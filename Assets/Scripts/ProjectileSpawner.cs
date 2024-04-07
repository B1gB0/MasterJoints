using UnityEngine;

public class ProjectileSpawner : MonoBehaviour
{
    [SerializeField] private GameObject _prefab;
    [SerializeField] private Transform _newPrefabTransform;

    public void Spawn()
    {
        Instantiate(_prefab, _newPrefabTransform.position, Quaternion.identity);
    }
}
