using System;
using System.Text;

namespace SKILL
{
	public class GSkill4460Stub : GSkillStub
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
				int				skill_t0 = skill.GetT0();

				skill.SetRatio((D2INT(player_level / (13 - skill_level)) * 0.01f + (skill_level * 0.01f + (skill_t0 * 0.03f + 1.0f))));
				skill.SetPlus(((3 * skill_level)));
				player.SetPerform(1);
			}
		}
		public GSkill4460Stub()
			: base(4460)
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
			SetAction(0,"���_����_��������");
			SetAction(1,"������_����_��������");
			SetAction(2,"������_����_��������");
			SetAction(3,"�ϻ���_����_��������");
			SetAction(4,"������_����_��������");
			SetAction(5,"���_����_��������");
			SetAction(6,"�����_����_��������");
			SetAction(7,"����_����_��ɫʯ");
			SetAction(8,"����_����_��ɫʯ");
			SetAction(9,"��ԯ_����_��ɫʯ");
			SetAction(10,"����_����_��ɫʯ");
			SetAction(11,"����_����_��ɫʯ");
			SetAction(12,"�컪_����_��ɫʯ");
			SetAction(13,"01");
			SetAction(14,"01");
			SetAction(15,"0");
			SetAction(16,"0");
			SetAction(17,"������_����_��������");
			SetAction(18,"���_���_����_��������");
			SetAction(19,"������_���_����_��������");
			SetAction(20,"������_���_����_��������");
			SetAction(21,"�ϻ���_���_����_��������");
			SetAction(22,"������_���_����_��������");
			SetAction(23,"���_���_����_��������");
			SetAction(24,"�����_���_����_��������");
			SetAction(25,"����_���_����_��ɫʯ");
			SetAction(26,"����_���_����_��ɫʯ");
			SetAction(27,"��ԯ_���_����_��ɫʯ");
			SetAction(28,"����_���_����_��ɫʯ");
			SetAction(29,"����_���_����_��ɫʯ");
			SetAction(30,"�컪_���_����_��ɫʯ");
			name = "�С���������";
			nativename = "�С���������";
			icon = "��������.dds";
			SetTalent(0,687);
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

			return (13 - skill_level);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_level = player.GetLevel();
			int				skill_level = skill.GetLevel();

			victim.SetProbability(((1.0f - player_level * 0.002f) * 100.0f));
			victim.SetTime(2000.0f);
			victim.SetBuffid(1);
			victim.SetAmount(((10 * skill_level)));
			victim.SetValue(0.0f);
			victim.SetHpleak(true);
			return true;
		}
	}
	public class GSkill4460 : GSkill
	{
		public GSkill4460()
			: base(4460)
		{
			
		}
	}
	public class GSkill4461Stub : GSkillStub
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

				skill.SetRatio((D2INT(player_level / (12 - skill_level)) * 0.01f + (skill_level * 0.01f + 1.0f)));
				skill.SetPlus(((10 * skill_level)));
				player.SetPerform(1);
			}
		}
		public GSkill4461Stub()
			: base(4461)
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
			SetAction(0,"���_����_��������");
			SetAction(1,"���_����_��������");
			SetAction(2,"���_����_��������");
			SetAction(3,"���_����_��������");
			SetAction(4,"���_����_��������");
			SetAction(5,"���_����_��������");
			SetAction(6,"���_����_��������");
			SetAction(7,"����_����_��ɫʯ");
			SetAction(8,"����_����_��ɫʯ");
			SetAction(9,"��ԯ_����_��ɫʯ");
			SetAction(10,"����_����_��ɫʯ");
			SetAction(11,"����_����_��ɫʯ");
			SetAction(12,"�컪_����_��ɫʯ");
			SetAction(13,"01");
			SetAction(14,"01");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"���_���_����_��������");
			SetAction(19,"���_���_����_��������");
			SetAction(20,"���_���_����_��������");
			SetAction(21,"���_���_����_��������");
			SetAction(22,"���_���_����_��������");
			SetAction(23,"���_���_����_��������");
			SetAction(24,"���_���_����_��������");
			SetAction(25,"����_���_����_��ɫʯ");
			SetAction(26,"����_���_����_��ɫʯ");
			SetAction(27,"��ԯ_���_����_��ɫʯ");
			SetAction(28,"����_���_����_��ɫʯ");
			SetAction(29,"����_���_����_��ɫʯ");
			SetAction(30,"�컪_���_����_��ɫʯ");
			name = "�С���ʻ�һ";
			nativename = "�С���ʻ�һ";
			icon = "��ʻ�һ.dds";
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

			return (32 - 2 * skill_level);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();

			victim.SetProbability(((4 * skill_level + 20)));
			victim.SetTime(((30100 - 2000 * skill_level)));
			victim.SetBuffid(4);
			victim.SetAmount(128.0f);
			victim.SetCycsubdefence(true);
			victim.SetTime(((2000 * skill_level + 1100)));
			victim.SetAmount(((2 * norm(skill_level / 4.9f) + (norm(skill_level / 3.9f) + skill_level))));
			victim.SetValue(((4 * skill_level)));
			victim.SetCursed(true);
			return true;
		}
	}
	public class GSkill4461 : GSkill
	{
		public GSkill4461()
			: base(4461)
		{
			
		}
	}
	public class GSkill4462Stub : GSkillStub
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
				int				skill_level = skill.GetLevel();
				int				skill_t0 = skill.GetT0();
				int				skill_t1 = skill.GetT1();

				skill.SetCrit((skill_t1 * 0.02f));
				skill.SetRatio(((skill_t0 + 1) * (D2INT((player_mp / 0.95f) / player_maxmp) * 0.04f) + (D2INT(player_level / (12 - skill_level)) * 0.01f + (skill_level * 0.03f + (skill_t0 * 0.08f + 1.0f)))));
				skill.SetPlus(((30 * skill_level)));
				player.SetPerform(1);
			}
		}
		public GSkill4462Stub()
			: base(4462)
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
			SetAction(0,"������_����_���Ͼ�");
			SetAction(1,"������_����_���Ͼ�");
			SetAction(2,"������_����_���Ͼ�");
			SetAction(3,"������_����_���Ͼ�");
			SetAction(4,"������_����_���Ͼ�");
			SetAction(5,"������_����_���Ͼ�");
			SetAction(6,"������_����_���Ͼ�");
			SetAction(7,"����_����_ŭ���");
			SetAction(8,"����_����_����");
			SetAction(9,"��ԯ_����_�ʶ���");
			SetAction(10,"����_����_��ɱ");
			SetAction(11,"̫�_����_�׹�ī");
			SetAction(12,"�컪_����_������");
			SetAction(13,"01");
			SetAction(14,"01");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"������_���_����_���Ͼ�");
			SetAction(19,"������_���_����_���Ͼ�");
			SetAction(20,"������_���_����_���Ͼ�");
			SetAction(21,"������_���_����_���Ͼ�");
			SetAction(22,"������_���_����_���Ͼ�");
			SetAction(23,"������_���_����_���Ͼ�");
			SetAction(24,"������_���_����_���Ͼ�");
			SetAction(25,"����_���_����_ŭ���");
			SetAction(26,"����_���_����_����");
			SetAction(27,"��ԯ_���_����_�ʶ���");
			SetAction(28,"����_���_����_��ɱ");
			SetAction(29,"̫�_���_����_�׹�ī");
			SetAction(30,"�컪_���_����_������");
			name = "�С������ݺ�";
			nativename = "�С������ݺ�";
			icon = "�����ݺ�.dds";
			SetTalent(0,568);
			SetTalent(1,599);
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

			return (63 - 3 * skill_level);
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
	public class GSkill4462 : GSkill
	{
		public GSkill4462()
			: base(4462)
		{
			
		}
	}
	public class GSkill4463Stub : GSkillStub
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
				int				skill_t0 = skill.GetT0();

				skill.SetRatio((D2INT(player_level / (12 - skill_level)) * 0.01f + (skill_t0 * 0.1f + (skill_level * 0.02f + 1.0f))));
				skill.SetPlus(((10 * skill_level)));
				player.SetPerform(1);
			}
		}
		public GSkill4463Stub()
			: base(4463)
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
			SetAction(0,"������_����_��ȸӡ");
			SetAction(1,"������_����_��ȸӡ");
			SetAction(2,"������_����_��ȸӡ");
			SetAction(3,"������_����_��ȸӡ");
			SetAction(4,"������_����_��ȸӡ");
			SetAction(5,"������_����_��ȸӡ");
			SetAction(6,"������_����_��ȸӡ");
			SetAction(7,"����_����_ŭ���");
			SetAction(8,"����_����_����");
			SetAction(9,"��ԯ_����_�ʶ���");
			SetAction(10,"����_����_��ɱ");
			SetAction(11,"̫�_����_�׹�ī");
			SetAction(12,"�컪_����_������");
			SetAction(13,"01");
			SetAction(14,"01");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"������_���_����_��ȸӡ");
			SetAction(19,"������_���_����_��ȸӡ");
			SetAction(20,"������_���_����_��ȸӡ");
			SetAction(21,"������_���_����_��ȸӡ");
			SetAction(22,"������_���_����_��ȸӡ");
			SetAction(23,"������_���_����_��ȸӡ");
			SetAction(24,"������_���_����_��ȸӡ");
			SetAction(25,"����_���_����_ŭ���");
			SetAction(26,"����_���_����_����");
			SetAction(27,"��ԯ_���_����_�ʶ���");
			SetAction(28,"����_���_����_��ɱ");
			SetAction(29,"̫�_���_����_�׹�ī");
			SetAction(30,"�컪_���_����_������");
			name = "�С�����Ѫ��";
			nativename = "�С�����Ѫ��";
			icon = "����Ѫ��.dds";
			SetTalent(0,652);
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

			return (32 - 2 * skill_level);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_t0 = skill.GetT0();

			victim.SetProbability(((3 * skill_t0 + 15)));
			victim.SetTime(6100.0f);
			victim.SetRatio(((skill_t0 * 0.5f + 1.0f) * 0.05f));
			victim.SetBuffid(3);
			victim.SetTiansha(true);
			return true;
		}
	}
	public class GSkill4463 : GSkill
	{
		public GSkill4463()
			: base(4463)
		{
			
		}
	}
	public class GSkill4464Stub : GSkillStub
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
				int				skill_t0 = skill.GetT0();

				skill.SetRatio((D2INT(player_level / (12 - skill_level)) * 0.01f + (skill_t0 * 0.1f + (skill_level * 0.02f + 1.0f))));
				skill.SetPlus(((15 * skill_level)));
				player.SetPerform(1);
			}
		}
		public GSkill4464Stub()
			: base(4464)
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
			SetAction(0,"������_����_�ֻ���");
			SetAction(1,"������_����_�ֻ���");
			SetAction(2,"������_����_�ֻ���");
			SetAction(3,"������_����_�ֻ���");
			SetAction(4,"������_����_�ֻ���");
			SetAction(5,"������_����_�ֻ���");
			SetAction(6,"������_����_�ֻ���");
			SetAction(7,"����_����_ŭ���");
			SetAction(8,"����_����_����");
			SetAction(9,"��ԯ_����_�ʶ���");
			SetAction(10,"����_����_��ɱ");
			SetAction(11,"̫�_����_�׹�ī");
			SetAction(12,"�컪_����_������");
			SetAction(13,"01");
			SetAction(14,"01");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"������_���_����_�ֻ���");
			SetAction(19,"������_���_����_�ֻ���");
			SetAction(20,"������_���_����_�ֻ���");
			SetAction(21,"������_���_����_�ֻ���");
			SetAction(22,"������_���_����_�ֻ���");
			SetAction(23,"������_���_����_�ֻ���");
			SetAction(24,"������_���_����_�ֻ���");
			SetAction(25,"����_����_ŭ���");
			SetAction(26,"����_����_����");
			SetAction(27,"��ԯ_����_�ʶ���");
			SetAction(28,"����_����_��ɱ");
			SetAction(29,"̫�_����_�׹�ī");
			SetAction(30,"�컪_����_������");
			name = "�С������ֻ�";
			nativename = "�С������ֻ�";
			icon = "�����ֻ�.dds";
			SetTalent(0,670);
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

			return (63 - 3 * skill_level);
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();

			victim.SetValue(((8 * skill_level * (skill_t0 + 1))));
			victim.SetJuqi(true);
			return true;
		}
	}
	public class GSkill4464 : GSkill
	{
		public GSkill4464()
			: base(4464)
		{
			
		}
	}
	public class GSkill4465Stub : GSkillStub
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
				int				skill_t0 = skill.GetT0();

				skill.SetRatio((D2INT(player_level / (12 - skill_level)) * 0.01f + (skill_t0 * 0.1f + (skill_level * 0.02f + 1.0f))));
				skill.SetPlus(((15 * skill_level)));
				player.SetPerform(1);
			}
		}
		public GSkill4465Stub()
			: base(4465)
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
			SetAction(0,"�ϻ���_����_������");
			SetAction(1,"�ϻ���_����_������");
			SetAction(2,"�ϻ���_����_������");
			SetAction(3,"�ϻ���_����_������");
			SetAction(4,"�ϻ���_����_������");
			SetAction(5,"�ϻ���_����_������");
			SetAction(6,"�ϻ���_����_������");
			SetAction(7,"����_����_ŭ���");
			SetAction(8,"����_����_����");
			SetAction(9,"��ԯ_����_�ʶ���");
			SetAction(10,"����_����_��ɱ");
			SetAction(11,"̫�_����_�׹�ī");
			SetAction(12,"�컪_����_������");
			SetAction(13,"01");
			SetAction(14,"01");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"�ϻ���_���_����_������");
			SetAction(19,"�ϻ���_���_����_������");
			SetAction(20,"�ϻ���_���_����_������");
			SetAction(21,"�ϻ���_���_����_������");
			SetAction(22,"�ϻ���_���_����_������");
			SetAction(23,"�ϻ���_���_����_������");
			SetAction(24,"�ϻ���_���_����_������");
			SetAction(25,"����_���_����_ŭ���");
			SetAction(26,"����_���_����_����");
			SetAction(27,"��ԯ_���_����_�ʶ���");
			SetAction(28,"����_���_����_��ɱ");
			SetAction(29,"̫�_���_����_�׹�ī");
			SetAction(30,"�컪_���_����_������");
			name = "�С�������";
			nativename = "�С�������";
			icon = "������.dds";
			SetTalent(0,721);
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

			return (32 - 2 * skill_level);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_level = player.GetLevel();
			int				skill_t0 = skill.GetT0();

			victim.SetProbability(((1.0f - player_level * 0.002f) * ((3 * skill_t0 + 30))));
			victim.SetRatio((skill_t0 * 0.09f + 0.12f));
			victim.SetXiaoxin(true);
			return true;
		}
	}
	public class GSkill4465 : GSkill
	{
		public GSkill4465()
			: base(4465)
		{
			
		}
	}
	public class GSkill4466Stub : GSkillStub
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
				int				skill_level = skill.GetLevel();
				int				skill_t0 = skill.GetT0();

				skill.SetRatio((D2INT(player_level / (12 - skill_level)) * 0.01f + (skill_level * 0.02f + (skill_t0 * 0.1f + 1.0f))));
				skill.SetPlus(((skill_t0 * 0.1f + 1.0f) * ((player_mp + player_hp) * 0.01f) + ((17 * skill_level))));
				player.SetPerform(1);
			}
		}
		public GSkill4466Stub()
			: base(4466)
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
			SetAction(0,"���_����_Ѫ���Ƭ");
			SetAction(1,"���_����_Ѫ���Ƭ");
			SetAction(2,"���_����_Ѫ���Ƭ");
			SetAction(3,"���_����_Ѫ���Ƭ");
			SetAction(4,"���_����_Ѫ���Ƭ");
			SetAction(5,"���_����_Ѫ���Ƭ");
			SetAction(6,"���_����_Ѫ���Ƭ");
			SetAction(7,"����_����_ŭ���");
			SetAction(8,"����_����_����");
			SetAction(9,"��ԯ_����_�ʶ���");
			SetAction(10,"����_����_��ɱ");
			SetAction(11,"̫�_����_�׹�ī");
			SetAction(12,"�컪_����_������");
			SetAction(13,"01");
			SetAction(14,"01");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"���_���_����_Ѫ���Ƭ");
			SetAction(19,"���_���_����_Ѫ���Ƭ");
			SetAction(20,"���_���_����_Ѫ���Ƭ");
			SetAction(21,"���_���_����_Ѫ���Ƭ");
			SetAction(22,"���_���_����_Ѫ���Ƭ");
			SetAction(23,"���_���_����_Ѫ���Ƭ");
			SetAction(24,"���_���_����_Ѫ���Ƭ");
			SetAction(25,"����_���_����_ŭ���");
			SetAction(26,"����_���_����_����");
			SetAction(27,"��ԯ_���_����_�ʶ���");
			SetAction(28,"����_���_����_��ɱ");
			SetAction(29,"̫�_���_����_�׹�ī");
			SetAction(30,"�컪_���_����_������");
			name = "�С��������";
			nativename = "�С��������";
			icon = "ǧ���׹�.dds";
			SetTalent(0,1174);
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

			return (46 - 4 * skill_level);
		}
	}
	public class GSkill4466 : GSkill
	{
		public GSkill4466()
			: base(4466)
		{
			
		}
	}
	public class GSkill4467Stub : GSkillStub
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
				int				player_res3 = player.GetRes3();
				int				skill_level = skill.GetLevel();

				player.SetVar1(player_res3);
				skill.SetRatio((D2INT(player_level / (12 - skill_level)) * 0.01f + (skill_level * 0.02f + 1.0f)));
				skill.SetPlus(((15 * skill_level)));
				player.SetPerform(1);
			}
		}
		public GSkill4467Stub()
			: base(4467)
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
			SetAction(0,"�����_����_����ӡ");
			SetAction(1,"�����_����_����ӡ");
			SetAction(2,"�����_����_����ӡ");
			SetAction(3,"�����_����_����ӡ");
			SetAction(4,"�����_����_����ӡ");
			SetAction(5,"�����_����_����ӡ");
			SetAction(6,"�����_����_����ӡ");
			SetAction(7,"����_����_ŭ���");
			SetAction(8,"����_����_����");
			SetAction(9,"��ԯ_����_�ʶ���");
			SetAction(10,"����_����_��ɱ");
			SetAction(11,"̫�_����_�׹�ī");
			SetAction(12,"�컪_����_������");
			SetAction(13,"01");
			SetAction(14,"01");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"�����_���_����_����ӡ");
			SetAction(19,"�����_���_����_����ӡ");
			SetAction(20,"�����_���_����_����ӡ");
			SetAction(21,"�����_���_����_����ӡ");
			SetAction(22,"�����_���_����_����ӡ");
			SetAction(23,"�����_���_����_����ӡ");
			SetAction(24,"�����_���_����_����ӡ");
			SetAction(25,"����_���_����_ŭ���");
			SetAction(26,"����_���_����_����");
			SetAction(27,"��ԯ_���_����_�ʶ���");
			SetAction(28,"����_���_����_��ɱ");
			SetAction(29,"̫�_���_����_�׹�ī");
			SetAction(30,"�컪_���_����_������");
			name = "�С�ҵ������";
			nativename = "�С�ҵ������";
			icon = "ҵ������.dds";
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

			return (63 - 3 * skill_level);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_var1 = player.GetVar1();
			int				skill_level = skill.GetLevel();

			/*
			victim.SetProbability(((2 * skill_level + 10)));
			victim.SetTime(((1000 * skill_level + 4000)));
			victim.SetRatio(4.0f);
			victim.SetBuffid(1);
			victim.SetAmount(5.0f);
			victim.SetValue(((34 * skill_level + 69)));
			victim.SetFiring(true);
			if ( player.GetHasmultbuff(113) != 1
			|| (v13 = zrand(100), v13 >= 6 * skill_level + 24) )
			{
			v21 = 0.0f;
			}
			else
			{
			v21 = (6 * skill_level + player_var1);
			}
			victim.SetProbability(v21);
			victim.SetTime(((1000 * skill_level + 2000)));
			victim.SetWrap(true);
			*/
			return true;
		}
	}
	public class GSkill4467 : GSkill
	{
		public GSkill4467()
			: base(4467)
		{
			
		}
	}
	public class GSkill4468Stub : GSkillStub
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

				skill.SetRatio((D2INT(player_level / (12 - skill_level)) * 0.01f + (skill_level * 0.02f + 1.0f)));
				skill.SetPlus(((10 * skill_level)));
				player.SetPerform(1);
			}
		}
		public GSkill4468Stub()
			: base(4468)
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
			SetAction(0,"����_����_ŭ���");
			SetAction(1,"������_����_���Ͼ�");
			SetAction(2,"������_����_���Ͼ�");
			SetAction(3,"������_����_���Ͼ�");
			SetAction(4,"������_����_���Ͼ�");
			SetAction(5,"������_����_���Ͼ�");
			SetAction(6,"������_����_���Ͼ�");
			SetAction(7,"����_����_ŭ���");
			SetAction(8,"����_����_����");
			SetAction(9,"��ԯ_����_�ʶ���");
			SetAction(10,"����_����_��ɱ");
			SetAction(11,"̫�_����_�׹�ī");
			SetAction(12,"�컪_����_������");
			SetAction(13,"01");
			SetAction(14,"01");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"����_���_����_ŭ���");
			SetAction(19,"������_���_����_���Ͼ�");
			SetAction(20,"������_���_����_���Ͼ�");
			SetAction(21,"������_���_����_���Ͼ�");
			SetAction(22,"������_���_����_���Ͼ�");
			SetAction(23,"������_���_����_���Ͼ�");
			SetAction(24,"������_���_����_���Ͼ�");
			SetAction(25,"����_���_����_ŭ���");
			SetAction(26,"����_���_����_����");
			SetAction(27,"��ԯ_���_����_�ʶ���");
			SetAction(28,"����_���_����_��ɱ");
			SetAction(29,"̫�_���_����_�׹�ī");
			SetAction(30,"�컪_���_����_������");
			name = "�С�������";
			nativename = "�С�������";
			icon = "������.dds";
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

			return (63 - 3 * skill_level);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_level = player.GetLevel();
			int				skill_level = skill.GetLevel();

			victim.SetProbability((player_level * 2.2f));
			victim.SetTime(4100.0f);
			victim.SetRatio(0.1f);
			victim.SetBuffid(3);
			victim.SetWeak(true);
			victim.SetTime(((2000 * skill_level + 1100)));
			victim.SetAmount(((2 * norm(skill_level / 4.9f) + (norm(skill_level / 3.9f) + skill_level))));
			victim.SetValue(((6 * skill_level + 4)));
			victim.SetCursed(true);
			return true;
		}
	}
	public class GSkill4468 : GSkill
	{
		public GSkill4468()
			: base(4468)
		{
			
		}
	}
	public class GSkill4469Stub : GSkillStub
	{
		public class GState1 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 1625;
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
				return 375;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_level = player.GetLevel();
				int				skill_level = skill.GetLevel();

				skill.SetRatio((D2INT(player_level / (12 - skill_level)) * 0.01f + (skill_level * 0.02f + 1.0f)));
				skill.SetPlus(((15 * skill_level)));
				player.SetPerform(1);
			}
		}
		public GSkill4469Stub()
			: base(4469)
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
			SetAction(0,"����_����_����");
			SetAction(1,"������_����_��ȸӡ");
			SetAction(2,"������_����_��ȸӡ");
			SetAction(3,"������_����_��ȸӡ");
			SetAction(4,"������_����_��ȸӡ");
			SetAction(5,"������_����_��ȸӡ");
			SetAction(6,"������_����_��ȸӡ");
			SetAction(7,"����_����_ŭ���");
			SetAction(8,"����_����_����");
			SetAction(9,"��ԯ_����_�ʶ���");
			SetAction(10,"����_����_��ɱ");
			SetAction(11,"̫�_����_�׹�ī");
			SetAction(12,"�컪_����_������");
			SetAction(13,"01");
			SetAction(14,"01");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"����_���_����_����");
			SetAction(19,"������_���_����_��ȸӡ");
			SetAction(20,"������_���_����_��ȸӡ");
			SetAction(21,"������_���_����_��ȸӡ");
			SetAction(22,"������_���_����_��ȸӡ");
			SetAction(23,"������_���_����_��ȸӡ");
			SetAction(24,"������_���_����_��ȸӡ");
			SetAction(25,"����_���_����_ŭ���");
			SetAction(26,"����_���_����_����");
			SetAction(27,"��ԯ_���_����_�ʶ���");
			SetAction(28,"����_���_����_��ɱ");
			SetAction(29,"̫�_���_����_�׹�ī");
			SetAction(30,"�컪_���_����_������");
			name = "�С���Ӱ����";
			nativename = "�С���Ӱ����";
			icon = "��Ӱ����.dds";
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

			return (63 - 3 * skill_level);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();

			victim.SetProbability(((6 * skill_level + 24)));
			victim.SetTime(((30100 - 2000 * skill_level)));
			victim.SetBuffid(4);
			victim.SetAmount(192.0f);
			victim.SetCycsubdefence(true);
			victim.SetProbability(120.0f);
			victim.SetTime(((1000 * skill_level + 4100)));
			victim.SetBuffid(2);
			victim.SetValue(((10 * skill_level)));
			victim.SetSubanti(true);
			return true;
		}
	}
	public class GSkill4469 : GSkill
	{
		public GSkill4469()
			: base(4469)
		{
			
		}
	}
}
