using System;
using System.Text;

namespace SKILL
{
	public class GSkill3790Stub : GSkillStub
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
		public GSkill3790Stub()
			: base(3790)
		{
			occupation = 146;
			maxlevel = 1;
			maxlearn = 1;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 2;
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
			SetAction(0,"������_�κ�");
			SetAction(1,"������_�κ�");
			SetAction(2,"������_�κ�");
			SetAction(3,"������_�κ�");
			SetAction(4,"������_�κ�");
			SetAction(5,"������_�κ�");
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
			SetAction(18,"������_���_�κ�");
			SetAction(19,"������_���_�κ�");
			SetAction(20,"������_���_�κ�");
			SetAction(21,"������_���_�κ�");
			SetAction(22,"������_���_�κ�");
			SetAction(23,"������_���_�κ�");
			SetAction(24,"");
			SetAction(25,"");
			SetAction(26,"");
			SetAction(27,"");
			SetAction(28,"");
			SetAction(29,"");
			SetAction(30,"");
			name = "�κΣ���";
			nativename = "�κΣ���";
			icon = "�κ�.dds";
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
			skill_class = 0;
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
		public override float GetRadius(GSkill skill)
		{
			return 25.000000f;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 25.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 10.000000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 25.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			return 800.000000f;
		}
		public override int GetCoverage(GSkill skill)
		{
			return 25;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetProbability(100.0f);
			victim.SetTime(15100.0f);
			victim.SetRatio(0.1f);
			victim.SetBuffid(0);
			victim.SetIncattack(true);
			victim.SetTime(15100.0f);
			victim.SetValue(((20 * norm(zrand(100) / 75) + 20)));
			victim.SetBlessed(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetProbability(100.0f);
			victim.SetTime(60100.0f);
			victim.SetRatio(0.15001f);
			victim.SetBuffid(0);
			victim.SetIncskillaccu(true);
			return true;
		}
	}
	public class GSkill3790 : GSkill
	{
		public GSkill3790()
			: base(3790)
		{
			
		}
	}
	public class GSkill3791Stub : GSkillStub
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
			public override bool Cancel(GSkill skill)
			{
				return true;
			}
		}
		public class GState2 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 600;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_hp = player.GetHp();
				int				player_maxhp = player.GetMaxhp();
				int				player_mp = player.GetMp();
				int				player_maxmp = player.GetMaxmp();

				skill.SetRatio(0.5f);
				skill.SetPlus((norm((2 * player_mp) / (player_maxmp + 1)) * (player_mp * 0.01f) + (norm((2 * player_hp) / (player_maxhp + 1)) * (player_hp * 0.01f))));
				player.SetPerform(1);
			}
			public override bool Cancel(GSkill skill)
			{
				return true;
			}
		}
		public class GState3 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 600;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_hp = player.GetHp();
				int				player_maxhp = player.GetMaxhp();
				int				player_mp = player.GetMp();
				int				player_maxmp = player.GetMaxmp();

				skill.SetRatio(0.69999999f);
				skill.SetPlus((norm((2 * player_mp) / (player_maxmp + 1)) * (player_mp * 0.01f) + (norm((2 * player_hp) / (player_maxhp + 1)) * (player_hp * 0.01f))));
				player.SetPerform(1);
			}
			public override bool Cancel(GSkill skill)
			{
				return true;
			}
		}
		public class GState4 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 600;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_hp = player.GetHp();
				int				player_maxhp = player.GetMaxhp();
				int				player_mp = player.GetMp();
				int				player_maxmp = player.GetMaxmp();

				skill.SetRatio(0.89999998f);
				skill.SetPlus((norm((2 * player_mp) / (player_maxmp + 1)) * (player_mp * 0.01f) + (norm((2 * player_hp) / (player_maxhp + 1)) * (player_hp * 0.01f))));
				player.SetPerform(1);
			}
			public override bool Cancel(GSkill skill)
			{
				return true;
			}
		}
		public class GState5 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 600;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_hp = player.GetHp();
				int				player_maxhp = player.GetMaxhp();
				int				player_mp = player.GetMp();
				int				player_maxmp = player.GetMaxmp();

				skill.SetRatio(1.1f);
				skill.SetPlus((norm((2 * player_mp) / (player_maxmp + 1)) * (player_mp * 0.01f) + (norm((2 * player_hp) / (player_maxhp + 1)) * (player_hp * 0.01f))));
				player.SetPerform(1);
			}
			public override bool Cancel(GSkill skill)
			{
				return true;
			}
		}
		public class GState6 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 600;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_hp = player.GetHp();
				int				player_maxhp = player.GetMaxhp();
				int				player_mp = player.GetMp();
				int				player_maxmp = player.GetMaxmp();

				skill.SetRatio(1.3f);
				skill.SetPlus((norm((2 * player_mp) / (player_maxmp + 1)) * (player_mp * 0.01f) + (norm((2 * player_hp) / (player_maxhp + 1)) * (player_hp * 0.01f))));
				player.SetPerform(1);
			}
			public override bool Cancel(GSkill skill)
			{
				return true;
			}
		}
		public class GState7 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 600;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_hp = player.GetHp();
				int				player_maxhp = player.GetMaxhp();
				int				player_mp = player.GetMp();
				int				player_maxmp = player.GetMaxmp();

				skill.SetRatio(1.5f);
				skill.SetPlus((norm((2 * player_mp) / (player_maxmp + 1)) * (player_mp * 0.01f) + (norm((2 * player_hp) / (player_maxhp + 1)) * (player_hp * 0.01f))));
				player.SetPerform(1);
			}
			public override bool Cancel(GSkill skill)
			{
				return true;
			}
		}
		public class GState8 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 600;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_hp = player.GetHp();
				int				player_maxhp = player.GetMaxhp();
				int				player_mp = player.GetMp();
				int				player_maxmp = player.GetMaxmp();

				skill.SetRatio(1.7f);
				skill.SetPlus((norm((2 * player_mp) / (player_maxmp + 1)) * (player_mp * 0.01f) + (norm((2 * player_hp) / (player_maxhp + 1)) * (player_hp * 0.01f))));
				player.SetPerform(1);
			}
			public override bool Cancel(GSkill skill)
			{
				return true;
			}
		}
		public class GState9 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 600;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_hp = player.GetHp();
				int				player_maxhp = player.GetMaxhp();
				int				player_mp = player.GetMp();
				int				player_maxmp = player.GetMaxmp();

				skill.SetRatio(1.9f);
				skill.SetPlus((norm((2 * player_mp) / (player_maxmp + 1)) * (player_mp * 0.01f) + (norm((2 * player_hp) / (player_maxhp + 1)) * (player_hp * 0.01f))));
				player.SetPerform(1);
			}
			public override bool Cancel(GSkill skill)
			{
				return true;
			}
		}
		public class GState10 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 600;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_hp = player.GetHp();
				int				player_maxhp = player.GetMaxhp();
				int				player_mp = player.GetMp();
				int				player_maxmp = player.GetMaxmp();

				skill.SetRatio(2.0999999f);
				skill.SetPlus((norm((2 * player_mp) / (player_maxmp + 1)) * (player_mp * 0.01f) + (norm((2 * player_hp) / (player_maxhp + 1)) * (player_hp * 0.01f))));
				player.SetPerform(1);
			}
		}
		public GSkill3791Stub()
			: base(3791)
		{
			occupation = 146;
			maxlevel = 1;
			maxlearn = 1;
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
			SetAction(0,"������_�ű�");
			SetAction(1,"������_�ű�");
			SetAction(2,"������_�ű�");
			SetAction(3,"������_�ű�");
			SetAction(4,"������_�ű�");
			SetAction(5,"������_�ű�");
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
			SetAction(18,"������_���_�ű�");
			SetAction(19,"������_���_�ű�");
			SetAction(20,"������_���_�ű�");
			SetAction(21,"������_���_�ű�");
			SetAction(22,"������_���_�ű�");
			SetAction(23,"������_���_�ű�");
			SetAction(24,"");
			SetAction(25,"");
			SetAction(26,"");
			SetAction(27,"");
			SetAction(28,"");
			SetAction(29,"");
			SetAction(30,"");
			name = "�ű䣺��";
			nativename = "�ű䣺��";
			icon = "�ű�.dds";
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
			skill_class = 0;
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
			AddState(new GState6());
			AddState(new GState7());
			AddState(new GState8());
			AddState(new GState9());
			AddState(new GState10());
		}
		public override int GetExecutetime(GSkill skill)
		{
			return 6000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			return 360000;
		}
		public override float GetPraydistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return player_range + 18.0f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return player_range + 2.0f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return player_range + 24.0f;
		}
		public override float GetMpcost(GSkill skill)
		{
			return 305.000000f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_res4 = player.GetRes4();

			victim.SetTime(16100.0f);
			victim.SetBuffid(0);
			victim.SetValue(player_res4);
			victim.SetSubantisilent(true);
			return true;
		}
	}
	public class GSkill3791 : GSkill
	{
		public GSkill3791()
			: base(3791)
		{
			
		}
	}
	public class GSkill3792Stub : GSkillStub
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
			public override bool Cancel(GSkill skill)
			{
				return true;
			}
		}
		public class GState2 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 800;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_hp = player.GetHp();

				player.SetVar1(1);
				player.SetHp((player_hp * 0.75f));
				skill.SetRatio(2.0f);
				skill.SetCrit(0.5f);
				player.SetPerform(1);
			}
			public override bool Cancel(GSkill skill)
			{
				return true;
			}
		}
		public class GState3 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 800;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_hp = player.GetHp();

				player.SetVar1(2);
				player.SetHp((player_hp * 0.75f));
				skill.SetCrit(0.5f);
				skill.SetRatio(1.0f);
				player.SetPerform(0);
			}
		}
		public GSkill3792Stub()
			: base(3792)
		{
			occupation = 146;
			maxlevel = 1;
			maxlearn = 1;
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
			SetAction(0,"������_�շ�");
			SetAction(1,"������_�շ�");
			SetAction(2,"������_�շ�");
			SetAction(3,"������_�շ�");
			SetAction(4,"������_�շ�");
			SetAction(5,"������_�շ�");
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
			SetAction(18,"������_���_�շ�");
			SetAction(19,"������_���_�շ�");
			SetAction(20,"������_���_�շ�");
			SetAction(21,"������_���_�շ�");
			SetAction(22,"������_���_�շ�");
			SetAction(23,"������_���_�շ�");
			SetAction(24,"");
			SetAction(25,"");
			SetAction(26,"");
			SetAction(27,"");
			SetAction(28,"");
			SetAction(29,"");
			SetAction(30,"");
			name = "�շ�����";
			nativename = "�շ�����";
			icon = "�շ�.dds";
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
			skill_class = 0;
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

			return player_range + 6.0f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return player_range + 2.0f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return player_range + 8.0f;
		}
		public override float GetMpcost(GSkill skill)
		{
			return 1100.000000f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_var1 = player.GetVar1();

			/*
			if ( player_var1 == 2 )
			d = 100.0f;
			else
			victim.SetProbability(0.0f);
			victim.SetTime(30000.0f);
			victim.SetRatio(1.0f);
			victim.SetBuffid(9);
			victim.SetValue(3854.0f);
			victim.SetDelaycast(true);
			*/
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_level = player.GetLevel();
			int				skill_level = skill.GetLevel();

			victim.SetTime(6100.0f);
			victim.SetRatio((player_level * 0.002f + 0.5f));
			victim.SetAmount(((1600 * player_level * skill_level)));
			victim.SetDechurt(true);
			return true;
		}
	}
	public class GSkill3792 : GSkill
	{
		public GSkill3792()
			: base(3792)
		{
			
		}
	}
	public class GSkill3793Stub : GSkillStub
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
		public GSkill3793Stub()
			: base(3793)
		{
			occupation = 146;
			maxlevel = 1;
			maxlearn = 1;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 3;
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
			SetAction(0,"������_��ħ����");
			SetAction(1,"������_��ħ����");
			SetAction(2,"������_��ħ����");
			SetAction(3,"������_��ħ����");
			SetAction(4,"������_��ħ����");
			SetAction(5,"������_��ħ����");
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
			SetAction(18,"������_���_��ħ����");
			SetAction(19,"������_���_��ħ����");
			SetAction(20,"������_���_��ħ����");
			SetAction(21,"������_���_��ħ����");
			SetAction(22,"������_���_��ħ����");
			SetAction(23,"������_���_��ħ����");
			SetAction(24,"");
			SetAction(25,"");
			SetAction(26,"");
			SetAction(27,"");
			SetAction(28,"");
			SetAction(29,"");
			SetAction(30,"");
			name = "��ħ��������";
			nativename = "��ħ��������";
			icon = "��ħ����.dds";
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
			skill_class = 3;
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
		public override float GetRadius(GSkill skill)
		{
			return 25.000000f;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 25.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 10.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			return 1150.000000f;
		}
		public override int GetCoverage(GSkill skill)
		{
			return 25;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_level = player.GetLevel();

			victim.SetProbability(100.0f);
			victim.SetTime(15100.0f);
			victim.SetBuffid(0);
			victim.SetAmount((((30 * player_level) - 15 * norm(zrand(100) / 85) * player_level)));
			victim.SetValue(((99 * player_level)));
			victim.SetSubhp(true);
			victim.SetProbability(100.0f);
			victim.SetTime(15100.0f);
			victim.SetBuffid(0);
			victim.SetAmount((((30 * player_level) - 15 * norm(zrand(100) / 85) * player_level)));
			victim.SetValue(((99 * player_level)));
			victim.SetSubmp(true);
			victim.SetTime(15100.0f);
			victim.SetBuffid(0);
			victim.SetAmount(1.0f);
			victim.SetTurnbuff(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_hp = player.GetHp();

			victim.SetProbability(100.0f);
			victim.SetRatio(0.0f);
			victim.SetValue(player_hp);
			victim.SetHeal(true);
			victim.SetProbability(100.0f);
			victim.SetBuffid(2);
			victim.SetAmount(99.0f);
			victim.SetValue(99.0f);
			victim.SetExorcism(true);
			return true;
		}
	}
	public class GSkill3793 : GSkill
	{
		public GSkill3793()
			: base(3793)
		{
			
		}
	}
	public class GSkill3794Stub : GSkillStub
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
		public GSkill3794Stub()
			: base(3794)
		{
			occupation = 146;
			maxlevel = 1;
			maxlearn = 1;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 2;
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
			SetAction(0,"������_�����");
			SetAction(1,"������_�����");
			SetAction(2,"������_�����");
			SetAction(3,"������_�����");
			SetAction(4,"������_�����");
			SetAction(5,"������_�����");
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
			SetAction(18,"������_���_�����");
			SetAction(19,"������_���_�����");
			SetAction(20,"������_���_�����");
			SetAction(21,"������_���_�����");
			SetAction(22,"������_���_�����");
			SetAction(23,"������_���_�����");
			SetAction(24,"");
			SetAction(25,"");
			SetAction(26,"");
			SetAction(27,"");
			SetAction(28,"");
			SetAction(29,"");
			SetAction(30,"");
			name = "�����⣺��";
			nativename = "�����⣺��";
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
			skill_class = 3;
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
		public override float GetRadius(GSkill skill)
		{
			return 25.000000f;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 25.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 10.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			return 1100.000000f;
		}
		public override int GetCoverage(GSkill skill)
		{
			return 25;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetTime(30100.0f);
			victim.SetRatio(1.0f);
			victim.SetBuffid(0);
			victim.SetIncanti(true);
			victim.SetProbability(100.0f);
			victim.SetTime(12100.0f);
			victim.SetBuffid(0);
			victim.SetValue(9999.0f);
			victim.SetAdddefence(true);
			victim.SetProbability(100.0f);
			victim.SetClearwrap(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetProbability(100.0f);
			victim.SetTime(60100.0f);
			victim.SetRatio(0.15001f);
			victim.SetBuffid(0);
			victim.SetIncskillaccu(true);
			victim.SetProbability(100.0f);
			victim.SetBuffid(3);
			victim.SetAmount(99.0f);
			victim.SetValue(99.0f);
			victim.SetExorcism(true);
			return true;
		}
	}
	public class GSkill3794 : GSkill
	{
		public GSkill3794()
			: base(3794)
		{
			
		}
	}
	public class GSkill3795Stub : GSkillStub
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

				skill.SetRatio(1.1f);
				skill.SetCrithurt(3.0f);
				player.SetPerform(1);
			}
		}
		public GSkill3795Stub()
			: base(3795)
		{
			occupation = 146;
			maxlevel = 1;
			maxlearn = 1;
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
			SetAction(0,"������_�ֻػþ�");
			SetAction(1,"������_�ֻػþ�");
			SetAction(2,"������_�ֻػþ�");
			SetAction(3,"������_�ֻػþ�");
			SetAction(4,"������_�ֻػþ�");
			SetAction(5,"������_�ֻػþ�");
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
			SetAction(18,"������_���_�ֻػþ�");
			SetAction(19,"������_���_�ֻػþ�");
			SetAction(20,"������_���_�ֻػþ�");
			SetAction(21,"������_���_�ֻػþ�");
			SetAction(22,"������_���_�ֻػþ�");
			SetAction(23,"������_���_�ֻػþ�");
			SetAction(24,"");
			SetAction(25,"");
			SetAction(26,"");
			SetAction(27,"");
			SetAction(28,"");
			SetAction(29,"");
			SetAction(30,"");
			name = "�ֻػþ�����";
			nativename = "�ֻػþ�����";
			icon = "�ֻػþ�.dds";
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
			skill_class = 3;
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

			return player_range + 7.0f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return player_range + 2.0f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return player_range + 10.0f;
		}
		public override float GetMpcost(GSkill skill)
		{
			return 990.000000f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_level = player.GetLevel();
			int				player_res4 = player.GetRes4();

			victim.SetProbability(100.0f);
			victim.SetTime(((1000 * zrand(9) * (norm((player_level / 105))) + 8100)));
			victim.SetRatio(0.80000001f);
			victim.SetValue(0.80000001f);
			victim.SetRandcurse(true);
			victim.SetTime(16000.0f);
			victim.SetBuffid(0);
			victim.SetValue(player_res4);
			victim.SetSubantisilent(true);
			return true;
		}
	}
	public class GSkill3795 : GSkill
	{
		public GSkill3795()
			: base(3795)
		{
			
		}
	}
	public class GSkill3796Stub : GSkillStub
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
				int				player_hp = player.GetHp();
				int				player_maxhp = player.GetMaxhp();
				int				player_mp = player.GetMp();
				int				player_maxmp = player.GetMaxmp();

				skill.SetRatio(((2 * (norm(player_hp / player_maxhp)) * norm((player_mp / player_maxmp)) + 1)));
				player.SetPerform(1);
			}
		}
		public GSkill3796Stub()
			: base(3796)
		{
			occupation = 146;
			maxlevel = 1;
			maxlearn = 1;
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
			SetAction(0,"������_�����Ը");
			SetAction(1,"������_�����Ը");
			SetAction(2,"������_�����Ը");
			SetAction(3,"������_�����Ը");
			SetAction(4,"������_�����Ը");
			SetAction(5,"������_�����Ը");
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
			SetAction(18,"������_���_�����Ը");
			SetAction(19,"������_���_�����Ը");
			SetAction(20,"������_���_�����Ը");
			SetAction(21,"������_���_�����Ը");
			SetAction(22,"������_���_�����Ը");
			SetAction(23,"������_���_�����Ը");
			SetAction(24,"");
			SetAction(25,"");
			SetAction(26,"");
			SetAction(27,"");
			SetAction(28,"");
			SetAction(29,"");
			SetAction(30,"");
			name = "�����Ը����";
			nativename = "�����Ը����";
			icon = "�����Ը.dds";
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
			skill_class = 3;
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

			return player_range + 7.0f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return player_range + 2.0f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return player_range + 9.0f;
		}
		public override float GetMpcost(GSkill skill)
		{
			return 1350.000000f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetProbability(100.0f);
			victim.SetTime(30000.0f);
			victim.SetRatio(1.0f);
			victim.SetBuffid(9);
			victim.SetValue(3854.0f);
			victim.SetDelaycast(true);
			victim.SetProbability(100.0f);
			victim.SetTime(12000.0f);
			victim.SetBuffid(0);
			victim.SetAmount(9000000.0f);
			victim.SetValue(100000.0f);
			victim.SetMpleak(true);
			victim.SetProbability(100.0f);
			victim.SetTime(12100.0f);
			victim.SetRatio(0.99000001f);
			victim.SetBuffid(0);
			victim.SetDecaccuracy(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_level = player.GetLevel();

			victim.SetProbability(100.0f);
			victim.SetTime(12100.0f);
			victim.SetRatio(1.0f);
			victim.SetAmount(12.0f);
			victim.SetValue(player_level);
			victim.SetFrenzied(true);
			return true;
		}
	}
	public class GSkill3796 : GSkill
	{
		public GSkill3796()
			: base(3796)
		{
			
		}
	}
	public class GSkill3797Stub : GSkillStub
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
		public GSkill3797Stub()
			: base(3797)
		{
			occupation = 146;
			maxlevel = 1;
			maxlearn = 1;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 3;
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
			SetAction(0,"�ϻ���_�����");
			SetAction(1,"�ϻ���_�����");
			SetAction(2,"�ϻ���_�����");
			SetAction(3,"�ϻ���_�����");
			SetAction(4,"�ϻ���_�����");
			SetAction(5,"�ϻ���_�����");
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
			SetAction(18,"�ϻ���_���_�����");
			SetAction(19,"�ϻ���_���_�����");
			SetAction(20,"�ϻ���_���_�����");
			SetAction(21,"�ϻ���_���_�����");
			SetAction(22,"�ϻ���_���_�����");
			SetAction(23,"�ϻ���_���_�����");
			SetAction(24,"");
			SetAction(25,"");
			SetAction(26,"");
			SetAction(27,"");
			SetAction(28,"");
			SetAction(29,"");
			SetAction(30,"");
			name = "������";
			nativename = "������";
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
			skill_class = 1;
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
		public override float GetRadius(GSkill skill)
		{
			return 25.000000f;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 25.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 10.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			return 950.000000f;
		}
		public override int GetCoverage(GSkill skill)
		{
			return 25;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_level = player.GetLevel();

			victim.SetProbability(((1.0f - player_level * 0.002f) * 100.0f));
			victim.SetTime(12000.0f);
			victim.SetBuffid(0);
			victim.SetAmount(12.0f);
			victim.SetValue(1000000.0f);
			victim.SetMpleak(true);
			victim.SetProbability(((1.0f - player_level * 0.002f) * 100.0f));
			victim.SetRatio(1.0f);
			victim.SetDrainmagic(true);
			victim.SetTime(15100.0f);
			victim.SetBuffid(0);
			victim.SetAmount(1.0f);
			victim.SetTurnbuff(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetProbability(50.0f);
			victim.SetTime(60100.0f);
			victim.SetRatio(0.050000001f);
			victim.SetAttack2hp(true);
			victim.SetProbability(50.0f);
			victim.SetTime(60100.0f);
			victim.SetRatio(0.050000001f);
			victim.SetAttack2mp(true);
			return true;
		}
	}
	public class GSkill3797 : GSkill
	{
		public GSkill3797()
			: base(3797)
		{
			
		}
	}
	public class GSkill3798Stub : GSkillStub
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
		public GSkill3798Stub()
			: base(3798)
		{
			occupation = 146;
			maxlevel = 1;
			maxlearn = 1;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 2;
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
			SetAction(0,"�ϻ���_������");
			SetAction(1,"�ϻ���_������");
			SetAction(2,"�ϻ���_������");
			SetAction(3,"�ϻ���_������");
			SetAction(4,"�ϻ���_������");
			SetAction(5,"�ϻ���_������");
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
			SetAction(18,"�ϻ���_���_������");
			SetAction(19,"�ϻ���_���_������");
			SetAction(20,"�ϻ���_���_������");
			SetAction(21,"�ϻ���_���_������");
			SetAction(22,"�ϻ���_���_������");
			SetAction(23,"�ϻ���_���_������");
			SetAction(24,"");
			SetAction(25,"");
			SetAction(26,"");
			SetAction(27,"");
			SetAction(28,"");
			SetAction(29,"");
			SetAction(30,"");
			name = "�������";
			nativename = "�������";
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
			skill_class = 1;
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
		public override float GetRadius(GSkill skill)
		{
			return 25.000000f;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 25.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 10.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			return 1100.000000f;
		}
		public override int GetCoverage(GSkill skill)
		{
			return 15;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_mp = player.GetMp();

			victim.SetProbability(120.0f);
			victim.SetTime(8100.0f);
			victim.SetRatio(0.33000001f);
			victim.SetNingjin(true);
			victim.SetProbability(100.0f);
			victim.SetTime(30100.0f);
			victim.SetBuffid(0);
			victim.SetValue((player_mp * 0.01f));
			victim.SetAddattack(true);
			victim.SetProbability(100.0f);
			victim.SetClearsilent(true);
			victim.SetTime(10100.0f);
			victim.SetImmunesilent(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetProbability(100.0f);
			victim.SetTime(60100.0f);
			victim.SetRatio(0.15001f);
			victim.SetBuffid(0);
			victim.SetIncskillaccu(true);
			return true;
		}
	}
	public class GSkill3798 : GSkill
	{
		public GSkill3798()
			: base(3798)
		{
			
		}
	}
	public class GSkill3799Stub : GSkillStub
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

				skill.SetRatio(1.1f);
				player.SetPerform(1);
			}
		}
		public GSkill3799Stub()
			: base(3799)
		{
			occupation = 146;
			maxlevel = 1;
			maxlearn = 1;
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
			SetAction(0,"�ϻ���_�ٻ���");
			SetAction(1,"�ϻ���_�ٻ���");
			SetAction(2,"�ϻ���_�ٻ���");
			SetAction(3,"�ϻ���_�ٻ���");
			SetAction(4,"�ϻ���_�ٻ���");
			SetAction(5,"�ϻ���_�ٻ���");
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
			SetAction(18,"�ϻ���_���_�ٻ���");
			SetAction(19,"�ϻ���_���_�ٻ���");
			SetAction(20,"�ϻ���_���_�ٻ���");
			SetAction(21,"�ϻ���_���_�ٻ���");
			SetAction(22,"�ϻ���_���_�ٻ���");
			SetAction(23,"�ϻ���_���_�ٻ���");
			SetAction(24,"");
			SetAction(25,"");
			SetAction(26,"");
			SetAction(27,"");
			SetAction(28,"");
			SetAction(29,"");
			SetAction(30,"");
			name = "�ٻ��ף���";
			nativename = "�ٻ��ף���";
			icon = "�ٻ���.dds";
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
			skill_class = 1;
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

			return player_range + 4.0f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return player_range + 2.0f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return player_range + 6.0f;
		}
		public override float GetMpcost(GSkill skill)
		{
			return 950.000000f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_level = player.GetLevel();
			int				player_res4 = player.GetRes4();

			victim.SetProbability(600.0f);
			victim.SetTime(12100.0f);
			victim.SetSilent(true);
			victim.SetProbability(15.0f);
			victim.SetTime(60100.0f);
			victim.SetBarehanded(true);
			victim.SetProbability(15.0f);
			victim.SetTime(60000.0f);
			victim.SetBuffid(0);
			victim.SetAmount(((6000 * player_level)));
			victim.SetValue(((6000 * player_level)));
			victim.SetMpleak(true);
			victim.SetTime(16000.0f);
			victim.SetBuffid(0);
			victim.SetValue(player_res4);
			victim.SetSubantisilent(true);
			return true;
		}
	}
	public class GSkill3799 : GSkill
	{
		public GSkill3799()
			: base(3799)
		{
			
		}
	}
}
