
using UnityEngine;

public class RandomPositionGenerator : MonoBehaviour
{
    private float _leftBound;
    private float _rightBound;
    private float _groundY;

    private void Awake()
    {
        _leftBound = -10f;
        _rightBound = 10f;
        _groundY = -3.4f;
    }

    public Vector2 Generate()
    {
        float xPosition = Random.Range(_leftBound, _rightBound);
        return new Vector2(xPosition, _groundY);
    }
}
