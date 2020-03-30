using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    public GameObject bullet;
    public Transform spawnPoint;

    public GameObject soundPistol;
    public GameObject soundShotgun;

    bool temp = false;

    void Update()
    {
        if ( Input.GetButtonDown("Fire1") && !temp)
        {
            switch (GameObject.Find("Character").GetComponent<Inventory>().weapon)
            {
                case 1:
                    Instantiate(bullet, spawnPoint.position, spawnPoint.rotation * Quaternion.Euler(0, 0, 0), gameObject.transform);

                    soundPistol.GetComponent<AudioSource>().Play();
                    break;
                case 2:
                    Instantiate(bullet, spawnPoint.position, spawnPoint.rotation * Quaternion.Euler(0, Random.Range(-20f, 20f), 0), gameObject.transform);
                    Instantiate(bullet, spawnPoint.position, spawnPoint.rotation * Quaternion.Euler(0, Random.Range(-20f, 20f), 0), gameObject.transform);
                    Instantiate(bullet, spawnPoint.position, spawnPoint.rotation * Quaternion.Euler(0, Random.Range(-20f, 20f), 0), gameObject.transform);
                    Instantiate(bullet, spawnPoint.position, spawnPoint.rotation * Quaternion.Euler(0, Random.Range(-20f, 20f), 0), gameObject.transform);
                    Instantiate(bullet, spawnPoint.position, spawnPoint.rotation * Quaternion.Euler(0, Random.Range(-20f, 20f), 0), gameObject.transform);

                    soundShotgun.GetComponent<AudioSource>().Play();
                    break;
            }
            temp = true;
        }

        if (Input.GetButtonUp("Fire1"))
        {
            temp = false;
        }
    }
}
