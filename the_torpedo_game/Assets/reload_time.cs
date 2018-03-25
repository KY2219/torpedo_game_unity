using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class reload_time : MonoBehaviour {
    public bullet f;
    public GameObject text;
    int flag = 0;
    int camera_f = 0;
	// Use this for initialization
	void Start () {
        //this.GetComponent<Slider>().value = 0;
    }

    // Update is called once per frame
    void Update()
    {
        switch (flag)
        {
            case 0:
                this.GetComponent<Slider>().value = 0;
                text.GetComponent<Text>().text = "  ";
                break;
            case 1:
                this.GetComponent<Slider>().value += Time.deltaTime / 5;
                text.GetComponent<Text>().text = "reloading...";
                break;
        }
        switch (camera_f)
        {
            case 0:
                this.GetComponent<RectTransform>().localPosition = new Vector3(245.0f, -250.0f, 0.0f);
                this.GetComponent<RectTransform>().localScale = new Vector3(0.5f, 1.0f);
                if (Input.GetKeyDown(KeyCode.C))
                    camera_f = 1;
                break;
            case 1:
                this.GetComponent<RectTransform>().localPosition = new Vector3(0.0f, -180.0f, 0.0f);
                this.GetComponent<RectTransform>().localScale = new Vector3(0.5f, 1.0f);
                if (Input.GetKeyDown(KeyCode.C))
                    camera_f = 0;
                break;
        }

        if (flag == 0 && Input.GetKeyDown(KeyCode.Space)){
            flag = 1;
            StartCoroutine(time());
        }
       
    }
    IEnumerator time()
    {
        yield return new WaitForSeconds(5);
        flag = 0;
    }
}
