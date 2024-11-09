using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // 해당 객체의 인스턴스를 static 변수로 선언한다.
    private static GameManager instance;

    public static GameManager Instance 
    { 
        get 
        {
            // 현재 인스턴스가 NULL
            if (instance == null)
            {
                //GameObject클래스를 만들어 주는 데 
                // 이름은 GameManager, 타입(기본 컴포넌트)는 GameManager
                GameObject obj = new GameObject(nameof(GameManager), typeof(GameManager));
                
                // instance에 새로 만든 GameObject에서 GameManager 클래스를 가져온다.
                instance = obj.GetComponent<GameManager>();

                // DontDestroyOnLoad 해당 GameObject를 파괴하지 않는다.
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
