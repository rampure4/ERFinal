using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PuzzleManager : MonoBehaviour
{
    public GameObject[] puzzlePieceHolder1;
    public GameObject[] puzzlePieceHolder2;
    public GameObject[] puzzlePieceHolder3;
    public UnityEvent win;


    private int purpleCounter;
    private int coralCounter;
    private int blueCounter;

    public void winner()
    {
        if(puzzlePieceHolder1[0].activeInHierarchy && puzzlePieceHolder2[1].activeInHierarchy && puzzlePieceHolder3[2].activeInHierarchy)
        {
            Debug.Log("You Win");
            win.Invoke();
        }
    }

    public void purpleATM()
    {

        purpleCounter++;
        switch (purpleCounter)
        {
            case 0:
                puzzlePieceHolder1[0].SetActive(true);
                puzzlePieceHolder1[1].SetActive(false);
                puzzlePieceHolder1[2].SetActive(false);
                break;
            case 1:
                puzzlePieceHolder1[0].SetActive(false);
                puzzlePieceHolder1[1].SetActive(true);
                puzzlePieceHolder1[2].SetActive(false);
                break;
            case 2:
                puzzlePieceHolder1[0].SetActive(false);
                puzzlePieceHolder1[1].SetActive(false);
                puzzlePieceHolder1[2].SetActive(true);
                break;
            case 3:
                puzzlePieceHolder1[0].SetActive(true);
                puzzlePieceHolder1[1].SetActive(false);
                puzzlePieceHolder1[2].SetActive(false);
                purpleCounter = 0;
                break;
        }
    }

    public void coralATM()
    {
        coralCounter++;
        switch (coralCounter)
        {
            case 0:
                puzzlePieceHolder2[0].SetActive(true);
                puzzlePieceHolder2[1].SetActive(false);
                puzzlePieceHolder2[2].SetActive(false);
                break;
            case 1:
                puzzlePieceHolder2[0].SetActive(false);
                puzzlePieceHolder2[1].SetActive(true);
                puzzlePieceHolder2[2].SetActive(false);
                break;
            case 2:
                puzzlePieceHolder2[0].SetActive(false);
                puzzlePieceHolder2[1].SetActive(false);
                puzzlePieceHolder2[2].SetActive(true);
                break;
            case 3:
                puzzlePieceHolder2[0].SetActive(true);
                puzzlePieceHolder2[1].SetActive(false);
                puzzlePieceHolder2[2].SetActive(false);
                coralCounter = 0;
                break;
        }
    }
    public void blueATM()
    {

        blueCounter++;
        switch (blueCounter)
        {
            case 0:
                puzzlePieceHolder3[0].SetActive(true);
                puzzlePieceHolder3[1].SetActive(false);
                puzzlePieceHolder3[2].SetActive(false);
                break;
            case 1:
                puzzlePieceHolder3[0].SetActive(false);
                puzzlePieceHolder3[1].SetActive(true);
                puzzlePieceHolder3[2].SetActive(false);
                break;
            case 2:
                puzzlePieceHolder3[0].SetActive(false);
                puzzlePieceHolder3[1].SetActive(false);
                puzzlePieceHolder3[2].SetActive(true);
                break;
            case 3:
                puzzlePieceHolder3[0].SetActive(true);
                puzzlePieceHolder3[1].SetActive(false);
                puzzlePieceHolder3[2].SetActive(false);
                blueCounter = 0;
                break;
        }
    }
}
