using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonEnlargement : MonoBehaviour
{
    // Start is called before the first frame update
    float grower;

    bool check;

    void Start()
    {

        grower = 1f;
        check = false;

        StartCoroutine(Timing());

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Timing()
    {

        if (grower >= 1.5f)
        {
            
            check = true;

        }
        else if (grower <= 1)
        {

            check = false;

        }

        if (check)
        {

            grower -= 0.1f;

        }
        else
        {

            grower += 0.1f;

        }
        //grwoing and shrinking
        yield return new WaitForSeconds(0.1f);

        float sizeChange = Mathf.Sin(grower) + 2;

        transform.localScale = new Vector2(sizeChange, sizeChange * 4.6f);

        StartCoroutine(Timing());

    }

}
