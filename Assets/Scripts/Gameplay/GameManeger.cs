﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Gameplay
{
    public class GameManeger : MonoBehaviour
    {
        public AudioSource Tiro;
        public Text ScoreText;
        public Text HighScoreText;
        public float HighScore;
        public float CurrentScore;
        public static GameManeger Instance;
        public GameObject Character;
        public GameObject ShotPrefab;
        // Use this for initialization
        void Start ()
        {
            Instance = this;
            if (Persistence.Win > 0)
            {
                CurrentScore = Persistence.Win;
            }
        }
	
        // Update is called once per frame
        void Update ()
        {
            ScoreText.text = CurrentScore.ToString("0000");
            HighScore = PlayerPrefs.GetFloat("Hi_Score");
            if (HighScore >= CurrentScore)
            {
                HighScoreText.text = HighScore.ToString("0000");
            }
            else
            {
                PlayerPrefs.SetFloat("Hi_Score",CurrentScore);    
            }
            if (!Character.activeSelf)
            {
                Invoke("ResetGame",2);
            }
        }

       

        public void Fire()
        {
            if (!ShotPrefab.activeSelf)
            {
                Tiro.Play();
                ShotPrefab.transform.rotation = Quaternion.AngleAxis(0, Vector3.zero);
                ShotPrefab.transform.position = Character.transform.position + Vector3.up;
                ShotPrefab.SetActive(true);
            }
        }

        public void ScoreCount(int pontos)
        {
            CurrentScore += pontos;
        }

        public void ResetGame()
        {
            SceneManager.LoadScene("Game");
        }
    }
}

