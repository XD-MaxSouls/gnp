using System;
using System.Text;

namespace SKILL
{
	public class GSkill4480Stub : GSkillStub
	{
		public class GState1 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 1525;
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
				int				player_level = player.GetLevel();
				int				skill_level = skill.GetLevel();

				skill.SetRatio((D2INT(player_level / (11 - skill_level)) * 0.01f + (skill_level * 0.02f + 1.0f)));
				skill.SetPlus(((45 * skill_level)));
				player.SetPerform(1);
			}
		}
		public class GState3 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 475;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_level = player.GetLevel();
				int				skill_level = skill.GetLevel();

				skill.SetRatio((D2INT(player_level / (11 - skill_level)) * 0.01f + (skill_level * 0.02f + 1.0f)));
				skill.SetPlus(((45 * skill_level)));
				player.SetPerform(0);
			}
		}
		public GSkill4480Stub()
			: base(4480)
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
			SetAction(0,"ÊŞÉñ_·¨±¦_Ñª·ãÇ¹");
			SetAction(1,"ÇàÔÆÃÅ_·¨±¦_ÆßĞÇ½£");
			SetAction(2,"ÇàÔÆÃÅ_·¨±¦_ÆßĞÇ½£");
			SetAction(3,"ÇàÔÆÃÅ_·¨±¦_ÆßĞÇ½£");
			SetAction(4,"ÇàÔÆÃÅ_·¨±¦_ÆßĞÇ½£");
			SetAction(5,"ÇàÔÆÃÅ_·¨±¦_ÆßĞÇ½£");
			SetAction(6,"ÇàÔÆÃÅ_·¨±¦_ÆßĞÇ½£");
			SetAction(7,"ÊŞÉñ_·¨±¦_Ñª·ãÇ¹");
			SetAction(8,"ºüÑı_·¨±¦_·µ»êÏã");
			SetAction(9,"ĞùÔ¯_·¨±¦_ÄõÁú¹Ä");
			SetAction(10,"»³¹â_·¨±¦_ÆÆ¾ü");
			SetAction(11,"Ì«ê»_·¨±¦_´ºÇïËø");
			SetAction(12,"Ìì»ª_·¨±¦_ÑÇ·ç");
			SetAction(13,"01");
			SetAction(14,"01");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"ÊŞÉñ_Æï³Ë_·¨±¦_Ñª·ãÇ¹");
			SetAction(19,"ÇàÔÆÃÅ_Æï³Ë_·¨±¦_ÆßĞÇ½£");
			SetAction(20,"ÇàÔÆÃÅ_Æï³Ë_·¨±¦_ÆßĞÇ½£");
			SetAction(21,"ÇàÔÆÃÅ_Æï³Ë_·¨±¦_ÆßĞÇ½£");
			SetAction(22,"ÇàÔÆÃÅ_Æï³Ë_·¨±¦_ÆßĞÇ½£");
			SetAction(23,"ÇàÔÆÃÅ_Æï³Ë_·¨±¦_ÆßĞÇ½£");
			SetAction(24,"ÇàÔÆÃÅ_Æï³Ë_·¨±¦_ÆßĞÇ½£");
			SetAction(25,"ÊŞÉñ_Æï³Ë_·¨±¦_Ñª·ãÇ¹");
			SetAction(26,"ºüÑı_Æï³Ë_·¨±¦_·µ»êÏã");
			SetAction(27,"ĞùÔ¯_Æï³Ë_·¨±¦_ÄõÁú¹Ä");
			SetAction(28,"»³¹â_Æï³Ë_·¨±¦_ÆÆ¾ü");
			SetAction(29,"Ì«ê»_Æï³Ë_·¨±¦_´ºÇïËø");
			SetAction(30,"Ìì»ª_Æï³Ë_·¨±¦_ÑÇ·ç");
			name = "³Ğ¡¤·ãÁÖÉ·Ñª";
			nativename = "³Ğ¡¤·ãÁÖÉ·Ñª";
			icon = "·ãÁÖÉ·Ñª.dds";
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

			return ((-15 * skill_level) - skill_level * skill_level + 185);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();

			victim.SetTime(((2000 * skill_level + 2100)));
			victim.SetAmount(((2 * norm(skill_level / 4.9f) + (norm(skill_level / 3.9f) + skill_level))));
			victim.SetValue(((12 * skill_level + 6)));
			victim.SetCursed(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();

			victim.SetProbability(120.0f);
			victim.SetTime(((2000 * skill_level + 7100)));
			victim.SetRatio(1.0f);
			victim.SetAmount(((2 * norm(skill_level / 4.9f) + (norm(skill_level / 3.9f) + skill_level))));
			victim.SetValue(((skill_level * skill_level + (2 * skill_level) + 6)));
			victim.SetFrenzied(true);
			return true;
		}
	}
	public class GSkill4480 : GSkill
	{
		public GSkill4480()
			: base(4480)
		{
			
		}
	}
	public class GSkill4481Stub : GSkillStub
	{
		public class GState1 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 1625;
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
				return 375;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_level = player.GetLevel();
				int				skill_level = skill.GetLevel();

				skill.SetRatio((D2INT(player_level / (11 - skill_level)) * 0.01f + (skill_level * 0.03f + 1.0f)));
				skill.SetPlus(((60 * skill_level)));
				player.SetPerform(1);
			}
		}
		public GSkill4481Stub()
			: base(4481)
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
			SetAction(0,"ºüÑı_·¨±¦_·µ»êÏã");
			SetAction(1,"¹íÍõ×Ú_·¨±¦_ËÄÁéá¦");
			SetAction(2,"¹íÍõ×Ú_·¨±¦_ËÄÁéá¦");
			SetAction(3,"¹íÍõ×Ú_·¨±¦_ËÄÁéá¦");
			SetAction(4,"¹íÍõ×Ú_·¨±¦_ËÄÁéá¦");
			SetAction(5,"¹íÍõ×Ú_·¨±¦_ËÄÁéá¦");
			SetAction(6,"¹íÍõ×Ú_·¨±¦_ËÄÁéá¦");
			SetAction(7,"ÊŞÉñ_·¨±¦_Ñª·ãÇ¹");
			SetAction(8,"ºüÑı_·¨±¦_·µ»êÏã");
			SetAction(9,"ĞùÔ¯_·¨±¦_ÄõÁú¹Ä");
			SetAction(10,"»³¹â_·¨±¦_ÆÆ¾ü");
			SetAction(11,"Ì«ê»_·¨±¦_´ºÇïËø");
			SetAction(12,"Ìì»ª_·¨±¦_ÑÇ·ç");
			SetAction(13,"01");
			SetAction(14,"01");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"ºüÑı_Æï³Ë_·¨±¦_·µ»êÏã");
			SetAction(19,"¹íÍõ×Ú_Æï³Ë_·¨±¦_ËÄÁéá¦");
			SetAction(20,"¹íÍõ×Ú_Æï³Ë_·¨±¦_ËÄÁéá¦");
			SetAction(21,"¹íÍõ×Ú_Æï³Ë_·¨±¦_ËÄÁéá¦");
			SetAction(22,"¹íÍõ×Ú_Æï³Ë_·¨±¦_ËÄÁéá¦");
			SetAction(23,"¹íÍõ×Ú_Æï³Ë_·¨±¦_ËÄÁéá¦");
			SetAction(24,"¹íÍõ×Ú_Æï³Ë_·¨±¦_ËÄÁéá¦");
			SetAction(25,"ÊŞÉñ_Æï³Ë_·¨±¦_Ñª·ãÇ¹");
			SetAction(26,"ºüÑı_Æï³Ë_·¨±¦_·µ»êÏã");
			SetAction(27,"ĞùÔ¯_Æï³Ë_·¨±¦_ÄõÁú¹Ä");
			SetAction(28,"»³¹â_Æï³Ë_·¨±¦_ÆÆ¾ü");
			SetAction(29,"Ì«ê»_Æï³Ë_·¨±¦_´ºÇïËø");
			SetAction(30,"Ìì»ª_Æï³Ë_·¨±¦_ÑÇ·ç");
			name = "³Ğ¡¤¶áÆÇ·µ»ê";
			nativename = "³Ğ¡¤¶áÆÇ·µ»ê";
			icon = "¶áÆÇ·µ»ê.dds";
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

			return ((-15 * skill_level) - skill_level * skill_level + 195);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_maxmp = player.GetMaxmp();
			int				skill_level = skill.GetLevel();

			/*
			victim.SetProbability(((8 * skill_level + 26)));
			victim.SetTime(((30100 - 2000 * skill_level)));
			victim.SetBuffid(4);
			victim.SetAmount(256.0f);
			victim.SetCycsubdefence(true);
			v25 = 3 * skill_level + 13;
			if ( skill_level == 5 )
			v24 = (v25 + 5);
			else
			victim.SetProbability(v25);
			if ( skill_level == 5 )
			v23 = 2.0f;
			else
			victim.SetAmount(1.0f);
			victim.SetClearbuff(true);
			victim.SetProbability(-1.0f);
			victim.SetTime(6100.0f);
			victim.SetBuffid(4);
			victim.SetAmount((skill_level * (player_maxmp * 0.2f)));
			victim.SetValue(0.0f);
			victim.SetMpleak(true);
			*/
			return true;
		}
	}
	public class GSkill4481 : GSkill
	{
		public GSkill4481()
			: base(4481)
		{
			
		}
	}
	public class GSkill4482Stub : GSkillStub
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
				int				skill_level = skill.GetLevel();

				skill.SetRatio((D2INT(player_level / (11 - skill_level)) * 0.01f + (skill_level * 0.03f + 1.0f)));
				skill.SetPlus(((60 * skill_level)));
				player.SetPerform(1);
			}
		}
		public GSkill4482Stub()
			: base(4482)
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
			SetAction(0,"»³¹â_·¨±¦_ÆÆ¾ü");
			SetAction(1,"ÌìÒôËÂ_·¨±¦_½ğ¸ÕèÆ");
			SetAction(2,"ÌìÒôËÂ_·¨±¦_½ğ¸ÕèÆ");
			SetAction(3,"ÌìÒôËÂ_·¨±¦_½ğ¸ÕèÆ");
			SetAction(4,"ÌìÒôËÂ_·¨±¦_½ğ¸ÕèÆ");
			SetAction(5,"ÌìÒôËÂ_·¨±¦_½ğ¸ÕèÆ");
			SetAction(6,"ÌìÒôËÂ_·¨±¦_½ğ¸ÕèÆ");
			SetAction(7,"ÊŞÉñ_·¨±¦_Ñª·ãÇ¹");
			SetAction(8,"ºüÑı_·¨±¦_·µ»êÏã");
			SetAction(9,"ĞùÔ¯_·¨±¦_ÄõÁú¹Ä");
			SetAction(10,"»³¹â_·¨±¦_ÆÆ¾ü");
			SetAction(11,"Ì«ê»_·¨±¦_´ºÇïËø");
			SetAction(12,"Ìì»ª_·¨±¦_ÑÇ·ç");
			SetAction(13,"01");
			SetAction(14,"01");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"»³¹â_Æï³Ë_·¨±¦_ÆÆ¾ü");
			SetAction(19,"ÌìÒôËÂ_Æï³Ë_·¨±¦_½ğ¸ÕèÆ");
			SetAction(20,"ÌìÒôËÂ_Æï³Ë_·¨±¦_½ğ¸ÕèÆ");
			SetAction(21,"ÌìÒôËÂ_Æï³Ë_·¨±¦_½ğ¸ÕèÆ");
			SetAction(22,"ÌìÒôËÂ_Æï³Ë_·¨±¦_½ğ¸ÕèÆ");
			SetAction(23,"ÌìÒôËÂ_Æï³Ë_·¨±¦_½ğ¸ÕèÆ");
			SetAction(24,"ÌìÒôËÂ_Æï³Ë_·¨±¦_½ğ¸ÕèÆ");
			SetAction(25,"ÊŞÉñ_Æï³Ë_·¨±¦_Ñª·ãÇ¹");
			SetAction(26,"ºüÑı_Æï³Ë_·¨±¦_·µ»êÏã");
			SetAction(27,"ĞùÔ¯_Æï³Ë_·¨±¦_ÄõÁú¹Ä");
			SetAction(28,"»³¹â_Æï³Ë_·¨±¦_ÆÆ¾ü");
			SetAction(29,"Ì«ê»_Æï³Ë_·¨±¦_´ºÇïËø");
			SetAction(30,"Ìì»ª_Æï³Ë_·¨±¦_ÑÇ·ç");
			name = "³Ğ¡¤ºáÉ¨Ç§¾ü";
			nativename = "³Ğ¡¤ºáÉ¨Ç§¾ü";
			icon = "ºáÉ¨Ç§¾ü.dds";
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

			return ((-15 * skill_level) - skill_level * skill_level + 195);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();

			victim.SetProbability(120.0f);
			victim.SetTime(12000.0f);
			victim.SetRatio((skill_level * 0.02f));
			victim.SetBuffid(0);
			victim.SetDecdefence(true);
			victim.SetTime(12000.0f);
			victim.SetRatio((skill_level * 0.02f));
			victim.SetBuffid(0);
			victim.SetDecskilldamage(true);
			return true;
		}
	}
	public class GSkill4482 : GSkill
	{
		public GSkill4482()
			: base(4482)
		{
			
		}
	}
	public class GSkill4483Stub : GSkillStub
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
				int				skill_level = skill.GetLevel();

				skill.SetRatio((D2INT(player_level / (11 - skill_level)) * 0.01f + (skill_level * 0.03f + 1.0f)));
				skill.SetPlus(((60 * skill_level)));
				player.SetPerform(1);
			}
		}
		public GSkill4483Stub()
			: base(4483)
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
			SetAction(0,"Ìì»ª_·¨±¦_ÑÇ·ç");
			SetAction(1,"ºÏ»¶ÅÉ_·¨±¦_¶àÇé»·");
			SetAction(2,"ºÏ»¶ÅÉ_·¨±¦_¶àÇé»·");
			SetAction(3,"ºÏ»¶ÅÉ_·¨±¦_¶àÇé»·");
			SetAction(4,"ºÏ»¶ÅÉ_·¨±¦_¶àÇé»·");
			SetAction(5,"ºÏ»¶ÅÉ_·¨±¦_¶àÇé»·");
			SetAction(6,"ºÏ»¶ÅÉ_·¨±¦_¶àÇé»·");
			SetAction(7,"ÊŞÉñ_·¨±¦_Ñª·ãÇ¹");
			SetAction(8,"ºüÑı_·¨±¦_·µ»êÏã");
			SetAction(9,"ĞùÔ¯_·¨±¦_ÄõÁú¹Ä");
			SetAction(10,"»³¹â_·¨±¦_ÆÆ¾ü");
			SetAction(11,"Ì«ê»_·¨±¦_´ºÇïËø");
			SetAction(12,"Ìì»ª_·¨±¦_ÑÇ·ç");
			SetAction(13,"01");
			SetAction(14,"01");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"Ìì»ª_Æï³Ë_·¨±¦_ÑÇ·ç");
			SetAction(19,"ºÏ»¶ÅÉ_Æï³Ë_·¨±¦_¶àÇé»·");
			SetAction(20,"ºÏ»¶ÅÉ_Æï³Ë_·¨±¦_¶àÇé»·");
			SetAction(21,"ºÏ»¶ÅÉ_Æï³Ë_·¨±¦_¶àÇé»·");
			SetAction(22,"ºÏ»¶ÅÉ_Æï³Ë_·¨±¦_¶àÇé»·");
			SetAction(23,"ºÏ»¶ÅÉ_Æï³Ë_·¨±¦_¶àÇé»·");
			SetAction(24,"ºÏ»¶ÅÉ_Æï³Ë_·¨±¦_¶àÇé»·");
			SetAction(25,"ÊŞÉñ_Æï³Ë_·¨±¦_Ñª·ãÇ¹");
			SetAction(26,"ºüÑı_Æï³Ë_·¨±¦_·µ»êÏã");
			SetAction(27,"ĞùÔ¯_Æï³Ë_·¨±¦_ÄõÁú¹Ä");
			SetAction(28,"»³¹â_Æï³Ë_·¨±¦_ÆÆ¾ü");
			SetAction(29,"Ì«ê»_Æï³Ë_·¨±¦_´ºÇïËø");
			SetAction(30,"Ìì»ª_Æï³Ë_·¨±¦_ÑÇ·ç");
			name = "³Ğ¡¤²Ôñ··ï¸è";
			nativename = "³Ğ¡¤²Ôñ··ï¸è";
			icon = "²Ôñ··ï¸è.dds";
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

			return ((-15 * skill_level) - skill_level * skill_level + 195);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_hp = player.GetHp();
			int				skill_level = skill.GetLevel();

			victim.SetProbability(((25 * skill_level + 75)));
			victim.SetTime(((500 * skill_level + 1000)));
			victim.SetRatio(((skill_level + 1) * 0.05f));
			victim.SetBuffid(1);
			victim.SetSlow(true);
			victim.SetProbability(-1.0f);
			victim.SetTime(2000.0f);
			victim.SetBuffid(1);
			victim.SetAmount((player_hp * (skill_level * 0.02f + 0.02f)));
			victim.SetValue(0.0f);
			victim.SetHpleak(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();

			victim.SetProbability(((2 * skill_level + 2)));
			victim.SetTime(2000.0f);
			victim.SetBuffid(1);
			victim.SetAmount(((18 * skill_level * skill_level)));
			victim.SetValue(1.0f);
			victim.SetMpgen(true);
			return true;
		}
	}
	public class GSkill4483 : GSkill
	{
		public GSkill4483()
			: base(4483)
		{
			
		}
	}
	public class GSkill4484Stub : GSkillStub
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
				int				player_level = player.GetLevel();
				int				skill_level = skill.GetLevel();

				skill.SetRatio((D2INT(player_level / (11 - skill_level)) * 0.01f + (skill_level * 0.05f + 1.0f)));
				skill.SetPlus(((60 * skill_level)));
				player.SetPerform(1);
			}
		}
		public GSkill4484Stub()
			: base(4484)
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
			SetAction(0,"Ì«ê»_·¨±¦_´ºÇïËø");
			SetAction(1,"¹íµÀ_·¨±¦_ÆÆÉ²");
			SetAction(2,"¹íµÀ_·¨±¦_ÆÆÉ²");
			SetAction(3,"¹íµÀ_·¨±¦_ÆÆÉ²");
			SetAction(4,"¹íµÀ_·¨±¦_ÆÆÉ²");
			SetAction(5,"¹íµÀ_·¨±¦_ÆÆÉ²");
			SetAction(6,"¹íµÀ_·¨±¦_ÆÆÉ²");
			SetAction(7,"ÊŞÉñ_·¨±¦_Ñª·ãÇ¹");
			SetAction(8,"ºüÑı_·¨±¦_·µ»êÏã");
			SetAction(9,"ĞùÔ¯_·¨±¦_ÄõÁú¹Ä");
			SetAction(10,"»³¹â_·¨±¦_ÆÆ¾ü");
			SetAction(11,"Ì«ê»_·¨±¦_´ºÇïËø");
			SetAction(12,"Ìì»ª_·¨±¦_ÑÇ·ç");
			SetAction(13,"01");
			SetAction(14,"01");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"Ì«ê»_Æï³Ë_·¨±¦_´ºÇïËø");
			SetAction(19,"¹íµÀ_Æï³Ë_·¨±¦_ÆÆÉ²");
			SetAction(20,"¹íµÀ_Æï³Ë_·¨±¦_ÆÆÉ²");
			SetAction(21,"¹íµÀ_Æï³Ë_·¨±¦_ÆÆÉ²");
			SetAction(22,"¹íµÀ_Æï³Ë_·¨±¦_ÆÆÉ²");
			SetAction(23,"¹íµÀ_Æï³Ë_·¨±¦_ÆÆÉ²");
			SetAction(24,"¹íµÀ_Æï³Ë_·¨±¦_ÆÆÉ²");
			SetAction(25,"ÊŞÉñ_Æï³Ë_·¨±¦_Ñª·ãÇ¹");
			SetAction(26,"ºüÑı_Æï³Ë_·¨±¦_·µ»êÏã");
			SetAction(27,"ĞùÔ¯_Æï³Ë_·¨±¦_ÄõÁú¹Ä");
			SetAction(28,"»³¹â_Æï³Ë_·¨±¦_ÆÆ¾ü");
			SetAction(29,"Ì«ê»_Æï³Ë_·¨±¦_´ºÇïËø");
			SetAction(30,"Ìì»ª_Æï³Ë_·¨±¦_ÑÇ·ç");
			name = "³Ğ¡¤éäÂäÁ÷»ª";
			nativename = "³Ğ¡¤éäÂäÁ÷»ª";
			icon = "éäÂäÁ÷»ª.dds";
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

			return ((-15 * skill_level) - skill_level * skill_level + 195);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_res3 = player.GetRes3();
			int				skill_level = skill.GetLevel();

			/*
			victim.SetProbability(((8 * skill_level + 26)));
			victim.SetTime(((30100 - 2000 * skill_level)));
			victim.SetBuffid(3);
			victim.SetAmount(256.0f);
			victim.SetCycsubdefence(true);
			v27 = 5 * skill_level + 10;
			if ( skill_level == 5 )
			{
			v26 = (v27 + player_res3);
			}
			else
			{
			v26 = v27;
			}
			victim.SetProbability(v26);
			victim.SetTime(((1000 * skill_level)));
			victim.SetWrap(true);
			if ( player.GetHasbuff(4099) == 1 )
			v25 = (8 * skill_level + 10);
			else
			victim.SetProbability(0.0f);
			victim.SetTime(((1000 * skill_level + 4000)));
			victim.SetRatio((skill_level * 0.08f));
			victim.SetValue((skill_level * 0.08f));
			victim.SetParalysis(true);
			*/
			return true;
		}
	}
	public class GSkill4484 : GSkill
	{
		public GSkill4484()
			: base(4484)
		{
			
		}
	}
	public class GSkill4485Stub : GSkillStub
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
				int				skill_level = skill.GetLevel();

				skill.SetRatio((D2INT(player_level / (11 - skill_level)) * 0.01f + (skill_level * 0.03f + 1.0f)));
				skill.SetPlus(((60 * skill_level)));
				player.SetPerform(1);
			}
		}
		public GSkill4485Stub()
			: base(4485)
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
			SetAction(0,"ĞùÔ¯_·¨±¦_ÄõÁú¹Ä");
			SetAction(1,"·ÙÏã¹È_·¨±¦_ºâÌì³ß");
			SetAction(2,"·ÙÏã¹È_·¨±¦_ºâÌì³ß");
			SetAction(3,"·ÙÏã¹È_·¨±¦_ºâÌì³ß");
			SetAction(4,"·ÙÏã¹È_·¨±¦_ºâÌì³ß");
			SetAction(5,"·ÙÏã¹È_·¨±¦_ºâÌì³ß");
			SetAction(6,"·ÙÏã¹È_·¨±¦_ºâÌì³ß");
			SetAction(7,"ÊŞÉñ_·¨±¦_Ñª·ãÇ¹");
			SetAction(8,"ºüÑı_·¨±¦_·µ»êÏã");
			SetAction(9,"ĞùÔ¯_·¨±¦_ÄõÁú¹Ä");
			SetAction(10,"»³¹â_·¨±¦_ÆÆ¾ü");
			SetAction(11,"Ì«ê»_·¨±¦_´ºÇïËø");
			SetAction(12,"Ìì»ª_·¨±¦_ÑÇ·ç");
			SetAction(13,"01");
			SetAction(14,"01");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"ĞùÔ¯_Æï³Ë_·¨±¦_ÄõÁú¹Ä");
			SetAction(19,"·ÙÏã¹È_Æï³Ë_·¨±¦_ºâÌì³ß");
			SetAction(20,"·ÙÏã¹È_Æï³Ë_·¨±¦_ºâÌì³ß");
			SetAction(21,"·ÙÏã¹È_Æï³Ë_·¨±¦_ºâÌì³ß");
			SetAction(22,"·ÙÏã¹È_Æï³Ë_·¨±¦_ºâÌì³ß");
			SetAction(23,"·ÙÏã¹È_Æï³Ë_·¨±¦_ºâÌì³ß");
			SetAction(24,"·ÙÏã¹È_Æï³Ë_·¨±¦_ºâÌì³ß");
			SetAction(25,"ÊŞÉñ_Æï³Ë_·¨±¦_Ñª·ãÇ¹");
			SetAction(26,"ºüÑı_Æï³Ë_·¨±¦_·µ»êÏã");
			SetAction(27,"ĞùÔ¯_Æï³Ë_·¨±¦_ÄõÁú¹Ä");
			SetAction(28,"»³¹â_Æï³Ë_·¨±¦_ÆÆ¾ü");
			SetAction(29,"Ì«ê»_Æï³Ë_·¨±¦_´ºÇïËø");
			SetAction(30,"Ìì»ª_Æï³Ë_·¨±¦_ÑÇ·ç");
			name = "³Ğ¡¤À×¹ÄÕğÌì";
			nativename = "³Ğ¡¤À×¹ÄÕğÌì";
			icon = "¿ñÀ×ÌìÅ­.dds";
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

			return ((-15 * skill_level) - skill_level * skill_level + 195);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_hp = player.GetHp();
			int				skill_level = skill.GetLevel();

			victim.SetProbability(((25 * skill_level + 75)));
			victim.SetTime(((1000 * skill_level + 1000)));
			victim.SetSilent(true);
			victim.SetProbability(-1.0f);
			victim.SetTime(2000.0f);
			victim.SetBuffid(1);
			victim.SetAmount(((skill_level + 4) * (player_hp * 0.01f)));
			victim.SetValue(0.0f);
			victim.SetHpleak(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();

			victim.SetProbability(((2 * skill_level + 2)));
			victim.SetTime(12000.0f);
			victim.SetBuffid(1);
			victim.SetValue(((6 * skill_level + 38)));
			victim.SetAddattack(true);
			return true;
		}
	}
	public class GSkill4485 : GSkill
	{
		public GSkill4485()
			: base(4485)
		{
			
		}
	}
	public class GSkill4486Stub : GSkillStub
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
				int				player_mp = player.GetMp();
				int				player_maxmp = player.GetMaxmp();
				int				player_def = player.GetDef();
				int				skill_level = skill.GetLevel();
				int				skill_t0 = skill.GetT0();
				int				skill_t1 = skill.GetT1();
				int				skill_t2 = skill.GetT2();

				skill.SetCrit((skill_t1 * 0.02f));
				skill.SetRatio(((skill_t0 + 1) * (D2INT((player_mp / 0.95f) / player_maxmp) * 0.12f) + (D2INT(player_level / (10 - skill_level)) * 0.01f + (skill_t0 * 0.08f + (skill_level * 0.05f + 1.0f)))));
				skill.SetPlus((player_def * (skill_t2 * 0.03f) + ((120 * skill_level))));
				player.SetPerform(1);
			}
		}
		public GSkill4486Stub()
			: base(4486)
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
			SetAction(0,"¹íµÀ_·¨±¦_çúçêÖìç±");
			SetAction(1,"ÇàÔÆÃÅ_·¨±¦_çúçêÖìç±");
			SetAction(2,"¹íÍõ×Ú_·¨±¦_çúçêÖìç±");
			SetAction(3,"ºÏ»¶ÅÉ_·¨±¦_çúçêÖìç±");
			SetAction(4,"ÌìÒôËÂ_·¨±¦_çúçêÖìç±");
			SetAction(5,"¹íµÀ_·¨±¦_çúçêÖìç±");
			SetAction(6,"¹íµÀ_·¨±¦_çúçêÖìç±");
			SetAction(7,"ÊŞÉñ_·¨±¦_î¸á°");
			SetAction(8,"ºüÑı_·¨±¦_¸¡Ó°¹Å¾µ");
			SetAction(9,"ĞùÔ¯_·¨±¦_ÂäµØ½ğÇ®");
			SetAction(10,"»³¹â_·¨±¦_Ì°ÀÇ");
			SetAction(11,"Ì«ê»_·¨±¦_×ÓÄ¸ÒõÑô¿Û");
			SetAction(12,"Ìì»ª_·¨±¦_ÁğÁ§Õµ");
			SetAction(13,"01");
			SetAction(14,"01");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"¹íµÀ_Æï³Ë_·¨±¦_çúçêÖìç±");
			SetAction(19,"ÇàÔÆÃÅ_Æï³Ë_·¨±¦_çúçêÖìç±");
			SetAction(20,"¹íÍõ×Ú_Æï³Ë_·¨±¦_çúçêÖìç±");
			SetAction(21,"ºÏ»¶ÅÉ_Æï³Ë_·¨±¦_çúçêÖìç±");
			SetAction(22,"ÌìÒôËÂ_Æï³Ë_·¨±¦_çúçêÖìç±");
			SetAction(23,"¹íµÀ_Æï³Ë_·¨±¦_çúçêÖìç±");
			SetAction(24,"¹íµÀ_Æï³Ë_·¨±¦_çúçêÖìç±");
			SetAction(25,"ÊŞÉñ_Æï³Ë_·¨±¦_î¸á°");
			SetAction(26,"ºüÑı_Æï³Ë_·¨±¦_¸¡Ó°¹Å¾µ");
			SetAction(27,"ĞùÔ¯_Æï³Ë_·¨±¦_ÂäµØ½ğÇ®");
			SetAction(28,"»³¹â_Æï³Ë_·¨±¦_Ì°ÀÇ");
			SetAction(29,"Ì«ê»_Æï³Ë_·¨±¦_×ÓÄ¸ÒõÑô¿Û");
			SetAction(30,"Ìì»ª_Æï³Ë_·¨±¦_ÁğÁ§Õµ");
			name = "³Ğ¡¤Ç§ç±Ñ¤Îè";
			nativename = "³Ğ¡¤Ç§ç±Ñ¤Îè";
			icon = "Ç§ç±Ñ¤Îè.dds";
			SetTalent(0,568);
			SetTalent(1,599);
			SetTalent(2,1582);
			SetTalent(3,0);
			SetTalent(4,0);
			SetTalent(5,0);
			SetTalent(6,0);
			SetTalent(7,0);
			talent_size = 3;
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

			victim.SetTime(((1000 * skill_t0 + 5100)));
			victim.SetRatio((zrand(3 * skill_level + 17) / 100.0f + (skill_level * 0.01f)));
			victim.SetBuffid(1);
			victim.SetDecskilldamage(true);
			victim.SetProbability(((25 * skill_level + 100)));
			victim.SetTime(((500 * skill_t0 + 3100)));
			victim.SetWrap(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_mp = player.GetMp();
			int				player_maxmp = player.GetMaxmp();

			victim.SetBuffid((D2INT((player_mp / 0.95f) / player_maxmp)));
			victim.SetUniqprompt(true);
			return true;
		}
	}
	public class GSkill4486 : GSkill
	{
		public GSkill4486()
			: base(4486)
		{
			
		}
	}
	public class GSkill4487Stub : GSkillStub
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
		public GSkill4487Stub()
			: base(4487)
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
			SetAction(0,"¹íÍõ×Ú_·¨±¦_Ç¬À¤Çà¹â½ä");
			SetAction(1,"ÇàÔÆÃÅ_·¨±¦_Ç¬À¤Çà¹â½ä");
			SetAction(2,"¹íÍõ×Ú_·¨±¦_Ç¬À¤Çà¹â½ä");
			SetAction(3,"ºÏ»¶ÅÉ_·¨±¦_Ç¬À¤Çà¹â½ä");
			SetAction(4,"ÌìÒôËÂ_·¨±¦_Ç¬À¤Çà¹â½ä");
			SetAction(5,"¹íµÀ_·¨±¦_Ç¬À¤Çà¹â½ä");
			SetAction(6,"¹íµÀ_·¨±¦_Ç¬À¤Çà¹â½ä");
			SetAction(7,"ÊŞÉñ_·¨±¦_î¸á°");
			SetAction(8,"ºüÑı_·¨±¦_¸¡Ó°¹Å¾µ");
			SetAction(9,"ĞùÔ¯_·¨±¦_ÂäµØ½ğÇ®");
			SetAction(10,"»³¹â_·¨±¦_Ì°ÀÇ");
			SetAction(11,"Ì«ê»_·¨±¦_×ÓÄ¸ÒõÑô¿Û");
			SetAction(12,"Ìì»ª_·¨±¦_ÁğÁ§Õµ");
			SetAction(13,"01");
			SetAction(14,"01");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"¹íÍõ×Ú_Æï³Ë_·¨±¦_Ç¬À¤Çà¹â½ä");
			SetAction(19,"ÇàÔÆÃÅ_Æï³Ë_·¨±¦_Ç¬À¤Çà¹â½ä");
			SetAction(20,"¹íÍõ×Ú_Æï³Ë_·¨±¦_Ç¬À¤Çà¹â½ä");
			SetAction(21,"ºÏ»¶ÅÉ_Æï³Ë_·¨±¦_Ç¬À¤Çà¹â½ä");
			SetAction(22,"ÌìÒôËÂ_Æï³Ë_·¨±¦_Ç¬À¤Çà¹â½ä");
			SetAction(23,"¹íµÀ_Æï³Ë_·¨±¦_Ç¬À¤Çà¹â½ä");
			SetAction(24,"¹íµÀ_Æï³Ë_·¨±¦_Ç¬À¤Çà¹â½ä");
			SetAction(25,"ÊŞÉñ_Æï³Ë_·¨±¦_î¸á°");
			SetAction(26,"ºüÑı_Æï³Ë_·¨±¦_¸¡Ó°¹Å¾µ");
			SetAction(27,"ĞùÔ¯_Æï³Ë_·¨±¦_ÂäµØ½ğÇ®");
			SetAction(28,"»³¹â_Æï³Ë_·¨±¦_Ì°ÀÇ");
			SetAction(29,"Ì«ê»_Æï³Ë_·¨±¦_×ÓÄ¸ÒõÑô¿Û");
			SetAction(30,"Ìì»ª_Æï³Ë_·¨±¦_ÁğÁ§Õµ");
			name = "³Ğ¡¤Çà¹âÕ§ÏÖ";
			nativename = "³Ğ¡¤Çà¹âÕ§ÏÖ";
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
	public class GSkill4487 : GSkill
	{
		public GSkill4487()
			: base(4487)
		{
			
		}
	}
	public class GSkill4488Stub : GSkillStub
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
		public GSkill4488Stub()
			: base(4488)
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
			SetAction(0,"¹íÍõ×Ú_·¨±¦_ÈçÒâÇ¬À¤´ü");
			SetAction(1,"ÇàÔÆÃÅ_·¨±¦_ÈçÒâÇ¬À¤´ü");
			SetAction(2,"¹íÍõ×Ú_·¨±¦_ÈçÒâÇ¬À¤´ü");
			SetAction(3,"ºÏ»¶ÅÉ_·¨±¦_ÈçÒâÇ¬À¤´ü");
			SetAction(4,"ÌìÒôËÂ_·¨±¦_ÈçÒâÇ¬À¤´ü");
			SetAction(5,"¹íµÀ_·¨±¦_ÈçÒâÇ¬À¤´ü");
			SetAction(6,"¹íµÀ_·¨±¦_ÈçÒâÇ¬À¤´ü");
			SetAction(7,"ÊŞÉñ_·¨±¦_î¸á°");
			SetAction(8,"ºüÑı_·¨±¦_¸¡Ó°¹Å¾µ");
			SetAction(9,"ĞùÔ¯_·¨±¦_ÂäµØ½ğÇ®");
			SetAction(10,"»³¹â_·¨±¦_Ì°ÀÇ");
			SetAction(11,"Ì«ê»_·¨±¦_×ÓÄ¸ÒõÑô¿Û");
			SetAction(12,"Ìì»ª_·¨±¦_ÁğÁ§Õµ");
			SetAction(13,"01");
			SetAction(14,"01");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"¹íÍõ×Ú_Æï³Ë_·¨±¦_ÈçÒâÇ¬À¤´ü");
			SetAction(19,"ÇàÔÆÃÅ_Æï³Ë_·¨±¦_ÈçÒâÇ¬À¤´ü");
			SetAction(20,"¹íÍõ×Ú_Æï³Ë_·¨±¦_ÈçÒâÇ¬À¤´ü");
			SetAction(21,"ºÏ»¶ÅÉ_Æï³Ë_·¨±¦_ÈçÒâÇ¬À¤´ü");
			SetAction(22,"ÌìÒôËÂ_Æï³Ë_·¨±¦_ÈçÒâÇ¬À¤´ü");
			SetAction(23,"¹íµÀ_Æï³Ë_·¨±¦_ÈçÒâÇ¬À¤´ü");
			SetAction(24,"¹íµÀ_Æï³Ë_·¨±¦_ÈçÒâÇ¬À¤´ü");
			SetAction(25,"ÊŞÉñ_Æï³Ë_·¨±¦_î¸á°");
			SetAction(26,"ºüÑı_Æï³Ë_·¨±¦_¸¡Ó°¹Å¾µ");
			SetAction(27,"ĞùÔ¯_Æï³Ë_·¨±¦_ÂäµØ½ğÇ®");
			SetAction(28,"»³¹â_Æï³Ë_·¨±¦_Ì°ÀÇ");
			SetAction(29,"Ì«ê»_Æï³Ë_·¨±¦_×ÓÄ¸ÒõÑô¿Û");
			SetAction(30,"Ìì»ª_Æï³Ë_·¨±¦_ÁğÁ§Õµ");
			name = "³Ğ¡¤Ç¬À¤ÈçÒâ";
			nativename = "³Ğ¡¤Ç¬À¤ÈçÒâ";
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
	public class GSkill4488 : GSkill
	{
		public GSkill4488()
			: base(4488)
		{
			
		}
	}
	public class GSkill4489Stub : GSkillStub
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
		public GSkill4489Stub()
			: base(4489)
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
			SetAction(0,"¹íÍõ×Ú_·¨±¦_Á«»¨");
			SetAction(1,"ÇàÔÆÃÅ_·¨±¦_Á«»¨");
			SetAction(2,"¹íÍõ×Ú_·¨±¦_Á«»¨");
			SetAction(3,"ºÏ»¶ÅÉ_·¨±¦_Á«»¨");
			SetAction(4,"ÌìÒôËÂ_·¨±¦_Á«»¨");
			SetAction(5,"¹íµÀ_·¨±¦_Á«»¨");
			SetAction(6,"¹íµÀ_·¨±¦_Á«»¨");
			SetAction(7,"ÊŞÉñ_·¨±¦_î¸á°");
			SetAction(8,"ºüÑı_·¨±¦_¸¡Ó°¹Å¾µ");
			SetAction(9,"ĞùÔ¯_·¨±¦_ÂäµØ½ğÇ®");
			SetAction(10,"»³¹â_·¨±¦_Ì°ÀÇ");
			SetAction(11,"Ì«ê»_·¨±¦_×ÓÄ¸ÒõÑô¿Û");
			SetAction(12,"Ìì»ª_·¨±¦_ÁğÁ§Õµ");
			SetAction(13,"01");
			SetAction(14,"01");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"¹íÍõ×Ú_Æï³Ë_·¨±¦_Á«»¨");
			SetAction(19,"ÇàÔÆÃÅ_Æï³Ë_·¨±¦_Á«»¨");
			SetAction(20,"¹íÍõ×Ú_Æï³Ë_·¨±¦_Á«»¨");
			SetAction(21,"ºÏ»¶ÅÉ_Æï³Ë_·¨±¦_Á«»¨");
			SetAction(22,"ÌìÒôËÂ_Æï³Ë_·¨±¦_Á«»¨");
			SetAction(23,"¹íµÀ_Æï³Ë_·¨±¦_Á«»¨");
			SetAction(24,"¹íµÀ_Æï³Ë_·¨±¦_Á«»¨");
			SetAction(25,"ÊŞÉñ_Æï³Ë_·¨±¦_î¸á°");
			SetAction(26,"ºüÑı_Æï³Ë_·¨±¦_¸¡Ó°¹Å¾µ");
			SetAction(27,"ĞùÔ¯_Æï³Ë_·¨±¦_ÂäµØ½ğÇ®");
			SetAction(28,"»³¹â_Æï³Ë_·¨±¦_Ì°ÀÇ");
			SetAction(29,"Ì«ê»_Æï³Ë_·¨±¦_×ÓÄ¸ÒõÑô¿Û");
			SetAction(30,"Ìì»ª_Æï³Ë_·¨±¦_ÁğÁ§Õµ");
			name = "³Ğ¡¤°µÏãÎŞ¼Ê";
			nativename = "³Ğ¡¤°µÏãÎŞ¼Ê";
			icon = "°µÏãÎŞ¼Ê.dds";
			SetTalent(0,721);
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
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_level = player.GetLevel();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();

			victim.SetProbability(((35 * skill_level + 85)));
			victim.SetTime(((2000 * skill_level + 4100)));
			victim.SetValue(0.0f);
			victim.SetSleep(true);
			victim.SetProbability(((1.0f - player_level * 0.002f) * 50.0f));
			victim.SetRatio((skill_t0 * 0.09f + 0.36f));
			victim.SetXiaoxin(true);
			victim.SetProbability(100.0f);
			victim.SetTime(12000.0f);
			victim.SetBuffid(1);
			victim.SetAmount(((36 * skill_t0 + (48 * skill_level))));
			victim.SetCycsubdefence(true);
			return true;
		}
	}
	public class GSkill4489 : GSkill
	{
		public GSkill4489()
			: base(4489)
		{
			
		}
	}
}
