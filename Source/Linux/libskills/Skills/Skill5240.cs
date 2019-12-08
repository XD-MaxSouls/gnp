using System;
using System.Text;

namespace SKILL
{
	public class GSkill5240Stub : GSkillStub
	{
		public class GState1 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 0;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();

				player.SetPerform(1);
			}
		}
		public GSkill5240Stub()
			: base(5240)
		{
			occupation = 109;
			maxlevel = 1;
			maxlearn = 0;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 2;
			timetype = 1;
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
			SetAction(0,"0");
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
			SetAction(12,"0");
			SetAction(13,"0");
			SetAction(14,"0");
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
			name = "��ʱ�������ȴ";
			nativename = "��ʱ�������ȴ";
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
			skill_class = 13;
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

			victim.SetRatio(4853.0f);
			victim.SetAmount(0.0f);
			victim.SetValue(0.0f);
			victim.SetClearcooldown(true);
			return true;
		}
	}
	public class GSkill5240 : GSkill
	{
		public GSkill5240()
			: base(5240)
		{
			
		}
	}
	public class GSkill5241Stub : GSkillStub
	{
		public GSkill5241Stub()
			: base(5241)
		{
			occupation = 1;
			maxlevel = 10;
			maxlearn = 10;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 1;
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
			name = "5239";
			nativename = "5239";
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
		}
	}
	public class GSkill5241 : GSkill
	{
		public GSkill5241()
			: base(5241)
		{
			
		}
	}
	public class GSkill5242Stub : GSkillStub
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
				return 500;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();

				player.SetPerform(1);
			}
		}
		public GSkill5242Stub()
			: base(5242)
		{
			occupation = 129;
			maxlevel = 2;
			maxlearn = 2;
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
			skill_limit = 8;
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
			SetAction(6,"������_����");
			SetAction(7,"����_����");
			SetAction(8,"����_����");
			SetAction(9,"0");
			SetAction(10,"����_����");
			SetAction(11,"̫�_����");
			SetAction(12,"�컪_����");
			SetAction(13,"0");
			SetAction(14,"0");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"������_���_����");
			SetAction(19,"������_���_����");
			SetAction(20,"������_���_����");
			SetAction(21,"������_���_����");
			SetAction(22,"������_���_����");
			SetAction(23,"������_���_����");
			SetAction(24,"������_���_����");
			SetAction(25,"����_���_����");
			SetAction(26,"����_���_����");
			SetAction(27,"0");
			SetAction(28,"����_���_����");
			SetAction(29,"̫�_���_����");
			SetAction(30,"�컪_���_����");
			name = "�㻯";
			nativename = "�㻯";
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
		public override float GetPraydistance(GSkill skill)
		{
			return 8.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 7.000000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 9.000000f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();

			victim.SetProbability(100.0f);
			victim.SetTime(30000.0f);
			victim.SetValue(((skill_level + 893)));
			victim.SetBackorigin(true);
			return true;
		}
	}
	public class GSkill5242 : GSkill
	{
		public GSkill5242()
			: base(5242)
		{
			
		}
	}
	public class GSkill5243Stub : GSkillStub
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
				int				player_rage = player.GetRage();
				int				player_maxatk = player.GetMaxatk();

				/*
				if ( player_rage <= player_maxatk )
				  {
				v = player_maxatk;
				  }
				  else
				  {
				v = player_rage;
				  }
				player.SetVar1(v);
				player.SetRage(0);
				player.SetPerform(1);
				*/
			}
		}
		public GSkill5243Stub()
			: base(5243)
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
			rangetype = 16;
			doenchant = true;
			dobless = true;
			autoattack = false;
			allowform = 128;
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
			SetAction(0,"һ�򵱹�");
			SetAction(1,"һ�򵱹�");
			SetAction(2,"һ�򵱹�");
			SetAction(3,"һ�򵱹�");
			SetAction(4,"һ�򵱹�");
			SetAction(5,"һ�򵱹�");
			SetAction(6,"һ�򵱹�");
			SetAction(7,"һ�򵱹�");
			SetAction(8,"һ�򵱹�");
			SetAction(9,"һ�򵱹�");
			SetAction(10,"һ�򵱹�");
			SetAction(11,"һ�򵱹�");
			SetAction(12,"һ�򵱹�");
			SetAction(13,"һ�򵱹�");
			SetAction(14,"һ�򵱹�");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"һ�򵱹�");
			SetAction(19,"һ�򵱹�");
			SetAction(20,"һ�򵱹�");
			SetAction(21,"һ�򵱹�");
			SetAction(22,"һ�򵱹�");
			SetAction(23,"һ�򵱹�");
			SetAction(24,"һ�򵱹�");
			SetAction(25,"һ�򵱹�");
			SetAction(26,"һ�򵱹�");
			SetAction(27,"һ�򵱹�");
			SetAction(28,"һ�򵱹�");
			SetAction(29,"һ�򵱹�");
			SetAction(30,"һ�򵱹�");
			name = "һ�򵱹�";
			nativename = "һ�򵱹�";
			icon = "һ�򵱹�.dds";
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
			skill_class = 13;
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
			return 30000;
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
			int				player_var1 = player.GetVar1();

			victim.SetTime(10000.0f);
			victim.SetRatio(1.0f);
			victim.SetAmount(player_var1);
			victim.SetDechurt(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_var1 = player.GetVar1();

			victim.SetTime(10000.0f);
			victim.SetRatio(1.0f);
			victim.SetAmount(player_var1);
			victim.SetDechurt(true);
			victim.SetProbability(120.0f);
			victim.SetTime(300000.0f);
			victim.SetRatio(0.2f);
			victim.SetDecdamage(true);
			victim.SetProbability(120.0f);
			victim.SetTime(30000.0f);
			victim.SetRatio(5244.0f);
			victim.SetAmount(0.0f);
			victim.SetValue(0.0f);
			victim.SetSetcooldown(true);
			victim.SetProbability(120.0f);
			victim.SetRatio(4127.0f);
			victim.SetAmount(0.0f);
			victim.SetValue(0.0f);
			victim.SetDispel(true);
			return true;
		}
	}
	public class GSkill5243 : GSkill
	{
		public GSkill5243()
			: base(5243)
		{
			
		}
	}
	public class GSkill5244Stub : GSkillStub
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
				int				player_maxhp = player.GetMaxhp();
				int				player_rage = player.GetRage();

				player.SetVar1((int)(player_rage / player_maxhp));
				player.SetPerform(1);
			}
		}
		public GSkill5244Stub()
			: base(5244)
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
			rangetype = 16;
			doenchant = true;
			dobless = true;
			autoattack = false;
			allowform = 128;
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
			SetAction(0,"������ѩ");
			SetAction(1,"������ѩ");
			SetAction(2,"������ѩ");
			SetAction(3,"������ѩ");
			SetAction(4,"������ѩ");
			SetAction(5,"������ѩ");
			SetAction(6,"������ѩ");
			SetAction(7,"������ѩ");
			SetAction(8,"������ѩ");
			SetAction(9,"������ѩ");
			SetAction(10,"������ѩ");
			SetAction(11,"������ѩ");
			SetAction(12,"������ѩ");
			SetAction(13,"������ѩ");
			SetAction(14,"������ѩ");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"������ѩ");
			SetAction(19,"������ѩ");
			SetAction(20,"������ѩ");
			SetAction(21,"������ѩ");
			SetAction(22,"������ѩ");
			SetAction(23,"������ѩ");
			SetAction(24,"������ѩ");
			SetAction(25,"������ѩ");
			SetAction(26,"������ѩ");
			SetAction(27,"������ѩ");
			SetAction(28,"������ѩ");
			SetAction(29,"������ѩ");
			SetAction(30,"������ѩ");
			name = "������ѩ";
			nativename = "������ѩ";
			icon = "������ѩ.dds";
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
			skill_class = 13;
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
			return 30000;
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
			int				player_var1 = player.GetVar1();

			/*
			if ( 10000 * player_var1 <= 3000 )
			{
			t = 3000.0f;
			}
			else
			{
			t = (10000 * player_var1);
			}
			victim.SetTime(t);
			victim.SetBuffid(0);
			victim.SetAmount(1.0f);
			victim.SetTurndebuff(true);
			*/
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_var1 = player.GetVar1();

			/*
			if ( 10000 * player_var1 <= 3000 )
			{
			t = 3000.0f;
			}
			else
			{
			t = (10000 * player_var1);
			}
			victim.SetTime(t);
			victim.SetBuffid(0);
			victim.SetAmount(1.0f);
			victim.SetTurndebuff(true);
			victim.SetTime(300000.0f);
			victim.SetBuffid(0);
			victim.SetValue(100.0f);
			victim.SetAddanti(true);
			victim.SetProbability(120.0f);
			victim.SetTime(30000.0f);
			victim.SetRatio(5243.0f);
			victim.SetAmount(0.0f);
			victim.SetValue(0.0f);
			victim.SetSetcooldown(true);
			victim.SetProbability(120.0f);
			victim.SetRatio(4102.0f);
			victim.SetAmount(0.0f);
			victim.SetValue(0.0f);
			victim.SetDispel(true);
			*/
			return true;
		}
	}
	public class GSkill5244 : GSkill
	{
		public GSkill5244()
			: base(5244)
		{
			
		}
	}
	public class GSkill5245Stub : GSkillStub
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
		public GSkill5245Stub()
			: base(5245)
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
			rangetype = 16;
			doenchant = true;
			dobless = true;
			autoattack = false;
			allowform = 128;
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
			SetAction(0,"���⺮");
			SetAction(1,"���⺮");
			SetAction(2,"���⺮");
			SetAction(3,"���⺮");
			SetAction(4,"���⺮");
			SetAction(5,"���⺮");
			SetAction(6,"���⺮");
			SetAction(7,"���⺮");
			SetAction(8,"���⺮");
			SetAction(9,"���⺮");
			SetAction(10,"���⺮");
			SetAction(11,"���⺮");
			SetAction(12,"���⺮");
			SetAction(13,"���⺮");
			SetAction(14,"���⺮");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"���⺮");
			SetAction(19,"���⺮");
			SetAction(20,"���⺮");
			SetAction(21,"���⺮");
			SetAction(22,"���⺮");
			SetAction(23,"���⺮");
			SetAction(24,"���⺮");
			SetAction(25,"���⺮");
			SetAction(26,"���⺮");
			SetAction(27,"���⺮");
			SetAction(28,"���⺮");
			SetAction(29,"���⺮");
			SetAction(30,"���⺮");
			name = "���⺮";
			nativename = "���⺮";
			icon = "���⺮.dds";
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
			skill_class = 13;
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
			return 30000;
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
			return 20.000000f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetProbability(120.0f);
			victim.SetTime(6000.0f);
			victim.SetRatio(0.2f);
			victim.SetBuffid(0);
			victim.SetIncskillaccu(true);
			victim.SetProbability(120.0f);
			victim.SetTime(6000.0f);
			victim.SetBuffid(0);
			victim.SetValue(20.0f);
			victim.SetAddspot(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetProbability(120.0f);
			victim.SetTime(6000.0f);
			victim.SetRatio(0.2f);
			victim.SetBuffid(0);
			victim.SetIncskillaccu(true);
			victim.SetProbability(120.0f);
			victim.SetTime(6000.0f);
			victim.SetBuffid(0);
			victim.SetValue(20.0f);
			victim.SetAddspot(true);
			return true;
		}
	}
	public class GSkill5245 : GSkill
	{
		public GSkill5245()
			: base(5245)
		{
			
		}
	}
	public class GSkill5246Stub : GSkillStub
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
				int				player_res1 = player.GetRes1();

				player.SetVar1((int)(player_res1 + 100));
				player.SetPerform(1);
			}
		}
		public GSkill5246Stub()
			: base(5246)
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
			rangetype = 0;
			doenchant = true;
			dobless = true;
			autoattack = false;
			allowform = 128;
			credittype = 0;
			clearmask = 0;
			skill_limit = 0;
			skillelemsnum = 0;
			skillelemsfactor = 0.000000f;
			serialskill = 0;
			charge = 0;
			chargedist = 10.000000f;
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
			SetAction(0,"�׺�����");
			SetAction(1,"�׺�����");
			SetAction(2,"�׺�����");
			SetAction(3,"�׺�����");
			SetAction(4,"�׺�����");
			SetAction(5,"�׺�����");
			SetAction(6,"�׺�����");
			SetAction(7,"�׺�����");
			SetAction(8,"�׺�����");
			SetAction(9,"�׺�����");
			SetAction(10,"�׺�����");
			SetAction(11,"�׺�����");
			SetAction(12,"�׺�����");
			SetAction(13,"�׺�����");
			SetAction(14,"�׺�����");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"�׺�����");
			SetAction(19,"�׺�����");
			SetAction(20,"�׺�����");
			SetAction(21,"�׺�����");
			SetAction(22,"�׺�����");
			SetAction(23,"�׺�����");
			SetAction(24,"�׺�����");
			SetAction(25,"�׺�����");
			SetAction(26,"�׺�����");
			SetAction(27,"�׺�����");
			SetAction(28,"�׺�����");
			SetAction(29,"�׺�����");
			SetAction(30,"�׺�����");
			name = "�׺�����";
			nativename = "�׺�����";
			icon = "�׺�����.dds";
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
			skill_class = 13;
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
			return 30000;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 17.000000f;
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
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_var1 = player.GetVar1();

			victim.SetProbability(player_var1);
			victim.SetTime(1000.0f);
			victim.SetDizzy(true);
			victim.SetProbability(-1.0f);
			victim.SetTime(6000.0f);
			victim.SetAmount(10.0f);
			victim.SetValue(1.0f);
			victim.SetBepulled(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetTime(6000.0f);
			victim.SetPulling(true);
			return true;
		}
	}
	public class GSkill5246 : GSkill
	{
		public GSkill5246()
			: base(5246)
		{
			
		}
	}
	public class GSkill5247Stub : GSkillStub
	{
		public class GState1 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 1000;
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
				return 1000;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();

				player.SetPerform(1);
			}
		}
		public GSkill5247Stub()
			: base(5247)
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
			rangetype = 5;
			doenchant = true;
			dobless = false;
			autoattack = false;
			allowform = 1;
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
			weapon_limit = 13;
			SetAction(0,"����_��Ӱ׷��");
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
			SetAction(12,"0");
			SetAction(13,"����_��Ӱ׷��");
			SetAction(14,"0");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"����_���_��Ӱ׷��");
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
			name = "��Ӱ׷��";
			nativename = "��Ӱ׷��";
			icon = "��Ӱ׷��.dds";
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
			skill_class = 12;
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
			return 180000;
		}
		public override float GetMpcost(GSkill skill)
		{
			return 800.000000f;
		}
	}
	public class GSkill5247 : GSkill
	{
		public GSkill5247()
			: base(5247)
		{
			
		}
	}
	public class GSkill5248Stub : GSkillStub
	{
		public class GState1 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 1200;
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
				return 800;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();

				player.SetPerform(1);
			}
		}
		public GSkill5248Stub()
			: base(5248)
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
			rangetype = 0;
			doenchant = true;
			dobless = false;
			autoattack = false;
			allowform = 1;
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
			weapon_limit = 13;
			SetAction(0,"����_��˫��Ը");
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
			SetAction(12,"0");
			SetAction(13,"����_��˫��Ը");
			SetAction(14,"0");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"����_���_��˫��Ը");
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
			name = "��˫��Ը";
			nativename = "��˫��Ը";
			icon = "��˫��Ը.dds";
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
			skill_class = 12;
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
			return 180000;
		}
		public override float GetAttackdistance(GSkill skill)
		{
			return 25.000000f;
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
			return 25.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			return 1200.000000f;
		}
		public override int GetCoverage(GSkill skill)
		{
			return 40;
		}
	}
	public class GSkill5248 : GSkill
	{
		public GSkill5248()
			: base(5248)
		{
			
		}
	}
	public class GSkill5249Stub : GSkillStub
	{
		public class GState1 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 640;
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
				return 640;
			}
			public override void Calculate(GSkill skill)
			{
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
				return 640;
			}
			public override void Calculate(GSkill skill)
			{
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
				return 640;
			}
			public override void Calculate(GSkill skill)
			{
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
				return 640;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();

				player.SetPerform(1);
			}
			public override bool Cancel(GSkill skill)
			{
				return true;
			}
		}
		public GSkill5249Stub()
			: base(5249)
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
			autoattack = false;
			allowform = 64;
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
			weapon_limit = 13;
			SetAction(0,"���ܼ�_�������");
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
			SetAction(12,"0");
			SetAction(13,"���ܼ�_�������");
			SetAction(14,"0");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"���ܼ�_���_�������");
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
			name = "ľ�׼����������";
			nativename = "ľ�׼����������";
			icon = "���ܼ����������.dds";
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
			skill_class = 12;
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
			return 180000;
		}
		public override float GetRadius(GSkill skill)
		{
			return 5.000000f;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 18.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 15.000000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 25.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			return 1800.000000f;
		}
		public override int GetCoverage(GSkill skill)
		{
			return 40;
		}
	}
	public class GSkill5249 : GSkill
	{
		public GSkill5249()
			: base(5249)
		{
			
		}
	}
}
