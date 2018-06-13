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
		if (!ShotPrefab.activeSelf)
		{
			ShotPrefab.transform.rotation = Quaternion.AngleAxis(0, Vector3.zero);
			ShotPrefab.transform.position = Character.transform.position + Vector3.up;
			ShotPrefab.SetActive(true);
		}
	}
}
