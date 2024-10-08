using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinCollection : MonoBehaviour
{
    [SerializeField] private TMP_Text _text;
    private int count = 0;
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
         count++;
         _text.text = count.ToString();
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
