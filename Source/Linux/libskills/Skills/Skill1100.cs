using System;
using System.Text;

namespace SKILL
{
	public class GSkill1100Stub : GSkillStub
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

				skill.SetRatio((skill_t1 * 0.05f + 1.0f));
				skill.SetCrit((skill_t3 * 0.01f));
				skill.SetCrithurt((skill_t3 * 0.1f));
				skill.SetPlus(((skill_level * (skill_level * 0.66f) + (45.0f - skill_level * 1.2f)) * (D2INT(skill_level * 0.05f + 0.55f)) + (((D2INT(1.42f - skill_level * 0.05f)) * (3 * skill_level + 45)))));
				player.SetPerform(1);
			}
		}
		public GSkill1100Stub()
			: base(1100)
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
			SetAction(0,"¹íµÀ_½þµØ¶¾Ã¢");
			SetAction(1,"¹íµÀ_½þµØ¶¾Ã¢");
			SetAction(2,"¹íµÀ_½þµØ¶¾Ã¢");
			SetAction(3,"¹íµÀ_½þµØ¶¾Ã¢");
			SetAction(4,"¹íµÀ_½þµØ¶¾Ã¢");
			SetAction(5,"¹íµÀ_½þµØ¶¾Ã¢");
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
			SetAction(18,"¹íµÀ_Æï³Ë_½þµØ¶¾Ã¢");
			SetAction(19,"¹íµÀ_Æï³Ë_½þµØ¶¾Ã¢");
			SetAction(20,"¹íµÀ_Æï³Ë_½þµØ¶¾Ã¢");
			SetAction(21,"¹íµÀ_Æï³Ë_½þµØ¶¾Ã¢");
			SetAction(22,"¹íµÀ_Æï³Ë_½þµØ¶¾Ã¢");
			SetAction(23,"¹íµÀ_Æï³Ë_½þµØ¶¾Ã¢");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "½þµØ¶¾Ã¢";
			nativename = "½þµØ¶¾Ã¢";
			icon = "½þµØ¶¾Ã¢.dds";
			SetTalent(0,1142);
			SetTalent(1,1143);
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
			return 1000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			int				skill_t2 = skill.GetT2();

			return 6000 - 900 * skill_t2;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={30,32,34,36,38,40,42,44,47};return array[level-1];
		}
		public override float GetRadius(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (skill_level * 0.3f + 5.7f);
		}
		public override float GetPraydistance(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (skill_level * 0.3f + 5.7f);
		}
		public override float GetCastdistance(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (skill_level * 0.3f + 3.0f);
		}
		public override float GetMpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (8 * skill_level + 50);
		}
		public override int GetCoverage(GSkill skill)
		{
			return 12;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_level = player.GetLevel();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();
			int				skill_t1 = skill.GetT1();

			victim.SetProbability(((1.0f - player_level * 0.002f) * 100.0f));
			victim.SetTime(8000.0f);
			victim.SetBuffid(1);
			victim.SetAmount(((skill_t0 * 0.2f + 1.0f) * ((24 * skill_level + 96))));
			victim.SetValue(0.0f);
			victim.SetHpleak(true);
			victim.SetProbability(((600 * norm(zrand(100) / (100 - 3 * skill_t1)))));
			victim.SetTime(((3030 * skill_t1)));
			victim.SetRatio(0.15000001f);
			victim.SetBuffid(5);
			victim.SetWeak(true);
			return true;
		}
		public override float GetDropRate(GSkill skill)
		{
			return 0.240000f;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={1096};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={5};return array[index];
		}
	}
	public class GSkill1100 : GSkill
	{
		public GSkill1100()
			: base(1100)
		{
			
		}
	}
	public class GSkill1101Stub : GSkillStub
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

				skill.SetRatio((skill_t1 * 0.05f + 1.0f));
				skill.SetPlus((((skill_level * (skill_level * 2.3f)) - (12 * skill_level) + 210.0f) * (D2INT(skill_level * 0.05f + 0.55f)) + (((D2INT(1.42f - skill_level * 0.05f)) * (skill_level * skill_level + (7 * skill_level) + 150)))));
				player.SetPerform(1);
			}
		}
		public GSkill1101Stub()
			: base(1101)
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
			SetAction(0,"ÊÉ»êÑªÑÀ");
			SetAction(1,"ÊÉ»êÑªÑÀ");
			SetAction(2,"ÊÉ»êÑªÑÀ");
			SetAction(3,"ÊÉ»êÑªÑÀ");
			SetAction(4,"ÊÉ»êÑªÑÀ");
			SetAction(5,"ÊÉ»êÑªÑÀ");
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
			SetAction(18,"ÊÉ»êÑªÑÀ");
			SetAction(19,"ÊÉ»êÑªÑÀ");
			SetAction(20,"ÊÉ»êÑªÑÀ");
			SetAction(21,"ÊÉ»êÑªÑÀ");
			SetAction(22,"ÊÉ»êÑªÑÀ");
			SetAction(23,"ÊÉ»êÑªÑÀ");
			SetAction(24,"");
			SetAction(25,"");
			SetAction(26,"");
			SetAction(27,"");
			SetAction(28,"");
			SetAction(29,"");
			SetAction(30,"");
			name = "ÊÉ»êÑªÑÀ";
			nativename = "ÊÉ»êÑªÑÀ";
			icon = "ÊÉ»êÑªÑÀ.dds";
			SetTalent(0,1160);
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
		}
		public override int GetExecutetime(GSkill skill)
		{
			return 1000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			return 5000;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={35,37,39,41,43,45,47,49,52,56};return array[level-1];
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

			return (3 * skill_level + 15);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_hp = player.GetHp();
			int				player_maxhp = player.GetMaxhp();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();

			victim.SetProbability(((100 * norm((player_maxhp * (skill_t0 * 0.05f + ((skill_level - 1) * 0.05f + 0.15f))) / (player_hp + 1)))));
			victim.SetTime(100.0f);
			victim.SetBuffid(5);
			victim.SetAmount(((skill_t0 * 0.2f + 1.0f) * (((skill_level * (skill_level * 2.3f)) - (12 * skill_level) + 210.0f) * (D2INT(skill_level * 0.05f + 0.55f)) + (((D2INT(1.42f - skill_level * 0.05f)) * (skill_level * skill_level + (7 * skill_level) + 150))))));
			victim.SetValue(0.0f);
			victim.SetHpleak(true);
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={1099};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={5};return array[index];
		}
	}
	public class GSkill1101 : GSkill
	{
		public GSkill1101()
			: base(1101)
		{
			
		}
	}
	public class GSkill1102Stub : GSkillStub
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
		public GSkill1102Stub()
			: base(1102)
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
			dobless = true;
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
			SetAction(0,"¹íµÀ_»¤·¨¹íÓï");
			SetAction(1,"¹íµÀ_»¤·¨¹íÓï");
			SetAction(2,"¹íµÀ_»¤·¨¹íÓï");
			SetAction(3,"¹íµÀ_»¤·¨¹íÓï");
			SetAction(4,"¹íµÀ_»¤·¨¹íÓï");
			SetAction(5,"¹íµÀ_»¤·¨¹íÓï");
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
			SetAction(18,"¹íµÀ_Æï³Ë_»¤·¨¹íÓï");
			SetAction(19,"¹íµÀ_Æï³Ë_»¤·¨¹íÓï");
			SetAction(20,"¹íµÀ_Æï³Ë_»¤·¨¹íÓï");
			SetAction(21,"¹íµÀ_Æï³Ë_»¤·¨¹íÓï");
			SetAction(22,"¹íµÀ_Æï³Ë_»¤·¨¹íÓï");
			SetAction(23,"¹íµÀ_Æï³Ë_»¤·¨¹íÓï");
			SetAction(24,"");
			SetAction(25,"");
			SetAction(26,"");
			SetAction(27,"");
			SetAction(28,"");
			SetAction(29,"");
			SetAction(30,"");
			name = "»¤·¨¹íÓï";
			nativename = "»¤·¨¹íÓï";
			icon = "»¤·¨¹íÓï.dds";
			SetTalent(0,1176);
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
			int				skill_t0 = skill.GetT0();

			return 90000 - 4500 * skill_t0;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={40,43,47,52,58,65,73,82,92};return array[level-1];
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
			int				player_mp = player.GetMp();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();

			victim.SetTime(((2000 * (skill_t0 + skill_level) + 6100)));
			victim.SetImmunesleep(true);
			victim.SetTime(((2000 * (skill_t0 + skill_level) + 6100)));
			victim.SetImmunedizzy(true);
			victim.SetProbability(100.0f);
			victim.SetTime(24000.0f);
			victim.SetRatio(0.0f);
			victim.SetBuffid(1);
			victim.SetAmount(0.0f);
			victim.SetValue((player_mp * (skill_level * 0.02f)));
			victim.SetHpgen(true);
			victim.SetProbability(((30 * skill_t0)));
			victim.SetClearslow(true);
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={1098};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={3};return array[index];
		}
	}
	public class GSkill1102 : GSkill
	{
		public GSkill1102()
			: base(1102)
		{
			
		}
	}
	public class GSkill1103Stub : GSkillStub
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
				int				skill_t3 = skill.GetT3();

				skill.SetRatio(1.0f);
				skill.SetCrit((skill_t3 * 0.01f));
				skill.SetCrithurt((skill_t3 * 0.1f));
				skill.SetPlus((((13 * skill_level) + (skill_level * (skill_level * 0.7f)) + 27.0f) * (D2INT(skill_level * 0.05f + 0.55f)) + (((D2INT(1.42f - skill_level * 0.05f)) * (7 * skill_level + 110) + (5 * skill_level * skill_t0)))));
				player.SetPerform(1);
			}
		}
		public GSkill1103Stub()
			: base(1103)
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
			SetAction(0,"¹íµÀ_Ðý·çÂÒÎè");
			SetAction(1,"¹íµÀ_Ðý·çÂÒÎè");
			SetAction(2,"¹íµÀ_Ðý·çÂÒÎè");
			SetAction(3,"¹íµÀ_Ðý·çÂÒÎè");
			SetAction(4,"¹íµÀ_Ðý·çÂÒÎè");
			SetAction(5,"¹íµÀ_Ðý·çÂÒÎè");
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
			SetAction(18,"¹íµÀ_Æï³Ë_Ðý·çÂÒÎè");
			SetAction(19,"¹íµÀ_Æï³Ë_Ðý·çÂÒÎè");
			SetAction(20,"¹íµÀ_Æï³Ë_Ðý·çÂÒÎè");
			SetAction(21,"¹íµÀ_Æï³Ë_Ðý·çÂÒÎè");
			SetAction(22,"¹íµÀ_Æï³Ë_Ðý·çÂÒÎè");
			SetAction(23,"¹íµÀ_Æï³Ë_Ðý·çÂÒÎè");
			SetAction(24,"");
			SetAction(25,"");
			SetAction(26,"");
			SetAction(27,"");
			SetAction(28,"");
			SetAction(29,"");
			SetAction(30,"");
			name = "Ðý·çÂÒÎè";
			nativename = "Ðý·çÂÒÎè";
			icon = "Ðý·çÂÒÎè.dds";
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
			return 1000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			int				skill_t2 = skill.GetT2();

			return 6000 - 900 * skill_t2;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={45,47,49,51,53,55,57,59,62};return array[level-1];
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
			int				skill_level = skill.GetLevel();

			return (skill_level * 0.2f + 3.0f);
		}
		public override float GetMpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (7 * skill_level + 64);
		}
		public override int GetCoverage(GSkill skill)
		{
			return 15;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();
			int				skill_t1 = skill.GetT1();

			victim.SetProbability(((5 * skill_t1 + 33)));
			victim.SetTime(12100.0f);
			victim.SetBuffid(1);
			victim.SetValue(((skill_t1 * 0.5f + 1.0f) * ((8 * skill_level + 4))));
			victim.SetSubattack(true);
			return true;
		}
		public override float GetDropRate(GSkill skill)
		{
			return 0.300000f;
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={24};return array[index];
		}
	}
	public class GSkill1103 : GSkill
	{
		public GSkill1103()
			: base(1103)
		{
			
		}
	}
	public class GSkill1104Stub : GSkillStub
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
		public GSkill1104Stub()
			: base(1104)
		{
			occupation = 26;
			maxlevel = 4;
			maxlearn = 3;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 4;
			timetype = 1;
			targettype = 0;
			rangetype = 5;
			doenchant = true;
			dobless = true;
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
			name = "Óù¿ÕÊõ";
			nativename = "Óù¿ÕÊõ";
			icon = "Óù¿ÕÊõ.dds";
			SetTalent(0,1177);
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
		}
		public override int GetExecutetime(GSkill skill)
		{
			return 1;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();

			return (-5000 * skill_level) - 2000 * skill_t0 + 30000;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={46,50,76};return array[level-1];
		}
		public override float GetPraydistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return player_range;
		}
		public override float GetCastdistance(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (skill_level * 2.5f + 5.0f);
		}
		public override float GetMpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (240 - 40 * skill_level);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_t0 = skill.GetT0();

			victim.SetTime(5000.0f);
			victim.SetValue(15.0f);
			victim.SetDodge(true);
			victim.SetRatio(((39 * norm(zrand(100) / (95 - 15 * skill_t0)) + 1093)));
			victim.SetAmount(((12 * norm(zrand(100) / (95 - 15 * skill_t0)) + 1093)));
			victim.SetValue(((16 * norm(zrand(100) / (95 - 15 * skill_t0)) + 1093)));
			victim.SetClearcooldown(true);
			victim.SetRatio(((21 * norm(zrand(100) / (95 - 15 * skill_t0)) + 1093)));
			victim.SetAmount(((norm(zrand(100) / (95 - 15 * skill_t0)) + 1093)));
			victim.SetValue(((25 * norm(zrand(100) / (95 - 15 * skill_t0)) + 1093)));
			victim.SetClearcooldown(true);
			victim.SetRatio(((28 * norm(zrand(100) / (95 - 15 * skill_t0)) + 1093)));
			victim.SetAmount(((30 * norm(zrand(100) / (95 - 15 * skill_t0)) + 1093)));
			victim.SetValue(((31 * norm(zrand(100) / (95 - 15 * skill_t0)) + 1093)));
			victim.SetClearcooldown(true);
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={1103};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={1};return array[index];
		}
	}
	public class GSkill1104 : GSkill
	{
		public GSkill1104()
			: base(1104)
		{
			
		}
	}
	public class GSkill1105Stub : GSkillStub
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
		public GSkill1105Stub()
			: base(1105)
		{
			occupation = 26;
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
			SetAction(0,"ÓÄÈª¹í²½");
			SetAction(1,"ÓÄÈª¹í²½");
			SetAction(2,"ÓÄÈª¹í²½");
			SetAction(3,"ÓÄÈª¹í²½");
			SetAction(4,"ÓÄÈª¹í²½");
			SetAction(5,"ÓÄÈª¹í²½");
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
			SetAction(18,"ÓÄÈª¹í²½");
			SetAction(19,"ÓÄÈª¹í²½");
			SetAction(20,"ÓÄÈª¹í²½");
			SetAction(21,"ÓÄÈª¹í²½");
			SetAction(22,"ÓÄÈª¹í²½");
			SetAction(23,"ÓÄÈª¹í²½");
			SetAction(24,"");
			SetAction(25,"");
			SetAction(26,"");
			SetAction(27,"");
			SetAction(28,"");
			SetAction(29,"");
			SetAction(30,"");
			name = "ÓÄÈª¹í²½";
			nativename = "ÓÄÈª¹í²½";
			icon = "ÓÄÈª¹í²½.dds";
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

			return 180000 - 18000 * skill_t1;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={46,49,52,55,58,61,64,68};return array[level-1];
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
			int				skill_t2 = skill.GetT2();

			victim.SetTime((((2000 * skill_t2 + (3000 * skill_level) + 12100) * (norm(zrand(100) / (100 - 10 * skill_t2)) + 1))));
			victim.SetRatio((skill_t0 * 0.15f + (skill_level * 0.15f + 0.25f)));
			victim.SetAmount(2.0f);
			victim.SetValue(((5 * skill_level + 10)));
			victim.SetFocusanti(true);
			victim.SetProbability(((100 * skill_t0)));
			victim.SetClearwrap(true);
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={1103};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={1};return array[index];
		}
	}
	public class GSkill1105 : GSkill
	{
		public GSkill1105()
			: base(1105)
		{
			
		}
	}
	public class GSkill1106Stub : GSkillStub
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
		public GSkill1106Stub()
			: base(1106)
		{
			occupation = 26;
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
			SetAction(18,"±äÉí");
			SetAction(19,"±äÉí");
			SetAction(20,"±äÉí");
			SetAction(21,"±äÉí");
			SetAction(22,"±äÉí");
			SetAction(23,"±äÉí");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "¹ÆÍõ×ËÌ¬";
			nativename = "¹ÆÍõ×ËÌ¬";
			icon = "¹ÆÍõÐÎÌ¬.dds";
			SetTalent(0,1140);
			SetTalent(1,1181);
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
			int[] array={55,70,85,100,115,125,125,125};return array[level-1];
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

			victim.SetProbability(0.0f);
			victim.SetRatio(((-25 * skill_level)));
			victim.SetBuffid(((24 * skill_t1 * (skill_level * skill_level) + (40 * skill_t1 * skill_level)) + 120 * skill_level * skill_level + (200 * skill_level)));
			victim.SetAmount(((5 * skill_level + 25)));
			victim.SetValue(((35 * skill_level)));
			victim.SetInsanityform(true);
			victim.SetProbability(120.0f);
			victim.SetTime(((4000 * norm(skill_t1))));
			victim.SetRatio((skill_t1 * 0.25f));
			victim.SetAmount(0.0f);
			victim.SetValue(100.0f);
			victim.SetRetort(true);
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={1104};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={1};return array[index];
		}
	}
	public class GSkill1106 : GSkill
	{
		public GSkill1106()
			: base(1106)
		{
			
		}
	}
	public class GSkill1107Stub : GSkillStub
	{
		public GSkill1107Stub()
			: base(1107)
		{
			occupation = 26;
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
			name = "Îå¹íÀ÷»ê";
			nativename = "Îå¹íÀ÷»ê";
			icon = "Îå¹íÀ÷»ê.dds";
			SetTalent(0,1146);
			SetTalent(1,1147);
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
			int[] array={50,53,56,59,62,65};return array[level-1];
		}
		public override bool TakeEffect(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();
			int				skill_t1 = skill.GetT1();

			player.SetPasaddhp(((20 * skill_level)));
			player.SetPasaddattack(((3 * skill_t0 * skill_level + (8 * skill_level))));
			player.SetPasadddefence(((5 * skill_t1 * skill_level)));
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={1103};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={3};return array[index];
		}
	}
	public class GSkill1107 : GSkill
	{
		public GSkill1107()
			: base(1107)
		{
			
		}
	}
	public class GSkill1108Stub : GSkillStub
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

				skill.SetRatio((skill_level * 0.02f + 0.48f));
				player.SetPerform(1);
			}
		}
		public GSkill1108Stub()
			: base(1108)
		{
			occupation = 26;
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
			dobless = true;
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
			SetAction(0,"Ê´ÐÄ¶¾¹Æ");
			SetAction(1,"Ê´ÐÄ¶¾¹Æ");
			SetAction(2,"Ê´ÐÄ¶¾¹Æ");
			SetAction(3,"Ê´ÐÄ¶¾¹Æ");
			SetAction(4,"Ê´ÐÄ¶¾¹Æ");
			SetAction(5,"Ê´ÐÄ¶¾¹Æ");
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
			SetAction(18,"Ê´ÐÄ¶¾¹Æ");
			SetAction(19,"Ê´ÐÄ¶¾¹Æ");
			SetAction(20,"Ê´ÐÄ¶¾¹Æ");
			SetAction(21,"Ê´ÐÄ¶¾¹Æ");
			SetAction(22,"Ê´ÐÄ¶¾¹Æ");
			SetAction(23,"Ê´ÐÄ¶¾¹Æ");
			SetAction(24,"");
			SetAction(25,"");
			SetAction(26,"");
			SetAction(27,"");
			SetAction(28,"");
			SetAction(29,"");
			SetAction(30,"");
			name = "Ê´ÐÄ¶¾¹Æ";
			nativename = "Ê´ÐÄ¶¾¹Æ";
			icon = "Ê´ÐÄ¶¾¹Æ.dds";
			SetTalent(0,1178);
			SetTalent(1,1185);
			SetTalent(2,1189);
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
			return 7000;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={55,57,59,61,63,65,67,69,72,76,80,84};return array[level-1];
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

			return ((skill_level * 22.4f + (skill_level * (skill_level * 1.728f)) + 311.68f) * 0.25f);
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

			victim.SetProbability(((skill_t2 * 0.1f + 1.0f) * ((1.0f - player_level * 0.002f) * 100.0f)));
			victim.SetTime(((18000 - 2000 * skill_t2)));
			victim.SetBuffid(1);
			victim.SetAmount((player_hp * (skill_level * (skill_t1 * 0.005f)) + ((skill_t1 * 0.1f + 1.0f) * (skill_level * 22.4f + (skill_level * (skill_level * 1.728f)) + 311.68f))));
			victim.SetValue((skill_t0 * ((skill_level * 22.4f + (skill_level * (skill_level * 1.728f)) + 311.68f) * 0.1f)));
			victim.SetHpleak(true);
			victim.SetProbability(-1.0f);
			victim.SetTime(((6020 * skill_t0)));
			victim.SetRatio(0.2f);
			victim.SetBuffid(1);
			victim.SetSlow(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_mp = player.GetMp();

			victim.SetProbability(100.0f);
			victim.SetTime(8100.0f);
			victim.SetBuffid(5);
			victim.SetValue((player_mp * 0.002f + 1.0f));
			victim.SetAdddefence(true);
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={1106};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={1};return array[index];
		}
	}
	public class GSkill1108 : GSkill
	{
		public GSkill1108()
			: base(1108)
		{
			
		}
	}
	public class GSkill1109Stub : GSkillStub
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
		public GSkill1109Stub()
			: base(1109)
		{
			occupation = 26;
			maxlevel = 12;
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
			SetAction(0,"Ô¹Äîî¿÷ã");
			SetAction(1,"Ô¹Äîî¿÷ã");
			SetAction(2,"Ô¹Äîî¿÷ã");
			SetAction(3,"Ô¹Äîî¿÷ã");
			SetAction(4,"Ô¹Äîî¿÷ã");
			SetAction(5,"Ô¹Äîî¿÷ã");
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
			SetAction(18,"Ô¹Äîî¿÷ã");
			SetAction(19,"Ô¹Äîî¿÷ã");
			SetAction(20,"Ô¹Äîî¿÷ã");
			SetAction(21,"Ô¹Äîî¿÷ã");
			SetAction(22,"Ô¹Äîî¿÷ã");
			SetAction(23,"Ô¹Äîî¿÷ã");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "Ô¹Äîî¿÷ã";
			nativename = "Ô¹Äîî¿÷ã";
			icon = "Ô¹Äîî¿÷ã.dds";
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
			int[] array={55,58,61,64,68,72,76,81};return array[level-1];
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

			victim.SetProbability(100.0f);
			victim.SetTime(((3000 * skill_level + 12100)));
			victim.SetPowerless(true);
			victim.SetTime(((3000 * skill_level + 12100)));
			victim.SetRatio((skill_t0 * 0.05f + (skill_level * 0.05f)));
			victim.SetBuffid(1);
			victim.SetIncskilldamage(true);
			victim.SetTime(4100.0f);
			victim.SetRatio(0.050000001f);
			victim.SetInccritrate(true);
			victim.SetTime(((3000 * skill_level + 12100)));
			victim.SetImmunesilent(true);
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={1105};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={3};return array[index];
		}
	}
	public class GSkill1109 : GSkill
	{
		public GSkill1109()
			: base(1109)
		{
			
		}
	}
}
