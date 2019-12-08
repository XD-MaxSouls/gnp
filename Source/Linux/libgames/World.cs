using System;
using System.Text;

namespace GAME
{
    /// <summary>
    /// 地图类
    /// </summary>
    public class GWorld : GWorldBase
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        public GWorld()
        {

        }
        /// <summary>
        /// 怪物死亡时爆出物品回调函数
        /// </summary>
        /// <param name="item_type">物品类型</param>
        /// <param name="item_count">物品数量</param>
        /// <param name="drop_id">怪物标识</param>
        /// <param name="x">坐标X</param>
        /// <param name="y">坐标Y</param>
        /// <param name="z">坐标Z</param>
        protected void OnNpcDropItem(int item_type, int item_count, int drop_id, float x, float y, float z)
        {
            GMatrix matrix = GMatrix.GetMatrix();
            GDataManItem dataman = matrix.GetDataMan();
            string npc_name = dataman.GetDataName(drop_id);
            string item_name = dataman.GetDataName(item_type);
            int worldtag = GetTag();
            string s;

            s = string.Format("NPC({0})爆物品{1}，坐标{2:G}({3:G},{4:G},{5:G})",npc_name, item_name, worldtag, x, y, z);

            matrix.BroadcastMsg(s, 9);
        }
        /// <summary>
        /// 怪物AI处理时扔出物品回调函数
        /// </summary>
        /// <param name="item_type">物品类型</param>
        /// <param name="item_count">物品数量</param>
        /// <param name="drop_id">怪物标识</param>
        /// <param name="x">坐标X</param>
        /// <param name="y">坐标Y</param>
        /// <param name="z">坐标Z</param>
        protected void OnMonDropItem(int item_type, int item_count, int drop_id, float x, float y, float z)
        {
            GMatrix matrix = GMatrix.GetMatrix();
            GDataManItem dataman = matrix.GetDataMan();
            string item_name = dataman.GetDataName(item_type);
            int worldtag = GetTag();
            string s;

            s = string.Format("怪物爆物品{0}，坐标{1:G}({2:F3},{3:F3},{4:F3})", item_name, worldtag, x, y, z);

            matrix.BroadcastMsg(s, 9);
        }
        /// <summary>
        /// 角色扔出物品回调函数
        /// </summary>
        /// <param name="item_type">物品类型</param>
        /// <param name="item_count">物品数量</param>
        /// <param name="drop_id">怪物标识</param>
        /// <param name="x">坐标X</param>
        /// <param name="y">坐标Y</param>
        /// <param name="z">坐标Z</param>
        protected void OnPlayerDropItem(int item_type, int item_count, int drop_id, float x, float y, float z)
        {
            GMatrix matrix = GMatrix.GetMatrix();
            GDataManItem dataman = matrix.GetDataMan();
            string item_name = dataman.GetDataName(item_type);
            int worldtag = GetTag();
            string s;

            s = string.Format("扔下物品{0}，坐标{1:G}({2:F3},{3:F3},{4:F3})", item_name, worldtag, x, y, z);

            matrix.BroadcastMsg(s, 9);
        }
        /// <summary>
        /// 角色扔出金币回调函数
        /// </summary>
        /// <param name="amount">数量</param>
        /// <param name="drop_id">角色标识</param>
        /// <param name="x">坐标X</param>
        /// <param name="y">坐标Y</param>
        /// <param name="z">坐标Z</param>
        protected void OnPlayerDropMoney(int amount, int drop_id, float x, float y, float z)
        {
            GMatrix matrix = GMatrix.GetMatrix();
            int worldtag = GetTag();
            string s;

            s = string.Format("扔下{0:G}金币，坐标{1:G}({2:F3},{3:F3},{4:F3})", amount, worldtag, x, y, z);

            matrix.BroadcastMsg(s, 9);
        }
    }
}
