using System;
using System.Text;

namespace SKILL
{
	public class GSkill3280Stub : GSkillStub
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
		public GSkill3280Stub()
			: base(3280)
		{
			occupation = 128;
			maxlevel = 99;
			maxlearn = 99;
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
			name = "ÐÂÖ÷ÏßÓÃ¹ÇÉß±äÉí";
			nativename = "ÐÂÖ÷ÏßÓÃ¹ÇÉß±äÉí";
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
			int				skill_level = skill.GetLevel();

			return (D2INT(skill_level * 0.1f) + 2);
		}
		public override float GetCastdistance(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (D2INT(skill_level * 0.1f) + 1);
		}
		public override float GetEffectdistance(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (D2INT(skill_level * 0.1f) + 3);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();

			victim.SetProbability(120.0f);
			victim.SetTime(((1000 * (skill_level - 10 * D2INT(skill_level * 0.1f)))));
			victim.SetRatio(1.0f);
			victim.SetAmount(1.0f);
			victim.SetValue(350.0f);
			victim.SetTransform(true);
			return true;
		}
	}
	public class GSkill3280 : GSkill
	{
		public GSkill3280()
			: base(3280)
		{
			
		}
	}
	public class GSkill3281Stub : GSkillStub
	{
		public GSkill3281Stub()
			: base(3281)
		{
			occupation = 151;
			maxlevel = 10;
			maxlearn = 10;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 1;
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
			name = "ÐÂÊ±×°Îèµ¸01";
			nativename = "ÐÂÊ±×°Îèµ¸01";
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
	public class GSkill3281 : GSkill
	{
		public GSkill3281()
			: base(3281)
		{
			
		}
	}
	public class GSkill3282Stub : GSkillStub
	{
		public GSkill3282Stub()
			: base(3282)
		{
			occupation = 151;
			maxlevel = 10;
			maxlearn = 10;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 1;
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
			name = "ÐÂÊ±×°Îèµ¸02";
			nativename = "ÐÂÊ±×°Îèµ¸02";
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
	public class GSkill3282 : GSkill
	{
		public GSkill3282()
			: base(3282)
		{
			
		}
	}
	public class GSkill3283Stub : GSkillStub
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
		public GSkill3283Stub()
			: base(3283)
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
			dobless = true;
			autoattack = false;
			allowform = 0;
			credittype = 0;
			clearmask = 0;
			skill_limit = 7;
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
			SetAction(0,"¹íÍõ×Ú_¿ÝÄ¾Öä");
			SetAction(1,"ÇàÔÆÃÅ_Á¶Æø»¹Éñ");
			SetAction(2,"¹íÍõ×Ú_¿ÝÄ¾Öä");
			SetAction(3,"ºÏ»¶ÅÉ_¼¤Àø");
			SetAction(4,"ÌìÒôËÂ_Ò×½î¾­");
			SetAction(5,"ÄýÉñÑªÖä");
			SetAction(6,"0");
			SetAction(7,"ÊÞÉñ_ºáÐÐ");
			SetAction(8,"ºüÑý_¹ÌÔªÊõ");
			SetAction(9,"0");
			SetAction(10,"»³¹â_ÍµÏ®");
			SetAction(11,"0");
			SetAction(12,"Ìì»ª_´ºÀ×");
			SetAction(13,"");
			SetAction(14,"");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"¹íÍõ×Ú_Æï³Ë_¿ÝÄ¾Öä");
			SetAction(19,"ÇàÔÆÃÅ_Æï³Ë_Á¶Æø»¹Éñ");
			SetAction(20,"¹íÍõ×Ú_Æï³Ë_¿ÝÄ¾Öä");
			SetAction(21,"ºÏ»¶ÅÉ_Æï³Ë_¼¤Àø");
			SetAction(22,"ÌìÒôËÂ_Æï³Ë_Ò×½î¾­");
			SetAction(23,"ÄýÉñÑªÖä");
			SetAction(24,"0");
			SetAction(25,"ÊÞÉñ_Æï³Ë_ºáÐÐ");
			SetAction(26,"ºüÑý_Æï³Ë_¹ÌÔªÊõ");
			SetAction(27,"0");
			SetAction(28,"»³¹â_Æï³Ë_ÍµÏ®");
			SetAction(29,"0");
			SetAction(30,"Ìì»ª_Æï³Ë_´ºÀ×");
			name = "¹íÀ÷µÄ·ßÅ­";
			nativename = "¹íÀ÷µÄ·ßÅ­";
			icon = "¹íÀ÷µÄ·ßÅ­.dds";
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
			return 6000;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 22.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 16.000000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 27.000000f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetProbability(120.0f);
			victim.SetTime(28800000.0f);
			victim.SetRatio(0.5f);
			victim.SetBuffid(1);
			victim.SetIncattack(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetProbability(120.0f);
			victim.SetTime(28800000.0f);
			victim.SetRatio(0.5f);
			victim.SetBuffid(1);
			victim.SetIncattack(true);
			return true;
		}
	}
	public class GSkill3283 : GSkill
	{
		public GSkill3283()
			: base(3283)
		{
			
		}
	}
	public class GSkill3284Stub : GSkillStub
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
		public GSkill3284Stub()
			: base(3284)
		{
			occupation = 129;
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
			SetAction(0,"¹íÍõ×Ú_ÎÞ¼ä¼Å");
			SetAction(1,"¹íÍõ×Ú_ÎÞ¼ä¼Å");
			SetAction(2,"¹íÍõ×Ú_ÎÞ¼ä¼Å");
			SetAction(3,"¹íÍõ×Ú_ÎÞ¼ä¼Å");
			SetAction(4,"¹íÍõ×Ú_ÎÞ¼ä¼Å");
			SetAction(5,"¹íµÀ_¼á¶Ü");
			SetAction(6,"¹íÍõ×Ú_ÎÞ¼ä¼Å");
			SetAction(7,"ÊÞÉñ_»¢Á¦");
			SetAction(8,"ºüÑý_°²ÈçÉ½");
			SetAction(9,"ÐùÔ¯_¼ÓËÙ");
			SetAction(10,"»³¹â_ÍµÏ®");
			SetAction(11,"ÊÞÉñ_»¢Á¦");
			SetAction(12,"Ìì»ª_±¼À×");
			SetAction(13,"0");
			SetAction(14,"0");
			SetAction(15,"ÎäÆ÷´óÊ¦_ÔöÒæÐ§¹û");
			SetAction(16,"0");
			SetAction(17,"¹íÍõ×Ú_ÎÞ¼ä¼Å");
			SetAction(18,"¹íÍõ×Ú_Æï³Ë_ÎÞ¼ä¼Å");
			SetAction(19,"¹íÍõ×Ú_Æï³Ë_ÎÞ¼ä¼Å");
			SetAction(20,"¹íÍõ×Ú_Æï³Ë_ÎÞ¼ä¼Å");
			SetAction(21,"¹íÍõ×Ú_Æï³Ë_ÎÞ¼ä¼Å");
			SetAction(22,"¹íÍõ×Ú_Æï³Ë_ÎÞ¼ä¼Å");
			SetAction(23,"¹íµÀ_Æï³Ë_¼á¶Ü");
			SetAction(24,"¹íÍõ×Ú_Æï³Ë_ÎÞ¼ä¼Å");
			SetAction(25,"ÊÞÉñ_Æï³Ë_»¢Á¦");
			SetAction(26,"ºüÑý_Æï³Ë_°²ÈçÉ½");
			SetAction(27,"ÐùÔ¯_Æï³Ë_¼ÓËÙ");
			SetAction(28,"»³¹â_Æï³Ë_ÍµÏ®");
			SetAction(29,"ÊÞÉñ_Æï³Ë_»¢Á¦");
			SetAction(30,"Ìì»ª_Æï³Ë_±¼À×");
			name = "Ä°Â··²¸è";
			nativename = "Ä°Â··²¸è";
			icon = "Ä°Â··²¸è.dds";
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
			return 900000;
		}
		public override float GetRadius(GSkill skill)
		{
			return 25.000000f;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 25.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 10.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			return 600.000000f;
		}
		public override int GetCoverage(GSkill skill)
		{
			return 40;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetProbability(100.0f);
			victim.SetTime(30000.0f);
			victim.SetRatio(0.30000001f);
			victim.SetBuffid(5);
			victim.SetDecfatalratio(true);
			victim.SetProbability(100.0f);
			victim.SetTime(30000.0f);
			victim.SetRatio(3.0f);
			victim.SetBuffid(5);
			victim.SetDecfatalhurt(true);
			victim.SetProbability(100.0f);
			victim.SetTime(15000.0f);
			victim.SetRatio(0.40000999f);
			victim.SetBuffid(5);
			victim.SetIncskilldodge(true);
			victim.SetProbability(100.0f);
			victim.SetTime(15000.0f);
			victim.SetBuffid(1);
			victim.SetValue(4.0009999f);
			victim.SetAddspeed(true);
			return true;
		}
	}
	public class GSkill3284 : GSkill
	{
		public GSkill3284()
			: base(3284)
		{
			
		}
	}
	public class GSkill3285Stub : GSkillStub
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
		public GSkill3285Stub()
			: base(3285)
		{
			occupation = 129;
			maxlevel = 1;
			maxlearn = 1;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 3;
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
			SetAction(0,"¹íÍõ×Ú_³ÕÇéÖä");
			SetAction(1,"¹íÍõ×Ú_³ÕÇéÖä");
			SetAction(2,"¹íÍõ×Ú_³ÕÇéÖä");
			SetAction(3,"¹íÍõ×Ú_³ÕÇéÖä");
			SetAction(4,"¹íÍõ×Ú_³ÕÇéÖä");
			SetAction(5,"¹íµÀ_É¢¾¡");
			SetAction(6,"¹íÍõ×Ú_³ÕÇéÖä");
			SetAction(7,"ÊÞÉñ_É¢¾¡");
			SetAction(8,"ºüÑý_É¢¾¡");
			SetAction(9,"ÐùÔ¯_É¢¾¡");
			SetAction(10,"»³¹â_É¢¾¡");
			SetAction(11,"ÊÞÉñ_É¢¾¡");
			SetAction(12,"Ìì»ª_É¢¾¡");
			SetAction(13,"0");
			SetAction(14,"0");
			SetAction(15,"ÎäÆ÷´óÊ¦_µ¶ÉÁ");
			SetAction(16,"0");
			SetAction(17,"¹íÍõ×Ú_³ÕÇéÖä");
			SetAction(18,"¹íÍõ×Ú_Æï³Ë_³ÕÇéÖä");
			SetAction(19,"¹íÍõ×Ú_Æï³Ë_³ÕÇéÖä");
			SetAction(20,"¹íÍõ×Ú_Æï³Ë_³ÕÇéÖä");
			SetAction(21,"¹íÍõ×Ú_Æï³Ë_³ÕÇéÖä");
			SetAction(22,"¹íÍõ×Ú_Æï³Ë_³ÕÇéÖä");
			SetAction(23,"¹íµÀ_Æï³Ë_É¢¾¡");
			SetAction(24,"¹íÍõ×Ú_Æï³Ë_³ÕÇéÖä");
			SetAction(25,"ÊÞÉñ_Æï³Ë_É¢¾¡");
			SetAction(26,"ºüÑý_Æï³Ë_É¢¾¡");
			SetAction(27,"ÐùÔ¯_Æï³Ë_É¢¾¡");
			SetAction(28,"»³¹â_Æï³Ë_É¢¾¡");
			SetAction(29,"ÊÞÉñ_Æï³Ë_É¢¾¡");
			SetAction(30,"Ìì»ª_Æï³Ë_É¢¾¡");
			name = "±ÌÂä·²Çé";
			nativename = "±ÌÂä·²Çé";
			icon = "±ÌÂä·²Çé.dds";
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
			return 900000;
		}
		public override float GetRadius(GSkill skill)
		{
			return 18.000000f;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 13.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 12.000000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 35.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			return 600.000000f;
		}
		public override int GetCoverage(GSkill skill)
		{
			return 12;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_maxhp = player.GetMaxhp();

			victim.SetProbability(100.0f);
			victim.SetAmount(3.0f);
			victim.SetClearbuff(true);
			victim.SetProbability(100.0f);
			victim.SetTime(15000.0f);
			victim.SetBuffid(5);
			victim.SetAmount(100.0f);
			victim.SetValue((player_maxhp * 0.2f));
			victim.SetSubhp(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetProbability(100.0f);
			victim.SetTime(20000.0f);
			victim.SetRatio(1.0f);
			victim.SetAmount(99.0f);
			victim.SetDeadlybless(true);
			return true;
		}
	}
	public class GSkill3285 : GSkill
	{
		public GSkill3285()
			: base(3285)
		{
			
		}
	}
	public class GSkill3286Stub : GSkillStub
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
		public GSkill3286Stub()
			: base(3286)
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
			dobless = true;
			autoattack = false;
			allowform = 0;
			credittype = 0;
			clearmask = 0;
			skill_limit = 7;
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
			SetAction(0,"¹íÍõ×Ú_¿ÝÄ¾Öä");
			SetAction(1,"ÇàÔÆÃÅ_Á¶Æø»¹Éñ");
			SetAction(2,"¹íÍõ×Ú_¿ÝÄ¾Öä");
			SetAction(3,"ºÏ»¶ÅÉ_¼¤Àø");
			SetAction(4,"ÌìÒôËÂ_Ò×½î¾­");
			SetAction(5,"ÄýÉñÑªÖä");
			SetAction(6,"0");
			SetAction(7,"ÊÞÉñ_ºáÐÐ");
			SetAction(8,"ºüÑý_¹ÌÔªÊõ");
			SetAction(9,"0");
			SetAction(10,"»³¹â_ÍµÏ®");
			SetAction(11,"0");
			SetAction(12,"Ìì»ª_´ºÀ×");
			SetAction(13,"");
			SetAction(14,"");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"¹íÍõ×Ú_Æï³Ë_¿ÝÄ¾Öä");
			SetAction(19,"ÇàÔÆÃÅ_Æï³Ë_Á¶Æø»¹Éñ");
			SetAction(20,"¹íÍõ×Ú_Æï³Ë_¿ÝÄ¾Öä");
			SetAction(21,"ºÏ»¶ÅÉ_Æï³Ë_¼¤Àø");
			SetAction(22,"ÌìÒôËÂ_Æï³Ë_Ò×½î¾­");
			SetAction(23,"ÄýÉñÑªÖä");
			SetAction(24,"0");
			SetAction(25,"ÊÞÉñ_Æï³Ë_ºáÐÐ");
			SetAction(26,"ºüÑý_Æï³Ë_¹ÌÔªÊõ");
			SetAction(27,"0");
			SetAction(28,"»³¹â_Æï³Ë_ÍµÏ®");
			SetAction(29,"0");
			SetAction(30,"Ìì»ª_Æï³Ë_´ºÀ×");
			name = "Ñ©ç÷µÄÆíÔ¸";
			nativename = "Ñ©ç÷µÄÆíÔ¸";
			icon = "Ñ©ç÷µÄÆíÔ¸.dds";
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
			return 6000;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 22.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 16.000000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 27.000000f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetProbability(120.0f);
			victim.SetTime(28800000.0f);
			victim.SetRatio(0.5f);
			victim.SetBuffid(1);
			victim.SetIncdefence(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetProbability(120.0f);
			victim.SetTime(28800000.0f);
			victim.SetRatio(0.5f);
			victim.SetBuffid(1);
			victim.SetIncdefence(true);
			return true;
		}
	}
	public class GSkill3286 : GSkill
	{
		public GSkill3286()
			: base(3286)
		{
			
		}
	}
	public class GSkill3287Stub : GSkillStub
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
		public GSkill3287Stub()
			: base(3287)
		{
			occupation = 128;
			maxlevel = 10;
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
			skill_limit = 7;
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
			name = "ÐÂÖ÷ÏßÉñ×å´«ËÍ";
			nativename = "ÐÂÖ÷ÏßÉñ×å´«ËÍ";
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
			return 100;
		}
		public override float GetRadius(GSkill skill)
		{
			return 2.600000f;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 2.600000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 2.500000f;
		}
		public override int GetCoverage(GSkill skill)
		{
			return 12;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_occupation = player.GetOccupation();
			int				skill_level = skill.GetLevel();

			/*
			if ( skill_level == 1 )
			d = 100.0f;
			else
			victim.SetProbability(0.0f);
			victim.SetTime(16000.0f);
			if ( player_occupation == 33
			|| (v5 = player, GNET::PlayerWrapper::GetOccupation(v5) == 34)
			|| (v6 = player, GNET::PlayerWrapper::GetOccupation(v6) == 35)
			|| (v7 = player, GNET::PlayerWrapper::GetOccupation(v7) == 36)
			|| (v8 = player, GNET::PlayerWrapper::GetOccupation(v8) == 37) )
			{
			v119 = 40;
			}
			else
			{
			if ( player_occupation != 45
			&& (v10 = player, GNET::PlayerWrapper::GetOccupation(v10) != 46)
			&& (v11 = player, GNET::PlayerWrapper::GetOccupation(v11) != 47)
			&& (v12 = player, GNET::PlayerWrapper::GetOccupation(v12) != 48)
			&& (v13 = player, GNET::PlayerWrapper::GetOccupation(v13) != 49) )
			v118 = 345;
			else
			v119 = 40;
			}
			victim.SetBuffid(v119);
			if ( player_occupation == 33
			|| (v16 = player, GNET::PlayerWrapper::GetOccupation(v16) == 34)
			|| (v17 = player, GNET::PlayerWrapper::GetOccupation(v17) == 35)
			|| (v18 = player, GNET::PlayerWrapper::GetOccupation(v18) == 36)
			|| (v19 = player, GNET::PlayerWrapper::GetOccupation(v19) == 37) )
			{
			v117 = 462.0f;
			}
			else
			{
			if ( player_occupation != 45
			&& (v21 = player, GNET::PlayerWrapper::GetOccupation(v21) != 46)
			&& (v22 = player, GNET::PlayerWrapper::GetOccupation(v22) != 47)
			&& (v23 = player, GNET::PlayerWrapper::GetOccupation(v23) != 48)
			&& (v24 = player, GNET::PlayerWrapper::GetOccupation(v24) != 49) )
			v116 = 103.0f;
			else
			v117 = -143.0f;
			}
			victim.SetAmount(v117);
			if ( player_occupation == 33
			|| (v27 = player, GNET::PlayerWrapper::GetOccupation(v27) == 34)
			|| (v28 = player, GNET::PlayerWrapper::GetOccupation(v28) == 35)
			|| (v29 = player, GNET::PlayerWrapper::GetOccupation(v29) == 36)
			|| (v30 = player, GNET::PlayerWrapper::GetOccupation(v30) == 37) )
			{
			v115 = 69.0f;
			}
			else
			{
			if ( player_occupation != 45
			&& (v32 = player, GNET::PlayerWrapper::GetOccupation(v32) != 46)
			&& (v33 = player, GNET::PlayerWrapper::GetOccupation(v33) != 47)
			&& (v34 = player, GNET::PlayerWrapper::GetOccupation(v34) != 48)
			&& (v35 = player, GNET::PlayerWrapper::GetOccupation(v35) != 49) )
			v114 = 481.0f;
			else
			v115 = 370.0f;
			}
			victim.SetValue(v115);
			victim.SetMagicdoor(true);
			if ( skill_level == 2 )
			v113 = 100.0f;
			else
			victim.SetProbability(0.0f);
			victim.SetTime(16000.0f);
			if ( player_occupation != 39
			&& (v41 = player, GNET::PlayerWrapper::GetOccupation(v41) != 40)
			&& (v42 = player, GNET::PlayerWrapper::GetOccupation(v42) != 41)
			&& (v43 = player, GNET::PlayerWrapper::GetOccupation(v43) != 42)
			&& (v44 = player, GNET::PlayerWrapper::GetOccupation(v44) != 43) )
			v112 = 392;
			else
			victim.SetBuffid(40);
			if ( player_occupation != 39
			&& (v47 = player, GNET::PlayerWrapper::GetOccupation(v47) != 40)
			&& (v48 = player, GNET::PlayerWrapper::GetOccupation(v48) != 41)
			&& (v49 = player, GNET::PlayerWrapper::GetOccupation(v49) != 42)
			&& (v50 = player, GNET::PlayerWrapper::GetOccupation(v50) != 43) )
			v111 = -366.0f;
			else
			victim.SetAmount(462.0f);
			if ( player_occupation != 39
			&& (v53 = player, GNET::PlayerWrapper::GetOccupation(v53) != 40)
			&& (v54 = player, GNET::PlayerWrapper::GetOccupation(v54) != 41)
			&& (v55 = player, GNET::PlayerWrapper::GetOccupation(v55) != 42)
			&& (v56 = player, GNET::PlayerWrapper::GetOccupation(v56) != 43) )
			v110 = 456.0f;
			else
			victim.SetValue(135.0f);
			victim.SetMagicdoor(true);
			if ( skill_level == 3 )
			v109 = 100.0f;
			else
			victim.SetProbability(0.0f);
			victim.SetTime(16000.0f);
			if ( player_occupation != 45
			&& (v62 = player, GNET::PlayerWrapper::GetOccupation(v62) != 46)
			&& (v63 = player, GNET::PlayerWrapper::GetOccupation(v63) != 47)
			&& (v64 = player, GNET::PlayerWrapper::GetOccupation(v64) != 48)
			&& (v65 = player, GNET::PlayerWrapper::GetOccupation(v65) != 49) )
			v108 = 345;
			else
			victim.SetBuffid(40);
			if ( player_occupation != 45
			&& (v68 = player, GNET::PlayerWrapper::GetOccupation(v68) != 46)
			&& (v69 = player, GNET::PlayerWrapper::GetOccupation(v69) != 47)
			&& (v70 = player, GNET::PlayerWrapper::GetOccupation(v70) != 48)
			&& (v71 = player, GNET::PlayerWrapper::GetOccupation(v71) != 49) )
			v107 = 103.0f;
			else
			victim.SetAmount(-143.0f);
			if ( player_occupation != 45
			&& (v74 = player, GNET::PlayerWrapper::GetOccupation(v74) != 46)
			&& (v75 = player, GNET::PlayerWrapper::GetOccupation(v75) != 47)
			&& (v76 = player, GNET::PlayerWrapper::GetOccupation(v76) != 48)
			&& (v77 = player, GNET::PlayerWrapper::GetOccupation(v77) != 49) )
			v106 = 481.0f;
			else
			victim.SetValue(370.0f);
			victim.SetMagicdoor(true);
			if ( skill_level == 4 )
			v105 = 100.0f;
			else
			victim.SetProbability(0.0f);
			victim.SetTime(16000.0f);
			if ( player_occupation != 51
			&& (v83 = player, GNET::PlayerWrapper::GetOccupation(v83) != 52)
			&& (v84 = player, GNET::PlayerWrapper::GetOccupation(v84) != 53)
			&& (v85 = player, GNET::PlayerWrapper::GetOccupation(v85) != 54)
			&& (v86 = player, GNET::PlayerWrapper::GetOccupation(v86) != 55) )
			v104 = 389;
			else
			victim.SetBuffid(40);
			if ( player_occupation != 51
			&& (v89 = player, GNET::PlayerWrapper::GetOccupation(v89) != 52)
			&& (v90 = player, GNET::PlayerWrapper::GetOccupation(v90) != 53)
			&& (v91 = player, GNET::PlayerWrapper::GetOccupation(v91) != 54)
			&& (v92 = player, GNET::PlayerWrapper::GetOccupation(v92) != 55) )
			v103 = -324.0f;
			else
			victim.SetAmount(-142.0f);
			if ( player_occupation != 51
			&& (v95 = player, GNET::PlayerWrapper::GetOccupation(v95) != 52)
			&& (v96 = player, GNET::PlayerWrapper::GetOccupation(v96) != 53)
			&& (v97 = player, GNET::PlayerWrapper::GetOccupation(v97) != 54)
			&& (v98 = player, GNET::PlayerWrapper::GetOccupation(v98) != 55) )
			v102 = 429.0f;
			else
			victim.SetValue(295.0f);
			victim.SetMagicdoor(true);
			*/
			return true;
		}
	}
	public class GSkill3287 : GSkill
	{
		public GSkill3287()
			: base(3287)
		{
			
		}
	}
	public class GSkill3288Stub : GSkillStub
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
		public GSkill3288Stub()
			: base(3288)
		{
			occupation = 128;
			maxlevel = 99;
			maxlearn = 99;
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
			name = "ÊÈÑª";
			nativename = "ÊÈÑª";
			icon = "ÐÄÔ¸.dds";
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
			return 60000;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 5.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 4.000000f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();

			victim.SetProbability(120.0f);
			victim.SetTime(60000.0f);
			victim.SetRatio((skill_level * 0.01f));
			victim.SetAttack2hp(true);
			return true;
		}
	}
	public class GSkill3288 : GSkill
	{
		public GSkill3288()
			: base(3288)
		{
			
		}
	}
	public class GSkill3289Stub : GSkillStub
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
		public GSkill3289Stub()
			: base(3289)
		{
			occupation = 128;
			maxlevel = 99;
			maxlearn = 99;
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
			name = "ÄçÄ§";
			nativename = "ÄçÄ§";
			icon = "ÕÀ·Å.dds";
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
			return 60000;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 5.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 4.000000f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();

			victim.SetProbability(100.0f);
			victim.SetTime(60000.0f);
			victim.SetRatio((skill_level * 0.01f));
			victim.SetAttack2mp(true);
			return true;
		}
	}
	public class GSkill3289 : GSkill
	{
		public GSkill3289()
			: base(3289)
		{
			
		}
	}
}
