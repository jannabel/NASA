﻿using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NASA_L;
using NASA_L.Models;
using System.Threading.Tasks;
using Firebase.Auth;

namespace NASA_L.Auth
{
    public class FAuth:FirebaseCore
    {
        public async Task<LoginModel> LoginAsync(LoginModel model)
        {
            //model = await GetUserInfo(model);
            model.auth = new FirebaseAuthProvider(new FirebaseConfig(ApiKey));
            model.ab = await model.auth.SignInWithEmailAndPasswordAsync(model.Email, model.Password);
            model.token = model.ab.FirebaseToken;
            model.user = model.ab.User;
            return model;
        }
    }
}