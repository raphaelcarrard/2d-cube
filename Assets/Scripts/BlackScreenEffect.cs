using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BlackScreenEffect : MonoBehaviour
{

    public float hitEffectTime;

    private void Start()
    {
        GetComponent<Image>().enabled = true;
        StartCoroutine(BlackScreen());
    }

    private IEnumerator BlackScreen()
    {
        yield return new WaitForSeconds(1E-05f);
        if (hitEffectTime >= 0f)
        {
            hitEffectTime -= 1f * Time.deltaTime;
            GetComponent<Image>().color = new Color(1f, 1f, 1f, hitEffectTime);
        }
        if (hitEffectTime > 0f)
        {
            StartCoroutine(BlackScreen());
        }
    }

    private IEnumerator BlackScreen2()
    {
        yield return new WaitForSeconds(0.001f);
        if (hitEffectTime <= 1f)
        {
            hitEffectTime += 1f * Time.deltaTime;
            GetComponent<Image>().color = new Color(1f, 1f, 1f, hitEffectTime);
        }
        if (hitEffectTime > 1f)
        {
            SceneManager.LoadScene(Application.loadedLevel);
        }
        StartCoroutine(BlackScreen2());
    }
}
