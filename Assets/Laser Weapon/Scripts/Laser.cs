using UnityEngine;

public class Laser : MonoBehaviour
{
    public float lifetime, currentTimeAlive;

    void Update()
    {
        currentTimeAlive += Time.deltaTime;

        if (currentTimeAlive >= lifetime)
        {
            Destroy(gameObject);
        }        
    }
}
