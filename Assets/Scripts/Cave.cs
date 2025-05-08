using UnityEngine;
using UnityEngine.SceneManagement;

public class Cave : MonoBehaviour
{

    private GameObject goDontDestroy;
    public int openNumberLevel;

    private void Start()
    {
        goDontDestroy = GameObject.Find("DontDestroy");
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "Player")
        {
            if (goDontDestroy.GetComponent<DontDestroy>().openLvl < openNumberLevel)
            {
                goDontDestroy.GetComponent<DontDestroy>().openLvl = openNumberLevel;
            }
            goDontDestroy.GetComponent<DontDestroy>().level = openNumberLevel;
            SceneManager.LoadScene("PreloaderLevel");
        }
    }
}
