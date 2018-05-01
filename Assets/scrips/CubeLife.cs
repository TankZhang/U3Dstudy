using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeLife : MonoBehaviour {

    private void Awake()
    {
        Debug.Log("awake");
    }
    private void OnEnable()
    {
        Debug.Log("Onenable");
    }
    private void Start()
    {
        Debug.Log("Start");
    }
    private void FixedUpdate()
    {
        Debug.Log("fixedUpdate");
    }

    private void Update()
    {
        Debug.Log("Update");
    }
    private void LateUpdate()
    {
        Debug.Log("lateUpdate");
    }
    private void OnGUI()
    {
        Debug.Log("OnGui");
    }
    private void OnDisable()
    {
        Debug.Log("Ondisable");
    }
    private void OnDestroy()
    {
        Debug.Log("Ondestroy");
    }
}
