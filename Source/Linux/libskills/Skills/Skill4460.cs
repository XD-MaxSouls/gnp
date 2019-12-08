using System;
using System.Text;

namespace SKILL
{
	public class GSkill4460Stub : GSkillStub
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
				int				skill_t0 = skill.GetT0();

				skill.SetRatio((D2INT(player_level / (13 - skill_level)) * 0.01f + (skill_level * 0.01f + (skill_t0 * 0.03f + 1.0f))));
				skill.SetPlus(((3 * skill_level)));
				player.SetPerform(1);
			}
		}
		public GSkill4460Stub()
			: base(4460)
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
			SetAction(0,"¹íµÀ_·¨±¦_°ËØÔÉñÕÆ");
			SetAction(1,"ÇàÔÆÃÅ_·¨±¦_°ËØÔÉñÕÆ");
			SetAction(2,"¹íÍõ×Ú_·¨±¦_°ËØÔÉñÕÆ");
			SetAction(3,"ºÏ»¶ÅÉ_·¨±¦_°ËØÔÉñÕÆ");
			SetAction(4,"ÌìÒôËÂ_·¨±¦_°ËØÔÉñÕÆ");
			SetAction(5,"¹íµÀ_·¨±¦_°ËØÔÉñÕÆ");
			SetAction(6,"·ÙÏã¹È_·¨±¦_°ËØÔÉñÕÆ");
			SetAction(7,"ÊŞÉñ_·¨±¦_ÎåÉ«Ê¯");
			SetAction(8,"ºüÑı_·¨±¦_ÎåÉ«Ê¯");
			SetAction(9,"ĞùÔ¯_·¨±¦_ÎåÉ«Ê¯");
			SetAction(10,"»³¹â_·¨±¦_ÎåÉ«Ê¯");
			SetAction(11,"ÊŞÉñ_·¨±¦_ÎåÉ«Ê¯");
			SetAction(12,"Ìì»ª_·¨±¦_ÎåÉ«Ê¯");
			SetAction(13,"01");
			SetAction(14,"01");
			SetAction(15,"0");
			SetAction(16,"0");
			SetAction(17,"ÌìÒôËÂ_·¨±¦_°ËØÔÉñÕÆ");
			SetAction(18,"¹íµÀ_Æï³Ë_·¨±¦_°ËØÔÉñÕÆ");
			SetAction(19,"ÇàÔÆÃÅ_Æï³Ë_·¨±¦_°ËØÔÉñÕÆ");
			SetAction(20,"¹íÍõ×Ú_Æï³Ë_·¨±¦_°ËØÔÉñÕÆ");
			SetAction(21,"ºÏ»¶ÅÉ_Æï³Ë_·¨±¦_°ËØÔÉñÕÆ");
			SetAction(22,"ÌìÒôËÂ_Æï³Ë_·¨±¦_°ËØÔÉñÕÆ");
			SetAction(23,"¹íµÀ_Æï³Ë_·¨±¦_°ËØÔÉñÕÆ");
			SetAction(24,"·ÙÏã¹È_Æï³Ë_·¨±¦_°ËØÔÉñÕÆ");
			SetAction(25,"ÊŞÉñ_Æï³Ë_·¨±¦_ÎåÉ«Ê¯");
			SetAction(26,"ºüÑı_Æï³Ë_·¨±¦_ÎåÉ«Ê¯");
			SetAction(27,"ĞùÔ¯_Æï³Ë_·¨±¦_ÎåÉ«Ê¯");
			SetAction(28,"»³¹â_Æï³Ë_·¨±¦_ÎåÉ«Ê¯");
			SetAction(29,"ÊŞÉñ_Æï³Ë_·¨±¦_ÎåÉ«Ê¯");
			SetAction(30,"Ìì»ª_Æï³Ë_·¨±¦_ÎåÉ«Ê¯");
			name = "³Ğ¡¤°ËØÔÉñÕÆ";
			nativename = "³Ğ¡¤°ËØÔÉñÕÆ";
			icon = "°ËØÔÉñÕÆ.dds";
			SetTalent(0,687);
			SetTalent(1,0);
			SetTalent(2,0);
			SetTalent(3,0);
			SetTalent(4,0);
			SetTalent(5,0);
			SetTalent(6,0);
			SetTalent(7,0);
			talent_size = 1;
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

			return (13 - skill_level);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_level = player.GetLevel();
			int				skill_level = skill.GetLevel();

			victim.SetProbability(((1.0f - player_level * 0.002f) * 100.0f));
			victim.SetTime(2000.0f);
			victim.SetBuffid(1);
			victim.SetAmount(((10 * skill_level)));
			victim.SetValue(0.0f);
			victim.SetHpleak(true);
			return true;
		}
	}
	public class GSkill4460 : GSkill
	{
		public GSkill4460()
			: base(4460)
		{
			
		}
	}
	public class GSkill4461Stub : GSkillStub
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

				skill.SetRatio((D2INT(player_level / (12 - skill_level)) * 0.01f + (skill_level * 0.01f + 1.0f)));
				skill.SetPlus(((10 * skill_level)));
				player.SetPerform(1);
			}
		}
		public GSkill4461Stub()
			: base(4461)
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
			SetAction(0,"¹íµÀ_·¨±¦_°ËØÔÉñÕÆ");
			SetAction(1,"¹íµÀ_·¨±¦_°ËØÔÉñÕÆ");
			SetAction(2,"¹íµÀ_·¨±¦_°ËØÔÉñÕÆ");
			SetAction(3,"¹íµÀ_·¨±¦_°ËØÔÉñÕÆ");
			SetAction(4,"¹íµÀ_·¨±¦_°ËØÔÉñÕÆ");
			SetAction(5,"¹íµÀ_·¨±¦_°ËØÔÉñÕÆ");
			SetAction(6,"¹íµÀ_·¨±¦_°ËØÔÉñÕÆ");
			SetAction(7,"ÊŞÉñ_·¨±¦_ÎåÉ«Ê¯");
			SetAction(8,"ºüÑı_·¨±¦_ÎåÉ«Ê¯");
			SetAction(9,"ĞùÔ¯_·¨±¦_ÎåÉ«Ê¯");
			SetAction(10,"»³¹â_·¨±¦_ÎåÉ«Ê¯");
			SetAction(11,"ÊŞÉñ_·¨±¦_ÎåÉ«Ê¯");
			SetAction(12,"Ìì»ª_·¨±¦_ÎåÉ«Ê¯");
			SetAction(13,"01");
			SetAction(14,"01");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"¹íµÀ_Æï³Ë_·¨±¦_°ËØÔÉñÕÆ");
			SetAction(19,"¹íµÀ_Æï³Ë_·¨±¦_°ËØÔÉñÕÆ");
			SetAction(20,"¹íµÀ_Æï³Ë_·¨±¦_°ËØÔÉñÕÆ");
			SetAction(21,"¹íµÀ_Æï³Ë_·¨±¦_°ËØÔÉñÕÆ");
			SetAction(22,"¹íµÀ_Æï³Ë_·¨±¦_°ËØÔÉñÕÆ");
			SetAction(23,"¹íµÀ_Æï³Ë_·¨±¦_°ËØÔÉñÕÆ");
			SetAction(24,"¹íµÀ_Æï³Ë_·¨±¦_°ËØÔÉñÕÆ");
			SetAction(25,"ÊŞÉñ_Æï³Ë_·¨±¦_ÎåÉ«Ê¯");
			SetAction(26,"ºüÑı_Æï³Ë_·¨±¦_ÎåÉ«Ê¯");
			SetAction(27,"ĞùÔ¯_Æï³Ë_·¨±¦_ÎåÉ«Ê¯");
			SetAction(28,"»³¹â_Æï³Ë_·¨±¦_ÎåÉ«Ê¯");
			SetAction(29,"ÊŞÉñ_Æï³Ë_·¨±¦_ÎåÉ«Ê¯");
			SetAction(30,"Ìì»ª_Æï³Ë_·¨±¦_ÎåÉ«Ê¯");
			name = "³Ğ¡¤Íò²Ê»­Ò»";
			nativename = "³Ğ¡¤Íò²Ê»­Ò»";
			icon = "Íò²Ê»­Ò».dds";
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

			return (32 - 2 * skill_level);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();

			victim.SetProbability(((4 * skill_level + 20)));
			victim.SetTime(((30100 - 2000 * skill_level)));
			victim.SetBuffid(4);
			victim.SetAmount(128.0f);
			victim.SetCycsubdefence(true);
			victim.SetTime(((2000 * skill_level + 1100)));
			victim.SetAmount(((2 * norm(skill_level / 4.9f) + (norm(skill_level / 3.9f) + skill_level))));
			victim.SetValue(((4 * skill_level)));
			victim.SetCursed(true);
			return true;
		}
	}
	public class GSkill4461 : GSkill
	{
		public GSkill4461()
			: base(4461)
		{
			
		}
	}
	public class GSkill4462Stub : GSkillStub
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
				int				skill_level = skill.GetLevel();
				int				skill_t0 = skill.GetT0();
				int				skill_t1 = skill.GetT1();

				skill.SetCrit((skill_t1 * 0.02f));
				skill.SetRatio(((skill_t0 + 1) * (D2INT((player_mp / 0.95f) / player_maxmp) * 0.04f) + (D2INT(player_level / (12 - skill_level)) * 0.01f + (skill_level * 0.03f + (skill_t0 * 0.08f + 1.0f)))));
				skill.SetPlus(((30 * skill_level)));
				player.SetPerform(1);
			}
		}
		public GSkill4462Stub()
			: base(4462)
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
			doenchant = false;
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
			SetAction(0,"ÇàÔÆÃÅ_·¨±¦_ÁùºÏ¾µ");
			SetAction(1,"ÇàÔÆÃÅ_·¨±¦_ÁùºÏ¾µ");
			SetAction(2,"ÇàÔÆÃÅ_·¨±¦_ÁùºÏ¾µ");
			SetAction(3,"ÇàÔÆÃÅ_·¨±¦_ÁùºÏ¾µ");
			SetAction(4,"ÇàÔÆÃÅ_·¨±¦_ÁùºÏ¾µ");
			SetAction(5,"ÇàÔÆÃÅ_·¨±¦_ÁùºÏ¾µ");
			SetAction(6,"ÇàÔÆÃÅ_·¨±¦_ÁùºÏ¾µ");
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
			SetAction(18,"ÇàÔÆÃÅ_Æï³Ë_·¨±¦_ÁùºÏ¾µ");
			SetAction(19,"ÇàÔÆÃÅ_Æï³Ë_·¨±¦_ÁùºÏ¾µ");
			SetAction(20,"ÇàÔÆÃÅ_Æï³Ë_·¨±¦_ÁùºÏ¾µ");
			SetAction(21,"ÇàÔÆÃÅ_Æï³Ë_·¨±¦_ÁùºÏ¾µ");
			SetAction(22,"ÇàÔÆÃÅ_Æï³Ë_·¨±¦_ÁùºÏ¾µ");
			SetAction(23,"ÇàÔÆÃÅ_Æï³Ë_·¨±¦_ÁùºÏ¾µ");
			SetAction(24,"ÇàÔÆÃÅ_Æï³Ë_·¨±¦_ÁùºÏ¾µ");
			SetAction(25,"ÊŞÉñ_Æï³Ë_·¨±¦_Å­ÊŞá¦");
			SetAction(26,"ºüÑı_Æï³Ë_·¨±¦_µ¤Öì");
			SetAction(27,"ĞùÔ¯_Æï³Ë_·¨±¦_ÂÊ¶µÆì");
			SetAction(28,"»³¹â_Æï³Ë_·¨±¦_ÆßÉ±");
			SetAction(29,"Ì«ê»_Æï³Ë_·¨±¦_À×¹«Ä«");
			SetAction(30,"Ìì»ª_Æï³Ë_·¨±¦_¾ÅÒôÂİ");
			name = "³Ğ¡¤ÁùºÏ×İºá";
			nativename = "³Ğ¡¤ÁùºÏ×İºá";
			icon = "ÁùºÏ×İºá.dds";
			SetTalent(0,568);
			SetTalent(1,599);
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

			return (63 - 3 * skill_level);
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
	public class GSkill4462 : GSkill
	{
		public GSkill4462()
			: base(4462)
		{
			
		}
	}
	public class GSkill4463Stub : GSkillStub
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
				int				skill_t0 = skill.GetT0();

				skill.SetRatio((D2INT(player_level / (12 - skill_level)) * 0.01f + (skill_t0 * 0.1f + (skill_level * 0.02f + 1.0f))));
				skill.SetPlus(((10 * skill_level)));
				player.SetPerform(1);
			}
		}
		public GSkill4463Stub()
			: base(4463)
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
			SetAction(0,"¹íÍõ×Ú_·¨±¦_ÖìÈ¸Ó¡");
			SetAction(1,"¹íÍõ×Ú_·¨±¦_ÖìÈ¸Ó¡");
			SetAction(2,"¹íÍõ×Ú_·¨±¦_ÖìÈ¸Ó¡");
			SetAction(3,"¹íÍõ×Ú_·¨±¦_ÖìÈ¸Ó¡");
			SetAction(4,"¹íÍõ×Ú_·¨±¦_ÖìÈ¸Ó¡");
			SetAction(5,"¹íÍõ×Ú_·¨±¦_ÖìÈ¸Ó¡");
			SetAction(6,"¹íÍõ×Ú_·¨±¦_ÖìÈ¸Ó¡");
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
			SetAction(18,"¹íÍõ×Ú_Æï³Ë_·¨±¦_ÖìÈ¸Ó¡");
			SetAction(19,"¹íÍõ×Ú_Æï³Ë_·¨±¦_ÖìÈ¸Ó¡");
			SetAction(20,"¹íÍõ×Ú_Æï³Ë_·¨±¦_ÖìÈ¸Ó¡");
			SetAction(21,"¹íÍõ×Ú_Æï³Ë_·¨±¦_ÖìÈ¸Ó¡");
			SetAction(22,"¹íÍõ×Ú_Æï³Ë_·¨±¦_ÖìÈ¸Ó¡");
			SetAction(23,"¹íÍõ×Ú_Æï³Ë_·¨±¦_ÖìÈ¸Ó¡");
			SetAction(24,"¹íÍõ×Ú_Æï³Ë_·¨±¦_ÖìÈ¸Ó¡");
			SetAction(25,"ÊŞÉñ_Æï³Ë_·¨±¦_Å­ÊŞá¦");
			SetAction(26,"ºüÑı_Æï³Ë_·¨±¦_µ¤Öì");
			SetAction(27,"ĞùÔ¯_Æï³Ë_·¨±¦_ÂÊ¶µÆì");
			SetAction(28,"»³¹â_Æï³Ë_·¨±¦_ÆßÉ±");
			SetAction(29,"Ì«ê»_Æï³Ë_·¨±¦_À×¹«Ä«");
			SetAction(30,"Ìì»ª_Æï³Ë_·¨±¦_¾ÅÒôÂİ");
			name = "³Ğ¡¤ÁÒÑæÑªÓğ";
			nativename = "³Ğ¡¤ÁÒÑæÑªÓğ";
			icon = "ÁÒÑæÑªÓğ.dds";
			SetTalent(0,652);
			SetTalent(1,0);
			SetTalent(2,0);
			SetTalent(3,0);
			SetTalent(4,0);
			SetTalent(5,0);
			SetTalent(6,0);
			SetTalent(7,0);
			talent_size = 1;
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

			return (32 - 2 * skill_level);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_t0 = skill.GetT0();

			victim.SetProbability(((3 * skill_t0 + 15)));
			victim.SetTime(6100.0f);
			victim.SetRatio(((skill_t0 * 0.5f + 1.0f) * 0.05f));
			victim.SetBuffid(3);
			victim.SetTiansha(true);
			return true;
		}
	}
	public class GSkill4463 : GSkill
	{
		public GSkill4463()
			: base(4463)
		{
			
		}
	}
	public class GSkill4464Stub : GSkillStub
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
				int				skill_t0 = skill.GetT0();

				skill.SetRatio((D2INT(player_level / (12 - skill_level)) * 0.01f + (skill_t0 * 0.1f + (skill_level * 0.02f + 1.0f))));
				skill.SetPlus(((15 * skill_level)));
				player.SetPerform(1);
			}
		}
		public GSkill4464Stub()
			: base(4464)
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
			doenchant = false;
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
			SetAction(0,"ÌìÒôËÂ_·¨±¦_ÂÖ»ØÖé");
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
			SetAction(18,"ÌìÒôËÂ_Æï³Ë_·¨±¦_ÂÖ»ØÖé");
			SetAction(19,"ÌìÒôËÂ_Æï³Ë_·¨±¦_ÂÖ»ØÖé");
			SetAction(20,"ÌìÒôËÂ_Æï³Ë_·¨±¦_ÂÖ»ØÖé");
			SetAction(21,"ÌìÒôËÂ_Æï³Ë_·¨±¦_ÂÖ»ØÖé");
			SetAction(22,"ÌìÒôËÂ_Æï³Ë_·¨±¦_ÂÖ»ØÖé");
			SetAction(23,"ÌìÒôËÂ_Æï³Ë_·¨±¦_ÂÖ»ØÖé");
			SetAction(24,"ÌìÒôËÂ_Æï³Ë_·¨±¦_ÂÖ»ØÖé");
			SetAction(25,"ÊŞÉñ_·¨±¦_Å­ÊŞá¦");
			SetAction(26,"ºüÑı_·¨±¦_µ¤Öì");
			SetAction(27,"ĞùÔ¯_·¨±¦_ÂÊ¶µÆì");
			SetAction(28,"»³¹â_·¨±¦_ÆßÉ±");
			SetAction(29,"Ì«ê»_·¨±¦_À×¹«Ä«");
			SetAction(30,"Ìì»ª_·¨±¦_¾ÅÒôÂİ");
			name = "³Ğ¡¤·¨º£ÂÖ»Ø";
			nativename = "³Ğ¡¤·¨º£ÂÖ»Ø";
			icon = "·¨º£ÂÖ»Ø.dds";
			SetTalent(0,670);
			SetTalent(1,0);
			SetTalent(2,0);
			SetTalent(3,0);
			SetTalent(4,0);
			SetTalent(5,0);
			SetTalent(6,0);
			SetTalent(7,0);
			talent_size = 1;
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
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();

			victim.SetValue(((8 * skill_level * (skill_t0 + 1))));
			victim.SetJuqi(true);
			return true;
		}
	}
	public class GSkill4464 : GSkill
	{
		public GSkill4464()
			: base(4464)
		{
			
		}
	}
	public class GSkill4465Stub : GSkillStub
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
				int				skill_t0 = skill.GetT0();

				skill.SetRatio((D2INT(player_level / (12 - skill_level)) * 0.01f + (skill_t0 * 0.1f + (skill_level * 0.02f + 1.0f))));
				skill.SetPlus(((15 * skill_level)));
				player.SetPerform(1);
			}
		}
		public GSkill4465Stub()
			: base(4465)
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
			SetAction(0,"ºÏ»¶ÅÉ_·¨±¦_ÉãĞÄÁå");
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
			SetAction(18,"ºÏ»¶ÅÉ_Æï³Ë_·¨±¦_ÉåĞÄÁå");
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
			name = "³Ğ¡¤Éã»ê¶áÆÇ";
			nativename = "³Ğ¡¤Éã»ê¶áÆÇ";
			icon = "Éã»ê¶áÆÇ.dds";
			SetTalent(0,721);
			SetTalent(1,0);
			SetTalent(2,0);
			SetTalent(3,0);
			SetTalent(4,0);
			SetTalent(5,0);
			SetTalent(6,0);
			SetTalent(7,0);
			talent_size = 1;
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

			return (32 - 2 * skill_level);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_level = player.GetLevel();
			int				skill_t0 = skill.GetT0();

			victim.SetProbability(((1.0f - player_level * 0.002f) * ((3 * skill_t0 + 30))));
			victim.SetRatio((skill_t0 * 0.09f + 0.12f));
			victim.SetXiaoxin(true);
			return true;
		}
	}
	public class GSkill4465 : GSkill
	{
		public GSkill4465()
			: base(4465)
		{
			
		}
	}
	public class GSkill4466Stub : GSkillStub
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
				int				skill_level = skill.GetLevel();
				int				skill_t0 = skill.GetT0();

				skill.SetRatio((D2INT(player_level / (12 - skill_level)) * 0.01f + (skill_level * 0.02f + (skill_t0 * 0.1f + 1.0f))));
				skill.SetPlus(((skill_t0 * 0.1f + 1.0f) * ((player_mp + player_hp) * 0.01f) + ((17 * skill_level))));
				player.SetPerform(1);
			}
		}
		public GSkill4466Stub()
			: base(4466)
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
			doenchant = false;
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
			SetAction(0,"¹íµÀ_·¨±¦_ÑªÓñ¹ÇÆ¬");
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
			SetAction(18,"¹íµÀ_Æï³Ë_·¨±¦_ÑªÓñ¹ÇÆ¬");
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
			name = "³Ğ¡¤ËéÓñ»ÃÌì";
			nativename = "³Ğ¡¤ËéÓñ»ÃÌì";
			icon = "Ç§ÓğÀ×¹â.dds";
			SetTalent(0,1174);
			SetTalent(1,0);
			SetTalent(2,0);
			SetTalent(3,0);
			SetTalent(4,0);
			SetTalent(5,0);
			SetTalent(6,0);
			SetTalent(7,0);
			talent_size = 1;
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

			return (46 - 4 * skill_level);
		}
	}
	public class GSkill4466 : GSkill
	{
		public GSkill4466()
			: base(4466)
		{
			
		}
	}
	public class GSkill4467Stub : GSkillStub
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
				int				player_res3 = player.GetRes3();
				int				skill_level = skill.GetLevel();

				player.SetVar1(player_res3);
				skill.SetRatio((D2INT(player_level / (12 - skill_level)) * 0.01f + (skill_level * 0.02f + 1.0f)));
				skill.SetPlus(((15 * skill_level)));
				player.SetPerform(1);
			}
		}
		public GSkill4467Stub()
			: base(4467)
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
			SetAction(0,"·ÙÏã¹È_·¨±¦_ÄÏÃ÷Ó¡");
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
			SetAction(18,"·ÙÏã¹È_Æï³Ë_·¨±¦_ÄÏÃ÷Ó¡");
			SetAction(19,"·ÙÏã¹È_Æï³Ë_·¨±¦_ÄÏÃ÷Ó¡");
			SetAction(20,"·ÙÏã¹È_Æï³Ë_·¨±¦_ÄÏÃ÷Ó¡");
			SetAction(21,"·ÙÏã¹È_Æï³Ë_·¨±¦_ÄÏÃ÷Ó¡");
			SetAction(22,"·ÙÏã¹È_Æï³Ë_·¨±¦_ÄÏÃ÷Ó¡");
			SetAction(23,"·ÙÏã¹È_Æï³Ë_·¨±¦_ÄÏÃ÷Ó¡");
			SetAction(24,"·ÙÏã¹È_Æï³Ë_·¨±¦_ÄÏÃ÷Ó¡");
			SetAction(25,"ÊŞÉñ_Æï³Ë_·¨±¦_Å­ÊŞá¦");
			SetAction(26,"ºüÑı_Æï³Ë_·¨±¦_µ¤Öì");
			SetAction(27,"ĞùÔ¯_Æï³Ë_·¨±¦_ÂÊ¶µÆì");
			SetAction(28,"»³¹â_Æï³Ë_·¨±¦_ÆßÉ±");
			SetAction(29,"Ì«ê»_Æï³Ë_·¨±¦_À×¹«Ä«");
			SetAction(30,"Ìì»ª_Æï³Ë_·¨±¦_¾ÅÒôÂİ");
			name = "³Ğ¡¤Òµ»ğÌìÑô";
			nativename = "³Ğ¡¤Òµ»ğÌìÑô";
			icon = "Òµ»ğÌìÑô.dds";
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
			int				player_var1 = player.GetVar1();
			int				skill_level = skill.GetLevel();

			/*
			victim.SetProbability(((2 * skill_level + 10)));
			victim.SetTime(((1000 * skill_level + 4000)));
			victim.SetRatio(4.0f);
			victim.SetBuffid(1);
			victim.SetAmount(5.0f);
			victim.SetValue(((34 * skill_level + 69)));
			victim.SetFiring(true);
			if ( player.GetHasmultbuff(113) != 1
			|| (v13 = zrand(100), v13 >= 6 * skill_level + 24) )
			{
			v21 = 0.0f;
			}
			else
			{
			v21 = (6 * skill_level + player_var1);
			}
			victim.SetProbability(v21);
			victim.SetTime(((1000 * skill_level + 2000)));
			victim.SetWrap(true);
			*/
			return true;
		}
	}
	public class GSkill4467 : GSkill
	{
		public GSkill4467()
			: base(4467)
		{
			
		}
	}
	public class GSkill4468Stub : GSkillStub
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
				skill.SetPlus(((10 * skill_level)));
				player.SetPerform(1);
			}
		}
		public GSkill4468Stub()
			: base(4468)
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
			SetAction(0,"ÊŞÉñ_·¨±¦_Å­ÊŞá¦");
			SetAction(1,"ÇàÔÆÃÅ_·¨±¦_ÁùºÏ¾µ");
			SetAction(2,"ÇàÔÆÃÅ_·¨±¦_ÁùºÏ¾µ");
			SetAction(3,"ÇàÔÆÃÅ_·¨±¦_ÁùºÏ¾µ");
			SetAction(4,"ÇàÔÆÃÅ_·¨±¦_ÁùºÏ¾µ");
			SetAction(5,"ÇàÔÆÃÅ_·¨±¦_ÁùºÏ¾µ");
			SetAction(6,"ÇàÔÆÃÅ_·¨±¦_ÁùºÏ¾µ");
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
			SetAction(18,"ÊŞÉñ_Æï³Ë_·¨±¦_Å­ÊŞá¦");
			SetAction(19,"ÇàÔÆÃÅ_Æï³Ë_·¨±¦_ÁùºÏ¾µ");
			SetAction(20,"ÇàÔÆÃÅ_Æï³Ë_·¨±¦_ÁùºÏ¾µ");
			SetAction(21,"ÇàÔÆÃÅ_Æï³Ë_·¨±¦_ÁùºÏ¾µ");
			SetAction(22,"ÇàÔÆÃÅ_Æï³Ë_·¨±¦_ÁùºÏ¾µ");
			SetAction(23,"ÇàÔÆÃÅ_Æï³Ë_·¨±¦_ÁùºÏ¾µ");
			SetAction(24,"ÇàÔÆÃÅ_Æï³Ë_·¨±¦_ÁùºÏ¾µ");
			SetAction(25,"ÊŞÉñ_Æï³Ë_·¨±¦_Å­ÊŞá¦");
			SetAction(26,"ºüÑı_Æï³Ë_·¨±¦_µ¤Öì");
			SetAction(27,"ĞùÔ¯_Æï³Ë_·¨±¦_ÂÊ¶µÆì");
			SetAction(28,"»³¹â_Æï³Ë_·¨±¦_ÆßÉ±");
			SetAction(29,"Ì«ê»_Æï³Ë_·¨±¦_À×¹«Ä«");
			SetAction(30,"Ìì»ª_Æï³Ë_·¨±¦_¾ÅÒôÂİ");
			name = "³Ğ¡¤Çı»¢Öğ±ª";
			nativename = "³Ğ¡¤Çı»¢Öğ±ª";
			icon = "Çı»¢Öğ±ª.dds";
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
			int				player_level = player.GetLevel();
			int				skill_level = skill.GetLevel();

			victim.SetProbability((player_level * 2.2f));
			victim.SetTime(4100.0f);
			victim.SetRatio(0.1f);
			victim.SetBuffid(3);
			victim.SetWeak(true);
			victim.SetTime(((2000 * skill_level + 1100)));
			victim.SetAmount(((2 * norm(skill_level / 4.9f) + (norm(skill_level / 3.9f) + skill_level))));
			victim.SetValue(((6 * skill_level + 4)));
			victim.SetCursed(true);
			return true;
		}
	}
	public class GSkill4468 : GSkill
	{
		public GSkill4468()
			: base(4468)
		{
			
		}
	}
	public class GSkill4469Stub : GSkillStub
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

				skill.SetRatio((D2INT(player_level / (12 - skill_level)) * 0.01f + (skill_level * 0.02f + 1.0f)));
				skill.SetPlus(((15 * skill_level)));
				player.SetPerform(1);
			}
		}
		public GSkill4469Stub()
			: base(4469)
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
			SetAction(0,"ºüÑı_·¨±¦_µ¤Öì");
			SetAction(1,"¹íÍõ×Ú_·¨±¦_ÖìÈ¸Ó¡");
			SetAction(2,"¹íÍõ×Ú_·¨±¦_ÖìÈ¸Ó¡");
			SetAction(3,"¹íÍõ×Ú_·¨±¦_ÖìÈ¸Ó¡");
			SetAction(4,"¹íÍõ×Ú_·¨±¦_ÖìÈ¸Ó¡");
			SetAction(5,"¹íÍõ×Ú_·¨±¦_ÖìÈ¸Ó¡");
			SetAction(6,"¹íÍõ×Ú_·¨±¦_ÖìÈ¸Ó¡");
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
			SetAction(18,"ºüÑı_Æï³Ë_·¨±¦_µ¤Öì");
			SetAction(19,"¹íÍõ×Ú_Æï³Ë_·¨±¦_ÖìÈ¸Ó¡");
			SetAction(20,"¹íÍõ×Ú_Æï³Ë_·¨±¦_ÖìÈ¸Ó¡");
			SetAction(21,"¹íÍõ×Ú_Æï³Ë_·¨±¦_ÖìÈ¸Ó¡");
			SetAction(22,"¹íÍõ×Ú_Æï³Ë_·¨±¦_ÖìÈ¸Ó¡");
			SetAction(23,"¹íÍõ×Ú_Æï³Ë_·¨±¦_ÖìÈ¸Ó¡");
			SetAction(24,"¹íÍõ×Ú_Æï³Ë_·¨±¦_ÖìÈ¸Ó¡");
			SetAction(25,"ÊŞÉñ_Æï³Ë_·¨±¦_Å­ÊŞá¦");
			SetAction(26,"ºüÑı_Æï³Ë_·¨±¦_µ¤Öì");
			SetAction(27,"ĞùÔ¯_Æï³Ë_·¨±¦_ÂÊ¶µÆì");
			SetAction(28,"»³¹â_Æï³Ë_·¨±¦_ÆßÉ±");
			SetAction(29,"Ì«ê»_Æï³Ë_·¨±¦_À×¹«Ä«");
			SetAction(30,"Ìì»ª_Æï³Ë_·¨±¦_¾ÅÒôÂİ");
			name = "³Ğ¡¤ÔÂÓ°µ¤Öì";
			nativename = "³Ğ¡¤ÔÂÓ°µ¤Öì";
			icon = "ÔÂÓ°µ¤Öì.dds";
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

			victim.SetProbability(((6 * skill_level + 24)));
			victim.SetTime(((30100 - 2000 * skill_level)));
			victim.SetBuffid(4);
			victim.SetAmount(192.0f);
			victim.SetCycsubdefence(true);
			victim.SetProbability(120.0f);
			victim.SetTime(((1000 * skill_level + 4100)));
			victim.SetBuffid(2);
			victim.SetValue(((10 * skill_level)));
			victim.SetSubanti(true);
			return true;
		}
	}
	public class GSkill4469 : GSkill
	{
		public GSkill4469()
			: base(4469)
		{
			
		}
	}
}
