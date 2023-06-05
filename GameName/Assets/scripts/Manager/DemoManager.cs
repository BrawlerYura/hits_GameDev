using UnityEngine;
using UnityEngine.Tilemaps;
using TMPro;

public class DemoManager : MonoBehaviour
{
    private Camera _cam;
    [SerializeField] private Tilemap[] level;
    [SerializeField] private Transform spawnPoint;

    private int _currentPlayerTypeIndex;
    private int _currentTilemapIndex;
    private Color _currentForegroundColor;

    public SceneData SceneData;

    private void Awake()
    {
        _cam = FindObjectOfType<Camera>();
    }

    private void Start()
    {

    }

    /*
    public void SwitchLevel(int index)
    {
        //Switch tilemap active and apply color.
        levels[_currentTilemapIndex].gameObject.SetActive(false);
        levels[index].gameObject.SetActive(true);
        levels[index].color = _currentForegroundColor;
        levels[_currentTilemapIndex] = levels[index];

        _player.transform.position = spawnPoint.position;

        _currentTilemapIndex = index;
    }
    */
    

    private void Update()
    {

    }
}
