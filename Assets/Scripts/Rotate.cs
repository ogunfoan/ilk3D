using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    [SerializeField] private float Speedx;
    [SerializeField] private float Speedy;
    [SerializeField] private float Speedz; 
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(360 * Time.deltaTime *Speedx,360 * Time.deltaTime *Speedy,360 * Time.deltaTime *Speedz);
    }
}
