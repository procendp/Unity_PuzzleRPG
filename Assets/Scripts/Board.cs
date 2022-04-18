using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board : MonoBehaviour
{

    public int width;
    public int height;
    public GameObject tilePrefab;
    public GameObject[] dots;
    private BackgroundTile [,] allTiles;
    public GameObject[,] allDots;

    // Start is called before the first frame update
    void Start()
    {
        allTiles = new BackgroundTile[width, height];
        allDots = new GameObject[width, height]; //이중 배열 할당
        setUp();
    }

    private void setUp()    //퍼즐 타일 생성 함수
    {
        for (int i = 0; i < width; i++)
        {
            for (int j = 0; j < height; j++)
            {
                Vector2 tempPosition = new Vector2(i, j);
                GameObject backgroundTile = Instantiate(tilePrefab, tempPosition, Quaternion.identity) as GameObject; //as GameObject를 사용하여 생겨난 복제품 각각에 접근
                backgroundTile.transform.parent = this.transform;   //부모를 설정하여 정보가 변경되어도 기본값으로 설정되게끔
                backgroundTile.name = "( " + i + ", " + j + " )";   //실행 시, 하이어라키 창에 (0,0)처럼 표시해주기 위함

                int dotToUse = Random.Range(0, dots.Length);    //인스펙터 창에서 size 임의로 정해줄 수 있도록 선언
                GameObject dot = Instantiate(dots[dotToUse], tempPosition, Quaternion.identity);
                dot.transform.parent = this.transform;
                dot.name = "( " + i + ", " + j + " )" + " color";    //GameObject의 이름을 그대로 따서 color 표시

                allDots[i, j] = dot;
            }
        }
    }
}



/*

(0,2)(1,2)(2,2) ..
(0,1)(1,1)(2,1)(3,1) ..
(0,0)(1,0)(2,0)(3,0)(4,0) ..

*/