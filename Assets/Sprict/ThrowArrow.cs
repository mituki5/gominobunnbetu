using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class ThrowArrow : MonoBehaviour
{
    [SerializeField, Tooltip("gomi")]
    private GameObject ThrowingObject;

    [SerializeField, Range(0F, 90F), Tooltip("�ˏo����p�x")]
    private float ThrowingAngle;
    public Vector3 pos;
    private void Start()
    {
        Collider collider = GetComponent<Collider>();
        if (collider != null)
        {
            // �����Ȃ��悤��isTrigger������
            collider.isTrigger = true;
        }
    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            // �}�E�X���N���b�N�Ń{�[�����ˏo����
            ThrowingBall();
            pos = Camera.main.ScreenToViewportPoint(Input.mousePosition);
        }
    }

    private void ThrowingBall()
    {
        if (ThrowingObject != null)
        {
            // Ball�I�u�W�F�N�g�̐���
            GameObject ball = Instantiate(ThrowingObject, this.transform.position, Quaternion.identity);

            // �ˏo�p�x
            float angle = ThrowingAngle;

            // �ˏo
            Rigidbody rid = ball.GetComponent<Rigidbody>();
            rid.AddForce(pos,ForceMode.Impulse);
        }
        else
        {
            throw new System.Exception("�ˏo����I�u�W�F�N�g�܂��͕W�I�̃I�u�W�F�N�g�����ݒ�ł��B");
        }
    }
}
