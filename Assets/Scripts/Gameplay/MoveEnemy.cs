using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Gameplay
{

    public class MoveEnemy : MonoBehaviour
    {

        public float Speed;
        private float _timer;
        private int _direction=1;
        public float _xLimit;

        public GameObject[,] ships;
        public float _step = 0.125f;

        void Start ()
        {
            _timer = Time.deltaTime;
            Getreferences();
        }

        void Getreferences()
        {
            ships = new GameObject[transform.GetChild(0).childCount,transform.childCount];

            for (int x = 0; x < ships.GetLength(0); x++)
            {
                for (int y = 0; y < ships.GetLength(1); y++)
                {
                    ships[x, y] = transform.GetChild(y).transform.GetChild(x).gameObject;
                }
            }
        }

        void Calculatelimit()
        {
            if (_direction > 0)
            {
                for (int x = ships.GetLength(0) - 1; x >= 0; x--)
                {
                    var empty = true;
                    for (int y = 0; y < ships.GetLength(1); y++)
                    {
                        if (ships[x, y].activeSelf)
                        {
                            empty = false;
                            break;
                        }
                    }

                    _xLimit = 1 + _step * (ships.GetLength(0) - 1 + x);
                    if (!empty)
                    {
                        return;
                    }
                }
            }
            else
            {
                for (int x = 0; x <= ships.GetLength(0) - 1; x++)
                {
                    var empty = true;
                    for (int y = 0; y < ships.GetLength(1); y++)
                    {
                        if (ships[x, y].activeSelf)
                        {
                            empty = false;
                            break;
                        }
                    }

                    _xLimit = 1 + _step * (ships.GetLength(0) - 1 + x);
                    if (!empty)
                    {
                        return;
                    }
                }
            }
        }
	
        void Update ()
        {
            Calculatelimit();
            if (transform.position.x > _xLimit && _direction == 1)
            {
                _direction = -1;
                transform.position = transform.position + Vector3.down/5;
            }
            if (transform.position.x < -_xLimit && _direction==-1)
            {
                _direction = 1;
                transform.position = transform.position + Vector3.down/5;
            }
		
            transform.Translate(Vector3.right * Time.deltaTime*_direction);
        }
    }
}

