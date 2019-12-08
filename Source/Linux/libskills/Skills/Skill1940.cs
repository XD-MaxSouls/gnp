using System;
using System.Text;

namespace SKILL
{
	public class GSkill1940Stub : GSkillStub
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

				skill.SetRatio(1.75f);
				player.SetPerform(1);
			}
		}
		public GSkill1940Stub()
			: base(1940)
		{
			occupation = 151;
			maxlevel = 1;
			maxlearn = 1;
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
			allowform = 7;
			credittype = 0;
			clearmask = 0;
			skill_limit = 32;
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
			SetAction(0,"������_�ͻ�");
			SetAction(1,"������_�ͻ�");
			SetAction(2,"������_�ͻ�");
			SetAction(3,"�ϻ���_�ͻ�");
			SetAction(4,"������_�ͻ�");
			SetAction(5,"���_�ͻ�");
			SetAction(6,"����_�ͻ�");
			SetAction(7,"����_�ͻ�");
			SetAction(8,"����_�ͻ�");
			SetAction(9,"��ԯ_�ͻ�");
			SetAction(10,"����_�ͻ�");
			SetAction(11,"̫�_�ͻ�");
			SetAction(12,"�컪_�ͻ�");
			SetAction(13,"����_�ͻ�");
			SetAction(14,"Ӣ��_�ͻ�");
			SetAction(15,"Ԫ�ش�ʦ_�ͻ�");
			SetAction(16,"Ԫ�ش�ʦ_�ͻ�");
			SetAction(17,"������_�ͻ�");
			SetAction(18,"������_���_�ͻ�");
			SetAction(19,"������_���_�ͻ�");
			SetAction(20,"������_���_�ͻ�");
			SetAction(21,"�ϻ���_���_�ͻ�");
			SetAction(22,"������_���_�ͻ�");
			SetAction(23,"���_���_�ͻ�");
			SetAction(24,"����_���_�ͻ�");
			SetAction(25,"����_���_�ͻ�");
			SetAction(26,"����_���_�ͻ�");
			SetAction(27,"��ԯ_���_�ͻ�");
			SetAction(28,"����_���_�ͻ�");
			SetAction(29,"̫�_���_�ͻ�");
			SetAction(30,"�컪_���_�ͻ�");
			name = "�ͻ�";
			nativename = "�ͻ�";
			icon = "�ͻ�.dds";
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
			return 1000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			return 16000;
		}
		public override float GetPraydistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return (D2INT((player_range / 13.0f)) * 2.8f + (D2INT(player_range / 8.9f) * 1.8f + ((player_range * 0.5f) - D2INT(player_range / 3.9f) * 0.3f)) + 2.0f);
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

			return (D2INT((player_range / 13.0f)) * 2.8f + (D2INT(player_range / 8.9f) * 1.8f + ((player_range * 0.5f) - D2INT(player_range / 3.9f) * 0.3f)) + 3.0f);
		}
	}
	public class GSkill1940 : GSkill
	{
		public GSkill1940()
			: base(1940)
		{
			
		}
	}
	public class GSkill1941Stub : GSkillStub
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
		public GSkill1941Stub()
			: base(1941)
		{
			occupation = 151;
			maxlevel = 1;
			maxlearn = 1;
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
			allowform = 7;
			credittype = 0;
			clearmask = 0;
			skill_limit = 32;
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
			SetAction(0,"������_����");
			SetAction(1,"������_����");
			SetAction(2,"������_����");
			SetAction(3,"�ϻ���_����");
			SetAction(4,"������_����");
			SetAction(5,"���_����");
			SetAction(6,"����_����");
			SetAction(7,"����_����");
			SetAction(8,"����_����");
			SetAction(9,"��ԯ_����");
			SetAction(10,"����_����");
			SetAction(11,"̫�_����");
			SetAction(12,"�컪_����");
			SetAction(13,"����_����");
			SetAction(14,"Ӣ��_����");
			SetAction(15,"Ԫ�ش�ʦ_����");
			SetAction(16,"Ԫ�ش�ʦ_����");
			SetAction(17,"������_����");
			SetAction(18,"������_���_����");
			SetAction(19,"������_���_����");
			SetAction(20,"������_���_����");
			SetAction(21,"�ϻ���_���_����");
			SetAction(22,"������_���_����");
			SetAction(23,"���_���_����");
			SetAction(24,"����_���_����");
			SetAction(25,"����_���_����");
			SetAction(26,"����_���_����");
			SetAction(27,"��ԯ_���_����");
			SetAction(28,"����_���_����");
			SetAction(29,"̫�_���_����");
			SetAction(30,"�컪_���_����");
			name = "����";
			nativename = "����";
			icon = "����.dds";
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
			return 1000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			return 90000;
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
			int				player_maxmp = player.GetMaxmp();

			victim.SetProbability(120.0f);
			victim.SetTime(20000.0f);
			victim.SetBuffid(1);
			victim.SetAmount(0.0f);
			victim.SetValue(((3 * player_maxmp)));
			victim.SetMpgen(true);
			return true;
		}
	}
	public class GSkill1941 : GSkill
	{
		public GSkill1941()
			: base(1941)
		{
			
		}
	}
	public class GSkill1942Stub : GSkillStub
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
		public GSkill1942Stub()
			: base(1942)
		{
			occupation = 151;
			maxlevel = 4;
			maxlearn = 4;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 3;
			timetype = 0;
			targettype = 0;
			rangetype = 0;
			doenchant = true;
			dobless = false;
			autoattack = false;
			allowform = 7;
			credittype = 0;
			clearmask = 0;
			skill_limit = 32;
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
			SetAction(0,"������_ɢ��");
			SetAction(1,"������_ɢ��");
			SetAction(2,"������_ɢ��");
			SetAction(3,"�ϻ���_ɢ��");
			SetAction(4,"������_ɢ��");
			SetAction(5,"���_ɢ��");
			SetAction(6,"����_ɢ��");
			SetAction(7,"����_ɢ��");
			SetAction(8,"����_ɢ��");
			SetAction(9,"��ԯ_ɢ��");
			SetAction(10,"����_ɢ��");
			SetAction(11,"̫�_ɢ��");
			SetAction(12,"�컪_ɢ��");
			SetAction(13,"����_ɢ��");
			SetAction(14,"Ӣ��_ɢ��");
			SetAction(15,"Ԫ�ش�ʦ_ɢ��");
			SetAction(16,"Ԫ�ش�ʦ_ɢ��");
			SetAction(17,"������_ɢ��");
			SetAction(18,"������_���_ɢ��");
			SetAction(19,"������_���_ɢ��");
			SetAction(20,"������_���_ɢ��");
			SetAction(21,"�ϻ���_���_ɢ��");
			SetAction(22,"������_���_ɢ��");
			SetAction(23,"���_���_ɢ��");
			SetAction(24,"����_���_ɢ��");
			SetAction(25,"����_���_ɢ��");
			SetAction(26,"����_���_ɢ��");
			SetAction(27,"��ԯ_���_ɢ��");
			SetAction(28,"����_���_ɢ��");
			SetAction(29,"̫�_���_ɢ��");
			SetAction(30,"�컪_���_ɢ��");
			name = "ɢ��";
			nativename = "ɢ��";
			icon = "ɢ��.dds";
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
			return 1000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			return 90000;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 17.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 12.000000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 22.000000f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();

			victim.SetProbability(120.0f);
			victim.SetTime(60000.0f);
			victim.SetBuffid(1);
			victim.SetAmount(((18000 * (D2INT(skill_level / 4) + skill_level) + 18000)));
			victim.SetValue(0.0f);
			victim.SetMpleak(true);
			return true;
		}
	}
	public class GSkill1942 : GSkill
	{
		public GSkill1942()
			: base(1942)
		{
			
		}
	}
	public class GSkill1943Stub : GSkillStub
	{
		public class GState1 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 1800;
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

				skill.SetRatio(2.2f);
				player.SetPerform(1);
			}
		}
		public GSkill1943Stub()
			: base(1943)
		{
			occupation = 151;
			maxlevel = 1;
			maxlearn = 1;
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
			allowform = 7;
			credittype = 0;
			clearmask = 0;
			skill_limit = 32;
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
			SetAction(6,"����_��������");
			SetAction(7,"����_��������");
			SetAction(8,"����_��������");
			SetAction(9,"��ԯ_��������");
			SetAction(10,"����_��������");
			SetAction(11,"̫�_��������");
			SetAction(12,"�컪_��������");
			SetAction(13,"����_��������");
			SetAction(14,"Ӣ��_��������");
			SetAction(15,"Ԫ�ش�ʦ_��������");
			SetAction(16,"Ԫ�ش�ʦ_��������");
			SetAction(17,"������_��������");
			SetAction(18,"������_���_��������");
			SetAction(19,"������_���_��������");
			SetAction(20,"������_���_��������");
			SetAction(21,"�ϻ���_���_��������");
			SetAction(22,"������_���_��������");
			SetAction(23,"���_���_��������");
			SetAction(24,"����_���_��������");
			SetAction(25,"����_���_��������");
			SetAction(26,"����_���_��������");
			SetAction(27,"��ԯ_���_��������");
			SetAction(28,"����_���_��������");
			SetAction(29,"̫�_���_��������");
			SetAction(30,"�컪_���_��������");
			name = "��Ϊ";
			nativename = "��Ϊ";
			icon = "����֮����.dds";
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
			return 90000;
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
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetProbability(600.0f);
			victim.SetTime(6000.0f);
			victim.SetDizzy(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetTime(15000.0f);
			victim.SetRatio(0.15000001f);
			victim.SetInccritrate(true);
			return true;
		}
	}
	public class GSkill1943 : GSkill
	{
		public GSkill1943()
			: base(1943)
		{
			
		}
	}
	public class GSkill1944Stub : GSkillStub
	{
		public class GState1 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 1800;
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

				skill.SetRatio(2.2f);
				player.SetPerform(1);
			}
		}
		public GSkill1944Stub()
			: base(1944)
		{
			occupation = 151;
			maxlevel = 1;
			maxlearn = 1;
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
			allowform = 7;
			credittype = 0;
			clearmask = 0;
			skill_limit = 32;
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
			SetAction(0,"������_ѩ��֮��˪");
			SetAction(1,"������_ѩ��֮��˪");
			SetAction(2,"������_ѩ��֮��˪");
			SetAction(3,"�ϻ���_ѩ��֮��˪");
			SetAction(4,"������_ѩ��֮��˪");
			SetAction(5,"���_ѩ��֮��˪");
			SetAction(6,"����_ѩ��֮��˪");
			SetAction(7,"����_ѩ��֮��˪");
			SetAction(8,"����_ѩ��֮��˪");
			SetAction(9,"��ԯ_ѩ��֮��˪");
			SetAction(10,"����_ѩ��֮��˪");
			SetAction(11,"̫�_ѩ��֮��˪");
			SetAction(12,"�컪_ѩ��֮��˪");
			SetAction(13,"����_ѩ��֮��˪");
			SetAction(14,"Ӣ��_ѩ��֮��˪");
			SetAction(15,"Ԫ�ش�ʦ_ѩ��֮��˪");
			SetAction(16,"Ԫ�ش�ʦ_ѩ��֮��˪");
			SetAction(17,"������_ѩ��֮��˪");
			SetAction(18,"������_���_ѩ��֮��˪");
			SetAction(19,"������_���_ѩ��֮��˪");
			SetAction(20,"������_���_ѩ��֮��˪");
			SetAction(21,"�ϻ���_���_ѩ��֮��˪");
			SetAction(22,"������_���_ѩ��֮��˪");
			SetAction(23,"���_���_ѩ��֮��˪");
			SetAction(24,"����_���_ѩ��֮��˪");
			SetAction(25,"����_���_ѩ��֮��˪");
			SetAction(26,"����_���_ѩ��֮��˪");
			SetAction(27,"��ԯ_���_ѩ��֮��˪");
			SetAction(28,"����_���_ѩ��֮��˪");
			SetAction(29,"̫�_���_ѩ��֮��˪");
			SetAction(30,"�컪_���_ѩ��֮��˪");
			name = "����";
			nativename = "����";
			icon = "ѩ��֮��˪.dds";
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
			return 90000;
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
		public override float GetEffectdistance(GSkill skill)
		{
			return 20.000000f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetProbability(600.0f);
			victim.SetTime(12000.0f);
			victim.SetWrap(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetProbability(120.0f);
			victim.SetTime(15000.0f);
			victim.SetRatio(0.99000001f);
			victim.SetBuffid(1);
			victim.SetIncskilldodge(true);
			return true;
		}
	}
	public class GSkill1944 : GSkill
	{
		public GSkill1944()
			: base(1944)
		{
			
		}
	}
	public class GSkill1945Stub : GSkillStub
	{
		public class GState1 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 1800;
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

				skill.SetRatio(2.2f);
				player.SetPerform(1);
			}
		}
		public GSkill1945Stub()
			: base(1945)
		{
			occupation = 151;
			maxlevel = 1;
			maxlearn = 1;
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
			allowform = 7;
			credittype = 0;
			clearmask = 0;
			skill_limit = 32;
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
			SetAction(0,"������_����ֿ֮��");
			SetAction(1,"������_����ֿ֮��");
			SetAction(2,"������_����ֿ֮��");
			SetAction(3,"�ϻ���_����ֿ֮��");
			SetAction(4,"������_����ֿ֮��");
			SetAction(5,"���_����ֿ֮��");
			SetAction(6,"����_����ֿ֮��");
			SetAction(7,"����_����ֿ֮��");
			SetAction(8,"����_����ֿ֮��");
			SetAction(9,"��ԯ_����ֿ֮��");
			SetAction(10,"����_����ֿ֮��");
			SetAction(11,"̫�_����ֿ֮��");
			SetAction(12,"�컪_����ֿ֮��");
			SetAction(13,"����_����ֿ֮��");
			SetAction(14,"Ӣ��_����ֿ֮��");
			SetAction(15,"Ԫ�ش�ʦ_����ֿ֮��");
			SetAction(16,"Ԫ�ش�ʦ_����ֿ֮��");
			SetAction(17,"������_����ֿ֮��");
			SetAction(18,"������_���_����ֿ֮��");
			SetAction(19,"������_���_����ֿ֮��");
			SetAction(20,"������_���_����ֿ֮��");
			SetAction(21,"�ϻ���_���_����ֿ֮��");
			SetAction(22,"������_���_����ֿ֮��");
			SetAction(23,"���_���_����ֿ֮��");
			SetAction(24,"����_���_����ֿ֮��");
			SetAction(25,"����_���_����ֿ֮��");
			SetAction(26,"����_���_����ֿ֮��");
			SetAction(27,"��ԯ_���_����ֿ֮��");
			SetAction(28,"����_���_����ֿ֮��");
			SetAction(29,"̫�_���_����ֿ֮��");
			SetAction(30,"�컪_���_����ֿ֮��");
			name = "����";
			nativename = "����";
			icon = "����ֿ֮��.dds";
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
			return 90000;
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
		public override float GetEffectdistance(GSkill skill)
		{
			return 20.000000f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetProbability(600.0f);
			victim.SetTime(9000.0f);
			victim.SetSilent(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetProbability(120.0f);
			victim.SetTime(15000.0f);
			victim.SetRatio(0.33000001f);
			victim.SetDecdamage(true);
			return true;
		}
	}
	public class GSkill1945 : GSkill
	{
		public GSkill1945()
			: base(1945)
		{
			
		}
	}
	public class GSkill1946Stub : GSkillStub
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

				skill.SetRatio(1.0f);
				skill.SetPlus(1.0f);
				player.SetPerform(1);
			}
		}
		public GSkill1946Stub()
			: base(1946)
		{
			occupation = 128;
			maxlevel = 10;
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
			name = "��������A";
			nativename = "��������A";
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
		public override int GetExecutetime(GSkill skill)
		{
			return 800;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			return 1000;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 10.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 6.000000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 14.000000f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_level = player.GetLevel();
			int				skill_level = skill.GetLevel();

			victim.SetRatio(((5 * ((norm((player_level + 0.05f) / 186.0f)) - norm((player_level + 0.05f) / 187.0f)))));
			victim.SetAmount(0.0f);
			victim.SetValue((((norm((player_level + 0.05f) / 169.0f)) - norm((player_level + 0.05f) / 170.0f))));
			victim.SetSecondattack(true);
			victim.SetProbability(((600 * norm(zrand(100) / (85 - 5 * skill_level)))));
			victim.SetTime(3000.0f);
			victim.SetWrap(true);
			return true;
		}
	}
	public class GSkill1946 : GSkill
	{
		public GSkill1946()
			: base(1946)
		{
			
		}
	}
	public class GSkill1947Stub : GSkillStub
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

				player.SetPerform(1);
			}
		}
		public GSkill1947Stub()
			: base(1947)
		{
			occupation = 128;
			maxlevel = 10;
			maxlearn = 10;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 5;
			timetype = 0;
			targettype = 0;
			rangetype = 2;
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
			name = "��������B";
			nativename = "��������B";
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
		public override int GetExecutetime(GSkill skill)
		{
			return 1000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			return 1000;
		}
		public override float GetRadius(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (4 * skill_level + 4);
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
		public override int GetCoverage(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return 4 * skill_level + 4;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();

			victim.SetProbability(120.0f);
			victim.SetTime(((5000 * skill_level + 5000)));
			victim.SetRatio((skill_level * 0.15f + 0.1f));
			victim.SetAmount(0.0f);
			victim.SetValue(100.0f);
			victim.SetRetort(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();

			victim.SetProbability(120.0f);
			victim.SetTime(((5000 * skill_level + 5000)));
			victim.SetRatio((skill_level * 0.15f + 0.1f));
			victim.SetAmount(0.0f);
			victim.SetValue(100.0f);
			victim.SetRetort(true);
			return true;
		}
	}
	public class GSkill1947 : GSkill
	{
		public GSkill1947()
			: base(1947)
		{
			
		}
	}
	public class GSkill1948Stub : GSkillStub
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

				player.SetPerform(1);
			}
		}
		public GSkill1948Stub()
			: base(1948)
		{
			occupation = 128;
			maxlevel = 10;
			maxlearn = 10;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 5;
			timetype = 0;
			targettype = 0;
			rangetype = 2;
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
			name = "��������C";
			nativename = "��������C";
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
		public override int GetExecutetime(GSkill skill)
		{
			return 1000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			return 1000;
		}
		public override float GetRadius(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (4 * skill_level + 4);
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
		public override int GetCoverage(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return 4 * skill_level + 4;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();

			victim.SetTime(((10000 * skill_level + 10000)));
			victim.SetRatio((skill_level * 0.1f + 0.1f));
			victim.SetAmount(((10000 * skill_level + 10000)));
			victim.SetDechurt(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();

			victim.SetTime(((10000 * skill_level + 10000)));
			victim.SetRatio((skill_level * 0.1f + 0.1f));
			victim.SetAmount(((10000 * skill_level + 10000)));
			victim.SetDechurt(true);
			return true;
		}
	}
	public class GSkill1948 : GSkill
	{
		public GSkill1948()
			: base(1948)
		{
			
		}
	}
	public class GSkill1949Stub : GSkillStub
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

				skill.SetRatio((skill_level * 0.02f + 1.1f));
				skill.SetPlus(((skill_level * (skill_level * 9.9f)) - skill_level * 8.6f + 858.0f));
				player.SetPerform(1);
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

				skill.SetRatio((skill_level * 0.04f + 1.1f));
				skill.SetPlus(((skill_level * (skill_level * 9.9f)) - skill_level * 8.6f + 858.0f));
				player.SetPerform(0);
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

				skill.SetRatio((skill_level * 0.06f + 1.1f));
				skill.SetPlus(((skill_level * (skill_level * 9.9f)) - skill_level * 8.6f + 858.0f));
				player.SetPerform(0);
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

				skill.SetRatio((skill_level * 0.08f + 1.1f));
				skill.SetPlus(((skill_level * (skill_level * 9.9f)) - skill_level * 8.6f + 858.0f));
				player.SetPerform(0);
			}
		}
		public GSkill1949Stub()
			: base(1949)
		{
			occupation = 128;
			maxlevel = 10;
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
			name = "��������D";
			nativename = "��������D";
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
			return 6000;
		}
		public override float GetPraydistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return player_range + 10.0f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return player_range + 3.0f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return player_range + 10.0f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_level = player.GetLevel();
			int				skill_level = skill.GetLevel();

			victim.SetProbability(((600 * norm(zrand(100) / (95 - 5 * skill_level)))));
			victim.SetTime(3000.0f);
			victim.SetWrap(true);
			victim.SetRatio(((2 * ((norm((player_level + 0.05f) / 186.0f)) - norm((player_level + 0.05f) / 187.0f)))));
			victim.SetAmount(0.0f);
			victim.SetValue((((norm((player_level + 0.05f) / 186.0f)) - norm((player_level + 0.05f) / 187.0f))));
			victim.SetSecondattack(true);
			return true;
		}
	}
	public class GSkill1949 : GSkill
	{
		public GSkill1949()
			: base(1949)
		{
			
		}
	}
}
