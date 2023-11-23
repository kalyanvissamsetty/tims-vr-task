using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallThrower : MonoBehaviour
{
    public GameObject ballPrefab;
    public Transform throwPosition;
    public float throwForce = 10f;
    public float disableTime = 5f;


    private List<GameObject> ballPool = new List<GameObject>();

    void Update()
    {
        // Check if the instantiation cooldown has passed
        
    }

    public void InstantiateBall()
    {
        // Create a new ball from the object pool or instantiate a new one
        GameObject ball = GetPooledBall();
        if (ball == null)
        {
            ball = Instantiate(ballPrefab, throwPosition.position, Quaternion.identity);
            ballPool.Add(ball);
        }
        else
        {
            ball.transform.position = throwPosition.position;
            ball.SetActive(true);
        }

        // Apply a force to the ball
        Rigidbody ballRigidbody = ball.GetComponent<Rigidbody>();
        if (ballRigidbody != null)
        {
            ballRigidbody.velocity = Vector3.zero; // Reset velocity
            ballRigidbody.AddForce(throwPosition.forward * throwForce, ForceMode.VelocityChange);
        }

        // Disable the ball after a certain time
        DisableBallAfterTime(ball);
    }

    void DisableBallAfterTime(GameObject ball)
    {
        // Invoke the disable method after a specified time
        StartCoroutine(BallDisable(ball));
        //Invoke("DisableBall", disableTime, ball);
    }


    private IEnumerator BallDisable(GameObject ball)
    {
        yield return new WaitForSeconds(5f);
        DisableBall(ball);
    }
    void DisableBall(GameObject ball)
    {
        if (ball != null)
        {
            // Disable the ball and return it to the object pool
            ball.SetActive(false);
        }
    }

    GameObject GetPooledBall()
    {
        // Iterate through the pool to find a deactivated ball
        foreach (var ball in ballPool)
        {
            if (!ball.activeInHierarchy)
            {
                return ball;
            }
        }

        // If no deactivated ball is found, return null
        return null;
    }
}
