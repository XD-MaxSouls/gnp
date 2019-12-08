using System;
using System.Text;

namespace SKILL
{
	public class GSkill3970Stub : GSkillStub
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
				int				skill_level = skill.GetLevel();

				skill.SetRatio((skill_level * 0.01f + 1.0f));
				player.SetPerform(1);
			}
		}
		public GSkill3970Stub()
			: base(3970)
		{
			occupation = 128;
			maxlevel = 99;
			maxlearn = 99;
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
			SetAction(0,"0");
			SetAction(1,"0");
			SetAction(2,"0");
			SetAction(3,"0");
			SetAction(4,"0");
			SetAction(5,"0");
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
			SetAction(18,"0");
			SetAction(19,"0");
			SetAction(20,"0");
			SetAction(21,"0");
			SetAction(22,"0");
			SetAction(23,"0");
			SetAction(24,"");
			SetAction(25,"");
			SetAction(26,"");
			SetAction(27,"");
			SetAction(28,"");
			SetAction(29,"");
			SetAction(30,"");
			name = "≈¿À˛- ’ªÿ’ŸªΩ ﬁ";
			nativename = "≈¿À˛- ’ªÿ’ŸªΩ ﬁ";
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
			return 16.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 8.000000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 20.000000f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetProbability(130.0f);
			victim.SetRatio(1.0f);
			victim.SetUnsummon(true);
			victim.SetProbability(100.0f);
			victim.SetRatio(2.0f);
			victim.SetUnsummon(true);
			victim.SetProbability(100.0f);
			victim.SetRatio(3.0f);
			victim.SetUnsummonclone(true);
			return true;
		}
	}
	public class GSkill3970 : GSkill
	{
		public GSkill3970()
			: base(3970)
		{
			
		}
	}
	public class GSkill3971Stub : GSkillStub
	{
		public class GState1 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 100;
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
				return 100;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				skill_level = skill.GetLevel();

				skill.SetRatio((skill_level * 0.03f + 1.0f));
				player.SetPerform(1);
			}
		}
		public GSkill3971Stub()
			: base(3971)
		{
			occupation = 128;
			maxlevel = 99;
			maxlearn = 99;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 1;
			timetype = 0;
			targettype = 0;
			rangetype = 3;
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
			name = "≈¿À˛-«ø¡¶»∫π•";
			nativename = "≈¿À˛-«ø¡¶»∫π•";
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
			return 200;
		}
		public override float GetRadius(GSkill skill)
		{
			return 20.000000f;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 15.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 10.000000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 25.000000f;
		}
	}
	public class GSkill3971 : GSkill
	{
		public GSkill3971()
			: base(3971)
		{
			
		}
	}
	public class GSkill3972Stub : GSkillStub
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
		public GSkill3972Stub()
			: base(3972)
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
			name = "∂™ÀÆ«Únpc";
			nativename = "∂™ÀÆ«Únpc";
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
			return 20.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 20.000000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 30.000000f;
		}
	}
	public class GSkill3972 : GSkill
	{
		public GSkill3972()
			: base(3972)
		{
			
		}
	}
	public class GSkill3973Stub : GSkillStub
	{
		public class GState1 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 200;
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
				return 800;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();

				player.SetPerform(1);
			}
		}
		public GSkill3973Stub()
			: base(3973)
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
			name = " ÿª§’ﬂºı…À";
			nativename = " ÿª§’ﬂºı…À";
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
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetProbability(100.0f);
			victim.SetTime(1800000.0f);
			victim.SetRatio(1.0f);
			victim.SetBuffid((zrand(9) + 1));
			victim.SetIncdefence(true);
			return true;
		}
	}
	public class GSkill3973 : GSkill
	{
		public GSkill3973()
			: base(3973)
		{
			
		}
	}
	public class GSkill3974Stub : GSkillStub
	{
		public class GState1 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 400;
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
				return 600;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();

				player.SetPerform(1);
			}
		}
		public GSkill3974Stub()
			: base(3974)
		{
			occupation = 128;
			maxlevel = 9;
			maxlearn = 9;
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
			name = " ÿª§’ﬂ–Ã∑£";
			nativename = " ÿª§’ﬂ–Ã∑£";
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
		public override float GetEffectdistance(GSkill skill)
		{
			return 30.000000f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_maxhp = player.GetMaxhp();

			victim.SetProbability(101.0f);
			victim.SetTime(120000.0f);
			victim.SetRatio(1.2f);
			victim.SetBuffid(25);
			victim.SetAmount(20.0f);
			victim.SetValue((player_maxhp * 0.6f));
			victim.SetHumanbomb(true);
			return true;
		}
	}
	public class GSkill3974 : GSkill
	{
		public GSkill3974()
			: base(3974)
		{
			
		}
	}
	public class GSkill3975Stub : GSkillStub
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
		public GSkill3975Stub()
			: base(3975)
		{
			occupation = 151;
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
			SetAction(0,"πÌÕı◊⁄_ªÿ¥∫");
			SetAction(1,"«‡‘∆√≈_ªÿ¥∫");
			SetAction(2,"πÌÕı◊⁄_ªÿ¥∫");
			SetAction(3,"∫œª∂≈…_ªÿ¥∫");
			SetAction(4,"ÃÏ“ÙÀ¬_ªÿ¥∫");
			SetAction(5,"πÌµ¿_ªÿ¥∫");
			SetAction(6,"∑Ÿœ„π»_ªÿ¥∫");
			SetAction(7," ﬁ…Ò_ªÿ¥∫");
			SetAction(8,"∫¸—˝_ªÿ¥∫");
			SetAction(9,"–˘‘Ø_ªÿ¥∫");
			SetAction(10,"ª≥π‚_ªÿ¥∫");
			SetAction(11,"Ã´Íª_ªÿ¥∫");
			SetAction(12,"ÃÏª™_ªÿ¥∫");
			SetAction(13,"¡ÈŸÌ_ªÿ¥∫");
			SetAction(14,"”¢’–_ªÿ¥∫");
			SetAction(15,"0");
			SetAction(16,"0");
			SetAction(17,"πÈ‘∆_…Ë÷√∆¯—™");
			SetAction(18,"πÌÕı◊⁄_∆Ô≥À_ªÿ¥∫");
			SetAction(19,"«‡‘∆√≈_∆Ô≥À_ªÿ¥∫");
			SetAction(20,"πÌÕı◊⁄_∆Ô≥À_ªÿ¥∫");
			SetAction(21,"∫œª∂≈…_∆Ô≥À_ªÿ¥∫");
			SetAction(22,"ÃÏ“ÙÀ¬_∆Ô≥À_ªÿ¥∫");
			SetAction(23,"πÌµ¿_∆Ô≥À_ªÿ¥∫");
			SetAction(24,"∑Ÿœ„π»_∆Ô≥À_ªÿ¥∫");
			SetAction(25," ﬁ…Ò_∆Ô≥À_ªÿ¥∫");
			SetAction(26,"∫¸—˝_∆Ô≥À_ªÿ¥∫");
			SetAction(27,"–˘‘Ø_∆Ô≥À_ªÿ¥∫");
			SetAction(28,"ª≥π‚_∆Ô≥À_ªÿ¥∫");
			SetAction(29,"Ã´Íª_∆Ô≥À_ªÿ¥∫");
			SetAction(30,"ÃÏª™_∆Ô≥À_ªÿ¥∫");
			name = "∞À√≈∂›º◊°§ªØ…˙";
			nativename = "∞À√≈∂›º◊°§ªØ…˙";
			icon = "∞Æ«È¡º“©.dds";
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
		public override float GetEffectdistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return player_range;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_maxhp = player.GetMaxhp();
			int				player_maxmp = player.GetMaxmp();

			victim.SetProbability(100.0f);
			victim.SetTime(6000.0f);
			victim.SetRatio(0.0f);
			victim.SetBuffid(2);
			victim.SetAmount(0.0f);
			victim.SetValue((player_maxhp * 0.6f));
			victim.SetHpgen(true);
			victim.SetProbability(100.0f);
			victim.SetTime(6000.0f);
			victim.SetBuffid(2);
			victim.SetAmount(0.0f);
			victim.SetValue((player_maxmp * 0.6f));
			victim.SetMpgen(true);
			victim.SetProbability(100.0f);
			victim.SetTime(6000.0f);
			victim.SetBuffid(2);
			victim.SetAmount((player.GetMaxdp() * 0.6f));
			victim.SetValue(0.0f);
			victim.SetDivinityfury(true);
			return true;
		}
	}
	public class GSkill3975 : GSkill
	{
		public GSkill3975()
			: base(3975)
		{
			
		}
	}
	public class GSkill3976Stub : GSkillStub
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
		public GSkill3976Stub()
			: base(3976)
		{
			occupation = 151;
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
			SetAction(0,"πÌÕı◊⁄_æ£º¨");
			SetAction(1,"«‡‘∆√≈_æ£º¨");
			SetAction(2,"πÌÕı◊⁄_æ£º¨");
			SetAction(3,"∫œª∂≈…_æ£º¨");
			SetAction(4,"ÃÏ“ÙÀ¬_æ£º¨");
			SetAction(5,"πÌµ¿_æ£º¨");
			SetAction(6,"∑Ÿœ„_æ£º¨");
			SetAction(7," ﬁ…Ò_æ£º¨");
			SetAction(8,"∫¸—˝_æ£º¨");
			SetAction(9,"–˘‘Ø_æ£º¨");
			SetAction(10,"ª≥π‚_æ£º¨");
			SetAction(11,"Ã´Íª_æ£º¨");
			SetAction(12,"ÃÏª™_æ£º¨");
			SetAction(13,"¡ÈŸÌ_æ£º¨");
			SetAction(14,"”¢’–_æ£º¨");
			SetAction(15,"0");
			SetAction(16,"0");
			SetAction(17,"πÈ‘∆_…Ë÷√∆¯—™");
			SetAction(18,"πÌÕı◊⁄_∆Ô≥À_æ£º¨");
			SetAction(19,"«‡‘∆√≈_∆Ô≥À_æ£º¨");
			SetAction(20,"πÌÕı◊⁄_∆Ô≥À_æ£º¨");
			SetAction(21,"∫œª∂≈…_∆Ô≥À_æ£º¨");
			SetAction(22,"ÃÏ“ÙÀ¬_∆Ô≥À_æ£º¨");
			SetAction(23,"πÌµ¿_∆Ô≥À_æ£º¨");
			SetAction(24,"∑Ÿœ„π»_∆Ô≥À_æ£º¨");
			SetAction(25," ﬁ…Ò_∆Ô≥À_æ£º¨");
			SetAction(26,"∫¸—˝_∆Ô≥À_æ£º¨");
			SetAction(27,"–˘‘Ø_∆Ô≥À_æ£º¨");
			SetAction(28,"ª≥π‚_∆Ô≥À_æ£º¨");
			SetAction(29,"Ã´Íª_∆Ô≥À_æ£º¨");
			SetAction(30,"ÃÏª™_∆Ô≥À_æ£º¨");
			name = "∞À√≈∂›º◊°§æ™…Ò";
			nativename = "∞À√≈∂›º◊°§æ™…Ò";
			icon = "±©ª˜±¨…Àµ¿æﬂ1.dds";
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
		public override float GetEffectdistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return player_range;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetTime(12000.0f);
			victim.SetRatio(0.40000001f);
			victim.SetInccritrate(true);
			victim.SetTime(12000.0f);
			victim.SetRatio(2.0f);
			victim.SetBuffid(1);
			victim.SetIncskilldamage(true);
			victim.SetProbability(120.0f);
			victim.SetTime(12000.0f);
			victim.SetRatio(0.60000002f);
			victim.SetBuffid(1);
			victim.SetIncskillaccu(true);
			return true;
		}
	}
	public class GSkill3976 : GSkill
	{
		public GSkill3976()
			: base(3976)
		{
			
		}
	}
	public class GSkill3977Stub : GSkillStub
	{
		public class GState1 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 400;
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

				player.SetPerform(1);
			}
		}
		public GSkill3977Stub()
			: base(3977)
		{
			occupation = 151;
			maxlevel = 1;
			maxlearn = 0;
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
			SetAction(0,"∑Ÿœ„π»_∑Ÿœ„”Ò≤·°æ”Ò—Ù°ø");
			SetAction(1,"∑Ÿœ„π»_∑Ÿœ„”Ò≤·°æ”Ò—Ù°ø");
			SetAction(2,"∑Ÿœ„π»_∑Ÿœ„”Ò≤·°æ”Ò—Ù°ø");
			SetAction(3,"∑Ÿœ„π»_∑Ÿœ„”Ò≤·°æ”Ò—Ù°ø");
			SetAction(4,"∑Ÿœ„π»_∑Ÿœ„”Ò≤·°æ”Ò—Ù°ø");
			SetAction(5,"∑Ÿœ„π»_∑Ÿœ„”Ò≤·°æ”Ò—Ù°ø");
			SetAction(6,"∑Ÿœ„π»_∑Ÿœ„”Ò≤·°æ”Ò—Ù°ø");
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
			SetAction(17,"πÈ‘∆_…Ë÷√∆¯—™");
			SetAction(18,"∑Ÿœ„π»_∆Ô≥À_∑Ÿœ„”Ò≤·°æ”Ò—Ù°ø");
			SetAction(19,"∑Ÿœ„π»_∆Ô≥À_∑Ÿœ„”Ò≤·°æ”Ò—Ù°ø");
			SetAction(20,"∑Ÿœ„π»_∆Ô≥À_∑Ÿœ„”Ò≤·°æ”Ò—Ù°ø");
			SetAction(21,"∑Ÿœ„π»_∆Ô≥À_∑Ÿœ„”Ò≤·°æ”Ò—Ù°ø");
			SetAction(22,"∑Ÿœ„π»_∆Ô≥À_∑Ÿœ„”Ò≤·°æ”Ò—Ù°ø");
			SetAction(23,"∑Ÿœ„π»_∆Ô≥À_∑Ÿœ„”Ò≤·°æ”Ò—Ù°ø");
			SetAction(24,"∑Ÿœ„π»_∆Ô≥À_∑Ÿœ„”Ò≤·°æ”Ò—Ù°ø");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "∞À√≈∂›º◊°§–›÷π";
			nativename = "∞À√≈∂›º◊°§–›÷π";
			icon = "∞Æ–ƒ≤ ∫Á.dds";
			SetTalent(0,3405);
			SetTalent(1,3406);
			SetTalent(2,3404);
			SetTalent(3,0);
			SetTalent(4,0);
			SetTalent(5,0);
			SetTalent(6,0);
			SetTalent(7,0);
			talent_size = 3;
			talent_type = 0;
			use_proficiency = false;
			inc_proficiency = 0;
			preskillnum = 1;
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
		public override float GetPraydistance(GSkill skill)
		{
			return 13.500000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 12.000000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 15.000000f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();

			/*
			if ( player.GetDebuffcnt() )
			d = 120.0f;
			else
			victim.SetProbability(0.0f);
			victim.SetTime(50.0f);
			victim.SetRatio(5.0f);
			victim.SetBuffid(4);
			if ( (12 * norm(3) + 7) <= player.GetDebuffcnt() )
			{
			if ( 12 * norm(3) + 7 <= 2 )
			{
			LABEL_21:
			v25 = 3635.0f;
			goto LABEL_22;
			}
			}
			else
			{
			if ( player.GetDebuffcnt() <= 2 )
			goto LABEL_21;
			}
			if ( (12 * norm(3) + 7) <= player.GetDebuffcnt() )
			{
			if ( 12 * norm(3) + 7 <= 4 )
			{
			LABEL_19:
			v24 = 3636.0f;
			goto LABEL_20;
			}
			}
			else
			{
			if ( player.GetDebuffcnt() <= 4 )
			goto LABEL_19;
			}
			if ( (12 * norm(3) + 7) <= player.GetDebuffcnt() )
			{
			if ( 12 * norm(3) + 7 <= 6 )
			{
			LABEL_17:
			v23 = 3637.0f;
			goto LABEL_18;
			}
			}
			else
			{
			if ( player.GetDebuffcnt() <= 6 )
			goto LABEL_17;
			}
			v23 = 3638.0f;
			LABEL_18:
			v24 = v23;
			LABEL_20:
			v25 = v24;
			LABEL_22:
			victim.SetValue(v25);
			victim.SetDelaycast(true);
			victim.SetTime(8000.0f);
			victim.SetBuffid(1);
			victim.SetAmount(13.0f);
			victim.SetTurndebuff(true);
			*/
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={3452};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={1};return array[index];
		}
	}
	public class GSkill3977 : GSkill
	{
		public GSkill3977()
			: base(3977)
		{
			
		}
	}
	public class GSkill3978Stub : GSkillStub
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
		public GSkill3978Stub()
			: base(3978)
		{
			occupation = 151;
			maxlevel = 7;
			maxlearn = 6;
			eventflag = 1;
			spcost = 1;
			reborncount = 0;
			type = 11;
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
			name = "≤‚ ‘≤‚ ‘";
			nativename = "≤‚ ‘≤‚ ‘";
			icon = "—©”µ¿∂πÿ.dds";
			SetTalent(0,5456);
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
			preskillnum = 1;
			cycle = false;
			cyclemode = 0;
			cyclegfx = "";
			skill_class = 14;
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
			return 360000;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 15.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 10.000000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 20.000000f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetProbability(120.0f);
			victim.SetTime(15000.0f);
			victim.SetRatio(0.30000001f);
			victim.SetBuffid(1);
			victim.SetWeak(true);
			victim.SetProbability(120.0f);
			victim.SetTime(15000.0f);
			victim.SetRatio(0.40000001f);
			victim.SetBuffid(1);
			victim.SetSlow(true);
			return true;
		}
	}
	public class GSkill3978 : GSkill
	{
		public GSkill3978()
			: base(3978)
		{
			
		}
	}
	public class GSkill3979Stub : GSkillStub
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
		public GSkill3979Stub()
			: base(3979)
		{
			occupation = 151;
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
			SetAction(0,"πÌÕı◊⁄_øÒ∑Á÷‰");
			SetAction(1,"«‡‘∆√≈_Â–“£”Œ");
			SetAction(2,"πÌÕı◊⁄_øÒ∑Á÷‰");
			SetAction(3,"∫œª∂≈…_∏°π‚");
			SetAction(4,"ÃÏ“ÙÀ¬_“◊ΩÓæ≠");
			SetAction(5,"πÌµ¿_∞ŸπÌ“π––");
			SetAction(6,"«‡‘∆√≈_Â–“£”Œ");
			SetAction(7," ﬁ…Ò_∫·––");
			SetAction(8,"∫¸—˝_∑Á––’ﬂ");
			SetAction(9,"–˘‘Ø_º·∂‹");
			SetAction(10,"ª≥π‚_º”ÀŸ");
			SetAction(11,"Ã´Íª_º”ÀŸ");
			SetAction(12,"ÃÏª™_±º¿◊");
			SetAction(13,"¡ÈŸÌ_º·∂‹");
			SetAction(14,"”¢’–_º·∂‹");
			SetAction(15,"0");
			SetAction(16,"0");
			SetAction(17,"πÈ‘∆_…Ë÷√∆¯—™");
			SetAction(18,"πÌÕı◊⁄_∆Ô≥À_øÒ∑Á÷‰");
			SetAction(19,"«‡‘∆√≈_∆Ô≥À_Â–“£”Œ");
			SetAction(20,"πÌÕı◊⁄_∆Ô≥À_øÒ∑Á÷‰");
			SetAction(21,"∫œª∂≈…_∆Ô≥À_∏°π‚");
			SetAction(22,"ÃÏ“ÙÀ¬_∆Ô≥À_“◊ΩÓæ≠");
			SetAction(23,"πÌµ¿_∆Ô≥À_∞ŸπÌ“π––");
			SetAction(24,"«‡‘∆√≈_∆Ô≥À_Â–“£”Œ");
			SetAction(25," ﬁ…Ò_∆Ô≥À_∫·––");
			SetAction(26,"∫¸—˝_∆Ô≥À_∑Á––’ﬂ");
			SetAction(27,"–˘‘Ø_∆Ô≥À_º·∂‹");
			SetAction(28,"ª≥π‚_∆Ô≥À_º”ÀŸ");
			SetAction(29,"Ã´Íª_∆Ô≥À_º”ÀŸ");
			SetAction(30,"ÃÏª™_∆Ô≥À_±º¿◊");
			name = "∞À√≈∂›º◊°§ø™ÃÏ";
			nativename = "∞À√≈∂›º◊°§ø™ÃÏ";
			icon = "≥ø∑Á÷Æ‘∏.dds";
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

			victim.SetTime(20000.0f);
			victim.SetRatio(0.30000001f);
			victim.SetBuffid(1);
			victim.SetIncanti(true);
			return true;
		}
	}
	public class GSkill3979 : GSkill
	{
		public GSkill3979()
			: base(3979)
		{
			
		}
	}
}
