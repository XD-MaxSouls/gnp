using System;
using System.Text;

namespace SKILL
{
	public class GSkill5660Stub : GSkillStub
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
		public GSkill5660Stub()
			: base(5660)
		{
			occupation = 164;
			maxlevel = 20;
			maxlearn = 10;
			eventflag = 0;
			spcost = 0;
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
			skill_limit = 14;
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
			SetAction(0,"·ÙÏã¹È_ÖĞ¼¶»ğ¹¥");
			SetAction(1,"·ÙÏã¹È_ÖĞ¼¶»ğ¹¥");
			SetAction(2,"·ÙÏã¹È_ÖĞ¼¶»ğ¹¥");
			SetAction(3,"·ÙÏã¹È_ÖĞ¼¶»ğ¹¥");
			SetAction(4,"·ÙÏã¹È_ÖĞ¼¶»ğ¹¥");
			SetAction(5,"·ÙÏã¹È_ÖĞ¼¶»ğ¹¥");
			SetAction(6,"·ÙÏã¹È_ÖĞ¼¶»ğ¹¥");
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
			SetAction(18,"·ÙÏã¹È_Æï³Ë_ÖĞ¼¶»ğ¹¥");
			SetAction(19,"·ÙÏã¹È_Æï³Ë_ÖĞ¼¶»ğ¹¥");
			SetAction(20,"·ÙÏã¹È_Æï³Ë_ÖĞ¼¶»ğ¹¥");
			SetAction(21,"·ÙÏã¹È_Æï³Ë_ÖĞ¼¶»ğ¹¥");
			SetAction(22,"·ÙÏã¹È_Æï³Ë_ÖĞ¼¶»ğ¹¥");
			SetAction(23,"·ÙÏã¹È_Æï³Ë_ÖĞ¼¶»ğ¹¥");
			SetAction(24,"·ÙÏã¹È_Æï³Ë_ÖĞ¼¶»ğ¹¥");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "Ñ£»ğ¡¤ÑæÏ®";
			nativename = "Ñ£»ğ¡¤ÑæÏ®";
			icon = "ÁÒÑæÏ®.dds";
			SetTalent(0,3378);
			SetTalent(1,3380);
			SetTalent(2,3751);
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
			skill_class = 9;
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
			return 5400;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 11.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 9.000000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 14.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			return 110.000000f;
		}
	}
	public class GSkill5660 : GSkill
	{
		public GSkill5660()
			: base(5660)
		{
			
		}
	}
	public class GSkill5661Stub : GSkillStub
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
		public GSkill5661Stub()
			: base(5661)
		{
			occupation = 164;
			maxlevel = 20;
			maxlearn = 10;
			eventflag = 0;
			spcost = 0;
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
			skill_limit = 14;
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
			SetAction(0,"·ÙÏã¹È_ÈıÎ¶Õæ»ğ");
			SetAction(1,"·ÙÏã¹È_ÈıÎ¶Õæ»ğ");
			SetAction(2,"·ÙÏã¹È_ÈıÎ¶Õæ»ğ");
			SetAction(3,"·ÙÏã¹È_ÈıÎ¶Õæ»ğ");
			SetAction(4,"·ÙÏã¹È_ÈıÎ¶Õæ»ğ");
			SetAction(5,"·ÙÏã¹È_ÈıÎ¶Õæ»ğ");
			SetAction(6,"·ÙÏã¹È_ÈıÎ¶Õæ»ğ");
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
			SetAction(18,"·ÙÏã¹È_Æï³Ë_ÈıÎ¶Õæ»ğ");
			SetAction(19,"·ÙÏã¹È_Æï³Ë_ÈıÎ¶Õæ»ğ");
			SetAction(20,"·ÙÏã¹È_Æï³Ë_ÈıÎ¶Õæ»ğ");
			SetAction(21,"·ÙÏã¹È_Æï³Ë_ÈıÎ¶Õæ»ğ");
			SetAction(22,"·ÙÏã¹È_Æï³Ë_ÈıÎ¶Õæ»ğ");
			SetAction(23,"·ÙÏã¹È_Æï³Ë_ÈıÎ¶Õæ»ğ");
			SetAction(24,"·ÙÏã¹È_Æï³Ë_ÈıÎ¶Õæ»ğ");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "Ñ£»ğ¡¤ÈıÃÁ";
			nativename = "Ñ£»ğ¡¤ÈıÃÁ";
			icon = "ÈıÎ¶Õæ»ğ.dds";
			SetTalent(0,3384);
			SetTalent(1,3383);
			SetTalent(2,3751);
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
			skill_class = 9;
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
			return 5850;
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
			return 16.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			return 132.000000f;
		}
	}
	public class GSkill5661 : GSkill
	{
		public GSkill5661()
			: base(5661)
		{
			
		}
	}
	public class GSkill5662Stub : GSkillStub
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
		public GSkill5662Stub()
			: base(5662)
		{
			occupation = 164;
			maxlevel = 20;
			maxlearn = 10;
			eventflag = 0;
			spcost = 0;
			reborncount = 0;
			type = 1;
			timetype = 0;
			targettype = 0;
			rangetype = 2;
			doenchant = true;
			dobless = false;
			autoattack = false;
			allowform = 0;
			credittype = 0;
			clearmask = 0;
			skill_limit = 14;
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
			SetAction(0,"·ÙÏã¹È_×ÆÉÕ³Í½ä");
			SetAction(1,"·ÙÏã¹È_×ÆÉÕ³Í½ä");
			SetAction(2,"·ÙÏã¹È_×ÆÉÕ³Í½ä");
			SetAction(3,"·ÙÏã¹È_×ÆÉÕ³Í½ä");
			SetAction(4,"·ÙÏã¹È_×ÆÉÕ³Í½ä");
			SetAction(5,"·ÙÏã¹È_×ÆÉÕ³Í½ä");
			SetAction(6,"·ÙÏã¹È_×ÆÉÕ³Í½ä");
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
			SetAction(18,"·ÙÏã¹È_Æï³Ë_×ÆÉÕ³Í½ä");
			SetAction(19,"·ÙÏã¹È_Æï³Ë_×ÆÉÕ³Í½ä");
			SetAction(20,"·ÙÏã¹È_Æï³Ë_×ÆÉÕ³Í½ä");
			SetAction(21,"·ÙÏã¹È_Æï³Ë_×ÆÉÕ³Í½ä");
			SetAction(22,"·ÙÏã¹È_Æï³Ë_×ÆÉÕ³Í½ä");
			SetAction(23,"·ÙÏã¹È_Æï³Ë_×ÆÉÕ³Í½ä");
			SetAction(24,"·ÙÏã¹È_Æï³Ë_×ÆÉÕ³Í½ä");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "Ñ£»ğ¡¤¾ø³¾";
			nativename = "Ñ£»ğ¡¤¾ø³¾";
			icon = "¾ø³¾ÁùºÏ.dds";
			SetTalent(0,3386);
			SetTalent(1,3751);
			SetTalent(2,3752);
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
			skill_class = 9;
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
			return 4000;
		}
		public override float GetRadius(GSkill skill)
		{
			return 14.500000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			return 154.000000f;
		}
	}
	public class GSkill5662 : GSkill
	{
		public GSkill5662()
			: base(5662)
		{
			
		}
	}
	public class GSkill5663Stub : GSkillStub
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
		public GSkill5663Stub()
			: base(5663)
		{
			occupation = 164;
			maxlevel = 20;
			maxlearn = 10;
			eventflag = 0;
			spcost = 0;
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
			skill_limit = 14;
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
			SetAction(0,"·ÙÏã¹È_ÄùÅÌ»ØÌì");
			SetAction(1,"·ÙÏã¹È_ÄùÅÌ»ØÌì");
			SetAction(2,"·ÙÏã¹È_ÄùÅÌ»ØÌì");
			SetAction(3,"·ÙÏã¹È_ÄùÅÌ»ØÌì");
			SetAction(4,"·ÙÏã¹È_ÄùÅÌ»ØÌì");
			SetAction(5,"·ÙÏã¹È_ÄùÅÌ»ØÌì");
			SetAction(6,"·ÙÏã¹È_ÄùÅÌ»ØÌì");
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
			SetAction(18,"·ÙÏã¹È_Æï³Ë_ÄùÅÌ»ØÌì");
			SetAction(19,"·ÙÏã¹È_Æï³Ë_ÄùÅÌ»ØÌì");
			SetAction(20,"·ÙÏã¹È_Æï³Ë_ÄùÅÌ»ØÌì");
			SetAction(21,"·ÙÏã¹È_Æï³Ë_ÄùÅÌ»ØÌì");
			SetAction(22,"·ÙÏã¹È_Æï³Ë_ÄùÅÌ»ØÌì");
			SetAction(23,"·ÙÏã¹È_Æï³Ë_ÄùÅÌ»ØÌì");
			SetAction(24,"·ÙÏã¹È_Æï³Ë_ÄùÅÌ»ØÌì");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "Ñ£»ğ¡¤Äù˜„";
			nativename = "Ñ£»ğ¡¤Äù˜„";
			icon = "ÄùÅÌÖØÉú.dds";
			SetTalent(0,3420);
			SetTalent(1,3423);
			SetTalent(2,3759);
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
			skill_class = 9;
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
		public override float GetMpcost(GSkill skill)
		{
			return 176.000000f;
		}
	}
	public class GSkill5663 : GSkill
	{
		public GSkill5663()
			: base(5663)
		{
			
		}
	}
	public class GSkill5664Stub : GSkillStub
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
		public GSkill5664Stub()
			: base(5664)
		{
			occupation = 164;
			maxlevel = 20;
			maxlearn = 10;
			eventflag = 0;
			spcost = 0;
			reborncount = 0;
			type = 1;
			timetype = 0;
			targettype = 0;
			rangetype = 3;
			doenchant = true;
			dobless = false;
			autoattack = false;
			allowform = 0;
			credittype = 0;
			clearmask = 0;
			skill_limit = 14;
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
			SetAction(0,"·ÙÏã¹È_ÕÙ»½Ìì»ğ");
			SetAction(1,"·ÙÏã¹È_ÕÙ»½Ìì»ğ");
			SetAction(2,"·ÙÏã¹È_ÕÙ»½Ìì»ğ");
			SetAction(3,"·ÙÏã¹È_ÕÙ»½Ìì»ğ");
			SetAction(4,"·ÙÏã¹È_ÕÙ»½Ìì»ğ");
			SetAction(5,"·ÙÏã¹È_ÕÙ»½Ìì»ğ");
			SetAction(6,"·ÙÏã¹È_ÕÙ»½Ìì»ğ");
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
			SetAction(18,"·ÙÏã¹È_Æï³Ë_ÕÙ»½Ìì»ğ");
			SetAction(19,"·ÙÏã¹È_Æï³Ë_ÕÙ»½Ìì»ğ");
			SetAction(20,"·ÙÏã¹È_Æï³Ë_ÕÙ»½Ìì»ğ");
			SetAction(21,"·ÙÏã¹È_Æï³Ë_ÕÙ»½Ìì»ğ");
			SetAction(22,"·ÙÏã¹È_Æï³Ë_ÕÙ»½Ìì»ğ");
			SetAction(23,"·ÙÏã¹È_Æï³Ë_ÕÙ»½Ìì»ğ");
			SetAction(24,"·ÙÏã¹È_Æï³Ë_ÕÙ»½Ìì»ğ");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "Ñ£»ğ¡¤Á¶Óü";
			nativename = "Ñ£»ğ¡¤Á¶Óü";
			icon = "Á¶Óü½Ù²¨.dds";
			SetTalent(0,3418);
			SetTalent(1,3420);
			SetTalent(2,3751);
			SetTalent(3,3752);
			SetTalent(4,0);
			SetTalent(5,0);
			SetTalent(6,0);
			SetTalent(7,0);
			talent_size = 4;
			talent_type = 0;
			use_proficiency = false;
			inc_proficiency = 0;
			preskillnum = 0;
			cycle = false;
			cyclemode = 0;
			cyclegfx = "";
			skill_class = 9;
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
			return 4000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			return 8800;
		}
		public override float GetRadius(GSkill skill)
		{
			return 12.500000f;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 15.700000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 14.000000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 18.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			return 198.000000f;
		}
	}
	public class GSkill5664 : GSkill
	{
		public GSkill5664()
			: base(5664)
		{
			
		}
	}
	public class GSkill5665Stub : GSkillStub
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
		public GSkill5665Stub()
			: base(5665)
		{
			occupation = 164;
			maxlevel = 20;
			maxlearn = 10;
			eventflag = 0;
			spcost = 0;
			reborncount = 0;
			type = 1;
			timetype = 0;
			targettype = 0;
			rangetype = 2;
			doenchant = true;
			dobless = false;
			autoattack = false;
			allowform = 0;
			credittype = 0;
			clearmask = 0;
			skill_limit = 14;
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
			SetAction(0,"·ÙÏã¹È_ÕÙ»½ÔÉÊ¯");
			SetAction(1,"·ÙÏã¹È_ÕÙ»½ÔÉÊ¯");
			SetAction(2,"·ÙÏã¹È_ÕÙ»½ÔÉÊ¯");
			SetAction(3,"·ÙÏã¹È_ÕÙ»½ÔÉÊ¯");
			SetAction(4,"·ÙÏã¹È_ÕÙ»½ÔÉÊ¯");
			SetAction(5,"·ÙÏã¹È_ÕÙ»½ÔÉÊ¯");
			SetAction(6,"·ÙÏã¹È_ÕÙ»½ÔÉÊ¯");
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
			SetAction(18,"·ÙÏã¹È_Æï³Ë_ÕÙ»½ÔÉÊ¯");
			SetAction(19,"·ÙÏã¹È_Æï³Ë_ÕÙ»½ÔÉÊ¯");
			SetAction(20,"·ÙÏã¹È_Æï³Ë_ÕÙ»½ÔÉÊ¯");
			SetAction(21,"·ÙÏã¹È_Æï³Ë_ÕÙ»½ÔÉÊ¯");
			SetAction(22,"·ÙÏã¹È_Æï³Ë_ÕÙ»½ÔÉÊ¯");
			SetAction(23,"·ÙÏã¹È_Æï³Ë_ÕÙ»½ÔÉÊ¯");
			SetAction(24,"·ÙÏã¹È_Æï³Ë_ÕÙ»½ÔÉÊ¯");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "Ñ£»ğ¡¤ÄÏÎ×";
			nativename = "Ñ£»ğ¡¤ÄÏÎ×";
			icon = "ÄÏÎ×Ìì»ğ.dds";
			SetTalent(0,3381);
			SetTalent(1,3384);
			SetTalent(2,3389);
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
			skill_class = 9;
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
			return 5000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			return 16000;
		}
		public override float GetRadius(GSkill skill)
		{
			return 19.000000f;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 22.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 20.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			return 220.000000f;
		}
	}
	public class GSkill5665 : GSkill
	{
		public GSkill5665()
			: base(5665)
		{
			
		}
	}
	public class GSkill5666Stub : GSkillStub
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
		public GSkill5666Stub()
			: base(5666)
		{
			occupation = 165;
			maxlevel = 20;
			maxlearn = 10;
			eventflag = 0;
			spcost = 0;
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
			skill_limit = 14;
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
			weapon_limit = 11;
			SetAction(0,"Ì«ê»_Ìå¼¼2-4");
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
			SetAction(11,"Ì«ê»_Ìå¼¼2-4");
			SetAction(12,"0");
			SetAction(13,"0");
			SetAction(14,"0");
			SetAction(15,"0");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"Ì«ê»_Æï³Ë_Ìå¼¼2-4");
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
			SetAction(29,"Ì«ê»_Æï³Ë_Ìå¼¼2-4");
			SetAction(30,"0");
			name = "Îä»ê¡¤ÆÆÀÇ";
			nativename = "Îä»ê¡¤ÆÆÀÇ";
			icon = "É±ÆÆÀÇ.dds";
			SetTalent(0,3504);
			SetTalent(1,3507);
			SetTalent(2,3468);
			SetTalent(3,3469);
			SetTalent(4,3741);
			SetTalent(5,0);
			SetTalent(6,0);
			SetTalent(7,0);
			talent_size = 5;
			talent_type = 0;
			use_proficiency = false;
			inc_proficiency = 0;
			preskillnum = 0;
			cycle = false;
			cyclemode = 0;
			cyclegfx = "";
			skill_class = 10;
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
			return 5800;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 7.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 3.000000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 15.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			return 110.000000f;
		}
	}
	public class GSkill5666 : GSkill
	{
		public GSkill5666()
			: base(5666)
		{
			
		}
	}
	public class GSkill5667Stub : GSkillStub
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
		public GSkill5667Stub()
			: base(5667)
		{
			occupation = 165;
			maxlevel = 20;
			maxlearn = 10;
			eventflag = 0;
			spcost = 0;
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
			skill_limit = 14;
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
			weapon_limit = 11;
			SetAction(0,"Ì«ê»_Å­Ä¿½ğ¸ÕÖä");
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
			SetAction(11,"Ì«ê»_Å­Ä¿½ğ¸ÕÖä");
			SetAction(12,"0");
			SetAction(13,"0");
			SetAction(14,"0");
			SetAction(15,"0");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"Ì«ê»_Æï³Ë_Å­Ä¿½ğ¸ÕÖä");
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
			SetAction(29,"Ì«ê»_Æï³Ë_Å­Ä¿½ğ¸ÕÖä");
			SetAction(30,"0");
			name = "Îä»ê¡¤ÃğÊÀ";
			nativename = "Îä»ê¡¤ÃğÊÀ";
			icon = "ÃğÊÀ¶È.dds";
			SetTalent(0,3505);
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
			skill_class = 10;
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
			return 3000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			return 7200;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 7.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 3.000000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 15.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			return 132.000000f;
		}
	}
	public class GSkill5667 : GSkill
	{
		public GSkill5667()
			: base(5667)
		{
			
		}
	}
	public class GSkill5668Stub : GSkillStub
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
		public GSkill5668Stub()
			: base(5668)
		{
			occupation = 165;
			maxlevel = 20;
			maxlearn = 10;
			eventflag = 0;
			spcost = 0;
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
			skill_limit = 14;
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
			weapon_limit = 11;
			SetAction(0,"Ì«ê»_ËºÁÑ");
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
			SetAction(11,"Ì«ê»_ËºÁÑ");
			SetAction(12,"0");
			SetAction(13,"0");
			SetAction(14,"0");
			SetAction(15,"0");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"Ì«ê»_Æï³Ë_ËºÁÑ");
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
			SetAction(29,"Ì«ê»_Æï³Ë_ËºÁÑ");
			SetAction(30,"0");
			name = "Îä»ê¡¤Ñª»ê";
			nativename = "Îä»ê¡¤Ñª»ê";
			icon = "Ñª»ê½Ù.dds";
			SetTalent(0,3507);
			SetTalent(1,3478);
			SetTalent(2,3479);
			SetTalent(3,3510);
			SetTalent(4,3805);
			SetTalent(5,0);
			SetTalent(6,0);
			SetTalent(7,0);
			talent_size = 5;
			talent_type = 0;
			use_proficiency = false;
			inc_proficiency = 0;
			preskillnum = 0;
			cycle = false;
			cyclemode = 0;
			cyclegfx = "";
			skill_class = 10;
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
			return 5800;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 7.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 3.000000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 15.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			return 154.000000f;
		}
	}
	public class GSkill5668 : GSkill
	{
		public GSkill5668()
			: base(5668)
		{
			
		}
	}
	public class GSkill5669Stub : GSkillStub
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
		public GSkill5669Stub()
			: base(5669)
		{
			occupation = 165;
			maxlevel = 20;
			maxlearn = 10;
			eventflag = 0;
			spcost = 0;
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
			skill_limit = 14;
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
			weapon_limit = 11;
			SetAction(0,"Ì«ê»_À×ÉñÖ®´¥");
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
			SetAction(11,"Ì«ê»_À×ÉñÖ®´¥");
			SetAction(12,"0");
			SetAction(13,"0");
			SetAction(14,"0");
			SetAction(15,"0");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"Ì«ê»_Æï³Ë_À×ÉñÖ®´¥");
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
			SetAction(29,"Ì«ê»_Æï³Ë_À×ÉñÖ®´¥");
			SetAction(30,"0");
			name = "Îä»ê¡¤ÌÏÌì";
			nativename = "Îä»ê¡¤ÌÏÌì";
			icon = "ÌÏÌì¾¢.dds";
			SetTalent(0,3518);
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
			skill_class = 10;
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
			return 5000;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 7.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 3.000000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 15.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			return 176.000000f;
		}
	}
	public class GSkill5669 : GSkill
	{
		public GSkill5669()
			: base(5669)
		{
			
		}
	}
}
