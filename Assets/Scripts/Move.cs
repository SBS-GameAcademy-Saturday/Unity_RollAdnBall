using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Move : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 moveDirection = new Vector3(0,0,0);
        // Ű������ �Է��� �޴´�.
        if (Input.GetKey(KeyCode.W))// ������ �̵��Ѵ�.
        {
            moveDirection.z = 1;
        }
        if (Input.GetKey(KeyCode.A))// �������� �̵��Ѵ�.
        {
            moveDirection.x = -1;
        }
        if (Input.GetKey(KeyCode.S))// �ڷ� �̵��Ѵ�.
        {
            moveDirection.z = -1;
        }
        if (Input.GetKey(KeyCode.D))// �����ʷ� �̵��Ѵ�.
        {
            moveDirection.x = 1;
        }
        if (Input.GetKey(KeyCode.Q))// ���� �̵��Ѵ�.
        {
            moveDirection.y = -1;
        }
        if (Input.GetKey(KeyCode.E))// �Ʒ��� �̵��Ѵ�.
        {
            moveDirection.y = 1;
        }

        transform.position += moveDirection * Time.deltaTime;
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log($"{transform.gameObject.name} Collision Enter To {collision.gameObject.name}");
    }

    private void OnCollisionStay(Collision collision)
    {
        Debug.Log($"{transform.gameObject.name} Collision Stay To {collision.gameObject.name}");
    }

    private void OnCollisionExit(Collision collision)
    {
        Debug.Log($"{transform.gameObject.name} Collision Exit To {collision.gameObject.name}");
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log($"{transform.gameObject.name} Treiger Enter To {other.gameObject.name}");
    }

    private void OnTriggerStay(Collider other)
    {
        Debug.Log($"{transform.gameObject.name} Treiger Stay To {other.gameObject.name}");
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log($"{transform.gameObject.name} Treiger Exit To {other.gameObject.name}");
    }


}
