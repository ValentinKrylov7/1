using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartButton : MonoBehaviour
{
    private Image _image;
    [SerializeField] private Color _exitColor;
    [SerializeField] private Color _enterColor;

    private void Start()
    {
        gameObject.SetActive(false);
        IntroBackground.EventActivateButton += ActivateButton;
        _image = GetComponent<Image>();
    }

    public void ActivateButton()
    {
        gameObject.SetActive(true);
    }

    void OnMouseEnter()
    {
        AudioManager.PlaySoundStartButton();
        _image.color = _enterColor;
    }

    
    void OnMouseExit()
    {
        _image.color = _exitColor;
    }

}
