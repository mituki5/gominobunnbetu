using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loop : MonoBehaviour
{
    private float speed = 1;

    void Update()
    {
        transform.position -= new Vector3(Time.deltaTime * speed, 0, 0);

        if (transform.position.x <= -10f)
        {
            transform.position = new Vector3(8, 2.5f, 0);
        }
    }
}
