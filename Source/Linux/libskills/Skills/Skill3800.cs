using System;
using System.Text;

namespace SKILL
{
	public class GSkill3800Stub : GSkillStub
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
				int				player_maxhp = player.GetMaxhp();

				player.SetVar1(1);
				skill.SetPlus(((player_maxhp - player_hp) * 0.15f));
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
				int				player_mp = player.GetMp();
				int				player_maxmp = player.GetMaxmp();

				player.SetVar1(2);
				skill.SetPlus(((player_maxmp - player_mp) * 0.15f));
				player.SetPerform(0);
			}
		}
		public GSkill3800Stub()
			: base(3800)
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
			SetAction(0,"�ϻ���_���Ƿ�");
			SetAction(1,"�ϻ���_���Ƿ�");
			SetAction(2,"�ϻ���_���Ƿ�");
			SetAction(3,"�ϻ���_���Ƿ�");
			SetAction(4,"�ϻ���_���Ƿ�");
			SetAction(5,"�ϻ���_���Ƿ�");
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
			SetAction(18,"�ϻ���_���_���Ƿ�");
			SetAction(19,"�ϻ���_���_���Ƿ�");
			SetAction(20,"�ϻ���_���_���Ƿ�");
			SetAction(21,"�ϻ���_���_���Ƿ�");
			SetAction(22,"�ϻ���_���_���Ƿ�");
			SetAction(23,"�ϻ���_���_���Ƿ�");
			SetAction(24,"");
			SetAction(25,"");
			SetAction(26,"");
			SetAction(27,"");
			SetAction(28,"");
			SetAction(29,"");
			SetAction(30,"");
			name = "���Ƿ񣺷�";
			nativename = "���Ƿ񣺷�";
			icon = "���Ƿ�.dds";
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

			return player_range + 4.0f;
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

			return player_range + 7.0f;
		}
		public override float GetMpcost(GSkill skill)
		{
			return 1050.000000f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_var1 = player.GetVar1();

			/*
			if ( player_var1 == 2 )
			d = 100.0f;
			else
			victim.SetProbability(0.0f);
			victim.SetTime(30100.0f);
			victim.SetRatio(1.0f);
			victim.SetBuffid(9);
			victim.SetValue(3854.0f);
			victim.SetDelaycast(true);
			victim.SetTime(15100.0f);
			victim.SetRatio(0.15000001f);
			victim.SetBuffid(0);
			victim.SetDecskilldamage(true);
			victim.SetProbability(100.0f);
			victim.SetTime(15100.0f);
			victim.SetRatio(0.15000001f);
			victim.SetInchurt(true);
			*/
			return true;
		}
	}
	public class GSkill3800 : GSkill
	{
		public GSkill3800()
			: base(3800)
		{
			
		}
	}
	public class GSkill3801Stub : GSkillStub
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
		public GSkill3801Stub()
			: base(3801)
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
			SetAction(0,"���_��ħ");
			SetAction(1,"���_��ħ");
			SetAction(2,"���_��ħ");
			SetAction(3,"���_��ħ");
			SetAction(4,"���_��ħ");
			SetAction(5,"���_��ħ");
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
			SetAction(18,"���_���_��ħ");
			SetAction(19,"���_���_��ħ");
			SetAction(20,"���_���_��ħ");
			SetAction(21,"���_���_��ħ");
			SetAction(22,"���_���_��ħ");
			SetAction(23,"���_���_��ħ");
			SetAction(24,"");
			SetAction(25,"");
			SetAction(26,"");
			SetAction(27,"");
			SetAction(28,"");
			SetAction(29,"");
			SetAction(30,"");
			name = "��ħ����";
			nativename = "��ħ����";
			icon = "��ħ.dds";
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
			int				player_level = player.GetLevel();
			int				player_maxmp = player.GetMaxmp();

			victim.SetProbability(100.0f);
			victim.SetAmount(((300 * player_level * (norm((player_maxmp * 0.6f + 1.0f) / (300 * player_level)))) + (player_maxmp * (norm(((300 * player_level)) / (player_maxmp * 0.6f + 1.0f)) * 0.6f))));
			victim.SetMpdisperse(true);
			victim.SetTime(15100.0f);
			victim.SetBuffid(0);
			victim.SetAmount(1.0f);
			victim.SetTurnbuff(true);
			victim.SetProbability(100.0f);
			victim.SetTime(30100.0f);
			victim.SetBuffid(0);
			victim.SetValue(((5 * player_level)));
			victim.SetSubattack(true);
			victim.SetProbability(120.0f);
			victim.SetTime(30100.0f);
			victim.SetBuffid(0);
			victim.SetValue((player_level * 0.5f + 1.0f));
			victim.SetSubanti(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_level = player.GetLevel();

			victim.SetProbability(100.0f);
			victim.SetTime(30100.0f);
			victim.SetBuffid(0);
			victim.SetValue(((5 * player_level)));
			victim.SetAddattack(true);
			return true;
		}
	}
	public class GSkill3801 : GSkill
	{
		public GSkill3801()
			: base(3801)
		{
			
		}
	}
	public class GSkill3802Stub : GSkillStub
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
		public GSkill3802Stub()
			: base(3802)
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
			SetAction(0,"���_ɳ��");
			SetAction(1,"���_ɳ��");
			SetAction(2,"���_ɳ��");
			SetAction(3,"���_ɳ��");
			SetAction(4,"���_ɳ��");
			SetAction(5,"���_ɳ��");
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
			SetAction(18,"���_���_ɳ��");
			SetAction(19,"���_���_ɳ��");
			SetAction(20,"���_���_ɳ��");
			SetAction(21,"���_���_ɳ��");
			SetAction(22,"���_���_ɳ��");
			SetAction(23,"���_���_ɳ��");
			SetAction(24,"");
			SetAction(25,"");
			SetAction(26,"");
			SetAction(27,"");
			SetAction(28,"");
			SetAction(29,"");
			SetAction(30,"");
			name = "ɳ������";
			nativename = "ɳ������";
			icon = "ɳ��.dds";
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
			return 900.000000f;
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
			victim.SetTime(30100.0f);
			victim.SetRatio(1.0f);
			victim.SetAmount(25.0f);
			victim.SetValue(((2 * player_level)));
			victim.SetBloodshield(true);
			victim.SetTime(12100.0f);
			victim.SetImmunedizzy(true);
			victim.SetRatio(3801.0f);
			victim.SetAmount(3803.0f);
			victim.SetValue(3804.0f);
			victim.SetClearcooldown(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetProbability(100.0f);
			victim.SetTime(60000.0f);
			victim.SetRatio(0.15000001f);
			victim.SetBuffid(0);
			victim.SetIncskillaccu(true);
			return true;
		}
	}
	public class GSkill3802 : GSkill
	{
		public GSkill3802()
			: base(3802)
		{
			
		}
	}
	public class GSkill3803Stub : GSkillStub
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
		public GSkill3803Stub()
			: base(3803)
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
			SetAction(0,"���_����");
			SetAction(1,"���_����");
			SetAction(2,"���_����");
			SetAction(3,"���_����");
			SetAction(4,"���_����");
			SetAction(5,"���_����");
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
			SetAction(18,"���_���_����");
			SetAction(19,"���_���_����");
			SetAction(20,"���_���_����");
			SetAction(21,"���_���_����");
			SetAction(22,"���_���_����");
			SetAction(23,"���_���_����");
			SetAction(24,"");
			SetAction(25,"");
			SetAction(26,"");
			SetAction(27,"");
			SetAction(28,"");
			SetAction(29,"");
			SetAction(30,"");
			name = "���У���";
			nativename = "���У���";
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
			return 252000;
		}
		public override float GetPraydistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return player_range + 4.0f;
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

			return player_range + 6.0f;
		}
		public override float GetMpcost(GSkill skill)
		{
			return 850.000000f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_maxmp = player.GetMaxmp();
			int				player_res4 = player.GetRes4();

			/*
			victim.SetProbability(100.0f);
			victim.SetTime(12100.0f);
			victim.SetBarehanded(true);
			if ( player.GetObjectType() )
			d = 0.0f;
			else
			victim.SetProbability(15.0f);
			victim.SetTime(12100.0f);
			victim.SetBuffid(0);
			victim.SetAmount(1.0f);
			victim.SetValue(player_maxmp);
			victim.SetSubmp(true);
			victim.SetTime(16100.0f);
			victim.SetBuffid(0);
			victim.SetValue(player_res4);
			victim.SetSubantisilent(true);
			*/
			return true;
		}
	}
	public class GSkill3803 : GSkill
	{
		public GSkill3803()
			: base(3803)
		{
			
		}
	}
	public class GSkill3804Stub : GSkillStub
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

				skill.SetPlus(((zrand((D2INT(player_mp * 0.25f + (player_hp * 0.25f)))) + 1)));
				player.SetPerform(1);
			}
		}
		public GSkill3804Stub()
			: base(3804)
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
			SetAction(0,"���_�Ļ�");
			SetAction(1,"���_�Ļ�");
			SetAction(2,"���_�Ļ�");
			SetAction(3,"���_�Ļ�");
			SetAction(4,"���_�Ļ�");
			SetAction(5,"���_�Ļ�");
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
			SetAction(18,"���_���_�Ļ�");
			SetAction(19,"���_���_�Ļ�");
			SetAction(20,"���_���_�Ļ�");
			SetAction(21,"���_���_�Ļ�");
			SetAction(22,"���_���_�Ļ�");
			SetAction(23,"���_���_�Ļ�");
			SetAction(24,"");
			SetAction(25,"");
			SetAction(26,"");
			SetAction(27,"");
			SetAction(28,"");
			SetAction(29,"");
			SetAction(30,"");
			name = "�Ļ�����";
			nativename = "�Ļ�����";
			icon = "�Ļ�.dds";
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
			return 360000;
		}
		public override float GetPraydistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return player_range + 4.0f;
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

			return player_range + 7.0f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetProbability(100.0f);
			victim.SetTime(30100.0f);
			victim.SetRatio(1.0f);
			victim.SetBuffid(9);
			victim.SetValue(3854.0f);
			victim.SetDelaycast(true);
			victim.SetProbability(100.0f);
			victim.SetTime(6100.0f);
			victim.SetPowerless(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_maxmp = player.GetMaxmp();

			victim.SetProbability(100.0f);
			victim.SetTime(15100.0f);
			victim.SetBuffid(0);
			victim.SetValue(10.0f);
			victim.SetAddspeed(true);
			victim.SetProbability(100.0f);
			victim.SetTime(100.0f);
			victim.SetBuffid(0);
			victim.SetAmount((player_maxmp * 0.15f));
			victim.SetValue(0.0f);
			victim.SetMpgen(true);
			return true;
		}
	}
	public class GSkill3804 : GSkill
	{
		public GSkill3804()
			: base(3804)
		{
			
		}
	}
	public class GSkill3805Stub : GSkillStub
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
				return 400;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_res3 = player.GetRes3();
				int				skill_level = skill.GetLevel();

				player.SetVar1(1);
				player.SetVar2(player_res3);
				skill.SetPlus(((10 * skill_level * skill_level + (15 * skill_level) + 190)));
				skill.SetRatio((skill_level * 0.02f + 1.0f));
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
				int				player_res3 = player.GetRes3();
				int				skill_level = skill.GetLevel();

				player.SetVar1(0);
				player.SetVar2(player_res3);
				skill.SetPlus(((10 * skill_level * skill_level + (15 * skill_level) + 190)));
				skill.SetRatio((skill_level * 0.02f + 1.0f));
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
				int				player_res3 = player.GetRes3();
				int				skill_level = skill.GetLevel();

				player.SetVar1(0);
				player.SetVar2(player_res3);
				skill.SetPlus(((10 * skill_level * skill_level + (15 * skill_level) + 190)));
				skill.SetRatio((skill_level * 0.02f + 1.0f));
				player.SetPerform(0);
			}
		}
		public GSkill3805Stub()
			: base(3805)
		{
			occupation = 150;
			maxlevel = 12;
			maxlearn = 10;
			eventflag = 0;
			spcost = 0;
			reborncount = 0;
			type = 1;
			timetype = 0;
			targettype = 0;
			rangetype = 0;
			doenchant = false;
			dobless = true;
			autoattack = false;
			allowform = 0;
			credittype = 11;
			clearmask = 132;
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
			weapon_limit = 11;
			SetAction(0,"̫�_˺��");
			SetAction(1,"0");
			SetAction(2,"0");
			SetAction(3,"0");
			SetAction(4,"0");
			SetAction(5,"0");
			SetAction(6,"0");
			SetAction(7,"0");
			SetAction(8,"0");
			SetAction(9,"0");
			SetAction(10,"0");
			SetAction(11,"̫�_˺��");
			SetAction(12,"0");
			SetAction(13,"");
			SetAction(14,"");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"̫�_���_˺��");
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
			SetAction(29,"̫�_���_˺��");
			SetAction(30,"0");
			name = "Ѫ���II";
			nativename = "Ѫ���II";
			icon = "Ѫ���II.dds";
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
			skill_class = 10;
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
			return 2000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			return 15000;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={125,125,125,125,125,127,129,131,133,135};return array[level-1];
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 7.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 3.000000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 15.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (20 * skill_level + 550);
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_var1 = player.GetVar1();
			int				player_var2 = player.GetVar2();
			int				skill_level = skill.GetLevel();

			/*
			if ( player_var1 == 1 )
			d = (5 * skill_level + 20);
			else
			victim.SetProbability(0.0f);
			victim.SetTime(15000.0f);
			victim.SetAmount(skill_level);
			victim.SetValue(3705.0f);
			victim.SetTriggerskill(true);
			victim.SetProbability(-1.0f);
			victim.SetTime(10.0f);
			victim.SetRatio(3705.0f);
			victim.SetAmount(0.0f);
			victim.SetValue(0.0f);
			victim.SetSetcooldown(true);
			victim.SetTime(((2000 * skill_level + 5000)));
			victim.SetBuffid(1);
			victim.SetValue((skill_level * (player_var2 * 0.01f)));
			victim.SetAddantiwrap(true);
			*/
			return true;
		}
		public override int GetCreditCost(int level)
		{
			int[] array={18000,20000,22000,24000,26000,28000,30000,32000,38000,45000};return array[level-1];
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={3480};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={6};return array[index];
		}
	}
	public class GSkill3805 : GSkill
	{
		public GSkill3805()
			: base(3805)
		{
			
		}
	}
	public class GSkill3806Stub : GSkillStub
	{
		public class GState1 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 1200;
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
				int				player_res3 = player.GetRes3();
				int				skill_level = skill.GetLevel();

				player.SetVar1(player_res3);
				skill.SetPlus(((10 * skill_level * skill_level + (6 * skill_level) + 253)));
				skill.SetRatio((skill_level * 0.01f + 1.01f));
				player.SetPerform(1);
			}
		}
		public GSkill3806Stub()
			: base(3806)
		{
			occupation = 150;
			maxlevel = 12;
			maxlearn = 10;
			eventflag = 0;
			spcost = 0;
			reborncount = 0;
			type = 1;
			timetype = 0;
			targettype = 0;
			rangetype = 2;
			doenchant = true;
			dobless = false;
			autoattack = false;
			allowform = 0;
			credittype = 11;
			clearmask = 132;
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
			weapon_limit = 11;
			SetAction(0,"̫�_���촸");
			SetAction(1,"0");
			SetAction(2,"0");
			SetAction(3,"0");
			SetAction(4,"0");
			SetAction(5,"0");
			SetAction(6,"0");
			SetAction(7,"0");
			SetAction(8,"0");
			SetAction(9,"0");
			SetAction(10,"0");
			SetAction(11,"̫�_���촸");
			SetAction(12,"0");
			SetAction(13,"");
			SetAction(14,"");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"̫�_���_���촸");
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
			SetAction(29,"̫�_���_���촸");
			SetAction(30,"0");
			name = "�����II";
			nativename = "�����II";
			icon = "�����II.dds";
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
			skill_class = 10;
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
			return 120000;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={125,125,125,125,125,127,129,131,133,135};return array[level-1];
		}
		public override float GetRadius(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return (skill_level + 6);
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 7.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 1.700000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			return 1800.000000f;
		}
		public override int GetCoverage(GSkill skill)
		{
			int				skill_level = skill.GetLevel();

			return skill_level;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_res3 = player.GetRes3();
			int				player_var1 = player.GetVar1();
			int				skill_level = skill.GetLevel();

			/*
			if ( player_var1 - player_res3 <= 0 )
			{
			d = 0.0f;
			}
			else
			{
			d = (player_var1 - player_res3);
			}
			victim.SetProbability(d);
			victim.SetTime(15000.0f);
			victim.SetRatio((skill_level * 0.08f));
			victim.SetValue((skill_level * 0.08f));
			victim.SetParalysis(true);
			victim.SetProbability(-1.0f);
			victim.SetTime(8000.0f);
			victim.SetValue(skill_level);
			victim.SetCrippleddebuff(true);
			*/
			return true;
		}
		public override int GetCreditCost(int level)
		{
			int[] array={18000,20000,22000,24000,26000,28000,30000,32000,38000,45000};return array[level-1];
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={3484};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={9};return array[index];
		}
	}
	public class GSkill3806 : GSkill
	{
		public GSkill3806()
			: base(3806)
		{
			
		}
	}
	public class GSkill3807Stub : GSkillStub
	{
		public class GState1 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 500;
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
				return 1500;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();

				player.SetPerform(1);
			}
		}
		public GSkill3807Stub()
			: base(3807)
		{
			occupation = 150;
			maxlevel = 12;
			maxlearn = 10;
			eventflag = 0;
			spcost = 0;
			reborncount = 0;
			type = 2;
			timetype = 0;
			targettype = 0;
			rangetype = 5;
			doenchant = true;
			dobless = false;
			autoattack = false;
			allowform = 0;
			credittype = 11;
			clearmask = 132;
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
			weapon_limit = 11;
			SetAction(0,"̫�_����������");
			SetAction(1,"0");
			SetAction(2,"0");
			SetAction(3,"0");
			SetAction(4,"0");
			SetAction(5,"0");
			SetAction(6,"0");
			SetAction(7,"0");
			SetAction(8,"0");
			SetAction(9,"0");
			SetAction(10,"0");
			SetAction(11,"̫�_����������");
			SetAction(12,"0");
			SetAction(13,"");
			SetAction(14,"");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"̫�_���_����������");
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
			SetAction(29,"̫�_���_����������");
			SetAction(30,"0");
			name = "������II";
			nativename = "������II";
			icon = "������II.dds";
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
			skill_class = 10;
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
			return 120000;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={125,125,125,125,125,127,129,131,133,135};return array[level-1];
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
			return 450.000000f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();

			victim.SetProbability(120.0f);
			victim.SetTime(((1000 * skill_level + 5000)));
			victim.SetRatio((skill_level * 0.05f));
			victim.SetBuffid(1);
			victim.SetIncskilldodge(true);
			return true;
		}
		public override int GetCreditCost(int level)
		{
			int[] array={18000,20000,22000,24000,26000,28000,30000,32000,38000,45000};return array[level-1];
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={3485};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={3};return array[index];
		}
	}
	public class GSkill3807 : GSkill
	{
		public GSkill3807()
			: base(3807)
		{
			
		}
	}
	public class GSkill3808Stub : GSkillStub
	{
		public GSkill3808Stub()
			: base(3808)
		{
			occupation = 150;
			maxlevel = 12;
			maxlearn = 10;
			eventflag = 1;
			spcost = 0;
			reborncount = 0;
			type = 11;
			timetype = 0;
			targettype = 0;
			rangetype = 5;
			doenchant = false;
			dobless = false;
			autoattack = false;
			allowform = 0;
			credittype = 11;
			clearmask = 132;
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
			SetAction(0,"");
			SetAction(1,"0");
			SetAction(2,"0");
			SetAction(3,"0");
			SetAction(4,"0");
			SetAction(5,"0");
			SetAction(6,"0");
			SetAction(7,"0");
			SetAction(8,"0");
			SetAction(9,"0");
			SetAction(10,"0");
			SetAction(11,"");
			SetAction(12,"0");
			SetAction(13,"");
			SetAction(14,"");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"");
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
			SetAction(29,"");
			SetAction(30,"0");
			name = "�����������II";
			nativename = "�����������II";
			icon = "�����������II.dds";
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
			skill_class = 10;
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
			int[] array={125,125,125,125,125,127,129,131,133,135};return array[level-1];
		}
		public override int GetCreditCost(int level)
		{
			int[] array={18000,20000,22000,24000,26000,28000,30000,32000,38000,45000};return array[level-1];
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={3486};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={5};return array[index];
		}
	}
	public class GSkill3808 : GSkill
	{
		public GSkill3808()
			: base(3808)
		{
			
		}
	}
	public class GSkill3809Stub : GSkillStub
	{
		public GSkill3809Stub()
			: base(3809)
		{
			occupation = 150;
			maxlevel = 12;
			maxlearn = 10;
			eventflag = 1;
			spcost = 0;
			reborncount = 0;
			type = 11;
			timetype = 0;
			targettype = 0;
			rangetype = 0;
			doenchant = false;
			dobless = false;
			autoattack = false;
			allowform = 0;
			credittype = 11;
			clearmask = 132;
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
			SetAction(0,"0");
			SetAction(1,"0");
			SetAction(2,"0");
			SetAction(3,"0");
			SetAction(4,"0");
			SetAction(5,"0");
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
			name = "��Ԫ��II";
			nativename = "��Ԫ��II";
			icon = "��Ԫ��II.dds";
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
			skill_class = 10;
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
			int[] array={125,125,125,125,125,127,129,131,133,135};return array[level-1];
		}
		public override bool TakeEffect(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			int				skill_level = skill.GetLevel();

			player.SetPasdecfatalratio((skill_level * 0.01f));
			return true;
		}
		public override int GetCreditCost(int level)
		{
			int[] array={18000,20000,22000,24000,26000,28000,30000,32000,38000,45000};return array[level-1];
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={3492};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={3};return array[index];
		}
	}
	public class GSkill3809 : GSkill
	{
		public GSkill3809()
			: base(3809)
		{
			
		}
	}
}
