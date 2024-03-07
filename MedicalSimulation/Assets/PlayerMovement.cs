using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f; // Speed of movement
    public GameObject cytokines;
    public Transform [] spawnPoint;
    public bool enabledPlayer = false;
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // Calculate the horizontal and vertical movement amounts based on the input and speed
        float horizontalMovement = horizontalInput * speed * Time.deltaTime;
        float verticalMovement = verticalInput * speed * Time.deltaTime;

        // Move the GameObject
        transform.Translate(new Vector2(horizontalMovement, verticalMovement));
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.tag=="epithelial")
        {
            Instantiate(cytokines, spawnPoint[Random.Range(0, 20)]);
            Instantiate(cytokines, spawnPoint[Random.Range(0, 20)]);
            Instantiate(cytokines, spawnPoint[Random.Range(0, 20)]);
            enabledPlayer = true;
          deleteObj(collision.collider.gameObject);
        }
    }

    public void deleteObj(GameObject obj)
    {
      
   
     obj.GetComponent<Transform>().GetChild(0).transform.GetChild(0).gameObject.SetActive(true);
        obj.GetComponent<Transform>().GetChild(0).gameObject.transform.parent = null;

       Destroy(obj);

        transform.GetComponent<PlayerMovement>().enabled = false;
    }
   
}
