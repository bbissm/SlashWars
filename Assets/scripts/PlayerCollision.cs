using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
	// public int health = 1000;
	public PlayerMove movement;

	void OnCollisionEnter (Collision collisionInfo){
			// public PlayerMove movement;

		if(collisionInfo.collider.CompareTag("Enemy")){
			//health = health - 100;
			movement.enabled = false;
			FindObjectOfType<GameManager>().EndGame();
		}
	}
}
