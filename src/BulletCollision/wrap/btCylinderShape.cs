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

public class btCylinderShape : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal btCylinderShape(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(btCylinderShape obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~btCylinderShape() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          BulletCollisionPINVOKE.delete_btCylinderShape(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public SWIGTYPE_p_btVector3 getHalfExtentsWithMargin() {
    SWIGTYPE_p_btVector3 ret = new SWIGTYPE_p_btVector3(BulletCollisionPINVOKE.btCylinderShape_getHalfExtentsWithMargin(swigCPtr), true);
    return ret;
  }

  public SWIGTYPE_p_btVector3 getHalfExtentsWithoutMargin() {
    SWIGTYPE_p_btVector3 ret = new SWIGTYPE_p_btVector3(BulletCollisionPINVOKE.btCylinderShape_getHalfExtentsWithoutMargin(swigCPtr), false);
    return ret;
  }

  public btCylinderShape(SWIGTYPE_p_btVector3 halfExtents) : this(BulletCollisionPINVOKE.new_btCylinderShape(SWIGTYPE_p_btVector3.getCPtr(halfExtents)), true) {
    if (BulletCollisionPINVOKE.SWIGPendingException.Pending) throw BulletCollisionPINVOKE.SWIGPendingException.Retrieve();
  }

  public void getAabb(SWIGTYPE_p_btTransform t, SWIGTYPE_p_btVector3 aabbMin, SWIGTYPE_p_btVector3 aabbMax) {
    BulletCollisionPINVOKE.btCylinderShape_getAabb(swigCPtr, SWIGTYPE_p_btTransform.getCPtr(t), SWIGTYPE_p_btVector3.getCPtr(aabbMin), SWIGTYPE_p_btVector3.getCPtr(aabbMax));
    if (BulletCollisionPINVOKE.SWIGPendingException.Pending) throw BulletCollisionPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void calculateLocalInertia(float mass, SWIGTYPE_p_btVector3 inertia) {
    BulletCollisionPINVOKE.btCylinderShape_calculateLocalInertia(swigCPtr, mass, SWIGTYPE_p_btVector3.getCPtr(inertia));
    if (BulletCollisionPINVOKE.SWIGPendingException.Pending) throw BulletCollisionPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual SWIGTYPE_p_btVector3 localGetSupportingVertexWithoutMargin(SWIGTYPE_p_btVector3 vec) {
    SWIGTYPE_p_btVector3 ret = new SWIGTYPE_p_btVector3(BulletCollisionPINVOKE.btCylinderShape_localGetSupportingVertexWithoutMargin(swigCPtr, SWIGTYPE_p_btVector3.getCPtr(vec)), true);
    if (BulletCollisionPINVOKE.SWIGPendingException.Pending) throw BulletCollisionPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual void batchedUnitVectorGetSupportingVertexWithoutMargin(SWIGTYPE_p_btVector3 vectors, SWIGTYPE_p_btVector3 supportVerticesOut, int numVectors) {
    BulletCollisionPINVOKE.btCylinderShape_batchedUnitVectorGetSupportingVertexWithoutMargin(swigCPtr, SWIGTYPE_p_btVector3.getCPtr(vectors), SWIGTYPE_p_btVector3.getCPtr(supportVerticesOut), numVectors);
  }

  public virtual void setMargin(float collisionMargin) {
    BulletCollisionPINVOKE.btCylinderShape_setMargin(swigCPtr, collisionMargin);
  }

  public virtual SWIGTYPE_p_btVector3 localGetSupportingVertex(SWIGTYPE_p_btVector3 vec) {
    SWIGTYPE_p_btVector3 ret = new SWIGTYPE_p_btVector3(BulletCollisionPINVOKE.btCylinderShape_localGetSupportingVertex(swigCPtr, SWIGTYPE_p_btVector3.getCPtr(vec)), true);
    if (BulletCollisionPINVOKE.SWIGPendingException.Pending) throw BulletCollisionPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int getUpAxis() {
    int ret = BulletCollisionPINVOKE.btCylinderShape_getUpAxis(swigCPtr);
    return ret;
  }

  public virtual SWIGTYPE_p_btVector3 getAnisotropicRollingFrictionDirection() {
    SWIGTYPE_p_btVector3 ret = new SWIGTYPE_p_btVector3(BulletCollisionPINVOKE.btCylinderShape_getAnisotropicRollingFrictionDirection(swigCPtr), true);
    return ret;
  }

  public virtual float getRadius() {
    float ret = BulletCollisionPINVOKE.btCylinderShape_getRadius(swigCPtr);
    return ret;
  }

  public virtual void setLocalScaling(SWIGTYPE_p_btVector3 scaling) {
    BulletCollisionPINVOKE.btCylinderShape_setLocalScaling(swigCPtr, SWIGTYPE_p_btVector3.getCPtr(scaling));
    if (BulletCollisionPINVOKE.SWIGPendingException.Pending) throw BulletCollisionPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual string getName() {
    string ret = BulletCollisionPINVOKE.btCylinderShape_getName(swigCPtr);
    return ret;
  }

  public virtual int calculateSerializeBufferSize() {
    int ret = BulletCollisionPINVOKE.btCylinderShape_calculateSerializeBufferSize(swigCPtr);
    return ret;
  }

  public virtual string serialize(SWIGTYPE_p_void dataBuffer, SWIGTYPE_p_btSerializer serializer) {
    string ret = BulletCollisionPINVOKE.btCylinderShape_serialize(swigCPtr, SWIGTYPE_p_void.getCPtr(dataBuffer), SWIGTYPE_p_btSerializer.getCPtr(serializer));
    return ret;
  }

}

}
