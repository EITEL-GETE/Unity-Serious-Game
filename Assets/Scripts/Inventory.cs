using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public GameObject canvas;
    public GameObject joueur;
    public GameObject HUD;
    public KeyCode inventory = KeyCode.E;

    public bool open = false;

    bool temp = false;

    void Update()
    {
        if (Input.GetKeyDown(inventory) && !temp)
        {
            open = !open;
            temp = true;
        }

        if (Input.GetKeyUp(inventory))
        {
            temp = false;
        }

        canvas.SetActive(open);
        HUD.SetActive(!open);
        joueur.GetComponent<PlayerMouvement>().enabled = !open;
        joueur.GetComponent<Fire>().enabled = !open;
        joueur.GetComponent<MouseLook>().enabled = !open;
        joueur.GetComponent<Hand>().enabled = !open;

        if (open)
        {
            Cursor.lockState = CursorLockMode.None;
        }
        else
        {
            Cursor.lockState = CursorLockMode.Locked;
        }
    }
}
