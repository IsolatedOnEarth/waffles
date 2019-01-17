using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class charactermovement : MonoBehaviour {

    float MovementSpeed = 100.0f;


    Rigidbody RB;

	// Use this for initialization
	void Start () {
    
        RB.velocity = new Vector3(0, 1000, 0);
	}

	
	// Update is called once per frame
	void Update () {
		
	}
}
