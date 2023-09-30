using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ScaleChanger : MonoBehaviour
{
    private void Start()
    {
        transform.DOScale(new Vector3(3, 3, 3), 3f).SetLoops(-1,LoopType.Yoyo); 
    }
}
