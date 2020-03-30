using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    public GameObject weaponText;
    public int nWeapon = 2;

    public int weapon = 1;

    void Update()
    {
        if (Input.GetAxis("Mouse ScrollWheel") < 0)
        {
            if (weapon < nWeapon)
            {
                weapon++;
            }
            else
            {
                weapon = 1;
            }
        }

        if (Input.GetAxis("Mouse ScrollWheel") > 0)
        {
            if (weapon > 1)
            {
                weapon--;
            }
            else
            {
                weapon = nWeapon;
            }
        }

        // Choix de l'arme

        switch (weapon)
        {
            case 1:
                weaponText.GetComponent<UnityEngine.UI.Text>().text = "Pistol";
                break;
            case 2:
                weaponText.GetComponent<UnityEngine.UI.Text>().text = "Shotgun";
                break;
        }
    }
}
