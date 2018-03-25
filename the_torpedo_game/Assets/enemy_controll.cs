using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class enemy_controll : MonoBehaviour
{
    public GameObject enemy_ships;
    int time = 0;
    int freetime = 0;
    int flag = 0;

    // Use this for initialization
    void Start()
        
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Rigidbody rigidbody = GetComponent<Rigidbody>();
        switch (flag)
        {
            case 0:
                rigidbody.AddForce(1.4f, 0, 0);
                if (time == 620)
                {
                    flag = 2;
                    StartCoroutine(Example1());                   
                }
                break;

            case 1:
                rigidbody.AddForce(-1.4f, 0, 0);
                if (time == 620)
                {
                    flag = 2;
                    StartCoroutine(Example2());
                }
                break;

            case 2:
               break;
        }
        //float pos = this.transform.position.x;
        time++;
        /*if (flag == 0)
        {
            rigidbody.AddForce(0.7f, 0, 0);
            if (time == 700)
            {
                flag = 1;
                time = 0;

            }
        }
        if (flag == 1)
        {
            rigidbody.AddForce(-0.7f, 0, 0);
            if (time == 700)
            {
                flag = 0;
                time = 0;
            }
        }*/

        time++;
    }

    IEnumerator Example1()
    {    
        yield return new WaitForSeconds(4);
        flag = 1;
        time = 0;
    }
    IEnumerator Example2()
    {
        yield return new WaitForSeconds(4);
        flag = 0;
        time = 0;
    }


}