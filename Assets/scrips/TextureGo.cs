using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextureGo : MonoBehaviour {

    private GUITexture gUITexture;
	// Use this for initialization
	void Start () {
        gUITexture = gameObject.GetComponent<GUITexture>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnMouseEnter()
    {
        gUITexture.color = Color.red;
    }

    private void OnMouseDown()
    {
        gUITexture.color = Color.green;
    }

    private void OnMouseExit()
    {
        gUITexture.color = Color.yellow;
    }
}
