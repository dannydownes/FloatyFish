using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour
{
    public Vector2 jumpForce = new Vector2(0, 300);
	public AudioSource sound1;
	
    void Update()
    {
        // Jump
        if (Input.GetKeyUp("up"))
        {
            GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            GetComponent<Rigidbody2D>().AddForce(jumpForce);
			sound1.Play();
        }
		
		// Shooting
		bool shoot = Input.GetKeyDown("space");

		if (shoot)
		{
			WeaponScript weapon = GetComponent<WeaponScript>();
			
			if (weapon != null)
			{
			// false because the player is not an enemy
			weapon.Attack(false);
			}
		}
    }
	
	void OnDestroy()
	{
		Application.LoadLevel("GameOver");
	}
}