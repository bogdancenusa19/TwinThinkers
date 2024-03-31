using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideScore : MonoBehaviour
{
    [SerializeField] private GameObject score;
    
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player") || col.CompareTag("Player2"))
        {
            score.SetActive(false);
        }
    }

    private void OnTriggerExit2D(Collider2D col)
    {
        if (col.CompareTag("Player") || col.CompareTag("Player2"))
        {
            Invoke("SetScoreActive", 0.5f);
        }
    }

    private void SetScoreActive()
    {
        score.SetActive(true);
    }
}
