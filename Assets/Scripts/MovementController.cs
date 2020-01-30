using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour
{
    // Скорость передвижения игрока
    [SerializeField] private float speed = 10.0f;
    [SerializeField] private float upDownSpeed = 0.1f;

    // Компонент CharacterController
    private CharacterController cc;

    void Start() {
        // Получаем компонент CharacterController
        cc = GetComponent<CharacterController>();
    }

    void FixedUpdate() {
        // Получаем нажатия предустановленных клавиш
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        // Записываем данные в отдельную переменную
        Vector2 input = new Vector2(horizontal, vertical);
        // Определяем направление движения
        Vector3 desiredMove = transform.forward * input.y + transform.right * input.x;
        Vector3 moveDir = new Vector3(desiredMove.x * speed, 0, desiredMove.z * speed);
        // Передвигаем объект
        cc.Move(moveDir * Time.fixedDeltaTime);

        if (Input.GetKey("space")) {
            cc.Move(new Vector3(0, 1 * upDownSpeed, 0));
            Debug.Log("пробел");
        }

        if (Input.GetKey("c"))
        {
            cc.Move(new Vector3(0, -1 * upDownSpeed, 0));
            Debug.Log("пробел");
        }

    }
}
