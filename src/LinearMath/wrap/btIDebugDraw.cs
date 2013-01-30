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

public class btIDebugDraw : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal btIDebugDraw(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(btIDebugDraw obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~btIDebugDraw() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          LinearMathPINVOKE.delete_btIDebugDraw(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public virtual void drawLine(btVector3 from, btVector3 to, btVector3 color) {
    if (SwigDerivedClassHasMethod("drawLine", swigMethodTypes0)) LinearMathPINVOKE.btIDebugDraw_drawLineSwigExplicitbtIDebugDraw__SWIG_0(swigCPtr, btVector3.getCPtr(from), btVector3.getCPtr(to), btVector3.getCPtr(color)); else LinearMathPINVOKE.btIDebugDraw_drawLine__SWIG_0(swigCPtr, btVector3.getCPtr(from), btVector3.getCPtr(to), btVector3.getCPtr(color));
    if (LinearMathPINVOKE.SWIGPendingException.Pending) throw LinearMathPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void drawLine(btVector3 from, btVector3 to, btVector3 fromColor, btVector3 toColor) {
    if (SwigDerivedClassHasMethod("drawLine", swigMethodTypes1)) LinearMathPINVOKE.btIDebugDraw_drawLineSwigExplicitbtIDebugDraw__SWIG_1(swigCPtr, btVector3.getCPtr(from), btVector3.getCPtr(to), btVector3.getCPtr(fromColor), btVector3.getCPtr(toColor)); else LinearMathPINVOKE.btIDebugDraw_drawLine__SWIG_1(swigCPtr, btVector3.getCPtr(from), btVector3.getCPtr(to), btVector3.getCPtr(fromColor), btVector3.getCPtr(toColor));
    if (LinearMathPINVOKE.SWIGPendingException.Pending) throw LinearMathPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void drawSphere(float radius, btTransform transform, btVector3 color) {
    if (SwigDerivedClassHasMethod("drawSphere", swigMethodTypes2)) LinearMathPINVOKE.btIDebugDraw_drawSphereSwigExplicitbtIDebugDraw__SWIG_0(swigCPtr, radius, btTransform.getCPtr(transform), btVector3.getCPtr(color)); else LinearMathPINVOKE.btIDebugDraw_drawSphere__SWIG_0(swigCPtr, radius, btTransform.getCPtr(transform), btVector3.getCPtr(color));
    if (LinearMathPINVOKE.SWIGPendingException.Pending) throw LinearMathPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void drawSphere(btVector3 p, float radius, btVector3 color) {
    if (SwigDerivedClassHasMethod("drawSphere", swigMethodTypes3)) LinearMathPINVOKE.btIDebugDraw_drawSphereSwigExplicitbtIDebugDraw__SWIG_1(swigCPtr, btVector3.getCPtr(p), radius, btVector3.getCPtr(color)); else LinearMathPINVOKE.btIDebugDraw_drawSphere__SWIG_1(swigCPtr, btVector3.getCPtr(p), radius, btVector3.getCPtr(color));
    if (LinearMathPINVOKE.SWIGPendingException.Pending) throw LinearMathPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void drawTriangle(btVector3 v0, btVector3 v1, btVector3 v2, btVector3 arg3, btVector3 arg4, btVector3 arg5, btVector3 color, float alpha) {
    if (SwigDerivedClassHasMethod("drawTriangle", swigMethodTypes4)) LinearMathPINVOKE.btIDebugDraw_drawTriangleSwigExplicitbtIDebugDraw__SWIG_0(swigCPtr, btVector3.getCPtr(v0), btVector3.getCPtr(v1), btVector3.getCPtr(v2), btVector3.getCPtr(arg3), btVector3.getCPtr(arg4), btVector3.getCPtr(arg5), btVector3.getCPtr(color), alpha); else LinearMathPINVOKE.btIDebugDraw_drawTriangle__SWIG_0(swigCPtr, btVector3.getCPtr(v0), btVector3.getCPtr(v1), btVector3.getCPtr(v2), btVector3.getCPtr(arg3), btVector3.getCPtr(arg4), btVector3.getCPtr(arg5), btVector3.getCPtr(color), alpha);
    if (LinearMathPINVOKE.SWIGPendingException.Pending) throw LinearMathPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void drawTriangle(btVector3 v0, btVector3 v1, btVector3 v2, btVector3 color, float arg4) {
    if (SwigDerivedClassHasMethod("drawTriangle", swigMethodTypes5)) LinearMathPINVOKE.btIDebugDraw_drawTriangleSwigExplicitbtIDebugDraw__SWIG_1(swigCPtr, btVector3.getCPtr(v0), btVector3.getCPtr(v1), btVector3.getCPtr(v2), btVector3.getCPtr(color), arg4); else LinearMathPINVOKE.btIDebugDraw_drawTriangle__SWIG_1(swigCPtr, btVector3.getCPtr(v0), btVector3.getCPtr(v1), btVector3.getCPtr(v2), btVector3.getCPtr(color), arg4);
    if (LinearMathPINVOKE.SWIGPendingException.Pending) throw LinearMathPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void drawContactPoint(btVector3 PointOnB, btVector3 normalOnB, float distance, int lifeTime, btVector3 color) {
    if (SwigDerivedClassHasMethod("drawContactPoint", swigMethodTypes6)) LinearMathPINVOKE.btIDebugDraw_drawContactPointSwigExplicitbtIDebugDraw(swigCPtr, btVector3.getCPtr(PointOnB), btVector3.getCPtr(normalOnB), distance, lifeTime, btVector3.getCPtr(color)); else LinearMathPINVOKE.btIDebugDraw_drawContactPoint(swigCPtr, btVector3.getCPtr(PointOnB), btVector3.getCPtr(normalOnB), distance, lifeTime, btVector3.getCPtr(color));
    if (LinearMathPINVOKE.SWIGPendingException.Pending) throw LinearMathPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void reportErrorWarning(string warningString) {
    if (SwigDerivedClassHasMethod("reportErrorWarning", swigMethodTypes7)) LinearMathPINVOKE.btIDebugDraw_reportErrorWarningSwigExplicitbtIDebugDraw(swigCPtr, warningString); else LinearMathPINVOKE.btIDebugDraw_reportErrorWarning(swigCPtr, warningString);
  }

  public virtual void draw3dText(btVector3 location, string textString) {
    if (SwigDerivedClassHasMethod("draw3dText", swigMethodTypes8)) LinearMathPINVOKE.btIDebugDraw_draw3dTextSwigExplicitbtIDebugDraw(swigCPtr, btVector3.getCPtr(location), textString); else LinearMathPINVOKE.btIDebugDraw_draw3dText(swigCPtr, btVector3.getCPtr(location), textString);
    if (LinearMathPINVOKE.SWIGPendingException.Pending) throw LinearMathPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void setDebugMode(int debugMode) {
    if (SwigDerivedClassHasMethod("setDebugMode", swigMethodTypes9)) LinearMathPINVOKE.btIDebugDraw_setDebugModeSwigExplicitbtIDebugDraw(swigCPtr, debugMode); else LinearMathPINVOKE.btIDebugDraw_setDebugMode(swigCPtr, debugMode);
  }

  public virtual int getDebugMode() {
    int ret = (SwigDerivedClassHasMethod("getDebugMode", swigMethodTypes10) ? LinearMathPINVOKE.btIDebugDraw_getDebugModeSwigExplicitbtIDebugDraw(swigCPtr) : LinearMathPINVOKE.btIDebugDraw_getDebugMode(swigCPtr));
    return ret;
  }

  public virtual void drawAabb(btVector3 from, btVector3 to, btVector3 color) {
    if (SwigDerivedClassHasMethod("drawAabb", swigMethodTypes11)) LinearMathPINVOKE.btIDebugDraw_drawAabbSwigExplicitbtIDebugDraw(swigCPtr, btVector3.getCPtr(from), btVector3.getCPtr(to), btVector3.getCPtr(color)); else LinearMathPINVOKE.btIDebugDraw_drawAabb(swigCPtr, btVector3.getCPtr(from), btVector3.getCPtr(to), btVector3.getCPtr(color));
    if (LinearMathPINVOKE.SWIGPendingException.Pending) throw LinearMathPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void drawTransform(btTransform transform, float orthoLen) {
    if (SwigDerivedClassHasMethod("drawTransform", swigMethodTypes12)) LinearMathPINVOKE.btIDebugDraw_drawTransformSwigExplicitbtIDebugDraw(swigCPtr, btTransform.getCPtr(transform), orthoLen); else LinearMathPINVOKE.btIDebugDraw_drawTransform(swigCPtr, btTransform.getCPtr(transform), orthoLen);
    if (LinearMathPINVOKE.SWIGPendingException.Pending) throw LinearMathPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void drawArc(btVector3 center, btVector3 normal, btVector3 axis, float radiusA, float radiusB, float minAngle, float maxAngle, btVector3 color, bool drawSect, float stepDegrees) {
    if (SwigDerivedClassHasMethod("drawArc", swigMethodTypes13)) LinearMathPINVOKE.btIDebugDraw_drawArcSwigExplicitbtIDebugDraw__SWIG_0(swigCPtr, btVector3.getCPtr(center), btVector3.getCPtr(normal), btVector3.getCPtr(axis), radiusA, radiusB, minAngle, maxAngle, btVector3.getCPtr(color), drawSect, stepDegrees); else LinearMathPINVOKE.btIDebugDraw_drawArc__SWIG_0(swigCPtr, btVector3.getCPtr(center), btVector3.getCPtr(normal), btVector3.getCPtr(axis), radiusA, radiusB, minAngle, maxAngle, btVector3.getCPtr(color), drawSect, stepDegrees);
    if (LinearMathPINVOKE.SWIGPendingException.Pending) throw LinearMathPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void drawArc(btVector3 center, btVector3 normal, btVector3 axis, float radiusA, float radiusB, float minAngle, float maxAngle, btVector3 color, bool drawSect) {
    if (SwigDerivedClassHasMethod("drawArc", swigMethodTypes14)) LinearMathPINVOKE.btIDebugDraw_drawArcSwigExplicitbtIDebugDraw__SWIG_1(swigCPtr, btVector3.getCPtr(center), btVector3.getCPtr(normal), btVector3.getCPtr(axis), radiusA, radiusB, minAngle, maxAngle, btVector3.getCPtr(color), drawSect); else LinearMathPINVOKE.btIDebugDraw_drawArc__SWIG_1(swigCPtr, btVector3.getCPtr(center), btVector3.getCPtr(normal), btVector3.getCPtr(axis), radiusA, radiusB, minAngle, maxAngle, btVector3.getCPtr(color), drawSect);
    if (LinearMathPINVOKE.SWIGPendingException.Pending) throw LinearMathPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void drawSpherePatch(btVector3 center, btVector3 up, btVector3 axis, float radius, float minTh, float maxTh, float minPs, float maxPs, btVector3 color, float stepDegrees) {
    if (SwigDerivedClassHasMethod("drawSpherePatch", swigMethodTypes15)) LinearMathPINVOKE.btIDebugDraw_drawSpherePatchSwigExplicitbtIDebugDraw__SWIG_0(swigCPtr, btVector3.getCPtr(center), btVector3.getCPtr(up), btVector3.getCPtr(axis), radius, minTh, maxTh, minPs, maxPs, btVector3.getCPtr(color), stepDegrees); else LinearMathPINVOKE.btIDebugDraw_drawSpherePatch__SWIG_0(swigCPtr, btVector3.getCPtr(center), btVector3.getCPtr(up), btVector3.getCPtr(axis), radius, minTh, maxTh, minPs, maxPs, btVector3.getCPtr(color), stepDegrees);
    if (LinearMathPINVOKE.SWIGPendingException.Pending) throw LinearMathPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void drawSpherePatch(btVector3 center, btVector3 up, btVector3 axis, float radius, float minTh, float maxTh, float minPs, float maxPs, btVector3 color) {
    if (SwigDerivedClassHasMethod("drawSpherePatch", swigMethodTypes16)) LinearMathPINVOKE.btIDebugDraw_drawSpherePatchSwigExplicitbtIDebugDraw__SWIG_1(swigCPtr, btVector3.getCPtr(center), btVector3.getCPtr(up), btVector3.getCPtr(axis), radius, minTh, maxTh, minPs, maxPs, btVector3.getCPtr(color)); else LinearMathPINVOKE.btIDebugDraw_drawSpherePatch__SWIG_1(swigCPtr, btVector3.getCPtr(center), btVector3.getCPtr(up), btVector3.getCPtr(axis), radius, minTh, maxTh, minPs, maxPs, btVector3.getCPtr(color));
    if (LinearMathPINVOKE.SWIGPendingException.Pending) throw LinearMathPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void drawBox(btVector3 bbMin, btVector3 bbMax, btVector3 color) {
    if (SwigDerivedClassHasMethod("drawBox", swigMethodTypes17)) LinearMathPINVOKE.btIDebugDraw_drawBoxSwigExplicitbtIDebugDraw__SWIG_0(swigCPtr, btVector3.getCPtr(bbMin), btVector3.getCPtr(bbMax), btVector3.getCPtr(color)); else LinearMathPINVOKE.btIDebugDraw_drawBox__SWIG_0(swigCPtr, btVector3.getCPtr(bbMin), btVector3.getCPtr(bbMax), btVector3.getCPtr(color));
    if (LinearMathPINVOKE.SWIGPendingException.Pending) throw LinearMathPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void drawBox(btVector3 bbMin, btVector3 bbMax, btTransform trans, btVector3 color) {
    if (SwigDerivedClassHasMethod("drawBox", swigMethodTypes18)) LinearMathPINVOKE.btIDebugDraw_drawBoxSwigExplicitbtIDebugDraw__SWIG_1(swigCPtr, btVector3.getCPtr(bbMin), btVector3.getCPtr(bbMax), btTransform.getCPtr(trans), btVector3.getCPtr(color)); else LinearMathPINVOKE.btIDebugDraw_drawBox__SWIG_1(swigCPtr, btVector3.getCPtr(bbMin), btVector3.getCPtr(bbMax), btTransform.getCPtr(trans), btVector3.getCPtr(color));
    if (LinearMathPINVOKE.SWIGPendingException.Pending) throw LinearMathPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void drawCapsule(float radius, float halfHeight, int upAxis, btTransform transform, btVector3 color) {
    if (SwigDerivedClassHasMethod("drawCapsule", swigMethodTypes19)) LinearMathPINVOKE.btIDebugDraw_drawCapsuleSwigExplicitbtIDebugDraw(swigCPtr, radius, halfHeight, upAxis, btTransform.getCPtr(transform), btVector3.getCPtr(color)); else LinearMathPINVOKE.btIDebugDraw_drawCapsule(swigCPtr, radius, halfHeight, upAxis, btTransform.getCPtr(transform), btVector3.getCPtr(color));
    if (LinearMathPINVOKE.SWIGPendingException.Pending) throw LinearMathPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void drawCylinder(float radius, float halfHeight, int upAxis, btTransform transform, btVector3 color) {
    if (SwigDerivedClassHasMethod("drawCylinder", swigMethodTypes20)) LinearMathPINVOKE.btIDebugDraw_drawCylinderSwigExplicitbtIDebugDraw(swigCPtr, radius, halfHeight, upAxis, btTransform.getCPtr(transform), btVector3.getCPtr(color)); else LinearMathPINVOKE.btIDebugDraw_drawCylinder(swigCPtr, radius, halfHeight, upAxis, btTransform.getCPtr(transform), btVector3.getCPtr(color));
    if (LinearMathPINVOKE.SWIGPendingException.Pending) throw LinearMathPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void drawCone(float radius, float height, int upAxis, btTransform transform, btVector3 color) {
    if (SwigDerivedClassHasMethod("drawCone", swigMethodTypes21)) LinearMathPINVOKE.btIDebugDraw_drawConeSwigExplicitbtIDebugDraw(swigCPtr, radius, height, upAxis, btTransform.getCPtr(transform), btVector3.getCPtr(color)); else LinearMathPINVOKE.btIDebugDraw_drawCone(swigCPtr, radius, height, upAxis, btTransform.getCPtr(transform), btVector3.getCPtr(color));
    if (LinearMathPINVOKE.SWIGPendingException.Pending) throw LinearMathPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void drawPlane(btVector3 planeNormal, float planeConst, btTransform transform, btVector3 color) {
    if (SwigDerivedClassHasMethod("drawPlane", swigMethodTypes22)) LinearMathPINVOKE.btIDebugDraw_drawPlaneSwigExplicitbtIDebugDraw(swigCPtr, btVector3.getCPtr(planeNormal), planeConst, btTransform.getCPtr(transform), btVector3.getCPtr(color)); else LinearMathPINVOKE.btIDebugDraw_drawPlane(swigCPtr, btVector3.getCPtr(planeNormal), planeConst, btTransform.getCPtr(transform), btVector3.getCPtr(color));
    if (LinearMathPINVOKE.SWIGPendingException.Pending) throw LinearMathPINVOKE.SWIGPendingException.Retrieve();
  }

  public btIDebugDraw() : this(LinearMathPINVOKE.new_btIDebugDraw(), true) {
    SwigDirectorConnect();
  }

  private void SwigDirectorConnect() {
    if (SwigDerivedClassHasMethod("drawLine", swigMethodTypes0))
      swigDelegate0 = new SwigDelegatebtIDebugDraw_0(SwigDirectordrawLine__SWIG_0);
    if (SwigDerivedClassHasMethod("drawLine", swigMethodTypes1))
      swigDelegate1 = new SwigDelegatebtIDebugDraw_1(SwigDirectordrawLine__SWIG_1);
    if (SwigDerivedClassHasMethod("drawSphere", swigMethodTypes2))
      swigDelegate2 = new SwigDelegatebtIDebugDraw_2(SwigDirectordrawSphere__SWIG_0);
    if (SwigDerivedClassHasMethod("drawSphere", swigMethodTypes3))
      swigDelegate3 = new SwigDelegatebtIDebugDraw_3(SwigDirectordrawSphere__SWIG_1);
    if (SwigDerivedClassHasMethod("drawTriangle", swigMethodTypes4))
      swigDelegate4 = new SwigDelegatebtIDebugDraw_4(SwigDirectordrawTriangle__SWIG_0);
    if (SwigDerivedClassHasMethod("drawTriangle", swigMethodTypes5))
      swigDelegate5 = new SwigDelegatebtIDebugDraw_5(SwigDirectordrawTriangle__SWIG_1);
    if (SwigDerivedClassHasMethod("drawContactPoint", swigMethodTypes6))
      swigDelegate6 = new SwigDelegatebtIDebugDraw_6(SwigDirectordrawContactPoint);
    if (SwigDerivedClassHasMethod("reportErrorWarning", swigMethodTypes7))
      swigDelegate7 = new SwigDelegatebtIDebugDraw_7(SwigDirectorreportErrorWarning);
    if (SwigDerivedClassHasMethod("draw3dText", swigMethodTypes8))
      swigDelegate8 = new SwigDelegatebtIDebugDraw_8(SwigDirectordraw3dText);
    if (SwigDerivedClassHasMethod("setDebugMode", swigMethodTypes9))
      swigDelegate9 = new SwigDelegatebtIDebugDraw_9(SwigDirectorsetDebugMode);
    if (SwigDerivedClassHasMethod("getDebugMode", swigMethodTypes10))
      swigDelegate10 = new SwigDelegatebtIDebugDraw_10(SwigDirectorgetDebugMode);
    if (SwigDerivedClassHasMethod("drawAabb", swigMethodTypes11))
      swigDelegate11 = new SwigDelegatebtIDebugDraw_11(SwigDirectordrawAabb);
    if (SwigDerivedClassHasMethod("drawTransform", swigMethodTypes12))
      swigDelegate12 = new SwigDelegatebtIDebugDraw_12(SwigDirectordrawTransform);
    if (SwigDerivedClassHasMethod("drawArc", swigMethodTypes13))
      swigDelegate13 = new SwigDelegatebtIDebugDraw_13(SwigDirectordrawArc__SWIG_0);
    if (SwigDerivedClassHasMethod("drawArc", swigMethodTypes14))
      swigDelegate14 = new SwigDelegatebtIDebugDraw_14(SwigDirectordrawArc__SWIG_1);
    if (SwigDerivedClassHasMethod("drawSpherePatch", swigMethodTypes15))
      swigDelegate15 = new SwigDelegatebtIDebugDraw_15(SwigDirectordrawSpherePatch__SWIG_0);
    if (SwigDerivedClassHasMethod("drawSpherePatch", swigMethodTypes16))
      swigDelegate16 = new SwigDelegatebtIDebugDraw_16(SwigDirectordrawSpherePatch__SWIG_1);
    if (SwigDerivedClassHasMethod("drawBox", swigMethodTypes17))
      swigDelegate17 = new SwigDelegatebtIDebugDraw_17(SwigDirectordrawBox__SWIG_0);
    if (SwigDerivedClassHasMethod("drawBox", swigMethodTypes18))
      swigDelegate18 = new SwigDelegatebtIDebugDraw_18(SwigDirectordrawBox__SWIG_1);
    if (SwigDerivedClassHasMethod("drawCapsule", swigMethodTypes19))
      swigDelegate19 = new SwigDelegatebtIDebugDraw_19(SwigDirectordrawCapsule);
    if (SwigDerivedClassHasMethod("drawCylinder", swigMethodTypes20))
      swigDelegate20 = new SwigDelegatebtIDebugDraw_20(SwigDirectordrawCylinder);
    if (SwigDerivedClassHasMethod("drawCone", swigMethodTypes21))
      swigDelegate21 = new SwigDelegatebtIDebugDraw_21(SwigDirectordrawCone);
    if (SwigDerivedClassHasMethod("drawPlane", swigMethodTypes22))
      swigDelegate22 = new SwigDelegatebtIDebugDraw_22(SwigDirectordrawPlane);
    LinearMathPINVOKE.btIDebugDraw_director_connect(swigCPtr, swigDelegate0, swigDelegate1, swigDelegate2, swigDelegate3, swigDelegate4, swigDelegate5, swigDelegate6, swigDelegate7, swigDelegate8, swigDelegate9, swigDelegate10, swigDelegate11, swigDelegate12, swigDelegate13, swigDelegate14, swigDelegate15, swigDelegate16, swigDelegate17, swigDelegate18, swigDelegate19, swigDelegate20, swigDelegate21, swigDelegate22);
  }

  private bool SwigDerivedClassHasMethod(string methodName, Type[] methodTypes) {
    System.Reflection.MethodInfo methodInfo = this.GetType().GetMethod(methodName, System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance, null, methodTypes, null);
    bool hasDerivedMethod = methodInfo.DeclaringType.IsSubclassOf(typeof(btIDebugDraw));
    return hasDerivedMethod;
  }

  private void SwigDirectordrawLine__SWIG_0(IntPtr from, IntPtr to, IntPtr color) {
    drawLine(new btVector3(from, false), new btVector3(to, false), new btVector3(color, false));
  }

  private void SwigDirectordrawLine__SWIG_1(IntPtr from, IntPtr to, IntPtr fromColor, IntPtr toColor) {
    drawLine(new btVector3(from, false), new btVector3(to, false), new btVector3(fromColor, false), new btVector3(toColor, false));
  }

  private void SwigDirectordrawSphere__SWIG_0(float radius, IntPtr transform, IntPtr color) {
    drawSphere(radius, new btTransform(transform, false), new btVector3(color, false));
  }

  private void SwigDirectordrawSphere__SWIG_1(IntPtr p, float radius, IntPtr color) {
    drawSphere(new btVector3(p, false), radius, new btVector3(color, false));
  }

  private void SwigDirectordrawTriangle__SWIG_0(IntPtr v0, IntPtr v1, IntPtr v2, IntPtr arg3, IntPtr arg4, IntPtr arg5, IntPtr color, float alpha) {
    drawTriangle(new btVector3(v0, false), new btVector3(v1, false), new btVector3(v2, false), new btVector3(arg3, false), new btVector3(arg4, false), new btVector3(arg5, false), new btVector3(color, false), alpha);
  }

  private void SwigDirectordrawTriangle__SWIG_1(IntPtr v0, IntPtr v1, IntPtr v2, IntPtr color, float arg4) {
    drawTriangle(new btVector3(v0, false), new btVector3(v1, false), new btVector3(v2, false), new btVector3(color, false), arg4);
  }

  private void SwigDirectordrawContactPoint(IntPtr PointOnB, IntPtr normalOnB, float distance, int lifeTime, IntPtr color) {
    drawContactPoint(new btVector3(PointOnB, false), new btVector3(normalOnB, false), distance, lifeTime, new btVector3(color, false));
  }

  private void SwigDirectorreportErrorWarning(string warningString) {
    reportErrorWarning(warningString);
  }

  private void SwigDirectordraw3dText(IntPtr location, string textString) {
    draw3dText(new btVector3(location, false), textString);
  }

  private void SwigDirectorsetDebugMode(int debugMode) {
    setDebugMode(debugMode);
  }

  private int SwigDirectorgetDebugMode() {
    return getDebugMode();
  }

  private void SwigDirectordrawAabb(IntPtr from, IntPtr to, IntPtr color) {
    drawAabb(new btVector3(from, false), new btVector3(to, false), new btVector3(color, false));
  }

  private void SwigDirectordrawTransform(IntPtr transform, float orthoLen) {
    drawTransform(new btTransform(transform, false), orthoLen);
  }

  private void SwigDirectordrawArc__SWIG_0(IntPtr center, IntPtr normal, IntPtr axis, float radiusA, float radiusB, float minAngle, float maxAngle, IntPtr color, bool drawSect, float stepDegrees) {
    drawArc(new btVector3(center, false), new btVector3(normal, false), new btVector3(axis, false), radiusA, radiusB, minAngle, maxAngle, new btVector3(color, false), drawSect, stepDegrees);
  }

  private void SwigDirectordrawArc__SWIG_1(IntPtr center, IntPtr normal, IntPtr axis, float radiusA, float radiusB, float minAngle, float maxAngle, IntPtr color, bool drawSect) {
    drawArc(new btVector3(center, false), new btVector3(normal, false), new btVector3(axis, false), radiusA, radiusB, minAngle, maxAngle, new btVector3(color, false), drawSect);
  }

  private void SwigDirectordrawSpherePatch__SWIG_0(IntPtr center, IntPtr up, IntPtr axis, float radius, float minTh, float maxTh, float minPs, float maxPs, IntPtr color, float stepDegrees) {
    drawSpherePatch(new btVector3(center, false), new btVector3(up, false), new btVector3(axis, false), radius, minTh, maxTh, minPs, maxPs, new btVector3(color, false), stepDegrees);
  }

  private void SwigDirectordrawSpherePatch__SWIG_1(IntPtr center, IntPtr up, IntPtr axis, float radius, float minTh, float maxTh, float minPs, float maxPs, IntPtr color) {
    drawSpherePatch(new btVector3(center, false), new btVector3(up, false), new btVector3(axis, false), radius, minTh, maxTh, minPs, maxPs, new btVector3(color, false));
  }

  private void SwigDirectordrawBox__SWIG_0(IntPtr bbMin, IntPtr bbMax, IntPtr color) {
    drawBox(new btVector3(bbMin, false), new btVector3(bbMax, false), new btVector3(color, false));
  }

  private void SwigDirectordrawBox__SWIG_1(IntPtr bbMin, IntPtr bbMax, IntPtr trans, IntPtr color) {
    drawBox(new btVector3(bbMin, false), new btVector3(bbMax, false), new btTransform(trans, false), new btVector3(color, false));
  }

  private void SwigDirectordrawCapsule(float radius, float halfHeight, int upAxis, IntPtr transform, IntPtr color) {
    drawCapsule(radius, halfHeight, upAxis, new btTransform(transform, false), new btVector3(color, false));
  }

  private void SwigDirectordrawCylinder(float radius, float halfHeight, int upAxis, IntPtr transform, IntPtr color) {
    drawCylinder(radius, halfHeight, upAxis, new btTransform(transform, false), new btVector3(color, false));
  }

  private void SwigDirectordrawCone(float radius, float height, int upAxis, IntPtr transform, IntPtr color) {
    drawCone(radius, height, upAxis, new btTransform(transform, false), new btVector3(color, false));
  }

  private void SwigDirectordrawPlane(IntPtr planeNormal, float planeConst, IntPtr transform, IntPtr color) {
    drawPlane(new btVector3(planeNormal, false), planeConst, new btTransform(transform, false), new btVector3(color, false));
  }

  public delegate void SwigDelegatebtIDebugDraw_0(IntPtr from, IntPtr to, IntPtr color);
  public delegate void SwigDelegatebtIDebugDraw_1(IntPtr from, IntPtr to, IntPtr fromColor, IntPtr toColor);
  public delegate void SwigDelegatebtIDebugDraw_2(float radius, IntPtr transform, IntPtr color);
  public delegate void SwigDelegatebtIDebugDraw_3(IntPtr p, float radius, IntPtr color);
  public delegate void SwigDelegatebtIDebugDraw_4(IntPtr v0, IntPtr v1, IntPtr v2, IntPtr arg3, IntPtr arg4, IntPtr arg5, IntPtr color, float alpha);
  public delegate void SwigDelegatebtIDebugDraw_5(IntPtr v0, IntPtr v1, IntPtr v2, IntPtr color, float arg4);
  public delegate void SwigDelegatebtIDebugDraw_6(IntPtr PointOnB, IntPtr normalOnB, float distance, int lifeTime, IntPtr color);
  public delegate void SwigDelegatebtIDebugDraw_7(string warningString);
  public delegate void SwigDelegatebtIDebugDraw_8(IntPtr location, string textString);
  public delegate void SwigDelegatebtIDebugDraw_9(int debugMode);
  public delegate int SwigDelegatebtIDebugDraw_10();
  public delegate void SwigDelegatebtIDebugDraw_11(IntPtr from, IntPtr to, IntPtr color);
  public delegate void SwigDelegatebtIDebugDraw_12(IntPtr transform, float orthoLen);
  public delegate void SwigDelegatebtIDebugDraw_13(IntPtr center, IntPtr normal, IntPtr axis, float radiusA, float radiusB, float minAngle, float maxAngle, IntPtr color, bool drawSect, float stepDegrees);
  public delegate void SwigDelegatebtIDebugDraw_14(IntPtr center, IntPtr normal, IntPtr axis, float radiusA, float radiusB, float minAngle, float maxAngle, IntPtr color, bool drawSect);
  public delegate void SwigDelegatebtIDebugDraw_15(IntPtr center, IntPtr up, IntPtr axis, float radius, float minTh, float maxTh, float minPs, float maxPs, IntPtr color, float stepDegrees);
  public delegate void SwigDelegatebtIDebugDraw_16(IntPtr center, IntPtr up, IntPtr axis, float radius, float minTh, float maxTh, float minPs, float maxPs, IntPtr color);
  public delegate void SwigDelegatebtIDebugDraw_17(IntPtr bbMin, IntPtr bbMax, IntPtr color);
  public delegate void SwigDelegatebtIDebugDraw_18(IntPtr bbMin, IntPtr bbMax, IntPtr trans, IntPtr color);
  public delegate void SwigDelegatebtIDebugDraw_19(float radius, float halfHeight, int upAxis, IntPtr transform, IntPtr color);
  public delegate void SwigDelegatebtIDebugDraw_20(float radius, float halfHeight, int upAxis, IntPtr transform, IntPtr color);
  public delegate void SwigDelegatebtIDebugDraw_21(float radius, float height, int upAxis, IntPtr transform, IntPtr color);
  public delegate void SwigDelegatebtIDebugDraw_22(IntPtr planeNormal, float planeConst, IntPtr transform, IntPtr color);

  private SwigDelegatebtIDebugDraw_0 swigDelegate0;
  private SwigDelegatebtIDebugDraw_1 swigDelegate1;
  private SwigDelegatebtIDebugDraw_2 swigDelegate2;
  private SwigDelegatebtIDebugDraw_3 swigDelegate3;
  private SwigDelegatebtIDebugDraw_4 swigDelegate4;
  private SwigDelegatebtIDebugDraw_5 swigDelegate5;
  private SwigDelegatebtIDebugDraw_6 swigDelegate6;
  private SwigDelegatebtIDebugDraw_7 swigDelegate7;
  private SwigDelegatebtIDebugDraw_8 swigDelegate8;
  private SwigDelegatebtIDebugDraw_9 swigDelegate9;
  private SwigDelegatebtIDebugDraw_10 swigDelegate10;
  private SwigDelegatebtIDebugDraw_11 swigDelegate11;
  private SwigDelegatebtIDebugDraw_12 swigDelegate12;
  private SwigDelegatebtIDebugDraw_13 swigDelegate13;
  private SwigDelegatebtIDebugDraw_14 swigDelegate14;
  private SwigDelegatebtIDebugDraw_15 swigDelegate15;
  private SwigDelegatebtIDebugDraw_16 swigDelegate16;
  private SwigDelegatebtIDebugDraw_17 swigDelegate17;
  private SwigDelegatebtIDebugDraw_18 swigDelegate18;
  private SwigDelegatebtIDebugDraw_19 swigDelegate19;
  private SwigDelegatebtIDebugDraw_20 swigDelegate20;
  private SwigDelegatebtIDebugDraw_21 swigDelegate21;
  private SwigDelegatebtIDebugDraw_22 swigDelegate22;

  private static Type[] swigMethodTypes0 = new Type[] { typeof(btVector3), typeof(btVector3), typeof(btVector3) };
  private static Type[] swigMethodTypes1 = new Type[] { typeof(btVector3), typeof(btVector3), typeof(btVector3), typeof(btVector3) };
  private static Type[] swigMethodTypes2 = new Type[] { typeof(float), typeof(btTransform), typeof(btVector3) };
  private static Type[] swigMethodTypes3 = new Type[] { typeof(btVector3), typeof(float), typeof(btVector3) };
  private static Type[] swigMethodTypes4 = new Type[] { typeof(btVector3), typeof(btVector3), typeof(btVector3), typeof(btVector3), typeof(btVector3), typeof(btVector3), typeof(btVector3), typeof(float) };
  private static Type[] swigMethodTypes5 = new Type[] { typeof(btVector3), typeof(btVector3), typeof(btVector3), typeof(btVector3), typeof(float) };
  private static Type[] swigMethodTypes6 = new Type[] { typeof(btVector3), typeof(btVector3), typeof(float), typeof(int), typeof(btVector3) };
  private static Type[] swigMethodTypes7 = new Type[] { typeof(string) };
  private static Type[] swigMethodTypes8 = new Type[] { typeof(btVector3), typeof(string) };
  private static Type[] swigMethodTypes9 = new Type[] { typeof(int) };
  private static Type[] swigMethodTypes10 = new Type[] {  };
  private static Type[] swigMethodTypes11 = new Type[] { typeof(btVector3), typeof(btVector3), typeof(btVector3) };
  private static Type[] swigMethodTypes12 = new Type[] { typeof(btTransform), typeof(float) };
  private static Type[] swigMethodTypes13 = new Type[] { typeof(btVector3), typeof(btVector3), typeof(btVector3), typeof(float), typeof(float), typeof(float), typeof(float), typeof(btVector3), typeof(bool), typeof(float) };
  private static Type[] swigMethodTypes14 = new Type[] { typeof(btVector3), typeof(btVector3), typeof(btVector3), typeof(float), typeof(float), typeof(float), typeof(float), typeof(btVector3), typeof(bool) };
  private static Type[] swigMethodTypes15 = new Type[] { typeof(btVector3), typeof(btVector3), typeof(btVector3), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(btVector3), typeof(float) };
  private static Type[] swigMethodTypes16 = new Type[] { typeof(btVector3), typeof(btVector3), typeof(btVector3), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(btVector3) };
  private static Type[] swigMethodTypes17 = new Type[] { typeof(btVector3), typeof(btVector3), typeof(btVector3) };
  private static Type[] swigMethodTypes18 = new Type[] { typeof(btVector3), typeof(btVector3), typeof(btTransform), typeof(btVector3) };
  private static Type[] swigMethodTypes19 = new Type[] { typeof(float), typeof(float), typeof(int), typeof(btTransform), typeof(btVector3) };
  private static Type[] swigMethodTypes20 = new Type[] { typeof(float), typeof(float), typeof(int), typeof(btTransform), typeof(btVector3) };
  private static Type[] swigMethodTypes21 = new Type[] { typeof(float), typeof(float), typeof(int), typeof(btTransform), typeof(btVector3) };
  private static Type[] swigMethodTypes22 = new Type[] { typeof(btVector3), typeof(float), typeof(btTransform), typeof(btVector3) };
  public enum DebugDrawModes {
    DBG_NoDebug = 0,
    DBG_DrawWireframe = 1,
    DBG_DrawAabb = 2,
    DBG_DrawFeaturesText = 4,
    DBG_DrawContactPoints = 8,
    DBG_NoDeactivation = 16,
    DBG_NoHelpText = 32,
    DBG_DrawText = 64,
    DBG_ProfileTimings = 128,
    DBG_EnableSatComparison = 256,
    DBG_DisableBulletLCP = 512,
    DBG_EnableCCD = 1024,
    DBG_DrawConstraints = (1 << 11),
    DBG_DrawConstraintLimits = (1 << 12),
    DBG_FastWireframe = (1 << 13),
    DBG_DrawNormals = (1 << 14),
    DBG_MAX_DEBUG_DRAW_MODE
  }

}

}
