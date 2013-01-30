/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.8
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class VectorArray : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal VectorArray(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(VectorArray obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~VectorArray() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          examplePINVOKE.delete_VectorArray(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public VectorArray(int maxsize) : this(examplePINVOKE.new_VectorArray(maxsize), true) {
  }

  public int size() {
    int ret = examplePINVOKE.VectorArray_size(swigCPtr);
    return ret;
  }

  public Vector get(int index) {
    Vector ret = new Vector(examplePINVOKE.VectorArray_get(swigCPtr, index), false);
    return ret;
  }

  public void set(int index, Vector a) {
    examplePINVOKE.VectorArray_set(swigCPtr, index, Vector.getCPtr(a));
    if (examplePINVOKE.SWIGPendingException.Pending) throw examplePINVOKE.SWIGPendingException.Retrieve();
  }

}
