using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class DestroyOutOfBounds : MonoBehaviour
{
    // Start is called before the first frame update
    private float topBound = 20;
    private float lowerBound = -10;
    private GameManager gameManager;
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < lowerBound)
        {
            gameManager.AddLives(-1);
            Destroy(gameObject);
        }
        else if (transform.position.x < -25)
        {
            gameManager.AddLives(-1);
            Destroy(gameObject);
        }
    }
}
