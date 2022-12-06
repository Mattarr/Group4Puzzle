using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{
    public AudioClip deathSound;
    public GameObject player;
    public float moveSpeed;
    public Transform movePoint;
    Vector3 lastPos;
    public LayerMask whatStopsMovement;

    private void Start()
    {
        movePoint.parent = null;
    }

    public void MoveEnemy(Vector2 direction)
    {
        MoveTowardsPlayer();
        MoveTowardsPlayer();
    }

    private void Update()
    {
        // update sprite position e.g. Vector2.MoveTowards()
        transform.position = Vector3.MoveTowards(transform.position, movePoint.position, moveSpeed * Time.deltaTime);
    }

    private void MoveTowardsPlayer()
    {
        //print($"Moved enemy ");
        Vector2 direction = player.transform.position - movePoint.position;

        if (Math.Abs(direction.x) > 0.01f)
            direction.x = Mathf.Sign(direction.x);

        if (Math.Abs(direction.y) > 0.01f)
            direction.y = Mathf.Sign(direction.y);

        print($"Moved enemy {direction}");
        float newDistance = Vector3.Distance(transform.position, movePoint.position);
        //if (newDistance <= .05f)


        if (Mathf.Abs(direction.x) == 1)
        {
            if (!Physics2D.OverlapCircle(movePoint.position + new Vector3(direction.x, 0f, 0f), .2f, whatStopsMovement))
            {
                movePoint.position += new Vector3(direction.x, 0f, 0f);
            }
        }

        if (Mathf.Abs(direction.y) == 1)
        {
            if (!Physics2D.OverlapCircle(movePoint.position + new Vector3(0f, direction.y, 0f), .2f, whatStopsMovement))
            {
                movePoint.position += new Vector3(0f, direction.y, 0f);
            }
        }

    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            Scene scene = SceneManager.GetActiveScene();
            SceneManager.LoadScene(scene.name);
            AudioSource.PlayClipAtPoint(deathSound, transform.position);
        }
    }

    /*private void OnDrawGizmos()
    {
        Gizmos.DrawCube(center: movePoint.position, size: Vector3.one);
    }*/
}
