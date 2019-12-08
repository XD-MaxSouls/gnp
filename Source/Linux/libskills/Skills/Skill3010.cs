using System;
using System.Text;

namespace SKILL
{
	public class GSkill3010Stub : GSkillStub
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
				return 400;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();

				player.SetPerform(1);
			}
		}
		public GSkill3010Stub()
			: base(3010)
		{
			occupation = 167;
			maxlevel = 20;
			maxlearn = 20;
			eventflag = 0;
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
			credittype = 0;
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
			SetAction(0,"ÏÉ_±ù±¬");
			SetAction(1,"ÏÉ_±ù±¬");
			SetAction(2,"ÏÉ_±ù±¬");
			SetAction(3,"ÏÉ_±ù±¬");
			SetAction(4,"ÏÉ_±ù±¬");
			SetAction(5,"ÏÉ_±ù±¬");
			SetAction(6,"ÏÉ_±ù±¬");
			SetAction(7,"ÏÉ_±ù±¬");
			SetAction(8,"ÏÉ_±ù±¬");
			SetAction(9,"ÏÉ_±ù±¬");
			SetAction(10,"ÏÉ_±ù±¬");
			SetAction(11,"ÏÉ_±ù±¬");
			SetAction(12,"ÏÉ_±ù±¬");
			SetAction(13,"ÏÉ_±ù±¬");
			SetAction(14,"ÏÉ_±ù±¬");
			SetAction(15,"ÏÉ_±ù±¬");
			SetAction(16,"ÏÉ_±ù±¬");
			SetAction(17,"ÏÉ_±ù±¬");
			SetAction(18,"Æï³Ë_ÏÉ_±ù±¬");
			SetAction(19,"Æï³Ë_ÏÉ_±ù±¬");
			SetAction(20,"Æï³Ë_ÏÉ_±ù±¬");
			SetAction(21,"Æï³Ë_ÏÉ_±ù±¬");
			SetAction(22,"Æï³Ë_ÏÉ_±ù±¬");
			SetAction(23,"Æï³Ë_ÏÉ_±ù±¬");
			SetAction(24,"Æï³Ë_ÏÉ_±ù±¬");
			SetAction(25,"Æï³Ë_ÏÉ_±ù±¬");
			SetAction(26,"Æï³Ë_ÏÉ_±ù±¬");
			SetAction(27,"Æï³Ë_ÏÉ_±ù±¬");
			SetAction(28,"Æï³Ë_ÏÉ_±ù±¬");
			SetAction(29,"Æï³Ë_ÏÉ_±ù±¬");
			SetAction(30,"Æï³Ë_ÏÉ_±ù±¬");
			name = "±±Ú¤Ó¡";
			nativename = "±±Ú¤Ó¡";
			icon = "±ù·âÊõ.dds";
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
			int				skill_level = skill.GetLevel();

			return 180000 - 4000 * skill_level;
		}
		public override int GetEnmity(GSkill skill)
		{
			return 1;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={120,122,124,126,128,130,131,132,133,134,135,136,137,138,139,141,143,145,147,149};return array[level-1];
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 12.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 8.700000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 15.000000f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_maxhp = player.GetMaxhp();
			int				skill_level = skill.GetLevel();

			/*
			if ( player.GetIsfrozen() )
			d = 120.0f;
			else
			victim.SetProbability(0.0f);
			victim.SetTime(((2000 * norm(skill_level / 19.9f) + (200 * skill_level) + 2050)));
			victim.SetRatio(0.0f);
			victim.SetBuffid(1);
			victim.SetValue(((-20 - 4 * skill_level)));
			victim.SetDivinityburst(true);
			victim.SetProbability(120.0f);
			victim.SetTime(((2000 * norm(skill_level / 19.9f) + (200 * skill_level) + 2050)));
			victim.SetBuffid(4);
			victim.SetAmount(1000.0f);
			victim.SetValue((skill_level * (player_maxhp * 0.01f)));
			victim.SetSubhp(true);
			victim.SetProbability(120.0f);
			victim.SetTime(((2000 * norm(skill_level / 19.9f) + (200 * skill_level) + 2050)));
			victim.SetRatio((skill_level * 0.02f));
			victim.SetBuffid(1);
			victim.SetDecdrugeffect(true);
			if ( player.GetIsfrozen() )
			v45 = (2 * skill_level + 35);
			else
			victim.SetProbability(((2 * skill_level + 10)));
			victim.SetTime(((2000 * norm(skill_level / 19.9f) + (200 * skill_level) + 2050)));
			victim.SetRatio(0.0f);
			victim.SetBuffid(2);
			victim.SetFrozen(true);
			*/
			return true;
		}
		public override int GetDivinityExp(int level)
		{
			int[] array={400,500,500,700,1500,2400,3500,5600,8500,8600,19000,26500,49100,57600,85800,140300,241000,410600,614500,1344300};return array[level-1];
		}
		public override int GetDivinityLevel(int level)
		{
			int[] array={2,4,6,8,10,12,15,18,21,24,28,33,38,43,48,54,60,66,72,78};return array[level-1];
		}
		public override int GetDpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return 3 * skill_level * skill_level + (30 * skill_level) + 180;
		}
	}
	public class GSkill3010 : GSkill
	{
		public GSkill3010()
			: base(3010)
		{
			
		}
	}
	public class GSkill3011Stub : GSkillStub
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
		public GSkill3011Stub()
			: base(3011)
		{
			occupation = 167;
			maxlevel = 20;
			maxlearn = 20;
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
			clearmask = 1;
			skill_limit = 6;
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
			SetAction(0,"ÏÉ_ÉñÊ¥±¬·¢");
			SetAction(1,"ÏÉ_ÉñÊ¥±¬·¢");
			SetAction(2,"ÏÉ_ÉñÊ¥±¬·¢");
			SetAction(3,"ÏÉ_ÉñÊ¥±¬·¢");
			SetAction(4,"ÏÉ_ÉñÊ¥±¬·¢");
			SetAction(5,"ÏÉ_ÉñÊ¥±¬·¢");
			SetAction(6,"ÏÉ_ÉñÊ¥±¬·¢");
			SetAction(7,"ÏÉ_ÉñÊ¥±¬·¢");
			SetAction(8,"ÏÉ_ÉñÊ¥±¬·¢");
			SetAction(9,"ÏÉ_ÉñÊ¥±¬·¢");
			SetAction(10,"ÏÉ_ÉñÊ¥±¬·¢");
			SetAction(11,"ÏÉ_ÉñÊ¥±¬·¢");
			SetAction(12,"ÏÉ_ÉñÊ¥±¬·¢");
			SetAction(13,"ÏÉ_ÉñÊ¥±¬·¢");
			SetAction(14,"ÏÉ_ÉñÊ¥±¬·¢");
			SetAction(15,"ÏÉ_ÉñÊ¥±¬·¢");
			SetAction(16,"ÏÉ_ÉñÊ¥±¬·¢");
			SetAction(17,"ÏÉ_ÉñÊ¥±¬·¢");
			SetAction(18,"Æï³Ë_ÏÉ_ÉñÊ¥±¬·¢");
			SetAction(19,"Æï³Ë_ÏÉ_ÉñÊ¥±¬·¢");
			SetAction(20,"Æï³Ë_ÏÉ_ÉñÊ¥±¬·¢");
			SetAction(21,"Æï³Ë_ÏÉ_ÉñÊ¥±¬·¢");
			SetAction(22,"Æï³Ë_ÏÉ_ÉñÊ¥±¬·¢");
			SetAction(23,"Æï³Ë_ÏÉ_ÉñÊ¥±¬·¢");
			SetAction(24,"Æï³Ë_ÏÉ_ÉñÊ¥±¬·¢");
			SetAction(25,"Æï³Ë_ÏÉ_ÉñÊ¥±¬·¢");
			SetAction(26,"Æï³Ë_ÏÉ_ÉñÊ¥±¬·¢");
			SetAction(27,"Æï³Ë_ÏÉ_ÉñÊ¥±¬·¢");
			SetAction(28,"Æï³Ë_ÏÉ_ÉñÊ¥±¬·¢");
			SetAction(29,"Æï³Ë_ÏÉ_ÉñÊ¥±¬·¢");
			SetAction(30,"Æï³Ë_ÏÉ_ÉñÊ¥±¬·¢");
			name = "¾ªºèÃÎ";
			nativename = "¾ªºèÃÎ";
			icon = "Ê±¹âµ¹Á÷.dds";
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
			int				skill_level = skill.GetLevel();

			return 120000 - 4000 * skill_level;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={120,122,124,126,128,130,131,132,133,134,135,136,137,138,139,141,143,145,147,149};return array[level-1];
		}
		public override float GetRadius(GSkill skill)
		{
			return 15.000000f;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 14.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 12.000000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 18.000000f;
		}
		public override int GetCoverage(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return D2INT(skill_level / 4.9f) + 1;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();

			victim.SetProbability(((4 * skill_level + 20)));
			victim.SetTime(6050.0f);
			victim.SetGoback(true);
			victim.SetProbability(((4 * skill_level + 20)));
			victim.SetTime(((4000 * norm(skill_level / 19.9f) + 8050)));
			victim.SetAmount(4.0f);
			victim.SetValue(2.0f);
			victim.SetSilenttimer(true);
			return true;
		}
		public override int GetDivinityExp(int level)
		{
			int[] array={200,500,500,600,900,1900,3200,4500,8600,10800,20700,32200,51000,65200,84800,159900,360100,427500,743600,1450600};return array[level-1];
		}
		public override int GetDivinityLevel(int level)
		{
			int[] array={1,3,5,7,9,11,14,17,21,25,29,34,39,44,49,55,61,67,73,79};return array[level-1];
		}
		public override int GetDpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return 4 * skill_level * skill_level + (50 * skill_level) + 190;
		}
	}
	public class GSkill3011 : GSkill
	{
		public GSkill3011()
			: base(3011)
		{
			
		}
	}
	public class GSkill3012Stub : GSkillStub
	{
		public class GState1 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 1400;
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

				skill.SetRatio(0.0f);
				skill.SetSaint((int)((skill_level * 0.3f + 1.0f) * player.GetSaint()));
				player.SetPerform(1);
			}
		}
		public GSkill3012Stub()
			: base(3012)
		{
			occupation = 167;
			maxlevel = 20;
			maxlearn = 20;
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
			SetAction(0,"ÏÉ_±ù·âÊõ");
			SetAction(1,"ÏÉ_±ù·âÊõ");
			SetAction(2,"ÏÉ_±ù·âÊõ");
			SetAction(3,"ÏÉ_±ù·âÊõ");
			SetAction(4,"ÏÉ_±ù·âÊõ");
			SetAction(5,"ÏÉ_±ù·âÊõ");
			SetAction(6,"ÏÉ_±ù·âÊõ");
			SetAction(7,"ÏÉ_±ù·âÊõ");
			SetAction(8,"ÏÉ_±ù·âÊõ");
			SetAction(9,"ÏÉ_±ù·âÊõ");
			SetAction(10,"ÏÉ_±ù·âÊõ");
			SetAction(11,"ÏÉ_±ù·âÊõ");
			SetAction(12,"ÏÉ_±ù·âÊõ");
			SetAction(13,"ÏÉ_±ù·âÊõ");
			SetAction(14,"ÏÉ_±ù·âÊõ");
			SetAction(15,"ÏÉ_±ù·âÊõ");
			SetAction(16,"ÏÉ_±ù·âÊõ");
			SetAction(17,"ÏÉ_±ù·âÊõ");
			SetAction(18,"Æï³Ë_ÏÉ_±ù·âÊõ");
			SetAction(19,"Æï³Ë_ÏÉ_±ù·âÊõ");
			SetAction(20,"Æï³Ë_ÏÉ_±ù·âÊõ");
			SetAction(21,"Æï³Ë_ÏÉ_±ù·âÊõ");
			SetAction(22,"Æï³Ë_ÏÉ_±ù·âÊõ");
			SetAction(23,"Æï³Ë_ÏÉ_±ù·âÊõ");
			SetAction(24,"Æï³Ë_ÏÉ_±ù·âÊõ");
			SetAction(25,"Æï³Ë_ÏÉ_±ù·âÊõ");
			SetAction(26,"Æï³Ë_ÏÉ_±ù·âÊõ");
			SetAction(27,"Æï³Ë_ÏÉ_±ù·âÊõ");
			SetAction(28,"Æï³Ë_ÏÉ_±ù·âÊõ");
			SetAction(29,"Æï³Ë_ÏÉ_±ù·âÊõ");
			SetAction(30,"Æï³Ë_ÏÉ_±ù·âÊõ");
			name = "´ºÀ×Õğ";
			nativename = "´ºÀ×Õğ";
			icon = "±ù±©.dds";
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
			int				skill_level = skill.GetLevel();

			return 180000 - 4000 * skill_level;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={120,122,124,126,128,130,131,132,133,134,135,136,137,138,139,141,143,145,147,149};return array[level-1];
		}
		public override float GetRadius(GSkill skill)
		{
			return 20.000000f;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 17.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 15.000000f;
		}
		public override int GetCoverage(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return skill_level + 5;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_mp = player.GetMp();
			int				skill_level = skill.GetLevel();

			/*
			if ( player.GetIsfrozen() )
			d = 120.0f;
			else
			victim.SetProbability(0.0f);
			victim.SetValue((player_mp * 0.2f));
			victim.SetDirecthurt(true);
			victim.SetProbability(((4 * skill_level + 10)));
			if ( player.GetIsfrozen() )
			t = 4000.0f;
			else
			victim.SetTime(0.0f);
			victim.SetRatio(0.0f);
			victim.SetBuffid(1);
			victim.SetFrozen(true);
			*/
			return true;
		}
		public override int GetDivinityExp(int level)
		{
			int[] array={200,500,500,600,900,2400,3500,5600,8000,9100,21700,36400,51500,77500,79800,179300,290600,437200,872700,1620700};return array[level-1];
		}
		public override int GetDivinityLevel(int level)
		{
			int[] array={1,3,5,7,9,12,15,18,22,26,30,35,40,45,50,56,62,68,74,80};return array[level-1];
		}
		public override int GetDpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return 4 * skill_level * skill_level + (50 * skill_level) + 190;
		}
	}
	public class GSkill3012 : GSkill
	{
		public GSkill3012()
			: base(3012)
		{
			
		}
	}
	public class GSkill3013Stub : GSkillStub
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
		public GSkill3013Stub()
			: base(3013)
		{
			occupation = 167;
			maxlevel = 20;
			maxlearn = 20;
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
			credittype = 0;
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
			SetAction(0,"ÇàÔÆÃÅ_¹éÀ´È¥");
			SetAction(1,"ÇàÔÆÃÅ_¹éÀ´È¥");
			SetAction(2,"¹íÍõ×Ú_¹éÀ´È¥");
			SetAction(3,"ºÏ»¶ÅÉ_¹éÀ´È¥");
			SetAction(4,"ÌìÒôËÂ_¹éÀ´È¥");
			SetAction(5,"¹íµÀ_¹éÀ´È¥");
			SetAction(6,"·ÙÏã¹È_¹éÀ´È¥");
			SetAction(7,"ÊŞÉñ_¹éÀ´È¥");
			SetAction(8,"ºüÑı_¹éÀ´È¥");
			SetAction(9,"ĞùÔ¯_¹éÀ´È¥");
			SetAction(10,"»³¹â_¹éÀ´È¥");
			SetAction(11,"Ì«ê»_¹éÀ´È¥");
			SetAction(12,"Ìì»ª_¹éÀ´È¥");
			SetAction(13,"ÁéÙí_¹éÀ´È¥");
			SetAction(14,"Ó¢ÕĞ_¹éÀ´È¥");
			SetAction(15,"ÎäÆ÷´óÊ¦_¹éÀ´È¥");
			SetAction(16,"ÎäÆ÷´óÊ¦_¹éÀ´È¥");
			SetAction(17,"ÌìÒôËÂ_¹éÀ´È¥");
			SetAction(18,"ÇàÔÆÃÅ_Æï³Ë_¹éÀ´È¥");
			SetAction(19,"ÇàÔÆÃÅ_Æï³Ë_¹éÀ´È¥");
			SetAction(20,"¹íÍõ×Ú_Æï³Ë_¹éÀ´È¥");
			SetAction(21,"ºÏ»¶ÅÉ_Æï³Ë_¹éÀ´È¥");
			SetAction(22,"ÌìÒôËÂ_Æï³Ë_¹éÀ´È¥");
			SetAction(23,"¹íµÀ_Æï³Ë_¹éÀ´È¥");
			SetAction(24,"·ÙÏã¹È_Æï³Ë_¹éÀ´È¥");
			SetAction(25,"ÊŞÉñ_Æï³Ë_¹éÀ´È¥");
			SetAction(26,"ºüÑı_Æï³Ë_¹éÀ´È¥");
			SetAction(27,"ĞùÔ¯_Æï³Ë_¹éÀ´È¥");
			SetAction(28,"»³¹â_Æï³Ë_¹éÀ´È¥");
			SetAction(29,"Ì«ê»_Æï³Ë_¹éÀ´È¥");
			SetAction(30,"Ìì»ª_Æï³Ë_¹éÀ´È¥");
			name = "¹éÈ¥À´<Ğş>";
			nativename = "¹éÈ¥À´<Ğş>";
			icon = "ÏÉ¡¤¹éÈ¥À´.dds";
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
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();

			return (-18000 * skill_t0) - 20000 * skill_level + 600000;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={120,122,124,126,128,130,131,132,133,134,135,136,137,138,139,141,143,145,147,149};return array[level-1];
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 17.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 15.000000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 20.000000f;
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
			victim.SetTime(((1000 * skill_level + 10100)));
			victim.SetRatio((skill_level * 0.01f + 0.7f));
			victim.SetBuffid(9);
			victim.SetSlow(true);
			victim.SetProbability(100.0f);
			victim.SetTime(((1000 * skill_level + 10100)));
			victim.SetRatio((skill_level * 0.0301f));
			victim.SetBuffid(9);
			victim.SetDecskilldodge(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();

			victim.SetProbability(999.0f);
			victim.SetTime(((1000 * skill_level + 10100)));
			victim.SetRatio((0.7f - skill_level * 0.01f));
			victim.SetBuffid(9);
			victim.SetSlow(true);
			victim.SetProbability(100.0f);
			victim.SetTime(((1000 * skill_level + 10100)));
			victim.SetRatio((skill_level * 0.0301f));
			victim.SetBuffid(9);
			victim.SetIncskilldodge(true);
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={1521};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={10};return array[index];
		}
		public override int GetDivinityExp(int level)
		{
			int[] array={400,500,500,700,1500,3100,3900,6500,9100,10800,20700,26500,39600,52900,84300,119800,229700,389600,525000,1237600};return array[level-1];
		}
		public override int GetDivinityLevel(int level)
		{
			int[] array={2,4,6,8,10,13,16,19,22,25,29,33,37,42,47,53,59,65,71,77};return array[level-1];
		}
		public override int GetDpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return 3 * skill_level * skill_level + (30 * skill_level) + 180;
		}
	}
	public class GSkill3013 : GSkill
	{
		public GSkill3013()
			: base(3013)
		{
			
		}
	}
	public class GSkill3014Stub : GSkillStub
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
		public GSkill3014Stub()
			: base(3014)
		{
			occupation = 167;
			maxlevel = 20;
			maxlearn = 20;
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
			credittype = 0;
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
			SetAction(0,"ÇàÔÆÃÅ_ÓñÕæ¾÷");
			SetAction(1,"ÇàÔÆÃÅ_ÓñÕæ¾÷");
			SetAction(2,"¹íÍõ×Ú_ÓñÕæ¾÷");
			SetAction(3,"ºÏ»¶ÅÉ_ÓñÕæ¾÷");
			SetAction(4,"ÌìÒôËÂ_ÓñÕæ¾÷");
			SetAction(5,"¹íµÀ_ÓñÕæ¾÷");
			SetAction(6,"·ÙÏã¹È_ÓñÕæ¾÷");
			SetAction(7,"ÊŞÉñ_ÓñÕæ¾÷");
			SetAction(8,"ºüÑı_ÓñÕæ¾÷");
			SetAction(9,"ĞùÔ¯_ÓñÕæ¾÷");
			SetAction(10,"»³¹â_ÓñÕæ¾÷");
			SetAction(11,"Ì«ê»_ÓñÕæ¾÷");
			SetAction(12,"Ìì»ª_ÓñÕæ¾÷");
			SetAction(13,"ÁéÙí_ÓñÕæ¾÷");
			SetAction(14,"Ó¢ÕĞ_ÓñÕæ¾÷");
			SetAction(15,"ÎäÆ÷´óÊ¦_ÓñÕæ¾÷");
			SetAction(16,"ÎäÆ÷´óÊ¦_ÓñÕæ¾÷");
			SetAction(17,"ÌìÒôËÂ_ÓñÕæ¾÷");
			SetAction(18,"ÇàÔÆÃÅ_Æï³Ë_ÓñÕæ¾÷");
			SetAction(19,"ÇàÔÆÃÅ_Æï³Ë_ÓñÕæ¾÷");
			SetAction(20,"¹íÍõ×Ú_Æï³Ë_ÓñÕæ¾÷");
			SetAction(21,"ºÏ»¶ÅÉ_Æï³Ë_ÓñÕæ¾÷");
			SetAction(22,"ÌìÒôËÂ_Æï³Ë_ÓñÕæ¾÷");
			SetAction(23,"¹íµÀ_Æï³Ë_ÓñÕæ¾÷");
			SetAction(24,"·ÙÏã¹È_Æï³Ë_ÓñÕæ¾÷");
			SetAction(25,"ÊŞÉñ_Æï³Ë_ÓñÕæ¾÷");
			SetAction(26,"ºüÑı_Æï³Ë_ÓñÕæ¾÷");
			SetAction(27,"ĞùÔ¯_Æï³Ë_ÓñÕæ¾÷");
			SetAction(28,"»³¹â_Æï³Ë_ÓñÕæ¾÷");
			SetAction(29,"Ì«ê»_Æï³Ë_ÓñÕæ¾÷");
			SetAction(30,"Ìì»ª_Æï³Ë_ÓñÕæ¾÷");
			name = "ÓñÕæ¾÷<Ğş>";
			nativename = "ÓñÕæ¾÷<Ğş>";
			icon = "ÏÉ¡¤ÓñÕæ¾÷.dds";
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
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();

			return (-27000 * skill_t0) - 20000 * skill_level + 900000;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={120,122,124,126,128,130,131,132,133,134,135,136,137,138,139,141,143,145,147,149};return array[level-1];
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
			int				player_maxmp = player.GetMaxmp();
			int				player_dodge = player.GetDodge();
			int				player_atkrate = player.GetAtkrate();
			int				skill_level = skill.GetLevel();

			/*
			victim.SetProbability(100.0f);
			victim.SetTime(100.0f);
			victim.SetBuffid(1);
			if ( player.GetIsfrozen() )
			{
			v30 = player_maxmp * (norm(skill_level / 19.9f) * 0.3f) + (((player_dodge + player_atkrate) * (skill_level + 4)));
			}
			else
			{
			v30 = (player_maxmp * (norm(skill_level / 19.9f) * 0.3f) + (((player_dodge + player_atkrate) * (skill_level + 4)))) * ((norm((zrand(skill_level + 100)) / 100) + 1));
			}
			victim.SetAmount(v30);
			victim.SetValue(0.0f);
			victim.SetHpleak2(true);
			*/
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();

			victim.SetRatio(((8 * norm(zrand(100) / (100 - 2 * skill_level)) + 1520)));
			victim.SetAmount(((9 * norm(zrand(100) / (100 - 2 * skill_level)) + 1520)));
			victim.SetValue(((10 * norm(zrand(100) / (100 - 2 * skill_level)) + 1520)));
			victim.SetClearcooldown(true);
			victim.SetProbability(120.0f);
			victim.SetTime(((900000 - 20000 * skill_level)));
			victim.SetRatio(1525.0f);
			victim.SetAmount(1525.0f);
			victim.SetValue(1525.0f);
			victim.SetSetcooldown(true);
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={1525};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={10};return array[index];
		}
		public override int GetDivinityExp(int level)
		{
			int[] array={400,500,500,700,1500,2400,3500,5600,8500,8600,19000,26500,49100,57600,85800,140300,241000,410600,614500,1344300};return array[level-1];
		}
		public override int GetDivinityLevel(int level)
		{
			int[] array={2,4,6,8,10,12,15,18,21,24,28,33,38,43,48,54,60,66,72,78};return array[level-1];
		}
		public override int GetDpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return 3 * skill_level * skill_level + (30 * skill_level) + 180;
		}
	}
	public class GSkill3014 : GSkill
	{
		public GSkill3014()
			: base(3014)
		{
			
		}
	}
	public class GSkill3015Stub : GSkillStub
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
				int				player_res4 = player.GetRes4();
				int				skill_level = skill.GetLevel();

				player.SetVar1(player_res4);
				skill.SetRatio((skill_level * 0.05f + 1.0f));
				player.SetPerform(1);
			}
		}
		public GSkill3015Stub()
			: base(3015)
		{
			occupation = 167;
			maxlevel = 20;
			maxlearn = 20;
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
			credittype = 0;
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
			SetAction(0,"ÇàÔÆÃÅ_¼ÅÃğÌì");
			SetAction(1,"ÇàÔÆÃÅ_¼ÅÃğÌì");
			SetAction(2,"¹íÍõ×Ú_¼ÅÃğÌì");
			SetAction(3,"ºÏ»¶ÅÉ_¼ÅÃğÌì");
			SetAction(4,"ÌìÒôËÂ_¼ÅÃğÌì");
			SetAction(5,"¹íµÀ_¼ÅÃğÌì");
			SetAction(6,"·ÙÏã¹È_¼ÅÃğÌì");
			SetAction(7,"ÊŞÉñ_¼ÅÃğÌì");
			SetAction(8,"ºüÑı_¼ÅÃğÌì");
			SetAction(9,"ĞùÔ¯_¼ÅÃğÌì");
			SetAction(10,"»³¹â_¼ÅÃğÌì");
			SetAction(11,"Ì«ê»_¼ÅÃğÌì");
			SetAction(12,"Ìì»ª_¼ÅÃğÌì");
			SetAction(13,"ÁéÙí_¼ÅÃğÌì");
			SetAction(14,"Ó¢ÕĞ_¼ÅÃğÌì");
			SetAction(15,"ÎäÆ÷´óÊ¦_¼ÅÃğÌì");
			SetAction(16,"ÎäÆ÷´óÊ¦_¼ÅÃğÌì");
			SetAction(17,"ÌìÒôËÂ_¼ÅÃğÌì");
			SetAction(18,"ÇàÔÆÃÅ_Æï³Ë_¼ÅÃğÌì");
			SetAction(19,"ÇàÔÆÃÅ_Æï³Ë_¼ÅÃğÌì");
			SetAction(20,"¹íÍõ×Ú_Æï³Ë_¼ÅÃğÌì");
			SetAction(21,"ºÏ»¶ÅÉ_Æï³Ë_¼ÅÃğÌì");
			SetAction(22,"ÌìÒôËÂ_Æï³Ë_¼ÅÃğÌì");
			SetAction(23,"¹íµÀ_Æï³Ë_¼ÅÃğÌì");
			SetAction(24,"·ÙÏã¹È_Æï³Ë_¼ÅÃğÌì");
			SetAction(25,"ÊŞÉñ_Æï³Ë_¼ÅÃğÌì");
			SetAction(26,"ºüÑı_Æï³Ë_¼ÅÃğÌì");
			SetAction(27,"ĞùÔ¯_Æï³Ë_¼ÅÃğÌì");
			SetAction(28,"»³¹â_Æï³Ë_¼ÅÃğÌì");
			SetAction(29,"Ì«ê»_Æï³Ë_¼ÅÃğÌì");
			SetAction(30,"Ìì»ª_Æï³Ë_¼ÅÃğÌì");
			name = "¼ÅÃğÌì<Ğş>";
			nativename = "¼ÅÃğÌì<Ğş>";
			icon = "ÏÉ¡¤¼ÅÃğÌì.dds";
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
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();

			return (-18000 * skill_t0) - 15000 * skill_level + 600000;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={120,122,124,126,128,130,131,132,133,134,135,136,137,138,139,141,143,145,147,149};return array[level-1];
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
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_var1 = player.GetVar1();
			int				skill_level = skill.GetLevel();

			victim.SetProbability(600.0f);
			victim.SetTime(((2000 * skill_level + 10100)));
			victim.SetRatio(0.80000001f);
			victim.SetBuffid(8);
			victim.SetSlow(true);
			victim.SetProbability(((3 * skill_level + player_var1)));
			victim.SetTime(((2000 * skill_level + 10100)));
			victim.SetSilent(true);
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={1528};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={10};return array[index];
		}
		public override int GetDivinityExp(int level)
		{
			int[] array={200,500,500,600,900,1900,3200,4500,8600,10800,20700,32200,51000,65200,84800,159900,260100,427500,743600,1450600};return array[level-1];
		}
		public override int GetDivinityLevel(int level)
		{
			int[] array={1,3,5,7,9,11,14,17,21,25,29,34,39,44,49,55,61,67,73,79};return array[level-1];
		}
		public override int GetDpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return 4 * skill_level * skill_level + (50 * skill_level) + 190;
		}
	}
	public class GSkill3015 : GSkill
	{
		public GSkill3015()
			: base(3015)
		{
			
		}
	}
	public class GSkill3016Stub : GSkillStub
	{
		public class GState1 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 1350;
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
				return 650;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_maxatk = player.GetMaxatk();

				player.SetVar1(player_maxatk);
				player.SetPerform(1);
			}
		}
		public GSkill3016Stub()
			: base(3016)
		{
			occupation = 167;
			maxlevel = 20;
			maxlearn = 20;
			eventflag = 0;
			spcost = 0;
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
			clearmask = 1;
			skill_limit = 1;
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
			SetAction(0,"ÏÉ_±ùÉË");
			SetAction(1,"ÏÉ_±ùÉË");
			SetAction(2,"ÏÉ_±ùÉË");
			SetAction(3,"ÏÉ_±ùÉË");
			SetAction(4,"ÏÉ_±ùÉË");
			SetAction(5,"ÏÉ_±ùÉË");
			SetAction(6,"ÏÉ_±ùÉË");
			SetAction(7,"ÏÉ_±ùÉË");
			SetAction(8,"ÏÉ_±ùÉË");
			SetAction(9,"ÏÉ_±ùÉË");
			SetAction(10,"ÏÉ_±ùÉË");
			SetAction(11,"ÏÉ_±ùÉË");
			SetAction(12,"ÏÉ_±ùÉË");
			SetAction(13,"ÏÉ_±ùÉË");
			SetAction(14,"ÏÉ_±ùÉË");
			SetAction(15,"ÏÉ_±ùÉË");
			SetAction(16,"ÏÉ_±ùÉË");
			SetAction(17,"ÏÉ_±ùÉË");
			SetAction(18,"Æï³Ë_ÏÉ_±ùÉË");
			SetAction(19,"Æï³Ë_ÏÉ_±ùÉË");
			SetAction(20,"Æï³Ë_ÏÉ_±ùÉË");
			SetAction(21,"Æï³Ë_ÏÉ_±ùÉË");
			SetAction(22,"Æï³Ë_ÏÉ_±ùÉË");
			SetAction(23,"Æï³Ë_ÏÉ_±ùÉË");
			SetAction(24,"Æï³Ë_ÏÉ_±ùÉË");
			SetAction(25,"Æï³Ë_ÏÉ_±ùÉË");
			SetAction(26,"Æï³Ë_ÏÉ_±ùÉË");
			SetAction(27,"Æï³Ë_ÏÉ_±ùÉË");
			SetAction(28,"Æï³Ë_ÏÉ_±ùÉË");
			SetAction(29,"Æï³Ë_ÏÉ_±ùÉË");
			SetAction(30,"Æï³Ë_ÏÉ_±ùÉË");
			name = "ÄæÌì½Ù";
			nativename = "ÄæÌì½Ù";
			icon = "ÈËÌåÕ¨µ¯.dds";
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
			int				skill_level = skill.GetLevel();

			return 300000 - 10000 * skill_level;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={120,122,124,126,128,130,131,132,133,134,135,136,137,138,139,141,143,145,147,150};return array[level-1];
		}
		public override float GetPraydistance(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (skill_level * 0.5f + 5.0f);
		}
		public override float GetCastdistance(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (skill_level * 0.5f + 2.0f);
		}
		public override float GetEffectdistance(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (skill_level * 0.5f + 10.0f);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_var1 = player.GetVar1();
			int				skill_level = skill.GetLevel();

			/*
			victim.SetProbability(120.0f);
			victim.SetTime(10050.0f);
			victim.SetRatio(0.2f);
			victim.SetBuffid((D2INT(skill_level / 5) + 3));
			victim.SetAmount(15.0f);
			if ( zrand((skill_level * 0.5f + 105.0f)) <= 100 )
			{
			v26 = (norm(skill_level / 19.9f) * 0.1f + 1.0f) * (player_var1 * (zrand(skill_level) * 0.2f + ((0.2f * skill_level) + 0.8f)));
			}
			else
			{
			v26 = (norm(skill_level / 19.9f) * 0.1f + 1.0f) * (player_var1 * (1.5f * (zrand(skill_level) * 0.2f + ((0.2f * skill_level) + 0.8f))));
			}
			victim.SetValue(v26);
			victim.SetHumanbomb(true);
			*/
			return true;
		}
		public override int GetDivinityExp(int level)
		{
			int[] array={400,500,500,700,1500,3100,3900,6500,10300,16900,21800,43300,49900,81300,84500,197600,340200,435500,998600,1897100};return array[level-1];
		}
		public override int GetDivinityLevel(int level)
		{
			int[] array={2,4,6,8,10,13,16,19,23,27,31,36,41,46,51,57,63,69,75,81};return array[level-1];
		}
		public override int GetDpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return 4 * skill_level * skill_level + (50 * skill_level) + 190;
		}
	}
	public class GSkill3016 : GSkill
	{
		public GSkill3016()
			: base(3016)
		{
			
		}
	}
	public class GSkill3017Stub : GSkillStub
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
				int				skill_t3 = skill.GetT3();

				skill.SetRatio(((skill_level - 15) * (norm(skill_level / 14.9f) * 0.03f) + (skill_level * 0.05f + (skill_t3 * 0.05f + 1.1f))));
				skill.SetPlus((((zrand(15 * skill_t1 + 10) - 10) * norm(skill_t1 + 0.1f) + 100) / 100.0f * ((skill_level * (skill_level * 7.2f)) - skill_level * 6.4f + 694.0f)));
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
				int				skill_t3 = skill.GetT3();

				player.SetVar1(1);
				skill.SetRatio(((skill_level - 15) * (norm(skill_level / 14.9f) * 0.03f) + (skill_level * 0.05f + (skill_t3 * 0.05f + 1.1f))));
				skill.SetPlus((((zrand(15 * skill_t1 + 10) - 10) * norm(skill_t1 + 0.1f) + 100) / 100.0f * ((skill_level * (skill_level * 7.2f)) - skill_level * 6.4f + 694.0f)));
				player.SetPerform(0);
			}
		}
		public GSkill3017Stub()
			: base(3017)
		{
			occupation = 167;
			maxlevel = 20;
			maxlearn = 20;
			eventflag = 0;
			spcost = 0;
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
			SetAction(0,"ÇàÔÆÃÅ_À×¹â¶İÁú¾ö");
			SetAction(1,"ÇàÔÆÃÅ_À×¹â¶İÁú¾ö");
			SetAction(2,"ÇàÔÆÃÅ_À×¹â¶İÁú¾ö");
			SetAction(3,"ÇàÔÆÃÅ_À×¹â¶İÁú¾ö");
			SetAction(4,"ÇàÔÆÃÅ_À×¹â¶İÁú¾ö");
			SetAction(5,"ÇàÔÆÃÅ_À×¹â¶İÁú¾ö");
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
			SetAction(16,"0");
			SetAction(17,"0");
			SetAction(18,"ÇàÔÆÃÅ_Æï³Ë_À×¹â¶İÁú¾ö");
			SetAction(19,"ÇàÔÆÃÅ_Æï³Ë_À×¹â¶İÁú¾ö");
			SetAction(20,"ÇàÔÆÃÅ_Æï³Ë_À×¹â¶İÁú¾ö");
			SetAction(21,"ÇàÔÆÃÅ_Æï³Ë_À×¹â¶İÁú¾ö");
			SetAction(22,"ÇàÔÆÃÅ_Æï³Ë_À×¹â¶İÁú¾ö");
			SetAction(23,"ÇàÔÆÃÅ_Æï³Ë_À×¹â¶İÁú¾ö");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "À×¹â¶İÁú¾÷<Ğş>";
			nativename = "À×¹â¶İÁú¾÷<Ğş>";
			icon = "ÏÉ¡¤À×¹â¶İÁú¾÷.dds";
			SetTalent(0,606);
			SetTalent(1,610);
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
			AddState(new GState3());
		}
		public override int GetExecutetime(GSkill skill)
		{
			return 2000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			return 3000;
		}
		public override int GetEnmity(GSkill skill)
		{
			return 1;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={120,122,124,126,128,130,131,132,133,134,135,136,137,138,139,141,143,145,147,149};return array[level-1];
		}
		public override float GetRadius(GSkill skill)
		{
			return 21.000000f;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 21.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 16.000000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 24.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return ((skill_level * (skill_level * 11.5f)) - skill_level * 2.8f + 1630.0f);
		}
		public override int GetCoverage(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return skill_level + 10;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();

			victim.SetProbability(((skill_level + 12)));
			victim.SetTime(((8000 * skill_t0 + 8100)));
			victim.SetBuffid(1);
			victim.SetValue(((225 * skill_level)));
			victim.SetSubattack(true);
			victim.SetTime(((500 * skill_level + 2050)));
			victim.SetAmount(skill_level);
			victim.SetValue(((24 * skill_level + 48)));
			victim.SetCursed(true);
			return true;
		}
		public override float GetDropRate(GSkill skill)
		{
			return 0.500000f;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={783};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={6};return array[index];
		}
		public override int GetDivinityExp(int level)
		{
			int[] array={400,500,500,700,1500,3100,3900,6500,9100,10800,20700,26500,39600,52900,84300,119800,229700,389600,525000,1237600};return array[level-1];
		}
		public override int GetDivinityLevel(int level)
		{
			int[] array={2,4,6,8,10,13,16,19,22,25,29,33,37,42,47,53,59,65,71,77};return array[level-1];
		}
		public override int GetDpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return 4 * skill_level * skill_level + (34 * skill_level) + 200;
		}
	}
	public class GSkill3017 : GSkill
	{
		public GSkill3017()
			: base(3017)
		{
			
		}
	}
	public class GSkill3018Stub : GSkillStub
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
				int				player_res3 = player.GetRes3();

				player.SetVar1(player_res3);
				player.SetPerform(1);
			}
		}
		public GSkill3018Stub()
			: base(3018)
		{
			occupation = 167;
			maxlevel = 20;
			maxlearn = 20;
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
			credittype = 0;
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
			SetAction(0,"ÇàÔÆÃÅ_Ìì×ğ·¨Éí");
			SetAction(1,"ÇàÔÆÃÅ_Ìì×ğ·¨Éí");
			SetAction(2,"ÇàÔÆÃÅ_Ìì×ğ·¨Éí");
			SetAction(3,"ÇàÔÆÃÅ_Ìì×ğ·¨Éí");
			SetAction(4,"ÇàÔÆÃÅ_Ìì×ğ·¨Éí");
			SetAction(5,"ÇàÔÆÃÅ_Ìì×ğ·¨Éí");
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
			SetAction(18,"ÇàÔÆÃÅ_Æï³Ë_Ìì×ğ·¨Éí");
			SetAction(19,"ÇàÔÆÃÅ_Æï³Ë_Ìì×ğ·¨Éí");
			SetAction(20,"ÇàÔÆÃÅ_Æï³Ë_Ìì×ğ·¨Éí");
			SetAction(21,"ÇàÔÆÃÅ_Æï³Ë_Ìì×ğ·¨Éí");
			SetAction(22,"ÇàÔÆÃÅ_Æï³Ë_Ìì×ğ·¨Éí");
			SetAction(23,"ÇàÔÆÃÅ_Æï³Ë_Ìì×ğ·¨Éí");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "Ìì×ğ·¨Éí<Ğş>";
			nativename = "Ìì×ğ·¨Éí<Ğş>";
			icon = "ÏÉ¡¤Ìì×ğ·¨Éí.dds";
			SetTalent(0,578);
			SetTalent(1,592);
			SetTalent(2,594);
			SetTalent(3,596);
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
			int				skill_t3 = skill.GetT3();

			return 120000 - 10000 * skill_t3;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={120,122,124,126,128,130,131,132,133,134,135,136,137,138,139,141,143,145,147,149};return array[level-1];
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

			return (30 * skill_level + 560);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_maxhp = player.GetMaxhp();
			int				player_var1 = player.GetVar1();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();
			int				skill_t2 = skill.GetT2();

			victim.SetProbability(100.0f);
			victim.SetTime(20100.0f);
			victim.SetRatio(((D2INT((zrand(5 * skill_t2 + 99)) / 100) + 1) * (skill_t2 * 0.01f + (skill_level * 0.01f + 0.011f))));
			victim.SetBuffid(1);
			victim.SetValue(((skill_t0 * 0.3f + 1.0f) * (skill_level * (player_maxhp * 0.01f))));
			victim.SetFashen(true);
			victim.SetProbability(100.0f);
			victim.SetTime(((1000 * skill_level + 4100)));
			victim.SetRatio(1.0f);
			victim.SetAmount(skill_level);
			victim.SetValue(player_var1);
			victim.SetFrenzied(true);
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={784};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={5};return array[index];
		}
		public override int GetDivinityExp(int level)
		{
			int[] array={400,500,500,700,1500,2400,3500,5600,8500,8600,19000,26500,49100,57600,85800,140300,241000,410600,614500,1344300};return array[level-1];
		}
		public override int GetDivinityLevel(int level)
		{
			int[] array={2,4,6,8,10,12,15,18,21,24,28,33,38,43,48,54,60,66,72,78};return array[level-1];
		}
		public override int GetDpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return 3 * skill_level * skill_level + (26 * skill_level) + 180;
		}
	}
	public class GSkill3018 : GSkill
	{
		public GSkill3018()
			: base(3018)
		{
			
		}
	}
	public class GSkill3019Stub : GSkillStub
	{
		public class GState1 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 500;
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
				return 500;
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

				skill.SetRatio((D2INT((player_mp / (0.95f - skill_t2 * 0.1f)) / player_maxmp) * (skill_level * 0.02f + 0.06f) + (skill_t3 * ((player.GetSkilllevel(786) / 1.9f) * 0.05f + ((player.GetSkilllevel(785) / 3.9f) * 0.05f + ((player.GetSkilllevel(543) / 9) * 0.05f + ((player.GetSkilllevel(242) / 9) * 0.05f + ((player.GetSkilllevel(234) / 9) * 0.05f + 0.05f))))) + ((skill_level - 15) * (norm(skill_level / 14.9f) * 0.03f) + (skill_level * 0.05f + 1.0f)))));
				skill.SetPlus((((zrand(15 * skill_t0 + 10) - 10) * norm(skill_t0 + 0.1f) + 100) / 100.0f * ((2 * (skill_level * skill_level + (11 * skill_level)) + 750))));
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
				return 500;
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

				skill.SetRatio((D2INT((player_mp / (0.95f - skill_t2 * 0.1f)) / player_maxmp) * (skill_level * 0.02f + 0.06f) + (skill_t3 * ((player.GetSkilllevel(786) / 1.9f) * 0.05f + ((player.GetSkilllevel(785) / 3.9f) * 0.05f + ((player.GetSkilllevel(543) / 9) * 0.05f + ((player.GetSkilllevel(242) / 9) * 0.05f + ((player.GetSkilllevel(234) / 9) * 0.05f + 0.05f))))) + ((skill_level - 15) * (norm(skill_level / 14.9f) * 0.03f) + (skill_level * 0.05f + 1.0f)))));
				skill.SetPlus((((zrand(15 * skill_t0 + 10) - 10) * norm(skill_t0 + 0.1f) + 100) / 100.0f * ((2 * (skill_level * skill_level + (11 * skill_level)) + 750))));
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
				return 500;
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

				skill.SetRatio((D2INT((player_mp / (0.95f - skill_t2 * 0.1f)) / player_maxmp) * (skill_level * 0.02f + 0.06f) + (skill_t3 * ((player.GetSkilllevel(786) / 1.9f) * 0.05f + ((player.GetSkilllevel(785) / 3.9f) * 0.05f + ((player.GetSkilllevel(543) / 9) * 0.05f + ((player.GetSkilllevel(242) / 9) * 0.05f + ((player.GetSkilllevel(234) / 9) * 0.05f + 0.05f))))) + ((skill_level - 15) * (norm(skill_level / 14.9f) * 0.03f) + (skill_level * 0.05f + 1.0f)))));
				skill.SetPlus((((zrand(15 * skill_t0 + 10) - 10) * norm(skill_t0 + 0.1f) + 100) / 100.0f * ((2 * (skill_level * skill_level + (11 * skill_level)) + 750))));
				player.SetPerform(0);
			}
		}
		public GSkill3019Stub()
			: base(3019)
		{
			occupation = 167;
			maxlevel = 20;
			maxlearn = 20;
			eventflag = 0;
			spcost = 0;
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
			SetAction(0,"ÇàÔÆÃÅ_Ì«¼«ĞşÌìÕæ¾÷");
			SetAction(1,"ÇàÔÆÃÅ_Ì«¼«ĞşÌìÕæ¾÷");
			SetAction(2,"ÇàÔÆÃÅ_Ì«¼«ĞşÌìÕæ¾÷");
			SetAction(3,"ÇàÔÆÃÅ_Ì«¼«ĞşÌìÕæ¾÷");
			SetAction(4,"ÇàÔÆÃÅ_Ì«¼«ĞşÌìÕæ¾÷");
			SetAction(5,"ÇàÔÆÃÅ_Ì«¼«ĞşÌìÕæ¾÷");
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
			SetAction(18,"ÇàÔÆÃÅ_Æï³Ë_Ì«¼«ĞşÌìÕæ¾÷");
			SetAction(19,"ÇàÔÆÃÅ_Æï³Ë_Ì«¼«ĞşÌìÕæ¾÷");
			SetAction(20,"ÇàÔÆÃÅ_Æï³Ë_Ì«¼«ĞşÌìÕæ¾÷");
			SetAction(21,"ÇàÔÆÃÅ_Æï³Ë_Ì«¼«ĞşÌìÕæ¾÷");
			SetAction(22,"ÇàÔÆÃÅ_Æï³Ë_Ì«¼«ĞşÌìÕæ¾÷");
			SetAction(23,"ÇàÔÆÃÅ_Æï³Ë_Ì«¼«ĞşÌìÕæ¾÷");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "Ì«¼«ĞşÌìÕæ¾÷<Ğş>";
			nativename = "Ì«¼«ĞşÌìÕæ¾÷<Ğş>";
			icon = "ÏÉ¡¤Ì«¼«ĞşÌìÕæ¾÷.dds";
			SetTalent(0,607);
			SetTalent(1,611);
			SetTalent(2,612);
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
			AddState(new GState4());
		}
		public override int GetExecutetime(GSkill skill)
		{
			return 2000;
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
			int[] array={120,122,124,126,128,130,131,132,133,134,135,136,137,138,139,141,143,145,147,149};return array[level-1];
		}
		public override float GetRadius(GSkill skill)
		{
			return 23.000000f;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 22.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 15.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return ((4 * skill_level * skill_level) - 5 * skill_level + 2230);
		}
		public override int GetCoverage(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return skill_level + 10;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();
			int				skill_t1 = skill.GetT1();

			victim.SetProbability(((3 * skill_t1) + (skill_level * 0.5f + 2.0f)));
			victim.SetTime(3100.0f);
			victim.SetRatio(0.2f);
			victim.SetValue(0.2f);
			victim.SetRandcurse(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_mp = player.GetMp();
			int				player_maxmp = player.GetMaxmp();
			int				skill_level = skill.GetLevel();
			int				skill_t2 = skill.GetT2();

			victim.SetBuffid((D2INT((player_mp / (0.95f - skill_t2 * 0.1f)) / player_maxmp)));
			victim.SetUniqprompt(true);
			victim.SetProbability(((4 * skill_level + 15)));
			victim.SetClearwrap(true);
			return true;
		}
		public override float GetDropRate(GSkill skill)
		{
			return 0.500000f;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={785};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={4};return array[index];
		}
		public override int GetDivinityExp(int level)
		{
			int[] array={200,500,500,600,900,1900,3200,4500,8600,10800,20700,32200,51000,65200,84800,159900,260100,427500,743600,1450600};return array[level-1];
		}
		public override int GetDivinityLevel(int level)
		{
			int[] array={1,3,5,7,9,11,14,17,21,25,29,34,39,44,49,55,61,67,73,79};return array[level-1];
		}
		public override int GetDpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return 4 * skill_level * skill_level + (34 * skill_level) + 200;
		}
	}
	public class GSkill3019 : GSkill
	{
		public GSkill3019()
			: base(3019)
		{
			
		}
	}
}
