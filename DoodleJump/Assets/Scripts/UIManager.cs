using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Threading;

public class UIManager : MonoBehaviour
{
    public Text ScoreText;
    public Text GameOver;

    public EventSystemCustom eventSystem;
    private DoodlerScript Player;
    //private EnemyGenerator enemyGenerator;

    void Start()
    {
        eventSystem.OnUpdateScore.AddListener(UpdateScore);
        eventSystem.OnEnd.AddListener(End);
        Player = GameObject.Find("Doodler").GetComponent<DoodlerScript>();
        //enemyGenerator = GameObject.Find("EnemyGenerator").GetComponent<EnemyGenerator>();

    }

    public void UpdateScore()
    {
        ScoreText.text = Player.maxH.ToString();
    }
    public void End()
    {
        StartCoroutine(EndGameLost());
    }
    public IEnumerator EndGameLost()
    {
        //todo: show game over
        GameOver.gameObject.SetActive(true);
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene(0);
    }
    //public void UpdateLevel()
    //{
    //    Level.text = enemyGenerator.Level.ToString();
    //}

    //public void UpdateEnergy()
    //{
    //    Energy.text = Player.Energy.ToString();
    //}

    //public void UpdateLife()
    //{
    //    if (Player.Life <= 0)
    //        StartCoroutine(EndGameLost());

    //    Life.text = Player.Life.ToString();
    //}

    //public void EndGameWon()
    //{
    //    if (int.Parse(KeyCounter.text) >= Constants.RequiredKeyCountToWin)
    //    {
    //        //Debug.Log("YOU WON!");
    //        WinLabel.text = "You Won!";
    //    }
    //}

    //public IEnumerator EndGameLost()
    //{
    //    //todo: show game over
    //    GameOver.gameObject.SetActive(true);
    //    yield return new WaitForSeconds(2.5f);
    //    SceneManager.LoadScene(0);
    //}

    //public IEnumerator Wait()
    //{
    //    isRecharging = true;
    //    Debug.Log("isRecharging");
    //    yield return new WaitForSeconds(2.5f);
    //    isRecharging = false;
    //    Debug.Log("isRecharging finished");

    //}

}
