using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UrsoScript : MonoBehaviour
{
	public string ThisLevel;
	public AudioSource SFX;
	
	
	//comando apra destruir o player ao ser tocado
	private void OnCollisionEnter2D(Collision2D col)
	{
		if (col.gameObject.tag.Equals("Player"))
		{
			SFX.Play();
			col.gameObject.SetActive(false);
			Invoke("Recomeca",2);
			
		}
	}

	//comando com Invoke para dar tempo de tocar o som
	void Recomeca()
	{
		
		MyLoading.Reset(ThisLevel);
		
	}
}
