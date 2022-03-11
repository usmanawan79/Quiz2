using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Rigidbody2D rigidbody;
    public Transform Player;
    public float moveSpeed = 1.5f;
    private Vector2 movement;
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        
    }

    void Update()
    {
        Vector3 direction = Player.position - transform.position;             
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;  
        rigidbody.rotation = angle;
        direction.Normalize();   
        movement = direction;

    }
    private void FixedUpdate()
    {
        moveEnemy(movement);            
    }

    void moveEnemy(Vector2 direction)
    {
        rigidbody.MovePosition((Vector2)transform.position + (direction * moveSpeed * Time.deltaTime));  
    }


    private void OnCollisionEnter2D(Collision2D target)
    {
        if(target.gameObject.tag.Equals("arc") == true)
        
        Destroy(gameObject);
    }
}
