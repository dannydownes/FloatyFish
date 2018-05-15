using UnityEngine;

// Handle hitpoints and damages
public class HealthScript : MonoBehaviour
{
  // Total hitpoints
  public int hp = 10;

  // Enemy or player?
  public bool isEnemy = true;


  // Inflicts damage and check if the object should be destroyed
  // <param name="damageCount"></param>
  public void Damage(int damageCount)
  {
    hp -= damageCount;

    if (hp <= 0)
    {		
		// Dead!
		Destroy(gameObject);
    }
  }
  
  void OnTriggerEnter2D(Collider2D otherCollider)
  {
    // Is this a shot?
    ShotScript shot = otherCollider.gameObject.GetComponent<ShotScript>();
    if (shot != null)
    {
      // Avoid friendly fire
      if (shot.isEnemyShot != isEnemy)
      {
        Damage(shot.damage);

        // Destroy the shot
        Destroy(shot.gameObject); 
      }
    }
	
	DamageScript damage1 = otherCollider.gameObject.GetComponent<DamageScript>();
	if (damage1 != null)
	{
		if (damage1.isEnemyShot != isEnemy)
		{
			Damage(damage1.damage);
		}
	}
  }

}