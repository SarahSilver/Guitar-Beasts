using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawbarras : MonoBehaviour
{

    public GameObject barras;
    public float height;
    public float maxTime = 1f;
    private float timer = 0f;

    void Start()
    {
        GameObject newCano=Instantiate(barras);
        newCano.transform.position=transform.position+new Vector3(0, Random.Range(-height,height),0);
        Destroy(newCano, 10f);
    }

    void Update()
    {
        if(timer>maxTime){
            GameObject newCano=Instantiate(barras);
            newCano.transform.position=transform.position+new Vector3(0, Random.Range(-height,height),0);
            Destroy(newCano, 10f);
            timer=0;
        }
        timer += Time.deltaTime;
    }
}
