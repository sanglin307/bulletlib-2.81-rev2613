/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.8
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace BulletCSharp {

using System;
using System.Runtime.InteropServices;

public class CProfileNode : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CProfileNode(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(CProfileNode obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~CProfileNode() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          LinearMathPINVOKE.delete_CProfileNode(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public CProfileNode(string name, CProfileNode parent) : this(LinearMathPINVOKE.new_CProfileNode(name, CProfileNode.getCPtr(parent)), true) {
  }

  public CProfileNode Get_Sub_Node(string name) {
    IntPtr cPtr = LinearMathPINVOKE.CProfileNode_Get_Sub_Node(swigCPtr, name);
    CProfileNode ret = (cPtr == IntPtr.Zero) ? null : new CProfileNode(cPtr, false);
    return ret;
  }

  public CProfileNode Get_Parent() {
    IntPtr cPtr = LinearMathPINVOKE.CProfileNode_Get_Parent(swigCPtr);
    CProfileNode ret = (cPtr == IntPtr.Zero) ? null : new CProfileNode(cPtr, false);
    return ret;
  }

  public CProfileNode Get_Sibling() {
    IntPtr cPtr = LinearMathPINVOKE.CProfileNode_Get_Sibling(swigCPtr);
    CProfileNode ret = (cPtr == IntPtr.Zero) ? null : new CProfileNode(cPtr, false);
    return ret;
  }

  public CProfileNode Get_Child() {
    IntPtr cPtr = LinearMathPINVOKE.CProfileNode_Get_Child(swigCPtr);
    CProfileNode ret = (cPtr == IntPtr.Zero) ? null : new CProfileNode(cPtr, false);
    return ret;
  }

  public void CleanupMemory() {
    LinearMathPINVOKE.CProfileNode_CleanupMemory(swigCPtr);
  }

  public void Reset() {
    LinearMathPINVOKE.CProfileNode_Reset(swigCPtr);
  }

  public void Call() {
    LinearMathPINVOKE.CProfileNode_Call(swigCPtr);
  }

  public bool Return() {
    bool ret = LinearMathPINVOKE.CProfileNode_Return(swigCPtr);
    return ret;
  }

  public string Get_Name() {
    string ret = LinearMathPINVOKE.CProfileNode_Get_Name(swigCPtr);
    return ret;
  }

  public int Get_Total_Calls() {
    int ret = LinearMathPINVOKE.CProfileNode_Get_Total_Calls(swigCPtr);
    return ret;
  }

  public float Get_Total_Time() {
    float ret = LinearMathPINVOKE.CProfileNode_Get_Total_Time(swigCPtr);
    return ret;
  }

  public SWIGTYPE_p_void GetUserPointer() {
    IntPtr cPtr = LinearMathPINVOKE.CProfileNode_GetUserPointer(swigCPtr);
    SWIGTYPE_p_void ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_void(cPtr, false);
    return ret;
  }

  public void SetUserPointer(SWIGTYPE_p_void ptr) {
    LinearMathPINVOKE.CProfileNode_SetUserPointer(swigCPtr, SWIGTYPE_p_void.getCPtr(ptr));
  }

}

}
