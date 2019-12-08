using System;
using System.Text;

namespace SKILL
{
	public class GSkill2030Stub : GSkillStub
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
		public GSkill2030Stub()
			: base(2030)
		{
			occupation = 128;
			maxlevel = 100;
			maxlearn = 100;
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
			skill_limit = 10;
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
			name = "��ͷ����-Blanka";
			nativename = "��ͷ����-Blanka";
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
			return 2000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			return 2000;
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
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();

			victim.SetTime(5000.0f);
			victim.SetRatio((skill_level * 0.1f));
			victim.SetAmount(((1000 * skill_level)));
			victim.SetMagicshield(true);
			return true;
		}
	}
	public class GSkill2030 : GSkill
	{
		public GSkill2030()
			: base(2030)
		{
			
		}
	}
	public class GSkill2031Stub : GSkillStub
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
		public GSkill2031Stub()
			: base(2031)
		{
			occupation = 128;
			maxlevel = 100;
			maxlearn = 100;
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
			skill_limit = 10;
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
			name = "��ͷ����-Zangief";
			nativename = "��ͷ����-Zangief";
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
			return 2000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			return 2000;
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
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();

			victim.SetProbability(120.0f);
			victim.SetTime(5000.0f);
			victim.SetBuffid(2);
			victim.SetValue(((2 * skill_level)));
			victim.SetAdddodge(true);
			victim.SetProbability(120.0f);
			victim.SetTime(5000.0f);
			victim.SetRatio(skill_level);
			victim.SetBuffid(2);
			victim.SetIncskilldodge(true);
			return true;
		}
	}
	public class GSkill2031 : GSkill
	{
		public GSkill2031()
			: base(2031)
		{
			
		}
	}
	public class GSkill2032Stub : GSkillStub
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

				skill.SetRatio(1.0f);
				player.SetPerform(1);
			}
		}
		public GSkill2032Stub()
			: base(2032)
		{
			occupation = 128;
			maxlevel = 100;
			maxlearn = 100;
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
			allowform = 0;
			credittype = 0;
			clearmask = 0;
			skill_limit = 10;
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
			name = "��ͷ����-Bison";
			nativename = "��ͷ����-Bison";
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
			return 2000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			return 2000;
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

			return player_range;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return player_range + 7.0f;
		}
		public override float GetMpcost(GSkill skill)
		{
			return 1000.000000f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();

			victim.SetProbability(600.0f);
			victim.SetTime(((2000 * skill_level)));
			victim.SetRatio((skill_level * 0.01f));
			victim.SetBuffid(2);
			victim.SetWeak(true);
			return true;
		}
	}
	public class GSkill2032 : GSkill
	{
		public GSkill2032()
			: base(2032)
		{
			
		}
	}
	public class GSkill2033Stub : GSkillStub
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
				int				player_maxatk = player.GetMaxatk();

				player.SetVar1(player_maxatk);
				player.SetPerform(1);
			}
		}
		public GSkill2033Stub()
			: base(2033)
		{
			occupation = 129;
			maxlevel = 1;
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
			SetAction(0,"������_�������");
			SetAction(1,"������_�������");
			SetAction(2,"������_�������");
			SetAction(3,"������_�������");
			SetAction(4,"������_�������");
			SetAction(5,"������_�������");
			SetAction(6,"0");
			SetAction(7,"����_����");
			SetAction(8,"����_����ɽ");
			SetAction(9,"��ԯ_���ܻ�");
			SetAction(10,"0");
			SetAction(11,"0");
			SetAction(12,"0");
			SetAction(13,"����_�ͻ�");
			SetAction(14,"Ӣ��_�ͻ�");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"������_���_�������");
			SetAction(19,"������_���_�������");
			SetAction(20,"������_���_�������");
			SetAction(21,"������_���_�������");
			SetAction(22,"������_���_�������");
			SetAction(23,"������_���_�������");
			SetAction(24,"0");
			SetAction(25,"����_���_����");
			SetAction(26,"����_���_����ɽ");
			SetAction(27,"��ԯ_���_���ܻ�");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "��������";
			nativename = "��������";
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
		}
		public override int GetExecutetime(GSkill skill)
		{
			return 1000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			return 900000;
		}
		public override int GetEnmity(GSkill skill)
		{
			return 1;
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
			return 20.000000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 25.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			return 1000.000000f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_hp = player.GetHp();
			int				player_var1 = player.GetVar1();

			/*
			v37 = player.GetObjectType() == 0;
			if ( player.GetGender() == 1 )
			d = (600 * v37);
			else
			victim.SetProbability(0.0f);
			victim.SetTime(10000.0f);
			victim.SetDizzy(true);
			v35 = player.GetObjectType() == 0;
			if ( player.GetGender() == 2 )
			v34 = (600 * v35);
			else
			victim.SetProbability(0.0f);
			victim.SetTime(10000.0f);
			victim.SetSilent(true);
			v33 = player.GetObjectType() == 0;
			if ( player.GetGender() == 2 )
			v32 = (600 * v33);
			else
			victim.SetProbability(0.0f);
			victim.SetTime(10000.0f);
			victim.SetWrap(true);
			if ( player.GetObjectType() )
			v31 = 120.0f;
			else
			victim.SetProbability(0.0f);
			victim.SetTime(100.0f);
			victim.SetBuffid(0);
			if ( player_hp >= 15 * player_var1 )
			{
			v30 = (15 * player_var1);
			}
			else
			{
			v30 = (player_hp + 1);
			}
			victim.SetAmount(v30);
			victim.SetValue(0.0f);
			victim.SetHpleak(true);
			*/
			return true;
		}
	}
	public class GSkill2033 : GSkill
	{
		public GSkill2033()
			: base(2033)
		{
			
		}
	}
	public class GSkill2034Stub : GSkillStub
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
		public GSkill2034Stub()
			: base(2034)
		{
			occupation = 129;
			maxlevel = 1;
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
			SetAction(7,"����_����");
			SetAction(8,"����_����ɽ");
			SetAction(9,"��ԯ_���ܻ�");
			SetAction(10,"0");
			SetAction(11,"0");
			SetAction(12,"0");
			SetAction(13,"����_�ͻ�");
			SetAction(14,"Ӣ��_�ͻ�");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"�ϻ���_���_��Ӱ");
			SetAction(19,"�ϻ���_���_��Ӱ");
			SetAction(20,"�ϻ���_���_��Ӱ");
			SetAction(21,"�ϻ���_���_��Ӱ");
			SetAction(22,"�ϻ���_���_��Ӱ");
			SetAction(23,"�ϻ���_���_��Ӱ");
			SetAction(24,"0");
			SetAction(25,"����_���_����");
			SetAction(26,"����_���_����ɽ");
			SetAction(27,"��ԯ_���_���ܻ�");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "�������";
			nativename = "�������";
			icon = "��Ӱ.dds";
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
			return 900000;
		}
		public override int GetEnmity(GSkill skill)
		{
			return 1;
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
			return 20.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			return 1000.000000f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();

			/*
			v23 = player.GetObjectType() == 0;
			if ( player.GetGender() == 2 )
			d = (600 * v23);
			else
			victim.SetProbability(0.0f);
			victim.SetTime(10000.0f);
			victim.SetDizzy(true);
			v21 = player.GetObjectType() == 0;
			if ( player.GetGender() == 1 )
			v20 = (600 * v21);
			else
			victim.SetProbability(0.0f);
			victim.SetTime(10000.0f);
			victim.SetSilent(true);
			v19 = player.GetObjectType() == 0;
			if ( player.GetGender() == 1 )
			v18 = (600 * v19);
			else
			victim.SetProbability(0.0f);
			victim.SetTime(10000.0f);
			victim.SetWrap(true);
			*/
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetProbability(120.0f);
			victim.SetTime(15000.0f);
			victim.SetRatio(2.0f);
			victim.SetBuffid(0);
			victim.SetIncskilldodge(true);
			victim.SetProbability(120.0f);
			victim.SetTime(15000.0f);
			victim.SetBuffid(0);
			victim.SetValue(600.0f);
			victim.SetAdddodge(true);
			return true;
		}
	}
	public class GSkill2034 : GSkill
	{
		public GSkill2034()
			: base(2034)
		{
			
		}
	}
	public class GSkill2035Stub : GSkillStub
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
				int				player_minatk = player.GetMinatk();
				int				player_maxatk = player.GetMaxatk();

				player.SetVar1(player_maxatk);
				player.SetVar2(player_minatk);
				player.SetPerform(1);
			}
		}
		public GSkill2035Stub()
			: base(2035)
		{
			occupation = 148;
			maxlevel = 30;
			maxlearn = 20;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 3;
			timetype = 0;
			targettype = 0;
			rangetype = 0;
			doenchant = true;
			dobless = false;
			autoattack = false;
			allowform = 0;
			credittype = 9;
			clearmask = 129;
			skill_limit = 1;
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
			SetAction(0,"���_Թŭ");
			SetAction(1,"������_Թŭ");
			SetAction(2,"������_Թŭ");
			SetAction(3,"�ϻ���_Թŭ");
			SetAction(4,"������_Թŭ");
			SetAction(5,"���_Թŭ");
			SetAction(6,"����_Թŭ");
			SetAction(7,"����_Թŭ");
			SetAction(8,"����_Թŭ");
			SetAction(9,"��ԯ_Թŭ");
			SetAction(10,"����_Թŭ");
			SetAction(11,"̫�_Թŭ");
			SetAction(12,"�컪_Թŭ");
			SetAction(13,"����_Թŭ");
			SetAction(14,"Ӣ��_Թŭ");
			SetAction(15,"������ʦ_Թŭ");
			SetAction(16,"Ԫ�ش�ʦ_Թŭ");
			SetAction(17,"������_Թŭ");
			SetAction(18,"���_���_Թŭ");
			SetAction(19,"������_���_Թŭ");
			SetAction(20,"������_���_Թŭ");
			SetAction(21,"�ϻ���_���_Թŭ");
			SetAction(22,"������_���_Թŭ");
			SetAction(23,"���_���_Թŭ");
			SetAction(24,"����_���_Թŭ");
			SetAction(25,"����_���_Թŭ");
			SetAction(26,"����_���_Թŭ");
			SetAction(27,"��ԯ_���_Թŭ");
			SetAction(28,"����_���_Թŭ");
			SetAction(29,"̫�_���_Թŭ");
			SetAction(30,"�컪_���_Թŭ");
			name = "��֮Թŭ";
			nativename = "��֮Թŭ";
			icon = "��֮Թŭ.dds";
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
			int				skill_level = skill.GetLevel();

			return 600000 - 15000 * skill_level;
		}
		public override int GetEnmity(GSkill skill)
		{
			return 1;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={100,105,110,115,120,125,125,125,125,125,125,125,125,125,125,125,125,130,135,140};return array[level-1];
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
		public override float GetMpcost(GSkill skill)
		{
			return 1000.000000f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_var1 = player.GetVar1();
			int				player_var2 = player.GetVar2();
			int				skill_level = skill.GetLevel();

			/*
			victim.SetProbability(120.0f);
			victim.SetTime(((2000 * skill_level + 10000)));
			victim.SetBuffid(0);
			v46 = (0.03f * skill_level) + 0.2f;
			v45 = player_var1;
			v44 = (skill_level + 5);
			if ( player.GetCultivation() == 4 )
			v43 = (v46 + v46) * v45 * v44;
			else
			victim.SetAmount((v46 * v45 * v44));
			victim.SetValue(0.0f);
			victim.SetHpleak(true);
			victim.SetProbability(120.0f);
			victim.SetTime(((2000 * skill_level + 10000)));
			victim.SetBuffid(0);
			v42 = (0.03f * skill_level) + 0.2f;
			v41 = player_var2;
			v40 = (skill_level + 5);
			if ( player.GetCultivation() == 4 )
			v39 = (v42 + v42) * v41 * v40;
			else
			victim.SetAmount((v42 * v41 * v40));
			victim.SetValue(0.0f);
			victim.SetMpleak(true);
			victim.SetProbability(600.0f);
			victim.SetTime(((2000 * skill_level + 10000)));
			v38 = skill_level;
			if ( player.GetCultivation() == 4 )
			v37 = 0.04f * v38;
			else
			victim.SetRatio((0.02f * v38));
			victim.SetBuffid(0);
			victim.SetSlow(true);
			victim.SetProbability(120.0f);
			victim.SetTime(900000.0f);
			victim.SetRatio(2040.0f);
			victim.SetAmount(219.0f);
			victim.SetValue(219.0f);
			victim.SetSetcooldown(true);
			*/
			return true;
		}
		public override int GetCreditCost(int level)
		{
			int[] array={24000,26000,28000,30000,32000,34000,36000,38000,40000,42000,45000,48000,51000,54000,57000,60000,64000,68000,72000,80000};return array[level-1];
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={1520};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={3};return array[index];
		}
	}
	public class GSkill2035 : GSkill
	{
		public GSkill2035()
			: base(2035)
		{
			
		}
	}
	public class GSkill2036Stub : GSkillStub
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
				int				player_occupation = player.GetOccupation();

				player.SetVar1((player_occupation == 10)?1:0);
				player.SetVar2((player_occupation == 11)?1:0);
				player.SetVar3((player_occupation == 12)?1:0);
				player.SetVar4((player_occupation == 22)?1:0);
				player.SetVar5((player_occupation == 23)?1:0);
				player.SetPerform(1);
			}
		}
		public GSkill2036Stub()
			: base(2036)
		{
			occupation = 148;
			maxlevel = 30;
			maxlearn = 20;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 2;
			timetype = 0;
			targettype = 0;
			rangetype = 2;
			doenchant = true;
			dobless = false;
			autoattack = false;
			allowform = 0;
			credittype = 9;
			clearmask = 129;
			skill_limit = 1;
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
			SetAction(0,"���_�ػ�");
			SetAction(1,"������_�ػ�");
			SetAction(2,"������_�ػ�");
			SetAction(3,"�ϻ���_�ػ�");
			SetAction(4,"������_�ػ�");
			SetAction(5,"���_�ػ�");
			SetAction(6,"����_�ػ�");
			SetAction(7,"����_�ػ�");
			SetAction(8,"����_�ػ�");
			SetAction(9,"��ԯ_�ػ�");
			SetAction(10,"����_�ػ�");
			SetAction(11,"̫�_�ػ�");
			SetAction(12,"�컪_�ػ�");
			SetAction(13,"����_�ػ�");
			SetAction(14,"Ӣ��_�ػ�");
			SetAction(15,"������ʦ_�ػ�");
			SetAction(16,"Ԫ�ش�ʦ_�ػ�");
			SetAction(17,"������_�ػ�");
			SetAction(18,"���_���_�ػ�");
			SetAction(19,"������_���_�ػ�");
			SetAction(20,"������_���_�ػ�");
			SetAction(21,"�ϻ���_���_�ػ�");
			SetAction(22,"������_���_�ػ�");
			SetAction(23,"���_���_�ػ�");
			SetAction(24,"����_���_�ػ�");
			SetAction(25,"����_���_�ػ�");
			SetAction(26,"����_���_�ػ�");
			SetAction(27,"��ԯ_���_�ػ�");
			SetAction(28,"����_���_�ػ�");
			SetAction(29,"̫�_���_�ػ�");
			SetAction(30,"�컪_���_�ػ�");
			name = "��֮�ػ�";
			nativename = "��֮�ػ�";
			icon = "��֮�ػ�.dds";
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
			return 900000;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={90,95,100,105,110,115,120,125,125,125,125,125,125,125,125,125,125,130,135,140};return array[level-1];
		}
		public override float GetRadius(GSkill skill)
		{
			return 20.000000f;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 20.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 15.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			return 1000.000000f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_maxhp = player.GetMaxhp();
			int				player_maxmp = player.GetMaxmp();
			int				player_var1 = player.GetVar1();
			int				skill_level = skill.GetLevel();

			/*
			victim.SetProbability(120.0f);
			victim.SetTime(((2000 * skill_level + 10000)));
			if ( player_var1 != 1
			&& (v6 = player, GNET::PlayerWrapper::GetVar2(v6) != 1)
			&& (v7 = player, GNET::PlayerWrapper::GetVar3(v7) != 1)
			&& (v8 = player, GNET::PlayerWrapper::GetVar4(v8) != 1)
			&& (v9 = player, GNET::PlayerWrapper::GetVar5(v9) != 1) )
			d = 0.0f;
			else
			victim.SetRatio(1.0f);
			victim.SetBuffid(0);
			victim.SetAmount(0.0f);
			v44 = (0.005f * skill_level) + 0.05f;
			v43 = player_maxhp;
			v42 = (skill_level + 5);
			if ( player.GetCultivation() == 1 )
			v41 = (v44 + v44) * v43 * v42;
			else
			victim.SetValue((v44 * v43 * v42));
			victim.SetHpgen(true);
			victim.SetProbability(120.0f);
			victim.SetTime(((2000 * skill_level + 10000)));
			victim.SetBuffid(0);
			victim.SetAmount(0.0f);
			v40 = (0.005f * skill_level) + 0.05f;
			v39 = player_maxmp;
			v38 = (skill_level + 5);
			if ( player.GetCultivation() == 1 )
			v37 = (v40 + v40) * v39 * v38;
			else
			victim.SetValue((v40 * v39 * v38));
			victim.SetMpgen(true);
			if ( player.GetCultivation() == 1 )
			v36 = 120.0f;
			else
			victim.SetProbability(0.0f);
			victim.SetTime(10000.0f);
			victim.SetBuffid(0);
			victim.SetValue(((100 * skill_level)));
			victim.SetAdddefence(true);
			*/
			return true;
		}
		public override int GetCreditCost(int level)
		{
			int[] array={12000,13000,14000,15000,16000,17000,18000,19000,20000,21000,22000,24000,25500,27500,28500,30000,32000,34000,36000,40000};return array[level-1];
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={1520};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={2};return array[index];
		}
	}
	public class GSkill2036 : GSkill
	{
		public GSkill2036()
			: base(2036)
		{
			
		}
	}
	public class GSkill2037Stub : GSkillStub
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
				int				player_minatk = player.GetMinatk();
				int				player_maxatk = player.GetMaxatk();

				player.SetVar1(player_maxatk);
				player.SetVar2(player_minatk);
				player.SetPerform(1);
			}
		}
		public GSkill2037Stub()
			: base(2037)
		{
			occupation = 149;
			maxlevel = 30;
			maxlearn = 20;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 3;
			timetype = 0;
			targettype = 0;
			rangetype = 0;
			doenchant = true;
			dobless = false;
			autoattack = false;
			allowform = 0;
			credittype = 10;
			clearmask = 130;
			skill_limit = 1;
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
			SetAction(0,"���_Թŭ");
			SetAction(1,"������_Թŭ");
			SetAction(2,"������_Թŭ");
			SetAction(3,"�ϻ���_Թŭ");
			SetAction(4,"������_Թŭ");
			SetAction(5,"���_Թŭ");
			SetAction(6,"����_Թŭ");
			SetAction(7,"����_Թŭ");
			SetAction(8,"����_Թŭ");
			SetAction(9,"��ԯ_Թŭ");
			SetAction(10,"����_Թŭ");
			SetAction(11,"̫�_Թŭ");
			SetAction(12,"�컪_Թŭ");
			SetAction(13,"����_Թŭ");
			SetAction(14,"Ӣ��_Թŭ");
			SetAction(15,"������ʦ_Թŭ");
			SetAction(16,"Ԫ�ش�ʦ_Թŭ");
			SetAction(17,"������_Թŭ");
			SetAction(18,"���_���_Թŭ");
			SetAction(19,"������_���_Թŭ");
			SetAction(20,"������_���_Թŭ");
			SetAction(21,"�ϻ���_���_Թŭ");
			SetAction(22,"������_���_Թŭ");
			SetAction(23,"���_���_Թŭ");
			SetAction(24,"����_���_Թŭ");
			SetAction(25,"����_���_Թŭ");
			SetAction(26,"����_���_Թŭ");
			SetAction(27,"��ԯ_���_Թŭ");
			SetAction(28,"����_���_Թŭ");
			SetAction(29,"̫�_���_Թŭ");
			SetAction(30,"�컪_���_Թŭ");
			name = "ħ֮Թŭ";
			nativename = "ħ֮Թŭ";
			icon = "ħ֮Թŭ.dds";
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
			int				skill_level = skill.GetLevel();

			return 600000 - 15000 * skill_level;
		}
		public override int GetEnmity(GSkill skill)
		{
			return 1;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={100,105,110,115,120,125,125,125,125,125,125,125,125,125,125,125,125,130,135,140};return array[level-1];
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
		public override float GetMpcost(GSkill skill)
		{
			return 1000.000000f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_var1 = player.GetVar1();
			int				player_var2 = player.GetVar2();
			int				skill_level = skill.GetLevel();

			/*
			victim.SetProbability(120.0f);
			victim.SetTime(((2000 * skill_level + 10000)));
			victim.SetBuffid(0);
			v46 = (0.03f * skill_level) + 0.2f;
			v45 = player_var1;
			v44 = (skill_level + 5);
			if ( player.GetCultivation() == 1 )
			v43 = (v46 + v46) * v45 * v44;
			else
			victim.SetAmount((v46 * v45 * v44));
			victim.SetValue(0.0f);
			victim.SetHpleak(true);
			victim.SetProbability(120.0f);
			victim.SetTime(((2000 * skill_level + 10000)));
			victim.SetBuffid(0);
			v42 = (0.03f * skill_level) + 0.2f;
			v41 = player_var2;
			v40 = (skill_level + 5);
			if ( player.GetCultivation() == 1 )
			v39 = (v42 + v42) * v41 * v40;
			else
			victim.SetAmount((v42 * v41 * v40));
			victim.SetValue(0.0f);
			victim.SetMpleak(true);
			victim.SetProbability(600.0f);
			victim.SetTime(((2000 * skill_level + 10000)));
			v38 = skill_level;
			if ( player.GetCultivation() == 1 )
			v37 = 0.04f * v38;
			else
			victim.SetRatio((0.02f * v38));
			victim.SetBuffid(0);
			victim.SetSlow(true);
			victim.SetProbability(120.0f);
			victim.SetTime(900000.0f);
			victim.SetRatio(2036.0f);
			victim.SetAmount(219.0f);
			victim.SetValue(219.0f);
			victim.SetSetcooldown(true);
			*/
			return true;
		}
		public override int GetCreditCost(int level)
		{
			int[] array={24000,26000,28000,30000,32000,34000,36000,38000,40000,42000,45000,48000,51000,54000,57000,60000,64000,68000,72000,80000};return array[level-1];
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={1546};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={3};return array[index];
		}
	}
	public class GSkill2037 : GSkill
	{
		public GSkill2037()
			: base(2037)
		{
			
		}
	}
	public class GSkill2038Stub : GSkillStub
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
				int				player_occupation = player.GetOccupation();

				player.SetVar1((player_occupation == 10)?1:0);
				player.SetVar2((player_occupation == 11)?1:0);
				player.SetVar3((player_occupation == 12)?1:0);
				player.SetVar4((player_occupation == 22)?1:0);
				player.SetVar5((player_occupation == 23)?1:0);
				player.SetPerform(1);
			}
		}
		public GSkill2038Stub()
			: base(2038)
		{
			occupation = 149;
			maxlevel = 30;
			maxlearn = 20;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 2;
			timetype = 0;
			targettype = 0;
			rangetype = 2;
			doenchant = true;
			dobless = false;
			autoattack = false;
			allowform = 0;
			credittype = 10;
			clearmask = 130;
			skill_limit = 1;
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
			SetAction(0,"���_�ػ�");
			SetAction(1,"������_�ػ�");
			SetAction(2,"������_�ػ�");
			SetAction(3,"�ϻ���_�ػ�");
			SetAction(4,"������_�ػ�");
			SetAction(5,"���_�ػ�");
			SetAction(6,"����_�ػ�");
			SetAction(7,"����_�ػ�");
			SetAction(8,"����_�ػ�");
			SetAction(9,"��ԯ_�ػ�");
			SetAction(10,"����_�ػ�");
			SetAction(11,"̫�_�ػ�");
			SetAction(12,"�컪_�ػ�");
			SetAction(13,"����_�ػ�");
			SetAction(14,"Ӣ��_�ػ�");
			SetAction(15,"������ʦ_�ػ�");
			SetAction(16,"Ԫ�ش�ʦ_�ػ�");
			SetAction(17,"������_�ػ�");
			SetAction(18,"���_���_�ػ�");
			SetAction(19,"������_���_�ػ�");
			SetAction(20,"������_���_�ػ�");
			SetAction(21,"�ϻ���_���_�ػ�");
			SetAction(22,"������_���_�ػ�");
			SetAction(23,"���_���_�ػ�");
			SetAction(24,"����_���_�ػ�");
			SetAction(25,"����_���_�ػ�");
			SetAction(26,"����_���_�ػ�");
			SetAction(27,"��ԯ_���_�ػ�");
			SetAction(28,"����_���_�ػ�");
			SetAction(29,"̫�_���_�ػ�");
			SetAction(30,"�컪_���_�ػ�");
			name = "ħ֮�ػ�";
			nativename = "ħ֮�ػ�";
			icon = "ħ֮�ػ�.dds";
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
			return 900000;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={90,95,100,105,110,115,120,125,125,125,125,125,125,125,125,125,125,130,135,140};return array[level-1];
		}
		public override float GetRadius(GSkill skill)
		{
			return 20.000000f;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 20.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 15.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			return 1000.000000f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_maxhp = player.GetMaxhp();
			int				player_maxmp = player.GetMaxmp();
			int				player_var1 = player.GetVar1();
			int				skill_level = skill.GetLevel();

			/*
			victim.SetProbability(120.0f);
			victim.SetTime(((2000 * skill_level + 10000)));
			if ( player_var1 != 1
			&& (v6 = player, GNET::PlayerWrapper::GetVar2(v6) != 1)
			&& (v7 = player, GNET::PlayerWrapper::GetVar3(v7) != 1)
			&& (v8 = player, GNET::PlayerWrapper::GetVar4(v8) != 1)
			&& (v9 = player, GNET::PlayerWrapper::GetVar5(v9) != 1) )
			d = 0.0f;
			else
			victim.SetRatio(1.0f);
			victim.SetBuffid(0);
			victim.SetAmount(0.0f);
			v44 = (0.005f * skill_level) + 0.05f;
			v43 = player_maxhp;
			v42 = (skill_level + 5);
			if ( player.GetCultivation() == 2 )
			v41 = (v44 + v44) * v43 * v42;
			else
			victim.SetValue((v44 * v43 * v42));
			victim.SetHpgen(true);
			victim.SetProbability(120.0f);
			victim.SetTime(((2000 * skill_level + 10000)));
			victim.SetBuffid(0);
			victim.SetAmount(0.0f);
			v40 = (0.005f * skill_level) + 0.05f;
			v39 = player_maxmp;
			v38 = (skill_level + 5);
			if ( player.GetCultivation() == 2 )
			v37 = (v40 + v40) * v39 * v38;
			else
			victim.SetValue((v40 * v39 * v38));
			victim.SetMpgen(true);
			if ( player.GetCultivation() == 2 )
			v36 = 120.0f;
			else
			victim.SetProbability(0.0f);
			victim.SetTime(10000.0f);
			victim.SetBuffid(0);
			victim.SetValue(((100 * skill_level)));
			victim.SetAdddefence(true);
			*/
			return true;
		}
		public override int GetCreditCost(int level)
		{
			int[] array={12000,13000,14000,15000,16000,17000,18000,19000,20000,21000,22000,24000,25500,27500,28500,30000,32000,34000,36000,40000};return array[level-1];
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={1546};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={2};return array[index];
		}
	}
	public class GSkill2038 : GSkill
	{
		public GSkill2038()
			: base(2038)
		{
			
		}
	}
	public class GSkill2039Stub : GSkillStub
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
				int				player_minatk = player.GetMinatk();
				int				player_maxatk = player.GetMaxatk();

				player.SetVar1(player_maxatk);
				player.SetVar2(player_minatk);
				player.SetPerform(1);
			}
		}
		public GSkill2039Stub()
			: base(2039)
		{
			occupation = 150;
			maxlevel = 30;
			maxlearn = 20;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 3;
			timetype = 0;
			targettype = 0;
			rangetype = 0;
			doenchant = true;
			dobless = false;
			autoattack = false;
			allowform = 0;
			credittype = 11;
			clearmask = 132;
			skill_limit = 1;
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
			SetAction(0,"���_Թŭ");
			SetAction(1,"������_Թŭ");
			SetAction(2,"������_Թŭ");
			SetAction(3,"�ϻ���_Թŭ");
			SetAction(4,"������_Թŭ");
			SetAction(5,"���_Թŭ");
			SetAction(6,"����_Թŭ");
			SetAction(7,"����_Թŭ");
			SetAction(8,"����_Թŭ");
			SetAction(9,"��ԯ_Թŭ");
			SetAction(10,"����_Թŭ");
			SetAction(11,"̫�_Թŭ");
			SetAction(12,"�컪_Թŭ");
			SetAction(13,"����_Թŭ");
			SetAction(14,"Ӣ��_Թŭ");
			SetAction(15,"������ʦ_Թŭ");
			SetAction(16,"Ԫ�ش�ʦ_Թŭ");
			SetAction(17,"������_Թŭ");
			SetAction(18,"���_���_Թŭ");
			SetAction(19,"������_���_Թŭ");
			SetAction(20,"������_���_Թŭ");
			SetAction(21,"�ϻ���_���_Թŭ");
			SetAction(22,"������_���_Թŭ");
			SetAction(23,"���_���_Թŭ");
			SetAction(24,"����_���_Թŭ");
			SetAction(25,"����_���_Թŭ");
			SetAction(26,"����_���_Թŭ");
			SetAction(27,"��ԯ_���_Թŭ");
			SetAction(28,"����_���_Թŭ");
			SetAction(29,"̫�_���_Թŭ");
			SetAction(30,"�컪_���_Թŭ");
			name = "��֮Թŭ";
			nativename = "��֮Թŭ";
			icon = "��֮Թŭ.dds";
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
			int				skill_level = skill.GetLevel();

			return 600000 - 15000 * skill_level;
		}
		public override int GetEnmity(GSkill skill)
		{
			return 1;
		}
		public override int GetRequiredLevel(int level)
		{
			int[] array={100,105,110,115,120,125,125,125,125,125,125,125,125,125,125,125,125,130,135,140};return array[level-1];
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
		public override float GetMpcost(GSkill skill)
		{
			return 1000.000000f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_var1 = player.GetVar1();
			int				player_var2 = player.GetVar2();
			int				skill_level = skill.GetLevel();

			/*
			victim.SetProbability(120.0f);
			victim.SetTime(((2000 * skill_level + 10000)));
			victim.SetBuffid(0);
			v46 = (0.03f * skill_level) + 0.2f;
			v45 = player_var1;
			v44 = (skill_level + 5);
			if ( player.GetCultivation() == 2 )
			v43 = (v46 + v46) * v45 * v44;
			else
			victim.SetAmount((v46 * v45 * v44));
			victim.SetValue(0.0f);
			victim.SetHpleak(true);
			victim.SetProbability(120.0f);
			victim.SetTime(((2000 * skill_level + 10000)));
			victim.SetBuffid(0);
			v42 = (0.03f * skill_level) + 0.2f;
			v41 = player_var2;
			v40 = (skill_level + 5);
			if ( player.GetCultivation() == 2 )
			v39 = (v42 + v42) * v41 * v40;
			else
			victim.SetAmount((v42 * v41 * v40));
			victim.SetValue(0.0f);
			victim.SetMpleak(true);
			victim.SetProbability(600.0f);
			victim.SetTime(((2000 * skill_level + 10000)));
			v38 = skill_level;
			if ( player.GetCultivation() == 2 )
			v37 = 0.04f * v38;
			else
			victim.SetRatio((0.02f * v38));
			victim.SetBuffid(0);
			victim.SetSlow(true);
			victim.SetProbability(120.0f);
			victim.SetTime(900000.0f);
			victim.SetRatio(2038.0f);
			victim.SetAmount(219.0f);
			victim.SetValue(219.0f);
			victim.SetSetcooldown(true);
			*/
			return true;
		}
		public override int GetCreditCost(int level)
		{
			int[] array={24000,26000,28000,30000,32000,34000,36000,38000,40000,42000,45000,48000,51000,54000,57000,60000,64000,68000,72000,80000};return array[level-1];
		}
		public override int GetPreSkillID(int index)
		{
			int[] array={1572};return array[index];
		}
		public override int GetPreSkillSP(int index)
		{
			int[] array={3};return array[index];
		}
	}
	public class GSkill2039 : GSkill
	{
		public GSkill2039()
			: base(2039)
		{
			
		}
	}
}
