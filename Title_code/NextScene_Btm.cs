using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextScene_Btm : MonoBehaviour
{

    GameObject study01_c;
    GameObject study02_c;
    GameObject study03_c;
    GameObject study04_c;
    GameObject study01;
    GameObject study02;
    GameObject study03;
    GameObject study04;

    public int scen_num = 0;
    
    public void OnClick()
    {
        switch(scen_num)
        {
            case 1:
                SceneManager.LoadScene("S_Style02-07");
                break;

            case 2:
                SceneManager.LoadScene("S_Style05-06");
                break;

            case 3:
                SceneManager.LoadScene("S_Style03-04");
                break;

            case 4:
                SceneManager.LoadScene("BallMoveCheck");
                break;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        study01_c = GameObject.Find("study01_c");
        study02_c = GameObject.Find("study02_c");
        study03_c = GameObject.Find("study03_c");
        study04_c = GameObject.Find("issue_c");
        study01 = GameObject.Find("study01");
        study02 = GameObject.Find("study02");
        study03 = GameObject.Find("study03");
        study04 = GameObject.Find("issue");
        study01_c.SetActive(false);
        study02_c.SetActive(false);
        study03_c.SetActive(false);
        study04_c.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        switch(scen_num)
        {
            case 1:
                BtmFalse();
                study01.SetActive(false);
                study01_c.SetActive(true);
                break;

            case 6:
                BtmFalse();
                Debug.Log("2にきてるよ");
                study02.SetActive(false);
                study02_c.SetActive(true);
                break;

            case 3:
                BtmFalse();
                study03.SetActive(false);
                study03_c.SetActive(true);
                break;

            case 4:
                BtmFalse();
                study04.SetActive(false);
                study04_c.SetActive(true);
                break;

            default:
                BtmFalse();
                break;
        }
    }

    void BtmFalse()
    {
        study01_c.SetActive(false);
        study02_c.SetActive(false);
        study03_c.SetActive(false);
        study04_c.SetActive(false);
        study01.SetActive(true);
        study02.SetActive(true);
        study03.SetActive(true);
        study04.SetActive(true);
    }
}
