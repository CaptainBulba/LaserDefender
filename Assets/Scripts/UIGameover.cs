using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIGameover : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI scoreText;
    private ScoreKeeper scoreKeeper;

    private void Awake()
    {
        scoreKeeper = FindObjectOfType<ScoreKeeper>();
    }

    void Start()
    {
        scoreText.text = "You scored:\n" + scoreKeeper.GetScore();
    }
}
