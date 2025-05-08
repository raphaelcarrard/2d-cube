using UnityEngine;
using UnityEngine.UI;

public class SoundButton : MonoBehaviour
{

    private DontDestroy dontDestroy;
    public Sprite soundOff;
    public Sprite soundOn;
    private Image thisImage;
    private GameObject mainCamera;

    private void Start()
    {
        dontDestroy = GameObject.Find("DontDestroy").GetComponent<DontDestroy>();
        thisImage = GetComponent<Image>();
        mainCamera = GameObject.Find("MainCamera");
        if (dontDestroy.sound)
        {
            thisImage.sprite = soundOn;
            dontDestroy.gameObject.GetComponent<AudioSource>().volume = 1f;
        }
        else
        {
            thisImage.sprite = soundOff;
            dontDestroy.gameObject.GetComponent<AudioSource>().volume = 0f;
        }
    }

    public void ClickForButtonSound()
    {
        if (dontDestroy.sound)
        {
            dontDestroy.sound = false;
            GetComponent<Image>().sprite = soundOff;
        }
        else
        {
            dontDestroy.sound = true;
            GetComponent<Image>().sprite = soundOn;
        }
        mainCamera.GetComponent<SoundManager>().CheckSound();
    }
}
