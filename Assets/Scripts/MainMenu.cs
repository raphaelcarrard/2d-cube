using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class MainMenu : MonoBehaviour
{

    private DontDestroy dontDestroy;
    public Image[] levelsImage;

    private void Start()
    {
        dontDestroy = GameObject.Find("DontDestroy").GetComponent<DontDestroy>();
        UpdateUI();
    }

    private void Update()
    {
    }

    public void UpdateUI()
    {
        if (dontDestroy.openLvl <= 12)
        {
            for (int i = 0; i < dontDestroy.openLvl; i++)
            {
                levelsImage[i].color = new Color32(byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue);
            }
        }
        else if (dontDestroy.openLvl > 12)
        {
            for (int j = 0; j < 12; j++)
            {
                levelsImage[j].color = new Color32(byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue);
            }
        }
    }

    public void Level1()
    {
        dontDestroy.level = 1;
        SceneManager.LoadScene("PreloaderLevel");
    }

    public void Level2()
    {
        if (dontDestroy.openLvl >= 2)
        {
            dontDestroy.level = 2;
            SceneManager.LoadScene("PreloaderLevel");
        }
    }
    public void Level3()
    {
        if (dontDestroy.openLvl >= 3)
        {
            dontDestroy.level = 3;
            SceneManager.LoadScene("PreloaderLevel");
        }
    }

    public void Level4()
    {
        if (dontDestroy.openLvl >= 4)
        {
            dontDestroy.level = 4;
            SceneManager.LoadScene("PreloaderLevel");
        }
    }

    public void Level5()
    {
        if (dontDestroy.openLvl >= 5)
        {
            dontDestroy.level = 5;
            SceneManager.LoadScene("PreloaderLevel");
        }
    }

    public void Level6()
    {
        if (dontDestroy.openLvl >= 6)
        {
            dontDestroy.level = 6;
            SceneManager.LoadScene("PreloaderLevel");
        }
    }

    public void Level7()
    {
        if (dontDestroy.openLvl >= 7)
        {
            dontDestroy.level = 7;
            SceneManager.LoadScene("PreloaderLevel");
        }
    }

    public void Level8()
    {
        if (dontDestroy.openLvl >= 8)
        {
            dontDestroy.level = 8;
            SceneManager.LoadScene("PreloaderLevel");
        }
    }

    public void Level9()
    {
        if (dontDestroy.openLvl >= 9)
        {
            dontDestroy.level = 9;
            SceneManager.LoadScene("PreloaderLevel");
        }
    }

    public void Level10()
    {
        if (dontDestroy.openLvl >= 10)
        {
            dontDestroy.level = 10;
            SceneManager.LoadScene("PreloaderLevel");
        }
    }

    public void Level11()
    {
        if (dontDestroy.openLvl >= 11)
        {
            dontDestroy.level = 11;
            SceneManager.LoadScene("PreloaderLevel");
        }
    }

    public void Level12()
    {
        if (dontDestroy.openLvl >= 12)
        {
            dontDestroy.level = 12;
            SceneManager.LoadScene("PreloaderLevel");
        }
    }

    public void ExitGame()
    {
        #if UNITY_EDITOR
        dontDestroy.SaveOffline();
        EditorApplication.isPlaying = false;
        #elif UNITY_WEBGL
        dontDestroy.SaveOffline();
        SceneManager.LoadScene("ThanksForPlaying");
        #else
        dontDestroy.SaveOffline();
        Application.Quit();
        #endif
    }
}
