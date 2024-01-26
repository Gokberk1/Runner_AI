using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleAnimation : MonoBehaviour
{
    [SerializeField] float _speed = 1f;
    [SerializeField] float _strength = 2.5f;
    private float _randomOffset;

    void Start()
    {
        _randomOffset = Random.Range(-2.5f, 2.5f);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
        pos.x = Mathf.Sin(Time.time * _speed + _randomOffset) * _strength;
        transform.position = pos;
    }
}
