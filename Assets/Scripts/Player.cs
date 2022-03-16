using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Player : MonoBehaviour
{
    private float speed = 10;
    private float horizontalInput;
    private float verticalInput;
    private float xRange = 7.0f;
    public Text scoreText;
    public Text gameOver;

    // Start is called before the first frame update
    void Start()
    {
        gameOver.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);
        transform.Translate(Vector3.right * Time.deltaTime * speed * horizontalInput);

        //keep the player in bounds
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        if(transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        scoreText.text = "Score: " + Fruit.scores;
        if (transform.position.y < -1)
        {
            Destroy(gameObject);
            gameOver.gameObject.SetActive(true);
            Time.timeScale = 0;
        }
        
    }
   
   
}
