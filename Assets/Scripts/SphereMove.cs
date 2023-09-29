using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class SphereMove : MonoBehaviour
{
    [SerializeField] private Transform _path;

    private Transform[] _points;
    private Tweener _tween;
    private int _currentPoint = 0;

    private void Start()
    {
        GetPoints();
        Move();
    }

    private void Update()
    {
        ChangeMove();
    }

    private void GetPoints()
    {
        _points = new Transform[_path.childCount];

        for (int i = 0; i < _points.Length; i++)
        {
            _points[i] = _path.GetChild(i);
        }
    }

    private void Move()
    {
        _tween = transform.DOMove(_points[_currentPoint].position, 1).SetAutoKill(false);
    }

    private void ChangeMove()
    {
        if (transform.position == _points[_currentPoint].position)
        {
            _currentPoint++;

            if (_currentPoint >= _points.Length)
            {
                _currentPoint = 0;
                ChangeValueToPoint();
            }

            ChangeValueToPoint();
        }
    }

    private void ChangeValueToPoint()
    {
        _tween.ChangeEndValue(_points[_currentPoint].position, true).Restart();
    }
}
