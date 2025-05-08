using System.Collections;
using UnityEngine;

public class InstanceObjectTimer : MonoBehaviour
{

    public float time;
    public GameObject obj;
    private void Start()
    {
        StartCoroutine(Timer());
    }

    private IEnumerator Timer()
    {
        yield return new WaitForSeconds(time);
        Object.Instantiate(obj, base.transform.position, base.transform.rotation);
        StartCoroutine(Timer());
    }

    public void AganeStart()
    {
        StartCoroutine(Timer());
    }
}
