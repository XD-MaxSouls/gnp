using System;
using System.Text;
using System.Runtime.CompilerServices;

namespace GAME
{
    /// <summary>
    /// 游戏管理器接口类
    /// </summary>
    public class GMatrixBase
    {
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static GMatrix GetInstance();
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static GDataManItem GetDataMan(IntPtr p);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static int GetServerIndex(IntPtr p);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static string GetServerName(IntPtr p);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void BroadcastMsg(IntPtr p, string s, sbyte channel);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void Test(IntPtr p,int n,string s);
        private IntPtr nativePtr = new IntPtr();
        /// <summary>
        /// 取得游戏管理器全局对象
        /// </summary>
        /// <returns>管理器对象</returns>
        public static GMatrix GetMatrix()
        {
            return GetInstance();
        }
        /// <summary>
        /// 取得游戏数据管理器
        /// </summary>
        /// <returns>游戏数据管理器对象</returns>
        public GDataManItem GetDataMan()
        {
            return GetDataMan(nativePtr);
        }
        /// <summary>
        /// 取得游戏服务器线路号码
        /// </summary>
        /// <returns>线路号码</returns>
        public int GetServerIndex()
        {
            return GetServerIndex(nativePtr);
        }
        /// <summary>
        /// 取得游戏服务器线路名称
        /// </summary>
        /// <returns></returns>
        public string GetServerName()
        {
            return GetServerName(nativePtr);
        }
        /// <summary>
        /// 发送广播信息
        /// </summary>
        /// <param name="s">信息内容</param>
        /// <param name="channel">频道类型（0普通，1世界，2组队，3帮派，4密语，9广播）</param>
        public void BroadcastMsg(string s, sbyte channel)
        {
            BroadcastMsg(nativePtr, s, channel);
        }
        public void Test(int n,string s)
        {
            Test(nativePtr,n,s);
        }
    }
}
