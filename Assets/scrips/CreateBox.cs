using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateBox : MonoBehaviour {

    public GameObject goPrefab;

	// Use this for initialization
	void Start ()
    {
        //InvokeRepeating("CreateMoreBox", 3.0f, 3.0f);
        InvokeRepeating("CreateMoreBox", 3.0f, 3.0f);
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Z))
        {
            CancelInvoke();
        }
	}

    void CreateMoreBox()
    {
        for (int i = 0; i < 5; i++)
        {
            Vector3 vector3 = new Vector3(Random.Range(-3.0f, 3.0f), 1, Random.Range(-3.0f, 3.0f));
            GameObject.Instantiate(goPrefab, vector3, Quaternion.identity);
        }
    }
}
