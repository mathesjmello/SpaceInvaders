using System.Collections;
using System.Collections.Generic;
using Gameplay;
using UnityEngine;
using UnityEngine.Experimental.Rendering;

public class EnimScript : MonoBehaviour
{
	private float rnd;
	public GameObject Disparo;
	public GameObject Morte;
	public AudioSource Son;
	public int EnimValor;
	private float _shotTime ;
	// Use this for initialization
	void Start ()
	{
		rnd = Random.Range(6, 60);
	}

	

	private void Fire()
	{
		
		rnd = Random.Range(4, 12);
		
	}

	// Update is called once per frame
	void Update ()
	{
		_shotTime += Time.deltaTime;
	
		if (_shotTime > rnd)
		{
			Instantiate(Disparo);
			Disparo.transform.position = transform.position;
			_shotTime = 0;
			Fire();
		}
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
