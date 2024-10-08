using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StarterAssets;
using Unity.VisualScripting;
using MusicFilesNM;

public class PowerUp : MonoBehaviour
{
  [SerializeField] private GameObject PokerUp;
  private GameObject _music;
  private ThirdPersonController _thirdPersonController;

  private void Start()
  {
    _music = GameObject.Find("AudioManager");
    MusicPlayer _musicPlayer = _music.GetComponent(typeof(MusicPlayer)) as MusicPlayer;
    _thirdPersonController = GetComponent<ThirdPersonController>();
  }

  private void OnTriggerEnter(Collider other)
  {
    if (other.gameObject.CompareTag("PowerUp"))
    {
      PokerUp.SetActive(true);
      _thirdPersonController.SprintSpeed = 10f;
      Invoke("BacktoNormal", 3f);
    }
    
  }

  private void BacktoNormal()
  {
    PokerUp.SetActive(false);
    _thirdPersonController.SprintSpeed = 5.33f;
  }
  
}
