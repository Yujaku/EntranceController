using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Linq;
using System.Text;
using UnityEngine.UI;

namespace Slack
{
    public class ActionTeamCallBack : MonoBehaviour
    {
        public ToggleGroup toggleGroup;
        /*
        /// <summary>
        /// 3D班
        /// </summary>
        [SerializeField]
        Toggle Toggle3D = null;

        /// <summary>
        /// Java
        /// </summary>
        [SerializeField]
        Toggle ToggleJava = null;

        /// <summary>
        /// Unity
        /// </summary>
        [SerializeField]
        Toggle ToggleUnity = null;

        /// <summary>
        /// iOS
        /// </summary>
        [SerializeField]
        Toggle ToggleiOS = null;

        /// <summary>
        /// Web
        /// </summary>
        [SerializeField]
        Toggle ToggleWeb = null;
*/
/*

        /// <summary>
        /// 3D:SwitchState
        /// </summary>
        /// <returns>3DToggleStatu</returns>
        public bool IsGetToggle3D()
        {
            return Toggle3D.isOn;
        }

        /// <summary>
        /// Java:SwitchState
        /// </summary>
        /// <returns>JavaToggleStatu</returns>
        public bool IsGetToggleJava()
        {
            return ToggleJava.isOn;
        }

        /// <summary>
        /// Unity:SwitchStatu
        /// </summary>
        /// <returns>UnityToggleStatu</returns>
        public bool IsGetToggleUnity()
        {
            return ToggleUnity.isOn;
        }

        /// <summary>
        /// iOS:SwitchStatu
        /// </summary>
        /// <returns>iOSToggleStatu</returns>
        public bool IsGetToggleiOS()
        {
            return ToggleiOS.isOn;
        }

        /// <summary>
        /// Web;SwitchStatu
        /// </summary>
        /// <returns>WebToggleStatu</returns>
        public bool IsGetToggleWeb()
        {
            return ToggleWeb.isOn;
        }*/

        public string OnClickAction()
        {
            string selectLabel;
            string nullLabel= "未入力";

            if (toggleGroup.AnyTogglesOn())
            {
                selectLabel = toggleGroup.ActiveToggles().First().name;


                Debug.Log(selectLabel);
                return selectLabel;
            }

            return nullLabel;
        }
    }
}