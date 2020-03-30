using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public GameObject HUD;
    public GameObject inventory;
    public GameObject character;

    public KeyCode invKey = KeyCode.E;

    public bool open = false;

    void Update()
    {
        if (Input.GetKeyDown(invKey))
        {
            open = !open;
        }

        HUD.SetActive(!open);
        inventory.SetActive(open);

        character.GetComponent<PlayerMouvement>().enabled = !open;
        character.GetComponent<MouseLook>().enabled = !open;
        character.GetComponent<Fire>().enabled = !open;
        character.GetComponent<Hand>().enabled = !open;

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
