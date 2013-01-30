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

public class btCompoundShape : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal btCompoundShape(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(btCompoundShape obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~btCompoundShape() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          BulletCollisionPINVOKE.delete_btCompoundShape(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public btCompoundShape(bool enableDynamicAabbTree) : this(BulletCollisionPINVOKE.new_btCompoundShape__SWIG_0(enableDynamicAabbTree), true) {
  }

  public btCompoundShape() : this(BulletCollisionPINVOKE.new_btCompoundShape__SWIG_1(), true) {
  }

  public void addChildShape(SWIGTYPE_p_btTransform localTransform, SWIGTYPE_p_btCollisionShape shape) {
    BulletCollisionPINVOKE.btCompoundShape_addChildShape(swigCPtr, SWIGTYPE_p_btTransform.getCPtr(localTransform), SWIGTYPE_p_btCollisionShape.getCPtr(shape));
    if (BulletCollisionPINVOKE.SWIGPendingException.Pending) throw BulletCollisionPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void removeChildShape(SWIGTYPE_p_btCollisionShape shape) {
    BulletCollisionPINVOKE.btCompoundShape_removeChildShape(swigCPtr, SWIGTYPE_p_btCollisionShape.getCPtr(shape));
  }

  public void removeChildShapeByIndex(int childShapeindex) {
    BulletCollisionPINVOKE.btCompoundShape_removeChildShapeByIndex(swigCPtr, childShapeindex);
  }

  public int getNumChildShapes() {
    int ret = BulletCollisionPINVOKE.btCompoundShape_getNumChildShapes(swigCPtr);
    return ret;
  }

  public SWIGTYPE_p_btCollisionShape getChildShape(int index) {
    IntPtr cPtr = BulletCollisionPINVOKE.btCompoundShape_getChildShape__SWIG_0(swigCPtr, index);
    SWIGTYPE_p_btCollisionShape ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_btCollisionShape(cPtr, false);
    return ret;
  }

  public SWIGTYPE_p_btTransform getChildTransform(int index) {
    SWIGTYPE_p_btTransform ret = new SWIGTYPE_p_btTransform(BulletCollisionPINVOKE.btCompoundShape_getChildTransform__SWIG_0(swigCPtr, index), false);
    return ret;
  }

  public void updateChildTransform(int childIndex, SWIGTYPE_p_btTransform newChildTransform, bool shouldRecalculateLocalAabb) {
    BulletCollisionPINVOKE.btCompoundShape_updateChildTransform__SWIG_0(swigCPtr, childIndex, SWIGTYPE_p_btTransform.getCPtr(newChildTransform), shouldRecalculateLocalAabb);
    if (BulletCollisionPINVOKE.SWIGPendingException.Pending) throw BulletCollisionPINVOKE.SWIGPendingException.Retrieve();
  }

  public void updateChildTransform(int childIndex, SWIGTYPE_p_btTransform newChildTransform) {
    BulletCollisionPINVOKE.btCompoundShape_updateChildTransform__SWIG_1(swigCPtr, childIndex, SWIGTYPE_p_btTransform.getCPtr(newChildTransform));
    if (BulletCollisionPINVOKE.SWIGPendingException.Pending) throw BulletCollisionPINVOKE.SWIGPendingException.Retrieve();
  }

  public btCompoundShapeChild getChildList() {
    IntPtr cPtr = BulletCollisionPINVOKE.btCompoundShape_getChildList(swigCPtr);
    btCompoundShapeChild ret = (cPtr == IntPtr.Zero) ? null : new btCompoundShapeChild(cPtr, false);
    return ret;
  }

  public virtual void getAabb(SWIGTYPE_p_btTransform t, SWIGTYPE_p_btVector3 aabbMin, SWIGTYPE_p_btVector3 aabbMax) {
    BulletCollisionPINVOKE.btCompoundShape_getAabb(swigCPtr, SWIGTYPE_p_btTransform.getCPtr(t), SWIGTYPE_p_btVector3.getCPtr(aabbMin), SWIGTYPE_p_btVector3.getCPtr(aabbMax));
    if (BulletCollisionPINVOKE.SWIGPendingException.Pending) throw BulletCollisionPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void recalculateLocalAabb() {
    BulletCollisionPINVOKE.btCompoundShape_recalculateLocalAabb(swigCPtr);
  }

  public virtual void setLocalScaling(SWIGTYPE_p_btVector3 scaling) {
    BulletCollisionPINVOKE.btCompoundShape_setLocalScaling(swigCPtr, SWIGTYPE_p_btVector3.getCPtr(scaling));
    if (BulletCollisionPINVOKE.SWIGPendingException.Pending) throw BulletCollisionPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual SWIGTYPE_p_btVector3 getLocalScaling() {
    SWIGTYPE_p_btVector3 ret = new SWIGTYPE_p_btVector3(BulletCollisionPINVOKE.btCompoundShape_getLocalScaling(swigCPtr), false);
    return ret;
  }

  public virtual void calculateLocalInertia(float mass, SWIGTYPE_p_btVector3 inertia) {
    BulletCollisionPINVOKE.btCompoundShape_calculateLocalInertia(swigCPtr, mass, SWIGTYPE_p_btVector3.getCPtr(inertia));
    if (BulletCollisionPINVOKE.SWIGPendingException.Pending) throw BulletCollisionPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void setMargin(float margin) {
    BulletCollisionPINVOKE.btCompoundShape_setMargin(swigCPtr, margin);
  }

  public virtual float getMargin() {
    float ret = BulletCollisionPINVOKE.btCompoundShape_getMargin(swigCPtr);
    return ret;
  }

  public virtual string getName() {
    string ret = BulletCollisionPINVOKE.btCompoundShape_getName(swigCPtr);
    return ret;
  }

  public SWIGTYPE_p_btDbvt getDynamicAabbTree() {
    IntPtr cPtr = BulletCollisionPINVOKE.btCompoundShape_getDynamicAabbTree__SWIG_0(swigCPtr);
    SWIGTYPE_p_btDbvt ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_btDbvt(cPtr, false);
    return ret;
  }

  public void createAabbTreeFromChildren() {
    BulletCollisionPINVOKE.btCompoundShape_createAabbTreeFromChildren(swigCPtr);
  }

  public void calculatePrincipalAxisTransform(SWIGTYPE_p_float masses, SWIGTYPE_p_btTransform principal, SWIGTYPE_p_btVector3 inertia) {
    BulletCollisionPINVOKE.btCompoundShape_calculatePrincipalAxisTransform(swigCPtr, SWIGTYPE_p_float.getCPtr(masses), SWIGTYPE_p_btTransform.getCPtr(principal), SWIGTYPE_p_btVector3.getCPtr(inertia));
    if (BulletCollisionPINVOKE.SWIGPendingException.Pending) throw BulletCollisionPINVOKE.SWIGPendingException.Retrieve();
  }

  public int getUpdateRevision() {
    int ret = BulletCollisionPINVOKE.btCompoundShape_getUpdateRevision(swigCPtr);
    return ret;
  }

  public virtual int calculateSerializeBufferSize() {
    int ret = BulletCollisionPINVOKE.btCompoundShape_calculateSerializeBufferSize(swigCPtr);
    return ret;
  }

  public virtual string serialize(SWIGTYPE_p_void dataBuffer, SWIGTYPE_p_btSerializer serializer) {
    string ret = BulletCollisionPINVOKE.btCompoundShape_serialize(swigCPtr, SWIGTYPE_p_void.getCPtr(dataBuffer), SWIGTYPE_p_btSerializer.getCPtr(serializer));
    return ret;
  }

}

}
