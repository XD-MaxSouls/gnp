using System;
using System.Text;

namespace SKILL
{
	public class GSkill5070Stub : GSkillStub
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

				skill.SetRatio(0.60000002f);
				player.SetPerform(1);
			}
		}
		public GSkill5070Stub()
			: base(5070)
		{
			occupation = 128;
			maxlevel = 1;
			maxlearn = 1;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 1;
			timetype = 0;
			targettype = 0;
			rangetype = 3;
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
			SetAction(0,"��ѡ��Թ");
			SetAction(1,"��ѡ��Թ");
			SetAction(2,"��ѡ��Թ");
			SetAction(3,"��ѡ��Թ");
			SetAction(4,"��ѡ��Թ");
			SetAction(5,"��ѡ��Թ");
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
			SetAction(18,"��ѡ��Թ");
			SetAction(19,"��ѡ��Թ");
			SetAction(20,"��ѡ��Թ");
			SetAction(21,"��ѡ��Թ");
			SetAction(22,"��ѡ��Թ");
			SetAction(23,"��ѡ��Թ");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "��ѡ��Թ";
			nativename = "��ѡ��Թ";
			icon = "��ѡ��Թ.dds";
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
		public override int GetCooldowntime(GSkill skill)
		{
			return 12000;
		}
		public override float GetRadius(GSkill skill)
		{
			return 20.000000f;
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
			return 1000.000000f;
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
			int				player_hp = player.GetHp();
			int				player_maxhp = player.GetMaxhp();

			/*
			if ( ((1.0f - player_level * 0.002f + 0.09f) * 100.0f * 1.3f) - player.GetSaint() <= 15.0f )
			{
			d = 15.0f;
			}
			else
			{
			d = ((1.0f - player_level * 0.002f + 0.09f) * 100.0f * 1.3f) - player.GetSaint();
			}
			victim.SetProbability(d);
			victim.SetTime(54000.0f);
			victim.SetBuffid(1);
			victim.SetAmount((player_hp * 0.045f + ((6 * player_maxhp) * 1.3f)));
			victim.SetValue(6000.0f);
			victim.SetHpleak3(true);
			victim.SetProbability(((1.0f - player_level * 0.002f) * 15.0f));
			victim.SetRatio(1.0f);
			victim.SetDrainmagic(true);
			victim.SetProbability(50.0f);
			victim.SetTime(15100.0f);
			victim.SetBuffid(1);
			victim.SetValue(10000.0f);
			victim.SetSubdefence(true);
			victim.SetProbability(21.0f);
			victim.SetTime(12100.0f);
			victim.SetRatio(0.2f);
			victim.SetValue(0.2f);
			victim.SetRandcurse(true);
			*/
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
			victim.SetValue((player_mp * 0.004f + 1.0f));
			victim.SetAdddefence(true);
			return true;
		}
		public override float GetDropRate(GSkill skill)
		{
			return 0.500000f;
		}
	}
	public class GSkill5070 : GSkill
	{
		public GSkill5070()
			: base(5070)
		{
			
		}
	}
	public class GSkill5071Stub : GSkillStub
	{
		public class GState1 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 1000;
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
				return 1000;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_maxatk = player.GetMaxatk();

				player.SetVar1(player_maxatk);
				skill.SetRatio(1.39f);
				skill.SetPlus(522.0f);
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
				return 1000;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_maxatk = player.GetMaxatk();

				player.SetVar1(player_maxatk);
				skill.SetRatio(1.39f);
				skill.SetPlus(522.0f);
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
				int				player_maxatk = player.GetMaxatk();

				player.SetVar1(player_maxatk);
				skill.SetRatio(1.39f);
				skill.SetPlus(522.0f);
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
				return 500;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_maxatk = player.GetMaxatk();

				player.SetVar1(player_maxatk);
				skill.SetRatio(1.39f);
				skill.SetPlus(522.0f);
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
				return 200;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_maxatk = player.GetMaxatk();

				player.SetVar1(player_maxatk);
				skill.SetRatio(1.39f);
				skill.SetPlus(522.0f);
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
				return 200;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_maxatk = player.GetMaxatk();

				player.SetVar1(player_maxatk);
				skill.SetRatio(1.39f);
				skill.SetPlus(522.0f);
				player.SetPerform(0);
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
				return 100;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_maxatk = player.GetMaxatk();

				player.SetVar1(player_maxatk);
				skill.SetRatio(1.39f);
				skill.SetPlus(522.0f);
				player.SetPerform(0);
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
				return 100;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_maxatk = player.GetMaxatk();

				player.SetVar1(player_maxatk);
				skill.SetRatio(1.39f);
				skill.SetPlus(522.0f);
				player.SetPerform(0);
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
				return 100;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_maxatk = player.GetMaxatk();

				player.SetVar1(player_maxatk);
				skill.SetRatio(1.39f);
				skill.SetPlus(522.0f);
				player.SetPerform(0);
			}
		}
		public GSkill5071Stub()
			: base(5071)
		{
			occupation = 128;
			maxlevel = 1;
			maxlearn = 1;
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
			SetAction(0,"�����_�ٻ���ʯ");
			SetAction(1,"�����_�ٻ���ʯ");
			SetAction(2,"�����_�ٻ���ʯ");
			SetAction(3,"�����_�ٻ���ʯ");
			SetAction(4,"�����_�ٻ���ʯ");
			SetAction(5,"�����_�ٻ���ʯ");
			SetAction(6,"�����_�ٻ���ʯ");
			SetAction(7,"�����_�ٻ���ʯ");
			SetAction(8,"�����_�ٻ���ʯ");
			SetAction(9,"�����_�ٻ���ʯ");
			SetAction(10,"�����_�ٻ���ʯ");
			SetAction(11,"�����_�ٻ���ʯ");
			SetAction(12,"�����_�ٻ���ʯ");
			SetAction(13,"0");
			SetAction(14,"0");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"�����_���_�ٻ���ʯ");
			SetAction(19,"�����_���_�ٻ���ʯ");
			SetAction(20,"�����_���_�ٻ���ʯ");
			SetAction(21,"�����_���_�ٻ���ʯ");
			SetAction(22,"�����_���_�ٻ���ʯ");
			SetAction(23,"�����_���_�ٻ���ʯ");
			SetAction(24,"�����_���_�ٻ���ʯ");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "�������";
			nativename = "�������";
			icon = "�������.dds";
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
			return 5000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			return 7000;
		}
		public override float GetRadius(GSkill skill)
		{
			return 27.000000f;
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
			return 1000.000000f;
		}
		public override int GetCoverage(GSkill skill)
		{
			return 16;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_def = player.GetDef();
			int				player_var1 = player.GetVar1();

			victim.SetProbability(100.0f);
			victim.SetValue(((player_var1 - player_def)));
			victim.SetDirecthurt(true);
			victim.SetProbability(14.0f);
			victim.SetTime(14100.0f);
			victim.SetRatio(8.0f);
			victim.SetBuffid((zrand(4) + 1));
			victim.SetAmount(9.0f);
			victim.SetValue((player_var1 * 0.21f));
			victim.SetFiring(true);
			return true;
		}
	}
	public class GSkill5071 : GSkill
	{
		public GSkill5071()
			: base(5071)
		{
			
		}
	}
	public class GSkill5072Stub : GSkillStub
	{
		public class GState1 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 3000;
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
				return 5000;
			}
			public override void Calculate(GSkill skill)
			{
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
				return 2000;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();

				player.SetPerform(1);
			}
		}
		public GSkill5072Stub()
			: base(5072)
		{
			occupation = 128;
			maxlevel = 1;
			maxlearn = 1;
			eventflag = 0;
			spcost = 0;
			reborncount = 0;
			type = 2;
			timetype = 3;
			targettype = 0;
			rangetype = 2;
			doenchant = true;
			dobless = true;
			autoattack = false;
			allowform = 0;
			credittype = 0;
			clearmask = 1;
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
			SetAction(0,"�����_�󷨾��С����ס�");
			SetAction(1,"�����_�󷨾��С����ס�");
			SetAction(2,"�����_�󷨾��С����ס�");
			SetAction(3,"�����_�󷨾��С����ס�");
			SetAction(4,"�����_�󷨾��С����ס�");
			SetAction(5,"�����_�󷨾��С����ס�");
			SetAction(6,"�����_�󷨾��С����ס�");
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
			SetAction(18,"�����_���_�󷨾��С����ס�");
			SetAction(19,"�����_���_�󷨾��С����ס�");
			SetAction(20,"�����_���_�󷨾��С����ס�");
			SetAction(21,"�����_���_�󷨾��С����ס�");
			SetAction(22,"�����_���_�󷨾��С����ס�");
			SetAction(23,"�����_���_�󷨾��С����ס�");
			SetAction(24,"�����_���_�󷨾��С����ס�");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "��������";
			nativename = "��������";
			icon = "�ɡ���������.dds";
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
			cycle = true;
			cyclemode = 1;
			cyclegfx = "�������";
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
			AddState(new GState3());
		}
		public override int GetExecutetime(GSkill skill)
		{
			return 10000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			return 142800;
		}
		public override float GetRadius(GSkill skill)
		{
			return 28.000000f;
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
			return 7500.000000f;
		}
		public override int GetCoverage(GSkill skill)
		{
			return 40;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetProbability(40.0f);
			victim.SetBreakcasting(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();
			int				skill_t0 = skill.GetT0();
			int				skill_charging = skill.GetCharging();

			/*
			victim.SetProbability(120.0f);
			victim.SetTime(0.0f);
			victim.SetRatio(1.0f);
			victim.SetBuffid(0);
			victim.SetAmount(3373.0f);
			victim.SetValue(2.0f);
			victim.SetCycle(true);
			if ( zrand(100) >= 2 * player.GetSkilllevel(3759) )
			d = 218.0f;
			else
			victim.SetRatio(3449.0f);
			victim.SetAmount(218.0f);
			victim.SetValue(218.0f);
			victim.SetClearcooldown(true);
			victim.SetProbability(120.0f);
			victim.SetTime(50.0f);
			v38 = skill_charging > 0x1194;
			v36 = skill_charging > 0x9C4;
			if ( player.GetCyclemembercnt() > 3 )
			v37 = 100 * v36;
			else
			v37 = 0;
			skill_charging;
			if ( player.GetCyclemembercnt() > 0 )
			v35 = 100;
			else
			v35 = 0;
			v34 = skill_level;
			v33 = skill_t0 * player.GetCyclemembercnt();
			if ( player.GetCyclemembercnt() == 6 )
			v39 = v33 + v34 + v35 + 100 * v38 + v37 + 10;
			else
			v39 = v33 + v34 + v35 + v37 + 10;
			if ( skill_charging <= 0x12C0 )
			v32 = v39;
			else
			victim.SetRatio(((v39 + 10)));
			victim.SetBuffid(1);
			victim.SetValue(3860.0f);
			victim.SetDelaycast(true);
			victim.SetTime(500.0f);
			victim.SetRatio(0.0f);
			victim.SetAmount(0.0f);
			victim.SetValue(0.0f);
			victim.SetEvilaura(true);
			*/
			return true;
		}
	}
	public class GSkill5072 : GSkill
	{
		public GSkill5072()
			: base(5072)
		{
			
		}
	}
	public class GSkill5073Stub : GSkillStub
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
				return 1600;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();

				player.SetMp(0.0f);
				player.SetPerform(1);
			}
		}
		public GSkill5073Stub()
			: base(5073)
		{
			occupation = 128;
			maxlevel = 1;
			maxlearn = 1;
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
			SetAction(0,"�����_���̻���");
			SetAction(1,"�����_���̻���");
			SetAction(2,"�����_���̻���");
			SetAction(3,"�����_���̻���");
			SetAction(4,"�����_���̻���");
			SetAction(5,"�����_���̻���");
			SetAction(6,"�����_���̻���");
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
			SetAction(18,"�����_���_���̻���");
			SetAction(19,"�����_���_���̻���");
			SetAction(20,"�����_���_���̻���");
			SetAction(21,"�����_���_���̻���");
			SetAction(22,"�����_���_���̻���");
			SetAction(23,"�����_���_���̻���");
			SetAction(24,"�����_���_���̻���");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "��������";
			nativename = "��������";
			icon = "��������.dds";
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
			return 2000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			return 60000;
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
			GPlayerWrapper	player = skill.GetPlayer();
			int				player_level = player.GetLevel();

			return (10 * player_level);
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetProbability(120.0f);
			victim.SetAmount(12.0f);
			victim.SetCleardebuff(true);
			victim.SetProbability(100.0f);
			victim.SetTime(12000.0f);
			victim.SetRatio(0.2f);
			victim.SetBuffid(1);
			victim.SetIncattack(true);
			victim.SetTime(12000.0f);
			victim.SetValue(30.0f);
			victim.SetBlessed(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_maxhp = player.GetMaxhp();

			victim.SetProbability(120.0f);
			victim.SetTime(6000.0f);
			victim.SetRatio(0.0f);
			victim.SetBuffid(1);
			victim.SetAmount(0.0f);
			victim.SetValue(player_maxhp);
			victim.SetHpgen(true);
			return true;
		}
	}
	public class GSkill5073 : GSkill
	{
		public GSkill5073()
			: base(5073)
		{
			
		}
	}
	public class GSkill5074Stub : GSkillStub
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
				return 400;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();

				player.SetPerform(1);
			}
		}
		public GSkill5074Stub()
			: base(5074)
		{
			occupation = 128;
			maxlevel = 1;
			maxlearn = 1;
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
			SetAction(0,"�����_��������");
			SetAction(1,"�����_��������");
			SetAction(2,"�����_��������");
			SetAction(3,"�����_��������");
			SetAction(4,"�����_��������");
			SetAction(5,"�����_��������");
			SetAction(6,"�����_��������");
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
			SetAction(18,"�����_���_��������");
			SetAction(19,"�����_���_��������");
			SetAction(20,"�����_���_��������");
			SetAction(21,"�����_���_��������");
			SetAction(22,"�����_���_��������");
			SetAction(23,"�����_���_��������");
			SetAction(24,"�����_���_��������");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "������Թ";
			nativename = "������Թ";
			icon = "������Թ.dds";
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
		public override int GetCooldowntime(GSkill skill)
		{
			return 59200;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 18.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 16.000000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 20.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			return 720.000000f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();

			/*
			if ( player.GetHasbuff(4197) == 1 )
			d = 120.0f;
			else
			victim.SetProbability(0.0f);
			victim.SetRatio(4197.0f);
			victim.SetAmount(4197.0f);
			victim.SetValue(4197.0f);
			victim.SetDispel(true);
			victim.SetProbability(300.0f);
			victim.SetTime(26000.0f);
			victim.SetRatio(0.30000001f);
			victim.SetBuffid(1);
			victim.SetSlow(true);
			*/
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetProbability(120.0f);
			victim.SetTime(26000.0f);
			victim.SetRatio(0.0f);
			victim.SetBuffid(2);
			victim.SetAmount(44678.0f);
			victim.SetValue(0.0f);
			victim.SetCreateobject(true);
			victim.SetProbability(100.0f);
			victim.SetTime(59200.0f);
			victim.SetRatio(3749.0f);
			victim.SetAmount(3749.0f);
			victim.SetValue(3749.0f);
			victim.SetSetcooldown(true);
			return true;
		}
	}
	public class GSkill5074 : GSkill
	{
		public GSkill5074()
			: base(5074)
		{
			
		}
	}
	public class GSkill5075Stub : GSkillStub
	{
		public class GState1 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 350;
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

				player.SetVar1(1);
				player.SetVar2(player_level);
				skill.SetRatio(2.21f);
				skill.SetPlus(163.0f);
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
				return 225;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_level = player.GetLevel();

				player.SetVar1(2);
				player.SetVar2(player_level);
				skill.SetRatio(2.21f);
				skill.SetPlus(387.0f);
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
				return 500;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_level = player.GetLevel();

				player.SetVar1(3);
				player.SetVar2(player_level);
				skill.SetRatio(2.21f);
				skill.SetPlus(1142.0f);
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
				return 525;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_level = player.GetLevel();

				player.SetVar1(4);
				player.SetVar2(player_level);
				skill.SetRatio(2.21f);
				skill.SetPlus(1639.0f);
				player.SetPerform(0);
			}
		}
		public GSkill5075Stub()
			: base(5075)
		{
			occupation = 128;
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
			SetAction(0,"����_����");
			SetAction(1,"0");
			SetAction(2,"0");
			SetAction(3,"0");
			SetAction(4,"0");
			SetAction(5,"0");
			SetAction(6,"0");
			SetAction(7,"����_����");
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
			SetAction(18,"����_���_����");
			SetAction(19,"0");
			SetAction(20,"0");
			SetAction(21,"0");
			SetAction(22,"0");
			SetAction(23,"0");
			SetAction(24,"0");
			SetAction(25,"����_���_����");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "����";
			nativename = "����";
			icon = "����.dds";
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
			AddState(new GState3());
			AddState(new GState4());
			AddState(new GState5());
		}
		public override int GetExecutetime(GSkill skill)
		{
			return 1000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			return 5000;
		}
		public override int GetEnmity(GSkill skill)
		{
			return 1;
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
			return 12.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			return 500.000000f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_var1 = player.GetVar1();
			int				player_var2 = player.GetVar2();

			/*
			if ( player_var1 == 1 )
			d = 600.0f;
			else
			victim.SetProbability(0.0f);
			victim.SetTime(4000.0f);
			victim.SetRatio(0.30000001f);
			victim.SetBuffid(1);
			victim.SetSlow(true);
			if ( player_var1 == 2 )
			{
			v34 = (player_var2 / 3 + player_var2);
			}
			else
			{
			v34 = 0.0f;
			}
			victim.SetProbability(v34);
			victim.SetTime(4000.0f);
			victim.SetRatio(0.2f);
			victim.SetBuffid(1);
			victim.SetWeak(true);
			if ( player_var1 == 3 )
			{
			v33 = (player_var2 / 3 + player_var2);
			}
			else
			{
			v33 = 0.0f;
			}
			victim.SetProbability(v33);
			victim.SetTime(4000.0f);
			victim.SetWrap(true);
			if ( player_var1 == 4 )
			{
			v32 = (player_var2 / 3 + player_var2);
			}
			else
			{
			v32 = 0.0f;
			}
			victim.SetProbability(v32);
			victim.SetTime(4000.0f);
			victim.SetDizzy(true);
			*/
			return true;
		}
	}
	public class GSkill5075 : GSkill
	{
		public GSkill5075()
			: base(5075)
		{
			
		}
	}
	public class GSkill5076Stub : GSkillStub
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
		public GSkill5076Stub()
			: base(5076)
		{
			occupation = 128;
			maxlevel = 1;
			maxlearn = 1;
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
			SetAction(0,"����_��");
			SetAction(1,"0");
			SetAction(2,"0");
			SetAction(3,"0");
			SetAction(4,"0");
			SetAction(5,"0");
			SetAction(6,"0");
			SetAction(7,"����_��");
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
			SetAction(18,"����_���_��");
			SetAction(19,"0");
			SetAction(20,"0");
			SetAction(21,"0");
			SetAction(22,"0");
			SetAction(23,"0");
			SetAction(24,"0");
			SetAction(25,"����_���_��");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "��";
			nativename = "��";
			icon = "��.dds";
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
		public override int GetCooldowntime(GSkill skill)
		{
			return 120000;
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
			return 900.000000f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetProbability(120.0f);
			victim.SetTime(48000.0f);
			victim.SetBuffid(1);
			victim.SetAmount(0.20999999f);
			victim.SetValue(0.20999999f);
			victim.SetChihun(true);
			return true;
		}
	}
	public class GSkill5076 : GSkill
	{
		public GSkill5076()
			: base(5076)
		{
			
		}
	}
	public class GSkill5077Stub : GSkillStub
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
		public GSkill5077Stub()
			: base(5077)
		{
			occupation = 128;
			maxlevel = 1;
			maxlearn = 1;
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
			SetAction(0,"����_����");
			SetAction(1,"0");
			SetAction(2,"0");
			SetAction(3,"0");
			SetAction(4,"0");
			SetAction(5,"0");
			SetAction(6,"0");
			SetAction(7,"����_����");
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
			SetAction(18,"����_���_����");
			SetAction(19,"0");
			SetAction(20,"0");
			SetAction(21,"0");
			SetAction(22,"0");
			SetAction(23,"0");
			SetAction(24,"0");
			SetAction(25,"����_���_����");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "����";
			nativename = "����";
			icon = "����.dds";
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
		public override int GetCooldowntime(GSkill skill)
		{
			return 6000;
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

			victim.SetProbability(120.0f);
			victim.SetAmount(0.039999999f);
			victim.SetValue(0.02f);
			victim.SetLongxiang(true);
			return true;
		}
	}
	public class GSkill5077 : GSkill
	{
		public GSkill5077()
			: base(5077)
		{
			
		}
	}
	public class GSkill5078Stub : GSkillStub
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
		public GSkill5078Stub()
			: base(5078)
		{
			occupation = 128;
			maxlevel = 1;
			maxlearn = 1;
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
			SetAction(0,"����_����");
			SetAction(1,"0");
			SetAction(2,"0");
			SetAction(3,"0");
			SetAction(4,"0");
			SetAction(5,"0");
			SetAction(6,"0");
			SetAction(7,"����_����");
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
			SetAction(18,"����_���_����");
			SetAction(19,"0");
			SetAction(20,"0");
			SetAction(21,"0");
			SetAction(22,"0");
			SetAction(23,"0");
			SetAction(24,"0");
			SetAction(25,"����_���_����");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "����";
			nativename = "����";
			icon = "����.dds";
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
		public override int GetCooldowntime(GSkill skill)
		{
			return 6000;
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

			victim.SetProbability(120.0f);
			victim.SetAmount(0.039999999f);
			victim.SetValue(0.059999999f);
			victim.SetHuju(true);
			return true;
		}
	}
	public class GSkill5078 : GSkill
	{
		public GSkill5078()
			: base(5078)
		{
			
		}
	}
	public class GSkill5079Stub : GSkillStub
	{
		public class GState1 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 1000;
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
				return 500;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				skill_charging = skill.GetCharging();

				/*
				  if ( skill_charging <= 0xFA )
				  {
				    skill.SetCrithurt(0.0f);
				  }
				  else
				  {
				skill.SetCrithurt((skill_charging * 0.003f * 0.09f));
				  }
				  if ( skill_charging <= 0xFA )
				  {
				    skill.SetCrit(0.050000001f);
				  }
				  else
				  {
				skill.SetCrit((skill_charging * 0.0005f * 0.09f + 0.05f));
				  }
				player.SetVar1(1);
				  if ( skill_charging <= 0xFA )
				  {
				    skill.SetRatio(1.11f);
				  }
				  else
				  {
				skill.SetRatio((skill_charging * 0.0005f * 0.95f + 1.11f));
				  }
				skill.SetPlus(643.0f);
				player.SetPerform(1);
				*/
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
				return 500;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				skill_charging = skill.GetCharging();

				/*
				  if ( skill_charging <= 0xFA )
				  {
				    skill.SetCrithurt(0.0f);
				  }
				  else
				  {
				skill.SetCrithurt((skill_charging * 0.003f * 0.09f));
				  }
				  if ( skill_charging <= 0xFA )
				  {
				    skill.SetCrit(0.050000001f);
				  }
				  else
				  {
				skill.SetCrit((skill_charging * 0.0005f * 0.09f + 0.05f));
				  }
				player.SetVar1(2);
				  if ( skill_charging <= 0xFA )
				  {
				    skill.SetRatio(1.11f);
				  }
				  else
				  {
				skill.SetRatio((skill_charging * 0.0005f * 0.95f + 1.11f));
				  }
				skill.SetPlus(643.0f);
				player.SetPerform(0);
				*/
			}
		}
		public GSkill5079Stub()
			: base(5079)
		{
			occupation = 128;
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
			SetAction(0,"����_˫�ɻ�");
			SetAction(1,"0");
			SetAction(2,"0");
			SetAction(3,"0");
			SetAction(4,"0");
			SetAction(5,"0");
			SetAction(6,"0");
			SetAction(7,"0");
			SetAction(8,"����_˫�ɻ�");
			SetAction(9,"0");
			SetAction(10,"0");
			SetAction(11,"0");
			SetAction(12,"0");
			SetAction(13,"0");
			SetAction(14,"0");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"����_���_˫�ɻ�");
			SetAction(19,"0");
			SetAction(20,"0");
			SetAction(21,"0");
			SetAction(22,"0");
			SetAction(23,"0");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"����_���_˫�ɻ�");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "˫�ɻ�";
			nativename = "˫�ɻ�";
			icon = "˫�ɻ�.dds";
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
		public override int GetEnmity(GSkill skill)
		{
			return 1;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 30.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 25.000000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 40.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			return 687.000000f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_var1 = player.GetVar1();

			/*
			if ( player_var1 == 1 )
			d = 120.0f;
			else
			victim.SetProbability(0.0f);
			victim.SetTime(10000.0f);
			victim.SetBuffid(1);
			victim.SetAmount(3215.0f);
			victim.SetValue(0.0f);
			victim.SetHpleak(true);
			if ( player_var1 == 2 )
			v17 = 120.0f;
			else
			victim.SetProbability(0.0f);
			victim.SetTime(10000.0f);
			victim.SetBuffid(1);
			victim.SetAmount(3215.0f);
			victim.SetValue(0.0f);
			victim.SetMpleak(true);
			*/
			return true;
		}
	}
	public class GSkill5079 : GSkill
	{
		public GSkill5079()
			: base(5079)
		{
			
		}
	}
}
