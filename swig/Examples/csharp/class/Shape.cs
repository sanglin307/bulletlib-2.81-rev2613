/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.8
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class Shape : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal Shape(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(Shape obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~Shape() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          examplePINVOKE.delete_Shape(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public double x {
    set {
      examplePINVOKE.Shape_x_set(swigCPtr, value);
    } 
    get {
      double ret = examplePINVOKE.Shape_x_get(swigCPtr);
      return ret;
    } 
  }

  public double y {
    set {
      examplePINVOKE.Shape_y_set(swigCPtr, value);
    } 
    get {
      double ret = examplePINVOKE.Shape_y_get(swigCPtr);
      return ret;
    } 
  }

  public void move(double dx, double dy) {
    examplePINVOKE.Shape_move(swigCPtr, dx, dy);
  }

  public virtual double area() {
    double ret = examplePINVOKE.Shape_area(swigCPtr);
    return ret;
  }

  public virtual double perimeter() {
    double ret = examplePINVOKE.Shape_perimeter(swigCPtr);
    return ret;
  }

  public static int nshapes {
    set {
      examplePINVOKE.Shape_nshapes_set(value);
    } 
    get {
      int ret = examplePINVOKE.Shape_nshapes_get();
      return ret;
    } 
  }

}
