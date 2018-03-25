using UnityEngine;
using System.Collections;

public class enemy_bullet_collision : MonoBehaviour
{
    public GameObject enemy_torpedo;
    public GameObject enemy_explosion;
    public GameObject enemy_explo_pos;
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
        if (collision.gameObject)
         {
        Destroy(gameObject);
            Instantiate(enemy_explosion, enemy_explo_pos.transform.position, Quaternion.identity);
        }
    }
}
