using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnManager : MonoBehaviour
{
    public GameObject objectToSpawn; // Spawn edilecek prefab (örneğin bir düşman karakteri)
    public Transform spawnPoint;     // Spawn noktasının referansı

    void Start()
    {
        SpawnObject();  // Oyunun başında spawn etmek istersen
        InvokeRepeating("SpawnObject", 2.0f, 5.0f);
    }

    public void SpawnObject()
    {
        Instantiate(objectToSpawn, spawnPoint.position, spawnPoint.rotation);
    }
}


