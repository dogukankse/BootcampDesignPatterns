using System;
using UnityEngine;
using UnityEngine.Events;

namespace MVC
{
	public class PlayerView : MonoBehaviour
	{
		public UnityAction<Vector3> OnPositionChanged;
		private Vector3 _oldPosition;

		private void Start()
		{
			_oldPosition = transform.position;
		}

		private void Update()
		{
			if(_oldPosition == transform.position) return;
			_oldPosition = transform.position;
			OnPositionChanged?.Invoke(transform.position);
		}
	}
}