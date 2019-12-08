using System;
using System.Text;

namespace SKILL
{
	public class GSkill5610Stub : GSkillStub
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
		public GSkill5610Stub()
			: base(5610)
		{
			occupation = 153;
			maxlevel = 20;
			maxlearn = 10;
			eventflag = 0;
			spcost = 0;
			reborncount = 0;
			type = 1;
			timetype = 0;
			targettype = 0;
			rangetype = 14;
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
			weapon_limit = 14;
			SetAction(0,"Ó¢ÕĞ_Á½¶ÎÈº");
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
			SetAction(14,"Ó¢ÕĞ_Á½¶ÎÈº");
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
			name = "ÆÆ·ç¡¤ºáÉ¨";
			nativename = "ÆÆ·ç¡¤ºáÉ¨";
			icon = "ºáÉ¨Ç§¾ü01.dds";
			SetTalent(0,5202);
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
			skill_class = 13;
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
			return 5200;
		}
		public override float GetRadius(GSkill skill)
		{
			return 10.000000f;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 10.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 8.000000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 15.000000f;
		}
		public override int GetHpcost(GSkill skill)
		{
			return 198;
		}
	}
	public class GSkill5610 : GSkill
	{
		public GSkill5610()
			: base(5610)
		{
			
		}
	}
	public class GSkill5611Stub : GSkillStub
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
		public GSkill5611Stub()
			: base(5611)
		{
			occupation = 153;
			maxlevel = 20;
			maxlearn = 10;
			eventflag = 0;
			spcost = 0;
			reborncount = 0;
			type = 1;
			timetype = 0;
			targettype = 0;
			rangetype = 14;
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
			weapon_limit = 14;
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
			name = "ÆÆ·ç¡¤×İºá";
			nativename = "ÆÆ·ç¡¤×İºá";
			icon = "×İºáÌìÏÂ.dds";
			SetTalent(0,5220);
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
			skill_class = 13;
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
			return 6000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			return 13400;
		}
		public override float GetRadius(GSkill skill)
		{
			return 15.000000f;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 5.000000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 10.000000f;
		}
		public override int GetHpcost(GSkill skill)
		{
			return 220;
		}
	}
	public class GSkill5611 : GSkill
	{
		public GSkill5611()
			: base(5611)
		{
			
		}
	}
	public class GSkill5612Stub : GSkillStub
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
		public GSkill5612Stub()
			: base(5612)
		{
			occupation = 156;
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
			SetAction(0,"ÌìÒôËÂ_½ğ¸Õ¾­");
			SetAction(1,"ÌìÒôËÂ_½ğ¸Õ¾­");
			SetAction(2,"ÌìÒôËÂ_½ğ¸Õ¾­");
			SetAction(3,"ÌìÒôËÂ_½ğ¸Õ¾­");
			SetAction(4,"ÌìÒôËÂ_½ğ¸Õ¾­");
			SetAction(5,"ÌìÒôËÂ_½ğ¸Õ¾­");
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
			SetAction(18,"ÌìÒôËÂ_Æï³Ë_½ğ¸Õ¾­");
			SetAction(19,"ÌìÒôËÂ_Æï³Ë_½ğ¸Õ¾­");
			SetAction(20,"ÌìÒôËÂ_Æï³Ë_½ğ¸Õ¾­");
			SetAction(21,"ÌìÒôËÂ_Æï³Ë_½ğ¸Õ¾­");
			SetAction(22,"ÌìÒôËÂ_Æï³Ë_½ğ¸Õ¾­");
			SetAction(23,"ÌìÒôËÂ_Æï³Ë_½ğ¸Õ¾­");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "ÎŞ¹¸¡¤½ğ¸Õ";
			nativename = "ÎŞ¹¸¡¤½ğ¸Õ";
			icon = "½ğ¸Õ¾­.dds";
			SetTalent(0,676);
			SetTalent(1,693);
			SetTalent(2,698);
			SetTalent(3,702);
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
			skill_class = 3;
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
		public override int GetEnmity(GSkill skill)
		{
			return 1;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 16.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 10.700000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 19.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			return 110.000000f;
		}
	}
	public class GSkill5612 : GSkill
	{
		public GSkill5612()
			: base(5612)
		{
			
		}
	}
	public class GSkill5613Stub : GSkillStub
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
		public GSkill5613Stub()
			: base(5613)
		{
			occupation = 156;
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
			SetAction(0,"ÌìÒôËÂ_ÁùµÀÂÖ»Ø");
			SetAction(1,"ÌìÒôËÂ_ÁùµÀÂÖ»Ø");
			SetAction(2,"ÌìÒôËÂ_ÁùµÀÂÖ»Ø");
			SetAction(3,"ÌìÒôËÂ_ÁùµÀÂÖ»Ø");
			SetAction(4,"ÌìÒôËÂ_ÁùµÀÂÖ»Ø");
			SetAction(5,"ÌìÒôËÂ_ÁùµÀÂÖ»Ø");
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
			SetAction(18,"ÌìÒôËÂ_Æï³Ë_ÁùµÀÂÖ»Ø");
			SetAction(19,"ÌìÒôËÂ_Æï³Ë_ÁùµÀÂÖ»Ø");
			SetAction(20,"ÌìÒôËÂ_Æï³Ë_ÁùµÀÂÖ»Ø");
			SetAction(21,"ÌìÒôËÂ_Æï³Ë_ÁùµÀÂÖ»Ø");
			SetAction(22,"ÌìÒôËÂ_Æï³Ë_ÁùµÀÂÖ»Ø");
			SetAction(23,"ÌìÒôËÂ_Æï³Ë_ÁùµÀÂÖ»Ø");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "ÎŞ¹¸¡¤ÂÖ»Ø";
			nativename = "ÎŞ¹¸¡¤ÂÖ»Ø";
			icon = "ÁùµÀÂÖ»Ø.dds";
			SetTalent(0,699);
			SetTalent(1,702);
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
			skill_class = 3;
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
			return 6000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			return 12500;
		}
		public override int GetEnmity(GSkill skill)
		{
			return 1;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 28.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 11.000000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 33.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			return 132.000000f;
		}
	}
	public class GSkill5613 : GSkill
	{
		public GSkill5613()
			: base(5613)
		{
			
		}
	}
	public class GSkill5614Stub : GSkillStub
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
		public GSkill5614Stub()
			: base(5614)
		{
			occupation = 156;
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
			dobless = true;
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
			SetAction(0,"ÌìÒôËÂ_À×Òô·¨ÚÍ");
			SetAction(1,"ÌìÒôËÂ_À×Òô·¨ÚÍ");
			SetAction(2,"ÌìÒôËÂ_À×Òô·¨ÚÍ");
			SetAction(3,"ÌìÒôËÂ_À×Òô·¨ÚÍ");
			SetAction(4,"ÌìÒôËÂ_À×Òô·¨ÚÍ");
			SetAction(5,"ÌìÒôËÂ_À×Òô·¨ÚÍ");
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
			SetAction(18,"ÌìÒôËÂ_Æï³Ë_À×Òô·¨ÚÍ");
			SetAction(19,"ÌìÒôËÂ_Æï³Ë_À×Òô·¨ÚÍ");
			SetAction(20,"ÌìÒôËÂ_Æï³Ë_À×Òô·¨ÚÍ");
			SetAction(21,"ÌìÒôËÂ_Æï³Ë_À×Òô·¨ÚÍ");
			SetAction(22,"ÌìÒôËÂ_Æï³Ë_À×Òô·¨ÚÍ");
			SetAction(23,"ÌìÒôËÂ_Æï³Ë_À×Òô·¨ÚÍ");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "ÎŞ¹¸¡¤À×Òô";
			nativename = "ÎŞ¹¸¡¤À×Òô";
			icon = "À×Òô·¨ÚÍ.dds";
			SetTalent(0,684);
			SetTalent(1,698);
			SetTalent(2,702);
			SetTalent(3,708);
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
			skill_class = 3;
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
			return 6200;
		}
		public override int GetEnmity(GSkill skill)
		{
			return 1;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 17.500000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 12.200000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 20.600000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			return 154.000000f;
		}
	}
	public class GSkill5614 : GSkill
	{
		public GSkill5614()
			: base(5614)
		{
			
		}
	}
	public class GSkill5615Stub : GSkillStub
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
		public GSkill5615Stub()
			: base(5615)
		{
			occupation = 156;
			maxlevel = 20;
			maxlearn = 10;
			eventflag = 0;
			spcost = 0;
			reborncount = 0;
			type = 2;
			timetype = 1;
			targettype = 0;
			rangetype = 2;
			doenchant = true;
			dobless = true;
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
			SetAction(0,"ÌìÒôËÂ_´Èº½·¨Ô¸");
			SetAction(1,"ÌìÒôËÂ_´Èº½·¨Ô¸");
			SetAction(2,"ÌìÒôËÂ_´Èº½·¨Ô¸");
			SetAction(3,"ÌìÒôËÂ_´Èº½·¨Ô¸");
			SetAction(4,"ÌìÒôËÂ_´Èº½·¨Ô¸");
			SetAction(5,"ÌìÒôËÂ_´Èº½·¨Ô¸");
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
			SetAction(18,"ÌìÒôËÂ_Æï³Ë_´Èº½·¨Ô¸");
			SetAction(19,"ÌìÒôËÂ_Æï³Ë_´Èº½·¨Ô¸");
			SetAction(20,"ÌìÒôËÂ_Æï³Ë_´Èº½·¨Ô¸");
			SetAction(21,"ÌìÒôËÂ_Æï³Ë_´Èº½·¨Ô¸");
			SetAction(22,"ÌìÒôËÂ_Æï³Ë_´Èº½·¨Ô¸");
			SetAction(23,"ÌìÒôËÂ_Æï³Ë_´Èº½·¨Ô¸");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "ÎŞ¹¸¡¤´Èº½";
			nativename = "ÎŞ¹¸¡¤´Èº½";
			icon = "´Èº½·¨Ô¸.dds";
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
			skill_class = 3;
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
		public override int GetCooldowntime(GSkill skill)
		{
			return 12000;
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
			return 18.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			return 176.000000f;
		}
	}
	public class GSkill5615 : GSkill
	{
		public GSkill5615()
			: base(5615)
		{
			
		}
	}
	public class GSkill5616Stub : GSkillStub
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
		public GSkill5616Stub()
			: base(5616)
		{
			occupation = 156;
			maxlevel = 20;
			maxlearn = 10;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 1;
			timetype = 0;
			targettype = 0;
			rangetype = 2;
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
			weapon_limit = -1;
			SetAction(0,"ÌìÒôËÂ_·ğ¹âÆÕÕÕ");
			SetAction(1,"ÌìÒôËÂ_·ğ¹âÆÕÕÕ");
			SetAction(2,"ÌìÒôËÂ_·ğ¹âÆÕÕÕ");
			SetAction(3,"ÌìÒôËÂ_·ğ¹âÆÕÕÕ");
			SetAction(4,"ÌìÒôËÂ_·ğ¹âÆÕÕÕ");
			SetAction(5,"ÌìÒôËÂ_·ğ¹âÆÕÕÕ");
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
			SetAction(18,"ÌìÒôËÂ_Æï³Ë_·ğ¹âÆÕÕÕ");
			SetAction(19,"ÌìÒôËÂ_Æï³Ë_·ğ¹âÆÕÕÕ");
			SetAction(20,"ÌìÒôËÂ_Æï³Ë_·ğ¹âÆÕÕÕ");
			SetAction(21,"ÌìÒôËÂ_Æï³Ë_·ğ¹âÆÕÕÕ");
			SetAction(22,"ÌìÒôËÂ_Æï³Ë_·ğ¹âÆÕÕÕ");
			SetAction(23,"ÌìÒôËÂ_Æï³Ë_·ğ¹âÆÕÕÕ");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "ÎŞ¹¸¡¤·ğ¹â";
			nativename = "ÎŞ¹¸¡¤·ğ¹â";
			icon = "·ğ¹âÆÕÕÕ.dds";
			SetTalent(0,703);
			SetTalent(1,710);
			SetTalent(2,715);
			SetTalent(3,719);
			SetTalent(4,0);
			SetTalent(5,0);
			SetTalent(6,0);
			SetTalent(7,0);
			talent_size = 4;
			talent_type = 0;
			use_proficiency = false;
			inc_proficiency = 0;
			preskillnum = 1;
			cycle = false;
			cyclemode = 0;
			cyclegfx = "";
			skill_class = 3;
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
		public override int GetEnmity(GSkill skill)
		{
			return 1;
		}
		public override float GetRadius(GSkill skill)
		{
			return 18.000000f;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 14.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 12.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			return 198.000000f;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={282};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={1};return array[index];
		}
	}
	public class GSkill5616 : GSkill
	{
		public GSkill5616()
			: base(5616)
		{
			
		}
	}
	public class GSkill5617Stub : GSkillStub
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
		public GSkill5617Stub()
			: base(5617)
		{
			occupation = 156;
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
			SetAction(0,"ÌìÒôËÂ_ÎŞÁ¿ÕæÑÔ");
			SetAction(1,"ÌìÒôËÂ_ÎŞÁ¿ÕæÑÔ");
			SetAction(2,"ÌìÒôËÂ_ÎŞÁ¿ÕæÑÔ");
			SetAction(3,"ÌìÒôËÂ_ÎŞÁ¿ÕæÑÔ");
			SetAction(4,"ÌìÒôËÂ_ÎŞÁ¿ÕæÑÔ");
			SetAction(5,"ÌìÒôËÂ_ÎŞÁ¿ÕæÑÔ");
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
			SetAction(18,"ÌìÒôËÂ_Æï³Ë_ÎŞÁ¿ÕæÑÔ");
			SetAction(19,"ÌìÒôËÂ_Æï³Ë_ÎŞÁ¿ÕæÑÔ");
			SetAction(20,"ÌìÒôËÂ_Æï³Ë_ÎŞÁ¿ÕæÑÔ");
			SetAction(21,"ÌìÒôËÂ_Æï³Ë_ÎŞÁ¿ÕæÑÔ");
			SetAction(22,"ÌìÒôËÂ_Æï³Ë_ÎŞÁ¿ÕæÑÔ");
			SetAction(23,"ÌìÒôËÂ_Æï³Ë_ÎŞÁ¿ÕæÑÔ");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "ÎŞ¹¸¡¤ÎŞÁ¿";
			nativename = "ÎŞ¹¸¡¤ÎŞÁ¿";
			icon = "ÎŞÁ¿ÕæÑÔ.dds";
			SetTalent(0,675);
			SetTalent(1,681);
			SetTalent(2,701);
			SetTalent(3,2947);
			SetTalent(4,4112);
			SetTalent(5,4530);
			SetTalent(6,0);
			SetTalent(7,0);
			talent_size = 6;
			talent_type = 0;
			use_proficiency = false;
			inc_proficiency = 0;
			preskillnum = 0;
			cycle = false;
			cyclemode = 0;
			cyclegfx = "";
			skill_class = 3;
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
			return 7150;
		}
		public override int GetEnmity(GSkill skill)
		{
			return 1;
		}
		public override float GetRadius(GSkill skill)
		{
			return 15.000000f;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 14.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 13.000000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 25.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			return 220.000000f;
		}
	}
	public class GSkill5617 : GSkill
	{
		public GSkill5617()
			: base(5617)
		{
			
		}
	}
	public class GSkill5618Stub : GSkillStub
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
		public GSkill5618Stub()
			: base(5618)
		{
			occupation = 157;
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
			SetAction(0,"¹íÍõ×Ú_Ñ¸À×Õ¶");
			SetAction(1,"¹íÍõ×Ú_Ñ¸À×Õ¶");
			SetAction(2,"¹íÍõ×Ú_Ñ¸À×Õ¶");
			SetAction(3,"¹íÍõ×Ú_Ñ¸À×Õ¶");
			SetAction(4,"¹íÍõ×Ú_Ñ¸À×Õ¶");
			SetAction(5,"¹íÍõ×Ú_Ñ¸À×Õ¶");
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
			SetAction(18,"¹íÍõ×Ú_Æï³Ë_Ñ¸À×Õ¶");
			SetAction(19,"¹íÍõ×Ú_Æï³Ë_Ñ¸À×Õ¶");
			SetAction(20,"¹íÍõ×Ú_Æï³Ë_Ñ¸À×Õ¶");
			SetAction(21,"¹íÍõ×Ú_Æï³Ë_Ñ¸À×Õ¶");
			SetAction(22,"¹íÍõ×Ú_Æï³Ë_Ñ¸À×Õ¶");
			SetAction(23,"¹íÍõ×Ú_Æï³Ë_Ñ¸À×Õ¶");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "Õ½Îè¡¤Ñ¸À×";
			nativename = "Õ½Îè¡¤Ñ¸À×";
			icon = "Ñ¸À×Õ¶.dds";
			SetTalent(0,655);
			SetTalent(1,661);
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
			skill_class = 0;
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
			return 3600;
		}
		public override int GetEnmity(GSkill skill)
		{
			return 1;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 8.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 1.700000f;
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
	public class GSkill5618 : GSkill
	{
		public GSkill5618()
			: base(5618)
		{
			
		}
	}
	public class GSkill5619Stub : GSkillStub
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
		public GSkill5619Stub()
			: base(5619)
		{
			occupation = 157;
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
			SetAction(0,"¹íÍõ×Ú_ÌìÄ§Îè");
			SetAction(1,"¹íÍõ×Ú_ÌìÄ§Îè");
			SetAction(2,"¹íÍõ×Ú_ÌìÄ§Îè");
			SetAction(3,"¹íÍõ×Ú_ÌìÄ§Îè");
			SetAction(4,"¹íÍõ×Ú_ÌìÄ§Îè");
			SetAction(5,"¹íÍõ×Ú_ÌìÄ§Îè");
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
			SetAction(18,"¹íÍõ×Ú_Æï³Ë_ÌìÄ§Îè");
			SetAction(19,"¹íÍõ×Ú_Æï³Ë_ÌìÄ§Îè");
			SetAction(20,"¹íÍõ×Ú_Æï³Ë_ÌìÄ§Îè");
			SetAction(21,"¹íÍõ×Ú_Æï³Ë_ÌìÄ§Îè");
			SetAction(22,"¹íÍõ×Ú_Æï³Ë_ÌìÄ§Îè");
			SetAction(23,"¹íÍõ×Ú_Æï³Ë_ÌìÄ§Îè");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "Õ½Îè¡¤Ä§Îè";
			nativename = "Õ½Îè¡¤Ä§Îè";
			icon = "ÌìÄ§Îè.dds";
			SetTalent(0,661);
			SetTalent(1,663);
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
			skill_class = 0;
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
			return 4600;
		}
		public override int GetEnmity(GSkill skill)
		{
			return 1;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 8.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 1.700000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 14.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			return 132.000000f;
		}
	}
	public class GSkill5619 : GSkill
	{
		public GSkill5619()
			: base(5619)
		{
			
		}
	}
}
