using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float Speed = 10;
    public Camera PlayerCamera;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    /* 
         Main Loop 
        - Physics 
        - Logic
        - Camera 
        - UI
        - Render
         */
    void Update() // функция, которая вызывает каждый кадр
    {
        float forward = Input.GetAxis("Vertical"); // данная переменная нужна для того, чтобы мы могли шарик катить самим на W и S
        float right = Input.GetAxis("Horizontal");
        GetComponent<Rigidbody>().AddForce(PlayerCamera.transform.forward * Speed * Time.deltaTime * forward); // добавляем силу, который принимает значение: Vector(x,y,z) и направление forward
        GetComponent<Rigidbody>().AddForce(PlayerCamera.transform.right * Speed * Time.deltaTime * right); // данный компонент нужен для того, чтобы у нас работали клавиши A и D(влево, вправо)
    }
}
