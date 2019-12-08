using System;
using System.Text;

namespace SKILL
{
	public class GSkill520Stub : GSkillStub
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

				skill.SetRatio((skill_level * (skill_t1 * 0.05f + 0.22f)));
				player.SetPerform(1);
			}
		}
		public GSkill520Stub()
			: base(520)
		{
			occupation = 13;
			maxlevel = 4;
			maxlearn = 3;
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
			SetAction(0,"������_���ն");
			SetAction(1,"������_���ն");
			SetAction(2,"������_���ն");
			SetAction(3,"������_���ն");
			SetAction(4,"������_���ն");
			SetAction(5,"������_���ն");
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
			SetAction(18,"������_���_���ն");
			SetAction(19,"������_���_���ն");
			SetAction(20,"������_���_���ն");
			SetAction(21,"������_���_���ն");
			SetAction(22,"������_���_���ն");
			SetAction(23,"������_���_���ն");
			SetAction(24,"");
			SetAction(25,"");
			SetAction(26,"");
			SetAction(27,"");
			SetAction(28,"");
			SetAction(29,"");
			SetAction(30,"");
			name = "���ն";
			nativename = "���ն";
			icon = "���ն.dds";
			SetTalent(0,645);
			SetTalent(1,667);
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
			int				skill_t1 = skill.GetT1();

			return 60000 - 15000 * skill_t1;
		}
		public override int GetEnmity(GSkill skill)
		{
			return 1;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={106,114,122};return array[level-1];
		}
		public override float GetPraydistance(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (4 * skill_level + 10);
		}
		public override float GetCastdistance(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (4 * skill_level + 8);
		}
		public override float GetEffectdistance(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (4 * skill_level + 12);
		}
		public override float GetMpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return ((skill_level * (skill_level * 0.46f)) - skill_level * 1.3f + 151.0f);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_hp = player.GetHp();
			int				player_maxhp = player.GetMaxhp();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();
			int				skill_iscrit = skill.GetIscrit();

			victim.SetProbability(((3.0f - (player_hp + player_hp) / player_maxhp) * ((10 * skill_level + 5)) + ((200 * norm((zrand((D2INT((3.0f - (player_hp + player_hp) / player_maxhp) * ((10 * skill_level + 5) * 1.6f))) + 100)) / 100)))));
			victim.SetTime(((4000 * skill_level + 8100)));
			victim.SetRatio((skill_level * 0.2f + 0.2f));
			victim.SetBuffid(1);
			victim.SetSlow(true);
			victim.SetProbability(-1.0f);
			victim.SetTime(2000.0f);
			victim.SetBuffid(1);
			victim.SetAmount(((D2INT(zrand(100) / (100 - 6 * skill_t0)) + 1) * ((skill_t0 * 0.8f + 1.0f) * ((90 * skill_level)))));
			victim.SetValue(0.0f);
			victim.SetHpleak5(true);
			victim.SetProbability(skill_iscrit <= 0?0.0f:120.0f);
			victim.SetRatio(11.0f);
			victim.SetAmount(11.0f);
			victim.SetValue(11.0f);
			victim.SetDispel(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_t0 = skill.GetT0();

			victim.SetTime(((5000 * norm(skill_t0))));
			victim.SetRatio((skill_t0 * 0.03f));
			victim.SetInccritrate(true);
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={519};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={1};return array[index];
		}
	}
	public class GSkill520 : GSkill
	{
		public GSkill520()
			: base(520)
		{
			
		}
	}
	public class GSkill521Stub : GSkillStub
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
				int				skill_level = skill.GetLevel();
				int				skill_t0 = skill.GetT0();

				skill.SetRatio((skill_t0 * 0.15f + 0.0f));
				skill.SetPlus((player_mp * (skill_level * 0.1f + 0.8f)));
				skill.SetRatio((skill_t0 * 0.15f + 0.0f));
				skill.SetPlus((player_mp * (skill_level * 0.1f + 0.8f)));
				player.SetMp((player_mp * 0.5f));
				player.SetPerform(1);
			}
		}
		public GSkill521Stub()
			: base(521)
		{
			occupation = 13;
			maxlevel = 13;
			maxlearn = 7;
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
			SetAction(0,"������_������");
			SetAction(1,"������_������");
			SetAction(2,"������_������");
			SetAction(3,"������_������");
			SetAction(4,"������_������");
			SetAction(5,"������_������");
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
			SetAction(18,"������_���_������");
			SetAction(19,"������_���_������");
			SetAction(20,"������_���_������");
			SetAction(21,"������_���_������");
			SetAction(22,"������_���_������");
			SetAction(23,"������_���_������");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "������";
			nativename = "������";
			icon = "������.dds";
			SetTalent(0,650);
			SetTalent(1,659);
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
			int				skill_t1 = skill.GetT1();

			return 75000 - 10000 * skill_t1;
		}
		public override int GetEnmity(GSkill skill)
		{
			return 1;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={106,109,113,117,121,125,125};return array[level-1];
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
			return 15.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			return 1.000000f;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={519};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={1};return array[index];
		}
	}
	public class GSkill521 : GSkill
	{
		public GSkill521()
			: base(521)
		{
			
		}
	}
	public class GSkill522Stub : GSkillStub
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
		public GSkill522Stub()
			: base(522)
		{
			occupation = 13;
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
			SetAction(0,"������_��������");
			SetAction(1,"������_��������");
			SetAction(2,"������_��������");
			SetAction(3,"������_��������");
			SetAction(4,"������_��������");
			SetAction(5,"������_��������");
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
			SetAction(18,"������_���_��������");
			SetAction(19,"������_���_��������");
			SetAction(20,"������_���_��������");
			SetAction(21,"������_���_��������");
			SetAction(22,"������_���_��������");
			SetAction(23,"������_���_��������");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "��������";
			nativename = "��������";
			icon = "��������.dds";
			SetTalent(0,632);
			SetTalent(1,649);
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
			int				skill_t1 = skill.GetT1();

			return 120000 - 15000 * skill_t1;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={110,112,114,116,118,120,122,124};return array[level-1];
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

			return (15 * skill_level + 360);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();
			int				skill_t1 = skill.GetT1();

			victim.SetTime(((2000 * skill_t1 + 18100)));
			victim.SetValue(((2 * (skill_t0 * skill_level + skill_level) + 1)));
			victim.SetBlessed(true);
			victim.SetTime(((1500 * norm(skill_t0 / 1.5f) + 2000)));
			victim.SetInvincible(true);
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={519};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={3};return array[index];
		}
	}
	public class GSkill522 : GSkill
	{
		public GSkill522()
			: base(522)
		{
			
		}
	}
	public class GSkill523Stub : GSkillStub
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
				int				skill_t2 = skill.GetT2();

				skill.SetRatio((skill_t1 * 0.05f + 1.0f));
				skill.SetPlus(((skill_t2 * 0.07000000000000001f + 1.0f) * (((D2INT(skill_level * 0.05f + 0.55f)) * ((3 * skill_level * skill_level) - 7 * skill_level + 686)) + ((((52 * skill_level + 556)) - skill_level * (skill_level * 2.4f)) * (D2INT(1.42f - skill_level * 0.05f))))));
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
				int				skill_t2 = skill.GetT2();

				skill.SetRatio((skill_t1 * 0.05f + 1.0f));
				skill.SetPlus(((skill_t2 * 0.07000000000000001f + 1.0f) * (((D2INT(skill_level * 0.05f + 0.55f)) * ((3 * skill_level * skill_level) - 7 * skill_level + 686)) + ((((52 * skill_level + 556)) - skill_level * (skill_level * 2.4f)) * (D2INT(1.42f - skill_level * 0.05f))))));
				player.SetPerform(0);
			}
		}
		public GSkill523Stub()
			: base(523)
		{
			occupation = 13;
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
			SetAction(0,"������_������");
			SetAction(1,"������_������");
			SetAction(2,"������_������");
			SetAction(3,"������_������");
			SetAction(4,"������_������");
			SetAction(5,"������_������");
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
			SetAction(18,"������_���_������");
			SetAction(19,"������_���_������");
			SetAction(20,"������_���_������");
			SetAction(21,"������_���_������");
			SetAction(22,"������_���_������");
			SetAction(23,"������_���_������");
			SetAction(24,"");
			SetAction(25,"");
			SetAction(26,"");
			SetAction(27,"");
			SetAction(28,"");
			SetAction(29,"");
			SetAction(30,"");
			name = "������";
			nativename = "������";
			icon = "������.dds";
			SetTalent(0,631);
			SetTalent(1,634);
			SetTalent(2,661);
			SetTalent(3,665);
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
		}
		public override int GetExecutetime(GSkill skill)
		{
			return 2000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			int				skill_t2 = skill.GetT2();
			int				skill_t3 = skill.GetT3();

			return (-1000 * skill_t3) - 1350 * skill_t2 + 9000;
		}
		public override int GetEnmity(GSkill skill)
		{
			return 1;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={115,117,119,121,123,125,125,125,125};return array[level-1];
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

			return ((skill_level * (skill_level * 1.7f)) - skill_level * 5.8f + 640.0f);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_hp = player.GetHp();
			int				player_maxhp = player.GetMaxhp();
			int				player_maxmp = player.GetMaxmp();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();
			int				skill_t1 = skill.GetT1();
			int				skill_t3 = skill.GetT3();

			victim.SetProbability(((10 * skill_t0 + 33)));
			victim.SetTime(((6000 * skill_t3 + 6100)));
			victim.SetBuffid(1);
			victim.SetAmount((player_maxhp * 0.15f + 1.0f));
			victim.SetValue(((skill_t0 * 0.6f + 1.0f) * ((95 * skill_level + (5 * skill_level * skill_level)))));
			victim.SetSubhp(true);
			victim.SetProbability(-1.0f);
			victim.SetTime(((6000 * skill_t3 + 6100)));
			victim.SetBuffid(1);
			victim.SetAmount((player_maxmp * 0.15f + 1.0f));
			victim.SetValue(((skill_t0 * 0.6f + 1.0f) * ((114 * skill_level + (6 * skill_level * skill_level)))));
			victim.SetSubmp(true);
			victim.SetProbability(((2 * skill_level)));
			victim.SetTime(100.0f);
			victim.SetBuffid(2);
			victim.SetAmount((player_hp * (skill_t1 * 0.12f)));
			victim.SetValue(0.0f);
			victim.SetHpleak1(true);
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={520};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={2};return array[index];
		}
	}
	public class GSkill523 : GSkill
	{
		public GSkill523()
			: base(523)
		{
			
		}
	}
	public class GSkill524Stub : GSkillStub
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
		public GSkill524Stub()
			: base(524)
		{
			occupation = 13;
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
			SetAction(0,"������_��Ѫħ��");
			SetAction(1,"������_��Ѫħ��");
			SetAction(2,"������_��Ѫħ��");
			SetAction(3,"������_��Ѫħ��");
			SetAction(4,"������_��Ѫħ��");
			SetAction(5,"������_��Ѫħ��");
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
			SetAction(18,"������_���_��Ѫħ��");
			SetAction(19,"������_���_��Ѫħ��");
			SetAction(20,"������_���_��Ѫħ��");
			SetAction(21,"������_���_��Ѫħ��");
			SetAction(22,"������_���_��Ѫħ��");
			SetAction(23,"������_���_��Ѫħ��");
			SetAction(24,"");
			SetAction(25,"");
			SetAction(26,"");
			SetAction(27,"");
			SetAction(28,"");
			SetAction(29,"");
			SetAction(30,"");
			name = "��Ѫħ��";
			nativename = "��Ѫħ��";
			icon = "��Ѫħ��.dds";
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

			return 120000 - 12000 * skill_t2;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={115,118,121,124,125,125,125,125};return array[level-1];
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

			return (10 * skill_level + 330);
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
			int				skill_t3 = skill.GetT3();

			victim.SetProbability(100.0f);
			victim.SetTime(((2000 * skill_t1 + 16100)));
			victim.SetRatio(1.0f);
			victim.SetAmount(((5 * skill_t3 + (D2INT(skill_level / 3)) + 5)));
			victim.SetValue(((4 * skill_t0 * skill_level + (skill_level * skill_level + (20 * skill_level)))));
			victim.SetBloodshield(true);
			victim.SetProbability(skill_t1 <= 0?0.0f:120.0f);
			victim.SetTime(((60000 * skill_t1)));
			victim.SetBuffid(1);
			victim.SetAmount((skill_t1 * 0.1f + 0.00001f));
			victim.SetValue((player_maxmp * (skill_t1 * 0.06f)));
			victim.SetAddhp2(true);
			victim.SetProbability(((120 * norm(skill_level / 1.5f))));
			victim.SetAmount(((skill_level / 2)));
			victim.SetCleardebuff(true);
			victim.SetProbability(player_var1 <= 950?0.0f:(120 * norm(skill_t1 / 3.9f)));
			victim.SetRatio(0.0f);
			victim.SetValue(player_maxhp);
			victim.SetHeal(true);
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={521};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={3};return array[index];
		}
	}
	public class GSkill524 : GSkill
	{
		public GSkill524()
			: base(524)
		{
			
		}
	}
	public class GSkill525Stub : GSkillStub
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
				return 800;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				skill_level = skill.GetLevel();
				int				skill_t0 = skill.GetT0();

				skill.SetRatio(1.08f);
				skill.SetPlus(((skill_t0 * 0.07000000000000001f + 1.0f) * (D2INT(((D2INT(skill_level * 0.05f + 0.55f)) * ((118 * skill_level) - 3 * skill_level * skill_level - 144)) + (((13 * skill_level) + (skill_level * (skill_level * 0.078f)) + 490.0f) * (D2INT(1.42f - skill_level * 0.05f)))))));
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

				skill.SetRatio(1.08f);
				skill.SetPlus(((skill_t0 * 0.07000000000000001f + 1.0f) * (D2INT(((D2INT(skill_level * 0.05f + 0.55f)) * ((118 * skill_level) - 3 * skill_level * skill_level - 144)) + (((13 * skill_level) + (skill_level * (skill_level * 0.078f)) + 490.0f) * (D2INT(1.42f - skill_level * 0.05f)))))));
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

				skill.SetRatio(1.08f);
				skill.SetPlus(((skill_t0 * 0.07000000000000001f + 1.0f) * (D2INT(((D2INT(skill_level * 0.05f + 0.55f)) * ((118 * skill_level) - 3 * skill_level * skill_level - 144)) + (((13 * skill_level) + (skill_level * (skill_level * 0.078f)) + 490.0f) * (D2INT(1.42f - skill_level * 0.05f)))))));
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
				return 800;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				skill_level = skill.GetLevel();
				int				skill_t0 = skill.GetT0();

				skill.SetRatio(1.08f);
				skill.SetPlus(((skill_t0 * 0.07000000000000001f + 1.0f) * (D2INT(((D2INT(skill_level * 0.05f + 0.55f)) * ((118 * skill_level) - 3 * skill_level * skill_level - 144)) + (((13 * skill_level) + (skill_level * (skill_level * 0.078f)) + 490.0f) * (D2INT(1.42f - skill_level * 0.05f)))))));
				player.SetPerform(0);
			}
		}
		public GSkill525Stub()
			: base(525)
		{
			occupation = 13;
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
			SetAction(0,"������_������ɱ");
			SetAction(1,"������_������ɱ");
			SetAction(2,"������_������ɱ");
			SetAction(3,"������_������ɱ");
			SetAction(4,"������_������ɱ");
			SetAction(5,"������_������ɱ");
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
			SetAction(18,"������_���_������ɱ");
			SetAction(19,"������_���_������ɱ");
			SetAction(20,"������_���_������ɱ");
			SetAction(21,"������_���_������ɱ");
			SetAction(22,"������_���_������ɱ");
			SetAction(23,"������_���_������ɱ");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "������ɱ";
			nativename = "������ɱ";
			icon = "������ɱ.dds";
			SetTalent(0,661);
			SetTalent(1,665);
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
			AddState(new GState5());
		}
		public override int GetExecutetime(GSkill skill)
		{
			return 4000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			int				skill_t0 = skill.GetT0();

			return 10000 - 1500 * skill_t0;
		}
		public override int GetEnmity(GSkill skill)
		{
			return 1;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={120,122,124,125,125,125,125,125,125};return array[level-1];
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

			return ((skill_level * (skill_level * 2.4f)) - skill_level * 1.6f + 920.0f);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();
			int				skill_t1 = skill.GetT1();

			victim.SetProbability(((7 * skill_t1 + (3 * skill_level) + 3)));
			victim.SetTime(((3000 * skill_t1 + 3100)));
			victim.SetBarehanded(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_maxhp = player.GetMaxhp();
			int				skill_level = skill.GetLevel();

			victim.SetProbability(((3 * skill_level + 9)));
			victim.SetTime(8000.0f);
			victim.SetRatio(0.0f);
			victim.SetBuffid(1);
			victim.SetAmount(0.0f);
			victim.SetValue((player_maxhp * (skill_level * 0.01f)));
			victim.SetHpgen(true);
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={522};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={5};return array[index];
		}
	}
	public class GSkill525 : GSkill
	{
		public GSkill525()
			: base(525)
		{
			
		}
	}
	public class GSkill526Stub : GSkillStub
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
				int				player_res3 = player.GetRes3();

				player.SetVar1(player_res3);
				player.SetPerform(1);
			}
		}
		public GSkill526Stub()
			: base(526)
		{
			occupation = 13;
			maxlevel = 20;
			maxlearn = 7;
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
			SetAction(0,"������_�޼��");
			SetAction(1,"������_�޼��");
			SetAction(2,"������_�޼��");
			SetAction(3,"������_�޼��");
			SetAction(4,"������_�޼��");
			SetAction(5,"������_�޼��");
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
			SetAction(18,"������_���_�޼��");
			SetAction(19,"������_���_�޼��");
			SetAction(20,"������_���_�޼��");
			SetAction(21,"������_���_�޼��");
			SetAction(22,"������_���_�޼��");
			SetAction(23,"������_���_�޼��");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "�޼��";
			nativename = "�޼��";
			icon = "�޼��.dds";
			SetTalent(0,633);
			SetTalent(1,648);
			SetTalent(2,668);
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
			int				skill_t0 = skill.GetT0();

			return 120000 - 12000 * skill_t0;
		}
		public override int GetEnmity(GSkill skill)
		{
			return 1;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={125,125,125,125,125,125,125};return array[level-1];
		}
		public override float GetRadius(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (3 * skill_level + 9);
		}
		public override float GetPraydistance(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (3 * skill_level + 9);
		}
		public override float GetCastdistance(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (3 * skill_level + 6);
		}
		public override float GetMpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (skill_level * (skill_level * 1.7f) + ((16 * skill_level + 632)));
		}
		public override int GetCoverage(GSkill skill)
		{
			return 40;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_level = player.GetLevel();
			int				player_var1 = player.GetVar1();
			int				skill_level = skill.GetLevel();
			int				skill_t1 = skill.GetT1();
			int				skill_t2 = skill.GetT2();

			victim.SetProbability(player_var1 <= 600?600.0f:player_var1);
			victim.SetTime(((skill_t1 * 0.3f + 1.0f) * ((1000 * skill_level + 3000)) + 100.0f));
			victim.SetWrap(true);
			victim.SetProbability(((1.0f - player_level * 0.002f) * 100.0f));
			victim.SetTime(((14000 - 2000 * skill_t2)));
			victim.SetBuffid(1);
			victim.SetAmount((((skill_t2 * (120 * skill_level + 60)) * skill_level)));
			victim.SetValue(0.0f);
			victim.SetHpleak(true);
			victim.SetProbability(600.0f);
			victim.SetTime(((2050 * skill_t1)));
			victim.SetSilent(true);
			victim.SetProbability(600.0f);
			victim.SetTime(((skill_t1 * 0.3f + 1.0f) * ((1000 * skill_level + 3000)) + 100.0f));
			victim.SetRatio(1.0f);
			victim.SetBuffid(1);
			victim.SetSlow(true);
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={524};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={4};return array[index];
		}
	}
	public class GSkill526 : GSkill
	{
		public GSkill526()
			: base(526)
		{
			
		}
	}
	public class GSkill527Stub : GSkillStub
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
				int				player_maxatk = player.GetMaxatk();

				player.SetVar1(player_maxatk);
				player.SetPerform(1);
			}
		}
		public GSkill527Stub()
			: base(527)
		{
			occupation = 13;
			maxlevel = 18;
			maxlearn = 9;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 2;
			timetype = 1;
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
			SetAction(0,"������_�Խ���");
			SetAction(1,"������_�Խ���");
			SetAction(2,"������_�Խ���");
			SetAction(3,"������_�Խ���");
			SetAction(4,"������_�Խ���");
			SetAction(5,"������_�Խ���");
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
			SetAction(18,"������_���_�Խ���");
			SetAction(19,"������_���_�Խ���");
			SetAction(20,"������_���_�Խ���");
			SetAction(21,"������_���_�Խ���");
			SetAction(22,"������_���_�Խ���");
			SetAction(23,"������_���_�Խ���");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "�Խ���";
			nativename = "�Խ���";
			icon = "�Խ���.dds";
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
		}
		public override int GetCooldowntime(GSkill skill)
		{
			return 12000;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={125,125,125,125,125,125,125,125,125};return array[level-1];
		}
		public override float GetRadius(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (skill_level * 0.5f + 8.5f);
		}
		public override float GetPraydistance(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (skill_level * 0.5f + 8.5f);
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 9.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (235 - 5 * skill_level);
		}
		public override int GetCoverage(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return skill_level + 15;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_var1 = player.GetVar1();
			int				skill_level = skill.GetLevel();

			victim.SetProbability(((120 * (skill_level / 1.5f))));
			victim.SetTime(5000.0f);
			victim.SetRatio(((skill_level / 2) * 0.015f));
			victim.SetBuffid(6);
			victim.SetIncfatalratio(true);
			victim.SetProbability(120.0f);
			victim.SetTime(100.0f);
			victim.SetBuffid(2);
			victim.SetAmount((player_var1 * (skill_level * 0.03f + 0.11f)));
			victim.SetValue(0.0f);
			victim.SetHpleak3(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();

			victim.SetTime(3600000.0f);
			victim.SetRatio(0.0f);
			victim.SetAmount(20.0f);
			victim.SetValue(0.0f);
			victim.SetEvilaura(true);
			victim.SetProbability(((120 * (skill_level / 1.5f))));
			victim.SetTime(60000.0f);
			victim.SetRatio(((skill_level / 2) * 0.015f));
			victim.SetBuffid(2);
			victim.SetIncskillaccu(true);
			return true;
		}
		public override float GetDropRate(GSkill skill)
		{
			return 0.300000f;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={523};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={6};return array[index];
		}
	}
	public class GSkill527 : GSkill
	{
		public GSkill527()
			: base(527)
		{
			
		}
	}
	public class GSkill528Stub : GSkillStub
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
				int				skill_t2 = skill.GetT2();

				skill.SetCrit((skill_t1 * 0.02f));
				skill.SetCrithurt((skill_level * 0.08f));
				skill.SetRatio((skill_t2 * 0.05f + (skill_level * 0.03f + 1.22f)));
				skill.SetPlus(((((3 * skill_level * skill_level)) - skill_level * 0.064f + 974.0f) * (D2INT(skill_level * 0.05f + 0.55f)) + (((18 * skill_level) + (skill_level * (skill_level * 0.1f)) + 921.0f) * (D2INT(1.42f - skill_level * 0.05f)))));
				player.SetPerform(1);
			}
		}
		public GSkill528Stub()
			: base(528)
		{
			occupation = 16;
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
			SetAction(0,"�ϻ���_��Ӱ");
			SetAction(1,"�ϻ���_��Ӱ");
			SetAction(2,"�ϻ���_��Ӱ");
			SetAction(3,"�ϻ���_��Ӱ");
			SetAction(4,"�ϻ���_��Ӱ");
			SetAction(5,"�ϻ���_��Ӱ");
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
			SetAction(18,"�ϻ���_���_��Ӱ");
			SetAction(19,"�ϻ���_���_��Ӱ");
			SetAction(20,"�ϻ���_���_��Ӱ");
			SetAction(21,"�ϻ���_���_��Ӱ");
			SetAction(22,"�ϻ���_���_��Ӱ");
			SetAction(23,"�ϻ���_���_��Ӱ");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "��Ӱ";
			nativename = "��Ӱ";
			icon = "��Ӱ.dds";
			SetTalent(0,723);
			SetTalent(1,731);
			SetTalent(2,732);
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
			return 2000;
		}
		public override int GetEnmity(GSkill skill)
		{
			return 1;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={105,107,109,111,113,115,117,119,122};return array[level-1];
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

			return ((skill_level * (skill_level * 1.3f)) - skill_level * 3.5f + 501.0f);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_level = player.GetLevel();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();

			victim.SetProbability(((1.0f - player_level * 0.002f) * ((15 * skill_t0))));
			victim.SetTime(((4000 * norm(skill_t0))));
			victim.SetBuffid(1);
			victim.SetAmount((((((3 * skill_level * skill_level)) - skill_level * 0.064f + 974.0f) * (D2INT(skill_level * 0.05f + 0.55f)) + (((18 * skill_level) + (skill_level * (skill_level * 0.1f)) + 921.0f) * (D2INT(1.42f - skill_level * 0.05f)))) * (skill_t0 * 0.15f)));
			victim.SetValue(0.0f);
			victim.SetHpleak(true);
			return true;
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={24};return array[index];
		}
	}
	public class GSkill528 : GSkill
	{
		public GSkill528()
			: base(528)
		{
			
		}
	}
	public class GSkill529Stub : GSkillStub
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

				skill.SetCrit((skill_t3 * 0.01f));
				skill.SetCrithurt((skill_t3 * 0.1f));
				skill.SetRatio((skill_t1 * 0.05f + 1.0f));
				skill.SetPlus((((D2INT(skill_level * 0.05f + 0.55f)) * (50 * skill_level + 543)) + (((39 * skill_level) + (skill_level * (skill_level * 0.57f)) + 531.0f) * (D2INT(1.42f - skill_level * 0.05f)))));
				player.SetPerform(1);
			}
		}
		public GSkill529Stub()
			: base(529)
		{
			occupation = 16;
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
			SetAction(0,"�ϻ���_��ϼ");
			SetAction(1,"�ϻ���_��ϼ");
			SetAction(2,"�ϻ���_��ϼ");
			SetAction(3,"�ϻ���_��ϼ");
			SetAction(4,"�ϻ���_��ϼ");
			SetAction(5,"�ϻ���_��ϼ");
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
			SetAction(18,"�ϻ���_���_��ϼ");
			SetAction(19,"�ϻ���_���_��ϼ");
			SetAction(20,"�ϻ���_���_��ϼ");
			SetAction(21,"�ϻ���_���_��ϼ");
			SetAction(22,"�ϻ���_���_��ϼ");
			SetAction(23,"�ϻ���_���_��ϼ");
			SetAction(24,"");
			SetAction(25,"");
			SetAction(26,"");
			SetAction(27,"");
			SetAction(28,"");
			SetAction(29,"");
			SetAction(30,"");
			name = "��ϼ";
			nativename = "��ϼ";
			icon = "��ϼ.dds";
			SetTalent(0,743);
			SetTalent(1,742);
			SetTalent(2,749);
			SetTalent(3,753);
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
		public override int GetCooldowntime(GSkill skill)
		{
			return 4000;
		}
		public override int GetEnmity(GSkill skill)
		{
			return 1;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={106,109,113,117,121,125,125,125,125};return array[level-1];
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

			return (skill_level * 5.3f + (skill_level * (skill_level * 0.99f)) + 380.0f);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_level = player.GetLevel();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();
			int				skill_t2 = skill.GetT2();

			victim.SetTime(12100.0f);
			victim.SetBuffid(2);
			victim.SetValue(((skill_t2 * 0.2f + 1.0f) * ((6 * skill_level + 16))));
			victim.SetSubantiwrap(true);
			victim.SetTime(12100.0f);
			victim.SetBuffid(2);
			victim.SetValue(((skill_t2 * 0.2f + 1.0f) * ((4 * skill_level + 12))));
			victim.SetSubantisilent(true);
			victim.SetTime(12100.0f);
			victim.SetBuffid(2);
			victim.SetValue(((skill_t2 * 0.2f + 1.0f) * ((2 * skill_level + 4))));
			victim.SetSubantidizzy(true);
			victim.SetProbability(((1.0f - player_level * 0.002f) * ((8 * skill_t0 + 50))));
			victim.SetRatio(((D2INT(zrand(100) / (100 - 4 * skill_t0)) + 1) * 0.36f));
			victim.SetXiaoxin(true);
			return true;
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={528};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={1};return array[index];
		}
	}
	public class GSkill529 : GSkill
	{
		public GSkill529()
			: base(529)
		{
			
		}
	}
}
