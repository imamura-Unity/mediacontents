using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleScript : MonoBehaviour
{
    private float step = 1f;
    private float variable = 0f;
    private Vector2[] positions = { new Vector2(0, 0), new Vector2(0, 1), new Vector2(0, -1) };



    public Transform[] buttonPositions; // ボタンの位置の配列
    private int currentIndex = 0; // 現在の位置インデックス

    void Update()
    {
        // 上方向のキーが押されたら上に移動
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            variable += step;
        }

        // 下方向のキーが押されたら下に移動
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            variable -= step;
        }

        variable = Mathf.Clamp(variable, 0, positions.Length - 1);
        transform.position = positions[Mathf.RoundToInt(variable)];


        // ボタンが選択された場合の処理（例: Enterキーが押されたらゲームスタート）
        if (Input.GetKeyDown(KeyCode.Return))
        {
            // currentIndexに基づいて処理を実行
            switch (currentIndex)
            {
                case 0:
                    StartGame();
                    break;
                case 1:
                    OpenOptions();
                    break;
                case 2:
                    QuitGame();
                    break;
            }
        }
    }

    // 矢印を移動するメソッド
    private void MoveArrow(int direction)
    {
        currentIndex = (currentIndex + direction + buttonPositions.Length) % buttonPositions.Length;
        transform.position = buttonPositions[currentIndex].position;
    }

    // ゲームを開始するメソッド（例）
    private void StartGame()
    {
        Debug.Log("ゲームを開始します。");
        // ここにゲーム開始時の処理を追加
    }

    // オプションを開くメソッド（例）
    private void OpenOptions()
    {
        Debug.Log("オプションを開きます。");
        // ここにオプション画面を表示する処理を追加
    }

    // ゲームを終了するメソッド（例）
    private void QuitGame()
    {
        Debug.Log("ゲームを終了します。");
        Application.Quit(); // 注意: エディタ上では動作しない可能性があります
    }
}



    /*
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown("up"))
        {
            variable += step;
        }
        else if (Input.GetKeyDown("down"))
        {
            position.y -= 50;
        }









        
        Vector2 position = transform.position;

        if (Input.GetKey("left"))
        {
            position.x -= speed;
        }
        else if (Input.GetKeyDown("right"))
        {
            position.x += speed;
        }
        else if (Input.GetKeyDown("up"))
        {
            position.y += 50;
        }
        else if (Input.GetKeyDown("down"))
        {
            position.y -= 50;
        }

        transform.position = position;








        /*
        Vector2 position = transform.position;

        position.x = -96;

        if (ArrowPosition == 0)
        {
            position.y = -50;
        }
        else if (ArrowPosition == 1)
        {
            position.y = -100;
        }
        else if (ArrowPosition == 2) {
            position.y = -150;
        }

        transform.position = position;
        

    }
}
    */