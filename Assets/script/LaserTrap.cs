using UnityEngine;

public class LaserTrap : MonoBehaviour
{
    public Transform spawnPoint;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Ada yang menyentuh laser");

        if(other.CompareTag("Player"))
        {
            Debug.Log("PLAYER KENA LASER");

            CharacterController cc =
                other.GetComponent<CharacterController>();

            if(cc != null)
            {
                cc.enabled = false;
                other.transform.position = spawnPoint.position;
                cc.enabled = true;
            }
        }
    }
}