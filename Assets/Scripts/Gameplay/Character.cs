using UnityEngine;

namespace Gameplay
{
	public class Character : MonoBehaviour
	{
		private Rigidbody2D _rgb;
		private bool _inComing;
		public float Speed;
		private Vector3 _newPos;
		private static int _direcao;
		// Use this for initialization
		void Start ()
		{
			_rgb = gameObject.GetComponent<Rigidbody2D>();
		}
	
		// Update is called once per frame
		void Update () {
			// aplica as forças vetorias no objeto
	
		
			_rgb.velocity = new Vector2(Speed * _direcao, _rgb.velocity.y);

		


			// checa o input para realizar a movimentaçao e salva a posiçao do click
			if (Input.GetMouseButton(0))
			{
				_newPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
				_inComing = true;
            
			}
			if (Input.GetMouseButtonUp(0))
			{
				_inComing = false;
				_direcao = 0;
			}

			// realiza o movimento baseado na posiçao do click

			if (_inComing)
			{
				if (transform.position.x < _newPos.x)
				{ _direcao = 1; }

				if (transform.position.x > _newPos.x)
				{ _direcao =-1;  }

				if (transform.position.x > _newPos.x - .1f && transform.position.x < _newPos.x + .1f)
				{
					_direcao = 0;
				}
			}

		}

	}
}
