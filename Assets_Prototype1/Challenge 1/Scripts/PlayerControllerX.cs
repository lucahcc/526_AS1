using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public float speed = 10f; // 飞机的前进速度
    public float rotationSpeed = 50f; // 飞机的俯仰旋转速度
    private float verticalInput; // 上下箭头的输入值

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // 获取用户的上下箭头输入
        verticalInput = Input.GetAxis("Vertical");

        // 飞机以恒定速度向前飞行
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        // 根据用户输入控制飞机俯仰（仅响应上下箭头）
        transform.Rotate(Vector3.right * rotationSpeed * verticalInput * Time.deltaTime);
        Debug.Log("Vertical Input: " + verticalInput);

    }
}
