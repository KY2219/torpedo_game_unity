using UnityEngine;
using System.Collections;

public class shipcontroll : MonoBehaviour {
    // Use this for initialization
    public float sokudo;
    public GameObject ship;
    public float pos;
    public float syoki;
    public float sa;
    void Start () {

        syoki = transform.position.x;
	}
	
	// Update is called once per frame
	void Update () {
        pos = transform.position.x;
        sa = pos - syoki;

        if (sa < 8.0f)
        {
            if (Input.GetKey(KeyCode.D))
            {
                transform.GetComponent<Rigidbody>().AddForce(sokudo, 0, 0);
            }
        }

        if (sa > -8.0f)
        {
            if (Input.GetKey(KeyCode.A))
            {
                transform.GetComponent<Rigidbody>().AddForce(-sokudo, 0, 0);        
            }
        }   
    }
}
