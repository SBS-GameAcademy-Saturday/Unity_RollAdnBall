using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tank : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 moveDirection = new Vector3(0, 0, 0);
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

        //transform.Translate(moveDirection * Time.deltaTime);

        //transform.position = 
        //    Vector3.MoveTowards(transform.position, transform.position + (moveDirection), Time.deltaTime);

        transform.position += transform.TransformDirection(moveDirection * Time.deltaTime);
        //transform.Translate += moveDirection * Time.deltaTime;
    }
}
