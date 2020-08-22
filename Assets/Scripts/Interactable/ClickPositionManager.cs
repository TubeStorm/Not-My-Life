using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickPositionManager : MonoBehaviour
{
    public static ClickPositionManager instance;
    public LayerMask clickMask;
    public Vector3 clickPosition;
    // Update is called once per frame
    void Start()
    {
        instance = this;
    }


    public Vector3 ClickPosition()
	{
        if (Input.GetMouseButtonDown(0))
        {
            clickPosition = -Vector3.one;


            //clickPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition + new Vector3 (0,0, 5f));
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;


            if (Physics.Raycast(ray, out hit, 200f, clickMask))
            {
                clickPosition = hit.point;
            }


            Debug.Log("click position: " + clickPosition);


        }
        return clickPosition;
    }
}
