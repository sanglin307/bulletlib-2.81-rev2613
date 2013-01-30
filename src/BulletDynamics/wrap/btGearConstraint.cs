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

public class btGearConstraint : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal btGearConstraint(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(btGearConstraint obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~btGearConstraint() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          BulletDynamicsPINVOKE.delete_btGearConstraint(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public btGearConstraint(btRigidBody rbA, btRigidBody rbB, SWIGTYPE_p_btVector3 axisInA, SWIGTYPE_p_btVector3 axisInB, float ratio) : this(BulletDynamicsPINVOKE.new_btGearConstraint__SWIG_0(btRigidBody.getCPtr(rbA), btRigidBody.getCPtr(rbB), SWIGTYPE_p_btVector3.getCPtr(axisInA), SWIGTYPE_p_btVector3.getCPtr(axisInB), ratio), true) {
    if (BulletDynamicsPINVOKE.SWIGPendingException.Pending) throw BulletDynamicsPINVOKE.SWIGPendingException.Retrieve();
  }

  public btGearConstraint(btRigidBody rbA, btRigidBody rbB, SWIGTYPE_p_btVector3 axisInA, SWIGTYPE_p_btVector3 axisInB) : this(BulletDynamicsPINVOKE.new_btGearConstraint__SWIG_1(btRigidBody.getCPtr(rbA), btRigidBody.getCPtr(rbB), SWIGTYPE_p_btVector3.getCPtr(axisInA), SWIGTYPE_p_btVector3.getCPtr(axisInB)), true) {
    if (BulletDynamicsPINVOKE.SWIGPendingException.Pending) throw BulletDynamicsPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void getInfo1(btConstraintInfo1 info) {
    BulletDynamicsPINVOKE.btGearConstraint_getInfo1(swigCPtr, btConstraintInfo1.getCPtr(info));
  }

  public virtual void getInfo2(btConstraintInfo2 info) {
    BulletDynamicsPINVOKE.btGearConstraint_getInfo2(swigCPtr, btConstraintInfo2.getCPtr(info));
  }

  public virtual void setParam(int num, float value, int axis) {
    BulletDynamicsPINVOKE.btGearConstraint_setParam__SWIG_0(swigCPtr, num, value, axis);
  }

  public virtual void setParam(int num, float value) {
    BulletDynamicsPINVOKE.btGearConstraint_setParam__SWIG_1(swigCPtr, num, value);
  }

  public virtual float getParam(int num, int axis) {
    float ret = BulletDynamicsPINVOKE.btGearConstraint_getParam__SWIG_0(swigCPtr, num, axis);
    return ret;
  }

  public virtual float getParam(int num) {
    float ret = BulletDynamicsPINVOKE.btGearConstraint_getParam__SWIG_1(swigCPtr, num);
    return ret;
  }

}

}
