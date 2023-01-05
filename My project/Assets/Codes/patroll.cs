using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class patroll : MonoBehaviour
{
    public GameObject[] waypoints;
    private int currentWaypointIndex = 0;

    private int speed;
    private bool movingRight = true;
    // Start is called before the first frame update
    void Start()
    {
        speed = Random.Range(3, 6);
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector2.Distance(waypoints[currentWaypointIndex].transform.position, transform.position) < .1f)
        {
            currentWaypointIndex++;
            if (movingRight == true)
            {
                this.gameObject.transform.localScale = new Vector3(-1.3533f, 1.3533f, 1.3533f);
                movingRight = false;
            }
            else
            {
                this.gameObject.transform.localScale = new Vector3(1.3533f, 1.3533f, 1.3533f);
                movingRight = true;
            }

            if (currentWaypointIndex >= waypoints.Length)
            {
                currentWaypointIndex = 0;
            }
        }

        transform.position = Vector2.MoveTowards(transform.position, waypoints[currentWaypointIndex].transform.position, speed * Time.deltaTime);
    }
}
