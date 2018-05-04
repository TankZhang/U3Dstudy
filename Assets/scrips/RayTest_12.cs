using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayTest_12 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		SendRay();
	}
	
	// Update is called once per frame
	void Update () {
	}
	private Ray ray;
	private RaycastHit raycast;

	void SendRay()
	{
		//按下鼠标左键发射射线，打中了就销毁
		if(Input.GetMouseButtonDown(0))
		{
			ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			if(Physics.Raycast(ray, out raycast))
			{
				GameObject.Destroy(raycast.collider.gameObject);
			}
		}
	}
}
