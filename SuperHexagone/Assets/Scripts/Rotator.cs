using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //Giramos la camara poco a poco cada frame
        transform.Rotate(Vector3.forward, Time.deltaTime * -30f);
	}
}
