using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveTowards : MonoBehaviour
{

    public GameObject movePos;
    private Transform startingPos;
    private bool changePos = false;
    private void Start()
    {
        movePos = GameObject.Find("Virus");
        //startingPos.position = transform.position;
        Invoke("setTrue", 5);
    }

    private void Update()
    {
        if (changePos == false)
        {
            transform.position = Vector3.MoveTowards(transform.position, movePos.transform.position, 0.05f * Time.deltaTime);
        }
        //else
        //{
        //    transform.position = Vector3.MoveTowards(transform.position, startingPos.transform.position, 0.05f * Time.deltaTime);
        //}
    }

    public void setTrue()
    {
        changePos = true;
    }


}
