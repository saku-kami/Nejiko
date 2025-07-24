using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageGenerator : MonoBehaviour
{
    // �^�[�Q�b�g�L�����N�^�[�̕ێ��p�ϐ�
    public Transform character;
    //�X�e�[�W��prefab��z��ŊǗ�����ϐ�
    public GameObject[] stageChip;
    //�V�[���Ɏ��̉��������X�e�[�W��Prefab���Ǘ�����z��
    public List<GameObject> generateStageList = new List<GameObject>();
    //�X�e�[�W�����J�E���g����C���f�b�N�X
    public int preInstance = 5;

    public int currentChipIndex;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //�L�����N�^�[�̌��݈ʒu���猻�݂̃X�e�[�W�`�b�v�̃C���f�b�N�X���v�Z
        int characterPositionIndex = (int)(character.position.z / 30f);

        //���̃X�e�[�W�`�b�v�ɓ�������X�e�[�W�̍ŐV�������s��
        if (characterPositionIndex + preInstance > currentChipIndex)
        {
           //�w��̃X�e�[�W�`�b�v���쐬
           for (int i =currentChipIndex + 1; i < preInstance; i++)
            {
                GameObject stageObject = Instantiate(stageChip[0]);
                stageObject.transform.position = new Vector3(0, 0,i * 30f);
                //���������X�e�[�W�`�b�v���Ǘ����X�g�ɒǉ�
                generateStageList.Add(stageObject);
            
            }
        }
    }
}
