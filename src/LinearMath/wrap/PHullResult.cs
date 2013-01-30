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

public class PHullResult : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal PHullResult(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(PHullResult obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~PHullResult() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          LinearMathPINVOKE.delete_PHullResult(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public PHullResult() : this(LinearMathPINVOKE.new_PHullResult(), true) {
  }

  public uint mVcount {
    set {
      LinearMathPINVOKE.PHullResult_mVcount_set(swigCPtr, value);
    } 
    get {
      uint ret = LinearMathPINVOKE.PHullResult_mVcount_get(swigCPtr);
      return ret;
    } 
  }

  public uint mIndexCount {
    set {
      LinearMathPINVOKE.PHullResult_mIndexCount_set(swigCPtr, value);
    } 
    get {
      uint ret = LinearMathPINVOKE.PHullResult_mIndexCount_get(swigCPtr);
      return ret;
    } 
  }

  public uint mFaceCount {
    set {
      LinearMathPINVOKE.PHullResult_mFaceCount_set(swigCPtr, value);
    } 
    get {
      uint ret = LinearMathPINVOKE.PHullResult_mFaceCount_get(swigCPtr);
      return ret;
    } 
  }

  public btVector3 mVertices {
    set {
      LinearMathPINVOKE.PHullResult_mVertices_set(swigCPtr, btVector3.getCPtr(value));
    } 
    get {
      IntPtr cPtr = LinearMathPINVOKE.PHullResult_mVertices_get(swigCPtr);
      btVector3 ret = (cPtr == IntPtr.Zero) ? null : new btVector3(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_btAlignedObjectArrayT_unsigned_int_t m_Indices {
    set {
      LinearMathPINVOKE.PHullResult_m_Indices_set(swigCPtr, SWIGTYPE_p_btAlignedObjectArrayT_unsigned_int_t.getCPtr(value));
    } 
    get {
      IntPtr cPtr = LinearMathPINVOKE.PHullResult_m_Indices_get(swigCPtr);
      SWIGTYPE_p_btAlignedObjectArrayT_unsigned_int_t ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_btAlignedObjectArrayT_unsigned_int_t(cPtr, false);
      return ret;
    } 
  }

}

}