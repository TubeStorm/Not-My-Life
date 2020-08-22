using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    public UnityEngine.AI.NavMeshAgent playerAgent;
    private bool hasInteracted;

    //move player to the interactable object and then interact with it (talk, pick up etc)
    public virtual void MoveToInteraction(UnityEngine.AI.NavMeshAgent playerAgent)
	{
        hasInteracted = false;
        this.playerAgent = playerAgent; //set the one outside to the one in the parameters
        playerAgent.stoppingDistance = 2f;
        playerAgent.destination = this.transform.position;

	}

    void Update()
	{
        if (!hasInteracted && playerAgent != null && !playerAgent.pathPending)
		{
			if (playerAgent.remainingDistance <= playerAgent.stoppingDistance) //calculates distance left
			{
                Interact();
                hasInteracted = true;
			}
		}
	}

    public virtual void Interact()
	{
        Debug.Log("Interacting with Interactable Object");
	}
}
