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

public class Cluster : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal Cluster(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(Cluster obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~Cluster() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          BulletSoftBodyPINVOKE.delete_Cluster(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public SWIGTYPE_p_tScalarArray m_masses {
    set {
      BulletSoftBodyPINVOKE.Cluster_m_masses_set(swigCPtr, SWIGTYPE_p_tScalarArray.getCPtr(value));
      if (BulletSoftBodyPINVOKE.SWIGPendingException.Pending) throw BulletSoftBodyPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_tScalarArray ret = new SWIGTYPE_p_tScalarArray(BulletSoftBodyPINVOKE.Cluster_m_masses_get(swigCPtr), true);
      if (BulletSoftBodyPINVOKE.SWIGPendingException.Pending) throw BulletSoftBodyPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public SWIGTYPE_p_btAlignedObjectArrayT_Node_p_t m_nodes {
    set {
      BulletSoftBodyPINVOKE.Cluster_m_nodes_set(swigCPtr, SWIGTYPE_p_btAlignedObjectArrayT_Node_p_t.getCPtr(value));
    } 
    get {
      IntPtr cPtr = BulletSoftBodyPINVOKE.Cluster_m_nodes_get(swigCPtr);
      SWIGTYPE_p_btAlignedObjectArrayT_Node_p_t ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_btAlignedObjectArrayT_Node_p_t(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_tVector3Array m_framerefs {
    set {
      BulletSoftBodyPINVOKE.Cluster_m_framerefs_set(swigCPtr, SWIGTYPE_p_tVector3Array.getCPtr(value));
      if (BulletSoftBodyPINVOKE.SWIGPendingException.Pending) throw BulletSoftBodyPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_tVector3Array ret = new SWIGTYPE_p_tVector3Array(BulletSoftBodyPINVOKE.Cluster_m_framerefs_get(swigCPtr), true);
      if (BulletSoftBodyPINVOKE.SWIGPendingException.Pending) throw BulletSoftBodyPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public SWIGTYPE_p_btTransform m_framexform {
    set {
      BulletSoftBodyPINVOKE.Cluster_m_framexform_set(swigCPtr, SWIGTYPE_p_btTransform.getCPtr(value));
      if (BulletSoftBodyPINVOKE.SWIGPendingException.Pending) throw BulletSoftBodyPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_btTransform ret = new SWIGTYPE_p_btTransform(BulletSoftBodyPINVOKE.Cluster_m_framexform_get(swigCPtr), true);
      if (BulletSoftBodyPINVOKE.SWIGPendingException.Pending) throw BulletSoftBodyPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public float m_idmass {
    set {
      BulletSoftBodyPINVOKE.Cluster_m_idmass_set(swigCPtr, value);
    } 
    get {
      float ret = BulletSoftBodyPINVOKE.Cluster_m_idmass_get(swigCPtr);
      return ret;
    } 
  }

  public float m_imass {
    set {
      BulletSoftBodyPINVOKE.Cluster_m_imass_set(swigCPtr, value);
    } 
    get {
      float ret = BulletSoftBodyPINVOKE.Cluster_m_imass_get(swigCPtr);
      return ret;
    } 
  }

  public SWIGTYPE_p_btMatrix3x3 m_locii {
    set {
      BulletSoftBodyPINVOKE.Cluster_m_locii_set(swigCPtr, SWIGTYPE_p_btMatrix3x3.getCPtr(value));
      if (BulletSoftBodyPINVOKE.SWIGPendingException.Pending) throw BulletSoftBodyPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_btMatrix3x3 ret = new SWIGTYPE_p_btMatrix3x3(BulletSoftBodyPINVOKE.Cluster_m_locii_get(swigCPtr), true);
      if (BulletSoftBodyPINVOKE.SWIGPendingException.Pending) throw BulletSoftBodyPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public SWIGTYPE_p_btMatrix3x3 m_invwi {
    set {
      BulletSoftBodyPINVOKE.Cluster_m_invwi_set(swigCPtr, SWIGTYPE_p_btMatrix3x3.getCPtr(value));
      if (BulletSoftBodyPINVOKE.SWIGPendingException.Pending) throw BulletSoftBodyPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_btMatrix3x3 ret = new SWIGTYPE_p_btMatrix3x3(BulletSoftBodyPINVOKE.Cluster_m_invwi_get(swigCPtr), true);
      if (BulletSoftBodyPINVOKE.SWIGPendingException.Pending) throw BulletSoftBodyPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public SWIGTYPE_p_btVector3 m_com {
    set {
      BulletSoftBodyPINVOKE.Cluster_m_com_set(swigCPtr, SWIGTYPE_p_btVector3.getCPtr(value));
      if (BulletSoftBodyPINVOKE.SWIGPendingException.Pending) throw BulletSoftBodyPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_btVector3 ret = new SWIGTYPE_p_btVector3(BulletSoftBodyPINVOKE.Cluster_m_com_get(swigCPtr), true);
      if (BulletSoftBodyPINVOKE.SWIGPendingException.Pending) throw BulletSoftBodyPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public SWIGTYPE_p_btVector3 m_vimpulses {
    set {
      BulletSoftBodyPINVOKE.Cluster_m_vimpulses_set(swigCPtr, SWIGTYPE_p_btVector3.getCPtr(value));
    } 
    get {
      IntPtr cPtr = BulletSoftBodyPINVOKE.Cluster_m_vimpulses_get(swigCPtr);
      SWIGTYPE_p_btVector3 ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_btVector3(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_btVector3 m_dimpulses {
    set {
      BulletSoftBodyPINVOKE.Cluster_m_dimpulses_set(swigCPtr, SWIGTYPE_p_btVector3.getCPtr(value));
    } 
    get {
      IntPtr cPtr = BulletSoftBodyPINVOKE.Cluster_m_dimpulses_get(swigCPtr);
      SWIGTYPE_p_btVector3 ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_btVector3(cPtr, false);
      return ret;
    } 
  }

  public int m_nvimpulses {
    set {
      BulletSoftBodyPINVOKE.Cluster_m_nvimpulses_set(swigCPtr, value);
    } 
    get {
      int ret = BulletSoftBodyPINVOKE.Cluster_m_nvimpulses_get(swigCPtr);
      return ret;
    } 
  }

  public int m_ndimpulses {
    set {
      BulletSoftBodyPINVOKE.Cluster_m_ndimpulses_set(swigCPtr, value);
    } 
    get {
      int ret = BulletSoftBodyPINVOKE.Cluster_m_ndimpulses_get(swigCPtr);
      return ret;
    } 
  }

  public SWIGTYPE_p_btVector3 m_lv {
    set {
      BulletSoftBodyPINVOKE.Cluster_m_lv_set(swigCPtr, SWIGTYPE_p_btVector3.getCPtr(value));
      if (BulletSoftBodyPINVOKE.SWIGPendingException.Pending) throw BulletSoftBodyPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_btVector3 ret = new SWIGTYPE_p_btVector3(BulletSoftBodyPINVOKE.Cluster_m_lv_get(swigCPtr), true);
      if (BulletSoftBodyPINVOKE.SWIGPendingException.Pending) throw BulletSoftBodyPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public SWIGTYPE_p_btVector3 m_av {
    set {
      BulletSoftBodyPINVOKE.Cluster_m_av_set(swigCPtr, SWIGTYPE_p_btVector3.getCPtr(value));
      if (BulletSoftBodyPINVOKE.SWIGPendingException.Pending) throw BulletSoftBodyPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_btVector3 ret = new SWIGTYPE_p_btVector3(BulletSoftBodyPINVOKE.Cluster_m_av_get(swigCPtr), true);
      if (BulletSoftBodyPINVOKE.SWIGPendingException.Pending) throw BulletSoftBodyPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public SWIGTYPE_p_btDbvtNode m_leaf {
    set {
      BulletSoftBodyPINVOKE.Cluster_m_leaf_set(swigCPtr, SWIGTYPE_p_btDbvtNode.getCPtr(value));
    } 
    get {
      IntPtr cPtr = BulletSoftBodyPINVOKE.Cluster_m_leaf_get(swigCPtr);
      SWIGTYPE_p_btDbvtNode ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_btDbvtNode(cPtr, false);
      return ret;
    } 
  }

  public float m_ndamping {
    set {
      BulletSoftBodyPINVOKE.Cluster_m_ndamping_set(swigCPtr, value);
    } 
    get {
      float ret = BulletSoftBodyPINVOKE.Cluster_m_ndamping_get(swigCPtr);
      return ret;
    } 
  }

  public float m_ldamping {
    set {
      BulletSoftBodyPINVOKE.Cluster_m_ldamping_set(swigCPtr, value);
    } 
    get {
      float ret = BulletSoftBodyPINVOKE.Cluster_m_ldamping_get(swigCPtr);
      return ret;
    } 
  }

  public float m_adamping {
    set {
      BulletSoftBodyPINVOKE.Cluster_m_adamping_set(swigCPtr, value);
    } 
    get {
      float ret = BulletSoftBodyPINVOKE.Cluster_m_adamping_get(swigCPtr);
      return ret;
    } 
  }

  public float m_matching {
    set {
      BulletSoftBodyPINVOKE.Cluster_m_matching_set(swigCPtr, value);
    } 
    get {
      float ret = BulletSoftBodyPINVOKE.Cluster_m_matching_get(swigCPtr);
      return ret;
    } 
  }

  public float m_maxSelfCollisionImpulse {
    set {
      BulletSoftBodyPINVOKE.Cluster_m_maxSelfCollisionImpulse_set(swigCPtr, value);
    } 
    get {
      float ret = BulletSoftBodyPINVOKE.Cluster_m_maxSelfCollisionImpulse_get(swigCPtr);
      return ret;
    } 
  }

  public float m_selfCollisionImpulseFactor {
    set {
      BulletSoftBodyPINVOKE.Cluster_m_selfCollisionImpulseFactor_set(swigCPtr, value);
    } 
    get {
      float ret = BulletSoftBodyPINVOKE.Cluster_m_selfCollisionImpulseFactor_get(swigCPtr);
      return ret;
    } 
  }

  public bool m_containsAnchor {
    set {
      BulletSoftBodyPINVOKE.Cluster_m_containsAnchor_set(swigCPtr, value);
    } 
    get {
      bool ret = BulletSoftBodyPINVOKE.Cluster_m_containsAnchor_get(swigCPtr);
      return ret;
    } 
  }

  public bool m_collide {
    set {
      BulletSoftBodyPINVOKE.Cluster_m_collide_set(swigCPtr, value);
    } 
    get {
      bool ret = BulletSoftBodyPINVOKE.Cluster_m_collide_get(swigCPtr);
      return ret;
    } 
  }

  public int m_clusterIndex {
    set {
      BulletSoftBodyPINVOKE.Cluster_m_clusterIndex_set(swigCPtr, value);
    } 
    get {
      int ret = BulletSoftBodyPINVOKE.Cluster_m_clusterIndex_get(swigCPtr);
      return ret;
    } 
  }

  public Cluster() : this(BulletSoftBodyPINVOKE.new_Cluster(), true) {
  }

}

}