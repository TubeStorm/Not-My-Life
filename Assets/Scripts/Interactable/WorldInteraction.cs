using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine;

public class WorldInteraction : MonoBehaviour
{
	public static WorldInteraction instance;

    public UnityEngine.AI.NavMeshAgent playerAgent;
	protected FloatingJoystick joystick;
	protected FloatingJoystick joystick2;
	protected FloatingJoystick joystick3;

	public Rigidbody rigidbody;
	public Rigidbody playerBase;
	public Vector3 velocity1;
    float m_Speed = 10f;
	private float rotX = 0f;
	private float rotY = 0f;
	Transform MainCamera;
	public Animator anim;


	static protected float distanceTraveled;


	void Start()
	{
		instance = this;
		playerAgent = GetComponent<UnityEngine.AI.NavMeshAgent>();

		//find things in scene
		joystick = GameObject.Find("FloatingJoystick").GetComponent<FloatingJoystick>();
		joystick2 = GameObject.Find("FloatingJoystick2").GetComponent<FloatingJoystick>();
		joystick3 = GameObject.Find("FloatingJoystick3").GetComponent<FloatingJoystick>();

		MainCamera = Camera.main.transform;

	}

	void Update()
	{
		//get movement from 
		velocity1 = new Vector3(joystick.Horizontal * m_Speed, rigidbody.velocity.y, joystick.Vertical * m_Speed);
		rigidbody.velocity = velocity1;

		Debug.Log("SUUUUUP");


		//rotation player and camera
		var input = new Vector3(joystick2.Horizontal/40, 0, joystick2.Vertical/40);
		if (input != Vector3.zero)
		{
			rigidbody.transform.forward += input;
		}

		//rotate camera up or down
		var input2 = new Vector3(0, 0, joystick3.Vertical/30);
		input2 += new Vector3(0, 0, joystick2.Vertical / 40);//makes it swing
		if (input2 != Vector3.zero)
		{

			MainCamera.transform.up += input2; 

		}


		anim.SetFloat("velocity", velocity1[2]);


		if (Input.GetMouseButtonDown(0) && !UnityEngine.EventSystems.EventSystem.current.IsPointerOverGameObject())
		{
			GetInteraction();
		}
	}



	//grabs the camera, sends out a ray and figures out what is clicked on.
	void GetInteraction()
	{
		Ray interactionRay = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit interactionInfo;
		if (Physics.Raycast(interactionRay, out interactionInfo, Mathf.Infinity)) 
		{
			GameObject interactedObject = interactionInfo.collider.gameObject;

            if(interactedObject.tag == "Interactable Object" || interactedObject.tag == "Vending Machine" || interactedObject.tag == "Taxi")
			{
				//interactedObject.GetComponent<Interactable>().MoveToInteraction(playerAgent);
				Debug.Log("Object is from World interacted");
			}
			else
			{
				
				distanceTraveled = DistanceTraveled();
				Debug.Log("The distance to this poistion is: " + distanceTraveled);
			}
		}

	}



    float DistanceTraveled()
	{
		return Vector3.Distance(playerAgent.destination, ClickPositionManager.instance.ClickPosition());
	}


	/*------------------------------------------------------------------------------------
	//---------------------------------SAVING SCENE DATA-----------------------------------
	/------------------------------------------------------------------------------------*/

	void OnDestroy()
	{
	}

	/*---------------------------STATS GETTERS AND SETTERS---------------------------*/

	public static float GetDistance()
	{
		return distanceTraveled;
	}

	public static void SetDistance(float value)
	{
		distanceTraveled = value;
	}

	

}

