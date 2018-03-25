using UnityEngine;
using System.Collections;

public class e_launcher_controll : MonoBehaviour {
    //-35°～5.5°
    float kakudo = 0;
    public GameObject enemy_launcher;
    public Transform player1;
    public Transform player2;
    public Transform player3;
    // Use this for initialization
    //public player_ship_destroy_flag dflag;
    public player_ship_destroy_flag p1;
    public player_ship_destroy_flag p2;
    public player_ship_destroy_flag p3;
    void Start () {
      
    }

    // Update is called once per frame
    void Update() {
        //Vector3 pos = player1.position;
        // pos.y = this.transform.position.y;
        //this.transform.LookAt(pos);  //2
        /*switch (dflag.dest_flag) {
            case 0:
                Vector3 pos1 = new Vector3(player1.position.x, this.transform.position.y, player1.position.z);
                Quaternion rota1 = Quaternion.LookRotation(pos1 - transform.position);
                transform.rotation = Quaternion.Slerp(transform.rotation, rota1, Time.deltaTime * 0.5f); ;  //1
                break;
            case 1:
                Vector3 pos2 = new Vector3(player2.position.x, this.transform.position.y, player2.position.z);
                Quaternion rota2 = Quaternion.LookRotation(pos2 - transform.position);
                transform.rotation = Quaternion.Slerp(transform.rotation, rota2, Time.deltaTime * 0.5f); ;  //1
                break;
            case 2:
                Vector3 pos3 = new Vector3(player3.position.x, this.transform.position.y, player3.position.z);
                Quaternion rota3 = Quaternion.LookRotation(pos3 - transform.position);
                transform.rotation = Quaternion.Slerp(transform.rotation, rota3, Time.deltaTime * 0.5f); ;  //1
                break;
        }*/
        if(p1.p_dest_flag_1 == 0)  //enemy1が破壊されていない間はenemy1を狙い続ける
        {
            Vector3 pos1 = new Vector3(player1.position.x, this.transform.position.y, player1.position.z);
            Quaternion rota1 = Quaternion.LookRotation(pos1 - transform.position);
            transform.rotation = Quaternion.Slerp(transform.rotation, rota1, Time.deltaTime * 0.5f);  //1
        }

        if (p1.p_dest_flag_1 == 1 && p2.p_dest_flag_2 == 0) //enemy1が破壊されたらenemy2に移行
        {
            Vector3 pos2 = new Vector3(player2.position.x, this.transform.position.y, player2.position.z);
            Quaternion rota2 = Quaternion.LookRotation(pos2 - transform.position);
            transform.rotation = Quaternion.Slerp(transform.rotation, rota2, Time.deltaTime * 0.5f);  //1
        }

        if(p2.p_dest_flag_2 == 1 && p3.p_dest_flag_3 == 0)
        {
            Vector3 pos3 = new Vector3(player3.position.x, this.transform.position.y, player3.position.z);
            Quaternion rota3 = Quaternion.LookRotation(pos3 - transform.position);
            transform.rotation = Quaternion.Slerp(transform.rotation, rota3, Time.deltaTime * 0.5f);   //1
        }
       
    }

}
