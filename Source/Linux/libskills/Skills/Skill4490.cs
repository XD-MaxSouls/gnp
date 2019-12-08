using System;
using System.Text;

namespace SKILL
{
	public class GSkill4490Stub : GSkillStub
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
				int				player_level = player.GetLevel();
				int				player_hp = player.GetHp();
				int				player_mp = player.GetMp();
				int				player_def = player.GetDef();
				int				skill_level = skill.GetLevel();
				int				skill_t0 = skill.GetT0();
				int				skill_t1 = skill.GetT1();

				skill.SetRatio((D2INT(player_level / (10 - skill_level)) * 0.01f + (skill_level * 0.05f + (skill_t0 * 0.1f + 1.0f))));
				skill.SetPlus((player_def * (skill_t1 * 0.03f) + ((skill_t0 * 0.1f + 1.0f) * ((player_mp + player_hp) * 0.03f) + ((135 * skill_level)))));
				player.SetPerform(1);
			}
		}
		public GSkill4490Stub()
			: base(4490)
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
			dobless = false;
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
			SetAction(0,"���_����_ǧ����");
			SetAction(1,"���_����_ǧ����");
			SetAction(2,"���_����_ǧ����");
			SetAction(3,"���_����_ǧ����");
			SetAction(4,"���_����_ǧ����");
			SetAction(5,"���_����_ǧ����");
			SetAction(6,"���_����_ǧ����");
			SetAction(7,"����_����_��");
			SetAction(8,"����_����_��Ӱ�ž�");
			SetAction(9,"��ԯ_����_��ؽ�Ǯ");
			SetAction(10,"����_����_̰��");
			SetAction(11,"̫�_����_��ĸ������");
			SetAction(12,"�컪_����_����յ");
			SetAction(13,"01");
			SetAction(14,"01");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"���_���_����_ǧ����");
			SetAction(19,"���_���_����_ǧ����");
			SetAction(20,"���_���_����_ǧ����");
			SetAction(21,"���_���_����_ǧ����");
			SetAction(22,"���_���_����_ǧ����");
			SetAction(23,"���_���_����_ǧ����");
			SetAction(24,"���_���_����_ǧ����");
			SetAction(25,"����_���_����_��");
			SetAction(26,"����_���_����_��Ӱ�ž�");
			SetAction(27,"��ԯ_���_����_��ؽ�Ǯ");
			SetAction(28,"����_���_����_̰��");
			SetAction(29,"̫�_���_����_��ĸ������");
			SetAction(30,"�컪_���_����_����յ");
			name = "�С���������";
			nativename = "�С���������";
			icon = "����ڤڤ.dds";
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

			return ((-25 * skill_level) - skill_level * skill_level + 305);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_level = player.GetLevel();
			int				skill_level = skill.GetLevel();

			victim.SetTime(6100.0f);
			victim.SetRatio((skill_level * 0.03f));
			victim.SetBuffid(1);
			victim.SetDecskilldamage(true);
			victim.SetProbability(100.0f);
			victim.SetTime(((3000 * skill_level + 100)));
			victim.SetBuffid(5);
			victim.SetValue((player_level * (skill_level * 0.3f) + 1.0f));
			victim.SetSubdefence(true);
			return true;
		}
	}
	public class GSkill4490 : GSkill
	{
		public GSkill4490()
			: base(4490)
		{
			
		}
	}
	public class GSkill4491Stub : GSkillStub
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
				int				skill_level = skill.GetLevel();

				skill.SetRatio((D2INT(player_level / (10 - skill_level)) * 0.01f + (skill_level * 0.05f + 1.0f)));
				skill.SetPlus(((120 * skill_level)));
				player.SetPerform(1);
			}
		}
		public GSkill4491Stub()
			: base(4491)
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
			SetAction(0,"�����_����_������");
			SetAction(1,"�����_����_������");
			SetAction(2,"�����_����_������");
			SetAction(3,"�����_����_������");
			SetAction(4,"�����_����_������");
			SetAction(5,"�����_����_������");
			SetAction(6,"�����_����_������");
			SetAction(7,"����_����_��");
			SetAction(8,"����_����_��Ӱ�ž�");
			SetAction(9,"��ԯ_����_��ؽ�Ǯ");
			SetAction(10,"����_����_̰��");
			SetAction(11,"̫�_����_��ĸ������");
			SetAction(12,"�컪_����_����յ");
			SetAction(13,"01");
			SetAction(14,"01");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"�����_���_����_������");
			SetAction(19,"�����_���_����_������");
			SetAction(20,"�����_���_����_������");
			SetAction(21,"�����_���_����_������");
			SetAction(22,"�����_���_����_������");
			SetAction(23,"�����_���_����_������");
			SetAction(24,"�����_���_����_������");
			SetAction(25,"����_���_����_��");
			SetAction(26,"����_���_����_��Ӱ�ž�");
			SetAction(27,"��ԯ_���_����_��ؽ�Ǯ");
			SetAction(28,"����_���_����_̰��");
			SetAction(29,"̫�_���_����_��ĸ������");
			SetAction(30,"�컪_���_����_����յ");
			name = "�С��������";
			nativename = "�С��������";
			icon = "�������.dds";
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

			return ((-25 * skill_level) - skill_level * skill_level + 295);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();

			/*
			victim.SetProbability(((2 * skill_level + 25)));
			victim.SetTime(((1000 * skill_level + 8000)));
			victim.SetRatio(6.0f);
			victim.SetBuffid(4);
			victim.SetAmount(6.0f);
			victim.SetValue(((150 * skill_level + 315)));
			victim.SetFiring(true);
			if ( player.GetHasmultbuff(113) == 1 )
			v31 = (5 * skill_level + 10);
			else
			victim.SetProbability(0.0f);
			victim.SetTime(((1000 * skill_level + 3000)));
			victim.SetBuffid(1);
			victim.SetValue(((25 * skill_level + 40)));
			victim.SetSubdefence(true);
			if ( player.GetHasmultbuff(113) != 1
			|| (v21 = zrand(100), v21 >= 5 * skill_level + 15) )
			v30 = 0.0f;
			else
			victim.SetProbability(150.0f);
			victim.SetTime(((1000 * skill_level + 2000)));
			victim.SetRatio(((5 * skill_level + 15) * 0.01f));
			victim.SetBuffid(1);
			victim.SetSlow(true);
			*/
			return true;
		}
	}
	public class GSkill4491 : GSkill
	{
		public GSkill4491()
			: base(4491)
		{
			
		}
	}
	public class GSkill4492Stub : GSkillStub
	{
		public class GState1 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 1450;
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
				return 550;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_level = player.GetLevel();
				int				skill_level = skill.GetLevel();

				skill.SetCrit((skill_level * 0.01f));
				skill.SetCrithurt((skill_level * (skill_level * 0.01f) + (skill_level * 0.05f)));
				skill.SetRatio((D2INT(player_level / (10 - skill_level)) * 0.01f + (skill_level * 0.05f + 1.0f)));
				skill.SetPlus(((120 * skill_level)));
				player.SetPerform(1);
			}
		}
		public GSkill4492Stub()
			: base(4492)
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
			dobless = false;
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
			SetAction(0,"����_����_��");
			SetAction(1,"������_����_�������");
			SetAction(2,"������_����_Ǭ������");
			SetAction(3,"�ϻ���_����_����");
			SetAction(4,"������_����_����Ǭ����");
			SetAction(5,"���_����_ǧ����");
			SetAction(6,"�����_����_������");
			SetAction(7,"����_����_��");
			SetAction(8,"����_����_��Ӱ�ž�");
			SetAction(9,"��ԯ_����_��ؽ�Ǯ");
			SetAction(10,"����_����_̰��");
			SetAction(11,"̫�_����_��ĸ������");
			SetAction(12,"�컪_����_����յ");
			SetAction(13,"01");
			SetAction(14,"01");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"����_���_����_��");
			SetAction(19,"������_���_����_�������");
			SetAction(20,"������_���_����_Ǭ������");
			SetAction(21,"�ϻ���_���_����_����");
			SetAction(22,"������_���_����_����Ǭ����");
			SetAction(23,"���_���_����_ǧ����");
			SetAction(24,"�����_���_����_������");
			SetAction(25,"����_���_����_��");
			SetAction(26,"����_���_����_��Ӱ�ž�");
			SetAction(27,"��ԯ_���_����_��ؽ�Ǯ");
			SetAction(28,"����_���_����_̰��");
			SetAction(29,"̫�_���_����_��ĸ������");
			SetAction(30,"�컪_���_����_����յ");
			name = "�С�������ɱ";
			nativename = "�С�������ɱ";
			icon = "������ɱ.dds";
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

			return ((-25 * skill_level) - skill_level * skill_level + 295);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();

			victim.SetProbability(((14 * skill_level + 20)));
			victim.SetTime(6100.0f);
			victim.SetBuffid(5);
			victim.SetValue(((44 * skill_level)));
			victim.SetSubdefence(true);
			victim.SetTime(6100.0f);
			victim.SetBuffid(3);
			victim.SetValue(((23 * skill_level)));
			victim.SetSubantiweak(true);
			victim.SetTime(((1000 * skill_level + 3100)));
			victim.SetAmount(((2 * norm(skill_level / 4.9f) + (norm(skill_level / 3.9f) + skill_level))));
			victim.SetValue(((25 * skill_level + 12)));
			victim.SetCursed(true);
			return true;
		}
	}
	public class GSkill4492 : GSkill
	{
		public GSkill4492()
			: base(4492)
		{
			
		}
	}
	public class GSkill4493Stub : GSkillStub
	{
		public class GState1 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 1125;
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
				return 875;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_level = player.GetLevel();
				int				skill_level = skill.GetLevel();

				skill.SetRatio((D2INT(player_level / (10 - skill_level)) * 0.01f + (skill_level * 0.05f + 1.0f)));
				skill.SetPlus(((120 * skill_level)));
				player.SetPerform(1);
			}
		}
		public GSkill4493Stub()
			: base(4493)
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
			SetAction(0,"����_����_��Ӱ�ž�");
			SetAction(1,"������_����_�������");
			SetAction(2,"������_����_Ǭ������");
			SetAction(3,"�ϻ���_����_����");
			SetAction(4,"������_����_����Ǭ����");
			SetAction(5,"���_����_ǧ����");
			SetAction(6,"�����_����_������");
			SetAction(7,"����_����_��");
			SetAction(8,"����_����_��Ӱ�ž�");
			SetAction(9,"��ԯ_����_��ؽ�Ǯ");
			SetAction(10,"����_����_̰��");
			SetAction(11,"̫�_����_��ĸ������");
			SetAction(12,"�컪_����_����յ");
			SetAction(13,"01");
			SetAction(14,"01");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"����_���_����_��Ӱ�ž�");
			SetAction(19,"������_���_����_�������");
			SetAction(20,"������_���_����_Ǭ������");
			SetAction(21,"�ϻ���_���_����_����");
			SetAction(22,"������_���_����_����Ǭ����");
			SetAction(23,"���_���_����_ǧ����");
			SetAction(24,"�����_���_����_������");
			SetAction(25,"����_���_����_��");
			SetAction(26,"����_���_����_��Ӱ�ž�");
			SetAction(27,"��ԯ_���_����_��ؽ�Ǯ");
			SetAction(28,"����_���_����_̰��");
			SetAction(29,"̫�_���_����_��ĸ������");
			SetAction(30,"�컪_���_����_����յ");
			name = "�С�������Ӱ";
			nativename = "�С�������Ӱ";
			icon = "������Ӱ.dds";
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

			return ((-25 * skill_level) - skill_level * skill_level + 295);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();

			/*
			victim.SetProbability(((10 * skill_level + 28)));
			victim.SetTime(((30100 - 2000 * skill_level)));
			victim.SetBuffid(4);
			victim.SetAmount(384.0f);
			victim.SetCycsubdefence(true);
			if ( zrand(100) > 6 * skill_level + 12 )
			v27 = 0.0f;
			else
			victim.SetProbability(600.0f);
			victim.SetValue(3.0f);
			victim.SetRepel(true);
			if ( player.GetObjectType() )
			{
			v26 = 0.0f;
			}
			else
			{
			if ( zrand(100) > 6 * skill_level + 12 )
			{
			v25 = 0.0f;
			}
			else
			{
			v25 = (6 * skill_level + (skill_level * skill_level + (2 * (skill_level * skill_level) * skill_level)));
			}
			v26 = v25;
			}
			victim.SetProbability(v26);
			victim.SetTime(((1000 * skill_level + 1100)));
			victim.SetDizzy(true);
			*/
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();

			victim.SetTime(((4000 * skill_level + 12100)));
			victim.SetBuffid(0);
			victim.SetValue(((12 * skill_level)));
			victim.SetAddanti(true);
			return true;
		}
	}
	public class GSkill4493 : GSkill
	{
		public GSkill4493()
			: base(4493)
		{
			
		}
	}
	public class GSkill4494Stub : GSkillStub
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
				int				player_level = player.GetLevel();
				int				skill_level = skill.GetLevel();

				skill.SetRatio((D2INT(player_level / (10 - skill_level)) * 0.01f + (skill_level * 0.05f + 1.0f)));
				skill.SetPlus(((120 * skill_level)));
				player.SetPerform(1);
			}
		}
		public GSkill4494Stub()
			: base(4494)
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
			dobless = false;
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
			SetAction(0,"����_����_̰��");
			SetAction(1,"������_����_�������");
			SetAction(2,"������_����_Ǭ������");
			SetAction(3,"�ϻ���_����_����");
			SetAction(4,"������_����_����Ǭ����");
			SetAction(5,"���_����_ǧ����");
			SetAction(6,"�����_����_������");
			SetAction(7,"����_����_��");
			SetAction(8,"����_����_��Ӱ�ž�");
			SetAction(9,"��ԯ_����_��ؽ�Ǯ");
			SetAction(10,"����_����_̰��");
			SetAction(11,"̫�_����_��ĸ������");
			SetAction(12,"�컪_����_����յ");
			SetAction(13,"01");
			SetAction(14,"01");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"����_���_����_̰��");
			SetAction(19,"������_����_�������");
			SetAction(20,"������_����_Ǭ������");
			SetAction(21,"�ϻ���_����_����");
			SetAction(22,"������_����_����Ǭ����");
			SetAction(23,"���_����_ǧ����");
			SetAction(24,"�����_����_������");
			SetAction(25,"����_����_��");
			SetAction(26,"����_����_��Ӱ�ž�");
			SetAction(27,"��ԯ_����_��ؽ�Ǯ");
			SetAction(28,"����_���_����_̰��");
			SetAction(29,"̫�_����_��ĸ������");
			SetAction(30,"�컪_����_����յ");
			name = "�С��ƻ�ǧ��";
			nativename = "�С��ƻ�ǧ��";
			icon = "�ƻ�ǧ��.dds";
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

			return ((-25 * skill_level) - skill_level * skill_level + 295);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_res1 = player.GetRes1();
			int				player_res2 = player.GetRes2();
			int				player_res3 = player.GetRes3();
			int				player_res4 = player.GetRes4();
			int				player_res5 = player.GetRes5();
			int				skill_level = skill.GetLevel();

			victim.SetTime(12000.0f);
			victim.SetBuffid(0);
			victim.SetValue(((20 * skill_level)));
			victim.SetSubantisilent(true);
			victim.SetProbability((((player_res5 + (player_res4 + (player_res3 + (player_res2 + player_res1)))) / 5)));
			victim.SetTime(((1000 * skill_level + 1000)));
			victim.SetSilent(true);
			return true;
		}
	}
	public class GSkill4494 : GSkill
	{
		public GSkill4494()
			: base(4494)
		{
			
		}
	}
	public class GSkill4495Stub : GSkillStub
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
		}
		public class GState2 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 300;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_level = player.GetLevel();
				int				player_maxatk = player.GetMaxatk();
				int				player_res2 = player.GetRes2();
				int				skill_level = skill.GetLevel();

				player.SetVar1(player_res2);
				player.SetVar2(player_maxatk);
				player.SetVar3(1);
				skill.SetRatio((D2INT(player_level / (10 - skill_level)) * 0.01f + (skill_level * 0.02f + 1.0f)));
				skill.SetPlus(((50 * skill_level)));
				player.SetPerform(1);
			}
		}
		public class GState3 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 475;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_level = player.GetLevel();
				int				player_maxatk = player.GetMaxatk();
				int				player_res2 = player.GetRes2();
				int				skill_level = skill.GetLevel();

				player.SetVar1(player_res2);
				player.SetVar2(player_maxatk);
				player.SetVar3(0);
				skill.SetRatio((D2INT(player_level / (10 - skill_level)) * 0.01f + (skill_level * 0.02f + 1.0f)));
				skill.SetPlus(((50 * skill_level)));
				player.SetPerform(0);
			}
		}
		public GSkill4495Stub()
			: base(4495)
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
			SetAction(0,"�컪_����_����յ");
			SetAction(1,"������_����_�������");
			SetAction(2,"������_����_Ǭ������");
			SetAction(3,"�ϻ���_����_����");
			SetAction(4,"������_����_����Ǭ����");
			SetAction(5,"���_����_ǧ����");
			SetAction(6,"�����_����_������");
			SetAction(7,"����_����_��");
			SetAction(8,"����_����_��Ӱ�ž�");
			SetAction(9,"��ԯ_����_��ؽ�Ǯ");
			SetAction(10,"����_����_̰��");
			SetAction(11,"̫�_����_��ĸ������");
			SetAction(12,"�컪_����_����յ");
			SetAction(13,"01");
			SetAction(14,"01");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"�컪_���_����_����յ");
			SetAction(19,"������_���_����_�������");
			SetAction(20,"������_���_����_Ǭ������");
			SetAction(21,"�ϻ���_���_����_����");
			SetAction(22,"������_���_����_����Ǭ����");
			SetAction(23,"���_���_����_ǧ����");
			SetAction(24,"�����_���_����_������");
			SetAction(25,"����_���_����_��");
			SetAction(26,"����_���_����_��Ӱ�ž�");
			SetAction(27,"��ԯ_���_����_��ؽ�Ǯ");
			SetAction(28,"����_���_����_̰��");
			SetAction(29,"̫�_���_����_��ĸ������");
			SetAction(30,"�컪_���_����_����յ");
			name = "�С��������";
			nativename = "�С��������";
			icon = "�������.dds";
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
			AddState(new GState3());
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
		public override float GetRadius(GSkill skill)
		{
			return 2.000000f/*xxxx*/;
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

			return ((-25 * skill_level) - skill_level * skill_level + 295);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_level = player.GetLevel();
			int				player_def = player.GetDef();
			int				player_var1 = player.GetVar1();
			int				player_var2 = player.GetVar2();
			int				player_var3 = player.GetVar3();
			int				skill_level = skill.GetLevel();

			/*
			victim.SetTime(((500 * skill_level + 5000)));
			victim.SetBuffid(1);
			victim.SetValue(((21 * skill_level)));
			victim.SetSubantiweak(true);
			victim.SetProbability(player_var1);
			victim.SetTime(((500 * skill_level + 5000)));
			victim.SetRatio((skill_level * 0.05f + 0.05f));
			victim.SetBuffid(1);
			victim.SetWeak(true);
			v44 = player_var3;
			if ( D2INT(zrand(100)) >= skill_level + 2 )
			v43 = 0.0f;
			else
			victim.SetProbability(((100 * v44)));
			if ( ((50 * skill_level) + ((D2INT(player_level / (10 - skill_level)) * 0.01f + (skill_level * 0.03f + 1.0f)) * player_var2)) <= player_def )
			{
			v42 = 0.0f;
			}
			else
			{
			v42 = ((50 * skill_level) + ((D2INT(player_level / (10 - skill_level)) * 0.01f + (skill_level * 0.03f + 1.0f)) * player_var2)) - player_def;
			}
			victim.SetValue(v42);
			victim.SetDirecthurt(true);
			*/
			return true;
		}
	}
	public class GSkill4495 : GSkill
	{
		public GSkill4495()
			: base(4495)
		{
			
		}
	}
	public class GSkill4496Stub : GSkillStub
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
				int				skill_level = skill.GetLevel();

				skill.SetCrit((skill_level * 0.02f));
				skill.SetRatio((D2INT(player_level / (10 - skill_level)) * 0.01f + (skill_level * 0.05f + 1.0f)));
				skill.SetPlus(((120 * skill_level)));
				player.SetPerform(1);
			}
		}
		public GSkill4496Stub()
			: base(4496)
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
			SetAction(0,"̫�_����_��ĸ������");
			SetAction(1,"������_����_�������");
			SetAction(2,"������_����_Ǭ������");
			SetAction(3,"�ϻ���_����_����");
			SetAction(4,"������_����_����Ǭ����");
			SetAction(5,"���_����_ǧ����");
			SetAction(6,"�����_����_������");
			SetAction(7,"����_����_��");
			SetAction(8,"����_����_��Ӱ�ž�");
			SetAction(9,"��ԯ_����_��ؽ�Ǯ");
			SetAction(10,"����_����_̰��");
			SetAction(11,"̫�_����_��ĸ������");
			SetAction(12,"�컪_����_����յ");
			SetAction(13,"01");
			SetAction(14,"01");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"̫�_���_����_��ĸ������");
			SetAction(19,"������_���_����_�������");
			SetAction(20,"������_���_����_Ǭ������");
			SetAction(21,"�ϻ���_���_����_����");
			SetAction(22,"������_���_����_����Ǭ����");
			SetAction(23,"���_���_����_ǧ����");
			SetAction(24,"�����_���_����_������");
			SetAction(25,"����_���_����_��");
			SetAction(26,"����_���_����_��Ӱ�ž�");
			SetAction(27,"��ԯ_���_����_��ؽ�Ǯ");
			SetAction(28,"����_���_����_̰��");
			SetAction(29,"̫�_���_����_��ĸ������");
			SetAction(30,"�컪_���_����_����յ");
			name = "�С������Ļ�";
			nativename = "�С������Ļ�";
			icon = "�����Ļ�.dds";
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

			return ((-25 * skill_level) - skill_level * skill_level + 295);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_res1 = player.GetRes1();
			int				skill_level = skill.GetLevel();

			/*
			v20 = 6 * skill_level + 10;
			if ( skill_level == 5 )
			{
			v19 = (v20 + player_res1);
			}
			else
			{
			v19 = v20;
			}
			victim.SetProbability(v19);
			victim.SetTime(((1000 * skill_level)));
			victim.SetDizzy(true);
			if ( player.GetHasbuff(4096) == 1 )
			v18 = (10 * skill_level + 10);
			else
			victim.SetProbability(0.0f);
			victim.SetTime(((1000 * skill_level + 4000)));
			victim.SetRatio((skill_level * 0.1f));
			victim.SetValue((skill_level * 0.1f));
			victim.SetParalysis(true);
			*/
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();

			victim.SetTime(((4000 * skill_level + 12100)));
			victim.SetBuffid(0);
			victim.SetValue(((12 * skill_level)));
			victim.SetAddanti(true);
			return true;
		}
	}
	public class GSkill4496 : GSkill
	{
		public GSkill4496()
			: base(4496)
		{
			
		}
	}
	public class GSkill4497Stub : GSkillStub
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
				int				player_level = player.GetLevel();
				int				skill_level = skill.GetLevel();

				skill.SetRatio((D2INT(player_level / (10 - skill_level)) * 0.01f + (skill_level * 0.05f + 1.0f)));
				skill.SetPlus(((120 * skill_level)));
				player.SetPerform(1);
			}
		}
		public GSkill4497Stub()
			: base(4497)
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
			SetAction(0,"��ԯ_����_��ؽ�Ǯ");
			SetAction(1,"������_����_�������");
			SetAction(2,"������_����_Ǭ������");
			SetAction(3,"�ϻ���_����_����");
			SetAction(4,"������_����_����Ǭ����");
			SetAction(5,"���_����_ǧ����");
			SetAction(6,"�����_����_������");
			SetAction(7,"����_����_��");
			SetAction(8,"����_����_��Ӱ�ž�");
			SetAction(9,"��ԯ_����_��ؽ�Ǯ");
			SetAction(10,"����_����_̰��");
			SetAction(11,"̫�_����_��ĸ������");
			SetAction(12,"�컪_����_����յ");
			SetAction(13,"1");
			SetAction(14,"1");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"��ԯ_���_����_��ؽ�Ǯ");
			SetAction(19,"������_���_����_�������");
			SetAction(20,"������_���_����_Ǭ������");
			SetAction(21,"�ϻ���_���_����_����");
			SetAction(22,"������_���_����_����Ǭ����");
			SetAction(23,"���_���_����_ǧ����");
			SetAction(24,"�����_���_����_������");
			SetAction(25,"����_���_����_��");
			SetAction(26,"����_���_����_��Ӱ�ž�");
			SetAction(27,"��ԯ_���_����_��ؽ�Ǯ");
			SetAction(28,"����_���_����_̰��");
			SetAction(29,"̫�_���_����_��ĸ������");
			SetAction(30,"�컪_���_����_����յ");
			name = "�С�Ǭ��һ��";
			nativename = "�С�Ǭ��һ��";
			icon = "аħ��ɢ.dds";
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

			return ((-25 * skill_level) - skill_level * skill_level + 295);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();

			/*
			victim.SetProbability(((30 * skill_level + 88)));
			victim.SetTime(((2000 * skill_level + 5000)));
			victim.SetRatio(0.15000001f);
			victim.SetBuffid(1);
			victim.SetWeak(true);
			victim.SetProbability(((skill_level + 2)));
			victim.SetTime(((2000 * skill_level + 5000)));
			victim.SetRatio(((5 * skill_level + 5) * 0.01f));
			victim.SetBuffid(1);
			victim.SetDecdefence(true);
			victim.SetProbability(600.0f);
			if ( zrand(100) >= skill_level + 2 )
			t = 0.0f;
			else
			victim.SetTime(5000.0f);
			victim.SetDizzy(true);
			*/
			return true;
		}
	}
	public class GSkill4497 : GSkill
	{
		public GSkill4497()
			: base(4497)
		{
			
		}
	}
	public class GSkill4498Stub : GSkillStub
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
				int				player_level = player.GetLevel();
				int				player_mp = player.GetMp();
				int				player_maxmp = player.GetMaxmp();
				int				player_def = player.GetDef();
				int				player_occupation = player.GetOccupation();
				int				skill_level = skill.GetLevel();
				int				skill_t0 = skill.GetT0();
				int				skill_t1 = skill.GetT1();
				int				skill_t2 = skill.GetT2();

				player.SetVar11(player_occupation);
				skill.SetCrit((skill_t1 * 0.01f));
				skill.SetRatio(((skill_t0 + 1) * (D2INT((player_mp / 0.95f) / player_maxmp) * 0.16f) + (D2INT(player_level / (9 - skill_level)) * 0.01f + (skill_t0 * 0.08f + (skill_level * 0.06f + 1.0f)))));
				skill.SetPlus((player_def * (skill_t2 * 0.03f) + ((215 * skill_level))));
				player.SetPerform(1);
			}
		}
		public GSkill4498Stub()
			: base(4498)
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
			SetAction(0,"������_����_Ǭ����");
			SetAction(1,"������_����_Ǭ����");
			SetAction(2,"������_����_Ǭ����");
			SetAction(3,"������_����_Ǭ����");
			SetAction(4,"������_����_Ǭ����");
			SetAction(5,"������_����_Ǭ����");
			SetAction(6,"������_����_Ǭ����");
			SetAction(7,"����_����_ɥ�Ž�");
			SetAction(8,"����_����_����");
			SetAction(9,"��ԯ_����_��Ӱ");
			SetAction(10,"����_����_��Ӱ");
			SetAction(11,"̫�_����_�˻���");
			SetAction(12,"�컪_����_����ɺ�");
			SetAction(13,"1");
			SetAction(14,"1");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"������_���_����_Ǭ����");
			SetAction(19,"������_���_����_Ǭ����");
			SetAction(20,"������_���_����_Ǭ����");
			SetAction(21,"������_���_����_Ǭ����");
			SetAction(22,"������_���_����_Ǭ����");
			SetAction(23,"������_���_����_Ǭ����");
			SetAction(24,"������_���_����_Ǭ����");
			SetAction(25,"����_���_����_ɥ�Ž�");
			SetAction(26,"����_���_����_����");
			SetAction(27,"��ԯ_���_����_��Ӱ");
			SetAction(28,"����_���_����_��Ӱ");
			SetAction(29,"̫�_���_����_�˻���");
			SetAction(30,"�컪_���_����_����ɺ�");
			name = "�С�����̾��";
			nativename = "�С�����̾��";
			icon = "����̾��.dds";
			SetTalent(0,568);
			SetTalent(1,599);
			SetTalent(2,1582);
			SetTalent(3,0);
			SetTalent(4,0);
			SetTalent(5,0);
			SetTalent(6,0);
			SetTalent(7,0);
			talent_size = 3;
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
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_hp = player.GetHp();
			int				player_maxhp = player.GetMaxhp();
			int				player_mp = player.GetMp();
			int				player_maxmp = player.GetMaxmp();
			int				player_var1 = player.GetVar1();
			int				player_var11 = player.GetVar11();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();

			/*
			victim.SetProbability(((skill_level * skill_level + (3 * skill_t0) + 32)));
			victim.SetTime(((5000 * skill_level + 100)));
			victim.SetRatio((skill_t0 * 0.05f + (skill_level * 0.05f)));
			victim.SetBuffid(1);
			victim.SetDecaccuracy(true);
			if ( skill_level * (player_maxhp * 0.15f) <= player_hp )
			{
			v53 = 0.0f;
			}
			else
			{
			if ( player_var11 == 20 )
			{
			v52 = (skill_level * skill_level + 32);
			}
			else
			{
			v52 = (skill_level * skill_level + 12);
			}
			v53 = v52;
			}
			victim.SetProbability(v53);
			victim.SetTime(((2000 * skill_level + 2100)));
			victim.SetRatio((skill_level * (skill_level * 0.01f) + (skill_t0 * 0.05f + 0.2f)));
			victim.SetValue((skill_level * (skill_level * 0.01f) + (skill_t0 * 0.05f + 0.2f)));
			victim.SetRandcurse(true);
			victim.SetProbability(((skill_level * skill_level + (5 * skill_t0) + 32)));
			victim.SetTime(((2000 * skill_level + 2100)));
			victim.SetBuffid(0);
			victim.SetValue((((norm((player_maxmp * (skill_level * 0.15f)) / (player_mp + 1.0f)) + 1) * ((skill_level * skill_level) * skill_level + (40 * skill_level)))));
			victim.SetSubdefence(true);
			*/
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_mp = player.GetMp();
			int				player_maxmp = player.GetMaxmp();

			victim.SetBuffid((D2INT((player_mp / 0.95f) / player_maxmp)));
			victim.SetUniqprompt(true);
			return true;
		}
	}
	public class GSkill4498 : GSkill
	{
		public GSkill4498()
			: base(4498)
		{
			
		}
	}
	public class GSkill4499Stub : GSkillStub
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
				int				player_level = player.GetLevel();
				int				player_def = player.GetDef();
				int				player_occupation = player.GetOccupation();
				int				skill_level = skill.GetLevel();
				int				skill_t0 = skill.GetT0();
				int				skill_t1 = skill.GetT1();

				player.SetVar11(player_occupation);
				skill.SetCrit((skill_level * 0.01f));
				skill.SetCrithurt((skill_level * (skill_level * 0.01f) + (skill_level * 0.1f)));
				skill.SetRatio((D2INT(player_level / (9 - skill_level)) * 0.01f + (skill_level * 0.06f + (skill_t0 * 0.1f + 1.0f))));
				skill.SetPlus((player_def * (skill_t1 * 0.03f) + ((215 * skill_level))));
				player.SetPerform(1);
			}
		}
		public GSkill4499Stub()
			: base(4499)
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
			dobless = false;
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
			SetAction(0,"������_����_��ڤ����");
			SetAction(1,"������_����_��ڤ����");
			SetAction(2,"������_����_��ڤ����");
			SetAction(3,"������_����_��ڤ����");
			SetAction(4,"������_����_��ڤ����");
			SetAction(5,"������_����_��ڤ����");
			SetAction(6,"������_����_��ڤ����");
			SetAction(7,"����_����_ɥ�Ž�");
			SetAction(8,"����_����_����");
			SetAction(9,"��ԯ_����_��Ӱ");
			SetAction(10,"����_����_��Ӱ");
			SetAction(11,"̫�_����_�˻���");
			SetAction(12,"�컪_����_����ɺ�");
			SetAction(13,"1");
			SetAction(14,"1");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"������_���_����_��ڤ����");
			SetAction(19,"������_���_����_��ڤ����");
			SetAction(20,"������_���_����_��ڤ����");
			SetAction(21,"������_���_����_��ڤ����");
			SetAction(22,"������_���_����_��ڤ����");
			SetAction(23,"������_���_����_��ڤ����");
			SetAction(24,"������_���_����_��ڤ����");
			SetAction(25,"����_���_����_ɥ�Ž�");
			SetAction(26,"����_���_����_����");
			SetAction(27,"��ԯ_���_����_��Ӱ");
			SetAction(28,"����_���_����_��Ӱ");
			SetAction(29,"̫�_���_����_�˻���");
			SetAction(30,"�컪_���_����_����ɺ�");
			name = "�С������ĸ�";
			nativename = "�С������ĸ�";
			icon = "�����ĸ�.dds";
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
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_var1 = player.GetVar1();
			int				player_var11 = player.GetVar11();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();

			/*
			victim.SetTime(((4000 * skill_level + 4100)));
			victim.SetBuffid(0);
			victim.SetValue(((skill_level * skill_level + (12 * (skill_t0 + skill_level)))));
			victim.SetSubantidizzy(true);
			victim.SetTime(((4000 * skill_level + 4100)));
			victim.SetBuffid(0);
			victim.SetValue(((skill_level * skill_level + (12 * (skill_t0 + skill_level)))));
			victim.SetSubantiweak(true);
			victim.SetProbability(((3 * skill_t0 + 30)));
			victim.SetTime(12100.0f);
			victim.SetRatio(((skill_t0 * 0.5f + 1.0f) * 0.11f));
			victim.SetBuffid(3);
			victim.SetTiansha(true);
			if ( player_var11 == 14 )
			{
			v35 = (skill_level * skill_level + 5);
			}
			else
			{
			v35 = (skill_level * skill_level + 1);
			}
			victim.SetProbability(v35);
			victim.SetAmount(2.0f);
			victim.SetClearbuff(true);
			*/
			return true;
		}
	}
	public class GSkill4499 : GSkill
	{
		public GSkill4499()
			: base(4499)
		{
			
		}
	}
}
