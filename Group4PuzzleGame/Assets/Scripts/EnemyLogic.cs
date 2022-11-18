using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLogic : MonoBehaviour
{

    Transform target;
    Vector2 moveDirection;


    public float moveSpeed = 5f;
    public bool isMoving;
    public Vector3 origPos, targetPos;
    public float timeToMove = 0.1f;
    Vector3 lastPos;

    private void Start()
    {
        target = GameObject.Find("Player").transform;
    }
    private void Update()
    {
        if(target)
        {
            Vector3 direction = (target.position - transform.position).normalized;

            moveDirection = direction;
            if(target.transform.position != lastPos)
            StartCoroutine(MovePlayer(moveDirection));
            else
            Debug.Log("hi");

            lastPos = target.transform.position;
        }
    }
    public IEnumerator MovePlayer(Vector3 direction)
   {
        if(target)
        {
            float elapsedTime = 0;

            origPos = transform.position;
            targetPos = target.position;

            while(elapsedTime < timeToMove)
            {
                transform.position = Vector3.Lerp(origPos, targetPos, (elapsedTime / timeToMove));
                elapsedTime += Time.deltaTime;
                yield return null;
            }

            transform.position = origPos;
        }
   }

}