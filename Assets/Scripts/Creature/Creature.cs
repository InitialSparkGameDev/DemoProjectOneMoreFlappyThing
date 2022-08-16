using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(CreatureMover))]
public class Creature : MonoBehaviour
{
    private CreatureMover _mover;
    private int _score;

    public event UnityAction GameOver;

    public event UnityAction<int> ScoreChanged;

    private void Start()
    {
        _mover = GetComponent<CreatureMover>();
    }

    public void ResetPleyer()
    {
        _score = 0;
        _mover.ResetCreature();
        ScoreChanged?.Invoke(_score);
    }

    public void IncreaseScore()
    {
        _score++;
        ScoreChanged?.Invoke(_score);
    }

    public void Die()
    {
        GameOver?.Invoke();
        Time.timeScale = 0;
    }
}
