using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkingEnemy : MonoBehaviour
{
    public GameObject leftPoint;
    public GameObject rightPoint;
    public Rigidbody2D rigidBody;
    private Transform currentPoint;
    public float speed = 5;
    //private Animator animator;

    // Use this for initialization
    void Start()
    {
        speed = 5;
        rigidBody = GetComponent<Rigidbody2D>();
        //rigidBody.freezeRotation = true;
        // animator = GetComponent<Animator>();
        currentPoint = rightPoint.transform;
        // animator.SetBBool("isRunning", true);
    }

    // Update is called once per frame
    /*void Update()
    {
        Vector2 point = currentPoint.position - transform.position;

        if (currentPoint == rightPoint.transform)
        {

            rigidBody.velocity = new Vector2(speed, 0);
            
        }
        else
        {

            rigidBody.velocity = new Vector2(-speed, 0);
        }

        if (Vector2.Distance(transform.position, currentPoint.position) < 5f && currentPoint == rightPoint.transform)
        {
            currentPoint = leftPoint.transform;
        }

        if (Vector2.Distance(transform.position, currentPoint.position) < 5f && currentPoint == leftPoint.transform)
        {
            currentPoint = rightPoint.transform;
        }
    */

    private void FixedUpdate()
    {
        //Vector2 point = currentPoint.position - transform.position;

        if (currentPoint == rightPoint.transform)
        {
            rigidBody.velocity = new Vector2(speed, 0);

        }
        else
        {
            rigidBody.velocity = new Vector2(-speed, 0);
        }

        if (Vector2.Distance(transform.position, currentPoint.position) < 1f && currentPoint == rightPoint.transform)
        {
            currentPoint = leftPoint.transform;
        }

        if (Vector2.Distance(transform.position, currentPoint.position) < 1f && currentPoint == leftPoint.transform)
        {
            currentPoint = rightPoint.transform;
        }
    }

    /*
    private void Flip()
    {
        Vector3 localScale = transform.localScale;
        localScale.x *= 1;
        transform.localScale = localScale;
    }
    */
}
