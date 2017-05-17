using System;
using UnityEngine;

namespace Data
{
    public class ServicesFacade: MonoBehaviour
    {
        public static ServicesFacade Instance
        {
            get; private set;
        }

        private string userId;

        public void Login (string username, Action onSuccess)
        {
            //TODO: Call login service using username, if successful invoke callback and set userId
            userId = "1";
            onSuccess ();
        }
    }
}