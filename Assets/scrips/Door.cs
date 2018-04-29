using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour {

    private Transform m_transform;
    private bool doorOpenFlag;

	// Use this for initialization
	void Start () {
        doorOpenFlag = false;
        m_transform = gameObject.GetComponent<Transform>();        
    }
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.E))
        {
            DoorOperation();
        }
    }

    public void DoorOperation()
    {
        doorOpenFlag = !doorOpenFlag;
        m_transform.Rotate(Vector3.up, (doorOpenFlag ? -90 : 90));
    }
}
