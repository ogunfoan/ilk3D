using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollicionDetect : MonoBehaviour
{
    private int health = 3;
    [SerializeField] GameObject[] _healtUI;
    [SerializeField] private GameObject _gameOver;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("mermi"))
        {
            health--;
            _healtUI[health].gameObject.SetActive(false);
            Destroy(other.gameObject);
        }

        if (health==0)
        {
            _gameOver.SetActive(true);
            StartCoroutine(Fade());
        }
    }

    IEnumerator Fade()
    {
        yield return new WaitForSeconds(2f);
        Time.timeScale = 0;
    }
}
