using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class enemy_ship_destroy_flag : MonoBehaviour
{
    public GameObject enemy1;
    public GameObject enemy2;
    public GameObject enemy3;
    public int enemy_dest_flag_1 = 0;
    public int enemy_dest_flag_2 = 0;
    public int enemy_dest_flag_3 = 0;

    // Use this for initialization
    void Start()
    {  
    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "bullet")
        {      
            this.GetComponent<Rigidbody>().drag = 10;
            this.GetComponent<Rigidbody>().useGravity = true;
            if (gameObject.name == "enemy1")
                enemy_dest_flag_1 = 1;
            if(gameObject.name == "enemy2")
                enemy_dest_flag_2 = 1;
            if(gameObject.name == "enemy3")
                enemy_dest_flag_3 = 1;
        }       
    }
}