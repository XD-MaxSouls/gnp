using System;
using System.Text;

namespace SKILL
{
	public class GSkill770Stub : GSkillStub
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
		public GSkill770Stub()
			: base(770)
		{
			occupation = 4;
			maxlevel = 4;
			maxlearn = 3;
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
			SetAction(0,"ºÏ»¶ÅÉ_²»»Ú");
			SetAction(1,"ºÏ»¶ÅÉ_²»»Ú");
			SetAction(2,"ºÏ»¶ÅÉ_²»»Ú");
			SetAction(3,"ºÏ»¶ÅÉ_²»»Ú");
			SetAction(4,"ºÏ»¶ÅÉ_²»»Ú");
			SetAction(5,"ºÏ»¶ÅÉ_²»»Ú");
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
			SetAction(18,"ºÏ»¶ÅÉ_Æï³Ë_²»»Ú");
			SetAction(19,"ºÏ»¶ÅÉ_Æï³Ë_²»»Ú");
			SetAction(20,"ºÏ»¶ÅÉ_Æï³Ë_²»»Ú");
			SetAction(21,"ºÏ»¶ÅÉ_Æï³Ë_²»»Ú");
			SetAction(22,"ºÏ»¶ÅÉ_Æï³Ë_²»»Ú");
			SetAction(23,"ºÏ»¶ÅÉ_Æï³Ë_²»»Ú");
			SetAction(24,"");
			SetAction(25,"");
			SetAction(26,"");
			SetAction(27,"");
			SetAction(28,"");
			SetAction(29,"");
			SetAction(30,"");
			name = "²»»Ú";
			nativename = "²»»Ú";
			icon = "²»»Ú.dds";
			SetTalent(0,0);
			SetTalent(1,0);
			SetTalent(2,0);
			SetTalent(3,0);
			SetTalent(4,0);
			SetTalent(5,0);
			SetTalent(6,0);
			SetTalent(7,0);
			talent_size = 0;
			talent_type = 1;
			use_proficiency = false;
			inc_proficiency = 0;
			preskillnum = 1;
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
		public override int GetRequiredLevel(int level)
		{
			int[] array={120,125,130};return array[level-1];
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

			return (skill_level * skill_level + (20 * skill_level) + 220);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();

			victim.SetTime(((1000 * skill_level + 15000)));
			victim.SetRatio((skill_level * 0.0401f));
			victim.SetInccritrate(true);
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={767};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={2};return array[index];
		}
	}
	public class GSkill770 : GSkill
	{
		public GSkill770()
			: base(770)
		{
			
		}
	}
	public class GSkill771Stub : GSkillStub
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
		public GSkill771Stub()
			: base(771)
		{
			occupation = 129;
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
			name = "ÇàÔÆÖ®ÎÞÀäÈ´";
			nativename = "ÇàÔÆÖ®ÎÞÀäÈ´";
			icon = "·çÀ×Ö®Ô¹.dds";
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
		public override int GetCooldowntime(GSkill skill)
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
		public override float GetMpcost(GSkill skill)
		{
			return 1.000000f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetRatio(233.0f);
			victim.SetAmount(235.0f);
			victim.SetValue(239.0f);
			victim.SetClearcooldown(true);
			victim.SetRatio(395.0f);
			victim.SetAmount(241.0f);
			victim.SetValue(539.0f);
			victim.SetClearcooldown(true);
			victim.SetRatio(538.0f);
			victim.SetAmount(540.0f);
			victim.SetValue(542.0f);
			victim.SetClearcooldown(true);
			victim.SetRatio(600.0f);
			victim.SetAmount(389.0f);
			victim.SetValue(555.0f);
			victim.SetClearcooldown(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetRatio(784.0f);
			victim.SetAmount(785.0f);
			victim.SetValue(786.0f);
			victim.SetClearcooldown(true);
			return true;
		}
	}
	public class GSkill771 : GSkill
	{
		public GSkill771()
			: base(771)
		{
			
		}
	}
	public class GSkill772Stub : GSkillStub
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
		public GSkill772Stub()
			: base(772)
		{
			occupation = 129;
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
			name = "¹íÍõÖ®ÎÞÀäÈ´";
			nativename = "¹íÍõÖ®ÎÞÀäÈ´";
			icon = "Ä§µÀ.dds";
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
		public override int GetCooldowntime(GSkill skill)
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
		public override float GetMpcost(GSkill skill)
		{
			return 1.000000f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetRatio(243.0f);
			victim.SetAmount(245.0f);
			victim.SetValue(521.0f);
			victim.SetClearcooldown(true);
			victim.SetRatio(258.0f);
			victim.SetAmount(257.0f);
			victim.SetValue(259.0f);
			victim.SetClearcooldown(true);
			victim.SetRatio(255.0f);
			victim.SetAmount(314.0f);
			victim.SetValue(520.0f);
			victim.SetClearcooldown(true);
			victim.SetRatio(526.0f);
			victim.SetAmount(522.0f);
			victim.SetValue(524.0f);
			victim.SetClearcooldown(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetRatio(776.0f);
			victim.SetAmount(777.0f);
			victim.SetValue(778.0f);
			victim.SetClearcooldown(true);
			return true;
		}
	}
	public class GSkill772 : GSkill
	{
		public GSkill772()
			: base(772)
		{
			
		}
	}
	public class GSkill773Stub : GSkillStub
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
		public GSkill773Stub()
			: base(773)
		{
			occupation = 129;
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
			name = "ÌìÒôÖ®ÎÞÀäÈ´";
			nativename = "ÌìÒôÖ®ÎÞÀäÈ´";
			icon = "Ìì¹ÄÀ×Òô.dds";
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
		public override int GetCooldowntime(GSkill skill)
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
		public override float GetMpcost(GSkill skill)
		{
			return 1.000000f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetRatio(268.0f);
			victim.SetAmount(271.0f);
			victim.SetValue(276.0f);
			victim.SetClearcooldown(true);
			victim.SetRatio(319.0f);
			victim.SetAmount(547.0f);
			victim.SetValue(549.0f);
			victim.SetClearcooldown(true);
			victim.SetRatio(551.0f);
			victim.SetAmount(677.0f);
			victim.SetValue(685.0f);
			victim.SetClearcooldown(true);
			victim.SetRatio(787.0f);
			victim.SetAmount(789.0f);
			victim.SetValue(790.0f);
			victim.SetClearcooldown(true);
			return true;
		}
	}
	public class GSkill773 : GSkill
	{
		public GSkill773()
			: base(773)
		{
			
		}
	}
	public class GSkill774Stub : GSkillStub
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
		public GSkill774Stub()
			: base(774)
		{
			occupation = 129;
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
			name = "ºÏ»¶Ö®ÎÞÀäÈ´";
			nativename = "ºÏ»¶Ö®ÎÞÀäÈ´";
			icon = "²»»Ú.dds";
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
			return 1.000000f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetRatio(291.0f);
			victim.SetAmount(300.0f);
			victim.SetValue(299.0f);
			victim.SetClearcooldown(true);
			victim.SetRatio(302.0f);
			victim.SetAmount(307.0f);
			victim.SetValue(292.0f);
			victim.SetClearcooldown(true);
			victim.SetRatio(293.0f);
			victim.SetAmount(301.0f);
			victim.SetValue(530.0f);
			victim.SetClearcooldown(true);
			victim.SetRatio(531.0f);
			victim.SetAmount(770.0f);
			victim.SetValue(394.0f);
			victim.SetClearcooldown(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetRatio(289.0f);
			victim.SetAmount(780.0f);
			victim.SetValue(782.0f);
			victim.SetClearcooldown(true);
			return true;
		}
	}
	public class GSkill774 : GSkill
	{
		public GSkill774()
			: base(774)
		{
			
		}
	}
	public class GSkill775Stub : GSkillStub
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
				int				skill_level = skill.GetLevel();
				int				skill_t2 = skill.GetT2();
				int				skill_t3 = skill.GetT3();

				skill.SetRatio((skill_t3 * 0.01f + 1.2f));
				skill.SetPlus(((skill_t2 * 0.07000000000000001f + 1.0f) * ((skill_level * (skill_level * 9.9f)) - skill_level * 8.6f + 858.0f)));
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
				int				skill_level = skill.GetLevel();
				int				skill_t2 = skill.GetT2();
				int				skill_t3 = skill.GetT3();

				skill.SetRatio((skill_t3 * 0.02f + 1.2f));
				skill.SetPlus(((skill_t2 * 0.07000000000000001f + 1.0f) * ((skill_level * (skill_level * 9.9f)) - skill_level * 8.6f + 858.0f)));
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
				int				skill_level = skill.GetLevel();
				int				skill_t2 = skill.GetT2();
				int				skill_t3 = skill.GetT3();

				skill.SetRatio((skill_t3 * 0.03f + 1.2f));
				skill.SetPlus(((skill_t2 * 0.07000000000000001f + 1.0f) * ((skill_level * (skill_level * 9.9f)) - skill_level * 8.6f + 858.0f)));
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
				int				skill_level = skill.GetLevel();
				int				skill_t2 = skill.GetT2();
				int				skill_t3 = skill.GetT3();

				skill.SetRatio((skill_t3 * 0.04f + 1.2f));
				skill.SetPlus(((skill_t2 * 0.07000000000000001f + 1.0f) * ((skill_level * (skill_level * 9.9f)) - skill_level * 8.6f + 858.0f)));
				player.SetPerform(0);
			}
		}
		public GSkill775Stub()
			: base(775)
		{
			occupation = 14;
			maxlevel = 7;
			maxlearn = 6;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 1;
			timetype = 0;
			targettype = 0;
			rangetype = 3;
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
			SetAction(0,"¹íÍõ×Ú_Ä§»êÌìÖä");
			SetAction(1,"¹íÍõ×Ú_Ä§»êÌìÖä");
			SetAction(2,"¹íÍõ×Ú_Ä§»êÌìÖä");
			SetAction(3,"¹íÍõ×Ú_Ä§»êÌìÖä");
			SetAction(4,"¹íÍõ×Ú_Ä§»êÌìÖä");
			SetAction(5,"¹íÍõ×Ú_Ä§»êÌìÖä");
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
			SetAction(18,"¹íÍõ×Ú_Æï³Ë_Ä§»êÌìÖä");
			SetAction(19,"¹íÍõ×Ú_Æï³Ë_Ä§»êÌìÖä");
			SetAction(20,"¹íÍõ×Ú_Æï³Ë_Ä§»êÌìÖä");
			SetAction(21,"¹íÍõ×Ú_Æï³Ë_Ä§»êÌìÖä");
			SetAction(22,"¹íÍõ×Ú_Æï³Ë_Ä§»êÌìÖä");
			SetAction(23,"¹íÍõ×Ú_Æï³Ë_Ä§»êÌìÖä");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "Ä§»êÌìÖä";
			nativename = "Ä§»êÌìÖä";
			icon = "Ä§»êÌìÖä.dds";
			SetTalent(0,640);
			SetTalent(1,644);
			SetTalent(2,661);
			SetTalent(3,663);
			SetTalent(4,0);
			SetTalent(5,0);
			SetTalent(6,0);
			SetTalent(7,0);
			talent_size = 4;
			talent_type = 0;
			use_proficiency = false;
			inc_proficiency = 0;
			preskillnum = 1;
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
		}
		public override int GetExecutetime(GSkill skill)
		{
			return 2000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			int				skill_t2 = skill.GetT2();
			int				skill_t3 = skill.GetT3();

			return (-1350 * skill_t3) - 1350 * skill_t2 + 9000;
		}
		public override int GetEnmity(GSkill skill)
		{
			return 1;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={135,135,135,135,136,137};return array[level-1];
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
			int				skill_level = skill.GetLevel();

			return (5 * skill_level + 425);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();
			int				skill_t1 = skill.GetT1();

			victim.SetProbability(((6 * skill_t0 + 30)));
			victim.SetTime(((3000 * skill_t0 + 11100)));
			victim.SetRatio(((D2INT(zrand(100) / (100 - 6 * skill_t1)) + 1) * (skill_t1 * 0.03f + 0.11f)));
			victim.SetBuffid(3);
			victim.SetTiansha(true);
			victim.SetProbability(-1.0f);
			victim.SetTime(2000.0f);
			victim.SetBuffid(1);
			victim.SetAmount(((40 * skill_level + 160)));
			victim.SetValue(0.0f);
			victim.SetHpleak(true);
			return true;
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={24};return array[index];
		}
	}
	public class GSkill775 : GSkill
	{
		public GSkill775()
			: base(775)
		{
			
		}
	}
	public class GSkill776Stub : GSkillStub
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
		public GSkill776Stub()
			: base(776)
		{
			occupation = 14;
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
			SetAction(0,"¹íÍõ×Ú_¿ñÁé·´ÊÉ");
			SetAction(1,"¹íÍõ×Ú_¿ñÁé·´ÊÉ");
			SetAction(2,"¹íÍõ×Ú_¿ñÁé·´ÊÉ");
			SetAction(3,"¹íÍõ×Ú_¿ñÁé·´ÊÉ");
			SetAction(4,"¹íÍõ×Ú_¿ñÁé·´ÊÉ");
			SetAction(5,"¹íÍõ×Ú_¿ñÁé·´ÊÉ");
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
			SetAction(18,"¹íÍõ×Ú_Æï³Ë_¿ñÁé·´ÊÉ");
			SetAction(19,"¹íÍõ×Ú_Æï³Ë_¿ñÁé·´ÊÉ");
			SetAction(20,"¹íÍõ×Ú_Æï³Ë_¿ñÁé·´ÊÉ");
			SetAction(21,"¹íÍõ×Ú_Æï³Ë_¿ñÁé·´ÊÉ");
			SetAction(22,"¹íÍõ×Ú_Æï³Ë_¿ñÁé·´ÊÉ");
			SetAction(23,"¹íÍõ×Ú_Æï³Ë_¿ñÁé·´ÊÉ");
			SetAction(24,"");
			SetAction(25,"");
			SetAction(26,"");
			SetAction(27,"");
			SetAction(28,"");
			SetAction(29,"");
			SetAction(30,"");
			name = "¿ñÁé·´ÊÉ";
			nativename = "¿ñÁé·´ÊÉ";
			icon = "¿ñÁé·´ÊÉ.dds";
			SetTalent(0,647);
			SetTalent(1,662);
			SetTalent(2,666);
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
			int				skill_t1 = skill.GetT1();

			return 180000 - 18000 * skill_t1;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={135,136,136,138,139};return array[level-1];
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

			return (20 * skill_level + 660);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_maxmp = player.GetMaxmp();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();
			int				skill_t2 = skill.GetT2();

			victim.SetProbability(100.0f);
			victim.SetTime(((2000 * skill_t0 + 20100)));
			victim.SetRatio((skill_level * 0.1f));
			victim.SetAmount(0.0f);
			victim.SetValue(100.0f);
			victim.SetRetort(true);
			victim.SetTime(((3000 * skill_t2 + 10100)));
			victim.SetImmunesleep(true);
			victim.SetProbability(skill_t0 <= 0?0.0f:120.0f);
			victim.SetTime(((60000 * skill_t0)));
			victim.SetBuffid(1);
			victim.SetAmount((skill_t0 * 0.1f + 0.00001f));
			victim.SetValue((player_maxmp * (skill_t0 * 0.06f)));
			victim.SetAddhp2(true);
			victim.SetTime((((3000 * skill_t2 + 10100) * norm(skill_t2))));
			victim.SetImmunedizzy(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_maxhp = player.GetMaxhp();
			int				player_var1 = player.GetVar1();
			int				skill_t0 = skill.GetT0();

			/*
			if ( player_var1 <= 950 )
			{
			d = 0.0f;
			}
			else
			{
			d = (120 * norm(skill_t0 / 3.9f));
			}
			victim.SetProbability(d);
			victim.SetRatio(0.0f);
			victim.SetValue(player_maxhp);
			victim.SetHeal(true);
			*/
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={775};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={1};return array[index];
		}
	}
	public class GSkill776 : GSkill
	{
		public GSkill776()
			: base(776)
		{
			
		}
	}
	public class GSkill777Stub : GSkillStub
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
				int				skill_t0 = skill.GetT0();
				int				skill_t1 = skill.GetT1();
				int				skill_t3 = skill.GetT3();

				skill.SetCrit((skill_t0 * 0.02f));
				skill.SetRatio((skill_t1 * 0.07000000000000001f + 1.0f));
				skill.SetCrithurt((skill_t3 * 0.5f));
				skill.SetPlus(((skill_t3 * 0.3f + 1.0f) * ((100 * skill_level))));
				player.SetPerform(1);
			}
		}
		public GSkill777Stub()
			: base(777)
		{
			occupation = 14;
			maxlevel = 5;
			maxlearn = 4;
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
			SetAction(0,"¹íÍõ×Ú_»ÙÌìÃðµØ");
			SetAction(1,"¹íÍõ×Ú_»ÙÌìÃðµØ");
			SetAction(2,"¹íÍõ×Ú_»ÙÌìÃðµØ");
			SetAction(3,"¹íÍõ×Ú_»ÙÌìÃðµØ");
			SetAction(4,"¹íÍõ×Ú_»ÙÌìÃðµØ");
			SetAction(5,"¹íÍõ×Ú_»ÙÌìÃðµØ");
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
			SetAction(18,"¹íÍõ×Ú_Æï³Ë_»ÙÌìÃðµØ");
			SetAction(19,"¹íÍõ×Ú_Æï³Ë_»ÙÌìÃðµØ");
			SetAction(20,"¹íÍõ×Ú_Æï³Ë_»ÙÌìÃðµØ");
			SetAction(21,"¹íÍõ×Ú_Æï³Ë_»ÙÌìÃðµØ");
			SetAction(22,"¹íÍõ×Ú_Æï³Ë_»ÙÌìÃðµØ");
			SetAction(23,"¹íÍõ×Ú_Æï³Ë_»ÙÌìÃðµØ");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "»ÙÌìÃðµØ";
			nativename = "»ÙÌìÃðµØ";
			icon = "»ÙÌìÃðµØ.dds";
			SetTalent(0,628);
			SetTalent(1,633);
			SetTalent(2,645);
			SetTalent(3,668);
			SetTalent(4,0);
			SetTalent(5,0);
			SetTalent(6,0);
			SetTalent(7,0);
			talent_size = 4;
			talent_type = 0;
			use_proficiency = false;
			inc_proficiency = 0;
			preskillnum = 1;
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
			return 2000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			int				skill_t1 = skill.GetT1();

			return 20000 - 2000 * skill_t1;
		}
		public override int GetEnmity(GSkill skill)
		{
			return 1;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={135,135,136,138};return array[level-1];
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
			int				skill_level = skill.GetLevel();

			return (15 * skill_level + 950);
		}
		public override int GetCoverage(GSkill skill)
		{
			return 25;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();
			int				skill_t2 = skill.GetT2();

			victim.SetProbability(((15 * skill_t0 + 33)));
			victim.SetTime(20100.0f);
			victim.SetAssault(true);
			victim.SetProbability(-1.0f);
			victim.SetTime(2000.0f);
			victim.SetBuffid(1);
			victim.SetAmount(((D2INT(zrand(100) / (100 - 6 * skill_t2)) + 1) * ((skill_t2 * 0.8f + 1.0f) * ((120 * skill_level)))));
			victim.SetValue(0.0f);
			victim.SetHpleak5(true);
			return true;
		}
		public override float GetDropRate(GSkill skill)
		{
			return 0.500000f;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={776};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={1};return array[index];
		}
	}
	public class GSkill777 : GSkill
	{
		public GSkill777()
			: base(777)
		{
			
		}
	}
	public class GSkill778Stub : GSkillStub
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
				int				skill_level = skill.GetLevel();
				int				skill_t1 = skill.GetT1();
				int				skill_t3 = skill.GetT3();
				int				skill_t4 = skill.GetT4();
				int				skill_t5 = skill.GetT5();

				float a = (0.05f * skill_t1) + 1.22f;
				float ratio = 0.0f;
				if ( skill_t4 < skill_t5 )
				{
					if ( skill_t5 < player.GetSkilllevel(4530) )
					{
						ratio = player.GetSkilllevel(4530) * 0.04f + a;
					}
					else
					{
						ratio = skill_t5 * 0.04f + a;
					}
				}
				else
				{
					if ( skill_t4 < player.GetSkilllevel(4530) )
					{
						ratio = player.GetSkilllevel(4530) * 0.04f + a;
					}
					else
					{
						ratio = skill_t4 * 0.04f + a;
					}
				}
				skill.SetRatio(ratio);
				skill.SetPlus(((skill_t3 * 0.07000000000000001f + 1.0f) * ((7 * skill_level * skill_level + (30 * skill_level) + 720))));
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
				int				skill_level = skill.GetLevel();
				int				skill_t3 = skill.GetT3();
				int				skill_t4 = skill.GetT4();
				int				skill_t5 = skill.GetT5();

				float ratio = 0.0f;
				if ( skill_t4 < skill_t5 )
				{
					if ( skill_t5 < player.GetSkilllevel(4530) )
					{
						ratio = (0.04f * player.GetSkilllevel(4530)) + 1.22f;
					}
					else
					{
						ratio = (0.04f * skill_t5) + 1.22f;
					}
				}
				else
				{
					if ( skill_t4 < player.GetSkilllevel(4530) )
					{
						ratio = (0.04f * player.GetSkilllevel(4530)) + 1.22f;
					}
					else
					{
						ratio = (0.04f * skill_t4) + 1.22f;
					}
				}
				skill.SetRatio(ratio);
				skill.SetPlus(((skill_t3 * 0.07000000000000001f + 1.0f) * ((7 * skill_level * skill_level + (30 * skill_level) + 720))));
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
				int				skill_level = skill.GetLevel();
				int				skill_t3 = skill.GetT3();
				int				skill_t4 = skill.GetT4();
				int				skill_t5 = skill.GetT5();

				float ratio = 0.0f;
				if ( skill_t4 < skill_t5 )
				{
					if ( skill_t5 < player.GetSkilllevel(4530) )
					{
						ratio = (0.04f * player.GetSkilllevel(4530)) + 1.22f;
					}
					else
					{
						ratio = (0.04f * skill_t5) + 1.22f;
					}
				}
				else
				{
					if ( skill_t4 < player.GetSkilllevel(4530) )
					{
						ratio = (0.04f * player.GetSkilllevel(4530)) + 1.22f;
					}
					else
					{
						ratio = (0.04f * skill_t4) + 1.22f;
					}
				}
				skill.SetRatio(ratio);
				skill.SetPlus(((skill_t3 * 0.07000000000000001f + 1.0f) * ((7 * skill_level * skill_level + (30 * skill_level) + 720))));
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
				int				skill_level = skill.GetLevel();
				int				skill_t3 = skill.GetT3();
				int				skill_t4 = skill.GetT4();
				int				skill_t5 = skill.GetT5();

				float ratio = 0.0f;
				if ( skill_t4 < skill_t5 )
				{
					if ( skill_t5 < player.GetSkilllevel(4530) )
					{
						ratio = (0.04f * player.GetSkilllevel(4530)) + 1.22f;
					}
					else
					{
						ratio = (0.04f * skill_t5) + 1.22f;
					}
				}
				else
				{
					if ( skill_t4 < player.GetSkilllevel(4530) )
					{
						ratio = (0.04f * player.GetSkilllevel(4530)) + 1.22f;
					}
					else
					{
						ratio = (0.04f * skill_t4) + 1.22f;
					}
				}
				skill.SetRatio(ratio);
				skill.SetPlus(((skill_t3 * 0.07000000000000001f + 1.0f) * ((7 * skill_level * skill_level + (30 * skill_level) + 720))));
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
				int				skill_level = skill.GetLevel();
				int				skill_t3 = skill.GetT3();
				int				skill_t4 = skill.GetT4();
				int				skill_t5 = skill.GetT5();

				float ratio = 0.0f;
				if ( skill_t4 < skill_t5 )
				{
					if ( skill_t5 < player.GetSkilllevel(4530) )
					{
						ratio = (0.04f * player.GetSkilllevel(4530)) + 1.22f;
					}
					else
					{
						ratio = (0.04f * skill_t5) + 1.22f;
					}
				}
				else
				{
					if ( skill_t4 < player.GetSkilllevel(4530) )
					{
						ratio = (0.04f * player.GetSkilllevel(4530)) + 1.22f;
					}
					else
					{
						ratio = (0.04f * skill_t4) + 1.22f;
					}
				}
				skill.SetRatio(ratio);
				skill.SetPlus(((skill_t3 * 0.07000000000000001f + 1.0f) * ((7 * skill_level * skill_level + (30 * skill_level) + 720))));
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
				int				skill_level = skill.GetLevel();
				int				skill_t3 = skill.GetT3();
				int				skill_t4 = skill.GetT4();
				int				skill_t5 = skill.GetT5();

				float ratio = 0.0f;
				if ( skill_t4 < skill_t5 )
				{
					if ( skill_t5 < player.GetSkilllevel(4530) )
					{
						ratio = (0.04f * player.GetSkilllevel(4530)) + 1.37f;
					}
					else
					{
						ratio = (0.04f * skill_t5) + 1.37f;
					}
				}
				else
				{
					if ( skill_t4 < player.GetSkilllevel(4530) )
					{
						ratio = (0.04f * player.GetSkilllevel(4530)) + 1.37f;
					}
					else
					{
						ratio = (0.04f * skill_t4) + 1.37f;
					}
				}
				skill.SetRatio(ratio);
				skill.SetPlus(((skill_t3 * 0.07000000000000001f + 1.0f) * ((7 * skill_level * skill_level + (30 * skill_level) + 720))));
				player.SetPerform(0);
			}
		}
		public GSkill778Stub()
			: base(778)
		{
			occupation = 14;
			maxlevel = 3;
			maxlearn = 2;
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
			SetAction(0,"¹íÍõ×Ú_Î´ÃûÕ¶");
			SetAction(1,"¹íÍõ×Ú_Î´ÃûÕ¶");
			SetAction(2,"¹íÍõ×Ú_Î´ÃûÕ¶");
			SetAction(3,"¹íÍõ×Ú_Î´ÃûÕ¶");
			SetAction(4,"¹íÍõ×Ú_Î´ÃûÕ¶");
			SetAction(5,"¹íÍõ×Ú_Î´ÃûÕ¶");
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
			SetAction(18,"¹íÍõ×Ú_Æï³Ë_Î´ÃûÕ¶");
			SetAction(19,"¹íÍõ×Ú_Æï³Ë_Î´ÃûÕ¶");
			SetAction(20,"¹íÍõ×Ú_Æï³Ë_Î´ÃûÕ¶");
			SetAction(21,"¹íÍõ×Ú_Æï³Ë_Î´ÃûÕ¶");
			SetAction(22,"¹íÍõ×Ú_Æï³Ë_Î´ÃûÕ¶");
			SetAction(23,"¹íÍõ×Ú_Æï³Ë_Î´ÃûÕ¶");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "Î´ÃûÕ¶";
			nativename = "Î´ÃûÕ¶";
			icon = "Î´ÃûÕ¶.dds";
			SetTalent(0,624);
			SetTalent(1,629);
			SetTalent(2,650);
			SetTalent(3,661);
			SetTalent(4,2947);
			SetTalent(5,4112);
			SetTalent(6,4530);
			SetTalent(7,0);
			talent_size = 7;
			talent_type = 0;
			use_proficiency = false;
			inc_proficiency = 0;
			preskillnum = 1;
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
		}
		public override int GetExecutetime(GSkill skill)
		{
			return 3000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			int				skill_t1 = skill.GetT1();
			int				skill_t3 = skill.GetT3();

			return (-2000 * skill_t1) - 2250 * skill_t3 + 15000;
		}
		public override int GetEnmity(GSkill skill)
		{
			return 1;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={139,141};return array[level-1];
		}
		public override float GetPraydistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			int				skill_t4 = skill.GetT4();
			int				skill_t5 = skill.GetT5();

			return (3 * (norm(player.GetSkilllevel(4530) / 5) + (norm(skill_t5 / 5) + (norm(skill_t4 / 5)))) + 9);
		}
		public override float GetCastdistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			int				skill_t4 = skill.GetT4();
			int				skill_t5 = skill.GetT5();

			return ((3 * (norm(player.GetSkilllevel(4530) / 5) + (norm(skill_t5 / 5) + (norm(skill_t4 / 5))))) + 1.7f);
		}
		public override float GetEffectdistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			int				skill_t4 = skill.GetT4();
			int				skill_t5 = skill.GetT5();

			return (skill_t4 < skill_t5)?((skill_t5 < player.GetSkilllevel(4530))?((0.6f * player.GetSkilllevel(4530)) + 12.0f):(0.6f * skill_t5) + 12.0f):((skill_t4 < player.GetSkilllevel(4530))?((0.6f * player.GetSkilllevel(4530)) + 12.0f):((0.6f * skill_t4) + 12.0f))/**/;
		}
		public override float GetMpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (8 * skill_level + (skill_level * skill_level) + 580);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_level = player.GetLevel();
			int				player_maxhp = player.GetMaxhp();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();

			victim.SetProbability(((9 * skill_t0 * skill_level + (15 * skill_level) + 210)));
			victim.SetTime(6100.0f);
			victim.SetRatio((skill_t0 * 0.05f + 0.3f));
			victim.SetBuffid(1);
			victim.SetWeak(true);
			victim.SetProbability(((1.0f - player_level * 0.002f) * 33.0f));
			victim.SetTime(6000.0f);
			victim.SetBuffid(1);
			victim.SetAmount((player_maxhp * (skill_level * 0.1f)));
			victim.SetValue(0.0f);
			victim.SetMpleak(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_t2 = skill.GetT2();
			int				skill_t4 = skill.GetT4();

			/*
			victim.SetProbability(((15 * skill_t2 + 33)));
			victim.SetTime(8100.0f);
			if ( skill_t4 < player.GetSkilllevel(4112) )
			{
			if ( player.GetSkilllevel(4112) < player.GetSkilllevel(4530) )
			{
			v19 = (0.03f * player.GetSkilllevel(4530)) + 0.3f;
			}
			else
			{
			v19 = (0.03f * player.GetSkilllevel(4112)) + 0.3f;
			}
			v21 = v19;
			}
			else
			{
			if ( skill_t4 < player.GetSkilllevel(4530) )
			{
			v20 = (0.03f * player.GetSkilllevel(4530)) + 0.3f;
			}
			else
			{
			v20 = (0.03f * skill_t4) + 0.3f;
			}
			v21 = v20;
			}
			victim.SetRatio(v21);
			victim.SetDecdamage(true);
			*/
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={775};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={3};return array[index];
		}
	}
	public class GSkill778 : GSkill
	{
		public GSkill778()
			: base(778)
		{
			
		}
	}
	public class GSkill779Stub : GSkillStub
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
				int				skill_t1 = skill.GetT1();
				int				skill_t3 = skill.GetT3();

				skill.SetCrit(0.050000001f);
				skill.SetRatio((skill_t1 * 0.05f + 1.33f));
				skill.SetPlus(((2 * skill_level * skill_level + (50 * skill_level + (35 * skill_level * skill_t3)) + 980)));
				player.SetPerform(1);
			}
		}
		public GSkill779Stub()
			: base(779)
		{
			occupation = 17;
			maxlevel = 7;
			maxlearn = 6;
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
			SetAction(0,"ºÏ»¶ÅÉ_¾ÉÃÎ");
			SetAction(1,"ºÏ»¶ÅÉ_¾ÉÃÎ");
			SetAction(2,"ºÏ»¶ÅÉ_¾ÉÃÎ");
			SetAction(3,"ºÏ»¶ÅÉ_¾ÉÃÎ");
			SetAction(4,"ºÏ»¶ÅÉ_¾ÉÃÎ");
			SetAction(5,"ºÏ»¶ÅÉ_¾ÉÃÎ");
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
			SetAction(18,"ºÏ»¶ÅÉ_Æï³Ë_¾ÉÃÎ");
			SetAction(19,"ºÏ»¶ÅÉ_Æï³Ë_¾ÉÃÎ");
			SetAction(20,"ºÏ»¶ÅÉ_Æï³Ë_¾ÉÃÎ");
			SetAction(21,"ºÏ»¶ÅÉ_Æï³Ë_¾ÉÃÎ");
			SetAction(22,"ºÏ»¶ÅÉ_Æï³Ë_¾ÉÃÎ");
			SetAction(23,"ºÏ»¶ÅÉ_Æï³Ë_¾ÉÃÎ");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "¾ÉÃÎ";
			nativename = "¾ÉÃÎ";
			icon = "¾ÉÃÎ.dds";
			SetTalent(0,724);
			SetTalent(1,732);
			SetTalent(2,743);
			SetTalent(3,765);
			SetTalent(4,0);
			SetTalent(5,0);
			SetTalent(6,0);
			SetTalent(7,0);
			talent_size = 4;
			talent_type = 0;
			use_proficiency = false;
			inc_proficiency = 0;
			preskillnum = 1;
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
		public override int GetEnmity(GSkill skill)
		{
			return 1;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={135,135,135,135,136,137};return array[level-1];
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 8.000000f;
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
			int				skill_level = skill.GetLevel();

			return (skill_level * 1.7f + (skill_level * (skill_level * 1.1f)) + 360.0f);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_level = player.GetLevel();
			int				skill_level = skill.GetLevel();
			int				skill_t2 = skill.GetT2();
			int				skill_t3 = skill.GetT3();

			victim.SetProbability(((1.0f - player_level * 0.002f) * ((8 * skill_t2 + 60))));
			victim.SetRatio(((D2INT(zrand(100) / (100 - 4 * skill_t2)) + 1) * 0.48f));
			victim.SetDrainmagic(true);
			victim.SetProbability(((5 * skill_t3 + (3 * skill_level) + 10)));
			victim.SetAmount((((skill_level / 6.5f) + 2)));
			victim.SetClearbuff(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_maxhp = player.GetMaxhp();
			int				skill_t0 = skill.GetT0();

			victim.SetProbability(((8 * skill_t0)));
			victim.SetRatio(0.0f);
			victim.SetValue((player_maxhp * (skill_t0 * 0.02f)));
			victim.SetHeal(true);
			victim.SetProbability(120.0f);
			victim.SetRatio(293.0f);
			victim.SetBuffid(0);
			victim.SetAmount(0.0f);
			victim.SetValue(2000.0f);
			victim.SetReduceskillcd(true);
			return true;
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={24};return array[index];
		}
	}
	public class GSkill779 : GSkill
	{
		public GSkill779()
			: base(779)
		{
			
		}
	}
}
