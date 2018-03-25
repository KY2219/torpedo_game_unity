using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class system : MonoBehaviour {
    public void gamestart()
    {
        SceneManager.LoadScene("tpd");
    }
        // Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Escape))
            Application.Quit();
    }
}
