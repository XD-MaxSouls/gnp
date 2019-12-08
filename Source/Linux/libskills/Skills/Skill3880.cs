using System;
using System.Text;

namespace SKILL
{
	public class GSkill3880Stub : GSkillStub
	{
		public GSkill3880Stub()
			: base(3880)
		{
			occupation = 129;
			maxlevel = 9999;
			maxlearn = 10;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 13;
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
			name = "ÖïÏÉ¹Å¾íBuff¼Ó¹¥·À4";
			nativename = "ÖïÏÉ¹Å¾íBuff¼Ó¹¥·À4";
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
			int				skill_level = skill.GetLevel();

			victim.SetProbability(100.0f);
			victim.SetTime(1800000.0f);
			victim.SetRatio(0.5f);
			victim.SetBuffid(2);
			victim.SetValue(((2 * skill_level)));
			victim.SetHupo(true);
			victim.SetProbability(100.0f);
			victim.SetTime(1800000.0f);
			victim.SetRatio(0.5f);
			victim.SetBuffid(2);
			victim.SetValue(((2 * skill_level)));
			victim.SetGuilin(true);
			return true;
		}
	}
	public class GSkill3880 : GSkill
	{
		public GSkill3880()
			: base(3880)
		{
			
		}
	}
	public class GSkill3881Stub : GSkillStub
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
		public GSkill3881Stub()
			: base(3881)
		{
			occupation = 128;
			maxlevel = 999;
			maxlearn = 10;
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
			name = "×ÔÌåÎÞµÐ×£¸£";
			nativename = "×ÔÌåÎÞµÐ×£¸£";
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
			int				skill_level = skill.GetLevel();

			victim.SetTime(((1000 * skill_level)));
			victim.SetValue(((10 * skill_level)));
			victim.SetBlessed(true);
			return true;
		}
	}
	public class GSkill3881 : GSkill
	{
		public GSkill3881()
			: base(3881)
		{
			
		}
	}
	public class GSkill3882Stub : GSkillStub
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
		public GSkill3882Stub()
			: base(3882)
		{
			occupation = 128;
			maxlevel = 999;
			maxlearn = 10;
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
			name = "ÖïÏÉ¹Å¾í×ÔÉíÇå³ý×£¸£";
			nativename = "ÖïÏÉ¹Å¾í×ÔÉíÇå³ý×£¸£";
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
			victim.SetRatio(4119.0f);
			victim.SetAmount(4119.0f);
			victim.SetValue(4119.0f);
			victim.SetDispel(true);
			return true;
		}
	}
	public class GSkill3882 : GSkill
	{
		public GSkill3882()
			: base(3882)
		{
			
		}
	}
	public class GSkill3883Stub : GSkillStub
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
		public GSkill3883Stub()
			: base(3883)
		{
			occupation = 128;
			maxlevel = 999;
			maxlearn = 10;
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
			name = "ÖïÏÉ¹Å¾íÈºÃë¼¼ÄÜ";
			nativename = "ÖïÏÉ¹Å¾íÈºÃë¼¼ÄÜ";
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
		public override int GetEnmity(GSkill skill)
		{
			return 1;
		}
		public override float GetRadius(GSkill skill)
		{
			return 20.000000f;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 7.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 6.000000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 8.000000f;
		}
		public override int GetCoverage(GSkill skill)
		{
			return 3;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_maxhp = player.GetMaxhp();
			int				skill_level = skill.GetLevel();

			victim.SetProbability(120.0f);
			victim.SetValue((skill_level * (player_maxhp * 0.01f)));
			victim.SetDirecthurt(true);
			return true;
		}
	}
	public class GSkill3883 : GSkill
	{
		public GSkill3883()
			: base(3883)
		{
			
		}
	}
	public class GSkill3884Stub : GSkillStub
	{
		public class GState1 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 2500;
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

				player.SetHp(1.0f);
				player.SetDie(true);
				player.SetPerform(1);
			}
		}
		public GSkill3884Stub()
			: base(3884)
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
			name = "Ë®Çò´óÕ½_¹ÖÎïµÄË®Çò";
			nativename = "Ë®Çò´óÕ½_¹ÖÎïµÄË®Çò";
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
			return 3000;
		}
		public override float GetRadius(GSkill skill)
		{
			return 5.000000f;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 10.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 5.000000f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetProbability(9999.0f);
			victim.SetTime(3000.0f);
			victim.SetDizzy(true);
			return true;
		}
	}
	public class GSkill3884 : GSkill
	{
		public GSkill3884()
			: base(3884)
		{
			
		}
	}
	public class GSkill3885Stub : GSkillStub
	{
		public class GState1 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 650;
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
				return 2000;
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
				return 400;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();

				player.SetVar1(1);
				player.SetPerform(1);
			}
		}
		public class GState4 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 525;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();

				player.SetVar1(2);
				player.SetPerform(0);
			}
		}
		public GSkill3885Stub()
			: base(3885)
		{
			occupation = 128;
			maxlevel = 1;
			maxlearn = 0;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 2;
			timetype = 3;
			targettype = 0;
			rangetype = 5;
			doenchant = true;
			dobless = false;
			autoattack = false;
			allowform = 0;
			credittype = 0;
			clearmask = 0;
			skill_limit = 1024;
			skillelemsnum = 0;
			skillelemsfactor = 0.000000f;
			serialskill = 0;
			charge = 0;
			chargedist = 0.000000f;
			succeedskillcolor = 1;
			succeedskillcolornum = 1;
			comboskill = 0;
			need_item = true;
			item1_id = 52236;
			item1_num = 1;
			item2_id = -1;
			item2_num = 0;
			item_relation = 0;
			weapon_limit = -1;
			SetAction(0,"¶ªÑ©Çò");
			SetAction(1,"¶ªÑ©Çò");
			SetAction(2,"¶ªÑ©Çò");
			SetAction(3,"¶ªÑ©Çò");
			SetAction(4,"¶ªÑ©Çò");
			SetAction(5,"¶ªÑ©Çò");
			SetAction(6,"¶ªÑ©Çò");
			SetAction(7,"¶ªÑ©Çò");
			SetAction(8,"¶ªÑ©Çò");
			SetAction(9,"¶ªÑ©Çò");
			SetAction(10,"¶ªÑ©Çò");
			SetAction(11,"¶ªÑ©Çò");
			SetAction(12,"¶ªÑ©Çò");
			SetAction(13,"¶ªÑ©Çò");
			SetAction(14,"¶ªÑ©Çò");
			SetAction(15,"¶ªÑ©Çò");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"¶ªÑ©Çò");
			SetAction(19,"¶ªÑ©Çò");
			SetAction(20,"¶ªÑ©Çò");
			SetAction(21,"¶ªÑ©Çò");
			SetAction(22,"¶ªÑ©Çò");
			SetAction(23,"¶ªÑ©Çò");
			SetAction(24,"¶ªÑ©Çò");
			SetAction(25,"¶ªÑ©Çò");
			SetAction(26,"¶ªÑ©Çò");
			SetAction(27,"¶ªÑ©Çò");
			SetAction(28,"¶ªÑ©Çò");
			SetAction(29,"¶ªÑ©Çò");
			SetAction(30,"¶ªÑ©Çò");
			name = "¶ªË®Çò";
			nativename = "¶ªË®Çò";
			icon = "Ë®Çò.dds";
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
		}
		public override int GetExecutetime(GSkill skill)
		{
			return 3575;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			return 6000;
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
			int				skill_charging = skill.GetCharging();

			/*
			if ( player_var1 == 2 )
			d = 120.0f;
			else
			victim.SetProbability(0.0f);
			victim.SetTime(1000.0f);
			victim.SetRatio(((10 * skill_charging / 0x7D0 + 5)));
			victim.SetBuffid(2);
			victim.SetAmount(52206.0f);
			victim.SetValue(0.0f);
			victim.SetCreateobject(true);
			*/
			return true;
		}
	}
	public class GSkill3885 : GSkill
	{
		public GSkill3885()
			: base(3885)
		{
			
		}
	}
	public class GSkill3886Stub : GSkillStub
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
				return 100;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();

				player.SetPerform(1);
			}
		}
		public GSkill3886Stub()
			: base(3886)
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
			SetAction(0,"¼¼ÄÜ¹¥»÷1");
			SetAction(1,"¼¼ÄÜ¹¥»÷1");
			SetAction(2,"¼¼ÄÜ¹¥»÷1");
			SetAction(3,"¼¼ÄÜ¹¥»÷1");
			SetAction(4,"¼¼ÄÜ¹¥»÷1");
			SetAction(5,"¼¼ÄÜ¹¥»÷1");
			SetAction(6,"¼¼ÄÜ¹¥»÷1");
			SetAction(7,"¼¼ÄÜ¹¥»÷1");
			SetAction(8,"¼¼ÄÜ¹¥»÷1");
			SetAction(9,"¼¼ÄÜ¹¥»÷1");
			SetAction(10,"¼¼ÄÜ¹¥»÷1");
			SetAction(11,"¼¼ÄÜ¹¥»÷1");
			SetAction(12,"¼¼ÄÜ¹¥»÷1");
			SetAction(13,"¼¼ÄÜ¹¥»÷1");
			SetAction(14,"¼¼ÄÜ¹¥»÷1");
			SetAction(15,"¼¼ÄÜ¹¥»÷1");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"¼¼ÄÜ¹¥»÷1");
			SetAction(19,"¼¼ÄÜ¹¥»÷1");
			SetAction(20,"¼¼ÄÜ¹¥»÷1");
			SetAction(21,"¼¼ÄÜ¹¥»÷1");
			SetAction(22,"¼¼ÄÜ¹¥»÷1");
			SetAction(23,"¼¼ÄÜ¹¥»÷1");
			SetAction(24,"¼¼ÄÜ¹¥»÷1");
			SetAction(25,"¼¼ÄÜ¹¥»÷1");
			SetAction(26,"¼¼ÄÜ¹¥»÷1");
			SetAction(27,"¼¼ÄÜ¹¥»÷1");
			SetAction(28,"¼¼ÄÜ¹¥»÷1");
			SetAction(29,"¼¼ÄÜ¹¥»÷1");
			SetAction(30,"¼¼ÄÜ¹¥»÷1");
			name = "Ð¡ÂÜÀòµÄÁ¦Á¿";
			nativename = "Ð¡ÂÜÀòµÄÁ¦Á¿";
			icon = "Ð¡ÂÜÀò.dds";
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
			return 500;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			return 10000;
		}
		public override int GetEnmity(GSkill skill)
		{
			return 1;
		}
		public override float GetRadius(GSkill skill)
		{
			return 100.000000f;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 30.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 25.000000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 35.000000f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();

			/*
			if ( player.GetTmplid() == 52260 )
			d = 120.0f;
			else
			victim.SetProbability(0.0f);
			victim.SetRatio(17.0f);
			victim.SetAmount(24.0f);
			victim.SetValue(0.0f);
			victim.SetDispel(true);
			if ( player.GetTmplid() == 52260 )
			v27 = 120.0f;
			else
			victim.SetProbability(0.0f);
			victim.SetTime(15000.0f);
			victim.SetAssault(true);
			victim.SetTime(15000.0f);
			victim.SetBuffid(1);
			if ( player.GetTmplid() == 52260 )
			v26 = 9000.0f;
			else
			victim.SetValue(1.0f);
			victim.SetSubantidizzy(true);
			if ( player.GetTmplid() == 52260 )
			v25 = 120.0f;
			else
			victim.SetProbability(0.0f);
			victim.SetTime(15000.0f);
			victim.SetBuffid(1);
			victim.SetAmount(0.0f);
			victim.SetValue(30.0f);
			victim.SetMpgen(true);
			*/
			return true;
		}
	}
	public class GSkill3886 : GSkill
	{
		public GSkill3886()
			: base(3886)
		{
			
		}
	}
	public class GSkill3887Stub : GSkillStub
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
		public GSkill3887Stub()
			: base(3887)
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
			name = "¹ÖÊåÊåµÄ°®";
			nativename = "¹ÖÊåÊåµÄ°®";
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
		public override float GetPraydistance(GSkill skill)
		{
			return 3.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 1.000000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 10.000000f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_res3 = player.GetRes3();

			/*
			if ( player_res3 > 8999 )
			d = 0.0f;
			else
			victim.SetProbability(100.0f);
			victim.SetGohome(true);
			victim.SetProbability(120.0f);
			victim.SetRatio(581.0f);
			victim.SetAmount(582.0f);
			victim.SetValue(0.0f);
			victim.SetCleartransform(true);
			*/
			return true;
		}
	}
	public class GSkill3887 : GSkill
	{
		public GSkill3887()
			: base(3887)
		{
			
		}
	}
	public class GSkill3888Stub : GSkillStub
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
				return 400;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();

				player.SetPerform(1);
			}
		}
		public GSkill3888Stub()
			: base(3888)
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
			SetAction(0,"ÏÉ_±ù±¬");
			SetAction(1,"ÏÉ_±ù±¬");
			SetAction(2,"ÏÉ_±ù±¬");
			SetAction(3,"ÏÉ_±ù±¬");
			SetAction(4,"ÏÉ_±ù±¬");
			SetAction(5,"ÏÉ_±ù±¬");
			SetAction(6,"ÏÉ_±ù±¬");
			SetAction(7,"ÏÉ_±ù±¬");
			SetAction(8,"ÏÉ_±ù±¬");
			SetAction(9,"ÏÉ_±ù±¬");
			SetAction(10,"ÏÉ_±ù±¬");
			SetAction(11,"ÏÉ_±ù±¬");
			SetAction(12,"ÏÉ_±ù±¬");
			SetAction(13,"ÏÉ_±ù±¬");
			SetAction(14,"ÏÉ_±ù±¬");
			SetAction(15,"ÏÉ_±ù±¬");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"Æï³Ë_ÏÉ_±ù±¬");
			SetAction(19,"Æï³Ë_ÏÉ_±ù±¬");
			SetAction(20,"Æï³Ë_ÏÉ_±ù±¬");
			SetAction(21,"Æï³Ë_ÏÉ_±ù±¬");
			SetAction(22,"Æï³Ë_ÏÉ_±ù±¬");
			SetAction(23,"Æï³Ë_ÏÉ_±ù±¬");
			SetAction(24,"Æï³Ë_ÏÉ_±ù±¬");
			SetAction(25,"Æï³Ë_ÏÉ_±ù±¬");
			SetAction(26,"Æï³Ë_ÏÉ_±ù±¬");
			SetAction(27,"Æï³Ë_ÏÉ_±ù±¬");
			SetAction(28,"Æï³Ë_ÏÉ_±ù±¬");
			SetAction(29,"Æï³Ë_ÏÉ_±ù±¬");
			SetAction(30,"Æï³Ë_ÏÉ_±ù±¬");
			name = "Éîº£Ðþ±ùÊõ";
			nativename = "Éîº£Ðþ±ùÊõ";
			icon = "±ù·âÊõ.dds";
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
			return 10000;
		}
		public override int GetEnmity(GSkill skill)
		{
			return 1;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 25.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 20.000000f;
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
			if ( player.GetTmplid() != 52300
			&& (v3 = player, GNET::PlayerWrapper::GetTmplid(v3) != 52313)
			&& (v4 = player, GNET::PlayerWrapper::GetTmplid(v4) != 52314) )
			d = 0.0f;
			else
			victim.SetProbability(120.0f);
			victim.SetTime(20000.0f);
			victim.SetRatio(0.0f);
			victim.SetBuffid(1);
			victim.SetFrozen(true);
			*/
			return true;
		}
	}
	public class GSkill3888 : GSkill
	{
		public GSkill3888()
			: base(3888)
		{
			
		}
	}
	public class GSkill3889Stub : GSkillStub
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
				return 500;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();

				player.SetPerform(1);
			}
		}
		public GSkill3889Stub()
			: base(3889)
		{
			occupation = 129;
			maxlevel = 1;
			maxlearn = 0;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 3;
			timetype = 0;
			targettype = 0;
			rangetype = 6;
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
			SetAction(0,"ÇàÔÆÃÅ_¶¯Îï²¶×½");
			SetAction(1,"ÇàÔÆÃÅ_¶¯Îï²¶×½");
			SetAction(2,"¹íÍõ×Ú_¶¯Îï²¶×½");
			SetAction(3,"ºÏ»¶ÅÉ_¶¯Îï²¶×½");
			SetAction(4,"ÌìÒôËÂ_¶¯Îï²¶×½");
			SetAction(5,"¹íµÀ_¶¯Îï²¶×½");
			SetAction(6,"ÇàÔÆÃÅ_¶¯Îï²¶×½");
			SetAction(7,"ÊÞÉñ_¶¯Îï²¶×½");
			SetAction(8,"ºüÑý_¶¯Îï²¶×½");
			SetAction(9,"ÊÞÉñ_¶¯Îï²¶×½");
			SetAction(10,"»³¹â_¶¯Îï²¶×½");
			SetAction(11,"ÊÞÉñ_¶¯Îï²¶×½");
			SetAction(12,"Ìì»ª_¶¯Îï²¶×½");
			SetAction(13,"ÁéÙí_¶¯Îï²¶×½");
			SetAction(14,"Ó¢ÕÐ_¶¯Îï²¶×½");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"ÇàÔÆÃÅ_Æï³Ë_¶¯Îï²¶×½");
			SetAction(19,"ÇàÔÆÃÅ_Æï³Ë_¶¯Îï²¶×½");
			SetAction(20,"¹íÍõ×Ú_Æï³Ë_¶¯Îï²¶×½");
			SetAction(21,"ºÏ»¶ÅÉ_Æï³Ë_¶¯Îï²¶×½");
			SetAction(22,"ÌìÒôËÂ_Æï³Ë_¶¯Îï²¶×½");
			SetAction(23,"¹íµÀ_Æï³Ë_¶¯Îï²¶×½");
			SetAction(24,"ÇàÔÆÃÅ_Æï³Ë_¶¯Îï²¶×½");
			SetAction(25,"ÊÞÉñ_Æï³Ë_¶¯Îï²¶×½");
			SetAction(26,"ºüÑý_Æï³Ë_¶¯Îï²¶×½");
			SetAction(27,"ÊÞÉñ_Æï³Ë_¶¯Îï²¶×½");
			SetAction(28,"»³¹â_Æï³Ë_¶¯Îï²¶×½");
			SetAction(29,"ÊÞÉñ_Æï³Ë_¶¯Îï²¶×½");
			SetAction(30,"Ìì»ª_Æï³Ë_¶¯Îï²¶×½");
			name = "²¶Óã´ïÈË";
			nativename = "²¶Óã´ïÈË";
			icon = "²¶×½.dds";
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
			return 2500;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			return 1000;
		}
		public override float GetRadius(GSkill skill)
		{
			return 5.000000f;
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
			return 25.000000f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_maxhp = player.GetMaxhp();

			/*
			if ( player.GetTmplid() == 52281 )
			{
			d = 100.0f;
			}
			else
			{
			if ( player.GetTmplid() == 52282 )
			v28 = 70.0f;
			else
			d = 0.0f;
			}
			victim.SetProbability(d);
			victim.SetValue(player_maxhp);
			victim.SetDirecthurt(true);
			if ( player.GetTmplid() == 52283 )
			{
			v27 = 40.0f;
			}
			else
			{
			if ( player.GetTmplid() == 52284 )
			v26 = 30.0f;
			else
			v27 = 0.0f;
			}
			victim.SetProbability(v27);
			victim.SetValue(player_maxhp);
			victim.SetDirecthurt(true);
			if ( player.GetTmplid() == 52285 )
			{
			v25 = 20.0f;
			}
			else
			{
			if ( player.GetTmplid() == 52286 )
			v24 = 10.0f;
			else
			v25 = 0.0f;
			}
			victim.SetProbability(v25);
			victim.SetValue(player_maxhp);
			victim.SetDirecthurt(true);
			*/
			return true;
		}
	}
	public class GSkill3889 : GSkill
	{
		public GSkill3889()
			: base(3889)
		{
			
		}
	}
}
