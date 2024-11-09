using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GUIManager.Instance.ShowGameClear();
            GameManager.Instance.StopPlayerBall();
        }
    }
}
