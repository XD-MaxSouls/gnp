using System;
using System.Text;

namespace SKILL
{
	public class GSkill3130Stub : GSkillStub
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
		public GSkill3130Stub()
			: base(3130)
		{
			occupation = 169;
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
			clearmask = 4;
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
			SetAction(0,"–∞…Ò∞¡ ¿");
			SetAction(1,"–∞…Ò∞¡ ¿");
			SetAction(2,"–∞…Ò∞¡ ¿");
			SetAction(3,"–∞…Ò∞¡ ¿");
			SetAction(4,"–∞…Ò∞¡ ¿");
			SetAction(5,"–∞…Ò∞¡ ¿");
			SetAction(6,"0");
			SetAction(7,"0");
			SetAction(8,"0");
			SetAction(9,"0");
			SetAction(10,"0");
			SetAction(11,"0");
			SetAction(12,"0");
			SetAction(13,"0");
			SetAction(14,"0");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"–∞…Ò∞¡ ¿");
			SetAction(19,"–∞…Ò∞¡ ¿");
			SetAction(20,"–∞…Ò∞¡ ¿");
			SetAction(21,"–∞…Ò∞¡ ¿");
			SetAction(22,"–∞…Ò∞¡ ¿");
			SetAction(23,"–∞…Ò∞¡ ¿");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "–∞…Ò∞¡ ¿<Ï¯>";
			nativename = "–∞…Ò∞¡ ¿<Ï¯>";
			icon = "∑°§–∞…Ò∞¡ ¿.dds";
			SetTalent(0,1168);
			SetTalent(1,1169);
			SetTalent(2,1170);
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
			skill_class = 4;
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

			return (-18000 * skill_t0) - 4000 * skill_level + 180000;
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
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();
			int				skill_t1 = skill.GetT1();
			int				skill_t2 = skill.GetT2();

			victim.SetProbability(120.0f);
			victim.SetTime((((2000 * skill_t2 + 12000) * (norm(zrand(100) / (100 - 10 * skill_t2)) + 1) + 100)));
			victim.SetRatio((skill_t1 * 0.02f + (skill_level * 0.01f + 0.1f)));
			victim.SetBuffid(1);
			victim.SetAmount(0.0f);
			victim.SetValue(0.0f);
			victim.SetAoshi(true);
			victim.SetProbability(100.0f);
			victim.SetTime((((2000 * skill_t2 + 12000) * (norm(zrand(100) / (100 - 10 * skill_t2)) + 1))));
			victim.SetRatio((skill_level * 0.01f + 0.05f));
			victim.SetBuffid(5);
			victim.SetIncskillaccu(true);
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={1132};return array[index];
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
	public class GSkill3130 : GSkill
	{
		public GSkill3130()
			: base(3130)
		{
			
		}
	}
	public class GSkill3131Stub : GSkillStub
	{
		public class GState1 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 400;
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
				int				player_res1 = player.GetRes1();
				int				skill_level = skill.GetLevel();
				int				skill_t0 = skill.GetT0();
				int				skill_t1 = skill.GetT1();

				player.SetVar1(player_res1);
				skill.SetRatio((skill_t1 * 0.05f + (skill_level * 0.03f + 1.0f)));
				skill.SetCrit((skill_level * 0.01f));
				skill.SetPlus(((2 * skill_level * skill_level) + ((45 * skill_level) + ((35 * skill_t0 * skill_level) + ((norm(skill_level / 19.9f) + (skill_level * 0.1f)) * player_res1) + 860.0f))));
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
				return 400;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_res1 = player.GetRes1();
				int				skill_level = skill.GetLevel();
				int				skill_t0 = skill.GetT0();
				int				skill_t1 = skill.GetT1();

				player.SetVar1(player_res1);
				skill.SetRatio((skill_t1 * 0.05f + (skill_level * 0.03f + 1.0f)));
				skill.SetCrit((skill_level * 0.01f + 0.01f));
				skill.SetPlus(((2 * skill_level * skill_level) + ((45 * skill_level) + ((35 * skill_t0 * skill_level) + ((norm(skill_level / 19.9f) + (skill_level * 0.1f)) * player_res1) + 860.0f))));
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
				return 400;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_res1 = player.GetRes1();
				int				skill_level = skill.GetLevel();
				int				skill_t0 = skill.GetT0();
				int				skill_t1 = skill.GetT1();

				player.SetVar1(player_res1);
				skill.SetRatio((skill_t1 * 0.05f + (skill_level * 0.03f + 1.0f)));
				skill.SetCrit((skill_level * 0.01f + 0.02f));
				skill.SetPlus(((2 * skill_level * skill_level) + ((45 * skill_level) + ((35 * skill_t0 * skill_level) + ((norm(skill_level / 19.9f) + (skill_level * 0.1f)) * player_res1) + 860.0f))));
				player.SetPerform(0);
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
				return 400;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_res1 = player.GetRes1();
				int				skill_level = skill.GetLevel();
				int				skill_t0 = skill.GetT0();
				int				skill_t1 = skill.GetT1();

				player.SetVar1(player_res1);
				skill.SetRatio((skill_t1 * 0.05f + (skill_level * 0.03f + 1.0f)));
				skill.SetCrit((skill_level * 0.01f + 0.03f));
				skill.SetCrithurt(1.0f);
				skill.SetPlus(((2 * skill_level * skill_level) + ((45 * skill_level) + ((35 * skill_t0 * skill_level) + ((norm(skill_level / 19.9f) + (skill_level * 0.1f)) * player_res1) + 860.0f))));
				player.SetPerform(0);
			}
		}
		public GSkill3131Stub()
			: base(3131)
		{
			occupation = 169;
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
			autoattack = true;
			allowform = 2;
			credittype = 0;
			clearmask = 4;
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
			SetAction(0,"…ÒπÌ¬“ŒË");
			SetAction(1,"…ÒπÌ¬“ŒË");
			SetAction(2,"…ÒπÌ¬“ŒË");
			SetAction(3,"…ÒπÌ¬“ŒË");
			SetAction(4,"…ÒπÌ¬“ŒË");
			SetAction(5,"…ÒπÌ¬“ŒË");
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
			SetAction(18,"…ÒπÌ¬“ŒË");
			SetAction(19,"…ÒπÌ¬“ŒË");
			SetAction(20,"…ÒπÌ¬“ŒË");
			SetAction(21,"…ÒπÌ¬“ŒË");
			SetAction(22,"…ÒπÌ¬“ŒË");
			SetAction(23,"…ÒπÌ¬“ŒË");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "…ÒπÌ¬“ŒË<Ï¯>";
			nativename = "…ÒπÌ¬“ŒË<Ï¯>";
			icon = "∑°§…ÒπÌ¬“ŒË.dds";
			SetTalent(0,1166);
			SetTalent(1,1172);
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
			skill_class = 4;
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
		}
		public override int GetExecutetime(GSkill skill)
		{
			return 2000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return 11000 - 500 * skill_level;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={120,122,124,126,128,130,131,132,133,134,135,136,137,138,139,141,143,145,147,149};return array[level-1];
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 9.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 2.700000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 15.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (skill_level * skill_level + (25 * skill_level) + 700);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_maxmp = player.GetMaxmp();
			int				player_var1 = player.GetVar1();
			int				skill_level = skill.GetLevel();

			victim.SetProbability(15.0f);
			victim.SetTime(12100.0f);
			victim.SetRatio((skill_level * 0.01001f + 0.04f));
			victim.SetBuffid(1);
			victim.SetDeccritrate(true);
			victim.SetProbability(15.0f);
			victim.SetTime(12100.0f);
			victim.SetRatio((skill_level * 0.05f));
			victim.SetBuffid(1);
			victim.SetDecdodge(true);
			victim.SetProbability(((skill_level + 5)));
			victim.SetTime(12100.0f);
			victim.SetBuffid(1);
			victim.SetAmount((player_maxmp * 0.25f + 1.0f));
			victim.SetValue(((player_var1 * skill_level)));
			victim.SetSubmp(true);
			victim.SetProbability(((650 * norm(zrand(100) / (100 - 2 * skill_level)))));
			victim.SetTime(12100.0f);
			victim.SetSilent(true);
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={1133};return array[index];
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

			return 3 * skill_level * skill_level + (42 * skill_level) + 170;
		}
	}
	public class GSkill3131 : GSkill
	{
		public GSkill3131()
			: base(3131)
		{
			
		}
	}
	public class GSkill3132Stub : GSkillStub
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
				int				player_maxhp = player.GetMaxhp();
				int				player_maxatk = player.GetMaxatk();
				int				skill_level = skill.GetLevel();

				player.SetVar1(player_maxatk);
				player.SetVar2(player_maxhp);
				skill.SetRatio((skill_level * 0.02f + 0.48f));
				player.SetPerform(1);
			}
		}
		public GSkill3132Stub()
			: base(3132)
		{
			occupation = 169;
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
			dobless = true;
			autoattack = false;
			allowform = 4;
			credittype = 0;
			clearmask = 4;
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
			SetAction(0,"ÃÏ—°µ¿‘π");
			SetAction(1,"ÃÏ—°µ¿‘π");
			SetAction(2,"ÃÏ—°µ¿‘π");
			SetAction(3,"ÃÏ—°µ¿‘π");
			SetAction(4,"ÃÏ—°µ¿‘π");
			SetAction(5,"ÃÏ—°µ¿‘π");
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
			SetAction(18,"ÃÏ—°µ¿‘π");
			SetAction(19,"ÃÏ—°µ¿‘π");
			SetAction(20,"ÃÏ—°µ¿‘π");
			SetAction(21,"ÃÏ—°µ¿‘π");
			SetAction(22,"ÃÏ—°µ¿‘π");
			SetAction(23,"ÃÏ—°µ¿‘π");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "ÃÏ—°µ¿‘π<Ï¯>";
			nativename = "ÃÏ—°µ¿‘π<Ï¯>";
			icon = "∑°§ÃÏ—°µ¿‘π.dds";
			SetTalent(0,1185);
			SetTalent(1,1187);
			SetTalent(2,1189);
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
			skill_class = 4;
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
			return 12000;
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
			return 22.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 20.000000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 24.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (420 * skill_level + 420);
		}
		public override int GetCoverage(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return D2INT(skill_level / 2) + 6;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_level = player.GetLevel();
			int				player_hp = player.GetHp();
			int				player_var1 = player.GetVar1();
			int				player_var2 = player.GetVar2();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();
			int				skill_t1 = skill.GetT1();
			int				skill_t2 = skill.GetT2();

			victim.SetProbability(((skill_t2 * 0.1f + 1.0f) * ((1.0f - player_level * 0.003f) * 100.0f)));
			victim.SetTime(((60000 - 2000 * skill_t2)));
			victim.SetBuffid(1);
			victim.SetAmount((player_hp * (skill_level * (skill_t0 * 0.005f)) + ((skill_t0 * 0.1f + 1.0f) * (player_var1 * (skill_level * 0.8f + 2.0f) + (player_var2 * (skill_level * 0.1f + 1.0f))))));
			victim.SetValue(((skill_level * 0.1f + 0.8f) * player_var1));
			victim.SetHpleak3(true);
			victim.SetProbability(((1.0f - player_level * 0.002f) * ((skill_level + 5))));
			victim.SetRatio(1.0f);
			victim.SetDrainmagic(true);
			victim.SetProbability(((5 * skill_level)));
			victim.SetTime(((2000 * skill_t1 + (3000 * skill_level) + 100)));
			victim.SetBuffid(1);
			victim.SetValue(10000.0f);
			victim.SetSubdefence(true);
			victim.SetProbability(((skill_level + 5)));
			victim.SetTime(((2000 * skill_t1 + (500 * skill_level) + 1100)));
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
			int				skill_level = skill.GetLevel();

			victim.SetProbability(100.0f);
			victim.SetTime(8100.0f);
			victim.SetBuffid(5);
			victim.SetValue((player_mp * 0.004f + 1.0f));
			victim.SetAdddefence(true);
			victim.SetProbability(((5 * skill_level)));
			victim.SetTime(20050.0f);
			victim.SetRatio((skill_level * 0.1f + 0.5f));
			victim.SetBuffid(15);
			victim.SetAmount(0.0f);
			victim.SetValue(20.0f);
			victim.SetDeathscatter(true);
			return true;
		}
		public override float GetDropRate(GSkill skill)
		{
			return 0.500000f;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={1134};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={2};return array[index];
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

			return 4 * skill_level * skill_level + (34 * skill_level) + 200;
		}
	}
	public class GSkill3132 : GSkill
	{
		public GSkill3132()
			: base(3132)
		{
			
		}
	}
	public class GSkill3133Stub : GSkillStub
	{
		public class GState1 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 1000;
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
				int				skill_level = skill.GetLevel();

				skill.SetRatio(((skill_level - 15) * (norm(skill_level / 14.9f) * 0.03f) + (skill_level * 0.05f + 1.0f)));
				skill.SetPlus(354.0f);
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
				int				skill_level = skill.GetLevel();

				skill.SetRatio(((skill_level - 15) * (norm(skill_level / 14.9f) * 0.03f) + (skill_level * 0.05f + 1.0f)));
				skill.SetPlus(354.0f);
				player.SetPerform(0);
			}
		}
		public GSkill3133Stub()
			: base(3133)
		{
			occupation = 169;
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
			autoattack = true;
			allowform = 0;
			credittype = 0;
			clearmask = 4;
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
			weapon_limit = 7;
			SetAction(0," ﬁ…Ò_¬“»–");
			SetAction(1,"0");
			SetAction(2,"0");
			SetAction(3,"0");
			SetAction(4,"0");
			SetAction(5,"0");
			SetAction(6,"0");
			SetAction(7," ﬁ…Ò_¬“»–");
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
			SetAction(18," ﬁ…Ò_∆Ô≥À_¬“»–");
			SetAction(19,"0");
			SetAction(20,"0");
			SetAction(21,"0");
			SetAction(22,"0");
			SetAction(23,"0");
			SetAction(24,"0");
			SetAction(25," ﬁ…Ò_∆Ô≥À_¬“»–");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "¬“»–<Ï¯>";
			nativename = "¬“»–<Ï¯>";
			icon = "∑°§¬“»–.dds";
			SetTalent(0,2104);
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
			skill_class = 5;
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
			return 3000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			return 11000;
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
			return 10.000000f;
		}
		public override float GetAngle(GSkill skill)
		{
			return -0.999998f;
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

			return (5 * skill_level * skill_level + 1373);
		}
		public override int GetCoverage(GSkill skill)
		{
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();

			return (int)(2 * (skill_level / 4.99f) + skill_t0 + 4);
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();

			victim.SetProbability(120.0f);
			victim.SetRatio((skill_level * 0.02f + 0.15f));
			victim.SetValue(0.0f);
			victim.SetScopedamage(true);
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={1879};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={5};return array[index];
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
	public class GSkill3133 : GSkill
	{
		public GSkill3133()
			: base(3133)
		{
			
		}
	}
	public class GSkill3134Stub : GSkillStub
	{
		public class GState1 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 350;
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

				/*
				player.SetVar1(1);
				skill.SetRatio((skill_t1 * 0.01f + ((skill_level - 15) * (norm(skill_level / 14.9f) * 0.03f) + (skill_level * 0.05f + (skill_t0 * 0.02f + 1.02f)))));
				  if ( skill_t1 <= 0 )
				  {
				    skill.SetPlus(0.0f);
				  }
				  else
				  {
				skill.SetPlus(((10 * skill_t1 + 133)));
				  }
				player.SetPerform(1);
				*/
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
				return 225;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_res2 = player.GetRes2();
				int				skill_level = skill.GetLevel();
				int				skill_t0 = skill.GetT0();
				int				skill_t2 = skill.GetT2();

				/*
				player.SetVar1(2);
				player.SetVar2(player_res2);
				skill.SetRatio((skill_t2 * 0.01f + ((skill_level - 15) * (norm(skill_level / 14.9f) * 0.03f) + (skill_level * 0.05f + (skill_t0 * 0.02f + 1.02f)))));
				  if ( skill_t2 <= 0 )
				  {
				    skill.SetPlus(0.0f);
				  }
				  else
				  {
				skill.SetPlus(((21 * skill_t2 + 324)));
				  }
				player.SetPerform(0);
				*/
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
				int				player_res3 = player.GetRes3();
				int				skill_level = skill.GetLevel();
				int				skill_t0 = skill.GetT0();
				int				skill_t3 = skill.GetT3();

				/*
				player.SetVar1(3);
				player.SetVar3(player_res3);
				skill.SetRatio((skill_t3 * 0.01f + ((skill_level - 15) * (norm(skill_level / 14.9f) * 0.03f) + (skill_level * 0.05f + (skill_t0 * 0.02f + 1.02f)))));
				  if ( skill_t3 <= 0 )
				  {
				    skill.SetPlus(0.0f);
				  }
				  else
				  {
				skill.SetPlus(((33 * skill_t3 + 1043)));
				  }
				player.SetPerform(0);
				*/
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
				return 525;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_res1 = player.GetRes1();
				int				skill_level = skill.GetLevel();
				int				skill_t0 = skill.GetT0();
				int				skill_t4 = skill.GetT4();

				/*
				player.SetVar1(4);
				player.SetVar4(player_res1);
				skill.SetRatio((skill_t4 * 0.01f + ((skill_level - 15) * (norm(skill_level / 14.9f) * 0.03f) + (skill_level * 0.05f + (skill_t0 * 0.02f + 1.02f)))));
				  if ( skill_t4 <= 0 )
				  {
				    skill.SetPlus(0.0f);
				  }
				  else
				  {
				skill.SetPlus(((32 * skill_t4 + 1543)));
				  }
				player.SetPerform(0);
				*/
			}
		}
		public GSkill3134Stub()
			: base(3134)
		{
			occupation = 169;
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
			dobless = true;
			autoattack = true;
			allowform = 0;
			credittype = 0;
			clearmask = 4;
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
			weapon_limit = 7;
			SetAction(0," ﬁ…Ò_∞ÀÎ≈");
			SetAction(1,"0");
			SetAction(2,"0");
			SetAction(3,"0");
			SetAction(4,"0");
			SetAction(5,"0");
			SetAction(6,"0");
			SetAction(7," ﬁ…Ò_∞ÀÎ≈");
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
			SetAction(18," ﬁ…Ò_∆Ô≥À_∞ÀÎ≈");
			SetAction(19,"0");
			SetAction(20,"0");
			SetAction(21,"0");
			SetAction(22,"0");
			SetAction(23,"0");
			SetAction(24,"0");
			SetAction(25," ﬁ…Ò_∆Ô≥À_∞ÀÎ≈");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "∞ÀÎ≈<Ï¯>";
			nativename = "∞ÀÎ≈<Ï¯>";
			icon = "∑°§∞ÀÎ≈.dds";
			SetTalent(0,2084);
			SetTalent(1,1847);
			SetTalent(2,1856);
			SetTalent(3,1865);
			SetTalent(4,1874);
			SetTalent(5,0);
			SetTalent(6,0);
			SetTalent(7,0);
			talent_size = 5;
			talent_type = 0;
			use_proficiency = false;
			inc_proficiency = 0;
			preskillnum = 1;
			cycle = false;
			cyclemode = 0;
			cyclegfx = "";
			skill_class = 5;
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
		}
		public override int GetExecutetime(GSkill skill)
		{
			return 1000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			int				skill_t0 = skill.GetT0();
			int				skill_t1 = skill.GetT1();
			int				skill_t2 = skill.GetT2();
			int				skill_t3 = skill.GetT3();
			int				skill_t4 = skill.GetT4();

			return (int)(((((-1000 * skill_t0) - 1000 * (skill_t1 / 8.99f)) - 1000 * (skill_t2 / 8.99f)) - 1000 * (skill_t3 / 8.99f)) - 1000 * (skill_t4 / 8.99f) + 9600);
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
			return 7.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 3.000000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 15.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (8 * skill_level + 1376);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_var1 = player.GetVar1();
			int				player_var2 = player.GetVar2();
			int				player_var3 = player.GetVar3();
			int				player_var4 = player.GetVar4();
			int				skill_level = skill.GetLevel();
			int				skill_t1 = skill.GetT1();
			int				skill_t2 = skill.GetT2();
			int				skill_t3 = skill.GetT3();
			int				skill_t4 = skill.GetT4();

			/*
			if ( player_var1 == 1 )
			{
			if ( skill_t1 <= 0 )
			v39 = 0.0f;
			else
			d = 600.0f;
			}
			else
			{
			d = 0.0f;
			}
			victim.SetProbability(d);
			victim.SetTime(4000.0f);
			victim.SetRatio((skill_t1 * 0.05f + 0.15f));
			victim.SetBuffid(1);
			victim.SetSlow(true);
			if ( player_var1 == 2 )
			{
			v38 = D2INT(2 * skill_level + (skill_t2 * player_var2 / 9));
			}
			else
			{
			v38 = 0.0f;
			}
			victim.SetProbability(v38);
			victim.SetTime(4000.0f);
			victim.SetRatio(0.2f);
			victim.SetBuffid(1);
			victim.SetWeak(true);
			if ( player_var1 == 3 )
			{
			v37 = D2INT(2 * skill_level + (skill_t3 * player_var3 / 9));
			}
			else
			{
			v37 = 0.0f;
			}
			victim.SetProbability(v37);
			victim.SetTime(4000.0f);
			victim.SetWrap(true);
			if ( player_var1 == 4 )
			{
			v36 = D2INT(2 * skill_level + (skill_t4 * player_var4 / 9));
			}
			else
			{
			v36 = 0.0f;
			}
			victim.SetProbability(v36);
			victim.SetTime(4000.0f);
			victim.SetDizzy(true);
			*/
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_res4 = player.GetRes4();
			int				player_var1 = player.GetVar1();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();

			/*
			if ( player_var1 <= 1 )
			d = 0.0f;
			else
			victim.SetProbability(((10 * skill_t0)));
			victim.SetAmount(1.0f);
			victim.SetCleardebuff(true);
			victim.SetTime(((500 * skill_level + 2050)));
			victim.SetBuffid(2);
			victim.SetValue((player_res4 * (skill_level * 0.01f)));
			victim.SetAddantisilent(true);
			*/
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={1880};return array[index];
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

			return 3 * skill_level * skill_level + (42 * skill_level) + 170;
		}
	}
	public class GSkill3134 : GSkill
	{
		public GSkill3134()
			: base(3134)
		{
			
		}
	}
	public class GSkill3135Stub : GSkillStub
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
		public GSkill3135Stub()
			: base(3135)
		{
			occupation = 169;
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
			clearmask = 4;
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
			SetAction(0," ﬁ…Ò_ÚøªÍ");
			SetAction(1,"0");
			SetAction(2,"0");
			SetAction(3,"0");
			SetAction(4,"0");
			SetAction(5,"0");
			SetAction(6,"0");
			SetAction(7," ﬁ…Ò_ÚøªÍ");
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
			SetAction(18," ﬁ…Ò_∆Ô≥À_ÚøªÍ");
			SetAction(19,"0");
			SetAction(20,"0");
			SetAction(21,"0");
			SetAction(22,"0");
			SetAction(23,"0");
			SetAction(24,"0");
			SetAction(25," ﬁ…Ò_∆Ô≥À_ÚøªÍ");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "ÚøªÍ<Ï¯>";
			nativename = "ÚøªÍ<Ï¯>";
			icon = "∑°§ÚøªÍ.dds";
			SetTalent(0,2101);
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
			skill_class = 5;
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

			return 180000 - 20000 * skill_t0;
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

			return (12 * skill_level + 900);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();

			victim.SetProbability(120.0f);
			victim.SetTime(((2000 * skill_level + 10000)));
			victim.SetBuffid(1);
			victim.SetAmount((norm(skill_level / 19.9f) * 0.05f + (skill_level * 0.01f + 0.05f)));
			victim.SetValue((norm(skill_level / 19.9f) * 0.05f + (skill_level * 0.01f + 0.05f)));
			victim.SetChihun(true);
			victim.SetProbability(((5 * skill_level)));
			victim.SetTime(((1000 * skill_level + 2000)));
			victim.SetRatio((skill_level * 0.01f));
			victim.SetAttack2mp(true);
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={1881};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={2};return array[index];
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

			return 3 * skill_level * skill_level + (26 * skill_level) + 180;
		}
	}
	public class GSkill3135 : GSkill
	{
		public GSkill3135()
			: base(3135)
		{
			
		}
	}
	public class GSkill3136Stub : GSkillStub
	{
		public class GState1 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 200;
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
				return 725;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();

				player.SetVar1(1);
				skill.SetRatio(0.0f);
				skill.SetPlus(0.0f);
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
				return 200;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				skill_level = skill.GetLevel();
				int				skill_t1 = skill.GetT1();
				int				skill_t2 = skill.GetT2();

				/*
				player.SetVar1(2);
				skill.SetRatio(((skill_level - 15) * (norm(skill_level / 14.9f) * 0.03f) + (skill_level * 0.05f + 1.02f)));
				  v11 = 10 * skill_t1;
				  if ( skill_t1 <= 0 )
				    v12 = v11;
				  else
				    v12 = v11 + 133;
				  v10 = 21 * skill_t2;
				  if ( skill_t2 <= 0 )
				  {
				skill.SetPlus(((v10 + v12)));
				  }
				  else
				  {
				skill.SetPlus(((v10 + v12 + 324)));
				  }
				player.SetPerform(0);
				*/
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
				return 875;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				skill_level = skill.GetLevel();
				int				skill_t3 = skill.GetT3();
				int				skill_t4 = skill.GetT4();

				/*
				player.SetVar1(3);
				skill.SetRatio(((skill_level - 15) * (norm(skill_level / 14.9f) * 0.03f) + (skill_level * 0.05f + 1.02f)));
				  v11 = 33 * skill_t3;
				  if ( skill_t3 <= 0 )
				    v12 = v11;
				  else
				    v12 = v11 + 1043;
				  v10 = 32 * skill_t4;
				  if ( skill_t4 <= 0 )
				  {
				skill.SetPlus(((v10 + v12)));
				  }
				  else
				  {
				skill.SetPlus(((v10 + v12 + 1543)));
				  }
				player.SetPerform(0);
				*/
			}
		}
		public GSkill3136Stub()
			: base(3136)
		{
			occupation = 169;
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
			dobless = true;
			autoattack = true;
			allowform = 0;
			credittype = 0;
			clearmask = 4;
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
			weapon_limit = 7;
			SetAction(0," ﬁ…Ò_˜È’Ω");
			SetAction(1,"0");
			SetAction(2,"0");
			SetAction(3,"0");
			SetAction(4,"0");
			SetAction(5,"0");
			SetAction(6,"0");
			SetAction(7," ﬁ…Ò_˜È’Ω");
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
			SetAction(18," ﬁ…Ò_∆Ô≥À_˜È’Ω");
			SetAction(19,"0");
			SetAction(20,"0");
			SetAction(21,"0");
			SetAction(22,"0");
			SetAction(23,"0");
			SetAction(24,"0");
			SetAction(25," ﬁ…Ò_∆Ô≥À_˜È’Ω");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "˜È’Ω<Ï¯>";
			nativename = "˜È’Ω<Ï¯>";
			icon = "∑°§˜È’Ω.dds";
			SetTalent(0,2118);
			SetTalent(1,1850);
			SetTalent(2,1859);
			SetTalent(3,1868);
			SetTalent(4,1877);
			SetTalent(5,0);
			SetTalent(6,0);
			SetTalent(7,0);
			talent_size = 5;
			talent_type = 0;
			use_proficiency = false;
			inc_proficiency = 0;
			preskillnum = 1;
			cycle = false;
			cyclemode = 0;
			cyclegfx = "";
			skill_class = 5;
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
			int				skill_t0 = skill.GetT0();
			int				skill_t1 = skill.GetT1();
			int				skill_t2 = skill.GetT2();
			int				skill_t3 = skill.GetT3();
			int				skill_t4 = skill.GetT4();

            return (int)(((((-1000 * skill_t0) - 1000 * (skill_t1 / 8.99f)) - 1000 * (skill_t2 / 8.99f)) - 1000 * (skill_t3 / 8.99f)) - 1000 * (skill_t4 / 8.99f) + 12000);
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
			return 3.000000f;
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

			return (16 * skill_level + 877);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_var1 = player.GetVar1();
			int				skill_t1 = skill.GetT1();
			int				skill_t2 = skill.GetT2();
			int				skill_t3 = skill.GetT3();
			int				skill_t4 = skill.GetT4();

			/*
			if ( player_var1 == 2 )
			{
			if ( skill_t1 <= 0 )
			v37 = 0.0f;
			else
			d = 600.0f;
			}
			else
			{
			d = 0.0f;
			}
			victim.SetProbability(d);
			if ( zrand(100) >= 5 * skill_t1 + 15 )
			t = 400.0f;
			else
			victim.SetTime(4000.0f);
			victim.SetSilent(true);
			if ( player_var1 == 2 )
			{
			if ( skill_t2 <= 0 )
			v34 = 0.0f;
			else
			v35 = 120.0f;
			}
			else
			{
			v35 = 0.0f;
			}
			victim.SetProbability(v35);
			victim.SetTime(8000.0f);
			victim.SetBuffid(1);
			victim.SetValue(((2 * (skill_t2 * skill_t2 + (5 * skill_t2)) + 60)));
			victim.SetSubdefence(true);
			if ( player_var1 == 3 )
			{
			if ( skill_t3 <= 0 )
			v32 = 0.0f;
			else
			v33 = 120.0f;
			}
			else
			{
			v33 = 0.0f;
			}
			victim.SetProbability(v33);
			victim.SetTime(8000.0f);
			victim.SetBuffid(1);
			if ( player_var1 == 3 )
			{
			if ( skill_t3 <= 0 )
			v30 = 0.0f;
			else
			v31 = ((5 * skill_t3 + 35));
			}
			else
			{
			v31 = 0.0f;
			}
			victim.SetValue(v31);
			victim.SetSubanti(true);
			if ( player_var1 == 3 )
			{
			if ( skill_t4 <= 0 )
			v28 = 0.0f;
			else
			v29 = ((5 * skill_t4 + 35));
			}
			else
			{
			v29 = 0.0f;
			}
			victim.SetProbability(v29);
			victim.SetTime(8000.0f);
			victim.SetBarehanded(true);
			*/
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_var1 = player.GetVar1();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();

			/*
			victim.SetTime(3000.0f);
			if ( player_var1 == 1 )
			{
			if ( zrand(100) >= 34 * skill_t0 )
			v22 = 0.0f;
			else
			d = 1.0f;
			}
			else
			{
			d = 0.0f;
			}
			victim.SetValue(d);
			victim.SetBlessed(true);
			if ( skill_t0 <= 0 )
			{
			v21 = 0.0f;
			}
			else
			{
			if ( player_var1 == 1 )
			v20 = 120.0f;
			else
			v21 = 0.0f;
			}
			victim.SetProbability(v21);
			victim.SetTime(((2000 * skill_t0 + 2000)));
			victim.SetRatio((skill_level * 0.04f));
			victim.SetAmount(0.0f);
			victim.SetValue(100.0f);
			victim.SetRetort(true);
			victim.SetProbability(((4 * skill_level + 15)));
			victim.SetClearweak(true);
			*/
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={1882};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={5};return array[index];
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

			return 3 * skill_level * skill_level + (42 * skill_level) + 170;
		}
	}
	public class GSkill3136 : GSkill
	{
		public GSkill3136()
			: base(3136)
		{
			
		}
	}
	public class GSkill3137Stub : GSkillStub
	{
		public class GState1 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 1133;
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
				return 2000;
			}
			public override void Calculate(GSkill skill)
			{
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
				return 100;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_maxatk = player.GetMaxatk();
				int				skill_level = skill.GetLevel();
				int				skill_t0 = skill.GetT0();
				int				skill_charging = skill.GetCharging();

				/*
				  if ( skill_charging <= 0xFA )
				  {
				    skill.SetCrithurt(0.0f);
				  }
				  else
				  {
				skill.SetCrithurt((skill_level * 0.03f * (skill_charging * 0.0005f)));
				  }
				  if ( skill_charging <= 0xFA )
				    v = 0;
				  else
				    v = skill_charging;
				player.SetVar3(v);
				player.SetVar2(player_maxatk);
				  if ( skill_charging <= 0xFA )
				  {
				    skill.SetCrit(0.0f);
				  }
				  else
				  {
				skill.SetCrit((skill_level * 0.01f * (skill_charging * 0.0005f)));
				  }
				player.SetVar1(1);
				v20 = skill_t0 * 0.01f + ((skill_level - 15) * (norm(skill_level / 14.9f) * 0.03f) + ((0.05f * skill_level) + 1.02f));
				  if ( skill_charging <= 0xFA )
				  {
				    v19 = v20 + 0.0f;
				  }
				  else
				  {
				v19 = (skill_level * 0.05f + 0.5f) * (skill_charging * 0.0005f) + v20;
				  }
				skill.SetRatio(v19);
				skill.SetPlus(((9 * skill_level + 515)));
				player.SetPerform(1);
				*/
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
				return 100;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_maxatk = player.GetMaxatk();
				int				skill_level = skill.GetLevel();
				int				skill_t0 = skill.GetT0();
				int				skill_charging = skill.GetCharging();

				/*
				  if ( skill_charging <= 0xFA )
				  {
				    skill.SetCrithurt(0.0f);
				  }
				  else
				  {
				skill.SetCrithurt((skill_level * 0.03f * (skill_charging * 0.0005f)));
				  }
				  if ( skill_charging <= 0xFA )
				    v = 0;
				  else
				    v = skill_charging;
				player.SetVar3(v);
				player.SetVar2(player_maxatk);
				  if ( skill_charging <= 0xFA )
				  {
				    skill.SetCrit(0.0f);
				  }
				  else
				  {
				skill.SetCrit((skill_level * 0.01f * (skill_charging * 0.0005f)));
				  }
				player.SetVar1(2);
				v20 = skill_t0 * 0.01f + ((skill_level - 15) * (norm(skill_level / 14.9f) * 0.03f) + ((0.05f * skill_level) + 1.02f));
				  if ( skill_charging <= 0xFA )
				  {
				    v19 = v20 + 0.0f;
				  }
				  else
				  {
				v19 = (skill_level * 0.05f + 0.5f) * (skill_charging * 0.0005f) + v20;
				  }
				skill.SetRatio(v19);
				skill.SetPlus(((9 * skill_level + 515)));
				player.SetPerform(0);
				*/
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
				return 667;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_maxatk = player.GetMaxatk();
				int				skill_level = skill.GetLevel();
				int				skill_t0 = skill.GetT0();
				int				skill_t1 = skill.GetT1();
				int				skill_charging = skill.GetCharging();

				/*
				  if ( skill_charging <= 0xFA )
				  {
				    skill.SetCrithurt(0.0f);
				  }
				  else
				  {
				skill.SetCrithurt((skill_level * 0.03f * (skill_charging * 0.0005f)));
				  }
				  if ( skill_charging <= 0xFA )
				    v = 0;
				  else
				    v = skill_charging;
				player.SetVar3(v);
				player.SetVar2(player_maxatk);
				  if ( skill_charging <= 0xFA )
				  {
				    v22 = 0.0f;
				  }
				  else
				  {
				v22 = skill_level * 0.01f * (0.0005f * skill_charging);
				  }
				  if ( skill_t1 <= 2.9f )
				    v21 = v22 + 0.0f;
				  else
				skill.SetCrit((v22 + 0.1f));
				player.SetVar1(3);
				v20 = skill_t0 * 0.01f + ((skill_level - 15) * (norm(skill_level / 14.9f) * 0.03f) + ((0.05f * skill_level) + 1.02f));
				  if ( skill_charging <= 0xFA )
				  {
				    v19 = v20 + 0.0f;
				  }
				  else
				  {
				v19 = (skill_level * 0.05f + 0.5f) * (skill_charging * 0.0005f) + v20;
				  }
				skill.SetRatio(v19);
				skill.SetPlus(((9 * skill_level + 515)));
				player.SetPerform(0);
				*/
			}
		}
		public GSkill3137Stub()
			: base(3137)
		{
			occupation = 169;
			maxlevel = 20;
			maxlearn = 20;
			eventflag = 0;
			spcost = 0;
			reborncount = 0;
			type = 1;
			timetype = 3;
			targettype = 0;
			rangetype = 0;
			doenchant = true;
			dobless = false;
			autoattack = true;
			allowform = 0;
			credittype = 0;
			clearmask = 4;
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
			weapon_limit = 8;
			SetAction(0,"∫¸—˝_»˝‘∆¡˙");
			SetAction(1,"0");
			SetAction(2,"0");
			SetAction(3,"0");
			SetAction(4,"0");
			SetAction(5,"0");
			SetAction(6,"0");
			SetAction(7,"0");
			SetAction(8,"∫¸—˝_»˝‘∆¡˙");
			SetAction(9,"0");
			SetAction(10,"0");
			SetAction(11,"0");
			SetAction(12,"0");
			SetAction(13,"");
			SetAction(14,"");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"∫¸—˝_∆Ô≥À_»˝‘∆¡˙");
			SetAction(19,"0");
			SetAction(20,"0");
			SetAction(21,"0");
			SetAction(22,"0");
			SetAction(23,"0");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"∫¸—˝_∆Ô≥À_»˝‘∆¡˙");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "»˝‘∆¡˙<Ï¯>";
			nativename = "»˝‘∆¡˙<Ï¯>";
			icon = "∑°§»˝‘∆¡˙.dds";
			SetTalent(0,2142);
			SetTalent(1,2147);
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
			skill_class = 6;
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
		}
		public override int GetExecutetime(GSkill skill)
		{
			return 4000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			int				skill_t1 = skill.GetT1();

			return 12000 - 2000 * skill_t1;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={120,122,124,126,128,130,131,132,133,134,135,136,137,138,139,141,143,145,147,149};return array[level-1];
		}
		public override float GetPraydistance(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return ((3 * norm(skill_level / 19.9f)) + (skill_level * 0.2f + 30.0f));
		}
		public override float GetCastdistance(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return ((3 * norm(skill_level / 19.9f)) + (skill_level * 0.2f + 20.0f));
		}
		public override float GetEffectdistance(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return ((3 * norm(skill_level / 19.9f)) + (skill_level * 0.2f + 40.0f));
		}
		public override float GetMpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (16 * skill_level + 985);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_var1 = player.GetVar1();
			int				player_var2 = player.GetVar2();
			int				player_var3 = player.GetVar3();
			int				skill_level = skill.GetLevel();
			int				skill_t1 = skill.GetT1();

			/*
			if ( player_var1 == 1 )
			{
			if ( skill_t1 <= 0.9f )
			v29 = 0.0f;
			else
			d = 600.0f;
			}
			else
			{
			d = 0.0f;
			}
			victim.SetProbability(d);
			victim.SetTime(5000.0f);
			victim.SetRatio(0.40000001f);
			victim.SetBuffid(1);
			victim.SetWeak(true);
			if ( player_var1 == 2 )
			{
			if ( skill_t1 <= 1.9f )
			v27 = 0.0f;
			else
			v28 = 600.0f;
			}
			else
			{
			v28 = 0.0f;
			}
			victim.SetProbability(v28);
			victim.SetTime(5000.0f);
			victim.SetRatio(0.40000001f);
			victim.SetBuffid(1);
			victim.SetSlow(true);
			victim.SetProbability(100.0f);
			victim.SetTime((player_var3 * 0.0005f * 10.0f * 500.0f + ((300 * skill_level + 2000))));
			victim.SetBuffid(2);
			victim.SetAmount(1000.0f);
			victim.SetValue((skill_level * (player_var2 * 0.1f)));
			victim.SetSubhp(true);
			*/
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={1919};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={5};return array[index];
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
	public class GSkill3137 : GSkill
	{
		public GSkill3137()
			: base(3137)
		{
			
		}
	}
	public class GSkill3138Stub : GSkillStub
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
		public GSkill3138Stub()
			: base(3138)
		{
			occupation = 169;
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
			dobless = true;
			autoattack = false;
			allowform = 0;
			credittype = 0;
			clearmask = 4;
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
			SetAction(0,"∫¸—˝_¥ÛÙ‡Õı");
			SetAction(1,"0");
			SetAction(2,"0");
			SetAction(3,"0");
			SetAction(4,"0");
			SetAction(5,"0");
			SetAction(6,"0");
			SetAction(7,"0");
			SetAction(8,"∫¸—˝_¥ÛÙ‡Õı");
			SetAction(9,"0");
			SetAction(10,"0");
			SetAction(11,"0");
			SetAction(12,"0");
			SetAction(13,"");
			SetAction(14,"");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"∫¸—˝_∆Ô≥À_¥ÛÙ‡Õı");
			SetAction(19,"0");
			SetAction(20,"0");
			SetAction(21,"0");
			SetAction(22,"0");
			SetAction(23,"0");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"∫¸—˝_∆Ô≥À_¥ÛÙ‡Õı");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "¥ÛÙ‡Õı<Ï¯>";
			nativename = "¥ÛÙ‡Õı<Ï¯>";
			icon = "∑°§¥ÛÙ‡Õı.dds";
			SetTalent(0,2135);
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
			skill_class = 6;
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

			return (skill_level * skill_level + (16 * skill_level) + 1680);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_res1 = player.GetRes1();
			int				skill_level = skill.GetLevel();

			victim.SetProbability(120.0f);
			victim.SetTime(((1000 * skill_level + 7000)));
			victim.SetRatio((skill_level * 0.03f + 0.25f));
			victim.SetBuffid(1);
			victim.SetIncskillaccu(true);
			victim.SetTime(((1000 * skill_level + 7000)));
			victim.SetRatio((skill_level * 0.02f + 0.001f));
			victim.SetInccritrate(true);
			victim.SetTime(((1000 * skill_level + 7000)));
			victim.SetRatio((skill_level * 0.03f));
			victim.SetBuffid(1);
			victim.SetIncskilldamage(true);
			victim.SetTime(((1000 * skill_level + 7000)));
			victim.SetBuffid(1);
			victim.SetValue((skill_level * (player_res1 * 0.01f)));
			victim.SetAddantidizzy(true);
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={1920};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={2};return array[index];
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
	public class GSkill3138 : GSkill
	{
		public GSkill3138()
			: base(3138)
		{
			
		}
	}
	public class GSkill3139Stub : GSkillStub
	{
		public class GState1 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 667;
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
				return 2000;
			}
			public override void Calculate(GSkill skill)
			{
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
				return 333;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				skill_level = skill.GetLevel();
				int				skill_charging = skill.GetCharging();

				/*
				  if ( skill_charging <= 0xFA )
				  {
				    skill.SetCrithurt(0.0f);
				  }
				  else
				  {
				skill.SetCrithurt((skill_level * 0.03f * (skill_charging * 0.0005f)));
				  }
				  if ( skill_charging <= 0xFA )
				  {
				    skill.SetCrit(0.0f);
				  }
				  else
				  {
				skill.SetCrit((skill_level * 0.01f * (skill_charging * 0.0005f)));
				  }
				v13 = (skill_level - 15) * (norm(skill_level / 14.9f) * 0.03f) + ((0.05f * skill_level) + 1.02f);
				  if ( skill_charging <= 0xFA )
				  {
				    v12 = v13 + 0.0f;
				  }
				  else
				  {
				v12 = (skill_level * 0.1f + 0.5f) * (skill_charging * 0.0005f) + v13;
				  }
				skill.SetRatio(v12);
				skill.SetPlus(834.0f);
				player.SetPerform(1);
				*/
			}
		}
		public GSkill3139Stub()
			: base(3139)
		{
			occupation = 169;
			maxlevel = 20;
			maxlearn = 20;
			eventflag = 0;
			spcost = 0;
			reborncount = 0;
			type = 1;
			timetype = 3;
			targettype = 0;
			rangetype = 0;
			doenchant = true;
			dobless = false;
			autoattack = true;
			allowform = 0;
			credittype = 0;
			clearmask = 4;
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
			weapon_limit = 8;
			SetAction(0,"∫¸—˝_¬÷ªÿ…¡");
			SetAction(1,"0");
			SetAction(2,"0");
			SetAction(3,"0");
			SetAction(4,"0");
			SetAction(5,"0");
			SetAction(6,"0");
			SetAction(7,"0");
			SetAction(8,"∫¸—˝_¬÷ªÿ…¡");
			SetAction(9,"0");
			SetAction(10,"0");
			SetAction(11,"0");
			SetAction(12,"0");
			SetAction(13,"");
			SetAction(14,"");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"∫¸—˝_∆Ô≥À_¬÷ªÿ…¡");
			SetAction(19,"0");
			SetAction(20,"0");
			SetAction(21,"0");
			SetAction(22,"0");
			SetAction(23,"0");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"∫¸—˝_∆Ô≥À_¬÷ªÿ…¡");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "¬÷ªÿ…¡<Ï¯>";
			nativename = "¬÷ªÿ…¡<Ï¯>";
			icon = "∑°§¬÷ªÿ…¡.dds";
			SetTalent(0,2153);
			SetTalent(1,2158);
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
			skill_class = 6;
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
			return 3000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();

			return (-1000 * skill_level) - 5000 * skill_t0 + 40000;
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
			int				skill_level = skill.GetLevel();

			return ((5 * norm(skill_level / 19.9f)) + (skill_level * 0.5f + 30.0f));
		}
		public override float GetCastdistance(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return ((5 * norm(skill_level / 19.9f)) + (skill_level * 0.5f + 20.0f));
		}
		public override float GetEffectdistance(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return ((5 * norm(skill_level / 19.9f)) + (skill_level * 0.5f + 40.0f));
		}
		public override float GetMpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (14 * skill_level + 866);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_level = player.GetLevel();
			int				player_hp = player.GetHp();
			int				player_maxhp = player.GetMaxhp();
			int				player_mp = player.GetMp();
			int				player_maxmp = player.GetMaxmp();
			int				player_reborncount = player.GetReborncount();
			int				skill_level = skill.GetLevel();
			int				skill_t1 = skill.GetT1();

			victim.SetProbability(((4 * skill_level + 20)));
			victim.SetTime(((2000 * skill_t1 + 6000)));
			victim.SetBuffid(1);
			victim.SetAmount((((50 * player_reborncount + 50) * player_level)));
			victim.SetValue(((player_maxhp - player_hp)));
			victim.SetSubhp(true);
			victim.SetProbability(-1.0f);
			victim.SetTime(((2000 * skill_t1 + 6000)));
			victim.SetBuffid(1);
			victim.SetAmount((((50 * player_reborncount + 50) * player_level)));
			victim.SetValue(((player_maxmp - player_mp)));
			victim.SetSubmp(true);
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={1921};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={5};return array[index];
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

			return 3 * skill_level * skill_level + (42 * skill_level) + 170;
		}
	}
	public class GSkill3139 : GSkill
	{
		public GSkill3139()
			: base(3139)
		{
			
		}
	}
}
