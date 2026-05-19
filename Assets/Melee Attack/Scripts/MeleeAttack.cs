using UnityEngine;

public class MeleeAttack : MonoBehaviour
{
    private Animator anim;

    void Start() 
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            anim.SetTrigger("Attack Input");
            // anim.Play("Melee Swing"); // can use this instead to switch instantly to a specific animation clip
        }
    }
}
