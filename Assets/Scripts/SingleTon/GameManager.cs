using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // �ش� ��ü�� �ν��Ͻ��� static ������ �����Ѵ�.
    private static GameManager instance;

    public static GameManager Instance 
    { 
        get 
        {
            // ���� �ν��Ͻ��� NULL
            if (instance == null)
            {
                //GameObjectŬ������ ����� �ִ� �� 
                // �̸��� GameManager, Ÿ��(�⺻ ������Ʈ)�� GameManager
                GameObject obj = new GameObject(nameof(GameManager), typeof(GameManager));
                
                // instance�� ���� ���� GameObject���� GameManager Ŭ������ �����´�.
                instance = obj.GetComponent<GameManager>();

                // DontDestroyOnLoad �ش� GameObject�� �ı����� �ʴ´�.
                // => Persistent Single Ton
                // DontDestroyOnLoad(obj);
            }
            return instance; 
        } 
    }

    [SerializeField] private int _playerScore = 0;

    public int PlayerScore => _playerScore;

    [SerializeField] private PlayerBall _playerBall;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        _playerBall = FindObjectOfType<PlayerBall>();
    }

    public void StopPlayerBall()
    {
        _playerBall.enabled = false;
    }

    public void IncreasePlayerScore(int amount)
    {
        _playerScore += amount;
    }

    public void DecreasePlayerScore(int amount)
    {
        _playerScore -= amount; 
    }

    public void ReSetPlayerScore()
    {
        _playerScore = 0;
    }
}
