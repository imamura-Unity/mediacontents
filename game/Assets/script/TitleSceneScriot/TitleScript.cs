using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleScript : MonoBehaviour
{
    private float step = 1f;
    private float variable = 0f;
    private Vector2[] positions = { new Vector2(0, 0), new Vector2(0, 1), new Vector2(0, -1) };



    public Transform[] buttonPositions; // �{�^���̈ʒu�̔z��
    private int currentIndex = 0; // ���݂̈ʒu�C���f�b�N�X

    void Update()
    {
        // ������̃L�[�������ꂽ���Ɉړ�
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            variable += step;
        }

        // �������̃L�[�������ꂽ�牺�Ɉړ�
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            variable -= step;
        }

        variable = Mathf.Clamp(variable, 0, positions.Length - 1);
        transform.position = positions[Mathf.RoundToInt(variable)];


        // �{�^�����I�����ꂽ�ꍇ�̏����i��: Enter�L�[�������ꂽ��Q�[���X�^�[�g�j
        if (Input.GetKeyDown(KeyCode.Return))
        {
            // currentIndex�Ɋ�Â��ď��������s
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

    // �����ړ����郁�\�b�h
    private void MoveArrow(int direction)
    {
        currentIndex = (currentIndex + direction + buttonPositions.Length) % buttonPositions.Length;
        transform.position = buttonPositions[currentIndex].position;
    }

    // �Q�[�����J�n���郁�\�b�h�i��j
    private void StartGame()
    {
        Debug.Log("�Q�[�����J�n���܂��B");
        // �����ɃQ�[���J�n���̏�����ǉ�
    }

    // �I�v�V�������J�����\�b�h�i��j
    private void OpenOptions()
    {
        Debug.Log("�I�v�V�������J���܂��B");
        // �����ɃI�v�V������ʂ�\�����鏈����ǉ�
    }

    // �Q�[�����I�����郁�\�b�h�i��j
    private void QuitGame()
    {
        Debug.Log("�Q�[�����I�����܂��B");
        Application.Quit(); // ����: �G�f�B�^��ł͓��삵�Ȃ��\��������܂�
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