using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Module : MonoBehaviour
{
    public GameObject moduleInv;
    public GameObject moduleNiv;

    public bool placed = false;

    void Start()
    {
        gameObject.GetComponent<UnityEngine.UI.Button>().onClick.AddListener(Place);
    }

    void Place()
    {
        placed = !placed;
    }

    void Update()
    {
        moduleInv.SetActive(placed);
        moduleNiv.SetActive(placed);
    }
}
