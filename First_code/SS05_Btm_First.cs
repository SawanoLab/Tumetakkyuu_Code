using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SS05_Btm_First : MonoBehaviour
{
    GameObject Ball;

    public void OnClick()
    {
        Debug.Log("ナックルサービス");
        Ball.GetComponent<BallControl_First>().s_style = 5;
    }

    // Start is called before the first frame update
    void Start()
    {
        Ball = GameObject.Find("Ball3");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
