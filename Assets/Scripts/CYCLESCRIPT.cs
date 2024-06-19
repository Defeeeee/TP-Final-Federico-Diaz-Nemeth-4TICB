using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEngine;

public class CYCLESCRIPT : MonoBehaviour
{
    public GameObject[] arrayObjetos;
    private int idx = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {

            DeactivateAll();
            arrayObjetos[idx].SetActive(true);
            if (idx != arrayObjetos.Length - 1)
            {
                idx++;
            }
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {

            DeactivateAll();
            arrayObjetos[idx].SetActive(true);
            if (idx != 0)
            {
                idx--;
            }
        }
    }

    void DeactivateAll()
    {
        foreach (var objeto in arrayObjetos)
        {
            objeto.SetActive(false);
        }
    }
}
