using System;
using System.Text;

namespace SKILL
{
	public class GSkill540Stub : GSkillStub
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
		public GSkill540Stub()
			: base(540)
		{
			occupation = 19;
			maxlevel = 18;
			maxlearn = 7;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 3;
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
			SetAction(0,"青云门_极度深寒");
			SetAction(1,"青云门_极度深寒");
			SetAction(2,"青云门_极度深寒");
			SetAction(3,"青云门_极度深寒");
			SetAction(4,"青云门_极度深寒");
			SetAction(5,"青云门_极度深寒");
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
			SetAction(18,"青云门_骑乘_极度深寒");
			SetAction(19,"青云门_骑乘_极度深寒");
			SetAction(20,"青云门_骑乘_极度深寒");
			SetAction(21,"青云门_骑乘_极度深寒");
			SetAction(22,"青云门_骑乘_极度深寒");
			SetAction(23,"青云门_骑乘_极度深寒");
			SetAction(24,"");
			SetAction(25,"");
			SetAction(26,"");
			SetAction(27,"");
			SetAction(28,"");
			SetAction(29,"");
			SetAction(30,"");
			name = "极度深寒";
			nativename = "极度深寒";
			icon = "极度深寒.dds";
			SetTalent(0,592);
			SetTalent(1,596);
			SetTalent(2,599);
			SetTalent(3,615);
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

			return 90000 - 10000 * skill_t1;
		}
		public override int GetEnmity(GSkill skill)
		{
			return 1;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={110,112,114,116,118,120,122};return array[level-1];
		}
		public override float GetRadius(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (3 * skill_level + 15);
		}
		public override float GetPraydistance(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (3 * skill_level + 16);
		}
		public override float GetCastdistance(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (3 * skill_level + 15);
		}
		public override float GetEffectdistance(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (3 * skill_level + 18);
		}
		public override float GetMpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (20 * skill_level + 350);
		}
		public override int GetCoverage(GSkill skill)
		{
			return 15;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_level = player.GetLevel();
			int				player_maxhp = player.GetMaxhp();
			int				skill_level = skill.GetLevel();
			int				skill_t2 = skill.GetT2();
			int				skill_t3 = skill.GetT3();

			victim.SetProbability(100.0f);
			victim.SetTime(16000.0f);
			victim.SetBuffid(1);
			victim.SetAmount(((skill_t2 * 0.25f + 1.0f) * (((skill_level << 6) + 16)) * 1.125f));
			victim.SetCycsubdefence(true);
			victim.SetProbability(((20 * skill_t3)));
			victim.SetTime(((8010 * skill_t3)));
			victim.SetRatio(0.25f);
			victim.SetBuffid(1);
			victim.SetSlow(true);
			victim.SetProbability(120.0f);
			victim.SetTime(16000.0f);
			victim.SetBuffid(1);
			victim.SetAmount(((10 * player_level)));
			victim.SetValue((player_maxhp * (skill_level * 0.04f)));
			victim.SetSubhp(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();

			victim.SetProbability(100.0f);
			victim.SetTime(((4000 * norm(skill_t0))));
			victim.SetBuffid(1);
			victim.SetAmount(((20 * skill_level + 350) * (skill_t0 * 0.15f)));
			victim.SetValue(0.0f);
			victim.SetMpgen(true);
			return true;
		}
		public override float GetDropRate(GSkill skill)
		{
			return 0.500000f;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={537};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={3};return array[index];
		}
	}
	public class GSkill540 : GSkill
	{
		public GSkill540()
			: base(540)
		{
			
		}
	}
	public class GSkill541Stub : GSkillStub
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
				int				skill_t1 = skill.GetT1();
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
				skill.SetRatio(((D2INT((player_mp / (0.95f - skill_t3 * 0.1f)) / player_maxmp) * 0.16f + (skill_t2 * 0.05f + 1.0f)) + ((0.05f * level_sum) * skill_t2 * norm(skill_t2))));
				skill.SetPlus((player_maxmp * (skill_level * 0.01f) + (((skill_level * (skill_level * 8.9f)) - (46 * skill_level) + 2580.0f) * (D2INT(skill_level * 0.05f + 0.55f)) + ((((164 * skill_level + 2060)) - skill_level * (skill_level * 9.6f)) * (D2INT(1.42f - skill_level * 0.05f)) + ((50 * skill_level * skill_t1))))));
				player.SetPerform(1);
			}
		}
		public GSkill541Stub()
			: base(541)
		{
			occupation = 19;
			maxlevel = 18;
			maxlearn = 9;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 1;
			timetype = 0;
			targettype = 0;
			rangetype = 0;
			doenchant = false;
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
			SetAction(0,"青云门_天诛剑气");
			SetAction(1,"青云门_天诛剑气");
			SetAction(2,"青云门_天诛剑气");
			SetAction(3,"青云门_天诛剑气");
			SetAction(4,"青云门_天诛剑气");
			SetAction(5,"青云门_天诛剑气");
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
			SetAction(18,"青云门_骑乘_天诛剑气");
			SetAction(19,"青云门_骑乘_天诛剑气");
			SetAction(20,"青云门_骑乘_天诛剑气");
			SetAction(21,"青云门_骑乘_天诛剑气");
			SetAction(22,"青云门_骑乘_天诛剑气");
			SetAction(23,"青云门_骑乘_天诛剑气");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "天诛剑气";
			nativename = "天诛剑气";
			icon = "天诛剑气.dds";
			SetTalent(0,579);
			SetTalent(1,580);
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
			int				skill_t0 = skill.GetT0();

			return 6000 - 1000 * skill_t0;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={115,117,119,121,123,125,125,125,125};return array[level-1];
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 16.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (skill_level * 0.5f + 10.7f);
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 19.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (skill_level * 9.699999999999999f + (skill_level * (skill_level * 1.3f)) + 389.0f);
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
			int[] array={538};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={2};return array[index];
		}
	}
	public class GSkill541 : GSkill
	{
		public GSkill541()
			: base(541)
		{
			
		}
	}
	public class GSkill542Stub : GSkillStub
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
				int				player_mp = player.GetMp();
				int				player_maxmp = player.GetMaxmp();
				int				skill_level = skill.GetLevel();
				int				skill_t2 = skill.GetT2();
				int				skill_t3 = skill.GetT3();

				player.SetVar1(player.GetBuffcnt());
				skill.SetCrithurt((skill_t2 * 0.2f));
				skill.SetRatio((skill_t2 * (skill_level * 0.04f) + (skill_level * 0.15f + 1.0f)));
				skill.SetPlus((D2INT(player_mp / (player_maxmp * (0.95f - skill_t3 * 0.1f))) * (player_maxmp * 0.05f)));
				player.SetPerform(1);
			}
		}
		public GSkill542Stub()
			: base(542)
		{
			occupation = 19;
			maxlevel = 18;
			maxlearn = 7;
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
			SetAction(0,"青云门_真元华闪");
			SetAction(1,"青云门_真元华闪");
			SetAction(2,"青云门_真元华闪");
			SetAction(3,"青云门_真元华闪");
			SetAction(4,"青云门_真元华闪");
			SetAction(5,"青云门_真元华闪");
			SetAction(6,"0");
			SetAction(7,"0");
			SetAction(8,"0");
			SetAction(9,"0");
			SetAction(10,"0");
			SetAction(11,"0");
			SetAction(12,"0");
			SetAction(13,"");
			SetAction(14,"");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"青云门_骑乘_真元华闪");
			SetAction(19,"青云门_骑乘_真元华闪");
			SetAction(20,"青云门_骑乘_真元华闪");
			SetAction(21,"青云门_骑乘_真元华闪");
			SetAction(22,"青云门_骑乘_真元华闪");
			SetAction(23,"青云门_骑乘_真元华闪");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "真元华闪";
			nativename = "真元华闪";
			icon = "真元华闪.dds";
			SetTalent(0,592);
			SetTalent(1,596);
			SetTalent(2,598);
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
			return 1000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			int				skill_t1 = skill.GetT1();

			return 90000 - 10000 * skill_t1;
		}
		public override int GetEnmity(GSkill skill)
		{
			return 1;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={115,118,121,124,125,125,125};return array[level-1];
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 7.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 2.000000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 12.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (15 * skill_level + 950);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_hp = player.GetHp();
			int				player_maxhp = player.GetMaxhp();
			int				player_var1 = player.GetVar1();
			int				skill_level = skill.GetLevel();
			int				skill_t2 = skill.GetT2();

			victim.SetRatio(((player.GetDebuffcnt() * (skill_t2 * 0.04f) + (player_var1 * (skill_t2 * 0.04f) + 1.0f)) * (((2 * player_hp + 100) / (player_maxhp + 100)) + (skill_level * 0.05f))));
			victim.SetAmount(0.0f);
			victim.SetValue(0.0f);
			victim.SetSecondattack(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_mp = player.GetMp();
			int				player_maxmp = player.GetMaxmp();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();
			int				skill_t3 = skill.GetT3();

			victim.SetProbability(100.0f);
			victim.SetTime(((4000 * norm(skill_t0))));
			victim.SetBuffid(1);
			victim.SetAmount(((15 * skill_level + 950) * (skill_t0 * 0.15f)));
			victim.SetValue(0.0f);
			victim.SetMpgen(true);
			victim.SetBuffid((D2INT(player_mp / (player_maxmp * (0.95f - skill_t3 * 0.1f)))));
			victim.SetUniqprompt(true);
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={539};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={3};return array[index];
		}
	}
	public class GSkill542 : GSkill
	{
		public GSkill542()
			: base(542)
		{
			
		}
	}
	public class GSkill543Stub : GSkillStub
	{
		public class GState1 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 3000;
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
				return 1500;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				skill_level = skill.GetLevel();
				int				skill_t0 = skill.GetT0();
				int				skill_t3 = skill.GetT3();

				skill.SetRatio((skill_t3 * ((player.GetSkilllevel(242) / 9) * 0.05f + ((player.GetSkilllevel(234) / 9) * 0.05f + 0.05f)) + (skill_level * 0.02f + 1.0f)));
				skill.SetPlus((((zrand(15 * skill_t0 + 10) - 10) * norm(skill_t0 + 0.1f) + 100) / 100.0f * ((((333 * skill_level)) - skill_level * (skill_level * 8.5f)) * (D2INT(skill_level * 0.05f + 0.55f) * 0.9f) + (((28 * skill_level) + (skill_level * (skill_level * 0.13f)) + 1820.0f) * (D2INT(1.42f - skill_level * 0.05f) * 0.9f)))));
				player.SetPerform(1);
			}
			public override bool Cancel(GSkill skill)
			{
				return true;
			}
		}
		public class GState3 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 1500;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				skill_level = skill.GetLevel();
				int				skill_t0 = skill.GetT0();
				int				skill_t3 = skill.GetT3();

				skill.SetRatio((skill_t3 * ((player.GetSkilllevel(242) / 9) * 0.05f + ((player.GetSkilllevel(234) / 9) * 0.05f + 0.05f)) + (skill_level * 0.02f + 1.0f)));
				skill.SetPlus((((zrand(15 * skill_t0 + 10) - 10) * norm(skill_t0 + 0.1f) + 100) / 100.0f * ((((333 * skill_level)) - skill_level * (skill_level * 8.5f)) * (D2INT(skill_level * 0.05f + 0.55f) * 0.9f) + (((28 * skill_level) + (skill_level * (skill_level * 0.13f)) + 1820.0f) * (D2INT(1.42f - skill_level * 0.05f) * 0.9f)))));
				player.SetPerform(0);
			}
		}
		public GSkill543Stub()
			: base(543)
		{
			occupation = 19;
			maxlevel = 18;
			maxlearn = 9;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 1;
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
			SetAction(0,"青云门_天地不仁");
			SetAction(1,"青云门_天地不仁");
			SetAction(2,"青云门_天地不仁");
			SetAction(3,"青云门_天地不仁");
			SetAction(4,"青云门_天地不仁");
			SetAction(5,"青云门_天地不仁");
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
			SetAction(18,"青云门_骑乘_天地不仁");
			SetAction(19,"青云门_骑乘_天地不仁");
			SetAction(20,"青云门_骑乘_天地不仁");
			SetAction(21,"青云门_骑乘_天地不仁");
			SetAction(22,"青云门_骑乘_天地不仁");
			SetAction(23,"青云门_骑乘_天地不仁");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "天地不仁";
			nativename = "天地不仁";
			icon = "天地不仁.dds";
			SetTalent(0,607);
			SetTalent(1,611);
			SetTalent(2,614);
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
			AddState(new GState3());
		}
		public override int GetExecutetime(GSkill skill)
		{
			return 6000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			return 8000;
		}
		public override int GetEnmity(GSkill skill)
		{
			return 1;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={120,122,124,125,125,125,125,125,125};return array[level-1];
		}
		public override float GetRadius(GSkill skill)
		{
			return 19.000000f;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 19.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 14.000000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 15.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (((skill_level * skill_level)) - skill_level * 1.7f + 725.0f);
		}
		public override int GetCoverage(GSkill skill)
		{
			return 40;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_level = player.GetLevel();
			int				skill_t1 = skill.GetT1();
			int				skill_t2 = skill.GetT2();

			victim.SetProbability(((1.0f - player_level * 0.002f) * ((5 * skill_t2 + 6))));
			victim.SetRatio(0.75f);
			victim.SetDrainmagic(true);
			victim.SetProbability(((600 * D2INT(zrand(100) / (100 - 4 * skill_t1)))));
			victim.SetTime(((3050 * skill_t1)));
			victim.SetRatio((skill_t1 * 0.1f));
			victim.SetBuffid(1);
			victim.SetWeak(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_t2 = skill.GetT2();

			victim.SetTime(((500 * skill_t2 + 1500)));
			victim.SetInvincible(true);
			return true;
		}
		public override float GetDropRate(GSkill skill)
		{
			return 0.500000f;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={540};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={5};return array[index];
		}
	}
	public class GSkill543 : GSkill
	{
		public GSkill543()
			: base(543)
		{
			
		}
	}
	public class GSkill544Stub : GSkillStub
	{
		public class GState1 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 0;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();

				player.SetPerform(1);
			}
		}
		public GSkill544Stub()
			: base(544)
		{
			occupation = 19;
			maxlevel = 12;
			maxlearn = 6;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 2;
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
			SetAction(0,"青云门_天机印");
			SetAction(1,"青云门_天机印");
			SetAction(2,"青云门_天机印");
			SetAction(3,"青云门_天机印");
			SetAction(4,"青云门_天机印");
			SetAction(5,"青云门_天机印");
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
			SetAction(18,"青云门_骑乘_天机印");
			SetAction(19,"青云门_骑乘_天机印");
			SetAction(20,"青云门_骑乘_天机印");
			SetAction(21,"青云门_骑乘_天机印");
			SetAction(22,"青云门_骑乘_天机印");
			SetAction(23,"青云门_骑乘_天机印");
			SetAction(24,"");
			SetAction(25,"");
			SetAction(26,"");
			SetAction(27,"");
			SetAction(28,"");
			SetAction(29,"");
			SetAction(30,"");
			name = "天机印";
			nativename = "天机印";
			icon = "天机印.dds";
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
		}
		public override int GetCooldowntime(GSkill skill)
		{
			return 12000;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={125,125,125,125,125,125};return array[level-1];
		}
		public override float GetRadius(GSkill skill)
		{
			return 15.000000f;
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
			return 12.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (165 - 5 * skill_level);
		}
		public override int GetCoverage(GSkill skill)
		{
			return 25;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_maxmp = player.GetMaxmp();
			int				skill_level = skill.GetLevel();

			victim.SetProbability(((8 * skill_level + 47)));
			victim.SetTime(8100.0f);
			victim.SetRatio((skill_level * 0.08f));
			victim.SetBuffid(4);
			victim.SetSlow(true);
			victim.SetProbability(100.0f);
			victim.SetTime(8100.0f);
			victim.SetBuffid(9);
			victim.SetAmount((player_maxmp * 0.25f + 1.0f));
			victim.SetValue((player_maxmp * (skill_level * 0.05f)));
			victim.SetSubmp(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetTime(3600000.0f);
			victim.SetRatio(0.0f);
			victim.SetAmount(19.0f);
			victim.SetValue(0.0f);
			victim.SetEvilaura(true);
			return true;
		}
		public override float GetDropRate(GSkill skill)
		{
			return 0.500000f;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={542};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={4};return array[index];
		}
	}
	public class GSkill544 : GSkill
	{
		public GSkill544()
			: base(544)
		{
			
		}
	}
	public class GSkill545Stub : GSkillStub
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
				return 600;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				skill_level = skill.GetLevel();
				int				skill_t2 = skill.GetT2();

				skill.SetCrit(((skill_level / 9) * (skill_t2 * 0.01f) + (skill_t2 * 0.01f)));
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
				skill.SetRatio(((skill_t2 * 0.05f + (skill_level * 0.01f + 1.0f)) + ((0.05f * level_sum) * skill_t2 * norm(skill_t2))));
				skill.SetPlus((((D2INT(skill_level * 0.05f + 0.55f)) * (101 * skill_level + 1126)) + ((((105 * skill_level + 1230)) - skill_level * (skill_level * 5.3f)) * (D2INT(1.42f - skill_level * 0.05f)))));
				player.SetPerform(1);
			}
			public override bool Cancel(GSkill skill)
			{
				return true;
			}
		}
		public class GState3 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 600;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				skill_level = skill.GetLevel();
				int				skill_t1 = skill.GetT1();
				int				skill_t2 = skill.GetT2();

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
				skill.SetRatio(((skill_t2 * 0.05f + (skill_level * 0.01f + 1.0f)) + ((0.05f * level_sum) * skill_t2 * norm(skill_t2))));
				skill.SetPlus((((D2INT(skill_level * 0.05f + 0.55f)) * (101 * skill_level + 1126)) + ((((105 * skill_level + 1230)) - skill_level * (skill_level * 5.3f)) * (D2INT(1.42f - skill_level * 0.05f)) + ((60 * skill_level * skill_t1)))));
				player.SetPerform(0);
			}
		}
		public GSkill545Stub()
			: base(545)
		{
			occupation = 19;
			maxlevel = 18;
			maxlearn = 9;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 1;
			timetype = 0;
			targettype = 0;
			rangetype = 0;
			doenchant = false;
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
			SetAction(0,"青云门_七劫斩龙诀");
			SetAction(1,"青云门_七劫斩龙诀");
			SetAction(2,"青云门_七劫斩龙诀");
			SetAction(3,"青云门_七劫斩龙诀");
			SetAction(4,"青云门_七劫斩龙诀");
			SetAction(5,"青云门_七劫斩龙诀");
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
			SetAction(18,"青云门_骑乘_七劫斩龙诀");
			SetAction(19,"青云门_骑乘_七劫斩龙诀");
			SetAction(20,"青云门_骑乘_七劫斩龙诀");
			SetAction(21,"青云门_骑乘_七劫斩龙诀");
			SetAction(22,"青云门_骑乘_七劫斩龙诀");
			SetAction(23,"青云门_骑乘_七劫斩龙诀");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "七劫斩龙诀";
			nativename = "七劫斩龙诀";
			icon = "七劫斩龙诀.dds";
			SetTalent(0,579);
			SetTalent(1,581);
			SetTalent(2,583);
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
			AddState(new GState3());
		}
		public override int GetExecutetime(GSkill skill)
		{
			return 2000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			int				skill_t0 = skill.GetT0();

			return 6000 - 1000 * skill_t0;
		}
		public override int GetEnmity(GSkill skill)
		{
			return 1;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={125,125,125,125,125,125,125,125,125};return array[level-1];
		}
		public override float GetPraydistance(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (skill_level * 0.5f + 16.0f);
		}
		public override float GetCastdistance(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (skill_level * 0.5f + 10.7f);
		}
		public override float GetEffectdistance(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (skill_level * 0.5f + 19.0f);
		}
		public override float GetMpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return ((13 * skill_level) + (skill_level * (skill_level * 1.78f)) + 580.0f);
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();

			victim.SetProbability(33.0f);
			victim.SetTime(12100.0f);
			victim.SetRatio((skill_level * 0.01f));
			victim.SetAttack2hp(true);
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={541};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={6};return array[index];
		}
	}
	public class GSkill545 : GSkill
	{
		public GSkill545()
			: base(545)
		{
			
		}
	}
	public class GSkill546Stub : GSkillStub
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
				return 600;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				skill_level = skill.GetLevel();
				int				skill_t0 = skill.GetT0();
				int				skill_t1 = skill.GetT1();
				int				skill_t2 = skill.GetT2();

				skill.SetRatio((skill_t1 * 0.07000000000000001f + 1.0f));
				skill.SetPlus(((D2INT((zrand(7 * skill_t2 + 99)) / 100) + 1) * ((skill_t0 * 0.15f + 1.0f) * (((skill_level * (skill_level * 2.1f)) - skill_level * 0.043f + 663.0f) * (D2INT(skill_level * 0.05f + 0.55f)) + (((13 * skill_level) + (skill_level * (skill_level * 0.07099999999999999f)) + 623.0f) * (D2INT(1.42f - skill_level * 0.05f)))))));
				player.SetPerform(1);
			}
			public override bool Cancel(GSkill skill)
			{
				return true;
			}
		}
		public class GState3 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 600;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				skill_level = skill.GetLevel();
				int				skill_t0 = skill.GetT0();
				int				skill_t1 = skill.GetT1();
				int				skill_t2 = skill.GetT2();

				skill.SetRatio((skill_t1 * 0.07000000000000001f + 1.0f));
				skill.SetPlus(((D2INT((zrand(7 * skill_t2 + 99)) / 100) + 1) * ((skill_t0 * 0.15f + 1.0f) * (((skill_level * (skill_level * 2.1f)) - skill_level * 0.043f + 663.0f) * (D2INT(skill_level * 0.05f + 0.55f)) + (((13 * skill_level) + (skill_level * (skill_level * 0.07099999999999999f)) + 623.0f) * (D2INT(1.42f - skill_level * 0.05f)))))));
				player.SetPerform(0);
			}
		}
		public GSkill546Stub()
			: base(546)
		{
			occupation = 22;
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
			SetAction(0,"天音寺_拈花妙谛");
			SetAction(1,"天音寺_拈花妙谛");
			SetAction(2,"天音寺_拈花妙谛");
			SetAction(3,"天音寺_拈花妙谛");
			SetAction(4,"天音寺_拈花妙谛");
			SetAction(5,"天音寺_拈花妙谛");
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
			SetAction(18,"天音寺_骑乘_拈花妙谛");
			SetAction(19,"天音寺_骑乘_拈花妙谛");
			SetAction(20,"天音寺_骑乘_拈花妙谛");
			SetAction(21,"天音寺_骑乘_拈花妙谛");
			SetAction(22,"天音寺_骑乘_拈花妙谛");
			SetAction(23,"天音寺_骑乘_拈花妙谛");
			SetAction(24,"");
			SetAction(25,"");
			SetAction(26,"");
			SetAction(27,"");
			SetAction(28,"");
			SetAction(29,"");
			SetAction(30,"");
			name = "拈花妙谛";
			nativename = "拈花妙谛";
			icon = "拈花妙谛.dds";
			SetTalent(0,697);
			SetTalent(1,702);
			SetTalent(2,708);
			SetTalent(3,713);
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
			skill_class = 3;
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
			AddState(new GState3());
		}
		public override int GetExecutetime(GSkill skill)
		{
			return 2000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			return 7000;
		}
		public override int GetEnmity(GSkill skill)
		{
			return 1;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={105,107,109,111,113,115,117,119,122};return array[level-1];
		}
		public override float GetPraydistance(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (skill_level + 16);
		}
		public override float GetCastdistance(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (skill_level + 10.7f);
		}
		public override float GetEffectdistance(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (skill_level + 19);
		}
		public override float GetMpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return ((6 * skill_level) + (skill_level * (skill_level * 1.3f)) + 910.0f);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();
			int				skill_t3 = skill.GetT3();

			victim.SetProbability(100.0f);
			victim.SetTime(((2000 * skill_t3 + 4100)));
			victim.SetRatio((skill_level * (skill_t3 * 0.01f + 0.02f) + 0.05f));
			victim.SetBuffid(1);
			victim.SetDecaccuracy(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();
			int				skill_t2 = skill.GetT2();

			victim.SetValue(((24 * (skill_t2 + 1) * skill_level)));
			victim.SetJuqi(true);
			return true;
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={24};return array[index];
		}
	}
	public class GSkill546 : GSkill
	{
		public GSkill546()
			: base(546)
		{
			
		}
	}
	public class GSkill547Stub : GSkillStub
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
		public GSkill547Stub()
			: base(547)
		{
			occupation = 22;
			maxlevel = 4;
			maxlearn = 3;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 2;
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
			SetAction(0,"天音寺_破魔秘言");
			SetAction(1,"天音寺_破魔秘言");
			SetAction(2,"天音寺_破魔秘言");
			SetAction(3,"天音寺_破魔秘言");
			SetAction(4,"天音寺_破魔秘言");
			SetAction(5,"天音寺_破魔秘言");
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
			SetAction(18,"天音寺_骑乘_破魔秘言");
			SetAction(19,"天音寺_骑乘_破魔秘言");
			SetAction(20,"天音寺_骑乘_破魔秘言");
			SetAction(21,"天音寺_骑乘_破魔秘言");
			SetAction(22,"天音寺_骑乘_破魔秘言");
			SetAction(23,"天音寺_骑乘_破魔秘言");
			SetAction(24,"");
			SetAction(25,"");
			SetAction(26,"");
			SetAction(27,"");
			SetAction(28,"");
			SetAction(29,"");
			SetAction(30,"");
			name = "破魔秘言";
			nativename = "破魔秘言";
			icon = "破魔秘言.dds";
			SetTalent(0,696);
			SetTalent(1,700);
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
			skill_class = 3;
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

			return 150000 - 10000 * skill_t1;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={106,114,122};return array[level-1];
		}
		public override float GetRadius(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (5 * skill_level);
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
			return 750.000000f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();
			int				skill_t1 = skill.GetT1();

			victim.SetProbability(((5 * skill_t1 + (skill_level * skill_level + (15 * skill_level)) + 24)));
			victim.SetAmount(skill_level);
			victim.SetCleardebuff(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_maxhp = player.GetMaxhp();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();
			int				skill_t1 = skill.GetT1();

			victim.SetProbability(((5 * skill_t1 + (skill_level * skill_level + (15 * skill_level)) + 24)));
			victim.SetAmount(0.0f);
			victim.SetCleardebuff(true);
			victim.SetProbability(-1.0f);
			victim.SetRatio(0.0f);
			victim.SetValue((player_maxhp * (skill_t0 * 0.12f + (skill_level * 0.1f))));
			victim.SetHeal(true);
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={546};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={1};return array[index];
		}
	}
	public class GSkill547 : GSkill
	{
		public GSkill547()
			: base(547)
		{
			
		}
	}
	public class GSkill548Stub : GSkillStub
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
		public GSkill548Stub()
			: base(548)
		{
			occupation = 22;
			maxlevel = 20;
			maxlearn = 12;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 2;
			timetype = 0;
			targettype = 0;
			rangetype = 5;
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
			SetAction(0,"天音寺_般若波罗蜜");
			SetAction(1,"天音寺_般若波罗蜜");
			SetAction(2,"天音寺_般若波罗蜜");
			SetAction(3,"天音寺_般若波罗蜜");
			SetAction(4,"天音寺_般若波罗蜜");
			SetAction(5,"天音寺_般若波罗蜜");
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
			SetAction(18,"天音寺_骑乘_般若波罗蜜");
			SetAction(19,"天音寺_骑乘_般若波罗蜜");
			SetAction(20,"天音寺_骑乘_般若波罗蜜");
			SetAction(21,"天音寺_骑乘_般若波罗蜜");
			SetAction(22,"天音寺_骑乘_般若波罗蜜");
			SetAction(23,"天音寺_骑乘_般若波罗蜜");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "净土真言";
			nativename = "净土真言";
			icon = "净土真言.dds";
			SetTalent(0,703);
			SetTalent(1,718);
			SetTalent(2,719);
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
			skill_class = 3;
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

			return 30000 - 1000 * skill_t0;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={106,109,112,115,118,121,124,125,125,125,125,125};return array[level-1];
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
			return 22.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (((230 * skill_level + 556)) - skill_level * (skill_level * 1.9f));
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();
			int				skill_t1 = skill.GetT1();
			int				skill_t2 = skill.GetT2();

			victim.SetProbability(100.0f);
			victim.SetTime(16000.0f);
			victim.SetRatio(0.0f);
			victim.SetBuffid(4);
			victim.SetAmount(((skill_t1 * 0.4f + 1.0f) * ((skill_t2 * 0.15f + 1.0f) * ((((92 * skill_level) + 222.4f) - skill_level * (skill_level * 0.76f)) * (skill_level * 0.15f)))));
			victim.SetValue(((skill_t2 * 0.15f + 1.0f) * ((8 * D2INT((((230 * skill_level + 556)) - skill_level * (skill_level * 1.9f)) * 0.4f)))));
			victim.SetHpgen(true);
			victim.SetProbability(((100 * norm(skill_t2) * (D2INT(player.GetSkilllevel(277) / 12)))));
			victim.SetTime(((1800000 * norm(skill_t2))));
			victim.SetRatio(0.0f);
			victim.SetBuffid(3);
			victim.SetValue(((100 * skill_t2 * (player.GetSkilllevel(277) * (D2INT(player.GetSkilllevel(277) / 12))))));
			victim.SetTiangu(true);
			victim.SetProbability(((100 * norm(skill_t2) * (D2INT(player.GetSkilllevel(790) / 4)))));
			victim.SetTime(((1800000 * norm(skill_t2))));
			victim.SetRatio(0.0f);
			victim.SetBuffid(5);
			victim.SetValue(((100 * skill_t2 * (player.GetSkilllevel(790) * (D2INT(player.GetSkilllevel(790) / 4))))));
			victim.SetTiangu(true);
			int ability = 0;
			if (player.GetCultivation() == 1)
			{
				ability = player.GetSkilllevel(3028);
			}
			if ( player.GetCultivation() == 2 )
			{
				ability += player.GetSkilllevel(3076) ;
			}
			if ( player.GetCultivation() == 4 )
			{
				ability = (100 * (ability + player.GetSkilllevel(3124)) * skill_t2);
			}
			else
			{
				ability = (100 * skill_t2 * ability);
			}
			victim.SetProbability(ability);
			victim.SetTime(((1800000 * norm(skill_t2))));
			victim.SetRatio(0.0f);
			victim.SetBuffid(5);
			int value = 0;
			if (player.GetCultivation() == 1)
			{
				value = player.GetSkilllevel(3028);
			}
			if ( player.GetCultivation() == 2 )
			{
				value += player.GetSkilllevel(3076) ;
			}
			if ( player.GetCultivation() == 4 )
			{
				value = (100 * (value + player.GetSkilllevel(3124)) * skill_t2);
			}
			else
			{
				value = (100 * skill_t2 * value);
			}
			victim.SetValue(value);
			victim.SetTiangu(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();
			int				skill_t2 = skill.GetT2();

			victim.SetProbability(((100 * norm(skill_t2))));
			victim.SetTime(((1800000 * norm(skill_t2))));
			victim.SetRatio(0.0f);
			victim.SetBuffid(4);
			victim.SetValue(((100 * skill_level / 12 * (skill_t2 * skill_level))));
			victim.SetTiangu(true);
			victim.SetProbability(((100 * norm(skill_t2) * (D2INT(player.GetSkilllevel(273) / 12)))));
			victim.SetTime(((1800000 * norm(skill_t2))));
			victim.SetRatio(0.0f);
			victim.SetBuffid(2);
			victim.SetValue(((100 * skill_t2 * (player.GetSkilllevel(273) * (D2INT(player.GetSkilllevel(273) / 12))))));
			victim.SetTiangu(true);
			victim.SetProbability(((100 * norm(skill_t2) * (D2INT(player.GetSkilllevel(266) / 12)))));
			victim.SetTime(((1800000 * norm(skill_t2))));
			victim.SetRatio(0.0f);
			victim.SetBuffid(1);
			victim.SetValue(((100 * skill_t2 * (player.GetSkilllevel(266) * (D2INT(player.GetSkilllevel(266) / 12))))));
			victim.SetTiangu(true);
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={546};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={1};return array[index];
		}
	}
	public class GSkill548 : GSkill
	{
		public GSkill548()
			: base(548)
		{
			
		}
	}
	public class GSkill549Stub : GSkillStub
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
		public GSkill549Stub()
			: base(549)
		{
			occupation = 22;
			maxlevel = 20;
			maxlearn = 8;
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
			SetAction(0,"天音寺_摩诃心经");
			SetAction(1,"天音寺_摩诃心经");
			SetAction(2,"天音寺_摩诃心经");
			SetAction(3,"天音寺_摩诃心经");
			SetAction(4,"天音寺_摩诃心经");
			SetAction(5,"天音寺_摩诃心经");
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
			SetAction(18,"天音寺_骑乘_摩诃心经");
			SetAction(19,"天音寺_骑乘_摩诃心经");
			SetAction(20,"天音寺_骑乘_摩诃心经");
			SetAction(21,"天音寺_骑乘_摩诃心经");
			SetAction(22,"天音寺_骑乘_摩诃心经");
			SetAction(23,"天音寺_骑乘_摩诃心经");
			SetAction(24,"");
			SetAction(25,"");
			SetAction(26,"");
			SetAction(27,"");
			SetAction(28,"");
			SetAction(29,"");
			SetAction(30,"");
			name = "摩诃心经";
			nativename = "摩诃心经";
			icon = "摩诃心经.dds";
			SetTalent(0,700);
			SetTalent(1,717);
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
			skill_class = 3;
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

			return 600000 - 120000 * skill_t0;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={110,112,114,116,118,120,122,124};return array[level-1];
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 26.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 24.000000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 30.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (35 * skill_level + 750);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_maxhp = player.GetMaxhp();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();
			int				skill_t1 = skill.GetT1();

			victim.SetProbability(100.0f);
			victim.SetTime(((4000 * skill_t1 + 15000)));
			victim.SetRatio(1.0f);
			victim.SetBuffid(1);
			victim.SetAmount(0.0f);
			victim.SetValue(((4 * skill_t1 + 15) * (player_maxhp * ((skill_t1 + skill_level) * 0.01f))));
			victim.SetHpgen(true);
			victim.SetRatio(220.0f);
			victim.SetAmount(((569 * norm(zrand(100) / (100 - 30 * skill_t0)) + 220)));
			victim.SetValue(218.0f);
			victim.SetClearcooldown(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();

			victim.SetProbability(100.0f);
			victim.SetTime(120000.0f);
			victim.SetBuffid(1);
			victim.SetAmount(0.0f);
			victim.SetValue(((skill_t0 * 0.2f + 1.0f) * ((240 * skill_level))));
			victim.SetMpgen(true);
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={546};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={1};return array[index];
		}
	}
	public class GSkill549 : GSkill
	{
		public GSkill549()
			: base(549)
		{
			
		}
	}
}
