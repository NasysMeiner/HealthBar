using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    [SerializeField] private HealPointsBar _healPointsBar;

    private UnityAction _changeHealPoints;
    private int _healthPoints = 70;
    private int _maxHealthPoints = 100;
    private int _minHealthPoints = 0;
    private int _health;

    public int HealthPoints => _healthPoints;
    public int MaxHealthPoints => _maxHealthPoints;

    private void OnEnable()
    {
        _changeHealPoints += _healPointsBar.ChangeHealth;
    }

    private void OnDisable()
    {
        _changeHealPoints -= _healPointsBar.ChangeHealth;
    }

    public void Healing(int value)
    {
        _health = Mathf.Clamp(_healthPoints + value, _minHealthPoints, _maxHealthPoints);

        if(_healthPoints != _health)
        {
            _healthPoints += value;
            _changeHealPoints.Invoke();
        }
    }

    public void Damage(int value)
    {
        _health = Mathf.Clamp(_healthPoints + value, _minHealthPoints, _maxHealthPoints);

        if (_healthPoints != _health)
        {
            _healthPoints += value;
            _changeHealPoints.Invoke();
        }
    }
}
