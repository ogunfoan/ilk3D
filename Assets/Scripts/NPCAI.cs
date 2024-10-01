using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NPCAI : MonoBehaviour
{
    [SerializeField] private GameObject destination;

    private NavMeshAgent _aget;
    // Start is called before the first frame update
    void Start()
    {
        _aget = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        _aget.SetDestination(destination.transform.position);
    }
}
