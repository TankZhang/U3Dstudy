using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeskTriggers : MonoBehaviour {

    private GameObject[] mDesk;
    private bool upFlag;

	// Use this for initialization
	void Start () {
        upFlag = false;
        mDesk = GameObject.FindGameObjectsWithTag("Desks");
    }
	
	// Update is called once per frame
	void Update () {

	}

    private void OnTriggerEnter(Collider collider)
    {
        if(collider.name == "Student")
        {
            DeskOperate();
        }
    }

    private void OnTriggerExit(Collider collider)
    {
        if (collider.name == "Student")
        {
            DeskOperate();
        }
    }

    void DeskOperate()
    {
        upFlag = !upFlag;
        foreach (GameObject item in mDesk)
        {
            item.GetComponent<Transform>().Translate(upFlag?Vector3.up*2: Vector3.down  * 2, Space.Self);
        }
    }
}