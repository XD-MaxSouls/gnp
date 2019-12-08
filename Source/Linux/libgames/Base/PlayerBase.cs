using System;
using System.Text;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace GAME
{
    [StructLayout(LayoutKind.Sequential)]
    public struct G3DVECTOR
    {
        public float x;
        public float y;
        public float z;
    }
    [StructLayout(LayoutKind.Sequential)]
    public struct GID
    {
        public int type;
        public int id;
    }
    [StructLayout(LayoutKind.Sequential)]
    public struct GMSG
    {
	    public int message;
        public GID target;
        public GID source;
        public G3DVECTOR pos;
	    public int param;
	    public int param2;
        public int content_length;
        public IMsgContent content;
    };
    public interface IMsgContent
    {

    }
    /// <summary>
    /// 角色接口类
    /// </summary>
    public class GPlayerBase
    {
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static string GetName(IntPtr p);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static int GetLevel(IntPtr p);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static int GetHP(IntPtr p);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static int GetMP(IntPtr p);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static int GetMaxHP(IntPtr p);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static int GetMaxMP(IntPtr p);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static float GetSpeed(IntPtr p);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static float GetCrit(IntPtr p);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static int GetMinDamage(IntPtr p);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static int GetMaxDamage(IntPtr p);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static int GetAttack(IntPtr p);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static int GetDefense(IntPtr p);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static int GetArmor(IntPtr p);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static int GetResistance(IntPtr p, int index);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static float GetAttackRange(IntPtr p);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static int GetAntiCrit(IntPtr p);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static float GetAntiCritDamage(IntPtr p);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static int GetSkillAttackRate(IntPtr p);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static int GetSkillArmorRate(IntPtr p);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static int GetSkillBaseLevel(IntPtr p, int skillid);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static int GetSkillTotalLevel(IntPtr p, int skillid);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static int GetMapId(IntPtr p);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static float GetPosX(IntPtr p);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static float GetPosY(IntPtr p);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static float GetPosZ(IntPtr p);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static int GetCultivation(IntPtr p);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static int GetCircleMemberCnt(IntPtr p);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void SetLevel(IntPtr p, int v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void SetHP(IntPtr p, int v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void SetMP(IntPtr p, int v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void SetMaxHP(IntPtr p, int v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void SetMaxMP(IntPtr p, int v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void SetSpeed(IntPtr p, float v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void SetCrit(IntPtr p, int rate, float damage);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void SetDamage(IntPtr p, int low, int high);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void SetAttack(IntPtr p, int v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void SetDefense(IntPtr p, int v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void SetArmor(IntPtr p, int v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void SetResistance(IntPtr p, int index, int v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void SetAttackRange(IntPtr p, float v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void SetAntiCrit(IntPtr p, int crit, float damage);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void SetSkillRate(IntPtr p, int attack, int armor);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void SetAntiInvisibleRate(IntPtr p, int v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void AddHP(IntPtr p, int v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void AddMP(IntPtr p, int v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void AddDefense(IntPtr p, int v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void AddAttack(IntPtr p, int v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void AddArmor(IntPtr p, int v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void AddDamage(IntPtr p, int v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void AddResistance(IntPtr p, int index, int v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void AddCrit(IntPtr p, int rate, float damage);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void AddSpeed(IntPtr p, float v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void AddAntiCrit(IntPtr p, int crit, float damage);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void AddSkillRate(IntPtr p, int attack, float armor);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void AddAttackRange(IntPtr p, float v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void AddScaleHP(IntPtr p, int v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void AddScaleMP(IntPtr p, int v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void AddScaleDefense(IntPtr p, int v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void AddScaleAttack(IntPtr p, int v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void AddScaleArmor(IntPtr p, int v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void AddScaleDamage(IntPtr p, int v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void AddScaleSpeed(IntPtr p, int v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void AddScaleResistance(IntPtr p, int index, int v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void AddReputation(IntPtr p, int index, int rep);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void AddSkillProficiency(IntPtr p, int id, int add);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void AddTransformSkill(IntPtr p, int id, int level);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void Say(IntPtr p, string s);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void BroadcastMsg(IntPtr p, string s, sbyte channel);
        private IntPtr nativePtr = new IntPtr();
        /// <summary>
        /// 取得角色名称
        /// </summary>
        /// <returns>角色名称</returns>
        protected string GetName()
        {
            return GetName(nativePtr);
        }
        /// <summary>
        /// 取得角色等级
        /// </summary>
        /// <returns>等级</returns>
        protected int GetLevel()
        {
            return GetLevel(nativePtr);
        }
        /// <summary>
        /// 取得角色血量
        /// </summary>
        /// <returns></returns>
        protected int GetHP()
        {
            return GetHP(nativePtr);
        }
        protected int GetMP()
        {
            return GetMP(nativePtr);
        }
        protected int GetMaxHP()
        {
            return GetMaxHP(nativePtr);
        }
        protected int GetMaxMP()
        {
            return GetMaxMP(nativePtr);
        }
        protected float GetSpeed()
        {
            return GetSpeed(nativePtr);
        }
        protected float GetCrit()
        {
            return GetCrit(nativePtr);
        }
        protected int GetMinDamage()
        {
            return GetMinDamage(nativePtr);
        }
        protected int GetMaxDamage()
        {
            return GetMaxDamage(nativePtr);
        }
        protected int GetAttack()
        {
            return GetAttack(nativePtr);
        }
        protected int GetDefense()
        {
            return GetDefense(nativePtr);
        }
        protected int GetArmor()
        {
            return GetArmor(nativePtr);
        }
        protected int GetResistance(int index)
        {
            return GetResistance(nativePtr,index);
        }
        protected float GetAttackRange()
        {
            return GetAttackRange(nativePtr);
        }
        protected int GetAntiCrit()
        {
            return GetAntiCrit(nativePtr);
        }
        protected float GetAntiCritDamage()
        {
            return GetAntiCritDamage(nativePtr);
        }
        protected int GetSkillAttackRate()
        {
            return GetSkillAttackRate(nativePtr);
        }
        protected int GetSkillArmorRate()
        {
            return GetSkillArmorRate(nativePtr);
        }
        protected int GetSkillBaseLevel(int skillid)
        {
            return GetSkillBaseLevel(nativePtr,skillid);
        }
        protected int GetSkillTotalLevel(int skillid)
        {
            return GetSkillTotalLevel(nativePtr,skillid);
        }
        /// <summary>
        /// 取得角色当前所在地图标识
        /// </summary>
        /// <returns>标识</returns>
        protected int GetMapId()
        {
            return GetMapId(nativePtr);
        }
        /// <summary>
        /// 取得角色当前座标X
        /// </summary>
        /// <returns>座标X</returns>
        protected float GetPosX()
        {
            return GetPosX(nativePtr);
        }
        /// <summary>
        /// 取得角色当前座标Y
        /// </summary>
        /// <returns>座标Y</returns>
        protected float GetPosY()
        {
            return GetPosY(nativePtr);
        }
        /// <summary>
        /// 取得角色当前座标Z
        /// </summary>
        /// <returns>座标Z</returns>
        protected float GetPosZ()
        {
            return GetPosZ(nativePtr);
        }
        protected int GetCultivation()
        {
            return GetCultivation(nativePtr);
        }
        protected int GetCircleMemberCnt()
        {
            return GetCircleMemberCnt(nativePtr);
        }
        protected void SetLevel(int v)
        {
            SetLevel(nativePtr, v);
        }
        protected void SetHP(int v)
        {
            SetHP(nativePtr, v);
        }
        protected void SetMP(int v)
        {
            SetMP(nativePtr, v);
        }
        protected void SetMaxHP(int v)
        {
            SetMaxHP(nativePtr, v);
        }
        protected void SetMaxMP(int v)
        {
            SetMaxMP(nativePtr, v);
        }
        protected void SetSpeed(float v)
        {
            SetSpeed(nativePtr, v);
        }
        protected void SetCrit(int rate, float damage)
        {
            SetCrit(nativePtr, rate, damage);
        }
        protected void SetDamage(int low, int high)
        {
            SetDamage(nativePtr, low, high);
        }
        protected void SetAttack(int v)
        {
            SetAttack(nativePtr, v);
        }
        protected void SetDefense(int v)
        {
            SetDefense(nativePtr, v);
        }
        protected void SetArmor(int v)
        {
            SetArmor(nativePtr, v);
        }
        protected void SetResistance(int index, int v)
        {
            SetResistance(nativePtr, index, v);
        }
        protected void SetAttackRange(float v)
        {
            SetAttackRange(nativePtr, v);
        }
        protected void SetAntiCrit(int crit, float damage)
        {
            SetAntiCrit(nativePtr, crit, damage);
        }
        protected void SetSkillRate(int attack, int armor)
        {
            SetSkillRate(nativePtr, attack, armor);
        }
        protected void SetAntiInvisibleRate(int v)
        {
            SetAntiInvisibleRate(nativePtr, v);
        }
        protected void AddHP(int v)
        {
            AddHP(nativePtr, v);
        }
        protected void AddMP(int v)
        {
            AddMP(nativePtr, v);
        }
        protected void AddDefense(int v)
        {
            AddDefense(nativePtr, v);
        }
        protected void AddAttack(int v)
        {
            AddAttack(nativePtr, v);
        }
        protected void AddArmor(int v)
        {
            AddArmor(nativePtr, v);
        }
        protected void AddDamage(int v)
        {
            AddDamage(nativePtr, v);
        }
        protected void AddResistance(int index, int v)
        {
            AddResistance(nativePtr, index, v);
        }
        protected void AddCrit(int rate, float damage)
        {
            AddCrit(nativePtr, rate, damage);
        }
        protected void AddSpeed(float v)
        {
            AddSpeed(nativePtr, v);
        }
        protected void AddAntiCrit(int crit, float damage)
        {
            AddAntiCrit(nativePtr, crit, damage);
        }
        protected void AddSkillRate(int attack, float armor)
        {
            AddSkillRate(nativePtr, attack, armor);
        }
        protected void AddAttackRange(float v)
        {
            AddAttackRange(nativePtr, v);
        }
        protected void AddScaleHP(int v)
        {
            AddScaleHP(nativePtr, v);
        }
        protected void AddScaleMP(int v)
        {
            AddScaleMP(nativePtr, v);
        }
        protected void AddScaleDefense(int v)
        {
            AddScaleDefense(nativePtr, v);
        }
        protected void AddScaleAttack(int v)
        {
            AddScaleAttack(nativePtr, v);
        }
        protected void AddScaleArmor(int v)
        {
            AddScaleArmor(nativePtr, v);
        }
        protected void AddScaleDamage(int v)
        {
            AddScaleDamage(nativePtr, v);
        }
        protected void AddScaleSpeed(int v)
        {
            AddScaleSpeed(nativePtr, v);
        }
        protected void AddScaleResistance(int index, int v)
        {
            AddScaleResistance(nativePtr, index, v);
        }
        protected void AddReputation(int index, int rep)
        {
            AddReputation(nativePtr, index, rep);
        }
        protected void AddSkillProficiency(int id, int add)
        {
            AddSkillProficiency(nativePtr, id, add);
        }
        protected void AddTransformSkill(int id, int level)
        {
            AddTransformSkill(nativePtr, id, level);
        }
        /// <summary>
        /// 发送聊天文字
        /// </summary>
        /// <param name="s">文字内容</param>
        protected void Say(string s)
        {
            Say(nativePtr, s);
        }
        /// <summary>
        /// 发送广播信息
        /// </summary>
        /// <param name="s">信息内容</param>
        /// <param name="channel">频道类型（0普通，1世界，2组队，3帮派，4密语，9广播）</param>
        protected void BroadcastMsg(string s, sbyte channel)
        {
            BroadcastMsg(nativePtr, s, channel);
        }
    }
}
