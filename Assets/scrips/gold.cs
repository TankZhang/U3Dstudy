using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gold : MonoBehaviour {

    private Transform m_transform;
    private GUIText m_guiText;

	// Use this for initialization
	void Start () {
        m_transform = gameObject.GetComponent<Transform>();
        m_guiText = GameObject.Find("Score").GetComponent<GUIText>();
    }
	
	// Update is called once per frame
	void Update () {
        m_transform.Rotate(Vector3.forward, 10.0f);
	}

    public void AddScore()
    {
        int s = int.Parse(m_guiText.text);
        s++;
        m_guiText.text = s.ToString();
    }
}
