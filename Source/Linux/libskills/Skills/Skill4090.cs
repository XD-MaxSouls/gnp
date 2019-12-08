using System;
using System.Text;

namespace SKILL
{
	public class GSkill4090Stub : GSkillStub
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
				int				player_level = player.GetLevel();
				int				player_hp = player.GetHp();
				int				player_maxhp = player.GetMaxhp();
				int				player_mp = player.GetMp();
				int				player_maxmp = player.GetMaxmp();
				int				player_maxatk = player.GetMaxatk();
				int				player_def = player.GetDef();
				int				player_res1 = player.GetRes1();
				int				player_res2 = player.GetRes2();
				int				player_res3 = player.GetRes3();
				int				player_res4 = player.GetRes4();
				int				player_res5 = player.GetRes5();
				int				player_occupation = player.GetOccupation();
				int				skill_level = skill.GetLevel();
				int				skill_t0 = skill.GetT0();
				int				skill_t1 = skill.GetT1();

				/*
				player.SetVar11(player_occupation);
				player.SetVar1(player_maxatk);
				player.SetVar2(player_maxhp);
				player.SetVar3(player_maxmp);
				player.SetVar4(player_hp);
				player.SetVar5(player_mp);
				player.SetVar6(player_res1);
				player.SetVar7(player_res2);
				player.SetVar8(player_res3);
				player.SetVar9(player_res4);
				player.SetVar10(player_res5);
				if ( zrand(100) >= (skill_level + 1) * (skill_level + 1) )
				    v = 2;
				  else
				    v = 1;
				player.SetVar16(v);
				skill.SetRatio((D2INT(player_level / (9 - skill_level)) * 0.01f + (skill_level * 0.07000000000000001f + (skill_t0 * 0.03f + 1.0f))));
				skill.SetPlus((player_def * (skill_t1 * 0.03f) + ((215 * (zrand(249 * skill_level + 50) + skill_level) * skill_level) * 0.01f)));
				player.SetPerform(1);
				*/
			}
		}
		public GSkill4090Stub()
			: base(4090)
		{
			occupation = 130;
			maxlevel = 5;
			maxlearn = 5;
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
			SetAction(0,"鬼道_法宝_否极泰来");
			SetAction(1,"青云门_法宝_否极泰来");
			SetAction(2,"鬼王宗_法宝_否极泰来");
			SetAction(3,"合欢派_法宝_否极泰来");
			SetAction(4,"天音寺_法宝_否极泰来");
			SetAction(5,"鬼道_法宝_否极泰来");
			SetAction(6,"焚香谷_法宝_否极泰来");
			SetAction(7,"兽神_法宝_否极泰来");
			SetAction(8,"狐妖_法宝_否极泰来");
			SetAction(9,"轩辕_法宝_否极泰来");
			SetAction(10,"怀光_法宝_否极泰来");
			SetAction(11,"太昊_法宝_否极泰来");
			SetAction(12,"天华_法宝_否极泰来");
			SetAction(13,"灵夙_法宝_否极泰来");
			SetAction(14,"英招_法宝_否极泰来");
			SetAction(15,"0");
			SetAction(16,"0");
			SetAction(17,"天音寺_法宝_否极泰来");
			SetAction(18,"鬼道_骑乘_法宝_否极泰来");
			SetAction(19,"青云门_骑乘_法宝_否极泰来");
			SetAction(20,"鬼王宗_骑乘_法宝_否极泰来");
			SetAction(21,"合欢派_骑乘_法宝_否极泰来");
			SetAction(22,"天音寺_骑乘_法宝_否极泰来");
			SetAction(23,"鬼道_骑乘_法宝_否极泰来");
			SetAction(24,"焚香谷_骑乘_法宝_否极泰来");
			SetAction(25,"兽神_骑乘_法宝_否极泰来");
			SetAction(26,"狐妖_骑乘_法宝_否极泰来");
			SetAction(27,"轩辕_骑乘_法宝_否极泰来");
			SetAction(28,"怀光_骑乘_法宝_否极泰来");
			SetAction(29,"太昊_骑乘_法宝_否极泰来");
			SetAction(30,"天华_骑乘_法宝_否极泰来");
			name = "真·否极泰来";
			nativename = "真·否极泰来";
			icon = "飞升否极泰来.dds";
			SetTalent(0,687);
			SetTalent(1,1582);
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
			return 2000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return 6300 - 300 * skill_level;
		}
		public override int GetEnmity(GSkill skill)
		{
			return 1;
		}
		public override float GetPraydistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return (D2INT((player_range / 13.0f)) * 2.8f + (D2INT(player_range / 8.9f) * 1.8f + ((player_range * 0.5f) - D2INT(player_range / 3.9f) * 0.3f)) + 0.05f + 5.0f);
		}
		public override float GetCastdistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return (D2INT((player_range / 13.0f)) * 2.8f + (D2INT(player_range / 8.9f) * 1.8f + ((player_range * 0.5f) - D2INT(player_range / 3.9f) * 0.3f)) + 0.05f);
		}
		public override float GetEffectdistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return (D2INT((player_range / 13.0f)) * 2.8f + (D2INT(player_range / 8.9f) * 1.8f + ((player_range * 0.5f) - D2INT(player_range / 3.9f) * 0.3f)) + 0.05f + 10.0f);
		}
		public override float GetMpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return ((-35 * skill_level) - skill_level * skill_level + 445);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetTalismaneffects(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetTalismaneffectsbless(true);
			return true;
		}
	}
	public class GSkill4090 : GSkill
	{
		public GSkill4090()
			: base(4090)
		{
			
		}
	}
	public class GSkill4091Stub : GSkillStub
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
				int				player_level = player.GetLevel();
				int				player_def = player.GetDef();
				int				skill_level = skill.GetLevel();
				int				skill_t0 = skill.GetT0();
				int				skill_t1 = skill.GetT1();

				skill.SetRatio((D2INT(player_level / (9 - skill_level)) * 0.01f + (skill_level * 0.06f + (skill_t0 * 0.1f + 1.0f))));
				skill.SetPlus((player_def * (skill_t1 * 0.03f) + ((215 * skill_level))));
				player.SetPerform(1);
			}
		}
		public GSkill4091Stub()
			: base(4091)
		{
			occupation = 130;
			maxlevel = 3;
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
			SetAction(0,"鬼道_法宝_七星印");
			SetAction(1,"青云门_法宝_七星印");
			SetAction(2,"鬼王宗_法宝_七星印");
			SetAction(3,"合欢派_法宝_七星印");
			SetAction(4,"天音寺_法宝_七星印");
			SetAction(5,"鬼道_法宝_七星印");
			SetAction(6,"焚香谷_法宝_七星印");
			SetAction(7,"兽神_法宝_七星印");
			SetAction(8,"狐妖_法宝_七星印");
			SetAction(9,"0");
			SetAction(10,"怀光_法宝_七星印");
			SetAction(11,"太昊_法宝_七星印");
			SetAction(12,"天华_法宝_七星印");
			SetAction(13,"");
			SetAction(14,"");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"鬼道_骑乘_法宝_七星印");
			SetAction(19,"青云门_骑乘_法宝_七星印");
			SetAction(20,"鬼王宗_骑乘_法宝_七星印");
			SetAction(21,"合欢派_骑乘_法宝_七星印");
			SetAction(22,"天音寺_骑乘_法宝_七星印");
			SetAction(23,"鬼道_骑乘_法宝_七星印");
			SetAction(24,"焚香谷_骑乘_法宝_七星印");
			SetAction(25,"兽神_骑乘_法宝_七星印");
			SetAction(26,"狐妖_骑乘_法宝_七星印");
			SetAction(27,"0");
			SetAction(28,"怀光_骑乘_法宝_七星印");
			SetAction(29,"太昊_骑乘_法宝_七星印");
			SetAction(30,"天华_骑乘_法宝_七星印");
			name = "元宵灯祝";
			nativename = "元宵灯祝";
			icon = "华彰星陨.dds";
			SetTalent(0,721);
			SetTalent(1,1582);
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
			return 2000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return 6300 - 300 * skill_level;
		}
		public override float GetRadius(GSkill skill)
		{
			return 4.000000f;
		}
		public override float GetPraydistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return (D2INT((player_range / 13.0f)) * 2.8f + (D2INT(player_range / 8.9f) * 1.8f + ((player_range * 0.5f) - D2INT(player_range / 3.9f) * 0.3f)) + 0.05f + 5.0f);
		}
		public override float GetCastdistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return (D2INT((player_range / 13.0f)) * 2.8f + (D2INT(player_range / 8.9f) * 1.8f + ((player_range * 0.5f) - D2INT(player_range / 3.9f) * 0.3f)) + 0.05f);
		}
		public override float GetEffectdistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return (D2INT((player_range / 13.0f)) * 2.8f + (D2INT(player_range / 8.9f) * 1.8f + ((player_range * 0.5f) - D2INT(player_range / 3.9f) * 0.3f)) + 0.05f + 10.0f);
		}
		public override float GetMpcost(GSkill skill)
		{
			return -125.000000f;
		}
		public override int GetCoverage(GSkill skill)
		{
			return 2;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();

			victim.SetProbability(50.0f);
			victim.SetTime(12100.0f);
			victim.SetBuffid(0);
			victim.SetValue(200.0f);
			victim.SetSubdefence(true);
			victim.SetProbability(((skill_level * skill_level + 15)));
			victim.SetTime(10100.0f);
			victim.SetRatio((skill_level * (skill_level * 0.01f) + (skill_level * 0.01f)));
			victim.SetBuffid(5);
			victim.SetDecaccuracy(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_level = player.GetLevel();

			victim.SetProbability(25.0f);
			victim.SetRatio(0.0f);
			victim.SetValue(((3 * player_level + 300)));
			victim.SetHeal(true);
			return true;
		}
	}
	public class GSkill4091 : GSkill
	{
		public GSkill4091()
			: base(4091)
		{
			
		}
	}
	public class GSkill4092Stub : GSkillStub
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
				int				player_level = player.GetLevel();
				int				player_hp = player.GetHp();
				int				player_maxhp = player.GetMaxhp();
				int				player_mp = player.GetMp();
				int				player_maxmp = player.GetMaxmp();
				int				player_maxatk = player.GetMaxatk();
				int				player_def = player.GetDef();
				int				player_res1 = player.GetRes1();
				int				player_res2 = player.GetRes2();
				int				player_res3 = player.GetRes3();
				int				player_res4 = player.GetRes4();
				int				player_res5 = player.GetRes5();
				int				player_occupation = player.GetOccupation();
				int				skill_level = skill.GetLevel();
				int				skill_t0 = skill.GetT0();
				int				skill_t1 = skill.GetT1();

				/*
				player.SetVar11(player_occupation);
				player.SetVar1(player_maxatk);
				player.SetVar2(player_maxhp);
				player.SetVar3(player_maxmp);
				player.SetVar4(player_hp);
				player.SetVar5(player_mp);
				player.SetVar6(player_res1);
				player.SetVar7(player_res2);
				player.SetVar8(player_res3);
				player.SetVar9(player_res4);
				player.SetVar10(player_res5);
				if ( zrand(100) >= (skill_level + 1) * (skill_level + 1) )
				    v = 2;
				  else
				    v = 1;
				player.SetVar16(v);
				skill.SetRatio((D2INT(player_level / (9 - skill_level)) * 0.01f + (skill_level * 0.07000000000000001f + (skill_t0 * 0.03f + 1.0f))));
				skill.SetPlus((player_def * (skill_t1 * 0.03f) + ((player_mp + player_hp) * (skill_level * 0.01f) + ((215 * skill_level)))));
				player.SetPerform(1);
				*/
			}
		}
		public GSkill4092Stub()
			: base(4092)
		{
			occupation = 130;
			maxlevel = 5;
			maxlearn = 5;
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
			SetAction(0,"鬼道_法宝_江山如画");
			SetAction(1,"青云门_法宝_江山如画");
			SetAction(2,"鬼王宗_法宝_江山如画");
			SetAction(3,"合欢派_法宝_江山如画");
			SetAction(4,"天音寺_法宝_江山如画");
			SetAction(5,"鬼道_法宝_江山如画");
			SetAction(6,"焚香谷_法宝_江山如画");
			SetAction(7,"兽神_法宝_江山如画");
			SetAction(8,"狐妖_法宝_江山如画");
			SetAction(9,"轩辕_法宝_江山如画");
			SetAction(10,"怀光_法宝_江山如画");
			SetAction(11,"太昊_法宝_江山如画");
			SetAction(12,"天华_法宝_江山如画");
			SetAction(13,"0");
			SetAction(14,"0");
			SetAction(15,"武器大师_法宝_江山如画");
			SetAction(16,"武器大师_法宝_江山如画");
			SetAction(17,"天音寺_法宝_江山如画");
			SetAction(18,"鬼道_骑乘_法宝_江山如画");
			SetAction(19,"青云门_骑乘_法宝_江山如画");
			SetAction(20,"鬼王宗_骑乘_法宝_江山如画");
			SetAction(21,"合欢派_骑乘_法宝_江山如画");
			SetAction(22,"天音寺_骑乘_法宝_江山如画");
			SetAction(23,"鬼道_骑乘_法宝_江山如画");
			SetAction(24,"焚香谷_骑乘_法宝_江山如画");
			SetAction(25,"兽神_骑乘_法宝_江山如画");
			SetAction(26,"狐妖_骑乘_法宝_江山如画");
			SetAction(27,"轩辕_骑乘_法宝_江山如画");
			SetAction(28,"怀光_骑乘_法宝_江山如画");
			SetAction(29,"太昊_骑乘_法宝_江山如画");
			SetAction(30,"天华_骑乘_法宝_江山如画");
			name = "真·江山如画";
			nativename = "真·江山如画";
			icon = "飞升江山如画.dds";
			SetTalent(0,687);
			SetTalent(1,1582);
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
			return 2000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return 6300 - 300 * skill_level;
		}
		public override float GetPraydistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return (D2INT((player_range / 13.0f)) * 2.8f + (D2INT(player_range / 8.9f) * 1.8f + ((player_range * 0.5f) - D2INT(player_range / 3.9f) * 0.3f)) + 0.05f + 5.0f);
		}
		public override float GetCastdistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return (D2INT((player_range / 13.0f)) * 2.8f + (D2INT(player_range / 8.9f) * 1.8f + ((player_range * 0.5f) - D2INT(player_range / 3.9f) * 0.3f)) + 0.05f);
		}
		public override float GetEffectdistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return (D2INT((player_range / 13.0f)) * 2.8f + (D2INT(player_range / 8.9f) * 1.8f + ((player_range * 0.5f) - D2INT(player_range / 3.9f) * 0.3f)) + 0.05f + 10.0f);
		}
		public override float GetMpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return ((-35 * skill_level) - skill_level * skill_level + 445);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetTalismaneffects(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetTalismaneffectsbless(true);
			return true;
		}
	}
	public class GSkill4092 : GSkill
	{
		public GSkill4092()
			: base(4092)
		{
			
		}
	}
	public class GSkill4093Stub : GSkillStub
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
				int				player_level = player.GetLevel();
				int				player_hp = player.GetHp();
				int				player_maxhp = player.GetMaxhp();
				int				player_mp = player.GetMp();
				int				player_maxmp = player.GetMaxmp();
				int				player_maxatk = player.GetMaxatk();
				int				player_def = player.GetDef();
				int				player_res1 = player.GetRes1();
				int				player_res2 = player.GetRes2();
				int				player_res3 = player.GetRes3();
				int				player_res4 = player.GetRes4();
				int				player_res5 = player.GetRes5();
				int				player_occupation = player.GetOccupation();
				int				skill_level = skill.GetLevel();
				int				skill_t0 = skill.GetT0();
				int				skill_t1 = skill.GetT1();

				/*
				player.SetVar11(player_occupation);
				player.SetVar1(player_maxatk);
				player.SetVar2(player_maxhp);
				player.SetVar3(player_maxmp);
				player.SetVar4(player_hp);
				player.SetVar5(player_mp);
				player.SetVar6(player_res1);
				player.SetVar7(player_res2);
				player.SetVar8(player_res3);
				player.SetVar9(player_res4);
				player.SetVar10(player_res5);
				if ( zrand(100) >= (skill_level + 1) * (skill_level + 1) )
				    v = 2;
				  else
				    v = 1;
				player.SetVar16(v);
				skill.SetCrit((D2INT(zrand(101) / 75) * (skill_level * 0.02f + 0.05f) + 0.0001f));
				skill.SetCrithurt((skill_level * 0.15f));
				skill.SetRatio((D2INT(player_level / (9 - skill_level)) * 0.01f + (skill_level * 0.07000000000000001f + (skill_t0 * 0.03f + 1.0f))));
				skill.SetPlus((player_def * (skill_t1 * 0.03f) + ((215 * skill_level))));
				player.SetPerform(1);
				*/
			}
		}
		public GSkill4093Stub()
			: base(4093)
		{
			occupation = 130;
			maxlevel = 5;
			maxlearn = 5;
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
			SetAction(0,"鬼道_法宝_万毒噬天");
			SetAction(1,"青云门_法宝_万毒噬天");
			SetAction(2,"鬼王宗_法宝_万毒噬天");
			SetAction(3,"合欢派_法宝_万毒噬天");
			SetAction(4,"天音寺_法宝_万毒噬天");
			SetAction(5,"鬼道_法宝_万毒噬天");
			SetAction(6,"焚香谷_法宝_万毒噬天");
			SetAction(7,"兽神_法宝_万毒噬天");
			SetAction(8,"狐妖_法宝_万毒噬天");
			SetAction(9,"轩辕_法宝_万毒噬天");
			SetAction(10,"怀光_法宝_万毒噬天");
			SetAction(11,"太昊_法宝_万毒噬天");
			SetAction(12,"天华_法宝_万毒噬天");
			SetAction(13,"0");
			SetAction(14,"0");
			SetAction(15,"武器大师_法宝_万毒噬天");
			SetAction(16,"武器大师_法宝_万毒噬天");
			SetAction(17,"天音寺_法宝_万毒噬天");
			SetAction(18,"鬼道_骑乘_法宝_万毒噬天");
			SetAction(19,"青云门_骑乘_法宝_万毒噬天");
			SetAction(20,"鬼王宗_骑乘_法宝_万毒噬天");
			SetAction(21,"合欢派_骑乘_法宝_万毒噬天");
			SetAction(22,"天音寺_骑乘_法宝_万毒噬天");
			SetAction(23,"鬼道_骑乘_法宝_万毒噬天");
			SetAction(24,"焚香谷_骑乘_法宝_万毒噬天");
			SetAction(25,"兽神_骑乘_法宝_万毒噬天");
			SetAction(26,"狐妖_骑乘_法宝_万毒噬天");
			SetAction(27,"轩辕_骑乘_法宝_万毒噬天");
			SetAction(28,"怀光_骑乘_法宝_万毒噬天");
			SetAction(29,"太昊_骑乘_法宝_万毒噬天");
			SetAction(30,"天华_骑乘_法宝_万毒噬天");
			name = "真·万毒噬天";
			nativename = "真·万毒噬天";
			icon = "飞升万毒噬天.dds";
			SetTalent(0,687);
			SetTalent(1,1582);
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
			return 2000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return 6300 - 300 * skill_level;
		}
		public override int GetEnmity(GSkill skill)
		{
			return 1;
		}
		public override float GetPraydistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return (D2INT((player_range / 13.0f)) * 2.8f + (D2INT(player_range / 8.9f) * 1.8f + ((player_range * 0.5f) - D2INT(player_range / 3.9f) * 0.3f)) + 0.05f + 5.0f);
		}
		public override float GetCastdistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return (D2INT((player_range / 13.0f)) * 2.8f + (D2INT(player_range / 8.9f) * 1.8f + ((player_range * 0.5f) - D2INT(player_range / 3.9f) * 0.3f)) + 0.05f);
		}
		public override float GetEffectdistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return (D2INT((player_range / 13.0f)) * 2.8f + (D2INT(player_range / 8.9f) * 1.8f + ((player_range * 0.5f) - D2INT(player_range / 3.9f) * 0.3f)) + 0.05f + 10.0f);
		}
		public override float GetMpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return ((-35 * skill_level) - skill_level * skill_level + 445);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetTalismaneffects(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetTalismaneffectsbless(true);
			return true;
		}
	}
	public class GSkill4093 : GSkill
	{
		public GSkill4093()
			: base(4093)
		{
			
		}
	}
	public class GSkill4094Stub : GSkillStub
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
				int				player_level = player.GetLevel();
				int				player_hp = player.GetHp();
				int				player_maxhp = player.GetMaxhp();
				int				player_mp = player.GetMp();
				int				player_maxmp = player.GetMaxmp();
				int				player_maxatk = player.GetMaxatk();
				int				player_def = player.GetDef();
				int				player_res1 = player.GetRes1();
				int				player_res2 = player.GetRes2();
				int				player_res3 = player.GetRes3();
				int				player_res4 = player.GetRes4();
				int				player_res5 = player.GetRes5();
				int				player_occupation = player.GetOccupation();
				int				skill_level = skill.GetLevel();
				int				skill_t0 = skill.GetT0();
				int				skill_t1 = skill.GetT1();

				/*
				player.SetVar11(player_occupation);
				player.SetVar1(player_maxatk);
				player.SetVar2(player_maxhp);
				player.SetVar3(player_maxmp);
				player.SetVar4(player_hp);
				player.SetVar5(player_mp);
				player.SetVar6(player_res1);
				player.SetVar7(player_res2);
				player.SetVar8(player_res3);
				player.SetVar9(player_res4);
				player.SetVar10(player_res5);
				if ( zrand(100) >= (skill_level + 1) * (skill_level + 1) )
				    v = 2;
				  else
				    v = 1;
				player.SetVar16(v);
				skill.SetRatio((D2INT((player_hp / 0.75f) / player_maxhp) * (skill_level * 0.05f) + (D2INT(player_level / (9 - skill_level)) * 0.01f + (skill_t0 * 0.03f + (skill_level * 0.07000000000000001f + 1.0f)))));
				skill.SetPlus((player_def * (skill_t1 * 0.03f) + ((215 * skill_level))));
				player.SetPerform(1);
				*/
			}
		}
		public GSkill4094Stub()
			: base(4094)
		{
			occupation = 130;
			maxlevel = 5;
			maxlearn = 5;
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
			SetAction(0,"鬼道_法宝_醉生梦死");
			SetAction(1,"青云门_法宝_醉生梦死");
			SetAction(2,"鬼王宗_法宝_醉生梦死");
			SetAction(3,"合欢派_法宝_醉生梦死");
			SetAction(4,"天音寺_法宝_醉生梦死");
			SetAction(5,"鬼道_法宝_醉生梦死");
			SetAction(6,"焚香谷_法宝_醉生梦死");
			SetAction(7,"兽神_法宝_醉生梦死");
			SetAction(8,"狐妖_法宝_醉生梦死");
			SetAction(9,"轩辕_法宝_醉生梦死");
			SetAction(10,"怀光_法宝_醉生梦死");
			SetAction(11,"太昊_法宝_醉生梦死");
			SetAction(12,"天华_法宝_醉生梦死");
			SetAction(13,"0");
			SetAction(14,"0");
			SetAction(15,"武器大师_法宝_醉生梦死");
			SetAction(16,"武器大师_法宝_醉生梦死");
			SetAction(17,"天音寺_法宝_醉生梦死");
			SetAction(18,"鬼道_骑乘_法宝_醉生梦死");
			SetAction(19,"青云门_骑乘_法宝_醉生梦死");
			SetAction(20,"鬼王宗_骑乘_法宝_醉生梦死");
			SetAction(21,"合欢派_骑乘_法宝_醉生梦死");
			SetAction(22,"天音寺_骑乘_法宝_醉生梦死");
			SetAction(23,"鬼道_骑乘_法宝_醉生梦死");
			SetAction(24,"焚香谷_法宝_醉生梦死");
			SetAction(25,"兽神_骑乘_法宝_醉生梦死");
			SetAction(26,"狐妖_骑乘_法宝_醉生梦死");
			SetAction(27,"轩辕_骑乘_法宝_醉生梦死");
			SetAction(28,"怀光_骑乘_法宝_醉生梦死");
			SetAction(29,"太昊_骑乘_法宝_醉生梦死");
			SetAction(30,"天华_骑乘_法宝_醉生梦死");
			name = "真·玉净天华";
			nativename = "真·玉净天华";
			icon = "飞升醉生梦死.dds";
			SetTalent(0,687);
			SetTalent(1,1582);
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
			return 2000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return 6300 - 300 * skill_level;
		}
		public override int GetEnmity(GSkill skill)
		{
			return 1;
		}
		public override float GetPraydistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return (D2INT((player_range / 13.0f)) * 2.8f + (D2INT(player_range / 8.9f) * 1.8f + ((player_range * 0.5f) - D2INT(player_range / 3.9f) * 0.3f)) + 0.05f + 5.0f);
		}
		public override float GetCastdistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return (D2INT((player_range / 13.0f)) * 2.8f + (D2INT(player_range / 8.9f) * 1.8f + ((player_range * 0.5f) - D2INT(player_range / 3.9f) * 0.3f)) + 0.05f);
		}
		public override float GetEffectdistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return (D2INT((player_range / 13.0f)) * 2.8f + (D2INT(player_range / 8.9f) * 1.8f + ((player_range * 0.5f) - D2INT(player_range / 3.9f) * 0.3f)) + 0.05f + 10.0f);
		}
		public override float GetMpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return ((-35 * skill_level) - skill_level * skill_level + 445);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetTalismaneffects(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetTalismaneffectsbless(true);
			return true;
		}
	}
	public class GSkill4094 : GSkill
	{
		public GSkill4094()
			: base(4094)
		{
			
		}
	}
	public class GSkill4095Stub : GSkillStub
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
				int				player_level = player.GetLevel();
				int				player_def = player.GetDef();
				int				skill_level = skill.GetLevel();
				int				skill_t0 = skill.GetT0();
				int				skill_t1 = skill.GetT1();

				skill.SetRatio((D2INT(player_level / (11 - skill_level)) * 0.01f + (skill_t0 * 0.03f + (skill_level * 0.04f + 1.0f))));
				skill.SetPlus((player_def * (skill_t1 * 0.03f) + ((75 * skill_level))));
				player.SetPerform(1);
			}
		}
		public GSkill4095Stub()
			: base(4095)
		{
			occupation = 130;
			maxlevel = 5;
			maxlearn = 5;
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
			SetAction(0,"鬼道_法宝_玲珑塔");
			SetAction(1,"青云门_法宝_玲珑塔");
			SetAction(2,"鬼王宗_法宝_玲珑塔");
			SetAction(3,"合欢派_法宝_玲珑塔");
			SetAction(4,"天音寺_法宝_玲珑塔");
			SetAction(5,"鬼道_法宝_玲珑塔");
			SetAction(6,"焚香谷_法宝_玲珑塔");
			SetAction(7,"兽神_法宝_玲珑塔");
			SetAction(8,"狐妖_法宝_玲珑塔");
			SetAction(9,"");
			SetAction(10,"怀光_法宝_玲珑塔");
			SetAction(11,"太昊_法宝_玲珑塔");
			SetAction(12,"天华_法宝_玲珑塔");
			SetAction(13,"0");
			SetAction(14,"0");
			SetAction(15,"元素大师_法宝_玲珑塔");
			SetAction(16,"元素大师_法宝_玲珑塔");
			SetAction(17,"天音寺_法宝_玲珑塔");
			SetAction(18,"鬼道_骑乘_法宝_玲珑塔");
			SetAction(19,"青云门_骑乘_法宝_玲珑塔");
			SetAction(20,"鬼王宗_骑乘_法宝_玲珑塔");
			SetAction(21,"合欢派_骑乘_法宝_玲珑塔");
			SetAction(22,"天音寺_骑乘_法宝_玲珑塔");
			SetAction(23,"鬼道_骑乘_法宝_玲珑塔");
			SetAction(24,"焚香谷_骑乘_法宝_玲珑塔");
			SetAction(25,"兽神_骑乘_法宝_玲珑塔");
			SetAction(26,"狐妖_骑乘_法宝_玲珑塔");
			SetAction(27,"");
			SetAction(28,"怀光_骑乘_法宝_玲珑塔");
			SetAction(29,"太昊_骑乘_法宝_玲珑塔");
			SetAction(30,"天华_骑乘_法宝_玲珑塔");
			name = "宝塔镇河妖";
			nativename = "宝塔镇河妖";
			icon = "宝塔镇河妖.dds";
			SetTalent(0,687);
			SetTalent(1,1582);
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
			return 2000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return 6300 - 300 * skill_level;
		}
		public override int GetEnmity(GSkill skill)
		{
			return 1;
		}
		public override float GetRadius(GSkill skill)
		{
			return 5.000000f;
		}
		public override float GetPraydistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return (D2INT((player_range / 13.0f)) * 2.8f + (D2INT(player_range / 8.9f) * 1.8f + ((player_range * 0.5f) - D2INT(player_range / 3.9f) * 0.3f)) + 0.05f + 5.0f);
		}
		public override float GetCastdistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return (D2INT((player_range / 13.0f)) * 2.8f + (D2INT(player_range / 8.9f) * 1.8f + ((player_range * 0.5f) - D2INT(player_range / 3.9f) * 0.3f)) + 0.05f);
		}
		public override float GetEffectdistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return (D2INT((player_range / 13.0f)) * 2.8f + (D2INT(player_range / 8.9f) * 1.8f + ((player_range * 0.5f) - D2INT(player_range / 3.9f) * 0.3f)) + 0.05f + 10.0f);
		}
		public override float GetMpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (90 - 10 * skill_level);
		}
		public override int GetCoverage(GSkill skill)
		{
			return 2;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_level = player.GetLevel();
			int				skill_level = skill.GetLevel();

			victim.SetProbability(((1.0f - player_level * 0.002f) * ((5 * skill_level + 15))));
			victim.SetTime(30000.0f);
			victim.SetBuffid(1);
			victim.SetAmount(((360 * skill_level + 180)));
			victim.SetValue(((40 * (skill_level * skill_level + skill_level))));
			victim.SetHpleak(true);
			victim.SetProbability(-1.0f);
			victim.SetTime(30000.0f);
			victim.SetBuffid(1);
			victim.SetAmount(((360 * skill_level + 180)));
			victim.SetValue(((40 * (skill_level * skill_level + skill_level))));
			victim.SetMpleak(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_hp = player.GetHp();
			int				player_maxhp = player.GetMaxhp();
			int				skill_level = skill.GetLevel();

			victim.SetProbability(25.0f);
			victim.SetTime(12100.0f);
			victim.SetBuffid(1);
			victim.SetValue((D2INT(((player_hp * (2 * skill_level * skill_level + 8)) / player_maxhp))));
			victim.SetAddattack(true);
			return true;
		}
	}
	public class GSkill4095 : GSkill
	{
		public GSkill4095()
			: base(4095)
		{
			
		}
	}
	public class GSkill4096Stub : GSkillStub
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
				int				player_level = player.GetLevel();
				int				player_hp = player.GetHp();
				int				player_maxhp = player.GetMaxhp();
				int				player_mp = player.GetMp();
				int				player_maxmp = player.GetMaxmp();
				int				player_maxatk = player.GetMaxatk();
				int				player_def = player.GetDef();
				int				player_res1 = player.GetRes1();
				int				player_res2 = player.GetRes2();
				int				player_res3 = player.GetRes3();
				int				player_res4 = player.GetRes4();
				int				player_res5 = player.GetRes5();
				int				player_occupation = player.GetOccupation();
				int				skill_level = skill.GetLevel();
				int				skill_t0 = skill.GetT0();
				int				skill_t1 = skill.GetT1();

				/*
				player.SetVar11(player_occupation);
				player.SetVar1(player_maxatk);
				player.SetVar2(player_maxhp);
				player.SetVar3(player_maxmp);
				player.SetVar4(player_hp);
				player.SetVar5(player_mp);
				player.SetVar6(player_res1);
				player.SetVar7(player_res2);
				player.SetVar8(player_res3);
				player.SetVar9(player_res4);
				player.SetVar10(player_res5);
				if ( zrand(100) >= (skill_level + 1) * (skill_level + 1) )
				    v = 2;
				  else
				    v = 1;
				player.SetVar16(v);
				skill.SetRatio((D2INT(player_level / (9 - skill_level)) * 0.01f + (skill_level * 0.07000000000000001f + (skill_t0 * 0.03f + 1.0f))));
				skill.SetPlus((player_def * (skill_t1 * 0.03f) + ((215 * skill_level))));
				player.SetPerform(1);
				*/
			}
		}
		public GSkill4096Stub()
			: base(4096)
		{
			occupation = 130;
			maxlevel = 5;
			maxlearn = 5;
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
			SetAction(0,"鬼道_法宝_日月宝鉴");
			SetAction(1,"青云门_法宝_日月宝鉴");
			SetAction(2,"鬼王宗_法宝_日月宝鉴");
			SetAction(3,"合欢派_法宝_日月宝鉴");
			SetAction(4,"天音寺_法宝_日月宝鉴");
			SetAction(5,"鬼道_法宝_日月宝鉴");
			SetAction(6,"焚香谷_法宝_日月宝鉴");
			SetAction(7,"兽神_法宝_日月宝鉴");
			SetAction(8,"狐妖_法宝_日月宝鉴");
			SetAction(9,"轩辕_法宝_日月宝鉴");
			SetAction(10,"怀光_法宝_日月宝鉴");
			SetAction(11,"太昊_法宝_日月宝鉴");
			SetAction(12,"天华_法宝_日月宝鉴");
			SetAction(13,"灵夙_法宝_日月宝鉴");
			SetAction(14,"英招_法宝_日月宝鉴");
			SetAction(15,"武器大师_法宝_日月宝鉴");
			SetAction(16,"武器大师_法宝_日月宝鉴");
			SetAction(17,"天音寺_法宝_日月宝鉴");
			SetAction(18,"鬼道_骑乘_法宝_日月宝鉴");
			SetAction(19,"青云门_骑乘_法宝_日月宝鉴");
			SetAction(20,"鬼王宗_骑乘_法宝_日月宝鉴");
			SetAction(21,"合欢派_骑乘_法宝_日月宝鉴");
			SetAction(22,"天音寺_骑乘_法宝_日月宝鉴");
			SetAction(23,"鬼道_骑乘_法宝_日月宝鉴");
			SetAction(24,"焚香谷_骑乘_法宝_日月宝鉴");
			SetAction(25,"兽神_骑乘_法宝_日月宝鉴");
			SetAction(26,"狐妖_骑乘_法宝_日月宝鉴");
			SetAction(27,"轩辕_骑乘_法宝_日月宝鉴");
			SetAction(28,"怀光_骑乘_法宝_日月宝鉴");
			SetAction(29,"太昊_骑乘_法宝_日月宝鉴");
			SetAction(30,"天华_骑乘_法宝_日月宝鉴");
			name = "真·大凡若简";
			nativename = "真·大凡若简";
			icon = "飞升通用04.dds";
			SetTalent(0,687);
			SetTalent(1,1582);
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
			return 2000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return 6300 - 300 * skill_level;
		}
		public override float GetPraydistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return (D2INT((player_range / 13.0f)) * 2.8f + (D2INT(player_range / 8.9f) * 1.8f + ((player_range * 0.5f) - D2INT(player_range / 3.9f) * 0.3f)) + 0.05f + 5.0f);
		}
		public override float GetCastdistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return (D2INT((player_range / 13.0f)) * 2.8f + (D2INT(player_range / 8.9f) * 1.8f + ((player_range * 0.5f) - D2INT(player_range / 3.9f) * 0.3f)) + 0.05f);
		}
		public override float GetEffectdistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return (D2INT((player_range / 13.0f)) * 2.8f + (D2INT(player_range / 8.9f) * 1.8f + ((player_range * 0.5f) - D2INT(player_range / 3.9f) * 0.3f)) + 0.05f + 10.0f);
		}
		public override float GetMpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return ((-35 * skill_level) - skill_level * skill_level + 445);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetTalismaneffects(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetTalismaneffectsbless(true);
			return true;
		}
	}
	public class GSkill4096 : GSkill
	{
		public GSkill4096()
			: base(4096)
		{
			
		}
	}
	public class GSkill4097Stub : GSkillStub
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
				int				player_level = player.GetLevel();
				int				player_hp = player.GetHp();
				int				player_maxhp = player.GetMaxhp();
				int				player_mp = player.GetMp();
				int				player_maxmp = player.GetMaxmp();
				int				player_maxatk = player.GetMaxatk();
				int				player_def = player.GetDef();
				int				player_res1 = player.GetRes1();
				int				player_res2 = player.GetRes2();
				int				player_res3 = player.GetRes3();
				int				player_res4 = player.GetRes4();
				int				player_res5 = player.GetRes5();
				int				player_occupation = player.GetOccupation();
				int				skill_level = skill.GetLevel();
				int				skill_t0 = skill.GetT0();
				int				skill_t1 = skill.GetT1();

				/*
				player.SetVar11(player_occupation);
				player.SetVar1(player_maxatk);
				player.SetVar2(player_maxhp);
				player.SetVar3(player_maxmp);
				player.SetVar4(player_hp);
				player.SetVar5(player_mp);
				player.SetVar6(player_res1);
				player.SetVar7(player_res2);
				player.SetVar8(player_res3);
				player.SetVar9(player_res4);
				player.SetVar10(player_res5);
				if ( zrand(100) >= (skill_level + 1) * (skill_level + 1) )
				    v = 2;
				  else
				    v = 1;
				player.SetVar16(v);
				skill.SetRatio((D2INT(player_level / (9 - skill_level)) * 0.01f + (skill_level * 0.07000000000000001f + (skill_t0 * 0.03f + 1.0f))));
				skill.SetPlus((player_def * (skill_t1 * 0.03f) + ((215 * skill_level))));
				player.SetPerform(1);
				*/
			}
		}
		public GSkill4097Stub()
			: base(4097)
		{
			occupation = 130;
			maxlevel = 5;
			maxlearn = 5;
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
			SetAction(0,"鬼道_法宝_九龙神火罩");
			SetAction(1,"青云门_法宝_九龙神火罩");
			SetAction(2,"鬼王宗_法宝_九龙神火罩");
			SetAction(3,"合欢派_法宝_九龙神火罩");
			SetAction(4,"天音寺_法宝_九龙神火罩");
			SetAction(5,"鬼道_法宝_九龙神火罩");
			SetAction(6,"焚香谷_法宝_九龙神火罩");
			SetAction(7,"兽神_法宝_九龙神火罩");
			SetAction(8,"狐妖_法宝_九龙神火罩");
			SetAction(9,"轩辕_法宝_九龙神火罩");
			SetAction(10,"怀光_法宝_九龙神火罩");
			SetAction(11,"太昊_法宝_九龙神火罩");
			SetAction(12,"天华_法宝_九龙神火罩");
			SetAction(13,"灵夙_法宝_九龙神火罩");
			SetAction(14,"英招_法宝_九龙神火罩");
			SetAction(15,"武器大师_法宝_九龙神火罩");
			SetAction(16,"武器大师_法宝_九龙神火罩");
			SetAction(17,"合欢派_法宝_九龙神火罩");
			SetAction(18,"鬼道_骑乘_法宝_九龙神火罩");
			SetAction(19,"青云门_骑乘_法宝_九龙神火罩");
			SetAction(20,"鬼王宗_骑乘_法宝_九龙神火罩");
			SetAction(21,"合欢派_骑乘_法宝_九龙神火罩");
			SetAction(22,"天音寺_骑乘_法宝_九龙神火罩");
			SetAction(23,"鬼道_骑乘_法宝_九龙神火罩");
			SetAction(24,"焚香谷_骑乘_法宝_九龙神火罩");
			SetAction(25,"兽神_骑乘_法宝_九龙神火罩");
			SetAction(26,"狐妖_骑乘_法宝_九龙神火罩");
			SetAction(27,"轩辕_骑乘_法宝_九龙神火罩");
			SetAction(28,"怀光_骑乘_法宝_九龙神火罩");
			SetAction(29,"太昊_骑乘_法宝_九龙神火罩");
			SetAction(30,"天华_骑乘_法宝_九龙神火罩");
			name = "真·炼狱神火";
			nativename = "真·炼狱神火";
			icon = "飞升炼狱神火.dds";
			SetTalent(0,687);
			SetTalent(1,1582);
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
			return 2000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return 6300 - 300 * skill_level;
		}
		public override float GetPraydistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return (D2INT((player_range / 13.0f)) * 2.8f + (D2INT(player_range / 8.9f) * 1.8f + ((player_range * 0.5f) - D2INT(player_range / 3.9f) * 0.3f)) + 0.05f + 5.0f);
		}
		public override float GetCastdistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return (D2INT((player_range / 13.0f)) * 2.8f + (D2INT(player_range / 8.9f) * 1.8f + ((player_range * 0.5f) - D2INT(player_range / 3.9f) * 0.3f)) + 0.05f);
		}
		public override float GetEffectdistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return (D2INT((player_range / 13.0f)) * 2.8f + (D2INT(player_range / 8.9f) * 1.8f + ((player_range * 0.5f) - D2INT(player_range / 3.9f) * 0.3f)) + 0.05f + 10.0f);
		}
		public override float GetMpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return ((-35 * skill_level) - skill_level * skill_level + 445);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetTalismaneffects(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetTalismaneffectsbless(true);
			return true;
		}
	}
	public class GSkill4097 : GSkill
	{
		public GSkill4097()
			: base(4097)
		{
			
		}
	}
	public class GSkill4098Stub : GSkillStub
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
				int				player_level = player.GetLevel();
				int				player_hp = player.GetHp();
				int				player_maxhp = player.GetMaxhp();
				int				player_mp = player.GetMp();
				int				player_maxmp = player.GetMaxmp();
				int				player_maxatk = player.GetMaxatk();
				int				player_def = player.GetDef();
				int				player_res1 = player.GetRes1();
				int				player_res2 = player.GetRes2();
				int				player_res3 = player.GetRes3();
				int				player_res4 = player.GetRes4();
				int				player_res5 = player.GetRes5();
				int				player_occupation = player.GetOccupation();
				int				skill_level = skill.GetLevel();
				int				skill_t0 = skill.GetT0();
				int				skill_t1 = skill.GetT1();

				/*
				player.SetVar11(player_occupation);
				player.SetVar1(player_maxatk);
				player.SetVar2(player_maxhp);
				player.SetVar3(player_maxmp);
				player.SetVar4(player_hp);
				player.SetVar5(player_mp);
				player.SetVar6(player_res1);
				player.SetVar7(player_res2);
				player.SetVar8(player_res3);
				player.SetVar9(player_res4);
				player.SetVar10(player_res5);
				if ( zrand(100) >= (skill_level + 1) * (skill_level + 1) )
				    v = 2;
				  else
				    v = 1;
				player.SetVar16(v);
				skill.SetCrit((skill_level * 0.02f + 0.01f));
				skill.SetRatio((D2INT(player_level / (9 - skill_level)) * 0.01f + (skill_level * 0.07000000000000001f + (skill_t0 * 0.03f + 1.0f))));
				skill.SetPlus((player_def * (skill_t1 * 0.03f) + ((215 * skill_level))));
				player.SetPerform(1);
				*/
			}
		}
		public GSkill4098Stub()
			: base(4098)
		{
			occupation = 130;
			maxlevel = 5;
			maxlearn = 5;
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
			SetAction(0,"鬼道_法宝_金葫芦");
			SetAction(1,"青云门_法宝_金葫芦");
			SetAction(2,"鬼王宗_法宝_金葫芦");
			SetAction(3,"合欢派_法宝_金葫芦");
			SetAction(4,"天音寺_法宝_金葫芦");
			SetAction(5,"鬼道_法宝_金葫芦");
			SetAction(6,"焚香谷_法宝_金葫芦");
			SetAction(7,"兽神_法宝_金葫芦");
			SetAction(8,"狐妖_法宝_金葫芦");
			SetAction(9,"轩辕_法宝_金葫芦");
			SetAction(10,"怀光_法宝_金葫芦");
			SetAction(11,"太昊_法宝_金葫芦");
			SetAction(12,"天华_法宝_金葫芦");
			SetAction(13,"灵夙_法宝_金葫芦");
			SetAction(14,"英招_法宝_金葫芦");
			SetAction(15,"武器大师_法宝_金葫芦");
			SetAction(16,"武器大师_法宝_金葫芦");
			SetAction(17,"天音寺_法宝_金葫芦");
			SetAction(18,"鬼道_骑乘_法宝_金葫芦");
			SetAction(19,"青云门_骑乘_法宝_金葫芦");
			SetAction(20,"鬼王宗_骑乘_法宝_金葫芦");
			SetAction(21,"合欢派_骑乘_法宝_金葫芦");
			SetAction(22,"天音寺_骑乘_法宝_金葫芦");
			SetAction(23,"鬼道_骑乘_法宝_金葫芦");
			SetAction(24,"焚香谷_骑乘_法宝_金葫芦");
			SetAction(25,"兽神_骑乘_法宝_金葫芦");
			SetAction(26,"狐妖_骑乘_法宝_金葫芦");
			SetAction(27,"轩辕_骑乘_法宝_金葫芦");
			SetAction(28,"怀光_骑乘_法宝_金葫芦");
			SetAction(29,"太昊_骑乘_法宝_金葫芦");
			SetAction(30,"天华_骑乘_法宝_金葫芦");
			name = "真·方寸乾坤";
			nativename = "真·方寸乾坤";
			icon = "飞升方寸乾坤.dds";
			SetTalent(0,687);
			SetTalent(1,1582);
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
			return 2000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return 6300 - 300 * skill_level;
		}
		public override int GetEnmity(GSkill skill)
		{
			return 1;
		}
		public override float GetPraydistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return (D2INT((player_range / 13.0f)) * 2.8f + (D2INT(player_range / 8.9f) * 1.8f + ((player_range * 0.5f) - D2INT(player_range / 3.9f) * 0.3f)) + 0.05f + 5.0f);
		}
		public override float GetCastdistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return (D2INT((player_range / 13.0f)) * 2.8f + (D2INT(player_range / 8.9f) * 1.8f + ((player_range * 0.5f) - D2INT(player_range / 3.9f) * 0.3f)) + 0.05f);
		}
		public override float GetEffectdistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return (D2INT((player_range / 13.0f)) * 2.8f + (D2INT(player_range / 8.9f) * 1.8f + ((player_range * 0.5f) - D2INT(player_range / 3.9f) * 0.3f)) + 0.05f + 10.0f);
		}
		public override float GetMpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return ((-35 * skill_level) - skill_level * skill_level + 445);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetTalismaneffects(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetTalismaneffectsbless(true);
			return true;
		}
	}
	public class GSkill4098 : GSkill
	{
		public GSkill4098()
			: base(4098)
		{
			
		}
	}
	public class GSkill4099Stub : GSkillStub
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
				int				player_level = player.GetLevel();
				int				player_hp = player.GetHp();
				int				player_maxhp = player.GetMaxhp();
				int				player_mp = player.GetMp();
				int				player_maxmp = player.GetMaxmp();
				int				player_maxatk = player.GetMaxatk();
				int				player_def = player.GetDef();
				int				player_res1 = player.GetRes1();
				int				player_res2 = player.GetRes2();
				int				player_res3 = player.GetRes3();
				int				player_res4 = player.GetRes4();
				int				player_res5 = player.GetRes5();
				int				player_occupation = player.GetOccupation();
				int				skill_level = skill.GetLevel();
				int				skill_t0 = skill.GetT0();
				int				skill_t1 = skill.GetT1();

				/*
				player.SetVar11(player_occupation);
				player.SetVar1(player_maxatk);
				player.SetVar2(player_maxhp);
				player.SetVar3(player_maxmp);
				player.SetVar4(player_hp);
				player.SetVar5(player_mp);
				player.SetVar6(player_res1);
				player.SetVar7(player_res2);
				player.SetVar8(player_res3);
				player.SetVar9(player_res4);
				player.SetVar10(player_res5);
				if ( zrand(100) >= (skill_level + 1) * (skill_level + 1) )
				    v = 2;
				  else
				    v = 1;
				player.SetVar16(v);
				skill.SetRatio((D2INT(player_level / (9 - skill_level)) * 0.01f + (skill_level * 0.07000000000000001f + (D2INT((zrand(skill_level + 101)) / 100.0f) * (skill_level * 0.6f) + (skill_t0 * 0.03f) + 1.0f))));
				skill.SetPlus((player_def * (skill_t1 * 0.03f) + ((215 * skill_level))));
				player.SetPerform(1);
				*/
			}
		}
		public GSkill4099Stub()
			: base(4099)
		{
			occupation = 130;
			maxlevel = 5;
			maxlearn = 5;
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
			SetAction(0,"鬼道_法宝_阴阳镜");
			SetAction(1,"青云门_法宝_阴阳镜");
			SetAction(2,"鬼王宗_法宝_阴阳镜");
			SetAction(3,"合欢派_法宝_阴阳镜");
			SetAction(4,"天音寺_法宝_阴阳镜");
			SetAction(5,"鬼道_法宝_阴阳镜");
			SetAction(6,"焚香谷_法宝_阴阳镜");
			SetAction(7,"兽神_法宝_阴阳镜");
			SetAction(8,"狐妖_法宝_阴阳镜");
			SetAction(9,"轩辕_法宝_阴阳镜");
			SetAction(10,"怀光_法宝_阴阳镜");
			SetAction(11,"太昊_法宝_阴阳镜");
			SetAction(12,"天华_法宝_阴阳镜");
			SetAction(13,"灵夙_法宝_阴阳镜");
			SetAction(14,"英招_法宝_阴阳镜");
			SetAction(15,"武器大师_法宝_阴阳镜");
			SetAction(16,"武器大师_法宝_阴阳镜");
			SetAction(17,"天音寺_法宝_阴阳镜");
			SetAction(18,"鬼道_骑乘_法宝_阴阳镜");
			SetAction(19,"青云门_骑乘_法宝_阴阳镜");
			SetAction(20,"鬼王宗_骑乘_法宝_阴阳镜");
			SetAction(21,"合欢派_骑乘_法宝_阴阳镜");
			SetAction(22,"天音寺_骑乘_法宝_阴阳镜");
			SetAction(23,"鬼道_骑乘_法宝_阴阳镜");
			SetAction(24,"焚香谷_骑乘_法宝_阴阳镜");
			SetAction(25,"兽神_骑乘_法宝_阴阳镜");
			SetAction(26,"狐妖_骑乘_法宝_阴阳镜");
			SetAction(27,"轩辕_骑乘_法宝_阴阳镜");
			SetAction(28,"怀光_骑乘_法宝_阴阳镜");
			SetAction(29,"太昊_骑乘_法宝_阴阳镜");
			SetAction(30,"天华_骑乘_法宝_阴阳镜");
			name = "真·阴阳相生";
			nativename = "真·阴阳相生";
			icon = "飞升阴阳相生.dds";
			SetTalent(0,687);
			SetTalent(1,1582);
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
			return 2000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return 6300 - 300 * skill_level;
		}
		public override int GetEnmity(GSkill skill)
		{
			return 1;
		}
		public override float GetPraydistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return (D2INT((player_range / 13.0f)) * 2.8f + (D2INT(player_range / 8.9f) * 1.8f + ((player_range * 0.5f) - D2INT(player_range / 3.9f) * 0.3f)) + 0.05f + 5.0f);
		}
		public override float GetCastdistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return (D2INT((player_range / 13.0f)) * 2.8f + (D2INT(player_range / 8.9f) * 1.8f + ((player_range * 0.5f) - D2INT(player_range / 3.9f) * 0.3f)) + 0.05f);
		}
		public override float GetEffectdistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return (D2INT((player_range / 13.0f)) * 2.8f + (D2INT(player_range / 8.9f) * 1.8f + ((player_range * 0.5f) - D2INT(player_range / 3.9f) * 0.3f)) + 0.05f + 10.0f);
		}
		public override float GetMpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return ((-35 * skill_level) - skill_level * skill_level + 445);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetTalismaneffects(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetTalismaneffectsbless(true);
			return true;
		}
	}
	public class GSkill4099 : GSkill
	{
		public GSkill4099()
			: base(4099)
		{
			
		}
	}
}
