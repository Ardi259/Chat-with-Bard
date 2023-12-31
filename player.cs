using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    [SerializeField] private float moveSpeed = 20f;
    [SerializeField] private GameInput gameInput;
    private bool isWalking;

    private void Update() {

        Vector2 inputVector = gameInput.GameInputNormalized();

        Vector3 moveDir = new Vector3(inputVector.x,0f, inputVector.y);
        transform.position += moveDir * Time.deltaTime * moveSpeed;

        isWalking = moveDir != Vector3.zero;

        float rotationSpeed = 10f;
        transform.forward = Vector3.Slerp(transform.forward, moveDir, Time.deltaTime * rotationSpeed);
        Debug.Log(Time.deltaTime);
        
    }

    public bool IsWalking() {
        return isWalking;
    }
}