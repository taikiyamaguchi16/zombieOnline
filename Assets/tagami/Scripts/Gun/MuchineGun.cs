using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuchineGun : MonoBehaviour, IGun
{
    [SerializeField] Transform muzzleTransform;

    [SerializeField] GameObject bulletPrefab;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Fire()
    {
        Instantiate(bulletPrefab, muzzleTransform.position, Quaternion.LookRotation(transform.forward));
    }
}
