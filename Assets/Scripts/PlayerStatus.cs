using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerStatus : MonoBehaviour
{
    public GameObject player;
    public GameObject winText;
    public GameObject loseText;

    public void GameWin()
    {
        winText.SetActive(true);
        StartCoroutine(WinReset());
    }
    
    public void DestroyPlayer()
    {
        StartCoroutine(DeathAnimation());
        Destroy(player);
    }

    IEnumerator DeathAnimation()
    {
        loseText.SetActive(true);
        
        yield return new WaitForSeconds(1.5f);

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    
    IEnumerator WinReset()
    {
        yield return new WaitForSeconds(3f);

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    
}
