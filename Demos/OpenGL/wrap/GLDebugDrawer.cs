/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.8
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class GLDebugDrawer : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal GLDebugDrawer(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(GLDebugDrawer obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~GLDebugDrawer() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          OpenGLSupportPINVOKE.delete_GLDebugDrawer(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public GLDebugDrawer() : this(OpenGLSupportPINVOKE.new_GLDebugDrawer(), true) {
  }

  public virtual void drawLine(SWIGTYPE_p_btVector3 from, SWIGTYPE_p_btVector3 to, SWIGTYPE_p_btVector3 fromColor, SWIGTYPE_p_btVector3 toColor) {
    OpenGLSupportPINVOKE.GLDebugDrawer_drawLine__SWIG_0(swigCPtr, SWIGTYPE_p_btVector3.getCPtr(from), SWIGTYPE_p_btVector3.getCPtr(to), SWIGTYPE_p_btVector3.getCPtr(fromColor), SWIGTYPE_p_btVector3.getCPtr(toColor));
    if (OpenGLSupportPINVOKE.SWIGPendingException.Pending) throw OpenGLSupportPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void drawLine(SWIGTYPE_p_btVector3 from, SWIGTYPE_p_btVector3 to, SWIGTYPE_p_btVector3 color) {
    OpenGLSupportPINVOKE.GLDebugDrawer_drawLine__SWIG_1(swigCPtr, SWIGTYPE_p_btVector3.getCPtr(from), SWIGTYPE_p_btVector3.getCPtr(to), SWIGTYPE_p_btVector3.getCPtr(color));
    if (OpenGLSupportPINVOKE.SWIGPendingException.Pending) throw OpenGLSupportPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void drawSphere(SWIGTYPE_p_btVector3 p, float radius, SWIGTYPE_p_btVector3 color) {
    OpenGLSupportPINVOKE.GLDebugDrawer_drawSphere(swigCPtr, SWIGTYPE_p_btVector3.getCPtr(p), radius, SWIGTYPE_p_btVector3.getCPtr(color));
    if (OpenGLSupportPINVOKE.SWIGPendingException.Pending) throw OpenGLSupportPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void drawTriangle(SWIGTYPE_p_btVector3 a, SWIGTYPE_p_btVector3 b, SWIGTYPE_p_btVector3 c, SWIGTYPE_p_btVector3 color, float alpha) {
    OpenGLSupportPINVOKE.GLDebugDrawer_drawTriangle(swigCPtr, SWIGTYPE_p_btVector3.getCPtr(a), SWIGTYPE_p_btVector3.getCPtr(b), SWIGTYPE_p_btVector3.getCPtr(c), SWIGTYPE_p_btVector3.getCPtr(color), alpha);
    if (OpenGLSupportPINVOKE.SWIGPendingException.Pending) throw OpenGLSupportPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void drawContactPoint(SWIGTYPE_p_btVector3 PointOnB, SWIGTYPE_p_btVector3 normalOnB, float distance, int lifeTime, SWIGTYPE_p_btVector3 color) {
    OpenGLSupportPINVOKE.GLDebugDrawer_drawContactPoint(swigCPtr, SWIGTYPE_p_btVector3.getCPtr(PointOnB), SWIGTYPE_p_btVector3.getCPtr(normalOnB), distance, lifeTime, SWIGTYPE_p_btVector3.getCPtr(color));
    if (OpenGLSupportPINVOKE.SWIGPendingException.Pending) throw OpenGLSupportPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void reportErrorWarning(string warningString) {
    OpenGLSupportPINVOKE.GLDebugDrawer_reportErrorWarning(swigCPtr, warningString);
  }

  public virtual void draw3dText(SWIGTYPE_p_btVector3 location, string textString) {
    OpenGLSupportPINVOKE.GLDebugDrawer_draw3dText(swigCPtr, SWIGTYPE_p_btVector3.getCPtr(location), textString);
    if (OpenGLSupportPINVOKE.SWIGPendingException.Pending) throw OpenGLSupportPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void setDebugMode(int debugMode) {
    OpenGLSupportPINVOKE.GLDebugDrawer_setDebugMode(swigCPtr, debugMode);
  }

  public virtual int getDebugMode() {
    int ret = OpenGLSupportPINVOKE.GLDebugDrawer_getDebugMode(swigCPtr);
    return ret;
  }

}
