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

public class btSoftRigidDynamicsWorld : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal btSoftRigidDynamicsWorld(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(btSoftRigidDynamicsWorld obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~btSoftRigidDynamicsWorld() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          BulletSoftBodyPINVOKE.delete_btSoftRigidDynamicsWorld(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public btSoftRigidDynamicsWorld(SWIGTYPE_p_btDispatcher dispatcher, SWIGTYPE_p_btBroadphaseInterface pairCache, SWIGTYPE_p_btConstraintSolver constraintSolver, SWIGTYPE_p_btCollisionConfiguration collisionConfiguration, btSoftBodySolver softBodySolver) : this(BulletSoftBodyPINVOKE.new_btSoftRigidDynamicsWorld__SWIG_0(SWIGTYPE_p_btDispatcher.getCPtr(dispatcher), SWIGTYPE_p_btBroadphaseInterface.getCPtr(pairCache), SWIGTYPE_p_btConstraintSolver.getCPtr(constraintSolver), SWIGTYPE_p_btCollisionConfiguration.getCPtr(collisionConfiguration), btSoftBodySolver.getCPtr(softBodySolver)), true) {
  }

  public btSoftRigidDynamicsWorld(SWIGTYPE_p_btDispatcher dispatcher, SWIGTYPE_p_btBroadphaseInterface pairCache, SWIGTYPE_p_btConstraintSolver constraintSolver, SWIGTYPE_p_btCollisionConfiguration collisionConfiguration) : this(BulletSoftBodyPINVOKE.new_btSoftRigidDynamicsWorld__SWIG_1(SWIGTYPE_p_btDispatcher.getCPtr(dispatcher), SWIGTYPE_p_btBroadphaseInterface.getCPtr(pairCache), SWIGTYPE_p_btConstraintSolver.getCPtr(constraintSolver), SWIGTYPE_p_btCollisionConfiguration.getCPtr(collisionConfiguration)), true) {
  }

  public virtual void debugDrawWorld() {
    BulletSoftBodyPINVOKE.btSoftRigidDynamicsWorld_debugDrawWorld(swigCPtr);
  }

  public virtual int stepSimulation(float timeStep, int maxSubSteps, float fixedTimeStep) {
    int ret = BulletSoftBodyPINVOKE.btSoftRigidDynamicsWorld_stepSimulation__SWIG_0(swigCPtr, timeStep, maxSubSteps, fixedTimeStep);
    return ret;
  }

  public virtual int stepSimulation(float timeStep, int maxSubSteps) {
    int ret = BulletSoftBodyPINVOKE.btSoftRigidDynamicsWorld_stepSimulation__SWIG_1(swigCPtr, timeStep, maxSubSteps);
    return ret;
  }

  public virtual int stepSimulation(float timeStep) {
    int ret = BulletSoftBodyPINVOKE.btSoftRigidDynamicsWorld_stepSimulation__SWIG_2(swigCPtr, timeStep);
    return ret;
  }

  public SWIGTYPE_p_btCollisionWorld getCollisionWorld() {
    IntPtr cPtr = BulletSoftBodyPINVOKE.btSoftRigidDynamicsWorld_getCollisionWorld(swigCPtr);
    SWIGTYPE_p_btCollisionWorld ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_btCollisionWorld(cPtr, false);
    return ret;
  }

  public SWIGTYPE_p_btDiscreteDynamicsWorld getDiscreteDynamicsWorld() {
    IntPtr cPtr = BulletSoftBodyPINVOKE.btSoftRigidDynamicsWorld_getDiscreteDynamicsWorld(swigCPtr);
    SWIGTYPE_p_btDiscreteDynamicsWorld ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_btDiscreteDynamicsWorld(cPtr, false);
    return ret;
  }

  public void addSoftBody(btSoftBody body, short collisionFilterGroup, short collisionFilterMask) {
    BulletSoftBodyPINVOKE.btSoftRigidDynamicsWorld_addSoftBody__SWIG_0(swigCPtr, btSoftBody.getCPtr(body), collisionFilterGroup, collisionFilterMask);
  }

  public void addSoftBody(btSoftBody body, short collisionFilterGroup) {
    BulletSoftBodyPINVOKE.btSoftRigidDynamicsWorld_addSoftBody__SWIG_1(swigCPtr, btSoftBody.getCPtr(body), collisionFilterGroup);
  }

  public void addSoftBody(btSoftBody body) {
    BulletSoftBodyPINVOKE.btSoftRigidDynamicsWorld_addSoftBody__SWIG_2(swigCPtr, btSoftBody.getCPtr(body));
  }

  public void removeSoftBody(btSoftBody body) {
    BulletSoftBodyPINVOKE.btSoftRigidDynamicsWorld_removeSoftBody(swigCPtr, btSoftBody.getCPtr(body));
  }

  public virtual void removeCollisionObject(SWIGTYPE_p_btCollisionObject collisionObject) {
    BulletSoftBodyPINVOKE.btSoftRigidDynamicsWorld_removeCollisionObject(swigCPtr, SWIGTYPE_p_btCollisionObject.getCPtr(collisionObject));
  }

  public int getDrawFlags() {
    int ret = BulletSoftBodyPINVOKE.btSoftRigidDynamicsWorld_getDrawFlags(swigCPtr);
    return ret;
  }

  public void setDrawFlags(int f) {
    BulletSoftBodyPINVOKE.btSoftRigidDynamicsWorld_setDrawFlags(swigCPtr, f);
  }

  public btSoftBodyWorldInfo getWorldInfo() {
    btSoftBodyWorldInfo ret = new btSoftBodyWorldInfo(BulletSoftBodyPINVOKE.btSoftRigidDynamicsWorld_getWorldInfo__SWIG_0(swigCPtr), false);
    return ret;
  }

  public virtual SWIGTYPE_p_btDynamicsWorldType getWorldType() {
    SWIGTYPE_p_btDynamicsWorldType ret = new SWIGTYPE_p_btDynamicsWorldType(BulletSoftBodyPINVOKE.btSoftRigidDynamicsWorld_getWorldType(swigCPtr), true);
    return ret;
  }

  public SWIGTYPE_p_btAlignedObjectArrayT_btSoftBody_p_t getSoftBodyArray() {
    SWIGTYPE_p_btAlignedObjectArrayT_btSoftBody_p_t ret = new SWIGTYPE_p_btAlignedObjectArrayT_btSoftBody_p_t(BulletSoftBodyPINVOKE.btSoftRigidDynamicsWorld_getSoftBodyArray__SWIG_0(swigCPtr), false);
    return ret;
  }

  public virtual void rayTest(SWIGTYPE_p_btVector3 rayFromWorld, SWIGTYPE_p_btVector3 rayToWorld, RayResultCallback resultCallback) {
    BulletSoftBodyPINVOKE.btSoftRigidDynamicsWorld_rayTest(swigCPtr, SWIGTYPE_p_btVector3.getCPtr(rayFromWorld), SWIGTYPE_p_btVector3.getCPtr(rayToWorld), RayResultCallback.getCPtr(resultCallback));
    if (BulletSoftBodyPINVOKE.SWIGPendingException.Pending) throw BulletSoftBodyPINVOKE.SWIGPendingException.Retrieve();
  }

  public static void rayTestSingle(SWIGTYPE_p_btTransform rayFromTrans, SWIGTYPE_p_btTransform rayToTrans, SWIGTYPE_p_btCollisionObject collisionObject, SWIGTYPE_p_btCollisionShape collisionShape, SWIGTYPE_p_btTransform colObjWorldTransform, RayResultCallback resultCallback) {
    BulletSoftBodyPINVOKE.btSoftRigidDynamicsWorld_rayTestSingle(SWIGTYPE_p_btTransform.getCPtr(rayFromTrans), SWIGTYPE_p_btTransform.getCPtr(rayToTrans), SWIGTYPE_p_btCollisionObject.getCPtr(collisionObject), SWIGTYPE_p_btCollisionShape.getCPtr(collisionShape), SWIGTYPE_p_btTransform.getCPtr(colObjWorldTransform), RayResultCallback.getCPtr(resultCallback));
    if (BulletSoftBodyPINVOKE.SWIGPendingException.Pending) throw BulletSoftBodyPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void serialize(SWIGTYPE_p_btSerializer serializer) {
    BulletSoftBodyPINVOKE.btSoftRigidDynamicsWorld_serialize(swigCPtr, SWIGTYPE_p_btSerializer.getCPtr(serializer));
  }

}

}
