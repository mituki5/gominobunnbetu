using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float Power = 10.0f;
    public bool KeyOFF = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {

            //int i  = 0;
            //if(++i <= 100)
            //{
                    //Power = i;
                    //—Í‚Ì•ûŒü
                    Vector3 forceDirection = new Vector3(3, Power, 0);
                    float forceMagnitude= 10.0f;
                    Vector3 force = forceMagnitude * forceDirection;
                    Rigidbody2D rb = gameObject.GetComponent<Rigidbody2D>();
                    rb.AddForce(force,ForceMode2D.Impulse);
            //}
            //i(power)‚ª‚P‚O‚O‚É‚È‚Á‚½‚çi(power)‚ª‰º‚ª‚é
            //if(--i > 0)
            //{
            //    Power = i;
            //}

        }
    }
}
