using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;//�V�[���}�l�W�����g��L���ɂ���

public class Title : MonoBehaviour
{

	// Use this for initialization
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{
		if (Input.GetMouseButtonDown(0) || Input.GetKeyDown("space") || Input.GetButtonDown("Action1") || Input.GetButtonDown("Jump")) //�}�E�X���N���b�N�A�X�y�[�X�L�[�AA�{�^���A�W�����v�{�^�����������ꍇ
		{
			SceneManager.LoadScene("RPG scene");//some_sensei�V�[�������[�h����
		}

	}
}