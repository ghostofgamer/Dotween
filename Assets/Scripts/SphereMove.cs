using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class SphereMove : MonoBehaviour
{
    [SerializeField] private Transform _point;


    private void Start()
    {
        transform.DOMove(_point.position, 3).SetLoops(-1,LoopType.Yoyo);
    }
}
