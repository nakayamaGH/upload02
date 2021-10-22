using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Bridge;

public class ScoreSceneChangeDirectr : MonoBehaviour
{
    // �X�R�A�V�[������

    // Text�ϐ�
    [SerializeField] private Text score;
    [SerializeField] private Text enemyBreak;

    // ���p�ϐ�
    [SerializeField] private AudioClip buttonSE;
    private AudioSource audioSource;

    private IAddExp iAddExp;


    // Start is called before the first frame update
    void Start()
    {
        // �R���|�[�l���g�擾
        audioSource = GetComponent<AudioSource>();

        iAddExp = new StatusChanger();
        iAddExp.AddExp(ScoreDirector.scorePoint);
    }

    // Update is called once per frame
    void Update()
    {
        // ���\�b�h�Ăяo��
        SceneChage();
        DisplayText();
    }



    /// <summary>
    ///  �V�[���J�ڏ���
    /// </summary>
    private void SceneChage()
    {
        // Z�L�[�Ń��g���C
        if (Input.GetKeyDown(KeyCode.Z))
        {
            // �V�[���J��
            FadeManager.Instance.LoadScene("GameScene", 0.5f);

            // �{�^����SE
            audioSource.PlayOneShot(buttonSE);

        }

        // C�L�[�Ń^�C�g��
        if (Input.GetKeyDown(KeyCode.C))
        {
            // �V�[���J��
            FadeManager.Instance.LoadScene("StartMenuScene", 0.5f);

            // �{�^����SE
            audioSource.PlayOneShot(buttonSE);

        }
    }


   �@/// <summary>
    /// Text�\������
    /// </summary>
    private void DisplayText()
    {
        // text�\��
        score.text = ScoreDirector.scorePoint.ToString("D4");
        enemyBreak.text = ScoreDirector.enemyBreak.ToString("D3");
    }

}