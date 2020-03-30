using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Statsjoueur : MonoBehaviour {
    public Image vie;
    public float life, maxlife;







    // Start is called before the first frame update
    void Start()
    {
        life = maxlife;
        
    }

    // Update is called once per frame
    void Update()
    {
        vie.fillAmount = life / maxlife;
    }
}
