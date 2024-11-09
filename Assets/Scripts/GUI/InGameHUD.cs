using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InGameHUD : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI scoreText;
    [SerializeField] TextMeshProUGUI stageNameText;
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < transform.childCount; i++)
        {
            // 현재 i 번째의 자식 계층 게임 오브젝트를 가져온다.
            GameObject child = transform.GetChild(i).gameObject;
            if (child.name == "ScoreText")
            {
                scoreText = child.GetComponent<TextMeshProUGUI>();
            }
            if(child.name == "StageNameText")
            {
                stageNameText = child.GetComponent<TextMeshProUGUI>();
            }
        }
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        int sceneCount = SceneManager.sceneCountInBuildSettings;
        if(currentSceneIndex < sceneCount - 1)
        {
            stageNameText.text = $"현재 스테이지 : {SceneManager.GetActiveScene().name}";
        }
        else
        {
            stageNameText.text = "마지막 스테이지";
        }
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = $"점수 : {GameManager.Instance.PlayerScore}점";
    }
}
