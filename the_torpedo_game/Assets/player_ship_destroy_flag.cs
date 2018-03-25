using UnityEngine;
using System.Collections;

public class player_ship_destroy_flag : MonoBehaviour {
    public GameObject player1;
    public GameObject player2;
    public GameObject player3;
    public int dest_flag = 0;
    public int p_dest_flag_1 = 0;
    public int p_dest_flag_2 = 0;
    public int p_dest_flag_3 = 0; 

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag=="enemy_bullet")
        {
            this.GetComponent<Rigidbody>().drag = 10;
            this.GetComponent<Rigidbody>().useGravity = true;
            dest_flag++;
            if (gameObject.name == "player1") 
                p_dest_flag_1 = 1;            
            if (gameObject.name == "player2")
                p_dest_flag_2 = 1;
            if (gameObject.name == "player3")
                p_dest_flag_3 = 1;
        }
    }
}
