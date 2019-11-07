using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class robot : MonoBehaviour {
    [Header("對話")]
    public string say = "給我電池!!!";
    public float SaySpeed = 0.2f;
    [Header("任務")]
    public bool Complete = false;
    public int BaetryFinish = 5;
    public int Baetry = 0;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
