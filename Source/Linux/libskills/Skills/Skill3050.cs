using System;
using System.Text;

namespace SKILL
{
	public class GSkill3050Stub : GSkillStub
	{
		public class GState1 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 2000;
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
		public GSkill3050Stub()
			: base(3050)
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
			weapon_limit = 12;
			SetAction(0,"Ìì»ª_ÇØéä");
			SetAction(1,"0");
			SetAction(2,"0");
			SetAction(3,"0");
			SetAction(4,"0");
			SetAction(5,"0");
			SetAction(6,"0");
			SetAction(7,"0");
			SetAction(8,"0");
			SetAction(9,"0");
			SetAction(10,"0");
			SetAction(11,"0");
			SetAction(12,"Ìì»ª_ÇØéä");
			SetAction(13,"");
			SetAction(14,"");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"Ìì»ª_Æï³Ë_ÇØéä");
			SetAction(19,"0");
			SetAction(20,"0");
			SetAction(21,"0");
			SetAction(22,"0");
			SetAction(23,"0");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"Ìì»ª_Æï³Ë_ÇØéä");
			name = "¾ÅÏö¾øÏì<Ðþ>";
			nativename = "¾ÅÏö¾øÏì<Ðþ>";
			icon = "ÏÉ¡¤¾ÅÏö¾øÏì.dds";
			SetTalent(0,2634);
			SetTalent(1,2638);
			SetTalent(2,2718);
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
			skill_class = 8;
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
			int				skill_t1 = skill.GetT1();

			return 30000 - 3000 * skill_t1;
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
			return 25.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 20.000000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 30.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (65 * skill_level + 500);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();

			victim.SetProbability(((3 * skill_level + 30)));
			victim.SetTime(18000.0f);
			victim.SetRatio((skill_t0 * 0.02f + (skill_level * 0.03f + 0.2f) + 0.001f));
			victim.SetBuffid(1);
			victim.SetDecskillaccu(true);
			victim.SetProbability(100.0f);
			victim.SetTime(18000.0f);
			victim.SetRatio((skill_level * 0.02f + 0.2f));
			victim.SetBuffid(1);
			victim.SetSlow(true);
			victim.SetTime(((18000 * norm(skill_t0))));
			victim.SetRatio((skill_t0 * 0.07000000000000001f));
			victim.SetBuffid(1);
			victim.SetDecanti(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();
			int				skill_t2 = skill.GetT2();

			victim.SetProbability(((skill_t2 + (2 * skill_level) + 20)));
			victim.SetTime(((2000 * norm(skill_t2) + 5000)));
			victim.SetRatio(1.0f);
			victim.SetSkillmirror(true);
			victim.SetProbability(((5 * skill_level)));
			victim.SetTime(18000.0f);
			victim.SetBuffid(2);
			victim.SetValue((skill_level * 0.1f));
			victim.SetAddspeed(true);
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={2499};return array[index];
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
	public class GSkill3050 : GSkill
	{
		public GSkill3050()
			: base(3050)
		{
			
		}
	}
	public class GSkill3051Stub : GSkillStub
	{
		public class GState1 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 1200;
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
				int				player_res2 = player.GetRes2();
				int				skill_level = skill.GetLevel();
				int				skill_t0 = skill.GetT0();
				int				skill_j0 = skill.GetJ0();
				int				skill_j1 = skill.GetJ1();
				int				skill_j2 = skill.GetJ2();

				skill.SetCrit((skill_t0 * 0.02f + (skill_j1 * (skill_level * 0.003f) + (skill_j1 * 0.01f))));
				skill.SetRatio((skill_j2 * 0.01f + (skill_j2 * (skill_level * 0.02f + 0.1f) + 1.0f)));
				skill.SetPlus(((90 * skill_j0) + ((skill_level * 0.2f + 3.0f) * ((player_res2 * skill_j0)) + ((14 * skill_level) + (skill_level * (skill_level * 0.091f))) + 543.0f)));
				player.SetPerform(1);
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
				int				player_res2 = player.GetRes2();
				int				skill_level = skill.GetLevel();
				int				skill_t0 = skill.GetT0();
				int				skill_j0 = skill.GetJ0();
				int				skill_j1 = skill.GetJ1();
				int				skill_j2 = skill.GetJ2();

				skill.SetCrit((skill_t0 * 0.02f + (skill_j1 * (skill_level * 0.003f) + (skill_j1 * 0.01f))));
				skill.SetRatio((skill_j2 * 0.01f + (skill_j2 * (skill_level * 0.02f + 0.1f) + 1.0f)));
				skill.SetPlus(((90 * skill_j0) + ((skill_level * 0.2f + 3.0f) * ((player_res2 * skill_j0)) + ((14 * skill_level) + (skill_level * (skill_level * 0.091f))) + 543.0f)));
				player.SetPerform(0);
			}
		}
		public class GState4 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 600;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_res2 = player.GetRes2();
				int				skill_level = skill.GetLevel();
				int				skill_t0 = skill.GetT0();
				int				skill_j0 = skill.GetJ0();
				int				skill_j1 = skill.GetJ1();
				int				skill_j2 = skill.GetJ2();

				skill.SetCrit((skill_t0 * 0.02f + (skill_j1 * (skill_level * 0.003f) + (skill_j1 * 0.01f))));
				skill.SetRatio((skill_j2 * 0.01f + (skill_j2 * (skill_level * 0.02f + 0.1f) + 1.0f)));
				skill.SetPlus(((90 * skill_j0) + ((skill_level * 0.2f + 3.0f) * ((player_res2 * skill_j0)) + ((14 * skill_level) + (skill_level * (skill_level * 0.091f))) + 543.0f)));
				player.SetPerform(0);
			}
		}
		public GSkill3051Stub()
			: base(3051)
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
			doenchant = false;
			dobless = false;
			autoattack = true;
			allowform = 0;
			credittype = 0;
			clearmask = 1;
			skill_limit = 0;
			skillelemsnum = 3;
			skillelemsfactor = 3.000000f;
			serialskill = 0;
			charge = 0;
			chargedist = 0.000000f;
			succeedskillcolor = 1;
			succeedskillcolornum = 1;
			comboskill = 1;
			need_item = false;
			item1_id = -1;
			item1_num = 0;
			item2_id = -1;
			item2_num = 0;
			item_relation = 0;
			weapon_limit = 12;
			SetAction(0,"Ìì»ª_¾ÅÏö»·Åå");
			SetAction(1,"0");
			SetAction(2,"0");
			SetAction(3,"0");
			SetAction(4,"0");
			SetAction(5,"0");
			SetAction(6,"0");
			SetAction(7,"0");
			SetAction(8,"0");
			SetAction(9,"0");
			SetAction(10,"0");
			SetAction(11,"0");
			SetAction(12,"Ìì»ª_¾ÅÏö»·Åå");
			SetAction(13,"");
			SetAction(14,"");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"Ìì»ª_Æï³Ë_¾ÅÏö»·Åå");
			SetAction(19,"0");
			SetAction(20,"0");
			SetAction(21,"0");
			SetAction(22,"0");
			SetAction(23,"0");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"Ìì»ª_Æï³Ë_¾ÅÏö»·Åå");
			name = "ÉñÒý£ºÃ·»¨ÈýÅª<Ðþ>";
			nativename = "ÉñÒý£ºÃ·»¨ÈýÅª<Ðþ>";
			icon = "ÏÉ¡¤ÉñÒý£ºÃ·»¨ÈýÅª.dds";
			SetTalent(0,2617);
			SetTalent(1,2605);
			SetTalent(2,2606);
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
			skill_class = 8;
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
			int				skill_t2 = skill.GetT2();

			return 10000 - 2000 * skill_t2;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={120,122,124,126,128,130,131,132,133,134,135,136,137,138,139,141,143,145,147,149};return array[level-1];
		}
		public override float GetRadius(GSkill skill)
		{
			int				skill_t1 = skill.GetT1();

			return (2 * skill_t1 + 20);
		}
		public override float GetPraydistance(GSkill skill)
		{
			int				skill_t1 = skill.GetT1();

			return (2 * skill_t1 + 17);
		}
		public override float GetCastdistance(GSkill skill)
		{
			int				skill_t1 = skill.GetT1();

			return (2 * skill_t1 + 15);
		}
		public override float GetEffectdistance(GSkill skill)
		{
			int				skill_t1 = skill.GetT1();

			return (2 * skill_t1 + 30);
		}
		public override float GetMpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (25 * skill_level + 1650);
		}
		public override int GetCoverage(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return skill_level + 5;
		}
		public override int GetSkillElem(int index)
		{
			int[] array={2919,2920,2921};return array[index-1];
		}
		public override int GetComboSkillCapacity(int level)
		{
			int[] array={1,1,1,2,2,2,2,3,3,3,3,4,4,4,4,5,5,5,5,6};return array[level-1];
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={2500};return array[index];
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

			return 4 * skill_level * skill_level + (34 * skill_level) + 200;
		}
	}
	public class GSkill3051 : GSkill
	{
		public GSkill3051()
			: base(3051)
		{
			
		}
	}
	public class GSkill3052Stub : GSkillStub
	{
		public class GState1 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 1200;
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

				player.SetPerform(1);
			}
		}
		public GSkill3052Stub()
			: base(3052)
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
			weapon_limit = 12;
			SetAction(0,"Ìì»ª_×±Ì¨ÇïË¼");
			SetAction(1,"0");
			SetAction(2,"0");
			SetAction(3,"0");
			SetAction(4,"0");
			SetAction(5,"0");
			SetAction(6,"0");
			SetAction(7,"0");
			SetAction(8,"0");
			SetAction(9,"0");
			SetAction(10,"0");
			SetAction(11,"0");
			SetAction(12,"Ìì»ª_×±Ì¨ÇïË¼");
			SetAction(13,"");
			SetAction(14,"");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"Ìì»ª_Æï³Ë_×±Ì¨ÇïË¼");
			SetAction(19,"0");
			SetAction(20,"0");
			SetAction(21,"0");
			SetAction(22,"0");
			SetAction(23,"0");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"Ìì»ª_Æï³Ë_×±Ì¨ÇïË¼");
			name = "ÇíÌ¨ÑÅÔÏ<Ðþ>";
			nativename = "ÇíÌ¨ÑÅÔÏ<Ðþ>";
			icon = "ÏÉ¡¤ÇíÌ¨ÑÅÔÏ.dds";
			SetTalent(0,2596);
			SetTalent(1,2600);
			SetTalent(2,2718);
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
			skill_class = 8;
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

			return 60000 - 8000 * skill_t1;
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
			return 15.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (300 * skill_level + 3500);
		}
		public override int GetCoverage(GSkill skill)
		{
			return 6;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();

			victim.SetProbability(120.0f);
			victim.SetRatio(0.0f);
			victim.SetValue(((1000 * skill_level + 5000)));
			victim.SetHeal(true);
			victim.SetProbability(((5 * skill_t0 + (3 * skill_level) + 30)));
			victim.SetRatio(4099.0f);
			victim.SetAmount(15.0f);
			victim.SetValue(14.0f);
			victim.SetDispel(true);
			victim.SetProbability(-1.0f);
			victim.SetRatio(48.0f);
			victim.SetAmount(49.0f);
			victim.SetValue(50.0f);
			victim.SetDispel(true);
			victim.SetProbability(((3 * skill_level + 10)));
			victim.SetTime(((500 * skill_level + 2050)));
			victim.SetRatio((skill_level * 0.02f + 0.2f));
			victim.SetValue(2.0f);
			victim.SetSkillreflect(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_res1 = player.GetRes1();
			int				skill_level = skill.GetLevel();
			int				skill_t2 = skill.GetT2();

			victim.SetProbability(((skill_t2 + (4 * skill_level) + 14)));
			victim.SetTime(((2000 * norm(skill_t2) + 5000)));
			victim.SetRatio(1.0f);
			victim.SetSkillmirror(true);
			victim.SetTime(((1000 * skill_level + 2050)));
			victim.SetBuffid(1);
			victim.SetValue((skill_level * (player_res1 * 0.01f)));
			victim.SetAddantidizzy(true);
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={2501};return array[index];
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

			return 4 * skill_level * skill_level + (34 * skill_level) + 200;
		}
	}
	public class GSkill3052 : GSkill
	{
		public GSkill3052()
			: base(3052)
		{
			
		}
	}
	public class GSkill3053Stub : GSkillStub
	{
		public class GState1 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 1100;
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
		public GSkill3053Stub()
			: base(3053)
		{
			occupation = 168;
			maxlevel = 20;
			maxlearn = 20;
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
			SetAction(0,"Ä§_×ÏÃ¢±¬·¢");
			SetAction(1,"Ä§_×ÏÃ¢±¬·¢");
			SetAction(2,"Ä§_×ÏÃ¢±¬·¢");
			SetAction(3,"Ä§_×ÏÃ¢±¬·¢");
			SetAction(4,"Ä§_×ÏÃ¢±¬·¢");
			SetAction(5,"Ä§_×ÏÃ¢±¬·¢");
			SetAction(6,"Ä§_×ÏÃ¢±¬·¢");
			SetAction(7,"Ä§_×ÏÃ¢±¬·¢");
			SetAction(8,"Ä§_×ÏÃ¢±¬·¢");
			SetAction(9,"Ä§_×ÏÃ¢±¬·¢");
			SetAction(10,"Ä§_×ÏÃ¢±¬·¢");
			SetAction(11,"Ä§_×ÏÃ¢±¬·¢");
			SetAction(12,"Ä§_×ÏÃ¢±¬·¢");
			SetAction(13,"Ä§_×ÏÃ¢±¬·¢");
			SetAction(14,"Ä§_×ÏÃ¢±¬·¢");
			SetAction(15,"Ä§_×ÏÃ¢±¬·¢");
			SetAction(16,"Ä§_×ÏÃ¢±¬·¢");
			SetAction(17,"Ä§_×ÏÃ¢±¬·¢");
			SetAction(18,"Æï³Ë_Ä§_×ÏÃ¢±¬·¢");
			SetAction(19,"Æï³Ë_Ä§_×ÏÃ¢±¬·¢");
			SetAction(20,"Æï³Ë_Ä§_×ÏÃ¢±¬·¢");
			SetAction(21,"Æï³Ë_Ä§_×ÏÃ¢±¬·¢");
			SetAction(22,"Æï³Ë_Ä§_×ÏÃ¢±¬·¢");
			SetAction(23,"Æï³Ë_Ä§_×ÏÃ¢±¬·¢");
			SetAction(24,"Æï³Ë_Ä§_×ÏÃ¢±¬·¢");
			SetAction(25,"Æï³Ë_Ä§_×ÏÃ¢±¬·¢");
			SetAction(26,"Æï³Ë_Ä§_×ÏÃ¢±¬·¢");
			SetAction(27,"Æï³Ë_Ä§_×ÏÃ¢±¬·¢");
			SetAction(28,"Æï³Ë_Ä§_×ÏÃ¢±¬·¢");
			SetAction(29,"Æï³Ë_Ä§_×ÏÃ¢±¬·¢");
			SetAction(30,"Æï³Ë_Ä§_×ÏÃ¢±¬·¢");
			name = "ÉñÁ¦±¬·¢";
			nativename = "ÉñÁ¦±¬·¢";
			icon = "ÔªÆø±¬·¢-Ä§.dds";
			SetTalent(0,3711);
			SetTalent(1,4449);
			SetTalent(2,4450);
			SetTalent(3,4451);
			SetTalent(4,0);
			SetTalent(5,0);
			SetTalent(6,0);
			SetTalent(7,0);
			talent_size = 4;
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

			return 300000 - 5000 * skill_level;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={120,122,124,126,128,130,131,132,133,134,135,136,137,138,139,141,143,145,147,150};return array[level-1];
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
			int				skill_t0 = skill.GetT0();
			int				skill_t1 = skill.GetT1();
			int				skill_t2 = skill.GetT2();
			int				skill_t3 = skill.GetT3();

			victim.SetTime(((3000 * skill_t3 + (5000 * skill_t2 + (8000 * skill_t1 + (8000 * skill_t0 + ((norm(skill_level / 15)) * (1000 * skill_level - 15000) + (2000 * skill_level))))) + 5000)));
			victim.SetRatio((skill_level * 0.01f));
			victim.SetBuffid(1);
			victim.SetAmount(((((2 * (skill_level * skill_level + (5 * skill_level)) + 184) * ((2 * skill_level) + (norm(skill_level / 15)) * (skill_level - 15) + 5)) * 0.25f) - ((norm(skill_level / 15)) * (skill_level - 15) + (2 * skill_level) + 5) * ((2 * (skill_level * skill_level + (5 * skill_level)) + 184) * (skill_t3 * 0.05f + (skill_t2 * 0.1f + (skill_t1 * 0.25f + (skill_t0 * 0.25f)))))));
			victim.SetMiracleburstmo(true);
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
			int				skill_t0 = skill.GetT0();

			return (2 * (skill_level * skill_level + (5 * skill_level))) - skill_t0 * (2 * (skill_level * skill_level + (5 * skill_level)) + 184) + 184;
		}
	}
	public class GSkill3053 : GSkill
	{
		public GSkill3053()
			: base(3053)
		{
			
		}
	}
	public class GSkill3054Stub : GSkillStub
	{
		public GSkill3054Stub()
			: base(3054)
		{
			occupation = 168;
			maxlevel = 20;
			maxlearn = 20;
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
			SetAction(0,"0");
			SetAction(1,"0");
			SetAction(2,"0");
			SetAction(3,"0");
			SetAction(4,"0");
			SetAction(5,"0");
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
			SetAction(18,"0");
			SetAction(19,"0");
			SetAction(20,"0");
			SetAction(21,"0");
			SetAction(22,"0");
			SetAction(23,"0");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "ÃðÄ§";
			nativename = "ÃðÄ§";
			icon = "¿ËÄ§¡¤Ä§.dds";
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
			int[] array={120,122,124,126,128,130,131,132,133,134,135,136,137,138,139,141,143,145,147,149};return array[level-1];
		}
		public override bool TakeEffect(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			int				skill_level = skill.GetLevel();

			player.SetPasdecrestrainmo((skill_level * 0.01005f));
			player.SetPasinccrit((D2INT(skill_level / 19.9f) * 0.0501f));
			return true;
		}
		public override int GetDivinityExp(int level)
		{
			int[] array={200,500,500,600,900,1900,3200,4500,8600,10800,20700,32200,51000,65200,84800,159900,260100,427500,743600,1450600};return array[level-1];
		}
		public override int GetDivinityLevel(int level)
		{
			int[] array={1,3,5,7,9,11,14,17,21,25,29,34,39,44,49,55,61,67,73,79};return array[level-1];
		}
	}
	public class GSkill3054 : GSkill
	{
		public GSkill3054()
			: base(3054)
		{
			
		}
	}
	public class GSkill3055Stub : GSkillStub
	{
		public GSkill3055Stub()
			: base(3055)
		{
			occupation = 168;
			maxlevel = 20;
			maxlearn = 20;
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
			SetAction(0,"0");
			SetAction(1,"0");
			SetAction(2,"0");
			SetAction(3,"0");
			SetAction(4,"0");
			SetAction(5,"0");
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
			SetAction(18,"0");
			SetAction(19,"0");
			SetAction(20,"0");
			SetAction(21,"0");
			SetAction(22,"0");
			SetAction(23,"0");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "Ãð·ð";
			nativename = "Ãð·ð";
			icon = "¿Ë·ð¡¤Ä§.dds";
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
			int[] array={120,122,124,126,128,130,131,132,133,134,135,136,137,138,139,141,143,145,147,149};return array[level-1];
		}
		public override bool TakeEffect(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			int				skill_level = skill.GetLevel();

			player.SetPasdecrestrainfo((skill_level * 0.01005f));
			player.SetPasaddsmite((D2INT(skill_level / 19.9f) * 0.5f));
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
	}
	public class GSkill3055 : GSkill
	{
		public GSkill3055()
			: base(3055)
		{
			
		}
	}
	public class GSkill3056Stub : GSkillStub
	{
		public GSkill3056Stub()
			: base(3056)
		{
			occupation = 168;
			maxlevel = 20;
			maxlearn = 20;
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
			SetAction(0,"0");
			SetAction(1,"0");
			SetAction(2,"0");
			SetAction(3,"0");
			SetAction(4,"0");
			SetAction(5,"0");
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
			SetAction(18,"0");
			SetAction(19,"0");
			SetAction(20,"0");
			SetAction(21,"0");
			SetAction(22,"0");
			SetAction(23,"0");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "ÃðÏÉ";
			nativename = "ÃðÏÉ";
			icon = "¿ËÏÉ¡¤Ä§.dds";
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
			int[] array={120,122,124,126,128,130,131,132,133,134,135,136,137,138,139,141,143,145,147,149};return array[level-1];
		}
		public override bool TakeEffect(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			int				skill_level = skill.GetLevel();

			player.SetPasdecrestrainxian((skill_level * 0.01005f));
			player.SetPasincskillaccu(((50 * D2INT(skill_level / 19.9f))));
			return true;
		}
		public override int GetDivinityExp(int level)
		{
			int[] array={400,500,500,700,1500,3100,3900,6500,9100,10800,20700,26500,39600,52900,84300,119800,229700,389600,525000,1237600};return array[level-1];
		}
		public override int GetDivinityLevel(int level)
		{
			int[] array={2,4,6,8,10,13,16,19,22,25,29,33,37,42,47,53,59,65,71,77};return array[level-1];
		}
	}
	public class GSkill3056 : GSkill
	{
		public GSkill3056()
			: base(3056)
		{
			
		}
	}
	public class GSkill3057Stub : GSkillStub
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
				int				player_maxatk = player.GetMaxatk();

				player.SetVar1(player_maxatk);
				player.SetPerform(1);
			}
		}
		public GSkill3057Stub()
			: base(3057)
		{
			occupation = 168;
			maxlevel = 20;
			maxlearn = 20;
			eventflag = 0;
			spcost = 1;
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
			SetAction(0,"Ä§_ÉñÊ¥×ÆÉÕ");
			SetAction(1,"Ä§_ÉñÊ¥×ÆÉÕ");
			SetAction(2,"Ä§_ÉñÊ¥×ÆÉÕ");
			SetAction(3,"Ä§_ÉñÊ¥×ÆÉÕ");
			SetAction(4,"Ä§_ÉñÊ¥×ÆÉÕ");
			SetAction(5,"Ä§_ÉñÊ¥×ÆÉÕ");
			SetAction(6,"Ä§_ÉñÊ¥×ÆÉÕ");
			SetAction(7,"Ä§_ÉñÊ¥×ÆÉÕ");
			SetAction(8,"Ä§_ÉñÊ¥×ÆÉÕ");
			SetAction(9,"Ä§_ÉñÊ¥×ÆÉÕ");
			SetAction(10,"Ä§_ÉñÊ¥×ÆÉÕ");
			SetAction(11,"Ä§_ÉñÊ¥×ÆÉÕ");
			SetAction(12,"Ä§_ÉñÊ¥×ÆÉÕ");
			SetAction(13,"Ä§_ÉñÊ¥×ÆÉÕ");
			SetAction(14,"Ä§_ÉñÊ¥×ÆÉÕ");
			SetAction(15,"Ä§_ÉñÊ¥×ÆÉÕ");
			SetAction(16,"Ä§_ÉñÊ¥×ÆÉÕ");
			SetAction(17,"Ä§_ÉñÊ¥×ÆÉÕ");
			SetAction(18,"Æï³Ë_Ä§_ÉñÊ¥×ÆÉÕ");
			SetAction(19,"Æï³Ë_Ä§_ÉñÊ¥×ÆÉÕ");
			SetAction(20,"Æï³Ë_Ä§_ÉñÊ¥×ÆÉÕ");
			SetAction(21,"Æï³Ë_Ä§_ÉñÊ¥×ÆÉÕ");
			SetAction(22,"Æï³Ë_Ä§_ÉñÊ¥×ÆÉÕ");
			SetAction(23,"Æï³Ë_Ä§_ÉñÊ¥×ÆÉÕ");
			SetAction(24,"Æï³Ë_Ä§_ÉñÊ¥×ÆÉÕ");
			SetAction(25,"Æï³Ë_Ä§_ÉñÊ¥×ÆÉÕ");
			SetAction(26,"Æï³Ë_Ä§_ÉñÊ¥×ÆÉÕ");
			SetAction(27,"Æï³Ë_Ä§_ÉñÊ¥×ÆÉÕ");
			SetAction(28,"Æï³Ë_Ä§_ÉñÊ¥×ÆÉÕ");
			SetAction(29,"Æï³Ë_Ä§_ÉñÊ¥×ÆÉÕ");
			SetAction(30,"Æï³Ë_Ä§_ÉñÊ¥×ÆÉÕ");
			name = "ÑªÖä";
			nativename = "ÑªÖä";
			icon = "Ð°¶ñÓ¡¼Ç.dds";
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

			return 60000 - 2000 * skill_level;
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
			return 25.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 18.000000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 30.000000f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_skilldodge = player.GetSkilldodge();
			int				player_var1 = player.GetVar1();
			int				skill_level = skill.GetLevel();

			/*
			if ( player.GetObjectType() )
			{
			if ( player_skilldodge > 2000 )
			v32 = 0.0f;
			else
			d = 120.0f;
			}
			else
			{
			d = 120.0f;
			}
			victim.SetProbability(d);
			victim.SetTime(((1000 * skill_level + 4050)));
			victim.SetBuffid(1);
			victim.SetAmount(((skill_level + 4) * ((skill_level * 0.02f + 0.2f) * (player_var1 * 0.1f))));
			victim.SetValue(((skill_level * 0.02f + 0.1f) * ((skill_level + 4) * ((skill_level * 0.02f + 0.2f) * (player_var1 * 0.1f)))));
			victim.SetIgnite(true);
			victim.SetProbability(120.0f);
			victim.SetTime(((1000 * skill_level + 4050)));
			victim.SetRatio((skill_level * 0.01f));
			victim.SetBuffid(1);
			victim.SetDeccritrate(true);
			victim.SetProbability(((3 * skill_level + 30)));
			victim.SetAmount(1.0f);
			victim.SetClearbuff(true);
			*/
			return true;
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
	public class GSkill3057 : GSkill
	{
		public GSkill3057()
			: base(3057)
		{
			
		}
	}
	public class GSkill3058Stub : GSkillStub
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
				int				player_res1 = player.GetRes1();

				player.SetVar1(player_res1);
				player.SetPerform(1);
			}
		}
		public GSkill3058Stub()
			: base(3058)
		{
			occupation = 168;
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
			SetAction(0,"Ä§_ÖÂËÀ´ò»÷");
			SetAction(1,"Ä§_ÖÂËÀ´ò»÷");
			SetAction(2,"Ä§_ÖÂËÀ´ò»÷");
			SetAction(3,"Ä§_ÖÂËÀ´ò»÷");
			SetAction(4,"Ä§_ÖÂËÀ´ò»÷");
			SetAction(5,"Ä§_ÖÂËÀ´ò»÷");
			SetAction(6,"Ä§_ÖÂËÀ´ò»÷");
			SetAction(7,"Ä§_ÖÂËÀ´ò»÷");
			SetAction(8,"Ä§_ÖÂËÀ´ò»÷");
			SetAction(9,"Ä§_ÖÂËÀ´ò»÷");
			SetAction(10,"Ä§_ÖÂËÀ´ò»÷");
			SetAction(11,"Ä§_ÖÂËÀ´ò»÷");
			SetAction(12,"Ä§_ÖÂËÀ´ò»÷");
			SetAction(13,"Ä§_ÖÂËÀ´ò»÷");
			SetAction(14,"Ä§_ÖÂËÀ´ò»÷");
			SetAction(15,"Ä§_ÖÂËÀ´ò»÷");
			SetAction(16,"Ä§_ÖÂËÀ´ò»÷");
			SetAction(17,"Ä§_ÖÂËÀ´ò»÷");
			SetAction(18,"Æï³Ë_Ä§_ÖÂËÀ´ò»÷");
			SetAction(19,"Æï³Ë_Ä§_ÖÂËÀ´ò»÷");
			SetAction(20,"Æï³Ë_Ä§_ÖÂËÀ´ò»÷");
			SetAction(21,"Æï³Ë_Ä§_ÖÂËÀ´ò»÷");
			SetAction(22,"Æï³Ë_Ä§_ÖÂËÀ´ò»÷");
			SetAction(23,"Æï³Ë_Ä§_ÖÂËÀ´ò»÷");
			SetAction(24,"Æï³Ë_Ä§_ÖÂËÀ´ò»÷");
			SetAction(25,"Æï³Ë_Ä§_ÖÂËÀ´ò»÷");
			SetAction(26,"Æï³Ë_Ä§_ÖÂËÀ´ò»÷");
			SetAction(27,"Æï³Ë_Ä§_ÖÂËÀ´ò»÷");
			SetAction(28,"Æï³Ë_Ä§_ÖÂËÀ´ò»÷");
			SetAction(29,"Æï³Ë_Ä§_ÖÂËÀ´ò»÷");
			SetAction(30,"Æï³Ë_Ä§_ÖÂËÀ´ò»÷");
			name = "¶áÆÇ";
			nativename = "¶áÆÇ";
			icon = "Ð°¶ñ½ûïÀ.dds";
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
			return 18.000000f;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 18.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 16.000000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 15.000000f;
		}
		public override int GetCoverage(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return 2 * norm(skill_level / 19.9f) + (D2INT(skill_level / 4.9f)) + 3;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_var1 = player.GetVar1();
			int				skill_level = skill.GetLevel();

			/*
			victim.SetProbability(((10 * norm(skill_level / 19.9f) + (3 * skill_level) + 20)));
			victim.SetPullback(true);
			if ( zrand(100) + 80 <= 100 )
			{
			v16 = 0.0f;
			}
			else
			{
			if ( player_var1 <= 900 )
			{
			v15 = 900.0f;
			}
			else
			{
			v15 = player_var1;
			}
			v16 = v15;
			}
			victim.SetProbability(v16);
			if ( player.GetIsignite() )
			t = (200 * skill_level + 5050);
			else
			victim.SetTime(((200 * skill_level + 1050)));
			victim.SetDizzy(true);
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

			return 4 * skill_level * skill_level + (50 * skill_level) + 190;
		}
	}
	public class GSkill3058 : GSkill
	{
		public GSkill3058()
			: base(3058)
		{
			
		}
	}
	public class GSkill3059Stub : GSkillStub
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

				player.SetPerform(1);
			}
		}
		public GSkill3059Stub()
			: base(3059)
		{
			occupation = 168;
			maxlevel = 20;
			maxlearn = 20;
			eventflag = 0;
			spcost = 1;
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
			SetAction(0,"Ä§_ºÚ°µÊõ");
			SetAction(1,"Ä§_ºÚ°µÊõ");
			SetAction(2,"Ä§_ºÚ°µÊõ");
			SetAction(3,"Ä§_ºÚ°µÊõ");
			SetAction(4,"Ä§_ºÚ°µÊõ");
			SetAction(5,"Ä§_ºÚ°µÊõ");
			SetAction(6,"Ä§_ºÚ°µÊõ");
			SetAction(7,"Ä§_ºÚ°µÊõ");
			SetAction(8,"Ä§_ºÚ°µÊõ");
			SetAction(9,"Ä§_ºÚ°µÊõ");
			SetAction(10,"Ä§_ºÚ°µÊõ");
			SetAction(11,"Ä§_ºÚ°µÊõ");
			SetAction(12,"Ä§_ºÚ°µÊõ");
			SetAction(13,"Ä§_ºÚ°µÊõ");
			SetAction(14,"Ä§_ºÚ°µÊõ");
			SetAction(15,"Ä§_ºÚ°µÊõ");
			SetAction(16,"Ä§_ºÚ°µÊõ");
			SetAction(17,"Ä§_ºÚ°µÊõ");
			SetAction(18,"Æï³Ë_Ä§_ºÚ°µÊõ");
			SetAction(19,"Æï³Ë_Ä§_ºÚ°µÊõ");
			SetAction(20,"Æï³Ë_Ä§_ºÚ°µÊõ");
			SetAction(21,"Æï³Ë_Ä§_ºÚ°µÊõ");
			SetAction(22,"Æï³Ë_Ä§_ºÚ°µÊõ");
			SetAction(23,"Æï³Ë_Ä§_ºÚ°µÊõ");
			SetAction(24,"Æï³Ë_Ä§_ºÚ°µÊõ");
			SetAction(25,"Æï³Ë_Ä§_ºÚ°µÊõ");
			SetAction(26,"Æï³Ë_Ä§_ºÚ°µÊõ");
			SetAction(27,"Æï³Ë_Ä§_ºÚ°µÊõ");
			SetAction(28,"Æï³Ë_Ä§_ºÚ°µÊõ");
			SetAction(29,"Æï³Ë_Ä§_ºÚ°µÊõ");
			SetAction(30,"Æï³Ë_Ä§_ºÚ°µÊõ");
			name = "ÒµÕÏ";
			nativename = "ÒµÕÏ";
			icon = "ºÚ°µÊõ.dds";
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
		public override float GetPraydistance(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (skill_level + 16);
		}
		public override float GetCastdistance(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (skill_level + 12);
		}
		public override float GetEffectdistance(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (skill_level + 18);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_hp = player.GetHp();
			int				skill_level = skill.GetLevel();

			/*
			victim.SetProbability(((30 * norm(skill_level / 19.9f) + (3 * skill_level) + 20)));
			victim.SetTime(((4000 * norm(skill_level / 19.9f) + (300 * skill_level) + 2000)));
			victim.SetDarkness(true);
			if ( player.GetIsignite() )
			v21 = 120.0f;
			else
			victim.SetProbability(0.0f);
			victim.SetTime(6000.0f);
			victim.SetBuffid(4);
			victim.SetAmount(1000.0f);
			victim.SetValue((player_hp * 0.2f));
			victim.SetSubhp(true);
			*/
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

			return 3 * skill_level * skill_level + (30 * skill_level) + 180;
		}
	}
	public class GSkill3059 : GSkill
	{
		public GSkill3059()
			: base(3059)
		{
			
		}
	}
}
