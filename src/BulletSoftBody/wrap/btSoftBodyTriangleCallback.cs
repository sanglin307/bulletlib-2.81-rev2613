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

public class btSoftBodyTriangleCallback : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal btSoftBodyTriangleCallback(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(btSoftBodyTriangleCallback obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~btSoftBodyTriangleCallback() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          BulletSoftBodyPINVOKE.delete_btSoftBodyTriangleCallback(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public int m_triangleCount {
    set {
      BulletSoftBodyPINVOKE.btSoftBodyTriangleCallback_m_triangleCount_set(swigCPtr, value);
    } 
    get {
      int ret = BulletSoftBodyPINVOKE.btSoftBodyTriangleCallback_m_triangleCount_get(swigCPtr);
      return ret;
    } 
  }

  public btSoftBodyTriangleCallback(SWIGTYPE_p_btDispatcher dispatcher, SWIGTYPE_p_btCollisionObjectWrapper body0Wrap, SWIGTYPE_p_btCollisionObjectWrapper body1Wrap, bool isSwapped) : this(BulletSoftBodyPINVOKE.new_btSoftBodyTriangleCallback(SWIGTYPE_p_btDispatcher.getCPtr(dispatcher), SWIGTYPE_p_btCollisionObjectWrapper.getCPtr(body0Wrap), SWIGTYPE_p_btCollisionObjectWrapper.getCPtr(body1Wrap), isSwapped), true) {
  }

  public void setTimeStepAndCounters(float collisionMarginTriangle, SWIGTYPE_p_btCollisionObjectWrapper triObjWrap, SWIGTYPE_p_btDispatcherInfo dispatchInfo, SWIGTYPE_p_btManifoldResult resultOut) {
    BulletSoftBodyPINVOKE.btSoftBodyTriangleCallback_setTimeStepAndCounters(swigCPtr, collisionMarginTriangle, SWIGTYPE_p_btCollisionObjectWrapper.getCPtr(triObjWrap), SWIGTYPE_p_btDispatcherInfo.getCPtr(dispatchInfo), SWIGTYPE_p_btManifoldResult.getCPtr(resultOut));
    if (BulletSoftBodyPINVOKE.SWIGPendingException.Pending) throw BulletSoftBodyPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void processTriangle(SWIGTYPE_p_btVector3 triangle, int partId, int triangleIndex) {
    BulletSoftBodyPINVOKE.btSoftBodyTriangleCallback_processTriangle(swigCPtr, SWIGTYPE_p_btVector3.getCPtr(triangle), partId, triangleIndex);
  }

  public void clearCache() {
    BulletSoftBodyPINVOKE.btSoftBodyTriangleCallback_clearCache(swigCPtr);
  }

  public SWIGTYPE_p_btVector3 getAabbMin() {
    SWIGTYPE_p_btVector3 ret = new SWIGTYPE_p_btVector3(BulletSoftBodyPINVOKE.btSoftBodyTriangleCallback_getAabbMin(swigCPtr), false);
    return ret;
  }

  public SWIGTYPE_p_btVector3 getAabbMax() {
    SWIGTYPE_p_btVector3 ret = new SWIGTYPE_p_btVector3(BulletSoftBodyPINVOKE.btSoftBodyTriangleCallback_getAabbMax(swigCPtr), false);
    return ret;
  }

}

}
