using UnityEngine;

namespace Observer
{
	public class Player : MonoBehaviour
	{
		private int _enemyKilled;

		public void Subscribe(Enemy e)
		{
			e.OnKill += Kill;
		}

		public void Unsubscribe(Enemy e)
		{
			e.OnKill -= Kill;
		}

		private void Kill()
		{
			_enemyKilled++;
			print("Enemy killed: "+_enemyKilled);
			if (_enemyKilled == 3)
			{
				print("Ulti");
				_enemyKilled = 0;
			}
		}
	}
}