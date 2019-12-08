using System;
using System.Text;

namespace SKILL
{
	public class GSkill3900Stub : GSkillStub
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
		public GSkill3900Stub()
			: base(3900)
		{
			occupation = 128;
			maxlevel = 1;
			maxlearn = 0;
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
			skill_limit = 7;
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
			SetAction(0,"");
			SetAction(1,"");
			SetAction(2,"");
			SetAction(3,"");
			SetAction(4,"");
			SetAction(5,"");
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
			SetAction(18,"");
			SetAction(19,"");
			SetAction(20,"");
			SetAction(21,"");
			SetAction(22,"");
			SetAction(23,"");
			SetAction(24,"");
			SetAction(25,"");
			SetAction(26,"");
			SetAction(27,"");
			SetAction(28,"");
			SetAction(29,"");
			SetAction(30,"");
			name = "����֮��";
			nativename = "����֮��";
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
			return 60000;
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

			victim.SetProbability(100.0f);
			victim.SetTime(14400000.0f);
			victim.SetRatio(0.0f);
			victim.SetBuffid(1);
			victim.SetAmount(0.0f);
			victim.SetValue(720000.0f);
			victim.SetHpgen(true);
			victim.SetProbability(100.0f);
			victim.SetTime(14400000.0f);
			victim.SetBuffid(1);
			victim.SetAmount(0.0f);
			victim.SetValue(1440000.0f);
			victim.SetMpgen(true);
			return true;
		}
	}
	public class GSkill3900 : GSkill
	{
		public GSkill3900()
			: base(3900)
		{
			
		}
	}
	public class GSkill3901Stub : GSkillStub
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
		public GSkill3901Stub()
			: base(3901)
		{
			occupation = 128;
			maxlevel = 1;
			maxlearn = 0;
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
			SetAction(0,"���ܹ���3");
			SetAction(1,"���ܹ���3");
			SetAction(2,"���ܹ���3");
			SetAction(3,"���ܹ���3");
			SetAction(4,"���ܹ���3");
			SetAction(5,"���ܹ���3");
			SetAction(6,"���ܹ���3");
			SetAction(7,"���ܹ���3");
			SetAction(8,"���ܹ���3");
			SetAction(9,"���ܹ���3");
			SetAction(10,"���ܹ���3");
			SetAction(11,"���ܹ���3");
			SetAction(12,"���ܹ���3");
			SetAction(13,"���ܹ���3");
			SetAction(14,"���ܹ���3");
			SetAction(15,"���ܹ���3");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"���ܹ���3");
			SetAction(19,"���ܹ���3");
			SetAction(20,"���ܹ���3");
			SetAction(21,"���ܹ���3");
			SetAction(22,"���ܹ���3");
			SetAction(23,"���ܹ���3");
			SetAction(24,"���ܹ���3");
			SetAction(25,"���ܹ���3");
			SetAction(26,"���ܹ���3");
			SetAction(27,"���ܹ���3");
			SetAction(28,"���ܹ���3");
			SetAction(29,"���ܹ���3");
			SetAction(30,"���ܹ���3");
			name = "�򵹹�����";
			nativename = "�򵹹�����";
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
			return 2000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			return 4000;
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
			return 30.000000f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();

			/*
			if ( player.GetTmplid() != 52260
			|| (v3 = player, GNET::PlayerWrapper::GetRes1(v3) > 1999) )
			d = 0.0f;
			else
			victim.SetProbability(120.0f);
			victim.SetValue(5000.0f);
			victim.SetDirecthurt(true);
			*/
			return true;
		}
	}
	public class GSkill3901 : GSkill
	{
		public GSkill3901()
			: base(3901)
		{
			
		}
	}
	public class GSkill3902Stub : GSkillStub
	{
		public class GState1 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 100;
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
				return 100;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();

				player.SetPerform(1);
			}
		}
		public GSkill3902Stub()
			: base(3902)
		{
			occupation = 128;
			maxlevel = 1;
			maxlearn = 0;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 3;
			timetype = 0;
			targettype = 0;
			rangetype = 2;
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
			SetAction(0,"");
			SetAction(1,"");
			SetAction(2,"");
			SetAction(3,"");
			SetAction(4,"");
			SetAction(5,"");
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
			SetAction(18,"");
			SetAction(19,"");
			SetAction(20,"");
			SetAction(21,"");
			SetAction(22,"");
			SetAction(23,"");
			SetAction(24,"");
			SetAction(25,"");
			SetAction(26,"");
			SetAction(27,"");
			SetAction(28,"");
			SetAction(29,"");
			SetAction(30,"");
			name = "ˮ���ս_��ҵ�ˮ��";
			nativename = "ˮ���ս_��ҵ�ˮ��";
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
			return 200;
		}
		public override float GetRadius(GSkill skill)
		{
			return 5.000000f;
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

			/*
			if ( (player.GetTmplid() <= 52201
			|| (v3 = player, GNET::PlayerWrapper::GetTmplid(v3) > 52205))
			&& (v4 = player, GNET::PlayerWrapper::GetTmplid(v4) != 52340) )
			d = 0.0f;
			else
			victim.SetProbability(120.0f);
			victim.SetValue(10000.0f);
			victim.SetDirecthurt(true);
			*/
			return true;
		}
	}
	public class GSkill3902 : GSkill
	{
		public GSkill3902()
			: base(3902)
		{
			
		}
	}
	public class GSkill3903Stub : GSkillStub
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

				player.SetPerform(1);
			}
		}
		public class GState3 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 1000;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();

				player.SetPerform(0);
			}
		}
		public class GState4 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 1000;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_hp = player.GetHp();

				player.SetHp(((player_hp - 1000000)));
				player.SetPerform(0);
			}
		}
		public class GState5 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 1000;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();

				player.SetPerform(0);
			}
		}
		public GSkill3903Stub()
			: base(3903)
		{
			occupation = 129;
			maxlevel = 1;
			maxlearn = 0;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 1;
			timetype = 0;
			targettype = 0;
			rangetype = 6;
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
			SetAction(0,"������_˪��ѩ��");
			SetAction(1,"������_˪��ѩ��");
			SetAction(2,"������_˪��ѩ��");
			SetAction(3,"������_˪��ѩ��");
			SetAction(4,"������_˪��ѩ��");
			SetAction(5,"������_˪��ѩ��");
			SetAction(6,"������_˪��ѩ��");
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
			SetAction(18,"0");
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
			SetAction(30,"0");
			name = "������";
			nativename = "������";
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
			return 5000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			return 200;
		}
		public override float GetRadius(GSkill skill)
		{
			return 16.000000f;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 16.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 13.000000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 21.000000f;
		}
		public override int GetCoverage(GSkill skill)
		{
			return 6;
		}
	}
	public class GSkill3903 : GSkill
	{
		public GSkill3903()
			: base(3903)
		{
			
		}
	}
	public class GSkill3904Stub : GSkillStub
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
		public GSkill3904Stub()
			: base(3904)
		{
			occupation = 151;
			maxlevel = 1;
			maxlearn = 0;
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
			SetAction(0,"������_�ش�");
			SetAction(1,"������_�ش�");
			SetAction(2,"������_�ش�");
			SetAction(3,"�ϻ���_�ش�");
			SetAction(4,"������_�ش�");
			SetAction(5,"���_�ش�");
			SetAction(6,"�����_�ش�");
			SetAction(7,"����_�ش�");
			SetAction(8,"����_�ش�");
			SetAction(9,"��ԯ_�ش�");
			SetAction(10,"����_�ش�");
			SetAction(11,"̫�_�ش�");
			SetAction(12,"�컪_�ش�");
			SetAction(13,"����_�ش�");
			SetAction(14,"Ӣ��_�ش�");
			SetAction(15,"Ԫ�ش�ʦ_�ش�");
			SetAction(16,"Ԫ�ش�ʦ_�ش�");
			SetAction(17,"����_������Ѫ");
			SetAction(18,"������_���_�ش�");
			SetAction(19,"������_���_�ش�");
			SetAction(20,"������_���_�ش�");
			SetAction(21,"�ϻ���_���_�ش�");
			SetAction(22,"������_���_�ش�");
			SetAction(23,"���_���_�ش�");
			SetAction(24,"�����_���_�ش�");
			SetAction(25,"����_���_�ش�");
			SetAction(26,"����_���_�ش�");
			SetAction(27,"��ԯ_���_�ش�");
			SetAction(28,"����_���_�ش�");
			SetAction(29,"̫�_���_�ش�");
			SetAction(30,"�컪_���_�ش�");
			name = "���Ѫ��";
			nativename = "���Ѫ��";
			icon = "��ͨ_Ѫ��.dds";
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
			return 300000;
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
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return player_range;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_maxhp = player.GetMaxhp();
			int				player_maxmp = player.GetMaxmp();

			victim.SetProbability(100.0f);
			victim.SetTime(10000.0f);
			victim.SetRatio(0.0f);
			victim.SetBuffid(2);
			victim.SetAmount(0.0f);
			victim.SetValue((player_maxhp * 0.5f));
			victim.SetHpgen(true);
			victim.SetProbability(100.0f);
			victim.SetTime(10000.0f);
			victim.SetBuffid(2);
			victim.SetAmount(0.0f);
			victim.SetValue((player_maxmp * 0.5f));
			victim.SetMpgen(true);
			victim.SetProbability(100.0f);
			victim.SetTime(10000.0f);
			victim.SetBuffid(2);
			victim.SetAmount((player.GetMaxdp() * 0.5f));
			victim.SetValue(0.0f);
			victim.SetDivinityfury(true);
			return true;
		}
	}
	public class GSkill3904 : GSkill
	{
		public GSkill3904()
			: base(3904)
		{
			
		}
	}
	public class GSkill3905Stub : GSkillStub
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
		public GSkill3905Stub()
			: base(3905)
		{
			occupation = 151;
			maxlevel = 1;
			maxlearn = 0;
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
			SetAction(24,"�����_���_����");
			SetAction(25,"����_���_����");
			SetAction(26,"����_���_����");
			SetAction(27,"��ԯ_���_����");
			SetAction(28,"����_���_����");
			SetAction(29,"̫�_���_����");
			SetAction(30,"�컪_���_����");
			name = "�����Ŀ";
			nativename = "�����Ŀ";
			icon = "��ͨ_��Ŀ.dds";
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
			return 360000;
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
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return player_range;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetTime(12000.0f);
			victim.SetRatio(0.039999999f);
			victim.SetInccritrate(true);
			victim.SetProbability(120.0f);
			victim.SetTime(12000.0f);
			victim.SetRatio(0.30000001f);
			victim.SetNingjin(true);
			return true;
		}
	}
	public class GSkill3905 : GSkill
	{
		public GSkill3905()
			: base(3905)
		{
			
		}
	}
	public class GSkill3906Stub : GSkillStub
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
		public GSkill3906Stub()
			: base(3906)
		{
			occupation = 151;
			maxlevel = 1;
			maxlearn = 0;
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
			SetAction(0,"������_���");
			SetAction(1,"������_���");
			SetAction(2,"������_���");
			SetAction(3,"�ϻ���_���");
			SetAction(4,"������_���");
			SetAction(5,"���_���");
			SetAction(6,"�����_���");
			SetAction(7,"����_���");
			SetAction(8,"����_���");
			SetAction(9,"��ԯ_���");
			SetAction(10,"����_���");
			SetAction(11,"̫�_���");
			SetAction(12,"�컪_���");
			SetAction(13,"����_���");
			SetAction(14,"Ӣ��_���");
			SetAction(15,"Ԫ�ش�ʦ_���");
			SetAction(16,"Ԫ�ش�ʦ_���");
			SetAction(17,"������_���");
			SetAction(18,"������_���_���");
			SetAction(19,"������_���_���");
			SetAction(20,"������_���_���");
			SetAction(21,"�ϻ���_���_���");
			SetAction(22,"������_���_���");
			SetAction(23,"���_���_���");
			SetAction(24,"�����_���_���");
			SetAction(25,"����_���_���");
			SetAction(26,"����_���_���");
			SetAction(27,"��ԯ_���_���");
			SetAction(28,"����_���_���");
			SetAction(29,"̫�_���_���");
			SetAction(30,"�컪_���_���");
			name = "�����ɽ";
			nativename = "�����ɽ";
			icon = "��ͨ_��ɽ.dds";
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
			return 360000;
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

			victim.SetProbability(120.0f);
			victim.SetTime(12000.0f);
			victim.SetRatio(0.2f);
			victim.SetBuffid(1);
			victim.SetIncattack(true);
			victim.SetProbability(120.0f);
			victim.SetTime(12000.0f);
			victim.SetRatio(0.2f);
			victim.SetBuffid(1);
			victim.SetIncdefence(true);
			victim.SetTime(12000.0f);
			victim.SetRatio(0.1f);
			victim.SetBuffid(1);
			victim.SetInchp(true);
			victim.SetTime(12000.0f);
			victim.SetRatio(0.1f);
			victim.SetBuffid(1);
			victim.SetIncmp(true);
			return true;
		}
	}
	public class GSkill3906 : GSkill
	{
		public GSkill3906()
			: base(3906)
		{
			
		}
	}
	public class GSkill3907Stub : GSkillStub
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
		public GSkill3907Stub()
			: base(3907)
		{
			occupation = 151;
			maxlevel = 1;
			maxlearn = 0;
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
			SetAction(0,"������_ȼ��");
			SetAction(1,"������_ȼ��");
			SetAction(2,"������_ȼ��");
			SetAction(3,"�ϻ���_ȼ��");
			SetAction(4,"������_ȼ��");
			SetAction(5,"���_ȼ��");
			SetAction(6,"�����_ȼ��");
			SetAction(7,"����_ȼ��");
			SetAction(8,"����_ȼ��");
			SetAction(9,"��ԯ_ȼ��");
			SetAction(10,"����_ȼ��");
			SetAction(11,"̫�_ȼ��");
			SetAction(12,"�컪_ȼ��");
			SetAction(13,"����_ȼ��");
			SetAction(14,"Ӣ��_ȼ��");
			SetAction(15,"Ԫ�ش�ʦ_ȼ��");
			SetAction(16,"Ԫ�ش�ʦ_ȼ��");
			SetAction(17,"������_ȼ��");
			SetAction(18,"������_���_ȼ��");
			SetAction(19,"������_���_ȼ��");
			SetAction(20,"������_���_ȼ��");
			SetAction(21,"�ϻ���_���_ȼ��");
			SetAction(22,"������_���_ȼ��");
			SetAction(23,"���_���_ȼ��");
			SetAction(24,"�����_���_ȼ��");
			SetAction(25,"����_���_ȼ��");
			SetAction(26,"����_���_ȼ��");
			SetAction(27,"��ԯ_���_ȼ��");
			SetAction(28,"����_���_ȼ��");
			SetAction(29,"̫�_���_ȼ��");
			SetAction(30,"�컪_���_ȼ��");
			name = "�������";
			nativename = "�������";
			icon = "��ͨ_����.dds";
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
			return 360000;
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
			return 20.000000f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetProbability(120.0f);
			victim.SetTime(15000.0f);
			victim.SetRatio(0.30000001f);
			victim.SetBuffid(1);
			victim.SetWeak(true);
			victim.SetProbability(120.0f);
			victim.SetTime(15000.0f);
			victim.SetRatio(0.40000001f);
			victim.SetBuffid(1);
			victim.SetSlow(true);
			return true;
		}
	}
	public class GSkill3907 : GSkill
	{
		public GSkill3907()
			: base(3907)
		{
			
		}
	}
	public class GSkill3908Stub : GSkillStub
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
		public GSkill3908Stub()
			: base(3908)
		{
			occupation = 151;
			maxlevel = 1;
			maxlearn = 0;
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
			SetAction(0,"������_�����");
			SetAction(1,"������_��ң��");
			SetAction(2,"������_�����");
			SetAction(3,"�ϻ���_����");
			SetAction(4,"������_�׽");
			SetAction(5,"���_�ٹ�ҹ��");
			SetAction(6,"������_��ң��");
			SetAction(7,"����_����");
			SetAction(8,"����_������");
			SetAction(9,"��ԯ_����");
			SetAction(10,"����_����");
			SetAction(11,"̫�_����");
			SetAction(12,"�컪_����");
			SetAction(13,"����_����");
			SetAction(14,"Ӣ��_����");
			SetAction(15,"0");
			SetAction(16,"Ԫ�ش�ʦ_�ٶȼ�ȡ");
			SetAction(17,"����_������Ѫ");
			SetAction(18,"������_���_�����");
			SetAction(19,"������_���_��ң��");
			SetAction(20,"������_���_�����");
			SetAction(21,"�ϻ���_���_����");
			SetAction(22,"������_���_�׽");
			SetAction(23,"���_���_�ٹ�ҹ��");
			SetAction(24,"������_���_��ң��");
			SetAction(25,"����_���_����");
			SetAction(26,"����_���_������");
			SetAction(27,"��ԯ_���_����");
			SetAction(28,"����_���_����");
			SetAction(29,"̫�_���_����");
			SetAction(30,"�컪_���_����");
			name = "�������";
			nativename = "�������";
			icon = "��ͨ_����.dds";
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
			return 300000;
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

			victim.SetProbability(120.0f);
			victim.SetTime(10000.0f);
			victim.SetBuffid(1);
			victim.SetValue(5.0f);
			victim.SetAddspeed(true);
			victim.SetProbability(120.0f);
			victim.SetTime(10000.0f);
			victim.SetBuffid(1);
			victim.SetValue(4.0f);
			victim.SetIncmountspeed(true);
			victim.SetProbability(120.0f);
			victim.SetClearslow(true);
			return true;
		}
	}
	public class GSkill3908 : GSkill
	{
		public GSkill3908()
			: base(3908)
		{
			
		}
	}
	public class GSkill3909Stub : GSkillStub
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
		public GSkill3909Stub()
			: base(3909)
		{
			occupation = 151;
			maxlevel = 1;
			maxlearn = 0;
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
			SetAction(0,"������_ɢ��");
			SetAction(1,"������_ɢ��");
			SetAction(2,"������_ɢ��");
			SetAction(3,"�ϻ���_ɢ��");
			SetAction(4,"������_ɢ��");
			SetAction(5,"���_ɢ��");
			SetAction(6,"�����_ɢ��");
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
			SetAction(17,"����_������Ѫ");
			SetAction(18,"������_���_ɢ��");
			SetAction(19,"������_���_ɢ��");
			SetAction(20,"������_���_ɢ��");
			SetAction(21,"�ϻ���_���_ɢ��");
			SetAction(22,"������_���_ɢ��");
			SetAction(23,"���_���_ɢ��");
			SetAction(24,"�����_���_ɢ��");
			SetAction(25,"����_���_ɢ��");
			SetAction(26,"����_���_ɢ��");
			SetAction(27,"��ԯ_���_ɢ��");
			SetAction(28,"����_���_ɢ��");
			SetAction(29,"̫�_���_ɢ��");
			SetAction(30,"�컪_���_ɢ��");
			name = "������⻯��";
			nativename = "������⻯��";
			icon = "��ͨ_���⻯��.dds";
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
			return 240000;
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

			victim.SetProbability(120.0f);
			victim.SetAmount(20.0f);
			victim.SetCleardebuff(true);
			return true;
		}
	}
	public class GSkill3909 : GSkill
	{
		public GSkill3909()
			: base(3909)
		{
			
		}
	}
}
