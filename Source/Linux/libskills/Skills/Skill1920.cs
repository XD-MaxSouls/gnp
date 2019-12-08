using System;
using System.Text;

namespace SKILL
{
	public class GSkill1920Stub : GSkillStub
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
		public GSkill1920Stub()
			: base(1920)
		{
			occupation = 43;
			maxlevel = 3;
			maxlearn = 2;
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
			SetAction(0,"∫¸—˝_¥ÛÙ‡Õı");
			SetAction(1,"0");
			SetAction(2,"0");
			SetAction(3,"0");
			SetAction(4,"0");
			SetAction(5,"0");
			SetAction(6,"0");
			SetAction(7,"0");
			SetAction(8,"∫¸—˝_¥ÛÙ‡Õı");
			SetAction(9,"0");
			SetAction(10,"0");
			SetAction(11,"0");
			SetAction(12,"0");
			SetAction(13,"0");
			SetAction(14,"0");
			SetAction(15,"0");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"∫¸—˝_∆Ô≥À_¥ÛÙ‡Õı");
			SetAction(19,"0");
			SetAction(20,"0");
			SetAction(21,"0");
			SetAction(22,"0");
			SetAction(23,"0");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"∫¸—˝_∆Ô≥À_¥ÛÙ‡Õı");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "¥ÛÙ‡Õı";
			nativename = "¥ÛÙ‡Õı";
			icon = "¥ÛÙ‡Õı.dds";
			SetTalent(0,2135);
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
			skill_class = 6;
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
			int				skill_t0 = skill.GetT0();

			return 120000 - 20000 * skill_t0;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={136,140};return array[level-1];
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
			return 1680.000000f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();

			victim.SetProbability(120.0f);
			victim.SetTime(((6000 * skill_level + 6000)));
			victim.SetRatio((skill_level * 0.25f));
			victim.SetBuffid(1);
			victim.SetIncskillaccu(true);
			victim.SetTime(((6000 * skill_level + 6000)));
			victim.SetRatio((skill_level * 0.1f));
			victim.SetInccritrate(true);
			victim.SetTime(((6000 * skill_level + 6000)));
			victim.SetRatio((skill_level * 0.25f));
			victim.SetBuffid(1);
			victim.SetIncskilldamage(true);
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={1919};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={1};return array[index];
		}
	}
	public class GSkill1920 : GSkill
	{
		public GSkill1920()
			: base(1920)
		{
			
		}
	}
	public class GSkill1921Stub : GSkillStub
	{
		public class GState1 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 667;
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
				return 2000;
			}
			public override void Calculate(GSkill skill)
			{
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
				return 333;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				skill_level = skill.GetLevel();
				int				skill_t2 = skill.GetT2();
				int				skill_t3 = skill.GetT3();
				int				skill_t4 = skill.GetT4();
				int				skill_charging = skill.GetCharging();

				/*
				  if ( skill_charging <= 0xFA )
				  {
				    skill.SetCrithurt(0.0f);
				  }
				  else
				  {
				skill.SetCrithurt((skill_level * 0.1f * (skill_charging * 0.0005f)));
				  }
				  if ( skill_charging <= 0xFA )
				  {
				    skill.SetCrit(0.0f);
				  }
				  else
				  {
				skill.SetCrit((skill_level * 0.01f * (skill_charging * 0.0005f)));
				  }
				  v13 = (0.02f * skill_level) + 1.02f;
				if ( skill_t2 < skill_t3 )
				  {
				if ( skill_t3 < skill_t4 )
				      v14 = skill_t4 * 0.02f + v13;
				    else
				      v14 = skill_t3 * 0.02f + v13;
				  }
				  else
				  {
				if ( skill_t2 < skill_t4 )
				      v14 = skill_t4 * 0.02f + v13;
				    else
				      v14 = skill_t2 * 0.02f + v13;
				  }
				  if ( skill_charging <= 0xFA )
				  {
				    v12 = v14 + 0.0f;
				  }
				  else
				  {
				v12 = (skill_level * 0.1f + 0.5f) * (skill_charging * 0.0005f) + v14;
				  }
				skill.SetRatio(v12);
				skill.SetPlus(834.0f);
				player.SetPerform(1);
				*/
			}
		}
		public GSkill1921Stub()
			: base(1921)
		{
			occupation = 43;
			maxlevel = 6;
			maxlearn = 5;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 1;
			timetype = 3;
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
			weapon_limit = 8;
			SetAction(0,"∫¸—˝_¬÷ªÿ…¡");
			SetAction(1,"0");
			SetAction(2,"0");
			SetAction(3,"0");
			SetAction(4,"0");
			SetAction(5,"0");
			SetAction(6,"0");
			SetAction(7,"0");
			SetAction(8,"∫¸—˝_¬÷ªÿ…¡");
			SetAction(9,"0");
			SetAction(10,"0");
			SetAction(11,"0");
			SetAction(12,"0");
			SetAction(13,"");
			SetAction(14,"");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"∫¸—˝_∆Ô≥À_¬÷ªÿ…¡");
			SetAction(19,"0");
			SetAction(20,"0");
			SetAction(21,"0");
			SetAction(22,"0");
			SetAction(23,"0");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"∫¸—˝_∆Ô≥À_¬÷ªÿ…¡");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "¬÷ªÿ…¡";
			nativename = "¬÷ªÿ…¡";
			icon = "¬÷ªÿ…¡.dds";
			SetTalent(0,2153);
			SetTalent(1,2158);
			SetTalent(2,2947);
			SetTalent(3,4112);
			SetTalent(4,4530);
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
			skill_class = 6;
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
			return 3000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			int				skill_t0 = skill.GetT0();

			return 40000 - 5000 * skill_t0;
		}
		public override int GetEnmity(GSkill skill)
		{
			return 1;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={140,141,141,141,141};return array[level-1];
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 30.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 25.000000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 40.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			return 866.000000f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_level = player.GetLevel();
			int				player_hp = player.GetHp();
			int				player_maxhp = player.GetMaxhp();
			int				player_mp = player.GetMp();
			int				player_maxmp = player.GetMaxmp();
			int				player_reborncount = player.GetReborncount();
			int				skill_level = skill.GetLevel();
			int				skill_t1 = skill.GetT1();
			int				skill_t2 = skill.GetT2();
			int				skill_t3 = skill.GetT3();
			int				skill_t4 = skill.GetT4();

			/*
			victim.SetProbability(((10 * skill_level + 20)));
			victim.SetTime(((2000 * skill_t1 + 6000)));
			victim.SetBuffid(1);
			victim.SetAmount((((50 * player_reborncount + 50) * player_level)));
			v58 = (player_maxhp - player_hp);
			v56 = player_maxhp;
			if ( skill_t2 < skill_t3 )
			{
			if ( skill_t3 < skill_t4 )
			v57 = 0.02f * (v56 * skill_t4);
			else
			v57 = 0.02f * (v56 * skill_t3);
			}
			else
			{
			if ( skill_t2 < skill_t4 )
			v57 = 0.02f * (v56 * skill_t4);
			else
			v57 = 0.02f * (v56 * skill_t2);
			}
			v54 = zrand(100);
			if ( skill_t2 >= skill_t3 )
			{
			if ( skill_t2 < skill_t4 )
			{
			if ( v54 < 5 * skill_t4 )
			goto LABEL_19;
			}
			else if ( v54 < 5 * skill_t2 )
			{
			goto LABEL_19;
			}
			LABEL_18:
			v55 = 0.0f * v57;
			goto LABEL_20;
			}
			if ( skill_t3 >= skill_t4 )
			{
			if ( v54 < 5 * skill_t3 )
			goto LABEL_19;
			goto LABEL_18;
			}
			if ( v54 >= 5 * skill_t4 )
			goto LABEL_18;
			LABEL_19:
			v55 = v57;
			LABEL_20:
			victim.SetValue((v58 + v55));
			victim.SetSubhp(true);
			victim.SetProbability(((10 * skill_level + 20)));
			victim.SetTime(((2000 * skill_t1 + 6000)));
			victim.SetBuffid(1);
			victim.SetAmount((((50 * player_reborncount + 50) * player_level)));
			v53 = (player_maxmp - player_mp);
			v51 = player_maxmp;
			if ( skill_t2 < skill_t3 )
			{
			if ( skill_t3 < skill_t4 )
			v52 = 0.02f * (v51 * skill_t4);
			else
			v52 = 0.02f * (v51 * skill_t3);
			}
			else
			{
			if ( skill_t2 < skill_t4 )
			v52 = 0.02f * (v51 * skill_t4);
			else
			v52 = 0.02f * (v51 * skill_t2);
			}
			v49 = zrand(100);
			if ( skill_t2 < skill_t3 )
			{
			if ( skill_t3 < skill_t4 )
			{
			if ( v49 < 5 * skill_t4 )
			{
			LABEL_38:
			v50 = v52;
			goto LABEL_39;
			}
			}
			else if ( v49 < 5 * skill_t3 )
			{
			goto LABEL_38;
			}
			}
			else
			{
			if ( skill_t2 < skill_t4 )
			{
			if ( v49 < 5 * skill_t4 )
			goto LABEL_38;
			}
			else if ( v49 < 5 * skill_t2 )
			{
			goto LABEL_38;
			}
			}
			v50 = 0.0f * v52;
			LABEL_39:
			victim.SetValue((v53 + v50));
			victim.SetSubmp(true);
			*/
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={1919};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={3};return array[index];
		}
	}
	public class GSkill1921 : GSkill
	{
		public GSkill1921()
			: base(1921)
		{
			
		}
	}
	public class GSkill1922Stub : GSkillStub
	{
		public class GState1 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 1500;
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
		public GSkill1922Stub()
			: base(1922)
		{
			occupation = 43;
			maxlevel = 6;
			maxlearn = 5;
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
			SetAction(0,"∫¸—˝_¡˙–Îª¢");
			SetAction(1,"0");
			SetAction(2,"0");
			SetAction(3,"0");
			SetAction(4,"0");
			SetAction(5,"0");
			SetAction(6,"0");
			SetAction(7,"0");
			SetAction(8,"∫¸—˝_¡˙–Îª¢");
			SetAction(9,"0");
			SetAction(10,"0");
			SetAction(11,"0");
			SetAction(12,"0");
			SetAction(13,"0");
			SetAction(14,"0");
			SetAction(15,"0");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"∫¸—˝_∆Ô≥À_¡˙–Îª¢");
			SetAction(19,"0");
			SetAction(20,"0");
			SetAction(21,"0");
			SetAction(22,"0");
			SetAction(23,"0");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"∫¸—˝_∆Ô≥À_¡˙–Îª¢");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "¡˙–Îª¢";
			nativename = "¡˙–Îª¢";
			icon = "¡˙–Îª¢.dds";
			SetTalent(0,2169);
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
			skill_class = 6;
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
			return 180000;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={136,137,138,139,140};return array[level-1];
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
			return 2000.000000f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_t0 = skill.GetT0();

			victim.SetProbability(120.0f);
			victim.SetTime(((20000 * skill_t0 + 40000)));
			victim.SetRatio(1.0f);
			victim.SetBuffid(1);
			victim.SetAmount(1.0f);
			victim.SetValue(30007.0f);
			victim.SetSummon(true);
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={1919};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={1};return array[index];
		}
	}
	public class GSkill1922 : GSkill
	{
		public GSkill1922()
			: base(1922)
		{
			
		}
	}
	public class GSkill1923Stub : GSkillStub
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
				return 400;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();

				player.SetPerform(1);
			}
			public override bool Cancel(GSkill skill)
			{
				return true;
			}
		}
		public GSkill1923Stub()
			: base(1923)
		{
			occupation = 129;
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
			SetAction(0,"πÌÕı◊⁄_∞¸‘˙");
			SetAction(1,"πÌÕı◊⁄_∞¸‘˙");
			SetAction(2,"πÌÕı◊⁄_∞¸‘˙");
			SetAction(3,"πÌÕı◊⁄_∞¸‘˙");
			SetAction(4,"πÌÕı◊⁄_∞¸‘˙");
			SetAction(5,"πÌÕı◊⁄_∞¸‘˙");
			SetAction(6,"0");
			SetAction(7," ﬁ…Ò_∫·––");
			SetAction(8,"∫¸—˝_∑Á––’ﬂ");
			SetAction(9,"0");
			SetAction(10,"ª≥π‚_«≥œÆ");
			SetAction(11,"0");
			SetAction(12,"ÃÏª™_≥ı‘™“Ù»–");
			SetAction(13,"");
			SetAction(14,"");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"πÌÕı◊⁄_∞¸‘˙");
			SetAction(19,"πÌÕı◊⁄_∞¸‘˙");
			SetAction(20,"πÌÕı◊⁄_∞¸‘˙");
			SetAction(21,"πÌÕı◊⁄_∞¸‘˙");
			SetAction(22,"πÌÕı◊⁄_∞¸‘˙");
			SetAction(23,"πÌÕı◊⁄_∞¸‘˙");
			SetAction(24,"0");
			SetAction(25," ﬁ…Ò_∆Ô≥À_∫·––");
			SetAction(26,"∫¸—˝_∆Ô≥À_∑Á––’ﬂ");
			SetAction(27,"0");
			SetAction(28,"ª≥π‚_∆Ô≥À_«≥œÆ");
			SetAction(29,"0");
			SetAction(30,"ÃÏª™_∆Ô≥À_≥ı‘™“Ù»–");
			name = "Ã«π˚Ã«π˚";
			nativename = "Ã«π˚Ã«π˚";
			icon = "˜»–ƒ.dds";
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
			return 500;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			return 6000;
		}
		public override float GetPraydistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return player_range + 15.0f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return player_range + 3.0f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 25.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			return 100.000000f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();

			/*
			if ( player.GetTmplid() == 23201 )
			d = 1000.0f;
			else
			victim.SetRatio(0.0f);
			victim.SetAmount(0.0f);
			if ( player.GetTmplid() == 23201 )
			v9 = 1.0f;
			else
			victim.SetValue(0.0f);
			victim.SetSecondattack(true);
			*/
			return true;
		}
	}
	public class GSkill1923 : GSkill
	{
		public GSkill1923()
			: base(1923)
		{
			
		}
	}
	public class GSkill1924Stub : GSkillStub
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

				skill.SetRatio(0.0f);
				skill.SetPlus(1.0f);
				player.SetPerform(1);
			}
		}
		public GSkill1924Stub()
			: base(1924)
		{
			occupation = 129;
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
			SetAction(0,"«‡‘∆√≈_ÃÏµÿ≤ª» ");
			SetAction(1,"«‡‘∆√≈_ÃÏµÿ≤ª» ");
			SetAction(2,"«‡‘∆√≈_ÃÏµÿ≤ª» ");
			SetAction(3,"«‡‘∆√≈_ÃÏµÿ≤ª» ");
			SetAction(4,"«‡‘∆√≈_ÃÏµÿ≤ª» ");
			SetAction(5,"«‡‘∆√≈_ÃÏµÿ≤ª» ");
			SetAction(6,"0");
			SetAction(7," ﬁ…Ò_…±¬æ");
			SetAction(8,"∫¸—˝_—£π‚ ∏");
			SetAction(9,"0");
			SetAction(10,"0");
			SetAction(11,"0");
			SetAction(12,"0");
			SetAction(13,"");
			SetAction(14,"");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"«‡‘∆√≈_∆Ô≥À_ÃÏµÿ≤ª» ");
			SetAction(19,"«‡‘∆√≈_∆Ô≥À_ÃÏµÿ≤ª» ");
			SetAction(20,"«‡‘∆√≈_∆Ô≥À_ÃÏµÿ≤ª» ");
			SetAction(21,"«‡‘∆√≈_∆Ô≥À_ÃÏµÿ≤ª» ");
			SetAction(22,"«‡‘∆√≈_∆Ô≥À_ÃÏµÿ≤ª» ");
			SetAction(23,"«‡‘∆√≈_∆Ô≥À_ÃÏµÿ≤ª» ");
			SetAction(24,"0");
			SetAction(25," ﬁ…Ò_∆Ô≥À_…±¬æ");
			SetAction(26,"∫¸—˝_∆Ô≥À_—£π‚ ∏");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "–«∫”º≈√";
			nativename = "–«∫”º≈√";
			icon = "æ€¡È÷‰.dds";
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
			return 500;
		}
		public override float GetPraydistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return player_range + 15.0f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return player_range + 3.0f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 25.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			return 100.000000f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();

			/*
			if ( player.GetTmplid() != 23262
			&& (v3 = player, GNET::PlayerWrapper::GetTmplid(v3) != 23265)
			&& (v4 = player, GNET::PlayerWrapper::GetTmplid(v4) != 23267) )
			d = 0.0f;
			else
			victim.SetRatio(1000.0f);
			victim.SetAmount(0.0f);
			if ( player.GetTmplid() != 23262
			&& (v8 = player, GNET::PlayerWrapper::GetTmplid(v8) != 23265)
			&& (v9 = player, GNET::PlayerWrapper::GetTmplid(v9) != 23267) )
			v13 = 0.0f;
			else
			victim.SetValue(1.0f);
			victim.SetSecondattack(true);
			*/
			return true;
		}
	}
	public class GSkill1924 : GSkill
	{
		public GSkill1924()
			: base(1924)
		{
			
		}
	}
	public class GSkill1925Stub : GSkillStub
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
		public GSkill1925Stub()
			: base(1925)
		{
			occupation = 129;
			maxlevel = 1;
			maxlearn = 1;
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
			SetAction(0,"ªÿ≥«_ø’");
			SetAction(1,"ªÿ≥«_Ω£");
			SetAction(2,"ªÿ≥«_¬÷");
			SetAction(3,"ªÿ≥«_µ∂");
			SetAction(4,"ªÿ≥«_’»");
			SetAction(5,"ªÿ≥«_◊¶");
			SetAction(6,"ªÿ≥«_≥ﬂ");
			SetAction(7,"ªÿ≥«_∏´");
			SetAction(8,"ªÿ≥«_π≠");
			SetAction(9,"ªÿ≥«_“«");
			SetAction(10,"ªÿ≥«_¡≠");
			SetAction(11,"ªÿ≥«_»≠");
			SetAction(12,"ªÿ≥«_«Ÿ");
			SetAction(13,"ªÿ≥«_± ");
			SetAction(14,"ªÿ≥«_√¨");
			SetAction(15,"ªÿ≥«_Ô°");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"ªÿ≥«_∆Ô≥À_ø’");
			SetAction(19,"ªÿ≥«_∆Ô≥À_Ω£");
			SetAction(20,"ªÿ≥«_∆Ô≥À_µ∂");
			SetAction(21,"ªÿ≥«_∆Ô≥À_¬÷");
			SetAction(22,"ªÿ≥«_∆Ô≥À_’»");
			SetAction(23,"ªÿ≥«_∆Ô≥À_◊¶");
			SetAction(24,"ªÿ≥«_∆Ô≥À_≥ﬂ");
			SetAction(25,"ªÿ≥«_∆Ô≥À_∏´");
			SetAction(26,"ªÿ≥«_∆Ô≥À_π≠");
			SetAction(27,"ªÿ≥«_∆Ô≥À_“«");
			SetAction(28,"ªÿ≥«_∆Ô≥À_¡≠");
			SetAction(29,"ªÿ≥«_∆Ô≥À_»≠");
			SetAction(30,"ªÿ≥«_∆Ô≥À_«Ÿ");
			name = "¥´ÀÕ ı";
			nativename = "¥´ÀÕ ı";
			icon = "ªÿ≥« ı.dds";
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
	public class GSkill1925 : GSkill
	{
		public GSkill1925()
			: base(1925)
		{
			
		}
	}
	public class GSkill1926Stub : GSkillStub
	{
		public GSkill1926Stub()
			: base(1926)
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
			name = "”Œ¿÷Buffº”π•ª˜";
			nativename = "”Œ¿÷Buffº”π•ª˜";
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
			int				skill_level = skill.GetLevel();

			victim.SetProbability(100.0f);
			victim.SetTime(7200000.0f);
			victim.SetRatio(0.1f);
			victim.SetBuffid(1);
			victim.SetValue(((2 * skill_level)));
			victim.SetHupo(true);
			return true;
		}
	}
	public class GSkill1926 : GSkill
	{
		public GSkill1926()
			: base(1926)
		{
			
		}
	}
	public class GSkill1927Stub : GSkillStub
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
				int				player_level = player.GetLevel();
				int				player_def = player.GetDef();
				int				skill_level = skill.GetLevel();
				int				skill_t0 = skill.GetT0();
				int				skill_t1 = skill.GetT1();

				skill.SetRatio((D2INT(player_level / (9 - skill_level)) * 0.01f + (skill_level * 0.05f + (skill_t0 * 0.03f + 1.0f))));
				skill.SetPlus((player_def * (skill_t1 * 0.03f) + ((210 * skill_level))));
				player.SetPerform(1);
			}
		}
		public GSkill1927Stub()
			: base(1927)
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
			SetAction(0,"πÌµ¿_∑®±¶_ÀƒœÒ∑À˛");
			SetAction(1,"«‡‘∆√≈_∑®±¶_ÀƒœÒ∑À˛");
			SetAction(2,"πÌÕı◊⁄_∑®±¶_ÀƒœÒ∑À˛");
			SetAction(3,"∫œª∂≈…_∑®±¶_ÀƒœÒ∑À˛");
			SetAction(4,"ÃÏ“ÙÀ¬_∑®±¶_ÀƒœÒ∑À˛");
			SetAction(5,"πÌµ¿_∑®±¶_ÀƒœÒ∑À˛");
			SetAction(6,"∑Ÿœ„π»_∑®±¶_ÀƒœÒ∑À˛");
			SetAction(7," ﬁ…Ò_∑®±¶_ÀƒœÛ∑À˛");
			SetAction(8,"∫¸—˝_∑®±¶_ÀƒœÛ∑À˛");
			SetAction(9,"–˘‘Ø_∑®±¶_ÀƒœÛ∑À˛");
			SetAction(10,"ª≥π‚_∑®±¶_ÀƒœÛ∑À˛");
			SetAction(11,"Ã´Íª_∑®±¶_ÀƒœÛ∑À˛");
			SetAction(12,"ÃÏª™_∑®±¶_ÀƒœÛ∑À˛");
			SetAction(13,"¡ÈŸÌ_∑®±¶_ÀƒœÛ∑À˛");
			SetAction(14,"”¢’–_∑®±¶_ÀƒœÛ∑À˛");
			SetAction(15,"Œ‰∆˜¥Û ¶_∑®±¶_ÀƒœÛ∑À˛");
			SetAction(16,"Œ‰∆˜¥Û ¶_∑®±¶_ÀƒœÛ∑À˛");
			SetAction(17,"ÃÏ“ÙÀ¬_∑®±¶_ÀƒœÒ∑À˛");
			SetAction(18,"πÌµ¿_∆Ô≥À_∑®±¶_ÀƒœÒ∑À˛");
			SetAction(19,"«‡‘∆√≈_∆Ô≥À_∑®±¶_ÀƒœÒ∑À˛");
			SetAction(20,"πÌÕı◊⁄_∆Ô≥À_∑®±¶_ÀƒœÒ∑À˛");
			SetAction(21,"∫œª∂≈…_∆Ô≥À_∑®±¶_ÀƒœÒ∑À˛");
			SetAction(22,"ÃÏ“ÙÀ¬_∆Ô≥À_∑®±¶_ÀƒœÒ∑À˛");
			SetAction(23,"πÌµ¿_∆Ô≥À_∑®±¶_ÀƒœÒ∑À˛");
			SetAction(24,"∑Ÿœ„π»_∆Ô≥À_∑®±¶_ÀƒœÒ∑À˛");
			SetAction(25," ﬁ…Ò_∆Ô≥À_∑®±¶_ÀƒœÛ∑À˛");
			SetAction(26,"∫¸—˝_∆Ô≥À_∑®±¶_ÀƒœÛ∑À˛");
			SetAction(27,"–˘‘Ø_∆Ô≥À_∑®±¶_ÀƒœÛ∑À˛");
			SetAction(28,"ª≥π‚_∆Ô≥À_∑®±¶_ÀƒœÛ∑À˛");
			SetAction(29,"Ã´Íª_∆Ô≥À_∑®±¶_ÀƒœÛ∑À˛");
			SetAction(30,"ÃÏª™_∆Ô≥À_∑®±¶_ÀƒœÛ∑À˛");
			name = " •À˛Ωµƒß";
			nativename = " •À˛Ωµƒß";
			icon = " •À˛Ωµƒß.dds";
			SetTalent(0,687);
			SetTalent(1,1582);
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
		public override int GetCooldowntime(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return 6300 - 300 * skill_level;
		}
		public override int GetEnmity(GSkill skill)
		{
			return 1;
		}
		public override float GetPraydistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return (D2INT((player_range / 13.0f)) * 2.8f + (D2INT(player_range / 8.9f) * 1.8f + ((player_range * 0.5f) - D2INT(player_range / 3.9f) * 0.3f)) + 0.05f + 5.0f);
		}
		public override float GetCastdistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return (D2INT((player_range / 13.0f)) * 2.8f + (D2INT(player_range / 8.9f) * 1.8f + ((player_range * 0.5f) - D2INT(player_range / 3.9f) * 0.3f)) + 0.05f);
		}
		public override float GetEffectdistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return (D2INT((player_range / 13.0f)) * 2.8f + (D2INT(player_range / 8.9f) * 1.8f + ((player_range * 0.5f) - D2INT(player_range / 3.9f) * 0.3f)) + 0.05f + 10.0f);
		}
		public override float GetMpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return ((-30 * skill_level) - skill_level * skill_level + 380);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();

			victim.SetProbability(((600 * norm(zrand(100) / (90 - 10 * skill_level)))));
			victim.SetTime(2200.0f);
			victim.SetDizzy(true);
			victim.SetProbability(-1.0f);
			victim.SetAmount(1.0f);
			victim.SetClearbuff(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();

			victim.SetProbability(((10 * skill_level + 10)));
			victim.SetTime(100.0f);
			victim.SetBuffid(1);
			victim.SetAmount((((-30 * skill_level) - skill_level * skill_level + 380)));
			victim.SetValue(0.0f);
			victim.SetMpgen(true);
			victim.SetProbability(((10 * skill_level + 10)));
			victim.SetAmount(1.0f);
			victim.SetCleardebuff(true);
			return true;
		}
	}
	public class GSkill1927 : GSkill
	{
		public GSkill1927()
			: base(1927)
		{
			
		}
	}
	public class GSkill1928Stub : GSkillStub
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
		public GSkill1928Stub()
			: base(1928)
		{
			occupation = 151;
			maxlevel = 99;
			maxlearn = 5;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 1;
			timetype = 0;
			targettype = 0;
			rangetype = 0;
			doenchant = false;
			dobless = true;
			autoattack = false;
			allowform = 0;
			credittype = 0;
			clearmask = 0;
			skill_limit = 1;
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
			SetAction(0,"πÌÕı◊⁄_«¨¿§’∂");
			SetAction(1,"«‡‘∆√≈_«¨¿§’∂");
			SetAction(2,"πÌÕı◊⁄_«¨¿§’∂");
			SetAction(3,"∫œª∂≈…_«¨¿§’∂");
			SetAction(4,"ÃÏ“ÙÀ¬_«¨¿§’∂");
			SetAction(5,"πÌÕı◊⁄_«¨¿§’∂");
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
			SetAction(18,"πÌÕı◊⁄_∆Ô≥À_«¨¿§’∂");
			SetAction(19,"«‡‘∆√≈_∆Ô≥À_«¨¿§’∂");
			SetAction(20,"πÌÕı◊⁄_∆Ô≥À_«¨¿§’∂");
			SetAction(21,"∫œª∂≈…_∆Ô≥À_«¨¿§’∂");
			SetAction(22,"ÃÏ“ÙÀ¬_∆Ô≥À_«¨¿§’∂");
			SetAction(23,"πÌÕı◊⁄_∆Ô≥À_«¨¿§’∂");
			SetAction(24,"");
			SetAction(25,"");
			SetAction(26,"");
			SetAction(27,"");
			SetAction(28,"");
			SetAction(29,"");
			SetAction(30,"");
			name = "≤‚ ‘ººƒ‹D";
			nativename = "≤‚ ‘ººƒ‹D";
			icon = "≤‚ ‘4.dds";
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
			return 1000;
		}
		public override float GetPraydistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return player_range + 8.0f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return player_range + 5.0f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return player_range + 16.0f;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetProbability(100.0f);
			victim.SetTime(20000.0f);
			victim.SetBuffid(1);
			victim.SetValue(800.0f);
			victim.SetAddattack4(true);
			victim.SetTime(20000.0f);
			victim.SetBuffid(1);
			victim.SetValue(100.0f);
			victim.SetAddanti2(true);
			return true;
		}
	}
	public class GSkill1928 : GSkill
	{
		public GSkill1928()
			: base(1928)
		{
			
		}
	}
	public class GSkill1929Stub : GSkillStub
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
		public GSkill1929Stub()
			: base(1929)
		{
			occupation = 151;
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
			SetAction(0,"πÌÕı◊⁄_«¨¿§’∂");
			SetAction(1,"«‡‘∆√≈_«¨¿§’∂");
			SetAction(2,"πÌÕı◊⁄_«¨¿§’∂");
			SetAction(3,"∫œª∂≈…_«¨¿§’∂");
			SetAction(4,"ÃÏ“ÙÀ¬_«¨¿§’∂");
			SetAction(5,"πÌÕı◊⁄_«¨¿§’∂");
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
			SetAction(18,"πÌÕı◊⁄_∆Ô≥À_«¨¿§’∂");
			SetAction(19,"«‡‘∆√≈_∆Ô≥À_«¨¿§’∂");
			SetAction(20,"πÌÕı◊⁄_∆Ô≥À_«¨¿§’∂");
			SetAction(21,"∫œª∂≈…_∆Ô≥À_«¨¿§’∂");
			SetAction(22,"ÃÏ“ÙÀ¬_∆Ô≥À_«¨¿§’∂");
			SetAction(23,"πÌÕı◊⁄_∆Ô≥À_«¨¿§’∂");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "≤‚ ‘ººƒ‹E";
			nativename = "≤‚ ‘ººƒ‹E";
			icon = "≤‚ ‘5.dds";
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
		public override float GetEffectdistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return player_range + 16.0f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetTime(60000.0f);
			victim.SetValue(600.0f);
			victim.SetRecoverhp(true);
			return true;
		}
	}
	public class GSkill1929 : GSkill
	{
		public GSkill1929()
			: base(1929)
		{
			
		}
	}
}
