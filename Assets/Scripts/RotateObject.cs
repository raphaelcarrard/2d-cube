using UnityEngine;

public class RotateObject : MonoBehaviour
{

    public bool x;
    public bool y;
    public bool z;
    public int speedRotate = 20;

    private void Update()
    {
        if (x)
        {
            base.transform.Rotate(new Vector3(0f, 0f, (float)speedRotate * Time.deltaTime));
        }
        else if (y)
        {
            base.transform.Rotate(new Vector3(0f, (float)speedRotate * Time.deltaTime, 0f));
        }
        else if (z)
        {
            base.transform.Rotate(new Vector3((float)speedRotate * Time.deltaTime, 0f, 0f));
        }
    }
}
