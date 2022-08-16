using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Creature))]
public class CreatireCollisionHandler : MonoBehaviour
{
    private Creature _creature;
    private float _timeSinceLastScore;
    private float _scoreCoolDown = 1;

    private void Start()
    {
        _creature = GetComponent<Creature>();
    }

    private void Update()
    {
        _timeSinceLastScore += Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out ScoreZone scoreZone))
        {
            if(_timeSinceLastScore >= _scoreCoolDown)
            {
                _creature.IncreaseScore();
                _timeSinceLastScore = 0;
            }
        }
        else
        {
            _creature.Die();
        }
    }
}
