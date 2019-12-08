using System;
using System.Text;

namespace SKILL
{
	public class GSkill1660Stub : GSkillStub
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

				skill.SetRatio(1.1f);
				skill.SetCrithurt(3.0f);
				player.SetPerform(1);
			}
		}
		public GSkill1660Stub()
			: base(1660)
		{
			occupation = 146;
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
			SetAction(0,"ÃÏ“ÙÀ¬_¬÷ªÿª√æ≥");
			SetAction(1,"ÃÏ“ÙÀ¬_¬÷ªÿª√æ≥");
			SetAction(2,"ÃÏ“ÙÀ¬_¬÷ªÿª√æ≥");
			SetAction(3,"ÃÏ“ÙÀ¬_¬÷ªÿª√æ≥");
			SetAction(4,"ÃÏ“ÙÀ¬_¬÷ªÿª√æ≥");
			SetAction(5,"ÃÏ“ÙÀ¬_¬÷ªÿª√æ≥");
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
			SetAction(18,"ÃÏ“ÙÀ¬_∆Ô≥À_¬÷ªÿª√æ≥");
			SetAction(19,"ÃÏ“ÙÀ¬_∆Ô≥À_¬÷ªÿª√æ≥");
			SetAction(20,"ÃÏ“ÙÀ¬_∆Ô≥À_¬÷ªÿª√æ≥");
			SetAction(21,"ÃÏ“ÙÀ¬_∆Ô≥À_¬÷ªÿª√æ≥");
			SetAction(22,"ÃÏ“ÙÀ¬_∆Ô≥À_¬÷ªÿª√æ≥");
			SetAction(23,"ÃÏ“ÙÀ¬_∆Ô≥À_¬÷ªÿª√æ≥");
			SetAction(24,"");
			SetAction(25,"");
			SetAction(26,"");
			SetAction(27,"");
			SetAction(28,"");
			SetAction(29,"");
			SetAction(30,"");
			name = "¬÷ªÿª√æ≥£∫√Ó";
			nativename = "¬÷ªÿª√æ≥£∫√Ó";
			icon = "¬÷ªÿª√æ≥.dds";
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
			return 360000;
		}
		public override float GetPraydistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return player_range + 7.0f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return player_range + 2.0f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return player_range + 10.0f;
		}
		public override float GetMpcost(GSkill skill)
		{
			return 990.000000f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_level = player.GetLevel();

			victim.SetProbability(100.0f);
			victim.SetTime(((1000 * zrand(9) * (norm((player_level / 105))) + 8100)));
			victim.SetRatio(0.80000001f);
			victim.SetValue(0.80000001f);
			victim.SetRandcurse(true);
			victim.SetProbability(100.0f);
			victim.SetRatio(0.5f);
			victim.SetDrainmagic(true);
			return true;
		}
	}
	public class GSkill1660 : GSkill
	{
		public GSkill1660()
			: base(1660)
		{
			
		}
	}
	public class GSkill1661Stub : GSkillStub
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
				int				player_hp = player.GetHp();
				int				player_maxhp = player.GetMaxhp();
				int				player_mp = player.GetMp();
				int				player_maxmp = player.GetMaxmp();

				skill.SetCrit(0.079999998f);
				skill.SetSkillaccu(300);
				skill.SetRatio(((2 * (norm(player_hp / player_maxhp)) * norm((player_mp / player_maxmp)) + 1)));
				player.SetPerform(1);
			}
		}
		public GSkill1661Stub()
			: base(1661)
		{
			occupation = 146;
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
			SetAction(0,"ÃÏ“ÙÀ¬_…·…Ì¥Û‘∏");
			SetAction(1,"ÃÏ“ÙÀ¬_…·…Ì¥Û‘∏");
			SetAction(2,"ÃÏ“ÙÀ¬_…·…Ì¥Û‘∏");
			SetAction(3,"ÃÏ“ÙÀ¬_…·…Ì¥Û‘∏");
			SetAction(4,"ÃÏ“ÙÀ¬_…·…Ì¥Û‘∏");
			SetAction(5,"ÃÏ“ÙÀ¬_…·…Ì¥Û‘∏");
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
			SetAction(18,"ÃÏ“ÙÀ¬_∆Ô≥À_…·…Ì¥Û‘∏");
			SetAction(19,"ÃÏ“ÙÀ¬_∆Ô≥À_…·…Ì¥Û‘∏");
			SetAction(20,"ÃÏ“ÙÀ¬_∆Ô≥À_…·…Ì¥Û‘∏");
			SetAction(21,"ÃÏ“ÙÀ¬_∆Ô≥À_…·…Ì¥Û‘∏");
			SetAction(22,"ÃÏ“ÙÀ¬_∆Ô≥À_…·…Ì¥Û‘∏");
			SetAction(23,"ÃÏ“ÙÀ¬_∆Ô≥À_…·…Ì¥Û‘∏");
			SetAction(24,"");
			SetAction(25,"");
			SetAction(26,"");
			SetAction(27,"");
			SetAction(28,"");
			SetAction(29,"");
			SetAction(30,"");
			name = "…·…Ì¥Û‘∏£∫√Ó";
			nativename = "…·…Ì¥Û‘∏£∫√Ó";
			icon = "…·…Ì¥Û‘∏.dds";
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
			return 360000;
		}
		public override float GetPraydistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return player_range + 7.0f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return player_range + 2.0f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return player_range + 9.0f;
		}
		public override float GetMpcost(GSkill skill)
		{
			return 1350.000000f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetProbability(999.0f);
			victim.SetTime(6100.0f);
			victim.SetWrap(true);
			victim.SetProbability(100.0f);
			victim.SetTime(12000.0f);
			victim.SetBuffid(0);
			victim.SetAmount(9000000.0f);
			victim.SetValue(100000.0f);
			victim.SetMpleak(true);
			victim.SetProbability(100.0f);
			victim.SetTime(12100.0f);
			victim.SetRatio(0.99000001f);
			victim.SetBuffid(0);
			victim.SetDecaccuracy(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_level = player.GetLevel();

			victim.SetProbability(100.0f);
			victim.SetTime(12100.0f);
			victim.SetRatio(1.0f);
			victim.SetAmount(12.0f);
			victim.SetValue(player_level);
			victim.SetFrenzied(true);
			return true;
		}
	}
	public class GSkill1661 : GSkill
	{
		public GSkill1661()
			: base(1661)
		{
			
		}
	}
	public class GSkill1662Stub : GSkillStub
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
		public GSkill1662Stub()
			: base(1662)
		{
			occupation = 146;
			maxlevel = 1;
			maxlearn = 1;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 3;
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
			SetAction(0,"∫œª∂≈…_º∏∂‡≥Ó");
			SetAction(1,"∫œª∂≈…_º∏∂‡≥Ó");
			SetAction(2,"∫œª∂≈…_º∏∂‡≥Ó");
			SetAction(3,"∫œª∂≈…_º∏∂‡≥Ó");
			SetAction(4,"∫œª∂≈…_º∏∂‡≥Ó");
			SetAction(5,"∫œª∂≈…_º∏∂‡≥Ó");
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
			SetAction(18,"∫œª∂≈…_∆Ô≥À_º∏∂‡≥Ó");
			SetAction(19,"∫œª∂≈…_∆Ô≥À_º∏∂‡≥Ó");
			SetAction(20,"∫œª∂≈…_∆Ô≥À_º∏∂‡≥Ó");
			SetAction(21,"∫œª∂≈…_∆Ô≥À_º∏∂‡≥Ó");
			SetAction(22,"∫œª∂≈…_∆Ô≥À_º∏∂‡≥Ó");
			SetAction(23,"∫œª∂≈…_∆Ô≥À_º∏∂‡≥Ó");
			SetAction(24,"");
			SetAction(25,"");
			SetAction(26,"");
			SetAction(27,"");
			SetAction(28,"");
			SetAction(29,"");
			SetAction(30,"");
			name = "º∏∂‡≥Ó£∫√Ó";
			nativename = "º∏∂‡≥Ó£∫√Ó";
			icon = "º∏∂‡≥Ó.dds";
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
			return 360000;
		}
		public override float GetRadius(GSkill skill)
		{
			return 25.000000f;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 25.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 10.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			return 950.000000f;
		}
		public override int GetCoverage(GSkill skill)
		{
			return 25;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_level = player.GetLevel();

			victim.SetProbability(((1.0f - player_level * 0.002f) * 100.0f));
			victim.SetTime(12000.0f);
			victim.SetBuffid(0);
			victim.SetAmount(12.0f);
			victim.SetValue(1000000.0f);
			victim.SetMpleak(true);
			victim.SetProbability(((1.0f - player_level * 0.002f) * 100.0f));
			victim.SetRatio(1.0f);
			victim.SetDrainmagic(true);
			victim.SetProbability(100.0f);
			victim.SetTime(12100.0f);
			victim.SetRatio(0.15000001f);
			victim.SetInchurt(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetProbability(50.0f);
			victim.SetTime(60100.0f);
			victim.SetRatio(0.050000001f);
			victim.SetAttack2hp(true);
			victim.SetProbability(50.0f);
			victim.SetTime(60100.0f);
			victim.SetRatio(0.050000001f);
			victim.SetAttack2mp(true);
			return true;
		}
	}
	public class GSkill1662 : GSkill
	{
		public GSkill1662()
			: base(1662)
		{
			
		}
	}
	public class GSkill1663Stub : GSkillStub
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
		public GSkill1663Stub()
			: base(1663)
		{
			occupation = 146;
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
			SetAction(0,"∫œª∂≈…_ÕÌ¿¥«Ô");
			SetAction(1,"∫œª∂≈…_ÕÌ¿¥«Ô");
			SetAction(2,"∫œª∂≈…_ÕÌ¿¥«Ô");
			SetAction(3,"∫œª∂≈…_ÕÌ¿¥«Ô");
			SetAction(4,"∫œª∂≈…_ÕÌ¿¥«Ô");
			SetAction(5,"∫œª∂≈…_ÕÌ¿¥«Ô");
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
			SetAction(18,"∫œª∂≈…_∆Ô≥À_ÕÌ¿¥«Ô");
			SetAction(19,"∫œª∂≈…_∆Ô≥À_ÕÌ¿¥«Ô");
			SetAction(20,"∫œª∂≈…_∆Ô≥À_ÕÌ¿¥«Ô");
			SetAction(21,"∫œª∂≈…_∆Ô≥À_ÕÌ¿¥«Ô");
			SetAction(22,"∫œª∂≈…_∆Ô≥À_ÕÌ¿¥«Ô");
			SetAction(23,"∫œª∂≈…_∆Ô≥À_ÕÌ¿¥«Ô");
			SetAction(24,"");
			SetAction(25,"");
			SetAction(26,"");
			SetAction(27,"");
			SetAction(28,"");
			SetAction(29,"");
			SetAction(30,"");
			name = "ÕÌ¿¥«Ô£∫√Ó";
			nativename = "ÕÌ¿¥«Ô£∫√Ó";
			icon = "ÕÌ¿¥«Ô.dds";
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
			return 360000;
		}
		public override float GetRadius(GSkill skill)
		{
			return 25.000000f;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 25.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 10.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			return 1100.000000f;
		}
		public override int GetCoverage(GSkill skill)
		{
			return 15;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_mp = player.GetMp();

			victim.SetProbability(120.0f);
			victim.SetTime(8100.0f);
			victim.SetRatio(0.33000001f);
			victim.SetNingjin(true);
			victim.SetProbability(100.0f);
			victim.SetTime(30100.0f);
			victim.SetBuffid(0);
			victim.SetValue((player_mp * 0.01f));
			victim.SetAddattack(true);
			victim.SetProbability(100.0f);
			victim.SetClearsilent(true);
			victim.SetTime(10000.0f);
			victim.SetImmunesilent(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_res1 = player.GetRes1();
			int				player_res2 = player.GetRes2();
			int				player_res3 = player.GetRes3();
			int				player_res4 = player.GetRes4();
			int				player_res5 = player.GetRes5();

			victim.SetProbability(100.0f);
			victim.SetTime(16100.0f);
			victim.SetBuffid(2);
			victim.SetValue(((player_res5 + (player_res4 + (player_res3 + (player_res2 + player_res1)))) * 0.33f));
			victim.SetAddattack(true);
			return true;
		}
	}
	public class GSkill1663 : GSkill
	{
		public GSkill1663()
			: base(1663)
		{
			
		}
	}
	public class GSkill1664Stub : GSkillStub
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

				skill.SetRatio(1.1f);
				player.SetPerform(1);
			}
		}
		public GSkill1664Stub()
			: base(1664)
		{
			occupation = 146;
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
			SetAction(0,"∫œª∂≈…_‘Ÿªÿ ◊");
			SetAction(1,"∫œª∂≈…_‘Ÿªÿ ◊");
			SetAction(2,"∫œª∂≈…_‘Ÿªÿ ◊");
			SetAction(3,"∫œª∂≈…_‘Ÿªÿ ◊");
			SetAction(4,"∫œª∂≈…_‘Ÿªÿ ◊");
			SetAction(5,"∫œª∂≈…_‘Ÿªÿ ◊");
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
			SetAction(18,"∫œª∂≈…_∆Ô≥À_‘Ÿªÿ ◊");
			SetAction(19,"∫œª∂≈…_∆Ô≥À_‘Ÿªÿ ◊");
			SetAction(20,"∫œª∂≈…_∆Ô≥À_‘Ÿªÿ ◊");
			SetAction(21,"∫œª∂≈…_∆Ô≥À_‘Ÿªÿ ◊");
			SetAction(22,"∫œª∂≈…_∆Ô≥À_‘Ÿªÿ ◊");
			SetAction(23,"∫œª∂≈…_∆Ô≥À_‘Ÿªÿ ◊");
			SetAction(24,"");
			SetAction(25,"");
			SetAction(26,"");
			SetAction(27,"");
			SetAction(28,"");
			SetAction(29,"");
			SetAction(30,"");
			name = "‘Ÿªÿ ◊£∫√Ó";
			nativename = "‘Ÿªÿ ◊£∫√Ó";
			icon = "‘Ÿªÿ ◊.dds";
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
			return 360000;
		}
		public override float GetPraydistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return player_range + 4.0f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return player_range + 2.0f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return player_range + 6.0f;
		}
		public override float GetMpcost(GSkill skill)
		{
			return 950.000000f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_level = player.GetLevel();

			victim.SetProbability(600.0f);
			victim.SetTime(12100.0f);
			victim.SetSilent(true);
			victim.SetProbability(15.0f);
			victim.SetTime(60100.0f);
			victim.SetBarehanded(true);
			victim.SetProbability(15.0f);
			victim.SetTime(60000.0f);
			victim.SetBuffid(0);
			victim.SetAmount(((6000 * player_level)));
			victim.SetValue(((6000 * player_level)));
			victim.SetMpleak(true);
			victim.SetProbability(100.0f);
			victim.SetRatio(0.5f);
			victim.SetDrainmagic(true);
			return true;
		}
	}
	public class GSkill1664 : GSkill
	{
		public GSkill1664()
			: base(1664)
		{
			
		}
	}
	public class GSkill1665Stub : GSkillStub
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
				int				player_hp = player.GetHp();
				int				player_maxhp = player.GetMaxhp();

				skill.SetCrit(0.050000001f);
				skill.SetSkillaccu(300);
				skill.SetPlus(((player_maxhp - player_hp) * 0.15f));
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
				int				player_mp = player.GetMp();
				int				player_maxmp = player.GetMaxmp();

				skill.SetCrit(0.050000001f);
				skill.SetSkillaccu(300);
				skill.SetPlus(((player_maxmp - player_mp) * 0.15f));
				player.SetPerform(0);
			}
		}
		public GSkill1665Stub()
			: base(1665)
		{
			occupation = 146;
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
			SetAction(0,"∫œª∂≈…_‘¯º«∑Ò");
			SetAction(1,"∫œª∂≈…_‘¯º«∑Ò");
			SetAction(2,"∫œª∂≈…_‘¯º«∑Ò");
			SetAction(3,"∫œª∂≈…_‘¯º«∑Ò");
			SetAction(4,"∫œª∂≈…_‘¯º«∑Ò");
			SetAction(5,"∫œª∂≈…_‘¯º«∑Ò");
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
			SetAction(18,"∫œª∂≈…_∆Ô≥À_‘¯º«∑Ò");
			SetAction(19,"∫œª∂≈…_∆Ô≥À_‘¯º«∑Ò");
			SetAction(20,"∫œª∂≈…_∆Ô≥À_‘¯º«∑Ò");
			SetAction(21,"∫œª∂≈…_∆Ô≥À_‘¯º«∑Ò");
			SetAction(22,"∫œª∂≈…_∆Ô≥À_‘¯º«∑Ò");
			SetAction(23,"∫œª∂≈…_∆Ô≥À_‘¯º«∑Ò");
			SetAction(24,"");
			SetAction(25,"");
			SetAction(26,"");
			SetAction(27,"");
			SetAction(28,"");
			SetAction(29,"");
			SetAction(30,"");
			name = "‘¯º«∑Ò£∫√Ó";
			nativename = "‘¯º«∑Ò£∫√Ó";
			icon = "‘¯º«∑Ò.dds";
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
			AddState(new GState3());
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
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return player_range + 4.0f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return player_range + 2.0f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return player_range + 7.0f;
		}
		public override float GetMpcost(GSkill skill)
		{
			return 1050.000000f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetTime(15100.0f);
			victim.SetRatio(0.15000001f);
			victim.SetBuffid(0);
			victim.SetDecskilldamage(true);
			victim.SetProbability(100.0f);
			victim.SetTime(15100.0f);
			victim.SetRatio(0.15000001f);
			victim.SetInchurt(true);
			return true;
		}
	}
	public class GSkill1665 : GSkill
	{
		public GSkill1665()
			: base(1665)
		{
			
		}
	}
	public class GSkill1666Stub : GSkillStub
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
		public GSkill1666Stub()
			: base(1666)
		{
			occupation = 146;
			maxlevel = 1;
			maxlearn = 1;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 3;
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
			SetAction(0,"πÌµ¿_ƒÊƒß");
			SetAction(1,"πÌµ¿_ƒÊƒß");
			SetAction(2,"πÌµ¿_ƒÊƒß");
			SetAction(3,"πÌµ¿_ƒÊƒß");
			SetAction(4,"πÌµ¿_ƒÊƒß");
			SetAction(5,"πÌµ¿_ƒÊƒß");
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
			SetAction(18,"πÌµ¿_∆Ô≥À_ƒÊƒß");
			SetAction(19,"πÌµ¿_∆Ô≥À_ƒÊƒß");
			SetAction(20,"πÌµ¿_∆Ô≥À_ƒÊƒß");
			SetAction(21,"πÌµ¿_∆Ô≥À_ƒÊƒß");
			SetAction(22,"πÌµ¿_∆Ô≥À_ƒÊƒß");
			SetAction(23,"πÌµ¿_∆Ô≥À_ƒÊƒß");
			SetAction(24,"");
			SetAction(25,"");
			SetAction(26,"");
			SetAction(27,"");
			SetAction(28,"");
			SetAction(29,"");
			SetAction(30,"");
			name = "ƒÊƒß£∫√Ó";
			nativename = "ƒÊƒß£∫√Ó";
			icon = "ƒÊƒß.dds";
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
			return 360000;
		}
		public override float GetRadius(GSkill skill)
		{
			return 25.000000f;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 25.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 10.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			return 1100.000000f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_level = player.GetLevel();
			int				player_maxmp = player.GetMaxmp();

			victim.SetProbability(100.0f);
			victim.SetAmount(((300 * player_level * (norm((player_maxmp * 0.6f + 1.0f) / (300 * player_level)))) + (player_maxmp * (norm(((300 * player_level)) / (player_maxmp * 0.6f + 1.0f)) * 0.6f))));
			victim.SetMpdisperse(true);
			victim.SetProbability(999.0f);
			victim.SetTime(12100.0f);
			victim.SetRatio(0.15000001f);
			victim.SetInchurt(true);
			victim.SetProbability(100.0f);
			victim.SetTime(30100.0f);
			victim.SetBuffid(0);
			victim.SetValue(((5 * player_level)));
			victim.SetSubattack(true);
			victim.SetProbability(120.0f);
			victim.SetTime(30100.0f);
			victim.SetBuffid(0);
			victim.SetValue((player_level * 0.5f + 1.0f));
			victim.SetSubanti(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_level = player.GetLevel();

			victim.SetProbability(100.0f);
			victim.SetTime(30100.0f);
			victim.SetBuffid(0);
			victim.SetValue(((5 * player_level)));
			victim.SetAddattack(true);
			return true;
		}
	}
	public class GSkill1666 : GSkill
	{
		public GSkill1666()
			: base(1666)
		{
			
		}
	}
	public class GSkill1667Stub : GSkillStub
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
		public GSkill1667Stub()
			: base(1667)
		{
			occupation = 146;
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
			SetAction(0,"πÌµ¿_…≥Ó¯");
			SetAction(1,"πÌµ¿_…≥Ó¯");
			SetAction(2,"πÌµ¿_…≥Ó¯");
			SetAction(3,"πÌµ¿_…≥Ó¯");
			SetAction(4,"πÌµ¿_…≥Ó¯");
			SetAction(5,"πÌµ¿_…≥Ó¯");
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
			SetAction(18,"πÌµ¿_∆Ô≥À_…≥Ó¯");
			SetAction(19,"πÌµ¿_∆Ô≥À_…≥Ó¯");
			SetAction(20,"πÌµ¿_∆Ô≥À_…≥Ó¯");
			SetAction(21,"πÌµ¿_∆Ô≥À_…≥Ó¯");
			SetAction(22,"πÌµ¿_∆Ô≥À_…≥Ó¯");
			SetAction(23,"πÌµ¿_∆Ô≥À_…≥Ó¯");
			SetAction(24,"");
			SetAction(25,"");
			SetAction(26,"");
			SetAction(27,"");
			SetAction(28,"");
			SetAction(29,"");
			SetAction(30,"");
			name = "…≥Ó¯£∫√Ó";
			nativename = "…≥Ó¯£∫√Ó";
			icon = "…≥Ó¯.dds";
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
			return 360000;
		}
		public override float GetRadius(GSkill skill)
		{
			return 25.000000f;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 25.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 10.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			return 900.000000f;
		}
		public override int GetCoverage(GSkill skill)
		{
			return 25;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_level = player.GetLevel();

			victim.SetProbability(100.0f);
			victim.SetTime(30100.0f);
			victim.SetRatio(1.0f);
			victim.SetAmount(25.0f);
			victim.SetValue(((2 * player_level)));
			victim.SetBloodshield(true);
			victim.SetTime(12100.0f);
			victim.SetImmunedizzy(true);
			victim.SetRatio(1666.0f);
			victim.SetAmount(1668.0f);
			victim.SetValue(1669.0f);
			victim.SetClearcooldown(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_res1 = player.GetRes1();
			int				player_res2 = player.GetRes2();
			int				player_res3 = player.GetRes3();
			int				player_res4 = player.GetRes4();
			int				player_res5 = player.GetRes5();

			victim.SetProbability(100.0f);
			victim.SetTime(16100.0f);
			victim.SetBuffid(0);
			victim.SetValue(((player_res5 + (player_res4 + (player_res3 + (player_res2 + player_res1)))) * 0.33f));
			victim.SetAddattack(true);
			return true;
		}
	}
	public class GSkill1667 : GSkill
	{
		public GSkill1667()
			: base(1667)
		{
			
		}
	}
	public class GSkill1668Stub : GSkillStub
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

				skill.SetRatio(1.1f);
				player.SetPerform(1);
			}
		}
		public GSkill1668Stub()
			: base(1668)
		{
			occupation = 146;
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
			SetAction(0,"πÌµ¿_ÀÈ»–");
			SetAction(1,"πÌµ¿_ÀÈ»–");
			SetAction(2,"πÌµ¿_ÀÈ»–");
			SetAction(3,"πÌµ¿_ÀÈ»–");
			SetAction(4,"πÌµ¿_ÀÈ»–");
			SetAction(5,"πÌµ¿_ÀÈ»–");
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
			SetAction(18,"πÌµ¿_∆Ô≥À_ÀÈ»–");
			SetAction(19,"πÌµ¿_∆Ô≥À_ÀÈ»–");
			SetAction(20,"πÌµ¿_∆Ô≥À_ÀÈ»–");
			SetAction(21,"πÌµ¿_∆Ô≥À_ÀÈ»–");
			SetAction(22,"πÌµ¿_∆Ô≥À_ÀÈ»–");
			SetAction(23,"πÌµ¿_∆Ô≥À_ÀÈ»–");
			SetAction(24,"");
			SetAction(25,"");
			SetAction(26,"");
			SetAction(27,"");
			SetAction(28,"");
			SetAction(29,"");
			SetAction(30,"");
			name = "ÀÈ»–£∫√Ó";
			nativename = "ÀÈ»–£∫√Ó";
			icon = "ÀÈ»–.dds";
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
			return 252000;
		}
		public override float GetPraydistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return player_range + 4.0f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return player_range + 2.0f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return player_range + 6.0f;
		}
		public override float GetMpcost(GSkill skill)
		{
			return 850.000000f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_maxmp = player.GetMaxmp();

			victim.SetProbability(100.0f);
			victim.SetTime(12100.0f);
			victim.SetBarehanded(true);
			victim.SetProbability((player.GetObjectType()!=0)?0.0f:15.0f);
			victim.SetTime(12100.0f);
			victim.SetBuffid(0);
			victim.SetAmount(1.0f);
			victim.SetValue(player_maxmp);
			victim.SetSubmp(true);
			victim.SetProbability(100.0f);
			victim.SetRatio(0.5f);
			victim.SetDrainmagic(true);
			return true;
		}
	}
	public class GSkill1668 : GSkill
	{
		public GSkill1668()
			: base(1668)
		{
			
		}
	}
	public class GSkill1669Stub : GSkillStub
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
				int				player_hp = player.GetHp();
				int				player_mp = player.GetMp();

				skill.SetCrit(0.079999998f);
				skill.SetSkillaccu(3000);
				skill.SetPlus(((zrand((D2INT(player_mp * 0.25f + (player_hp * 0.25f)))) + 1)));
				player.SetPerform(1);
			}
		}
		public GSkill1669Stub()
			: base(1669)
		{
			occupation = 146;
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
			SetAction(0,"πÌµ¿_”ƒª˜");
			SetAction(1,"πÌµ¿_”ƒª˜");
			SetAction(2,"πÌµ¿_”ƒª˜");
			SetAction(3,"πÌµ¿_”ƒª˜");
			SetAction(4,"πÌµ¿_”ƒª˜");
			SetAction(5,"πÌµ¿_”ƒª˜");
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
			SetAction(18,"πÌµ¿_∆Ô≥À_”ƒª˜");
			SetAction(19,"πÌµ¿_∆Ô≥À_”ƒª˜");
			SetAction(20,"πÌµ¿_∆Ô≥À_”ƒª˜");
			SetAction(21,"πÌµ¿_∆Ô≥À_”ƒª˜");
			SetAction(22,"πÌµ¿_∆Ô≥À_”ƒª˜");
			SetAction(23,"πÌµ¿_∆Ô≥À_”ƒª˜");
			SetAction(24,"");
			SetAction(25,"");
			SetAction(26,"");
			SetAction(27,"");
			SetAction(28,"");
			SetAction(29,"");
			SetAction(30,"");
			name = "”ƒª˜£∫√Ó";
			nativename = "”ƒª˜£∫√Ó";
			icon = "”ƒª˜.dds";
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
			return 360000;
		}
		public override float GetPraydistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return player_range + 4.0f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return player_range + 2.0f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return player_range + 7.0f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetProbability(999.0f);
			victim.SetTime(6100.0f);
			victim.SetWrap(true);
			victim.SetProbability(100.0f);
			victim.SetTime(6100.0f);
			victim.SetPowerless(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_maxmp = player.GetMaxmp();

			victim.SetProbability(100.0f);
			victim.SetTime(15100.0f);
			victim.SetBuffid(0);
			victim.SetValue(10.0f);
			victim.SetAddspeed(true);
			victim.SetProbability(100.0f);
			victim.SetTime(100.0f);
			victim.SetBuffid(0);
			victim.SetAmount((player_maxmp * 0.15f));
			victim.SetValue(0.0f);
			victim.SetMpgen(true);
			return true;
		}
	}
	public class GSkill1669 : GSkill
	{
		public GSkill1669()
			: base(1669)
		{
			
		}
	}
}
