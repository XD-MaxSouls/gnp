using System;
using System.Text;

namespace SKILL
{
	public class GSkill4660Stub : GSkillStub
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
				return 200;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_maxmp = player.GetMaxmp();
				int				skill_level = skill.GetLevel();
				int				skill_t1 = skill.GetT1();

				player.SetVar1(player_maxmp);
				skill.SetPlus(2000.0f);
				skill.SetPlus2((skill_level * (player_maxmp * 0.015f)));
				skill.SetCrithurt((skill_t1 * 0.1f));
				player.SetPerform(1);
			}
		}
		public GSkill4660Stub()
			: base(4660)
		{
			occupation = 167;
			maxlevel = 20;
			maxlearn = 0;
			eventflag = 0;
			spcost = 0;
			reborncount = 0;
			type = 1;
			timetype = 0;
			targettype = 0;
			rangetype = 11;
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
			weapon_limit = 9;
			SetAction(0,"轩辕_日炎术_02");
			SetAction(1,"0");
			SetAction(2,"0");
			SetAction(3,"0");
			SetAction(4,"0");
			SetAction(5,"0");
			SetAction(6,"0");
			SetAction(7,"0");
			SetAction(8,"0");
			SetAction(9,"轩辕_日炎术_02");
			SetAction(10,"0");
			SetAction(11,"0");
			SetAction(12,"0");
			SetAction(13,"");
			SetAction(14,"");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"轩辕_骑乘_日炎术_02");
			SetAction(19,"0");
			SetAction(20,"0");
			SetAction(21,"0");
			SetAction(22,"0");
			SetAction(23,"0");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"轩辕_骑乘_日炎术_02");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "界·天演式·六道<玄>";
			nativename = "界·天演式·六道<玄>";
			icon = "六道(玄).dds";
			SetTalent(0,4142);
			SetTalent(1,4148);
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
			skill_class = 11;
			guide = false;
			summon_id = 0;
			trigger = true;
			conbutton_sub = false;
			isBabySkill = false;
			castInPreSkill = false;
			preCastSkillId = 0;
			darkLightType = 0;
			followskill = 4661;
			targetcnt = 6;
			excludemonstercnt = 0;

			AddState(new GState1());
			AddState(new GState2());
		}
		public override int GetExecutetime(GSkill skill)
		{
			return 400;
		}
		public override float GetAttackdistance(GSkill skill)
		{
			return 20.000000f;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 17.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 15.000000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 20.000000f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_var1 = player.GetVar1();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();

			/*
			if ( skill_t0 <= 0 )
			d = 0.0f;
			else
			victim.SetProbability(120.0f);
			victim.SetTime(2000.0f);
			victim.SetRatio((skill_t0 * 0.02f));
			victim.SetBuffid(1);
			victim.SetIncfatalratio(true);
			if ( player.GetObjectType() )
			v17 = 0.0f;
			else
			victim.SetProbability(120.0f);
			victim.SetAmount(((skill_level * (0.005f * player_var1)) + (skill_level * (0.005f * player_var1))));
			victim.SetMpdisperse(true);
			*/
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();

			victim.SetProbability(120.0f);
			victim.SetTime(2000.0f);
			victim.SetAmount(skill_level);
			victim.SetValue(4661.0f);
			victim.SetTriggerskill(true);
			victim.SetProbability(120.0f);
			victim.SetTime(1000.0f);
			victim.SetPowerless(true);
			return true;
		}
	}
	public class GSkill4660 : GSkill
	{
		public GSkill4660()
			: base(4660)
		{
			
		}
	}
	public class GSkill4661Stub : GSkillStub
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
				return 200;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_maxmp = player.GetMaxmp();
				int				skill_level = skill.GetLevel();
				int				skill_t1 = skill.GetT1();

				player.SetVar1(player_maxmp);
				skill.SetPlus(2000.0f);
				skill.SetPlus2((skill_level * (player_maxmp * 0.02f)));
				skill.SetCrithurt((skill_t1 * 0.15f));
				player.SetPerform(1);
			}
		}
		public GSkill4661Stub()
			: base(4661)
		{
			occupation = 167;
			maxlevel = 20;
			maxlearn = 0;
			eventflag = 0;
			spcost = 0;
			reborncount = 0;
			type = 1;
			timetype = 0;
			targettype = 0;
			rangetype = 11;
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
			weapon_limit = 9;
			SetAction(0,"轩辕_日炎术_02");
			SetAction(1,"0");
			SetAction(2,"0");
			SetAction(3,"0");
			SetAction(4,"0");
			SetAction(5,"0");
			SetAction(6,"0");
			SetAction(7,"0");
			SetAction(8,"0");
			SetAction(9,"轩辕_日炎术_02");
			SetAction(10,"0");
			SetAction(11,"0");
			SetAction(12,"0");
			SetAction(13,"");
			SetAction(14,"");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"轩辕_骑乘_日炎术_02");
			SetAction(19,"0");
			SetAction(20,"0");
			SetAction(21,"0");
			SetAction(22,"0");
			SetAction(23,"0");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"轩辕_骑乘_日炎术_02");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "界·天演式·六道<玄>";
			nativename = "界·天演式·六道<玄>";
			icon = "六道(玄).dds";
			SetTalent(0,4142);
			SetTalent(1,4148);
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
			skill_class = 11;
			guide = false;
			summon_id = 0;
			trigger = true;
			conbutton_sub = false;
			isBabySkill = false;
			castInPreSkill = false;
			preCastSkillId = 0;
			darkLightType = 0;
			followskill = 4662;
			targetcnt = 6;
			excludemonstercnt = 0;

			AddState(new GState1());
			AddState(new GState2());
		}
		public override int GetExecutetime(GSkill skill)
		{
			return 400;
		}
		public override float GetAttackdistance(GSkill skill)
		{
			return 20.000000f;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 17.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 15.000000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 20.000000f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_var1 = player.GetVar1();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();

			/*
			if ( skill_t0 <= 0 )
			d = 0.0f;
			else
			victim.SetProbability(120.0f);
			victim.SetTime(2000.0f);
			victim.SetRatio((skill_t0 * 0.03f));
			victim.SetBuffid(1);
			victim.SetIncfatalratio(true);
			if ( player.GetObjectType() )
			v16 = 0.0f;
			else
			victim.SetProbability(120.0f);
			victim.SetAmount((skill_level * (player_var1 * 0.005f) * 3.0f));
			victim.SetMpdisperse(true);
			*/
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();

			victim.SetProbability(120.0f);
			victim.SetTime(2000.0f);
			victim.SetAmount(skill_level);
			victim.SetValue(4662.0f);
			victim.SetTriggerskill(true);
			victim.SetProbability(120.0f);
			victim.SetTime(1000.0f);
			victim.SetPowerless(true);
			return true;
		}
	}
	public class GSkill4661 : GSkill
	{
		public GSkill4661()
			: base(4661)
		{
			
		}
	}
	public class GSkill4662Stub : GSkillStub
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
				return 200;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_maxmp = player.GetMaxmp();
				int				skill_level = skill.GetLevel();
				int				skill_t1 = skill.GetT1();

				player.SetVar1(player_maxmp);
				skill.SetPlus(2000.0f);
				skill.SetPlus2((skill_level * (player_maxmp * 0.025f)));
				skill.SetCrithurt((skill_t1 * 0.2f));
				player.SetPerform(1);
			}
		}
		public GSkill4662Stub()
			: base(4662)
		{
			occupation = 167;
			maxlevel = 20;
			maxlearn = 0;
			eventflag = 0;
			spcost = 0;
			reborncount = 0;
			type = 1;
			timetype = 0;
			targettype = 0;
			rangetype = 11;
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
			weapon_limit = 9;
			SetAction(0,"轩辕_日炎术_02");
			SetAction(1,"0");
			SetAction(2,"0");
			SetAction(3,"0");
			SetAction(4,"0");
			SetAction(5,"0");
			SetAction(6,"0");
			SetAction(7,"0");
			SetAction(8,"0");
			SetAction(9,"轩辕_日炎术_02");
			SetAction(10,"0");
			SetAction(11,"0");
			SetAction(12,"0");
			SetAction(13,"");
			SetAction(14,"");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"轩辕_骑乘_日炎术_02");
			SetAction(19,"0");
			SetAction(20,"0");
			SetAction(21,"0");
			SetAction(22,"0");
			SetAction(23,"0");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"轩辕_骑乘_日炎术_02");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "界·天演式·六道<玄>";
			nativename = "界·天演式·六道<玄>";
			icon = "六道(玄).dds";
			SetTalent(0,4142);
			SetTalent(1,4148);
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
			skill_class = 11;
			guide = false;
			summon_id = 0;
			trigger = true;
			conbutton_sub = false;
			isBabySkill = false;
			castInPreSkill = false;
			preCastSkillId = 0;
			darkLightType = 0;
			followskill = 4663;
			targetcnt = 6;
			excludemonstercnt = 0;

			AddState(new GState1());
			AddState(new GState2());
		}
		public override int GetExecutetime(GSkill skill)
		{
			return 400;
		}
		public override float GetAttackdistance(GSkill skill)
		{
			return 20.000000f;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 17.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 15.000000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 20.000000f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_var1 = player.GetVar1();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();

			/*
			if ( skill_t0 <= 0 )
			d = 0.0f;
			else
			victim.SetProbability(120.0f);
			victim.SetTime(2000.0f);
			victim.SetRatio((skill_t0 * 0.04f));
			victim.SetBuffid(1);
			victim.SetIncfatalratio(true);
			if ( player.GetObjectType() )
			v16 = 0.0f;
			else
			victim.SetProbability(120.0f);
			victim.SetAmount((skill_level * (player_var1 * 0.005f) * 4.0f));
			victim.SetMpdisperse(true);
			*/
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();

			victim.SetProbability(120.0f);
			victim.SetTime(2000.0f);
			victim.SetAmount(skill_level);
			victim.SetValue(4663.0f);
			victim.SetTriggerskill(true);
			victim.SetProbability(120.0f);
			victim.SetTime(1000.0f);
			victim.SetPowerless(true);
			return true;
		}
	}
	public class GSkill4662 : GSkill
	{
		public GSkill4662()
			: base(4662)
		{
			
		}
	}
	public class GSkill4663Stub : GSkillStub
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
				return 200;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_maxmp = player.GetMaxmp();
				int				skill_level = skill.GetLevel();
				int				skill_t1 = skill.GetT1();

				player.SetVar1(player_maxmp);
				skill.SetPlus(2000.0f);
				skill.SetPlus2((skill_level * (player_maxmp * 0.03f)));
				skill.SetCrithurt((skill_t1 * 0.25f));
				player.SetPerform(1);
			}
		}
		public GSkill4663Stub()
			: base(4663)
		{
			occupation = 167;
			maxlevel = 20;
			maxlearn = 0;
			eventflag = 0;
			spcost = 0;
			reborncount = 0;
			type = 1;
			timetype = 0;
			targettype = 0;
			rangetype = 11;
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
			weapon_limit = 9;
			SetAction(0,"轩辕_日炎术_02");
			SetAction(1,"0");
			SetAction(2,"0");
			SetAction(3,"0");
			SetAction(4,"0");
			SetAction(5,"0");
			SetAction(6,"0");
			SetAction(7,"0");
			SetAction(8,"0");
			SetAction(9,"轩辕_日炎术_02");
			SetAction(10,"0");
			SetAction(11,"0");
			SetAction(12,"0");
			SetAction(13,"");
			SetAction(14,"");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"轩辕_骑乘_日炎术_02");
			SetAction(19,"0");
			SetAction(20,"0");
			SetAction(21,"0");
			SetAction(22,"0");
			SetAction(23,"0");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"轩辕_骑乘_日炎术_02");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "界·天演式·六道<玄>";
			nativename = "界·天演式·六道<玄>";
			icon = "六道(玄).dds";
			SetTalent(0,4142);
			SetTalent(1,4148);
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
			skill_class = 11;
			guide = false;
			summon_id = 0;
			trigger = true;
			conbutton_sub = false;
			isBabySkill = false;
			castInPreSkill = false;
			preCastSkillId = 0;
			darkLightType = 0;
			followskill = 4664;
			targetcnt = 6;
			excludemonstercnt = 0;

			AddState(new GState1());
			AddState(new GState2());
		}
		public override int GetExecutetime(GSkill skill)
		{
			return 400;
		}
		public override float GetAttackdistance(GSkill skill)
		{
			return 20.000000f;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 17.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 15.000000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 20.000000f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_var1 = player.GetVar1();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();

			/*
			if ( skill_t0 <= 0 )
			d = 0.0f;
			else
			victim.SetProbability(120.0f);
			victim.SetTime(2000.0f);
			victim.SetRatio((skill_t0 * 0.05f));
			victim.SetBuffid(1);
			victim.SetIncfatalratio(true);
			if ( player.GetObjectType() )
			v16 = 0.0f;
			else
			victim.SetProbability(120.0f);
			victim.SetAmount((skill_level * (player_var1 * 0.005f) * 5.0f));
			victim.SetMpdisperse(true);
			*/
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();

			victim.SetProbability(120.0f);
			victim.SetTime(2000.0f);
			victim.SetAmount(skill_level);
			victim.SetValue(4664.0f);
			victim.SetTriggerskill(true);
			victim.SetProbability(120.0f);
			victim.SetTime(1000.0f);
			victim.SetPowerless(true);
			return true;
		}
	}
	public class GSkill4663 : GSkill
	{
		public GSkill4663()
			: base(4663)
		{
			
		}
	}
	public class GSkill4664Stub : GSkillStub
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
				return 200;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_maxmp = player.GetMaxmp();
				int				skill_level = skill.GetLevel();
				int				skill_t1 = skill.GetT1();

				player.SetVar1(player_maxmp);
				skill.SetPlus(2000.0f);
				skill.SetPlus2((skill_level * (player_maxmp * 0.035f)));
				skill.SetCrithurt((skill_t1 * 0.3f));
				player.SetPerform(1);
			}
		}
		public GSkill4664Stub()
			: base(4664)
		{
			occupation = 167;
			maxlevel = 20;
			maxlearn = 0;
			eventflag = 0;
			spcost = 0;
			reborncount = 0;
			type = 1;
			timetype = 0;
			targettype = 0;
			rangetype = 11;
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
			weapon_limit = 9;
			SetAction(0,"轩辕_日炎术_02");
			SetAction(1,"0");
			SetAction(2,"0");
			SetAction(3,"0");
			SetAction(4,"0");
			SetAction(5,"0");
			SetAction(6,"0");
			SetAction(7,"0");
			SetAction(8,"0");
			SetAction(9,"轩辕_日炎术_02");
			SetAction(10,"0");
			SetAction(11,"0");
			SetAction(12,"0");
			SetAction(13,"");
			SetAction(14,"");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"轩辕_骑乘_日炎术_02");
			SetAction(19,"0");
			SetAction(20,"0");
			SetAction(21,"0");
			SetAction(22,"0");
			SetAction(23,"0");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"轩辕_骑乘_日炎术_02");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "界·天演式·六道<玄>";
			nativename = "界·天演式·六道<玄>";
			icon = "六道(玄).dds";
			SetTalent(0,4142);
			SetTalent(1,4148);
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
			skill_class = 11;
			guide = false;
			summon_id = 0;
			trigger = true;
			conbutton_sub = false;
			isBabySkill = false;
			castInPreSkill = false;
			preCastSkillId = 0;
			darkLightType = 0;
			followskill = 0;
			targetcnt = 6;
			excludemonstercnt = 0;

			AddState(new GState1());
			AddState(new GState2());
		}
		public override int GetExecutetime(GSkill skill)
		{
			return 400;
		}
		public override float GetAttackdistance(GSkill skill)
		{
			return 20.000000f;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 17.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 15.000000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 20.000000f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_var1 = player.GetVar1();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();

			/*
			if ( skill_t0 <= 0 )
			d = 0.0f;
			else
			victim.SetProbability(120.0f);
			victim.SetTime(2000.0f);
			victim.SetRatio((skill_t0 * 0.06f));
			victim.SetBuffid(1);
			victim.SetIncfatalratio(true);
			if ( player.GetObjectType() )
			v16 = 0.0f;
			else
			victim.SetProbability(120.0f);
			victim.SetAmount((skill_level * (player_var1 * 0.005f) * 6.0f));
			victim.SetMpdisperse(true);
			*/
			return true;
		}
	}
	public class GSkill4664 : GSkill
	{
		public GSkill4664()
			: base(4664)
		{
			
		}
	}
	public class GSkill4665Stub : GSkillStub
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
				return 200;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_maxmp = player.GetMaxmp();
				int				skill_level = skill.GetLevel();
				int				skill_t1 = skill.GetT1();

				skill.SetPlus(2000.0f);
				skill.SetPlus2((skill_level * (player_maxmp * 0.015f)));
				skill.SetCrit((skill_level * 0.005f + skill_level * 0.005f));
				skill.SetCrithurt((skill_t1 * 0.1f));
				player.SetPerform(1);
			}
		}
		public GSkill4665Stub()
			: base(4665)
		{
			occupation = 168;
			maxlevel = 20;
			maxlearn = 0;
			eventflag = 0;
			spcost = 0;
			reborncount = 0;
			type = 1;
			timetype = 0;
			targettype = 0;
			rangetype = 11;
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
			weapon_limit = 9;
			SetAction(0,"轩辕_日炎术_02");
			SetAction(1,"0");
			SetAction(2,"0");
			SetAction(3,"0");
			SetAction(4,"0");
			SetAction(5,"0");
			SetAction(6,"0");
			SetAction(7,"0");
			SetAction(8,"0");
			SetAction(9,"轩辕_日炎术_02");
			SetAction(10,"0");
			SetAction(11,"0");
			SetAction(12,"0");
			SetAction(13,"");
			SetAction(14,"");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"轩辕_骑乘_日炎术_02");
			SetAction(19,"0");
			SetAction(20,"0");
			SetAction(21,"0");
			SetAction(22,"0");
			SetAction(23,"0");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"轩辕_骑乘_日炎术_02");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "界·天演式·六道<煞>";
			nativename = "界·天演式·六道<煞>";
			icon = "六道(煞).dds";
			SetTalent(0,4142);
			SetTalent(1,4148);
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
			skill_class = 11;
			guide = false;
			summon_id = 0;
			trigger = true;
			conbutton_sub = false;
			isBabySkill = false;
			castInPreSkill = false;
			preCastSkillId = 0;
			darkLightType = 0;
			followskill = 4666;
			targetcnt = 6;
			excludemonstercnt = 0;

			AddState(new GState1());
			AddState(new GState2());
		}
		public override int GetExecutetime(GSkill skill)
		{
			return 400;
		}
		public override float GetAttackdistance(GSkill skill)
		{
			return 20.000000f;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 17.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 15.000000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 20.000000f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_t0 = skill.GetT0();

			/*
			if ( skill_t0 <= 0 )
			d = 0.0f;
			else
			victim.SetProbability(120.0f);
			victim.SetTime(2000.0f);
			victim.SetRatio((skill_t0 * 0.02f));
			victim.SetBuffid(1);
			victim.SetIncfatalratio(true);
			*/
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();

			victim.SetProbability(120.0f);
			victim.SetTime(2000.0f);
			victim.SetAmount(skill_level);
			victim.SetValue(4666.0f);
			victim.SetTriggerskill(true);
			victim.SetProbability(120.0f);
			victim.SetTime(1000.0f);
			victim.SetPowerless(true);
			return true;
		}
	}
	public class GSkill4665 : GSkill
	{
		public GSkill4665()
			: base(4665)
		{
			
		}
	}
	public class GSkill4666Stub : GSkillStub
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
				return 200;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_maxmp = player.GetMaxmp();
				int				skill_level = skill.GetLevel();
				int				skill_t1 = skill.GetT1();

				skill.SetPlus(2000.0f);
				skill.SetPlus2((skill_level * (player_maxmp * 0.02f)));
				skill.SetCrit((skill_level * 0.005f * 3.0f));
				skill.SetCrithurt((skill_t1 * 0.15f));
				player.SetPerform(1);
			}
		}
		public GSkill4666Stub()
			: base(4666)
		{
			occupation = 168;
			maxlevel = 20;
			maxlearn = 0;
			eventflag = 0;
			spcost = 0;
			reborncount = 0;
			type = 1;
			timetype = 0;
			targettype = 0;
			rangetype = 11;
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
			weapon_limit = 9;
			SetAction(0,"轩辕_日炎术_02");
			SetAction(1,"0");
			SetAction(2,"0");
			SetAction(3,"0");
			SetAction(4,"0");
			SetAction(5,"0");
			SetAction(6,"0");
			SetAction(7,"0");
			SetAction(8,"0");
			SetAction(9,"轩辕_日炎术_02");
			SetAction(10,"0");
			SetAction(11,"0");
			SetAction(12,"0");
			SetAction(13,"");
			SetAction(14,"");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"轩辕_骑乘_日炎术_02");
			SetAction(19,"0");
			SetAction(20,"0");
			SetAction(21,"0");
			SetAction(22,"0");
			SetAction(23,"0");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"轩辕_骑乘_日炎术_02");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "界·天演式·六道<煞>";
			nativename = "界·天演式·六道<煞>";
			icon = "六道(煞).dds";
			SetTalent(0,4142);
			SetTalent(1,4148);
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
			skill_class = 11;
			guide = false;
			summon_id = 0;
			trigger = true;
			conbutton_sub = false;
			isBabySkill = false;
			castInPreSkill = false;
			preCastSkillId = 0;
			darkLightType = 0;
			followskill = 4667;
			targetcnt = 6;
			excludemonstercnt = 0;

			AddState(new GState1());
			AddState(new GState2());
		}
		public override int GetExecutetime(GSkill skill)
		{
			return 400;
		}
		public override float GetAttackdistance(GSkill skill)
		{
			return 20.000000f;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 17.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 15.000000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 20.000000f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_t0 = skill.GetT0();

			/*
			if ( skill_t0 <= 0 )
			d = 0.0f;
			else
			victim.SetProbability(120.0f);
			victim.SetTime(2000.0f);
			victim.SetRatio((skill_t0 * 0.03f));
			victim.SetBuffid(1);
			victim.SetIncfatalratio(true);
			*/
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();

			victim.SetProbability(120.0f);
			victim.SetTime(2000.0f);
			victim.SetAmount(skill_level);
			victim.SetValue(4667.0f);
			victim.SetTriggerskill(true);
			victim.SetProbability(120.0f);
			victim.SetTime(1000.0f);
			victim.SetPowerless(true);
			return true;
		}
	}
	public class GSkill4666 : GSkill
	{
		public GSkill4666()
			: base(4666)
		{
			
		}
	}
	public class GSkill4667Stub : GSkillStub
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
				return 200;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_maxmp = player.GetMaxmp();
				int				skill_level = skill.GetLevel();
				int				skill_t1 = skill.GetT1();

				skill.SetPlus(2000.0f);
				skill.SetPlus2((skill_level * (player_maxmp * 0.025f)));
				skill.SetCrit((skill_level * 0.005f * 4.0f));
				skill.SetCrithurt((skill_t1 * 0.2f));
				player.SetPerform(1);
			}
		}
		public GSkill4667Stub()
			: base(4667)
		{
			occupation = 168;
			maxlevel = 20;
			maxlearn = 0;
			eventflag = 0;
			spcost = 0;
			reborncount = 0;
			type = 1;
			timetype = 0;
			targettype = 0;
			rangetype = 11;
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
			weapon_limit = 9;
			SetAction(0,"轩辕_日炎术_02");
			SetAction(1,"0");
			SetAction(2,"0");
			SetAction(3,"0");
			SetAction(4,"0");
			SetAction(5,"0");
			SetAction(6,"0");
			SetAction(7,"0");
			SetAction(8,"0");
			SetAction(9,"轩辕_日炎术_02");
			SetAction(10,"0");
			SetAction(11,"0");
			SetAction(12,"0");
			SetAction(13,"");
			SetAction(14,"");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"轩辕_骑乘_日炎术_02");
			SetAction(19,"0");
			SetAction(20,"0");
			SetAction(21,"0");
			SetAction(22,"0");
			SetAction(23,"0");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"轩辕_骑乘_日炎术_02");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "界·天演式·六道<煞>";
			nativename = "界·天演式·六道<煞>";
			icon = "六道(煞).dds";
			SetTalent(0,4142);
			SetTalent(1,4148);
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
			skill_class = 11;
			guide = false;
			summon_id = 0;
			trigger = true;
			conbutton_sub = false;
			isBabySkill = false;
			castInPreSkill = false;
			preCastSkillId = 0;
			darkLightType = 0;
			followskill = 4668;
			targetcnt = 6;
			excludemonstercnt = 0;

			AddState(new GState1());
			AddState(new GState2());
		}
		public override int GetExecutetime(GSkill skill)
		{
			return 400;
		}
		public override float GetAttackdistance(GSkill skill)
		{
			return 20.000000f;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 17.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 15.000000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 20.000000f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_t0 = skill.GetT0();

			/*
			if ( skill_t0 <= 0 )
			d = 0.0f;
			else
			victim.SetProbability(120.0f);
			victim.SetTime(2000.0f);
			victim.SetRatio((skill_t0 * 0.04f));
			victim.SetBuffid(1);
			victim.SetIncfatalratio(true);
			*/
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();

			victim.SetProbability(120.0f);
			victim.SetTime(2000.0f);
			victim.SetAmount(skill_level);
			victim.SetValue(4668.0f);
			victim.SetTriggerskill(true);
			victim.SetProbability(120.0f);
			victim.SetTime(1000.0f);
			victim.SetPowerless(true);
			return true;
		}
	}
	public class GSkill4667 : GSkill
	{
		public GSkill4667()
			: base(4667)
		{
			
		}
	}
	public class GSkill4668Stub : GSkillStub
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
				return 200;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_maxmp = player.GetMaxmp();
				int				skill_level = skill.GetLevel();
				int				skill_t1 = skill.GetT1();

				skill.SetPlus(2000.0f);
				skill.SetPlus2((skill_level * (player_maxmp * 0.03f)));
				skill.SetCrit((skill_level * 0.005f * 5.0f));
				skill.SetCrithurt((skill_t1 * 0.25f));
				player.SetPerform(1);
			}
		}
		public GSkill4668Stub()
			: base(4668)
		{
			occupation = 168;
			maxlevel = 20;
			maxlearn = 0;
			eventflag = 0;
			spcost = 0;
			reborncount = 0;
			type = 1;
			timetype = 0;
			targettype = 0;
			rangetype = 11;
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
			weapon_limit = 9;
			SetAction(0,"轩辕_日炎术_02");
			SetAction(1,"0");
			SetAction(2,"0");
			SetAction(3,"0");
			SetAction(4,"0");
			SetAction(5,"0");
			SetAction(6,"0");
			SetAction(7,"0");
			SetAction(8,"0");
			SetAction(9,"轩辕_日炎术_02");
			SetAction(10,"0");
			SetAction(11,"0");
			SetAction(12,"0");
			SetAction(13,"");
			SetAction(14,"");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"轩辕_骑乘_日炎术_02");
			SetAction(19,"0");
			SetAction(20,"0");
			SetAction(21,"0");
			SetAction(22,"0");
			SetAction(23,"0");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"轩辕_骑乘_日炎术_02");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "界·天演式·六道<煞>";
			nativename = "界·天演式·六道<煞>";
			icon = "六道(煞).dds";
			SetTalent(0,4142);
			SetTalent(1,4148);
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
			skill_class = 11;
			guide = false;
			summon_id = 0;
			trigger = true;
			conbutton_sub = false;
			isBabySkill = false;
			castInPreSkill = false;
			preCastSkillId = 0;
			darkLightType = 0;
			followskill = 4669;
			targetcnt = 6;
			excludemonstercnt = 0;

			AddState(new GState1());
			AddState(new GState2());
		}
		public override int GetExecutetime(GSkill skill)
		{
			return 400;
		}
		public override float GetAttackdistance(GSkill skill)
		{
			return 20.000000f;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 17.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 15.000000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 20.000000f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_t0 = skill.GetT0();

			/*
			if ( skill_t0 <= 0 )
			d = 0.0f;
			else
			victim.SetProbability(120.0f);
			victim.SetTime(2000.0f);
			victim.SetRatio((skill_t0 * 0.05f));
			victim.SetBuffid(1);
			victim.SetIncfatalratio(true);
			*/
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();

			victim.SetProbability(120.0f);
			victim.SetTime(2000.0f);
			victim.SetAmount(skill_level);
			victim.SetValue(4669.0f);
			victim.SetTriggerskill(true);
			victim.SetProbability(120.0f);
			victim.SetTime(1000.0f);
			victim.SetPowerless(true);
			return true;
		}
	}
	public class GSkill4668 : GSkill
	{
		public GSkill4668()
			: base(4668)
		{
			
		}
	}
	public class GSkill4669Stub : GSkillStub
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
				return 200;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_maxmp = player.GetMaxmp();
				int				skill_level = skill.GetLevel();
				int				skill_t1 = skill.GetT1();

				skill.SetPlus(2000.0f);
				skill.SetPlus2((skill_level * (player_maxmp * 0.035f)));
				skill.SetCrit((skill_level * 0.005f * 6.0f));
				skill.SetCrithurt((skill_t1 * 0.3f));
				player.SetPerform(1);
			}
		}
		public GSkill4669Stub()
			: base(4669)
		{
			occupation = 168;
			maxlevel = 20;
			maxlearn = 0;
			eventflag = 0;
			spcost = 0;
			reborncount = 0;
			type = 1;
			timetype = 0;
			targettype = 0;
			rangetype = 11;
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
			weapon_limit = 9;
			SetAction(0,"轩辕_日炎术_02");
			SetAction(1,"0");
			SetAction(2,"0");
			SetAction(3,"0");
			SetAction(4,"0");
			SetAction(5,"0");
			SetAction(6,"0");
			SetAction(7,"0");
			SetAction(8,"0");
			SetAction(9,"轩辕_日炎术_02");
			SetAction(10,"0");
			SetAction(11,"0");
			SetAction(12,"0");
			SetAction(13,"");
			SetAction(14,"");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"轩辕_骑乘_日炎术_02");
			SetAction(19,"0");
			SetAction(20,"0");
			SetAction(21,"0");
			SetAction(22,"0");
			SetAction(23,"0");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"轩辕_骑乘_日炎术_02");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "界·天演式·六道<煞>";
			nativename = "界·天演式·六道<煞>";
			icon = "六道(煞).dds";
			SetTalent(0,4142);
			SetTalent(1,4148);
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
			skill_class = 11;
			guide = false;
			summon_id = 0;
			trigger = true;
			conbutton_sub = false;
			isBabySkill = false;
			castInPreSkill = false;
			preCastSkillId = 0;
			darkLightType = 0;
			followskill = 0;
			targetcnt = 6;
			excludemonstercnt = 0;

			AddState(new GState1());
			AddState(new GState2());
		}
		public override int GetExecutetime(GSkill skill)
		{
			return 400;
		}
		public override float GetAttackdistance(GSkill skill)
		{
			return 20.000000f;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 17.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 15.000000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 20.000000f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_t0 = skill.GetT0();

			/*
			if ( skill_t0 <= 0 )
			d = 0.0f;
			else
			victim.SetProbability(120.0f);
			victim.SetTime(2000.0f);
			victim.SetRatio((skill_t0 * 0.06f));
			victim.SetBuffid(1);
			victim.SetIncfatalratio(true);
			*/
			return true;
		}
	}
	public class GSkill4669 : GSkill
	{
		public GSkill4669()
			: base(4669)
		{
			
		}
	}
}
