using UnityEngine;

public class Robot : MonoBehaviour
{
    [Header("對話")]
    public string say = "嗨，你好，我快沒電了，可以請你幫我找到五顆電池嗎？";
    public float saySpeed = 0.2f;
    [Header("任務")]
    public bool complete;
    public int bateryFinish = 5;
    public int batery;
}
