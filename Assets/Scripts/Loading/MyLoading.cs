using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


//script que carrega as cenas mostrando a tela de loading e depois indo para a proxima
public static class MyLoading  {

	public static void Loading(string scene){
		Persistence.nextLevel = scene;
		SceneManager.LoadScene ("Loading");

	}

	public static void Reset(string scene)
	{
		SceneManager.LoadScene(scene);
	}
}
