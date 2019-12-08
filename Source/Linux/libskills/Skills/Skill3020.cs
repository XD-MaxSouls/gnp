using System;
using System.Text;

namespace SKILL
{
	public class GSkill3020Stub : GSkillStub
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
				return 900;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_res3 = player.GetRes3();
				int				skill_level = skill.GetLevel();
				int				skill_t1 = skill.GetT1();
				int				skill_t2 = skill.GetT2();

				player.SetVar1(player_res3);
				skill.SetRatio((skill_t2 * (norm(player.GetSkilllevel(3019) / 0.9f) * 0.05f + ((player.GetSkilllevel(786) / 1.9f) * 0.05f + ((player.GetSkilllevel(785) / 3.9f) * 0.05f + ((player.GetSkilllevel(543) / 9) * 0.05f + ((player.GetSkilllevel(242) / 9) * 0.05f + ((player.GetSkilllevel(234) / 9) * 0.05f + 0.05f)))))) + ((skill_level - 15) * (norm(skill_level / 14.9f) * 0.03f) + (skill_level * 0.05f + 1.0f))));
				skill.SetPlus((((zrand(15 * skill_t1 + 10) - 10) * norm(skill_t1 + 0.1f) + 100) / 100.0f * ((3 * skill_level * skill_level + (12 * skill_level) + 800))));
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
				return 900;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_res3 = player.GetRes3();
				int				skill_level = skill.GetLevel();
				int				skill_t1 = skill.GetT1();
				int				skill_t2 = skill.GetT2();

				player.SetVar1(player_res3);
				skill.SetRatio((skill_t2 * (norm(player.GetSkilllevel(3019) / 0.9f) * 0.05f + ((player.GetSkilllevel(786) / 1.9f) * 0.05f + ((player.GetSkilllevel(785) / 3.9f) * 0.05f + ((player.GetSkilllevel(543) / 9) * 0.05f + ((player.GetSkilllevel(242) / 9) * 0.05f + ((player.GetSkilllevel(234) / 9) * 0.05f + 0.05f)))))) + ((skill_level - 15) * (norm(skill_level / 14.9f) * 0.03f) + (skill_level * 0.05f + 1.0f))));
				skill.SetPlus((((zrand(15 * skill_t1 + 10) - 10) * norm(skill_t1 + 0.1f) + 100) / 100.0f * ((3 * skill_level * skill_level + (12 * skill_level) + 800))));
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
				return 900;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_res3 = player.GetRes3();
				int				skill_level = skill.GetLevel();
				int				skill_t1 = skill.GetT1();
				int				skill_t2 = skill.GetT2();

				player.SetVar1(player_res3);
				skill.SetRatio((skill_t2 * (norm(player.GetSkilllevel(3019) / 0.9f) * 0.05f + ((player.GetSkilllevel(786) / 1.9f) * 0.05f + ((player.GetSkilllevel(785) / 3.9f) * 0.05f + ((player.GetSkilllevel(543) / 9) * 0.05f + ((player.GetSkilllevel(242) / 9) * 0.05f + ((player.GetSkilllevel(234) / 9) * 0.05f + 0.05f)))))) + ((skill_level - 15) * (norm(skill_level / 14.9f) * 0.03f) + (skill_level * 0.05f + 1.0f))));
				skill.SetPlus((((zrand(15 * skill_t1 + 10) - 10) * norm(skill_t1 + 0.1f) + 100) / 100.0f * ((3 * skill_level * skill_level + (12 * skill_level) + 800))));
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
				return 900;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_res3 = player.GetRes3();
				int				skill_level = skill.GetLevel();
				int				skill_t1 = skill.GetT1();
				int				skill_t2 = skill.GetT2();

				player.SetVar1(player_res3);
				skill.SetRatio((skill_t2 * (norm(player.GetSkilllevel(3019) / 0.9f) * 0.05f + ((player.GetSkilllevel(786) / 1.9f) * 0.05f + ((player.GetSkilllevel(785) / 3.9f) * 0.05f + ((player.GetSkilllevel(543) / 9) * 0.05f + ((player.GetSkilllevel(242) / 9) * 0.05f + ((player.GetSkilllevel(234) / 9) * 0.05f + 0.05f)))))) + ((skill_level - 15) * (norm(skill_level / 14.9f) * 0.03f) + (skill_level * 0.05f + 1.0f))));
				skill.SetPlus((((zrand(15 * skill_t1 + 10) - 10) * norm(skill_t1 + 0.1f) + 100) / 100.0f * ((3 * skill_level * skill_level + (12 * skill_level) + 800))));
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
				return 900;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_res3 = player.GetRes3();
				int				skill_level = skill.GetLevel();
				int				skill_t1 = skill.GetT1();
				int				skill_t2 = skill.GetT2();

				player.SetVar1(player_res3);
				skill.SetRatio((skill_t2 * (norm(player.GetSkilllevel(3019) / 0.9f) * 0.05f + ((player.GetSkilllevel(786) / 1.9f) * 0.05f + ((player.GetSkilllevel(785) / 3.9f) * 0.05f + ((player.GetSkilllevel(543) / 9) * 0.05f + ((player.GetSkilllevel(242) / 9) * 0.05f + ((player.GetSkilllevel(234) / 9) * 0.05f + 0.05f)))))) + ((skill_level - 15) * (norm(skill_level / 14.9f) * 0.03f) + (skill_level * 0.05f + 1.0f))));
				skill.SetPlus((((zrand(15 * skill_t1 + 10) - 10) * norm(skill_t1 + 0.1f) + 100) / 100.0f * ((3 * skill_level * skill_level + (12 * skill_level) + 800))));
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
				return 900;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_res3 = player.GetRes3();
				int				skill_level = skill.GetLevel();
				int				skill_t1 = skill.GetT1();
				int				skill_t2 = skill.GetT2();

				player.SetVar1(player_res3);
				skill.SetRatio((skill_t2 * (norm(player.GetSkilllevel(3019) / 0.9f) * 0.05f + ((player.GetSkilllevel(786) / 1.9f) * 0.05f + ((player.GetSkilllevel(785) / 3.9f) * 0.05f + ((player.GetSkilllevel(543) / 9) * 0.05f + ((player.GetSkilllevel(242) / 9) * 0.05f + ((player.GetSkilllevel(234) / 9) * 0.05f + 0.05f)))))) + ((skill_level - 15) * (norm(skill_level / 14.9f) * 0.03f) + (skill_level * 0.05f + 1.0f))));
				skill.SetPlus((((zrand(15 * skill_t1 + 10) - 10) * norm(skill_t1 + 0.1f) + 100) / 100.0f * (((D2INT((zrand(5 * skill_level + 99)) / 100) + 1) * (3 * skill_level * skill_level + (12 * skill_level) + 800)))));
				player.SetPerform(0);
			}
		}
		public GSkill3020Stub()
			: base(3020)
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
			SetAction(0,"������_���������");
			SetAction(1,"������_���������");
			SetAction(2,"������_���������");
			SetAction(3,"������_���������");
			SetAction(4,"������_���������");
			SetAction(5,"������_���������");
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
			SetAction(18,"������_���_���������");
			SetAction(19,"������_���_���������");
			SetAction(20,"������_���_���������");
			SetAction(21,"������_���_���������");
			SetAction(22,"������_���_���������");
			SetAction(23,"������_���_���������");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "���������<��>";
			nativename = "���������<��>";
			icon = "�ɡ����������.dds";
			SetTalent(0,593);
			SetTalent(1,607);
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
			return 16000;
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
			return 26.000000f;
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
			return 25.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (30 * skill_level * skill_level + 2560);
		}
		public override int GetCoverage(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return skill_level + 10;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_var1 = player.GetVar1();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();

			/*
			if ( zrand(100) >= 2 * skill_level )
			d = 0.0f;
			else
			victim.SetProbability(((10 * skill_level + 550)));
			victim.SetTime(6100.0f);
			victim.SetSilent(true);
			victim.SetProbability(((skill_level + player_var1)));
			victim.SetTime(((500 * skill_t0 + 6100)));
			victim.SetWrap(true);
			*/
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();

			victim.SetRatio(((2800 * D2INT((zrand(2 * skill_level + 100)) / 100) + 220)));
			victim.SetAmount(220.0f);
			victim.SetValue(220.0f);
			victim.SetClearcooldown(true);
			victim.SetTime(6000.0f);
			victim.SetImmunesleep(true);
			victim.SetProbability(((4 * skill_level + 12)));
			victim.SetRatio(0.0f);
			victim.SetValue(((12 * skill_level + (skill_level * skill_level))));
			victim.SetScopedamage(true);
			return true;
		}
		public override float GetDropRate(GSkill skill)
		{
			return 0.500000f;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={786};return array[index];
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
	public class GSkill3020 : GSkill
	{
		public GSkill3020()
			: base(3020)
		{
			
		}
	}
	public class GSkill3021Stub : GSkillStub
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
				int				player_res4 = player.GetRes4();
				int				skill_level = skill.GetLevel();
				int				skill_t2 = skill.GetT2();
				int				skill_t3 = skill.GetT3();

				player.SetVar1(player_res4);
				skill.SetRatio((skill_t3 * 0.01f + ((skill_level - 15) * (norm(skill_level / 14.9f) * 0.03f) + (skill_level * 0.05f + 1.1f))));
				skill.SetPlus(((skill_t2 * 0.07000000000000001f + 1.0f) * ((skill_level * (skill_level * 9.9f)) - skill_level * 8.6f + 858.0f)));
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
				int				player_res4 = player.GetRes4();
				int				skill_level = skill.GetLevel();
				int				skill_t2 = skill.GetT2();
				int				skill_t3 = skill.GetT3();

				player.SetVar1(player_res4);
				skill.SetRatio((skill_t3 * 0.02f + ((skill_level - 15) * (norm(skill_level / 14.9f) * 0.03f) + (skill_level * 0.05f + 1.1f))));
				skill.SetPlus(((skill_t2 * 0.07000000000000001f + 1.0f) * ((skill_level * (skill_level * 9.9f)) - skill_level * 8.6f + 858.0f)));
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
				int				player_res4 = player.GetRes4();
				int				skill_level = skill.GetLevel();
				int				skill_t2 = skill.GetT2();
				int				skill_t3 = skill.GetT3();

				player.SetVar1(player_res4);
				skill.SetRatio((skill_t3 * 0.03f + ((skill_level - 15) * (norm(skill_level / 14.9f) * 0.03f) + (skill_level * 0.05f + 1.1f))));
				skill.SetPlus(((skill_t2 * 0.07000000000000001f + 1.0f) * ((skill_level * (skill_level * 9.9f)) - skill_level * 8.6f + 858.0f)));
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
				int				player_res4 = player.GetRes4();
				int				skill_level = skill.GetLevel();
				int				skill_t2 = skill.GetT2();
				int				skill_t3 = skill.GetT3();

				player.SetVar1(player_res4);
				skill.SetRatio((skill_t3 * 0.04f + ((skill_level - 15) * (norm(skill_level / 14.9f) * 0.03f) + (skill_level * 0.05f + (((zrand(4 * skill_level + 40)) * norm((zrand(skill_level + 100)) / 100.0f)) * 0.02f + 1.1f)))));
				skill.SetPlus(((skill_t2 * 0.07000000000000001f + 1.0f) * ((skill_level * (skill_level * 9.9f)) - skill_level * 8.6f + 858.0f)));
				player.SetPerform(0);
			}
		}
		public GSkill3021Stub()
			: base(3021)
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
			SetAction(0,"������_ħ������");
			SetAction(1,"������_ħ������");
			SetAction(2,"������_ħ������");
			SetAction(3,"������_ħ������");
			SetAction(4,"������_ħ������");
			SetAction(5,"������_ħ������");
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
			SetAction(18,"������_���_ħ������");
			SetAction(19,"������_���_ħ������");
			SetAction(20,"������_���_ħ������");
			SetAction(21,"������_���_ħ������");
			SetAction(22,"������_���_ħ������");
			SetAction(23,"������_���_ħ������");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "ħ������<��>";
			nativename = "ħ������<��>";
			icon = "�ɡ�ħ������.dds";
			SetTalent(0,640);
			SetTalent(1,644);
			SetTalent(2,661);
			SetTalent(3,663);
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
		}
		public override int GetExecutetime(GSkill skill)
		{
			return 2000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			int				skill_t2 = skill.GetT2();
			int				skill_t3 = skill.GetT3();

			return (-1350 * skill_t3) - 1350 * skill_t2 + 9000;
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
			return 6.000000f;
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
			int				skill_level = skill.GetLevel();

			return (10 * skill_level + 850);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_var1 = player.GetVar1();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();
			int				skill_t1 = skill.GetT1();

			victim.SetProbability(((6 * skill_t0 + 30)));
			victim.SetTime(((3000 * skill_t0 + 11100)));
			victim.SetRatio(((D2INT(zrand(100) / (100 - 6 * skill_t1)) + 1) * (skill_t1 * 0.03f + 0.11f)));
			victim.SetBuffid(3);
			victim.SetTiansha(true);
			victim.SetProbability(-1.0f);
			victim.SetTime(2000.0f);
			victim.SetBuffid(1);
			victim.SetAmount(((40 * skill_level + 160)));
			victim.SetValue(0.0f);
			victim.SetHpleak(true);
			victim.SetProbability(((2 * skill_level + player_var1)));
			victim.SetTime(3100.0f);
			victim.SetSilent(true);
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={775};return array[index];
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
	public class GSkill3021 : GSkill
	{
		public GSkill3021()
			: base(3021)
		{
			
		}
	}
	public class GSkill3022Stub : GSkillStub
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

				player.SetVar1((int)((1000 * player_hp) / player_maxhp));
				player.SetPerform(1);
			}
		}
		public GSkill3022Stub()
			: base(3022)
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
			SetAction(0,"������_���鷴��");
			SetAction(1,"������_���鷴��");
			SetAction(2,"������_���鷴��");
			SetAction(3,"������_���鷴��");
			SetAction(4,"������_���鷴��");
			SetAction(5,"������_���鷴��");
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
			SetAction(18,"������_���_���鷴��");
			SetAction(19,"������_���_���鷴��");
			SetAction(20,"������_���_���鷴��");
			SetAction(21,"������_���_���鷴��");
			SetAction(22,"������_���_���鷴��");
			SetAction(23,"������_���_���鷴��");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "���鷴��<��>";
			nativename = "���鷴��<��>";
			icon = "�ɡ����鷴��.dds";
			SetTalent(0,647);
			SetTalent(1,662);
			SetTalent(2,666);
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

			return (20 * skill_level + 660);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_maxmp = player.GetMaxmp();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();
			int				skill_t2 = skill.GetT2();

			/*
			victim.SetProbability(100.0f);
			victim.SetTime(((2000 * skill_t0 + 20100)));
			victim.SetRatio((norm(skill_level / 19.9f) * 0.3f + (skill_level * 0.04f)));
			victim.SetAmount(0.0f);
			victim.SetValue(((5 * skill_level)));
			victim.SetRetort(true);
			victim.SetTime(((3000 * skill_t2 + 10100)));
			victim.SetImmunesleep(true);
			if ( skill_t0 <= 0 )
			v33 = 0.0f;
			else
			victim.SetProbability(120.0f);
			victim.SetTime(((60000 * skill_t0)));
			victim.SetBuffid(1);
			victim.SetAmount((skill_t0 * 0.1f + 0.00001f));
			victim.SetValue((player_maxmp * (skill_t0 * 0.06f)));
			victim.SetAddhp2(true);
			victim.SetTime((((3000 * skill_t2 + 10100) * norm(skill_t2))));
			victim.SetImmunedizzy(true);
			*/
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_maxhp = player.GetMaxhp();
			int				player_var1 = player.GetVar1();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();

			/*
			victim.SetTime(((1000 * skill_level + 1050)));
			victim.SetImmuneweak(true);
			if ( player_var1 <= 950 )
			{
			d = 0.0f;
			}
			else
			{
			d = (120 * norm(skill_t0 / 3.9f));
			}
			victim.SetProbability(d);
			victim.SetRatio(0.0f);
			victim.SetValue(player_maxhp);
			victim.SetHeal(true);
			*/
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={776};return array[index];
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
	public class GSkill3022 : GSkill
	{
		public GSkill3022()
			: base(3022)
		{
			
		}
	}
	public class GSkill3023Stub : GSkillStub
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
				return 1200;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				skill_level = skill.GetLevel();
				int				skill_t0 = skill.GetT0();
				int				skill_t1 = skill.GetT1();
				int				skill_t3 = skill.GetT3();

				skill.SetCrit((skill_t0 * 0.02f));
				skill.SetRatio((skill_t1 * 0.07000000000000001f + 1.0f));
				skill.SetCrithurt((skill_t3 * 0.5f));
				skill.SetPlus(((skill_t3 * 0.3f + 1.0f) * ((100 * skill_level))));
				player.SetPerform(1);
			}
		}
		public GSkill3023Stub()
			: base(3023)
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
			SetAction(0,"������_�������");
			SetAction(1,"������_�������");
			SetAction(2,"������_�������");
			SetAction(3,"������_�������");
			SetAction(4,"������_�������");
			SetAction(5,"������_�������");
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
			SetAction(18,"������_���_�������");
			SetAction(19,"������_���_�������");
			SetAction(20,"������_���_�������");
			SetAction(21,"������_���_�������");
			SetAction(22,"������_���_�������");
			SetAction(23,"������_���_�������");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "�������<��>";
			nativename = "�������<��>";
			icon = "�ɡ��������.dds";
			SetTalent(0,628);
			SetTalent(1,633);
			SetTalent(2,645);
			SetTalent(3,668);
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
			return 2000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			int				skill_t1 = skill.GetT1();

			return 20000 - 2000 * skill_t1;
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
			return 13.000000f;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 13.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 11.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (15 * skill_level + 950);
		}
		public override int GetCoverage(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return 2 * D2INT(skill_level / 4.9f) + 6;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();
			int				skill_t2 = skill.GetT2();

			victim.SetProbability(((15 * skill_t0 + 33)));
			victim.SetTime(20100.0f);
			victim.SetAssault(true);
			victim.SetProbability(-1.0f);
			victim.SetTime(2000.0f);
			victim.SetBuffid(1);
			victim.SetAmount(((D2INT(zrand(100) / (100 - 6 * skill_t2)) + 1) * ((skill_t2 * 0.8f + 1.0f) * ((120 * skill_level)))));
			victim.SetValue(0.0f);
			victim.SetHpleak5(true);
			victim.SetProbability(((3 * skill_level + 10)));
			victim.SetPullback(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_maxhp = player.GetMaxhp();
			int				skill_level = skill.GetLevel();

			victim.SetProbability(120.0f);
			victim.SetTime(8100.0f);
			victim.SetRatio(1.0f);
			victim.SetAmount(((skill_level + 10)));
			victim.SetValue((skill_level * (player_maxhp * 0.01f)));
			victim.SetHpregain(true);
			return true;
		}
		public override float GetDropRate(GSkill skill)
		{
			return 0.500000f;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={777};return array[index];
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
	public class GSkill3023 : GSkill
	{
		public GSkill3023()
			: base(3023)
		{
			
		}
	}
	public class GSkill3024Stub : GSkillStub
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
				skill.SetRatio(((skill_level - 15) * (norm(skill_level / 14.9f) * 0.03f) + (skill_level * 0.05f + 1.27f)));
				skill.SetPlus(((skill_t3 * 0.07000000000000001f + 1.0f) * ((5 * skill_level * skill_level + 720))));
				player.SetPerform(0);
			}
		}
		public GSkill3024Stub()
			: base(3024)
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
			dobless = true;
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
			SetAction(0,"������_δ��ն");
			SetAction(1,"������_δ��ն");
			SetAction(2,"������_δ��ն");
			SetAction(3,"������_δ��ն");
			SetAction(4,"������_δ��ն");
			SetAction(5,"������_δ��ն");
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
			SetAction(18,"������_���_δ��ն");
			SetAction(19,"������_���_δ��ն");
			SetAction(20,"������_���_δ��ն");
			SetAction(21,"������_���_δ��ն");
			SetAction(22,"������_���_δ��ն");
			SetAction(23,"������_���_δ��ն");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "δ��ն<��>";
			nativename = "δ��ն<��>";
			icon = "�ɡ�δ��ն.dds";
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
			int				player_res2 = player.GetRes2();
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
			victim.SetProbability(((2 * skill_level + 20)));
			victim.SetTime(((500 * skill_level + 2050)));
			victim.SetBuffid(1);
			victim.SetValue((player_res2 * (skill_level * 0.005f)));
			victim.SetSubanti(true);
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
	public class GSkill3024 : GSkill
	{
		public GSkill3024()
			: base(3024)
		{
			
		}
	}
	public class GSkill3025Stub : GSkillStub
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
				int				player_res3 = player.GetRes3();
				int				skill_level = skill.GetLevel();
				int				skill_t2 = skill.GetT2();
				int				skill_t3 = skill.GetT3();

				player.SetVar1(player_res3);
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
				int				player_res3 = player.GetRes3();
				int				skill_level = skill.GetLevel();
				int				skill_t2 = skill.GetT2();
				int				skill_t3 = skill.GetT3();

				player.SetVar1(player_res3);
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
				int				player_res3 = player.GetRes3();
				int				skill_level = skill.GetLevel();
				int				skill_t2 = skill.GetT2();
				int				skill_t3 = skill.GetT3();

				player.SetVar1(player_res3);
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
				int				player_res3 = player.GetRes3();
				int				skill_level = skill.GetLevel();
				int				skill_t2 = skill.GetT2();
				int				skill_t3 = skill.GetT3();

				player.SetVar1(player_res3);
				skill.SetRatio((skill_t2 * 0.07000000000000001f + ((skill_level - 15) * (norm(skill_level / 14.9f) * 0.03f) + (skill_level * 0.05f + 1.0f))));
				skill.SetPlus((((skill_level * skill_level + (22 * skill_level) + 835) * (D2INT((zrand(7 * skill_t3 + 99)) / 100) + 1))));
				player.SetPerform(0);
			}
		}
		public GSkill3025Stub()
			: base(3025)
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
			dobless = true;
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
			SetAction(0,"������_��������");
			SetAction(1,"������_��������");
			SetAction(2,"������_��������");
			SetAction(3,"������_��������");
			SetAction(4,"������_��������");
			SetAction(5,"������_��������");
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
			SetAction(18,"������_���_��������");
			SetAction(19,"������_���_��������");
			SetAction(20,"������_���_��������");
			SetAction(21,"������_���_��������");
			SetAction(22,"������_���_��������");
			SetAction(23,"������_���_��������");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "��������<��>";
			nativename = "��������<��>";
			icon = "�ɡ���������.dds";
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

			return (skill_level * 0.6f + 16.0f);
		}
		public override float GetCastdistance(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (skill_level * 0.6f + 10.7f);
		}
		public override float GetEffectdistance(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (skill_level * 0.6f + 19.0f);
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
			int				player_var1 = player.GetVar1();
			int				skill_level = skill.GetLevel();
			int				skill_t1 = skill.GetT1();

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
			victim.SetProbability(((40 * norm(skill_level / 19.9f)) + ((skill_level * 0.005f + 0.6f) * player_var1)));
			victim.SetTime(6100.0f);
			victim.SetWrap(true);
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
	public class GSkill3025 : GSkill
	{
		public GSkill3025()
			: base(3025)
		{
			
		}
	}
	public class GSkill3026Stub : GSkillStub
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
		public GSkill3026Stub()
			: base(3026)
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
			SetAction(0,"������_��������");
			SetAction(1,"������_��������");
			SetAction(2,"������_��������");
			SetAction(3,"������_��������");
			SetAction(4,"������_��������");
			SetAction(5,"������_��������");
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
			SetAction(18,"������_���_��������");
			SetAction(19,"������_���_��������");
			SetAction(20,"������_���_��������");
			SetAction(21,"������_���_��������");
			SetAction(22,"������_���_��������");
			SetAction(23,"������_���_��������");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "��������<��>";
			nativename = "��������<��>";
			icon = "�ɡ���������.dds";
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
			v24 = 120.0f;
			else
			victim.SetProbability(0.0f);
			victim.SetTime(((14800 - 2250 * skill_t0)));
			victim.SetRatio(788.0f);
			victim.SetAmount(220.0f);
			victim.SetValue(220.0f);
			victim.SetSetcooldown(true);
			victim.SetProbability(120.0f);
			victim.SetTime(((500 * skill_level + 2050)));
			victim.SetRatio((skill_level * 0.01f));
			victim.SetAttack2mp(true);
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
	public class GSkill3026 : GSkill
	{
		public GSkill3026()
			: base(3026)
		{
			
		}
	}
	public class GSkill3027Stub : GSkillStub
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
		public GSkill3027Stub()
			: base(3027)
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
			SetAction(0,"������_�󷲰���");
			SetAction(1,"������_�󷲰���");
			SetAction(2,"������_�󷲰���");
			SetAction(3,"������_�󷲰���");
			SetAction(4,"������_�󷲰���");
			SetAction(5,"������_�󷲰���");
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
			SetAction(18,"������_���_�󷲰���");
			SetAction(19,"������_���_�󷲰���");
			SetAction(20,"������_���_�󷲰���");
			SetAction(21,"������_���_�󷲰���");
			SetAction(22,"������_���_�󷲰���");
			SetAction(23,"������_���_�󷲰���");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "�������<��>";
			nativename = "�������<��>";
			icon = "�ɡ��������.dds";
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
			victim.SetRatio((skill_t0 * 0.02f + (skill_level * 0.02f) - 0.002f));
			victim.SetBuffid(1);
			victim.SetAmount(0.0f);
			victim.SetValue(((skill_t2 * 0.1f + 1.0f) * ((skill_t1 * 0.2f + 1.0f) * (player_maxhp * (skill_level * 0.03f) * 10.0f))));
			victim.SetBanruo(true);
			victim.SetTime(((2000 * skill_t2 + 2100)));
			victim.SetInvincible(true);
			victim.SetTime(((2000 * skill_t2 + 20100)));
			victim.SetRatio((skill_level * 0.01f + 0.003f));
			victim.SetInccritrate(true);
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
	public class GSkill3027 : GSkill
	{
		public GSkill3027()
			: base(3027)
		{
			
		}
	}
	public class GSkill3028Stub : GSkillStub
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
				int				skill_level = skill.GetLevel();

				/*
				player.SetVar2((int)(player_mp - skill_level * (player_maxmp * 0.025f) > 0.0f));
				player.SetVar1(player_maxmp);
				if ( player_mp - skill_level * (player_maxmp * 0.03f) <= 0.0f )
				  {
				v23 = player_mp;
				  }
				  else
				  {
				v23 = player_mp - skill_level * (player_maxmp * 0.03f);
				  }
				player.SetMp(v23);
				player.SetPerform(1);
				*/
			}
		}
		public GSkill3028Stub()
			: base(3028)
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
			weapon_limit = -1;
			SetAction(0,"������_��������");
			SetAction(1,"������_��������");
			SetAction(2,"������_��������");
			SetAction(3,"������_��������");
			SetAction(4,"������_��������");
			SetAction(5,"������_��������");
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
			SetAction(18,"������_���_��������");
			SetAction(19,"������_���_��������");
			SetAction(20,"������_���_��������");
			SetAction(21,"������_���_��������");
			SetAction(22,"������_���_��������");
			SetAction(23,"������_���_��������");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "��������<��>";
			nativename = "��������<��>";
			icon = "�ɡ���������.dds";
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
			int				skill_level = skill.GetLevel();

			victim.SetProbability(((100 * player_var2)));
			victim.SetRatio(1.0f);
			victim.SetValue((player_maxhp * (norm(skill_level / 19.9f) * 0.2f + (skill_level * 0.03f + 0.2f))));
			victim.SetHeal(true);
			victim.SetProbability(((120 * player_var2)));
			victim.SetTime(50.0f);
			victim.SetRatio(skill_level);
			victim.SetBuffid(1);
			victim.SetValue(5230.0f);
			victim.SetDelaycast(true);
			victim.SetProbability(((120 * player_var2)));
			victim.SetTime(300000.0f);
			victim.SetAmount((skill_level * (player_var1 * 0.05f)));
			victim.SetBloodpool(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_var2 = player.GetVar2();
			int				skill_level = skill.GetLevel();
			int				skill_t2 = skill.GetT2();

			victim.SetProbability(((100 * player_var2)));
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
	public class GSkill3028 : GSkill
	{
		public GSkill3028()
			: base(3028)
		{
			
		}
	}
	public class GSkill3029Stub : GSkillStub
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
				return 800;
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
		public GSkill3029Stub()
			: base(3029)
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
			dobless = true;
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
			SetAction(0,"�ϻ���_����");
			SetAction(1,"�ϻ���_����");
			SetAction(2,"�ϻ���_����");
			SetAction(3,"�ϻ���_����");
			SetAction(4,"�ϻ���_����");
			SetAction(5,"�ϻ���_����");
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
			SetAction(18,"�ϻ���_���_����");
			SetAction(19,"�ϻ���_���_����");
			SetAction(20,"�ϻ���_���_����");
			SetAction(21,"�ϻ���_���_����");
			SetAction(22,"�ϻ���_���_����");
			SetAction(23,"�ϻ���_���_����");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "����<��>";
			nativename = "����<��>";
			icon = "�ɡ�����.dds";
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
			victim.SetAmount(2.0f);
			victim.SetClearbuff(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_maxhp = player.GetMaxhp();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();

			victim.SetProbability(((8 * skill_t0)));
			victim.SetRatio(0.0f);
			victim.SetValue((player_maxhp * (skill_t0 * 0.02f)));
			victim.SetHeal(true);
			victim.SetRatio(((174 * D2INT((zrand(3 * skill_level + 99)) / 100) + 220)));
			victim.SetAmount(220.0f);
			victim.SetValue(220.0f);
			victim.SetClearcooldown(true);
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
	public class GSkill3029 : GSkill
	{
		public GSkill3029()
			: base(3029)
		{
			
		}
	}
}
