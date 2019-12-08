using System;
using System.Text;

namespace SKILL
{
	public class GSkill3260Stub : GSkillStub
	{
		public GSkill3260Stub()
			: base(3260)
		{
			occupation = 1;
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
			name = "·ÏÆú";
			nativename = "·ÏÆú";
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
	public class GSkill3260 : GSkill
	{
		public GSkill3260()
			: base(3260)
		{
			
		}
	}
	public class GSkill3261Stub : GSkillStub
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
				int				skill_level = skill.GetLevel();
				int				skill_t1 = skill.GetT1();
				int				skill_t2 = skill.GetT2();

				skill.SetRatio((skill_t2 * 0.05f + 1.0f));
				skill.SetPlus(((skill_t1 * 0.1f + 1.0f) * (((5 * skill_level) + (skill_level * (skill_level * 0.32f)) + 58.0f) * (D2INT(skill_level * 0.05f + 0.55f)) + (((D2INT(1.42f - skill_level * 0.05f)) * (6 * skill_level + 50))))));
				player.SetPerform(1);
			}
		}
		public GSkill3261Stub()
			: base(3261)
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
			rangetype = 4;
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
			SetAction(0,"ÇàÔÆÃÅ_Ðþ±ù´Ì");
			SetAction(1,"ÇàÔÆÃÅ_Ðþ±ù´Ì");
			SetAction(2,"ÇàÔÆÃÅ_Ðþ±ù´Ì");
			SetAction(3,"ÇàÔÆÃÅ_Ðþ±ù´Ì");
			SetAction(4,"ÇàÔÆÃÅ_Ðþ±ù´Ì");
			SetAction(5,"ÇàÔÆÃÅ_Ðþ±ù´Ì");
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
			SetAction(18,"ÇàÔÆÃÅ_Æï³Ë_Ðþ±ù´Ì");
			SetAction(19,"ÇàÔÆÃÅ_Æï³Ë_Ðþ±ù´Ì");
			SetAction(20,"ÇàÔÆÃÅ_Æï³Ë_Ðþ±ù´Ì");
			SetAction(21,"ÇàÔÆÃÅ_Æï³Ë_Ðþ±ù´Ì");
			SetAction(22,"ÇàÔÆÃÅ_Æï³Ë_Ðþ±ù´Ì");
			SetAction(23,"ÇàÔÆÃÅ_Æï³Ë_Ðþ±ù´Ì");
			SetAction(24,"");
			SetAction(25,"");
			SetAction(26,"");
			SetAction(27,"");
			SetAction(28,"");
			SetAction(29,"");
			SetAction(30,"");
			name = "ÇàÔÆ-Ðþ±ù´Ì";
			nativename = "ÇàÔÆ-Ðþ±ù´Ì";
			icon = "Ðþ±ù´Ì.dds";
			SetTalent(0,571);
			SetTalent(1,602);
			SetTalent(2,617);
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
			return 1000;
		}
		public override int GetEnmity(GSkill skill)
		{
			return 1;
		}
		public override float GetRadius(GSkill skill)
		{
			return 12.000000f;
		}
		public override float GetAngle(GSkill skill)
		{
			return -0.333332f;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 8.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 5.000000f;
		}
		public override int GetCoverage(GSkill skill)
		{
			return 24;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetProbability(50.0f);
			victim.SetTime(6000.0f);
			victim.SetRatio(0.0f);
			victim.SetBuffid(1);
			victim.SetFrozen(true);
			return true;
		}
		public override float GetDropRate(GSkill skill)
		{
			return 0.500000f;
		}
	}
	public class GSkill3261 : GSkill
	{
		public GSkill3261()
			: base(3261)
		{
			
		}
	}
	public class GSkill3262Stub : GSkillStub
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

				skill.SetCrit(0.40000001f);
				skill.SetCrithurt(2.0f);
				skill.SetRatio(4.3699999f);
				skill.SetPlus(1200.0f);
				player.SetPerform(1);
			}
		}
		public GSkill3262Stub()
			: base(3262)
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
			SetAction(0,"ºÏ»¶ÅÉ_²øÃà");
			SetAction(1,"ºÏ»¶ÅÉ_²øÃà");
			SetAction(2,"ºÏ»¶ÅÉ_²øÃà");
			SetAction(3,"ºÏ»¶ÅÉ_²øÃà");
			SetAction(4,"ºÏ»¶ÅÉ_²øÃà");
			SetAction(5,"ºÏ»¶ÅÉ_²øÃà");
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
			SetAction(18,"ºÏ»¶ÅÉ_Æï³Ë_²øÃà");
			SetAction(19,"ºÏ»¶ÅÉ_Æï³Ë_²øÃà");
			SetAction(20,"ºÏ»¶ÅÉ_Æï³Ë_²øÃà");
			SetAction(21,"ºÏ»¶ÅÉ_Æï³Ë_²øÃà");
			SetAction(22,"ºÏ»¶ÅÉ_Æï³Ë_²øÃà");
			SetAction(23,"ºÏ»¶ÅÉ_Æï³Ë_²øÃà");
			SetAction(24,"");
			SetAction(25,"");
			SetAction(26,"");
			SetAction(27,"");
			SetAction(28,"");
			SetAction(29,"");
			SetAction(30,"");
			name = "ºÏ»¶-²øÃà";
			nativename = "ºÏ»¶-²øÃà";
			icon = "²øÃà.dds";
			SetTalent(0,742);
			SetTalent(1,746);
			SetTalent(2,749);
			SetTalent(3,753);
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
		public override int GetEnmity(GSkill skill)
		{
			return 1;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 7.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 2.700000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 12.000000f;
		}
	}
	public class GSkill3262 : GSkill
	{
		public GSkill3262()
			: base(3262)
		{
			
		}
	}
	public class GSkill3263Stub : GSkillStub
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
		public GSkill3263Stub()
			: base(3263)
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
			SetAction(0,"ºÏ»¶ÅÉ_Ï§´º");
			SetAction(1,"ºÏ»¶ÅÉ_Ï§´º");
			SetAction(2,"ºÏ»¶ÅÉ_Ï§´º");
			SetAction(3,"ºÏ»¶ÅÉ_Ï§´º");
			SetAction(4,"ºÏ»¶ÅÉ_Ï§´º");
			SetAction(5,"ºÏ»¶ÅÉ_Ï§´º");
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
			SetAction(18,"ºÏ»¶ÅÉ_Æï³Ë_Ï§´º");
			SetAction(19,"ºÏ»¶ÅÉ_Æï³Ë_Ï§´º");
			SetAction(20,"ºÏ»¶ÅÉ_Æï³Ë_Ï§´º");
			SetAction(21,"ºÏ»¶ÅÉ_Æï³Ë_Ï§´º");
			SetAction(22,"ºÏ»¶ÅÉ_Æï³Ë_Ï§´º");
			SetAction(23,"ºÏ»¶ÅÉ_Æï³Ë_Ï§´º");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "ºÏ»¶-Ï§´º";
			nativename = "ºÏ»¶-Ï§´º";
			icon = "Ï§´º.dds";
			SetTalent(0,734);
			SetTalent(1,763);
			SetTalent(2,764);
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
			return 1000;
		}
		public override float GetPraydistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return player_range;
		}
		public override float GetCastdistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return player_range;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetTime(12000.0f);
			victim.SetValue(20.0f);
			victim.SetBlessed(true);
			victim.SetProbability(100.0f);
			victim.SetBuffid(2);
			victim.SetAmount(99.0f);
			victim.SetValue(99.0f);
			victim.SetExorcism(true);
			victim.SetProbability(100.0f);
			victim.SetClearslow(true);
			return true;
		}
	}
	public class GSkill3263 : GSkill
	{
		public GSkill3263()
			: base(3263)
		{
			
		}
	}
	public class GSkill3264Stub : GSkillStub
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
				int				skill_level = skill.GetLevel();

				skill.SetRatio((norm(zrand(130) / 100.0f) + 1.2f));
				skill.SetCrit(0.30000001f);
				skill.SetCrithurt(0.5f);
				skill.SetPlus((((62 * skill_level) + (skill_level * (skill_level * 0.72f)) + 348.0f) * (D2INT(skill_level * 0.05f + 0.55f)) + ((skill_level * 7.9f + (skill_level * (skill_level * 1.4f)) + 677.0f) * (D2INT(1.42f - skill_level * 0.05f)))));
				player.SetPerform(1);
			}
		}
		public GSkill3264Stub()
			: base(3264)
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
			rangetype = 4;
			doenchant = true;
			dobless = false;
			autoattack = false;
			allowform = 1;
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
			SetAction(0,"¹íµÀ_±©É³Âþ¾í");
			SetAction(1,"¹íµÀ_±©É³Âþ¾í");
			SetAction(2,"¹íµÀ_±©É³Âþ¾í");
			SetAction(3,"¹íµÀ_±©É³Âþ¾í");
			SetAction(4,"¹íµÀ_±©É³Âþ¾í");
			SetAction(5,"¹íµÀ_±©É³Âþ¾í");
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
			SetAction(18,"¹íµÀ_Æï³Ë_±©É³Âþ¾í");
			SetAction(19,"¹íµÀ_Æï³Ë_±©É³Âþ¾í");
			SetAction(20,"¹íµÀ_Æï³Ë_±©É³Âþ¾í");
			SetAction(21,"¹íµÀ_Æï³Ë_±©É³Âþ¾í");
			SetAction(22,"¹íµÀ_Æï³Ë_±©É³Âþ¾í");
			SetAction(23,"¹íµÀ_Æï³Ë_±©É³Âþ¾í");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "¹íµÀ-±©É³Âþ¾í";
			nativename = "¹íµÀ-±©É³Âþ¾í";
			icon = "±©É³Âþ¾í.dds";
			SetTalent(0,1148);
			SetTalent(1,1149);
			SetTalent(2,1151);
			SetTalent(3,1155);
			SetTalent(4,1543);
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
		public override float GetRadius(GSkill skill)
		{
			return 12.000000f;
		}
		public override float GetAngle(GSkill skill)
		{
			return -0.333332f;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 7.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 5.000000f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetProbability(120.0f);
			victim.SetTime(20100.0f);
			victim.SetBuffid(1);
			victim.SetValue(((zrand(500) + 3000)));
			victim.SetSubdefence(true);
			return true;
		}
		public override float GetDropRate(GSkill skill)
		{
			return 0.400000f;
		}
	}
	public class GSkill3264 : GSkill
	{
		public GSkill3264()
			: base(3264)
		{
			
		}
	}
	public class GSkill3265Stub : GSkillStub
	{
		public class GState1 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 1800;
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
				int				skill_level = skill.GetLevel();

				skill.SetRatio(((4 * norm(zrand(118) / 100.0f) + 1)));
				skill.SetPlus(((2 * (skill_level * skill_level + (25 * skill_level)) + 750)));
				player.SetPerform(1);
			}
			public override bool Cancel(GSkill skill)
			{
				return true;
			}
		}
		public GSkill3265Stub()
			: base(3265)
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
			rangetype = 2;
			doenchant = true;
			dobless = false;
			autoattack = false;
			allowform = 1;
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
			SetAction(0,"¹íµÀ_Ãð»ê¿ñì­");
			SetAction(1,"¹íµÀ_Ãð»ê¿ñì­");
			SetAction(2,"¹íµÀ_Ãð»ê¿ñì­");
			SetAction(3,"¹íµÀ_Ãð»ê¿ñì­");
			SetAction(4,"¹íµÀ_Ãð»ê¿ñì­");
			SetAction(5,"¹íµÀ_Ãð»ê¿ñì­");
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
			SetAction(18,"¹íµÀ_Æï³Ë_Ãð»ê¿ñì­");
			SetAction(19,"¹íµÀ_Æï³Ë_Ãð»ê¿ñì­");
			SetAction(20,"¹íµÀ_Æï³Ë_Ãð»ê¿ñì­");
			SetAction(21,"¹íµÀ_Æï³Ë_Ãð»ê¿ñì­");
			SetAction(22,"¹íµÀ_Æï³Ë_Ãð»ê¿ñì­");
			SetAction(23,"¹íµÀ_Æï³Ë_Ãð»ê¿ñì­");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "¹íµÀ-Ãð»ê¿ñì­";
			nativename = "¹íµÀ-Ãð»ê¿ñì­";
			icon = "Ãð»ê¿ñì­.dds";
			SetTalent(0,1151);
			SetTalent(1,1153);
			SetTalent(2,1154);
			SetTalent(3,1155);
			SetTalent(4,1543);
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
			return 12.000000f;
		}
		public override int GetCoverage(GSkill skill)
		{
			return 35;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetProbability(80.0f);
			victim.SetRatio(0.1f);
			victim.SetDrainmagic(true);
			victim.SetProbability(650.0f);
			victim.SetTime(12100.0f);
			victim.SetRatio(0.15000001f);
			victim.SetBuffid(1);
			victim.SetWeak(true);
			victim.SetProbability(((zrand(300) + 200)));
			victim.SetTime(4000.0f);
			victim.SetDizzy(true);
			return true;
		}
		public override float GetDropRate(GSkill skill)
		{
			return 0.500000f;
		}
	}
	public class GSkill3265 : GSkill
	{
		public GSkill3265()
			: base(3265)
		{
			
		}
	}
	public class GSkill3266Stub : GSkillStub
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
				int				skill_level = skill.GetLevel();
				int				skill_t1 = skill.GetT1();
				int				skill_t3 = skill.GetT3();

				skill.SetRatio((skill_t3 * 0.07000000000000001f + 1.04f));
				skill.SetPlus(((skill_t1 * 0.15f + 1.0f) * (((26 * skill_level) + (skill_level * (skill_level * 0.21f)) + 50.0f) * (D2INT(skill_level * 0.05f + 0.55f)) + (((D2INT(1.42f - skill_level * 0.05f)) * (6 * skill_level + 203))))));
				player.SetPerform(1);
			}
		}
		public GSkill3266Stub()
			: base(3266)
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
			SetAction(0,"ÌìÒôËÂ_½ð¸Õ¾­");
			SetAction(1,"ÌìÒôËÂ_½ð¸Õ¾­");
			SetAction(2,"ÌìÒôËÂ_½ð¸Õ¾­");
			SetAction(3,"ÌìÒôËÂ_½ð¸Õ¾­");
			SetAction(4,"ÌìÒôËÂ_½ð¸Õ¾­");
			SetAction(5,"ÌìÒôËÂ_½ð¸Õ¾­");
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
			SetAction(18,"ÌìÒôËÂ_Æï³Ë_½ð¸Õ¾­");
			SetAction(19,"ÌìÒôËÂ_Æï³Ë_½ð¸Õ¾­");
			SetAction(20,"ÌìÒôËÂ_Æï³Ë_½ð¸Õ¾­");
			SetAction(21,"ÌìÒôËÂ_Æï³Ë_½ð¸Õ¾­");
			SetAction(22,"ÌìÒôËÂ_Æï³Ë_½ð¸Õ¾­");
			SetAction(23,"ÌìÒôËÂ_Æï³Ë_½ð¸Õ¾­");
			SetAction(24,"");
			SetAction(25,"");
			SetAction(26,"");
			SetAction(27,"");
			SetAction(28,"");
			SetAction(29,"");
			SetAction(30,"");
			name = "ÌìÒô-½ð¸Õ¾­";
			nativename = "ÌìÒô-½ð¸Õ¾­";
			icon = "½ð¸Õ¾­.dds";
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
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_level = player.GetLevel();

			victim.SetProbability(100.0f);
			victim.SetTime(800.0f);
			victim.SetRatio(1.0f);
			victim.SetBuffid(1);
			victim.SetDecdefence(true);
			victim.SetProbability(120.0f);
			victim.SetTime(8000.0f);
			victim.SetBuffid(1);
			victim.SetAmount(((100 * player_level)));
			victim.SetValue(0.0f);
			victim.SetHpleak(true);
			return true;
		}
	}
	public class GSkill3266 : GSkill
	{
		public GSkill3266()
			: base(3266)
		{
			
		}
	}
	public class GSkill3267Stub : GSkillStub
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
				return 600;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				skill_level = skill.GetLevel();
				int				skill_t0 = skill.GetT0();
				int				skill_t1 = skill.GetT1();
				int				skill_t2 = skill.GetT2();

				skill.SetRatio((skill_t1 * 0.07000000000000001f + 1.0f));
				skill.SetPlus(((D2INT((zrand(7 * skill_t2 + 99)) / 100) + 1) * ((skill_t0 * 0.15f + 1.0f) * (((skill_level * (skill_level * 2.1f)) - skill_level * 0.043f + 663.0f) * (D2INT(skill_level * 0.05f + 0.55f)) + (((13 * skill_level) + (skill_level * (skill_level * 0.07099999999999999f)) + 623.0f) * (D2INT(1.42f - skill_level * 0.05f)))))));
				player.SetPerform(1);
			}
			public override bool Cancel(GSkill skill)
			{
				return true;
			}
		}
		public class GState3 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 600;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				skill_level = skill.GetLevel();
				int				skill_t0 = skill.GetT0();
				int				skill_t1 = skill.GetT1();
				int				skill_t2 = skill.GetT2();

				skill.SetRatio((skill_t1 * 0.07000000000000001f + 1.0f));
				skill.SetPlus(((D2INT((zrand(7 * skill_t2 + 99)) / 100) + 1) * ((skill_t0 * 0.15f + 1.0f) * (((skill_level * (skill_level * 2.1f)) - skill_level * 0.043f + 663.0f) * (D2INT(skill_level * 0.05f + 0.55f)) + (((13 * skill_level) + (skill_level * (skill_level * 0.07099999999999999f)) + 623.0f) * (D2INT(1.42f - skill_level * 0.05f)))))));
				player.SetPerform(0);
			}
		}
		public GSkill3267Stub()
			: base(3267)
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
			rangetype = 3;
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
			SetAction(0,"ÌìÒôËÂ_Äé»¨ÃîÚÐ");
			SetAction(1,"ÌìÒôËÂ_Äé»¨ÃîÚÐ");
			SetAction(2,"ÌìÒôËÂ_Äé»¨ÃîÚÐ");
			SetAction(3,"ÌìÒôËÂ_Äé»¨ÃîÚÐ");
			SetAction(4,"ÌìÒôËÂ_Äé»¨ÃîÚÐ");
			SetAction(5,"ÌìÒôËÂ_Äé»¨ÃîÚÐ");
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
			SetAction(18,"ÌìÒôËÂ_Æï³Ë_Äé»¨ÃîÚÐ");
			SetAction(19,"ÌìÒôËÂ_Æï³Ë_Äé»¨ÃîÚÐ");
			SetAction(20,"ÌìÒôËÂ_Æï³Ë_Äé»¨ÃîÚÐ");
			SetAction(21,"ÌìÒôËÂ_Æï³Ë_Äé»¨ÃîÚÐ");
			SetAction(22,"ÌìÒôËÂ_Æï³Ë_Äé»¨ÃîÚÐ");
			SetAction(23,"ÌìÒôËÂ_Æï³Ë_Äé»¨ÃîÚÐ");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "ÌìÒô-Äé»¨ÃîÚÐ";
			nativename = "ÌìÒô-Äé»¨ÃîÚÐ";
			icon = "Äé»¨ÃîÚÐ.dds";
			SetTalent(0,697);
			SetTalent(1,702);
			SetTalent(2,708);
			SetTalent(3,713);
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
			return 7000;
		}
		public override int GetEnmity(GSkill skill)
		{
			return 1;
		}
		public override float GetRadius(GSkill skill)
		{
			return 20.000000f;
		}
		public override float GetPraydistance(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (skill_level + 16);
		}
		public override float GetCastdistance(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (skill_level + 10.7f);
		}
		public override float GetEffectdistance(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (skill_level + 19);
		}
		public override float GetMpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return ((6 * skill_level) + (skill_level * (skill_level * 1.3f)) + 910.0f);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetProbability(750.0f);
			victim.SetTime(12000.0f);
			victim.SetValue(0.0f);
			victim.SetSleep(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetValue(((zrand(50000) + 100000)));
			victim.SetJuqi(true);
			return true;
		}
	}
	public class GSkill3267 : GSkill
	{
		public GSkill3267()
			: base(3267)
		{
			
		}
	}
	public class GSkill3268Stub : GSkillStub
	{
		public class GState1 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 1800;
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
				int				skill_level = skill.GetLevel();

				skill.SetCrit(0.2f);
				skill.SetRatio(1.8f);
				skill.SetPlus(((11 * skill_level + 2320)));
				player.SetPerform(1);
			}
			public override bool Cancel(GSkill skill)
			{
				return true;
			}
		}
		public GSkill3268Stub()
			: base(3268)
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
			rangetype = 2;
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
			weapon_limit = 7;
			SetAction(0,"ÊÞÉñ_Á¬É½");
			SetAction(1,"0");
			SetAction(2,"0");
			SetAction(3,"0");
			SetAction(4,"0");
			SetAction(5,"0");
			SetAction(6,"0");
			SetAction(7,"ÊÞÉñ_Á¬É½");
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
			SetAction(18,"ÊÞÉñ_Æï³Ë_Á¬É½");
			SetAction(19,"0");
			SetAction(20,"0");
			SetAction(21,"0");
			SetAction(22,"0");
			SetAction(23,"0");
			SetAction(24,"0");
			SetAction(25,"ÊÞÉñ_Æï³Ë_Á¬É½");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "¾ÅÀè-Á¬É½";
			nativename = "¾ÅÀè-Á¬É½";
			icon = "Á¬É½.dds";
			SetTalent(0,2093);
			SetTalent(1,2095);
			SetTalent(2,2096);
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
			int				skill_t0 = skill.GetT0();

			return 8000 - 1000 * skill_t0;
		}
		public override int GetEnmity(GSkill skill)
		{
			return 1;
		}
		public override float GetRadius(GSkill skill)
		{
			return 12.000000f;
		}
		public override float GetAngle(GSkill skill)
		{
			return -0.999998f;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 6.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 4.000000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 6.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (13 * skill_level + 395);
		}
		public override int GetCoverage(GSkill skill)
		{
			return 4;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetProbability(620.0f);
			victim.SetTime(6000.0f);
			victim.SetWrap(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetProbability(120.0f);
			victim.SetAmount(1.0f);
			victim.SetValue(0.2f);
			victim.SetLongxiang(true);
			return true;
		}
	}
	public class GSkill3268 : GSkill
	{
		public GSkill3268()
			: base(3268)
		{
			
		}
	}
	public class GSkill3269Stub : GSkillStub
	{
		public class GState1 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 1800;
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
				int				skill_level = skill.GetLevel();

				skill.SetRatio((skill_level * 0.01f + 1.42f));
				skill.SetPlus(((43 * skill_level + 1752)));
				player.SetPerform(1);
			}
		}
		public GSkill3269Stub()
			: base(3269)
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
			weapon_limit = 7;
			SetAction(0,"ÊÞÉñ_É±Â¾");
			SetAction(1,"0");
			SetAction(2,"0");
			SetAction(3,"0");
			SetAction(4,"0");
			SetAction(5,"0");
			SetAction(6,"0");
			SetAction(7,"ÊÞÉñ_É±Â¾");
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
			SetAction(18,"ÊÞÉñ_Æï³Ë_É±Â¾");
			SetAction(19,"0");
			SetAction(20,"0");
			SetAction(21,"0");
			SetAction(22,"0");
			SetAction(23,"0");
			SetAction(24,"0");
			SetAction(25,"ÊÞÉñ_Æï³Ë_É±Â¾");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "¾ÅÀè-É±Â¾";
			nativename = "¾ÅÀè-É±Â¾";
			icon = "É±Â¾.dds";
			SetTalent(0,2086);
			SetTalent(1,2087);
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
		public override int GetEnmity(GSkill skill)
		{
			return 1;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 9.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 4.700000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 14.000000f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_hp = player.GetHp();
			int				player_maxhp = player.GetMaxhp();

			/*
			if ( player_maxhp * 0.5f <= player_hp )
			d = 0.0f;
			else
			victim.SetProbability(120.0f);
			victim.SetTime(300.0f);
			victim.SetBuffid(1);
			victim.SetAmount(((player_maxhp + 1)));
			victim.SetValue(0.0f);
			victim.SetHpleak(true);
			*/
			return true;
		}
	}
	public class GSkill3269 : GSkill
	{
		public GSkill3269()
			: base(3269)
		{
			
		}
	}
}
