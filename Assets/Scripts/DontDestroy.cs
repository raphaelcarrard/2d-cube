using UnityEngine;
using UnityEngine.SceneManagement;
public class DontDestroy : MonoBehaviour
{

    public int openLvl;
    public int level;
    public int countDead;
    public bool sound;

    private void Awake()
    {
        LoadOffline();
        base.gameObject.name = "DontDestroy";
        Object.DontDestroyOnLoad(base.gameObject);
    }
    private void Start()
    {
        if (openLvl == 0)
        {
            openLvl = 1;
        }
        SceneManager.LoadScene("Menu");
    }

    public void SaveOffline()
    {
        PlayerPrefs.SetInt("OpenLvl", openLvl);
        PlayerPrefs.SetInt("CountDead", countDead);
    }

    public void LoadOffline()
    {
        openLvl = PlayerPrefs.GetInt("OpenLvl");
        countDead = PlayerPrefs.GetInt("CountDead");
    }
}
