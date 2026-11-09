using UnityEngine;

public class LimiteMovimiento : MonoBehaviour
{
    public float limiteMax = 4;
    public float limiteMin = -4;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y > limiteMax) 
        {
            Vector3 newpos = transform.position;
            newpos.y = limiteMax;
            transform.position = newpos;



        }

        if (transform.position.y < limiteMin)
        {
            Vector3 newpos = transform.position;
            newpos.y = limiteMin;
            transform.position = newpos;



        }
        






        



    }
}