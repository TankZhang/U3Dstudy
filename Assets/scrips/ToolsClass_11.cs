using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToolsClass_11 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Debug.Log(Mathf.Max(5,10));
		//插值运算
		Debug.Log(Mathf.Lerp(0,10,0.2f));
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.A))
		{
			Debug.Log(Screen.width);
			Debug.Log(Screen.height);
		}
		//Debug.Log("时间"+Time.time);
		//Debug.Log(Time.deltaTime);
		//Time.timeScale=0;

		//差值0~10
		num = Mathf.Lerp(num,10,Time.deltaTime);
		Debug.Log(num);
	}
	private float num = 0;
}
