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

public class btDefaultVehicleRaycaster : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal btDefaultVehicleRaycaster(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(btDefaultVehicleRaycaster obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~btDefaultVehicleRaycaster() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          BulletDynamicsPINVOKE.delete_btDefaultVehicleRaycaster(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public btDefaultVehicleRaycaster(SWIGTYPE_p_btDynamicsWorld world) : this(BulletDynamicsPINVOKE.new_btDefaultVehicleRaycaster(SWIGTYPE_p_btDynamicsWorld.getCPtr(world)), true) {
  }

  public virtual SWIGTYPE_p_void castRay(SWIGTYPE_p_btVector3 from, SWIGTYPE_p_btVector3 to, btVehicleRaycasterResult result) {
    IntPtr cPtr = BulletDynamicsPINVOKE.btDefaultVehicleRaycaster_castRay(swigCPtr, SWIGTYPE_p_btVector3.getCPtr(from), SWIGTYPE_p_btVector3.getCPtr(to), btVehicleRaycasterResult.getCPtr(result));
    SWIGTYPE_p_void ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_void(cPtr, false);
    if (BulletDynamicsPINVOKE.SWIGPendingException.Pending) throw BulletDynamicsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
