using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    private Score score;
    // Start is called before the first frame update
    void Start()
    {
        score = new Score();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        score.AddScore(100);
    }
}
