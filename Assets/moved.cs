using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moved : MonoBehaviour {

    public Transform ball;

    Vector3 offset;
	// Use this for initialization
	void Start () {

        offset = transform.position - ball.position ;
	}
	
	// Update is called once per frame
	void Update () {

        transform.position = ball.position + offset;
	}
}
