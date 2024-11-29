using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnClickS : MonoBehaviour
{
    float down = 0.1f;
    Vector3 originalPosition;
    void Start()
    {
        originalPosition = transform.position;

    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            transform.position = originalPosition - new Vector3(0, down, 0);
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            transform.position = originalPosition;
        }

    }
}
