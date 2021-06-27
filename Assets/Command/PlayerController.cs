using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Command;
using UnityEngine;

namespace Command
{
	public class PlayerController : MonoBehaviour
    {
    	public float speed = 10;
    
    
    	private MoveForward _moveForward;
    	private MoveBackward _moveBackward;
    	private MoveRight _moveRight;
    	private MoveLeft _moveLeft;
    
    	private List<ICommand> _commands;
    
    	private void Start()
    	{
    		_moveForward = new MoveForward();
    		_moveBackward = new MoveBackward();
    		_moveLeft = new MoveLeft();
    		_moveRight = new MoveRight();
    
    		_commands = new List<ICommand>();
    	}
    
    	private void Update()
    	{
    		// Vector2 input = ReadInput();
    		// if (input == Vector2.zero) return;
    		// transform.position += new Vector3(input.x, input.y, 0) * (speed * Time.deltaTime);
    		PlayerMove();
    	}
    
    	private Vector2 ReadInput()
    	{
    		Vector2 input = new Vector2(0, 0);
    		if (Input.GetKey(KeyCode.W))
    		{
    			input.y += 1;
    		}
    
    		if (Input.GetKey(KeyCode.S))
    		{
    			input.y -= 1;
    		}
    
    		if (Input.GetKey(KeyCode.A))
    		{
    			input.x -= 1;
    		}
    
    		if (Input.GetKey(KeyCode.D))
    		{
    			input.x += 1;
    		}
    
    		return input;
    	}
    
    
    	private void PlayerMove()
    	{
    		if (Input.GetKey(KeyCode.W))
    		{
    			_moveForward.Execute(transform, speed);
    			_commands.Add(_moveForward);
    		}
    
    		if (Input.GetKey(KeyCode.S))
    		{
    			_moveBackward.Execute(transform, speed);
    			_commands.Add(_moveBackward);
    		}
    
    		if (Input.GetKey(KeyCode.A))
    		{
    			_moveLeft.Execute(transform, speed);
    			_commands.Add(_moveLeft);
    		}
    
    		if (Input.GetKey(KeyCode.D))
    		{
    			_moveRight.Execute(transform, speed);
    			_commands.Add(_moveRight);
    		}
    
    		if (Input.GetKey(KeyCode.R))
    		{
    			if (_commands.Count == 0) return;
    			ICommand command = _commands.Last();
    			command.Undo(transform, speed);
    			_commands.RemoveAt(_commands.Count - 1);
    		}
    	}
    }
}
