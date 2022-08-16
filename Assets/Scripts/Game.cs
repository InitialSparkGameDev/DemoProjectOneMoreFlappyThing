using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    [SerializeField] private Creature _creature;
    [SerializeField] private HitSurfacesGenerator _hitSurfacesGenerator;
    [SerializeField] private RestartScreen _restartScreen;

    private void OnEnable()
    {
        _restartScreen.RestartButtonClick += OnRestartButtonClick;
        _creature.GameOver += OnGameOver;
    }

    private void OnDisable()
    {
        _restartScreen.RestartButtonClick -= OnRestartButtonClick;
        _creature.GameOver += OnGameOver;
    }

    private void OnRestartButtonClick()
    {
        _restartScreen.Close();
        _hitSurfacesGenerator.ResetPool();
        StartGame();
    }

    private void StartGame()
    {
        Time.timeScale = 1;
        _creature.ResetPleyer();
    }

    public void OnGameOver()
    {
        Time.timeScale = 0;
        _restartScreen.Open();
    }
}
