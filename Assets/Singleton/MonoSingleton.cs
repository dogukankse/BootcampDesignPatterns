using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonoSingleton : MonoBehaviour
{
	public static MonoSingleton Instance => _instance;
	private static MonoSingleton _instance;

	private void Awake()
	{
		if (_instance == null)
		{
			_instance = this;
			DontDestroyOnLoad(this);
		}
		else if (_instance != this)
		{
			Destroy(gameObject);
		}
	}
}