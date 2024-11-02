using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBall : MonoBehaviour
{
    [SerializeField] private Rigidbody _rigidbody;
    [SerializeField] private float _forcePower = 10f;
    [SerializeField] private float _jumpForcePower = 20f;
    [SerializeField] private AudioSource _audioSource;
    [SerializeField] private bool _isJumped = false; 

    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Jump();
    }

    private void Move()
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
        _rigidbody.AddForce(moveDirection * _forcePower);
    }

    private void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !_isJumped)
        {
            _isJumped = true;
            _audioSource.Play();
            _rigidbody.AddForce(Vector3.up * _jumpForcePower);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        _isJumped = false;
    }
}
