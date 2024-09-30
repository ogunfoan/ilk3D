using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollection : MonoBehaviour
{
    private AudioSource _audioSource;
    private void Start()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("coin"))
        {
         //Destroy(other.gameObject);
         other.gameObject.SetActive(false); // görünürlüğünü kapattık
         _audioSource.Play();
         StartCoroutine(Spawn(other.gameObject));
        }
    }

    IEnumerator Spawn(GameObject gameObject)
    {
        yield return new WaitForSeconds(100);
        gameObject.SetActive(true);
    }
    
}
