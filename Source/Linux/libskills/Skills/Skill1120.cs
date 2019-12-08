using System;
using System.Text;

namespace SKILL
{
	public class GSkill1120Stub : GSkillStub
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
				int				player_mp = player.GetMp();
				int				skill_level = skill.GetLevel();
				int				skill_t1 = skill.GetT1();
				int				skill_t3 = skill.GetT3();

				skill.SetRatio(skill_t3 * 0.05f + 1.0f);
				skill.SetPlus((INT(skill_level * 0.05f + 0.55f) * ((13 * skill_level * skill_level) - 240 * skill_level + 2070)) + ((skill_level * 4.4f + (skill_level * (skill_level * 3.2f)) + 633.0f) * INT(1.42f - skill_level * 0.05f) + ((15 * skill_level * skill_t1) + ((player_mp + player_hp) * 0.03f))));
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
				int				player_mp = player.GetMp();
				int				skill_level = skill.GetLevel();
				int				skill_t1 = skill.GetT1();
				int				skill_t3 = skill.GetT3();

				skill.SetRatio(skill_t3 * 0.05f + 1.0f);
				skill.SetPlus((INT(skill_level * 0.05f + 0.55f) * ((13 * skill_level * skill_level) - 240 * skill_level + 2070)) + ((skill_level * 4.4f + (skill_level * (skill_level * 3.2f)) + 633.0f) * INT(1.42f - skill_level * 0.05f) + ((15 * skill_level * skill_t1) + ((player_mp + player_hp) * 0.03f))));
				player.SetPerform(0);
			}
		}
		public GSkill1120Stub()
			: base(1120)
		{
			occupation = 27;
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
			dobless = false;
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
			SetAction(0,"Ëé»êÌìÏ®");
			SetAction(1,"Ëé»êÌìÏ®");
			SetAction(2,"Ëé»êÌìÏ®");
			SetAction(3,"Ëé»êÌìÏ®");
			SetAction(4,"Ëé»êÌìÏ®");
			SetAction(5,"Ëé»êÌìÏ®");
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
			SetAction(18,"Ëé»êÌìÏ®");
			SetAction(19,"Ëé»êÌìÏ®");
			SetAction(20,"Ëé»êÌìÏ®");
			SetAction(21,"Ëé»êÌìÏ®");
			SetAction(22,"Ëé»êÌìÏ®");
			SetAction(23,"Ëé»êÌìÏ®");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "Ëé»êÌìÏ®";
			nativename = "Ëé»êÌìÏ®";
			icon = "Ëé»êÌìÏ®.dds";
			SetTalent(0,1163);
			SetTalent(1,1166);
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
			AddState(new GState3());
		}
		public override int GetExecutetime(GSkill skill)
		{
			return 2000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			return 6000;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={95,97,99,101,103,105,107,109,112,116};return array[level-1];
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
			return 13.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (30 * skill_level + 650);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();
			int				skill_t2 = skill.GetT2();

			victim.SetProbability((3 * skill_level * skill_t2) + ((skill_level * 14.1f + 100.0f) - skill_level * (skill_level * 0.34f)));
			victim.SetTime(2000 * skill_t0 + 2100);
			victim.SetDizzy(true);
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={1118};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={3};return array[index];
		}
	}
	public class GSkill1120 : GSkill
	{
		public GSkill1120()
			: base(1120)
		{
			
		}
	}
	public class GSkill1121Stub : GSkillStub
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
		public GSkill1121Stub()
			: base(1121)
		{
			occupation = 27;
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
			dobless = false;
			autoattack = false;
			allowform = 4;
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
			SetAction(0,"ÄýÉñÑªÖä");
			SetAction(1,"ÄýÉñÑªÖä");
			SetAction(2,"ÄýÉñÑªÖä");
			SetAction(3,"ÄýÉñÑªÖä");
			SetAction(4,"ÄýÉñÑªÖä");
			SetAction(5,"ÄýÉñÑªÖä");
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
			SetAction(18,"ÄýÉñÑªÖä");
			SetAction(19,"ÄýÉñÑªÖä");
			SetAction(20,"ÄýÉñÑªÖä");
			SetAction(21,"ÄýÉñÑªÖä");
			SetAction(22,"ÄýÉñÑªÖä");
			SetAction(23,"ÄýÉñÑªÖä");
			SetAction(24,"");
			SetAction(25,"");
			SetAction(26,"");
			SetAction(27,"");
			SetAction(28,"");
			SetAction(29,"");
			SetAction(30,"");
			name = "ÄýÑªÉñÖä";
			nativename = "ÄýÑªÉñÖä";
			icon = "ÄýÑªÉñÖä.dds";
			SetTalent(0,1180);
			SetTalent(1,1184);
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
			int[] array={100,103,106,109,112,115,118,122};return array[level-1];
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

			return (15 * skill_level + 605);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();
			int				skill_t1 = skill.GetT1();

			victim.SetTime(3000 * (skill_t1 + skill_level) + 12100);
			victim.SetRatio(skill_t0 * 0.15f + (skill_level * 0.15f + 0.25f));
			victim.SetAmount(0.0f);
			victim.SetValue(5 * skill_level + 10);
			victim.SetFocusanti(true);
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={1117};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={5};return array[index];
		}
	}
	public class GSkill1121 : GSkill
	{
		public GSkill1121()
			: base(1121)
		{
			
		}
	}
	public class GSkill1122Stub : GSkillStub
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
				int				skill_level = skill.GetLevel();
				int				skill_t1 = skill.GetT1();
				int				skill_t3 = skill.GetT3();
				int				skill_t4 = skill.GetT4();

				skill.SetRatio(skill_t4 * 0.02f + (skill_t1 * 0.05f + 1.0f));
				skill.SetCrit(skill_t3 * 0.01f);
				skill.SetCrithurt(skill_t3 * 0.1f);
				skill.SetPlus(((skill_level * (skill_level * 8.4f)) - (140 * skill_level) + 1290.0f) * INT(skill_level * 0.05f + 0.55f) + ((11 * skill_level) + (skill_level * (skill_level * 0.043f)) + 547.0f) * INT(1.42f - skill_level * 0.05f));
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
				int				skill_level = skill.GetLevel();
				int				skill_t1 = skill.GetT1();
				int				skill_t3 = skill.GetT3();
				int				skill_t4 = skill.GetT4();

				skill.SetRatio(skill_t4 * 0.02f + (skill_t1 * 0.05f + 1.0f));
				skill.SetCrit(skill_t3 * 0.01f);
				skill.SetCrithurt(skill_t3 * 0.1f);
				skill.SetPlus(((skill_level * (skill_level * 8.4f)) - (140 * skill_level) + 1290.0f) * INT(skill_level * 0.05f + 0.55f) + ((11 * skill_level) + (skill_level * (skill_level * 0.043f)) + 547.0f) * INT(1.42f - skill_level * 0.05f));
				player.SetPerform(0);
			}
		}
		public GSkill1122Stub()
			: base(1122)
		{
			occupation = 28;
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
			SetAction(0,"¹íµÀ_Ä»Ìì¿ñÉ³");
			SetAction(1,"¹íµÀ_Ä»Ìì¿ñÉ³");
			SetAction(2,"¹íµÀ_Ä»Ìì¿ñÉ³");
			SetAction(3,"¹íµÀ_Ä»Ìì¿ñÉ³");
			SetAction(4,"¹íµÀ_Ä»Ìì¿ñÉ³");
			SetAction(5,"¹íµÀ_Ä»Ìì¿ñÉ³");
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
			SetAction(18,"¹íµÀ_Æï³Ë_Ä»Ìì¿ñÉ³");
			SetAction(19,"¹íµÀ_Æï³Ë_Ä»Ìì¿ñÉ³");
			SetAction(20,"¹íµÀ_Æï³Ë_Ä»Ìì¿ñÉ³");
			SetAction(21,"¹íµÀ_Æï³Ë_Ä»Ìì¿ñÉ³");
			SetAction(22,"¹íµÀ_Æï³Ë_Ä»Ìì¿ñÉ³");
			SetAction(23,"¹íµÀ_Æï³Ë_Ä»Ìì¿ñÉ³");
			SetAction(24,"");
			SetAction(25,"");
			SetAction(26,"");
			SetAction(27,"");
			SetAction(28,"");
			SetAction(29,"");
			SetAction(30,"");
			name = "Ä»Ìì¿ñÉ³";
			nativename = "Ä»Ìì¿ñÉ³";
			icon = "Ä»Ìì¿ñÉ³.dds";
			SetTalent(0,1151);
			SetTalent(1,1152);
			SetTalent(2,1154);
			SetTalent(3,1155);
			SetTalent(4,1543);
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
			AddState(new GState3());
		}
		public override int GetExecutetime(GSkill skill)
		{
			return 2000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			int				skill_t0 = skill.GetT0();
			int				skill_t4 = skill.GetT4();

			return (-900 * skill_t0) - 300 * skill_t4 + 6000;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={105,107,109,111,113,115,117,119,122};return array[level-1];
		}
		public override float GetRadius(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (skill_level * 0.2f + 6.8f);
		}
		public override float GetAngle(GSkill skill)
		{
			return -0.333332f;
		}
		public override float GetPraydistance(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (skill_level * 0.2f + 6.8f);
		}
		public override float GetCastdistance(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (skill_level * 0.2f + 3.8f);
		}
		public override float GetMpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (10 * skill_level + (skill_level * skill_level) + 600);
		}
		public override int GetCoverage(GSkill skill)
		{
			return 28;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_t2 = skill.GetT2();

			victim.SetProbability(600 * norm(zrand(100) / (100 - 4 * skill_t2)));
			victim.SetTime(2050 * skill_t2);
			victim.SetDizzy(true);
			return true;
		}
		public override float GetDropRate(GSkill skill)
		{
			return 0.500000f;
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={24};return array[index];
		}
	}
	public class GSkill1122 : GSkill
	{
		public GSkill1122()
			: base(1122)
		{
			
		}
	}
	public class GSkill1123Stub : GSkillStub
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
		public GSkill1123Stub()
			: base(1123)
		{
			occupation = 28;
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
			allowform = 4;
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
			SetAction(0,"Óü»ðÁ¶Ö¾");
			SetAction(1,"Óü»ðÁ¶Ö¾");
			SetAction(2,"Óü»ðÁ¶Ö¾");
			SetAction(3,"Óü»ðÁ¶Ö¾");
			SetAction(4,"Óü»ðÁ¶Ö¾");
			SetAction(5,"Óü»ðÁ¶Ö¾");
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
			SetAction(18,"Óü»ðÁ¶Ö¾");
			SetAction(19,"Óü»ðÁ¶Ö¾");
			SetAction(20,"Óü»ðÁ¶Ö¾");
			SetAction(21,"Óü»ðÁ¶Ö¾");
			SetAction(22,"Óü»ðÁ¶Ö¾");
			SetAction(23,"Óü»ðÁ¶Ö¾");
			SetAction(24,"");
			SetAction(25,"");
			SetAction(26,"");
			SetAction(27,"");
			SetAction(28,"");
			SetAction(29,"");
			SetAction(30,"");
			name = "Óü»ðÁ¶Ö¾";
			nativename = "Óü»ðÁ¶Ö¾";
			icon = "Óü»ðÁ¶Ö¾.dds";
			SetTalent(0,1184);
			SetTalent(1,1187);
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
			AddState(new GState2());
		}
		public override int GetExecutetime(GSkill skill)
		{
			return 1000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			int				skill_t0 = skill.GetT0();

			return 180000 - 18000 * skill_t0;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={106,109,112,115,118,121,124,125,125};return array[level-1];
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
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_maxhp = player.GetMaxhp();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();
			int				skill_t1 = skill.GetT1();

			victim.SetProbability(100 - 15 * skill_t1);
			victim.SetTime(3000 * skill_level + 12100);
			victim.SetBuffid(1);
			victim.SetAmount((1.0f - skill_t1 * 0.1f) * (100 * skill_level));
			victim.SetCycsubdefence(true);
			victim.SetProbability(100 - 15 * skill_t1);
			victim.SetTime(3000 * skill_level + 12100);
			victim.SetBuffid(1);
			victim.SetAmount((1.0f - skill_t1 * 0.1f) * (skill_level * (player_maxhp * 0.15f)));
			victim.SetValue(0.0f);
			victim.SetHpleak(true);
			victim.SetProbability(120.0f);
			victim.SetTime(3000 * (skill_t0 + skill_level) + 12100);
			victim.SetRatio(skill_level * 0.03f);
			victim.SetBuffid(4);
			victim.SetIncattack(true);
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={1122};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={1};return array[index];
		}
	}
	public class GSkill1123 : GSkill
	{
		public GSkill1123()
			: base(1123)
		{
			
		}
	}
	public class GSkill1124Stub : GSkillStub
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
		public GSkill1124Stub()
			: base(1124)
		{
			occupation = 28;
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
			allowform = 2;
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
			SetAction(0,"ìå»êÑªÓ¡");
			SetAction(1,"ìå»êÑªÓ¡");
			SetAction(2,"ìå»êÑªÓ¡");
			SetAction(3,"ìå»êÑªÓ¡");
			SetAction(4,"ìå»êÑªÓ¡");
			SetAction(5,"ìå»êÑªÓ¡");
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
			SetAction(18,"ìå»êÑªÓ¡");
			SetAction(19,"ìå»êÑªÓ¡");
			SetAction(20,"ìå»êÑªÓ¡");
			SetAction(21,"ìå»êÑªÓ¡");
			SetAction(22,"ìå»êÑªÓ¡");
			SetAction(23,"ìå»êÑªÓ¡");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "ìå»êÑªÓ¡";
			nativename = "ìå»êÑªÓ¡";
			icon = "ìå»êÑªÓ¡.dds";
			SetTalent(0,1168);
			SetTalent(1,1169);
			SetTalent(2,1170);
			SetTalent(3,1570);
			SetTalent(4,1111);
			SetTalent(5,1117);
			SetTalent(6,1134);
			SetTalent(7,0);
			talent_size = 7;
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
			int				skill_t0 = skill.GetT0();

			return 180000 - 18000 * skill_t0;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={106,109,112,115,118,121,124,125,125};return array[level-1];
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
			int				skill_t2 = skill.GetT2();

			victim.SetProbability(((5 * skill_t1 + 33)));
			victim.SetTime((((2000 * skill_t2 + (3000 * skill_level) + 27100) * (norm(zrand(100) / (100 - 10 * skill_t2)) + 1))));
			victim.SetRatio((skill_t1 * 0.01f + (skill_level * 0.01f)));
			victim.SetAttack2hp(true);
			victim.SetTime(((5050 * norm(zrand(100) / (100 - 10 * skill_t2)) + 5050)));
			victim.SetRatio(0.07f);
			victim.SetInccritrate(true);
			victim.SetProbability(((120 * norm(skill_t1))));
			victim.SetTime(30000.0f);
			victim.SetRatio(1570.0f);
			victim.SetBuffid(13);
			victim.SetAmount(1111.0f);
			victim.SetValue(1117.0f);
			victim.SetIncskilllevel(true);
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={1122};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={1};return array[index];
		}
	}
	public class GSkill1124 : GSkill
	{
		public GSkill1124()
			: base(1124)
		{
			
		}
	}
	public class GSkill1125Stub : GSkillStub
	{
		public GSkill1125Stub()
			: base(1125)
		{
			occupation = 28;
			maxlevel = 10;
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
			name = "°µÓ°Ä§ÐÄ";
			nativename = "°µÓ°Ä§ÐÄ";
			icon = "°µÓ°Ä§ÐÄ.dds";
			SetTalent(0,1147);
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
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={110,114,118,122,125,125};return array[level-1];
		}
		public override bool TakeEffect(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();

			player.SetPasaddhp(((40 * skill_level)));
			player.SetPasaddsmite((skill_level * 0.1f));
			player.SetPasadddefence(((5 * skill_t0 * skill_level)));
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={1122};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={3};return array[index];
		}
	}
	public class GSkill1125 : GSkill
	{
		public GSkill1125()
			: base(1125)
		{
			
		}
	}
	public class GSkill1126Stub : GSkillStub
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

				skill.SetRatio((skill_level * 0.02f + 0.48f));
				skill.SetPlus(((player_mp + player_hp) * 0.04f));
				player.SetPerform(1);
			}
		}
		public GSkill1126Stub()
			: base(1126)
		{
			occupation = 28;
			maxlevel = 20;
			maxlearn = 12;
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
			allowform = 4;
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
			SetAction(0,"°Ù¹Æà¢»ê");
			SetAction(1,"°Ù¹Æà¢»ê");
			SetAction(2,"°Ù¹Æà¢»ê");
			SetAction(3,"°Ù¹Æà¢»ê");
			SetAction(4,"°Ù¹Æà¢»ê");
			SetAction(5,"°Ù¹Æà¢»ê");
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
			SetAction(18,"°Ù¹Æà¢»ê");
			SetAction(19,"°Ù¹Æà¢»ê");
			SetAction(20,"°Ù¹Æà¢»ê");
			SetAction(21,"°Ù¹Æà¢»ê");
			SetAction(22,"°Ù¹Æà¢»ê");
			SetAction(23,"°Ù¹Æà¢»ê");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "°Ù¹Æà¢»ê";
			nativename = "°Ù¹Æà¢»ê";
			icon = "°Ù¹Æà¢»ê.dds";
			SetTalent(0,1180);
			SetTalent(1,1185);
			SetTalent(2,1186);
			SetTalent(3,1189);
			SetTalent(4,2062);
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
			return 7000;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={115,117,119,121,123,125,125,125,125,125,125,125};return array[level-1];
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 22.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 20.000000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 24.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return ((skill_level * 371.84f + (skill_level * (skill_level * 8.960000000000001f)) + 3320.0f) * 0.25f);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_level = player.GetLevel();
			int				player_hp = player.GetHp();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();
			int				skill_t1 = skill.GetT1();
			int				skill_t2 = skill.GetT2();
			int				skill_t3 = skill.GetT3();
			int				skill_t4 = skill.GetT4();

			victim.SetProbability(((skill_t3 * 0.1f + 1.0f) * ((skill_t4 * 0.03f + (1.0f - player_level * 0.002f)) * 100.0f)));
			victim.SetTime(((48000 - 2000 * skill_t3)));
			victim.SetBuffid(1);
			victim.SetAmount((player_hp * (skill_level * (skill_t1 * 0.005f)) + ((skill_t1 * 0.1f + 1.0f) * (skill_level * 371.84f + (skill_level * (skill_level * 8.960000000000001f)) + 8320.0f))));
			victim.SetValue(0.0f);
			victim.SetHpleak(true);
			victim.SetProbability(((3 * skill_t0 + (2 * skill_level))));
			victim.SetTime(((1000 * skill_t2 + 4100)));
			victim.SetDiet(true);
			victim.SetProbability(((600 * norm(zrand(100) / 67))));
			victim.SetTime(((2050 * skill_t2)));
			victim.SetWrap(true);
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={1123};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={3};return array[index];
		}
	}
	public class GSkill1126 : GSkill
	{
		public GSkill1126()
			: base(1126)
		{
			
		}
	}
	public class GSkill1127Stub : GSkillStub
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
		public GSkill1127Stub()
			: base(1127)
		{
			occupation = 28;
			maxlevel = 20;
			maxlearn = 8;
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
			SetAction(0,"È¼»ê½Ù»ð");
			SetAction(1,"È¼»ê½Ù»ð");
			SetAction(2,"È¼»ê½Ù»ð");
			SetAction(3,"È¼»ê½Ù»ð");
			SetAction(4,"È¼»ê½Ù»ð");
			SetAction(5,"È¼»ê½Ù»ð");
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
			SetAction(18,"È¼»ê½Ù»ð");
			SetAction(19,"È¼»ê½Ù»ð");
			SetAction(20,"È¼»ê½Ù»ð");
			SetAction(21,"È¼»ê½Ù»ð");
			SetAction(22,"È¼»ê½Ù»ð");
			SetAction(23,"È¼»ê½Ù»ð");
			SetAction(24,"");
			SetAction(25,"");
			SetAction(26,"");
			SetAction(27,"");
			SetAction(28,"");
			SetAction(29,"");
			SetAction(30,"");
			name = "È¼»ê½Ù»ð";
			nativename = "È¼»ê½Ù»ð";
			icon = "È¼»ê½Ù»ð.dds";
			SetTalent(0,1161);
			SetTalent(1,1165);
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
			AddState(new GState2());
		}
		public override int GetExecutetime(GSkill skill)
		{
			return 1000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			int				skill_t1 = skill.GetT1();

			return 90000 - 9000 * skill_t1;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={115,117,119,121,123,125,125,125};return array[level-1];
		}
		public override float GetRadius(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (2 * skill_level + 5);
		}
		public override float GetPraydistance(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (2 * skill_level + 4);
		}
		public override float GetCastdistance(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (2 * skill_level + 3);
		}
		public override float GetMpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (150 * skill_level);
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

			victim.SetProbability(100.0f);
			victim.SetAmount(((skill_t0 * 0.2f + 1.0f) * ((20 * skill_level * skill_level + (600 * skill_level)))));
			victim.SetMpdisperse(true);
			return true;
		}
		public override float GetDropRate(GSkill skill)
		{
			return 0.500000f;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={1124};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={3};return array[index];
		}
	}
	public class GSkill1127 : GSkill
	{
		public GSkill1127()
			: base(1127)
		{
			
		}
	}
	public class GSkill1128Stub : GSkillStub
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
				int				skill_level = skill.GetLevel();
				int				skill_t1 = skill.GetT1();
				int				skill_t3 = skill.GetT3();
				int				skill_t4 = skill.GetT4();

				skill.SetRatio(((2 * norm(zrand(116) / 100.0f)) + (skill_t4 * 0.02f + (skill_t1 * 0.06f + 1.0f))));
				skill.SetCrit((norm(skill_t4 / 9.9f) * 0.03f + (skill_t3 * 0.01f)));
				skill.SetCrithurt((skill_t3 * 0.1f));
				skill.SetPlus(((24 * skill_level) + (skill_level * (skill_level * 0.091f)) + 1670.0f));
				player.SetPerform(1);
			}
		}
		public GSkill1128Stub()
			: base(1128)
		{
			occupation = 28;
			maxlevel = 20;
			maxlearn = 9;
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
			SetAction(0,"¹íµÀ_¶¾ÁúÊ´Ìì");
			SetAction(1,"¹íµÀ_¶¾ÁúÊ´Ìì");
			SetAction(2,"¹íµÀ_¶¾ÁúÊ´Ìì");
			SetAction(3,"¹íµÀ_¶¾ÁúÊ´Ìì");
			SetAction(4,"¹íµÀ_¶¾ÁúÊ´Ìì");
			SetAction(5,"¹íµÀ_¶¾ÁúÊ´Ìì");
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
			SetAction(18,"¹íµÀ_Æï³Ë_¶¾ÁúÊ´Ìì");
			SetAction(19,"¹íµÀ_Æï³Ë_¶¾ÁúÊ´Ìì");
			SetAction(20,"¹íµÀ_Æï³Ë_¶¾ÁúÊ´Ìì");
			SetAction(21,"¹íµÀ_Æï³Ë_¶¾ÁúÊ´Ìì");
			SetAction(22,"¹íµÀ_Æï³Ë_¶¾ÁúÊ´Ìì");
			SetAction(23,"¹íµÀ_Æï³Ë_¶¾ÁúÊ´Ìì");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "¶¾ÁúÊ´Ìì";
			nativename = "¶¾ÁúÊ´Ìì";
			icon = "¶¾ÁúÊ´Ìì.dds";
			SetTalent(0,1151);
			SetTalent(1,1152);
			SetTalent(2,1154);
			SetTalent(3,1155);
			SetTalent(4,1543);
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
			return 2000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			int				skill_t0 = skill.GetT0();
			int				skill_t4 = skill.GetT4();

			return (-900 * skill_t0) - 300 * skill_t4 + 6000;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={120,122,124,125,125,125,125,125,125};return array[level-1];
		}
		public override float GetRadius(GSkill skill)
		{
			return 10.000000f;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 10.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 6.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (((79 * skill_level)) - skill_level * (skill_level * 1.6f) + 746.0f);
		}
		public override int GetCoverage(GSkill skill)
		{
			return 30;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();
			int				skill_t2 = skill.GetT2();

			victim.SetProbability(120.0f);
			victim.SetTime(100.0f);
			victim.SetBuffid(1);
			victim.SetAmount((((24 * skill_level) + (skill_level * (skill_level * 0.091f)) + 1670.0f) * (skill_level * 0.05f)));
			victim.SetValue(0.0f);
			victim.SetHpleak(true);
			victim.SetProbability(((600 * norm(zrand(100) / (100 - 3 * skill_t2)))));
			victim.SetTime(((2050 * skill_t2)));
			victim.SetDizzy(true);
			return true;
		}
		public override float GetDropRate(GSkill skill)
		{
			return 0.500000f;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={1125};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={3};return array[index];
		}
	}
	public class GSkill1128 : GSkill
	{
		public GSkill1128()
			: base(1128)
		{
			
		}
	}
	public class GSkill1129Stub : GSkillStub
	{
		public class GState1 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 900;
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
				return 700;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_hp = player.GetHp();
				int				player_mp = player.GetMp();
				int				skill_level = skill.GetLevel();
				int				skill_t0 = skill.GetT0();
				int				skill_t1 = skill.GetT1();

				skill.SetRatio((skill_t1 * 0.05f + 1.0f));
				skill.SetPlus((((D2INT(skill_level * 0.05f + 0.55f)) * ((428 * skill_level) - 13 * skill_level * skill_level - 860)) + (((skill_level * (skill_level * 6.9f)) - skill_level * 3.6f + 1260.0f) * (D2INT(1.42f - skill_level * 0.05f)) + ((25 * skill_level * skill_t0) + ((player_mp + player_hp) * 0.04f)))));
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
				return 700;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_hp = player.GetHp();
				int				player_mp = player.GetMp();
				int				skill_level = skill.GetLevel();
				int				skill_t0 = skill.GetT0();
				int				skill_t1 = skill.GetT1();

				skill.SetRatio((skill_t1 * 0.05f + 1.0f));
				skill.SetPlus((((D2INT(skill_level * 0.05f + 0.55f)) * ((428 * skill_level) - 13 * skill_level * skill_level - 860)) + (((skill_level * (skill_level * 6.9f)) - skill_level * 3.6f + 1260.0f) * (D2INT(1.42f - skill_level * 0.05f)) + ((25 * skill_level * skill_t0) + ((player_mp + player_hp) * 0.04f)))));
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
				return 700;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_hp = player.GetHp();
				int				player_mp = player.GetMp();
				int				skill_level = skill.GetLevel();
				int				skill_t0 = skill.GetT0();
				int				skill_t1 = skill.GetT1();

				skill.SetRatio((skill_t1 * 0.05f + 1.0f));
				skill.SetPlus((((D2INT(skill_level * 0.05f + 0.55f)) * ((428 * skill_level) - 13 * skill_level * skill_level - 860)) + (((skill_level * (skill_level * 6.9f)) - skill_level * 3.6f + 1260.0f) * (D2INT(1.42f - skill_level * 0.05f)) + ((25 * skill_level * skill_t0) + ((player_mp + player_hp) * 0.04f)))));
				player.SetPerform(0);
			}
		}
		public GSkill1129Stub()
			: base(1129)
		{
			occupation = 28;
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
			dobless = false;
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
			SetAction(0,"É­ÂÞÈýÐ¦");
			SetAction(1,"É­ÂÞÈýÐ¦");
			SetAction(2,"É­ÂÞÈýÐ¦");
			SetAction(3,"É­ÂÞÈýÐ¦");
			SetAction(4,"É­ÂÞÈýÐ¦");
			SetAction(5,"É­ÂÞÈýÐ¦");
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
			SetAction(18,"É­ÂÞÈýÐ¦");
			SetAction(19,"É­ÂÞÈýÐ¦");
			SetAction(20,"É­ÂÞÈýÐ¦");
			SetAction(21,"É­ÂÞÈýÐ¦");
			SetAction(22,"É­ÂÞÈýÐ¦");
			SetAction(23,"É­ÂÞÈýÐ¦");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "É­ÂÞÈýÐ¦";
			nativename = "É­ÂÞÈýÐ¦";
			icon = "É­ÂÞÈýÐ¦.dds";
			SetTalent(0,1166);
			SetTalent(1,1172);
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
			return 6000;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={125,125,125,125,125,125,125,125,125,125};return array[level-1];
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
			return 13.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (skill_level * (skill_level * 3.3f) + ((65 * skill_level + 735)));
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_level = player.GetLevel();
			int				skill_level = skill.GetLevel();

			victim.SetProbability(15.0f);
			victim.SetTime(16000.0f);
			victim.SetBuffid(1);
			victim.SetAmount((player_level * (skill_level * 0.5f)));
			victim.SetCycsubattack(true);
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={1127};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={5};return array[index];
		}
	}
	public class GSkill1129 : GSkill
	{
		public GSkill1129()
			: base(1129)
		{
			
		}
	}
}
