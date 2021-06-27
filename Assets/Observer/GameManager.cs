using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Observer;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Enemy enemy;
    public Player player;

    private List<Enemy> _enemies;
    private Player _player;
    private void Start()
    {
        _enemies = new List<Enemy>();
        _player = Instantiate(player, new Vector3(0, -1, 0), Quaternion.identity);
        
        for (int i = 0; i < 3; i++)
        {
            Enemy enemy = Instantiate(this.enemy, new Vector3((i - 1) * 3, 3, 0), Quaternion.identity);
            _enemies.Add(enemy);
            _player.Subscribe(enemy);
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (_enemies.Count == 0) return;
            Enemy enemy = _enemies.Last();
            _enemies.RemoveAt(_enemies.Count-1);
            Destroy(enemy.gameObject);
        }
    }
}
