using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public GameObject torpedoPrefab;    //GameObject型変数bulletを宣言
    //public Transform spawn;           //Transform型変数spawnを宣言
    public float speed = 100;           //float型変数speedを宣言。同時に1000を代入
    public int flag = 0;

    // Use this for initialization
    void Start()   {
       // atari_obj = GameObject.FindWithTag("enemy");
    }

    // Update is called once per frame
    void Update() {
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
        if (flag == 0 && Input.GetKeyDown(KeyCode.Space))
            {
                GameObject torpedos = (GameObject)Instantiate(torpedoPrefab, transform.position, Quaternion.identity);
                Rigidbody shellRigidbody = torpedos.GetComponent<Rigidbody>();
                shellRigidbody.AddForce(transform.forward * speed);
                flag = 1;
                StartCoroutine(reload());
            }               
    }

    IEnumerator reload()
    {
        yield return new WaitForSeconds(5);
        flag = 0;
    }

}