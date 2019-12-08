using System;
using System.Text;

namespace SKILL
{
	public class GSkill3290Stub : GSkillStub
	{
		public GSkill3290Stub()
			: base(3290)
		{
			occupation = 129;
			maxlevel = 99;
			maxlearn = 10;
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
			name = "清除加速变身等";
			nativename = "清除加速变身等";
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

			victim.SetProbability(100.0f);
			victim.SetRatio(4269.0f);
			victim.SetAmount(4155.0f);
			victim.SetValue(4154.0f);
			victim.SetDispel(true);
			victim.SetProbability(100.0f);
			victim.SetRatio(4142.0f);
			victim.SetAmount(4171.0f);
			victim.SetValue(4176.0f);
			victim.SetDispel(true);
			victim.SetProbability(120.0f);
			victim.SetRatio(0.0f);
			victim.SetAmount(0.0f);
			victim.SetValue(0.0f);
			victim.SetCleartransform(true);
			victim.SetProbability(100.0f);
			victim.SetRatio(4268.0f);
			victim.SetAmount(4178.0f);
			victim.SetValue(4221.0f);
			victim.SetDispel(true);
			return true;
		}
	}
	public class GSkill3290 : GSkill
	{
		public GSkill3290()
			: base(3290)
		{
			
		}
	}
	public class GSkill3291Stub : GSkillStub
	{
		public class GState1 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 50;
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
				return 50;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();

				player.SetPerform(1);
			}
		}
		public GSkill3291Stub()
			: base(3291)
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
			rangetype = 2;
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
			name = "家族副本传送门";
			nativename = "家族副本传送门";
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
			return 100;
		}
		public override float GetRadius(GSkill skill)
		{
			return 3.500000f;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 4.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 3.000000f;
		}
		public override int GetCoverage(GSkill skill)
		{
			return 15;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();

			/*
			victim.SetProbability(120.0f);
			victim.SetTime(116000.0f);
			if ( skill_level == 1 )
			v28 = 34;
			else
			v28 = 0;
			if ( skill_level == 2 )
			v29 = v28 + 34;
			else
			v29 = v28;
			if ( skill_level == 3 )
			v30 = v29 + 34;
			else
			v30 = v29;
			if ( skill_level == 4 )
			v31 = v30 + 34;
			else
			v31 = v30;
			if ( skill_level == 5 )
			v32 = v31 + 34;
			else
			v32 = v31;
			if ( skill_level == 6 )
			v33 = v32 + 34;
			else
			v33 = v32;
			if ( skill_level == 7 )
			v34 = v33 + 37;
			else
			v34 = v33;
			if ( skill_level == 8 )
			v35 = v34 + 37;
			else
			v35 = v34;
			if ( skill_level == 9 )
			d = v35 + 37;
			else
			victim.SetBuffid(v35);
			if ( skill_level == 1 )
			v19 = 175;
			else
			v19 = 0;
			if ( skill_level == 2 )
			v20 = v19 + 231;
			else
			v20 = v19;
			if ( skill_level == 3 )
			v21 = v20 + 154;
			else
			v21 = v20;
			if ( skill_level == 4 )
			v22 = v21 + 202;
			else
			v22 = v21;
			if ( skill_level == 5 )
			v23 = v22 + 249;
			else
			v23 = v22;
			if ( skill_level == 6 )
			v24 = v23 + 286;
			else
			v24 = v23;
			if ( skill_level == 7 )
			v25 = v24 + 348;
			else
			v25 = v24;
			if ( skill_level == 8 )
			v26 = v25 + 344;
			else
			v26 = v25;
			if ( skill_level == 9 )
			v18 = (v26 + 290);
			else
			victim.SetAmount(v26);
			if ( skill_level == 1 )
			v10 = 58;
			else
			v10 = 0;
			if ( skill_level == 2 )
			v11 = v10 + 58;
			else
			v11 = v10;
			if ( skill_level == 3 )
			v12 = v11 + 3;
			else
			v12 = v11;
			if ( skill_level == 4 )
			v13 = v12 + 3;
			else
			v13 = v12;
			if ( skill_level == 5 )
			v14 = v13 + 4;
			else
			v14 = v13;
			if ( skill_level == 6 )
			v15 = v14 + 3;
			else
			v15 = v14;
			if ( skill_level == 7 )
			v16 = v15 + 49;
			else
			v16 = v15;
			if ( skill_level == 8 )
			v17 = v16 - 11;
			else
			v17 = v16;
			if ( skill_level == 9 )
			v9 = (v17 + 67);
			else
			victim.SetValue(v17);
			victim.SetMagicdoor(true);
			*/
			return true;
		}
	}
	public class GSkill3291 : GSkill
	{
		public GSkill3291()
			: base(3291)
		{
			
		}
	}
	public class GSkill3292Stub : GSkillStub
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

				skill.SetRatio(1.25f);
				skill.SetPlus((((zrand(55) - 10) * norm(3.1f) + 100) / 100.0f * 914.8000000000001f));
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

				skill.SetRatio(1.25f);
				skill.SetPlus((((zrand(55) - 10) * norm(3.1f) + 100) / 100.0f * 914.8000000000001f));
				player.SetPerform(0);
			}
		}
		public GSkill3292Stub()
			: base(3292)
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
			SetAction(0,"青云门_雷光遁龙决");
			SetAction(1,"青云门_雷光遁龙决");
			SetAction(2,"青云门_雷光遁龙决");
			SetAction(3,"青云门_雷光遁龙决");
			SetAction(4,"青云门_雷光遁龙决");
			SetAction(5,"青云门_雷光遁龙决");
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
			SetAction(18,"青云门_骑乘_雷光遁龙决");
			SetAction(19,"青云门_骑乘_雷光遁龙决");
			SetAction(20,"青云门_骑乘_雷光遁龙决");
			SetAction(21,"青云门_骑乘_雷光遁龙决");
			SetAction(22,"青云门_骑乘_雷光遁龙决");
			SetAction(23,"青云门_骑乘_雷光遁龙决");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "雷光遁龙诀";
			nativename = "雷光遁龙诀";
			icon = "雷光遁龙诀.dds";
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
			AddState(new GState3());
		}
		public override int GetExecutetime(GSkill skill)
		{
			return 2000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			return 3000;
		}
		public override int GetEnmity(GSkill skill)
		{
			return 1;
		}
		public override float GetRadius(GSkill skill)
		{
			return 21.000000f;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 21.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 16.000000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 24.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			return 1000.000000f;
		}
		public override int GetCoverage(GSkill skill)
		{
			return 15;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetProbability(65.0f);
			victim.SetTime(32100.0f);
			victim.SetBuffid(1);
			victim.SetValue(600.0f);
			victim.SetSubattack(true);
			victim.SetProbability(15.0f);
			victim.SetTime(9150.0f);
			victim.SetRatio(0.15000001f);
			victim.SetBuffid(1);
			victim.SetDecdefence(true);
			return true;
		}
		public override float GetDropRate(GSkill skill)
		{
			return 0.500000f;
		}
	}
	public class GSkill3292 : GSkill
	{
		public GSkill3292()
			: base(3292)
		{
			
		}
	}
	public class GSkill3293Stub : GSkillStub
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
		public GSkill3293Stub()
			: base(3293)
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
			SetAction(0,"青云门_天尊法身");
			SetAction(1,"青云门_天尊法身");
			SetAction(2,"青云门_天尊法身");
			SetAction(3,"青云门_天尊法身");
			SetAction(4,"青云门_天尊法身");
			SetAction(5,"青云门_天尊法身");
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
			SetAction(18,"青云门_骑乘_天尊法身");
			SetAction(19,"青云门_骑乘_天尊法身");
			SetAction(20,"青云门_骑乘_天尊法身");
			SetAction(21,"青云门_骑乘_天尊法身");
			SetAction(22,"青云门_骑乘_天尊法身");
			SetAction(23,"青云门_骑乘_天尊法身");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "天尊法身";
			nativename = "天尊法身";
			icon = "天尊法身.dds";
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
			return 90000;
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
		public override float GetMpcost(GSkill skill)
		{
			return 500.000000f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_maxhp = player.GetMaxhp();

			victim.SetProbability(100.0f);
			victim.SetTime(20100.0f);
			victim.SetRatio(((D2INT(zrand(114) / 100) + 1) * 0.091f));
			victim.SetBuffid(1);
			victim.SetValue(((11875 - 1500 * D2INT(0.7692307692307693f)) * 1.9f));
			victim.SetFashen(true);
			victim.SetProbability(100.0f);
			victim.SetTime(((4000 * norm(3))));
			victim.SetRatio(0.0f);
			victim.SetBuffid(1);
			victim.SetAmount(0.0f);
			victim.SetValue((player_maxhp * 0.06f));
			victim.SetHpgen(true);
			return true;
		}
	}
	public class GSkill3293 : GSkill
	{
		public GSkill3293()
			: base(3293)
		{
			
		}
	}
	public class GSkill3294Stub : GSkillStub
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
				int				player_mp = player.GetMp();
				int				player_maxmp = player.GetMaxmp();

				skill.SetRatio((D2INT((player_mp / 0.6499999999999999f) / player_maxmp) * 0.08f + 1.27f));
				skill.SetPlus((((zrand(55) - 10) * norm(3.1f) + 100) / 100.0f * 966.0f));
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
				return 500;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_mp = player.GetMp();
				int				player_maxmp = player.GetMaxmp();

				skill.SetRatio((D2INT((player_mp / 0.6499999999999999f) / player_maxmp) * 0.08f + 1.27f));
				skill.SetPlus((((zrand(55) - 10) * norm(3.1f) + 100) / 100.0f * 966.0f));
				player.SetPerform(0);
			}
			public override bool Cancel(GSkill skill)
			{
				return true;
			}
		}
		public class GState4 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 500;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_mp = player.GetMp();
				int				player_maxmp = player.GetMaxmp();

				skill.SetRatio((D2INT((player_mp / 0.6499999999999999f) / player_maxmp) * 0.08f + 1.27f));
				skill.SetPlus((((zrand(55) - 10) * norm(3.1f) + 100) / 100.0f * 966.0f));
				player.SetPerform(0);
			}
		}
		public GSkill3294Stub()
			: base(3294)
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
			SetAction(0,"青云门_太极玄天真诀");
			SetAction(1,"青云门_太极玄天真诀");
			SetAction(2,"青云门_太极玄天真诀");
			SetAction(3,"青云门_太极玄天真诀");
			SetAction(4,"青云门_太极玄天真诀");
			SetAction(5,"青云门_太极玄天真诀");
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
			SetAction(18,"青云门_骑乘_太极玄天真诀");
			SetAction(19,"青云门_骑乘_太极玄天真诀");
			SetAction(20,"青云门_骑乘_太极玄天真诀");
			SetAction(21,"青云门_骑乘_太极玄天真诀");
			SetAction(22,"青云门_骑乘_太极玄天真诀");
			SetAction(23,"青云门_骑乘_太极玄天真诀");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "太极玄天真诀";
			nativename = "太极玄天真诀";
			icon = "太极玄天真诀.dds";
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
			AddState(new GState3());
			AddState(new GState4());
		}
		public override int GetExecutetime(GSkill skill)
		{
			return 2000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			return 4000;
		}
		public override int GetEnmity(GSkill skill)
		{
			return 1;
		}
		public override float GetRadius(GSkill skill)
		{
			return 23.000000f;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 22.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 15.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			return 1000.000000f;
		}
		public override int GetCoverage(GSkill skill)
		{
			return 15;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetProbability(29.0f);
			victim.SetTime(3100.0f);
			victim.SetRatio(0.2f);
			victim.SetValue(0.2f);
			victim.SetRandcurse(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_mp = player.GetMp();
			int				player_maxmp = player.GetMaxmp();

			victim.SetBuffid((D2INT((player_mp / 0.6499999999999999f) / player_maxmp)));
			victim.SetUniqprompt(true);
			return true;
		}
		public override float GetDropRate(GSkill skill)
		{
			return 0.500000f;
		}
	}
	public class GSkill3294 : GSkill
	{
		public GSkill3294()
			: base(3294)
		{
			
		}
	}
	public class GSkill3295Stub : GSkillStub
	{
		public class GState1 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 600;
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
				return 900;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();

				player.SetVar1(1);
				skill.SetRatio(1.33f);
				skill.SetPlus((((zrand(55) - 10) * norm(3.1f) + 100) / 100.0f * 1085.0f));
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
				return 900;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();

				player.SetVar1(2);
				skill.SetRatio(1.33f);
				skill.SetPlus((((zrand(55) - 10) * norm(3.1f) + 100) / 100.0f * 1085.0f));
				player.SetPerform(0);
			}
			public override bool Cancel(GSkill skill)
			{
				return true;
			}
		}
		public class GState4 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 900;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();

				player.SetVar1(2);
				skill.SetRatio(1.33f);
				skill.SetPlus((((zrand(55) - 10) * norm(3.1f) + 100) / 100.0f * 1085.0f));
				player.SetPerform(0);
			}
			public override bool Cancel(GSkill skill)
			{
				return true;
			}
		}
		public class GState5 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 900;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();

				player.SetVar1(2);
				skill.SetRatio(1.33f);
				skill.SetPlus((((zrand(55) - 10) * norm(3.1f) + 100) / 100.0f * 1085.0f));
				player.SetPerform(0);
			}
			public override bool Cancel(GSkill skill)
			{
				return true;
			}
		}
		public class GState6 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 900;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();

				player.SetVar1(2);
				skill.SetRatio(1.33f);
				skill.SetPlus((((zrand(55) - 10) * norm(3.1f) + 100) / 100.0f * 1085.0f));
				player.SetPerform(0);
			}
			public override bool Cancel(GSkill skill)
			{
				return true;
			}
		}
		public class GState7 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 900;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();

				player.SetVar1(3);
				skill.SetRatio(1.33f);
				skill.SetPlus((((zrand(55) - 10) * norm(3.1f) + 100) / 100.0f * ((1085 * D2INT(zrand(114) / 100) + 1085))));
				player.SetPerform(0);
			}
		}
		public GSkill3295Stub()
			: base(3295)
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
			SetAction(0,"青云门_神剑御雷真诀");
			SetAction(1,"青云门_神剑御雷真诀");
			SetAction(2,"青云门_神剑御雷真诀");
			SetAction(3,"青云门_神剑御雷真诀");
			SetAction(4,"青云门_神剑御雷真诀");
			SetAction(5,"青云门_神剑御雷真诀");
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
			SetAction(18,"青云门_骑乘_神剑御雷真诀");
			SetAction(19,"青云门_骑乘_神剑御雷真诀");
			SetAction(20,"青云门_骑乘_神剑御雷真诀");
			SetAction(21,"青云门_骑乘_神剑御雷真诀");
			SetAction(22,"青云门_骑乘_神剑御雷真诀");
			SetAction(23,"青云门_骑乘_神剑御雷真诀");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "神剑御雷真诀";
			nativename = "神剑御雷真诀";
			icon = "神剑御雷真诀.dds";
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
			AddState(new GState3());
			AddState(new GState4());
			AddState(new GState5());
			AddState(new GState6());
			AddState(new GState7());
		}
		public override int GetExecutetime(GSkill skill)
		{
			return 6000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			return 16000;
		}
		public override int GetEnmity(GSkill skill)
		{
			return 1;
		}
		public override float GetRadius(GSkill skill)
		{
			return 26.000000f;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 25.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 18.000000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 25.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			return 1000.000000f;
		}
		public override int GetCoverage(GSkill skill)
		{
			return 15;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetProbability(((600 * D2INT(zrand(100) / 85))));
			victim.SetTime(6100.0f);
			victim.SetSilent(true);
			victim.SetProbability(285.0f);
			victim.SetTime(7600.0f);
			victim.SetWrap(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_var1 = player.GetVar1();

			/*
			victim.SetRatio(((566 * D2INT(zrand(129) / 100) + 220)));
			victim.SetAmount(220.0f);
			victim.SetValue(220.0f);
			victim.SetClearcooldown(true);
			v17 = norm(true);
			v16 = norm(24.0f / (zrand(100) + 0.01f));
			if ( player_var1 == 1
			|| (v10 = player, GNET::PlayerWrapper::GetVar1(v10) == 3) )
			t = (3000 * v16 * v17);
			else
			victim.SetTime(0.0f);
			victim.SetValue(10.0f);
			victim.SetBlessed(true);
			*/
			return true;
		}
		public override float GetDropRate(GSkill skill)
		{
			return 0.500000f;
		}
	}
	public class GSkill3295 : GSkill
	{
		public GSkill3295()
			: base(3295)
		{
			
		}
	}
	public class GSkill3296Stub : GSkillStub
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
				return 400;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();

				skill.SetRatio(3.03f);
				skill.SetPlus(1406.988f);
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
				return 400;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();

				skill.SetRatio(3.0599999f);
				skill.SetPlus(1406.988f);
				player.SetPerform(0);
			}
			public override bool Cancel(GSkill skill)
			{
				return true;
			}
		}
		public class GState4 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 400;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();

				skill.SetRatio(3.0899999f);
				skill.SetPlus(1406.988f);
				player.SetPerform(0);
			}
			public override bool Cancel(GSkill skill)
			{
				return true;
			}
		}
		public class GState5 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 400;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();

				skill.SetRatio(3.1199999f);
				skill.SetPlus(1406.988f);
				player.SetPerform(0);
			}
		}
		public GSkill3296Stub()
			: base(3296)
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
			weapon_limit = -1;
			SetAction(0,"鬼王宗_魔魂天咒");
			SetAction(1,"鬼王宗_魔魂天咒");
			SetAction(2,"鬼王宗_魔魂天咒");
			SetAction(3,"鬼王宗_魔魂天咒");
			SetAction(4,"鬼王宗_魔魂天咒");
			SetAction(5,"鬼王宗_魔魂天咒");
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
			SetAction(18,"鬼王宗_骑乘_魔魂天咒");
			SetAction(19,"鬼王宗_骑乘_魔魂天咒");
			SetAction(20,"鬼王宗_骑乘_魔魂天咒");
			SetAction(21,"鬼王宗_骑乘_魔魂天咒");
			SetAction(22,"鬼王宗_骑乘_魔魂天咒");
			SetAction(23,"鬼王宗_骑乘_魔魂天咒");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "魔魂天咒";
			nativename = "魔魂天咒";
			icon = "魔魂天咒.dds";
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
			AddState(new GState3());
			AddState(new GState4());
			AddState(new GState5());
		}
		public override int GetExecutetime(GSkill skill)
		{
			return 2000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			return 900;
		}
		public override int GetEnmity(GSkill skill)
		{
			return 1;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 3.000000f;
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
			return 500.000000f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetProbability(48.0f);
			victim.SetTime(20100.0f);
			victim.SetRatio(((D2INT(zrand(100) / 82) + 1) * 0.2f));
			victim.SetBuffid(3);
			victim.SetTiansha(true);
			victim.SetProbability(-1.0f);
			victim.SetTime(2000.0f);
			victim.SetBuffid(1);
			victim.SetAmount(400.0f);
			victim.SetValue(0.0f);
			victim.SetHpleak(true);
			return true;
		}
	}
	public class GSkill3296 : GSkill
	{
		public GSkill3296()
			: base(3296)
		{
			
		}
	}
	public class GSkill3297Stub : GSkillStub
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
		public GSkill3297Stub()
			: base(3297)
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
			SetAction(0,"鬼王宗_狂灵反噬");
			SetAction(1,"鬼王宗_狂灵反噬");
			SetAction(2,"鬼王宗_狂灵反噬");
			SetAction(3,"鬼王宗_狂灵反噬");
			SetAction(4,"鬼王宗_狂灵反噬");
			SetAction(5,"鬼王宗_狂灵反噬");
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
			SetAction(18,"鬼王宗_骑乘_狂灵反噬");
			SetAction(19,"鬼王宗_骑乘_狂灵反噬");
			SetAction(20,"鬼王宗_骑乘_狂灵反噬");
			SetAction(21,"鬼王宗_骑乘_狂灵反噬");
			SetAction(22,"鬼王宗_骑乘_狂灵反噬");
			SetAction(23,"鬼王宗_骑乘_狂灵反噬");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "狂灵反噬";
			nativename = "狂灵反噬";
			icon = "狂灵反噬.dds";
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
			return 126000;
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
		public override float GetMpcost(GSkill skill)
		{
			return 500.000000f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_maxmp = player.GetMaxmp();

			victim.SetProbability(100.0f);
			victim.SetTime(26100.0f);
			victim.SetRatio(0.5f);
			victim.SetAmount(0.0f);
			victim.SetValue(100.0f);
			victim.SetRetort(true);
			victim.SetTime(19100.0f);
			victim.SetImmunesleep(true);
			victim.SetProbability(120.0f);
			victim.SetTime(180000.0f);
			victim.SetBuffid(1);
			victim.SetAmount(0.30001f);
			victim.SetValue((player_maxmp * 0.18f));
			victim.SetAddhp2(true);
			victim.SetTime(((19100 * norm(3))));
			victim.SetImmunedizzy(true);
			return true;
		}
	}
	public class GSkill3297 : GSkill
	{
		public GSkill3297()
			: base(3297)
		{
			
		}
	}
	public class GSkill3298Stub : GSkillStub
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
				return 1200;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				skill_level = skill.GetLevel();

				skill.SetCrit(0.059999999f);
				skill.SetRatio(1.21f);
				skill.SetCrithurt(1.5f);
				skill.SetPlus(((100 * skill_level) * 1.9f));
				player.SetPerform(1);
			}
		}
		public GSkill3298Stub()
			: base(3298)
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
			SetAction(0,"鬼王宗_毁天灭地");
			SetAction(1,"鬼王宗_毁天灭地");
			SetAction(2,"鬼王宗_毁天灭地");
			SetAction(3,"鬼王宗_毁天灭地");
			SetAction(4,"鬼王宗_毁天灭地");
			SetAction(5,"鬼王宗_毁天灭地");
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
			SetAction(18,"鬼王宗_骑乘_毁天灭地");
			SetAction(19,"鬼王宗_骑乘_毁天灭地");
			SetAction(20,"鬼王宗_骑乘_毁天灭地");
			SetAction(21,"鬼王宗_骑乘_毁天灭地");
			SetAction(22,"鬼王宗_骑乘_毁天灭地");
			SetAction(23,"鬼王宗_骑乘_毁天灭地");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "毁天灭地";
			nativename = "毁天灭地";
			icon = "毁天灭地.dds";
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
			return 4000;
		}
		public override int GetEnmity(GSkill skill)
		{
			return 1;
		}
		public override float GetRadius(GSkill skill)
		{
			return 11.000000f;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 11.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 5.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			return 500.000000f;
		}
		public override int GetCoverage(GSkill skill)
		{
			return 25;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetProbability(78.0f);
			victim.SetTime(20100.0f);
			victim.SetAssault(true);
			victim.SetProbability(-1.0f);
			victim.SetTime(2000.0f);
			victim.SetBuffid(1);
			victim.SetAmount(((D2INT(zrand(100) / 82) + 1) * 1632.0f));
			victim.SetValue(0.0f);
			victim.SetHpleak5(true);
			return true;
		}
		public override float GetDropRate(GSkill skill)
		{
			return 0.500000f;
		}
	}
	public class GSkill3298 : GSkill
	{
		public GSkill3298()
			: base(3298)
		{
			
		}
	}
	public class GSkill3299Stub : GSkillStub
	{
		public class GState1 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 300;
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
				return 450;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();

				skill.SetRatio(1.89f);
				skill.SetPlus(1056.33f);
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
				return 450;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();

				skill.SetRatio(1.74f);
				skill.SetPlus(1056.33f);
				player.SetPerform(0);
			}
			public override bool Cancel(GSkill skill)
			{
				return true;
			}
		}
		public class GState4 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 450;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();

				skill.SetRatio(1.74f);
				skill.SetPlus(1056.33f);
				player.SetPerform(0);
			}
			public override bool Cancel(GSkill skill)
			{
				return true;
			}
		}
		public class GState5 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 450;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();

				skill.SetRatio(1.74f);
				skill.SetPlus(1056.33f);
				player.SetPerform(0);
			}
			public override bool Cancel(GSkill skill)
			{
				return true;
			}
		}
		public class GState6 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 450;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();

				skill.SetRatio(1.74f);
				skill.SetPlus(1056.33f);
				player.SetPerform(0);
			}
			public override bool Cancel(GSkill skill)
			{
				return true;
			}
		}
		public class GState7 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 450;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();

				skill.SetRatio(1.89f);
				skill.SetPlus(1056.33f);
				player.SetPerform(0);
			}
		}
		public GSkill3299Stub()
			: base(3299)
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
			SetAction(0,"鬼王宗_未名斩");
			SetAction(1,"鬼王宗_未名斩");
			SetAction(2,"鬼王宗_未名斩");
			SetAction(3,"鬼王宗_未名斩");
			SetAction(4,"鬼王宗_未名斩");
			SetAction(5,"鬼王宗_未名斩");
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
			SetAction(18,"鬼王宗_骑乘_未名斩");
			SetAction(19,"鬼王宗_骑乘_未名斩");
			SetAction(20,"鬼王宗_骑乘_未名斩");
			SetAction(21,"鬼王宗_骑乘_未名斩");
			SetAction(22,"鬼王宗_骑乘_未名斩");
			SetAction(23,"鬼王宗_骑乘_未名斩");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "未名斩";
			nativename = "未名斩";
			icon = "未名斩.dds";
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
			AddState(new GState3());
			AddState(new GState4());
			AddState(new GState5());
			AddState(new GState6());
			AddState(new GState7());
		}
		public override int GetExecutetime(GSkill skill)
		{
			return 3000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			return 2250;
		}
		public override int GetEnmity(GSkill skill)
		{
			return 1;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 10.800000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 3.500000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 13.800000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			return 500.000000f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_level = player.GetLevel();
			int				player_maxhp = player.GetMaxhp();

			victim.SetProbability(336.0f);
			victim.SetTime(6100.0f);
			victim.SetRatio(0.44999999f);
			victim.SetBuffid(1);
			victim.SetWeak(true);
			victim.SetProbability(((1.0f - player_level * 0.002f) * 33.0f));
			victim.SetTime(6000.0f);
			victim.SetBuffid(1);
			victim.SetAmount((player_maxhp * 0.3f));
			victim.SetValue(0.0f);
			victim.SetMpleak(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetProbability(78.0f);
			victim.SetTime(8100.0f);
			victim.SetRatio(0.36000001f);
			victim.SetDecdamage(true);
			return true;
		}
	}
	public class GSkill3299 : GSkill
	{
		public GSkill3299()
			: base(3299)
		{
			
		}
	}
}
