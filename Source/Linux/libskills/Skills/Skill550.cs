using System;
using System.Text;

namespace SKILL
{
	public class GSkill550Stub : GSkillStub
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

				player.SetVar1(player_res5);
				player.SetPerform(1);
			}
		}
		public GSkill550Stub()
			: base(550)
		{
			occupation = 22;
			maxlevel = 20;
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
			SetAction(0,"ÌìÒôËÂ_¼ÅÃğÖä");
			SetAction(1,"ÌìÒôËÂ_¼ÅÃğÖä");
			SetAction(2,"ÌìÒôËÂ_¼ÅÃğÖä");
			SetAction(3,"ÌìÒôËÂ_¼ÅÃğÖä");
			SetAction(4,"ÌìÒôËÂ_¼ÅÃğÖä");
			SetAction(5,"ÌìÒôËÂ_¼ÅÃğÖä");
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
			SetAction(18,"ÌìÒôËÂ_Æï³Ë_¼ÅÃğÖä");
			SetAction(19,"ÌìÒôËÂ_Æï³Ë_¼ÅÃğÖä");
			SetAction(20,"ÌìÒôËÂ_Æï³Ë_¼ÅÃğÖä");
			SetAction(21,"ÌìÒôËÂ_Æï³Ë_¼ÅÃğÖä");
			SetAction(22,"ÌìÒôËÂ_Æï³Ë_¼ÅÃğÖä");
			SetAction(23,"ÌìÒôËÂ_Æï³Ë_¼ÅÃğÖä");
			SetAction(24,"");
			SetAction(25,"");
			SetAction(26,"");
			SetAction(27,"");
			SetAction(28,"");
			SetAction(29,"");
			SetAction(30,"");
			name = "¼ÅÃğ±ÎÈÕ";
			nativename = "¼ÅÃğ±ÎÈÕ";
			icon = "¼ÅÃğ±ÎÈÕ.dds";
			SetTalent(0,682);
			SetTalent(1,694);
			SetTalent(2,713);
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

			return 120000 - 15000 * skill_t0;
		}
		public override int GetEnmity(GSkill skill)
		{
			return 1;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={115,117,119,121,123,125,125,125};return array[level-1];
		}
		public override float GetRadius(GSkill skill)
		{
			return 18.000000f;
		}
		public override float GetPraydistance(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (skill_level + 20);
		}
		public override float GetCastdistance(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (skill_level + 17);
		}
		public override float GetEffectdistance(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (skill_level + 38);
		}
		public override float GetMpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (10 * skill_level + 550);
		}
		public override int GetCoverage(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return 3 * skill_level;
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

			victim.SetProbability(((13 * skill_t0 + (2 * skill_level) + 48)));
			victim.SetTime(((8000 * skill_t2 + (1000 * skill_level) + 11100)));
			victim.SetRatio((skill_t1 * 0.02001f + (skill_level * 0.01001f)));
			victim.SetBuffid(1);
			victim.SetDeccritrate(true);
			victim.SetProbability(-1.0f);
			victim.SetTime(((8000 * skill_t2 + (1000 * skill_level) + 11100)));
			victim.SetRatio((skill_t1 * 0.2f + (skill_level * 0.1f)));
			victim.SetBuffid(1);
			victim.SetDeccrithurt(true);
			victim.SetTime(((1000 * skill_t0 * skill_level)));
			victim.SetBuffid(1);
			victim.SetValue((player_var1 * (skill_t0 * 0.1f)));
			victim.SetSubantisleep(true);
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={547};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={2};return array[index];
		}
	}
	public class GSkill550 : GSkill
	{
		public GSkill550()
			: base(550)
		{
			
		}
	}
	public class GSkill551Stub : GSkillStub
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
		public GSkill551Stub()
			: base(551)
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
			SetAction(0,"ÌìÒôËÂ_Ò»ºÈ");
			SetAction(1,"ÌìÒôËÂ_Ò»ºÈ");
			SetAction(2,"ÌìÒôËÂ_Ò»ºÈ");
			SetAction(3,"ÌìÒôËÂ_Ò»ºÈ");
			SetAction(4,"ÌìÒôËÂ_Ò»ºÈ");
			SetAction(5,"ÌìÒôËÂ_Ò»ºÈ");
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
			SetAction(18,"ÌìÒôËÂ_Æï³Ë_Ò»ºÈ");
			SetAction(19,"ÌìÒôËÂ_Æï³Ë_Ò»ºÈ");
			SetAction(20,"ÌìÒôËÂ_Æï³Ë_Ò»ºÈ");
			SetAction(21,"ÌìÒôËÂ_Æï³Ë_Ò»ºÈ");
			SetAction(22,"ÌìÒôËÂ_Æï³Ë_Ò»ºÈ");
			SetAction(23,"ÌìÒôËÂ_Æï³Ë_Ò»ºÈ");
			SetAction(24,"");
			SetAction(25,"");
			SetAction(26,"");
			SetAction(27,"");
			SetAction(28,"");
			SetAction(29,"");
			SetAction(30,"");
			name = "Òò¹ûÑ­»·";
			nativename = "Òò¹ûÑ­»·";
			icon = "Òò¹ûÑ­»·.dds";
			SetTalent(0,683);
			SetTalent(1,701);
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
			return 180000;
		}
		public override int GetEnmity(GSkill skill)
		{
			return 1;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={115,118,121,124,125,125,125,125};return array[level-1];
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

			return (3 * skill_level * skill_level + (15 * skill_level) + 600);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();
			int				skill_t1 = skill.GetT1();

			victim.SetProbability(120.0f);
			victim.SetTime(((600000 * skill_t0 + 600000)));
			victim.SetRatio((skill_level * (skill_t1 * 0.01f + 0.02f)));
			victim.SetAmount(0.0f);
			victim.SetValue(((10 * skill_t0 + 50)));
			victim.SetRetort(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();
			int				skill_t1 = skill.GetT1();

			victim.SetTime(((5000 * (skill_t1 + skill_level))));
			victim.SetRatio(0.02f);
			victim.SetValue(1.0f);
			victim.SetAutorescurrect(true);
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={548};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={3};return array[index];
		}
	}
	public class GSkill551 : GSkill
	{
		public GSkill551()
			: base(551)
		{
			
		}
	}
	public class GSkill552Stub : GSkillStub
	{
		public class GState1 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 1500;
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
				int				player_res5 = player.GetRes5();
				int				skill_level = skill.GetLevel();
				int				skill_t0 = skill.GetT0();
				int				skill_t1 = skill.GetT1();

				player.SetVar1(1);
				player.SetVar2(player_res5);
				skill.SetRatio((skill_t1 * 0.07000000000000001f + 1.0f));
				skill.SetCrit(((skill_level / 9) * (skill_t0 * 0.01f + 0.01f)));
				skill.SetPlus(((((81 * skill_level + 596)) - skill_level * (skill_level * 1.8f)) * (D2INT(skill_level * 0.05f + 0.55f)) + (((17 * skill_level) + (skill_level * (skill_level * 0.089f)) + 742.0f) * (D2INT(1.42f - skill_level * 0.05f)) + ((((skill_t0 + 1) * (skill_level / 9 * player_res5)) * norm(skill_t0))))));
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
				return 1000;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_res5 = player.GetRes5();
				int				player_var2 = player.GetVar2();
				int				skill_level = skill.GetLevel();
				int				skill_t0 = skill.GetT0();
				int				skill_t1 = skill.GetT1();

				player.SetVar1(1);
				player.SetVar2(player_res5);
				skill.SetRatio((skill_t1 * 0.07000000000000001f + 1.0f));
				skill.SetCrit(((skill_level / 9) * (skill_t0 * 0.01f + 0.02f)));
				skill.SetPlus(((((81 * skill_level + 596)) - skill_level * (skill_level * 1.8f)) * (D2INT(skill_level * 0.05f + 0.55f)) + (((17 * skill_level) + (skill_level * (skill_level * 0.089f)) + 742.0f) * (D2INT(1.42f - skill_level * 0.05f)) + ((((skill_t0 + 2) * (skill_level / 9 * player_var2)) * norm(skill_t0))))));
				player.SetPerform(1);
			}
			public override bool Cancel(GSkill skill)
			{
				return true;
			}
		}
		public class GState4 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 1000;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_res5 = player.GetRes5();
				int				player_var2 = player.GetVar2();
				int				skill_level = skill.GetLevel();
				int				skill_t0 = skill.GetT0();
				int				skill_t1 = skill.GetT1();

				player.SetVar1(1);
				player.SetVar2(player_res5);
				skill.SetRatio((skill_t1 * 0.07000000000000001f + 1.0f));
				skill.SetCrit(((skill_level / 9) * (skill_t0 * 0.01f + 0.03f)));
				skill.SetPlus(((((81 * skill_level + 596)) - skill_level * (skill_level * 1.8f)) * (D2INT(skill_level * 0.05f + 0.55f)) + (((17 * skill_level) + (skill_level * (skill_level * 0.089f)) + 742.0f) * (D2INT(1.42f - skill_level * 0.05f)) + ((((skill_t0 + 3) * (skill_level / 9 * player_var2)) * norm(skill_t0))))));
				player.SetPerform(1);
			}
			public override bool Cancel(GSkill skill)
			{
				return true;
			}
		}
		public class GState5 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 500;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_res5 = player.GetRes5();
				int				player_var2 = player.GetVar2();
				int				skill_level = skill.GetLevel();
				int				skill_t0 = skill.GetT0();
				int				skill_t1 = skill.GetT1();

				player.SetVar1(0);
				player.SetVar2(player_res5);
				skill.SetRatio((skill_t1 * 0.07000000000000001f + 1.0f));
				skill.SetCrit(((skill_level / 9) * (skill_t0 * 0.01f + 0.04f)));
				skill.SetPlus(((((81 * skill_level + 596)) - skill_level * (skill_level * 1.8f)) * (D2INT(skill_level * 0.05f + 0.55f)) + (((17 * skill_level) + (skill_level * (skill_level * 0.089f)) + 742.0f) * (D2INT(1.42f - skill_level * 0.05f)) + ((((skill_t0 + 4) * (skill_level / 9 * player_var2)) * norm(skill_t0))))));
				player.SetPerform(1);
			}
			public override bool Cancel(GSkill skill)
			{
				return true;
			}
		}
		public class GState6 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 500;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_res5 = player.GetRes5();
				int				player_var2 = player.GetVar2();
				int				skill_level = skill.GetLevel();
				int				skill_t0 = skill.GetT0();
				int				skill_t1 = skill.GetT1();

				player.SetVar1(0);
				player.SetVar2(player_res5);
				skill.SetRatio((skill_t1 * 0.07000000000000001f + 1.0f));
				skill.SetCrit(((skill_level / 9) * (skill_t0 * 0.01f + 0.05f)));
				skill.SetPlus(((((81 * skill_level + 596)) - skill_level * (skill_level * 1.8f)) * (D2INT(skill_level * 0.05f + 0.55f)) + (((17 * skill_level) + (skill_level * (skill_level * 0.089f)) + 742.0f) * (D2INT(1.42f - skill_level * 0.05f)) + ((((skill_t0 + 5) * (skill_level / 9 * player_var2)) * norm(skill_t0))))));
				player.SetPerform(1);
			}
			public override bool Cancel(GSkill skill)
			{
				return true;
			}
		}
		public class GState7 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 500;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_res5 = player.GetRes5();
				int				player_var2 = player.GetVar2();
				int				skill_level = skill.GetLevel();
				int				skill_t0 = skill.GetT0();
				int				skill_t1 = skill.GetT1();

				player.SetVar1(0);
				player.SetVar2(player_res5);
				skill.SetRatio((skill_t1 * 0.07000000000000001f + 1.0f));
				skill.SetCrit(((skill_level / 9) * (skill_t0 * 0.01f + 0.06f)));
				skill.SetPlus(((((81 * skill_level + 596)) - skill_level * (skill_level * 1.8f)) * (D2INT(skill_level * 0.05f + 0.55f)) + (((17 * skill_level) + (skill_level * (skill_level * 0.089f)) + 742.0f) * (D2INT(1.42f - skill_level * 0.05f)) + ((((skill_t0 + 6) * (skill_level / 9 * player_var2)) * norm(skill_t0))))));
				player.SetPerform(1);
			}
		}
		public GSkill552Stub()
			: base(552)
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
			SetAction(0,"ÌìÒôËÂ_ÁùµÀÂÖ»Ø");
			SetAction(1,"ÌìÒôËÂ_ÁùµÀÂÖ»Ø");
			SetAction(2,"ÌìÒôËÂ_ÁùµÀÂÖ»Ø");
			SetAction(3,"ÌìÒôËÂ_ÁùµÀÂÖ»Ø");
			SetAction(4,"ÌìÒôËÂ_ÁùµÀÂÖ»Ø");
			SetAction(5,"ÌìÒôËÂ_ÁùµÀÂÖ»Ø");
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
			SetAction(18,"ÌìÒôËÂ_Æï³Ë_ÁùµÀÂÖ»Ø");
			SetAction(19,"ÌìÒôËÂ_Æï³Ë_ÁùµÀÂÖ»Ø");
			SetAction(20,"ÌìÒôËÂ_Æï³Ë_ÁùµÀÂÖ»Ø");
			SetAction(21,"ÌìÒôËÂ_Æï³Ë_ÁùµÀÂÖ»Ø");
			SetAction(22,"ÌìÒôËÂ_Æï³Ë_ÁùµÀÂÖ»Ø");
			SetAction(23,"ÌìÒôËÂ_Æï³Ë_ÁùµÀÂÖ»Ø");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "ÁùµÀÂÖ»Ø";
			nativename = "ÁùµÀÂÖ»Ø";
			icon = "ÁùµÀÂÖ»Ø.dds";
			SetTalent(0,699);
			SetTalent(1,702);
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
			AddState(new GState3());
			AddState(new GState4());
			AddState(new GState5());
			AddState(new GState6());
			AddState(new GState7());
		}
		public override int GetExecutetime(GSkill skill)
		{
			return 6000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			int				skill_t0 = skill.GetT0();

			return 20000 - 3000 * skill_t0;
		}
		public override int GetEnmity(GSkill skill)
		{
			return 1;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={120,122,124,125,125,125,125,125,125};return array[level-1];
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 28.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (skill_level + 10);
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 33.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (((27 * skill_level + 325)) - skill_level * (skill_level * 0.17f));
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_var1 = player.GetVar1();
			int				player_var2 = player.GetVar2();

			victim.SetProbability(6.0f);
			victim.SetTime(2100.0f);
			victim.SetRatio(0.1f);
			victim.SetValue(0.1f);
			victim.SetRandcurse(true);
			victim.SetProbability(player_var1 == 1?player_var2:0.0f);
			victim.SetTime(2000.0f);
			victim.SetValue(0.0f);
			victim.SetSleep(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_maxhp = player.GetMaxhp();

			victim.SetProbability(8.0f);
			victim.SetRatio(0.0f);
			victim.SetValue((player_maxhp * 0.08f));
			victim.SetHeal(true);
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={549};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={2};return array[index];
		}
	}
	public class GSkill552 : GSkill
	{
		public GSkill552()
			: base(552)
		{
			
		}
	}
	public class GSkill553Stub : GSkillStub
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
		public GSkill553Stub()
			: base(553)
		{
			occupation = 22;
			maxlevel = 20;
			maxlearn = 9;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 2;
			timetype = 1;
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
			SetAction(0,"ÌìÒôËÂ_´Èº½·¨Ô¸");
			SetAction(1,"ÌìÒôËÂ_´Èº½·¨Ô¸");
			SetAction(2,"ÌìÒôËÂ_´Èº½·¨Ô¸");
			SetAction(3,"ÌìÒôËÂ_´Èº½·¨Ô¸");
			SetAction(4,"ÌìÒôËÂ_´Èº½·¨Ô¸");
			SetAction(5,"ÌìÒôËÂ_´Èº½·¨Ô¸");
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
			SetAction(18,"ÌìÒôËÂ_Æï³Ë_´Èº½·¨Ô¸");
			SetAction(19,"ÌìÒôËÂ_Æï³Ë_´Èº½·¨Ô¸");
			SetAction(20,"ÌìÒôËÂ_Æï³Ë_´Èº½·¨Ô¸");
			SetAction(21,"ÌìÒôËÂ_Æï³Ë_´Èº½·¨Ô¸");
			SetAction(22,"ÌìÒôËÂ_Æï³Ë_´Èº½·¨Ô¸");
			SetAction(23,"ÌìÒôËÂ_Æï³Ë_´Èº½·¨Ô¸");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "´Èº½·¨Ô¸";
			nativename = "´Èº½·¨Ô¸";
			icon = "´Èº½·¨Ô¸.dds";
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
		}
		public override int GetCooldowntime(GSkill skill)
		{
			return 12000;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={125,125,125,125,125,125,125,125,125};return array[level-1];
		}
		public override float GetRadius(GSkill skill)
		{
			return 20.000000f;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 20.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 18.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (195 - 5 * skill_level);
		}
		public override int GetCoverage(GSkill skill)
		{
			return 25;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();

			victim.SetTime(8100.0f);
			victim.SetRatio((skill_level * 0.02f));
			victim.SetBuffid(2);
			victim.SetIncskilldamage(true);
			victim.SetRatio(((9 * norm(zrand(125) / 100) + 266)));
			victim.SetAmount(((16 * norm(zrand(125) / 100) + 266)));
			victim.SetValue(((280 * norm(zrand(125) / 100) + 266)));
			victim.SetClearcooldown(true);
			victim.SetRatio(((286 * norm(zrand(125) / 100) + 266)));
			victim.SetAmount(((521 * norm(zrand(125) / 100) + 266)));
			victim.SetValue(266.0f);
			victim.SetClearcooldown(true);
			victim.SetProbability(120.0f);
			victim.SetTime(8100.0f);
			victim.SetRatio((skill_level * 0.05f));
			victim.SetBuffid(1);
			victim.SetIncdrugeffect(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetTime(3600000.0f);
			victim.SetAmount(21.0f);
			victim.SetHolyaura(true);
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={551};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={4};return array[index];
		}
	}
	public class GSkill553 : GSkill
	{
		public GSkill553()
			: base(553)
		{
			
		}
	}
	public class GSkill554Stub : GSkillStub
	{
		public class GState1 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 600;
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
				return 800;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				skill_level = skill.GetLevel();
				int				skill_t0 = skill.GetT0();
				int				skill_t2 = skill.GetT2();

				skill.SetCrit((skill_t2 * 0.01f));
				skill.SetRatio((skill_t2 * 0.1f + (skill_t0 * 0.05f + 1.0f)));
				skill.SetPlus(((15 * skill_level + 300) * (D2INT(skill_level * 0.05f + 0.55f) * 0.9f) + ((13 * skill_level + 280) * (D2INT(1.42f - skill_level * 0.05f) * 0.9f))));
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
				return 800;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				skill_level = skill.GetLevel();
				int				skill_t0 = skill.GetT0();
				int				skill_t2 = skill.GetT2();

				skill.SetCrit((skill_t2 * 0.01f));
				skill.SetRatio((skill_t2 * 0.1f + (skill_t0 * 0.05f + 1.0f)));
				skill.SetPlus(((15 * skill_level + 300) * (D2INT(skill_level * 0.05f + 0.55f) * 0.9f) + ((13 * skill_level + 280) * (D2INT(1.42f - skill_level * 0.05f) * 0.9f))));
				player.SetPerform(0);
			}
			public override bool Cancel(GSkill skill)
			{
				return true;
			}
		}
		public class GState4 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 800;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				skill_level = skill.GetLevel();
				int				skill_t0 = skill.GetT0();
				int				skill_t2 = skill.GetT2();

				skill.SetCrit((skill_t2 * 0.01f));
				skill.SetRatio((skill_t2 * 0.1f + (skill_t0 * 0.05f + 1.0f)));
				skill.SetPlus(((15 * skill_level + 300) * (D2INT(skill_level * 0.05f + 0.55f) * 0.9f) + ((13 * skill_level + 280) * (D2INT(1.42f - skill_level * 0.05f) * 0.9f))));
				player.SetPerform(0);
			}
		}
		public GSkill554Stub()
			: base(554)
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
			rangetype = 3;
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
			SetAction(0,"ÌìÒôËÂ_·ğÍÓ¾»ÊÀÔ¸");
			SetAction(1,"ÌìÒôËÂ_·ğÍÓ¾»ÊÀÔ¸");
			SetAction(2,"ÌìÒôËÂ_·ğÍÓ¾»ÊÀÔ¸");
			SetAction(3,"ÌìÒôËÂ_·ğÍÓ¾»ÊÀÔ¸");
			SetAction(4,"ÌìÒôËÂ_·ğÍÓ¾»ÊÀÔ¸");
			SetAction(5,"ÌìÒôËÂ_·ğÍÓ¾»ÊÀÔ¸");
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
			SetAction(18,"ÌìÒôËÂ_Æï³Ë_·ğÍÓ¾»ÊÀÔ¸");
			SetAction(19,"ÌìÒôËÂ_Æï³Ë_·ğÍÓ¾»ÊÀÔ¸");
			SetAction(20,"ÌìÒôËÂ_Æï³Ë_·ğÍÓ¾»ÊÀÔ¸");
			SetAction(21,"ÌìÒôËÂ_Æï³Ë_·ğÍÓ¾»ÊÀÔ¸");
			SetAction(22,"ÌìÒôËÂ_Æï³Ë_·ğÍÓ¾»ÊÀÔ¸");
			SetAction(23,"ÌìÒôËÂ_Æï³Ë_·ğÍÓ¾»ÊÀÔ¸");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "·ğÍÓ¾»ÊÀÔ¸";
			nativename = "·ğÍÓ¾»ÊÀÔ¸";
			icon = "·ğÍÓ¾»ÊÀÔ¸.dds";
			SetTalent(0,681);
			SetTalent(1,684);
			SetTalent(2,716);
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
			AddState(new GState3());
			AddState(new GState4());
		}
		public override int GetExecutetime(GSkill skill)
		{
			return 3000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			int				skill_t1 = skill.GetT1();

			return 8000 - 1200 * skill_t1;
		}
		public override int GetEnmity(GSkill skill)
		{
			return 1;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={125,125,125,125,125,125,125,125,125};return array[level-1];
		}
		public override float GetRadius(GSkill skill)
		{
			return 12.000000f;
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
			return 22.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (skill_level * 1.5f + (skill_level * (skill_level * 1.7f)) + 500.0f);
		}
		public override int GetCoverage(GSkill skill)
		{
			return 30;
		}
		public override float GetDropRate(GSkill skill)
		{
			return 0.500000f;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={550};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={6};return array[index];
		}
	}
	public class GSkill554 : GSkill
	{
		public GSkill554()
			: base(554)
		{
			
		}
	}
	public class GSkill555Stub : GSkillStub
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
				int				player_level = player.GetLevel();
				int				player_mp = player.GetMp();
				int				player_maxmp = player.GetMaxmp();
				int				player_def = player.GetDef();
				int				skill_level = skill.GetLevel();
				int				skill_t0 = skill.GetT0();
				int				skill_t1 = skill.GetT1();
				int				skill_t2 = skill.GetT2();

				skill.SetCrit((skill_t1 * 0.02f));
				skill.SetRatio(((skill_t0 + 1) * (D2INT((player_mp / 0.95f) / player_maxmp) * 0.12f) + (D2INT(player_level / (10 - skill_level)) * 0.01f + (skill_t0 * 0.08f + (skill_level * 0.05f + 1.0f)))));
				skill.SetPlus((player_def * (skill_t2 * 0.03f) + ((120 * skill_level))));
				player.SetPerform(1);
			}
		}
		public GSkill555Stub()
			: base(555)
		{
			occupation = 130;
			maxlevel = 5;
			maxlearn = 5;
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
			SetAction(0,"¹íµÀ_·¨±¦_çúçêÖìç±");
			SetAction(1,"ÇàÔÆÃÅ_·¨±¦_çúçêÖìç±");
			SetAction(2,"¹íÍõ×Ú_·¨±¦_çúçêÖìç±");
			SetAction(3,"ºÏ»¶ÅÉ_·¨±¦_çúçêÖìç±");
			SetAction(4,"ÌìÒôËÂ_·¨±¦_çúçêÖìç±");
			SetAction(5,"¹íµÀ_·¨±¦_çúçêÖìç±");
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
			SetAction(18,"¹íµÀ_Æï³Ë_·¨±¦_çúçêÖìç±");
			SetAction(19,"ÇàÔÆÃÅ_Æï³Ë_·¨±¦_çúçêÖìç±");
			SetAction(20,"¹íÍõ×Ú_Æï³Ë_·¨±¦_çúçêÖìç±");
			SetAction(21,"ºÏ»¶ÅÉ_Æï³Ë_·¨±¦_çúçêÖìç±");
			SetAction(22,"ÌìÒôËÂ_Æï³Ë_·¨±¦_çúçêÖìç±");
			SetAction(23,"¹íµÀ_Æï³Ë_·¨±¦_çúçêÖìç±");
			SetAction(24,"");
			SetAction(25,"");
			SetAction(26,"");
			SetAction(27,"");
			SetAction(28,"");
			SetAction(29,"");
			SetAction(30,"");
			name = "Ç§ç±Ñ¤Îè";
			nativename = "Ç§ç±Ñ¤Îè";
			icon = "Ç§ç±Ñ¤Îè.dds";
			SetTalent(0,568);
			SetTalent(1,599);
			SetTalent(2,1582);
			SetTalent(3,0);
			SetTalent(4,0);
			SetTalent(5,0);
			SetTalent(6,0);
			SetTalent(7,0);
			talent_size = 3;
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
			int				skill_level = skill.GetLevel();

			return 6300 - 300 * skill_level;
		}
		public override int GetEnmity(GSkill skill)
		{
			return 1;
		}
		public override float GetPraydistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return (D2INT((player_range / 13.0f)) * 2.8f + (D2INT(player_range / 8.9f) * 1.8f + ((player_range * 0.5f) - D2INT(player_range / 3.9f) * 0.3f)) + 0.05f + 5.0f);
		}
		public override float GetCastdistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return (D2INT((player_range / 13.0f)) * 2.8f + (D2INT(player_range / 8.9f) * 1.8f + ((player_range * 0.5f) - D2INT(player_range / 3.9f) * 0.3f)) + 0.05f);
		}
		public override float GetEffectdistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return (D2INT((player_range / 13.0f)) * 2.8f + (D2INT(player_range / 8.9f) * 1.8f + ((player_range * 0.5f) - D2INT(player_range / 3.9f) * 0.3f)) + 0.05f + 10.0f);
		}
		public override float GetMpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return ((-25 * skill_level) - skill_level * skill_level + 295);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();

			victim.SetTime(((1000 * skill_t0 + 5100)));
			victim.SetRatio((zrand(3 * skill_level + 17) / 100.0f + (skill_level * 0.01f)));
			victim.SetBuffid(1);
			victim.SetDecskilldamage(true);
			victim.SetProbability(((25 * skill_level + 100)));
			victim.SetTime(((500 * skill_t0 + 3100)));
			victim.SetWrap(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_mp = player.GetMp();
			int				player_maxmp = player.GetMaxmp();

			victim.SetBuffid((D2INT((player_mp / 0.95f) / player_maxmp)));
			victim.SetUniqprompt(true);
			return true;
		}
	}
	public class GSkill555 : GSkill
	{
		public GSkill555()
			: base(555)
		{
			
		}
	}
	public class GSkill556Stub : GSkillStub
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
				int				player_level = player.GetLevel();
				int				player_def = player.GetDef();
				int				skill_level = skill.GetLevel();
				int				skill_t0 = skill.GetT0();
				int				skill_t1 = skill.GetT1();

				skill.SetRatio((D2INT(player_level / (10 - skill_level)) * 0.01f + (skill_level * 0.05f + (D2INT((zrand(skill_level + 101)) / 100.0f) * (skill_level * 0.6f) + (skill_t0 * 0.03f) + 1.0f))));
				skill.SetPlus((player_def * (skill_t1 * 0.03f) + ((150 * skill_level))));
				player.SetPerform(1);
			}
		}
		public GSkill556Stub()
			: base(556)
		{
			occupation = 130;
			maxlevel = 5;
			maxlearn = 5;
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
			SetAction(0,"¹íµÀ_·¨±¦_ÒõÑô¾µ");
			SetAction(1,"ÇàÔÆÃÅ_·¨±¦_ÒõÑô¾µ");
			SetAction(2,"¹íÍõ×Ú_·¨±¦_ÒõÑô¾µ");
			SetAction(3,"ºÏ»¶ÅÉ_·¨±¦_ÒõÑô¾µ");
			SetAction(4,"ÌìÒôËÂ_·¨±¦_ÒõÑô¾µ");
			SetAction(5,"¹íµÀ_·¨±¦_ÒõÑô¾µ");
			SetAction(6,"·ÙÏã¹È_·¨±¦_ÒõÑô¾µ");
			SetAction(7,"ÊŞÉñ_·¨±¦_ÒõÑô¾µ");
			SetAction(8,"ºüÑı_·¨±¦_ÒõÑô¾µ");
			SetAction(9,"ĞùÔ¯_·¨±¦_ÒõÑô¾µ");
			SetAction(10,"»³¹â_·¨±¦_ÒõÑô¾µ");
			SetAction(11,"Ì«ê»_·¨±¦_ÒõÑô¾µ");
			SetAction(12,"Ìì»ª_·¨±¦_ÒõÑô¾µ");
			SetAction(13,"ÁéÙí_·¨±¦_ÒõÑô¾µ");
			SetAction(14,"Ó¢ÕĞ_·¨±¦_ÒõÑô¾µ");
			SetAction(15,"ÎäÆ÷´óÊ¦_·¨±¦_ÒõÑô¾µ");
			SetAction(16,"ÎäÆ÷´óÊ¦_·¨±¦_ÒõÑô¾µ");
			SetAction(17,"ÌìÒôËÂ_·¨±¦_ÒõÑô¾µ");
			SetAction(18,"¹íµÀ_Æï³Ë_·¨±¦_ÒõÑô¾µ");
			SetAction(19,"ÇàÔÆÃÅ_Æï³Ë_·¨±¦_ÒõÑô¾µ");
			SetAction(20,"¹íÍõ×Ú_Æï³Ë_·¨±¦_ÒõÑô¾µ");
			SetAction(21,"ºÏ»¶ÅÉ_Æï³Ë_·¨±¦_ÒõÑô¾µ");
			SetAction(22,"ÌìÒôËÂ_Æï³Ë_·¨±¦_ÒõÑô¾µ");
			SetAction(23,"¹íµÀ_Æï³Ë_·¨±¦_ÒõÑô¾µ");
			SetAction(24,"·ÙÏã¹È_Æï³Ë_·¨±¦_ÒõÑô¾µ");
			SetAction(25,"ÊŞÉñ_Æï³Ë_·¨±¦_ÒõÑô¾µ");
			SetAction(26,"ºüÑı_Æï³Ë_·¨±¦_ÒõÑô¾µ");
			SetAction(27,"ĞùÔ¯_Æï³Ë_·¨±¦_ÒõÑô¾µ");
			SetAction(28,"»³¹â_Æï³Ë_·¨±¦_ÒõÑô¾µ");
			SetAction(29,"Ì«ê»_Æï³Ë_·¨±¦_ÒõÑô¾µ");
			SetAction(30,"Ìì»ª_Æï³Ë_·¨±¦_ÒõÑô¾µ");
			name = "ÒõÑôÏàÉú";
			nativename = "ÒõÑôÏàÉú";
			icon = "ÒõÑôÏàÉú.dds";
			SetTalent(0,687);
			SetTalent(1,1582);
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
			int				skill_level = skill.GetLevel();

			return 6300 - 300 * skill_level;
		}
		public override int GetEnmity(GSkill skill)
		{
			return 1;
		}
		public override float GetPraydistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return (D2INT((player_range / 13.0f)) * 2.8f + (D2INT(player_range / 8.9f) * 1.8f + ((player_range * 0.5f) - D2INT(player_range / 3.9f) * 0.3f)) + 0.05f + 5.0f);
		}
		public override float GetCastdistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return (D2INT((player_range / 13.0f)) * 2.8f + (D2INT(player_range / 8.9f) * 1.8f + ((player_range * 0.5f) - D2INT(player_range / 3.9f) * 0.3f)) + 0.05f);
		}
		public override float GetEffectdistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return (D2INT((player_range / 13.0f)) * 2.8f + (D2INT(player_range / 8.9f) * 1.8f + ((player_range * 0.5f) - D2INT(player_range / 3.9f) * 0.3f)) + 0.05f + 10.0f);
		}
		public override float GetMpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return ((-25 * skill_level) - skill_level * skill_level + 295);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_maxhp = player.GetMaxhp();
			int				skill_level = skill.GetLevel();

			victim.SetProbability(((10 * skill_level + 15)));
			victim.SetTime(((3000 * skill_level + 100)));
			victim.SetBuffid(1);
			victim.SetAmount((player_maxhp * 0.15f));
			victim.SetValue(((250 * skill_level)));
			victim.SetSubhp(true);
			victim.SetProbability(((600 * norm(zrand(100) / (98 - skill_level)))));
			victim.SetTime(((5000 * skill_level + 100)));
			victim.SetDizzy(true);
			victim.SetProbability(-1.0f);
			victim.SetTime(((7000 * skill_level + 100)));
			victim.SetRatio((skill_level * 0.03f));
			victim.SetBuffid(4);
			victim.SetWeak(true);
			return true;
		}
	}
	public class GSkill556 : GSkill
	{
		public GSkill556()
			: base(556)
		{
			
		}
	}
	public class GSkill557Stub : GSkillStub
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
				int				player_level = player.GetLevel();
				int				player_def = player.GetDef();
				int				skill_level = skill.GetLevel();
				int				skill_t0 = skill.GetT0();
				int				skill_t1 = skill.GetT1();

				skill.SetRatio((D2INT(player_level / (9 - skill_level)) * 0.01f + (skill_level * 0.06f + (skill_t0 * 0.03f + 1.0f))));
				skill.SetPlus((player_def * (skill_t1 * 0.03f) + ((215 * skill_level))));
				player.SetPerform(1);
			}
		}
		public GSkill557Stub()
			: base(557)
		{
			occupation = 130;
			maxlevel = 5;
			maxlearn = 5;
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
			SetAction(0,"¹íµÀ_·¨±¦_ó´Áúá¦");
			SetAction(1,"ÇàÔÆÃÅ_·¨±¦_ó´Áúá¦");
			SetAction(2,"¹íÍõ×Ú_·¨±¦_ó´Áúá¦");
			SetAction(3,"ºÏ»¶ÅÉ_·¨±¦_ó´Áúá¦");
			SetAction(4,"ÌìÒôËÂ_·¨±¦_ó´Áúá¦");
			SetAction(5,"¹íµÀ_·¨±¦_ó´Áúá¦");
			SetAction(6,"·ÙÏã¹È_·¨±¦_ó´Áúá¦");
			SetAction(7,"ÊŞÉñ_·¨±¦_ó´Áúá¦");
			SetAction(8,"ºüÑı_·¨±¦_ó´Áúá¦");
			SetAction(9,"ĞùÔ¯_·¨±¦_ó´Áúá¦");
			SetAction(10,"»³¹â_·¨±¦_ó´Áúá¦");
			SetAction(11,"Ì«ê»_·¨±¦_ó´Áúá¦");
			SetAction(12,"Ìì»ª_·¨±¦_ó´Áúá¦");
			SetAction(13,"ÁéÙí_·¨±¦_ó´Áúá¦");
			SetAction(14,"Ó¢ÕĞ_·¨±¦_ó´Áúá¦");
			SetAction(15,"ÎäÆ÷´óÊ¦_·¨±¦_ó´Áúá¦");
			SetAction(16,"ÎäÆ÷´óÊ¦_·¨±¦_ó´Áúá¦");
			SetAction(17,"ÌìÒôËÂ_·¨±¦_ó´Áúá¦");
			SetAction(18,"¹íµÀ_Æï³Ë_·¨±¦_ó´Áúá¦");
			SetAction(19,"ÇàÔÆÃÅ_Æï³Ë_·¨±¦_ó´Áúá¦");
			SetAction(20,"¹íÍõ×Ú_Æï³Ë_·¨±¦_ó´Áúá¦");
			SetAction(21,"ºÏ»¶ÅÉ_Æï³Ë_·¨±¦_ó´Áúá¦");
			SetAction(22,"ÌìÒôËÂ_Æï³Ë_·¨±¦_ó´Áúá¦");
			SetAction(23,"¹íµÀ_Æï³Ë_·¨±¦_ó´Áúá¦");
			SetAction(24,"·ÙÏã¹È_Æï³Ë_·¨±¦_ó´Áúá¦");
			SetAction(25,"ÊŞÉñ_Æï³Ë_·¨±¦_ó´Áúá¦");
			SetAction(26,"ºüÑı_Æï³Ë_·¨±¦_ó´Áúá¦");
			SetAction(27,"ĞùÔ¯_Æï³Ë_·¨±¦_ó´Áúá¦");
			SetAction(28,"»³¹â_Æï³Ë_·¨±¦_ó´Áúá¦");
			SetAction(29,"Ì«ê»_Æï³Ë_·¨±¦_ó´Áúá¦");
			SetAction(30,"Ìì»ª_Æï³Ë_·¨±¦_ó´Áúá¦");
			name = "ò°ÁúÁÒÑ×";
			nativename = "ò°ÁúÁÒÑ×";
			icon = "ò°ÁúÁÒÑ×.dds";
			SetTalent(0,687);
			SetTalent(1,1582);
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
			int				skill_level = skill.GetLevel();

			return 6300 - 300 * skill_level;
		}
		public override int GetEnmity(GSkill skill)
		{
			return 1;
		}
		public override float GetPraydistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return (D2INT((player_range / 13.0f)) * 2.8f + (D2INT(player_range / 8.9f) * 1.8f + ((player_range * 0.5f) - D2INT(player_range / 3.9f) * 0.3f)) + 0.05f + 5.0f);
		}
		public override float GetCastdistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return (D2INT((player_range / 13.0f)) * 2.8f + (D2INT(player_range / 8.9f) * 1.8f + ((player_range * 0.5f) - D2INT(player_range / 3.9f) * 0.3f)) + 0.05f);
		}
		public override float GetEffectdistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return (D2INT((player_range / 13.0f)) * 2.8f + (D2INT(player_range / 8.9f) * 1.8f + ((player_range * 0.5f) - D2INT(player_range / 3.9f) * 0.3f)) + 0.05f + 10.0f);
		}
		public override float GetMpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return ((-35 * skill_level) - skill_level * skill_level + 445);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_level = player.GetLevel();
			int				skill_level = skill.GetLevel();

			victim.SetProbability(((1.0f - player_level * 0.002f) * 100.0f));
			victim.SetTime(12000.0f);
			victim.SetBuffid(1);
			victim.SetAmount((((skill_level * 0.4f + 0.8f) * (D2INT((zrand(5 * skill_level + 100)) / 100)) + 1.0f) * ((420 * skill_level))));
			victim.SetValue(0.0f);
			victim.SetHpleak(true);
			victim.SetProbability(((600 * norm(zrand(100) / (100 - 4 * skill_level)))));
			victim.SetTime(((1000 * skill_level + 2100)));
			victim.SetDizzy(true);
			return true;
		}
	}
	public class GSkill557 : GSkill
	{
		public GSkill557()
			: base(557)
		{
			
		}
	}
	public class GSkill558Stub : GSkillStub
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
				int				player_level = player.GetLevel();
				int				player_def = player.GetDef();
				int				skill_level = skill.GetLevel();
				int				skill_t0 = skill.GetT0();
				int				skill_t1 = skill.GetT1();

				skill.SetCrit((skill_level * 0.02f + 0.01f));
				skill.SetRatio((D2INT(player_level / (10 - skill_level)) * 0.01f + (skill_level * 0.05f + (skill_t0 * 0.03f + 1.0f))));
				skill.SetPlus((player_def * (skill_t1 * 0.03f) + ((150 * skill_level))));
				player.SetPerform(1);
			}
		}
		public GSkill558Stub()
			: base(558)
		{
			occupation = 130;
			maxlevel = 5;
			maxlearn = 5;
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
			SetAction(0,"¹íµÀ_·¨±¦_½ğºùÂ«");
			SetAction(1,"ÇàÔÆÃÅ_·¨±¦_½ğºùÂ«");
			SetAction(2,"¹íÍõ×Ú_·¨±¦_½ğºùÂ«");
			SetAction(3,"ºÏ»¶ÅÉ_·¨±¦_½ğºùÂ«");
			SetAction(4,"ÌìÒôËÂ_·¨±¦_½ğºùÂ«");
			SetAction(5,"¹íµÀ_·¨±¦_½ğºùÂ«");
			SetAction(6,"·ÙÏã¹È_·¨±¦_½ğºùÂ«");
			SetAction(7,"ÊŞÉñ_·¨±¦_½ğºùÂ«");
			SetAction(8,"ºüÑı_·¨±¦_½ğºùÂ«");
			SetAction(9,"ĞùÔ¯_·¨±¦_½ğºùÂ«");
			SetAction(10,"»³¹â_·¨±¦_½ğºùÂ«");
			SetAction(11,"Ì«ê»_·¨±¦_½ğºùÂ«");
			SetAction(12,"Ìì»ª_·¨±¦_½ğºùÂ«");
			SetAction(13,"ÁéÙí_·¨±¦_½ğºùÂ«");
			SetAction(14,"Ó¢ÕĞ_·¨±¦_½ğºùÂ«");
			SetAction(15,"ÎäÆ÷´óÊ¦_·¨±¦_½ğºùÂ«");
			SetAction(16,"ÎäÆ÷´óÊ¦_·¨±¦_½ğºùÂ«");
			SetAction(17,"ÌìÒôËÂ_·¨±¦_½ğºùÂ«");
			SetAction(18,"¹íµÀ_Æï³Ë_·¨±¦_½ğºùÂ«");
			SetAction(19,"ÇàÔÆÃÅ_Æï³Ë_·¨±¦_½ğºùÂ«");
			SetAction(20,"¹íÍõ×Ú_Æï³Ë_·¨±¦_½ğºùÂ«");
			SetAction(21,"ºÏ»¶ÅÉ_Æï³Ë_·¨±¦_½ğºùÂ«");
			SetAction(22,"ÌìÒôËÂ_Æï³Ë_·¨±¦_½ğºùÂ«");
			SetAction(23,"¹íµÀ_Æï³Ë_·¨±¦_½ğºùÂ«");
			SetAction(24,"·ÙÏã¹È_Æï³Ë_·¨±¦_½ğºùÂ«");
			SetAction(25,"ÊŞÉñ_Æï³Ë_·¨±¦_½ğºùÂ«");
			SetAction(26,"ºüÑı_Æï³Ë_·¨±¦_½ğºùÂ«");
			SetAction(27,"ĞùÔ¯_Æï³Ë_·¨±¦_½ğºùÂ«");
			SetAction(28,"»³¹â_Æï³Ë_·¨±¦_½ğºùÂ«");
			SetAction(29,"Ì«ê»_Æï³Ë_·¨±¦_½ğºùÂ«");
			SetAction(30,"Ìì»ª_Æï³Ë_·¨±¦_½ğºùÂ«");
			name = "·½´çÇ¬À¤";
			nativename = "·½´çÇ¬À¤";
			icon = "·½´çÇ¬À¤.dds";
			SetTalent(0,687);
			SetTalent(1,1582);
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
			int				skill_level = skill.GetLevel();

			return 6300 - 300 * skill_level;
		}
		public override int GetEnmity(GSkill skill)
		{
			return 1;
		}
		public override float GetPraydistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return (D2INT((player_range / 13.0f)) * 2.8f + (D2INT(player_range / 8.9f) * 1.8f + ((player_range * 0.5f) - D2INT(player_range / 3.9f) * 0.3f)) + 0.05f + 5.0f);
		}
		public override float GetCastdistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return (D2INT((player_range / 13.0f)) * 2.8f + (D2INT(player_range / 8.9f) * 1.8f + ((player_range * 0.5f) - D2INT(player_range / 3.9f) * 0.3f)) + 0.05f);
		}
		public override float GetEffectdistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return (D2INT((player_range / 13.0f)) * 2.8f + (D2INT(player_range / 8.9f) * 1.8f + ((player_range * 0.5f) - D2INT(player_range / 3.9f) * 0.3f)) + 0.05f + 10.0f);
		}
		public override float GetMpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return ((-25 * skill_level) - skill_level * skill_level + 295);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_level = player.GetLevel();
			int				skill_level = skill.GetLevel();

			victim.SetProbability(((1.0f - player_level * 0.002f) * ((12 * skill_level))));
			victim.SetTime(((2000 * skill_level + 4100)));
			victim.SetBarehanded(true);
			victim.SetProbability(-1.0f);
			victim.SetRatio((skill_level * 0.1f));
			victim.SetDrainmagic(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_mp = player.GetMp();
			int				skill_level = skill.GetLevel();

			victim.SetProbability(((2 * skill_level + 3)));
			victim.SetRatio(0.0f);
			victim.SetValue((player_mp * (skill_level * 0.05f)));
			victim.SetHeal(true);
			return true;
		}
	}
	public class GSkill558 : GSkill
	{
		public GSkill558()
			: base(558)
		{
			
		}
	}
	public class GSkill559Stub : GSkillStub
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
				int				player_level = player.GetLevel();
				int				player_def = player.GetDef();
				int				skill_level = skill.GetLevel();
				int				skill_t0 = skill.GetT0();
				int				skill_t1 = skill.GetT1();

				skill.SetRatio((D2INT(player_level / (10 - skill_level)) * 0.01f + (skill_level * 0.05f + (skill_t0 * 0.1f + 1.0f))));
				skill.SetPlus((player_def * (skill_t1 * 0.03f) + ((120 * skill_level))));
				player.SetPerform(1);
			}
		}
		public GSkill559Stub()
			: base(559)
		{
			occupation = 130;
			maxlevel = 5;
			maxlearn = 5;
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
			SetAction(0,"¹íÍõ×Ú_·¨±¦_Á«»¨");
			SetAction(1,"ÇàÔÆÃÅ_·¨±¦_Á«»¨");
			SetAction(2,"¹íÍõ×Ú_·¨±¦_Á«»¨");
			SetAction(3,"ºÏ»¶ÅÉ_·¨±¦_Á«»¨");
			SetAction(4,"ÌìÒôËÂ_·¨±¦_Á«»¨");
			SetAction(5,"¹íµÀ_·¨±¦_Á«»¨");
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
			SetAction(18,"¹íÍõ×Ú_Æï³Ë_·¨±¦_Á«»¨");
			SetAction(19,"ÇàÔÆÃÅ_Æï³Ë_·¨±¦_Á«»¨");
			SetAction(20,"¹íÍõ×Ú_Æï³Ë_·¨±¦_Á«»¨");
			SetAction(21,"ºÏ»¶ÅÉ_Æï³Ë_·¨±¦_Á«»¨");
			SetAction(22,"ÌìÒôËÂ_Æï³Ë_·¨±¦_Á«»¨");
			SetAction(23,"¹íµÀ_·¨±¦_Á«»¨");
			SetAction(24,"");
			SetAction(25,"");
			SetAction(26,"");
			SetAction(27,"");
			SetAction(28,"");
			SetAction(29,"");
			SetAction(30,"");
			name = "°µÏãÎŞ¼Ê";
			nativename = "°µÏãÎŞ¼Ê";
			icon = "°µÏãÎŞ¼Ê.dds";
			SetTalent(0,721);
			SetTalent(1,1582);
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
			int				skill_level = skill.GetLevel();

			return 6300 - 300 * skill_level;
		}
		public override int GetEnmity(GSkill skill)
		{
			return 1;
		}
		public override float GetPraydistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return (D2INT((player_range / 13.0f)) * 2.8f + (D2INT(player_range / 8.9f) * 1.8f + ((player_range * 0.5f) - D2INT(player_range / 3.9f) * 0.3f)) + 0.05f + 5.0f);
		}
		public override float GetCastdistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return (D2INT((player_range / 13.0f)) * 2.8f + (D2INT(player_range / 8.9f) * 1.8f + ((player_range * 0.5f) - D2INT(player_range / 3.9f) * 0.3f)) + 0.05f);
		}
		public override float GetEffectdistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return (D2INT((player_range / 13.0f)) * 2.8f + (D2INT(player_range / 8.9f) * 1.8f + ((player_range * 0.5f) - D2INT(player_range / 3.9f) * 0.3f)) + 0.05f + 10.0f);
		}
		public override float GetMpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return ((-25 * skill_level) - skill_level * skill_level + 295);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_level = player.GetLevel();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();

			victim.SetProbability(((35 * skill_level + 85)));
			victim.SetTime(((2000 * skill_level + 4100)));
			victim.SetValue(0.0f);
			victim.SetSleep(true);
			victim.SetProbability(((1.0f - player_level * 0.002f) * 50.0f));
			victim.SetRatio((skill_t0 * 0.09f + 0.36f));
			victim.SetXiaoxin(true);
			victim.SetProbability(100.0f);
			victim.SetTime(12000.0f);
			victim.SetBuffid(1);
			victim.SetAmount(((36 * skill_t0 + (48 * skill_level))));
			victim.SetCycsubdefence(true);
			return true;
		}
	}
	public class GSkill559 : GSkill
	{
		public GSkill559()
			: base(559)
		{
			
		}
	}
}
