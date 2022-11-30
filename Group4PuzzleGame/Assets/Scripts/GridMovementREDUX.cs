using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridMovementREDUX : MonoBehaviour
{
    public float moveSpeed = 5f;
    public bool isMoving;
    public Vector3 origPos, targetPos;
    public float timeToMove = 0.1f;
    public Rigidbody2D rb;
    public Vector2 movement;

    private void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        movement = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
    }

    private void FixedUpdate()
    {
        MovePlayer(movement);
    }

    /*private void MoveCharacter(Vector2 Direction)
    {
        rb.MovePosition((Vector2)transform.position + (Direction * moveSpeed * Time.deltaTime));

    }*/

    public IEnumerator MovePlayer(Vector2 direction)
    {
        isMoving = true;

        float elapsedTime = 0;

        Vector2 origPos = transform.position;
        targetPos = origPos + direction;

        while (elapsedTime < timeToMove)
        {
            rb.MovePosition(origPos + (direction * moveSpeed));
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        transform.position = targetPos;

        isMoving = false;
    }
}