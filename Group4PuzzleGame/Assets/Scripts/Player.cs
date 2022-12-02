using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Levels
{
    public class Player : MonoBehaviour
    {   
        public float moveSpeed = 5f;
        public Transform movePoint;
        public LayerMask whatStopsMovement;
        private void Start()
        {
            movePoint.parent = null;
        }

        private void Update()
        {
            transform.position = Vector3.MoveTowards(transform.position, movePoint.position, moveSpeed * Time.deltaTime);
        }

        public void MovePlayer(Vector2 direction)
        {
            print($"Moved player {direction}");

            if (Vector3.Distance(transform.position, movePoint.position) <= .05f)
            {

                if (Mathf.Abs(direction.x) == 1)
                {
                    if (!Physics2D.OverlapCircle(movePoint.position + new Vector3(direction.x, 0f, 0f), .2f, whatStopsMovement))
                    {
                        movePoint.position += new Vector3(direction.x, 0f, 0f);
                    }
                }
                else if (Mathf.Abs(direction.y) == 1)
                {
                    if (!Physics2D.OverlapCircle(movePoint.position + new Vector3(0f, direction.y, 0f), .2f, whatStopsMovement))
                    {
                        movePoint.position += new Vector3(0f, direction.y, 0f);
                    }
                }
            }
        }

        /*private void OnCollisionEnter2D(Collision2D col)
        {
            if (col.gameObject.tag == "Enemy")
            {
                Scene scene = SceneManager.GetActiveScene();
                SceneManager.LoadScene(scene.name);
            }
        }*/

        /*private void OnDrawGizmos()
        {
            Gizmos.DrawCube(center: (Vector3)movePoint.position, size: Vector3.one);
        }*/
    }
}
