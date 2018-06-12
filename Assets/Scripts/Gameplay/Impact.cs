using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// script que facilita a movimentalção de outros objts




public class Impact : MonoBehaviour {

	Vector3 deltapos;
	Vector3 oldpos;
	// Update is called once per frame
	void FixedUpdate () {
		deltapos = transform.position - oldpos;
		oldpos = transform.position;
	}
	void OnCollisionEnter2D(Collision2D col){
		
		if(col.rigidbody)
			
			col.rigidbody.AddForce(deltapos*50,ForceMode2D.Impulse);

		deltapos = Vector3.zero;
	}
}
