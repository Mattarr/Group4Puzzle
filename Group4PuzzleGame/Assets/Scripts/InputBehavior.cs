using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Levels
{
    public class InputBehavior : MonoBehaviour
    {
        public UnityEvent<Vector2> onMoveInput;

        private void Update()
        {
            Vector2 moveDirection = GetDirection();

            if (moveDirection != Vector2.zero)
                onMoveInput.Invoke(moveDirection);
        }

        private static Vector2 GetDirection()
        {
            Vector2 result = Vector2.zero;

            if (Input.GetKeyDown(KeyCode.W))
                result.y++;

            if (Input.GetKeyDown(KeyCode.A))
                result.x--;

            if (Input.GetKeyDown(KeyCode.S))
                result.y--;

            if (Input.GetKeyDown(KeyCode.D))
                result.x++;

            return result.normalized;
        }
    }
}
