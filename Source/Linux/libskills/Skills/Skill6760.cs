using System;
using System.Text;

namespace SKILL
{
	public class GSkill6760Stub : GSkillStub
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
		public GSkill6760Stub()
			: base(6760)
		{
			occupation = 128;
			maxlevel = 1;
			maxlearn = 0;
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
			name = "πÈ‘∆-…ÒÕ®-–«¬ÆÃ˝”Íº±ÀŸ¿‰»¥";
			nativename = "πÈ‘∆-…ÒÕ®-–«¬ÆÃ˝”Íº±ÀŸ¿‰»¥";
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
	public class GSkill6760 : GSkill
	{
		public GSkill6760()
			: base(6760)
		{
			
		}
	}
	public class GSkill6761Stub : GSkillStub
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
		public GSkill6761Stub()
			: base(6761)
		{
			occupation = 128;
			maxlevel = 10;
			maxlearn = 10;
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
			name = "πÈ‘∆-¥©¡÷¥Ú“∂II-±©ª˜¬ ";
			nativename = "πÈ‘∆-¥©¡÷¥Ú“∂II-±©ª˜¬ ";
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
	public class GSkill6761 : GSkill
	{
		public GSkill6761()
			: base(6761)
		{
			
		}
	}
	public class GSkill6762Stub : GSkillStub
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
		public GSkill6762Stub()
			: base(6762)
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
			name = "πÈ‘∆-∞◊”ÍÃ¯÷ÈII-«Âø’’Ê∆¯";
			nativename = "πÈ‘∆-∞◊”ÍÃ¯÷ÈII-«Âø’’Ê∆¯";
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
	public class GSkill6762 : GSkill
	{
		public GSkill6762()
			: base(6762)
		{
			
		}
	}
	public class GSkill6763Stub : GSkillStub
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
		public GSkill6763Stub()
			: base(6763)
		{
			occupation = 128;
			maxlevel = 10;
			maxlearn = 10;
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
			name = "πÈ‘∆-Õ©”∞ Ë∑ÁII-”–¿˚◊¥Ã¨";
			nativename = "πÈ‘∆-Õ©”∞ Ë∑ÁII-”–¿˚◊¥Ã¨";
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
	public class GSkill6763 : GSkill
	{
		public GSkill6763()
			: base(6763)
		{
			
		}
	}
	public class GSkill6764Stub : GSkillStub
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
		public GSkill6764Stub()
			: base(6764)
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
			name = "πÈ‘∆-Õ©”∞ Ë∑ÁII-≤ª¿˚◊¥Ã¨";
			nativename = "πÈ‘∆-Õ©”∞ Ë∑ÁII-≤ª¿˚◊¥Ã¨";
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
	public class GSkill6764 : GSkill
	{
		public GSkill6764()
			: base(6764)
		{
			
		}
	}
	public class GSkill6765Stub : GSkillStub
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
		public GSkill6765Stub()
			: base(6765)
		{
			occupation = 128;
			maxlevel = 10;
			maxlearn = 10;
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
			name = "πÈ‘∆-ª®¬˙œ™II-∂ÓÕ‚”–¿˚◊¥Ã¨";
			nativename = "πÈ‘∆-ª®¬˙œ™II-∂ÓÕ‚”–¿˚◊¥Ã¨";
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
	public class GSkill6765 : GSkill
	{
		public GSkill6765()
			: base(6765)
		{
			
		}
	}
	public class GSkill6766Stub : GSkillStub
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
		public GSkill6766Stub()
			: base(6766)
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
			SetAction(0,"«‡‘∆√≈_∑®±¶_∫œª∂¡Â");
			SetAction(1,"«‡‘∆√≈_∑®±¶_∫œª∂¡Â");
			SetAction(2,"πÌÕı◊⁄_∑®±¶_∫œª∂¡Â");
			SetAction(3,"∫œª∂≈…_∑®±¶_∫œª∂¡Â");
			SetAction(4,"ÃÏ“ÙÀ¬_∑®±¶_∫œª∂¡Â");
			SetAction(5,"πÌµ¿_∑®±¶_∫œª∂¡Â");
			SetAction(6,"∑Ÿœ„π»_∑®±¶_∫œª∂¡Â");
			SetAction(7," ﬁ…Ò_∑®±¶_∫œª∂¡Â");
			SetAction(8,"∫¸—˝_∑®±¶_∫œª∂¡Â");
			SetAction(9,"–˘‘Ø_∑®±¶_∫œª∂¡Â");
			SetAction(10,"ª≥π‚_∑®±¶_∫œª∂¡Â");
			SetAction(11,"Ã´Íª_∑®±¶_∫œª∂¡Â");
			SetAction(12,"ÃÏª™_∑®±¶_∫œª∂¡Â");
			SetAction(13,"¡ÈŸÌ_∑®±¶_∫œª∂¡Â");
			SetAction(14,"”¢’–_∑®±¶_∫œª∂¡Â");
			SetAction(15,"‘™Àÿ¥Û ¶_∑®±¶_∫œª∂¡Â");
			SetAction(16,"‘™Àÿ¥Û ¶_∑®±¶_∫œª∂¡Â");
			SetAction(17,"πÈ‘∆_∑®±¶_∫œª∂¡Â");
			SetAction(18,"«‡‘∆√≈_∆Ô≥À_∑®±¶_∫œª∂¡Â");
			SetAction(19,"«‡‘∆√≈_∆Ô≥À_∑®±¶_∫œª∂¡Â");
			SetAction(20,"πÌÕı◊⁄_∆Ô≥À_∑®±¶_∫œª∂¡Â");
			SetAction(21,"∫œª∂≈…_∆Ô≥À_∑®±¶_∫œª∂¡Â");
			SetAction(22,"ÃÏ“ÙÀ¬_∆Ô≥À_∑®±¶_∫œª∂¡Â");
			SetAction(23,"πÌµ¿_∆Ô≥À_∑®±¶_∫œª∂¡Â");
			SetAction(24,"∑Ÿœ„π»_∆Ô≥À_∑®±¶_∫œª∂¡Â");
			SetAction(25," ﬁ…Ò_∆Ô≥À_∑®±¶_∫œª∂¡Â");
			SetAction(26,"∫¸—˝_∆Ô≥À_∑®±¶_∫œª∂¡Â");
			SetAction(27,"–˘‘Ø_∆Ô≥À_∑®±¶_∫œª∂¡Â");
			SetAction(28,"ª≥π‚_∆Ô≥À_∑®±¶_∫œª∂¡Â");
			SetAction(29,"Ã´Íª_∆Ô≥À_∑®±¶_∫œª∂¡Â");
			SetAction(30,"ÃÏª™_∆Ô≥À_∑®±¶_∫œª∂¡Â");
			name = "ÙÊ»Ùæ™∫Ë";
			nativename = "ÙÊ»Ùæ™∫Ë";
			icon = "ÙÊ»Ùæ™∫Ë.dds";
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
			return 100000;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 5.050000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 0.050000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 10.050000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			return 649.000000f;
		}
	}
	public class GSkill6766 : GSkill
	{
		public GSkill6766()
			: base(6766)
		{
			
		}
	}
	public class GSkill6767Stub : GSkillStub
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
		public GSkill6767Stub()
			: base(6767)
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
			SetAction(0,"«‡‘∆√≈_∑®±¶_∫œª∂¡Â");
			SetAction(1,"«‡‘∆√≈_∑®±¶_∫œª∂¡Â");
			SetAction(2,"πÌÕı◊⁄_∑®±¶_∫œª∂¡Â");
			SetAction(3,"∫œª∂∆§_∑®±¶_∫œª∂¡Â");
			SetAction(4,"ÃÏ“ÙÀ¬_∑®±¶_∫œª∂¡Â");
			SetAction(5,"πÌµ¿_∑®±¶_∫œª∂¡Â");
			SetAction(6,"∑Ÿœ„π»_∑®±¶_∫œª∂¡Â");
			SetAction(7," ﬁ…Ò_∑®±¶_∫œª∂¡Â");
			SetAction(8,"∫¸—˝_∑®±¶_∫œª∂¡Â");
			SetAction(9,"–˘‘Ø_∑®±¶_∫œª∂¡Â");
			SetAction(10,"ª≥π‚_∑®±¶_∫œª∂¡Â");
			SetAction(11,"Ã´Íª_∑®±¶_∫œª∂¡Â");
			SetAction(12,"ÃÏª™_∑®±¶_∫œª∂¡Â");
			SetAction(13,"¡ÈŸÌ_∑®±¶_∫œª∂¡Â");
			SetAction(14,"”¢’–_∑®±¶_∫œª∂¡Â");
			SetAction(15,"‘™Àÿ¥Û ¶_∑®±¶_∫œª∂¡Â");
			SetAction(16,"‘™Àÿ¥Û ¶_∑®±¶_∫œª∂¡Â");
			SetAction(17,"πÈ‘∆_∑®±¶_∫œª∂¡Â");
			SetAction(18,"«‡‘∆√≈_∆Ô≥À_∑®±¶_∫œª∂¡Â");
			SetAction(19,"«‡‘∆√≈_∆Ô≥À_∑®±¶_∫œª∂¡Â");
			SetAction(20,"πÌÕı◊⁄_∆Ô≥À_∑®±¶_∫œª∂¡Â");
			SetAction(21,"∫œª∂≈…_∆Ô≥À_∑®±¶_∫œª∂¡Â");
			SetAction(22,"ÃÏ“ÙÀ¬_∆Ô≥À_∑®±¶_∫œª∂¡Â");
			SetAction(23,"πÌµ¿_∆Ô≥À_∑®±¶_∫œª∂¡Â");
			SetAction(24,"∑Ÿœ„π»_∆Ô≥À_∑®±¶_∫œª∂¡Â");
			SetAction(25," ﬁ…Ò_∆Ô≥À_∑®±¶_∫œª∂¡Â");
			SetAction(26,"∫¸—˝_∆Ô≥À_∑®±¶_∫œª∂¡Â");
			SetAction(27,"–˘‘Ø_∆Ô≥À_∑®±¶_∫œª∂¡Â");
			SetAction(28,"ª≥π‚_∆Ô≥À_∑®±¶_∫œª∂¡Â");
			SetAction(29,"Ã´Íª_∆Ô≥À_∑®±¶_∫œª∂¡Â");
			SetAction(30,"ÃÏª™_∆Ô≥À_∑®±¶_∫œª∂¡Â");
			name = "≥–°§ÙÊ»Ùæ™∫Ë";
			nativename = "≥–°§ÙÊ»Ùæ™∫Ë";
			icon = "ÙÊ»Ùæ™∫Ë.dds";
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
			return 100000;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 5.050000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 0.050000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 10.050000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			return 649.000000f;
		}
	}
	public class GSkill6767 : GSkill
	{
		public GSkill6767()
			: base(6767)
		{
			
		}
	}
	public class GSkill6768Stub : GSkillStub
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
		public GSkill6768Stub()
			: base(6768)
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
			SetAction(0,"«‡‘∆√≈_∑®±¶_∫œª∂¡Â");
			SetAction(1,"«‡‘∆√≈_∑®±¶_∫œª∂¡Â");
			SetAction(2,"πÌÕı◊⁄_∑®±¶_∫œª∂¡Â");
			SetAction(3,"∫œª∂≈…_∑®±¶_∫œª∂¡Â");
			SetAction(4,"ÃÏ“ÙÀ¬_∑®±¶_∫œª∂¡Â");
			SetAction(5,"πÌµ¿_∑®±¶_∫œª∂¡Â");
			SetAction(6,"∑Ÿœ„π»_∑®±¶_∫œª∂¡Â");
			SetAction(7," ﬁ…Ò_∑®±¶_∫œª∂¡Â");
			SetAction(8,"∫¸—˝_∑®±¶_∫œª∂¡Â");
			SetAction(9,"–˘‘Ø_∑®±¶_∫œª∂¡Â");
			SetAction(10,"ª≥π‚_∑®±¶_∫œª∂¡Â");
			SetAction(11,"Ã´Íª_∑®±¶_∫œª∂¡Â");
			SetAction(12,"ÃÏª™_∑®±¶_∫œª∂¡Â");
			SetAction(13,"¡ÈŸÌ_∑®±¶_∫œª∂¡Â");
			SetAction(14,"”¢’–_∑®±¶_∫œª∂¡Â");
			SetAction(15,"‘™Àÿ¥Û ¶_∑®±¶_∫œª∂¡Â");
			SetAction(16,"‘™Àÿ¥Û ¶_∑®±¶_∫œª∂¡Â");
			SetAction(17,"πÈ‘∆_∑®±¶_∫œª∂¡Â");
			SetAction(18,"«‡‘∆√≈_∆Ô≥À_∑®±¶_∫œª∂¡Â");
			SetAction(19,"«‡‘∆√≈_∆Ô≥À_∑®±¶_∫œª∂¡Â");
			SetAction(20,"πÌÕı◊⁄_∆Ô≥À_∑®±¶_∫œª∂¡Â");
			SetAction(21,"∫œª∂≈…_∆Ô≥À_∑®±¶_∫œª∂¡Â");
			SetAction(22,"ÃÏ“ÙÀ¬_∆Ô≥À_∑®±¶_∫œª∂¡Â");
			SetAction(23,"πÌµ¿_∆Ô≥À_∑®±¶_∫œª∂¡Â");
			SetAction(24,"∑Ÿœ„π»_∆Ô≥À_∑®±¶_∫œª∂¡Â");
			SetAction(25," ﬁ…Ò_∆Ô≥À_∑®±¶_∫œª∂¡Â");
			SetAction(26,"∫¸—˝_∆Ô≥À_∑®±¶_∫œª∂¡Â");
			SetAction(27,"–˘‘Ø_∆Ô≥À_∑®±¶_∫œª∂¡Â");
			SetAction(28,"ª≥π‚_∆Ô≥À_∑®±¶_∫œª∂¡Â");
			SetAction(29,"Ã´Íª_∆Ô≥À_∑®±¶_∫œª∂¡Â");
			SetAction(30,"ÃÏª™_∆Ô≥À_∑®±¶_∫œª∂¡Â");
			name = "’Ê°§ÙÊ»Ùæ™∫Ë";
			nativename = "’Ê°§ÙÊ»Ùæ™∫Ë";
			icon = "’Ê°§ÙÊ»Ùæ™∫Ë.dds";
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
			return 70000;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 5.050000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 0.050000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 10.050000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			return 649.000000f;
		}
	}
	public class GSkill6768 : GSkill
	{
		public GSkill6768()
			: base(6768)
		{
			
		}
	}
	public class GSkill6769Stub : GSkillStub
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
		public GSkill6769Stub()
			: base(6769)
		{
			occupation = 130;
			maxlevel = 5;
			maxlearn = 5;
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
			name = "ÙÊ»Ùæ™∫Ë1";
			nativename = "ÙÊ»Ùæ™∫Ë1";
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
	public class GSkill6769 : GSkill
	{
		public GSkill6769()
			: base(6769)
		{
			
		}
	}
}
