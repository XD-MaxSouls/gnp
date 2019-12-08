using System;
using System.Text;

namespace SKILL
{
	public class GSkill240Stub : GSkillStub
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
				skill.SetRatio(((skill_t2 * 0.05f + 1.0f) + ((0.05f * level_sum) * skill_t2 * norm(skill_t2))));
				skill.SetPlus(((((330 * skill_level - 360)) - skill_level * (skill_level * 5.2f)) * (D2INT(skill_level * 0.05f + 0.55f)) + (((126 * skill_level) + (1520.0f - skill_level * (skill_level * 6.2f))) * (D2INT(1.42f - skill_level * 0.05f)) + ((30 * skill_t0 * skill_level)))));
				player.SetPerform(1);
			}
		}
		public GSkill240Stub()
			: base(240)
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
			SetAction(0,"ÇàÔÆÃÅ_ÌìÍâ·ÉÏÉ");
			SetAction(1,"ÇàÔÆÃÅ_ÌìÍâ·ÉÏÉ");
			SetAction(2,"ÇàÔÆÃÅ_ÌìÍâ·ÉÏÉ");
			SetAction(3,"ÇàÔÆÃÅ_ÌìÍâ·ÉÏÉ");
			SetAction(4,"ÇàÔÆÃÅ_ÌìÍâ·ÉÏÉ");
			SetAction(5,"ÇàÔÆÃÅ_ÌìÍâ·ÉÏÉ");
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
			SetAction(18,"ÇàÔÆÃÅ_Æï³Ë_ÌìÍâ·ÉÏÉ");
			SetAction(19,"ÇàÔÆÃÅ_Æï³Ë_ÌìÍâ·ÉÏÉ");
			SetAction(20,"ÇàÔÆÃÅ_Æï³Ë_ÌìÍâ·ÉÏÉ");
			SetAction(21,"ÇàÔÆÃÅ_Æï³Ë_ÌìÍâ·ÉÏÉ");
			SetAction(22,"ÇàÔÆÃÅ_Æï³Ë_ÌìÍâ·ÉÏÉ");
			SetAction(23,"ÇàÔÆÃÅ_Æï³Ë_ÌìÍâ·ÉÏÉ");
			SetAction(24,"");
			SetAction(25,"");
			SetAction(26,"");
			SetAction(27,"");
			SetAction(28,"");
			SetAction(29,"");
			SetAction(30,"");
			name = "ÌìÍâ·ÉÏÉ";
			nativename = "ÌìÍâ·ÉÏÉ";
			icon = "ÌìÍâ·ÉÏÉ.dds";
			SetTalent(0,577);
			SetTalent(1,579);
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
		}
		public override int GetExecutetime(GSkill skill)
		{
			return 2000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			int				skill_t1 = skill.GetT1();

			return 16000 - 1000 * skill_t1;
		}
		public override int GetEnmity(GSkill skill)
		{
			return 1;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={100,102,104,106,108,110,112,114,116};return array[level-1];
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
			return 20.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return ((25 * skill_level) + (skill_level * (skill_level * 1.4f)) + 616.0f);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();

			victim.SetProbability(((16 * skill_level + 45)));
			victim.SetTime(((300 * skill_level + 3500)));
			victim.SetRatio((skill_level * 0.03f + 0.37f));
			victim.SetBuffid(3);
			victim.SetSlow(true);
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={237};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={6};return array[index];
		}
	}
	public class GSkill240 : GSkill
	{
		public GSkill240()
			: base(240)
		{
			
		}
	}
	public class GSkill241Stub : GSkillStub
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
		public GSkill241Stub()
			: base(241)
		{
			occupation = 9;
			maxlevel = 12;
			maxlearn = 5;
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
			SetAction(0,"ÇàÔÆÃÅ_ÌìÏÉ»¤Ìå");
			SetAction(1,"ÇàÔÆÃÅ_ÌìÏÉ»¤Ìå");
			SetAction(2,"ÇàÔÆÃÅ_ÌìÏÉ»¤Ìå");
			SetAction(3,"ÇàÔÆÃÅ_ÌìÏÉ»¤Ìå");
			SetAction(4,"ÇàÔÆÃÅ_ÌìÏÉ»¤Ìå");
			SetAction(5,"ÇàÔÆÃÅ_ÌìÏÉ»¤Ìå");
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
			SetAction(18,"ÇàÔÆÃÅ_Æï³Ë_ÌìÏÉ»¤Ìå");
			SetAction(19,"ÇàÔÆÃÅ_Æï³Ë_ÌìÏÉ»¤Ìå");
			SetAction(20,"ÇàÔÆÃÅ_Æï³Ë_ÌìÏÉ»¤Ìå");
			SetAction(21,"ÇàÔÆÃÅ_Æï³Ë_ÌìÏÉ»¤Ìå");
			SetAction(22,"ÇàÔÆÃÅ_Æï³Ë_ÌìÏÉ»¤Ìå");
			SetAction(23,"ÇàÔÆÃÅ_Æï³Ë_ÌìÏÉ»¤Ìå");
			SetAction(24,"");
			SetAction(25,"");
			SetAction(26,"");
			SetAction(27,"");
			SetAction(28,"");
			SetAction(29,"");
			SetAction(30,"");
			name = "ÌìÏÉ»¤Ìå";
			nativename = "ÌìÏÉ»¤Ìå";
			icon = "ÌìÏÉ»¤Ìå.dds";
			SetTalent(0,592);
			SetTalent(1,594);
			SetTalent(2,596);
			SetTalent(3,1590);
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
			int				skill_t2 = skill.GetT2();

			return 120000 - 10000 * skill_t2;
		}
		public override int GetEnmity(GSkill skill)
		{
			return 1;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={85,90,95,101,105};return array[level-1];
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

			return ((51 * skill_level) - skill_level * skill_level + 117);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();
			int				skill_t1 = skill.GetT1();
			int				skill_t3 = skill.GetT3();

			victim.SetProbability(120.0f);
			victim.SetTime(((6000 * skill_level + 6100)));
			victim.SetBuffid(1);
			victim.SetValue(((skill_t3 * 0.1f + 1.0f) * ((((4 * skill_t1 + 1) * (10 * skill_level + 10)) * (D2INT(zrand(100) / (100 - 9 * skill_t1)) + 1)))));
			victim.SetAdddefence(true);
			victim.SetTime(((300000 * skill_level + 300100)));
			victim.SetBuffid(2);
			victim.SetValue(((skill_t3 * 0.1f + 1.0f) * ((200 * skill_level))));
			victim.SetAddmp(true);
			victim.SetProbability(100.0f);
			victim.SetTime(((4000 * norm(skill_t0))));
			victim.SetBuffid(1);
			victim.SetAmount(0.0f);
			victim.SetValue((skill_t0 * (((51 * skill_level) - skill_level * skill_level + 117) * 0.15f)));
			victim.SetMpgen(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_t1 = skill.GetT1();

			victim.SetTime(((12000 * skill_t1)));
			victim.SetRatio((skill_t1 * 0.05f));
			victim.SetBuffid(1);
			victim.SetIncanti(true);
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={313};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={4};return array[index];
		}
	}
	public class GSkill241 : GSkill
	{
		public GSkill241()
			: base(241)
		{
			
		}
	}
	public class GSkill242Stub : GSkillStub
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
				int				skill_t3 = skill.GetT3();

				skill.SetRatio((skill_t3 * ((player.GetSkilllevel(234) / 9) * 0.05f + 0.05f) + 1.0f));
				skill.SetPlus((((zrand(15 * skill_t0 + 10) - 10) * norm(skill_t0 + 0.1f) + 100) / 100.0f * (((skill_level * (skill_level * 5.6f)) - (74 * skill_level) + 1100.0f) * (D2INT(skill_level * 0.05f + 0.55f) * 0.9f) + ((((13 * skill_level + 664)) - skill_level * (skill_level * 0.08400000000000001f)) * (D2INT(1.42f - skill_level * 0.05f) * 0.9f)))));
				player.SetPerform(1);
			}
		}
		public GSkill242Stub()
			: base(242)
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
			SetAction(0,"ÇàÔÆÃÅ_À×ÉñÖ®Å­");
			SetAction(1,"ÇàÔÆÃÅ_À×ÉñÖ®Å­");
			SetAction(2,"ÇàÔÆÃÅ_À×ÉñÖ®Å­");
			SetAction(3,"ÇàÔÆÃÅ_À×ÉñÖ®Å­");
			SetAction(4,"ÇàÔÆÃÅ_À×ÉñÖ®Å­");
			SetAction(5,"ÇàÔÆÃÅ_À×ÉñÖ®Å­");
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
			SetAction(18,"ÇàÔÆÃÅ_Æï³Ë_À×ÉñÖ®Å­");
			SetAction(19,"ÇàÔÆÃÅ_Æï³Ë_À×ÉñÖ®Å­");
			SetAction(20,"ÇàÔÆÃÅ_Æï³Ë_À×ÉñÖ®Å­");
			SetAction(21,"ÇàÔÆÃÅ_Æï³Ë_À×ÉñÖ®Å­");
			SetAction(22,"ÇàÔÆÃÅ_Æï³Ë_À×ÉñÖ®Å­");
			SetAction(23,"ÇàÔÆÃÅ_Æï³Ë_À×ÉñÖ®Å­");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "À×ÉñÖ®×¶";
			nativename = "À×ÉñÖ®×¶";
			icon = "À×ÉñÖ®×¶.dds";
			SetTalent(0,607);
			SetTalent(1,611);
			SetTalent(2,613);
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
			int[] array={90,92,94,96,98,100,102,104,106};return array[level-1];
		}
		public override float GetRadius(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (skill_level * 0.3f + 11.0f);
		}
		public override float GetPraydistance(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (skill_level * 0.3f + 11.0f);
		}
		public override float GetCastdistance(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (skill_level * 0.3f + 6.0f);
		}
		public override float GetMpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (8 * skill_level + 250);
		}
		public override int GetCoverage(GSkill skill)
		{
			return 35;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_t1 = skill.GetT1();
			int				skill_t2 = skill.GetT2();

			victim.SetProbability(((600 * D2INT(zrand(100) / (100 - 4 * skill_t1)))));
			victim.SetTime(((3050 * skill_t1)));
			victim.SetRatio((skill_t1 * 0.1f));
			victim.SetBuffid(1);
			victim.SetWeak(true);
			victim.SetProbability(((600 * D2INT(zrand(100) / (100 - 7 * skill_t2)))));
			victim.SetTime(((3050 * norm(skill_t2))));
			victim.SetWrap(true);
			return true;
		}
		public override float GetDropRate(GSkill skill)
		{
			return 0.500000f;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={236};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={5};return array[index];
		}
	}
	public class GSkill242 : GSkill
	{
		public GSkill242()
			: base(242)
		{
			
		}
	}
	public class GSkill243Stub : GSkillStub
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
		public GSkill243Stub()
			: base(243)
		{
			occupation = 1;
			maxlevel = 12;
			maxlearn = 5;
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
			SetAction(0,"¹íÍõ×Ú_¿ñ·çÖä");
			SetAction(1,"¹íÍõ×Ú_¿ñ·çÖä");
			SetAction(2,"¹íÍõ×Ú_¿ñ·çÖä");
			SetAction(3,"¹íÍõ×Ú_¿ñ·çÖä");
			SetAction(4,"¹íÍõ×Ú_¿ñ·çÖä");
			SetAction(5,"¹íÍõ×Ú_¿ñ·çÖä");
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
			SetAction(18,"¹íÍõ×Ú_Æï³Ë_¿ñ·çÖä");
			SetAction(19,"¹íÍõ×Ú_Æï³Ë_¿ñ·çÖä");
			SetAction(20,"¹íÍõ×Ú_Æï³Ë_¿ñ·çÖä");
			SetAction(21,"¹íÍõ×Ú_Æï³Ë_¿ñ·çÖä");
			SetAction(22,"¹íÍõ×Ú_Æï³Ë_¿ñ·çÖä");
			SetAction(23,"¹íÍõ×Ú_Æï³Ë_¿ñ·çÖä");
			SetAction(24,"");
			SetAction(25,"");
			SetAction(26,"");
			SetAction(27,"");
			SetAction(28,"");
			SetAction(29,"");
			SetAction(30,"");
			name = "×··çÖä";
			nativename = "×··çÖä";
			icon = "×··çÖä.dds";
			SetTalent(0,619);
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
			skill_class = 0;
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

			return 80000 - 10000 * skill_t0;
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

			return (skill_level * 2.8f + (skill_level * (skill_level * 0.25f)) + 31.0f);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();

			victim.SetProbability(120.0f);
			victim.SetTime(2000 * skill_level + 10100);
			victim.SetBuffid(1);
			victim.SetValue(skill_level * 0.4f + 0.2f);
			victim.SetAddspeed(true);
			victim.SetProbability(120.0f);
			victim.SetTime((1000 * skill_t0 + 2000) * skill_level + 10100);
			victim.SetBuffid(1);
			victim.SetValue(2 * skill_level * (skill_t0 + 1));
			victim.SetAdddodge(true);
			victim.SetProbability(skill_t0==2?120.0f:0.0f);
			victim.SetTime(11000 * skill_t0 * skill_level + 100);
			victim.SetBuffid(0);
			victim.SetValue(0.5f);
			victim.SetIncmountspeed(true);
			victim.SetProbability(120 * norm(skill_t0));
			victim.SetTime(12000.0f);
			victim.SetBuffid(1);
			victim.SetValue(2 * skill_t0);
			victim.SetIncmountspeed(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_t0 = skill.GetT0();

			victim.SetTime(8000 * D2INT(skill_t0 / 1.5f));
			victim.SetImmuneslow(true);
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={244};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={1};return array[index];
		}
	}
	public class GSkill243 : GSkill
	{
		public GSkill243()
			: base(243)
		{
			
		}
	}
	public class GSkill244Stub : GSkillStub
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
				int				skill_t0 = skill.GetT0();
				int				skill_t1 = skill.GetT1();

				skill.SetPlus(((skill_t1 * 0.08f + 1.0f) * ((skill_level * 2.3f + (skill_level * (skill_level * 0.33f)) + 27.0f) * (D2INT(skill_level * 0.05f + 0.55f)) + ((skill_level * 3.3f + (skill_level * (skill_level * 0.013f)) + 39.0f) * (D2INT(1.42f - skill_level * 0.05f)) + ((3 * skill_level * skill_t0))))));
				player.SetPerform(1);
			}
		}
		public GSkill244Stub()
			: base(244)
		{
			occupation = 1;
			maxlevel = 20;
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
			SetAction(0,"¹íÍõ×Ú_·èÄ§Õ¶");
			SetAction(1,"¹íÍõ×Ú_·èÄ§Õ¶");
			SetAction(2,"¹íÍõ×Ú_·èÄ§Õ¶");
			SetAction(3,"¹íÍõ×Ú_·èÄ§Õ¶");
			SetAction(4,"¹íÍõ×Ú_·èÄ§Õ¶");
			SetAction(5,"¹íÍõ×Ú_·èÄ§Õ¶");
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
			SetAction(18,"¹íÍõ×Ú_Æï³Ë_·èÄ§Õ¶");
			SetAction(19,"¹íÍõ×Ú_Æï³Ë_·èÄ§Õ¶");
			SetAction(20,"¹íÍõ×Ú_Æï³Ë_·èÄ§Õ¶");
			SetAction(21,"¹íÍõ×Ú_Æï³Ë_·èÄ§Õ¶");
			SetAction(22,"¹íÍõ×Ú_Æï³Ë_·èÄ§Õ¶");
			SetAction(23,"¹íÍõ×Ú_Æï³Ë_·èÄ§Õ¶");
			SetAction(24,"");
			SetAction(25,"");
			SetAction(26,"");
			SetAction(27,"");
			SetAction(28,"");
			SetAction(29,"");
			SetAction(30,"");
			name = "·èÄ§Õ¶";
			nativename = "·èÄ§Õ¶";
			icon = "·èÄ§Õ¶.dds";
			SetTalent(0,618);
			SetTalent(1,630);
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
			skill_class = 0;
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
			int[] array={15,17,19,21,23,25,27,29,31};return array[level-1];
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
			return 10.000000f;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();

			victim.SetProbability(120.0f);
			victim.SetTime(((1000 * skill_level + 2000)));
			victim.SetBuffid(1);
			victim.SetValue(((2 * skill_t0 * skill_level + skill_level + 1)));
			victim.SetAddattack(true);
			return true;
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={8};return array[index];
		}
	}
	public class GSkill244 : GSkill
	{
		public GSkill244()
			: base(244)
		{
			
		}
	}
	public class GSkill245Stub : GSkillStub
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
		public GSkill245Stub()
			: base(245)
		{
			occupation = 1;
			maxlevel = 7;
			maxlearn = 6;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 3;
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
			SetAction(0,"¹íÍõ×Ú_¼¤Å­");
			SetAction(1,"¹íÍõ×Ú_¼¤Å­");
			SetAction(2,"¹íÍõ×Ú_¼¤Å­");
			SetAction(3,"¹íÍõ×Ú_¼¤Å­");
			SetAction(4,"¹íÍõ×Ú_¼¤Å­");
			SetAction(5,"¹íÍõ×Ú_¼¤Å­");
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
			SetAction(18,"¹íÍõ×Ú_Æï³Ë_¼¤Å­");
			SetAction(19,"¹íÍõ×Ú_Æï³Ë_¼¤Å­");
			SetAction(20,"¹íÍõ×Ú_Æï³Ë_¼¤Å­");
			SetAction(21,"¹íÍõ×Ú_Æï³Ë_¼¤Å­");
			SetAction(22,"¹íÍõ×Ú_Æï³Ë_¼¤Å­");
			SetAction(23,"¹íÍõ×Ú_Æï³Ë_¼¤Å­");
			SetAction(24,"");
			SetAction(25,"");
			SetAction(26,"");
			SetAction(27,"");
			SetAction(28,"");
			SetAction(29,"");
			SetAction(30,"");
			name = "Àä³°ÈÈ·í";
			nativename = "Àä³°ÈÈ·í";
			icon = "Àä³°ÈÈ·í.dds";
			SetTalent(0,639);
			SetTalent(1,645);
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
			skill_class = 0;
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
			int				skill_t0 = skill.GetT0();

			return (-10000 * skill_level) - 10000 * skill_t0 + 120000;
		}
		public override int GetEnmity(GSkill skill)
		{
			return 1;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={25,30,35,41,43,47};return array[level-1];
		}
		public override float GetPraydistance(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (2 * skill_level + 10);
		}
		public override float GetCastdistance(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (2 * skill_level + 8);
		}
		public override float GetEffectdistance(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (2 * skill_level + 12);
		}
		public override float GetMpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (skill_level * 6.5f + (skill_level * (skill_level * 0.4f)) + 62.0f);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();

			victim.SetProbability(((5 * skill_level + 65)));
			victim.SetTime(12100.0f);
			victim.SetAssault(true);
			victim.SetProbability(-1.0f);
			victim.SetTime(2000.0f);
			victim.SetBuffid(1);
			victim.SetAmount(((D2INT(zrand(100) / (100 - 6 * skill_t0)) + 1) * (skill_level * (skill_t0 * 0.06f) + (skill_level * (skill_level * 0.01f) + (skill_level * 0.15f + 0.15f)))));
			victim.SetValue(0.0f);
			victim.SetHpleak5(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_t0 = skill.GetT0();

			victim.SetTime(((2050 * skill_t0)));
			victim.SetImmunesilent(true);
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={243};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={4};return array[index];
		}
	}
	public class GSkill245 : GSkill
	{
		public GSkill245()
			: base(245)
		{
			
		}
	}
	public class GSkill246Stub : GSkillStub
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

				skill.SetRatio((skill_t2 * 0.05f + 1.0f));
				skill.SetPlus(((skill_t1 * 0.08f + 1.0f) * (((11 * skill_level) + (skill_level * (skill_level * 0.93f)) + 188.0f) * (D2INT(skill_level * 0.05f + 0.55f)) + (((D2INT(1.42f - skill_level * 0.05f)) * (16 * skill_level + 199))))));
				player.SetPerform(1);
			}
		}
		public GSkill246Stub()
			: base(246)
		{
			occupation = 2;
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
			SetAction(0,"¹íÍõ×Ú_Ê§»êÕ¶");
			SetAction(1,"¹íÍõ×Ú_Ê§»êÕ¶");
			SetAction(2,"¹íÍõ×Ú_Ê§»êÕ¶");
			SetAction(3,"¹íÍõ×Ú_Ê§»êÕ¶");
			SetAction(4,"¹íÍõ×Ú_Ê§»êÕ¶");
			SetAction(5,"¹íÍõ×Ú_Ê§»êÕ¶");
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
			SetAction(18,"¹íÍõ×Ú_Æï³Ë_Ê§»êÕ¶");
			SetAction(19,"¹íÍõ×Ú_Æï³Ë_Ê§»êÕ¶");
			SetAction(20,"¹íÍõ×Ú_Æï³Ë_Ê§»êÕ¶");
			SetAction(21,"¹íÍõ×Ú_Æï³Ë_Ê§»êÕ¶");
			SetAction(22,"¹íÍõ×Ú_Æï³Ë_Ê§»êÕ¶");
			SetAction(23,"¹íÍõ×Ú_Æï³Ë_Ê§»êÕ¶");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "Ê§»êÕ¶";
			nativename = "Ê§»êÕ¶";
			icon = "Ê§»êÕ¶.dds";
			SetTalent(0,626);
			SetTalent(1,630);
			SetTalent(2,634);
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
			skill_class = 0;
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
			return 8000;
		}
		public override int GetEnmity(GSkill skill)
		{
			return 1;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={70,72,74,76,78,80,82,84,86};return array[level-1];
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
			int				skill_level = skill.GetLevel();

			return (skill_level * 5.1f + (skill_level * (skill_level * 0.27f)) + 142.0f);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_level = player.GetLevel();
			int				player_hp = player.GetHp();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();
			int				skill_t2 = skill.GetT2();

			victim.SetProbability(((1.0f - player_level * 0.002f) * ((2 * skill_level + 48))));
			victim.SetTime(4000.0f);
			victim.SetBuffid(1);
			victim.SetAmount(((100 * skill_level + 100)));
			victim.SetValue(0.0f);
			victim.SetMpleak(true);
			victim.SetTime(((3000 * skill_t0 + 6100)));
			victim.SetBuffid(1);
			victim.SetValue(((2 * skill_level * skill_t0) + (skill_level * 3.3f + 40.0f)));
			victim.SetSubantidizzy(true);
			victim.SetProbability(((600 * D2INT(zrand(100) / (100 - 4 * skill_t0)))));
			victim.SetTime(((1050 * skill_t0)));
			victim.SetDizzy(true);
			victim.SetProbability(((2 * skill_level)));
			victim.SetTime(100.0f);
			victim.SetBuffid(2);
			victim.SetAmount((player_hp * (skill_t2 * 0.12f)));
			victim.SetValue(0.0f);
			victim.SetHpleak1(true);
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={254};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={6};return array[index];
		}
	}
	public class GSkill246 : GSkill
	{
		public GSkill246()
			: base(246)
		{
			
		}
	}
	public class GSkill247Stub : GSkillStub
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
				int				skill_t1 = skill.GetT1();

				skill.SetPlus(((skill_t1 * 0.07000000000000001f + 1.0f) * (((15 * skill_level) + (skill_level * (skill_level * 0.3f)) + 19.0f) * (D2INT(skill_level * 0.05f + 0.55f)) + ((skill_level * 3.8f + (skill_level * (skill_level * 0.2f)) + 111.0f) * (D2INT(1.42f - skill_level * 0.05f))))));
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

				skill.SetRatio((skill_level * 0.01f + 1.0f));
				skill.SetPlus(((skill_t1 * 0.07000000000000001f + 1.0f) * (((15 * skill_level) + (skill_level * (skill_level * 0.3f)) + 19.0f) * (D2INT(skill_level * 0.05f + 0.55f)) + ((skill_level * 3.8f + (skill_level * (skill_level * 0.2f)) + 111.0f) * (D2INT(1.42f - skill_level * 0.05f))))));
				player.SetPerform(0);
			}
		}
		public GSkill247Stub()
			: base(247)
		{
			occupation = 2;
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
			SetAction(0,"¹íÍõ×Ú_Ñ¸À×Õ¶");
			SetAction(1,"¹íÍõ×Ú_Ñ¸À×Õ¶");
			SetAction(2,"¹íÍõ×Ú_Ñ¸À×Õ¶");
			SetAction(3,"¹íÍõ×Ú_Ñ¸À×Õ¶");
			SetAction(4,"¹íÍõ×Ú_Ñ¸À×Õ¶");
			SetAction(5,"¹íÍõ×Ú_Ñ¸À×Õ¶");
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
			SetAction(18,"¹íÍõ×Ú_Æï³Ë_Ñ¸À×Õ¶");
			SetAction(19,"¹íÍõ×Ú_Æï³Ë_Ñ¸À×Õ¶");
			SetAction(20,"¹íÍõ×Ú_Æï³Ë_Ñ¸À×Õ¶");
			SetAction(21,"¹íÍõ×Ú_Æï³Ë_Ñ¸À×Õ¶");
			SetAction(22,"¹íÍõ×Ú_Æï³Ë_Ñ¸À×Õ¶");
			SetAction(23,"¹íÍõ×Ú_Æï³Ë_Ñ¸À×Õ¶");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "Ñ¸À×Õ¶";
			nativename = "Ñ¸À×Õ¶";
			icon = "Ñ¸À×Õ¶.dds";
			SetTalent(0,655);
			SetTalent(1,661);
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
			skill_class = 0;
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
			int				skill_t1 = skill.GetT1();

			return 3000 - 450 * skill_t1;
		}
		public override int GetEnmity(GSkill skill)
		{
			return 1;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={45,47,49,51,53,55,57,59,61};return array[level-1];
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 8.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 1.700000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 14.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			return 30.000000f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_level = player.GetLevel();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();

			victim.SetProbability(((1.0f - player_level * 0.002f) * ((20 * skill_t0))));
			victim.SetRatio((skill_t0 * (skill_level * 0.03f)));
			victim.SetDrainmagic(true);
			victim.SetProbability(((2 * skill_level * skill_t0)));
			victim.SetTime(((2050 * skill_t0)));
			victim.SetBarehanded(true);
			return true;
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={24};return array[index];
		}
	}
	public class GSkill247 : GSkill
	{
		public GSkill247()
			: base(247)
		{
			
		}
	}
	public class GSkill248Stub : GSkillStub
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
				int				skill_t3 = skill.GetT3();

				skill.SetRatio((skill_t3 * 0.05f + 1.0f));
				skill.SetPlus(((skill_t2 * 0.08f + 1.0f) * ((skill_level * (skill_level * 0.37f) + 44.0f) * (D2INT(skill_level * 0.05f + 0.55f)) + ((skill_level * 2.9f + (skill_level * (skill_level * 0.014f)) + 34.0f) * (D2INT(1.42f - skill_level * 0.05f))))));
				player.SetPerform(1);
			}
		}
		public GSkill248Stub()
			: base(248)
		{
			occupation = 1;
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
			SetAction(0,"¹íÍõ×Ú_»ğÑæµ¶");
			SetAction(1,"¹íÍõ×Ú_»ğÑæµ¶");
			SetAction(2,"¹íÍõ×Ú_»ğÑæµ¶");
			SetAction(3,"¹íÍõ×Ú_»ğÑæµ¶");
			SetAction(4,"¹íÍõ×Ú_»ğÑæµ¶");
			SetAction(5,"¹íÍõ×Ú_»ğÑæµ¶");
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
			SetAction(18,"¹íÍõ×Ú_Æï³Ë_»ğÑæµ¶");
			SetAction(19,"¹íÍõ×Ú_Æï³Ë_»ğÑæµ¶");
			SetAction(20,"¹íÍõ×Ú_Æï³Ë_»ğÑæµ¶");
			SetAction(21,"¹íÍõ×Ú_Æï³Ë_»ğÑæµ¶");
			SetAction(22,"¹íÍõ×Ú_Æï³Ë_»ğÑæµ¶");
			SetAction(23,"¹íÍõ×Ú_Æï³Ë_»ğÑæµ¶");
			SetAction(24,"");
			SetAction(25,"");
			SetAction(26,"");
			SetAction(27,"");
			SetAction(28,"");
			SetAction(29,"");
			SetAction(30,"");
			name = "»ğÑæµ¶";
			nativename = "»ğÑæµ¶";
			icon = "»ğÑæµ¶.dds";
			SetTalent(0,620);
			SetTalent(1,621);
			SetTalent(2,630);
			SetTalent(3,634);
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
			skill_class = 0;
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

			return 9000 - 1000 * skill_t0;
		}
		public override int GetEnmity(GSkill skill)
		{
			return 1;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={25,27,29,31,33,35,37,39,41};return array[level-1];
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 8.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 2.700000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 13.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			return 20.000000f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_level = player.GetLevel();
			int				player_hp = player.GetHp();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();
			int				skill_t1 = skill.GetT1();
			int				skill_t3 = skill.GetT3();

			victim.SetProbability(((1.0f - player_level * 0.002f) * 100.0f));
			victim.SetTime(12000.0f);
			victim.SetBuffid(2);
			victim.SetAmount(((skill_t0 * 0.75f + 1.0f) * ((48 * skill_level + 144))));
			victim.SetValue(0.0f);
			victim.SetHpleak4(true);
			victim.SetProbability(((4 * skill_t1 * skill_level) + (skill_level * 3.5f + 35.0f)));
			victim.SetTime(((skill_t1 * 0.35f + 1.0f) * ((300 * skill_level + 1700)) + 1000.0f));
			victim.SetDizzy(true);
			victim.SetProbability(((2 * skill_level)));
			victim.SetTime(100.0f);
			victim.SetBuffid(0);
			victim.SetAmount((player_hp * (skill_t3 * 0.12f)));
			victim.SetValue(0.0f);
			victim.SetHpleak4(true);
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={462};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={2};return array[index];
		}
	}
	public class GSkill248 : GSkill
	{
		public GSkill248()
			: base(248)
		{
			
		}
	}
	public class GSkill249Stub : GSkillStub
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
				int				player_maxhp = player.GetMaxhp();

				player.SetVar1((int)(1000 * player_hp) / player_maxhp);
				player.SetPerform(1);
			}
		}
		public GSkill249Stub()
			: base(249)
		{
			occupation = 3;
			maxlevel = 12;
			maxlearn = 8;
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
			SetAction(0,"¹íÍõ×Ú_¿İÄ¾Öä");
			SetAction(1,"¹íÍõ×Ú_¿İÄ¾Öä");
			SetAction(2,"¹íÍõ×Ú_¿İÄ¾Öä");
			SetAction(3,"¹íÍõ×Ú_¿İÄ¾Öä");
			SetAction(4,"¹íÍõ×Ú_¿İÄ¾Öä");
			SetAction(5,"¹íÍõ×Ú_¿İÄ¾Öä");
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
			SetAction(18,"¹íÍõ×Ú_Æï³Ë_¿İÄ¾Öä");
			SetAction(19,"¹íÍõ×Ú_Æï³Ë_¿İÄ¾Öä");
			SetAction(20,"¹íÍõ×Ú_Æï³Ë_¿İÄ¾Öä");
			SetAction(21,"¹íÍõ×Ú_Æï³Ë_¿İÄ¾Öä");
			SetAction(22,"¹íÍõ×Ú_Æï³Ë_¿İÄ¾Öä");
			SetAction(23,"¹íÍõ×Ú_Æï³Ë_¿İÄ¾Öä");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "¿İÄ¾Öä";
			nativename = "¿İÄ¾Öä";
			icon = "¿İÄ¾Öä.dds";
			SetTalent(0,632);
			SetTalent(1,642);
			SetTalent(2,647);
			SetTalent(3,662);
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
			skill_class = 0;
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
			int				skill_t3 = skill.GetT3();

			return 144000 - 18000 * skill_t3;
		}
		public override int GetEnmity(GSkill skill)
		{
			return 1;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={85,89,93,97,101,105,109,111};return array[level-1];
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

			return (((29 * skill_level + 45)) - skill_level * (skill_level * 0.58f));
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_maxhp = player.GetMaxhp();
			int				player_maxmp = player.GetMaxmp();
			int				player_var1 = player.GetVar1();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();
			int				skill_t1 = skill.GetT1();
			int				skill_t2 = skill.GetT2();

			victim.SetTime(2000 * skill_t2 + 20100);
			victim.SetBuffid(1);
			victim.SetValue((D2INT(zrand(11 * skill_t0 + 99) / 100) + 1) * ((4 * skill_level * skill_t1) + (skill_level * 17.5f + skill_level * (skill_level * 0.3f))));
			victim.SetAddantidizzy(true);
			
			victim.SetProbability(skill_t2<=0?0.0f:120.0f);
			victim.SetTime(60000 * skill_t2);
			victim.SetBuffid(1);
			victim.SetAmount(skill_t2 * 0.1f + 0.00001f);
			victim.SetValue(player_maxmp * (skill_t2 * 0.06f));
			victim.SetAddhp2(true);
			
			victim.SetProbability(player_var1<950?0.0f:120 * norm(skill_t2 / 3.9f));
			victim.SetRatio(0.0f);
			victim.SetValue(player_maxhp);
			victim.SetHeal(true);
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={315};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={3};return array[index];
		}
	}
	public class GSkill249 : GSkill
	{
		public GSkill249()
			: base(249)
		{
			
		}
	}
}
