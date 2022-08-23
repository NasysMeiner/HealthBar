using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    [SerializeField] private HealPointsBar _healPointsBar;

    private int _healthPoints = 70;
    private int _maxHealthPoints = 100;
    private int _minHealthPoints = 0;
    private int _health;

    private UnityEvent �hangeHealPoints = new UnityEvent();

    public event UnityAction On�hangeHealPoints
    {
        add => �hangeHealPoints.AddListener(value);
        remove => �hangeHealPoints.RemoveListener(value);
    }

    public int HealthPoints => _healthPoints;
    public int MaxHealthPoints => _maxHealthPoints;

    public void Healing(int value)
    {
        _health = Mathf.Clamp(_healthPoints + value, _minHealthPoints, _maxHealthPoints);

        if(_healthPoints != _health)
        {
            _healthPoints += value;
            �hangeHealPoints.Invoke();
        }
    }

    public void Damage(int value)
    {
        _health = Mathf.Clamp(_healthPoints + value, _minHealthPoints, _maxHealthPoints);

        if (_healthPoints != _health)
        {
            _healthPoints += value;
            �hangeHealPoints.Invoke();
        }
    }
}
