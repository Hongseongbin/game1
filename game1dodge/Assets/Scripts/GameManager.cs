using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // UI관련 라이브러리 
using UnityEngine.SceneManagement; // 씬 관련 라이브러리

public class GameManager : MonoBehaviour
{
    /* GameManager의 기능
    1. 게임오버 상태 표현 
    2. 생존시간 갱신
    3. ui를 갱신하고 표시
    4. 게임오버시 게임 재시작
     */

    public GameObject gameoverText;
    public Text timeText;
    public Text recordText;

    private float surviveTime;
    private bool isGameover;


    private void Start()
    {
        surviveTime = 0;
        isGameover = false;
    }

    private void Update()
    {
        if (!isGameover)
        {
            surviveTime += Time.deltaTime;
            timeText.text = "Time : " + (int)surviveTime;
        }
        else
        {

            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene("SampleScene");
            }
        }
    }
    public void EndGame()
    {
        isGameover = true;
        gameoverText.SetActive(true);
        float bestTime = PlayerPrefs.GetFloat("BestTime");

        if (surviveTime > bestTime)
        {
            bestTime = surviveTime;

            PlayerPrefs.SetFloat("BestTime", bestTime);
        }

        recordText.text = "Best Time : " + (int)bestTime;

    }

}
