using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCombat : MonoBehaviour
{
    public Animator animator;

    public Transform attackPoint;
    public LayerMask enemyLayers;

    public float attackRange = 0.5f;
    public int attackDamage = 20;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Attack();
        }
    }

    void Attack()
    {
        // Play an attack animation,
        animator.SetTrigger("Attack");
       
        // Detect enemies in range of attack,
        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, enemyLayers);


        // Victor code stuff:
        
        foreach (Collider2D enemy in hitEnemies)
        { 
            Enemy EnemyScript;
             enemy.TryGetComponent<Enemy>(out EnemyScript);

            if (EnemyScript != null)
            {
                EnemyScript.TakeDamage(attackDamage);
                print("Hit something");
            }

        }
        // Damage them
       // foreach (Collider2D enemy in hitEnemies)
        {
            // enemy.GetComponent<Enemy>().TakeDamage(attackDamage);
            
           // Debug.Log("We hit" + enemy.name);
        }
    }
    private void OnDrawGizmos()
    {
        if (attackPoint == null)
            return;

        Gizmos.DrawWireSphere(attackPoint.position, attackRange);
    }

}
