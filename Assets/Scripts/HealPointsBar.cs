using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))] 

public class HealPointsBar : MonoBehaviour
{
    [SerializeField] private Image _image;
    [SerializeField] private Player _player;

    private float _newPositionHp;
    private float _step = 0.1f;

    private void Start()
    {
        _image = GetComponent<Image>();
        _image.fillAmount = (float)_player.HealthPoints / _player.MaxHealthPoints;
        _newPositionHp = _image.fillAmount;
    }

    public void ChangeHealth()
    {
        StopAllCoroutines();
        _newPositionHp = (float)_player.HealthPoints / _player.MaxHealthPoints;
        StartCoroutine(nameof(ChangeHealBar));
    }

    private IEnumerator ChangeHealBar()
    {
        while (_image.fillAmount != _newPositionHp)
        {
            _image.fillAmount = Mathf.MoveTowards(_image.fillAmount, _newPositionHp, _step * Time.deltaTime);
            yield return null;
        }
    }
}