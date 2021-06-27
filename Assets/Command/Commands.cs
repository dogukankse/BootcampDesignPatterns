using UnityEngine;

namespace Command
{
	class MoveForward : ICommand
	{
		public void Execute(Transform transform, float speed)
		{
			transform.position += new Vector3(0, 1, 0) * (speed * Time.deltaTime);
		}

		public void Undo(Transform transform, float speed)
		{
			transform.position -= new Vector3(0, 1, 0) * (speed * Time.deltaTime);
		}
	}
	class MoveBackward : ICommand
	{
		public void Execute(Transform transform, float speed)
		{
			transform.position -= new Vector3(0, 1, 0) * (speed * Time.deltaTime);
		}

		public void Undo(Transform transform, float speed)
		{
			transform.position += new Vector3(0, 1, 0) * (speed * Time.deltaTime);
		}
	}
	class MoveRight : ICommand
	{
		public void Execute(Transform transform, float speed)
		{
			transform.position += new Vector3(1,0 , 0) * (speed * Time.deltaTime);
		}

		public void Undo(Transform transform, float speed)
		{
			transform.position -= new Vector3(1,0 , 0) * (speed * Time.deltaTime);
		}
	}
	class MoveLeft : ICommand
	{
		public void Execute(Transform transform, float speed)
		{
			transform.position -= new Vector3(1,0 , 0) * (speed * Time.deltaTime);
		}

		public void Undo(Transform transform, float speed)
		{
			transform.position += new Vector3(1,0 , 0) * (speed * Time.deltaTime);
		}
	}
}