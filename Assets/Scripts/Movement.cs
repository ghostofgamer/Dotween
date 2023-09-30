using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Movement : MonoBehaviour
{
    [SerializeField] private Transform _target;

    private Vector3 _lastPositionTarget;
    private Tweener _tween;

    private void Start()
    {
        ChangeColor();
        ChangeRotate();
        Move();
    }

    private void Update()
    {
        ChangeTargetposition();
    }

    private void ChangeColor()
    {
        GetComponent<Renderer>().material.DOColor(Color.blue, 1.5f).SetLoops(-1, LoopType.Yoyo);
    }
    private void ChangeRotate()
    {
        transform.DORotate(new Vector3(0, 360, 180), 3f, RotateMode.FastBeyond360).SetLoops(-1, LoopType.Yoyo);
    }

    private void Move()
    {
        _tween = transform.DOMove(_target.position, 1.5f).SetAutoKill(false);
        _lastPositionTarget = _target.position;
    }

    private void ChangeTargetposition()
    {
        if (_lastPositionTarget != _target.position)
        {
            _tween.ChangeEndValue(_target.position, true).Restart();
            _lastPositionTarget = _target.position;
        }
    }
}
