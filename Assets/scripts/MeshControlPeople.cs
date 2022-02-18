using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MeshControlPeople : MonoBehaviour
{
    private Camera mainCamera;
    private NavMeshAgent agent;

    public GameObject model3d;
    ///public GameObject startPosition;
    public GameObject finishPosition;

    private Vector3 target;

    private void Start()
    {
        mainCamera = Camera.main;
        agent = GetComponent<NavMeshAgent>();
        ///model3d.transform.position = new Vector3(startPosition.transform.position.x, 0, startPosition.transform.position.z);
        target = new Vector3(finishPosition.transform.position.x, 0, finishPosition.transform.position.z);
    }

    private void Update()
    {
        agent.SetDestination(target);
    }
}
