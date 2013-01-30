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

public class btPolarDecomposition : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal btPolarDecomposition(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(btPolarDecomposition obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~btPolarDecomposition() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          LinearMathPINVOKE.delete_btPolarDecomposition(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public static float DEFAULT_TOLERANCE {
    get {
      float ret = LinearMathPINVOKE.btPolarDecomposition_DEFAULT_TOLERANCE_get();
      return ret;
    } 
  }

  public static uint DEFAULT_MAX_ITERATIONS {
    get {
      uint ret = LinearMathPINVOKE.btPolarDecomposition_DEFAULT_MAX_ITERATIONS_get();
      return ret;
    } 
  }

  public btPolarDecomposition(float tolerance, uint maxIterations) : this(LinearMathPINVOKE.new_btPolarDecomposition__SWIG_0(tolerance, maxIterations), true) {
  }

  public btPolarDecomposition(float tolerance) : this(LinearMathPINVOKE.new_btPolarDecomposition__SWIG_1(tolerance), true) {
  }

  public btPolarDecomposition() : this(LinearMathPINVOKE.new_btPolarDecomposition__SWIG_2(), true) {
  }

  public uint decompose(btMatrix3x3 a, btMatrix3x3 u, btMatrix3x3 h) {
    uint ret = LinearMathPINVOKE.btPolarDecomposition_decompose(swigCPtr, btMatrix3x3.getCPtr(a), btMatrix3x3.getCPtr(u), btMatrix3x3.getCPtr(h));
    if (LinearMathPINVOKE.SWIGPendingException.Pending) throw LinearMathPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public uint maxIterations() {
    uint ret = LinearMathPINVOKE.btPolarDecomposition_maxIterations(swigCPtr);
    return ret;
  }

}

}