using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Gameplay
{
    public class Shot : MonoBehaviour
    {

        public float Vel;
        // Use this for initialization
        void Start () {
		
        }
	
        // Update is called once per frame
        void Update () {
            transform.Translate(Vector3.up/Vel);
        }

        private void OnCollisionEnter2D(Collision2D other)
        {
            other.gameObject.SetActive(false);
            gameObject.SetActive(false);
        }

        private void OnBecameInvisible()
        {
            gameObject.SetActive(false);
        }
    }

}

