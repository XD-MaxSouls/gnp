using System;
using System.Text;

namespace SKILL
{
	public class GSkill1510Stub : GSkillStub
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
		public GSkill1510Stub()
			: base(1510)
		{
			occupation = 147;
			maxlevel = 50;
			maxlearn = 12;
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
			allowform = 0;
			credittype = 8;
			clearmask = 64;
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
			SetAction(0,"青云门_天罡云体");
			SetAction(1,"青云门_天罡云体");
			SetAction(2,"鬼王宗_天罡云体");
			SetAction(3,"合欢派_天罡云体");
			SetAction(4,"天音寺_天罡云体");
			SetAction(5,"鬼道_天罡云体");
			SetAction(6,"焚香谷_天罡云体");
			SetAction(7,"兽神_天罡云体");
			SetAction(8,"狐妖_天罡云体");
			SetAction(9,"太昊_天罡云体");
			SetAction(10,"怀光_天罡云体");
			SetAction(11,"太昊_天罡云体");
			SetAction(12,"天华_天罡云体");
			SetAction(13,"灵夙_天罡云体");
			SetAction(14,"英招_天罡云体");
			SetAction(15,"元素大师_坚盾");
			SetAction(16,"元素大师_天罡云体");
			SetAction(17,"天音寺_天罡云体");
			SetAction(18,"青云门_骑乘_天罡云体");
			SetAction(19,"青云门_骑乘_天罡云体");
			SetAction(20,"鬼王宗_骑乘_天罡云体");
			SetAction(21,"合欢派_骑乘_天罡云体");
			SetAction(22,"天音寺_骑乘_天罡云体");
			SetAction(23,"鬼道_骑乘_天罡云体");
			SetAction(24,"焚香谷_骑乘_天罡云体");
			SetAction(25,"兽神_骑乘_天罡云体");
			SetAction(26,"狐妖_骑乘_天罡云体");
			SetAction(27,"太昊_骑乘_天罡云体");
			SetAction(28,"怀光_骑乘_天罡云体");
			SetAction(29,"太昊_骑乘_天罡云体");
			SetAction(30,"天华_骑乘_天罡云体");
			name = "天罡云体";
			nativename = "天罡云体";
			icon = "天罡云体.dds";
			SetTalent(0,1508);
			SetTalent(1,1505);
			SetTalent(2,0);
			SetTalent(3,0);
			SetTalent(4,0);
			SetTalent(5,0);
			SetTalent(6,0);
			SetTalent(7,0);
			talent_size = 2;
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
			int				skill_t0 = skill.GetT0();

			return 600000 - 30000 * skill_t0;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={105,105,105,110,115,120,125,125,125,125,125,125};return array[level-1];
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
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_level = player.GetLevel();
			int				skill_level = skill.GetLevel();
			int				skill_t1 = skill.GetT1();

			victim.SetTime(((skill_t1 * 0.05f + 1.0f) * 180000.0f));
			victim.SetBuffid(1);
			victim.SetValue(((skill_t1 * 0.05f + 1.0f) * ((player_level * 0.05f / 15.0f + 1.0f) * (skill_level * (skill_level * 0.2f) + ((3 * skill_level))))));
			victim.SetAddanti2(true);
			return true;
		}
		public override int GetCreditCost(int level)
		{
			int[] array={25,50,125,250,500,1000,1800,3600,7200,14400,14400,14400};return array[level-1];
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={1509};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={1};return array[index];
		}
	}
	public class GSkill1510 : GSkill
	{
		public GSkill1510()
			: base(1510)
		{
			
		}
	}
	public class GSkill1511Stub : GSkillStub
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
		public GSkill1511Stub()
			: base(1511)
		{
			occupation = 147;
			maxlevel = 50;
			maxlearn = 12;
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
			allowform = 0;
			credittype = 8;
			clearmask = 64;
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
			SetAction(0,"青云门_天罡步尘");
			SetAction(1,"青云门_天罡步尘");
			SetAction(2,"鬼王宗_天罡步尘");
			SetAction(3,"合欢派_天罡步尘");
			SetAction(4,"天音寺_天罡步尘");
			SetAction(5,"鬼道_天罡步尘");
			SetAction(6,"焚香谷_天罡步尘");
			SetAction(7,"兽神_天罡步尘");
			SetAction(8,"狐妖_天罡步尘");
			SetAction(9,"太昊_天罡步尘");
			SetAction(10,"怀光_天罡步尘");
			SetAction(11,"太昊_天罡步尘");
			SetAction(12,"天华_天罡步尘");
			SetAction(13,"灵夙_天罡步尘");
			SetAction(14,"英招_天罡步尘");
			SetAction(15,"元素大师_坚盾");
			SetAction(16,"元素大师_天罡步尘");
			SetAction(17,"天音寺_天罡步尘");
			SetAction(18,"青云门_骑乘_天罡步尘");
			SetAction(19,"青云门_骑乘_天罡步尘");
			SetAction(20,"鬼王宗_骑乘_天罡步尘");
			SetAction(21,"合欢派_骑乘_天罡步尘");
			SetAction(22,"天音寺_骑乘_天罡步尘");
			SetAction(23,"鬼道_骑乘_天罡步尘");
			SetAction(24,"焚香谷_骑乘_天罡步尘");
			SetAction(25,"兽神_骑乘_天罡步尘");
			SetAction(26,"狐妖_骑乘_天罡步尘");
			SetAction(27,"太昊_骑乘_天罡步尘");
			SetAction(28,"怀光_骑乘_天罡步尘");
			SetAction(29,"太昊_骑乘_天罡步尘");
			SetAction(30,"天华_骑乘_天罡步尘");
			name = "天罡步尘";
			nativename = "天罡步尘";
			icon = "天罡步尘.dds";
			SetTalent(0,1508);
			SetTalent(1,1505);
			SetTalent(2,0);
			SetTalent(3,0);
			SetTalent(4,0);
			SetTalent(5,0);
			SetTalent(6,0);
			SetTalent(7,0);
			talent_size = 2;
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
			int				skill_t0 = skill.GetT0();

			return 600000 - 30000 * skill_t0;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={105,105,105,110,115,120,125,125,125,125,125,125};return array[level-1];
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
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_level = player.GetLevel();
			int				skill_level = skill.GetLevel();
			int				skill_t1 = skill.GetT1();

			victim.SetProbability(100.0f);
			victim.SetTime(((skill_t1 * 0.05f + 1.0f) * 180000.0f));
			victim.SetBuffid(1);
			victim.SetValue(((skill_t1 * 0.05f + 1.0f) * ((player_level * 0.05f / 15.0f + 1.0f) * (skill_level * (skill_level * 0.5f) + ((3 * skill_level))))));
			victim.SetAdddodge2(true);
			return true;
		}
		public override int GetCreditCost(int level)
		{
			int[] array={25,50,125,250,500,1000,1800,3600,7200,14400,14400,14400};return array[level-1];
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={1510};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={1};return array[index];
		}
	}
	public class GSkill1511 : GSkill
	{
		public GSkill1511()
			: base(1511)
		{
			
		}
	}
	public class GSkill1512Stub : GSkillStub
	{
		public class GState1 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 1600;
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
				return 400;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();

				player.SetPerform(1);
			}
		}
		public GSkill1512Stub()
			: base(1512)
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
			name = "奥运河阳路障";
			nativename = "奥运河阳路障";
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
			return 2000;
		}
		public override float GetRadius(GSkill skill)
		{
			return 18.000000f;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 30.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 10.000000f;
		}
		public override int GetCoverage(GSkill skill)
		{
			return 30;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetProbability(100.0f);
			victim.SetTime(1000.0f);
			victim.SetBuffid(110);
			victim.SetAmount(164.0f);
			victim.SetValue(176.0f);
			victim.SetMagicdoor(true);
			return true;
		}
	}
	public class GSkill1512 : GSkill
	{
		public GSkill1512()
			: base(1512)
		{
			
		}
	}
	public class GSkill1513Stub : GSkillStub
	{
		public class GState1 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 1600;
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
				return 400;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();

				player.SetPerform(1);
			}
		}
		public GSkill1513Stub()
			: base(1513)
		{
			occupation = 129;
			maxlevel = 1;
			maxlearn = 10;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 1;
			timetype = 0;
			targettype = 0;
			rangetype = 3;
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
			SetAction(0,"青云门_霜天雪舞");
			SetAction(1,"青云门_霜天雪舞");
			SetAction(2,"青云门_霜天雪舞");
			SetAction(3,"青云门_霜天雪舞");
			SetAction(4,"青云门_霜天雪舞");
			SetAction(5,"青云门_霜天雪舞");
			SetAction(6,"焚香谷_初级火攻");
			SetAction(7,"兽神_雪琪之冰霜");
			SetAction(8,"狐妖_雪琪之冰霜");
			SetAction(9,"轩辕_雪琪之冰霜");
			SetAction(10,"怀光_雪琪之冰霜");
			SetAction(11,"太昊_锤击");
			SetAction(12,"天华_雪琪之冰霜");
			SetAction(13,"灵夙_雪琪之冰霜");
			SetAction(14,"英招_雪琪之冰霜");
			SetAction(15,"武器大师_刀闪");
			SetAction(16,"元素大师_四重群攻");
			SetAction(17,"青云门_霜天雪舞");
			SetAction(18,"青云门_骑乘_霜天雪舞");
			SetAction(19,"青云门_骑乘_霜天雪舞");
			SetAction(20,"青云门_骑乘_霜天雪舞");
			SetAction(21,"青云门_骑乘_霜天雪舞");
			SetAction(22,"青云门_骑乘_霜天雪舞");
			SetAction(23,"青云门_骑乘_霜天雪舞");
			SetAction(24,"焚香谷_骑乘_初级火攻");
			SetAction(25,"兽神_骑乘_雪琪之冰霜");
			SetAction(26,"狐妖_骑乘_雪琪之冰霜");
			SetAction(27,"轩辕_骑乘_雪琪之冰霜");
			SetAction(28,"怀光_骑乘_雪琪之冰霜");
			SetAction(29,"太昊_骑乘_锤击");
			SetAction(30,"天华_骑乘_雪琪之冰霜");
			name = "傲剑无痕";
			nativename = "傲剑无痕";
			icon = "焚心厉雷.dds";
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
			return 2000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			return 900000;
		}
		public override float GetRadius(GSkill skill)
		{
			return 25.000000f;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 25.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 10.000000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 30.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			return 600.000000f;
		}
		public override int GetCoverage(GSkill skill)
		{
			return 25;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_maxhp = player.GetMaxhp();

			victim.SetProbability(100.0f);
			victim.SetTime(100.0f);
			victim.SetBuffid(1);
			victim.SetAmount((player_maxhp * 0.333f));
			victim.SetValue(0.0f);
			victim.SetHpleak1(true);
			victim.SetProbability(100.0f);
			victim.SetTime(30000.0f);
			victim.SetRatio(0.89999998f);
			victim.SetBuffid(1);
			victim.SetDecaccuracy(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetProbability(100.0f);
			victim.SetTime(15000.0f);
			victim.SetBuffid(8);
			victim.SetValue(9999.0f);
			victim.SetAdddefence(true);
			return true;
		}
	}
	public class GSkill1513 : GSkill
	{
		public GSkill1513()
			: base(1513)
		{
			
		}
	}
	public class GSkill1514Stub : GSkillStub
	{
		public class GState1 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 1600;
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
				return 400;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();

				player.SetPerform(1);
			}
		}
		public GSkill1514Stub()
			: base(1514)
		{
			occupation = 129;
			maxlevel = 1;
			maxlearn = 10;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 2;
			timetype = 0;
			targettype = 0;
			rangetype = 0;
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
			SetAction(0,"鬼王宗_痴情咒");
			SetAction(1,"鬼王宗_痴情咒");
			SetAction(2,"鬼王宗_痴情咒");
			SetAction(3,"鬼王宗_痴情咒");
			SetAction(4,"鬼王宗_痴情咒");
			SetAction(5,"鬼道_空灵");
			SetAction(6,"焚香谷_火狩护主");
			SetAction(7,"兽神_散尽");
			SetAction(8,"狐妖_散尽");
			SetAction(9,"轩辕_散尽");
			SetAction(10,"怀光_散尽");
			SetAction(11,"太昊_锤击");
			SetAction(12,"天华_散尽");
			SetAction(13,"灵夙_散尽");
			SetAction(14,"英招_散尽");
			SetAction(15,"武器大师_刀闪");
			SetAction(16,"元素大师_献祭");
			SetAction(17,"鬼王宗_痴情咒");
			SetAction(18,"鬼王宗_骑乘_痴情咒");
			SetAction(19,"鬼王宗_骑乘_痴情咒");
			SetAction(20,"鬼王宗_骑乘_痴情咒");
			SetAction(21,"鬼王宗_骑乘_痴情咒");
			SetAction(22,"鬼王宗_骑乘_痴情咒");
			SetAction(23,"鬼道_骑乘_空灵");
			SetAction(24,"焚香谷_骑乘_火狩护主");
			SetAction(25,"兽神_骑乘_散尽");
			SetAction(26,"狐妖_骑乘_散尽");
			SetAction(27,"轩辕_骑乘_散尽");
			SetAction(28,"怀光_骑乘_散尽");
			SetAction(29,"太昊_骑乘_锤击");
			SetAction(30,"天华_骑乘_散尽");
			name = "碧海痴情";
			nativename = "碧海痴情";
			icon = "往生夙愿.dds";
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
			return 200;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			return 900000;
		}
		public override float GetRadius(GSkill skill)
		{
			return 25.000000f;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 25.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 20.000000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 35.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			return 600.000000f;
		}
		public override int GetCoverage(GSkill skill)
		{
			return 25;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_level = player.GetLevel();
			int				skill_level = skill.GetLevel();

			victim.SetTime(30000.0f);
			victim.SetRatio(0.25f);
			victim.SetAmount(((1000 * player_level * skill_level)));
			victim.SetDechurt(true);
			victim.SetProbability(100.0f);
			victim.SetTime(30000.0f);
			victim.SetRatio(0.1f);
			victim.SetBuffid(9);
			victim.SetIncattack(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_level = player.GetLevel();
			int				skill_level = skill.GetLevel();

			victim.SetTime(30000.0f);
			victim.SetRatio(0.75f);
			victim.SetAmount(((3000 * player_level * skill_level)));
			victim.SetDechurt(true);
			return true;
		}
	}
	public class GSkill1514 : GSkill
	{
		public GSkill1514()
			: base(1514)
		{
			
		}
	}
	public class GSkill1515Stub : GSkillStub
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
		public GSkill1515Stub()
			: base(1515)
		{
			occupation = 129;
			maxlevel = 1;
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
			SetAction(0,"鬼王宗_无间寂");
			SetAction(1,"鬼王宗_无间寂");
			SetAction(2,"鬼王宗_无间寂");
			SetAction(3,"鬼王宗_无间寂");
			SetAction(4,"鬼王宗_无间寂");
			SetAction(5,"鬼道_天外天");
			SetAction(6,"焚香谷_火狩护主");
			SetAction(7,"兽神_虎力");
			SetAction(8,"狐妖_安如山");
			SetAction(9,"轩辕_能环");
			SetAction(10,"怀光_偷袭");
			SetAction(11,"太昊_加速");
			SetAction(12,"天华_奔雷");
			SetAction(13,"灵夙_坚盾");
			SetAction(14,"英招_坚盾");
			SetAction(15,"武器大师_刀闪");
			SetAction(16,"元素大师_迟钝");
			SetAction(17,"鬼王宗_无间寂");
			SetAction(18,"鬼王宗_骑乘_无间寂");
			SetAction(19,"鬼王宗_骑乘_无间寂");
			SetAction(20,"鬼王宗_骑乘_无间寂");
			SetAction(21,"鬼王宗_骑乘_无间寂");
			SetAction(22,"鬼王宗_骑乘_无间寂");
			SetAction(23,"鬼道_骑乘_天外天");
			SetAction(24,"焚香谷_骑乘_火狩护主");
			SetAction(25,"兽神_骑乘_虎力");
			SetAction(26,"狐妖_骑乘_安如山");
			SetAction(27,"轩辕_骑乘_能环");
			SetAction(28,"怀光_骑乘_偷袭");
			SetAction(29,"太昊_骑乘_加速");
			SetAction(30,"天华_骑乘_奔雷");
			name = "凡尘物华";
			nativename = "凡尘物华";
			icon = "回魂祭.dds";
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
			return 900000;
		}
		public override float GetRadius(GSkill skill)
		{
			return 25.000000f;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 25.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 10.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			return 600.000000f;
		}
		public override int GetCoverage(GSkill skill)
		{
			return 40;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetProbability(100.0f);
			victim.SetTime(30000.0f);
			victim.SetRatio(0.30000001f);
			victim.SetBuffid(5);
			victim.SetDeccritrate(true);
			victim.SetProbability(100.0f);
			victim.SetTime(30000.0f);
			victim.SetRatio(3.0f);
			victim.SetBuffid(5);
			victim.SetDeccrithurt(true);
			victim.SetProbability(100.0f);
			victim.SetTime(30000.0f);
			victim.SetBarehanded(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetTime(12000.0f);
			victim.SetInvincible(true);
			return true;
		}
	}
	public class GSkill1515 : GSkill
	{
		public GSkill1515()
			: base(1515)
		{
			
		}
	}
	public class GSkill1516Stub : GSkillStub
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
		public GSkill1516Stub()
			: base(1516)
		{
			occupation = 129;
			maxlevel = 1;
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
			SetAction(0,"合欢派_相思");
			SetAction(1,"合欢派_相思");
			SetAction(2,"合欢派_相思");
			SetAction(3,"合欢派_相思");
			SetAction(4,"合欢派_相思");
			SetAction(5,"合欢派_相思");
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
			SetAction(18,"合欢派_骑乘_相思");
			SetAction(19,"合欢派_骑乘_相思");
			SetAction(20,"合欢派_骑乘_相思");
			SetAction(21,"合欢派_骑乘_相思");
			SetAction(22,"合欢派_骑乘_相思");
			SetAction(23,"合欢派_骑乘_相思");
			SetAction(24,"");
			SetAction(25,"");
			SetAction(26,"");
			SetAction(27,"");
			SetAction(28,"");
			SetAction(29,"");
			SetAction(30,"");
			name = "一夏清凉";
			nativename = "一夏清凉";
			icon = "再造祷言.dds";
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
			return 900000;
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
		public override float GetMpcost(GSkill skill)
		{
			return 600.000000f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_maxhp = player.GetMaxhp();

			victim.SetProbability(100.0f);
			victim.SetRatio(0.0f);
			victim.SetValue(player_maxhp);
			victim.SetHeal(true);
			victim.SetProbability(100.0f);
			victim.SetTime(12000.0f);
			victim.SetBuffid(1);
			victim.SetValue(5000.0f);
			victim.SetAdddefence(true);
			victim.SetProbability(100.0f);
			victim.SetTime(30000.0f);
			victim.SetBuffid(1);
			victim.SetValue(999.0f);
			victim.SetAdddodge(true);
			victim.SetProbability(100.0f);
			victim.SetTime(30000.0f);
			victim.SetRatio(1.0f);
			victim.SetAttack2hp(true);
			return true;
		}
	}
	public class GSkill1516 : GSkill
	{
		public GSkill1516()
			: base(1516)
		{
			
		}
	}
	public class GSkill1517Stub : GSkillStub
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
				int				player_hp = player.GetHp();
				int				player_mp = player.GetMp();

				skill.SetRatio(1.0f);
				skill.SetPlus(((player_mp + player_hp) * 0.02f));
				player.SetPerform(1);
			}
		}
		public GSkill1517Stub()
			: base(1517)
		{
			occupation = 129;
			maxlevel = 1;
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
			autoattack = true;
			allowform = 0;
			credittype = 0;
			clearmask = 0;
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
			SetAction(0,"青云门_破魔剑气");
			SetAction(1,"青云门_破魔剑气");
			SetAction(2,"青云门_破魔剑气");
			SetAction(3,"青云门_破魔剑气");
			SetAction(4,"青云门_破魔剑气");
			SetAction(5,"青云门_破魔剑气");
			SetAction(6,"焚香谷_初级火攻");
			SetAction(7,"兽神_猛击");
			SetAction(8,"狐妖_猛击");
			SetAction(9,"轩辕_猛击");
			SetAction(10,"怀光_猛击");
			SetAction(11,"太昊_锤击");
			SetAction(12,"天华_猛击");
			SetAction(13,"灵夙_猛击");
			SetAction(14,"英招_猛击");
			SetAction(15,"元素大师_熔岩攻击");
			SetAction(16,"元素大师_熔岩攻击");
			SetAction(17,"青云门_破魔剑气");
			SetAction(18,"青云门_骑乘_破魔剑气");
			SetAction(19,"青云门_骑乘_破魔剑气");
			SetAction(20,"青云门_骑乘_破魔剑气");
			SetAction(21,"青云门_骑乘_破魔剑气");
			SetAction(22,"青云门_骑乘_破魔剑气");
			SetAction(23,"青云门_骑乘_破魔剑气");
			SetAction(24,"焚香谷_骑乘_初级火攻");
			SetAction(25,"兽神_骑乘_猛击");
			SetAction(26,"狐妖_骑乘_猛击");
			SetAction(27,"轩辕_骑乘_猛击");
			SetAction(28,"怀光_骑乘_猛击");
			SetAction(29,"太昊_骑乘_锤击");
			SetAction(30,"天华_骑乘_猛击");
			name = "郎情妾意剑";
			nativename = "郎情妾意剑";
			icon = "邪剑星羽.dds";
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
			return 900000;
		}
		public override int GetEnmity(GSkill skill)
		{
			return 1;
		}
		public override float GetAttackdistance(GSkill skill)
		{
			return 10.000000f;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 16.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 10.700000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 19.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			return 600.000000f;
		}
		public override int GetCoverage(GSkill skill)
		{
			return 12;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_maxhp = player.GetMaxhp();
			int				player_maxmp = player.GetMaxmp();

			victim.SetProbability(100.0f);
			victim.SetRatio(1.0f);
			victim.SetDrainmagic(true);
			victim.SetProbability(100.0f);
			victim.SetTime(60000.0f);
			victim.SetBuffid(9);
			victim.SetAmount(((3 * (player_maxhp + player_maxmp))));
			victim.SetValue(0.0f);
			victim.SetMpleak(true);
			victim.SetProbability(33.0f);
			victim.SetTime(60000.0f);
			victim.SetPowerless(true);
			return true;
		}
	}
	public class GSkill1517 : GSkill
	{
		public GSkill1517()
			: base(1517)
		{
			
		}
	}
	public class GSkill1518Stub : GSkillStub
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
				int				player_hp = player.GetHp();
				int				player_mp = player.GetMp();

				skill.SetRatio(1.0f);
				skill.SetPlus(((player_hp + player_mp) * 0.02f));
				player.SetPerform(1);
			}
		}
		public GSkill1518Stub()
			: base(1518)
		{
			occupation = 129;
			maxlevel = 1;
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
			autoattack = true;
			allowform = 0;
			credittype = 0;
			clearmask = 0;
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
			SetAction(0,"鬼王宗_无妄刃");
			SetAction(1,"鬼王宗_无妄刃");
			SetAction(2,"鬼王宗_无妄刃");
			SetAction(3,"鬼王宗_无妄刃");
			SetAction(4,"鬼王宗_无妄刃");
			SetAction(5,"鬼王宗_无妄刃");
			SetAction(6,"焚香谷_初级火攻");
			SetAction(7,"兽神_猛击");
			SetAction(8,"狐妖_猛击");
			SetAction(9,"轩辕_猛击");
			SetAction(10,"怀光_猛击");
			SetAction(11,"太昊_锤击");
			SetAction(12,"天华_猛击");
			SetAction(13,"灵夙_猛击");
			SetAction(14,"英招_猛击");
			SetAction(15,"元素大师_熔岩攻击");
			SetAction(16,"元素大师_熔岩攻击");
			SetAction(17,"鬼王宗_无妄刃");
			SetAction(18,"鬼王宗_骑乘_无妄刃");
			SetAction(19,"鬼王宗_骑乘_无妄刃");
			SetAction(20,"鬼王宗_骑乘_无妄刃");
			SetAction(21,"鬼王宗_骑乘_无妄刃");
			SetAction(22,"鬼王宗_骑乘_无妄刃");
			SetAction(23,"鬼王宗_骑乘_无妄刃");
			SetAction(24,"焚香谷_骑乘_初级火攻");
			SetAction(25,"兽神_骑乘_猛击");
			SetAction(26,"狐妖_骑乘_猛击");
			SetAction(27,"轩辕_骑乘_猛击");
			SetAction(28,"怀光_骑乘_猛击");
			SetAction(29,"太昊_骑乘_锤击");
			SetAction(30,"天华_骑乘_猛击");
			name = "情意绵绵刀";
			nativename = "情意绵绵刀";
			icon = "决意.dds";
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
			return 900000;
		}
		public override int GetEnmity(GSkill skill)
		{
			return 1;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 7.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 1.700000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 12.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			return 600.000000f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_maxhp = player.GetMaxhp();

			victim.SetProbability(100.0f);
			victim.SetTime(120000.0f);
			victim.SetBuffid(9);
			victim.SetAmount(((3 * player_maxhp)));
			victim.SetValue(0.0f);
			victim.SetHpleak(true);
			victim.SetProbability(999.0f);
			victim.SetTime(120000.0f);
			victim.SetRatio(0.15000001f);
			victim.SetBuffid(9);
			victim.SetSlow(true);
			victim.SetTime(120000.0f);
			victim.SetRatio(0.15000001f);
			victim.SetBuffid(9);
			victim.SetDecanti(true);
			return true;
		}
	}
	public class GSkill1518 : GSkill
	{
		public GSkill1518()
			: base(1518)
		{
			
		}
	}
	public class GSkill1519Stub : GSkillStub
	{
		public class GState1 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 1600;
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
				return 400;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();

				player.SetPerform(1);
			}
		}
		public GSkill1519Stub()
			: base(1519)
		{
			occupation = 129;
			maxlevel = 1;
			maxlearn = 10;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 2;
			timetype = 0;
			targettype = 0;
			rangetype = 0;
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
			SetAction(0,"鬼王宗_痴情咒");
			SetAction(1,"鬼王宗_痴情咒");
			SetAction(2,"鬼王宗_痴情咒");
			SetAction(3,"鬼王宗_痴情咒");
			SetAction(4,"鬼王宗_痴情咒");
			SetAction(5,"鬼道_空灵");
			SetAction(6,"0");
			SetAction(7,"兽神_散尽");
			SetAction(8,"狐妖_散尽");
			SetAction(9,"轩辕_散尽");
			SetAction(10,"怀光_散尽");
			SetAction(11,"太昊_加速");
			SetAction(12,"天华_散尽");
			SetAction(13,"灵夙_散尽");
			SetAction(14,"英招_散尽");
			SetAction(15,"武器大师_刀闪");
			SetAction(16,"元素大师_献祭");
			SetAction(17,"鬼王宗_痴情咒");
			SetAction(18,"鬼王宗_骑乘_痴情咒");
			SetAction(19,"鬼王宗_骑乘_痴情咒");
			SetAction(20,"鬼王宗_骑乘_痴情咒");
			SetAction(21,"鬼王宗_骑乘_痴情咒");
			SetAction(22,"鬼王宗_骑乘_痴情咒");
			SetAction(23,"鬼道_骑乘_空灵");
			SetAction(24,"0");
			SetAction(25,"兽神_骑乘_散尽");
			SetAction(26,"狐妖_骑乘_散尽");
			SetAction(27,"轩辕_骑乘_散尽");
			SetAction(28,"怀光_骑乘_散尽");
			SetAction(29,"太昊_骑乘_加速");
			SetAction(30,"天华_骑乘_散尽");
			name = "碧海情痴";
			nativename = "碧海情痴";
			icon = "往生夙愿.dds";
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
			return 200;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			return 900000;
		}
		public override float GetRadius(GSkill skill)
		{
			return 25.000000f;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 25.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 20.000000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 35.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			return 600.000000f;
		}
		public override int GetCoverage(GSkill skill)
		{
			return 25;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_level = player.GetLevel();
			int				skill_level = skill.GetLevel();

			victim.SetTime(30000.0f);
			victim.SetRatio(0.25f);
			victim.SetAmount(((1000 * player_level * skill_level)));
			victim.SetDechurt(true);
			victim.SetTime(30000.0f);
			victim.SetRatio(0.050000001f);
			victim.SetInccritrate(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_level = player.GetLevel();
			int				skill_level = skill.GetLevel();

			victim.SetTime(30000.0f);
			victim.SetRatio(0.75f);
			victim.SetAmount(((3000 * player_level * skill_level)));
			victim.SetDechurt(true);
			return true;
		}
	}
	public class GSkill1519 : GSkill
	{
		public GSkill1519()
			: base(1519)
		{
			
		}
	}
}
