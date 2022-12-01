using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyREDUX : MonoBehaviour

{
    public GameObject player;
    public float moveSpeed = 5f;
    public Transform movePoint;
    public LayerMask whatStopsMovement;
    private bool isTurn = false;
    public float distance = 0f;
    Vector3 lastPos;
    private Vector2 movement;

    // Start is called before the first frame update
    void Start()
    {
        movePoint.parent = null;
    }

    // Update is called once per frame
    void Update()
    {
        distance = Vector2.Distance(transform.position, player.transform.position);
        Vector2 direction = player.transform.position - transform.position;
        direction.Normalize();
        movement = direction;
        if (player.transform.position != lastPos &&
            !Physics2D.OverlapCircle(movePoint.position + new Vector3(direction.x, 0f, 0f), .2f, whatStopsMovement))
        {
            transform.position += movePoint.position + new Vector3(direction.x, 0f, 0f);
                //MoveTowards(this.transform.position, player.transform.position, moveSpeed * Time.deltaTime);
        }

        lastPos = player.transform.position;
    }

    /*private void FixedUpdate()
    {
        moveEnemy(movement);
    }

    void moveEnemy(Vector2 direction)
    {
        
    }*/
}
