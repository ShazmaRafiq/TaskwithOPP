using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mango : Fruit
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public override void AddScore()
    {
        scores += 10;
        Debug.Log("Collide with" + gameObject.name + "with Score" + scores);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            AddScore();
        }
    }
}
