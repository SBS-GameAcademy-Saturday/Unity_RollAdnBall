using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    [SerializeField] private float _speed = 5f;
    [SerializeField] private AudioSource _audioSource;

    // Start is called before the first frame update
    void Start()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up * Time.deltaTime * _speed, Space.World);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            //_audioSource.PlayOneShot(_audioSource.clip);
            AudioSource.PlayClipAtPoint(_audioSource.clip, transform.position,_audioSource.volume);
            GameManager.Instance.IncreasePlayerScore(10);
            Destroy(gameObject);
        }
    }
}
