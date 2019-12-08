using System;
using System.Text;

namespace SKILL
{
	public class GSkill1930Stub : GSkillStub
	{
		public GSkill1930Stub()
			: base(1930)
		{
			occupation = 129;
			maxlevel = 1;
			maxlearn = 1;
			eventflag = 0;
			spcost = 0;
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
			name = "ÑªÒûÌì¾§";
			nativename = "ÑªÒûÌì¾§";
			icon = "ÑªÒûÌì¾§.dds";
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
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_hp = player.GetHp();
			int				player_maxhp = player.GetMaxhp();

			victim.SetProbability(((120 * norm(player_hp / player_maxhp))));
			victim.SetRatio(1800.0f);
			victim.SetAmount(1.0f);
			victim.SetValue(22457.0f);
			victim.SetCreateitem(true);
			victim.SetProbability(((120 * norm((player_hp / player_maxhp)))));
			victim.SetTime(100.0f);
			victim.SetBuffid(0);
			victim.SetAmount(99.0f);
			victim.SetValue(((player_hp - 100)));
			victim.SetHpleak2(true);
			return true;
		}
	}
	public class GSkill1930 : GSkill
	{
		public GSkill1930()
			: base(1930)
		{
			
		}
	}
	public class GSkill1931Stub : GSkillStub
	{
		public class GState1 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 200;
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
		public GSkill1931Stub()
			: base(1931)
		{
			occupation = 128;
			maxlevel = 500;
			maxlearn = 500;
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
			skill_limit = 32;
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
			name = "¿É¿ØÖÆÊ±¼ä´ÎÊýµÄÎÞµÐ";
			nativename = "¿É¿ØÖÆÊ±¼ä´ÎÊýµÄÎÞµÐ";
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
			return 500;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			return 500;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();

			victim.SetProbability(100.0f);
			victim.SetTime(((1000 * skill_level)));
			victim.SetBuffid(1);
			victim.SetValue(99999.0f);
			victim.SetAdddefence(true);
			victim.SetTime(((1000 * skill_level)));
			victim.SetValue(((20 * skill_level)));
			victim.SetBlessed(true);
			return true;
		}
	}
	public class GSkill1931 : GSkill
	{
		public GSkill1931()
			: base(1931)
		{
			
		}
	}
	public class GSkill1932Stub : GSkillStub
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
		public GSkill1932Stub()
			: base(1932)
		{
			occupation = 129;
			maxlevel = 10;
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
			need_item = true;
			item1_id = 23019;
			item1_num = 1;
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
			name = "ÁèÏö¸±±¾±¦Ïä";
			nativename = "ÁèÏö¸±±¾±¦Ïä";
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

			victim.SetProbability(100.0f);
			victim.SetRatio(0.0f);
			victim.SetAmount(1.0f);
			victim.SetValue(23018.0f);
			victim.SetCreateitem(true);
			return true;
		}
	}
	public class GSkill1932 : GSkill
	{
		public GSkill1932()
			: base(1932)
		{
			
		}
	}
	public class GSkill1933Stub : GSkillStub
	{
		public GSkill1933Stub()
			: base(1933)
		{
			occupation = 129;
			maxlevel = 1;
			maxlearn = 1;
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
			name = "ÐÂÊÖ½±²âÊÔ1";
			nativename = "ÐÂÊÖ½±²âÊÔ1";
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

			victim.SetProbability(100.0f);
			victim.SetRatio(0.0f);
			victim.SetAmount(1.0f);
			victim.SetValue(23801.0f);
			victim.SetCreateitem(true);
			victim.SetProbability(100.0f);
			victim.SetRatio(0.0f);
			victim.SetAmount(10.0f);
			victim.SetValue(685.0f);
			victim.SetCreateitem(true);
			victim.SetProbability(100.0f);
			victim.SetRatio(0.0f);
			victim.SetAmount(10.0f);
			victim.SetValue(4006.0f);
			victim.SetCreateitem(true);
			return true;
		}
	}
	public class GSkill1933 : GSkill
	{
		public GSkill1933()
			: base(1933)
		{
			
		}
	}
	public class GSkill1934Stub : GSkillStub
	{
		public GSkill1934Stub()
			: base(1934)
		{
			occupation = 129;
			maxlevel = 1;
			maxlearn = 1;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 13;
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
			name = "ÐÂÊÖ½±²âÊÔ2";
			nativename = "ÐÂÊÖ½±²âÊÔ2";
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
	public class GSkill1934 : GSkill
	{
		public GSkill1934()
			: base(1934)
		{
			
		}
	}
	public class GSkill1935Stub : GSkillStub
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
		public GSkill1935Stub()
			: base(1935)
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
			SetAction(0,"¹íÍõ×Ú_¼á¶Ü");
			SetAction(1,"ÇàÔÆÃÅ_¼á¶Ü");
			SetAction(2,"¹íÍõ×Ú_¼á¶Ü");
			SetAction(3,"ºÏ»¶ÅÉ_¼á¶Ü");
			SetAction(4,"ÌìÒôËÂ_¼á¶Ü");
			SetAction(5,"¹íµÀ_¼á¶Ü");
			SetAction(6,"·ÙÏã_¼á¶Ü");
			SetAction(7,"ÊÞÉñ_¼á¶Ü");
			SetAction(8,"ºüÑý_¼á¶Ü");
			SetAction(9,"ÐùÔ¯_¼á¶Ü");
			SetAction(10,"»³¹â_¼á¶Ü");
			SetAction(11,"Ì«ê»_¼á¶Ü");
			SetAction(12,"Ìì»ª_¼á¶Ü");
			SetAction(13,"ÁéÙí_¼á¶Ü");
			SetAction(14,"Ó¢ÕÐ_¼á¶Ü");
			SetAction(15,"ÎäÆ÷´óÊ¦_¼á¶Ü");
			SetAction(16,"ÔªËØ´óÊ¦_¼á¶Ü");
			SetAction(17,"ÌìÒôËÂ_¼á¶Ü");
			SetAction(18,"¹íÍõ×Ú_Æï³Ë_¼á¶Ü");
			SetAction(19,"ÇàÔÆÃÅ_Æï³Ë_¼á¶Ü");
			SetAction(20,"¹íÍõ×Ú_Æï³Ë_¼á¶Ü");
			SetAction(21,"ºÏ»¶ÅÉ_Æï³Ë_¼á¶Ü");
			SetAction(22,"ÌìÒôËÂ_Æï³Ë_¼á¶Ü");
			SetAction(23,"¹íµÀ_Æï³Ë_¼á¶Ü");
			SetAction(24,"·ÙÏã_Æï³Ë_¼á¶Ü");
			SetAction(25,"ÊÞÉñ_Æï³Ë_¼á¶Ü");
			SetAction(26,"ºüÑý_Æï³Ë_¼á¶Ü");
			SetAction(27,"ÐùÔ¯_Æï³Ë_¼á¶Ü");
			SetAction(28,"»³¹â_Æï³Ë_¼á¶Ü");
			SetAction(29,"Ì«ê»_Æï³Ë_¼á¶Ü");
			SetAction(30,"Ìì»ª_Æï³Ë_¼á¶Ü");
			name = "¼á¶Ü";
			nativename = "¼á¶Ü";
			icon = "¼á¶Ü.dds";
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
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetProbability(120.0f);
			victim.SetTime(20000.0f);
			victim.SetRatio(1.0f);
			victim.SetBuffid(1);
			victim.SetIncdefence(true);
			return true;
		}
	}
	public class GSkill1935 : GSkill
	{
		public GSkill1935()
			: base(1935)
		{
			
		}
	}
	public class GSkill1936Stub : GSkillStub
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
		public GSkill1936Stub()
			: base(1936)
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
			SetAction(0,"¹íÍõ×Ú_¾£¼¬");
			SetAction(1,"ÇàÔÆÃÅ_¾£¼¬");
			SetAction(2,"¹íÍõ×Ú_¾£¼¬");
			SetAction(3,"ºÏ»¶ÅÉ_¾£¼¬");
			SetAction(4,"ÌìÒôËÂ_¾£¼¬");
			SetAction(5,"¹íµÀ_¾£¼¬");
			SetAction(6,"·ÙÏã_¾£¼¬");
			SetAction(7,"ÊÞÉñ_¾£¼¬");
			SetAction(8,"ºüÑý_¾£¼¬");
			SetAction(9,"ÐùÔ¯_¾£¼¬");
			SetAction(10,"»³¹â_¾£¼¬");
			SetAction(11,"Ì«ê»_¾£¼¬");
			SetAction(12,"Ìì»ª_¾£¼¬");
			SetAction(13,"ÁéÙí_¾£¼¬");
			SetAction(14,"Ó¢ÕÐ_¾£¼¬");
			SetAction(15,"ÔªËØ´óÊ¦_¾£¼¬");
			SetAction(16,"ÔªËØ´óÊ¦_¾£¼¬");
			SetAction(17,"ÌìÒôËÂ_¾£¼¬");
			SetAction(18,"¹íÍõ×Ú_Æï³Ë_¾£¼¬");
			SetAction(19,"ÇàÔÆÃÅ_Æï³Ë_¾£¼¬");
			SetAction(20,"¹íÍõ×Ú_Æï³Ë_¾£¼¬");
			SetAction(21,"ºÏ»¶ÅÉ_Æï³Ë_¾£¼¬");
			SetAction(22,"ÌìÒôËÂ_Æï³Ë_¾£¼¬");
			SetAction(23,"¹íµÀ_Æï³Ë_¾£¼¬");
			SetAction(24,"·ÙÏã_Æï³Ë_¾£¼¬");
			SetAction(25,"ÊÞÉñ_Æï³Ë_¾£¼¬");
			SetAction(26,"ºüÑý_Æï³Ë_¾£¼¬");
			SetAction(27,"ÐùÔ¯_Æï³Ë_¾£¼¬");
			SetAction(28,"»³¹â_Æï³Ë_¾£¼¬");
			SetAction(29,"Ì«ê»_Æï³Ë_¾£¼¬");
			SetAction(30,"Ìì»ª_Æï³Ë_¾£¼¬");
			name = "¾£¼¬";
			nativename = "¾£¼¬";
			icon = "¾£¼¬.dds";
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
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetProbability(120.0f);
			victim.SetTime(20000.0f);
			victim.SetRatio(0.30000001f);
			victim.SetAmount(0.0f);
			victim.SetValue(100.0f);
			victim.SetRetort(true);
			return true;
		}
	}
	public class GSkill1936 : GSkill
	{
		public GSkill1936()
			: base(1936)
		{
			
		}
	}
	public class GSkill1937Stub : GSkillStub
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
		public GSkill1937Stub()
			: base(1937)
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
			SetAction(0,"¹íÍõ×Ú_»Ø´º");
			SetAction(1,"ÇàÔÆÃÅ_»Ø´º");
			SetAction(2,"¹íÍõ×Ú_»Ø´º");
			SetAction(3,"ºÏ»¶ÅÉ_»Ø´º");
			SetAction(4,"ÌìÒôËÂ_»Ø´º");
			SetAction(5,"¹íµÀ_»Ø´º");
			SetAction(6,"·ÙÏã_»Ø´º");
			SetAction(7,"ÊÞÉñ_»Ø´º");
			SetAction(8,"ºüÑý_»Ø´º");
			SetAction(9,"ÐùÔ¯_»Ø´º");
			SetAction(10,"»³¹â_»Ø´º");
			SetAction(11,"Ì«ê»_»Ø´º");
			SetAction(12,"Ìì»ª_»Ø´º");
			SetAction(13,"ÁéÙí_»Ø´º");
			SetAction(14,"Ó¢ÕÐ_»Ø´º");
			SetAction(15,"ÔªËØ´óÊ¦_»Ø´º");
			SetAction(16,"ÔªËØ´óÊ¦_»Ø´º");
			SetAction(17,"ÌìÒôËÂ_»Ø´º");
			SetAction(18,"¹íÍõ×Ú_Æï³Ë_»Ø´º");
			SetAction(19,"ÇàÔÆÃÅ_Æï³Ë_»Ø´º");
			SetAction(20,"¹íÍõ×Ú_Æï³Ë_»Ø´º");
			SetAction(21,"ºÏ»¶ÅÉ_Æï³Ë_»Ø´º");
			SetAction(22,"ÌìÒôËÂ_Æï³Ë_»Ø´º");
			SetAction(23,"¹íµÀ_Æï³Ë_»Ø´º");
			SetAction(24,"·ÙÏã_Æï³Ë_»Ø´º");
			SetAction(25,"ÊÞÉñ_Æï³Ë_»Ø´º");
			SetAction(26,"ºüÑý_Æï³Ë_»Ø´º");
			SetAction(27,"ÐùÔ¯_Æï³Ë_»Ø´º");
			SetAction(28,"»³¹â_Æï³Ë_»Ø´º");
			SetAction(29,"Ì«ê»_Æï³Ë_»Ø´º");
			SetAction(30,"Ìì»ª_Æï³Ë_»Ø´º");
			name = "»Ø´º";
			nativename = "»Ø´º";
			icon = "»Ø´º.dds";
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
			int				player_maxhp = player.GetMaxhp();

			victim.SetProbability(120.0f);
			victim.SetTime(20000.0f);
			victim.SetRatio(0.0f);
			victim.SetBuffid(1);
			victim.SetAmount(12.0f);
			victim.SetValue(((3 * player_maxhp)));
			victim.SetHpgen(true);
			return true;
		}
	}
	public class GSkill1937 : GSkill
	{
		public GSkill1937()
			: base(1937)
		{
			
		}
	}
	public class GSkill1938Stub : GSkillStub
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
		public GSkill1938Stub()
			: base(1938)
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
			SetAction(0,"¹íÍõ×Ú_È¼ÉÕ");
			SetAction(1,"ÇàÔÆÃÅ_È¼ÉÕ");
			SetAction(2,"¹íÍõ×Ú_È¼ÉÕ");
			SetAction(3,"ºÏ»¶ÅÉ_È¼ÉÕ");
			SetAction(4,"ÌìÒôËÂ_È¼ÉÕ");
			SetAction(5,"¹íµÀ_È¼ÉÕ");
			SetAction(6,"·ÙÏã_È¼ÉÕ");
			SetAction(7,"ÊÞÉñ_È¼ÉÕ");
			SetAction(8,"ºüÑý_È¼ÉÕ");
			SetAction(9,"ÐùÔ¯_È¼ÉÕ");
			SetAction(10,"»³¹â_È¼ÉÕ");
			SetAction(11,"Ì«ê»_È¼ÉÕ");
			SetAction(12,"Ìì»ª_È¼ÉÕ");
			SetAction(13,"ÁéÙí_È¼ÉÕ");
			SetAction(14,"Ó¢ÕÐ_È¼ÉÕ");
			SetAction(15,"ÔªËØ´óÊ¦_È¼ÉÕ");
			SetAction(16,"ÔªËØ´óÊ¦_È¼ÉÕ");
			SetAction(17,"ÌìÒôËÂ_È¼ÉÕ");
			SetAction(18,"¹íÍõ×Ú_Æï³Ë_È¼ÉÕ");
			SetAction(19,"ÇàÔÆÃÅ_Æï³Ë_È¼ÉÕ");
			SetAction(20,"¹íÍõ×Ú_Æï³Ë_È¼ÉÕ");
			SetAction(21,"ºÏ»¶ÅÉ_Æï³Ë_È¼ÉÕ");
			SetAction(22,"ÌìÒôËÂ_Æï³Ë_È¼ÉÕ");
			SetAction(23,"¹íµÀ_Æï³Ë_È¼ÉÕ");
			SetAction(24,"·ÙÏã_Æï³Ë_È¼ÉÕ");
			SetAction(25,"ÊÞÉñ_Æï³Ë_È¼ÉÕ");
			SetAction(26,"ºüÑý_Æï³Ë_È¼ÉÕ");
			SetAction(27,"ÐùÔ¯_Æï³Ë_È¼ÉÕ");
			SetAction(28,"»³¹â_Æï³Ë_È¼ÉÕ");
			SetAction(29,"Ì«ê»_Æï³Ë_È¼ÉÕ");
			SetAction(30,"Ìì»ª_Æï³Ë_È¼ÉÕ");
			name = "È¼ÉÕ";
			nativename = "È¼ÉÕ";
			icon = "È¼ÉÕ.dds";
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
			victim.SetHpleak(true);
			return true;
		}
	}
	public class GSkill1938 : GSkill
	{
		public GSkill1938()
			: base(1938)
		{
			
		}
	}
	public class GSkill1939Stub : GSkillStub
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
		public GSkill1939Stub()
			: base(1939)
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
			doenchant = true;
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
			SetAction(0,"¹íÍõ×Ú_ÆÆ¼×");
			SetAction(1,"ÇàÔÆÃÅ_ÆÆ¼×");
			SetAction(2,"¹íÍõ×Ú_ÆÆ¼×");
			SetAction(3,"ºÏ»¶ÅÉ_ÆÆ¼×");
			SetAction(4,"ÌìÒôËÂ_ÆÆ¼×");
			SetAction(5,"¹íµÀ_ÆÆ¼×");
			SetAction(6,"·ÙÏã_ÆÆ¼×");
			SetAction(7,"ÊÞÉñ_ÆÆ¼×");
			SetAction(8,"ºüÑý_ÆÆ¼×");
			SetAction(9,"ÐùÔ¯_ÆÆ¼×");
			SetAction(10,"»³¹â_ÆÆ¼×");
			SetAction(11,"Ì«ê»_ÆÆ¼×");
			SetAction(12,"Ìì»ª_ÆÆ¼×");
			SetAction(13,"ÁéÙí_ÆÆ¼×");
			SetAction(14,"Ó¢ÕÐ_ÆÆ¼×");
			SetAction(15,"ÔªËØ´óÊ¦_ÆÆ¼×");
			SetAction(16,"ÔªËØ´óÊ¦_ÆÆ¼×");
			SetAction(17,"ÌìÒôËÂ_ÆÆ¼×");
			SetAction(18,"¹íÍõ×Ú_Æï³Ë_ÆÆ¼×");
			SetAction(19,"ÇàÔÆÃÅ_Æï³Ë_ÆÆ¼×");
			SetAction(20,"¹íÍõ×Ú_Æï³Ë_ÆÆ¼×");
			SetAction(21,"ºÏ»¶ÅÉ_Æï³Ë_ÆÆ¼×");
			SetAction(22,"ÌìÒôËÂ_Æï³Ë_ÆÆ¼×");
			SetAction(23,"¹íµÀ_Æï³Ë_ÆÆ¼×");
			SetAction(24,"·ÙÏã_Æï³Ë_ÆÆ¼×");
			SetAction(25,"ÊÞÉñ_Æï³Ë_ÆÆ¼×");
			SetAction(26,"ºüÑý_Æï³Ë_ÆÆ¼×");
			SetAction(27,"ÐùÔ¯_Æï³Ë_ÆÆ¼×");
			SetAction(28,"»³¹â_Æï³Ë_ÆÆ¼×");
			SetAction(29,"Ì«ê»_Æï³Ë_ÆÆ¼×");
			SetAction(30,"Ìì»ª_Æï³Ë_ÆÆ¼×");
			name = "ÆÆ¼×";
			nativename = "ÆÆ¼×";
			icon = "ÆÆ¼×.dds";
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
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetProbability(120.0f);
			victim.SetTime(8000.0f);
			victim.SetRatio(0.5f);
			victim.SetBuffid(1);
			victim.SetDecdefence(true);
			return true;
		}
	}
	public class GSkill1939 : GSkill
	{
		public GSkill1939()
			: base(1939)
		{
			
		}
	}
}
