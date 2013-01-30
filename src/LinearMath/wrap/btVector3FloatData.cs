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

public class btVector3FloatData : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal btVector3FloatData(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(btVector3FloatData obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~btVector3FloatData() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          LinearMathPINVOKE.delete_btVector3FloatData(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public SWIGTYPE_p_float m_floats {
    set {
      LinearMathPINVOKE.btVector3FloatData_m_floats_set(swigCPtr, SWIGTYPE_p_float.getCPtr(value));
    } 
    get {
      IntPtr cPtr = LinearMathPINVOKE.btVector3FloatData_m_floats_get(swigCPtr);
      SWIGTYPE_p_float ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_float(cPtr, false);
      return ret;
    } 
  }

  public btVector3FloatData() : this(LinearMathPINVOKE.new_btVector3FloatData(), true) {
  }

}

}