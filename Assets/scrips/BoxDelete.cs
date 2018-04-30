using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxDelete : MonoBehaviour {

	// Use this for initialization
	void Start () {
        GameObject.Destroy(gameObject, Random.Range(3.0f,7.0f));
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
