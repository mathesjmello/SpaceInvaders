using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{

//programação do menu de pause, controlado pelos botões
	
//pausa o tempo da fase	
	public void PauseGame()
	{
		Time.timeScale = 0f;
	}
//retoma a fase
	public void ResumeGame()
	{

		Time.timeScale = 1;
	}
//volta pro menu
	public void BackMenu()
	{
		Time.timeScale = 1;
		MyLoading.Loading("LevelSelect");
	}
//Restart fase
	public void RestartLvl(string fase)
	{
		Time.timeScale = 1;
		MyLoading.Loading(fase);	
	}

}
