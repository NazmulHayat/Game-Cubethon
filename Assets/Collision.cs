
using UnityEngine;

public class Collision : MonoBehaviour
{
    public PlayerMovements Movements;
    void OnCollisionEnter(UnityEngine.Collision Collisioninfo)
    {
        if(Collisioninfo.collider.tag == "Obstacale")
        {
            Movements.enabled = false;
            FindObjectOfType<GameManager>().EndGame();

        }
    }
}
