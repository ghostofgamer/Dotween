using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class TextChanger : MonoBehaviour
{
    [SerializeField] private Text _text;

    private readonly int _positionStart = 3;
    private readonly float _duration = 1.5f;

    private void Start()
    {
        DoSequence();
    }

    private void DoSequence()
    {
        Sequence sequence = DOTween.Sequence();
        sequence.Append(_text.DOText("Срочно!!!", _duration));
        sequence.Append(_text.DOText(" Примите в компанию", _duration, true, ScrambleMode.All));
        sequence.Append(_text.DOText(" AGAVA", _duration).SetRelative());
        sequence.Insert(_positionStart, _text.DOColor(Color.green, 3f));
    }
}
