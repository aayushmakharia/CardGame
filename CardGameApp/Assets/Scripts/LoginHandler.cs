using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoginHandler : MonoBehaviour
{
    public InputField loginEmail, loginPassword;
    private string email, password;
    
    public void SubmitCredentials()
    {

        email = loginEmail.text.Trim();
        password = loginPassword.text.Trim();

        Debug.Log(email + " : " + password);

    }
}
