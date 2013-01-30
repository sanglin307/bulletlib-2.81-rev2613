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

public class btCollisionWorld : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal btCollisionWorld(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(btCollisionWorld obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~btCollisionWorld() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          BulletCollisionPINVOKE.delete_btCollisionWorld(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public btCollisionWorld(SWIGTYPE_p_btDispatcher dispatcher, SWIGTYPE_p_btBroadphaseInterface broadphasePairCache, SWIGTYPE_p_btCollisionConfiguration collisionConfiguration) : this(BulletCollisionPINVOKE.new_btCollisionWorld(SWIGTYPE_p_btDispatcher.getCPtr(dispatcher), SWIGTYPE_p_btBroadphaseInterface.getCPtr(broadphasePairCache), SWIGTYPE_p_btCollisionConfiguration.getCPtr(collisionConfiguration)), true) {
  }

  public void setBroadphase(SWIGTYPE_p_btBroadphaseInterface pairCache) {
    BulletCollisionPINVOKE.btCollisionWorld_setBroadphase(swigCPtr, SWIGTYPE_p_btBroadphaseInterface.getCPtr(pairCache));
  }

  public SWIGTYPE_p_btBroadphaseInterface getBroadphase() {
    IntPtr cPtr = BulletCollisionPINVOKE.btCollisionWorld_getBroadphase__SWIG_0(swigCPtr);
    SWIGTYPE_p_btBroadphaseInterface ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_btBroadphaseInterface(cPtr, false);
    return ret;
  }

  public SWIGTYPE_p_btOverlappingPairCache getPairCache() {
    IntPtr cPtr = BulletCollisionPINVOKE.btCollisionWorld_getPairCache(swigCPtr);
    SWIGTYPE_p_btOverlappingPairCache ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_btOverlappingPairCache(cPtr, false);
    return ret;
  }

  public SWIGTYPE_p_btDispatcher getDispatcher() {
    IntPtr cPtr = BulletCollisionPINVOKE.btCollisionWorld_getDispatcher__SWIG_0(swigCPtr);
    SWIGTYPE_p_btDispatcher ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_btDispatcher(cPtr, false);
    return ret;
  }

  public void updateSingleAabb(btCollisionObject colObj) {
    BulletCollisionPINVOKE.btCollisionWorld_updateSingleAabb(swigCPtr, btCollisionObject.getCPtr(colObj));
  }

  public virtual void updateAabbs() {
    BulletCollisionPINVOKE.btCollisionWorld_updateAabbs(swigCPtr);
  }

  public virtual void computeOverlappingPairs() {
    BulletCollisionPINVOKE.btCollisionWorld_computeOverlappingPairs(swigCPtr);
  }

  public virtual void setDebugDrawer(SWIGTYPE_p_btIDebugDraw debugDrawer) {
    BulletCollisionPINVOKE.btCollisionWorld_setDebugDrawer(swigCPtr, SWIGTYPE_p_btIDebugDraw.getCPtr(debugDrawer));
  }

  public virtual SWIGTYPE_p_btIDebugDraw getDebugDrawer() {
    IntPtr cPtr = BulletCollisionPINVOKE.btCollisionWorld_getDebugDrawer(swigCPtr);
    SWIGTYPE_p_btIDebugDraw ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_btIDebugDraw(cPtr, false);
    return ret;
  }

  public virtual void debugDrawWorld() {
    BulletCollisionPINVOKE.btCollisionWorld_debugDrawWorld(swigCPtr);
  }

  public virtual void debugDrawObject(SWIGTYPE_p_btTransform worldTransform, SWIGTYPE_p_btCollisionShape shape, SWIGTYPE_p_btVector3 color) {
    BulletCollisionPINVOKE.btCollisionWorld_debugDrawObject(swigCPtr, SWIGTYPE_p_btTransform.getCPtr(worldTransform), SWIGTYPE_p_btCollisionShape.getCPtr(shape), SWIGTYPE_p_btVector3.getCPtr(color));
    if (BulletCollisionPINVOKE.SWIGPendingException.Pending) throw BulletCollisionPINVOKE.SWIGPendingException.Retrieve();
  }

  public int getNumCollisionObjects() {
    int ret = BulletCollisionPINVOKE.btCollisionWorld_getNumCollisionObjects(swigCPtr);
    return ret;
  }

  public virtual void rayTest(SWIGTYPE_p_btVector3 rayFromWorld, SWIGTYPE_p_btVector3 rayToWorld, SWIGTYPE_p_btCollisionWorld__RayResultCallback resultCallback) {
    BulletCollisionPINVOKE.btCollisionWorld_rayTest(swigCPtr, SWIGTYPE_p_btVector3.getCPtr(rayFromWorld), SWIGTYPE_p_btVector3.getCPtr(rayToWorld), SWIGTYPE_p_btCollisionWorld__RayResultCallback.getCPtr(resultCallback));
    if (BulletCollisionPINVOKE.SWIGPendingException.Pending) throw BulletCollisionPINVOKE.SWIGPendingException.Retrieve();
  }

  public void convexSweepTest(SWIGTYPE_p_btConvexShape castShape, SWIGTYPE_p_btTransform from, SWIGTYPE_p_btTransform to, SWIGTYPE_p_btCollisionWorld__ConvexResultCallback resultCallback, float allowedCcdPenetration) {
    BulletCollisionPINVOKE.btCollisionWorld_convexSweepTest__SWIG_0(swigCPtr, SWIGTYPE_p_btConvexShape.getCPtr(castShape), SWIGTYPE_p_btTransform.getCPtr(from), SWIGTYPE_p_btTransform.getCPtr(to), SWIGTYPE_p_btCollisionWorld__ConvexResultCallback.getCPtr(resultCallback), allowedCcdPenetration);
    if (BulletCollisionPINVOKE.SWIGPendingException.Pending) throw BulletCollisionPINVOKE.SWIGPendingException.Retrieve();
  }

  public void convexSweepTest(SWIGTYPE_p_btConvexShape castShape, SWIGTYPE_p_btTransform from, SWIGTYPE_p_btTransform to, SWIGTYPE_p_btCollisionWorld__ConvexResultCallback resultCallback) {
    BulletCollisionPINVOKE.btCollisionWorld_convexSweepTest__SWIG_1(swigCPtr, SWIGTYPE_p_btConvexShape.getCPtr(castShape), SWIGTYPE_p_btTransform.getCPtr(from), SWIGTYPE_p_btTransform.getCPtr(to), SWIGTYPE_p_btCollisionWorld__ConvexResultCallback.getCPtr(resultCallback));
    if (BulletCollisionPINVOKE.SWIGPendingException.Pending) throw BulletCollisionPINVOKE.SWIGPendingException.Retrieve();
  }

  public void contactTest(btCollisionObject colObj, SWIGTYPE_p_btCollisionWorld__ContactResultCallback resultCallback) {
    BulletCollisionPINVOKE.btCollisionWorld_contactTest(swigCPtr, btCollisionObject.getCPtr(colObj), SWIGTYPE_p_btCollisionWorld__ContactResultCallback.getCPtr(resultCallback));
    if (BulletCollisionPINVOKE.SWIGPendingException.Pending) throw BulletCollisionPINVOKE.SWIGPendingException.Retrieve();
  }

  public void contactPairTest(btCollisionObject colObjA, btCollisionObject colObjB, SWIGTYPE_p_btCollisionWorld__ContactResultCallback resultCallback) {
    BulletCollisionPINVOKE.btCollisionWorld_contactPairTest(swigCPtr, btCollisionObject.getCPtr(colObjA), btCollisionObject.getCPtr(colObjB), SWIGTYPE_p_btCollisionWorld__ContactResultCallback.getCPtr(resultCallback));
    if (BulletCollisionPINVOKE.SWIGPendingException.Pending) throw BulletCollisionPINVOKE.SWIGPendingException.Retrieve();
  }

  public static void rayTestSingle(SWIGTYPE_p_btTransform rayFromTrans, SWIGTYPE_p_btTransform rayToTrans, btCollisionObject collisionObject, SWIGTYPE_p_btCollisionShape collisionShape, SWIGTYPE_p_btTransform colObjWorldTransform, SWIGTYPE_p_btCollisionWorld__RayResultCallback resultCallback) {
    BulletCollisionPINVOKE.btCollisionWorld_rayTestSingle(SWIGTYPE_p_btTransform.getCPtr(rayFromTrans), SWIGTYPE_p_btTransform.getCPtr(rayToTrans), btCollisionObject.getCPtr(collisionObject), SWIGTYPE_p_btCollisionShape.getCPtr(collisionShape), SWIGTYPE_p_btTransform.getCPtr(colObjWorldTransform), SWIGTYPE_p_btCollisionWorld__RayResultCallback.getCPtr(resultCallback));
    if (BulletCollisionPINVOKE.SWIGPendingException.Pending) throw BulletCollisionPINVOKE.SWIGPendingException.Retrieve();
  }

  public static void rayTestSingleInternal(SWIGTYPE_p_btTransform rayFromTrans, SWIGTYPE_p_btTransform rayToTrans, SWIGTYPE_p_btCollisionObjectWrapper collisionObjectWrap, SWIGTYPE_p_btCollisionWorld__RayResultCallback resultCallback) {
    BulletCollisionPINVOKE.btCollisionWorld_rayTestSingleInternal(SWIGTYPE_p_btTransform.getCPtr(rayFromTrans), SWIGTYPE_p_btTransform.getCPtr(rayToTrans), SWIGTYPE_p_btCollisionObjectWrapper.getCPtr(collisionObjectWrap), SWIGTYPE_p_btCollisionWorld__RayResultCallback.getCPtr(resultCallback));
    if (BulletCollisionPINVOKE.SWIGPendingException.Pending) throw BulletCollisionPINVOKE.SWIGPendingException.Retrieve();
  }

  public static void objectQuerySingle(SWIGTYPE_p_btConvexShape castShape, SWIGTYPE_p_btTransform rayFromTrans, SWIGTYPE_p_btTransform rayToTrans, btCollisionObject collisionObject, SWIGTYPE_p_btCollisionShape collisionShape, SWIGTYPE_p_btTransform colObjWorldTransform, SWIGTYPE_p_btCollisionWorld__ConvexResultCallback resultCallback, float allowedPenetration) {
    BulletCollisionPINVOKE.btCollisionWorld_objectQuerySingle(SWIGTYPE_p_btConvexShape.getCPtr(castShape), SWIGTYPE_p_btTransform.getCPtr(rayFromTrans), SWIGTYPE_p_btTransform.getCPtr(rayToTrans), btCollisionObject.getCPtr(collisionObject), SWIGTYPE_p_btCollisionShape.getCPtr(collisionShape), SWIGTYPE_p_btTransform.getCPtr(colObjWorldTransform), SWIGTYPE_p_btCollisionWorld__ConvexResultCallback.getCPtr(resultCallback), allowedPenetration);
    if (BulletCollisionPINVOKE.SWIGPendingException.Pending) throw BulletCollisionPINVOKE.SWIGPendingException.Retrieve();
  }

  public static void objectQuerySingleInternal(SWIGTYPE_p_btConvexShape castShape, SWIGTYPE_p_btTransform convexFromTrans, SWIGTYPE_p_btTransform convexToTrans, SWIGTYPE_p_btCollisionObjectWrapper colObjWrap, SWIGTYPE_p_btCollisionWorld__ConvexResultCallback resultCallback, float allowedPenetration) {
    BulletCollisionPINVOKE.btCollisionWorld_objectQuerySingleInternal(SWIGTYPE_p_btConvexShape.getCPtr(castShape), SWIGTYPE_p_btTransform.getCPtr(convexFromTrans), SWIGTYPE_p_btTransform.getCPtr(convexToTrans), SWIGTYPE_p_btCollisionObjectWrapper.getCPtr(colObjWrap), SWIGTYPE_p_btCollisionWorld__ConvexResultCallback.getCPtr(resultCallback), allowedPenetration);
    if (BulletCollisionPINVOKE.SWIGPendingException.Pending) throw BulletCollisionPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void addCollisionObject(btCollisionObject collisionObject, short collisionFilterGroup, short collisionFilterMask) {
    BulletCollisionPINVOKE.btCollisionWorld_addCollisionObject__SWIG_0(swigCPtr, btCollisionObject.getCPtr(collisionObject), collisionFilterGroup, collisionFilterMask);
  }

  public virtual void addCollisionObject(btCollisionObject collisionObject, short collisionFilterGroup) {
    BulletCollisionPINVOKE.btCollisionWorld_addCollisionObject__SWIG_1(swigCPtr, btCollisionObject.getCPtr(collisionObject), collisionFilterGroup);
  }

  public virtual void addCollisionObject(btCollisionObject collisionObject) {
    BulletCollisionPINVOKE.btCollisionWorld_addCollisionObject__SWIG_2(swigCPtr, btCollisionObject.getCPtr(collisionObject));
  }

  public SWIGTYPE_p_btAlignedObjectArrayT_btCollisionObject_p_t getCollisionObjectArray() {
    SWIGTYPE_p_btAlignedObjectArrayT_btCollisionObject_p_t ret = new SWIGTYPE_p_btAlignedObjectArrayT_btCollisionObject_p_t(BulletCollisionPINVOKE.btCollisionWorld_getCollisionObjectArray__SWIG_0(swigCPtr), false);
    return ret;
  }

  public virtual void removeCollisionObject(btCollisionObject collisionObject) {
    BulletCollisionPINVOKE.btCollisionWorld_removeCollisionObject(swigCPtr, btCollisionObject.getCPtr(collisionObject));
  }

  public virtual void performDiscreteCollisionDetection() {
    BulletCollisionPINVOKE.btCollisionWorld_performDiscreteCollisionDetection(swigCPtr);
  }

  public SWIGTYPE_p_btDispatcherInfo getDispatchInfo() {
    SWIGTYPE_p_btDispatcherInfo ret = new SWIGTYPE_p_btDispatcherInfo(BulletCollisionPINVOKE.btCollisionWorld_getDispatchInfo__SWIG_0(swigCPtr), false);
    return ret;
  }

  public bool getForceUpdateAllAabbs() {
    bool ret = BulletCollisionPINVOKE.btCollisionWorld_getForceUpdateAllAabbs(swigCPtr);
    return ret;
  }

  public void setForceUpdateAllAabbs(bool forceUpdateAllAabbs) {
    BulletCollisionPINVOKE.btCollisionWorld_setForceUpdateAllAabbs(swigCPtr, forceUpdateAllAabbs);
  }

  public virtual void serialize(SWIGTYPE_p_btSerializer serializer) {
    BulletCollisionPINVOKE.btCollisionWorld_serialize(swigCPtr, SWIGTYPE_p_btSerializer.getCPtr(serializer));
  }

}

}
