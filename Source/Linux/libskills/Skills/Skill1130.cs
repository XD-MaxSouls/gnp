using System;
using System.Text;

namespace SKILL
{
	public class GSkill1130Stub : GSkillStub
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
		public GSkill1130Stub()
			: base(1130)
		{
			occupation = 28;
			maxlevel = 20;
			maxlearn = 6;
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
			allowform = 7;
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
			SetAction(0,"Î×¶¾¶·ÕÎ");
			SetAction(1,"Î×¶¾¶·ÕÎ");
			SetAction(2,"Î×¶¾¶·ÕÎ");
			SetAction(3,"Î×¶¾¶·ÕÎ");
			SetAction(4,"Î×¶¾¶·ÕÎ");
			SetAction(5,"Î×¶¾¶·ÕÎ");
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
			SetAction(18,"Î×¶¾¶·ÕÎ");
			SetAction(19,"Î×¶¾¶·ÕÎ");
			SetAction(20,"Î×¶¾¶·ÕÎ");
			SetAction(21,"Î×¶¾¶·ÕÎ");
			SetAction(22,"Î×¶¾¶·ÕÎ");
			SetAction(23,"Î×¶¾¶·ÕÎ");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "Î×¶¾¶·ÕÎ";
			nativename = "Î×¶¾¶·ÕÎ";
			icon = "Î×¶¾¶·ÕÎ.dds";
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
			return 12.000000f;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 12.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 8.000000f;
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

			victim.SetProbability(100.0f);
			victim.SetTime(8100.0f);
			victim.SetRatio((skill_level * 0.02f));
			victim.SetInchurt(true);
			victim.SetProbability(100.0f);
			victim.SetTime(8100.0f);
			victim.SetBuffid(9);
			victim.SetValue(((25 * skill_level)));
			victim.SetSubattack(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetTime(3600000.0f);
			victim.SetRatio(0.0f);
			victim.SetAmount(22.0f);
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
			int[] array={1126};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={1};return array[index];
		}
	}
	public class GSkill1130 : GSkill
	{
		public GSkill1130()
			: base(1130)
		{
			
		}
	}
	public class GSkill1131Stub : GSkillStub
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

				skill.SetRatio((norm((zrand(5 * skill_t1 + 100)) / 100) * (skill_t1 * 0.06f) + (skill_t4 * 0.02f + (skill_t1 * 0.06f + 1.0f))));
				skill.SetCrit((norm(skill_t4 / 9.9f) * 0.03f + (skill_t3 * 0.01f)));
				skill.SetCrithurt((skill_t3 * 0.1f + (skill_level * 0.1f)));
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

				skill.SetRatio((norm((zrand(5 * skill_t1 + 100)) / 100) * (skill_t1 * 0.06f) + (skill_t4 * 0.02f + (skill_t1 * 0.06f + 1.0f))));
				skill.SetCrit((norm(skill_t4 / 9.9f) * 0.03f + (skill_t3 * 0.01f)));
				skill.SetCrithurt((skill_t3 * 0.1f + (skill_level * 0.1f)));
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

				skill.SetRatio((norm((zrand(5 * skill_t1 + 100)) / 100) * (skill_t1 * 0.06f) + (skill_t1 * 0.06f + ((3 * norm(zrand(108) / 100.0f)) + (skill_t4 * 0.02f + 1.0f)))));
				skill.SetCrit((norm(skill_t4 / 9.9f) * 0.03f + (skill_t3 * 0.01f)));
				skill.SetCrithurt((skill_t3 * 0.1f + (skill_level * 0.1f)));
				skill.SetPlus(((2 * (skill_level * player_level + (skill_level * skill_level + (25 * skill_level))) + 750)));
				player.SetPerform(0);
			}
		}
		public GSkill1131Stub()
			: base(1131)
		{
			occupation = 29;
			maxlevel = 7;
			maxlearn = 6;
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
			allowform = 1;
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
			SetAction(0,"¹íµÀ_Ãð»ê¿ñì­");
			SetAction(1,"¹íµÀ_Ãð»ê¿ñì­");
			SetAction(2,"¹íµÀ_Ãð»ê¿ñì­");
			SetAction(3,"¹íµÀ_Ãð»ê¿ñì­");
			SetAction(4,"¹íµÀ_Ãð»ê¿ñì­");
			SetAction(5,"¹íµÀ_Ãð»ê¿ñì­");
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
			SetAction(18,"¹íµÀ_Æï³Ë_Ãð»ê¿ñì­");
			SetAction(19,"¹íµÀ_Æï³Ë_Ãð»ê¿ñì­");
			SetAction(20,"¹íµÀ_Æï³Ë_Ãð»ê¿ñì­");
			SetAction(21,"¹íµÀ_Æï³Ë_Ãð»ê¿ñì­");
			SetAction(22,"¹íµÀ_Æï³Ë_Ãð»ê¿ñì­");
			SetAction(23,"¹íµÀ_Æï³Ë_Ãð»ê¿ñì­");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "Ãð»ê¿ñì­";
			nativename = "Ãð»ê¿ñì­";
			icon = "Ãð»ê¿ñì­.dds";
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
			int				skill_t1 = skill.GetT1();
			int				skill_t4 = skill.GetT4();

			return ((-1950 * skill_t0) - 650 * skill_t4) - 5850 * norm(skill_t1 / 1.9f) + 13000;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={135,135,135,135,136,137};return array[level-1];
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
			return 35;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_level = player.GetLevel();
			int				skill_level = skill.GetLevel();
			int				skill_t2 = skill.GetT2();

			victim.SetProbability(((1.0f - player_level * 0.002f) * 100.0f));
			victim.SetRatio((skill_level * 0.03f));
			victim.SetDrainmagic(true);
			victim.SetProbability(((skill_level * skill_level + (16 * skill_level) + 170)));
			victim.SetTime(12100.0f);
			victim.SetRatio(0.15000001f);
			victim.SetBuffid(1);
			victim.SetWeak(true);
			victim.SetProbability(((600 * norm(zrand(100) / (100 - 2 * skill_t2)))));
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
	public class GSkill1131 : GSkill
	{
		public GSkill1131()
			: base(1131)
		{
			
		}
	}
	public class GSkill1132Stub : GSkillStub
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
		public GSkill1132Stub()
			: base(1132)
		{
			occupation = 29;
			maxlevel = 6;
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
			SetAction(0,"Ð°Éñ°ÁÊÀ");
			SetAction(1,"Ð°Éñ°ÁÊÀ");
			SetAction(2,"Ð°Éñ°ÁÊÀ");
			SetAction(3,"Ð°Éñ°ÁÊÀ");
			SetAction(4,"Ð°Éñ°ÁÊÀ");
			SetAction(5,"Ð°Éñ°ÁÊÀ");
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
			SetAction(18,"Ð°Éñ°ÁÊÀ");
			SetAction(19,"Ð°Éñ°ÁÊÀ");
			SetAction(20,"Ð°Éñ°ÁÊÀ");
			SetAction(21,"Ð°Éñ°ÁÊÀ");
			SetAction(22,"Ð°Éñ°ÁÊÀ");
			SetAction(23,"Ð°Éñ°ÁÊÀ");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "Ð°Éñ°ÁÊÀ";
			nativename = "Ð°Éñ°ÁÊÀ";
			icon = "Ð°Éñ°ÁÊÀ.dds";
			SetTalent(0,1168);
			SetTalent(1,1169);
			SetTalent(2,1170);
			SetTalent(3,1109);
			SetTalent(4,1161);
			SetTalent(5,1165);
			SetTalent(6,0);
			SetTalent(7,0);
			talent_size = 6;
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
			int				skill_t0 = skill.GetT0();

			return 180000 - 18000 * skill_t0;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={135,136,136,138,139};return array[level-1];
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
			victim.SetRatio((skill_t1 * 0.02f + (skill_level * 0.04f)));
			victim.SetBuffid(1);
			victim.SetAmount(0.0f);
			victim.SetValue(0.0f);
			victim.SetAoshi(true);
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={1131};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={1};return array[index];
		}
	}
	public class GSkill1132 : GSkill
	{
		public GSkill1132()
			: base(1132)
		{
			
		}
	}
	public class GSkill1133Stub : GSkillStub
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
				int				skill_t0 = skill.GetT0();
				int				skill_t1 = skill.GetT1();

				skill.SetRatio((skill_t1 * 0.05f + 1.0f));
				skill.SetCrit((skill_level * 0.01f));
				skill.SetPlus(((2 * skill_level * skill_level + (45 * skill_level + (35 * skill_t0 * skill_level)) + 860)));
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
				int				skill_t0 = skill.GetT0();
				int				skill_t1 = skill.GetT1();

				skill.SetRatio((skill_t1 * 0.05f + 1.0f));
				skill.SetCrit((skill_level * 0.01f + 0.01f));
				skill.SetPlus(((2 * skill_level * skill_level + (45 * skill_level + (35 * skill_t0 * skill_level)) + 860)));
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
				int				skill_t0 = skill.GetT0();
				int				skill_t1 = skill.GetT1();

				skill.SetRatio((skill_t1 * 0.05f + 1.0f));
				skill.SetCrit((skill_level * 0.01f + 0.02f));
				skill.SetPlus(((2 * skill_level * skill_level + (45 * skill_level + (35 * skill_t0 * skill_level)) + 860)));
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
				int				skill_t0 = skill.GetT0();
				int				skill_t1 = skill.GetT1();

				skill.SetRatio((skill_t1 * 0.05f + 1.0f));
				skill.SetCrit((skill_level * 0.01f + 0.03f));
				skill.SetCrithurt(1.0f);
				skill.SetPlus(((2 * skill_level * skill_level + (45 * skill_level + (35 * skill_t0 * skill_level)) + 860)));
				player.SetPerform(0);
			}
		}
		public GSkill1133Stub()
			: base(1133)
		{
			occupation = 29;
			maxlevel = 5;
			maxlearn = 4;
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
			allowform = 2;
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
			SetAction(0,"Éñ¹íÂÒÎè");
			SetAction(1,"Éñ¹íÂÒÎè");
			SetAction(2,"Éñ¹íÂÒÎè");
			SetAction(3,"Éñ¹íÂÒÎè");
			SetAction(4,"Éñ¹íÂÒÎè");
			SetAction(5,"Éñ¹íÂÒÎè");
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
			SetAction(18,"Éñ¹íÂÒÎè");
			SetAction(19,"Éñ¹íÂÒÎè");
			SetAction(20,"Éñ¹íÂÒÎè");
			SetAction(21,"Éñ¹íÂÒÎè");
			SetAction(22,"Éñ¹íÂÒÎè");
			SetAction(23,"Éñ¹íÂÒÎè");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "Éñ¹íÂÒÎè";
			nativename = "Éñ¹íÂÒÎè";
			icon = "Éñ¹íÂÒÎè.dds";
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

			return 11000 - 1000 * skill_level;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={135,135,136,138};return array[level-1];
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
			int				skill_level = skill.GetLevel();

			victim.SetProbability(15.0f);
			victim.SetTime(12100.0f);
			victim.SetRatio((skill_level * 0.02001f));
			victim.SetBuffid(1);
			victim.SetDeccritrate(true);
			victim.SetProbability(15.0f);
			victim.SetTime(12100.0f);
			victim.SetRatio((skill_level * 0.05f));
			victim.SetBuffid(1);
			victim.SetDecdodge(true);
			victim.SetProbability(15.0f);
			victim.SetTime(12100.0f);
			victim.SetBuffid(1);
			victim.SetAmount((player_maxmp * 0.25f + 1.0f));
			victim.SetValue(((1000 * skill_level)));
			victim.SetSubmp(true);
			victim.SetProbability(((600 * norm(zrand(100) / (100 - 2 * skill_level)))));
			victim.SetTime(12100.0f);
			victim.SetSilent(true);
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={1132};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={1};return array[index];
		}
	}
	public class GSkill1133 : GSkill
	{
		public GSkill1133()
			: base(1133)
		{
			
		}
	}
	public class GSkill1134Stub : GSkillStub
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
				int				player_maxatk = player.GetMaxatk();
				int				skill_level = skill.GetLevel();
				int				skill_t4 = skill.GetT4();
				int				skill_t5 = skill.GetT5();
				int				skill_t6 = skill.GetT6();

				player.SetVar3((player.GetCultivation() == 1)?1:0);
				player.SetVar4((player.GetCultivation() == 4)?1:0);
				player.SetVar5((player.GetCultivation() == 2)?1:0);
				player.SetVar1(player_maxatk);
				player.SetVar2((int)player.GetSaint());
				float f = (0.02f * skill_level) + 0.48f;
				float ratio = 0.0f;
				if ( skill_t4 < skill_t5 )
				{
					ratio = (skill_t5 < skill_t6)?(skill_t6 * 0.02f + f):(skill_t5 * 0.02f + f);
				}
				else
				{
					ratio = (skill_t4 < skill_t6)?(skill_t6 * 0.02f + f):(skill_t4 * 0.02f + f);
				}
				skill.SetRatio(ratio);
				player.SetPerform(1);
			}
		}
		public GSkill1134Stub()
			: base(1134)
		{
			occupation = 29;
			maxlevel = 20;
			maxlearn = 2;
			eventflag = 0;
			spcost = 1;
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
			SetAction(0,"ÌìÑ¡µÀÔ¹");
			SetAction(1,"ÌìÑ¡µÀÔ¹");
			SetAction(2,"ÌìÑ¡µÀÔ¹");
			SetAction(3,"ÌìÑ¡µÀÔ¹");
			SetAction(4,"ÌìÑ¡µÀÔ¹");
			SetAction(5,"ÌìÑ¡µÀÔ¹");
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
			SetAction(18,"ÌìÑ¡µÀÔ¹");
			SetAction(19,"ÌìÑ¡µÀÔ¹");
			SetAction(20,"ÌìÑ¡µÀÔ¹");
			SetAction(21,"ÌìÑ¡µÀÔ¹");
			SetAction(22,"ÌìÑ¡µÀÔ¹");
			SetAction(23,"ÌìÑ¡µÀÔ¹");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "ÌìÑ¡µÀÔ¹";
			nativename = "ÌìÑ¡µÀÔ¹";
			icon = "ÌìÑ¡µÀÔ¹.dds";
			SetTalent(0,1185);
			SetTalent(1,1187);
			SetTalent(2,1189);
			SetTalent(3,2062);
			SetTalent(4,2947);
			SetTalent(5,4112);
			SetTalent(6,4530);
			SetTalent(7,0);
			talent_size = 7;
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
			int[] array={139,141};return array[level-1];
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

			return (625 * skill_level + 625);
		}
		public override int GetCoverage(GSkill skill)
		{
			return 25;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_level = player.GetLevel();
			int				player_hp = player.GetHp();
			int				player_maxhp = player.GetMaxhp();
			int				player_maxatk = player.GetMaxatk();
			int				player_var1 = player.GetVar1();
			int				player_var2 = player.GetVar2();
			int				player_var3 = player.GetVar3();
			int				player_var4 = player.GetVar4();
			int				player_var5 = player.GetVar5();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();
			int				skill_t1 = skill.GetT1();
			int				skill_t2 = skill.GetT2();
			int				skill_t3 = skill.GetT3();
			int				skill_t4 = skill.GetT4();
			int				skill_t5 = skill.GetT5();

			float d = 0.0f;
			while (true)
			{
				if (player.GetSglevel() == 0)
				{
					d = (skill_t2 * 0.1f + 1.0f) * ((skill_t3 * 0.03f + (1.0f - player_level * 0.002f)) * 100.0f);
					break;
				}
				float v144 = (skill_t2 + skill_t3 + 40) * player_var5 + ((skill_t2 + 30) * player_var4 + (player_var3 * (skill_t2 + 30)));
				float v143 = (player_var2 - player.GetSaint()) / 10.0f;
				if ((player_var1 - player_maxatk) / 200 > 20)
				{
					if ((v144 + 20) + v143 < 25.0f)
					{
						d = 25.0f;
						break;
					}
				}
				else if ((player_var1 - player_maxatk) / 200 >= -20)
				{
					if ((v144 + (player_var1 - player_maxatk) / 200) + v143 < 25.0f)
					{
						d = 25.0f;
						break;
					}
				}
				else if ((v144 - 20) + v143 < 25.0f)
				{
					d = 25.0f;
					break;
				}
				d = (85 * player_var5 + (65 * (player_var4 + player_var3)));
				float v138 = ((skill_t2 + 30) * player_var4 + (player_var3 * (skill_t2 + 30))) + (skill_t2 + skill_t3 + 40) * player_var5;
				if ((player_var1 - player_maxatk) / 200 > 20)
				{
					if ((v144 + 20) + v143 <= d)
					{
						d = ((v138 + 20)) + v143;
						break;
					}
				}
				else
				{
					if ((player_var1 - player_maxatk) / 200 < -20)
					{
						if ((v144 - 20) + v143 <= d)
						{
							d = ((v138 - 20)) + v143;
							break;
						}
					}
					else
					{
						if ((v144 + (player_var1 - player_maxatk) / 200) + v143 <= d)
						{
							d = ((v138 + (player_var1 - player_maxatk) / 200)) + v143;
							break;
						}
					}
				}
				break;
			}
			victim.SetProbability(d);
			victim.SetTime(((60000 - 2000 * skill_t2)));
			victim.SetBuffid(1);
			victim.SetAmount((player_hp * (skill_level * (skill_t0 * 0.005f)) + ((skill_t0 * 0.1f + 1.0f) * ((2 * skill_level * player_maxhp)))));
			victim.SetValue(((2000 * skill_level)));
			victim.SetHpleak3(true);
			victim.SetProbability(((1.0f - player_level * 0.002f) * ((5 * skill_level))));
			victim.SetRatio(1.0f);
			victim.SetDrainmagic(true);
			victim.SetProbability(((5 * skill_level)));
			victim.SetTime(((2000 * skill_t1 + (3000 * skill_level) + 100)));
			victim.SetBuffid(1);
			victim.SetValue(10000.0f);
			victim.SetSubdefence(true);
			float ability = 0.0f;
			float s = 5 * skill_level;
			if ( skill_t4 < skill_t5 )
			{
				ability = (skill_t5 < player.GetSkilllevel(4530))?(s + 2 * player.GetSkilllevel(4530)):(s + 2 * skill_t5);
			}
			else
			{
				ability = (skill_t4 < player.GetSkilllevel(4530))?(s + 2 * player.GetSkilllevel(4530)):(s + 2 * skill_t4);
			}
			victim.SetProbability(ability);
			victim.SetTime(((2000 * (skill_t1 + skill_level) + 100)));
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

			victim.SetProbability(100.0f);
			victim.SetTime(8100.0f);
			victim.SetBuffid(5);
			victim.SetValue((player_mp * 0.004f + 1.0f));
			victim.SetAdddefence(true);
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
			int[] array={3};return array[index];
		}
	}
	public class GSkill1134 : GSkill
	{
		public GSkill1134()
			: base(1134)
		{
			
		}
	}
	public class GSkill1135Stub : GSkillStub
	{
		public GSkill1135Stub()
			: base(1135)
		{
			occupation = 129;
			maxlevel = 500;
			maxlearn = 10;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 13;
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
			name = "¼¦³á¼ÓÑª";
			nativename = "¼¦³á¼ÓÑª";
			icon = "";
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

			victim.SetProbability(100.0f);
			victim.SetRatio(0.0f);
			victim.SetValue(((100 * skill_level)));
			victim.SetHeal(true);
			victim.SetProbability(100.0f);
			victim.SetTime(6000.0f);
			victim.SetRatio(0.0f);
			victim.SetBuffid(1);
			victim.SetAmount(0.0f);
			victim.SetValue(999.0f);
			victim.SetHpgen(true);
			return true;
		}
	}
	public class GSkill1135 : GSkill
	{
		public GSkill1135()
			: base(1135)
		{
			
		}
	}
	public class GSkill1136Stub : GSkillStub
	{
		public GSkill1136Stub()
			: base(1136)
		{
			occupation = 129;
			maxlevel = 500;
			maxlearn = 10;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 13;
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
			SetAction(0,"");
			SetAction(1,"");
			SetAction(2,"");
			SetAction(3,"");
			SetAction(4,"");
			SetAction(5,"");
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
			SetAction(18,"");
			SetAction(19,"");
			SetAction(20,"");
			SetAction(21,"");
			SetAction(22,"");
			SetAction(23,"");
			SetAction(24,"");
			SetAction(25,"");
			SetAction(26,"");
			SetAction(27,"");
			SetAction(28,"");
			SetAction(29,"");
			SetAction(30,"");
			name = "¼¦³á¼õÑª";
			nativename = "¼¦³á¼õÑª";
			icon = "";
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

			victim.SetProbability(100.0f);
			victim.SetTime(6000.0f);
			victim.SetBuffid(1);
			victim.SetAmount(((200 * skill_level)));
			victim.SetValue(0.0f);
			victim.SetHpleak(true);
			return true;
		}
	}
	public class GSkill1136 : GSkill
	{
		public GSkill1136()
			: base(1136)
		{
			
		}
	}
	public class GSkill1137Stub : GSkillStub
	{
		public GSkill1137Stub()
			: base(1137)
		{
			occupation = 129;
			maxlevel = 500;
			maxlearn = 10;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 13;
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
			SetAction(0,"");
			SetAction(1,"");
			SetAction(2,"");
			SetAction(3,"");
			SetAction(4,"");
			SetAction(5,"");
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
			SetAction(18,"");
			SetAction(19,"");
			SetAction(20,"");
			SetAction(21,"");
			SetAction(22,"");
			SetAction(23,"");
			SetAction(24,"");
			SetAction(25,"");
			SetAction(26,"");
			SetAction(27,"");
			SetAction(28,"");
			SetAction(29,"");
			SetAction(30,"");
			name = "¼¦³á¼ÓÕæÆø";
			nativename = "¼¦³á¼ÓÕæÆø";
			icon = "";
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

			victim.SetTime(300000.0f);
			victim.SetBuffid(3);
			victim.SetValue(((50 * skill_level)));
			victim.SetAddmp(true);
			return true;
		}
	}
	public class GSkill1137 : GSkill
	{
		public GSkill1137()
			: base(1137)
		{
			
		}
	}
	public class GSkill1138Stub : GSkillStub
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
		public GSkill1138Stub()
			: base(1138)
		{
			occupation = 128;
			maxlevel = 500;
			maxlearn = 10;
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
			name = "ÈºÌå»Ø³Ç";
			nativename = "ÈºÌå»Ø³Ç";
			icon = "";
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
		public override float GetRadius(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (skill_level + 2);
		}
		public override float GetPraydistance(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (skill_level + 2);
		}
		public override float GetCastdistance(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return skill_level;
		}
		public override int GetCoverage(GSkill skill)
		{
			return 40;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetProbability(100.0f);
			victim.SetGohome(true);
			return true;
		}
	}
	public class GSkill1138 : GSkill
	{
		public GSkill1138()
			: base(1138)
		{
			
		}
	}
	public class GSkill1139Stub : GSkillStub
	{
		public GSkill1139Stub()
			: base(1139)
		{
			occupation = 25;
			maxlevel = 3;
			maxlearn = 2;
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
			name = "¶ñ¹íÑÀ";
			nativename = "¶ñ¹íÑÀ";
			icon = "¶ñ¹íÑÀ.dds";
			SetTalent(0,0);
			SetTalent(1,0);
			SetTalent(2,0);
			SetTalent(3,0);
			SetTalent(4,0);
			SetTalent(5,0);
			SetTalent(6,0);
			SetTalent(7,0);
			talent_size = 0;
			talent_type = 1;
			use_proficiency = false;
			inc_proficiency = 0;
			preskillnum = 0;
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
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={15,15};return array[level-1];
		}
	}
	public class GSkill1139 : GSkill
	{
		public GSkill1139()
			: base(1139)
		{
			
		}
	}
}
