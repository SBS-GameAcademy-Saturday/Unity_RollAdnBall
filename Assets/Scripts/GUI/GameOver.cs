using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    [SerializeField] private Button replayButton;
    [SerializeField] private Button quitButton;

    private void Start()
    {
        replayButton.onClick.AddListener(OnClickedReplayButton);
        quitButton.onClick.AddListener (OnClickedQuitButton);
    }

    private void OnClickedReplayButton()
    {
        //Debug.Log("다시 시작 버튼이 눌렸습니다.");
        string currentSceneName = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(currentSceneName);
    }

    private void OnClickedQuitButton()
    {
        //Debug.Log("종료하기 버튼이 눌렸습니다.");
        Application.Quit();
    }

}
