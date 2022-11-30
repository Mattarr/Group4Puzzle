 using System.Collections;
 using System.Collections.Generic;
 using UnityEngine;

public class EnemyLogic : MonoBehaviour
 {
    
//     Transform target;
//     Vector2 moveDirection;
//     Vector2 Pmove;

//     public float moveSpeed = 5f;
//     public bool isMoving;
//     public Vector3 origPos, targetPos;
//     public float timeToMove = 0.1f;
//     Vector3 lastPos;
//     public int counting;

//     private void Start()
//     {
//         target = GameObject.Find("PlayerCharacter").transform;
//     }
//     private void Update()
//     {
//         if(target)
//         {
//             Vector3 direction = transform.position;
//             Vector3 Pdirection = target.transform.position;
            
//             moveDirection = direction;
//             Pmove = Pdirection;
//             while(transform.position != target.position)
//             {
//                 ++counting;
                
//                 if(target.transform.position != lastPos)
//                 {
                    
                    
//                  if(target.transform.position.x != lastPos);
//                      moveDirection = (moveDirection.position.x + 1.0f);
//                  if(target.transform.position.y != lastPos);
//                     moveDirection = (moveDirection.position.y + 1.0f);
                        
                    
//                 }
//                 else
//                 Debug.Log("hi");

//                  lastPos = target.transform.position;
//             }
            
//         }
//     }
//     public IEnumerator MovePlayer(Vector3 direction)
//    {
//         if(target)
//         {
//             float elapsedTime = 0;

//             origPos = transform.position;
//             targetPos = target.position;

//             while(elapsedTime < timeToMove)
//             {
//                 transform.position = Vector3.Lerp(origPos, targetPos, (elapsedTime / timeToMove));
//                 elapsedTime += Time.deltaTime;
//                 yield return null;
//             }

//             transform.position = origPos;
//         }
//    }

}
