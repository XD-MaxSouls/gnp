using System;
using System.Text;

namespace SKILL
{
	public class GSkill5060Stub : GSkillStub
	{
		public class GState1 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 1225;
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
				return 225;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_maxhp = player.GetMaxhp();

				skill.SetCrit(0.029999999f);
				skill.SetCrithurt(0.30000001f);
				skill.SetRatio(2.3599999f);
				skill.SetPlus((player_maxhp * 0.1f + 850.0f + 87.0f + 36.0f));
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
				return 225;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_maxhp = player.GetMaxhp();

				skill.SetCrit(0.029999999f);
				skill.SetCrithurt(0.30000001f);
				skill.SetRatio(2.3599999f);
				skill.SetPlus((player_maxhp * 0.1f + 850.0f + 87.0f + 36.0f));
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
				return 200;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_maxhp = player.GetMaxhp();

				skill.SetCrit(0.029999999f);
				skill.SetCrithurt(0.30000001f);
				skill.SetRatio(2.3599999f);
				skill.SetPlus((player_maxhp * 0.1f + 850.0f + 87.0f + 36.0f));
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
				return 125;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_maxhp = player.GetMaxhp();

				skill.SetCrit(0.029999999f);
				skill.SetCrithurt(0.30000001f);
				skill.SetRatio(2.3599999f);
				skill.SetPlus((player_maxhp * 0.1f + 850.0f + 87.0f + 36.0f));
				player.SetPerform(0);
			}
		}
		public GSkill5060Stub()
			: base(5060)
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
			SetAction(0,"∫œª∂_∑Áª®—©‘¬");
			SetAction(1,"∫œª∂_∑Áª®—©‘¬");
			SetAction(2,"∫œª∂_∑Áª®—©‘¬");
			SetAction(3,"∫œª∂_∑Áª®—©‘¬");
			SetAction(4,"∫œª∂_∑Áª®—©‘¬");
			SetAction(5,"∫œª∂_∑Áª®—©‘¬");
			SetAction(6,"0");
			SetAction(7,"0");
			SetAction(8,"0");
			SetAction(9,"0");
			SetAction(10,"0");
			SetAction(11,"0");
			SetAction(12,"0");
			SetAction(13,"0");
			SetAction(14,"0");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"∫œª∂_∆Ô≥À_∑Áª®—©‘¬");
			SetAction(19,"∫œª∂_∆Ô≥À_∑Áª®—©‘¬");
			SetAction(20,"∫œª∂_∆Ô≥À_∑Áª®—©‘¬");
			SetAction(21,"∫œª∂_∆Ô≥À_∑Áª®—©‘¬");
			SetAction(22,"∫œª∂_∆Ô≥À_∑Áª®—©‘¬");
			SetAction(23,"∫œª∂_∆Ô≥À_∑Áª®—©‘¬");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "∑Áª®—©‘¬";
			nativename = "∑Áª®—©‘¬";
			icon = "∑Áª®—©‘¬.dds";
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
			return 6400;
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
			return 1.700000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 13.000000f;
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
			int				player_maxmp = player.GetMaxmp();

			victim.SetProbability(((304 * norm(6.0f / (zrand(100) + 0.01f)) + 304)));
			victim.SetTime(9100.0f);
			victim.SetSilent(true);
			victim.SetProbability(((1.0f - player_level * 0.002f) * 100.0f));
			victim.SetTime(120000.0f);
			victim.SetBuffid(1);
			victim.SetAmount((player_maxmp * 0.01f * 60.0f * 3.0f));
			victim.SetValue(0.0f);
			victim.SetMpleak(true);
			victim.SetProbability(33.0f);
			victim.SetTime(12100.0f);
			victim.SetRatio(0.25f);
			victim.SetBuffid(1);
			victim.SetSlow(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_mp = player.GetMp();

			victim.SetProbability(25.0f);
			victim.SetRatio(0.0f);
			victim.SetValue((player_mp * 0.05f));
			victim.SetHeal(true);
			return true;
		}
	}
	public class GSkill5060 : GSkill
	{
		public GSkill5060()
			: base(5060)
		{
			
		}
	}
	public class GSkill5061Stub : GSkillStub
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
		public GSkill5061Stub()
			: base(5061)
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
			SetAction(0,"∫œª∂≈…_œß¥∫");
			SetAction(1,"∫œª∂≈…_œß¥∫");
			SetAction(2,"∫œª∂≈…_œß¥∫");
			SetAction(3,"∫œª∂≈…_œß¥∫");
			SetAction(4,"∫œª∂≈…_œß¥∫");
			SetAction(5,"∫œª∂≈…_œß¥∫");
			SetAction(6,"0");
			SetAction(7,"0");
			SetAction(8,"0");
			SetAction(9,"0");
			SetAction(10,"0");
			SetAction(11,"0");
			SetAction(12,"0");
			SetAction(13,"0");
			SetAction(14,"0");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"∫œª∂≈…_∆Ô≥À_œß¥∫");
			SetAction(19,"∫œª∂≈…_∆Ô≥À_œß¥∫");
			SetAction(20,"∫œª∂≈…_∆Ô≥À_œß¥∫");
			SetAction(21,"∫œª∂≈…_∆Ô≥À_œß¥∫");
			SetAction(22,"∫œª∂≈…_∆Ô≥À_œß¥∫");
			SetAction(23,"∫œª∂≈…_∆Ô≥À_œß¥∫");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "œß¥∫";
			nativename = "œß¥∫";
			icon = "œß¥∫.dds";
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
			return 136800;
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

			victim.SetTime(10500.0f);
			victim.SetValue(16.0f);
			victim.SetBlessed(true);
			victim.SetProbability(100.0f);
			victim.SetBuffid(2);
			victim.SetAmount(99.0f);
			victim.SetValue(99.0f);
			victim.SetExorcism(true);
			victim.SetProbability(90.0f);
			victim.SetClearslow(true);
			victim.SetProbability(120.0f);
			victim.SetTime(10500.0f);
			victim.SetRatio(1.0f);
			victim.SetAmount(30.0f);
			victim.SetValue((player_maxhp * 0.3f));
			victim.SetHpregain(true);
			return true;
		}
	}
	public class GSkill5061 : GSkill
	{
		public GSkill5061()
			: base(5061)
		{
			
		}
	}
	public class GSkill5062Stub : GSkillStub
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
				int				player_hp = player.GetHp();
				int				player_maxhp = player.GetMaxhp();

				player.SetVar1((int)((1000 * player_hp) / player_maxhp));
				player.SetPerform(1);
			}
		}
		public GSkill5062Stub()
			: base(5062)
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
			SetAction(15,"");
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
			name = "∆Ì∏£";
			nativename = "∆Ì∏£";
			icon = "∆Ì∏£.dds";
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
			return 136800;
		}
		public override int GetEnmity(GSkill skill)
		{
			return 1;
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
			return 266.856995f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_level = player.GetLevel();
			int				player_maxhp = player.GetMaxhp();
			int				player_maxmp = player.GetMaxmp();
			int				player_var1 = player.GetVar1();

			/*
			victim.SetTime(41700.0f);
			victim.SetRatio(((D2INT(zrand(100) / 82) + 1) * 3.93f));
			victim.SetBuffid(1);
			victim.SetInchp2(true);
			victim.SetTime(((4500000 * norm(player.GetSkilllevel(740) / 1.5f) * norm(player.GetSkilllevel(305)))));
			victim.SetBuffid(4);
			victim.SetValue(((player_maxmp * 0.4f + (player_level * 1.6f)) * 2.05f));
			victim.SetAddhp(true);
			if ( player_var1 <= 950 )
			v30 = 0.0f;
			else
			victim.SetProbability(((120 * norm(2.0f))));
			victim.SetRatio(0.0f);
			victim.SetValue(player_maxhp);
			victim.SetHeal(true);
			*/
			return true;
		}
	}
	public class GSkill5062 : GSkill
	{
		public GSkill5062()
			: base(5062)
		{
			
		}
	}
	public class GSkill5063Stub : GSkillStub
	{
		public class GState1 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 125;
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
				return 100;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_level = player.GetLevel();

				player.SetVar1(1);
				skill.SetRatio(1.5700001f);
				skill.SetPlus((player_level * 0.15f * 3.0f * 3.0f + 720.0f + 90.0f + 45.0f));
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
				return 1150;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_level = player.GetLevel();

				player.SetVar1(0);
				skill.SetRatio(1.5700001f);
				skill.SetPlus((player_level * 0.15f * 3.0f * 3.0f + 720.0f + 90.0f + 45.0f));
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
				return 1625;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_level = player.GetLevel();

				player.SetVar1(0);
				skill.SetCrit(0.1f);
				skill.SetRatio(1.5700001f);
				skill.SetPlus((player_level * 0.15f * 3.0f * 3.0f + 720.0f + 90.0f + 45.0f));
				player.SetPerform(0);
			}
		}
		public GSkill5063Stub()
			: base(5063)
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
			SetAction(0,"ÃÏ“ÙÀ¬_Œﬁ¡ø’Ê—‘");
			SetAction(1,"ÃÏ“ÙÀ¬_Œﬁ¡ø’Ê—‘");
			SetAction(2,"ÃÏ“ÙÀ¬_Œﬁ¡ø’Ê—‘");
			SetAction(3,"ÃÏ“ÙÀ¬_Œﬁ¡ø’Ê—‘");
			SetAction(4,"ÃÏ“ÙÀ¬_Œﬁ¡ø’Ê—‘");
			SetAction(5,"ÃÏ“ÙÀ¬_Œﬁ¡ø’Ê—‘");
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
			SetAction(18,"ÃÏ“ÙÀ¬_∆Ô≥À_Œﬁ¡ø’Ê—‘");
			SetAction(19,"ÃÏ“ÙÀ¬_∆Ô≥À_Œﬁ¡ø’Ê—‘");
			SetAction(20,"ÃÏ“ÙÀ¬_∆Ô≥À_Œﬁ¡ø’Ê—‘");
			SetAction(21,"ÃÏ“ÙÀ¬_∆Ô≥À_Œﬁ¡ø’Ê—‘");
			SetAction(22,"ÃÏ“ÙÀ¬_∆Ô≥À_Œﬁ¡ø’Ê—‘");
			SetAction(23,"ÃÏ“ÙÀ¬_∆Ô≥À_Œﬁ¡ø’Ê—‘");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "Œﬁ¡ø’Ê—‘";
			nativename = "Œﬁ¡ø’Ê—‘";
			icon = "Œﬁ¡ø’Ê—‘.dds";
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
			return 3000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			return 8250;
		}
		public override int GetEnmity(GSkill skill)
		{
			return 1;
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
			return 10.700000f;
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
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_var1 = player.GetVar1();

			/*
			victim.SetTime(4900.0f);
			if ( player.GetSaint() <= 9.0f )
			{
			d = 0.69999999f;
			}
			else
			{
			if ( 0.72f - player.GetSaint() * 0.002f <= 0.1f )
			{
			v26 = 0.1f;
			}
			else
			{
			v26 = 0.72f - player.GetSaint() * 0.002f;
			}
			d = v26;
			}
			victim.SetRatio(d);
			victim.SetBuffid(1);
			victim.SetDecanti(true);
			victim.SetProbability(279.0f);
			victim.SetTime(15100.0f);
			victim.SetValue(0.0f);
			victim.SetSleep(true);
			victim.SetProbability(-1.0f);
			victim.SetRatio(0.30000001f);
			victim.SetDrainmagic(true);
			if ( player_var1 != 1
			|| (v17 = player, GNET::PlayerWrapper::GetHasbuff(v17, 4097) != 1) )
			v25 = 0.0f;
			else
			victim.SetProbability(100.0f);
			victim.SetTime(15000.0f);
			victim.SetBuffid(1);
			victim.SetAmount(40000.0f);
			victim.SetValue(0.0f);
			victim.SetHpleak(true);
			*/
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_var1 = player.GetVar1();

			/*
			victim.SetTime(12700.0f);
			victim.SetRatio(0.15000001f);
			victim.SetBuffid(1);
			victim.SetIncanti(true);
			if ( player_var1 == 1 )
			d = 120.0f;
			else
			victim.SetProbability(0.0f);
			victim.SetTime(8050.0f);
			victim.SetRatio(3026.0f);
			victim.SetAmount(3074.0f);
			victim.SetValue(3122.0f);
			victim.SetSetcooldown(true);
			*/
			return true;
		}
		public override float GetDropRate(GSkill skill)
		{
			return 0.500000f;
		}
	}
	public class GSkill5063 : GSkill
	{
		public GSkill5063()
			: base(5063)
		{
			
		}
	}
	public class GSkill5064Stub : GSkillStub
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

				skill.SetRatio(1.33f);
				skill.SetPlus(((1003 * D2INT(zrand(120) / 100) + 1003)));
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

				skill.SetRatio(1.33f);
				skill.SetPlus(((1003 * D2INT(zrand(120) / 100) + 1003)));
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

				skill.SetRatio(1.33f);
				skill.SetPlus(((1003 * D2INT(zrand(120) / 100) + 1003)));
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

				skill.SetRatio(1.33f);
				skill.SetPlus(((1003 * D2INT(zrand(120) / 100) + 1003)));
				player.SetPerform(0);
			}
		}
		public GSkill5064Stub()
			: base(5064)
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
			SetAction(0,"ÃÏ“ÙÀ¬_¿◊“Ù∑®⁄Õ");
			SetAction(1,"ÃÏ“ÙÀ¬_¿◊“Ù∑®⁄Õ");
			SetAction(2,"ÃÏ“ÙÀ¬_¿◊“Ù∑®⁄Õ");
			SetAction(3,"ÃÏ“ÙÀ¬_¿◊“Ù∑®⁄Õ");
			SetAction(4,"ÃÏ“ÙÀ¬_¿◊“Ù∑®⁄Õ");
			SetAction(5,"ÃÏ“ÙÀ¬_¿◊“Ù∑®⁄Õ");
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
			SetAction(18,"ÃÏ“ÙÀ¬_∆Ô≥À_¿◊“Ù∑®⁄Õ");
			SetAction(19,"ÃÏ“ÙÀ¬_∆Ô≥À_¿◊“Ù∑®⁄Õ");
			SetAction(20,"ÃÏ“ÙÀ¬_∆Ô≥À_¿◊“Ù∑®⁄Õ");
			SetAction(21,"ÃÏ“ÙÀ¬_∆Ô≥À_¿◊“Ù∑®⁄Õ");
			SetAction(22,"ÃÏ“ÙÀ¬_∆Ô≥À_¿◊“Ù∑®⁄Õ");
			SetAction(23,"ÃÏ“ÙÀ¬_∆Ô≥À_¿◊“Ù∑®⁄Õ");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "¿◊“Ù∑®⁄Õ";
			nativename = "¿◊“Ù∑®⁄Õ";
			icon = "¿◊“Ù∑®⁄Õ.dds";
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
			return 6400;
		}
		public override int GetEnmity(GSkill skill)
		{
			return 1;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 25.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 19.700001f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 28.600000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			return 1000.000000f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_level = player.GetLevel();

			victim.SetProbability(((1.0f - player_level * 0.002f) * 100.0f));
			victim.SetTime(24000.0f);
			victim.SetBuffid(1);
			victim.SetAmount(3720.0f);
			victim.SetValue(0.0f);
			victim.SetHpleak(true);
			victim.SetProbability(18.0f);
			victim.SetTime(12150.0f);
			victim.SetRatio(0.090000004f);
			victim.SetBuffid(1);
			victim.SetDecdefence(true);
			victim.SetProbability(100.0f);
			victim.SetTime(24000.0f);
			victim.SetBuffid(1);
			victim.SetValue(15.0f);
			victim.SetSubanti(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetValue(768.0f);
			victim.SetJuqi(true);
			return true;
		}
	}
	public class GSkill5064 : GSkill
	{
		public GSkill5064()
			: base(5064)
		{
			
		}
	}
	public class GSkill5065Stub : GSkillStub
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
		public GSkill5065Stub()
			: base(5065)
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
			SetAction(15,"");
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
			name = "¥ÛËÛ∞„»Ù";
			nativename = "¥ÛËÛ∞„»Ù";
			icon = "¥Û∑≤∞„»Ù.dds";
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
			int				player_maxhp = player.GetMaxhp();

			victim.SetProbability(100.0f);
			victim.SetTime(26100.0f);
			victim.SetRatio(0.20999999f);
			victim.SetBuffid(1);
			victim.SetAmount(0.0f);
			victim.SetValue((player_maxhp * 0.15f * 10.0f * 1.6f * 1.3f));
			victim.SetBanruo(true);
			victim.SetTime(8100.0f);
			victim.SetInvincible(true);
			victim.SetTime(20000.0f);
			victim.SetRatio(0.2f);
			victim.SetBuffid(1);
			victim.SetIncanti(true);
			return true;
		}
	}
	public class GSkill5065 : GSkill
	{
		public GSkill5065()
			: base(5065)
		{
			
		}
	}
	public class GSkill5066Stub : GSkillStub
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
		public GSkill5066Stub()
			: base(5066)
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
			SetAction(0,"ÃÏ“ÙÀ¬_ÕÚœÛ…˙∑");
			SetAction(1,"ÃÏ“ÙÀ¬_ÕÚœÛ…˙∑");
			SetAction(2,"ÃÏ“ÙÀ¬_ÕÚœÛ…˙∑");
			SetAction(3,"ÃÏ“ÙÀ¬_ÕÚœÛ…˙∑");
			SetAction(4,"ÃÏ“ÙÀ¬_ÕÚœÛ…˙∑");
			SetAction(5,"ÃÏ“ÙÀ¬_ÕÚœÛ…˙∑");
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
			SetAction(18,"ÃÏ“ÙÀ¬_∆Ô≥À_ÕÚœÛ…˙∑");
			SetAction(19,"ÃÏ“ÙÀ¬_∆Ô≥À_ÕÚœÛ…˙∑");
			SetAction(20,"ÃÏ“ÙÀ¬_∆Ô≥À_ÕÚœÛ…˙∑");
			SetAction(21,"ÃÏ“ÙÀ¬_∆Ô≥À_ÕÚœÛ…˙∑");
			SetAction(22,"ÃÏ“ÙÀ¬_∆Ô≥À_ÕÚœÛ…˙∑");
			SetAction(23,"ÃÏ“ÙÀ¬_∆Ô≥À_ÕÚœÛ…˙∑");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "ÕÚœÛ…˙∑";
			nativename = "ÕÚœÛ…˙∑";
			icon = "ÕÚœÛ…˙∑.dds";
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
			return 45000;
		}
		public override float GetRadius(GSkill skill)
		{
			return 30.000000f;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 15.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 12.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			return 4500.000000f;
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

			victim.SetProbability(100.0f);
			victim.SetRatio(0.0f);
			victim.SetValue(player_maxhp);
			victim.SetHeal(true);
			victim.SetProbability(80.0f);
			victim.SetAmount(20.0f);
			victim.SetCleardebuff(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetProbability(100.0f);
			victim.SetTime(((900000 * norm(3))));
			victim.SetRatio(0.0f);
			victim.SetBuffid(5);
			victim.SetValue(1200.0f);
			victim.SetTiangu(true);
			return true;
		}
	}
	public class GSkill5066 : GSkill
	{
		public GSkill5066()
			: base(5066)
		{
			
		}
	}
	public class GSkill5067Stub : GSkillStub
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

				player.SetPerform(1);
			}
		}
		public GSkill5067Stub()
			: base(5067)
		{
			occupation = 128;
			maxlevel = 1;
			maxlearn = 1;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 2;
			timetype = 1;
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
			SetAction(0,"±‰…Ì");
			SetAction(1,"±‰…Ì");
			SetAction(2,"±‰…Ì");
			SetAction(3,"±‰…Ì");
			SetAction(4,"±‰…Ì");
			SetAction(5,"±‰…Ì");
			SetAction(6,"0");
			SetAction(7,"0");
			SetAction(8,"0");
			SetAction(9,"0");
			SetAction(10,"0");
			SetAction(11,"0");
			SetAction(12,"0");
			SetAction(13,"0");
			SetAction(14,"0");
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
			name = "ƒßªÍ◊ÀÃ¨";
			nativename = "ƒßªÍ◊ÀÃ¨";
			icon = "ƒßªÍ–ŒÃ¨.dds";
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
		}
		public override int GetExecutetime(GSkill skill)
		{
			return 10;
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

			victim.SetProbability(13689.0f);
			victim.SetRatio(135.0f);
			victim.SetBuffid(0);
			victim.SetAmount(6.0f);
			victim.SetValue(135.0f);
			victim.SetGhostform(true);
			victim.SetProbability(120.0f);
			victim.SetTime(12000.0f);
			victim.SetRatio(0.30000001f);
			victim.SetNingjin(true);
			victim.SetProbability(100.0f);
			victim.SetTime(60000.0f);
			victim.SetRatio(0.2f);
			victim.SetAttack2hp(true);
			return true;
		}
	}
	public class GSkill5067 : GSkill
	{
		public GSkill5067()
			: base(5067)
		{
			
		}
	}
	public class GSkill5068Stub : GSkillStub
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

				player.SetPerform(1);
			}
		}
		public GSkill5068Stub()
			: base(5068)
		{
			occupation = 128;
			maxlevel = 9;
			maxlearn = 9;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 2;
			timetype = 1;
			targettype = 0;
			rangetype = 5;
			doenchant = true;
			dobless = false;
			autoattack = false;
			allowform = 5;
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
			SetAction(0,"±‰…Ì");
			SetAction(1,"±‰…Ì");
			SetAction(2,"±‰…Ì");
			SetAction(3,"±‰…Ì");
			SetAction(4,"±‰…Ì");
			SetAction(5,"±‰…Ì");
			SetAction(6,"0");
			SetAction(7,"0");
			SetAction(8,"0");
			SetAction(9,"0");
			SetAction(10,"0");
			SetAction(11,"0");
			SetAction(12,"0");
			SetAction(13,"0");
			SetAction(14,"0");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"±‰…Ì");
			SetAction(19,"±‰…Ì");
			SetAction(20,"±‰…Ì");
			SetAction(21,"±‰…Ì");
			SetAction(22,"±‰…Ì");
			SetAction(23,"±‰…Ì");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "π∆Õı◊ÀÃ¨";
			nativename = "π∆Õı◊ÀÃ¨";
			icon = "π∆Õı–ŒÃ¨.dds";
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
		}
		public override int GetExecutetime(GSkill skill)
		{
			return 10;
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

			victim.SetProbability(0.0f);
			victim.SetRatio(-225.0f);
			victim.SetBuffid(16128);
			victim.SetAmount(70.0f);
			victim.SetValue(315.0f);
			victim.SetInsanityform(true);
			victim.SetProbability(120.0f);
			victim.SetTime(((4000 * norm(2))));
			victim.SetRatio(0.5f);
			victim.SetAmount(0.0f);
			victim.SetValue(100.0f);
			victim.SetRetort(true);
			victim.SetProbability(100.0f);
			victim.SetTime(60000.0f);
			victim.SetRatio(0.2f);
			victim.SetAttack2mp(true);
			return true;
		}
	}
	public class GSkill5068 : GSkill
	{
		public GSkill5068()
			: base(5068)
		{
			
		}
	}
	public class GSkill5069Stub : GSkillStub
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

				skill.SetRatio((norm(zrand(115) / 100) * 0.18f + 1.24f));
				skill.SetCrit(0.029999999f);
				skill.SetCrithurt(0.89999998f);
				skill.SetPlus(1122.0f);
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

				skill.SetRatio((norm(zrand(115) / 100) * 0.18f + 1.24f));
				skill.SetCrit(0.029999999f);
				skill.SetCrithurt(0.89999998f);
				skill.SetPlus(1122.0f);
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
				int				player_level = player.GetLevel();

				skill.SetRatio((norm(zrand(115) / 100) * 0.18f + ((3 * norm(zrand(108) / 100.0f)) + 1.06f + 0.18f)));
				skill.SetCrit(0.029999999f);
				skill.SetCrithurt(0.89999998f);
				skill.SetPlus(((12 * player_level + 1122)));
				player.SetPerform(0);
			}
		}
		public GSkill5069Stub()
			: base(5069)
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
			SetAction(0,"πÌµ¿_√ªÍøÒÏ≠");
			SetAction(1,"πÌµ¿_√ªÍøÒÏ≠");
			SetAction(2,"πÌµ¿_√ªÍøÒÏ≠");
			SetAction(3,"πÌµ¿_√ªÍøÒÏ≠");
			SetAction(4,"πÌµ¿_√ªÍøÒÏ≠");
			SetAction(5,"πÌµ¿_√ªÍøÒÏ≠");
			SetAction(6,"0");
			SetAction(7,"0");
			SetAction(8,"0");
			SetAction(9,"0");
			SetAction(10,"0");
			SetAction(11,"0");
			SetAction(12,"0");
			SetAction(13,"0");
			SetAction(14,"0");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"πÌµ¿_∆Ô≥À_√ªÍøÒÏ≠");
			SetAction(19,"πÌµ¿_∆Ô≥À_√ªÍøÒÏ≠");
			SetAction(20,"πÌµ¿_∆Ô≥À_√ªÍøÒÏ≠");
			SetAction(21,"πÌµ¿_∆Ô≥À_√ªÍøÒÏ≠");
			SetAction(22,"πÌµ¿_∆Ô≥À_√ªÍøÒÏ≠");
			SetAction(23,"πÌµ¿_∆Ô≥À_√ªÍøÒÏ≠");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "√ªÍøÒÏ≠";
			nativename = "√ªÍøÒÏ≠";
			icon = "√ªÍøÒÏ≠.dds";
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
			return 10.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			return 1000.000000f;
		}
		public override int GetCoverage(GSkill skill)
		{
			return 35;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_level = player.GetLevel();

			victim.SetProbability(((1.0f - player_level * 0.002f) * 100.0f));
			victim.SetRatio(0.18000001f);
			victim.SetDrainmagic(true);
			victim.SetProbability(302.0f);
			victim.SetTime(12100.0f);
			victim.SetRatio(0.15000001f);
			victim.SetBuffid(1);
			victim.SetWeak(true);
			victim.SetProbability(((600 * norm((zrand(100) / 94)))));
			victim.SetTime(6150.0f);
			victim.SetDizzy(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetProbability(100.0f);
			victim.SetTime(6100.0f);
			victim.SetBuffid(1);
			victim.SetValue(90.0f);
			victim.SetAdddodge(true);
			return true;
		}
		public override float GetDropRate(GSkill skill)
		{
			return 0.500000f;
		}
	}
	public class GSkill5069 : GSkill
	{
		public GSkill5069()
			: base(5069)
		{
			
		}
	}
}
