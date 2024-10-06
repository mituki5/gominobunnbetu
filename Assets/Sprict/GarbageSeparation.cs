using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GarbageSeparation : MonoBehaviour
{
    private Vector2 Pos;
    public float Speed = 5.0f;

    private void Start()
    {
        
    }
    //Clickしたら瞬間移動

    //Clickで進行
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //Movingtrash();
            Pos = Camera.main.ScreenToViewportPoint(Input.mousePosition);
            this.gameObject.transform.position = Input.mousePosition;
            transform.position = Vector3.Lerp(transform.position, Pos, Speed * Time.deltaTime);
        }
    }

    
    //ごみの移動先
    public void Movingtrash()
    {
        int num = 0;
        switch (num)
        {
            //紙屑
            case 0:
                break;
            //ペットボトル
            case 1:
                break;

        }
    }


}
