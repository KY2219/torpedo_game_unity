using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class line_disp : MonoBehaviour {
    public GameObject text;
    public camera_change change;
    // Use this for initialization
    void Start () { 
    }
	
	// Update is called once per frame
	void Update () {
        if (change.change_flag == 0)
        {
            text.GetComponent<Text>().text = "黄色線　プレイヤー行動可能範囲";
        }
        else if (change.change_flag == 1)
        {
            text.GetComponent<Text>().text = " ";
        }
    }
}
