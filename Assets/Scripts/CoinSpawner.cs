using UnityEngine;

[RequireComponent(typeof(RandomPositionGenerator))]
public class CoinSpawner : MonoBehaviour
{
    [SerializeField] private Coin _prefab;
    
    private RandomPositionGenerator _randomPositionGenerator;
    private float _delay;
    private float _repeatRate;

    private void Start()
    {
        _randomPositionGenerator = GetComponent<RandomPositionGenerator>();
        _delay = 2.0f;
        _repeatRate = 5.0f;
       
        InvokeRepeating(nameof(Spawn), _delay, _repeatRate);
    }

    private void Spawn()
    {
        Instantiate(_prefab, _randomPositionGenerator.Generate(), Quaternion.identity);
    }
}
