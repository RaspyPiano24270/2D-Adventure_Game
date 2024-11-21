using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine;

public class PlayerController : MonoBehaviour{
       // Start is called before the first frame update
    void Start(){

    }
       // Update is called once per frame
    void Update(){
        float horizontal = 0.0f;
        if (Keyboard.current.aKey.isPressed){
            horizontal = -1.0f;
        } else if (Keyboard.current.dKey.isPressed){
            horizontal = 1.0f;
        }
        Debug.Log(horizontal);

        float verticle = 0.0f;
        if (Keyboard.current.wKey.isPressed){
            verticle = 1.0f;
        } else if (Keyboard.current.sKey.isPressed){
            verticle = -1.0f;
        }
        Debug.Log(verticle);
        
        Vector2 position = transform.position;
        position.x = position.x + 0.1f * horizontal;
        position.y = position.y + 0.1f * verticle;
        transform.position = position;
    }
}
