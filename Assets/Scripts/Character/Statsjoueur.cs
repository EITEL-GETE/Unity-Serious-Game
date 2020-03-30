using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Statsjoueur : MonoBehaviour {

    public GameObject vie;
    public float maxlife = 100.0f;
    float maxScale;
    float life;

    public KeyCode test = KeyCode.P;

    void Start()
    {
        life = maxlife;
        maxScale = vie.transform.localScale.x;
    }

    void Update()
    {
        if (Input.GetKeyDown(test) && life > 0)
        {
            life -= 10;
        }

        vie.transform.localScale = new Vector3(maxScale * life / maxlife, maxScale, maxScale);

        if (life < 0)
        {
            life = 0;
        }
    }
}
