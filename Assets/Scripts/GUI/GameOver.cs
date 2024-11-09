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
        //Debug.Log("�ٽ� ���� ��ư�� ���Ƚ��ϴ�.");
        string currentSceneName = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(currentSceneName);
    }

    private void OnClickedQuitButton()
    {
        //Debug.Log("�����ϱ� ��ư�� ���Ƚ��ϴ�.");
        Application.Quit();
    }

}
