using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManeger : MonoBehaviour
{

	public GameObject Character;
	public GameObject ShotPrefab;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Fire()
	{
		
		ShotPrefab.transform.position = Character.transform.position+ Vector3.up;
		Instantiate(ShotPrefab);
	}
}
