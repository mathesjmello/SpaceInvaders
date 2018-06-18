using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MorteScript : MonoBehaviour {

	// Use this for initialization
	private void OnEnable()
	{
	Invoke("Some",0.5f);
		
	}

	
	
	// Update is called once per frame
	void Update () {
		
	}

	void Some()
	{
		transform.gameObject.SetActive(false);
	}
}
