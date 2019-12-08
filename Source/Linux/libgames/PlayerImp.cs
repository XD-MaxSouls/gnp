using System;
using System.Text;

namespace GAME
{
    /// <summary>
    /// 游戏角色类
    /// </summary>
    public class GPlayerImp : GPlayerBase
    {
        private GPlayerCmd _cmd = null;
        /// <summary>
        /// 构造函数
        /// </summary>
        public GPlayerImp()
        {
            _cmd = new GPlayerCmd(this);
        }
        /// <summary>
        /// 角色输入游戏命令回调函数
        /// </summary>
        /// <param name="sCmd">命令名称</param>
        /// <param name="sParam0">参数0</param>
        /// <param name="sParam1">参数1</param>
        /// <param name="sParam2">参数2</param>
        /// <param name="sParam3">参数3</param>
        /// <param name="sParam4">参数4</param>
        /// <param name="sParam5">参数5</param>
        /// <param name="sParam6">参数6</param>
        /// <returns>是否处理命令</returns>
        protected bool OnCmdHandler(string sCmd, string sParam0, string sParam1, string sParam2, string sParam3, string sParam4, string sParam5, string sParam6)
        {
            return _cmd.OnCmdHandler(sCmd, sParam0, sParam1, sParam2, sParam3, sParam4, sParam5, sParam6);
        }
        /// <summary>
        /// 角色处理心跳回调函数
        /// </summary>
        /// <param name="tick">二次心跳间隔时间（秒）</param>
        protected void OnHeartbeat(uint tick)
        {

        }
        /// <summary>
        /// 角色消息处理回调函数
        /// </summary>
        /// <param name="msg">消息对象</param>
        /// <returns>是否处理</returns>
        protected bool OnMessageHandler(GMSG msg)
        {
            return false;
        }
        /// <summary>
        /// 角色进入地图回调函数
        /// </summary>
        protected void OnEnterWorld()
        {

        }
        /// <summary>
        /// 角色离开地图回调函数
        /// </summary>
        protected void OnLeaveWorld()
        {

        }
        protected void OnAddExp(ref long exp)
        {
            GMatrix matrix = GMatrix.GetMatrix();
            string name = GetName();
            string s;

            s = string.Format("玩家({0})获得经验{1}", name, exp);

            exp *= 2;

            matrix.BroadcastMsg(s, 9);
        }
        protected void OnIncExp(ref long exp)
        {
            GMatrix matrix = GMatrix.GetMatrix();
            string name = GetName();
            string s;

            s = string.Format("玩家({0})得到经验{1}", name, exp);

            exp *= 2;

            matrix.BroadcastMsg(s, 9);
        }
        /// <summary>
        /// 角色等级提升回调函数
        /// </summary>
        /// <param name="level_old">原等级</param>
        /// <param name="level_new">新等级</param>
        /// <param name="level_reborn">飞升次数</param>
        protected void OnLevelUp(int level_old, int level_new, int level_reborn)
        {
            GMatrix matrix = GMatrix.GetMatrix();
            string name = GetName();
            string s;

            s = string.Format("玩家({0})从{1:G}级升级到{2:G}", name,level_old, level_new, level_reborn);

            matrix.BroadcastMsg(s, 9);
        }
        /// <summary>
        /// 角色捡起物品回调函数
        /// </summary>
        /// <param name="item_type">物品类型</param>
        /// <param name="total_count">物品数量</param>
        /// <param name="pickup_count">捡起数量</param>
        /// <param name="drop_id">物品所属标识</param>
        /// <param name="worldtag">地图号</param>
        /// <param name="x">坐标X</param>
        /// <param name="y">坐标Y</param>
        /// <param name="z">坐标Z</param>
        protected void OnPickupItem(int item_type, int total_count, int pickup_count, int drop_id, int worldtag, float x, float y, float z)
        {
            GMatrix matrix = GMatrix.GetMatrix();
            string name = GetName();
            string s;

            s = string.Format("玩家({0})捡起{1:G}个物品{2:G}，位于{3:G}({4:F3},{5:F3},{6:F3})", name, pickup_count, item_type, worldtag, x, y, z);

            matrix.BroadcastMsg(s, 9);
        }
    }
}
