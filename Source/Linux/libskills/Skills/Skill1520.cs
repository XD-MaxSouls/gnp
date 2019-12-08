using System;
using System.Text;

namespace SKILL
{
	public class GSkill1520Stub : GSkillStub
	{
		public GSkill1520Stub()
			: base(1520)
		{
			occupation = 148;
			maxlevel = 12;
			maxlearn = 10;
			eventflag = 1;
			spcost = 1;
			reborncount = 0;
			type = 11;
			timetype = 0;
			targettype = 0;
			rangetype = 0;
			doenchant = false;
			dobless = false;
			autoattack = false;
			allowform = 0;
			credittype = 9;
			clearmask = 1;
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
			name = "太玄经";
			nativename = "太玄经";
			icon = "太玄经.dds";
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
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={90,90,90,95,100,105,110,115,120,125};return array[level-1];
		}
		public override bool TakeEffect(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			int				skill_level = skill.GetLevel();

			player.SetPasadddefence((skill_level * (skill_level * 0.5f) + ((10 * skill_level))));
			player.SetPasaddweak(((5 * skill_level)));
			player.SetPasinccrit((D2INT(skill_level / 9.5f) * 0.0305f));
			return true;
		}
		public override int GetCreditCost(int level)
		{
			int[] array={10000,12000,14000,16000,18000,20000,22000,24000,26000,30000};return array[level-1];
		}
	}
	public class GSkill1520 : GSkill
	{
		public GSkill1520()
			: base(1520)
		{
			
		}
	}
	public class GSkill1521Stub : GSkillStub
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
			public override bool Cancel(GSkill skill)
			{
				return true;
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
		public GSkill1521Stub()
			: base(1521)
		{
			occupation = 148;
			maxlevel = 12;
			maxlearn = 10;
			eventflag = 0;
			spcost = 0;
			reborncount = 0;
			type = 3;
			timetype = 0;
			targettype = 0;
			rangetype = 0;
			doenchant = true;
			dobless = true;
			autoattack = false;
			allowform = 0;
			credittype = 9;
			clearmask = 1;
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
			SetAction(0,"青云门_归来去");
			SetAction(1,"青云门_归来去");
			SetAction(2,"鬼王宗_归来去");
			SetAction(3,"合欢派_归来去");
			SetAction(4,"天音寺_归来去");
			SetAction(5,"鬼道_归来去");
			SetAction(6,"焚香谷_归来去");
			SetAction(7,"兽神_归来去");
			SetAction(8,"狐妖_归来去");
			SetAction(9,"0");
			SetAction(10,"怀光_归来去");
			SetAction(11,"太昊_归来去");
			SetAction(12,"天华_归来去");
			SetAction(13,"灵夙_归来去");
			SetAction(14,"英招_归来去");
			SetAction(15,"武器大师_归来去");
			SetAction(16,"元素大师_归来去");
			SetAction(17,"天音寺_归来去");
			SetAction(18,"青云门_骑乘_归来去");
			SetAction(19,"青云门_骑乘_归来去");
			SetAction(20,"鬼王宗_骑乘_归来去");
			SetAction(21,"合欢派_骑乘_归来去");
			SetAction(22,"天音寺_骑乘_归来去");
			SetAction(23,"鬼道_骑乘_归来去");
			SetAction(24,"焚香谷_骑乘_归来去");
			SetAction(25,"兽神_骑乘_归来去");
			SetAction(26,"狐妖_骑乘_归来去");
			SetAction(27,"0");
			SetAction(28,"怀光_骑乘_归来去");
			SetAction(29,"太昊_骑乘_归来去");
			SetAction(30,"天华_骑乘_归来去");
			name = "归去来";
			nativename = "归去来";
			icon = "归去来.dds";
			SetTalent(0,1545);
			SetTalent(1,0);
			SetTalent(2,0);
			SetTalent(3,0);
			SetTalent(4,0);
			SetTalent(5,0);
			SetTalent(6,0);
			SetTalent(7,0);
			talent_size = 1;
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

			return 600000 - 18000 * skill_t0;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={90,95,100,105,110,115,120,125,125,125};return array[level-1];
		}
		public override float GetPraydistance(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (3 * skill_level + 14);
		}
		public override float GetCastdistance(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (3 * skill_level + 12);
		}
		public override float GetEffectdistance(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (3 * skill_level + 17);
		}
		public override float GetMpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (25 * skill_level + 2250);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();

			victim.SetProbability(999.0f);
			victim.SetTime(((3000 * skill_level + 15100)));
			victim.SetRatio((skill_level * 0.01f + 0.7f));
			victim.SetBuffid(9);
			victim.SetSlow(true);
			victim.SetProbability(100.0f);
			victim.SetTime(((3000 * skill_level + 15100)));
			victim.SetRatio((skill_level * 0.0401f));
			victim.SetBuffid(9);
			victim.SetDecskilldodge(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();

			victim.SetProbability(999.0f);
			victim.SetTime(((3000 * skill_level + 15100)));
			victim.SetRatio((skill_level * 0.01f + 0.7f));
			victim.SetBuffid(9);
			victim.SetSlow(true);
			victim.SetProbability(100.0f);
			victim.SetTime(((3000 * skill_level + 15100)));
			victim.SetRatio((skill_level * 0.0401f));
			victim.SetBuffid(9);
			victim.SetIncskilldodge(true);
			return true;
		}
		public override int GetCreditCost(int level)
		{
			int[] array={18000,20000,22000,24000,26000,28000,30000,32000,38000,45000};return array[level-1];
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={1520};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={2};return array[index];
		}
	}
	public class GSkill1521 : GSkill
	{
		public GSkill1521()
			: base(1521)
		{
			
		}
	}
	public class GSkill1522Stub : GSkillStub
	{
		public GSkill1522Stub()
			: base(1522)
		{
			occupation = 148;
			maxlevel = 12;
			maxlearn = 10;
			eventflag = 1;
			spcost = 0;
			reborncount = 0;
			type = 11;
			timetype = 0;
			targettype = 0;
			rangetype = 0;
			doenchant = false;
			dobless = false;
			autoattack = false;
			allowform = 0;
			credittype = 9;
			clearmask = 1;
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
			name = "自在心";
			nativename = "自在心";
			icon = "通用03.dds";
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
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={90,95,100,105,110,115,120,125,125,125};return array[level-1];
		}
		public override bool TakeEffect(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			int				skill_level = skill.GetLevel();

			player.SetPasaddwrap(((5 * skill_level)));
			player.SetPasaddsmite((D2INT(skill_level / 9.5f) * 0.15f));
			return true;
		}
		public override int GetCreditCost(int level)
		{
			int[] array={18000,20000,22000,24000,26000,28000,30000,32000,38000,45000};return array[level-1];
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={1520};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={2};return array[index];
		}
	}
	public class GSkill1522 : GSkill
	{
		public GSkill1522()
			: base(1522)
		{
			
		}
	}
	public class GSkill1523Stub : GSkillStub
	{
		public GSkill1523Stub()
			: base(1523)
		{
			occupation = 148;
			maxlevel = 12;
			maxlearn = 10;
			eventflag = 1;
			spcost = 0;
			reborncount = 0;
			type = 11;
			timetype = 0;
			targettype = 0;
			rangetype = 0;
			doenchant = false;
			dobless = false;
			autoattack = false;
			allowform = 0;
			credittype = 9;
			clearmask = 1;
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
			name = "弃红尘";
			nativename = "弃红尘";
			icon = "弃红尘.dds";
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
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={90,95,100,105,110,115,120,125,125,125};return array[level-1];
		}
		public override bool TakeEffect(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			int				skill_level = skill.GetLevel();

			player.SetPasaddsilent(((5 * skill_level)));
			player.SetPasinccrit((D2INT(skill_level / 9.5f) * 0.011f));
			return true;
		}
		public override int GetCreditCost(int level)
		{
			int[] array={18000,20000,22000,24000,26000,28000,30000,32000,38000,45000};return array[level-1];
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={1520};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={2};return array[index];
		}
	}
	public class GSkill1523 : GSkill
	{
		public GSkill1523()
			: base(1523)
		{
			
		}
	}
	public class GSkill1524Stub : GSkillStub
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
			public override bool Cancel(GSkill skill)
			{
				return true;
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
		public GSkill1524Stub()
			: base(1524)
		{
			occupation = 148;
			maxlevel = 12;
			maxlearn = 10;
			eventflag = 1;
			spcost = 0;
			reborncount = 0;
			type = 3;
			timetype = 0;
			targettype = 0;
			rangetype = 0;
			doenchant = true;
			dobless = false;
			autoattack = false;
			allowform = 0;
			credittype = 9;
			clearmask = 1;
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
			SetAction(0,"青云门_太虚诀");
			SetAction(1,"青云门_太虚诀");
			SetAction(2,"鬼王宗_太虚诀");
			SetAction(3,"合欢派_太虚诀");
			SetAction(4,"天音寺_太虚诀");
			SetAction(5,"鬼道_太虚诀");
			SetAction(6,"焚香谷_太虚诀");
			SetAction(7,"兽神_太虚诀");
			SetAction(8,"狐妖_太虚诀");
			SetAction(9,"0");
			SetAction(10,"怀光_太虚诀");
			SetAction(11,"太昊_太虚诀");
			SetAction(12,"天华_太虚诀");
			SetAction(13,"灵夙_太虚诀");
			SetAction(14,"英招_太虚诀");
			SetAction(15,"武器大师_太虚诀");
			SetAction(16,"元素大师_太虚诀");
			SetAction(17,"青云门_太虚诀");
			SetAction(18,"青云门_骑乘_太虚诀");
			SetAction(19,"青云门_骑乘_太虚诀");
			SetAction(20,"鬼王宗_骑乘_太虚诀");
			SetAction(21,"合欢派_骑乘_太虚诀");
			SetAction(22,"天音寺_骑乘_太虚诀");
			SetAction(23,"鬼道_骑乘_太虚诀");
			SetAction(24,"焚香谷_骑乘_太虚诀");
			SetAction(25,"兽神_骑乘_太虚诀");
			SetAction(26,"狐妖_骑乘_太虚诀");
			SetAction(27,"0");
			SetAction(28,"怀光_骑乘_太虚诀");
			SetAction(29,"太昊_骑乘_太虚诀");
			SetAction(30,"天华_骑乘_太虚诀");
			name = "太虚诀";
			nativename = "太虚诀";
			icon = "太虚诀.dds";
			SetTalent(0,1545);
			SetTalent(1,0);
			SetTalent(2,0);
			SetTalent(3,0);
			SetTalent(4,0);
			SetTalent(5,0);
			SetTalent(6,0);
			SetTalent(7,0);
			talent_size = 1;
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

			return 600000 - 18000 * skill_t0;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={90,95,100,105,110,115,120,125,125,125};return array[level-1];
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
			return 20.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (50 * skill_level + 1250);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_level = player.GetLevel();
			int				player_dodge = player.GetDodge();
			int				skill_level = skill.GetLevel();

			victim.SetProbability(100.0f);
			victim.SetTime(100.0f);
			victim.SetBuffid(1);
			victim.SetAmount((((player_level + player_dodge) * (skill_level + 12))));
			victim.SetValue(0.0f);
			victim.SetHpleak3(true);
			victim.SetProbability(((5 * skill_level + 15)));
			victim.SetTime(300000.0f);
			victim.SetRatio(1573.0f);
			victim.SetAmount(1574.0f);
			victim.SetValue(1575.0f);
			victim.SetSetcooldown(true);
			victim.SetProbability(((5 * skill_level + 15)));
			victim.SetTime(300000.0f);
			victim.SetRatio(1576.0f);
			victim.SetAmount(1577.0f);
			victim.SetValue(1578.0f);
			victim.SetSetcooldown(true);
			victim.SetProbability(((5 * skill_level + 15)));
			victim.SetTime(300000.0f);
			victim.SetRatio(1579.0f);
			victim.SetAmount(1580.0f);
			victim.SetValue(1581.0f);
			victim.SetSetcooldown(true);
			return true;
		}
		public override int GetCreditCost(int level)
		{
			int[] array={18000,20000,22000,24000,26000,28000,30000,32000,38000,45000};return array[level-1];
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={1520};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={2};return array[index];
		}
	}
	public class GSkill1524 : GSkill
	{
		public GSkill1524()
			: base(1524)
		{
			
		}
	}
	public class GSkill1525Stub : GSkillStub
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
			public override bool Cancel(GSkill skill)
			{
				return true;
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
		public GSkill1525Stub()
			: base(1525)
		{
			occupation = 148;
			maxlevel = 12;
			maxlearn = 10;
			eventflag = 0;
			spcost = 0;
			reborncount = 0;
			type = 3;
			timetype = 0;
			targettype = 0;
			rangetype = 0;
			doenchant = true;
			dobless = true;
			autoattack = false;
			allowform = 0;
			credittype = 9;
			clearmask = 1;
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
			SetAction(0,"青云门_玉真诀");
			SetAction(1,"青云门_玉真诀");
			SetAction(2,"鬼王宗_玉真诀");
			SetAction(3,"合欢派_玉真诀");
			SetAction(4,"天音寺_玉真诀");
			SetAction(5,"鬼道_玉真诀");
			SetAction(6,"焚香谷_玉真诀");
			SetAction(7,"兽神_玉真诀");
			SetAction(8,"狐妖_玉真诀");
			SetAction(9,"轩辕_玉真诀");
			SetAction(10,"怀光_玉真诀");
			SetAction(11,"太昊_玉真诀");
			SetAction(12,"天华_玉真诀");
			SetAction(13,"灵夙_玉真诀");
			SetAction(14,"英招_玉真诀");
			SetAction(15,"武器大师_玉真诀");
			SetAction(16,"元素大师_玉真诀");
			SetAction(17,"鬼王宗_玉真诀");
			SetAction(18,"青云门_骑乘_玉真诀");
			SetAction(19,"青云门_骑乘_玉真诀");
			SetAction(20,"鬼王宗_骑乘_玉真诀");
			SetAction(21,"合欢派_骑乘_玉真诀");
			SetAction(22,"天音寺_骑乘_玉真诀");
			SetAction(23,"鬼道_骑乘_玉真诀");
			SetAction(24,"焚香谷_骑乘_玉真诀");
			SetAction(25,"兽神_骑乘_玉真诀");
			SetAction(26,"狐妖_骑乘_玉真诀");
			SetAction(27,"轩辕_骑乘_玉真诀");
			SetAction(28,"怀光_骑乘_玉真诀");
			SetAction(29,"太昊_骑乘_玉真诀");
			SetAction(30,"天华_骑乘_玉真诀");
			name = "玉真诀";
			nativename = "玉真诀";
			icon = "玉真诀.dds";
			SetTalent(0,1545);
			SetTalent(1,0);
			SetTalent(2,0);
			SetTalent(3,0);
			SetTalent(4,0);
			SetTalent(5,0);
			SetTalent(6,0);
			SetTalent(7,0);
			talent_size = 1;
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

			return 900000 - 27000 * skill_t0;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={90,95,100,105,110,115,120,125,125,125};return array[level-1];
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
		public override float GetMpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (50 * skill_level + 1250);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_level = player.GetLevel();
			int				player_atkrate = player.GetAtkrate();
			int				skill_level = skill.GetLevel();

			victim.SetProbability(100.0f);
			victim.SetTime(100.0f);
			victim.SetBuffid(1);
			victim.SetAmount((((player_level + player_atkrate) * (skill_level + 9))));
			victim.SetValue(0.0f);
			victim.SetHpleak2(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();

			victim.SetRatio(((8 * norm(zrand(100) / (90 - 5 * skill_level)) + 1520)));
			victim.SetAmount(((9 * norm(zrand(100) / (90 - 5 * skill_level)) + 1520)));
			victim.SetValue(((10 * norm(zrand(100) / (90 - 5 * skill_level)) + 1520)));
			victim.SetClearcooldown(true);
			victim.SetProbability(120.0f);
			victim.SetTime(((900000 - 27000 * skill_t0)));
			victim.SetRatio(3014.0f);
			victim.SetAmount(3014.0f);
			victim.SetValue(3014.0f);
			victim.SetSetcooldown(true);
			return true;
		}
		public override int GetCreditCost(int level)
		{
			int[] array={18000,20000,22000,24000,26000,28000,30000,32000,38000,45000};return array[level-1];
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={1520};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={2};return array[index];
		}
	}
	public class GSkill1525 : GSkill
	{
		public GSkill1525()
			: base(1525)
		{
			
		}
	}
	public class GSkill1526Stub : GSkillStub
	{
		public class GState1 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 5000;
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
				return 1000;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();

				player.SetPerform(1);
			}
		}
		public GSkill1526Stub()
			: base(1526)
		{
			occupation = 148;
			maxlevel = 12;
			maxlearn = 10;
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
			credittype = 9;
			clearmask = 1;
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
			SetAction(0,"青云门_忘情水");
			SetAction(1,"青云门_忘情水");
			SetAction(2,"鬼王宗_忘情水");
			SetAction(3,"合欢派_忘情水");
			SetAction(4,"天音寺_忘情水");
			SetAction(5,"鬼道_忘情水");
			SetAction(6,"焚香谷_忘情水");
			SetAction(7,"兽神_忘情水");
			SetAction(8,"狐妖_忘情水");
			SetAction(9,"轩辕_忘情水");
			SetAction(10,"怀光_忘情水");
			SetAction(11,"太昊_忘情水");
			SetAction(12,"天华_忘情水");
			SetAction(13,"灵夙_忘情水");
			SetAction(14,"英招_忘情水");
			SetAction(15,"武器大师_忘情水");
			SetAction(16,"元素大师_忘情水");
			SetAction(17,"天音寺_忘情水");
			SetAction(18,"青云门_骑乘_忘情水");
			SetAction(19,"青云门_骑乘_忘情水");
			SetAction(20,"鬼王宗_骑乘_忘情水");
			SetAction(21,"合欢派_骑乘_忘情水");
			SetAction(22,"天音寺_骑乘_忘情水");
			SetAction(23,"鬼道_骑乘_忘情水");
			SetAction(24,"焚香谷_骑乘_忘情水");
			SetAction(25,"兽神_骑乘_忘情水");
			SetAction(26,"狐妖_骑乘_忘情水");
			SetAction(27,"轩辕_骑乘_忘情水");
			SetAction(28,"怀光_骑乘_忘情水");
			SetAction(29,"太昊_骑乘_忘情水");
			SetAction(30,"天华_骑乘_忘情水");
			name = "忘情水";
			nativename = "忘情水";
			icon = "忘情水.dds";
			SetTalent(0,1545);
			SetTalent(1,0);
			SetTalent(2,0);
			SetTalent(3,0);
			SetTalent(4,0);
			SetTalent(5,0);
			SetTalent(6,0);
			SetTalent(7,0);
			talent_size = 1;
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
			return 6000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			int				skill_t0 = skill.GetT0();

			return 900000 - 27000 * skill_t0;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={90,95,100,105,110,115,120,125,125,125};return array[level-1];
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
			return 1500.000000f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();

			victim.SetProbability(100.0f);
			victim.SetRatio(3600.0f);
			victim.SetAmount(1.0f);
			victim.SetValue(((skill_level + 20006)));
			victim.SetCreateitem(true);
			return true;
		}
		public override int GetCreditCost(int level)
		{
			int[] array={18000,20000,22000,24000,26000,28000,30000,32000,38000,45000};return array[level-1];
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={1520};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={3};return array[index];
		}
	}
	public class GSkill1526 : GSkill
	{
		public GSkill1526()
			: base(1526)
		{
			
		}
	}
	public class GSkill1527Stub : GSkillStub
	{
		public class GState1 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 5000;
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
				return 1000;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();

				player.SetPerform(1);
			}
		}
		public GSkill1527Stub()
			: base(1527)
		{
			occupation = 148;
			maxlevel = 12;
			maxlearn = 10;
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
			credittype = 9;
			clearmask = 1;
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
			SetAction(0,"青云门_长生酒");
			SetAction(1,"青云门_长生酒");
			SetAction(2,"鬼王宗_长生酒");
			SetAction(3,"合欢派_长生酒");
			SetAction(4,"天音寺_长生酒");
			SetAction(5,"鬼道_长生酒");
			SetAction(6,"焚香谷_长生酒");
			SetAction(7,"兽神_长生酒");
			SetAction(8,"狐妖_长生酒");
			SetAction(9,"轩辕_长生酒");
			SetAction(10,"怀光_长生酒");
			SetAction(11,"太昊_长生酒");
			SetAction(12,"天华_长生酒");
			SetAction(13,"灵夙_长生酒");
			SetAction(14,"英招_长生酒");
			SetAction(15,"武器大师_长生酒");
			SetAction(16,"元素大师_长生酒");
			SetAction(17,"天音寺_长生酒");
			SetAction(18,"青云门_骑乘_长生酒");
			SetAction(19,"青云门_骑乘_长生酒");
			SetAction(20,"鬼王宗_骑乘_长生酒");
			SetAction(21,"合欢派_骑乘_长生酒");
			SetAction(22,"天音寺_骑乘_长生酒");
			SetAction(23,"鬼道_骑乘_长生酒");
			SetAction(24,"焚香谷_骑乘_长生酒");
			SetAction(25,"兽神_骑乘_长生酒");
			SetAction(26,"狐妖_骑乘_长生酒");
			SetAction(27,"轩辕_骑乘_长生酒");
			SetAction(28,"怀光_骑乘_长生酒");
			SetAction(29,"太昊_骑乘_长生酒");
			SetAction(30,"天华_骑乘_长生酒");
			name = "长生酒";
			nativename = "长生酒";
			icon = "长生酒.dds";
			SetTalent(0,1545);
			SetTalent(1,0);
			SetTalent(2,0);
			SetTalent(3,0);
			SetTalent(4,0);
			SetTalent(5,0);
			SetTalent(6,0);
			SetTalent(7,0);
			talent_size = 1;
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
			return 6000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			int				skill_t0 = skill.GetT0();

			return 900000 - 27000 * skill_t0;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={90,95,100,105,110,115,120,125,125,125};return array[level-1];
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
			return 1500.000000f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();

			victim.SetProbability(100.0f);
			victim.SetRatio(3600.0f);
			victim.SetAmount(1.0f);
			victim.SetValue(((skill_level + 20026)));
			victim.SetCreateitem(true);
			return true;
		}
		public override int GetCreditCost(int level)
		{
			int[] array={18000,20000,22000,24000,26000,28000,30000,32000,38000,45000};return array[level-1];
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={1520};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={3};return array[index];
		}
	}
	public class GSkill1527 : GSkill
	{
		public GSkill1527()
			: base(1527)
		{
			
		}
	}
	public class GSkill1528Stub : GSkillStub
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
			public override bool Cancel(GSkill skill)
			{
				return true;
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

				skill.SetRatio((skill_level * 0.05f + 1.0f));
				player.SetPerform(1);
			}
		}
		public GSkill1528Stub()
			: base(1528)
		{
			occupation = 148;
			maxlevel = 12;
			maxlearn = 10;
			eventflag = 0;
			spcost = 0;
			reborncount = 0;
			type = 1;
			timetype = 0;
			targettype = 0;
			rangetype = 4;
			doenchant = true;
			dobless = false;
			autoattack = true;
			allowform = 0;
			credittype = 9;
			clearmask = 1;
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
			SetAction(0,"青云门_寂灭天");
			SetAction(1,"青云门_寂灭天");
			SetAction(2,"鬼王宗_寂灭天");
			SetAction(3,"合欢派_寂灭天");
			SetAction(4,"天音寺_寂灭天");
			SetAction(5,"鬼道_寂灭天");
			SetAction(6,"焚香谷_寂灭天");
			SetAction(7,"兽神_寂灭天");
			SetAction(8,"狐妖_寂灭天");
			SetAction(9,"轩辕_寂灭天");
			SetAction(10,"怀光_寂灭天");
			SetAction(11,"太昊_寂灭天");
			SetAction(12,"天华_寂灭天");
			SetAction(13,"灵夙_寂灭天");
			SetAction(14,"英招_寂灭天");
			SetAction(15,"武器大师_寂灭天");
			SetAction(16,"元素大师_寂灭天");
			SetAction(17,"天音寺_寂灭天");
			SetAction(18,"青云门_骑乘_寂灭天");
			SetAction(19,"青云门_骑乘_寂灭天");
			SetAction(20,"鬼王宗_骑乘_寂灭天");
			SetAction(21,"合欢派_骑乘_寂灭天");
			SetAction(22,"天音寺_骑乘_寂灭天");
			SetAction(23,"鬼道_骑乘_寂灭天");
			SetAction(24,"焚香谷_骑乘_寂灭天");
			SetAction(25,"兽神_骑乘_寂灭天");
			SetAction(26,"狐妖_骑乘_寂灭天");
			SetAction(27,"轩辕_骑乘_寂灭天");
			SetAction(28,"怀光_骑乘_寂灭天");
			SetAction(29,"太昊_骑乘_寂灭天");
			SetAction(30,"天华_骑乘_寂灭天");
			name = "寂灭天";
			nativename = "寂灭天";
			icon = "寂灭天.dds";
			SetTalent(0,1545);
			SetTalent(1,0);
			SetTalent(2,0);
			SetTalent(3,0);
			SetTalent(4,0);
			SetTalent(5,0);
			SetTalent(6,0);
			SetTalent(7,0);
			talent_size = 1;
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

			return 600000 - 18000 * skill_t0;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={90,95,100,105,110,115,120,125,125,125};return array[level-1];
		}
		public override float GetRadius(GSkill skill)
		{
			return 18.000000f;
		}
		public override float GetAngle(GSkill skill)
		{
			return -0.888887f;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 15.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 8.000000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return player_range + 6.0f;
		}
		public override float GetMpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (125 * skill_level + 1875);
		}
		public override int GetCoverage(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return 2 * skill_level + 18;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_level = player.GetLevel();
			int				skill_level = skill.GetLevel();

			victim.SetProbability(600.0f);
			victim.SetTime(((2000 * skill_level + 14100)));
			victim.SetRatio(0.80000001f);
			victim.SetBuffid(8);
			victim.SetSlow(true);
			victim.SetProbability((player_level * (skill_level * 0.1f + 1.9f)));
			victim.SetTime(((2000 * skill_level + 14100)));
			victim.SetSilent(true);
			return true;
		}
		public override int GetCreditCost(int level)
		{
			int[] array={18000,20000,22000,24000,26000,28000,30000,32000,38000,45000};return array[level-1];
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={1520};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={3};return array[index];
		}
	}
	public class GSkill1528 : GSkill
	{
		public GSkill1528()
			: base(1528)
		{
			
		}
	}
	public class GSkill1529Stub : GSkillStub
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
			public override bool Cancel(GSkill skill)
			{
				return true;
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
		public GSkill1529Stub()
			: base(1529)
		{
			occupation = 148;
			maxlevel = 12;
			maxlearn = 10;
			eventflag = 0;
			spcost = 0;
			reborncount = 0;
			type = 1;
			timetype = 0;
			targettype = 0;
			rangetype = 4;
			doenchant = true;
			dobless = false;
			autoattack = true;
			allowform = 0;
			credittype = 9;
			clearmask = 1;
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
			SetAction(0,"青云门_离恨天");
			SetAction(1,"青云门_离恨天");
			SetAction(2,"鬼王宗_离恨天");
			SetAction(3,"合欢派_离恨天");
			SetAction(4,"天音寺_离恨天");
			SetAction(5,"鬼道_离恨天");
			SetAction(6,"焚香谷_离恨天");
			SetAction(7,"兽神_离恨天");
			SetAction(8,"狐妖_离恨天");
			SetAction(9,"轩辕_离恨天");
			SetAction(10,"怀光_离恨天");
			SetAction(11,"太昊_离恨天");
			SetAction(12,"天华_离恨天");
			SetAction(13,"灵夙_离恨天");
			SetAction(14,"英招_离恨天");
			SetAction(15,"武器大师_离恨天");
			SetAction(16,"元素大师_离恨天");
			SetAction(17,"天音寺_离恨天");
			SetAction(18,"青云门_离恨天");
			SetAction(19,"青云门_骑乘_离恨天");
			SetAction(20,"鬼王宗_骑乘_离恨天");
			SetAction(21,"合欢派_骑乘_离恨天");
			SetAction(22,"天音寺_骑乘_离恨天");
			SetAction(23,"鬼道_骑乘_离恨天");
			SetAction(24,"焚香谷_骑乘_离恨天");
			SetAction(25,"兽神_骑乘_离恨天");
			SetAction(26,"狐妖_骑乘_离恨天");
			SetAction(27,"轩辕_骑乘_离恨天");
			SetAction(28,"怀光_骑乘_离恨天");
			SetAction(29,"太昊_骑乘_离恨天");
			SetAction(30,"天华_骑乘_离恨天");
			name = "离恨天";
			nativename = "离恨天";
			icon = "离恨天.dds";
			SetTalent(0,1545);
			SetTalent(1,0);
			SetTalent(2,0);
			SetTalent(3,0);
			SetTalent(4,0);
			SetTalent(5,0);
			SetTalent(6,0);
			SetTalent(7,0);
			talent_size = 1;
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

			return 600000 - 18000 * skill_t0;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={90,95,100,105,110,115,120,125,125,125};return array[level-1];
		}
		public override float GetRadius(GSkill skill)
		{
			return 18.000000f;
		}
		public override float GetAngle(GSkill skill)
		{
			return -0.888887f;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 18.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 8.000000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return player_range + 6.0f;
		}
		public override float GetMpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (125 * skill_level + 2000);
		}
		public override int GetCoverage(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return 2 * skill_level + 18;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_level = player.GetLevel();
			int				player_maxhp = player.GetMaxhp();
			int				skill_level = skill.GetLevel();

			victim.SetProbability(100.0f);
			victim.SetAmount(1.0f);
			victim.SetClearbuff(true);
			victim.SetTime((player.GetObjectType()!=0)?0.0f:3100.0f);
			victim.SetRatio((player.GetObjectType()!=0)?0.0f:(skill_level * 0.08f));
			victim.SetBuffid(1);
			victim.SetInchp(true);
			victim.SetProbability(((1.0f - player_level * 0.002f) * 100.0f));
			victim.SetTime(24000.0f);
			victim.SetBuffid(5);
			victim.SetAmount((player_maxhp * ((skill_level * 0.01f + 0.02f) * 12.0f)));
			victim.SetValue(0.0f);
			victim.SetHpleak1(true);
			return true;
		}
		public override int GetCreditCost(int level)
		{
			int[] array={18000,20000,22000,24000,26000,28000,30000,32000,38000,45000};return array[level-1];
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={1528};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={1};return array[index];
		}
	}
	public class GSkill1529 : GSkill
	{
		public GSkill1529()
			: base(1529)
		{
			
		}
	}
}
