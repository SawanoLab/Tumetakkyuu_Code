using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC06_Btm : MonoBehaviour
{

    GameObject Ball;

    public void OnClick()
    {
        Debug.Log("ナックルサービス");
        Ball.GetComponent<BallControl_BMC>().s_course = 6;
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
