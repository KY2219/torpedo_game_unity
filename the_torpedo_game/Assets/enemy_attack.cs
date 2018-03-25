using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_attack : MonoBehaviour
{
    public GameObject enemy_torpedo_Prefab;    //GameObject型変数torpedo_prehubを宣言
    //public Transform spawn;           //Transform型変数spawnを宣言
    public float speed = 100;           //float型変数speedを宣言。同時に1000を代入
    int flag = 1;
   // int fire_flag = 0;
    // Use this for initialization
    void Start()
    {
        // atari_obj = GameObject.FindWithTag("enemy");
        StartCoroutine(reload());
    }

    // Update is called once per frame
    void Update()
    {
        /*switch (flag) {
            case 0:
                if (Input.GetKeyDown(KeyCode.Space))
                {
                  // 弾丸の複製
                 GameObject torpedos = (GameObject)Instantiate(torpedoPrefab, transform.position, Quaternion.identity);
                 Rigidbody shellRigidbody = torpedos.GetComponent<Rigidbody>();
                 shellRigidbody.AddForce(transform.forward * speed);
                 flag = 1;
                }
                break;
            case 1:
                StartCoroutine(reload());
                break;
         }*/
       // random_launch();
       
        if (flag == 0)
        {
           
       
                GameObject torpedos = (GameObject)Instantiate(enemy_torpedo_Prefab, transform.position, Quaternion.identity);
                Rigidbody shellRigidbody = torpedos.GetComponent<Rigidbody>();
                shellRigidbody.AddForce(transform.forward * speed);
                flag = 1;
               // fire_flag = 0;
                StartCoroutine(reload());
            
        }



    }

    IEnumerator reload()
    {
        yield return new WaitForSeconds(5 + Random.Range(1.0f, 5.0f));
        flag = 0;
        //used_bullet = false;
    }
    /*IEnumerator random_launch()
    {
        yield return new WaitForSeconds(2);
        fire_flag = 1;
    }*/

}
