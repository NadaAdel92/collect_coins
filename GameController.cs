using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {
	GameMaster _gm;
	Text _playerscoretext;

	void Start(){
		_gm = GameObject.Find ("GameMaster").GetComponent<GameMaster> ();
		_playerscoretext = GameObject.Find ("PlayerScoreText").GetComponent<Text> ();
	}

	void OnTriggerEnter (Collider _other) {
		if (_other.gameObject.CompareTag("Coin")){
			
			int _coinType = _other.GetComponent<PickupScript>().coinType;
		
		switch (_coinType) {
			case 1:
				Debug.Log ("CoinType = " + _coinType.ToString ());
				AddScore (_other.GetComponent<PickupScript>().itemScore);
			break;
			
			default:
			 break;
		}
		}
		_other.gameObject.SetActive(false);
		}

	void AddScore (int _palyerscore){
		_gm.playerScore += _palyerscore ;
		_playerscoretext.text = _gm.playerScore.ToString ();
	}
	}

