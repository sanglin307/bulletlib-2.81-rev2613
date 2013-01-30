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

public class btAlignedObjectArrayNode : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal btAlignedObjectArrayNode(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(btAlignedObjectArrayNode obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~btAlignedObjectArrayNode() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          BulletSoftBodyPINVOKE.delete_btAlignedObjectArrayNode(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public btAlignedObjectArrayNode() : this(BulletSoftBodyPINVOKE.new_btAlignedObjectArrayNode__SWIG_0(), true) {
  }

  public btAlignedObjectArrayNode(btAlignedObjectArrayNode otherArray) : this(BulletSoftBodyPINVOKE.new_btAlignedObjectArrayNode__SWIG_1(btAlignedObjectArrayNode.getCPtr(otherArray)), true) {
    if (BulletSoftBodyPINVOKE.SWIGPendingException.Pending) throw BulletSoftBodyPINVOKE.SWIGPendingException.Retrieve();
  }

  public int size() {
    int ret = BulletSoftBodyPINVOKE.btAlignedObjectArrayNode_size(swigCPtr);
    return ret;
  }

  public Node at(int n) {
    Node ret = new Node(BulletSoftBodyPINVOKE.btAlignedObjectArrayNode_at__SWIG_0(swigCPtr, n), false);
    return ret;
  }

  public void clear() {
    BulletSoftBodyPINVOKE.btAlignedObjectArrayNode_clear(swigCPtr);
  }

  public void pop_back() {
    BulletSoftBodyPINVOKE.btAlignedObjectArrayNode_pop_back(swigCPtr);
  }

  public void resizeNoInitialize(int newsize) {
    BulletSoftBodyPINVOKE.btAlignedObjectArrayNode_resizeNoInitialize(swigCPtr, newsize);
  }

  public void resize(int newsize, Node fillData) {
    BulletSoftBodyPINVOKE.btAlignedObjectArrayNode_resize__SWIG_0(swigCPtr, newsize, Node.getCPtr(fillData));
    if (BulletSoftBodyPINVOKE.SWIGPendingException.Pending) throw BulletSoftBodyPINVOKE.SWIGPendingException.Retrieve();
  }

  public void resize(int newsize) {
    BulletSoftBodyPINVOKE.btAlignedObjectArrayNode_resize__SWIG_1(swigCPtr, newsize);
  }

  public Node expandNonInitializing() {
    Node ret = new Node(BulletSoftBodyPINVOKE.btAlignedObjectArrayNode_expandNonInitializing(swigCPtr), false);
    return ret;
  }

  public Node expand(Node fillValue) {
    Node ret = new Node(BulletSoftBodyPINVOKE.btAlignedObjectArrayNode_expand__SWIG_0(swigCPtr, Node.getCPtr(fillValue)), false);
    if (BulletSoftBodyPINVOKE.SWIGPendingException.Pending) throw BulletSoftBodyPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Node expand() {
    Node ret = new Node(BulletSoftBodyPINVOKE.btAlignedObjectArrayNode_expand__SWIG_1(swigCPtr), false);
    return ret;
  }

  public void push_back(Node _Val) {
    BulletSoftBodyPINVOKE.btAlignedObjectArrayNode_push_back(swigCPtr, Node.getCPtr(_Val));
    if (BulletSoftBodyPINVOKE.SWIGPendingException.Pending) throw BulletSoftBodyPINVOKE.SWIGPendingException.Retrieve();
  }

  public int capacity() {
    int ret = BulletSoftBodyPINVOKE.btAlignedObjectArrayNode_capacity(swigCPtr);
    return ret;
  }

  public void reserve(int _Count) {
    BulletSoftBodyPINVOKE.btAlignedObjectArrayNode_reserve(swigCPtr, _Count);
  }

  public void swap(int index0, int index1) {
    BulletSoftBodyPINVOKE.btAlignedObjectArrayNode_swap(swigCPtr, index0, index1);
  }

  public int findBinarySearch(Node key) {
    int ret = BulletSoftBodyPINVOKE.btAlignedObjectArrayNode_findBinarySearch(swigCPtr, Node.getCPtr(key));
    if (BulletSoftBodyPINVOKE.SWIGPendingException.Pending) throw BulletSoftBodyPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int findLinearSearch(Node key) {
    int ret = BulletSoftBodyPINVOKE.btAlignedObjectArrayNode_findLinearSearch(swigCPtr, Node.getCPtr(key));
    if (BulletSoftBodyPINVOKE.SWIGPendingException.Pending) throw BulletSoftBodyPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void remove(Node key) {
    BulletSoftBodyPINVOKE.btAlignedObjectArrayNode_remove(swigCPtr, Node.getCPtr(key));
    if (BulletSoftBodyPINVOKE.SWIGPendingException.Pending) throw BulletSoftBodyPINVOKE.SWIGPendingException.Retrieve();
  }

  public void initializeFromBuffer(SWIGTYPE_p_void buffer, int size, int capacity) {
    BulletSoftBodyPINVOKE.btAlignedObjectArrayNode_initializeFromBuffer(swigCPtr, SWIGTYPE_p_void.getCPtr(buffer), size, capacity);
  }

  public void copyFromArray(btAlignedObjectArrayNode otherArray) {
    BulletSoftBodyPINVOKE.btAlignedObjectArrayNode_copyFromArray(swigCPtr, btAlignedObjectArrayNode.getCPtr(otherArray));
    if (BulletSoftBodyPINVOKE.SWIGPendingException.Pending) throw BulletSoftBodyPINVOKE.SWIGPendingException.Retrieve();
  }

}

}
