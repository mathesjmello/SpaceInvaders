using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour {
	public GameObject alert;

	// quando esse script se inicia ele carrega as informações do persistence
	void Start(){
		Persistence.LoadData();
	}
	// botão que sai do jogo
	public void Sair(){

		Application.Quit ();
	}
// botão que volta para a tela de faser
	public void Play(){

		MyLoading.Loading ("LevelSelect");
	}
	// botão que volta para o menu
	public void MenuBack(){

		MyLoading.Loading ("Menu");
	}

	// mostra tela de sair quando clica no voltar do celular
	void  Update(){
		if (Input.GetKeyDown (KeyCode.Escape)) {
			alert.SetActive (true);

		}

	}
// Comando para o botão permitir apenas a fase 1
	public void ZeraGame()
	{
		Persistence.levelstatus= new int[]{1,0,0,0,0,0,0,0};
		PlayerPrefsX.SetIntArray ("LevelStatus", Persistence.levelstatus);
		MyLoading.Loading("LevelSelect");
	}
}
