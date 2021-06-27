using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MVC
{
	public class PlayerController
	{
		private PlayerView _view;
		private PlayerModel _model;

		public Transform heal;
		public Transform dmg;


		public PlayerController(PlayerView view)
		{
			_view = view;
			_view.OnPositionChanged = PositionChanged;

			_model = new PlayerModel();
			_model.OnDead = Dead;

			heal = GameObject.FindObjectOfType<Heal>().transform;
			dmg = GameObject.FindObjectOfType<Dmg>().transform;
		}


		private void PositionChanged(Vector3 pos)
		{
			if (Vector3.Distance(pos, heal.position) < 5)
			{
				_model.Health += 5;
			}
			else if (Vector3.Distance(pos, dmg.position) < 5)
			{
				_model.Health -= 5;
			}

			Debug.Log(_model.Health);

			_model.Position = pos;
		}

		private void Dead()
		{
			Debug.Log("Öldün");
		}
	}
}