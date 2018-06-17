using System.Collections;
using System.Collections.Generic;
using Gameplay;
using UnityEngine;

public class EnimScript : MonoBehaviour
{

	public AudioSource Son;
	public int EnimValor;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnDisable()
	{
		GameManeger.Instance.ScoreCount(EnimValor);
		Son.Play();
	}
}
