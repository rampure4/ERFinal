using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public GameObject[] puzzlePieceHolder1;
    public void LoadGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        puzzlePieceHolder1[0].SetActive(false);

    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit!");

    }
}
