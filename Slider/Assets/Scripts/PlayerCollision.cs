using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

    public PlayerMovement movement;

    void OnCollisionEnter(Collision collisionInfo)
    {

        if (collisionInfo.collider.tag.Equals("Obstacle"))
        {
            Debug.Log("We hot an obstacle!!!");
            movement.enabled = false;
        }
        
    }
}
