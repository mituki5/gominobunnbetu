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
    //Click������u�Ԉړ�

    //Click�Ői�s
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

    
    //���݂̈ړ���
    public void Movingtrash()
    {
        int num = 0;
        switch (num)
        {
            //����
            case 0:
                break;
            //�y�b�g�{�g��
            case 1:
                break;

        }
    }


}
