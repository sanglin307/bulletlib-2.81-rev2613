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

public class btGEN_Link : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal btGEN_Link(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(btGEN_Link obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~btGEN_Link() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          LinearMathPINVOKE.delete_btGEN_Link(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public btGEN_Link() : this(LinearMathPINVOKE.new_btGEN_Link__SWIG_0(), true) {
  }

  public btGEN_Link(btGEN_Link next, btGEN_Link prev) : this(LinearMathPINVOKE.new_btGEN_Link__SWIG_1(btGEN_Link.getCPtr(next), btGEN_Link.getCPtr(prev)), true) {
  }

  public btGEN_Link getNext() {
    IntPtr cPtr = LinearMathPINVOKE.btGEN_Link_getNext(swigCPtr);
    btGEN_Link ret = (cPtr == IntPtr.Zero) ? null : new btGEN_Link(cPtr, false);
    return ret;
  }

  public btGEN_Link getPrev() {
    IntPtr cPtr = LinearMathPINVOKE.btGEN_Link_getPrev(swigCPtr);
    btGEN_Link ret = (cPtr == IntPtr.Zero) ? null : new btGEN_Link(cPtr, false);
    return ret;
  }

  public bool isHead() {
    bool ret = LinearMathPINVOKE.btGEN_Link_isHead(swigCPtr);
    return ret;
  }

  public bool isTail() {
    bool ret = LinearMathPINVOKE.btGEN_Link_isTail(swigCPtr);
    return ret;
  }

  public void insertBefore(btGEN_Link link) {
    LinearMathPINVOKE.btGEN_Link_insertBefore(swigCPtr, btGEN_Link.getCPtr(link));
  }

  public void insertAfter(btGEN_Link link) {
    LinearMathPINVOKE.btGEN_Link_insertAfter(swigCPtr, btGEN_Link.getCPtr(link));
  }

  public void remove() {
    LinearMathPINVOKE.btGEN_Link_remove(swigCPtr);
  }

}

}
