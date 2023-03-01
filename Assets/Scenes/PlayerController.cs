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
    void Update() // �������, ������� �������� ������ ����
    {
        float forward = Input.GetAxis("Vertical"); // ������ ���������� ����� ��� ����, ����� �� ����� ����� ������ ����� �� W � S
        float right = Input.GetAxis("Horizontal");
        GetComponent<Rigidbody>().AddForce(PlayerCamera.transform.forward * Speed * Time.deltaTime * forward); // ��������� ����, ������� ��������� ��������: Vector(x,y,z) � ����������� forward
        GetComponent<Rigidbody>().AddForce(PlayerCamera.transform.right * Speed * Time.deltaTime * right); // ������ ��������� ����� ��� ����, ����� � ��� �������� ������� A � D(�����, ������)
    }
}
