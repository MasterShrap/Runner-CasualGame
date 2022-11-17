using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WallCollision : MonoBehaviour
{
    [SerializeField] private PlayerDeformation _playerDeformation;
    [SerializeField] private PlayerBihaviour _playerBihaviour;
    [SerializeField] private CoinManager _coinManager;

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
            break;
            case "PreFinish":
                _coinManager.Save();
                _playerBihaviour.PreFinishRun();
            break;
            case "Finish":
                _coinManager.Save();
                _playerBihaviour.Dance();
                StartCoroutine(NextLevel());
            break;
        }
    }

    private IEnumerator NextLevel()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}