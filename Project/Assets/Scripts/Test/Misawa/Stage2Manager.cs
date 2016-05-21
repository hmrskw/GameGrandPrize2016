using UnityEngine;
using System.Collections;

public class Stage2Manager : MonoBehaviour {

    [SerializeField]
    private GameObject _bird = null;

    [SerializeField,Tooltip("鳥が飛んでくる頻度")]
    private float _frequency;

    private int _count;

    // Use this for initialization
    void Start () {
        _count = 0;
    }
	
	// Update is called once per frame
	void FixedUpdate() {
        //エリア２内の処理
        if (transform.position.x > 50.0f)
        {
            if (transform.position.x < 60.0f)
            {
                if (_count % (60 / _frequency) == 0)
                {
                    Instantiate(_bird, new Vector3(transform.position.x + 10.0f, Random.Range(-4.0f, 0.0f), 0), Quaternion.identity);
                }
            }
            else if (transform.position.x < 70.0f)
            {
                if (_count % (60 / _frequency) == 0)
                {
                    Instantiate(_bird, new Vector3(transform.position.x + 10.0f, Random.Range(0.0f, 4.0f), 0), Quaternion.identity);
                }
            }
            else if (transform.position.x < 80.0f)
            {
                if (_count % (60 / _frequency) == 0)
                {
                    Instantiate(_bird, new Vector3(transform.position.x + 10.0f, Random.Range(-4.0f, 1.0f), 0), Quaternion.identity);
                }
            }
            else if (transform.position.x < 90.0f)
            {
                if (_count % (60 / _frequency) == 0)
                {
                    Instantiate(_bird, new Vector3(transform.position.x + 10.0f, Random.Range(0.0f, 4.0f), 0), Quaternion.identity);
                }
            }
        }
        _count++;

    }

    //リスポーンしたときにシーン上の鳥を消す
    public void DestoroyBird()
    {
        //TODO:Birdクラスに消去する関数を作る
        //(Birdクラス内で初期位置からxがある程度動いたら、勝手に消えるようにもしたほうがいいかも)
        //鳥を消去する関数を呼び出す
    }
}
