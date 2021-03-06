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

public class int4 : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal int4(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(int4 obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~int4() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          LinearMathPINVOKE.delete_int4(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public int x {
    set {
      LinearMathPINVOKE.int4_x_set(swigCPtr, value);
    } 
    get {
      int ret = LinearMathPINVOKE.int4_x_get(swigCPtr);
      return ret;
    } 
  }

  public int y {
    set {
      LinearMathPINVOKE.int4_y_set(swigCPtr, value);
    } 
    get {
      int ret = LinearMathPINVOKE.int4_y_get(swigCPtr);
      return ret;
    } 
  }

  public int z {
    set {
      LinearMathPINVOKE.int4_z_set(swigCPtr, value);
    } 
    get {
      int ret = LinearMathPINVOKE.int4_z_get(swigCPtr);
      return ret;
    } 
  }

  public int w {
    set {
      LinearMathPINVOKE.int4_w_set(swigCPtr, value);
    } 
    get {
      int ret = LinearMathPINVOKE.int4_w_get(swigCPtr);
      return ret;
    } 
  }

  public int4() : this(LinearMathPINVOKE.new_int4__SWIG_0(), true) {
  }

  public int4(int _x, int _y, int _z, int _w) : this(LinearMathPINVOKE.new_int4__SWIG_1(_x, _y, _z, _w), true) {
  }

}

}
