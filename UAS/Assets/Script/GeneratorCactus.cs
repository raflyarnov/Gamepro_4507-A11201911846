using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratorCactus : MonoBehaviour
{
   // Start is called before the first frame update
    public GameObject cactus;
    void Start()
    {
        InvokeRepeating("CreateObstacle", 0.8f, 1.3f);
    }
    void CreateObstacle()
    {
        if (ScoreManager.instance.GetScore() > 5 && Random.Range(1,10) >= 8 ) {
            Instantiate(cactus);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
