using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Gameplay
{
	public class Character : MonoBehaviour
	{
		public GameObject NaveDestruida;
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
		void Update ()
		{

			if (Input.GetMouseButtonDown(0))
			{
				Vector2 worldPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
				RaycastHit2D hit = Physics2D.Raycast(worldPoint, Vector2.zero);

				if (hit.collider != null)
				{
					switch (hit.collider.name)
					{
						case "direita":
							_direcao = 1;
							break;
						case "esquerda":
							_direcao = -1;
							break;
					}
				}
			}
			if (Input.GetMouseButtonUp(0))
				_direcao = 0;



			_rgb.velocity = new Vector2(Speed * _direcao, _rgb.velocity.y);

		}

		private void OnDisable()
		{
			NaveDestruida.SetActive(true);
			NaveDestruida.transform.position = transform.position;
			
		}
	}
	
	
}
