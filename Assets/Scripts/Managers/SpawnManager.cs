﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] Enemies;

    public void Init()
    {
        for (int i = 0; i < 10; i++)
        {
            Vector2 point = FindObjectOfType<BoardManager>().RandomFreePosition();
            Instantiate(Enemies[Random.Range(0, Enemies.Length - 1)], point, Quaternion.identity);
        }
    }
}
