using UnityEngine;

public class FireLaser : MonoBehaviour
{
    public GameObject laserPrefab;
    public GameObject marker;

    [Range(0, 30)] public float maxRange;

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

            // STEP 2: DETERMINE ENDPOINT FOR LASER
            RaycastHit2D hit = Physics2D.Raycast(transform.position, projectileDirection, maxRange);

            // STEP 3: FIND MIDPOINT
            Vector3 midpoint = Vector3.zero;
            
            if (hit)
            {
                midpoint = (hit.point - transform.position) / 2;
                distance = (hit.point - transform.position).magnitude;

                GameObject laser = Instantiate(laserPrefab, midpoint, Quaternion.identity);
                // laser.localScale = 
            }
        }   
    }
}
