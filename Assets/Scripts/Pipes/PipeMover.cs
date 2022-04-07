using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMover : MonoBehaviour
{
    [SerializeField] private float _speed;

   
    void Update()
    {
        transform.Translate(-_speed * Time.deltaTime, 0, 0);
    }
}
