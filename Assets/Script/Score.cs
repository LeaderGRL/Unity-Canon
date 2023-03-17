using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    private float scorePoint = 0;
    [SerializeField] private TextMeshProUGUI scoreText;
  
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = scorePoint.ToString();
    }

    public void AddScore(float point)
    {
        Debug.Log("point : " + point);
        scorePoint += point;
        Debug.Log("scorePoint : " + scorePoint);
    }

    public float GetScore()
    {
        return scorePoint;
    }

}
