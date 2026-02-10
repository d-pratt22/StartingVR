using UnityEngine;
using TMPro;
public class WolfGun : MonoBehaviour
{
    public GameObject wolfPrefab;
    public float wolfVelocity = 20f;
    private GameObject wolf;
    private Rigidbody rb;
    public TMP_Text wolfAmountText;
    public int wolfAmount;


    public void ShootWolf(GameObject parentHand)
    {
        wolf = Instantiate(wolfPrefab, parentHand.transform);
        rb = wolf.GetComponent<Rigidbody>();
        rb.isKinematic = false;
        wolf.transform.parent = null;
        rb.AddForce(parentHand.transform.forward * wolfVelocity, ForceMode.Impulse);
        wolfAmount++;
        wolfAmountText.text = "Wolf Count: " + wolfAmount;

    }

}