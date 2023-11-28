using UnityEngine;

public class Frog : MonoBehaviour
{
    [SerializeField] private AudioPlayer _audioPlayer;
    [SerializeField] private AudioClip _audioClip;

    private void OnMouseDown()
    {
        _audioPlayer.PlayClip(_audioClip);
    }
}
