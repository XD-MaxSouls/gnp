using System;
using System.Text;

namespace SKILL
{
	public class GSkill4670Stub : GSkillStub
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
				int				player_res5 = player.GetRes5();
				int				skill_level = skill.GetLevel();
				int				skill_t1 = skill.GetT1();

				player.SetVar1(player_res5);
				skill.SetPlus(2000.0f);
				skill.SetPlus2((skill_level * (player_maxmp * 0.015f)));
				skill.SetCrithurt((skill_t1 * 0.1f));
				player.SetPerform(1);
			}
		}
		public GSkill4670Stub()
			: base(4670)
		{
			occupation = 169;
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
			name = "界·天演式·六道<禅>";
			nativename = "界·天演式·六道<禅>";
			icon = "六道(禅).dds";
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
			followskill = 4671;
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
			victim.SetProbability(((5 * skill_level + player_var1 + 10)));
			victim.SetTime(3000.0f);
			victim.SetValue(0.0f);
			victim.SetSleep(true);
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
			victim.SetValue(4671.0f);
			victim.SetTriggerskill(true);
			victim.SetProbability(120.0f);
			victim.SetTime(1000.0f);
			victim.SetPowerless(true);
			return true;
		}
	}
	public class GSkill4670 : GSkill
	{
		public GSkill4670()
			: base(4670)
		{
			
		}
	}
	public class GSkill4671Stub : GSkillStub
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
				int				player_res5 = player.GetRes5();
				int				skill_level = skill.GetLevel();
				int				skill_t1 = skill.GetT1();

				player.SetVar1(player_res5);
				skill.SetPlus(2000.0f);
				skill.SetPlus2((skill_level * (player_maxmp * 0.02f)));
				skill.SetCrithurt((skill_t1 * 0.15f));
				player.SetPerform(1);
			}
		}
		public GSkill4671Stub()
			: base(4671)
		{
			occupation = 169;
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
			name = "界·天演式·六道<禅>";
			nativename = "界·天演式·六道<禅>";
			icon = "六道(禅).dds";
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
			followskill = 4672;
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
			victim.SetProbability(((5 * skill_level + player_var1 + 20)));
			victim.SetTime(3000.0f);
			victim.SetValue(0.0f);
			victim.SetSleep(true);
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
			victim.SetValue(4672.0f);
			victim.SetTriggerskill(true);
			victim.SetProbability(120.0f);
			victim.SetTime(1000.0f);
			victim.SetPowerless(true);
			return true;
		}
	}
	public class GSkill4671 : GSkill
	{
		public GSkill4671()
			: base(4671)
		{
			
		}
	}
	public class GSkill4672Stub : GSkillStub
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
				int				player_res5 = player.GetRes5();
				int				skill_level = skill.GetLevel();
				int				skill_t1 = skill.GetT1();

				player.SetVar1(player_res5);
				skill.SetPlus(2000.0f);
				skill.SetPlus2((skill_level * (player_maxmp * 0.025f)));
				skill.SetCrithurt((skill_t1 * 0.2f));
				player.SetPerform(1);
			}
		}
		public GSkill4672Stub()
			: base(4672)
		{
			occupation = 169;
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
			name = "界·天演式·六道<禅>";
			nativename = "界·天演式·六道<禅>";
			icon = "六道(禅).dds";
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
			followskill = 4673;
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
			victim.SetProbability(((5 * skill_level + player_var1 + 30)));
			victim.SetTime(3000.0f);
			victim.SetValue(0.0f);
			victim.SetSleep(true);
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
			victim.SetValue(4673.0f);
			victim.SetTriggerskill(true);
			victim.SetProbability(120.0f);
			victim.SetTime(1000.0f);
			victim.SetPowerless(true);
			return true;
		}
	}
	public class GSkill4672 : GSkill
	{
		public GSkill4672()
			: base(4672)
		{
			
		}
	}
	public class GSkill4673Stub : GSkillStub
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
				int				player_res5 = player.GetRes5();
				int				skill_level = skill.GetLevel();
				int				skill_t1 = skill.GetT1();

				player.SetVar1(player_res5);
				skill.SetPlus(2000.0f);
				skill.SetPlus2((skill_level * (player_maxmp * 0.03f)));
				skill.SetCrithurt((skill_t1 * 0.25f));
				player.SetPerform(1);
			}
		}
		public GSkill4673Stub()
			: base(4673)
		{
			occupation = 169;
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
			name = "界·天演式·六道<禅>";
			nativename = "界·天演式·六道<禅>";
			icon = "六道(禅).dds";
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
			followskill = 4674;
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
			victim.SetProbability(((5 * skill_level + player_var1 + 40)));
			victim.SetTime(3000.0f);
			victim.SetValue(0.0f);
			victim.SetSleep(true);
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
			victim.SetValue(4674.0f);
			victim.SetTriggerskill(true);
			victim.SetProbability(120.0f);
			victim.SetTime(1000.0f);
			victim.SetPowerless(true);
			return true;
		}
	}
	public class GSkill4673 : GSkill
	{
		public GSkill4673()
			: base(4673)
		{
			
		}
	}
	public class GSkill4674Stub : GSkillStub
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
				int				player_res5 = player.GetRes5();
				int				skill_level = skill.GetLevel();
				int				skill_t1 = skill.GetT1();

				player.SetVar1(player_res5);
				skill.SetPlus(2000.0f);
				skill.SetPlus2((skill_level * (player_maxmp * 0.035f)));
				skill.SetCrithurt((skill_t1 * 0.3f));
				player.SetPerform(1);
			}
		}
		public GSkill4674Stub()
			: base(4674)
		{
			occupation = 169;
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
			name = "界·天演式·六道<禅>";
			nativename = "界·天演式·六道<禅>";
			icon = "六道(禅).dds";
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
			victim.SetProbability(((5 * skill_level + player_var1 + 50)));
			victim.SetTime(3000.0f);
			victim.SetValue(0.0f);
			victim.SetSleep(true);
			*/
			return true;
		}
	}
	public class GSkill4674 : GSkill
	{
		public GSkill4674()
			: base(4674)
		{
			
		}
	}
	public class GSkill4675Stub : GSkillStub
	{
		public class GState1 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 0;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_level = player.GetLevel();
				int				skill_t2 = skill.GetT2();

				/*
				player.SetVar1(player_level);
				v12 = (8 * player_level);
				if ( player.GetDarklightform() != 3
				    && (v7 = player, GNET::PlayerWrapper::GetDarklightform(v7) != 5)
				    && (v8 = player, GNET::PlayerWrapper::GetDarklightform(v8) != 6) )
				    v11 = v12;
				  else
				skill.SetPlus(((skill_t2 * 0.1f + 1.0f) * v12));
				player.SetPerform(1);
				*/
			}
		}
		public GSkill4675Stub()
			: base(4675)
		{
			occupation = 58;
			maxlevel = 10;
			maxlearn = 9;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 1;
			timetype = 1;
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
			name = "定风波被动";
			nativename = "定风波被动";
			icon = "";
			SetTalent(0,4115);
			SetTalent(1,4116);
			SetTalent(2,4117);
			SetTalent(3,4123);
			SetTalent(4,4151);
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
			return 15.000000f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_var1 = player.GetVar1();
			int				skill_level = skill.GetLevel();
			int				skill_t3 = skill.GetT3();

			/*
			victim.SetProbability(((10 * skill_level + (3 * player_var1))));
			victim.SetTime(3000.0f);
			victim.SetWrap(true);
			if ( zrand(100) >= 10 * skill_t3 )
			{
			v15 = 0.0f;
			}
			else
			{
			v15 = (10 * skill_level + (3 * player_var1));
			}
			victim.SetProbability(v15);
			victim.SetTime(3000.0f);
			victim.SetDizzy(true);
			*/
			return true;
		}
	}
	public class GSkill4675 : GSkill
	{
		public GSkill4675()
			: base(4675)
		{
			
		}
	}
	public class GSkill4676Stub : GSkillStub
	{
		public class GState1 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 0;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_level = player.GetLevel();
				int				player_maxmp = player.GetMaxmp();
				int				skill_level = skill.GetLevel();
				int				skill_t2 = skill.GetT2();

				/*
				v12 = (skill_level * player_maxmp / 100 + (8 * player_level));
				if ( player.GetDarklightform() != 4
				    && (v7 = player, GNET::PlayerWrapper::GetDarklightform(v7) != 5)
				    && (v8 = player, GNET::PlayerWrapper::GetDarklightform(v8) != 6) )
				    v11 = v12;
				  else
				skill.SetPlus(((skill_t2 * 0.1f + 1.0f) * v12));
				player.SetPerform(1);
				*/
			}
		}
		public GSkill4676Stub()
			: base(4676)
		{
			occupation = 58;
			maxlevel = 10;
			maxlearn = 9;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 1;
			timetype = 1;
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
			name = "三千界被动";
			nativename = "三千界被动";
			icon = "";
			SetTalent(0,4132);
			SetTalent(1,4133);
			SetTalent(2,4134);
			SetTalent(3,4140);
			SetTalent(4,4151);
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
			return 15.000000f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_t3 = skill.GetT3();

			/*
			if ( skill_t3 <= 0 )
			d = 0.0f;
			else
			victim.SetProbability(120.0f);
			victim.SetTime(((5000 * skill_t3)));
			victim.SetBuffid(1);
			victim.SetValue(20.0f);
			victim.SetSubhide(true);
			*/
			return true;
		}
	}
	public class GSkill4676 : GSkill
	{
		public GSkill4676()
			: base(4676)
		{
			
		}
	}
	public class GSkill4677Stub : GSkillStub
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
			public override bool Cancel(GSkill skill)
			{
				return true;
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
		public GSkill4677Stub()
			: base(4677)
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
			SetAction(0,"鬼王宗_虚空斩");
			SetAction(1,"鬼王宗_虚空斩");
			SetAction(2,"鬼王宗_虚空斩");
			SetAction(3,"鬼王宗_虚空斩");
			SetAction(4,"鬼王宗_虚空斩");
			SetAction(5,"鬼王宗_虚空斩");
			SetAction(6,"鬼王宗_虚空斩");
			SetAction(7,"兽神_横行");
			SetAction(8,"狐妖_固元术");
			SetAction(9,"轩辕_飞弹");
			SetAction(10,"怀光_偷袭");
			SetAction(11,"太昊_加速");
			SetAction(12,"天华_初元音刃");
			SetAction(13,"");
			SetAction(14,"");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"鬼王宗_骑乘_虚空斩");
			SetAction(19,"鬼王宗_骑乘_虚空斩");
			SetAction(20,"鬼王宗_骑乘_虚空斩");
			SetAction(21,"鬼王宗_骑乘_虚空斩");
			SetAction(22,"鬼王宗_骑乘_虚空斩");
			SetAction(23,"鬼王宗_骑乘_虚空斩");
			SetAction(24,"鬼王宗_骑乘_虚空斩");
			SetAction(25,"兽神_骑乘_横行");
			SetAction(26,"狐妖_骑乘_固元术");
			SetAction(27,"轩辕_骑乘_飞弹");
			SetAction(28,"怀光_骑乘_偷袭");
			SetAction(29,"太昊_骑乘_加速");
			SetAction(30,"天华_骑乘_初元音刃");
			name = "神农网";
			nativename = "神农网";
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
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_maxhp = player.GetMaxhp();

			/*
			if ( (player.GetTmplid() <= 54931
			|| (v3 = player, GNET::PlayerWrapper::GetTmplid(v3) > 54940))
			&& ((v4 = player, GNET::PlayerWrapper::GetTmplid(v4) <= 54940)
			|| (v5 = player, GNET::PlayerWrapper::GetTmplid(v5) > 54949)) )
			d = 0.0f;
			else
			victim.SetProbability(100.0f);
			victim.SetValue((player_maxhp * 0.35f));
			victim.SetDirecthurt(true);
			*/
			return true;
		}
	}
	public class GSkill4677 : GSkill
	{
		public GSkill4677()
			: base(4677)
		{
			
		}
	}
	public class GSkill4678Stub : GSkillStub
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
		public GSkill4678Stub()
			: base(4678)
		{
			occupation = 128;
			maxlevel = 9;
			maxlearn = 9;
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
			name = "上古副本1关技能1";
			nativename = "上古副本1关技能1";
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
			return 7.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 6.000000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 9.000000f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_hp = player.GetHp();
			int				player_res1 = player.GetRes1();
			int				player_res2 = player.GetRes2();
			int				skill_level = skill.GetLevel();

			/*
			if ( skill_level <= 0 )
			{
			d = 0.0f;
			}
			else
			{
			d = (player_res2 + 99);
			}
			victim.SetProbability(d);
			victim.SetTime(30000.0f);
			victim.SetRatio(0.69999999f);
			victim.SetBuffid(3);
			victim.SetWeak(true);
			if ( skill_level <= 1 )
			v26 = 0.0f;
			else
			victim.SetProbability(99.0f);
			victim.SetTime(15000.0f);
			victim.SetDarkness(true);
			if ( skill_level <= 2 )
			{
			v25 = 0.0f;
			}
			else
			{
			v25 = (player_res1 + 99);
			}
			victim.SetProbability(v25);
			victim.SetTime(15000.0f);
			victim.SetDizzy(true);
			if ( skill_level <= 3 )
			v24 = 0.0f;
			else
			victim.SetProbability(99.0f);
			victim.SetTime(500.0f);
			victim.SetBuffid(2);
			victim.SetAmount((player_hp * 0.5f));
			victim.SetValue(1.0f);
			victim.SetHpleak(true);
			*/
			return true;
		}
	}
	public class GSkill4678 : GSkill
	{
		public GSkill4678()
			: base(4678)
		{
			
		}
	}
	public class GSkill4679Stub : GSkillStub
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
		public GSkill4679Stub()
			: base(4679)
		{
			occupation = 128;
			maxlevel = 9;
			maxlearn = 9;
			eventflag = 0;
			spcost = 1;
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
			name = "上古副本1关技能2";
			nativename = "上古副本1关技能2";
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
			return 25.000000f;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 12.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 8.000000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 26.000000f;
		}
		public override int GetCoverage(GSkill skill)
		{
			return 40;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_maxhp = player.GetMaxhp();
			int				skill_level = skill.GetLevel();

			victim.SetProbability(100.0f);
			victim.SetTime(((4000 * skill_level)));
			victim.SetBuffid(3);
			victim.SetAmount((skill_level * (player_maxhp * 0.2f)));
			victim.SetValue(1.0f);
			victim.SetHpleak(true);
			return true;
		}
	}
	public class GSkill4679 : GSkill
	{
		public GSkill4679()
			: base(4679)
		{
			
		}
	}
}
