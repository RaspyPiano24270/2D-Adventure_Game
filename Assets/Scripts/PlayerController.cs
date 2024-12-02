using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine;

public class PlayerController : MonoBehaviour{
    //variables related to character movement
    public InputAction MoveAction;
    Rigidbody2D rigidbody2d;
    Vector2 move;
    public float speed = 3.0f;
    //variables related to character health
    public int maxHealth = 5;
    int currentHealth;
    // Start is called before the first frame update
    void Start(){
        MoveAction.Enable();
        rigidbody2d = GetComponent<Rigidbody2D>();
        currentHealth = maxHealth;
    }
    // Update is called once per frame
    void Update(){
        move = MoveAction.ReadValue<Vector2>();
        Debug.Log(move);
        
    }
    void FixedUpdate(){
        Vector2 position = (Vector2)rigidbody2d.position + move * speed * Time.deltaTime;
        rigidbody2d.MovePosition(position);
    }
    void ChangeHealth(int amount){
        currentHealth = Mathf.Clamp(currentHealth + amount, 0, maxHealth);
        Debug.Log(currentHealth + "/" + maxHealth);
    }
}
