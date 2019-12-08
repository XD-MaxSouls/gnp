using System;
using System.Text;

namespace SKILL
{
	public class GSkill4480Stub : GSkillStub
	{
		public class GState1 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 1525;
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
				int				skill_level = skill.GetLevel();

				skill.SetRatio((D2INT(player_level / (11 - skill_level)) * 0.01f + (skill_level * 0.02f + 1.0f)));
				skill.SetPlus(((45 * skill_level)));
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
				int				skill_level = skill.GetLevel();

				skill.SetRatio((D2INT(player_level / (11 - skill_level)) * 0.01f + (skill_level * 0.02f + 1.0f)));
				skill.SetPlus(((45 * skill_level)));
				player.SetPerform(0);
			}
		}
		public GSkill4480Stub()
			: base(4480)
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
			SetAction(0,"����_����_Ѫ��ǹ");
			SetAction(1,"������_����_���ǽ�");
			SetAction(2,"������_����_���ǽ�");
			SetAction(3,"������_����_���ǽ�");
			SetAction(4,"������_����_���ǽ�");
			SetAction(5,"������_����_���ǽ�");
			SetAction(6,"������_����_���ǽ�");
			SetAction(7,"����_����_Ѫ��ǹ");
			SetAction(8,"����_����_������");
			SetAction(9,"��ԯ_����_������");
			SetAction(10,"����_����_�ƾ�");
			SetAction(11,"̫�_����_������");
			SetAction(12,"�컪_����_�Ƿ�");
			SetAction(13,"01");
			SetAction(14,"01");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"����_���_����_Ѫ��ǹ");
			SetAction(19,"������_���_����_���ǽ�");
			SetAction(20,"������_���_����_���ǽ�");
			SetAction(21,"������_���_����_���ǽ�");
			SetAction(22,"������_���_����_���ǽ�");
			SetAction(23,"������_���_����_���ǽ�");
			SetAction(24,"������_���_����_���ǽ�");
			SetAction(25,"����_���_����_Ѫ��ǹ");
			SetAction(26,"����_���_����_������");
			SetAction(27,"��ԯ_���_����_������");
			SetAction(28,"����_���_����_�ƾ�");
			SetAction(29,"̫�_���_����_������");
			SetAction(30,"�컪_���_����_�Ƿ�");
			name = "�С�����ɷѪ";
			nativename = "�С�����ɷѪ";
			icon = "����ɷѪ.dds";
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

			return ((-15 * skill_level) - skill_level * skill_level + 185);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();

			victim.SetTime(((2000 * skill_level + 2100)));
			victim.SetAmount(((2 * norm(skill_level / 4.9f) + (norm(skill_level / 3.9f) + skill_level))));
			victim.SetValue(((12 * skill_level + 6)));
			victim.SetCursed(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();

			victim.SetProbability(120.0f);
			victim.SetTime(((2000 * skill_level + 7100)));
			victim.SetRatio(1.0f);
			victim.SetAmount(((2 * norm(skill_level / 4.9f) + (norm(skill_level / 3.9f) + skill_level))));
			victim.SetValue(((skill_level * skill_level + (2 * skill_level) + 6)));
			victim.SetFrenzied(true);
			return true;
		}
	}
	public class GSkill4480 : GSkill
	{
		public GSkill4480()
			: base(4480)
		{
			
		}
	}
	public class GSkill4481Stub : GSkillStub
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

				skill.SetRatio((D2INT(player_level / (11 - skill_level)) * 0.01f + (skill_level * 0.03f + 1.0f)));
				skill.SetPlus(((60 * skill_level)));
				player.SetPerform(1);
			}
		}
		public GSkill4481Stub()
			: base(4481)
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
			SetAction(0,"����_����_������");
			SetAction(1,"������_����_�����");
			SetAction(2,"������_����_�����");
			SetAction(3,"������_����_�����");
			SetAction(4,"������_����_�����");
			SetAction(5,"������_����_�����");
			SetAction(6,"������_����_�����");
			SetAction(7,"����_����_Ѫ��ǹ");
			SetAction(8,"����_����_������");
			SetAction(9,"��ԯ_����_������");
			SetAction(10,"����_����_�ƾ�");
			SetAction(11,"̫�_����_������");
			SetAction(12,"�컪_����_�Ƿ�");
			SetAction(13,"01");
			SetAction(14,"01");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"����_���_����_������");
			SetAction(19,"������_���_����_�����");
			SetAction(20,"������_���_����_�����");
			SetAction(21,"������_���_����_�����");
			SetAction(22,"������_���_����_�����");
			SetAction(23,"������_���_����_�����");
			SetAction(24,"������_���_����_�����");
			SetAction(25,"����_���_����_Ѫ��ǹ");
			SetAction(26,"����_���_����_������");
			SetAction(27,"��ԯ_���_����_������");
			SetAction(28,"����_���_����_�ƾ�");
			SetAction(29,"̫�_���_����_������");
			SetAction(30,"�컪_���_����_�Ƿ�");
			name = "�С����Ƿ���";
			nativename = "�С����Ƿ���";
			icon = "���Ƿ���.dds";
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

			return ((-15 * skill_level) - skill_level * skill_level + 195);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_maxmp = player.GetMaxmp();
			int				skill_level = skill.GetLevel();

			/*
			victim.SetProbability(((8 * skill_level + 26)));
			victim.SetTime(((30100 - 2000 * skill_level)));
			victim.SetBuffid(4);
			victim.SetAmount(256.0f);
			victim.SetCycsubdefence(true);
			v25 = 3 * skill_level + 13;
			if ( skill_level == 5 )
			v24 = (v25 + 5);
			else
			victim.SetProbability(v25);
			if ( skill_level == 5 )
			v23 = 2.0f;
			else
			victim.SetAmount(1.0f);
			victim.SetClearbuff(true);
			victim.SetProbability(-1.0f);
			victim.SetTime(6100.0f);
			victim.SetBuffid(4);
			victim.SetAmount((skill_level * (player_maxmp * 0.2f)));
			victim.SetValue(0.0f);
			victim.SetMpleak(true);
			*/
			return true;
		}
	}
	public class GSkill4481 : GSkill
	{
		public GSkill4481()
			: base(4481)
		{
			
		}
	}
	public class GSkill4482Stub : GSkillStub
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

				skill.SetRatio((D2INT(player_level / (11 - skill_level)) * 0.01f + (skill_level * 0.03f + 1.0f)));
				skill.SetPlus(((60 * skill_level)));
				player.SetPerform(1);
			}
		}
		public GSkill4482Stub()
			: base(4482)
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
			SetAction(0,"����_����_�ƾ�");
			SetAction(1,"������_����_�����");
			SetAction(2,"������_����_�����");
			SetAction(3,"������_����_�����");
			SetAction(4,"������_����_�����");
			SetAction(5,"������_����_�����");
			SetAction(6,"������_����_�����");
			SetAction(7,"����_����_Ѫ��ǹ");
			SetAction(8,"����_����_������");
			SetAction(9,"��ԯ_����_������");
			SetAction(10,"����_����_�ƾ�");
			SetAction(11,"̫�_����_������");
			SetAction(12,"�컪_����_�Ƿ�");
			SetAction(13,"01");
			SetAction(14,"01");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"����_���_����_�ƾ�");
			SetAction(19,"������_���_����_�����");
			SetAction(20,"������_���_����_�����");
			SetAction(21,"������_���_����_�����");
			SetAction(22,"������_���_����_�����");
			SetAction(23,"������_���_����_�����");
			SetAction(24,"������_���_����_�����");
			SetAction(25,"����_���_����_Ѫ��ǹ");
			SetAction(26,"����_���_����_������");
			SetAction(27,"��ԯ_���_����_������");
			SetAction(28,"����_���_����_�ƾ�");
			SetAction(29,"̫�_���_����_������");
			SetAction(30,"�컪_���_����_�Ƿ�");
			name = "�С���ɨǧ��";
			nativename = "�С���ɨǧ��";
			icon = "��ɨǧ��.dds";
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

			return ((-15 * skill_level) - skill_level * skill_level + 195);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();

			victim.SetProbability(120.0f);
			victim.SetTime(12000.0f);
			victim.SetRatio((skill_level * 0.02f));
			victim.SetBuffid(0);
			victim.SetDecdefence(true);
			victim.SetTime(12000.0f);
			victim.SetRatio((skill_level * 0.02f));
			victim.SetBuffid(0);
			victim.SetDecskilldamage(true);
			return true;
		}
	}
	public class GSkill4482 : GSkill
	{
		public GSkill4482()
			: base(4482)
		{
			
		}
	}
	public class GSkill4483Stub : GSkillStub
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

				skill.SetRatio((D2INT(player_level / (11 - skill_level)) * 0.01f + (skill_level * 0.03f + 1.0f)));
				skill.SetPlus(((60 * skill_level)));
				player.SetPerform(1);
			}
		}
		public GSkill4483Stub()
			: base(4483)
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
			SetAction(0,"�컪_����_�Ƿ�");
			SetAction(1,"�ϻ���_����_���黷");
			SetAction(2,"�ϻ���_����_���黷");
			SetAction(3,"�ϻ���_����_���黷");
			SetAction(4,"�ϻ���_����_���黷");
			SetAction(5,"�ϻ���_����_���黷");
			SetAction(6,"�ϻ���_����_���黷");
			SetAction(7,"����_����_Ѫ��ǹ");
			SetAction(8,"����_����_������");
			SetAction(9,"��ԯ_����_������");
			SetAction(10,"����_����_�ƾ�");
			SetAction(11,"̫�_����_������");
			SetAction(12,"�컪_����_�Ƿ�");
			SetAction(13,"01");
			SetAction(14,"01");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"�컪_���_����_�Ƿ�");
			SetAction(19,"�ϻ���_���_����_���黷");
			SetAction(20,"�ϻ���_���_����_���黷");
			SetAction(21,"�ϻ���_���_����_���黷");
			SetAction(22,"�ϻ���_���_����_���黷");
			SetAction(23,"�ϻ���_���_����_���黷");
			SetAction(24,"�ϻ���_���_����_���黷");
			SetAction(25,"����_���_����_Ѫ��ǹ");
			SetAction(26,"����_���_����_������");
			SetAction(27,"��ԯ_���_����_������");
			SetAction(28,"����_���_����_�ƾ�");
			SetAction(29,"̫�_���_����_������");
			SetAction(30,"�컪_���_����_�Ƿ�");
			name = "�С������";
			nativename = "�С������";
			icon = "�����.dds";
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

			return ((-15 * skill_level) - skill_level * skill_level + 195);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_hp = player.GetHp();
			int				skill_level = skill.GetLevel();

			victim.SetProbability(((25 * skill_level + 75)));
			victim.SetTime(((500 * skill_level + 1000)));
			victim.SetRatio(((skill_level + 1) * 0.05f));
			victim.SetBuffid(1);
			victim.SetSlow(true);
			victim.SetProbability(-1.0f);
			victim.SetTime(2000.0f);
			victim.SetBuffid(1);
			victim.SetAmount((player_hp * (skill_level * 0.02f + 0.02f)));
			victim.SetValue(0.0f);
			victim.SetHpleak(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();

			victim.SetProbability(((2 * skill_level + 2)));
			victim.SetTime(2000.0f);
			victim.SetBuffid(1);
			victim.SetAmount(((18 * skill_level * skill_level)));
			victim.SetValue(1.0f);
			victim.SetMpgen(true);
			return true;
		}
	}
	public class GSkill4483 : GSkill
	{
		public GSkill4483()
			: base(4483)
		{
			
		}
	}
	public class GSkill4484Stub : GSkillStub
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

				skill.SetRatio((D2INT(player_level / (11 - skill_level)) * 0.01f + (skill_level * 0.05f + 1.0f)));
				skill.SetPlus(((60 * skill_level)));
				player.SetPerform(1);
			}
		}
		public GSkill4484Stub()
			: base(4484)
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
			SetAction(0,"̫�_����_������");
			SetAction(1,"���_����_��ɲ");
			SetAction(2,"���_����_��ɲ");
			SetAction(3,"���_����_��ɲ");
			SetAction(4,"���_����_��ɲ");
			SetAction(5,"���_����_��ɲ");
			SetAction(6,"���_����_��ɲ");
			SetAction(7,"����_����_Ѫ��ǹ");
			SetAction(8,"����_����_������");
			SetAction(9,"��ԯ_����_������");
			SetAction(10,"����_����_�ƾ�");
			SetAction(11,"̫�_����_������");
			SetAction(12,"�컪_����_�Ƿ�");
			SetAction(13,"01");
			SetAction(14,"01");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"̫�_���_����_������");
			SetAction(19,"���_���_����_��ɲ");
			SetAction(20,"���_���_����_��ɲ");
			SetAction(21,"���_���_����_��ɲ");
			SetAction(22,"���_���_����_��ɲ");
			SetAction(23,"���_���_����_��ɲ");
			SetAction(24,"���_���_����_��ɲ");
			SetAction(25,"����_���_����_Ѫ��ǹ");
			SetAction(26,"����_���_����_������");
			SetAction(27,"��ԯ_���_����_������");
			SetAction(28,"����_���_����_�ƾ�");
			SetAction(29,"̫�_���_����_������");
			SetAction(30,"�컪_���_����_�Ƿ�");
			name = "�С���������";
			nativename = "�С���������";
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
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_res3 = player.GetRes3();
			int				skill_level = skill.GetLevel();

			/*
			victim.SetProbability(((8 * skill_level + 26)));
			victim.SetTime(((30100 - 2000 * skill_level)));
			victim.SetBuffid(3);
			victim.SetAmount(256.0f);
			victim.SetCycsubdefence(true);
			v27 = 5 * skill_level + 10;
			if ( skill_level == 5 )
			{
			v26 = (v27 + player_res3);
			}
			else
			{
			v26 = v27;
			}
			victim.SetProbability(v26);
			victim.SetTime(((1000 * skill_level)));
			victim.SetWrap(true);
			if ( player.GetHasbuff(4099) == 1 )
			v25 = (8 * skill_level + 10);
			else
			victim.SetProbability(0.0f);
			victim.SetTime(((1000 * skill_level + 4000)));
			victim.SetRatio((skill_level * 0.08f));
			victim.SetValue((skill_level * 0.08f));
			victim.SetParalysis(true);
			*/
			return true;
		}
	}
	public class GSkill4484 : GSkill
	{
		public GSkill4484()
			: base(4484)
		{
			
		}
	}
	public class GSkill4485Stub : GSkillStub
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

				skill.SetRatio((D2INT(player_level / (11 - skill_level)) * 0.01f + (skill_level * 0.03f + 1.0f)));
				skill.SetPlus(((60 * skill_level)));
				player.SetPerform(1);
			}
		}
		public GSkill4485Stub()
			: base(4485)
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
			SetAction(0,"��ԯ_����_������");
			SetAction(1,"�����_����_�����");
			SetAction(2,"�����_����_�����");
			SetAction(3,"�����_����_�����");
			SetAction(4,"�����_����_�����");
			SetAction(5,"�����_����_�����");
			SetAction(6,"�����_����_�����");
			SetAction(7,"����_����_Ѫ��ǹ");
			SetAction(8,"����_����_������");
			SetAction(9,"��ԯ_����_������");
			SetAction(10,"����_����_�ƾ�");
			SetAction(11,"̫�_����_������");
			SetAction(12,"�컪_����_�Ƿ�");
			SetAction(13,"01");
			SetAction(14,"01");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"��ԯ_���_����_������");
			SetAction(19,"�����_���_����_�����");
			SetAction(20,"�����_���_����_�����");
			SetAction(21,"�����_���_����_�����");
			SetAction(22,"�����_���_����_�����");
			SetAction(23,"�����_���_����_�����");
			SetAction(24,"�����_���_����_�����");
			SetAction(25,"����_���_����_Ѫ��ǹ");
			SetAction(26,"����_���_����_������");
			SetAction(27,"��ԯ_���_����_������");
			SetAction(28,"����_���_����_�ƾ�");
			SetAction(29,"̫�_���_����_������");
			SetAction(30,"�컪_���_����_�Ƿ�");
			name = "�С��׹�����";
			nativename = "�С��׹�����";
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
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_hp = player.GetHp();
			int				skill_level = skill.GetLevel();

			victim.SetProbability(((25 * skill_level + 75)));
			victim.SetTime(((1000 * skill_level + 1000)));
			victim.SetSilent(true);
			victim.SetProbability(-1.0f);
			victim.SetTime(2000.0f);
			victim.SetBuffid(1);
			victim.SetAmount(((skill_level + 4) * (player_hp * 0.01f)));
			victim.SetValue(0.0f);
			victim.SetHpleak(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();

			victim.SetProbability(((2 * skill_level + 2)));
			victim.SetTime(12000.0f);
			victim.SetBuffid(1);
			victim.SetValue(((6 * skill_level + 38)));
			victim.SetAddattack(true);
			return true;
		}
	}
	public class GSkill4485 : GSkill
	{
		public GSkill4485()
			: base(4485)
		{
			
		}
	}
	public class GSkill4486Stub : GSkillStub
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
				int				skill_level = skill.GetLevel();
				int				skill_t0 = skill.GetT0();
				int				skill_t1 = skill.GetT1();
				int				skill_t2 = skill.GetT2();

				skill.SetCrit((skill_t1 * 0.02f));
				skill.SetRatio(((skill_t0 + 1) * (D2INT((player_mp / 0.95f) / player_maxmp) * 0.12f) + (D2INT(player_level / (10 - skill_level)) * 0.01f + (skill_t0 * 0.08f + (skill_level * 0.05f + 1.0f)))));
				skill.SetPlus((player_def * (skill_t2 * 0.03f) + ((120 * skill_level))));
				player.SetPerform(1);
			}
		}
		public GSkill4486Stub()
			: base(4486)
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
			SetAction(0,"���_����_�������");
			SetAction(1,"������_����_�������");
			SetAction(2,"������_����_�������");
			SetAction(3,"�ϻ���_����_�������");
			SetAction(4,"������_����_�������");
			SetAction(5,"���_����_�������");
			SetAction(6,"���_����_�������");
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
			SetAction(18,"���_���_����_�������");
			SetAction(19,"������_���_����_�������");
			SetAction(20,"������_���_����_�������");
			SetAction(21,"�ϻ���_���_����_�������");
			SetAction(22,"������_���_����_�������");
			SetAction(23,"���_���_����_�������");
			SetAction(24,"���_���_����_�������");
			SetAction(25,"����_���_����_��");
			SetAction(26,"����_���_����_��Ӱ�ž�");
			SetAction(27,"��ԯ_���_����_��ؽ�Ǯ");
			SetAction(28,"����_���_����_̰��");
			SetAction(29,"̫�_���_����_��ĸ������");
			SetAction(30,"�컪_���_����_����յ");
			name = "�С�ǧ�Ѥ��";
			nativename = "�С�ǧ�Ѥ��";
			icon = "ǧ�Ѥ��.dds";
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

			victim.SetTime(((1000 * skill_t0 + 5100)));
			victim.SetRatio((zrand(3 * skill_level + 17) / 100.0f + (skill_level * 0.01f)));
			victim.SetBuffid(1);
			victim.SetDecskilldamage(true);
			victim.SetProbability(((25 * skill_level + 100)));
			victim.SetTime(((500 * skill_t0 + 3100)));
			victim.SetWrap(true);
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
	public class GSkill4486 : GSkill
	{
		public GSkill4486()
			: base(4486)
		{
			
		}
	}
	public class GSkill4487Stub : GSkillStub
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
		public GSkill4487Stub()
			: base(4487)
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
			SetAction(0,"������_����_Ǭ������");
			SetAction(1,"������_����_Ǭ������");
			SetAction(2,"������_����_Ǭ������");
			SetAction(3,"�ϻ���_����_Ǭ������");
			SetAction(4,"������_����_Ǭ������");
			SetAction(5,"���_����_Ǭ������");
			SetAction(6,"���_����_Ǭ������");
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
			SetAction(18,"������_���_����_Ǭ������");
			SetAction(19,"������_���_����_Ǭ������");
			SetAction(20,"������_���_����_Ǭ������");
			SetAction(21,"�ϻ���_���_����_Ǭ������");
			SetAction(22,"������_���_����_Ǭ������");
			SetAction(23,"���_���_����_Ǭ������");
			SetAction(24,"���_���_����_Ǭ������");
			SetAction(25,"����_���_����_��");
			SetAction(26,"����_���_����_��Ӱ�ž�");
			SetAction(27,"��ԯ_���_����_��ؽ�Ǯ");
			SetAction(28,"����_���_����_̰��");
			SetAction(29,"̫�_���_����_��ĸ������");
			SetAction(30,"�컪_���_����_����յ");
			name = "�С����է��";
			nativename = "�С����է��";
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
	public class GSkill4487 : GSkill
	{
		public GSkill4487()
			: base(4487)
		{
			
		}
	}
	public class GSkill4488Stub : GSkillStub
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
		public GSkill4488Stub()
			: base(4488)
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
			SetAction(0,"������_����_����Ǭ����");
			SetAction(1,"������_����_����Ǭ����");
			SetAction(2,"������_����_����Ǭ����");
			SetAction(3,"�ϻ���_����_����Ǭ����");
			SetAction(4,"������_����_����Ǭ����");
			SetAction(5,"���_����_����Ǭ����");
			SetAction(6,"���_����_����Ǭ����");
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
			SetAction(18,"������_���_����_����Ǭ����");
			SetAction(19,"������_���_����_����Ǭ����");
			SetAction(20,"������_���_����_����Ǭ����");
			SetAction(21,"�ϻ���_���_����_����Ǭ����");
			SetAction(22,"������_���_����_����Ǭ����");
			SetAction(23,"���_���_����_����Ǭ����");
			SetAction(24,"���_���_����_����Ǭ����");
			SetAction(25,"����_���_����_��");
			SetAction(26,"����_���_����_��Ӱ�ž�");
			SetAction(27,"��ԯ_���_����_��ؽ�Ǯ");
			SetAction(28,"����_���_����_̰��");
			SetAction(29,"̫�_���_����_��ĸ������");
			SetAction(30,"�컪_���_����_����յ");
			name = "�С�Ǭ������";
			nativename = "�С�Ǭ������";
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
	public class GSkill4488 : GSkill
	{
		public GSkill4488()
			: base(4488)
		{
			
		}
	}
	public class GSkill4489Stub : GSkillStub
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
		public GSkill4489Stub()
			: base(4489)
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
			SetAction(0,"������_����_����");
			SetAction(1,"������_����_����");
			SetAction(2,"������_����_����");
			SetAction(3,"�ϻ���_����_����");
			SetAction(4,"������_����_����");
			SetAction(5,"���_����_����");
			SetAction(6,"���_����_����");
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
			SetAction(18,"������_���_����_����");
			SetAction(19,"������_���_����_����");
			SetAction(20,"������_���_����_����");
			SetAction(21,"�ϻ���_���_����_����");
			SetAction(22,"������_���_����_����");
			SetAction(23,"���_���_����_����");
			SetAction(24,"���_���_����_����");
			SetAction(25,"����_���_����_��");
			SetAction(26,"����_���_����_��Ӱ�ž�");
			SetAction(27,"��ԯ_���_����_��ؽ�Ǯ");
			SetAction(28,"����_���_����_̰��");
			SetAction(29,"̫�_���_����_��ĸ������");
			SetAction(30,"�컪_���_����_����յ");
			name = "�С������޼�";
			nativename = "�С������޼�";
			icon = "�����޼�.dds";
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
			int				skill_t0 = skill.GetT0();

			victim.SetProbability(((35 * skill_level + 85)));
			victim.SetTime(((2000 * skill_level + 4100)));
			victim.SetValue(0.0f);
			victim.SetSleep(true);
			victim.SetProbability(((1.0f - player_level * 0.002f) * 50.0f));
			victim.SetRatio((skill_t0 * 0.09f + 0.36f));
			victim.SetXiaoxin(true);
			victim.SetProbability(100.0f);
			victim.SetTime(12000.0f);
			victim.SetBuffid(1);
			victim.SetAmount(((36 * skill_t0 + (48 * skill_level))));
			victim.SetCycsubdefence(true);
			return true;
		}
	}
	public class GSkill4489 : GSkill
	{
		public GSkill4489()
			: base(4489)
		{
			
		}
	}
}
