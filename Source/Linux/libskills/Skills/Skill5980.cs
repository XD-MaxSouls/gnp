using System;
using System.Text;

namespace SKILL
{
	public class GSkill5980Stub : GSkillStub
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
		public GSkill5980Stub()
			: base(5980)
		{
			occupation = 188;
			maxlevel = 100;
			maxlearn = 100;
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
			SetAction(15,"0");
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
			name = "À×Öù_À×µç¹¥»÷";
			nativename = "À×Öù_À×µç¹¥»÷";
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
			return 5200;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 15.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 12.000000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 16.000000f;
		}
	}
	public class GSkill5980 : GSkill
	{
		public GSkill5980()
			: base(5980)
		{
			
		}
	}
	public class GSkill5981Stub : GSkillStub
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
		public GSkill5981Stub()
			: base(5981)
		{
			occupation = 188;
			maxlevel = 100;
			maxlearn = 100;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 3;
			timetype = 0;
			targettype = 0;
			rangetype = 3;
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
			SetAction(15,"0");
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
			name = "ÑýÊÞ_×çÖä";
			nativename = "ÑýÊÞ_×çÖä";
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
			return 600;
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
			return 20.000000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 40.000000f;
		}
	}
	public class GSkill5981 : GSkill
	{
		public GSkill5981()
			: base(5981)
		{
			
		}
	}
	public class GSkill5982Stub : GSkillStub
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
		public GSkill5982Stub()
			: base(5982)
		{
			occupation = 188;
			maxlevel = 100;
			maxlearn = 100;
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
			SetAction(15,"0");
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
			name = "ÑýÊÞ_×£¸£";
			nativename = "ÑýÊÞ_×£¸£";
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
			return 600;
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
	}
	public class GSkill5982 : GSkill
	{
		public GSkill5982()
			: base(5982)
		{
			
		}
	}
	public class GSkill5983Stub : GSkillStub
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
		public GSkill5983Stub()
			: base(5983)
		{
			occupation = 188;
			maxlevel = 100;
			maxlearn = 100;
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
			SetAction(15,"0");
			SetAction(16,"0");
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
			name = "BOSSÊ´¹ÇÉñ½«_µþ¼Ó¹¥»÷";
			nativename = "BOSSÊ´¹ÇÉñ½«_µþ¼Ó¹¥»÷";
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
		public override float GetPraydistance(GSkill skill)
		{
			return 12.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 10.000000f;
		}
	}
	public class GSkill5983 : GSkill
	{
		public GSkill5983()
			: base(5983)
		{
			
		}
	}
	public class GSkill5984Stub : GSkillStub
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
		public GSkill5984Stub()
			: base(5984)
		{
			occupation = 188;
			maxlevel = 100;
			maxlearn = 100;
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
			skill_limit = 6;
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
			name = "BOSS¹í³µ_Èº¹¥×£¸£";
			nativename = "BOSS¹í³µ_Èº¹¥×£¸£";
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
			return 600;
		}
		public override float GetRadius(GSkill skill)
		{
			return 30.000000f;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 25.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 20.000000f;
		}
	}
	public class GSkill5984 : GSkill
	{
		public GSkill5984()
			: base(5984)
		{
			
		}
	}
	public class GSkill5985Stub : GSkillStub
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
		public GSkill5985Stub()
			: base(5985)
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
			rangetype = 0;
			doenchant = true;
			dobless = false;
			autoattack = false;
			allowform = 0;
			credittype = 0;
			clearmask = 0;
			skill_limit = 30;
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
			SetAction(0,"¹íÍõ×Ú_Ç¬À¤Õ¶");
			SetAction(1,"ÇàÔÆÃÅ_Ç¬À¤Õ¶");
			SetAction(2,"¹íÍõ×Ú_Ç¬À¤Õ¶");
			SetAction(3,"ºÏ»¶ÅÉ_Ç¬À¤Õ¶");
			SetAction(4,"ÌìÒôËÂ_Ç¬À¤Õ¶");
			SetAction(5,"¹íµÀ_Ç¬À¤Õ¶");
			SetAction(6,"·ÙÏã¹È_»ðá÷»¤Ö÷");
			SetAction(7,"ÊÞÉñ_ºáÐÐ");
			SetAction(8,"ºüÑý_¹ÌÔªÊõ");
			SetAction(9,"ÐùÔ¯_¹â·Éµ¯");
			SetAction(10,"»³¹â_ÍµÏ®");
			SetAction(11,"Ì«ê»_´¸»÷");
			SetAction(12,"Ìì»ª_³õÔªÒôÈÐ");
			SetAction(13,"ÁéÙí_¼á¶Ü");
			SetAction(14,"Ó¢ÕÐ_¼á¶Ü");
			SetAction(15,"ÎäÆ÷´óÊ¦_µ¶ÉÁ");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"¹íÍõ×Ú_Æï³Ë_Ç¬À¤Õ¶");
			SetAction(19,"ÇàÔÆÃÅ_Æï³Ë_Ç¬À¤Õ¶");
			SetAction(20,"¹íÍõ×Ú_Æï³Ë_Ç¬À¤Õ¶");
			SetAction(21,"ºÏ»¶ÅÉ_Æï³Ë_Ç¬À¤Õ¶");
			SetAction(22,"ÌìÒôËÂ_Æï³Ë_Ç¬À¤Õ¶");
			SetAction(23,"¹íµÀ_Æï³Ë_Ç¬À¤Õ¶");
			SetAction(24,"·ÙÏã¹È_Æï³Ë_»ðá÷»¤Ö÷");
			SetAction(25,"ÊÞÉñ_Æï³Ë_ºáÐÐ");
			SetAction(26,"ºüÑý_Æï³Ë_¹ÌÔªÊõ");
			SetAction(27,"ÐùÔ¯_Æï³Ë_¹â·Éµ¯");
			SetAction(28,"»³¹â_Æï³Ë_ÍµÏ®");
			SetAction(29,"Ì«ê»_Æï³Ë_´¸»÷");
			SetAction(30,"Ìì»ª_Æï³Ë_³õÔªÒôÈÐ");
			name = "É¨°Ñ";
			nativename = "É¨°Ñ";
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
			return 13000;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 6.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 5.000000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 7.000000f;
		}
	}
	public class GSkill5985 : GSkill
	{
		public GSkill5985()
			: base(5985)
		{
			
		}
	}
	public class GSkill5986Stub : GSkillStub
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
		public GSkill5986Stub()
			: base(5986)
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
			SetAction(0,"ÇàÔÆÃÅ_ËªÌìÑ©Îè");
			SetAction(1,"ÇàÔÆÃÅ_ËªÌìÑ©Îè");
			SetAction(2,"ÇàÔÆÃÅ_ËªÌìÑ©Îè");
			SetAction(3,"ÇàÔÆÃÅ_ËªÌìÑ©Îè");
			SetAction(4,"ÇàÔÆÃÅ_ËªÌìÑ©Îè");
			SetAction(5,"ÇàÔÆÃÅ_ËªÌìÑ©Îè");
			SetAction(6,"·ÙÏã¹È_³õ¼¶»ð¹¥");
			SetAction(7,"ÊÞÉñ_Ñ©ç÷Ö®±ùËª");
			SetAction(8,"ºüÑý_Ñ©ç÷Ö®±ùËª");
			SetAction(9,"ÐùÔ¯_Ñ©ç÷Ö®±ùËª");
			SetAction(10,"»³¹â_Ñ©ç÷Ö®±ùËª");
			SetAction(11,"Ì«ê»_´¸»÷");
			SetAction(12,"Ìì»ª_Ñ©ç÷Ö®±ùËª");
			SetAction(13,"ÁéÙí_Ñ©ç÷Ö®±ùËª");
			SetAction(14,"Ó¢ÕÐ_Ñ©ç÷Ö®±ùËª");
			SetAction(15,"ÎäÆ÷´óÊ¦_µ¶ÉÁ");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"ÇàÔÆÃÅ_Æï³Ë_ËªÌìÑ©Îè");
			SetAction(19,"ÇàÔÆÃÅ_Æï³Ë_ËªÌìÑ©Îè");
			SetAction(20,"ÇàÔÆÃÅ_Æï³Ë_ËªÌìÑ©Îè0");
			SetAction(21,"ÇàÔÆÃÅ_Æï³Ë_ËªÌìÑ©Îè");
			SetAction(22,"ÇàÔÆÃÅ_Æï³Ë_ËªÌìÑ©Îè");
			SetAction(23,"ÇàÔÆÃÅ_Æï³Ë_ËªÌìÑ©Îè");
			SetAction(24,"·ÙÏã¹È_Æï³Ë_³õ¼¶»ð¹¥");
			SetAction(25,"ÊÞÉñ_Æï³Ë_Ñ©ç÷Ö®±ùËª");
			SetAction(26,"ºüÑý_Æï³Ë_Ñ©ç÷Ö®±ùËª");
			SetAction(27,"ÐùÔ¯_Æï³Ë_Ñ©ç÷Ö®±ùËª");
			SetAction(28,"»³¹â_Æï³Ë_Ñ©ç÷Ö®±ùËª");
			SetAction(29,"Ì«ê»_Æï³Ë_´¸»÷");
			SetAction(30,"Ìì»ª_Æï³Ë_Ñ©ç÷Ö®±ùËª");
			name = "²âÊÔ·ÀÊØ";
			nativename = "²âÊÔ·ÀÊØ";
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
			return 8000;
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
	public class GSkill5986 : GSkill
	{
		public GSkill5986()
			: base(5986)
		{
			
		}
	}
	public class GSkill5987Stub : GSkillStub
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
		public GSkill5987Stub()
			: base(5987)
		{
			occupation = 129;
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
			skill_limit = 30;
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
			SetAction(0,"¹íÍõ×Ú_Ç¬À¤Õ¶");
			SetAction(1,"ÇàÔÆÃÅ_Ç¬À¤Õ¶");
			SetAction(2,"¹íÍõ×Ú_Ç¬À¤Õ¶");
			SetAction(3,"ºÏ»¶ÅÉ_Ç¬À¤Õ¶");
			SetAction(4,"ÌìÒôËÂ_Ç¬À¤Õ¶");
			SetAction(5,"¹íµÀ_Ç¬À¤Õ¶");
			SetAction(6,"·ÙÏã¹È_»ðá÷»¤Ö÷");
			SetAction(7,"ÊÞÉñ_ºáÐÐ");
			SetAction(8,"ºüÑý_¹ÌÔªÊõ");
			SetAction(9,"ÐùÔ¯_¹â·Éµ¯");
			SetAction(10,"»³¹â_ÍµÏ®");
			SetAction(11,"Ì«ê»_´¸»÷");
			SetAction(12,"Ìì»ª_³õÔªÒôÈÐ");
			SetAction(13,"ÁéÙí_¼á¶Ü");
			SetAction(14,"Ó¢ÕÐ_¼á¶Ü");
			SetAction(15,"ÎäÆ÷´óÊ¦_µ¶ÉÁ");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"¹íÍõ×Ú_Æï³Ë_Ç¬À¤Õ¶");
			SetAction(19,"ÇàÔÆÃÅ_Æï³Ë_Ç¬À¤Õ¶");
			SetAction(20,"¹íÍõ×Ú_Æï³Ë_Ç¬À¤Õ¶");
			SetAction(21,"ºÏ»¶ÅÉ_Æï³Ë_Ç¬À¤Õ¶");
			SetAction(22,"ÌìÒôËÂ_Æï³Ë_Ç¬À¤Õ¶");
			SetAction(23,"¹íµÀ_Æï³Ë_Ç¬À¤Õ¶");
			SetAction(24,"·ÙÏã¹È_Æï³Ë_»ðá÷»¤Ö÷");
			SetAction(25,"ÊÞÉñ_Æï³Ë_ºáÐÐ");
			SetAction(26,"ºüÑý_Æï³Ë_¹ÌÔªÊõ");
			SetAction(27,"ÐùÔ¯_Æï³Ë_¹â·Éµ¯");
			SetAction(28,"»³¹â_Æï³Ë_ÍµÏ®");
			SetAction(29,"Ì«ê»_´¸»÷");
			SetAction(30,"Ìì»ª_Æï³Ë_³õÔªÒôÈÐ");
			name = "²ù×Ó";
			nativename = "²ù×Ó";
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
			return 2000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			return 60000;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 6.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 5.000000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 7.000000f;
		}
	}
	public class GSkill5987 : GSkill
	{
		public GSkill5987()
			: base(5987)
		{
			
		}
	}
	public class GSkill5988Stub : GSkillStub
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
		public GSkill5988Stub()
			: base(5988)
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
			rangetype = 0;
			doenchant = true;
			dobless = false;
			autoattack = false;
			allowform = 0;
			credittype = 0;
			clearmask = 0;
			skill_limit = 30;
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
			SetAction(0,"¹íÍõ×Ú_Ç¬À¤Õ¶");
			SetAction(1,"ÇàÔÆÃÅ_Ç¬À¤Õ¶");
			SetAction(2,"¹íÍõ×Ú_Ç¬À¤Õ¶");
			SetAction(3,"ºÏ»¶ÅÉ_Ç¬À¤Õ¶");
			SetAction(4,"ÌìÒôËÂ_Ç¬À¤Õ¶");
			SetAction(5,"¹íµÀ_Ç¬À¤Õ¶");
			SetAction(6,"·ÙÏã¹È_»ðá÷»¤Ö÷");
			SetAction(7,"ÊÞÉñ_ºáÐÐ");
			SetAction(8,"ºüÑý_¹ÌÔªÊõ");
			SetAction(9,"ÐùÔ¯_¹â·Éµ¯");
			SetAction(10,"»³¹â_ÍµÏ®");
			SetAction(11,"Ì«ê»_´¸»÷");
			SetAction(12,"Ìì»ª_³õÔªÒôÈÐ");
			SetAction(13,"ÁéÙí_¼á¶Ü");
			SetAction(14,"Ó¢ÕÐ_¼á¶Ü");
			SetAction(15,"ÎäÆ÷´óÊ¦_µ¶ÉÁ");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"¹íÍõ×Ú_Æï³Ë_Ç¬À¤Õ¶");
			SetAction(19,"ÇàÔÆÃÅ_Æï³Ë_Ç¬À¤Õ¶");
			SetAction(20,"¹íÍõ×Ú_Æï³Ë_Ç¬À¤Õ¶");
			SetAction(21,"ºÏ»¶ÅÉ_Æï³Ë_Ç¬À¤Õ¶");
			SetAction(22,"ÌìÒôËÂ_Æï³Ë_Ç¬À¤Õ¶");
			SetAction(23,"¹íµÀ_Æï³Ë_Ç¬À¤Õ¶");
			SetAction(24,"·ÙÏã¹È_Æï³Ë_»ðá÷»¤Ö÷");
			SetAction(25,"ÊÞÉñ_Æï³Ë_ºáÐÐ");
			SetAction(26,"ºüÑý_Æï³Ë_¹ÌÔªÊõ");
			SetAction(27,"ÐùÔ¯_Æï³Ë_¹â·Éµ¯");
			SetAction(28,"»³¹â_Æï³Ë_ÍµÏ®");
			SetAction(29,"Ì«ê»_´¸»÷");
			SetAction(30,"Ìì»ª_Æï³Ë_³õÔªÒôÈÐ");
			name = "Ä¨²¼";
			nativename = "Ä¨²¼";
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
			return 10000;
		}
		public override int GetEnmity(GSkill skill)
		{
			return 1;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 6.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 5.000000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 7.000000f;
		}
	}
	public class GSkill5988 : GSkill
	{
		public GSkill5988()
			: base(5988)
		{
			
		}
	}
	public class GSkill5989Stub : GSkillStub
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
		public GSkill5989Stub()
			: base(5989)
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
			doenchant = false;
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
			SetAction(15,"0");
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
			name = "¹ÖÎïÎÞµÐÐ¡Ê÷×¨ÓÃ";
			nativename = "¹ÖÎïÎÞµÐÐ¡Ê÷×¨ÓÃ";
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
		public override float GetEffectdistance(GSkill skill)
		{
			return 25.000000f;
		}
	}
	public class GSkill5989 : GSkill
	{
		public GSkill5989()
			: base(5989)
		{
			
		}
	}
}
