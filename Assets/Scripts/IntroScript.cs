﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//script para regrar tempo de exibição do logo e chamar o menu
public class IntroScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Invoke ("ExitIntro", 4);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void ExitIntro(){
		SceneManager.LoadScene ("Menu");
	}
}
