using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBase : MonoBehaviour
{

    public virtual void AttackPlayer()
    {
        print("Enemy is attacking player");
    }

    public virtual void OnMouseOver()
    {
        transform.GetComponent<SpriteRenderer>().color = Color.red;
        AttackPlayer();
    }

    void OnMouseExit()
    {
        transform.GetComponent<SpriteRenderer>().color = Color.white;
        print("");
    }

}
