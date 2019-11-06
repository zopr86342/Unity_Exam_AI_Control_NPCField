using UnityEngine;

public class RobotBall : MonoBehaviour
{
    [Header("速度"), Range(0.5f, 500f)]
    public float speed = 10.5f;
    [Header("跳躍"), Range(10, 1000)]
    public int jump = 100;
    [Header("是否在地板上")]
    public bool isGround;

    private Rigidbody rig;

    private void Start()
    {
        rig = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        Move();
        Jump();
    }

    private void OnCollisionEnter(Collision collision)
    {
        isGround = true;
    }

    /// <summary>
    /// 移動
    /// </summary>
    private void Move()
    {
        rig.AddForce(speed * Input.GetAxis("Horizontal"), 0, speed * Input.GetAxis("Vertical"));
    }

    /// <summary>
    /// 跳躍
    /// </summary>
    private void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGround == true)
        {
            isGround = false;
            rig.AddForce(0, jump, 0);
        }
    }
}
