using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdControler : MonoBehaviour
{
    public float JumpForce;
    public Rigidbody2D rb2D;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello World!");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump")) //sprawdza czy gra� u�y� spacji
        {
            rb2D.AddForce(new Vector2(0, JumpForce), ForceMode2D.Impulse);
        }
        
    }
}