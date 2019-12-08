using System;
using System.Text;

namespace SKILL
{
	public class GSkill1570Stub : GSkillStub
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

				skill.SetRatio((skill_level <= 13)?((0.07000000000000001f * skill_level) + 0.58f):((0.07000000000000001f * (skill_level - 13)) + 0.58f));
				player.SetPerform(1);
			}
		}
		public GSkill1570Stub()
			: base(1570)
		{
			occupation = 149;
			maxlevel = 30;
			maxlearn = 10;
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
			allowform = 4;
			credittype = 10;
			clearmask = 130;
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
			SetAction(0,"�����߹�");
			SetAction(1,"�����߹�");
			SetAction(2,"�����߹�");
			SetAction(3,"�����߹�");
			SetAction(4,"�����߹�");
			SetAction(5,"�����߹�");
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
			SetAction(18,"�����߹�");
			SetAction(19,"�����߹�");
			SetAction(20,"�����߹�");
			SetAction(21,"�����߹�");
			SetAction(22,"�����߹�");
			SetAction(23,"�����߹�");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "�����߹�II";
			nativename = "�����߹�II";
			icon = "�����߹�II.dds";
			SetTalent(0,1182);
			SetTalent(1,1185);
			SetTalent(2,1189);
			SetTalent(3,2062);
			SetTalent(4,1169);
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
			int[] array={125,125,125,125,125,127,129,131,133,135};return array[level-1];
		}
		public override float GetRadius(GSkill skill)
		{
			return 11.000000f;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 26.000000f;
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

			return (skill_level <= 13)?(0.2f * ((skill_level * 4.42f + (skill_level * (14.08f * skill_level))) + 1888.0f)):(0.2f * (((skill_level - 13) * 4.42f + ((skill_level - 13) * (14.08f * (skill_level - 13)))) + 1888.0f))/**/;
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
			int				player_hp = player.GetHp();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();
			int				skill_t1 = skill.GetT1();
			int				skill_t2 = skill.GetT2();
			int				skill_t3 = skill.GetT3();
			int				skill_t4 = skill.GetT4();

			victim.SetProbability(((skill_t2 * 0.1f + 1.0f) * ((skill_t3 * 0.03f + (1.0f - player_level * 0.002f)) * 100.0f)));
			victim.SetTime(((32000 - 2000 * skill_t2)));
			victim.SetBuffid(3);
			victim.SetAmount((skill_level <= 13)?(player_hp * (skill_t1 * (skill_level * 0.005f)) + ((skill_t1 * 0.1f + 1.0f) * (((skill_level << 7) + (skill_level * (6.27f * skill_level))) + 1837.0f))):((player_hp * (skill_t1 * ((skill_level - 13) * 0.005f)) + ((skill_t1 * 0.1f + 1.0f) * (((skill_level << 7) - 1664) + ((skill_level - 13) * ((skill_level - 13) * 6.27f)) + 1837.0f))) * ((0.4f * skill_t4) + 1.0f)));
			victim.SetValue((skill_level <= 13)?(skill_t0 * (0.1f * (((skill_level << 7) + (skill_level * (6.27f * skill_level))) + 1837.0f))):(skill_t0 * ((skill_t4 * 0.4f + 1.0f) * (0.1f * ((((skill_level << 7) - 1664) + ((skill_level - 13) * (6.27f * (skill_level - 13)))) + 1837.0f)))));
			victim.SetHpleak2(true);
			victim.SetProbability(120.0f);
			victim.SetTime(32000.0f);
			victim.SetBuffid(3);
			victim.SetValue((skill_level <= 13)?(5 * (skill_t0 + 1) * skill_level):((5 * skill_level - 65) * (skill_t0 + 1)));
			victim.SetSubanti(true);
			return true;
		}
		public override int GetCreditCost(int level)
		{
			int[] array={18000,20000,22000,24000,26000,28000,30000,32000,38000,45000};return array[level-1];
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={1117};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={12};return array[index];
		}
	}
	public class GSkill1570 : GSkill
	{
		public GSkill1570()
			: base(1570)
		{
			
		}
	}
	public class GSkill1571Stub : GSkillStub
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

				skill.SetRatio((skill_level * 0.07000000000000001f + 0.58f));
				player.SetPerform(1);
			}
		}
		public GSkill1571Stub()
			: base(1571)
		{
			occupation = 149;
			maxlevel = 12;
			maxlearn = 10;
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
			allowform = 4;
			credittype = 10;
			clearmask = 130;
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
			SetAction(0,"�ٹ�ࢻ�");
			SetAction(1,"�ٹ�ࢻ�");
			SetAction(2,"�ٹ�ࢻ�");
			SetAction(3,"�ٹ�ࢻ�");
			SetAction(4,"�ٹ�ࢻ�");
			SetAction(5,"�ٹ�ࢻ�");
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
			SetAction(18,"�ٹ�ࢻ�");
			SetAction(19,"�ٹ�ࢻ�");
			SetAction(20,"�ٹ�ࢻ�");
			SetAction(21,"�ٹ�ࢻ�");
			SetAction(22,"�ٹ�ࢻ�");
			SetAction(23,"�ٹ�ࢻ�");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "�ٹ�ࢻ�II";
			nativename = "�ٹ�ࢻ�II";
			icon = "�ٹ�ࢻ�II.dds";
			SetTalent(0,1180);
			SetTalent(1,1185);
			SetTalent(2,1186);
			SetTalent(3,1189);
			SetTalent(4,2062);
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
			int[] array={125,125,125,125,125,127,129,131,133,135};return array[level-1];
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

			return ((skill_level * 371.84f + (skill_level * (skill_level * 8.960000000000001f)) + 8320.0f) * 0.2f);
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
			int				skill_t3 = skill.GetT3();
			int				skill_t4 = skill.GetT4();

			victim.SetProbability(((skill_t3 * 0.1f + 1.0f) * ((skill_t4 * 0.03f + (1.0f - player_level * 0.002f)) * 100.0f)));
			victim.SetTime(((48000 - 2000 * skill_t3)));
			victim.SetBuffid(2);
			victim.SetAmount((player_hp * (skill_level * (skill_t1 * 0.005f)) + ((skill_t1 * 0.1f + 1.0f) * (skill_level * 371.84f + (skill_level * (skill_level * 8.960000000000001f)) + 8320.0f))));
			victim.SetValue(0.0f);
			victim.SetHpleak(true);
			victim.SetProbability(((3 * skill_t0 + (5 * skill_level))));
			victim.SetTime(((1000 * skill_t2 + 4100)));
			victim.SetDiet(true);
			victim.SetProbability(((600 * norm(zrand(100) / 67))));
			victim.SetTime(((3050 * skill_t2)));
			victim.SetWrap(true);
			return true;
		}
		public override int GetCreditCost(int level)
		{
			int[] array={18000,20000,22000,24000,26000,28000,30000,32000,38000,45000};return array[level-1];
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={1126};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={12};return array[index];
		}
	}
	public class GSkill1571 : GSkill
	{
		public GSkill1571()
			: base(1571)
		{
			
		}
	}
	public class GSkill1572Stub : GSkillStub
	{
		public GSkill1572Stub()
			: base(1572)
		{
			occupation = 150;
			maxlevel = 12;
			maxlearn = 10;
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
			credittype = 11;
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
			SetAction(0,"������_����淨");
			SetAction(1,"������_����淨");
			SetAction(2,"������_����淨");
			SetAction(3,"�ϻ���_����淨");
			SetAction(4,"������_����淨");
			SetAction(5,"���_����淨");
			SetAction(6,"����_����淨");
			SetAction(7,"����_����淨");
			SetAction(8,"����_����淨");
			SetAction(9,"��ԯ_����淨");
			SetAction(10,"����_����淨");
			SetAction(11,"̫�_����淨");
			SetAction(12,"�컪_����淨");
			SetAction(13,"����_����淨");
			SetAction(14,"Ӣ��_����淨");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"������_���_����淨");
			SetAction(19,"������_���_����淨");
			SetAction(20,"������_���_����淨");
			SetAction(21,"�ϻ���_���_����淨");
			SetAction(22,"������_���_����淨");
			SetAction(23,"���_���_����淨");
			SetAction(24,"����_���_����淨");
			SetAction(25,"����_���_����淨");
			SetAction(26,"����_���_����淨");
			SetAction(27,"��ԯ_���_����淨");
			SetAction(28,"����_���_����淨");
			SetAction(29,"̫�_���_����淨");
			SetAction(30,"�컪_���_����淨");
			name = "����淨";
			nativename = "����淨";
			icon = "����淨.dds";
			SetTalent(0,1574);
			SetTalent(1,1576);
			SetTalent(2,1578);
			SetTalent(3,1580);
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
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={90,90,90,95,100,105,110,115,120,125};return array[level-1];
		}
		public override bool TakeEffect(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();
			int				skill_t1 = skill.GetT1();
			int				skill_t2 = skill.GetT2();
			int				skill_t3 = skill.GetT3();

			player.SetPasdecfatalratio((((skill_level / 10) * (skill_t3 / 10 + (skill_t2 / 10 + (skill_t1 / 10 + (skill_t0 / 10))))) * 0.01f));
			player.SetPasaddhp(((15 * skill_level * skill_level + (90 * skill_level))));
			player.SetPasadddizzy(((4 * skill_level)));
			player.SetPasincskilldodge(((50 * norm(skill_level / 9.9f))));
			return true;
		}
		public override int GetCreditCost(int level)
		{
			int[] array={10000,12000,14000,16000,18000,20000,22000,24000,26000,30000};return array[level-1];
		}
	}
	public class GSkill1572 : GSkill
	{
		public GSkill1572()
			: base(1572)
		{
			
		}
	}
	public class GSkill1573Stub : GSkillStub
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

				skill.SetRatio(1.0f);
				player.SetPerform(1);
			}
		}
		public GSkill1573Stub()
			: base(1573)
		{
			occupation = 150;
			maxlevel = 12;
			maxlearn = 10;
			eventflag = 0;
			spcost = 0;
			reborncount = 0;
			type = 1;
			timetype = 0;
			targettype = 0;
			rangetype = 0;
			doenchant = true;
			dobless = true;
			autoattack = false;
			allowform = 0;
			credittype = 11;
			clearmask = 4;
			skill_limit = 3;
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
			SetAction(0,"������_����ħ��");
			SetAction(1,"������_����ħ��");
			SetAction(2,"������_����ħ��");
			SetAction(3,"�ϻ���_����ħ��");
			SetAction(4,"������_����ħ��");
			SetAction(5,"���_����ħ��");
			SetAction(6,"�����_����ħ��");
			SetAction(7,"����_����ħ��");
			SetAction(8,"����_����ħ��");
			SetAction(9,"��ԯ_����ħ��");
			SetAction(10,"����_����ħ��");
			SetAction(11,"̫�_����ħ��");
			SetAction(12,"�컪_����ħ��");
			SetAction(13,"����_����ħ��");
			SetAction(14,"Ӣ��_����ħ��");
			SetAction(15,"������ʦ_����ħ��");
			SetAction(16,"Ԫ�ش�ʦ_����ħ��");
			SetAction(17,"������_����ħ��");
			SetAction(18,"������_���_����ħ��");
			SetAction(19,"������_���_����ħ��");
			SetAction(20,"������_���_����ħ��");
			SetAction(21,"�ϻ���_���_����ħ��");
			SetAction(22,"������_���_����ħ��");
			SetAction(23,"���_���_����ħ��");
			SetAction(24,"�����_���_����ħ��");
			SetAction(25,"����_���_����ħ��");
			SetAction(26,"����_���_����ħ��");
			SetAction(27,"��ԯ_���_����ħ��");
			SetAction(28,"����_���_����ħ��");
			SetAction(29,"̫�_���_����ħ��");
			SetAction(30,"�컪_���_����ħ��");
			name = "����ħ��";
			nativename = "����ħ��";
			icon = "����ħ��.dds";
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
			return 2700000;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={90,95,100,105,110,115,120,125,125,125};return array[level-1];
		}
		public override float GetPraydistance(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (skill_level + 12);
		}
		public override float GetCastdistance(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (skill_level + 10);
		}
		public override float GetEffectdistance(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (skill_level + 15);
		}
		public override float GetMpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (345 * skill_level + 6000);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_level = player.GetLevel();
			int				skill_level = skill.GetLevel();

			victim.SetProbability((((6 * skill_level + 34) * norm((player_level / 60)))));
			victim.SetGohome(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetProbability(100.0f);
			victim.SetTime(30000.0f);
			victim.SetRatio(0.80000001f);
			victim.SetBuffid(1);
			victim.SetWeak(true);
			return true;
		}
		public override int GetCreditCost(int level)
		{
			int[] array={18000,20000,22000,24000,26000,28000,30000,32000,38000,45000};return array[level-1];
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={1572};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={3};return array[index];
		}
	}
	public class GSkill1573 : GSkill
	{
		public GSkill1573()
			: base(1573)
		{
			
		}
	}
	public class GSkill1574Stub : GSkillStub
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
		public GSkill1574Stub()
			: base(1574)
		{
			occupation = 150;
			maxlevel = 12;
			maxlearn = 10;
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
			credittype = 11;
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
			SetAction(0,"������_��������");
			SetAction(1,"������_��������");
			SetAction(2,"������_��������");
			SetAction(3,"�ϻ���_��������");
			SetAction(4,"������_��������");
			SetAction(5,"���_��������");
			SetAction(6,"�����_��������");
			SetAction(7,"����_��������");
			SetAction(8,"����_��������");
			SetAction(9,"��ԯ_��������");
			SetAction(10,"����_��������");
			SetAction(11,"̫�_��������");
			SetAction(12,"�컪_��������");
			SetAction(13,"����_��������");
			SetAction(14,"Ӣ��_��������");
			SetAction(15,"������ʦ_��������");
			SetAction(16,"Ԫ�ش�ʦ_��������");
			SetAction(17,"������_��������");
			SetAction(18,"������_���_��������");
			SetAction(19,"������_���_��������");
			SetAction(20,"������_���_��������");
			SetAction(21,"�ϻ���_���_��������");
			SetAction(22,"������_���_��������");
			SetAction(23,"���_���_��������");
			SetAction(24,"�����_���_��������");
			SetAction(25,"����_���_��������");
			SetAction(26,"����_���_��������");
			SetAction(27,"��ԯ_���_��������");
			SetAction(28,"����_���_��������");
			SetAction(29,"̫�_���_��������");
			SetAction(30,"�컪_���_��������");
			name = "��������";
			nativename = "��������";
			icon = "��������.dds";
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
			return 600000;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={90,95,100,105,110,115,120,125,125,125};return array[level-1];
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 12.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 10.000000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 15.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (45 * skill_level + 1125);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();

			victim.SetProbability(100.0f);
			victim.SetTime(((3000 * skill_level)));
			victim.SetBuffid(8);
			victim.SetValue(((30 * skill_level)));
			victim.SetSubanti(true);
			victim.SetProbability(25.0f);
			victim.SetTime(600000.0f);
			victim.SetRatio(1547.0f);
			victim.SetAmount(1548.0f);
			victim.SetValue(1550.0f);
			victim.SetSetcooldown(true);
			victim.SetProbability(25.0f);
			victim.SetTime(600000.0f);
			victim.SetRatio(1551.0f);
			victim.SetAmount(1554.0f);
			victim.SetValue(1553.0f);
			victim.SetSetcooldown(true);
			victim.SetProbability(25.0f);
			victim.SetTime(600000.0f);
			victim.SetRatio(1555.0f);
			victim.SetAmount(1556.0f);
			victim.SetValue(1546.0f);
			victim.SetSetcooldown(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();

			victim.SetRatio(((4 * norm(zrand(100) / (90 - 5 * skill_level)) + 1572)));
			victim.SetAmount(((5 * norm(zrand(100) / (90 - 5 * skill_level)) + 1572)));
			victim.SetValue(((6 * norm(zrand(100) / (90 - 5 * skill_level)) + 1572)));
			victim.SetClearcooldown(true);
			victim.SetRatio(((7 * norm(zrand(100) / (90 - 5 * skill_level)) + 1572)));
			victim.SetAmount(1572.0f);
			victim.SetValue(1572.0f);
			victim.SetClearcooldown(true);
			return true;
		}
		public override int GetCreditCost(int level)
		{
			int[] array={18000,20000,22000,24000,26000,28000,30000,32000,38000,45000};return array[level-1];
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={1572};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={3};return array[index];
		}
	}
	public class GSkill1574 : GSkill
	{
		public GSkill1574()
			: base(1574)
		{
			
		}
	}
	public class GSkill1575Stub : GSkillStub
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
		public GSkill1575Stub()
			: base(1575)
		{
			occupation = 150;
			maxlevel = 12;
			maxlearn = 10;
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
			allowform = 0;
			credittype = 11;
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
			SetAction(0,"������_������ŭ");
			SetAction(1,"������_������ŭ");
			SetAction(2,"������_������ŭ");
			SetAction(3,"�ϻ���_������ŭ");
			SetAction(4,"������_������ŭ");
			SetAction(5,"���_������ŭ");
			SetAction(6,"�����_������ŭ");
			SetAction(7,"����_������ŭ");
			SetAction(8,"����_������ŭ");
			SetAction(9,"��ԯ_������ŭ");
			SetAction(10,"����_������ŭ");
			SetAction(11,"̫�_������ŭ");
			SetAction(12,"�컪_������ŭ");
			SetAction(13,"����_������ŭ");
			SetAction(14,"Ӣ��_������ŭ");
			SetAction(15,"������ʦ_������ŭ");
			SetAction(16,"Ԫ�ش�ʦ_������ŭ");
			SetAction(17,"������_������ŭ");
			SetAction(18,"������_���_������ŭ");
			SetAction(19,"������_���_������ŭ");
			SetAction(20,"������_���_������ŭ");
			SetAction(21,"�ϻ���_���_������ŭ");
			SetAction(22,"������_���_������ŭ");
			SetAction(23,"���_���_������ŭ");
			SetAction(24,"�����_���_������ŭ");
			SetAction(25,"����_���_������ŭ");
			SetAction(26,"����_���_������ŭ");
			SetAction(27,"��ԯ_���_������ŭ");
			SetAction(28,"����_���_������ŭ");
			SetAction(29,"̫�_���_������ŭ");
			SetAction(30,"�컪_���_������ŭ");
			name = "������ŭ";
			nativename = "������ŭ";
			icon = "������ŭ.dds";
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
			return 600000;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={90,95,100,105,110,115,120,125,125,125};return array[level-1];
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 12.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 10.000000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 15.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (45 * skill_level + 1325);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_level = player.GetLevel();
			int				skill_level = skill.GetLevel();

			victim.SetProbability(((1.0f - player_level * 0.002f) * 100.0f));
			victim.SetTime(30000.0f);
			victim.SetBuffid(9);
			victim.SetAmount(((3000 * skill_level + 3000)));
			victim.SetValue(0.0f);
			victim.SetMpleak(true);
			victim.SetProbability(100.0f);
			victim.SetTime(30000.0f);
			victim.SetBuffid(9);
			victim.SetAmount(((300 * skill_level + 150)));
			victim.SetCycsubdefence(true);
			victim.SetProbability(100.0f);
			victim.SetTime(30000.0f);
			victim.SetBuffid(9);
			victim.SetAmount(((300 * skill_level + 150)));
			victim.SetCycsubattack(true);
			return true;
		}
		public override int GetCreditCost(int level)
		{
			int[] array={18000,20000,22000,24000,26000,28000,30000,32000,38000,45000};return array[level-1];
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={1572};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={3};return array[index];
		}
	}
	public class GSkill1575 : GSkill
	{
		public GSkill1575()
			: base(1575)
		{
			
		}
	}
	public class GSkill1576Stub : GSkillStub
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
		public GSkill1576Stub()
			: base(1576)
		{
			occupation = 150;
			maxlevel = 12;
			maxlearn = 10;
			eventflag = 0;
			spcost = 0;
			reborncount = 0;
			type = 2;
			timetype = 0;
			targettype = 0;
			rangetype = 2;
			doenchant = true;
			dobless = false;
			autoattack = false;
			allowform = 0;
			credittype = 11;
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
			SetAction(0,"������_�����ӻ�");
			SetAction(1,"������_�����ӻ�");
			SetAction(2,"������_�����ӻ�");
			SetAction(3,"�ϻ���_�����ӻ�");
			SetAction(4,"������_�����ӻ�");
			SetAction(5,"���_�����ӻ�");
			SetAction(6,"�����_�����ӻ�");
			SetAction(7,"����_�����ӻ�");
			SetAction(8,"����_�����ӻ�");
			SetAction(9,"��ԯ_�����ӻ�");
			SetAction(10,"����_�����ӻ�");
			SetAction(11,"̫�_�����ӻ�");
			SetAction(12,"�컪_�����ӻ�");
			SetAction(13,"����_�����ӻ�");
			SetAction(14,"Ӣ��_�����ӻ�");
			SetAction(15,"������ʦ_�����ӻ�");
			SetAction(16,"Ԫ�ش�ʦ_�����ӻ�");
			SetAction(17,"������_�����ӻ�");
			SetAction(18,"������_���_�����ӻ�");
			SetAction(19,"������_���_�����ӻ�");
			SetAction(20,"������_���_�����ӻ�");
			SetAction(21,"�ϻ���_���_�����ӻ�");
			SetAction(22,"������_���_�����ӻ�");
			SetAction(23,"���_���_�����ӻ�");
			SetAction(24,"�����_���_�����ӻ�");
			SetAction(25,"����_���_�����ӻ�");
			SetAction(26,"����_���_�����ӻ�");
			SetAction(27,"��ԯ_���_�����ӻ�");
			SetAction(28,"����_���_�����ӻ�");
			SetAction(29,"̫�_���_�����ӻ�");
			SetAction(30,"�컪_���_�����ӻ�");
			name = "�������";
			nativename = "�������";
			icon = "�������II.dds";
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
			return 600000;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={90,95,100,105,110,115,120,125,125,125};return array[level-1];
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
			return 10.000000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 15.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (35 * skill_level + 1335);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_level = player.GetLevel();
			int				skill_level = skill.GetLevel();

			victim.SetProbability(100.0f);
			victim.SetTime(((3000 * skill_level + 15100)));
			victim.SetBuffid(9);
			victim.SetValue(((norm(player_level / 90) * 0.8f + 0.2f) * ((120 * skill_level))));
			victim.SetAdddefence(true);
			victim.SetProbability(((norm(player_level / 90) * 0.8f + 0.2f) * 100.0f));
			victim.SetAmount(1.0f);
			victim.SetCleardebuff(true);
			victim.SetProbability(((skill_level / 10) * ((norm(player_level / 90) * 0.8f + 0.2f) * 100.0f)));
			victim.SetAmount(1.0f);
			victim.SetCleardebuff(true);
			victim.SetProbability(100.0f);
			victim.SetTime(((3000 * skill_level + 15100)));
			victim.SetRatio((norm((player_level / 90)) * 0.3f + (skill_level * 0.02f)));
			victim.SetBuffid(8);
			victim.SetIncattack(true);
			return true;
		}
		public override int GetCreditCost(int level)
		{
			int[] array={18000,20000,22000,24000,26000,28000,30000,32000,38000,45000};return array[level-1];
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={1572};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={3};return array[index];
		}
	}
	public class GSkill1576 : GSkill
	{
		public GSkill1576()
			: base(1576)
		{
			
		}
	}
	public class GSkill1577Stub : GSkillStub
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
		public GSkill1577Stub()
			: base(1577)
		{
			occupation = 150;
			maxlevel = 12;
			maxlearn = 10;
			eventflag = 0;
			spcost = 0;
			reborncount = 0;
			type = 2;
			timetype = 0;
			targettype = 0;
			rangetype = 2;
			doenchant = true;
			dobless = false;
			autoattack = false;
			allowform = 0;
			credittype = 11;
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
			SetAction(0,"������_������̨");
			SetAction(1,"������_������̨");
			SetAction(2,"������_������̨");
			SetAction(3,"�ϻ���_������̨");
			SetAction(4,"������_������̨");
			SetAction(5,"���_������̨");
			SetAction(6,"�����_������̨");
			SetAction(7,"����_������̨");
			SetAction(8,"����_������̨");
			SetAction(9,"��ԯ_������̨");
			SetAction(10,"����_������̨");
			SetAction(11,"̫�_������̨");
			SetAction(12,"�컪_������̨");
			SetAction(13,"����_������̨");
			SetAction(14,"Ӣ��_������̨");
			SetAction(15,"������ʦ_������̨");
			SetAction(16,"Ԫ�ش�ʦ_������̨");
			SetAction(17,"������_������̨");
			SetAction(18,"������_���_������̨");
			SetAction(19,"������_���_������̨");
			SetAction(20,"������_���_������̨");
			SetAction(21,"�ϻ���_���_������̨");
			SetAction(22,"������_���_������̨");
			SetAction(23,"���_���_������̨");
			SetAction(24,"�����_���_������̨");
			SetAction(25,"����_���_������̨");
			SetAction(26,"����_���_������̨");
			SetAction(27,"��ԯ_���_������̨");
			SetAction(28,"����_���_������̨");
			SetAction(29,"̫�_���_������̨");
			SetAction(30,"�컪_���_������̨");
			name = "������̨";
			nativename = "������̨";
			icon = "������̨.dds";
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
			return 600000;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={90,95,100,105,110,115,120,125,125,125};return array[level-1];
		}
		public override float GetRadius(GSkill skill)
		{
			return 15.000000f;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 15.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 10.000000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return player_range + 4.0f;
		}
		public override float GetMpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (35 * skill_level + 1335);
		}
		public override int GetCoverage(GSkill skill)
		{
			return 10;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();

			victim.SetTime(((5000 * skill_level + 15100)));
			victim.SetBuffid(0);
			victim.SetValue(((20 * skill_level)));
			victim.SetAddanti(true);
			return true;
		}
		public override int GetCreditCost(int level)
		{
			int[] array={18000,20000,22000,24000,26000,28000,30000,32000,38000,45000};return array[level-1];
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={1572};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={3};return array[index];
		}
	}
	public class GSkill1577 : GSkill
	{
		public GSkill1577()
			: base(1577)
		{
			
		}
	}
	public class GSkill1578Stub : GSkillStub
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
		public GSkill1578Stub()
			: base(1578)
		{
			occupation = 150;
			maxlevel = 12;
			maxlearn = 10;
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
			credittype = 11;
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
			SetAction(0,"������_����֮��");
			SetAction(1,"������_����֮��");
			SetAction(2,"������_����֮��");
			SetAction(3,"�ϻ���_����֮��");
			SetAction(4,"������_����֮��");
			SetAction(5,"���_����֮��");
			SetAction(6,"�����_����֮��");
			SetAction(7,"����_����֮��");
			SetAction(8,"����_����֮��");
			SetAction(9,"��ԯ_����֮��");
			SetAction(10,"����_����֮��");
			SetAction(11,"̫�_����֮��");
			SetAction(12,"�컪_����֮��");
			SetAction(13,"����_����֮��");
			SetAction(14,"Ӣ��_����֮��");
			SetAction(15,"������ʦ_����֮��");
			SetAction(16,"Ԫ�ش�ʦ_����֮��");
			SetAction(17,"������_����֮��");
			SetAction(18,"������_���_����֮��");
			SetAction(19,"������_���_��֮��");
			SetAction(20,"������_���_����֮��");
			SetAction(21,"�ϻ���_���_����֮��");
			SetAction(22,"������_���_����֮��");
			SetAction(23,"���_���_����֮��");
			SetAction(24,"�����_���_����֮��");
			SetAction(25,"����_���_����֮��");
			SetAction(26,"����_���_����֮��");
			SetAction(27,"��ԯ_���_����֮��");
			SetAction(28,"����_���_����֮��");
			SetAction(29,"̫�_���_����֮��");
			SetAction(30,"�컪_���_����֮��");
			name = "����֮��";
			nativename = "����֮��";
			icon = "����֮��.dds";
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
			return 600000;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={90,95,100,105,110,115,120,125,125,125};return array[level-1];
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

			return (35 * skill_level + 1335);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();

			victim.SetProbability(((skill_level + 79)));
			victim.SetTime(((6000 * skill_level + 30100)));
			victim.SetRatio((skill_level * 0.08f + 0.2f <= 1.0f)?(skill_level * 0.08f + 0.2f):1.0f);
			victim.SetAmount(((4 * skill_level + 5)));
			victim.SetDeadlybless(true);
			return true;
		}
		public override int GetCreditCost(int level)
		{
			int[] array={18000,20000,22000,24000,26000,28000,30000,32000,38000,45000};return array[level-1];
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={1572};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={3};return array[index];
		}
	}
	public class GSkill1578 : GSkill
	{
		public GSkill1578()
			: base(1578)
		{
			
		}
	}
	public class GSkill1579Stub : GSkillStub
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
		public GSkill1579Stub()
			: base(1579)
		{
			occupation = 150;
			maxlevel = 12;
			maxlearn = 10;
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
			credittype = 11;
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
			SetAction(0,"������_���֮��");
			SetAction(1,"������_���֮��");
			SetAction(2,"������_���֮��");
			SetAction(3,"�ϻ���_���֮��");
			SetAction(4,"������_���֮��");
			SetAction(5,"���_���֮��");
			SetAction(6,"�����_���֮��");
			SetAction(7,"����_���֮��");
			SetAction(8,"����_���֮��");
			SetAction(9,"��ԯ_���֮��");
			SetAction(10,"����_���֮��");
			SetAction(11,"̫�_���֮��");
			SetAction(12,"�컪_���֮��");
			SetAction(13,"����_���֮��");
			SetAction(14,"Ӣ��_���֮��");
			SetAction(15,"������ʦ_���֮��");
			SetAction(16,"Ԫ�ش�ʦ_���֮��");
			SetAction(17,"������_���֮��");
			SetAction(18,"������_���_���֮��");
			SetAction(19,"������_���_���֮��");
			SetAction(20,"������_���_���֮��");
			SetAction(21,"�ϻ���_���_���֮��");
			SetAction(22,"������_���_���֮��");
			SetAction(23,"���_���_���֮��");
			SetAction(24,"�����_���_���֮��");
			SetAction(25,"����_���_���֮��");
			SetAction(26,"����_���_���֮��");
			SetAction(27,"��ԯ_���_���֮��");
			SetAction(28,"����_���_���֮��");
			SetAction(29,"̫�_���_���֮��");
			SetAction(30,"�컪_���_���֮��");
			name = "���֮��";
			nativename = "���֮��";
			icon = "���֮��.dds";
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
			return 600000;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={90,95,100,105,110,115,120,125,125,125};return array[level-1];
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

			return (50 * skill_level + 1700);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();

			victim.SetProbability(((10 * skill_level)));
			victim.SetTime(((3000 * skill_level + 15100)));
			victim.SetRejectdebuff(true);
			return true;
		}
		public override int GetCreditCost(int level)
		{
			int[] array={18000,20000,22000,24000,26000,28000,30000,32000,38000,45000};return array[level-1];
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={1572};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={3};return array[index];
		}
	}
	public class GSkill1579 : GSkill
	{
		public GSkill1579()
			: base(1579)
		{
			
		}
	}
}
