using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayDemo_13 : MonoBehaviour
{

    private int width = 10;
    private int heigt = 5;
    public GameObject prefebBrick;
    public GameObject bullet;
    private Ray ray;
    private RaycastHit raycast;
    private Transform m_transform;
    // Use this for initialization
    void Start()
    {
        m_transform = gameObject.GetComponent<Transform>();
        CreateWall();
    }

    // Update is called once per frame
    void Update()
    {
        SendBullet();
    }
    void CreateWall()
    {
        for (int i = 0; i < width; i++)
        {
            for (int j = 0; j < heigt; j++)
            {
                GameObject go = GameObject.Instantiate(prefebBrick, new Vector3(i - 5, j, 0), Quaternion.identity);
				go.GetComponent<MeshRenderer>().material.color = new Color(Random.Range(0.0f,1.0f),Random.Range(0.0f,1.0f),Random.Range(0.0f,1.0f));
            }
        }
    }

    void SendBullet()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out raycast))
            {
                //实例化子弹，发射子弹
                GameObject go = (GameObject)GameObject.Instantiate(bullet, m_transform.position, Quaternion.identity);
                Vector3 dir = raycast.point - m_transform.position;

				Debug.DrawRay(m_transform.position,dir,Color.green,1.0f);
                go.GetComponent<Rigidbody>().AddForce(dir * 100);
            }
        }
    }
}
