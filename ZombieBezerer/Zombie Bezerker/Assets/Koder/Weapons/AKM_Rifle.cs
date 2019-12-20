using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AKM_Rifle : MonoBehaviour
{
    private RaycastHit hit;
    public GameObject fpsCam;
    public int weaponRange;
    public float Firerate;
    public float Lastshot;

    // Start is called before the first frame update
    void Start()
    {
        Lastshot = Firerate;
    }

    // Update is called once per frame
    void Update()
    {
        Lastshot = Lastshot - Time.deltaTime;

        if (Lastshot <= 0)
        {
            Lastshot = 0;
        }
        if (Input.GetMouseButton(0))
        {
            Recoil();
        }
    }
    void Recoil()
    {
        if (Lastshot == 0)
        {
            Fire();
            Lastshot = Firerate;
        }
    }
    void Fire()
    {
        

        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.TransformDirection(Vector3.forward), out RaycastHit hit, weaponRange))
        {
            if (hit.transform.tag == "Enemy")
            {
                hit.transform.GetComponent<Health>().TakeDamage();
                //- Kalder en funktion i scriptet der sidder på "Enemy" der tager skade. selve spilleren giver ikke skade!.
            }
        }
    }
}