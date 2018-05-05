using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick_14 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		CheckUnderPlane();
	}

private void CheckUnderPlane()
{
	Transform m_trans = gameObject.GetComponent<Transform>();
	if(m_trans.position.y<-5)
	{
		GameObject.Destroy(gameObject);
	}
}
	private void OnTriggerEnter(Collider collider)
    {
        if(collider.gameObject.name.Contains("bullet"))
        {
            GameObject.Destroy(gameObject);
			GameObject.Destroy(collider.gameObject,1.0f);
        }
    }
}
