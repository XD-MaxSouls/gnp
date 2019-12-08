using System;
using System.Text;

namespace SKILL
{
	public class GSkill3900Stub : GSkillStub
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
		public GSkill3900Stub()
			: base(3900)
		{
			occupation = 128;
			maxlevel = 1;
			maxlearn = 0;
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
			skill_limit = 7;
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
			SetAction(0,"");
			SetAction(1,"");
			SetAction(2,"");
			SetAction(3,"");
			SetAction(4,"");
			SetAction(5,"");
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
			SetAction(18,"");
			SetAction(19,"");
			SetAction(20,"");
			SetAction(21,"");
			SetAction(22,"");
			SetAction(23,"");
			SetAction(24,"");
			SetAction(25,"");
			SetAction(26,"");
			SetAction(27,"");
			SetAction(28,"");
			SetAction(29,"");
			SetAction(30,"");
			name = "ÎåÄêÖ®Çì";
			nativename = "ÎåÄêÖ®Çì";
			icon = "ÁÆÉË.dds";
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
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetProbability(100.0f);
			victim.SetTime(14400000.0f);
			victim.SetRatio(0.0f);
			victim.SetBuffid(1);
			victim.SetAmount(0.0f);
			victim.SetValue(720000.0f);
			victim.SetHpgen(true);
			victim.SetProbability(100.0f);
			victim.SetTime(14400000.0f);
			victim.SetBuffid(1);
			victim.SetAmount(0.0f);
			victim.SetValue(1440000.0f);
			victim.SetMpgen(true);
			return true;
		}
	}
	public class GSkill3900 : GSkill
	{
		public GSkill3900()
			: base(3900)
		{
			
		}
	}
	public class GSkill3901Stub : GSkillStub
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
		public GSkill3901Stub()
			: base(3901)
		{
			occupation = 128;
			maxlevel = 1;
			maxlearn = 0;
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
			SetAction(0,"¼¼ÄÜ¹¥»÷3");
			SetAction(1,"¼¼ÄÜ¹¥»÷3");
			SetAction(2,"¼¼ÄÜ¹¥»÷3");
			SetAction(3,"¼¼ÄÜ¹¥»÷3");
			SetAction(4,"¼¼ÄÜ¹¥»÷3");
			SetAction(5,"¼¼ÄÜ¹¥»÷3");
			SetAction(6,"¼¼ÄÜ¹¥»÷3");
			SetAction(7,"¼¼ÄÜ¹¥»÷3");
			SetAction(8,"¼¼ÄÜ¹¥»÷3");
			SetAction(9,"¼¼ÄÜ¹¥»÷3");
			SetAction(10,"¼¼ÄÜ¹¥»÷3");
			SetAction(11,"¼¼ÄÜ¹¥»÷3");
			SetAction(12,"¼¼ÄÜ¹¥»÷3");
			SetAction(13,"¼¼ÄÜ¹¥»÷3");
			SetAction(14,"¼¼ÄÜ¹¥»÷3");
			SetAction(15,"¼¼ÄÜ¹¥»÷3");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"¼¼ÄÜ¹¥»÷3");
			SetAction(19,"¼¼ÄÜ¹¥»÷3");
			SetAction(20,"¼¼ÄÜ¹¥»÷3");
			SetAction(21,"¼¼ÄÜ¹¥»÷3");
			SetAction(22,"¼¼ÄÜ¹¥»÷3");
			SetAction(23,"¼¼ÄÜ¹¥»÷3");
			SetAction(24,"¼¼ÄÜ¹¥»÷3");
			SetAction(25,"¼¼ÄÜ¹¥»÷3");
			SetAction(26,"¼¼ÄÜ¹¥»÷3");
			SetAction(27,"¼¼ÄÜ¹¥»÷3");
			SetAction(28,"¼¼ÄÜ¹¥»÷3");
			SetAction(29,"¼¼ÄÜ¹¥»÷3");
			SetAction(30,"¼¼ÄÜ¹¥»÷3");
			name = "´òµ¹¹ÖÊåÊå";
			nativename = "´òµ¹¹ÖÊåÊå";
			icon = "²¶¿ì.dds";
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
			return 4000;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 15.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 10.000000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 30.000000f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();

			/*
			if ( player.GetTmplid() != 52260
			|| (v3 = player, GNET::PlayerWrapper::GetRes1(v3) > 1999) )
			d = 0.0f;
			else
			victim.SetProbability(120.0f);
			victim.SetValue(5000.0f);
			victim.SetDirecthurt(true);
			*/
			return true;
		}
	}
	public class GSkill3901 : GSkill
	{
		public GSkill3901()
			: base(3901)
		{
			
		}
	}
	public class GSkill3902Stub : GSkillStub
	{
		public class GState1 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 100;
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
				return 100;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();

				player.SetPerform(1);
			}
		}
		public GSkill3902Stub()
			: base(3902)
		{
			occupation = 128;
			maxlevel = 1;
			maxlearn = 0;
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
			SetAction(0,"");
			SetAction(1,"");
			SetAction(2,"");
			SetAction(3,"");
			SetAction(4,"");
			SetAction(5,"");
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
			SetAction(18,"");
			SetAction(19,"");
			SetAction(20,"");
			SetAction(21,"");
			SetAction(22,"");
			SetAction(23,"");
			SetAction(24,"");
			SetAction(25,"");
			SetAction(26,"");
			SetAction(27,"");
			SetAction(28,"");
			SetAction(29,"");
			SetAction(30,"");
			name = "Ë®Çò´óÕ½_Íæ¼ÒµÄË®Çò";
			nativename = "Ë®Çò´óÕ½_Íæ¼ÒµÄË®Çò";
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
			return 200;
		}
		public override float GetRadius(GSkill skill)
		{
			return 5.000000f;
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

			/*
			if ( (player.GetTmplid() <= 52201
			|| (v3 = player, GNET::PlayerWrapper::GetTmplid(v3) > 52205))
			&& (v4 = player, GNET::PlayerWrapper::GetTmplid(v4) != 52340) )
			d = 0.0f;
			else
			victim.SetProbability(120.0f);
			victim.SetValue(10000.0f);
			victim.SetDirecthurt(true);
			*/
			return true;
		}
	}
	public class GSkill3902 : GSkill
	{
		public GSkill3902()
			: base(3902)
		{
			
		}
	}
	public class GSkill3903Stub : GSkillStub
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

				player.SetPerform(1);
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

				player.SetPerform(0);
			}
		}
		public class GState4 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 1000;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_hp = player.GetHp();

				player.SetHp(((player_hp - 1000000)));
				player.SetPerform(0);
			}
		}
		public class GState5 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 1000;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();

				player.SetPerform(0);
			}
		}
		public GSkill3903Stub()
			: base(3903)
		{
			occupation = 129;
			maxlevel = 1;
			maxlearn = 0;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 1;
			timetype = 0;
			targettype = 0;
			rangetype = 6;
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
			SetAction(0,"ÇàÔÆÃÅ_ËªÌìÑ©Îè");
			SetAction(1,"ÇàÔÆÃÅ_ËªÌìÑ©Îè");
			SetAction(2,"ÇàÔÆÃÅ_ËªÌìÑ©Îè");
			SetAction(3,"ÇàÔÆÃÅ_ËªÌìÑ©Îè");
			SetAction(4,"ÇàÔÆÃÅ_ËªÌìÑ©Îè");
			SetAction(5,"ÇàÔÆÃÅ_ËªÌìÑ©Îè");
			SetAction(6,"ÇàÔÆÃÅ_ËªÌìÑ©Îè");
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
			name = "»ğÓêÊõ";
			nativename = "»ğÓêÊõ";
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
			AddState(new GState3());
			AddState(new GState4());
			AddState(new GState5());
		}
		public override int GetExecutetime(GSkill skill)
		{
			return 5000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			return 200;
		}
		public override float GetRadius(GSkill skill)
		{
			return 16.000000f;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 16.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 13.000000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 21.000000f;
		}
		public override int GetCoverage(GSkill skill)
		{
			return 6;
		}
	}
	public class GSkill3903 : GSkill
	{
		public GSkill3903()
			: base(3903)
		{
			
		}
	}
	public class GSkill3904Stub : GSkillStub
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
		public GSkill3904Stub()
			: base(3904)
		{
			occupation = 151;
			maxlevel = 1;
			maxlearn = 0;
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
			SetAction(0,"¹íÍõ×Ú_»Ø´º");
			SetAction(1,"ÇàÔÆÃÅ_»Ø´º");
			SetAction(2,"¹íÍõ×Ú_»Ø´º");
			SetAction(3,"ºÏ»¶ÅÉ_»Ø´º");
			SetAction(4,"ÌìÒôËÂ_»Ø´º");
			SetAction(5,"¹íµÀ_»Ø´º");
			SetAction(6,"·ÙÏã¹È_»Ø´º");
			SetAction(7,"ÊŞÉñ_»Ø´º");
			SetAction(8,"ºüÑı_»Ø´º");
			SetAction(9,"ĞùÔ¯_»Ø´º");
			SetAction(10,"»³¹â_»Ø´º");
			SetAction(11,"Ì«ê»_»Ø´º");
			SetAction(12,"Ìì»ª_»Ø´º");
			SetAction(13,"ÁéÙí_»Ø´º");
			SetAction(14,"Ó¢ÕĞ_»Ø´º");
			SetAction(15,"ÔªËØ´óÊ¦_»Ø´º");
			SetAction(16,"ÔªËØ´óÊ¦_»Ø´º");
			SetAction(17,"¹éÔÆ_ÉèÖÃÆøÑª");
			SetAction(18,"¹íÍõ×Ú_Æï³Ë_»Ø´º");
			SetAction(19,"ÇàÔÆÃÅ_Æï³Ë_»Ø´º");
			SetAction(20,"¹íÍõ×Ú_Æï³Ë_»Ø´º");
			SetAction(21,"ºÏ»¶ÅÉ_Æï³Ë_»Ø´º");
			SetAction(22,"ÌìÒôËÂ_Æï³Ë_»Ø´º");
			SetAction(23,"¹íµÀ_Æï³Ë_»Ø´º");
			SetAction(24,"·ÙÏã¹È_Æï³Ë_»Ø´º");
			SetAction(25,"ÊŞÉñ_Æï³Ë_»Ø´º");
			SetAction(26,"ºüÑı_Æï³Ë_»Ø´º");
			SetAction(27,"ĞùÔ¯_Æï³Ë_»Ø´º");
			SetAction(28,"»³¹â_Æï³Ë_»Ø´º");
			SetAction(29,"Ì«ê»_Æï³Ë_»Ø´º");
			SetAction(30,"Ìì»ª_Æï³Ë_»Ø´º");
			name = "ĞÇÓï¡¤Ñªµä";
			nativename = "ĞÇÓï¡¤Ñªµä";
			icon = "ÉñÍ¨_Ñªµä.dds";
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
			return 300000;
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
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_maxhp = player.GetMaxhp();
			int				player_maxmp = player.GetMaxmp();

			victim.SetProbability(100.0f);
			victim.SetTime(10000.0f);
			victim.SetRatio(0.0f);
			victim.SetBuffid(2);
			victim.SetAmount(0.0f);
			victim.SetValue((player_maxhp * 0.5f));
			victim.SetHpgen(true);
			victim.SetProbability(100.0f);
			victim.SetTime(10000.0f);
			victim.SetBuffid(2);
			victim.SetAmount(0.0f);
			victim.SetValue((player_maxmp * 0.5f));
			victim.SetMpgen(true);
			victim.SetProbability(100.0f);
			victim.SetTime(10000.0f);
			victim.SetBuffid(2);
			victim.SetAmount((player.GetMaxdp() * 0.5f));
			victim.SetValue(0.0f);
			victim.SetDivinityfury(true);
			return true;
		}
	}
	public class GSkill3904 : GSkill
	{
		public GSkill3904()
			: base(3904)
		{
			
		}
	}
	public class GSkill3905Stub : GSkillStub
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
		public GSkill3905Stub()
			: base(3905)
		{
			occupation = 151;
			maxlevel = 1;
			maxlearn = 0;
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
			SetAction(0,"¹íÍõ×Ú_¾£¼¬");
			SetAction(1,"ÇàÔÆÃÅ_¾£¼¬");
			SetAction(2,"¹íÍõ×Ú_¾£¼¬");
			SetAction(3,"ºÏ»¶ÅÉ_¾£¼¬");
			SetAction(4,"ÌìÒôËÂ_¾£¼¬");
			SetAction(5,"¹íµÀ_¾£¼¬");
			SetAction(6,"·ÙÏã_¾£¼¬");
			SetAction(7,"ÊŞÉñ_¾£¼¬");
			SetAction(8,"ºüÑı_¾£¼¬");
			SetAction(9,"ĞùÔ¯_¾£¼¬");
			SetAction(10,"»³¹â_¾£¼¬");
			SetAction(11,"Ì«ê»_¾£¼¬");
			SetAction(12,"Ìì»ª_¾£¼¬");
			SetAction(13,"ÁéÙí_¾£¼¬");
			SetAction(14,"Ó¢ÕĞ_¾£¼¬");
			SetAction(15,"ÔªËØ´óÊ¦_¾£¼¬");
			SetAction(16,"ÔªËØ´óÊ¦_¾£¼¬");
			SetAction(17,"ÌìÒôËÂ_¾£¼¬");
			SetAction(18,"¹íÍõ×Ú_Æï³Ë_¾£¼¬");
			SetAction(19,"ÇàÔÆÃÅ_Æï³Ë_¾£¼¬");
			SetAction(20,"¹íÍõ×Ú_Æï³Ë_¾£¼¬");
			SetAction(21,"ºÏ»¶ÅÉ_Æï³Ë_¾£¼¬");
			SetAction(22,"ÌìÒôËÂ_Æï³Ë_¾£¼¬");
			SetAction(23,"¹íµÀ_Æï³Ë_¾£¼¬");
			SetAction(24,"·ÙÏã¹È_Æï³Ë_¾£¼¬");
			SetAction(25,"ÊŞÉñ_Æï³Ë_¾£¼¬");
			SetAction(26,"ºüÑı_Æï³Ë_¾£¼¬");
			SetAction(27,"ĞùÔ¯_Æï³Ë_¾£¼¬");
			SetAction(28,"»³¹â_Æï³Ë_¾£¼¬");
			SetAction(29,"Ì«ê»_Æï³Ë_¾£¼¬");
			SetAction(30,"Ìì»ª_Æï³Ë_¾£¼¬");
			name = "ĞÇÓï¡¤ÌìÄ¿";
			nativename = "ĞÇÓï¡¤ÌìÄ¿";
			icon = "ÉñÍ¨_ÌìÄ¿.dds";
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
			return 360000;
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

			victim.SetTime(12000.0f);
			victim.SetRatio(0.039999999f);
			victim.SetInccritrate(true);
			victim.SetProbability(120.0f);
			victim.SetTime(12000.0f);
			victim.SetRatio(0.30000001f);
			victim.SetNingjin(true);
			return true;
		}
	}
	public class GSkill3905 : GSkill
	{
		public GSkill3905()
			: base(3905)
		{
			
		}
	}
	public class GSkill3906Stub : GSkillStub
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
		public GSkill3906Stub()
			: base(3906)
		{
			occupation = 151;
			maxlevel = 1;
			maxlearn = 0;
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
			SetAction(0,"¹íÍõ×Ú_¼á¶Ü");
			SetAction(1,"ÇàÔÆÃÅ_¼á¶Ü");
			SetAction(2,"¹íÍõ×Ú_¼á¶Ü");
			SetAction(3,"ºÏ»¶ÅÉ_¼á¶Ü");
			SetAction(4,"ÌìÒôËÂ_¼á¶Ü");
			SetAction(5,"¹íµÀ_¼á¶Ü");
			SetAction(6,"·ÙÏã¹È_¼á¶Ü");
			SetAction(7,"ÊŞÉñ_¼á¶Ü");
			SetAction(8,"ºüÑı_¼á¶Ü");
			SetAction(9,"ĞùÔ¯_¼á¶Ü");
			SetAction(10,"»³¹â_¼á¶Ü");
			SetAction(11,"Ì«ê»_¼á¶Ü");
			SetAction(12,"Ìì»ª_¼á¶Ü");
			SetAction(13,"ÁéÙí_¼á¶Ü");
			SetAction(14,"Ó¢ÕĞ_¼á¶Ü");
			SetAction(15,"ÔªËØ´óÊ¦_¼á¶Ü");
			SetAction(16,"ÔªËØ´óÊ¦_¼á¶Ü");
			SetAction(17,"ÌìÒôËÂ_¼á¶Ü");
			SetAction(18,"¹íÍõ×Ú_Æï³Ë_¼á¶Ü");
			SetAction(19,"ÇàÔÆÃÅ_Æï³Ë_¼á¶Ü");
			SetAction(20,"¹íÍõ×Ú_Æï³Ë_¼á¶Ü");
			SetAction(21,"ºÏ»¶ÅÉ_Æï³Ë_¼á¶Ü");
			SetAction(22,"ÌìÒôËÂ_Æï³Ë_¼á¶Ü");
			SetAction(23,"¹íµÀ_Æï³Ë_¼á¶Ü");
			SetAction(24,"·ÙÏã¹È_Æï³Ë_¼á¶Ü");
			SetAction(25,"ÊŞÉñ_Æï³Ë_¼á¶Ü");
			SetAction(26,"ºüÑı_Æï³Ë_¼á¶Ü");
			SetAction(27,"ĞùÔ¯_Æï³Ë_¼á¶Ü");
			SetAction(28,"»³¹â_Æï³Ë_¼á¶Ü");
			SetAction(29,"Ì«ê»_Æï³Ë_¼á¶Ü");
			SetAction(30,"Ìì»ª_Æï³Ë_¼á¶Ü");
			name = "ĞÇÓï¡¤°ÎÉ½";
			nativename = "ĞÇÓï¡¤°ÎÉ½";
			icon = "ÉñÍ¨_°ÎÉ½.dds";
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
			return 360000;
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
			victim.SetTime(12000.0f);
			victim.SetRatio(0.2f);
			victim.SetBuffid(1);
			victim.SetIncattack(true);
			victim.SetProbability(120.0f);
			victim.SetTime(12000.0f);
			victim.SetRatio(0.2f);
			victim.SetBuffid(1);
			victim.SetIncdefence(true);
			victim.SetTime(12000.0f);
			victim.SetRatio(0.1f);
			victim.SetBuffid(1);
			victim.SetInchp(true);
			victim.SetTime(12000.0f);
			victim.SetRatio(0.1f);
			victim.SetBuffid(1);
			victim.SetIncmp(true);
			return true;
		}
	}
	public class GSkill3906 : GSkill
	{
		public GSkill3906()
			: base(3906)
		{
			
		}
	}
	public class GSkill3907Stub : GSkillStub
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
		public GSkill3907Stub()
			: base(3907)
		{
			occupation = 151;
			maxlevel = 1;
			maxlearn = 0;
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
			SetAction(0,"¹íÍõ×Ú_È¼ÉÕ");
			SetAction(1,"ÇàÔÆÃÅ_È¼ÉÕ");
			SetAction(2,"¹íÍõ×Ú_È¼ÉÕ");
			SetAction(3,"ºÏ»¶ÅÉ_È¼ÉÕ");
			SetAction(4,"ÌìÒôËÂ_È¼ÉÕ");
			SetAction(5,"¹íµÀ_È¼ÉÕ");
			SetAction(6,"·ÙÏã¹È_È¼ÉÕ");
			SetAction(7,"ÊŞÉñ_È¼ÉÕ");
			SetAction(8,"ºüÑı_È¼ÉÕ");
			SetAction(9,"ĞùÔ¯_È¼ÉÕ");
			SetAction(10,"»³¹â_È¼ÉÕ");
			SetAction(11,"Ì«ê»_È¼ÉÕ");
			SetAction(12,"Ìì»ª_È¼ÉÕ");
			SetAction(13,"ÁéÙí_È¼ÉÕ");
			SetAction(14,"Ó¢ÕĞ_È¼ÉÕ");
			SetAction(15,"ÔªËØ´óÊ¦_È¼ÉÕ");
			SetAction(16,"ÔªËØ´óÊ¦_È¼ÉÕ");
			SetAction(17,"ÌìÒôËÂ_È¼ÉÕ");
			SetAction(18,"¹íÍõ×Ú_Æï³Ë_È¼ÉÕ");
			SetAction(19,"ÇàÔÆÃÅ_Æï³Ë_È¼ÉÕ");
			SetAction(20,"¹íÍõ×Ú_Æï³Ë_È¼ÉÕ");
			SetAction(21,"ºÏ»¶ÅÉ_Æï³Ë_È¼ÉÕ");
			SetAction(22,"ÌìÒôËÂ_Æï³Ë_È¼ÉÕ");
			SetAction(23,"¹íµÀ_Æï³Ë_È¼ÉÕ");
			SetAction(24,"·ÙÏã¹È_Æï³Ë_È¼ÉÕ");
			SetAction(25,"ÊŞÉñ_Æï³Ë_È¼ÉÕ");
			SetAction(26,"ºüÑı_Æï³Ë_È¼ÉÕ");
			SetAction(27,"ĞùÔ¯_Æï³Ë_È¼ÉÕ");
			SetAction(28,"»³¹â_Æï³Ë_È¼ÉÕ");
			SetAction(29,"Ì«ê»_Æï³Ë_È¼ÉÕ");
			SetAction(30,"Ìì»ª_Æï³Ë_È¼ÉÕ");
			name = "ĞÇÓï¡¤ÕòÁé";
			nativename = "ĞÇÓï¡¤ÕòÁé";
			icon = "ÉñÍ¨_ÕòÁé.dds";
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
			return 360000;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 15.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 10.000000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 20.000000f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetProbability(120.0f);
			victim.SetTime(15000.0f);
			victim.SetRatio(0.30000001f);
			victim.SetBuffid(1);
			victim.SetWeak(true);
			victim.SetProbability(120.0f);
			victim.SetTime(15000.0f);
			victim.SetRatio(0.40000001f);
			victim.SetBuffid(1);
			victim.SetSlow(true);
			return true;
		}
	}
	public class GSkill3907 : GSkill
	{
		public GSkill3907()
			: base(3907)
		{
			
		}
	}
	public class GSkill3908Stub : GSkillStub
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
		public GSkill3908Stub()
			: base(3908)
		{
			occupation = 151;
			maxlevel = 1;
			maxlearn = 0;
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
			SetAction(0,"¹íÍõ×Ú_¿ñ·çÖä");
			SetAction(1,"ÇàÔÆÃÅ_åĞÒ£ÓÎ");
			SetAction(2,"¹íÍõ×Ú_¿ñ·çÖä");
			SetAction(3,"ºÏ»¶ÅÉ_¸¡¹â");
			SetAction(4,"ÌìÒôËÂ_Ò×½î¾­");
			SetAction(5,"¹íµÀ_°Ù¹íÒ¹ĞĞ");
			SetAction(6,"ÇàÔÆÃÅ_åĞÒ£ÓÎ");
			SetAction(7,"ÊŞÉñ_ºáĞĞ");
			SetAction(8,"ºüÑı_·çĞĞÕß");
			SetAction(9,"ĞùÔ¯_¼ÓËÙ");
			SetAction(10,"»³¹â_¼ÓËÙ");
			SetAction(11,"Ì«ê»_¼ÓËÙ");
			SetAction(12,"Ìì»ª_±¼À×");
			SetAction(13,"ÁéÙí_¼ÓËÙ");
			SetAction(14,"Ó¢ÕĞ_¼ÓËÙ");
			SetAction(15,"0");
			SetAction(16,"ÔªËØ´óÊ¦_ËÙ¶È¼³È¡");
			SetAction(17,"¹éÔÆ_ÉèÖÃÆøÑª");
			SetAction(18,"¹íÍõ×Ú_Æï³Ë_¿ñ·çÖä");
			SetAction(19,"ÇàÔÆÃÅ_Æï³Ë_åĞÒ£ÓÎ");
			SetAction(20,"¹íÍõ×Ú_Æï³Ë_¿ñ·çÖä");
			SetAction(21,"ºÏ»¶ÅÉ_Æï³Ë_¸¡¹â");
			SetAction(22,"ÌìÒôËÂ_Æï³Ë_Ò×½î¾­");
			SetAction(23,"¹íµÀ_Æï³Ë_°Ù¹íÒ¹ĞĞ");
			SetAction(24,"ÇàÔÆÃÅ_Æï³Ë_åĞÒ£ÓÎ");
			SetAction(25,"ÊŞÉñ_Æï³Ë_ºáĞĞ");
			SetAction(26,"ºüÑı_Æï³Ë_·çĞĞÕß");
			SetAction(27,"ĞùÔ¯_Æï³Ë_¼ÓËÙ");
			SetAction(28,"»³¹â_Æï³Ë_¼ÓËÙ");
			SetAction(29,"Ì«ê»_Æï³Ë_¼ÓËÙ");
			SetAction(30,"Ìì»ª_Æï³Ë_±¼À×");
			name = "ĞÇÓï¡¤ÌÚÔÆ";
			nativename = "ĞÇÓï¡¤ÌÚÔÆ";
			icon = "ÉñÍ¨_ÌÚÔÆ.dds";
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
			return 300000;
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
			victim.SetTime(10000.0f);
			victim.SetBuffid(1);
			victim.SetValue(5.0f);
			victim.SetAddspeed(true);
			victim.SetProbability(120.0f);
			victim.SetTime(10000.0f);
			victim.SetBuffid(1);
			victim.SetValue(4.0f);
			victim.SetIncmountspeed(true);
			victim.SetProbability(120.0f);
			victim.SetClearslow(true);
			return true;
		}
	}
	public class GSkill3908 : GSkill
	{
		public GSkill3908()
			: base(3908)
		{
			
		}
	}
	public class GSkill3909Stub : GSkillStub
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
		public GSkill3909Stub()
			: base(3909)
		{
			occupation = 151;
			maxlevel = 1;
			maxlearn = 0;
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
			SetAction(0,"¹íÍõ×Ú_É¢¾¡");
			SetAction(1,"ÇàÔÆÃÅ_É¢¾¡");
			SetAction(2,"¹íÍõ×Ú_É¢¾¡");
			SetAction(3,"ºÏ»¶ÅÉ_É¢¾¡");
			SetAction(4,"ÌìÒôËÂ_É¢¾¡");
			SetAction(5,"¹íµÀ_É¢¾¡");
			SetAction(6,"·ÙÏã¹È_É¢¾¡");
			SetAction(7,"ÊŞÉñ_É¢¾¡");
			SetAction(8,"ºüÑı_É¢¾¡");
			SetAction(9,"ĞùÔ¯_É¢¾¡");
			SetAction(10,"»³¹â_É¢¾¡");
			SetAction(11,"Ì«ê»_É¢¾¡");
			SetAction(12,"Ìì»ª_É¢¾¡");
			SetAction(13,"ÁéÙí_É¢¾¡");
			SetAction(14,"Ó¢ÕĞ_É¢¾¡");
			SetAction(15,"ÔªËØ´óÊ¦_É¢¾¡");
			SetAction(16,"ÔªËØ´óÊ¦_É¢¾¡");
			SetAction(17,"¹éÔÆ_ÉèÖÃÆøÑª");
			SetAction(18,"¹íÍõ×Ú_Æï³Ë_É¢¾¡");
			SetAction(19,"ÇàÔÆÃÅ_Æï³Ë_É¢¾¡");
			SetAction(20,"¹íÍõ×Ú_Æï³Ë_É¢¾¡");
			SetAction(21,"ºÏ»¶ÅÉ_Æï³Ë_É¢¾¡");
			SetAction(22,"ÌìÒôËÂ_Æï³Ë_É¢¾¡");
			SetAction(23,"¹íµÀ_Æï³Ë_É¢¾¡");
			SetAction(24,"·ÙÏã¹È_Æï³Ë_É¢¾¡");
			SetAction(25,"ÊŞÉñ_Æï³Ë_É¢¾¡");
			SetAction(26,"ºüÑı_Æï³Ë_É¢¾¡");
			SetAction(27,"ĞùÔ¯_Æï³Ë_É¢¾¡");
			SetAction(28,"»³¹â_Æï³Ë_É¢¾¡");
			SetAction(29,"Ì«ê»_Æï³Ë_É¢¾¡");
			SetAction(30,"Ìì»ª_Æï³Ë_É¢¾¡");
			name = "ĞÇÓï¡¤ÉíÍâ»¯Éí";
			nativename = "ĞÇÓï¡¤ÉíÍâ»¯Éí";
			icon = "ÉñÍ¨_ÉíÍâ»¯Éí.dds";
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
			return 240000;
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
			victim.SetAmount(20.0f);
			victim.SetCleardebuff(true);
			return true;
		}
	}
	public class GSkill3909 : GSkill
	{
		public GSkill3909()
			: base(3909)
		{
			
		}
	}
}
