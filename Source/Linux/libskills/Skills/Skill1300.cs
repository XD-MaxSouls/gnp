using System;
using System.Text;

namespace SKILL
{
	public class GSkill1300Stub : GSkillStub
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
				int				player_level = player.GetLevel();
				int				player_mp = player.GetMp();
				int				player_maxmp = player.GetMaxmp();

				skill.SetRatio((norm(player_mp / (player_maxmp * 0.75f + 1.0f)) * 0.2f + 1.2f));
				skill.SetPlus(((12 * player_level)));
				player.SetPerform(1);
			}
		}
		public GSkill1300Stub()
			: base(1300)
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
			SetAction(0,"ÇàÔÆÃÅ_Ì«Òõ±ùĞÄÖä");
			SetAction(1,"ÇàÔÆÃÅ_Ì«Òõ±ùĞÄÖä");
			SetAction(2,"ÇàÔÆÃÅ_Ì«Òõ±ùĞÄÖä");
			SetAction(3,"ÇàÔÆÃÅ_Ì«Òõ±ùĞÄÖä");
			SetAction(4,"ÇàÔÆÃÅ_Ì«Òõ±ùĞÄÖä");
			SetAction(5,"ÇàÔÆÃÅ_Ì«Òõ±ùĞÄÖä");
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
			SetAction(18,"ÇàÔÆÃÅ_Æï³Ë_Ì«Òõ±ùĞÄÖä");
			SetAction(19,"ÇàÔÆÃÅ_Æï³Ë_Ì«Òõ±ùĞÄÖä");
			SetAction(20,"ÇàÔÆÃÅ_Æï³Ë_Ì«Òõ±ùĞÄÖä");
			SetAction(21,"ÇàÔÆÃÅ_Æï³Ë_Ì«Òõ±ùĞÄÖä");
			SetAction(22,"ÇàÔÆÃÅ_Æï³Ë_Ì«Òõ±ùĞÄÖä");
			SetAction(23,"ÇàÔÆÃÅ_Æï³Ë_Ì«Òõ±ùĞÄÖä");
			SetAction(24,"");
			SetAction(25,"");
			SetAction(26,"");
			SetAction(27,"");
			SetAction(28,"");
			SetAction(29,"");
			SetAction(30,"");
			name = "Ì«Òõ±ùÖä£ºĞş";
			nativename = "Ì«Òõ±ùÖä£ºĞş";
			icon = "Ì«Òõ±ùĞÄÖä.dds";
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

			return player_range + 11.0f;
		}
		public override float GetMpcost(GSkill skill)
		{
			return 1200.000000f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetProbability(100.0f);
			victim.SetTime(8100.0f);
			victim.SetRatio(0.0f);
			victim.SetBuffid(9);
			victim.SetFrozen(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_hp = player.GetHp();

			victim.SetProbability(100.0f);
			victim.SetTime(100.0f);
			victim.SetBuffid(1);
			victim.SetAmount(0.0f);
			victim.SetValue((player_hp * 0.15f));
			victim.SetMpgen(true);
			return true;
		}
	}
	public class GSkill1300 : GSkill
	{
		public GSkill1300()
			: base(1300)
		{
			
		}
	}
	public class GSkill1301Stub : GSkillStub
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
		public GSkill1301Stub()
			: base(1301)
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
			SetAction(0,"ÇàÔÆÃÅ_ÎåÀ×Ìì½Ù»ğ");
			SetAction(1,"ÇàÔÆÃÅ_ÎåÀ×Ìì½Ù»ğ");
			SetAction(2,"ÇàÔÆÃÅ_ÎåÀ×Ìì½Ù»ğ");
			SetAction(3,"ÇàÔÆÃÅ_ÎåÀ×Ìì½Ù»ğ");
			SetAction(4,"ÇàÔÆÃÅ_ÎåÀ×Ìì½Ù»ğ");
			SetAction(5,"ÇàÔÆÃÅ_ÎåÀ×Ìì½Ù»ğ");
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
			SetAction(18,"ÇàÔÆÃÅ_Æï³Ë_ÎåÀ×Ìì½Ù»ğ");
			SetAction(19,"ÇàÔÆÃÅ_Æï³Ë_ÎåÀ×Ìì½Ù»ğ");
			SetAction(20,"ÇàÔÆÃÅ_Æï³Ë_ÎåÀ×Ìì½Ù»ğ");
			SetAction(21,"ÇàÔÆÃÅ_Æï³Ë_ÎåÀ×Ìì½Ù»ğ");
			SetAction(22,"ÇàÔÆÃÅ_Æï³Ë_ÎåÀ×Ìì½Ù»ğ");
			SetAction(23,"ÇàÔÆÃÅ_Æï³Ë_ÎåÀ×Ìì½Ù»ğ");
			SetAction(24,"");
			SetAction(25,"");
			SetAction(26,"");
			SetAction(27,"");
			SetAction(28,"");
			SetAction(29,"");
			SetAction(30,"");
			name = "ÎåÀ×Ìì½Ù£ºĞş";
			nativename = "ÎåÀ×Ìì½Ù£ºĞş";
			icon = "ÎåÀ×Ìì½Ù»ğ.dds";
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

			return player_range + 11.0f;
		}
		public override float GetMpcost(GSkill skill)
		{
			return 1200.000000f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_hp = player.GetHp();
			int				player_maxhp = player.GetMaxhp();
			int				player_mp = player.GetMp();
			int				player_maxmp = player.GetMaxmp();

			victim.SetProbability(100.0f);
			victim.SetTime(((48000 / ((norm(player_maxmp / (2 * player_mp + 1)) + 1) * (norm(player_maxhp / (2 * player_hp + 1)) + 1)))));
			victim.SetBuffid(0);
			victim.SetAmount(((player_maxmp + player_maxhp) * 0.5f));
			victim.SetValue(0.0f);
			victim.SetHpleak(true);
			victim.SetProbability(600.0f);
			victim.SetTime(6100.0f);
			victim.SetWrap(true);
			return true;
		}
	}
	public class GSkill1301 : GSkill
	{
		public GSkill1301()
			: base(1301)
		{
			
		}
	}
	public class GSkill1302Stub : GSkillStub
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

				player.SetVar1(player_res1);
				player.SetPerform(1);
			}
		}
		public GSkill1302Stub()
			: base(1302)
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
			SetAction(0,"¹íÍõ×Ú_ÁúĞ¥");
			SetAction(1,"¹íÍõ×Ú_ÁúĞ¥");
			SetAction(2,"¹íÍõ×Ú_ÁúĞ¥");
			SetAction(3,"¹íÍõ×Ú_ÁúĞ¥");
			SetAction(4,"¹íÍõ×Ú_ÁúĞ¥");
			SetAction(5,"¹íÍõ×Ú_ÁúĞ¥");
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
			SetAction(18,"¹íÍõ×Ú_Æï³Ë_ÁúĞ¥");
			SetAction(19,"¹íÍõ×Ú_Æï³Ë_ÁúĞ¥");
			SetAction(20,"¹íÍõ×Ú_Æï³Ë_ÁúĞ¥");
			SetAction(21,"¹íÍõ×Ú_Æï³Ë_ÁúĞ¥");
			SetAction(22,"¹íÍõ×Ú_Æï³Ë_ÁúĞ¥");
			SetAction(23,"¹íÍõ×Ú_Æï³Ë_ÁúĞ¥");
			SetAction(24,"");
			SetAction(25,"");
			SetAction(26,"");
			SetAction(27,"");
			SetAction(28,"");
			SetAction(29,"");
			SetAction(30,"");
			name = "ÁúĞ¥£ºĞş";
			nativename = "ÁúĞ¥£ºĞş";
			icon = "ÁúĞ¥.dds";
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
			int				player_var1 = player.GetVar1();

			victim.SetProbability((player_var1 <= 600)?600.0f:player_var1);
			victim.SetTime(((6000 * norm(zrand(100) / 75) + 6100)));
			victim.SetDizzy(true);
			victim.SetProbability(100.0f);
			victim.SetTime(((9000 * norm(zrand(100) / 75) + 9100)));
			victim.SetRatio(0.1f);
			victim.SetBuffid(0);
			victim.SetDecdefence(true);
			victim.SetProbability(600.0f);
			victim.SetTime(30100.0f);
			victim.SetRatio(0.25f);
			victim.SetBuffid(0);
			victim.SetSlow(true);
			return true;
		}
	}
	public class GSkill1302 : GSkill
	{
		public GSkill1302()
			: base(1302)
		{
			
		}
	}
	public class GSkill1303Stub : GSkillStub
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
		public GSkill1303Stub()
			: base(1303)
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
			SetAction(0,"¹íÍõ×Ú_ÄÎºÎ");
			SetAction(1,"¹íÍõ×Ú_ÄÎºÎ");
			SetAction(2,"¹íÍõ×Ú_ÄÎºÎ");
			SetAction(3,"¹íÍõ×Ú_ÄÎºÎ");
			SetAction(4,"¹íÍõ×Ú_ÄÎºÎ");
			SetAction(5,"¹íÍõ×Ú_ÄÎºÎ");
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
			SetAction(18,"¹íÍõ×Ú_Æï³Ë_ÄÎºÎ");
			SetAction(19,"¹íÍõ×Ú_Æï³Ë_ÄÎºÎ");
			SetAction(20,"¹íÍõ×Ú_Æï³Ë_ÄÎºÎ");
			SetAction(21,"¹íÍõ×Ú_Æï³Ë_ÄÎºÎ");
			SetAction(22,"¹íÍõ×Ú_Æï³Ë_ÄÎºÎ");
			SetAction(23,"¹íÍõ×Ú_Æï³Ë_ÄÎºÎ");
			SetAction(24,"");
			SetAction(25,"");
			SetAction(26,"");
			SetAction(27,"");
			SetAction(28,"");
			SetAction(29,"");
			SetAction(30,"");
			name = "ÄÎºÎ£ºĞş";
			nativename = "ÄÎºÎ£ºĞş";
			icon = "ÄÎºÎ.dds";
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
		public override float GetEffectdistance(GSkill skill)
		{
			return 25.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			return 800.000000f;
		}
		public override int GetCoverage(GSkill skill)
		{
			return 25;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetProbability(100.0f);
			victim.SetTime(15100.0f);
			victim.SetRatio(0.1f);
			victim.SetBuffid(0);
			victim.SetIncattack(true);
			victim.SetTime(15100.0f);
			victim.SetValue(((20 * norm(zrand(100) / 75) + 20)));
			victim.SetBlessed(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetProbability(100.0f);
			victim.SetTime(16100.0f);
			victim.SetRatio(0.25f);
			victim.SetBuffid(0);
			victim.SetIncskillaccu(true);
			return true;
		}
	}
	public class GSkill1303 : GSkill
	{
		public GSkill1303()
			: base(1303)
		{
			
		}
	}
	public class GSkill1304Stub : GSkillStub
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
				return 600;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_hp = player.GetHp();
				int				player_maxhp = player.GetMaxhp();
				int				player_mp = player.GetMp();
				int				player_maxmp = player.GetMaxmp();

				skill.SetRatio(0.5f);
				skill.SetPlus((norm((2 * player_mp) / (player_maxmp + 1)) * (player_mp * 0.01f) + (norm((2 * player_hp) / (player_maxhp + 1)) * (player_hp * 0.01f))));
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
				int				player_hp = player.GetHp();
				int				player_maxhp = player.GetMaxhp();
				int				player_mp = player.GetMp();
				int				player_maxmp = player.GetMaxmp();

				skill.SetRatio(0.69999999f);
				skill.SetPlus((norm((2 * player_mp) / (player_maxmp + 1)) * (player_mp * 0.01f) + (norm((2 * player_hp) / (player_maxhp + 1)) * (player_hp * 0.01f))));
				player.SetPerform(1);
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
				return 600;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_hp = player.GetHp();
				int				player_maxhp = player.GetMaxhp();
				int				player_mp = player.GetMp();
				int				player_maxmp = player.GetMaxmp();

				skill.SetRatio(0.89999998f);
				skill.SetPlus((norm((2 * player_mp) / (player_maxmp + 1)) * (player_mp * 0.01f) + (norm((2 * player_hp) / (player_maxhp + 1)) * (player_hp * 0.01f))));
				player.SetPerform(1);
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
				return 600;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_hp = player.GetHp();
				int				player_maxhp = player.GetMaxhp();
				int				player_mp = player.GetMp();
				int				player_maxmp = player.GetMaxmp();

				skill.SetRatio(1.1f);
				skill.SetPlus((norm((2 * player_mp) / (player_maxmp + 1)) * (player_mp * 0.01f) + (norm((2 * player_hp) / (player_maxhp + 1)) * (player_hp * 0.01f))));
				player.SetPerform(1);
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
				return 600;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_hp = player.GetHp();
				int				player_maxhp = player.GetMaxhp();
				int				player_mp = player.GetMp();
				int				player_maxmp = player.GetMaxmp();

				skill.SetRatio(1.3f);
				skill.SetPlus((norm((2 * player_mp) / (player_maxmp + 1)) * (player_mp * 0.01f) + (norm((2 * player_hp) / (player_maxhp + 1)) * (player_hp * 0.01f))));
				player.SetPerform(1);
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
				return 600;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_hp = player.GetHp();
				int				player_maxhp = player.GetMaxhp();
				int				player_mp = player.GetMp();
				int				player_maxmp = player.GetMaxmp();

				skill.SetRatio(1.5f);
				skill.SetPlus((norm((2 * player_mp) / (player_maxmp + 1)) * (player_mp * 0.01f) + (norm((2 * player_hp) / (player_maxhp + 1)) * (player_hp * 0.01f))));
				player.SetPerform(1);
			}
			public override bool Cancel(GSkill skill)
			{
				return true;
			}
		}
		public class GState8 : GState
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
				int				player_mp = player.GetMp();
				int				player_maxmp = player.GetMaxmp();

				skill.SetRatio(1.7f);
				skill.SetPlus((norm((2 * player_mp) / (player_maxmp + 1)) * (player_mp * 0.01f) + (norm((2 * player_hp) / (player_maxhp + 1)) * (player_hp * 0.01f))));
				player.SetPerform(1);
			}
			public override bool Cancel(GSkill skill)
			{
				return true;
			}
		}
		public class GState9 : GState
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
				int				player_mp = player.GetMp();
				int				player_maxmp = player.GetMaxmp();

				skill.SetRatio(1.9f);
				skill.SetPlus((norm((2 * player_mp) / (player_maxmp + 1)) * (player_mp * 0.01f) + (norm((2 * player_hp) / (player_maxhp + 1)) * (player_hp * 0.01f))));
				player.SetPerform(1);
			}
			public override bool Cancel(GSkill skill)
			{
				return true;
			}
		}
		public class GState10 : GState
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
				int				player_mp = player.GetMp();
				int				player_maxmp = player.GetMaxmp();

				skill.SetRatio(2.0999999f);
				skill.SetPlus((norm((2 * player_mp) / (player_maxmp + 1)) * (player_mp * 0.01f) + (norm((2 * player_hp) / (player_maxhp + 1)) * (player_hp * 0.01f))));
				player.SetPerform(1);
			}
		}
		public GSkill1304Stub()
			: base(1304)
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
			SetAction(0,"¹íÍõ×Ú_¾Å±ä");
			SetAction(1,"¹íÍõ×Ú_¾Å±ä");
			SetAction(2,"¹íÍõ×Ú_¾Å±ä");
			SetAction(3,"¹íÍõ×Ú_¾Å±ä");
			SetAction(4,"¹íÍõ×Ú_¾Å±ä");
			SetAction(5,"¹íÍõ×Ú_¾Å±ä");
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
			SetAction(18,"¹íÍõ×Ú_Æï³Ë_¾Å±ä");
			SetAction(19,"¹íÍõ×Ú_Æï³Ë_¾Å±ä");
			SetAction(20,"¹íÍõ×Ú_Æï³Ë_¾Å±ä");
			SetAction(21,"¹íÍõ×Ú_Æï³Ë_¾Å±ä");
			SetAction(22,"¹íÍõ×Ú_Æï³Ë_¾Å±ä");
			SetAction(23,"¹íÍõ×Ú_Æï³Ë_¾Å±ä");
			SetAction(24,"");
			SetAction(25,"");
			SetAction(26,"");
			SetAction(27,"");
			SetAction(28,"");
			SetAction(29,"");
			SetAction(30,"");
			name = "¾Å±ä£ºĞş";
			nativename = "¾Å±ä£ºĞş";
			icon = "¾Å±ä.dds";
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
			AddState(new GState3());
			AddState(new GState4());
			AddState(new GState5());
			AddState(new GState6());
			AddState(new GState7());
			AddState(new GState8());
			AddState(new GState9());
			AddState(new GState10());
		}
		public override int GetExecutetime(GSkill skill)
		{
			return 6000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			return 360000;
		}
		public override float GetPraydistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return player_range + 18.0f;
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

			return player_range + 24.0f;
		}
		public override float GetMpcost(GSkill skill)
		{
			return 305.000000f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetProbability(((600 * norm(zrand(100) / 85))));
			victim.SetTime(2100.0f);
			victim.SetWrap(true);
			return true;
		}
	}
	public class GSkill1304 : GSkill
	{
		public GSkill1304()
			: base(1304)
		{
			
		}
	}
	public class GSkill1305Stub : GSkillStub
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
				return 800;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_hp = player.GetHp();
				int				player_mp = player.GetMp();
				int				player_maxmp = player.GetMaxmp();

				player.SetHp((player_hp * 0.75f));
				skill.SetRatio((norm(player_mp / (player_maxmp * 0.75f + 1.0f)) * 0.2f + 2.0f));
				skill.SetCrit(0.5f);
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
				return 800;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_hp = player.GetHp();
				int				player_mp = player.GetMp();
				int				player_maxmp = player.GetMaxmp();

				player.SetHp((player_hp * 0.75f));
				skill.SetCrit(0.5f);
				skill.SetRatio((norm(player_mp / (player_maxmp * 0.75f + 1.0f)) * 0.2f + 1.0f));
				player.SetPerform(0);
			}
		}
		public GSkill1305Stub()
			: base(1305)
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
			doenchant = false;
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
			SetAction(0,"¹íÍõ×Ú_¿Õ·µ");
			SetAction(1,"¹íÍõ×Ú_¿Õ·µ");
			SetAction(2,"¹íÍõ×Ú_¿Õ·µ");
			SetAction(3,"¹íÍõ×Ú_¿Õ·µ");
			SetAction(4,"¹íÍõ×Ú_¿Õ·µ");
			SetAction(5,"¹íÍõ×Ú_¿Õ·µ");
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
			SetAction(18,"¹íÍõ×Ú_Æï³Ë_¿Õ·µ");
			SetAction(19,"¹íÍõ×Ú_Æï³Ë_¿Õ·µ");
			SetAction(20,"¹íÍõ×Ú_Æï³Ë_¿Õ·µ");
			SetAction(21,"¹íÍõ×Ú_Æï³Ë_¿Õ·µ");
			SetAction(22,"¹íÍõ×Ú_Æï³Ë_¿Õ·µ");
			SetAction(23,"¹íÍõ×Ú_Æï³Ë_¿Õ·µ");
			SetAction(24,"");
			SetAction(25,"");
			SetAction(26,"");
			SetAction(27,"");
			SetAction(28,"");
			SetAction(29,"");
			SetAction(30,"");
			name = "¿Õ·µ£ºĞş";
			nativename = "¿Õ·µ£ºĞş";
			icon = "¿Õ·µ.dds";
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

			return player_range + 6.0f;
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

			return player_range + 8.0f;
		}
		public override float GetMpcost(GSkill skill)
		{
			return 1100.000000f;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_level = player.GetLevel();
			int				skill_level = skill.GetLevel();

			victim.SetTime(6100.0f);
			victim.SetRatio((player_level * 0.002f + 0.5f));
			victim.SetAmount(((1600 * player_level * skill_level)));
			victim.SetDechurt(true);
			return true;
		}
	}
	public class GSkill1305 : GSkill
	{
		public GSkill1305()
			: base(1305)
		{
			
		}
	}
	public class GSkill1306Stub : GSkillStub
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
		public GSkill1306Stub()
			: base(1306)
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
			SetAction(0,"ÌìÒôËÂ_ÆÆÄ§åÈÀ¶");
			SetAction(1,"ÌìÒôËÂ_ÆÆÄ§åÈÀ¶");
			SetAction(2,"ÌìÒôËÂ_ÆÆÄ§åÈÀ¶");
			SetAction(3,"ÌìÒôËÂ_ÆÆÄ§åÈÀ¶");
			SetAction(4,"ÌìÒôËÂ_ÆÆÄ§åÈÀ¶");
			SetAction(5,"ÌìÒôËÂ_ÆÆÄ§åÈÀ¶");
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
			SetAction(18,"ÌìÒôËÂ_Æï³Ë_ÆÆÄ§åÈÀ¶");
			SetAction(19,"ÌìÒôËÂ_Æï³Ë_ÆÆÄ§åÈÀ¶");
			SetAction(20,"ÌìÒôËÂ_Æï³Ë_ÆÆÄ§åÈÀ¶");
			SetAction(21,"ÌìÒôËÂ_Æï³Ë_ÆÆÄ§åÈÀ¶");
			SetAction(22,"ÌìÒôËÂ_Æï³Ë_ÆÆÄ§åÈÀ¶");
			SetAction(23,"ÌìÒôËÂ_Æï³Ë_ÆÆÄ§åÈÀ¶");
			SetAction(24,"");
			SetAction(25,"");
			SetAction(26,"");
			SetAction(27,"");
			SetAction(28,"");
			SetAction(29,"");
			SetAction(30,"");
			name = "ÆÆÄ§åÈÀ¶£ºĞş";
			nativename = "ÆÆÄ§åÈÀ¶£ºĞş";
			icon = "ÆÆÄ§åÈÀ¶.dds";
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
			return 1150.000000f;
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
			victim.SetTime(15100.0f);
			victim.SetBuffid(0);
			victim.SetAmount((((30 * player_level) - 15 * norm(zrand(100) / 85) * player_level)));
			victim.SetValue(((99 * player_level)));
			victim.SetSubhp(true);
			victim.SetProbability(100.0f);
			victim.SetTime(15100.0f);
			victim.SetBuffid(0);
			victim.SetAmount((((30 * player_level) - 15 * norm(zrand(100) / 85) * player_level)));
			victim.SetValue(((99 * player_level)));
			victim.SetSubmp(true);
			victim.SetProbability(600.0f);
			victim.SetTime(15100.0f);
			victim.SetRatio(0.5f);
			victim.SetBuffid(0);
			victim.SetSlow(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_hp = player.GetHp();

			victim.SetProbability(100.0f);
			victim.SetRatio(0.0f);
			victim.SetValue(player_hp);
			victim.SetHeal(true);
			victim.SetProbability(100.0f);
			victim.SetBuffid(2);
			victim.SetAmount(99.0f);
			victim.SetValue(99.0f);
			victim.SetExorcism(true);
			return true;
		}
	}
	public class GSkill1306 : GSkill
	{
		public GSkill1306()
			: base(1306)
		{
			
		}
	}
	public class GSkill1307Stub : GSkillStub
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
		public GSkill1307Stub()
			: base(1307)
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
			SetAction(0,"ÌìÒôËÂ_Íò·ğ³¯×Ú");
			SetAction(1,"ÌìÒôËÂ_Íò·ğ³¯×Ú");
			SetAction(2,"ÌìÒôËÂ_Íò·ğ³¯×Ú");
			SetAction(3,"ÌìÒôËÂ_Íò·ğ³¯×Ú");
			SetAction(4,"ÌìÒôËÂ_Íò·ğ³¯×Ú");
			SetAction(5,"ÌìÒôËÂ_Íò·ğ³¯×Ú");
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
			SetAction(18,"ÌìÒôËÂ_Æï³Ë_Íò·ğ³¯×Ú");
			SetAction(19,"ÌìÒôËÂ_Æï³Ë_Íò·ğ³¯×Ú");
			SetAction(20,"ÌìÒôËÂ_Æï³Ë_Íò·ğ³¯×Ú");
			SetAction(21,"ÌìÒôËÂ_Æï³Ë_Íò·ğ³¯×Ú");
			SetAction(22,"ÌìÒôËÂ_Æï³Ë_Íò·ğ³¯×Ú");
			SetAction(23,"ÌìÒôËÂ_Æï³Ë_Íò·ğ³¯×Ú");
			SetAction(24,"");
			SetAction(25,"");
			SetAction(26,"");
			SetAction(27,"");
			SetAction(28,"");
			SetAction(29,"");
			SetAction(30,"");
			name = "ÌìÍâ·ğ¹â£ºĞş";
			nativename = "ÌìÍâ·ğ¹â£ºĞş";
			icon = "ÌìÍâ·ğ¹â.dds";
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
			return 25;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetTime(30100.0f);
			victim.SetRatio(1.0f);
			victim.SetBuffid(0);
			victim.SetIncanti(true);
			victim.SetProbability(100.0f);
			victim.SetTime(12100.0f);
			victim.SetBuffid(0);
			victim.SetValue(9999.0f);
			victim.SetAdddefence(true);
			victim.SetProbability(100.0f);
			victim.SetClearwrap(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetProbability(100.0f);
			victim.SetTime(16100.0f);
			victim.SetRatio(0.25f);
			victim.SetBuffid(0);
			victim.SetIncskilldodge(true);
			victim.SetProbability(100.0f);
			victim.SetBuffid(3);
			victim.SetAmount(99.0f);
			victim.SetValue(99.0f);
			victim.SetExorcism(true);
			return true;
		}
	}
	public class GSkill1307 : GSkill
	{
		public GSkill1307()
			: base(1307)
		{
			
		}
	}
	public class GSkill1308Stub : GSkillStub
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
				int				player_mp = player.GetMp();
				int				player_maxmp = player.GetMaxmp();

				skill.SetRatio((norm(player_mp / (player_maxmp * 0.75f + 1.0f)) * 0.2f + 1.1f));
				skill.SetCrithurt(3.0f);
				player.SetPerform(1);
			}
		}
		public GSkill1308Stub()
			: base(1308)
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
			SetAction(0,"ÌìÒôËÂ_ÂÖ»Ø»Ã¾³");
			SetAction(1,"ÌìÒôËÂ_ÂÖ»Ø»Ã¾³");
			SetAction(2,"ÌìÒôËÂ_ÂÖ»Ø»Ã¾³");
			SetAction(3,"ÌìÒôËÂ_ÂÖ»Ø»Ã¾³");
			SetAction(4,"ÌìÒôËÂ_ÂÖ»Ø»Ã¾³");
			SetAction(5,"ÌìÒôËÂ_ÂÖ»Ø»Ã¾³");
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
			SetAction(18,"ÌìÒôËÂ_Æï³Ë_ÂÖ»Ø»Ã¾³");
			SetAction(19,"ÌìÒôËÂ_Æï³Ë_ÂÖ»Ø»Ã¾³");
			SetAction(20,"ÌìÒôËÂ_Æï³Ë_ÂÖ»Ø»Ã¾³");
			SetAction(21,"ÌìÒôËÂ_Æï³Ë_ÂÖ»Ø»Ã¾³");
			SetAction(22,"ÌìÒôËÂ_Æï³Ë_ÂÖ»Ø»Ã¾³");
			SetAction(23,"ÌìÒôËÂ_Æï³Ë_ÂÖ»Ø»Ã¾³");
			SetAction(24,"");
			SetAction(25,"");
			SetAction(26,"");
			SetAction(27,"");
			SetAction(28,"");
			SetAction(29,"");
			SetAction(30,"");
			name = "ÂÖ»Ø»Ã¾³£ºĞş";
			nativename = "ÂÖ»Ø»Ã¾³£ºĞş";
			icon = "ÂÖ»Ø»Ã¾³.dds";
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
			return true;
		}
	}
	public class GSkill1308 : GSkill
	{
		public GSkill1308()
			: base(1308)
		{
			
		}
	}
	public class GSkill1309Stub : GSkillStub
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

				skill.SetRatio(((2 * (norm(player_hp / player_maxhp)) * norm((player_mp / player_maxmp)) + 1)));
				player.SetPerform(1);
			}
		}
		public GSkill1309Stub()
			: base(1309)
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
			SetAction(0,"ÌìÒôËÂ_ÉáÉí´óÔ¸");
			SetAction(1,"ÌìÒôËÂ_ÉáÉí´óÔ¸");
			SetAction(2,"ÌìÒôËÂ_ÉáÉí´óÔ¸");
			SetAction(3,"ÌìÒôËÂ_ÉáÉí´óÔ¸");
			SetAction(4,"ÌìÒôËÂ_ÉáÉí´óÔ¸");
			SetAction(5,"ÌìÒôËÂ_ÉáÉí´óÔ¸");
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
			SetAction(18,"ÌìÒôËÂ_Æï³Ë_ÉáÉí´óÔ¸");
			SetAction(19,"ÌìÒôËÂ_Æï³Ë_ÉáÉí´óÔ¸");
			SetAction(20,"ÌìÒôËÂ_Æï³Ë_ÉáÉí´óÔ¸");
			SetAction(21,"ÌìÒôËÂ_Æï³Ë_ÉáÉí´óÔ¸");
			SetAction(22,"ÌìÒôËÂ_Æï³Ë_ÉáÉí´óÔ¸");
			SetAction(23,"ÌìÒôËÂ_Æï³Ë_ÉáÉí´óÔ¸");
			SetAction(24,"");
			SetAction(25,"");
			SetAction(26,"");
			SetAction(27,"");
			SetAction(28,"");
			SetAction(29,"");
			SetAction(30,"");
			name = "ÉáÉí´óÔ¸£ºĞş";
			nativename = "ÉáÉí´óÔ¸£ºĞş";
			icon = "ÉáÉí´óÔ¸.dds";
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

			victim.SetProbability(600.0f);
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
	public class GSkill1309 : GSkill
	{
		public GSkill1309()
			: base(1309)
		{
			
		}
	}
}
