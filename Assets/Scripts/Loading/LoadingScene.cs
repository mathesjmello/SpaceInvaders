using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LoadingScene : MonoBehaviour {
	AsyncOperation aop;
	public SpriteRenderer srend;
	float timer=0;
	// Use this for initialization
	void Start () {
		aop = SceneManager.LoadSceneAsync(Persistence.nextLevel);
		aop.allowSceneActivation = false;

	}
	
	// faz a barra de carregamento crescer conforme a proxima tela é carregada
	void Update () {
		print (timer);
		if (timer <= 0.89f) {
			timer =Mathf.Lerp(timer,aop.progress,Time.deltaTime*5);
			srend.size = new Vector2 (timer*11, srend.size.y);
		} else {
			aop.allowSceneActivation = true;
		}
	}
}
