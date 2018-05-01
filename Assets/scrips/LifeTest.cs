using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeTest : MonoBehaviour
{

    public GameObject prefabCube;
    private GameObject myCube;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            myCube = GameObject.Instantiate(prefabCube, Vector3.zero, Quaternion.identity) as GameObject;
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            GameObject.Destroy(myCube);
        }
    }
}
