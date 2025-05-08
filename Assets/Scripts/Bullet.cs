using UnityEngine;

public class Bullet : MonoBehaviour
{

    public bool left;
    public bool right;
    public bool up;
    public bool down;
    public float speed;
    private DontDestroy dontDestroy;

    private void Start()
    {
        dontDestroy = GameObject.Find("DontDestroy").GetComponent<DontDestroy>();
    }

    
    private void FixedUpdate()
    {
        if (left) {
            base.transform.Translate(Vector2.left * speed);
        }
        else if (right)
        {
            base.transform.Translate(Vector2.right * speed);
        }
        else if (up)
        {
            base.transform.Translate(Vector2.up * speed);
        }
        else if (down)
        {
            base.transform.Translate(Vector2.down * speed);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "Player")
        {
            if (!other.gameObject.GetComponent<Player>().dead)
            {
                dontDestroy.countDead++;
            }
            other.gameObject.GetComponent<Player>().Dead();
        }
        else if (other.tag == "Wall")
        {
            Object.Destroy(base.gameObject);
        }
        else if (other.tag == "WoodBox")
        {
            other.gameObject.GetComponent<BoxTrigger>().Destroy();
            Object.Destroy(base.gameObject);
        }
    }
}
