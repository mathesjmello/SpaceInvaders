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
            if(transform.name=="tiro")
            transform.Translate(Vector3.up/Vel);
            else
            {
                transform.Translate(Vector3.down/Vel);
            }
        }

        private void OnCollisionEnter2D(Collision2D other)
        {
            if (transform.name == "tiro")
            {
                other.gameObject.SetActive(false);
                gameObject.SetActive(false);
            }
            
            
        }

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.name=="character" || other.CompareTag("casinha"))
            {
                other.gameObject.SetActive(false);
                gameObject.SetActive(false);
       
            }
        }

        private void OnBecameInvisible()
        {
            gameObject.SetActive(false);
        }
    }

}

