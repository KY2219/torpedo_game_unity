using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_change : MonoBehaviour
{
    public GameObject cannon_head;
    public GameObject torpedo;
    public GameObject camera_view;
    public int change_flag = 0;
    // Use this for initialization
    void Start()
    {
       transform.position = camera_view.transform.position;
       transform.rotation = camera_view.transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        switch (change_flag)
        {
            case 0:
                camera_view.transform.position = new Vector3(3,57,-45);
                camera_view.transform.rotation = Quaternion.Euler(60, 0, 0);
                if (Input.GetKeyDown(KeyCode.C))        
                    change_flag = 1;
                break;
            case 1:
                camera_view.transform.position = cannon_head.transform.position + new Vector3(0, 2, 0);
                camera_view.transform.rotation = cannon_head.transform.rotation;
                if (Input.GetKeyDown(KeyCode.C))
                    change_flag = 0;
                break;
           
        }
                /*if (Input.GetKey(KeyCode.Y)) {
                    camerachange_flag = 2;
                }
                if (camerachange_flag == 2) {
                    GameObject camera = GameObject.Find("Main Camera");
                    GameObject torpedos = GameObject.Instantiate(torpedo) as GameObject;
                    camera.transform.position = torpedos.transform.position + new Vector3(0, 2, 2);
                    camera.transform.rotation = torpedos.transform.rotation;
                }*/
        }
}

