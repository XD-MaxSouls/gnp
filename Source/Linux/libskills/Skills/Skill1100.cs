using System;
using System.Text;

namespace SKILL
{
	public class GSkill1100Stub : GSkillStub
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

				skill.SetRatio((skill_t1 * 0.05f + 1.0f));
				skill.SetCrit((skill_t3 * 0.01f));
				skill.SetCrithurt((skill_t3 * 0.1f));
				skill.SetPlus(((skill_level * (skill_level * 0.66f) + (45.0f - skill_level * 1.2f)) * (D2INT(skill_level * 0.05f + 0.55f)) + (((D2INT(1.42f - skill_level * 0.05f)) * (3 * skill_level + 45)))));
				player.SetPerform(1);
			}
		}
		public GSkill1100Stub()
			: base(1100)
		{
			occupation = 25;
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
			SetAction(0,"���_���ض�â");
			SetAction(1,"���_���ض�â");
			SetAction(2,"���_���ض�â");
			SetAction(3,"���_���ض�â");
			SetAction(4,"���_���ض�â");
			SetAction(5,"���_���ض�â");
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
			SetAction(18,"���_���_���ض�â");
			SetAction(19,"���_���_���ض�â");
			SetAction(20,"���_���_���ض�â");
			SetAction(21,"���_���_���ض�â");
			SetAction(22,"���_���_���ض�â");
			SetAction(23,"���_���_���ض�â");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "���ض�â";
			nativename = "���ض�â";
			icon = "���ض�â.dds";
			SetTalent(0,1142);
			SetTalent(1,1143);
			SetTalent(2,1151);
			SetTalent(3,1155);
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
			int				skill_t2 = skill.GetT2();

			return 6000 - 900 * skill_t2;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={30,32,34,36,38,40,42,44,47};return array[level-1];
		}
		public override float GetRadius(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (skill_level * 0.3f + 5.7f);
		}
		public override float GetPraydistance(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (skill_level * 0.3f + 5.7f);
		}
		public override float GetCastdistance(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (skill_level * 0.3f + 3.0f);
		}
		public override float GetMpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (8 * skill_level + 50);
		}
		public override int GetCoverage(GSkill skill)
		{
			return 12;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_level = player.GetLevel();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();
			int				skill_t1 = skill.GetT1();

			victim.SetProbability(((1.0f - player_level * 0.002f) * 100.0f));
			victim.SetTime(8000.0f);
			victim.SetBuffid(1);
			victim.SetAmount(((skill_t0 * 0.2f + 1.0f) * ((24 * skill_level + 96))));
			victim.SetValue(0.0f);
			victim.SetHpleak(true);
			victim.SetProbability(((600 * norm(zrand(100) / (100 - 3 * skill_t1)))));
			victim.SetTime(((3030 * skill_t1)));
			victim.SetRatio(0.15000001f);
			victim.SetBuffid(5);
			victim.SetWeak(true);
			return true;
		}
		public override float GetDropRate(GSkill skill)
		{
			return 0.240000f;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={1096};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={5};return array[index];
		}
	}
	public class GSkill1100 : GSkill
	{
		public GSkill1100()
			: base(1100)
		{
			
		}
	}
	public class GSkill1101Stub : GSkillStub
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
				skill.SetPlus((((skill_level * (skill_level * 2.3f)) - (12 * skill_level) + 210.0f) * (D2INT(skill_level * 0.05f + 0.55f)) + (((D2INT(1.42f - skill_level * 0.05f)) * (skill_level * skill_level + (7 * skill_level) + 150)))));
				player.SetPerform(1);
			}
		}
		public GSkill1101Stub()
			: base(1101)
		{
			occupation = 25;
			maxlevel = 20;
			maxlearn = 10;
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
			SetAction(0,"�ɻ�Ѫ��");
			SetAction(1,"�ɻ�Ѫ��");
			SetAction(2,"�ɻ�Ѫ��");
			SetAction(3,"�ɻ�Ѫ��");
			SetAction(4,"�ɻ�Ѫ��");
			SetAction(5,"�ɻ�Ѫ��");
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
			SetAction(18,"�ɻ�Ѫ��");
			SetAction(19,"�ɻ�Ѫ��");
			SetAction(20,"�ɻ�Ѫ��");
			SetAction(21,"�ɻ�Ѫ��");
			SetAction(22,"�ɻ�Ѫ��");
			SetAction(23,"�ɻ�Ѫ��");
			SetAction(24,"");
			SetAction(25,"");
			SetAction(26,"");
			SetAction(27,"");
			SetAction(28,"");
			SetAction(29,"");
			SetAction(30,"");
			name = "�ɻ�Ѫ��";
			nativename = "�ɻ�Ѫ��";
			icon = "�ɻ�Ѫ��.dds";
			SetTalent(0,1160);
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
		}
		public override int GetExecutetime(GSkill skill)
		{
			return 1000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			return 5000;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={35,37,39,41,43,45,47,49,52,56};return array[level-1];
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

			return (3 * skill_level + 15);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_hp = player.GetHp();
			int				player_maxhp = player.GetMaxhp();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();

			victim.SetProbability(((100 * norm((player_maxhp * (skill_t0 * 0.05f + ((skill_level - 1) * 0.05f + 0.15f))) / (player_hp + 1)))));
			victim.SetTime(100.0f);
			victim.SetBuffid(5);
			victim.SetAmount(((skill_t0 * 0.2f + 1.0f) * (((skill_level * (skill_level * 2.3f)) - (12 * skill_level) + 210.0f) * (D2INT(skill_level * 0.05f + 0.55f)) + (((D2INT(1.42f - skill_level * 0.05f)) * (skill_level * skill_level + (7 * skill_level) + 150))))));
			victim.SetValue(0.0f);
			victim.SetHpleak(true);
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={1099};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={5};return array[index];
		}
	}
	public class GSkill1101 : GSkill
	{
		public GSkill1101()
			: base(1101)
		{
			
		}
	}
	public class GSkill1102Stub : GSkillStub
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
		public GSkill1102Stub()
			: base(1102)
		{
			occupation = 25;
			maxlevel = 20;
			maxlearn = 9;
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
			allowform = 7;
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
			SetAction(0,"���_��������");
			SetAction(1,"���_��������");
			SetAction(2,"���_��������");
			SetAction(3,"���_��������");
			SetAction(4,"���_��������");
			SetAction(5,"���_��������");
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
			SetAction(18,"���_���_��������");
			SetAction(19,"���_���_��������");
			SetAction(20,"���_���_��������");
			SetAction(21,"���_���_��������");
			SetAction(22,"���_���_��������");
			SetAction(23,"���_���_��������");
			SetAction(24,"");
			SetAction(25,"");
			SetAction(26,"");
			SetAction(27,"");
			SetAction(28,"");
			SetAction(29,"");
			SetAction(30,"");
			name = "��������";
			nativename = "��������";
			icon = "��������.dds";
			SetTalent(0,1176);
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

			return 90000 - 4500 * skill_t0;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={40,43,47,52,58,65,73,82,92};return array[level-1];
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
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_mp = player.GetMp();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();

			victim.SetTime(((2000 * (skill_t0 + skill_level) + 6100)));
			victim.SetImmunesleep(true);
			victim.SetTime(((2000 * (skill_t0 + skill_level) + 6100)));
			victim.SetImmunedizzy(true);
			victim.SetProbability(100.0f);
			victim.SetTime(24000.0f);
			victim.SetRatio(0.0f);
			victim.SetBuffid(1);
			victim.SetAmount(0.0f);
			victim.SetValue((player_mp * (skill_level * 0.02f)));
			victim.SetHpgen(true);
			victim.SetProbability(((30 * skill_t0)));
			victim.SetClearslow(true);
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={1098};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={3};return array[index];
		}
	}
	public class GSkill1102 : GSkill
	{
		public GSkill1102()
			: base(1102)
		{
			
		}
	}
	public class GSkill1103Stub : GSkillStub
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
				int				skill_t3 = skill.GetT3();

				skill.SetRatio(1.0f);
				skill.SetCrit((skill_t3 * 0.01f));
				skill.SetCrithurt((skill_t3 * 0.1f));
				skill.SetPlus((((13 * skill_level) + (skill_level * (skill_level * 0.7f)) + 27.0f) * (D2INT(skill_level * 0.05f + 0.55f)) + (((D2INT(1.42f - skill_level * 0.05f)) * (7 * skill_level + 110) + (5 * skill_level * skill_t0)))));
				player.SetPerform(1);
			}
		}
		public GSkill1103Stub()
			: base(1103)
		{
			occupation = 26;
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
			allowform = 1;
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
			SetAction(0,"���_��������");
			SetAction(1,"���_��������");
			SetAction(2,"���_��������");
			SetAction(3,"���_��������");
			SetAction(4,"���_��������");
			SetAction(5,"���_��������");
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
			SetAction(18,"���_���_��������");
			SetAction(19,"���_���_��������");
			SetAction(20,"���_���_��������");
			SetAction(21,"���_���_��������");
			SetAction(22,"���_���_��������");
			SetAction(23,"���_���_��������");
			SetAction(24,"");
			SetAction(25,"");
			SetAction(26,"");
			SetAction(27,"");
			SetAction(28,"");
			SetAction(29,"");
			SetAction(30,"");
			name = "��������";
			nativename = "��������";
			icon = "��������.dds";
			SetTalent(0,1144);
			SetTalent(1,1145);
			SetTalent(2,1151);
			SetTalent(3,1155);
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
			int				skill_t2 = skill.GetT2();

			return 6000 - 900 * skill_t2;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={45,47,49,51,53,55,57,59,62};return array[level-1];
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

			return (skill_level * 0.2f + 3.0f);
		}
		public override float GetMpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (7 * skill_level + 64);
		}
		public override int GetCoverage(GSkill skill)
		{
			return 15;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();
			int				skill_t1 = skill.GetT1();

			victim.SetProbability(((5 * skill_t1 + 33)));
			victim.SetTime(12100.0f);
			victim.SetBuffid(1);
			victim.SetValue(((skill_t1 * 0.5f + 1.0f) * ((8 * skill_level + 4))));
			victim.SetSubattack(true);
			return true;
		}
		public override float GetDropRate(GSkill skill)
		{
			return 0.300000f;
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={24};return array[index];
		}
	}
	public class GSkill1103 : GSkill
	{
		public GSkill1103()
			: base(1103)
		{
			
		}
	}
	public class GSkill1104Stub : GSkillStub
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
		public GSkill1104Stub()
			: base(1104)
		{
			occupation = 26;
			maxlevel = 4;
			maxlearn = 3;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 4;
			timetype = 1;
			targettype = 0;
			rangetype = 5;
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
			name = "������";
			nativename = "������";
			icon = "������.dds";
			SetTalent(0,1177);
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
		public override int GetExecutetime(GSkill skill)
		{
			return 1;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();

			return (-5000 * skill_level) - 2000 * skill_t0 + 30000;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={46,50,76};return array[level-1];
		}
		public override float GetPraydistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return player_range;
		}
		public override float GetCastdistance(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (skill_level * 2.5f + 5.0f);
		}
		public override float GetMpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (240 - 40 * skill_level);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_t0 = skill.GetT0();

			victim.SetTime(5000.0f);
			victim.SetValue(15.0f);
			victim.SetDodge(true);
			victim.SetRatio(((39 * norm(zrand(100) / (95 - 15 * skill_t0)) + 1093)));
			victim.SetAmount(((12 * norm(zrand(100) / (95 - 15 * skill_t0)) + 1093)));
			victim.SetValue(((16 * norm(zrand(100) / (95 - 15 * skill_t0)) + 1093)));
			victim.SetClearcooldown(true);
			victim.SetRatio(((21 * norm(zrand(100) / (95 - 15 * skill_t0)) + 1093)));
			victim.SetAmount(((norm(zrand(100) / (95 - 15 * skill_t0)) + 1093)));
			victim.SetValue(((25 * norm(zrand(100) / (95 - 15 * skill_t0)) + 1093)));
			victim.SetClearcooldown(true);
			victim.SetRatio(((28 * norm(zrand(100) / (95 - 15 * skill_t0)) + 1093)));
			victim.SetAmount(((30 * norm(zrand(100) / (95 - 15 * skill_t0)) + 1093)));
			victim.SetValue(((31 * norm(zrand(100) / (95 - 15 * skill_t0)) + 1093)));
			victim.SetClearcooldown(true);
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={1103};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={1};return array[index];
		}
	}
	public class GSkill1104 : GSkill
	{
		public GSkill1104()
			: base(1104)
		{
			
		}
	}
	public class GSkill1105Stub : GSkillStub
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
		public GSkill1105Stub()
			: base(1105)
		{
			occupation = 26;
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
			allowform = 2;
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
			SetAction(0,"��Ȫ��");
			SetAction(1,"��Ȫ��");
			SetAction(2,"��Ȫ��");
			SetAction(3,"��Ȫ��");
			SetAction(4,"��Ȫ��");
			SetAction(5,"��Ȫ��");
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
			SetAction(18,"��Ȫ��");
			SetAction(19,"��Ȫ��");
			SetAction(20,"��Ȫ��");
			SetAction(21,"��Ȫ��");
			SetAction(22,"��Ȫ��");
			SetAction(23,"��Ȫ��");
			SetAction(24,"");
			SetAction(25,"");
			SetAction(26,"");
			SetAction(27,"");
			SetAction(28,"");
			SetAction(29,"");
			SetAction(30,"");
			name = "��Ȫ��";
			nativename = "��Ȫ��";
			icon = "��Ȫ��.dds";
			SetTalent(0,1162);
			SetTalent(1,1168);
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
			int				skill_t1 = skill.GetT1();

			return 180000 - 18000 * skill_t1;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={46,49,52,55,58,61,64,68};return array[level-1];
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
			int				skill_t2 = skill.GetT2();

			victim.SetTime((((2000 * skill_t2 + (3000 * skill_level) + 12100) * (norm(zrand(100) / (100 - 10 * skill_t2)) + 1))));
			victim.SetRatio((skill_t0 * 0.15f + (skill_level * 0.15f + 0.25f)));
			victim.SetAmount(2.0f);
			victim.SetValue(((5 * skill_level + 10)));
			victim.SetFocusanti(true);
			victim.SetProbability(((100 * skill_t0)));
			victim.SetClearwrap(true);
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={1103};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={1};return array[index];
		}
	}
	public class GSkill1105 : GSkill
	{
		public GSkill1105()
			: base(1105)
		{
			
		}
	}
	public class GSkill1106Stub : GSkillStub
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
		public GSkill1106Stub()
			: base(1106)
		{
			occupation = 26;
			maxlevel = 12;
			maxlearn = 8;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 2;
			timetype = 1;
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
			SetAction(0,"����");
			SetAction(1,"����");
			SetAction(2,"����");
			SetAction(3,"����");
			SetAction(4,"����");
			SetAction(5,"����");
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
			SetAction(18,"����");
			SetAction(19,"����");
			SetAction(20,"����");
			SetAction(21,"����");
			SetAction(22,"����");
			SetAction(23,"����");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "������̬";
			nativename = "������̬";
			icon = "������̬.dds";
			SetTalent(0,1140);
			SetTalent(1,1181);
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
		}
		public override int GetExecutetime(GSkill skill)
		{
			return 10;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			int				skill_t0 = skill.GetT0();

			return 12500 - 3000 * skill_t0;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={55,70,85,100,115,125,125,125};return array[level-1];
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

			victim.SetProbability(0.0f);
			victim.SetRatio(((-25 * skill_level)));
			victim.SetBuffid(((24 * skill_t1 * (skill_level * skill_level) + (40 * skill_t1 * skill_level)) + 120 * skill_level * skill_level + (200 * skill_level)));
			victim.SetAmount(((5 * skill_level + 25)));
			victim.SetValue(((35 * skill_level)));
			victim.SetInsanityform(true);
			victim.SetProbability(120.0f);
			victim.SetTime(((4000 * norm(skill_t1))));
			victim.SetRatio((skill_t1 * 0.25f));
			victim.SetAmount(0.0f);
			victim.SetValue(100.0f);
			victim.SetRetort(true);
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={1104};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={1};return array[index];
		}
	}
	public class GSkill1106 : GSkill
	{
		public GSkill1106()
			: base(1106)
		{
			
		}
	}
	public class GSkill1107Stub : GSkillStub
	{
		public GSkill1107Stub()
			: base(1107)
		{
			occupation = 26;
			maxlevel = 10;
			maxlearn = 6;
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
			name = "�������";
			nativename = "�������";
			icon = "�������.dds";
			SetTalent(0,1146);
			SetTalent(1,1147);
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
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={50,53,56,59,62,65};return array[level-1];
		}
		public override bool TakeEffect(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();
			int				skill_t1 = skill.GetT1();

			player.SetPasaddhp(((20 * skill_level)));
			player.SetPasaddattack(((3 * skill_t0 * skill_level + (8 * skill_level))));
			player.SetPasadddefence(((5 * skill_t1 * skill_level)));
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={1103};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={3};return array[index];
		}
	}
	public class GSkill1107 : GSkill
	{
		public GSkill1107()
			: base(1107)
		{
			
		}
	}
	public class GSkill1108Stub : GSkillStub
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

				skill.SetRatio((skill_level * 0.02f + 0.48f));
				player.SetPerform(1);
			}
		}
		public GSkill1108Stub()
			: base(1108)
		{
			occupation = 26;
			maxlevel = 20;
			maxlearn = 12;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 1;
			timetype = 0;
			targettype = 0;
			rangetype = 0;
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
			SetAction(0,"ʴ�Ķ���");
			SetAction(1,"ʴ�Ķ���");
			SetAction(2,"ʴ�Ķ���");
			SetAction(3,"ʴ�Ķ���");
			SetAction(4,"ʴ�Ķ���");
			SetAction(5,"ʴ�Ķ���");
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
			SetAction(18,"ʴ�Ķ���");
			SetAction(19,"ʴ�Ķ���");
			SetAction(20,"ʴ�Ķ���");
			SetAction(21,"ʴ�Ķ���");
			SetAction(22,"ʴ�Ķ���");
			SetAction(23,"ʴ�Ķ���");
			SetAction(24,"");
			SetAction(25,"");
			SetAction(26,"");
			SetAction(27,"");
			SetAction(28,"");
			SetAction(29,"");
			SetAction(30,"");
			name = "ʴ�Ķ���";
			nativename = "ʴ�Ķ���";
			icon = "ʴ�Ķ���.dds";
			SetTalent(0,1178);
			SetTalent(1,1185);
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
			return 7000;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={55,57,59,61,63,65,67,69,72,76,80,84};return array[level-1];
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

			return ((skill_level * 22.4f + (skill_level * (skill_level * 1.728f)) + 311.68f) * 0.25f);
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
			int				skill_t2 = skill.GetT2();

			victim.SetProbability(((skill_t2 * 0.1f + 1.0f) * ((1.0f - player_level * 0.002f) * 100.0f)));
			victim.SetTime(((18000 - 2000 * skill_t2)));
			victim.SetBuffid(1);
			victim.SetAmount((player_hp * (skill_level * (skill_t1 * 0.005f)) + ((skill_t1 * 0.1f + 1.0f) * (skill_level * 22.4f + (skill_level * (skill_level * 1.728f)) + 311.68f))));
			victim.SetValue((skill_t0 * ((skill_level * 22.4f + (skill_level * (skill_level * 1.728f)) + 311.68f) * 0.1f)));
			victim.SetHpleak(true);
			victim.SetProbability(-1.0f);
			victim.SetTime(((6020 * skill_t0)));
			victim.SetRatio(0.2f);
			victim.SetBuffid(1);
			victim.SetSlow(true);
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
			victim.SetValue((player_mp * 0.002f + 1.0f));
			victim.SetAdddefence(true);
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={1106};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={1};return array[index];
		}
	}
	public class GSkill1108 : GSkill
	{
		public GSkill1108()
			: base(1108)
		{
			
		}
	}
	public class GSkill1109Stub : GSkillStub
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
		public GSkill1109Stub()
			: base(1109)
		{
			occupation = 26;
			maxlevel = 12;
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
			SetAction(0,"Թ�����");
			SetAction(1,"Թ�����");
			SetAction(2,"Թ�����");
			SetAction(3,"Թ�����");
			SetAction(4,"Թ�����");
			SetAction(5,"Թ�����");
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
			SetAction(18,"Թ�����");
			SetAction(19,"Թ�����");
			SetAction(20,"Թ�����");
			SetAction(21,"Թ�����");
			SetAction(22,"Թ�����");
			SetAction(23,"Թ�����");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "Թ�����";
			nativename = "Թ�����";
			icon = "Թ�����.dds";
			SetTalent(0,1161);
			SetTalent(1,1165);
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
			int[] array={55,58,61,64,68,72,76,81};return array[level-1];
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

			victim.SetProbability(100.0f);
			victim.SetTime(((3000 * skill_level + 12100)));
			victim.SetPowerless(true);
			victim.SetTime(((3000 * skill_level + 12100)));
			victim.SetRatio((skill_t0 * 0.05f + (skill_level * 0.05f)));
			victim.SetBuffid(1);
			victim.SetIncskilldamage(true);
			victim.SetTime(4100.0f);
			victim.SetRatio(0.050000001f);
			victim.SetInccritrate(true);
			victim.SetTime(((3000 * skill_level + 12100)));
			victim.SetImmunesilent(true);
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={1105};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={3};return array[index];
		}
	}
	public class GSkill1109 : GSkill
	{
		public GSkill1109()
			: base(1109)
		{
			
		}
	}
}
