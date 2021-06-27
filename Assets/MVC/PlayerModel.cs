using UnityEngine;
using UnityEngine.Events;

namespace MVC
{
	
	public class PlayerModel
	{
		
		public UnityAction OnDead;

		public Vector3 Position
		{
			get => _position;
			set => _position = value;
		}

		public int Health
		{
			get => _health;
			set
			{
				int temp = value;
				if (temp >= 100)
					_health = 100;
				else if (temp <= 0)
				{
					_health = 0;
					OnDead?.Invoke();
				}
				else
				{
					_health = value;
				}
			}
		}


		private Vector3 _position;
		private int _health = 100;
	}
}