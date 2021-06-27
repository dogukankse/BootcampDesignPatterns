using UnityEngine;
using UnityEngine.Events;

namespace Observer
{
	public class Enemy : MonoBehaviour
	{
		public UnityAction OnKill;

		public void OnDestroy()
		{
			OnKill?.Invoke();
		}
	}
}