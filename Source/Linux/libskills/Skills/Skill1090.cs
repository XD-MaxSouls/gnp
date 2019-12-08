using System;
using System.Text;

namespace SKILL
{
	public class GSkill1090Stub : GSkillStub
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
		public GSkill1090Stub()
			: base(1090)
		{
			occupation = 128;
			maxlevel = 9999;
			maxlearn = 10;
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
			name = "Ñ©ÈËÈº¼ÓÑª×çÖä";
			nativename = "Ñ©ÈËÈº¼ÓÑª×çÖä";
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
		public override int GetCoverage(GSkill skill)
		{
			return 40;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();

			victim.SetProbability(100.0f);
			victim.SetRatio(0.0f);
			victim.SetValue(((200 * skill_level)));
			victim.SetHeal(true);
			return true;
		}
	}
	public class GSkill1090 : GSkill
	{
		public GSkill1090()
			: base(1090)
		{
			
		}
	}
	public class GSkill1091Stub : GSkillStub
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
				int				skill_level = skill.GetLevel();

				skill.SetRatio((skill_level * 0.01f + 0.99f));
				player.SetPerform(1);
			}
		}
		public GSkill1091Stub()
			: base(1091)
		{
			occupation = 128;
			maxlevel = 9999;
			maxlearn = 10;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 1;
			timetype = 0;
			targettype = 0;
			rangetype = 2;
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
			name = "Ñ©ÈËÈº¹¥";
			nativename = "Ñ©ÈËÈº¹¥";
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
		public override int GetCoverage(GSkill skill)
		{
			return 40;
		}
	}
	public class GSkill1091 : GSkill
	{
		public GSkill1091()
			: base(1091)
		{
			
		}
	}
	public class GSkill1092Stub : GSkillStub
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
				int				skill_level = skill.GetLevel();

				skill.SetRatio((skill_level * 0.01f + 0.99f));
				player.SetPerform(1);
			}
		}
		public GSkill1092Stub()
			: base(1092)
		{
			occupation = 128;
			maxlevel = 9999;
			maxlearn = 10;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 1;
			timetype = 0;
			targettype = 0;
			rangetype = 3;
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
			name = "Ñ©ÈËBOSSÈº¹¥";
			nativename = "Ñ©ÈËBOSSÈº¹¥";
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
			return 15.000000f;
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
		public override int GetCoverage(GSkill skill)
		{
			return 40;
		}
	}
	public class GSkill1092 : GSkill
	{
		public GSkill1092()
			: base(1092)
		{
			
		}
	}
	public class GSkill1093Stub : GSkillStub
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
				int				player_skilldodge = player.GetSkilldodge();
				int				skill_level = skill.GetLevel();
				int				skill_t0 = skill.GetT0();

				player.SetVar1(player_skilldodge);
				skill.SetRatio(1.0f);
				skill.SetPlus(((skill_level * 9.4f + (skill_level * (skill_level * 0.6f)) - 12.0f) * (D2INT(skill_level * 0.05f + 0.55f)) + ((skill_level * 5.3f + (skill_level * (skill_level * 0.014f)) + 58.0f) * (D2INT(1.42f - skill_level * 0.05f)) + ((8 * skill_level * skill_t0)))));
				player.SetPerform(1);
			}
		}
		public GSkill1093Stub()
			: base(1093)
		{
			occupation = 25;
			maxlevel = 20;
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
			autoattack = true;
			allowform = 1;
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
			SetAction(0,"¹íµÀ_ÌÞ¹ÇÐ×ÑÀ");
			SetAction(1,"¹íµÀ_ÌÞ¹ÇÐ×ÑÀ");
			SetAction(2,"¹íµÀ_ÌÞ¹ÇÐ×ÑÀ");
			SetAction(3,"¹íµÀ_ÌÞ¹ÇÐ×ÑÀ");
			SetAction(4,"¹íµÀ_ÌÞ¹ÇÐ×ÑÀ");
			SetAction(5,"¹íµÀ_ÌÞ¹ÇÐ×ÑÀ");
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
			SetAction(18,"¹íµÀ_Æï³Ë_ÌÞ¹ÇÐ×ÑÀ");
			SetAction(19,"¹íµÀ_Æï³Ë_ÌÞ¹ÇÐ×ÑÀ");
			SetAction(20,"¹íµÀ_Æï³Ë_ÌÞ¹ÇÐ×ÑÀ");
			SetAction(21,"¹íµÀ_Æï³Ë_ÌÞ¹ÇÐ×ÑÀ");
			SetAction(22,"¹íµÀ_Æï³Ë_ÌÞ¹ÇÐ×ÑÀ");
			SetAction(23,"¹íµÀ_Æï³Ë_ÌÞ¹ÇÐ×ÑÀ");
			SetAction(24,"");
			SetAction(25,"");
			SetAction(26,"");
			SetAction(27,"");
			SetAction(28,"");
			SetAction(29,"");
			SetAction(30,"");
			name = "ÌÞ¹ÇÐ×ÑÀ";
			nativename = "ÌÞ¹ÇÐ×ÑÀ";
			icon = "ÌÞ¹ÇÐ×ÑÀ.dds";
			SetTalent(0,1139);
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
			return 2000;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={15,17,19,21,23,25,27,29,32};return array[level-1];
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
			return 10.000000f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_t0 = skill.GetT0();

			victim.SetProbability(((33 * norm(skill_t0))));
			victim.SetTime(6100.0f);
			victim.SetBuffid(6);
			victim.SetValue(((5 * skill_t0)));
			victim.SetSubattack(true);
			return true;
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={8};return array[index];
		}
	}
	public class GSkill1093 : GSkill
	{
		public GSkill1093()
			: base(1093)
		{
			
		}
	}
	public class GSkill1094Stub : GSkillStub
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
		public GSkill1094Stub()
			: base(1094)
		{
			occupation = 25;
			maxlevel = 12;
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
			allowform = 7;
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
			SetAction(0,"¹íµÀ_°Ù¹íÒ¹ÐÐ");
			SetAction(1,"¹íµÀ_°Ù¹íÒ¹ÐÐ");
			SetAction(2,"¹íµÀ_°Ù¹íÒ¹ÐÐ");
			SetAction(3,"¹íµÀ_°Ù¹íÒ¹ÐÐ");
			SetAction(4,"¹íµÀ_°Ù¹íÒ¹ÐÐ");
			SetAction(5,"¹íµÀ_°Ù¹íÒ¹ÐÐ");
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
			SetAction(18,"¹íµÀ_Æï³Ë_°Ù¹íÒ¹ÐÐ");
			SetAction(19,"¹íµÀ_Æï³Ë_°Ù¹íÒ¹ÐÐ");
			SetAction(20,"¹íµÀ_Æï³Ë_°Ù¹íÒ¹ÐÐ");
			SetAction(21,"¹íµÀ_Æï³Ë_°Ù¹íÒ¹ÐÐ");
			SetAction(22,"¹íµÀ_Æï³Ë_°Ù¹íÒ¹ÐÐ");
			SetAction(23,"¹íµÀ_Æï³Ë_°Ù¹íÒ¹ÐÐ");
			SetAction(24,"");
			SetAction(25,"");
			SetAction(26,"");
			SetAction(27,"");
			SetAction(28,"");
			SetAction(29,"");
			SetAction(30,"");
			name = "°Ù¹íÒ¹ÐÐ";
			nativename = "°Ù¹íÒ¹ÐÐ";
			icon = "°Ù¹íÒ¹ÐÐ.dds";
			SetTalent(0,1156);
			SetTalent(1,1168);
			SetTalent(2,1170);
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
			int				skill_t1 = skill.GetT1();

			return 120000 - 12000 * skill_t1;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={16,18,19,22,25};return array[level-1];
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

			return player_range;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();
			int				skill_t2 = skill.GetT2();

			victim.SetProbability(100.0f);
			victim.SetTime((((2000 * (skill_t2 + skill_level) + 10100) * (norm(zrand(100) / (100 - 10 * skill_t2)) + 1))));
			victim.SetBuffid(1);
			victim.SetValue(((skill_t0 * 0.8f + 1.0f) * (skill_level * 0.4f + 0.2f)));
			victim.SetAddspeed(true);
			victim.SetTime((((2000 * (skill_t2 + skill_level) + 10100) * (norm(zrand(100) / (100 - 10 * skill_t2)) + 1))));
			victim.SetBuffid(1);
			victim.SetValue(((4 * (skill_level * skill_t0 + skill_level))));
			victim.SetAddanti(true);
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={1093};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={1};return array[index];
		}
	}
	public class GSkill1094 : GSkill
	{
		public GSkill1094()
			: base(1094)
		{
			
		}
	}
	public class GSkill1095Stub : GSkillStub
	{
		public GSkill1095Stub()
			: base(1095)
		{
			occupation = 25;
			maxlevel = 5;
			maxlearn = 5;
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
			name = "¶ÝÓ°Âþ³¾";
			nativename = "¶ÝÓ°Âþ³¾";
			icon = "¶ÝÓ°Âþ³¾.dds";
			SetTalent(0,1147);
			SetTalent(1,1173);
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
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={16,18,20,22,24};return array[level-1];
		}
		public override bool TakeEffect(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();
			int				skill_t1 = skill.GetT1();

			player.SetPasaddhp(((10 * skill_level)));
			player.SetPasadddodge(((skill_level * skill_t1 + (2 * skill_level))));
			player.SetPasaddsleep(((skill_level * skill_t1 + (2 * skill_level))));
			player.SetPasadddefence(((5 * skill_t0 * skill_level)));
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={1093};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={1};return array[index];
		}
	}
	public class GSkill1095 : GSkill
	{
		public GSkill1095()
			: base(1095)
		{
			
		}
	}
	public class GSkill1096Stub : GSkillStub
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
				int				skill_t2 = skill.GetT2();

				skill.SetRatio(1.0f);
				skill.SetCrit((skill_t2 * 0.01f));
				skill.SetCrithurt((skill_t2 * 0.1f));
				skill.SetPlus(((skill_t0 * 0.15f + 1.0f) * ((((skill_level * skill_level)) - skill_level * 7.4f + 76.0f) * (D2INT(skill_level * 0.05f + 0.55f)) + ((skill_level * 2.4f + (skill_level * (skill_level * 0.35f)) + 42.0f) * (D2INT(1.42f - skill_level * 0.05f))))));
				player.SetPerform(1);
			}
		}
		public GSkill1096Stub()
			: base(1096)
		{
			occupation = 25;
			maxlevel = 20;
			maxlearn = 9;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 1;
			timetype = 0;
			targettype = 0;
			rangetype = 4;
			doenchant = false;
			dobless = false;
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
			SetAction(0,"¹íµÀ_»¯¹Ç¶¾ÕÎ");
			SetAction(1,"¹íµÀ_»¯¹Ç¶¾ÕÎ");
			SetAction(2,"¹íµÀ_»¯¹Ç¶¾ÕÎ");
			SetAction(3,"¹íµÀ_»¯¹Ç¶¾ÕÎ");
			SetAction(4,"¹íµÀ_»¯¹Ç¶¾ÕÎ");
			SetAction(5,"¹íµÀ_»¯¹Ç¶¾ÕÎ");
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
			SetAction(18,"¹íµÀ_Æï³Ë_»¯¹Ç¶¾ÕÎ");
			SetAction(19,"¹íµÀ_Æï³Ë_»¯¹Ç¶¾ÕÎ");
			SetAction(20,"¹íµÀ_Æï³Ë_»¯¹Ç¶¾ÕÎ");
			SetAction(21,"¹íµÀ_Æï³Ë_»¯¹Ç¶¾ÕÎ");
			SetAction(22,"¹íµÀ_Æï³Ë_»¯¹Ç¶¾ÕÎ");
			SetAction(23,"¹íµÀ_Æï³Ë_»¯¹Ç¶¾ÕÎ");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "»¯¹Ç¶¾É°";
			nativename = "»¯¹Ç¶¾É°";
			icon = "»¯¹Ç¶¾É°.dds";
			SetTalent(0,1141);
			SetTalent(1,1151);
			SetTalent(2,1155);
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
			int				skill_t1 = skill.GetT1();

			return 6000 - 900 * skill_t1;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={20,22,24,26,28,30,32,34,36};return array[level-1];
		}
		public override float GetRadius(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (skill_level * 0.2f + 5.8f);
		}
		public override float GetAngle(GSkill skill)
		{
			return -0.333332f;
		}
		public override float GetPraydistance(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (skill_level * 0.2f + 5.8f);
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 3.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return ((5 * skill_level) + (skill_level * (skill_level * 0.2f)) + 40.0f);
		}
		public override int GetCoverage(GSkill skill)
		{
			return 8;
		}
		public override float GetDropRate(GSkill skill)
		{
			return 0.160000f;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={1093};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={3};return array[index];
		}
	}
	public class GSkill1096 : GSkill
	{
		public GSkill1096()
			: base(1096)
		{
			
		}
	}
	public class GSkill1097Stub : GSkillStub
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
		public GSkill1097Stub()
			: base(1097)
		{
			occupation = 25;
			maxlevel = 12;
			maxlearn = 8;
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
			SetAction(0,"±äÉí");
			SetAction(1,"±äÉí");
			SetAction(2,"±äÉí");
			SetAction(3,"±äÉí");
			SetAction(4,"±äÉí");
			SetAction(5,"±äÉí");
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
			name = "Ä§»ê×ËÌ¬";
			nativename = "Ä§»ê×ËÌ¬";
			icon = "Ä§»êÐÎÌ¬.dds";
			SetTalent(0,1140);
			SetTalent(1,1158);
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
		}
		public override int GetExecutetime(GSkill skill)
		{
			return 10;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			int				skill_t0 = skill.GetT0();

			return 12500 - 3000 * skill_t0;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={25,45,65,85,105,125,125,125};return array[level-1];
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
			int				skill_t1 = skill.GetT1();

			victim.SetProbability(((skill_t1 * 0.15f + 1.0f) * ((120 * skill_level * skill_level + (90 * skill_level)))));
			victim.SetRatio(((15 * skill_level)));
			victim.SetBuffid(0);
			victim.SetAmount(((11 * skill_level - 93)));
			victim.SetValue(((15 * skill_level)));
			victim.SetGhostform(true);
			victim.SetProbability(120.0f);
			victim.SetTime(((6000 * skill_t1)));
			victim.SetRatio((skill_t1 * 0.15f));
			victim.SetNingjin(true);
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={1095};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={4};return array[index];
		}
	}
	public class GSkill1097 : GSkill
	{
		public GSkill1097()
			: base(1097)
		{
			
		}
	}
	public class GSkill1098Stub : GSkillStub
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
		public GSkill1098Stub()
			: base(1098)
		{
			occupation = 25;
			maxlevel = 20;
			maxlearn = 9;
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
			allowform = 7;
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
			SetAction(0,"¹íµÀ_Ä§ÔªÐ°Öä");
			SetAction(1,"¹íµÀ_Ä§ÔªÐ°Öä");
			SetAction(2,"¹íµÀ_Ä§ÔªÐ°Öä");
			SetAction(3,"¹íµÀ_Ä§ÔªÐ°Öä");
			SetAction(4,"¹íµÀ_Ä§ÔªÐ°Öä");
			SetAction(5,"¹íµÀ_Ä§ÔªÐ°Öä");
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
			SetAction(18,"¹íµÀ_Æï³Ë_Ä§ÔªÐ°Öä");
			SetAction(19,"¹íµÀ_Æï³Ë_Ä§ÔªÐ°Öä");
			SetAction(20,"¹íµÀ_Æï³Ë_Ä§ÔªÐ°Öä");
			SetAction(21,"¹íµÀ_Æï³Ë_Ä§ÔªÐ°Öä");
			SetAction(22,"¹íµÀ_Æï³Ë_Ä§ÔªÐ°Öä");
			SetAction(23,"¹íµÀ_Æï³Ë_Ä§ÔªÐ°Öä");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "Ä§ÔªÐ°Öä";
			nativename = "Ä§ÔªÐ°Öä";
			icon = "Ä§ÔªÐ°Öä.dds";
			SetTalent(0,1175);
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
			return 6000;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={25,30,35,40,45,50,55,60,65};return array[level-1];
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
			int				skill_t0 = skill.GetT0();

			victim.SetTime(((600000 * skill_t0 + 600000)));
			victim.SetBuffid(2);
			victim.SetValue(((skill_t0 * 0.1f + 1.0f) * ((6 * skill_level * skill_level + (120 * skill_level) + 60))));
			victim.SetAddmp(true);
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={1094};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={4};return array[index];
		}
	}
	public class GSkill1098 : GSkill
	{
		public GSkill1098()
			: base(1098)
		{
			
		}
	}
	public class GSkill1099Stub : GSkillStub
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
				int				skill_level = skill.GetLevel();
				int				skill_t0 = skill.GetT0();
				int				skill_t3 = skill.GetT3();

				skill.SetRatio((skill_t3 * 0.05f + 1.0f));
				skill.SetPlus((((13 * skill_level) + (skill_level * (skill_level * 0.99f)) + 2.2f) * (D2INT(skill_level * 0.05f + 0.55f)) + (((D2INT(1.42f - skill_level * 0.05f)) * (13 * skill_level + 72)) + ((4 * skill_t0 * skill_level) + ((player_mp + player_hp) * 0.01f)))));
				player.SetPerform(1);
			}
		}
		public GSkill1099Stub()
			: base(1099)
		{
			occupation = 25;
			maxlevel = 20;
			maxlearn = 10;
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
			allowform = 2;
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
			SetAction(0,"ÓÄ»êÀû×¦");
			SetAction(1,"ÓÄ»êÀû×¦");
			SetAction(2,"ÓÄ»êÀû×¦");
			SetAction(3,"ÓÄ»êÀû×¦");
			SetAction(4,"ÓÄ»êÀû×¦");
			SetAction(5,"ÓÄ»êÀû×¦");
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
			SetAction(18,"ÓÄ»êÀû×¦");
			SetAction(19,"ÓÄ»êÀû×¦");
			SetAction(20,"ÓÄ»êÀû×¦");
			SetAction(21,"ÓÄ»êÀû×¦");
			SetAction(22,"ÓÄ»êÀû×¦");
			SetAction(23,"ÓÄ»êÀû×¦");
			SetAction(24,"");
			SetAction(25,"");
			SetAction(26,"");
			SetAction(27,"");
			SetAction(28,"");
			SetAction(29,"");
			SetAction(30,"");
			name = "ÓÄ»êÀû×¦";
			nativename = "ÓÄ»êÀû×¦";
			icon = "ÓÄ»êÀû×¦.dds";
			SetTalent(0,1159);
			SetTalent(1,1163);
			SetTalent(2,1167);
			SetTalent(3,1172);
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
			return 6000;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={25,27,29,31,33,35,37,39,42,46};return array[level-1];
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
			int				skill_level = skill.GetLevel();

			return (2 * skill_level + 10);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();
			int				skill_t1 = skill.GetT1();
			int				skill_t2 = skill.GetT2();

			victim.SetProbability(((4 * skill_t2 * skill_level) + (skill_level * 5.5f + 45.0f)));
			victim.SetTime(((3000 * skill_t1 + (500 * skill_level) + 1600)));
			victim.SetRatio((skill_level * 0.03f + 0.07000000000000001f));
			victim.SetBuffid(2);
			victim.SetWeak(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();

			victim.SetProbability(((15 * skill_t0)));
			victim.SetRatio(0.0f);
			victim.SetValue(((skill_level * skill_level + (5 * skill_level) + 40) * 0.5f));
			victim.SetHeal(true);
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={1097};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={1};return array[index];
		}
	}
	public class GSkill1099 : GSkill
	{
		public GSkill1099()
			: base(1099)
		{
			
		}
	}
}
