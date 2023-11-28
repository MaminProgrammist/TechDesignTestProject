using UnityEngine;

public class Frog : MonoBehaviour
{
    [SerializeField] private AudioPlayer _audioPlayer;
    [SerializeField] private AudioClip _audioClip;
    [SerializeField] private Transform _button;

    private void OnMouseDown()
    {
        _audioPlayer.PlayClip(_audioClip);
        _button.gameObject.SetActive(true);
    }
}
