using System.Collections;
//using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Slack
{
    /// <summary>
    /// 送信するメッセージ取得
    /// </summary>
    public class SendingScript : MonoBehaviour
    {
        /// <summary>
        /// メッセージ送信テキストフィールド
        /// </summary>
        [SerializeField]
        InputField inputTextField = null;

        /// <summary>
        /// 送信するテキストのデータ
        /// </summary>
        [SerializeField]
        string textData;

        public string SaveMessage()
        {
            textData = inputTextField.text;
            string textNull="なし";
            if (textData != null)
            {
                inputTextField.text = null;
                Debug.Log(textData);
                return textData;
            }
            return textNull;
        }
    }
}