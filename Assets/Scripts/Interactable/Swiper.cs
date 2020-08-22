using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine;
using UnityEngine.UI;

public class Swiper : MonoBehaviour
{
	public static Swiper instance;
	private Touch initTouch = new Touch();
	public Camera cam;

	private float rotX = 0f;
	private float rotY = 0f;
	private Vector3 origRot;

	public float rotSpeed = 0.5f;
	public float dir = -1;



	// Start is called before the first frame update
	void Start()
	{
		instance = this;
		origRot = cam.transform.eulerAngles;
		rotX = origRot.x;
		rotY = origRot.y;
	}

	// Update is called once per frame
	public void FixedUpdate()
	{

		foreach (Touch touch in Input.touches)
		{

			//if (!IsPointerOverGameObject(touch.fingerId))
			//{
				if (touch.phase == TouchPhase.Began)
				{
					initTouch = touch;
				}
				else if (touch.phase == TouchPhase.Moved)
				{
					//swiping
					float deltaX = initTouch.position.x - touch.position.x;
					float deltaY = initTouch.position.y - touch.position.y;
					rotY -= deltaX * Time.deltaTime * rotSpeed * dir;
					rotX += deltaY * Time.deltaTime * rotSpeed * dir;
					rotX = Mathf.Clamp(rotX, -20f, 20f);
					//rotY = Mathf.Clamp(rotY, -20f, 20f);
					WorldInteraction.instance.playerBase.transform.localEulerAngles = new Vector3(0, rotY, 0);

					cam.transform.eulerAngles = new Vector3(rotX, rotY, 0f);
				}
				else if (touch.phase == TouchPhase.Ended)
				{
					initTouch = new Touch();
				}

			//}
		}
	}
}