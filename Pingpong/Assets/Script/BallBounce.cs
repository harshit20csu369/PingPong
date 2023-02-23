using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBounce : MonoBehaviour
{
    public BallMovement ballMovement;


    public ScoreManager scoreManager;

    private void Bounce(Collider2D collision)
    {
        Vector3 ballposition = transform.position;
        Vector3 racketPosition = collision.transform.position;
        float racketHeight = collision.GetComponent<Collider>().bounds.size.y;     //which part of the racket when ball is hit

        float positionX;
        if (collision.gameObject.name=="Player 1")
        {
            positionX = 1;

        }

        else
        {
            positionX = -1;
        }

    float positionY = (ballposition.y - racketPosition.y) / racketHeight;

        ballMovement.IncreaseHitCounter();
        ballMovement.MoveBall(new Vector2(positionX,positionY));
    }

    private void OnCollisionEnter2D(Collision collision)
    {
        if (collision.gameObject.name == "Player 1" || collision.gameObject.name == "Player 2")
        {
            Bounce(collision);
        }

        else if (collision .gameObject.name=="Right Border")
        {
            scoreManager.playerGoal();
        }

        else if (collision.gameObject.name == "Left Border")
        {
            scoreManager.playerGoal();
        }
    }
  
}




