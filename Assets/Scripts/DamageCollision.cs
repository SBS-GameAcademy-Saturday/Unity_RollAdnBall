using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageCollision : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GUIManager.Instance.ShowGameOver();
            GameManager.Instance.StopPlayerBall();
        }
    }
}
