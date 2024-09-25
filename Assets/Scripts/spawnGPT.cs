using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnGPT : MonoBehaviour
{
    public GameObject objectToSpawn;     // Spawn edilecek prefab
    public Transform spawnPoint;         // Spawn noktasının referansı
    public float spawnRadius = 5.0f;     // Kontrol için yarıçap
    public LayerMask layerMask;          // Hangi layer’ları kontrol edeceğini belirlemek için

    void Start()
    {
        SpawnObject();  // Başlangıçta bir kere dene
    }

    public void SpawnObject()
    {
        // SpawnPoint'te hali hazırda bir obje olup olmadığını kontrol et
        Collider[] colliders = Physics.OverlapSphere(spawnPoint.position, spawnRadius, layerMask);

        if (colliders.Length == 0)
        {
            // Eğer hiç obje yoksa, spawn işlemini yap
            Instantiate(objectToSpawn, spawnPoint.position, spawnPoint.rotation);
            Debug.Log("Nesne spawn edildi!");
        }
        else
        {
            // Eğer varsa, spawn işlemini yapma
            Debug.Log("Spawn noktasında bir obje zaten var!");
        }
    }
}