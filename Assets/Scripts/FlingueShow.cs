using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlingueShow : MonoBehaviour
{
    public float velocity = 1.0f;

    void Update()
    {
        gameObject.transform.eulerAngles += new Vector3(0, Time.deltaTime * velocity, 0);
    }
}
