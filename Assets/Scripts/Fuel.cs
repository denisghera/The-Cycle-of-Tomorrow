using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fuel : MonoBehaviour
{
    public float fuelAmount = 150f;
    public float fuelCollected = 50f;
    public Slider slider;

    void Awake()
    {
        StartCoroutine(fuelConsumedCo());
    }
    void Update()
    {
        slider.value = fuelAmount;
        if(fuelAmount>150f)
        {
            fuelAmount = 150f;
        }
    }
    private IEnumerator fuelConsumedCo()
    {
        while (true)
        {
            yield return new WaitForSeconds(0.5f);
            this.fuelAmount -= 1f;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Fuel")
        {
            this.fuelAmount += fuelCollected;
            Destroy(other.gameObject);
        }
    }
}
