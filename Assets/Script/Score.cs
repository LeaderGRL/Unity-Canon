using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    private float scorePoint = 0;
    public GameObject scoreText;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<TextMeshProUGUI>().text = scorePoint.ToString();

    }

    public void AddScore(float point)
    {
        scorePoint += point;
        //scoreText.text = "a";
        Debug.Log("scorePoint : " + scorePoint.ToString());
        GetComponent<TextMeshProUGUI>().text = scorePoint.ToString();
    }

    public float GetScore()
    {
        return scorePoint;
    }

}
