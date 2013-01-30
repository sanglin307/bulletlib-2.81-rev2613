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

public class btTransform : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal btTransform(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(btTransform obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~btTransform() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          LinearMathPINVOKE.delete_btTransform(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public btTransform() : this(LinearMathPINVOKE.new_btTransform__SWIG_0(), true) {
  }

  public btTransform(btQuaternion q, btVector3 c) : this(LinearMathPINVOKE.new_btTransform__SWIG_1(btQuaternion.getCPtr(q), btVector3.getCPtr(c)), true) {
    if (LinearMathPINVOKE.SWIGPendingException.Pending) throw LinearMathPINVOKE.SWIGPendingException.Retrieve();
  }

  public btTransform(btQuaternion q) : this(LinearMathPINVOKE.new_btTransform__SWIG_2(btQuaternion.getCPtr(q)), true) {
    if (LinearMathPINVOKE.SWIGPendingException.Pending) throw LinearMathPINVOKE.SWIGPendingException.Retrieve();
  }

  public btTransform(btMatrix3x3 b, btVector3 c) : this(LinearMathPINVOKE.new_btTransform__SWIG_3(btMatrix3x3.getCPtr(b), btVector3.getCPtr(c)), true) {
    if (LinearMathPINVOKE.SWIGPendingException.Pending) throw LinearMathPINVOKE.SWIGPendingException.Retrieve();
  }

  public btTransform(btMatrix3x3 b) : this(LinearMathPINVOKE.new_btTransform__SWIG_4(btMatrix3x3.getCPtr(b)), true) {
    if (LinearMathPINVOKE.SWIGPendingException.Pending) throw LinearMathPINVOKE.SWIGPendingException.Retrieve();
  }

  public btTransform(btTransform other) : this(LinearMathPINVOKE.new_btTransform__SWIG_5(btTransform.getCPtr(other)), true) {
    if (LinearMathPINVOKE.SWIGPendingException.Pending) throw LinearMathPINVOKE.SWIGPendingException.Retrieve();
  }

  public void mult(btTransform t1, btTransform t2) {
    LinearMathPINVOKE.btTransform_mult(swigCPtr, btTransform.getCPtr(t1), btTransform.getCPtr(t2));
    if (LinearMathPINVOKE.SWIGPendingException.Pending) throw LinearMathPINVOKE.SWIGPendingException.Retrieve();
  }

  public btMatrix3x3 getBasis() {
    btMatrix3x3 ret = new btMatrix3x3(LinearMathPINVOKE.btTransform_getBasis__SWIG_0(swigCPtr), false);
    return ret;
  }

  public btVector3 getOrigin() {
    btVector3 ret = new btVector3(LinearMathPINVOKE.btTransform_getOrigin__SWIG_0(swigCPtr), false);
    return ret;
  }

  public btQuaternion getRotation() {
    btQuaternion ret = new btQuaternion(LinearMathPINVOKE.btTransform_getRotation(swigCPtr), true);
    return ret;
  }

  public void setFromOpenGLMatrix(SWIGTYPE_p_float m) {
    LinearMathPINVOKE.btTransform_setFromOpenGLMatrix(swigCPtr, SWIGTYPE_p_float.getCPtr(m));
  }

  public void getOpenGLMatrix(SWIGTYPE_p_float m) {
    LinearMathPINVOKE.btTransform_getOpenGLMatrix(swigCPtr, SWIGTYPE_p_float.getCPtr(m));
  }

  public void setOrigin(btVector3 origin) {
    LinearMathPINVOKE.btTransform_setOrigin(swigCPtr, btVector3.getCPtr(origin));
    if (LinearMathPINVOKE.SWIGPendingException.Pending) throw LinearMathPINVOKE.SWIGPendingException.Retrieve();
  }

  public btVector3 invXform(btVector3 inVec) {
    btVector3 ret = new btVector3(LinearMathPINVOKE.btTransform_invXform(swigCPtr, btVector3.getCPtr(inVec)), true);
    if (LinearMathPINVOKE.SWIGPendingException.Pending) throw LinearMathPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setBasis(btMatrix3x3 basis) {
    LinearMathPINVOKE.btTransform_setBasis(swigCPtr, btMatrix3x3.getCPtr(basis));
    if (LinearMathPINVOKE.SWIGPendingException.Pending) throw LinearMathPINVOKE.SWIGPendingException.Retrieve();
  }

  public void setRotation(btQuaternion q) {
    LinearMathPINVOKE.btTransform_setRotation(swigCPtr, btQuaternion.getCPtr(q));
    if (LinearMathPINVOKE.SWIGPendingException.Pending) throw LinearMathPINVOKE.SWIGPendingException.Retrieve();
  }

  public void setIdentity() {
    LinearMathPINVOKE.btTransform_setIdentity(swigCPtr);
  }

  public btTransform inverse() {
    btTransform ret = new btTransform(LinearMathPINVOKE.btTransform_inverse(swigCPtr), true);
    return ret;
  }

  public btTransform inverseTimes(btTransform t) {
    btTransform ret = new btTransform(LinearMathPINVOKE.btTransform_inverseTimes(swigCPtr, btTransform.getCPtr(t)), true);
    if (LinearMathPINVOKE.SWIGPendingException.Pending) throw LinearMathPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static btTransform getIdentity() {
    btTransform ret = new btTransform(LinearMathPINVOKE.btTransform_getIdentity(), false);
    return ret;
  }

  public void serialize(btTransformFloatData dataOut) {
    LinearMathPINVOKE.btTransform_serialize(swigCPtr, btTransformFloatData.getCPtr(dataOut));
    if (LinearMathPINVOKE.SWIGPendingException.Pending) throw LinearMathPINVOKE.SWIGPendingException.Retrieve();
  }

  public void serializeFloat(btTransformFloatData dataOut) {
    LinearMathPINVOKE.btTransform_serializeFloat(swigCPtr, btTransformFloatData.getCPtr(dataOut));
    if (LinearMathPINVOKE.SWIGPendingException.Pending) throw LinearMathPINVOKE.SWIGPendingException.Retrieve();
  }

  public void deSerialize(btTransformFloatData dataIn) {
    LinearMathPINVOKE.btTransform_deSerialize(swigCPtr, btTransformFloatData.getCPtr(dataIn));
    if (LinearMathPINVOKE.SWIGPendingException.Pending) throw LinearMathPINVOKE.SWIGPendingException.Retrieve();
  }

  public void deSerializeDouble(btTransformDoubleData dataIn) {
    LinearMathPINVOKE.btTransform_deSerializeDouble(swigCPtr, btTransformDoubleData.getCPtr(dataIn));
    if (LinearMathPINVOKE.SWIGPendingException.Pending) throw LinearMathPINVOKE.SWIGPendingException.Retrieve();
  }

  public void deSerializeFloat(btTransformFloatData dataIn) {
    LinearMathPINVOKE.btTransform_deSerializeFloat(swigCPtr, btTransformFloatData.getCPtr(dataIn));
    if (LinearMathPINVOKE.SWIGPendingException.Pending) throw LinearMathPINVOKE.SWIGPendingException.Retrieve();
  }

}

}
