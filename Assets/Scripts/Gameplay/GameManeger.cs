using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay
{
    public class GameManeger : MonoBehaviour
    {
        public Text ScoreText;
        public Text HighScoreText;
        public float HighScore;
        public int CurrentScore;
        public static GameManeger Instance;
        public GameObject Character;
        public GameObject ShotPrefab;
        // Use this for initialization
        void Start ()
        {
            Instance = this;
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

        public void ScoreCount(int pontos)
        {
            CurrentScore += pontos;
        } 
    }
}

