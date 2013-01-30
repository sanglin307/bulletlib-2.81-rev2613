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

public class btAlignedObjectArrayeVSolver : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal btAlignedObjectArrayeVSolver(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(btAlignedObjectArrayeVSolver obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~btAlignedObjectArrayeVSolver() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          BulletSoftBodyPINVOKE.delete_btAlignedObjectArrayeVSolver(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public btAlignedObjectArrayeVSolver() : this(BulletSoftBodyPINVOKE.new_btAlignedObjectArrayeVSolver__SWIG_0(), true) {
  }

  public btAlignedObjectArrayeVSolver(btAlignedObjectArrayeVSolver otherArray) : this(BulletSoftBodyPINVOKE.new_btAlignedObjectArrayeVSolver__SWIG_1(btAlignedObjectArrayeVSolver.getCPtr(otherArray)), true) {
    if (BulletSoftBodyPINVOKE.SWIGPendingException.Pending) throw BulletSoftBodyPINVOKE.SWIGPendingException.Retrieve();
  }

  public int size() {
    int ret = BulletSoftBodyPINVOKE.btAlignedObjectArrayeVSolver_size(swigCPtr);
    return ret;
  }

  public eVSolver._ at(int n) {
    eVSolver._ ret = (eVSolver._)BulletSoftBodyPINVOKE.btAlignedObjectArrayeVSolver_at__SWIG_0(swigCPtr, n);
    return ret;
  }

  public void clear() {
    BulletSoftBodyPINVOKE.btAlignedObjectArrayeVSolver_clear(swigCPtr);
  }

  public void pop_back() {
    BulletSoftBodyPINVOKE.btAlignedObjectArrayeVSolver_pop_back(swigCPtr);
  }

  public void resizeNoInitialize(int newsize) {
    BulletSoftBodyPINVOKE.btAlignedObjectArrayeVSolver_resizeNoInitialize(swigCPtr, newsize);
  }

  public void resize(int newsize, eVSolver._ fillData) {
    BulletSoftBodyPINVOKE.btAlignedObjectArrayeVSolver_resize__SWIG_0(swigCPtr, newsize, (int)fillData);
  }

  public void resize(int newsize) {
    BulletSoftBodyPINVOKE.btAlignedObjectArrayeVSolver_resize__SWIG_1(swigCPtr, newsize);
  }

  public SWIGTYPE_p_eVSolver___ expandNonInitializing() {
    SWIGTYPE_p_eVSolver___ ret = new SWIGTYPE_p_eVSolver___(BulletSoftBodyPINVOKE.btAlignedObjectArrayeVSolver_expandNonInitializing(swigCPtr), false);
    return ret;
  }

  public SWIGTYPE_p_eVSolver___ expand(eVSolver._ fillValue) {
    SWIGTYPE_p_eVSolver___ ret = new SWIGTYPE_p_eVSolver___(BulletSoftBodyPINVOKE.btAlignedObjectArrayeVSolver_expand__SWIG_0(swigCPtr, (int)fillValue), false);
    return ret;
  }

  public SWIGTYPE_p_eVSolver___ expand() {
    SWIGTYPE_p_eVSolver___ ret = new SWIGTYPE_p_eVSolver___(BulletSoftBodyPINVOKE.btAlignedObjectArrayeVSolver_expand__SWIG_1(swigCPtr), false);
    return ret;
  }

  public void push_back(eVSolver._ _Val) {
    BulletSoftBodyPINVOKE.btAlignedObjectArrayeVSolver_push_back(swigCPtr, (int)_Val);
  }

  public int capacity() {
    int ret = BulletSoftBodyPINVOKE.btAlignedObjectArrayeVSolver_capacity(swigCPtr);
    return ret;
  }

  public void reserve(int _Count) {
    BulletSoftBodyPINVOKE.btAlignedObjectArrayeVSolver_reserve(swigCPtr, _Count);
  }

  public void swap(int index0, int index1) {
    BulletSoftBodyPINVOKE.btAlignedObjectArrayeVSolver_swap(swigCPtr, index0, index1);
  }

  public int findBinarySearch(eVSolver._ key) {
    int ret = BulletSoftBodyPINVOKE.btAlignedObjectArrayeVSolver_findBinarySearch(swigCPtr, (int)key);
    return ret;
  }

  public int findLinearSearch(eVSolver._ key) {
    int ret = BulletSoftBodyPINVOKE.btAlignedObjectArrayeVSolver_findLinearSearch(swigCPtr, (int)key);
    return ret;
  }

  public void remove(eVSolver._ key) {
    BulletSoftBodyPINVOKE.btAlignedObjectArrayeVSolver_remove(swigCPtr, (int)key);
  }

  public void initializeFromBuffer(SWIGTYPE_p_void buffer, int size, int capacity) {
    BulletSoftBodyPINVOKE.btAlignedObjectArrayeVSolver_initializeFromBuffer(swigCPtr, SWIGTYPE_p_void.getCPtr(buffer), size, capacity);
  }

  public void copyFromArray(btAlignedObjectArrayeVSolver otherArray) {
    BulletSoftBodyPINVOKE.btAlignedObjectArrayeVSolver_copyFromArray(swigCPtr, btAlignedObjectArrayeVSolver.getCPtr(otherArray));
    if (BulletSoftBodyPINVOKE.SWIGPendingException.Pending) throw BulletSoftBodyPINVOKE.SWIGPendingException.Retrieve();
  }

}

}