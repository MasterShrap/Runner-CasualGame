using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WallCollision : MonoBehaviour
{
    [SerializeField] private PlayerDeformation _playerDeformation;
    [SerializeField] private PlayerBihaviour _playerBihaviour;
    [SerializeField] private CoinManager _coinManager;
    [SerializeField] private GameObject _briksEffectPrefab;

    private List<string> Tags = new List<string>()
    {
        "Wall",
        "PreFinish",
        "Finish"
    };

    private void OnTriggerEnter(Collider other)
    {
        switch(other.gameObject.tag)
        {
            case "Wall":
                _coinManager.Save();
                _playerDeformation.HitBarrier();
                Instantiate(_briksEffectPrefab, other.transform.position, other.transform.rotation);
                Destroy(other.gameObject);
            break;
            case "PreFinish":
                _coinManager.Save();
                _playerBihaviour.PreFinishRun();
            break;
            case "Finish":
                _coinManager.Save();
                _playerBihaviour.Dance();
                StartCoroutine(NextLevel(SceneManager.GetActiveScene().buildIndex + 1));
            break;
            case "LastFinish":
                _coinManager.Save();
                _playerBihaviour.Dance();
                StartCoroutine(NextLevel(0));   
            break;
        }
    }

    private IEnumerator NextLevel(int level)
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(level);
    }
}