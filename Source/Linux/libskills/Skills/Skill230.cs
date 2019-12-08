using System;
using System.Text;

namespace SKILL
{
	public class GSkill230Stub : GSkillStub
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
				int				skill_t1 = skill.GetT1();
				int				skill_t2 = skill.GetT2();

				skill.SetRatio(skill_t2 * 0.05f + 1.0f);
				skill.SetPlus((skill_t1 * 0.1f + 1.0f) * (((5 * skill_level) + (skill_level * (skill_level * 0.32f)) + 58.0f) * INT(skill_level * 0.05f + 0.55f) + (INT(1.42f - skill_level * 0.05f) * (6 * skill_level + 50))));
				player.SetPerform(1);
			}
		}
		public GSkill230Stub()
			: base(230)
		{
			occupation = 8;
			maxlevel = 20;
			maxlearn = 9;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 1;
			timetype = 0;
			targettype = 0;
			rangetype = 4;
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
			SetAction(0,"青云门_玄冰刺");
			SetAction(1,"青云门_玄冰刺");
			SetAction(2,"青云门_玄冰刺");
			SetAction(3,"青云门_玄冰刺");
			SetAction(4,"青云门_玄冰刺");
			SetAction(5,"青云门_玄冰刺");
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
			SetAction(18,"青云门_骑乘_玄冰刺");
			SetAction(19,"青云门_骑乘_玄冰刺");
			SetAction(20,"青云门_骑乘_玄冰刺");
			SetAction(21,"青云门_骑乘_玄冰刺");
			SetAction(22,"青云门_骑乘_玄冰刺");
			SetAction(23,"青云门_骑乘_玄冰刺");
			SetAction(24,"");
			SetAction(25,"");
			SetAction(26,"");
			SetAction(27,"");
			SetAction(28,"");
			SetAction(29,"");
			SetAction(30,"");
			name = "玄冰刺";
			nativename = "玄冰刺";
			icon = "玄冰刺.dds";
			SetTalent(0,571);
			SetTalent(1,602);
			SetTalent(2,617);
			SetTalent(3,0);
			SetTalent(4,0);
			SetTalent(5,0);
			SetTalent(6,0);
			SetTalent(7,0);
			talent_size = 3;
			talent_type = 0;
			use_proficiency = false;
			inc_proficiency = 0;
			preskillnum = 1;
			cycle = false;
			cyclemode = 0;
			cyclegfx = "";
			skill_class = 2;
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
		public override int GetEnmity(GSkill skill)
		{
			return 1;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={45,47,49,51,53,55,57,59,61};return array[level-1];
		}
		public override float GetRadius(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (skill_level * 0.2f + 6.3f);
		}
		public override float GetAngle(GSkill skill)
		{
			return -0.333332f;
		}
		public override float GetPraydistance(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (skill_level * 0.2f + 6.3f);
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 3.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (skill_level * 5.1f + (skill_level * (skill_level * 0.35f)) + 89.0f);
		}
		public override int GetCoverage(GSkill skill)
		{
			return 24;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();

			victim.SetProbability(((5 * skill_level + 40)));
			victim.SetTime(((500 * skill_level + 2600)));
			victim.SetRatio((skill_level * 0.04f + 0.18f));
			victim.SetBuffid(1);
			victim.SetSlow(true);
			victim.SetProbability(-1.0f);
			victim.SetTime(((2000 * skill_t0 + (4000 * norm(skill_t0)) + 100)));
			victim.SetBuffid(1);
			victim.SetValue(((15 * skill_t0)));
			victim.SetSubattack(true);
			victim.SetProbability(33.0f);
			victim.SetValue(10.0f);
			victim.SetRepel(true);
			return true;
		}
		public override float GetDropRate(GSkill skill)
		{
			return 0.500000f;
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={24};return array[index];
		}
	}
	public class GSkill230 : GSkill
	{
		public GSkill230()
			: base(230)
		{
			
		}
	}
	public class GSkill231Stub : GSkillStub
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
			public override bool Cancel(GSkill skill)
			{
				return true;
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
		public GSkill231Stub()
			: base(231)
		{
			occupation = 7;
			maxlevel = 12;
			maxlearn = 8;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 2;
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
			SetAction(0,"青云门_五气朝元");
			SetAction(1,"青云门_五气朝元");
			SetAction(2,"青云门_五气朝元");
			SetAction(3,"青云门_五气朝元");
			SetAction(4,"青云门_五气朝元");
			SetAction(5,"青云门_五气朝元");
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
			SetAction(18,"青云门_骑乘_五气朝元");
			SetAction(19,"青云门_骑乘_五气朝元");
			SetAction(20,"青云门_骑乘_五气朝元");
			SetAction(21,"青云门_骑乘_五气朝元");
			SetAction(22,"青云门_骑乘_五气朝元");
			SetAction(23,"青云门_骑乘_五气朝元");
			SetAction(24,"");
			SetAction(25,"");
			SetAction(26,"");
			SetAction(27,"");
			SetAction(28,"");
			SetAction(29,"");
			SetAction(30,"");
			name = "五气朝元";
			nativename = "五气朝元";
			icon = "五气朝元.dds";
			SetTalent(0,586);
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
			skill_class = 2;
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
			return 2000;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={25,29,33,37,41,43,47,49};return array[level-1];
		}
		public override float GetRadius(GSkill skill)
		{
			return 18.000000f;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 18.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 10.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return ((46 * skill_level) + (skill_level * (skill_level * 1.5f)) + 206.0f);
		}
		public override int GetCoverage(GSkill skill)
		{
			return 40;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();

			victim.SetProbability(100.0f);
			victim.SetTime(900000 * skill_t0 + 1800000);
			victim.SetRatio(skill_level * (skill_t0 * 0.01f + 0.05f));
			victim.SetBuffid(1);
			victim.SetValue(0.0f);
			victim.SetZhaoqi(true);
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={233};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={4};return array[index];
		}
	}
	public class GSkill231 : GSkill
	{
		public GSkill231()
			: base(231)
		{
			
		}
	}
	public class GSkill232Stub : GSkillStub
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
				int				skill_t2 = skill.GetT2();

				skill.SetCrit(skill_t2 * 0.01f + (INT(skill_level / 9) * (skill_t2 * 0.01f)));
				skill.SetCrithurt(INT(skill_level / 9) * (skill_t2 * 0.3f));
				int level_sum = 0;
				if (player.GetSkilllevel(237) > 8) level_sum ++;
				if (player.GetSkilllevel(222) > 8) level_sum ++;
				if (player.GetSkilllevel(232) > 8) level_sum ++;
				if (player.GetSkilllevel(228) > 8) level_sum ++;
				if (player.GetSkilllevel(312) > 8) level_sum ++;
				if (player.GetSkilllevel(240) > 8) level_sum ++;
				if (player.GetSkilllevel(541) > 8) level_sum ++;
				if (player.GetSkilllevel(545) > 8) level_sum ++;
				skill.SetRatio(((0.05f * level_sum) * skill_t2 * norm(skill_t2) + 1.0f) + (0.05f * skill_t2));
				skill.SetCrit(skill_t2 * 0.03f);
				skill.SetPlus(((23 * skill_level) + (skill_level * (skill_level * 0.66f)) + 11.0f) * INT(skill_level * 0.05f + 0.55f) + (INT(1.42f - skill_level * 0.05f) * (14 * skill_level + 137)));
				player.SetPerform(1);
			}
		}
		public GSkill232Stub()
			: base(232)
		{
			occupation = 7;
			maxlevel = 20;
			maxlearn = 9;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 1;
			timetype = 0;
			targettype = 0;
			rangetype = 0;
			doenchant = true;
			dobless = true;
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
			SetAction(0,"青云门_归元剑气");
			SetAction(1,"青云门_归元剑气");
			SetAction(2,"青云门_归元剑气");
			SetAction(3,"青云门_归元剑气");
			SetAction(4,"青云门_归元剑气");
			SetAction(5,"青云门_归元剑气");
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
			SetAction(18,"青云门_骑乘_归元剑气");
			SetAction(19,"青云门_骑乘_归元剑气");
			SetAction(20,"青云门_骑乘_归元剑气");
			SetAction(21,"青云门_骑乘_归元剑气");
			SetAction(22,"青云门_骑乘_归元剑气");
			SetAction(23,"青云门_骑乘_归元剑气");
			SetAction(24,"");
			SetAction(25,"");
			SetAction(26,"");
			SetAction(27,"");
			SetAction(28,"");
			SetAction(29,"");
			SetAction(30,"");
			name = "归元剑气";
			nativename = "归元剑气";
			icon = "归元剑气.dds";
			SetTalent(0,570);
			SetTalent(1,579);
			SetTalent(2,583);
			SetTalent(3,604);
			SetTalent(4,0);
			SetTalent(5,0);
			SetTalent(6,0);
			SetTalent(7,0);
			talent_size = 4;
			talent_type = 0;
			use_proficiency = false;
			inc_proficiency = 0;
			preskillnum = 1;
			cycle = false;
			cyclemode = 0;
			cyclegfx = "";
			skill_class = 2;
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
			int				skill_t1 = skill.GetT1();

			return 6000 - 1000 * skill_t1;
		}
		public override int GetEnmity(GSkill skill)
		{
			return 1;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={40,42,44,46,48,50,52,54,56};return array[level-1];
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
			int				skill_level = skill.GetLevel();

			return (2 * skill_level + 39);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_t3 = skill.GetT3();

			victim.SetProbability(15 * skill_t3);
			victim.SetValue(9.0f);
			victim.SetRepel(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_level = player.GetLevel();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();
			int				skill_t3 = skill.GetT3();

			victim.SetProbability(120.0f);
			victim.SetTime(2000 * skill_t0 + 3100);
			victim.SetBuffid(1);
			victim.SetValue((INT(zrand(100) / (100 - 6 * skill_t3)) + 1) * (skill_t0 * (player_level * 0.5f) + ((6 * skill_level))));
			victim.SetAddattack(true);
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={222};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={6};return array[index];
		}
	}
	public class GSkill232 : GSkill
	{
		public GSkill232()
			: base(232)
		{
			
		}
	}
	public class GSkill233Stub : GSkillStub
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
		public GSkill233Stub()
			: base(233)
		{
			occupation = 7;
			maxlevel = 12;
			maxlearn = 5;
			eventflag = 1;
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
			SetAction(0,"青云门_逍遥游");
			SetAction(1,"青云门_逍遥游");
			SetAction(2,"青云门_逍遥游");
			SetAction(3,"青云门_逍遥游");
			SetAction(4,"青云门_逍遥游");
			SetAction(5,"青云门_逍遥游");
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
			SetAction(18,"青云门_骑乘_逍遥游");
			SetAction(19,"青云门_骑乘_逍遥游");
			SetAction(20,"青云门_骑乘_逍遥游");
			SetAction(21,"青云门_骑乘_逍遥游");
			SetAction(22,"青云门_骑乘_逍遥游");
			SetAction(23,"青云门_骑乘_逍遥游");
			SetAction(24,"");
			SetAction(25,"");
			SetAction(26,"");
			SetAction(27,"");
			SetAction(28,"");
			SetAction(29,"");
			SetAction(30,"");
			name = "逍遥游";
			nativename = "逍遥游";
			icon = "逍遥游.dds";
			SetTalent(0,592);
			SetTalent(1,596);
			SetTalent(2,601);
			SetTalent(3,0);
			SetTalent(4,0);
			SetTalent(5,0);
			SetTalent(6,0);
			SetTalent(7,0);
			talent_size = 3;
			talent_type = 0;
			use_proficiency = false;
			inc_proficiency = 0;
			preskillnum = 1;
			cycle = false;
			cyclemode = 0;
			cyclegfx = "";
			skill_class = 2;
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
			int				skill_t1 = skill.GetT1();

			return 120000 - 10000 * skill_t1;
		}
		public override int GetEnmity(GSkill skill)
		{
			return 1;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={16,18,19,22,25};return array[level-1];
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
			int				skill_level = skill.GetLevel();

			return (skill_level * 0.47f + (skill_level * (skill_level * 0.55f)) + 45.0f);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();
			int				skill_t2 = skill.GetT2();

			victim.SetProbability(120.0f);
			victim.SetTime(5000 * skill_t2 + (2000 * skill_level) + 10100);
			victim.SetBuffid(1);
			victim.SetValue(skill_level * 0.4f + 0.2f);
			victim.SetAddspeed(true);
			victim.SetTime(5000 * skill_t2 + (2000 * skill_level) + 10100);
			victim.SetRatio(skill_t2 * (skill_level * 0.25f) + (skill_level * (skill_level * 0.02f) + (skill_level * 0.1f)));
			victim.SetBuffid(2);
			victim.SetIncmpgen(true);
			victim.SetProbability(100.0f);
			victim.SetTime(4000 * norm(skill_t0));
			victim.SetBuffid(1);
			victim.SetAmount(0.0f);
			victim.SetValue(skill_t0 * 0.15f * (skill_level * 0.47f + (skill_level * (skill_level * 0.55f)) + 45.0f));
			victim.SetMpgen(true);
			return true;
		}
		public override bool TakeEffect(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			int				skill_level = skill.GetLevel();

			player.SetPasaddwrap(skill_level * 2.7f + 7.5f);
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={223};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={1};return array[index];
		}
	}
	public class GSkill233 : GSkill
	{
		public GSkill233()
			: base(233)
		{
			
		}
	}
	public class GSkill234Stub : GSkillStub
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
			public override bool Cancel(GSkill skill)
			{
				return true;
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
				int				skill_level = skill.GetLevel();
				int				skill_t0 = skill.GetT0();
				int				skill_t1 = skill.GetT1();
				int				skill_t3 = skill.GetT3();

				skill.SetRatio((skill_t1 * (D2INT(zrand(100) / (100 - 6 * skill_t1)) * 0.2f) + (skill_t3 * 0.05f + 1.0f)));
				skill.SetPlus((((zrand(15 * skill_t0 + 10) - 10) * norm(skill_t0 + 0.1f) + 100) / 100.0f * ((47 * skill_level + 49) * (D2INT(skill_level * 0.05f + 0.55f) * 0.9f) + ((skill_level * 8.6f + 324.0f) * (D2INT(1.42f - skill_level * 0.05f) * 0.9f)))));
				player.SetPerform(1);
			}
		}
		public GSkill234Stub()
			: base(234)
		{
			occupation = 8;
			maxlevel = 20;
			maxlearn = 9;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 1;
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
			SetAction(0,"青云门_雷云风暴");
			SetAction(1,"青云门_雷云风暴");
			SetAction(2,"青云门_雷云风暴");
			SetAction(3,"青云门_雷云风暴");
			SetAction(4,"青云门_雷云风暴");
			SetAction(5,"青云门_雷云风暴");
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
			SetAction(18,"青云门_骑乘_雷云风暴");
			SetAction(19,"青云门_骑乘_雷云风暴");
			SetAction(20,"青云门_骑乘_雷云风暴");
			SetAction(21,"青云门_骑乘_雷云风暴");
			SetAction(22,"青云门_骑乘_雷云风暴");
			SetAction(23,"青云门_骑乘_雷云风暴");
			SetAction(24,"");
			SetAction(25,"");
			SetAction(26,"");
			SetAction(27,"");
			SetAction(28,"");
			SetAction(29,"");
			SetAction(30,"");
			name = "雷云风暴";
			nativename = "雷云风暴";
			icon = "雷云风暴.dds";
			SetTalent(0,607);
			SetTalent(1,609);
			SetTalent(2,611);
			SetTalent(3,617);
			SetTalent(4,0);
			SetTalent(5,0);
			SetTalent(6,0);
			SetTalent(7,0);
			talent_size = 4;
			talent_type = 0;
			use_proficiency = false;
			inc_proficiency = 0;
			preskillnum = 1;
			cycle = false;
			cyclemode = 0;
			cyclegfx = "";
			skill_class = 2;
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
			return 2000;
		}
		public override int GetEnmity(GSkill skill)
		{
			return 1;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={60,62,64,66,68,70,72,74,76};return array[level-1];
		}
		public override float GetRadius(GSkill skill)
		{
			return 12.000000f;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 9.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 4.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (skill_level * 2.7f + (skill_level * (skill_level * 1.2f)) + 100.0f);
		}
		public override int GetCoverage(GSkill skill)
		{
			return 25;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_t2 = skill.GetT2();

			victim.SetProbability(((600 * D2INT(zrand(100) / (100 - 4 * skill_t2)))));
			victim.SetTime(((3050 * skill_t2)));
			victim.SetRatio((skill_t2 * 0.1f));
			victim.SetBuffid(1);
			victim.SetWeak(true);
			return true;
		}
		public override float GetDropRate(GSkill skill)
		{
			return 0.500000f;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={239};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={5};return array[index];
		}
	}
	public class GSkill234 : GSkill
	{
		public GSkill234()
			: base(234)
		{
			
		}
	}
	public class GSkill235Stub : GSkillStub
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
		public GSkill235Stub()
			: base(235)
		{
			occupation = 8;
			maxlevel = 9;
			maxlearn = 7;
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
			SetAction(0,"青云门_真元护体");
			SetAction(1,"青云门_真元护体");
			SetAction(2,"青云门_真元护体");
			SetAction(3,"青云门_真元护体");
			SetAction(4,"青云门_真元护体");
			SetAction(5,"青云门_真元护体");
			SetAction(6,"0");
			SetAction(7,"0");
			SetAction(8,"0");
			SetAction(9,"0");
			SetAction(10,"0");
			SetAction(11,"0");
			SetAction(12,"0");
			SetAction(13,"0");
			SetAction(14,"0");
			SetAction(15,"0");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"青云门_骑乘_真元护体");
			SetAction(19,"青云门_骑乘_真元护体");
			SetAction(20,"青云门_骑乘_真元护体");
			SetAction(21,"青云门_骑乘_真元护体");
			SetAction(22,"青云门_骑乘_真元护体");
			SetAction(23,"青云门_骑乘_真元护体");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "真元护体";
			nativename = "真元护体";
			icon = "真元护体.dds";
			SetTalent(0,588);
			SetTalent(1,592);
			SetTalent(2,596);
			SetTalent(3,1589);
			SetTalent(4,0);
			SetTalent(5,0);
			SetTalent(6,0);
			SetTalent(7,0);
			talent_size = 4;
			talent_type = 0;
			use_proficiency = false;
			inc_proficiency = 0;
			preskillnum = 1;
			cycle = false;
			cyclemode = 0;
			cyclegfx = "";
			skill_class = 2;
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
			int				skill_level = skill.GetLevel();
			int				skill_t2 = skill.GetT2();

			return (-5000 * skill_level) - 10000 * skill_t2 + 125000;
		}
		public override int GetEnmity(GSkill skill)
		{
			return 1;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={46,48,52,57,63,69,76};return array[level-1];
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
			int				skill_level = skill.GetLevel();

			return (5 * skill_level * skill_level + (100 * skill_level));
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_maxmp = player.GetMaxmp();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();
			int				skill_t1 = skill.GetT1();

			victim.SetTime(30100.0f);
			victim.SetRatio((skill_t0 * 0.1f + (skill_level * 0.01f + 0.08f)));
			victim.SetAmount(((skill_level * player_maxmp)));
			victim.SetMagicshield(true);
			victim.SetProbability(100.0f);
			victim.SetTime(((4000 * norm(skill_t1))));
			victim.SetBuffid(1);
			victim.SetAmount(0.0f);
			victim.SetValue((skill_t1 * ((5 * skill_level * skill_level + (100 * skill_level)) * 0.15f)));
			victim.SetMpgen(true);
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={230};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={1};return array[index];
		}
	}
	public class GSkill235 : GSkill
	{
		public GSkill235()
			: base(235)
		{
			
		}
	}
	public class GSkill236Stub : GSkillStub
	{
		public class GState1 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 2600;
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
				return 400;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();

				player.SetPerform(1);
			}
		}
		public GSkill236Stub()
			: base(236)
		{
			occupation = 9;
			maxlevel = 12;
			maxlearn = 8;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 3;
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
			SetAction(0,"青云门_雷霆震怒");
			SetAction(1,"青云门_雷霆震怒");
			SetAction(2,"青云门_雷霆震怒");
			SetAction(3,"青云门_雷霆震怒");
			SetAction(4,"青云门_雷霆震怒");
			SetAction(5,"青云门_雷霆震怒");
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
			SetAction(18,"青云门_骑乘_雷霆震怒");
			SetAction(19,"青云门_骑乘_雷霆震怒");
			SetAction(20,"青云门_骑乘_雷霆震怒");
			SetAction(21,"青云门_骑乘_雷霆震怒");
			SetAction(22,"青云门_骑乘_雷霆震怒");
			SetAction(23,"青云门_骑乘_雷霆震怒");
			SetAction(24,"");
			SetAction(25,"");
			SetAction(26,"");
			SetAction(27,"");
			SetAction(28,"");
			SetAction(29,"");
			SetAction(30,"");
			name = "雷霆震怒";
			nativename = "雷霆震怒";
			icon = "雷霆震怒.dds";
			SetTalent(0,593);
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
			skill_class = 2;
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
			return 60000;
		}
		public override int GetEnmity(GSkill skill)
		{
			return 1;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={80,82,84,86,88,90,92,94};return array[level-1];
		}
		public override float GetRadius(GSkill skill)
		{
			return 11.000000f;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 19.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 10.700000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 21.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (skill_level * 1.2f + (skill_level * (skill_level * 1.9f)) + 540.0f);
		}
		public override int GetCoverage(GSkill skill)
		{
			return 35;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();

			victim.SetProbability(((3 * skill_t0 * skill_level) + (((10 * skill_level + 91)) - skill_level * (skill_level * 0.18f))));
			victim.SetTime(((300 * skill_t0 * skill_level + (330 * skill_level) + 800)));
			victim.SetWrap(true);
			return true;
		}
		public override float GetDropRate(GSkill skill)
		{
			return 0.500000f;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={238};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={3};return array[index];
		}
	}
	public class GSkill236 : GSkill
	{
		public GSkill236()
			: base(236)
		{
			
		}
	}
	public class GSkill237Stub : GSkillStub
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
			public override bool Cancel(GSkill skill)
			{
				return true;
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
				int				player_mp = player.GetMp();
				int				player_maxmp = player.GetMaxmp();
				int				skill_level = skill.GetLevel();
				int				skill_t0 = skill.GetT0();
				int				skill_t2 = skill.GetT2();
				int				skill_t3 = skill.GetT3();

				skill.SetCrit((skill_t2 * 0.01f + (D2INT(skill_level / 9) * (skill_t2 * 0.01f))));
				skill.SetCrithurt((D2INT(skill_level / 9) * (skill_t2 * 0.3f)));
				int level_sum = 0;
				if (player.GetSkilllevel(237) > 8) level_sum ++;
				if (player.GetSkilllevel(222) > 8) level_sum ++;
				if (player.GetSkilllevel(232) > 8) level_sum ++;
				if (player.GetSkilllevel(228) > 8) level_sum ++;
				if (player.GetSkilllevel(312) > 8) level_sum ++;
				if (player.GetSkilllevel(240) > 8) level_sum ++;
				if (player.GetSkilllevel(541) > 8) level_sum ++;
				if (player.GetSkilllevel(545) > 8) level_sum ++;
				skill.SetRatio(((D2INT((player_mp / (0.95f - skill_t3 * 0.1f)) / player_maxmp) * 0.12f + (skill_t2 * 0.05f + 1.0f)) + ((0.05f * level_sum) * skill_t2 * norm(skill_t2))));
				skill.SetPlus(((25 * skill_t0 * skill_level) + (((77 * skill_level) + (skill_level * (skill_level * 1.8f)) + 636.0f) * (D2INT(skill_level * 0.05f + 0.55f)) + ((((114 * skill_level + 901)) - skill_level * (skill_level * 6.4f)) * (D2INT(1.42f - skill_level * 0.05f))))));
				player.SetPerform(1);
			}
		}
		public GSkill237Stub()
			: base(237)
		{
			occupation = 9;
			maxlevel = 20;
			maxlearn = 9;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 1;
			timetype = 0;
			targettype = 0;
			rangetype = 0;
			doenchant = true;
			dobless = true;
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
			SetAction(0,"青云门_怒剑狂花");
			SetAction(1,"青云门_怒剑狂花");
			SetAction(2,"青云门_怒剑狂花");
			SetAction(3,"青云门_怒剑狂花");
			SetAction(4,"青云门_怒剑狂花");
			SetAction(5,"青云门_怒剑狂花");
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
			SetAction(18,"青云门_骑乘_怒剑狂花");
			SetAction(19,"青云门_骑乘_怒剑狂花");
			SetAction(20,"青云门_骑乘_怒剑狂花");
			SetAction(21,"青云门_骑乘_怒剑狂花");
			SetAction(22,"青云门_骑乘_怒剑狂花");
			SetAction(23,"青云门_骑乘_怒剑狂花");
			SetAction(24,"");
			SetAction(25,"");
			SetAction(26,"");
			SetAction(27,"");
			SetAction(28,"");
			SetAction(29,"");
			SetAction(30,"");
			name = "怒剑狂花";
			nativename = "怒剑狂花";
			icon = "怒剑狂花.dds";
			SetTalent(0,576);
			SetTalent(1,579);
			SetTalent(2,583);
			SetTalent(3,612);
			SetTalent(4,0);
			SetTalent(5,0);
			SetTalent(6,0);
			SetTalent(7,0);
			talent_size = 4;
			talent_type = 0;
			use_proficiency = false;
			inc_proficiency = 0;
			preskillnum = 1;
			cycle = false;
			cyclemode = 0;
			cyclegfx = "";
			skill_class = 2;
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
			int				skill_t1 = skill.GetT1();

			return 8000 - 1000 * skill_t1;
		}
		public override int GetEnmity(GSkill skill)
		{
			return 1;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={85,87,89,91,93,95,97,99,101};return array[level-1];
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 18.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 10.700000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 21.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (skill_level * 0.72f + (skill_level * (skill_level * 1.4f)) + 364.0f);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_level = player.GetLevel();
			int				skill_level = skill.GetLevel();

			victim.SetProbability(((1.0f - player_level * 0.002f) * 100.0f));
			victim.SetTime(8000.0f);
			victim.SetBuffid(1);
			victim.SetAmount(((340 * skill_level + 2956)));
			victim.SetValue(0.0f);
			victim.SetHpleak(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_mp = player.GetMp();
			int				player_maxmp = player.GetMaxmp();
			int				skill_t3 = skill.GetT3();

			victim.SetBuffid((D2INT((player_mp / (0.95f - skill_t3 * 0.1f)) / player_maxmp)));
			victim.SetUniqprompt(true);
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={461};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={2};return array[index];
		}
	}
	public class GSkill237 : GSkill
	{
		public GSkill237()
			: base(237)
		{
			
		}
	}
	public class GSkill238Stub : GSkillStub
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
			public override bool Cancel(GSkill skill)
			{
				return true;
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
				int				skill_level = skill.GetLevel();
				int				skill_t0 = skill.GetT0();
				int				skill_t1 = skill.GetT1();
				int				skill_t3 = skill.GetT3();

				skill.SetCrit((skill_t1 * 0.02f));
				skill.SetRatio((skill_t3 * 0.05f + 1.0f));
				skill.SetPlus((((zrand(15 * skill_t0 + 10) - 10) * norm(skill_t0 + 0.1f) + 100) / 100.0f * (((32 * skill_level) + (skill_level * (skill_level * 0.83f)) + 309.0f) * (D2INT(skill_level * 0.05f + 0.55f) * 0.9f) + ((skill_level * 8.4f + (skill_level * (skill_level * 0.52f)) + 474.0f) * (D2INT(1.42f - skill_level * 0.05f) * 0.9f)))));
				player.SetPerform(1);
			}
		}
		public GSkill238Stub()
			: base(238)
		{
			occupation = 9;
			maxlevel = 20;
			maxlearn = 9;
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
			SetAction(0,"青云门_五雷轰顶");
			SetAction(1,"青云门_五雷轰顶");
			SetAction(2,"青云门_五雷轰顶");
			SetAction(3,"青云门_五雷轰顶");
			SetAction(4,"青云门_五雷轰顶");
			SetAction(5,"青云门_五雷轰顶");
			SetAction(6,"0");
			SetAction(7,"0");
			SetAction(8,"0");
			SetAction(9,"0");
			SetAction(10,"0");
			SetAction(11,"0");
			SetAction(12,"0");
			SetAction(13,"0");
			SetAction(14,"0");
			SetAction(15,"0");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"青云门_骑乘_五雷轰顶");
			SetAction(19,"青云门_骑乘_五雷轰顶");
			SetAction(20,"青云门_骑乘_五雷轰顶");
			SetAction(21,"青云门_骑乘_五雷轰顶");
			SetAction(22,"青云门_骑乘_五雷轰顶");
			SetAction(23,"青云门_骑乘_五雷轰顶");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "五雷轰顶";
			nativename = "五雷轰顶";
			icon = "五雷轰顶.dds";
			SetTalent(0,606);
			SetTalent(1,608);
			SetTalent(2,610);
			SetTalent(3,617);
			SetTalent(4,0);
			SetTalent(5,0);
			SetTalent(6,0);
			SetTalent(7,0);
			talent_size = 4;
			talent_type = 0;
			use_proficiency = false;
			inc_proficiency = 0;
			preskillnum = 1;
			cycle = false;
			cyclemode = 0;
			cyclegfx = "";
			skill_class = 2;
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
			return 2000;
		}
		public override int GetEnmity(GSkill skill)
		{
			return 1;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={75,77,79,81,83,85,87,89,91};return array[level-1];
		}
		public override float GetRadius(GSkill skill)
		{
			return 9.000000f;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 18.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 10.700000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 21.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return ((11 * skill_level) + (skill_level * (skill_level * 0.82f)) + 184.0f);
		}
		public override int GetCoverage(GSkill skill)
		{
			return 30;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_t1 = skill.GetT1();
			int				skill_t2 = skill.GetT2();

			victim.SetProbability(((10 * skill_t1)));
			victim.SetAmount(1.0f);
			victim.SetClearbuff(true);
			victim.SetProbability(((5 * skill_t2)));
			victim.SetTime(((3050 * skill_t2)));
			victim.SetRatio((skill_t2 * 0.05f));
			victim.SetBuffid(1);
			victim.SetDecdefence(true);
			return true;
		}
		public override float GetDropRate(GSkill skill)
		{
			return 0.500000f;
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={24};return array[index];
		}
	}
	public class GSkill238 : GSkill
	{
		public GSkill238()
			: base(238)
		{
			
		}
	}
	public class GSkill239Stub : GSkillStub
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
				int				skill_level = skill.GetLevel();

				int hpnow = player_hp;
				int hpdec = 120 * skill_level + 120;
				player.SetHp(((norm(player_hp / hpdec) * (hpnow - hpdec) + 1)));
				player.SetPerform(1);
			}
		}
		public GSkill239Stub()
			: base(239)
		{
			occupation = 8;
			maxlevel = 12;
			maxlearn = 8;
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
			SetAction(0,"青云门_炼气还神");
			SetAction(1,"青云门_炼气还神");
			SetAction(2,"青云门_炼气还神");
			SetAction(3,"青云门_炼气还神");
			SetAction(4,"青云门_炼气还神");
			SetAction(5,"青云门_炼气还神");
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
			SetAction(18,"青云门_骑乘_炼气还神");
			SetAction(19,"青云门_骑乘_炼气还神");
			SetAction(20,"青云门_骑乘_炼气还神");
			SetAction(21,"青云门_骑乘_炼气还神");
			SetAction(22,"青云门_骑乘_炼气还神");
			SetAction(23,"青云门_骑乘_炼气还神");
			SetAction(24,"");
			SetAction(25,"");
			SetAction(26,"");
			SetAction(27,"");
			SetAction(28,"");
			SetAction(29,"");
			SetAction(30,"");
			name = "炼气还神";
			nativename = "炼气还神";
			icon = "炼气还神.dds";
			SetTalent(0,589);
			SetTalent(1,592);
			SetTalent(2,596);
			SetTalent(3,0);
			SetTalent(4,0);
			SetTalent(5,0);
			SetTalent(6,0);
			SetTalent(7,0);
			talent_size = 3;
			talent_type = 0;
			use_proficiency = false;
			inc_proficiency = 0;
			preskillnum = 1;
			cycle = false;
			cyclemode = 0;
			cyclegfx = "";
			skill_class = 2;
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
			int				skill_t2 = skill.GetT2();

			return 120000 - 10000 * skill_t2;
		}
		public override int GetEnmity(GSkill skill)
		{
			return 1;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={50,52,54,56,58,60,62,64};return array[level-1];
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
			int				player_hp = player.GetHp();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();
			int				skill_t1 = skill.GetT1();

			victim.SetProbability(120.0f);
			victim.SetTime(((2000 * skill_level + 2000)));
			victim.SetBuffid(5);
			victim.SetAmount(0.0f);
			victim.SetValue(((D2INT(zrand(100) / (100 - 16 * skill_t0)) + 1) * ((skill_t0 * 0.6f + 1.0f) * (norm(((120 * skill_level) + 120.5f) / player_hp) * (player_hp * (skill_level * 0.05f + 0.95f)) + (norm(player_hp / ((120 * skill_level) + 120.5f)) * ((120 * skill_level + 120) * (skill_level * 0.05f + 1.0f)))))));
			victim.SetMpgen(true);
			victim.SetTime(((6050 * norm(skill_t1))));
			victim.SetRatio((skill_t1 * 0.03f));
			victim.SetBuffid(1);
			victim.SetIncskilldamage(true);
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={230};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={3};return array[index];
		}
	}
	public class GSkill239 : GSkill
	{
		public GSkill239()
			: base(239)
		{
			
		}
	}
}
