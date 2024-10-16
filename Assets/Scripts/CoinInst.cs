using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject objectToSpawn; // Spawn edilecek prefab (örneğin bir düşman karakteri)
    public Transform spawnPoint;     // Spawn noktasının referansı

    void Start()
    {
        SpawnObject();  // Oyunun başında spawn etmek istersen
    }

    public void SpawnObject()
    {
        Instantiate(objectToSpawn, spawnPoint.position, spawnPoint.rotation);
    }
}