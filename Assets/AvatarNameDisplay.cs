using Photon.Pun;
using TMPro;

// MonoBehaviourPunCallbacks���p�����āAphotonView�v���p�e�B���g����悤�ɂ���
public class AvatarNameDisplay : MonoBehaviourPunCallbacks
{
    private void Start()
    {
        var nameLabel = GetComponent<TextMeshProUGUI>();
        // �v���C���[���ƃv���C���[ID��\������
        nameLabel.text = $"{photonView.Owner.NickName}({photonView.OwnerActorNr})";
    }
}