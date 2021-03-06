﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using UnityEngine ;
using System.Collections ;

using CoreFramework ;

namespace CoreFramework.Coroutines
{
  
public enum CoroutineState
{
  Empty = 0 ,
  Ready ,
  Running ,
  ContinueRequested ,
  PauseRequested ,
  Paused ,
  AbortRequested ,
  Aborted ,
  Finished
}
  
public interface ICoroutine : IEnumerator
{

  CoroutineState State { get ; }
  
  void FinishNow ( ) ;
  void RequestPause ( ) ;
  void RequestAbort( ) ;
  void RequestContinue ( ) ;
  
  bool IsPausedOrPauseRquested ( ) ;
  bool IsAbortedOrAbortRequested ( ) ;
  bool IsRunningOrContinueRequested ( ) ;
  bool IsFinishedOrAborted ( ) ;
}


public interface ICoroutine<ReturnValue> : ICoroutine
{
  ReturnValue Value { get ; }
}

}
