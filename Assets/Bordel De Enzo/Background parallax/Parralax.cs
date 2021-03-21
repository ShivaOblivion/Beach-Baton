using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parralax : MonoBehaviour
{
    private float lenght, starpos;
    public GameObject cam;
    public float parralaxEffect;

    // Start is called before the first frame update
    void Start()
    {
        starpos = transform.position.x;
        lenght = GetComponent<SpriteRenderer>().bounds.size.x;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float temp = (cam.transform.position.x * (1 - parralaxEffect));
        float dist = (cam.transform.position.x * parralaxEffect);
        
        transform.position = new Vector3(starpos + dist, transform.position.y, transform.position.z);

        if (temp > starpos + lenght) starpos += lenght;
        else if (temp < starpos - lenght) starpos -= lenght;
    
    }
}
