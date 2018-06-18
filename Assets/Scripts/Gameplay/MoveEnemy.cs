using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Gameplay
{

    public class MoveEnemy : MonoBehaviour
    {

        public float Speed;
        private int _direction=1;
        public float _xLimit;

	      void Update ()
        {
            if (transform.position.x > _xLimit && _direction == 1)
            {
                _direction = -1;
                transform.position = transform.position + Vector3.down/7;
            }
            if (transform.position.x < -_xLimit && _direction==-1)
            {
                _direction = 1;
                transform.position = transform.position + Vector3.down/7;
            }
		
            transform.Translate(Vector3.right * Time.deltaTime*_direction*Speed);
        }
    }
}

