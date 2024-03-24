using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class CharacterMovement : MonoBehaviour
{

    [SerializeField] private NavMeshAgent agent;
    private Camera camera;
    private Ray ray;
    private RaycastHit hit;

    private static readonly int _GROUND_LAYER = 1 << 6;

    public float speed = 5f;
    public Vector2 destination;

    private void Awake()
    {
        
        agent = GetComponent<NavMeshAgent>();
        camera = Camera.main;

    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ray = camera.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit, 1000f, _GROUND_LAYER))
            {
                agent.destination = hit.point;
            }
        }

    }

    void MoveToDestination()
    {
        transform.position = Vector2.MoveTowards(transform.position, destination, speed * Time.deltaTime);
    }
}
