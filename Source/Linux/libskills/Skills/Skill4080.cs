using System;
using System.Text;

namespace SKILL
{
	public class GSkill4080Stub : GSkillStub
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
				int				player_level = player.GetLevel();
				int				player_hp = player.GetHp();
				int				player_maxhp = player.GetMaxhp();
				int				player_mp = player.GetMp();
				int				player_maxmp = player.GetMaxmp();
				int				player_maxatk = player.GetMaxatk();
				int				player_def = player.GetDef();
				int				player_res1 = player.GetRes1();
				int				player_res2 = player.GetRes2();
				int				player_res3 = player.GetRes3();
				int				player_res4 = player.GetRes4();
				int				player_res5 = player.GetRes5();
				int				player_occupation = player.GetOccupation();
				int				skill_level = skill.GetLevel();
				int				skill_t0 = skill.GetT0();
				int				skill_t1 = skill.GetT1();

				/*
				player.SetVar11(player_occupation);
				player.SetVar1(player_maxatk);
				player.SetVar2(player_maxhp);
				player.SetVar3(player_maxmp);
				player.SetVar4(player_hp);
				player.SetVar5(player_mp);
				player.SetVar6(player_res1);
				player.SetVar7(player_res2);
				player.SetVar8(player_res3);
				player.SetVar9(player_res4);
				player.SetVar10(player_res5);
				if ( zrand(100) >= (skill_level + 1) * (skill_level + 1) )
				    v = 2;
				  else
				    v = 1;
				player.SetVar16(v);
				skill.SetCrit((skill_level * 0.01f));
				skill.SetCrithurt((skill_level * (skill_level * 0.01f) + (skill_level * 0.1f)));
				skill.SetRatio((D2INT(player_level / (9 - skill_level)) * 0.01f + (skill_level * 0.07000000000000001f + (skill_t0 * 0.1f + 1.0f))));
				skill.SetPlus((player_def * (skill_t1 * 0.03f) + ((215 * skill_level))));
				player.SetPerform(1);
				*/
			}
		}
		public GSkill4080Stub()
			: base(4080)
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
			SetAction(0,"������_����_��ڤ����");
			SetAction(1,"������_����_��ڤ����");
			SetAction(2,"������_����_��ڤ����");
			SetAction(3,"������_����_��ڤ����");
			SetAction(4,"������_����_��ڤ����");
			SetAction(5,"������_����_��ڤ����");
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
			SetAction(18,"������_���_����_��ڤ����");
			SetAction(19,"������_���_����_��ڤ����");
			SetAction(20,"������_���_����_��ڤ����");
			SetAction(21,"������_���_����_��ڤ����");
			SetAction(22,"������_���_����_��ڤ����");
			SetAction(23,"������_���_����_��ڤ����");
			SetAction(24,"");
			SetAction(25,"");
			SetAction(26,"");
			SetAction(27,"");
			SetAction(28,"");
			SetAction(29,"");
			SetAction(30,"");
			name = "�桤�����ĸ�";
			nativename = "�桤�����ĸ�";
			icon = "���������ĸ�.dds";
			SetTalent(0,652);
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
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetTalismaneffects(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetTalismaneffectsbless(true);
			return true;
		}
	}
	public class GSkill4080 : GSkill
	{
		public GSkill4080()
			: base(4080)
		{
			
		}
	}
	public class GSkill4081Stub : GSkillStub
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
				return 500;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_level = player.GetLevel();
				int				player_hp = player.GetHp();
				int				player_maxhp = player.GetMaxhp();
				int				player_mp = player.GetMp();
				int				player_maxmp = player.GetMaxmp();
				int				player_maxatk = player.GetMaxatk();
				int				player_def = player.GetDef();
				int				player_res1 = player.GetRes1();
				int				player_res2 = player.GetRes2();
				int				player_res3 = player.GetRes3();
				int				player_res4 = player.GetRes4();
				int				player_res5 = player.GetRes5();
				int				player_occupation = player.GetOccupation();
				int				skill_level = skill.GetLevel();
				int				skill_t0 = skill.GetT0();
				int				skill_t1 = skill.GetT1();

				/*
				player.SetVar11(player_occupation);
				player.SetVar1(player_maxatk);
				player.SetVar2(player_maxhp);
				player.SetVar3(player_maxmp);
				player.SetVar4(player_hp);
				player.SetVar5(player_mp);
				player.SetVar6(player_res1);
				player.SetVar7(player_res2);
				player.SetVar8(player_res3);
				player.SetVar9(player_res4);
				player.SetVar10(player_res5);
				if ( zrand(100) >= (skill_level + 1) * (skill_level + 1) )
				    v = 2;
				  else
				    v = 1;
				player.SetVar16(v);
				skill.SetRatio((D2INT(player_level / (9 - skill_level)) * 0.01f + (skill_level * 0.07000000000000001f + (skill_t0 * 0.1f + 1.0f))));
				skill.SetPlus((player_def * (skill_t1 * 0.03f) + ((215 * skill_level))));
				player.SetPerform(1);
				*/
			}
		}
		public GSkill4081Stub()
			: base(4081)
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
			SetAction(0,"������_����_�ֻ���");
			SetAction(1,"������_����_�ֻ���");
			SetAction(2,"������_����_�ֻ���");
			SetAction(3,"������_����_�ֻ���");
			SetAction(4,"������_����_�ֻ���");
			SetAction(5,"������_����_�ֻ���");
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
			SetAction(18,"������_���_����_�ֻ���");
			SetAction(19,"������_���_����_�ֻ���");
			SetAction(20,"������_���_����_�ֻ���");
			SetAction(21,"������_���_����_�ֻ���");
			SetAction(22,"������_���_����_�ֻ���");
			SetAction(23,"������_���_����_�ֻ���");
			SetAction(24,"");
			SetAction(25,"");
			SetAction(26,"");
			SetAction(27,"");
			SetAction(28,"");
			SetAction(29,"");
			SetAction(30,"");
			name = "�桤��������";
			nativename = "�桤��������";
			icon = "������������.dds";
			SetTalent(0,670);
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
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetTalismaneffects(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetTalismaneffectsbless(true);
			return true;
		}
	}
	public class GSkill4081 : GSkill
	{
		public GSkill4081()
			: base(4081)
		{
			
		}
	}
	public class GSkill4082Stub : GSkillStub
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
				int				player_level = player.GetLevel();
				int				player_hp = player.GetHp();
				int				player_maxhp = player.GetMaxhp();
				int				player_mp = player.GetMp();
				int				player_maxmp = player.GetMaxmp();
				int				player_maxatk = player.GetMaxatk();
				int				player_def = player.GetDef();
				int				player_res1 = player.GetRes1();
				int				player_res2 = player.GetRes2();
				int				player_res3 = player.GetRes3();
				int				player_res4 = player.GetRes4();
				int				player_res5 = player.GetRes5();
				int				player_occupation = player.GetOccupation();
				int				skill_level = skill.GetLevel();
				int				skill_t0 = skill.GetT0();
				int				skill_t1 = skill.GetT1();

				/*
				player.SetVar11(player_occupation);
				player.SetVar1(player_maxatk);
				player.SetVar2(player_maxhp);
				player.SetVar3(player_maxmp);
				player.SetVar4(player_hp);
				player.SetVar5(player_mp);
				player.SetVar6(player_res1);
				player.SetVar7(player_res2);
				player.SetVar8(player_res3);
				player.SetVar9(player_res4);
				player.SetVar10(player_res5);
				if ( zrand(100) >= (skill_level + 1) * (skill_level + 1) )
				    v = 2;
				  else
				    v = 1;
				player.SetVar16(v);
				skill.SetRatio((D2INT(player_level / (9 - skill_level)) * 0.01f + (skill_level * 0.07000000000000001f + (skill_t0 * 0.1f + 1.0f))));
				skill.SetPlus((player_def * (skill_t1 * 0.03f) + ((215 * skill_level))));
				player.SetPerform(1);
				*/
			}
		}
		public GSkill4082Stub()
			: base(4082)
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
			SetAction(0,"�ϻ���_����_����");
			SetAction(1,"�ϻ���_����_����");
			SetAction(2,"�ϻ���_����_����");
			SetAction(3,"�ϻ���_����_����");
			SetAction(4,"�ϻ���_����_����");
			SetAction(5,"�ϻ���_����_����");
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
			SetAction(18,"�ϻ���_���_����_����");
			SetAction(19,"�ϻ���_���_����_����");
			SetAction(20,"�ϻ���_���_����_����");
			SetAction(21,"�ϻ���_���_����_����");
			SetAction(22,"�ϻ���_���_����_����");
			SetAction(23,"�ϻ���_���_����_����");
			SetAction(24,"");
			SetAction(25,"");
			SetAction(26,"");
			SetAction(27,"");
			SetAction(28,"");
			SetAction(29,"");
			SetAction(30,"");
			name = "�桤����֮��";
			nativename = "�桤����֮��";
			icon = "��������֮��.dds";
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
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetTalismaneffects(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetTalismaneffectsbless(true);
			return true;
		}
	}
	public class GSkill4082 : GSkill
	{
		public GSkill4082()
			: base(4082)
		{
			
		}
	}
	public class GSkill4083Stub : GSkillStub
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
				int				player_level = player.GetLevel();
				int				player_hp = player.GetHp();
				int				player_maxhp = player.GetMaxhp();
				int				player_mp = player.GetMp();
				int				player_maxmp = player.GetMaxmp();
				int				player_maxatk = player.GetMaxatk();
				int				player_def = player.GetDef();
				int				player_res1 = player.GetRes1();
				int				player_res2 = player.GetRes2();
				int				player_res3 = player.GetRes3();
				int				player_res4 = player.GetRes4();
				int				player_res5 = player.GetRes5();
				int				player_occupation = player.GetOccupation();
				int				skill_level = skill.GetLevel();
				int				skill_t0 = skill.GetT0();
				int				skill_t1 = skill.GetT1();

				/*
				player.SetVar11(player_occupation);
				player.SetVar1(player_maxatk);
				player.SetVar2(player_maxhp);
				player.SetVar3(player_maxmp);
				player.SetVar4(player_hp);
				player.SetVar5(player_mp);
				player.SetVar6(player_res1);
				player.SetVar7(player_res2);
				player.SetVar8(player_res3);
				player.SetVar9(player_res4);
				player.SetVar10(player_res5);
				if ( zrand(100) >= (skill_level + 1) * (skill_level + 1) )
				    v = 2;
				  else
				    v = 1;
				player.SetVar16(v);
				skill.SetRatio((D2INT(player_level / (9 - skill_level)) * 0.01f + (skill_level * 0.07000000000000001f + (skill_t0 * 0.1f + 1.0f))));
				skill.SetPlus((player_def * (skill_t1 * 0.03f) + ((skill_t0 * 0.1f + 1.0f) * ((player_hp + player_mp) * 0.04f) + ((215 * skill_level)))));
				player.SetPerform(1);
				*/
			}
		}
		public GSkill4083Stub()
			: base(4083)
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
			SetAction(0,"���_����_����");
			SetAction(1,"���_����_����");
			SetAction(2,"���_����_����");
			SetAction(3,"���_����_����");
			SetAction(4,"���_����_����");
			SetAction(5,"���_����_����");
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
			SetAction(18,"���_���_����_����");
			SetAction(19,"���_���_����_����");
			SetAction(20,"���_���_����_����");
			SetAction(21,"���_���_����_����");
			SetAction(22,"���_���_����_����");
			SetAction(23,"���_���_����_����");
			SetAction(24,"");
			SetAction(25,"");
			SetAction(26,"");
			SetAction(27,"");
			SetAction(28,"");
			SetAction(29,"");
			SetAction(30,"");
			name = "�桤����֮��";
			nativename = "�桤����֮��";
			icon = "�����������.dds";
			SetTalent(0,1174);
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

			return ((-35 * skill_level) - skill_level * skill_level + 495);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetTalismaneffects(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetTalismaneffectsbless(true);
			return true;
		}
	}
	public class GSkill4083 : GSkill
	{
		public GSkill4083()
			: base(4083)
		{
			
		}
	}
	public class GSkill4084Stub : GSkillStub
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
				int				player_level = player.GetLevel();
				int				player_hp = player.GetHp();
				int				player_maxhp = player.GetMaxhp();
				int				player_mp = player.GetMp();
				int				player_maxmp = player.GetMaxmp();
				int				player_maxatk = player.GetMaxatk();
				int				player_res1 = player.GetRes1();
				int				player_res2 = player.GetRes2();
				int				player_res3 = player.GetRes3();
				int				player_res4 = player.GetRes4();
				int				player_res5 = player.GetRes5();
				int				player_occupation = player.GetOccupation();
				int				skill_level = skill.GetLevel();

				/*
				player.SetVar11(player_occupation);
				player.SetVar1(player_maxatk);
				player.SetVar2(player_maxhp);
				player.SetVar3(player_maxmp);
				player.SetVar4(player_hp);
				player.SetVar5(player_mp);
				player.SetVar6(player_res1);
				player.SetVar7(player_res2);
				player.SetVar8(player_res3);
				player.SetVar9(player_res4);
				player.SetVar10(player_res5);
				if ( zrand(100) >= (skill_level + 1) * (skill_level + 1) )
				    v = 2;
				  else
				    v = 1;
				player.SetVar16(v);
				if ( zrand(100) >= skill_level * skill_level )
				    v48 = 2;
				  else
				player.SetVar1(1);
				skill.SetRatio((D2INT(player_level / (9 - skill_level)) * 0.01f + (skill_level * 0.07000000000000001f + 1.0f)));
				skill.SetPlus(((215 * skill_level)));
				player.SetPerform(1);
				*/
			}
		}
		public GSkill4084Stub()
			: base(4084)
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
			SetAction(0,"�����_����_�ź�������");
			SetAction(1,"�����_����_�ź�������");
			SetAction(2,"�����_����_�ź�������");
			SetAction(3,"�����_����_�ź�������");
			SetAction(4,"�����_����_�ź�������");
			SetAction(5,"�����_����_�ź�������");
			SetAction(6,"�����_����_�ź�������");
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
			SetAction(18,"�����_���_����_�ź�������");
			SetAction(19,"�����_���_����_�ź�������");
			SetAction(20,"�����_���_����_�ź�������");
			SetAction(21,"�����_���_����_�ź�������");
			SetAction(22,"�����_���_����_�ź�������");
			SetAction(23,"�����_���_����_�ź�������");
			SetAction(24,"�����_���_����_�ź�������");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "�桤̫������";
			nativename = "�桤̫������";
			icon = "����̫������.dds";
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

			return 6300 - 300 * skill_level;
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
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetTalismaneffects(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetTalismaneffectsbless(true);
			return true;
		}
	}
	public class GSkill4084 : GSkill
	{
		public GSkill4084()
			: base(4084)
		{
			
		}
	}
	public class GSkill4085Stub : GSkillStub
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
				int				player_level = player.GetLevel();
				int				player_hp = player.GetHp();
				int				player_maxhp = player.GetMaxhp();
				int				player_mp = player.GetMp();
				int				player_maxmp = player.GetMaxmp();
				int				player_maxatk = player.GetMaxatk();
				int				player_res1 = player.GetRes1();
				int				player_res2 = player.GetRes2();
				int				player_res3 = player.GetRes3();
				int				player_res4 = player.GetRes4();
				int				player_res5 = player.GetRes5();
				int				player_occupation = player.GetOccupation();
				int				skill_level = skill.GetLevel();

				/*
				player.SetVar11(player_occupation);
				player.SetVar1(player_maxatk);
				player.SetVar2(player_maxhp);
				player.SetVar3(player_maxmp);
				player.SetVar4(player_hp);
				player.SetVar5(player_mp);
				player.SetVar6(player_res1);
				player.SetVar7(player_res2);
				player.SetVar8(player_res3);
				player.SetVar9(player_res4);
				player.SetVar10(player_res5);
				if ( zrand(100) >= (skill_level + 1) * (skill_level + 1) )
				    v = 2;
				  else
				    v = 1;
				player.SetVar16(v);
				skill.SetCrit((D2INT(skill_level / 4.9f) * 0.03f + (skill_level * 0.02f)));
				skill.SetCrithurt((skill_level * (skill_level * 0.01f) + (skill_level * 0.1f)));
				skill.SetRatio((D2INT(player_level / (9 - skill_level)) * 0.02f + (skill_level * 0.06f + 1.0f)));
				skill.SetPlus(((500 * skill_level)));
				player.SetPerform(1);
				*/
			}
		}
		public GSkill4085Stub()
			: base(4085)
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
			SetAction(0,"����_����_ɥ�Ž�");
			SetAction(1,"0");
			SetAction(2,"0");
			SetAction(3,"0");
			SetAction(4,"0");
			SetAction(5,"0");
			SetAction(6,"0");
			SetAction(7,"����_����_ɥ�Ž�");
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
			SetAction(18,"����_���_����_ɥ�Ž�");
			SetAction(19,"0");
			SetAction(20,"0");
			SetAction(21,"0");
			SetAction(22,"0");
			SetAction(23,"0");
			SetAction(24,"0");
			SetAction(25,"����_���_����_ɥ�Ž�");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "�桤����ɥ��";
			nativename = "�桤����ɥ��";
			icon = "��������ɥ��.dds";
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
			return 2500;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return 6300 - 300 * skill_level;
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

			return ((-35 * skill_level) - skill_level * skill_level + 745);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetTalismaneffects(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetTalismaneffectsbless(true);
			return true;
		}
	}
	public class GSkill4085 : GSkill
	{
		public GSkill4085()
			: base(4085)
		{
			
		}
	}
	public class GSkill4086Stub : GSkillStub
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
				int				player_level = player.GetLevel();
				int				player_hp = player.GetHp();
				int				player_maxhp = player.GetMaxhp();
				int				player_mp = player.GetMp();
				int				player_maxmp = player.GetMaxmp();
				int				player_maxatk = player.GetMaxatk();
				int				player_res1 = player.GetRes1();
				int				player_res2 = player.GetRes2();
				int				player_res3 = player.GetRes3();
				int				player_res4 = player.GetRes4();
				int				player_res5 = player.GetRes5();
				int				player_occupation = player.GetOccupation();
				int				skill_level = skill.GetLevel();

				/*
				player.SetVar11(player_occupation);
				player.SetVar1(player_maxatk);
				player.SetVar2(player_maxhp);
				player.SetVar3(player_maxmp);
				player.SetVar4(player_hp);
				player.SetVar5(player_mp);
				player.SetVar6(player_res1);
				player.SetVar7(player_res2);
				player.SetVar8(player_res3);
				player.SetVar9(player_res4);
				player.SetVar10(player_res5);
				if ( zrand(100) >= (skill_level + 1) * (skill_level + 1) )
				    v = 2;
				  else
				    v = 1;
				player.SetVar16(v);
				skill.SetRatio((D2INT(player_level / (9 - skill_level)) * 0.01f + (skill_level * 0.07000000000000001f + 1.0f)));
				skill.SetPlus(((215 * skill_level)));
				player.SetPerform(1);
				*/
			}
		}
		public GSkill4086Stub()
			: base(4086)
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
			SetAction(0,"����_����_����");
			SetAction(1,"0");
			SetAction(2,"0");
			SetAction(3,"0");
			SetAction(4,"0");
			SetAction(5,"0");
			SetAction(6,"0");
			SetAction(7,"0");
			SetAction(8,"����_����_����");
			SetAction(9,"0");
			SetAction(10,"0");
			SetAction(11,"0");
			SetAction(12,"0");
			SetAction(13,"");
			SetAction(14,"");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"����_���_����_����");
			SetAction(19,"0");
			SetAction(20,"0");
			SetAction(21,"0");
			SetAction(22,"0");
			SetAction(23,"0");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"����_���_����_����");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "�桤�ػ�����";
			nativename = "�桤�ػ�����";
			icon = "�����ػ�����.dds";
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

			return 6300 - 300 * skill_level;
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
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetTalismaneffects(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetTalismaneffectsbless(true);
			return true;
		}
	}
	public class GSkill4086 : GSkill
	{
		public GSkill4086()
			: base(4086)
		{
			
		}
	}
	public class GSkill4087Stub : GSkillStub
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
				int				player_level = player.GetLevel();
				int				player_hp = player.GetHp();
				int				player_maxhp = player.GetMaxhp();
				int				player_mp = player.GetMp();
				int				player_maxmp = player.GetMaxmp();
				int				player_maxatk = player.GetMaxatk();
				int				player_res1 = player.GetRes1();
				int				player_res2 = player.GetRes2();
				int				player_res3 = player.GetRes3();
				int				player_res4 = player.GetRes4();
				int				player_res5 = player.GetRes5();
				int				player_occupation = player.GetOccupation();
				int				skill_level = skill.GetLevel();

				/*
				player.SetVar11(player_occupation);
				player.SetVar1(player_maxatk);
				player.SetVar2(player_maxhp);
				player.SetVar3(player_maxmp);
				player.SetVar4(player_hp);
				player.SetVar5(player_mp);
				player.SetVar6(player_res1);
				player.SetVar7(player_res2);
				player.SetVar8(player_res3);
				player.SetVar9(player_res4);
				player.SetVar10(player_res5);
				if ( zrand(100) >= (skill_level + 1) * (skill_level + 1) )
				    v = 2;
				  else
				    v = 1;
				player.SetVar16(v);
				skill.SetRatio((D2INT(player_level / (9 - skill_level)) * 0.01f + (skill_level * 0.07000000000000001f + 1.0f)));
				skill.SetPlus(((215 * skill_level)));
				player.SetPerform(1);
				*/
			}
		}
		public GSkill4087Stub()
			: base(4087)
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
			SetAction(0,"����_����_��Ӱ");
			SetAction(1,"0");
			SetAction(2,"0");
			SetAction(3,"0");
			SetAction(4,"0");
			SetAction(5,"0");
			SetAction(6,"0");
			SetAction(7,"0");
			SetAction(8,"0");
			SetAction(9,"0");
			SetAction(10,"����_����_��Ӱ");
			SetAction(11,"0");
			SetAction(12,"0");
			SetAction(13,"");
			SetAction(14,"");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"����_���_����_��Ӱ");
			SetAction(19,"0");
			SetAction(20,"0");
			SetAction(21,"0");
			SetAction(22,"0");
			SetAction(23,"0");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"����_���_����_��Ӱ");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "�桤���Ӱ��";
			nativename = "�桤���Ӱ��";
			icon = "�������Ӱ��.dds";
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
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetTalismaneffects(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetTalismaneffectsbless(true);
			return true;
		}
	}
	public class GSkill4087 : GSkill
	{
		public GSkill4087()
			: base(4087)
		{
			
		}
	}
	public class GSkill4088Stub : GSkillStub
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
				int				player_level = player.GetLevel();
				int				player_hp = player.GetHp();
				int				player_maxhp = player.GetMaxhp();
				int				player_mp = player.GetMp();
				int				player_maxmp = player.GetMaxmp();
				int				player_maxatk = player.GetMaxatk();
				int				player_res1 = player.GetRes1();
				int				player_res2 = player.GetRes2();
				int				player_res3 = player.GetRes3();
				int				player_res4 = player.GetRes4();
				int				player_res5 = player.GetRes5();
				int				player_occupation = player.GetOccupation();
				int				skill_level = skill.GetLevel();

				/*
				player.SetVar11(player_occupation);
				player.SetVar1(player_maxatk);
				player.SetVar2(player_maxhp);
				player.SetVar3(player_maxmp);
				player.SetVar4(player_hp);
				player.SetVar5(player_mp);
				player.SetVar6(player_res1);
				player.SetVar7(player_res2);
				player.SetVar8(player_res3);
				player.SetVar9(player_res4);
				player.SetVar10(player_res5);
				if ( zrand(100) >= (skill_level + 1) * (skill_level + 1) )
				    v = 2;
				  else
				    v = 1;
				player.SetVar16(v);
				skill.SetRatio((D2INT(player_level / (9 - skill_level)) * 0.01f + (skill_level * 0.08f + 1.0f)));
				skill.SetPlus(((175 * skill_level)));
				player.SetPerform(1);
				*/
			}
		}
		public GSkill4088Stub()
			: base(4088)
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
			SetAction(0,"�컪_����_����ɺ�");
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
			SetAction(12,"�컪_����_����ɺ�");
			SetAction(13,"");
			SetAction(14,"");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"�컪_���_����_����ɺ�");
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
			SetAction(30,"�컪_���_����_����ɺ�");
			name = "�桤��ħ����";
			nativename = "�桤��ħ����";
			icon = "������ħ����.dds";
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

			return 6300 - 300 * skill_level;
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
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetTalismaneffects(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetTalismaneffectsbless(true);
			return true;
		}
	}
	public class GSkill4088 : GSkill
	{
		public GSkill4088()
			: base(4088)
		{
			
		}
	}
	public class GSkill4089Stub : GSkillStub
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
				int				player_level = player.GetLevel();
				int				player_hp = player.GetHp();
				int				player_maxhp = player.GetMaxhp();
				int				player_mp = player.GetMp();
				int				player_maxmp = player.GetMaxmp();
				int				player_maxatk = player.GetMaxatk();
				int				player_res1 = player.GetRes1();
				int				player_res2 = player.GetRes2();
				int				player_res3 = player.GetRes3();
				int				player_res4 = player.GetRes4();
				int				player_res5 = player.GetRes5();
				int				player_occupation = player.GetOccupation();
				int				skill_level = skill.GetLevel();

				/*
				player.SetVar11(player_occupation);
				player.SetVar1(player_maxatk);
				player.SetVar2(player_maxhp);
				player.SetVar3(player_maxmp);
				player.SetVar4(player_hp);
				player.SetVar5(player_mp);
				player.SetVar6(player_res1);
				player.SetVar7(player_res2);
				player.SetVar8(player_res3);
				player.SetVar9(player_res4);
				player.SetVar10(player_res5);
				if ( zrand(100) >= (skill_level + 1) * (skill_level + 1) )
				    v = 2;
				  else
				    v = 1;
				player.SetVar16(v);
				skill.SetCrit((skill_level * 0.01f));
				skill.SetCrithurt((skill_level * (skill_level * 0.01f) + (skill_level * 0.05f)));
				skill.SetRatio((D2INT(player_level / (9 - skill_level)) * 0.01f + (skill_level * 0.07000000000000001f + 1.0f)));
				skill.SetPlus(((215 * skill_level)));
				player.SetPerform(1);
				*/
			}
		}
		public GSkill4089Stub()
			: base(4089)
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
			SetAction(0,"̫�_����_�˻���");
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
			SetAction(11,"̫�_����_�˻���");
			SetAction(12,"0");
			SetAction(13,"");
			SetAction(14,"");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"̫�_���_����_�˻���");
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
			SetAction(29,"̫�_���_����_�˻���");
			SetAction(30,"0");
			name = "�桤��������";
			nativename = "�桤��������";
			icon = "������������.dds";
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

			return 6300 - 300 * skill_level;
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
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetTalismaneffects(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetTalismaneffectsbless(true);
			return true;
		}
	}
	public class GSkill4089 : GSkill
	{
		public GSkill4089()
			: base(4089)
		{
			
		}
	}
}
