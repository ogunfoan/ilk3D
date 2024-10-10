using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MermiYokEdici : MonoBehaviour
{
    private void Update()
    {
        Invoke("Yoket",20f);
    }

    private void Yoket()
    {
        Destroy(gameObject);
    }
}
