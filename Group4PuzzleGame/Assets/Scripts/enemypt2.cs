using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemypt2 : MonoBehaviour

{
    public GameObject player;
    public float speed;
    public float distance;
    Vector3 lastPos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        distance = Vector2.Distance(transform.position, player.transform.position);
        Vector2 direciton = player.transform.position - transform.position;
        if(player.transform.position != lastPos)
        transform.position = Vector2.MoveTowards(this.transform.position, player.transform.position, speed * Time.deltaTime);

        lastPos = player.transform.position;
    }
}
