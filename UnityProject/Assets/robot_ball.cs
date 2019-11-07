using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class robot_ball : MonoBehaviour {
    [Range(0, 1000), Header("速度")]
    public int speed=50;
    [Range(0, 1000), Header("跳躍")]
    public int jump=100;
    [Header("是否在地上")]
    public bool IsGround = true;
    Rigidbody ball;
	// Use this for initialization
	void Start () {
        ball = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnCollisionEnter(Collision collision)
    {
        IsGround = true;
    }
    private void FixedUpdate()
    {
        Jump();
        Walk();

    }
    private void Walk()
    {
        ball.AddForce(new Vector3(speed * Input.GetAxis("Horizontal"), 0, speed * Input.GetAxis("Vertical")));
    }
    private void Jump()
    {
        if(Input.GetKeyDown(KeyCode.Space)&&IsGround==true)
        {
            IsGround = false;
            ball.AddForce(new Vector3(0, jump, 0));
        }
    }
    }


