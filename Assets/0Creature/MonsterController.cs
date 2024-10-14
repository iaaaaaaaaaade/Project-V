using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityStandardAssets.Characters.ThirdPerson;

public class MonsterController : MonoBehaviour
{
    public Camera Camera;
    public NavMeshAgent agent;
    public ThirdPersonCharacter character;

    void Start()
    {
        agent.updateRotation = false;   
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0)){
            Ray ray = Camera.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out RaycastHit hit))
            {
                agent.SetDestination(hit.point);
            }
        }
        if (agent.remainingDistance>agent.stoppingDistance)
        {
            character.Move(agent.desiredVelocity, false, false);
        }else
        {
            character.Move(Vector3.zero, false, false);
        }
    }
}
