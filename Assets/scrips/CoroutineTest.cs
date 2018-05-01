using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoroutineTest : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        Debug.Log("Task1");
        Debug.Log("Task2");
        StartCoroutine("Task");
        Debug.Log("Task4");
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.C))
        {
            StopCoroutine("Task");
        }
    }

    IEnumerator Task()
    {
        yield return new WaitForSeconds(2);
        Debug.Log("Task3");
        yield return new WaitForSeconds(2);
        Debug.Log("Task5");
    }

    //void Task3()
    //{
    //    Debug.Log("Task3");
    //}
}
