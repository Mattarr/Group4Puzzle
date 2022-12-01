using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Levels
{
    public class Enemy : MonoBehaviour
    {
        public GameObject player;
        public float speed;
        public float distance;
        Vector3 lastPos;
        public void MoveEnemy(Vector2 direction)
        {
            MoveTowardsPlayer();
            MoveTowardsPlayer();
        }

        private void Update()
        {
            // update sprite position e.g. Vector2.MoveTowards()

        }

        private void MoveTowardsPlayer()
        {
            // calculate direction to player ***TO DO
            distance = Vector2.Distance(transform.position, player.transform.position);
            Vector2 direciton = player.transform.position - transform.position;
            // check collision
            // update "real" position
            print($"Moved enemy ");
        }
    }
}