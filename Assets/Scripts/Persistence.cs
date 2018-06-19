using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Script que grava todos os playersPrefs e carrega eles, é chamado toda vez que muda de fazes ou scenes


public static class Persistence {
	public static string nextLevel;
	public static float musicvolume;
	public static float sfxvolume;
	public static float Hi_Score;
	public static float Win;

	public static void SaveData(){
		PlayerPrefs.SetFloat ("MVolume", musicvolume);
		PlayerPrefs.SetFloat ("SFXVolume", sfxvolume);
		PlayerPrefs.SetFloat ("Hi_Score", Hi_Score);
		PlayerPrefs.SetFloat("Win",Win);
	}

	public static void LoadData(){
		
		musicvolume=PlayerPrefs.GetFloat("MVolume");
		sfxvolume=PlayerPrefs.GetFloat("SFXVolume");
		Hi_Score=PlayerPrefs.GetFloat("Hi_Score");
		Win=PlayerPrefs.GetFloat("Win");
	}
}

