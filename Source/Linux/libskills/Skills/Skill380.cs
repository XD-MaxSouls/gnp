using System;
using System.Text;

namespace SKILL
{
	public class GSkill380Stub : GSkillStub
	{
		public GSkill380Stub()
			: base(380)
		{
			occupation = 7;
			maxlevel = 12;
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
			name = "玄妙镜";
			nativename = "玄妙镜";
			icon = "玄妙镜.dds";
			SetTalent(0,587);
			SetTalent(1,595);
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
			skill_class = 2;
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
			int[] array={35,40,45,50,55,59};return array[level-1];
		}
		public override bool TakeEffect(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();
			int				skill_t1 = skill.GetT1();

			player.SetPasadddizzy((skill_t0 * 0.2f + 1.0f) * (5 * skill_level));
			player.SetPasaddhp(20 * skill_level * skill_t1);
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={231};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={3};return array[index];
		}
	}
	public class GSkill380 : GSkill
	{
		public GSkill380()
			: base(380)
		{
			
		}
	}
	public class GSkill381Stub : GSkillStub
	{
		public GSkill381Stub()
			: base(381)
		{
			occupation = 9;
			maxlevel = 12;
			maxlearn = 7;
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
			name = "齐物论";
			nativename = "齐物论";
			icon = "齐物论.dds";
			SetTalent(0,595);
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
			skill_class = 2;
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
			int[] array={95,99,103,107,109,111,113};return array[level-1];
		}
		public override bool TakeEffect(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();

			player.SetPasadddefence(((5 * skill_level + 1)));
			player.SetPasaddhp(((20 * skill_t0 * skill_level)));
			player.SetPasdecfatalhurt((skill_level * 0.0501f));
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={241};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={2};return array[index];
		}
	}
	public class GSkill381 : GSkill
	{
		public GSkill381()
			: base(381)
		{
			
		}
	}
	public class GSkill382Stub : GSkillStub
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
		public GSkill382Stub()
			: base(382)
		{
			occupation = 11;
			maxlevel = 20;
			maxlearn = 8;
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
			SetAction(0,"天音寺_四大皆空火");
			SetAction(1,"天音寺_四大皆空火");
			SetAction(2,"天音寺_四大皆空火");
			SetAction(3,"天音寺_四大皆空火");
			SetAction(4,"天音寺_四大皆空火");
			SetAction(5,"天音寺_四大皆空火");
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
			SetAction(18,"天音寺_骑乘_四大皆空火");
			SetAction(19,"天音寺_骑乘_四大皆空火");
			SetAction(20,"天音寺_骑乘_四大皆空火");
			SetAction(21,"天音寺_骑乘_四大皆空火");
			SetAction(22,"天音寺_骑乘_四大皆空火");
			SetAction(23,"天音寺_骑乘_四大皆空火");
			SetAction(24,"");
			SetAction(25,"");
			SetAction(26,"");
			SetAction(27,"");
			SetAction(28,"");
			SetAction(29,"");
			SetAction(30,"");
			name = "四大皆空：火";
			nativename = "四大皆空：火";
			icon = "四大皆空：火.dds";
			SetTalent(0,679);
			SetTalent(1,680);
			SetTalent(2,691);
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
			return 4000;
		}
		public override int GetEnmity(GSkill skill)
		{
			return 1;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={55,58,61,64,67,70,73,77};return array[level-1];
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

			return (skill_level * 2.21f + ((3 * skill_level * skill_level)) + 228.0f);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_level = player.GetLevel();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();
			int				skill_t1 = skill.GetT1();
			int				skill_t2 = skill.GetT2();

			victim.SetTime(((900000 * skill_t0 + 1800000)));
			victim.SetBuffid(1);
			victim.SetValue(((skill_t1 * 0.4f + 1.0f) * ((8 * skill_level + 8))));
			victim.SetAddantiweak(true);
			victim.SetProbability(100.0f);
			victim.SetRatio(0.0f);
			victim.SetValue((skill_t0 * ((skill_level * 2.21f + ((3 * skill_level * skill_level)) + 228.0f) * 0.3f)));
			victim.SetHeal(true);
			victim.SetProbability(((8 * skill_t2)));
			victim.SetTime(((15050 * skill_t2)));
			victim.SetRatio((skill_t2 * 0.04f));
			victim.SetBuffid(1);
			victim.SetIncattack(true);
			victim.SetProbability(((100 * norm(skill_t1))));
			victim.SetTime(1800000.0f);
			victim.SetBuffid(0);
			victim.SetValue(((4 * (player.GetSkilllevel(385) + (player.GetSkilllevel(384) + (player.GetSkilllevel(383) + player.GetSkilllevel(382)))) * skill_t1) + (player_level * (skill_t1 * 0.25f) + 1.0f)));
			victim.SetAddattack3(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_t0 = skill.GetT0();
			int				skill_t1 = skill.GetT1();

			/*
			if ( player.GetHasbuff(4511) == 1 )
			{
			t = 1.0f;
			}
			else
			{
			t = ((norm(skill_t1) * (900000 * skill_t0 + 1800000)) * norm(player.GetSkilllevel(383)));
			}
			victim.SetTime(t);
			victim.SetBuffid((player.GetHasbuff(4511) != 1));
			if ( player.GetHasbuff(4511) == 1 )
			{
			d = 0.0000099999997f;
			}
			else
			{
			d = (skill_t1 * 0.4f + 1.0f) * ((8 * player.GetSkilllevel(383) + 8));
			}
			victim.SetValue(d);
			victim.SetAddantisilent(true);
			if ( player.GetHasbuff(4521) == 1 )
			{
			v51 = 1.0f;
			}
			else
			{
			v51 = ((norm(skill_t1) * (900000 * skill_t0 + 1800000)) * norm(player.GetSkilllevel(384)));
			}
			victim.SetTime(v51);
			victim.SetBuffid((player.GetHasbuff(4521) != 1));
			if ( player.GetHasbuff(4521) == 1 )
			{
			v50 = 0.0000099999997f;
			}
			else
			{
			v50 = (skill_t1 * 0.4f + 1.0f) * ((8 * player.GetSkilllevel(384) + 8));
			}
			victim.SetValue(v50);
			victim.SetAddantiwrap(true);
			if ( player.GetHasbuff(4481) == 1 )
			{
			v49 = 1.0f;
			}
			else
			{
			v49 = ((norm(skill_t1) * (900000 * skill_t0 + 1800000)) * norm(player.GetSkilllevel(385)));
			}
			victim.SetTime(v49);
			victim.SetBuffid((player.GetHasbuff(4481) != 1));
			if ( player.GetHasbuff(4481) == 1 )
			{
			v48 = 0.0000099999997f;
			}
			else
			{
			v48 = (skill_t1 * 0.4f + 1.0f) * ((8 * player.GetSkilllevel(385) + 8));
			}
			victim.SetValue(v48);
			victim.SetAddantidizzy(true);
			*/
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={396};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={2};return array[index];
		}
	}
	public class GSkill382 : GSkill
	{
		public GSkill382()
			: base(382)
		{
			
		}
	}
	public class GSkill383Stub : GSkillStub
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
		public GSkill383Stub()
			: base(383)
		{
			occupation = 11;
			maxlevel = 20;
			maxlearn = 8;
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
			SetAction(0,"天音寺_四大皆空风");
			SetAction(1,"天音寺_四大皆空风");
			SetAction(2,"天音寺_四大皆空风");
			SetAction(3,"天音寺_四大皆空风");
			SetAction(4,"天音寺_四大皆空风");
			SetAction(5,"天音寺_四大皆空风");
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
			SetAction(18,"天音寺_骑乘_四大皆空风");
			SetAction(19,"天音寺_骑乘_四大皆空风");
			SetAction(20,"天音寺_骑乘_四大皆空风");
			SetAction(21,"天音寺_骑乘_四大皆空风");
			SetAction(22,"天音寺_骑乘_四大皆空风");
			SetAction(23,"天音寺_骑乘_四大皆空风");
			SetAction(24,"");
			SetAction(25,"");
			SetAction(26,"");
			SetAction(27,"");
			SetAction(28,"");
			SetAction(29,"");
			SetAction(30,"");
			name = "四大皆空：风";
			nativename = "四大皆空：风";
			icon = "四大皆空：风.dds";
			SetTalent(0,679);
			SetTalent(1,680);
			SetTalent(2,691);
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
			return 4000;
		}
		public override int GetEnmity(GSkill skill)
		{
			return 1;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={65,68,71,74,77,79,81,84};return array[level-1];
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

			return (((111 * skill_level + 180)) - skill_level * (skill_level * 2.21f));
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_level = player.GetLevel();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();
			int				skill_t1 = skill.GetT1();
			int				skill_t2 = skill.GetT2();

			victim.SetTime(((900000 * skill_t0 + 1800000)));
			victim.SetBuffid(1);
			victim.SetValue(((skill_t1 * 0.4f + 1.0f) * ((8 * skill_level + 8))));
			victim.SetAddantisilent(true);
			victim.SetProbability(100.0f);
			victim.SetRatio(0.0f);
			victim.SetValue((skill_t0 * ((((111 * skill_level + 180)) - skill_level * (skill_level * 2.21f)) * 0.3f)));
			victim.SetHeal(true);
			victim.SetProbability(((8 * skill_t2)));
			victim.SetTime(((15050 * skill_t2)));
			victim.SetRatio((skill_t2 * 0.04f));
			victim.SetBuffid(1);
			victim.SetIncattack(true);
			victim.SetProbability(((100 * norm(skill_t1))));
			victim.SetTime(1800000.0f);
			victim.SetBuffid(0);
			victim.SetValue(((4 * (player.GetSkilllevel(385) + (player.GetSkilllevel(384) + (player.GetSkilllevel(383) + player.GetSkilllevel(382)))) * skill_t1) + (player_level * (skill_t1 * 0.25f) + 1.0f)));
			victim.SetAddattack3(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_t0 = skill.GetT0();
			int				skill_t1 = skill.GetT1();

			/*
			if ( player.GetHasbuff(4501) == 1 )
			{
			t = 1.0f;
			}
			else
			{
			t = ((norm(skill_t1) * (900000 * skill_t0 + 1800000)) * norm(player.GetSkilllevel(382)));
			}
			victim.SetTime(t);
			victim.SetBuffid((player.GetHasbuff(4501) != 1));
			if ( player.GetHasbuff(4501) == 1 )
			{
			d = 0.0000099999997f;
			}
			else
			{
			d = (skill_t1 * 0.4f + 1.0f) * ((8 * player.GetSkilllevel(382) + 8));
			}
			victim.SetValue(d);
			victim.SetAddantiweak(true);
			if ( player.GetHasbuff(4521) == 1 )
			{
			v51 = 1.0f;
			}
			else
			{
			v51 = ((norm(skill_t1) * (900000 * skill_t0 + 1800000)) * norm(player.GetSkilllevel(384)));
			}
			victim.SetTime(v51);
			victim.SetBuffid((player.GetHasbuff(4521) != 1));
			if ( player.GetHasbuff(4521) == 1 )
			{
			v50 = 0.0000099999997f;
			}
			else
			{
			v50 = (skill_t1 * 0.4f + 1.0f) * ((8 * player.GetSkilllevel(384) + 8));
			}
			victim.SetValue(v50);
			victim.SetAddantiwrap(true);
			if ( player.GetHasbuff(4481) == 1 )
			{
			v49 = 1.0f;
			}
			else
			{
			v49 = ((norm(skill_t1) * (900000 * skill_t0 + 1800000)) * norm(player.GetSkilllevel(385)));
			}
			victim.SetTime(v49);
			victim.SetBuffid((player.GetHasbuff(4481) != 1));
			if ( player.GetHasbuff(4481) == 1 )
			{
			v48 = 0.0000099999997f;
			}
			else
			{
			v48 = (skill_t1 * 0.4f + 1.0f) * ((8 * player.GetSkilllevel(385) + 8));
			}
			victim.SetValue(v48);
			victim.SetAddantidizzy(true);
			*/
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={386};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={1};return array[index];
		}
	}
	public class GSkill383 : GSkill
	{
		public GSkill383()
			: base(383)
		{
			
		}
	}
	public class GSkill384Stub : GSkillStub
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
		public GSkill384Stub()
			: base(384)
		{
			occupation = 12;
			maxlevel = 20;
			maxlearn = 8;
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
			SetAction(0,"天音寺_四大皆空水");
			SetAction(1,"天音寺_四大皆空水");
			SetAction(2,"天音寺_四大皆空水");
			SetAction(3,"天音寺_四大皆空水");
			SetAction(4,"天音寺_四大皆空水");
			SetAction(5,"天音寺_四大皆空水");
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
			SetAction(18,"天音寺_骑乘_四大皆空水");
			SetAction(19,"天音寺_骑乘_四大皆空水");
			SetAction(20,"天音寺_骑乘_四大皆空水");
			SetAction(21,"天音寺_骑乘_四大皆空水");
			SetAction(22,"天音寺_骑乘_四大皆空水");
			SetAction(23,"天音寺_骑乘_四大皆空水");
			SetAction(24,"");
			SetAction(25,"");
			SetAction(26,"");
			SetAction(27,"");
			SetAction(28,"");
			SetAction(29,"");
			SetAction(30,"");
			name = "四大皆空：水";
			nativename = "四大皆空：水";
			icon = "四大皆空：水.dds";
			SetTalent(0,679);
			SetTalent(1,680);
			SetTalent(2,691);
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
			return 4000;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={85,87,89,91,93,95,97,100};return array[level-1];
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

			return (((96 * skill_level + 171)) - skill_level * (skill_level * 1.47f));
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_level = player.GetLevel();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();
			int				skill_t1 = skill.GetT1();
			int				skill_t2 = skill.GetT2();

			victim.SetTime(((900000 * skill_t0 + 1800000)));
			victim.SetBuffid(1);
			victim.SetValue(((skill_t1 * 0.4f + 1.0f) * ((8 * skill_level + 8))));
			victim.SetAddantiwrap(true);
			victim.SetProbability(100.0f);
			victim.SetRatio(0.0f);
			victim.SetValue((skill_t0 * ((((96 * skill_level + 171)) - skill_level * (skill_level * 1.47f)) * 0.3f)));
			victim.SetHeal(true);
			victim.SetProbability(((8 * skill_t2)));
			victim.SetTime(((15050 * skill_t2)));
			victim.SetRatio((skill_t2 * 0.04f));
			victim.SetBuffid(1);
			victim.SetIncattack(true);
			victim.SetProbability(((100 * norm(skill_t1))));
			victim.SetTime(1800000.0f);
			victim.SetBuffid(0);
			victim.SetValue(((4 * (player.GetSkilllevel(385) + (player.GetSkilllevel(384) + (player.GetSkilllevel(383) + player.GetSkilllevel(382)))) * skill_t1) + (player_level * (skill_t1 * 0.25f) + 1.0f)));
			victim.SetAddattack3(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_t0 = skill.GetT0();
			int				skill_t1 = skill.GetT1();

			/*
			if ( player.GetHasbuff(4501) == 1 )
			{
			t = 1.0f;
			}
			else
			{
			t = ((norm(skill_t1) * (900000 * skill_t0 + 1800000)) * norm(player.GetSkilllevel(382)));
			}
			victim.SetTime(t);
			victim.SetBuffid((player.GetHasbuff(4501) != 1));
			if ( player.GetHasbuff(4501) == 1 )
			{
			d = 0.0000099999997f;
			}
			else
			{
			d = (skill_t1 * 0.4f + 1.0f) * ((8 * player.GetSkilllevel(382) + 8));
			}
			victim.SetValue(d);
			victim.SetAddantiweak(true);
			if ( player.GetHasbuff(4481) == 1 )
			{
			v51 = 1.0f;
			}
			else
			{
			v51 = ((norm(skill_t1) * (900000 * skill_t0 + 1800000)) * norm(player.GetSkilllevel(385)));
			}
			victim.SetTime(v51);
			victim.SetBuffid((player.GetHasbuff(4481) != 1));
			if ( player.GetHasbuff(4481) == 1 )
			{
			v50 = 0.0000099999997f;
			}
			else
			{
			v50 = (skill_t1 * 0.4f + 1.0f) * ((8 * player.GetSkilllevel(385) + 8));
			}
			victim.SetValue(v50);
			victim.SetAddantidizzy(true);
			if ( player.GetHasbuff(4511) == 1 )
			{
			v49 = 1.0f;
			}
			else
			{
			v49 = ((norm(skill_t1) * (900000 * skill_t0 + 1800000)) * norm(player.GetSkilllevel(383)));
			}
			victim.SetTime(v49);
			victim.SetBuffid((player.GetHasbuff(4511) != 1));
			if ( player.GetHasbuff(4511) == 1 )
			{
			v48 = 0.0000099999997f;
			}
			else
			{
			v48 = (skill_t1 * 0.4f + 1.0f) * ((8 * player.GetSkilllevel(383) + 8));
			}
			victim.SetValue(v48);
			victim.SetAddantisilent(true);
			*/
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={465};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={2};return array[index];
		}
	}
	public class GSkill384 : GSkill
	{
		public GSkill384()
			: base(384)
		{
			
		}
	}
	public class GSkill385Stub : GSkillStub
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
		public GSkill385Stub()
			: base(385)
		{
			occupation = 12;
			maxlevel = 20;
			maxlearn = 8;
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
			SetAction(0,"天音寺_四大皆空地");
			SetAction(1,"天音寺_四大皆空地");
			SetAction(2,"天音寺_四大皆空地");
			SetAction(3,"天音寺_四大皆空地");
			SetAction(4,"天音寺_四大皆空地");
			SetAction(5,"天音寺_四大皆空地");
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
			SetAction(18,"天音寺_骑乘_四大皆空地");
			SetAction(19,"天音寺_骑乘_四大皆空地");
			SetAction(20,"天音寺_骑乘_四大皆空地");
			SetAction(21,"天音寺_骑乘_四大皆空地");
			SetAction(22,"天音寺_骑乘_四大皆空地");
			SetAction(23,"天音寺_骑乘_四大皆空地");
			SetAction(24,"");
			SetAction(25,"");
			SetAction(26,"");
			SetAction(27,"");
			SetAction(28,"");
			SetAction(29,"");
			SetAction(30,"");
			name = "四大皆空：地";
			nativename = "四大皆空：地";
			icon = "四大皆空：地.dds";
			SetTalent(0,679);
			SetTalent(1,680);
			SetTalent(2,691);
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
			return 4000;
		}
		public override int GetEnmity(GSkill skill)
		{
			return 1;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={95,98,101,103,107,109,111,114};return array[level-1];
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

			return (((135 * skill_level + 252)) - skill_level * (skill_level * 3.6f));
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_level = player.GetLevel();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();
			int				skill_t1 = skill.GetT1();
			int				skill_t2 = skill.GetT2();

			victim.SetTime(((900000 * skill_t0 + 1800000)));
			victim.SetBuffid(1);
			victim.SetValue(((skill_t1 * 0.4f + 1.0f) * ((8 * skill_level + 8))));
			victim.SetAddantidizzy(true);
			victim.SetProbability(100.0f);
			victim.SetRatio(0.0f);
			victim.SetValue((skill_t0 * ((((135 * skill_level + 252)) - skill_level * (skill_level * 3.6f)) * 0.3f)));
			victim.SetHeal(true);
			victim.SetProbability(((8 * skill_t2)));
			victim.SetTime(((15050 * skill_t2)));
			victim.SetRatio((skill_t2 * 0.04f));
			victim.SetBuffid(1);
			victim.SetIncattack(true);
			victim.SetProbability(((100 * norm(skill_t1))));
			victim.SetTime(1800000.0f);
			victim.SetBuffid(0);
			victim.SetValue(((4 * (player.GetSkilllevel(385) + (player.GetSkilllevel(384) + (player.GetSkilllevel(383) + player.GetSkilllevel(382)))) * skill_t1) + (player_level * (skill_t1 * 0.25f) + 1.0f)));
			victim.SetAddattack3(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_t0 = skill.GetT0();
			int				skill_t1 = skill.GetT1();

			/*
			if ( player.GetHasbuff(4501) == 1 )
			{
			t = 1.0f;
			}
			else
			{
			t = ((norm(skill_t1) * (900000 * skill_t0 + 1800000)) * norm(player.GetSkilllevel(382)));
			}
			victim.SetTime(t);
			victim.SetBuffid((player.GetHasbuff(4501) != 1));
			if ( player.GetHasbuff(4501) == 1 )
			{
			d = 0.0000099999997f;
			}
			else
			{
			d = (skill_t1 * 0.4f + 1.0f) * ((8 * player.GetSkilllevel(382) + 8));
			}
			victim.SetValue(d);
			victim.SetAddantiweak(true);
			if ( player.GetHasbuff(4511) == 1 )
			{
			v51 = 1.0f;
			}
			else
			{
			v51 = ((norm(skill_t1) * (900000 * skill_t0 + 1800000)) * norm(player.GetSkilllevel(383)));
			}
			victim.SetTime(v51);
			victim.SetBuffid((player.GetHasbuff(4511) != 1));
			if ( player.GetHasbuff(4511) == 1 )
			{
			v50 = 0.0000099999997f;
			}
			else
			{
			v50 = (skill_t1 * 0.4f + 1.0f) * ((8 * player.GetSkilllevel(383) + 8));
			}
			victim.SetValue(v50);
			victim.SetAddantisilent(true);
			if ( player.GetHasbuff(4521) == 1 )
			{
			v49 = 1.0f;
			}
			else
			{
			v49 = ((norm(skill_t1) * (900000 * skill_t0 + 1800000)) * norm(player.GetSkilllevel(384)));
			}
			victim.SetTime(v49);
			victim.SetBuffid((player.GetHasbuff(4521) != 1));
			if ( player.GetHasbuff(4521) == 1 )
			{
			v48 = 0.0000099999997f;
			}
			else
			{
			v48 = (skill_t1 * 0.4f + 1.0f) * ((8 * player.GetSkilllevel(384) + 8));
			}
			victim.SetValue(v48);
			victim.SetAddantiwrap(true);
			*/
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={285};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={2};return array[index];
		}
	}
	public class GSkill385 : GSkill
	{
		public GSkill385()
			: base(385)
		{
			
		}
	}
	public class GSkill386Stub : GSkillStub
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

				player.SetPerform(1);
			}
		}
		public GSkill386Stub()
			: base(386)
		{
			occupation = 11;
			maxlevel = 12;
			maxlearn = 5;
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
			SetAction(0,"天音寺_大慈悲");
			SetAction(1,"天音寺_大慈悲");
			SetAction(2,"天音寺_大慈悲");
			SetAction(3,"天音寺_大慈悲");
			SetAction(4,"天音寺_大慈悲");
			SetAction(5,"天音寺_大慈悲");
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
			SetAction(18,"天音寺_骑乘_大慈悲");
			SetAction(19,"天音寺_骑乘_大慈悲");
			SetAction(20,"天音寺_骑乘_大慈悲");
			SetAction(21,"天音寺_骑乘_大慈悲");
			SetAction(22,"天音寺_骑乘_大慈悲");
			SetAction(23,"天音寺_骑乘_大慈悲");
			SetAction(24,"");
			SetAction(25,"");
			SetAction(26,"");
			SetAction(27,"");
			SetAction(28,"");
			SetAction(29,"");
			SetAction(30,"");
			name = "大慈悲";
			nativename = "大慈悲";
			icon = "大慈悲.dds";
			SetTalent(0,684);
			SetTalent(1,709);
			SetTalent(2,710);
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
			return 2000;
		}
		public override int GetEnmity(GSkill skill)
		{
			return 1;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={55,60,63,69,76};return array[level-1];
		}
		public override float GetRadius(GSkill skill)
		{
			return 18.000000f;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 18.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 10.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (skill_level * 8.800000000000001f + (skill_level * (skill_level * 2.7f)) + 239.0f);
		}
		public override int GetCoverage(GSkill skill)
		{
			return 40;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();
			int				skill_t1 = skill.GetT1();
			int				skill_t2 = skill.GetT2();

			victim.SetProbability(100.0f);
			victim.SetTime(((900000 * skill_t0 + 1800000)));
			victim.SetRatio((skill_t2 * 0.03f + (skill_level * 0.02f)));
			victim.SetBuffid(1);
			victim.SetValue(0.0f);
			victim.SetCibei(true);
			victim.SetProbability(100.0f);
			victim.SetRatio(0.0f);
			victim.SetValue((skill_t1 * ((skill_level * 8.800000000000001f + (skill_level * (skill_level * 2.7f)) + 239.0f) * 0.75f)));
			victim.SetHeal(true);
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={273};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={4};return array[index];
		}
	}
	public class GSkill386 : GSkill
	{
		public GSkill386()
			: base(386)
		{
			
		}
	}
	public class GSkill387Stub : GSkillStub
	{
		public class GState1 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 2400;
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
				int				player_level = player.GetLevel();
				int				skill_level = skill.GetLevel();

				skill.SetRatio((player_level * 0.01f / 7.0f + (skill_level * 0.02f + 1.0f)));
				skill.SetPlus(((skill_level * player_level) + (((30 * skill_level + 120)) - skill_level * (skill_level * 0.26f))));
				player.SetPerform(1);
			}
		}
		public GSkill387Stub()
			: base(387)
		{
			occupation = 130;
			maxlevel = 8;
			maxlearn = 8;
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
			SetAction(0,"青云门_天下无极");
			SetAction(1,"青云门_天下无极");
			SetAction(2,"青云门_天下无极");
			SetAction(3,"青云门_天下无极");
			SetAction(4,"青云门_天下无极");
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
			SetAction(18,"青云门_骑乘_天下无极");
			SetAction(19,"青云门_骑乘_天下无极");
			SetAction(20,"青云门_骑乘_天下无极");
			SetAction(21,"青云门_骑乘_天下无极");
			SetAction(22,"青云门_骑乘_天下无极");
			SetAction(23,"0");
			SetAction(24,"");
			SetAction(25,"");
			SetAction(26,"");
			SetAction(27,"");
			SetAction(28,"");
			SetAction(29,"");
			SetAction(30,"");
			name = "六合护体";
			nativename = "六合护体";
			icon = "六合护体.dds";
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
			return 3000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			return 60000;
		}
		public override float GetRadius(GSkill skill)
		{
			return 13.000000f;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 13.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 7.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return ((29 * skill_level) + (skill_level * (skill_level * 2.1f)) + 293.0f);
		}
		public override int GetCoverage(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return skill_level + 20;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetProbability(50.0f);
			victim.SetTime(4000.0f);
			victim.SetRatio(0.2f);
			victim.SetBuffid(1);
			victim.SetSlow(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();

			victim.SetProbability(120.0f);
			victim.SetTime(6000.0f);
			victim.SetBuffid(4);
			victim.SetValue(((100 * skill_level)));
			victim.SetAdddefence(true);
			return true;
		}
	}
	public class GSkill387 : GSkill
	{
		public GSkill387()
			: base(387)
		{
			
		}
	}
	public class GSkill389Stub : GSkillStub
	{
		public class GState1 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 7000;
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
				return 1000;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();

				player.SetPerform(1);
			}
		}
		public GSkill389Stub()
			: base(389)
		{
			occupation = 129;
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
			SetAction(0,"回城_空");
			SetAction(1,"回城_剑");
			SetAction(2,"回城_轮");
			SetAction(3,"回城_刀");
			SetAction(4,"回城_杖");
			SetAction(5,"回城_爪");
			SetAction(6,"回城_刃");
			SetAction(7,"回城_斧");
			SetAction(8,"回城_弓");
			SetAction(9,"回城_空");
			SetAction(10,"回城_镰");
			SetAction(11,"回城_拳");
			SetAction(12,"回城_琴");
			SetAction(13,"回城_笔");
			SetAction(14,"回城_矛");
			SetAction(15,"回城_铩");
			SetAction(16,"回城_铩");
			SetAction(17,"回城_杖");
			SetAction(18,"回城_骑乘_空");
			SetAction(19,"回城_骑乘_剑");
			SetAction(20,"回城_骑乘_刀");
			SetAction(21,"回城_骑乘_轮");
			SetAction(22,"回城_骑乘_杖");
			SetAction(23,"回城_骑乘_爪");
			SetAction(24,"回城_骑乘_刃");
			SetAction(25,"回城_骑乘_斧");
			SetAction(26,"回城_骑乘_弓");
			SetAction(27,"回城_骑乘_空");
			SetAction(28,"回城_骑乘_镰");
			SetAction(29,"回城_骑乘_拳");
			SetAction(30,"回城_骑乘_琴");
			name = "传送术";
			nativename = "传送术";
			icon = "回城术.dds";
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
			return 8000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			return 3600000;
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
			victim.SetGohome(true);
			return true;
		}
	}
	public class GSkill389 : GSkill
	{
		public GSkill389()
			: base(389)
		{
			
		}
	}
}
