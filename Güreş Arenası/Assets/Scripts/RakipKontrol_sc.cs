using UnityEngine;
using UnityEngine.UIElements;

/* Bu oyunda rakip daha sonra bir yapay zeka ajanýna dönüþtüreleceði için
 bu aþamada sadece gerekli aksiyonlarýn temeli yazýlmýþtýr. */
public class RakipKontrol_sc : MonoBehaviour
{
    Rigidbody rb;

    // Start is called once
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    public void Update()
    {
        // rakip zemin dýþýna çýkýp düþerse de player kazanýr
        if (transform.position.y < -5f && !Object.FindFirstObjectByType<GameManager_sc>().gameEnded)
        {
            Object.FindFirstObjectByType<GameManager_sc>().PlayerWon();
        }
    }

    // playerý iter
    public void CounterPush(Rigidbody playerRb, float guc)
    {
        Vector3 itme = (playerRb.transform.position - transform.position).normalized;
        playerRb.AddForce(itme * guc, ForceMode.Impulse);
    }

    // rakip aðýrlýðýný artýrýr ki player daha zor itsin
    public void HeavyMode(float extraMass)
    {
        rb.mass += extraMass;
    }

    // kaygan zemin oluþturup playerý etkiler
    public void CreateSlipZone()
    {
        // Sonraki aþamada prefab instantiate edilecek (AI ile)
    }

    // hýzlanýp kaçma gibi
    public void Charge(float speed)
    {
        rb.AddForce(transform.forward * speed, ForceMode.Impulse);
    }

    // rakip zemine çarparsa player kazanýr (tag: ground)
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            Object.FindFirstObjectByType<GameManager_sc>().PlayerWon();
            Destroy(gameObject, 0.5f);
        }
    }
}
