using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour {

    private Rigidbody m_rigidbody;
    private Transform m_transform;
    public GameObject m_gameObject;

	// Use this for initialization
	void Start () {
        m_rigidbody = gameObject.GetComponent<Rigidbody>();
        m_transform = gameObject.GetComponent<Transform>();
    }
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.W))
        {
            m_rigidbody.MovePosition(m_transform.position + Vector3.forward * 0.2f);
        }
        if (Input.GetKey(KeyCode.A))
        {
            m_rigidbody.MovePosition(m_transform.position + Vector3.left * 0.2f);
        }
        if (Input.GetKey(KeyCode.S))
        {
            m_rigidbody.MovePosition(m_transform.position + Vector3.back * 0.2f);
        }
        if (Input.GetKey(KeyCode.D))
        {
            m_rigidbody.MovePosition(m_transform.position + Vector3.right * 0.2f);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            m_rigidbody.MovePosition(m_transform.position + Vector3.up*0.5f);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Box")
        {
            Vector3 position = collision.gameObject.transform.position;
            GameObject.Destroy(collision.gameObject);
            Instantiate(m_gameObject, position + Vector3.up, Quaternion.identity);
        }
    }

    private void OnTriggerEnter(Collider collider)
    {
        if(collider.gameObject.tag == "Gold")
        {
            collider.gameObject.SendMessage("AddScore");
            GameObject.Destroy(collider.gameObject);
        }
    }
}
