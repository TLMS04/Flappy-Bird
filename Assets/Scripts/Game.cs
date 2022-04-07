using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    [SerializeField] private Bird _bird;
    [SerializeField] private PipeGenerator _pipeGenerator;
    [SerializeField] private GameUI _gameUI;

    private void OnEnable()
    {
        _bird.GameOver += OnGameOver;
        _bird.ScoreChanged += OnScoreChanged;
    }
    private void OnDisable()
    {
        _bird.GameOver -= OnGameOver;
        _bird.ScoreChanged -= OnScoreChanged;
    }
    private void Start()
    {
        Time.timeScale = 0;
        _gameUI.ShowStartScreen();
    }
    public void StartGame()
    {
        _gameUI.HideStartScreen();
        Time.timeScale = 1;
    }
    public void RestartGame()
    {
        _gameUI.HideGameOverScreen();
        _pipeGenerator.ResetPool();
        _bird.ResetPlayer();
        Time.timeScale = 1;
    }
    public void OnGameOver()
    {
        Time.timeScale = 0;
        _gameUI.ShowGameOverScreen();
    }
    public void OnScoreChanged(int score)
    {
        _gameUI.SetScoreText(score);
    }

}
