using System;
using System.Text;

namespace SKILL
{
	public class GSkill2710Stub : GSkillStub
	{
		public GSkill2710Stub()
			: base(2710)
		{
			occupation = 150;
			maxlevel = 12;
			maxlearn = 10;
			eventflag = 1;
			spcost = 0;
			reborncount = 0;
			type = 11;
			timetype = 0;
			targettype = 0;
			rangetype = 0;
			doenchant = false;
			dobless = false;
			autoattack = false;
			allowform = 0;
			credittype = 11;
			clearmask = 132;
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
			name = " ‹…ÌII";
			nativename = " ‹…ÌII";
			icon = " ‹…ÌII.dds";
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
			preskillnum = 1;
			cycle = false;
			cyclemode = 0;
			cyclegfx = "";
			skill_class = 7;
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
		public override int GetRequiredLevel(int level)
		{
			int[] array={125,125,125,125,125,127,129,131,133,135};return array[level-1];
		}
		public override int GetCreditCost(int level)
		{
			int[] array={18000,20000,22000,24000,26000,28000,30000,32000,38000,45000};return array[level-1];
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={2449};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={5};return array[index];
		}
	}
	public class GSkill2710 : GSkill
	{
		public GSkill2710()
			: base(2710)
		{
			
		}
	}
	public class GSkill2711Stub : GSkillStub
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
				int				player_res2 = player.GetRes2();
				int				skill_level = skill.GetLevel();
				int				skill_t0 = skill.GetT0();

				/*
				player.SetVar1((int)(8 * skill_level + player_res2));
				player.SetVar2(player.GetHide());
				  v13 = (0.02f * skill_level) + 1.0f;
				if ( player.GetHide() <= 0 )
				    v12 = v13 + 0.0f;
				  else
				skill.SetRatio((skill_t0 * 0.1f + v13));
				player.SetPerform(1);
				*/
			}
		}
		public GSkill2711Stub()
			: base(2711)
		{
			occupation = 150;
			maxlevel = 12;
			maxlearn = 10;
			eventflag = 0;
			spcost = 0;
			reborncount = 0;
			type = 1;
			timetype = 0;
			targettype = 0;
			rangetype = 0;
			doenchant = true;
			dobless = true;
			autoattack = true;
			allowform = 0;
			credittype = 11;
			clearmask = 132;
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
			weapon_limit = 10;
			SetAction(0,"ª≥π‚_∞µœÆ");
			SetAction(1,"0");
			SetAction(2,"0");
			SetAction(3,"0");
			SetAction(4,"0");
			SetAction(5,"0");
			SetAction(6,"0");
			SetAction(7,"0");
			SetAction(8,"0");
			SetAction(9,"0");
			SetAction(10,"ª≥π‚_∞µœÆ");
			SetAction(11,"0");
			SetAction(12,"0");
			SetAction(13,"");
			SetAction(14,"");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"ª≥π‚_∆Ô≥À_∞µœÆ");
			SetAction(19,"0");
			SetAction(20,"0");
			SetAction(21,"0");
			SetAction(22,"0");
			SetAction(23,"0");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"ª≥π‚_∆Ô≥À_∞µœÆ");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "«±œÆII";
			nativename = "«±œÆII";
			icon = "«±œÆII.dds";
			SetTalent(0,2528);
			SetTalent(1,2427);
			SetTalent(2,2553);
			SetTalent(3,2556);
			SetTalent(4,2453);
			SetTalent(5,0);
			SetTalent(6,0);
			SetTalent(7,0);
			talent_size = 5;
			talent_type = 0;
			use_proficiency = false;
			inc_proficiency = 0;
			preskillnum = 1;
			cycle = false;
			cyclemode = 0;
			cyclegfx = "";
			skill_class = 7;
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
			return 20000;
		}
		public override int GetEnmity(GSkill skill)
		{
			return 1;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={125,125,125,125,125,127,129,131,133,135};return array[level-1];
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 7.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 1.700000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 12.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			return 800.000000f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_var1 = player.GetVar1();
			int				player_var2 = player.GetVar2();
			int				skill_level = skill.GetLevel();
			int				skill_t1 = skill.GetT1();
			int				skill_t2 = skill.GetT2();
			int				skill_t3 = skill.GetT3();

			/*
			if ( player_var2 <= 0 )
			{
			d = player_var1;
			}
			else
			{
			if ( player_var1 <= 600 )
			{
			v29 = 600.0f;
			}
			else
			{
			v29 = player_var1;
			}
			d = v29;
			}
			victim.SetProbability(d);
			victim.SetTime(20000.0f);
			victim.SetRatio((skill_level * 0.05f));
			victim.SetBuffid(0);
			victim.SetWeak(true);
			if ( skill_t1 <= 0 )
			v28 = 0.0f;
			else
			victim.SetProbability(-1.0f);
			victim.SetTime(((5000 * skill_t3 + 20000)));
			victim.SetBuffid(0);
			victim.SetValue(((10 * skill_t1)));
			victim.SetSubanti(true);
			if ( skill_t2 <= 0 )
			v27 = 0.0f;
			else
			victim.SetProbability(-1.0f);
			victim.SetTime(((5000 * skill_t3 + 20000)));
			victim.SetRatio((skill_t2 * 0.1f + 0.0001f));
			victim.SetBuffid(0);
			victim.SetIncfatalhurt(true);
			*/
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_var2 = player.GetVar2();
			int				skill_t4 = skill.GetT4();

			/*
			if ( player_var2 <= 0 )
			d = 0.0f;
			else
			victim.SetProbability(((20 * skill_t4)));
			victim.SetTime(20000.0f);
			victim.SetRatio(3.0f);
			victim.SetBuffid(0);
			victim.SetAmount(1.0f);
			victim.SetValue(34670.0f);
			victim.SetSummonclone(true);
			*/
			return true;
		}
		public override int GetCreditCost(int level)
		{
			int[] array={18000,20000,22000,24000,26000,28000,30000,32000,38000,45000};return array[level-1];
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={2423};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={9};return array[index];
		}
	}
	public class GSkill2711 : GSkill
	{
		public GSkill2711()
			: base(2711)
		{
			
		}
	}
	public class GSkill2712Stub : GSkillStub
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
				int				skill_t0 = skill.GetT0();

				/*
				player.SetVar1(player.GetHide());
				  v9 = (0.02f * skill_level) + 1.0f;
				if ( player.GetHide() <= 0 )
				    v8 = v9 + 0.0f;
				  else
				skill.SetRatio((skill_t0 * 0.1f + v9));
				player.SetPerform(1);
				*/
			}
		}
		public GSkill2712Stub()
			: base(2712)
		{
			occupation = 150;
			maxlevel = 12;
			maxlearn = 10;
			eventflag = 0;
			spcost = 0;
			reborncount = 0;
			type = 1;
			timetype = 0;
			targettype = 0;
			rangetype = 0;
			doenchant = true;
			dobless = true;
			autoattack = true;
			allowform = 0;
			credittype = 11;
			clearmask = 132;
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
			weapon_limit = 10;
			SetAction(0,"ª≥π‚_ªÍœÆ");
			SetAction(1,"0");
			SetAction(2,"0");
			SetAction(3,"0");
			SetAction(4,"0");
			SetAction(5,"0");
			SetAction(6,"0");
			SetAction(7,"0");
			SetAction(8,"0");
			SetAction(9,"0");
			SetAction(10,"ª≥π‚_ªÍœÆ");
			SetAction(11,"0");
			SetAction(12,"0");
			SetAction(13,"");
			SetAction(14,"");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"ª≥π‚_∆Ô≥À_ªÍœÆ");
			SetAction(19,"0");
			SetAction(20,"0");
			SetAction(21,"0");
			SetAction(22,"0");
			SetAction(23,"0");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"ª≥π‚_∆Ô≥À_ªÍœÆ");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "¡‘œÆII";
			nativename = "¡‘œÆII";
			icon = "¡‘œÆII.dds";
			SetTalent(0,2528);
			SetTalent(1,2453);
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
			preskillnum = 1;
			cycle = false;
			cyclemode = 0;
			cyclegfx = "";
			skill_class = 7;
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
			return 20000;
		}
		public override int GetEnmity(GSkill skill)
		{
			return 1;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={125,125,125,125,125,127,129,131,133,135};return array[level-1];
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 7.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 1.700000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 12.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			return 1000.000000f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_var1 = player.GetVar1();
			int				player_occupation = player.GetOccupation();
			int				skill_level = skill.GetLevel();

			/*
			victim.SetProbability(120.0f);
			victim.SetRatio(11.0f);
			victim.SetAmount(0.0f);
			victim.SetValue(0.0f);
			victim.SetDispel(true);
			if ( player_var1 > 0 )
			d = 120.0f;
			else
			victim.SetProbability(((10 * skill_level)));
			victim.SetTime(60000.0f);
			if ( player_occupation != 1
			&& (v11 = player, GNET::PlayerWrapper::GetOccupation(v11) != 2)
			&& (v12 = player, GNET::PlayerWrapper::GetOccupation(v12) != 3)
			&& (v13 = player, GNET::PlayerWrapper::GetOccupation(v13) != 13)
			&& (v14 = player, GNET::PlayerWrapper::GetOccupation(v14) != 14) )
			v127 = 0;
			else
			v127 = 243;
			if ( player_occupation != 4
			&& (v16 = player, GNET::PlayerWrapper::GetOccupation(v16) != 5)
			&& (v17 = player, GNET::PlayerWrapper::GetOccupation(v17) != 6)
			&& (v18 = player, GNET::PlayerWrapper::GetOccupation(v18) != 16)
			&& (v19 = player, GNET::PlayerWrapper::GetOccupation(v19) != 17) )
			v128 = v127;
			else
			v128 = v127 + 289;
			if ( player_occupation != 7
			&& (v21 = player, GNET::PlayerWrapper::GetOccupation(v21) != 8)
			&& (v22 = player, GNET::PlayerWrapper::GetOccupation(v22) != 9)
			&& (v23 = player, GNET::PlayerWrapper::GetOccupation(v23) != 19)
			&& (v24 = player, GNET::PlayerWrapper::GetOccupation(v24) != 20) )
			v129 = v128;
			else
			v129 = v128 + 233;
			if ( player_occupation != 10
			&& (v26 = player, GNET::PlayerWrapper::GetOccupation(v26) != 11)
			&& (v27 = player, GNET::PlayerWrapper::GetOccupation(v27) != 12)
			&& (v28 = player, GNET::PlayerWrapper::GetOccupation(v28) != 22)
			&& (v29 = player, GNET::PlayerWrapper::GetOccupation(v29) != 23) )
			v130 = v129;
			else
			v130 = v129 + 276;
			if ( player_occupation != 25
			&& (v31 = player, GNET::PlayerWrapper::GetOccupation(v31) != 26)
			&& (v32 = player, GNET::PlayerWrapper::GetOccupation(v32) != 27)
			&& (v33 = player, GNET::PlayerWrapper::GetOccupation(v33) != 28)
			&& (v34 = player, GNET::PlayerWrapper::GetOccupation(v34) != 29) )
			v126 = v130;
			else
			victim.SetRatio(((v130 + 1094)));
			if ( player_occupation != 1
			&& (v37 = player, GNET::PlayerWrapper::GetOccupation(v37) != 2)
			&& (v38 = player, GNET::PlayerWrapper::GetOccupation(v38) != 3)
			&& (v39 = player, GNET::PlayerWrapper::GetOccupation(v39) != 13)
			&& (v40 = player, GNET::PlayerWrapper::GetOccupation(v40) != 14) )
			v122 = 0;
			else
			v122 = 393;
			if ( player_occupation != 4
			&& (v42 = player, GNET::PlayerWrapper::GetOccupation(v42) != 5)
			&& (v43 = player, GNET::PlayerWrapper::GetOccupation(v43) != 6)
			&& (v44 = player, GNET::PlayerWrapper::GetOccupation(v44) != 16)
			&& (v45 = player, GNET::PlayerWrapper::GetOccupation(v45) != 17) )
			v123 = v122;
			else
			v123 = v122 + 394;
			if ( player_occupation != 7
			&& (v47 = player, GNET::PlayerWrapper::GetOccupation(v47) != 8)
			&& (v48 = player, GNET::PlayerWrapper::GetOccupation(v48) != 9)
			&& (v49 = player, GNET::PlayerWrapper::GetOccupation(v49) != 19)
			&& (v50 = player, GNET::PlayerWrapper::GetOccupation(v50) != 20) )
			v124 = v123;
			else
			v124 = v123 + 395;
			if ( player_occupation != 10
			&& (v52 = player, GNET::PlayerWrapper::GetOccupation(v52) != 11)
			&& (v53 = player, GNET::PlayerWrapper::GetOccupation(v53) != 12)
			&& (v54 = player, GNET::PlayerWrapper::GetOccupation(v54) != 22)
			&& (v55 = player, GNET::PlayerWrapper::GetOccupation(v55) != 23) )
			v125 = v124;
			else
			v125 = v124 + 396;
			if ( player_occupation != 25
			&& (v57 = player, GNET::PlayerWrapper::GetOccupation(v57) != 26)
			&& (v58 = player, GNET::PlayerWrapper::GetOccupation(v58) != 27)
			&& (v59 = player, GNET::PlayerWrapper::GetOccupation(v59) != 28)
			&& (v60 = player, GNET::PlayerWrapper::GetOccupation(v60) != 29) )
			v121 = v125;
			else
			victim.SetAmount(((v125 + 1104)));
			victim.SetValue(0.0f);
			victim.SetSetcooldown(true);
			if ( player_var1 > 0 )
			v120 = 120.0f;
			else
			victim.SetProbability(((10 * skill_level)));
			victim.SetTime(60000.0f);
			if ( player_occupation != 33
			&& (v68 = player, GNET::PlayerWrapper::GetOccupation(v68) != 34)
			&& (v69 = player, GNET::PlayerWrapper::GetOccupation(v69) != 35)
			&& (v70 = player, GNET::PlayerWrapper::GetOccupation(v70) != 36)
			&& (v71 = player, GNET::PlayerWrapper::GetOccupation(v71) != 37) )
			v117 = 0;
			else
			v117 = 1844;
			if ( player_occupation != 39
			&& (v73 = player, GNET::PlayerWrapper::GetOccupation(v73) != 40)
			&& (v74 = player, GNET::PlayerWrapper::GetOccupation(v74) != 41)
			&& (v75 = player, GNET::PlayerWrapper::GetOccupation(v75) != 42)
			&& (v76 = player, GNET::PlayerWrapper::GetOccupation(v76) != 43) )
			v118 = v117;
			else
			v118 = v117 + 1886;
			if ( player_occupation != 45
			&& (v78 = player, GNET::PlayerWrapper::GetOccupation(v78) != 46)
			&& (v79 = player, GNET::PlayerWrapper::GetOccupation(v79) != 47)
			&& (v80 = player, GNET::PlayerWrapper::GetOccupation(v80) != 48)
			&& (v81 = player, GNET::PlayerWrapper::GetOccupation(v81) != 49) )
			v119 = v118;
			else
			v119 = v118 + 2416;
			if ( player_occupation != 51
			&& (v83 = player, GNET::PlayerWrapper::GetOccupation(v83) != 52)
			&& (v84 = player, GNET::PlayerWrapper::GetOccupation(v84) != 53)
			&& (v85 = player, GNET::PlayerWrapper::GetOccupation(v85) != 54)
			&& (v86 = player, GNET::PlayerWrapper::GetOccupation(v86) != 55) )
			v116 = v119;
			else
			victim.SetRatio(((v119 + 2465)));
			if ( player_occupation != 33
			&& (v89 = player, GNET::PlayerWrapper::GetOccupation(v89) != 34)
			&& (v90 = player, GNET::PlayerWrapper::GetOccupation(v90) != 35)
			&& (v91 = player, GNET::PlayerWrapper::GetOccupation(v91) != 36)
			&& (v92 = player, GNET::PlayerWrapper::GetOccupation(v92) != 37) )
			v113 = 0;
			else
			v113 = 1853;
			if ( player_occupation != 39
			&& (v94 = player, GNET::PlayerWrapper::GetOccupation(v94) != 40)
			&& (v95 = player, GNET::PlayerWrapper::GetOccupation(v95) != 41)
			&& (v96 = player, GNET::PlayerWrapper::GetOccupation(v96) != 42)
			&& (v97 = player, GNET::PlayerWrapper::GetOccupation(v97) != 43) )
			v114 = v113;
			else
			v114 = v113 + 1895;
			if ( player_occupation != 45
			&& (v99 = player, GNET::PlayerWrapper::GetOccupation(v99) != 46)
			&& (v100 = player, GNET::PlayerWrapper::GetOccupation(v100) != 47)
			&& (v101 = player, GNET::PlayerWrapper::GetOccupation(v101) != 48)
			&& (v102 = player, GNET::PlayerWrapper::GetOccupation(v102) != 49) )
			v115 = v114;
			else
			v115 = v114 + 2426;
			if ( player_occupation != 51
			&& (v104 = player, GNET::PlayerWrapper::GetOccupation(v104) != 52)
			&& (v105 = player, GNET::PlayerWrapper::GetOccupation(v105) != 53)
			&& (v106 = player, GNET::PlayerWrapper::GetOccupation(v106) != 54)
			&& (v107 = player, GNET::PlayerWrapper::GetOccupation(v107) != 55) )
			v112 = v115;
			else
			victim.SetAmount(((v115 + 2477)));
			victim.SetValue(0.0f);
			victim.SetSetcooldown(true);
			*/
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_var1 = player.GetVar1();
			int				skill_t1 = skill.GetT1();

			/*
			if ( player_var1 <= 0 )
			d = 0.0f;
			else
			victim.SetProbability(((20 * skill_t1)));
			victim.SetTime(20000.0f);
			victim.SetRatio(3.0f);
			victim.SetBuffid(0);
			victim.SetAmount(1.0f);
			victim.SetValue(34670.0f);
			victim.SetSummonclone(true);
			*/
			return true;
		}
		public override int GetCreditCost(int level)
		{
			int[] array={18000,20000,22000,24000,26000,28000,30000,32000,38000,45000};return array[level-1];
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={2432};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={9};return array[index];
		}
	}
	public class GSkill2712 : GSkill
	{
		public GSkill2712()
			: base(2712)
		{
			
		}
	}
	public class GSkill2713Stub : GSkillStub
	{
		public class GState1 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 750;
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
				return 250;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_res1 = player.GetRes1();
				int				skill_level = skill.GetLevel();
				int				skill_t0 = skill.GetT0();

				/*
				player.SetVar1((int)(8 * skill_level + player_res1));
				player.SetVar2(player.GetHide());
				  v13 = (0.02f * skill_level) + 1.0f;
				if ( player.GetHide() <= 0 )
				    v12 = v13 + 0.0f;
				  else
				skill.SetRatio((skill_t0 * 0.1f + v13));
				player.SetPerform(1);
				*/
			}
		}
		public GSkill2713Stub()
			: base(2713)
		{
			occupation = 150;
			maxlevel = 12;
			maxlearn = 10;
			eventflag = 0;
			spcost = 0;
			reborncount = 0;
			type = 1;
			timetype = 0;
			targettype = 0;
			rangetype = 0;
			doenchant = true;
			dobless = true;
			autoattack = true;
			allowform = 0;
			credittype = 11;
			clearmask = 132;
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
			weapon_limit = 10;
			SetAction(0,"ª≥π‚_”∞œÆ");
			SetAction(1,"0");
			SetAction(2,"0");
			SetAction(3,"0");
			SetAction(4,"0");
			SetAction(5,"0");
			SetAction(6,"0");
			SetAction(7,"0");
			SetAction(8,"0");
			SetAction(9,"0");
			SetAction(10,"ª≥π‚_”∞œÆ");
			SetAction(11,"0");
			SetAction(12,"0");
			SetAction(13,"");
			SetAction(14,"");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"ª≥π‚_∆Ô≥À_”∞œÆ");
			SetAction(19,"0");
			SetAction(20,"0");
			SetAction(21,"0");
			SetAction(22,"0");
			SetAction(23,"0");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"ª≥π‚_∆Ô≥À_”∞œÆ");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "—¿œÆII";
			nativename = "—¿œÆII";
			icon = "—¿œÆII.dds";
			SetTalent(0,2528);
			SetTalent(1,2445);
			SetTalent(2,2555);
			SetTalent(3,2556);
			SetTalent(4,2453);
			SetTalent(5,0);
			SetTalent(6,0);
			SetTalent(7,0);
			talent_size = 5;
			talent_type = 0;
			use_proficiency = false;
			inc_proficiency = 0;
			preskillnum = 1;
			cycle = false;
			cyclemode = 0;
			cyclegfx = "";
			skill_class = 7;
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
			return 20000;
		}
		public override int GetEnmity(GSkill skill)
		{
			return 1;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={125,125,125,125,125,127,129,131,133,135};return array[level-1];
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 7.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 1.700000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 12.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			return 1200.000000f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_var1 = player.GetVar1();
			int				player_var2 = player.GetVar2();
			int				skill_level = skill.GetLevel();
			int				skill_t1 = skill.GetT1();
			int				skill_t2 = skill.GetT2();
			int				skill_t3 = skill.GetT3();

			/*
			victim.SetRatio(0.0f);
			victim.SetAmount(0.0f);
			victim.SetValue((skill_level * 0.05f));
			victim.SetSecondattack(true);
			if ( player_var2 <= 0 )
			{
			v32 = player_var1;
			}
			else
			{
			if ( player_var1 <= 600 )
			{
			v31 = 600.0f;
			}
			else
			{
			v31 = player_var1;
			}
			v32 = v31;
			}
			victim.SetProbability(v32);
			victim.SetTime(5000.0f);
			victim.SetDizzy(true);
			if ( skill_t1 <= 0 )
			v30 = 0.0f;
			else
			victim.SetProbability(-1.0f);
			victim.SetTime(((5000 * skill_t3 + 20000)));
			victim.SetRatio((skill_t1 * 0.03f + 0.00001f));
			victim.SetBuffid(0);
			victim.SetIncfatalratio(true);
			if ( skill_t2 <= 0 )
			v29 = 0.0f;
			else
			victim.SetProbability(-1.0f);
			victim.SetTime(((5000 * skill_t3 + 20000)));
			victim.SetRatio((skill_t2 * 0.05f));
			victim.SetBuffid(0);
			victim.SetDecskilldodge(true);
			*/
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_var2 = player.GetVar2();
			int				skill_t4 = skill.GetT4();

			/*
			if ( player_var2 <= 0 )
			d = 0.0f;
			else
			victim.SetProbability(((20 * skill_t4)));
			victim.SetTime(20000.0f);
			victim.SetRatio(3.0f);
			victim.SetBuffid(0);
			victim.SetAmount(1.0f);
			victim.SetValue(34670.0f);
			victim.SetSummonclone(true);
			*/
			return true;
		}
		public override int GetCreditCost(int level)
		{
			int[] array={18000,20000,22000,24000,26000,28000,30000,32000,38000,45000};return array[level-1];
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={2441};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={9};return array[index];
		}
	}
	public class GSkill2713 : GSkill
	{
		public GSkill2713()
			: base(2713)
		{
			
		}
	}
	public class GSkill2714Stub : GSkillStub
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
				int				player_res1 = player.GetRes1();
				int				player_res2 = player.GetRes2();
				int				player_res3 = player.GetRes3();
				int				player_res4 = player.GetRes4();
				int				player_res5 = player.GetRes5();

				player.SetVar1((int)(player_res5 + (player_res4 + (player_res3 + (player_res2 + player_res1)))));
				player.SetPerform(1);
			}
		}
		public GSkill2714Stub()
			: base(2714)
		{
			occupation = 150;
			maxlevel = 12;
			maxlearn = 10;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 2;
			timetype = 0;
			targettype = 0;
			rangetype = 2;
			doenchant = true;
			dobless = false;
			autoattack = false;
			allowform = 0;
			credittype = 11;
			clearmask = 132;
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
			weapon_limit = 12;
			SetAction(0,"ÃÏª™_À™∫Ë");
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
			SetAction(12,"ÃÏª™_À™∫Ë");
			SetAction(13,"");
			SetAction(14,"");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"ÃÏª™_∆Ô≥À_À™∫Ë");
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
			SetAction(30,"ÃÏª™_∆Ô≥À_À™∫Ë");
			name = "Ã˝À™—≈‘œII";
			nativename = "Ã˝À™—≈‘œII";
			icon = "Ã˝À™—≈‘œII.dds";
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
			preskillnum = 1;
			cycle = false;
			cyclemode = 0;
			cyclegfx = "";
			skill_class = 8;
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
			return 120000;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={125,125,125,125,125,127,129,131,133,135};return array[level-1];
		}
		public override float GetRadius(GSkill skill)
		{
			return 20.000000f;
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
			int				skill_level = skill.GetLevel();

			return (100 * skill_level + 3000);
		}
		public override int GetCoverage(GSkill skill)
		{
			return 6;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_var1 = player.GetVar1();
			int				skill_level = skill.GetLevel();

			victim.SetTime(20000.0f);
			victim.SetRatio((skill_level * 0.01f));
			victim.SetBuffid(0);
			victim.SetIncanti(true);
			victim.SetProbability(120.0f);
			victim.SetTime(10000.0f);
			victim.SetRatio(0.0f);
			victim.SetBuffid(1);
			victim.SetAmount(0.0f);
			victim.SetValue((skill_level * (player_var1 * 0.5f)));
			victim.SetHpgen(true);
			return true;
		}
		public override int GetCreditCost(int level)
		{
			int[] array={18000,20000,22000,24000,26000,28000,30000,32000,38000,45000};return array[level-1];
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={2487};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={9};return array[index];
		}
	}
	public class GSkill2714 : GSkill
	{
		public GSkill2714()
			: base(2714)
		{
			
		}
	}
	public class GSkill2715Stub : GSkillStub
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

				skill.SetCrit((skill_level * 0.02f));
				skill.SetRatio((skill_level * 0.01f + 1.0f));
				player.SetPerform(1);
			}
		}
		public GSkill2715Stub()
			: base(2715)
		{
			occupation = 150;
			maxlevel = 12;
			maxlearn = 10;
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
			credittype = 11;
			clearmask = 132;
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
			weapon_limit = 12;
			SetAction(0,"ÃÏª™_«ÂÙ•");
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
			SetAction(12,"ÃÏª™_«ÂÙ•");
			SetAction(13,"");
			SetAction(14,"");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"ÃÏª™_∆Ô≥À_«ÂÙ•");
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
			SetAction(30,"ÃÏª™_∆Ô≥À_«ÂÙ•");
			name = "÷–∆Ω“Ù»–II";
			nativename = "÷–∆Ω“Ù»–II";
			icon = "÷–∆Ω“Ù»–II.dds";
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
			preskillnum = 1;
			cycle = false;
			cyclemode = 0;
			cyclegfx = "";
			skill_class = 8;
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
			return 120000;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={125,125,125,125,125,127,129,131,133,135};return array[level-1];
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
			return 25.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			return 1500.000000f;
		}
		public override int GetCoverage(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return skill_level + 2;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();

			victim.SetProbability(((2 * skill_level) + (skill_level * (skill_level * 0.7f)) + 10.0f));
			victim.SetRatio(1.0f);
			victim.SetUnsummon(true);
			victim.SetProbability(-1.0f);
			victim.SetRatio(2.0f);
			victim.SetUnsummon(true);
			victim.SetProbability(-1.0f);
			victim.SetRatio(3.0f);
			victim.SetUnsummonclone(true);
			return true;
		}
		public override int GetCreditCost(int level)
		{
			int[] array={18000,20000,22000,24000,26000,28000,30000,32000,38000,45000};return array[level-1];
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={2480};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={9};return array[index];
		}
	}
	public class GSkill2715 : GSkill
	{
		public GSkill2715()
			: base(2715)
		{
			
		}
	}
	public class GSkill2716Stub : GSkillStub
	{
		public class GState1 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 1000;
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
		public GSkill2716Stub()
			: base(2716)
		{
			occupation = 150;
			maxlevel = 12;
			maxlearn = 10;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 2;
			timetype = 0;
			targettype = 0;
			rangetype = 0;
			doenchant = true;
			dobless = true;
			autoattack = false;
			allowform = 0;
			credittype = 11;
			clearmask = 132;
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
			weapon_limit = 12;
			SetAction(0,"ÃÏª™_ Ø…œ«Â»™");
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
			SetAction(12,"ÃÏª™_ Ø…œ«Â»™");
			SetAction(13,"");
			SetAction(14,"");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"ÃÏª™_∆Ô≥À_ Ø…œ«Â»™");
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
			SetAction(30,"ÃÏª™_∆Ô≥À_ Ø…œ«Â»™");
			name = "‘∆ÀÆ—≈‘œII";
			nativename = "‘∆ÀÆ—≈‘œII";
			icon = "‘∆ÀÆ—≈‘œII.dds";
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
			preskillnum = 1;
			cycle = false;
			cyclemode = 0;
			cyclegfx = "";
			skill_class = 8;
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
			return 1500;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			return 90000;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={125,125,125,125,125,127,129,131,133,135};return array[level-1];
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
			return 25.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			return 900.000000f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();

			victim.SetProbability(120.0f);
			victim.SetTime(((1000 * skill_level + 6000)));
			victim.SetRatio((skill_level * 0.01f + 0.000001f));
			victim.SetBuffid(1);
			victim.SetIncskillaccu(true);
			victim.SetProbability(100.0f);
			victim.SetTime(((1000 * skill_level + 6000)));
			victim.SetRatio((skill_level * 0.025f));
			victim.SetDecdamage(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetRatio(2465.0f);
			victim.SetAmount(2496.0f);
			victim.SetValue(0.0f);
			victim.SetClearcooldown(true);
			return true;
		}
		public override int GetCreditCost(int level)
		{
			int[] array={18000,20000,22000,24000,26000,28000,30000,32000,38000,45000};return array[level-1];
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={2486};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={3};return array[index];
		}
	}
	public class GSkill2716 : GSkill
	{
		public GSkill2716()
			: base(2716)
		{
			
		}
	}
	public class GSkill2717Stub : GSkillStub
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
			public override bool Cancel(GSkill skill)
			{
				return true;
			}
		}
		public class GState2 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 2900;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();

				player.SetPerform(1);
			}
		}
		public GSkill2717Stub()
			: base(2717)
		{
			occupation = 150;
			maxlevel = 12;
			maxlearn = 10;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 2;
			timetype = 0;
			targettype = 0;
			rangetype = 14;
			doenchant = true;
			dobless = true;
			autoattack = false;
			allowform = 0;
			credittype = 11;
			clearmask = 132;
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
			weapon_limit = 12;
			SetAction(0,"ÃÏª™_¡Ï”Ú_—Ù¥∫∞◊—©");
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
			SetAction(12,"ÃÏª™_¡Ï”Ú_—Ù¥∫∞◊—©");
			SetAction(13,"");
			SetAction(14,"");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"ÃÏª™_¡Ï”Ú_—Ù¥∫∞◊—©");
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
			SetAction(30,"ÃÏª™_¡Ï”Ú_—Ù¥∫∞◊—©");
			name = "ÃÏÙ•£∫—Ù¥∫∞◊—©II";
			nativename = "ÃÏÙ•£∫—Ù¥∫∞◊—©II";
			icon = "ÃÏÙ•£∫—Ù¥∫∞◊—©II.dds";
			SetTalent(0,2593);
			SetTalent(1,2599);
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
			preskillnum = 1;
			cycle = false;
			cyclemode = 0;
			cyclegfx = "";
			skill_class = 8;
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
			int				skill_t0 = skill.GetT0();

			return 120000 - 20000 * skill_t0;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={125,125,125,125,125,127,129,131,133,135};return array[level-1];
		}
		public override float GetRadius(GSkill skill)
		{
			return 20.000000f;
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
			return 20.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			int				skill_t1 = skill.GetT1();

			return ((1.0f - skill_t1 * 0.04f) * 600.0f);
		}
		public override int GetCoverage(GSkill skill)
		{
			return 6;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();

			victim.SetProbability(((2 * skill_level) + (skill_level * (skill_level * 0.7f)) + 10.0f));
			victim.SetAmount(1.0f);
			victim.SetCleardebuff(true);
			victim.SetProbability(-1.0f);
			victim.SetTime(3000.0f);
			victim.SetRatio((((2 * skill_level) + (skill_level * (skill_level * 0.3f)) + 10.0f) * 0.01f));
			victim.SetBuffid(1);
			victim.SetInccrithurt(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetProbability(0.0f);
			victim.SetTime(3600000.0f);
			victim.SetRatio(27.0f);
			victim.SetAmount(0.0f);
			victim.SetValue(1.0f);
			victim.SetAbsulotearea(true);
			return true;
		}
		public override int GetCreditCost(int level)
		{
			int[] array={18000,20000,22000,24000,26000,28000,30000,32000,38000,45000};return array[level-1];
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={2497};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={9};return array[index];
		}
	}
	public class GSkill2717 : GSkill
	{
		public GSkill2717()
			: base(2717)
		{
			
		}
	}
	public class GSkill2718Stub : GSkillStub
	{
		public GSkill2718Stub()
			: base(2718)
		{
			occupation = 150;
			maxlevel = 12;
			maxlearn = 10;
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
			credittype = 11;
			clearmask = 132;
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
			weapon_limit = 12;
			SetAction(0,"ÃÏª™_”Ò‘œ");
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
			SetAction(12,"ÃÏª™_”Ò‘œ");
			SetAction(13,"");
			SetAction(14,"");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"ÃÏª™_∆Ô≥À_”Ò‘œ");
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
			SetAction(30,"ÃÏª™_∆Ô≥À_”Ò‘œ");
			name = "æµª®ÀÆ‘¬II";
			nativename = "æµª®ÀÆ‘¬II";
			icon = "æµª®ÀÆ‘¬II.dds";
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
			preskillnum = 1;
			cycle = false;
			cyclemode = 0;
			cyclegfx = "";
			skill_class = 8;
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
		public override int GetRequiredLevel(int level)
		{
			int[] array={125,125,125,125,125,127,129,131,133,135};return array[level-1];
		}
		public override int GetCreditCost(int level)
		{
			int[] array={18000,20000,22000,24000,26000,28000,30000,32000,38000,45000};return array[level-1];
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={2496};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={5};return array[index];
		}
	}
	public class GSkill2718 : GSkill
	{
		public GSkill2718()
			: base(2718)
		{
			
		}
	}
	public class GSkill2719Stub : GSkillStub
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

				player.SetPerform(1);
			}
		}
		public GSkill2719Stub()
			: base(2719)
		{
			occupation = 151;
			maxlevel = 5;
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
			SetAction(0,"πÌÕı◊⁄_ª¢–•");
			SetAction(1,"«‡‘∆√≈_ª¢–•");
			SetAction(2,"πÌÕı◊⁄_ª¢–•");
			SetAction(3,"∫œª∂≈…_ª¢–•");
			SetAction(4,"ÃÏ“ÙÀ¬_ª¢–•");
			SetAction(5,"πÌµ¿_ª¢–•");
			SetAction(6,"πÌÕı◊⁄_ª¢–•");
			SetAction(7," ﬁ…Ò_∫·––");
			SetAction(8,"∫¸—˝_∑Á––’ﬂ");
			SetAction(9,"");
			SetAction(10,"0");
			SetAction(11," ﬁ…Ò_∫·––");
			SetAction(12,"0");
			SetAction(13,"");
			SetAction(14,"");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"πÌÕı◊⁄_∆Ô≥À_ª¢–•");
			SetAction(19,"«‡‘∆√≈_∆Ô≥À_ª¢–•");
			SetAction(20,"πÌÕı◊⁄_∆Ô≥À_ª¢–•");
			SetAction(21,"∫œª∂≈…_∆Ô≥À_ª¢–•");
			SetAction(22,"ÃÏ“ÙÀ¬_∆Ô≥À_ª¢–•");
			SetAction(23,"πÌµ¿_∆Ô≥À_ª¢–•");
			SetAction(24,"πÌÕı◊⁄_∆Ô≥À_ª¢–•");
			SetAction(25," ﬁ…Ò_∆Ô≥À_∫·––");
			SetAction(26,"∫¸—˝_∆Ô≥À_∑Á––’ﬂ");
			SetAction(27,"");
			SetAction(28,"0");
			SetAction(29," ﬁ…Ò_∆Ô≥À_∫·––");
			SetAction(30,"0");
			name = "∫∆‘™’Ú∆«";
			nativename = "∫∆‘™’Ú∆«";
			icon = "Õ®”√03.dds";
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
			return 180000;
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
			return 300.000000f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetTime(30000.0f);
			victim.SetBuffid(2);
			victim.SetValue(300.0f);
			victim.SetAddantidizzy(true);
			victim.SetTime(30000.0f);
			victim.SetBuffid(2);
			victim.SetValue(300.0f);
			victim.SetAddantisleep(true);
			victim.SetTime(30000.0f);
			victim.SetBuffid(2);
			victim.SetValue(300.0f);
			victim.SetAddantisilent(true);
			victim.SetTime(30000.0f);
			victim.SetBuffid(2);
			victim.SetValue(300.0f);
			victim.SetAddantiwrap(true);
			return true;
		}
	}
	public class GSkill2719 : GSkill
	{
		public GSkill2719()
			: base(2719)
		{
			
		}
	}
}
