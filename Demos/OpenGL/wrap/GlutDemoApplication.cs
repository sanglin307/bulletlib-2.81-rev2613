/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.8
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class GlutDemoApplication : DemoApplication {
  private HandleRef swigCPtr;

  internal GlutDemoApplication(IntPtr cPtr, bool cMemoryOwn) : base(OpenGLSupportPINVOKE.GlutDemoApplication_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(GlutDemoApplication obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~GlutDemoApplication() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          OpenGLSupportPINVOKE.delete_GlutDemoApplication(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public override void specialKeyboard(int key, int x, int y) {
    OpenGLSupportPINVOKE.GlutDemoApplication_specialKeyboard(swigCPtr, key, x, y);
  }

  public override void swapBuffers() {
    OpenGLSupportPINVOKE.GlutDemoApplication_swapBuffers(swigCPtr);
  }

  public override void updateModifierKeys() {
    OpenGLSupportPINVOKE.GlutDemoApplication_updateModifierKeys(swigCPtr);
  }

}
