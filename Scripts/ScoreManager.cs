using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static int score = 0;                            // Score
    public static int missedBox = 0;                        // Count of missed box
    [SerializeField]
    private TextMeshProUGUI ScoreText;  

    private void Start()
    {
        //ScoreText = GetComponent<TextMeshProUGUI>();
    }

    private void Update()
    {
        ScoreText.text = "Score:" + score;
    }

}
