using System;
using System.Text;

namespace SKILL
{
	public class GSkill3850Stub : GSkillStub
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
		public GSkill3850Stub()
			: base(3850)
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
			weapon_limit = 11;
			SetAction(0,"Ì«ê»_·ÉÉý1");
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
			SetAction(11,"Ì«ê»_·ÉÉý1");
			SetAction(12,"0");
			SetAction(13,"");
			SetAction(14,"");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"Ì«ê»_Æï³Ë_·ÉÉý1");
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
			SetAction(29,"Ì«ê»_Æï³Ë_·ÉÉý1");
			SetAction(30,"0");
			name = "±ø¼ø£ºê»";
			nativename = "±ø¼ø£ºê»";
			icon = "±ø¼ø.dds";
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
			skill_class = 10;
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
		public override int GetEnmity(GSkill skill)
		{
			return 1;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 15.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 12.000000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 20.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			return 980.000000f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetProbability(120.0f);
			victim.SetTime(15000.0f);
			victim.SetValue(9.0f);
			victim.SetCrippleddebuff(true);
			victim.SetTime(20000.0f);
			victim.SetRatio(0.2f);
			victim.SetBuffid(0);
			victim.SetDecanti(true);
			victim.SetProbability(120.0f);
			victim.SetTime(20000.0f);
			victim.SetRatio(0.2f);
			victim.SetBuffid(1);
			victim.SetDecskillaccu(true);
			return true;
		}
	}
	public class GSkill3850 : GSkill
	{
		public GSkill3850()
			: base(3850)
		{
			
		}
	}
	public class GSkill3851Stub : GSkillStub
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
				return 300;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_res1 = player.GetRes1();
				int				player_res2 = player.GetRes2();
				int				player_res3 = player.GetRes3();
				int				player_res4 = player.GetRes4();
				int				player_res5 = player.GetRes5();

				player.SetVar1((int)(player_res5 + (player_res4 + (player_res3 + (player_res2 + player_res1)))));
				skill.SetRatio(1.2f);
				player.SetPerform(1);
			}
		}
		public class GState3 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 300;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();

				player.SetVar1(0);
				skill.SetRatio(1.2f);
				player.SetPerform(0);
			}
		}
		public class GState4 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 300;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();

				player.SetVar1(0);
				skill.SetRatio(1.2f);
				player.SetPerform(0);
			}
		}
		public class GState5 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 300;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();

				player.SetVar1(0);
				skill.SetRatio(1.2f);
				player.SetPerform(0);
			}
		}
		public GSkill3851Stub()
			: base(3851)
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
			succeedskillcolor = 1;
			succeedskillcolornum = 1;
			comboskill = 0;
			need_item = false;
			item1_id = -1;
			item1_num = 0;
			item2_id = -1;
			item2_num = 0;
			item_relation = 0;
			weapon_limit = 11;
			SetAction(0,"Ì«ê»_·ÉÉý2");
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
			SetAction(11,"Ì«ê»_·ÉÉý2");
			SetAction(12,"0");
			SetAction(13,"");
			SetAction(14,"");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"Ì«ê»_Æï³Ë_·ÉÉý2");
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
			SetAction(29,"Ì«ê»_Æï³Ë_·ÉÉý2");
			SetAction(30,"0");
			name = "¶·»ê£ºê»";
			nativename = "¶·»ê£ºê»";
			icon = "¶·»ê1.dds";
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
			skill_class = 10;
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
			return 15.000000f;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 7.500000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 1.700000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 15.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			return 1000.000000f;
		}
		public override int GetCoverage(GSkill skill)
		{
			return 30;
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
			int				player_var1 = player.GetVar1();

			/*
			if ( player_var1 - (player_res5 + (player_res4 + (player_res3 + (player_res2 + player_res1)))) <= 0 )
			{
			d = 0.0f;
			}
			else
			{
			d = (player_var1 - (player_res5 + (player_res4 + (player_res3 + (player_res2 + player_res1)))));
			}
			victim.SetProbability(d);
			victim.SetTime(15000.0f);
			victim.SetRatio(1.0f);
			victim.SetValue(0.5f);
			victim.SetParalysis(true);
			if ( player_var1 )
			v36 = 120.0f;
			else
			victim.SetProbability(0.0f);
			victim.SetTime(10000.0f);
			victim.SetRatio(0.30000001f);
			victim.SetBuffid(1);
			victim.SetDecskilldodge(true);
			*/
			return true;
		}
	}
	public class GSkill3851 : GSkill
	{
		public GSkill3851()
			: base(3851)
		{
			
		}
	}
	public class GSkill3852Stub : GSkillStub
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
		public GSkill3852Stub()
			: base(3852)
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
			weapon_limit = 11;
			SetAction(0,"Ì«ê»_·ÉÉý4");
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
			SetAction(11,"Ì«ê»_·ÉÉý4");
			SetAction(12,"0");
			SetAction(13,"");
			SetAction(14,"");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"Ì«ê»_Æï³Ë_·ÉÉý4");
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
			SetAction(29,"Ì«ê»_Æï³Ë_·ÉÉý4");
			SetAction(30,"0");
			name = "ÎäÕß£ºê»";
			nativename = "ÎäÕß£ºê»";
			icon = "ÎäÕß.dds";
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
			skill_class = 10;
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
			return 25.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			return 1250.000000f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetTime(60000.0f);
			victim.SetRatio(0.2f);
			victim.SetBuffid(0);
			victim.SetIncanti(true);
			return true;
		}
	}
	public class GSkill3852 : GSkill
	{
		public GSkill3852()
			: base(3852)
		{
			
		}
	}
	public class GSkill3853Stub : GSkillStub
	{
		public GSkill3853Stub()
			: base(3853)
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
			name = "¹íÉñÍ¨£º¸½¼ÓÍ¨ÓÃ";
			nativename = "¹íÉñÍ¨£º¸½¼ÓÍ¨ÓÃ";
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
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_hp = player.GetHp();

			/*
			if ( player.GetObjectType() )
			d = 0.0f;
			else
			victim.SetProbability(50.0f);
			victim.SetValue((player_hp * 0.2f));
			victim.SetDirecthurt(true);
			victim.SetProbability(50.0f);
			victim.SetAmount(1.0f);
			victim.SetClearbuff(true);
			*/
			return true;
		}
	}
	public class GSkill3853 : GSkill
	{
		public GSkill3853()
			: base(3853)
		{
			
		}
	}
	public class GSkill3854Stub : GSkillStub
	{
		public GSkill3854Stub()
			: base(3854)
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
			allowform = 0;
			credittype = 0;
			clearmask = 0;
			skill_limit = 1;
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
			name = "ÌìÇ´ÑÓÊ±£º·Ù";
			nativename = "ÌìÇ´ÑÓÊ±£º·Ù";
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
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_maxatk = player.GetMaxatk();

			victim.SetProbability(100.0f);
			victim.SetValue((player_maxatk * 3.75f));
			victim.SetDirecthurt(true);
			return true;
		}
	}
	public class GSkill3854 : GSkill
	{
		public GSkill3854()
			: base(3854)
		{
			
		}
	}
	public class GSkill3855Stub : GSkillStub
	{
		public GSkill3855Stub()
			: base(3855)
		{
			occupation = 150;
			maxlevel = 9;
			maxlearn = 9;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 2;
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
			name = "°ÔÐ°Õó·¨II";
			nativename = "°ÔÐ°Õó·¨II";
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
			skill_class = 9;
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
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();

			/*
			victim.SetProbability(100.0f);
			if ( skill_level <= 0 )
			d = 218.0f;
			else
			victim.SetRatio(4116.0f);
			if ( skill_level <= 2 )
			v18 = 218.0f;
			else
			victim.SetAmount(4112.0f);
			if ( skill_level <= 1 )
			v17 = 218.0f;
			else
			victim.SetValue(4114.0f);
			victim.SetDispel(true);
			if ( skill_level <= 0 )
			t = 0.0f;
			else
			victim.SetTime(3000.0f);
			victim.SetImmunewrap(true);
			if ( skill_level <= 2 )
			v15 = 0.0f;
			else
			victim.SetTime(3000.0f);
			victim.SetImmunesleep(true);
			if ( skill_level <= 1 )
			v14 = 0.0f;
			else
			victim.SetTime(3000.0f);
			victim.SetImmunesilent(true);
			*/
			return true;
		}
	}
	public class GSkill3855 : GSkill
	{
		public GSkill3855()
			: base(3855)
		{
			
		}
	}
	public class GSkill3856Stub : GSkillStub
	{
		public GSkill3856Stub()
			: base(3856)
		{
			occupation = 150;
			maxlevel = 2000;
			maxlearn = 2000;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 2;
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
			name = "×£ÈÚÕó·¨II";
			nativename = "×£ÈÚÕó·¨II";
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
			skill_class = 9;
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
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();

			/*
			victim.SetProbability(100.0f);
			victim.SetRatio(218.0f);
			victim.SetAmount(5281.0f);
			victim.SetValue(218.0f);
			victim.SetDispel(true);
			victim.SetTime(3000.0f);
			v77 = 0.01f * (2 * player.GetCyclemembercnt() + (skill_level - 100 * (skill_level / 100)) + 3);
			if ( zrand(100) >= 10 * (skill_level - 100 * (skill_level / 100))
			|| ((v75 = skill_level / 100,
			player,_occupation != 7)
			&& (v14 = player, GNET::PlayerWrapper::GetOccupation(v14) != 8)
			&& (v15 = player, GNET::PlayerWrapper::GetOccupation(v15) != 9)
			&& (v16 = player, GNET::PlayerWrapper::GetOccupation(v16) != 19)
			&& (v17 = player, GNET::PlayerWrapper::GetOccupation(v17) != 20)
			&& (v18 = player, GNET::PlayerWrapper::GetOccupation(v18) != 1)
			&& (v19 = player, GNET::PlayerWrapper::GetOccupation(v19) != 2)
			&& (v20 = player, GNET::PlayerWrapper::GetOccupation(v20) != 3)
			&& (v21 = player, GNET::PlayerWrapper::GetOccupation(v21) != 13)
			&& (v22 = player, GNET::PlayerWrapper::GetOccupation(v22) != 14)
			&& (v23 = player, GNET::PlayerWrapper::GetOccupation(v23) != 10)
			&& (v24 = player, GNET::PlayerWrapper::GetOccupation(v24) != 11)
			&& (v25 = player, GNET::PlayerWrapper::GetOccupation(v25) != 12)
			&& (v26 = player, GNET::PlayerWrapper::GetOccupation(v26) != 22)
			&& (v27 = player, GNET::PlayerWrapper::GetOccupation(v27) != 23)
			&& (v28 = player, GNET::PlayerWrapper::GetOccupation(v28) != 4)
			&& (v29 = player, GNET::PlayerWrapper::GetOccupation(v29) != 5)
			&& (v30 = player, GNET::PlayerWrapper::GetOccupation(v30) != 6)
			&& (v31 = player, GNET::PlayerWrapper::GetOccupation(v31) != 16)
			&& (v32 = player, GNET::PlayerWrapper::GetOccupation(v32) != 17)
			&& (v33 = player, GNET::PlayerWrapper::GetOccupation(v33) != 25)
			&& (v34 = player, GNET::PlayerWrapper::GetOccupation(v34) != 26)
			&& (v35 = player, GNET::PlayerWrapper::GetOccupation(v35) != 27)
			&& (v36 = player, GNET::PlayerWrapper::GetOccupation(v36) != 28)
			&& (v37 = player, GNET::PlayerWrapper::GetOccupation(v37) != 29)
			&& (v38 = player, GNET::PlayerWrapper::GetOccupation(v38) != 64)
			&& (v39 = player, GNET::PlayerWrapper::GetOccupation(v39) != 65)
			&& (v40 = player, GNET::PlayerWrapper::GetOccupation(v40) != 66)
			&& (v41 = player, GNET::PlayerWrapper::GetOccupation(v41) != 67)
			&& (v42 = player, GNET::PlayerWrapper::GetOccupation(v42) != 68) ? (v74 = 0) : (v74 = 1),
			(v43 = player, GNET::PlayerWrapper::GetOccupation(v43) != 33)
			&& (v44 = player, GNET::PlayerWrapper::GetOccupation(v44) != 34)
			&& (v45 = player, GNET::PlayerWrapper::GetOccupation(v45) != 35)
			&& (v46 = player, GNET::PlayerWrapper::GetOccupation(v46) != 36)
			&& (v47 = player, GNET::PlayerWrapper::GetOccupation(v47) != 37)
			&& (v48 = player, GNET::PlayerWrapper::GetOccupation(v48) != 39)
			&& (v49 = player, GNET::PlayerWrapper::GetOccupation(v49) != 40)
			&& (v50 = player, GNET::PlayerWrapper::GetOccupation(v50) != 41)
			&& (v51 = player, GNET::PlayerWrapper::GetOccupation(v51) != 42)
			&& (v52 = player, GNET::PlayerWrapper::GetOccupation(v52) != 43)
			&& (v53 = player, GNET::PlayerWrapper::GetOccupation(v53) != 45)
			&& (v54 = player, GNET::PlayerWrapper::GetOccupation(v54) != 46)
			&& (v55 = player, GNET::PlayerWrapper::GetOccupation(v55) != 47)
			&& (v56 = player, GNET::PlayerWrapper::GetOccupation(v56) != 48)
			&& (v57 = player, GNET::PlayerWrapper::GetOccupation(v57) != 49)
			&& (v58 = player, GNET::PlayerWrapper::GetOccupation(v58) != 51)
			&& (v59 = player, GNET::PlayerWrapper::GetOccupation(v59) != 52)
			&& (v60 = player, GNET::PlayerWrapper::GetOccupation(v60) != 53)
			&& (v61 = player, GNET::PlayerWrapper::GetOccupation(v61) != 54)
			&& (v62 = player, GNET::PlayerWrapper::GetOccupation(v62) != 55)
			&& (v63 = player, GNET::PlayerWrapper::GetOccupation(v63) != 96)
			&& (v64 = player, GNET::PlayerWrapper::GetOccupation(v64) != 97)
			&& (v65 = player, GNET::PlayerWrapper::GetOccupation(v65) != 98)
			&& (v66 = player, GNET::PlayerWrapper::GetOccupation(v66) != 99)
			&& (v67 = player, GNET::PlayerWrapper::GetOccupation(v67) != 100) ? (v73 = v74) : (v73 = v74 + 2),
			v75 != v73) )
			v76 = v77;
			else
			victim.SetRatio((v77 + v77));
			victim.SetBuffid(1);
			victim.SetIncskilldamage(true);
			*/
			return true;
		}
	}
	public class GSkill3856 : GSkill
	{
		public GSkill3856()
			: base(3856)
		{
			
		}
	}
	public class GSkill3857Stub : GSkillStub
	{
		public class GState1 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 2000;
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
				int				skill_level = skill.GetLevel();

				player.SetVar1(1);
				skill.SetRatio(((skill_level - 15) * (norm(skill_level / 14.9f) * 0.03f) + (skill_level * 0.08f + 1.0f)));
				skill.SetCrithurt((skill_level * 0.05f));
				skill.SetPlus(((4 * skill_level * skill_level + (15 * skill_level) + 850)));
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
				return 400;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				skill_level = skill.GetLevel();

				player.SetVar1(0);
				skill.SetRatio(((skill_level - 15) * (norm(skill_level / 14.9f) * 0.03f) + (skill_level * 0.08f + 1.0f)));
				skill.SetCrithurt((skill_level * 0.05f));
				skill.SetPlus(((4 * skill_level * skill_level + (15 * skill_level) + 850)));
				player.SetPerform(0);
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
				return 400;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				skill_level = skill.GetLevel();

				player.SetVar1(0);
				skill.SetRatio(((skill_level - 15) * (norm(skill_level / 14.9f) * 0.03f) + (skill_level * 0.08f + 1.0f)));
				skill.SetCrithurt((skill_level * 0.05f));
				skill.SetPlus(((4 * skill_level * skill_level + (15 * skill_level) + 850)));
				player.SetPerform(0);
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
				return 200;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				skill_level = skill.GetLevel();

				player.SetVar1(0);
				skill.SetRatio(((skill_level - 15) * (norm(skill_level / 14.9f) * 0.03f) + (skill_level * 0.08f + 1.0f)));
				skill.SetCrithurt((skill_level * 0.05f));
				skill.SetPlus(((4 * skill_level * skill_level + (15 * skill_level) + 850)));
				player.SetPerform(0);
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
				return 200;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				skill_level = skill.GetLevel();

				player.SetVar1(0);
				skill.SetRatio(((skill_level - 15) * (norm(skill_level / 14.9f) * 0.03f) + (skill_level * 0.08f + 1.0f)));
				skill.SetCrithurt((skill_level * 0.05f));
				skill.SetPlus(((4 * skill_level * skill_level + (15 * skill_level) + 850)));
				player.SetPerform(0);
			}
		}
		public GSkill3857Stub()
			: base(3857)
		{
			occupation = 180;
			maxlevel = 20;
			maxlearn = 0;
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
			weapon_limit = 11;
			SetAction(0,"Ì«ê»_ÉñÖ®·£");
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
			SetAction(11,"Ì«ê»_ÉñÖ®·£");
			SetAction(12,"0");
			SetAction(13,"");
			SetAction(14,"");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"Ì«ê»_Æï³Ë_ÉñÖ®·£");
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
			SetAction(29,"Ì«ê»_Æï³Ë_ÉñÖ®·£");
			SetAction(30,"0");
			name = "ÌìµØ¾ø<Ðþ>";
			nativename = "ÌìµØ¾ø<Ðþ>";
			icon = "ÏÉ¡¤ÌìµØ¾ø.dds";
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
			skill_class = 10;
			guide = false;
			summon_id = 0;
			trigger = true;
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
		}
		public override int GetExecutetime(GSkill skill)
		{
			return 4000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			return 15000;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 12.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 10.000000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 15.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (5 * skill_level * skill_level + (50 * skill_level) + 1300);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_maxhp = player.GetMaxhp();
			int				skill_level = skill.GetLevel();

			victim.SetProbability(120.0f);
			victim.SetTime(((1000 * skill_level + 10000)));
			victim.SetBuffid((zrand(skill_level / 2 + 5)));
			victim.SetAmount((skill_level * (player_maxhp * 0.005f)));
			victim.SetValue((skill_level * (player_maxhp * 0.005f)));
			victim.SetSubhp(true);
			victim.SetProbability(80.0f);
			victim.SetTime(((1000 * skill_level + 10000)));
			victim.SetRatio((D2INT(skill_level / 4) * 0.01f));
			victim.SetBuffid((zrand(skill_level / 2 + 5)));
			victim.SetIncfatalratio(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_var1 = player.GetVar1();
			int				skill_level = skill.GetLevel();

			/*
			if ( player_var1 == 1 )
			d = 120.0f;
			else
			victim.SetProbability(0.0f);
			victim.SetTime(((1000 * skill_level + 10000)));
			victim.SetRatio((skill_level * 0.01f));
			victim.SetBuffid(1);
			victim.SetBloodthirsty(true);
			v19 = player_var1;
			if ( norm(zrand(100) / (99 - 3 * skill_level)) )
			v18 = (3466 * v19);
			else
			victim.SetRatio(0.0f);
			victim.SetAmount(0.0f);
			victim.SetValue(0.0f);
			victim.SetClearcooldown(true);
			*/
			return true;
		}
		public override int GetDpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return 3 * skill_level * skill_level + (42 * skill_level) + 170;
		}
	}
	public class GSkill3857 : GSkill
	{
		public GSkill3857()
			: base(3857)
		{
			
		}
	}
	public class GSkill3858Stub : GSkillStub
	{
		public class GState1 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 2000;
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
				int				skill_level = skill.GetLevel();

				player.SetVar1(1);
				skill.SetRatio(((skill_level - 15) * (norm(skill_level / 14.9f) * 0.03f) + (skill_level * 0.08f + 1.0f)));
				skill.SetCrithurt((skill_level * 0.05f));
				skill.SetPlus(((4 * skill_level * skill_level + (15 * skill_level) + 850)));
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
				return 400;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				skill_level = skill.GetLevel();

				player.SetVar1(0);
				skill.SetRatio(((skill_level - 15) * (norm(skill_level / 14.9f) * 0.03f) + (skill_level * 0.08f + 1.0f)));
				skill.SetCrithurt((skill_level * 0.05f));
				skill.SetPlus(((4 * skill_level * skill_level + (15 * skill_level) + 850)));
				player.SetPerform(0);
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
				return 400;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				skill_level = skill.GetLevel();

				player.SetVar1(0);
				skill.SetRatio(((skill_level - 15) * (norm(skill_level / 14.9f) * 0.03f) + (skill_level * 0.08f + 1.0f)));
				skill.SetCrithurt((skill_level * 0.05f));
				skill.SetPlus(((4 * skill_level * skill_level + (15 * skill_level) + 850)));
				player.SetPerform(0);
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
				return 200;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				skill_level = skill.GetLevel();

				player.SetVar1(0);
				skill.SetRatio(((skill_level - 15) * (norm(skill_level / 14.9f) * 0.03f) + (skill_level * 0.08f + 1.0f)));
				skill.SetCrithurt((skill_level * 0.05f));
				skill.SetPlus(((4 * skill_level * skill_level + (15 * skill_level) + 850)));
				player.SetPerform(0);
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
				return 200;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				skill_level = skill.GetLevel();

				player.SetVar1(0);
				skill.SetRatio(((skill_level - 15) * (norm(skill_level / 14.9f) * 0.03f) + (skill_level * 0.08f + 1.0f)));
				skill.SetCrithurt((skill_level * 0.05f));
				skill.SetPlus(((4 * skill_level * skill_level + (15 * skill_level) + 850)));
				player.SetPerform(0);
			}
		}
		public GSkill3858Stub()
			: base(3858)
		{
			occupation = 180;
			maxlevel = 20;
			maxlearn = 0;
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
			weapon_limit = 11;
			SetAction(0,"Ì«ê»_ÉñÖ®·£");
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
			SetAction(11,"Ì«ê»_ÉñÖ®·£");
			SetAction(12,"0");
			SetAction(13,"");
			SetAction(14,"");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"Ì«ê»_Æï³Ë_ÉñÖ®·£");
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
			SetAction(29,"Ì«ê»_Æï³Ë_ÉñÖ®·£");
			SetAction(30,"0");
			name = "ÌìµØ¾ø<É·>";
			nativename = "ÌìµØ¾ø<É·>";
			icon = "Ä§¡¤ÌìµØ¾ø.dds";
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
			skill_class = 10;
			guide = false;
			summon_id = 0;
			trigger = true;
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
		}
		public override int GetExecutetime(GSkill skill)
		{
			return 4000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			return 15000;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 12.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 10.000000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 15.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (5 * skill_level * skill_level + (50 * skill_level) + 1300);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_maxhp = player.GetMaxhp();
			int				skill_level = skill.GetLevel();

			victim.SetProbability(120.0f);
			victim.SetTime(((1000 * skill_level + 10000)));
			victim.SetBuffid((zrand(skill_level / 5 + 5)));
			victim.SetAmount((skill_level * (player_maxhp * 0.005f)));
			victim.SetValue((skill_level * (player_maxhp * 0.005f)));
			victim.SetSubhp(true);
			victim.SetProbability(80.0f);
			victim.SetTime(((1000 * skill_level + 10000)));
			victim.SetRatio((D2INT(skill_level / 4) * 0.01f));
			victim.SetBuffid((zrand(skill_level / 2 + 5)));
			victim.SetIncfatalratio(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_var1 = player.GetVar1();
			int				skill_level = skill.GetLevel();

			/*
			if ( player_var1 == 1 )
			d = 120.0f;
			else
			victim.SetProbability(0.0f);
			victim.SetTime(((1000 * skill_level + 10000)));
			victim.SetRatio((skill_level * 0.01f));
			victim.SetBuffid(1);
			victim.SetBloodthirsty(true);
			v19 = player_var1;
			if ( norm(zrand(100) / (99 - 3 * skill_level)) )
			v18 = (3467 * v19);
			else
			victim.SetRatio(0.0f);
			victim.SetAmount(0.0f);
			victim.SetValue(0.0f);
			victim.SetClearcooldown(true);
			*/
			return true;
		}
		public override int GetDpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return 3 * skill_level * skill_level + (42 * skill_level) + 170;
		}
	}
	public class GSkill3858 : GSkill
	{
		public GSkill3858()
			: base(3858)
		{
			
		}
	}
	public class GSkill3859Stub : GSkillStub
	{
		public class GState1 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 2000;
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
				int				skill_level = skill.GetLevel();

				player.SetVar1(1);
				skill.SetRatio(((skill_level - 15) * (norm(skill_level / 14.9f) * 0.03f) + (skill_level * 0.08f + 1.0f)));
				skill.SetCrithurt((skill_level * 0.05f));
				skill.SetPlus(((4 * skill_level * skill_level + (15 * skill_level) + 850)));
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
				return 400;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				skill_level = skill.GetLevel();

				player.SetVar1(0);
				skill.SetRatio(((skill_level - 15) * (norm(skill_level / 14.9f) * 0.03f) + (skill_level * 0.08f + 1.0f)));
				skill.SetCrithurt((skill_level * 0.05f));
				skill.SetPlus(((4 * skill_level * skill_level + (15 * skill_level) + 850)));
				player.SetPerform(0);
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
				return 400;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				skill_level = skill.GetLevel();

				player.SetVar1(0);
				skill.SetRatio(((skill_level - 15) * (norm(skill_level / 14.9f) * 0.03f) + (skill_level * 0.08f + 1.0f)));
				skill.SetCrithurt((skill_level * 0.05f));
				skill.SetPlus(((4 * skill_level * skill_level + (15 * skill_level) + 850)));
				player.SetPerform(0);
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
				return 200;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				skill_level = skill.GetLevel();

				player.SetVar1(0);
				skill.SetRatio(((skill_level - 15) * (norm(skill_level / 14.9f) * 0.03f) + (skill_level * 0.08f + 1.0f)));
				skill.SetCrithurt((skill_level * 0.05f));
				skill.SetPlus(((4 * skill_level * skill_level + (15 * skill_level) + 850)));
				player.SetPerform(0);
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
				return 200;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				skill_level = skill.GetLevel();

				player.SetVar1(2);
				skill.SetRatio(((skill_level - 15) * (norm(skill_level / 14.9f) * 0.03f) + (skill_level * 0.08f + 1.0f)));
				skill.SetCrithurt((skill_level * 0.05f));
				skill.SetPlus(((4 * skill_level * skill_level + (15 * skill_level) + 850)));
				player.SetPerform(0);
			}
		}
		public GSkill3859Stub()
			: base(3859)
		{
			occupation = 180;
			maxlevel = 25;
			maxlearn = 0;
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
			weapon_limit = 11;
			SetAction(0,"Ì«ê»_ÉñÖ®·£");
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
			SetAction(11,"Ì«ê»_ÉñÖ®·£");
			SetAction(12,"0");
			SetAction(13,"");
			SetAction(14,"");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"Ì«ê»_Æï³Ë_ÉñÖ®·£");
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
			SetAction(29,"Ì«ê»_Æï³Ë_ÉñÖ®·£");
			SetAction(30,"0");
			name = "ÌìµØ¾ø<ìø>";
			nativename = "ÌìµØ¾ø<ìø>";
			icon = "·ð¡¤ÌìµØ¾ø.dds";
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
			skill_class = 10;
			guide = false;
			summon_id = 0;
			trigger = true;
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
		}
		public override int GetExecutetime(GSkill skill)
		{
			return 4000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			return 15000;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 12.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 10.000000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 15.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (5 * skill_level * skill_level + (50 * skill_level) + 1300);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_maxhp = player.GetMaxhp();
			int				skill_level = skill.GetLevel();

			victim.SetProbability(120.0f);
			victim.SetTime(((1000 * skill_level + 10000)));
			victim.SetBuffid((zrand(skill_level / 2 + 5)));
			victim.SetAmount((skill_level * (player_maxhp * 0.005f)));
			victim.SetValue((skill_level * (player_maxhp * 0.005f)));
			victim.SetSubhp(true);
			victim.SetProbability(80.0f);
			victim.SetTime(((1000 * skill_level + 10000)));
			victim.SetRatio((D2INT(skill_level / 4) * 0.01f));
			victim.SetBuffid((zrand(skill_level / 2 + 5)));
			victim.SetIncfatalratio(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_var1 = player.GetVar1();
			int				skill_level = skill.GetLevel();

			/*
			if ( player_var1 == 1 )
			d = 120.0f;
			else
			victim.SetProbability(0.0f);
			victim.SetTime(((1000 * skill_level + 10000)));
			victim.SetRatio((skill_level * 0.01f));
			victim.SetBuffid(1);
			victim.SetBloodthirsty(true);
			if ( player_var1 == 2 )
			v19 = (3 * skill_level);
			else
			victim.SetProbability(0.0f);
			victim.SetTime(1000.0f);
			victim.SetRatio(skill_level);
			victim.SetBuffid(1);
			victim.SetValue(3589.0f);
			victim.SetDelaycast(true);
			*/
			return true;
		}
		public override int GetDpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return 3 * skill_level * skill_level + (42 * skill_level) + 170;
		}
	}
	public class GSkill3859 : GSkill
	{
		public GSkill3859()
			: base(3859)
		{
			
		}
	}
}
