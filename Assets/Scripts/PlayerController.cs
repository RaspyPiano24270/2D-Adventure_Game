using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine;

public class PlayerController : MonoBehaviour{
    // Start is called before the first frame update
    public InputAction MoveAction;
    void Start(){
        MoveAction.Enable();
    }
    // Update is called once per frame
    void Update(){
        Vector2 move = MoveAction.ReadValue<Vector2>();
        Debug.Log(move);
        Vector2 position = (Vector2)transform.position + move * 0.1f;
        transform.position = position;
    }
}
