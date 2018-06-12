using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Gameplay
{
	public class Character : MonoBehaviour
	{
		public Button LButton;
		public Button RButton;
		private Rigidbody2D _rgb;
		private bool _inComing;
		public float Speed;
		private Vector3 _newPos;
		private static int _direcao;
		// Use this for initialization
		void Start ()
		{
			LButton.onClick.AddListener(MoveLeft);
			RButton.onClick.AddListener(MoveRight);
			_rgb = gameObject.GetComponent<Rigidbody2D>();
		}

		

		// Update is called once per frame
		void Update ()
		{

			
			
			
			_rgb.velocity = new Vector2(Speed * _direcao, _rgb.velocity.y);

		}

		public void MoveRight()
		{
			_direcao = 1;
		}

		public void MoveLeft()
		{
			_direcao = -1;
		}
	}
	
}
