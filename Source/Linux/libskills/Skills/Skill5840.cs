using System;
using System.Text;

namespace SKILL
{
	public class GSkill5840Stub : GSkillStub
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
		public GSkill5840Stub()
			: base(5840)
		{
			occupation = 151;
			maxlevel = 3;
			maxlearn = 3;
			eventflag = 0;
			spcost = 0;
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
			SetAction(0,"πÌÕı◊⁄_√Õª÷‰");
			SetAction(1,"πÌÕı◊⁄_√Õª÷‰");
			SetAction(2,"πÌÕı◊⁄_√Õª÷‰");
			SetAction(3,"πÌÕı◊⁄_√Õª÷‰");
			SetAction(4,"πÌÕı◊⁄_√Õª÷‰");
			SetAction(5,"πÌÕı◊⁄_√Õª÷‰");
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
			SetAction(18,"πÌÕı◊⁄_∆Ô≥À_√Õª÷‰");
			SetAction(19,"πÌÕı◊⁄_∆Ô≥À_√Õª÷‰");
			SetAction(20,"πÌÕı◊⁄_∆Ô≥À_√Õª÷‰");
			SetAction(21,"πÌÕı◊⁄_∆Ô≥À_√Õª÷‰");
			SetAction(22,"πÌÕı◊⁄_∆Ô≥À_√Õª÷‰");
			SetAction(23,"πÌÕı◊⁄_∆Ô≥À_√Õª÷‰");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "√Õª÷‰III °∂”¢–€°∑";
			nativename = "√Õª÷‰III °∂”¢–€°∑";
			icon = "√Õª÷‰4.dds";
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
			return 1000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			return 360000;
		}
		public override int GetEnmity(GSkill skill)
		{
			return 1;
		}
		public override float GetMpcost(GSkill skill)
		{
			return 1000.000000f;
		}
	}
	public class GSkill5840 : GSkill
	{
		public GSkill5840()
			: base(5840)
		{
			
		}
	}
	public class GSkill5841Stub : GSkillStub
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
		public GSkill5841Stub()
			: base(5841)
		{
			occupation = 151;
			maxlevel = 3;
			maxlearn = 3;
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
			SetAction(0,"∫œª∂≈…_∆Ì∏£");
			SetAction(1,"∫œª∂≈…_∆Ì∏£");
			SetAction(2,"∫œª∂≈…_∆Ì∏£");
			SetAction(3,"∫œª∂≈…_∆Ì∏£");
			SetAction(4,"∫œª∂≈…_∆Ì∏£");
			SetAction(5,"∫œª∂≈…_∆Ì∏£");
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
			SetAction(18,"∫œª∂≈…_∆Ô≥À_∆Ì∏£");
			SetAction(19,"∫œª∂≈…_∆Ô≥À_∆Ì∏£");
			SetAction(20,"∫œª∂≈…_∆Ô≥À_∆Ì∏£");
			SetAction(21,"∫œª∂≈…_∆Ô≥À_∆Ì∏£");
			SetAction(22,"∫œª∂≈…_∆Ô≥À_∆Ì∏£");
			SetAction(23,"∫œª∂≈…_∆Ô≥À_∆Ì∏£");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "∆Ì∏£III  °∂ÃÏø’°∑";
			nativename = "∆Ì∏£III  °∂ÃÏø’°∑";
			icon = "∆Ì∏£1.dds";
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
			skill_class = 1;
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
		public override int GetEnmity(GSkill skill)
		{
			return 1;
		}
		public override float GetMpcost(GSkill skill)
		{
			return 1000.000000f;
		}
	}
	public class GSkill5841 : GSkill
	{
		public GSkill5841()
			: base(5841)
		{
			
		}
	}
	public class GSkill5842Stub : GSkillStub
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
		public GSkill5842Stub()
			: base(5842)
		{
			occupation = 151;
			maxlevel = 3;
			maxlearn = 3;
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
			SetAction(0,"∫œª∂≈…_∆Ì∏£");
			SetAction(1,"∫œª∂≈…_∆Ì∏£");
			SetAction(2,"∫œª∂≈…_∆Ì∏£");
			SetAction(3,"∫œª∂≈…_∆Ì∏£");
			SetAction(4,"∫œª∂≈…_∆Ì∏£");
			SetAction(5,"∫œª∂≈…_∆Ì∏£");
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
			SetAction(18,"∫œª∂≈…_∆Ô≥À_∆Ì∏£");
			SetAction(19,"∫œª∂≈…_∆Ô≥À_∆Ì∏£");
			SetAction(20,"∫œª∂≈…_∆Ô≥À_∆Ì∏£");
			SetAction(21,"∫œª∂≈…_∆Ô≥À_∆Ì∏£");
			SetAction(22,"∫œª∂≈…_∆Ô≥À_∆Ì∏£");
			SetAction(23,"∫œª∂≈…_∆Ô≥À_∆Ì∏£");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "∆Ì∏£III  °∂±Ã∫£°∑";
			nativename = "∆Ì∏£III  °∂±Ã∫£°∑";
			icon = "∆Ì∏£2.dds";
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
			skill_class = 1;
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
		public override int GetEnmity(GSkill skill)
		{
			return 1;
		}
		public override float GetMpcost(GSkill skill)
		{
			return 1000.000000f;
		}
	}
	public class GSkill5842 : GSkill
	{
		public GSkill5842()
			: base(5842)
		{
			
		}
	}
	public class GSkill5843Stub : GSkillStub
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
		public GSkill5843Stub()
			: base(5843)
		{
			occupation = 151;
			maxlevel = 3;
			maxlearn = 3;
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
			SetAction(0,"∫œª∂≈…_∆Ì∏£");
			SetAction(1,"∫œª∂≈…_∆Ì∏£");
			SetAction(2,"∫œª∂≈…_∆Ì∏£");
			SetAction(3,"∫œª∂≈…_∆Ì∏£");
			SetAction(4,"∫œª∂≈…_∆Ì∏£");
			SetAction(5,"∫œª∂≈…_∆Ì∏£");
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
			SetAction(18,"∫œª∂≈…_∆Ô≥À_∆Ì∏£");
			SetAction(19,"∫œª∂≈…_∆Ô≥À_∆Ì∏£");
			SetAction(20,"∫œª∂≈…_∆Ô≥À_∆Ì∏£");
			SetAction(21,"∫œª∂≈…_∆Ô≥À_∆Ì∏£");
			SetAction(22,"∫œª∂≈…_∆Ô≥À_∆Ì∏£");
			SetAction(23,"∫œª∂≈…_∆Ô≥À_∆Ì∏£");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "∆Ì∏£III  °∂¥Ûµÿ°∑";
			nativename = "∆Ì∏£III  °∂¥Ûµÿ°∑";
			icon = "∆Ì∏£3.dds";
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
			skill_class = 1;
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
		public override int GetEnmity(GSkill skill)
		{
			return 1;
		}
		public override float GetMpcost(GSkill skill)
		{
			return 1000.000000f;
		}
	}
	public class GSkill5843 : GSkill
	{
		public GSkill5843()
			: base(5843)
		{
			
		}
	}
	public class GSkill5844Stub : GSkillStub
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
		public GSkill5844Stub()
			: base(5844)
		{
			occupation = 151;
			maxlevel = 3;
			maxlearn = 3;
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
			SetAction(0,"∫œª∂≈…_∆Ì∏£");
			SetAction(1,"∫œª∂≈…_∆Ì∏£");
			SetAction(2,"∫œª∂≈…_∆Ì∏£");
			SetAction(3,"∫œª∂≈…_∆Ì∏£");
			SetAction(4,"∫œª∂≈…_∆Ì∏£");
			SetAction(5,"∫œª∂≈…_∆Ì∏£");
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
			SetAction(18,"∫œª∂≈…_∆Ô≥À_∆Ì∏£");
			SetAction(19,"∫œª∂≈…_∆Ô≥À_∆Ì∏£");
			SetAction(20,"∫œª∂≈…_∆Ô≥À_∆Ì∏£");
			SetAction(21,"∫œª∂≈…_∆Ô≥À_∆Ì∏£");
			SetAction(22,"∫œª∂≈…_∆Ô≥À_∆Ì∏£");
			SetAction(23,"∫œª∂≈…_∆Ô≥À_∆Ì∏£");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "∆Ì∏£III  °∂”¢–€°∑";
			nativename = "∆Ì∏£III  °∂”¢–€°∑";
			icon = "∆Ì∏£4.dds";
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
			skill_class = 1;
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
		public override int GetEnmity(GSkill skill)
		{
			return 1;
		}
		public override float GetMpcost(GSkill skill)
		{
			return 1000.000000f;
		}
	}
	public class GSkill5844 : GSkill
	{
		public GSkill5844()
			: base(5844)
		{
			
		}
	}
	public class GSkill5845Stub : GSkillStub
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
		public GSkill5845Stub()
			: base(5845)
		{
			occupation = 151;
			maxlevel = 3;
			maxlearn = 3;
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
			SetAction(0,"ÃÏ“ÙÀ¬_¥Û∑≤∞„»Ù");
			SetAction(1,"ÃÏ“ÙÀ¬_¥Û∑≤∞„»Ù");
			SetAction(2,"ÃÏ“ÙÀ¬_¥Û∑≤∞„»Ù");
			SetAction(3,"ÃÏ“ÙÀ¬_¥Û∑≤∞„»Ù");
			SetAction(4,"ÃÏ“ÙÀ¬_¥Û∑≤∞„»Ù");
			SetAction(5,"ÃÏ“ÙÀ¬_¥Û∑≤∞„»Ù");
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
			SetAction(18,"ÃÏ“ÙÀ¬_∆Ô≥À_¥Û∑≤∞„»Ù");
			SetAction(19,"ÃÏ“ÙÀ¬_∆Ô≥À_¥Û∑≤∞„»Ù");
			SetAction(20,"ÃÏ“ÙÀ¬_∆Ô≥À_¥Û∑≤∞„»Ù");
			SetAction(21,"ÃÏ“ÙÀ¬_∆Ô≥À_¥Û∑≤∞„»Ù");
			SetAction(22,"ÃÏ“ÙÀ¬_∆Ô≥À_¥Û∑≤∞„»Ù");
			SetAction(23,"ÃÏ“ÙÀ¬_∆Ô≥À_¥Û∑≤∞„»Ù");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "¥ÛËÛ∞„»ÙIII  °∂ÃÏø’°∑";
			nativename = "¥ÛËÛ∞„»ÙIII  °∂ÃÏø’°∑";
			icon = "¥Û∑≤∞„»Ù1.dds";
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
		public override int GetExecutetime(GSkill skill)
		{
			return 1000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			return 80000;
		}
		public override float GetMpcost(GSkill skill)
		{
			return 1000.000000f;
		}
	}
	public class GSkill5845 : GSkill
	{
		public GSkill5845()
			: base(5845)
		{
			
		}
	}
	public class GSkill5846Stub : GSkillStub
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
		public GSkill5846Stub()
			: base(5846)
		{
			occupation = 151;
			maxlevel = 3;
			maxlearn = 3;
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
			SetAction(0,"ÃÏ“ÙÀ¬_¥Û∑≤∞„»Ù");
			SetAction(1,"ÃÏ“ÙÀ¬_¥Û∑≤∞„»Ù");
			SetAction(2,"ÃÏ“ÙÀ¬_¥Û∑≤∞„»Ù");
			SetAction(3,"ÃÏ“ÙÀ¬_¥Û∑≤∞„»Ù");
			SetAction(4,"ÃÏ“ÙÀ¬_¥Û∑≤∞„»Ù");
			SetAction(5,"ÃÏ“ÙÀ¬_¥Û∑≤∞„»Ù");
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
			SetAction(18,"ÃÏ“ÙÀ¬_∆Ô≥À_¥Û∑≤∞„»Ù");
			SetAction(19,"ÃÏ“ÙÀ¬_∆Ô≥À_¥Û∑≤∞„»Ù");
			SetAction(20,"ÃÏ“ÙÀ¬_∆Ô≥À_¥Û∑≤∞„»Ù");
			SetAction(21,"ÃÏ“ÙÀ¬_∆Ô≥À_¥Û∑≤∞„»Ù");
			SetAction(22,"ÃÏ“ÙÀ¬_∆Ô≥À_¥Û∑≤∞„»Ù");
			SetAction(23,"ÃÏ“ÙÀ¬_∆Ô≥À_¥Û∑≤∞„»Ù");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "¥ÛËÛ∞„»ÙIII  °∂±Ã∫£°∑";
			nativename = "¥ÛËÛ∞„»ÙIII  °∂±Ã∫£°∑";
			icon = "¥Û∑≤∞„»Ù2.dds";
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
		public override int GetExecutetime(GSkill skill)
		{
			return 1000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			return 80000;
		}
		public override float GetMpcost(GSkill skill)
		{
			return 1000.000000f;
		}
	}
	public class GSkill5846 : GSkill
	{
		public GSkill5846()
			: base(5846)
		{
			
		}
	}
	public class GSkill5847Stub : GSkillStub
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
		public GSkill5847Stub()
			: base(5847)
		{
			occupation = 151;
			maxlevel = 3;
			maxlearn = 3;
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
			SetAction(0,"ÃÏ“ÙÀ¬_¥Û∑≤∞„»Ù");
			SetAction(1,"ÃÏ“ÙÀ¬_¥Û∑≤∞„»Ù");
			SetAction(2,"ÃÏ“ÙÀ¬_¥Û∑≤∞„»Ù");
			SetAction(3,"ÃÏ“ÙÀ¬_¥Û∑≤∞„»Ù");
			SetAction(4,"ÃÏ“ÙÀ¬_¥Û∑≤∞„»Ù");
			SetAction(5,"ÃÏ“ÙÀ¬_¥Û∑≤∞„»Ù");
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
			SetAction(18,"ÃÏ“ÙÀ¬_∆Ô≥À_¥Û∑≤∞„»Ù");
			SetAction(19,"ÃÏ“ÙÀ¬_∆Ô≥À_¥Û∑≤∞„»Ù");
			SetAction(20,"ÃÏ“ÙÀ¬_∆Ô≥À_¥Û∑≤∞„»Ù");
			SetAction(21,"ÃÏ“ÙÀ¬_∆Ô≥À_¥Û∑≤∞„»Ù");
			SetAction(22,"ÃÏ“ÙÀ¬_∆Ô≥À_¥Û∑≤∞„»Ù");
			SetAction(23,"ÃÏ“ÙÀ¬_∆Ô≥À_¥Û∑≤∞„»Ù");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "¥ÛËÛ∞„»ÙIII  °∂¥Ûµÿ°∑";
			nativename = "¥ÛËÛ∞„»ÙIII  °∂¥Ûµÿ°∑";
			icon = "¥Û∑≤∞„»Ù3.dds";
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
		public override int GetExecutetime(GSkill skill)
		{
			return 1000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			return 80000;
		}
		public override float GetMpcost(GSkill skill)
		{
			return 1000.000000f;
		}
	}
	public class GSkill5847 : GSkill
	{
		public GSkill5847()
			: base(5847)
		{
			
		}
	}
	public class GSkill5848Stub : GSkillStub
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
		public GSkill5848Stub()
			: base(5848)
		{
			occupation = 151;
			maxlevel = 3;
			maxlearn = 3;
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
			SetAction(0,"ÃÏ“ÙÀ¬_¥Û∑≤∞„»Ù");
			SetAction(1,"ÃÏ“ÙÀ¬_¥Û∑≤∞„»Ù");
			SetAction(2,"ÃÏ“ÙÀ¬_¥Û∑≤∞„»Ù");
			SetAction(3,"ÃÏ“ÙÀ¬_¥Û∑≤∞„»Ù");
			SetAction(4,"ÃÏ“ÙÀ¬_¥Û∑≤∞„»Ù");
			SetAction(5,"ÃÏ“ÙÀ¬_¥Û∑≤∞„»Ù");
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
			SetAction(18,"ÃÏ“ÙÀ¬_∆Ô≥À_¥Û∑≤∞„»Ù");
			SetAction(19,"ÃÏ“ÙÀ¬_∆Ô≥À_¥Û∑≤∞„»Ù");
			SetAction(20,"ÃÏ“ÙÀ¬_∆Ô≥À_¥Û∑≤∞„»Ù");
			SetAction(21,"ÃÏ“ÙÀ¬_∆Ô≥À_¥Û∑≤∞„»Ù");
			SetAction(22,"ÃÏ“ÙÀ¬_∆Ô≥À_¥Û∑≤∞„»Ù");
			SetAction(23,"ÃÏ“ÙÀ¬_∆Ô≥À_¥Û∑≤∞„»Ù");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "¥ÛËÛ∞„»ÙIII  °∂”¢–€°∑";
			nativename = "¥ÛËÛ∞„»ÙIII  °∂”¢–€°∑";
			icon = "¥Û∑≤∞„»Ù4.dds";
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
		public override int GetExecutetime(GSkill skill)
		{
			return 1000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			return 80000;
		}
		public override float GetMpcost(GSkill skill)
		{
			return 1000.000000f;
		}
	}
	public class GSkill5848 : GSkill
	{
		public GSkill5848()
			: base(5848)
		{
			
		}
	}
	public class GSkill5849Stub : GSkillStub
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
		public GSkill5849Stub()
			: base(5849)
		{
			occupation = 151;
			maxlevel = 3;
			maxlearn = 3;
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
			SetAction(0,"–∞…Ò∞¡ ¿");
			SetAction(1,"–∞…Ò∞¡ ¿");
			SetAction(2,"–∞…Ò∞¡ ¿");
			SetAction(3,"–∞…Ò∞¡ ¿");
			SetAction(4,"–∞…Ò∞¡ ¿");
			SetAction(5,"–∞…Ò∞¡ ¿");
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
			SetAction(18,"–∞…Ò∞¡ ¿");
			SetAction(19,"–∞…Ò∞¡ ¿");
			SetAction(20,"–∞…Ò∞¡ ¿");
			SetAction(21,"–∞…Ò∞¡ ¿");
			SetAction(22,"–∞…Ò∞¡ ¿");
			SetAction(23,"–∞…Ò∞¡ ¿");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "–∞…Ò∞¡ ¿III  °∂ÃÏø’°∑";
			nativename = "–∞…Ò∞¡ ¿III  °∂ÃÏø’°∑";
			icon = "–∞…Ò∞¡ ¿1.dds";
			SetTalent(0,1109);
			SetTalent(1,1161);
			SetTalent(2,1165);
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
			skill_class = 4;
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
			return 70000;
		}
	}
	public class GSkill5849 : GSkill
	{
		public GSkill5849()
			: base(5849)
		{
			
		}
	}
}
