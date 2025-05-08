using UnityEngine;

public class SoundManager : MonoBehaviour
{

    private DontDestroy dontDestroy;

    private void Awake()
    {
        dontDestroy = GameObject.Find("DontDestroy").GetComponent<DontDestroy>();
        CheckSound();
    }

    public void CheckSound()
    {
        if (dontDestroy.sound)
        {
            GetComponent<AudioListener>().enabled = true;
            dontDestroy.gameObject.GetComponent<AudioSource>().volume = 1f;
        }
        else if (!dontDestroy.sound)
        {
            GetComponent<AudioListener>().enabled = false;
            dontDestroy.gameObject.GetComponent<AudioSource>().volume = 0f;
        }
    }

}
