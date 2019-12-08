using System;
using System.Text;

namespace SKILL
{
	public class GSkill250Stub : GSkillStub
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
				int				player_hp = player.GetHp();
				int				skill_level = skill.GetLevel();
				int				skill_t0 = skill.GetT0();
				int				skill_t3 = skill.GetT3();

				skill.SetRatio((skill_t3 * 0.04f + 1.0f));
				player.SetHp((((norm(player_hp / 20)) * (player_hp - 20) + 1)));
				skill.SetPlus(((skill_t0 * 0.08f + 1.0f) * (((((67 * skill_level + 59)) - skill_level * (skill_level * 0.14f)) * (D2INT(skill_level * 0.05f + 0.55f)) + (((12 * skill_level) + (skill_level * (skill_level * 0.058f)) + 443.0f) * (D2INT(1.42f - skill_level * 0.05f)))) * (norm((player_hp / 20))) + 1.0f)));
				player.SetPerform(1);
			}
		}
		public GSkill250Stub()
			: base(250)
		{
			occupation = 2;
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
			SetAction(0,"¹íÍõ×Ú_·ÙÐÄÕ¶");
			SetAction(1,"¹íÍõ×Ú_·ÙÐÄÕ¶");
			SetAction(2,"¹íÍõ×Ú_·ÙÐÄÕ¶");
			SetAction(3,"¹íÍõ×Ú_·ÙÐÄÕ¶");
			SetAction(4,"¹íÍõ×Ú_·ÙÐÄÕ¶");
			SetAction(5,"¹íÍõ×Ú_·ÙÐÄÕ¶");
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
			SetAction(18,"¹íÍõ×Ú_Æï³Ë_·ÙÐÄÕ¶");
			SetAction(19,"¹íÍõ×Ú_Æï³Ë_·ÙÐÄÕ¶");
			SetAction(20,"¹íÍõ×Ú_Æï³Ë_·ÙÐÄÕ¶");
			SetAction(21,"¹íÍõ×Ú_Æï³Ë_·ÙÐÄÕ¶");
			SetAction(22,"¹íÍõ×Ú_Æï³Ë_·ÙÐÄÕ¶");
			SetAction(23,"¹íÍõ×Ú_Æï³Ë_·ÙÐÄÕ¶");
			SetAction(24,"");
			SetAction(25,"");
			SetAction(26,"");
			SetAction(27,"");
			SetAction(28,"");
			SetAction(29,"");
			SetAction(30,"");
			name = "·ÙÐÄÕ¶";
			nativename = "·ÙÐÄÕ¶";
			icon = "·ÙÐÄÕ¶.dds";
			SetTalent(0,630);
			SetTalent(1,640);
			SetTalent(2,644);
			SetTalent(3,660);
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
			return 2000;
		}
		public override int GetEnmity(GSkill skill)
		{
			return 1;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={60,62,64,66,68,70,72,74,76};return array[level-1];
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
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_t1 = skill.GetT1();
			int				skill_t2 = skill.GetT2();

			victim.SetProbability(((6 * skill_t1 + 15)));
			victim.SetTime(((3000 * skill_t1 + 6100)));
			victim.SetRatio(((D2INT(zrand(100) / (100 - 6 * skill_t2)) + 1) * (skill_t2 * 0.03f + 0.05f)));
			victim.SetBuffid(3);
			victim.SetTiansha(true);
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={258};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={5};return array[index];
		}
	}
	public class GSkill250 : GSkill
	{
		public GSkill250()
			: base(250)
		{
			
		}
	}
	public class GSkill251Stub : GSkillStub
	{
		public GSkill251Stub()
			: base(251)
		{
			occupation = 1;
			maxlevel = 15;
			maxlearn = 8;
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
			name = "ºñÍÁÖä";
			nativename = "ºñÍÁÖä";
			icon = "ºñÍÁÖä.dds";
			SetTalent(0,653);
			SetTalent(1,657);
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
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={20,22,24,26,28,30,32,34};return array[level-1];
		}
		public override bool TakeEffect(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			int				player_level = player.GetLevel();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();
			int				skill_t1 = skill.GetT1();

			player.SetPasinchp((D2INT(skill_level / 8) * 0.02001f + (skill_level * 0.01001f)));
			player.SetPasinchpgen((skill_level * (skill_t0 * 0.05f)));
			player.SetPasaddsmite((skill_level * (skill_t1 * 0.02f)));
			player.SetPasaddhp(((2 * skill_t0 * player_level)));
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={244};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={3};return array[index];
		}
	}
	public class GSkill251 : GSkill
	{
		public GSkill251()
			: base(251)
		{
			
		}
	}
	public class GSkill252Stub : GSkillStub
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
				int				skill_level = skill.GetLevel();
				int				skill_t3 = skill.GetT3();

				skill.SetRatio((skill_t3 * 0.05f + (skill_level * 0.02f + 0.31f)));
				skill.SetCrithurt((skill_t3 * 0.5f));
				skill.SetPlus((player_level * (skill_t3 * 0.2f)));
				player.SetPerform(1);
			}
		}
		public GSkill252Stub()
			: base(252)
		{
			occupation = 1;
			maxlevel = 20;
			maxlearn = 9;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 1;
			timetype = 0;
			targettype = 0;
			rangetype = 4;
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
			SetAction(0,"¹íÍõ×Ú_º®±ùÈÐ");
			SetAction(1,"¹íÍõ×Ú_º®±ùÈÐ");
			SetAction(2,"¹íÍõ×Ú_º®±ùÈÐ");
			SetAction(3,"¹íÍõ×Ú_º®±ùÈÐ");
			SetAction(4,"¹íÍõ×Ú_º®±ùÈÐ");
			SetAction(5,"¹íÍõ×Ú_º®±ùÈÐ");
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
			SetAction(18,"¹íÍõ×Ú_Æï³Ë_º®±ùÈÐ");
			SetAction(19,"¹íÍõ×Ú_Æï³Ë_º®±ùÈÐ");
			SetAction(20,"¹íÍõ×Ú_Æï³Ë_º®±ùÈÐ");
			SetAction(21,"¹íÍõ×Ú_Æï³Ë_º®±ùÈÐ");
			SetAction(22,"¹íÍõ×Ú_Æï³Ë_º®±ùÈÐ");
			SetAction(23,"¹íÍõ×Ú_Æï³Ë_º®±ùÈÐ");
			SetAction(24,"");
			SetAction(25,"");
			SetAction(26,"");
			SetAction(27,"");
			SetAction(28,"");
			SetAction(29,"");
			SetAction(30,"");
			name = "º®±ùÈÐ";
			nativename = "º®±ùÈÐ";
			icon = "º®±ùÈÐ.dds";
			SetTalent(0,622);
			SetTalent(1,638);
			SetTalent(2,665);
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
			return 1000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			int				skill_t2 = skill.GetT2();

			return 6000 - 1000 * skill_t2;
		}
		public override int GetEnmity(GSkill skill)
		{
			return 1;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={40,42,44,46,48,50,52,53,55};return array[level-1];
		}
		public override float GetRadius(GSkill skill)
		{
			return 5.000000f;
		}
		public override float GetAngle(GSkill skill)
		{
			return -0.333332f;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 5.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 3.000000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return player_range + 10.0f;
		}
		public override float GetMpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (skill_level * 4.5f + (skill_level * (skill_level * 0.18f)) + 81.0f);
		}
		public override int GetCoverage(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return 2 * skill_level + 8;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_level = player.GetLevel();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();
			int				skill_t1 = skill.GetT1();

			victim.SetProbability(((skill_level + 65)));
			victim.SetTime(((3000 * skill_t1 + 10100)));
			victim.SetRatio((skill_t1 * 0.1f + (skill_level * 0.03f + 0.03f)));
			victim.SetBuffid(1);
			victim.SetSlow(true);
			victim.SetProbability(-1.0f);
			victim.SetTime(100.0f);
			victim.SetBuffid(1);
			victim.SetAmount((player_level * (skill_t0 * 0.9f)));
			victim.SetValue(0.0f);
			victim.SetHpleak(true);
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={248};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={6};return array[index];
		}
	}
	public class GSkill252 : GSkill
	{
		public GSkill252()
			: base(252)
		{
			
		}
	}
	public class GSkill253Stub : GSkillStub
	{
		public GSkill253Stub()
			: base(253)
		{
			occupation = 2;
			maxlevel = 12;
			maxlearn = 6;
			eventflag = 1;
			spcost = 1;
			reborncount = 0;
			type = 11;
			timetype = 0;
			targettype = 0;
			rangetype = 5;
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
			name = "ÃÜÔÆÖä";
			nativename = "ÃÜÔÆÖä";
			icon = "ÃÜÔÆÖä.dds";
			SetTalent(0,641);
			SetTalent(1,657);
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
		}
		public override int GetEnmity(GSkill skill)
		{
			return 1;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={46,48,52,56,61,66};return array[level-1];
		}
		public override float GetRadius(GSkill skill)
		{
			return 1.000000f;
		}
		public override int GetCoverage(GSkill skill)
		{
			return 1;
		}
		public override bool TakeEffect(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();
			int				skill_t1 = skill.GetT1();

			player.SetPasadddefence(((5 * skill_level + 5)));
			player.SetPasaddsmite((skill_level * (skill_t1 * 0.02f)));
			player.SetPasadddizzy(((3 * skill_t0 * skill_level)));
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={247};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={1};return array[index];
		}
	}
	public class GSkill253 : GSkill
	{
		public GSkill253()
			: base(253)
		{
			
		}
	}
	public class GSkill254Stub : GSkillStub
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
				int				skill_t3 = skill.GetT3();

				skill.SetRatio((skill_t3 * 0.05f + 1.0f));
				skill.SetPlus(((skill_t2 * 0.08f + 1.0f) * (((9 * skill_level) + (skill_level * (skill_level * 0.47f)) + 58.0f) * (D2INT(skill_level * 0.05f + 0.55f)) + (((D2INT(1.42f - skill_level * 0.05f)) * (9 * skill_level + 92) + (6 * skill_t0 * skill_level))))));
				player.SetPerform(1);
			}
		}
		public GSkill254Stub()
			: base(254)
		{
			occupation = 2;
			maxlevel = 12;
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
			SetAction(0,"¹íÍõ×Ú_ÎÞÍýÈÐ");
			SetAction(1,"¹íÍõ×Ú_ÎÞÍýÈÐ");
			SetAction(2,"¹íÍõ×Ú_ÎÞÍýÈÐ");
			SetAction(3,"¹íÍõ×Ú_ÎÞÍýÈÐ");
			SetAction(4,"¹íÍõ×Ú_ÎÞÍýÈÐ");
			SetAction(5,"¹íÍõ×Ú_ÎÞÍýÈÐ");
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
			SetAction(18,"¹íÍõ×Ú_Æï³Ë_ÎÞÍýÈÐ");
			SetAction(19,"¹íÍõ×Ú_Æï³Ë_ÎÞÍýÈÐ");
			SetAction(20,"¹íÍõ×Ú_Æï³Ë_ÎÞÍýÈÐ");
			SetAction(21,"¹íÍõ×Ú_Æï³Ë_ÎÞÍýÈÐ");
			SetAction(22,"¹íÍõ×Ú_Æï³Ë_ÎÞÍýÈÐ");
			SetAction(23,"¹íÍõ×Ú_Æï³Ë_ÎÞÍýÈÐ");
			SetAction(24,"");
			SetAction(25,"");
			SetAction(26,"");
			SetAction(27,"");
			SetAction(28,"");
			SetAction(29,"");
			SetAction(30,"");
			name = "ÎÞÍýÕ¶";
			nativename = "ÎÞÍýÕ¶";
			icon = "ÎÞÍýÕ¶.dds";
			SetTalent(0,624);
			SetTalent(1,625);
			SetTalent(2,630);
			SetTalent(3,634);
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
			return 1000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			int				skill_t1 = skill.GetT1();

			return 8000 - 1000 * skill_t1;
		}
		public override int GetEnmity(GSkill skill)
		{
			return 1;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={55,57,59,61,63,65,67,69,71};return array[level-1];
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

			return (skill_level * 0.48f + (skill_level * (skill_level * 0.32f)) + 63.0f);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_hp = player.GetHp();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();
			int				skill_t1 = skill.GetT1();
			int				skill_t3 = skill.GetT3();

			victim.SetProbability(((4 * skill_level * skill_t1) + (skill_level * 4.2f + 52.0f)));
			victim.SetTime(((3000 * skill_t1 + (600 * skill_level) + 1000)));
			victim.SetRatio((skill_t0 * 0.08f + (skill_level * 0.02f + 0.08f)));
			victim.SetBuffid(1);
			victim.SetWeak(true);
			victim.SetProbability(((2 * skill_level)));
			victim.SetTime(100.0f);
			victim.SetBuffid(2);
			victim.SetAmount((player_hp * (skill_t3 * 0.12f)));
			victim.SetValue(0.0f);
			victim.SetHpleak1(true);
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={393};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={2};return array[index];
		}
	}
	public class GSkill254 : GSkill
	{
		public GSkill254()
			: base(254)
		{
			
		}
	}
	public class GSkill255Stub : GSkillStub
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
				int				skill_t2 = skill.GetT2();
				int				skill_t3 = skill.GetT3();

				skill.SetCrit((skill_t2 * 0.01f));
				skill.SetPlus(((skill_t3 * 0.08f + 1.0f) * (((21 * skill_level) + (skill_level * (skill_level * 0.95f)) + 221.0f) * (D2INT(skill_level * 0.05f + 0.55f)) + ((((33 * skill_level + 299)) - skill_level * (skill_level * 1.5f)) * (D2INT(1.42f - skill_level * 0.05f))))));
				player.SetPerform(1);
			}
		}
		public GSkill255Stub()
			: base(255)
		{
			occupation = 3;
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
			SetAction(0,"¹íÍõ×Ú_ÊÉÑªÕ¶");
			SetAction(1,"¹íÍõ×Ú_ÊÉÑªÕ¶");
			SetAction(2,"¹íÍõ×Ú_ÊÉÑªÕ¶");
			SetAction(3,"¹íÍõ×Ú_ÊÉÑªÕ¶");
			SetAction(4,"¹íÍõ×Ú_ÊÉÑªÕ¶");
			SetAction(5,"¹íÍõ×Ú_ÊÉÑªÕ¶");
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
			SetAction(18,"¹íÍõ×Ú_Æï³Ë_ÊÉÑªÕ¶");
			SetAction(19,"¹íÍõ×Ú_Æï³Ë_ÊÉÑªÕ¶");
			SetAction(20,"¹íÍõ×Ú_Æï³Ë_ÊÉÑªÕ¶");
			SetAction(21,"¹íÍõ×Ú_Æï³Ë_ÊÉÑªÕ¶");
			SetAction(22,"¹íÍõ×Ú_Æï³Ë_ÊÉÑªÕ¶");
			SetAction(23,"¹íÍõ×Ú_Æï³Ë_ÊÉÑªÕ¶");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "ÊÉÑªÕ¶";
			nativename = "ÊÉÑªÕ¶";
			icon = "ÊÉÑªÕ¶.dds";
			SetTalent(0,621);
			SetTalent(1,627);
			SetTalent(2,628);
			SetTalent(3,630);
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
			return 1000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			int				skill_t1 = skill.GetT1();

			return 20000 - 3000 * skill_t1;
		}
		public override int GetEnmity(GSkill skill)
		{
			return 1;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={85,87,89,91,93,95,97,99,101};return array[level-1];
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

			return (skill_level + (skill_level * (skill_level * 1.2f)) + 413.0f);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_t2 = skill.GetT2();

			victim.SetProbability(((15 * skill_t2)));
			victim.SetTime(((3050 * skill_t2)));
			victim.SetRatio((skill_t2 * 0.05f));
			victim.SetBuffid(1);
			victim.SetDecaccuracy(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();
			int				skill_t1 = skill.GetT1();

			victim.SetProbability(120.0f);
			victim.SetRatio(0.0f);
			victim.SetValue(((skill_t1 * 0.15f + 1.0f) * ((25 * skill_t0 * skill_level) + ((((21 * skill_level) + (skill_level * (skill_level * 0.95f)) + 221.0f) * (D2INT(skill_level * 0.05f + 0.55f)) + ((((33 * skill_level + 299)) - skill_level * (skill_level * 1.5f)) * (D2INT(1.42f - skill_level * 0.05f)))) * (skill_level * 0.25f + 0.15f)))));
			victim.SetHeal(true);
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={463};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={2};return array[index];
		}
	}
	public class GSkill255 : GSkill
	{
		public GSkill255()
			: base(255)
		{
			
		}
	}
	public class GSkill256Stub : GSkillStub
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
				return 800;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				skill_level = skill.GetLevel();
				int				skill_t0 = skill.GetT0();
				int				skill_t1 = skill.GetT1();

				skill.SetRatio((skill_t1 * 0.02f + 1.05f));
				skill.SetPlus(((skill_t0 * 0.07000000000000001f + 1.0f) * (((skill_level * (skill_level * 3.5f)) - (45 * skill_level) + 634.0f) * (D2INT(skill_level * 0.05f + 0.55f)) + ((skill_level * 9.300000000000001f + 365.0f) * (D2INT(1.42f - skill_level * 0.05f))))));
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
				int				skill_level = skill.GetLevel();
				int				skill_t0 = skill.GetT0();
				int				skill_t1 = skill.GetT1();

				skill.SetRatio((skill_t1 * 0.03f + 1.05f));
				skill.SetPlus(((skill_t0 * 0.07000000000000001f + 1.0f) * (((skill_level * (skill_level * 3.5f)) - (45 * skill_level) + 634.0f) * (D2INT(skill_level * 0.05f + 0.55f)) + ((skill_level * 9.300000000000001f + 365.0f) * (D2INT(1.42f - skill_level * 0.05f))))));
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
				return 800;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				skill_level = skill.GetLevel();
				int				skill_t0 = skill.GetT0();
				int				skill_t1 = skill.GetT1();

				skill.SetRatio((skill_t1 * 0.04f + 1.05f));
				skill.SetPlus(((skill_t0 * 0.07000000000000001f + 1.0f) * (((skill_level * (skill_level * 3.5f)) - (45 * skill_level) + 634.0f) * (D2INT(skill_level * 0.05f + 0.55f)) + ((skill_level * 9.300000000000001f + 365.0f) * (D2INT(1.42f - skill_level * 0.05f))))));
				player.SetPerform(0);
			}
		}
		public GSkill256Stub()
			: base(256)
		{
			occupation = 3;
			maxlevel = 20;
			maxlearn = 9;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 1;
			timetype = 0;
			targettype = 0;
			rangetype = 0;
			doenchant = false;
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
			SetAction(0,"¹íÍõ×Ú_ÌìÄ§Îè");
			SetAction(1,"¹íÍõ×Ú_ÌìÄ§Îè");
			SetAction(2,"¹íÍõ×Ú_ÌìÄ§Îè");
			SetAction(3,"¹íÍõ×Ú_ÌìÄ§Îè");
			SetAction(4,"¹íÍõ×Ú_ÌìÄ§Îè");
			SetAction(5,"¹íÍõ×Ú_ÌìÄ§Îè");
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
			SetAction(18,"¹íÍõ×Ú_Æï³Ë_ÌìÄ§Îè");
			SetAction(19,"¹íÍõ×Ú_Æï³Ë_ÌìÄ§Îè");
			SetAction(20,"¹íÍõ×Ú_Æï³Ë_ÌìÄ§Îè");
			SetAction(21,"¹íÍõ×Ú_Æï³Ë_ÌìÄ§Îè");
			SetAction(22,"¹íÍõ×Ú_Æï³Ë_ÌìÄ§Îè");
			SetAction(23,"¹íÍõ×Ú_Æï³Ë_ÌìÄ§Îè");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "ÌìÄ§Îè";
			nativename = "ÌìÄ§Îè";
			icon = "ÌìÄ§Îè.dds";
			SetTalent(0,661);
			SetTalent(1,663);
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
		}
		public override int GetExecutetime(GSkill skill)
		{
			return 3000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			int				skill_t0 = skill.GetT0();
			int				skill_t1 = skill.GetT1();

			return (-750 * skill_t1) - 750 * skill_t0 + 5000;
		}
		public override int GetEnmity(GSkill skill)
		{
			return 1;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={90,92,94,96,98,100,102,104,106};return array[level-1];
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
			return 14.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (18 * skill_level + 557);
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={314};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={5};return array[index];
		}
	}
	public class GSkill256 : GSkill
	{
		public GSkill256()
			: base(256)
		{
			
		}
	}
	public class GSkill257Stub : GSkillStub
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
		public GSkill257Stub()
			: base(257)
		{
			occupation = 2;
			maxlevel = 12;
			maxlearn = 7;
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
			SetAction(0,"¹íÍõ×Ú_ºáÐÐÎÞ¼É");
			SetAction(1,"¹íÍõ×Ú_ºáÐÐÎÞ¼É");
			SetAction(2,"¹íÍõ×Ú_ºáÐÐÎÞ¼É");
			SetAction(3,"¹íÍõ×Ú_ºáÐÐÎÞ¼É");
			SetAction(4,"¹íÍõ×Ú_ºáÐÐÎÞ¼É");
			SetAction(5,"¹íÍõ×Ú_ºáÐÐÎÞ¼É");
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
			SetAction(18,"¹íÍõ×Ú_Æï³Ë_ºáÐÐÎÞ¼É");
			SetAction(19,"¹íÍõ×Ú_Æï³Ë_ºáÐÐÎÞ¼É");
			SetAction(20,"¹íÍõ×Ú_Æï³Ë_ºáÐÐÎÞ¼É");
			SetAction(21,"¹íÍõ×Ú_Æï³Ë_ºáÐÐÎÞ¼É");
			SetAction(22,"¹íÍõ×Ú_Æï³Ë_ºáÐÐÎÞ¼É");
			SetAction(23,"¹íÍõ×Ú_Æï³Ë_ºáÐÐÎÞ¼É");
			SetAction(24,"");
			SetAction(25,"");
			SetAction(26,"");
			SetAction(27,"");
			SetAction(28,"");
			SetAction(29,"");
			SetAction(30,"");
			name = "Ä§ÐÔ´ó·¢";
			nativename = "Ä§ÐÔ´ó·¢";
			icon = "Ä§ÐÔ´ó·¢.dds";
			SetTalent(0,642);
			SetTalent(1,647);
			SetTalent(2,662);
			SetTalent(3,666);
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
			return 1000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			int				skill_t2 = skill.GetT2();

			return 144000 - 18000 * skill_t2;
		}
		public override int GetEnmity(GSkill skill)
		{
			return 1;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={55,59,63,67,71,75,79};return array[level-1];
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 20.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 18.000000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 22.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (skill_level * 0.55f + (skill_level * (skill_level * 1.1f)) + 145.0f);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();
			int				skill_t1 = skill.GetT1();
			int				skill_t3 = skill.GetT3();

			victim.SetProbability(120.0f);
			victim.SetRatio(4272.0f);
			victim.SetAmount(4098.0f);
			victim.SetValue(4272.0f);
			victim.SetDispel(true);
			victim.SetProbability(120.0f);
			victim.SetClearsilent(true);
			victim.SetTime(((2000 * skill_t1 + 20100)));
			victim.SetBuffid(2);
			victim.SetValue(((4 * skill_level * skill_t0 + (10 * skill_level) + 20)));
			victim.SetAddantisilent(true);
			victim.SetProbability(((10 * skill_t3)));
			victim.SetClearwrap(true);
			victim.SetProbability(120.0f);
			victim.SetTime(1000 * skill_level + 1000);
			victim.SetImmunetaune(true);
			/**/
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_maxhp = player.GetMaxhp();
			int				player_maxmp = player.GetMaxmp();
			int				player_var1 = player.GetVar1();
			int				skill_t1 = skill.GetT1();

			victim.SetProbability(skill_t1<=0?0.0f:120.0f);
			victim.SetTime(((60000 * skill_t1)));
			victim.SetBuffid(1);
			victim.SetAmount((skill_t1 * 0.1f + 0.00001f));
			victim.SetValue((player_maxmp * (skill_t1 * 0.06f)));
			victim.SetAddhp2(true);
			victim.SetProbability(player_var1 <= 950 ? 0.0f : (120 * norm(skill_t1 / 3.9f)));
			victim.SetRatio(0.0f);
			victim.SetValue(player_maxhp);
			victim.SetHeal(true);
			/**/
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={253};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={3};return array[index];
		}
	}
	public class GSkill257 : GSkill
	{
		public GSkill257()
			: base(257)
		{
			
		}
	}
	public class GSkill258Stub : GSkillStub
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
		public GSkill258Stub()
			: base(258)
		{
			occupation = 2;
			maxlevel = 20;
			maxlearn = 7;
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
			SetAction(0,"¹íÍõ×Ú_ÃÍ»ðÖä");
			SetAction(1,"¹íÍõ×Ú_ÃÍ»ðÖä");
			SetAction(2,"¹íÍõ×Ú_ÃÍ»ðÖä");
			SetAction(3,"¹íÍõ×Ú_ÃÍ»ðÖä");
			SetAction(4,"¹íÍõ×Ú_ÃÍ»ðÖä");
			SetAction(5,"¹íÍõ×Ú_ÃÍ»ðÖä");
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
			SetAction(18,"¹íÍõ×Ú_Æï³Ë_ÃÍ»ðÖä");
			SetAction(19,"¹íÍõ×Ú_Æï³Ë_ÃÍ»ðÖä");
			SetAction(20,"¹íÍõ×Ú_Æï³Ë_ÃÍ»ðÖä");
			SetAction(21,"¹íÍõ×Ú_Æï³Ë_ÃÍ»ðÖä");
			SetAction(22,"¹íÍõ×Ú_Æï³Ë_ÃÍ»ðÖä");
			SetAction(23,"¹íÍõ×Ú_Æï³Ë_ÃÍ»ðÖä");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "ÃÍ»ðÖä";
			nativename = "ÃÍ»ðÖä";
			icon = "ÃÍ»ðÖä.dds";
			SetTalent(0,623);
			SetTalent(1,647);
			SetTalent(2,662);
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
			int				skill_t2 = skill.GetT2();

			return 90000 - 9000 * skill_t2;
		}
		public override int GetEnmity(GSkill skill)
		{
			return 1;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={50,52,54,56,58,60,64};return array[level-1];
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

			return (skill_level * 0.52f + (skill_level * (skill_level * 0.32f)) + 120.0f);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_maxhp = player.GetMaxhp();
			int				player_maxmp = player.GetMaxmp();
			int				player_var1 = player.GetVar1();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();
			int				skill_t1 = skill.GetT1();

			victim.SetProbability(100.0f);
			victim.SetTime(((2000 * skill_t1 + 20100)));
			victim.SetRatio((skill_t0 * 0.02f + (skill_level * 0.01f + 0.05f)));
			victim.SetBuffid(3);
			victim.SetIncattack(true);
			victim.SetProbability(((100 - 7 * skill_t0)));
			victim.SetTime(((2000 * skill_t1 + 20100)));
			victim.SetRatio((0.31f - skill_level * 0.01f));
			victim.SetBuffid(3);
			victim.SetDecdefence(true);
			victim.SetProbability(skill_t1 <= 0?0.0f:120.0f);
			victim.SetTime(((60000 * skill_t1)));
			victim.SetBuffid(1);
			victim.SetAmount((skill_t1 * 0.1f + 0.00001f));
			victim.SetValue((player_maxmp * (skill_t1 * 0.06f)));
			victim.SetAddhp2(true);
			victim.SetProbability(player_var1 <= 950?0.0f:(120 * norm(skill_t1 / 3.9f)));
			victim.SetRatio(0.0f);
			victim.SetValue(player_maxhp);
			victim.SetHeal(true);
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={247};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={3};return array[index];
		}
	}
	public class GSkill258 : GSkill
	{
		public GSkill258()
			: base(258)
		{
			
		}
	}
	public class GSkill259Stub : GSkillStub
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
		public GSkill259Stub()
			: base(259)
		{
			occupation = 2;
			maxlevel = 8;
			maxlearn = 6;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 3;
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
			SetAction(0,"¹íÍõ×Ú_ÈºÌå¼¤Å­");
			SetAction(1,"¹íÍõ×Ú_ÈºÌå¼¤Å­");
			SetAction(2,"¹íÍõ×Ú_ÈºÌå¼¤Å­");
			SetAction(3,"¹íÍõ×Ú_ÈºÌå¼¤Å­");
			SetAction(4,"¹íÍõ×Ú_ÈºÌå¼¤Å­");
			SetAction(5,"¹íÍõ×Ú_ÈºÌå¼¤Å­");
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
			SetAction(18,"¹íÍõ×Ú_Æï³Ë_ÈºÌå¼¤Å­");
			SetAction(19,"¹íÍõ×Ú_Æï³Ë_ÈºÌå¼¤Å­");
			SetAction(20,"¹íÍõ×Ú_Æï³Ë_ÈºÌå¼¤Å­");
			SetAction(21,"¹íÍõ×Ú_Æï³Ë_ÈºÌå¼¤Å­");
			SetAction(22,"¹íÍõ×Ú_Æï³Ë_ÈºÌå¼¤Å­");
			SetAction(23,"¹íÍõ×Ú_Æï³Ë_ÈºÌå¼¤Å­");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "Ö¸ÌìÂîµØ";
			nativename = "Ö¸ÌìÂîµØ";
			icon = "Ö¸ÌìÂîµØ.dds";
			SetTalent(0,643);
			SetTalent(1,645);
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
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();

			return (-15000 * skill_level) - 10000 * skill_t0 + 165000;
		}
		public override int GetEnmity(GSkill skill)
		{
			return 1;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={65,69,73,77,81,83};return array[level-1];
		}
		public override float GetRadius(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (3 * skill_level + 4);
		}
		public override float GetPraydistance(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (2 * skill_level + 10);
		}
		public override float GetCastdistance(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (2 * skill_level + 8);
		}
		public override float GetEffectdistance(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (2 * skill_level + 11);
		}
		public override float GetMpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return ((30 * skill_level) + (skill_level * (skill_level * 1.2f)) + 224.0f);
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

			victim.SetProbability(((6 * skill_level + 52)));
			victim.SetTime(12000.0f);
			victim.SetAssault(true);
			victim.SetProbability(-1.0f);
			victim.SetTime(2000.0f);
			victim.SetBuffid(1);
			victim.SetAmount(((D2INT(zrand(100) / (100 - 6 * skill_level)) + 1) * ((skill_t1 * 0.8f + 1.0f) * ((60 * skill_level)))));
			victim.SetValue(0.0f);
			victim.SetHpleak5(true);
			victim.SetTime(((6050 * skill_t0)));
			victim.SetBuffid(2);
			victim.SetValue(((15 * skill_t0)));
			victim.SetSubantidizzy(true);
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={257};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={3};return array[index];
		}
	}
	public class GSkill259 : GSkill
	{
		public GSkill259()
			: base(259)
		{
			
		}
	}
}
