using System;
using System.Text;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace SKILL
{
    /// <summary>
    /// 技能处理类
    /// </summary>
    public class GState : IDisposable
    {
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static IntPtr Constructor(GState stub);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void Deconstructor(IntPtr p);
        private IntPtr nativePtr = new IntPtr();
        /// <summary>
        /// 构造函数
        /// </summary>
        public GState()
        {
            nativePtr = Constructor(this);
        }
        /// <summary>
        /// 析构函数
        /// </summary>
        ~GState()
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
        /// <summary>
        /// 取得接口对象指针
        /// </summary>
        /// <returns></returns>
        public IntPtr GetNativePtr()
        {
            return nativePtr;
        }
        public virtual int GetTime(GSkill skill)
        {
            return 0;
        }
        public virtual void Calculate(GSkill skill)
        {

        }
        /// <summary>
        /// 中断执行
        /// </summary>
        /// <param name="skill">技能数据对象</param>
        /// <returns>是否中断</returns>
        public virtual bool Interrupt(GSkill skill)
        {
            return false;
        }
        /// <summary>
        /// 取消执行
        /// </summary>
        /// <param name="skill">技能数据对象</param>
        /// <returns>是否取消</returns>
        public virtual bool Cancel(GSkill skill)
        {
            return false;
        }
        public virtual bool Bypass(GSkill skill)
        {
            return false;
        }
        public virtual bool Skip(GSkill skill)
        {
            return false;
        }
        public virtual bool Quit(GSkill skill)
        {
            return false;
        }
        public virtual bool Loop(GSkill skill)
        {
            return false;
        }
    }
}
