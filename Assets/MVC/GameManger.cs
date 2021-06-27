using System;
using UnityEngine;

namespace MVC
{
	public class GameManger : MonoBehaviour
	{
		public PlayerView _view;
		private PlayerController _controller;

		private void Start()
		{
			_controller = new PlayerController(_view);
		}
	}
}