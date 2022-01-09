using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private Text textTime;
    private Text getScore;
    private bool gameOver;
    public float score = 0;
    private Text finalTime;
    private Text finalScore;

    [Header("結束畫面")]
    public GameObject final;

    private void Start()
    {
        textTime = GameObject.Find("時間").GetComponent<Text>();
        getScore = GameObject.Find("分數").GetComponent<Text>();

    }

    private void Update()
    {
        UpdateTime();
        UpdataScore();
    }

    private void UpdataScore()
    {
        if (gameOver) return;
        getScore.text = "分數：" + score;
    }

    /// <summary>
    /// 更新時間
    /// </summary>
    private void UpdateTime()
    {
        if (gameOver) return;
        textTime.text = "時間：" + Time.timeSinceLevelLoad.ToString("F0");
    }

    /// <summary>
    /// 遊戲結束
    /// </summary>
    public void GameOver()
    {
        gameOver = true;
        final.SetActive(true);
        finalTime = GameObject.Find("結束時間").GetComponent<Text>();
        finalScore = GameObject.Find("結束分數").GetComponent<Text>();
        finalTime.text = "時 間：" + Time.timeSinceLevelLoad.ToString("F0");
        finalScore.text = "分 數：" + score;
    }

    /// <summary>
    /// 離開遊戲
    /// </summary>
    public void Quit()
    {
        Application.Quit();
    }

    /// <summary>
    /// 重新遊戲
    /// </summary>
    public void Replay()
    {
        SceneManager.LoadScene("選單");
    }
}
