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

public class btMultiSphereShape : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal btMultiSphereShape(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(btMultiSphereShape obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~btMultiSphereShape() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          BulletCollisionPINVOKE.delete_btMultiSphereShape(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public btMultiSphereShape(SWIGTYPE_p_btVector3 positions, SWIGTYPE_p_float radi, int numSpheres) : this(BulletCollisionPINVOKE.new_btMultiSphereShape(SWIGTYPE_p_btVector3.getCPtr(positions), SWIGTYPE_p_float.getCPtr(radi), numSpheres), true) {
  }

  public virtual void calculateLocalInertia(float mass, SWIGTYPE_p_btVector3 inertia) {
    BulletCollisionPINVOKE.btMultiSphereShape_calculateLocalInertia(swigCPtr, mass, SWIGTYPE_p_btVector3.getCPtr(inertia));
    if (BulletCollisionPINVOKE.SWIGPendingException.Pending) throw BulletCollisionPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual SWIGTYPE_p_btVector3 localGetSupportingVertexWithoutMargin(SWIGTYPE_p_btVector3 vec) {
    SWIGTYPE_p_btVector3 ret = new SWIGTYPE_p_btVector3(BulletCollisionPINVOKE.btMultiSphereShape_localGetSupportingVertexWithoutMargin(swigCPtr, SWIGTYPE_p_btVector3.getCPtr(vec)), true);
    if (BulletCollisionPINVOKE.SWIGPendingException.Pending) throw BulletCollisionPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual void batchedUnitVectorGetSupportingVertexWithoutMargin(SWIGTYPE_p_btVector3 vectors, SWIGTYPE_p_btVector3 supportVerticesOut, int numVectors) {
    BulletCollisionPINVOKE.btMultiSphereShape_batchedUnitVectorGetSupportingVertexWithoutMargin(swigCPtr, SWIGTYPE_p_btVector3.getCPtr(vectors), SWIGTYPE_p_btVector3.getCPtr(supportVerticesOut), numVectors);
  }

  public int getSphereCount() {
    int ret = BulletCollisionPINVOKE.btMultiSphereShape_getSphereCount(swigCPtr);
    return ret;
  }

  public SWIGTYPE_p_btVector3 getSpherePosition(int index) {
    SWIGTYPE_p_btVector3 ret = new SWIGTYPE_p_btVector3(BulletCollisionPINVOKE.btMultiSphereShape_getSpherePosition(swigCPtr, index), false);
    return ret;
  }

  public float getSphereRadius(int index) {
    float ret = BulletCollisionPINVOKE.btMultiSphereShape_getSphereRadius(swigCPtr, index);
    return ret;
  }

  public virtual string getName() {
    string ret = BulletCollisionPINVOKE.btMultiSphereShape_getName(swigCPtr);
    return ret;
  }

  public virtual int calculateSerializeBufferSize() {
    int ret = BulletCollisionPINVOKE.btMultiSphereShape_calculateSerializeBufferSize(swigCPtr);
    return ret;
  }

  public virtual string serialize(SWIGTYPE_p_void dataBuffer, SWIGTYPE_p_btSerializer serializer) {
    string ret = BulletCollisionPINVOKE.btMultiSphereShape_serialize(swigCPtr, SWIGTYPE_p_void.getCPtr(dataBuffer), SWIGTYPE_p_btSerializer.getCPtr(serializer));
    return ret;
  }

}

}
