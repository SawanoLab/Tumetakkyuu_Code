using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SS04_Btm : MonoBehaviour
{

    GameObject Ball;

    public void OnClick()
    {
        Debug.Log("ナックルサービス");
        Ball.GetComponent<BallControl_BMC>().s_style = 4;
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
