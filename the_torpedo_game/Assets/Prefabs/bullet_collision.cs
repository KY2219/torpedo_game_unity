using UnityEngine;
using System.Collections;

public class bullet_collision : MonoBehaviour {
    public GameObject torpedo;
    public GameObject explosion;
    public GameObject explo_pos;
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject)
        {
            Destroy(gameObject);
            //ParticleSystem ps = collider.gameObject;
            //GetComponent<ParticleSystem>();
            Instantiate(explosion, explo_pos.transform.position, Quaternion.identity);
        }
    }
}
