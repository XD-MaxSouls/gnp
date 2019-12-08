using System;
using System.Text;
using System.Runtime.CompilerServices;

namespace GAME
{
    /// <summary>
    /// 游戏数据管理器接口
    /// </summary>
    public class GDataManBase
    {
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static string GetDataName(IntPtr p,int id);
        private IntPtr nativePtr = new IntPtr();
        /// <summary>
        /// 根据游戏数据标识取得数据的名称
        /// </summary>
        /// <param name="id">游戏数据标识（物品ID、怪物ID等标识）</param>
        /// <returns>数据名称</returns>
        public string GetDataName(int id)
        {
            return GetDataName(nativePtr, id);
        }
    }
}
