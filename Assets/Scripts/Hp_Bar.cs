using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hp_Bar : MonoBehaviour
{
    [SerializeField] private Image _image;
    [SerializeField] private Player _player;

    private float _newPositionHp;

    private void Start()
    {
        _image = GetComponent<Image>();
        _image.fillAmount = _player.HealthPoints;
        _newPositionHp = _image.fillAmount;
    }

    private void Update()
    {
        _image.fillAmount = Mathf.MoveTowards(_image.fillAmount, _newPositionHp, 0.1f * Time.deltaTime);
    }

    public void ChangeHealth()
    {    
        _newPositionHp = (float)_player.HealthPoints / 100;
    }
}
