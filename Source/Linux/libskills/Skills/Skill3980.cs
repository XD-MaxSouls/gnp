using System;
using System.Text;

namespace SKILL
{
	public class GSkill3980Stub : GSkillStub
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
		public GSkill3980Stub()
			: base(3980)
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
			SetAction(0,"¹íÍõ×Ú_É¢¾¡");
			SetAction(1,"ÇàÔÆÃÅ_É¢¾¡");
			SetAction(2,"¹íÍõ×Ú_É¢¾¡");
			SetAction(3,"ºÏ»¶ÅÉ_É¢¾¡");
			SetAction(4,"ÌìÒôËÂ_É¢¾¡");
			SetAction(5,"¹íµÀ_É¢¾¡");
			SetAction(6,"·ÙÏã¹È_É¢¾¡");
			SetAction(7,"ÊÞÉñ_É¢¾¡");
			SetAction(8,"ºüÑý_É¢¾¡");
			SetAction(9,"ÐùÔ¯_É¢¾¡");
			SetAction(10,"»³¹â_É¢¾¡");
			SetAction(11,"Ì«ê»_É¢¾¡");
			SetAction(12,"Ìì»ª_É¢¾¡");
			SetAction(13,"ÁéÙí_É¢¾¡");
			SetAction(14,"Ó¢ÕÐ_É¢¾¡");
			SetAction(15,"0");
			SetAction(16,"0");
			SetAction(17,"¹éÔÆ_ÉèÖÃÆøÑª");
			SetAction(18,"¹íÍõ×Ú_Æï³Ë_É¢¾¡");
			SetAction(19,"ÇàÔÆÃÅ_Æï³Ë_É¢¾¡");
			SetAction(20,"¹íÍõ×Ú_Æï³Ë_É¢¾¡");
			SetAction(21,"ºÏ»¶ÅÉ_Æï³Ë_É¢¾¡");
			SetAction(22,"ÌìÒôËÂ_Æï³Ë_É¢¾¡");
			SetAction(23,"¹íµÀ_Æï³Ë_É¢¾¡");
			SetAction(24,"·ÙÏã¹È_Æï³Ë_É¢¾¡");
			SetAction(25,"ÊÞÉñ_Æï³Ë_É¢¾¡");
			SetAction(26,"ºüÑý_Æï³Ë_É¢¾¡");
			SetAction(27,"ÐùÔ¯_Æï³Ë_É¢¾¡");
			SetAction(28,"»³¹â_Æï³Ë_É¢¾¡");
			SetAction(29,"Ì«ê»_Æï³Ë_É¢¾¡");
			SetAction(30,"Ìì»ª_Æï³Ë_É¢¾¡");
			name = "°ËÃÅ¶Ý¼×¡¤¾°ºü";
			nativename = "°ËÃÅ¶Ý¼×¡¤¾°ºü";
			icon = "°×ºüÕÙ»½·û.dds";
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
			victim.SetTime(120000.0f);
			victim.SetRatio(1.0f);
			victim.SetBuffid(0);
			victim.SetAmount(2.0f);
			victim.SetValue(52420.0f);
			victim.SetSummon(true);
			return true;
		}
	}
	public class GSkill3980 : GSkill
	{
		public GSkill3980()
			: base(3980)
		{
			
		}
	}
	public class GSkill3981Stub : GSkillStub
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
		public GSkill3981Stub()
			: base(3981)
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
			SetAction(0,"¹íÍõ×Ú_É¢¾¡");
			SetAction(1,"ÇàÔÆÃÅ_É¢¾¡");
			SetAction(2,"¹íÍõ×Ú_É¢¾¡");
			SetAction(3,"ºÏ»¶ÅÉ_É¢¾¡");
			SetAction(4,"ÌìÒôËÂ_É¢¾¡");
			SetAction(5,"¹íµÀ_É¢¾¡");
			SetAction(6,"·ÙÏã¹È_É¢¾¡");
			SetAction(7,"ÊÞÉñ_É¢¾¡");
			SetAction(8,"ºüÑý_É¢¾¡");
			SetAction(9,"ÐùÔ¯_É¢¾¡");
			SetAction(10,"»³¹â_É¢¾¡");
			SetAction(11,"Ì«ê»_É¢¾¡");
			SetAction(12,"Ìì»ª_É¢¾¡");
			SetAction(13,"ÁéÙí_É¢¾¡");
			SetAction(14,"Ó¢ÕÐ_É¢¾¡");
			SetAction(15,"0");
			SetAction(16,"0");
			SetAction(17,"¹éÔÆ_ÉèÖÃÆøÑª");
			SetAction(18,"¹íÍõ×Ú_Æï³Ë_É¢¾¡");
			SetAction(19,"ÇàÔÆÃÅ_Æï³Ë_É¢¾¡");
			SetAction(20,"¹íÍõ×Ú_Æï³Ë_É¢¾¡");
			SetAction(21,"ºÏ»¶ÅÉ_Æï³Ë_É¢¾¡");
			SetAction(22,"ÌìÒôËÂ_Æï³Ë_É¢¾¡");
			SetAction(23,"¹íµÀ_Æï³Ë_É¢¾¡");
			SetAction(24,"·ÙÏã¹È_Æï³Ë_É¢¾¡");
			SetAction(25,"ÊÞÉñ_Æï³Ë_É¢¾¡");
			SetAction(26,"ºüÑý_Æï³Ë_É¢¾¡");
			SetAction(27,"ÐùÔ¯_Æï³Ë_É¢¾¡");
			SetAction(28,"»³¹â_Æï³Ë_É¢¾¡");
			SetAction(29,"Ì«ê»_Æï³Ë_É¢¾¡");
			SetAction(30,"Ìì»ª_Æï³Ë_É¢¾¡");
			name = "°ËÃÅ¶Ý¼×¡¤¶ÅÐÐ";
			nativename = "°ËÃÅ¶Ý¼×¡¤¶ÅÐÐ";
			icon = "±ù¾§ÓñÁ«.dds";
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
			victim.SetTime(8000.0f);
			victim.SetRatio(0.0f);
			victim.SetBuffid(2);
			victim.SetFrozen(true);
			return true;
		}
	}
	public class GSkill3981 : GSkill
	{
		public GSkill3981()
			: base(3981)
		{
			
		}
	}
	public class GSkill3982Stub : GSkillStub
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
		public GSkill3982Stub()
			: base(3982)
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
			SetAction(0,"¹íÍõ×Ú_¼á¶Ü");
			SetAction(1,"ÇàÔÆÃÅ_¼á¶Ü");
			SetAction(2,"¹íÍõ×Ú_¼á¶Ü");
			SetAction(3,"ºÏ»¶ÅÉ_¼á¶Ü");
			SetAction(4,"ÌìÒôËÂ_¼á¶Ü");
			SetAction(5,"¹íµÀ_¼á¶Ü");
			SetAction(6,"·ÙÏã¹È_¼á¶Ü");
			SetAction(7,"ÊÞÉñ_¼á¶Ü");
			SetAction(8,"ºüÑý_¼á¶Ü");
			SetAction(9,"ÐùÔ¯_¼á¶Ü");
			SetAction(10,"»³¹â_¼á¶Ü");
			SetAction(11,"Ì«ê»_¼á¶Ü");
			SetAction(12,"Ìì»ª_¼á¶Ü");
			SetAction(13,"ÁéÙí_¼á¶Ü");
			SetAction(14,"Ó¢ÕÐ_¼á¶Ü");
			SetAction(15,"ÔªËØ´óÊ¦_¼á¶Ü");
			SetAction(16,"ÔªËØ´óÊ¦_¼á¶Ü");
			SetAction(17,"¹éÔÆ_ÉèÖÃÆøÑª");
			SetAction(18,"¹íÍõ×Ú_Æï³Ë_¼á¶Ü");
			SetAction(19,"ÇàÔÆÃÅ_Æï³Ë_¼á¶Ü");
			SetAction(20,"¹íÍõ×Ú_Æï³Ë_¼á¶Ü");
			SetAction(21,"ºÏ»¶ÅÉ_Æï³Ë_¼á¶Ü");
			SetAction(22,"ÌìÒôËÂ_Æï³Ë_¼á¶Ü");
			SetAction(23,"¹íµÀ_Æï³Ë_¼á¶Ü");
			SetAction(24,"·ÙÏã¹È_Æï³Ë_¼á¶Ü");
			SetAction(25,"ÊÞÉñ_Æï³Ë_¼á¶Ü");
			SetAction(26,"ºüÑý_Æï³Ë_¼á¶Ü");
			SetAction(27,"ÐùÔ¯_Æï³Ë_¼á¶Ü");
			SetAction(28,"»³¹â_Æï³Ë_¼á¶Ü");
			SetAction(29,"Ì«ê»_Æï³Ë_¼á¶Ü");
			SetAction(30,"Ìì»ª_Æï³Ë_¼á¶Ü");
			name = "°ËÃÅ¶Ý¼×¡¤¾øÉË";
			nativename = "°ËÃÅ¶Ý¼×¡¤¾øÉË";
			icon = "µêÂô3µµÍ¨ÓÃ½ðÉí.dds";
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

			victim.SetTime(10000.0f);
			victim.SetInvincible(true);
			return true;
		}
	}
	public class GSkill3982 : GSkill
	{
		public GSkill3982()
			: base(3982)
		{
			
		}
	}
	public class GSkill3983Stub : GSkillStub
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
		public GSkill3983Stub()
			: base(3983)
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
			SetAction(0,"¹íÍõ×Ú_ÆÆ¼×");
			SetAction(1,"ÇàÔÆÃÅ_ÆÆ¼×");
			SetAction(2,"¹íÍõ×Ú_ÆÆ¼×");
			SetAction(3,"ºÏ»¶ÅÉ_ÆÆ¼×");
			SetAction(4,"ÌìÒôËÂ_ÆÆ¼×");
			SetAction(5,"¹íµÀ_ÆÆ¼×");
			SetAction(6,"·ÙÏã¹È_ÆÆ¼×");
			SetAction(7,"ÊÞÉñ_ÆÆ¼×");
			SetAction(8,"ºüÑý_ÆÆ¼×");
			SetAction(9,"ÐùÔ¯_ÆÆ¼×");
			SetAction(10,"»³¹â_ÆÆ¼×");
			SetAction(11,"Ì«ê»_ÆÆ¼×");
			SetAction(12,"Ìì»ª_ÆÆ¼×");
			SetAction(13,"ÁéÙí_ÆÆ¼×");
			SetAction(14,"Ó¢ÕÐ_ÆÆ¼×");
			SetAction(15,"0");
			SetAction(16,"0");
			SetAction(17,"¹éÔÆ_ÆïÉèÖÃÆøÑª");
			SetAction(18,"¹íÍõ×Ú_Æï³Ë_ÆÆ¼×");
			SetAction(19,"ÇàÔÆÃÅ_Æï³Ë_ÆÆ¼×");
			SetAction(20,"¹íÍõ×Ú_Æï³Ë_ÆÆ¼×");
			SetAction(21,"ºÏ»¶ÅÉ_Æï³Ë_ÆÆ¼×");
			SetAction(22,"ÌìÒôËÂ_Æï³Ë_ÆÆ¼×");
			SetAction(23,"¹íµÀ_Æï³Ë_ÆÆ¼×");
			SetAction(24,"·ÙÏã¹È_Æï³Ë_ÆÆ¼×");
			SetAction(25,"ÊÞÉñ_Æï³Ë_ÆÆ¼×");
			SetAction(26,"ºüÑý_Æï³Ë_ÆÆ¼×");
			SetAction(27,"ÐùÔ¯_Æï³Ë_ÆÆ¼×");
			SetAction(28,"»³¹â_Æï³Ë_ÆÆ¼×");
			SetAction(29,"Ì«ê»_Æï³Ë_ÆÆ¼×");
			SetAction(30,"Ìì»ª_Æï³Ë_ÆÆ¼×");
			name = "°ËÃÅ¶Ý¼×¡¤ËÀµÀ";
			nativename = "°ËÃÅ¶Ý¼×¡¤ËÀµÀ";
			icon = "·ÉÑ©µ¶.dds";
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
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_maxhp = player.GetMaxhp();

			victim.SetProbability(120.0f);
			victim.SetValue((player_maxhp * 0.5f));
			victim.SetDirecthurt(true);
			return true;
		}
	}
	public class GSkill3983 : GSkill
	{
		public GSkill3983()
			: base(3983)
		{
			
		}
	}
	public class GSkill3984Stub : GSkillStub
	{
		public class GState1 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 50;
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
				return 50;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();

				player.SetPerform(1);
			}
		}
		public GSkill3984Stub()
			: base(3984)
		{
			occupation = 64;
			maxlevel = 1;
			maxlearn = 0;
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
			name = "ÁùÃëÎÞµÐ";
			nativename = "ÁùÃëÎÞµÐ";
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

			AddState(new GState1());
			AddState(new GState2());
		}
		public override int GetExecutetime(GSkill skill)
		{
			return 100;
		}
		public override float GetRadius(GSkill skill)
		{
			return 28.000000f;
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

			victim.SetTime(6100.0f);
			victim.SetInvincible(true);
			return true;
		}
	}
	public class GSkill3984 : GSkill
	{
		public GSkill3984()
			: base(3984)
		{
			
		}
	}
	public class GSkill3985Stub : GSkillStub
	{
		public GSkill3985Stub()
			: base(3985)
		{
			occupation = 129;
			maxlevel = 99;
			maxlearn = 99;
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
			name = "ÈË»Ê¶Ò»»¼Ó±©»÷";
			nativename = "ÈË»Ê¶Ò»»¼Ó±©»÷";
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

			victim.SetTime(300000.0f);
			victim.SetRatio(0.050000001f);
			victim.SetInccritrate(true);
			return true;
		}
	}
	public class GSkill3985 : GSkill
	{
		public GSkill3985()
			: base(3985)
		{
			
		}
	}
	public class GSkill3986Stub : GSkillStub
	{
		public GSkill3986Stub()
			: base(3986)
		{
			occupation = 129;
			maxlevel = 99;
			maxlearn = 99;
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
			name = "ÈË»Ê¶Ò»»¼Ó±¬ÉË";
			nativename = "ÈË»Ê¶Ò»»¼Ó±¬ÉË";
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
			victim.SetTime(300000.0f);
			victim.SetRatio(0.30000001f);
			victim.SetBuffid(9);
			victim.SetInccrithurt(true);
			return true;
		}
	}
	public class GSkill3986 : GSkill
	{
		public GSkill3986()
			: base(3986)
		{
			
		}
	}
	public class GSkill3987Stub : GSkillStub
	{
		public GSkill3987Stub()
			: base(3987)
		{
			occupation = 129;
			maxlevel = 99;
			maxlearn = 99;
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
			name = "ÈË»Ê¶Ò»»¼Ó¼õ±©»÷";
			nativename = "ÈË»Ê¶Ò»»¼Ó¼õ±©»÷";
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
			victim.SetTime(300000.0f);
			victim.SetRatio(0.050000001f);
			victim.SetBuffid(9);
			victim.SetDecfatalratio(true);
			return true;
		}
	}
	public class GSkill3987 : GSkill
	{
		public GSkill3987()
			: base(3987)
		{
			
		}
	}
	public class GSkill3988Stub : GSkillStub
	{
		public GSkill3988Stub()
			: base(3988)
		{
			occupation = 129;
			maxlevel = 99;
			maxlearn = 99;
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
			name = "ÈË»Ê¶Ò»»¼Ó¼õ±¬ÉË";
			nativename = "ÈË»Ê¶Ò»»¼Ó¼õ±¬ÉË";
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

			victim.SetProbability(120.0f);
			victim.SetTime(300000.0f);
			victim.SetRatio(0.30000001f);
			victim.SetBuffid(9);
			victim.SetDecfatalhurt(true);
			return true;
		}
	}
	public class GSkill3988 : GSkill
	{
		public GSkill3988()
			: base(3988)
		{
			
		}
	}
	public class GSkill3989Stub : GSkillStub
	{
		public GSkill3989Stub()
			: base(3989)
		{
			occupation = 129;
			maxlevel = 99;
			maxlearn = 99;
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
			name = "ÈË»Ê¶Ò»»¼ÓÈ«¿¹";
			nativename = "ÈË»Ê¶Ò»»¼ÓÈ«¿¹";
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

			victim.SetTime(300000.0f);
			victim.SetBuffid(8);
			victim.SetValue(20.0f);
			victim.SetAddanti(true);
			return true;
		}
	}
	public class GSkill3989 : GSkill
	{
		public GSkill3989()
			: base(3989)
		{
			
		}
	}
}
