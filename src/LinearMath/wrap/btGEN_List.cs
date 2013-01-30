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

public class btGEN_List : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal btGEN_List(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(btGEN_List obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~btGEN_List() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          LinearMathPINVOKE.delete_btGEN_List(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public btGEN_List() : this(LinearMathPINVOKE.new_btGEN_List(), true) {
  }

  public btGEN_Link getHead() {
    IntPtr cPtr = LinearMathPINVOKE.btGEN_List_getHead(swigCPtr);
    btGEN_Link ret = (cPtr == IntPtr.Zero) ? null : new btGEN_Link(cPtr, false);
    return ret;
  }

  public btGEN_Link getTail() {
    IntPtr cPtr = LinearMathPINVOKE.btGEN_List_getTail(swigCPtr);
    btGEN_Link ret = (cPtr == IntPtr.Zero) ? null : new btGEN_Link(cPtr, false);
    return ret;
  }

  public void addHead(btGEN_Link link) {
    LinearMathPINVOKE.btGEN_List_addHead(swigCPtr, btGEN_Link.getCPtr(link));
  }

  public void addTail(btGEN_Link link) {
    LinearMathPINVOKE.btGEN_List_addTail(swigCPtr, btGEN_Link.getCPtr(link));
  }

}

}
