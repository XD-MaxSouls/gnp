using System;
using System.Text;

namespace SKILL
{
	public class GSkill5340Stub : GSkillStub
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
		public GSkill5340Stub()
			: base(5340)
		{
			occupation = 128;
			maxlevel = 1;
			maxlearn = 1;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 2;
			timetype = 1;
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
			SetAction(13,"0");
			SetAction(14,"0");
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
			name = "±ä³É¶ã²ØÕß10";
			nativename = "±ä³É¶ã²ØÕß10";
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
	}
	public class GSkill5340 : GSkill
	{
		public GSkill5340()
			: base(5340)
		{
			
		}
	}
	public class GSkill5341Stub : GSkillStub
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
		public GSkill5341Stub()
			: base(5341)
		{
			occupation = 128;
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
			name = "ÒþÄä";
			nativename = "ÒþÄä";
			icon = "Ó°Áé.dds";
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
			return 30000;
		}
	}
	public class GSkill5341 : GSkill
	{
		public GSkill5341()
			: base(5341)
		{
			
		}
	}
	public class GSkill5342Stub : GSkillStub
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
		public GSkill5342Stub()
			: base(5342)
		{
			occupation = 151;
			maxlevel = 1;
			maxlearn = 10;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 2;
			timetype = 0;
			targettype = 0;
			rangetype = 5;
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
			SetAction(0,"ºÏ»¶ÅÉ_Á¯Ó°");
			SetAction(1,"ºÏ»¶ÅÉ_Á¯Ó°");
			SetAction(2,"ºÏ»¶ÅÉ_Á¯Ó°");
			SetAction(3,"ºÏ»¶ÅÉ_Á¯Ó°");
			SetAction(4,"ºÏ»¶ÅÉ_Á¯Ó°");
			SetAction(5,"ºÏ»¶ÅÉ_Á¯Ó°");
			SetAction(6,"ºÏ»¶ÅÉ_Á¯Ó°");
			SetAction(7,"ÊÞÉñ_Áú¹â");
			SetAction(8,"ºüÑý_°²ÈçÉ½");
			SetAction(9,"ÐùÔ¯_¼ÓËÙ");
			SetAction(10,"»³¹â_¾£¼¬");
			SetAction(11,"ÊÞÉñ_Áú¹â");
			SetAction(12,"Ìì»ª_¾£¼¬");
			SetAction(13,"ÁéÙí_¾£¼¬");
			SetAction(14,"Ó¢ÕÐ_¾£¼¬");
			SetAction(15,"0");
			SetAction(16,"0");
			SetAction(17,"¹éÔÆ_ÉèÖÃÆøÑª");
			SetAction(18,"ºÏ»¶ÅÉ_Æï³Ë_Á¯Ó°");
			SetAction(19,"ºÏ»¶ÅÉ_Æï³Ë_Á¯Ó°");
			SetAction(20,"ºÏ»¶ÅÉ_Æï³Ë_Á¯Ó°");
			SetAction(21,"ºÏ»¶ÅÉ_Æï³Ë_Á¯Ó°");
			SetAction(22,"ºÏ»¶ÅÉ_Æï³Ë_Á¯Ó°");
			SetAction(23,"ºÏ»¶ÅÉ_Æï³Ë_Á¯Ó°");
			SetAction(24,"ºÏ»¶ÅÉ_Æï³Ë_Á¯Ó°");
			SetAction(25,"ÊÞÉñ_Æï³Ë_Áú¹â");
			SetAction(26,"ºüÑý_Æï³Ë_°²ÈçÉ½");
			SetAction(27,"ÐùÔ¯_Æï³Ë_¼ÓËÙ");
			SetAction(28,"»³¹â_Æï³Ë_¾£¼¬");
			SetAction(29,"ÊÞÉñ_Æï³Ë_Áú¹â");
			SetAction(30,"Ìì»ª_Æï³Ë_¾£¼¬");
			name = "ÌìÂíÐÐ¿Õ";
			nativename = "ÌìÂíÐÐ¿Õ";
			icon = "ÌìÂíÐÐ¿Õ.dds";
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
	}
	public class GSkill5342 : GSkill
	{
		public GSkill5342()
			: base(5342)
		{
			
		}
	}
	public class GSkill5343Stub : GSkillStub
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
		public GSkill5343Stub()
			: base(5343)
		{
			occupation = 129;
			maxlevel = 5;
			maxlearn = 5;
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
			name = "ÕÙ»½-Ð¡Âí¸ç";
			nativename = "ÕÙ»½-Ð¡Âí¸ç";
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
	}
	public class GSkill5343 : GSkill
	{
		public GSkill5343()
			: base(5343)
		{
			
		}
	}
	public class GSkill5344Stub : GSkillStub
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
		public GSkill5344Stub()
			: base(5344)
		{
			occupation = 128;
			maxlevel = 1;
			maxlearn = 1;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 2;
			timetype = 0;
			targettype = 0;
			rangetype = 7;
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
			name = "ÕÙ»½-Ð¡Âí¸ç¿¹ÐÔÔöÒæ";
			nativename = "ÕÙ»½-Ð¡Âí¸ç¿¹ÐÔÔöÒæ";
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
			return 1800000;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 30.000000f;
		}
	}
	public class GSkill5344 : GSkill
	{
		public GSkill5344()
			: base(5344)
		{
			
		}
	}
	public class GSkill5345Stub : GSkillStub
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
		public GSkill5345Stub()
			: base(5345)
		{
			occupation = 128;
			maxlevel = 1;
			maxlearn = 1;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 1;
			timetype = 0;
			targettype = 0;
			rangetype = 14;
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
			SetAction(0,"ÇàÔÆÃÅ_¶¯Îï²¶×½");
			SetAction(1,"ÇàÔÆÃÅ_¶¯Îï²¶×½");
			SetAction(2,"¹íÍõ×Ú_¶¯Îï²¶×½");
			SetAction(3,"ºÏ»¶ÅÉ_¶¯Îï²¶×½");
			SetAction(4,"ÌìÒôËÂ_¶¯Îï²¶×½");
			SetAction(5,"¹íµÀ_¶¯Îï²¶×½");
			SetAction(6,"ÇàÔÆÃÅ_¶¯Îï²¶×½");
			SetAction(7,"ÊÞÉñ_¶¯Îï²¶×½");
			SetAction(8,"ºüÑý_¶¯Îï²¶×½");
			SetAction(9,"ÊÞÉñ_¶¯Îï²¶×½");
			SetAction(10,"»³¹â_¶¯Îï²¶×½");
			SetAction(11,"ÊÞÉñ_¶¯Îï²¶×½");
			SetAction(12,"Ìì»ª_¶¯Îï²¶×½");
			SetAction(13,"ÁéÙí_¶¯Îï²¶×½");
			SetAction(14,"Ó¢ÕÐ_¶¯Îï²¶×½");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"ÇàÔÆÃÅ_Æï³Ë_¶¯Îï²¶×½");
			SetAction(19,"ÇàÔÆÃÅ_Æï³Ë_¶¯Îï²¶×½");
			SetAction(20,"¹íÍõ×Ú_Æï³Ë_¶¯Îï²¶×½");
			SetAction(21,"ºÏ»¶ÅÉ_Æï³Ë_¶¯Îï²¶×½");
			SetAction(22,"ÌìÒôËÂ_Æï³Ë_¶¯Îï²¶×½");
			SetAction(23,"¹íµÀ_Æï³Ë_¶¯Îï²¶×½");
			SetAction(24,"ÇàÔÆÃÅ_Æï³Ë_¶¯Îï²¶×½");
			SetAction(25,"ÊÞÉñ_Æï³Ë_¶¯Îï²¶×½");
			SetAction(26,"ºüÑý_Æï³Ë_¶¯Îï²¶×½");
			SetAction(27,"ÊÞÉñ_Æï³Ë_¶¯Îï²¶×½");
			SetAction(28,"»³¹â_Æï³Ë_¶¯Îï²¶×½");
			SetAction(29,"ÊÞÉñ_Æï³Ë_¶¯Îï²¶×½");
			SetAction(30,"Ìì»ª_Æï³Ë_¶¯Îï²¶×½");
			name = "²¶Óã";
			nativename = "²¶Óã";
			icon = "ÃüÔËÖ®¹â.dds";
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
			return 3000;
		}
		public override float GetRadius(GSkill skill)
		{
			return 20.000000f;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 18.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 15.000000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 30.000000f;
		}
	}
	public class GSkill5345 : GSkill
	{
		public GSkill5345()
			: base(5345)
		{
			
		}
	}
	public class GSkill5346Stub : GSkillStub
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
		public GSkill5346Stub()
			: base(5346)
		{
			occupation = 151;
			maxlevel = 3;
			maxlearn = 3;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 3;
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
			SetAction(0,"¹íÍõ×Ú_Ðé¿ÕÕ¶");
			SetAction(1,"¹íÍõ×Ú_Ðé¿ÕÕ¶");
			SetAction(2,"¹íÍõ×Ú_Ðé¿ÕÕ¶");
			SetAction(3,"¹íÍõ×Ú_Ðé¿ÕÕ¶");
			SetAction(4,"¹íÍõ×Ú_Ðé¿ÕÕ¶");
			SetAction(5,"¹íÍõ×Ú_Ðé¿ÕÕ¶");
			SetAction(6,"¹íÍõ×Ú_Ðé¿ÕÕ¶");
			SetAction(7,"ÊÞÉñ_ºáÐÐ");
			SetAction(8,"ºüÑý_¹ÌÔªÊõ");
			SetAction(9,"ÐùÔ¯_·Éµ¯");
			SetAction(10,"»³¹â_ÍµÏ®");
			SetAction(11,"Ì«ê»_¼ÓËÙ");
			SetAction(12,"Ìì»ª_³õÔªÒôÈÐ");
			SetAction(13,"ÁéÙí_¾£¼¬");
			SetAction(14,"Ó¢ÕÐ_¾£¼¬");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"¹íÍõ×Ú_Æï³Ë_Ðé¿ÕÕ¶");
			SetAction(19,"¹íÍõ×Ú_Æï³Ë_Ðé¿ÕÕ¶");
			SetAction(20,"¹íÍõ×Ú_Æï³Ë_Ðé¿ÕÕ¶");
			SetAction(21,"¹íÍõ×Ú_Æï³Ë_Ðé¿ÕÕ¶");
			SetAction(22,"¹íÍõ×Ú_Æï³Ë_Ðé¿ÕÕ¶");
			SetAction(23,"¹íÍõ×Ú_Æï³Ë_Ðé¿ÕÕ¶");
			SetAction(24,"¹íÍõ×Ú_Æï³Ë_Ðé¿ÕÕ¶");
			SetAction(25,"ÊÞÉñ_Æï³Ë_ºáÐÐ");
			SetAction(26,"ºüÑý_Æï³Ë_¹ÌÔªÊõ");
			SetAction(27,"ÐùÔ¯_Æï³Ë_·Éµ¯");
			SetAction(28,"»³¹â_Æï³Ë_ÍµÏ®");
			SetAction(29,"Ì«ê»_Æï³Ë_¼ÓËÙ");
			SetAction(30,"Ìì»ª_Æï³Ë_³õÔªÒôÈÐ");
			name = "Ê®µîÑÖÂÞ";
			nativename = "Ê®µîÑÖÂÞ";
			icon = "ÌìºÓ.dds";
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
			return 9.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 7.000000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 13.000000f;
		}
	}
	public class GSkill5346 : GSkill
	{
		public GSkill5346()
			: base(5346)
		{
			
		}
	}
	public class GSkill5347Stub : GSkillStub
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
		public GSkill5347Stub()
			: base(5347)
		{
			occupation = 151;
			maxlevel = 3;
			maxlearn = 3;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 3;
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
			SetAction(0,"¹íÍõ×Ú_Ðé¿ÕÕ¶");
			SetAction(1,"¹íÍõ×Ú_Ðé¿ÕÕ¶");
			SetAction(2,"¹íÍõ×Ú_Ðé¿ÕÕ¶");
			SetAction(3,"¹íÍõ×Ú_Ðé¿ÕÕ¶");
			SetAction(4,"¹íÍõ×Ú_Ðé¿ÕÕ¶");
			SetAction(5,"¹íÍõ×Ú_Ðé¿ÕÕ¶");
			SetAction(6,"¹íÍõ×Ú_Ðé¿ÕÕ¶");
			SetAction(7,"ÊÞÉñ_ºáÐÐ");
			SetAction(8,"ºüÑý_¹ÌÔªÊõ");
			SetAction(9,"ÐùÔ¯_·Éµ¯");
			SetAction(10,"»³¹â_ÍµÏ®");
			SetAction(11,"Ì«ê»_¼ÓËÙ");
			SetAction(12,"Ìì»ª_³õÔªÒôÈÐ");
			SetAction(13,"ÁéÙí_¾£¼¬");
			SetAction(14,"Ó¢ÕÐ_¾£¼¬");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"¹íÍõ×Ú_Æï³Ë_Ðé¿ÕÕ¶");
			SetAction(19,"¹íÍõ×Ú_Æï³Ë_Ðé¿ÕÕ¶");
			SetAction(20,"¹íÍõ×Ú_Æï³Ë_Ðé¿ÕÕ¶");
			SetAction(21,"¹íÍõ×Ú_Æï³Ë_Ðé¿ÕÕ¶");
			SetAction(22,"¹íÍõ×Ú_Æï³Ë_Ðé¿ÕÕ¶");
			SetAction(23,"¹íÍõ×Ú_Æï³Ë_Ðé¿ÕÕ¶");
			SetAction(24,"¹íÍõ×Ú_Æï³Ë_Ðé¿ÕÕ¶");
			SetAction(25,"ÊÞÉñ_Æï³Ë_ºáÐÐ");
			SetAction(26,"ºüÑý_Æï³Ë_¹ÌÔªÊõ");
			SetAction(27,"ÐùÔ¯_Æï³Ë_·Éµ¯");
			SetAction(28,"»³¹â_Æï³Ë_ÍµÏ®");
			SetAction(29,"Ì«ê»_Æï³Ë_¼ÓËÙ");
			SetAction(30,"Ìì»ª_Æï³Ë_³õÔªÒôÈÐ");
			name = "¾ÅÓüÚ¤Áé";
			nativename = "¾ÅÓüÚ¤Áé";
			icon = "Ç§Äê.dds";
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
			return 9.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 7.000000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 13.000000f;
		}
	}
	public class GSkill5347 : GSkill
	{
		public GSkill5347()
			: base(5347)
		{
			
		}
	}
	public class GSkill5348Stub : GSkillStub
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
		public GSkill5348Stub()
			: base(5348)
		{
			occupation = 151;
			maxlevel = 3;
			maxlearn = 3;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 3;
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
			SetAction(0,"¹íÍõ×Ú_Ðé¿ÕÕ¶");
			SetAction(1,"¹íÍõ×Ú_Ðé¿ÕÕ¶");
			SetAction(2,"¹íÍõ×Ú_Ðé¿ÕÕ¶");
			SetAction(3,"¹íÍõ×Ú_Ðé¿ÕÕ¶");
			SetAction(4,"¹íÍõ×Ú_Ðé¿ÕÕ¶");
			SetAction(5,"¹íÍõ×Ú_Ðé¿ÕÕ¶");
			SetAction(6,"¹íÍõ×Ú_Ðé¿ÕÕ¶");
			SetAction(7,"ÊÞÉñ_ºáÐÐ");
			SetAction(8,"ºüÑý_¹ÌÔªÊõ");
			SetAction(9,"ÐùÔ¯_·Éµ¯");
			SetAction(10,"»³¹â_ÍµÏ®");
			SetAction(11,"Ì«ê»_¼ÓËÙ");
			SetAction(12,"Ìì»ª_³õÔªÒôÈÐ");
			SetAction(13,"ÁéÙí_¾£¼¬");
			SetAction(14,"Ó¢ÕÐ_¾£¼¬");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"¹íÍõ×Ú_Æï³Ë_Ðé¿ÕÕ¶");
			SetAction(19,"¹íÍõ×Ú_Æï³Ë_Ðé¿ÕÕ¶");
			SetAction(20,"¹íÍõ×Ú_Æï³Ë_Ðé¿ÕÕ¶");
			SetAction(21,"¹íÍõ×Ú_Æï³Ë_Ðé¿ÕÕ¶");
			SetAction(22,"¹íÍõ×Ú_Æï³Ë_Ðé¿ÕÕ¶");
			SetAction(23,"¹íÍõ×Ú_Æï³Ë_Ðé¿ÕÕ¶");
			SetAction(24,"¹íÍõ×Ú_Æï³Ë_Ðé¿ÕÕ¶");
			SetAction(25,"ÊÞÉñ_Æï³Ë_ºáÐÐ");
			SetAction(26,"ºüÑý_Æï³Ë_¹ÌÔªÊõ");
			SetAction(27,"ÐùÔ¯_Æï³Ë_·Éµ¯");
			SetAction(28,"»³¹â_Æï³Ë_ÍµÏ®");
			SetAction(29,"Ì«ê»_Æï³Ë_¼ÓËÙ");
			SetAction(30,"Ìì»ª_Æï³Ë_³õÔªÒôÈÐ");
			name = "Æß»êË÷Ãü";
			nativename = "Æß»êË÷Ãü";
			icon = "»ÓÈ÷.dds";
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
			return 120000;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 9.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 7.000000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 13.000000f;
		}
	}
	public class GSkill5348 : GSkill
	{
		public GSkill5348()
			: base(5348)
		{
			
		}
	}
	public class GSkill5349Stub : GSkillStub
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
		public GSkill5349Stub()
			: base(5349)
		{
			occupation = 128;
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
			name = "Õ½³¡¶áÆì";
			nativename = "Õ½³¡¶áÆì";
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
	}
	public class GSkill5349 : GSkill
	{
		public GSkill5349()
			: base(5349)
		{
			
		}
	}
}
