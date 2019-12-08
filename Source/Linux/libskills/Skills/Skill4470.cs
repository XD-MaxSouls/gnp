using System;
using System.Text;

namespace SKILL
{
	public class GSkill4470Stub : GSkillStub
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

				skill.SetRatio((D2INT(player_level / (12 - skill_level)) * 0.01f + (skill_level * 0.02f + 1.0f)));
				skill.SetPlus(((15 * skill_level)));
				player.SetPerform(1);
			}
		}
		public GSkill4470Stub()
			: base(4470)
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
			SetAction(0,"»³¹â_·¨±¦_ÆßÉ±");
			SetAction(1,"ÌìÒôËÂ_·¨±¦_ÂÖ»ØÖé");
			SetAction(2,"ÌìÒôËÂ_·¨±¦_ÂÖ»ØÖé");
			SetAction(3,"ÌìÒôËÂ_·¨±¦_ÂÖ»ØÖé");
			SetAction(4,"ÌìÒôËÂ_·¨±¦_ÂÖ»ØÖé");
			SetAction(5,"ÌìÒôËÂ_·¨±¦_ÂÖ»ØÖé");
			SetAction(6,"ÌìÒôËÂ_·¨±¦_ÂÖ»ØÖé");
			SetAction(7,"ÊŞÉñ_·¨±¦_Å­ÊŞá¦");
			SetAction(8,"ºüÑı_·¨±¦_µ¤Öì");
			SetAction(9,"ĞùÔ¯_·¨±¦_ÂÊ¶µÆì");
			SetAction(10,"»³¹â_·¨±¦_ÆßÉ±");
			SetAction(11,"Ì«ê»_·¨±¦_À×¹«Ä«");
			SetAction(12,"Ìì»ª_·¨±¦_¾ÅÒôÂİ");
			SetAction(13,"01");
			SetAction(14,"01");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"»³¹â_Æï³Ë_·¨±¦_ÆßÉ±");
			SetAction(19,"ÌìÒôËÂ_Æï³Ë_·¨±¦_ÂÖ»ØÖé");
			SetAction(20,"ÌìÒôËÂ_Æï³Ë_·¨±¦_ÂÖ»ØÖé");
			SetAction(21,"ÌìÒôËÂ_Æï³Ë_·¨±¦_ÂÖ»ØÖé");
			SetAction(22,"ÌìÒôËÂ_Æï³Ë_·¨±¦_ÂÖ»ØÖé");
			SetAction(23,"ÌìÒôËÂ_Æï³Ë_·¨±¦_ÂÖ»ØÖé");
			SetAction(24,"ÌìÒôËÂ_Æï³Ë_·¨±¦_ÂÖ»ØÖé");
			SetAction(25,"ÊŞÉñ_Æï³Ë_·¨±¦_Å­ÊŞá¦");
			SetAction(26,"ºüÑı_Æï³Ë_·¨±¦_µ¤Öì");
			SetAction(27,"ĞùÔ¯_Æï³Ë_·¨±¦_ÂÊ¶µÆì");
			SetAction(28,"»³¹â_Æï³Ë_·¨±¦_ÆßÉ±");
			SetAction(29,"Ì«ê»_Æï³Ë_·¨±¦_À×¹«Ä«");
			SetAction(30,"Ìì»ª_Æï³Ë_·¨±¦_¾ÅÒôÂİ");
			name = "³Ğ¡¤ÑªÉ±Ç§Àï";
			nativename = "³Ğ¡¤ÑªÉ±Ç§Àï";
			icon = "ÑªÉ±Ç§Àï.dds";
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

			return (63 - 3 * skill_level);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();

			victim.SetProbability(600.0f);
			victim.SetTime(12000.0f);
			victim.SetRatio((skill_level * 0.02f));
			victim.SetBuffid(0);
			victim.SetWeak(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();

			victim.SetProbability(120.0f);
			victim.SetTime(12000.0f);
			victim.SetRatio((skill_level * 0.02f));
			victim.SetBuffid(0);
			victim.SetIncattack(true);
			victim.SetProbability(120.0f);
			victim.SetTime(12000.0f);
			victim.SetRatio(1.0f);
			victim.SetAmount(10.0f);
			victim.SetValue(((6 * skill_level + 4)));
			victim.SetFrenzied(true);
			return true;
		}
	}
	public class GSkill4470 : GSkill
	{
		public GSkill4470()
			: base(4470)
		{
			
		}
	}
	public class GSkill4471Stub : GSkillStub
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

				skill.SetRatio((D2INT(player_level / (12 - skill_level)) * 0.01f + (skill_level * 0.02f + 1.0f)));
				skill.SetPlus(((15 * skill_level)));
				player.SetPerform(1);
			}
		}
		public GSkill4471Stub()
			: base(4471)
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
			SetAction(0,"Ìì»ª_·¨±¦_¾ÅÒôÂİ");
			SetAction(1,"ºÏ»¶ÅÉ_·¨±¦_ÉãĞÄÁå");
			SetAction(2,"ºÏ»¶ÅÉ_·¨±¦_ÉãĞÄÁå");
			SetAction(3,"ºÏ»¶ÅÉ_·¨±¦_ÉãĞÄÁå");
			SetAction(4,"ºÏ»¶ÅÉ_·¨±¦_ÉãĞÄÁå");
			SetAction(5,"ºÏ»¶ÅÉ_·¨±¦_ÉãĞÄÁå");
			SetAction(6,"ºÏ»¶ÅÉ_·¨±¦_ÉãĞÄÁå");
			SetAction(7,"ÊŞÉñ_·¨±¦_Å­ÊŞá¦");
			SetAction(8,"ºüÑı_·¨±¦_µ¤Öì");
			SetAction(9,"ĞùÔ¯_·¨±¦_ÂÊ¶µÆì");
			SetAction(10,"»³¹â_·¨±¦_ÆßÉ±");
			SetAction(11,"Ì«ê»_·¨±¦_À×¹«Ä«");
			SetAction(12,"Ìì»ª_·¨±¦_¾ÅÒôÂİ");
			SetAction(13,"01");
			SetAction(14,"01");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"Ìì»ª_Æï³Ë_·¨±¦_¾ÅÒôÂİ");
			SetAction(19,"ºÏ»¶ÅÉ_Æï³Ë_·¨±¦_ÉåĞÄÁå");
			SetAction(20,"ºÏ»¶ÅÉ_Æï³Ë_·¨±¦_ÉåĞÄÁå");
			SetAction(21,"ºÏ»¶ÅÉ_Æï³Ë_·¨±¦_ÉåĞÄÁå");
			SetAction(22,"ºÏ»¶ÅÉ_Æï³Ë_·¨±¦_ÉåĞÄÁå");
			SetAction(23,"ºÏ»¶ÅÉ_Æï³Ë_·¨±¦_ÉåĞÄÁå");
			SetAction(24,"ºÏ»¶ÅÉ_Æï³Ë_·¨±¦_ÉåĞÄÁå");
			SetAction(25,"ÊŞÉñ_Æï³Ë_·¨±¦_Å­ÊŞá¦");
			SetAction(26,"ºüÑı_Æï³Ë_·¨±¦_µ¤Öì");
			SetAction(27,"ĞùÔ¯_Æï³Ë_·¨±¦_ÂÊ¶µÆì");
			SetAction(28,"»³¹â_Æï³Ë_·¨±¦_ÆßÉ±");
			SetAction(29,"Ì«ê»_Æï³Ë_·¨±¦_À×¹«Ä«");
			SetAction(30,"Ìì»ª_Æï³Ë_·¨±¦_¾ÅÒôÂİ");
			name = "³Ğ¡¤Çí»ªÌìô¥";
			nativename = "³Ğ¡¤Çí»ªÌìô¥";
			icon = "Çí»ªÌìô¥.dds";
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

			return (63 - 3 * skill_level);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();

			victim.SetProbability(((skill_level + 5)));
			victim.SetValue((skill_level * 0.5f + 8.0f));
			victim.SetRepel(true);
			return true;
		}
	}
	public class GSkill4471 : GSkill
	{
		public GSkill4471()
			: base(4471)
		{
			
		}
	}
	public class GSkill4472Stub : GSkillStub
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

				skill.SetRatio((D2INT(player_level / (12 - skill_level)) * 0.01f + (skill_level * 0.03f + 1.0f)));
				skill.SetPlus(((25 * skill_level)));
				player.SetPerform(1);
			}
		}
		public GSkill4472Stub()
			: base(4472)
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
			SetAction(0,"Ì«ê»_·¨±¦_À×¹«Ä«");
			SetAction(1,"¹íµÀ_·¨±¦_ÑªÓñ¹ÇÆ¬");
			SetAction(2,"¹íµÀ_·¨±¦_ÑªÓñ¹ÇÆ¬");
			SetAction(3,"¹íµÀ_·¨±¦_ÑªÓñ¹ÇÆ¬");
			SetAction(4,"¹íµÀ_·¨±¦_ÑªÓñ¹ÇÆ¬");
			SetAction(5,"¹íµÀ_·¨±¦_ÑªÓñ¹ÇÆ¬");
			SetAction(6,"¹íµÀ_·¨±¦_ÑªÓñ¹ÇÆ¬");
			SetAction(7,"ÊŞÉñ_·¨±¦_Å­ÊŞá¦");
			SetAction(8,"ºüÑı_·¨±¦_µ¤Öì");
			SetAction(9,"ĞùÔ¯_·¨±¦_ÂÊ¶µÆì");
			SetAction(10,"»³¹â_·¨±¦_ÆßÉ±");
			SetAction(11,"Ì«ê»_·¨±¦_À×¹«Ä«");
			SetAction(12,"Ìì»ª_·¨±¦_¾ÅÒôÂİ");
			SetAction(13,"01");
			SetAction(14,"01");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"Ì«ê»_Æï³Ë_·¨±¦_À×¹«Ä«");
			SetAction(19,"¹íµÀ_Æï³Ë_·¨±¦_ÑªÓñ¹ÇÆ¬");
			SetAction(20,"¹íµÀ_Æï³Ë_·¨±¦_ÑªÓñ¹ÇÆ¬");
			SetAction(21,"¹íµÀ_Æï³Ë_·¨±¦_ÑªÓñ¹ÇÆ¬");
			SetAction(22,"¹íµÀ_Æï³Ë_·¨±¦_ÑªÓñ¹ÇÆ¬");
			SetAction(23,"¹íµÀ_Æï³Ë_·¨±¦_ÑªÓñ¹ÇÆ¬");
			SetAction(24,"¹íµÀ_Æï³Ë_·¨±¦_ÑªÓñ¹ÇÆ¬");
			SetAction(25,"ÊŞÉñ_Æï³Ë_·¨±¦_Å­ÊŞá¦");
			SetAction(26,"ºüÑı_Æï³Ë_·¨±¦_µ¤Öì");
			SetAction(27,"ĞùÔ¯_Æï³Ë_·¨±¦_ÂÊ¶µÆì");
			SetAction(28,"»³¹â_Æï³Ë_·¨±¦_ÆßÉ±");
			SetAction(29,"Ì«ê»_Æï³Ë_·¨±¦_À×¹«Ä«");
			SetAction(30,"Ìì»ª_Æï³Ë_·¨±¦_¾ÅÒôÂİ");
			name = "³Ğ¡¤ĞÌÌìÅ­À×";
			nativename = "³Ğ¡¤ĞÌÌìÅ­À×";
			icon = "ĞÌÌìÅ­À×.dds";
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

			return (63 - 3 * skill_level);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_res2 = player.GetRes2();
			int				skill_level = skill.GetLevel();

			/*
			v23 = 5 * skill_level + 10;
			if ( skill_level == 5 )
			{
			v22 = (v23 + player_res2);
			}
			else
			{
			v22 = v23;
			}
			victim.SetProbability(v22);
			victim.SetTime(((1000 * skill_level + 4000)));
			victim.SetRatio((skill_level * 0.01f));
			victim.SetBuffid(1);
			victim.SetWeak(true);
			if ( player.GetHasmultbuff(5) == 1 )
			v21 = (2 * skill_level + 5);
			else
			victim.SetProbability(0.0f);
			victim.SetTime(((1000 * skill_level + 4000)));
			victim.SetRatio((skill_level * 0.05f));
			victim.SetValue((skill_level * 0.05f));
			victim.SetParalysis(true);
			*/
			return true;
		}
	}
	public class GSkill4472 : GSkill
	{
		public GSkill4472()
			: base(4472)
		{
			
		}
	}
	public class GSkill4473Stub : GSkillStub
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

				skill.SetRatio((D2INT(player_level / (12 - skill_level)) * 0.01f + (skill_level * 0.02f + 1.0f)));
				skill.SetPlus(((15 * skill_level)));
				player.SetPerform(1);
			}
		}
		public GSkill4473Stub()
			: base(4473)
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
			SetAction(0,"ĞùÔ¯_·¨±¦_ÂÊ¶µÆì");
			SetAction(1,"·ÙÏã¹È_·¨±¦_ÄÏÃ÷Ó¡");
			SetAction(2,"·ÙÏã¹È_·¨±¦_ÄÏÃ÷Ó¡");
			SetAction(3,"·ÙÏã¹È_·¨±¦_ÄÏÃ÷Ó¡");
			SetAction(4,"·ÙÏã¹È_·¨±¦_ÄÏÃ÷Ó¡");
			SetAction(5,"·ÙÏã¹È_·¨±¦_ÄÏÃ÷Ó¡");
			SetAction(6,"·ÙÏã¹È_·¨±¦_ÄÏÃ÷Ó¡");
			SetAction(7,"ÊŞÉñ_·¨±¦_Å­ÊŞá¦");
			SetAction(8,"ºüÑı_·¨±¦_µ¤Öì");
			SetAction(9,"ĞùÔ¯_·¨±¦_ÂÊ¶µÆì");
			SetAction(10,"»³¹â_·¨±¦_ÆßÉ±");
			SetAction(11,"Ì«ê»_·¨±¦_À×¹«Ä«");
			SetAction(12,"Ìì»ª_·¨±¦_¾ÅÒôÂİ");
			SetAction(13,"01");
			SetAction(14,"01");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"ĞùÔ¯_Æï³Ë__·¨±¦_ÂÊ¶µÆì");
			SetAction(19,"·ÙÏã¹È_Æï³Ë_·¨±¦_ÄÏÃ÷Ó¡");
			SetAction(20,"·ÙÏã¹È_Æï³Ë_·¨±¦_ÄÏÃ÷Ó¡");
			SetAction(21,"·ÙÏã¹È_Æï³Ë_·¨±¦_ÄÏÃ÷Ó¡");
			SetAction(22,"·ÙÏã¹È_Æï³Ë_·¨±¦_ÄÏÃ÷Ó¡");
			SetAction(23,"·ÙÏã¹È_Æï³Ë_·¨±¦_ÄÏÃ÷Ó¡");
			SetAction(24,"·ÙÏã¹È_Æï³Ë_·¨±¦_ÄÏÃ÷Ó¡");
			SetAction(25,"ÊŞÉñ_Æï³Ë_·¨±¦_Å­ÊŞá¦");
			SetAction(26,"ºüÑı_Æï³Ë_·¨±¦_µ¤Öì");
			SetAction(27,"ĞùÔ¯_Æï³Ë__·¨±¦_ÂÊ¶µÆì");
			SetAction(28,"»³¹â_Æï³Ë_·¨±¦_ÆßÉ±");
			SetAction(29,"Ì«ê»_Æï³Ë_·¨±¦_À×¹«Ä«");
			SetAction(30,"Ìì»ª_Æï³Ë_·¨±¦_¾ÅÒôÂİ");
			name = "³Ğ¡¤ÂÊ¶µÉñ»ğ";
			nativename = "³Ğ¡¤ÂÊ¶µÉñ»ğ";
			icon = "Òµ»ğ.dds";
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

			return (63 - 3 * skill_level);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();

			victim.SetProbability(((skill_level + 5)));
			victim.SetTime(6100.0f);
			victim.SetBuffid(1);
			victim.SetAmount(((36 * skill_level + 96)));
			victim.SetValue(0.0f);
			victim.SetHpleak(true);
			return true;
		}
	}
	public class GSkill4473 : GSkill
	{
		public GSkill4473()
			: base(4473)
		{
			
		}
	}
	public class GSkill4474Stub : GSkillStub
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
				skill.SetRatio(((skill_t0 + 1) * (D2INT((player_mp / 0.95f) / player_maxmp) * 0.08f) + (D2INT(player_level / (11 - skill_level)) * 0.01f + (skill_level * 0.04f + (skill_t0 * 0.08f + 1.0f)))));
				skill.SetPlus((player_def * (skill_t2 * 0.03f) + ((90 * skill_level))));
				player.SetPerform(1);
			}
		}
		public GSkill4474Stub()
			: base(4474)
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
			SetAction(0,"ÇàÔÆÃÅ_·¨±¦_ÆßĞÇ½£");
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
			SetAction(18,"ÇàÔÆÃÅ_Æï³Ë_·¨±¦_ÆßĞÇ½£");
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
			name = "³Ğ¡¤Á÷ĞÇ¸ÏÔÂ";
			nativename = "³Ğ¡¤Á÷ĞÇ¸ÏÔÂ";
			icon = "Á÷ĞÇ¸ÏÔÂ.dds";
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

			return ((-15 * skill_level) - skill_level * skill_level + 195);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();

			victim.SetProbability(((5 * skill_level + 25)));
			victim.SetTime(((1000 * skill_t0 + 3100)));
			victim.SetRatio((skill_level * 0.05f + 0.25f));
			victim.SetBuffid(1);
			victim.SetSlow(true);
			victim.SetProbability(-1.0f);
			victim.SetTime(4000.0f);
			victim.SetBuffid(1);
			victim.SetAmount(((100 * (skill_t0 + skill_level))));
			victim.SetValue(0.0f);
			victim.SetMpleak(true);
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
	public class GSkill4474 : GSkill
	{
		public GSkill4474()
			: base(4474)
		{
			
		}
	}
	public class GSkill4475Stub : GSkillStub
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

				skill.SetRatio((D2INT(player_level / (11 - skill_level)) * 0.01f + (skill_t0 * 0.1f + (skill_level * 0.02f + 1.0f))));
				skill.SetPlus((player_def * (skill_t1 * 0.03f) + ((10 * skill_level))));
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
				int				player_level = player.GetLevel();
				int				player_def = player.GetDef();
				int				skill_level = skill.GetLevel();
				int				skill_t0 = skill.GetT0();
				int				skill_t1 = skill.GetT1();

				skill.SetRatio((D2INT(player_level / (11 - skill_level)) * 0.01f + (skill_t0 * 0.1f + (skill_level * 0.02f + 1.0f))));
				skill.SetPlus((player_def * (skill_t1 * 0.03f) + ((10 * skill_level))));
				player.SetPerform(0);
			}
		}
		public GSkill4475Stub()
			: base(4475)
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
			SetAction(0,"¹íÍõ×Ú_·¨±¦_ËÄÁéá¦");
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
			SetAction(13,"1");
			SetAction(14,"1");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"¹íÍõ×Ú_Æï³Ë_·¨±¦_ËÄÁéá¦");
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
			name = "³Ğ¡¤ËÄÁéÑªÖä";
			nativename = "³Ğ¡¤ËÄÁéÑªÖä";
			icon = "ËÄÁéÑªÖä.dds";
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

			return ((-15 * skill_level) - skill_level * skill_level + 185);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_level = player.GetLevel();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();

			victim.SetProbability((player_level * (skill_level * 0.35f)));
			victim.SetTime(2100.0f);
			victim.SetRatio((skill_t0 * 0.05f + 0.1f));
			victim.SetBuffid(1);
			victim.SetWeak(true);
			victim.SetProbability(-1.0f);
			victim.SetTime(2000.0f);
			victim.SetBuffid(1);
			victim.SetAmount((player_level * (skill_t0 * 0.1f + (skill_level * 0.2f + 0.4f))));
			victim.SetValue(0.0f);
			victim.SetHpleak(true);
			victim.SetProbability(((3 * skill_t0 + 20)));
			victim.SetTime(8100.0f);
			victim.SetRatio(((skill_t0 * 0.5f + 1.0f) * 0.07000000000000001f));
			victim.SetBuffid(3);
			victim.SetTiansha(true);
			return true;
		}
	}
	public class GSkill4475 : GSkill
	{
		public GSkill4475()
			: base(4475)
		{
			
		}
	}
	public class GSkill4476Stub : GSkillStub
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

				skill.SetRatio((D2INT(player_level / (11 - skill_level)) * 0.01f + (skill_level * 0.03f + (skill_t0 * 0.1f + 1.0f))));
				skill.SetPlus((player_def * (skill_t1 * 0.03f) + ((60 * skill_level))));
				player.SetPerform(1);
			}
		}
		public GSkill4476Stub()
			: base(4476)
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
			SetAction(0,"ÌìÒôËÂ_·¨±¦_½ğ¸ÕèÆ");
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
			SetAction(18,"ÌìÒôËÂ_Æï³Ë_·¨±¦_½ğ¸ÕèÆ");
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
			name = "³Ğ¡¤½ğ¸Õ½µÄ§";
			nativename = "³Ğ¡¤½ğ¸Õ½µÄ§";
			icon = "½ğ¸Õ½µÄ§.dds";
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
			int				player_mp = player.GetMp();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();

			victim.SetProbability(((25 * skill_level + 75)));
			victim.SetTime(((1000 * skill_t0 + 2100)));
			victim.SetValue(0.0f);
			victim.SetSleep(true);
			victim.SetProbability(-1.0f);
			victim.SetTime(2000.0f);
			victim.SetBuffid(1);
			victim.SetAmount((player_mp * (skill_t0 * 0.05f + (skill_level * 0.02f + 0.02f))));
			victim.SetValue(0.0f);
			victim.SetMpleak(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();

			victim.SetValue(((16 * skill_level * (skill_t0 + 1))));
			victim.SetJuqi(true);
			return true;
		}
	}
	public class GSkill4476 : GSkill
	{
		public GSkill4476()
			: base(4476)
		{
			
		}
	}
	public class GSkill4477Stub : GSkillStub
	{
		public class GState1 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 1400;
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
				return 600;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_level = player.GetLevel();
				int				player_def = player.GetDef();
				int				skill_level = skill.GetLevel();
				int				skill_t0 = skill.GetT0();
				int				skill_t1 = skill.GetT1();

				skill.SetRatio((D2INT(player_level / (11 - skill_level)) * 0.01f + (skill_level * 0.02f + (skill_t0 * 0.1f + 1.0f))));
				skill.SetPlus((player_def * (skill_t1 * 0.03f) + ((35 * skill_level))));
				player.SetPerform(1);
			}
		}
		public GSkill4477Stub()
			: base(4477)
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
			SetAction(0,"ºÏ»¶ÅÉ_·¨±¦_¶àÇé»·");
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
			SetAction(18,"ºÏ»¶ÅÉ_Æï³Ë_·¨±¦_¶àÇé»·");
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
			name = "³Ğ¡¤É²ÄÇ·¼»ª";
			nativename = "³Ğ¡¤É²ÄÇ·¼»ª";
			icon = "É²ÄÇ·¼»ª.dds";
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

			return ((-15 * skill_level) - skill_level * skill_level + 185);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_level = player.GetLevel();
			int				player_mp = player.GetMp();
			int				player_maxmp = player.GetMaxmp();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();

			victim.SetProbability(((1.0f - player_level * 0.002f) * ((3 * skill_t0 + 40))));
			victim.SetRatio((skill_t0 * 0.09f + 0.24f));
			victim.SetXiaoxin(true);
			victim.SetRatio((norm((player_maxmp * (skill_level * 0.04f + 0.11f)) / (player_mp + 1)) * (skill_level * 0.05f + 0.15f) + 0.0001f));
			victim.SetAmount(0.0f);
			victim.SetValue(0.0f);
			victim.SetSecondattack(true);
			return true;
		}
	}
	public class GSkill4477 : GSkill
	{
		public GSkill4477()
			: base(4477)
		{
			
		}
	}
	public class GSkill4478Stub : GSkillStub
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
				int				player_hp = player.GetHp();
				int				player_mp = player.GetMp();
				int				player_def = player.GetDef();
				int				skill_level = skill.GetLevel();
				int				skill_t0 = skill.GetT0();
				int				skill_t1 = skill.GetT1();

				skill.SetRatio((D2INT(player_level / (11 - skill_level)) * 0.01f + (skill_level * 0.04f + (skill_t0 * 0.1f + 1.0f))));
				skill.SetPlus((player_def * (skill_t1 * 0.03f) + ((skill_t0 * 0.1f + 1.0f) * ((player_mp + player_hp) * 0.02f) + ((31 * skill_level)))));
				player.SetPerform(1);
			}
		}
		public GSkill4478Stub()
			: base(4478)
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
			SetAction(0,"¹íµÀ_·¨±¦_ÆÆÉ²");
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
			SetAction(18,"¹íµÀ_Æï³Ë_·¨±¦_ÆÆÉ²");
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
			name = "³Ğ¡¤¾øìå»ª¹â";
			nativename = "³Ğ¡¤¾øìå»ª¹â";
			icon = "ÔÖĞÇ²øÈÆ.dds";
			SetTalent(0,1174);
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

			return ((-15 * skill_level) - skill_level * skill_level + 225);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_mp = player.GetMp();
			int				skill_level = skill.GetLevel();

			victim.SetProbability(((2 * skill_level)));
			victim.SetTime(6100.0f);
			victim.SetBarehanded(true);
			victim.SetProbability(-1.0f);
			victim.SetTime(100.0f);
			victim.SetBuffid(1);
			victim.SetAmount((player_mp * (skill_level * 0.15f)));
			victim.SetValue(0.0f);
			victim.SetMpleak(true);
			return true;
		}
	}
	public class GSkill4478 : GSkill
	{
		public GSkill4478()
			: base(4478)
		{
			
		}
	}
	public class GSkill4479Stub : GSkillStub
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

				skill.SetRatio((D2INT(player_level / (11 - skill_level)) * 0.01f + (skill_level * 0.03f + 1.0f)));
				skill.SetPlus(((60 * skill_level)));
				player.SetPerform(1);
			}
		}
		public GSkill4479Stub()
			: base(4479)
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
			SetAction(0,"·ÙÏã¹È_·¨±¦_ºâÌì³ß");
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
			SetAction(18,"·ÙÏã¹È_Æï³Ë_·¨±¦_ºâÌì³ß");
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
			name = "³Ğ¡¤ÌìµØĞş¼«";
			nativename = "³Ğ¡¤ÌìµØĞş¼«";
			icon = "ÌìµØĞş¼«.dds";
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
			int				skill_level = skill.GetLevel();

			/*
			victim.SetProbability(((2 * skill_level + 20)));
			victim.SetTime(((1000 * skill_level + 6000)));
			victim.SetRatio(5.0f);
			victim.SetBuffid(3);
			victim.SetAmount(6.0f);
			victim.SetValue((((skill_level << 6) + 198)));
			victim.SetFiring(true);
			if ( player.GetHasmultbuff(113) == 1 )
			v18 = 120.0f;
			else
			victim.SetProbability(0.0f);
			victim.SetValue(((111 * zrand(9) + 111)));
			victim.SetDirecthurt(true);
			*/
			return true;
		}
	}
	public class GSkill4479 : GSkill
	{
		public GSkill4479()
			: base(4479)
		{
			
		}
	}
}
