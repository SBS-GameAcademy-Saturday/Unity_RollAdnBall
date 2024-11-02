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
        // 키보드의 입력을 받는다.
        if (Input.GetKey(KeyCode.W))// 앞으로 이동한다.
        {
            moveDirection.z = 1;
        }
        if (Input.GetKey(KeyCode.A))// 왼쪽으로 이동한다.
        {
            moveDirection.x = -1;
        }
        if (Input.GetKey(KeyCode.S))// 뒤로 이동한다.
        {
            moveDirection.z = -1;
        }
        if (Input.GetKey(KeyCode.D))// 오른쪽로 이동한다.
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
