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
            Debug.Log("W키를 입력했습니다.");
        }
        if (Input.GetKey(KeyCode.A))// 왼쪽으로 이동한다.
        {
            moveDirection.x = -1;
            Debug.Log("A키를 입력했습니다.");
        }
        if (Input.GetKey(KeyCode.S))// 뒤로 이동한다.
        {
            moveDirection.z = -1;
            Debug.Log("S키를 입력했습니다.");
        }
        if (Input.GetKey(KeyCode.D))// 오른쪽로 이동한다.
        {
            moveDirection.x = 1;
            Debug.Log("D키를 입력했습니다.");
        }

        transform.position += moveDirection * Time.deltaTime;
    }
}
