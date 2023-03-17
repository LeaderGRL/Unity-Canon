using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager instance;
    [SerializeField] private Score score;
    // Start is called before the first frame update
    void Start()
    {
        if (instance == null)
        {
            instance = this;
        }
        
        //score = new Score();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public static GameManager GetInstance()
    {
        return instance;
    }

    public Score GetScore()
    {
        return score;
    }
}
