using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    //Is trigger勾选后会将collider变为触发器
    private void OnTriggerEnter(Collider coll)
    {
        Debug.Log("Wall trigger enter with" + coll.gameObject.name);
    }

    //Is trigger勾选后会将collider变为触发器
    private void OnTriggerExit(Collider coll)
    {
        Debug.Log("Wall trigger exit with" + coll.gameObject.name);
    }

    //Is trigger勾选后会将collider变为触发器
    private void OnTriggerStay(Collider coll)
    {
        Debug.Log("Wall trigger stay with" + coll.gameObject.name);
    }
}
