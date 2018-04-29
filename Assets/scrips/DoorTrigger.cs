using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrigger : MonoBehaviour {

    private Door m_Door;
	// Use this for initialization
	void Start ()
    {
        m_Door = GameObject.Find("DoorPar").GetComponent<Door>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider collider)
    {
        if(collider.gameObject.name == "Student")
        {
            m_Door.DoorOperation();
        }
    }

    private void OnTriggerExit(Collider collider)
    {
        if (collider.gameObject.name == "Student")
        {
            m_Door.DoorOperation();
        }
    }
}
