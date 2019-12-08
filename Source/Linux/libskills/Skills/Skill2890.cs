using System;
using System.Text;

namespace SKILL
{
	public class GSkill2890Stub : GSkillStub
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
		public GSkill2890Stub()
			: base(2890)
		{
			occupation = 129;
			maxlevel = 10;
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
			SetAction(0,"¹íÍõ×Ú_ÃÍ»÷");
			SetAction(1,"ÇàÔÆÃÅ_ÃÍ»÷");
			SetAction(2,"¹íÍõ×Ú_ÃÍ»÷");
			SetAction(3,"ºÏ»¶ÅÉ_ÃÍ»÷");
			SetAction(4,"ÌìÒôËÂ_ÃÍ»÷");
			SetAction(5,"¹íµÀ_ÃÍ»÷");
			SetAction(6,"0");
			SetAction(7,"ÊÞÉñ_ÃÍ»÷");
			SetAction(8,"ºüÑý_ÃÍ»÷");
			SetAction(9,"0");
			SetAction(10,"»³¹â_Ç³Ï®");
			SetAction(11,"0");
			SetAction(12,"Ìì»ª_³õÔªÒôÈÐ");
			SetAction(13,"");
			SetAction(14,"");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"¹íÍõ×Ú_Æï³Ë_ÃÍ»÷");
			SetAction(19,"ÇàÔÆÃÅ_Æï³Ë_ÃÍ»÷");
			SetAction(20,"¹íÍõ×Ú_Æï³Ë_ÃÍ»÷");
			SetAction(21,"ºÏ»¶ÅÉ_Æï³Ë_ÃÍ»÷");
			SetAction(22,"ÌìÒôËÂ_Æï³Ë_ÃÍ»÷");
			SetAction(23,"¹íµÀ_Æï³Ë_ÃÍ»÷");
			SetAction(24,"0");
			SetAction(25,"ÊÞÉñ_Æï³Ë_ÃÍ»÷");
			SetAction(26,"ºüÑý_Æï³Ë_ÃÍ»÷");
			SetAction(27,"0");
			SetAction(28,"»³¹â_Æï³Ë_Ç³Ï®");
			SetAction(29,"0");
			SetAction(30,"Ìì»ª_Æï³Ë_³õÔªÒôÈÐ");
			name = "êØ»Ê¾üÁî";
			nativename = "êØ»Ê¾üÁî";
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
			return 1000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			return 600000;
		}
		public override float GetPraydistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return player_range + 8.0f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return player_range + 7.0f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return player_range + 9.0f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetProbability(100.0f);
			victim.SetAmount(1.0f);
			victim.SetClearbuff(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetTime(60000.0f);
			victim.SetRatio(0.050000001f);
			victim.SetInccritrate(true);
			return true;
		}
	}
	public class GSkill2890 : GSkill
	{
		public GSkill2890()
			: base(2890)
		{
			
		}
	}
	public class GSkill2891Stub : GSkillStub
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
		public GSkill2891Stub()
			: base(2891)
		{
			occupation = 129;
			maxlevel = 1;
			maxlearn = 1;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 5;
			timetype = 0;
			targettype = 0;
			rangetype = 2;
			doenchant = true;
			dobless = true;
			autoattack = false;
			allowform = 0;
			credittype = 0;
			clearmask = 0;
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
			SetAction(0,"¹íÍõ×Ú_¿ÝÄ¾Öä");
			SetAction(1,"ÇàÔÆÃÅ_Á¶Æø»¹Éñ");
			SetAction(2,"¹íÍõ×Ú_¿ÝÄ¾Öä");
			SetAction(3,"ºÏ»¶ÅÉ_¼¤Àø");
			SetAction(4,"ÌìÒôËÂ_Ò×½î¾­");
			SetAction(5,"ÄýÉñÑªÖä");
			SetAction(6,"0");
			SetAction(7,"ÊÞÉñ_ºáÐÐ");
			SetAction(8,"ºüÑý_¹ÌÔªÊõ");
			SetAction(9,"0");
			SetAction(10,"»³¹â_ÍµÏ®");
			SetAction(11,"0");
			SetAction(12,"Ìì»ª_´ºÀ×");
			SetAction(13,"");
			SetAction(14,"");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"¹íÍõ×Ú_Æï³Ë_¿ÝÄ¾Öä");
			SetAction(19,"ÇàÔÆÃÅ_Æï³Ë_Á¶Æø»¹Éñ");
			SetAction(20,"¹íÍõ×Ú_Æï³Ë_¿ÝÄ¾Öä");
			SetAction(21,"ºÏ»¶ÅÉ_Æï³Ë_¼¤Àø");
			SetAction(22,"ÌìÒôËÂ_Æï³Ë_Ò×½î¾­");
			SetAction(23,"ÄýÉñÑªÖä");
			SetAction(24,"0");
			SetAction(25,"ÊÞÉñ_Æï³Ë_ºáÐÐ");
			SetAction(26,"ºüÑý_Æï³Ë_¹ÌÔªÊõ");
			SetAction(27,"0");
			SetAction(28,"»³¹â_Æï³Ë_ÍµÏ®");
			SetAction(29,"0");
			SetAction(30,"Ìì»ª_Æï³Ë_´ºÀ×");
			name = "Óù¼ÝÇ×Õ÷¡¤ÁØ";
			nativename = "Óù¼ÝÇ×Õ÷¡¤ÁØ";
			icon = "Óù¼ÝÇ×Õ÷¡¤ÁØ.dds";
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
			return 480000;
		}
		public override float GetRadius(GSkill skill)
		{
			return 35.000000f;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 32.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 30.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			return 3000.000000f;
		}
		public override int GetCoverage(GSkill skill)
		{
			return 40;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_maxhp = player.GetMaxhp();

			/*
			if ( player.GetObjectType() )
			d = 0.0f;
			else
			victim.SetProbability(100.0f);
			victim.SetTime(500.0f);
			victim.SetRatio(0.0f);
			victim.SetBuffid(4);
			victim.SetAmount(1.0f);
			victim.SetValue((player_maxhp * 0.8f));
			victim.SetHpgen(true);
			if ( player.GetObjectType() )
			v23 = 0.0f;
			else
			victim.SetProbability(100.0f);
			victim.SetTime(30000.0f);
			victim.SetRatio(0.0f);
			victim.SetBuffid(5);
			victim.SetAmount(1.0f);
			victim.SetValue(((15 * player_maxhp) * 0.1f));
			victim.SetHpgen(true);
			*/
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_maxhp = player.GetMaxhp();

			victim.SetProbability(100.0f);
			victim.SetTime(500.0f);
			victim.SetRatio(0.0f);
			victim.SetBuffid(4);
			victim.SetAmount(1.0f);
			victim.SetValue((player_maxhp * 0.8f));
			victim.SetHpgen(true);
			victim.SetProbability(100.0f);
			victim.SetTime(30000.0f);
			victim.SetRatio(0.0f);
			victim.SetBuffid(5);
			victim.SetAmount(1.0f);
			victim.SetValue(((15 * player_maxhp) * 0.1f));
			victim.SetHpgen(true);
			return true;
		}
	}
	public class GSkill2891 : GSkill
	{
		public GSkill2891()
			: base(2891)
		{
			
		}
	}
	public class GSkill2892Stub : GSkillStub
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
		public GSkill2892Stub()
			: base(2892)
		{
			occupation = 129;
			maxlevel = 1;
			maxlearn = 1;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 5;
			timetype = 0;
			targettype = 0;
			rangetype = 2;
			doenchant = true;
			dobless = true;
			autoattack = false;
			allowform = 0;
			credittype = 0;
			clearmask = 0;
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
			SetAction(0,"¹íÍõ×Ú_¼á¶Ü");
			SetAction(1,"ÇàÔÆÃÅ_¼á¶Ü");
			SetAction(2,"¹íÍõ×Ú_¼á¶Ü");
			SetAction(3,"ºÏ»¶ÅÉ_¼á¶Ü");
			SetAction(4,"ÌìÒôËÂ_¼á¶Ü");
			SetAction(5,"¹íµÀ_¼á¶Ü");
			SetAction(6,"0");
			SetAction(7,"ÊÞÉñ_¼á¶Ü");
			SetAction(8,"ºüÑý_¼á¶Ü");
			SetAction(9,"0");
			SetAction(10,"»³¹â_ÍµÏ®");
			SetAction(11,"0");
			SetAction(12,"Ìì»ª_´ºÀ×");
			SetAction(13,"");
			SetAction(14,"");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"¹íÍõ×Ú_Æï³Ë_¼á¶Ü");
			SetAction(19,"ÇàÔÆÃÅ_Æï³Ë_¼á¶Ü");
			SetAction(20,"¹íÍõ×Ú_Æï³Ë_¼á¶Ü");
			SetAction(21,"ºÏ»¶ÅÉ_Æï³Ë_¼á¶Ü");
			SetAction(22,"ÌìÒôËÂ_Æï³Ë_¼á¶Ü");
			SetAction(23,"¹íµÀ_Æï³Ë_¼á¶Ü");
			SetAction(24,"0");
			SetAction(25,"ÊÞÉñ_Æï³Ë_¼á¶Ü");
			SetAction(26,"ºüÑý_Æï³Ë_¼á¶Ü");
			SetAction(27,"0");
			SetAction(28,"»³¹â_Æï³Ë_ÍµÏ®");
			SetAction(29,"0");
			SetAction(30,"Ìì»ª_Æï³Ë_´ºÀ×");
			name = "Óù¼ÝÇ×Õ÷¡¤·ç";
			nativename = "Óù¼ÝÇ×Õ÷¡¤·ç";
			icon = "Óù¼ÝÇ×Õ÷¡¤·ç.dds";
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
			return 480000;
		}
		public override float GetRadius(GSkill skill)
		{
			return 35.000000f;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 32.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 30.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			return 3000.000000f;
		}
		public override int GetCoverage(GSkill skill)
		{
			return 40;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();

			/*
			if ( player.GetObjectType() )
			d = 0.0f;
			else
			victim.SetProbability(100.0f);
			victim.SetTime(20000.0f);
			victim.SetBuffid(4);
			victim.SetValue(2.5999999f);
			victim.SetAddspeed(true);
			if ( player.GetObjectType() )
			v12 = 0.0f;
			else
			victim.SetProbability(80.0f);
			victim.SetClearwrap(true);
			*/
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetProbability(100.0f);
			victim.SetTime(20000.0f);
			victim.SetBuffid(4);
			victim.SetValue(2.5999999f);
			victim.SetAddspeed(true);
			victim.SetProbability(80.0f);
			victim.SetClearwrap(true);
			return true;
		}
	}
	public class GSkill2892 : GSkill
	{
		public GSkill2892()
			: base(2892)
		{
			
		}
	}
	public class GSkill2893Stub : GSkillStub
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
		public GSkill2893Stub()
			: base(2893)
		{
			occupation = 129;
			maxlevel = 1;
			maxlearn = 1;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 5;
			timetype = 0;
			targettype = 0;
			rangetype = 2;
			doenchant = true;
			dobless = true;
			autoattack = false;
			allowform = 0;
			credittype = 0;
			clearmask = 0;
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
			SetAction(0,"¹íÍõ×Ú_¾£¼¬");
			SetAction(1,"ÇàÔÆÃÅ_¾£¼¬");
			SetAction(2,"¹íÍõ×Ú_¾£¼¬");
			SetAction(3,"ºÏ»¶ÅÉ_¾£¼¬");
			SetAction(4,"ÌìÒôËÂ_¾£¼¬");
			SetAction(5,"¹íµÀ_¾£¼¬");
			SetAction(6,"0");
			SetAction(7,"ÊÞÉñ_¾£¼¬");
			SetAction(8,"ºüÑý_¾£¼¬");
			SetAction(9,"0");
			SetAction(10,"»³¹â_ÍµÏ®");
			SetAction(11,"0");
			SetAction(12,"Ìì»ª_´ºÀ×");
			SetAction(13,"");
			SetAction(14,"");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"¹íÍõ×Ú_Æï³Ë_¾£¼¬");
			SetAction(19,"ÇàÔÆÃÅ_Æï³Ë_¾£¼¬");
			SetAction(20,"¹íÍõ×Ú_Æï³Ë_¾£¼¬");
			SetAction(21,"ºÏ»¶ÅÉ_Æï³Ë_¾£¼¬");
			SetAction(22,"ÌìÒôËÂ_Æï³Ë_¾£¼¬");
			SetAction(23,"¹íµÀ_Æï³Ë_¾£¼¬");
			SetAction(24,"0");
			SetAction(25,"ÊÞÉñ_Æï³Ë_¾£¼¬");
			SetAction(26,"ºüÑý_Æï³Ë_¾£¼¬");
			SetAction(27,"0");
			SetAction(28,"»³¹â_Æï³Ë_ÍµÏ®");
			SetAction(29,"0");
			SetAction(30,"Ìì»ª_Æï³Ë_´ºÀ×");
			name = "Óù¼ÝÇ×Õ÷¡¤Óú";
			nativename = "Óù¼ÝÇ×Õ÷¡¤Óú";
			icon = "Óù¼ÝÇ×Õ÷¡¤Óú.dds";
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
			return 480000;
		}
		public override float GetRadius(GSkill skill)
		{
			return 35.000000f;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 32.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 30.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			return 3000.000000f;
		}
		public override int GetCoverage(GSkill skill)
		{
			return 40;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();

			/*
			if ( player.GetObjectType() )
			d = 0.0f;
			else
			victim.SetProbability(100.0f);
			victim.SetCleardizzy(true);
			if ( player.GetObjectType() )
			v17 = 0.0f;
			else
			victim.SetProbability(100.0f);
			victim.SetClearsleep(true);
			if ( player.GetObjectType() )
			v16 = 0.0f;
			else
			victim.SetProbability(100.0f);
			victim.SetClearsilent(true);
			if ( player.GetObjectType() )
			v15 = 0.0f;
			else
			victim.SetProbability(100.0f);
			victim.SetClearwrap(true);
			*/
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetProbability(100.0f);
			victim.SetCleardizzy(true);
			victim.SetProbability(100.0f);
			victim.SetClearsleep(true);
			victim.SetProbability(100.0f);
			victim.SetClearsilent(true);
			victim.SetProbability(100.0f);
			victim.SetClearwrap(true);
			return true;
		}
	}
	public class GSkill2893 : GSkill
	{
		public GSkill2893()
			: base(2893)
		{
			
		}
	}
	public class GSkill2894Stub : GSkillStub
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
		public GSkill2894Stub()
			: base(2894)
		{
			occupation = 129;
			maxlevel = 1;
			maxlearn = 1;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 5;
			timetype = 0;
			targettype = 0;
			rangetype = 2;
			doenchant = true;
			dobless = true;
			autoattack = false;
			allowform = 0;
			credittype = 0;
			clearmask = 0;
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
			SetAction(0,"¹íÍõ×Ú_»Ø´º");
			SetAction(1,"ÇàÔÆÃÅ_»Ø´º");
			SetAction(2,"¹íÍõ×Ú_»Ø´º");
			SetAction(3,"ºÏ»¶ÅÉ_»Ø´º");
			SetAction(4,"ÌìÒôËÂ_»Ø´º");
			SetAction(5,"¹íµÀ_»Ø´º");
			SetAction(6,"0");
			SetAction(7,"ÊÞÉñ_»Ø´º");
			SetAction(8,"ºüÑý_»Ø´º");
			SetAction(9,"0");
			SetAction(10,"»³¹â_ÍµÏ®");
			SetAction(11,"0");
			SetAction(12,"Ìì»ª_´ºÀ×");
			SetAction(13,"");
			SetAction(14,"");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"¹íÍõ×Ú_Æï³Ë_»Ø´º");
			SetAction(19,"ÇàÔÆÃÅ_Æï³Ë_»Ø´º");
			SetAction(20,"¹íÍõ×Ú_Æï³Ë_»Ø´º");
			SetAction(21,"ºÏ»¶ÅÉ_Æï³Ë_»Ø´º");
			SetAction(22,"ÌìÒôËÂ_Æï³Ë_»Ø´º");
			SetAction(23,"¹íµÀ_Æï³Ë_»Ø´º");
			SetAction(24,"0");
			SetAction(25,"ÊÞÉñ_Æï³Ë_»Ø´º");
			SetAction(26,"ºüÑý_Æï³Ë_»Ø´º");
			SetAction(27,"0");
			SetAction(28,"»³¹â_Æï³Ë_ÍµÏ®");
			SetAction(29,"0");
			SetAction(30,"Ìì»ª_Æï³Ë_´ºÀ×");
			name = "Óù¼ÝÇ×Õ÷¡¤ëÊ";
			nativename = "Óù¼ÝÇ×Õ÷¡¤ëÊ";
			icon = "Óù¼ÝÇ×Õ÷¡¤ëÊ.dds";
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
			return 480000;
		}
		public override float GetRadius(GSkill skill)
		{
			return 35.000000f;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 32.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 30.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			return 3000.000000f;
		}
		public override int GetCoverage(GSkill skill)
		{
			return 40;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();

			/*
			if ( player.GetObjectType() )
			d = 0.0f;
			else
			victim.SetProbability(100.0f);
			victim.SetTime(30000.0f);
			victim.SetRatio(0.2f);
			victim.SetBuffid(4);
			victim.SetIncskilldodge(true);
			*/
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetProbability(100.0f);
			victim.SetTime(30000.0f);
			victim.SetRatio(0.2f);
			victim.SetBuffid(4);
			victim.SetIncskilldodge(true);
			return true;
		}
	}
	public class GSkill2894 : GSkill
	{
		public GSkill2894()
			: base(2894)
		{
			
		}
	}
	public class GSkill2895Stub : GSkillStub
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
		public GSkill2895Stub()
			: base(2895)
		{
			occupation = 129;
			maxlevel = 1;
			maxlearn = 1;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 5;
			timetype = 0;
			targettype = 0;
			rangetype = 2;
			doenchant = true;
			dobless = true;
			autoattack = false;
			allowform = 0;
			credittype = 0;
			clearmask = 0;
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
			SetAction(0,"¹íÍõ×Ú_»¹Éñ");
			SetAction(1,"ÇàÔÆÃÅ_»¹Éñ");
			SetAction(2,"¹íÍõ×Ú_»¹Éñ");
			SetAction(3,"ºÏ»¶ÅÉ_»¹Éñ");
			SetAction(4,"ÌìÒôËÂ_»¹Éñ");
			SetAction(5,"¹íµÀ_»¹Éñ");
			SetAction(6,"0");
			SetAction(7,"ÊÞÉñ_»¹Éñ");
			SetAction(8,"ºüÑý_»¹Éñ");
			SetAction(9,"0");
			SetAction(10,"»³¹â_ÍµÏ®");
			SetAction(11,"0");
			SetAction(12,"Ìì»ª_´ºÀ×");
			SetAction(13,"");
			SetAction(14,"");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"¹íÍõ×Ú_Æï³Ë_»¹Éñ");
			SetAction(19,"ÇàÔÆÃÅ_Æï³Ë_»¹Éñ");
			SetAction(20,"¹íÍõ×Ú_Æï³Ë_»¹Éñ");
			SetAction(21,"ºÏ»¶ÅÉ_Æï³Ë_»¹Éñ");
			SetAction(22,"ÌìÒôËÂ_Æï³Ë_»¹Éñ");
			SetAction(23,"¹íµÀ_Æï³Ë_»¹Éñ");
			SetAction(24,"0");
			SetAction(25,"ÊÞÉñ_Æï³Ë_»¹Éñ");
			SetAction(26,"ºüÑý_Æï³Ë_»¹Éñ");
			SetAction(27,"0");
			SetAction(28,"»³¹â_Æï³Ë_ÍµÏ®");
			SetAction(29,"0");
			SetAction(30,"Ìì»ª_Æï³Ë_´ºÀ×");
			name = "Óù¼ÝÇ×Õ÷¡¤°²";
			nativename = "Óù¼ÝÇ×Õ÷¡¤°²";
			icon = "Óù¼ÝÇ×Õ÷¡¤°².dds";
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
			return 480000;
		}
		public override float GetRadius(GSkill skill)
		{
			return 35.000000f;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 32.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 30.000000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 35.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			return 3000.000000f;
		}
		public override int GetCoverage(GSkill skill)
		{
			return 40;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();

			/*
			if ( player.GetObjectType() )
			t = 0.0f;
			else
			victim.SetTime(30000.0f);
			victim.SetRatio(0.60000998f);
			victim.SetAmount(25000.0f);
			victim.SetDechurt(true);
			*/
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetTime(30000.0f);
			victim.SetRatio(0.60000998f);
			victim.SetAmount(25000.0f);
			victim.SetDechurt(true);
			return true;
		}
	}
	public class GSkill2895 : GSkill
	{
		public GSkill2895()
			: base(2895)
		{
			
		}
	}
	public class GSkill2896Stub : GSkillStub
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
		public GSkill2896Stub()
			: base(2896)
		{
			occupation = 129;
			maxlevel = 1;
			maxlearn = 1;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 5;
			timetype = 0;
			targettype = 0;
			rangetype = 2;
			doenchant = true;
			dobless = true;
			autoattack = false;
			allowform = 0;
			credittype = 0;
			clearmask = 0;
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
			SetAction(0,"¹íÍõ×Ú_¿ÝÄ¾Öä");
			SetAction(1,"ÇàÔÆÃÅ_Á¶Æø»¹Éñ");
			SetAction(2,"¹íÍõ×Ú_¿ÝÄ¾Öä");
			SetAction(3,"ºÏ»¶ÅÉ_¼¤Àø");
			SetAction(4,"ÌìÒôËÂ_Ò×½î¾­");
			SetAction(5,"ÄýÉñÑªÖä");
			SetAction(6,"0");
			SetAction(7,"ÊÞÉñ_ºáÐÐ");
			SetAction(8,"ºüÑý_¹ÌÔªÊõ");
			SetAction(9,"0");
			SetAction(10,"»³¹â_ÍµÏ®");
			SetAction(11,"0");
			SetAction(12,"Ìì»ª_´ºÀ×");
			SetAction(13,"");
			SetAction(14,"");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"¹íÍõ×Ú_Æï³Ë_¿ÝÄ¾Öä");
			SetAction(19,"ÇàÔÆÃÅ_Æï³Ë_Á¶Æø»¹Éñ");
			SetAction(20,"¹íÍõ×Ú_Æï³Ë_¿ÝÄ¾Öä");
			SetAction(21,"ºÏ»¶ÅÉ_Æï³Ë_¼¤Àø");
			SetAction(22,"ÌìÒôËÂ_Æï³Ë_Ò×½î¾­");
			SetAction(23,"ÄýÉñÑªÖä");
			SetAction(24,"0");
			SetAction(25,"ÊÞÉñ_Æï³Ë_ºáÐÐ");
			SetAction(26,"ºüÑý_Æï³Ë_¹ÌÔªÊõ");
			SetAction(27,"0");
			SetAction(28,"»³¹â_ÍµÏ®");
			SetAction(29,"0");
			SetAction(30,"Ìì»ª_´ºÀ×");
			name = "Óù¼ÝÇ×Õ÷¡¤ÓÓ";
			nativename = "Óù¼ÝÇ×Õ÷¡¤ÓÓ";
			icon = "Óù¼ÝÇ×Õ÷¡¤ÓÓ.dds";
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
			return 480000;
		}
		public override float GetRadius(GSkill skill)
		{
			return 35.000000f;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 32.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 30.000000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 35.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			return 3000.000000f;
		}
		public override int GetCoverage(GSkill skill)
		{
			return 40;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();

			/*
			if ( player.GetObjectType() )
			t = 0.0f;
			else
			victim.SetTime(30000.0f);
			victim.SetValue(2.0f);
			victim.SetBlessed(true);
			*/
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetTime(30000.0f);
			victim.SetValue(2.0f);
			victim.SetBlessed(true);
			return true;
		}
	}
	public class GSkill2896 : GSkill
	{
		public GSkill2896()
			: base(2896)
		{
			
		}
	}
	public class GSkill2897Stub : GSkillStub
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
		public GSkill2897Stub()
			: base(2897)
		{
			occupation = 129;
			maxlevel = 1;
			maxlearn = 1;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 5;
			timetype = 0;
			targettype = 0;
			rangetype = 2;
			doenchant = true;
			dobless = true;
			autoattack = false;
			allowform = 0;
			credittype = 0;
			clearmask = 0;
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
			SetAction(0,"¹íÍõ×Ú_¼á¶Ü");
			SetAction(1,"ÇàÔÆÃÅ_¼á¶Ü");
			SetAction(2,"¹íÍõ×Ú_¼á¶Ü");
			SetAction(3,"ºÏ»¶ÅÉ_¼á¶Ü");
			SetAction(4,"ÌìÒôËÂ_¼á¶Ü");
			SetAction(5,"¹íµÀ_¼á¶Ü");
			SetAction(6,"0");
			SetAction(7,"ÊÞÉñ_¼á¶Ü");
			SetAction(8,"ºüÑý_¼á¶Ü");
			SetAction(9,"0");
			SetAction(10,"»³¹â_ÍµÏ®");
			SetAction(11,"0");
			SetAction(12,"Ìì»ª_´ºÀ×");
			SetAction(13,"");
			SetAction(14,"");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"¹íÍõ×Ú_Æï³Ë_¼á¶Ü");
			SetAction(19,"ÇàÔÆÃÅ_Æï³Ë_¼á¶Ü");
			SetAction(20,"¹íÍõ×Ú_Æï³Ë_¼á¶Ü");
			SetAction(21,"ºÏ»¶ÅÉ_Æï³Ë_¼á¶Ü");
			SetAction(22,"ÌìÒôËÂ_Æï³Ë_¼á¶Ü");
			SetAction(23,"¹íµÀ_Æï³Ë_¼á¶Ü");
			SetAction(24,"0");
			SetAction(25,"ÊÞÉñ_Æï³Ë_¼á¶Ü");
			SetAction(26,"ºüÑý_Æï³Ë_¼á¶Ü");
			SetAction(27,"0");
			SetAction(28,"»³¹â_Æï³Ë_ÍµÏ®");
			SetAction(29,"0");
			SetAction(30,"Ìì»ª_Æï³Ë_´ºÀ×");
			name = "Óù¼ÝÇ×Õ÷¡¤ïþ";
			nativename = "Óù¼ÝÇ×Õ÷¡¤ïþ";
			icon = "Óù¼ÝÇ×Õ÷¡¤ïþ.dds";
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
			return 480000;
		}
		public override float GetRadius(GSkill skill)
		{
			return 30.000000f;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 32.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 30.000000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 35.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			return 3000.000000f;
		}
		public override int GetCoverage(GSkill skill)
		{
			return 40;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();

			/*
			if ( player.GetObjectType() )
			d = 0.0f;
			else
			victim.SetProbability(100.0f);
			if ( player.GetObjectType() )
			t = 0.0f;
			else
			victim.SetTime(30000.0f);
			victim.SetRatio(1.0f);
			victim.SetAmount(12.0f);
			victim.SetValue(150.0f);
			victim.SetBloodshield(true);
			*/
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetProbability(100.0f);
			victim.SetTime(30000.0f);
			victim.SetRatio(1.0f);
			victim.SetAmount(12.0f);
			victim.SetValue(150.0f);
			victim.SetBloodshield(true);
			return true;
		}
	}
	public class GSkill2897 : GSkill
	{
		public GSkill2897()
			: base(2897)
		{
			
		}
	}
	public class GSkill2898Stub : GSkillStub
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
		public GSkill2898Stub()
			: base(2898)
		{
			occupation = 129;
			maxlevel = 1;
			maxlearn = 1;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 5;
			timetype = 0;
			targettype = 1;
			rangetype = 2;
			doenchant = true;
			dobless = false;
			autoattack = false;
			allowform = 0;
			credittype = 0;
			clearmask = 0;
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
			SetAction(0,"¹íÍõ×Ú_»¹Éñ");
			SetAction(1,"ÇàÔÆÃÅ_»¹Éñ");
			SetAction(2,"¹íÍõ×Ú_»¹Éñ");
			SetAction(3,"ºÏ»¶ÅÉ_»¹Éñ");
			SetAction(4,"ÌìÒôËÂ_»¹Éñ");
			SetAction(5,"¹íµÀ_»¹Éñ");
			SetAction(6,"0");
			SetAction(7,"ÊÞÉñ_»¹Éñ");
			SetAction(8,"ºüÑý_»¹Éñ");
			SetAction(9,"0");
			SetAction(10,"»³¹â_ÍµÏ®");
			SetAction(11,"0");
			SetAction(12,"Ìì»ª_´ºÀ×");
			SetAction(13,"");
			SetAction(14,"");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"¹íÍõ×Ú_Æï³Ë_»¹Éñ");
			SetAction(19,"ÇàÔÆÃÅ_Æï³Ë_»¹Éñ");
			SetAction(20,"¹íÍõ×Ú_Æï³Ë_»¹Éñ");
			SetAction(21,"ºÏ»¶ÅÉ_Æï³Ë_»¹Éñ");
			SetAction(22,"ÌìÒôËÂ_Æï³Ë_»¹Éñ");
			SetAction(23,"¹íµÀ_Æï³Ë_»¹Éñ");
			SetAction(24,"0");
			SetAction(25,"ÊÞÉñ_Æï³Ë_»¹Éñ");
			SetAction(26,"ºüÑý_Æï³Ë_»¹Éñ");
			SetAction(27,"0");
			SetAction(28,"»³¹â_Æï³Ë_ÍµÏ®");
			SetAction(29,"0");
			SetAction(30,"Ìì»ª_Æï³Ë_´ºÀ×");
			name = "Óù¼ÝÇ×Õ÷¡¤Éú";
			nativename = "Óù¼ÝÇ×Õ÷¡¤Éú";
			icon = "Óù¼ÝÇ×Õ÷¡¤Éú.dds";
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
			return 480000;
		}
		public override float GetRadius(GSkill skill)
		{
			return 30.000000f;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 32.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 30.000000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 35.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			return 3000.000000f;
		}
		public override int GetCoverage(GSkill skill)
		{
			return 40;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetRatio(0.029999999f);
			victim.SetValue(0.2f);
			victim.SetSalvation(true);
			return true;
		}
	}
	public class GSkill2898 : GSkill
	{
		public GSkill2898()
			: base(2898)
		{
			
		}
	}
	public class GSkill2899Stub : GSkillStub
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
		public GSkill2899Stub()
			: base(2899)
		{
			occupation = 51;
			maxlevel = 1;
			maxlearn = 1;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 1;
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
			name = "ÒôÂÉ£º¹¬";
			nativename = "ÒôÂÉ£º¹¬";
			icon = "¹¬.dds";
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
			skill_class = 8;
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
		public override int GetEnmity(GSkill skill)
		{
			return 1;
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
			float			skill_tianhua1 = skill.GetTianhua1();

			victim.SetTime(18000.0f);
			victim.SetBuffid(1);
			victim.SetValue((skill_tianhua1 * 30.0f));
			victim.SetSubantisilent(true);
			return true;
		}
	}
	public class GSkill2899 : GSkill
	{
		public GSkill2899()
			: base(2899)
		{
			
		}
	}
}
