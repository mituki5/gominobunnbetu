using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public int Power = 5;
    public Vector3 force;

    void Start()
    {
        force = this.transform.position;
    }

    void Update()
    {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();

        if(Input.GetMouseButtonDown(0))
        {
            force = new  Vector3(Power, 5, 0);
            rb.AddForce(force, ForceMode2D.Impulse);
        }
    }
}
