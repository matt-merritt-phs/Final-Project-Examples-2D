using UnityEngine;

public class Enemy : MonoBehaviour
{
    public bool hurt;
    public float hurtDuration, currentTimeHurt;
    
    private SpriteRenderer spr;

    void Start()
    {
        spr = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (hurt)
        {
            spr.color = new Color(255, 0, 0);
            currentTimeHurt += Time.deltaTime;

            if (currentTimeHurt >= hurtDuration)
            {
                hurt = false;
            }
        }
        else
        {
            spr.color = new Color(255, 255, 255);
            currentTimeHurt = 0;
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Projectile")
        {
            hurt = true;
        }
    }
}
