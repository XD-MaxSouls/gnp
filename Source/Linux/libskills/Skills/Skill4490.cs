using System;
using System.Text;

namespace SKILL
{
	public class GSkill4490Stub : GSkillStub
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

				skill.SetRatio((D2INT(player_level / (10 - skill_level)) * 0.01f + (skill_level * 0.05f + (skill_t0 * 0.1f + 1.0f))));
				skill.SetPlus((player_def * (skill_t1 * 0.03f) + ((skill_t0 * 0.1f + 1.0f) * ((player_mp + player_hp) * 0.03f) + ((135 * skill_level)))));
				player.SetPerform(1);
			}
		}
		public GSkill4490Stub()
			: base(4490)
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
			SetAction(0,"¹íµÀ_·¨±¦_Ç§¶¾¹Æ");
			SetAction(1,"¹íµÀ_·¨±¦_Ç§¶¾¹Æ");
			SetAction(2,"¹íµÀ_·¨±¦_Ç§¶¾¹Æ");
			SetAction(3,"¹íµÀ_·¨±¦_Ç§¶¾¹Æ");
			SetAction(4,"¹íµÀ_·¨±¦_Ç§¶¾¹Æ");
			SetAction(5,"¹íµÀ_·¨±¦_Ç§¶¾¹Æ");
			SetAction(6,"¹íµÀ_·¨±¦_Ç§¶¾¹Æ");
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
			SetAction(18,"¹íµÀ_Æï³Ë_·¨±¦_Ç§¶¾¹Æ");
			SetAction(19,"¹íµÀ_Æï³Ë_·¨±¦_Ç§¶¾¹Æ");
			SetAction(20,"¹íµÀ_Æï³Ë_·¨±¦_Ç§¶¾¹Æ");
			SetAction(21,"¹íµÀ_Æï³Ë_·¨±¦_Ç§¶¾¹Æ");
			SetAction(22,"¹íµÀ_Æï³Ë_·¨±¦_Ç§¶¾¹Æ");
			SetAction(23,"¹íµÀ_Æï³Ë_·¨±¦_Ç§¶¾¹Æ");
			SetAction(24,"¹íµÀ_Æï³Ë_·¨±¦_Ç§¶¾¹Æ");
			SetAction(25,"ÊŞÉñ_Æï³Ë_·¨±¦_î¸á°");
			SetAction(26,"ºüÑı_Æï³Ë_·¨±¦_¸¡Ó°¹Å¾µ");
			SetAction(27,"ĞùÔ¯_Æï³Ë_·¨±¦_ÂäµØ½ğÇ®");
			SetAction(28,"»³¹â_Æï³Ë_·¨±¦_Ì°ÀÇ");
			SetAction(29,"Ì«ê»_Æï³Ë_·¨±¦_×ÓÄ¸ÒõÑô¿Û");
			SetAction(30,"Ìì»ª_Æï³Ë_·¨±¦_ÁğÁ§Õµ");
			name = "³Ğ¡¤ËÀÍö²¨ÎÆ";
			nativename = "³Ğ¡¤ËÀÍö²¨ÎÆ";
			icon = "¹íòâÚ¤Ú¤.dds";
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

			return ((-25 * skill_level) - skill_level * skill_level + 305);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_level = player.GetLevel();
			int				skill_level = skill.GetLevel();

			victim.SetTime(6100.0f);
			victim.SetRatio((skill_level * 0.03f));
			victim.SetBuffid(1);
			victim.SetDecskilldamage(true);
			victim.SetProbability(100.0f);
			victim.SetTime(((3000 * skill_level + 100)));
			victim.SetBuffid(5);
			victim.SetValue((player_level * (skill_level * 0.3f) + 1.0f));
			victim.SetSubdefence(true);
			return true;
		}
	}
	public class GSkill4490 : GSkill
	{
		public GSkill4490()
			: base(4490)
		{
			
		}
	}
	public class GSkill4491Stub : GSkillStub
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

				skill.SetRatio((D2INT(player_level / (10 - skill_level)) * 0.01f + (skill_level * 0.05f + 1.0f)));
				skill.SetPlus(((120 * skill_level)));
				player.SetPerform(1);
			}
		}
		public GSkill4491Stub()
			: base(4491)
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
			SetAction(0,"·ÙÏã¹È_·¨±¦_»ğÁáçç");
			SetAction(1,"·ÙÏã¹È_·¨±¦_»ğÁáçç");
			SetAction(2,"·ÙÏã¹È_·¨±¦_»ğÁáçç");
			SetAction(3,"·ÙÏã¹È_·¨±¦_»ğÁáçç");
			SetAction(4,"·ÙÏã¹È_·¨±¦_»ğÁáçç");
			SetAction(5,"·ÙÏã¹È_·¨±¦_»ğÁáçç");
			SetAction(6,"·ÙÏã¹È_·¨±¦_»ğÁáçç");
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
			SetAction(18,"·ÙÏã¹È_Æï³Ë_·¨±¦_»ğÁáçç");
			SetAction(19,"·ÙÏã¹È_Æï³Ë_·¨±¦_»ğÁáçç");
			SetAction(20,"·ÙÏã¹È_Æï³Ë_·¨±¦_»ğÁáçç");
			SetAction(21,"·ÙÏã¹È_Æï³Ë_·¨±¦_»ğÁáçç");
			SetAction(22,"·ÙÏã¹È_Æï³Ë_·¨±¦_»ğÁáçç");
			SetAction(23,"·ÙÏã¹È_Æï³Ë_·¨±¦_»ğÁáçç");
			SetAction(24,"·ÙÏã¹È_Æï³Ë_·¨±¦_»ğÁáçç");
			SetAction(25,"ÊŞÉñ_Æï³Ë_·¨±¦_î¸á°");
			SetAction(26,"ºüÑı_Æï³Ë_·¨±¦_¸¡Ó°¹Å¾µ");
			SetAction(27,"ĞùÔ¯_Æï³Ë_·¨±¦_ÂäµØ½ğÇ®");
			SetAction(28,"»³¹â_Æï³Ë_·¨±¦_Ì°ÀÇ");
			SetAction(29,"Ì«ê»_Æï³Ë_·¨±¦_×ÓÄ¸ÒõÑô¿Û");
			SetAction(30,"Ìì»ª_Æï³Ë_·¨±¦_ÁğÁ§Õµ");
			name = "³Ğ¡¤Áè»ğÃ÷Ñô";
			nativename = "³Ğ¡¤Áè»ğÃ÷Ñô";
			icon = "Áè»ğÃ÷Ñô.dds";
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

			return ((-25 * skill_level) - skill_level * skill_level + 295);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();

			/*
			victim.SetProbability(((2 * skill_level + 25)));
			victim.SetTime(((1000 * skill_level + 8000)));
			victim.SetRatio(6.0f);
			victim.SetBuffid(4);
			victim.SetAmount(6.0f);
			victim.SetValue(((150 * skill_level + 315)));
			victim.SetFiring(true);
			if ( player.GetHasmultbuff(113) == 1 )
			v31 = (5 * skill_level + 10);
			else
			victim.SetProbability(0.0f);
			victim.SetTime(((1000 * skill_level + 3000)));
			victim.SetBuffid(1);
			victim.SetValue(((25 * skill_level + 40)));
			victim.SetSubdefence(true);
			if ( player.GetHasmultbuff(113) != 1
			|| (v21 = zrand(100), v21 >= 5 * skill_level + 15) )
			v30 = 0.0f;
			else
			victim.SetProbability(150.0f);
			victim.SetTime(((1000 * skill_level + 2000)));
			victim.SetRatio(((5 * skill_level + 15) * 0.01f));
			victim.SetBuffid(1);
			victim.SetSlow(true);
			*/
			return true;
		}
	}
	public class GSkill4491 : GSkill
	{
		public GSkill4491()
			: base(4491)
		{
			
		}
	}
	public class GSkill4492Stub : GSkillStub
	{
		public class GState1 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 1450;
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
				return 550;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_level = player.GetLevel();
				int				skill_level = skill.GetLevel();

				skill.SetCrit((skill_level * 0.01f));
				skill.SetCrithurt((skill_level * (skill_level * 0.01f) + (skill_level * 0.05f)));
				skill.SetRatio((D2INT(player_level / (10 - skill_level)) * 0.01f + (skill_level * 0.05f + 1.0f)));
				skill.SetPlus(((120 * skill_level)));
				player.SetPerform(1);
			}
		}
		public GSkill4492Stub()
			: base(4492)
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
			SetAction(0,"ÊŞÉñ_·¨±¦_î¸á°");
			SetAction(1,"ÇàÔÆÃÅ_·¨±¦_çúçêÖìç±");
			SetAction(2,"¹íÍõ×Ú_·¨±¦_Ç¬À¤Çà¹â½ä");
			SetAction(3,"ºÏ»¶ÅÉ_·¨±¦_Á«»¨");
			SetAction(4,"ÌìÒôËÂ_·¨±¦_ÈçÒâÇ¬À¤´ü");
			SetAction(5,"¹íµÀ_·¨±¦_Ç§¶¾¹Æ");
			SetAction(6,"·ÙÏã¹È_·¨±¦_»ğÁáçç");
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
			SetAction(18,"ÊŞÉñ_Æï³Ë_·¨±¦_î¸á°");
			SetAction(19,"ÇàÔÆÃÅ_Æï³Ë_·¨±¦_çúçêÖìç±");
			SetAction(20,"¹íÍõ×Ú_Æï³Ë_·¨±¦_Ç¬À¤Çà¹â½ä");
			SetAction(21,"ºÏ»¶ÅÉ_Æï³Ë_·¨±¦_Á«»¨");
			SetAction(22,"ÌìÒôËÂ_Æï³Ë_·¨±¦_ÈçÒâÇ¬À¤´ü");
			SetAction(23,"¹íµÀ_Æï³Ë_·¨±¦_Ç§¶¾¹Æ");
			SetAction(24,"·ÙÏã¹È_Æï³Ë_·¨±¦_»ğÁáçç");
			SetAction(25,"ÊŞÉñ_Æï³Ë_·¨±¦_î¸á°");
			SetAction(26,"ºüÑı_Æï³Ë_·¨±¦_¸¡Ó°¹Å¾µ");
			SetAction(27,"ĞùÔ¯_Æï³Ë_·¨±¦_ÂäµØ½ğÇ®");
			SetAction(28,"»³¹â_Æï³Ë_·¨±¦_Ì°ÀÇ");
			SetAction(29,"Ì«ê»_Æï³Ë_·¨±¦_×ÓÄ¸ÒõÑô¿Û");
			SetAction(30,"Ìì»ª_Æï³Ë_·¨±¦_ÁğÁ§Õµ");
			name = "³Ğ¡¤¿ñÀ½ÃğÉ±";
			nativename = "³Ğ¡¤¿ñÀ½ÃğÉ±";
			icon = "¿ñÀ½ÃğÉ±.dds";
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

			return ((-25 * skill_level) - skill_level * skill_level + 295);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();

			victim.SetProbability(((14 * skill_level + 20)));
			victim.SetTime(6100.0f);
			victim.SetBuffid(5);
			victim.SetValue(((44 * skill_level)));
			victim.SetSubdefence(true);
			victim.SetTime(6100.0f);
			victim.SetBuffid(3);
			victim.SetValue(((23 * skill_level)));
			victim.SetSubantiweak(true);
			victim.SetTime(((1000 * skill_level + 3100)));
			victim.SetAmount(((2 * norm(skill_level / 4.9f) + (norm(skill_level / 3.9f) + skill_level))));
			victim.SetValue(((25 * skill_level + 12)));
			victim.SetCursed(true);
			return true;
		}
	}
	public class GSkill4492 : GSkill
	{
		public GSkill4492()
			: base(4492)
		{
			
		}
	}
	public class GSkill4493Stub : GSkillStub
	{
		public class GState1 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 1125;
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
				return 875;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_level = player.GetLevel();
				int				skill_level = skill.GetLevel();

				skill.SetRatio((D2INT(player_level / (10 - skill_level)) * 0.01f + (skill_level * 0.05f + 1.0f)));
				skill.SetPlus(((120 * skill_level)));
				player.SetPerform(1);
			}
		}
		public GSkill4493Stub()
			: base(4493)
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
			SetAction(0,"ºüÑı_·¨±¦_¸¡Ó°¹Å¾µ");
			SetAction(1,"ÇàÔÆÃÅ_·¨±¦_çúçêÖìç±");
			SetAction(2,"¹íÍõ×Ú_·¨±¦_Ç¬À¤Çà¹â½ä");
			SetAction(3,"ºÏ»¶ÅÉ_·¨±¦_Á«»¨");
			SetAction(4,"ÌìÒôËÂ_·¨±¦_ÈçÒâÇ¬À¤´ü");
			SetAction(5,"¹íµÀ_·¨±¦_Ç§¶¾¹Æ");
			SetAction(6,"·ÙÏã¹È_·¨±¦_»ğÁáçç");
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
			SetAction(18,"ºüÑı_Æï³Ë_·¨±¦_¸¡Ó°¹Å¾µ");
			SetAction(19,"ÇàÔÆÃÅ_Æï³Ë_·¨±¦_çúçêÖìç±");
			SetAction(20,"¹íÍõ×Ú_Æï³Ë_·¨±¦_Ç¬À¤Çà¹â½ä");
			SetAction(21,"ºÏ»¶ÅÉ_Æï³Ë_·¨±¦_Á«»¨");
			SetAction(22,"ÌìÒôËÂ_Æï³Ë_·¨±¦_ÈçÒâÇ¬À¤´ü");
			SetAction(23,"¹íµÀ_Æï³Ë_·¨±¦_Ç§¶¾¹Æ");
			SetAction(24,"·ÙÏã¹È_Æï³Ë_·¨±¦_»ğÁáçç");
			SetAction(25,"ÊŞÉñ_Æï³Ë_·¨±¦_î¸á°");
			SetAction(26,"ºüÑı_Æï³Ë_·¨±¦_¸¡Ó°¹Å¾µ");
			SetAction(27,"ĞùÔ¯_Æï³Ë_·¨±¦_ÂäµØ½ğÇ®");
			SetAction(28,"»³¹â_Æï³Ë_·¨±¦_Ì°ÀÇ");
			SetAction(29,"Ì«ê»_Æï³Ë_·¨±¦_×ÓÄ¸ÒõÑô¿Û");
			SetAction(30,"Ìì»ª_Æï³Ë_·¨±¦_ÁğÁ§Õµ");
			name = "³Ğ¡¤¸¡¹âÀ»Ó°";
			nativename = "³Ğ¡¤¸¡¹âÀ»Ó°";
			icon = "¸¡¹âÀ»Ó°.dds";
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

			return ((-25 * skill_level) - skill_level * skill_level + 295);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();

			/*
			victim.SetProbability(((10 * skill_level + 28)));
			victim.SetTime(((30100 - 2000 * skill_level)));
			victim.SetBuffid(4);
			victim.SetAmount(384.0f);
			victim.SetCycsubdefence(true);
			if ( zrand(100) > 6 * skill_level + 12 )
			v27 = 0.0f;
			else
			victim.SetProbability(600.0f);
			victim.SetValue(3.0f);
			victim.SetRepel(true);
			if ( player.GetObjectType() )
			{
			v26 = 0.0f;
			}
			else
			{
			if ( zrand(100) > 6 * skill_level + 12 )
			{
			v25 = 0.0f;
			}
			else
			{
			v25 = (6 * skill_level + (skill_level * skill_level + (2 * (skill_level * skill_level) * skill_level)));
			}
			v26 = v25;
			}
			victim.SetProbability(v26);
			victim.SetTime(((1000 * skill_level + 1100)));
			victim.SetDizzy(true);
			*/
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();

			victim.SetTime(((4000 * skill_level + 12100)));
			victim.SetBuffid(0);
			victim.SetValue(((12 * skill_level)));
			victim.SetAddanti(true);
			return true;
		}
	}
	public class GSkill4493 : GSkill
	{
		public GSkill4493()
			: base(4493)
		{
			
		}
	}
	public class GSkill4494Stub : GSkillStub
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

				skill.SetRatio((D2INT(player_level / (10 - skill_level)) * 0.01f + (skill_level * 0.05f + 1.0f)));
				skill.SetPlus(((120 * skill_level)));
				player.SetPerform(1);
			}
		}
		public GSkill4494Stub()
			: base(4494)
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
			SetAction(0,"»³¹â_·¨±¦_Ì°ÀÇ");
			SetAction(1,"ÇàÔÆÃÅ_·¨±¦_çúçêÖìç±");
			SetAction(2,"¹íÍõ×Ú_·¨±¦_Ç¬À¤Çà¹â½ä");
			SetAction(3,"ºÏ»¶ÅÉ_·¨±¦_Á«»¨");
			SetAction(4,"ÌìÒôËÂ_·¨±¦_ÈçÒâÇ¬À¤´ü");
			SetAction(5,"¹íµÀ_·¨±¦_Ç§¶¾¹Æ");
			SetAction(6,"·ÙÏã¹È_·¨±¦_»ğÁáçç");
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
			SetAction(18,"»³¹â_Æï³Ë_·¨±¦_Ì°ÀÇ");
			SetAction(19,"ÇàÔÆÃÅ_·¨±¦_çúçêÖìç±");
			SetAction(20,"¹íÍõ×Ú_·¨±¦_Ç¬À¤Çà¹â½ä");
			SetAction(21,"ºÏ»¶ÅÉ_·¨±¦_Á«»¨");
			SetAction(22,"ÌìÒôËÂ_·¨±¦_ÈçÒâÇ¬À¤´ü");
			SetAction(23,"¹íµÀ_·¨±¦_Ç§¶¾¹Æ");
			SetAction(24,"·ÙÏã¹È_·¨±¦_»ğÁáçç");
			SetAction(25,"ÊŞÉñ_·¨±¦_î¸á°");
			SetAction(26,"ºüÑı_·¨±¦_¸¡Ó°¹Å¾µ");
			SetAction(27,"ĞùÔ¯_·¨±¦_ÂäµØ½ğÇ®");
			SetAction(28,"»³¹â_Æï³Ë_·¨±¦_Ì°ÀÇ");
			SetAction(29,"Ì«ê»_·¨±¦_×ÓÄ¸ÒõÑô¿Û");
			SetAction(30,"Ìì»ª_·¨±¦_ÁğÁ§Õµ");
			name = "³Ğ¡¤ÆÆ»êÇ§½Ù";
			nativename = "³Ğ¡¤ÆÆ»êÇ§½Ù";
			icon = "ÆÆ»êÇ§½Ù.dds";
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

			return ((-25 * skill_level) - skill_level * skill_level + 295);
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
			int				skill_level = skill.GetLevel();

			victim.SetTime(12000.0f);
			victim.SetBuffid(0);
			victim.SetValue(((20 * skill_level)));
			victim.SetSubantisilent(true);
			victim.SetProbability((((player_res5 + (player_res4 + (player_res3 + (player_res2 + player_res1)))) / 5)));
			victim.SetTime(((1000 * skill_level + 1000)));
			victim.SetSilent(true);
			return true;
		}
	}
	public class GSkill4494 : GSkill
	{
		public GSkill4494()
			: base(4494)
		{
			
		}
	}
	public class GSkill4495Stub : GSkillStub
	{
		public class GState1 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 1225;
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
				int				player_maxatk = player.GetMaxatk();
				int				player_res2 = player.GetRes2();
				int				skill_level = skill.GetLevel();

				player.SetVar1(player_res2);
				player.SetVar2(player_maxatk);
				player.SetVar3(1);
				skill.SetRatio((D2INT(player_level / (10 - skill_level)) * 0.01f + (skill_level * 0.02f + 1.0f)));
				skill.SetPlus(((50 * skill_level)));
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
				int				player_maxatk = player.GetMaxatk();
				int				player_res2 = player.GetRes2();
				int				skill_level = skill.GetLevel();

				player.SetVar1(player_res2);
				player.SetVar2(player_maxatk);
				player.SetVar3(0);
				skill.SetRatio((D2INT(player_level / (10 - skill_level)) * 0.01f + (skill_level * 0.02f + 1.0f)));
				skill.SetPlus(((50 * skill_level)));
				player.SetPerform(0);
			}
		}
		public GSkill4495Stub()
			: base(4495)
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
			SetAction(0,"Ìì»ª_·¨±¦_ÁğÁ§Õµ");
			SetAction(1,"ÇàÔÆÃÅ_·¨±¦_çúçêÖìç±");
			SetAction(2,"¹íÍõ×Ú_·¨±¦_Ç¬À¤Çà¹â½ä");
			SetAction(3,"ºÏ»¶ÅÉ_·¨±¦_Á«»¨");
			SetAction(4,"ÌìÒôËÂ_·¨±¦_ÈçÒâÇ¬À¤´ü");
			SetAction(5,"¹íµÀ_·¨±¦_Ç§¶¾¹Æ");
			SetAction(6,"·ÙÏã¹È_·¨±¦_»ğÁáçç");
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
			SetAction(18,"Ìì»ª_Æï³Ë_·¨±¦_ÁğÁ§Õµ");
			SetAction(19,"ÇàÔÆÃÅ_Æï³Ë_·¨±¦_çúçêÖìç±");
			SetAction(20,"¹íÍõ×Ú_Æï³Ë_·¨±¦_Ç¬À¤Çà¹â½ä");
			SetAction(21,"ºÏ»¶ÅÉ_Æï³Ë_·¨±¦_Á«»¨");
			SetAction(22,"ÌìÒôËÂ_Æï³Ë_·¨±¦_ÈçÒâÇ¬À¤´ü");
			SetAction(23,"¹íµÀ_Æï³Ë_·¨±¦_Ç§¶¾¹Æ");
			SetAction(24,"·ÙÏã¹È_Æï³Ë_·¨±¦_»ğÁáçç");
			SetAction(25,"ÊŞÉñ_Æï³Ë_·¨±¦_î¸á°");
			SetAction(26,"ºüÑı_Æï³Ë_·¨±¦_¸¡Ó°¹Å¾µ");
			SetAction(27,"ĞùÔ¯_Æï³Ë_·¨±¦_ÂäµØ½ğÇ®");
			SetAction(28,"»³¹â_Æï³Ë_·¨±¦_Ì°ÀÇ");
			SetAction(29,"Ì«ê»_Æï³Ë_·¨±¦_×ÓÄ¸ÒõÑô¿Û");
			SetAction(30,"Ìì»ª_Æï³Ë_·¨±¦_ÁğÁ§Õµ");
			name = "³Ğ¡¤Óî¹âÅîÀ³";
			nativename = "³Ğ¡¤Óî¹âÅîÀ³";
			icon = "Óî¹âÅîÀ³.dds";
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
		public override float GetRadius(GSkill skill)
		{
			return 2.000000f/*xxxx*/;
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
			int				player_def = player.GetDef();
			int				player_var1 = player.GetVar1();
			int				player_var2 = player.GetVar2();
			int				player_var3 = player.GetVar3();
			int				skill_level = skill.GetLevel();

			/*
			victim.SetTime(((500 * skill_level + 5000)));
			victim.SetBuffid(1);
			victim.SetValue(((21 * skill_level)));
			victim.SetSubantiweak(true);
			victim.SetProbability(player_var1);
			victim.SetTime(((500 * skill_level + 5000)));
			victim.SetRatio((skill_level * 0.05f + 0.05f));
			victim.SetBuffid(1);
			victim.SetWeak(true);
			v44 = player_var3;
			if ( D2INT(zrand(100)) >= skill_level + 2 )
			v43 = 0.0f;
			else
			victim.SetProbability(((100 * v44)));
			if ( ((50 * skill_level) + ((D2INT(player_level / (10 - skill_level)) * 0.01f + (skill_level * 0.03f + 1.0f)) * player_var2)) <= player_def )
			{
			v42 = 0.0f;
			}
			else
			{
			v42 = ((50 * skill_level) + ((D2INT(player_level / (10 - skill_level)) * 0.01f + (skill_level * 0.03f + 1.0f)) * player_var2)) - player_def;
			}
			victim.SetValue(v42);
			victim.SetDirecthurt(true);
			*/
			return true;
		}
	}
	public class GSkill4495 : GSkill
	{
		public GSkill4495()
			: base(4495)
		{
			
		}
	}
	public class GSkill4496Stub : GSkillStub
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

				skill.SetCrit((skill_level * 0.02f));
				skill.SetRatio((D2INT(player_level / (10 - skill_level)) * 0.01f + (skill_level * 0.05f + 1.0f)));
				skill.SetPlus(((120 * skill_level)));
				player.SetPerform(1);
			}
		}
		public GSkill4496Stub()
			: base(4496)
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
			SetAction(0,"Ì«ê»_·¨±¦_×ÓÄ¸ÒõÑô¿Û");
			SetAction(1,"ÇàÔÆÃÅ_·¨±¦_çúçêÖìç±");
			SetAction(2,"¹íÍõ×Ú_·¨±¦_Ç¬À¤Çà¹â½ä");
			SetAction(3,"ºÏ»¶ÅÉ_·¨±¦_Á«»¨");
			SetAction(4,"ÌìÒôËÂ_·¨±¦_ÈçÒâÇ¬À¤´ü");
			SetAction(5,"¹íµÀ_·¨±¦_Ç§¶¾¹Æ");
			SetAction(6,"·ÙÏã¹È_·¨±¦_»ğÁáçç");
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
			SetAction(18,"Ì«ê»_Æï³Ë_·¨±¦_×ÓÄ¸ÒõÑô¿Û");
			SetAction(19,"ÇàÔÆÃÅ_Æï³Ë_·¨±¦_çúçêÖìç±");
			SetAction(20,"¹íÍõ×Ú_Æï³Ë_·¨±¦_Ç¬À¤Çà¹â½ä");
			SetAction(21,"ºÏ»¶ÅÉ_Æï³Ë_·¨±¦_Á«»¨");
			SetAction(22,"ÌìÒôËÂ_Æï³Ë_·¨±¦_ÈçÒâÇ¬À¤´ü");
			SetAction(23,"¹íµÀ_Æï³Ë_·¨±¦_Ç§¶¾¹Æ");
			SetAction(24,"·ÙÏã¹È_Æï³Ë_·¨±¦_»ğÁáçç");
			SetAction(25,"ÊŞÉñ_Æï³Ë_·¨±¦_î¸á°");
			SetAction(26,"ºüÑı_Æï³Ë_·¨±¦_¸¡Ó°¹Å¾µ");
			SetAction(27,"ĞùÔ¯_Æï³Ë_·¨±¦_ÂäµØ½ğÇ®");
			SetAction(28,"»³¹â_Æï³Ë_·¨±¦_Ì°ÀÇ");
			SetAction(29,"Ì«ê»_Æï³Ë_·¨±¦_×ÓÄ¸ÒõÑô¿Û");
			SetAction(30,"Ìì»ª_Æï³Ë_·¨±¦_ÁğÁ§Õµ");
			name = "³Ğ¡¤×ÓÎçĞÄ»ê";
			nativename = "³Ğ¡¤×ÓÎçĞÄ»ê";
			icon = "×ÓÎçĞÄ»ê.dds";
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

			return ((-25 * skill_level) - skill_level * skill_level + 295);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_res1 = player.GetRes1();
			int				skill_level = skill.GetLevel();

			/*
			v20 = 6 * skill_level + 10;
			if ( skill_level == 5 )
			{
			v19 = (v20 + player_res1);
			}
			else
			{
			v19 = v20;
			}
			victim.SetProbability(v19);
			victim.SetTime(((1000 * skill_level)));
			victim.SetDizzy(true);
			if ( player.GetHasbuff(4096) == 1 )
			v18 = (10 * skill_level + 10);
			else
			victim.SetProbability(0.0f);
			victim.SetTime(((1000 * skill_level + 4000)));
			victim.SetRatio((skill_level * 0.1f));
			victim.SetValue((skill_level * 0.1f));
			victim.SetParalysis(true);
			*/
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();

			victim.SetTime(((4000 * skill_level + 12100)));
			victim.SetBuffid(0);
			victim.SetValue(((12 * skill_level)));
			victim.SetAddanti(true);
			return true;
		}
	}
	public class GSkill4496 : GSkill
	{
		public GSkill4496()
			: base(4496)
		{
			
		}
	}
	public class GSkill4497Stub : GSkillStub
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

				skill.SetRatio((D2INT(player_level / (10 - skill_level)) * 0.01f + (skill_level * 0.05f + 1.0f)));
				skill.SetPlus(((120 * skill_level)));
				player.SetPerform(1);
			}
		}
		public GSkill4497Stub()
			: base(4497)
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
			SetAction(0,"ĞùÔ¯_·¨±¦_ÂäµØ½ğÇ®");
			SetAction(1,"ÇàÔÆÃÅ_·¨±¦_çúçêÖìç±");
			SetAction(2,"¹íÍõ×Ú_·¨±¦_Ç¬À¤Çà¹â½ä");
			SetAction(3,"ºÏ»¶ÅÉ_·¨±¦_Á«»¨");
			SetAction(4,"ÌìÒôËÂ_·¨±¦_ÈçÒâÇ¬À¤´ü");
			SetAction(5,"¹íµÀ_·¨±¦_Ç§¶¾¹Æ");
			SetAction(6,"·ÙÏã¹È_·¨±¦_»ğÁáçç");
			SetAction(7,"ÊŞÉñ_·¨±¦_î¸á°");
			SetAction(8,"ºüÑı_·¨±¦_¸¡Ó°¹Å¾µ");
			SetAction(9,"ĞùÔ¯_·¨±¦_ÂäµØ½ğÇ®");
			SetAction(10,"»³¹â_·¨±¦_Ì°ÀÇ");
			SetAction(11,"Ì«ê»_·¨±¦_×ÓÄ¸ÒõÑô¿Û");
			SetAction(12,"Ìì»ª_·¨±¦_ÁğÁ§Õµ");
			SetAction(13,"1");
			SetAction(14,"1");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"ĞùÔ¯_Æï³Ë_·¨±¦_ÂäµØ½ğÇ®");
			SetAction(19,"ÇàÔÆÃÅ_Æï³Ë_·¨±¦_çúçêÖìç±");
			SetAction(20,"¹íÍõ×Ú_Æï³Ë_·¨±¦_Ç¬À¤Çà¹â½ä");
			SetAction(21,"ºÏ»¶ÅÉ_Æï³Ë_·¨±¦_Á«»¨");
			SetAction(22,"ÌìÒôËÂ_Æï³Ë_·¨±¦_ÈçÒâÇ¬À¤´ü");
			SetAction(23,"¹íµÀ_Æï³Ë_·¨±¦_Ç§¶¾¹Æ");
			SetAction(24,"·ÙÏã¹È_Æï³Ë_·¨±¦_»ğÁáçç");
			SetAction(25,"ÊŞÉñ_Æï³Ë_·¨±¦_î¸á°");
			SetAction(26,"ºüÑı_Æï³Ë_·¨±¦_¸¡Ó°¹Å¾µ");
			SetAction(27,"ĞùÔ¯_Æï³Ë_·¨±¦_ÂäµØ½ğÇ®");
			SetAction(28,"»³¹â_Æï³Ë_·¨±¦_Ì°ÀÇ");
			SetAction(29,"Ì«ê»_Æï³Ë_·¨±¦_×ÓÄ¸ÒõÑô¿Û");
			SetAction(30,"Ìì»ª_Æï³Ë_·¨±¦_ÁğÁ§Õµ");
			name = "³Ğ¡¤Ç¬À¤Ò»ÖÀ";
			nativename = "³Ğ¡¤Ç¬À¤Ò»ÖÀ";
			icon = "Ğ°Ä§ÍËÉ¢.dds";
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

			return ((-25 * skill_level) - skill_level * skill_level + 295);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();

			/*
			victim.SetProbability(((30 * skill_level + 88)));
			victim.SetTime(((2000 * skill_level + 5000)));
			victim.SetRatio(0.15000001f);
			victim.SetBuffid(1);
			victim.SetWeak(true);
			victim.SetProbability(((skill_level + 2)));
			victim.SetTime(((2000 * skill_level + 5000)));
			victim.SetRatio(((5 * skill_level + 5) * 0.01f));
			victim.SetBuffid(1);
			victim.SetDecdefence(true);
			victim.SetProbability(600.0f);
			if ( zrand(100) >= skill_level + 2 )
			t = 0.0f;
			else
			victim.SetTime(5000.0f);
			victim.SetDizzy(true);
			*/
			return true;
		}
	}
	public class GSkill4497 : GSkill
	{
		public GSkill4497()
			: base(4497)
		{
			
		}
	}
	public class GSkill4498Stub : GSkillStub
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
				int				player_occupation = player.GetOccupation();
				int				skill_level = skill.GetLevel();
				int				skill_t0 = skill.GetT0();
				int				skill_t1 = skill.GetT1();
				int				skill_t2 = skill.GetT2();

				player.SetVar11(player_occupation);
				skill.SetCrit((skill_t1 * 0.01f));
				skill.SetRatio(((skill_t0 + 1) * (D2INT((player_mp / 0.95f) / player_maxmp) * 0.16f) + (D2INT(player_level / (9 - skill_level)) * 0.01f + (skill_t0 * 0.08f + (skill_level * 0.06f + 1.0f)))));
				skill.SetPlus((player_def * (skill_t2 * 0.03f) + ((215 * skill_level))));
				player.SetPerform(1);
			}
		}
		public GSkill4498Stub()
			: base(4498)
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
			SetAction(0,"ÇàÔÆÃÅ_·¨±¦_Ç¬À¤Ëø");
			SetAction(1,"ÇàÔÆÃÅ_·¨±¦_Ç¬À¤Ëø");
			SetAction(2,"ÇàÔÆÃÅ_·¨±¦_Ç¬À¤Ëø");
			SetAction(3,"ÇàÔÆÃÅ_·¨±¦_Ç¬À¤Ëø");
			SetAction(4,"ÇàÔÆÃÅ_·¨±¦_Ç¬À¤Ëø");
			SetAction(5,"ÇàÔÆÃÅ_·¨±¦_Ç¬À¤Ëø");
			SetAction(6,"ÇàÔÆÃÅ_·¨±¦_Ç¬À¤Ëø");
			SetAction(7,"ÊŞÉñ_·¨±¦_É¥ÃÅ½£");
			SetAction(8,"ºüÑı_·¨±¦_ÂåÊé");
			SetAction(9,"ĞùÔ¯_·¨±¦_³ĞÓ°");
			SetAction(10,"»³¹â_·¨±¦_¾øÓ°");
			SetAction(11,"Ì«ê»_·¨±¦_ôË»ÊÖÓ");
			SetAction(12,"Ìì»ª_·¨±¦_±ÌÂä·Éºè");
			SetAction(13,"1");
			SetAction(14,"1");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"ÇàÔÆÃÅ_Æï³Ë_·¨±¦_Ç¬À¤Ëø");
			SetAction(19,"ÇàÔÆÃÅ_Æï³Ë_·¨±¦_Ç¬À¤Ëø");
			SetAction(20,"ÇàÔÆÃÅ_Æï³Ë_·¨±¦_Ç¬À¤Ëø");
			SetAction(21,"ÇàÔÆÃÅ_Æï³Ë_·¨±¦_Ç¬À¤Ëø");
			SetAction(22,"ÇàÔÆÃÅ_Æï³Ë_·¨±¦_Ç¬À¤Ëø");
			SetAction(23,"ÇàÔÆÃÅ_Æï³Ë_·¨±¦_Ç¬À¤Ëø");
			SetAction(24,"ÇàÔÆÃÅ_Æï³Ë_·¨±¦_Ç¬À¤Ëø");
			SetAction(25,"ÊŞÉñ_Æï³Ë_·¨±¦_É¥ÃÅ½£");
			SetAction(26,"ºüÑı_Æï³Ë_·¨±¦_ÂåÊé");
			SetAction(27,"ĞùÔ¯_Æï³Ë_·¨±¦_³ĞÓ°");
			SetAction(28,"»³¹â_Æï³Ë_·¨±¦_¾øÓ°");
			SetAction(29,"Ì«ê»_Æï³Ë_·¨±¦_ôË»ÊÖÓ");
			SetAction(30,"Ìì»ª_Æï³Ë_·¨±¦_±ÌÂä·Éºè");
			name = "³Ğ¡¤³¾¹âÌ¾Ãî";
			nativename = "³Ğ¡¤³¾¹âÌ¾Ãî";
			icon = "³¾¹âÌ¾Ãî.dds";
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
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_hp = player.GetHp();
			int				player_maxhp = player.GetMaxhp();
			int				player_mp = player.GetMp();
			int				player_maxmp = player.GetMaxmp();
			int				player_var1 = player.GetVar1();
			int				player_var11 = player.GetVar11();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();

			/*
			victim.SetProbability(((skill_level * skill_level + (3 * skill_t0) + 32)));
			victim.SetTime(((5000 * skill_level + 100)));
			victim.SetRatio((skill_t0 * 0.05f + (skill_level * 0.05f)));
			victim.SetBuffid(1);
			victim.SetDecaccuracy(true);
			if ( skill_level * (player_maxhp * 0.15f) <= player_hp )
			{
			v53 = 0.0f;
			}
			else
			{
			if ( player_var11 == 20 )
			{
			v52 = (skill_level * skill_level + 32);
			}
			else
			{
			v52 = (skill_level * skill_level + 12);
			}
			v53 = v52;
			}
			victim.SetProbability(v53);
			victim.SetTime(((2000 * skill_level + 2100)));
			victim.SetRatio((skill_level * (skill_level * 0.01f) + (skill_t0 * 0.05f + 0.2f)));
			victim.SetValue((skill_level * (skill_level * 0.01f) + (skill_t0 * 0.05f + 0.2f)));
			victim.SetRandcurse(true);
			victim.SetProbability(((skill_level * skill_level + (5 * skill_t0) + 32)));
			victim.SetTime(((2000 * skill_level + 2100)));
			victim.SetBuffid(0);
			victim.SetValue((((norm((player_maxmp * (skill_level * 0.15f)) / (player_mp + 1.0f)) + 1) * ((skill_level * skill_level) * skill_level + (40 * skill_level)))));
			victim.SetSubdefence(true);
			*/
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
	public class GSkill4498 : GSkill
	{
		public GSkill4498()
			: base(4498)
		{
			
		}
	}
	public class GSkill4499Stub : GSkillStub
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
				int				player_occupation = player.GetOccupation();
				int				skill_level = skill.GetLevel();
				int				skill_t0 = skill.GetT0();
				int				skill_t1 = skill.GetT1();

				player.SetVar11(player_occupation);
				skill.SetCrit((skill_level * 0.01f));
				skill.SetCrithurt((skill_level * (skill_level * 0.01f) + (skill_level * 0.1f)));
				skill.SetRatio((D2INT(player_level / (9 - skill_level)) * 0.01f + (skill_level * 0.06f + (skill_t0 * 0.1f + 1.0f))));
				skill.SetPlus((player_def * (skill_t1 * 0.03f) + ((215 * skill_level))));
				player.SetPerform(1);
			}
		}
		public GSkill4499Stub()
			: base(4499)
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
			SetAction(0,"¹íÍõ×Ú_·¨±¦_ÓÄÚ¤¹íÊÖ");
			SetAction(1,"¹íÍõ×Ú_·¨±¦_ÓÄÚ¤¹íÊÖ");
			SetAction(2,"¹íÍõ×Ú_·¨±¦_ÓÄÚ¤¹íÊÖ");
			SetAction(3,"¹íÍõ×Ú_·¨±¦_ÓÄÚ¤¹íÊÖ");
			SetAction(4,"¹íÍõ×Ú_·¨±¦_ÓÄÚ¤¹íÊÖ");
			SetAction(5,"¹íÍõ×Ú_·¨±¦_ÓÄÚ¤¹íÊÖ");
			SetAction(6,"¹íÍõ×Ú_·¨±¦_ÓÄÚ¤¹íÊÖ");
			SetAction(7,"ÊŞÉñ_·¨±¦_É¥ÃÅ½£");
			SetAction(8,"ºüÑı_·¨±¦_ÂåÊé");
			SetAction(9,"ĞùÔ¯_·¨±¦_³ĞÓ°");
			SetAction(10,"»³¹â_·¨±¦_¾øÓ°");
			SetAction(11,"Ì«ê»_·¨±¦_ôË»ÊÖÓ");
			SetAction(12,"Ìì»ª_·¨±¦_±ÌÂä·Éºè");
			SetAction(13,"1");
			SetAction(14,"1");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"¹íÍõ×Ú_Æï³Ë_·¨±¦_ÓÄÚ¤¹íÊÖ");
			SetAction(19,"¹íÍõ×Ú_Æï³Ë_·¨±¦_ÓÄÚ¤¹íÊÖ");
			SetAction(20,"¹íÍõ×Ú_Æï³Ë_·¨±¦_ÓÄÚ¤¹íÊÖ");
			SetAction(21,"¹íÍõ×Ú_Æï³Ë_·¨±¦_ÓÄÚ¤¹íÊÖ");
			SetAction(22,"¹íÍõ×Ú_Æï³Ë_·¨±¦_ÓÄÚ¤¹íÊÖ");
			SetAction(23,"¹íÍõ×Ú_Æï³Ë_·¨±¦_ÓÄÚ¤¹íÊÖ");
			SetAction(24,"¹íÍõ×Ú_Æï³Ë_·¨±¦_ÓÄÚ¤¹íÊÖ");
			SetAction(25,"ÊŞÉñ_Æï³Ë_·¨±¦_É¥ÃÅ½£");
			SetAction(26,"ºüÑı_Æï³Ë_·¨±¦_ÂåÊé");
			SetAction(27,"ĞùÔ¯_Æï³Ë_·¨±¦_³ĞÓ°");
			SetAction(28,"»³¹â_Æï³Ë_·¨±¦_¾øÓ°");
			SetAction(29,"Ì«ê»_Æï³Ë_·¨±¦_ôË»ÊÖÓ");
			SetAction(30,"Ìì»ª_Æï³Ë_·¨±¦_±ÌÂä·Éºè");
			name = "³Ğ¡¤¹íÓòÓÄ¸è";
			nativename = "³Ğ¡¤¹íÓòÓÄ¸è";
			icon = "¹íÓòÓÄ¸è.dds";
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
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_var1 = player.GetVar1();
			int				player_var11 = player.GetVar11();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();

			/*
			victim.SetTime(((4000 * skill_level + 4100)));
			victim.SetBuffid(0);
			victim.SetValue(((skill_level * skill_level + (12 * (skill_t0 + skill_level)))));
			victim.SetSubantidizzy(true);
			victim.SetTime(((4000 * skill_level + 4100)));
			victim.SetBuffid(0);
			victim.SetValue(((skill_level * skill_level + (12 * (skill_t0 + skill_level)))));
			victim.SetSubantiweak(true);
			victim.SetProbability(((3 * skill_t0 + 30)));
			victim.SetTime(12100.0f);
			victim.SetRatio(((skill_t0 * 0.5f + 1.0f) * 0.11f));
			victim.SetBuffid(3);
			victim.SetTiansha(true);
			if ( player_var11 == 14 )
			{
			v35 = (skill_level * skill_level + 5);
			}
			else
			{
			v35 = (skill_level * skill_level + 1);
			}
			victim.SetProbability(v35);
			victim.SetAmount(2.0f);
			victim.SetClearbuff(true);
			*/
			return true;
		}
	}
	public class GSkill4499 : GSkill
	{
		public GSkill4499()
			: base(4499)
		{
			
		}
	}
}
