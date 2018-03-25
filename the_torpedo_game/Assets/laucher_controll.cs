using UnityEngine;
using System.Collections;

public class laucher_controll : MonoBehaviour
{
    public GameObject launcher;
    // Use this for initialization
    public float rot;
    void Start()
    {
      
        // = launcher.transform.rotation.y;
    }

    // Update is called once per frame
    void Update()
    {
    
        rot = launcher.transform.rotation.y;
  

        if (Input.GetKey(KeyCode.RightArrow))
            {
                launcher.transform.Rotate(new Vector3(0, 0.15f, 0));
           if(rot > 0.02f)
            {
                launcher.transform.eulerAngles = new Vector3(0, 2.4f, 0);
            }
            }
            else if (Input.GetKey(KeyCode.LeftArrow))
            {
                launcher.transform.Rotate(new Vector3(0, -0.15f, 0));
            if (rot < -0.23f)
            {
                launcher.transform.eulerAngles = new Vector3(0, -27.0f, 0);
            }
        }

        
    }
}