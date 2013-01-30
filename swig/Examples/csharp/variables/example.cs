/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.8
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class example {
  public static int ivar {
    set {
      examplePINVOKE.ivar_set(value);
    } 
    get {
      int ret = examplePINVOKE.ivar_get();
      return ret;
    } 
  }

  public static short svar {
    set {
      examplePINVOKE.svar_set(value);
    } 
    get {
      short ret = examplePINVOKE.svar_get();
      return ret;
    } 
  }

  public static int lvar {
    set {
      examplePINVOKE.lvar_set(value);
    } 
    get {
      int ret = examplePINVOKE.lvar_get();
      return ret;
    } 
  }

  public static uint uivar {
    set {
      examplePINVOKE.uivar_set(value);
    } 
    get {
      uint ret = examplePINVOKE.uivar_get();
      return ret;
    } 
  }

  public static ushort usvar {
    set {
      examplePINVOKE.usvar_set(value);
    } 
    get {
      ushort ret = examplePINVOKE.usvar_get();
      return ret;
    } 
  }

  public static uint ulvar {
    set {
      examplePINVOKE.ulvar_set(value);
    } 
    get {
      uint ret = examplePINVOKE.ulvar_get();
      return ret;
    } 
  }

  public static sbyte scvar {
    set {
      examplePINVOKE.scvar_set(value);
    } 
    get {
      sbyte ret = examplePINVOKE.scvar_get();
      return ret;
    } 
  }

  public static byte ucvar {
    set {
      examplePINVOKE.ucvar_set(value);
    } 
    get {
      byte ret = examplePINVOKE.ucvar_get();
      return ret;
    } 
  }

  public static char cvar {
    set {
      examplePINVOKE.cvar_set(value);
    } 
    get {
      char ret = examplePINVOKE.cvar_get();
      return ret;
    } 
  }

  public static float fvar {
    set {
      examplePINVOKE.fvar_set(value);
    } 
    get {
      float ret = examplePINVOKE.fvar_get();
      return ret;
    } 
  }

  public static double dvar {
    set {
      examplePINVOKE.dvar_set(value);
    } 
    get {
      double ret = examplePINVOKE.dvar_get();
      return ret;
    } 
  }

  public static string strvar {
    set {
      examplePINVOKE.strvar_set(value);
    } 
    get {
      string ret = examplePINVOKE.strvar_get();
      return ret;
    } 
  }

  public static string cstrvar {
    get {
      string ret = examplePINVOKE.cstrvar_get();
      return ret;
    } 
  }

  public static SWIGTYPE_p_int iptrvar {
    set {
      examplePINVOKE.iptrvar_set(SWIGTYPE_p_int.getCPtr(value));
    } 
    get {
      IntPtr cPtr = examplePINVOKE.iptrvar_get();
      SWIGTYPE_p_int ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_int(cPtr, false);
      return ret;
    } 
  }

  public static string name {
    set {
      examplePINVOKE.name_set(value);
    } 
    get {
      string ret = examplePINVOKE.name_get();
      return ret;
    } 
  }

  public static SWIGTYPE_p_Point ptptr {
    set {
      examplePINVOKE.ptptr_set(SWIGTYPE_p_Point.getCPtr(value));
    } 
    get {
      IntPtr cPtr = examplePINVOKE.ptptr_get();
      SWIGTYPE_p_Point ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_Point(cPtr, false);
      return ret;
    } 
  }

  public static SWIGTYPE_p_Point pt {
    set {
      examplePINVOKE.pt_set(SWIGTYPE_p_Point.getCPtr(value));
      if (examplePINVOKE.SWIGPendingException.Pending) throw examplePINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_Point ret = new SWIGTYPE_p_Point(examplePINVOKE.pt_get(), true);
      if (examplePINVOKE.SWIGPendingException.Pending) throw examplePINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public static int status {
    get {
      int ret = examplePINVOKE.status_get();
      return ret;
    } 
  }

  public static string path {
    get {
      string ret = examplePINVOKE.path_get();
      return ret;
    } 
  }

  public static void print_vars() {
    examplePINVOKE.print_vars();
  }

  public static SWIGTYPE_p_int new_int(int value) {
    IntPtr cPtr = examplePINVOKE.new_int(value);
    SWIGTYPE_p_int ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_int(cPtr, false);
    return ret;
  }

  public static SWIGTYPE_p_Point new_Point(int x, int y) {
    IntPtr cPtr = examplePINVOKE.new_Point(x, y);
    SWIGTYPE_p_Point ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_Point(cPtr, false);
    return ret;
  }

  public static string Point_print(SWIGTYPE_p_Point p) {
    string ret = examplePINVOKE.Point_print(SWIGTYPE_p_Point.getCPtr(p));
    return ret;
  }

  public static void pt_print() {
    examplePINVOKE.pt_print();
  }

}
