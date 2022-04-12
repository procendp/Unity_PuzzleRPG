using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//인스펙터 창 sprites renderer 껐음

public class BackgroundTile : MonoBehaviour
{
    public GameObject[] dots;

    // Start is called before the first frame update
    void Start()
    {
        Initialize();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Initialize()
    {
        int dotToUse = Random.Range(0, dots.Length);    //인스펙터 창에서 size 임의로 정해줄 수 있도록 선언
        GameObject dot = Instantiate(dots[dotToUse], transform.position, Quaternion.identity);
        dot.transform.parent = this.transform;
        dot.name = this.gameObject.name;    //GameObject의 이름을 그대로 따옴


    }
}
