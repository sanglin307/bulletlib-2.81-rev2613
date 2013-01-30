/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.8
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class GL_DialogDynamicsWorld : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal GL_DialogDynamicsWorld(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(GL_DialogDynamicsWorld obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~GL_DialogDynamicsWorld() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          OpenGLSupportPINVOKE.delete_GL_DialogDynamicsWorld(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public GL_DialogDynamicsWorld() : this(OpenGLSupportPINVOKE.new_GL_DialogDynamicsWorld(), true) {
  }

  public virtual void setScreenSize(int width, int height) {
    OpenGLSupportPINVOKE.GL_DialogDynamicsWorld_setScreenSize(swigCPtr, width, height);
  }

  public virtual GL_DialogWindow createDialog(int horPos, int vertPos, int dialogWidth, int dialogHeight, string dialogTitle) {
    IntPtr cPtr = OpenGLSupportPINVOKE.GL_DialogDynamicsWorld_createDialog(swigCPtr, horPos, vertPos, dialogWidth, dialogHeight, dialogTitle);
    GL_DialogWindow ret = (cPtr == IntPtr.Zero) ? null : new GL_DialogWindow(cPtr, false);
    return ret;
  }

  public GL_ToggleControl createToggle(GL_DialogWindow dialog, string toggleText) {
    IntPtr cPtr = OpenGLSupportPINVOKE.GL_DialogDynamicsWorld_createToggle(swigCPtr, GL_DialogWindow.getCPtr(dialog), toggleText);
    GL_ToggleControl ret = (cPtr == IntPtr.Zero) ? null : new GL_ToggleControl(cPtr, false);
    return ret;
  }

  public GL_SliderControl createSlider(GL_DialogWindow dialog, string sliderText, float initialFraction) {
    IntPtr cPtr = OpenGLSupportPINVOKE.GL_DialogDynamicsWorld_createSlider__SWIG_0(swigCPtr, GL_DialogWindow.getCPtr(dialog), sliderText, initialFraction);
    GL_SliderControl ret = (cPtr == IntPtr.Zero) ? null : new GL_SliderControl(cPtr, false);
    return ret;
  }

  public GL_SliderControl createSlider(GL_DialogWindow dialog, string sliderText) {
    IntPtr cPtr = OpenGLSupportPINVOKE.GL_DialogDynamicsWorld_createSlider__SWIG_1(swigCPtr, GL_DialogWindow.getCPtr(dialog), sliderText);
    GL_SliderControl ret = (cPtr == IntPtr.Zero) ? null : new GL_SliderControl(cPtr, false);
    return ret;
  }

  public virtual void draw(float timeStep) {
    OpenGLSupportPINVOKE.GL_DialogDynamicsWorld_draw(swigCPtr, timeStep);
  }

  public virtual bool mouseFunc(int button, int state, int x, int y) {
    bool ret = OpenGLSupportPINVOKE.GL_DialogDynamicsWorld_mouseFunc(swigCPtr, button, state, x, y);
    return ret;
  }

  public virtual void mouseMotionFunc(int x, int y) {
    OpenGLSupportPINVOKE.GL_DialogDynamicsWorld_mouseMotionFunc(swigCPtr, x, y);
  }

}
