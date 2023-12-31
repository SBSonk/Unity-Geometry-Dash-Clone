using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLine : MonoBehaviour
{
    public AudioSource finishMusic;
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            FindObjectOfType<PlayerStatus>().GameWin();
            finishMusic.Play();
        }
    }
}
