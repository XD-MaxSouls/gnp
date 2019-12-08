using System;
using System.Text;
using System.Runtime.CompilerServices;

namespace GAME
{
    /// <summary>
    /// 地图接口类
    /// </summary>
    public class GWorldBase
    {
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static int GetTag(IntPtr p);
        private IntPtr nativePtr = new IntPtr();
        /// <summary>
        /// 取得地图标识
        /// </summary>
        /// <returns></returns>
        public int GetTag()
        {
            return GetTag(nativePtr);
        }
    }
}
