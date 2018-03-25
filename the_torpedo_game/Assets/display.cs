using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class display : MonoBehaviour {
    public GameObject text;
    public player_ship_destroy_flag p_flag_1;  //プレイヤーの破壊フラグ
    public player_ship_destroy_flag p_flag_2;
    public player_ship_destroy_flag p_flag_3;

    public enemy_ship_destroy_flag enemy_flag_1; //敵の破壊フラグ
    public enemy_ship_destroy_flag enemy_flag_2;
    public enemy_ship_destroy_flag enemy_flag_3;
    // Use this for initialization
    void Start () {
        text.GetComponent<Text>().text = " ";   
    }
	
	// Update is called once per frame
	void Update () {
        if (p_flag_1.p_dest_flag_1 == 1 && p_flag_2.p_dest_flag_2 == 1 && p_flag_3.p_dest_flag_3 == 1)
        {
            text.GetComponent<Text>().text = "you lose...";
        }
        else if (enemy_flag_1.enemy_dest_flag_1 == 1 && enemy_flag_2.enemy_dest_flag_2 == 1 && enemy_flag_3.enemy_dest_flag_3 == 1)
        {
            text.GetComponent<Text>().text = "all enemy destroyed!!";
        }
    }

   
}
