using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ColorChanger : MonoBehaviour
{
    private void Start()
    {
        GetComponent<Renderer>().material.DOColor(Color.red, 3f).SetLoops(-1,LoopType.Yoyo);
    }
}
