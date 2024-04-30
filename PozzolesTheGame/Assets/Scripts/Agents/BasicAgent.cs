using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicAgent : MonoBehaviour
{
    SteeringBehaviours behaviours;

    [SerializeField] Vector3 eyesPos;
    [SerializeField] float eyesRadious;

    // Start is called before the first frame update
    void Start()
    {
        behaviours = new SteeringBehaviours();        
    }

    private void FixedUpdate()
    {
        PerceptionManager();
    }

    private void PerceptionManager()
    {
        EyesPerception();
    }
    
    void EyesPerception()
    {
        Collider[] agentsViewed = Physics.OverlapSphere(eyesPos, eyesRadious);
        foreach (Collider agent in agentsViewed)
        {
            if (agent.CompareTag("Agent"))
            {

            }
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(eyesPos, eyesRadious);
    }
}
