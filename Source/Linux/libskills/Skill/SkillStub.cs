using System;
using System.Text;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace SKILL
{
    /// <summary>
    /// 技能实例接口
    /// </summary>
    public class GSkillStub : IDisposable
    {
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static IntPtr Constructor(GSkillStub stub, int id);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void Deconstructor(IntPtr p);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void SetOccupation(IntPtr p,int v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void SetMaxLevel(IntPtr p,int v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void SetMaxLearn(IntPtr p,int v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void SetEventFlag(IntPtr p,int v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void SetSPCost(IntPtr p,int v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void SetRebornCount(IntPtr p,int v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void SetType(IntPtr p, int v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void SetTimeType(IntPtr p,int v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void SetTargetType(IntPtr p,int v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void SetRangeType(IntPtr p,int v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void SetDoEnchant(IntPtr p,bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void SetDoBless(IntPtr p,bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void SetAutoAttack(IntPtr p,bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void SetAllowForm(IntPtr p,int v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void SetCreditType(IntPtr p,int v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void SetClearMask(IntPtr p,int v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void SetSkillLimit(IntPtr p,int v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void SetSkillElemsNum(IntPtr p,int v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void SetSkillElemsFactor(IntPtr p,float v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void SetSerialSkill(IntPtr p,int v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void SetCharge(IntPtr p,int v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void SetChargeDist(IntPtr p,float v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void SetSucceedSkillColor(IntPtr p,int v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void SetSucceedSkillColorNum(IntPtr p,int v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void SetComboSkill(IntPtr p,int v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void SetNeedItem(IntPtr p,bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void SetItem1Id(IntPtr p,int v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void SetItem1Num(IntPtr p,int v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void SetItem2Id(IntPtr p,int v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void SetItem2Num(IntPtr p,int v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void SetItemRelation(IntPtr p,int v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void SetWeaponLimit(IntPtr p,int v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void SetAction(IntPtr p, int index, string v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void SetName(IntPtr p, string v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void SetNativeName(IntPtr p, string v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void SetIcon(IntPtr p, string v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void SetTalent(IntPtr p,int index,int v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void SetTalentSize(IntPtr p,int v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void SetTalentType(IntPtr p,int v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void SetUseProficiency(IntPtr p,bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void SetIncProficiency(IntPtr p,int v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void SetPreSkillNum(IntPtr p,int v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void SetCycle(IntPtr p,bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void SetCycleMode(IntPtr p,int v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void SetSetCycleGfx(IntPtr p, string v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void SetSkillClass(IntPtr p,int v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void SetGuide(IntPtr p,bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void SetSummonId(IntPtr p,int v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void SetTrigger(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void SetConbuttonSub(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void SetBabySkill(IntPtr p, bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void SetCastInPreSkill(IntPtr p,bool v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void SetPreCastSkillId(IntPtr p,int v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void SetDarkLightType(IntPtr p,int v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void SetFollowSkill(IntPtr p,int v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void SetTargetCnt(IntPtr p, int v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void SetExcludeMonsterCnt(IntPtr p, int v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void AddState(IntPtr p, IntPtr v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        protected extern static int GetOccupTransform(int occup);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        protected extern static int norm(float f);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        protected extern static int zrand(int n);
        private IntPtr nativePtr = new IntPtr();
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="id">技能标识</param>
        public GSkillStub(int id)
        {
            this.nativePtr = Constructor(this, id);
        }
        /// <summary>
        /// 析构函数
        /// </summary>
        ~GSkillStub()
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
        /// 所需职业
        /// </summary>
        protected int occupation
        {
            set { SetOccupation(nativePtr, value); }
        }
        /// <summary>
        /// 最高等级 
        /// </summary>
        protected int maxlevel
        {
            set { SetMaxLevel(nativePtr, value); }
        }
        /// <summary>
        /// 最高可以学习等级
        /// </summary>
        protected int maxlearn
        {
            set { SetMaxLearn(nativePtr, value); }
        }
        protected int eventflag
        {
            set { SetEventFlag(nativePtr, value); }
        }
        protected int spcost
        {
            set { SetSPCost(nativePtr, value); }
        }
        /// <summary>
        /// 所需飞升数
        /// </summary>
        protected int reborncount
        {
            set { SetRebornCount(nativePtr, value); }
        }
        protected int type
        {
            set { SetType(nativePtr, value); }
        }
        protected int timetype
        {
            set { SetTimeType(nativePtr, value); }
        }
        protected int targettype
        {
            set { SetTargetType(nativePtr, value); }
        }
        protected int rangetype
        {
            set { SetRangeType(nativePtr, value); }
        }
        protected bool doenchant
        {
            set { SetDoEnchant(nativePtr, value); }
        }
        protected bool dobless
        {
            set { SetDoBless(nativePtr, value); }
        }
        protected bool autoattack
        {
            set { SetAutoAttack(nativePtr, value); }
        }
        protected int allowform
        {
            set { SetAllowForm(nativePtr, value); }
        }
        protected int credittype
        {
            set { SetCreditType(nativePtr, value); }
        }
        protected int clearmask
        {
            set { SetClearMask(nativePtr, value); }
        }
        protected int skill_limit
        {
            set { SetSkillLimit(nativePtr, value); }
        }
        protected int skillelemsnum
        {
            set { SetSkillElemsNum(nativePtr, value); }
        }
        protected float skillelemsfactor
        {
            set { SetSkillElemsFactor(nativePtr, value); }
        }
        protected int serialskill
        {
            set { SetSerialSkill(nativePtr, value); }
        }
        protected int charge
        {
            set { SetCharge(nativePtr, value); }
        }
        protected float chargedist
        {
            set { SetChargeDist(nativePtr, value); }
        }
        protected int succeedskillcolor
        {
            set { SetSucceedSkillColor(nativePtr, value); }
        }
        protected int succeedskillcolornum
        {
            set { SetSucceedSkillColorNum(nativePtr, value); }
        }
        protected int comboskill
        {
            set { SetComboSkill(nativePtr, value); }
        }
        /// <summary>
        /// 需要物品
        /// </summary>
        protected bool need_item
        {
            set { SetNeedItem(nativePtr, value); }
        }
        /// <summary>
        /// 所需物品一标识
        /// </summary>
        protected int item1_id
        {
            set { SetItem1Id(nativePtr, value); }
        }
        /// <summary>
        /// 所需物品一数量
        /// </summary>
        protected int item1_num
        {
            set { SetItem1Num(nativePtr, value); }
        }
        /// <summary>
        /// 所需物品二标识
        /// </summary>
        protected int item2_id
        {
            set { SetItem2Id(nativePtr, value); }
        }
        /// <summary>
        /// 所需物品二数量
        /// </summary>
        protected int item2_num
        {
            set { SetItem2Num(nativePtr, value); }
        }
        protected int item_relation
        {
            set { SetItemRelation(nativePtr, value); }
        }
        /// <summary>
        /// 所需武器
        /// </summary>
        protected int weapon_limit
        {
            set { SetWeaponLimit(nativePtr, value); }
        }
        /// <summary>
        /// 动作名称（客户端用）
        /// </summary>
        /// <param name="index">动作索引</param>
        /// <param name="v">动作名称</param>
        protected void SetAction(int index,string v)
        {
            SetAction(nativePtr, index, v);
        }
        /// <summary>
        /// 技能名称
        /// </summary>
        protected string nativename
        {
            set { SetNativeName(nativePtr, value); }
        }
        /// <summary>
        /// 技能图标
        /// </summary>
        protected string icon
        {
            set { SetIcon(nativePtr, value); }
        }
        /// <summary>
        /// 技能名称
        /// </summary>
        protected string name
        {
            set { SetName(nativePtr, value); }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="index"></param>
        /// <param name="v"></param>
        protected void SetTalent(int index,int v)
        {
            SetTalent(nativePtr,index, v);
        }
        protected int talent_size
        {
            set { SetTalentSize(nativePtr, value); }
        }
        protected int talent_type
        {
            set { SetTalentType(nativePtr, value); }
        }
        protected bool use_proficiency
        {
            set { SetUseProficiency(nativePtr, value); }
        }
        protected int inc_proficiency
        {
            set { SetIncProficiency(nativePtr, value); }
        }
        protected int preskillnum
        {
            set { SetPreSkillNum(nativePtr, value); }
        }
        protected bool cycle
        {
            set { SetCycle(nativePtr, value); }
        }
        protected int cyclemode
        {
            set { SetCycleMode(nativePtr, value); }
        }
        protected string cyclegfx
        {
            set { SetSetCycleGfx(nativePtr, value); }
        }
        protected int skill_class
        {
            set { SetSkillClass(nativePtr, value); }
        }
        protected bool guide
        {
            set { SetGuide(nativePtr, value); }
        }
        protected int summon_id
        {
            set { SetSummonId(nativePtr, value); }
        }
        protected bool trigger
        {
            set { SetTrigger(nativePtr, value); }
        }
        protected bool conbutton_sub
        {
            set { SetConbuttonSub(nativePtr, value); }
        }
        protected bool isBabySkill
        {
            set { SetBabySkill(nativePtr, value); }
        }
        protected bool castInPreSkill
        {
            set { SetCastInPreSkill(nativePtr, value); }
        }
        protected int preCastSkillId
        {
            set { SetPreCastSkillId(nativePtr, value); }
        }
        protected int darkLightType
        {
            set { SetDarkLightType(nativePtr, value); }
        }
        protected int followskill
        {
            set { SetFollowSkill(nativePtr, value); }
        }
        protected int targetcnt
        {
            set { SetTargetCnt(nativePtr, value); }
        }
        protected int excludemonstercnt
        {
            set { SetExcludeMonsterCnt(nativePtr, value); }
        }
        protected void AddState(GState v)
        {
            AddState(nativePtr, v.GetNativePtr());
        }
        /// <summary>
        /// 执行时间
        /// </summary>
        /// <param name="skill">技能数据对象</param>
        /// <returns>时间（毫秒）</returns>
        public virtual int GetExecutetime(GSkill skill)
        {
		    return 0;
        }
        /// <summary>
        /// 冷却时间
        /// </summary>
        /// <param name="skill">技能数据对象</param>
        /// <returns>时间（毫秒）</returns>
        public virtual int GetCooldowntime(GSkill skill)
        {
		    return 0;
        }
		public virtual int GetEnmity(GSkill skill)
        {
            return 0;
        }
        /// <summary>
        /// 所需角色等级
        /// </summary>
        /// <param name="level">技能等级</param>
        /// <returns>角色等级</returns>
		public virtual int GetRequiredLevel(int level)
        {
            return 0;
        }
		public virtual int GetRequiredProficiency(int level)
        {
            return 0;
        }
		public virtual float GetRadius(GSkill skill)
        {
            return 0.0f;
        }
		public virtual float GetAttackdistance(GSkill skill)
        {
            return 0.0f;
        }
		public virtual float GetAngle(GSkill skill)
        {
            return 0.0f;
        }
        /// <summary>
        /// 取得祈祷距离
        /// </summary>
        /// <param name="skill">技能数据对象</param>
        /// <returns></returns>
		public virtual float GetPraydistance(GSkill skill)
        {
            return 0.0f;
        }
        /// <summary>
        /// 取得释放距离
        /// </summary>
        /// <param name="skill">技能数据对象</param>
        /// <returns></returns>
		public virtual float GetCastdistance(GSkill skill)
        {
            return 0.0f;
        }
        /// <summary>
        /// 取得生效距离
        /// </summary>
        /// <param name="skill">技能数据对象</param>
        /// <returns></returns>
		public virtual float GetEffectdistance(GSkill skill)
        {
            return 0.0f;
        }
        /// <summary>
        /// 所需MP值
        /// </summary>
        /// <param name="skill">技能数据对象</param>
        /// <returns>MP数量</returns>
		public virtual float GetMpcost(GSkill skill)
        {
            return 0.0f;
        }
		public virtual int GetCoverage(GSkill skill)
        {
            return 20;
        }
        /// <summary>
        /// 技能状态攻击处理
        /// </summary>
        /// <param name="skill">技能数据对象</param>
        /// <returns></returns>
		public virtual bool StateAttack(GSkill skill)
        {
		    return false;
        }
        /// <summary>
        /// 技能效果处理
        /// </summary>
        /// <param name="skill">技能数据对象</param>
        /// <returns></returns>
		public virtual bool TakeEffect(GSkill skill)
        {
		    return false;
        }
        /// <summary>
        /// 技能祝福处理
        /// </summary>
        /// <param name="skill">技能数据对象</param>
        /// <returns></returns>
		public virtual bool BlessMe(GSkill skill)
        {
		    return false;
        }
		public virtual int GetCreditCost(int level)
        {
            return 0;
        }
		public virtual float GetDropRate(GSkill skill)
        {
            return 0.0f;
        }
		public virtual int GetSkillElem(int index)
        {
            return 0;
        }
		public virtual int GetComboSkillCapacity(int index)
        {
            return 0;
        }
		public virtual bool CheckDarkLightValue(GSkill skill)
        {
		    return true;
        }
        /// <summary>
        /// 所需技能标识
        /// </summary>
        /// <param name="index">标识索引</param>
        /// <returns>技能标识</returns>
		public virtual int GetPreSkillID(int index)
        {
            return 0;
        }
        /// <summary>
        /// 所需技能级别
        /// </summary>
        /// <param name="index">等级索引</param>
        /// <returns>技能级别</returns>
		public virtual int GetPreSkillSP(int index)
        {
            return 0;
        }
        /// <summary>
        /// 所需封神经验
        /// </summary>
        /// <param name="level">技能等级</param>
        /// <returns>经验值</returns>
		public virtual int GetDivinityExp(int level)
        {
            return 0;
        }
        /// <summary>
        /// 所需封神级别
        /// </summary>
        /// <param name="level">技能等级</param>
        /// <returns>封神等级</returns>
		public virtual int GetDivinityLevel(int level)
        {
            return 0;
        }
        /// <summary>
        /// 所需DP值
        /// </summary>
        /// <param name="skill">技能数据对象</param>
        /// <returns>DP数量</returns>
		public virtual int GetDpcost(GSkill skill)
        {
            return 0;
        }
        /// <summary>
        /// 所需HP值
        /// </summary>
        /// <param name="skill">技能数据对象</param>
        /// <returns>HP数量</returns>
		public virtual int GetHpcost(GSkill skill)
        {
            return 0;
        }
		public virtual int GetInkcost(GSkill skill)
        {
            return 0;
        }
        public virtual int GetExcludemonsterTid(int index)
        {
            return 0;
        }
        /// <summary>
        /// 技能初始回调函数（用于初始化技能实例）
        /// </summary>
        /// <returns>是否成功</returns>
        static bool Init()
        {
            return GSkillInstance.Init();
        }
        /// <summary>
        /// 浮点转整型
        /// </summary>
        /// <param name="x">浮点数</param>
        /// <returns>整型数</returns>
        public static int INT(double x)
        {
            return (int)x;
        }
        /// <summary>
        /// 浮点转整型
        /// </summary>
        /// <param name="x">浮点数</param>
        /// <returns>整型数</returns>
        public static int INT(float x)
        {
            return (int)x;
        }
        /// <summary>
        /// 浮点转整型
        /// </summary>
        /// <param name="x">浮点数</param>
        /// <returns>整型数</returns>
        public static int D2INT(double x)
        {
            return (int)x;
        }
        /// <summary>
        /// 浮点转整型
        /// </summary>
        /// <param name="x">浮点数</param>
        /// <returns>整型数</returns>
        public static int D2INT(float x)
        {
            return (int)x;
        }
        /// <summary>
        /// 布尔值转整型
        /// </summary>
        /// <param name="x">布尔值</param>
        /// <returns>整型数</returns>
        public static int D2INT(bool x)
        {
            return x != false?1:0;
        }
    }
}
