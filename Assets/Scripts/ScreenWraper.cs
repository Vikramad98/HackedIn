using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenWraper : MonoBehaviour
{

    private Transform playerTransform;
    float maxX = 3.25f;
    float minX = -3.25f;
    float maxY = 5.5f;
    float minY = -5.5f; 
    // Start is called before the first frame update
    void Start()
    {
        playerTransform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerTransform.position.x > maxX)
        {
            playerTransform.position = new Vector3(minX, transform.position.y, transform.position.z);
        }

        // If the player exceeds the left side of the screen.
        if (playerTransform.position.x < minX)
        {
            playerTransform.position = new Vector3(maxX, transform.position.y, transform.position.z);
        }
        if (playerTransform.position.y > maxY)
        {
            playerTransform.position = new Vector3(transform.position.x, minY, transform.position.z);
        }

        // If the player exceeds the down side of the screen.
        if (playerTransform.position.y < minY)
        {
            playerTransform.position = new Vector3(transform.position.x, maxY, transform.position.z);
        }
    }
}
