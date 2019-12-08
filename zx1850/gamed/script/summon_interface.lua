-- �ٻ��ű�
-- �������нű�ֻ�����ٻ������ʼ����ʱ����ܵ���

---------------------------------------------------------------------------------------------------- 
-- �ٻ������� 
---------------------------------------------------------------------------------------------------- 
function InitSummonData(id, skill_level, player, monster, index)
	local tempData={}

	tempData.level = player:GetLevel()															-- ����
	tempData.hp = player:GetHP()																		-- �����Ѫ
	tempData.mp = player:GetMP()																		-- �������
	tempData.curhp = player:GetCurHP()															-- ��ǰ��Ѫ
	tempData.curmp = player:GetCurMP()															-- ��ǰ����
	tempData.maxDmg, tempData.minDmg = player:GetDamage()						-- �󹥣�С��
	tempData.defense = player:GetDefense()													-- ����
	tempData.attack = player:GetAttack()														-- �չ�����
	tempData.armor = player:GetArmor()															-- ��ͨ����
	tempData.crRate, tempData.crDmg = player:GetCrit()							-- ����һ���ʣ�10����1.0%���ʣ�
																																	-- ����һ���˺���1.50����150%��
	tempData.skAtk, tempData.skAmr = player:GetSkillRate()					-- �������У�10����101��
																																	-- ���ܶ�����10����1��
	tempData.antiCrRate, tempData.antiCrDmg = player:GetAntiCrit()	-- ��������һ���ʣ���
																																	-- ��������һ���˺�����
	tempData.res1,tempData.res2,tempData.res3,tempData.res4,tempData.res5,tempData.res6 = player:GetResistance()
	tempData.antiInvisibleRate = player:GetLevel()									-- ��������
	tempData.cultivation = player:PlayerQueryCultivation()					-- ��Ӫ(1��2ħ4��)
	

	-- �����ٻ�
	if id == 29999 or id == 30004 or id == 30005 or id == 30006 or id == 30007 
	or id == 32507 or id == 32508 or id == 35210 then
		InitAnimal(tempData, skill_level, player, index)
		if		 id == 29999 then InitWolf(tempData, skill_level, player, index)		-- ��ԭ��
		elseif id == 30004 then	InitBull(tempData, skill_level, player, index)		-- ������
		elseif id == 30005 then InitBear(tempData, skill_level, player, index)		-- ��ɽ��
		elseif id == 30006 then InitTurt(tempData, skill_level, player, index)		-- ɰ����
		elseif id == 30007 then InitTige(tempData, skill_level, player, index)		-- ���뻢
		elseif id == 32507 then InitSFox(tempData, skill_level, player, index)		-- ѩ��
		elseif id == 32508 then InitSFox(tempData, skill_level, player, index)		-- ѩ��
		elseif id == 35210 then InitSFox(tempData, skill_level, player, index)		-- ѩ��
		end

		if		 id == 30004 and tempData.cultivation == 1 then	MagiBull(tempData, skill_level, player, index)		-- �컯����ǿ�����������ɣ�
		elseif id == 30005 and tempData.cultivation == 2 then MagiBear(tempData, skill_level, player, index)		-- �컯����ǿ����ɽ�ܣ�ħ��
		elseif id == 30006 and tempData.cultivation == 4 then MagiTurt(tempData, skill_level, player, index)		-- �컯����ǿ��ɰ��������
		end

		monster:SetLevel(tempData.level)
		monster:SetHP(tempData.hp)
		monster:SetMP(tempData.mp)
		monster:SetCurHP(tempData.hp)
		monster:SetCurMP(tempData.mp)
		monster:SetDamage(tempData.maxDmg, tempData.minDmg)
		monster:SetDefense(tempData.defense)
		monster:SetAttack(tempData.attack)
		monster:SetArmor(tempData.armor)
		monster:SetCrit(tempData.crRate, tempData.crDmg)
		monster:SetSkillRate(tempData.skAtk, tempData.skAmr)
		monster:SetAntiCrit(tempData.antiCrRate, tempData.antiCrDmg)
		monster:SetResistance(tempData.res1,tempData.res2,tempData.res3,tempData.res4,tempData.res5,tempData.res6)
		monster:SetAntiInvisibleRate(tempData.antiInvisibleRate)

	-- ֲ���ٻ�
	elseif id == 30008 or id == 30992 or id == 30993 or id == 30994 then
		InitPlant(tempData, skill_level, player, index)
		if		 id == 30008 then InitPltA(tempData, skill_level, player, index)		-- ¾����
		elseif id == 30992 then	InitPltB(tempData, skill_level, player, index)		-- ����ס
		elseif id == 30993 then InitPltC(tempData, skill_level, player, index)		-- ����ͩ
		elseif id == 30994 then InitPltD(tempData, skill_level, player, index)		-- ��ܽ��
		end
		
		tempData.armor = 1            -- ��ֲ���������Ĭ������Ϊ1����ֹӰ����ɽ�ķ�������
		
		if		 id == 30008 and tempData.cultivation == 2 then MagiPltA(tempData, skill_level, player, index)		-- ǿ��¾���ӣ�ħ��
		elseif id == 30993 and tempData.cultivation == 4 then MagiPltC(tempData, skill_level, player, index)		-- ǿ������ͩ����
		elseif id == 30994 and tempData.cultivation == 1 then MagiPltD(tempData, skill_level, player, index)		-- ǿ����ܽ�أ��ɣ�
		end
		
		monster:SetLevel(tempData.level)
		monster:SetHP(tempData.hp)
		monster:SetMP(tempData.mp)
		monster:SetCurHP(tempData.hp)
		monster:SetCurMP(tempData.mp)
		monster:SetDamage(tempData.maxDmg, tempData.minDmg)
		monster:SetDefense(tempData.defense)
		monster:SetAttack(tempData.attack)
		monster:SetArmor(tempData.armor)
		monster:SetCrit(tempData.crRate, tempData.crDmg)
		monster:SetSkillRate(tempData.skAtk, tempData.skAmr)
		monster:SetAntiCrit(tempData.antiCrRate, tempData.antiCrDmg)
		monster:SetResistance(tempData.res1,tempData.res2,tempData.res3,tempData.res4,tempData.res5,tempData.res6)
		monster:SetAntiInvisibleRate(tempData.antiInvisibleRate)

	-- Ӱ����
	elseif id == 34666 or id == 34667 or id == 34668 or id == 34669 or id == 34670 then
		InitClone(tempData, skill_level, player, index)
		if		 id == 34666 then InitNormalClone(tempData, skill_level, player, index)		-- �ͼ�Ӱ��
		elseif id == 34667 then InitNormalClone(tempData, skill_level, player, index)		-- �߼�Ӱ��
		elseif id == 34668 then InitNormalClone(tempData, skill_level, player, index)		-- �߼�Ӱ��
		elseif id == 34669 then InitNormalClone(tempData, skill_level, player, index)		-- �߼�Ӱ��
		elseif id == 34670 then InitSuperClone(tempData, skill_level, player, index)		-- �ռ�Ӱ��
		end
		
		monster:SetLevel(tempData.level)
		monster:SetHP(tempData.hp)
		monster:SetMP(tempData.mp)
		monster:SetCurHP(tempData.curhp)
		monster:SetCurMP(tempData.curmp)
		monster:SetDamage(tempData.maxDmg, tempData.minDmg)
		monster:SetDefense(tempData.defense)
		monster:SetAttack(tempData.attack)
		monster:SetArmor(tempData.armor)
		monster:SetCrit(tempData.crRate, tempData.crDmg)
		monster:SetSkillRate(tempData.skAtk, tempData.skAmr)
		monster:SetAntiCrit(tempData.antiCrRate, tempData.antiCrDmg)
		monster:SetResistance(tempData.res1,tempData.res2,tempData.res3,tempData.res4,tempData.res5,tempData.res6)
		monster:SetAntiInvisibleRate(tempData.antiInvisibleRate)

	---------------------------------------------------------------------------------------------------- 
	-- ������ 
	----------------------------------------------------------------------------------------------------
	elseif id == 41930 then
		local _,skill_Jianglin = player:PlayerQuerySkilllvl(3064)
		tempData.crRate = tempData.crRate + 10 * skill_Jianglin
		tempData.crDmg  = tempData.crDmg  + 0.05 * skill_Jianglin
		tempData.hp = tempData.hp*(1.2 + 0.2 * skill_Jianglin)
		tempData.mp = 1+skill_Jianglin
		tempData.maxDmg = tempData.maxDmg*(1+0.04*skill_Jianglin) + 384 + 248 * skill_Jianglin
		tempData.minDmg = tempData.minDmg*(1+0.04*skill_Jianglin) + 384 + 248 * skill_Jianglin
		monster:SetHP(tempData.hp)
		monster:SetMP(tempData.mp)
		monster:SetDamage(tempData.maxDmg, tempData.minDmg)
		monster:SetDefense(tempData.defense)
		monster:SetArmor(tempData.armor)
		monster:SetCrit(tempData.crRate, tempData.crDmg)
    monster:SetSkillRate(tempData.skAtk+2*skill_Jianglin, tempData.skAmr)
    monster:SetResistance(tempData.res1,tempData.res2,tempData.res3,tempData.res4,tempData.res5,skill_Jianglin)
	
	
	--------------------------------------------------------------------------------------------------
	-- ���㼼����� 
	--------------------------------------------------------------------------------------------------
	---ҵ��ɱ---
	elseif id == 45507 or id == 50295 or id == 50296 or id == 50297 then
		local _,talent_YeHuoSha_DouPo 	= player:PlayerQuerySkilllvl(3412)
		local monsterlv = 0
		if id == 45507 then monsterlv = 1 
		elseif id == 50295 then monsterlv = 2
		elseif id == 50296 then monsterlv = 3
		elseif id == 50297 then monsterlv = 4
		end
		tempData.maxDmg = (0.6+0.1*monsterlv)*tempData.maxDmg*(1+0.2*talent_YeHuoSha_DouPo)
		tempData.minDmg = (0.6+0.1*monsterlv)*tempData.minDmg*(1+0.2*talent_YeHuoSha_DouPo)
		monster:SetHP(999999)
		monster:SetMP(tempData.mp)
		monster:SetDamage(tempData.maxDmg, tempData.minDmg)
		monster:SetDefense(tempData.defense)
		monster:SetArmor(tempData.armor)
		monster:SetCrit(tempData.crRate, tempData.crDmg)
		monster:SetAttack(tempData.attack)
		monster:SetSkillRate(tempData.skAtk, 1000)
		monster:SetAntiCrit(tempData.antiCrRate, tempData.antiCrDmg)
		monster:SetResistance(tempData.res1,tempData.res2,tempData.res3,tempData.res4,tempData.res5,tempData.res6)
		monster:SetAntiInvisibleRate(tempData.antiInvisibleRate)

	---ҵ��ɱ2nd---	
	elseif id == 50760 then
		local _,talent_YeHuoSha2nd 	= player:PlayerQuerySkilllvl(3756)
		tempData.mp = 0.01*(0.5*talent_YeHuoSha2nd)*player:GetCurHP()*(player:GetCurMP()/player:GetMP())
		monster:SetHP(999999)
		monster:SetMP(tempData.mp)
		monster:SetDamage(tempData.maxDmg, tempData.minDmg)
		monster:SetDefense(talent_YeHuoSha2nd)
		monster:SetArmor(tempData.armor)
		monster:SetCrit(tempData.crRate, tempData.crDmg)
		monster:SetAttack(tempData.attack)
		monster:SetSkillRate(tempData.skAtk, 1000)
		monster:SetAntiCrit(tempData.antiCrRate, tempData.antiCrDmg)
		monster:SetResistance(tempData.res1,tempData.res2,tempData.res3,tempData.res4,tempData.res5,tempData.res6)
		monster:SetAntiInvisibleRate(tempData.antiInvisibleRate)

		---����---
	elseif id == 44678  then
		local _,talent_TianSuo_ShuangLeng 	= player:PlayerQuerySkilllvl(3402)
		tempData.hp = tempData.hp*(1+talent_TianSuo_ShuangLeng)
		monster:SetHP(tempData.hp)
		monster:SetMP(tempData.mp)
		monster:SetDamage(tempData.maxDmg, tempData.minDmg)
		monster:SetDefense(tempData.defense)
		monster:SetArmor(tempData.armor)
		monster:SetCrit(tempData.crRate, tempData.crDmg)
		monster:SetAttack(tempData.attack)
		monster:SetSkillRate(tempData.skAtk, tempData.skAmr)
		monster:SetAntiCrit(tempData.antiCrRate, tempData.antiCrDmg)
		monster:SetResistance(tempData.res1,tempData.res2,tempData.res3,tempData.res4,tempData.res5,tempData.res6)
		monster:SetAntiInvisibleRate(tempData.antiInvisibleRate)

	---����2nd---	
	elseif id == 44679  then
		local _,talent_TianSuo2nd 	= player:PlayerQuerySkilllvl(3749)
		tempData.hp = tempData.hp*talent_TianSuo2nd*0.1
		monster:SetHP(tempData.hp)
		monster:SetMP(tempData.mp)
		monster:SetDamage(tempData.maxDmg, tempData.minDmg)
		monster:SetDefense(tempData.defense)
		monster:SetArmor(tempData.armor)
		monster:SetCrit(tempData.crRate, tempData.crDmg)
		monster:SetAttack(tempData.attack)
		monster:SetSkillRate(tempData.skAtk, tempData.skAmr)
		monster:SetAntiCrit(tempData.antiCrRate, tempData.antiCrDmg)
		monster:SetResistance(tempData.res1,tempData.res2,tempData.res3,tempData.res4,tempData.res5,tempData.res6)
		monster:SetAntiInvisibleRate(tempData.antiInvisibleRate)

	---������---	
	elseif id == 45508 or id == 50636 or id == 50637  then
		local _,talent_JieHuo_LiShang 	= player:PlayerQuerySkilllvl(3418)
		local monsterlv = 0
		if id == 45508 then monsterlv = 1 
		elseif id == 50636 then monsterlv = 2
		elseif id == 50637 then monsterlv = 3
		end
		tempData.hp = tempData.hp*monsterlv*1
		tempData.maxDmg = (0.6+0.1*monsterlv)*tempData.maxDmg*(1+0.2*talent_JieHuo_LiShang)
		tempData.minDmg = (0.6+0.1*monsterlv)*tempData.minDmg*(1+0.2*talent_JieHuo_LiShang)
		monster:SetHP(tempData.hp)
		monster:SetMP(tempData.mp)
		monster:SetCurHP(tempData.hp)
		monster:SetCurMP(tempData.mp)
		monster:SetDamage(tempData.maxDmg, tempData.minDmg)
		monster:SetDefense(tempData.defense)
		monster:SetArmor(tempData.armor)
		monster:SetCrit(tempData.crRate, tempData.crDmg)
		monster:SetAttack(tempData.attack)
		monster:SetSkillRate(tempData.skAtk, tempData.skAmr)
		monster:SetAntiCrit(tempData.antiCrRate, tempData.antiCrDmg)
		monster:SetResistance(tempData.res1,tempData.res2,tempData.res3,tempData.res4,tempData.res5,tempData.res6)
		monster:SetAntiInvisibleRate(tempData.antiInvisibleRate)
	
	---�˻Ļ���---
	elseif id == 45509 or id == 50638 or id == 50639  then
		local monsterlv = 0
		if id == 45509 then monsterlv = 1 
		elseif id == 50638 then monsterlv = 2
		elseif id == 50639 then monsterlv = 3
		end
		local _,cyclelv1 	= player:PlayerQuerySkilllvl(3372)	-- ����
		local _,cyclelv2 	= player:PlayerQuerySkilllvl(3432)	-- ��а��
		local _,cyclelv3 	= player:PlayerQuerySkilllvl(3441)	-- �ٻ�����
		local _,cyclelv4 	= player:PlayerQuerySkilllvl(3450)	-- ף�����
		local _,wudao			= player:PlayerQuerySkilllvl(3423)	-- ���飺�޵�
		local _,tianya		= player:PlayerQuerySkilllvl(2947)
		local _,tianya1		= player:PlayerQuerySkilllvl(4112)
		local _,tianya2		= player:PlayerQuerySkilllvl(4530)
		local MemberCnt		= player:GetCircleMemberCnt()
		
		local k = 0
		if cyclelv1 >= 5 then k = k+1 end
		if cyclelv2 >= 5 then k = k+20 end
		if cyclelv3 >= 5 then k = k+200 end
		if cyclelv4 >= 5 then k = k+2000 end
		
		if skill_level > 1000 then															-- ��ͨ���׵ļ��ܵȼ��ǳ���1000��
			if wudao >= 4 or tianya >= 1 or tianya1 >= 1 or tianya2 >= 1 then k = 0 end
		end
		
		if     MemberCnt == 1 then tempData.hp = tempData.hp *  8
		elseif MemberCnt == 2 then tempData.hp = tempData.hp * 10
		elseif MemberCnt == 3 then tempData.hp = tempData.hp * 12
		elseif MemberCnt == 4 then tempData.hp = tempData.hp * 14
		elseif MemberCnt == 5 then tempData.hp = tempData.hp * 15
		elseif MemberCnt == 6 then tempData.hp = tempData.hp * 16
		end
				
		tempData.mp = 1 + k
		tempData.maxDmg = (1+0.2*monsterlv)*tempData.maxDmg
		tempData.minDmg = (1+0.2*monsterlv)*tempData.minDmg
		tempData.skAmr 	= tempData.skAmr - 500											-- ���ͼ��ܶ���50��
		if tempData.skAmr < 0 then tempData.skAmr = 0 end						-- ������0
		if tempData.skAmr > 1500 then tempData.skAmr = 1500 end			-- ������150

		monster:SetHP(tempData.hp)
		monster:SetMP(tempData.mp)
		monster:SetDamage(tempData.maxDmg, tempData.minDmg)
		monster:SetDefense(tempData.defense)
		monster:SetArmor(tempData.armor)
		monster:SetCrit(tempData.crRate, tempData.crDmg)
		monster:SetAttack(tempData.attack)
		monster:SetSkillRate(tempData.skAtk, tempData.skAmr)
		monster:SetAntiCrit(tempData.antiCrRate, tempData.antiCrDmg)
		monster:SetResistance(tempData.res1,tempData.res2,tempData.res3,tempData.res4,tempData.res5,tempData.res6)
		monster:SetAntiInvisibleRate(tempData.antiInvisibleRate)
		
	---��������---
	elseif id == 50832  then
		local monsterlv = 0
		local cult = tempData.cultivation
		local _,cyclelv1 	= player:PlayerQuerySkilllvl(3372)
		local _,cyclelv2 	= player:PlayerQuerySkilllvl(3432)
		local _,cyclelv3 	= player:PlayerQuerySkilllvl(3441)
		local _,cyclelv4 	= player:PlayerQuerySkilllvl(3450)
		local _,fengshenxian 	= player:PlayerQuerySkilllvl(3572)
		local _,fengshenmo	 	= player:PlayerQuerySkilllvl(3578)
		local _,fengshenfo	 	= player:PlayerQuerySkilllvl(3582)
		if fengshenxian 	>0 and cult == 1 then monsterlv = 100 + fengshenxian end
		if fengshenmo		 	>0 and cult == 2 then monsterlv = 200 + fengshenmo   end
		if fengshenfo		 	>0 and cult == 4 then monsterlv = 300 + fengshenfo   end
		local k = 0
		if cyclelv1 >= 5 then k = k+1 end
		if cyclelv2 >= 5 then k = k+20 end
		if cyclelv3 >= 5 then k = k+200 end
		if cyclelv4 >= 5 then k = k+2000 end
		tempData.hp = 0.5*tempData.hp
		tempData.mp = 1 + k
		tempData.maxDmg = tempData.maxDmg
		tempData.minDmg = tempData.minDmg
		monster:SetHP(tempData.hp)
		monster:SetMP(tempData.mp)
		monster:SetDamage(tempData.maxDmg, tempData.minDmg)
		monster:SetDefense(tempData.defense)
		monster:SetArmor(monsterlv)
		monster:SetCrit(tempData.crRate, tempData.crDmg)
		monster:SetAttack(tempData.attack)
		monster:SetSkillRate(tempData.skAtk, tempData.skAmr)
		monster:SetAntiCrit(tempData.antiCrRate, tempData.antiCrDmg)
		monster:SetResistance(tempData.res1,tempData.res2,tempData.res3,tempData.res4,tempData.res5,tempData.res6)
		monster:SetAntiInvisibleRate(tempData.antiInvisibleRate)

	---�޾�֮�������ٻ�����---
	elseif id == 52420 then
		monster:SetLevel(tempData.level)
		monster:SetHP(5000000)
		monster:SetMP(tempData.mp)
		monster:SetCurHP(tempData.hp)
		monster:SetCurMP(tempData.mp)
		monster:SetDamage(tempData.maxDmg, tempData.minDmg)
		monster:SetDefense(tempData.defense)
		monster:SetAttack(tempData.attack)
		monster:SetArmor(tempData.armor)
		monster:SetCrit(tempData.crRate, tempData.crDmg)
		monster:SetSkillRate(tempData.skAtk, tempData.skAmr)
		monster:SetAntiCrit(tempData.antiCrRate, tempData.antiCrDmg)
		monster:SetResistance(tempData.res1,tempData.res2,tempData.res3,tempData.res4,tempData.res5,tempData.res6)
		monster:SetAntiInvisibleRate(tempData.antiInvisibleRate)

	---�������ٻ���
	elseif id == 53989 then
		local _,AnJieJie	= player:PlayerQuerySkilllvl(4025)
		monster:SetLevel(tempData.level)
		monster:SetHP(1000)
		monster:SetMP(AnJieJie)
		monster:SetCurHP(1000)
		monster:SetCurMP(AnJieJie)
		monster:SetDamage(1, 1)
		monster:SetDefense(tempData.defense)
		monster:SetAttack(tempData.attack)
		monster:SetArmor(tempData.armor)
		monster:SetCrit(tempData.crRate, tempData.crDmg)
		monster:SetSkillRate(tempData.skAtk, tempData.skAmr)
		monster:SetAntiCrit(tempData.antiCrRate, tempData.antiCrDmg)
		monster:SetResistance(tempData.res1,tempData.res2,tempData.res3,tempData.res4,tempData.res5,tempData.res6)
		monster:SetAntiInvisibleRate(tempData.antiInvisibleRate + 100)

	elseif id == 53990 then
		local _,GuangJieJie	= player:PlayerQuerySkilllvl(4026)
		monster:SetLevel(tempData.level)
		monster:SetHP(1000)
		monster:SetMP(tempData.mp)
		monster:SetCurHP(1000)
		monster:SetCurMP(tempData.mp)
		monster:SetDamage(tempData.maxDmg, tempData.minDmg)
		monster:SetDefense(tempData.defense)
		monster:SetAttack(tempData.attack)
		monster:SetArmor(GuangJieJie)
		monster:SetCrit(tempData.crRate, tempData.crDmg)
		monster:SetSkillRate(tempData.skAtk, tempData.skAmr)
		monster:SetAntiCrit(tempData.antiCrRate, tempData.antiCrDmg)
		monster:SetResistance(tempData.res1,tempData.res2,tempData.res3,tempData.res4,tempData.res5,tempData.res6)
		monster:SetAntiInvisibleRate(tempData.antiInvisibleRate + 100)

	elseif id == 54003 then
		local _,HeiSha	= player:PlayerQuerySkilllvl(4129)
		monster:SetLevel(tempData.level)
		monster:SetHP(tempData.hp * 10)
		monster:SetMP(tempData.mp)
		monster:SetCurHP(tempData.hp * 10)
		monster:SetCurMP(tempData.mp)
		monster:SetDamage(tempData.maxDmg, tempData.minDmg)
		monster:SetDefense(tempData.defense)
		monster:SetAttack(tempData.attack)
		monster:SetArmor(tempData.armor)
		monster:SetCrit(tempData.crRate + 100 * HeiSha, tempData.crDmg)
		monster:SetSkillRate(tempData.skAtk, tempData.skAmr)
		monster:SetAntiCrit(tempData.antiCrRate, tempData.antiCrDmg)
		monster:SetResistance(tempData.res1,tempData.res2,tempData.res3,tempData.res4,tempData.res5,tempData.res6)
		monster:SetAntiInvisibleRate(tempData.antiInvisibleRate + 100)

	elseif id == 54000 then
		local _,TianGuang	= player:PlayerQuerySkilllvl(4146)
		monster:SetLevel(tempData.level)
		monster:SetHP(tempData.hp * 10)
		monster:SetMP(tempData.mp)
		monster:SetCurHP(tempData.hp * 10)
		monster:SetCurMP(tempData.mp)
		monster:SetDamage(tempData.maxDmg, tempData.minDmg)
		monster:SetDefense(tempData.defense)
		monster:SetAttack(tempData.attack)
		monster:SetArmor(TianGuang)
		monster:SetCrit(tempData.crRate, tempData.crDmg)
		monster:SetSkillRate(tempData.skAtk, tempData.skAmr)
		monster:SetAntiCrit(tempData.antiCrRate, tempData.antiCrDmg)
		monster:SetResistance(tempData.res1,tempData.res2,tempData.res3,tempData.res4,tempData.res5,tempData.res6)
		monster:SetAntiInvisibleRate(tempData.antiInvisibleRate + 100)

	elseif id == 53991 or id == 54859 or id == 54860 or id == 54861 then
		local _,XueTong	= player:PlayerQuerySkilllvl(4153)
		local _,QiuMing = player:PlayerQuerySkilllvl(4003)
		local _,JingYu  = player:PlayerQuerySkilllvl(4004)
		local _,MuCangQiongXuan = player:PlayerQuerySkilllvl(4585)	-- Ŀ���<��>
		local _,MuCangQiongSha  = player:PlayerQuerySkilllvl(4589)	-- Ŀ���<ɷ>
		local _,MuCangQiongChan = player:PlayerQuerySkilllvl(4593)	-- Ŀ���<��>
		monster:SetLevel(tempData.level)
		monster:SetHP(2)
		monster:SetMP(tempData.mp)
		monster:SetCurHP(tempData.hp)
		monster:SetCurMP(tempData.mp)
		monster:SetDamage(tempData.maxDmg*(1+0.1*XueTong), tempData.minDmg*(1+0.1*XueTong))
		monster:SetDefense(tempData.defense)
		monster:SetAttack(QiuMing)
		monster:SetArmor(JingYu)
		monster:SetCrit(tempData.crRate, tempData.crDmg)
		monster:SetSkillRate(tempData.skAtk+800, tempData.skAmr)
		monster:SetAntiCrit(tempData.antiCrRate, tempData.antiCrDmg)
		monster:SetResistance(MuCangQiongXuan,MuCangQiongSha,MuCangQiongChan,
													tempData.res4,tempData.res5,tempData.res6)
		monster:SetAntiInvisibleRate(tempData.antiInvisibleRate + 20)
	--ǣ���ٻ���
	elseif id == 58864 or id == 58857 or id == 58858 or id == 60296 
			or id == 58860 or id == 58861 or id == 60295
			or id == 58863 or id == 60293 or id == 58855
			
			then
		local dengji
		if id == 58864 then
			_,dengji	= player:PlayerQuerySkilllvl(4778)
		elseif id == 58857 then
			_,dengji	= player:PlayerQuerySkilllvl(4794)
		elseif id ==58858 then
			_,dengji	= player:PlayerQuerySkilllvl(4803)
		elseif id ==60296 then
			_,dengji	= player:PlayerQuerySkilllvl(4811)
		elseif id ==58860 then
			_,dengji	= player:PlayerQuerySkilllvl(4797)
		elseif id ==58861 then
			_,dengji	= player:PlayerQuerySkilllvl(4806)	
		elseif id ==58863 then
			_,dengji	= player:PlayerQuerySkilllvl(4819)
		elseif id ==58855 then
			_,dengji	= player:PlayerQuerySkilllvl(4802)		
		elseif id ==60293 then
			dengji	= 100	
		elseif id ==60295 then
			_,dengji  = player:PlayerQuerySkilllvl(5155)  --����ID
		
		end
		monster:SetLevel(tempData.level)
		monster:SetHP(tempData.hp)
		monster:SetMP(tempData.mp)
		monster:SetCurHP(tempData.hp)
		monster:SetCurMP(tempData.mp)
		monster:SetDamage(tempData.maxDmg, tempData.minDmg)
		monster:SetDefense(tempData.defense)
		monster:SetAttack(tempData.attack)
		monster:SetArmor(tempData.armor)
		monster:SetCrit(tempData.crRate, tempData.crDmg)
		monster:SetSkillRate(tempData.skAtk, tempData.skAmr)
		monster:SetAntiCrit(tempData.antiCrRate, tempData.antiCrDmg)
		monster:SetResistance(tempData.res1,tempData.res2,tempData.res3,tempData.res4,tempData.res5,dengji)
		monster:SetAntiInvisibleRate(tempData.antiInvisibleRate + 100)

	elseif id == 58859 then
			local _,jinengdengji	= player:PlayerQuerySkilllvl(4782)
			local _,tianshudengji	= player:PlayerQuerySkilllvl(5132)
		monster:SetLevel(tempData.level)
		monster:SetHP(tempData.hp)
		monster:SetMP(tempData.mp)
		monster:SetCurHP(tempData.hp)
		monster:SetCurMP(tianshudengji)
		monster:SetDamage(tempData.maxDmg, tempData.minDmg)
		monster:SetDefense(tempData.defense)
		monster:SetAttack(tempData.attack)
		monster:SetArmor(tempData.armor)
		monster:SetCrit(tempData.crRate, tempData.crDmg)
		monster:SetSkillRate(tempData.skAtk, tempData.skAmr)
		monster:SetAntiCrit(tempData.antiCrRate, tempData.antiCrDmg)
		monster:SetResistance(tempData.res1,tempData.res2,tempData.res3,tempData.res4,tempData.res5,jinengdengji)
		monster:SetAntiInvisibleRate(tempData.antiInvisibleRate + 100)
		
	elseif id == 58862  then
			local	_,jinengdengji	= player:PlayerQuerySkilllvl(4815)
			local _,tianshudengji	= player:PlayerQuerySkilllvl(5140)
			local _,tianshu	      = player:PlayerQuerySkilllvl(5136)
		monster:SetLevel(tempData.level)
		monster:SetHP(tempData.hp)
		monster:SetMP(tianshu)
		monster:SetCurHP(tempData.hp)
		monster:SetCurMP(tianshudengji)
		monster:SetDamage(tempData.maxDmg, tempData.minDmg)
		monster:SetDefense(tempData.defense)
		monster:SetAttack(tempData.attack)
		monster:SetArmor(tempData.armor)
		monster:SetCrit(tempData.crRate, tempData.crDmg)
		monster:SetSkillRate(tempData.skAtk, tempData.skAmr)
		monster:SetAntiCrit(tempData.antiCrRate, tempData.antiCrDmg)
		monster:SetResistance(tempData.res1,tempData.res2,tempData.res3,tempData.res4,tempData.res5,jinengdengji)
		monster:SetAntiInvisibleRate(tempData.antiInvisibleRate + 100)

	elseif id == 60310 then
			local _,jinengdengji	= player:PlayerQuerySkilllvl(4818)
			local _,tianshudengji	= player:PlayerQuerySkilllvl(5158)
		monster:SetLevel(tempData.level)
		monster:SetHP(tempData.hp)
		monster:SetMP(tempData.mp)
		monster:SetCurHP(tempData.hp)
		monster:SetCurMP(tianshudengji)
		monster:SetDamage(tempData.maxDmg, tempData.minDmg)
		monster:SetDefense(tempData.defense)
		monster:SetAttack(tempData.attack)
		monster:SetArmor(tempData.armor)
		monster:SetCrit(tempData.crRate, tempData.crDmg)
		monster:SetSkillRate(tempData.skAtk, tempData.skAmr)
		monster:SetAntiCrit(tempData.antiCrRate, tempData.antiCrDmg)
		monster:SetResistance(tempData.res1,tempData.res2,tempData.res3,tempData.res4,tempData.res5,jinengdengji)
		monster:SetAntiInvisibleRate(tempData.antiInvisibleRate + 100)
		
	---Ӣ�����ٻ���:����
	elseif id == 60813 then
		local _,guqiang	= player:PlayerQuerySkilllvl(4863)
		local _,guqiangII = player:PlayerQuerySkilllvl(5254)
		if tempData.cultivation ~= 1 then guqiangII = 0 end
		
		monster:SetLevel(tempData.level)
		monster:SetHP(tempData.hp*0.1*guqiang)
		monster:SetCurHP(tempData.hp*0.1*guqiang)
		monster:SetMP(tempData.mp)
		monster:SetCurMP(tempData.mp)
		monster:SetDamage(1, 1)
		monster:SetDefense(tempData.defense)
		monster:SetAttack(tempData.attack)
		monster:SetArmor(guqiangII)
		monster:SetCrit(tempData.crRate, tempData.crDmg)
		monster:SetSkillRate(tempData.skAtk, tempData.skAmr)
		monster:SetAntiCrit(tempData.antiCrRate, tempData.antiCrDmg)
		monster:SetResistance(tempData.res1,tempData.res2,tempData.res3,tempData.res4,tempData.res5,tempData.res6)
		monster:SetAntiInvisibleRate(tempData.antiInvisibleRate + 100)

	---Ӣ�����ٻ���:����
	elseif id == 60814 then
		local _,shenyuan	= player:PlayerQuerySkilllvl(4872)
		local _,suihun	= player:PlayerQuerySkilllvl(5185)
		local _,shenyuanII = player:PlayerQuerySkilllvl(5255)
		if tempData.cultivation ~= 1 then shenyuanII = 0 end

		monster:SetLevel(tempData.level)
		monster:SetHP(tempData.hp*shenyuan)
		monster:SetCurHP(tempData.hp*shenyuan)
		if suihun>0 then
			monster:SetMP(suihun)
			monster:SetCurMP(suihun)
		else
			monster:SetMP(0)
			monster:SetCurMP(0)
		end
		monster:SetDamage(1, 1)
		monster:SetDefense(tempData.defense)
		monster:SetAttack(tempData.attack)
		monster:SetArmor(shenyuanII)
		monster:SetCrit(tempData.crRate, tempData.crDmg)
		monster:SetSkillRate(tempData.skAtk, tempData.skAmr)
		monster:SetAntiCrit(tempData.antiCrRate, tempData.antiCrDmg)
		monster:SetResistance(tempData.res1,tempData.res2,tempData.res3,tempData.res4,tempData.res5,tempData.res6)
		monster:SetAntiInvisibleRate(tempData.antiInvisibleRate + 100)

	end
	return id
end
---------------------------------------------------------------------------------------------------- 
-- �ٻ����ﺯ�� 
---------------------------------------------------------------------------------------------------- 
function InitAnimal(tempData, skill_level, player, index)
	local _,skill_ShuoKongJin = player:PlayerQuerySkilllvl(1889)
	local _,skill_TongMingXin = player:PlayerQuerySkilllvl(1898)
	local _,skill_JinFengDi = player:PlayerQuerySkilllvl(1907)
	local _,skill_HuMuJing = player:PlayerQuerySkilllvl(1916)
	local allPasSkill = skill_ShuoKongJin + skill_TongMingXin + skill_JinFengDi + skill_HuMuJing

	local _,talent_QiXuan = player:PlayerQuerySkilllvl(2160)
	local _,talent_ShenMu = player:PlayerQuerySkilllvl(2161)
	local _,talent_GouChi = player:PlayerQuerySkilllvl(2162)
	local _,talent_JiaoXuan = player:PlayerQuerySkilllvl(2163)

	local _,talent_RuiJin = player:PlayerQuerySkilllvl(2159)
	local _,talent_HuiSa = player:PlayerQuerySkilllvl(2164)

	if(skill_ShuoKongJin < talent_QiXuan) then talent_QiXuan   = skill_ShuoKongJin end
	if(skill_TongMingXin < talent_ShenMu) then talent_ShenMu   = skill_TongMingXin end
	if(skill_JinFengDi < talent_GouChi)   then talent_GouChi   = skill_JinFengDi	 end
	if(skill_HuMuJing < talent_JiaoXuan)  then talent_JiaoXuan = skill_HuMuJing	   end

	tempData.mp = 1
	tempData.curhp = tempData.hp
	tempData.curmp = tempData.mp
	tempData.maxDmg = tempData.maxDmg + 0.5 * talent_QiXuan * tempData.level
	tempData.minDmg = tempData.minDmg + 0.5 * talent_QiXuan * tempData.level
	tempData.attack = tempData.attack + 120 * talent_ShenMu
	tempData.crRate = tempData.crRate + 10 * talent_GouChi
	tempData.crDmg  = tempData.crDmg + 0.1 * talent_JiaoXuan
	
	tempData.maxDmg = tempData.maxDmg - 5 * talent_RuiJin	* allPasSkill
	tempData.minDmg = tempData.minDmg - 5 * talent_RuiJin	* allPasSkill
	tempData.crDmg  = tempData.crDmg - 0.03 * talent_HuiSa	* allPasSkill
	tempData.antiInvisibleRate = tempData.antiInvisibleRate + 10
end
---------------------------------------------------------------------------------------------------- 
-- �ٻ�ֲ�ﺯ�� 
---------------------------------------------------------------------------------------------------- 
function InitPlant(tempData, skill_level, player, index)
	local _,talent_JianMu = player:PlayerQuerySkilllvl(2130)
	
	tempData.hp = 10 + skill_level + 3 * talent_JianMu
	tempData.mp = 1
	tempData.curhp = tempData.hp
	tempData.curmp = tempData.mp
	tempData.maxDmg = 1+skill_level
	tempData.minDmg = 1
	tempData.defense = 99999
	tempData.antiInvisibleRate = tempData.antiInvisibleRate + 10
end
---------------------------------------------------------------------------------------------------- 
-- Ӱ������ 
---------------------------------------------------------------------------------------------------- 
function InitClone(tempData, skill_level, player, index)
	local _,talent_FengYing = player:PlayerQuerySkilllvl(2562)
	local _,talent_XuanYing = player:PlayerQuerySkilllvl(2564)
	local _,talent_ZuoYing = player:PlayerQuerySkilllvl(2567)
	local _,talent_BiYing = player:PlayerQuerySkilllvl(2568)

	tempData.armor 			= tempData.armor 			+  20 * talent_FengYing
	tempData.skAmr 			= tempData.skAmr 			+ 100 * talent_XuanYing
	tempData.antiCrRate = tempData.antiCrRate +	100 * talent_ZuoYing
	tempData.antiCrDmg	= tempData.antiCrDmg  + 0.5 * talent_BiYing
end
---------------------------------------------------------------------------------------------------- 
-- ������ 
---------------------------------------------------------------------------------------------------- 
function InitWolf(tempData, skill_level, player, index)		-- ��ԭ��
	local _,skill_CangYuanLang = player:PlayerQuerySkilllvl(1890)
	local _,talent_XiongLang = player:PlayerQuerySkilllvl(2165)

	tempData.crRate = tempData.crRate + 10 * skill_CangYuanLang
	tempData.crDmg  = tempData.crDmg  + 0.05 * talent_XiongLang * skill_CangYuanLang
end

function InitBull(tempData, skill_level, player, index)		-- ������
	local _,skill_LeiZeGu = player:PlayerQuerySkilllvl(1899)
	local _,talent_KuiGu = player:PlayerQuerySkilllvl(2166)

	tempData.maxDmg = tempData.maxDmg * (1 + 0.01 * skill_LeiZeGu)
	tempData.minDmg = tempData.minDmg * (1 + 0.01 * skill_LeiZeGu)
	tempData.crRate = tempData.crRate + 5 * talent_KuiGu * skill_LeiZeGu
end

function InitBear(tempData, skill_level, player, index)		-- ��ɽ��
	local _,skill_MangShanXiong = player:PlayerQuerySkilllvl(1908)
	local _,talent_WeiXiong = player:PlayerQuerySkilllvl(2167)

	tempData.hp = tempData.hp * (1 + 0.1 * skill_MangShanXiong)
	tempData.maxDmg = tempData.maxDmg * (1 + 0.005 * talent_WeiXiong * skill_MangShanXiong)
	tempData.minDmg = tempData.minDmg * (1 + 0.005 * talent_WeiXiong * skill_MangShanXiong)
end

function InitTurt(tempData, skill_level, player, index)		-- ɰ����
	local _,skill_ShaHeYuan = player:PlayerQuerySkilllvl(1917)
	local _,talent_XuanGui = player:PlayerQuerySkilllvl(2168)

	tempData.defense = tempData.defense * (1+0.01*skill_ShaHeYuan)
	tempData.hp = tempData.hp * (1 + 0.05 * talent_XuanGui * skill_ShaHeYuan)
end

function InitTige(tempData, skill_level, player, index)		-- ���뻢
	InitTurt(tempData, skill_level, player)
	InitBear(tempData, skill_level, player)
	InitBull(tempData, skill_level, player)
	InitWolf(tempData, skill_level, player)

	if skill_level > 5 then skill_level = 5 end --����������뻢�ȼ������˺����������
	tempData.mp = 1 + skill_level
	tempData.hp = tempData.hp * skill_level
end

function InitSFox(tempData, skill_level, player, index)		-- ѩ��
	InitTurt(tempData, skill_level, player)
	InitBear(tempData, skill_level, player)
	InitBull(tempData, skill_level, player)
	InitWolf(tempData, skill_level, player)

	tempData.mp = 1 + index
end

function MagiBull(tempData, skill_level, player, index)		-- �컯����ǿ��������
	local _,skill_BullII = player:PlayerQuerySkilllvl(2221)

	tempData.skAtk = tempData.skAtk + 20 * skill_BullII
	tempData.skAmr = tempData.skAmr + 50 * skill_BullII
	tempData.mp = 1 + skill_BullII
end

function MagiBear(tempData, skill_level, player, index)		-- �컯����ǿ����ɽ��
	local _,skill_BearII = player:PlayerQuerySkilllvl(2231)

	tempData.skAtk = tempData.skAtk + 20 * skill_BearII
	tempData.skAmr = tempData.skAmr + 50 * skill_BearII
	tempData.mp = 1 + skill_BearII

end

function MagiTurt(tempData, skill_level, player, index)		-- �컯����ǿ��ɰ����
	local _,skill_TurtII = player:PlayerQuerySkilllvl(2241)

	tempData.skAtk = tempData.skAtk + 20 * skill_TurtII
	tempData.skAmr = tempData.skAmr + 50 * skill_TurtII
	tempData.mp = 1 + skill_TurtII
end
---------------------------------------------------------------------------------------------------- 
-- ֲ���� 
---------------------------------------------------------------------------------------------------- 
function InitPltA(tempData, skill_level, player, index)		-- ¾����
	local _,talent_HuXu = player:PlayerQuerySkilllvl(2126)
	tempData.attack = player:GetDamage()
	tempData.mp = 1 + talent_HuXu
end

function InitPltB(tempData, skill_level, player, index)		-- ����ס
	local _,talent_JianChi = player:PlayerQuerySkilllvl(2127)
	tempData.mp = 1 + talent_JianChi
end

function InitPltC(tempData, skill_level, player, index)		-- ����ͩ
	local _,talent_YuXin = player:PlayerQuerySkilllvl(2128)
	tempData.mp = 1 + talent_YuXin
end

function InitPltD(tempData, skill_level, player, index)		-- ��ܽ��
	local _,talent_QiongJiang = player:PlayerQuerySkilllvl(2129)
	tempData.mp = 1 + talent_QiongJiang
end

function MagiPltA(tempData, skill_level, player, index)		-- �컯����ǿ��¾����
	local _,skill_PltAII = player:PlayerQuerySkilllvl(2230)
	tempData.armor = 1 + skill_PltAII
end

function MagiPltC(tempData, skill_level, player, index)		-- �컯����ǿ������ͩ
	local _,skill_PltCII = player:PlayerQuerySkilllvl(2240)
	tempData.armor = 1 + skill_PltCII
end

function MagiPltD(tempData, skill_level, player, index)		-- �컯����ǿ����ܽ��
	local _,skill_PltDII = player:PlayerQuerySkilllvl(2220)
	tempData.armor = 1 + skill_PltDII
end
---------------------------------------------------------------------------------------------------- 
-- Ӱ���� 
----------------------------------------------------------------------------------------------------
function InitNormalClone(tempData, skill_level, player, index)	-- ��ͨӰ��
  local _,skill_Xing = player:PlayerQuerySkilllvl(2420)
	local _,skill_Hun = player:PlayerQuerySkilllvl(2438)
	local _,skill_Ji = player:PlayerQuerySkilllvl(2453)


	tempData.maxDmg = tempData.maxDmg * (0.5+ 0.1 * skill_Hun)
	tempData.minDmg = tempData.minDmg * (0.5+ 0.1 * skill_Hun)
 	tempData.hp     = tempData.hp     * (1 + 0.1 * skill_Xing)
end

function InitSuperClone(tempData, skill_level, player, index)		-- �ռ�Ӱ��
	local _,skill_Xing = player:PlayerQuerySkilllvl(2420)
	local _,skill_Hun = player:PlayerQuerySkilllvl(2438)
	local _,skill_Ji = player:PlayerQuerySkilllvl(2453)
	local mapID,mapX,mapY,mapZ = player:PlayerQueryPosition()

	tempData.maxDmg = tempData.maxDmg * (1 + 0.1 * skill_Ji + 0.1 * skill_Hun)
	tempData.minDmg = tempData.minDmg * (1 + 0.1 * skill_Ji + 0.1 * skill_Hun)
	tempData.hp     = tempData.hp     * (1 + 0.1 * skill_Ji + 0.1 * skill_Xing)
	tempData.curhp  = tempData.hp
	
	if mapID ~= 534 then																				-- �޾�֮���������������Ӱ�Ӷ����ӳ�
		tempData.armor 	= tempData.armor 			+ 160  							-- 160���չ�����
		tempData.skAmr 	= tempData.skAmr 			+ 800								--  80�㼼�ܶ���
	end

end