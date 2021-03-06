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

public class btDefaultCollisionConstructionInfo : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal btDefaultCollisionConstructionInfo(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(btDefaultCollisionConstructionInfo obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~btDefaultCollisionConstructionInfo() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          BulletCollisionPINVOKE.delete_btDefaultCollisionConstructionInfo(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public SWIGTYPE_p_btStackAlloc m_stackAlloc {
    set {
      BulletCollisionPINVOKE.btDefaultCollisionConstructionInfo_m_stackAlloc_set(swigCPtr, SWIGTYPE_p_btStackAlloc.getCPtr(value));
    } 
    get {
      IntPtr cPtr = BulletCollisionPINVOKE.btDefaultCollisionConstructionInfo_m_stackAlloc_get(swigCPtr);
      SWIGTYPE_p_btStackAlloc ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_btStackAlloc(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_btPoolAllocator m_persistentManifoldPool {
    set {
      BulletCollisionPINVOKE.btDefaultCollisionConstructionInfo_m_persistentManifoldPool_set(swigCPtr, SWIGTYPE_p_btPoolAllocator.getCPtr(value));
    } 
    get {
      IntPtr cPtr = BulletCollisionPINVOKE.btDefaultCollisionConstructionInfo_m_persistentManifoldPool_get(swigCPtr);
      SWIGTYPE_p_btPoolAllocator ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_btPoolAllocator(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_btPoolAllocator m_collisionAlgorithmPool {
    set {
      BulletCollisionPINVOKE.btDefaultCollisionConstructionInfo_m_collisionAlgorithmPool_set(swigCPtr, SWIGTYPE_p_btPoolAllocator.getCPtr(value));
    } 
    get {
      IntPtr cPtr = BulletCollisionPINVOKE.btDefaultCollisionConstructionInfo_m_collisionAlgorithmPool_get(swigCPtr);
      SWIGTYPE_p_btPoolAllocator ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_btPoolAllocator(cPtr, false);
      return ret;
    } 
  }

  public int m_defaultMaxPersistentManifoldPoolSize {
    set {
      BulletCollisionPINVOKE.btDefaultCollisionConstructionInfo_m_defaultMaxPersistentManifoldPoolSize_set(swigCPtr, value);
    } 
    get {
      int ret = BulletCollisionPINVOKE.btDefaultCollisionConstructionInfo_m_defaultMaxPersistentManifoldPoolSize_get(swigCPtr);
      return ret;
    } 
  }

  public int m_defaultMaxCollisionAlgorithmPoolSize {
    set {
      BulletCollisionPINVOKE.btDefaultCollisionConstructionInfo_m_defaultMaxCollisionAlgorithmPoolSize_set(swigCPtr, value);
    } 
    get {
      int ret = BulletCollisionPINVOKE.btDefaultCollisionConstructionInfo_m_defaultMaxCollisionAlgorithmPoolSize_get(swigCPtr);
      return ret;
    } 
  }

  public int m_customCollisionAlgorithmMaxElementSize {
    set {
      BulletCollisionPINVOKE.btDefaultCollisionConstructionInfo_m_customCollisionAlgorithmMaxElementSize_set(swigCPtr, value);
    } 
    get {
      int ret = BulletCollisionPINVOKE.btDefaultCollisionConstructionInfo_m_customCollisionAlgorithmMaxElementSize_get(swigCPtr);
      return ret;
    } 
  }

  public int m_defaultStackAllocatorSize {
    set {
      BulletCollisionPINVOKE.btDefaultCollisionConstructionInfo_m_defaultStackAllocatorSize_set(swigCPtr, value);
    } 
    get {
      int ret = BulletCollisionPINVOKE.btDefaultCollisionConstructionInfo_m_defaultStackAllocatorSize_get(swigCPtr);
      return ret;
    } 
  }

  public int m_useEpaPenetrationAlgorithm {
    set {
      BulletCollisionPINVOKE.btDefaultCollisionConstructionInfo_m_useEpaPenetrationAlgorithm_set(swigCPtr, value);
    } 
    get {
      int ret = BulletCollisionPINVOKE.btDefaultCollisionConstructionInfo_m_useEpaPenetrationAlgorithm_get(swigCPtr);
      return ret;
    } 
  }

  public btDefaultCollisionConstructionInfo() : this(BulletCollisionPINVOKE.new_btDefaultCollisionConstructionInfo(), true) {
  }

}

}
