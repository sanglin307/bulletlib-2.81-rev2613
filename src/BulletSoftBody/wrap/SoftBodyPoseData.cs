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

public class SoftBodyPoseData : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal SoftBodyPoseData(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(SoftBodyPoseData obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~SoftBodyPoseData() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          BulletSoftBodyPINVOKE.delete_SoftBodyPoseData(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public SWIGTYPE_p_btMatrix3x3FloatData m_rot {
    set {
      BulletSoftBodyPINVOKE.SoftBodyPoseData_m_rot_set(swigCPtr, SWIGTYPE_p_btMatrix3x3FloatData.getCPtr(value));
      if (BulletSoftBodyPINVOKE.SWIGPendingException.Pending) throw BulletSoftBodyPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_btMatrix3x3FloatData ret = new SWIGTYPE_p_btMatrix3x3FloatData(BulletSoftBodyPINVOKE.SoftBodyPoseData_m_rot_get(swigCPtr), true);
      if (BulletSoftBodyPINVOKE.SWIGPendingException.Pending) throw BulletSoftBodyPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public SWIGTYPE_p_btMatrix3x3FloatData m_scale {
    set {
      BulletSoftBodyPINVOKE.SoftBodyPoseData_m_scale_set(swigCPtr, SWIGTYPE_p_btMatrix3x3FloatData.getCPtr(value));
      if (BulletSoftBodyPINVOKE.SWIGPendingException.Pending) throw BulletSoftBodyPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_btMatrix3x3FloatData ret = new SWIGTYPE_p_btMatrix3x3FloatData(BulletSoftBodyPINVOKE.SoftBodyPoseData_m_scale_get(swigCPtr), true);
      if (BulletSoftBodyPINVOKE.SWIGPendingException.Pending) throw BulletSoftBodyPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public SWIGTYPE_p_btMatrix3x3FloatData m_aqq {
    set {
      BulletSoftBodyPINVOKE.SoftBodyPoseData_m_aqq_set(swigCPtr, SWIGTYPE_p_btMatrix3x3FloatData.getCPtr(value));
      if (BulletSoftBodyPINVOKE.SWIGPendingException.Pending) throw BulletSoftBodyPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_btMatrix3x3FloatData ret = new SWIGTYPE_p_btMatrix3x3FloatData(BulletSoftBodyPINVOKE.SoftBodyPoseData_m_aqq_get(swigCPtr), true);
      if (BulletSoftBodyPINVOKE.SWIGPendingException.Pending) throw BulletSoftBodyPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public SWIGTYPE_p_btVector3FloatData m_com {
    set {
      BulletSoftBodyPINVOKE.SoftBodyPoseData_m_com_set(swigCPtr, SWIGTYPE_p_btVector3FloatData.getCPtr(value));
      if (BulletSoftBodyPINVOKE.SWIGPendingException.Pending) throw BulletSoftBodyPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_btVector3FloatData ret = new SWIGTYPE_p_btVector3FloatData(BulletSoftBodyPINVOKE.SoftBodyPoseData_m_com_get(swigCPtr), true);
      if (BulletSoftBodyPINVOKE.SWIGPendingException.Pending) throw BulletSoftBodyPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public SWIGTYPE_p_btVector3FloatData m_positions {
    set {
      BulletSoftBodyPINVOKE.SoftBodyPoseData_m_positions_set(swigCPtr, SWIGTYPE_p_btVector3FloatData.getCPtr(value));
    } 
    get {
      IntPtr cPtr = BulletSoftBodyPINVOKE.SoftBodyPoseData_m_positions_get(swigCPtr);
      SWIGTYPE_p_btVector3FloatData ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_btVector3FloatData(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_float m_weights {
    set {
      BulletSoftBodyPINVOKE.SoftBodyPoseData_m_weights_set(swigCPtr, SWIGTYPE_p_float.getCPtr(value));
    } 
    get {
      IntPtr cPtr = BulletSoftBodyPINVOKE.SoftBodyPoseData_m_weights_get(swigCPtr);
      SWIGTYPE_p_float ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_float(cPtr, false);
      return ret;
    } 
  }

  public int m_numPositions {
    set {
      BulletSoftBodyPINVOKE.SoftBodyPoseData_m_numPositions_set(swigCPtr, value);
    } 
    get {
      int ret = BulletSoftBodyPINVOKE.SoftBodyPoseData_m_numPositions_get(swigCPtr);
      return ret;
    } 
  }

  public int m_numWeigts {
    set {
      BulletSoftBodyPINVOKE.SoftBodyPoseData_m_numWeigts_set(swigCPtr, value);
    } 
    get {
      int ret = BulletSoftBodyPINVOKE.SoftBodyPoseData_m_numWeigts_get(swigCPtr);
      return ret;
    } 
  }

  public int m_bvolume {
    set {
      BulletSoftBodyPINVOKE.SoftBodyPoseData_m_bvolume_set(swigCPtr, value);
    } 
    get {
      int ret = BulletSoftBodyPINVOKE.SoftBodyPoseData_m_bvolume_get(swigCPtr);
      return ret;
    } 
  }

  public int m_bframe {
    set {
      BulletSoftBodyPINVOKE.SoftBodyPoseData_m_bframe_set(swigCPtr, value);
    } 
    get {
      int ret = BulletSoftBodyPINVOKE.SoftBodyPoseData_m_bframe_get(swigCPtr);
      return ret;
    } 
  }

  public float m_restVolume {
    set {
      BulletSoftBodyPINVOKE.SoftBodyPoseData_m_restVolume_set(swigCPtr, value);
    } 
    get {
      float ret = BulletSoftBodyPINVOKE.SoftBodyPoseData_m_restVolume_get(swigCPtr);
      return ret;
    } 
  }

  public int m_pad {
    set {
      BulletSoftBodyPINVOKE.SoftBodyPoseData_m_pad_set(swigCPtr, value);
    } 
    get {
      int ret = BulletSoftBodyPINVOKE.SoftBodyPoseData_m_pad_get(swigCPtr);
      return ret;
    } 
  }

  public SoftBodyPoseData() : this(BulletSoftBodyPINVOKE.new_SoftBodyPoseData(), true) {
  }

}

}
