using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class GameUI : MonoBehaviour
{
    [SerializeField] private GameObject _startScreen;
    [SerializeField] private GameObject _gameOverScreen;
    [SerializeField] private TextMeshProUGUI _scoreText;

    public void ShowStartScreen()
    {
        _startScreen.SetActive(true);
    }

    public void ShowGameOverScreen()
    {
        _gameOverScreen.SetActive(true);
    }

    public void HideStartScreen()
    {
        _startScreen.SetActive(false);
    }

    public void HideGameOverScreen()
    {
        _gameOverScreen.SetActive(false);
    }
     public void SetScoreText(int score)
    {
        _scoreText.text = score.ToString();
    }
}
