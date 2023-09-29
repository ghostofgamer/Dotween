using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class CubeRotate : MonoBehaviour
{
    private void Start()
    {
        transform.DORotate(new Vector3(0,360,0), 1f);
    }
}
