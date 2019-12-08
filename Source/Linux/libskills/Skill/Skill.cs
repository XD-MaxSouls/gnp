using System;
using System.Text;
using System.Runtime.CompilerServices;

namespace SKILL
{
    /// <summary>
    /// 技能数据接口
    /// </summary>
    public class GSkill : IDisposable
    {
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static IntPtr Constructor(GSkill stub, int id);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void Deconstructor(IntPtr p);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static IntPtr GetPlayer(IntPtr p);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static IntPtr GetVictim(IntPtr p);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static int GetC0(IntPtr p);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static int GetC1(IntPtr p);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static int GetC2(IntPtr p);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static int GetC3(IntPtr p);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static int GetC4(IntPtr p);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static int GetJ0(IntPtr p);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static int GetJ1(IntPtr p);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static int GetJ2(IntPtr p);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static int GetJ3(IntPtr p);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static int GetJ4(IntPtr p);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static int GetJ5(IntPtr p);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static int GetJ6(IntPtr p);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static int GetJ7(IntPtr p);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static int GetJ8(IntPtr p);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static int GetJ9(IntPtr p);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static int GetT0(IntPtr p);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static int GetT1(IntPtr p);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static int GetT2(IntPtr p);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static int GetT3(IntPtr p);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static int GetT4(IntPtr p);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static int GetT5(IntPtr p);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static int GetT6(IntPtr p);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static int GetT7(IntPtr p);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static int GetLevel(IntPtr p);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static int GetCooltime(IntPtr p);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static int GetIscrit(IntPtr p);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static float GetPlus(IntPtr p);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static float GetPlus2(IntPtr p);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static float GetRatio(IntPtr p);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static float GetCrit(IntPtr p);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static float GetCrithurt(IntPtr p);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static int GetSkillaccu(IntPtr p);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static int GetDamage(IntPtr p);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static int GetRealDamage(IntPtr p);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static float GetTianhua1(IntPtr p);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static float GetTianhua2(IntPtr p);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static int GetCharging(IntPtr p);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void SetPlus(IntPtr p, float v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void SetPlus2(IntPtr p, float v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void SetRatio(IntPtr p, float v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void SetCrit(IntPtr p, float v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void SetCrithurt(IntPtr p, float v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void SetSkillaccu(IntPtr p, int v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void SetRealDamage(IntPtr p, int v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void SetCharging(IntPtr p, int v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void SetSaint(IntPtr p, int v);
        private IntPtr nativePtr = new IntPtr();
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="id">技能标识</param>
        public GSkill(int id)
        {
            nativePtr = Constructor(this, id);
        }
        /// <summary>
        /// 析构函数
        /// </summary>
        ~GSkill()
        {
            Dispose(false);
        }
        /// <summary>
        /// 释放对象函数
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
        }
        /// <summary>
        /// 释放对象函数
        /// </summary>
        /// <param name="disposing">是否为手工</param>
        protected virtual void Dispose(bool disposing)
        {
            if (nativePtr != IntPtr.Zero)
            {
                Deconstructor(nativePtr);
                nativePtr = IntPtr.Zero;
            }
            if (disposing != false)
            {
                GC.SuppressFinalize(this);
            }
        }
        public int GetC0()
        {
            return GetC0(nativePtr);
        }
        public int GetC1()
        {
            return GetC1(nativePtr);
        }
        public int GetC2()
        {
            return GetC2(nativePtr);
        }
        public int GetC3()
        {
            return GetC3(nativePtr);
        }
        public int GetC4()
        {
            return GetC4(nativePtr);
        }
        public int GetJ0()
        {
            return GetJ0(nativePtr);
        }
        public int GetJ1()
        {
            return GetJ1(nativePtr);
        }
        public int GetJ2()
        {
            return GetJ2(nativePtr);
        }
        public int GetJ3()
        {
            return GetJ3(nativePtr);
        }
        public int GetJ4()
        {
            return GetJ4(nativePtr);
        }
        public int GetJ5()
        {
            return GetJ5(nativePtr);
        }
        public int GetJ6()
        {
            return GetJ6(nativePtr);
        }
        public int GetJ7()
        {
            return GetJ7(nativePtr);
        }
        public int GetJ8()
        {
            return GetJ8(nativePtr);
        }
        public int GetJ9()
        {
            return GetJ9(nativePtr);
        }
        public int GetT0()
        {
            return GetT0(nativePtr);
        }
        public int GetT1()
        {
            return GetT1(nativePtr);
        }
        public int GetT2()
        {
            return GetT2(nativePtr);
        }
        public int GetT3()
        {
            return GetT3(nativePtr);
        }
        public int GetT4()
        {
            return GetT4(nativePtr);
        }
        public int GetT5()
        {
            return GetT5(nativePtr);
        }
        public int GetT6()
        {
            return GetT6(nativePtr);
        }
        public int GetT7()
        {
            return GetT7(nativePtr);
        }
        public int GetLevel()
        {
            return GetLevel(nativePtr);
        }
        public int GetCooltime()
        {
            return GetCooltime(nativePtr);
        }
        public int GetIscrit()
        {
            return GetIscrit(nativePtr);
        }
        public float GetPlus()
        {
            return GetPlus(nativePtr);
        }
        public float GetPlus2()
        {
            return GetPlus2(nativePtr);
        }
        public float GetRatio()
        {
            return GetRatio(nativePtr);
        }
        public float GetCrit()
        {
            return GetCrit(nativePtr);
        }
        public float GetCrithurt()
        {
            return GetCrithurt(nativePtr);
        }
        public int GetSkillaccu()
        {
            return GetSkillaccu(nativePtr);
        }
        public int GetDamage()
        {
            return GetDamage(nativePtr);
        }
        public int GetRealDamage()
        {
            return GetRealDamage(nativePtr);
        }
        public float GetTianhua1()
        {
            return GetTianhua1(nativePtr);
        }
        public float GetTianhua2()
        {
            return GetTianhua2(nativePtr);
        }
        public int GetCharging()
        {
            return GetCharging(nativePtr);
        }
        public void SetPlus(float v)
        {
            SetPlus(nativePtr, v);
        }
        public void SetPlus2(float v)
        {
            SetPlus2(nativePtr, v);
        }
        public void SetRatio(float v)
        {
            SetRatio(nativePtr, v);
        }
        public void SetCrit(float v)
        {
            SetCrit(nativePtr, v);
        }
        public void SetCrithurt(float v)
        {
            SetCrithurt(nativePtr, v);
        }
        public void SetSkillaccu(int v)
        {
            SetSkillaccu(nativePtr, v);
        }
        public void SetRealDamage(int v)
        {
            SetRealDamage(nativePtr, v);
        }
        public void SetCharging(int v)
        {
            SetCharging(nativePtr, v);
        }
        public void SetSaint(int v)
        {
            SetSaint(nativePtr, v);
        }
        public GPlayerWrapper GetPlayer()
        {
            return new GPlayerWrapper(GetPlayer(nativePtr));
        }
        public GPlayerWrapper GetVictim()
        {
            return new GPlayerWrapper(GetVictim(nativePtr));
        }
    }
}
