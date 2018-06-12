using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(Vector3.up);
	}

	private void OnCollisionEnter2D(Collision2D other)
	{
		other.gameObject.SetActive(false);
		gameObject.SetActive(false);
	}
}
