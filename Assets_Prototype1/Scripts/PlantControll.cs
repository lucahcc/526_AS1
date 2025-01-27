using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantControll : MonoBehaviour
{
    // �������������� Unity ������е���
    public float forwardSpeed = 10f; // �ɻ���ǰ���е��ٶ�
    public float pitchSpeed = 50f; // �ɻ���������ת�ٶ�

    private float verticalInput; // �û����룺���¼�ͷ

    // Start ����Ϸ��ʼʱ����
    void Start()
    {
        // ��ʼ���߼���������Ҫ��
    }

    // Update ÿ֡����һ��
    void Update()
    {
        // ��ȡ�û������¼�ͷ����
        verticalInput = Input.GetAxis("Vertical");

        // �÷ɻ��Ժ㶨�ٶ���ǰ����
        transform.Translate(Vector3.forward * forwardSpeed * Time.deltaTime);

        // ���Ʒɻ��ĸ�������ͷ������б��
        transform.Rotate(Vector3.right * pitchSpeed * verticalInput * Time.deltaTime);
    }
}
