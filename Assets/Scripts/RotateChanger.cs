using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class RotateChanger : MonoBehaviour
{
    private void Start()
    {
        transform.DORotate(new Vector3(0f, 360f, 0f), 3f, RotateMode.FastBeyond360).SetLoops(-1,LoopType.Yoyo);
    }
}
