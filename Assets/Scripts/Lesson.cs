using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson : MonoBehaviour
{
    [SerializeField] private float _speed;

    private void Awake()
    {
        var position = gameObject.transform.position;
        Debug.Log(position);

        position.x -= _speed;
        gameObject.transform.position = position;
    }
}