using System;
using System.Text;

namespace SKILL
{
	public class GSkill560Stub : GSkillStub
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
		public GSkill560Stub()
			: base(560)
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
			SetAction(0,"¹íÍõ×Ú_·¨±¦_Ç¬À¤Çà¹â½ä");
			SetAction(1,"ÇàÔÆÃÅ_·¨±¦_Ç¬À¤Çà¹â½ä");
			SetAction(2,"¹íÍõ×Ú_·¨±¦_Ç¬À¤Çà¹â½ä");
			SetAction(3,"ºÏ»¶ÅÉ_·¨±¦_Ç¬À¤Çà¹â½ä");
			SetAction(4,"ÌìÒôËÂ_·¨±¦_Ç¬À¤Çà¹â½ä");
			SetAction(5,"¹íµÀ_·¨±¦_Ç¬À¤Çà¹â½ä");
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
			SetAction(18,"¹íÍõ×Ú_Æï³Ë_·¨±¦_Ç¬À¤Çà¹â½ä");
			SetAction(19,"ÇàÔÆÃÅ_Æï³Ë_·¨±¦_Ç¬À¤Çà¹â½ä");
			SetAction(20,"¹íÍõ×Ú_Æï³Ë_·¨±¦_Ç¬À¤Çà¹â½ä");
			SetAction(21,"ºÏ»¶ÅÉ_Æï³Ë_·¨±¦_Ç¬À¤Çà¹â½ä");
			SetAction(22,"ÌìÒôËÂ_Æï³Ë_·¨±¦_Ç¬À¤Çà¹â½ä");
			SetAction(23,"¹íµÀ_Æï³Ë_·¨±¦_Ç¬À¤Çà¹â½ä");
			SetAction(24,"");
			SetAction(25,"");
			SetAction(26,"");
			SetAction(27,"");
			SetAction(28,"");
			SetAction(29,"");
			SetAction(30,"");
			name = "Çà¹âÕ§ÏÖ";
			nativename = "Çà¹âÕ§ÏÖ";
			icon = "Çà¹âÕ§ÏÖ.dds";
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
	public class GSkill560 : GSkill
	{
		public GSkill560()
			: base(560)
		{
			
		}
	}
	public class GSkill561Stub : GSkillStub
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

				skill.SetCrit((skill_level * 0.03f));
				skill.SetRatio((D2INT(player_level / (9 - skill_level)) * 0.01f + (skill_level * 0.05f + (skill_t0 * 0.03f + 1.0f))));
				skill.SetPlus((player_def * (skill_t1 * 0.03f) + ((3 * player_level * skill_level + (215 * skill_level)))));
				player.SetPerform(1);
			}
		}
		public GSkill561Stub()
			: base(561)
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
			SetAction(0,"¹íµÀ_·¨±¦_ÎåÁúÂÖ");
			SetAction(1,"ÇàÔÆÃÅ_·¨±¦_ÎåÁúÂÖ");
			SetAction(2,"¹íÍõ×Ú_·¨±¦_ÎåÁúÂÖ");
			SetAction(3,"ºÏ»¶ÅÉ_·¨±¦_ÎåÁúÂÖ");
			SetAction(4,"ÌìÒôËÂ_·¨±¦_ÎåÁúÂÖ");
			SetAction(5,"¹íµÀ_·¨±¦_ÎåÁúÂÖ");
			SetAction(6,"·ÙÏã¹È_·¨±¦_ÎåÁúÂÖ");
			SetAction(7,"ÊÞÉñ_·¨±¦_ÎåÁúÂÖ");
			SetAction(8,"ºüÑý_·¨±¦_ÎåÁúÂÖ");
			SetAction(9,"ÐùÔ¯_·¨±¦_ÎåÁúÂÖ");
			SetAction(10,"»³¹â_·¨±¦_ÎåÁúÂÖ");
			SetAction(11,"Ì«ê»_·¨±¦_ÎåÁúÂÖ");
			SetAction(12,"Ìì»ª_·¨±¦_ÎåÁúÂÖ");
			SetAction(13,"ÁéÙí_·¨±¦_ÎåÁúÂÖ");
			SetAction(14,"Ó¢ÕÐ_·¨±¦_ÎåÁúÂÖ");
			SetAction(15,"ÎäÆ÷´óÊ¦_·¨±¦_ÎåÁúÂÖ");
			SetAction(16,"ÎäÆ÷´óÊ¦_·¨±¦_ÎåÁúÂÖ");
			SetAction(17,"ÌìÒôËÂ_·¨±¦_ÎåÁúÂÖ");
			SetAction(18,"¹íµÀ_Æï³Ë_·¨±¦_ÎåÁúÂÖ");
			SetAction(19,"ÇàÔÆÃÅ_Æï³Ë_·¨±¦_ÎåÁúÂÖ");
			SetAction(20,"¹íÍõ×Ú_Æï³Ë_·¨±¦_ÎåÁúÂÖ");
			SetAction(21,"ºÏ»¶ÅÉ_Æï³Ë_·¨±¦_ÎåÁúÂÖ");
			SetAction(22,"ÌìÒôËÂ_Æï³Ë_·¨±¦_ÎåÁúÂÖ");
			SetAction(23,"¹íµÀ_Æï³Ë_·¨±¦_ÎåÁúÂÖ");
			SetAction(24,"·ÙÏã¹È_Æï³Ë_·¨±¦_ÎåÁúÂÖ");
			SetAction(25,"ÊÞÉñ_Æï³Ë_·¨±¦_ÎåÁúÂÖ");
			SetAction(26,"ºüÑý_Æï³Ë_·¨±¦_ÎåÁúÂÖ");
			SetAction(27,"ÐùÔ¯_Æï³Ë_·¨±¦_ÎåÁúÂÖ");
			SetAction(28,"»³¹â_Æï³Ë_·¨±¦_ÎåÁúÂÖ");
			SetAction(29,"Ì«ê»_Æï³Ë_·¨±¦_ÎåÁúÂÖ");
			SetAction(30,"Ìì»ª_Æï³Ë_·¨±¦_ÎåÁúÂÖ");
			name = "ÎåÁúÓùÌì";
			nativename = "ÎåÁúÓùÌì";
			icon = "ÎåÁúÓùÌì.dds";
			SetTalent(0,687);
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

			return ((-35 * skill_level) - skill_level * skill_level + 445);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();

			victim.SetProbability(((5 * skill_level)));
			victim.SetTime((((2000 * skill_level + 4000) * (D2INT((zrand(6 * skill_level + 99)) / 100) + 1) + 100)));
			victim.SetRatio((skill_level * 0.02f + 0.2f));
			victim.SetValue((skill_level * 0.02f + 0.2f));
			victim.SetRandcurse(true);
			victim.SetProbability(33.0f);
			victim.SetTime(((4000 * skill_level + 8000)));
			victim.SetBuffid(1);
			victim.SetAmount(((16 * skill_level * skill_level + (60 * skill_level))));
			victim.SetCycsubattack(true);
			return true;
		}
	}
	public class GSkill561 : GSkill
	{
		public GSkill561()
			: base(561)
		{
			
		}
	}
	public class GSkill562Stub : GSkillStub
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

				skill.SetRatio((D2INT(player_level / (10 - skill_level)) * 0.01f + (skill_level * 0.05f + (skill_t0 * 0.03f + 1.0f))));
				skill.SetPlus((player_def * (skill_t1 * 0.03f) + ((120 * skill_level))));
				player.SetPerform(1);
			}
		}
		public GSkill562Stub()
			: base(562)
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
			SetAction(0,"¹íµÀ_·¨±¦_¾ÅÁúÉñ»ðÕÖ");
			SetAction(1,"ÇàÔÆÃÅ_·¨±¦_¾ÅÁúÉñ»ðÕÖ");
			SetAction(2,"¹íÍõ×Ú_·¨±¦_¾ÅÁúÉñ»ðÕÖ");
			SetAction(3,"ºÏ»¶ÅÉ_·¨±¦_¾ÅÁúÉñ»ðÕÖ");
			SetAction(4,"ÌìÒôËÂ_·¨±¦_¾ÅÁúÉñ»ðÕÖ");
			SetAction(5,"¹íµÀ_·¨±¦_¾ÅÁúÉñ»ðÕÖ");
			SetAction(6,"·ÙÏã¹È_·¨±¦_¾ÅÁúÉñ»ðÕÖ");
			SetAction(7,"ÊÞÉñ_·¨±¦_¾ÅÁúÉñ»ðÕÖ");
			SetAction(8,"ºüÑý_·¨±¦_¾ÅÁúÉñ»ðÕÖ");
			SetAction(9,"ÐùÔ¯_·¨±¦_¾ÅÁúÉñ»ðÕÖ");
			SetAction(10,"»³¹â_·¨±¦_¾ÅÁúÉñ»ðÕÖ");
			SetAction(11,"Ì«ê»_·¨±¦_¾ÅÁúÉñ»ðÕÖ");
			SetAction(12,"Ìì»ª_·¨±¦_¾ÅÁúÉñ»ðÕÖ");
			SetAction(13,"ÁéÙí_·¨±¦_¾ÅÁúÉñ»ðÕÖ");
			SetAction(14,"Ó¢ÕÐ_·¨±¦_¾ÅÁúÉñ»ðÕÖ");
			SetAction(15,"ÎäÆ÷´óÊ¦_·¨±¦_¾ÅÁúÉñ»ðÕÖ");
			SetAction(16,"ÎäÆ÷´óÊ¦_·¨±¦_¾ÅÁúÉñ»ðÕÖ");
			SetAction(17,"ÌìÒôËÂ_·¨±¦_¾ÅÁúÉñ»ðÕÖ");
			SetAction(18,"¹íµÀ_Æï³Ë_·¨±¦_¾ÅÁúÉñ»ðÕÖ");
			SetAction(19,"ÇàÔÆÃÅ_Æï³Ë_·¨±¦_¾ÅÁúÉñ»ðÕÖ");
			SetAction(20,"¹íÍõ×Ú_Æï³Ë_·¨±¦_¾ÅÁúÉñ»ðÕÖ");
			SetAction(21,"ºÏ»¶ÅÉ_Æï³Ë_·¨±¦_¾ÅÁúÉñ»ðÕÖ");
			SetAction(22,"ÌìÒôËÂ_Æï³Ë_·¨±¦_¾ÅÁúÉñ»ðÕÖ");
			SetAction(23,"¹íµÀ_Æï³Ë_·¨±¦_¾ÅÁúÉñ»ðÕÖ");
			SetAction(24,"·ÙÏã¹È_Æï³Ë_·¨±¦_¾ÅÁúÉñ»ðÕÖ");
			SetAction(25,"ÊÞÉñ_Æï³Ë_·¨±¦_¾ÅÁúÉñ»ðÕÖ");
			SetAction(26,"ºüÑý_Æï³Ë_·¨±¦_¾ÅÁúÉñ»ðÕÖ");
			SetAction(27,"ÐùÔ¯_Æï³Ë_·¨±¦_¾ÅÁúÉñ»ðÕÖ");
			SetAction(28,"»³¹â_Æï³Ë_·¨±¦_¾ÅÁúÉñ»ðÕÖ");
			SetAction(29,"Ì«ê»_Æï³Ë_·¨±¦_¾ÅÁúÉñ»ðÕÖ");
			SetAction(30,"Ìì»ª_Æï³Ë_·¨±¦_¾ÅÁúÉñ»ðÕÖ");
			name = "Á¶ÓüÉñ»ð";
			nativename = "Á¶ÓüÉñ»ð";
			icon = "Á¶ÓüÉñ»ð.dds";
			SetTalent(0,687);
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

			victim.SetProbability(100.0f);
			victim.SetTime(((2000 * skill_level + 4100)));
			victim.SetBuffid(1);
			victim.SetValue(((24 * skill_level)));
			victim.SetSubdefence(true);
			victim.SetProbability(((1.0f - player_level * 0.002f) * 100.0f));
			victim.SetTime(4000.0f);
			victim.SetBuffid(1);
			victim.SetAmount(((32 * skill_level)));
			victim.SetValue(((320 * skill_level)));
			victim.SetHpleak(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();

			victim.SetProbability(((6 * skill_level + 6)));
			victim.SetTime(((1000 * skill_level + 12100)));
			victim.SetRatio(1.0f);
			victim.SetAmount(((skill_level + 2)));
			victim.SetValue(((3 * skill_level * skill_level + (15 * skill_level))));
			victim.SetBloodshield(true);
			return true;
		}
	}
	public class GSkill562 : GSkill
	{
		public GSkill562()
			: base(562)
		{
			
		}
	}
	public class GSkill563Stub : GSkillStub
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
		public GSkill563Stub()
			: base(563)
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
			SetAction(0,"¹íÍõ×Ú_·¨±¦_ÈçÒâÇ¬À¤´ü");
			SetAction(1,"ÇàÔÆÃÅ_·¨±¦_ÈçÒâÇ¬À¤´ü");
			SetAction(2,"¹íÍõ×Ú_·¨±¦_ÈçÒâÇ¬À¤´ü");
			SetAction(3,"ºÏ»¶ÅÉ_·¨±¦_ÈçÒâÇ¬À¤´ü");
			SetAction(4,"ÌìÒôËÂ_·¨±¦_ÈçÒâÇ¬À¤´ü");
			SetAction(5,"¹íµÀ_·¨±¦_ÈçÒâÇ¬À¤´ü");
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
			SetAction(18,"¹íÍõ×Ú_Æï³Ë_·¨±¦_ÈçÒâÇ¬À¤´ü");
			SetAction(19,"ÇàÔÆÃÅ_Æï³Ë_·¨±¦_ÈçÒâÇ¬À¤´ü");
			SetAction(20,"¹íÍõ×Ú_Æï³Ë_·¨±¦_ÈçÒâÇ¬À¤´ü");
			SetAction(21,"ºÏ»¶ÅÉ_Æï³Ë_·¨±¦_ÈçÒâÇ¬À¤´ü");
			SetAction(22,"ÌìÒôËÂ_Æï³Ë_·¨±¦_ÈçÒâÇ¬À¤´ü");
			SetAction(23,"¹íµÀ_Æï³Ë_·¨±¦_ÈçÒâÇ¬À¤´ü");
			SetAction(24,"");
			SetAction(25,"");
			SetAction(26,"");
			SetAction(27,"");
			SetAction(28,"");
			SetAction(29,"");
			SetAction(30,"");
			name = "Ç¬À¤ÈçÒâ";
			nativename = "Ç¬À¤ÈçÒâ";
			icon = "Ç¬À¤ÈçÒâ.dds";
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
	public class GSkill563 : GSkill
	{
		public GSkill563()
			: base(563)
		{
			
		}
	}
	public class GSkill564Stub : GSkillStub
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

				skill.SetRatio((D2INT(player_level / (9 - skill_level)) * 0.01f + (skill_level * 0.07000000000000001f + (skill_t0 * 0.03f + 1.0f))));
				skill.SetPlus((player_def * (skill_t1 * 0.03f) + ((skill_level * (D2INT((zrand(4 * skill_level + 99)) / 100.0f) * 0.8f) + 1.0f) * ((250 * skill_level)))));
				player.SetPerform(1);
			}
		}
		public GSkill564Stub()
			: base(564)
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
			SetAction(0,"¹íµÀ_·¨±¦_Éã»ê");
			SetAction(1,"ÇàÔÆÃÅ_·¨±¦_Éã»ê");
			SetAction(2,"¹íÍõ×Ú_·¨±¦_Éã»ê");
			SetAction(3,"ºÏ»¶ÅÉ_·¨±¦_Éã»ê");
			SetAction(4,"ÌìÒôËÂ_·¨±¦_Éã»ê");
			SetAction(5,"¹íµÀ_·¨±¦_Éã»ê");
			SetAction(6,"·ÙÏã¹È_·¨±¦_Éã»ê");
			SetAction(7,"ÊÞÉñ_·¨±¦_Éã»ê");
			SetAction(8,"ºüÑý_·¨±¦_Éã»ê");
			SetAction(9,"ÐùÔ¯_·¨±¦_Éã»ê");
			SetAction(10,"»³¹â_·¨±¦_Éã»ê");
			SetAction(11,"Ì«ê»_·¨±¦_Éã»ê");
			SetAction(12,"Ìì»ª_·¨±¦_Éã»ê");
			SetAction(13,"ÁéÙí_·¨±¦_Éã»ê");
			SetAction(14,"Ó¢ÕÐ_·¨±¦_Éã»ê");
			SetAction(15,"ÎäÆ÷´óÊ¦_·¨±¦_Éã»ê");
			SetAction(16,"ÎäÆ÷´óÊ¦_·¨±¦_Éã»ê");
			SetAction(17,"ÌìÒôËÂ_·¨±¦_Éã»ê");
			SetAction(18,"¹íµÀ_Æï³Ë_·¨±¦_Éã»ê");
			SetAction(19,"ÇàÔÆÃÅ_Æï³Ë_·¨±¦_Éã»ê");
			SetAction(20,"¹íÍõ×Ú_Æï³Ë_·¨±¦_Éã»ê");
			SetAction(21,"ºÏ»¶ÅÉ_Æï³Ë_·¨±¦_Éã»ê");
			SetAction(22,"ÌìÒôËÂ_Æï³Ë_·¨±¦_Éã»ê");
			SetAction(23,"¹íµÀ_Æï³Ë_·¨±¦_Éã»ê");
			SetAction(24,"·ÙÏã¹È_Æï³Ë_·¨±¦_Éã»ê");
			SetAction(25,"ÊÞÉñ_Æï³Ë_·¨±¦_Éã»ê");
			SetAction(26,"ºüÑý_Æï³Ë_·¨±¦_Éã»ê");
			SetAction(27,"ÐùÔ¯_Æï³Ë_·¨±¦_Éã»ê");
			SetAction(28,"»³¹â_Æï³Ë_·¨±¦_Éã»ê");
			SetAction(29,"Ì«ê»_Æï³Ë_·¨±¦_Éã»ê");
			SetAction(30,"Ìì»ª_Æï³Ë_·¨±¦_Éã»ê");
			name = "»êÉãÐÄ³Û";
			nativename = "»êÉãÐÄ³Û";
			icon = "»êÉãÐÄ³Û.dds";
			SetTalent(0,687);
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

			return ((-35 * skill_level) - skill_level * skill_level + 555);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();

			victim.SetProbability(((600 * norm(zrand(100) / (100 - 4 * skill_level)))));
			victim.SetTime(((5000 * skill_level + 100)));
			victim.SetDizzy(true);
			victim.SetProbability(((5 * skill_level + 25)));
			victim.SetTime(((4000 * skill_level + 100)));
			victim.SetBuffid(1);
			victim.SetValue(((30 * skill_level)));
			victim.SetSubattack(true);
			victim.SetProbability(((5 * skill_t0 + 50)));
			victim.SetTime(16100.0f);
			victim.SetRatio((skill_level * 0.01001f));
			victim.SetBuffid(1);
			victim.SetDeccritrate(true);
			return true;
		}
	}
	public class GSkill564 : GSkill
	{
		public GSkill564()
			: base(564)
		{
			
		}
	}
	public class GSkill565Stub : GSkillStub
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

				skill.SetRatio((D2INT(player_level / (9 - skill_level)) * 0.01f + (skill_level * 0.07000000000000001f + (skill_t0 * 0.03f + 1.0f))));
				skill.SetPlus((player_def * (skill_t1 * 0.03f) + ((250 * skill_level))));
				player.SetPerform(1);
			}
		}
		public GSkill565Stub()
			: base(565)
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
			SetAction(0,"¹íµÀ_·¨±¦_ÊÉÑªÖé");
			SetAction(1,"ÇàÔÆÃÅ_·¨±¦_ÊÉÑªÖé");
			SetAction(2,"¹íÍõ×Ú_·¨±¦_ÊÉÑªÖé");
			SetAction(3,"ºÏ»¶ÅÉ_·¨±¦_ÊÉÑªÖé");
			SetAction(4,"ÌìÒôËÂ_·¨±¦_ÊÉÑªÖé");
			SetAction(5,"¹íµÀ_·¨±¦_ÊÉÑªÖé");
			SetAction(6,"·ÙÏã¹È_·¨±¦_ÊÉÑªÖé");
			SetAction(7,"ÊÞÉñ_·¨±¦_ÊÉÑªÖé");
			SetAction(8,"ºüÑý_·¨±¦_ÊÉÑªÖé");
			SetAction(9,"ÐùÔ¯_·¨±¦_ÊÉÑªÖé");
			SetAction(10,"»³¹â_·¨±¦_ÊÉÑªÖé");
			SetAction(11,"Ì«ê»_·¨±¦_ÊÉÑªÖé");
			SetAction(12,"Ìì»ª_·¨±¦_ÊÉÑªÖé");
			SetAction(13,"ÁéÙí_·¨±¦_ÊÉÑªÖé");
			SetAction(14,"Ó¢ÕÐ_·¨±¦_ÊÉÑªÖé");
			SetAction(15,"ÎäÆ÷´óÊ¦_·¨±¦_ÊÉÑªÖé");
			SetAction(16,"ÎäÆ÷´óÊ¦_·¨±¦_ÊÉÑªÖé");
			SetAction(17,"ÌìÒôËÂ_·¨±¦_ÊÉÑªÖé");
			SetAction(18,"¹íµÀ_Æï³Ë_·¨±¦_ÊÉÑªÖé");
			SetAction(19,"ÇàÔÆÃÅ_Æï³Ë_·¨±¦_ÊÉÑªÖé");
			SetAction(20,"¹íÍõ×Ú_Æï³Ë_·¨±¦_ÊÉÑªÖé");
			SetAction(21,"ºÏ»¶ÅÉ_Æï³Ë_·¨±¦_ÊÉÑªÖé");
			SetAction(22,"ÌìÒôËÂ_Æï³Ë_·¨±¦_ÊÉÑªÖé");
			SetAction(23,"¹íµÀ_Æï³Ë_·¨±¦_ÊÉÑªÖé");
			SetAction(24,"·ÙÏã¹È_Æï³Ë_·¨±¦_ÊÉÑªÖé");
			SetAction(25,"ÊÞÉñ_Æï³Ë_·¨±¦_ÊÉÑªÖé");
			SetAction(26,"ºüÑý_Æï³Ë_·¨±¦_ÊÉÑªÖé");
			SetAction(27,"ÐùÔ¯_Æï³Ë_·¨±¦_ÊÉÑªÖé");
			SetAction(28,"»³¹â_Æï³Ë_·¨±¦_ÊÉÑªÖé");
			SetAction(29,"Ì«ê»_Æï³Ë_·¨±¦_ÊÉÑªÖé");
			SetAction(30,"Ìì»ª_Æï³Ë_·¨±¦_ÊÉÑªÖé");
			name = "ÊÉÑªÐ°Áé";
			nativename = "ÊÉÑªÐ°Áé";
			icon = "ÊÉÑªÐ°Áé.dds";
			SetTalent(0,687);
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

			return ((-35 * skill_level) - skill_level * skill_level + 555);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_level = player.GetLevel();
			int				player_maxmp = player.GetMaxmp();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();

			victim.SetProbability(((600 * norm(zrand(100) / (100 - 8 * skill_level)))));
			victim.SetTime(((5000 * skill_level + 100)));
			victim.SetRatio((skill_level * (skill_level * 0.01f) + (skill_level * 0.05f + 0.15f)));
			victim.SetBuffid(5);
			victim.SetWeak(true);
			victim.SetProbability(((1.0f - player_level * 0.002f) * ((skill_level * skill_level + (3 * skill_level)))));
			victim.SetRatio(1.0f);
			victim.SetDrainmagic(true);
			victim.SetProbability(((3 * skill_t0 + 50)));
			victim.SetTime(16100.0f);
			victim.SetRatio((skill_level * 0.2f));
			victim.SetBuffid(1);
			victim.SetDeccrithurt(true);
			victim.SetProbability(((1.0f - player_level * 0.002f) * 100.0f));
			victim.SetTime(30000.0f);
			victim.SetBuffid(5);
			victim.SetAmount((player_maxmp * (skill_level * (skill_level * 0.02f)) * 15.0f));
			victim.SetValue(0.0f);
			victim.SetMpleak(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_maxhp = player.GetMaxhp();
			int				skill_level = skill.GetLevel();

			victim.SetProbability(((skill_level * skill_level + (5 * skill_level) + 35)));
			victim.SetRatio(0.0f);
			victim.SetValue((player_maxhp * (skill_level * 0.02f)));
			victim.SetHeal(true);
			return true;
		}
	}
	public class GSkill565 : GSkill
	{
		public GSkill565()
			: base(565)
		{
			
		}
	}
	public class GSkill566Stub : GSkillStub
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

				skill.SetRatio((D2INT(player_level / (8 - skill_level)) * 0.01f + (skill_level * 0.09f + (skill_t0 * 0.03f + 1.0f))));
				skill.SetPlus((player_def * (skill_t1 * 0.03f) + ((255 * skill_level))));
				player.SetPerform(1);
			}
		}
		public GSkill566Stub()
			: base(566)
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
			SetAction(0,"¹íµÀ_·¨±¦_ÊÉ»ê");
			SetAction(1,"ÇàÔÆÃÅ_·¨±¦_ÊÉ»ê");
			SetAction(2,"¹íÍõ×Ú_·¨±¦_ÊÉ»ê");
			SetAction(3,"ºÏ»¶ÅÉ_·¨±¦_ÊÉ»ê");
			SetAction(4,"ÌìÒôËÂ_·¨±¦_ÊÉ»ê");
			SetAction(5,"¹íµÀ_·¨±¦_ÊÉ»ê");
			SetAction(6,"·ÙÏã¹È_·¨±¦_ÊÉ»ê");
			SetAction(7,"ÊÞÉñ_·¨±¦_ÊÉ»ê");
			SetAction(8,"ºüÑý_·¨±¦_ÊÉ»ê");
			SetAction(9,"ÐùÔ¯_·¨±¦_ÊÉ»ê");
			SetAction(10,"»³¹â_·¨±¦_ÊÉ»ê");
			SetAction(11,"Ì«ê»_·¨±¦_ÊÉ»ê");
			SetAction(12,"Ìì»ª_·¨±¦_ÊÉ»ê");
			SetAction(13,"ÁéÙí_·¨±¦_ÊÉ»ê");
			SetAction(14,"Ó¢ÕÐ_·¨±¦_ÊÉ»ê");
			SetAction(15,"ÎäÆ÷´óÊ¦_·¨±¦_ÊÉ»ê");
			SetAction(16,"ÎäÆ÷´óÊ¦_·¨±¦_ÊÉ»ê");
			SetAction(17,"ÌìÒôËÂ_·¨±¦_ÊÉ»ê");
			SetAction(18,"¹íµÀ_Æï³Ë_·¨±¦_ÊÉ»ê");
			SetAction(19,"ÇàÔÆÃÅ_Æï³Ë_·¨±¦_ÊÉ»ê");
			SetAction(20,"¹íÍõ×Ú_Æï³Ë_·¨±¦_ÊÉ»ê");
			SetAction(21,"ºÏ»¶ÅÉ_Æï³Ë_·¨±¦_ÊÉ»ê");
			SetAction(22,"ÌìÒôËÂ_Æï³Ë_·¨±¦_ÊÉ»ê");
			SetAction(23,"¹íµÀ_Æï³Ë_·¨±¦_ÊÉ»ê");
			SetAction(24,"·ÙÏã¹È_Æï³Ë_·¨±¦_ÊÉ»ê");
			SetAction(25,"ÊÞÉñ_Æï³Ë_·¨±¦_ÊÉ»ê");
			SetAction(26,"ºüÑý_Æï³Ë_·¨±¦_ÊÉ»ê");
			SetAction(27,"ÐùÔ¯_Æï³Ë_·¨±¦_ÊÉ»ê");
			SetAction(28,"»³¹â_Æï³Ë_·¨±¦_ÊÉ»ê");
			SetAction(29,"Ì«ê»_Æï³Ë_·¨±¦_ÊÉ»ê");
			SetAction(30,"Ìì»ª_Æï³Ë_·¨±¦_ÊÉ»ê");
			name = "ÊÉ»êÎÞË«";
			nativename = "ÊÉ»êÎÞË«";
			icon = "ÊÉ»êÎÞË«.dds";
			SetTalent(0,687);
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

			return ((-55 * skill_level) - skill_level * skill_level + 705);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_maxmp = player.GetMaxmp();
			int				skill_level = skill.GetLevel();

			victim.SetProbability(120.0f);
			victim.SetTime(30000.0f);
			victim.SetBuffid(1);
			victim.SetAmount((player_maxmp * ((skill_level + 1) * ((skill_level + 1) * 0.02f)) * 15.0f));
			victim.SetValue(0.0f);
			victim.SetMpleak(true);
			victim.SetProbability(zrand(100) >= 7 * skill_level + 7?0.0f:600.0f);
			victim.SetTime(((5000 * skill_level + 5000)));
			victim.SetRatio(((skill_level + 1) * ((skill_level + 1) * 0.01f) + ((skill_level + 1) * 0.05f + 0.15f)));
			victim.SetBuffid(1);
			victim.SetWeak(true);
			victim.SetProbability(50.0f);
			victim.SetTime(16000.0f);
			victim.SetRatio((skill_level * 0.03001f));
			victim.SetBuffid(1);
			victim.SetDeccritrate(true);
			victim.SetProbability(50.0f);
			victim.SetTime(16000.0f);
			victim.SetRatio(((skill_level + 1) * 0.2f));
			victim.SetBuffid(1);
			victim.SetDeccrithurt(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_maxhp = player.GetMaxhp();
			int				skill_level = skill.GetLevel();

			victim.SetProbability((((skill_level + 1) * (skill_level + 1) + (5 * skill_level) + 40)));
			victim.SetRatio(0.0f);
			victim.SetValue((player_maxhp * ((skill_level + 1) * 0.02f)));
			victim.SetHeal(true);
			return true;
		}
	}
	public class GSkill566 : GSkill
	{
		public GSkill566()
			: base(566)
		{
			
		}
	}
	public class GSkill567Stub : GSkillStub
	{
		public GSkill567Stub()
			: base(567)
		{
			occupation = 7;
			maxlevel = 3;
			maxlearn = 2;
			eventflag = 1;
			spcost = 1;
			reborncount = 0;
			type = 11;
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
			name = "º®±ùÁÒÑ×";
			nativename = "º®±ùÁÒÑ×";
			icon = "º®±ùÁÒÑ×.dds";
			SetTalent(0,0);
			SetTalent(1,0);
			SetTalent(2,0);
			SetTalent(3,0);
			SetTalent(4,0);
			SetTalent(5,0);
			SetTalent(6,0);
			SetTalent(7,0);
			talent_size = 0;
			talent_type = 1;
			use_proficiency = false;
			inc_proficiency = 0;
			preskillnum = 0;
			cycle = false;
			cyclemode = 0;
			cyclegfx = "";
			skill_class = 2;
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
		public override int GetRequiredLevel(int level)
		{
			int[] array={15,135};return array[level-1];
		}
	}
	public class GSkill567 : GSkill
	{
		public GSkill567()
			: base(567)
		{
			
		}
	}
	public class GSkill568Stub : GSkillStub
	{
		public GSkill568Stub()
			: base(568)
		{
			occupation = 7;
			maxlevel = 4;
			maxlearn = 3;
			eventflag = 1;
			spcost = 1;
			reborncount = 0;
			type = 11;
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
			name = "ÇýÎï·¨¾÷";
			nativename = "ÇýÎï·¨¾÷";
			icon = "ÇýÎï·¨¾÷.dds";
			SetTalent(0,0);
			SetTalent(1,0);
			SetTalent(2,0);
			SetTalent(3,0);
			SetTalent(4,0);
			SetTalent(5,0);
			SetTalent(6,0);
			SetTalent(7,0);
			talent_size = 0;
			talent_type = 1;
			use_proficiency = false;
			inc_proficiency = 0;
			preskillnum = 0;
			cycle = false;
			cyclemode = 0;
			cyclegfx = "";
			skill_class = 2;
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
		public override int GetRequiredLevel(int level)
		{
			int[] array={15,15,15};return array[level-1];
		}
	}
	public class GSkill568 : GSkill
	{
		public GSkill568()
			: base(568)
		{
			
		}
	}
	public class GSkill569Stub : GSkillStub
	{
		public GSkill569Stub()
			: base(569)
		{
			occupation = 7;
			maxlevel = 3;
			maxlearn = 2;
			eventflag = 1;
			spcost = 1;
			reborncount = 0;
			type = 11;
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
			name = "·ç½£Ö®Ã¢";
			nativename = "·ç½£Ö®Ã¢";
			icon = "Óù½£Ö®Ã¢.dds";
			SetTalent(0,0);
			SetTalent(1,0);
			SetTalent(2,0);
			SetTalent(3,0);
			SetTalent(4,0);
			SetTalent(5,0);
			SetTalent(6,0);
			SetTalent(7,0);
			talent_size = 0;
			talent_type = 1;
			use_proficiency = false;
			inc_proficiency = 0;
			preskillnum = 1;
			cycle = false;
			cyclemode = 0;
			cyclegfx = "";
			skill_class = 2;
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
		public override int GetRequiredLevel(int level)
		{
			int[] array={25,25};return array[level-1];
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={567};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={1};return array[index];
		}
	}
	public class GSkill569 : GSkill
	{
		public GSkill569()
			: base(569)
		{
			
		}
	}
}
