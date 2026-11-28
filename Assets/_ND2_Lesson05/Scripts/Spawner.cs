using UnityEngine;


/// <summary>
/// スポナークラス
/// -----------------------
/// 指定したオブジェクトを、一定間隔でランダムな位置に出現させる
/// </summary>
public class Spawner : MonoBehaviour
{
    //===フィールド===//
    [Header("＊＊＊出現設定＊＊＊")]
    [SerializeField] private GameObject _spawnerPrefab;//出現する場所
    [SerializeField] private float _spawnInterval;//出現間隔
    [SerializeField] private float _min;
    [SerializeField] private float _max;

    private float _spawnIntervalTimer;//

    void Start()
    {
        _spawnIntervalTimer = _spawnInterval;
    }


    void Update()
    {
        _spawnIntervalTimer -= Time.deltaTime;

        if (_spawnIntervalTimer <= 0)
        {
            Spawn();
            _spawnIntervalTimer = _spawnInterval;     //リセット
        }
    }

    //出現メソッド
   public void Spawn()
    {
        //ランダムな出現位置
        Vector3 spawnPoint = new Vector3(Random.Range(_min, _max), 0.5f,Random.Range(_min, _max));
           
       Instantiate(_spawnerPrefab, spawnPoint, Quaternion.identity); //インスタンティエートで増産


    }
}
