using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    private int score;
    [SerializeField] private TMP_Text scoreLabel;

    private void OnEnable()
    {
        Brick.OnBreak += IncrementScore;
    }

    private void OnDisable()
    {
        Brick.OnBreak -= IncrementScore;
    }

    private void Start()
    {
        UpdateScoreLabel();
    }

    private void IncrementScore()
    {
        score++;
        UpdateScoreLabel();
    }

    private void UpdateScoreLabel()
    {
        scoreLabel.text = score.ToString();
    }
}
