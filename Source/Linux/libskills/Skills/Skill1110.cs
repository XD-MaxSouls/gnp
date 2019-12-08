using System;
using System.Text;

namespace SKILL
{
	public class GSkill1110Stub : GSkillStub
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
				int				skill_t0 = skill.GetT0();
				int				skill_t3 = skill.GetT3();

				skill.SetRatio(1.0f);
				skill.SetCrit((skill_t3 * 0.01f));
				skill.SetCrithurt((skill_t3 * 0.1f));
				skill.SetPlus(((((87 * skill_level - 85)) - skill_level * (skill_level * 0.049f)) * (D2INT(skill_level * 0.05f + 0.55f)) + (((11 * skill_level) + (skill_level * (skill_level * 0.049f)) + 453.0f) * (D2INT(1.42f - skill_level * 0.05f)) + ((6 * skill_t0 * skill_level)))));
				player.SetPerform(1);
			}
		}
		public GSkill1110Stub()
			: base(1110)
		{
			occupation = 26;
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
			SetAction(0,"πÌµ¿_∫¨…≥…‰”∞");
			SetAction(1,"πÌµ¿_∫¨…≥…‰”∞");
			SetAction(2,"πÌµ¿_∫¨…≥…‰”∞");
			SetAction(3,"πÌµ¿_∫¨…≥…‰”∞");
			SetAction(4,"πÌµ¿_∫¨…≥…‰”∞");
			SetAction(5,"πÌµ¿_∫¨…≥…‰”∞");
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
			SetAction(18,"πÌµ¿_∆Ô≥À_∫¨…≥…‰”∞");
			SetAction(19,"πÌµ¿_∆Ô≥À_∫¨…≥…‰”∞");
			SetAction(20,"πÌµ¿_∆Ô≥À_∫¨…≥…‰”∞");
			SetAction(21,"πÌµ¿_∆Ô≥À_∫¨…≥…‰”∞");
			SetAction(22,"πÌµ¿_∆Ô≥À_∫¨…≥…‰”∞");
			SetAction(23,"πÌµ¿_∆Ô≥À_∫¨…≥…‰”∞");
			SetAction(24,"");
			SetAction(25,"");
			SetAction(26,"");
			SetAction(27,"");
			SetAction(28,"");
			SetAction(29,"");
			SetAction(30,"");
			name = "∫¨…≥…‰”∞";
			nativename = "∫¨…≥…‰”∞";
			icon = "∫¨…≥…‰”∞.dds";
			SetTalent(0,1144);
			SetTalent(1,1145);
			SetTalent(2,1151);
			SetTalent(3,1155);
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
			return 2000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			int				skill_t2 = skill.GetT2();

			return 6000 - 900 * skill_t2;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={60,62,64,66,68,70,72,74,77};return array[level-1];
		}
		public override float GetRadius(GSkill skill)
		{
			return 8.000000f;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 8.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 6.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (skill_level * 0.17f + (skill_level * (skill_level * 1.65f)) + 262.0f);
		}
		public override int GetCoverage(GSkill skill)
		{
			return 18;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();
			int				skill_t1 = skill.GetT1();

			victim.SetProbability(((5 * skill_t1 + 33)));
			victim.SetTime(((3000 * skill_t1 + 8100)));
			victim.SetRatio((skill_level * 0.01f));
			victim.SetBuffid(1);
			victim.SetDecaccuracy(true);
			return true;
		}
		public override float GetDropRate(GSkill skill)
		{
			return 0.360000f;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={1107};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={2};return array[index];
		}
	}
	public class GSkill1110 : GSkill
	{
		public GSkill1110()
			: base(1110)
		{
			
		}
	}
	public class GSkill1111Stub : GSkillStub
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

				skill.SetRatio((skill_level <= 13)?((0.02f * skill_level) + 0.48f):((0.02f * (skill_level - 13)) + 0.48f));
				skill.SetPlus(((player_mp + player_hp) * 0.02f));
				player.SetPerform(1);
			}
		}
		public GSkill1111Stub()
			: base(1111)
		{
			occupation = 26;
			maxlevel = 30;
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
			SetAction(0,"ƒ˝—™—˝π∆");
			SetAction(1,"ƒ˝—™—˝π∆");
			SetAction(2,"ƒ˝—™—˝π∆");
			SetAction(3,"ƒ˝—™—˝π∆");
			SetAction(4,"ƒ˝—™—˝π∆");
			SetAction(5,"ƒ˝—™—˝π∆");
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
			SetAction(18,"ƒ˝—™—˝π∆");
			SetAction(19,"ƒ˝—™—˝π∆");
			SetAction(20,"ƒ˝—™—˝π∆");
			SetAction(21,"ƒ˝—™—˝π∆");
			SetAction(22,"ƒ˝—™—˝π∆");
			SetAction(23,"ƒ˝—™—˝π∆");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "ƒ˝—™—˝π∆";
			nativename = "ƒ˝—™—˝π∆";
			icon = "ƒ˝—™—˝π∆.dds";
			SetTalent(0,1179);
			SetTalent(1,1185);
			SetTalent(2,1189);
			SetTalent(3,1169);
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
			return 7000;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={70,72,74,76,78,80,82,84,87,90,93,96};return array[level-1];
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

			return (skill_level <= 13)?(0.25f * ((skill_level * 7.04f + (skill_level * (5.31f * skill_level))) + 1030.0f)):(0.25f * (((skill_level - 13) * 7.04f + ((skill_level - 13) * (5.31f * (skill_level - 13)))) + 1030.0f))/**/;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_level = player.GetLevel();
			int				player_hp = player.GetHp();
			int				player_maxhp = player.GetMaxhp();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();
			int				skill_t1 = skill.GetT1();
			int				skill_t2 = skill.GetT2();
			int				skill_t3 = skill.GetT3();

			float s = 0.05f * skill_t0;
			float h = player_hp + 1.0f;
			float n = norm((skill_level <= 13)?((((0.02f * skill_level) + 0.08f) + s) * player_maxhp / h):((((0.02f * (skill_level - 13)) + 0.08f) + s) * player_maxhp / h));
			float ability = (skill_level <= 13)?(3 * skill_level * n):(n * (3 * skill_level - 39));
			victim.SetProbability(ability);
			victim.SetTime(((1000 * skill_t0 + 4100)));
			victim.SetRatio(0.30000001f);
			victim.SetValue(0.30000001f);
			victim.SetRandcurse(true);
			victim.SetProbability(((skill_t2 * 0.1f + 1.0f) * ((1.0f - player_level * 0.002f) * 100.0f)));
			victim.SetTime(((24000 - 2000 * skill_t2)));
			victim.SetBuffid(1);
			float amount = (skill_level <= 13)?(player_hp * (skill_level * (skill_t1 * 0.005f)) + ((skill_t1 * 0.1f + 1.0f) * ((skill_level * 7.04f + (skill_level * (5.31f * skill_level))) + 1030.0f))):((player_hp * ((skill_level - 13) * (skill_t1 * 0.005f)) + ((skill_t1 * 0.1f + 1.0f) * ((skill_level - 13) * 7.04f + ((skill_level - 13) * ((skill_level - 13) * 5.31f)) + 1030.0f))) * ((0.4f * skill_t3) + 1.0f));
			victim.SetAmount(amount);
			float value = (skill_level <= 13)?(skill_t0 * (0.1f * ((skill_level * 7.04f + (skill_level * (5.31f * skill_level))) + 1030.0f))):(skill_t0 * ((skill_t3 * 0.4f + 1.0f) * (0.1f * (((skill_level - 13) * 7.04f + ((skill_level - 13) * (5.31f * (skill_level - 13)))) + 1030.0f))));
			victim.SetValue(value);
			victim.SetHpleak1(true);
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={1108};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={5};return array[index];
		}
	}
	public class GSkill1111 : GSkill
	{
		public GSkill1111()
			: base(1111)
		{
			
		}
	}
	public class GSkill1112Stub : GSkillStub
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
				int				player_mp = player.GetMp();
				int				skill_level = skill.GetLevel();
				int				skill_t3 = skill.GetT3();

				skill.SetRatio((skill_t3 * 0.05f + 1.0f));
				skill.SetPlus(((14 * skill_level) + (skill_level * (skill_level * 5.5f)) + 621.0f + ((player_mp + player_hp) * 0.02f)));
				player.SetPerform(1);
			}
		}
		public GSkill1112Stub()
			: base(1112)
		{
			occupation = 26;
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
			SetAction(0,"∆∆»––∞ªÍ");
			SetAction(1,"∆∆»––∞ªÍ");
			SetAction(2,"∆∆»––∞ªÍ");
			SetAction(3,"∆∆»––∞ªÍ");
			SetAction(4,"∆∆»––∞ªÍ");
			SetAction(5,"∆∆»––∞ªÍ");
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
			SetAction(18,"∆∆»––∞ªÍ");
			SetAction(19,"∆∆»––∞ªÍ");
			SetAction(20,"∆∆»––∞ªÍ");
			SetAction(21,"∆∆»––∞ªÍ");
			SetAction(22,"∆∆»––∞ªÍ");
			SetAction(23,"∆∆»––∞ªÍ");
			SetAction(24,"");
			SetAction(25,"");
			SetAction(26,"");
			SetAction(27,"");
			SetAction(28,"");
			SetAction(29,"");
			SetAction(30,"");
			name = "∆∆»––∞ªÍ";
			nativename = "∆∆»––∞ªÍ";
			icon = "∆∆»––∞ªÍ.dds";
			SetTalent(0,1163);
			SetTalent(1,1167);
			SetTalent(2,1172);
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
			return 2000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			return 5000;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={65,67,69,71,73,75,77,79,82,86};return array[level-1];
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

			return ((skill_level * (skill_level * 1.2f)) - skill_level * 5.3f + 97.0f);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();
			int				skill_t1 = skill.GetT1();

			victim.SetProbability(((skill_level * skill_t1 + (3 * skill_level))));
			victim.SetTime(((2000 * skill_t0 + (500 * skill_level) + 2100)));
			victim.SetBarehanded(true);
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={1109};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={4};return array[index];
		}
	}
	public class GSkill1112 : GSkill
	{
		public GSkill1112()
			: base(1112)
		{
			
		}
	}
	public class GSkill1113Stub : GSkillStub
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
				int				skill_t0 = skill.GetT0();
				int				skill_t3 = skill.GetT3();
				int				skill_t4 = skill.GetT4();

				skill.SetRatio((norm(zrand(130) / 100.0f) + (skill_t4 * 0.02f + (skill_t0 * 0.04f + 1.0f))));
				skill.SetCrit((norm(skill_t4 / 9.9f) * 0.03f + (skill_t3 * 0.01f)));
				skill.SetCrithurt((skill_t3 * 0.1f));
				skill.SetPlus((((62 * skill_level) + (skill_level * (skill_level * 0.72f)) + 348.0f) * (D2INT(skill_level * 0.05f + 0.55f)) + ((skill_level * 7.9f + (skill_level * (skill_level * 1.4f)) + 677.0f) * (D2INT(1.42f - skill_level * 0.05f)))));
				player.SetPerform(1);
			}
		}
		public GSkill1113Stub()
			: base(1113)
		{
			occupation = 27;
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
			SetAction(0,"πÌµ¿_±©…≥¬˛æÌ");
			SetAction(1,"πÌµ¿_±©…≥¬˛æÌ");
			SetAction(2,"πÌµ¿_±©…≥¬˛æÌ");
			SetAction(3,"πÌµ¿_±©…≥¬˛æÌ");
			SetAction(4,"πÌµ¿_±©…≥¬˛æÌ");
			SetAction(5,"πÌµ¿_±©…≥¬˛æÌ");
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
			SetAction(18,"πÌµ¿_∆Ô≥À_±©…≥¬˛æÌ");
			SetAction(19,"πÌµ¿_∆Ô≥À_±©…≥¬˛æÌ");
			SetAction(20,"πÌµ¿_∆Ô≥À_±©…≥¬˛æÌ");
			SetAction(21,"πÌµ¿_∆Ô≥À_±©…≥¬˛æÌ");
			SetAction(22,"πÌµ¿_∆Ô≥À_±©…≥¬˛æÌ");
			SetAction(23,"πÌµ¿_∆Ô≥À_±©…≥¬˛æÌ");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "±©…≥¬˛æÌ";
			nativename = "±©…≥¬˛æÌ";
			icon = "±©…≥¬˛æÌ.dds";
			SetTalent(0,1148);
			SetTalent(1,1149);
			SetTalent(2,1151);
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
			int				skill_t2 = skill.GetT2();
			int				skill_t4 = skill.GetT4();

			return (-900 * skill_t2) - 300 * skill_t4 + 6000;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={75,77,79,81,83,85,87,89,92};return array[level-1];
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

			return ((14 * skill_level) + (skill_level * (skill_level * 1.1f)) + 315.0f);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();
			int				skill_t1 = skill.GetT1();

			victim.SetProbability(((5 * skill_t1 + 33)));
			victim.SetTime(8100.0f);
			victim.SetBuffid(1);
			victim.SetValue(((skill_t1 * 0.3f + 1.0f) * ((10 * skill_level + 5))));
			victim.SetSubdefence(true);
			return true;
		}
		public override float GetDropRate(GSkill skill)
		{
			return 0.400000f;
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={24};return array[index];
		}
	}
	public class GSkill1113 : GSkill
	{
		public GSkill1113()
			: base(1113)
		{
			
		}
	}
	public class GSkill1114Stub : GSkillStub
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
		public GSkill1114Stub()
			: base(1114)
		{
			occupation = 27;
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
			SetAction(0,"πÈ¡È√ÿ”°");
			SetAction(1,"πÈ¡È√ÿ”°");
			SetAction(2,"πÈ¡È√ÿ”°");
			SetAction(3,"πÈ¡È√ÿ”°");
			SetAction(4,"πÈ¡È√ÿ”°");
			SetAction(5,"πÈ¡È√ÿ”°");
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
			SetAction(16,"0");
			SetAction(17,"0");
			SetAction(18,"πÈ¡È√ÿ”°");
			SetAction(19,"πÈ¡È√ÿ”°");
			SetAction(20,"πÈ¡È√ÿ”°");
			SetAction(21,"πÈ¡È√ÿ”°");
			SetAction(22,"πÈ¡È√ÿ”°");
			SetAction(23,"πÈ¡È√ÿ”°");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "πÈ¡È√ÿ”°";
			nativename = "πÈ¡È√ÿ”°";
			icon = "πÈ¡È√ÿ”°.dds";
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
			int[] array={75,79,83,87,91,94,97,100,103};return array[level-1];
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
			int				player_maxmp = player.GetMaxmp();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();
			int				skill_t1 = skill.GetT1();

			victim.SetProbability(((5 * skill_t0 + 33)));
			victim.SetTime(((3000 * (skill_t1 + skill_level) + 27100)));
			victim.SetRatio((skill_t0 * 0.01f + (skill_level * 0.01f)));
			victim.SetAttack2mp(true);
			victim.SetTime(((3000 * (skill_t1 + skill_level) + 27100)));
			victim.SetRatio(0.85000002f);
			victim.SetAmount(((2 * skill_level * player_maxmp + 1)));
			victim.SetMagicshield(true);
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={1113};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={1};return array[index];
		}
	}
	public class GSkill1114 : GSkill
	{
		public GSkill1114()
			: base(1114)
		{
			
		}
	}
	public class GSkill1115Stub : GSkillStub
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
		public GSkill1115Stub()
			: base(1115)
		{
			occupation = 27;
			maxlevel = 20;
			maxlearn = 10;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 3;
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
			SetAction(0,"‘ππÌ–ƒƒß");
			SetAction(1,"‘ππÌ–ƒƒß");
			SetAction(2,"‘ππÌ–ƒƒß");
			SetAction(3,"‘ππÌ–ƒƒß");
			SetAction(4,"‘ππÌ–ƒƒß");
			SetAction(5,"‘ππÌ–ƒƒß");
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
			SetAction(18,"‘ππÌ–ƒƒß");
			SetAction(19,"‘ππÌ–ƒƒß");
			SetAction(20,"‘ππÌ–ƒƒß");
			SetAction(21,"‘ππÌ–ƒƒß");
			SetAction(22,"‘ππÌ–ƒƒß");
			SetAction(23,"‘ππÌ–ƒƒß");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "‘ππÌ–ƒƒß";
			nativename = "‘ππÌ–ƒƒß";
			icon = "‘ππÌ–ƒƒß.dds";
			SetTalent(0,1162);
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

			return 90000 - 9000 * skill_t1;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={75,80,85,90,95,100,105,110,115,120};return array[level-1];
		}
		public override float GetPraydistance(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (skill_level + 10);
		}
		public override float GetCastdistance(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (skill_level + 8);
		}
		public override float GetEffectdistance(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (skill_level + 12);
		}
		public override float GetMpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (30 * skill_level + 350);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();
			int				skill_t2 = skill.GetT2();

			victim.SetProbability(100.0f);
			victim.SetTime(((2000 * (norm(zrand(100) / (100 - 10 * skill_t2)) + 1) * (skill_t2 + skill_level))));
			victim.SetRatio((skill_level * 0.03f));
			victim.SetBuffid(1);
			victim.SetValue(((skill_t0 * 0.3f + 1.0f) * ((skill_level * skill_level + (30 * skill_level)))));
			victim.SetXinmo(true);
			victim.SetProbability(((120 * (skill_level / 10))));
			victim.SetTime(((2000 * (norm(zrand(100) / (100 - 10 * skill_t2)) + 1) * (skill_t2 + skill_level))));
			victim.SetRatio(0.1f);
			victim.SetBuffid(1);
			victim.SetIncfatalratio(true);
			victim.SetProbability(((120 * (skill_level / 10) * (zrand(100) / (100 - 8 * skill_t0)))));
			victim.SetTime(((2000 * (norm(zrand(100) / (100 - 10 * skill_t2)) + 1) * (skill_t2 + skill_level))));
			victim.SetRatio((skill_t0 * 0.04f));
			victim.SetBuffid(2);
			victim.SetIncfatalratio(true);
			victim.SetProbability(-1.0f);
			victim.SetTime(((2000 * (norm(zrand(100) / (100 - 10 * skill_t2)) + 1) * (skill_t2 + skill_level))));
			victim.SetRatio((skill_t0 * 0.3f));
			victim.SetBuffid(1);
			victim.SetIncfatalhurt(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_t0 = skill.GetT0();

			victim.SetProbability(((100 * skill_t0)));
			victim.SetClearweak(true);
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={1113};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={1};return array[index];
		}
	}
	public class GSkill1115 : GSkill
	{
		public GSkill1115()
			: base(1115)
		{
			
		}
	}
	public class GSkill1116Stub : GSkillStub
	{
		public GSkill1116Stub()
			: base(1116)
		{
			occupation = 27;
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
			name = "πÌ∆ı÷˝ªÍ";
			nativename = "πÌ∆ı÷˝ªÍ";
			icon = "πÌ∆ı÷˝ªÍ.dds";
			SetTalent(0,1147);
			SetTalent(1,1164);
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
			int[] array={80,83,86,89,92,95};return array[level-1];
		}
		public override bool TakeEffect(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();
			int				skill_t1 = skill.GetT1();

			player.SetPasaddhp(((30 * skill_level)));
			player.SetPasaddanti(((2 * (skill_level * skill_t1 + (2 * skill_level)))));
			player.SetPasadddefence(((5 * skill_t0 * skill_level)));
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={1113};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={3};return array[index];
		}
	}
	public class GSkill1116 : GSkill
	{
		public GSkill1116()
			: base(1116)
		{
			
		}
	}
	public class GSkill1117Stub : GSkillStub
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
				int				skill_level = skill.GetLevel();

				player.SetVar1(player_maxhp);
				skill.SetRatio((skill_level <= 13)?(0.02f * skill_level + 0.48f):(0.02f * (skill_level - 13) + 0.48f));
				skill.SetPlus(((player_mp + player_hp) * 0.03f));
				player.SetPerform(1);
			}
		}
		public GSkill1117Stub()
			: base(1117)
		{
			occupation = 27;
			maxlevel = 30;
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
			SetAction(0,"∏ø◊„…ﬂπ∆");
			SetAction(1,"∏ø◊„…ﬂπ∆");
			SetAction(2,"∏ø◊„…ﬂπ∆");
			SetAction(3,"∏ø◊„…ﬂπ∆");
			SetAction(4,"∏ø◊„…ﬂπ∆");
			SetAction(5,"∏ø◊„…ﬂπ∆");
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
			SetAction(18,"∏ø◊„…ﬂπ∆");
			SetAction(19,"∏ø◊„…ﬂπ∆");
			SetAction(20,"∏ø◊„…ﬂπ∆");
			SetAction(21,"∏ø◊„…ﬂπ∆");
			SetAction(22,"∏ø◊„…ﬂπ∆");
			SetAction(23,"∏ø◊„…ﬂπ∆");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "∏ø◊„…ﬂπ∆";
			nativename = "∏ø◊„…ﬂπ∆";
			icon = "∏ø◊„…ﬂπ∆.dds";
			SetTalent(0,1182);
			SetTalent(1,1185);
			SetTalent(2,1189);
			SetTalent(3,2062);
			SetTalent(4,1169);
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
			int[] array={85,87,89,91,93,95,97,99,102,106,110,114};return array[level-1];
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

			return (skill_level <= 13)?(0.25f * ((skill_level * 4.42f + (skill_level * (14.08f * skill_level))) + 1888.0f)):(1.25f * (0.25f * (((skill_level - 13) * 4.42f + ((skill_level - 13) * (14.08f * (skill_level - 13)))) + 1888.0f)))/**/;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_level = player.GetLevel();
			int				player_hp = player.GetHp();
			int				player_var1 = player.GetVar1();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();
			int				skill_t1 = skill.GetT1();
			int				skill_t2 = skill.GetT2();
			int				skill_t3 = skill.GetT3();
			int				skill_t4 = skill.GetT4();

			victim.SetProbability(((skill_t2 * 0.1f + 1.0f) * ((skill_t3 * 0.03f + (1.0f - player_level * 0.002f)) * 100.0f)));
			victim.SetTime(((32000 - 2000 * skill_t2)));
			victim.SetBuffid(2);
			float amount = (skill_level <= 13)?(player_hp * (skill_t1 * (skill_level * 0.005f)) + ((skill_t1 * 0.1f + 1.0f) * (((skill_level << 7) + (skill_level * (6.27f * skill_level))) + 1837.0f))):((skill_t4 * 0.4f + 1.0f) * (player_hp * (skill_t1 * ((skill_level - 13) * 0.005f)) + ((skill_t1 * 0.1f + 1.0f) * ((((skill_level << 7) - 1664) + ((skill_level - 13) * (6.27f * (skill_level - 13)))) + 1837.0f))));
			victim.SetAmount(amount);
			float value = (skill_level <= 13)?(skill_t0 * (0.1f * (((skill_level << 7) + (skill_level * (6.27f * skill_level))) + 1837.0f))):(skill_t0 * ((skill_t4 * 0.4f + 1.0f) * (0.1f * ((((skill_level << 7) - 1664) + ((skill_level - 13) * (6.27f * (skill_level - 13)))) + 1837.0f))));
			victim.SetValue(value);
			victim.SetHpleak2(true);
			victim.SetProbability(120.0f);
			victim.SetTime(32100.0f);
			victim.SetBuffid(1);
			float value1 = (skill_level <= 13)?(5 * (skill_t0 + 1) * skill_level):((5 * skill_level - 65) * (skill_t0 + 1));
			victim.SetValue(value1);
			victim.SetSubanti(true);
			victim.SetProbability(((5 * skill_t3)));
			victim.SetTime(10000.0f);
			victim.SetRatio((skill_t3 * 0.01f + (norm(skill_t3 / 0.9f) * (skill_level * 0.01f))));
			victim.SetAmount(((2 * player_var1)));
			victim.SetAccumdamage(true);
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={1114};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={3};return array[index];
		}
	}
	public class GSkill1117 : GSkill
	{
		public GSkill1117()
			: base(1117)
		{
			
		}
	}
	public class GSkill1118Stub : GSkillStub
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
		public GSkill1118Stub()
			: base(1118)
		{
			occupation = 27;
			maxlevel = 20;
			maxlearn = 10;
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
			SetAction(0,"”¸ª¡∂ªÍ");
			SetAction(1,"”¸ª¡∂ªÍ");
			SetAction(2,"”¸ª¡∂ªÍ");
			SetAction(3,"”¸ª¡∂ªÍ");
			SetAction(4,"”¸ª¡∂ªÍ");
			SetAction(5,"”¸ª¡∂ªÍ");
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
			SetAction(18,"”¸ª¡∂ªÍ");
			SetAction(19,"”¸ª¡∂ªÍ");
			SetAction(20,"”¸ª¡∂ªÍ");
			SetAction(21,"”¸ª¡∂ªÍ");
			SetAction(22,"”¸ª¡∂ªÍ");
			SetAction(23,"”¸ª¡∂ªÍ");
			SetAction(24,"");
			SetAction(25,"");
			SetAction(26,"");
			SetAction(27,"");
			SetAction(28,"");
			SetAction(29,"");
			SetAction(30,"");
			name = "”¸ª¡∂ªÍ";
			nativename = "”¸ª¡∂ªÍ";
			icon = "”¸ª¡∂ªÍ.dds";
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

			return 180000 - 18000 * skill_t1;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={85,89,93,97,101,106,111,116,121,125};return array[level-1];
		}
		public override float GetRadius(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (2 * skill_level + 6);
		}
		public override float GetPraydistance(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (2 * skill_level + 6);
		}
		public override float GetCastdistance(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (3 * skill_level + 4);
		}
		public override float GetMpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (2 * ((skill_level * skill_level) * skill_level + (60 * skill_level)));
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
			victim.SetTime(((3000 * skill_level + 6100)));
			victim.SetBuffid(1);
			victim.SetAmount(((3000 - 100 * skill_level)));
			victim.SetValue(((skill_t0 * 0.15f + 1.0f) * ((4 * ((skill_level * skill_level) * skill_level + (45 * skill_level))))));
			victim.SetSubhp(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();

			victim.SetProbability(100.0f);
			victim.SetTime(((3000 * skill_level + 6100)));
			victim.SetBuffid(1);
			victim.SetAmount(((3000 - 100 * skill_level)));
			victim.SetValue(((2 * ((skill_level * skill_level) * skill_level + (45 * skill_level)))));
			victim.SetSubhp(true);
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={1115};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={2};return array[index];
		}
	}
	public class GSkill1118 : GSkill
	{
		public GSkill1118()
			: base(1118)
		{
			
		}
	}
	public class GSkill1119Stub : GSkillStub
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
				int				skill_t0 = skill.GetT0();
				int				skill_t3 = skill.GetT3();
				int				skill_t4 = skill.GetT4();

				skill.SetRatio((skill_t4 * 0.02f + (skill_t0 * 0.05f + 1.0f)));
				skill.SetCrit((norm(skill_t4 / 9.9f) * 0.03f + (skill_t3 * 0.01f)));
				skill.SetCrithurt((skill_t3 * 0.1f));
				skill.SetPlus((skill_level * (skill_level * 0.1f) + ((20 * skill_level + 736))));
				player.SetPerform(1);
			}
		}
		public GSkill1119Stub()
			: base(1119)
		{
			occupation = 27;
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
			SetAction(0,"πÌµ¿_¡∂π«µÿ¥Ã");
			SetAction(1,"πÌµ¿_¡∂π«µÿ¥Ã");
			SetAction(2,"πÌµ¿_¡∂π«µÿ¥Ã");
			SetAction(3,"πÌµ¿_¡∂π«µÿ¥Ã");
			SetAction(4,"πÌµ¿_¡∂π«µÿ¥Ã");
			SetAction(5,"πÌµ¿_¡∂π«µÿ¥Ã");
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
			SetAction(18,"πÌµ¿_∆Ô≥À_¡∂π«µÿ¥Ã");
			SetAction(19,"πÌµ¿_∆Ô≥À_¡∂π«µÿ¥Ã");
			SetAction(20,"πÌµ¿_∆Ô≥À_¡∂π«µÿ¥Ã");
			SetAction(21,"πÌµ¿_∆Ô≥À_¡∂π«µÿ¥Ã");
			SetAction(22,"πÌµ¿_∆Ô≥À_¡∂π«µÿ¥Ã");
			SetAction(23,"πÌµ¿_∆Ô≥À_¡∂π«µÿ¥Ã");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "¡∂π«µÿ¥Ã";
			nativename = "¡∂π«µÿ¥Ã";
			icon = "¡∂π«µÿ¥Ã.dds";
			SetTalent(0,1148);
			SetTalent(1,1149);
			SetTalent(2,1151);
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
			int				skill_t2 = skill.GetT2();
			int				skill_t4 = skill.GetT4();

			return (-900 * skill_t2) - 300 * skill_t4 + 6000;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={90,92,94,96,98,100,102,104,107};return array[level-1];
		}
		public override float GetRadius(GSkill skill)
		{
			return 9.000000f;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 9.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 5.000000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 9.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (2 * skill_level * skill_level + (15 * skill_level) + 450);
		}
		public override int GetCoverage(GSkill skill)
		{
			return 24;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_level = player.GetLevel();
			int				skill_level = skill.GetLevel();
			int				skill_t1 = skill.GetT1();

			victim.SetProbability(((1.0f - player_level * 0.002f) * 100.0f));
			victim.SetTime(16000.0f);
			victim.SetBuffid(1);
			victim.SetAmount(((skill_t1 * 0.2f + 1.0f) * (skill_level * (skill_level * 0.1f) + ((20 * skill_level + 736)))));
			victim.SetValue(0.0f);
			victim.SetHpleak(true);
			victim.SetProbability(((5 * skill_level + 60)));
			victim.SetTime(16100.0f);
			victim.SetRatio(0.2f);
			victim.SetBuffid(1);
			victim.SetSlow(true);
			return true;
		}
		public override float GetDropRate(GSkill skill)
		{
			return 0.480000f;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={1116};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={4};return array[index];
		}
	}
	public class GSkill1119 : GSkill
	{
		public GSkill1119()
			: base(1119)
		{
			
		}
	}
}
