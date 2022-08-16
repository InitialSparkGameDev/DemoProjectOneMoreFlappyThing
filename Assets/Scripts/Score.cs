using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    [SerializeField] private Creature _creature;
    [SerializeField] private TMP_Text _score;

    private void OnEnable()
    {
        _creature.ScoreChanged += OnScoreChanged;
    }

    private void OnDisable()
    {
        _creature.ScoreChanged -= OnScoreChanged;
    }

    private void OnScoreChanged(int score)
    {
        _score.text = score.ToString();
    }
}
