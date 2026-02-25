using UnityEngine;

public class BaseProjectileGun : MonoBehaviour
{
    [SerializeField] private GameObject ammo;
    [SerializeField] private Transform gunBarrel;
    [SerializeField] private float shotDelay;
    [SerializeField] private float shotSpeed;
    private bool canShoot = true;
    [SerializeField] private bool fullAuto = true;
    private float timer = 0;

    private AudioSource audioSource;
    [SerializeField] private AudioClip firingSound;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!canShoot)
        {
            timer += Time.deltaTime;
            if (timer > shotDelay)
            {
                canShoot = true;
                timer = 0;
            }
        }
        //actual shot
        if ((canShoot) && (fullAuto ? Input.GetButton("Fire1") : Input.GetButtonDown("Fire1")))
        {
            canShoot = false;
            audioSource.PlayOneShot(firingSound);
            GameObject shot = GameObject.Instantiate(ammo, gunBarrel.position, Quaternion.identity);
            shot.GetComponent<Rigidbody>().AddForce(gunBarrel.forward * shotSpeed, ForceMode.VelocityChange);
        }
    }
}
