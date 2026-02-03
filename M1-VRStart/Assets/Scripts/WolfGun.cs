using UnityEngine;

public class WolfGun : MonoBehaviour
{
    public GameObject wolfPrefab;
    public float wolfVelocity = 20f;
    private GameObject wolf;
    private Rigidbody rb;



    public void ShootWolf(GameObject parentHand)
    {
        wolf = Instantiate(wolfPrefab, parentHand.transform);
        rb = wolf.GetComponent<Rigidbody>();
        rb.isKinematic = false;
        wolf.transform.parent = null;
        rb.AddForce(parentHand.transform.forward * wolfVelocity, ForceMode.Impulse);

    }

}