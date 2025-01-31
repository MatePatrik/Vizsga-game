using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class EnemyDeath3 : MonoBehaviour
{
    public EnemyHealth3 enemyHealth;
    public Animator anim;
    public SpriteRenderer spriteRenderer;
    public BoxCollider2D boxCollider;
    public SpriteRenderer expSprite;
    public GameObject canvas;
    public float timer;
    private void Start()
    {
        expSprite = GetComponentInChildren<SpriteRenderer>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        boxCollider = GetComponent<BoxCollider2D>();
        enemyHealth = GetComponent<EnemyHealth3>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        if (!enemyHealth.alive)
        {
            Destroy(boxCollider);
            timer += Time.deltaTime;
            Destroy(canvas);
            anim.SetBool("Death", true);
            if (timer > 1)
            {
                Destroy(spriteRenderer);
                expSprite.sortingOrder = 2;
            }
        }
    }
}
