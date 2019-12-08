--[[
//����³�����Ҫ���õ�������

1.���ݳ��������Դ���ü��ܺͼ��ܵȼ�
ZLuaPetBedgeSkills(pet_tid,horoscope,origin)

2.���ݳ��������Դ�����츳
ZLuaPetBedgeTalents(pet_tid,origin)

3.���ݳ��������Դ���������������
ZLuaPetBedgeLives(pet_tid,origin)

4.���＼��������츳��ȡ�ļ�������
ZLuaPetBedgeSkillBenefitByTalenet(skill_id,talentslist,pet_level)

5.�����ֻؼ������
ZLuaPetBedgeFatalitySkills(pet_tid,origin)

--]]

----���ݳ���id�������ܺͼ��ܵȼ�----------------------------------------------------------
function ZLuaPetBedgeSkills(pet_tid,pet,horoscope,origin)
 	if ZLuaPetBedgeExistInTmplIDs(pet_tid) == 0 then return end
	local AvailablePets=ZLuaAvailablePets()
	local ServerOrigins=ZLuaPetBedgeOrigins()
	local serverorigin = origin or ServerOrigins["drop"]
	
	local skillslist={}		---//�����б�
	local skillschance={}	---//ÿ�����ܳ��ֵĸ���
	local choosenum=3				---//ѡȡ�ļ�������
	local maxsamecol=1			---//ÿ�����������ֵĴ���
	local maxskillslevel=1	---//ÿ�����������ֵļ���
	
	local choosenumchance={250,500,1000,250,0,0,0}		---//���ּ��ܵ�����
	
	if pet:QueryRebornCnt() == 1 then 
		choosenumchance = {250,500,1000,250,80,50,30}
	end
	
	choosenum=math.max(math.min(ZPetGrade_Get_RanPoint(choosenumchance),7),1)
			
	local choosedskills={}
	local returnedskills={}
	local returnedskillslevel={}

	local Horoscope=ZLuaPetBedgeHoroscopeDesc()

	if 	pet:QueryRebornCnt() == 0 then 
	
  	if horoscope==Horoscope["riyao"]	then 
  		skillslist=		{1399,1400,1401,1402,1403,1404,1453,1454,1455,1456,1457,1458}
  		skillschance=	{1000,1000,1000,1000,1000,1000,1000,1000,1000,1000,1000,1000}
  	elseif horoscope==Horoscope["yueyao"]	then 
  		skillslist=		{1405,1406,1407,1408,1409,1410,1453,1454,1455,1456,1457,1458}
  		skillschance=	{1000,1000,1000,1000,1000,1000,1000,1000,1000,1000,1000,1000}
  	elseif horoscope==Horoscope["jinyao"]	then 
  		skillslist=		{1411,1412,1413,1414,1415,1416,1453,1454,1455,1456,1457,1458}
  		skillschance=	{1000,1000,1000,1000,1000,1000,1000,1000,1000,1000,1000,1000}
  	elseif horoscope==Horoscope["muyao"] then
  		skillslist=		{1417,1418,1419,1420,1421,1422,1453,1454,1455,1456,1457,1458}
  		skillschance=	{1000,1000,1000,1000,1000,1000,1000,1000,1000,1000,1000,1000}	
  	elseif horoscope==Horoscope["shuiyao"] then
  		skillslist=		{1423,1424,1425,1426,1427,1428,1453,1454,1455,1456,1457,1458}
  		skillschance=	{1000,1000,1000,1000,1000,1000,1000,1000,1000,1000,1000,1000}	
  	elseif horoscope==Horoscope["huoyao"]	then 
  		skillslist=		{1429,1430,1431,1432,1433,1434,1453,1454,1455,1456,1457,1458}
  		skillschance=	{1000,1000,1000,1000,1000,1000,1000,1000,1000,1000,1000,1000}
  	elseif horoscope==Horoscope["tuyao"] then	
  		skillslist=		{1435,1436,1437,1438,1439,1440,1453,1454,1455,1456,1457,1458}
  		skillschance=	{1000,1000,1000,1000,1000,1000,1000,1000,1000,1000,1000,1000}
  	elseif horoscope==Horoscope["luohou"]	then 
  		skillslist=		{1441,1442,1443,1444,1445,1446,1453,1454,1455,1456,1457,1458}
  		skillschance=	{1000,1000,1000,1000,1000,1000,1000,1000,1000,1000,1000,1000}
  	elseif horoscope==Horoscope["jidu"]	then 
  		skillslist=		{1447,1448,1449,1450,1451,1452,1453,1454,1455,1456,1457,1458}
  		skillschance=	{1000,1000,1000,1000,1000,1000,1000,1000,1000,1000,1000,1000}
  	else
  		skillslist=		{1453,1454,1455,1456,1457,1458}
  		skillschance=	{1000,1000,1000,1000,1000,1000}
  	end	
	
	elseif pet:QueryRebornCnt() == 1 then 
		
  	if horoscope==Horoscope["riyao"]	then 
  		skillslist=		{1399,1400,1401,1402,1403,1404,1453,1454,1455,1456,1457,1458,5018}
  		skillschance=	{1000,1000,1000,1000,1000,1000,1000,1000,1000,1000,1000,1000,200}
  	elseif horoscope==Horoscope["yueyao"]	then 
  		skillslist=		{1405,1406,1407,1408,1409,1410,1453,1454,1455,1456,1457,1458,5019}
  		skillschance=	{1000,1000,1000,1000,1000,1000,1000,1000,1000,1000,1000,1000,200}
  	elseif horoscope==Horoscope["jinyao"]	then 
  		skillslist=		{1411,1412,1413,1414,1415,1416,1453,1454,1455,1456,1457,1458,5020}
  		skillschance=	{1000,1000,1000,1000,1000,1000,1000,1000,1000,1000,1000,1000,200}
  	elseif horoscope==Horoscope["muyao"] then
  		skillslist=		{1417,1418,1419,1420,1421,1422,1453,1454,1455,1456,1457,1458,5021}
  		skillschance=	{1000,1000,1000,1000,1000,1000,1000,1000,1000,1000,1000,1000,200}	
  	elseif horoscope==Horoscope["shuiyao"] then
  		skillslist=		{1423,1424,1425,1426,1427,1428,1453,1454,1455,1456,1457,1458,5022}
  		skillschance=	{1000,1000,1000,1000,1000,1000,1000,1000,1000,1000,1000,1000,200}	
  	elseif horoscope==Horoscope["huoyao"]	then 
  		skillslist=		{1429,1430,1431,1432,1433,1434,1453,1454,1455,1456,1457,1458,5023}
  		skillschance=	{1000,1000,1000,1000,1000,1000,1000,1000,1000,1000,1000,1000,200}
  	elseif horoscope==Horoscope["tuyao"] then	
  		skillslist=		{1435,1436,1437,1438,1439,1440,1453,1454,1455,1456,1457,1458,5024}
  		skillschance=	{1000,1000,1000,1000,1000,1000,1000,1000,1000,1000,1000,1000,200}
  	elseif horoscope==Horoscope["luohou"]	then 
  		skillslist=		{1441,1442,1443,1444,1445,1446,1453,1454,1455,1456,1457,1458,5026}
  		skillschance=	{1000,1000,1000,1000,1000,1000,1000,1000,1000,1000,1000,1000,200}
  	elseif horoscope==Horoscope["jidu"]	then 
  		skillslist=		{1447,1448,1449,1450,1451,1452,1453,1454,1455,1456,1457,1458,5025}
  		skillschance=	{1000,1000,1000,1000,1000,1000,1000,1000,1000,1000,1000,1000,200}
  	else
  		skillslist=		{1453,1454,1455,1456,1457,1458,5027,5028}
  		skillschance=	{1000,1000,1000,1000,1000,1000,200,200}
  	end	
	
	end
		
	if choosenum>7 or choosenum>table.getn(skillslist) or table.getn(skillslist)~=table.getn(skillschance) then return end 
	choosedskills=ZLuaCheckOutNums(skillslist,skillschance,choosenum,maxsamecol)
	
	if pet_tid==AvailablePets["S_luxueqi"].pet_tid then
		choosedskills={1261,1273}
	elseif pet_tid==AvailablePets["S_luxueqi2"].pet_tid then
		choosedskills={1274,1275}
	elseif pet_tid==AvailablePets["S_biyao"].pet_tid then
		choosedskills={247,314,526,777}
	end 	
	returnedskills,returnedskillslevel=ZLuaPetBedgeMakeSkillsTable(choosedskills,choosenum,maxskillslevel)
	
	return returnedskills,returnedskillslevel
end 
------------------------------------------------------------------------------------------
----���ݳ���id����Դ�趨�츳--------------------------------------------------------------
function ZLuaPetBedgeTalents(pet_tid,origin)
 	if ZLuaPetBedgeExistInTmplIDs(pet_tid) == 0 then return end
	local AvailablePets=ZLuaAvailablePets()
	local ServerOrigins=ZLuaPetBedgeOrigins()
	local serverorigin = origin or ServerOrigins["drop"]
	
	local TalentsList={}
	local talentschance={}	---//ÿ���츳��ϳ��ֵĸ���
	local talentschoosed		---//ѡȡ���츳���
	
	---//13���츳���
		TalentsList[1]={10,5,0,0,0,0,0,0,0,0,0,5,0}
		TalentsList[2]={5,10,5,0,0,0,0,0,0,0,0,0,5}
		TalentsList[3]={0,5,10,5,0,0,0,0,0,0,0,0,0}
		TalentsList[4]={0,0,5,10,5,0,0,0,0,0,0,0,0}
		TalentsList[5]={0,0,0,5,10,5,0,0,0,0,0,0,0}
		TalentsList[6]={0,0,0,0,5,10,5,0,0,0,0,0,5}
		TalentsList[7]={0,0,0,0,0,5,10,5,0,0,0,0,0}
		TalentsList[8]={0,0,0,0,0,0,5,10,5,0,0,0,0}
		TalentsList[9]={0,0,0,0,0,0,0,5,10,5,0,0,0}
		TalentsList[10]={0,0,0,0,0,0,0,0,5,10,5,0,5}
		TalentsList[11]={0,0,0,0,0,0,0,0,0,5,10,5,0}
		TalentsList[12]={5,0,0,0,0,0,0,0,0,0,5,10,0}
		TalentsList[13]={0,5,0,0,0,5,0,0,0,5,0,0,10}
		talentschance={10,10,10,10,10,10,10,10,10,10,10,10,10} 
		talentschoosed=ZPetGrade_Get_RanPoint(talentschance)

	if talentschoosed>13 or talentschoosed<1  then talentschoosed=13 end 

	return TalentsList[talentschoosed]
end 
------------------------------------------------------------------------------------------
----���ݳ���id��������(�ֻ�)����---------------------------------------------------------------
function ZLuaPetBedgeFatalitySkills(pet_tid,origin)
	local AvailablePets=ZLuaAvailablePets()
	local fatalskills={1368,1369,1370,1371,1372,1373,1374,1375,1376,1377,
										 1378,1379,1380,1381,1382,1383,1384,1385,1386,1387,
										 1388,1389,1390,1391,1392,1393,1394,1397,1398}

	local fatalchance={1000,1000,1000,1000,1000,1000,1000,1000,1000,1000,
										 1000,1000,1000,1000,1000,1000,1000,1000,1000,1000,
										 1000,1000,1000,1000,1000,1000,1000,1000,1000}
	local fatalchoosed=fatalskills[ZPetGrade_Get_RanPoint(fatalchance)]
	
	if pet_tid==AvailablePets["S_luxueqi"].pet_tid then
		fatalchoosed=1395
	elseif pet_tid==AvailablePets["S_biyao"].pet_tid then
		fatalchoosed=1396
	end 
	
	return fatalchoosed
end 
------------------------------------------------------------------------------------------
------���ݳ���id����Դ�趨�����������----------------------------------------------------
function ZLuaPetBedgeLives(pet_tid,origin)
		--[[
		age				LivesAttr[1] 			acuity 		LivesAttr[7]	
		life			LivesAttr[2]			stamina 	LivesAttr[8]	
		maxhunger	LivesAttr[3]			sawy 			LivesAttr[9] 
		curhunger	LivesAttr[4]			dowry 		LivesAttr[10]		
		maxhonor	LivesAttr[5] 			wisdom 		LivesAttr[11]	
		curhonor	LivesAttr[6]			cnr 			LivesAttr[12]
		--]]
 	if ZLuaPetBedgeExistInTmplIDs(pet_tid) == 0 then return end
	local AvailablePets=ZLuaAvailablePets()
	local ServerOrigins=ZLuaPetBedgeOrigins()
	local serverorigin = origin or ServerOrigins["drop"]
	local LivesAttr={}

	local AddLifeMulti=1							---//�������Դ��ͬ���ӵ�����Ӱ������
	
	if origin==ServerOrigins["gshop"] then 
		AddLifeMulti=1.2
	elseif 	origin==ServerOrigins["npc"] then
		AddLifeMulti=0.8
	end 
	if pet_tid==AvailablePets["S_luxueqi"].pet_tid or pet_tid==AvailablePets["S_biyao"].pet_tid then 		
	---//½ѩ�����ػ�/�����İ�֮��
		LivesAttr[1]=ZLuaChooseNormalNums(10,20,1)
		LivesAttr[2]=1200
		LivesAttr[3]=ZLuaChooseNormalNums(500,500,1)
		LivesAttr[4]=ZLuaChooseNormalNums(500,500,1)
		LivesAttr[5]=ZLuaChooseNormalNums(240,240,1)
		LivesAttr[6]=ZLuaChooseNormalNums(20,20,1)
		
		LivesAttr[7],LivesAttr[8],LivesAttr[9],LivesAttr[10],
		LivesAttr[11],LivesAttr[12]=ZLuaPetBedgeLivesAbility(pet_tid,origin)
	elseif pet_tid==AvailablePets["Q_heyangqingwa"].pet_tid or pet_tid==AvailablePets["Q_heyangyelang"].pet_tid then 		
	---//����ʳ���
		LivesAttr[1]=ZLuaChooseNormalNums(10,20,1)
		LivesAttr[2]=4320
		LivesAttr[3]=ZLuaChooseNormalNums(250,250,1)
		LivesAttr[4]=ZLuaChooseNormalNums(250,250,1)
		LivesAttr[5]=ZLuaChooseNormalNums(80,80,1)
		LivesAttr[6]=ZLuaChooseNormalNums(10,10,1)
		
		LivesAttr[7],LivesAttr[8],LivesAttr[9],LivesAttr[10],
		LivesAttr[11],LivesAttr[12]=ZLuaPetBedgeLivesAbility(pet_tid,origin)
	else
		LivesAttr[1]=ZLuaChooseNormalNums(10,20,1)
		LivesAttr[2]=ZLuaChooseNormalNums(8000*AddLifeMulti,10000*AddLifeMulti,1)
		LivesAttr[3]=ZLuaChooseNormalNums(500,500,1)
		LivesAttr[4]=ZLuaChooseNormalNums(500,500,1)
		LivesAttr[5]=ZLuaChooseNormalNums(240,240,1)
		LivesAttr[6]=ZLuaChooseNormalNums(20,20,1)
		
		LivesAttr[7],LivesAttr[8],LivesAttr[9],LivesAttr[10],
		LivesAttr[11],LivesAttr[12]=ZLuaPetBedgeLivesAbility(pet_tid,origin)
	end 
	return LivesAttr
end 
------���ݳ���id�趨�����������(��������ֵ����)----------------------------------------------------
function ZLuaPetBedgeLivesAbility(pet_tid,origin)
 	if ZLuaPetBedgeExistInTmplIDs(pet_tid) == 0 then return end
	local AvailablePets=ZLuaAvailablePets()
	local ServerOrigins=ZLuaPetBedgeOrigins()
	local serverorigin = origin or ServerOrigins["drop"]
	local Race=ZLuaPetBedgeRaceDesc()
	
	local pet,petrace
	petrace=Race["renzu"]
	
	for _,pet in pairs(AvailablePets) do
		if pet.pet_tid == pet_tid then 
			petrace=pet.race 
		end
	end
	local P_acuity,P_stamina,P_sawy,P_dowry,P_wisdom,P_cnr=0,0,0,0,0,0

	if petrace==Race["renzu"] then 					---//����
		P_acuity=ZLuaChooseNormalNums(5,15,1)
		P_stamina=0
		P_sawy=0
		P_dowry=ZLuaChooseNormalNums(5,15,1)
		P_wisdom=0
		P_cnr=ZLuaChooseNormalNums(15,25,1)
	elseif petrace==Race["yaozu"] then			---//����
		P_acuity=0
		P_stamina=0
		P_sawy=ZLuaChooseNormalNums(5,15,1)
		P_dowry=ZLuaChooseNormalNums(15,25,1)
		P_wisdom=ZLuaChooseNormalNums(5,15,1)
		P_cnr=0
	elseif petrace==Race["guizu"] then			---//����
		P_acuity=0
		P_stamina=ZLuaChooseNormalNums(5,15,1)
		P_sawy=ZLuaChooseNormalNums(15,25,1)
		P_dowry=ZLuaChooseNormalNums(5,15,1)
		P_wisdom=0
		P_cnr=0
	elseif petrace==Race["yuzu"] then				---//����
		P_acuity=ZLuaChooseNormalNums(15,25,1)
		P_stamina=0
		P_sawy=ZLuaChooseNormalNums(5,15,1)
		P_dowry=ZLuaChooseNormalNums(5,15,1)
		P_wisdom=0
		P_cnr=0
	elseif petrace==Race["meizu"] then			---//����
		P_acuity=ZLuaChooseNormalNums(5,15,1)
		P_stamina=0
		P_sawy=0
		P_dowry=ZLuaChooseNormalNums(15,25,1)
		P_wisdom=0
		P_cnr=0
	elseif petrace==Race["tianjiang"] then	---//�콫
		P_acuity=0
		P_stamina=ZLuaChooseNormalNums(5,15,1)
		P_sawy=0
		P_dowry=0
		P_wisdom=ZLuaChooseNormalNums(15,25,1)
		P_cnr=0
	elseif petrace==Race["xianling"] then		---//����
		P_acuity=ZLuaChooseNormalNums(3,15,1)
		P_stamina=ZLuaChooseNormalNums(3,15,1)
		P_sawy=ZLuaChooseNormalNums(3,15,1)
		P_dowry=ZLuaChooseNormalNums(3,15,1)
		P_wisdom=ZLuaChooseNormalNums(3,15,1)
		P_cnr=ZLuaChooseNormalNums(3,15,1)
	elseif petrace==Race["shanjing"] then		---//ɽ��
		P_acuity=0
		P_stamina=ZLuaChooseNormalNums(5,15,1)
		P_sawy=ZLuaChooseNormalNums(5,15,1)
		P_dowry=0
		P_wisdom=ZLuaChooseNormalNums(15,25,1)
		P_cnr=0
	elseif petrace==Race["yeshou"] then			---//Ұ��
		P_acuity=0
		P_stamina=ZLuaChooseNormalNums(15,25,1)
		P_sawy=ZLuaChooseNormalNums(5,15,1)
		P_dowry=0
		P_wisdom=0
		P_cnr=0
	elseif petrace==Race["yishou"] then			---//����
		P_acuity=0
		P_stamina=ZLuaChooseNormalNums(5,15,1)
		P_sawy=0
		P_dowry=0
		P_wisdom=ZLuaChooseNormalNums(5,15,1)
		P_cnr=ZLuaChooseNormalNums(15,25,1)
	elseif petrace==Race["shuizu"] then			---//ˮ��
		P_acuity=ZLuaChooseNormalNums(15,25,1)
		P_stamina=0
		P_sawy=0
		P_dowry=0
		P_wisdom=0
		P_cnr=ZLuaChooseNormalNums(5,15,1)
	elseif petrace==Race["chonggu"] then		---//���
		P_acuity=0
		P_stamina=0
		P_sawy=0
		P_dowry=0
		P_wisdom=ZLuaChooseNormalNums(5,15,1)
		P_cnr=ZLuaChooseNormalNums(15,25,1)
	elseif petrace==Race["huanling"] then		---//����
		P_acuity=ZLuaChooseNormalNums(5,15,1)
		P_stamina=0
		P_sawy=0
		P_dowry=ZLuaChooseNormalNums(15,25,1)
		P_wisdom=0
		P_cnr=ZLuaChooseNormalNums(5,15,1)
	elseif petrace==Race["siling"] then			---//����
		P_acuity=0
		P_stamina=ZLuaChooseNormalNums(5,15,1)
		P_sawy=0
		P_dowry=ZLuaChooseNormalNums(5,15,1)
		P_wisdom=ZLuaChooseNormalNums(15,25,1)
		P_cnr=0
	elseif petrace==Race["yuansu"] then			---//Ԫ��
		P_acuity=ZLuaChooseNormalNums(5,15,1)
		P_stamina=0
		P_sawy=ZLuaChooseNormalNums(15,25,1)
		P_dowry=0
		P_wisdom=0
		P_cnr=ZLuaChooseNormalNums(5,15,1)
	elseif petrace==Race["teshu"] then			---//����
		P_acuity=0
		P_stamina=0
		P_sawy=0
		P_dowry=0
		P_wisdom=0
		P_cnr=0
	end 	
	---//�������Գ���
	if pet_tid==AvailablePets["TestPet"].pet_tid then 
		P_acuity=80
		P_stamina=80
		P_sawy=80
		P_dowry=80
		P_wisdom=80
		P_cnr=80
	elseif pet_tid==AvailablePets["S_luxueqi"].pet_tid or pet_tid==AvailablePets["Q_heyangqingwa"].pet_tid 
			or pet_tid==AvailablePets["Q_heyangyelang"].pet_tid or pet_tid==AvailablePets["S_biyao"].pet_tid then 
		P_acuity=0
		P_stamina=0
		P_sawy=0
		P_dowry=0
		P_wisdom=0
		P_cnr=0
	end 
	return P_acuity,P_stamina,P_sawy,P_dowry,P_wisdom,P_cnr
end 
------------------------------------------------------------------------------------------
---���＼�ܴ��츳��ȡ�ļ�������(�����ڷ�����/ְҵ����)
function ZLuaPetBedgeSkillBenefitByTalenet(skill_id,talentslist,pet_level)
	if skill_id==0 or type(skill_id)~="number" then return 0 end 
		
	local SkillsBindingTalents={}
	local TalentsID={}
		TalentsID[1210]=1			---//�׻��ʡ�	����������ף��Ч����ǿ��	��������������Ч����ǿ
		TalentsID[1211]=2			---//�����ʡ�	����/����������ף��Ч����ǿ��	����/��������������Ч����ǿ
		TalentsID[1212]=3			---//��ڤ�ʡ�	�Ȼ�������Ч����ǿ��	��ʳ��/����������Ч����ǿ
		TalentsID[1213]=4			---//��Ѫ�ʡ�	����������ף��Ч����ǿ��	��Ѫ��ʧ������Ч����ǿ
		TalentsID[1214]=5			---//�����ʡ�	����������Ч����ǿ��	������/����������Ч����ǿ
		TalentsID[1215]=6			---//�����ʡ�	��˯������Ч����ǿ/��Ѫ�ظ��ࣻ	�������״̬������Ч����ǿ
		TalentsID[1216]=7			---//�����ʡ�	ѣ��������Ч����ǿ��	�¼�������Ч����ǿ
		TalentsID[1217]=8			---//�����ʡ�	������ʧ��/����������Ч����ǿ��	��������������Ч����ǿ
		TalentsID[1218]=9			---//̫���ʡ�	����������Ч����ǿ��	��е��/��ȡ������Ч����ǿ
		TalentsID[1219]=10		---//��ͨ�ʡ�	��Ѫ������ף��Ч����ǿ��	��Ѫ����������Ч����ǿ
		TalentsID[1220]=11		---//�����ʡ�	����������ף��Ч����ǿ��	��������������Ч����ǿ
		TalentsID[1221]=12		---//��Ӱ�ʡ�	����������ף��Ч����ǿ��	��������������Ч����ǿ
		TalentsID[1222]=13		---//�����ʡ�	����������ף��Ч����ǿ��	��������������Ч����ǿ
	
	---//�����6���츳Ӱ��,������-100����
	---//all the pet skills here
		SkillsBindingTalents[1399]={1213,-100,-100,-100,-100,-100}---//�ػ�<����>
		SkillsBindingTalents[1400]={1219,-100,-100,-100,-100,-100}---//�ȳ�<����>
		SkillsBindingTalents[1401]={1222,-100,-100,-100,-100,-100}---//��ҫ<����>
		SkillsBindingTalents[1402]={1210,-100,-100,-100,-100,-100}---//���<����>
		SkillsBindingTalents[1403]={1213,-100,-100,-100,-100,-100}---//���<����>
		SkillsBindingTalents[1404]={1216,-100,-100,-100,-100,-100}---//����<����>
		SkillsBindingTalents[5018]={1213,-100,-100,-100,-100,-100}---//����<����>
		SkillsBindingTalents[1405]={1210,-100,-100,-100,-100,-100}---//����<����>
		SkillsBindingTalents[1406]={1211,-100,-100,-100,-100,-100}---//����<����>
		SkillsBindingTalents[1407]={1222,-100,-100,-100,-100,-100}---//��ע<����>
		SkillsBindingTalents[1408]={1221,-100,-100,-100,-100,-100}---//����<����>
		SkillsBindingTalents[1409]={1221,-100,-100,-100,-100,-100}---//��Ӱ<����>
		SkillsBindingTalents[1410]={1212,-100,-100,-100,-100,-100}---//ˮ��<����>
		SkillsBindingTalents[5019]={1210,-100,-100,-100,-100,-100}---//�¶�<����>
		SkillsBindingTalents[1411]={1210,-100,-100,-100,-100,-100}---//â��<����>
		SkillsBindingTalents[1412]={1210,-100,-100,-100,-100,-100}---//ŭ��<����>
		SkillsBindingTalents[1413]={1222,-100,-100,-100,-100,-100}---//ȫ��<����>
		SkillsBindingTalents[1414]={1217,-100,-100,-100,-100,-100}---//˺��<����>
		SkillsBindingTalents[1415]={1210,-100,-100,-100,-100,-100}---//�̶�<����>
		SkillsBindingTalents[1416]={1212,-100,-100,-100,-100,-100}---//����<����>
		SkillsBindingTalents[5020]={1210,-100,-100,-100,-100,-100}---//����<����>
		SkillsBindingTalents[1417]={1219,-100,-100,-100,-100,-100}---//����<ľ��>
		SkillsBindingTalents[1418]={1213,-100,-100,-100,-100,-100}---//����<ľ��>
		SkillsBindingTalents[1419]={1222,-100,-100,-100,-100,-100}---//�ͻ�<ľ��>
		SkillsBindingTalents[1420]={1213,-100,-100,-100,-100,-100}---//����<ľ��>
		SkillsBindingTalents[1421]={1214,-100,-100,-100,-100,-100}---//�<ľ��>
		SkillsBindingTalents[1422]={1215,-100,-100,-100,-100,-100}---//ƣ��<ľ��>
		SkillsBindingTalents[5021]={1219,-100,-100,-100,-100,-100}---//��<ľ��>
		SkillsBindingTalents[1423]={1219,-100,-100,-100,-100,-100}---//��Ȫ<ˮ��>
		SkillsBindingTalents[1424]={1215,-100,-100,-100,-100,-100}---//����<ˮ��>
		SkillsBindingTalents[1425]={1222,-100,-100,-100,-100,-100}---//Ԥ��<ˮ��>
		SkillsBindingTalents[1426]={1217,-100,-100,-100,-100,-100}---//����<ˮ��>
		SkillsBindingTalents[1427]={1210,-100,-100,-100,-100,-100}---//����<ˮ��>
		SkillsBindingTalents[1428]={1217,-100,-100,-100,-100,-100}---//˼��<ˮ��>
		SkillsBindingTalents[5022]={1219,-100,-100,-100,-100,-100}---//�׺�<ˮ��>
		SkillsBindingTalents[1429]={1211,-100,-100,-100,-100,-100}---//���<����>
		SkillsBindingTalents[1430]={1210,-100,-100,-100,-100,-100}---//��ͨ<����>
		SkillsBindingTalents[1431]={1222,-100,-100,-100,-100,-100}---//����<����>
		SkillsBindingTalents[1432]={1220,-100,-100,-100,-100,-100}---//����<����>
		SkillsBindingTalents[1433]={1212,-100,-100,-100,-100,-100}---//���<����>
		SkillsBindingTalents[1434]={1213,-100,-100,-100,-100,-100}---//ȼ��<����>
		SkillsBindingTalents[5023]={1211,-100,-100,-100,-100,-100}---//��ӳ<����>
		SkillsBindingTalents[1435]={1220,-100,-100,-100,-100,-100}---//��ף<����>
		SkillsBindingTalents[1436]={1221,-100,-100,-100,-100,-100}---//����<����>
		SkillsBindingTalents[1437]={1222,-100,-100,-100,-100,-100}---//�˺�<����>
		SkillsBindingTalents[1438]={1214,-100,-100,-100,-100,-100}---//׷��<����>
		SkillsBindingTalents[1439]={1216,-100,-100,-100,-100,-100}---//����<����>
		SkillsBindingTalents[1440]={1214,-100,-100,-100,-100,-100}---//�ݵ�<����>
		SkillsBindingTalents[5024]={1220,-100,-100,-100,-100,-100}---//̩��<����>
		SkillsBindingTalents[1441]={1217,-100,-100,-100,-100,-100}---//����<�޺�>
		SkillsBindingTalents[1442]={1218,-100,-100,-100,-100,-100}---//����<�޺�>
		SkillsBindingTalents[1443]={1222,-100,-100,-100,-100,-100}---//����<�޺�>
		SkillsBindingTalents[1444]={1219,-100,-100,-100,-100,-100}---//����<�޺�>
		SkillsBindingTalents[1445]={1211,-100,-100,-100,-100,-100}---//����<�޺�>
		SkillsBindingTalents[1446]={1218,-100,-100,-100,-100,-100}---//��ʹ<�޺�>
		SkillsBindingTalents[5026]={1217,-100,-100,-100,-100,-100}---//����<�޺�>
		SkillsBindingTalents[1447]={1221,-100,-100,-100,-100,-100}---//����<�ƶ�>
		SkillsBindingTalents[1448]={1214,-100,-100,-100,-100,-100}---//����<�ƶ�>
		SkillsBindingTalents[1449]={1222,-100,-100,-100,-100,-100}---//����<�ƶ�>
		SkillsBindingTalents[1450]={1217,-100,-100,-100,-100,-100}---//����<�ƶ�>
		SkillsBindingTalents[1451]={1216,-100,-100,-100,-100,-100}---//���<�ƶ�>
		SkillsBindingTalents[1452]={1215,-100,-100,-100,-100,-100}---//��ã<�ƶ�>
		SkillsBindingTalents[5025]={1221,-100,-100,-100,-100,-100}---//����<�ƶ�>
		SkillsBindingTalents[1453]={1222,-100,-100,-100,-100,-100}---//����<ͨ��>
		SkillsBindingTalents[1454]={1222,-100,-100,-100,-100,-100}---//����<ͨ��>
		SkillsBindingTalents[1455]={1222,-100,-100,-100,-100,-100}---//����<ͨ��>
		SkillsBindingTalents[1456]={1222,-100,-100,-100,-100,-100}---//����<ͨ��>
		SkillsBindingTalents[1457]={1215,-100,-100,-100,-100,-100}---//����<ͨ��>
		SkillsBindingTalents[1458]={1218,-100,-100,-100,-100,-100}---//��ȡ<ͨ��>
		SkillsBindingTalents[5027]={1222,-100,-100,-100,-100,-100}---//ŭ��<ͨ��>
		SkillsBindingTalents[5028]={1222,-100,-100,-100,-100,-100}---//ŭ��<ͨ��>
		SkillsBindingTalents[5029]={1222,-100,-100,-100,-100,-100}---//ŭ��<ͨ��>
		SkillsBindingTalents[5030]={1222,-100,-100,-100,-100,-100}---//ŭ��<ͨ��>
		SkillsBindingTalents[5031]={1222,-100,-100,-100,-100,-100}---//ŭ��<ͨ��>
		SkillsBindingTalents[5032]={1222,-100,-100,-100,-100,-100}---//ŭ��<ͨ��>
		SkillsBindingTalents[5033]={1222,-100,-100,-100,-100,-100}---//ŭ��<ͨ��>
		SkillsBindingTalents[5034]={1222,-100,-100,-100,-100,-100}---//ŭ��<ͨ��>
		SkillsBindingTalents[5035]={1222,-100,-100,-100,-100,-100}---//ŭ��<ͨ��>
		SkillsBindingTalents[5036]={1222,-100,-100,-100,-100,-100}---//ŭ��<ͨ��>
		SkillsBindingTalents[5037]={1222,-100,-100,-100,-100,-100}---//ŭ��<ͨ��>
		SkillsBindingTalents[5038]={1222,-100,-100,-100,-100,-100}---//ŭ��<ͨ��>

	if type(SkillsBindingTalents[skill_id])~="table" then return 0 end 	
	
	local addskills=0
	for i=1,table.getn(SkillsBindingTalents[skill_id]) do 
		if SkillsBindingTalents[skill_id][i]~=-100 then 
		 	 if talentslist[TalentsID[SkillsBindingTalents[skill_id][i]]]==10 then 
		 	 		addskills=addskills+30
		 	 elseif talentslist[TalentsID[SkillsBindingTalents[skill_id][i]]]==5 then
		 			addskills=addskills+10
		 	 else 
			 		addskills=0
			 end 
		else 
		end 	
	end 
		return addskills	
end 
------------------------------------------------------------------------------------------
---���＼�ܴӵ�ǰ���ܶȻ�ȡ�ļ�������(�����ڷ�����/ְҵ����)
function ZLuaPetBedgeSkillBenefitByHonor(skillid,curhonor)
	if skillid==0 or type(skillid)~="number" then return 0 end 
	if type(skillid)~="number" then return 0 end 
	local addskills=0
	local honorclass={0,80,240,480,960,1800,3600,7200,14400,28800,57600,99999}
	
	for i=1,table.getn(honorclass)-1 do 
		if curhonor>honorclass[i] and curhonor<=honorclass[i+1] then 
			addskills=i
		end 
	end 
	---//return addskills	
	---//���ܶ�Ӱ�켼�ܼ�����ʱ������
	return 1
end
------------------------------------------------------------------------------------------
---���＼�ܴӵ�ǰ���ܶȻ�ȡ������һ��������һ���˺�����
function ZLuaPetBedgeCritBenefitByHonor(curhonor)
	local addcrit,addcritdmg=0,0
	local honorclass={0,80,240,480,960,1800,3600,7200,14400,28800,57600,99999}
	for i=1,table.getn(honorclass)-1 do 
		if curhonor>honorclass[i] and curhonor<=honorclass[i+1] then 
			addcrit=0.005*i
			addcritdmg=0.05*i
		end 
	end 
	return addcrit,addcritdmg
end
---��ilist�а���vlist�涨�ĸ���ѡȡnum������,ÿ������������maxsamcol��------------------
function ZLuaCheckOutNums(ilist,vlist,num,maxsamecol)
	if table.getn(ilist)~=table.getn(vlist) then return end
	if table.getn(ilist)<num then return end 
	
	local TheDesk={}	---�Ѿ���ѡȡ�������
	local TheHand={}	---���ص���������

	for i=1,num do
		TheDesk[i]=0
		TheHand[i]=0
	end 
	local findsamenum
	
	for j=1,num do 
			TheDesk[j]=ZPetGrade_Get_RanPoint(vlist)
			findsamenum=0
			for k=1,j do
					if TheDesk[k]==TheDesk[j] then 
						findsamenum=findsamenum+1
						if findsamenum>=maxsamecol then 
							vlist[TheDesk[j]]=0 
						end
					end
			end
			TheHand[j]=ilist[TheDesk[j]]
	end 
	return TheHand
end
---��һ����Ԫ��ƽ��ȡ��-------------------------------------------------------------------
function ZLuaChooseNormalNums(fromnum,endnum,mode)
	---//��ʼ��,������,�������ͣ�1����Ϊ���� 2��������
	if type(fromnum)~="number" or type(endnum)~="number" or fromnum>endnum or fromnum<0 then end
	fromnum=math.ceil(fromnum)
	endnum=math.ceil(endnum)
	
	if mode==nil then mode=1 end 
	
	local normalnum
	if mode==1 then
		normalnum=math.floor(math.random()*(endnum-fromnum))+1+fromnum
		if endnum==fromnum then normalnum=math.floor(endnum) end 
	else
		normalnum=math.random()*(endnum-fromnum)+1+fromnum
		if endnum==fromnum then normalnum=endnum end 
	end 
		return normalnum
end 
-----���ݳ���ļ��ܲ��뵽7�� �����ɼ��ܵȼ�(8/9/10/11�ֱ�Ϊ�ֻ�/�ǳ�/����/�հ׼���,��������)------
function ZLuaPetBedgeMakeSkillsTable(choosedskills,choosenum,maxskillslevel)
	local skills={}
	local skillslevel={}
	for i=1,7 do
		if i<=choosenum then 
				skills[i]=choosedskills[i]
				skillslevel[i]=1+math.floor(math.random()*maxskillslevel)
		else
				skills[i]=0
				skillslevel[i]=0
		end 
	end 
	return skills,skillslevel
end 
------------------------------------------------------------------------------------------