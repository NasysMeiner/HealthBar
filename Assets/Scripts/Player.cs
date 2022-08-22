using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private int _healthPoints;

    private int _value = 10;
    private int _maxHealthPoints = 100;
    private int _minHealthPoints = 0;

    public int HealthPoints { get { return _healthPoints; } private set { } }

    public void HealingPlayer()
    {
        if(_healthPoints != _maxHealthPoints)
        {
            _healthPoints += _value;
        }
    }

    public void DamagePlayer()
    {
        if(_healthPoints != _minHealthPoints)
        {
            _healthPoints -= _value;
        }
    }
}
