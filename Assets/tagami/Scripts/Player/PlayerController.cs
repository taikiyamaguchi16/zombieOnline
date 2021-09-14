using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] GameObject shootingGunObj;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //発射
        if(Input.GetKeyDown(KeyCode.Space))
        {
            shootingGunObj.GetComponent<IGun>().Fire();
        }
    }
}
