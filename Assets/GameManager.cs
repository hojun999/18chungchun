using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    //public GameObject playerText;
    //public GameObject Title;
    //public GameObject startButton;



    private void Start()
    {
        //Time.timeScale = 0;
    }

    public void StartMaze()
    {
        //Time.timeScale = 1;
        //playerText.SetActive(true);
        //startButton.SetActive(false);
        //Title.SetActive(false);
        SceneManager.LoadScene("Maze");
    }

}
