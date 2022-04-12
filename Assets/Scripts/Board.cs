using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board : MonoBehaviour
{

    public int width;
    public int height;
    public GameObject tilePrefab;
    private BackgroundTile [,] allTiles;

    // Start is called before the first frame update
    void Start()
    {
        allTiles = new BackgroundTile[width, height]; //이중 배열 할당
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
            }
        }
    }
}



/*

(0,2)(1,2)(2,2) ..
(0,1)(1,1)(2,1)(3,1) ..
(0,0)(1,0)(2,0)(3,0)(4,0) ..

*/