using System;
using System.Text;

namespace SKILL
{
	public class GSkill560Stub : GSkillStub
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
				int				skill_level = skill.GetLevel();
				int				skill_t0 = skill.GetT0();
				int				skill_t1 = skill.GetT1();

				skill.SetRatio((D2INT(player_level / (10 - skill_level)) * 0.01f + (skill_level * 0.05f + (skill_t0 * 0.1f + 1.0f))));
				skill.SetPlus((player_def * (skill_t1 * 0.03f) + ((120 * skill_level))));
				player.SetPerform(1);
			}
		}
		public GSkill560Stub()
			: base(560)
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
			SetAction(0,"������_����_Ǭ������");
			SetAction(1,"������_����_Ǭ������");
			SetAction(2,"������_����_Ǭ������");
			SetAction(3,"�ϻ���_����_Ǭ������");
			SetAction(4,"������_����_Ǭ������");
			SetAction(5,"���_����_Ǭ������");
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
			SetAction(18,"������_���_����_Ǭ������");
			SetAction(19,"������_���_����_Ǭ������");
			SetAction(20,"������_���_����_Ǭ������");
			SetAction(21,"�ϻ���_���_����_Ǭ������");
			SetAction(22,"������_���_����_Ǭ������");
			SetAction(23,"���_���_����_Ǭ������");
			SetAction(24,"");
			SetAction(25,"");
			SetAction(26,"");
			SetAction(27,"");
			SetAction(28,"");
			SetAction(29,"");
			SetAction(30,"");
			name = "���է��";
			nativename = "���է��";
			icon = "���է��.dds";
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

			return ((-25 * skill_level) - skill_level * skill_level + 295);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();

			victim.SetProbability(((3 * skill_t0 + 25)));
			victim.SetTime(10100.0f);
			victim.SetRatio(((skill_t0 * 0.5f + 1.0f) * 0.09f));
			victim.SetBuffid(3);
			victim.SetTiansha(true);
			victim.SetProbability(((40 * skill_level + 75)));
			victim.SetTime(((1000 * skill_t0 + (2000 * skill_level) + 4100)));
			victim.SetSilent(true);
			victim.SetProbability(-1.0f);
			victim.SetTime(8000.0f);
			victim.SetBuffid(1);
			victim.SetAmount(((80 * skill_t0 + (240 * skill_level))));
			victim.SetValue(0.0f);
			victim.SetHpleak(true);
			return true;
		}
	}
	public class GSkill560 : GSkill
	{
		public GSkill560()
			: base(560)
		{
			
		}
	}
	public class GSkill561Stub : GSkillStub
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
				int				skill_level = skill.GetLevel();
				int				skill_t0 = skill.GetT0();
				int				skill_t1 = skill.GetT1();

				skill.SetCrit((skill_level * 0.03f));
				skill.SetRatio((D2INT(player_level / (9 - skill_level)) * 0.01f + (skill_level * 0.05f + (skill_t0 * 0.03f + 1.0f))));
				skill.SetPlus((player_def * (skill_t1 * 0.03f) + ((3 * player_level * skill_level + (215 * skill_level)))));
				player.SetPerform(1);
			}
		}
		public GSkill561Stub()
			: base(561)
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
			SetAction(0,"���_����_������");
			SetAction(1,"������_����_������");
			SetAction(2,"������_����_������");
			SetAction(3,"�ϻ���_����_������");
			SetAction(4,"������_����_������");
			SetAction(5,"���_����_������");
			SetAction(6,"�����_����_������");
			SetAction(7,"����_����_������");
			SetAction(8,"����_����_������");
			SetAction(9,"��ԯ_����_������");
			SetAction(10,"����_����_������");
			SetAction(11,"̫�_����_������");
			SetAction(12,"�컪_����_������");
			SetAction(13,"����_����_������");
			SetAction(14,"Ӣ��_����_������");
			SetAction(15,"������ʦ_����_������");
			SetAction(16,"������ʦ_����_������");
			SetAction(17,"������_����_������");
			SetAction(18,"���_���_����_������");
			SetAction(19,"������_���_����_������");
			SetAction(20,"������_���_����_������");
			SetAction(21,"�ϻ���_���_����_������");
			SetAction(22,"������_���_����_������");
			SetAction(23,"���_���_����_������");
			SetAction(24,"�����_���_����_������");
			SetAction(25,"����_���_����_������");
			SetAction(26,"����_���_����_������");
			SetAction(27,"��ԯ_���_����_������");
			SetAction(28,"����_���_����_������");
			SetAction(29,"̫�_���_����_������");
			SetAction(30,"�컪_���_����_������");
			name = "��������";
			nativename = "��������";
			icon = "��������.dds";
			SetTalent(0,687);
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

			return ((-35 * skill_level) - skill_level * skill_level + 445);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();

			victim.SetProbability(((5 * skill_level)));
			victim.SetTime((((2000 * skill_level + 4000) * (D2INT((zrand(6 * skill_level + 99)) / 100) + 1) + 100)));
			victim.SetRatio((skill_level * 0.02f + 0.2f));
			victim.SetValue((skill_level * 0.02f + 0.2f));
			victim.SetRandcurse(true);
			victim.SetProbability(33.0f);
			victim.SetTime(((4000 * skill_level + 8000)));
			victim.SetBuffid(1);
			victim.SetAmount(((16 * skill_level * skill_level + (60 * skill_level))));
			victim.SetCycsubattack(true);
			return true;
		}
	}
	public class GSkill561 : GSkill
	{
		public GSkill561()
			: base(561)
		{
			
		}
	}
	public class GSkill562Stub : GSkillStub
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
				int				skill_level = skill.GetLevel();
				int				skill_t0 = skill.GetT0();
				int				skill_t1 = skill.GetT1();

				skill.SetRatio((D2INT(player_level / (10 - skill_level)) * 0.01f + (skill_level * 0.05f + (skill_t0 * 0.03f + 1.0f))));
				skill.SetPlus((player_def * (skill_t1 * 0.03f) + ((120 * skill_level))));
				player.SetPerform(1);
			}
		}
		public GSkill562Stub()
			: base(562)
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
			SetAction(0,"���_����_���������");
			SetAction(1,"������_����_���������");
			SetAction(2,"������_����_���������");
			SetAction(3,"�ϻ���_����_���������");
			SetAction(4,"������_����_���������");
			SetAction(5,"���_����_���������");
			SetAction(6,"�����_����_���������");
			SetAction(7,"����_����_���������");
			SetAction(8,"����_����_���������");
			SetAction(9,"��ԯ_����_���������");
			SetAction(10,"����_����_���������");
			SetAction(11,"̫�_����_���������");
			SetAction(12,"�컪_����_���������");
			SetAction(13,"����_����_���������");
			SetAction(14,"Ӣ��_����_���������");
			SetAction(15,"������ʦ_����_���������");
			SetAction(16,"������ʦ_����_���������");
			SetAction(17,"������_����_���������");
			SetAction(18,"���_���_����_���������");
			SetAction(19,"������_���_����_���������");
			SetAction(20,"������_���_����_���������");
			SetAction(21,"�ϻ���_���_����_���������");
			SetAction(22,"������_���_����_���������");
			SetAction(23,"���_���_����_���������");
			SetAction(24,"�����_���_����_���������");
			SetAction(25,"����_���_����_���������");
			SetAction(26,"����_���_����_���������");
			SetAction(27,"��ԯ_���_����_���������");
			SetAction(28,"����_���_����_���������");
			SetAction(29,"̫�_���_����_���������");
			SetAction(30,"�컪_���_����_���������");
			name = "�������";
			nativename = "�������";
			icon = "�������.dds";
			SetTalent(0,687);
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

			return ((-25 * skill_level) - skill_level * skill_level + 295);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_level = player.GetLevel();
			int				skill_level = skill.GetLevel();

			victim.SetProbability(100.0f);
			victim.SetTime(((2000 * skill_level + 4100)));
			victim.SetBuffid(1);
			victim.SetValue(((24 * skill_level)));
			victim.SetSubdefence(true);
			victim.SetProbability(((1.0f - player_level * 0.002f) * 100.0f));
			victim.SetTime(4000.0f);
			victim.SetBuffid(1);
			victim.SetAmount(((32 * skill_level)));
			victim.SetValue(((320 * skill_level)));
			victim.SetHpleak(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();

			victim.SetProbability(((6 * skill_level + 6)));
			victim.SetTime(((1000 * skill_level + 12100)));
			victim.SetRatio(1.0f);
			victim.SetAmount(((skill_level + 2)));
			victim.SetValue(((3 * skill_level * skill_level + (15 * skill_level))));
			victim.SetBloodshield(true);
			return true;
		}
	}
	public class GSkill562 : GSkill
	{
		public GSkill562()
			: base(562)
		{
			
		}
	}
	public class GSkill563Stub : GSkillStub
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
				int				skill_level = skill.GetLevel();
				int				skill_t0 = skill.GetT0();
				int				skill_t1 = skill.GetT1();

				skill.SetRatio((D2INT(player_level / (10 - skill_level)) * 0.01f + (skill_level * 0.05f + (skill_t0 * 0.1f + 1.0f))));
				skill.SetPlus((player_def * (skill_t1 * 0.03f) + ((120 * skill_level))));
				player.SetPerform(1);
			}
		}
		public GSkill563Stub()
			: base(563)
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
			SetAction(0,"������_����_����Ǭ����");
			SetAction(1,"������_����_����Ǭ����");
			SetAction(2,"������_����_����Ǭ����");
			SetAction(3,"�ϻ���_����_����Ǭ����");
			SetAction(4,"������_����_����Ǭ����");
			SetAction(5,"���_����_����Ǭ����");
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
			SetAction(18,"������_���_����_����Ǭ����");
			SetAction(19,"������_���_����_����Ǭ����");
			SetAction(20,"������_���_����_����Ǭ����");
			SetAction(21,"�ϻ���_���_����_����Ǭ����");
			SetAction(22,"������_���_����_����Ǭ����");
			SetAction(23,"���_���_����_����Ǭ����");
			SetAction(24,"");
			SetAction(25,"");
			SetAction(26,"");
			SetAction(27,"");
			SetAction(28,"");
			SetAction(29,"");
			SetAction(30,"");
			name = "Ǭ������";
			nativename = "Ǭ������";
			icon = "Ǭ������.dds";
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
		public override float GetRadius(GSkill skill)
		{
			return 15.000000f;
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
		public override int GetCoverage(GSkill skill)
		{
			return 1;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();

			victim.SetProbability(100.0f);
			victim.SetTime(((1000 * skill_t0 + (3000 * skill_level) + 100)));
			victim.SetBuffid(1);
			victim.SetValue(((15 * skill_t0 + (25 * skill_level))));
			victim.SetSubattack(true);
			victim.SetProbability(((600 * norm(zrand(100) / (96 - skill_level)))));
			victim.SetTime(((2000 * skill_level + 3100)));
			victim.SetDizzy(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();

			victim.SetValue(((24 * (skill_t0 + 1) * skill_level)));
			victim.SetJuqi(true);
			return true;
		}
	}
	public class GSkill563 : GSkill
	{
		public GSkill563()
			: base(563)
		{
			
		}
	}
	public class GSkill564Stub : GSkillStub
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
				int				skill_level = skill.GetLevel();
				int				skill_t0 = skill.GetT0();
				int				skill_t1 = skill.GetT1();

				skill.SetRatio((D2INT(player_level / (9 - skill_level)) * 0.01f + (skill_level * 0.07000000000000001f + (skill_t0 * 0.03f + 1.0f))));
				skill.SetPlus((player_def * (skill_t1 * 0.03f) + ((skill_level * (D2INT((zrand(4 * skill_level + 99)) / 100.0f) * 0.8f) + 1.0f) * ((250 * skill_level)))));
				player.SetPerform(1);
			}
		}
		public GSkill564Stub()
			: base(564)
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
			SetAction(0,"���_����_���");
			SetAction(1,"������_����_���");
			SetAction(2,"������_����_���");
			SetAction(3,"�ϻ���_����_���");
			SetAction(4,"������_����_���");
			SetAction(5,"���_����_���");
			SetAction(6,"�����_����_���");
			SetAction(7,"����_����_���");
			SetAction(8,"����_����_���");
			SetAction(9,"��ԯ_����_���");
			SetAction(10,"����_����_���");
			SetAction(11,"̫�_����_���");
			SetAction(12,"�컪_����_���");
			SetAction(13,"����_����_���");
			SetAction(14,"Ӣ��_����_���");
			SetAction(15,"������ʦ_����_���");
			SetAction(16,"������ʦ_����_���");
			SetAction(17,"������_����_���");
			SetAction(18,"���_���_����_���");
			SetAction(19,"������_���_����_���");
			SetAction(20,"������_���_����_���");
			SetAction(21,"�ϻ���_���_����_���");
			SetAction(22,"������_���_����_���");
			SetAction(23,"���_���_����_���");
			SetAction(24,"�����_���_����_���");
			SetAction(25,"����_���_����_���");
			SetAction(26,"����_���_����_���");
			SetAction(27,"��ԯ_���_����_���");
			SetAction(28,"����_���_����_���");
			SetAction(29,"̫�_���_����_���");
			SetAction(30,"�컪_���_����_���");
			name = "�����ĳ�";
			nativename = "�����ĳ�";
			icon = "�����ĳ�.dds";
			SetTalent(0,687);
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

			return ((-35 * skill_level) - skill_level * skill_level + 555);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();

			victim.SetProbability(((600 * norm(zrand(100) / (100 - 4 * skill_level)))));
			victim.SetTime(((5000 * skill_level + 100)));
			victim.SetDizzy(true);
			victim.SetProbability(((5 * skill_level + 25)));
			victim.SetTime(((4000 * skill_level + 100)));
			victim.SetBuffid(1);
			victim.SetValue(((30 * skill_level)));
			victim.SetSubattack(true);
			victim.SetProbability(((5 * skill_t0 + 50)));
			victim.SetTime(16100.0f);
			victim.SetRatio((skill_level * 0.01001f));
			victim.SetBuffid(1);
			victim.SetDeccritrate(true);
			return true;
		}
	}
	public class GSkill564 : GSkill
	{
		public GSkill564()
			: base(564)
		{
			
		}
	}
	public class GSkill565Stub : GSkillStub
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
				int				skill_level = skill.GetLevel();
				int				skill_t0 = skill.GetT0();
				int				skill_t1 = skill.GetT1();

				skill.SetRatio((D2INT(player_level / (9 - skill_level)) * 0.01f + (skill_level * 0.07000000000000001f + (skill_t0 * 0.03f + 1.0f))));
				skill.SetPlus((player_def * (skill_t1 * 0.03f) + ((250 * skill_level))));
				player.SetPerform(1);
			}
		}
		public GSkill565Stub()
			: base(565)
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
			SetAction(0,"���_����_��Ѫ��");
			SetAction(1,"������_����_��Ѫ��");
			SetAction(2,"������_����_��Ѫ��");
			SetAction(3,"�ϻ���_����_��Ѫ��");
			SetAction(4,"������_����_��Ѫ��");
			SetAction(5,"���_����_��Ѫ��");
			SetAction(6,"�����_����_��Ѫ��");
			SetAction(7,"����_����_��Ѫ��");
			SetAction(8,"����_����_��Ѫ��");
			SetAction(9,"��ԯ_����_��Ѫ��");
			SetAction(10,"����_����_��Ѫ��");
			SetAction(11,"̫�_����_��Ѫ��");
			SetAction(12,"�컪_����_��Ѫ��");
			SetAction(13,"����_����_��Ѫ��");
			SetAction(14,"Ӣ��_����_��Ѫ��");
			SetAction(15,"������ʦ_����_��Ѫ��");
			SetAction(16,"������ʦ_����_��Ѫ��");
			SetAction(17,"������_����_��Ѫ��");
			SetAction(18,"���_���_����_��Ѫ��");
			SetAction(19,"������_���_����_��Ѫ��");
			SetAction(20,"������_���_����_��Ѫ��");
			SetAction(21,"�ϻ���_���_����_��Ѫ��");
			SetAction(22,"������_���_����_��Ѫ��");
			SetAction(23,"���_���_����_��Ѫ��");
			SetAction(24,"�����_���_����_��Ѫ��");
			SetAction(25,"����_���_����_��Ѫ��");
			SetAction(26,"����_���_����_��Ѫ��");
			SetAction(27,"��ԯ_���_����_��Ѫ��");
			SetAction(28,"����_���_����_��Ѫ��");
			SetAction(29,"̫�_���_����_��Ѫ��");
			SetAction(30,"�컪_���_����_��Ѫ��");
			name = "��Ѫа��";
			nativename = "��Ѫа��";
			icon = "��Ѫа��.dds";
			SetTalent(0,687);
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

			return ((-35 * skill_level) - skill_level * skill_level + 555);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_level = player.GetLevel();
			int				player_maxmp = player.GetMaxmp();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();

			victim.SetProbability(((600 * norm(zrand(100) / (100 - 8 * skill_level)))));
			victim.SetTime(((5000 * skill_level + 100)));
			victim.SetRatio((skill_level * (skill_level * 0.01f) + (skill_level * 0.05f + 0.15f)));
			victim.SetBuffid(5);
			victim.SetWeak(true);
			victim.SetProbability(((1.0f - player_level * 0.002f) * ((skill_level * skill_level + (3 * skill_level)))));
			victim.SetRatio(1.0f);
			victim.SetDrainmagic(true);
			victim.SetProbability(((3 * skill_t0 + 50)));
			victim.SetTime(16100.0f);
			victim.SetRatio((skill_level * 0.2f));
			victim.SetBuffid(1);
			victim.SetDeccrithurt(true);
			victim.SetProbability(((1.0f - player_level * 0.002f) * 100.0f));
			victim.SetTime(30000.0f);
			victim.SetBuffid(5);
			victim.SetAmount((player_maxmp * (skill_level * (skill_level * 0.02f)) * 15.0f));
			victim.SetValue(0.0f);
			victim.SetMpleak(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_maxhp = player.GetMaxhp();
			int				skill_level = skill.GetLevel();

			victim.SetProbability(((skill_level * skill_level + (5 * skill_level) + 35)));
			victim.SetRatio(0.0f);
			victim.SetValue((player_maxhp * (skill_level * 0.02f)));
			victim.SetHeal(true);
			return true;
		}
	}
	public class GSkill565 : GSkill
	{
		public GSkill565()
			: base(565)
		{
			
		}
	}
	public class GSkill566Stub : GSkillStub
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
				int				skill_level = skill.GetLevel();
				int				skill_t0 = skill.GetT0();
				int				skill_t1 = skill.GetT1();

				skill.SetRatio((D2INT(player_level / (8 - skill_level)) * 0.01f + (skill_level * 0.09f + (skill_t0 * 0.03f + 1.0f))));
				skill.SetPlus((player_def * (skill_t1 * 0.03f) + ((255 * skill_level))));
				player.SetPerform(1);
			}
		}
		public GSkill566Stub()
			: base(566)
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
			SetAction(0,"���_����_�ɻ�");
			SetAction(1,"������_����_�ɻ�");
			SetAction(2,"������_����_�ɻ�");
			SetAction(3,"�ϻ���_����_�ɻ�");
			SetAction(4,"������_����_�ɻ�");
			SetAction(5,"���_����_�ɻ�");
			SetAction(6,"�����_����_�ɻ�");
			SetAction(7,"����_����_�ɻ�");
			SetAction(8,"����_����_�ɻ�");
			SetAction(9,"��ԯ_����_�ɻ�");
			SetAction(10,"����_����_�ɻ�");
			SetAction(11,"̫�_����_�ɻ�");
			SetAction(12,"�컪_����_�ɻ�");
			SetAction(13,"����_����_�ɻ�");
			SetAction(14,"Ӣ��_����_�ɻ�");
			SetAction(15,"������ʦ_����_�ɻ�");
			SetAction(16,"������ʦ_����_�ɻ�");
			SetAction(17,"������_����_�ɻ�");
			SetAction(18,"���_���_����_�ɻ�");
			SetAction(19,"������_���_����_�ɻ�");
			SetAction(20,"������_���_����_�ɻ�");
			SetAction(21,"�ϻ���_���_����_�ɻ�");
			SetAction(22,"������_���_����_�ɻ�");
			SetAction(23,"���_���_����_�ɻ�");
			SetAction(24,"�����_���_����_�ɻ�");
			SetAction(25,"����_���_����_�ɻ�");
			SetAction(26,"����_���_����_�ɻ�");
			SetAction(27,"��ԯ_���_����_�ɻ�");
			SetAction(28,"����_���_����_�ɻ�");
			SetAction(29,"̫�_���_����_�ɻ�");
			SetAction(30,"�컪_���_����_�ɻ�");
			name = "�ɻ���˫";
			nativename = "�ɻ���˫";
			icon = "�ɻ���˫.dds";
			SetTalent(0,687);
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

			return ((-55 * skill_level) - skill_level * skill_level + 705);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_maxmp = player.GetMaxmp();
			int				skill_level = skill.GetLevel();

			victim.SetProbability(120.0f);
			victim.SetTime(30000.0f);
			victim.SetBuffid(1);
			victim.SetAmount((player_maxmp * ((skill_level + 1) * ((skill_level + 1) * 0.02f)) * 15.0f));
			victim.SetValue(0.0f);
			victim.SetMpleak(true);
			victim.SetProbability(zrand(100) >= 7 * skill_level + 7?0.0f:600.0f);
			victim.SetTime(((5000 * skill_level + 5000)));
			victim.SetRatio(((skill_level + 1) * ((skill_level + 1) * 0.01f) + ((skill_level + 1) * 0.05f + 0.15f)));
			victim.SetBuffid(1);
			victim.SetWeak(true);
			victim.SetProbability(50.0f);
			victim.SetTime(16000.0f);
			victim.SetRatio((skill_level * 0.03001f));
			victim.SetBuffid(1);
			victim.SetDeccritrate(true);
			victim.SetProbability(50.0f);
			victim.SetTime(16000.0f);
			victim.SetRatio(((skill_level + 1) * 0.2f));
			victim.SetBuffid(1);
			victim.SetDeccrithurt(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_maxhp = player.GetMaxhp();
			int				skill_level = skill.GetLevel();

			victim.SetProbability((((skill_level + 1) * (skill_level + 1) + (5 * skill_level) + 40)));
			victim.SetRatio(0.0f);
			victim.SetValue((player_maxhp * ((skill_level + 1) * 0.02f)));
			victim.SetHeal(true);
			return true;
		}
	}
	public class GSkill566 : GSkill
	{
		public GSkill566()
			: base(566)
		{
			
		}
	}
	public class GSkill567Stub : GSkillStub
	{
		public GSkill567Stub()
			: base(567)
		{
			occupation = 7;
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
			talent_type = 1;
			use_proficiency = false;
			inc_proficiency = 0;
			preskillnum = 0;
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
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={15,135};return array[level-1];
		}
	}
	public class GSkill567 : GSkill
	{
		public GSkill567()
			: base(567)
		{
			
		}
	}
	public class GSkill568Stub : GSkillStub
	{
		public GSkill568Stub()
			: base(568)
		{
			occupation = 7;
			maxlevel = 4;
			maxlearn = 3;
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
			name = "���﷨��";
			nativename = "���﷨��";
			icon = "���﷨��.dds";
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
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={15,15,15};return array[level-1];
		}
	}
	public class GSkill568 : GSkill
	{
		public GSkill568()
			: base(568)
		{
			
		}
	}
	public class GSkill569Stub : GSkillStub
	{
		public GSkill569Stub()
			: base(569)
		{
			occupation = 7;
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
			name = "�罣֮â";
			nativename = "�罣֮â";
			icon = "����֮â.dds";
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
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={25,25};return array[level-1];
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={567};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={1};return array[index];
		}
	}
	public class GSkill569 : GSkill
	{
		public GSkill569()
			: base(569)
		{
			
		}
	}
}
