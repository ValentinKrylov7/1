using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class IntroBackground : MonoBehaviour
{
    private Image _background;
    [SerializeField] private float _timeToAwake;

    public static event Action EventActivateButton;

    void Start()
    {
        _background = GetComponent<Image>();
        StartCoroutine(BloomBackground(_background.color));
    }
 
    private IEnumerator BloomBackground(Color bloomColor)
    {
        for (int i = 0; i < 255; i++)
        {
            bloomColor.a = 0 + 1f / 255 * i;
            _background.color = bloomColor;
            yield return new WaitForSeconds(_timeToAwake/255);
        }
        EventActivateButton?.Invoke();
    }
}
