using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputTest : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.A))
        {
            Debug.Log("A...");
        }

        if(Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log("A Down...");
        }

        if(Input.GetKeyUp(KeyCode.A))
        {
            Debug.Log("A UP...");
        }

        if(Input.GetMouseButton(0))
        {
            Debug.Log("Mouseleft...");
        }
	}
}
