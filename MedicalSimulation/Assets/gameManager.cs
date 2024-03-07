using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManager : MonoBehaviour
{
    public GameObject cells;
    public Animator virsusCell;
    public PlayerMovement movement;
    private void Start()
    {
        Invoke("startProcess", 3);
    }

    void startProcess()
    {
        cells.SetActive(true);
        virsusCell.enabled = false;
    }

    private void Update()
    {
        if (movement.enabledPlayer == true)
        {
            if (Input.GetKey(KeyCode.Space))
            {
                movement.enabled = true;
                movement.enabledPlayer = false;
            }
        }
    }
}
