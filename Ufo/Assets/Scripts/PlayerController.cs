using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D gracz;

    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        gracz = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        float ruchPoziomy = Input.GetAxis("Horizontal");
        float ruchPionowy = Input.GetAxis("Vertical");
        Vector2 vector = new Vector2(ruchPoziomy, ruchPionowy);

        gracz.AddForce(vector * speed);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
