using System;
using System.Text;

namespace SKILL
{
	public class GSkill4510Stub : GSkillStub
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

				skill.SetRatio((D2INT(player_level / (11 - skill_level)) * 0.01f + (skill_level * 0.04f + (skill_t0 * 0.03f + 1.0f))));
				skill.SetPlus((player_def * (skill_t1 * 0.03f) + ((60 * (zrand(249 * skill_level + 50) + skill_level) * skill_level) * 0.01f)));
				player.SetPerform(1);
			}
		}
		public GSkill4510Stub()
			: base(4510)
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
			SetAction(0,"���_����_��̩��");
			SetAction(1,"������_����_��̩��");
			SetAction(2,"������_����_��̩��");
			SetAction(3,"�ϻ���_����_��̩��");
			SetAction(4,"������_����_��̩��");
			SetAction(5,"���_����_��̩��");
			SetAction(6,"�����_����_��̩��");
			SetAction(7,"����_����_��̩��");
			SetAction(8,"����_����_��̩��");
			SetAction(9,"��ԯ_����_��̩��");
			SetAction(10,"����_����_��̩��");
			SetAction(11,"̫�_����_��̩��");
			SetAction(12,"�컪_����_��̩��");
			SetAction(13,"����_����_��̩��");
			SetAction(14,"Ӣ��_����_��̩��");
			SetAction(15,"������ʦ_����_��̩��");
			SetAction(16,"������ʦ_����_��̩��");
			SetAction(17,"������_����_��̩��");
			SetAction(18,"���_���_����_��̩��");
			SetAction(19,"������_���_����_��̩��");
			SetAction(20,"������_���_����_��̩��");
			SetAction(21,"�ϻ���_���_����_��̩��");
			SetAction(22,"������_���_����_��̩��");
			SetAction(23,"���_���_����_��̩��");
			SetAction(24,"�����_���_����_��̩��");
			SetAction(25,"����_���_����_��̩��");
			SetAction(26,"����_���_����_��̩��");
			SetAction(27,"��ԯ_���_����_��̩��");
			SetAction(28,"����_���_����_��̩��");
			SetAction(29,"̫�_���_����_��̩��");
			SetAction(30,"�컪_���_����_��̩��");
			name = "�С���̩��";
			nativename = "�С���̩��";
			icon = "��̩��.dds";
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

			return (90 - 10 * skill_level);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();

			victim.SetProbability(((2 * skill_level + 3)));
			victim.SetTime(4100.0f);
			victim.SetRatio((skill_level * 0.03f + 0.09f));
			victim.SetValue((skill_level * 0.03f + 0.09f));
			victim.SetRandcurse(true);
			return true;
		}
	}
	public class GSkill4510 : GSkill
	{
		public GSkill4510()
			: base(4510)
		{
			
		}
	}
	public class GSkill4511Stub : GSkillStub
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

				skill.SetRatio((D2INT(player_level / (11 - skill_level)) * 0.01f + (skill_level * 0.04f + (skill_t0 * 0.03f + 1.0f))));
				skill.SetPlus((player_def * (skill_t1 * 0.03f) + ((player_mp + player_hp) * (skill_level * 0.01f) + ((60 * skill_level)))));
				player.SetPerform(1);
			}
		}
		public GSkill4511Stub()
			: base(4511)
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
			SetAction(0,"���_����_��ɽ�续");
			SetAction(1,"������_����_��ɽ�续");
			SetAction(2,"������_����_��ɽ�续");
			SetAction(3,"�ϻ���_����_��ɽ�续");
			SetAction(4,"������_����_��ɽ�续");
			SetAction(5,"���_����_��ɽ�续");
			SetAction(6,"�����_����_��ɽ�续");
			SetAction(7,"����_����_��ɽ�续");
			SetAction(8,"����_����_��ɽ�续");
			SetAction(9,"��ԯ_����_��ɽ�续");
			SetAction(10,"����_����_��ɽ�续");
			SetAction(11,"̫�_����_��ɽ�续");
			SetAction(12,"�컪_����_��ɽ�续");
			SetAction(13,"����_����_��ɽ�续");
			SetAction(14,"Ӣ��_����_��ɽ�续");
			SetAction(15,"������ʦ_����_��ɽ�续");
			SetAction(16,"������ʦ_����_��ɽ�续");
			SetAction(17,"������_����_��ɽ�续");
			SetAction(18,"���_���_����_��ɽ�续");
			SetAction(19,"������_���_����_��ɽ�续");
			SetAction(20,"������_���_����_��ɽ�续");
			SetAction(21,"�ϻ���_���_����_��ɽ�续");
			SetAction(22,"������_���_����_��ɽ�续");
			SetAction(23,"���_���_����_��ɽ�续");
			SetAction(24,"�����_���_����_��ɽ�续");
			SetAction(25,"����_���_����_��ɽ�续");
			SetAction(26,"����_���_����_��ɽ�续");
			SetAction(27,"��ԯ_���_����_��ɽ�续");
			SetAction(28,"����_���_����_��ɽ�续");
			SetAction(29,"̫�_���_����_��ɽ�续");
			SetAction(30,"�컪_���_����_��ɽ�续");
			name = "�С���ɽ�续";
			nativename = "�С���ɽ�续";
			icon = "��ɽ�续.dds";
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

			return (90 - 10 * skill_level);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();

			victim.SetProbability(((3 * skill_level + 3)));
			victim.SetTime(3100.0f);
			victim.SetDiet(true);
			return true;
		}
	}
	public class GSkill4511 : GSkill
	{
		public GSkill4511()
			: base(4511)
		{
			
		}
	}
	public class GSkill4512Stub : GSkillStub
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

				skill.SetCrit((D2INT(zrand(101) / 75) * (skill_level * 0.02f + 0.05f) + 0.0001f));
				skill.SetCrithurt((skill_level * 0.15f));
				skill.SetRatio((D2INT(player_level / (10 - skill_level)) * 0.01f + (skill_level * 0.04f + (skill_t0 * 0.03f + 1.0f))));
				skill.SetPlus((player_def * (skill_t1 * 0.03f) + ((88 * skill_level))));
				player.SetPerform(1);
			}
		}
		public GSkill4512Stub()
			: base(4512)
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
			name = "�С�������";
			nativename = "�С�������";
			icon = "������.dds";
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

			return (125 - 15 * skill_level);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_level = player.GetLevel();
			int				skill_level = skill.GetLevel();

			victim.SetProbability(((1.0f - player_level * 0.002f) * 100.0f));
			victim.SetTime(4000.0f);
			victim.SetBuffid(1);
			victim.SetAmount((player_level * (skill_level * 2.5f)));
			victim.SetValue(0.0f);
			victim.SetHpleak(true);
			return true;
		}
	}
	public class GSkill4512 : GSkill
	{
		public GSkill4512()
			: base(4512)
		{
			
		}
	}
	public class GSkill4513Stub : GSkillStub
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
				int				player_maxhp = player.GetMaxhp();
				int				player_def = player.GetDef();
				int				skill_level = skill.GetLevel();
				int				skill_t0 = skill.GetT0();
				int				skill_t1 = skill.GetT1();

				skill.SetRatio((D2INT((player_hp / 0.75f) / player_maxhp) * (skill_level * 0.05f) + (D2INT(player_level / (11 - skill_level)) * 0.01f + (skill_t0 * 0.03f + (skill_level * 0.04f + 1.0f)))));
				skill.SetPlus((player_def * (skill_t1 * 0.03f) + ((60 * skill_level))));
				player.SetPerform(1);
			}
		}
		public GSkill4513Stub()
			: base(4513)
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
			doenchant = false;
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
			SetAction(0,"���_����_��������");
			SetAction(1,"������_����_��������");
			SetAction(2,"������_����_��������");
			SetAction(3,"�ϻ���_����_��������");
			SetAction(4,"������_����_��������");
			SetAction(5,"���_����_��������");
			SetAction(6,"�����_����_��������");
			SetAction(7,"����_����_��������");
			SetAction(8,"����_����_��������");
			SetAction(9,"��ԯ_����_��������");
			SetAction(10,"����_����_��������");
			SetAction(11,"̫�_����_��������");
			SetAction(12,"�컪_����_��������");
			SetAction(13,"����_����_��������");
			SetAction(14,"Ӣ��_����_��������");
			SetAction(15,"������ʦ_����_��������");
			SetAction(16,"������ʦ_����_��������");
			SetAction(17,"������_����_��������");
			SetAction(18,"���_���_����_��������");
			SetAction(19,"������_���_����_��������");
			SetAction(20,"������_���_����_��������");
			SetAction(21,"�ϻ���_���_����_��������");
			SetAction(22,"������_���_����_��������");
			SetAction(23,"���_���_����_��������");
			SetAction(24,"�����_����_��������");
			SetAction(25,"����_���_����_��������");
			SetAction(26,"����_���_����_��������");
			SetAction(27,"��ԯ_���_����_��������");
			SetAction(28,"����_���_����_��������");
			SetAction(29,"̫�_���_����_��������");
			SetAction(30,"�컪_���_����_��������");
			name = "�С����컪";
			nativename = "�С����컪";
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

			return (90 - 10 * skill_level);
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();

			victim.SetProbability(100.0f);
			victim.SetRatio(0.0f);
			victim.SetValue(((zrand(10 * skill_level + 91) + skill_level)));
			victim.SetHeal(true);
			return true;
		}
	}
	public class GSkill4513 : GSkill
	{
		public GSkill4513()
			: base(4513)
		{
			
		}
	}
	public class GSkill4514Stub : GSkillStub
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

				skill.SetRatio((D2INT(player_level / (9 - skill_level)) * 0.01f + (skill_level * 0.05f + (skill_t0 * 0.03f + 1.0f))));
				skill.SetPlus((player_def * (skill_t1 * 0.03f) + ((205 * skill_level))));
				player.SetPerform(1);
			}
		}
		public GSkill4514Stub()
			: base(4514)
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
			SetAction(0,"���_����_���±���");
			SetAction(1,"������_����_���±���");
			SetAction(2,"������_����_���±���");
			SetAction(3,"�ϻ���_����_���±���");
			SetAction(4,"������_����_���±���");
			SetAction(5,"���_����_���±���");
			SetAction(6,"�����_����_���±���");
			SetAction(7,"����_����_���±���");
			SetAction(8,"����_����_���±���");
			SetAction(9,"��ԯ_����_���±���");
			SetAction(10,"����_����_���±���");
			SetAction(11,"̫�_����_���±���");
			SetAction(12,"�컪_����_���±���");
			SetAction(13,"����_����_���±���");
			SetAction(14,"Ӣ��_����_���±���");
			SetAction(15,"������ʦ_����_���±���");
			SetAction(16,"������ʦ_����_���±���");
			SetAction(17,"������_����_���±���");
			SetAction(18,"���_���_����_���±���");
			SetAction(19,"������_���_����_���±���");
			SetAction(20,"������_���_����_���±���");
			SetAction(21,"�ϻ���_���_����_���±���");
			SetAction(22,"������_���_����_���±���");
			SetAction(23,"���_���_����_���±���");
			SetAction(24,"�����_���_����_���±���");
			SetAction(25,"����_���_����_���±���");
			SetAction(26,"����_���_����_���±���");
			SetAction(27,"��ԯ_���_����_���±���");
			SetAction(28,"����_���_����_���±���");
			SetAction(29,"̫�_���_����_���±���");
			SetAction(30,"�컪_���_����_���±���");
			name = "�С�������";
			nativename = "�С�������";
			icon = "ͨ��04.dds";
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

			return ((-25 * skill_level) - skill_level * skill_level + 315);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();

			victim.SetProbability(100.0f);
			victim.SetTime(((2000 * skill_level + 4100)));
			victim.SetBuffid(1);
			victim.SetValue(((4 * (skill_level * skill_level + (7 * skill_level)))));
			victim.SetSubattack(true);
			victim.SetProbability(33.0f);
			victim.SetTime(10100.0f);
			victim.SetRatio((skill_level * 0.02001f));
			victim.SetBuffid(1);
			victim.SetDeccritrate(true);
			victim.SetProbability(((600 * norm((zrand(100) / 94)))));
			victim.SetTime(((2000 * skill_level + 100)));
			victim.SetDizzy(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();

			victim.SetProbability(((5 * skill_level + 5)));
			victim.SetTime(((2000 * skill_level + 12100)));
			victim.SetRatio(1.0f);
			victim.SetAmount(((2 * skill_level + 2)));
			victim.SetValue(((25 * skill_level * skill_level + 35)));
			victim.SetHpregain(true);
			return true;
		}
	}
	public class GSkill4514 : GSkill
	{
		public GSkill4514()
			: base(4514)
		{
			
		}
	}
	public class GSkill4515Stub : GSkillStub
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
		public GSkill4515Stub()
			: base(4515)
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
			name = "�С��������";
			nativename = "�С��������";
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
	public class GSkill4515 : GSkill
	{
		public GSkill4515()
			: base(4515)
		{
			
		}
	}
	public class GSkill4516Stub : GSkillStub
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

				skill.SetCrit((skill_level * 0.02f + 0.01f));
				skill.SetRatio((D2INT(player_level / (10 - skill_level)) * 0.01f + (skill_level * 0.05f + (skill_t0 * 0.03f + 1.0f))));
				skill.SetPlus((player_def * (skill_t1 * 0.03f) + ((150 * skill_level))));
				player.SetPerform(1);
			}
		}
		public GSkill4516Stub()
			: base(4516)
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
			SetAction(0,"���_����_���«");
			SetAction(1,"������_����_���«");
			SetAction(2,"������_����_���«");
			SetAction(3,"�ϻ���_����_���«");
			SetAction(4,"������_����_���«");
			SetAction(5,"���_����_���«");
			SetAction(6,"�����_����_���«");
			SetAction(7,"����_����_���«");
			SetAction(8,"����_����_���«");
			SetAction(9,"��ԯ_����_���«");
			SetAction(10,"����_����_���«");
			SetAction(11,"̫�_����_���«");
			SetAction(12,"�컪_����_���«");
			SetAction(13,"����_����_���«");
			SetAction(14,"Ӣ��_����_���«");
			SetAction(15,"������ʦ_����_���«");
			SetAction(16,"������ʦ_����_���«");
			SetAction(17,"������_����_���«");
			SetAction(18,"���_���_����_���«");
			SetAction(19,"������_���_����_���«");
			SetAction(20,"������_���_����_���«");
			SetAction(21,"�ϻ���_���_����_���«");
			SetAction(22,"������_���_����_���«");
			SetAction(23,"���_���_����_���«");
			SetAction(24,"�����_���_����_���«");
			SetAction(25,"����_���_����_���«");
			SetAction(26,"����_���_����_���«");
			SetAction(27,"��ԯ_���_����_���«");
			SetAction(28,"����_���_����_���«");
			SetAction(29,"̫�_���_����_���«");
			SetAction(30,"�컪_���_����_���«");
			name = "�С�����Ǭ��";
			nativename = "�С�����Ǭ��";
			icon = "����Ǭ��.dds";
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

			return ((-25 * skill_level) - skill_level * skill_level + 295);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_level = player.GetLevel();
			int				skill_level = skill.GetLevel();

			victim.SetProbability(((1.0f - player_level * 0.002f) * ((12 * skill_level))));
			victim.SetTime(((2000 * skill_level + 4100)));
			victim.SetBarehanded(true);
			victim.SetProbability(-1.0f);
			victim.SetRatio((skill_level * 0.1f));
			victim.SetDrainmagic(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_mp = player.GetMp();
			int				skill_level = skill.GetLevel();

			victim.SetProbability(((2 * skill_level + 3)));
			victim.SetRatio(0.0f);
			victim.SetValue((player_mp * (skill_level * 0.05f)));
			victim.SetHeal(true);
			return true;
		}
	}
	public class GSkill4516 : GSkill
	{
		public GSkill4516()
			: base(4516)
		{
			
		}
	}
	public class GSkill4517Stub : GSkillStub
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

				skill.SetRatio((D2INT(player_level / (10 - skill_level)) * 0.01f + (skill_level * 0.05f + (D2INT((zrand(skill_level + 101)) / 100.0f) * (skill_level * 0.6f) + (skill_t0 * 0.03f) + 1.0f))));
				skill.SetPlus((player_def * (skill_t1 * 0.03f) + ((150 * skill_level))));
				player.SetPerform(1);
			}
		}
		public GSkill4517Stub()
			: base(4517)
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
			name = "�С���������";
			nativename = "�С���������";
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

			return ((-25 * skill_level) - skill_level * skill_level + 295);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_maxhp = player.GetMaxhp();
			int				skill_level = skill.GetLevel();

			victim.SetProbability(((10 * skill_level + 15)));
			victim.SetTime(((3000 * skill_level + 100)));
			victim.SetBuffid(1);
			victim.SetAmount((player_maxhp * 0.15f));
			victim.SetValue(((250 * skill_level)));
			victim.SetSubhp(true);
			victim.SetProbability(((600 * norm(zrand(100) / (98 - skill_level)))));
			victim.SetTime(((5000 * skill_level + 100)));
			victim.SetDizzy(true);
			victim.SetProbability(-1.0f);
			victim.SetTime(((7000 * skill_level + 100)));
			victim.SetRatio((skill_level * 0.03f));
			victim.SetBuffid(4);
			victim.SetWeak(true);
			return true;
		}
	}
	public class GSkill4517 : GSkill
	{
		public GSkill4517()
			: base(4517)
		{
			
		}
	}
	public class GSkill4518Stub : GSkillStub
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

				skill.SetRatio((D2INT(player_level / (9 - skill_level)) * 0.01f + (skill_level * 0.06f + (skill_t0 * 0.1f + 1.0f))));
				skill.SetPlus((player_def * (skill_t1 * 0.03f) + ((215 * skill_level))));
				player.SetPerform(1);
			}
		}
		public GSkill4518Stub()
			: base(4518)
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
			SetAction(0,"���_����_����ӡ");
			SetAction(1,"������_����_����ӡ");
			SetAction(2,"������_����_����ӡ");
			SetAction(3,"�ϻ���_����_����ӡ");
			SetAction(4,"������_����_����ӡ");
			SetAction(5,"���_����_����ӡ");
			SetAction(6,"�����_����_����ӡ");
			SetAction(7,"����_����_����ӡ");
			SetAction(8,"����_����_����ӡ");
			SetAction(9,"��ԯ_����_����ӡ");
			SetAction(10,"����_����_����ӡ");
			SetAction(11,"̫�_����_����ӡ");
			SetAction(12,"�컪_����_����ӡ");
			SetAction(13,"����_����_����ӡ");
			SetAction(14,"Ӣ��_����_����ӡ");
			SetAction(15,"������ʦ_����_����ӡ");
			SetAction(16,"������ʦ_����_����ӡ");
			SetAction(17,"������_����_����ӡ");
			SetAction(18,"���_���_����_����ӡ");
			SetAction(19,"������_���_����_����ӡ");
			SetAction(20,"������_���_����_����ӡ");
			SetAction(21,"�ϻ���_���_����_����ӡ");
			SetAction(22,"������_���_����_����ӡ");
			SetAction(23,"���_���_����_����ӡ");
			SetAction(24,"�����_���_����_����ӡ");
			SetAction(25,"����_���_����_����ӡ");
			SetAction(26,"����_���_����_����ӡ");
			SetAction(27,"��ԯ_���_����_����ӡ");
			SetAction(28,"����_���_����_����ӡ");
			SetAction(29,"̫�_���_����_����ӡ");
			SetAction(30,"�컪_���_����_����ӡ");
			name = "�С���������";
			nativename = "�С���������";
			icon = "��������.dds";
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
		public override float GetRadius(GSkill skill)
		{
			return 4.000000f;
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
		public override int GetCoverage(GSkill skill)
		{
			return 2;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();

			victim.SetProbability(((skill_level * skill_level + 15)));
			victim.SetTime(10100.0f);
			victim.SetRatio((skill_level * (skill_level * 0.01f) + (skill_level * 0.01f)));
			victim.SetInchurt(true);
			victim.SetProbability(((skill_level * skill_level + 15)));
			victim.SetTime(10100.0f);
			victim.SetRatio((skill_level * (skill_level * 0.01f) + (skill_level * 0.01f)));
			victim.SetBuffid(5);
			victim.SetDecaccuracy(true);
			victim.SetProbability(((600 * norm(zrand(100) / (98 - skill_level * skill_level)))));
			victim.SetTime(6100.0f);
			victim.SetWrap(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_maxhp = player.GetMaxhp();
			int				skill_level = skill.GetLevel();

			victim.SetProbability(((2 * skill_level)));
			victim.SetRatio(0.0f);
			victim.SetValue(((skill_level * (skill_level * 0.01f) + 0.25f) * player_maxhp));
			victim.SetHeal(true);
			return true;
		}
	}
	public class GSkill4518 : GSkill
	{
		public GSkill4518()
			: base(4518)
		{
			
		}
	}
	public class GSkill4519Stub : GSkillStub
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
				int				player_def = player.GetDef();
				int				skill_level = skill.GetLevel();
				int				skill_t0 = skill.GetT0();
				int				skill_t1 = skill.GetT1();

				skill.SetRatio((D2INT(player_level / (10 - skill_level)) * 0.01f + (skill_level * 0.05f + (skill_t0 * 0.03f + 1.0f))));
				skill.SetPlus((player_def * (skill_t1 * 0.03f) + (player_mp * (skill_level * 0.02f) + ((150 * skill_level)))));
				player.SetPerform(1);
			}
		}
		public GSkill4519Stub()
			: base(4519)
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
			SetAction(0,"���_����_��ɽ�续");
			SetAction(1,"������_����_��ɽ�续");
			SetAction(2,"������_����_��ɽ�续");
			SetAction(3,"�ϻ���_����_��ɽ�续");
			SetAction(4,"������_����_��ɽ�续");
			SetAction(5,"���_����_��ɽ�续");
			SetAction(6,"�����_����_��ɽ�续");
			SetAction(7,"����_����_��ɽ�续");
			SetAction(8,"����_����_��ɽ�续");
			SetAction(9,"��ԯ_����_��ɽ�续");
			SetAction(10,"����_����_��ɽ�续");
			SetAction(11,"̫�_����_��ɽ�续");
			SetAction(12,"�컪_����_��ɽ�续");
			SetAction(13,"����_����_��ɽ�续");
			SetAction(14,"Ӣ��_����_��ɽ�续");
			SetAction(15,"������ʦ_����_��ɽ�续");
			SetAction(16,"������ʦ_����_��ɽ�续");
			SetAction(17,"������_����_��ɽ�续");
			SetAction(18,"���_���_����_��ɽ�续");
			SetAction(19,"������_���_����_��ɽ�续");
			SetAction(20,"������_���_����_��ɽ�续");
			SetAction(21,"�ϻ���_���_����_��ɽ�续");
			SetAction(22,"������_���_����_��ɽ�续");
			SetAction(23,"���_���_����_��ɽ�续");
			SetAction(24,"�����_���_����_��ɽ�续");
			SetAction(25,"���_���_����_��ɽ�续");
			SetAction(26,"����_���_����_��ɽ�续");
			SetAction(27,"��ԯ_���_����_��ɽ�续");
			SetAction(28,"����_���_����_��ɽ�续");
			SetAction(29,"̫�_���_����_��ɽ�续");
			SetAction(30,"�컪_���_����_��ɽ�续");
			name = "�С���ң����";
			nativename = "�С���ң����";
			icon = "Ļ�춾.dds";
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

			return ((-15 * skill_level) - skill_level * skill_level + 195);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();

			victim.SetProbability(((3 * skill_level + 3)));
			victim.SetTime(4100.0f);
			victim.SetDiet(true);
			victim.SetProbability(-1.0f);
			victim.SetTime(12100.0f);
			victim.SetRatio((skill_level * 0.05f));
			victim.SetBuffid(6);
			victim.SetDecdefence(true);
			return true;
		}
	}
	public class GSkill4519 : GSkill
	{
		public GSkill4519()
			: base(4519)
		{
			
		}
	}
}
