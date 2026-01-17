using UnityEngine;

public class Diddy : BattleEnemy
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        gameObject.name = "Diddy";
        health = 150f;
    }


    public override void TakeDamage(float damage)
    {
        base.TakeDamage(damage * 0.5f); // Diddy neemt de helft van de damage
        //Diddy regenerate ook een klein beetje health bij elke aanval
        health += 3f;

        Debug.Log($"Diddy krijgt {damage * 0.5f} damage! Maar krijgt {health += 3f} HP erbij HP: {health}");
        if (health <= 0)
            Die();

    }

    public override void Attack(GameObject target)
    {
        base.Attack(target);
        Debug.Log($"Diddy slaat {target.name} met zijn trommel!");
    }

  
}
