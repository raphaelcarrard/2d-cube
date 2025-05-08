using UnityEngine;
using UnityEngine.SceneManagement;

public class PreloadLevels : MonoBehaviour
{

    public string levelName;
    private float roundLoad;
    private bool oneActiv;
    private bool one_Activ;
    private GameObject dontGo;

    private void Awake()
    {
        dontGo = GameObject.Find("DontDestroy");
    }

    private void Start()
    {
        if (dontGo.GetComponent<DontDestroy>().level == 1)
        {
            if (dontGo.GetComponent<DontDestroy>().openLvl >= 1)
            {
                NGHelper.instance.unlockMedal(84429);
            }
            levelName = "Level1";
        }
        if (dontGo.GetComponent<DontDestroy>().level == 2)
        {
            if (dontGo.GetComponent<DontDestroy>().openLvl >= 2)
            {
                NGHelper.instance.unlockMedal(84430);
            }
            levelName = "Level2";
        }
        if (dontGo.GetComponent<DontDestroy>().level == 3)
        {
            if (dontGo.GetComponent<DontDestroy>().openLvl >= 3)
            {
                NGHelper.instance.unlockMedal(84431);
            }
            levelName = "Level3";
        }
        if (dontGo.GetComponent<DontDestroy>().level == 4)
        {
            if (dontGo.GetComponent<DontDestroy>().openLvl >= 4)
            {
                NGHelper.instance.unlockMedal(84432);
            }
            levelName = "Level4";
        }
        if (dontGo.GetComponent<DontDestroy>().level == 5)
        {
            if (dontGo.GetComponent<DontDestroy>().openLvl >= 5)
            {
                NGHelper.instance.unlockMedal(84433);
            }
            levelName = "Level5";
        }
        if (dontGo.GetComponent<DontDestroy>().level == 6)
        {
            if (dontGo.GetComponent<DontDestroy>().openLvl >= 6)
            {
                NGHelper.instance.unlockMedal(84434);
            }
            levelName = "Level6";
        }
        if (dontGo.GetComponent<DontDestroy>().level == 7)
        {
            if (dontGo.GetComponent<DontDestroy>().openLvl >= 7)
            {
                NGHelper.instance.unlockMedal(84435);
            }
            levelName = "Level7";
        }
        if (dontGo.GetComponent<DontDestroy>().level == 8)
        {
            if (dontGo.GetComponent<DontDestroy>().openLvl >= 8)
            {
                NGHelper.instance.unlockMedal(84436);
            }
            levelName = "Level8";
        }
        if (dontGo.GetComponent<DontDestroy>().level == 9)
        {
            if (dontGo.GetComponent<DontDestroy>().openLvl >= 9)
            {
                NGHelper.instance.unlockMedal(84437);
            }
            levelName = "Level9";
        }
        if (dontGo.GetComponent<DontDestroy>().level == 10)
        {
            if (dontGo.GetComponent<DontDestroy>().openLvl >= 10)
            {
                NGHelper.instance.unlockMedal(84438);
            }
            levelName = "Level10";
        }
        if (dontGo.GetComponent<DontDestroy>().level == 11)
        {
            if (dontGo.GetComponent<DontDestroy>().openLvl >= 11)
            {
                NGHelper.instance.unlockMedal(84439);
            }
            levelName = "Level11";
        }
        if (dontGo.GetComponent<DontDestroy>().level == 12)
        {
            if (dontGo.GetComponent<DontDestroy>().openLvl >= 12)
            {
                NGHelper.instance.unlockMedal(84440);
            }
            levelName = "Level12";
        }
        if (dontGo.GetComponent<DontDestroy>().level == 13)
        {
            if (dontGo.GetComponent<DontDestroy>().openLvl >= 13)
            {
                NGHelper.instance.unlockMedal(84441);
            }
            levelName = "Menu";
        }
        dontGo.GetComponent<DontDestroy>().SaveOffline();
        SceneManager.LoadScene(string.Empty + levelName);
    }
}
