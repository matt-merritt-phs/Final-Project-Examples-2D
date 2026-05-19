using UnityEngine;

public class BlastWeapon : MonoBehaviour
{
    public GameObject projectilePrefab;
    public GameObject marker;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            // mousePosition is the 2D position on the screen that we clicked
            Vector3 mousePosition = Input.mousePosition;
            mousePosition.z = 10f;

            // worldPosition is the 3D coordinates of where we clicked
            Vector3 worldPosition = Camera.main.ScreenToWorldPoint(mousePosition);

            // move the aim marker to the click location
            marker.transform.position = worldPosition;


            // STEP 1: CALCULATE THE DIRECTION OF THE PROJECTILE MOVEMENT
            Vector3 projectileDirection = Vector3.Normalize(worldPosition - transform.position);

            // STEP 2: SPAWN PROJECTILE PREFAB
            GameObject newProjectile = Instantiate(projectilePrefab, transform.position, Quaternion.identity);

            // STEP 3: ADD THE SPEED TO THE PROJECTILE
            Rigidbody2D projectileRB = newProjectile.GetComponent<Rigidbody2D>();
            projectileRB.linearVelocity = projectileDirection * 3;

            // STEP 4: SPAWN ADJACENT PROJECTILE PREFABS
            GameObject newLeftProjectile = Instantiate(projectilePrefab, transform.position, Quaternion.identity);
            GameObject newRightProjectile = Instantiate(projectilePrefab, transform.position, Quaternion.identity);

            // STEP 5: ADD THE SPEED TO THE PROJECTILES WITH ANGLE ADJUSMENT
            Rigidbody2D projectileLeftRB = newLeftProjectile.GetComponent<Rigidbody2D>();
            projectileLeftRB.linearVelocity =  Quaternion.Euler(0, 0, -10) * projectileDirection * 3;

            Rigidbody2D projectileRightRB = newRightProjectile.GetComponent<Rigidbody2D>();
            projectileRightRB.linearVelocity = Quaternion.Euler(0, 0, 10) * projectileDirection * 3;
        }   
    }
}
