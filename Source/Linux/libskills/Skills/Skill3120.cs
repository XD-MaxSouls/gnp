using System;
using System.Text;

namespace SKILL
{
	public class GSkill3120Stub : GSkillStub
	{
		public class GState1 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 300;
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
				return 450;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_res2 = player.GetRes2();
				int				skill_level = skill.GetLevel();
				int				skill_t1 = skill.GetT1();
				int				skill_t3 = skill.GetT3();

				player.SetVar1(player_res2);
				skill.SetRatio((skill_t1 * 0.05f + ((skill_level - 15) * (norm(skill_level / 14.9f) * 0.03f) + (skill_level * 0.05f + 1.12f))));
				skill.SetPlus(((skill_t3 * 0.07000000000000001f + 1.0f) * ((5 * skill_level * skill_level + 720))));
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
				return 450;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_res2 = player.GetRes2();
				int				skill_level = skill.GetLevel();
				int				skill_t3 = skill.GetT3();

				player.SetVar1(player_res2);
				skill.SetRatio(((skill_level - 15) * (norm(skill_level / 14.9f) * 0.03f) + (skill_level * 0.05f + 1.12f)));
				skill.SetPlus(((skill_t3 * 0.07000000000000001f + 1.0f) * ((5 * skill_level * skill_level + 720))));
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
				return 450;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_res2 = player.GetRes2();
				int				skill_level = skill.GetLevel();
				int				skill_t3 = skill.GetT3();

				player.SetVar1(player_res2);
				skill.SetRatio(((skill_level - 15) * (norm(skill_level / 14.9f) * 0.03f) + (skill_level * 0.05f + 1.12f)));
				skill.SetPlus(((skill_t3 * 0.07000000000000001f + 1.0f) * ((5 * skill_level * skill_level + 720))));
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
				return 450;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_res2 = player.GetRes2();
				int				skill_level = skill.GetLevel();
				int				skill_t3 = skill.GetT3();

				player.SetVar1(player_res2);
				skill.SetRatio(((skill_level - 15) * (norm(skill_level / 14.9f) * 0.03f) + (skill_level * 0.05f + 1.12f)));
				skill.SetPlus(((skill_t3 * 0.07000000000000001f + 1.0f) * ((5 * skill_level * skill_level + 720))));
				player.SetPerform(0);
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
				return 450;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_res2 = player.GetRes2();
				int				skill_level = skill.GetLevel();
				int				skill_t3 = skill.GetT3();

				player.SetVar1(player_res2);
				skill.SetRatio(((skill_level - 15) * (norm(skill_level / 14.9f) * 0.03f) + (skill_level * 0.05f + 1.12f)));
				skill.SetPlus(((skill_t3 * 0.07000000000000001f + 1.0f) * ((5 * skill_level * skill_level + 720))));
				player.SetPerform(0);
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
				return 450;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_res2 = player.GetRes2();
				int				skill_level = skill.GetLevel();
				int				skill_t3 = skill.GetT3();

				player.SetVar1(player_res2);
				skill.SetRatio(((skill_level - 15) * (norm(skill_level / 14.9f) * 0.03f) + (skill_level * 0.05f + 1.12f) + 0.15f));
				skill.SetPlus(((skill_t3 * 0.07000000000000001f + 1.0f) * ((5 * skill_level * skill_level + 720))));
				player.SetPerform(0);
			}
		}
		public GSkill3120Stub()
			: base(3120)
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
			weapon_limit = -1;
			SetAction(0,"πÌÕı◊⁄_Œ¥√˚’∂");
			SetAction(1,"πÌÕı◊⁄_Œ¥√˚’∂");
			SetAction(2,"πÌÕı◊⁄_Œ¥√˚’∂");
			SetAction(3,"πÌÕı◊⁄_Œ¥√˚’∂");
			SetAction(4,"πÌÕı◊⁄_Œ¥√˚’∂");
			SetAction(5,"πÌÕı◊⁄_Œ¥√˚’∂");
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
			SetAction(18,"πÌÕı◊⁄_∆Ô≥À_Œ¥√˚’∂");
			SetAction(19,"πÌÕı◊⁄_∆Ô≥À_Œ¥√˚’∂");
			SetAction(20,"πÌÕı◊⁄_∆Ô≥À_Œ¥√˚’∂");
			SetAction(21,"πÌÕı◊⁄_∆Ô≥À_Œ¥√˚’∂");
			SetAction(22,"πÌÕı◊⁄_∆Ô≥À_Œ¥√˚’∂");
			SetAction(23,"πÌÕı◊⁄_∆Ô≥À_Œ¥√˚’∂");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "Œ¥√˚’∂<Ï¯>";
			nativename = "Œ¥√˚’∂<Ï¯>";
			icon = "∑°§Œ¥√˚’∂.dds";
			SetTalent(0,624);
			SetTalent(1,629);
			SetTalent(2,650);
			SetTalent(3,661);
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
			AddState(new GState3());
			AddState(new GState4());
			AddState(new GState5());
			AddState(new GState6());
			AddState(new GState7());
		}
		public override int GetExecutetime(GSkill skill)
		{
			return 3000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			int				skill_t1 = skill.GetT1();
			int				skill_t3 = skill.GetT3();

			return (-2000 * skill_t1) - 2250 * skill_t3 + 15000;
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
			return 12.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (15 * skill_level + (2 * skill_level * skill_level) + 1150);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_level = player.GetLevel();
			int				player_maxhp = player.GetMaxhp();
			int				player_var1 = player.GetVar1();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();

			victim.SetProbability(((2 * skill_level + player_var1)));
			victim.SetTime(6100.0f);
			victim.SetRatio((skill_t0 * 0.05f + 0.3f));
			victim.SetBuffid(1);
			victim.SetWeak(true);
			victim.SetProbability(((1.0f - player_level * 0.002f) * 33.0f));
			victim.SetTime(6000.0f);
			victim.SetBuffid(1);
			victim.SetAmount((player_maxhp * (skill_level * 0.1f)));
			victim.SetValue(0.0f);
			victim.SetMpleak(true);
			victim.SetProbability(((2 * norm(skill_level / 19.9f) + 3)));
			victim.SetTime(((100 * skill_level + 1050)));
			victim.SetDiet(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_t2 = skill.GetT2();

			victim.SetProbability(((15 * skill_t2 + 33)));
			victim.SetTime(8100.0f);
			victim.SetRatio(0.30000001f);
			victim.SetDecdamage(true);
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={778};return array[index];
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
	public class GSkill3120 : GSkill
	{
		public GSkill3120()
			: base(3120)
		{
			
		}
	}
	public class GSkill3121Stub : GSkillStub
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
				int				skill_level = skill.GetLevel();
				int				skill_t2 = skill.GetT2();
				int				skill_t3 = skill.GetT3();

				skill.SetRatio((skill_t2 * 0.07000000000000001f + ((skill_level - 15) * (norm(skill_level / 14.9f) * 0.03f) + (skill_level * 0.05f + 1.0f))));
				skill.SetPlus((((skill_level * skill_level + (22 * skill_level) + 835) * (D2INT((zrand(7 * skill_t3 + 99)) / 100) + 1))));
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
				int				skill_level = skill.GetLevel();
				int				skill_t2 = skill.GetT2();
				int				skill_t3 = skill.GetT3();

				skill.SetRatio((skill_t2 * 0.07000000000000001f + ((skill_level - 15) * (norm(skill_level / 14.9f) * 0.03f) + (skill_level * 0.05f + 1.0f))));
				skill.SetPlus((((skill_level * skill_level + (22 * skill_level) + 835) * (D2INT((zrand(7 * skill_t3 + 99)) / 100) + 1))));
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
				int				skill_level = skill.GetLevel();
				int				skill_t2 = skill.GetT2();
				int				skill_t3 = skill.GetT3();

				skill.SetRatio((skill_t2 * 0.07000000000000001f + ((skill_level - 15) * (norm(skill_level / 14.9f) * 0.03f) + (skill_level * 0.05f + 1.0f))));
				skill.SetPlus((((skill_level * skill_level + (22 * skill_level) + 835) * (D2INT((zrand(7 * skill_t3 + 99)) / 100) + 1))));
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
				int				skill_level = skill.GetLevel();
				int				skill_t2 = skill.GetT2();
				int				skill_t3 = skill.GetT3();

				skill.SetRatio((skill_t2 * 0.07000000000000001f + ((skill_level - 15) * (norm(skill_level / 14.9f) * 0.03f) + (skill_level * 0.05f + 1.0f))));
				skill.SetPlus((((skill_level * skill_level + (22 * skill_level) + 835) * (D2INT((zrand(7 * skill_t3 + 99)) / 100) + 1))));
				player.SetPerform(0);
			}
		}
		public GSkill3121Stub()
			: base(3121)
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
			weapon_limit = -1;
			SetAction(0,"ÃÏ“ÙÀ¬_¿◊“Ù∑®⁄Õ");
			SetAction(1,"ÃÏ“ÙÀ¬_¿◊“Ù∑®⁄Õ");
			SetAction(2,"ÃÏ“ÙÀ¬_¿◊“Ù∑®⁄Õ");
			SetAction(3,"ÃÏ“ÙÀ¬_¿◊“Ù∑®⁄Õ");
			SetAction(4,"ÃÏ“ÙÀ¬_¿◊“Ù∑®⁄Õ");
			SetAction(5,"ÃÏ“ÙÀ¬_¿◊“Ù∑®⁄Õ");
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
			SetAction(18,"ÃÏ“ÙÀ¬_∆Ô≥À_¿◊“Ù∑®⁄Õ");
			SetAction(19,"ÃÏ“ÙÀ¬_∆Ô≥À_¿◊“Ù∑®⁄Õ");
			SetAction(20,"ÃÏ“ÙÀ¬_∆Ô≥À_¿◊“Ù∑®⁄Õ");
			SetAction(21,"ÃÏ“ÙÀ¬_∆Ô≥À_¿◊“Ù∑®⁄Õ");
			SetAction(22,"ÃÏ“ÙÀ¬_∆Ô≥À_¿◊“Ù∑®⁄Õ");
			SetAction(23,"ÃÏ“ÙÀ¬_∆Ô≥À_¿◊“Ù∑®⁄Õ");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "¿◊“Ù∑®⁄Õ<Ï¯>";
			nativename = "¿◊“Ù∑®⁄Õ<Ï¯>";
			icon = "∑°§¿◊“Ù∑®⁄Õ.dds";
			SetTalent(0,684);
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
			int				skill_t0 = skill.GetT0();

			return 16000 - 3200 * skill_t0;
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

			return (skill_level * 0.7f + 16.0f);
		}
		public override float GetCastdistance(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (skill_level * 0.7f + 10.7f);
		}
		public override float GetEffectdistance(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (skill_level * 0.7f + 19.0f);
		}
		public override float GetMpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return ((skill_level * (skill_level * 2.6f)) - skill_level * 3.3f + 1820.0f);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_level = player.GetLevel();
			int				skill_level = skill.GetLevel();
			int				skill_t1 = skill.GetT1();

			/*
			victim.SetProbability(((1.0f - player_level * 0.002f) * 100.0f));
			victim.SetTime(((4000 * skill_level)));
			victim.SetBuffid(1);
			victim.SetAmount((skill_level * (skill_level * (skill_level * 1.5f) + ((11 * skill_level + 500)))));
			victim.SetValue(0.0f);
			victim.SetHpleak(true);
			victim.SetProbability(((6 * skill_t1)));
			victim.SetTime(((4050 * skill_t1)));
			victim.SetRatio((skill_t1 * 0.03f));
			victim.SetBuffid(1);
			victim.SetDecdefence(true);
			if ( zrand(100) >= 5 * skill_level )
			v31 = 0.0f;
			else
			victim.SetProbability(140.0f);
			victim.SetTime(6100.0f);
			victim.SetRatio((skill_level * 0.02f + 0.2f));
			victim.SetBuffid(1);
			victim.SetSlow(true);
			*/
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();
			int				skill_t3 = skill.GetT3();

			victim.SetValue(((32 * skill_level * (skill_t3 + 1))));
			victim.SetJuqi(true);
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={787};return array[index];
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
	public class GSkill3121 : GSkill
	{
		public GSkill3121()
			: base(3121)
		{
			
		}
	}
	public class GSkill3122Stub : GSkillStub
	{
		public class GState1 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 125;
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
				return 100;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_level = player.GetLevel();
				int				player_res5 = player.GetRes5();
				int				skill_level = skill.GetLevel();
				int				skill_t0 = skill.GetT0();
				int				skill_t1 = skill.GetT1();

				player.SetVar2(1);
				player.SetVar1(player_res5);
				skill.SetRatio((skill_t1 * 0.05f + ((skill_level - 15) * (norm(skill_level / 14.9f) * 0.03f) + (skill_level * 0.05f + (skill_t0 * 0.06f + 1.0f)))));
				skill.SetPlus(((5 * skill_level * skill_level) + ((30 * skill_level) + (skill_t0 * (skill_level * (player_level * 0.15f)) + 720.0f))));
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
				return 1150;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_level = player.GetLevel();
				int				player_res5 = player.GetRes5();
				int				skill_level = skill.GetLevel();
				int				skill_t0 = skill.GetT0();
				int				skill_t1 = skill.GetT1();

				player.SetVar2(0);
				player.SetVar1(player_res5);
				skill.SetRatio((skill_t1 * 0.05f + ((skill_level - 15) * (norm(skill_level / 14.9f) * 0.03f) + (skill_level * 0.05f + (skill_t0 * 0.06f + 1.0f)))));
				skill.SetPlus(((5 * skill_level * skill_level) + ((30 * skill_level) + (skill_t0 * (skill_level * (player_level * 0.15f)) + 720.0f))));
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
				return 1625;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_level = player.GetLevel();
				int				player_res5 = player.GetRes5();
				int				skill_level = skill.GetLevel();
				int				skill_t0 = skill.GetT0();
				int				skill_t1 = skill.GetT1();

				player.SetVar2(0);
				player.SetVar1(player_res5);
				skill.SetCrit(0.1f);
				skill.SetRatio((skill_t1 * 0.05f + ((skill_level - 15) * (norm(skill_level / 14.9f) * 0.03f) + (skill_level * 0.05f + (skill_t0 * 0.06f + 1.0f)))));
				skill.SetPlus(((5 * skill_level * skill_level) + ((30 * skill_level) + (skill_t0 * (skill_level * (player_level * 0.15f)) + 720.0f))));
				player.SetPerform(0);
			}
		}
		public GSkill3122Stub()
			: base(3122)
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
			SetAction(0,"ÃÏ“ÙÀ¬_Œﬁ¡ø’Ê—‘");
			SetAction(1,"ÃÏ“ÙÀ¬_Œﬁ¡ø’Ê—‘");
			SetAction(2,"ÃÏ“ÙÀ¬_Œﬁ¡ø’Ê—‘");
			SetAction(3,"ÃÏ“ÙÀ¬_Œﬁ¡ø’Ê—‘");
			SetAction(4,"ÃÏ“ÙÀ¬_Œﬁ¡ø’Ê—‘");
			SetAction(5,"ÃÏ“ÙÀ¬_Œﬁ¡ø’Ê—‘");
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
			SetAction(18,"ÃÏ“ÙÀ¬_∆Ô≥À_Œﬁ¡ø’Ê—‘");
			SetAction(19,"ÃÏ“ÙÀ¬_∆Ô≥À_Œﬁ¡ø’Ê—‘");
			SetAction(20,"ÃÏ“ÙÀ¬_∆Ô≥À_Œﬁ¡ø’Ê—‘");
			SetAction(21,"ÃÏ“ÙÀ¬_∆Ô≥À_Œﬁ¡ø’Ê—‘");
			SetAction(22,"ÃÏ“ÙÀ¬_∆Ô≥À_Œﬁ¡ø’Ê—‘");
			SetAction(23,"ÃÏ“ÙÀ¬_∆Ô≥À_Œﬁ¡ø’Ê—‘");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "Œﬁ¡ø’Ê—‘<Ï¯>";
			nativename = "Œﬁ¡ø’Ê—‘<Ï¯>";
			icon = "∑°§Œﬁ¡ø’Ê—‘.dds";
			SetTalent(0,675);
			SetTalent(1,681);
			SetTalent(2,701);
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
			int				skill_t0 = skill.GetT0();

			return 15000 - 2250 * skill_t0;
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
			return 15.000000f;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 14.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 13.000000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 25.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return ((60 * skill_level) + (skill_level * (skill_level * 3.3f)) + 1850.0f);
		}
		public override int GetCoverage(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return D2INT(skill_level / 1.9f) + 6;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_var1 = player.GetVar1();
			int				skill_level = skill.GetLevel();
			int				skill_t2 = skill.GetT2();

			victim.SetTime(3100.0f);
			victim.SetRatio((skill_level * 0.01f + 0.1f));
			victim.SetBuffid(1);
			victim.SetDecanti(true);
			victim.SetProbability((player_var1 * (skill_level * 0.01f + 0.5f)));
			victim.SetTime(15100.0f);
			victim.SetValue(0.1f);
			victim.SetDsleep(true);
			victim.SetProbability(-1.0f);
			victim.SetRatio((skill_t2 * 0.1f));
			victim.SetDrainmagic(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_maxatk = player.GetMaxatk();
			int				player_var2 = player.GetVar2();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();

			/*
			victim.SetTime(((500 * skill_level + 2050)));
			victim.SetBuffid(1);
			victim.SetValue((player_maxatk * 0.01f));
			victim.SetAddanti(true);
			if ( player_var2 == 1 )
			v25 = 120.0f;
			else
			victim.SetProbability(0.0f);
			victim.SetTime(((14800 - 2250 * skill_t0)));
			victim.SetRatio(788.0f);
			victim.SetAmount(220.0f);
			victim.SetValue(220.0f);
			victim.SetSetcooldown(true);
			victim.SetRatio(((2902 * D2INT((zrand((skill_level * 0.5f + 100.0f))) / 100) + 220)));
			victim.SetAmount(220.0f);
			victim.SetValue(220.0f);
			victim.SetClearcooldown(true);
			*/
			return true;
		}
		public override float GetDropRate(GSkill skill)
		{
			return 0.500000f;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={788};return array[index];
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

			return 4 * skill_level * skill_level + (34 * skill_level) + 200;
		}
	}
	public class GSkill3122 : GSkill
	{
		public GSkill3122()
			: base(3122)
		{
			
		}
	}
	public class GSkill3123Stub : GSkillStub
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

				player.SetPerform(1);
			}
		}
		public GSkill3123Stub()
			: base(3123)
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
			SetAction(0,"ÃÏ“ÙÀ¬_¥Û∑≤∞„»Ù");
			SetAction(1,"ÃÏ“ÙÀ¬_¥Û∑≤∞„»Ù");
			SetAction(2,"ÃÏ“ÙÀ¬_¥Û∑≤∞„»Ù");
			SetAction(3,"ÃÏ“ÙÀ¬_¥Û∑≤∞„»Ù");
			SetAction(4,"ÃÏ“ÙÀ¬_¥Û∑≤∞„»Ù");
			SetAction(5,"ÃÏ“ÙÀ¬_¥Û∑≤∞„»Ù");
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
			SetAction(18,"ÃÏ“ÙÀ¬_∆Ô≥À_¥Û∑≤∞„»Ù");
			SetAction(19,"ÃÏ“ÙÀ¬_∆Ô≥À_¥Û∑≤∞„»Ù");
			SetAction(20,"ÃÏ“ÙÀ¬_∆Ô≥À_¥Û∑≤∞„»Ù");
			SetAction(21,"ÃÏ“ÙÀ¬_∆Ô≥À_¥Û∑≤∞„»Ù");
			SetAction(22,"ÃÏ“ÙÀ¬_∆Ô≥À_¥Û∑≤∞„»Ù");
			SetAction(23,"ÃÏ“ÙÀ¬_∆Ô≥À_¥Û∑≤∞„»Ù");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "¥ÛËÛ∞„»Ù<Ï¯>";
			nativename = "¥ÛËÛ∞„»Ù<Ï¯>";
			icon = "∑°§¥ÛËÛ∞„»Ù.dds";
			SetTalent(0,693);
			SetTalent(1,700);
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
		}
		public override int GetExecutetime(GSkill skill)
		{
			return 1000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			int				skill_t1 = skill.GetT1();

			return 180000 - 18000 * skill_t1;
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

			return (skill_level * skill_level + (15 * skill_level) + 810);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_maxhp = player.GetMaxhp();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();
			int				skill_t1 = skill.GetT1();
			int				skill_t2 = skill.GetT2();

			victim.SetProbability(100.0f);
			victim.SetTime(((2000 * skill_t2 + 20100)));
			victim.SetRatio((skill_t0 * 0.02f + (skill_level * 0.02f)));
			victim.SetBuffid(1);
			victim.SetAmount(0.0f);
			victim.SetValue(((skill_t2 * 0.1f + 1.0f) * ((skill_t1 * 0.2f + 1.0f) * (player_maxhp * (skill_level * 0.03f) * 10.0f))));
			victim.SetBanruo(true);
			victim.SetTime(((2000 * skill_t2 + 2100)));
			victim.SetInvincible(true);
			victim.SetProbability(100.0f);
			victim.SetTime(((2000 * skill_t2 + 20100)));
			victim.SetRatio((skill_level * 0.1f));
			victim.SetBuffid(1);
			victim.SetIncdefence(true);
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={789};return array[index];
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

			return 3 * skill_level * skill_level + (26 * skill_level) + 180;
		}
	}
	public class GSkill3123 : GSkill
	{
		public GSkill3123()
			: base(3123)
		{
			
		}
	}
	public class GSkill3124Stub : GSkillStub
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
				int				player_mp = player.GetMp();
				int				player_maxmp = player.GetMaxmp();
				int				player_maxatk = player.GetMaxatk();
				int				skill_level = skill.GetLevel();

				/*
				player.SetVar3((int)(player_mp - skill_level * (player_maxmp * 0.025f) > 0.0f));
				player.SetVar2(player_maxmp);
				if ( player_mp - skill_level * (player_maxmp * 0.03f) <= 0.0f )
				  {
				v26 = player_mp;
				  }
				  else
				  {
				v26 = player_mp - skill_level * (player_maxmp * 0.03f);
				  }
				player.SetMp(v26);
				player.SetVar1(player_maxatk);
				player.SetPerform(1);
				*/
			}
		}
		public GSkill3124Stub()
			: base(3124)
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
			rangetype = 2;
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
			SetAction(0,"ÃÏ“ÙÀ¬_ÕÚœÛ…˙∑");
			SetAction(1,"ÃÏ“ÙÀ¬_ÕÚœÛ…˙∑");
			SetAction(2,"ÃÏ“ÙÀ¬_ÕÚœÛ…˙∑");
			SetAction(3,"ÃÏ“ÙÀ¬_ÕÚœÛ…˙∑");
			SetAction(4,"ÃÏ“ÙÀ¬_ÕÚœÛ…˙∑");
			SetAction(5,"ÃÏ“ÙÀ¬_ÕÚœÛ…˙∑");
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
			SetAction(18,"ÃÏ“ÙÀ¬_∆Ô≥À_ÕÚœÛ…˙∑");
			SetAction(19,"ÃÏ“ÙÀ¬_∆Ô≥À_ÕÚœÛ…˙∑");
			SetAction(20,"ÃÏ“ÙÀ¬_∆Ô≥À_ÕÚœÛ…˙∑");
			SetAction(21,"ÃÏ“ÙÀ¬_∆Ô≥À_ÕÚœÛ…˙∑");
			SetAction(22,"ÃÏ“ÙÀ¬_∆Ô≥À_ÕÚœÛ…˙∑");
			SetAction(23,"ÃÏ“ÙÀ¬_∆Ô≥À_ÕÚœÛ…˙∑");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "ÕÚœÛ…˙∑<Ï¯>";
			nativename = "ÕÚœÛ…˙∑<Ï¯>";
			icon = "∑°§ÕÚœÛ…˙∑.dds";
			SetTalent(0,697);
			SetTalent(1,703);
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
			int				skill_t1 = skill.GetT1();

			return 60000 - 5000 * skill_t1;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={120,122,124,126,128,130,131,132,133,134,135,136,137,138,139,141,143,145,147,149};return array[level-1];
		}
		public override float GetRadius(GSkill skill)
		{
			return 30.000000f;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 15.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 12.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (8 * skill_level * skill_level + 4500);
		}
		public override int GetCoverage(GSkill skill)
		{
			return 40;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_maxhp = player.GetMaxhp();
			int				player_var1 = player.GetVar1();
			int				player_var2 = player.GetVar2();
			int				player_var3 = player.GetVar3();
			int				skill_level = skill.GetLevel();

			victim.SetProbability(((100 * player_var3)));
			victim.SetRatio(1.0f);
			victim.SetValue((player_maxhp * (norm(skill_level / 19.9f) * 0.2f + (skill_level * 0.03f + 0.2f))));
			victim.SetHeal(true);
			victim.SetTime((((500 * skill_level + 2050) * player_var3)));
			victim.SetRatio((player_var3 * (skill_level * 0.02f)));
			victim.SetAmount((player_var3 * ((player_var1 * skill_level) * 0.5f)));
			victim.SetDechurt(true);
			victim.SetProbability(((120 * player_var3)));
			victim.SetTime(50.0f);
			victim.SetRatio(skill_level);
			victim.SetBuffid(1);
			victim.SetValue(5232.0f);
			victim.SetDelaycast(true);
			victim.SetProbability(((120 * player_var3)));
			victim.SetTime(300000.0f);
			victim.SetAmount((skill_level * (player_var2 * 0.05f)));
			victim.SetBloodpool(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_var3 = player.GetVar3();
			int				skill_level = skill.GetLevel();
			int				skill_t2 = skill.GetT2();

			victim.SetProbability(((100 * player_var3)));
			victim.SetTime(((1800000 * norm(skill_t2))));
			victim.SetRatio(0.0f);
			victim.SetBuffid(5);
			victim.SetValue(((100 * skill_t2 * skill_level)));
			victim.SetTiangu(true);
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={790};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={4};return array[index];
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
	public class GSkill3124 : GSkill
	{
		public GSkill3124()
			: base(3124)
		{
			
		}
	}
	public class GSkill3125Stub : GSkillStub
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

				skill.SetCrit(0.050000001f);
				skill.SetRatio((skill_t1 * 0.05f + ((skill_level - 15) * (norm(skill_level / 14.9f) * 0.03f) + (skill_level * 0.05f + 1.33f))));
				skill.SetPlus(((2 * skill_level * skill_level + (35 * skill_level * skill_t3) + 180)));
				player.SetPerform(1);
			}
		}
		public GSkill3125Stub()
			: base(3125)
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
			weapon_limit = -1;
			SetAction(0,"∫œª∂≈…_æ…√Œ");
			SetAction(1,"∫œª∂≈…_æ…√Œ");
			SetAction(2,"∫œª∂≈…_æ…√Œ");
			SetAction(3,"∫œª∂≈…_æ…√Œ");
			SetAction(4,"∫œª∂≈…_æ…√Œ");
			SetAction(5,"∫œª∂≈…_æ…√Œ");
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
			SetAction(18,"∫œª∂≈…_∆Ô≥À_æ…√Œ");
			SetAction(19,"∫œª∂≈…_∆Ô≥À_æ…√Œ");
			SetAction(20,"∫œª∂≈…_∆Ô≥À_æ…√Œ");
			SetAction(21,"∫œª∂≈…_∆Ô≥À_æ…√Œ");
			SetAction(22,"∫œª∂≈…_∆Ô≥À_æ…√Œ");
			SetAction(23,"∫œª∂≈…_∆Ô≥À_æ…√Œ");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "æ…√Œ<Ï¯>";
			nativename = "æ…√Œ<Ï¯>";
			icon = "∑°§æ…√Œ.dds";
			SetTalent(0,724);
			SetTalent(1,732);
			SetTalent(2,743);
			SetTalent(3,765);
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
		}
		public override int GetExecutetime(GSkill skill)
		{
			return 1000;
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
			return 8.000000f;
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

			return (skill_level * 3.5f + (skill_level * (skill_level * 2.3f)) + 710.0f);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_level = player.GetLevel();
			int				skill_level = skill.GetLevel();
			int				skill_t2 = skill.GetT2();
			int				skill_t3 = skill.GetT3();

			victim.SetProbability(((1.0f - player_level * 0.002f) * ((8 * skill_t2 + 60))));
			victim.SetRatio(((D2INT(zrand(100) / (100 - 4 * skill_t2)) + 1) * 0.48f));
			victim.SetDrainmagic(true);
			victim.SetProbability(((5 * skill_t3 + skill_level + 14)));
			victim.SetAmount(((norm(skill_level / 19.9f) + 2)));
			victim.SetClearbuff(true);
			victim.SetTime(((300 * skill_level + 2050)));
			victim.SetRatio(1.0f);
			victim.SetDisperseanti(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_maxhp = player.GetMaxhp();
			int				skill_t0 = skill.GetT0();

			victim.SetProbability(((8 * skill_t0)));
			victim.SetRatio(0.0f);
			victim.SetValue((player_maxhp * (skill_t0 * 0.02f)));
			victim.SetHeal(true);
			victim.SetProbability(120.0f);
			victim.SetRatio(293.0f);
			victim.SetBuffid(0);
			victim.SetAmount(0.0f);
			victim.SetValue(2000.0f);
			victim.SetReduceskillcd(true);
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={779};return array[index];
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

			return 3 * skill_level * skill_level + (42 * skill_level) + 170;
		}
	}
	public class GSkill3125 : GSkill
	{
		public GSkill3125()
			: base(3125)
		{
			
		}
	}
	public class GSkill3126Stub : GSkillStub
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

				player.SetPerform(1);
			}
		}
		public GSkill3126Stub()
			: base(3126)
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
			SetAction(0,"∫œª∂≈…_œß¥∫");
			SetAction(1,"∫œª∂≈…_œß¥∫");
			SetAction(2,"∫œª∂≈…_œß¥∫");
			SetAction(3,"∫œª∂≈…_œß¥∫");
			SetAction(4,"∫œª∂≈…_œß¥∫");
			SetAction(5,"∫œª∂≈…_œß¥∫");
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
			SetAction(18,"∫œª∂≈…_∆Ô≥À_œß¥∫");
			SetAction(19,"∫œª∂≈…_∆Ô≥À_œß¥∫");
			SetAction(20,"∫œª∂≈…_∆Ô≥À_œß¥∫");
			SetAction(21,"∫œª∂≈…_∆Ô≥À_œß¥∫");
			SetAction(22,"∫œª∂≈…_∆Ô≥À_œß¥∫");
			SetAction(23,"∫œª∂≈…_∆Ô≥À_œß¥∫");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "œß¥∫<Ï¯>";
			nativename = "œß¥∫<Ï¯>";
			icon = "∑°§œß¥∫.dds";
			SetTalent(0,734);
			SetTalent(1,763);
			SetTalent(2,764);
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
		}
		public override int GetExecutetime(GSkill skill)
		{
			return 1000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			int				skill_t1 = skill.GetT1();

			return 180000 - 14400 * skill_t1;
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

			return (17 * skill_level + 490);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();
			int				skill_t2 = skill.GetT2();

			victim.SetTime(((skill_t2 * 0.1f + 1.0f) * 12000.0f + 100.0f));
			victim.SetValue(((2 * skill_t0 + skill_level)));
			victim.SetBlessed(true);
			victim.SetProbability(100.0f);
			victim.SetBuffid(2);
			victim.SetAmount(99.0f);
			victim.SetValue(99.0f);
			victim.SetExorcism(true);
			victim.SetProbability(((30 * skill_t0)));
			victim.SetClearslow(true);
			victim.SetProbability(((4 * skill_level + 10)));
			victim.SetClearwrap(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_t0 = skill.GetT0();

			victim.SetTime(((3000 * norm(skill_t0 / 1.5f))));
			victim.SetInvincible(true);
			victim.SetProbability(120.0f);
			victim.SetRatio(293.0f);
			victim.SetBuffid(0);
			victim.SetAmount(0.0f);
			victim.SetValue(2000.0f);
			victim.SetReduceskillcd(true);
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={780};return array[index];
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
	public class GSkill3126 : GSkill
	{
		public GSkill3126()
			: base(3126)
		{
			
		}
	}
	public class GSkill3127Stub : GSkillStub
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
				int				player_res1 = player.GetRes1();
				int				player_res2 = player.GetRes2();
				int				player_res3 = player.GetRes3();
				int				player_res4 = player.GetRes4();
				int				player_res5 = player.GetRes5();
				int				skill_level = skill.GetLevel();
				int				skill_t0 = skill.GetT0();
				int				skill_t1 = skill.GetT1();

				player.SetVar1((int)((player_res5 + (player_res4 + (player_res3 + (player_res2 + player_res1)))) * 0.001f));
				skill.SetCrit((skill_t0 * 0.02f));
				skill.SetRatio((skill_t1 * 0.1f + 0.75f));
				skill.SetPlus(((5 * skill_level * skill_level + (60 * skill_level) + 55)));
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
				int				player_res1 = player.GetRes1();
				int				player_res2 = player.GetRes2();
				int				player_res3 = player.GetRes3();
				int				player_res4 = player.GetRes4();
				int				player_res5 = player.GetRes5();
				int				skill_level = skill.GetLevel();
				int				skill_t0 = skill.GetT0();
				int				skill_t1 = skill.GetT1();

				player.SetVar1((int)((player_res5 + (player_res4 + (player_res3 + (player_res2 + player_res1)))) * 0.001f));
				skill.SetCrit((skill_t0 * 0.02f));
				skill.SetRatio((skill_t1 * 0.1f + 0.75f));
				skill.SetPlus(((5 * skill_level * skill_level + (60 * skill_level) + 55)));
				player.SetPerform(0);
			}
		}
		public GSkill3127Stub()
			: base(3127)
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
			SetAction(0,"∫œª∂≈…_¡Ø”∞");
			SetAction(1,"∫œª∂≈…_¡Ø”∞");
			SetAction(2,"∫œª∂≈…_¡Ø”∞");
			SetAction(3,"∫œª∂≈…_¡Ø”∞");
			SetAction(4,"∫œª∂≈…_¡Ø”∞");
			SetAction(5,"∫œª∂≈…_¡Ø”∞");
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
			SetAction(18,"∫œª∂≈…_∆Ô≥À_¡Ø”∞");
			SetAction(19,"∫œª∂≈…_∆Ô≥À_¡Ø”∞");
			SetAction(20,"∫œª∂≈…_∆Ô≥À_¡Ø”∞");
			SetAction(21,"∫œª∂≈…_∆Ô≥À_¡Ø”∞");
			SetAction(22,"∫œª∂≈…_∆Ô≥À_¡Ø”∞");
			SetAction(23,"∫œª∂≈…_∆Ô≥À_¡Ø”∞");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "¡Ø”∞<Ï¯>";
			nativename = "¡Ø”∞<Ï¯>";
			icon = "∑°§¡Ø”∞.dds";
			SetTalent(0,731);
			SetTalent(1,735);
			SetTalent(2,744);
			SetTalent(3,748);
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
		}
		public override int GetExecutetime(GSkill skill)
		{
			return 2000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			return 6000;
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
			return 12.000000f;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 10.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 8.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return ((12 * skill_level) + (skill_level * (skill_level * 1.2f)) + 780.0f);
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
			int				player_var1 = player.GetVar1();
			int				skill_level = skill.GetLevel();
			int				skill_t2 = skill.GetT2();
			int				skill_t3 = skill.GetT3();

			victim.SetProbability(33.0f);
			victim.SetTime(4000.0f);
			victim.SetBuffid(1);
			victim.SetAmount((((player_var1 * (player_var1 * player_var1)) * player_var1 + (10 * skill_level * skill_level)) * (skill_level * ((zrand(60) + 60) * 0.02f))));
			victim.SetValue(0.0f);
			victim.SetHpleak(true);
			victim.SetProbability(-1.0f);
			victim.SetTime(((skill_t2 * 0.3f + 1.0f) * 8000.0f + 100.0f));
			victim.SetRatio((skill_t3 * 0.03f + 0.1f));
			victim.SetInchurt2(true);
			victim.SetProbability(((5 * skill_level)));
			victim.SetTime(((500 * skill_level + 2050)));
			victim.SetBuffid(1);
			victim.SetAmount(1000.0f);
			victim.SetValue((player_maxhp * (skill_level * 0.01f)));
			victim.SetSubhp(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetProbability(120.0f);
			victim.SetRatio(293.0f);
			victim.SetBuffid(0);
			victim.SetAmount(0.0f);
			victim.SetValue(2000.0f);
			victim.SetReduceskillcd(true);
			return true;
		}
		public override float GetDropRate(GSkill skill)
		{
			return 0.500000f;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={781};return array[index];
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
	public class GSkill3127 : GSkill
	{
		public GSkill3127()
			: base(3127)
		{
			
		}
	}
	public class GSkill3128Stub : GSkillStub
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
		public GSkill3128Stub()
			: base(3128)
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
			name = "∑Áª®—©‘¬<Ï¯>";
			nativename = "∑Áª®—©‘¬<Ï¯>";
			icon = "∑°§∑Áª®—©‘¬.dds";
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
			victim.SetProbability(skill_level);
			if ( player_maxhp * 0.6f <= player_hp )
			t = 0.0f;
			else
			victim.SetTime(((200 * skill_level + 1000)));
			victim.SetDiet(true);
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

			return 5 * skill_level + 100;
		}
	}
	public class GSkill3128 : GSkill
	{
		public GSkill3128()
			: base(3128)
		{
			
		}
	}
	public class GSkill3129Stub : GSkillStub
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
				skill.SetCrithurt((skill_t3 * 0.1f + (skill_level * 0.06f)));
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
				skill.SetCrithurt((skill_t3 * 0.1f + (skill_level * 0.06f)));
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
				skill.SetCrithurt((skill_t3 * 0.1f + (skill_level * 0.06f)));
				skill.SetPlus(((2 * (skill_level * player_level + (skill_level * skill_level + (25 * skill_level))) + 750)));
				player.SetPerform(0);
			}
		}
		public GSkill3129Stub()
			: base(3129)
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
			autoattack = false;
			allowform = 1;
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
			name = "√ªÍøÒÏ≠<Ï¯>";
			nativename = "√ªÍøÒÏ≠<Ï¯>";
			icon = "∑°§√ªÍøÒÏ≠.dds";
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
			victim.SetRatio((skill_level * 0.02f));
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
			victim.SetImmuneweak(true);
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
	public class GSkill3129 : GSkill
	{
		public GSkill3129()
			: base(3129)
		{
			
		}
	}
}
