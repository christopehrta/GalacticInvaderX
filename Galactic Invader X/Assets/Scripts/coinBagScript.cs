﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinBagScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("Move");
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * 30f * Time.deltaTime);

    }

    IEnumerator Move()
    {
        while (true)
        {
            yield return new WaitForSeconds(1f);
            transform.eulerAngles += new Vector3(0, 180f, 0);
        }
    }
}
