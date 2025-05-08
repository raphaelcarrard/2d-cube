using UnityEngine;

public class BoxTrigger : MonoBehaviour
{
    public GameObject brakeBox;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "Saw")
        {
            Object.Instantiate(brakeBox, base.transform.position, base.transform.rotation);
            Object.Destroy(base.gameObject);
        }
    }

    public void Destroy()
    {
        Object.Instantiate(brakeBox, base.transform.position, base.transform.rotation);
        Object.Destroy(base.gameObject);
    }
}
