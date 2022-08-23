using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    [SerializeField] private UnityEvent _changeHealPoints;

    private int _healthPoints = 70;
    private int _maxHealthPoints = 100;
    private int _minHealthPoints = 0;

    public int HealthPoints => _healthPoints;
    public int MaxHealthPoints => _maxHealthPoints;

    public void ChangeHealPoints(int value)
    {
        if(value > 0)
        {
            if (_healthPoints < _maxHealthPoints && _healthPoints != _maxHealthPoints)
            {
                _healthPoints += value;
                _changeHealPoints.Invoke();
            }           
        }
        else
        {
            if (_healthPoints != _minHealthPoints && _healthPoints > _minHealthPoints)
            {
                _healthPoints += value;
                _changeHealPoints.Invoke();
            }
        }
    }
}
