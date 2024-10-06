using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class ThrowArrow : MonoBehaviour
{
    [SerializeField, Tooltip("gomi")]
    private GameObject ThrowingObject;

    [SerializeField, Range(0F, 90F), Tooltip("射出する角度")]
    private float ThrowingAngle;
    public Vector3 pos;
    private void Start()
    {
        Collider collider = GetComponent<Collider>();
        if (collider != null)
        {
            // 干渉しないようにisTriggerをつける
            collider.isTrigger = true;
        }
    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            // マウス左クリックでボールを射出する
            ThrowingBall();
            pos = Camera.main.ScreenToViewportPoint(Input.mousePosition);
        }
    }

    private void ThrowingBall()
    {
        if (ThrowingObject != null)
        {
            // Ballオブジェクトの生成
            GameObject ball = Instantiate(ThrowingObject, this.transform.position, Quaternion.identity);

            // 射出角度
            float angle = ThrowingAngle;

            // 射出
            Rigidbody rid = ball.GetComponent<Rigidbody>();
            rid.AddForce(pos,ForceMode.Impulse);
        }
        else
        {
            throw new System.Exception("射出するオブジェクトまたは標的のオブジェクトが未設定です。");
        }
    }
}
