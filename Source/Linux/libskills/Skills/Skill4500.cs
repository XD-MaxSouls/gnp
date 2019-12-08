using System;
using System.Text;

namespace SKILL
{
	public class GSkill4500Stub : GSkillStub
	{
		public class GState1 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 1500;
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
				int				player_level = player.GetLevel();
				int				player_def = player.GetDef();
				int				player_occupation = player.GetOccupation();
				int				skill_level = skill.GetLevel();
				int				skill_t0 = skill.GetT0();
				int				skill_t1 = skill.GetT1();

				player.SetVar11(player_occupation);
				skill.SetRatio((D2INT(player_level / (9 - skill_level)) * 0.01f + (skill_level * 0.06f + (skill_t0 * 0.1f + 1.0f))));
				skill.SetPlus((player_def * (skill_t1 * 0.03f) + ((215 * skill_level))));
				player.SetPerform(1);
			}
		}
		public GSkill4500Stub()
			: base(4500)
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
			SetAction(0,"ÌìÒôËÂ_·¨±¦_ÂÖ»ØÅÌ");
			SetAction(1,"ÌìÒôËÂ_·¨±¦_ÂÖ»ØÅÌ");
			SetAction(2,"ÌìÒôËÂ_·¨±¦_ÂÖ»ØÅÌ");
			SetAction(3,"ÌìÒôËÂ_·¨±¦_ÂÖ»ØÅÌ");
			SetAction(4,"ÌìÒôËÂ_·¨±¦_ÂÖ»ØÅÌ");
			SetAction(5,"ÌìÒôËÂ_·¨±¦_ÂÖ»ØÅÌ");
			SetAction(6,"ÌìÒôËÂ_·¨±¦_ÂÖ»ØÅÌ");
			SetAction(7,"ÊÞÉñ_·¨±¦_É¥ÃÅ½£");
			SetAction(8,"ºüÑý_·¨±¦_ÂåÊé");
			SetAction(9,"ÐùÔ¯_·¨±¦_³ÐÓ°");
			SetAction(10,"»³¹â_·¨±¦_¾øÓ°");
			SetAction(11,"Ì«ê»_·¨±¦_ôË»ÊÖÓ");
			SetAction(12,"Ìì»ª_·¨±¦_±ÌÂä·Éºè");
			SetAction(13,"1");
			SetAction(14,"1");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"ÌìÒôËÂ_Æï³Ë_·¨±¦_ÂÖ»ØÅÌ");
			SetAction(19,"ÌìÒôËÂ_Æï³Ë_·¨±¦_ÂÖ»ØÅÌ");
			SetAction(20,"ÌìÒôËÂ_Æï³Ë_·¨±¦_ÂÖ»ØÅÌ");
			SetAction(21,"ÌìÒôËÂ_Æï³Ë_·¨±¦_ÂÖ»ØÅÌ");
			SetAction(22,"ÌìÒôËÂ_Æï³Ë_·¨±¦_ÂÖ»ØÅÌ");
			SetAction(23,"ÌìÒôËÂ_Æï³Ë_·¨±¦_ÂÖ»ØÅÌ");
			SetAction(24,"ÌìÒôËÂ_Æï³Ë_·¨±¦_ÂÖ»ØÅÌ");
			SetAction(25,"ÊÞÉñ_Æï³Ë_·¨±¦_É¥ÃÅ½£");
			SetAction(26,"ºüÑý_Æï³Ë_·¨±¦_ÂåÊé");
			SetAction(27,"ÐùÔ¯_Æï³Ë_·¨±¦_³ÐÓ°");
			SetAction(28,"»³¹â_Æï³Ë_·¨±¦_¾øÓ°");
			SetAction(29,"Ì«ê»_Æï³Ë_·¨±¦_ôË»ÊÖÓ");
			SetAction(30,"Ìì»ª_Æï³Ë_·¨±¦_±ÌÂä·Éºè");
			name = "³Ð¡¤¼ÅÃðÌìÎè";
			nativename = "³Ð¡¤¼ÅÃðÌìÎè";
			icon = "¼ÅÃðÌìÎè.dds";
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
			int				player_level = player.GetLevel();
			int				player_var1 = player.GetVar1();
			int				player_var11 = player.GetVar11();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();

			/*
			if ( player_var11 == 23 )
			d = 100.0f;
			else
			victim.SetProbability(23.0f);
			victim.SetTime(((4000 * skill_level + 4100)));
			victim.SetBuffid(1);
			victim.SetValue((((skill_level * skill_level) * skill_level + (5 * skill_t0 + (9 * skill_level)))));
			victim.SetSubanti(true);
			victim.SetProbability(100.0f);
			victim.SetTime(100.0f);
			victim.SetBuffid(0);
			victim.SetAmount((((player_level * (skill_level * skill_level + (3 * skill_level))) * norm(((5 * skill_level + 125) / player_level)))));
			victim.SetValue(0.0f);
			victim.SetHpleak(true);
			victim.SetProbability(((5 * skill_level + 15)));
			victim.SetTime(((3000 * skill_level + 3100)));
			victim.SetRatio((skill_level * 0.05f + (skill_t0 * 0.05f + 0.25f)));
			victim.SetBuffid(0);
			victim.SetSlow(true);
			*/
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();

			victim.SetValue(((32 * skill_level * (skill_t0 + 1))));
			victim.SetJuqi(true);
			return true;
		}
	}
	public class GSkill4500 : GSkill
	{
		public GSkill4500()
			: base(4500)
		{
			
		}
	}
	public class GSkill4501Stub : GSkillStub
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
				skill.SetRatio((D2INT(player_level / (9 - skill_level)) * 0.01f + (skill_level * 0.06f + (skill_t0 * 0.1f + 1.0f))));
				skill.SetPlus((player_def * (skill_t1 * 0.03f) + ((215 * skill_level))));
				player.SetPerform(1);
			}
		}
		public GSkill4501Stub()
			: base(4501)
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
			SetAction(0,"ºÏ»¶ÅÉ_·¨±¦_³à½ðç±");
			SetAction(1,"ºÏ»¶ÅÉ_·¨±¦_³à½ðç±");
			SetAction(2,"ºÏ»¶ÅÉ_·¨±¦_³à½ðç±");
			SetAction(3,"ºÏ»¶ÅÉ_·¨±¦_³à½ðç±");
			SetAction(4,"ºÏ»¶ÅÉ_·¨±¦_³à½ðç±");
			SetAction(5,"ºÏ»¶ÅÉ_·¨±¦_³à½ðç±");
			SetAction(6,"ºÏ»¶ÅÉ_·¨±¦_³à½ðç±");
			SetAction(7,"ÊÞÉñ_·¨±¦_É¥ÃÅ½£");
			SetAction(8,"ºüÑý_·¨±¦_ÂåÊé");
			SetAction(9,"ÐùÔ¯_·¨±¦_³ÐÓ°");
			SetAction(10,"»³¹â_·¨±¦_¾øÓ°");
			SetAction(11,"Ì«ê»_·¨±¦_ôË»ÊÖÓ");
			SetAction(12,"Ìì»ª_·¨±¦_±ÌÂä·Éºè");
			SetAction(13,"1");
			SetAction(14,"1");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"ºÏ»¶ÅÉ_Æï³Ë_·¨±¦_³à½ðç±");
			SetAction(19,"ºÏ»¶ÅÉ_Æï³Ë_·¨±¦_³à½ðç±");
			SetAction(20,"ºÏ»¶ÅÉ_Æï³Ë_·¨±¦_³à½ðç±");
			SetAction(21,"ºÏ»¶ÅÉ_Æï³Ë_·¨±¦_³à½ðç±");
			SetAction(22,"ºÏ»¶ÅÉ_Æï³Ë_·¨±¦_³à½ðç±");
			SetAction(23,"ºÏ»¶ÅÉ_Æï³Ë_·¨±¦_³à½ðç±");
			SetAction(24,"ºÏ»¶ÅÉ_Æï³Ë_·¨±¦_³à½ðç±");
			SetAction(25,"ÊÞÉñ_Æï³Ë_·¨±¦_É¥ÃÅ½£");
			SetAction(26,"ºüÑý_Æï³Ë_·¨±¦_ÂåÊé");
			SetAction(27,"ÐùÔ¯_Æï³Ë_·¨±¦_³ÐÓ°");
			SetAction(28,"»³¹â_Æï³Ë_·¨±¦_¾øÓ°");
			SetAction(29,"Ì«ê»_Æï³Ë_·¨±¦_ôË»ÊÖÓ");
			SetAction(30,"Ìì»ª_Æï³Ë_·¨±¦_±ÌÂä·Éºè");
			name = "³Ð¡¤ÃÎÁîÖ®À½";
			nativename = "³Ð¡¤ÃÎÁîÖ®À½";
			icon = "ÃÎÁîÖ®À½.dds";
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
			int				player_level = player.GetLevel();
			int				player_var1 = player.GetVar1();
			int				player_var11 = player.GetVar11();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();

			/*
			victim.SetProbability(((1.0f - player_level * 0.002f) * 60.0f));
			victim.SetRatio((skill_t0 * 0.1f + 0.48f));
			victim.SetDrainmagic(true);
			victim.SetProbability(((1.0f - player_level * 0.002f) * 100.0f));
			victim.SetTime(100.0f);
			victim.SetBuffid(0);
			victim.SetAmount(((250 * skill_t0 + (zrand(50 * skill_level * skill_level + (250 * skill_level))) + 1)));
			victim.SetValue(0.0f);
			victim.SetHpleak(true);
			if ( player_var11 == 17 )
			v41 = 33.0f;
			else
			victim.SetProbability(25.0f);
			victim.SetTime(((6000 * skill_level + 100)));
			victim.SetBuffid(1);
			victim.SetAmount((((-500 * skill_level) - 500 * skill_t0 + 5500)));
			victim.SetValue(((300 * skill_level + 300)));
			victim.SetSubmp(true);
			victim.SetProbability(((1.0f - player_level * 0.002f) * ((2 * skill_t0 + (5 * skill_level) + 35))));
			victim.SetTime(((4000 * skill_level + 4100)));
			victim.SetBarehanded(true);
			*/
			return true;
		}
	}
	public class GSkill4501 : GSkill
	{
		public GSkill4501()
			: base(4501)
		{
			
		}
	}
	public class GSkill4502Stub : GSkillStub
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
				int				player_occupation = player.GetOccupation();
				int				skill_level = skill.GetLevel();
				int				skill_t0 = skill.GetT0();
				int				skill_t1 = skill.GetT1();

				player.SetVar11(player_occupation);
				skill.SetRatio((D2INT(player_level / (9 - skill_level)) * 0.01f + (skill_level * 0.06f + (skill_t0 * 0.1f + 1.0f))));
				skill.SetPlus((player_def * (skill_t1 * 0.03f) + ((skill_t0 * 0.1f + 1.0f) * ((player_hp + player_mp) * 0.04f) + ((215 * skill_level)))));
				player.SetPerform(1);
			}
		}
		public GSkill4502Stub()
			: base(4502)
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
			SetAction(0,"¹íµÀ_·¨±¦_¹ííà");
			SetAction(1,"¹íµÀ_·¨±¦_¹ííà");
			SetAction(2,"¹íµÀ_·¨±¦_¹ííà");
			SetAction(3,"¹íµÀ_·¨±¦_¹ííà");
			SetAction(4,"¹íµÀ_·¨±¦_¹ííà");
			SetAction(5,"¹íµÀ_·¨±¦_¹ííà");
			SetAction(6,"¹íµÀ_·¨±¦_¹ííà");
			SetAction(7,"ÊÞÉñ_·¨±¦_É¥ÃÅ½£");
			SetAction(8,"ºüÑý_·¨±¦_ÂåÊé");
			SetAction(9,"ÐùÔ¯_·¨±¦_³ÐÓ°");
			SetAction(10,"»³¹â_·¨±¦_¾øÓ°");
			SetAction(11,"Ì«ê»_·¨±¦_ôË»ÊÖÓ");
			SetAction(12,"Ìì»ª_·¨±¦_±ÌÂä·Éºè");
			SetAction(13,"1");
			SetAction(14,"1");
			SetAction(15,"0");
			SetAction(16,"0");
			SetAction(17,"1");
			SetAction(18,"¹íµÀ_Æï³Ë_·¨±¦_¹ííà");
			SetAction(19,"¹íµÀ_Æï³Ë_·¨±¦_¹ííà");
			SetAction(20,"¹íµÀ_Æï³Ë_·¨±¦_¹ííà");
			SetAction(21,"¹íµÀ_Æï³Ë_·¨±¦_¹ííà");
			SetAction(22,"¹íµÀ_Æï³Ë_·¨±¦_¹ííà");
			SetAction(23,"¹íµÀ_Æï³Ë_·¨±¦_¹ííà");
			SetAction(24,"¹íµÀ_Æï³Ë_·¨±¦_¹ííà");
			SetAction(25,"ÊÞÉñ_Æï³Ë_·¨±¦_É¥ÃÅ½£");
			SetAction(26,"ºüÑý_Æï³Ë_·¨±¦_ÂåÊé");
			SetAction(27,"ÐùÔ¯_Æï³Ë_·¨±¦_³ÐÓ°");
			SetAction(28,"»³¹â_Æï³Ë_·¨±¦_¾øÓ°");
			SetAction(29,"Ì«ê»_Æï³Ë_·¨±¦_ôË»ÊÖÓ");
			SetAction(30,"Ìì»ª_Æï³Ë_·¨±¦_±ÌÂä·Éºè");
			name = "³Ð¡¤ÃÔ×ÙÖ®¼Å";
			nativename = "³Ð¡¤ÃÔ×ÙÖ®¼Å";
			icon = "öïÅôÕñ³á.dds";
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

			return ((-35 * skill_level) - skill_level * skill_level + 495);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_level = player.GetLevel();
			int				player_hp = player.GetHp();
			int				player_maxmp = player.GetMaxmp();
			int				player_var1 = player.GetVar1();
			int				player_var11 = player.GetVar11();
			int				skill_level = skill.GetLevel();

			/*
			victim.SetProbability(((600 * norm((zrand(100) / 95)))));
			victim.SetTime(((5000 * skill_level + 100)));
			victim.SetWrap(true);
			victim.SetProbability(100.0f);
			victim.SetTime(((4000 * skill_level + 100)));
			victim.SetBuffid(0);
			victim.SetAmount((player_maxmp * 0.2f + 1.0f));
			victim.SetValue(((100 * skill_level * skill_level + (500 * skill_level))));
			victim.SetSubmp(true);
			if ( player_var11 == 29 )
			{
			v38 = (1.0f - player_level * 0.002f) * 100.0f;
			}
			else
			{
			v38 = 23.0f;
			}
			victim.SetProbability(v38);
			victim.SetTime(((1000 * D2INT(((player_level / 2) / skill_level)) + 2000)));
			victim.SetBuffid(0);
			victim.SetAmount((player_hp * ((5 * (skill_level * skill_level + skill_level) + 10) * 0.01f)));
			victim.SetValue(0.0f);
			victim.SetHpleak(true);
			*/
			return true;
		}
	}
	public class GSkill4502 : GSkill
	{
		public GSkill4502()
			: base(4502)
		{
			
		}
	}
	public class GSkill4503Stub : GSkillStub
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
				int				player_occupation = player.GetOccupation();
				int				skill_level = skill.GetLevel();

				/*
				player.SetVar11(player_occupation);
				if ( zrand(100) >= skill_level * skill_level )
				    v = 2;
				  else
				    v = 1;
				player.SetVar1(v);
				skill.SetRatio((D2INT(player_level / (9 - skill_level)) * 0.01f + (skill_level * 0.07000000000000001f + 1.0f)));
				skill.SetPlus(((215 * skill_level)));
				player.SetPerform(1);
				*/
			}
		}
		public GSkill4503Stub()
			: base(4503)
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
			SetAction(0,"·ÙÏã¹È_·¨±¦_¾Åº®Äý±ù´Ì");
			SetAction(1,"·ÙÏã¹È_·¨±¦_¾Åº®Äý±ù´Ì");
			SetAction(2,"·ÙÏã¹È_·¨±¦_¾Åº®Äý±ù´Ì");
			SetAction(3,"·ÙÏã¹È_·¨±¦_¾Åº®Äý±ù´Ì");
			SetAction(4,"·ÙÏã¹È_·¨±¦_¾Åº®Äý±ù´Ì");
			SetAction(5,"·ÙÏã¹È_·¨±¦_¾Åº®Äý±ù´Ì");
			SetAction(6,"·ÙÏã¹È_·¨±¦_¾Åº®Äý±ù´Ì");
			SetAction(7,"ÊÞÉñ_·¨±¦_É¥ÃÅ½£");
			SetAction(8,"ºüÑý_·¨±¦_ÂåÊé");
			SetAction(9,"ÐùÔ¯_·¨±¦_³ÐÓ°");
			SetAction(10,"»³¹â_·¨±¦_¾øÓ°");
			SetAction(11,"Ì«ê»_·¨±¦_ôË»ÊÖÓ");
			SetAction(12,"Ìì»ª_·¨±¦_±ÌÂä·Éºè");
			SetAction(13,"1");
			SetAction(14,"1");
			SetAction(15,"0");
			SetAction(16,"0");
			SetAction(17,"1");
			SetAction(18,"·ÙÏã¹È_Æï³Ë_·¨±¦_¾Åº®Äý±ù´Ì");
			SetAction(19,"·ÙÏã¹È_Æï³Ë_·¨±¦_¾Åº®Äý±ù´Ì");
			SetAction(20,"·ÙÏã¹È_Æï³Ë_·¨±¦_¾Åº®Äý±ù´Ì");
			SetAction(21,"·ÙÏã¹È_Æï³Ë_·¨±¦_¾Åº®Äý±ù´Ì");
			SetAction(22,"·ÙÏã¹È_Æï³Ë_·¨±¦_¾Åº®Äý±ù´Ì");
			SetAction(23,"·ÙÏã¹È_Æï³Ë_·¨±¦_¾Åº®Äý±ù´Ì");
			SetAction(24,"·ÙÏã¹È_Æï³Ë_·¨±¦_¾Åº®Äý±ù´Ì");
			SetAction(25,"ÊÞÉñ_Æï³Ë_·¨±¦_É¥ÃÅ½£");
			SetAction(26,"ºüÑý_Æï³Ë_·¨±¦_ÂåÊé");
			SetAction(27,"ÐùÔ¯_Æï³Ë_·¨±¦_³ÐÓ°");
			SetAction(28,"»³¹â_Æï³Ë_·¨±¦_¾øÓ°");
			SetAction(29,"Ì«ê»_Æï³Ë_·¨±¦_ôË»ÊÖÓ");
			SetAction(30,"Ìì»ª_Æï³Ë_·¨±¦_±ÌÂä·Éºè");
			name = "³Ð¡¤Ì«ÓÄÐþ±ù";
			nativename = "³Ð¡¤Ì«ÓÄÐþ±ù";
			icon = "Ì«ÓÄÒõ»ð.dds";
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

			return ((-35 * skill_level) - skill_level * skill_level + 445);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_var1 = player.GetVar1();
			int				player_var11 = player.GetVar11();
			int				skill_level = skill.GetLevel();

			/*
			victim.SetTime(12000.0f);
			victim.SetAmount(10.0f);
			victim.SetValue(((18 * skill_level + 12)));
			victim.SetCursed(true);
			victim.SetProbability(120.0f);
			victim.SetTime(12000.0f);
			if ( player_var11 == 68 )
			{
			d = (10 * player_var1 + skill_level);
			}
			else
			{
			d = (10 * player_var1 + skill_level);
			}
			victim.SetRatio(d);
			victim.SetBuffid(1);
			victim.SetValue(3336.0f);
			victim.SetDelaycast(true);
			*/
			return true;
		}
	}
	public class GSkill4503 : GSkill
	{
		public GSkill4503()
			: base(4503)
		{
			
		}
	}
	public class GSkill4504Stub : GSkillStub
	{
		public class GState1 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 1700;
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
				int				player_level = player.GetLevel();
				int				player_occupation = player.GetOccupation();
				int				skill_level = skill.GetLevel();

				player.SetVar11(player_occupation);
				skill.SetRatio((D2INT(player_level / (9 - skill_level)) * 0.01f + 1.0f));
				skill.SetPlus(((145 * skill_level)));
				player.SetPerform(1);
			}
		}
		public class GState3 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 275;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_level = player.GetLevel();
				int				player_occupation = player.GetOccupation();
				int				skill_level = skill.GetLevel();

				player.SetVar11(player_occupation);
				skill.SetRatio((D2INT(player_level / (9 - skill_level)) * 0.01f + 1.0f));
				skill.SetPlus(((145 * skill_level)));
				player.SetPerform(0);
			}
		}
		public class GState4 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 325;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_level = player.GetLevel();
				int				player_occupation = player.GetOccupation();
				int				skill_level = skill.GetLevel();

				player.SetVar11(player_occupation);
				player.SetVar1(1);
				skill.SetCrit((D2INT(skill_level / 4.9f) * 0.03f + (skill_level * 0.02f)));
				skill.SetCrithurt((skill_level * (skill_level * 0.01f) + (skill_level * 0.1f)));
				skill.SetRatio((D2INT(player_level / (9 - skill_level)) * 0.01f + (skill_level * 0.06f + 1.0f)));
				skill.SetPlus(((145 * skill_level)));
				player.SetPerform(0);
			}
		}
		public GSkill4504Stub()
			: base(4504)
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
			SetAction(0,"ÊÞÉñ_·¨±¦_É¥ÃÅ½£");
			SetAction(1,"ÇàÔÆÃÅ_·¨±¦_Ç¬À¤Ëø");
			SetAction(2,"¹íÍõ×Ú_·¨±¦_ÓÄÚ¤¹íÊÖ");
			SetAction(3,"ÌìÒôËÂ_·¨±¦_ÂÖ»ØÅÌ");
			SetAction(4,"ºÏ»¶ÅÉ_·¨±¦_³à½ðç±");
			SetAction(5,"¹íµÀ_·¨±¦_¹ííà");
			SetAction(6,"·ÙÏã¹È_·¨±¦_¾Åº®Äý±ù´Ì");
			SetAction(7,"ÊÞÉñ_·¨±¦_É¥ÃÅ½£");
			SetAction(8,"ºüÑý_·¨±¦_ÂåÊé");
			SetAction(9,"ÐùÔ¯_·¨±¦_³ÐÓ°");
			SetAction(10,"»³¹â_·¨±¦_¾øÓ°");
			SetAction(11,"Ì«ê»_·¨±¦_ôË»ÊÖÓ");
			SetAction(12,"Ìì»ª_·¨±¦_±ÌÂä·Éºè");
			SetAction(13,"1");
			SetAction(14,"1");
			SetAction(15,"0");
			SetAction(16,"0");
			SetAction(17,"1");
			SetAction(18,"ÊÞÉñ_Æï³Ë_·¨±¦_É¥ÃÅ½£");
			SetAction(19,"ÇàÔÆÃÅ_Æï³Ë_·¨±¦_Ç¬À¤Ëø");
			SetAction(20,"¹íÍõ×Ú_Æï³Ë_·¨±¦_ÓÄÚ¤¹íÊÖ");
			SetAction(21,"ÌìÒôËÂ_Æï³Ë_·¨±¦_ÂÖ»ØÅÌ");
			SetAction(22,"ºÏ»¶ÅÉ_Æï³Ë_·¨±¦_³à½ðç±");
			SetAction(23,"¹íµÀ_Æï³Ë_·¨±¦_¹ííà");
			SetAction(24,"·ÙÏã¹È_Æï³Ë_·¨±¦_¾Åº®Äý±ù´Ì");
			SetAction(25,"ÊÞÉñ_Æï³Ë_·¨±¦_É¥ÃÅ½£");
			SetAction(26,"ºüÑý_Æï³Ë_·¨±¦_ÂåÊé");
			SetAction(27,"ÐùÔ¯_Æï³Ë_·¨±¦_³ÐÓ°");
			SetAction(28,"»³¹â_Æï³Ë_·¨±¦_¾øÓ°");
			SetAction(29,"Ì«ê»_Æï³Ë_·¨±¦_ôË»ÊÖÓ");
			SetAction(30,"Ìì»ª_Æï³Ë_·¨±¦_±ÌÂä·Éºè");
			name = "³Ð¡¤Íö»êÉ¥ÆÇ";
			nativename = "³Ð¡¤Íö»êÉ¥ÆÇ";
			icon = "Íö»êÉ¥ÆÇ.dds";
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
			return 2500;
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

			return ((-35 * skill_level) - skill_level * skill_level + 745);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_var1 = player.GetVar1();
			int				skill_level = skill.GetLevel();

			/*
			if ( player_var1 == 1 )
			{
			d = (600 * norm((skill_level + zrand(25)) / 25));
			}
			else
			{
			d = 0.0f;
			}
			victim.SetProbability(d);
			victim.SetTime(8100.0f);
			victim.SetRatio(0.5f);
			victim.SetBuffid(4);
			victim.SetSlow(true);
			victim.SetTime(((5000 * norm(skill_level / 4.9f) + (2000 * skill_level) + 100)));
			victim.SetAmount(((norm(skill_level / 3.9f) + (2 * (skill_level + (2 * norm(skill_level / 4.9f)))))));
			victim.SetValue(((36 * (norm(skill_level / 4.9f) + skill_level) + 48)));
			victim.SetCursed(true);
			*/
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_var1 = player.GetVar1();
			int				player_var11 = player.GetVar11();
			int				skill_level = skill.GetLevel();

			/*
			victim.SetRatio(1853.0f);
			victim.SetAmount(0.0f);
			victim.SetValue(0.0f);
			victim.SetClearcooldown(true);
			if ( player_var1 == 1 )
			{
			if ( player_var11 == 37 )
			v16 = 25.0f;
			else
			d = 20.0f;
			}
			else
			{
			d = 0.0f;
			}
			victim.SetProbability(d);
			victim.SetTime(((1000 * skill_level + 3100)));
			victim.SetBuffid(3);
			victim.SetValue((skill_level * 0.5f + 2.0f));
			victim.SetAddspeed(true);
			*/
			return true;
		}
	}
	public class GSkill4504 : GSkill
	{
		public GSkill4504()
			: base(4504)
		{
			
		}
	}
	public class GSkill4505Stub : GSkillStub
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
				int				player_occupation = player.GetOccupation();
				int				skill_level = skill.GetLevel();

				player.SetVar11(player_occupation);
				skill.SetRatio((D2INT(player_level / (9 - skill_level)) * 0.01f + (skill_level * 0.07000000000000001f + 1.0f)));
				skill.SetPlus(((215 * skill_level)));
				player.SetPerform(1);
			}
		}
		public GSkill4505Stub()
			: base(4505)
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
			SetAction(0,"ºüÑý_·¨±¦_ÂåÊé");
			SetAction(1,"ÇàÔÆÃÅ_·¨±¦_Ç¬À¤Ëø");
			SetAction(2,"¹íÍõ×Ú_·¨±¦_ÓÄÚ¤¹íÊÖ");
			SetAction(3,"ºÏ»¶ÅÉ_·¨±¦_³à½ðç±");
			SetAction(4,"ÌìÒôËÂ_·¨±¦_ÂÖ»ØÅÌ");
			SetAction(5,"¹íµÀ_·¨±¦_¹ííà");
			SetAction(6,"·ÙÏã¹È_·¨±¦_¾Åº®Äý±ù´Ì");
			SetAction(7,"ÊÞÉñ_·¨±¦_É¥ÃÅ½£");
			SetAction(8,"ºüÑý_·¨±¦_ÂåÊé");
			SetAction(9,"ÐùÔ¯_·¨±¦_³ÐÓ°");
			SetAction(10,"»³¹â_·¨±¦_¾øÓ°");
			SetAction(11,"Ì«ê»_·¨±¦_ôË»ÊÖÓ");
			SetAction(12,"Ìì»ª_·¨±¦_±ÌÂä·Éºè");
			SetAction(13,"1");
			SetAction(14,"1");
			SetAction(15,"1");
			SetAction(16,"1");
			SetAction(17,"1");
			SetAction(18,"ºüÑý_Æï³Ë_·¨±¦_ÂåÊé");
			SetAction(19,"ÇàÔÆÃÅ_Æï³Ë_·¨±¦_Ç¬À¤Ëø");
			SetAction(20,"¹íÍõ×Ú_Æï³Ë_·¨±¦_ÓÄÚ¤¹íÊÖ");
			SetAction(21,"ºÏ»¶ÅÉ_Æï³Ë_·¨±¦_³à½ðç±");
			SetAction(22,"ÌìÒôËÂ_Æï³Ë_·¨±¦_ÂÖ»ØÅÌ");
			SetAction(23,"¹íµÀ_Æï³Ë_·¨±¦_¹ííà");
			SetAction(24,"·ÙÏã¹È_Æï³Ë_·¨±¦_¾Åº®Äý±ù´Ì");
			SetAction(25,"ÊÞÉñ_Æï³Ë_·¨±¦_É¥ÃÅ½£");
			SetAction(26,"ºüÑý_Æï³Ë_·¨±¦_ÂåÊé");
			SetAction(27,"ÐùÔ¯_Æï³Ë_·¨±¦_³ÐÓ°");
			SetAction(28,"»³¹â_Æï³Ë_·¨±¦_¾øÓ°");
			SetAction(29,"Ì«ê»_Æï³Ë_·¨±¦_ôË»ÊÖÓ");
			SetAction(30,"Ìì»ª_Æï³Ë_·¨±¦_±ÌÂä·Éºè");
			name = "³Ð¡¤êØ»ÊÉñÍþ";
			nativename = "³Ð¡¤êØ»ÊÉñÍþ";
			icon = "êØ»ÊÉñÍþ.dds";
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

			return ((-35 * skill_level) - skill_level * skill_level + 445);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_var1 = player.GetVar1();
			int				player_var11 = player.GetVar11();
			int				skill_level = skill.GetLevel();

			/*
			victim.SetProbability(((12 * skill_level + 30)));
			victim.SetTime(((6000 * norm(skill_level / 4.9f) + (2000 * skill_level) + 30100)));
			victim.SetBuffid(4);
			victim.SetAmount(((66 * norm(skill_level / 4.9f) + (34 * (norm(skill_level / 3.9f) + skill_level)) + 512)));
			victim.SetCycsubdefence(true);
			victim.SetProbability(((8 * skill_level + 18)));
			victim.SetTime(((24100 - 2000 * skill_level)));
			victim.SetBuffid(4);
			victim.SetAmount(((24 * skill_level + 512)));
			victim.SetCycsubattack(true);
			if ( player_var11 == 43 )
			{
			v33 = 4 * skill_level + 6;
			if ( skill_level == 5 )
			v32 = (v33 + 10);
			else
			v34 = v33;
			}
			else
			{
			v31 = skill_level + 3;
			if ( skill_level == 4 )
			v30 = (v31 + 10);
			else
			v34 = v31;
			}
			victim.SetProbability(v34);
			victim.SetTime(((1000 * skill_level + 2100)));
			victim.SetDiet(true);
			*/
			return true;
		}
	}
	public class GSkill4505 : GSkill
	{
		public GSkill4505()
			: base(4505)
		{
			
		}
	}
	public class GSkill4506Stub : GSkillStub
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
				int				player_occupation = player.GetOccupation();
				int				skill_level = skill.GetLevel();

				player.SetVar11(player_occupation);
				skill.SetRatio((D2INT(player_level / (9 - skill_level)) * 0.01f + (skill_level * 0.07000000000000001f + 1.0f)));
				skill.SetPlus(((215 * skill_level)));
				player.SetPerform(1);
			}
		}
		public GSkill4506Stub()
			: base(4506)
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
			SetAction(0,"»³¹â_·¨±¦_¾øÓ°");
			SetAction(1,"ÇàÔÆÃÅ_·¨±¦_Ç¬À¤Ëø");
			SetAction(2,"¹íÍõ×Ú_·¨±¦_ÓÄÚ¤¹íÊÖ");
			SetAction(3,"ºÏ»¶ÅÉ_·¨±¦_³à½ðç±");
			SetAction(4,"ÌìÒôËÂ_·¨±¦_ÂÖ»ØÅÌ");
			SetAction(5,"¹íµÀ_·¨±¦_¹ííà");
			SetAction(6,"·ÙÏã¹È_·¨±¦_¾Åº®Äý±ù´Ì");
			SetAction(7,"ÊÞÉñ_·¨±¦_É¥ÃÅ½£");
			SetAction(8,"ºüÑý_·¨±¦_ÂåÊé");
			SetAction(9,"ÐùÔ¯_·¨±¦_³ÐÓ°");
			SetAction(10,"»³¹â_·¨±¦_¾øÓ°");
			SetAction(11,"Ì«ê»_·¨±¦_ôË»ÊÖÓ");
			SetAction(12,"Ìì»ª_·¨±¦_±ÌÂä·Éºè");
			SetAction(13,"1");
			SetAction(14,"1");
			SetAction(15,"1");
			SetAction(16,"1");
			SetAction(17,"1");
			SetAction(18,"»³¹â_Æï³Ë_·¨±¦_¾øÓ°");
			SetAction(19,"ÇàÔÆÃÅ_Æï³Ë_·¨±¦_Ç¬À¤Ëø");
			SetAction(20,"¹íÍõ×Ú_Æï³Ë_·¨±¦_ÓÄÚ¤¹íÊÖ");
			SetAction(21,"ºÏ»¶ÅÉ_Æï³Ë_·¨±¦_³à½ðç±");
			SetAction(22,"ÌìÒôËÂ_Æï³Ë_·¨±¦_ÂÖ»ØÅÌ");
			SetAction(23,"¹íµÀ_Æï³Ë_·¨±¦_¹ííà");
			SetAction(24,"·ÙÏã¹È_Æï³Ë_·¨±¦_¾Åº®Äý±ù´Ì");
			SetAction(25,"ÊÞÉñ_Æï³Ë_·¨±¦_É¥ÃÅ½£");
			SetAction(26,"ºüÑý_Æï³Ë_·¨±¦_ÂåÊé");
			SetAction(27,"ÐùÔ¯_Æï³Ë_·¨±¦_³ÐÓ°");
			SetAction(28,"»³¹â_Æï³Ë_·¨±¦_¾øÓ°");
			SetAction(29,"Ì«ê»_Æï³Ë_·¨±¦_ôË»ÊÖÓ");
			SetAction(30,"Ìì»ª_Æï³Ë_·¨±¦_±ÌÂä·Éºè");
			name = "³Ð¡¤ÆÅæ¶Ó°»Ê";
			nativename = "³Ð¡¤ÆÅæ¶Ó°»Ê";
			icon = "ÆÅæ¶Ó°»Ê.dds";
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

			return ((-35 * skill_level) - skill_level * skill_level + 445);
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
			int				player_var11 = player.GetVar11();
			int				skill_level = skill.GetLevel();

			/*
			if ( player_var11 == 49 )
			{
			v34 = (10 * skill_level + ((player_res5 + (player_res4 + (player_res3 + (player_res2 + player_res1)))) / 5));
			}
			else
			{
			v34 = (5 * skill_level + ((player_res5 + (player_res4 + (player_res3 + (player_res2 + player_res1)))) / 5));
			}
			victim.SetProbability(v34);
			victim.SetTime(((1000 * skill_level + 1000)));
			victim.SetSilent(true);
			victim.SetTime(12000.0f);
			victim.SetRatio((skill_level * 0.04f));
			victim.SetBuffid(0);
			victim.SetDecskilldamage(true);
			*/
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();

			victim.SetProbability(120.0f);
			victim.SetTime(12000.0f);
			victim.SetRatio(1.0f);
			victim.SetAmount(10.0f);
			victim.SetValue(((18 * skill_level + 12)));
			victim.SetFrenzied(true);
			return true;
		}
	}
	public class GSkill4506 : GSkill
	{
		public GSkill4506()
			: base(4506)
		{
			
		}
	}
	public class GSkill4507Stub : GSkillStub
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
				int				player_occupation = player.GetOccupation();
				int				skill_level = skill.GetLevel();

				player.SetVar11(player_occupation);
				skill.SetRatio((D2INT(player_level / (9 - skill_level)) * 0.01f + (skill_level * 0.08f + 1.0f)));
				skill.SetPlus(((175 * skill_level)));
				player.SetPerform(1);
			}
		}
		public GSkill4507Stub()
			: base(4507)
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
			SetAction(0,"Ìì»ª_·¨±¦_±ÌÂä·Éºè");
			SetAction(1,"ÇàÔÆÃÅ_·¨±¦_Ç¬À¤Ëø");
			SetAction(2,"¹íÍõ×Ú_·¨±¦_ÓÄÚ¤¹íÊÖ");
			SetAction(3,"ºÏ»¶ÅÉ_·¨±¦_³à½ðç±");
			SetAction(4,"ÌìÒôËÂ_·¨±¦_ÂÖ»ØÅÌ");
			SetAction(5,"¹íµÀ_·¨±¦_¹ííà");
			SetAction(6,"·ÙÏã¹È_·¨±¦_¾Åº®Äý±ù´Ì");
			SetAction(7,"ÊÞÉñ_·¨±¦_É¥ÃÅ½£");
			SetAction(8,"ºüÑý_·¨±¦_ÂåÊé");
			SetAction(9,"ÐùÔ¯_·¨±¦_³ÐÓ°");
			SetAction(10,"»³¹â_·¨±¦_¾øÓ°");
			SetAction(11,"Ì«ê»_·¨±¦_ôË»ÊÖÓ");
			SetAction(12,"Ìì»ª_·¨±¦_±ÌÂä·Éºè");
			SetAction(13,"1");
			SetAction(14,"1");
			SetAction(15,"1");
			SetAction(16,"1");
			SetAction(17,"1");
			SetAction(18,"Ìì»ª_Æï³Ë_·¨±¦_±ÌÂä·Éºè");
			SetAction(19,"ÇàÔÆÃÅ_Æï³Ë_·¨±¦_Ç¬À¤Ëø");
			SetAction(20,"¹íÍõ×Ú_Æï³Ë_·¨±¦_ÓÄÚ¤¹íÊÖ");
			SetAction(21,"ºÏ»¶ÅÉ_Æï³Ë_·¨±¦_³à½ðç±");
			SetAction(22,"ÌìÒôËÂ_Æï³Ë_·¨±¦_ÂÖ»ØÅÌ");
			SetAction(23,"¹íµÀ_Æï³Ë_·¨±¦_¹ííà");
			SetAction(24,"·ÙÏã¹È_Æï³Ë_·¨±¦_¾Åº®Äý±ù´Ì");
			SetAction(25,"ÊÞÉñ_Æï³Ë_·¨±¦_É¥ÃÅ½£");
			SetAction(26,"ºüÑý_Æï³Ë_·¨±¦_ÂåÊé");
			SetAction(27,"ÐùÔ¯_Æï³Ë_·¨±¦_³ÐÓ°");
			SetAction(28,"»³¹â_Æï³Ë_·¨±¦_¾øÓ°");
			SetAction(29,"Ì«ê»_Æï³Ë_·¨±¦_ôË»ÊÖÓ");
			SetAction(30,"Ìì»ª_Æï³Ë_·¨±¦_±ÌÂä·Éºè");
			name = "³Ð¡¤ÌìÄ§½µ·ü";
			nativename = "³Ð¡¤ÌìÄ§½µ·ü";
			icon = "ÌìÄ§½µ·ü.dds";
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

			return ((-35 * skill_level) - skill_level * skill_level + 445);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();

			victim.SetProbability(((skill_level * skill_level + 2)));
			victim.SetTime(((2000 * skill_level + 2000)));
			victim.SetRatio(((skill_level * (skill_level * 0.03f)) - skill_level * 0.06f + 0.06f));
			victim.SetBuffid(4);
			victim.SetDecskillaccu(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_res1 = player.GetRes1();
			int				player_res2 = player.GetRes2();
			int				player_res3 = player.GetRes3();
			int				player_res4 = player.GetRes4();
			int				player_res5 = player.GetRes5();
			int				player_var1 = player.GetVar1();
			int				player_var11 = player.GetVar11();
			int				skill_level = skill.GetLevel();

			/*
			victim.SetProbability(((2 * skill_level)));
			victim.SetTime(((1000 * skill_level + 2000)));
			victim.SetRatio(0.5f);
			victim.SetBuffid(3);
			victim.SetIncdrugeffect(true);
			if ( player_var11 == 55 )
			{
			if ( (player_res5 + (player_res4 + (player_res3 + (player_res2 + player_res1)))) / 240 + 10 > 50 )
			{
			v60 = 50.0f;
			}
			else
			{
			v60 = ((player_res5 + (player_res4 + (player_res3 + (player_res2 + player_res1)))) / 240);
			}
			v61 = v60;
			}
			else
			{
			if ( (player_res5 + (player_res4 + (player_res3 + (player_res2 + player_res1)))) / 1000 + 7 > 8 )
			{
			v59 = 8.0f;
			}
			else
			{
			v59 = ((player_res5 + (player_res4 + (player_res3 + (player_res2 + player_res1)))) / 1000);
			}
			v61 = v59;
			}
			victim.SetProbability(v61);
			victim.SetTime(((100 * skill_level * (skill_level * skill_level) + 3000)));
			victim.SetRatio((skill_level * (skill_level * (skill_level * 0.01f)) + (skill_level * 0.05f)));
			victim.SetBuffid(2);
			victim.SetInccrithurt(true);
			*/
			return true;
		}
	}
	public class GSkill4507 : GSkill
	{
		public GSkill4507()
			: base(4507)
		{
			
		}
	}
	public class GSkill4508Stub : GSkillStub
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
				int				player_occupation = player.GetOccupation();
				int				skill_level = skill.GetLevel();

				player.SetVar11(player_occupation);
				skill.SetCrit((skill_level * 0.01f));
				skill.SetCrithurt((skill_level * (skill_level * 0.01f) + (skill_level * 0.05f)));
				skill.SetRatio((D2INT(player_level / (9 - skill_level)) * 0.01f + (skill_level * 0.07000000000000001f + 1.0f)));
				skill.SetPlus(((215 * skill_level)));
				player.SetPerform(1);
			}
		}
		public GSkill4508Stub()
			: base(4508)
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
			SetAction(0,"Ì«ê»_·¨±¦_ôË»ÊÖÓ");
			SetAction(1,"ÇàÔÆÃÅ_·¨±¦_Ç¬À¤Ëø");
			SetAction(2,"¹íÍõ×Ú_·¨±¦_ÓÄÚ¤¹íÊÖ");
			SetAction(3,"ºÏ»¶ÅÉ_·¨±¦_³à½ðç±");
			SetAction(4,"ÌìÒôËÂ_·¨±¦_ÂÖ»ØÅÌ");
			SetAction(5,"¹íµÀ_·¨±¦_¹ííà");
			SetAction(6,"·ÙÏã¹È_·¨±¦_¾Åº®Äý±ù´Ì");
			SetAction(7,"ÊÞÉñ_·¨±¦_É¥ÃÅ½£");
			SetAction(8,"ºüÑý_·¨±¦_ÂåÊé");
			SetAction(9,"ÐùÔ¯_·¨±¦_³ÐÓ°");
			SetAction(10,"»³¹â_·¨±¦_¾øÓ°");
			SetAction(11,"Ì«ê»_·¨±¦_ôË»ÊÖÓ");
			SetAction(12,"Ìì»ª_·¨±¦_±ÌÂä·Éºè");
			SetAction(13,"1");
			SetAction(14,"1");
			SetAction(15,"1");
			SetAction(16,"1");
			SetAction(17,"1");
			SetAction(18,"Ì«ê»_Æï³Ë_·¨±¦_ôË»ÊÖÓ");
			SetAction(19,"ÇàÔÆÃÅ_Æï³Ë_·¨±¦_Ç¬À¤Ëø");
			SetAction(20,"¹íÍõ×Ú_Æï³Ë_·¨±¦_ÓÄÚ¤¹íÊÖ");
			SetAction(21,"ºÏ»¶ÅÉ_Æï³Ë_·¨±¦_³à½ðç±");
			SetAction(22,"ÌìÒôËÂ_Æï³Ë_·¨±¦_ÂÖ»ØÅÌ");
			SetAction(23,"¹íµÀ_Æï³Ë_·¨±¦_¹ííà");
			SetAction(24,"·ÙÏã¹È_Æï³Ë_·¨±¦_¾Åº®Äý±ù´Ì");
			SetAction(25,"ÊÞÉñ_Æï³Ë_·¨±¦_É¥ÃÅ½£");
			SetAction(26,"ºüÑý_Æï³Ë_·¨±¦_ÂåÊé");
			SetAction(27,"ÐùÔ¯_Æï³Ë_·¨±¦_³ÐÓ°");
			SetAction(28,"»³¹â_Æï³Ë_·¨±¦_¾øÓ°");
			SetAction(29,"Ì«ê»_Æï³Ë_·¨±¦_ôË»ÊÖÓ");
			SetAction(30,"Ìì»ª_Æï³Ë_·¨±¦_±ÌÂä·Éºè");
			name = "³Ð¡¤ºÆÆøÔÆÌì";
			nativename = "³Ð¡¤ºÆÆøÔÆÌì";
			icon = "ºÆÆøÔÆÌì.dds";
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

			return ((-35 * skill_level) - skill_level * skill_level + 445);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_var1 = player.GetVar1();
			int				player_var11 = player.GetVar11();
			int				skill_level = skill.GetLevel();

			/*
			victim.SetTime((((2000 * skill_level + 3000) * norm(zrand(100) / (80 - 8 * skill_level)))));
			victim.SetRatio((skill_level * 0.01f));
			victim.SetBuffid(0);
			victim.SetDecanti(true);
			if ( player_var11 == 100 )
			v18 = (8 * skill_level + 20);
			else
			victim.SetProbability(((4 * skill_level + 10)));
			if ( skill_level == 5 )
			v17 = 3.0f;
			else
			victim.SetAmount(1.0f);
			victim.SetClearbuff(true);
			*/
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();

			victim.SetProbability(((10 * skill_level)));
			victim.SetTime(((1000 * skill_level)));
			victim.SetRatio((skill_level * 0.02f));
			victim.SetBuffid(5);
			victim.SetIncattack(true);
			return true;
		}
	}
	public class GSkill4508 : GSkill
	{
		public GSkill4508()
			: base(4508)
		{
			
		}
	}
	public class GSkill4509Stub : GSkillStub
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

				skill.SetRatio((D2INT(player_level / (9 - skill_level)) * 0.01f + (skill_level * 0.08f + 1.0f)));
				skill.SetPlus(((175 * skill_level)));
				player.SetPerform(1);
			}
		}
		public GSkill4509Stub()
			: base(4509)
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
			SetAction(0,"ÐùÔ¯_·¨±¦_³ÐÓ°");
			SetAction(1,"ÇàÔÆÃÅ_·¨±¦_Ç¬À¤Ëø");
			SetAction(2,"¹íÍõ×Ú_·¨±¦_ÓÄÚ¤¹íÊÖ");
			SetAction(3,"ºÏ»¶ÅÉ_·¨±¦_³à½ðç±");
			SetAction(4,"ÌìÒôËÂ_·¨±¦_ÂÖ»ØÅÌ");
			SetAction(5,"¹íµÀ_·¨±¦_¹ííà");
			SetAction(6,"·ÙÏã¹È_·¨±¦_¾Åº®Äý±ù´Ì");
			SetAction(7,"ÊÞÉñ_·¨±¦_É¥ÃÅ½£");
			SetAction(8,"ºüÑý_·¨±¦_ÂåÊé");
			SetAction(9,"ÐùÔ¯_·¨±¦_³ÐÓ°");
			SetAction(10,"»³¹â_·¨±¦_¾øÓ°");
			SetAction(11,"Ì«ê»_·¨±¦_ôË»ÊÖÓ");
			SetAction(12,"Ìì»ª_·¨±¦_±ÌÂä·Éºè");
			SetAction(13,"1");
			SetAction(14,"1");
			SetAction(15,"1");
			SetAction(16,"1");
			SetAction(17,"1");
			SetAction(18,"ÐùÔ¯_Æï³Ë_·¨±¦_³ÐÓ°");
			SetAction(19,"ÇàÔÆÃÅ_Æï³Ë_·¨±¦_Ç¬À¤Ëø");
			SetAction(20,"¹íÍõ×Ú_Æï³Ë_·¨±¦_ÓÄÚ¤¹íÊÖ");
			SetAction(21,"ºÏ»¶ÅÉ_Æï³Ë_·¨±¦_³à½ðç±");
			SetAction(22,"ÌìÒôËÂ_Æï³Ë_·¨±¦_ÂÖ»ØÅÌ");
			SetAction(23,"¹íµÀ_Æï³Ë_·¨±¦_¹ííà");
			SetAction(24,"·ÙÏã¹È_Æï³Ë_·¨±¦_¾Åº®Äý±ù´Ì");
			SetAction(25,"ÊÞÉñ_Æï³Ë_·¨±¦_É¥ÃÅ½£");
			SetAction(26,"ºüÑý_Æï³Ë_·¨±¦_ÂåÊé");
			SetAction(27,"ÐùÔ¯_Æï³Ë_·¨±¦_³ÐÓ°");
			SetAction(28,"»³¹â_Æï³Ë_·¨±¦_¾øÓ°");
			SetAction(29,"Ì«ê»_Æï³Ë_·¨±¦_ôË»ÊÖÓ");
			SetAction(30,"Ìì»ª_Æï³Ë_·¨±¦_±ÌÂä·Éºè");
			name = "³Ð¡¤ÎÞÉÏÎÞ¼«";
			nativename = "³Ð¡¤ÎÞÉÏÎÞ¼«";
			icon = "ÏÈÌìî¸Æø.dds";
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

			return ((-35 * skill_level) - skill_level * skill_level + 445);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();

			victim.SetProbability(((skill_level * skill_level + 2)));
			victim.SetTime(((2000 * skill_level + 2000)));
			victim.SetRatio(((skill_level * skill_level + 6) * 0.01f));
			victim.SetBuffid(1);
			victim.SetDecskilldodge(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_var1 = player.GetVar1();
			int				player_var11 = player.GetVar11();
			int				skill_level = skill.GetLevel();

			/*
			if ( zrand(100) >= 3 * skill_level )
			t = 0.0f;
			else
			victim.SetTime(((2000 * skill_level + 2000)));
			victim.SetRatio(((skill_level + 3) * 0.01f));
			victim.SetInccritrate(true);
			if ( player_var11 == 60 )
			v19 = (3 * skill_level);
			else
			victim.SetProbability(skill_level);
			victim.SetTime(((skill_level * (skill_level * 0.5f) + 3.0f) * 1000.0f));
			victim.SetRatio(((2 * skill_level * skill_level + 50) * 0.01f));
			victim.SetBuffid(1);
			victim.SetInccrithurt(true);
			*/
			return true;
		}
	}
	public class GSkill4509 : GSkill
	{
		public GSkill4509()
			: base(4509)
		{
			
		}
	}
}
