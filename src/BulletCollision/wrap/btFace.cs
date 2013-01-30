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

public class btFace : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal btFace(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(btFace obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~btFace() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          BulletCollisionPINVOKE.delete_btFace(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public btAlignedObjectArrayInt m_indices {
    set {
      BulletCollisionPINVOKE.btFace_m_indices_set(swigCPtr, btAlignedObjectArrayInt.getCPtr(value));
    } 
    get {
      IntPtr cPtr = BulletCollisionPINVOKE.btFace_m_indices_get(swigCPtr);
      btAlignedObjectArrayInt ret = (cPtr == IntPtr.Zero) ? null : new btAlignedObjectArrayInt(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_float m_plane {
    set {
      BulletCollisionPINVOKE.btFace_m_plane_set(swigCPtr, SWIGTYPE_p_float.getCPtr(value));
    } 
    get {
      IntPtr cPtr = BulletCollisionPINVOKE.btFace_m_plane_get(swigCPtr);
      SWIGTYPE_p_float ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_float(cPtr, false);
      return ret;
    } 
  }

  public btFace() : this(BulletCollisionPINVOKE.new_btFace(), true) {
  }

}

}
