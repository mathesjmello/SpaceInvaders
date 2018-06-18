using System.Collections;
using System.Collections.Generic;
using Gameplay;
using UnityEngine;

public class EnimScript : MonoBehaviour
{
	public GameObject Morte;
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
		if(!Morte.activeSelf)
		Morte.SetActive(true);
		Morte.transform.position = transform.position;
		Son.Play();
	}
}
