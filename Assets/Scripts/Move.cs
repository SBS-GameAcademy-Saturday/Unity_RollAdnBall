using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Move : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(0,0,-6);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 moveDirection = new Vector3(0,0,0);
        // Ű������ �Է��� �޴´�.
        if (Input.GetKey(KeyCode.W))// ������ �̵��Ѵ�.
        {
            moveDirection.z = 1;
            Debug.Log("WŰ�� �Է��߽��ϴ�.");
        }
        if (Input.GetKey(KeyCode.A))// �������� �̵��Ѵ�.
        {
            moveDirection.x = -1;
            Debug.Log("AŰ�� �Է��߽��ϴ�.");
        }
        if (Input.GetKey(KeyCode.S))// �ڷ� �̵��Ѵ�.
        {
            moveDirection.z = -1;
            Debug.Log("SŰ�� �Է��߽��ϴ�.");
        }
        if (Input.GetKey(KeyCode.D))// �����ʷ� �̵��Ѵ�.
        {
            moveDirection.x = 1;
            Debug.Log("DŰ�� �Է��߽��ϴ�.");
        }
        if (Input.GetKey(KeyCode.Q))// ���� �̵��Ѵ�.
        {
            moveDirection.y = -1;
            Debug.Log("QŰ�� �Է��߽��ϴ�.");
        }
        if (Input.GetKey(KeyCode.E))// �Ʒ��� �̵��Ѵ�.
        {
            moveDirection.y = 1;
            Debug.Log("EŰ�� �Է��߽��ϴ�.");
        }

        transform.position += moveDirection * Time.deltaTime;
    }
}
