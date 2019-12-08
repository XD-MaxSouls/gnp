using System;
using System.Text;

namespace SKILL
{
	public class GSkill270Stub : GSkillStub
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

				skill.SetRatio((skill_t1 * 0.05f + 1.0f));
				skill.SetPlus(((skill_level * 1.8f + (skill_level * (skill_level * 0.43f)) + 58.0f) * (D2INT(skill_level * 0.05f + 0.55f)) + (((D2INT(1.42f - skill_level * 0.05f)) * (5 * skill_level + 53)))));
				player.SetPerform(1);
			}
		}
		public GSkill270Stub()
			: base(270)
		{
			occupation = 10;
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
			SetAction(0,"ÌìÒôËÂ_Ê¨×Óºð");
			SetAction(1,"ÌìÒôËÂ_Ê¨×Óºð");
			SetAction(2,"ÌìÒôËÂ_Ê¨×Óºð");
			SetAction(3,"ÌìÒôËÂ_Ê¨×Óºð");
			SetAction(4,"ÌìÒôËÂ_Ê¨×Óºð");
			SetAction(5,"ÌìÒôËÂ_Ê¨×Óºð");
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
			SetAction(18,"ÌìÒôËÂ_Æï³Ë_Ê¨×Óºð");
			SetAction(19,"ÌìÒôËÂ_Æï³Ë_Ê¨×Óºð");
			SetAction(20,"ÌìÒôËÂ_Æï³Ë_Ê¨×Óºð");
			SetAction(21,"ÌìÒôËÂ_Æï³Ë_Ê¨×Óºð");
			SetAction(22,"ÌìÒôËÂ_Æï³Ë_Ê¨×Óºð");
			SetAction(23,"ÌìÒôËÂ_Æï³Ë_Ê¨×Óºð");
			SetAction(24,"");
			SetAction(25,"");
			SetAction(26,"");
			SetAction(27,"");
			SetAction(28,"");
			SetAction(29,"");
			SetAction(30,"");
			name = "Ê¨×Óºð";
			nativename = "Ê¨×Óºð";
			icon = "Ê¨×Óºð.dds";
			SetTalent(0,672);
			SetTalent(1,681);
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
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();

			return (100 - 15 * skill_t0) * (10500 - 500 * skill_level) / 100;
		}
		public override int GetEnmity(GSkill skill)
		{
			return 1;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={40,42,44,46,47,48,51,53,55};return array[level-1];
		}
		public override float GetRadius(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (skill_level * 0.2f + 5.8f);
		}
		public override float GetAngle(GSkill skill)
		{
			return -0.333332f;
		}
		public override float GetPraydistance(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (skill_level * 0.2f + 5.8f);
		}
		public override float GetCastdistance(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (skill_level * 0.2f + 2.3f);
		}
		public override float GetMpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (skill_level * 5.2f + (skill_level * (skill_level * 0.48f)) + 98.0f);
		}
		public override int GetCoverage(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return skill_level + 20;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_t0 = skill.GetT0();

			victim.SetProbability(((600 * D2INT(zrand(100) / (100 - 6 * skill_t0)))));
			victim.SetTime(((1050 * skill_t0)));
			victim.SetDizzy(true);
			victim.SetProbability(((5 * skill_t0 + 50)));
			victim.SetValue(9.0f);
			victim.SetRepel(true);
			return true;
		}
		public override float GetDropRate(GSkill skill)
		{
			return 0.400000f;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={269};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={6};return array[index];
		}
	}
	public class GSkill270 : GSkill
	{
		public GSkill270()
			: base(270)
		{
			
		}
	}
	public class GSkill271Stub : GSkillStub
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
				int				player_res5 = player.GetRes5();
				int				skill_level = skill.GetLevel();
				int				skill_t3 = skill.GetT3();

				player.SetVar1(player_res5);
				skill.SetRatio((skill_t3 * 0.07000000000000001f + 1.0f));
				skill.SetPlus(((15 * skill_level + 201)));
				player.SetPerform(1);
			}
		}
		public GSkill271Stub()
			: base(271)
		{
			occupation = 10;
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
			SetAction(0,"ÌìÒôËÂ_¹ÛÒô¾­");
			SetAction(1,"ÌìÒôËÂ_¹ÛÒô¾­");
			SetAction(2,"ÌìÒôËÂ_¹ÛÒô¾­");
			SetAction(3,"ÌìÒôËÂ_¹ÛÒô¾­");
			SetAction(4,"ÌìÒôËÂ_¹ÛÒô¾­");
			SetAction(5,"ÌìÒôËÂ_¹ÛÒô¾­");
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
			SetAction(18,"ÌìÒôËÂ_Æï³Ë_¹ÛÒô¾­");
			SetAction(19,"ÌìÒôËÂ_Æï³Ë_¹ÛÒô¾­");
			SetAction(20,"ÌìÒôËÂ_Æï³Ë_¹ÛÒô¾­");
			SetAction(21,"ÌìÒôËÂ_Æï³Ë_¹ÛÒô¾­");
			SetAction(22,"ÌìÒôËÂ_Æï³Ë_¹ÛÒô¾­");
			SetAction(23,"ÌìÒôËÂ_Æï³Ë_¹ÛÒô¾­");
			SetAction(24,"");
			SetAction(25,"");
			SetAction(26,"");
			SetAction(27,"");
			SetAction(28,"");
			SetAction(29,"");
			SetAction(30,"");
			name = "ËÐ¾­";
			nativename = "ËÐ¾­";
			icon = "ËÐ¾­.dds";
			SetTalent(0,671);
			SetTalent(1,690);
			SetTalent(2,698);
			SetTalent(3,702);
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
		}
		public override int GetExecutetime(GSkill skill)
		{
			return 1000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			return 9000;
		}
		public override int GetEnmity(GSkill skill)
		{
			return 1;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={30,32,34,36,38,40,42,44,46};return array[level-1];
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 8.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 5.000000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 9.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			return 20.000000f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_var1 = player.GetVar1();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();
			int				skill_t1 = skill.GetT1();
			int				skill_t2 = skill.GetT2();

			victim.SetProbability(((player_var1 * skill_t1) * 0.2f + ((2 * skill_level * skill_t1) + (skill_level * 3.7f + 37.0f))));
			victim.SetTime(((400 * skill_t0 * skill_level + (600 * skill_level) + 2000)));
			victim.SetValue(0.0f);
			victim.SetSleep(true);
			victim.SetProbability(-1.0f);
			victim.SetTime(8000.0f);
			victim.SetBuffid(1);
			victim.SetAmount(((48 * skill_level + 144)));
			victim.SetValue(0.0f);
			victim.SetHpleak(true);
			victim.SetProbability(((6 * skill_t2)));
			victim.SetTime(((4050 * skill_t2)));
			victim.SetRatio((skill_t2 * 0.03f));
			victim.SetBuffid(1);
			victim.SetDecdefence(true);
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={276};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={5};return array[index];
		}
	}
	public class GSkill271 : GSkill
	{
		public GSkill271()
			: base(271)
		{
			
		}
	}
	public class GSkill272Stub : GSkillStub
	{
		public class GState1 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 2400;
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
				return 600;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_level = player.GetLevel();
				int				skill_level = skill.GetLevel();

				skill.SetRatio((player_level * 0.01f / 7.0f + (skill_level * 0.02f + 1.0f)));
				skill.SetPlus(((skill_level * player_level) + (((15 * skill_level + 24)) - skill_level * (skill_level * 0.32f))));
				player.SetPerform(1);
			}
		}
		public GSkill272Stub()
			: base(272)
		{
			occupation = 130;
			maxlevel = 8;
			maxlearn = 8;
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
			SetAction(0,"ÌìÒôËÂ_ÂÖ»ØÖé");
			SetAction(1,"ÌìÒôËÂ_ÂÖ»ØÖé");
			SetAction(2,"ÌìÒôËÂ_ÂÖ»ØÖé");
			SetAction(3,"ÌìÒôËÂ_ÂÖ»ØÖé");
			SetAction(4,"ÌìÒôËÂ_ÂÖ»ØÖé");
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
			SetAction(18,"ÌìÒôËÂ_Æï³Ë_ÖÚÉúÂÖ»Ø");
			SetAction(19,"ÌìÒôËÂ_Æï³Ë_ÖÚÉúÂÖ»Ø");
			SetAction(20,"ÌìÒôËÂ_Æï³Ë_ÖÚÉúÂÖ»Ø");
			SetAction(21,"ÌìÒôËÂ_Æï³Ë_ÖÚÉúÂÖ»Ø");
			SetAction(22,"ÌìÒôËÂ_Æï³Ë_ÖÚÉúÂÖ»Ø");
			SetAction(23,"0");
			SetAction(24,"");
			SetAction(25,"");
			SetAction(26,"");
			SetAction(27,"");
			SetAction(28,"");
			SetAction(29,"");
			SetAction(30,"");
			name = "ÖÚÉúÂÖ»Ø";
			nativename = "ÖÚÉúÂÖ»Ø";
			icon = "ÖÚÉúÂÖ»Ø.dds";
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
		public override float GetRadius(GSkill skill)
		{
			return 10.000000f;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 10.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 6.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return ((24 * skill_level) + (skill_level * (skill_level * 1.6f)) + 216.0f);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();

			victim.SetRatio(0.0f);
			victim.SetAmount(0.0f);
			victim.SetValue((skill_level * 0.01f + 0.09f));
			victim.SetSecondattack(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();

			victim.SetValue(((8 * skill_level)));
			victim.SetJuqi(true);
			return true;
		}
	}
	public class GSkill272 : GSkill
	{
		public GSkill272()
			: base(272)
		{
			
		}
	}
	public class GSkill273Stub : GSkillStub
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
		public GSkill273Stub()
			: base(273)
		{
			occupation = 11;
			maxlevel = 20;
			maxlearn = 12;
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
			SetAction(0,"ÌìÒôËÂ_ºêÔ¸");
			SetAction(1,"ÌìÒôËÂ_ºêÔ¸");
			SetAction(2,"ÌìÒôËÂ_ºêÔ¸");
			SetAction(3,"ÌìÒôËÂ_ºêÔ¸");
			SetAction(4,"ÌìÒôËÂ_ºêÔ¸");
			SetAction(5,"ÌìÒôËÂ_ºêÔ¸");
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
			SetAction(18,"ÌìÒôËÂ_Æï³Ë_ºêÔ¸");
			SetAction(19,"ÌìÒôËÂ_Æï³Ë_ºêÔ¸");
			SetAction(20,"ÌìÒôËÂ_Æï³Ë_ºêÔ¸");
			SetAction(21,"ÌìÒôËÂ_Æï³Ë_ºêÔ¸");
			SetAction(22,"ÌìÒôËÂ_Æï³Ë_ºêÔ¸");
			SetAction(23,"ÌìÒôËÂ_Æï³Ë_ºêÔ¸");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "ºêÔ¸";
			nativename = "ºêÔ¸";
			icon = "ºêÔ¸.dds";
			SetTalent(0,703);
			SetTalent(1,711);
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
			return 2000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			int				skill_t0 = skill.GetT0();

			return 2000 - 1000 * skill_t0;
		}
		public override int GetEnmity(GSkill skill)
		{
			return 1;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={46,48,50,52,56,59,62,65,68,72,75,78};return array[level-1];
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 15.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 13.000000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 17.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return ((20 * skill_level) + (skill_level * (skill_level * 3.7f)) + 247.0f);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_level = player.GetLevel();
			int				skill_level = skill.GetLevel();
			int				skill_t1 = skill.GetT1();
			int				skill_t2 = skill.GetT2();

			victim.SetProbability(100.0f);
			victim.SetRatio(0.0f);
			victim.SetValue(((skill_t2 * 0.15f + 1.0f) * (D2INT((40 * skill_level) + (skill_level * (skill_level * 7.4f)) + 494.0f))));
			victim.SetHeal(true);
			victim.SetProbability(120.0f);
			victim.SetTime(6000.0f);
			victim.SetRatio(0.0f);
			victim.SetBuffid(2);
			victim.SetAmount(0.0f);
			victim.SetValue(((skill_t2 * 0.15f + 1.0f) * (D2INT((skill_level * 6.9f + (skill_level * (skill_level * 1.29f)) + 172.8f) * 3.0f))));
			victim.SetHpgen(true);
			victim.SetTime(((90000 * skill_t1 + 90000)));
			victim.SetBuffid(1);
			victim.SetValue(((skill_t1 * 0.6f + 1.0f) * (player_level * (skill_level * 0.15f + 0.45f))));
			victim.SetAddmp(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();
			int				skill_t2 = skill.GetT2();

			victim.SetProbability(100.0f);
			victim.SetTime(((1800000 * norm(skill_t2))));
			victim.SetRatio(0.0f);
			victim.SetBuffid(2);
			victim.SetValue(((100 * skill_t2 * skill_level)));
			victim.SetTiangu(true);
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={274};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={1};return array[index];
		}
	}
	public class GSkill273 : GSkill
	{
		public GSkill273()
			: base(273)
		{
			
		}
	}
	public class GSkill274Stub : GSkillStub
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

				skill.SetRatio((skill_t2 * 0.07000000000000001f + 1.0f));
				skill.SetPlus((((20 * skill_level + 224) * (D2INT((zrand(7 * skill_t3 + 99)) / 100) + 1))));
				player.SetPerform(1);
			}
		}
		public GSkill274Stub()
			: base(274)
		{
			occupation = 11;
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
			SetAction(0,"ÌìÒôËÂ_°ãÈô¾­");
			SetAction(1,"ÌìÒôËÂ_°ãÈô¾­");
			SetAction(2,"ÌìÒôËÂ_°ãÈô¾­");
			SetAction(3,"ÌìÒôËÂ_°ãÈô¾­");
			SetAction(4,"ÌìÒôËÂ_°ãÈô¾­");
			SetAction(5,"ÌìÒôËÂ_°ãÈô¾­");
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
			SetAction(18,"ÌìÒôËÂ_Æï³Ë_°ãÈô¾­");
			SetAction(19,"ÌìÒôËÂ_Æï³Ë_°ãÈô¾­");
			SetAction(20,"ÌìÒôËÂ_Æï³Ë_°ãÈô¾­");
			SetAction(21,"ÌìÒôËÂ_Æï³Ë_°ãÈô¾­");
			SetAction(22,"ÌìÒôËÂ_Æï³Ë_°ãÈô¾­");
			SetAction(23,"ÌìÒôËÂ_Æï³Ë_°ãÈô¾­");
			SetAction(24,"");
			SetAction(25,"");
			SetAction(26,"");
			SetAction(27,"");
			SetAction(28,"");
			SetAction(29,"");
			SetAction(30,"");
			name = "°ãÈô¾­";
			nativename = "°ãÈô¾­";
			icon = "°ãÈô¾­.dds";
			SetTalent(0,692);
			SetTalent(1,698);
			SetTalent(2,702);
			SetTalent(3,708);
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
		}
		public override int GetExecutetime(GSkill skill)
		{
			return 1000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			return 4000;
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
			return 20.000000f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();
			int				skill_t1 = skill.GetT1();

			victim.SetTime(((skill_t0 * 0.3f + 1.0f) * ((4000 * skill_level + 4000)) + 100.0f));
			victim.SetBuffid(1);
			victim.SetValue(((2 * skill_level * skill_t0) + (skill_level * 2.2f + 31.0f)));
			victim.SetSubantisleep(true);
			victim.SetProbability(((6 * skill_t1)));
			victim.SetTime(((4050 * skill_t1)));
			victim.SetRatio((skill_t1 * 0.03f));
			victim.SetBuffid(1);
			victim.SetDecdefence(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();
			int				skill_t3 = skill.GetT3();

			victim.SetValue(((8 * skill_level * (skill_t3 + 1))));
			victim.SetJuqi(true);
			return true;
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={24};return array[index];
		}
	}
	public class GSkill274 : GSkill
	{
		public GSkill274()
			: base(274)
		{
			
		}
	}
	public class GSkill275Stub : GSkillStub
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
				int				player_hp = player.GetHp();
				int				skill_level = skill.GetLevel();
				int				skill_t0 = skill.GetT0();
				int				skill_t2 = skill.GetT2();

				skill.SetRatio((skill_t2 * 0.07000000000000001f + 1.0f));
				player.SetHp((player_hp * 0.9f));
				skill.SetPlus(((skill_t0 * 0.12f + 1.0f) * (((D2INT(skill_level * 0.05f + 0.55f)) * ((13 * skill_level * skill_level) - 180 * skill_level + 2740)) + ((((31 * skill_level + 1690)) - skill_level * (skill_level * 0.29f)) * (D2INT(1.42f - skill_level * 0.05f))))));
				player.SetPerform(1);
			}
		}
		public GSkill275Stub()
			: base(275)
		{
			occupation = 12;
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
			SetAction(0,"ÌìÒôËÂ_Í¬¹é¼«ÀÖ");
			SetAction(1,"ÌìÒôËÂ_Í¬¹é¼«ÀÖ");
			SetAction(2,"ÌìÒôËÂ_Í¬¹é¼«ÀÖ");
			SetAction(3,"ÌìÒôËÂ_Í¬¹é¼«ÀÖ");
			SetAction(4,"ÌìÒôËÂ_Í¬¹é¼«ÀÖ");
			SetAction(5,"ÌìÒôËÂ_Í¬¹é¼«ÀÖ");
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
			SetAction(18,"ÌìÒôËÂ_Æï³Ë_Í¬¹é¼«ÀÖ");
			SetAction(19,"ÌìÒôËÂ_Æï³Ë_Í¬¹é¼«ÀÖ");
			SetAction(20,"ÌìÒôËÂ_Æï³Ë_Í¬¹é¼«ÀÖ");
			SetAction(21,"ÌìÒôËÂ_Æï³Ë_Í¬¹é¼«ÀÖ");
			SetAction(22,"ÌìÒôËÂ_Æï³Ë_Í¬¹é¼«ÀÖ");
			SetAction(23,"ÌìÒôËÂ_Æï³Ë_Í¬¹é¼«ÀÖ");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "Í¬¹é¼«ÀÖ";
			nativename = "Í¬¹é¼«ÀÖ";
			icon = "Í¬¹é¼«ÀÖ.dds";
			SetTalent(0,696);
			SetTalent(1,698);
			SetTalent(2,702);
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
			return 2000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			return 10000;
		}
		public override int GetEnmity(GSkill skill)
		{
			return 1;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={90,92,94,96,98,100,102,104,106};return array[level-1];
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 13.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 9.000000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 18.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return ((skill_level * (skill_level * 4.1f)) - (22 * skill_level) + 880.0f);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_t1 = skill.GetT1();

			victim.SetProbability(((6 * skill_t1)));
			victim.SetTime(((4050 * skill_t1)));
			victim.SetRatio((skill_t1 * 0.03f));
			victim.SetBuffid(1);
			victim.SetDecdefence(true);
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={319};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={4};return array[index];
		}
	}
	public class GSkill275 : GSkill
	{
		public GSkill275()
			: base(275)
		{
			
		}
	}
	public class GSkill276Stub : GSkillStub
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
		public GSkill276Stub()
			: base(276)
		{
			occupation = 10;
			maxlevel = 20;
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
			SetAction(0,"ÌìÒôËÂ_Ò×½î¾­");
			SetAction(1,"ÌìÒôËÂ_Ò×½î¾­");
			SetAction(2,"ÌìÒôËÂ_Ò×½î¾­");
			SetAction(3,"ÌìÒôËÂ_Ò×½î¾­");
			SetAction(4,"ÌìÒôËÂ_Ò×½î¾­");
			SetAction(5,"ÌìÒôËÂ_Ò×½î¾­");
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
			SetAction(18,"ÌìÒôËÂ_Æï³Ë_Ò×½î¾­");
			SetAction(19,"ÌìÒôËÂ_Æï³Ë_Ò×½î¾­");
			SetAction(20,"ÌìÒôËÂ_Æï³Ë_Ò×½î¾­");
			SetAction(21,"ÌìÒôËÂ_Æï³Ë_Ò×½î¾­");
			SetAction(22,"ÌìÒôËÂ_Æï³Ë_Ò×½î¾­");
			SetAction(23,"ÌìÒôËÂ_Æï³Ë_Ò×½î¾­");
			SetAction(24,"");
			SetAction(25,"");
			SetAction(26,"");
			SetAction(27,"");
			SetAction(28,"");
			SetAction(29,"");
			SetAction(30,"");
			name = "Ò×½î¾­";
			nativename = "Ò×½î¾­";
			icon = "Ò×½î¾­.dds";
			SetTalent(0,700);
			SetTalent(1,705);
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

			return 120000 - 20000 * skill_t0;
		}
		public override int GetEnmity(GSkill skill)
		{
			return 1;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={20,22,24,26,28,30,32,34};return array[level-1];
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

			return (135 - 5 * skill_level);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();
			int				skill_t1 = skill.GetT1();

			victim.SetProbability(120.0f);
			victim.SetTime(((2000 * skill_level + 8100)));
			victim.SetBuffid(1);
			victim.SetValue(((skill_t0 * 0.1f + 1.0f) * (skill_level * 0.4f + 0.4f)));
			victim.SetAddspeed(true);
			victim.SetTime(((5000 * skill_t1 + (2000 * skill_level) + 8100)));
			victim.SetRatio((skill_t1 * 0.5f + (skill_level * 0.3f)));
			victim.SetBuffid(1);
			victim.SetInchpgen(true);
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={267};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={1};return array[index];
		}
	}
	public class GSkill276 : GSkill
	{
		public GSkill276()
			: base(276)
		{
			
		}
	}
	public class GSkill277Stub : GSkillStub
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
				int				player_mp = player.GetMp();
				int				player_maxmp = player.GetMaxmp();
				int				skill_level = skill.GetLevel();

				player.SetVar1((player_mp - skill_level * (player_maxmp * 0.04f) > 0.0f)?1:0);
				player.SetMp(player_mp - skill_level * (player_maxmp * 0.04f) <= 0.0f?player_mp:player_mp - skill_level * (player_maxmp * 0.04f));
				player.SetPerform(1);
			}
		}
		public GSkill277Stub()
			: base(277)
		{
			occupation = 12;
			maxlevel = 20;
			maxlearn = 12;
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
			SetAction(0,"ÌìÒôËÂ_·ð¹âÆÕÕÕ");
			SetAction(1,"ÌìÒôËÂ_·ð¹âÆÕÕÕ");
			SetAction(2,"ÌìÒôËÂ_·ð¹âÆÕÕÕ");
			SetAction(3,"ÌìÒôËÂ_·ð¹âÆÕÕÕ");
			SetAction(4,"ÌìÒôËÂ_·ð¹âÆÕÕÕ");
			SetAction(5,"ÌìÒôËÂ_·ð¹âÆÕÕÕ");
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
			SetAction(18,"ÌìÒôËÂ_Æï³Ë_·ð¹âÆÕÕÕ");
			SetAction(19,"ÌìÒôËÂ_Æï³Ë_·ð¹âÆÕÕÕ");
			SetAction(20,"ÌìÒôËÂ_Æï³Ë_·ð¹âÆÕÕÕ");
			SetAction(21,"ÌìÒôËÂ_Æï³Ë_·ð¹âÆÕÕÕ");
			SetAction(22,"ÌìÒôËÂ_Æï³Ë_·ð¹âÆÕÕÕ");
			SetAction(23,"ÌìÒôËÂ_Æï³Ë_·ð¹âÆÕÕÕ");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "·ð¹âÆÕÕÕ";
			nativename = "·ð¹âÆÕÕÕ";
			icon = "·ð¹âÆÕÕÕ.dds";
			SetTalent(0,703);
			SetTalent(1,710);
			SetTalent(2,715);
			SetTalent(3,719);
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
		}
		public override int GetExecutetime(GSkill skill)
		{
			return 2000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			int				skill_t0 = skill.GetT0();

			return 60000 - 1000 * skill_t0;
		}
		public override int GetEnmity(GSkill skill)
		{
			return 1;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={76,78,80,83,86,89,92,95,98,102,105,108};return array[level-1];
		}
		public override float GetRadius(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (skill_level + 6);
		}
		public override float GetPraydistance(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (skill_level + 6);
		}
		public override float GetCastdistance(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (skill_level + 2);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_mp = player.GetMp();
			int				player_maxmp = player.GetMaxmp();
			int				player_var1 = player.GetVar1();
			int				skill_level = skill.GetLevel();
			int				skill_t1 = skill.GetT1();
			int				skill_t2 = skill.GetT2();
			int				skill_t3 = skill.GetT3();

			victim.SetProbability(((100 * player_var1)));
			victim.SetRatio(1.0f);
			victim.SetValue(((skill_t3 * 0.15f + 1.0f) * (player_maxmp * (skill_t2 * 0.06f + (skill_level * 0.04f)) * (norm(zrand(121) / 100) * ((skill_t2 + 1) * 0.2f) + 1.0f))));
			victim.SetHeal(true);
			victim.SetProbability(-1.0f);
			victim.SetTime(8000.0f);
			victim.SetRatio(0.0f);
			victim.SetBuffid(3);
			victim.SetAmount((player_mp * (skill_t1 * 0.02f)));
			victim.SetValue(((skill_t3 * 0.15f + 1.0f) * (player_maxmp * (skill_level * 0.04f))));
			victim.SetHpgen(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();
			int				skill_t3 = skill.GetT3();

			victim.SetProbability(100.0f);
			victim.SetTime(((1800000 * norm(skill_t3))));
			victim.SetRatio(0.0f);
			victim.SetBuffid(3);
			victim.SetValue(((100 * skill_t3 * skill_level)));
			victim.SetTiangu(true);
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={282};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={1};return array[index];
		}
	}
	public class GSkill277 : GSkill
	{
		public GSkill277()
			: base(277)
		{
			
		}
	}
	public class GSkill278Stub : GSkillStub
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
				int				skill_t3 = skill.GetT3();

				skill.SetRatio((skill_t3 * 0.07000000000000001f + 1.04f));
				skill.SetPlus(((skill_t1 * 0.3f + 1.0f) * (((26 * skill_level) + (skill_level * (skill_level * 0.21f)) + 50.0f) * (D2INT(skill_level * 0.05f + 0.55f)) + (((D2INT(1.42f - skill_level * 0.05f)) * (6 * skill_level + 203))))));
				player.SetPerform(1);
			}
		}
		public GSkill278Stub()
			: base(278)
		{
			occupation = 11;
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
			SetAction(0,"ÌìÒôËÂ_½ð¸Õ¾­");
			SetAction(1,"ÌìÒôËÂ_½ð¸Õ¾­");
			SetAction(2,"ÌìÒôËÂ_½ð¸Õ¾­");
			SetAction(3,"ÌìÒôËÂ_½ð¸Õ¾­");
			SetAction(4,"ÌìÒôËÂ_½ð¸Õ¾­");
			SetAction(5,"ÌìÒôËÂ_½ð¸Õ¾­");
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
			SetAction(18,"ÌìÒôËÂ_Æï³Ë_½ð¸Õ¾­");
			SetAction(19,"ÌìÒôËÂ_Æï³Ë_½ð¸Õ¾­");
			SetAction(20,"ÌìÒôËÂ_Æï³Ë_½ð¸Õ¾­");
			SetAction(21,"ÌìÒôËÂ_Æï³Ë_½ð¸Õ¾­");
			SetAction(22,"ÌìÒôËÂ_Æï³Ë_½ð¸Õ¾­");
			SetAction(23,"ÌìÒôËÂ_Æï³Ë_½ð¸Õ¾­");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "½ð¸Õ¾­";
			nativename = "½ð¸Õ¾­";
			icon = "½ð¸Õ¾­.dds";
			SetTalent(0,676);
			SetTalent(1,693);
			SetTalent(2,698);
			SetTalent(3,702);
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
		}
		public override int GetExecutetime(GSkill skill)
		{
			return 1000;
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
			return 40.000000f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_level = player.GetLevel();
			int				skill_t0 = skill.GetT0();
			int				skill_t2 = skill.GetT2();

			victim.SetProbability(((6 * skill_t2)));
			victim.SetTime(((4050 * skill_t2)));
			victim.SetRatio((skill_t2 * 0.03f));
			victim.SetBuffid(1);
			victim.SetDecdefence(true);
			victim.SetProbability(((1.0f - player_level * 0.002f) * 100.0f));
			victim.SetTime(((8000 * norm(skill_t0))));
			victim.SetBuffid(1);
			victim.SetAmount(((2 * skill_t0 * player_level)));
			victim.SetValue(0.0f);
			victim.SetHpleak(true);
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={279};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={2};return array[index];
		}
	}
	public class GSkill278 : GSkill
	{
		public GSkill278()
			: base(278)
		{
			
		}
	}
	public class GSkill279Stub : GSkillStub
	{
		public GSkill279Stub()
			: base(279)
		{
			occupation = 11;
			maxlevel = 12;
			maxlearn = 5;
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
			name = "Ã÷¾µÌ¨";
			nativename = "Ã÷¾µÌ¨";
			icon = "Ã÷¾µÌ¨.dds";
			SetTalent(0,674);
			SetTalent(1,712);
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
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={50,54,60,65,70};return array[level-1];
		}
		public override bool TakeEffect(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();
			int				skill_t1 = skill.GetT1();

			player.SetPasinccrit((skill_t0 * 0.03f));
			player.SetPasaddsmite((skill_level * (skill_t1 * 0.01f)));
			player.SetPasadddefence(((skill_t0 * 0.15f + 1.0f) * (skill_level * 4.5f + (skill_level * (skill_level * 0.5f)) + 5.0f)));
			player.SetPasaddattack(((skill_level * skill_t1)));
			player.SetPasadddodge(((skill_level * skill_t1)));
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={274};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={1};return array[index];
		}
	}
	public class GSkill279 : GSkill
	{
		public GSkill279()
			: base(279)
		{
			
		}
	}
}
