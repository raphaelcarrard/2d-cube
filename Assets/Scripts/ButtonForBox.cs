using UnityEngine;

public class ButtonForBox : MonoBehaviour
{

    public bool buttonPressed;
    public SpriteRenderer[] powerCable;
    public GameObject turret;
    public GameObject turretPointFire;

    private void OnTriggerStay2D(Collider2D other)
    {
        if(!(other.name == "Box") && !(other.name == "Player") && !(other.name == "MetalBox"))
        {
            return;
        }
        buttonPressed = true;
        if (buttonPressed)
        {
            for (int i = 0; i < powerCable.Length; i++)
            {
                powerCable[i].color = new Color32(62, 62, 62, byte.MaxValue);
            }
            turret.GetComponent<SpriteRenderer>().color = new Color32(62, 62, 62, byte.MaxValue);
            turretPointFire.SetActive(false);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (!(other.name == "Box") && !(other.name == "Player") && !(other.name == "MetalBox"))
        {
            return;
        }
        buttonPressed = false;
        if (!buttonPressed)
        {
            for (int i = 0; i < powerCable.Length; i++)
            {
                powerCable[i].color = new Color32(byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue);
            }
            turret.GetComponent<SpriteRenderer>().color = new Color32(byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue);
            turretPointFire.SetActive(true);
            turretPointFire.GetComponent<InstanceObjectTimer>().AganeStart();
        }
    }
}
