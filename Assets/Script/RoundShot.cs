using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoundShot : MonoBehaviour
{
    bool hasCollide = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (hasCollide)
            return;
        
        if (collision.gameObject.CompareTag("Target"))
        {
            Debug.Log("Collision");
            GameManager.GetInstance().GetScore().AddScore(100.0f);
        }

        hasCollide = true;
    }
}
