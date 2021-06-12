using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SignUpHandler : MonoBehaviour
{
    public InputField loginEmail, loginPassword;

    public void OpenSignUpPage()
    {
        loginEmail.SetTextWithoutNotify("");
        loginPassword.SetTextWithoutNotify("");
        SceneManager.LoadScene("SignUpPage");
    }

    public InputField signupEmail, signupPassword1, signupUsername, signupPassword2;
    private string email, username, password1, password2;

    public void SignUp()
    {
        email = signupEmail.text.Trim();
        password1 = signupPassword1.text.Trim();
        password2 = signupPassword2.text.Trim();
        username = signupUsername.text.Trim();

        if (!password1.Equals(password2))
        {
            Debug.Log("Passwords Don't Match");
        }
        else
        {
            Debug.Log(username + " : " + email + " : " + password1);
        }
    }

}
