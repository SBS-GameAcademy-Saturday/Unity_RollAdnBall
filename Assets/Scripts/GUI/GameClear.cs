using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameClear : MonoBehaviour
{
    [SerializeField] private Button nextButton;
    [SerializeField] private Button replayButton;
    [SerializeField] private Button quitButton;

    private void Start()
    {
        nextButton.onClick.AddListener(OnClickedNextButton);
        replayButton.onClick.AddListener(OnClickedReplayButton);
        quitButton.onClick.AddListener(OnClickedQuitButton);

        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        int sceneCount = SceneManager.sceneCountInBuildSettings;
        nextButton.gameObject.SetActive(currentSceneIndex < sceneCount - 1);
    }

    private void OnClickedNextButton()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        int sceneCount = SceneManager.sceneCountInBuildSettings;
        if(currentSceneIndex + 1 >= sceneCount)
        {
            return;
        }
        SceneManager.LoadScene(currentSceneIndex + 1);
        Debug.Log("���� ���������� �̵��մϴ�.");
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
