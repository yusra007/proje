using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    float hiz = 5.0f;
    // Update is called once per frame
    void Update()
    {
        float okTuslari = Input.GetAxis("Horizontal");
        float yaOktuslari = Input.GetAxis("Vertical");

        transform.Translate(okTuslari * hiz * Time.deltaTime,
            0, yaOktuslari * hiz * Time.deltaTime);
    }
}
