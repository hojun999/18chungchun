using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.AI;

public class MonsterAI : MonoBehaviour
{
    //Rigidbody rb;
    //Transform tr;
    //public float moveSpeed;
    public Transform monsterStartPos;
    public Transform playerPos;

    NavMeshAgent nav;

    //private float xMove = -1;
    //private float zMove = 0;

    public GameObject restartPanel;

    int destinationNum;

    public Transform[] destinationPos;


    private void Awake()
    {
        Think();
    }
    void Start()
    {
        nav = GetComponent<NavMeshAgent>();

        //rb = GetComponent<Rigidbody>();
        //tr = GetComponent<Transform>();

        //turnRight();

        gameObject.transform.position = monsterStartPos.position;
    }

    void Update()
    {
        //Vector3 movePos = new Vector3(xMove, 0, zMove) * moveSpeed;
        //rb.velocity = movePos;

        if (Vector3.Distance(transform.position, playerPos.position) < 10f)
            nav.destination = playerPos.position;
        else
            nav.destination = destinationPos[destinationNum].position;

    }

    void Think()
    {
        Invoke("Think", 7f);
        GetDestinationNum();
    }

    void GetDestinationNum()
    {
        destinationNum = Random.Range(1, 5);
    }

    //public void goStraight()        // 기준은 가상현실 미로 출발선 방향과 같음 ( > )
    //{
    //    xMove = -1;
    //    zMove = 0;
    //    gameObject.transform.rotation = Quaternion.Euler(0, -90, 0);
    //}

    //public void turnLeft()
    //{
    //    xMove = 0;
    //    zMove = -1;
    //    gameObject.transform.rotation = Quaternion.Euler(0, 180, 0);
    //}

    //public void turnRight()
    //{
    //    xMove = 0;
    //    zMove = 1;
    //    gameObject.transform.rotation = Quaternion.Euler(0, 0, 0);
    //}

    //public void goBack()
    //{
    //    xMove = 1;
    //    zMove = 0;
    //    gameObject.transform.rotation = Quaternion.Euler(0, 90, 0);
    //}

    private void OnTriggerEnter(Collider other)
    {
        //if (other.CompareTag("TurningRight"))
        //    goStraight();        
        //else if (other.CompareTag("TurningLeft"))
        //    goBack();
        //else if (other.CompareTag("TurningUp"))
        //    turnLeft();
        //else if (other.CompareTag("TurningDown"))
        //    turnRight();

        if (other.CompareTag("Player"))
        {
            Time.timeScale = 0;
            restartPanel.SetActive(true);
        }
    }

    public void restart()
    {
        SceneManager.LoadScene("Maze");
        Time.timeScale = 1;
    }

    public void LoadMaze()
    {
        SceneManager.LoadScene("Maze");
    }
}
