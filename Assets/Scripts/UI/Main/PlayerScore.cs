using Events;
using TMPro;
using UnityEngine;

namespace UI.Main
{
    public class PlayerScore : MonoBehaviour
    {
        private int _currScore;
        private const string ScoreTxt = "Score: ";
        [SerializeField] private TextMeshProUGUI _scoreTMP;

        private void Awake()
        {
            _scoreTMP.text = ScoreTxt + 0;
        }

        private void OnEnable()
        {
            PlayerEvents.PlayerBaitConsume += OnPlayerBaitConsume;
        }

        private void OnPlayerBaitConsume(int playerScore)
        {
            _currScore++;
            _scoreTMP.text = ScoreTxt + _currScore;
        }

        private void OnDisable()
        {
            PlayerEvents.PlayerBaitConsume -= OnPlayerBaitConsume;
        }
    }
}