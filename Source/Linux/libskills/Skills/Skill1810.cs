using System;
using System.Text;

namespace SKILL
{
	public class GSkill1810Stub : GSkillStub
	{
		public class GState1 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 9750;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();

				player.SetPray(1);
			}
			public override bool Cancel(GSkill skill)
			{
				return true;
			}
		}
		public class GState2 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 250;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();

				player.SetPerform(1);
			}
		}
		public GSkill1810Stub()
			: base(1810)
		{
			occupation = 152;
			maxlevel = 10;
			maxlearn = 3;
			eventflag = 0;
			spcost = 0;
			reborncount = 0;
			type = 2;
			timetype = 0;
			targettype = 0;
			rangetype = 5;
			doenchant = true;
			dobless = false;
			autoattack = false;
			allowform = 7;
			credittype = 6;
			clearmask = 8;
			skill_limit = 0;
			skillelemsnum = 0;
			skillelemsfactor = 0.000000f;
			serialskill = 0;
			charge = 0;
			chargedist = 0.000000f;
			succeedskillcolor = 1;
			succeedskillcolornum = 1;
			comboskill = 0;
			need_item = false;
			item1_id = -1;
			item1_num = 0;
			item2_id = -1;
			item2_num = 0;
			item_relation = 0;
			weapon_limit = -1;
			SetAction(0,"鬼王宗_夫妻技能_天涯比翼");
			SetAction(1,"青云门_夫妻技能_天涯比翼");
			SetAction(2,"鬼王宗_夫妻技能_天涯比翼");
			SetAction(3,"合欢派_夫妻技能_天涯比翼");
			SetAction(4,"天音寺_夫妻技能_天涯比翼");
			SetAction(5,"鬼道_夫妻技能_天涯比翼");
			SetAction(6,"焚香谷_夫妻技能_天涯比翼");
			SetAction(7,"兽神_夫妻技能_天涯比翼");
			SetAction(8,"狐妖_夫妻技能_天涯比翼");
			SetAction(9,"轩辕_夫妻技能_天涯比翼");
			SetAction(10,"怀光_夫妻技能_天涯比翼");
			SetAction(11,"太昊_夫妻技能_天涯比翼");
			SetAction(12,"天华_夫妻技能_天涯比翼");
			SetAction(13,"灵夙_夫妻技能_天涯比翼");
			SetAction(14,"英招_夫妻技能_天涯比翼");
			SetAction(15,"武器大师_夫妻技能_天涯比翼");
			SetAction(16,"元素大师_夫妻技能_天涯比翼");
			SetAction(17,"天音寺_夫妻技能_天涯比翼");
			SetAction(18,"鬼王宗_骑乘_夫妻技能_天涯比翼");
			SetAction(19,"青云门_骑乘_夫妻技能_天涯比翼");
			SetAction(20,"鬼王宗_骑乘_夫妻技能_天涯比翼");
			SetAction(21,"合欢派_骑乘_夫妻技能_天涯比翼");
			SetAction(22,"天音寺_骑乘_夫妻技能_天涯比翼");
			SetAction(23,"鬼道_骑乘_夫妻技能_天涯比翼");
			SetAction(24,"焚香谷_骑乘_夫妻技能_天涯比翼");
			SetAction(25,"兽神_骑乘_夫妻技能_天涯比翼");
			SetAction(26,"狐妖_骑乘_夫妻技能_天涯比翼");
			SetAction(27,"轩辕_骑乘_夫妻技能_天涯比翼");
			SetAction(28,"怀光_骑乘_夫妻技能_天涯比翼");
			SetAction(29,"太昊_骑乘_夫妻技能_天涯比翼");
			SetAction(30,"天华_骑乘_夫妻技能_天涯比翼");
			name = "天涯比翼";
			nativename = "天涯比翼";
			icon = "天涯比翼.dds";
			SetTalent(0,0);
			SetTalent(1,0);
			SetTalent(2,0);
			SetTalent(3,0);
			SetTalent(4,0);
			SetTalent(5,0);
			SetTalent(6,0);
			SetTalent(7,0);
			talent_size = 0;
			talent_type = 0;
			use_proficiency = false;
			inc_proficiency = 0;
			preskillnum = 0;
			cycle = false;
			cyclemode = 0;
			cyclegfx = "";
			skill_class = -2;
			guide = false;
			summon_id = 0;
			trigger = false;
			conbutton_sub = false;
			isBabySkill = false;
			castInPreSkill = false;
			preCastSkillId = 0;
			darkLightType = 0;
			followskill = 0;
			targetcnt = 0;
			excludemonstercnt = 0;

			AddState(new GState1());
			AddState(new GState2());
		}
		public override int GetExecutetime(GSkill skill)
		{
			return 10000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (skill_level == 4)?10800000:(118800000 - 32400000 * skill_level)/**/;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={30,30,30};return array[level-1];
		}
		public override float GetPraydistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return player_range;
		}
		public override float GetCastdistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return player_range;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetJumptospouse(true);
			return true;
		}
		public override int GetCreditCost(int level)
		{
			int[] array={1200,3600,7200};return array[level-1];
		}
	}
	public class GSkill1810 : GSkill
	{
		public GSkill1810()
			: base(1810)
		{
			
		}
	}
	public class GSkill1811Stub : GSkillStub
	{
		public class GState1 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 625;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();

				player.SetPray(1);
			}
		}
		public class GState2 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 375;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();

				player.SetPerform(1);
			}
		}
		public GSkill1811Stub()
			: base(1811)
		{
			occupation = 152;
			maxlevel = 10;
			maxlearn = 6;
			eventflag = 0;
			spcost = 0;
			reborncount = 0;
			type = 2;
			timetype = 0;
			targettype = 0;
			rangetype = 8;
			doenchant = true;
			dobless = false;
			autoattack = false;
			allowform = 7;
			credittype = 6;
			clearmask = 8;
			skill_limit = 0;
			skillelemsnum = 0;
			skillelemsfactor = 0.000000f;
			serialskill = 0;
			charge = 0;
			chargedist = 0.000000f;
			succeedskillcolor = 1;
			succeedskillcolornum = 1;
			comboskill = 0;
			need_item = false;
			item1_id = -1;
			item1_num = 0;
			item2_id = -1;
			item2_num = 0;
			item_relation = 0;
			weapon_limit = -1;
			SetAction(0,"鬼王宗_夫妻技能_伉俪情深");
			SetAction(1,"青云门_夫妻技能_伉俪情深");
			SetAction(2,"鬼王宗_夫妻技能_伉俪情深");
			SetAction(3,"合欢派_夫妻技能_伉俪情深");
			SetAction(4,"天音寺_夫妻技能_伉俪情深");
			SetAction(5,"鬼道_夫妻技能_伉俪情深");
			SetAction(6,"焚香谷_夫妻技能_伉俪情深");
			SetAction(7,"兽神_夫妻技能_伉俪情深");
			SetAction(8,"狐妖_夫妻技能_伉俪情深");
			SetAction(9,"轩辕_夫妻技能_伉俪情深");
			SetAction(10,"怀光_夫妻技能_伉俪情深");
			SetAction(11,"太昊_夫妻技能_伉俪情深");
			SetAction(12,"天华_夫妻技能_伉俪情深");
			SetAction(13,"灵夙_夫妻技能_伉俪情深");
			SetAction(14,"英招_夫妻技能_伉俪情深");
			SetAction(15,"武器大师_夫妻技能_伉俪情深");
			SetAction(16,"元素大师_夫妻技能_伉俪情深");
			SetAction(17,"天音寺_夫妻技能_伉俪情深");
			SetAction(18,"鬼王宗_骑乘_夫妻技能_伉俪情深");
			SetAction(19,"青云门_骑乘_夫妻技能_伉俪情深");
			SetAction(20,"鬼王宗_骑乘_夫妻技能_伉俪情深");
			SetAction(21,"合欢派_骑乘_夫妻技能_伉俪情深");
			SetAction(22,"天音寺_骑乘_夫妻技能_伉俪情深");
			SetAction(23,"鬼道_骑乘_夫妻技能_伉俪情深");
			SetAction(24,"焚香谷_骑乘_夫妻技能_伉俪情深");
			SetAction(25,"兽神_骑乘_夫妻技能_伉俪情深");
			SetAction(26,"狐妖_骑乘_夫妻技能_伉俪情深");
			SetAction(27,"轩辕_骑乘_夫妻技能_伉俪情深");
			SetAction(28,"怀光_骑乘_夫妻技能_伉俪情深");
			SetAction(29,"太昊_骑乘_夫妻技能_伉俪情深");
			SetAction(30,"天华_骑乘_夫妻技能_伉俪情深");
			name = "伉俪情深";
			nativename = "伉俪情深";
			icon = "伉俪情深.dds";
			SetTalent(0,0);
			SetTalent(1,0);
			SetTalent(2,0);
			SetTalent(3,0);
			SetTalent(4,0);
			SetTalent(5,0);
			SetTalent(6,0);
			SetTalent(7,0);
			talent_size = 0;
			talent_type = 0;
			use_proficiency = false;
			inc_proficiency = 0;
			preskillnum = 1;
			cycle = false;
			cyclemode = 0;
			cyclegfx = "";
			skill_class = -2;
			guide = false;
			summon_id = 0;
			trigger = false;
			conbutton_sub = false;
			isBabySkill = false;
			castInPreSkill = false;
			preCastSkillId = 0;
			darkLightType = 0;
			followskill = 0;
			targetcnt = 0;
			excludemonstercnt = 0;

			AddState(new GState1());
			AddState(new GState2());
		}
		public override int GetExecutetime(GSkill skill)
		{
			return 1000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			return 1800000;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={30,30,30,30,30,30};return array[level-1];
		}
		public override float GetPraydistance(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (2 * skill_level + 14);
		}
		public override float GetCastdistance(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (2 * skill_level + 12);
		}
		public override float GetEffectdistance(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (2 * skill_level + 16);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_hp = player.GetHp();
			int				player_mp = player.GetMp();
			int				skill_level = skill.GetLevel();

			victim.SetProbability(120.0f);
			victim.SetTime(100.0f);
			victim.SetRatio(0.0f);
			victim.SetBuffid(1);
			victim.SetAmount((player_hp * (skill_level * 0.6f)));
			victim.SetValue(0.0f);
			victim.SetHpgen(true);
			victim.SetProbability(120.0f);
			victim.SetTime(100.0f);
			victim.SetBuffid(1);
			victim.SetAmount((player_mp * (skill_level * 0.6f)));
			victim.SetValue(0.0f);
			victim.SetMpgen(true);
			victim.SetProbability(100.0f);
			victim.SetTime(60000.0f);
			victim.SetRatio((skill_level * 0.0501f));
			victim.SetBuffid(0);
			victim.SetIncskillaccu(true);
			return true;
		}
		public override int GetCreditCost(int level)
		{
			int[] array={1200,2400,3600,4800,6000,7200};return array[level-1];
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={1810};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={1};return array[index];
		}
	}
	public class GSkill1811 : GSkill
	{
		public GSkill1811()
			: base(1811)
		{
			
		}
	}
	public class GSkill1812Stub : GSkillStub
	{
		public class GState1 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 2925;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();

				player.SetPray(1);
			}
			public override bool Cancel(GSkill skill)
			{
				return true;
			}
		}
		public class GState2 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 75;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_hp = player.GetHp();

				player.SetHp((player_hp * 0.01f + 1.0f));
				player.SetPerform(1);
			}
		}
		public GSkill1812Stub()
			: base(1812)
		{
			occupation = 152;
			maxlevel = 10;
			maxlearn = 5;
			eventflag = 0;
			spcost = 0;
			reborncount = 0;
			type = 2;
			timetype = 0;
			targettype = 1;
			rangetype = 8;
			doenchant = true;
			dobless = false;
			autoattack = false;
			allowform = 7;
			credittype = 6;
			clearmask = 8;
			skill_limit = 0;
			skillelemsnum = 0;
			skillelemsfactor = 0.000000f;
			serialskill = 0;
			charge = 0;
			chargedist = 0.000000f;
			succeedskillcolor = 1;
			succeedskillcolornum = 1;
			comboskill = 0;
			need_item = false;
			item1_id = -1;
			item1_num = 0;
			item2_id = -1;
			item2_num = 0;
			item_relation = 0;
			weapon_limit = -1;
			SetAction(0,"鬼王宗_夫妻技能_再续前缘");
			SetAction(1,"青云门_夫妻技能_再续前缘");
			SetAction(2,"鬼王宗_夫妻技能_再续前缘");
			SetAction(3,"合欢派_夫妻技能_再续前缘");
			SetAction(4,"天音寺_夫妻技能_再续前缘");
			SetAction(5,"鬼道_夫妻技能_再续前缘");
			SetAction(6,"焚香谷_夫妻技能_再续前缘");
			SetAction(7,"兽神_夫妻技能_再续前缘");
			SetAction(8,"狐妖_夫妻技能_再续前缘");
			SetAction(9,"轩辕_夫妻技能_再续前缘");
			SetAction(10,"怀光_夫妻技能_再续前缘");
			SetAction(11,"太昊_夫妻技能_再续前缘");
			SetAction(12,"天华_夫妻技能_再续前缘");
			SetAction(13,"灵夙_夫妻技能_再续前缘");
			SetAction(14,"英招_夫妻技能_再续前缘");
			SetAction(15,"武器大师_夫妻技能_再续前缘");
			SetAction(16,"元素大师_夫妻技能_再续前缘");
			SetAction(17,"天音寺_夫妻技能_再续前缘");
			SetAction(18,"鬼王宗_骑乘_夫妻技能_再续前缘");
			SetAction(19,"青云门_骑乘_夫妻技能_再续前缘");
			SetAction(20,"鬼王宗_骑乘_夫妻技能_再续前缘");
			SetAction(21,"合欢派_骑乘_夫妻技能_再续前缘");
			SetAction(22,"天音寺_骑乘_夫妻技能_再续前缘");
			SetAction(23,"鬼道_骑乘_夫妻技能_再续前缘");
			SetAction(24,"焚香谷_骑乘_夫妻技能_再续前缘");
			SetAction(25,"兽神_骑乘_夫妻技能_再续前缘");
			SetAction(26,"狐妖_骑乘_夫妻技能_再续前缘");
			SetAction(27,"轩辕_骑乘_夫妻技能_再续前缘");
			SetAction(28,"怀光_骑乘_夫妻技能_再续前缘");
			SetAction(29,"太昊_骑乘_夫妻技能_再续前缘");
			SetAction(30,"天华_骑乘_夫妻技能_再续前缘");
			name = "再续前缘";
			nativename = "再续前缘";
			icon = "再续前缘.dds";
			SetTalent(0,0);
			SetTalent(1,0);
			SetTalent(2,0);
			SetTalent(3,0);
			SetTalent(4,0);
			SetTalent(5,0);
			SetTalent(6,0);
			SetTalent(7,0);
			talent_size = 0;
			talent_type = 0;
			use_proficiency = false;
			inc_proficiency = 0;
			preskillnum = 1;
			cycle = false;
			cyclemode = 0;
			cyclegfx = "";
			skill_class = -2;
			guide = false;
			summon_id = 0;
			trigger = false;
			conbutton_sub = false;
			isBabySkill = false;
			castInPreSkill = false;
			preCastSkillId = 0;
			darkLightType = 0;
			followskill = 0;
			targetcnt = 0;
			excludemonstercnt = 0;

			AddState(new GState1());
			AddState(new GState2());
		}
		public override int GetExecutetime(GSkill skill)
		{
			return 3000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (int)(((skill_level / 5.9f) * 0.5f + ((6 - skill_level))) * 3600000.0f);
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={30,30,30,30,30};return array[level-1];
		}
		public override float GetPraydistance(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (2 * skill_level + 14);
		}
		public override float GetCastdistance(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (2 * skill_level + 12);
		}
		public override float GetEffectdistance(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (2 * skill_level + 16);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetRatio(0.029999999f);
			victim.SetValue(0.2f);
			victim.SetSalvation(true);
			return true;
		}
		public override int GetCreditCost(int level)
		{
			int[] array={1200,2400,3600,4800,6000};return array[level-1];
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={1811};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={2};return array[index];
		}
	}
	public class GSkill1812 : GSkill
	{
		public GSkill1812()
			: base(1812)
		{
			
		}
	}
	public class GSkill1813Stub : GSkillStub
	{
		public class GState1 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 250;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();

				player.SetPray(1);
			}
		}
		public class GState2 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 750;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();

				player.SetPerform(1);
			}
		}
		public GSkill1813Stub()
			: base(1813)
		{
			occupation = 152;
			maxlevel = 10;
			maxlearn = 6;
			eventflag = 0;
			spcost = 0;
			reborncount = 0;
			type = 2;
			timetype = 0;
			targettype = 0;
			rangetype = 8;
			doenchant = true;
			dobless = false;
			autoattack = false;
			allowform = 7;
			credittype = 6;
			clearmask = 8;
			skill_limit = 0;
			skillelemsnum = 0;
			skillelemsfactor = 0.000000f;
			serialskill = 0;
			charge = 0;
			chargedist = 0.000000f;
			succeedskillcolor = 1;
			succeedskillcolornum = 1;
			comboskill = 0;
			need_item = false;
			item1_id = -1;
			item1_num = 0;
			item2_id = -1;
			item2_num = 0;
			item_relation = 0;
			weapon_limit = -1;
			SetAction(0,"鬼王宗_夫妻技能_永结同心");
			SetAction(1,"青云门_夫妻技能_永结同心");
			SetAction(2,"鬼王宗_夫妻技能_永结同心");
			SetAction(3,"合欢派_夫妻技能_永结同心");
			SetAction(4,"天音寺_夫妻技能_永结同心");
			SetAction(5,"鬼道_夫妻技能_永结同心");
			SetAction(6,"焚香谷_夫妻技能_永结同心");
			SetAction(7,"兽神_夫妻技能_永结同心");
			SetAction(8,"狐妖_夫妻技能_永结同心");
			SetAction(9,"轩辕_夫妻技能_永结同心");
			SetAction(10,"怀光_夫妻技能_永结同心");
			SetAction(11,"太昊_夫妻技能_永结同心");
			SetAction(12,"天华_夫妻技能_永结同心");
			SetAction(13,"灵夙_夫妻技能_永结同心");
			SetAction(14,"英招_夫妻技能_永结同心");
			SetAction(15,"武器大师_夫妻技能_永结同心");
			SetAction(16,"元素大师_夫妻技能_永结同心");
			SetAction(17,"天音寺_夫妻技能_永结同心");
			SetAction(18,"鬼王宗_骑乘_夫妻技能_永结同心");
			SetAction(19,"青云门_骑乘_夫妻技能_永结同心");
			SetAction(20,"鬼王宗_骑乘_夫妻技能_永结同心");
			SetAction(21,"合欢派_骑乘_夫妻技能_永结同心");
			SetAction(22,"天音寺_骑乘_夫妻技能_永结同心");
			SetAction(23,"鬼道_骑乘_夫妻技能_永结同心");
			SetAction(24,"焚香谷_骑乘_夫妻技能_永结同心");
			SetAction(25,"兽神_骑乘_夫妻技能_永结同心");
			SetAction(26,"狐妖_骑乘_夫妻技能_永结同心");
			SetAction(27,"轩辕_骑乘_夫妻技能_永结同心");
			SetAction(28,"怀光_骑乘_夫妻技能_永结同心");
			SetAction(29,"太昊_骑乘_夫妻技能_永结同心");
			SetAction(30,"天华_骑乘_夫妻技能_永结同心");
			name = "永结同心";
			nativename = "永结同心";
			icon = "永结同心.dds";
			SetTalent(0,0);
			SetTalent(1,0);
			SetTalent(2,0);
			SetTalent(3,0);
			SetTalent(4,0);
			SetTalent(5,0);
			SetTalent(6,0);
			SetTalent(7,0);
			talent_size = 0;
			talent_type = 0;
			use_proficiency = false;
			inc_proficiency = 0;
			preskillnum = 1;
			cycle = false;
			cyclemode = 0;
			cyclegfx = "";
			skill_class = -2;
			guide = false;
			summon_id = 0;
			trigger = false;
			conbutton_sub = false;
			isBabySkill = false;
			castInPreSkill = false;
			preCastSkillId = 0;
			darkLightType = 0;
			followskill = 0;
			targetcnt = 0;
			excludemonstercnt = 0;

			AddState(new GState1());
			AddState(new GState2());
		}
		public override int GetExecutetime(GSkill skill)
		{
			return 1000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			return 7200000;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={30,30,30,30,30,30};return array[level-1];
		}
		public override float GetPraydistance(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (2 * skill_level + 14);
		}
		public override float GetCastdistance(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (2 * skill_level + 12);
		}
		public override float GetEffectdistance(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (2 * skill_level + 16);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();

			victim.SetProbability(120.0f);
			victim.SetTime(3600000.0f);
			victim.SetRatio((skill_level * 0.01f));
			victim.SetBuffid(1);
			victim.SetValue(0.0f);
			victim.SetTongxin(true);
			return true;
		}
		public override int GetCreditCost(int level)
		{
			int[] array={1200,2400,3600,4800,6000,7200};return array[level-1];
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={1811};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={2};return array[index];
		}
	}
	public class GSkill1813 : GSkill
	{
		public GSkill1813()
			: base(1813)
		{
			
		}
	}
	public class GSkill1814Stub : GSkillStub
	{
		public class GState1 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 800;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();

				player.SetPray(1);
			}
		}
		public class GState2 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 200;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();

				player.SetPerform(1);
			}
		}
		public GSkill1814Stub()
			: base(1814)
		{
			occupation = 128;
			maxlevel = 99;
			maxlearn = 10;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 1;
			timetype = 0;
			targettype = 0;
			rangetype = 3;
			doenchant = true;
			dobless = false;
			autoattack = false;
			allowform = 0;
			credittype = 0;
			clearmask = 0;
			skill_limit = 0;
			skillelemsnum = 0;
			skillelemsfactor = 0.000000f;
			serialskill = 0;
			charge = 0;
			chargedist = 0.000000f;
			succeedskillcolor = 0;
			succeedskillcolornum = 0;
			comboskill = 0;
			need_item = false;
			item1_id = -1;
			item1_num = 0;
			item2_id = -1;
			item2_num = 0;
			item_relation = 0;
			weapon_limit = -1;
			SetAction(0,"");
			SetAction(1,"");
			SetAction(2,"");
			SetAction(3,"");
			SetAction(4,"");
			SetAction(5,"");
			SetAction(6,"");
			SetAction(7,"");
			SetAction(8,"");
			SetAction(9,"");
			SetAction(10,"");
			SetAction(11,"");
			SetAction(12,"");
			SetAction(13,"");
			SetAction(14,"");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"");
			SetAction(19,"");
			SetAction(20,"");
			SetAction(21,"");
			SetAction(22,"");
			SetAction(23,"");
			SetAction(24,"");
			SetAction(25,"");
			SetAction(26,"");
			SetAction(27,"");
			SetAction(28,"");
			SetAction(29,"");
			SetAction(30,"");
			name = "九人团CA1";
			nativename = "九人团CA1";
			icon = "";
			SetTalent(0,0);
			SetTalent(1,0);
			SetTalent(2,0);
			SetTalent(3,0);
			SetTalent(4,0);
			SetTalent(5,0);
			SetTalent(6,0);
			SetTalent(7,0);
			talent_size = 0;
			talent_type = 0;
			use_proficiency = false;
			inc_proficiency = 0;
			preskillnum = 0;
			cycle = false;
			cyclemode = 0;
			cyclegfx = "";
			skill_class = -2;
			guide = false;
			summon_id = 0;
			trigger = false;
			conbutton_sub = false;
			isBabySkill = false;
			castInPreSkill = false;
			preCastSkillId = 0;
			darkLightType = 0;
			followskill = 0;
			targetcnt = 0;
			excludemonstercnt = 0;

			AddState(new GState1());
			AddState(new GState2());
		}
		public override int GetExecutetime(GSkill skill)
		{
			return 1000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			return 1000;
		}
		public override float GetRadius(GSkill skill)
		{
			return 25.000000f;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 18.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 15.000000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 30.000000f;
		}
		public override int GetCoverage(GSkill skill)
		{
			return 40;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();

			victim.SetProbability(100.0f);
			victim.SetTime(((2000 * skill_level)));
			victim.SetDizzy(true);
			victim.SetProbability(100.0f);
			victim.SetTime(((2000 * skill_level)));
			victim.SetWrap(true);
			victim.SetProbability(100.0f);
			victim.SetTime(((2000 * skill_level)));
			victim.SetRatio(0.5f);
			victim.SetBuffid(1);
			victim.SetWeak(true);
			return true;
		}
	}
	public class GSkill1814 : GSkill
	{
		public GSkill1814()
			: base(1814)
		{
			
		}
	}
	public class GSkill1815Stub : GSkillStub
	{
		public class GState1 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 800;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();

				player.SetPray(1);
			}
		}
		public class GState2 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 200;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();

				player.SetPerform(1);
			}
		}
		public GSkill1815Stub()
			: base(1815)
		{
			occupation = 128;
			maxlevel = 99;
			maxlearn = 10;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 1;
			timetype = 0;
			targettype = 0;
			rangetype = 3;
			doenchant = true;
			dobless = false;
			autoattack = false;
			allowform = 0;
			credittype = 0;
			clearmask = 0;
			skill_limit = 0;
			skillelemsnum = 0;
			skillelemsfactor = 0.000000f;
			serialskill = 0;
			charge = 0;
			chargedist = 0.000000f;
			succeedskillcolor = 0;
			succeedskillcolornum = 0;
			comboskill = 0;
			need_item = false;
			item1_id = -1;
			item1_num = 0;
			item2_id = -1;
			item2_num = 0;
			item_relation = 0;
			weapon_limit = -1;
			SetAction(0,"0");
			SetAction(1,"0");
			SetAction(2,"0");
			SetAction(3,"0");
			SetAction(4,"0");
			SetAction(5,"0");
			SetAction(6,"");
			SetAction(7,"");
			SetAction(8,"");
			SetAction(9,"");
			SetAction(10,"");
			SetAction(11,"");
			SetAction(12,"");
			SetAction(13,"");
			SetAction(14,"");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"0");
			SetAction(19,"0");
			SetAction(20,"0");
			SetAction(21,"0");
			SetAction(22,"0");
			SetAction(23,"0");
			SetAction(24,"");
			SetAction(25,"");
			SetAction(26,"");
			SetAction(27,"");
			SetAction(28,"");
			SetAction(29,"");
			SetAction(30,"");
			name = "九人团CA2";
			nativename = "九人团CA2";
			icon = "";
			SetTalent(0,0);
			SetTalent(1,0);
			SetTalent(2,0);
			SetTalent(3,0);
			SetTalent(4,0);
			SetTalent(5,0);
			SetTalent(6,0);
			SetTalent(7,0);
			talent_size = 0;
			talent_type = 0;
			use_proficiency = false;
			inc_proficiency = 0;
			preskillnum = 0;
			cycle = false;
			cyclemode = 0;
			cyclegfx = "";
			skill_class = -2;
			guide = false;
			summon_id = 0;
			trigger = false;
			conbutton_sub = false;
			isBabySkill = false;
			castInPreSkill = false;
			preCastSkillId = 0;
			darkLightType = 0;
			followskill = 0;
			targetcnt = 0;
			excludemonstercnt = 0;

			AddState(new GState1());
			AddState(new GState2());
		}
		public override int GetExecutetime(GSkill skill)
		{
			return 1000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			return 1000;
		}
		public override float GetRadius(GSkill skill)
		{
			return 25.000000f;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 18.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 15.000000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 30.000000f;
		}
		public override int GetCoverage(GSkill skill)
		{
			return 40;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();

			victim.SetProbability(100.0f);
			victim.SetTime(((2000 * skill_level)));
			victim.SetValue(0.0f);
			victim.SetSleep(true);
			victim.SetProbability(100.0f);
			victim.SetTime(((2000 * skill_level)));
			victim.SetSilent(true);
			victim.SetProbability(100.0f);
			victim.SetTime(((2000 * skill_level)));
			victim.SetRatio(0.5f);
			victim.SetBuffid(1);
			victim.SetSlow(true);
			return true;
		}
	}
	public class GSkill1815 : GSkill
	{
		public GSkill1815()
			: base(1815)
		{
			
		}
	}
	public class GSkill1816Stub : GSkillStub
	{
		public class GState1 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 800;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();

				player.SetPray(1);
			}
		}
		public class GState2 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 200;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();

				player.SetPerform(1);
			}
		}
		public GSkill1816Stub()
			: base(1816)
		{
			occupation = 128;
			maxlevel = 99;
			maxlearn = 10;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 3;
			timetype = 0;
			targettype = 0;
			rangetype = 2;
			doenchant = true;
			dobless = true;
			autoattack = false;
			allowform = 0;
			credittype = 0;
			clearmask = 0;
			skill_limit = 0;
			skillelemsnum = 0;
			skillelemsfactor = 0.000000f;
			serialskill = 0;
			charge = 0;
			chargedist = 0.000000f;
			succeedskillcolor = 0;
			succeedskillcolornum = 0;
			comboskill = 0;
			need_item = false;
			item1_id = -1;
			item1_num = 0;
			item2_id = -1;
			item2_num = 0;
			item_relation = 0;
			weapon_limit = -1;
			SetAction(0,"0");
			SetAction(1,"0");
			SetAction(2,"0");
			SetAction(3,"0");
			SetAction(4,"0");
			SetAction(5,"0");
			SetAction(6,"");
			SetAction(7,"");
			SetAction(8,"");
			SetAction(9,"");
			SetAction(10,"");
			SetAction(11,"");
			SetAction(12,"");
			SetAction(13,"");
			SetAction(14,"");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"0");
			SetAction(19,"0");
			SetAction(20,"0");
			SetAction(21,"0");
			SetAction(22,"0");
			SetAction(23,"0");
			SetAction(24,"");
			SetAction(25,"");
			SetAction(26,"");
			SetAction(27,"");
			SetAction(28,"");
			SetAction(29,"");
			SetAction(30,"");
			name = "九人团CA3";
			nativename = "九人团CA3";
			icon = "";
			SetTalent(0,0);
			SetTalent(1,0);
			SetTalent(2,0);
			SetTalent(3,0);
			SetTalent(4,0);
			SetTalent(5,0);
			SetTalent(6,0);
			SetTalent(7,0);
			talent_size = 0;
			talent_type = 0;
			use_proficiency = false;
			inc_proficiency = 0;
			preskillnum = 0;
			cycle = false;
			cyclemode = 0;
			cyclegfx = "";
			skill_class = -2;
			guide = false;
			summon_id = 0;
			trigger = false;
			conbutton_sub = false;
			isBabySkill = false;
			castInPreSkill = false;
			preCastSkillId = 0;
			darkLightType = 0;
			followskill = 0;
			targetcnt = 0;
			excludemonstercnt = 0;

			AddState(new GState1());
			AddState(new GState2());
		}
		public override int GetExecutetime(GSkill skill)
		{
			return 1000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			return 1000;
		}
		public override float GetRadius(GSkill skill)
		{
			return 30.000000f;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 18.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 10.000000f;
		}
		public override int GetCoverage(GSkill skill)
		{
			return 40;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_maxhp = player.GetMaxhp();
			int				player_maxmp = player.GetMaxmp();

			victim.SetProbability(100.0f);
			victim.SetTime(60000.0f);
			victim.SetRatio(0.0f);
			victim.SetBuffid(1);
			victim.SetAmount(1000.0f);
			victim.SetValue(((2 * player_maxhp)));
			victim.SetHpgen(true);
			victim.SetProbability(100.0f);
			victim.SetTime(60000.0f);
			victim.SetBuffid(1);
			victim.SetAmount(1000.0f);
			victim.SetValue(((2 * player_maxmp)));
			victim.SetMpgen(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetTime(6000.0f);
			victim.SetInvincible(true);
			return true;
		}
	}
	public class GSkill1816 : GSkill
	{
		public GSkill1816()
			: base(1816)
		{
			
		}
	}
	public class GSkill1817Stub : GSkillStub
	{
		public class GState1 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 800;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();

				player.SetPray(1);
			}
		}
		public class GState2 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 200;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();

				player.SetPerform(1);
			}
		}
		public GSkill1817Stub()
			: base(1817)
		{
			occupation = 128;
			maxlevel = 99;
			maxlearn = 10;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 3;
			timetype = 0;
			targettype = 0;
			rangetype = 2;
			doenchant = true;
			dobless = true;
			autoattack = false;
			allowform = 0;
			credittype = 0;
			clearmask = 0;
			skill_limit = 0;
			skillelemsnum = 0;
			skillelemsfactor = 0.000000f;
			serialskill = 0;
			charge = 0;
			chargedist = 0.000000f;
			succeedskillcolor = 0;
			succeedskillcolornum = 0;
			comboskill = 0;
			need_item = false;
			item1_id = -1;
			item1_num = 0;
			item2_id = -1;
			item2_num = 0;
			item_relation = 0;
			weapon_limit = -1;
			SetAction(0,"0");
			SetAction(1,"0");
			SetAction(2,"0");
			SetAction(3,"0");
			SetAction(4,"0");
			SetAction(5,"0");
			SetAction(6,"");
			SetAction(7,"");
			SetAction(8,"");
			SetAction(9,"");
			SetAction(10,"");
			SetAction(11,"");
			SetAction(12,"");
			SetAction(13,"");
			SetAction(14,"");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"0");
			SetAction(19,"0");
			SetAction(20,"0");
			SetAction(21,"0");
			SetAction(22,"0");
			SetAction(23,"0");
			SetAction(24,"");
			SetAction(25,"");
			SetAction(26,"");
			SetAction(27,"");
			SetAction(28,"");
			SetAction(29,"");
			SetAction(30,"");
			name = "九人团CA4";
			nativename = "九人团CA4";
			icon = "";
			SetTalent(0,0);
			SetTalent(1,0);
			SetTalent(2,0);
			SetTalent(3,0);
			SetTalent(4,0);
			SetTalent(5,0);
			SetTalent(6,0);
			SetTalent(7,0);
			talent_size = 0;
			talent_type = 0;
			use_proficiency = false;
			inc_proficiency = 0;
			preskillnum = 0;
			cycle = false;
			cyclemode = 0;
			cyclegfx = "";
			skill_class = -2;
			guide = false;
			summon_id = 0;
			trigger = false;
			conbutton_sub = false;
			isBabySkill = false;
			castInPreSkill = false;
			preCastSkillId = 0;
			darkLightType = 0;
			followskill = 0;
			targetcnt = 0;
			excludemonstercnt = 0;

			AddState(new GState1());
			AddState(new GState2());
		}
		public override int GetExecutetime(GSkill skill)
		{
			return 1000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			return 1000;
		}
		public override float GetRadius(GSkill skill)
		{
			return 25.000000f;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 15.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 6.000000f;
		}
		public override int GetCoverage(GSkill skill)
		{
			return 40;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetProbability(100.0f);
			victim.SetAmount(0.0f);
			victim.SetClearbuff(true);
			victim.SetProbability(100.0f);
			victim.SetAmount(0.0f);
			victim.SetCleardebuff(true);
			victim.SetTime(60000.0f);
			victim.SetRatio(0.5f);
			victim.SetBuffid(0);
			victim.SetIncskilldamage(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetProbability(100.0f);
			victim.SetTime(60000.0f);
			victim.SetRatio(0.5f);
			victim.SetBuffid(0);
			victim.SetIncattack(true);
			return true;
		}
	}
	public class GSkill1817 : GSkill
	{
		public GSkill1817()
			: base(1817)
		{
			
		}
	}
	public class GSkill1818Stub : GSkillStub
	{
		public class GState1 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 800;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();

				player.SetPray(1);
			}
		}
		public class GState2 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 200;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				skill_level = skill.GetLevel();

				skill.SetRatio((skill_level * 0.02f + 1.0f));
				player.SetPerform(1);
			}
		}
		public GSkill1818Stub()
			: base(1818)
		{
			occupation = 128;
			maxlevel = 99;
			maxlearn = 10;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 1;
			timetype = 0;
			targettype = 0;
			rangetype = 0;
			doenchant = true;
			dobless = false;
			autoattack = false;
			allowform = 0;
			credittype = 0;
			clearmask = 0;
			skill_limit = 0;
			skillelemsnum = 0;
			skillelemsfactor = 0.000000f;
			serialskill = 0;
			charge = 0;
			chargedist = 0.000000f;
			succeedskillcolor = 0;
			succeedskillcolornum = 0;
			comboskill = 0;
			need_item = false;
			item1_id = -1;
			item1_num = 0;
			item2_id = -1;
			item2_num = 0;
			item_relation = 0;
			weapon_limit = -1;
			SetAction(0,"0");
			SetAction(1,"0");
			SetAction(2,"0");
			SetAction(3,"0");
			SetAction(4,"0");
			SetAction(5,"0");
			SetAction(6,"");
			SetAction(7,"");
			SetAction(8,"");
			SetAction(9,"");
			SetAction(10,"");
			SetAction(11,"");
			SetAction(12,"");
			SetAction(13,"");
			SetAction(14,"");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"0");
			SetAction(19,"0");
			SetAction(20,"0");
			SetAction(21,"0");
			SetAction(22,"0");
			SetAction(23,"0");
			SetAction(24,"");
			SetAction(25,"");
			SetAction(26,"");
			SetAction(27,"");
			SetAction(28,"");
			SetAction(29,"");
			SetAction(30,"");
			name = "九人团CP11";
			nativename = "九人团CP11";
			icon = "";
			SetTalent(0,0);
			SetTalent(1,0);
			SetTalent(2,0);
			SetTalent(3,0);
			SetTalent(4,0);
			SetTalent(5,0);
			SetTalent(6,0);
			SetTalent(7,0);
			talent_size = 0;
			talent_type = 0;
			use_proficiency = false;
			inc_proficiency = 0;
			preskillnum = 0;
			cycle = false;
			cyclemode = 0;
			cyclegfx = "";
			skill_class = -2;
			guide = false;
			summon_id = 0;
			trigger = false;
			conbutton_sub = false;
			isBabySkill = false;
			castInPreSkill = false;
			preCastSkillId = 0;
			darkLightType = 0;
			followskill = 0;
			targetcnt = 0;
			excludemonstercnt = 0;

			AddState(new GState1());
			AddState(new GState2());
		}
		public override int GetExecutetime(GSkill skill)
		{
			return 1000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			return 1000;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 15.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 12.000000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 18.000000f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();

			victim.SetProbability(100.0f);
			victim.SetAmount(1.0f);
			victim.SetClearbuff(true);
			victim.SetTime(((2000 * skill_level)));
			victim.SetBuffid(0);
			victim.SetValue(400.0f);
			victim.SetSubantislow(true);
			victim.SetTime(((2000 * skill_level)));
			victim.SetBuffid(0);
			victim.SetValue(400.0f);
			victim.SetSubantiwrap(true);
			return true;
		}
	}
	public class GSkill1818 : GSkill
	{
		public GSkill1818()
			: base(1818)
		{
			
		}
	}
	public class GSkill1819Stub : GSkillStub
	{
		public class GState1 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 800;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();

				player.SetPray(1);
			}
		}
		public class GState2 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 200;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();

				player.SetPerform(1);
			}
		}
		public GSkill1819Stub()
			: base(1819)
		{
			occupation = 128;
			maxlevel = 99;
			maxlearn = 10;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 2;
			timetype = 0;
			targettype = 0;
			rangetype = 5;
			doenchant = true;
			dobless = false;
			autoattack = false;
			allowform = 0;
			credittype = 0;
			clearmask = 0;
			skill_limit = 0;
			skillelemsnum = 0;
			skillelemsfactor = 0.000000f;
			serialskill = 0;
			charge = 0;
			chargedist = 0.000000f;
			succeedskillcolor = 0;
			succeedskillcolornum = 0;
			comboskill = 0;
			need_item = false;
			item1_id = -1;
			item1_num = 0;
			item2_id = -1;
			item2_num = 0;
			item_relation = 0;
			weapon_limit = -1;
			SetAction(0,"0");
			SetAction(1,"0");
			SetAction(2,"0");
			SetAction(3,"0");
			SetAction(4,"0");
			SetAction(5,"0");
			SetAction(6,"");
			SetAction(7,"");
			SetAction(8,"");
			SetAction(9,"");
			SetAction(10,"");
			SetAction(11,"");
			SetAction(12,"");
			SetAction(13,"");
			SetAction(14,"");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"0");
			SetAction(19,"0");
			SetAction(20,"0");
			SetAction(21,"0");
			SetAction(22,"0");
			SetAction(23,"0");
			SetAction(24,"");
			SetAction(25,"");
			SetAction(26,"");
			SetAction(27,"");
			SetAction(28,"");
			SetAction(29,"");
			SetAction(30,"");
			name = "九人团CP12";
			nativename = "九人团CP12";
			icon = "";
			SetTalent(0,0);
			SetTalent(1,0);
			SetTalent(2,0);
			SetTalent(3,0);
			SetTalent(4,0);
			SetTalent(5,0);
			SetTalent(6,0);
			SetTalent(7,0);
			talent_size = 0;
			talent_type = 0;
			use_proficiency = false;
			inc_proficiency = 0;
			preskillnum = 0;
			cycle = false;
			cyclemode = 0;
			cyclegfx = "";
			skill_class = -2;
			guide = false;
			summon_id = 0;
			trigger = false;
			conbutton_sub = false;
			isBabySkill = false;
			castInPreSkill = false;
			preCastSkillId = 0;
			darkLightType = 0;
			followskill = 0;
			targetcnt = 0;
			excludemonstercnt = 0;

			AddState(new GState1());
			AddState(new GState2());
		}
		public override int GetExecutetime(GSkill skill)
		{
			return 1000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			return 1000;
		}
		public override float GetPraydistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return player_range;
		}
		public override float GetCastdistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return player_range;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 18.000000f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();

			victim.SetTime(((2000 * skill_level)));
			victim.SetInvincible(true);
			return true;
		}
	}
	public class GSkill1819 : GSkill
	{
		public GSkill1819()
			: base(1819)
		{
			
		}
	}
}
