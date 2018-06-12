using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class LevelSelect : MonoBehaviour {
	public Button[] buttons; 
	
	public void Start(){
		for (int i = 0; i < buttons.Length; i++) {
			if (Persistence.levelstatus [i] > 0) {
				buttons [i].interactable = true;
			} else {
				buttons [i].interactable = false;
			}

		}
	}

	public void Loadonclick(string level){

		MyLoading.Loading (level);
	}
}
