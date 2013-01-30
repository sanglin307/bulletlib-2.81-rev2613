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

public class btPoint2PointConstraintDoubleData : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal btPoint2PointConstraintDoubleData(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(btPoint2PointConstraintDoubleData obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~btPoint2PointConstraintDoubleData() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          BulletDynamicsPINVOKE.delete_btPoint2PointConstraintDoubleData(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public SWIGTYPE_p_btTypedConstraintData m_typeConstraintData {
    set {
      BulletDynamicsPINVOKE.btPoint2PointConstraintDoubleData_m_typeConstraintData_set(swigCPtr, SWIGTYPE_p_btTypedConstraintData.getCPtr(value));
      if (BulletDynamicsPINVOKE.SWIGPendingException.Pending) throw BulletDynamicsPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_btTypedConstraintData ret = new SWIGTYPE_p_btTypedConstraintData(BulletDynamicsPINVOKE.btPoint2PointConstraintDoubleData_m_typeConstraintData_get(swigCPtr), true);
      if (BulletDynamicsPINVOKE.SWIGPendingException.Pending) throw BulletDynamicsPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public SWIGTYPE_p_btVector3DoubleData m_pivotInA {
    set {
      BulletDynamicsPINVOKE.btPoint2PointConstraintDoubleData_m_pivotInA_set(swigCPtr, SWIGTYPE_p_btVector3DoubleData.getCPtr(value));
      if (BulletDynamicsPINVOKE.SWIGPendingException.Pending) throw BulletDynamicsPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_btVector3DoubleData ret = new SWIGTYPE_p_btVector3DoubleData(BulletDynamicsPINVOKE.btPoint2PointConstraintDoubleData_m_pivotInA_get(swigCPtr), true);
      if (BulletDynamicsPINVOKE.SWIGPendingException.Pending) throw BulletDynamicsPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public SWIGTYPE_p_btVector3DoubleData m_pivotInB {
    set {
      BulletDynamicsPINVOKE.btPoint2PointConstraintDoubleData_m_pivotInB_set(swigCPtr, SWIGTYPE_p_btVector3DoubleData.getCPtr(value));
      if (BulletDynamicsPINVOKE.SWIGPendingException.Pending) throw BulletDynamicsPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_btVector3DoubleData ret = new SWIGTYPE_p_btVector3DoubleData(BulletDynamicsPINVOKE.btPoint2PointConstraintDoubleData_m_pivotInB_get(swigCPtr), true);
      if (BulletDynamicsPINVOKE.SWIGPendingException.Pending) throw BulletDynamicsPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public btPoint2PointConstraintDoubleData() : this(BulletDynamicsPINVOKE.new_btPoint2PointConstraintDoubleData(), true) {
  }

}

}
