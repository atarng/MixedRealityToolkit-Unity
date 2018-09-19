﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public interface INetworkHandler : IEventSystemHandler
{
    void OnDataReceived();

    //Not necissarily possible
    void OnDataSendComplete();	

    //Not necissarily possible
    void OnRecievedCancelled();

    //Not necissarily possible
    void OnSendCancelled();	

}
