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

public class btAxisSweep3 : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal btAxisSweep3(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(btAxisSweep3 obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~btAxisSweep3() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          BulletCollisionPINVOKE.delete_btAxisSweep3(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public btAxisSweep3(SWIGTYPE_p_btVector3 worldAabbMin, SWIGTYPE_p_btVector3 worldAabbMax, ushort maxHandles, SWIGTYPE_p_btOverlappingPairCache pairCache, bool disableRaycastAccelerator) : this(BulletCollisionPINVOKE.new_btAxisSweep3__SWIG_0(SWIGTYPE_p_btVector3.getCPtr(worldAabbMin), SWIGTYPE_p_btVector3.getCPtr(worldAabbMax), maxHandles, SWIGTYPE_p_btOverlappingPairCache.getCPtr(pairCache), disableRaycastAccelerator), true) {
    if (BulletCollisionPINVOKE.SWIGPendingException.Pending) throw BulletCollisionPINVOKE.SWIGPendingException.Retrieve();
  }

  public btAxisSweep3(SWIGTYPE_p_btVector3 worldAabbMin, SWIGTYPE_p_btVector3 worldAabbMax, ushort maxHandles, SWIGTYPE_p_btOverlappingPairCache pairCache) : this(BulletCollisionPINVOKE.new_btAxisSweep3__SWIG_1(SWIGTYPE_p_btVector3.getCPtr(worldAabbMin), SWIGTYPE_p_btVector3.getCPtr(worldAabbMax), maxHandles, SWIGTYPE_p_btOverlappingPairCache.getCPtr(pairCache)), true) {
    if (BulletCollisionPINVOKE.SWIGPendingException.Pending) throw BulletCollisionPINVOKE.SWIGPendingException.Retrieve();
  }

  public btAxisSweep3(SWIGTYPE_p_btVector3 worldAabbMin, SWIGTYPE_p_btVector3 worldAabbMax, ushort maxHandles) : this(BulletCollisionPINVOKE.new_btAxisSweep3__SWIG_2(SWIGTYPE_p_btVector3.getCPtr(worldAabbMin), SWIGTYPE_p_btVector3.getCPtr(worldAabbMax), maxHandles), true) {
    if (BulletCollisionPINVOKE.SWIGPendingException.Pending) throw BulletCollisionPINVOKE.SWIGPendingException.Retrieve();
  }

  public btAxisSweep3(SWIGTYPE_p_btVector3 worldAabbMin, SWIGTYPE_p_btVector3 worldAabbMax) : this(BulletCollisionPINVOKE.new_btAxisSweep3__SWIG_3(SWIGTYPE_p_btVector3.getCPtr(worldAabbMin), SWIGTYPE_p_btVector3.getCPtr(worldAabbMax)), true) {
    if (BulletCollisionPINVOKE.SWIGPendingException.Pending) throw BulletCollisionPINVOKE.SWIGPendingException.Retrieve();
  }

}

}
