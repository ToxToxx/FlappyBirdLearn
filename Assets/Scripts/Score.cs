using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    private const string HIGHSCORE = "Highscore";

    public static Score Instance;

    [SerializeField] private TextMeshProUGUI _currentScoreText;
    [SerializeField] private TextMeshProUGUI _highestScoreText;

    private int _score;
    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
        }
    }

    private void Start()
    {
        _currentScoreText.text = _score.ToString();

        _highestScoreText.text = PlayerPrefs.GetInt(HIGHSCORE, 0).ToString();

        UpdateHighScore();

    }

    private void UpdateHighScore()
    {
        if (_score > PlayerPrefs.GetInt(HIGHSCORE))
        {
            PlayerPrefs.SetInt(HIGHSCORE, _score);
            _highestScoreText.text = _score.ToString();
        }
    }

    public void UpdateScore()
    {
        _score++;
        _currentScoreText.text = _score.ToString();
        UpdateHighScore();
    }
}
