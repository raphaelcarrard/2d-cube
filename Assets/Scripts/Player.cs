using UnityEngine;
using UnityEngine.SceneManagement;
using UnityStandardAssets.CrossPlatformInput;

public class Player : MonoBehaviour
{

    private Rigidbody2D rg;
    public float maxSpeed = 10f;
    private bool isFacingRight = true;
    public bool isGrounded;
    public Transform groundCheck;
    private float groundRadius = 0.03f;
    public LayerMask whatIsGround;
    public bool flipRight;
    public bool dead;
    public int nowKeys;
    private GameObject blackScreen;

    public Animator anim;
    private string[] secretCode;
    private int index;

    private void Awake()
    {
        blackScreen = GameObject.Find("BlackScreen");
    }
    private void Start()
    {
        rg = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        anim.SetBool("IdleRight", true);
        anim.SetBool("IdleLeft", false);
        anim.SetBool("WalkRight", false);
        anim.SetBool("WalkLeft", false);
        secretCode = new string[] { "r", "a", "p", "h", "a" };
        index = 0;
    }

    
    private void Update()
    {
        if(!dead && isGrounded && (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W) || CrossPlatformInputManager.GetButtonDown("Jump"))){
            Debug.Log("Up");
            rg.AddForce(new Vector2(0f, 10000f));
        }
        Vector2 vector = new Vector2(CrossPlatformInputManager.GetAxis("Horizontal") * maxSpeed * Time.deltaTime, CrossPlatformInputManager.GetAxis("Vertical") * maxSpeed * Time.deltaTime);
        if (vector.x > 0f)
        {
            if (GetComponent<SpriteRenderer>().flipX)
            {
                GetComponent<SpriteRenderer>().flipX = false;
                anim.SetBool("WalkRight", true);
                anim.SetBool("WalkLeft", false);
            }
        }
        else if (vector.x < 0f && !GetComponent<SpriteRenderer>().flipX)
        {
            GetComponent<SpriteRenderer>().flipX = true;
            anim.SetBool("WalkRight", false);
            anim.SetBool("WalkLeft", true);
        }
        if (vector.x == 0f)
        {
            anim.SetBool("IdleRight", true);
            anim.SetBool("IdleLeft", false);
            anim.SetBool("WalkRight", false);
            anim.SetBool("WalkLeft", false);
        }
        if (Input.anyKeyDown)
        {
            if (Input.GetKeyDown(secretCode[index]))
            {
                index++;
            }
            else
            {
                index = 0;
            }
        }

        if (index == secretCode.Length)
        {
            NGHelper.instance.unlockMedal(84478);
            anim.enabled = true;
            index = 0;
        }
    }

    private void FixedUpdate()
    {
        if (dead)
        {
            anim.SetBool("Dead", true);
            anim.SetBool("IdleRight", false);
            anim.SetBool("IdleLeft", false);
            anim.SetBool("WalkRight", false);
            anim.SetBool("WalkLeft", false);
            return;
        }
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundRadius, whatIsGround);
        float axis = Input.GetAxis("Horizontal");
        rg.linearVelocity = new Vector2(axis * maxSpeed, rg.linearVelocity.y);
        if (axis > 0f)
        {
            if (GetComponent<SpriteRenderer>().flipX)
            {
                GetComponent<SpriteRenderer>().flipX = false;
                anim.SetBool("WalkRight", true);
                anim.SetBool("WalkLeft", false);
                if (axis == 0f)
                {
                    anim.SetBool("IdleRight", true);
                    anim.SetBool("IdleLeft", false);
                    anim.SetBool("WalkRight", false);
                    anim.SetBool("WalkLeft", false);
                }
            }
        }
        else if (axis < 0f && !GetComponent<SpriteRenderer>().flipX)
        {
            GetComponent<SpriteRenderer>().flipX = true;
            anim.SetBool("WalkRight", false);
            anim.SetBool("WalkLeft", true);
        }
    }

    private void Flip()
    {
        isFacingRight = !isFacingRight;
        Vector3 localScale = base.transform.localScale;
        localScale.x *= -1f;
        base.transform.localScale = localScale;
    }

    public void Dead()
    {
        dead = true;
        blackScreen.GetComponent<BlackScreenEffect>().StopAllCoroutines();
        blackScreen.GetComponent<BlackScreenEffect>().StartCoroutine("BlackScreen2");
    }
}
