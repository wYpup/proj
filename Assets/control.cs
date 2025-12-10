using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class control : MonoBehaviour
{
    [SerializeField] float speed = 5;//Скорость змейки
    [SerializeField] float rotateSpeed = 3;//Скорость поворота
    Rigidbody rb;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        float horizontal = Input.GetAxis("Horizontal") * rotateSpeed;//Считывание нажатий влево-вправо и умножение на скорость вращения
        transform.Rotate(Vector3.up * horizontal, Space.World);//Поворот змейки по глобальной оси Y
    }
    private void FixedUpdate()
    {
        //Толкать змейку локально вперёд (по оси X - право, потому что у тебя объект повёрнут на бок)
        rb.AddRelativeForce(Vector3.right * speed, ForceMode.Force);
    }


    public AppleSpawner spawner;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Apple"))
        {
           
            Destroy(other.gameObject);

            if (spawner != null)
            {
                spawner.SpawnNewApple();
            }
        }
    }
}
