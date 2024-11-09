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
            // ���� i ��°�� �ڽ� ���� ���� ������Ʈ�� �����´�.
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
            stageNameText.text = $"���� �������� : {SceneManager.GetActiveScene().name}";
        }
        else
        {
            stageNameText.text = "������ ��������";
        }
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = $"���� : {GameManager.Instance.PlayerScore}��";
    }
}
