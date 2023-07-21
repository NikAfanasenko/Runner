using UnityEngine;

public class PlayerSpawn : MonoBehaviour
{
    [SerializeField] private GameObject _playerPrefab;
    [SerializeField] private Transform _spawnPoint;
    private Vector3 _position;

    private Character _currentPlayer;

    private void Awake()
    {
        Load();
    }

    private void Load()
    {
        _position = _spawnPoint.position;
        Spawn(_playerPrefab);
        PlayerSetting();
    }
    private void Spawn(GameObject prefab)
    {
        _currentPlayer = Instantiate(prefab,new Vector3(_position.x, _position.y),Quaternion.identity).GetComponent<Character>();        
    }

    private void PlayerSetting()
    {        
        _currentPlayer.Init(_position);
    }

}
