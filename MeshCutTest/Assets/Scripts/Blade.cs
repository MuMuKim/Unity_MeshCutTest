using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blade : MonoBehaviour
{
    public Material mat;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Cutable"))
        {
            GameObject[] obj;

            obj = MeshCut.Cut(other.gameObject, other.gameObject.transform.position, Vector3.down, mat);

            obj[1].AddComponent<Rigidbody>();
        }
    }
    
}
