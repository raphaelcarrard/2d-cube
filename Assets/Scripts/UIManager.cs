using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{

    public Text textCountDead;
    private DontDestroy dontDestroy;
    private void Start()
    {
        dontDestroy = GameObject.Find("DontDestroy").GetComponent<DontDestroy>();
        textCountDead.text = string.Empty + dontDestroy.countDead;
    }

    
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(1);
        }
    }
}
