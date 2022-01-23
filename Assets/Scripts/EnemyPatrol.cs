using UnityEngine;
using DG.Tweening;

[RequireComponent(typeof(Rigidbody2D))]
public class EnemyPatrol : MonoBehaviour
{
    [SerializeField] Vector3[] _waypoints;

    private void Start()
    {
        Tween tween = transform.DOPath(_waypoints, 5, PathType.CatmullRom).SetOptions(true);

        tween.SetEase(Ease.Linear).SetLoops(-1);
    }
}
