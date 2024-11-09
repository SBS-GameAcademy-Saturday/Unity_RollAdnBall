using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GUIManager : MonoBehaviour
{
    private static GUIManager instance;

    public static GUIManager Instance
    {
        get
        {
            if (instance == null)
            {
                GameObject obj = new GameObject(nameof(GUIManager),typeof(GUIManager));
                instance = obj.GetComponent<GUIManager>();
                instance.Initialize();
            }
            return instance;
        }
    }

    [SerializeField] private GameClear gameClearGUI;
    [SerializeField] private GameOver gameOverGUI;

    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        Initialize();
    }

    public void Initialize()
    {
        if(gameClearGUI == null) gameClearGUI = FindObjectOfType<GameClear>(true);
        if(gameOverGUI == null) gameOverGUI = FindObjectOfType<GameOver>(true);
    }

    public void ShowGameClear()
    {
        gameClearGUI.gameObject.SetActive(true);
    }

    public void ShowGameOver() 
    {
        gameOverGUI.gameObject.SetActive(true);
    }
}
