using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveEnemy : MonoBehaviour
{

	public float Speed;

	private int _direction=1;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (transform.position.x > 1 && _direction == 1)
		{
			_direction = -1;
			transform.position = transform.position + Vector3.down/5;
		}
		if (transform.position.x < -1 && _direction==-1)
		{
			_direction = 1;
			transform.position = transform.position + Vector3.down/5;
		}
		
		
		transform.Translate(Vector3.right * Time.deltaTime*_direction);
	}
}
