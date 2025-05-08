using UnityEngine;

public class DeadZonePlayer : MonoBehaviour
{

    private DontDestroy dontDestroy;

    private void Start()
    {
        dontDestroy = GameObject.Find("DontDestroy"). GetComponent<DontDestroy>();
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
    }
}
