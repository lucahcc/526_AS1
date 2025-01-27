using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantControll : MonoBehaviour
{
    // 公共变量可以在 Unity 检查器中调整
    public float forwardSpeed = 10f; // 飞机向前飞行的速度
    public float pitchSpeed = 50f; // 飞机俯仰的旋转速度

    private float verticalInput; // 用户输入：上下箭头

    // Start 在游戏开始时调用
    void Start()
    {
        // 初始化逻辑（如有需要）
    }

    // Update 每帧调用一次
    void Update()
    {
        // 获取用户的上下箭头输入
        verticalInput = Input.GetAxis("Vertical");

        // 让飞机以恒定速度向前飞行
        transform.Translate(Vector3.forward * forwardSpeed * Time.deltaTime);

        // 控制飞机的俯仰（机头上下倾斜）
        transform.Rotate(Vector3.right * pitchSpeed * verticalInput * Time.deltaTime);
    }
}
