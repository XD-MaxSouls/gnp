using System;
using System.Text;

namespace SKILL
{
	public class GSkill3080Stub : GSkillStub
	{
		public class GState1 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 1225;
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
				return 225;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_res4 = player.GetRes4();
				int				skill_level = skill.GetLevel();
				int				skill_t0 = skill.GetT0();
				int				skill_t2 = skill.GetT2();

				player.SetVar2(1);
				player.SetVar1(player_res4);
				skill.SetCrit((skill_t2 * 0.01f));
				skill.SetCrithurt((skill_t2 * 0.1f));
				skill.SetRatio((skill_t0 * 0.05f + ((skill_level - 15) * (norm(skill_level / 14.9f) * 0.03f) + (skill_level * 0.05f + 1.0f))));
				skill.SetPlus(((4 * skill_level * skill_level + (29 * skill_level) + 850)));
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
				return 225;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_res4 = player.GetRes4();
				int				skill_level = skill.GetLevel();
				int				skill_t0 = skill.GetT0();
				int				skill_t2 = skill.GetT2();

				player.SetVar2(0);
				player.SetVar1(player_res4);
				skill.SetCrit((skill_t2 * 0.01f));
				skill.SetCrithurt((skill_t2 * 0.1f));
				skill.SetRatio((skill_t0 * 0.05f + ((skill_level - 15) * (norm(skill_level / 14.9f) * 0.03f) + (skill_level * 0.05f + 1.0f))));
				skill.SetPlus(((4 * skill_level * skill_level + (29 * skill_level) + 850)));
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
				return 200;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_res4 = player.GetRes4();
				int				skill_level = skill.GetLevel();
				int				skill_t0 = skill.GetT0();
				int				skill_t2 = skill.GetT2();

				player.SetVar2(0);
				player.SetVar1(player_res4);
				skill.SetCrit((skill_t2 * 0.01f));
				skill.SetCrithurt((skill_t2 * 0.1f));
				skill.SetRatio((skill_t0 * 0.05f + ((skill_level - 15) * (norm(skill_level / 14.9f) * 0.03f) + (skill_level * 0.05f + 1.0f))));
				skill.SetPlus(((4 * skill_level * skill_level + (29 * skill_level) + 850)));
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
				return 125;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_res4 = player.GetRes4();
				int				skill_level = skill.GetLevel();
				int				skill_t0 = skill.GetT0();
				int				skill_t2 = skill.GetT2();

				player.SetVar2(0);
				player.SetVar1(player_res4);
				skill.SetCrit((skill_t2 * 0.01f));
				skill.SetCrithurt((skill_t2 * 0.1f));
				skill.SetRatio((skill_t0 * 0.05f + ((skill_level - 15) * (norm(skill_level / 14.9f) * 0.03f) + (skill_level * 0.05f + 1.0f))));
				skill.SetPlus(((4 * skill_level * skill_level + (29 * skill_level) + 850)));
				player.SetPerform(0);
			}
		}
		public GSkill3080Stub()
			: base(3080)
		{
			occupation = 168;
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
			clearmask = 2;
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
			SetAction(0,"∫œª∂_∑Áª®—©‘¬");
			SetAction(1,"∫œª∂_∑Áª®—©‘¬");
			SetAction(2,"∫œª∂_∑Áª®—©‘¬");
			SetAction(3,"∫œª∂_∑Áª®—©‘¬");
			SetAction(4,"∫œª∂_∑Áª®—©‘¬");
			SetAction(5,"∫œª∂_∑Áª®—©‘¬");
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
			SetAction(18,"∫œª∂_∆Ô≥À_∑Áª®—©‘¬");
			SetAction(19,"∫œª∂_∆Ô≥À_∑Áª®—©‘¬");
			SetAction(20,"∫œª∂_∆Ô≥À_∑Áª®—©‘¬");
			SetAction(21,"∫œª∂_∆Ô≥À_∑Áª®—©‘¬");
			SetAction(22,"∫œª∂_∆Ô≥À_∑Áª®—©‘¬");
			SetAction(23,"∫œª∂_∆Ô≥À_∑Áª®—©‘¬");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "∑Áª®—©‘¬<…∑>";
			nativename = "∑Áª®—©‘¬<…∑>";
			icon = "ƒß°§∑Áª®—©‘¬.dds";
			SetTalent(0,742);
			SetTalent(1,749);
			SetTalent(2,753);
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
			skill_class = 1;
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
			int				skill_t1 = skill.GetT1();

			return 16000 - 3200 * skill_t1;
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
			return 9.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 1.700000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 13.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (21 * skill_level + (3 * skill_level * skill_level) + 950);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_level = player.GetLevel();
			int				player_hp = player.GetHp();
			int				player_maxhp = player.GetMaxhp();
			int				player_maxmp = player.GetMaxmp();
			int				player_var1 = player.GetVar1();
			int				skill_level = skill.GetLevel();

			/*
			victim.SetProbability(((skill_level * 0.02f + 0.6f) * player_var1));
			victim.SetTime(4100.0f);
			victim.SetSilent(true);
			victim.SetProbability(((1.0f - player_level * 0.002f) * 100.0f));
			victim.SetTime(120000.0f);
			victim.SetBuffid(1);
			victim.SetAmount((skill_level * (player_maxmp * 0.01f * 60.0f)));
			victim.SetValue(0.0f);
			victim.SetMpleak(true);
			victim.SetProbability(((600 * norm(zrand(100) / 67))));
			victim.SetTime(12100.0f);
			victim.SetRatio(0.25f);
			victim.SetBuffid(1);
			victim.SetSlow(true);
			victim.SetProbability(650.0f);
			if ( player_maxhp * 0.6f <= player_hp )
			t = 0.0f;
			else
			victim.SetTime(((500 * skill_level)));
			victim.SetWrap(true);
			*/
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_mp = player.GetMp();
			int				player_var2 = player.GetVar2();

			victim.SetProbability(25.0f);
			victim.SetRatio(0.0f);
			victim.SetValue((player_mp * 0.05f));
			victim.SetHeal(true);
			victim.SetProbability(((120 * player_var2)));
			victim.SetRatio(293.0f);
			victim.SetBuffid(0);
			victim.SetAmount(0.0f);
			victim.SetValue(2000.0f);
			victim.SetReduceskillcd(true);
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={782};return array[index];
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
	public class GSkill3080 : GSkill
	{
		public GSkill3080()
			: base(3080)
		{
			
		}
	}
	public class GSkill3081Stub : GSkillStub
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
				int				skill_level = skill.GetLevel();
				int				skill_t1 = skill.GetT1();
				int				skill_t3 = skill.GetT3();
				int				skill_t4 = skill.GetT4();

				skill.SetRatio((norm((zrand(5 * skill_t1 + 100)) / 100) * (skill_t1 * 0.06f) + (skill_t4 * 0.02f + (skill_t1 * 0.06f + ((skill_level - 15) * (norm(skill_level / 14.9f) * 0.03f) + (skill_level * 0.05f + 1.0f))))));
				skill.SetCrit((skill_t3 * 0.01f));
				skill.SetCrithurt((skill_t3 * 0.1f + (skill_level * 0.05f)));
				skill.SetPlus(((2 * (skill_level * skill_level + (25 * skill_level)) + 750)));
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
				int				skill_level = skill.GetLevel();
				int				skill_t1 = skill.GetT1();
				int				skill_t3 = skill.GetT3();
				int				skill_t4 = skill.GetT4();

				skill.SetRatio((norm((zrand(5 * skill_t1 + 100)) / 100) * (skill_t1 * 0.06f) + (skill_t4 * 0.02f + (skill_t1 * 0.06f + ((skill_level - 15) * (norm(skill_level / 14.9f) * 0.03f) + (skill_level * 0.05f + 1.0f))))));
				skill.SetCrit((skill_t3 * 0.01f));
				skill.SetCrithurt((skill_t3 * 0.1f + (skill_level * 0.05f)));
				skill.SetPlus(((2 * (skill_level * skill_level + (25 * skill_level)) + 750)));
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
				int				player_level = player.GetLevel();
				int				skill_level = skill.GetLevel();
				int				skill_t1 = skill.GetT1();
				int				skill_t3 = skill.GetT3();
				int				skill_t4 = skill.GetT4();

				skill.SetRatio((norm((zrand(5 * skill_t1 + 100)) / 100) * (skill_t1 * 0.06f) + (skill_t1 * 0.06f + ((3 * norm(zrand(108) / 100.0f)) + (skill_t4 * 0.02f + ((skill_level - 15) * (norm(skill_level / 14.9f) * 0.03f) + (skill_level * 0.05f + 1.0f)))))));
				skill.SetCrit((skill_t3 * 0.01f));
				skill.SetCrithurt((skill_t3 * 0.1f + (skill_level * 0.05f)));
				skill.SetPlus(((2 * (skill_level * player_level + (skill_level * skill_level + (25 * skill_level))) + 750)));
				player.SetPerform(0);
			}
		}
		public GSkill3081Stub()
			: base(3081)
		{
			occupation = 168;
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
			allowform = 1;
			credittype = 0;
			clearmask = 2;
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
			SetAction(0,"πÌµ¿_√ªÍøÒÏ≠");
			SetAction(1,"πÌµ¿_√ªÍøÒÏ≠");
			SetAction(2,"πÌµ¿_√ªÍøÒÏ≠");
			SetAction(3,"πÌµ¿_√ªÍøÒÏ≠");
			SetAction(4,"πÌµ¿_√ªÍøÒÏ≠");
			SetAction(5,"πÌµ¿_√ªÍøÒÏ≠");
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
			SetAction(18,"πÌµ¿_∆Ô≥À_√ªÍøÒÏ≠");
			SetAction(19,"πÌµ¿_∆Ô≥À_√ªÍøÒÏ≠");
			SetAction(20,"πÌµ¿_∆Ô≥À_√ªÍøÒÏ≠");
			SetAction(21,"πÌµ¿_∆Ô≥À_√ªÍøÒÏ≠");
			SetAction(22,"πÌµ¿_∆Ô≥À_√ªÍøÒÏ≠");
			SetAction(23,"πÌµ¿_∆Ô≥À_√ªÍøÒÏ≠");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "√ªÍøÒÏ≠<…∑>";
			nativename = "√ªÍøÒÏ≠<…∑>";
			icon = "ƒß°§√ªÍøÒÏ≠.dds";
			SetTalent(0,1151);
			SetTalent(1,1153);
			SetTalent(2,1154);
			SetTalent(3,1155);
			SetTalent(4,1543);
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
		}
		public override int GetExecutetime(GSkill skill)
		{
			return 2000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			int				skill_t0 = skill.GetT0();
			int				skill_t4 = skill.GetT4();

			return (-1950 * skill_t0) - 650 * skill_t4 + 13000;
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
			return 20.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 15.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (5 * skill_level * skill_level + (80 * skill_level) + 800);
		}
		public override int GetCoverage(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return D2INT(skill_level / 2) + 6;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();
			int				skill_t2 = skill.GetT2();

			victim.SetProbability(100.0f);
			victim.SetRatio((skill_level * 0.01f));
			victim.SetDrainmagic(true);
			victim.SetProbability(((skill_level * skill_level + (6 * skill_level) + 170)));
			victim.SetTime(12100.0f);
			victim.SetRatio(0.15000001f);
			victim.SetBuffid(1);
			victim.SetWeak(true);
			victim.SetProbability(((650 * norm(zrand(100) / (100 - 2 * skill_t2)))));
			victim.SetTime(((2050 * skill_t2)));
			victim.SetDizzy(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();

			victim.SetProbability(100.0f);
			victim.SetTime(6100.0f);
			victim.SetBuffid(1);
			victim.SetValue(((15 * skill_level)));
			victim.SetAdddodge(true);
			victim.SetTime(((500 * skill_level + 2050)));
			victim.SetImmunesleep(true);
			return true;
		}
		public override float GetDropRate(GSkill skill)
		{
			return 0.500000f;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={1131};return array[index];
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
	public class GSkill3081 : GSkill
	{
		public GSkill3081()
			: base(3081)
		{
			
		}
	}
	public class GSkill3082Stub : GSkillStub
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
		public GSkill3082Stub()
			: base(3082)
		{
			occupation = 168;
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
			clearmask = 2;
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
			name = "–∞…Ò∞¡ ¿<…∑>";
			nativename = "–∞…Ò∞¡ ¿<…∑>";
			icon = "ƒß°§–∞…Ò∞¡ ¿.dds";
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
			victim.SetRatio((skill_level * 0.03f));
			victim.SetBuffid(5);
			victim.SetInccrithurt(true);
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
	public class GSkill3082 : GSkill
	{
		public GSkill3082()
			: base(3082)
		{
			
		}
	}
	public class GSkill3083Stub : GSkillStub
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
				int				player_res4 = player.GetRes4();
				int				skill_level = skill.GetLevel();
				int				skill_t0 = skill.GetT0();
				int				skill_t1 = skill.GetT1();

				player.SetVar1(player_res4);
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
				int				player_res4 = player.GetRes4();
				int				skill_level = skill.GetLevel();
				int				skill_t0 = skill.GetT0();
				int				skill_t1 = skill.GetT1();

				player.SetVar1(player_res4);
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
				int				player_res4 = player.GetRes4();
				int				skill_level = skill.GetLevel();
				int				skill_t0 = skill.GetT0();
				int				skill_t1 = skill.GetT1();

				player.SetVar1(player_res4);
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
				int				player_res4 = player.GetRes4();
				int				skill_level = skill.GetLevel();
				int				skill_t0 = skill.GetT0();
				int				skill_t1 = skill.GetT1();

				player.SetVar1(player_res4);
				skill.SetRatio((skill_t1 * 0.05f + (skill_level * 0.03f + 1.0f)));
				skill.SetCrit((skill_level * 0.01f + 0.03f));
				skill.SetCrithurt(1.0f);
				skill.SetPlus(((2 * skill_level * skill_level) + ((45 * skill_level) + ((35 * skill_t0 * skill_level) + ((norm(skill_level / 19.9f) + (skill_level * 0.1f)) * player_res1) + 860.0f))));
				player.SetPerform(0);
			}
		}
		public GSkill3083Stub()
			: base(3083)
		{
			occupation = 168;
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
			clearmask = 2;
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
			name = "…ÒπÌ¬“ŒË<…∑>";
			nativename = "…ÒπÌ¬“ŒË<…∑>";
			icon = "ƒß°§…ÒπÌ¬“ŒË.dds";
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
	public class GSkill3083 : GSkill
	{
		public GSkill3083()
			: base(3083)
		{
			
		}
	}
	public class GSkill3084Stub : GSkillStub
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
		public GSkill3084Stub()
			: base(3084)
		{
			occupation = 168;
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
			clearmask = 2;
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
			name = "ÃÏ—°µ¿‘π<…∑>";
			nativename = "ÃÏ—°µ¿‘π<…∑>";
			icon = "ƒß°§ÃÏ—°µ¿‘π.dds";
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
			victim.SetProbability(((15 * norm(skill_level / 19.9f) + (2 * skill_level) + 10)));
			victim.SetAmount(((norm(skill_level / 19.9f) + 1)));
			victim.SetCleardebuff(true);
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
	public class GSkill3084 : GSkill
	{
		public GSkill3084()
			: base(3084)
		{
			
		}
	}
	public class GSkill3085Stub : GSkillStub
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
		public GSkill3085Stub()
			: base(3085)
		{
			occupation = 168;
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
			clearmask = 2;
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
			name = "¬“»–<…∑>";
			nativename = "¬“»–<…∑>";
			icon = "ƒß°§¬“»–.dds";
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
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();

			victim.SetProbability(((5 * skill_level)));
			victim.SetTime(((500 * skill_level + 2050)));
			victim.SetRatio((skill_level * 0.03f));
			victim.SetBuffid(1);
			victim.SetDecdrugeffect(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();

			victim.SetProbability(120.0f);
			victim.SetRatio((skill_level * 0.02f + 0.1f));
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
	public class GSkill3085 : GSkill
	{
		public GSkill3085()
			: base(3085)
		{
			
		}
	}
	public class GSkill3086Stub : GSkillStub
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
		public GSkill3086Stub()
			: base(3086)
		{
			occupation = 168;
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
			clearmask = 2;
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
			name = "∞ÀÎ≈<…∑>";
			nativename = "∞ÀÎ≈<…∑>";
			icon = "ƒß°§∞ÀÎ≈.dds";
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
			int				player_res5 = player.GetRes5();
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
			victim.SetValue((player_res5 * (skill_level * 0.01f)));
			victim.SetAddantisleep(true);
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
	public class GSkill3086 : GSkill
	{
		public GSkill3086()
			: base(3086)
		{
			
		}
	}
	public class GSkill3087Stub : GSkillStub
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
		public GSkill3087Stub()
			: base(3087)
		{
			occupation = 168;
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
			clearmask = 2;
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
			name = "ÚøªÍ<…∑>";
			nativename = "ÚøªÍ<…∑>";
			icon = "ƒß°§ÚøªÍ.dds";
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
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_res2 = player.GetRes2();
			int				skill_level = skill.GetLevel();

			victim.SetProbability(120.0f);
			victim.SetTime(((1000 * skill_level + 2000)));
			victim.SetRatio(1.0f);
			victim.SetAmount(skill_level);
			victim.SetValue((skill_level * (player_res2 * 0.05f)));
			victim.SetFrenzied(true);
			victim.SetProbability(120.0f);
			victim.SetTime(((2000 * skill_level + 10000)));
			victim.SetBuffid(1);
			victim.SetAmount((norm(skill_level / 19.9f) * 0.05f + (skill_level * 0.01f + 0.05f)));
			victim.SetValue((norm(skill_level / 19.9f) * 0.05f + (skill_level * 0.01f + 0.05f)));
			victim.SetChihun(true);
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
	public class GSkill3087 : GSkill
	{
		public GSkill3087()
			: base(3087)
		{
			
		}
	}
	public class GSkill3088Stub : GSkillStub
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
		public GSkill3088Stub()
			: base(3088)
		{
			occupation = 168;
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
			clearmask = 2;
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
			name = "˜È’Ω<…∑>";
			nativename = "˜È’Ω<…∑>";
			icon = "ƒß°§˜È’Ω.dds";
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
			victim.SetRatio((skill_level * 0.05f));
			victim.SetAmount(0.0f);
			victim.SetValue(100.0f);
			victim.SetRetort(true);
			victim.SetProbability(((3 * skill_level + 15)));
			victim.SetClearslow(true);
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
	public class GSkill3088 : GSkill
	{
		public GSkill3088()
			: base(3088)
		{
			
		}
	}
	public class GSkill3089Stub : GSkillStub
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
				  if ( skill_charging <= 0xFA )
				  {
				    skill.SetCrit(0.0f);
				  }
				  else
				  {
				skill.SetCrit((skill_level * 0.01f * (skill_charging * 0.0005f)));
				  }
				player.SetVar1(1);
				v17 = skill_t0 * 0.01f + ((skill_level - 15) * (norm(skill_level / 14.9f) * 0.03f) + ((0.05f * skill_level) + 1.02f));
				  if ( skill_charging <= 0xFA )
				  {
				    v16 = v17 + 0.0f;
				  }
				  else
				  {
				v16 = (skill_level * 0.05f + 0.5f) * (skill_charging * 0.0005f) + v17;
				  }
				skill.SetRatio(v16);
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
				  if ( skill_charging <= 0xFA )
				  {
				    skill.SetCrit(0.0f);
				  }
				  else
				  {
				skill.SetCrit((skill_level * 0.01f * (skill_charging * 0.0005f)));
				  }
				player.SetVar1(2);
				v17 = skill_t0 * 0.01f + ((skill_level - 15) * (norm(skill_level / 14.9f) * 0.03f) + ((0.05f * skill_level) + 1.02f));
				  if ( skill_charging <= 0xFA )
				  {
				    v16 = v17 + 0.0f;
				  }
				  else
				  {
				v16 = (skill_level * 0.05f + 0.5f) * (skill_charging * 0.0005f) + v17;
				  }
				skill.SetRatio(v16);
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
				  if ( skill_charging <= 0xFA )
				  {
				    v19 = 0.0f;
				  }
				  else
				  {
				v19 = skill_level * 0.01f * (0.0005f * skill_charging);
				  }
				  if ( skill_t1 <= 2.9f )
				    v18 = v19 + 0.0f;
				  else
				skill.SetCrit((v19 + 0.1f));
				player.SetVar1(3);
				v17 = skill_t0 * 0.01f + ((skill_level - 15) * (norm(skill_level / 14.9f) * 0.03f) + ((0.05f * skill_level) + 1.02f));
				  if ( skill_charging <= 0xFA )
				  {
				    v16 = v17 + 0.0f;
				  }
				  else
				  {
				v16 = (skill_level * 0.05f + 0.5f) * (skill_charging * 0.0005f) + v17;
				  }
				skill.SetRatio(v16);
				skill.SetPlus(((9 * skill_level + 515)));
				player.SetPerform(0);
				*/
			}
		}
		public GSkill3089Stub()
			: base(3089)
		{
			occupation = 168;
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
			clearmask = 2;
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
			name = "»˝‘∆¡˙<…∑>";
			nativename = "»˝‘∆¡˙<…∑>";
			icon = "ƒß°§»˝‘∆¡˙.dds";
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
			int				player_var3 = player.GetVar3();
			int				skill_level = skill.GetLevel();
			int				skill_t1 = skill.GetT1();

			/*
			if ( player_var1 == 1 )
			{
			if ( skill_t1 <= 0.9f )
			v25 = 0.0f;
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
			v23 = 0.0f;
			else
			v24 = 600.0f;
			}
			else
			{
			v24 = 0.0f;
			}
			victim.SetProbability(v24);
			victim.SetTime(5000.0f);
			victim.SetRatio(0.40000001f);
			victim.SetBuffid(1);
			victim.SetSlow(true);
			victim.SetTime((player_var3 * 0.0005f * 10.0f * 500.0f + ((300 * skill_level + 2000))));
			victim.SetRatio((skill_level * 0.01f));
			victim.SetBuffid(1);
			victim.SetDecanti(true);
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
	public class GSkill3089 : GSkill
	{
		public GSkill3089()
			: base(3089)
		{
			
		}
	}
}
