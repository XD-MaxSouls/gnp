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
			SetAction(0,"¹íÍõ×Ú_ÃÍ»÷");
			SetAction(1,"ÇàÔÆÃÅ_ÃÍ»÷");
			SetAction(2,"¹íÍõ×Ú_ÃÍ»÷");
			SetAction(3,"ºÏ»¶ÅÉ_ÃÍ»÷");
			SetAction(4,"ÌìÒôËÂ_ÃÍ»÷");
			SetAction(5,"¹íµÀ_ÃÍ»÷");
			SetAction(6,"·ÙÏã_ÃÍ»÷");
			SetAction(7,"ÊÞÉñ_ÃÍ»÷");
			SetAction(8,"ºüÑý_ÃÍ»÷");
			SetAction(9,"ÐùÔ¯_ÃÍ»÷");
			SetAction(10,"»³¹â_ÃÍ»÷");
			SetAction(11,"Ì«ê»_ÃÍ»÷");
			SetAction(12,"Ìì»ª_ÃÍ»÷");
			SetAction(13,"ÁéÙí_ÃÍ»÷");
			SetAction(14,"Ó¢ÕÐ_ÃÍ»÷");
			SetAction(15,"ÔªËØ´óÊ¦_ÃÍ»÷");
			SetAction(16,"ÔªËØ´óÊ¦_ÃÍ»÷");
			SetAction(17,"ÌìÒôËÂ_ÃÍ»÷");
			SetAction(18,"¹íÍõ×Ú_Æï³Ë_ÃÍ»÷");
			SetAction(19,"ÇàÔÆÃÅ_Æï³Ë_ÃÍ»÷");
			SetAction(20,"¹íÍõ×Ú_Æï³Ë_ÃÍ»÷");
			SetAction(21,"ºÏ»¶ÅÉ_Æï³Ë_ÃÍ»÷");
			SetAction(22,"ÌìÒôËÂ_Æï³Ë_ÃÍ»÷");
			SetAction(23,"¹íµÀ_Æï³Ë_ÃÍ»÷");
			SetAction(24,"·ÙÏã_Æï³Ë_ÃÍ»÷");
			SetAction(25,"ÊÞÉñ_Æï³Ë_ÃÍ»÷");
			SetAction(26,"ºüÑý_Æï³Ë_ÃÍ»÷");
			SetAction(27,"ÐùÔ¯_Æï³Ë_ÃÍ»÷");
			SetAction(28,"»³¹â_Æï³Ë_ÃÍ»÷");
			SetAction(29,"Ì«ê»_Æï³Ë_ÃÍ»÷");
			SetAction(30,"Ìì»ª_Æï³Ë_ÃÍ»÷");
			name = "ÃÍ»÷";
			nativename = "ÃÍ»÷";
			icon = "ÃÍ»÷.dds";
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
			SetAction(0,"¹íÍõ×Ú_»¹Éñ");
			SetAction(1,"ÇàÔÆÃÅ_»¹Éñ");
			SetAction(2,"¹íÍõ×Ú_»¹Éñ");
			SetAction(3,"ºÏ»¶ÅÉ_»¹Éñ");
			SetAction(4,"ÌìÒôËÂ_»¹Éñ");
			SetAction(5,"¹íµÀ_»¹Éñ");
			SetAction(6,"·ÙÏã_»¹Éñ");
			SetAction(7,"ÊÞÉñ_»¹Éñ");
			SetAction(8,"ºüÑý_»¹Éñ");
			SetAction(9,"ÐùÔ¯_»¹Éñ");
			SetAction(10,"»³¹â_»¹Éñ");
			SetAction(11,"Ì«ê»_»¹Éñ");
			SetAction(12,"Ìì»ª_»¹Éñ");
			SetAction(13,"ÁéÙí_»¹Éñ");
			SetAction(14,"Ó¢ÕÐ_»¹Éñ");
			SetAction(15,"ÔªËØ´óÊ¦_»¹Éñ");
			SetAction(16,"ÔªËØ´óÊ¦_»¹Éñ");
			SetAction(17,"ÌìÒôËÂ_»¹Éñ");
			SetAction(18,"¹íÍõ×Ú_Æï³Ë_»¹Éñ");
			SetAction(19,"ÇàÔÆÃÅ_Æï³Ë_»¹Éñ");
			SetAction(20,"¹íÍõ×Ú_Æï³Ë_»¹Éñ");
			SetAction(21,"ºÏ»¶ÅÉ_Æï³Ë_»¹Éñ");
			SetAction(22,"ÌìÒôËÂ_Æï³Ë_»¹Éñ");
			SetAction(23,"¹íµÀ_Æï³Ë_»¹Éñ");
			SetAction(24,"·ÙÏã_Æï³Ë_»¹Éñ");
			SetAction(25,"ÊÞÉñ_Æï³Ë_»¹Éñ");
			SetAction(26,"ºüÑý_Æï³Ë_»¹Éñ");
			SetAction(27,"ÐùÔ¯_Æï³Ë_»¹Éñ");
			SetAction(28,"»³¹â_Æï³Ë_»¹Éñ");
			SetAction(29,"Ì«ê»_Æï³Ë_»¹Éñ");
			SetAction(30,"Ìì»ª_Æï³Ë_»¹Éñ");
			name = "»¹Éñ";
			nativename = "»¹Éñ";
			icon = "»¹Éñ.dds";
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
			SetAction(0,"¹íÍõ×Ú_É¢¾¡");
			SetAction(1,"ÇàÔÆÃÅ_É¢¾¡");
			SetAction(2,"¹íÍõ×Ú_É¢¾¡");
			SetAction(3,"ºÏ»¶ÅÉ_É¢¾¡");
			SetAction(4,"ÌìÒôËÂ_É¢¾¡");
			SetAction(5,"¹íµÀ_É¢¾¡");
			SetAction(6,"·ÙÏã_É¢¾¡");
			SetAction(7,"ÊÞÉñ_É¢¾¡");
			SetAction(8,"ºüÑý_É¢¾¡");
			SetAction(9,"ÐùÔ¯_É¢¾¡");
			SetAction(10,"»³¹â_É¢¾¡");
			SetAction(11,"Ì«ê»_É¢¾¡");
			SetAction(12,"Ìì»ª_É¢¾¡");
			SetAction(13,"ÁéÙí_É¢¾¡");
			SetAction(14,"Ó¢ÕÐ_É¢¾¡");
			SetAction(15,"ÔªËØ´óÊ¦_É¢¾¡");
			SetAction(16,"ÔªËØ´óÊ¦_É¢¾¡");
			SetAction(17,"ÌìÒôËÂ_É¢¾¡");
			SetAction(18,"¹íÍõ×Ú_Æï³Ë_É¢¾¡");
			SetAction(19,"ÇàÔÆÃÅ_Æï³Ë_É¢¾¡");
			SetAction(20,"¹íÍõ×Ú_Æï³Ë_É¢¾¡");
			SetAction(21,"ºÏ»¶ÅÉ_Æï³Ë_É¢¾¡");
			SetAction(22,"ÌìÒôËÂ_Æï³Ë_É¢¾¡");
			SetAction(23,"¹íµÀ_Æï³Ë_É¢¾¡");
			SetAction(24,"·ÙÏã_Æï³Ë_É¢¾¡");
			SetAction(25,"ÊÞÉñ_Æï³Ë_É¢¾¡");
			SetAction(26,"ºüÑý_Æï³Ë_É¢¾¡");
			SetAction(27,"ÐùÔ¯_Æï³Ë_É¢¾¡");
			SetAction(28,"»³¹â_Æï³Ë_É¢¾¡");
			SetAction(29,"Ì«ê»_Æï³Ë_É¢¾¡");
			SetAction(30,"Ìì»ª_Æï³Ë_É¢¾¡");
			name = "É¢¾¡";
			nativename = "É¢¾¡";
			icon = "É¢¾¡.dds";
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
			SetAction(0,"¹íÍõ×Ú_¹íÀ÷²»·²");
			SetAction(1,"ÇàÔÆÃÅ_¹íÀ÷²»·²");
			SetAction(2,"¹íÍõ×Ú_¹íÀ÷²»·²");
			SetAction(3,"ºÏ»¶ÅÉ_¹íÀ÷²»·²");
			SetAction(4,"ÌìÒôËÂ_¹íÀ÷²»·²");
			SetAction(5,"¹íµÀ_¹íÀ÷²»·²");
			SetAction(6,"·ÙÏã_¹íÀ÷²»·²");
			SetAction(7,"ÊÞÉñ_¹íÀ÷²»·²");
			SetAction(8,"ºüÑý_¹íÀ÷²»·²");
			SetAction(9,"ÐùÔ¯_¹íÀ÷²»·²");
			SetAction(10,"»³¹â_¹íÀ÷²»·²");
			SetAction(11,"Ì«ê»_¹íÀ÷²»·²");
			SetAction(12,"Ìì»ª_¹íÀ÷²»·²");
			SetAction(13,"ÁéÙí_¹íÀ÷²»·²");
			SetAction(14,"Ó¢ÕÐ_¹íÀ÷²»·²");
			SetAction(15,"ÔªËØ´óÊ¦_¹íÀ÷²»·²");
			SetAction(16,"ÔªËØ´óÊ¦_¹íÀ÷²»·²");
			SetAction(17,"ÌìÒôËÂ_¹íÀ÷²»·²");
			SetAction(18,"¹íÍõ×Ú_Æï³Ë_¹íÀ÷²»·²");
			SetAction(19,"ÇàÔÆÃÅ_Æï³Ë_¹íÀ÷²»·²");
			SetAction(20,"¹íÍõ×Ú_Æï³Ë_¹íÀ÷²»·²");
			SetAction(21,"ºÏ»¶ÅÉ_Æï³Ë_¹íÀ÷²»·²");
			SetAction(22,"ÌìÒôËÂ_Æï³Ë_¹íÀ÷²»·²");
			SetAction(23,"¹íµÀ_Æï³Ë_¹íÀ÷²»·²");
			SetAction(24,"·ÙÏã_Æï³Ë_¹íÀ÷²»·²");
			SetAction(25,"ÊÞÉñ_Æï³Ë_¹íÀ÷²»·²");
			SetAction(26,"ºüÑý_Æï³Ë_¹íÀ÷²»·²");
			SetAction(27,"ÐùÔ¯_Æï³Ë_¹íÀ÷²»·²");
			SetAction(28,"»³¹â_Æï³Ë_¹íÀ÷²»·²");
			SetAction(29,"Ì«ê»_Æï³Ë_¹íÀ÷²»·²");
			SetAction(30,"Ìì»ª_Æï³Ë_¹íÀ÷²»·²");
			name = "ÎÞÎª";
			nativename = "ÎÞÎª";
			icon = "¹íÀ÷Ö®²»·².dds";
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
			SetAction(0,"¹íÍõ×Ú_Ñ©ç÷Ö®±ùËª");
			SetAction(1,"ÇàÔÆÃÅ_Ñ©ç÷Ö®±ùËª");
			SetAction(2,"¹íÍõ×Ú_Ñ©ç÷Ö®±ùËª");
			SetAction(3,"ºÏ»¶ÅÉ_Ñ©ç÷Ö®±ùËª");
			SetAction(4,"ÌìÒôËÂ_Ñ©ç÷Ö®±ùËª");
			SetAction(5,"¹íµÀ_Ñ©ç÷Ö®±ùËª");
			SetAction(6,"·ÙÏã_Ñ©ç÷Ö®±ùËª");
			SetAction(7,"ÊÞÉñ_Ñ©ç÷Ö®±ùËª");
			SetAction(8,"ºüÑý_Ñ©ç÷Ö®±ùËª");
			SetAction(9,"ÐùÔ¯_Ñ©ç÷Ö®±ùËª");
			SetAction(10,"»³¹â_Ñ©ç÷Ö®±ùËª");
			SetAction(11,"Ì«ê»_Ñ©ç÷Ö®±ùËª");
			SetAction(12,"Ìì»ª_Ñ©ç÷Ö®±ùËª");
			SetAction(13,"ÁéÙí_Ñ©ç÷Ö®±ùËª");
			SetAction(14,"Ó¢ÕÐ_Ñ©ç÷Ö®±ùËª");
			SetAction(15,"ÔªËØ´óÊ¦_Ñ©ç÷Ö®±ùËª");
			SetAction(16,"ÔªËØ´óÊ¦_Ñ©ç÷Ö®±ùËª");
			SetAction(17,"ÌìÒôËÂ_Ñ©ç÷Ö®±ùËª");
			SetAction(18,"¹íÍõ×Ú_Æï³Ë_Ñ©ç÷Ö®±ùËª");
			SetAction(19,"ÇàÔÆÃÅ_Æï³Ë_Ñ©ç÷Ö®±ùËª");
			SetAction(20,"¹íÍõ×Ú_Æï³Ë_Ñ©ç÷Ö®±ùËª");
			SetAction(21,"ºÏ»¶ÅÉ_Æï³Ë_Ñ©ç÷Ö®±ùËª");
			SetAction(22,"ÌìÒôËÂ_Æï³Ë_Ñ©ç÷Ö®±ùËª");
			SetAction(23,"¹íµÀ_Æï³Ë_Ñ©ç÷Ö®±ùËª");
			SetAction(24,"·ÙÏã_Æï³Ë_Ñ©ç÷Ö®±ùËª");
			SetAction(25,"ÊÞÉñ_Æï³Ë_Ñ©ç÷Ö®±ùËª");
			SetAction(26,"ºüÑý_Æï³Ë_Ñ©ç÷Ö®±ùËª");
			SetAction(27,"ÐùÔ¯_Æï³Ë_Ñ©ç÷Ö®±ùËª");
			SetAction(28,"»³¹â_Æï³Ë_Ñ©ç÷Ö®±ùËª");
			SetAction(29,"Ì«ê»_Æï³Ë_Ñ©ç÷Ö®±ùËª");
			SetAction(30,"Ìì»ª_Æï³Ë_Ñ©ç÷Ö®±ùËª");
			name = "º¬ÕÂ";
			nativename = "º¬ÕÂ";
			icon = "Ñ©ç÷Ö®±ùËª.dds";
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
			SetAction(0,"¹íÍõ×Ú_±ÌÑþÖ®Ö¿°®");
			SetAction(1,"ÇàÔÆÃÅ_±ÌÑþÖ®Ö¿°®");
			SetAction(2,"¹íÍõ×Ú_±ÌÑþÖ®Ö¿°®");
			SetAction(3,"ºÏ»¶ÅÉ_±ÌÑþÖ®Ö¿°®");
			SetAction(4,"ÌìÒôËÂ_±ÌÑþÖ®Ö¿°®");
			SetAction(5,"¹íµÀ_±ÌÑþÖ®Ö¿°®");
			SetAction(6,"·ÙÏã_±ÌÑþÖ®Ö¿°®");
			SetAction(7,"ÊÞÉñ_±ÌÑþÖ®Ö¿°®");
			SetAction(8,"ºüÑý_±ÌÑþÖ®Ö¿°®");
			SetAction(9,"ÐùÔ¯_±ÌÑþÖ®Ö¿°®");
			SetAction(10,"»³¹â_±ÌÑþÖ®Ö¿°®");
			SetAction(11,"Ì«ê»_±ÌÑþÖ®Ö¿°®");
			SetAction(12,"Ìì»ª_±ÌÑþÖ®Ö¿°®");
			SetAction(13,"ÁéÙí_±ÌÑþÖ®Ö¿°®");
			SetAction(14,"Ó¢ÕÐ_±ÌÑþÖ®Ö¿°®");
			SetAction(15,"ÔªËØ´óÊ¦_±ÌÑþÖ®Ö¿°®");
			SetAction(16,"ÔªËØ´óÊ¦_±ÌÑþÖ®Ö¿°®");
			SetAction(17,"ÌìÒôËÂ_±ÌÑþÖ®Ö¿°®");
			SetAction(18,"¹íÍõ×Ú_Æï³Ë_±ÌÑþÖ®Ö¿°®");
			SetAction(19,"ÇàÔÆÃÅ_Æï³Ë_±ÌÑþÖ®Ö¿°®");
			SetAction(20,"¹íÍõ×Ú_Æï³Ë_±ÌÑþÖ®Ö¿°®");
			SetAction(21,"ºÏ»¶ÅÉ_Æï³Ë_±ÌÑþÖ®Ö¿°®");
			SetAction(22,"ÌìÒôËÂ_Æï³Ë_±ÌÑþÖ®Ö¿°®");
			SetAction(23,"¹íµÀ_Æï³Ë_±ÌÑþÖ®Ö¿°®");
			SetAction(24,"·ÙÏã_Æï³Ë_±ÌÑþÖ®Ö¿°®");
			SetAction(25,"ÊÞÉñ_Æï³Ë_±ÌÑþÖ®Ö¿°®");
			SetAction(26,"ºüÑý_Æï³Ë_±ÌÑþÖ®Ö¿°®");
			SetAction(27,"ÐùÔ¯_Æï³Ë_±ÌÑþÖ®Ö¿°®");
			SetAction(28,"»³¹â_Æï³Ë_±ÌÑþÖ®Ö¿°®");
			SetAction(29,"Ì«ê»_Æï³Ë_±ÌÑþÖ®Ö¿°®");
			SetAction(30,"Ìì»ª_Æï³Ë_±ÌÑþÖ®Ö¿°®");
			name = "³åÐé";
			nativename = "³åÐé";
			icon = "±ÌÑþÖ®Ö¿°®.dds";
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
			name = "³þººµ¶±øA";
			nativename = "³þººµ¶±øA";
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
			name = "³þººµ¶±øB";
			nativename = "³þººµ¶±øB";
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
			name = "³þººµ¶±øC";
			nativename = "³þººµ¶±øC";
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
			name = "³þººµ¶±øD";
			nativename = "³þººµ¶±øD";
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
