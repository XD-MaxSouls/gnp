using System;
using System.Text;

namespace SKILL
{
	public class GSkill5350Stub : GSkillStub
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
		public GSkill5350Stub()
			: base(5350)
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
			SetAction(13,"ÁéÙí_¶¯Îï²¶×½");
			SetAction(14,"Ó¢ÕÐ_¶¯Îï²¶×½");
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
			name = "·É±¼";
			nativename = "·É±¼";
			icon = "¼¼ÄÜ-·É±¼.dds";
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
			return 6.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 5.000000f;
		}
	}
	public class GSkill5350 : GSkill
	{
		public GSkill5350()
			: base(5350)
		{
			
		}
	}
	public class GSkill5351Stub : GSkillStub
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
		public GSkill5351Stub()
			: base(5351)
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
			SetAction(0,"¹íÍõ×Ú_¾£¼¬");
			SetAction(1,"¹íÍõ×Ú_¾£¼¬");
			SetAction(2,"¹íÍõ×Ú_¾£¼¬");
			SetAction(3,"¹íÍõ×Ú_¾£¼¬");
			SetAction(4,"¹íÍõ×Ú_¾£¼¬");
			SetAction(5,"¹íÍõ×Ú_¾£¼¬");
			SetAction(6,"¹íÍõ×Ú_¾£¼¬");
			SetAction(7,"ÊÞÉñ_¾£¼¬");
			SetAction(8,"ºüÑý_¾£¼¬");
			SetAction(9,"ÐùÔ¯_¾£¼¬");
			SetAction(10,"»³¹â_¾£¼¬");
			SetAction(11,"ÊÞÉñ_¾£¼¬");
			SetAction(12,"Ìì»ª_¾£¼¬");
			SetAction(13,"ÁéÙí_¶¯Îï²¶×½");
			SetAction(14,"Ó¢ÕÐ_¶¯Îï²¶×½");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"¹íÍõ×Ú_Æï³Ë_¾£¼¬");
			SetAction(19,"¹íÍõ×Ú_Æï³Ë_¾£¼¬");
			SetAction(20,"¹íÍõ×Ú_Æï³Ë_¾£¼¬");
			SetAction(21,"¹íÍõ×Ú_Æï³Ë_¾£¼¬");
			SetAction(22,"¹íÍõ×Ú_Æï³Ë_¾£¼¬");
			SetAction(23,"¹íÍõ×Ú_Æï³Ë_¾£¼¬");
			SetAction(24,"¹íÍõ×Ú_Æï³Ë_¾£¼¬");
			SetAction(25,"ÊÞÉñ_Æï³Ë_¾£¼¬");
			SetAction(26,"ºüÑý_Æï³Ë_¾£¼¬");
			SetAction(27,"ÐùÔ¯_Æï³Ë_¾£¼¬");
			SetAction(28,"»³¹â_Æï³Ë_¾£¼¬");
			SetAction(29,"ÊÞÉñ_Æï³Ë_¾£¼¬");
			SetAction(30,"Ìì»ª_Æï³Ë_¾£¼¬");
			name = "¼áÈÍ";
			nativename = "¼áÈÍ";
			icon = "¼¼ÄÜ-¼áÈÍ.dds";
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
			return 6.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 5.000000f;
		}
	}
	public class GSkill5351 : GSkill
	{
		public GSkill5351()
			: base(5351)
		{
			
		}
	}
	public class GSkill5352Stub : GSkillStub
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
		public GSkill5352Stub()
			: base(5352)
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
			name = "Õ½³¡×´Ì¬¸ß¹¥";
			nativename = "Õ½³¡×´Ì¬¸ß¹¥";
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
	public class GSkill5352 : GSkill
	{
		public GSkill5352()
			: base(5352)
		{
			
		}
	}
	public class GSkill5353Stub : GSkillStub
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
		public GSkill5353Stub()
			: base(5353)
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
			name = "Õ½³¡×´Ì¬¼õÉË";
			nativename = "Õ½³¡×´Ì¬¼õÉË";
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
	public class GSkill5353 : GSkill
	{
		public GSkill5353()
			: base(5353)
		{
			
		}
	}
	public class GSkill5354Stub : GSkillStub
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
		public GSkill5354Stub()
			: base(5354)
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
			rangetype = 0;
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
			SetAction(5,"¹íµÀ_Ç¬À¤Õ¶");
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
			SetAction(23,"¹íµÀ_Æï³Ë_Ç¬À¤Õ¶");
			SetAction(24,"0");
			SetAction(25,"ÊÞÉñ_Æï³Ë_ºáÐÐ");
			SetAction(26,"ºüÑý_Æï³Ë_¹ÌÔªÊõ");
			SetAction(27,"0");
			SetAction(28,"»³¹â_Æï³Ë_ÍµÏ®");
			SetAction(29,"0");
			SetAction(30,"Ìì»ª_Æï³Ë_´ºÀ×");
			name = "×£¸£";
			nativename = "×£¸£";
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
			return 18000;
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
	}
	public class GSkill5354 : GSkill
	{
		public GSkill5354()
			: base(5354)
		{
			
		}
	}
	public class GSkill5355Stub : GSkillStub
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
		public GSkill5355Stub()
			: base(5355)
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
			rangetype = 0;
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
			SetAction(5,"¹íµÀ_Ç¬À¤Õ¶");
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
			SetAction(23,"¹íµÀ_Æï³Ë_Ç¬À¤Õ¶");
			SetAction(24,"0");
			SetAction(25,"ÊÞÉñ_Æï³Ë_ºáÐÐ");
			SetAction(26,"ºüÑý_Æï³Ë_¹ÌÔªÊõ");
			SetAction(27,"0");
			SetAction(28,"»³¹â_Æï³Ë_ÍµÏ®");
			SetAction(29,"0");
			SetAction(30,"Ìì»ª_Æï³Ë_´ºÀ×");
			name = "×£¸£";
			nativename = "×£¸£";
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
			return 18000;
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
	}
	public class GSkill5355 : GSkill
	{
		public GSkill5355()
			: base(5355)
		{
			
		}
	}
	public class GSkill5356Stub : GSkillStub
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
		public GSkill5356Stub()
			: base(5356)
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
			rangetype = 0;
			doenchant = true;
			dobless = false;
			autoattack = false;
			allowform = 0;
			credittype = 0;
			clearmask = 0;
			skill_limit = 23;
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
			SetAction(5,"¹íµÀ_Ç¬À¤Õ¶");
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
			SetAction(23,"¹íµÀ_Æï³Ë_Ç¬À¤Õ¶");
			SetAction(24,"0");
			SetAction(25,"ÊÞÉñ_Æï³Ë_ºáÐÐ");
			SetAction(26,"ºüÑý_Æï³Ë_¹ÌÔªÊõ");
			SetAction(27,"0");
			SetAction(28,"»³¹â_Æï³Ë_ÍµÏ®");
			SetAction(29,"0");
			SetAction(30,"Ìì»ª_Æï³Ë_´ºÀ×");
			name = "¸æ°×";
			nativename = "¸æ°×";
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
			return 18000;
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
	}
	public class GSkill5356 : GSkill
	{
		public GSkill5356()
			: base(5356)
		{
			
		}
	}
	public class GSkill5357Stub : GSkillStub
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
		public GSkill5357Stub()
			: base(5357)
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
			rangetype = 0;
			doenchant = true;
			dobless = false;
			autoattack = false;
			allowform = 0;
			credittype = 0;
			clearmask = 0;
			skill_limit = 23;
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
			SetAction(5,"¹íµÀ_Ç¬À¤Õ¶");
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
			SetAction(23,"¹íµÀ_Æï³Ë_Ç¬À¤Õ¶");
			SetAction(24,"0");
			SetAction(25,"ÊÞÉñ_Æï³Ë_ºáÐÐ");
			SetAction(26,"ºüÑý_Æï³Ë_¹ÌÔªÊõ");
			SetAction(27,"0");
			SetAction(28,"»³¹â_Æï³Ë_ÍµÏ®");
			SetAction(29,"0");
			SetAction(30,"Ìì»ª_Æï³Ë_´ºÀ×");
			name = "¸æ°×";
			nativename = "¸æ°×";
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
			return 18000;
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
	}
	public class GSkill5357 : GSkill
	{
		public GSkill5357()
			: base(5357)
		{
			
		}
	}
	public class GSkill5358Stub : GSkillStub
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
		public GSkill5358Stub()
			: base(5358)
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
			name = "ÓÞÈË½ÚÉËº¦·´µ¯";
			nativename = "ÓÞÈË½ÚÉËº¦·´µ¯";
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
			return 500;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			return 1000;
		}
	}
	public class GSkill5358 : GSkill
	{
		public GSkill5358()
			: base(5358)
		{
			
		}
	}
	public class GSkill5359Stub : GSkillStub
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
		public GSkill5359Stub()
			: base(5359)
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
			name = "ÓÞÈË½Ú¸½¼ÓÕæÆø";
			nativename = "ÓÞÈË½Ú¸½¼ÓÕæÆø";
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
			return 500;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			return 1000;
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
			return 20.000000f;
		}
	}
	public class GSkill5359 : GSkill
	{
		public GSkill5359()
			: base(5359)
		{
			
		}
	}
}
