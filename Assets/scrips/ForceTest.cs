using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForceTest : MonoBehaviour {

    private Rigidbody m_rigidbody;

	// Use this for initialization
	void Start () {
        m_rigidbody = gameObject.GetComponent<Rigidbody>();

	}
	
	// Update is called once per frame
	void Update () {       
    }

    //update按帧算，卡顿时候不执行，但是该函数是按时间固定调用的
    void FixedUpdate()
    {
        //m_rigidbody.AddForce(Vector3.forward*50, ForceMode.Force); 
        if (Input.GetKeyDown(KeyCode.Z))
        {
            m_rigidbody.AddRelativeForce(Vector3.forward * 10, ForceMode.Force);
        }
    }
}
