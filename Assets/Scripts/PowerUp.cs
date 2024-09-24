using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StarterAssets;
using Unity.VisualScripting;

public class PowerUp : MonoBehaviour
{
  private ThirdPersonController _thirdPersonController;

  private void Start()
  {
    _thirdPersonController = GetComponent<ThirdPersonController>();
  }

  private void OnTriggerEnter(Collider other)
  {
    if (other.gameObject.CompareTag("PowerUp"))
    {
      _thirdPersonController.SprintSpeed = 10f;
    }
    
  }
}
