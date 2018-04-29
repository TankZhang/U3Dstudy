﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigidBodyMove : MonoBehaviour {

    private Rigidbody m_rigid;
    private Transform m_transform;

	// Use this for initialization
	void Start () {
        m_rigid = gameObject.GetComponent<Rigidbody>();
        m_transform = gameObject.GetComponent<Transform>();
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKey(KeyCode.A))
        {
            m_rigid.MovePosition(m_transform.position + Vector3.left*0.1f);
        }

        if (Input.GetKey(KeyCode.W))
        {
            m_rigid.MovePosition(m_transform.position + Vector3.forward * 0.1f);
        }

        if (Input.GetKey(KeyCode.S))
        {
            m_rigid.MovePosition(m_transform.position + Vector3.back * 0.1f);
        }

        if (Input.GetKey(KeyCode.D))
        {
            m_rigid.MovePosition(m_transform.position + Vector3.right * 0.1f);
        }

    }
}
