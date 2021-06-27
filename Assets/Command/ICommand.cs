using UnityEngine;

namespace Command
{
	public interface ICommand
	{
		void Execute(Transform transform,float speed);
		void Undo(Transform transform,float speed);
		
	}
}