using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrystalCollector : MonoBehaviour
{
    public GameObject cristal1, cristal2, cristal3, cristal4;
    public GameObject pressE, pressC, pressF;
    public GameObject craftedObj;
    public Rigidbody capsule;
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Crystal")
        {
            pressE.SetActive(true);
            if (Input.GetKey(KeyCode.E))
            {
                cristal1.SetActive(true);
                Destroy(other.gameObject);
                pressE.SetActive(false);
            }
        }
        if (other.tag == "Crystal2")
        {
            pressE.SetActive(true);
            if (Input.GetKey(KeyCode.E))
            {
                cristal2.SetActive(true);
                Destroy(other.gameObject);
                pressE.SetActive(false);
            }
        }
        if (other.tag == "Crystal3")
        {
            pressE.SetActive(true);
            if (Input.GetKey(KeyCode.E))
            {
                cristal3.SetActive(true);
                Destroy(other.gameObject);
                pressE.SetActive(false);
            }
        }
        if (other.tag == "Crystal4")
        {
            pressE.SetActive(true);
            if (Input.GetKey(KeyCode.E))
            {
                cristal4.SetActive(true);
                Destroy(other.gameObject);
                pressE.SetActive(false);
            }
        }
        if(other.tag == "Craft")
        {
            if (cristal1.active == true && cristal2.active == true && cristal3.active == true && cristal4.active == true)
            {
                pressC.SetActive(true);
                if (Input.GetKey(KeyCode.C))
                {
                    cristal1.SetActive(false);
                    cristal2.SetActive(false);
                    cristal3.SetActive(false);
                    cristal4.SetActive(false);
                    craftedObj.SetActive(true);
                }
            }
        }
        if(other.tag == "Capsule")
        {
            if(craftedObj.active == true)
            {
                pressF.SetActive(true);
                if(Input.GetKey(KeyCode.F))
                {
                    capsule.AddForce(transform.up * 100f);
                    craftedObj.SetActive(false);
                }
            }
        }
    }
    private void FixedUpdate()
    {
        pressC.SetActive(false);
        pressE.SetActive(false);
        pressF.SetActive(false);
    }
}
