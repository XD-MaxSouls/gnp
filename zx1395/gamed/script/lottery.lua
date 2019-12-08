local lottery_template = {};

function AddLotteryTemplate(id, s1, c1)
	lottery_template[tonumber(id)] = {};
	lottery_template[tonumber(id)].Select = s1;
	lottery_template[tonumber(id)].Cashing = c1;
end

----���ּ�����̬��-------------------------------------------------------------------------------------------
function ZLottery_Chance_Norm(n1)
  local n1_size=table.getn(n1)
	local Total_Chance=0
	local i,k,m
	---�����
	for i=1,n1_size do
   		Total_Chance=n1[i]+Total_Chance          
	end
 	---���ɸ���������
	local nx={}
	for k=1,n1_size do
			if k==1 then 
				nx[1]=n1[k]
			else
		    nx[k]=n1[k]+nx[k-1]              
		  end
	end
	---��������׼���ĸ���������
	local n2={}
  for m=1,n1_size do
   		if Total_Chance==0 then                 ---����ȫ0���еĴ�������{1,0,0...}
		 		n2[m]=0
				n2[1]=1
			else
				n2[m]=nx[m]/ Total_Chance
			end
	end
	---����һ���������� 
  ---ZLuaTal_Special_Print(n2)   				---$$$$������$$$$-----
	return n2
end
-------------------------------------------------------------------------------------------------------------
----���ճ��ָ������Ӧ��ѡȡ��λ��---------------------------------------------------------------------------
function ZLottery_Get_RanPoint(s1)
	local js,ron1
	ron1= math.random()                
	---print("---------------------------")     ---$$$$������$$$$-----
	---print("Now the random Num is:",ron1) 	---$$$$������$$$$-----
  local p1=ZLottery_Chance_Norm(s1)
	for js=1,table.getn(p1) do
          if ron1<=p1[js] then 
		    	---print("So We Choose:",js) 		---$$$$������$$$$-----
    	  		return js
		  		end
	end
	return 1
end
-------------------------------------------------------------------------------------------------------------
---�ҵ�S1��a���ֵĸ���---------------------------------------------------------------------------------------
function ZLottery_FindSameNum(s1,a)
	local i,j
	j=0
	for i=1,table.getn(s1) do
		if s1[i]==a then 
		j=j+1
		end 
	end 
	return j	
end 
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType6576SelectNumber(list, max_count) --- Lottery Used@20090703(����_��ľ����)
	local NumList={1,2,3,4}
	local NumChance={360,360,360,180}
	return NumList[ZLottery_Get_RanPoint(NumChance)]
end
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType7916SelectNumber(list, max_count) --- Lottery Used@20070706(����_�����)
	local NumList={1,2,3}
	local NumChance={120,50,830}
	return NumList[ZLottery_Get_RanPoint(NumChance)]
end
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType10484SelectNumber(list, max_count) --- Lottery Used@20070723(�ɹ�����)
	local NumList={1,2}
	local NumChance={140,860}
	return NumList[ZLottery_Get_RanPoint(NumChance)]
end
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType10722SelectNumber(list, max_count) --- Lottery Used@20101118(����_���Ԫ��)
	local NumList={1,2,3,4}
	local NumChance={1494,1710,1000,5796}
	return NumList[ZLottery_Get_RanPoint(NumChance)]
end
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType11537SelectNumber(list, max_count) --- Lottery Used@20070924(����_����֮��)
	local NumList={1,2,3,4}
	local NumChance={180,10,150,660}
	return NumList[ZLottery_Get_RanPoint(NumChance)]
end
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType11742SelectNumber(list, max_count) --- Lottery Used@20071010(����ɽ���ȴ����)
	local NumList={1,2,3,4}
	local NumChance={100,0,0,0}
	return NumList[ZLottery_Get_RanPoint(NumChance)]
end
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType11743SelectNumber(list, max_count) --- Lottery Used@20071010(�����򶾶������)
	local NumList={1,2,3,4}
	local NumChance={100,0,0,0}
	return NumList[ZLottery_Get_RanPoint(NumChance)]
end
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType12006SelectNumber(list, max_count) --- Lottery Used@20071106(����_���Ա���)
	local NumList={1,2,3,4}
	local NumChance={100,40,100,760}
	return NumList[ZLottery_Get_RanPoint(NumChance)]
end
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType13318SelectNumber(list, max_count) --- Lottery Used@2009-12-21(��������)
	local NumList={1,2,3,4}
	local NumChance={40,240,83,637}
	return NumList[ZLottery_Get_RanPoint(NumChance)]
end
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType13319SelectNumber(list, max_count) --- Lottery Used@20071123(Ǭ���ݱ�)
	local NumList={1,2,3,4}
	local NumChance={159,50,105,686}
	return NumList[ZLottery_Get_RanPoint(NumChance)]
end
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryTypeCharmSeason1SelectNumber(list, max_count,id) --- Lottery Used@20071123(��һ������������)
	local NumList={1,2,3,4}
	local NumChance={100,0,0,0}
	return NumList[ZLottery_Get_RanPoint(NumChance)]
end
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType13377SelectNumber(list, max_count) --- Lottery Used@20071123(��������ӳ�������������)
	local NumList={1,2,3,4}
	local NumChance={40,240,83,637}
	return NumList[ZLottery_Get_RanPoint(NumChance)]
end
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType13593SelectNumber(list, max_count) --- Lottery Used@20071218(�¹ⱦ��)
	local NumList={1,2,3,4}
	local NumChance={145,312,480,63}
	return NumList[ZLottery_Get_RanPoint(NumChance)]
end
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType13905SelectNumber(list, max_count) --- Lottery Used@20090728(����_��ͼ��)
	local NumList={1,2,3,4}
	local NumChance={1443,4643,2000,1914}
	return NumList[ZLottery_Get_RanPoint(NumChance)]
end
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType15677SelectNumber(list, max_count) --- Lottery Used@20080222(ʨ��֮��)
	local NumList={1,2,3,4}
	local NumChance={1494,1710,1000,5796}
	return NumList[ZLottery_Get_RanPoint(NumChance)]
end
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType15866SelectNumber(list, max_count) --- Lottery Used@20090915(����_�׹�ī��)
	local NumList={1,2,3,4}
	local NumChance={1260,2155,2934,3651}
	return NumList[ZLottery_Get_RanPoint(NumChance)]
end
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType16550SelectNumber(list, max_count) --- Lottery Used@20091019(����_��¹����)
	local NumList={1,2,3,4}
	local NumChance={1260,2155,2934,3651}
	return NumList[ZLottery_Get_RanPoint(NumChance)]
end
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType18283SelectNumber(list, max_count) --- Lottery Used@20080509(����_�������)
	local NumList={1,2,3,4}
	local NumChance={1260,3550,3300,1890}
	return NumList[ZLottery_Get_RanPoint(NumChance)]
end
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType18799SelectNumber(list, max_count) --- Lottery Used@20091120(����_�����쾧)
	local NumList={1,2,3,4}
	local NumChance={2000,2160,3000,2840}
	return NumList[ZLottery_Get_RanPoint(NumChance)]
end
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType18890SelectNumber(list, max_count) --- Lottery Used@20090915(����_����ʥ��)
	local NumList={1,2,3,4}
	local NumChance={1494,2160,3000,3346}
	return NumList[ZLottery_Get_RanPoint(NumChance)]
end
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryTypeGoldSeason1SelectNumber(list, max_count) --- Lottery Used@20080704(��һ��ձ���)
	local NumList={1,2,3,4}
	local NumChance={100,0,0,0}
	return NumList[ZLottery_Get_RanPoint(NumChance)]
end
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryTypeItemSeason1SelectNumber(list, max_count) --- Lottery Used@20080708(װ����������)
	local NumList={1,2,3,4}
	local NumChance={100,0,0,0}
	return NumList[ZLottery_Get_RanPoint(NumChance)]
end
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType19125SelectNumber(list, max_count) 			--- Lottery Used@20100412(����_��������)
	local NumList={1,2,3,4}
	local NumChance={1450,3110,3000,2440}
	return NumList[ZLottery_Get_RanPoint(NumChance)]
end
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType19297SelectNumber(list, max_count) 			--- Lottery Used@20080730(����_�ƹ����)
	local NumList={1,2,3,4}
	local NumChance={1450,2470,3000,3080}
	return NumList[ZLottery_Get_RanPoint(NumChance)]
end
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType19434SelectNumber(list, max_count) 			--- Lottery Used@20100122(����_������ͼ)
	local NumList={1,2,3,4}
	local NumChance={1260,2470,3000,3270}
	return NumList[ZLottery_Get_RanPoint(NumChance)]
end
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType19558SelectNumber(list, max_count) 			--- Lottery Used@20080902(����֮��)
	local NumList={1,2,3,4}
	local NumChance={1260,2470,3000,3270}
	return NumList[ZLottery_Get_RanPoint(NumChance)]
end
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryTypeGoldSeason2SelectNumber(list, max_count) --- Lottery Used@20080812(��һ��ձ���/���＼����)
	local NumList={1,2,3,4}
	local NumChance={100,0,0,0}
	return NumList[ZLottery_Get_RanPoint(NumChance)]
end
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType19713SelectNumber(list, max_count) 			--- Lottery Used@20100225(����_����֮��)
	local NumList={1,2,3,4}
	local NumChance={1260,1920,3000,3820}
	return NumList[ZLottery_Get_RanPoint(NumChance)]
end
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType20097SelectNumber(list, max_count) 			--- Lottery Used@20080930(08������������)
	local NumList={1,2,3,4}
	local NumChance={1150,3280,3000,2570}
	return NumList[ZLottery_Get_RanPoint(NumChance)]
end
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType20109SelectNumber(list, max_count) 			--- Lottery Used@20080930(201012����_�������)
	local NumList={1,2,3,4}
	local NumChance={1450,1000,3000,4550}
	return NumList[ZLottery_Get_RanPoint(NumChance)]
end
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType20284SelectNumber(list, max_count) 			--- Lottery Used@2009-12-21(����_����ӡ)
	local NumList={1,2,3,4}
	local NumChance={1590,3420,3000,1990}
	return NumList[ZLottery_Get_RanPoint(NumChance)]
end
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType20480SelectNumber(list, max_count)			--- Lottery Used@20081022A(��ȸ��)
	local NumList={1,2,3,4}
	local NumChance={1260,1920,3000,3820}
	return NumList[ZLottery_Get_RanPoint(NumChance)]
end
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType20482SelectNumber(list, max_count)			--- Lottery Used@20081022B(���ʹž�)
	local NumList={1,2,3,4}
	local NumChance={1700,2500,3300,2500}
	return NumList[ZLottery_Get_RanPoint(NumChance)]
end
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType20460SelectNumber(list, max_count)			--- Lottery Used@20081106(��������)
	local NumList={1,2,3,4}
	local NumChance={20,20,30,30}
	return NumList[ZLottery_Get_RanPoint(NumChance)]
end
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType21194SelectNumber(list, max_count)			--- Lottery Used@20081113(�޹���ϻ)
	local NumList={1,2,3,4}
	local NumChance={126,247,300,327}
	return NumList[ZLottery_Get_RanPoint(NumChance)]
end
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType21697SelectNumber(list, max_count)			--- Lottery Used@20081201(������ʯ)
	local NumList={1,2,3,4}
	local NumChance={171,311,300,218}
	return NumList[ZLottery_Get_RanPoint(NumChance)]
end
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType21752SelectNumber(list, max_count)			--- Lottery Used@20081202(�����ƪ/ѩ��������Ҳ�Ʊ)
	local NumList={1,2,3,4}
	local NumChance={126,311,300,263}
	return NumList[ZLottery_Get_RanPoint(NumChance)]
end
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType22126SelectNumber(list, max_count)			--- Lottery Used@20081221(��ѩ���)
	local NumList={1,2,3,4}
	local NumChance={126,247,300,327}
	return NumList[ZLottery_Get_RanPoint(NumChance)]
end
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType22127SelectNumber(list, max_count)			--- Lottery Used@20081230(�׹�ϻ��)
	local NumList={1,2,3,4}
	local NumChance={145,192,300,363}
	return NumList[ZLottery_Get_RanPoint(NumChance)]
end
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryTypeItemSeason2SelectNumber(list, max_count) --- Lottery Used@20090113(09��������Ҳ�Ʊ)
	local NumList={1,2,3,4}
--local NumChance={171,381,255,193}
	local NumChance={285,255,381,79}
	return NumList[ZLottery_Get_RanPoint(NumChance)]
end
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType23162SelectNumber(list, max_count)			--- Lottery Used@20100713(����_����:����¿)
	local PriceChance = {25,450,4000}																						-- һ�����Ƚ�����(��λ:���֮)
	PriceChance[4] = 10000 - PriceChance[1] - PriceChance[2] - PriceChance[3]		--     �ĵȽ�����(��λ:���֮)
	
	local subChance = {}
	local subSum = {}
	subChance[1] = {100}								-- һ�Ƚ��ڲ���Ը���(1��)
	subChance[2] = {2,1,1,1,1,1,2}			-- ���Ƚ��ڲ���Ը���(3�ţ�5�ţ�7�ţ�9�ţ�11�ţ�13�ţ�15��)
	subChance[3] = {25,25,25,25}				-- ���Ƚ��ڲ���Ը���(4�ţ�6�ţ�12�ţ�14��)
	subChance[4] = {2,5,5,8}						-- �ĵȽ��ڲ���Ը���(2�ţ�8�ţ�10�ţ�16��)

	for j=1,4 do
		subSum[j] = 0
		for i,_ in pairs(subChance[j]) do
			subSum[j] = subSum[j] + subChance[j][i]
		end
	end
	
	local NumList = {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16}
	local NumChance =
	{
		PriceChance[1], 													PriceChance[4]*subChance[4][1]/subSum[4], 
		PriceChance[2]*subChance[2][1]/subSum[2], PriceChance[3]*subChance[3][1]/subSum[3],
		PriceChance[2]*subChance[2][2]/subSum[2], PriceChance[3]*subChance[3][2]/subSum[3], 
		PriceChance[2]*subChance[2][3]/subSum[2], PriceChance[4]*subChance[4][2]/subSum[4],
		PriceChance[2]*subChance[2][4]/subSum[2], PriceChance[4]*subChance[4][3]/subSum[4], 
		PriceChance[2]*subChance[2][5]/subSum[2], PriceChance[3]*subChance[3][3]/subSum[3],
		PriceChance[2]*subChance[2][6]/subSum[2], PriceChance[3]*subChance[3][4]/subSum[3], 
		PriceChance[2]*subChance[2][7]/subSum[2], PriceChance[4]*subChance[4][4]/subSum[4],
	}
	return NumList[ZLottery_Get_RanPoint(NumChance)]
end
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType23018SelectNumber(list, max_count) --- Lottery Used@20090213(09��3������Ҳ�Ʊ����ͭ����)
	local NumList={1,2,3,4}
	local NumChance={21,42,30,7}
	return NumList[ZLottery_Get_RanPoint(NumChance)]
end
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType23295SelectNumber(list, max_count) --- Lottery Used@20090304(09��3�³����Ʊ�������ر�)
	local NumList={1,2,3,4}
	local NumChance={10,42,30,18}
	return NumList[ZLottery_Get_RanPoint(NumChance)]
end
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType23212SelectNumber(list, max_count)			--- Lottery Used@20091130(����_����:ʥ������)
	local PriceChance = {10,250,4000}																						-- һ�����Ƚ�����(��λ:���֮)
	PriceChance[4] = 10000 - PriceChance[1] - PriceChance[2] - PriceChance[3]		--     �ĵȽ�����(��λ:���֮)
	
	local subChance = {}
	local subSum = {}
	subChance[1] = {10}												-- һ�Ƚ��ڲ���Ը���(1��)
	subChance[2] = {100,50,100}								-- ���Ƚ��ڲ���Ը���(5�ţ�9�ţ�13��)
	subChance[3] = {1000,1000,1000,1000}			-- ���Ƚ��ڲ���Ը���(3�ţ�7�ţ�11�ţ�15��)
	subChance[4] = {25,10,10,25,25,40,40,25}	-- �ĵȽ��ڲ���Ը���(2,4,6,8,10,12,14,16)

	for j=1,4 do
		subSum[j] = 0
		for i,_ in pairs(subChance[j]) do
			subSum[j] = subSum[j] + subChance[j][i]
		end
	end
	
	local NumList = {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16}
	local NumChance =
	{
		PriceChance[1], 													PriceChance[4]*subChance[4][1]/subSum[4], PriceChance[3]*subChance[3][1]/subSum[3], PriceChance[4]*subChance[4][2]/subSum[4],
		PriceChance[2]*subChance[2][1]/subSum[2], PriceChance[4]*subChance[4][3]/subSum[4], PriceChance[3]*subChance[3][2]/subSum[3], PriceChance[4]*subChance[4][4]/subSum[4],
		PriceChance[2]*subChance[2][2]/subSum[2], PriceChance[4]*subChance[4][5]/subSum[4], PriceChance[3]*subChance[3][3]/subSum[3], PriceChance[4]*subChance[4][6]/subSum[4],
		PriceChance[2]*subChance[2][3]/subSum[2], PriceChance[4]*subChance[4][7]/subSum[4], PriceChance[3]*subChance[3][4]/subSum[3], PriceChance[4]*subChance[4][8]/subSum[4],
	}
	return NumList[ZLottery_Get_RanPoint(NumChance)]
end
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType23336SelectNumber(list, max_count)			--- Lottery Used@20100817(����_����:���ܽ�֦)
	local PriceChance = {20,100,3300}																						-- һ�����Ƚ�����(��λ:���֮)
	PriceChance[4] = 10000 - PriceChance[1] - PriceChance[2] - PriceChance[3]		--     �ĵȽ�����(��λ:���֮)
	
	local subChance = {}
	local subSum = {}
	subChance[1] = {10,10}										-- һ�Ƚ��ڲ���Ը���(1�ţ�9��)
	subChance[2] = {40,60}										-- ���Ƚ��ڲ���Ը���(5�ţ�13��)
	subChance[3] = {13,20,13,20}							-- ���Ƚ��ڲ���Ը���(3�ţ�7�ţ�11�ţ�15��)
	subChance[4] = {25,10,10,25,25,40,40,25}	-- �ĵȽ��ڲ���Ը���(2,4,6,8,10,12,14,16)

	for j=1,4 do
		subSum[j] = 0
		for i,_ in pairs(subChance[j]) do
			subSum[j] = subSum[j] + subChance[j][i]
		end
	end
	
	local NumList = {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16}
	local NumChance =
	{
		PriceChance[1]*subChance[1][1]/subSum[1], PriceChance[4]*subChance[4][1]/subSum[4], PriceChance[3]*subChance[3][1]/subSum[3], PriceChance[4]*subChance[4][2]/subSum[4],
		PriceChance[2]*subChance[2][1]/subSum[2], PriceChance[4]*subChance[4][3]/subSum[4], PriceChance[3]*subChance[3][2]/subSum[3], PriceChance[4]*subChance[4][4]/subSum[4],
		PriceChance[1]*subChance[1][2]/subSum[1], PriceChance[4]*subChance[4][5]/subSum[4], PriceChance[3]*subChance[3][3]/subSum[3], PriceChance[4]*subChance[4][6]/subSum[4],
		PriceChance[2]*subChance[2][2]/subSum[2], PriceChance[4]*subChance[4][7]/subSum[4], PriceChance[3]*subChance[3][4]/subSum[3], PriceChance[4]*subChance[4][8]/subSum[4],
	}
	return NumList[ZLottery_Get_RanPoint(NumChance)]
end
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType23363SelectNumber(list, max_count)			--- Lottery Used@20090318(����:������ƪ)
	local PriceChance = {20,100,4000}																						-- һ�����Ƚ�����(��λ:���֮)
	PriceChance[4] = 10000 - PriceChance[1] - PriceChance[2] - PriceChance[3]		--     �ĵȽ�����(��λ:���֮)
	
	local subChance = {}
	local subSum = {}
	subChance[1] = {10,10}										-- һ�Ƚ��ڲ���Ը���(1�ţ�9��)
	subChance[2] = {40,60}										-- ���Ƚ��ڲ���Ը���(5�ţ�13��)
	subChance[3] = {1000,1000,1000,1000}			-- ���Ƚ��ڲ���Ը���(3�ţ�7�ţ�11�ţ�15��)
	subChance[4] = {25,10,10,25,25,40,40,25}	-- �ĵȽ��ڲ���Ը���(2,4,6,8,10,12,14,16)

	for j=1,4 do
		subSum[j] = 0
		for i,_ in pairs(subChance[j]) do
			subSum[j] = subSum[j] + subChance[j][i]
		end
	end
	
	local NumList = {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16}
	local NumChance =
	{
		PriceChance[1]*subChance[1][1]/subSum[1], PriceChance[4]*subChance[4][1]/subSum[4], PriceChance[3]*subChance[3][1]/subSum[3], PriceChance[4]*subChance[4][2]/subSum[4],
		PriceChance[2]*subChance[2][1]/subSum[2], PriceChance[4]*subChance[4][3]/subSum[4], PriceChance[3]*subChance[3][2]/subSum[3], PriceChance[4]*subChance[4][4]/subSum[4],
		PriceChance[1]*subChance[1][2]/subSum[1], PriceChance[4]*subChance[4][5]/subSum[4], PriceChance[3]*subChance[3][3]/subSum[3], PriceChance[4]*subChance[4][6]/subSum[4],
		PriceChance[2]*subChance[2][2]/subSum[2], PriceChance[4]*subChance[4][7]/subSum[4], PriceChance[3]*subChance[3][4]/subSum[3], PriceChance[4]*subChance[4][8]/subSum[4],
	}
	return NumList[ZLottery_Get_RanPoint(NumChance)]
end
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType23422SelectNumber(list, max_count)			--- Lottery Used@20100329(����_����:���Ļ�ʯ)
	local PriceChance = {20,100,4000}																						-- һ�����Ƚ�����(��λ:���֮)
	PriceChance[4] = 10000 - PriceChance[1] - PriceChance[2] - PriceChance[3]		--     �ĵȽ�����(��λ:���֮)
	
	local subChance = {}
	local subSum = {}
	subChance[1] = {10}												-- һ�Ƚ��ڲ���Ը���(1��)
	subChance[2] = {33,33,33}									-- ���Ƚ��ڲ���Ը���(5�ţ�9�ţ�13��)
	subChance[3] = {1000,1000,1000,1000}			-- ���Ƚ��ڲ���Ը���(3�ţ�7�ţ�11�ţ�15��)
	subChance[4] = {25,10,10,25,25,40,40,25}	-- �ĵȽ��ڲ���Ը���(2,4,6,8,10,12,14,16)

	for j=1,4 do
		subSum[j] = 0
		for i,_ in pairs(subChance[j]) do
			subSum[j] = subSum[j] + subChance[j][i]
		end
	end
	
	local NumList = {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16}
	local NumChance =
	{
		PriceChance[1]*subChance[1][1]/subSum[1], PriceChance[4]*subChance[4][1]/subSum[4], PriceChance[3]*subChance[3][1]/subSum[3], PriceChance[4]*subChance[4][2]/subSum[4],
		PriceChance[2]*subChance[2][1]/subSum[2], PriceChance[4]*subChance[4][3]/subSum[4], PriceChance[3]*subChance[3][2]/subSum[3], PriceChance[4]*subChance[4][4]/subSum[4],
		PriceChance[2]*subChance[2][2]/subSum[2], PriceChance[4]*subChance[4][5]/subSum[4], PriceChance[3]*subChance[3][3]/subSum[3], PriceChance[4]*subChance[4][6]/subSum[4],
		PriceChance[2]*subChance[2][3]/subSum[2], PriceChance[4]*subChance[4][7]/subSum[4], PriceChance[3]*subChance[3][4]/subSum[3], PriceChance[4]*subChance[4][8]/subSum[4],
	}
	return NumList[ZLottery_Get_RanPoint(NumChance)]
end
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType23423SelectNumber(list, max_count) --- Lottery Used@20090326(09��3�������Ǹ�����Ʊ�������ر�)
	local NumList={1,2,3,4}
	local NumChance={3684,3684,1000,1632}
	return NumList[ZLottery_Get_RanPoint(NumChance)]
end
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType24343SelectNumber(list, max_count)			--- Lottery Used@20090211(�����ʯ:���)
	local PriceChance = {25,450,4000}																						-- һ�����Ƚ�����(��λ:���֮)
	PriceChance[4] = 10000 - PriceChance[1] - PriceChance[2] - PriceChance[3]		--     �ĵȽ�����(��λ:���֮)
	
	local subChance = {}
	local subSum = {}
	subChance[1] = {100}								-- һ�Ƚ��ڲ���Ը���(1��)
	subChance[2] = {2,1,1,1,1,1,2}			-- ���Ƚ��ڲ���Ը���(3�ţ�5�ţ�7�ţ�9�ţ�11�ţ�13�ţ�15��)
	subChance[3] = {25,25,25,25}				-- ���Ƚ��ڲ���Ը���(4�ţ�6�ţ�12�ţ�14��)
	subChance[4] = {2,5,5,8}						-- �ĵȽ��ڲ���Ը���(2�ţ�8�ţ�10�ţ�16��)

	for j=1,4 do
		subSum[j] = 0
		for i,_ in pairs(subChance[j]) do
			subSum[j] = subSum[j] + subChance[j][i]
		end
	end
	
	local NumList = {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16}
	local NumChance =
	{
		PriceChance[1], 													PriceChance[4]*subChance[4][1]/subSum[4], 
		PriceChance[2]*subChance[2][1]/subSum[2], PriceChance[3]*subChance[3][1]/subSum[3],
		PriceChance[2]*subChance[2][2]/subSum[2], PriceChance[3]*subChance[3][2]/subSum[3], 
		PriceChance[2]*subChance[2][3]/subSum[2], PriceChance[4]*subChance[4][2]/subSum[4],
		PriceChance[2]*subChance[2][4]/subSum[2], PriceChance[4]*subChance[4][3]/subSum[4], 
		PriceChance[2]*subChance[2][5]/subSum[2], PriceChance[3]*subChance[3][3]/subSum[3],
		PriceChance[2]*subChance[2][6]/subSum[2], PriceChance[3]*subChance[3][4]/subSum[3], 
		PriceChance[2]*subChance[2][7]/subSum[2], PriceChance[4]*subChance[4][4]/subSum[4],
	}
	return NumList[ZLottery_Get_RanPoint(NumChance)]
end
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType24344SelectNumber(list, max_count) 			--- Lottery Used@20090506(09����������Ҳ�Ʊ)
	local NumList={1,2,3,4}
	local NumChance={1150,3280,3000,2570}
	return NumList[ZLottery_Get_RanPoint(NumChance)]
end
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType24993SelectNumber(list, max_count)			--- Lottery Used@20090518(���޽���777)
	local NumList={1,2,3,4}
	local NumChance={126,216,300,358}
	return NumList[ZLottery_Get_RanPoint(NumChance)]
end
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType24998SelectNumber(list, max_count)			--- Lottery Used@20090518(���챦¼777)
	local NumList={1,2,3,4}
	local NumChance={126,216,330,328}
	return NumList[ZLottery_Get_RanPoint(NumChance)]
end
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType33055SelectNumber(list, max_count) --- Lottery Used@20091222(����_2009ʥ������)
	local NumList={1,2,3,4}
	local NumChance={100,0,0,0}
	return NumList[ZLottery_Get_RanPoint(NumChance)]
end
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType24999SelectNumber(list, max_count)			--- Lottery Used@20090518(���޽�������)
	local PriceChance = {200,1008,43625}																						-- һ�����Ƚ�����(��λ:���֮)
	PriceChance[4] = 100000 - PriceChance[1] - PriceChance[2] - PriceChance[3]		--     �ĵȽ�����(��λ:���֮)
	
	local subChance = {}
	local subSum = {}
	subChance[1] = {100}												-- һ�Ƚ��ڲ���Ը���(1��)
	subChance[2] = {33,33,33}									-- ���Ƚ��ڲ���Ը���(5�ţ�9�ţ�13��)
	subChance[3] = {25,25,25,25}			-- ���Ƚ��ڲ���Ը���(3�ţ�7�ţ�11�ţ�15��)
	subChance[4] = {25,10,10,25,25,40,40,25}	-- �ĵȽ��ڲ���Ը���(2,4,6,8,10,12,14,16)

	for j=1,4 do
		subSum[j] = 0
		for i,_ in pairs(subChance[j]) do
			subSum[j] = subSum[j] + subChance[j][i]
		end
	end
	
	local NumList = {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16}
	local NumChance =
	{
		PriceChance[1]*subChance[1][1]/subSum[1], PriceChance[4]*subChance[4][1]/subSum[4], PriceChance[3]*subChance[3][1]/subSum[3], PriceChance[4]*subChance[4][2]/subSum[4],
		PriceChance[2]*subChance[2][1]/subSum[2], PriceChance[4]*subChance[4][3]/subSum[4], PriceChance[3]*subChance[3][2]/subSum[3], PriceChance[4]*subChance[4][4]/subSum[4],
		PriceChance[2]*subChance[2][2]/subSum[2], PriceChance[4]*subChance[4][5]/subSum[4], PriceChance[3]*subChance[3][3]/subSum[3], PriceChance[4]*subChance[4][6]/subSum[4],
		PriceChance[2]*subChance[2][3]/subSum[2], PriceChance[4]*subChance[4][7]/subSum[4], PriceChance[3]*subChance[3][4]/subSum[3], PriceChance[4]*subChance[4][8]/subSum[4],
	}
	return NumList[ZLottery_Get_RanPoint(NumChance)]
end
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType34125SelectNumber(list, max_count)										--- Lottery Used@20100312(����_������ϻ)
	local PriceChance = {25,250,2000}																						-- һ�����Ƚ�����(��λ:���֮)
	PriceChance[4] = 10000 - PriceChance[1] - PriceChance[2] - PriceChance[3]		--     �ĵȽ�����(��λ:���֮)
	
	local subChance = {}
	local subSum = {}
	subChance[1] = {10,15}											-- һ�Ƚ��ڲ���Ը���(1�ţ�9��)
	subChance[2] = {150,100}										-- ���Ƚ��ڲ���Ը���(5�ţ�13��)
	subChance[3] = {5,15,15,5}									-- ���Ƚ��ڲ���Ը���(3�ţ�7�ţ�11�ţ�15��)
	subChance[4] = {50,40,10,50,50,10,40,50}		-- �ĵȽ��ڲ���Ը���(2,4,6,8,10,12,14,16)

	for j=1,4 do
		subSum[j] = 0
		for i,_ in pairs(subChance[j]) do
			subSum[j] = subSum[j] + subChance[j][i]
		end
	end
	
	local NumList = {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16}
	local NumChance =
	{
		PriceChance[1]*subChance[1][1]/subSum[1], PriceChance[4]*subChance[4][1]/subSum[4], PriceChance[3]*subChance[3][1]/subSum[3], PriceChance[4]*subChance[4][2]/subSum[4],
		PriceChance[2]*subChance[2][1]/subSum[2], PriceChance[4]*subChance[4][3]/subSum[4], PriceChance[3]*subChance[3][2]/subSum[3], PriceChance[4]*subChance[4][4]/subSum[4],
		PriceChance[1]*subChance[1][2]/subSum[1], PriceChance[4]*subChance[4][5]/subSum[4], PriceChance[3]*subChance[3][3]/subSum[3], PriceChance[4]*subChance[4][6]/subSum[4],
		PriceChance[2]*subChance[2][2]/subSum[2], PriceChance[4]*subChance[4][7]/subSum[4], PriceChance[3]*subChance[3][4]/subSum[3], PriceChance[4]*subChance[4][8]/subSum[4],
	}
	return NumList[ZLottery_Get_RanPoint(NumChance)]
end
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType25418SelectNumber(list, max_count)			--- Lottery Used@20100504(����_��Į��ɳ)
	local PriceChance = {20,100,4000}																						-- һ�����Ƚ�����(��λ:���֮)
	PriceChance[4] = 10000 - PriceChance[1] - PriceChance[2] - PriceChance[3]		--     �ĵȽ�����(��λ:���֮)
	
	local subChance = {}
	local subSum = {}
	subChance[1] = {20}												-- һ�Ƚ��ڲ���Ը���(1��)
	subChance[2] = {33,33,33}									-- ���Ƚ��ڲ���Ը���(5�ţ�9�ţ�13��)
	subChance[3] = {1000,1000,1000,1000}			-- ���Ƚ��ڲ���Ը���(3�ţ�7�ţ�11�ţ�15��)
	subChance[4] = {25,10,10,25,25,40,40,25}	-- �ĵȽ��ڲ���Ը���(2,4,6,8,10,12,14,16)

	for j=1,4 do
		subSum[j] = 0
		for i,_ in pairs(subChance[j]) do
			subSum[j] = subSum[j] + subChance[j][i]
		end
	end
	
	local NumList = {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16}
	local NumChance =
	{
		PriceChance[1], 													PriceChance[4]*subChance[4][1]/subSum[4], PriceChance[3]*subChance[3][1]/subSum[3], PriceChance[4]*subChance[4][2]/subSum[4],
		PriceChance[2]*subChance[2][1]/subSum[2], PriceChance[4]*subChance[4][3]/subSum[4], PriceChance[3]*subChance[3][2]/subSum[3], PriceChance[4]*subChance[4][4]/subSum[4],
		PriceChance[2]*subChance[2][2]/subSum[2], PriceChance[4]*subChance[4][5]/subSum[4], PriceChance[3]*subChance[3][3]/subSum[3], PriceChance[4]*subChance[4][6]/subSum[4],
		PriceChance[2]*subChance[2][3]/subSum[2], PriceChance[4]*subChance[4][7]/subSum[4], PriceChance[3]*subChance[3][4]/subSum[3], PriceChance[4]*subChance[4][8]/subSum[4],
	}
	return NumList[ZLottery_Get_RanPoint(NumChance)]
end
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType25305SelectNumber(list, max_count)			--- Lottery Used@20100521(����_��������)
	local PriceChance = {20,250,4000}																						-- һ�����Ƚ�����(��λ:���֮)
	PriceChance[4] = 10000 - PriceChance[1] - PriceChance[2] - PriceChance[3]		--     �ĵȽ�����(��λ:���֮)
	
	local subChance = {}
	local subSum = {}
	subChance[1] = {20}												-- һ�Ƚ��ڲ���Ը���(1��)
	subChance[2] = {100,50,100}								-- ���Ƚ��ڲ���Ը���(5�ţ�9�ţ�13��)
	subChance[3] = {1000,1000,1000,1000}			-- ���Ƚ��ڲ���Ը���(3�ţ�7�ţ�11�ţ�15��)
	subChance[4] = {25,10,10,25,25,40,40,25}	-- �ĵȽ��ڲ���Ը���(2,4,6,8,10,12,14,16)

	for j=1,4 do
		subSum[j] = 0
		for i,_ in pairs(subChance[j]) do
			subSum[j] = subSum[j] + subChance[j][i]
		end
	end
	
	local NumList = {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16}
	local NumChance =
	{
		PriceChance[1], 													PriceChance[4]*subChance[4][1]/subSum[4], PriceChance[3]*subChance[3][1]/subSum[3], PriceChance[4]*subChance[4][2]/subSum[4],
		PriceChance[2]*subChance[2][1]/subSum[2], PriceChance[4]*subChance[4][3]/subSum[4], PriceChance[3]*subChance[3][2]/subSum[3], PriceChance[4]*subChance[4][4]/subSum[4],
		PriceChance[2]*subChance[2][2]/subSum[2], PriceChance[4]*subChance[4][5]/subSum[4], PriceChance[3]*subChance[3][3]/subSum[3], PriceChance[4]*subChance[4][6]/subSum[4],
		PriceChance[2]*subChance[2][3]/subSum[2], PriceChance[4]*subChance[4][7]/subSum[4], PriceChance[3]*subChance[3][4]/subSum[3], PriceChance[4]*subChance[4][8]/subSum[4],
	}
	return NumList[ZLottery_Get_RanPoint(NumChance)]
end
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType25000SelectNumber(list, max_count)			--- Lottery Used@20090518(���챦¼����)
	local PriceChance = {200,1008,33878}																						-- һ�����Ƚ�����(��λ:���֮)
	PriceChance[4] = 100000 - PriceChance[1] - PriceChance[2] - PriceChance[3]		--     �ĵȽ�����(��λ:���֮)
	
	local subChance = {}
	local subSum = {}
	subChance[1] = {100}												-- һ�Ƚ��ڲ���Ը���(1��)
	subChance[2] = {33,33,33}									-- ���Ƚ��ڲ���Ը���(5�ţ�9�ţ�13��)
	subChance[3] = {25,25,25,25}			-- ���Ƚ��ڲ���Ը���(3�ţ�7�ţ�11�ţ�15��)
	subChance[4] = {25,10,10,25,25,40,40,25}	-- �ĵȽ��ڲ���Ը���(2,4,6,8,10,12,14,16)

	for j=1,4 do
		subSum[j] = 0
		for i,_ in pairs(subChance[j]) do
			subSum[j] = subSum[j] + subChance[j][i]
		end
	end
	
	local NumList = {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16}
	local NumChance =
	{
		PriceChance[1]*subChance[1][1]/subSum[1], PriceChance[4]*subChance[4][1]/subSum[4], PriceChance[3]*subChance[3][1]/subSum[3], PriceChance[4]*subChance[4][2]/subSum[4],
		PriceChance[2]*subChance[2][1]/subSum[2], PriceChance[4]*subChance[4][3]/subSum[4], PriceChance[3]*subChance[3][2]/subSum[3], PriceChance[4]*subChance[4][4]/subSum[4],
		PriceChance[2]*subChance[2][2]/subSum[2], PriceChance[4]*subChance[4][5]/subSum[4], PriceChance[3]*subChance[3][3]/subSum[3], PriceChance[4]*subChance[4][6]/subSum[4],
		PriceChance[2]*subChance[2][3]/subSum[2], PriceChance[4]*subChance[4][7]/subSum[4], PriceChance[3]*subChance[3][4]/subSum[3], PriceChance[4]*subChance[4][8]/subSum[4],
	}
	return NumList[ZLottery_Get_RanPoint(NumChance)]
end

-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType34124SelectNumber(list, max_count)										--- Lottery Used@20100608(����_�������)
	local PriceChance = {10,100,3500}																						-- һ�����Ƚ�����(��λ:���֮)
	PriceChance[4] = 10000 - PriceChance[1] - PriceChance[2] - PriceChance[3]		--     �ĵȽ�����(��λ:���֮)
	
	local subChance = {}
	local subSum = {}
	subChance[1] = {10,10}										-- һ�Ƚ��ڲ���Ը���(1�ţ�9��)
	subChance[2] = {40,60}										-- ���Ƚ��ڲ���Ը���(5�ţ�13��)
	subChance[3] = {20,15,15,20}							-- ���Ƚ��ڲ���Ը���(3�ţ�7�ţ�11�ţ�15��)
	subChance[4] = {40,10,10,40,40,10,10,40}	-- �ĵȽ��ڲ���Ը���(2,4,6,8,10,12,14,16)

	for j=1,4 do
		subSum[j] = 0
		for i,_ in pairs(subChance[j]) do
			subSum[j] = subSum[j] + subChance[j][i]
		end
	end
	
	local NumList = {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16}
	local NumChance =
	{
		PriceChance[1]*subChance[1][1]/subSum[1], PriceChance[4]*subChance[4][1]/subSum[4], PriceChance[3]*subChance[3][1]/subSum[3], PriceChance[4]*subChance[4][2]/subSum[4],
		PriceChance[2]*subChance[2][1]/subSum[2], PriceChance[4]*subChance[4][3]/subSum[4], PriceChance[3]*subChance[3][2]/subSum[3], PriceChance[4]*subChance[4][4]/subSum[4],
		PriceChance[1]*subChance[1][2]/subSum[1], PriceChance[4]*subChance[4][5]/subSum[4], PriceChance[3]*subChance[3][3]/subSum[3], PriceChance[4]*subChance[4][6]/subSum[4],
		PriceChance[2]*subChance[2][2]/subSum[2], PriceChance[4]*subChance[4][7]/subSum[4], PriceChance[3]*subChance[3][4]/subSum[3], PriceChance[4]*subChance[4][8]/subSum[4],
	}
	return NumList[ZLottery_Get_RanPoint(NumChance)]
end
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType34937SelectNumber(list, max_count)										--- Lottery Used@20100811(����_��������)
	local PriceChance = {12,100,3500}																						-- һ�����Ƚ�����(��λ:���֮)
	PriceChance[4] = 10000 - PriceChance[1] - PriceChance[2] - PriceChance[3]		--     �ĵȽ�����(��λ:���֮)
	
	local subChance = {}
	local subSum = {}
	subChance[1] = {10,2}											-- һ�Ƚ��ڲ���Ը���(1�ţ�9��)
	subChance[2] = {40,60}										-- ���Ƚ��ڲ���Ը���(5�ţ�13��)
	subChance[3] = {20,15,15,20}							-- ���Ƚ��ڲ���Ը���(3�ţ�7�ţ�11�ţ�15��)
	subChance[4] = {40,10,10,40,40,10,10,40}	-- �ĵȽ��ڲ���Ը���(2,4,6,8,10,12,14,16)

	for j=1,4 do
		subSum[j] = 0
		for i,_ in pairs(subChance[j]) do
			subSum[j] = subSum[j] + subChance[j][i]
		end
	end
	
	local NumList = {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16}
	local NumChance =
	{
		PriceChance[1]*subChance[1][1]/subSum[1], PriceChance[4]*subChance[4][1]/subSum[4], PriceChance[3]*subChance[3][1]/subSum[3], PriceChance[4]*subChance[4][2]/subSum[4],
		PriceChance[2]*subChance[2][1]/subSum[2], PriceChance[4]*subChance[4][3]/subSum[4], PriceChance[3]*subChance[3][2]/subSum[3], PriceChance[4]*subChance[4][4]/subSum[4],
		PriceChance[1]*subChance[1][2]/subSum[1], PriceChance[4]*subChance[4][5]/subSum[4], PriceChance[3]*subChance[3][3]/subSum[3], PriceChance[4]*subChance[4][6]/subSum[4],
		PriceChance[2]*subChance[2][2]/subSum[2], PriceChance[4]*subChance[4][7]/subSum[4], PriceChance[3]*subChance[3][4]/subSum[3], PriceChance[4]*subChance[4][8]/subSum[4],
	}
	return NumList[ZLottery_Get_RanPoint(NumChance)]
end
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType25750SelectNumber(list, max_count)			--- Lottery Used@20101011(����_��Ҷ��֥)
	local PriceChance = {32,250,5000}																						-- һ�����Ƚ�����(��λ:���֮)
	PriceChance[4] = 10000 - PriceChance[1] - PriceChance[2] - PriceChance[3]		--     �ĵȽ�����(��λ:���֮)
	
	local subChance = {}
	local subSum = {}
	subChance[1] = {10,2,20}										-- һ�Ƚ��ڲ���Ը���(1,9,13)
	subChance[2] = {60,50,50,50,40}							-- ���Ƚ��ڲ���Ը���(3,5,7,11,15)
	subChance[3] = {1250,500,2000,1250}					-- ���Ƚ��ڲ���Ը���(4,6,12,14)
	subChance[4] = {25,10,40,25}								-- �ĵȽ��ڲ���Ը���(2,8,10,16)

	for j=1,4 do
		subSum[j] = 0
		for i,_ in pairs(subChance[j]) do
			subSum[j] = subSum[j] + subChance[j][i]
		end
	end
	
	local NumList = {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16}
	local NumChance =
	{
		PriceChance[1]*subChance[1][1]/subSum[1], PriceChance[4]*subChance[4][1]/subSum[4], PriceChance[2]*subChance[2][1]/subSum[2], PriceChance[3]*subChance[3][1]/subSum[3],
		PriceChance[2]*subChance[2][2]/subSum[2], PriceChance[3]*subChance[3][2]/subSum[3], PriceChance[2]*subChance[2][3]/subSum[2], PriceChance[4]*subChance[4][2]/subSum[4],
		PriceChance[1]*subChance[1][2]/subSum[1], PriceChance[4]*subChance[4][3]/subSum[4], PriceChance[2]*subChance[2][4]/subSum[2], PriceChance[3]*subChance[3][3]/subSum[3],
		PriceChance[1]*subChance[1][3]/subSum[1], PriceChance[3]*subChance[3][4]/subSum[3], PriceChance[2]*subChance[2][5]/subSum[2], PriceChance[4]*subChance[4][4]/subSum[4],
	}
	return NumList[ZLottery_Get_RanPoint(NumChance)]
end
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType28573SelectNumber(list, max_count)			--- Lottery Used@20101015(����_�����ر�)
	local PriceChance = {10,240,4575}																						-- һ�����Ƚ�����(��λ:���֮)
	PriceChance[4] = 10000 - PriceChance[1] - PriceChance[2] - PriceChance[3]		--     �ĵȽ�����(��λ:���֮)
	
	local subChance = {}
	local subSum = {}
	subChance[1] = {10,50,20,20}							-- һ�Ƚ��ڲ���Ը���
	subChance[2] = {40,60,50,50,40}						-- ���Ƚ��ڲ���Ը���
	subChance[3] = {175,2500,2000}						-- ���Ƚ��ڲ���Ը���
	subChance[4] = {1505,1000,1000,1670}			-- �ĵȽ��ڲ���Ը���

	for j=1,4 do
		subSum[j] = 0
		for i,_ in pairs(subChance[j]) do
			subSum[j] = subSum[j] + subChance[j][i]
		end
	end
	
	local NumList = {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16}
	local NumChance =
	{
		PriceChance[1]*subChance[1][1]/subSum[1], 
		PriceChance[4]*subChance[4][1]/subSum[4], 
		PriceChance[2]*subChance[2][1]/subSum[2], 
		PriceChance[3]*subChance[3][1]/subSum[3],
		
		PriceChance[1]*subChance[1][2]/subSum[1], 
		PriceChance[3]*subChance[3][2]/subSum[3], 
		PriceChance[2]*subChance[2][2]/subSum[2], 
		PriceChance[4]*subChance[4][2]/subSum[4],

		PriceChance[1]*subChance[1][3]/subSum[1], 
		PriceChance[4]*subChance[4][3]/subSum[4], 
		PriceChance[2]*subChance[2][3]/subSum[2], 
		PriceChance[3]*subChance[3][3]/subSum[3],

		PriceChance[1]*subChance[1][4]/subSum[1], 
		PriceChance[2]*subChance[2][4]/subSum[2], 
		PriceChance[2]*subChance[2][5]/subSum[2], 
		PriceChance[4]*subChance[4][4]/subSum[4],
	}
	return NumList[ZLottery_Get_RanPoint(NumChance)]
end
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType34295SelectNumber(list, max_count)		--- (����_20110125_������)
	local PriceChance = {20,100,3500}																						-- һ�����Ƚ�����(��λ:���֮)
	PriceChance[4] = 10000 - PriceChance[1] - PriceChance[2] - PriceChance[3]		--     �ĵȽ�����(��λ:���֮)
	
	local subChance = {}
	local subSum = {}
	subChance[1] = {10,10}										-- һ�Ƚ��ڲ���Ը���(1�ţ�9��)
	subChance[2] = {80,20}										-- ���Ƚ��ڲ���Ը���(5�ţ�13��)
	subChance[3] = {20,15,15,20}							-- ���Ƚ��ڲ���Ը���(3�ţ�7�ţ�11�ţ�15��)
	subChance[4] = {40,10,10,40,40,10,10,40}	-- �ĵȽ��ڲ���Ը���(2,4,6,8,10,12,14,16)

	for j=1,4 do
		subSum[j] = 0
		for i,_ in pairs(subChance[j]) do
			subSum[j] = subSum[j] + subChance[j][i]
		end
	end
	
	local NumList = {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16}
	local NumChance =
	{
		PriceChance[1]*subChance[1][1]/subSum[1], PriceChance[4]*subChance[4][1]/subSum[4], PriceChance[3]*subChance[3][1]/subSum[3], PriceChance[4]*subChance[4][2]/subSum[4],
		PriceChance[2]*subChance[2][1]/subSum[2], PriceChance[4]*subChance[4][3]/subSum[4], PriceChance[3]*subChance[3][2]/subSum[3], PriceChance[4]*subChance[4][4]/subSum[4],
		PriceChance[1]*subChance[1][2]/subSum[1], PriceChance[4]*subChance[4][5]/subSum[4], PriceChance[3]*subChance[3][3]/subSum[3], PriceChance[4]*subChance[4][6]/subSum[4],
		PriceChance[2]*subChance[2][2]/subSum[2], PriceChance[4]*subChance[4][7]/subSum[4], PriceChance[3]*subChance[3][4]/subSum[3], PriceChance[4]*subChance[4][8]/subSum[4],
	}
	return NumList[ZLottery_Get_RanPoint(NumChance)]
end
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType23144SelectNumber(list, max_count)	---(����:���20110125���������ƽ�)
	local NumList={1,2,3,4}
	local NumChance={5,20,30,45}
	return NumList[ZLottery_Get_RanPoint(NumChance)]
end
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType41080SelectNumber(list, max_count)			---(�廪����-����20110311)
	local PriceChance = {20,200,4000}																						-- һ�����Ƚ�����(��λ:���֮)
	PriceChance[4] = 10000 - PriceChance[1] - PriceChance[2] - PriceChance[3]		--     �ĵȽ�����(��λ:���֮)
	
	local subChance = {}
	local subSum = {}
	subChance[1] = {70,50,70,10}					-- һ�Ƚ��ڲ���Ը���
	subChance[2] = {25,25,25,25}					-- ���Ƚ��ڲ���Ը���
	subChance[3] = {30,10,30,10}					-- ���Ƚ��ڲ���Ը���
	subChance[4] = {10,40,40,10}					-- �ĵȽ��ڲ���Ը���

	for j=1,4 do
		subSum[j] = 0
		for i,_ in pairs(subChance[j]) do
			subSum[j] = subSum[j] + subChance[j][i]
		end
	end
	
	local NumList = {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16}
	local NumChance =
	{
		PriceChance[1]*subChance[1][1]/subSum[1], 
		PriceChance[4]*subChance[4][1]/subSum[4], 
		PriceChance[2]*subChance[2][1]/subSum[2], 
		PriceChance[3]*subChance[3][1]/subSum[3],
		
		PriceChance[1]*subChance[1][2]/subSum[1], 
		PriceChance[3]*subChance[3][2]/subSum[3], 
		PriceChance[2]*subChance[2][2]/subSum[2], 
		PriceChance[4]*subChance[4][2]/subSum[4],

		PriceChance[1]*subChance[1][3]/subSum[1], 
		PriceChance[4]*subChance[4][3]/subSum[4], 
		PriceChance[2]*subChance[2][3]/subSum[2], 
		PriceChance[3]*subChance[3][3]/subSum[3],

		PriceChance[1]*subChance[1][4]/subSum[1], 
		PriceChance[3]*subChance[3][4]/subSum[3], 
		PriceChance[2]*subChance[2][4]/subSum[2], 
		PriceChance[4]*subChance[4][4]/subSum[4],
	}
	return NumList[ZLottery_Get_RanPoint(NumChance)]
end
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType40928SelectNumber(list, max_count)			---(��������20110402����)
	local PriceChance = {20,150,4000}																						-- һ�����Ƚ�����(��λ:���֮)
	PriceChance[4] = 10000 - PriceChance[1] - PriceChance[2] - PriceChance[3]		--     �ĵȽ�����(��λ:���֮)
	
	local subChance = {}
	local subSum = {}
	subChance[1] = {10,10,10,10}					-- һ�Ƚ��ڲ���Ը���
	subChance[2] = {25,50,50,25}						-- ���Ƚ��ڲ���Ը���
	subChance[3] = {10,10,10,10}							-- ���Ƚ��ڲ���Ը���
	subChance[4] = {10,40,40,10}						-- �ĵȽ��ڲ���Ը���

	for j=1,4 do
		subSum[j] = 0
		for i,_ in pairs(subChance[j]) do
			subSum[j] = subSum[j] + subChance[j][i]
		end
	end
	
	local NumList = {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16}
	local NumChance =
	{
		PriceChance[1]*subChance[1][1]/subSum[1], 
		PriceChance[4]*subChance[4][1]/subSum[4], 
		PriceChance[2]*subChance[2][1]/subSum[2], 
		PriceChance[3]*subChance[3][1]/subSum[3],
		
		PriceChance[1]*subChance[1][2]/subSum[1], 
		PriceChance[3]*subChance[3][2]/subSum[3], 
		PriceChance[2]*subChance[2][2]/subSum[2], 
		PriceChance[4]*subChance[4][2]/subSum[4],

		PriceChance[1]*subChance[1][3]/subSum[1], 
		PriceChance[4]*subChance[4][3]/subSum[4], 
		PriceChance[2]*subChance[2][3]/subSum[2], 
		PriceChance[3]*subChance[3][3]/subSum[3],

		PriceChance[1]*subChance[1][4]/subSum[1], 
		PriceChance[3]*subChance[3][4]/subSum[3], 
		PriceChance[2]*subChance[2][4]/subSum[2], 
		PriceChance[4]*subChance[4][4]/subSum[4],
	}
	return NumList[ZLottery_Get_RanPoint(NumChance)]
end
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType32605SelectNumber(list, max_count)			---(ʨ����¼20110505����)
	local PriceChance = {20,300,5000}																						-- һ�����Ƚ�����(��λ:���֮)
	PriceChance[4] = 10000 - PriceChance[1] - PriceChance[2] - PriceChance[3]		--     �ĵȽ�����(��λ:���֮)
	
	local subChance = {}
	local subSum = {}
	subChance[1] = {20}												-- һ�Ƚ��ڲ���Ը���(1��)
	subChance[2] = {150,100,50}								-- ���Ƚ��ڲ���Ը���(5�ţ�9�ţ�13��)
	subChance[3] = {1250,500,2000,1250}				-- ���Ƚ��ڲ���Ը���(3�ţ�7�ţ�11�ţ�15��)
	subChance[4] = {25,10,10,25,25,40,40,25}	-- �ĵȽ��ڲ���Ը���(2,4,6,8,10,12,14,16)

	for j=1,4 do
		subSum[j] = 0
		for i,_ in pairs(subChance[j]) do
			subSum[j] = subSum[j] + subChance[j][i]
		end
	end
	
	local NumList = {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16}
	local NumChance =
	{
		PriceChance[1], 													PriceChance[4]*subChance[4][1]/subSum[4], PriceChance[3]*subChance[3][1]/subSum[3], PriceChance[4]*subChance[4][2]/subSum[4],
		PriceChance[2]*subChance[2][1]/subSum[2], PriceChance[4]*subChance[4][3]/subSum[4], PriceChance[3]*subChance[3][2]/subSum[3], PriceChance[4]*subChance[4][4]/subSum[4],
		PriceChance[2]*subChance[2][2]/subSum[2], PriceChance[4]*subChance[4][5]/subSum[4], PriceChance[3]*subChance[3][3]/subSum[3], PriceChance[4]*subChance[4][6]/subSum[4],
		PriceChance[2]*subChance[2][3]/subSum[2], PriceChance[4]*subChance[4][7]/subSum[4], PriceChance[3]*subChance[3][4]/subSum[3], PriceChance[4]*subChance[4][8]/subSum[4],
	}
	return NumList[ZLottery_Get_RanPoint(NumChance)]
end

-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType42732SelectNumber(list, max_count)			---(���ƴͱ�)20110527����
	local PriceChance = {100,1000,1000}																						-- һ�����Ƚ�����(��λ:���֮)
	PriceChance[4] = 10000 - PriceChance[1] - PriceChance[2] - PriceChance[3]		--     �ĵȽ�����(��λ:���֮)
	
	local subChance = {}
	local subSum = {}
	subChance[1] = {15,35,15,35}							    -- һ�Ƚ��ڲ���Ը��ʣ�1,5,9,13��
	subChance[2] = {25,25,25,25}					   	    -- ���Ƚ��ڲ���Ը��ʣ�3,7,11,15��
	subChance[3] = {25,25,25,25}						      -- ���Ƚ��ڲ���Ը��ʣ�4,6,12,14��
	subChance[4] = {3000,900,1000,3000}			      -- �ĵȽ��ڲ���Ը��ʣ�2,8,10,16��

	for j=1,4 do
		subSum[j] = 0
		for i,_ in pairs(subChance[j]) do
			subSum[j] = subSum[j] + subChance[j][i]
		end
	end
	
	local NumList = {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16}
	local NumChance =
	{
		PriceChance[1]*subChance[1][1]/subSum[1], 
		PriceChance[4]*subChance[4][1]/subSum[4], 
		PriceChance[2]*subChance[2][1]/subSum[2], 
		PriceChance[3]*subChance[3][1]/subSum[3],
		
		PriceChance[1]*subChance[1][2]/subSum[1], 
		PriceChance[3]*subChance[3][2]/subSum[3], 
		PriceChance[2]*subChance[2][2]/subSum[2], 
		PriceChance[4]*subChance[4][2]/subSum[4],

		PriceChance[1]*subChance[1][3]/subSum[1], 
		PriceChance[4]*subChance[4][3]/subSum[4], 
		PriceChance[2]*subChance[2][3]/subSum[2], 
		PriceChance[3]*subChance[3][3]/subSum[3],

		PriceChance[1]*subChance[1][4]/subSum[1], 
		PriceChance[3]*subChance[3][4]/subSum[3], 
		PriceChance[2]*subChance[2][4]/subSum[2], 
		PriceChance[4]*subChance[4][4]/subSum[4],
	}
	return NumList[ZLottery_Get_RanPoint(NumChance)]
end
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType42784SelectNumber(list, max_count)			---����Ԫ�ز�20110527������
	local PriceChance = {20,200,3000}																						-- һ�����Ƚ�����(��λ:���֮)
	PriceChance[4] = 10000 - PriceChance[1] - PriceChance[2] - PriceChance[3]		--     �ĵȽ�����(��λ:���֮)
	
	local subChance = {}
	local subSum = {}
	subChance[1] = {30,50,40,30,50}					-- һ�Ƚ��ڲ���Ը��ʣ�1��5��7��11��13��
	subChance[2] = {40,100,60}									-- ���Ƚ��ڲ���Ը��ʣ�3��9��15��
	subChance[3] = {10,10,10,10}							-- ���Ƚ��ڲ���Ը��ʣ�4��6��12��14��
	subChance[4] = {10,10,10,10}							-- �ĵȽ��ڲ���Ը��ʣ�2��8��10��16��

	for j=1,4 do
		subSum[j] = 0
		for i,_ in pairs(subChance[j]) do
			subSum[j] = subSum[j] + subChance[j][i]
		end
	end
	
	local NumList = {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16}
	local NumChance =
	{
		PriceChance[1]*subChance[1][1]/subSum[1], 
		PriceChance[4]*subChance[4][1]/subSum[4], 
		PriceChance[2]*subChance[2][1]/subSum[2], 
		PriceChance[3]*subChance[3][1]/subSum[3],
		
		PriceChance[1]*subChance[1][2]/subSum[1], 
		PriceChance[3]*subChance[3][2]/subSum[3], 
		PriceChance[1]*subChance[1][3]/subSum[1], 
		PriceChance[4]*subChance[4][2]/subSum[4],

		PriceChance[2]*subChance[2][2]/subSum[2], 
		PriceChance[4]*subChance[4][3]/subSum[4], 
		PriceChance[1]*subChance[1][4]/subSum[1], 
		PriceChance[3]*subChance[3][3]/subSum[3],

		PriceChance[1]*subChance[1][5]/subSum[1], 
		PriceChance[3]*subChance[3][4]/subSum[3], 
		PriceChance[2]*subChance[2][3]/subSum[2], 
		PriceChance[4]*subChance[4][4]/subSum[4],
	}
	return NumList[ZLottery_Get_RanPoint(NumChance)]
end
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType42868SelectNumber(list, max_count)			--- (��������20110714����)
	local PriceChance = {40,200,3000}																						-- һ�����Ƚ�����(��λ:���֮)
	PriceChance[4] = 10000 - PriceChance[1] - PriceChance[2] - PriceChance[3]		--     �ĵȽ�����(��λ:���֮)
	
	local subChance = {}
	local subSum = {}
	subChance[1] = {20,5,13,2}					-- һ�Ƚ��ڲ���Ը���
	subChance[2] = {50,60,40,50}					-- ���Ƚ��ڲ���Ը���
	subChance[3] = {10,10,10,10}					-- ���Ƚ��ڲ���Ը���
	subChance[4] = {10,10,10,10}					-- �ĵȽ��ڲ���Ը���

	for j=1,4 do
		subSum[j] = 0
		for i,_ in pairs(subChance[j]) do
			subSum[j] = subSum[j] + subChance[j][i]
		end
	end
	
	local NumList = {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16}
	local NumChance =
	{
		PriceChance[1]*subChance[1][1]/subSum[1], 
		PriceChance[4]*subChance[4][1]/subSum[4], 
		PriceChance[2]*subChance[2][1]/subSum[2], 
		PriceChance[3]*subChance[3][1]/subSum[3],
		
		PriceChance[1]*subChance[1][2]/subSum[1], 
		PriceChance[3]*subChance[3][2]/subSum[3], 
		PriceChance[2]*subChance[2][2]/subSum[2], 
		PriceChance[4]*subChance[4][2]/subSum[4],

		PriceChance[1]*subChance[1][3]/subSum[1], 
		PriceChance[4]*subChance[4][3]/subSum[4], 
		PriceChance[2]*subChance[2][3]/subSum[2], 
		PriceChance[3]*subChance[3][3]/subSum[3],

		PriceChance[1]*subChance[1][4]/subSum[1], 
		PriceChance[3]*subChance[3][4]/subSum[3], 
		PriceChance[2]*subChance[2][4]/subSum[2], 
		PriceChance[4]*subChance[4][4]/subSum[4],
	}
	return NumList[ZLottery_Get_RanPoint(NumChance)]
end
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType25417SelectNumber(list, max_count)			---(Ѫ����ľ2011-08-11����)
	local PriceChance = {20,100,4000}																						-- һ�����Ƚ�����(��λ:���֮)
	PriceChance[4] = 10000 - PriceChance[1] - PriceChance[2] - PriceChance[3]		--     �ĵȽ�����(��λ:���֮)
	
	local subChance = {}
	local subSum = {}
	subChance[1] = {10,10}										-- һ�Ƚ��ڲ���Ը���(1�ţ�9��)
	subChance[2] = {40,60}										-- ���Ƚ��ڲ���Ը���(5�ţ�13��)
	subChance[3] = {1000,1000,1000,1000}			-- ���Ƚ��ڲ���Ը���(3�ţ�7�ţ�11�ţ�15��)
	subChance[4] = {25,10,10,25,25,40,40,25}	-- �ĵȽ��ڲ���Ը���(2,4,6,8,10,12,14,16)

	for j=1,4 do
		subSum[j] = 0
		for i,_ in pairs(subChance[j]) do
			subSum[j] = subSum[j] + subChance[j][i]
		end
	end
	
	local NumList = {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16}
	local NumChance =
	{
		PriceChance[1]*subChance[1][1]/subSum[1], PriceChance[4]*subChance[4][1]/subSum[4], PriceChance[3]*subChance[3][1]/subSum[3], PriceChance[4]*subChance[4][2]/subSum[4],
		PriceChance[2]*subChance[2][1]/subSum[2], PriceChance[4]*subChance[4][3]/subSum[4], PriceChance[3]*subChance[3][2]/subSum[3], PriceChance[4]*subChance[4][4]/subSum[4],
		PriceChance[1]*subChance[1][2]/subSum[1], PriceChance[4]*subChance[4][5]/subSum[4], PriceChance[3]*subChance[3][3]/subSum[3], PriceChance[4]*subChance[4][6]/subSum[4],
		PriceChance[2]*subChance[2][2]/subSum[2], PriceChance[4]*subChance[4][7]/subSum[4], PriceChance[3]*subChance[3][4]/subSum[3], PriceChance[4]*subChance[4][8]/subSum[4],
	}
	return NumList[ZLottery_Get_RanPoint(NumChance)]
end
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType42665SelectNumber(list, max_count)			---(��������2011-08-11����)
	local PriceChance = {40,200,3000}																						-- һ�����Ƚ�����(��λ:���֮)
	PriceChance[4] = 10000 - PriceChance[1] - PriceChance[2] - PriceChance[3]		--     �ĵȽ�����(��λ:���֮)
	
	local subChance = {}
	local subSum = {}
	subChance[1] = {20,40,150,150,40}					-- һ�Ƚ��ڲ���Ը��ʣ�1��5��7��11��13��
	subChance[2] = {50,50,100}									-- ���Ƚ��ڲ���Ը��ʣ�3��9��15��
	subChance[3] = {10,10,10,10}							-- ���Ƚ��ڲ���Ը��ʣ�4��6��12��14��
	subChance[4] = {10,10,10,10}							-- �ĵȽ��ڲ���Ը��ʣ�2��8��10��16��

	for j=1,4 do
		subSum[j] = 0
		for i,_ in pairs(subChance[j]) do
			subSum[j] = subSum[j] + subChance[j][i]
		end
	end
	
	local NumList = {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16}
	local NumChance =
	{
		PriceChance[1]*subChance[1][1]/subSum[1], 
		PriceChance[4]*subChance[4][1]/subSum[4], 
		PriceChance[2]*subChance[2][1]/subSum[2], 
		PriceChance[3]*subChance[3][1]/subSum[3],
		
		PriceChance[1]*subChance[1][2]/subSum[1], 
		PriceChance[3]*subChance[3][2]/subSum[3], 
		PriceChance[1]*subChance[1][3]/subSum[1], 
		PriceChance[4]*subChance[4][2]/subSum[4],

		PriceChance[2]*subChance[2][2]/subSum[2], 
		PriceChance[4]*subChance[4][3]/subSum[4], 
		PriceChance[1]*subChance[1][4]/subSum[1], 
		PriceChance[3]*subChance[3][3]/subSum[3],

		PriceChance[1]*subChance[1][5]/subSum[1], 
		PriceChance[3]*subChance[3][4]/subSum[3], 
		PriceChance[2]*subChance[2][3]/subSum[2], 
		PriceChance[4]*subChance[4][4]/subSum[4],
	}
	return NumList[ZLottery_Get_RanPoint(NumChance)]
end
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType44403SelectNumber(list, max_count)			---(����ѩ��2011-08-29����)
	local PriceChance = {20,200,3000}																						-- һ�����Ƚ�����(��λ:���֮)
	PriceChance[4] = 10000 - PriceChance[1] - PriceChance[2] - PriceChance[3]		--     �ĵȽ�����(��λ:���֮)
	
	local subChance = {}
	local subSum = {}
	subChance[1] = {20,80,20,80}					-- һ�Ƚ��ڲ���Ը���
	subChance[2] = {50,50,50,50}					-- ���Ƚ��ڲ���Ը���
	subChance[3] = {10,10,10,10}					-- ���Ƚ��ڲ���Ը���
	subChance[4] = {10,10,10,10}					-- �ĵȽ��ڲ���Ը���

	for j=1,4 do
		subSum[j] = 0
		for i,_ in pairs(subChance[j]) do
			subSum[j] = subSum[j] + subChance[j][i]
		end
	end
	
	local NumList = {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16}
	local NumChance =
	{
		PriceChance[1]*subChance[1][1]/subSum[1], 
		PriceChance[4]*subChance[4][1]/subSum[4], 
		PriceChance[2]*subChance[2][1]/subSum[2], 
		PriceChance[3]*subChance[3][1]/subSum[3],
		
		PriceChance[1]*subChance[1][2]/subSum[1], 
		PriceChance[3]*subChance[3][2]/subSum[3], 
		PriceChance[2]*subChance[2][2]/subSum[2], 
		PriceChance[4]*subChance[4][2]/subSum[4],

		PriceChance[1]*subChance[1][3]/subSum[1], 
		PriceChance[4]*subChance[4][3]/subSum[4], 
		PriceChance[2]*subChance[2][3]/subSum[2], 
		PriceChance[3]*subChance[3][3]/subSum[3],

		PriceChance[1]*subChance[1][4]/subSum[1], 
		PriceChance[3]*subChance[3][4]/subSum[3], 
		PriceChance[2]*subChance[2][4]/subSum[2], 
		PriceChance[4]*subChance[4][4]/subSum[4],
	}
	return NumList[ZLottery_Get_RanPoint(NumChance)]
end
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType42353SelectNumber(list, max_count)			---(�ŋ����-����2011-09-22����)
	local PriceChance = {40,200,3000}																						-- һ�����Ƚ�����(��λ:���֮)
	PriceChance[4] = 10000 - PriceChance[1] - PriceChance[2] - PriceChance[3]		--     �ĵȽ�����(��λ:���֮)
	
	local subChance = {}
	local subSum = {}
	subChance[1] = {20,5,13,2}					-- һ�Ƚ��ڲ���Ը���
	subChance[2] = {50,60,50,40}					-- ���Ƚ��ڲ���Ը���
	subChance[3] = {10,10,10,10}					-- ���Ƚ��ڲ���Ը���
	subChance[4] = {10,10,10,10}					-- �ĵȽ��ڲ���Ը���

	for j=1,4 do
		subSum[j] = 0
		for i,_ in pairs(subChance[j]) do
			subSum[j] = subSum[j] + subChance[j][i]
		end
	end
	
	local NumList = {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16}
	local NumChance =
	{
		PriceChance[1]*subChance[1][1]/subSum[1], 
		PriceChance[4]*subChance[4][1]/subSum[4], 
		PriceChance[2]*subChance[2][1]/subSum[2], 
		PriceChance[3]*subChance[3][1]/subSum[3],
		
		PriceChance[1]*subChance[1][2]/subSum[1], 
		PriceChance[3]*subChance[3][2]/subSum[3], 
		PriceChance[2]*subChance[2][2]/subSum[2], 
		PriceChance[4]*subChance[4][2]/subSum[4],

		PriceChance[1]*subChance[1][3]/subSum[1], 
		PriceChance[4]*subChance[4][3]/subSum[4], 
		PriceChance[2]*subChance[2][3]/subSum[2], 
		PriceChance[3]*subChance[3][3]/subSum[3],

		PriceChance[1]*subChance[1][4]/subSum[1], 
		PriceChance[3]*subChance[3][4]/subSum[3], 
		PriceChance[2]*subChance[2][4]/subSum[2], 
		PriceChance[4]*subChance[4][4]/subSum[4],
	}
	return NumList[ZLottery_Get_RanPoint(NumChance)]
end
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType40529SelectNumber(list, max_count)			---(�������2011-10-17����)
	local PriceChance = {20,150,4000}																						-- һ�����Ƚ�����(��λ:���֮)
	PriceChance[4] = 10000 - PriceChance[1] - PriceChance[2] - PriceChance[3]		--     �ĵȽ�����(��λ:���֮)
	
	local subChance = {}
	local subSum = {}
	subChance[1] = {20}												-- һ�Ƚ��ڲ���Ը���(1��)
	subChance[2] = {40,50,60}									-- ���Ƚ��ڲ���Ը���(5�ţ�9�ţ�13��)
	subChance[3] = {1000,1000,1000,1000}			-- ���Ƚ��ڲ���Ը���(3�ţ�7�ţ�11�ţ�15��)
	subChance[4] = {50,40,10,50,50,10,40,50}	-- �ĵȽ��ڲ���Ը���(2,4,6,8,10,12,14,16)

	for j=1,4 do
		subSum[j] = 0
		for i,_ in pairs(subChance[j]) do
			subSum[j] = subSum[j] + subChance[j][i]
		end
	end
	
	local NumList = {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16}
	local NumChance =
	{
		PriceChance[1], 													PriceChance[4]*subChance[4][1]/subSum[4], PriceChance[3]*subChance[3][1]/subSum[3], PriceChance[4]*subChance[4][2]/subSum[4],
		PriceChance[2]*subChance[2][1]/subSum[2], PriceChance[4]*subChance[4][3]/subSum[4], PriceChance[3]*subChance[3][2]/subSum[3], PriceChance[4]*subChance[4][4]/subSum[4],
		PriceChance[2]*subChance[2][2]/subSum[2], PriceChance[4]*subChance[4][5]/subSum[4], PriceChance[3]*subChance[3][3]/subSum[3], PriceChance[4]*subChance[4][6]/subSum[4],
		PriceChance[2]*subChance[2][3]/subSum[2], PriceChance[4]*subChance[4][7]/subSum[4], PriceChance[3]*subChance[3][4]/subSum[3], PriceChance[4]*subChance[4][8]/subSum[4],
	}
	return NumList[ZLottery_Get_RanPoint(NumChance)]
end
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType44638SelectNumber(list, max_count)			--- (������ϻ2011-10-20����)
	local PriceChance = {20,200,3000}																						-- һ�����Ƚ�����(��λ:���֮)
	PriceChance[4] = 10000 - PriceChance[1] - PriceChance[2] - PriceChance[3]		--     �ĵȽ�����(��λ:���֮)
	
	local subChance = {}
	local subSum = {}
	subChance[1] = {20,90,20,90}					-- һ�Ƚ��ڲ���Ը���
	subChance[2] = {20,60,60,60}					-- ���Ƚ��ڲ���Ը���
	subChance[3] = {10,10,10,10}					-- ���Ƚ��ڲ���Ը���
	subChance[4] = {10,10,10,10}					-- �ĵȽ��ڲ���Ը���

	for j=1,4 do
		subSum[j] = 0
		for i,_ in pairs(subChance[j]) do
			subSum[j] = subSum[j] + subChance[j][i]
		end
	end
	
	local NumList = {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16}
	local NumChance =
	{
		PriceChance[1]*subChance[1][1]/subSum[1], 
		PriceChance[4]*subChance[4][1]/subSum[4], 
		PriceChance[2]*subChance[2][1]/subSum[2], 
		PriceChance[3]*subChance[3][1]/subSum[3],
		
		PriceChance[1]*subChance[1][2]/subSum[1], 
		PriceChance[3]*subChance[3][2]/subSum[3], 
		PriceChance[2]*subChance[2][2]/subSum[2], 
		PriceChance[4]*subChance[4][2]/subSum[4],

		PriceChance[1]*subChance[1][3]/subSum[1], 
		PriceChance[4]*subChance[4][3]/subSum[4], 
		PriceChance[2]*subChance[2][3]/subSum[2], 
		PriceChance[3]*subChance[3][3]/subSum[3],

		PriceChance[1]*subChance[1][4]/subSum[1], 
		PriceChance[3]*subChance[3][4]/subSum[3], 
		PriceChance[2]*subChance[2][4]/subSum[2], 
		PriceChance[4]*subChance[4][4]/subSum[4],
	}
	return NumList[ZLottery_Get_RanPoint(NumChance)]
end
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType43403SelectNumber(list, max_count)			---(2011���Ӳ�Ʊ2011-11-17����)
	local PriceChance = {40,200,3000}																						-- һ�����Ƚ�����(��λ:���֮)
	PriceChance[4] = 10000 - PriceChance[1] - PriceChance[2] - PriceChance[3]		--     �ĵȽ�����(��λ:���֮)
	
	local subChance = {}
	local subSum = {}
	subChance[1] = {20,9,2,9}					-- һ�Ƚ��ڲ���Ը���
	subChance[2] = {50,50,50,50}					-- ���Ƚ��ڲ���Ը���
	subChance[3] = {10,10,10,10}					-- ���Ƚ��ڲ���Ը���
	subChance[4] = {10,10,10,10}					-- �ĵȽ��ڲ���Ը���

	for j=1,4 do
		subSum[j] = 0
		for i,_ in pairs(subChance[j]) do
			subSum[j] = subSum[j] + subChance[j][i]
		end
	end
	
	local NumList = {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16}
	local NumChance =
	{
		PriceChance[1]*subChance[1][1]/subSum[1], 
		PriceChance[4]*subChance[4][1]/subSum[4], 
		PriceChance[2]*subChance[2][1]/subSum[2], 
		PriceChance[3]*subChance[3][1]/subSum[3],
		
		PriceChance[1]*subChance[1][2]/subSum[1], 
		PriceChance[3]*subChance[3][2]/subSum[3], 
		PriceChance[2]*subChance[2][2]/subSum[2], 
		PriceChance[4]*subChance[4][2]/subSum[4],

		PriceChance[1]*subChance[1][3]/subSum[1], 
		PriceChance[4]*subChance[4][3]/subSum[4], 
		PriceChance[2]*subChance[2][3]/subSum[2], 
		PriceChance[3]*subChance[3][3]/subSum[3],

		PriceChance[1]*subChance[1][4]/subSum[1], 
		PriceChance[3]*subChance[3][4]/subSum[3], 
		PriceChance[2]*subChance[2][4]/subSum[2], 
		PriceChance[4]*subChance[4][4]/subSum[4],
	}
	return NumList[ZLottery_Get_RanPoint(NumChance)]
end
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType50621SelectNumber(list, max_count)			---(̫������2011-12-12����)
	local PriceChance = {20,120,3000}																						-- һ�����Ƚ�����(��λ:���֮)
	PriceChance[4] = 10000 - PriceChance[1] - PriceChance[2] - PriceChance[3]		--     �ĵȽ�����(��λ:���֮)
	
	local subChance = {}
	local subSum = {}
	subChance[1] = {50,20,50,80}					-- һ�Ƚ��ڲ���Ը���
	subChance[2] = {30,30,30,30}					-- ���Ƚ��ڲ���Ը���
	subChance[3] = {10,10,10,10}					-- ���Ƚ��ڲ���Ը���
	subChance[4] = {10,10,10,10}					-- �ĵȽ��ڲ���Ը���

	for j=1,4 do
		subSum[j] = 0
		for i,_ in pairs(subChance[j]) do
			subSum[j] = subSum[j] + subChance[j][i]
		end
	end
	
	local NumList = {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16}
	local NumChance =
	{
		PriceChance[1]*subChance[1][1]/subSum[1], 
		PriceChance[4]*subChance[4][1]/subSum[4], 
		PriceChance[2]*subChance[2][1]/subSum[2], 
		PriceChance[3]*subChance[3][1]/subSum[3],
		
		PriceChance[1]*subChance[1][2]/subSum[1], 
		PriceChance[3]*subChance[3][2]/subSum[3], 
		PriceChance[2]*subChance[2][2]/subSum[2], 
		PriceChance[4]*subChance[4][2]/subSum[4],

		PriceChance[1]*subChance[1][3]/subSum[1], 
		PriceChance[4]*subChance[4][3]/subSum[4], 
		PriceChance[2]*subChance[2][3]/subSum[2], 
		PriceChance[3]*subChance[3][3]/subSum[3],

		PriceChance[1]*subChance[1][4]/subSum[1], 
		PriceChance[3]*subChance[3][4]/subSum[3], 
		PriceChance[2]*subChance[2][4]/subSum[2], 
		PriceChance[4]*subChance[4][4]/subSum[4],
	}
	return NumList[ZLottery_Get_RanPoint(NumChance)]
end
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType44764SelectNumber(list, max_count)			---(��Ե����2011-12-16����)
	local PriceChance = {35,200,3000}																						-- һ�����Ƚ�����(��λ:���֮)
	PriceChance[4] = 10000 - PriceChance[1] - PriceChance[2] - PriceChance[3]		--     �ĵȽ�����(��λ:���֮)
	
	local subChance = {}
	local subSum = {}
	subChance[1] = {13,17,5}					-- һ�Ƚ��ڲ���Ը���
	subChance[2] = {30,20,100,20,30}					-- ���Ƚ��ڲ���Ը���
	subChance[3] = {10,10,10,10}					-- ���Ƚ��ڲ���Ը���
	subChance[4] = {10,10,10,10}					-- �ĵȽ��ڲ���Ը���

	for j=1,4 do 
		subSum[j] = 0
		for i,_ in pairs(subChance[j]) do
			subSum[j] = subSum[j] + subChance[j][i]
		end
	end
	
	local NumList = {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16}
	local NumChance =
	{
		PriceChance[1]*subChance[1][1]/subSum[1], 
		PriceChance[4]*subChance[4][1]/subSum[4], 
		PriceChance[2]*subChance[2][1]/subSum[2], 
		PriceChance[3]*subChance[3][1]/subSum[3],
		
		PriceChance[1]*subChance[1][2]/subSum[1], 
		PriceChance[3]*subChance[3][2]/subSum[3], 
		PriceChance[2]*subChance[2][2]/subSum[2], 
		PriceChance[4]*subChance[4][2]/subSum[4],

		PriceChance[2]*subChance[2][3]/subSum[2], 
		PriceChance[4]*subChance[4][3]/subSum[4], 
		PriceChance[2]*subChance[2][4]/subSum[2], 
		PriceChance[3]*subChance[3][3]/subSum[3],

		PriceChance[1]*subChance[1][3]/subSum[1], 
		PriceChance[3]*subChance[3][4]/subSum[3], 
		PriceChance[2]*subChance[2][5]/subSum[2], 
		PriceChance[4]*subChance[4][4]/subSum[4],
	}
	return NumList[ZLottery_Get_RanPoint(NumChance)]
end
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType50824SelectNumber(list, max_count)			---(��Դ��¼20120109����)
	local PriceChance = {40,120,3000}																						-- һ�����Ƚ�����(��λ:���֮)
	PriceChance[4] = 10000 - PriceChance[1] - PriceChance[2] - PriceChance[3]		--     �ĵȽ�����(��λ:���֮)
	
	local subChance = {}
	local subSum = {}
	subChance[1] = {20,3,2,15}					-- һ�Ƚ��ڲ���Ը���
	subChance[2] = {30,30,30,30}					-- ���Ƚ��ڲ���Ը���
	subChance[3] = {10,10,10,10}					-- ���Ƚ��ڲ���Ը���
	subChance[4] = {10,10,10,10}					-- �ĵȽ��ڲ���Ը���

	for j=1,4 do
		subSum[j] = 0
		for i,_ in pairs(subChance[j]) do
			subSum[j] = subSum[j] + subChance[j][i]
		end
	end
	
	local NumList = {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16}
	local NumChance =
	{
		PriceChance[1]*subChance[1][1]/subSum[1], 
		PriceChance[4]*subChance[4][1]/subSum[4], 
		PriceChance[2]*subChance[2][1]/subSum[2], 
		PriceChance[3]*subChance[3][1]/subSum[3],
		
		PriceChance[1]*subChance[1][2]/subSum[1], 
		PriceChance[3]*subChance[3][2]/subSum[3], 
		PriceChance[2]*subChance[2][2]/subSum[2], 
		PriceChance[4]*subChance[4][2]/subSum[4],

		PriceChance[1]*subChance[1][3]/subSum[1], 
		PriceChance[4]*subChance[4][3]/subSum[4], 
		PriceChance[2]*subChance[2][3]/subSum[2], 
		PriceChance[3]*subChance[3][3]/subSum[3],

		PriceChance[1]*subChance[1][4]/subSum[1], 
		PriceChance[3]*subChance[3][4]/subSum[3], 
		PriceChance[2]*subChance[2][4]/subSum[2], 
		PriceChance[4]*subChance[4][4]/subSum[4],
	}
	return NumList[ZLottery_Get_RanPoint(NumChance)]
end
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType33530SelectNumber(list, max_count)			---(������2012-02-03����)
	local PriceChance = {20,100,4000}																						-- һ�����Ƚ�����(��λ:���֮)
	PriceChance[4] = 10000 - PriceChance[1] - PriceChance[2] - PriceChance[3]		--     �ĵȽ�����(��λ:���֮)
	
	local subChance = {}
	local subSum = {}
	subChance[1] = {18,2}											-- һ�Ƚ��ڲ���Ը���(1�ţ�9��)
	subChance[2] = {40,60}										-- ���Ƚ��ڲ���Ը���(5�ţ�13��)
	subChance[3] = {1000,1000,1000,1000}			-- ���Ƚ��ڲ���Ը���(3�ţ�7�ţ�11�ţ�15��)
	subChance[4] = {40,10,10,40,40,10,10,40}	-- �ĵȽ��ڲ���Ը���(2,4,6,8,10,12,14,16)

	for j=1,4 do
		subSum[j] = 0
		for i,_ in pairs(subChance[j]) do
			subSum[j] = subSum[j] + subChance[j][i]
		end
	end
	
	local NumList = {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16}
	local NumChance =
	{
		PriceChance[1]*subChance[1][1]/subSum[1], PriceChance[4]*subChance[4][1]/subSum[4], PriceChance[3]*subChance[3][1]/subSum[3], PriceChance[4]*subChance[4][2]/subSum[4],
		PriceChance[2]*subChance[2][1]/subSum[2], PriceChance[4]*subChance[4][3]/subSum[4], PriceChance[3]*subChance[3][2]/subSum[3], PriceChance[4]*subChance[4][4]/subSum[4],
		PriceChance[1]*subChance[1][2]/subSum[1], PriceChance[4]*subChance[4][5]/subSum[4], PriceChance[3]*subChance[3][3]/subSum[3], PriceChance[4]*subChance[4][6]/subSum[4],
		PriceChance[2]*subChance[2][2]/subSum[2], PriceChance[4]*subChance[4][7]/subSum[4], PriceChance[3]*subChance[3][4]/subSum[3], PriceChance[4]*subChance[4][8]/subSum[4],
	}
	return NumList[ZLottery_Get_RanPoint(NumChance)]
end
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType44766SelectNumber(list, max_count)			--- Lottery Used@20120316(����_��������)
	local PriceChance = {28,180,3000}																						-- һ�����Ƚ�����(��λ:���֮)
	PriceChance[4] = 10000 - PriceChance[1] - PriceChance[2] - PriceChance[3]		--     �ĵȽ�����(��λ:���֮)
	
	local subChance = {}
	local subSum = {}
	subChance[1] = {10,8,2,8}					-- һ�Ƚ��ڲ���Ը���
	subChance[2] = {70,30,30,50}					-- ���Ƚ��ڲ���Ը���
	subChance[3] = {10,10,10,10}					-- ���Ƚ��ڲ���Ը���
	subChance[4] = {10,10,10,10}					-- �ĵȽ��ڲ���Ը���

	for j=1,4 do
		subSum[j] = 0
		for i,_ in pairs(subChance[j]) do
			subSum[j] = subSum[j] + subChance[j][i]
		end
	end
	
	local NumList = {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16}
	local NumChance =
	{
		PriceChance[1]*subChance[1][1]/subSum[1], 
		PriceChance[4]*subChance[4][1]/subSum[4], 
		PriceChance[2]*subChance[2][1]/subSum[2], 
		PriceChance[3]*subChance[3][1]/subSum[3],
		
		PriceChance[1]*subChance[1][2]/subSum[1], 
		PriceChance[3]*subChance[3][2]/subSum[3], 
		PriceChance[2]*subChance[2][2]/subSum[2], 
		PriceChance[4]*subChance[4][2]/subSum[4],

		PriceChance[1]*subChance[1][3]/subSum[1], 
		PriceChance[4]*subChance[4][3]/subSum[4], 
		PriceChance[2]*subChance[2][3]/subSum[2], 
		PriceChance[3]*subChance[3][3]/subSum[3],

		PriceChance[1]*subChance[1][4]/subSum[1], 
		PriceChance[3]*subChance[3][4]/subSum[3], 
		PriceChance[2]*subChance[2][4]/subSum[2], 
		PriceChance[4]*subChance[4][4]/subSum[4],
	}
	return NumList[ZLottery_Get_RanPoint(NumChance)]
end
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType51097SelectNumber(list, max_count)			--- (������֥2012-03-31����)
	local PriceChance = {40,120,3000}																						-- һ�����Ƚ�����(��λ:���֮)
	PriceChance[4] = 10000 - PriceChance[1] - PriceChance[2] - PriceChance[3]		--     �ĵȽ�����(��λ:���֮)
	
	local subChance = {}
	local subSum = {}
	subChance[1] = {28,5,2,5}					-- һ�Ƚ��ڲ���Ը���
	subChance[2] = {30,30,30,30}					-- ���Ƚ��ڲ���Ը���
	subChance[3] = {10,10,10,10}					-- ���Ƚ��ڲ���Ը���
	subChance[4] = {10,10,10,10}					-- �ĵȽ��ڲ���Ը���

	for j=1,4 do
		subSum[j] = 0
		for i,_ in pairs(subChance[j]) do
			subSum[j] = subSum[j] + subChance[j][i]
		end
	end
	
	local NumList = {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16}
	local NumChance =
	{
		PriceChance[1]*subChance[1][1]/subSum[1], 
		PriceChance[4]*subChance[4][1]/subSum[4], 
		PriceChance[2]*subChance[2][1]/subSum[2], 
		PriceChance[3]*subChance[3][1]/subSum[3],
		
		PriceChance[1]*subChance[1][2]/subSum[1], 
		PriceChance[3]*subChance[3][2]/subSum[3], 
		PriceChance[2]*subChance[2][2]/subSum[2], 
		PriceChance[4]*subChance[4][2]/subSum[4],

		PriceChance[1]*subChance[1][3]/subSum[1], 
		PriceChance[4]*subChance[4][3]/subSum[4], 
		PriceChance[2]*subChance[2][3]/subSum[2], 
		PriceChance[3]*subChance[3][3]/subSum[3],

		PriceChance[1]*subChance[1][4]/subSum[1], 
		PriceChance[3]*subChance[3][4]/subSum[3], 
		PriceChance[2]*subChance[2][4]/subSum[2], 
		PriceChance[4]*subChance[4][4]/subSum[4],
	}
	return NumList[ZLottery_Get_RanPoint(NumChance)]
end
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType51203SelectNumber(list, max_count)			---(��������2012-05-04����)
	local PriceChance = {40,120,3000}																						-- һ�����Ƚ�����(��λ:���֮)
	PriceChance[4] = 10000 - PriceChance[1] - PriceChance[2] - PriceChance[3]		--     �ĵȽ�����(��λ:���֮)
	
	local subChance = {}
	local subSum = {}
	subChance[1] = {20,15,2,3}					-- һ�Ƚ��ڲ���Ը���
	subChance[2] = {30,30,30,30}					-- ���Ƚ��ڲ���Ը���
	subChance[3] = {10,10,10,10}					-- ���Ƚ��ڲ���Ը���
	subChance[4] = {10,10,10,10}					-- �ĵȽ��ڲ���Ը���

	for j=1,4 do
		subSum[j] = 0
		for i,_ in pairs(subChance[j]) do
			subSum[j] = subSum[j] + subChance[j][i]
		end
	end
	
	local NumList = {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16}
	local NumChance =
	{
		PriceChance[1]*subChance[1][1]/subSum[1], 
		PriceChance[4]*subChance[4][1]/subSum[4], 
		PriceChance[2]*subChance[2][1]/subSum[2], 
		PriceChance[3]*subChance[3][1]/subSum[3],
		
		PriceChance[1]*subChance[1][2]/subSum[1], 
		PriceChance[3]*subChance[3][2]/subSum[3], 
		PriceChance[2]*subChance[2][2]/subSum[2], 
		PriceChance[4]*subChance[4][2]/subSum[4],

		PriceChance[1]*subChance[1][3]/subSum[1], 
		PriceChance[4]*subChance[4][3]/subSum[4], 
		PriceChance[2]*subChance[2][3]/subSum[2], 
		PriceChance[3]*subChance[3][3]/subSum[3],

		PriceChance[1]*subChance[1][4]/subSum[1], 
		PriceChance[3]*subChance[3][4]/subSum[3], 
		PriceChance[2]*subChance[2][4]/subSum[2], 
		PriceChance[4]*subChance[4][4]/subSum[4],
	}
	return NumList[ZLottery_Get_RanPoint(NumChance)]
end
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType51267SelectNumber(list, max_count)			---(������ʯ2012-06-08����)
	local PriceChance = {40,120,3000}																						-- һ�����Ƚ�����(��λ:���֮)
	PriceChance[4] = 10000 - PriceChance[1] - PriceChance[2] - PriceChance[3]		--     �ĵȽ�����(��λ:���֮)
	
	local subChance = {}
	local subSum = {}
	subChance[1] = {22,8,2,8}					-- һ�Ƚ��ڲ���Ը���
	subChance[2] = {30,30,30,30}					-- ���Ƚ��ڲ���Ը���
	subChance[3] = {10,10,10,10}					-- ���Ƚ��ڲ���Ը���
	subChance[4] = {10,10,10,10}					-- �ĵȽ��ڲ���Ը���

	for j=1,4 do
		subSum[j] = 0
		for i,_ in pairs(subChance[j]) do
			subSum[j] = subSum[j] + subChance[j][i]
		end
	end
	
	local NumList = {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16}
	local NumChance =
	{
		PriceChance[1]*subChance[1][1]/subSum[1], 
		PriceChance[4]*subChance[4][1]/subSum[4], 
		PriceChance[2]*subChance[2][1]/subSum[2], 
		PriceChance[3]*subChance[3][1]/subSum[3],
		
		PriceChance[1]*subChance[1][2]/subSum[1], 
		PriceChance[3]*subChance[3][2]/subSum[3], 
		PriceChance[2]*subChance[2][2]/subSum[2], 
		PriceChance[4]*subChance[4][2]/subSum[4],

		PriceChance[1]*subChance[1][3]/subSum[1], 
		PriceChance[4]*subChance[4][3]/subSum[4], 
		PriceChance[2]*subChance[2][3]/subSum[2], 
		PriceChance[3]*subChance[3][3]/subSum[3],

		PriceChance[1]*subChance[1][4]/subSum[1], 
		PriceChance[3]*subChance[3][4]/subSum[3], 
		PriceChance[2]*subChance[2][4]/subSum[2], 
		PriceChance[4]*subChance[4][4]/subSum[4],
	}
	return NumList[ZLottery_Get_RanPoint(NumChance)]
end
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType40670SelectNumber(list, max_count)			--- Lottery Used@20120723(����_�˼��¯)
	local PriceChance = {7,150,3000}																						-- һ�����Ƚ�����(��λ:���֮)
	PriceChance[4] = 10000 - PriceChance[1] - PriceChance[2] - PriceChance[3]		--     �ĵȽ�����(��λ:���֮)
	
	local subChance = {}
	local subSum = {}
	subChance[1] = {25,10,10,25}					-- һ�Ƚ��ڲ���Ը���
	subChance[2] = {25,50,50,25}						-- ���Ƚ��ڲ���Ը���
	subChance[3] = {10,10,10,10}							-- ���Ƚ��ڲ���Ը���
	subChance[4] = {10,40,40,10}						-- �ĵȽ��ڲ���Ը���

	for j=1,4 do
		subSum[j] = 0
		for i,_ in pairs(subChance[j]) do
			subSum[j] = subSum[j] + subChance[j][i]
		end
	end
	
	local NumList = {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16}
	local NumChance =
	{
		PriceChance[1]*subChance[1][1]/subSum[1], 
		PriceChance[4]*subChance[4][1]/subSum[4], 
		PriceChance[2]*subChance[2][1]/subSum[2], 
		PriceChance[3]*subChance[3][1]/subSum[3],
		
		PriceChance[1]*subChance[1][2]/subSum[1], 
		PriceChance[3]*subChance[3][2]/subSum[3], 
		PriceChance[2]*subChance[2][2]/subSum[2], 
		PriceChance[4]*subChance[4][2]/subSum[4],

		PriceChance[1]*subChance[1][3]/subSum[1], 
		PriceChance[4]*subChance[4][3]/subSum[4], 
		PriceChance[2]*subChance[2][3]/subSum[2], 
		PriceChance[3]*subChance[3][3]/subSum[3],

		PriceChance[1]*subChance[1][4]/subSum[1], 
		PriceChance[3]*subChance[3][4]/subSum[3], 
		PriceChance[2]*subChance[2][4]/subSum[2], 
		PriceChance[4]*subChance[4][4]/subSum[4],
	}
	return NumList[ZLottery_Get_RanPoint(NumChance)]
end
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType40344SelectNumber(list, max_count)			--- Lottery Used@20120723(����_ʮȫ����)
	local PriceChance = {18,150,4000}																						-- һ�����Ƚ�����(��λ:���֮)
	PriceChance[4] = 10000 - PriceChance[1] - PriceChance[2] - PriceChance[3]		--     �ĵȽ�����(��λ:���֮)
	
	local subChance = {}
	local subSum = {}
	subChance[1] = {100,40,20,20}						-- һ�Ƚ��ڲ���Ը���
	subChance[2] = {25,60,40,25}						-- ���Ƚ��ڲ���Ը���
	subChance[3] = {10,10,10,10}						-- ���Ƚ��ڲ���Ը���
	subChance[4] = {80,20,20,80}						-- �ĵȽ��ڲ���Ը���

	for j=1,4 do
		subSum[j] = 0
		for i,_ in pairs(subChance[j]) do
			subSum[j] = subSum[j] + subChance[j][i]
		end
	end
	
	local NumList = {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16}
	local NumChance =
	{
		PriceChance[1]*subChance[1][1]/subSum[1], 
		PriceChance[4]*subChance[4][1]/subSum[4], 
		PriceChance[2]*subChance[2][1]/subSum[2], 
		PriceChance[3]*subChance[3][1]/subSum[3],
		
		PriceChance[1]*subChance[1][2]/subSum[1], 
		PriceChance[3]*subChance[3][2]/subSum[3], 
		PriceChance[2]*subChance[2][2]/subSum[2], 
		PriceChance[4]*subChance[4][2]/subSum[4],

		PriceChance[1]*subChance[1][3]/subSum[1], 
		PriceChance[4]*subChance[4][3]/subSum[4], 
		PriceChance[2]*subChance[2][3]/subSum[2], 
		PriceChance[3]*subChance[3][3]/subSum[3],

		PriceChance[1]*subChance[1][4]/subSum[1], 
		PriceChance[3]*subChance[3][4]/subSum[3], 
		PriceChance[2]*subChance[2][4]/subSum[2], 
		PriceChance[4]*subChance[4][4]/subSum[4],
	}
	return NumList[ZLottery_Get_RanPoint(NumChance)]
end
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType35361SelectNumber(list, max_count)			--- (����ϻ2012-08-06����)
	local PriceChance = {10,150,3000}																						-- һ�����Ƚ�����(��λ:���֮)
	PriceChance[4] = 10000 - PriceChance[1] - PriceChance[2] - PriceChance[3]		--     �ĵȽ�����(��λ:���֮)
	
	local subChance = {}
	local subSum = {}
	subChance[1] = {10}												-- һ�Ƚ��ڲ���Ը���(1��)
	subChance[2] = {50,50,50}									-- ���Ƚ��ڲ���Ը���(5�ţ�9�ţ�13��)
	subChance[3] = {750,750,750,750}					-- ���Ƚ��ڲ���Ը���(3�ţ�7�ţ�11�ţ�15��)
	subChance[4] = {50,40,10,50,50,10,40,50}	-- �ĵȽ��ڲ���Ը���(2,4,6,8,10,12,14,16)

	for j=1,4 do
		subSum[j] = 0
		for i,_ in pairs(subChance[j]) do
			subSum[j] = subSum[j] + subChance[j][i]
		end
	end
	
	local NumList = {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16}
	local NumChance =
	{
		PriceChance[1], 													PriceChance[4]*subChance[4][1]/subSum[4], PriceChance[3]*subChance[3][1]/subSum[3], PriceChance[4]*subChance[4][2]/subSum[4],
		PriceChance[2]*subChance[2][1]/subSum[2], PriceChance[4]*subChance[4][3]/subSum[4], PriceChance[3]*subChance[3][2]/subSum[3], PriceChance[4]*subChance[4][4]/subSum[4],
		PriceChance[2]*subChance[2][2]/subSum[2], PriceChance[4]*subChance[4][5]/subSum[4], PriceChance[3]*subChance[3][3]/subSum[3], PriceChance[4]*subChance[4][6]/subSum[4],
		PriceChance[2]*subChance[2][3]/subSum[2], PriceChance[4]*subChance[4][7]/subSum[4], PriceChance[3]*subChance[3][4]/subSum[3], PriceChance[4]*subChance[4][8]/subSum[4],
	}
	return NumList[ZLottery_Get_RanPoint(NumChance)]
end
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType32692SelectNumber(list, max_count)			---(���޻�Ҷ)
	local PriceChance = {20,100,4500}																						-- һ�����Ƚ�����(��λ:���֮)
	PriceChance[4] = 10000 - PriceChance[1] - PriceChance[2] - PriceChance[3]		--     �ĵȽ�����(��λ:���֮)
	
	local subChance = {}
	local subSum = {}
	subChance[1] = {10,10}										-- һ�Ƚ��ڲ���Ը���(1�ţ�9��)
	subChance[2] = {80,20}										-- ���Ƚ��ڲ���Ը���(5�ţ�13��)
	subChance[3] = {1250,1000,1000,1250}			-- ���Ƚ��ڲ���Ը���(3�ţ�7�ţ�11�ţ�15��)
	subChance[4] = {25,10,10,25,25,40,40,25}	-- �ĵȽ��ڲ���Ը���(2,4,6,8,10,12,14,16)

	for j=1,4 do
		subSum[j] = 0
		for i,_ in pairs(subChance[j]) do
			subSum[j] = subSum[j] + subChance[j][i]
		end
	end
	
	local NumList = {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16}
	local NumChance =
	{
		PriceChance[1]*subChance[1][1]/subSum[1], PriceChance[4]*subChance[4][1]/subSum[4], PriceChance[3]*subChance[3][1]/subSum[3], PriceChance[4]*subChance[4][2]/subSum[4],
		PriceChance[2]*subChance[2][1]/subSum[2], PriceChance[4]*subChance[4][3]/subSum[4], PriceChance[3]*subChance[3][2]/subSum[3], PriceChance[4]*subChance[4][4]/subSum[4],
		PriceChance[1]*subChance[1][2]/subSum[1], PriceChance[4]*subChance[4][5]/subSum[4], PriceChance[3]*subChance[3][3]/subSum[3], PriceChance[4]*subChance[4][6]/subSum[4],
		PriceChance[2]*subChance[2][2]/subSum[2], PriceChance[4]*subChance[4][7]/subSum[4], PriceChance[3]*subChance[3][4]/subSum[3], PriceChance[4]*subChance[4][8]/subSum[4],
	}
	return NumList[ZLottery_Get_RanPoint(NumChance)]
end
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType41391SelectNumber(list, max_count)			--- (Х�����2012-08-17����)
	local PriceChance = {20,200,3000}																						-- һ�����Ƚ�����(��λ:���֮)
	PriceChance[4] = 10000 - PriceChance[1] - PriceChance[2] - PriceChance[3]		--     �ĵȽ�����(��λ:���֮)
	
	local subChance = {}
	local subSum = {}
	subChance[1] = {60,25,5,10}					-- һ�Ƚ��ڲ���Ը���
	subChance[2] = {50,50,50,50}					-- ���Ƚ��ڲ���Ը���
	subChance[3] = {10,10,10,10}					-- ���Ƚ��ڲ���Ը���
	subChance[4] = {10,10,15,15}					-- �ĵȽ��ڲ���Ը���

	for j=1,4 do
		subSum[j] = 0
		for i,_ in pairs(subChance[j]) do
			subSum[j] = subSum[j] + subChance[j][i]
		end
	end
	
	local NumList = {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16}
	local NumChance =
	{
		PriceChance[1]*subChance[1][1]/subSum[1], 
		PriceChance[4]*subChance[4][1]/subSum[4], 
		PriceChance[2]*subChance[2][1]/subSum[2], 
		PriceChance[3]*subChance[3][1]/subSum[3],
		
		PriceChance[1]*subChance[1][2]/subSum[1], 
		PriceChance[3]*subChance[3][2]/subSum[3], 
		PriceChance[2]*subChance[2][2]/subSum[2], 
		PriceChance[4]*subChance[4][2]/subSum[4],

		PriceChance[1]*subChance[1][3]/subSum[1], 
		PriceChance[4]*subChance[4][3]/subSum[4], 
		PriceChance[2]*subChance[2][3]/subSum[2], 
		PriceChance[3]*subChance[3][3]/subSum[3],

		PriceChance[1]*subChance[1][4]/subSum[1], 
		PriceChance[3]*subChance[3][4]/subSum[3], 
		PriceChance[2]*subChance[2][4]/subSum[2], 
		PriceChance[4]*subChance[4][4]/subSum[4],
	}
	return NumList[ZLottery_Get_RanPoint(NumChance)]
end
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType52346SelectNumber(list, max_count)			--- (ʱ�ⱦ��2012-08-17����)
	local PriceChance = {30,120,3000}																						-- һ�����Ƚ�����(��λ:���֮)
	PriceChance[4] = 10000 - PriceChance[1] - PriceChance[2] - PriceChance[3]		--     �ĵȽ�����(��λ:���֮)
	
	local subChance = {}
	local subSum = {}
	subChance[1] = {18,5,2,5}					-- һ�Ƚ��ڲ���Ը���
	subChance[2] = {30,30,30,30}					-- ���Ƚ��ڲ���Ը���
	subChance[3] = {10,10,10,10}					-- ���Ƚ��ڲ���Ը���
	subChance[4] = {10,10,10,10}					-- �ĵȽ��ڲ���Ը���

	for j=1,4 do
		subSum[j] = 0
		for i,_ in pairs(subChance[j]) do
			subSum[j] = subSum[j] + subChance[j][i]
		end
	end
	
	local NumList = {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16}
	local NumChance =
	{
		PriceChance[1]*subChance[1][1]/subSum[1], 
		PriceChance[4]*subChance[4][1]/subSum[4], 
		PriceChance[2]*subChance[2][1]/subSum[2], 
		PriceChance[3]*subChance[3][1]/subSum[3],
		
		PriceChance[1]*subChance[1][2]/subSum[1], 
		PriceChance[3]*subChance[3][2]/subSum[3], 
		PriceChance[2]*subChance[2][2]/subSum[2], 
		PriceChance[4]*subChance[4][2]/subSum[4],

		PriceChance[1]*subChance[1][3]/subSum[1], 
		PriceChance[4]*subChance[4][3]/subSum[4], 
		PriceChance[2]*subChance[2][3]/subSum[2], 
		PriceChance[3]*subChance[3][3]/subSum[3],

		PriceChance[1]*subChance[1][4]/subSum[1], 
		PriceChance[3]*subChance[3][4]/subSum[3], 
		PriceChance[2]*subChance[2][4]/subSum[2], 
		PriceChance[4]*subChance[4][4]/subSum[4],
	}
	return NumList[ZLottery_Get_RanPoint(NumChance)]
end
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType51452SelectNumber(list, max_count)			--- (��ɫ����2012-09-13����)
	local PriceChance = {40,120,3000}																						-- һ�����Ƚ�����(��λ:���֮)
	PriceChance[4] = 10000 - PriceChance[1] - PriceChance[2] - PriceChance[3]		--     �ĵȽ�����(��λ:���֮)
	
	local subChance = {}
	local subSum = {}
	subChance[1] = {22,8,2,8}					-- һ�Ƚ��ڲ���Ը���
	subChance[2] = {30,30,30,30}					-- ���Ƚ��ڲ���Ը���
	subChance[3] = {10,10,10,10}					-- ���Ƚ��ڲ���Ը���
	subChance[4] = {10,10,10,10}					-- �ĵȽ��ڲ���Ը���

	for j=1,4 do
		subSum[j] = 0
		for i,_ in pairs(subChance[j]) do
			subSum[j] = subSum[j] + subChance[j][i]
		end
	end
	
	local NumList = {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16}
	local NumChance =
	{
		PriceChance[1]*subChance[1][1]/subSum[1], 
		PriceChance[4]*subChance[4][1]/subSum[4], 
		PriceChance[2]*subChance[2][1]/subSum[2], 
		PriceChance[3]*subChance[3][1]/subSum[3],
		
		PriceChance[1]*subChance[1][2]/subSum[1], 
		PriceChance[3]*subChance[3][2]/subSum[3], 
		PriceChance[2]*subChance[2][2]/subSum[2], 
		PriceChance[4]*subChance[4][2]/subSum[4],

		PriceChance[1]*subChance[1][3]/subSum[1], 
		PriceChance[4]*subChance[4][3]/subSum[4], 
		PriceChance[2]*subChance[2][3]/subSum[2], 
		PriceChance[3]*subChance[3][3]/subSum[3],

		PriceChance[1]*subChance[1][4]/subSum[1], 
		PriceChance[3]*subChance[3][4]/subSum[3], 
		PriceChance[2]*subChance[2][4]/subSum[2], 
		PriceChance[4]*subChance[4][4]/subSum[4],
	}
	return NumList[ZLottery_Get_RanPoint(NumChance)]
end
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType40346SelectNumber(list, max_count)			---(��������2012-09-20����)
	local PriceChance = {20,100,3000}																						-- һ�����Ƚ�����(��λ:���֮)
	PriceChance[4] = 10000 - PriceChance[1] - PriceChance[2] - PriceChance[3]		--     �ĵȽ�����(��λ:���֮)
	
	local subChance = {}
	local subSum = {}
	subChance[1] = {20}												-- һ�Ƚ��ڲ���Ը���(1��)
	subChance[2] = {33,33,33}									-- ���Ƚ��ڲ���Ը���(5�ţ�9�ţ�13��)
	subChance[3] = {500,1000,1000,500}				-- ���Ƚ��ڲ���Ը���(3�ţ�7�ţ�11�ţ�15��)
	subChance[4] = {30,20,20,30,30,20,20,30}	-- �ĵȽ��ڲ���Ը���(2,4,6,8,10,12,14,16)

	for j=1,4 do
		subSum[j] = 0
		for i,_ in pairs(subChance[j]) do
			subSum[j] = subSum[j] + subChance[j][i]
		end
	end
	
	local NumList = {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16}
	local NumChance =
	{
		PriceChance[1], 													PriceChance[4]*subChance[4][1]/subSum[4], PriceChance[3]*subChance[3][1]/subSum[3], PriceChance[4]*subChance[4][2]/subSum[4],
		PriceChance[2]*subChance[2][1]/subSum[2], PriceChance[4]*subChance[4][3]/subSum[4], PriceChance[3]*subChance[3][2]/subSum[3], PriceChance[4]*subChance[4][4]/subSum[4],
		PriceChance[2]*subChance[2][2]/subSum[2], PriceChance[4]*subChance[4][5]/subSum[4], PriceChance[3]*subChance[3][3]/subSum[3], PriceChance[4]*subChance[4][6]/subSum[4],
		PriceChance[2]*subChance[2][3]/subSum[2], PriceChance[4]*subChance[4][7]/subSum[4], PriceChance[3]*subChance[3][4]/subSum[3], PriceChance[4]*subChance[4][8]/subSum[4],
	}
	return NumList[ZLottery_Get_RanPoint(NumChance)]
end
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType25749SelectNumber(list, max_count)			--- (̫�Կ���2012-09-27����)
	local PriceChance = {20,100,4000}																						-- һ�����Ƚ�����(��λ:���֮)
	PriceChance[4] = 10000 - PriceChance[1] - PriceChance[2] - PriceChance[3]		--     �ĵȽ�����(��λ:���֮)
	
	local subChance = {}
	local subSum = {}
	subChance[1] = {20}												-- һ�Ƚ��ڲ���Ը���(1��)
	subChance[2] = {33,33,33}									-- ���Ƚ��ڲ���Ը���(5�ţ�9�ţ�13��)
	subChance[3] = {1000,1000,1000,1000}			-- ���Ƚ��ڲ���Ը���(3�ţ�7�ţ�11�ţ�15��)
	subChance[4] = {25,10,10,25,25,40,40,25}	-- �ĵȽ��ڲ���Ը���(2,4,6,8,10,12,14,16)

	for j=1,4 do
		subSum[j] = 0
		for i,_ in pairs(subChance[j]) do
			subSum[j] = subSum[j] + subChance[j][i]
		end
	end
	
	local NumList = {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16}
	local NumChance =
	{
		PriceChance[1], 													PriceChance[4]*subChance[4][1]/subSum[4], PriceChance[3]*subChance[3][1]/subSum[3], PriceChance[4]*subChance[4][2]/subSum[4],
		PriceChance[2]*subChance[2][1]/subSum[2], PriceChance[4]*subChance[4][3]/subSum[4], PriceChance[3]*subChance[3][2]/subSum[3], PriceChance[4]*subChance[4][4]/subSum[4],
		PriceChance[2]*subChance[2][2]/subSum[2], PriceChance[4]*subChance[4][5]/subSum[4], PriceChance[3]*subChance[3][3]/subSum[3], PriceChance[4]*subChance[4][6]/subSum[4],
		PriceChance[2]*subChance[2][3]/subSum[2], PriceChance[4]*subChance[4][7]/subSum[4], PriceChance[3]*subChance[3][4]/subSum[3], PriceChance[4]*subChance[4][8]/subSum[4],
	}
	return NumList[ZLottery_Get_RanPoint(NumChance)]
end
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType52751SelectNumber(list, max_count)			---(������Ե��2012-10-12����)
	local PriceChance = {150,1000,1000}																						-- һ�����Ƚ�����(��λ:���֮)
	PriceChance[4] = 10000 - PriceChance[1] - PriceChance[2] - PriceChance[3]		--     �ĵȽ�����(��λ:���֮)
	
	local subChance = {}
	local subSum = {}
	subChance[1] = {15,35,15,35}							    -- һ�Ƚ��ڲ���Ը��ʣ�1,5,9,13��
	subChance[2] = {25,25,25,25}					   	    -- ���Ƚ��ڲ���Ը��ʣ�3,7,11,15��
	subChance[3] = {25,25,25,25}						      -- ���Ƚ��ڲ���Ը��ʣ�4,6,12,14��
	subChance[4] = {3000,900,1000,3000}			      -- �ĵȽ��ڲ���Ը��ʣ�2,8,10,16��

	for j=1,4 do
		subSum[j] = 0
		for i,_ in pairs(subChance[j]) do
			subSum[j] = subSum[j] + subChance[j][i]
		end
	end
	
	local NumList = {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16}
	local NumChance =
	{
		PriceChance[1]*subChance[1][1]/subSum[1], 
		PriceChance[4]*subChance[4][1]/subSum[4], 
		PriceChance[2]*subChance[2][1]/subSum[2], 
		PriceChance[3]*subChance[3][1]/subSum[3],
		
		PriceChance[1]*subChance[1][2]/subSum[1], 
		PriceChance[3]*subChance[3][2]/subSum[3], 
		PriceChance[2]*subChance[2][2]/subSum[2], 
		PriceChance[4]*subChance[4][2]/subSum[4],

		PriceChance[1]*subChance[1][3]/subSum[1], 
		PriceChance[4]*subChance[4][3]/subSum[4], 
		PriceChance[2]*subChance[2][3]/subSum[2], 
		PriceChance[3]*subChance[3][3]/subSum[3],

		PriceChance[1]*subChance[1][4]/subSum[1], 
		PriceChance[3]*subChance[3][4]/subSum[3], 
		PriceChance[2]*subChance[2][4]/subSum[2], 
		PriceChance[4]*subChance[4][4]/subSum[4],
	}
	return NumList[ZLottery_Get_RanPoint(NumChance)]
end
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType44823SelectNumber(list, max_count)			--- (���ɱ���2012-10-12����)
	local PriceChance = {20,120,3000}																						-- һ�����Ƚ�����(��λ:���֮)
	PriceChance[4] = 10000 - PriceChance[1] - PriceChance[2] - PriceChance[3]		--     �ĵȽ�����(��λ:���֮)
	
	local subChance = {}
	local subSum = {}
	subChance[1] = {50,20,50,80}					-- һ�Ƚ��ڲ���Ը���
	subChance[2] = {30,30,30,30}					-- ���Ƚ��ڲ���Ը���
	subChance[3] = {10,10,10,10}					-- ���Ƚ��ڲ���Ը���
	subChance[4] = {10,10,10,10}					-- �ĵȽ��ڲ���Ը���

	for j=1,4 do
		subSum[j] = 0
		for i,_ in pairs(subChance[j]) do
			subSum[j] = subSum[j] + subChance[j][i]
		end
	end
	
	local NumList = {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16}
	local NumChance =
	{
		PriceChance[1]*subChance[1][1]/subSum[1], 
		PriceChance[4]*subChance[4][1]/subSum[4], 
		PriceChance[2]*subChance[2][1]/subSum[2], 
		PriceChance[3]*subChance[3][1]/subSum[3],
		
		PriceChance[1]*subChance[1][2]/subSum[1], 
		PriceChance[3]*subChance[3][2]/subSum[3], 
		PriceChance[2]*subChance[2][2]/subSum[2], 
		PriceChance[4]*subChance[4][2]/subSum[4],

		PriceChance[1]*subChance[1][3]/subSum[1], 
		PriceChance[4]*subChance[4][3]/subSum[4], 
		PriceChance[2]*subChance[2][3]/subSum[2], 
		PriceChance[3]*subChance[3][3]/subSum[3],

		PriceChance[1]*subChance[1][4]/subSum[1], 
		PriceChance[3]*subChance[3][4]/subSum[3], 
		PriceChance[2]*subChance[2][4]/subSum[2], 
		PriceChance[4]*subChance[4][4]/subSum[4],
	}
	return NumList[ZLottery_Get_RanPoint(NumChance)]
end
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType41307SelectNumber(list, max_count)			---(ǧ������2012-10-19����)
	local PriceChance = {30,300,3000}																						-- һ�����Ƚ�����(��λ:���֮)
	PriceChance[4] = 10000 - PriceChance[1] - PriceChance[2] - PriceChance[3]		--     �ĵȽ�����(��λ:���֮)
	
	local subChance = {}
	local subSum = {}
	subChance[1] = {25,50,25,50}					-- һ�Ƚ��ڲ���Ը���
	subChance[2] = {25,50,50,25}					-- ���Ƚ��ڲ���Ը���
	subChance[3] = {10,10,10,10}					-- ���Ƚ��ڲ���Ը���
	subChance[4] = {10,10,10,20}					-- �ĵȽ��ڲ���Ը���

	for j=1,4 do
		subSum[j] = 0
		for i,_ in pairs(subChance[j]) do
			subSum[j] = subSum[j] + subChance[j][i]
		end
	end
	
	local NumList = {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16}
	local NumChance =
	{
		PriceChance[1]*subChance[1][1]/subSum[1], 
		PriceChance[4]*subChance[4][1]/subSum[4], 
		PriceChance[2]*subChance[2][1]/subSum[2], 
		PriceChance[3]*subChance[3][1]/subSum[3],
		
		PriceChance[1]*subChance[1][2]/subSum[1], 
		PriceChance[3]*subChance[3][2]/subSum[3], 
		PriceChance[2]*subChance[2][2]/subSum[2], 
		PriceChance[4]*subChance[4][2]/subSum[4],

		PriceChance[1]*subChance[1][3]/subSum[1], 
		PriceChance[4]*subChance[4][3]/subSum[4], 
		PriceChance[2]*subChance[2][3]/subSum[2], 
		PriceChance[3]*subChance[3][3]/subSum[3],

		PriceChance[1]*subChance[1][4]/subSum[1], 
		PriceChance[3]*subChance[3][4]/subSum[3], 
		PriceChance[2]*subChance[2][4]/subSum[2], 
		PriceChance[4]*subChance[4][4]/subSum[4],
	}
	return NumList[ZLottery_Get_RanPoint(NumChance)]
end
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType42338SelectNumber(list, max_count)			---(��ɣ��ľ2012-10-19����)
	local PriceChance = {30,300,3000}																						-- һ�����Ƚ�����(��λ:���֮)
	PriceChance[4] = 10000 - PriceChance[1] - PriceChance[2] - PriceChance[3]		--     �ĵȽ�����(��λ:���֮)
	
	local subChance = {}
	local subSum = {}
	subChance[1] = {25,50,25,50}					-- һ�Ƚ��ڲ���Ը���
	subChance[2] = {25,50,50,25}					-- ���Ƚ��ڲ���Ը���
	subChance[3] = {10,10,10,10}					-- ���Ƚ��ڲ���Ը���
	subChance[4] = {10,10,10,20}					-- �ĵȽ��ڲ���Ը���

	for j=1,4 do
		subSum[j] = 0
		for i,_ in pairs(subChance[j]) do
			subSum[j] = subSum[j] + subChance[j][i]
		end
	end
	
	local NumList = {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16}
	local NumChance =
	{
		PriceChance[1]*subChance[1][1]/subSum[1], 
		PriceChance[4]*subChance[4][1]/subSum[4], 
		PriceChance[2]*subChance[2][1]/subSum[2], 
		PriceChance[3]*subChance[3][1]/subSum[3],
		
		PriceChance[1]*subChance[1][2]/subSum[1], 
		PriceChance[3]*subChance[3][2]/subSum[3], 
		PriceChance[2]*subChance[2][2]/subSum[2], 
		PriceChance[4]*subChance[4][2]/subSum[4],

		PriceChance[1]*subChance[1][3]/subSum[1], 
		PriceChance[4]*subChance[4][3]/subSum[4], 
		PriceChance[2]*subChance[2][3]/subSum[2], 
		PriceChance[3]*subChance[3][3]/subSum[3],

		PriceChance[1]*subChance[1][4]/subSum[1], 
		PriceChance[3]*subChance[3][4]/subSum[3], 
		PriceChance[2]*subChance[2][4]/subSum[2], 
		PriceChance[4]*subChance[4][4]/subSum[4],
	}
	return NumList[ZLottery_Get_RanPoint(NumChance)]
end
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType40345SelectNumber(list, max_count)			---(��ػ��2012-10-19����)
	local PriceChance = {20,100,2500}																						-- һ�����Ƚ�����(��λ:���֮)
	PriceChance[4] = 10000 - PriceChance[1] - PriceChance[2] - PriceChance[3]		--     �ĵȽ�����(��λ:���֮)
	
	local subChance = {}
	local subSum = {}
	subChance[1] = {20}												-- һ�Ƚ��ڲ���Ը���(1��)
	subChance[2] = {33,33,33}									-- ���Ƚ��ڲ���Ը���(5�ţ�9�ţ�13��)
	subChance[3] = {500,1000,500,500}					-- ���Ƚ��ڲ���Ը���(3�ţ�7�ţ�11�ţ�15��)
	subChance[4] = {30,20,20,30,30,20,20,30}	-- �ĵȽ��ڲ���Ը���(2,4,6,8,10,12,14,16)

	for j=1,4 do
		subSum[j] = 0
		for i,_ in pairs(subChance[j]) do
			subSum[j] = subSum[j] + subChance[j][i]
		end
	end
	
	local NumList = {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16}
	local NumChance =
	{
		PriceChance[1], 													PriceChance[4]*subChance[4][1]/subSum[4], PriceChance[3]*subChance[3][1]/subSum[3], PriceChance[4]*subChance[4][2]/subSum[4],
		PriceChance[2]*subChance[2][1]/subSum[2], PriceChance[4]*subChance[4][3]/subSum[4], PriceChance[3]*subChance[3][2]/subSum[3], PriceChance[4]*subChance[4][4]/subSum[4],
		PriceChance[2]*subChance[2][2]/subSum[2], PriceChance[4]*subChance[4][5]/subSum[4], PriceChance[3]*subChance[3][3]/subSum[3], PriceChance[4]*subChance[4][6]/subSum[4],
		PriceChance[2]*subChance[2][3]/subSum[2], PriceChance[4]*subChance[4][7]/subSum[4], PriceChance[3]*subChance[3][4]/subSum[3], PriceChance[4]*subChance[4][8]/subSum[4],
	}
	return NumList[ZLottery_Get_RanPoint(NumChance)]
end

-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType50984SelectNumber(list, max_count)			---(��ɫʥ��2012-12-06����)
	local PriceChance = {40,120,3000}																						-- һ�����Ƚ�����(��λ:���֮)
	PriceChance[4] = 10000 - PriceChance[1] - PriceChance[2] - PriceChance[3]		--     �ĵȽ�����(��λ:���֮)
	
	local subChance = {}
	local subSum = {}
	subChance[1] = {22,8,2,8}					-- һ�Ƚ��ڲ���Ը���
	subChance[2] = {30,30,30,30}					-- ���Ƚ��ڲ���Ը���
	subChance[3] = {10,10,10,10}					-- ���Ƚ��ڲ���Ը���
	subChance[4] = {10,10,10,10}					-- �ĵȽ��ڲ���Ը���

	for j=1,4 do
		subSum[j] = 0
		for i,_ in pairs(subChance[j]) do
			subSum[j] = subSum[j] + subChance[j][i]
		end
	end
	
	local NumList = {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16}
	local NumChance =
	{
		PriceChance[1]*subChance[1][1]/subSum[1], 
		PriceChance[4]*subChance[4][1]/subSum[4], 
		PriceChance[2]*subChance[2][1]/subSum[2], 
		PriceChance[3]*subChance[3][1]/subSum[3],
		
		PriceChance[1]*subChance[1][2]/subSum[1], 
		PriceChance[3]*subChance[3][2]/subSum[3], 
		PriceChance[2]*subChance[2][2]/subSum[2], 
		PriceChance[4]*subChance[4][2]/subSum[4],

		PriceChance[1]*subChance[1][3]/subSum[1], 
		PriceChance[4]*subChance[4][3]/subSum[4], 
		PriceChance[2]*subChance[2][3]/subSum[2], 
		PriceChance[3]*subChance[3][3]/subSum[3],

		PriceChance[1]*subChance[1][4]/subSum[1], 
		PriceChance[3]*subChance[3][4]/subSum[3], 
		PriceChance[2]*subChance[2][4]/subSum[2], 
		PriceChance[4]*subChance[4][4]/subSum[4],
	}
	return NumList[ZLottery_Get_RanPoint(NumChance)]
end
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType54054SelectNumber(list, max_count)			--- Lottery Used@201220901(��������)
	local PriceChance = {30,120,3000}																						-- һ�����Ƚ�����(��λ:���֮)
	PriceChance[4] = 10000 - PriceChance[1] - PriceChance[2] - PriceChance[3]		--     �ĵȽ�����(��λ:���֮)
	
	local subChance = {}
	local subSum = {}
	subChance[1] = {18,5,2,5}					-- һ�Ƚ��ڲ���Ը���
	subChance[2] = {30,30,30,30}					-- ���Ƚ��ڲ���Ը���
	subChance[3] = {10,10,10,10}					-- ���Ƚ��ڲ���Ը���
	subChance[4] = {10,10,10,10}					-- �ĵȽ��ڲ���Ը���

	for j=1,4 do
		subSum[j] = 0
		for i,_ in pairs(subChance[j]) do
			subSum[j] = subSum[j] + subChance[j][i]
		end
	end
	
	local NumList = {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16}
	local NumChance =
	{
		PriceChance[1]*subChance[1][1]/subSum[1], 
		PriceChance[4]*subChance[4][1]/subSum[4], 
		PriceChance[2]*subChance[2][1]/subSum[2], 
		PriceChance[3]*subChance[3][1]/subSum[3],
		
		PriceChance[1]*subChance[1][2]/subSum[1], 
		PriceChance[3]*subChance[3][2]/subSum[3], 
		PriceChance[2]*subChance[2][2]/subSum[2], 
		PriceChance[4]*subChance[4][2]/subSum[4],

		PriceChance[1]*subChance[1][3]/subSum[1], 
		PriceChance[4]*subChance[4][3]/subSum[4], 
		PriceChance[2]*subChance[2][3]/subSum[2], 
		PriceChance[3]*subChance[3][3]/subSum[3],

		PriceChance[1]*subChance[1][4]/subSum[1], 
		PriceChance[3]*subChance[3][4]/subSum[3], 
		PriceChance[2]*subChance[2][4]/subSum[2], 
		PriceChance[4]*subChance[4][4]/subSum[4],
	}
	return NumList[ZLottery_Get_RanPoint(NumChance)]
end
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType54858SelectNumber(list, max_count)			--- Lottery Used@20130111(����-ҹ����ѩ)
	local PriceChance = {30,120,3000}																						-- һ�����Ƚ�����(��λ:���֮)
	PriceChance[4] = 10000 - PriceChance[1] - PriceChance[2] - PriceChance[3]		--     �ĵȽ�����(��λ:���֮)
	
	local subChance = {}
	local subSum = {}
	subChance[1] = {18,5,2,5}					-- һ�Ƚ��ڲ���Ը���
	subChance[2] = {30,30,30,30}					-- ���Ƚ��ڲ���Ը���
	subChance[3] = {10,10,10,10}					-- ���Ƚ��ڲ���Ը���
	subChance[4] = {10,10,10,10}					-- �ĵȽ��ڲ���Ը���

	for j=1,4 do
		subSum[j] = 0
		for i,_ in pairs(subChance[j]) do
			subSum[j] = subSum[j] + subChance[j][i]
		end
	end
	
	local NumList = {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16}
	local NumChance =
	{
		PriceChance[1]*subChance[1][1]/subSum[1], 
		PriceChance[4]*subChance[4][1]/subSum[4], 
		PriceChance[2]*subChance[2][1]/subSum[2], 
		PriceChance[3]*subChance[3][1]/subSum[3],
		
		PriceChance[1]*subChance[1][2]/subSum[1], 
		PriceChance[3]*subChance[3][2]/subSum[3], 
		PriceChance[2]*subChance[2][2]/subSum[2], 
		PriceChance[4]*subChance[4][2]/subSum[4],

		PriceChance[1]*subChance[1][3]/subSum[1], 
		PriceChance[4]*subChance[4][3]/subSum[4], 
		PriceChance[2]*subChance[2][3]/subSum[2], 
		PriceChance[3]*subChance[3][3]/subSum[3],

		PriceChance[1]*subChance[1][4]/subSum[1], 
		PriceChance[3]*subChance[3][4]/subSum[3], 
		PriceChance[2]*subChance[2][4]/subSum[2], 
		PriceChance[4]*subChance[4][4]/subSum[4],
	}
	return NumList[ZLottery_Get_RanPoint(NumChance)]
end
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType52457SelectNumber(list, max_count)			--- Lottery Used@20120607(�֮��)
	local PriceChance = {40,120,3000}																						-- һ�����Ƚ�����(��λ:���֮)
	PriceChance[4] = 10000 - PriceChance[1] - PriceChance[2] - PriceChance[3]		--     �ĵȽ�����(��λ:���֮)
	
	local subChance = {}
	local subSum = {}
	subChance[1] = {28,5,2,5}					-- һ�Ƚ��ڲ���Ը���
	subChance[2] = {30,30,30,30}					-- ���Ƚ��ڲ���Ը���
	subChance[3] = {10,10,10,10}					-- ���Ƚ��ڲ���Ը���
	subChance[4] = {10,10,10,10}					-- �ĵȽ��ڲ���Ը���

	for j=1,4 do
		subSum[j] = 0
		for i,_ in pairs(subChance[j]) do
			subSum[j] = subSum[j] + subChance[j][i]
		end
	end
	
	local NumList = {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16}
	local NumChance =
	{
		PriceChance[1]*subChance[1][1]/subSum[1], 
		PriceChance[4]*subChance[4][1]/subSum[4], 
		PriceChance[2]*subChance[2][1]/subSum[2], 
		PriceChance[3]*subChance[3][1]/subSum[3],
		
		PriceChance[1]*subChance[1][2]/subSum[1], 
		PriceChance[3]*subChance[3][2]/subSum[3], 
		PriceChance[2]*subChance[2][2]/subSum[2], 
		PriceChance[4]*subChance[4][2]/subSum[4],

		PriceChance[1]*subChance[1][3]/subSum[1], 
		PriceChance[4]*subChance[4][3]/subSum[4], 
		PriceChance[2]*subChance[2][3]/subSum[2], 
		PriceChance[3]*subChance[3][3]/subSum[3],

		PriceChance[1]*subChance[1][4]/subSum[1], 
		PriceChance[3]*subChance[3][4]/subSum[3], 
		PriceChance[2]*subChance[2][4]/subSum[2], 
		PriceChance[4]*subChance[4][4]/subSum[4],
	}
	return NumList[ZLottery_Get_RanPoint(NumChance)]
end
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType54031SelectNumber(list, max_count)			---(�������쾧��Ʊ2012-12-24����)
	local PriceChance = {200,2000,3000}																						-- һ�����Ƚ�����(��λ:���֮)
	PriceChance[4] = 10000 - PriceChance[1] - PriceChance[2] - PriceChance[3]		--     �ĵȽ�����(��λ:���֮)
	
	local subChance = {}
	local subSum = {}
	subChance[1] = {5,5,5,5}					-- һ�Ƚ��ڲ���Ը���
	subChance[2] = {30,30,30,30}					-- ���Ƚ��ڲ���Ը���
	subChance[3] = {10,10,10,10}					-- ���Ƚ��ڲ���Ը���
	subChance[4] = {10,10,10,10}					-- �ĵȽ��ڲ���Ը���

	for j=1,4 do
		subSum[j] = 0
		for i,_ in pairs(subChance[j]) do
			subSum[j] = subSum[j] + subChance[j][i]
		end
	end
	
	local NumList = {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16}
	local NumChance =
	{
		PriceChance[1]*subChance[1][1]/subSum[1], 
		PriceChance[4]*subChance[4][1]/subSum[4], 
		PriceChance[2]*subChance[2][1]/subSum[2], 
		PriceChance[3]*subChance[3][1]/subSum[3],
		
		PriceChance[1]*subChance[1][2]/subSum[1], 
		PriceChance[3]*subChance[3][2]/subSum[3], 
		PriceChance[2]*subChance[2][2]/subSum[2], 
		PriceChance[4]*subChance[4][2]/subSum[4],

		PriceChance[1]*subChance[1][3]/subSum[1], 
		PriceChance[4]*subChance[4][3]/subSum[4], 
		PriceChance[2]*subChance[2][3]/subSum[2], 
		PriceChance[3]*subChance[3][3]/subSum[3],

		PriceChance[1]*subChance[1][4]/subSum[1], 
		PriceChance[3]*subChance[3][4]/subSum[3], 
		PriceChance[2]*subChance[2][4]/subSum[2], 
		PriceChance[4]*subChance[4][4]/subSum[4],
	}
	return NumList[ZLottery_Get_RanPoint(NumChance)]
end
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType52471SelectNumber(list, max_count)			--- Lottery Used@20120628(�丸)
	local PriceChance = {40,120,3000}																						-- һ�����Ƚ�����(��λ:���֮)
	PriceChance[4] = 10000 - PriceChance[1] - PriceChance[2] - PriceChance[3]		--     �ĵȽ�����(��λ:���֮)
	
	local subChance = {}
	local subSum = {}
	subChance[1] = {22,8,2,8}					-- һ�Ƚ��ڲ���Ը���
	subChance[2] = {30,30,30,30}					-- ���Ƚ��ڲ���Ը���
	subChance[3] = {10,10,10,10}					-- ���Ƚ��ڲ���Ը���
	subChance[4] = {10,10,10,10}					-- �ĵȽ��ڲ���Ը���

	for j=1,4 do
		subSum[j] = 0
		for i,_ in pairs(subChance[j]) do
			subSum[j] = subSum[j] + subChance[j][i]
		end
	end
	
	local NumList = {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16}
	local NumChance =
	{
		PriceChance[1]*subChance[1][1]/subSum[1], 
		PriceChance[4]*subChance[4][1]/subSum[4], 
		PriceChance[2]*subChance[2][1]/subSum[2], 
		PriceChance[3]*subChance[3][1]/subSum[3],
		
		PriceChance[1]*subChance[1][2]/subSum[1], 
		PriceChance[3]*subChance[3][2]/subSum[3], 
		PriceChance[2]*subChance[2][2]/subSum[2], 
		PriceChance[4]*subChance[4][2]/subSum[4],

		PriceChance[1]*subChance[1][3]/subSum[1], 
		PriceChance[4]*subChance[4][3]/subSum[4], 
		PriceChance[2]*subChance[2][3]/subSum[2], 
		PriceChance[3]*subChance[3][3]/subSum[3],

		PriceChance[1]*subChance[1][4]/subSum[1], 
		PriceChance[3]*subChance[3][4]/subSum[3], 
		PriceChance[2]*subChance[2][4]/subSum[2], 
		PriceChance[4]*subChance[4][4]/subSum[4],
	}
	return NumList[ZLottery_Get_RanPoint(NumChance)]
end
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType33823SelectNumber(list, max_count)			--- Lottery Used@20100202(ӭ�´���)
	local PriceChance = {24,200,2000}																						-- һ�����Ƚ�����(��λ:���֮)
	PriceChance[4] = 10000 - PriceChance[1] - PriceChance[2] - PriceChance[3]		--     �ĵȽ�����(��λ:���֮)
	
	local subChance = {}
	local subSum = {}
	subChance[1] = {100,30,10,100}					-- һ�Ƚ��ڲ���Ը���
	subChance[2] = {50,60,40,50}						-- ���Ƚ��ڲ���Ը���
	subChance[3] = {5,15,15,5}							-- ���Ƚ��ڲ���Ը���
	subChance[4] = {10,40,40,10}						-- �ĵȽ��ڲ���Ը���

	for j=1,4 do
		subSum[j] = 0
		for i,_ in pairs(subChance[j]) do
			subSum[j] = subSum[j] + subChance[j][i]
		end
	end
	
	local NumList = {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16}
	local NumChance =
	{
		PriceChance[1]*subChance[1][1]/subSum[1], 
		PriceChance[4]*subChance[4][1]/subSum[4], 
		PriceChance[2]*subChance[2][1]/subSum[2], 
		PriceChance[3]*subChance[3][1]/subSum[3],
		
		PriceChance[1]*subChance[1][2]/subSum[1], 
		PriceChance[3]*subChance[3][2]/subSum[3], 
		PriceChance[2]*subChance[2][2]/subSum[2], 
		PriceChance[4]*subChance[4][2]/subSum[4],

		PriceChance[1]*subChance[1][3]/subSum[1], 
		PriceChance[4]*subChance[4][3]/subSum[4], 
		PriceChance[2]*subChance[2][3]/subSum[2], 
		PriceChance[3]*subChance[3][3]/subSum[3],

		PriceChance[1]*subChance[1][4]/subSum[1], 
		PriceChance[3]*subChance[3][4]/subSum[3], 
		PriceChance[2]*subChance[2][4]/subSum[2], 
		PriceChance[4]*subChance[4][4]/subSum[4],
	}
	return NumList[ZLottery_Get_RanPoint(NumChance)]
end
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType52680SelectNumber(list, max_count)			--- Lottery Used@20120802(�����ɽ�)
	local PriceChance = {30,120,3000}																						-- һ�����Ƚ�����(��λ:���֮)
	PriceChance[4] = 10000 - PriceChance[1] - PriceChance[2] - PriceChance[3]		--     �ĵȽ�����(��λ:���֮)
	
	local subChance = {}
	local subSum = {}
	subChance[1] = {18,5,2,5}					-- һ�Ƚ��ڲ���Ը���
	subChance[2] = {30,30,30,30}					-- ���Ƚ��ڲ���Ը���
	subChance[3] = {10,10,10,10}					-- ���Ƚ��ڲ���Ը���
	subChance[4] = {10,10,10,10}					-- �ĵȽ��ڲ���Ը���

	for j=1,4 do
		subSum[j] = 0
		for i,_ in pairs(subChance[j]) do
			subSum[j] = subSum[j] + subChance[j][i]
		end
	end
	
	local NumList = {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16}
	local NumChance =
	{
		PriceChance[1]*subChance[1][1]/subSum[1], 
		PriceChance[4]*subChance[4][1]/subSum[4], 
		PriceChance[2]*subChance[2][1]/subSum[2], 
		PriceChance[3]*subChance[3][1]/subSum[3],
		
		PriceChance[1]*subChance[1][2]/subSum[1], 
		PriceChance[3]*subChance[3][2]/subSum[3], 
		PriceChance[2]*subChance[2][2]/subSum[2], 
		PriceChance[4]*subChance[4][2]/subSum[4],

		PriceChance[1]*subChance[1][3]/subSum[1], 
		PriceChance[4]*subChance[4][3]/subSum[4], 
		PriceChance[2]*subChance[2][3]/subSum[2], 
		PriceChance[3]*subChance[3][3]/subSum[3],

		PriceChance[1]*subChance[1][4]/subSum[1], 
		PriceChance[3]*subChance[3][4]/subSum[3], 
		PriceChance[2]*subChance[2][4]/subSum[2], 
		PriceChance[4]*subChance[4][4]/subSum[4],
	}
	return NumList[ZLottery_Get_RanPoint(NumChance)]
end
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType54886SelectNumber(list, max_count)			--- Lottery Used@20121026(�������)
	local PriceChance = {20,120,3000}																						-- һ�����Ƚ�����(��λ:���֮)
	PriceChance[4] = 10000 - PriceChance[1] - PriceChance[2] - PriceChance[3]		--     �ĵȽ�����(��λ:���֮)
	
	local subChance = {}
	local subSum = {}
	subChance[1] = {8,7,2,3}					-- һ�Ƚ��ڲ���Ը���
	subChance[2] = {30,30,30,30}					-- ���Ƚ��ڲ���Ը���
	subChance[3] = {10,10,10,10}					-- ���Ƚ��ڲ���Ը���
	subChance[4] = {10,10,10,10}					-- �ĵȽ��ڲ���Ը���

	for j=1,4 do
		subSum[j] = 0
		for i,_ in pairs(subChance[j]) do
			subSum[j] = subSum[j] + subChance[j][i]
		end
	end
	
	local NumList = {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16}
	local NumChance =
	{
		PriceChance[1]*subChance[1][1]/subSum[1], 
		PriceChance[4]*subChance[4][1]/subSum[4], 
		PriceChance[2]*subChance[2][1]/subSum[2], 
		PriceChance[3]*subChance[3][1]/subSum[3],
		
		PriceChance[1]*subChance[1][2]/subSum[1], 
		PriceChance[3]*subChance[3][2]/subSum[3], 
		PriceChance[2]*subChance[2][2]/subSum[2], 
		PriceChance[4]*subChance[4][2]/subSum[4],

		PriceChance[1]*subChance[1][3]/subSum[1], 
		PriceChance[4]*subChance[4][3]/subSum[4], 
		PriceChance[2]*subChance[2][3]/subSum[2], 
		PriceChance[3]*subChance[3][3]/subSum[3],

		PriceChance[1]*subChance[1][4]/subSum[1], 
		PriceChance[3]*subChance[3][4]/subSum[3], 
		PriceChance[2]*subChance[2][4]/subSum[2], 
		PriceChance[4]*subChance[4][4]/subSum[4],
	}
	return NumList[ZLottery_Get_RanPoint(NumChance)]
end
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType54929SelectNumber(list, max_count)			--- Lottery Used@20121113(��ɫ����)
	local PriceChance = {40,120,3000}																						-- һ�����Ƚ�����(��λ:���֮)
	PriceChance[4] = 10000 - PriceChance[1] - PriceChance[2] - PriceChance[3]		--     �ĵȽ�����(��λ:���֮)
	
	local subChance = {}
	local subSum = {}
	subChance[1] = {20,10,2,8}					-- һ�Ƚ��ڲ���Ը���
	subChance[2] = {30,30,30,30}					-- ���Ƚ��ڲ���Ը���
	subChance[3] = {10,10,10,10}					-- ���Ƚ��ڲ���Ը���
	subChance[4] = {10,10,10,10}					-- �ĵȽ��ڲ���Ը���

	for j=1,4 do
		subSum[j] = 0
		for i,_ in pairs(subChance[j]) do
			subSum[j] = subSum[j] + subChance[j][i]
		end
	end
	
	local NumList = {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16}
	local NumChance =
	{
		PriceChance[1]*subChance[1][1]/subSum[1], 
		PriceChance[4]*subChance[4][1]/subSum[4], 
		PriceChance[2]*subChance[2][1]/subSum[2], 
		PriceChance[3]*subChance[3][1]/subSum[3],
		
		PriceChance[1]*subChance[1][2]/subSum[1], 
		PriceChance[3]*subChance[3][2]/subSum[3], 
		PriceChance[2]*subChance[2][2]/subSum[2], 
		PriceChance[4]*subChance[4][2]/subSum[4],

		PriceChance[1]*subChance[1][3]/subSum[1], 
		PriceChance[4]*subChance[4][3]/subSum[4], 
		PriceChance[2]*subChance[2][3]/subSum[2], 
		PriceChance[3]*subChance[3][3]/subSum[3],

		PriceChance[1]*subChance[1][4]/subSum[1], 
		PriceChance[3]*subChance[3][4]/subSum[3], 
		PriceChance[2]*subChance[2][4]/subSum[2], 
		PriceChance[4]*subChance[4][4]/subSum[4],
	}
	return NumList[ZLottery_Get_RanPoint(NumChance)]
end
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType57426SelectNumber(list, max_count)			--- Lottery Used@20130419(������)
	local PriceChance = {30,120,3000}																						-- һ�����Ƚ�����(��λ:���֮)
	PriceChance[4] = 10000 - PriceChance[1] - PriceChance[2] - PriceChance[3]		--     �ĵȽ�����(��λ:���֮)
	
	local subChance = {}
	local subSum = {}
	subChance[1] = {20,4,2,4}					-- һ�Ƚ��ڲ���Ը���
	subChance[2] = {30,30,30,30}					-- ���Ƚ��ڲ���Ը���
	subChance[3] = {10,10,10,10}					-- ���Ƚ��ڲ���Ը���
	subChance[4] = {10,10,10,10}					-- �ĵȽ��ڲ���Ը���

	for j=1,4 do
		subSum[j] = 0
		for i,_ in pairs(subChance[j]) do
			subSum[j] = subSum[j] + subChance[j][i]
		end
	end
	
	local NumList = {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16}
	local NumChance =
	{
		PriceChance[1]*subChance[1][1]/subSum[1], 
		PriceChance[4]*subChance[4][1]/subSum[4], 
		PriceChance[2]*subChance[2][1]/subSum[2], 
		PriceChance[3]*subChance[3][1]/subSum[3],
		
		PriceChance[1]*subChance[1][2]/subSum[1], 
		PriceChance[3]*subChance[3][2]/subSum[3], 
		PriceChance[2]*subChance[2][2]/subSum[2], 
		PriceChance[4]*subChance[4][2]/subSum[4],

		PriceChance[1]*subChance[1][3]/subSum[1], 
		PriceChance[4]*subChance[4][3]/subSum[4], 
		PriceChance[2]*subChance[2][3]/subSum[2], 
		PriceChance[3]*subChance[3][3]/subSum[3],

		PriceChance[1]*subChance[1][4]/subSum[1], 
		PriceChance[3]*subChance[3][4]/subSum[3], 
		PriceChance[2]*subChance[2][4]/subSum[2], 
		PriceChance[4]*subChance[4][4]/subSum[4],
	}
	return NumList[ZLottery_Get_RanPoint(NumChance)]
end
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType58555SelectNumber(list, max_count)			--- Lottery Used@20130801(�˽���)
	local PriceChance = {30,120,3000}																						-- һ�����Ƚ�����(��λ:���֮)
	PriceChance[4] = 10000 - PriceChance[1] - PriceChance[2] - PriceChance[3]		--     �ĵȽ�����(��λ:���֮)
	
	local subChance = {}
	local subSum = {}
	subChance[1] = {185,50,15,50}					-- һ�Ƚ��ڲ���Ը���
	subChance[2] = {30,30,30,30}					-- ���Ƚ��ڲ���Ը���
	subChance[3] = {10,10,10,10}					-- ���Ƚ��ڲ���Ը���
	subChance[4] = {10,10,10,10}					-- �ĵȽ��ڲ���Ը���

	for j=1,4 do
		subSum[j] = 0
		for i,_ in pairs(subChance[j]) do
			subSum[j] = subSum[j] + subChance[j][i]
		end
	end
	
	local NumList = {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16}
	local NumChance =
	{
		PriceChance[1]*subChance[1][1]/subSum[1], 
		PriceChance[4]*subChance[4][1]/subSum[4], 
		PriceChance[2]*subChance[2][1]/subSum[2], 
		PriceChance[3]*subChance[3][1]/subSum[3],
		
		PriceChance[1]*subChance[1][2]/subSum[1], 
		PriceChance[3]*subChance[3][2]/subSum[3], 
		PriceChance[2]*subChance[2][2]/subSum[2], 
		PriceChance[4]*subChance[4][2]/subSum[4],

		PriceChance[1]*subChance[1][3]/subSum[1], 
		PriceChance[4]*subChance[4][3]/subSum[4], 
		PriceChance[2]*subChance[2][3]/subSum[2], 
		PriceChance[3]*subChance[3][3]/subSum[3],

		PriceChance[1]*subChance[1][4]/subSum[1], 
		PriceChance[3]*subChance[3][4]/subSum[3], 
		PriceChance[2]*subChance[2][4]/subSum[2], 
		PriceChance[4]*subChance[4][4]/subSum[4],
	}
	return NumList[ZLottery_Get_RanPoint(NumChance)]
end
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType61160SelectNumber(list, max_count)			--- Lottery Used@20130912(�����ð��ɲ�Ʊ)
	local PriceChance = {1,9,1500}																						-- һ�����Ƚ�����(��λ:���֮)
	PriceChance[4] = 10000 - PriceChance[1] - PriceChance[2] - PriceChance[3]		--     �ĵȽ�����(��λ:���֮)
	
	local subChance = {}
	local subSum = {}
	subChance[1] = {10,10,10,10}					-- һ�Ƚ��ڲ���Ը���
	subChance[2] = {30,30,30,30}					-- ���Ƚ��ڲ���Ը���
	subChance[3] = {10,10,10,10}					-- ���Ƚ��ڲ���Ը���
	subChance[4] = {10,10,10,10}					-- �ĵȽ��ڲ���Ը���

	for j=1,4 do
		subSum[j] = 0
		for i,_ in pairs(subChance[j]) do
			subSum[j] = subSum[j] + subChance[j][i]
		end
	end
	
	local NumList = {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16}
	local NumChance =
	{
		PriceChance[1]*subChance[1][1]/subSum[1], 
		PriceChance[4]*subChance[4][1]/subSum[4], 
		PriceChance[2]*subChance[2][1]/subSum[2], 
		PriceChance[3]*subChance[3][1]/subSum[3],
		
		PriceChance[1]*subChance[1][2]/subSum[1], 
		PriceChance[3]*subChance[3][2]/subSum[3], 
		PriceChance[2]*subChance[2][2]/subSum[2], 
		PriceChance[4]*subChance[4][2]/subSum[4],

		PriceChance[1]*subChance[1][3]/subSum[1], 
		PriceChance[4]*subChance[4][3]/subSum[4], 
		PriceChance[2]*subChance[2][3]/subSum[2], 
		PriceChance[3]*subChance[3][3]/subSum[3],

		PriceChance[1]*subChance[1][4]/subSum[1], 
		PriceChance[3]*subChance[3][4]/subSum[3], 
		PriceChance[2]*subChance[2][4]/subSum[2], 
		PriceChance[4]*subChance[4][4]/subSum[4],
	}
	return NumList[ZLottery_Get_RanPoint(NumChance)]
end
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType58313SelectNumber(list, max_count)			--- Lottery Used@20130606(�����)
	local PriceChance = {40,120,3000}																						-- һ�����Ƚ�����(��λ:���֮)
	PriceChance[4] = 10000 - PriceChance[1] - PriceChance[2] - PriceChance[3]		--     �ĵȽ�����(��λ:���֮)
	
	local subChance = {}
	local subSum = {}
	subChance[1] = {220,80,15,85}					-- һ�Ƚ��ڲ���Ը���
	subChance[2] = {30,30,30,30}					-- ���Ƚ��ڲ���Ը���
	subChance[3] = {10,10,10,10}					-- ���Ƚ��ڲ���Ը���
	subChance[4] = {10,10,10,10}					-- �ĵȽ��ڲ���Ը���

	for j=1,4 do
		subSum[j] = 0
		for i,_ in pairs(subChance[j]) do
			subSum[j] = subSum[j] + subChance[j][i]
		end
	end
	
	local NumList = {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16}
	local NumChance =
	{
		PriceChance[1]*subChance[1][1]/subSum[1], 
		PriceChance[4]*subChance[4][1]/subSum[4], 
		PriceChance[2]*subChance[2][1]/subSum[2], 
		PriceChance[3]*subChance[3][1]/subSum[3],
		
		PriceChance[1]*subChance[1][2]/subSum[1], 
		PriceChance[3]*subChance[3][2]/subSum[3], 
		PriceChance[2]*subChance[2][2]/subSum[2], 
		PriceChance[4]*subChance[4][2]/subSum[4],

		PriceChance[1]*subChance[1][3]/subSum[1], 
		PriceChance[4]*subChance[4][3]/subSum[4], 
		PriceChance[2]*subChance[2][3]/subSum[2], 
		PriceChance[3]*subChance[3][3]/subSum[3],

		PriceChance[1]*subChance[1][4]/subSum[1], 
		PriceChance[3]*subChance[3][4]/subSum[3], 
		PriceChance[2]*subChance[2][4]/subSum[2], 
		PriceChance[4]*subChance[4][4]/subSum[4],
	}
	return NumList[ZLottery_Get_RanPoint(NumChance)]
end
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType58365SelectNumber(list, max_count)			--- Lottery Used@20130626(����Ũ)
	local PriceChance = {35,120,3000}																						-- һ�����Ƚ�����(��λ:���֮)
	PriceChance[4] = 10000 - PriceChance[1] - PriceChance[2] - PriceChance[3]		--     �ĵȽ�����(��λ:���֮)
	
	local subChance = {}
	local subSum = {}
	subChance[1] = {225,80,15,30}					-- һ�Ƚ��ڲ���Ը���
	subChance[2] = {30,30,30,30}					-- ���Ƚ��ڲ���Ը���
	subChance[3] = {10,10,10,10}					-- ���Ƚ��ڲ���Ը���
	subChance[4] = {10,10,10,10}					-- �ĵȽ��ڲ���Ը���

	for j=1,4 do
		subSum[j] = 0
		for i,_ in pairs(subChance[j]) do
			subSum[j] = subSum[j] + subChance[j][i]
		end
	end
	
	local NumList = {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16}
	local NumChance =
	{
		PriceChance[1]*subChance[1][1]/subSum[1], 
		PriceChance[4]*subChance[4][1]/subSum[4], 
		PriceChance[2]*subChance[2][1]/subSum[2], 
		PriceChance[3]*subChance[3][1]/subSum[3],
		
		PriceChance[1]*subChance[1][2]/subSum[1], 
		PriceChance[3]*subChance[3][2]/subSum[3], 
		PriceChance[2]*subChance[2][2]/subSum[2], 
		PriceChance[4]*subChance[4][2]/subSum[4],

		PriceChance[1]*subChance[1][3]/subSum[1], 
		PriceChance[4]*subChance[4][3]/subSum[4], 
		PriceChance[2]*subChance[2][3]/subSum[2], 
		PriceChance[3]*subChance[3][3]/subSum[3],

		PriceChance[1]*subChance[1][4]/subSum[1], 
		PriceChance[3]*subChance[3][4]/subSum[3], 
		PriceChance[2]*subChance[2][4]/subSum[2], 
		PriceChance[4]*subChance[4][4]/subSum[4],
	}
	return NumList[ZLottery_Get_RanPoint(NumChance)]
end
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType55493SelectNumber(list, max_count)			--- Lottery Used@20111102(������Ԫ�����Ʊ)
	local PriceChance = {6,1500,6000}																						-- һ�����Ƚ�����(��λ:���֮)
	PriceChance[4] = 10000 - PriceChance[1] - PriceChance[2] - PriceChance[3]		--     �ĵȽ�����(��λ:���֮)
	
	local subChance = {}
	local subSum = {}
	subChance[1] = {20,20,20,20}					-- һ�Ƚ��ڲ���Ը���
	subChance[2] = {30,30,30,30}					-- ���Ƚ��ڲ���Ը���
	subChance[3] = {10,10,10,10}					-- ���Ƚ��ڲ���Ը���
	subChance[4] = {10,10,10,10}					-- �ĵȽ��ڲ���Ը���

	for j=1,4 do
		subSum[j] = 0
		for i,_ in pairs(subChance[j]) do
			subSum[j] = subSum[j] + subChance[j][i]
		end
	end
	
	local NumList = {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16}
	local NumChance =
	{
		PriceChance[1]*subChance[1][1]/subSum[1], 
		PriceChance[4]*subChance[4][1]/subSum[4], 
		PriceChance[2]*subChance[2][1]/subSum[2], 
		PriceChance[3]*subChance[3][1]/subSum[3],
		
		PriceChance[1]*subChance[1][2]/subSum[1], 
		PriceChance[3]*subChance[3][2]/subSum[3], 
		PriceChance[2]*subChance[2][2]/subSum[2], 
		PriceChance[4]*subChance[4][2]/subSum[4],

		PriceChance[1]*subChance[1][3]/subSum[1], 
		PriceChance[4]*subChance[4][3]/subSum[4], 
		PriceChance[2]*subChance[2][3]/subSum[2], 
		PriceChance[3]*subChance[3][3]/subSum[3],

		PriceChance[1]*subChance[1][4]/subSum[1], 
		PriceChance[3]*subChance[3][4]/subSum[3], 
		PriceChance[2]*subChance[2][4]/subSum[2], 
		PriceChance[4]*subChance[4][4]/subSum[4],
	}
	return NumList[ZLottery_Get_RanPoint(NumChance)]
end
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType54909SelectNumber(list, max_count)			--- Lottery Used@20121107(��ս�ò�Ʊ)
	local PriceChance = {150,2000,3920}																						-- һ�����Ƚ�����(��λ:���֮)
	PriceChance[4] = 10000 - PriceChance[1] - PriceChance[2] - PriceChance[3]		--     �ĵȽ�����(��λ:���֮)
	
	local subChance = {}
	local subSum = {}
	subChance[1] = {45,50,5,50}					-- һ�Ƚ��ڲ���Ը���
	subChance[2] = {30,30,30,30}					-- ���Ƚ��ڲ���Ը���
	subChance[3] = {10,10,10,10}					-- ���Ƚ��ڲ���Ը���
	subChance[4] = {10,10,10,10}					-- �ĵȽ��ڲ���Ը���

	for j=1,4 do
		subSum[j] = 0
		for i,_ in pairs(subChance[j]) do
			subSum[j] = subSum[j] + subChance[j][i]
		end
	end
	
	local NumList = {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16}
	local NumChance =
	{
		PriceChance[1]*subChance[1][1]/subSum[1], 
		PriceChance[4]*subChance[4][1]/subSum[4], 
		PriceChance[2]*subChance[2][1]/subSum[2], 
		PriceChance[3]*subChance[3][1]/subSum[3],
		
		PriceChance[1]*subChance[1][2]/subSum[1], 
		PriceChance[3]*subChance[3][2]/subSum[3], 
		PriceChance[2]*subChance[2][2]/subSum[2], 
		PriceChance[4]*subChance[4][2]/subSum[4],

		PriceChance[1]*subChance[1][3]/subSum[1], 
		PriceChance[4]*subChance[4][3]/subSum[4], 
		PriceChance[2]*subChance[2][3]/subSum[2], 
		PriceChance[3]*subChance[3][3]/subSum[3],

		PriceChance[1]*subChance[1][4]/subSum[1], 
		PriceChance[3]*subChance[3][4]/subSum[3], 
		PriceChance[2]*subChance[2][4]/subSum[2], 
		PriceChance[4]*subChance[4][4]/subSum[4],
	}
	return NumList[ZLottery_Get_RanPoint(NumChance)]
end
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType55541SelectNumber(list, max_count)			--- Lottery Used@20130107(���߿���)
	local PriceChance = {20,120,3000}																						-- һ�����Ƚ�����(��λ:���֮)
	PriceChance[4] = 10000 - PriceChance[1] - PriceChance[2] - PriceChance[3]		--     �ĵȽ�����(��λ:���֮)
	
	local subChance = {}
	local subSum = {}
	subChance[1] = {80,50,20,50}					-- һ�Ƚ��ڲ���Ը���
	subChance[2] = {30,30,30,30}					-- ���Ƚ��ڲ���Ը���
	subChance[3] = {10,10,10,10}					-- ���Ƚ��ڲ���Ը���
	subChance[4] = {10,10,10,10}					-- �ĵȽ��ڲ���Ը���

	for j=1,4 do
		subSum[j] = 0
		for i,_ in pairs(subChance[j]) do
			subSum[j] = subSum[j] + subChance[j][i]
		end
	end
	
	local NumList = {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16}
	local NumChance =
	{
		PriceChance[1]*subChance[1][1]/subSum[1], 
		PriceChance[4]*subChance[4][1]/subSum[4], 
		PriceChance[2]*subChance[2][1]/subSum[2], 
		PriceChance[3]*subChance[3][1]/subSum[3],
		
		PriceChance[1]*subChance[1][2]/subSum[1], 
		PriceChance[3]*subChance[3][2]/subSum[3], 
		PriceChance[2]*subChance[2][2]/subSum[2], 
		PriceChance[4]*subChance[4][2]/subSum[4],

		PriceChance[1]*subChance[1][3]/subSum[1], 
		PriceChance[4]*subChance[4][3]/subSum[4], 
		PriceChance[2]*subChance[2][3]/subSum[2], 
		PriceChance[3]*subChance[3][3]/subSum[3],

		PriceChance[1]*subChance[1][4]/subSum[1], 
		PriceChance[3]*subChance[3][4]/subSum[3], 
		PriceChance[2]*subChance[2][4]/subSum[2], 
		PriceChance[4]*subChance[4][4]/subSum[4],
	}
	return NumList[ZLottery_Get_RanPoint(NumChance)]
end
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType55792SelectNumber(list, max_count)			--- Lottery Used@20130305(��¥��)
	local PriceChance = {40,120,3000}																						-- һ�����Ƚ�����(��λ:���֮)
	PriceChance[4] = 10000 - PriceChance[1] - PriceChance[2] - PriceChance[3]		--     �ĵȽ�����(��λ:���֮)
	
	local subChance = {}
	local subSum = {}
	subChance[1] = {20,10,2,8}					-- һ�Ƚ��ڲ���Ը���
	subChance[2] = {30,30,30,30}					-- ���Ƚ��ڲ���Ը���
	subChance[3] = {10,10,10,10}					-- ���Ƚ��ڲ���Ը���
	subChance[4] = {10,10,10,10}					-- �ĵȽ��ڲ���Ը���

	for j=1,4 do
		subSum[j] = 0
		for i,_ in pairs(subChance[j]) do
			subSum[j] = subSum[j] + subChance[j][i]
		end
	end
	
	local NumList = {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16}
	local NumChance =
	{
		PriceChance[1]*subChance[1][1]/subSum[1], 
		PriceChance[4]*subChance[4][1]/subSum[4], 
		PriceChance[2]*subChance[2][1]/subSum[2], 
		PriceChance[3]*subChance[3][1]/subSum[3],
		
		PriceChance[1]*subChance[1][2]/subSum[1], 
		PriceChance[3]*subChance[3][2]/subSum[3], 
		PriceChance[2]*subChance[2][2]/subSum[2], 
		PriceChance[4]*subChance[4][2]/subSum[4],

		PriceChance[1]*subChance[1][3]/subSum[1], 
		PriceChance[4]*subChance[4][3]/subSum[4], 
		PriceChance[2]*subChance[2][3]/subSum[2], 
		PriceChance[3]*subChance[3][3]/subSum[3],

		PriceChance[1]*subChance[1][4]/subSum[1], 
		PriceChance[3]*subChance[3][4]/subSum[3], 
		PriceChance[2]*subChance[2][4]/subSum[2], 
		PriceChance[4]*subChance[4][4]/subSum[4],
	}
	return NumList[ZLottery_Get_RanPoint(NumChance)]
end
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType55966SelectNumber(list, max_count)			--- Lottery Used@20120407(��ɽϪ)
	local PriceChance = {40,120,3000}																						-- һ�����Ƚ�����(��λ:���֮)
	PriceChance[4] = 10000 - PriceChance[1] - PriceChance[2] - PriceChance[3]		--     �ĵȽ�����(��λ:���֮)
	
	local subChance = {}
	local subSum = {}
	subChance[1] = {225,80,15,80}					-- һ�Ƚ��ڲ���Ը���
	subChance[2] = {30,30,30,30}					-- ���Ƚ��ڲ���Ը���
	subChance[3] = {10,10,10,10}					-- ���Ƚ��ڲ���Ը���
	subChance[4] = {10,10,10,10}					-- �ĵȽ��ڲ���Ը���

	for j=1,4 do
		subSum[j] = 0
		for i,_ in pairs(subChance[j]) do
			subSum[j] = subSum[j] + subChance[j][i]
		end
	end
	
	local NumList = {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16}
	local NumChance =
	{
		PriceChance[1]*subChance[1][1]/subSum[1], 
		PriceChance[4]*subChance[4][1]/subSum[4], 
		PriceChance[2]*subChance[2][1]/subSum[2], 
		PriceChance[3]*subChance[3][1]/subSum[3],
		
		PriceChance[1]*subChance[1][2]/subSum[1], 
		PriceChance[3]*subChance[3][2]/subSum[3], 
		PriceChance[2]*subChance[2][2]/subSum[2], 
		PriceChance[4]*subChance[4][2]/subSum[4],

		PriceChance[1]*subChance[1][3]/subSum[1], 
		PriceChance[4]*subChance[4][3]/subSum[4], 
		PriceChance[2]*subChance[2][3]/subSum[2], 
		PriceChance[3]*subChance[3][3]/subSum[3],

		PriceChance[1]*subChance[1][4]/subSum[1], 
		PriceChance[3]*subChance[3][4]/subSum[3], 
		PriceChance[2]*subChance[2][4]/subSum[2], 
		PriceChance[4]*subChance[4][4]/subSum[4],
	}
	return NumList[ZLottery_Get_RanPoint(NumChance)]
end
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType60300SelectNumber(list, max_count)			--- Lottery Used@20130826(ȵ����)
	local PriceChance = {35,120,3000}																						-- һ�����Ƚ�����(��λ:���֮)
	PriceChance[4] = 10000 - PriceChance[1] - PriceChance[2] - PriceChance[3]		--     �ĵȽ�����(��λ:���֮)
	
	local subChance = {}
	local subSum = {}
	subChance[1] = {200,85,15,100}					-- һ�Ƚ��ڲ���Ը���
	subChance[2] = {30,30,30,30}					-- ���Ƚ��ڲ���Ը���
	subChance[3] = {10,10,10,10}					-- ���Ƚ��ڲ���Ը���
	subChance[4] = {10,10,10,10}					-- �ĵȽ��ڲ���Ը���

	for j=1,4 do
		subSum[j] = 0
		for i,_ in pairs(subChance[j]) do
			subSum[j] = subSum[j] + subChance[j][i]
		end
	end
	
	local NumList = {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16}
	local NumChance =
	{
		PriceChance[1]*subChance[1][1]/subSum[1], 
		PriceChance[4]*subChance[4][1]/subSum[4], 
		PriceChance[2]*subChance[2][1]/subSum[2], 
		PriceChance[3]*subChance[3][1]/subSum[3],
		
		PriceChance[1]*subChance[1][2]/subSum[1], 
		PriceChance[3]*subChance[3][2]/subSum[3], 
		PriceChance[2]*subChance[2][2]/subSum[2], 
		PriceChance[4]*subChance[4][2]/subSum[4],

		PriceChance[1]*subChance[1][3]/subSum[1], 
		PriceChance[4]*subChance[4][3]/subSum[4], 
		PriceChance[2]*subChance[2][3]/subSum[2], 
		PriceChance[3]*subChance[3][3]/subSum[3],

		PriceChance[1]*subChance[1][4]/subSum[1], 
		PriceChance[3]*subChance[3][4]/subSum[3], 
		PriceChance[2]*subChance[2][4]/subSum[2], 
		PriceChance[4]*subChance[4][4]/subSum[4],
	}
	return NumList[ZLottery_Get_RanPoint(NumChance)]
end
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType55590SelectNumber(list, max_count)			--- Lottery Used@20130205(�����)
	local PriceChance = {30,120,3000}																						-- һ�����Ƚ�����(��λ:���֮)
	PriceChance[4] = 10000 - PriceChance[1] - PriceChance[2] - PriceChance[3]		--     �ĵȽ�����(��λ:���֮)
	
	local subChance = {}
	local subSum = {}
	subChance[1] = {50,20,50,180}					-- һ�Ƚ��ڲ���Ը���
	subChance[2] = {30,30,30,30}					-- ���Ƚ��ڲ���Ը���
	subChance[3] = {10,10,10,10}					-- ���Ƚ��ڲ���Ը���
	subChance[4] = {10,10,10,10}					-- �ĵȽ��ڲ���Ը���

	for j=1,4 do
		subSum[j] = 0
		for i,_ in pairs(subChance[j]) do
			subSum[j] = subSum[j] + subChance[j][i]
		end
	end
	
	local NumList = {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16}
	local NumChance =
	{
		PriceChance[1]*subChance[1][1]/subSum[1], 
		PriceChance[4]*subChance[4][1]/subSum[4], 
		PriceChance[2]*subChance[2][1]/subSum[2], 
		PriceChance[3]*subChance[3][1]/subSum[3],
		
		PriceChance[1]*subChance[1][2]/subSum[1], 
		PriceChance[3]*subChance[3][2]/subSum[3], 
		PriceChance[2]*subChance[2][2]/subSum[2], 
		PriceChance[4]*subChance[4][2]/subSum[4],

		PriceChance[1]*subChance[1][3]/subSum[1], 
		PriceChance[4]*subChance[4][3]/subSum[4], 
		PriceChance[2]*subChance[2][3]/subSum[2], 
		PriceChance[3]*subChance[3][3]/subSum[3],

		PriceChance[1]*subChance[1][4]/subSum[1], 
		PriceChance[3]*subChance[3][4]/subSum[3], 
		PriceChance[2]*subChance[2][4]/subSum[2], 
		PriceChance[4]*subChance[4][4]/subSum[4],
	}
	return NumList[ZLottery_Get_RanPoint(NumChance)]
end
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType58780SelectNumber(list, max_count)	--- Lottery Used@20130809(Ⱦɫ��)
	local PriceChance = {1,2,4,8,16}																						-- һ�����Ƚ�����(��λ:���֮)
	local subChance = {}
	local subSum = {}
	subChance[1] = {4,4,4,4,5,5,5,5,6,6,6,6}					-- һ�Ƚ��ڲ���Ը���
	subChance[2] = {4,4,4,4,5,5,5,5,6,6,6,6}					-- ���Ƚ��ڲ���Ը���
	subChance[3] = {4,4,4,4,5,5,5,5,6,6,6,6}					-- ���Ƚ��ڲ���Ը���
	subChance[4] = {4,4,4,4,5,5,5,5,6,6,6,6}					-- �ĵȽ��ڲ���Ը���
	subChance[5] = {4,4,4,4,5,5,5,5,6,6,6,6}					-- ��Ƚ��ڲ���Ը���

	for j=1,5 do
		subSum[j] = 0
		for i,_ in pairs(subChance[j]) do
			subSum[j] = subSum[j] + subChance[j][i]
		end
	end
	
	local NumList={}
	local NumChance={}
	for k=1,60 do
		NumList[k]=k
		j=(k-1)%12
		i=(k-1-j)/12+1
		NumChance[k]=PriceChance[i]*subChance[i][j+1]/subSum[i]
	end	

	return NumList[ZLottery_Get_RanPoint(NumChance)]
end
function LotteryType55442SelectNumber(list, max_count)	--- Lottery Ԫ��
	local PriceChance = {1,2,4,8,16}																						-- һ�����Ƚ�����(��λ:���֮)
	local subChance = {}
	local subSum = {}
	subChance[1] = {4,4,4,4,5,5,5,5,6,6,6,6}					-- һ�Ƚ��ڲ���Ը���
	subChance[2] = {4,4,4,4,5,5,5,5,6,6,6,6}					-- ���Ƚ��ڲ���Ը���
	subChance[3] = {4,4,4,4,5,5,5,5,6,6,6,6}					-- ���Ƚ��ڲ���Ը���
	subChance[4] = {4,4,4,4,5,5,5,5,6,6,6,6}					-- �ĵȽ��ڲ���Ը���
	subChance[5] = {4,4,4,4,5,5,5,5,6,6,6,6}					-- ��Ƚ��ڲ���Ը���

	for j=1,5 do
		subSum[j] = 0
		for i,_ in pairs(subChance[j]) do
			subSum[j] = subSum[j] + subChance[j][i]
		end
	end
	
	local NumList={}
	local NumChance={}
	for k=1,60 do
		NumList[k]=k
		j=(k-1)%12
		i=(k-1-j)/12+1
		NumChance[k]=PriceChance[i]*subChance[i][j+1]/subSum[i]
	end	

	return NumList[ZLottery_Get_RanPoint(NumChance)]
end
-------------------------------------------------------------------------------------------------------------
----------------------------------------------------  �����ķָ���  -----------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType6576Cashing(cur_list)		---(����_��ľ����)
	---fmax_countΪ�ò�Ʊ����Чλ��
	local cp
	local nowcurlist={}
	local fmax_count=table.getn(cur_list)
	nowcurlist[0]=""
	for cp=1,fmax_count do
		nowcurlist[cp]=nowcurlist[cp-1]..cur_list[cp]
	end 
	
	local lot_prize={}
	local lot_prizechance={}
	local prizeout
	local Out_Prize={}
	Out_Prize[1]={}
	Out_Prize[2]={}
	Out_Prize[3]={}
	Out_Prize[4]={}
	
	Out_Prize[1][4713]=100	--��ľ��
	
	Out_Prize[2][23188]=100	--˫��������
	
	Out_Prize[3][3988]=100	--�سǷ�
	Out_Prize[3][3991]=100
	Out_Prize[3][6430]=100
	Out_Prize[3][3989]=100
	Out_Prize[3][3990]=100
	Out_Prize[3][3992]=100
		
	Out_Prize[4][1807]=100	--̫һ��
		
	local i,v,k
	
	for k=1,4 do
		lot_prize[k]={}
		lot_prizechance[k]={}
	end 
	
	for k=1,4 do
		for i,v in pairs(Out_Prize[k]) do 
			table.insert(lot_prize[k],i)
			table.insert(lot_prizechance[k],v)
		end 
	end 
	if nowcurlist[fmax_count]=="444" then 
		prizeout=lot_prize[1][ZLottery_Get_RanPoint(lot_prizechance[1])]
		return 1,0,prizeout,1,0,0
	elseif ZLottery_FindSameNum(cur_list,4)==2 or nowcurlist[fmax_count]=="333" or nowcurlist[fmax_count]=="222" or nowcurlist[fmax_count]=="111" then 
		prizeout=lot_prize[2][ZLottery_Get_RanPoint(lot_prizechance[2])]
		return 2,0,prizeout,1,0,0
	elseif ZLottery_FindSameNum(cur_list,4)==1 then 
		prizeout=lot_prize[3][ZLottery_Get_RanPoint(lot_prizechance[3])]
		return 3,0,prizeout,2,0,0
	else 
		return 4,0,1807,1,0,0
	end
	return 4,0,1807,1,0,0 
end 
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType28703SelectNumber(list, max_count)			--- Lottery Used@20100927(����_���ʻ��)
	local PriceChance = {10,100,4000}																						-- һ�����Ƚ�����(��λ:���֮)
	PriceChance[4] = 10000 - PriceChance[1] - PriceChance[2] - PriceChance[3]		--     �ĵȽ�����(��λ:���֮)
	
	local subChance = {}
	local subSum = {}
	subChance[1] = {10,10}										-- һ�Ƚ��ڲ���Ը���(1�ţ�9��)
	subChance[2] = {40,60}										-- ���Ƚ��ڲ���Ը���(5�ţ�13��)
	subChance[3] = {1000,1000,1000,1000}			-- ���Ƚ��ڲ���Ը���(3�ţ�7�ţ�11�ţ�15��)
	subChance[4] = {25,10,10,25,25,40,40,25}	-- �ĵȽ��ڲ���Ը���(2,4,6,8,10,12,14,16)

	for j=1,4 do
		subSum[j] = 0
		for i,_ in pairs(subChance[j]) do
			subSum[j] = subSum[j] + subChance[j][i]
		end
	end
	
	local NumList = {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16}
	local NumChance =
	{
		PriceChance[1]*subChance[1][1]/subSum[1], PriceChance[4]*subChance[4][1]/subSum[4], PriceChance[3]*subChance[3][1]/subSum[3], PriceChance[4]*subChance[4][2]/subSum[4],
		PriceChance[2]*subChance[2][1]/subSum[2], PriceChance[4]*subChance[4][3]/subSum[4], PriceChance[3]*subChance[3][2]/subSum[3], PriceChance[4]*subChance[4][4]/subSum[4],
		PriceChance[1]*subChance[1][2]/subSum[1], PriceChance[4]*subChance[4][5]/subSum[4], PriceChance[3]*subChance[3][3]/subSum[3], PriceChance[4]*subChance[4][6]/subSum[4],
		PriceChance[2]*subChance[2][2]/subSum[2], PriceChance[4]*subChance[4][7]/subSum[4], PriceChance[3]*subChance[3][4]/subSum[3], PriceChance[4]*subChance[4][8]/subSum[4],
	}
	return NumList[ZLottery_Get_RanPoint(NumChance)]
end
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType7916Cashing(cur_list)	---(�����)
	---fmax_countΪ�ò�Ʊ����Чλ��
	local cp
	local nowcurlist={}
	local fmax_count=table.getn(cur_list)
	nowcurlist[0]=""
	for cp=1,fmax_count do
		nowcurlist[cp]=nowcurlist[cp-1]..cur_list[cp]
	end 
	
	local lot_prize={}
	local lot_prizechance={}
	local prizeout
	local Out_Prize={}
	Out_Prize[1]={}
	Out_Prize[2]={}
	Out_Prize[3]={}
	Out_Prize[4]={}
	
	Out_Prize[1][7925]=100	--����
	
	Out_Prize[2][7540]=100	--���������
	Out_Prize[2][7541]=100	--�������Ů
	
	Out_Prize[3][6473]=100	--�»�֮��
	Out_Prize[4][1807]=100	--̫һ��
		
	local i,v,k
	
	for k=1,4 do
		lot_prize[k]={}
		lot_prizechance[k]={}
	end 
	
	for k=1,4 do
		for i,v in pairs(Out_Prize[k]) do 
			table.insert(lot_prize[k],i)
			table.insert(lot_prizechance[k],v)
		end 
	end 
	if nowcurlist[fmax_count]=="111" then 
		prizeout=lot_prize[1][ZLottery_Get_RanPoint(lot_prizechance[1])]
		return 1,0,prizeout,1,0,0
	elseif nowcurlist[fmax_count]=="222" then 
		prizeout=lot_prize[2][ZLottery_Get_RanPoint(lot_prizechance[2])]
		return 2,0,prizeout,1,0,0
	elseif nowcurlist[fmax_count]=="333" or (ZLottery_FindSameNum(cur_list,1)==1 and ZLottery_FindSameNum(cur_list,2)==1 and ZLottery_FindSameNum(cur_list,3)==1) then  
		prizeout=lot_prize[3][ZLottery_Get_RanPoint(lot_prizechance[3])]
		return 3,0,prizeout,1,0,0
	else 
		return 4,0,1807,2,0,0
	end
	return 4,0,1807,2,0,0 
end
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType10484Cashing(cur_list)	---(�ɹ�����)
	---fmax_countΪ�ò�Ʊ����Чλ��
	local cp
	local nowcurlist={}
	local fmax_count=table.getn(cur_list)
	nowcurlist[0]=""
	for cp=1,fmax_count do
		nowcurlist[cp]=nowcurlist[cp-1]..cur_list[cp]
	end 
	
	local lot_prize={}
	local lot_prizechance={}
	local prizeout
	local Out_Prize={}
	Out_Prize[1]={}
	Out_Prize[2]={}
	Out_Prize[3]={}
	Out_Prize[4]={}
	
	Out_Prize[1][4708]=100	---���ǽ�
	Out_Prize[1][4709]=100	---�����
	Out_Prize[1][4710]=100	---�����
	Out_Prize[1][4711]=100	---���黷
	
	Out_Prize[2][6047]=50	---����ʯ����
	
	Out_Prize[2][6050]=100	---���Ͼ�����
	Out_Prize[2][6048]=100	---��ȸӡ����
	Out_Prize[2][6051]=100	---�ֻ�������
	Out_Prize[2][6049]=100	---����������
	
	Out_Prize[2][6054]=50	---���ǽ�����
	Out_Prize[2][6052]=50	---���������
	Out_Prize[2][6055]=50	---���������
	Out_Prize[2][6053]=50	---���黷����
	
	Out_Prize[2][6056]=10	---ɽ��������
	Out_Prize[2][6057]=10	---��ľ������
	Out_Prize[2][6059]=10	---��ƿ����

	Out_Prize[3][7928]=100  --����ʯ����������
	Out_Prize[3][7932]=100  --15����������������
	Out_Prize[3][7935]=100  --45����������������
	Out_Prize[3][7939]=100  --75����������������
	
	Out_Prize[4][4703]=100  --����ʯ
		
	local i,v,k
	
	for k=1,4 do
		lot_prize[k]={}
		lot_prizechance[k]={}
	end 
	
	for k=1,4 do
		for i,v in pairs(Out_Prize[k]) do 
			table.insert(lot_prize[k],i)
			table.insert(lot_prizechance[k],v)
		end 
	end 
	if nowcurlist[fmax_count]=="111" then 
		prizeout=lot_prize[1][ZLottery_Get_RanPoint(lot_prizechance[1])]
		return 1,0,prizeout,1,0,0
	elseif ZLottery_FindSameNum(cur_list,1)==2 then 
		prizeout=lot_prize[2][ZLottery_Get_RanPoint(lot_prizechance[2])]
		return 2,0,prizeout,1,0,0
	elseif ZLottery_FindSameNum(cur_list,1)==1 then 
		prizeout=lot_prize[3][ZLottery_Get_RanPoint(lot_prizechance[3])]
		return 3,0,prizeout,1,0,0
	else 
		prizeout=lot_prize[4][ZLottery_Get_RanPoint(lot_prizechance[4])]
		return 4,0,prizeout,1,0,0
	end
	return 4,0,4703,1,0,0 
end 
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType10722Cashing(cur_list)	---(����_���Ԫ��)
	---fmax_countΪ�ò�Ʊ����Чλ��
	local cp
	local nowcurlist={}
	local fmax_count=table.getn(cur_list)
	nowcurlist[0]=""
	for cp=1,fmax_count do
		nowcurlist[cp]=nowcurlist[cp-1]..cur_list[cp]
	end 
	
	local lot_prize={}
	local lot_prizechance={}
	local prizeout
	local Out_Prize={}
	Out_Prize[1]={}
	Out_Prize[2]={}
	Out_Prize[3]={}
	Out_Prize[4]={}
	
	Out_Prize[1][10715]=100		--���
	
	Out_Prize[2][10867]=100		--������
	
	
	Out_Prize[3][3994]=100		--���
	Out_Prize[4][3993]=100		--����
		
local i,v,k
	
	for k=1,4 do
		lot_prize[k]={}
		lot_prizechance[k]={}
	end 
	
	for k=1,4 do
		for i,v in pairs(Out_Prize[k]) do 
			table.insert(lot_prize[k],i)
			table.insert(lot_prizechance[k],v)
		end 
	end 
	if nowcurlist[fmax_count]=="111" then 
		prizeout=lot_prize[1][ZLottery_Get_RanPoint(lot_prizechance[1])]
		return 1,0,prizeout,1,0,0
	elseif nowcurlist[fmax_count]=="222"  then 
		prizeout=lot_prize[2][ZLottery_Get_RanPoint(lot_prizechance[2])]
		return 2,0,prizeout,1,0,0
	elseif (ZLottery_FindSameNum(cur_list,1)==0 and ZLottery_FindSameNum(cur_list,2)==0) or
		ZLottery_FindSameNum(cur_list,1)==2 or ZLottery_FindSameNum(cur_list,2)==2 then 
		prizeout=lot_prize[3][ZLottery_Get_RanPoint(lot_prizechance[3])]
			return 3,0,prizeout,2,0,0 
	else 
		return 4,0,3993,2,0,0
	end
	return 4,0,3993,2,0,0 
end 
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType11537Cashing(cur_list)	---(����֮��)
	---fmax_countΪ�ò�Ʊ����Чλ��
	local cp
	local nowcurlist={}
	local fmax_count=table.getn(cur_list)
	nowcurlist[0]=""
	for cp=1,fmax_count do
		nowcurlist[cp]=nowcurlist[cp-1]..cur_list[cp]
	end 
	
	local lot_prize={}
	local lot_prizechance={}
	local prizeout
	local Out_Prize={}
	Out_Prize[1]={}
	Out_Prize[2]={}
	Out_Prize[3]={}
	Out_Prize[4]={}
	
	Out_Prize[1][11538]=100		---����
	
	Out_Prize[2][11539]=100		---��������
	
	
	Out_Prize[3][6473]=100		---�»�֮��
	Out_Prize[4][8079]=100		---�������
		
	local i,v,k
	
	for k=1,4 do
		lot_prize[k]={}
		lot_prizechance[k]={}
	end 
	
	for k=1,4 do
		for i,v in pairs(Out_Prize[k]) do 
			table.insert(lot_prize[k],i)
			table.insert(lot_prizechance[k],v)
		end 
	end 
	if ZLottery_FindSameNum(cur_list,1)==1 and ZLottery_FindSameNum(cur_list,2)==1 and ZLottery_FindSameNum(cur_list,3)==1 then 
		prizeout=lot_prize[1][ZLottery_Get_RanPoint(lot_prizechance[1])]
		return 1,0,prizeout,1,0,0
	elseif ZLottery_FindSameNum(cur_list,1)>=1 and ZLottery_FindSameNum(cur_list,2)>=1 and ZLottery_FindSameNum(cur_list,3)==0 then 
		prizeout=lot_prize[2][ZLottery_Get_RanPoint(lot_prizechance[2])]
		return 2,0,prizeout,1,0,0
	elseif ZLottery_FindSameNum(cur_list,1)>=1 and ZLottery_FindSameNum(cur_list,2)==0 then  
		prizeout=lot_prize[3][ZLottery_Get_RanPoint(lot_prizechance[3])]
		return 3,0,prizeout,1,0,0
	else 
		return 4,0,8079,2,0,0
	end
	return 4,0,8079,2,0,0 
end
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType11742Cashing(cur_list)	---(����ɽ���ȴ����)
	---fmax_countΪ�ò�Ʊ����Чλ��
	local cp
	local nowcurlist={}
	local fmax_count=table.getn(cur_list)
	nowcurlist[0]=""
	for cp=1,fmax_count do
		nowcurlist[cp]=nowcurlist[cp-1]..cur_list[cp]
	end 
		
	if nowcurlist[fmax_count]=="111" then 
			return 1,0,4712,1,0,0
		end
	return 1,0,4712,1,0,0 
end
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType11743Cashing(cur_list)	---(�����򶾶������)
	---fmax_countΪ�ò�Ʊ����Чλ��
	local cp
	local nowcurlist={}
	local fmax_count=table.getn(cur_list)
	nowcurlist[0]=""
	for cp=1,fmax_count do
		nowcurlist[cp]=nowcurlist[cp-1]..cur_list[cp]
	end 
		
	if nowcurlist[fmax_count]=="111" then 
			return 1,0,4714,1,0,0
		end
	return 1,0,4714,1,0,0 
end
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType12006Cashing(cur_list)	---(����_���Ա���)
	---fmax_countΪ�ò�Ʊ����Чλ��
	local cp
	local nowcurlist={}
	local fmax_count=table.getn(cur_list)
	nowcurlist[0]=""
	for cp=1,fmax_count do
		nowcurlist[cp]=nowcurlist[cp-1]..cur_list[cp]
	end 
	
	local lot_prize={}
	local lot_prizechance={}
	local prizeout
	local Out_Prize={}
	Out_Prize[1]={}
	Out_Prize[2]={}
	Out_Prize[3]={}
	Out_Prize[4]={}
	
	Out_Prize[1][12005]=100		---������
	
	Out_Prize[2][10869]=100		---���«
	
	
	Out_Prize[3][2579]=100		---����ʯ
	Out_Prize[4][8079]=100		---�������
		
	local i,v,k
	
	for k=1,4 do
		lot_prize[k]={}
		lot_prizechance[k]={}
	end 
	
	for k=1,4 do
		for i,v in pairs(Out_Prize[k]) do 
			table.insert(lot_prize[k],i)
			table.insert(lot_prizechance[k],v)
		end 
	end 
	if ZLottery_FindSameNum(cur_list,1)==1 and ZLottery_FindSameNum(cur_list,2)==1 and ZLottery_FindSameNum(cur_list,3)==1 then 
		prizeout=lot_prize[1][ZLottery_Get_RanPoint(lot_prizechance[1])]
		return 1,0,prizeout,1,0,0
	elseif ZLottery_FindSameNum(cur_list,1)>=1 and ZLottery_FindSameNum(cur_list,2)>=1 and ZLottery_FindSameNum(cur_list,3)==0 then 
		prizeout=lot_prize[2][ZLottery_Get_RanPoint(lot_prizechance[2])]
		return 2,0,prizeout,1,0,0
	elseif ZLottery_FindSameNum(cur_list,1)>=1 and ZLottery_FindSameNum(cur_list,2)==0 then  
		prizeout=lot_prize[3][ZLottery_Get_RanPoint(lot_prizechance[3])]
		return 3,0,prizeout,8,0,0
	else 
		return 4,0,8079,2,0,0
	end
	return 4,0,8079,2,0,0 
end
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType13318Cashing(cur_list)	---(����_��������)
	---fmax_countΪ�ò�Ʊ����Чλ��
	local cp
	local nowcurlist={}
	local fmax_count=table.getn(cur_list)
	nowcurlist[0]=""
	for cp=1,fmax_count do
		nowcurlist[cp]=nowcurlist[cp-1]..cur_list[cp]
	end 
	
	local lot_prize={}
	local lot_prizechance={}
	local prizeout
	local Out_Prize={}
	Out_Prize[1]={}
	Out_Prize[2]={}
	Out_Prize[3]={}
	Out_Prize[4]={}
	Out_Prize[5]={}
	
	Out_Prize[1][13342]=100		---���ư׺ף��һ�ȯ��	
	
	Out_Prize[2][7931]=40			---��������
	Out_Prize[2][7937]=60			---������Ů

	Out_Prize[3][18794]=100		---�ɶ�

	Out_Prize[4][11678]=25		---��������ʯ(��ҿɼ�Ϊ4�Ƚ�)
	Out_Prize[4][11676]=25		---ħ������ʯ
	Out_Prize[4][11679]=25		---��������ʯ			
	Out_Prize[4][11677]=25		---��������ʯ

	Out_Prize[5][8079]=100		---�������	
		
	local i,v,k
	
	for k=1,5 do
		lot_prize[k]={}
		lot_prizechance[k]={}
	end 
	
	for k=1,5 do
		for i,v in pairs(Out_Prize[k]) do 
			table.insert(lot_prize[k],i)
			table.insert(lot_prizechance[k],v)
		end 
	end 
	if ZLottery_FindSameNum(cur_list,1)==1 and ZLottery_FindSameNum(cur_list,2)==1 and ZLottery_FindSameNum(cur_list,3)==1 then 
		prizeout=lot_prize[1][ZLottery_Get_RanPoint(lot_prizechance[1])]
		return 1,0,prizeout,1,0,0
	elseif ZLottery_FindSameNum(cur_list,1)>=1 and ZLottery_FindSameNum(cur_list,2)>=1 and ZLottery_FindSameNum(cur_list,3)==0 then 
		prizeout=lot_prize[2][ZLottery_Get_RanPoint(lot_prizechance[2])]
		return 2,0,prizeout,1,0,0
	elseif ZLottery_FindSameNum(cur_list,4)==3 then  
		prizeout=lot_prize[3][ZLottery_Get_RanPoint(lot_prizechance[3])]
		return 3,0,prizeout,3,0,0
	elseif ZLottery_FindSameNum(cur_list,1)>=1 and ZLottery_FindSameNum(cur_list,2)==0 then  
		prizeout=lot_prize[4][ZLottery_Get_RanPoint(lot_prizechance[4])]
		return 4,0,prizeout,1,0,0
	else 
		return 5,0,8079,2,0,0
	end
	return 5,0,8079,2,0,0 
end
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType13377Cashing(cur_list)	---(����ҳ������ӵ���������)
	---fmax_countΪ�ò�Ʊ����Чλ��
	local cp
	local nowcurlist={}
	local fmax_count=table.getn(cur_list)
	nowcurlist[0]=""
	for cp=1,fmax_count do
		nowcurlist[cp]=nowcurlist[cp-1]..cur_list[cp]
	end 
	
	local lot_prize={}
	local lot_prizechance={}
	local prizeout
	local Out_Prize={}
	Out_Prize[1]={}
	Out_Prize[2]={}
	Out_Prize[3]={}
	Out_Prize[4]={}
	Out_Prize[5]={}
	
	Out_Prize[1][13342]=100		---�ף��һ�ȯ��	
	
	Out_Prize[2][13312]=20		---�·�
	Out_Prize[2][13313]=40		---ͷ��	
	Out_Prize[2][13314]=40		---Ь��
		
	Out_Prize[3][13344]=100		---//���Ӷһ�ȯ
	
	Out_Prize[4][11678]=25		---��������ʯ
	Out_Prize[4][11676]=25		---ħ������ʯ
	Out_Prize[4][11679]=25		---��������ʯ			
	Out_Prize[4][11677]=25		---��������ʯ
	

	Out_Prize[5][8079]=100		---�������	
		
	local i,v,k
	
	for k=1,5 do
		lot_prize[k]={}
		lot_prizechance[k]={}
	end 
	
	for k=1,5 do
		for i,v in pairs(Out_Prize[k]) do 
			table.insert(lot_prize[k],i)
			table.insert(lot_prizechance[k],v)
		end 
	end 
	if ZLottery_FindSameNum(cur_list,1)==1 and ZLottery_FindSameNum(cur_list,2)==1 and ZLottery_FindSameNum(cur_list,3)==1 then 
		prizeout=lot_prize[1][ZLottery_Get_RanPoint(lot_prizechance[1])]
		return 1,0,prizeout,1,0,0
	elseif ZLottery_FindSameNum(cur_list,1)>=1 and ZLottery_FindSameNum(cur_list,2)>=1 and ZLottery_FindSameNum(cur_list,3)==0 then 
		prizeout=lot_prize[2][ZLottery_Get_RanPoint(lot_prizechance[2])]
		return 2,0,prizeout,1,0,0
	elseif ZLottery_FindSameNum(cur_list,4)==3 then  
		prizeout=lot_prize[3][ZLottery_Get_RanPoint(lot_prizechance[3])]
		return 3,0,prizeout,1,0,0
	elseif ZLottery_FindSameNum(cur_list,1)>=1 and ZLottery_FindSameNum(cur_list,2)==0 then  
		prizeout=lot_prize[4][ZLottery_Get_RanPoint(lot_prizechance[4])]
		return 4,0,prizeout,2,0,0
	else 
		return 5,0,8079,4,0,0
	end
	return 5,0,8079,4,0,0 
end
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType13319Cashing(cur_list)	---(Ǭ���ݱ�)
	---fmax_countΪ�ò�Ʊ����Чλ��
	local cp
	local nowcurlist={}
	local fmax_count=table.getn(cur_list)
	nowcurlist[0]=""
	for cp=1,fmax_count do
		nowcurlist[cp]=nowcurlist[cp-1]..cur_list[cp]
	end 
	
	local lot_prize={}
	local lot_prizechance={}
	local prizeout
	local Out_Prize={}
	Out_Prize[1]={}
	Out_Prize[2]={}
	Out_Prize[3]={}
	Out_Prize[4]={}
	
	Out_Prize[1][10867]=100		---������
	Out_Prize[2][13350]=100		---���˷�
	Out_Prize[3][13343]=100		---�۱���
	Out_Prize[4][1807]=100		---̫һ��
		
	local i,v,k
	for k=1,4 do
		lot_prize[k]={}
		lot_prizechance[k]={}
	end 
	
	for k=1,4 do
		for i,v in pairs(Out_Prize[k]) do 
			table.insert(lot_prize[k],i)
			table.insert(lot_prizechance[k],v)
		end 
	end 
	if ZLottery_FindSameNum(cur_list,1)==1 and ZLottery_FindSameNum(cur_list,2)==1 and ZLottery_FindSameNum(cur_list,3)==1 then 
		prizeout=lot_prize[1][ZLottery_Get_RanPoint(lot_prizechance[1])]
		return 1,0,prizeout,1,0,0
	elseif ZLottery_FindSameNum(cur_list,1)>=1 and ZLottery_FindSameNum(cur_list,2)>=1 and ZLottery_FindSameNum(cur_list,3)==0 then 
		prizeout=lot_prize[2][ZLottery_Get_RanPoint(lot_prizechance[2])]
		return 2,0,prizeout,15,0,0
	elseif ZLottery_FindSameNum(cur_list,1)>=1 and ZLottery_FindSameNum(cur_list,2)==0 then  
		prizeout=lot_prize[3][ZLottery_Get_RanPoint(lot_prizechance[3])]
		return 3,0,prizeout,1,0,0
	else 
		return 4,0,1807,6,0,0
	end
	return 4,0,1807,6,0,0 
end
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryTypeCharmSeason1Cashing(cur_list,id)	---(��һ����������)
	---fmax_countΪ�ò�Ʊ����Чλ��
	local cp
	local nowcurlist={}
	local fmax_count=table.getn(cur_list)
	nowcurlist[0]=""
	for cp=1,fmax_count do
		nowcurlist[cp]=nowcurlist[cp-1]..cur_list[cp]
	end 
	
	local lot_prize={}
	local lot_prizechance={}
	local prizeout
	local Out_Prize={}
	Out_Prize[1]={}
	
	if id==13320 then  ---����
		Out_Prize[1][12686]=200  ---��������_��
		Out_Prize[1][12691]=47  ---��������_��
		Out_Prize[1][12696]=63  ---��ħ�ط�_��
		Out_Prize[1][12701]=27  ---����е�_��
		Out_Prize[1][12706]=26  ---���﷨��_��
		Out_Prize[1][12711]=31  ---�������_��
		Out_Prize[1][12716]=53  ---������_��
		Out_Prize[1][12722]=42  ---��������_��
		Out_Prize[1][12727]=28  ---��Ԫ����_��
		Out_Prize[1][12732]=31  ---�������_��
		Out_Prize[1][12737]=47  ---������_��
		Out_Prize[1][12742]=200  ---�罣֮â_��
		Out_Prize[1][12747]=170  ---��Ԫ���_��
		Out_Prize[1][12752]=63  ---��ħŭ��_��
		Out_Prize[1][12757]=63  ---ŭ���Ľ�_��
		Out_Prize[1][12762]=37  ---а������_��
		Out_Prize[1][12767]=47  ---�������_��
		Out_Prize[1][12772]=32  ---ն������_��
		Out_Prize[1][12777]=27  ---������â_��
		Out_Prize[1][12782]=170  ---��Ԫ֮��_��
		Out_Prize[1][12788]=29  ---���᳤��_��
		Out_Prize[1][12793]=30  ---����ʥ��_��
		Out_Prize[1][12798]=29  ---��������_��
		Out_Prize[1][12803]=23  ---���ӹ���_��
		Out_Prize[1][12808]=23  ---������ŭ_��
		Out_Prize[1][12813]=38  ---�������_��
		Out_Prize[1][12818]=36  ---ʢ��֮��_��
		Out_Prize[1][12823]=72  ---˪������_��
		Out_Prize[1][12828]=63  ---�������_��
		Out_Prize[1][12833]=63  ---���׽���_��
		Out_Prize[1][12838]=25  ---���׿�Х_��
		Out_Prize[1][12843]=29  ---Ⱥ���ѿ�_��
		Out_Prize[1][12848]=34  ---�������_��

	elseif id==13321 then 
		Out_Prize[1][12687]=200  ---��������_ľ
		Out_Prize[1][12692]=47  ---��������_ľ
		Out_Prize[1][12697]=63  ---��ħ�ط�_ľ
		Out_Prize[1][12702]=27  ---����е�_ľ
		Out_Prize[1][12707]=26  ---���﷨��_ľ
		Out_Prize[1][12712]=31  ---�������_ľ
		Out_Prize[1][12718]=53  ---������_ľ
		Out_Prize[1][12723]=42  ---��������_ľ
		Out_Prize[1][12728]=28  ---��Ԫ����_ľ
		Out_Prize[1][12733]=31  ---�������_ľ
		Out_Prize[1][12738]=47  ---������_ľ
		Out_Prize[1][12743]=200  ---�罣֮â_ľ
		Out_Prize[1][12748]=170  ---��Ԫ���_ľ
		Out_Prize[1][12753]=63  ---��ħŭ��_ľ
		Out_Prize[1][12758]=63  ---ŭ���Ľ�_ľ
		Out_Prize[1][12763]=37  ---а������_ľ
		Out_Prize[1][12768]=47  ---�������_ľ
		Out_Prize[1][12773]=32  ---ն������_ľ
		Out_Prize[1][12778]=27  ---������â_ľ
		Out_Prize[1][12783]=170  ---��Ԫ֮��_ľ
		Out_Prize[1][12789]=29  ---���᳤��_ľ
		Out_Prize[1][12794]=30  ---����ʥ��_ľ
		Out_Prize[1][12799]=29  ---��������_ľ
		Out_Prize[1][12804]=23  ---���ӹ���_ľ
		Out_Prize[1][12809]=23  ---������ŭ_ľ
		Out_Prize[1][12814]=38  ---�������_ľ
		Out_Prize[1][12819]=36  ---ʢ��֮��_ľ
		Out_Prize[1][12824]=72  ---˪������_ľ
		Out_Prize[1][12829]=63  ---�������_ľ
		Out_Prize[1][12834]=63  ---���׽���_ľ
		Out_Prize[1][12839]=25  ---���׿�Х_ľ
		Out_Prize[1][12844]=29  ---Ⱥ���ѿ�_ľ
		Out_Prize[1][12849]=34  ---�������_ľ

	elseif id==13322 then 
		Out_Prize[1][12688]=200  ---��������_ˮ
		Out_Prize[1][12693]=47  ---��������_ˮ
		Out_Prize[1][12698]=63  ---��ħ�ط�_ˮ
		Out_Prize[1][12703]=27  ---����е�_ˮ
		Out_Prize[1][12708]=26  ---���﷨��_ˮ
		Out_Prize[1][12713]=31  ---�������_ˮ
		Out_Prize[1][12719]=53  ---������_ˮ
		Out_Prize[1][12724]=42  ---��������_ˮ
		Out_Prize[1][12729]=28  ---��Ԫ����_ˮ
		Out_Prize[1][12734]=31  ---�������_ˮ
		Out_Prize[1][12739]=47  ---������_ˮ
		Out_Prize[1][12744]=200  ---�罣֮â_ˮ
		Out_Prize[1][12749]=170  ---��Ԫ���_ˮ
		Out_Prize[1][12754]=63  ---��ħŭ��_ˮ
		Out_Prize[1][12759]=63  ---ŭ���Ľ�_ˮ
		Out_Prize[1][12764]=37  ---а������_ˮ
		Out_Prize[1][12769]=47  ---�������_ˮ
		Out_Prize[1][12774]=32  ---ն������_ˮ
		Out_Prize[1][12779]=27  ---������â_ˮ
		Out_Prize[1][12784]=170  ---��Ԫ֮��_ˮ
		Out_Prize[1][12790]=29  ---���᳤��_ˮ
		Out_Prize[1][12795]=30  ---����ʥ��_ˮ
		Out_Prize[1][12800]=29  ---��������_ˮ
		Out_Prize[1][12805]=23  ---���ӹ���_ˮ
		Out_Prize[1][12810]=23  ---������ŭ_ˮ
		Out_Prize[1][12815]=38  ---�������_ˮ
		Out_Prize[1][12820]=36  ---ʢ��֮��_ˮ
		Out_Prize[1][12825]=72  ---˪������_ˮ
		Out_Prize[1][12830]=63  ---�������_ˮ
		Out_Prize[1][12835]=63  ---���׽���_ˮ
		Out_Prize[1][12840]=25  ---���׿�Х_ˮ
		Out_Prize[1][12845]=29  ---Ⱥ���ѿ�_ˮ
		Out_Prize[1][12850]=34  ---�������_ˮ

	elseif id==13323 then 
		Out_Prize[1][12689]=200  ---��������_��
		Out_Prize[1][12694]=47  ---��������_��
		Out_Prize[1][12699]=63  ---��ħ�ط�_��
		Out_Prize[1][12704]=27  ---����е�_��
		Out_Prize[1][12709]=26  ---���﷨��_��
		Out_Prize[1][12714]=31  ---�������_��
		Out_Prize[1][12720]=53  ---������_��
		Out_Prize[1][12725]=42  ---��������_��
		Out_Prize[1][12730]=28  ---��Ԫ����_��
		Out_Prize[1][12735]=31  ---�������_��
		Out_Prize[1][12740]=47  ---������_��
		Out_Prize[1][12745]=200  ---�罣֮â_��
		Out_Prize[1][12750]=170  ---��Ԫ���_��
		Out_Prize[1][12755]=63  ---��ħŭ��_��
		Out_Prize[1][12760]=63  ---ŭ���Ľ�_��
		Out_Prize[1][12765]=37  ---а������_��
		Out_Prize[1][12770]=47  ---�������_��
		Out_Prize[1][12775]=32  ---ն������_��
		Out_Prize[1][12780]=27  ---������â_��
		Out_Prize[1][12785]=170  ---��Ԫ֮��_��
		Out_Prize[1][12791]=29  ---���᳤��_��
		Out_Prize[1][12796]=30  ---����ʥ��_��
		Out_Prize[1][12801]=29  ---��������_��
		Out_Prize[1][12806]=23  ---���ӹ���_��
		Out_Prize[1][12811]=23  ---������ŭ_��
		Out_Prize[1][12816]=38  ---�������_��
		Out_Prize[1][12821]=36  ---ʢ��֮��_��
		Out_Prize[1][12826]=72  ---˪������_��
		Out_Prize[1][12831]=63  ---�������_��
		Out_Prize[1][12836]=63  ---���׽���_��
		Out_Prize[1][12841]=25  ---���׿�Х_��
		Out_Prize[1][12846]=29  ---Ⱥ���ѿ�_��
		Out_Prize[1][12851]=34  ---�������_��

	elseif id==13324 then 
		Out_Prize[1][12690]=200  ---��������_��
		Out_Prize[1][12695]=47  ---��������_��
		Out_Prize[1][12700]=63  ---��ħ�ط�_��
		Out_Prize[1][12705]=27  ---����е�_��
		Out_Prize[1][12710]=26  ---���﷨��_��
		Out_Prize[1][12715]=31  ---�������_��
		Out_Prize[1][12721]=53  ---������_��
		Out_Prize[1][12726]=42  ---��������_��
		Out_Prize[1][12731]=28  ---��Ԫ����_��
		Out_Prize[1][12736]=31  ---�������_��
		Out_Prize[1][12741]=47  ---������_��
		Out_Prize[1][12746]=200  ---�罣֮â_��
		Out_Prize[1][12751]=170  ---��Ԫ���_��
		Out_Prize[1][12756]=63  ---��ħŭ��_��
		Out_Prize[1][12761]=63  ---ŭ���Ľ�_��
		Out_Prize[1][12766]=37  ---а������_��
		Out_Prize[1][12771]=47  ---�������_��
		Out_Prize[1][12776]=32  ---ն������_��
		Out_Prize[1][12781]=27  ---������â_��
		Out_Prize[1][12786]=170  ---��Ԫ֮��_��
		Out_Prize[1][12792]=29  ---���᳤��_��
		Out_Prize[1][12797]=30  ---����ʥ��_��
		Out_Prize[1][12802]=29  ---��������_��
		Out_Prize[1][12807]=23  ---���ӹ���_��
		Out_Prize[1][12812]=23  ---������ŭ_��
		Out_Prize[1][12817]=38  ---�������_��
		Out_Prize[1][12822]=36  ---ʢ��֮��_��
		Out_Prize[1][12827]=72  ---˪������_��
		Out_Prize[1][12832]=63  ---�������_��
		Out_Prize[1][12837]=63  ---���׽���_��
		Out_Prize[1][12842]=25  ---���׿�Х_��
		Out_Prize[1][12847]=29  ---Ⱥ���ѿ�_��
		Out_Prize[1][12852]=34  ---�������_��

	elseif id==13325 then 
		Out_Prize[1][12072]=200  ---��ħ_��
		Out_Prize[1][12073]=30  ---����_��
		Out_Prize[1][12074]=30  ---����_��
		Out_Prize[1][12075]=47  ---����_��
		Out_Prize[1][12076]=46  ---�ƻ�_��
		Out_Prize[1][12077]=31  ---�޼�_��
		Out_Prize[1][12078]=38  ---����_��
		Out_Prize[1][12079]=40  ---��ŭ_��
		Out_Prize[1][12080]=26  ---����_��
		Out_Prize[1][12081]=30  ---��Ǵ_��
		Out_Prize[1][12082]=47  ---����_��
		Out_Prize[1][12083]=33  ---����_��
		Out_Prize[1][12084]=42  ---ҵ��_��
		Out_Prize[1][12085]=30  ---����_��
		Out_Prize[1][12086]=33  ---ս��_��
		Out_Prize[1][12087]=30  ---��ɷ_��
		Out_Prize[1][12088]=40  ---ħ��_��
		Out_Prize[1][12089]=27  ---��Թ_��
		Out_Prize[1][12090]=30  ---����_��
		Out_Prize[1][12091]=26  ---Ѫ��_��
		Out_Prize[1][12092]=26  ---����_��
		Out_Prize[1][12093]=26  ---����_��
		Out_Prize[1][12094]=53  ---����_��
		Out_Prize[1][12095]=38  ---��Ѫ_��
		Out_Prize[1][12096]=29  ---����_��
		Out_Prize[1][12097]=31  ---��ע_��
		Out_Prize[1][12098]=27  ---ĩ��_��
		Out_Prize[1][12099]=53  ---����_��
		Out_Prize[1][12100]=92  ---����_��
		Out_Prize[1][12101]=47  ---ħɷ_��
		Out_Prize[1][12102]=30  ---�ƿ�_��
		Out_Prize[1][12103]=35  ---����_��
		Out_Prize[1][12104]=26  ---ŭ��_��

	elseif id==13326 then 
		Out_Prize[1][12128]=200  ---��ħ_ľ
		Out_Prize[1][12130]=30  ---����_ľ
		Out_Prize[1][12131]=30  ---����_ľ
		Out_Prize[1][12133]=47  ---����_ľ
		Out_Prize[1][12135]=46  ---�ƻ�_ľ
		Out_Prize[1][12136]=31  ---�޼�_ľ
		Out_Prize[1][12139]=38  ---����_ľ
		Out_Prize[1][12141]=40  ---��ŭ_ľ
		Out_Prize[1][12144]=26  ---����_ľ
		Out_Prize[1][12147]=30  ---��Ǵ_ľ
		Out_Prize[1][12148]=47  ---����_ľ
		Out_Prize[1][12149]=33  ---����_ľ
		Out_Prize[1][12151]=42  ---ҵ��_ľ
		Out_Prize[1][12153]=30  ---����_ľ
		Out_Prize[1][12155]=33  ---ս��_ľ
		Out_Prize[1][12157]=30  ---��ɷ_ľ
		Out_Prize[1][12159]=40  ---ħ��_ľ
		Out_Prize[1][12161]=27  ---��Թ_ľ
		Out_Prize[1][12164]=30  ---����_ľ
		Out_Prize[1][12166]=26  ---Ѫ��_ľ
		Out_Prize[1][12167]=26  ---����_ľ
		Out_Prize[1][12169]=26  ---����_ľ
		Out_Prize[1][12171]=53  ---����_ľ
		Out_Prize[1][12173]=38  ---��Ѫ_ľ
		Out_Prize[1][12175]=29  ---����_ľ
		Out_Prize[1][12177]=31  ---��ע_ľ
		Out_Prize[1][12179]=27  ---ĩ��_ľ
		Out_Prize[1][12181]=53  ---����_ľ
		Out_Prize[1][12182]=92  ---����_ľ
		Out_Prize[1][12184]=47  ---ħɷ_ľ
		Out_Prize[1][12185]=30  ---�ƿ�_ľ
		Out_Prize[1][12187]=35  ---����_ľ
		Out_Prize[1][12188]=26  ---ŭ��_ľ

	elseif id==13327 then 
		Out_Prize[1][12228]=200  ---��ħ_ˮ
		Out_Prize[1][12230]=30  ---����_ˮ
		Out_Prize[1][12232]=30  ---����_ˮ
		Out_Prize[1][12234]=47  ---����_ˮ
		Out_Prize[1][12236]=46  ---�ƻ�_ˮ
		Out_Prize[1][12238]=31  ---�޼�_ˮ
		Out_Prize[1][12242]=38  ---����_ˮ
		Out_Prize[1][12243]=40  ---��ŭ_ˮ
		Out_Prize[1][12244]=26  ---����_ˮ
		Out_Prize[1][12245]=30  ---��Ǵ_ˮ
		Out_Prize[1][12247]=47  ---����_ˮ
		Out_Prize[1][12248]=33  ---����_ˮ
		Out_Prize[1][12250]=42  ---ҵ��_ˮ
		Out_Prize[1][12252]=30  ---����_ˮ
		Out_Prize[1][12254]=33  ---ս��_ˮ
		Out_Prize[1][12257]=30  ---��ɷ_ˮ
		Out_Prize[1][12259]=40  ---ħ��_ˮ
		Out_Prize[1][12260]=27  ---��Թ_ˮ
		Out_Prize[1][12261]=30  ---����_ˮ
		Out_Prize[1][12262]=26  ---Ѫ��_ˮ
		Out_Prize[1][12263]=26  ---����_ˮ
		Out_Prize[1][12264]=26  ---����_ˮ
		Out_Prize[1][12265]=53  ---����_ˮ
		Out_Prize[1][12266]=38  ---��Ѫ_ˮ
		Out_Prize[1][12267]=29  ---����_ˮ
		Out_Prize[1][12268]=31  ---��ע_ˮ
		Out_Prize[1][12269]=27  ---ĩ��_ˮ
		Out_Prize[1][12270]=53  ---����_ˮ
		Out_Prize[1][12271]=92  ---����_ˮ
		Out_Prize[1][12272]=47  ---ħɷ_ˮ
		Out_Prize[1][12273]=30  ---�ƿ�_ˮ
		Out_Prize[1][12274]=35  ---����_ˮ
		Out_Prize[1][12275]=26  ---ŭ��_ˮ


	elseif id==13328 then 
		Out_Prize[1][12284]=200  ---��ħ_��
		Out_Prize[1][12285]=30  ---����_��
		Out_Prize[1][12286]=30  ---����_��
		Out_Prize[1][12287]=47  ---����_��
		Out_Prize[1][12288]=46  ---�ƻ�_��
		Out_Prize[1][12289]=31  ---�޼�_��
		Out_Prize[1][12290]=38  ---����_��
		Out_Prize[1][12291]=40  ---��ŭ_��
		Out_Prize[1][12292]=26  ---����_��
		Out_Prize[1][12293]=30  ---��Ǵ_��
		Out_Prize[1][12294]=47  ---����_��
		Out_Prize[1][12295]=33  ---����_��
		Out_Prize[1][12296]=42  ---ҵ��_��
		Out_Prize[1][12298]=30  ---����_��
		Out_Prize[1][12300]=33  ---ս��_��
		Out_Prize[1][12302]=30  ---��ɷ_��
		Out_Prize[1][12304]=40  ---ħ��_��
		Out_Prize[1][12306]=27  ---��Թ_��
		Out_Prize[1][12308]=30  ---����_��
		Out_Prize[1][12310]=26  ---Ѫ��_��
		Out_Prize[1][12312]=26  ---����_��
		Out_Prize[1][12314]=26  ---����_��
		Out_Prize[1][12316]=53  ---����_��
		Out_Prize[1][12318]=38  ---��Ѫ_��
		Out_Prize[1][12322]=29  ---����_��
		Out_Prize[1][12323]=31  ---��ע_��
		Out_Prize[1][12325]=27  ---ĩ��_��
		Out_Prize[1][12327]=53  ---����_��
		Out_Prize[1][12329]=92  ---����_��
		Out_Prize[1][12330]=47  ---ħɷ_��
		Out_Prize[1][12333]=30  ---�ƿ�_��
		Out_Prize[1][12335]=35  ---����_��
		Out_Prize[1][12337]=26  ---ŭ��_��


	elseif id==13329 then 
		Out_Prize[1][12346]=200  ---��ħ_��
		Out_Prize[1][12347]=30  ---����_��
		Out_Prize[1][12348]=30  ---����_��
		Out_Prize[1][12349]=47  ---����_��
		Out_Prize[1][12350]=46  ---�ƻ�_��
		Out_Prize[1][12351]=31  ---�޼�_��
		Out_Prize[1][12352]=38  ---����_��
		Out_Prize[1][12353]=40  ---��ŭ_��
		Out_Prize[1][12354]=26  ---����_��
		Out_Prize[1][12355]=30  ---��Ǵ_��
		Out_Prize[1][12356]=47  ---����_��
		Out_Prize[1][12357]=33  ---����_��
		Out_Prize[1][12358]=42  ---ҵ��_��
		Out_Prize[1][12359]=30  ---����_��
		Out_Prize[1][12360]=33  ---ս��_��
		Out_Prize[1][12361]=30  ---��ɷ_��
		Out_Prize[1][12362]=40  ---ħ��_��
		Out_Prize[1][12363]=27  ---��Թ_��
		Out_Prize[1][12364]=30  ---����_��
		Out_Prize[1][12365]=26  ---Ѫ��_��
		Out_Prize[1][12366]=26  ---����_��
		Out_Prize[1][12367]=26  ---����_��
		Out_Prize[1][12368]=53  ---����_��
		Out_Prize[1][12369]=38  ---��Ѫ_��
		Out_Prize[1][12370]=29  ---����_��
		Out_Prize[1][12371]=31  ---��ע_��
		Out_Prize[1][12372]=27  ---ĩ��_��
		Out_Prize[1][12373]=53  ---����_��
		Out_Prize[1][12374]=92  ---����_��
		Out_Prize[1][12375]=47  ---ħɷ_��
		Out_Prize[1][12376]=30  ---�ƿ�_��
		Out_Prize[1][12377]=35  ---����_��
		Out_Prize[1][12378]=26  ---ŭ��_��


	elseif id==13330 then 
		Out_Prize[1][12107]=92  ---�컨��׹_��
		Out_Prize[1][12109]=29  ---�ռ���ɫ_��
		Out_Prize[1][12111]=31  ---���ı���_��
		Out_Prize[1][12115]=200  ---��ħ����_��
		Out_Prize[1][12117]=92  ---���ķ���_��
		Out_Prize[1][12118]=170  ---������_��
		Out_Prize[1][12119]=28  ---�̱���Ԫ_��
		Out_Prize[1][12120]=47  ---���쵻��_��
		Out_Prize[1][12121]=43  ---��������_��
		Out_Prize[1][12122]=35  ---���ݳ���_��
		Out_Prize[1][12123]=27  ---����֮��_��
		Out_Prize[1][12124]=35  ---һ�����_��
		Out_Prize[1][12125]=34  ---�Ⱦ��ٲ�_��
		Out_Prize[1][12126]=29  ---ɫ���ǿ�_��
		Out_Prize[1][12127]=29  ---��ڤ����_��
		Out_Prize[1][12129]=28  ---����֮��_��
		Out_Prize[1][12132]=26  ---���ѭ��_��
		Out_Prize[1][12134]=26  ---Ԧ����ͨ_��
		Out_Prize[1][12137]=92  ---������Ը_��
		Out_Prize[1][12138]=28  ---������Ե_��
		Out_Prize[1][12140]=53  ---��������_��
		Out_Prize[1][12142]=34  ---�������_��
		Out_Prize[1][12143]=27  ---�޾��ຣ_��
		Out_Prize[1][12145]=35  ---��������_��
		Out_Prize[1][12146]=35  ---Ǭ������_��
		Out_Prize[1][12150]=29  ---��������_��
		Out_Prize[1][12152]=29  ---�����ħ_��
		Out_Prize[1][12154]=31  ---��ħ���_��
		Out_Prize[1][12156]=32  ---��������_��
		Out_Prize[1][12158]=30  ---�޳��ֶ�_��
		Out_Prize[1][12160]=55  ---��ת֮��_��
		Out_Prize[1][12162]=34  ---�ȱ�Ϊ��_��
		Out_Prize[1][12163]=30  ---��ħ����_��

	elseif id==13331 then 
		Out_Prize[1][12183]=92  ---�컨��׹_ľ
		Out_Prize[1][12186]=29  ---�ռ���ɫ_ľ
		Out_Prize[1][12189]=31  ---���ı���_ľ
		Out_Prize[1][12192]=200  ---��ħ����_ľ
		Out_Prize[1][12194]=92  ---���ķ���_ľ
		Out_Prize[1][12197]=170  ---������_ľ
		Out_Prize[1][12199]=28  ---�̱���Ԫ_ľ
		Out_Prize[1][12202]=47  ---���쵻��_ľ
		Out_Prize[1][12203]=43  ---��������_ľ
		Out_Prize[1][12204]=35  ---���ݳ���_ľ
		Out_Prize[1][12205]=27  ---����֮��_ľ
		Out_Prize[1][12206]=35  ---һ�����_ľ
		Out_Prize[1][12207]=34  ---�Ⱦ��ٲ�_ľ
		Out_Prize[1][12208]=29  ---ɫ���ǿ�_ľ
		Out_Prize[1][12209]=29  ---��ڤ����_ľ
		Out_Prize[1][12210]=28  ---����֮��_ľ
		Out_Prize[1][12211]=26  ---���ѭ��_ľ
		Out_Prize[1][12212]=26  ---Ԧ����ͨ_ľ
		Out_Prize[1][12213]=92  ---������Ը_ľ
		Out_Prize[1][12214]=28  ---������Ե_ľ
		Out_Prize[1][12215]=53  ---��������_ľ
		Out_Prize[1][12216]=34  ---�������_ľ
		Out_Prize[1][12217]=27  ---�޾��ຣ_ľ
		Out_Prize[1][12218]=35  ---��������_ľ
		Out_Prize[1][12219]=35  ---Ǭ������_ľ
		Out_Prize[1][12220]=29  ---��������_ľ
		Out_Prize[1][12221]=29  ---�����ħ_ľ
		Out_Prize[1][12222]=31  ---��ħ���_ľ
		Out_Prize[1][12223]=32  ---��������_ľ
		Out_Prize[1][12224]=30  ---�޳��ֶ�_ľ
		Out_Prize[1][12225]=55  ---��ת֮��_ľ
		Out_Prize[1][12226]=34  ---�ȱ�Ϊ��_ľ
		Out_Prize[1][12227]=30  ---��ħ����_ľ

	elseif id==13332 then
		Out_Prize[1][12246]=92  ---�컨��׹_ˮ
		Out_Prize[1][12249]=29  ---�ռ���ɫ_ˮ
		Out_Prize[1][12251]=31  ---���ı���_ˮ
		Out_Prize[1][12253]=200  ---��ħ����_ˮ
		Out_Prize[1][12255]=92  ---���ķ���_ˮ
		Out_Prize[1][12256]=170  ---������_ˮ
		Out_Prize[1][12258]=28  ---�̱���Ԫ_ˮ
		Out_Prize[1][12297]=47  ---���쵻��_ˮ
		Out_Prize[1][12299]=43  ---��������_ˮ
		Out_Prize[1][12301]=35  ---���ݳ���_ˮ
		Out_Prize[1][12303]=27  ---����֮��_ˮ
		Out_Prize[1][12305]=35  ---һ�����_ˮ
		Out_Prize[1][12307]=34  ---�Ⱦ��ٲ�_ˮ
		Out_Prize[1][12309]=29  ---ɫ���ǿ�_ˮ
		Out_Prize[1][12311]=29  ---��ڤ����_ˮ
		Out_Prize[1][12313]=28  ---����֮��_ˮ
		Out_Prize[1][12315]=26  ---���ѭ��_ˮ
		Out_Prize[1][12317]=26  ---Ԧ����ͨ_ˮ
		Out_Prize[1][12319]=92  ---������Ը_ˮ
		Out_Prize[1][12320]=28  ---������Ե_ˮ
		Out_Prize[1][12321]=53  ---��������_ˮ
		Out_Prize[1][12324]=34  ---�������_ˮ
		Out_Prize[1][12326]=27  ---�޾��ຣ_ˮ
		Out_Prize[1][12328]=35  ---��������_ˮ
		Out_Prize[1][12331]=35  ---Ǭ������_ˮ
		Out_Prize[1][12332]=29  ---��������_ˮ
		Out_Prize[1][12334]=29  ---�����ħ_ˮ
		Out_Prize[1][12336]=31  ---��ħ���_ˮ
		Out_Prize[1][12387]=32  ---��������_ˮ
		Out_Prize[1][12388]=30  ---�޳��ֶ�_ˮ
		Out_Prize[1][12389]=55  ---��ת֮��_ˮ
		Out_Prize[1][12390]=34  ---�ȱ�Ϊ��_ˮ
		Out_Prize[1][12391]=30  ---��ħ����_ˮ

 
	elseif id==13333 then 
		Out_Prize[1][12400]=92  ---�컨��׹_��
		Out_Prize[1][12401]=29  ---�ռ���ɫ_��
		Out_Prize[1][12402]=31  ---���ı���_��
		Out_Prize[1][12403]=200  ---��ħ����_��
		Out_Prize[1][12404]=92  ---���ķ���_��
		Out_Prize[1][12405]=170  ---������_��
		Out_Prize[1][12406]=28  ---�̱���Ԫ_��
		Out_Prize[1][12407]=47  ---���쵻��_��
		Out_Prize[1][12408]=43  ---��������_��
		Out_Prize[1][12409]=35  ---���ݳ���_��
		Out_Prize[1][12410]=27  ---����֮��_��
		Out_Prize[1][12411]=35  ---һ�����_��
		Out_Prize[1][12412]=34  ---�Ⱦ��ٲ�_��
		Out_Prize[1][12413]=29  ---ɫ���ǿ�_��
		Out_Prize[1][12414]=29  ---��ڤ����_��
		Out_Prize[1][12415]=28  ---����֮��_��
		Out_Prize[1][12416]=26  ---���ѭ��_��
		Out_Prize[1][12417]=26  ---Ԧ����ͨ_��
		Out_Prize[1][12418]=92  ---������Ը_��
		Out_Prize[1][12419]=28  ---������Ե_��
		Out_Prize[1][12420]=53  ---��������_��
		Out_Prize[1][12422]=34  ---�������_��
		Out_Prize[1][12450]=27  ---�޾��ຣ_��
		Out_Prize[1][12453]=35  ---��������_��
		Out_Prize[1][12455]=35  ---Ǭ������_��
		Out_Prize[1][12457]=29  ---��������_��
		Out_Prize[1][12460]=29  ---�����ħ_��
		Out_Prize[1][12463]=31  ---��ħ���_��
		Out_Prize[1][12465]=32  ---��������_��
		Out_Prize[1][12466]=30  ---�޳��ֶ�_��
		Out_Prize[1][12468]=55  ---��ת֮��_��
		Out_Prize[1][12470]=34  ---�ȱ�Ϊ��_��
		Out_Prize[1][12473]=30  ---��ħ����_��


	elseif id==13334 then 
		Out_Prize[1][12503]=92  ---�컨��׹_��
		Out_Prize[1][13235]=29  ---�ռ���ɫ_��
		Out_Prize[1][12505]=31  ---���ı���_��
		Out_Prize[1][12507]=200  ---��ħ����_��
		Out_Prize[1][12509]=92  ---���ķ���_��
		Out_Prize[1][12512]=170  ---������_��
		Out_Prize[1][12514]=28  ---�̱���Ԫ_��
		Out_Prize[1][12516]=47  ---���쵻��_��
		Out_Prize[1][12518]=43  ---��������_��
		Out_Prize[1][12519]=35  ---���ݳ���_��
		Out_Prize[1][12520]=27  ---����֮��_��
		Out_Prize[1][12521]=35  ---һ�����_��
		Out_Prize[1][12522]=34  ---�Ⱦ��ٲ�_��
		Out_Prize[1][12523]=29  ---ɫ���ǿ�_��
		Out_Prize[1][12524]=29  ---��ڤ����_��
		Out_Prize[1][12525]=28  ---����֮��_��
		Out_Prize[1][12526]=26  ---���ѭ��_��
		Out_Prize[1][12527]=26  ---Ԧ����ͨ_��
		Out_Prize[1][12528]=92  ---������Ը_��
		Out_Prize[1][12529]=28  ---������Ե_��
		Out_Prize[1][12530]=53  ---��������_��
		Out_Prize[1][12531]=34  ---�������_��
		Out_Prize[1][12532]=27  ---�޾��ຣ_��
		Out_Prize[1][12533]=35  ---��������_��
		Out_Prize[1][12534]=35  ---Ǭ������_��
		Out_Prize[1][12535]=29  ---��������_��
		Out_Prize[1][12536]=29  ---�����ħ_��
		Out_Prize[1][12537]=31  ---��ħ���_��
		Out_Prize[1][12538]=32  ---��������_��
		Out_Prize[1][12539]=30  ---�޳��ֶ�_��
		Out_Prize[1][12540]=55  ---��ת֮��_��
		Out_Prize[1][12541]=34  ---�ȱ�Ϊ��_��
		Out_Prize[1][12542]=30  ---��ħ����_��


	elseif id==13335 then
		Out_Prize[1][12421]=200  ---���_��
		Out_Prize[1][12423]=63  ---ʶ��_��
		Out_Prize[1][12424]=35  ---����_��
		Out_Prize[1][12437]=27  ---����_��
		Out_Prize[1][12442]=92  ---����_��
		Out_Prize[1][12447]=26  ---�鶯_��
		Out_Prize[1][12454]=34  ---�þ�_��
		Out_Prize[1][12462]=29  ---����_��
		Out_Prize[1][12472]=29  ---����_��
		Out_Prize[1][12478]=37  ---����_��
		Out_Prize[1][12485]=28  ---����_��
		Out_Prize[1][12493]=34  ---����_��
		Out_Prize[1][12500]=42  ---���_��
		Out_Prize[1][12510]=38  ---Լ��_��
		Out_Prize[1][12551]=38  ---����_��
		Out_Prize[1][12556]=92  ---����_��
		Out_Prize[1][12561]=34  ---����_��
		Out_Prize[1][12566]=34  ---��Ը_��
		Out_Prize[1][12571]=22  ---���_��
		Out_Prize[1][12576]=72  ---����_��
		Out_Prize[1][12581]=42  ---�೾_��
		Out_Prize[1][12586]=34  ---˼��_��
		Out_Prize[1][12591]=31  ---��ʧ_��
		Out_Prize[1][12596]=47  ---����_��
		Out_Prize[1][12601]=28  ---����_��
		Out_Prize[1][12606]=28  ---����_��
		Out_Prize[1][12611]=47  ---���_��
		Out_Prize[1][12616]=42  ---����_��
		Out_Prize[1][12621]=34  ---����_��
		Out_Prize[1][12626]=26  ---��Ȼ_��
		Out_Prize[1][12631]=200  ---Ԧ��_��
		Out_Prize[1][12632]=27  ---����_��
		Out_Prize[1][12641]=37  ---����_��

 	elseif id==13336 then 
 		Out_Prize[1][12425]=200  ---���_ľ
		Out_Prize[1][12429]=63  ---ʶ��_ľ
		Out_Prize[1][12433]=35  ---����_ľ
		Out_Prize[1][12438]=27  ---����_ľ
		Out_Prize[1][12443]=92  ---����_ľ
		Out_Prize[1][12448]=26  ---�鶯_ľ
		Out_Prize[1][12456]=34  ---�þ�_ľ
		Out_Prize[1][12464]=29  ---����_ľ
		Out_Prize[1][12474]=29  ---����_ľ
		Out_Prize[1][12479]=37  ---����_ľ
		Out_Prize[1][12488]=28  ---����_ľ
		Out_Prize[1][12494]=34  ---����_ľ
		Out_Prize[1][12502]=42  ---���_ľ
		Out_Prize[1][12511]=38  ---Լ��_ľ
		Out_Prize[1][12552]=38  ---����_ľ
		Out_Prize[1][12557]=92  ---����_ľ
		Out_Prize[1][12562]=34  ---����_ľ
		Out_Prize[1][12567]=34  ---��Ը_ľ
		Out_Prize[1][12572]=22  ---���_ľ
		Out_Prize[1][12577]=72  ---����_ľ
		Out_Prize[1][12582]=42  ---�೾_ľ
		Out_Prize[1][12587]=34  ---˼��_ľ
		Out_Prize[1][12592]=31  ---��ʧ_ľ
		Out_Prize[1][12597]=47  ---����_ľ
		Out_Prize[1][12602]=28  ---����_ľ
		Out_Prize[1][12607]=28  ---����_ľ
		Out_Prize[1][12612]=47  ---���_ľ
		Out_Prize[1][12617]=42  ---����_ľ
		Out_Prize[1][12622]=34  ---����_ľ
		Out_Prize[1][12627]=26  ---��Ȼ_ľ
		Out_Prize[1][12633]=200  ---Ԧ��_ľ
		Out_Prize[1][12637]=27  ---����_ľ
		Out_Prize[1][12642]=37  ---����_ľ

	elseif id==13337 then
		Out_Prize[1][12426]=200  ---���_ˮ
		Out_Prize[1][12430]=63  ---ʶ��_ˮ
		Out_Prize[1][12434]=35  ---����_ˮ
		Out_Prize[1][12439]=27  ---����_ˮ
		Out_Prize[1][12444]=92  ---����_ˮ
		Out_Prize[1][12449]=26  ---�鶯_ˮ
		Out_Prize[1][12458]=34  ---�þ�_ˮ
		Out_Prize[1][12471]=29  ---����_ˮ
		Out_Prize[1][12475]=29  ---����_ˮ
		Out_Prize[1][12480]=37  ---����_ˮ
		Out_Prize[1][12490]=28  ---����_ˮ
		Out_Prize[1][12495]=34  ---����_ˮ
		Out_Prize[1][12504]=42  ---���_ˮ
		Out_Prize[1][12513]=38  ---Լ��_ˮ
		Out_Prize[1][12553]=38  ---����_ˮ
		Out_Prize[1][12558]=92  ---����_ˮ
		Out_Prize[1][12563]=34  ---����_ˮ
		Out_Prize[1][12568]=34  ---��Ը_ˮ
		Out_Prize[1][12573]=22  ---���_ˮ
		Out_Prize[1][12578]=72  ---����_ˮ
		Out_Prize[1][12583]=42  ---�೾_ˮ
		Out_Prize[1][12588]=34  ---˼��_ˮ
		Out_Prize[1][12593]=31  ---��ʧ_ˮ
		Out_Prize[1][12598]=47  ---����_ˮ
		Out_Prize[1][12603]=28  ---����_ˮ
		Out_Prize[1][12608]=28  ---����_ˮ
		Out_Prize[1][12613]=47  ---���_ˮ
		Out_Prize[1][12618]=42  ---����_ˮ
		Out_Prize[1][12623]=34  ---����_ˮ
		Out_Prize[1][12628]=26  ---��Ȼ_ˮ
		Out_Prize[1][12634]=200  ---Ԧ��_ˮ
		Out_Prize[1][12638]=27  ---����_ˮ
		Out_Prize[1][12643]=37  ---����_ˮ

 	elseif id==13338 then 
 		Out_Prize[1][12427]=200  ---���_��
		Out_Prize[1][12431]=63  ---ʶ��_��
		Out_Prize[1][12435]=35  ---����_��
		Out_Prize[1][12440]=27  ---����_��
		Out_Prize[1][12445]=92  ---����_��
		Out_Prize[1][12451]=26  ---�鶯_��
		Out_Prize[1][12459]=34  ---�þ�_��
		Out_Prize[1][12467]=29  ---����_��
		Out_Prize[1][12476]=29  ---����_��
		Out_Prize[1][12481]=37  ---����_��
		Out_Prize[1][12491]=28  ---����_��
		Out_Prize[1][12496]=34  ---����_��
		Out_Prize[1][12506]=42  ---���_��
		Out_Prize[1][12515]=38  ---Լ��_��
		Out_Prize[1][12554]=38  ---����_��
		Out_Prize[1][12559]=92  ---����_��
		Out_Prize[1][12564]=34  ---����_��
		Out_Prize[1][12569]=34  ---��Ը_��
		Out_Prize[1][12574]=22  ---���_��
		Out_Prize[1][12579]=72  ---����_��
		Out_Prize[1][12584]=42  ---�೾_��
		Out_Prize[1][12589]=34  ---˼��_��
		Out_Prize[1][12594]=31  ---��ʧ_��
		Out_Prize[1][12599]=47  ---����_��
		Out_Prize[1][12604]=28  ---����_��
		Out_Prize[1][12609]=28  ---����_��
		Out_Prize[1][12614]=47  ---���_��
		Out_Prize[1][12619]=42  ---����_��
		Out_Prize[1][12624]=34  ---����_��
		Out_Prize[1][12629]=26  ---��Ȼ_��
		Out_Prize[1][12635]=200  ---Ԧ��_��
		Out_Prize[1][12639]=27  ---����_��
		Out_Prize[1][12644]=37  ---����_��
	
	elseif id==13339 then 
		Out_Prize[1][12428]=200  ---���_��
		Out_Prize[1][12432]=63  ---ʶ��_��
		Out_Prize[1][12436]=35  ---����_��
		Out_Prize[1][12441]=27  ---����_��
		Out_Prize[1][12446]=92  ---����_��
		Out_Prize[1][12452]=26  ---�鶯_��
		Out_Prize[1][12461]=34  ---�þ�_��
		Out_Prize[1][12469]=29  ---����_��
		Out_Prize[1][12477]=29  ---����_��
		Out_Prize[1][12484]=37  ---����_��
		Out_Prize[1][12492]=28  ---����_��
		Out_Prize[1][12497]=34  ---����_��
		Out_Prize[1][12508]=42  ---���_��
		Out_Prize[1][12517]=38  ---Լ��_��
		Out_Prize[1][12555]=38  ---����_��
		Out_Prize[1][12560]=92  ---����_��
		Out_Prize[1][12565]=34  ---����_��
		Out_Prize[1][12570]=34  ---��Ը_��
		Out_Prize[1][12575]=22  ---���_��
		Out_Prize[1][12580]=72  ---����_��
		Out_Prize[1][12585]=42  ---�೾_��
		Out_Prize[1][12590]=34  ---˼��_��
		Out_Prize[1][12595]=31  ---��ʧ_��
		Out_Prize[1][12600]=47  ---����_��
		Out_Prize[1][12605]=28  ---����_��
		Out_Prize[1][12610]=28  ---����_��
		Out_Prize[1][12615]=47  ---���_��
		Out_Prize[1][12620]=42  ---����_��
		Out_Prize[1][12625]=34  ---����_��
		Out_Prize[1][12630]=26  ---��Ȼ_��
		Out_Prize[1][12636]=200  ---Ԧ��_��
		Out_Prize[1][12640]=27  ---����_��
		Out_Prize[1][12645]=37  ---����_��
	
	elseif id==18752 then
		Out_Prize[1][18460]=120---�����_��
		Out_Prize[1][18465]=60---��Ѫ��_��
		Out_Prize[1][18470]=120---���Ƕ�_��
		Out_Prize[1][18475]=120---������_��
		Out_Prize[1][18480]=120---���ľ�_��
		Out_Prize[1][18485]=120---��Ӱ��_��
		Out_Prize[1][18490]=120---��Ȼ��_��
		Out_Prize[1][18495]=120---Ļ�춾_��
		Out_Prize[1][18500]=120---������_��
		Out_Prize[1][18510]=60---������_��
		Out_Prize[1][18520]=60---�����_��
		Out_Prize[1][18535]=120---�ٶ���_��
		Out_Prize[1][18540]=120---ŭ����_��
		Out_Prize[1][18545]=120---��ٻ�_��
		Out_Prize[1][18550]=120---������_��
		Out_Prize[1][18555]=60---���ӡ_��
		Out_Prize[1][18560]=60---�����_��
		Out_Prize[1][18565]=120---�ػ��_��
		Out_Prize[1][18570]=120---�͹�Х_��
		Out_Prize[1][18575]=60---������_��
		Out_Prize[1][18580]=15---аѪ��_��
		Out_Prize[1][18585]=120---�ٹ�_��
		Out_Prize[1][18595]=120---������_��
		Out_Prize[1][18600]=120---а���_��
		Out_Prize[1][18605]=120---Ӧ����_��
		Out_Prize[1][18610]=120---����ͨ_��
		Out_Prize[1][18615]=60---���嶾_��
		Out_Prize[1][18620]=120---��Ѫ��_��
		Out_Prize[1][18625]=120---�ɻ��_��
		Out_Prize[1][18635]=60---���۴�_��
		Out_Prize[1][18640]=120---������_��
		Out_Prize[1][18650]=15---����_��
		Out_Prize[1][18655]=60---��Ǭ��_��
	elseif id==18753 then
		Out_Prize[1][18461]=120---�����_ľ
		Out_Prize[1][18466]=60---��Ѫ��_ľ
		Out_Prize[1][18471]=120---���Ƕ�_ľ
		Out_Prize[1][18476]=120---������_ľ
		Out_Prize[1][18481]=120---���ľ�_ľ
		Out_Prize[1][18486]=120---��Ӱ��_ľ
		Out_Prize[1][18491]=120---��Ȼ��_ľ
		Out_Prize[1][18496]=120---Ļ�춾_ľ
		Out_Prize[1][18501]=120---������_ľ
		Out_Prize[1][18511]=60---������_ľ
		Out_Prize[1][18521]=60---�����_ľ
		Out_Prize[1][18536]=120---�ٶ���_ľ
		Out_Prize[1][18541]=120---ŭ����_ľ
		Out_Prize[1][18546]=120---��ٻ�_ľ
		Out_Prize[1][18551]=120---������_ľ
		Out_Prize[1][18556]=60---���ӡ_ľ
		Out_Prize[1][18561]=60---�����_ľ
		Out_Prize[1][18566]=120---�ػ��_ľ
		Out_Prize[1][18571]=120---�͹�Х_ľ
		Out_Prize[1][18576]=60---������_ľ
		Out_Prize[1][18581]=15---аѪ��_ľ
		Out_Prize[1][18586]=120---�ٹ�_ľ
		Out_Prize[1][18596]=120---������_ľ
		Out_Prize[1][18601]=120---а���_ľ
		Out_Prize[1][18606]=120---Ӧ����_ľ
		Out_Prize[1][18611]=120---����ͨ_ľ
		Out_Prize[1][18616]=60---���嶾_ľ
		Out_Prize[1][18621]=120---��Ѫ��_ľ
		Out_Prize[1][18626]=120---�ɻ��_ľ
		Out_Prize[1][18636]=60---���۴�_ľ
		Out_Prize[1][18641]=120---������_ľ
		Out_Prize[1][18651]=15---����_ľ
		Out_Prize[1][18656]=60---��Ǭ��_ľ
	elseif id==18754 then
		Out_Prize[1][18462]=120---�����_ˮ
		Out_Prize[1][18467]=60---��Ѫ��_ˮ
		Out_Prize[1][18472]=120---���Ƕ�_ˮ
		Out_Prize[1][18477]=120---������_ˮ
		Out_Prize[1][18482]=120---���ľ�_ˮ
		Out_Prize[1][18487]=120---��Ӱ��_ˮ
		Out_Prize[1][18492]=120---��Ȼ��_ˮ
		Out_Prize[1][18497]=120---Ļ�춾_ˮ
		Out_Prize[1][18502]=120---������_ˮ
		Out_Prize[1][18512]=60---������_ˮ
		Out_Prize[1][18522]=60---�����_ˮ
		Out_Prize[1][18537]=120---�ٶ���_ˮ
		Out_Prize[1][18542]=120---ŭ����_ˮ
		Out_Prize[1][18547]=120---��ٻ�_ˮ
		Out_Prize[1][18552]=120---������_ˮ
		Out_Prize[1][18557]=60---���ӡ_ˮ
		Out_Prize[1][18562]=60---�����_ˮ
		Out_Prize[1][18567]=120---�ػ��_ˮ
		Out_Prize[1][18572]=120---�͹�Х_ˮ
		Out_Prize[1][18577]=60---������_ˮ
		Out_Prize[1][18582]=15---аѪ��_ˮ
		Out_Prize[1][18587]=120---�ٹ�_ˮ
		Out_Prize[1][18597]=120---������_ˮ
		Out_Prize[1][18602]=120---а���_ˮ
		Out_Prize[1][18607]=120---Ӧ����_ˮ
		Out_Prize[1][18612]=120---����ͨ_ˮ
		Out_Prize[1][18617]=60---���嶾_ˮ
		Out_Prize[1][18622]=120---��Ѫ��_ˮ
		Out_Prize[1][18627]=120---�ɻ��_ˮ
		Out_Prize[1][18637]=60---���۴�_ˮ
		Out_Prize[1][18642]=120---������_ˮ
		Out_Prize[1][18652]=15---����_ˮ
		Out_Prize[1][18657]=60---��Ǭ��_ˮ
	elseif id==18755 then
		Out_Prize[1][18463]=120---�����_��
		Out_Prize[1][18468]=60---��Ѫ��_��
		Out_Prize[1][18473]=120---���Ƕ�_��
		Out_Prize[1][18478]=120---������_��
		Out_Prize[1][18483]=120---���ľ�_��
		Out_Prize[1][18488]=120---��Ӱ��_��
		Out_Prize[1][18493]=120---��Ȼ��_��
		Out_Prize[1][18498]=120---Ļ�춾_��
		Out_Prize[1][18503]=120---������_��
		Out_Prize[1][18513]=60---������_��
		Out_Prize[1][18523]=60---�����_��
		Out_Prize[1][18538]=120---�ٶ���_��
		Out_Prize[1][18543]=120---ŭ����_��
		Out_Prize[1][18548]=120---��ٻ�_��
		Out_Prize[1][18553]=120---������_��
		Out_Prize[1][18558]=60---���ӡ_��
		Out_Prize[1][18563]=60---�����_��
		Out_Prize[1][18568]=120---�ػ��_��
		Out_Prize[1][18573]=120---�͹�Х_��
		Out_Prize[1][18578]=60---������_��
		Out_Prize[1][18583]=15---аѪ��_��
		Out_Prize[1][18588]=120---�ٹ�_��
		Out_Prize[1][18598]=120---������_��
		Out_Prize[1][18603]=120---а���_��
		Out_Prize[1][18608]=120---Ӧ����_��
		Out_Prize[1][18613]=120---����ͨ_��
		Out_Prize[1][18618]=60---���嶾_��
		Out_Prize[1][18623]=120---��Ѫ��_��
		Out_Prize[1][18628]=120---�ɻ��_��
		Out_Prize[1][18638]=60---���۴�_��
		Out_Prize[1][18643]=120---������_��
		Out_Prize[1][18653]=15---����_��
		Out_Prize[1][18658]=60---��Ǭ��_��

	elseif id==18756 then 
		Out_Prize[1][18464]=120---�����_��
		Out_Prize[1][18469]=60---��Ѫ��_��
		Out_Prize[1][18474]=120---���Ƕ�_��
		Out_Prize[1][18479]=120---������_��
		Out_Prize[1][18484]=120---���ľ�_��
		Out_Prize[1][18489]=120---��Ӱ��_��
		Out_Prize[1][18494]=120---��Ȼ��_��
		Out_Prize[1][18499]=120---Ļ�춾_��
		Out_Prize[1][18504]=120---������_��
		Out_Prize[1][18514]=60---������_��
		Out_Prize[1][18524]=60---�����_��
		Out_Prize[1][18539]=120---�ٶ���_��
		Out_Prize[1][18544]=120---ŭ����_��
		Out_Prize[1][18549]=120---��ٻ�_��
		Out_Prize[1][18554]=120---������_��
		Out_Prize[1][18559]=60---���ӡ_��
		Out_Prize[1][18564]=60---�����_��
		Out_Prize[1][18569]=120---�ػ��_��
		Out_Prize[1][18574]=120---�͹�Х_��
		Out_Prize[1][18579]=60---������_��
		Out_Prize[1][18584]=15---аѪ��_��
		Out_Prize[1][18589]=120---�ٹ�_��
		Out_Prize[1][18599]=120---������_��
		Out_Prize[1][18604]=120---а���_��
		Out_Prize[1][18609]=120---Ӧ����_��
		Out_Prize[1][18614]=120---����ͨ_��
		Out_Prize[1][18619]=60---���嶾_��
		Out_Prize[1][18624]=120---��Ѫ��_��
		Out_Prize[1][18629]=120---�ɻ��_��
		Out_Prize[1][18639]=60---���۴�_��
		Out_Prize[1][18644]=120---������_��
		Out_Prize[1][18654]=15---����_��
		Out_Prize[1][18659]=60---��Ǭ��_��
			-- ���軤������
	elseif id==31494 then	-- �����
		Out_Prize[1][30477]=140
		Out_Prize[1][30478]=50
		Out_Prize[1][30479]=20
		Out_Prize[1][30480]=200
		Out_Prize[1][30481]=140
		Out_Prize[1][30482]=90
		Out_Prize[1][30483]=50
		Out_Prize[1][30484]=20
		Out_Prize[1][30485]=140
		Out_Prize[1][30486]=50
		Out_Prize[1][30487]=20
		Out_Prize[1][30491]=200
		Out_Prize[1][30492]=90
		Out_Prize[1][30493]=50
		Out_Prize[1][30494]=140
		Out_Prize[1][30495]=50
		Out_Prize[1][30496]=20
		Out_Prize[1][30497]=200
		Out_Prize[1][30498]=140
		Out_Prize[1][30499]=90
		Out_Prize[1][30500]=50
		Out_Prize[1][30501]=20
		Out_Prize[1][30502]=140
		Out_Prize[1][30503]=50
		Out_Prize[1][30504]=20
		Out_Prize[1][30511]=140
		Out_Prize[1][30512]=50
		Out_Prize[1][30513]=20
		Out_Prize[1][30514]=200
		Out_Prize[1][30515]=140
		Out_Prize[1][30516]=90
		Out_Prize[1][30517]=50
		Out_Prize[1][30518]=20

	elseif id==31495 then	-- ����ľ
		Out_Prize[1][30528]=140
		Out_Prize[1][30529]=50
		Out_Prize[1][30530]=20
		Out_Prize[1][30531]=200
		Out_Prize[1][30532]=140
		Out_Prize[1][30533]=90
		Out_Prize[1][30534]=50
		Out_Prize[1][30535]=20
		Out_Prize[1][30536]=140
		Out_Prize[1][30537]=50
		Out_Prize[1][30538]=20
		Out_Prize[1][30542]=200
		Out_Prize[1][30543]=90
		Out_Prize[1][30544]=50
		Out_Prize[1][30545]=140
		Out_Prize[1][30546]=50
		Out_Prize[1][30547]=20
		Out_Prize[1][30548]=200
		Out_Prize[1][30549]=140
		Out_Prize[1][30550]=90
		Out_Prize[1][30551]=50
		Out_Prize[1][30552]=20
		Out_Prize[1][30553]=140
		Out_Prize[1][30554]=50
		Out_Prize[1][30555]=20
		Out_Prize[1][30562]=140
		Out_Prize[1][30563]=50
		Out_Prize[1][30564]=20
		Out_Prize[1][30565]=200
		Out_Prize[1][30566]=140
		Out_Prize[1][30567]=90
		Out_Prize[1][30568]=50
		Out_Prize[1][30569]=20

	elseif id==31496 then	-- ����ˮ
		Out_Prize[1][30579]=140
		Out_Prize[1][30580]=50
		Out_Prize[1][30581]=20
		Out_Prize[1][30582]=200
		Out_Prize[1][30583]=140
		Out_Prize[1][30584]=90
		Out_Prize[1][30585]=50
		Out_Prize[1][30586]=20
		Out_Prize[1][30587]=140
		Out_Prize[1][30588]=50
		Out_Prize[1][30589]=20
		Out_Prize[1][30593]=200
		Out_Prize[1][30594]=90
		Out_Prize[1][30595]=50
		Out_Prize[1][30596]=140
		Out_Prize[1][30597]=50
		Out_Prize[1][30598]=20
		Out_Prize[1][30599]=200
		Out_Prize[1][30600]=140
		Out_Prize[1][30601]=90
		Out_Prize[1][30602]=50
		Out_Prize[1][30603]=20
		Out_Prize[1][30604]=140
		Out_Prize[1][30605]=50
		Out_Prize[1][30606]=20
		Out_Prize[1][30613]=140
		Out_Prize[1][30614]=50
		Out_Prize[1][30615]=20
		Out_Prize[1][30616]=200
		Out_Prize[1][30617]=140
		Out_Prize[1][30618]=90
		Out_Prize[1][30619]=50
		Out_Prize[1][30620]=20

	elseif id==31493 then	-- �����
		Out_Prize[1][30630]=140
		Out_Prize[1][30631]=50
		Out_Prize[1][30632]=20
		Out_Prize[1][30633]=200
		Out_Prize[1][30634]=140
		Out_Prize[1][30635]=90
		Out_Prize[1][30636]=50
		Out_Prize[1][30637]=20
		Out_Prize[1][30638]=140
		Out_Prize[1][30639]=50
		Out_Prize[1][30640]=20
		Out_Prize[1][30644]=200
		Out_Prize[1][30645]=90
		Out_Prize[1][30646]=50
		Out_Prize[1][30647]=140
		Out_Prize[1][30648]=50
		Out_Prize[1][30649]=20
		Out_Prize[1][30650]=200
		Out_Prize[1][30651]=140
		Out_Prize[1][30652]=90
		Out_Prize[1][30653]=50
		Out_Prize[1][30654]=20
		Out_Prize[1][30655]=140
		Out_Prize[1][30656]=50
		Out_Prize[1][30657]=20
		Out_Prize[1][30664]=140
		Out_Prize[1][30665]=50
		Out_Prize[1][30666]=20
		Out_Prize[1][30667]=200
		Out_Prize[1][30668]=140
		Out_Prize[1][30669]=90
		Out_Prize[1][30670]=50
		Out_Prize[1][30671]=20

	elseif id==31497 then	-- ������
		Out_Prize[1][30681]=140
		Out_Prize[1][30682]=50
		Out_Prize[1][30683]=20
		Out_Prize[1][30684]=200
		Out_Prize[1][30685]=140
		Out_Prize[1][30686]=90
		Out_Prize[1][30687]=50
		Out_Prize[1][30688]=20
		Out_Prize[1][30689]=140
		Out_Prize[1][30690]=50
		Out_Prize[1][30691]=20
		Out_Prize[1][30695]=200
		Out_Prize[1][30696]=90
		Out_Prize[1][30697]=50
		Out_Prize[1][30698]=140
		Out_Prize[1][30699]=50
		Out_Prize[1][30700]=20
		Out_Prize[1][30701]=200
		Out_Prize[1][30702]=140
		Out_Prize[1][30703]=90
		Out_Prize[1][30704]=50
		Out_Prize[1][30705]=20
		Out_Prize[1][30706]=140
		Out_Prize[1][30707]=50
		Out_Prize[1][30708]=20
		Out_Prize[1][30715]=140
		Out_Prize[1][30716]=50
		Out_Prize[1][30717]=20
		Out_Prize[1][30718]=200
		Out_Prize[1][30719]=140
		Out_Prize[1][30720]=90
		Out_Prize[1][30721]=50
		Out_Prize[1][30722]=20

	-- ��ɽ��������
	elseif id==31499 then	-- ��ɽ��
		Out_Prize[1][30731]=200
		Out_Prize[1][30732]=140
		Out_Prize[1][30733]=90
		Out_Prize[1][30734]=50
		Out_Prize[1][30736]=200
		Out_Prize[1][30737]=140
		Out_Prize[1][30738]=90
		Out_Prize[1][30740]=20
		Out_Prize[1][30747]=140
		Out_Prize[1][30748]=200
		Out_Prize[1][30749]=140
		Out_Prize[1][30750]=90
		Out_Prize[1][30751]=50
		Out_Prize[1][30995]=20
		Out_Prize[1][30753]=200
		Out_Prize[1][30754]=140
		Out_Prize[1][30755]=90
		Out_Prize[1][30756]=50
		Out_Prize[1][30759]=140
		Out_Prize[1][30760]=200
		Out_Prize[1][30761]=140
		Out_Prize[1][30762]=90
		Out_Prize[1][30763]=50
		Out_Prize[1][30764]=20
		Out_Prize[1][30771]=200
		Out_Prize[1][30772]=140
		Out_Prize[1][30773]=90
		Out_Prize[1][30774]=50
		Out_Prize[1][30775]=20
		Out_Prize[1][30778]=200
		Out_Prize[1][30779]=140
		Out_Prize[1][30780]=90
		Out_Prize[1][30781]=50

	elseif id==31500 then	-- ��ɽľ
		Out_Prize[1][30784]=200
		Out_Prize[1][30785]=140
		Out_Prize[1][30786]=90
		Out_Prize[1][30787]=50
		Out_Prize[1][30789]=200
		Out_Prize[1][30790]=140
		Out_Prize[1][30791]=90
		Out_Prize[1][30793]=20
		Out_Prize[1][30800]=140
		Out_Prize[1][30801]=200
		Out_Prize[1][30802]=140
		Out_Prize[1][30803]=90
		Out_Prize[1][30804]=50
		Out_Prize[1][30805]=20
		Out_Prize[1][30806]=200
		Out_Prize[1][30807]=140
		Out_Prize[1][30808]=90
		Out_Prize[1][30809]=50
		Out_Prize[1][30811]=140
		Out_Prize[1][30812]=200
		Out_Prize[1][30813]=140
		Out_Prize[1][30814]=90
		Out_Prize[1][30815]=50
		Out_Prize[1][30816]=20
		Out_Prize[1][30823]=200
		Out_Prize[1][30824]=140
		Out_Prize[1][30825]=90
		Out_Prize[1][30826]=50
		Out_Prize[1][30827]=20
		Out_Prize[1][30829]=200
		Out_Prize[1][30830]=140
		Out_Prize[1][30831]=90
		Out_Prize[1][30832]=50

	elseif id==31501 then	-- ��ɽˮ
		Out_Prize[1][30835]=200
		Out_Prize[1][30836]=140
		Out_Prize[1][30837]=90
		Out_Prize[1][30838]=50
		Out_Prize[1][30840]=200
		Out_Prize[1][30841]=140
		Out_Prize[1][30842]=90
		Out_Prize[1][30844]=20
		Out_Prize[1][30851]=140
		Out_Prize[1][30852]=200
		Out_Prize[1][30853]=140
		Out_Prize[1][30854]=90
		Out_Prize[1][30855]=50
		Out_Prize[1][30856]=20
		Out_Prize[1][30857]=200
		Out_Prize[1][30858]=140
		Out_Prize[1][30859]=90
		Out_Prize[1][30860]=50
		Out_Prize[1][30862]=140
		Out_Prize[1][30863]=200
		Out_Prize[1][30864]=140
		Out_Prize[1][30865]=90
		Out_Prize[1][30866]=50
		Out_Prize[1][30867]=20
		Out_Prize[1][30874]=200
		Out_Prize[1][30875]=140
		Out_Prize[1][30876]=90
		Out_Prize[1][30877]=50
		Out_Prize[1][30878]=20
		Out_Prize[1][30880]=200
		Out_Prize[1][30881]=140
		Out_Prize[1][30882]=90
		Out_Prize[1][30883]=50

	elseif id==31498 then	-- ��ɽ��
		Out_Prize[1][30886]=200
		Out_Prize[1][30887]=140
		Out_Prize[1][30888]=90
		Out_Prize[1][30889]=50
		Out_Prize[1][30891]=200
		Out_Prize[1][30892]=140
		Out_Prize[1][30893]=90
		Out_Prize[1][30895]=20
		Out_Prize[1][30902]=140
		Out_Prize[1][30903]=200
		Out_Prize[1][30904]=140
		Out_Prize[1][30905]=90
		Out_Prize[1][30906]=50
		Out_Prize[1][30907]=20
		Out_Prize[1][30908]=200
		Out_Prize[1][30909]=140
		Out_Prize[1][30910]=90
		Out_Prize[1][30911]=50
		Out_Prize[1][30913]=140
		Out_Prize[1][30914]=200
		Out_Prize[1][30915]=140
		Out_Prize[1][30916]=90
		Out_Prize[1][30917]=50
		Out_Prize[1][30918]=20
		Out_Prize[1][30925]=200
		Out_Prize[1][30926]=140
		Out_Prize[1][30927]=90
		Out_Prize[1][30928]=50
		Out_Prize[1][30929]=20
		Out_Prize[1][30931]=200
		Out_Prize[1][30932]=140
		Out_Prize[1][30933]=90
		Out_Prize[1][30934]=50

	elseif id==31502 then	-- ��ɽ��
		Out_Prize[1][30938]=200
		Out_Prize[1][30939]=140
		Out_Prize[1][30940]=90
		Out_Prize[1][30941]=50
		Out_Prize[1][30943]=200
		Out_Prize[1][30944]=140
		Out_Prize[1][30945]=90
		Out_Prize[1][30947]=20
		Out_Prize[1][30954]=140
		Out_Prize[1][30955]=200
		Out_Prize[1][30956]=140
		Out_Prize[1][30957]=90
		Out_Prize[1][30958]=50
		Out_Prize[1][30959]=20
		Out_Prize[1][30960]=200
		Out_Prize[1][30961]=140
		Out_Prize[1][30962]=90
		Out_Prize[1][30963]=50
		Out_Prize[1][30965]=140
		Out_Prize[1][30966]=200
		Out_Prize[1][30967]=140
		Out_Prize[1][30968]=90
		Out_Prize[1][30969]=50
		Out_Prize[1][30970]=20
		Out_Prize[1][30977]=200
		Out_Prize[1][30978]=140
		Out_Prize[1][30979]=90
		Out_Prize[1][30980]=50
		Out_Prize[1][30981]=20
		Out_Prize[1][30983]=200
		Out_Prize[1][30984]=140
		Out_Prize[1][30985]=90
		Out_Prize[1][30986]=50

	elseif id==40357 then	-- ������
		Out_Prize[1][38737]=200
		Out_Prize[1][38754]=200
		Out_Prize[1][38743]=200
		Out_Prize[1][38766]=200
		Out_Prize[1][38748]=200
		Out_Prize[1][38759]=200
		Out_Prize[1][38783]=200
		Out_Prize[1][38738]=140
		Out_Prize[1][38755]=140
		Out_Prize[1][38777]=140
		Out_Prize[1][38744]=140
		Out_Prize[1][38767]=140
		Out_Prize[1][38749]=140
		Out_Prize[1][38760]=140
		Out_Prize[1][38784]=140
		Out_Prize[1][38739]=90
		Out_Prize[1][38756]=90
		Out_Prize[1][38745]=90
		Out_Prize[1][38768]=90
		Out_Prize[1][38750]=90
		Out_Prize[1][38761]=90
		Out_Prize[1][38785]=90
		Out_Prize[1][38740]=50
		Out_Prize[1][38757]=50
		Out_Prize[1][38779]=50
		Out_Prize[1][38746]=50
		Out_Prize[1][38769]=50
		Out_Prize[1][38751]=50
		Out_Prize[1][38762]=50
		Out_Prize[1][38786]=50
		Out_Prize[1][38741]=20
		Out_Prize[1][38763]=20
		Out_Prize[1][38752]=20

	elseif id==40358 then	-- ����ľ
		Out_Prize[1][38431]=200
		Out_Prize[1][38448]=200
		Out_Prize[1][38437]=200
		Out_Prize[1][38460]=200
		Out_Prize[1][38442]=200
		Out_Prize[1][38453]=200
		Out_Prize[1][38477]=200
		Out_Prize[1][38432]=140
		Out_Prize[1][38449]=140
		Out_Prize[1][38471]=140
		Out_Prize[1][38438]=140
		Out_Prize[1][38461]=140
		Out_Prize[1][38443]=140
		Out_Prize[1][38454]=140
		Out_Prize[1][38478]=140
		Out_Prize[1][38433]=90
		Out_Prize[1][38450]=90
		Out_Prize[1][38439]=90
		Out_Prize[1][38462]=90
		Out_Prize[1][38444]=90
		Out_Prize[1][38455]=90
		Out_Prize[1][38479]=90
		Out_Prize[1][38434]=50
		Out_Prize[1][38451]=50
		Out_Prize[1][38473]=50
		Out_Prize[1][38440]=50
		Out_Prize[1][38463]=50
		Out_Prize[1][38445]=50
		Out_Prize[1][38456]=50
		Out_Prize[1][38480]=50
		Out_Prize[1][38435]=20
		Out_Prize[1][38457]=20
		Out_Prize[1][38446]=20

	elseif id==40359 then	-- ����ˮ
		Out_Prize[1][38533]=200
		Out_Prize[1][38550]=200
		Out_Prize[1][38539]=200
		Out_Prize[1][38562]=200
		Out_Prize[1][38544]=200
		Out_Prize[1][38555]=200
		Out_Prize[1][38579]=200
		Out_Prize[1][38534]=140
		Out_Prize[1][38551]=140
		Out_Prize[1][38573]=140
		Out_Prize[1][38540]=140
		Out_Prize[1][38563]=140
		Out_Prize[1][38545]=140
		Out_Prize[1][38556]=140
		Out_Prize[1][38580]=140
		Out_Prize[1][38535]=90
		Out_Prize[1][38552]=90
		Out_Prize[1][38541]=90
		Out_Prize[1][38564]=90
		Out_Prize[1][38546]=90
		Out_Prize[1][38557]=90
		Out_Prize[1][38581]=90
		Out_Prize[1][38536]=50
		Out_Prize[1][38553]=50
		Out_Prize[1][38575]=50
		Out_Prize[1][38542]=50
		Out_Prize[1][38565]=50
		Out_Prize[1][38547]=50
		Out_Prize[1][38558]=50
		Out_Prize[1][38582]=50
		Out_Prize[1][38537]=20
		Out_Prize[1][38559]=20
		Out_Prize[1][38548]=20

	elseif id==40360 then	-- �����
		Out_Prize[1][38635]=200
		Out_Prize[1][38652]=200
		Out_Prize[1][38641]=200
		Out_Prize[1][38664]=200
		Out_Prize[1][38646]=200
		Out_Prize[1][38657]=200
		Out_Prize[1][38681]=200
		Out_Prize[1][38636]=140
		Out_Prize[1][38653]=140
		Out_Prize[1][38675]=140
		Out_Prize[1][38642]=140
		Out_Prize[1][38665]=140
		Out_Prize[1][38647]=140
		Out_Prize[1][38658]=140
		Out_Prize[1][38682]=140
		Out_Prize[1][38637]=90
		Out_Prize[1][38654]=90
		Out_Prize[1][38643]=90
		Out_Prize[1][38666]=90
		Out_Prize[1][38648]=90
		Out_Prize[1][38659]=90
		Out_Prize[1][38683]=90
		Out_Prize[1][38638]=50
		Out_Prize[1][38655]=50
		Out_Prize[1][38677]=50
		Out_Prize[1][38644]=50
		Out_Prize[1][38667]=50
		Out_Prize[1][38649]=50
		Out_Prize[1][38660]=50
		Out_Prize[1][38684]=50
		Out_Prize[1][38639]=20
		Out_Prize[1][38661]=20
		Out_Prize[1][38650]=20

	elseif id==40361 then	-- �����
		Out_Prize[1][38839]=200
		Out_Prize[1][38346]=200
		Out_Prize[1][38335]=200
		Out_Prize[1][38358]=200
		Out_Prize[1][38340]=200
		Out_Prize[1][38351]=200
		Out_Prize[1][38375]=200
		Out_Prize[1][38840]=140
		Out_Prize[1][38347]=140
		Out_Prize[1][38369]=140
		Out_Prize[1][38336]=140
		Out_Prize[1][38359]=140
		Out_Prize[1][38341]=140
		Out_Prize[1][38352]=140
		Out_Prize[1][38376]=140
		Out_Prize[1][38331]=90
		Out_Prize[1][38348]=90
		Out_Prize[1][38337]=90
		Out_Prize[1][38360]=90
		Out_Prize[1][38342]=90
		Out_Prize[1][38353]=90
		Out_Prize[1][38377]=90
		Out_Prize[1][38332]=50
		Out_Prize[1][38349]=50
		Out_Prize[1][38371]=50
		Out_Prize[1][38338]=50
		Out_Prize[1][38361]=50
		Out_Prize[1][38343]=50
		Out_Prize[1][38354]=50
		Out_Prize[1][38378]=50
		Out_Prize[1][38333]=20
		Out_Prize[1][38355]=20
		Out_Prize[1][38344]=20

	elseif id==40362 then	-- �컪��
		Out_Prize[1][38812]=200
		Out_Prize[1][38809]=200
		Out_Prize[1][38822]=200
		Out_Prize[1][38792]=200
		Out_Prize[1][38788]=200
		Out_Prize[1][38789]=140
		Out_Prize[1][38798]=200
		Out_Prize[1][38832]=200
		Out_Prize[1][38833]=140
		Out_Prize[1][38813]=140
		Out_Prize[1][38793]=140
		Out_Prize[1][38805]=140
		Out_Prize[1][38823]=140
		Out_Prize[1][38815]=200
		Out_Prize[1][38829]=200
		Out_Prize[1][38795]=200
		Out_Prize[1][38826]=200
		Out_Prize[1][38810]=90
		Out_Prize[1][38814]=90
		Out_Prize[1][38824]=90
		Out_Prize[1][38799]=140
		Out_Prize[1][38830]=140
		Out_Prize[1][38816]=140
		Out_Prize[1][38796]=140
		Out_Prize[1][38819]=50
		Out_Prize[1][38827]=140
		Out_Prize[1][38791]=50
		Out_Prize[1][38806]=50
		Out_Prize[1][38825]=50
		Out_Prize[1][38803]=50
		Out_Prize[1][38835]=20
		Out_Prize[1][38804]=50
		Out_Prize[1][38808]=50

	elseif id==40363 then	-- �컪ľ
		Out_Prize[1][38506]=200
		Out_Prize[1][38503]=200
		Out_Prize[1][38516]=200
		Out_Prize[1][38486]=200
		Out_Prize[1][38482]=200
		Out_Prize[1][38483]=140
		Out_Prize[1][38492]=200
		Out_Prize[1][38526]=200
		Out_Prize[1][38527]=140
		Out_Prize[1][38507]=140
		Out_Prize[1][38487]=140
		Out_Prize[1][38499]=140
		Out_Prize[1][38517]=140
		Out_Prize[1][38509]=200
		Out_Prize[1][38523]=200
		Out_Prize[1][38489]=200
		Out_Prize[1][38520]=200
		Out_Prize[1][38504]=90
		Out_Prize[1][38508]=90
		Out_Prize[1][38518]=90
		Out_Prize[1][38493]=140
		Out_Prize[1][38524]=140
		Out_Prize[1][38510]=140
		Out_Prize[1][38490]=140
		Out_Prize[1][38513]=50
		Out_Prize[1][38521]=140
		Out_Prize[1][38485]=50
		Out_Prize[1][38500]=50
		Out_Prize[1][38519]=50
		Out_Prize[1][38497]=50
		Out_Prize[1][38529]=20
		Out_Prize[1][38498]=50
		Out_Prize[1][38502]=50

	elseif id==40364 then	-- �컪ˮ
		Out_Prize[1][38608]=200
		Out_Prize[1][38605]=200
		Out_Prize[1][38618]=200
		Out_Prize[1][38588]=200
		Out_Prize[1][38584]=200
		Out_Prize[1][38585]=140
		Out_Prize[1][38594]=200
		Out_Prize[1][38628]=200
		Out_Prize[1][38629]=140
		Out_Prize[1][38609]=140
		Out_Prize[1][38589]=140
		Out_Prize[1][38601]=140
		Out_Prize[1][38619]=140
		Out_Prize[1][38611]=200
		Out_Prize[1][38625]=200
		Out_Prize[1][38591]=200
		Out_Prize[1][38622]=200
		Out_Prize[1][38606]=90
		Out_Prize[1][38610]=90
		Out_Prize[1][38620]=90
		Out_Prize[1][38595]=140
		Out_Prize[1][38626]=140
		Out_Prize[1][38612]=140
		Out_Prize[1][38592]=140
		Out_Prize[1][38615]=50
		Out_Prize[1][38623]=140
		Out_Prize[1][38587]=50
		Out_Prize[1][38602]=50
		Out_Prize[1][38621]=50
		Out_Prize[1][38599]=50
		Out_Prize[1][38631]=20
		Out_Prize[1][38600]=50
		Out_Prize[1][38604]=50

	elseif id==40365 then	-- �컪��
		Out_Prize[1][38710]=200
		Out_Prize[1][38707]=200
		Out_Prize[1][38720]=200
		Out_Prize[1][38690]=200
		Out_Prize[1][38686]=200
		Out_Prize[1][38687]=140
		Out_Prize[1][38696]=200
		Out_Prize[1][38730]=200
		Out_Prize[1][38731]=140
		Out_Prize[1][38711]=140
		Out_Prize[1][38691]=140
		Out_Prize[1][38703]=140
		Out_Prize[1][38721]=140
		Out_Prize[1][38713]=200
		Out_Prize[1][38727]=200
		Out_Prize[1][38693]=200
		Out_Prize[1][38724]=200
		Out_Prize[1][38708]=90
		Out_Prize[1][38712]=90
		Out_Prize[1][38722]=90
		Out_Prize[1][38697]=140
		Out_Prize[1][38728]=140
		Out_Prize[1][38714]=140
		Out_Prize[1][38694]=140
		Out_Prize[1][38717]=50
		Out_Prize[1][38725]=140
		Out_Prize[1][38689]=50
		Out_Prize[1][38704]=50
		Out_Prize[1][38723]=50
		Out_Prize[1][38701]=50
		Out_Prize[1][38733]=20
		Out_Prize[1][38702]=50
		Out_Prize[1][38706]=50

	elseif id==40366 then	-- �컪��
		Out_Prize[1][38404]=200
		Out_Prize[1][38401]=200
		Out_Prize[1][38414]=200
		Out_Prize[1][38384]=200
		Out_Prize[1][38380]=200
		Out_Prize[1][38381]=140
		Out_Prize[1][38390]=200
		Out_Prize[1][38424]=200
		Out_Prize[1][38425]=140
		Out_Prize[1][38405]=140
		Out_Prize[1][38385]=140
		Out_Prize[1][38397]=140
		Out_Prize[1][38415]=140
		Out_Prize[1][38407]=200
		Out_Prize[1][38421]=200
		Out_Prize[1][38387]=200
		Out_Prize[1][38418]=200
		Out_Prize[1][38402]=90
		Out_Prize[1][38406]=90
		Out_Prize[1][38416]=90
		Out_Prize[1][38391]=140
		Out_Prize[1][38422]=140
		Out_Prize[1][38408]=140
		Out_Prize[1][38388]=140
		Out_Prize[1][38411]=50
		Out_Prize[1][38419]=140
		Out_Prize[1][38383]=50
		Out_Prize[1][38398]=50
		Out_Prize[1][38417]=50
		Out_Prize[1][38395]=50
		Out_Prize[1][38427]=20
		Out_Prize[1][38396]=50
		Out_Prize[1][38400]=50		
		
		elseif id==50615 then  --̫껽�
		Out_Prize[1][49620]=90
		Out_Prize[1][49624]=200
		Out_Prize[1][49662]=150
		Out_Prize[1][49621]=200
		Out_Prize[1][49632]=150
		Out_Prize[1][49645]=200
		Out_Prize[1][49649]=90
		Out_Prize[1][49625]=150
		Out_Prize[1][49628]=150
		Out_Prize[1][49650]=120
		Out_Prize[1][49654]=120
		Out_Prize[1][49657]=120
		Out_Prize[1][49646]=150
		Out_Prize[1][49663]=120
		Out_Prize[1][49617]=200
		Out_Prize[1][49622]=150
		Out_Prize[1][49633]=50
		Out_Prize[1][49630]=120
		Out_Prize[1][49634]=50
		Out_Prize[1][49637]=120
		Out_Prize[1][49651]=90
		Out_Prize[1][49655]=90
		Out_Prize[1][49618]=20
		Out_Prize[1][49623]=50
		Out_Prize[1][49631]=50
		Out_Prize[1][49638]=120
		Out_Prize[1][49648]=20
		Out_Prize[1][49656]=90
		Out_Prize[1][49660]=50
		Out_Prize[1][49635]=90
		Out_Prize[1][49639]=90
		Out_Prize[1][49640]=50
		Out_Prize[1][49661]=90
		
	elseif id==50616 then  --̫�ľ
		Out_Prize[1][49671]=90
		Out_Prize[1][49675]=200
		Out_Prize[1][49713]=150
		Out_Prize[1][49672]=200
		Out_Prize[1][49683]=150
		Out_Prize[1][49696]=200
		Out_Prize[1][49700]=90
		Out_Prize[1][49676]=150
		Out_Prize[1][49679]=150
		Out_Prize[1][49701]=120
		Out_Prize[1][49705]=120
		Out_Prize[1][49708]=120
		Out_Prize[1][49697]=150
		Out_Prize[1][49714]=120
		Out_Prize[1][49668]=200
		Out_Prize[1][49673]=150
		Out_Prize[1][49684]=50
		Out_Prize[1][49681]=120
		Out_Prize[1][49685]=50
		Out_Prize[1][49688]=120
		Out_Prize[1][49702]=90
		Out_Prize[1][49706]=90
		Out_Prize[1][49669]=20
		Out_Prize[1][49674]=50
		Out_Prize[1][49682]=50
		Out_Prize[1][49689]=120
		Out_Prize[1][49699]=20
		Out_Prize[1][49707]=90
		Out_Prize[1][49711]=50
		Out_Prize[1][49686]=90
		Out_Prize[1][49690]=90
		Out_Prize[1][49691]=50
		Out_Prize[1][49712]=90
	
	elseif id==50617 then  --̫�ˮ
		Out_Prize[1][49722]=90
		Out_Prize[1][49726]=200
		Out_Prize[1][49764]=150
		Out_Prize[1][49723]=200
		Out_Prize[1][49734]=150
		Out_Prize[1][49747]=200
		Out_Prize[1][49751]=90
		Out_Prize[1][49727]=150
		Out_Prize[1][49730]=150
		Out_Prize[1][49752]=120
		Out_Prize[1][49756]=120
		Out_Prize[1][49759]=120
		Out_Prize[1][49748]=150
		Out_Prize[1][49765]=120
		Out_Prize[1][49719]=200
		Out_Prize[1][49724]=150
		Out_Prize[1][49735]=50
		Out_Prize[1][49732]=120
		Out_Prize[1][49736]=50
		Out_Prize[1][49739]=120
		Out_Prize[1][49753]=90
		Out_Prize[1][49757]=90
		Out_Prize[1][49720]=20
		Out_Prize[1][49725]=50
		Out_Prize[1][49733]=50
		Out_Prize[1][49740]=120
		Out_Prize[1][49750]=20
		Out_Prize[1][49758]=90
		Out_Prize[1][49762]=50
		Out_Prize[1][49737]=90
		Out_Prize[1][49741]=90
		Out_Prize[1][49742]=50
		Out_Prize[1][49763]=90
		
	elseif id==50618 then  --̫껻�
		Out_Prize[1][49773]=90
		Out_Prize[1][49777]=200
		Out_Prize[1][49815]=150
		Out_Prize[1][49774]=200
		Out_Prize[1][49785]=150
		Out_Prize[1][49798]=200
		Out_Prize[1][49802]=90
		Out_Prize[1][49778]=150
		Out_Prize[1][49781]=150
		Out_Prize[1][49803]=120
		Out_Prize[1][49807]=120
		Out_Prize[1][49810]=120
		Out_Prize[1][49799]=150
		Out_Prize[1][49816]=120
		Out_Prize[1][49770]=200
		Out_Prize[1][49775]=150
		Out_Prize[1][49786]=50
		Out_Prize[1][49783]=120
		Out_Prize[1][49787]=50
		Out_Prize[1][49790]=120
		Out_Prize[1][49804]=90
		Out_Prize[1][49808]=90
		Out_Prize[1][49771]=20
		Out_Prize[1][49776]=50
		Out_Prize[1][49784]=50
		Out_Prize[1][49791]=120
		Out_Prize[1][49801]=20
		Out_Prize[1][49809]=90
		Out_Prize[1][49813]=50
		Out_Prize[1][49788]=90
		Out_Prize[1][49792]=90
		Out_Prize[1][49793]=50
		Out_Prize[1][49814]=90
		
	elseif id==50619 then  --̫���
		Out_Prize[1][49824]=90
		Out_Prize[1][49828]=200
		Out_Prize[1][49866]=150
		Out_Prize[1][49825]=200
		Out_Prize[1][49836]=150
		Out_Prize[1][49849]=200
		Out_Prize[1][49853]=90
		Out_Prize[1][49829]=150
		Out_Prize[1][49832]=150
		Out_Prize[1][49854]=120
		Out_Prize[1][49858]=120
		Out_Prize[1][49861]=120
		Out_Prize[1][49850]=150
		Out_Prize[1][49867]=120
		Out_Prize[1][49821]=200
		Out_Prize[1][49826]=150
		Out_Prize[1][49837]=50
		Out_Prize[1][49834]=120
		Out_Prize[1][49838]=50
		Out_Prize[1][49841]=120
		Out_Prize[1][49855]=90
		Out_Prize[1][49859]=90
		Out_Prize[1][49822]=20
		Out_Prize[1][49827]=50
		Out_Prize[1][49835]=50
		Out_Prize[1][49842]=120
		Out_Prize[1][49852]=20
		Out_Prize[1][49860]=90
		Out_Prize[1][49864]=50
		Out_Prize[1][49839]=90
		Out_Prize[1][49843]=90
		Out_Prize[1][49844]=50
		Out_Prize[1][49865]=90

	elseif id==50610 then  --�����
		Out_Prize[1][49873]=220
		Out_Prize[1][49876]=220
		Out_Prize[1][49874]=220
		Out_Prize[1][49890]=220
		Out_Prize[1][49895]=30
		Out_Prize[1][49888]=110
		Out_Prize[1][49906]=110
		Out_Prize[1][49905]=20
		Out_Prize[1][49904]=40
		Out_Prize[1][49871]=10
		Out_Prize[1][49886]=10
		Out_Prize[1][49900]=40
		Out_Prize[1][49903]=10
		Out_Prize[1][49907]=50
		Out_Prize[1][49920]=10
		Out_Prize[1][49878]=20
		Out_Prize[1][49881]=20
		Out_Prize[1][49879]=110
		Out_Prize[1][49880]=50
		Out_Prize[1][49882]=30
		Out_Prize[1][49883]=10
		Out_Prize[1][49892]=40
		Out_Prize[1][49896]=30
		Out_Prize[1][49887]=20
		Out_Prize[1][49891]=50
		Out_Prize[1][49897]=20
		Out_Prize[1][49899]=30
		Out_Prize[1][49909]=110
		Out_Prize[1][49910]=110
		Out_Prize[1][49912]=40
		Out_Prize[1][49916]=30
		Out_Prize[1][49915]=50
		Out_Prize[1][49917]=10
	
	elseif id==50611 then  --����ľ
		Out_Prize[1][49924]=220
		Out_Prize[1][49927]=220
		Out_Prize[1][49925]=220
		Out_Prize[1][49941]=220
		Out_Prize[1][49946]=30
		Out_Prize[1][49939]=110
		Out_Prize[1][49957]=110
		Out_Prize[1][49956]=20
		Out_Prize[1][49955]=40
		Out_Prize[1][49922]=10
		Out_Prize[1][49937]=10
		Out_Prize[1][49951]=40
		Out_Prize[1][49954]=10
		Out_Prize[1][49958]=50
		Out_Prize[1][49971]=10
		Out_Prize[1][49929]=20
		Out_Prize[1][49932]=20
		Out_Prize[1][49930]=110
		Out_Prize[1][49931]=50
		Out_Prize[1][49933]=30
		Out_Prize[1][49934]=10
		Out_Prize[1][49943]=40
		Out_Prize[1][49947]=30
		Out_Prize[1][49938]=20
		Out_Prize[1][49942]=50
		Out_Prize[1][49948]=20
		Out_Prize[1][49950]=30
		Out_Prize[1][49960]=110
		Out_Prize[1][49961]=110
		Out_Prize[1][49963]=40
		Out_Prize[1][49967]=30
		Out_Prize[1][49966]=50
		Out_Prize[1][49968]=10

	elseif id==50612 then  --����ˮ
		Out_Prize[1][49975]=220
		Out_Prize[1][49978]=220
		Out_Prize[1][49976]=220
		Out_Prize[1][49992]=220
		Out_Prize[1][49997]=30
		Out_Prize[1][49990]=110
		Out_Prize[1][50008]=110
		Out_Prize[1][50007]=20
		Out_Prize[1][50006]=40
		Out_Prize[1][49973]=10
		Out_Prize[1][49988]=10
		Out_Prize[1][50002]=40
		Out_Prize[1][50005]=10
		Out_Prize[1][50009]=50
		Out_Prize[1][50022]=10
		Out_Prize[1][49980]=20
		Out_Prize[1][49983]=20
		Out_Prize[1][49981]=110
		Out_Prize[1][49982]=50
		Out_Prize[1][49984]=30
		Out_Prize[1][49985]=10
		Out_Prize[1][49994]=40
		Out_Prize[1][49998]=30
		Out_Prize[1][49989]=20
		Out_Prize[1][49993]=50
		Out_Prize[1][49999]=20
		Out_Prize[1][50001]=30
		Out_Prize[1][50011]=110
		Out_Prize[1][50012]=110
		Out_Prize[1][50014]=40
		Out_Prize[1][50018]=30
		Out_Prize[1][50017]=50
		Out_Prize[1][50019]=10	
	
	elseif id==50613 then  --�����
		Out_Prize[1][50026]=220
		Out_Prize[1][50029]=220
		Out_Prize[1][50027]=220
		Out_Prize[1][50043]=220
		Out_Prize[1][50048]=30
		Out_Prize[1][50041]=110
		Out_Prize[1][50059]=110
		Out_Prize[1][50058]=20
		Out_Prize[1][50057]=40
		Out_Prize[1][50024]=10
		Out_Prize[1][50039]=10
		Out_Prize[1][50053]=40
		Out_Prize[1][50056]=10
		Out_Prize[1][50060]=50
		Out_Prize[1][50073]=10
		Out_Prize[1][50031]=20
		Out_Prize[1][50034]=20
		Out_Prize[1][50032]=110
		Out_Prize[1][50033]=50
		Out_Prize[1][50035]=30
		Out_Prize[1][50036]=10
		Out_Prize[1][50045]=40
		Out_Prize[1][50049]=30
		Out_Prize[1][50040]=20
		Out_Prize[1][50044]=50
		Out_Prize[1][50050]=20
		Out_Prize[1][50052]=30
		Out_Prize[1][50062]=110
		Out_Prize[1][50063]=110
		Out_Prize[1][50065]=40
		Out_Prize[1][50069]=30
		Out_Prize[1][50068]=50
		Out_Prize[1][50070]=10

	elseif id==50614 then  --������
		Out_Prize[1][50077]=220
		Out_Prize[1][50080]=220
		Out_Prize[1][50078]=220
		Out_Prize[1][50094]=220
		Out_Prize[1][50099]=30
		Out_Prize[1][50092]=110
		Out_Prize[1][50110]=110
		Out_Prize[1][50109]=20
		Out_Prize[1][50108]=40
		Out_Prize[1][50075]=10
		Out_Prize[1][50090]=10
		Out_Prize[1][50104]=40
		Out_Prize[1][50107]=10
		Out_Prize[1][50111]=50
		Out_Prize[1][50124]=10
		Out_Prize[1][50082]=20
		Out_Prize[1][50085]=20
		Out_Prize[1][50083]=110
		Out_Prize[1][50084]=50
		Out_Prize[1][50086]=30
		Out_Prize[1][50087]=10
		Out_Prize[1][50096]=40
		Out_Prize[1][50100]=30
		Out_Prize[1][50091]=20
		Out_Prize[1][50095]=50
		Out_Prize[1][50101]=20
		Out_Prize[1][50103]=30
		Out_Prize[1][50113]=110
		Out_Prize[1][50114]=110
		Out_Prize[1][50116]=40
		Out_Prize[1][50120]=30
		Out_Prize[1][50119]=50
		Out_Prize[1][50121]=10
		
		elseif id==54766 then  --���ʽ�
		Out_Prize[1][54191]=220
		Out_Prize[1][54192]=220
		Out_Prize[1][54193]=220
		Out_Prize[1][54196]=220
		Out_Prize[1][54197]=220
		Out_Prize[1][54198]=110
		Out_Prize[1][54208]=110
		Out_Prize[1][54209]=110
		Out_Prize[1][54210]=110
		Out_Prize[1][54213]=110
		Out_Prize[1][54214]=50
		Out_Prize[1][54215]=50
		Out_Prize[1][54219]=50
		Out_Prize[1][54220]=50
		Out_Prize[1][54221]=50
		Out_Prize[1][54224]=30
		Out_Prize[1][54228]=30
		Out_Prize[1][54229]=30
		Out_Prize[1][54230]=30
		Out_Prize[1][54194]=20
		Out_Prize[1][54199]=20
		Out_Prize[1][54200]=20
		Out_Prize[1][54211]=20
		Out_Prize[1][54216]=20
		Out_Prize[1][54217]=20
		Out_Prize[1][54222]=20
		Out_Prize[1][54227]=20
		Out_Prize[1][54231]=20
		Out_Prize[1][54195]=10
		Out_Prize[1][54201]=10
		Out_Prize[1][54212]=10
		Out_Prize[1][54218]=10
		Out_Prize[1][54223]=10
		
	elseif id==54767 then  --����ľ
		Out_Prize[1][54242]=220
		Out_Prize[1][54243]=220
		Out_Prize[1][54244]=220
		Out_Prize[1][54247]=220
		Out_Prize[1][54248]=220
		Out_Prize[1][54249]=110
		Out_Prize[1][54259]=110
		Out_Prize[1][54260]=110
		Out_Prize[1][54261]=110
		Out_Prize[1][54264]=110
		Out_Prize[1][54265]=50
		Out_Prize[1][54266]=50
		Out_Prize[1][54270]=50
		Out_Prize[1][54271]=50
		Out_Prize[1][54272]=50
		Out_Prize[1][54275]=30
		Out_Prize[1][54279]=30
		Out_Prize[1][54280]=30
		Out_Prize[1][54281]=30
		Out_Prize[1][54245]=20
		Out_Prize[1][54250]=20
		Out_Prize[1][54251]=20
		Out_Prize[1][54262]=20
		Out_Prize[1][54267]=20
		Out_Prize[1][54268]=20
		Out_Prize[1][54273]=20
		Out_Prize[1][54278]=20
		Out_Prize[1][54282]=20
		Out_Prize[1][54246]=10
		Out_Prize[1][54252]=10
		Out_Prize[1][54263]=10
		Out_Prize[1][54269]=10
		Out_Prize[1][54274]=10
		
	elseif id==54768 then  --����ˮ
		Out_Prize[1][54293]=220
		Out_Prize[1][54294]=220
		Out_Prize[1][54295]=220
		Out_Prize[1][54298]=220
		Out_Prize[1][54299]=220
		Out_Prize[1][54300]=110
		Out_Prize[1][54310]=110
		Out_Prize[1][54311]=110
		Out_Prize[1][54312]=110
		Out_Prize[1][54315]=110
		Out_Prize[1][54316]=50
		Out_Prize[1][54317]=50
		Out_Prize[1][54321]=50
		Out_Prize[1][54322]=50
		Out_Prize[1][54323]=50
		Out_Prize[1][54326]=30
		Out_Prize[1][54330]=30
		Out_Prize[1][54331]=30
		Out_Prize[1][54332]=30
		Out_Prize[1][54296]=20
		Out_Prize[1][54301]=20
		Out_Prize[1][54302]=20
		Out_Prize[1][54313]=20
		Out_Prize[1][54318]=20
		Out_Prize[1][54319]=20
		Out_Prize[1][54324]=20
		Out_Prize[1][54329]=20
		Out_Prize[1][54333]=20
		Out_Prize[1][54297]=10
		Out_Prize[1][54303]=10
		Out_Prize[1][54314]=10
		Out_Prize[1][54320]=10
		Out_Prize[1][54325]=10

	elseif id==54769 then  --���ʻ�
		Out_Prize[1][54344]=220
		Out_Prize[1][54345]=220
		Out_Prize[1][54346]=220
		Out_Prize[1][54349]=220
		Out_Prize[1][54350]=220
		Out_Prize[1][54351]=110
		Out_Prize[1][54361]=110
		Out_Prize[1][54362]=110
		Out_Prize[1][54363]=110
		Out_Prize[1][54366]=110
		Out_Prize[1][54367]=50
		Out_Prize[1][54368]=50
		Out_Prize[1][54372]=50
		Out_Prize[1][54373]=50
		Out_Prize[1][54374]=50
		Out_Prize[1][54377]=30
		Out_Prize[1][54381]=30
		Out_Prize[1][54382]=30
		Out_Prize[1][54383]=30
		Out_Prize[1][54347]=20
		Out_Prize[1][54352]=20
		Out_Prize[1][54353]=20
		Out_Prize[1][54364]=20
		Out_Prize[1][54369]=20
		Out_Prize[1][54370]=20
		Out_Prize[1][54375]=20
		Out_Prize[1][54380]=20
		Out_Prize[1][54384]=20
		Out_Prize[1][54348]=10
		Out_Prize[1][54354]=10
		Out_Prize[1][54365]=10
		Out_Prize[1][54371]=10
		Out_Prize[1][54376]=10

	elseif id==54770 then  --������
		Out_Prize[1][54395]=220
		Out_Prize[1][54396]=220
		Out_Prize[1][54397]=220
		Out_Prize[1][54400]=220
		Out_Prize[1][54401]=220
		Out_Prize[1][54402]=110
		Out_Prize[1][54412]=110
		Out_Prize[1][54413]=110
		Out_Prize[1][54414]=110
		Out_Prize[1][54417]=110
		Out_Prize[1][54418]=50
		Out_Prize[1][54419]=50
		Out_Prize[1][54423]=50
		Out_Prize[1][54424]=50
		Out_Prize[1][54425]=50
		Out_Prize[1][54428]=30
		Out_Prize[1][54432]=30
		Out_Prize[1][54433]=30
		Out_Prize[1][54434]=30
		Out_Prize[1][54398]=20
		Out_Prize[1][54403]=20
		Out_Prize[1][54404]=20
		Out_Prize[1][54415]=20
		Out_Prize[1][54420]=20
		Out_Prize[1][54421]=20
		Out_Prize[1][54426]=20
		Out_Prize[1][54431]=20
		Out_Prize[1][54435]=20
		Out_Prize[1][54399]=10
		Out_Prize[1][54405]=10
		Out_Prize[1][54416]=10
		Out_Prize[1][54422]=10
		Out_Prize[1][54427]=10
		
	elseif id==62174 then  --ǣ����
		Out_Prize[1][61502]=220
		Out_Prize[1][61503]=220
		Out_Prize[1][61504]=110
		Out_Prize[1][61505]=110
		Out_Prize[1][61506]=50
		Out_Prize[1][61507]=50
		Out_Prize[1][61508]=30
		Out_Prize[1][61509]=30
		Out_Prize[1][61510]=20
		Out_Prize[1][61511]=10
		Out_Prize[1][61512]=10
		Out_Prize[1][61513]=220
		Out_Prize[1][61514]=220
		Out_Prize[1][61515]=110
		Out_Prize[1][61516]=110
		Out_Prize[1][61517]=50
		Out_Prize[1][61518]=50
		Out_Prize[1][61519]=30
		Out_Prize[1][61520]=30
		Out_Prize[1][61521]=20
		Out_Prize[1][61522]=10
		Out_Prize[1][61523]=10
		Out_Prize[1][61524]=220
		Out_Prize[1][61525]=220
		Out_Prize[1][61526]=110
		Out_Prize[1][61527]=110
		Out_Prize[1][61528]=50
		Out_Prize[1][61529]=50
		Out_Prize[1][61530]=30
		Out_Prize[1][61531]=30
		Out_Prize[1][61532]=20
		Out_Prize[1][61533]=10
		Out_Prize[1][61534]=10

	elseif id==62175 then  --ǣ��ľ
		Out_Prize[1][61540]=220
		Out_Prize[1][61541]=220
		Out_Prize[1][61542]=110
		Out_Prize[1][61543]=110
		Out_Prize[1][61544]=50
		Out_Prize[1][61545]=50
		Out_Prize[1][61546]=30
		Out_Prize[1][61547]=30
		Out_Prize[1][61548]=20
		Out_Prize[1][61549]=10
		Out_Prize[1][61550]=10
		Out_Prize[1][61551]=220
		Out_Prize[1][61552]=220
		Out_Prize[1][61553]=110
		Out_Prize[1][61554]=110
		Out_Prize[1][61555]=50
		Out_Prize[1][61556]=50
		Out_Prize[1][61557]=30
		Out_Prize[1][61558]=30
		Out_Prize[1][61559]=20
		Out_Prize[1][61560]=10
		Out_Prize[1][61561]=10
		Out_Prize[1][61562]=220
		Out_Prize[1][61563]=220
		Out_Prize[1][61564]=110
		Out_Prize[1][61565]=110
		Out_Prize[1][61566]=50
		Out_Prize[1][61567]=50
		Out_Prize[1][61568]=30
		Out_Prize[1][61569]=30
		Out_Prize[1][61570]=20
		Out_Prize[1][61571]=10
		Out_Prize[1][61572]=10

	elseif id==62176 then  --ǣ��ˮ
		Out_Prize[1][61578]=220
		Out_Prize[1][61579]=220
		Out_Prize[1][61580]=110
		Out_Prize[1][61581]=110
		Out_Prize[1][61582]=50
		Out_Prize[1][61583]=50
		Out_Prize[1][61584]=30
		Out_Prize[1][61585]=30
		Out_Prize[1][61586]=20
		Out_Prize[1][61587]=10
		Out_Prize[1][61588]=10
		Out_Prize[1][61589]=220
		Out_Prize[1][61590]=220
		Out_Prize[1][61591]=110
		Out_Prize[1][61592]=110
		Out_Prize[1][61593]=50
		Out_Prize[1][61594]=50
		Out_Prize[1][61595]=30
		Out_Prize[1][61596]=30
		Out_Prize[1][61597]=20
		Out_Prize[1][61598]=10
		Out_Prize[1][61599]=10
		Out_Prize[1][61600]=220
		Out_Prize[1][61601]=220
		Out_Prize[1][61602]=110
		Out_Prize[1][61603]=110
		Out_Prize[1][61604]=50
		Out_Prize[1][61605]=50
		Out_Prize[1][61606]=30
		Out_Prize[1][61607]=30
		Out_Prize[1][61608]=20
		Out_Prize[1][61609]=10
		Out_Prize[1][61610]=10
		
	elseif id==62177 then  --ǣ����
		Out_Prize[1][61616]=220
		Out_Prize[1][61617]=220
		Out_Prize[1][61618]=110
		Out_Prize[1][61619]=110
		Out_Prize[1][61620]=50
		Out_Prize[1][61621]=50
		Out_Prize[1][61622]=30
		Out_Prize[1][61623]=30
		Out_Prize[1][61624]=20
		Out_Prize[1][61625]=10
		Out_Prize[1][61626]=10
		Out_Prize[1][61627]=220
		Out_Prize[1][61628]=220
		Out_Prize[1][61629]=110
		Out_Prize[1][61630]=110
		Out_Prize[1][61631]=50
		Out_Prize[1][61632]=50
		Out_Prize[1][61633]=30
		Out_Prize[1][61634]=30
		Out_Prize[1][61635]=20
		Out_Prize[1][61636]=10
		Out_Prize[1][61637]=10
		Out_Prize[1][61638]=220
		Out_Prize[1][61639]=220
		Out_Prize[1][61640]=110
		Out_Prize[1][61641]=110
		Out_Prize[1][61642]=50
		Out_Prize[1][61643]=50
		Out_Prize[1][61644]=30
		Out_Prize[1][61645]=30
		Out_Prize[1][61646]=20
		Out_Prize[1][61647]=10
		Out_Prize[1][61648]=10

	elseif id==62178 then  --ǣ����
		Out_Prize[1][61654]=220
		Out_Prize[1][61655]=220
		Out_Prize[1][61656]=110
		Out_Prize[1][61657]=110
		Out_Prize[1][61658]=50
		Out_Prize[1][61659]=50
		Out_Prize[1][61660]=30
		Out_Prize[1][61661]=30
		Out_Prize[1][61662]=20
		Out_Prize[1][61663]=10
		Out_Prize[1][61664]=10
		Out_Prize[1][61665]=220
		Out_Prize[1][61666]=220
		Out_Prize[1][61667]=110
		Out_Prize[1][61668]=110
		Out_Prize[1][61669]=50
		Out_Prize[1][61670]=50
		Out_Prize[1][61671]=30
		Out_Prize[1][61672]=30
		Out_Prize[1][61673]=20
		Out_Prize[1][61674]=10
		Out_Prize[1][61675]=10
		Out_Prize[1][61676]=220
		Out_Prize[1][61677]=220
		Out_Prize[1][61678]=110
		Out_Prize[1][61679]=110
		Out_Prize[1][61680]=50
		Out_Prize[1][61681]=50
		Out_Prize[1][61682]=30
		Out_Prize[1][61683]=30
		Out_Prize[1][61684]=20
		Out_Prize[1][61685]=10
		Out_Prize[1][61686]=10
		
	elseif id==62179 then  --Ӣ�н�
		Out_Prize[1][61695]=220
		Out_Prize[1][61698]=220
		Out_Prize[1][61709]=220
		Out_Prize[1][61715]=220
		Out_Prize[1][61720]=220
		Out_Prize[1][61729]=220
		Out_Prize[1][61732]=220
		Out_Prize[1][61692]=110
		Out_Prize[1][61699]=110
		Out_Prize[1][61710]=110
		Out_Prize[1][61716]=110
		Out_Prize[1][61721]=110
		Out_Prize[1][61726]=110
		Out_Prize[1][61733]=110
		Out_Prize[1][61696]=50
		Out_Prize[1][61700]=50
		Out_Prize[1][61711]=50
		Out_Prize[1][61717]=50
		Out_Prize[1][61730]=50
		Out_Prize[1][61734]=50
		Out_Prize[1][61693]=30
		Out_Prize[1][61697]=30
		Out_Prize[1][61701]=30
		Out_Prize[1][61718]=30
		Out_Prize[1][61722]=20
		Out_Prize[1][61727]=20
		Out_Prize[1][61731]=20
		Out_Prize[1][61735]=20
		Out_Prize[1][61694]=10
		Out_Prize[1][61702]=10
		Out_Prize[1][61725]=10
		Out_Prize[1][61728]=10
		Out_Prize[1][61736]=10
		
	elseif id==62180 then  --Ӣ��ľ
		Out_Prize[1][61746]=220
		Out_Prize[1][61749]=220
		Out_Prize[1][61760]=220
		Out_Prize[1][61766]=220
		Out_Prize[1][61771]=220
		Out_Prize[1][61780]=220
		Out_Prize[1][61783]=220
		Out_Prize[1][61743]=110
		Out_Prize[1][61750]=110
		Out_Prize[1][61761]=110
		Out_Prize[1][61767]=110
		Out_Prize[1][61772]=110
		Out_Prize[1][61777]=110
		Out_Prize[1][61784]=110
		Out_Prize[1][61747]=50
		Out_Prize[1][61751]=50
		Out_Prize[1][61762]=50
		Out_Prize[1][61768]=50
		Out_Prize[1][61781]=50
		Out_Prize[1][61785]=50
		Out_Prize[1][61744]=30
		Out_Prize[1][61748]=30
		Out_Prize[1][61752]=30
		Out_Prize[1][61769]=30
		Out_Prize[1][61773]=20
		Out_Prize[1][61778]=20
		Out_Prize[1][61782]=20
		Out_Prize[1][61786]=20
		Out_Prize[1][61745]=10
		Out_Prize[1][61753]=10
		Out_Prize[1][61776]=10
		Out_Prize[1][61779]=10
		Out_Prize[1][61787]=10
	
	elseif id==62181 then  --Ӣ��ˮ
		Out_Prize[1][61797]=220
		Out_Prize[1][61800]=220
		Out_Prize[1][61811]=220
		Out_Prize[1][61817]=220
		Out_Prize[1][61822]=220
		Out_Prize[1][61831]=220
		Out_Prize[1][61834]=220
		Out_Prize[1][61794]=110
		Out_Prize[1][61801]=110
		Out_Prize[1][61812]=110
		Out_Prize[1][61818]=110
		Out_Prize[1][61823]=110
		Out_Prize[1][61828]=110
		Out_Prize[1][61835]=110
		Out_Prize[1][61798]=50
		Out_Prize[1][61802]=50
		Out_Prize[1][61813]=50
		Out_Prize[1][61819]=50
		Out_Prize[1][61832]=50
		Out_Prize[1][61836]=50
		Out_Prize[1][61795]=30
		Out_Prize[1][61799]=30
		Out_Prize[1][61803]=30
		Out_Prize[1][61820]=30
		Out_Prize[1][61824]=20
		Out_Prize[1][61829]=20
		Out_Prize[1][61833]=20
		Out_Prize[1][61837]=20
		Out_Prize[1][61796]=10
		Out_Prize[1][61804]=10
		Out_Prize[1][61827]=10
		Out_Prize[1][61830]=10
		Out_Prize[1][61838]=10

	elseif id==62182 then  --Ӣ�л�
		Out_Prize[1][61848]=220
		Out_Prize[1][61851]=220
		Out_Prize[1][61862]=220
		Out_Prize[1][61868]=220
		Out_Prize[1][61873]=220
		Out_Prize[1][61882]=220
		Out_Prize[1][61885]=220
		Out_Prize[1][61845]=110
		Out_Prize[1][61852]=110
		Out_Prize[1][61863]=110
		Out_Prize[1][61869]=110
		Out_Prize[1][61874]=110
		Out_Prize[1][61879]=110
		Out_Prize[1][61886]=110
		Out_Prize[1][61849]=50
		Out_Prize[1][61853]=50
		Out_Prize[1][61864]=50
		Out_Prize[1][61870]=50
		Out_Prize[1][61883]=50
		Out_Prize[1][61887]=50
		Out_Prize[1][61846]=30
		Out_Prize[1][61850]=30
		Out_Prize[1][61854]=30
		Out_Prize[1][61871]=30
		Out_Prize[1][61875]=20
		Out_Prize[1][61880]=20
		Out_Prize[1][61884]=20
		Out_Prize[1][61888]=20
		Out_Prize[1][61847]=10
		Out_Prize[1][61855]=10
		Out_Prize[1][61878]=10
		Out_Prize[1][61881]=10
		Out_Prize[1][61889]=10

	elseif id==62183 then  --Ӣ����
		Out_Prize[1][61899]=220
		Out_Prize[1][61902]=220
		Out_Prize[1][61913]=220
		Out_Prize[1][61919]=220
		Out_Prize[1][61924]=220
		Out_Prize[1][61933]=220
		Out_Prize[1][61936]=220
		Out_Prize[1][61896]=110
		Out_Prize[1][61903]=110
		Out_Prize[1][61914]=110
		Out_Prize[1][61920]=110
		Out_Prize[1][61925]=110
		Out_Prize[1][61930]=110
		Out_Prize[1][61937]=110
		Out_Prize[1][61900]=50
		Out_Prize[1][61904]=50
		Out_Prize[1][61915]=50
		Out_Prize[1][61921]=50
		Out_Prize[1][61934]=50
		Out_Prize[1][61938]=50
		Out_Prize[1][61897]=30
		Out_Prize[1][61901]=30
		Out_Prize[1][61905]=30
		Out_Prize[1][61922]=30
		Out_Prize[1][61926]=20
		Out_Prize[1][61931]=20
		Out_Prize[1][61935]=20
		Out_Prize[1][61939]=20
		Out_Prize[1][61898]=10
		Out_Prize[1][61906]=10
		Out_Prize[1][61929]=10
		Out_Prize[1][61932]=10
		Out_Prize[1][61940]=10

	elseif id == 62061 then
		Out_Prize[1][60541]=200
		Out_Prize[1][60543]=200
		Out_Prize[1][60545]=200
		Out_Prize[1][60547]=200
		Out_Prize[1][60549]=200
		Out_Prize[1][60551]=200
		Out_Prize[1][60553]=200
		Out_Prize[1][60555]=200
		Out_Prize[1][60557]=200
		Out_Prize[1][60559]=320
		Out_Prize[1][60561]=320
		Out_Prize[1][60563]=100
		Out_Prize[1][60565]=100
		Out_Prize[1][60567]=100
		Out_Prize[1][60569]=100
		Out_Prize[1][60571]=40
		Out_Prize[1][60573]=40
		Out_Prize[1][60575]=40
		Out_Prize[1][60577]=40
		Out_Prize[1][60579]=40
		Out_Prize[1][60581]=40
		
	elseif id == 62062 then
		Out_Prize[1][60542]=50
		Out_Prize[1][60544]=50
		Out_Prize[1][60546]=50
		Out_Prize[1][60548]=50
		Out_Prize[1][60550]=50
		Out_Prize[1][60552]=50
		Out_Prize[1][60554]=50
		Out_Prize[1][60556]=50
		Out_Prize[1][60558]=50
		Out_Prize[1][60560]=80
		Out_Prize[1][60562]=80
		Out_Prize[1][60564]=25
		Out_Prize[1][60566]=25
		Out_Prize[1][60568]=25
		Out_Prize[1][60570]=25
		Out_Prize[1][60572]=10
		Out_Prize[1][60574]=10
		Out_Prize[1][60576]=10
		Out_Prize[1][60578]=10
		Out_Prize[1][60580]=10
		Out_Prize[1][60582]=10
		
	elseif id == 62063 then
		Out_Prize[1][61424]=10
		Out_Prize[1][61425]=10
		Out_Prize[1][61426]=10
		Out_Prize[1][61427]=10
		Out_Prize[1][61428]=10
		Out_Prize[1][61429]=10
		Out_Prize[1][61431]=10
		Out_Prize[1][61432]=10
		Out_Prize[1][61433]=10
		Out_Prize[1][61434]=16
		Out_Prize[1][61435]=16
		Out_Prize[1][61436]=5
		Out_Prize[1][61437]=5
		Out_Prize[1][61438]=5
		Out_Prize[1][61439]=5
		Out_Prize[1][61440]=2
		Out_Prize[1][61441]=2
		Out_Prize[1][61442]=2
		Out_Prize[1][61443]=2
		Out_Prize[1][61444]=2
		Out_Prize[1][61445]=2		

	else
		Out_Prize[1][id]=100
	end 	
		
	local i,v,k
	
	for k=1,1 do
		lot_prize[k]={}
		lot_prizechance[k]={}
	end 
	
	for k=1,1 do
		for i,v in pairs(Out_Prize[k]) do 
			table.insert(lot_prize[k],i)
			table.insert(lot_prizechance[k],v)
		end 
	end 
	if nowcurlist[fmax_count]=="111" then 
		prizeout=lot_prize[1][ZLottery_Get_RanPoint(lot_prizechance[1])]
		return 1,0,prizeout,1,0,0
	end
	return 1,0,id,1,0,0 
end
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType13593Cashing(cur_list)		---(�¹ⱦ��)
	---fmax_countΪ�ò�Ʊ����Чλ��
	local cp
	local nowcurlist={}
	local fmax_count=table.getn(cur_list)
	nowcurlist[0]=""
	for cp=1,fmax_count do
		nowcurlist[cp]=nowcurlist[cp-1]..cur_list[cp]
	end 
	
	local lot_prize={}
	local lot_prizechance={}
	local prizeout
	local Out_Prize={}
	Out_Prize[1]={}
	Out_Prize[2]={}
	Out_Prize[3]={}
	Out_Prize[4]={}
	
	Out_Prize[1][33124]=100		---�¹�����(����������)
	
	Out_Prize[2][24904]=100   ---���龫��

	Out_Prize[3][23360]=100   ---ǧ������

	Out_Prize[4][21154]=100	---���춷��
		
	local i,v,k
	
	for k=1,4 do
		lot_prize[k]={}
		lot_prizechance[k]={}
	end 
	
	for k=1,4 do
		for i,v in pairs(Out_Prize[k]) do 
			table.insert(lot_prize[k],i)
			table.insert(lot_prizechance[k],v)
		end 
	end 
	if nowcurlist[fmax_count]=="111" then 
		prizeout=lot_prize[1][ZLottery_Get_RanPoint(lot_prizechance[1])]
		return 1,0,prizeout,1,0,0
	elseif nowcurlist[fmax_count]=="222"  then 
		prizeout=lot_prize[2][ZLottery_Get_RanPoint(lot_prizechance[2])]
		return 2,0,prizeout,1,0,0
		
	elseif (ZLottery_FindSameNum(cur_list,1)==0 and ZLottery_FindSameNum(cur_list,2)==0) or
	(ZLottery_FindSameNum(cur_list,1)==1 and ZLottery_FindSameNum(cur_list,2)==1 and 
	ZLottery_FindSameNum(cur_list,3)==1) or
	(ZLottery_FindSameNum(cur_list,1)==1 and ZLottery_FindSameNum(cur_list,2)==1 and 
	ZLottery_FindSameNum(cur_list,4)==1)or
	(ZLottery_FindSameNum(cur_list,2)==1 and ZLottery_FindSameNum(cur_list,3)==1 and 
	ZLottery_FindSameNum(cur_list,4)==1)then 
		prizeout=lot_prize[3][ZLottery_Get_RanPoint(lot_prizechance[3])]
		return 3,0,prizeout,2,0,0
	else 
		return 4,0,21154,2,0,0
	end
	return 4,0,21154,2,0,0 
end 

-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType13905Cashing(cur_list)		---(����_��ͼ��)
	---fmax_countΪ�ò�Ʊ����Чλ��
	local cp
	local nowcurlist={}
	local fmax_count=table.getn(cur_list)
	nowcurlist[0]=""
	for cp=1,fmax_count do
		nowcurlist[cp]=nowcurlist[cp-1]..cur_list[cp]
	end 
	
	local lot_prize={}
	local lot_prizechance={}
	local prizeout
	local Out_Prize={}
	Out_Prize[1]={}
	Out_Prize[2]={}
	Out_Prize[3]={}
	Out_Prize[4]={}
	
	Out_Prize[1][13486]=100 ---˪��
	
	Out_Prize[2][13904]=333 ---//�߼�����
	Out_Prize[2][13903]=667	---//�߼���ľ
	
	Out_Prize[3][18794]=100		---�ɶ�
	
	Out_Prize[4][8079]=100	---�������
		
	local i,v,k
	
	for k=1,4 do
		lot_prize[k]={}
		lot_prizechance[k]={}
	end 
	
	for k=1,4 do
		for i,v in pairs(Out_Prize[k]) do 
			table.insert(lot_prize[k],i)
			table.insert(lot_prizechance[k],v)
		end 
	end 
	if nowcurlist[fmax_count]=="111" then 
		prizeout=lot_prize[1][ZLottery_Get_RanPoint(lot_prizechance[1])]
		return 1,0,prizeout,1,0,0
	elseif nowcurlist[fmax_count]=="222"  then 
		prizeout=lot_prize[2][ZLottery_Get_RanPoint(lot_prizechance[2])]
		return 2,0,prizeout,1,0,0
	elseif ZLottery_FindSameNum(cur_list,1)==2 or ZLottery_FindSameNum(cur_list,2)==2 then 
		prizeout=lot_prize[3][ZLottery_Get_RanPoint(lot_prizechance[3])]
		return 3,0,prizeout,3,0,0
	else 
		return 4,0,8079,2,0,0
	end
	return 4,0,8079,2,0,0 
end 
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType15677Cashing(cur_list)		---(ʨ��֮��)
	---fmax_countΪ�ò�Ʊ����Чλ��
	local cp
	local nowcurlist={}
	local fmax_count=table.getn(cur_list)
	nowcurlist[0]=""
	for cp=1,fmax_count do
		nowcurlist[cp]=nowcurlist[cp-1]..cur_list[cp]
	end 
	
	local lot_prize={}
	local lot_prizechance={}
	local prizeout
	local Out_Prize={}
	Out_Prize[1]={}
	Out_Prize[2]={}
	Out_Prize[3]={}
	Out_Prize[4]={}
	
	Out_Prize[1][15672]=100		---��ʨ
	
	Out_Prize[2][7931]=40			---��������
	Out_Prize[2][7937]=60			---������Ů	

	Out_Prize[3][15693]=140	---���¶һ�ȯ
	Out_Prize[3][15694]=20	---���նһ�ȯ	
	
	Out_Prize[4][8079]=100	---�������
		
	local i,v,k
	
	for k=1,4 do
		lot_prize[k]={}
		lot_prizechance[k]={}
	end 
	
	for k=1,4 do
		for i,v in pairs(Out_Prize[k]) do 
			table.insert(lot_prize[k],i)
			table.insert(lot_prizechance[k],v)
		end 
	end 
	if nowcurlist[fmax_count]=="111" then 
		prizeout=lot_prize[1][ZLottery_Get_RanPoint(lot_prizechance[1])]
		return 1,0,prizeout,1,0,0
	elseif nowcurlist[fmax_count]=="222"  then 
		prizeout=lot_prize[2][ZLottery_Get_RanPoint(lot_prizechance[2])]
		return 2,0,prizeout,1,0,0
	elseif (ZLottery_FindSameNum(cur_list,1)==0 and ZLottery_FindSameNum(cur_list,2)==0) or
	ZLottery_FindSameNum(cur_list,1)==2 or ZLottery_FindSameNum(cur_list,2)==2 then 
		prizeout=lot_prize[3][ZLottery_Get_RanPoint(lot_prizechance[3])]
		if prizeout==15694 then 
			return 3,0,prizeout,1,0,0
		else
			return 3,0,prizeout,2,0,0
		end 
	else 
		return 4,0,8079,2,0,0
	end
	return 4,0,8079,2,0,0 
end 
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType15866Cashing(cur_list)		---(����_�׹�ī��)
	---fmax_countΪ�ò�Ʊ����Чλ��
	local cp
	local nowcurlist={}
	local fmax_count=table.getn(cur_list)
	nowcurlist[0]=""
	for cp=1,fmax_count do
		nowcurlist[cp]=nowcurlist[cp-1]..cur_list[cp]
	end 
	
	local lot_prize={}
	local lot_prizechance={}
	local prizeout
	local Out_Prize={}
	Out_Prize[1]={}
	Out_Prize[2]={}
	Out_Prize[3]={}
	Out_Prize[4]={}
	
	Out_Prize[1][15865]=100		---ī������
	
	Out_Prize[2][7931]=40			---��������
	Out_Prize[2][7937]=60			---������Ů	

	Out_Prize[3][13343]=100		---�۱���
		
	Out_Prize[4][13901]=25		---��Defҩ
	Out_Prize[4][13900]=100		---��Atkҩ
		
	local i,v,k
	
	for k=1,4 do
		lot_prize[k]={}
		lot_prizechance[k]={}
	end 
	
	for k=1,4 do
		for i,v in pairs(Out_Prize[k]) do 
			table.insert(lot_prize[k],i)
			table.insert(lot_prizechance[k],v)
		end 
	end 
	if nowcurlist[fmax_count]=="111" then 
		prizeout=lot_prize[1][ZLottery_Get_RanPoint(lot_prizechance[1])]
		return 1,0,prizeout,1,0,0
	elseif nowcurlist[fmax_count]=="222"  then 
		prizeout=lot_prize[2][ZLottery_Get_RanPoint(lot_prizechance[2])]
		return 2,0,prizeout,1,0,0
	elseif (ZLottery_FindSameNum(cur_list,1)==0 and ZLottery_FindSameNum(cur_list,2)==0) or
	(ZLottery_FindSameNum(cur_list,1)==1 and ZLottery_FindSameNum(cur_list,2)==1 and 
	ZLottery_FindSameNum(cur_list,3)==1) then 
		prizeout=lot_prize[3][ZLottery_Get_RanPoint(lot_prizechance[3])]
		return 3,0,prizeout,10,0,0
	else 
		prizeout=lot_prize[4][ZLottery_Get_RanPoint(lot_prizechance[4])]
		return 4,0,prizeout,1,0,0
	end
	return 4,0,13900,1,0,0 
end 
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType16550Cashing(cur_list)		---(����_��¹����)
	---fmax_countΪ�ò�Ʊ����Чλ��
	local cp
	local nowcurlist={}
	local fmax_count=table.getn(cur_list)
	nowcurlist[0]=""
	for cp=1,fmax_count do
		nowcurlist[cp]=nowcurlist[cp-1]..cur_list[cp]
	end 
	
	local lot_prize={}
	local lot_prizechance={}
	local prizeout
	local Out_Prize={}
	Out_Prize[1]={}
	Out_Prize[2]={}
	Out_Prize[3]={}
	Out_Prize[4]={}
	
	Out_Prize[1][16549]=100		---��ɫ¹
	
	Out_Prize[2][7931]=40			---��������
	Out_Prize[2][7937]=60			---������Ů

	Out_Prize[3][18794]=100		---�ɶ�
		
	Out_Prize[4][13901]=25		---��Defҩ
	Out_Prize[4][13900]=100		---��Atkҩ
		
	local i,v,k
	
	for k=1,4 do
		lot_prize[k]={}
		lot_prizechance[k]={}
	end 
	
	for k=1,4 do
		for i,v in pairs(Out_Prize[k]) do 
			table.insert(lot_prize[k],i)
			table.insert(lot_prizechance[k],v)
		end 
	end 
	if nowcurlist[fmax_count]=="111" then 
		prizeout=lot_prize[1][ZLottery_Get_RanPoint(lot_prizechance[1])]
		return 1,0,prizeout,1,0,0
	elseif nowcurlist[fmax_count]=="222"  then 
		prizeout=lot_prize[2][ZLottery_Get_RanPoint(lot_prizechance[2])]
		return 2,0,prizeout,1,0,0
	elseif (ZLottery_FindSameNum(cur_list,1)==0 and ZLottery_FindSameNum(cur_list,2)==0) or
	(ZLottery_FindSameNum(cur_list,1)==1 and ZLottery_FindSameNum(cur_list,2)==1 and 
	ZLottery_FindSameNum(cur_list,3)==1) then 
		prizeout=lot_prize[3][ZLottery_Get_RanPoint(lot_prizechance[3])]
		return 3,0,prizeout,3,0,0
	else 
		prizeout=lot_prize[4][ZLottery_Get_RanPoint(lot_prizechance[4])]
		return 4,0,prizeout,1,0,0
	end
	return 4,0,13900,1,0,0 
end 
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType18283Cashing(cur_list)		---(����_�������)
	---fmax_countΪ�ò�Ʊ����Чλ��
	local cp
	local nowcurlist={}
	local fmax_count=table.getn(cur_list)
	nowcurlist[0]=""
	for cp=1,fmax_count do
		nowcurlist[cp]=nowcurlist[cp-1]..cur_list[cp]
	end 
	
	local lot_prize={}
	local lot_prizechance={}
	local prizeout
	local Out_Prize={}
	Out_Prize[1]={}
	Out_Prize[2]={}
	Out_Prize[3]={}
	Out_Prize[4]={}
	
	Out_Prize[1][18284]=100	---����һ�ȯ
	
	Out_Prize[2][13307]=80	---�������
	Out_Prize[2][13306]=20	---��������	

	Out_Prize[3][18794]=100	---�ɶ�
	
	Out_Prize[4][13901]=25		---��Defҩ
	Out_Prize[4][13900]=100		---��Atkҩ
		
	local i,v,k
	
	for k=1,4 do
		lot_prize[k]={}
		lot_prizechance[k]={}
	end 
	
	for k=1,4 do
		for i,v in pairs(Out_Prize[k]) do 
			table.insert(lot_prize[k],i)
			table.insert(lot_prizechance[k],v)
		end 
	end 
	if nowcurlist[fmax_count]=="111" then 
		prizeout=lot_prize[1][ZLottery_Get_RanPoint(lot_prizechance[1])]
		return 1,0,prizeout,1,0,0
	elseif nowcurlist[fmax_count]=="222"  then 
		prizeout=lot_prize[2][ZLottery_Get_RanPoint(lot_prizechance[2])]
		return 2,0,prizeout,1,0,0
	elseif (ZLottery_FindSameNum(cur_list,1)==0 and ZLottery_FindSameNum(cur_list,2)==0) or
	(ZLottery_FindSameNum(cur_list,1)==1 and ZLottery_FindSameNum(cur_list,2)==1 and 
	ZLottery_FindSameNum(cur_list,3)==1) then 
		prizeout=lot_prize[3][ZLottery_Get_RanPoint(lot_prizechance[3])]
		return 3,0,prizeout,3,0,0
	else 
		prizeout=lot_prize[4][ZLottery_Get_RanPoint(lot_prizechance[4])]
		return 4,0,prizeout,1,0,0
	end
	return 4,0,13900,1,0,0 
end
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType18799Cashing(cur_list)		---(����_�����쾧)
	---fmax_countΪ�ò�Ʊ����Чλ��
	local cp
	local nowcurlist={}
	local fmax_count=table.getn(cur_list)
	nowcurlist[0]=""
	for cp=1,fmax_count do
		nowcurlist[cp]=nowcurlist[cp-1]..cur_list[cp]
	end 
	
	local lot_prize={}
	local lot_prizechance={}
	local prizeout
	local Out_Prize={}
	Out_Prize[1]={}
	Out_Prize[2]={}
	Out_Prize[3]={}
	Out_Prize[4]={}
	
	Out_Prize[1][18801]=100		---��ԭѩ��
	
	Out_Prize[2][13316]=100		---������

	Out_Prize[3][18794]=100		---�ɶ�
		
	Out_Prize[4][13901]=25		---��Defҩ
	Out_Prize[4][13900]=100		---��Atkҩ
		
	local i,v,k
	
	for k=1,4 do
		lot_prize[k]={}
		lot_prizechance[k]={}
	end 
	
	for k=1,4 do
		for i,v in pairs(Out_Prize[k]) do 
			table.insert(lot_prize[k],i)
			table.insert(lot_prizechance[k],v)
		end 
	end 
	if nowcurlist[fmax_count]=="111" then 
		prizeout=lot_prize[1][ZLottery_Get_RanPoint(lot_prizechance[1])]
		return 1,0,prizeout,1,0,0
	elseif nowcurlist[fmax_count]=="222"  then 
		prizeout=lot_prize[2][ZLottery_Get_RanPoint(lot_prizechance[2])]
		return 2,0,prizeout,1,0,0
	elseif (ZLottery_FindSameNum(cur_list,1)==0 and ZLottery_FindSameNum(cur_list,2)==0) or
	ZLottery_FindSameNum(cur_list,1)==2 or ZLottery_FindSameNum(cur_list,2)==2 then 
		prizeout=lot_prize[3][ZLottery_Get_RanPoint(lot_prizechance[3])]
			return 3,0,prizeout,3,0,0
	else 
		prizeout=lot_prize[4][ZLottery_Get_RanPoint(lot_prizechance[4])]
		return 4,0,prizeout,1,0,0
	end
	return 4,0,13900,2,0,0 
end 
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType18890Cashing(cur_list)		---(����_����ʥ��)
	---fmax_countΪ�ò�Ʊ����Чλ��
	local cp
	local nowcurlist={}
	local fmax_count=table.getn(cur_list)
	nowcurlist[0]=""
	for cp=1,fmax_count do
		nowcurlist[cp]=nowcurlist[cp-1]..cur_list[cp]
	end 
	
	local lot_prize={}
	local lot_prizechance={}
	local prizeout
	local Out_Prize={}
	Out_Prize[1]={}
	Out_Prize[2]={}
	Out_Prize[3]={}
	Out_Prize[4]={}
	
	Out_Prize[1][18891]=100		---�����һ�ȯ
	
	Out_Prize[2][7931]=40			---��������
	Out_Prize[2][7937]=60			---������Ů

	Out_Prize[3][18794]=100		---�ɶ�
	
	Out_Prize[4][8079]=100		---�������
		
	local i,v,k
	
	for k=1,4 do
		lot_prize[k]={}
		lot_prizechance[k]={}
	end 
	
	for k=1,4 do
		for i,v in pairs(Out_Prize[k]) do 
			table.insert(lot_prize[k],i)
			table.insert(lot_prizechance[k],v)
		end 
	end 
	if nowcurlist[fmax_count]=="111" then 
		prizeout=lot_prize[1][ZLottery_Get_RanPoint(lot_prizechance[1])]
		return 1,0,prizeout,1,0,0
	elseif nowcurlist[fmax_count]=="222"  then 
		prizeout=lot_prize[2][ZLottery_Get_RanPoint(lot_prizechance[2])]
		return 2,0,prizeout,1,0,0
	elseif (ZLottery_FindSameNum(cur_list,1)==0 and ZLottery_FindSameNum(cur_list,2)==0) or
	ZLottery_FindSameNum(cur_list,1)==2 or ZLottery_FindSameNum(cur_list,2)==2 then 
		prizeout=lot_prize[3][ZLottery_Get_RanPoint(lot_prizechance[3])]
			return 3,0,prizeout,3,0,0
	else 
		prizeout=lot_prize[4][ZLottery_Get_RanPoint(lot_prizechance[4])]
		return 4,0,prizeout,2,0,0
	end
	return 4,0,8079,2,0,0 
end 
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryTypeItemSeason1Cashing(cur_list,id)		---(��һ��ղ�Ʊ)
	---fmax_countΪ�ò�Ʊ����Чλ��
	local cp
	local nowcurlist={}
	local fmax_count=table.getn(cur_list)
	nowcurlist[0]=""
	for cp=1,fmax_count do
		nowcurlist[cp]=nowcurlist[cp-1]..cur_list[cp]
	end 
	
	local lot_prize={}
	local lot_prizechance={}
	local prizeout
	local Out_Prize={}
	Out_Prize[1]={}
	
	if id==19112 then
		Out_Prize[1][3449]={chance=100,num=1}---//ħ��
		Out_Prize[1][3459]={chance=100,num=1}---//ʥ��
		Out_Prize[1][3530]={chance=100,num=1}---//ħ��
		Out_Prize[1][3540]={chance=100,num=1}---//ħ��
		Out_Prize[1][6151]={chance=100,num=1}---//���ƽ�
		Out_Prize[1][6152]={chance=100,num=1}---//�ѿս�
		Out_Prize[1][6153]={chance=100,num=1}---//�ѻ��
		Out_Prize[1][6154]={chance=100,num=1}---//���׽�
		Out_Prize[1][6155]={chance=100,num=1}---//���ƽ�
		Out_Prize[1][6156]={chance=100,num=1}---//���ƽ�
		Out_Prize[1][6157]={chance=100,num=1}---//���ƽ�
		Out_Prize[1][6158]={chance=100,num=1}---//��Ӣ��
		Out_Prize[1][6159]={chance=100,num=1}---//��Ӣ��
		Out_Prize[1][6160]={chance=100,num=1}---//���׽�
		Out_Prize[1][6161]={chance=100,num=1}---//�����
		Out_Prize[1][6162]={chance=100,num=1}---//�׹��
		Out_Prize[1][6163]={chance=100,num=1}---//�����
		Out_Prize[1][6164]={chance=100,num=1}---//���ƽ�
		Out_Prize[1][6165]={chance=100,num=1}---//���ƽ�
		Out_Prize[1][6311]={chance=100,num=1}---//ħѭ
		Out_Prize[1][6331]={chance=100,num=1}---//ħ��
		Out_Prize[1][14377]={chance=100,num=1}---//����������У�
		Out_Prize[1][14384]={chance=100,num=1}---//����ڤ�����У�
		Out_Prize[1][14518]={chance=100,num=1}---//���������Ů��
		Out_Prize[1][14525]={chance=100,num=1}---//����ڤ����Ů��
		Out_Prize[1][14750]={chance=100,num=1}---//������ף��У�
		Out_Prize[1][14757]={chance=100,num=1}---//����ڤ�ף��У�
		Out_Prize[1][14891]={chance=100,num=1}---//������ף�Ů��
		Out_Prize[1][14898]={chance=100,num=1}---//����ڤ�ף�Ů��
		Out_Prize[1][15032]={chance=100,num=1}---//������ѥ���У�
		Out_Prize[1][15039]={chance=100,num=1}---//����ڤѥ���У�
		Out_Prize[1][15173]={chance=100,num=1}---//������ѥ��Ů��
		Out_Prize[1][15180]={chance=100,num=1}---//����ڤѥ��Ů��
		Out_Prize[1][3008]={chance=100,num=1}---//��ڣս�ף��У�
		Out_Prize[1][3015]={chance=100,num=1}---//�и��������У�
		Out_Prize[1][3022]={chance=100,num=1}---//�������ۣ��У�
		Out_Prize[1][3029]={chance=100,num=1}---//�������£��У�
		Out_Prize[1][3036]={chance=100,num=1}---//��ڣսѥ���У�
		Out_Prize[1][3043]={chance=100,num=1}---//�и���ѥ���У�
		Out_Prize[1][3050]={chance=100,num=1}---//�������ģ��У�
		Out_Prize[1][3057]={chance=100,num=1}---//�������ģ��У�
		Out_Prize[1][3064]={chance=100,num=1}---//��ڣս�����У�
		Out_Prize[1][3071]={chance=100,num=1}---//�и�������У�
		Out_Prize[1][3078]={chance=100,num=1}---//�������ڣ��У�
		Out_Prize[1][3085]={chance=100,num=1}---//�������ڣ��У�
		Out_Prize[1][3092]={chance=100,num=1}---//��ڣս�ף�Ů��
		Out_Prize[1][3099]={chance=100,num=1}---//�и�������Ů��
		Out_Prize[1][3106]={chance=100,num=1}---//�������ۣ�Ů��
		Out_Prize[1][3113]={chance=100,num=1}---//�������£�Ů��
		Out_Prize[1][3120]={chance=100,num=1}---//��ڣսѥ��Ů��
		Out_Prize[1][3127]={chance=100,num=1}---//�и���ѥ��Ů��
		Out_Prize[1][3134]={chance=100,num=1}---//�������ģ�Ů��
		Out_Prize[1][3141]={chance=100,num=1}---//�������ģ�Ů��
		Out_Prize[1][3148]={chance=100,num=1}---//��ڣս����Ů��
		Out_Prize[1][3155]={chance=100,num=1}---//�и������Ů��
		Out_Prize[1][3162]={chance=100,num=1}---//�������ڣ�Ů��
		Out_Prize[1][3169]={chance=100,num=1}---//�������ڣ�Ů��
		Out_Prize[1][5180]={chance=100,num=1}---//ɱ��ħ�����У�
		Out_Prize[1][5181]={chance=100,num=1}---//ɱ��ħ����Ů��
		Out_Prize[1][5208]={chance=100,num=1}---//����������У�
		Out_Prize[1][5209]={chance=100,num=1}---//���������Ů��
		Out_Prize[1][5236]={chance=100,num=1}---//�ޱ����ڣ��У�
		Out_Prize[1][5237]={chance=100,num=1}---//�ޱ����ڣ�Ů��
		Out_Prize[1][5264]={chance=100,num=1}---//��̨���ڣ��У�
		Out_Prize[1][5265]={chance=100,num=1}---//��̨���ڣ�Ů��
		Out_Prize[1][5316]={chance=100,num=1}---//ɱ��ħѥ���У�
		Out_Prize[1][5317]={chance=100,num=1}---//ɱ��ħѥ��Ů��
		Out_Prize[1][5344]={chance=100,num=1}---//������ѥ���У�
		Out_Prize[1][5345]={chance=100,num=1}---//������ѥ��Ů��
		Out_Prize[1][5372]={chance=100,num=1}---//�ޱ����ģ��У�
		Out_Prize[1][5373]={chance=100,num=1}---//�ޱ����ģ�Ů��
		Out_Prize[1][5400]={chance=100,num=1}---//��̨���ģ��У�
		Out_Prize[1][5401]={chance=100,num=1}---//��̨���ģ�Ů��
		Out_Prize[1][5428]={chance=100,num=1}---//ɱ��ħ�ף��У�
		Out_Prize[1][5429]={chance=100,num=1}---//ɱ��ħ�ף�Ů��
		Out_Prize[1][5456]={chance=100,num=1}---//�����������У�
		Out_Prize[1][5457]={chance=100,num=1}---//����������Ů��
		Out_Prize[1][5484]={chance=100,num=1}---//�ޱ����ۣ��У�
		Out_Prize[1][5485]={chance=100,num=1}---//�ޱ����ۣ�Ů��
		Out_Prize[1][5512]={chance=100,num=1}---//��̨���£��У�
		Out_Prize[1][5513]={chance=100,num=1}---//��̨���£�Ů��
	elseif id==19113 then 
		Out_Prize[1][3450]={chance=100,num=1}---//����
		Out_Prize[1][3460]={chance=100,num=1}---//����
		Out_Prize[1][3531]={chance=100,num=1}---//����
		Out_Prize[1][3541]={chance=100,num=1}---//����
		Out_Prize[1][6312]={chance=100,num=1}---//��ѭ
		Out_Prize[1][6332]={chance=100,num=1}---//����
		Out_Prize[1][14378]={chance=100,num=1}---//�����п����У�
		Out_Prize[1][14385]={chance=100,num=1}---//��ɷ��ʬ�����У�
		Out_Prize[1][14519]={chance=100,num=1}---//�����п���Ů��
		Out_Prize[1][14526]={chance=100,num=1}---//��ɷ��ʬ����Ů��
		Out_Prize[1][14751]={chance=100,num=1}---//�����мף��У�
		Out_Prize[1][14758]={chance=100,num=1}---//��ɷ��ʬ�ף��У�
		Out_Prize[1][14892]={chance=100,num=1}---//�����мף�Ů��
		Out_Prize[1][14899]={chance=100,num=1}---//��ɷ��ʬ�ף�Ů��
		Out_Prize[1][15033]={chance=100,num=1}---//������ѥ���У�
		Out_Prize[1][15040]={chance=100,num=1}---//��ɷ��ʬѥ���У�
		Out_Prize[1][15174]={chance=100,num=1}---//������ѥ��Ů��
		Out_Prize[1][15181]={chance=100,num=1}---//��ɷ��ʬѥ��Ů��
		Out_Prize[1][3009]={chance=100,num=1}---//ħ�����������У�
		Out_Prize[1][3016]={chance=100,num=1}---//����ɽ������У�
		Out_Prize[1][3023]={chance=100,num=1}---//���������ۣ��У�
		Out_Prize[1][3030]={chance=100,num=1}---//���𹦵��ۣ��У�
		Out_Prize[1][3037]={chance=100,num=1}---//ħ������ѥ���У�
		Out_Prize[1][3044]={chance=100,num=1}---//����ɽ�ѥ���У�
		Out_Prize[1][3051]={chance=100,num=1}---//���������ģ��У�
		Out_Prize[1][3058]={chance=100,num=1}---//���𹦵��ģ��У�
		Out_Prize[1][3065]={chance=100,num=1}---//ħ����������У�
		Out_Prize[1][3072]={chance=100,num=1}---//����ɽ᰿����У�
		Out_Prize[1][3079]={chance=100,num=1}---//��������ڣ��У�
		Out_Prize[1][3086]={chance=100,num=1}---//���𹦵¹ڣ��У�
		Out_Prize[1][3093]={chance=100,num=1}---//ħ����������Ů��
		Out_Prize[1][3100]={chance=100,num=1}---//����ɽ�����Ů��
		Out_Prize[1][3107]={chance=100,num=1}---//���������ۣ�Ů��
		Out_Prize[1][3114]={chance=100,num=1}---//���𹦵��ۣ�Ů��
		Out_Prize[1][3121]={chance=100,num=1}---//ħ������ѥ��Ů��
		Out_Prize[1][3128]={chance=100,num=1}---//����ɽ�ѥ��Ů��
		Out_Prize[1][3135]={chance=100,num=1}---//���������ģ�Ů��
		Out_Prize[1][3142]={chance=100,num=1}---//���𹦵��ģ�Ů��
		Out_Prize[1][3149]={chance=100,num=1}---//ħ���������Ů��
		Out_Prize[1][3156]={chance=100,num=1}---//����ɽ᰿���Ů��
		Out_Prize[1][3163]={chance=100,num=1}---//��������ڣ�Ů��
		Out_Prize[1][3170]={chance=100,num=1}---//���𹦵¹ڣ�Ů��
		Out_Prize[1][8278]={chance=100,num=1}---//ԡѪ���������У�
		Out_Prize[1][8279]={chance=100,num=1}---//ԡѪ��������Ů��
		Out_Prize[1][8390]={chance=100,num=1}---//�����������У�
		Out_Prize[1][8391]={chance=100,num=1}---//����������Ů��
		Out_Prize[1][8510]={chance=100,num=1}---//�����ƽ��ڣ��У�
		Out_Prize[1][8512]={chance=100,num=1}---//�����ƽ��ڣ�Ů��
		Out_Prize[1][8648]={chance=100,num=1}---//������Ԫ�ڣ��У�
		Out_Prize[1][8649]={chance=100,num=1}---//������Ԫ�ڣ�Ů��
		Out_Prize[1][8856]={chance=100,num=1}---//ԡѪ����ѥ���У�
		Out_Prize[1][8857]={chance=100,num=1}---//ԡѪ����ѥ��Ů��
		Out_Prize[1][8968]={chance=100,num=1}---//�������ѥ���У�
		Out_Prize[1][8969]={chance=100,num=1}---//�������ѥ��Ů��
		Out_Prize[1][9080]={chance=100,num=1}---//�����ƽ��ģ��У�
		Out_Prize[1][9081]={chance=100,num=1}---//�����ƽ��ģ�Ů��
		Out_Prize[1][9192]={chance=100,num=1}---//������Ԫ�ģ��У�
		Out_Prize[1][9193]={chance=100,num=1}---//������Ԫ�ģ�Ů��
		Out_Prize[1][9304]={chance=100,num=1}---//ԡѪ�����ף��У�
		Out_Prize[1][9305]={chance=100,num=1}---//ԡѪ�����ף�Ů��
		Out_Prize[1][9416]={chance=100,num=1}---//������������У�
		Out_Prize[1][9417]={chance=100,num=1}---//�����������Ů��
		Out_Prize[1][9528]={chance=100,num=1}---//�����ƽ��ۣ��У�
		Out_Prize[1][9529]={chance=100,num=1}---//�����ƽ��ۣ�Ů��
		Out_Prize[1][9640]={chance=100,num=1}---//������Ԫ�ۣ��У�
		Out_Prize[1][9641]={chance=100,num=1}---//������Ԫ�ۣ�Ů��
	elseif id==19114 then
		Out_Prize[1][3451]={chance=100,num=1}---//��ˡ
		Out_Prize[1][3461]={chance=100,num=1}---//����
		Out_Prize[1][3532]={chance=100,num=1}---//����
		Out_Prize[1][3542]={chance=100,num=1}---//����
		Out_Prize[1][6313]={chance=100,num=1}---//��ѭ
		Out_Prize[1][6333]={chance=100,num=1}---//����
		Out_Prize[1][10926]={chance=100,num=1}---//���ƽ�
		Out_Prize[1][10927]={chance=100,num=1}---//�ƿս�
		Out_Prize[1][10928]={chance=100,num=1}---//�ƻ��
		Out_Prize[1][10929]={chance=100,num=1}---//���׽�
		Out_Prize[1][10930]={chance=100,num=1}---//���ƽ�
		Out_Prize[1][10931]={chance=100,num=1}---//���ƽ�
		Out_Prize[1][10932]={chance=100,num=1}---//���ƽ�
		Out_Prize[1][10933]={chance=100,num=1}---//��Ӣ��
		Out_Prize[1][10934]={chance=100,num=1}---//��Ӣ��
		Out_Prize[1][10935]={chance=100,num=1}---//���׽�
		Out_Prize[1][10936]={chance=100,num=1}---//˸���
		Out_Prize[1][10937]={chance=100,num=1}---//ӯ���
		Out_Prize[1][10938]={chance=100,num=1}---//Ѥ���
		Out_Prize[1][10939]={chance=100,num=1}---//˷�ƽ�
		Out_Prize[1][10940]={chance=100,num=1}---//���ƽ�
		Out_Prize[1][14379]={chance=100,num=1}---//���׶��Ŀ����У�
		Out_Prize[1][14386]={chance=100,num=1}---//�Ź����п����У�
		Out_Prize[1][14520]={chance=100,num=1}---//���׶��Ŀ���Ů��
		Out_Prize[1][14527]={chance=100,num=1}---//�Ź����п���Ů��
		Out_Prize[1][14752]={chance=100,num=1}---//���׶��ļף��У�
		Out_Prize[1][14759]={chance=100,num=1}---//�Ź����мף��У�
		Out_Prize[1][14893]={chance=100,num=1}---//���׶��ļף�Ů��
		Out_Prize[1][14900]={chance=100,num=1}---//�Ź����мף�Ů��
		Out_Prize[1][15034]={chance=100,num=1}---//���׶���ѥ���У�
		Out_Prize[1][15041]={chance=100,num=1}---//�Ź�����ѥ���У�
		Out_Prize[1][15175]={chance=100,num=1}---//���׶���ѥ��Ů��
		Out_Prize[1][15182]={chance=100,num=1}---//�Ź�����ѥ��Ů��
		Out_Prize[1][3010]={chance=100,num=1}---//��ת���������У�
		Out_Prize[1][3017]={chance=100,num=1}---//�Ż����������У�
		Out_Prize[1][3024]={chance=100,num=1}---//���������ۣ��У�
		Out_Prize[1][3031]={chance=100,num=1}---//�������ۣ��У�
		Out_Prize[1][3038]={chance=100,num=1}---//��ת����ѥ���У�
		Out_Prize[1][3045]={chance=100,num=1}---//�Ż�����ѥ���У�
		Out_Prize[1][3052]={chance=100,num=1}---//���������ģ��У�
		Out_Prize[1][3059]={chance=100,num=1}---//�������ģ��У�
		Out_Prize[1][3066]={chance=100,num=1}---//��ת���Ŀ����У�
		Out_Prize[1][3073]={chance=100,num=1}---//�Ż����Ŀ����У�
		Out_Prize[1][3080]={chance=100,num=1}---//�������ɹڣ��У�
		Out_Prize[1][3087]={chance=100,num=1}---//�����Ϲڣ��У�
		Out_Prize[1][3094]={chance=100,num=1}---//��ת��������Ů��
		Out_Prize[1][3101]={chance=100,num=1}---//�Ż���������Ů��
		Out_Prize[1][3108]={chance=100,num=1}---//���������ۣ�Ů��
		Out_Prize[1][3115]={chance=100,num=1}---//�������ۣ�Ů��
		Out_Prize[1][3122]={chance=100,num=1}---//��ת����ѥ��Ů��
		Out_Prize[1][3129]={chance=100,num=1}---//�Ż�����ѥ��Ů��
		Out_Prize[1][3136]={chance=100,num=1}---//���������ģ�Ů��
		Out_Prize[1][3143]={chance=100,num=1}---//�������ģ�Ů��
		Out_Prize[1][3150]={chance=100,num=1}---//��ת���Ŀ���Ů��
		Out_Prize[1][3157]={chance=100,num=1}---//�Ż����Ŀ���Ů��
		Out_Prize[1][3164]={chance=100,num=1}---//�������ɹڣ�Ů��
		Out_Prize[1][3171]={chance=100,num=1}---//�����Ϲڣ�Ů��
		Out_Prize[1][8306]={chance=100,num=1}---//���޳��ۿ����У�
		Out_Prize[1][8307]={chance=100,num=1}---//���޳��ۿ���Ů��
		Out_Prize[1][8418]={chance=100,num=1}---//�Ż���ɴ�����У�
		Out_Prize[1][8419]={chance=100,num=1}---//�Ż���ɴ����Ů��
		Out_Prize[1][8561]={chance=100,num=1}---//��Ӣ��Ԫ�ڣ��У�
		Out_Prize[1][8562]={chance=100,num=1}---//��Ӣ��Ԫ�ڣ�Ů��
		Out_Prize[1][8676]={chance=100,num=1}---//����Ⱥ��ڣ��У�
		Out_Prize[1][8677]={chance=100,num=1}---//����Ⱥ��ڣ�Ů��
		Out_Prize[1][8884]={chance=100,num=1}---//���޳���ѥ���У�
		Out_Prize[1][8885]={chance=100,num=1}---//���޳���ѥ��Ů��
		Out_Prize[1][8996]={chance=100,num=1}---//�Ż���ɴѥ���У�
		Out_Prize[1][8997]={chance=100,num=1}---//�Ż���ɴѥ��Ů��
		Out_Prize[1][9108]={chance=100,num=1}---//��Ӣ��Ԫ�ģ��У�
		Out_Prize[1][9109]={chance=100,num=1}---//��Ӣ��Ԫ�ģ�Ů��
		Out_Prize[1][9220]={chance=100,num=1}---//����Ⱥ��ģ��У�
		Out_Prize[1][9221]={chance=100,num=1}---//����Ⱥ��ģ�Ů��
		Out_Prize[1][9332]={chance=100,num=1}---//���޳��������У�
		Out_Prize[1][9333]={chance=100,num=1}---//���޳�������Ů��
		Out_Prize[1][9444]={chance=100,num=1}---//�Ż���ɴ�����У�
		Out_Prize[1][9445]={chance=100,num=1}---//�Ż���ɴ����Ů��
		Out_Prize[1][9556]={chance=100,num=1}---//��Ӣ��Ԫ�ۣ��У�
		Out_Prize[1][9557]={chance=100,num=1}---//��Ӣ��Ԫ�ۣ�Ů��
		Out_Prize[1][9668]={chance=100,num=1}---//����Ⱥ��ۣ��У�
		Out_Prize[1][9669]={chance=100,num=1}---//����Ⱥ��ۣ�Ů��
	elseif id==19115 then 
		Out_Prize[1][3452]={chance=100,num=1}---//����
		Out_Prize[1][3462]={chance=100,num=1}---//̫��
		Out_Prize[1][3533]={chance=100,num=1}---//��
		Out_Prize[1][3543]={chance=100,num=1}---//����
		Out_Prize[1][6314]={chance=100,num=1}---//��ѭ
		Out_Prize[1][6334]={chance=100,num=1}---//����
		Out_Prize[1][14380]={chance=100,num=1}---//ս�����ħ������У�
		Out_Prize[1][14387]={chance=100,num=1}---//��ڤת����������У�
		Out_Prize[1][14521]={chance=100,num=1}---//ս�����ħ�����Ů��
		Out_Prize[1][14528]={chance=100,num=1}---//��ڤת���������Ů��
		Out_Prize[1][14753]={chance=100,num=1}---//ս�����ħ��ף��У�
		Out_Prize[1][14760]={chance=100,num=1}---//��ڤת������ף��У�
		Out_Prize[1][14894]={chance=100,num=1}---//ս�����ħ��ף�Ů��
		Out_Prize[1][14901]={chance=100,num=1}---//��ڤת������ף�Ů��
		Out_Prize[1][15035]={chance=100,num=1}---//ս�����ħ��ѥ���У�
		Out_Prize[1][15042]={chance=100,num=1}---//��ڤת�����ѥ���У�
		Out_Prize[1][15176]={chance=100,num=1}---//ս�����ħ��ѥ��Ů��
		Out_Prize[1][15183]={chance=100,num=1}---//��ڤת�����ѥ��Ů��
		Out_Prize[1][3011]={chance=100,num=1}---//�������˽������У�
		Out_Prize[1][3018]={chance=100,num=1}---//Զ�ͽ�����������У�
		Out_Prize[1][3025]={chance=100,num=1}---//������ٽ����ۣ��У�
		Out_Prize[1][3032]={chance=100,num=1}---//��ɽ��������ۣ��У�
		Out_Prize[1][3039]={chance=100,num=1}---//�������˽�ѥ���У�
		Out_Prize[1][3046]={chance=100,num=1}---//Զ�ͽ������ѥ���У�
		Out_Prize[1][3053]={chance=100,num=1}---//������ٽ����ģ��У�
		Out_Prize[1][3060]={chance=100,num=1}---//��ɽ��������ģ��У�
		Out_Prize[1][3067]={chance=100,num=1}---//�������˽ٿ����У�
		Out_Prize[1][3074]={chance=100,num=1}---//Զ�ͽ����������У�
		Out_Prize[1][3081]={chance=100,num=1}---//������ٽ��޹ڣ��У�
		Out_Prize[1][3088]={chance=100,num=1}---//��ɽ�������ڣ��У�
		Out_Prize[1][3095]={chance=100,num=1}---//�������˽�����Ů��
		Out_Prize[1][3102]={chance=100,num=1}---//Զ�ͽ����������Ů��
		Out_Prize[1][3109]={chance=100,num=1}---//������ٽ����ۣ�Ů��
		Out_Prize[1][3116]={chance=100,num=1}---//��ɽ��������ۣ�Ů��
		Out_Prize[1][3123]={chance=100,num=1}---//�������˽�ѥ��Ů��
		Out_Prize[1][3130]={chance=100,num=1}---//Զ�ͽ������ѥ��Ů��
		Out_Prize[1][3137]={chance=100,num=1}---//������ٽ����ģ�Ů��
		Out_Prize[1][3144]={chance=100,num=1}---//��ɽ��������ģ�Ů��
		Out_Prize[1][3151]={chance=100,num=1}---//�������˽ٿ���Ů��
		Out_Prize[1][3158]={chance=100,num=1}---//Զ�ͽ���������Ů��
		Out_Prize[1][3165]={chance=100,num=1}---//������ٽ��޹ڣ�Ů��
		Out_Prize[1][3172]={chance=100,num=1}---//��ɽ�������ڣ�Ů��
		Out_Prize[1][8334]={chance=100,num=1}---//��������а������У�
		Out_Prize[1][8335]={chance=100,num=1}---//��������а�����Ů��
		Out_Prize[1][8446]={chance=100,num=1}---//��̨�����л������У�
		Out_Prize[1][8447]={chance=100,num=1}---//��̨�����л�����Ů��
		Out_Prize[1][8592]={chance=100,num=1}---//��Ԫ�����ֽ�ڣ��У�
		Out_Prize[1][8593]={chance=100,num=1}---//��Ԫ�����ֽ�ڣ�Ů��
		Out_Prize[1][8704]={chance=100,num=1}---//Ħڭɲ������ڣ��У�
		Out_Prize[1][8705]={chance=100,num=1}---//Ħڭɲ������ڣ�Ů��
		Out_Prize[1][8912]={chance=100,num=1}---//��������а��ѥ���У�
		Out_Prize[1][8913]={chance=100,num=1}---//��������а��ѥ��Ů��
		Out_Prize[1][9024]={chance=100,num=1}---//��̨�����л�ѥ���У�
		Out_Prize[1][9025]={chance=100,num=1}---//��̨�����л�ѥ��Ů��
		Out_Prize[1][9136]={chance=100,num=1}---//��Ԫ�����ֽ��ģ��У�
		Out_Prize[1][9137]={chance=100,num=1}---//��Ԫ�����ֽ��ģ�Ů��
		Out_Prize[1][9248]={chance=100,num=1}---//Ħڭɲ�������ģ��У�
		Out_Prize[1][9249]={chance=100,num=1}---//Ħڭɲ�������ģ�Ů��
		Out_Prize[1][9360]={chance=100,num=1}---//��������а�������У�
		Out_Prize[1][9361]={chance=100,num=1}---//��������а������Ů��
		Out_Prize[1][9472]={chance=100,num=1}---//��̨�����л������У�
		Out_Prize[1][9473]={chance=100,num=1}---//��̨�����л�����Ů��
		Out_Prize[1][9584]={chance=100,num=1}---//��Ԫ�����ֽ��ۣ��У�
		Out_Prize[1][9585]={chance=100,num=1}---//��Ԫ�����ֽ��ۣ�Ů��
		Out_Prize[1][9696]={chance=100,num=1}---//Ħڭɲ�������ۣ��У�
		Out_Prize[1][9697]={chance=100,num=1}---//Ħڭɲ�������ۣ�Ů��
		Out_Prize[1][6315]={chance=100,num=1}---//��ѭ(��ǿ����ָ1)
		Out_Prize[1][6305]={chance=100,num=1}---//����(��ǿ����ָ2)
		Out_Prize[1][3463]={chance=100,num=1}---//����(��ǿ����ָ3)
		Out_Prize[1][10957]={chance=100,num=1}---//�����(��ǿ����ָ4)
	end
 
	local i,v
	lot_prize[1]={}
	lot_prizechance[1]={}
	for i,v in pairs(Out_Prize[1]) do 
			table.insert(lot_prize[1],i)
			table.insert(lot_prizechance[1],v.chance)
	end 
--	if nowcurlist[fmax_count]=="111" then 
		prizeout=lot_prize[1][ZLottery_Get_RanPoint(lot_prizechance[1])]
		return 1,0,prizeout,Out_Prize[1][prizeout].num,0,0
--	end
end 
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryTypeGoldSeason1Cashing(cur_list,id)	---(����Ҷһ���Ʒ)
	---fmax_countΪ�ò�Ʊ����Чλ��
	local cp
	local nowcurlist={}
	local fmax_count=table.getn(cur_list)
	nowcurlist[0]=""
	for cp=1,fmax_count do
		nowcurlist[cp]=nowcurlist[cp-1]..cur_list[cp]
	end 
	
	local lot_prize={}
	local lot_prizechance={}
	local prizeout
	local Out_Prize={}
	local prizenum=1
	Out_Prize[1]={}
	
	if id==19079 then  
		Out_Prize[1][14062]=200 
		prizenum=5
	elseif id==19081 then 
		Out_Prize[1][14062]=200 
		prizenum=10
	elseif id==19082 then 
		Out_Prize[1][14062]=200 
		prizenum=20
	elseif id ==19087 then 
		Out_Prize[1][14062]=200 
		prizenum=40
	else
		Out_Prize[1][id]=100
	end 	
		
	local i,v,k
	
	for k=1,1 do
		lot_prize[k]={}
		lot_prizechance[k]={}
	end 
	
	for k=1,1 do
		for i,v in pairs(Out_Prize[k]) do 
			table.insert(lot_prize[k],i)
			table.insert(lot_prizechance[k],v)
		end 
	end 
	if nowcurlist[fmax_count]=="111" then 
		prizeout=lot_prize[1][ZLottery_Get_RanPoint(lot_prizechance[1])]
		return 1,0,prizeout,prizenum,0,0
	end
	return 1,0,id,1,0,0 
end
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType19125Cashing(cur_list)		---(����_��������)
	---fmax_countΪ�ò�Ʊ����Чλ��
	local cp
	local nowcurlist={}
	local fmax_count=table.getn(cur_list)
	nowcurlist[0]=""
	for cp=1,fmax_count do
		nowcurlist[cp]=nowcurlist[cp-1]..cur_list[cp]
	end 
	
	local lot_prize={}
	local lot_prizechance={}
	local prizeout
	local Out_Prize={}
	Out_Prize[1]={}
	Out_Prize[2]={}
	Out_Prize[3]={}
	Out_Prize[4]={}
	
	Out_Prize[1][19132]=100		---��èpanda
	
	Out_Prize[2][19127]=100		---�������(��)
	Out_Prize[2][19128]=200		---�������(Ů)
	
	Out_Prize[3][13343]=140		---�۱���
	
	Out_Prize[4][8079]=25		---�������
		
	local i,v,k
	
	for k=1,4 do
	lot_prize[k]={}
		lot_prizechance[k]={}
	end 
	
	for k=1,4 do
		for i,v in pairs(Out_Prize[k]) do 
			table.insert(lot_prize[k],i)
			table.insert(lot_prizechance[k],v)
		end 
	end 
	if nowcurlist[fmax_count]=="111" then 
		prizeout=lot_prize[1][ZLottery_Get_RanPoint(lot_prizechance[1])]
		return 1,0,prizeout,1,0,0
	elseif nowcurlist[fmax_count]=="222"  then 
		prizeout=lot_prize[2][ZLottery_Get_RanPoint(lot_prizechance[2])]
		return 2,0,prizeout,1,0,0
	elseif (ZLottery_FindSameNum(cur_list,1)==0 and ZLottery_FindSameNum(cur_list,2)==0) or
	ZLottery_FindSameNum(cur_list,1)==2 or ZLottery_FindSameNum(cur_list,2)==2 then 
		prizeout=lot_prize[3][ZLottery_Get_RanPoint(lot_prizechance[3])]
		return 3,0,prizeout,10,0,0
	else 
		prizeout=lot_prize[4][ZLottery_Get_RanPoint(lot_prizechance[4])]
		return 4,0,prizeout,2,0,0
	end
	return 4,0,8079,2,0,0 
end 
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType19297Cashing(cur_list)		---(�ƹ����)
	---fmax_countΪ�ò�Ʊ����Чλ��
	local cp
	local nowcurlist={}
	local fmax_count=table.getn(cur_list)
	nowcurlist[0]=""
	for cp=1,fmax_count do
		nowcurlist[cp]=nowcurlist[cp-1]..cur_list[cp]
	end 
	
	local lot_prize={}
	local lot_prizechance={}
	local prizeout
	local Out_Prize={}
	Out_Prize[1]={}
	Out_Prize[2]={}
	Out_Prize[3]={}
	Out_Prize[4]={}
	
	Out_Prize[1][19298]=100		---����֮��(����һ�ȯ)
	
	Out_Prize[2][16506]=100		---������ĵ���

	Out_Prize[3][18794]=100		---�ɶ�
	
	Out_Prize[4][8079]=100			---�������
		
	local i,v,k
	
	for k=1,4 do
	lot_prize[k]={}
		lot_prizechance[k]={}
	end 
	
	for k=1,4 do
		for i,v in pairs(Out_Prize[k]) do 
			table.insert(lot_prize[k],i)
			table.insert(lot_prizechance[k],v)
		end 
	end 
	if nowcurlist[fmax_count]=="111" then 
		prizeout=lot_prize[1][ZLottery_Get_RanPoint(lot_prizechance[1])]
		return 1,0,prizeout,1,0,0
	elseif nowcurlist[fmax_count]=="222"  then 
		prizeout=lot_prize[2][ZLottery_Get_RanPoint(lot_prizechance[2])]
		return 2,0,prizeout,1,0,0
	elseif (ZLottery_FindSameNum(cur_list,1)==0 and ZLottery_FindSameNum(cur_list,2)==0) or
	ZLottery_FindSameNum(cur_list,1)==2 or ZLottery_FindSameNum(cur_list,2)==2 then 
		prizeout=lot_prize[3][ZLottery_Get_RanPoint(lot_prizechance[3])]
		return 3,0,prizeout,3,0,0
	else 
		prizeout=lot_prize[4][ZLottery_Get_RanPoint(lot_prizechance[4])]
		return 4,0,prizeout,2,0,0
	end
	return 4,0,8079,2,0,0 
end 
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType19434Cashing(cur_list)		---(����_Ʊ�����/������ͼ)
	---fmax_countΪ�ò�Ʊ����Чλ��
	local cp
	local nowcurlist={}
	local fmax_count=table.getn(cur_list)
	nowcurlist[0]=""
	for cp=1,fmax_count do
		nowcurlist[cp]=nowcurlist[cp-1]..cur_list[cp]
	end 
	
	local lot_prize={}
	local lot_prizechance={}
	local prizeout
	local Out_Prize={}
	Out_Prize[1]={}
	Out_Prize[2]={}
	Out_Prize[3]={}
	Out_Prize[4]={}
	
	Out_Prize[1][19435]=100		---����(����һ�ȯ)
	
	Out_Prize[2][19129]=100		---��Ы���(��)
	Out_Prize[2][19130]=200		---�������(Ů)

	Out_Prize[3][18794]=100		---�ɶ�
	
	Out_Prize[4][13901]=25		---��Defҩ
	Out_Prize[4][13900]=100		---��Atkҩ
		
	local i,v,k
	for k=1,4 do
	lot_prize[k]={}
		lot_prizechance[k]={}
	end 
	
	for k=1,4 do
		for i,v in pairs(Out_Prize[k]) do 
			table.insert(lot_prize[k],i)
			table.insert(lot_prizechance[k],v)
		end 
	end 
	if nowcurlist[fmax_count]=="111" then 
		prizeout=lot_prize[1][ZLottery_Get_RanPoint(lot_prizechance[1])]
		return 1,0,prizeout,1,0,0
	elseif nowcurlist[fmax_count]=="222"  then 
		prizeout=lot_prize[2][ZLottery_Get_RanPoint(lot_prizechance[2])]
		return 2,0,prizeout,1,0,0
	elseif (ZLottery_FindSameNum(cur_list,1)==0 and ZLottery_FindSameNum(cur_list,2)==0) or
	ZLottery_FindSameNum(cur_list,1)==2 or ZLottery_FindSameNum(cur_list,2)==2 then 
		prizeout=lot_prize[3][ZLottery_Get_RanPoint(lot_prizechance[3])]
		return 3,0,prizeout,3,0,0
	else 
		prizeout=lot_prize[4][ZLottery_Get_RanPoint(lot_prizechance[4])]
		return 4,0,prizeout,1,0,0
	end
	return 4,0,13900,1,0,0 
end 
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType19558Cashing(cur_list)		---(������/˷��ͮ��)
	---fmax_countΪ�ò�Ʊ����Чλ��
	local cp
	local nowcurlist={}
	local fmax_count=table.getn(cur_list)
	nowcurlist[0]=""
	for cp=1,fmax_count do
		nowcurlist[cp]=nowcurlist[cp-1]..cur_list[cp]
	end 
	
	local lot_prize={}
	local lot_prizechance={}
	local prizeout
	local Out_Prize={}
	Out_Prize[1]={}
	Out_Prize[2]={}
	Out_Prize[3]={}
	Out_Prize[4]={}
	
	Out_Prize[1][19559]=100		---������(�ɽ��һ�ȯ)
	
	Out_Prize[2][18306]=100		---���֮Ӱ(����)

	Out_Prize[3][16551]=100		---������
	Out_Prize[3][19418]=900		---�鱦�س�
	
	Out_Prize[4][8079]=100		---�������

	local i,v,k
	for k=1,4 do
	lot_prize[k]={}
		lot_prizechance[k]={}
	end 
	
	for k=1,4 do
		for i,v in pairs(Out_Prize[k]) do 
			table.insert(lot_prize[k],i)
			table.insert(lot_prizechance[k],v)
		end 
	end 
	if nowcurlist[fmax_count]=="111" then 
		prizeout=lot_prize[1][ZLottery_Get_RanPoint(lot_prizechance[1])]
		return 1,0,prizeout,1,0,0
	elseif nowcurlist[fmax_count]=="222"  then 
		prizeout=lot_prize[2][ZLottery_Get_RanPoint(lot_prizechance[2])]
		return 2,0,prizeout,1,0,0
	elseif (ZLottery_FindSameNum(cur_list,1)==0 and ZLottery_FindSameNum(cur_list,2)==0) or
	ZLottery_FindSameNum(cur_list,1)==2 or ZLottery_FindSameNum(cur_list,2)==2 then 
		prizeout=lot_prize[3][ZLottery_Get_RanPoint(lot_prizechance[3])]
		if prizeout==16551 then 
			return 3,0,16551,1,0,0
		else
			return 3,0,19418,100,0,0
		end 
	else 
		prizeout=lot_prize[4][ZLottery_Get_RanPoint(lot_prizechance[4])]
		return 4,0,prizeout,2,0,0
	end
	return 4,0,8079,2,0,0 
end 
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryTypeGoldSeason2Cashing(cur_list,id)		---(����һ��ղ�Ʊ/���＼����)
	---fmax_countΪ�ò�Ʊ����Чλ��
	local cp
	local nowcurlist={}
	local fmax_count=table.getn(cur_list)
	nowcurlist[0]=""
	for cp=1,fmax_count do
		nowcurlist[cp]=nowcurlist[cp-1]..cur_list[cp]
	end 
	
	local lot_prize={}
	local lot_prizechance={}
	local prizeout
	local Out_Prize={}
	Out_Prize[1]={}
	
	if id==19425 then
		Out_Prize[1][19356]={chance=100,num=1}---//�ػ�<����>
		Out_Prize[1][19357]={chance=100,num=1}---//�ȳ�<����>
		Out_Prize[1][19358]={chance=100,num=1}---//��ҫ<����>
		Out_Prize[1][19359]={chance=100,num=1}---//���<����>
		Out_Prize[1][19360]={chance=100,num=1}---//���<����>
		Out_Prize[1][19361]={chance=100,num=1}---//����<����>
	elseif id==19426 then 
		Out_Prize[1][19362]={chance=100,num=1}---//����<����>
		Out_Prize[1][19363]={chance=100,num=1}---//����<����>
		Out_Prize[1][19364]={chance=100,num=1}---//��ע<����>
		Out_Prize[1][19365]={chance=100,num=1}---//����<����>
		Out_Prize[1][19366]={chance=100,num=1}---//��Ӱ<����>
		Out_Prize[1][19367]={chance=100,num=1}---//ˮ��<����>
	elseif id==19427 then 
		Out_Prize[1][19368]={chance=100,num=1}---//â��<����>
		Out_Prize[1][19369]={chance=100,num=1}---//ŭ��<����>
		Out_Prize[1][19370]={chance=100,num=1}---//ȫ��<����>
		Out_Prize[1][19371]={chance=100,num=1}---//˺��<����>
		Out_Prize[1][19372]={chance=100,num=1}---//�̶�<����>
		Out_Prize[1][19373]={chance=100,num=1}---//����<����>
	elseif id==19428 then 
		Out_Prize[1][19374]={chance=100,num=1}---//����<ľ��>
		Out_Prize[1][19375]={chance=100,num=1}---//����<ľ��>
		Out_Prize[1][19376]={chance=100,num=1}---//�ͻ�<ľ��>
		Out_Prize[1][19377]={chance=100,num=1}---//����<ľ��>
		Out_Prize[1][19378]={chance=100,num=1}---//�<ľ��>
		Out_Prize[1][19379]={chance=100,num=1}---//ƣ��<ľ��>
	elseif id==19429 then 
		Out_Prize[1][19380]={chance=100,num=1}---//��Ȫ<ˮ��>
		Out_Prize[1][19381]={chance=100,num=1}---//����<ˮ��>
		Out_Prize[1][19382]={chance=100,num=1}---//Ԥ��<ˮ��>
		Out_Prize[1][19383]={chance=100,num=1}---//����<ˮ��>
		Out_Prize[1][19384]={chance=100,num=1}---//����<ˮ��>
		Out_Prize[1][19385]={chance=100,num=1}---//˼��<ˮ��>
	elseif id==19430 then 
		Out_Prize[1][19386]={chance=100,num=1}---//���<����>
		Out_Prize[1][19387]={chance=100,num=1}---//��ͨ<����>
		Out_Prize[1][19388]={chance=100,num=1}---//����<����>
		Out_Prize[1][19389]={chance=100,num=1}---//����<����>
		Out_Prize[1][19390]={chance=100,num=1}---//���<����>
		Out_Prize[1][19391]={chance=100,num=1}---//ȼ��<����>
	elseif id==19431 then 
		Out_Prize[1][19392]={chance=100,num=1}---//��ף<����>
		Out_Prize[1][19393]={chance=100,num=1}---//����<����>
		Out_Prize[1][19394]={chance=100,num=1}---//�˺�<����>
		Out_Prize[1][19395]={chance=100,num=1}---//׷��<����>
		Out_Prize[1][19396]={chance=100,num=1}---//����<����>
		Out_Prize[1][19397]={chance=100,num=1}---//�ݵ�<����>
	elseif id==19432 then 
		Out_Prize[1][19398]={chance=100,num=1}---//����<�޺�>
		Out_Prize[1][19399]={chance=100,num=1}---//����<�޺�>
		Out_Prize[1][19400]={chance=100,num=1}---//����<�޺�>
		Out_Prize[1][19401]={chance=100,num=1}---//����<�޺�>
		Out_Prize[1][19402]={chance=100,num=1}---//����<�޺�>
		Out_Prize[1][19403]={chance=100,num=1}---//��ʹ<�޺�>
	elseif id==19433 then 
		Out_Prize[1][19404]={chance=100,num=1}---//����<�ƶ�>
		Out_Prize[1][19405]={chance=100,num=1}---//����<�ƶ�>
		Out_Prize[1][19406]={chance=100,num=1}---//����<�ƶ�>
		Out_Prize[1][19407]={chance=100,num=1}---//����<�ƶ�>
		Out_Prize[1][19408]={chance=100,num=1}---//���<�ƶ�>
		Out_Prize[1][19409]={chance=100,num=1}---//��ã<�ƶ�>
	end
		Out_Prize[1][19410]={chance=100,num=1}---//����<ͨ��>
		Out_Prize[1][19411]={chance=100,num=1}---//����<ͨ��>
		Out_Prize[1][19412]={chance=100,num=1}---//����<ͨ��>
		Out_Prize[1][19413]={chance=100,num=1}---//����<ͨ��>
		Out_Prize[1][19414]={chance=100,num=1}---//����<ͨ��>
		Out_Prize[1][19415]={chance=100,num=1}---//��ȡ<ͨ��>
	
	local i,v
	lot_prize[1]={}
	lot_prizechance[1]={}
	for i,v in pairs(Out_Prize[1]) do 
			table.insert(lot_prize[1],i)
			table.insert(lot_prizechance[1],v.chance)
	end 
	if nowcurlist[fmax_count]=="111" then 
		prizeout=lot_prize[1][ZLottery_Get_RanPoint(lot_prizechance[1])]
		return 1,0,prizeout,Out_Prize[1][prizeout].num,0,0
	end
end 
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType19713Cashing(cur_list)		---(����_����֮��)
	---fmax_countΪ�ò�Ʊ����Чλ��
	local cp
	local nowcurlist={}
	local fmax_count=table.getn(cur_list)
	nowcurlist[0]=""
	for cp=1,fmax_count do
		nowcurlist[cp]=nowcurlist[cp-1]..cur_list[cp]
	end 
	
	local lot_prize={}
	local lot_prizechance={}
	local prizeout
	local Out_Prize={}
	Out_Prize[1]={}
	Out_Prize[2]={}
	Out_Prize[3]={}
	Out_Prize[4]={}
	
	Out_Prize[1][19714]=100		---����һ�ȯ
	
	Out_Prize[2][21200]=100			---�����
	
	Out_Prize[3][18794]=100		---�ɶ�
	
	Out_Prize[4][8079]=	40	---�������
	Out_Prize[4][13901]=20  ---����
	Out_Prize[4][13900]=40  ---����
	
	
	local i,v,k
	for k=1,4 do
	lot_prize[k]={}
		lot_prizechance[k]={}
	end 
	
	for k=1,4 do
		for i,v in pairs(Out_Prize[k]) do 
			table.insert(lot_prize[k],i)
			table.insert(lot_prizechance[k],v)
		end 
	end 
	if nowcurlist[fmax_count]=="111" then 
		prizeout=lot_prize[1][ZLottery_Get_RanPoint(lot_prizechance[1])]
		return 1,0,prizeout,1,0,0
	elseif nowcurlist[fmax_count]=="222"  then 
		prizeout=lot_prize[2][ZLottery_Get_RanPoint(lot_prizechance[2])]
		return 2,0,prizeout,15,0,0
	elseif (ZLottery_FindSameNum(cur_list,1)==0 and ZLottery_FindSameNum(cur_list,2)==0) or
	ZLottery_FindSameNum(cur_list,1)==2 or ZLottery_FindSameNum(cur_list,2)==2 then 
		prizeout=lot_prize[3][ZLottery_Get_RanPoint(lot_prizechance[3])]
		return 3,0,prizeout,3,0,0
	else 
		prizeout=lot_prize[4][ZLottery_Get_RanPoint(lot_prizechance[4])]
		if prizeout==8079 then 
			return 4,0,prizeout,2,0,0
		else
			return 4,0,prizeout,1,0,0
		end
	end
	return 4,0,8079,2,0,0 
end 
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType20097Cashing(cur_list)		---(08������������)
	---fmax_countΪ�ò�Ʊ����Чλ��
	local cp
	local nowcurlist={}
	local fmax_count=table.getn(cur_list)
	nowcurlist[0]=""
	for cp=1,fmax_count do
		nowcurlist[cp]=nowcurlist[cp-1]..cur_list[cp]
	end 
	
	local lot_prize={}
	local lot_prizechance={}
	local prizeout
	local Out_Prize={}
	Out_Prize[1]={}
	Out_Prize[2]={}
	Out_Prize[3]={}
	Out_Prize[4]={}
	
	Out_Prize[1][20096]=100		---�±�������
	
	Out_Prize[2][6315]=200			---100��������ָ
	Out_Prize[2][6305]=200			---100��������ָ
	Out_Prize[2][3463]=200			---100�����˽�ָ
	Out_Prize[2][10957]=100			---100��ȫ����ָ

	Out_Prize[3][16551]=100			---������
	Out_Prize[3][13301]=60			---������1
	Out_Prize[3][13302]=60			---������2
	Out_Prize[3][13303]=60			---������3
	Out_Prize[3][13304]=60			---������4
	Out_Prize[3][13305]=60			---������5
	
	Out_Prize[4][20098]=100			---������һ�ȯ
	Out_Prize[4][20099]=100			---Ǭ��ͨ���һ�ȯ
	
	local i,v,k
	for k=1,4 do
	lot_prize[k]={}
		lot_prizechance[k]={}
	end 
	for k=1,4 do
		for i,v in pairs(Out_Prize[k]) do 
			table.insert(lot_prize[k],i)
			table.insert(lot_prizechance[k],v)
		end 
	end 
	if nowcurlist[fmax_count]=="111" then 
		prizeout=lot_prize[1][ZLottery_Get_RanPoint(lot_prizechance[1])]
		return 1,0,prizeout,1,0,0
	elseif nowcurlist[fmax_count]=="222"  then 
		prizeout=lot_prize[2][ZLottery_Get_RanPoint(lot_prizechance[2])]
		return 2,0,prizeout,1,0,0
	elseif (ZLottery_FindSameNum(cur_list,1)==0 and ZLottery_FindSameNum(cur_list,2)==0) or
	ZLottery_FindSameNum(cur_list,1)==2 or ZLottery_FindSameNum(cur_list,2)==2 then 
		prizeout=lot_prize[3][ZLottery_Get_RanPoint(lot_prizechance[3])]
		if prizeout==16551 then 
			return 3,0,prizeout,1,0,0
		else
			return 3,0,prizeout,5,0,0
		end 	
	else 
		prizeout=lot_prize[4][ZLottery_Get_RanPoint(lot_prizechance[4])]
		return 4,0,prizeout,1,0,0
	end
	return 4,0,20098,1,0,0 
end 
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType20109Cashing(cur_list)		---(201012����_�������)
	---fmax_countΪ�ò�Ʊ����Чλ��
	local cp
	local nowcurlist={}
	local fmax_count=table.getn(cur_list)
	nowcurlist[0]=""
	for cp=1,fmax_count do
		nowcurlist[cp]=nowcurlist[cp-1]..cur_list[cp]
	end 
	
	local lot_prize={}
	local lot_prizechance={}
	local prizeout
	local Out_Prize={}
	Out_Prize[1]={}
	Out_Prize[2]={}
	Out_Prize[3]={}
	Out_Prize[4]={}
	
	Out_Prize[1][20110]=80		---�ɽ�������һ�ȯ
	Out_Prize[1][18848]=10		---����װ�����
	Out_Prize[1][18849]=10		---����װ�����
	
	Out_Prize[2][20090]=40		---��������Ԫ��

	Out_Prize[3][18794]=100		---�ɶ�
	
	Out_Prize[4][8079]=100		---�������
	local i,v,k
	for k=1,4 do
	lot_prize[k]={}
		lot_prizechance[k]={}
	end 
	for k=1,4 do
		for i,v in pairs(Out_Prize[k]) do 
			table.insert(lot_prize[k],i)
			table.insert(lot_prizechance[k],v)
		end 
	end 
	if nowcurlist[fmax_count]=="111" then 
		prizeout=lot_prize[1][ZLottery_Get_RanPoint(lot_prizechance[1])]
		return 1,0,prizeout,1,0,0
	elseif nowcurlist[fmax_count]=="222"  then 
		prizeout=lot_prize[2][ZLottery_Get_RanPoint(lot_prizechance[2])]
		return 2,0,prizeout,1,0,0
	elseif (ZLottery_FindSameNum(cur_list,1)==0 and ZLottery_FindSameNum(cur_list,2)==0) or
	ZLottery_FindSameNum(cur_list,1)==2 or ZLottery_FindSameNum(cur_list,2)==2 then 
		prizeout=lot_prize[3][ZLottery_Get_RanPoint(lot_prizechance[3])]
		return 3,0,prizeout,3,0,0
	else 
		prizeout=lot_prize[4][ZLottery_Get_RanPoint(lot_prizechance[4])]
		return 4,0,prizeout,2,0,0
	end
	return 4,0,8079,2,0,0 
end 
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType20284Cashing(cur_list)		---(����_����ӡ)
	---fmax_countΪ�ò�Ʊ����Чλ��
	local cp
	local nowcurlist={}
	local fmax_count=table.getn(cur_list)
	nowcurlist[0]=""
	for cp=1,fmax_count do
		nowcurlist[cp]=nowcurlist[cp-1]..cur_list[cp]
	end 
	
	local lot_prize={}
	local lot_prizechance={}
	local prizeout
	local Out_Prize={}
	Out_Prize[1]={}
	Out_Prize[2]={}
	Out_Prize[3]={}
	Out_Prize[4]={}
	
	Out_Prize[1][20283]=100		---�ɽ�����ɶһ�ȯ
	
	Out_Prize[2][20108]=100		---�������������
	Out_Prize[2][19510]=100		---���������
	
	Out_Prize[3][18794]=500		---�ɶ�
	Out_Prize[3][7939]=100		---�챦������
	Out_Prize[3][19257]=200		---�����ڵ�
	
	Out_Prize[4][8079]=100		---�������
	
	local i,v,k
	for k=1,4 do
	lot_prize[k]={}
		lot_prizechance[k]={}
	end 
	for k=1,4 do
		for i,v in pairs(Out_Prize[k]) do 
			table.insert(lot_prize[k],i)
			table.insert(lot_prizechance[k],v)
		end 
	end 
	if nowcurlist[fmax_count]=="111" then 
		prizeout=lot_prize[1][ZLottery_Get_RanPoint(lot_prizechance[1])]
		return 1,0,prizeout,1,0,0
	elseif nowcurlist[fmax_count]=="222"  then 
		prizeout=lot_prize[2][ZLottery_Get_RanPoint(lot_prizechance[2])]
		return 2,0,prizeout,1,0,0
	elseif (ZLottery_FindSameNum(cur_list,1)==0 and ZLottery_FindSameNum(cur_list,2)==0) or
	ZLottery_FindSameNum(cur_list,1)==2 or ZLottery_FindSameNum(cur_list,2)==2 then 
		prizeout=lot_prize[3][ZLottery_Get_RanPoint(lot_prizechance[3])]
		if prizeout==19257 then 
			return 3,0,prizeout,1,0,0
		else
			return 3,0,prizeout,3,0,0
		end 
	else 
		prizeout=lot_prize[4][ZLottery_Get_RanPoint(lot_prizechance[4])]
		return 4,0,prizeout,2,0,0
	end
	return 4,0,8079,2,0,0 
end 
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType20480Cashing(cur_list)		---(��ȸ��)
	---fmax_countΪ�ò�Ʊ����Чλ��
	local cp
	local nowcurlist={}
	local fmax_count=table.getn(cur_list)
	nowcurlist[0]=""
	for cp=1,fmax_count do
		nowcurlist[cp]=nowcurlist[cp-1]..cur_list[cp]
	end 
	
	local lot_prize={}
	local lot_prizechance={}
	local prizeout
	local Out_Prize={}
	Out_Prize[1]={}
	Out_Prize[2]={}
	Out_Prize[3]={}
	Out_Prize[4]={}
	
	Out_Prize[1][20486]=100		---��ȸ�һ�ȯ

	Out_Prize[2][7931]=40			---��������
	Out_Prize[2][7937]=60			---������Ů

	Out_Prize[3][18794]=100		---�ɶ�

	Out_Prize[4][13901]=25		---��Defҩ
	Out_Prize[4][13900]=100		---��Atkҩ

	local i,v,k
	for k=1,4 do
	lot_prize[k]={}
		lot_prizechance[k]={}
	end 
	
	for k=1,4 do
		for i,v in pairs(Out_Prize[k]) do 
			table.insert(lot_prize[k],i)
			table.insert(lot_prizechance[k],v)
		end 
	end 
	if nowcurlist[fmax_count]=="111" then 
		prizeout=lot_prize[1][ZLottery_Get_RanPoint(lot_prizechance[1])]
		return 1,0,prizeout,1,0,0
	elseif nowcurlist[fmax_count]=="222"  then 
		prizeout=lot_prize[2][ZLottery_Get_RanPoint(lot_prizechance[2])]
		return 2,0,prizeout,1,0,0
	elseif (ZLottery_FindSameNum(cur_list,1)==0 and ZLottery_FindSameNum(cur_list,2)==0)
			or ZLottery_FindSameNum(cur_list,1)==2 or ZLottery_FindSameNum(cur_list,2)==2 then
		prizeout=lot_prize[3][ZLottery_Get_RanPoint(lot_prizechance[3])]
		return 3,0,prizeout,3,0,0
	else 
		prizeout=lot_prize[4][ZLottery_Get_RanPoint(lot_prizechance[4])]
		return 4,0,prizeout,1,0,0
	end
	return 4,0,13900,1,0,0 
end 
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType20482Cashing(cur_list)		---(���ʹž�)
	---fmax_countΪ�ò�Ʊ����Чλ��
	local cp
	local nowcurlist={}
	local fmax_count=table.getn(cur_list)
	nowcurlist[0]=""
	for cp=1,fmax_count do
		nowcurlist[cp]=nowcurlist[cp-1]..cur_list[cp]
	end 
	
	local lot_prize={}
	local lot_prizechance={}
	local prizeout
	local Out_Prize={}
	Out_Prize[1]={}
	Out_Prize[2]={}
	Out_Prize[3]={}
	Out_Prize[4]={}
	
	Out_Prize[1][20487]=100 ---//�ɽ���â�һ�ȯ
	
	Out_Prize[2][18797]=100 ---//���淨���һ�ȯ
	
	Out_Prize[3][13343]=100	---//�۱���
	
	Out_Prize[4][8079]=100	---//�������
		
	local i,v,k
	
	for k=1,4 do
		lot_prize[k]={}
		lot_prizechance[k]={}
	end 
	
	for k=1,4 do
		for i,v in pairs(Out_Prize[k]) do 
			table.insert(lot_prize[k],i)
			table.insert(lot_prizechance[k],v)
		end 
	end 
	if nowcurlist[fmax_count]=="111" then 
		prizeout=lot_prize[1][ZLottery_Get_RanPoint(lot_prizechance[1])]
		return 1,0,prizeout,1,0,0
	elseif nowcurlist[fmax_count]=="222"  then 
		prizeout=lot_prize[2][ZLottery_Get_RanPoint(lot_prizechance[2])]
		return 2,0,prizeout,1,0,0
	elseif ZLottery_FindSameNum(cur_list,1)==2 or ZLottery_FindSameNum(cur_list,2)==2 then 
		prizeout=lot_prize[3][ZLottery_Get_RanPoint(lot_prizechance[3])]
		return 3,0,prizeout,10,0,0
	else 
		prizeout=lot_prize[4][ZLottery_Get_RanPoint(lot_prizechance[4])]
		return 4,0,prizeout,2,0,0
	end
	return 4,0,8079,2,0,0 
end 
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType20460Cashing(cur_list)		---(��������)
	---fmax_countΪ�ò�Ʊ����Чλ��
	local cp
	local nowcurlist={}
	local fmax_count=table.getn(cur_list)
	nowcurlist[0]=""
	for cp=1,fmax_count do
		nowcurlist[cp]=nowcurlist[cp-1]..cur_list[cp]
	end 

	if nowcurlist[fmax_count]=="11" then 
		return 1,0,19277,1,0,0
	elseif nowcurlist[fmax_count]=="12" then
		return 4,0,19278,1,0,0
	elseif nowcurlist[fmax_count]=="13" then
		return 3,0,19279,1,0,0
	elseif nowcurlist[fmax_count]=="14" then
		return 4,0,19280,1,0,0
	elseif nowcurlist[fmax_count]=="21" then
		return 2,0,19281,1,0,0
	elseif nowcurlist[fmax_count]=="22" then
		return 4,0,19282,1,0,0
	elseif nowcurlist[fmax_count]=="23" then
		return 3,0,19283,1,0,0
	elseif nowcurlist[fmax_count]=="24" then
		return 4,0,19284,1,0,0
	elseif nowcurlist[fmax_count]=="31" then
		return 2,0,19285,1,0,0
	elseif nowcurlist[fmax_count]=="32" then
		return 4,0,19286,1,0,0
	elseif nowcurlist[fmax_count]=="33" then
		return 3,0,19277,1,0,0
	elseif nowcurlist[fmax_count]=="34" then
		return 4,0,19278,1,0,0
	elseif nowcurlist[fmax_count]=="41" then
		return 2,0,19279,1,0,0
	elseif nowcurlist[fmax_count]=="42" then
		return 4,0,19280,1,0,0
	elseif nowcurlist[fmax_count]=="43" then
		return 3,0,19281,1,0,0
	else
		return 4,0,19282,1,0,0
	end
	
end 
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType21194Cashing(cur_list)		---(�޹���ϻ)
	---fmax_countΪ�ò�Ʊ����Чλ��
	local cp
	local nowcurlist={}
	local fmax_count=table.getn(cur_list)
	nowcurlist[0]=""
	for cp=1,fmax_count do
		nowcurlist[cp]=nowcurlist[cp-1]..cur_list[cp]
	end 
	
	local lot_prize={}
	local lot_prizechance={}
	local prizeout
	local Out_Prize={}
	Out_Prize[1]={}
	Out_Prize[2]={}
	Out_Prize[3]={}
	Out_Prize[4]={}
	
	Out_Prize[1][21189]=100		---��������һ�ȯ

	Out_Prize[2][20491]=100		---������������

	Out_Prize[3][18794]=100		---�ɶ�����

	Out_Prize[4][13901]=20		---�������
	Out_Prize[4][13900]=80		---���Ǳ���

	local i,v,k
	for k=1,4 do
	lot_prize[k]={}
		lot_prizechance[k]={}
	end 
	
	for k=1,4 do
		for i,v in pairs(Out_Prize[k]) do 
			table.insert(lot_prize[k],i)
			table.insert(lot_prizechance[k],v)
		end 
	end 
	if nowcurlist[fmax_count]=="111" then 
		prizeout=lot_prize[1][ZLottery_Get_RanPoint(lot_prizechance[1])]
		return 1,0,prizeout,1,0,0
	elseif nowcurlist[fmax_count]=="222"  then 
		prizeout=lot_prize[2][ZLottery_Get_RanPoint(lot_prizechance[2])]
		return 2,0,prizeout,1,0,0
	elseif (ZLottery_FindSameNum(cur_list,1)==0 and ZLottery_FindSameNum(cur_list,2)==0)
			or ZLottery_FindSameNum(cur_list,1)==2 or ZLottery_FindSameNum(cur_list,2)==2 then
		prizeout=lot_prize[3][ZLottery_Get_RanPoint(lot_prizechance[3])]
		return 3,0,prizeout,3,0,0
	else 
		prizeout=lot_prize[4][ZLottery_Get_RanPoint(lot_prizechance[4])]
		return 4,0,prizeout,1,0,0
	end
	return 4,0,13900,1,0,0 
end 
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType21697Cashing(cur_list)		---(������ʯ)
	---fmax_countΪ�ò�Ʊ����Чλ��
	local cp
	local nowcurlist={}
	local fmax_count=table.getn(cur_list)
	nowcurlist[0]=""
	for cp=1,fmax_count do
		nowcurlist[cp]=nowcurlist[cp-1]..cur_list[cp]
	end 
	
	local lot_prize={}
	local lot_prizechance={}
	local prizeout
	local Out_Prize={}

	Out_Prize[1]={}
	Out_Prize[2]={}
	Out_Prize[3]={}
	Out_Prize[4]={}
	
	Out_Prize[1][21890]=100 ---//�ɽ���ضһ�ȯ
	Out_Prize[2][19257]=100 ---//�����ڵ�
	Out_Prize[3][13343]=100	---//�۱���
	Out_Prize[4][8079]=100	---//�������
		
	local i,v,k
	
	for k=1,4 do
		lot_prize[k]={}
		lot_prizechance[k]={}
	end 
	
	for k=1,4 do
		for i,v in pairs(Out_Prize[k]) do 
			table.insert(lot_prize[k],i)
			table.insert(lot_prizechance[k],v)
		end 
	end 
	if nowcurlist[fmax_count]=="111" then 
		prizeout=lot_prize[1][ZLottery_Get_RanPoint(lot_prizechance[1])]
		return 1,0,prizeout,1,0,0
	elseif nowcurlist[fmax_count]=="222"  then 
		prizeout=lot_prize[2][ZLottery_Get_RanPoint(lot_prizechance[2])]
		return 2,0,prizeout,10,0,0
	elseif ZLottery_FindSameNum(cur_list,1)==2 or ZLottery_FindSameNum(cur_list,2)==2 then 
		prizeout=lot_prize[3][ZLottery_Get_RanPoint(lot_prizechance[3])]
		return 3,0,prizeout,10,0,0
	else 
		prizeout=lot_prize[4][ZLottery_Get_RanPoint(lot_prizechance[4])]
		return 4,0,prizeout,2,0,0
	end
	return 4,0,8079,2,0,0 
end 
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType21752Cashing(cur_list)		---(�����ƪ/ѩ��������Ҳ�Ʊ)
	---fmax_countΪ�ò�Ʊ����Чλ��
	local cp
	local nowcurlist={}
	local fmax_count=table.getn(cur_list)
	nowcurlist[0]=""
	for cp=1,fmax_count do
		nowcurlist[cp]=nowcurlist[cp-1]..cur_list[cp]
	end 
	
	local lot_prize={}
	local lot_prizechance={}
	local prizeout
	local Out_Prize={}

	Out_Prize[1]={}
	Out_Prize[2]={}
	Out_Prize[3]={}
	Out_Prize[4]={}

	Out_Prize[1][20096]=100			---�±�������:���
	Out_Prize[2][21742]=33			---���н��ҡ�����
	Out_Prize[2][21743]=33			---̫����ҡ�����
	Out_Prize[2][21744]=33			---��ң���ҡ�����
	Out_Prize[3][21200]=50			---�����(��ħ������)
	Out_Prize[3][21345]=50			---�컯���10
	Out_Prize[4][20098]=50			---�����Ĺ�����
	Out_Prize[4][19557]=50			---�¹�ף��
	
	local i,v,k
	for k=1,4 do
	lot_prize[k]={}
		lot_prizechance[k]={}
	end 
	for k=1,4 do
		for i,v in pairs(Out_Prize[k]) do 
			table.insert(lot_prize[k],i)
			table.insert(lot_prizechance[k],v)
		end 
	end 
	if nowcurlist[fmax_count]=="111" then 
		prizeout=lot_prize[1][ZLottery_Get_RanPoint(lot_prizechance[1])]
		return 1,0,prizeout,1,0,0
	elseif nowcurlist[fmax_count]=="222"  then 
		prizeout=lot_prize[2][ZLottery_Get_RanPoint(lot_prizechance[2])]
		return 2,0,prizeout,1,0,0
	elseif (ZLottery_FindSameNum(cur_list,1)==0 and ZLottery_FindSameNum(cur_list,2)==0)
			or ZLottery_FindSameNum(cur_list,1)==2 or ZLottery_FindSameNum(cur_list,2)==2 then
		prizeout=lot_prize[3][ZLottery_Get_RanPoint(lot_prizechance[3])]
		if prizeout==21345 then
			return 3,0,prizeout,10,0,0
		else
			return 3,0,prizeout,1,0,0
		end
	else
		prizeout=lot_prize[4][ZLottery_Get_RanPoint(lot_prizechance[4])]
		return 4,0,prizeout,1,0,0
	end
	return 4,0,20098,1,0,0
end 
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType22126Cashing(cur_list)		---(��ѩ���)
	---fmax_countΪ�ò�Ʊ����Чλ��
	local cp
	local nowcurlist={}
	local fmax_count=table.getn(cur_list)
	nowcurlist[0]=""
	for cp=1,fmax_count do
		nowcurlist[cp]=nowcurlist[cp-1]..cur_list[cp]
	end 
	
	local lot_prize={}
	local lot_prizechance={}
	local prizeout
	local Out_Prize={}
	Out_Prize[1]={}
	Out_Prize[2]={}
	Out_Prize[3]={}
	Out_Prize[4]={}
	
	Out_Prize[1][22321]=100		---�׵�

	Out_Prize[2][22121]=100		---���������±���

	Out_Prize[3][18794]=100		---�ɶ�����

	Out_Prize[4][8079]=100		---�����������

	local i,v,k
	for k=1,4 do
	lot_prize[k]={}
		lot_prizechance[k]={}
	end 
	
	for k=1,4 do
		for i,v in pairs(Out_Prize[k]) do 
			table.insert(lot_prize[k],i)
			table.insert(lot_prizechance[k],v)
		end 
	end 
	if nowcurlist[fmax_count]=="111" then 
		prizeout=lot_prize[1][ZLottery_Get_RanPoint(lot_prizechance[1])]
		return 1,0,prizeout,1,0,0
	elseif nowcurlist[fmax_count]=="222"  then 
		prizeout=lot_prize[2][ZLottery_Get_RanPoint(lot_prizechance[2])]
		return 2,0,prizeout,1,0,0
	elseif (ZLottery_FindSameNum(cur_list,1)==0 and ZLottery_FindSameNum(cur_list,2)==0)
			or ZLottery_FindSameNum(cur_list,1)==2 or ZLottery_FindSameNum(cur_list,2)==2 then
		prizeout=lot_prize[3][ZLottery_Get_RanPoint(lot_prizechance[3])]
		return 3,0,prizeout,3,0,0
	else 
		prizeout=lot_prize[4][ZLottery_Get_RanPoint(lot_prizechance[4])]
		return 4,0,prizeout,2,0,0
	end
	return 4,0,13900,1,0,0 
end 
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType22127Cashing(cur_list)		---(�׹�ϻ��)
	---fmax_countΪ�ò�Ʊ����Чλ��
	local cp
	local nowcurlist={}
	local fmax_count=table.getn(cur_list)
	nowcurlist[0]=""
	for cp=1,fmax_count do
		nowcurlist[cp]=nowcurlist[cp-1]..cur_list[cp]
	end 
	
	local lot_prize={}
	local lot_prizechance={}
	local prizeout
	local Out_Prize={}
	Out_Prize[1]={}
	Out_Prize[2]={}
	Out_Prize[3]={}
	Out_Prize[4]={}
	
	Out_Prize[1][22438]=100		---������һ�ȯ

	Out_Prize[2][7931]=40			---��������
	Out_Prize[2][7937]=60			---������Ů

	Out_Prize[3][18794]=100		---�ɶ�

	Out_Prize[4][13901]=20		---��Defҩ
	Out_Prize[4][13900]=80		---��Atkҩ

	local i,v,k
	for k=1,4 do
	lot_prize[k]={}
		lot_prizechance[k]={}
	end 
	
	for k=1,4 do
		for i,v in pairs(Out_Prize[k]) do 
			table.insert(lot_prize[k],i)
			table.insert(lot_prizechance[k],v)
		end 
	end 
	if nowcurlist[fmax_count]=="111" then 
		prizeout=lot_prize[1][ZLottery_Get_RanPoint(lot_prizechance[1])]
		return 1,0,prizeout,1,0,0
	elseif nowcurlist[fmax_count]=="222"  then 
		prizeout=lot_prize[2][ZLottery_Get_RanPoint(lot_prizechance[2])]
		return 2,0,prizeout,1,0,0
	elseif (ZLottery_FindSameNum(cur_list,1)==0 and ZLottery_FindSameNum(cur_list,2)==0)
			or ZLottery_FindSameNum(cur_list,1)==2 or ZLottery_FindSameNum(cur_list,2)==2 then
		prizeout=lot_prize[3][ZLottery_Get_RanPoint(lot_prizechance[3])]
		return 3,0,prizeout,3,0,0
	else 
		prizeout=lot_prize[4][ZLottery_Get_RanPoint(lot_prizechance[4])]
		return 4,0,prizeout,1,0,0
	end
	return 4,0,13900,1,0,0 
end 
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryTypeItemSeason2Cashing(cur_list)		---(09��������Ҳ�Ʊ)
	---fmax_countΪ�ò�Ʊ����Чλ��
	local cp
	local nowcurlist={}
	local fmax_count=table.getn(cur_list)
	nowcurlist[0]=""
	for cp=1,fmax_count do
		nowcurlist[cp]=nowcurlist[cp-1]..cur_list[cp]
	end 
	
	local lot_prize={}
	local lot_prizechance={}
	local prizeout
	local Out_Prize={}
	Out_Prize[1]={}
	Out_Prize[2]={}
	Out_Prize[3]={}
	Out_Prize[4]={}
	
	Out_Prize[1][20503]=100		---��Ѫ��һ�ȯ
	
	Out_Prize[2][22097]=50		---�컯��ʯ
	Out_Prize[2][6315]=10			---��ָ1
	Out_Prize[2][6305]=10			---��ָ2
	Out_Prize[2][22074]=10		---��ָ3
	Out_Prize[2][22073]=10		---��ָ4
	Out_Prize[2][3463]=10			---��ָ5
	Out_Prize[2][10957]=10		---��ָ6

	Out_Prize[3][19254]=100		---ǧ��֥��
	Out_Prize[3][13343]=50		---�۱���
	Out_Prize[3][21153]=40		---ʤʯ

	Out_Prize[4][20099]=10		---�ɴ���Ǭ��ͨ��
	Out_Prize[4][20098]=35		---������һ�ȯ
	Out_Prize[4][21345]=30		---�컯��
		
	local i,v,k
	
	for k=1,4 do
		lot_prize[k]={}
		lot_prizechance[k]={}
	end 
	
	for k=1,4 do
		for i,v in pairs(Out_Prize[k]) do 
			table.insert(lot_prize[k],i)
			table.insert(lot_prizechance[k],v)
		end 
	end 
	if nowcurlist[fmax_count]=="444" then 
		prizeout=lot_prize[1][ZLottery_Get_RanPoint(lot_prizechance[1])]
		return 1,0,prizeout,1,0,0
	elseif nowcurlist[fmax_count]=="333"  then 
		prizeout=lot_prize[2][ZLottery_Get_RanPoint(lot_prizechance[2])]
		return 2,0,prizeout,1,0,0
	elseif (ZLottery_FindSameNum(cur_list,4)==0 and ZLottery_FindSameNum(cur_list,3)==0) or
	(ZLottery_FindSameNum(cur_list,4)==1 and ZLottery_FindSameNum(cur_list,3)==1 and 
	ZLottery_FindSameNum(cur_list,2)==1) then 
		prizeout=lot_prize[3][ZLottery_Get_RanPoint(lot_prizechance[3])]
		if prizeout == 19254 then				return 3,0,prizeout,15,0,0
		elseif prizeout == 13343 then		return 3,0,prizeout,10,0,0
		else 														return 3,0,prizeout,3,0,0
		end
	else 
		prizeout=lot_prize[4][ZLottery_Get_RanPoint(lot_prizechance[4])]
		if prizeout == 21345 then 			return 4,0,prizeout,80,0,0
		else 														return 4,0,prizeout,3,0,0
		end
	end
	return 4,0,21345,80,0,0 
end 
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType23162Cashing(cur_list)		---(����_����:����¿)
	---fmax_countΪ�ò�Ʊ����Чλ��
	local cp
	local nowcurlist={}
	local fmax_count=table.getn(cur_list)
	nowcurlist[0]=""
	for cp=1,fmax_count do
		nowcurlist[cp]=nowcurlist[cp-1]..cur_list[cp]
	end 

	if cur_list[1]==1 then 				--����¿�һ�ȯ
		return 1,0,23164,1,0,0

	elseif cur_list[1]==3 then		--�������
		return 2,0,13306,1,0,0
	elseif cur_list[1]==5 then		--�������ʯ
		return 2,0,17832,1,0,0
	elseif cur_list[1]==7 then		--��������ʯ
		return 2,0,11679,1,0,0
	elseif cur_list[1]==9 then		--��������ʯ
		return 2,0,11678,1,0,0
	elseif cur_list[1]==11 then		--�ϻ�����ʯ
		return 2,0,11677,1,0,0
	elseif cur_list[1]==13 then		--��������ʯ
		return 2,0,11676,1,0,0
	elseif cur_list[1]==15 then		--�������
		return 2,0,13307,1,0,0

	elseif cur_list[1]==4 then		--�ɶ�
		return 3,0,18794,3,0,0
	elseif cur_list[1]==6 then		--�ɶ�
		return 3,0,18794,3,0,0
	elseif cur_list[1]==12 then		--�ɶ�
		return 3,0,18794,3,0,0
	elseif cur_list[1]==14 then		--�ɶ�
		return 3,0,18794,3,0,0

	elseif cur_list[1]==2 then		--����
		return 4,0,13901,1,0,0
	elseif cur_list[1]==8 then		--����
		return 4,0,8079,2,0,0
	elseif cur_list[1]==10 then		--����
		return 4,0,8079,2,0,0
	else													--����
		return 4,0,13900,1,0,0
	end
	
end 
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType23018Cashing(cur_list)		---(09��3������Ҳ�Ʊ����ͭ����)
	---fmax_countΪ�ò�Ʊ����Чλ��
	local cp
	local nowcurlist={}
	local fmax_count=table.getn(cur_list)
	nowcurlist[0]=""
	for cp=1,fmax_count do
		nowcurlist[cp]=nowcurlist[cp-1]..cur_list[cp]
	end 
	
	local lot_prize={}
	local lot_prizechance={}
	local prizeout
	local Out_Prize={}
	Out_Prize[1]={}
	Out_Prize[2]={}
	Out_Prize[3]={}
	Out_Prize[4]={}
	
	local Prize1st = {
		20782,20783,20784,20785,	-- 120 & 135 ���ñ
		20806,20807,20808,20809,	-- 120 & 135 ����ñ
		20830,20831,20832,20833,	-- 120 & 135 �ϻ�ñ
		20854,20855,20856,20857,	-- 120 & 135 ����ñ
		20878,20879,20880,20881,	-- 120 & 135 ����ñ
		20902,20903,20904,20905,	-- 120 & 135 ���Ь
		20926,20927,20928,20929,	-- 120 & 135 ����Ь
		20950,20951,20952,20953,	-- 120 & 135 �ϻ�Ь
		20974,20975,20976,20977,	-- 120 & 135 ����Ь
		20998,20999,21000,21001,	-- 120 & 135 ����Ь
	}
	for _,v in pairs(Prize1st) do
		Out_Prize[1][v]= 25
	end
	
	Out_Prize[2][21153]=100		---ʤʯ

	Out_Prize[3][22124]=50		---����֮��
	Out_Prize[3][21200]=50		---�����

	Out_Prize[4][22343]=50		---�󶨵��컯��
	Out_Prize[4][19254]=50		---ǧ��֥��
	
		
	local i,v,k
	
	for k=1,4 do
		lot_prize[k]={}
		lot_prizechance[k]={}
	end 
	
	for k=1,4 do
		for i,v in pairs(Out_Prize[k]) do 
			table.insert(lot_prize[k],i)
			table.insert(lot_prizechance[k],v)
		end 
	end 

	if nowcurlist[fmax_count]=="111" then 
		prizeout=lot_prize[1][ZLottery_Get_RanPoint(lot_prizechance[1])]
		return 1,0,prizeout,1,0,0
	elseif nowcurlist[fmax_count]=="222"  then 
		prizeout=lot_prize[2][ZLottery_Get_RanPoint(lot_prizechance[2])]
		return 2,0,prizeout,1,0,0
	elseif ZLottery_FindSameNum(cur_list,1)==2 or ZLottery_FindSameNum(cur_list,2)==2 then 
		prizeout=lot_prize[3][ZLottery_Get_RanPoint(lot_prizechance[3])]
		return 3,0,prizeout,1,0,0
	else 
		prizeout=lot_prize[4][ZLottery_Get_RanPoint(lot_prizechance[4])]
		if prizeout == 22343 then
			return 4,0,prizeout,25,0,0
		else 
			return 4,0,prizeout,6,0,0
		end
	end
end 
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType23295Cashing(cur_list)		---(09��3�³����Ʊ�������ر�)
	---fmax_countΪ�ò�Ʊ����Чλ��
	local cp
	local nowcurlist={}
	local fmax_count=table.getn(cur_list)
	nowcurlist[0]=""
	for cp=1,fmax_count do
		nowcurlist[cp]=nowcurlist[cp-1]..cur_list[cp]
	end 
	
	local lot_prize={}
	local lot_prizechance={}
	local prizeout
	local Out_Prize={}

	Out_Prize[1]={}
	Out_Prize[2]={}
	Out_Prize[3]={}
	Out_Prize[4]={}
	
	Out_Prize[1][23327]=100		---����ѩ�ζһ�ȯ

	Out_Prize[2][16320]=50		---�׽�͹ǵ�
	Out_Prize[2][23296]=50		---��ħ��¼

	Out_Prize[3][22312]=50		---����������
	Out_Prize[3][21200]=50		---�����

	Out_Prize[4][19254]=100		---ǧ��֥��
	
		
	local i,v,k
	
	for k=1,4 do
		lot_prize[k]={}
		lot_prizechance[k]={}
	end 
	
	for k=1,4 do
		for i,v in pairs(Out_Prize[k]) do 
			table.insert(lot_prize[k],i)
			table.insert(lot_prizechance[k],v)
		end 
	end 

	if nowcurlist[fmax_count]=="111" then 
		prizeout=lot_prize[1][ZLottery_Get_RanPoint(lot_prizechance[1])]
		return 1,0,prizeout,1,0,0
	elseif nowcurlist[fmax_count]=="222" then 
		prizeout=lot_prize[2][ZLottery_Get_RanPoint(lot_prizechance[2])]
		return 2,0,prizeout,1,0,0
	elseif (ZLottery_FindSameNum(cur_list,1)==0 and ZLottery_FindSameNum(cur_list,2)==0)
			or ZLottery_FindSameNum(cur_list,1)==2 or ZLottery_FindSameNum(cur_list,2)==2 then
		prizeout=lot_prize[3][ZLottery_Get_RanPoint(lot_prizechance[3])]
		return 3,0,prizeout,2,0,0
	else 
		prizeout=lot_prize[4][ZLottery_Get_RanPoint(lot_prizechance[4])]
		return 4,0,prizeout,5,0,0
	end
	return 4,0,19254,5,0,0 
end 
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType23212Cashing(cur_list)		---(����_����:ʥ������)
	if cur_list[1]==1 then 				--����һ�ȯ
		return 1,0,23299,1,0,0

	elseif cur_list[1]==5 then		--�����ʮ���
		return 2,0,21200,15,0,0
	elseif cur_list[1]==9 then		--����ϴ��
		return 2,0,11539,1,0,0
	elseif cur_list[1]==13 then		--�����ʮ���
		return 2,0,21200,15,0,0

	elseif cur_list[1]==3 then		--�ɶ�
		return 3,0,18794,3,0,0
	elseif cur_list[1]==7 then		--�ɶ�
		return 3,0,18794,3,0,0
	elseif cur_list[1]==11 then		--�ɶ�
		return 3,0,18794,3,0,0
	elseif cur_list[1]==15 then		--�ɶ�
		return 3,0,18794,3,0,0

	elseif cur_list[1]==2 then		--����
		return 4,0,8079,2,0,0
	elseif cur_list[1]==4 then		--����
		return 4,0,13901,1,0,0
	elseif cur_list[1]==6 then		--����
		return 4,0,13901,1,0,0
	elseif cur_list[1]==8 then		--����
		return 4,0,8079,2,0,0
	elseif cur_list[1]==10 then		--����
		return 4,0,8079,2,0,0
	elseif cur_list[1]==12 then		--����
		return 4,0,13900,1,0,0
	elseif cur_list[1]==14 then		--����
		return 4,0,13900,1,0,0
	else													--����
		return 4,0,8079,2,0,0
	end
end 
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType23336Cashing(cur_list)		---(����_����:���ܽ�֦)
	if cur_list[1]==1 then 				--��˶һ�ȯ
		return 1,0,23344,1,0,0
	elseif cur_list[1]==9 then		--��˶һ�ȯ
		return 1,0,23344,1,0,0

	elseif cur_list[1]==5 then		--�а���
		return 2,0,7931,1,0,0
	elseif cur_list[1]==13 then		--Ů����
		return 2,0,7937,1,0,0

	elseif cur_list[1]==3 then		--����
		return 3,0,13343,10,0,0
	elseif cur_list[1]==7 then		--�ɶ�
		return 3,0,18794,3,0,0
	elseif cur_list[1]==11 then		--����
		return 3,0,13343,10,0,0
	elseif cur_list[1]==15 then		--�ɶ�
		return 3,0,18794,3,0,0

	elseif cur_list[1]==2 then		--����
		return 4,0,8079,2,0,0
	elseif cur_list[1]==4 then		--����
		return 4,0,13901,1,0,0
	elseif cur_list[1]==6 then		--����
		return 4,0,13901,1,0,0
	elseif cur_list[1]==8 then		--����
		return 4,0,8079,2,0,0
	elseif cur_list[1]==10 then		--����
		return 4,0,8079,2,0,0
	elseif cur_list[1]==12 then		--����
		return 4,0,13900,1,0,0
	elseif cur_list[1]==14 then		--����
		return 4,0,13900,1,0,0
	else													--����
		return 4,0,8079,2,0,0
	end
end 
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType23363Cashing(cur_list)		---(����:������ƪ)
	if cur_list[1]==1 then 				--����һ�ȯ
		return 1,0,23364,1,0,0
	elseif cur_list[1]==9 then		--����һ�ȯ
		return 1,0,23364,1,0,0

	elseif cur_list[1]==5 then		--�а���
		return 2,0,7931,1,0,0
	elseif cur_list[1]==13 then		--Ů����
		return 2,0,7937,1,0,0

	elseif cur_list[1]==3 then		--�ɶ�
		return 3,0,18794,3,0,0
	elseif cur_list[1]==7 then		--�ɶ�
		return 3,0,18794,3,0,0
	elseif cur_list[1]==11 then		--�ɶ�
		return 3,0,18794,3,0,0
	elseif cur_list[1]==15 then		--�ɶ�
		return 3,0,18794,3,0,0

	elseif cur_list[1]==2 then		--����
		return 4,0,8079,2,0,0
	elseif cur_list[1]==4 then		--����
		return 4,0,13901,1,0,0
	elseif cur_list[1]==6 then		--����
		return 4,0,13901,1,0,0
	elseif cur_list[1]==8 then		--����
		return 4,0,8079,2,0,0
	elseif cur_list[1]==10 then		--����
		return 4,0,8079,2,0,0
	elseif cur_list[1]==12 then		--����
		return 4,0,13900,1,0,0
	elseif cur_list[1]==14 then		--����
		return 4,0,13900,1,0,0
	else													--����
		return 4,0,8079,2,0,0
	end
end 
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType23422Cashing(cur_list)		---(����_����:���Ļ�ʯ)
	if cur_list[1]==1 then 				--ŭ���һ�ȯ
		return 1,0,23426,1,0,0

	elseif cur_list[1]==5 then		--����
		return 2,0,23353,1,0,0
	elseif cur_list[1]==9 then		--����
		return 2,0,23353,1,0,0
	elseif cur_list[1]==13 then		--����
		return 2,0,23353,1,0,0

	elseif cur_list[1]==3 then		--�ɶ�
		return 3,0,18794,3,0,0
	elseif cur_list[1]==7 then		--�ɶ�
		return 3,0,18794,3,0,0
	elseif cur_list[1]==11 then		--�ɶ�
		return 3,0,18794,3,0,0
	elseif cur_list[1]==15 then		--�ɶ�
		return 3,0,18794,3,0,0

	elseif cur_list[1]==2 then		--����
		return 4,0,8079,2,0,0
	elseif cur_list[1]==4 then		--����
		return 4,0,13901,1,0,0
	elseif cur_list[1]==6 then		--����
		return 4,0,13901,1,0,0
	elseif cur_list[1]==8 then		--����
		return 4,0,8079,2,0,0
	elseif cur_list[1]==10 then		--����
		return 4,0,8079,2,0,0
	elseif cur_list[1]==12 then		--����
		return 4,0,13900,1,0,0
	elseif cur_list[1]==14 then		--����
		return 4,0,13900,1,0,0
	else													--����
		return 4,0,8079,2,0,0
	end
end 
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType23423Cashing(cur_list)		---(09��3������������Ʊ�������ر�)
	---fmax_countΪ�ò�Ʊ����Чλ��
	local cp
	local nowcurlist={}
	local fmax_count=table.getn(cur_list)
	nowcurlist[0]=""
	for cp=1,fmax_count do
		nowcurlist[cp]=nowcurlist[cp-1]..cur_list[cp]
	end 
	
	local lot_prize={}
	local lot_prizechance={}
	local prizeout
	local Out_Prize={}
	Out_Prize[1]={}
	Out_Prize[2]={}
	Out_Prize[3]={}
	Out_Prize[4]={}
	
	Out_Prize[1][20664]=40		--- 135����
	Out_Prize[1][20665]=60		---
	Out_Prize[1][20688]=40		---
	Out_Prize[1][20689]=60		---
	Out_Prize[1][20712]=40		---
	Out_Prize[1][20713]=60		---
	Out_Prize[1][20736]=40		---
	Out_Prize[1][20737]=60		---
	Out_Prize[1][20760]=40		---
	Out_Prize[1][20761]=60		---
	
	Out_Prize[2][20784]=40		--- 135��ñ
	Out_Prize[2][20785]=60		---
	Out_Prize[2][20808]=40		---
	Out_Prize[2][20809]=60		---
	Out_Prize[2][20832]=40		---
	Out_Prize[2][20833]=60		---
	Out_Prize[2][20856]=40		---
	Out_Prize[2][20857]=60		---
	Out_Prize[2][20880]=40		---
	Out_Prize[2][20881]=60		---

	Out_Prize[3][22343]=100		--- ���컯��

	Out_Prize[4][21154]=100		--- ���춷��
		
	local i,v,k
	
	for k=1,4 do
		lot_prize[k]={}
		lot_prizechance[k]={}
	end 
	
	for k=1,4 do
		for i,v in pairs(Out_Prize[k]) do 
			table.insert(lot_prize[k],i)
			table.insert(lot_prizechance[k],v)
		end 
	end 
	if nowcurlist[fmax_count]=="111" then 
		prizeout=lot_prize[1][ZLottery_Get_RanPoint(lot_prizechance[1])]
		return 1,0,prizeout,1,0,0
	elseif nowcurlist[fmax_count]=="222"  then 
		prizeout=lot_prize[2][ZLottery_Get_RanPoint(lot_prizechance[2])]
		return 2,0,prizeout,1,0,0
	elseif ZLottery_FindSameNum(cur_list,1)==2 or ZLottery_FindSameNum(cur_list,2)==2 then 
		prizeout=lot_prize[3][ZLottery_Get_RanPoint(lot_prizechance[3])]
		return 3,0,prizeout,200,0,0
	else 
		prizeout=lot_prize[4][ZLottery_Get_RanPoint(lot_prizechance[4])]
		return 4,0,prizeout,20,0,0
	end

	return 4,0,prizeout,20,0,0
end 
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType24343Cashing(cur_list)		---(�����ʯ:���)
	---fmax_countΪ�ò�Ʊ����Чλ��
	local cp
	local nowcurlist={}
	local fmax_count=table.getn(cur_list)
	nowcurlist[0]=""
	for cp=1,fmax_count do
		nowcurlist[cp]=nowcurlist[cp-1]..cur_list[cp]
	end 

	if cur_list[1]==1 then 				--����һ�ȯ
		return 1,0,24338,1,0,0

	elseif cur_list[1]==3 then		--�������
		return 2,0,19128,1,0,0
	elseif cur_list[1]==5 then		--�������ʯ
		return 2,0,17832,1,0,0
	elseif cur_list[1]==7 then		--��������ʯ
		return 2,0,11679,1,0,0
	elseif cur_list[1]==9 then		--��������ʯ
		return 2,0,11678,1,0,0
	elseif cur_list[1]==11 then		--�ϻ�����ʯ
		return 2,0,11677,1,0,0
	elseif cur_list[1]==13 then		--��������ʯ
		return 2,0,11676,1,0,0
	elseif cur_list[1]==15 then		--�������
		return 2,0,19127,1,0,0

	elseif cur_list[1]==4 then		--�ɶ�
		return 3,0,18794,3,0,0
	elseif cur_list[1]==6 then		--�ɶ�
		return 3,0,18794,3,0,0
	elseif cur_list[1]==12 then		--�ɶ�
		return 3,0,18794,3,0,0
	elseif cur_list[1]==14 then		--�ɶ�
		return 3,0,18794,3,0,0

	elseif cur_list[1]==2 then		--����
		return 4,0,13901,1,0,0
	elseif cur_list[1]==8 then		--����
		return 4,0,8079,2,0,0
	elseif cur_list[1]==10 then		--����
		return 4,0,8079,2,0,0
	else													--����
		return 4,0,13900,1,0,0
	end
	
end 
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType24344Cashing(cur_list)		---(09����������Ҳ�Ʊ)
	---fmax_countΪ�ò�Ʊ����Чλ��
	local cp
	local nowcurlist={}
	local fmax_count=table.getn(cur_list)
	nowcurlist[0]=""
	for cp=1,fmax_count do
		nowcurlist[cp]=nowcurlist[cp-1]..cur_list[cp]
	end 
	
	local lot_prize={}
	local lot_prizechance={}
	local prizeout
	local Out_Prize={}
	Out_Prize[1]={}
	Out_Prize[2]={}
	Out_Prize[3]={}
	Out_Prize[4]={}
	
	Out_Prize[1][10875]=50		---���
	Out_Prize[1][20096]=50		---���
	
	Out_Prize[2][6315]=200			---100��������ָ
	Out_Prize[2][6305]=200			---100��������ָ
	Out_Prize[2][3463]=200			---100�����˽�ָ
	Out_Prize[2][10957]=100			---100��ȫ����ָ

	Out_Prize[3][16551]=50			---����������
	Out_Prize[3][19257]=50			---�����ڵ�
	
	Out_Prize[4][20098]=50			---������һ�ȯ����
	Out_Prize[4][20099]=50			---Ǭ��ͨ���һ�ȯ����
	
	local i,v,k
	for k=1,4 do
	lot_prize[k]={}
		lot_prizechance[k]={}
	end 
	for k=1,4 do
		for i,v in pairs(Out_Prize[k]) do 
			table.insert(lot_prize[k],i)
			table.insert(lot_prizechance[k],v)
		end 
	end 
	if nowcurlist[fmax_count]=="111" then 
		prizeout=lot_prize[1][ZLottery_Get_RanPoint(lot_prizechance[1])]
		return 1,0,prizeout,1,0,0
	elseif nowcurlist[fmax_count]=="222"  then 
		prizeout=lot_prize[2][ZLottery_Get_RanPoint(lot_prizechance[2])]
		return 2,0,prizeout,1,0,0
	elseif (ZLottery_FindSameNum(cur_list,1)==0 and ZLottery_FindSameNum(cur_list,2)==0) or
	ZLottery_FindSameNum(cur_list,1)==2 or ZLottery_FindSameNum(cur_list,2)==2 then 
		prizeout=lot_prize[3][ZLottery_Get_RanPoint(lot_prizechance[3])]
		if prizeout==16551 then 
			return 3,0,prizeout,3,0,0
		else
			return 3,0,prizeout,1,0,0
		end 	
	else 
		prizeout=lot_prize[4][ZLottery_Get_RanPoint(lot_prizechance[4])]
		return 4,0,prizeout,3,0,0
	end
	return 4,0,20098,3,0,0 
end 
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType24993Cashing(cur_list)		---(���޽���777)
	---fmax_countΪ�ò�Ʊ����Чλ��
	local cp
	local nowcurlist={}
	local fmax_count=table.getn(cur_list)
	nowcurlist[0]=""
	for cp=1,fmax_count do
		nowcurlist[cp]=nowcurlist[cp-1]..cur_list[cp]
	end 
	
	local lot_prize={}
	local lot_prizechance={}
	local prizeout
	local Out_Prize={}
	Out_Prize[1]={}
	Out_Prize[2]={}
	Out_Prize[3]={}
	Out_Prize[4]={}
	
	Out_Prize[1][21189]=100		---���޵����
	Out_Prize[2][24904]=100		---���龫��
	Out_Prize[3][18794]=100		---�ɶ�����
	Out_Prize[4][13901]=100		---�������
	Out_Prize[4][13900]=100		---���Ǳ���
	Out_Prize[4][8079]=100		---�����������

	local i,v,k
	for k=1,4 do
	lot_prize[k]={}
		lot_prizechance[k]={}
	end 
	
	for k=1,4 do
		for i,v in pairs(Out_Prize[k]) do 
			table.insert(lot_prize[k],i)
			table.insert(lot_prizechance[k],v)
		end 
	end 
	if nowcurlist[fmax_count]=="111" then 
		prizeout=lot_prize[1][ZLottery_Get_RanPoint(lot_prizechance[1])]
		return 1,0,prizeout,1,0,0
	elseif nowcurlist[fmax_count]=="222"  then 
		prizeout=lot_prize[2][ZLottery_Get_RanPoint(lot_prizechance[2])]
		return 2,0,prizeout,1,0,0
	elseif (ZLottery_FindSameNum(cur_list,1)==0 and ZLottery_FindSameNum(cur_list,2)==0)
			or ZLottery_FindSameNum(cur_list,1)==2 or ZLottery_FindSameNum(cur_list,2)==2 then
		prizeout=lot_prize[3][ZLottery_Get_RanPoint(lot_prizechance[3])]
		return 3,0,prizeout,3,0,0
	else 
		prizeout=lot_prize[4][ZLottery_Get_RanPoint(lot_prizechance[4])]
		if 		 prizeout == 13901 then	return 4,0,prizeout,1,0,0
		elseif prizeout == 13900 then	return 4,0,prizeout,1,0,0
		else 													return 4,0,prizeout,2,0,0
		end
	end
	return 4,0,8079,2,0,0 
end 
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType24998Cashing(cur_list)		---(���챦¼777)
	---fmax_countΪ�ò�Ʊ����Чλ��
	local cp
	local nowcurlist={}
	local fmax_count=table.getn(cur_list)
	nowcurlist[0]=""
	for cp=1,fmax_count do
		nowcurlist[cp]=nowcurlist[cp-1]..cur_list[cp]
	end 
	
	local lot_prize={}
	local lot_prizechance={}
	local prizeout
	local Out_Prize={}
	Out_Prize[1]={}
	Out_Prize[2]={}
	Out_Prize[3]={}
	Out_Prize[4]={}
	
	Out_Prize[1][24903]=100		---���������
	Out_Prize[2][18797]=100		---������ƪ	
	Out_Prize[3][13343]=100		---�۱���
	Out_Prize[4][13901]=25		---�������
	Out_Prize[4][13900]=100		---���Ǳ���
	Out_Prize[4][8079]=100		---�����������
		
	local i,v,k
	
	for k=1,4 do
		lot_prize[k]={}
		lot_prizechance[k]={}
	end 
	
	for k=1,4 do
		for i,v in pairs(Out_Prize[k]) do 
			table.insert(lot_prize[k],i)
			table.insert(lot_prizechance[k],v)
		end 
	end 
	if nowcurlist[fmax_count]=="111" then 
		prizeout=lot_prize[1][ZLottery_Get_RanPoint(lot_prizechance[1])]
		return 1,0,prizeout,1,0,0
	elseif nowcurlist[fmax_count]=="222"  then 
		prizeout=lot_prize[2][ZLottery_Get_RanPoint(lot_prizechance[2])]
		return 2,0,prizeout,1,0,0
	elseif (ZLottery_FindSameNum(cur_list,1)==0 and ZLottery_FindSameNum(cur_list,2)==0) or
	(ZLottery_FindSameNum(cur_list,1)==1 and ZLottery_FindSameNum(cur_list,2)==1 and 
	ZLottery_FindSameNum(cur_list,3)==1) then 
		prizeout=lot_prize[3][ZLottery_Get_RanPoint(lot_prizechance[3])]
		return 3,0,prizeout,10,0,0
	else 
		prizeout=lot_prize[4][ZLottery_Get_RanPoint(lot_prizechance[4])]
		if 		 prizeout == 13901 then	return 4,0,prizeout,1,0,0
		elseif prizeout == 13900 then	return 4,0,prizeout,1,0,0
		else 													return 4,0,prizeout,2,0,0
		end
	end
	return 4,0,8079,2,0,0 
end 
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType24999Cashing(cur_list)		---(���޽�������)
	if cur_list[1]==1 then 				--���޵����
		return 1,0,21189,1,0,0

	elseif cur_list[1]==5 then		--���龫��
		return 2,0,24904,1,0,0
	elseif cur_list[1]==9 then		--���龫��
		return 2,0,24904,1,0,0
	elseif cur_list[1]==13 then		--���龫��
		return 2,0,24904,1,0,0

	elseif cur_list[1]==3 then		--�ɶ�
		return 3,0,18794,3,0,0
	elseif cur_list[1]==7 then		--�ɶ�
		return 3,0,18794,3,0,0
	elseif cur_list[1]==11 then		--�ɶ�
		return 3,0,18794,3,0,0
	elseif cur_list[1]==15 then		--�ɶ�
		return 3,0,18794,3,0,0

	elseif cur_list[1]==2 then		--����
		return 4,0,8079,2,0,0
	elseif cur_list[1]==4 then		--����
		return 4,0,13901,1,0,0
	elseif cur_list[1]==6 then		--����
		return 4,0,13901,1,0,0
	elseif cur_list[1]==8 then		--����
		return 4,0,8079,2,0,0
	elseif cur_list[1]==10 then		--����
		return 4,0,8079,2,0,0
	elseif cur_list[1]==12 then		--����
		return 4,0,13900,1,0,0
	elseif cur_list[1]==14 then		--����
		return 4,0,13900,1,0,0
	else													--����
		return 4,0,8079,2,0,0
	end
end 
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType34125Cashing(cur_list)		---(����_������ϻ)
	if cur_list[1]==1 then 				--��������
		return 1,0,34043,1,0,0
	elseif cur_list[1]==9 then		--��ɴ�����
		return 1,0,34044,1,0,0

	elseif cur_list[1]==5 then		--����ʯ��
		return 2,0,28587,1,0,0
	elseif cur_list[1]==13 then		--��������
		return 2,0,11539,1,0,0

	elseif cur_list[1]==3 then		--������
		return 3,0,16551,1,0,0
	elseif cur_list[1]==7 then		--�۱���
		return 3,0,13343,10,0,0
	elseif cur_list[1]==11 then		--�۱���
		return 3,0,13343,10,0,0
	elseif cur_list[1]==15 then		--������
		return 3,0,16551,1,0,0

	elseif cur_list[1]==2 then		--�������
		return 4,0,8079,2,0,0
	elseif cur_list[1]==4 then		--����
		return 4,0,25307,1,0,0
	elseif cur_list[1]==6 then		--����
		return 4,0,25306,1,0,0
	elseif cur_list[1]==8 then		--�������
		return 4,0,8079,2,0,0
	elseif cur_list[1]==10 then		--�������
		return 4,0,8079,2,0,0
	elseif cur_list[1]==12 then		--����
		return 4,0,25306,1,0,0
	elseif cur_list[1]==14 then		--����
		return 4,0,25307,1,0,0
	else													--�������
		return 4,0,8079,2,0,0
	end
end 
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType33055Cashing(cur_list)	---(����_2009ʥ������)
	---fmax_countΪ�ò�Ʊ����Чλ��
	local cp
	local nowcurlist={}
	local fmax_count=table.getn(cur_list)
	nowcurlist[0]=""
	for cp=1,fmax_count do
		nowcurlist[cp]=nowcurlist[cp-1]..cur_list[cp]
	end 
	
	local lot_prize={}
	local lot_prizechance={}
	local lot_prizenumber={}
	local prizeout
	local Out_Prize={}
	Out_Prize[1]={}
	
	Out_Prize[1][31819]={chance=05,number=1}  ---˫������*1     0.05
	
	Out_Prize[1][18827]={chance=05,number=1}  ---��Ʒ���*1     0.05
	Out_Prize[1][18826]={chance=05,number=1}  ---��Ʒ��ì*1     0.05
	Out_Prize[1][18820]={chance=10,number=1}  ---��Ʒ���*1     0.1
	Out_Prize[1][18821]={chance=10,number=1}  ---��Ʒ��ì*1     0.1

	Out_Prize[1][19252]={chance=10,number=2}  ---��ԯͨ��*2     0.1
	Out_Prize[1][16385]={chance=10,number=25} ---Ǭ��ͨ��*25    0.1
	Out_Prize[1][19254]={chance=10,number=5}  ---ǧ��֥��*5     0.1
	Out_Prize[1][22312]={chance=10,number=3}  ---������*3       0.1 
	Out_Prize[1][23880]={chance=10,number=2}  ---������*2       0.1
	
	Out_Prize[1][22343]={chance=05,number=500}---�컯��*500     0.05
	Out_Prize[1][24653]={chance=05,number=1}  ---�󶨻���*1     0.05
	Out_Prize[1][24652]={chance=05,number=1}  ---�󶨹���*1     0.05
		
	local i,v
	
	lot_prize[1]={}
	lot_prizechance[1]={}
	lot_prizenumber[1]={}
	
	for i,v in pairs(Out_Prize[1]) do 
		table.insert(lot_prize[1],i)
		table.insert(lot_prizechance[1],v.chance)
		table.insert(lot_prizenumber[1],v.number)
	end 

	if nowcurlist[fmax_count]=="111" then 
		prizeout=lot_prize[1][ZLottery_Get_RanPoint(lot_prizechance[1])]
		return 1,0,prizeout,Out_Prize[1][prizeout].number,0,0
	end
	return 1,0,24653,1,0,0 
end
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType28703Cashing(cur_list)		---(����_���ʻ��)
	if cur_list[1]==1 then 				--���ɶһ�ȯ
		return 1,0,28707,1,0,0
	elseif cur_list[1]==9 then		--���ɶһ�ȯ
		return 1,0,28707,1,0,0

	elseif cur_list[1]==5 then		--�а���
		return 2,0,7931,1,0,0
	elseif cur_list[1]==13 then		--Ů����
		return 2,0,7937,1,0,0

	elseif cur_list[1]==3 then		--�ɶ�
		return 3,0,18794,3,0,0
	elseif cur_list[1]==7 then		--�ɶ�
		return 3,0,18794,3,0,0
	elseif cur_list[1]==11 then		--�ɶ�
		return 3,0,18794,3,0,0
	elseif cur_list[1]==15 then		--�ɶ�
		return 3,0,18794,3,0,0

	elseif cur_list[1]==2 then		--����
		return 4,0,8079,2,0,0
	elseif cur_list[1]==4 then		--����
		return 4,0,25306,1,0,0
	elseif cur_list[1]==6 then		--����
		return 4,0,25306,1,0,0
	elseif cur_list[1]==8 then		--����
		return 4,0,8079,2,0,0
	elseif cur_list[1]==10 then		--����
		return 4,0,8079,2,0,0
	elseif cur_list[1]==12 then		--����
		return 4,0,25307,1,0,0
	elseif cur_list[1]==14 then		--����
		return 4,0,25307,1,0,0
	else													--����
		return 4,0,8079,2,0,0
	end
end 
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType25418Cashing(cur_list)		---(����_��Į��ɳ)
	if cur_list[1]==1 then 				--ɳ���һ�ȯ
		return 1,0,25420,1,0,0

	elseif cur_list[1]==5 then		--��������
		return 2,0,11539,1,0,0
	elseif cur_list[1]==9 then		--��������
		return 2,0,11539,1,0,0
	elseif cur_list[1]==13 then		--��������
		return 2,0,11539,1,0,0

	elseif cur_list[1]==3 then		--�ɶ�
		return 3,0,18794,3,0,0
	elseif cur_list[1]==7 then		--�ɶ�
		return 3,0,18794,3,0,0
	elseif cur_list[1]==11 then		--�ɶ�
		return 3,0,18794,3,0,0
	elseif cur_list[1]==15 then		--�ɶ�
		return 3,0,18794,3,0,0

	elseif cur_list[1]==2 then		--����
		return 4,0,8079,2,0,0
	elseif cur_list[1]==4 then		--����
		return 4,0,25306,1,0,0
	elseif cur_list[1]==6 then		--����
		return 4,0,25306,1,0,0
	elseif cur_list[1]==8 then		--����
		return 4,0,8079,2,0,0
	elseif cur_list[1]==10 then		--����
		return 4,0,8079,2,0,0
	elseif cur_list[1]==12 then		--����
		return 4,0,25307,1,0,0
	elseif cur_list[1]==14 then		--����
		return 4,0,25307,1,0,0
	else													--����
		return 4,0,8079,2,0,0
	end
end 
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType25305Cashing(cur_list)		---(����_��������)
	if cur_list[1]==1 then 				--�����һ�ȯ
		return 1,0,25302,1,0,0

	elseif cur_list[1]==5 then		--������ߣ�Ů��
		return 2,0,19130,1,0,0
	elseif cur_list[1]==9 then		--��������
		return 2,0,11539,1,0,0
	elseif cur_list[1]==13 then		--��Ы��ߣ��У�
		return 2,0,19129,1,0,0

	elseif cur_list[1]==3 then		--�ɶ�
		return 3,0,18794,3,0,0
	elseif cur_list[1]==7 then		--�ɶ�
		return 3,0,18794,3,0,0
	elseif cur_list[1]==11 then		--�ɶ�
		return 3,0,18794,3,0,0
	elseif cur_list[1]==15 then		--�ɶ�
		return 3,0,18794,3,0,0

	elseif cur_list[1]==2 then		--����
		return 4,0,8079,2,0,0
	elseif cur_list[1]==4 then		--����
		return 4,0,25306,1,0,0
	elseif cur_list[1]==6 then		--����
		return 4,0,25306,1,0,0
	elseif cur_list[1]==8 then		--����
		return 4,0,8079,2,0,0
	elseif cur_list[1]==10 then		--����
		return 4,0,8079,2,0,0
	elseif cur_list[1]==12 then		--����
		return 4,0,25307,1,0,0
	elseif cur_list[1]==14 then		--����
		return 4,0,25307,1,0,0
	else													--����
		return 4,0,8079,2,0,0
	end
end 
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType34124Cashing(cur_list)		---(����_�������)
	if cur_list[1]==1 then 				--��ʶһ�
		return 1,0,34042,1,0,0
	elseif cur_list[1]==9 then		--��ʶһ�
		return 1,0,34042,1,0,0

	elseif cur_list[1]==5 then		--�а���
		return 2,0,7931,1,0,0
	elseif cur_list[1]==13 then		--Ů����
		return 2,0,7937,1,0,0

	elseif cur_list[1]==3 then		--�ɶ�
		return 3,0,18794,3,0,0
	elseif cur_list[1]==7 then		--�۱���
		return 3,0,13343,10,0,0
	elseif cur_list[1]==11 then		--�۱���
		return 3,0,13343,10,0,0
	elseif cur_list[1]==15 then		--�ɶ�
		return 3,0,18794,3,0,0

	elseif cur_list[1]==2 then		--����
		return 4,0,25307,1,0,0
	elseif cur_list[1]==4 then		--����
		return 4,0,25306,1,0,0
	elseif cur_list[1]==6 then		--����
		return 4,0,25306,1,0,0
	elseif cur_list[1]==8 then		--����
		return 4,0,25307,1,0,0
	elseif cur_list[1]==10 then		--����
		return 4,0,25307,1,0,0
	elseif cur_list[1]==12 then		--����
		return 4,0,25306,1,0,0
	elseif cur_list[1]==14 then		--����
		return 4,0,25306,1,0,0
	else													--����
		return 4,0,25307,1,0,0
	end
end 
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType25000Cashing(cur_list)		---(���챦¼����)
	if cur_list[1]==1 then 				--���������
		return 1,0,24903,1,0,0

	elseif cur_list[1]==5 then		--������ƪ
		return 2,0,18797,1,0,0
	elseif cur_list[1]==9 then		--������ƪ
		return 2,0,18797,1,0,0
	elseif cur_list[1]==13 then		--������ƪ
		return 2,0,18797,1,0,0

	elseif cur_list[1]==3 then		--�۱���
		return 3,0,13343,10,0,0
	elseif cur_list[1]==7 then		--�۱���
		return 3,0,13343,10,0,0
	elseif cur_list[1]==11 then		--�۱���
		return 3,0,13343,10,0,0
	elseif cur_list[1]==15 then		--�۱���
		return 3,0,13343,10,0,0

	elseif cur_list[1]==2 then		--����
		return 4,0,8079,2,0,0
	elseif cur_list[1]==4 then		--����
		return 4,0,13901,1,0,0
	elseif cur_list[1]==6 then		--����
		return 4,0,13901,1,0,0
	elseif cur_list[1]==8 then		--����
		return 4,0,8079,2,0,0
	elseif cur_list[1]==10 then		--����
		return 4,0,8079,2,0,0
	elseif cur_list[1]==12 then		--����
		return 4,0,13900,1,0,0
	elseif cur_list[1]==14 then		--����
		return 4,0,13900,1,0,0
	else													--����
		return 4,0,8079,2,0,0
	end
end 
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType34937Cashing(cur_list)		---(����_��������)
	if cur_list[1]==1 then 				--�����һ�ȯ
		return 1,0,33807,1,0,0
	elseif cur_list[1]==9 then		--ʮ���������
		return 1,0,32103,1,0,0

	elseif cur_list[1]==5 then		--�а���
		return 2,0,7931,1,0,0
	elseif cur_list[1]==13 then		--Ů����
		return 2,0,7937,1,0,0

	elseif cur_list[1]==3 then		--�ɶ�
		return 3,0,18794,3,0,0
	elseif cur_list[1]==7 then		--�۱���
		return 3,0,13343,10,0,0
	elseif cur_list[1]==11 then		--�۱���
		return 3,0,13343,10,0,0
	elseif cur_list[1]==15 then		--�ɶ�
		return 3,0,18794,3,0,0

	elseif cur_list[1]==2 then		--����
		return 4,0,25307,1,0,0
	elseif cur_list[1]==4 then		--����
		return 4,0,25306,1,0,0
	elseif cur_list[1]==6 then		--����
		return 4,0,25306,1,0,0
	elseif cur_list[1]==8 then		--����
		return 4,0,25307,1,0,0
	elseif cur_list[1]==10 then		--����
		return 4,0,25307,1,0,0
	elseif cur_list[1]==12 then		--����
		return 4,0,25306,1,0,0
	elseif cur_list[1]==14 then		--����
		return 4,0,25306,1,0,0
	else													--����
		return 4,0,25307,1,0,0
	end
end 
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType25750Cashing(cur_list)		---(����_��Ҷ��֥)
	if cur_list[1]==1 then 				--���������һ�ȯ
		return 1,0,25747,1,0,0
	elseif cur_list[1]==9 then		--10���������
		return 1,0,32103,1,0,0
	elseif cur_list[1]==13 then		--������ӡ
		return 1,0,32104,1,0,0

	elseif cur_list[1]==3 then		--Ů����
		return 2,0,7937,1,0,0
	elseif cur_list[1]==5 then		--����
		return 2,0,18911,1,0,0
	elseif cur_list[1]==7 then		--���龫��
		return 2,0,24904,1,0,0
	elseif cur_list[1]==11 then		--������ƪ
		return 2,0,18797,1,0,0
	elseif cur_list[1]==15 then		--�а���
		return 2,0,7931,1,0,0

	elseif cur_list[1]==4 then		--�ɶ�
		return 3,0,18794,3,0,0
	elseif cur_list[1]==6 then		--������
		return 3,0,16551,1,0,0
	elseif cur_list[1]==12 then		--�۱���
		return 3,0,13343,10,0,0
	elseif cur_list[1]==14 then		--�ɶ�
		return 3,0,18794,3,0,0

	elseif cur_list[1]==2 then		--����
		return 4,0,8079,2,0,0
	elseif cur_list[1]==8 then		--����
		return 4,0,25306,1,0,0
	elseif cur_list[1]==10 then		--����
		return 4,0,25307,1,0,0
	else													--����
		return 4,0,8079,2,0,0
	end
end 
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType28573Cashing(cur_list)		---(����_�����ر�)
	if cur_list[1]==1 then 				--��ħѪ��
		return 1,0,27150,1,0,0
	elseif cur_list[1]==5 then		--���
		return 1,0,10875,1,0,0
	elseif cur_list[1]==9 then		--��������ʮ����
		return 1,0,28588,1,0,0
	elseif cur_list[1]==13 then		--��Ѫ��
		return 1,0,10876,1,0,0

	elseif cur_list[1]==3 then		--̫��
		return 2,0,25729,1,0,0
	elseif cur_list[1]==7 then		--Ů����
		return 2,0,7937,1,0,0
	elseif cur_list[1]==11 then		--�а���
		return 2,0,7931,1,0,0
	elseif cur_list[1]==14 then		--���龫��
		return 2,0,24904,1,0,0
	elseif cur_list[1]==15 then		--̫��
		return 2,0,25729,1,0,0

	elseif cur_list[1]==4 then		--����ʯ��
		return 3,0,28587,1,0,0
	elseif cur_list[1]==6 then		--�ɶ�
		return 3,0,18794,3,0,0
	elseif cur_list[1]==12 then		--�۱���
		return 3,0,13343,10,0,0

	elseif cur_list[1]==8 then		--������
		return 4,0,16551,1,0,0
	elseif cur_list[1]==10 then		--ʤʯ
		return 4,0,21153,2,0,0
	elseif cur_list[1]==16 then		--����˼��
		return 4,0,25731,3,0,0
	else													--����
		return 4,0,8079,2,0,0
	end
end 
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType34295Cashing(cur_list)		---(����_20110125_������)
	if cur_list[1]==1 then 				--����һ���
		return 1,0,34351,1,0,0
	elseif cur_list[1]==9 then		--����һ�Ů
		return 1,0,34352,1,0,0

	elseif cur_list[1]==5 then		--̫��
		return 2,0,25729,1,0,0
	elseif cur_list[1]==13 then		--̫�
		return 2,0,25728,1,0,0

	elseif cur_list[1]==3 then		--�ɶ�
		return 3,0,18794,3,0,0
	elseif cur_list[1]==7 then		--�۱���
		return 3,0,13343,10,0,0
	elseif cur_list[1]==11 then		--�۱���
		return 3,0,13343,10,0,0
	elseif cur_list[1]==15 then		--�ɶ�
		return 3,0,18794,3,0,0

	elseif cur_list[1]==2 then		--����
		return 4,0,25307,1,0,0
	elseif cur_list[1]==4 then		--����
		return 4,0,25306,1,0,0
	elseif cur_list[1]==6 then		--����
		return 4,0,25306,1,0,0
	elseif cur_list[1]==8 then		--����
		return 4,0,25307,1,0,0
	elseif cur_list[1]==10 then		--����
		return 4,0,25307,1,0,0
	elseif cur_list[1]==12 then		--����
		return 4,0,25306,1,0,0
	elseif cur_list[1]==14 then		--����
		return 4,0,25306,1,0,0
	else													--����
		return 4,0,25307,1,0,0
	end
end 
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType23144Cashing(cur_list)		---(����:��챱��20110125�����ƽ�)
	---fmax_countΪ�ò�Ʊ����Чλ��
	local cp
	local nowcurlist={}
	local fmax_count=table.getn(cur_list)
	nowcurlist[0]=""
	for cp=1,fmax_count do
		nowcurlist[cp]=nowcurlist[cp-1]..cur_list[cp]
	end 

	if nowcurlist[fmax_count]=="11" then 			--���
		return 1,0,23142,1,0,0
	elseif nowcurlist[fmax_count]=="12" then	--����
		return 4,0,8079,2,0,0
	elseif nowcurlist[fmax_count]=="13" then	--�۱���
		return 3,0,13343,10,0,0
	elseif nowcurlist[fmax_count]=="14" then	--����
		return 4,0,13901,1,0,0
	elseif nowcurlist[fmax_count]=="21" then	--�а���
		return 2,0,7931,1,0,0
	elseif nowcurlist[fmax_count]=="22" then	--����
		return 4,0,13901,1,0,0
	elseif nowcurlist[fmax_count]=="23" then	--�ɶ�
		return 3,0,18794,3,0,0
	elseif nowcurlist[fmax_count]=="24" then	--����
		return 4,0,8079,2,0,0
	elseif nowcurlist[fmax_count]=="31" then	--Ů����
		return 2,0,7937,1,0,0
	elseif nowcurlist[fmax_count]=="32" then	--����
		return 4,0,8079,2,0,0
	elseif nowcurlist[fmax_count]=="33" then	--�ɶ�
		return 3,0,18794,3,0,0
	elseif nowcurlist[fmax_count]=="34" then	--����
		return 4,0,13900,1,0,0
	elseif nowcurlist[fmax_count]=="41" then	--����
		return 2,0,18911,1,0,0
	elseif nowcurlist[fmax_count]=="42" then	--����
		return 4,0,13900,1,0,0
	elseif nowcurlist[fmax_count]=="43" then	--�۱���
		return 3,0,13343,10,0,0
	else																			--����
		return 4,0,8079,2,0,0
	end	
end 
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType41080Cashing(cur_list)		---(�廪����)
	if cur_list[1]==1 then 				--�廪����
		return 1,0,41079,1,0,0
	elseif cur_list[1]==5 then		--ǬԪ��̥
		return 1,0,40673,1,0,0
	elseif cur_list[1]==9 then		--�廪����
		return 1,0,41079,1,0,0
	elseif cur_list[1]==13 then		--��Ԫ�쾧
		return 1,0,40668,1,0,0

	elseif cur_list[1]==3 then		--������ƪ
		return 2,0,18797,1,0,0
	elseif cur_list[1]==7 then		--����ĺ���ѩ��
		return 2,0,23327,1,0,0
	elseif cur_list[1]==11 then		--��������
		return 2,0,11539,1,0,0
	elseif cur_list[1]==15 then		--������ƪ
		return 2,0,18797,1,0,0

	elseif cur_list[1]==4 then		--�ɶ�
		return 3,0,18794,3,0,0
	elseif cur_list[1]==6 then		--��ħ��¼
		return 3,0,23296,1,0,0
	elseif cur_list[1]==12 then		--�ɶ�
		return 3,0,18794,3,0,0
	elseif cur_list[1]==14 then		--��ħ��¼
		return 3,0,23296,1,0,0

	elseif cur_list[1]==2 then		--�������
		return 4,0,25306,1,0,0
	elseif cur_list[1]==8 then		--���Ǳ���
		return 4,0,25307,1,0,0
	elseif cur_list[1]==10 then		--���Ǳ���
		return 4,0,25307,1,0,0
	elseif cur_list[1]==16 then		--�������
		return 4,0,25306,1,0,0
	else													--���Ǳ���
		return 4,0,25307,1,0,0
	end
end 
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType40928Cashing(cur_list)		---(��������)
	if cur_list[1]==1 then 				--��������һ�ȯ
		return 1,0,40924,1,0,0
	elseif cur_list[1]==5 then		--����һ���
		return 1,0,23299,1,0,0
	elseif cur_list[1]==9 then		--��������һ�ȯ
		return 1,0,40924,1,0,0
	elseif cur_list[1]==13 then		--���ɶһ�ȯ
		return 1,0,28707,1,0,0

	elseif cur_list[1]==3 then		--ɳ̲װ�·��һ�ȯ
		return 2,0,40905,1,0,0
	elseif cur_list[1]==7 then		--ɳ̲װЬ�Ӷһ�ȯ
		return 2,0,40906,1,0,0
	elseif cur_list[1]==11 then		--ɳ̲װͷ�ζһ�ȯ
		return 2,0,40904,1,0,0
	elseif cur_list[1]==15 then		--ɳ̲װ�·��һ�ȯ
		return 2,0,40905,1,0,0

	elseif cur_list[1]==4 then		--�ɶ�
		return 3,0,18794,3,0,0
	elseif cur_list[1]==6 then		--�ɶ�
		return 3,0,18794,3,0,0
	elseif cur_list[1]==12 then		--�ɶ�
		return 3,0,18794,3,0,0
	elseif cur_list[1]==14 then		--�ɶ�
		return 3,0,18794,3,0,0

	elseif cur_list[1]==2 then		--�������
		return 4,0,25306,1,0,0
	elseif cur_list[1]==8 then		--���Ǳ���
		return 4,0,25307,1,0,0
	elseif cur_list[1]==10 then		--���Ǳ���
		return 4,0,25307,1,0,0
	elseif cur_list[1]==16 then		--�������
		return 4,0,25306,1,0,0
	else													--���Ǳ���
		return 4,0,25307,1,0,0
	end
end 

-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType32605Cashing(cur_list)		---(ʨ����¼)
	if cur_list[1]==1 then 				--��ëʨ���һ�ȯ
		return 1,0,32604,1,0,0

	elseif cur_list[1]==5 then		--����ʯ��
		return 2,0,28587,1,0,0
	elseif cur_list[1]==9 then		--��������
		return 2,0,11539,1,0,0
	elseif cur_list[1]==13 then		--���龫��
		return 2,0,24904,1,0,0

	elseif cur_list[1]==3 then		--�ɶ�
		return 3,0,18794,3,0,0
	elseif cur_list[1]==7 then		--������
		return 3,0,16551,1,0,0
	elseif cur_list[1]==11 then		--�۱���
		return 3,0,13343,10,0,0
	elseif cur_list[1]==15 then		--�ɶ�
		return 3,0,18794,3,0,0

	elseif cur_list[1]==2 then		--����
		return 4,0,8079,2,0,0
	elseif cur_list[1]==4 then		--����
		return 4,0,25306,1,0,0
	elseif cur_list[1]==6 then		--����
		return 4,0,25306,1,0,0
	elseif cur_list[1]==8 then		--����
		return 4,0,8079,2,0,0
	elseif cur_list[1]==10 then		--����
		return 4,0,8079,2,0,0
	elseif cur_list[1]==12 then		--����
		return 4,0,25307,1,0,0
	elseif cur_list[1]==14 then		--����
		return 4,0,25307,1,0,0
	else													--����
		return 4,0,8079,2,0,0
	end
end 

-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType42732Cashing(cur_list)		---(���ƴͱ�20110527����)
	if cur_list[1]==1 then 				--�˲�����
		return 1,0,42718,1,0,0
	elseif cur_list[1]==9 then		--�˲�����
		return 1,0,42718,1,0,0
	elseif cur_list[1]==5 then		--�ƺž���
		return 1,0,42710,1,0,0
	elseif cur_list[1]==13 then		--�ƺž���
		return 1,0,42710,1,0,0

	elseif cur_list[1]==3 then		--�þ�Ԫ��
		return 2,0,42712,1,0,0
	elseif cur_list[1]==7 then		--�þ�Ԫ��
		return 2,0,42712,1,0,0
	elseif cur_list[1]==11 then		--�þ�Ԫ��
		return 2,0,42712,1,0,0
	elseif cur_list[1]==15 then		--�þ�Ԫ��
		return 2,0,42712,1,0,0
		
	elseif cur_list[1]==4 then		--ǧ����Ǯ
		return 3,0,41171,1,0,0
  elseif cur_list[1]==6 then		--ǧ����Ǯ
		return 3,0,41171,1,0,0
	elseif cur_list[1]==12 then		--ǧ����Ǯ
		return 3,0,41171,1,0,0
	elseif cur_list[1]==14 then		--ǧ����Ǯ
		return 3,0,41171,1,0,0

	elseif cur_list[1]==8 then		--�컯��
		return 4,0,22343,100,0,0
	elseif cur_list[1]==10 then		--�컯��
		return 4,0,22343,100,0,0
	elseif cur_list[1]==2 then		--��*60
		return 4,0,42720,1,0,0
	else													--��*60
		return 4,0,42720,1,0,0
	end
end 
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType42784Cashing(cur_list)		---(��Ԫ�ز�)
if cur_list[1]==1 then 				--ʮ���������
		return 1,0,32103,1,0,0
	elseif cur_list[1]==5 then		--ǬԪ��̥
		return 1,0,40673,1,0,0
	elseif cur_list[1]==7 then		--��Ѫ��
		return 1,0,10876,1,0,0
	elseif cur_list[1]==11 then		--��ħѪ��
		return 1,0,33821,1,0,0
	elseif cur_list[1]==13 then		--��Ԫ�쾧�Ž�
		return 1,0,40668,1,0,0

	elseif cur_list[1]==3 then		--���������
		return 2,0,7931,1,0,0
	elseif cur_list[1]==9 then		--��������
		return 2,0,11539,1,0,0
	elseif cur_list[1]==15 then		--�������Ů
		return 2,0,7937,1,0,0

	elseif cur_list[1]==4 then		--�ɶ�
		return 3,0,18794,3,0,0
	elseif cur_list[1]==6 then		--�ɶ�
		return 3,0,18794,3,0,0
	elseif cur_list[1]==12 then		--�ɶ�
		return 3,0,18794,3,0,0
	elseif cur_list[1]==14 then		--�ɶ�
		return 3,0,18794,3,0,0

	elseif cur_list[1]==2 then		--��ʯ��
		return 4,0,42401,1,0,0
	elseif cur_list[1]==8 then		--��ʯ��
		return 4,0,42401,1,0,0
	elseif cur_list[1]==10 then		--��ʯ��
		return 4,0,42401,1,0,0
	elseif cur_list[1]==16 then		--��ʯ��
		return 4,0,42401,1,0,0
	else													--��ʯ��
		return 4,0,42401,1,0,0
	end
end 
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType42868Cashing(cur_list)		---(��������)
	if cur_list[1]==1 then 				--��ˮ����
		return 1,0,42865,1,0,0
	elseif cur_list[1]==5 then		--ǬԪ��̥
		return 1,0,40673,1,0,0
	elseif cur_list[1]==9 then		--20�߼�Ԫ�������
		return 1,0,42862,1,0,0
	elseif cur_list[1]==13 then		--ʮ���������
		return 1,0,32103,1,0,0

	elseif cur_list[1]==3 then		--��Ͳ���
		return 2,0,42866,1,0,0
	elseif cur_list[1]==7 then		--�ܷｨľ
		return 2,0,13903,1,0,0
	elseif cur_list[1]==11 then		--��������
		return 2,0,13904,1,0,0
	elseif cur_list[1]==15 then		--�������
		return 2,0,42867,1,0,0

	elseif cur_list[1]==4 then		--�ɶ�
		return 3,0,18794,3,0,0
	elseif cur_list[1]==6 then		--�ɶ�
		return 3,0,18794,3,0,0
	elseif cur_list[1]==12 then		--�ɶ�
		return 3,0,18794,3,0,0
	elseif cur_list[1]==14 then		--�ɶ�
		return 3,0,18794,3,0,0

	elseif cur_list[1]==2 then		--��ʯ��
		return 4,0,42401,1,0,0
	elseif cur_list[1]==8 then		--��ʯ��
		return 4,0,42401,1,0,0
	elseif cur_list[1]==10 then		--��ʯ��
		return 4,0,42401,1,0,0
	elseif cur_list[1]==16 then		--��ʯ��
		return 4,0,42401,1,0,0
	else													--��ʯ��
		return 4,0,42401,1,0,0
	end
end 
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType25417Cashing(cur_list)		---(Ѫ����ľ)
	if cur_list[1]==1 then 				--ҹ�ɶһ�ȯ
		return 1,0,25419,1,0,0
	elseif cur_list[1]==9 then		--ҹ�ɶһ�ȯ
		return 1,0,25419,1,0,0

	elseif cur_list[1]==5 then		--�а���
		return 2,0,7931,1,0,0
	elseif cur_list[1]==13 then		--Ů����
		return 2,0,7937,1,0,0

	elseif cur_list[1]==3 then		--�ɶ�
		return 3,0,18794,3,0,0
	elseif cur_list[1]==7 then		--�ɶ�
		return 3,0,18794,3,0,0
	elseif cur_list[1]==11 then		--�ɶ�
		return 3,0,18794,3,0,0
	elseif cur_list[1]==15 then		--�ɶ�
		return 3,0,18794,3,0,0

	elseif cur_list[1]==2 then		--����
		return 4,0,8079,2,0,0
	elseif cur_list[1]==4 then		--����
		return 4,0,25306,1,0,0
	elseif cur_list[1]==6 then		--����
		return 4,0,25306,1,0,0
	elseif cur_list[1]==8 then		--����
		return 4,0,8079,2,0,0
	elseif cur_list[1]==10 then		--����
		return 4,0,8079,2,0,0
	elseif cur_list[1]==12 then		--����
		return 4,0,25307,1,0,0
	elseif cur_list[1]==14 then		--����
		return 4,0,25307,1,0,0
	else													--����
		return 4,0,8079,2,0,0
	end
end
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType42665Cashing(cur_list)		---(��������)
	if cur_list[1]==1 then 				--ʮ���������
		return 1,0,32103,1,0,0
	elseif cur_list[1]==5 then		--���޵����
		return 1,0,21189,1,0,0
	elseif cur_list[1]==7 then		--��ĸ���ɽ�
		return 1,0,42661,1,0,0
	elseif cur_list[1]==11 then		--��ĸ������
		return 1,0,42662,1,0,0
	elseif cur_list[1]==13 then		--���������
		return 1,0,24903,1,0,0

	elseif cur_list[1]==3 then		--���龫��
		return 2,0,24904,1,0,0
	elseif cur_list[1]==9 then		--������ƪ
		return 2,0,18797,1,0,0
	elseif cur_list[1]==15 then		--����ʯ��
		return 2,0,28587,1,0,0

	elseif cur_list[1]==4 then		--�ɶ�
		return 3,0,18794,3,0,0
	elseif cur_list[1]==6 then		--�ɶ�
		return 3,0,18794,3,0,0
	elseif cur_list[1]==12 then		--�ɶ�
		return 3,0,18794,3,0,0
	elseif cur_list[1]==14 then		--�ɶ�
		return 3,0,18794,3,0,0

	elseif cur_list[1]==2 then		--��ʯ��
		return 4,0,42401,1,0,0
	elseif cur_list[1]==8 then		--��ʯ��
		return 4,0,42401,1,0,0
	elseif cur_list[1]==10 then		--��ʯ��
		return 4,0,42401,1,0,0
	elseif cur_list[1]==16 then		--��ʯ��
		return 4,0,42401,1,0,0
	else													--��ʯ��
		return 4,0,42401,1,0,0
	end
end 
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType44403Cashing(cur_list)		---(����ѩ��)
	if cur_list[1]==1 then 				--�������
		return 1,0,44495,1,0,0
	elseif cur_list[1]==5 then		--��Ԫ�쾧�Ž�
		return 1,0,40668,1,0,0
	elseif cur_list[1]==9 then		--ʮ���������
		return 1,0,32103,1,0,0
	elseif cur_list[1]==13 then		--ǬԪ��̥
		return 1,0,40673,1,0,0

	elseif cur_list[1]==3 then		--����ʯ��
		return 2,0,28587,1,0,0
	elseif cur_list[1]==7 then		--������ƪ
		return 2,0,18797,1,0,0
	elseif cur_list[1]==11 then		--���龫��
		return 2,0,24904,1,0,0
	elseif cur_list[1]==15 then		--����ϴ����
		return 2,0,42400,1,0,0

	elseif cur_list[1]==4 then		--�ɶ�
		return 3,0,18794,3,0,0
	elseif cur_list[1]==6 then		--�ɶ�
		return 3,0,18794,3,0,0
	elseif cur_list[1]==12 then		--�ɶ�
		return 3,0,18794,3,0,0
	elseif cur_list[1]==14 then		--�ɶ�
		return 3,0,18794,3,0,0

	elseif cur_list[1]==2 then		--��ʯ��
		return 4,0,42401,1,0,0
	elseif cur_list[1]==8 then		--��ʯ��
		return 4,0,42401,1,0,0
	elseif cur_list[1]==10 then		--��ʯ��
		return 4,0,42401,1,0,0
	elseif cur_list[1]==16 then		--��ʯ��
		return 4,0,42401,1,0,0
	else													--��ʯ��
		return 4,0,42401,1,0,0
	end
end 
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType42353Cashing(cur_list)		---(�ŋ����)
	if cur_list[1]==1 then 				--����
		return 1,0,42352,1,0,0
	elseif cur_list[1]==5 then		--ǬԪ��̥
		return 1,0,40673,1,0,0
	elseif cur_list[1]==9 then		--����ʱװ�һ�ȯ
		return 1,0,42399,1,0,0
	elseif cur_list[1]==13 then		--ʮ���������
		return 1,0,32103,1,0,0

	elseif cur_list[1]==3 then		--̫��
		return 2,0,25729,1,0,0
	elseif cur_list[1]==7 then		--�컯��¼
		return 2,0,40527,1,0,0
	elseif cur_list[1]==11 then		--��Ӫȫϴ�һ�ȯ
		return 2,0,42400,1,0,0
	elseif cur_list[1]==15 then		--̫�
		return 2,0,25728,1,0,0

	elseif cur_list[1]==4 then		--�ɶ�
		return 3,0,18794,3,0,0
	elseif cur_list[1]==6 then		--�ɶ�
		return 3,0,18794,3,0,0
	elseif cur_list[1]==12 then		--�ɶ�
		return 3,0,18794,3,0,0
	elseif cur_list[1]==14 then		--�ɶ�
		return 3,0,18794,3,0,0

	elseif cur_list[1]==2 then		--��ʯ��
		return 4,0,42401,1,0,0
	elseif cur_list[1]==8 then		--��ʯ��
		return 4,0,42401,1,0,0
	elseif cur_list[1]==10 then		--��ʯ��
		return 4,0,42401,1,0,0
	elseif cur_list[1]==16 then		--��ʯ��
		return 4,0,42401,1,0,0
	else													--��ʯ��
		return 4,0,42401,1,0,0
	end
end 
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType40529Cashing(cur_list)		---(�������)
	if cur_list[1]==1 then 				--����һ�ȯ
		return 1,0,40531,1,0,0

	elseif cur_list[1]==5 then		--̫�
		return 2,0,25728,1,0,0
	elseif cur_list[1]==9 then		--�컯�䷽���
		return 2,0,40527,1,0,0
	elseif cur_list[1]==13 then		--̫��
		return 2,0,25729,1,0,0

	elseif cur_list[1]==3 then		--�ɶ�
		return 3,0,18794,3,0,0
	elseif cur_list[1]==7 then		--�ɶ�
		return 3,0,18794,3,0,0
	elseif cur_list[1]==11 then		--�ɶ�
		return 3,0,18794,3,0,0
	elseif cur_list[1]==15 then		--�ɶ�
		return 3,0,18794,3,0,0

	elseif cur_list[1]==2 then		--�سǾ�
		return 4,0,8079,2,0,0
	elseif cur_list[1]==4 then		--����
		return 4,0,25307,1,0,0
	elseif cur_list[1]==6 then		--����
		return 4,0,25306,1,0,0
	elseif cur_list[1]==8 then		--�سǾ�
		return 4,0,8079,2,0,0
	elseif cur_list[1]==10 then		--�سǾ�
		return 4,0,8079,2,0,0
	elseif cur_list[1]==12 then		--����
		return 4,0,25306,1,0,0
	elseif cur_list[1]==14 then		--����
		return 4,0,25307,1,0,0
	else													--�سǾ�
		return 4,0,8079,2,0,0
	end
end 
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType44638Cashing(cur_list)		---(������ϻ)
	if cur_list[1]==1 then 				--120�������
		return 1,0,40510,1,0,0
	elseif cur_list[1]==5 then		--���޵����
		return 1,0,21189,1,0,0
	elseif cur_list[1]==9 then		--ʮ���������
		return 1,0,32103,1,0,0
	elseif cur_list[1]==13 then		--���������
		return 1,0,24903,1,0,0

	elseif cur_list[1]==3 then		--����������
		return 2,0,43570,1,0,0
	elseif cur_list[1]==7 then		--̫��
		return 2,0,25729,1,0,0
	elseif cur_list[1]==11 then		--̫�
		return 2,0,25728,1,0,0
	elseif cur_list[1]==15 then		--�컯��¼
		return 2,0,40527,1,0,0

	elseif cur_list[1]==4 then		--�ɶ�
		return 3,0,18794,3,0,0
	elseif cur_list[1]==6 then		--�ɶ�
		return 3,0,18794,3,0,0
	elseif cur_list[1]==12 then		--�ɶ�
		return 3,0,18794,3,0,0
	elseif cur_list[1]==14 then		--�ɶ�
		return 3,0,18794,3,0,0

	elseif cur_list[1]==2 then		--��ʯ��
		return 4,0,42401,1,0,0
	elseif cur_list[1]==8 then		--��ʯ��
		return 4,0,42401,1,0,0
	elseif cur_list[1]==10 then		--��ʯ��
		return 4,0,42401,1,0,0
	elseif cur_list[1]==16 then		--��ʯ��
		return 4,0,42401,1,0,0
	else													--��ʯ��
		return 4,0,42401,1,0,0
	end
end 
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType43403Cashing(cur_list)		---(2011���Ӳ�Ʊ)
	if cur_list[1]==1 then 				--��������
		return 1,0,43466,1,0,0
	elseif cur_list[1]==5 then		--���޵����
		return 1,0,21189,1,0,0
	elseif cur_list[1]==9 then		--ʮ���������
		return 1,0,32103,1,0,0
	elseif cur_list[1]==13 then		--���������
		return 1,0,24903,1,0,0

	elseif cur_list[1]==3 then		--��ң���ҡ�����
		return 2,0,21744,1,0,0
	elseif cur_list[1]==7 then		--���н��ҡ�����
		return 2,0,21742,1,0,0
	elseif cur_list[1]==11 then		--̫����ҡ�����
		return 2,0,21743,1,0,0
	elseif cur_list[1]==15 then		--����ʥӡ
		return 2,0,18911,1,0,0

	elseif cur_list[1]==4 then		--�ɶ�
		return 3,0,18794,3,0,0
	elseif cur_list[1]==6 then		--�ɶ�
		return 3,0,18794,3,0,0
	elseif cur_list[1]==12 then		--�ɶ�
		return 3,0,18794,3,0,0
	elseif cur_list[1]==14 then		--�ɶ�
		return 3,0,18794,3,0,0

	elseif cur_list[1]==2 then		--��ʯ��
		return 4,0,42401,1,0,0
	elseif cur_list[1]==8 then		--��ʯ��
		return 4,0,42401,1,0,0
	elseif cur_list[1]==10 then		--��ʯ��
		return 4,0,42401,1,0,0
	elseif cur_list[1]==16 then		--��ʯ��
		return 4,0,42401,1,0,0
	else													--��ʯ��
		return 4,0,42401,1,0,0
	end
end 
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType50621Cashing(cur_list)		---(̫������)
	if cur_list[1]==1 then 				--����
		return 1,0,44495,1,0,0
	elseif cur_list[1]==5 then		--ʮ���������
		return 1,0,32103,1,0,0
	elseif cur_list[1]==9 then		--�ɻ�
		return 1,0,50620,1,0,0
	elseif cur_list[1]==13 then		--��Ԫ�쾧�Ž�
		return 1,0,40668,1,0,0

	elseif cur_list[1]==3 then		--2�Ƚ���ʯ��
		return 2,0,49293,1,0,0
	elseif cur_list[1]==7 then		--2�Ƚ���ʯ��
		return 2,0,49293,1,0,0
	elseif cur_list[1]==11 then		--2�Ƚ���ʯ��
		return 2,0,49293,1,0,0
	elseif cur_list[1]==15 then		--2�Ƚ���ʯ��
		return 2,0,49293,1,0,0

	elseif cur_list[1]==4 then		--�ɶ�
		return 3,0,18794,3,0,0
	elseif cur_list[1]==6 then		--�ɶ�
		return 3,0,18794,3,0,0
	elseif cur_list[1]==12 then		--�ɶ�
		return 3,0,18794,3,0,0
	elseif cur_list[1]==14 then		--�ɶ�
		return 3,0,18794,3,0,0

	elseif cur_list[1]==2 then		--��ʯ��
		return 4,0,42401,1,0,0
	elseif cur_list[1]==8 then		--��ʯ��
		return 4,0,42401,1,0,0
	elseif cur_list[1]==10 then		--��ʯ��
		return 4,0,42401,1,0,0
	elseif cur_list[1]==16 then		--��ʯ��
		return 4,0,42401,1,0,0
	else													--��ʯ��
		return 4,0,42401,1,0,0
	end
end 
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType44764Cashing(cur_list)		---(��Ե����)
	if cur_list[1]==1 then 				--����ʱװ�һ�ȯ
		return 1,0,42399,1,0,0
	elseif cur_list[1]==5 then		--20�߼�Ԫ�������
		return 1,0,42862,1,0,0
	elseif cur_list[1]==13 then		--ʮ���������
		return 1,0,32103,1,0,0

	elseif cur_list[1]==3 then		--�������Ů
		return 2,0,7937,1,0,0
	elseif cur_list[1]==7 then		--���������
		return 2,0,7931,1,0,0
	elseif cur_list[1]==9 then		--��������
		return 2,0,11539,1,0,0
	elseif cur_list[1]==11 then		--���������
		return 2,0,7931,1,0,0
	elseif cur_list[1]==15 then		--�������Ů
		return 2,0,7937,1,0,0

	elseif cur_list[1]==4 then		--�ɶ�
		return 3,0,18794,3,0,0
	elseif cur_list[1]==6 then		--�ɶ�
		return 3,0,18794,3,0,0
	elseif cur_list[1]==12 then		--�ɶ�
		return 3,0,18794,3,0,0
	elseif cur_list[1]==14 then		--�ɶ�
		return 3,0,18794,3,0,0

	elseif cur_list[1]==2 then		--��ʯ��
		return 4,0,42401,1,0,0
	elseif cur_list[1]==8 then		--��ʯ��
		return 4,0,42401,1,0,0
	elseif cur_list[1]==10 then		--��ʯ��
		return 4,0,42401,1,0,0
	elseif cur_list[1]==16 then		--��ʯ��
		return 4,0,42401,1,0,0
	else													--��ʯ��
		return 4,0,42401,1,0,0
	end
end
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType50824Cashing(cur_list)		---(��Դ��¼)
	if cur_list[1]==1 then 				--�һ���
		return 1,0,50845,1,0,0
	elseif cur_list[1]==5 then		--�������
		return 1,0,40510,1,0,0
	elseif cur_list[1]==9 then		--ʮ���������
		return 1,0,32103,1,0,0
	elseif cur_list[1]==13 then		--�������
		return 1,0,42862,1,0,0

	elseif cur_list[1]==3 then		--2�Ƚ���ʯ��
		return 2,0,49293,1,0,0
	elseif cur_list[1]==7 then		--2�Ƚ���ʯ��
		return 2,0,49293,1,0,0
	elseif cur_list[1]==11 then		--2�Ƚ���ʯ��
		return 2,0,49293,1,0,0
	elseif cur_list[1]==15 then		--2�Ƚ���ʯ��
		return 2,0,49293,1,0,0

	elseif cur_list[1]==4 then		--�ɶ�
		return 3,0,18794,3,0,0
	elseif cur_list[1]==6 then		--�ɶ�
		return 3,0,18794,3,0,0
	elseif cur_list[1]==12 then		--�ɶ�
		return 3,0,18794,3,0,0
	elseif cur_list[1]==14 then		--�ɶ�
		return 3,0,18794,3,0,0

	elseif cur_list[1]==2 then		--��ʯ��
		return 4,0,42401,1,0,0
	elseif cur_list[1]==8 then		--��ʯ��
		return 4,0,42401,1,0,0
	elseif cur_list[1]==10 then		--��ʯ��
		return 4,0,42401,1,0,0
	elseif cur_list[1]==16 then		--��ʯ��
		return 4,0,42401,1,0,0
	else													--��ʯ��
		return 4,0,42401,1,0,0
	end
end  
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType44766Cashing(cur_list)		---(����_��������)
	if cur_list[1]==1 then 				--ī��
		return 1,0,44765,1,0,0
	elseif cur_list[1]==5 then		--ǬԪ��̥
		return 1,0,40673,1,0,0
	elseif cur_list[1]==9 then		--ʮ���������
		return 1,0,32103,1,0,0
	elseif cur_list[1]==13 then		--��Ԫ�쾧�Ž�
		return 1,0,40668,1,0,0

	elseif cur_list[1]==3 then		--�ܷｨľ
		return 2,0,13903,1,0,0
	elseif cur_list[1]==7 then		--����ʥӡ
		return 2,0,18911,1,0,0
	elseif cur_list[1]==11 then		--����ʥӡ
		return 2,0,18911,1,0,0
	elseif cur_list[1]==15 then		--��������
		return 2,0,13904,1,0,0

	elseif cur_list[1]==4 then		--�ɶ�
		return 3,0,18794,3,0,0
	elseif cur_list[1]==6 then		--�ɶ�
		return 3,0,18794,3,0,0
	elseif cur_list[1]==12 then		--�ɶ�
		return 3,0,18794,3,0,0
	elseif cur_list[1]==14 then		--�ɶ�
		return 3,0,18794,3,0,0

	elseif cur_list[1]==2 then		--��ʯ��
		return 4,0,42401,1,0,0
	elseif cur_list[1]==8 then		--��ʯ��
		return 4,0,42401,1,0,0
	elseif cur_list[1]==10 then		--��ʯ��
		return 4,0,42401,1,0,0
	elseif cur_list[1]==16 then		--��ʯ��
		return 4,0,42401,1,0,0
	else													--��ʯ��
		return 4,0,42401,1,0,0
	end
end 
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType33530Cashing(cur_list)		---(������)
	if cur_list[1]==1 then 				--ڤ���һ�ȯ
		return 1,0,33529,1,0,0
	elseif cur_list[1]==9 then		--10������һ�ȯ
		return 1,0,32103,1,0,0

	elseif cur_list[1]==5 then		--�а���
		return 2,0,7931,1,0,0
	elseif cur_list[1]==13 then		--Ů����
		return 2,0,7937,1,0,0

	elseif cur_list[1]==3 then		--�ɶ�
		return 3,0,18794,3,0,0
	elseif cur_list[1]==7 then		--�ɶ�
		return 3,0,18794,3,0,0
	elseif cur_list[1]==11 then		--�ɶ�
		return 3,0,18794,3,0,0
	elseif cur_list[1]==15 then		--�ɶ�
		return 3,0,18794,3,0,0

	elseif cur_list[1]==2 then		--����
		return 4,0,25307,1,0,0
	elseif cur_list[1]==4 then		--����
		return 4,0,25306,1,0,0
	elseif cur_list[1]==6 then		--����
		return 4,0,25306,1,0,0
	elseif cur_list[1]==8 then		--����
		return 4,0,25307,1,0,0
	elseif cur_list[1]==10 then		--����
		return 4,0,25307,1,0,0
	elseif cur_list[1]==12 then		--����
		return 4,0,25306,1,0,0
	elseif cur_list[1]==14 then		--����
		return 4,0,25306,1,0,0
	else													--����
		return 4,0,25307,1,0,0
	end
end 
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType51097Cashing(cur_list)		---(������֥)
	if cur_list[1]==1 then 				--��������
		return 1,0,51082,1,0,0
	elseif cur_list[1]==5 then		--����
		return 1,0,44495,1,0,0
	elseif cur_list[1]==9 then		--ʮ���������
		return 1,0,32103,1,0,0
	elseif cur_list[1]==13 then		--�ɻ�
		return 1,0,50620,1,0,0

	elseif cur_list[1]==3 then		--2�Ƚ���ʯ��
		return 2,0,49293,1,0,0
	elseif cur_list[1]==7 then		--2�Ƚ���ʯ��
		return 2,0,49293,1,0,0
	elseif cur_list[1]==11 then		--2�Ƚ���ʯ��
		return 2,0,49293,1,0,0
	elseif cur_list[1]==15 then		--2�Ƚ���ʯ��
		return 2,0,49293,1,0,0

	elseif cur_list[1]==4 then		--�ɶ�
		return 3,0,18794,3,0,0
	elseif cur_list[1]==6 then		--�ɶ�
		return 3,0,18794,3,0,0
	elseif cur_list[1]==12 then		--�ɶ�
		return 3,0,18794,3,0,0
	elseif cur_list[1]==14 then		--�ɶ�
		return 3,0,18794,3,0,0

	elseif cur_list[1]==2 then		--��ʯ��
		return 4,0,42401,1,0,0
	elseif cur_list[1]==8 then		--��ʯ��
		return 4,0,42401,1,0,0
	elseif cur_list[1]==10 then		--��ʯ��
		return 4,0,42401,1,0,0
	elseif cur_list[1]==16 then		--��ʯ��
		return 4,0,42401,1,0,0
	else													--��ʯ��
		return 4,0,42401,1,0,0
	end
end 
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType51203Cashing(cur_list)		---(��������)
	if cur_list[1]==1 then 				--��������
		return 1,0,51202,1,0,0
	elseif cur_list[1]==5 then		--�������
		return 1,0,42862,1,0,0
	elseif cur_list[1]==9 then		--ʮ���������
		return 1,0,32103,1,0,0
	elseif cur_list[1]==13 then		--�������
		return 1,0,40510,1,0,0

	elseif cur_list[1]==3 then		--2�Ƚ���ʯ��
		return 2,0,49293,1,0,0
	elseif cur_list[1]==7 then		--2�Ƚ���ʯ��
		return 2,0,49293,1,0,0
	elseif cur_list[1]==11 then		--2�Ƚ���ʯ��
		return 2,0,49293,1,0,0
	elseif cur_list[1]==15 then		--2�Ƚ���ʯ��
		return 2,0,49293,1,0,0

	elseif cur_list[1]==4 then		--�ɶ�
		return 3,0,18794,3,0,0
	elseif cur_list[1]==6 then		--�ɶ�
		return 3,0,18794,3,0,0
	elseif cur_list[1]==12 then		--�ɶ�
		return 3,0,18794,3,0,0
	elseif cur_list[1]==14 then		--�ɶ�
		return 3,0,18794,3,0,0

	elseif cur_list[1]==2 then		--��ʯ��
		return 4,0,42401,1,0,0
	elseif cur_list[1]==8 then		--��ʯ��
		return 4,0,42401,1,0,0
	elseif cur_list[1]==10 then		--��ʯ��
		return 4,0,42401,1,0,0
	elseif cur_list[1]==16 then		--��ʯ��
		return 4,0,42401,1,0,0
	else													--��ʯ��
		return 4,0,42401,1,0,0
	end
end 
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType51267Cashing(cur_list)		---(������ʯ)
	if cur_list[1]==1 then 				--ʥ����
		return 1,0,51290,1,0,0
	elseif cur_list[1]==5 then		--��Ԫ�쾧9��
		return 1,0,40668,1,0,0
	elseif cur_list[1]==9 then		--ʮ���������
		return 1,0,32103,1,0,0
	elseif cur_list[1]==13 then		--ǬԪ��̥
		return 1,0,40673,1,0,0

	elseif cur_list[1]==3 then		--2�Ƚ���ʯ��
		return 2,0,49293,1,0,0
	elseif cur_list[1]==7 then		--2�Ƚ���ʯ��
		return 2,0,49293,1,0,0
	elseif cur_list[1]==11 then		--2�Ƚ���ʯ��
		return 2,0,49293,1,0,0
	elseif cur_list[1]==15 then		--2�Ƚ���ʯ��
		return 2,0,49293,1,0,0

	elseif cur_list[1]==4 then		--�ɶ�
		return 3,0,18794,3,0,0
	elseif cur_list[1]==6 then		--�ɶ�
		return 3,0,18794,3,0,0
	elseif cur_list[1]==12 then		--�ɶ�
		return 3,0,18794,3,0,0
	elseif cur_list[1]==14 then		--�ɶ�
		return 3,0,18794,3,0,0

	elseif cur_list[1]==2 then		--��ʯ��
		return 4,0,42401,1,0,0
	elseif cur_list[1]==8 then		--��ʯ��
		return 4,0,42401,1,0,0
	elseif cur_list[1]==10 then		--��ʯ��
		return 4,0,42401,1,0,0
	elseif cur_list[1]==16 then		--��ʯ��
		return 4,0,42401,1,0,0
	else													--��ʯ��
		return 4,0,42401,1,0,0
	end
end 
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType40670Cashing(cur_list)		---(����_�˼��¯)
	if cur_list[1]==1 then 				--ǬԪ��̥
		return 1,0,40673,1,0,0
	elseif cur_list[1]==5 then		--��Ԫ�쾧
		return 1,0,40668,1,0,0
	elseif cur_list[1]==9 then		--������10
		return 1,0,32103,1,0,0
	elseif cur_list[1]==13 then		--ǬԪ��̥
		return 1,0,40673,1,0,0

	elseif cur_list[1]==3 then		--���н��ҡ�����
		return 2,0,21742,1,0,0
	elseif cur_list[1]==7 then		--��ң���ҡ�����
		return 2,0,21744,1,0,0
	elseif cur_list[1]==11 then		--̫����ҡ�����
		return 2,0,21743,1,0,0
	elseif cur_list[1]==15 then		--���н��ҡ�����
		return 2,0,21742,1,0,0

	elseif cur_list[1]==4 then		--�ɶ�
		return 3,0,18794,3,0,0
	elseif cur_list[1]==6 then		--�ɶ�
		return 3,0,18794,3,0,0
	elseif cur_list[1]==12 then		--�ɶ�
		return 3,0,18794,3,0,0
	elseif cur_list[1]==14 then		--�ɶ�
		return 3,0,18794,3,0,0

	elseif cur_list[1]==2 then		--�������
		return 4,0,25306,1,0,0
	elseif cur_list[1]==8 then		--���Ǳ���
		return 4,0,25307,1,0,0
	elseif cur_list[1]==10 then		--���Ǳ���
		return 4,0,25307,1,0,0
	elseif cur_list[1]==16 then		--�������
		return 4,0,25306,1,0,0
	else													--���Ǳ���
		return 4,0,25307,1,0,0
	end
end 
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType40344Cashing(cur_list)		---(����_ʮȫ����)
	if cur_list[1]==1 then 				--���޵����
		return 1,0,21189,1,0,0
	elseif cur_list[1]==5 then		--������
		return 1,0,33820,1,0,0
	elseif cur_list[1]==9 then		--10���������
		return 1,0,32103,1,0,0
	elseif cur_list[1]==13 then		--��Ѫ�����
		return 1,0,40338,1,0,0

	elseif cur_list[1]==3 then		--��������
		return 2,0,11539,1,0,0
	elseif cur_list[1]==7 then		--Ů����
		return 2,0,7937,1,0,0
	elseif cur_list[1]==11 then		--�а���
		return 2,0,7931,1,0,0
	elseif cur_list[1]==15 then		--��������
		return 2,0,11539,1,0,0

	elseif cur_list[1]==4 then		--�ɶ�����
		return 3,0,18794,3,0,0
	elseif cur_list[1]==6 then		--�ɶ�����
		return 3,0,18794,3,0,0
	elseif cur_list[1]==12 then		--�ɶ�����
		return 3,0,18794,3,0,0
	elseif cur_list[1]==14 then		--�ɶ�����
		return 3,0,18794,3,0,0

	elseif cur_list[1]==2 then		--��������
		return 4,0,25307,1,0,0
	elseif cur_list[1]==8 then		--��������
		return 4,0,25306,1,0,0
	elseif cur_list[1]==10 then		--��������
		return 4,0,25306,1,0,0
	else													--��������
		return 4,0,25307,1,0,0
	end
end 
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType35361Cashing(cur_list)		---(����ϻ)
	if cur_list[1]==1 then 				--��˿��������籶һ�ȯ
		return 1,0,35359,1,0,0

	elseif cur_list[1]==5 then		--����ʯ��
		return 2,0,28587,1,0,0
	elseif cur_list[1]==9 then		--����ʯ��
		return 2,0,28587,1,0,0
	elseif cur_list[1]==13 then		--����ʯ��
		return 2,0,28587,1,0,0

	elseif cur_list[1]==3 then		--�۱���
		return 3,0,13343,10,0,0
	elseif cur_list[1]==7 then		--�۱���
		return 3,0,13343,10,0,0
	elseif cur_list[1]==11 then		--�۱���
		return 3,0,13343,10,0,0
	elseif cur_list[1]==15 then		--�۱���
		return 3,0,13343,10,0,0

	elseif cur_list[1]==2 then		--�������
		return 4,0,8079,2,0,0
	elseif cur_list[1]==4 then		--����
		return 4,0,25307,1,0,0
	elseif cur_list[1]==6 then		--����
		return 4,0,25306,1,0,0
	elseif cur_list[1]==8 then		--�������
		return 4,0,8079,2,0,0
	elseif cur_list[1]==10 then		--�������
		return 4,0,8079,2,0,0
	elseif cur_list[1]==12 then		--����
		return 4,0,25306,1,0,0
	elseif cur_list[1]==14 then		--����
		return 4,0,25307,1,0,0
	else													--�������
		return 4,0,8079,2,0,0
	end
end 
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType32692Cashing(cur_list)		---(���޻�Ҷ)
	if cur_list[1]==1 then 				--�����һ�ȯ
		return 1,0,32710,1,0,0
	elseif cur_list[1]==9 then		--�����һ�ȯ
		return 1,0,32710,1,0,0

	elseif cur_list[1]==5 then		--̫��
		return 2,0,25729,1,0,0
	elseif cur_list[1]==13 then		--̫�
		return 2,0,25728,1,0,0

	elseif cur_list[1]==3 then		--�ɶ�
		return 3,0,18794,3,0,0
	elseif cur_list[1]==7 then		--�۱���
		return 3,0,13343,10,0,0
	elseif cur_list[1]==11 then		--�۱���
		return 3,0,13343,10,0,0
	elseif cur_list[1]==15 then		--�ɶ�
		return 3,0,18794,3,0,0

	elseif cur_list[1]==2 then		--����
		return 4,0,8079,2,0,0
	elseif cur_list[1]==4 then		--����
		return 4,0,25306,1,0,0
	elseif cur_list[1]==6 then		--����
		return 4,0,25306,1,0,0
	elseif cur_list[1]==8 then		--����
		return 4,0,8079,2,0,0
	elseif cur_list[1]==10 then		--����
		return 4,0,8079,2,0,0
	elseif cur_list[1]==12 then		--����
		return 4,0,25307,1,0,0
	elseif cur_list[1]==14 then		--����
		return 4,0,25307,1,0,0
	else													--����
		return 4,0,8079,2,0,0
	end
end 
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType41391Cashing(cur_list)		---(Х�����)
	if cur_list[1]==1 then 				--��ƶһ�ȯ
		return 1,0,41390,1,0,0
	elseif cur_list[1]==5 then		--���
		return 1,0,33820,1,0,0
	elseif cur_list[1]==9 then		--��ħѪ��
		return 1,0,33821,1,0,0
	elseif cur_list[1]==13 then		--��Ѫ��
		return 1,0,40338,1,0,0

	elseif cur_list[1]==3 then		--���������
		return 2,0,19127,1,0,0
	elseif cur_list[1]==7 then		--��Ы�����
		return 2,0,19129,1,0,0
	elseif cur_list[1]==11 then		--��������Ů
		return 2,0,13306,1,0,0
	elseif cur_list[1]==15 then		--��������Ů
		return 2,0,19130,1,0,0

	elseif cur_list[1]==4 then		--�ɶ�
		return 3,0,18794,3,0,0
	elseif cur_list[1]==6 then		--�ɶ�
		return 3,0,18794,3,0,0
	elseif cur_list[1]==12 then		--�ɶ�
		return 3,0,18794,3,0,0
	elseif cur_list[1]==14 then		--�ɶ�
		return 3,0,18794,3,0,0

	elseif cur_list[1]==2 then		--�������
		return 4,0,25306,1,0,0
	elseif cur_list[1]==8 then		--�������
		return 4,0,25306,1,0,0
	elseif cur_list[1]==10 then		--���Ǳ���
		return 4,0,25307,1,0,0
	elseif cur_list[1]==16 then		--���Ǳ���
		return 4,0,25307,1,0,0
	else													--���Ǳ���
		return 4,0,25307,1,0,0
	end
end 
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType52346Cashing(cur_list)		---(ʱ�ⱦ��)
	if cur_list[1]==1 then 				--��Ӱ�ɽ�
		return 1,0,52345,1,0,0
	elseif cur_list[1]==5 then		--�ټƷ���һ�ȯ
		return 1,0,52343,1,0,0
	elseif cur_list[1]==9 then		--ʮ���������
		return 1,0,32103,1,0,0
	elseif cur_list[1]==13 then		--�ټƽ���һ�ȯ
		return 1,0,52342,1,0,0

	elseif cur_list[1]==3 then		--2�Ƚ���ʯ��
		return 2,0,49293,1,0,0
	elseif cur_list[1]==7 then		--2�Ƚ���ʯ��
		return 2,0,49293,1,0,0
	elseif cur_list[1]==11 then		--2�Ƚ���ʯ��
		return 2,0,49293,1,0,0
	elseif cur_list[1]==15 then		--2�Ƚ���ʯ��
		return 2,0,49293,1,0,0

	elseif cur_list[1]==4 then		--�ɶ�
		return 3,0,18794,3,0,0
	elseif cur_list[1]==6 then		--�ɶ�
		return 3,0,18794,3,0,0
	elseif cur_list[1]==12 then		--�ɶ�
		return 3,0,18794,3,0,0
	elseif cur_list[1]==14 then		--�ɶ�
		return 3,0,18794,3,0,0

	elseif cur_list[1]==2 then		--��ʯ��
		return 4,0,42401,1,0,0
	elseif cur_list[1]==8 then		--��ʯ��
		return 4,0,42401,1,0,0
	elseif cur_list[1]==10 then		--��ʯ��
		return 4,0,42401,1,0,0
	elseif cur_list[1]==16 then		--��ʯ��
		return 4,0,42401,1,0,0
	else													--��ʯ��
		return 4,0,42401,1,0,0
	end
end
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType51452Cashing(cur_list)		---(��ɫ����)
	if cur_list[1]==1 then 				--������ƾ�����
		return 1,0,51451,1,0,0
	elseif cur_list[1]==5 then		--��Ԫ�쾧9��
		return 1,0,40668,1,0,0
	elseif cur_list[1]==9 then		--ʮ���������
		return 1,0,32103,1,0,0
	elseif cur_list[1]==13 then		--����ʱװ�һ�ȯ
		return 1,0,42399,1,0,0

	elseif cur_list[1]==3 then		--2�Ƚ���ʯ��
		return 2,0,49293,1,0,0
	elseif cur_list[1]==7 then		--2�Ƚ���ʯ��
		return 2,0,49293,1,0,0
	elseif cur_list[1]==11 then		--2�Ƚ���ʯ��
		return 2,0,49293,1,0,0
	elseif cur_list[1]==15 then		--2�Ƚ���ʯ��
		return 2,0,49293,1,0,0

	elseif cur_list[1]==4 then		--�ɶ�
		return 3,0,18794,3,0,0
	elseif cur_list[1]==6 then		--�ɶ�
		return 3,0,18794,3,0,0
	elseif cur_list[1]==12 then		--�ɶ�
		return 3,0,18794,3,0,0
	elseif cur_list[1]==14 then		--�ɶ�
		return 3,0,18794,3,0,0

	elseif cur_list[1]==2 then		--��ʯ��
		return 4,0,42401,1,0,0
	elseif cur_list[1]==8 then		--��ʯ��
		return 4,0,42401,1,0,0
	elseif cur_list[1]==10 then		--��ʯ��
		return 4,0,42401,1,0,0
	elseif cur_list[1]==16 then		--��ʯ��
		return 4,0,42401,1,0,0
	else													--��ʯ��
		return 4,0,42401,1,0,0
	end
end 
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType40346Cashing(cur_list)		---(��������)
	if cur_list[1]==1 then 				--����ĺ���ѩ��
		return 1,0,23327,1,0,0

	elseif cur_list[1]==5 then		--���龫��
		return 2,0,24904,1,0,0
	elseif cur_list[1]==9 then		--���龫��
		return 2,0,24904,1,0,0
	elseif cur_list[1]==13 then		--���龫��
		return 2,0,24904,1,0,0

	elseif cur_list[1]==3 then		--��������
		return 3,0,18414,1,0,0
	elseif cur_list[1]==7 then		--�����ڵ�
		return 3,0,19257,3,0,0
	elseif cur_list[1]==11 then		--�����ڵ�
		return 3,0,19257,3,0,0
	elseif cur_list[1]==15 then		--��������
		return 3,0,18414,1,0,0

	elseif cur_list[1]==2 then		--�輼�ʶ�ȯ
		return 4,0,40339,1,0,0
	elseif cur_list[1]==4 then		--̫һ�����
		return 4,0,1807,5,0,0
	elseif cur_list[1]==6 then		--̫һ�����
		return 4,0,1807,5,0,0
	elseif cur_list[1]==8 then		--�輼�ʶ�ȯ
		return 4,0,40339,1,0,0
	elseif cur_list[1]==10 then		--�輼�ʶ�ȯ
		return 4,0,40339,1,0,0
	elseif cur_list[1]==12 then		--̫һ�����
		return 4,0,1807,5,0,0
	elseif cur_list[1]==14 then		--̫һ�����
		return 4,0,1807,5,0,0
	else													--�輼�ʶ�ȯ
		return 4,0,40339,1,0,0
	end
end 
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType25749Cashing(cur_list)		---(̫�Կ���)
	if cur_list[1]==1 then 				--�����«�һ�ȯ
		return 1,0,25746,1,0,0

	elseif cur_list[1]==5 then		--�����
		return 2,0,25732,1,0,0
	elseif cur_list[1]==9 then		--�����
		return 2,0,25732,1,0,0
	elseif cur_list[1]==13 then		--�����
		return 2,0,25732,1,0,0

	elseif cur_list[1]==3 then		--�ɶ�
		return 3,0,18794,3,0,0
	elseif cur_list[1]==7 then		--�ɶ�
		return 3,0,18794,3,0,0
	elseif cur_list[1]==11 then		--�ɶ�
		return 3,0,18794,3,0,0
	elseif cur_list[1]==15 then		--�ɶ�
		return 3,0,18794,3,0,0

	elseif cur_list[1]==2 then		--����
		return 4,0,8079,2,0,0
	elseif cur_list[1]==4 then		--����
		return 4,0,25306,1,0,0
	elseif cur_list[1]==6 then		--����
		return 4,0,25306,1,0,0
	elseif cur_list[1]==8 then		--����
		return 4,0,8079,2,0,0
	elseif cur_list[1]==10 then		--����
		return 4,0,8079,2,0,0
	elseif cur_list[1]==12 then		--����
		return 4,0,25307,1,0,0
	elseif cur_list[1]==14 then		--����
		return 4,0,25307,1,0,0
	else													--����
		return 4,0,8079,2,0,0
	end
end 
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType52751Cashing(cur_list)		---(��Ե��)
	if cur_list[1]==1 then 				--ս����ħ
		return 1,0,20561,1,0,0
	elseif cur_list[1]==9 then		--�þ�Ԫ��
		return 1,0,42712,1,0,0
	elseif cur_list[1]==5 then		--�ƺž���
		return 1,0,42710,1,0,0
	elseif cur_list[1]==13 then		--�ƺž���
		return 1,0,42710,1,0,0

	elseif cur_list[1]==3 then		--����
		return 2,0,23360,1,0,0
	elseif cur_list[1]==7 then		--����
		return 2,0,23360,1,0,0
	elseif cur_list[1]==11 then		--����
		return 2,0,23360,1,0,0
	elseif cur_list[1]==15 then		--����
		return 2,0,23360,1,0,0
		
	elseif cur_list[1]==4 then		--��ձ���
		return 3,0,23858,1,0,0
  elseif cur_list[1]==6 then		--ǧ����Ǯ
		return 3,0,41171,1,0,0
	elseif cur_list[1]==12 then		--������Ǯ
		return 3,0,24708,1,0,0
	elseif cur_list[1]==14 then		--������Ǯ
		return 3,0,24708,1,0,0

	elseif cur_list[1]==8 then		--�컯��
		return 4,0,22343,100,0,0
	elseif cur_list[1]==10 then		--Ԫ����
		return 4,0,41668,100,0,0
	elseif cur_list[1]==2 then		--��*60
		return 4,0,42720,1,0,0
	else													--��*60
		return 4,0,42720,1,0,0
	end
end 
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType54054Cashing(cur_list)		---(��������)
	if cur_list[1]==1 then 				--��������
		return 1,0,54043,1,0,0
	elseif cur_list[1]==5 then		--����
		return 1,0,44495,1,0,0
	elseif cur_list[1]==9 then		--ʮ���������
		return 1,0,32103,1,0,0
	elseif cur_list[1]==13 then		--�ɻ�
		return 1,0,50620,1,0,0

	elseif cur_list[1]==3 then		--2�Ƚ���ʯ��
		return 2,0,49293,1,0,0
	elseif cur_list[1]==7 then		--2�Ƚ���ʯ��
		return 2,0,49293,1,0,0
	elseif cur_list[1]==11 then		--2�Ƚ���ʯ��
		return 2,0,49293,1,0,0
	elseif cur_list[1]==15 then		--2�Ƚ���ʯ��
		return 2,0,49293,1,0,0

	elseif cur_list[1]==4 then		--�ɶ�
		return 3,0,18794,3,0,0
	elseif cur_list[1]==6 then		--�ɶ�
		return 3,0,18794,3,0,0
	elseif cur_list[1]==12 then		--�ɶ�
		return 3,0,18794,3,0,0
	elseif cur_list[1]==14 then		--�ɶ�
		return 3,0,18794,3,0,0

	elseif cur_list[1]==2 then		--��ʯ��
		return 4,0,42401,1,0,0
	elseif cur_list[1]==8 then		--��ʯ��
		return 4,0,42401,1,0,0
	elseif cur_list[1]==10 then		--��ʯ��
		return 4,0,42401,1,0,0
	elseif cur_list[1]==16 then		--��ʯ��
		return 4,0,42401,1,0,0
	else													--��ʯ��
		return 4,0,42401,1,0,0
	end
end 
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType54858Cashing(cur_list)		---(����-ҹ����ѩ)
	if cur_list[1]==1 then 				--��ҹ����(���
		return 1,0,54844,1,0,0
	elseif cur_list[1]==5 then		--�ټƷ���һ�ȯ
		return 1,0,52343,1,0,0
	elseif cur_list[1]==9 then		--ʮ���������
		return 1,0,32103,1,0,0
	elseif cur_list[1]==13 then		--�ټƽ���һ�ȯ
		return 1,0,52342,1,0,0

	elseif cur_list[1]==3 then		--2�Ƚ���ʯ��
		return 2,0,49293,1,0,0
	elseif cur_list[1]==7 then		--2�Ƚ���ʯ��
		return 2,0,49293,1,0,0
	elseif cur_list[1]==11 then		--2�Ƚ���ʯ��
		return 2,0,49293,1,0,0
	elseif cur_list[1]==15 then		--2�Ƚ���ʯ��
		return 2,0,49293,1,0,0

	elseif cur_list[1]==4 then		--�ɶ�
		return 3,0,18794,3,0,0
	elseif cur_list[1]==6 then		--�ɶ�
		return 3,0,18794,3,0,0
	elseif cur_list[1]==12 then		--�ɶ�
		return 3,0,18794,3,0,0
	elseif cur_list[1]==14 then		--�ɶ�
		return 3,0,18794,3,0,0

	elseif cur_list[1]==2 then		--��ʯ��
		return 4,0,42401,1,0,0
	elseif cur_list[1]==8 then		--��ʯ��
		return 4,0,42401,1,0,0
	elseif cur_list[1]==10 then		--��ʯ��
		return 4,0,42401,1,0,0
	elseif cur_list[1]==16 then		--��ʯ��
		return 4,0,42401,1,0,0
	else													--��ʯ��
		return 4,0,42401,1,0,0
	end
end 
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType52457Cashing(cur_list)		---(�֮��)
	if cur_list[1]==1 then 				--����֮��
		return 1,0,52456,1,0,0
	elseif cur_list[1]==5 then		--����
		return 1,0,44495,1,0,0
	elseif cur_list[1]==9 then		--ʮ���������
		return 1,0,32103,1,0,0
	elseif cur_list[1]==13 then		--�ɻ�
		return 1,0,50620,1,0,0

	elseif cur_list[1]==3 then		--2�Ƚ���ʯ��
		return 2,0,49293,1,0,0
	elseif cur_list[1]==7 then		--2�Ƚ���ʯ��
		return 2,0,49293,1,0,0
	elseif cur_list[1]==11 then		--2�Ƚ���ʯ��
		return 2,0,49293,1,0,0
	elseif cur_list[1]==15 then		--2�Ƚ���ʯ��
		return 2,0,49293,1,0,0

	elseif cur_list[1]==4 then		--�ɶ�
		return 3,0,18794,3,0,0
	elseif cur_list[1]==6 then		--�ɶ�
		return 3,0,18794,3,0,0
	elseif cur_list[1]==12 then		--�ɶ�
		return 3,0,18794,3,0,0
	elseif cur_list[1]==14 then		--�ɶ�
		return 3,0,18794,3,0,0

	elseif cur_list[1]==2 then		--��ʯ��
		return 4,0,42401,1,0,0
	elseif cur_list[1]==8 then		--��ʯ��
		return 4,0,42401,1,0,0
	elseif cur_list[1]==10 then		--��ʯ��
		return 4,0,42401,1,0,0
	elseif cur_list[1]==16 then		--��ʯ��
		return 4,0,42401,1,0,0
	else													--��ʯ��
		return 4,0,42401,1,0,0
	end
end 
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType44823Cashing(cur_list)		---(���ɱ���)
	if cur_list[1]==1 then 				--����
		return 1,0,44495,1,0,0
	elseif cur_list[1]==5 then		--ʮ���������
		return 1,0,32103,1,0,0
	elseif cur_list[1]==9 then		--�ɻ�
		return 1,0,50620,1,0,0
	elseif cur_list[1]==13 then		--��Ԫ�쾧�Ž�
		return 1,0,40668,1,0,0

	elseif cur_list[1]==3 then		--2�Ƚ���ʯ��
		return 2,0,49293,1,0,0
	elseif cur_list[1]==7 then		--2�Ƚ���ʯ��
		return 2,0,49293,1,0,0
	elseif cur_list[1]==11 then		--2�Ƚ���ʯ��
		return 2,0,49293,1,0,0
	elseif cur_list[1]==15 then		--2�Ƚ���ʯ��
		return 2,0,49293,1,0,0

	elseif cur_list[1]==4 then		--�ɶ�
		return 3,0,18794,3,0,0
	elseif cur_list[1]==6 then		--�ɶ�
		return 3,0,18794,3,0,0
	elseif cur_list[1]==12 then		--�ɶ�
		return 3,0,18794,3,0,0
	elseif cur_list[1]==14 then		--�ɶ�
		return 3,0,18794,3,0,0

	elseif cur_list[1]==2 then		--��ʯ��
		return 4,0,42401,1,0,0
	elseif cur_list[1]==8 then		--��ʯ��
		return 4,0,42401,1,0,0
	elseif cur_list[1]==10 then		--��ʯ��
		return 4,0,42401,1,0,0
	elseif cur_list[1]==16 then		--��ʯ��
		return 4,0,42401,1,0,0
	else													--��ʯ��
		return 4,0,42401,1,0,0
	end
end 
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType52471Cashing(cur_list)		---(�丸)
	if cur_list[1]==1 then 				--�丸�һ�ȯ
		return 1,0,52470,1,0,0
	elseif cur_list[1]==5 then		--��Ԫ�쾧9��
		return 1,0,40668,1,0,0
	elseif cur_list[1]==9 then		--ʮ���������
		return 1,0,32103,1,0,0
	elseif cur_list[1]==13 then		--����ʱװ�һ�ȯ
		return 1,0,42399,1,0,0

	elseif cur_list[1]==3 then		--2�Ƚ���ʯ��
		return 2,0,49293,1,0,0
	elseif cur_list[1]==7 then		--2�Ƚ���ʯ��
		return 2,0,49293,1,0,0
	elseif cur_list[1]==11 then		--2�Ƚ���ʯ��
		return 2,0,49293,1,0,0
	elseif cur_list[1]==15 then		--2�Ƚ���ʯ��
		return 2,0,49293,1,0,0

	elseif cur_list[1]==4 then		--�ɶ�
		return 3,0,18794,3,0,0
	elseif cur_list[1]==6 then		--�ɶ�
		return 3,0,18794,3,0,0
	elseif cur_list[1]==12 then		--�ɶ�
		return 3,0,18794,3,0,0
	elseif cur_list[1]==14 then		--�ɶ�
		return 3,0,18794,3,0,0

	elseif cur_list[1]==2 then		--��ʯ��
		return 4,0,42401,1,0,0
	elseif cur_list[1]==8 then		--��ʯ��
		return 4,0,42401,1,0,0
	elseif cur_list[1]==10 then		--��ʯ��
		return 4,0,42401,1,0,0
	elseif cur_list[1]==16 then		--��ʯ��
		return 4,0,42401,1,0,0
	else													--��ʯ��
		return 4,0,42401,1,0,0
	end
end 
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType41307Cashing(cur_list)		---(ǧ������)
	if cur_list[1]==1 then 				--ʮ���������
		return 1,0,32103,1,0,0
	elseif cur_list[1]==5 then		--���������
		return 1,0,24903,1,0,0
	elseif cur_list[1]==9 then		--��Ԫ�쾧�Ž�
		return 1,0,40668,1,0,0
	elseif cur_list[1]==13 then		--���޵����
		return 1,0,21189,1,0,0

	elseif cur_list[1]==3 then		--������ƪ
		return 2,0,18797,1,0,0
	elseif cur_list[1]==7 then		--����ʯ��
		return 2,0,28587,1,0,0
	elseif cur_list[1]==11 then		--��������
		return 2,0,11539,1,0,0
	elseif cur_list[1]==15 then		--���龫��
		return 2,0,24904,1,0,0

	elseif cur_list[1]==4 then		--�ɶ�
		return 3,0,18794,3,0,0
	elseif cur_list[1]==6 then		--�ɶ�
		return 3,0,18794,3,0,0
	elseif cur_list[1]==12 then		--�ɶ�
		return 3,0,18794,3,0,0
	elseif cur_list[1]==14 then		--�ɶ�
		return 3,0,18794,3,0,0

	elseif cur_list[1]==2 then		--�������
		return 4,0,25306,1,0,0
	elseif cur_list[1]==8 then		--�������
		return 4,0,8079,2,0,0
	elseif cur_list[1]==10 then		--�������
		return 4,0,8079,2,0,0
	elseif cur_list[1]==16 then		--���Ǳ���
		return 4,0,25307,1,0,0
	else													--�������
		return 4,0,8079,1,0,0
	end
end
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType42338Cashing(cur_list)		---(��ɣ��ľ)
	if cur_list[1]==1 then 				--ʮ���������
		return 1,0,32103,1,0,0
	elseif cur_list[1]==5 then		--����
		return 1,0,42150,1,0,0
	elseif cur_list[1]==9 then		--��Ԫ�쾧�Ž�
		return 1,0,40668,1,0,0
	elseif cur_list[1]==13 then		--����
		return 1,0,42150,1,0,0

	elseif cur_list[1]==3 then		--������ƪ
		return 2,0,18797,1,0,0
	elseif cur_list[1]==7 then		--����ʯ��
		return 2,0,28587,1,0,0
	elseif cur_list[1]==11 then		--��������
		return 2,0,11539,1,0,0
	elseif cur_list[1]==15 then		--���龫��
		return 2,0,24904,1,0,0

	elseif cur_list[1]==4 then		--�ɶ�
		return 3,0,18794,3,0,0
	elseif cur_list[1]==6 then		--�ɶ�
		return 3,0,18794,3,0,0
	elseif cur_list[1]==12 then		--�ɶ�
		return 3,0,18794,3,0,0
	elseif cur_list[1]==14 then		--�ɶ�
		return 3,0,18794,3,0,0

	elseif cur_list[1]==2 then		--�������
		return 4,0,25306,1,0,0
	elseif cur_list[1]==8 then		--�������
		return 4,0,8079,2,0,0
	elseif cur_list[1]==10 then		--�������
		return 4,0,8079,2,0,0
	elseif cur_list[1]==16 then		--���Ǳ���
		return 4,0,25307,1,0,0
	else													--�������
		return 4,0,8079,1,0,0
	end
end  
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType40345Cashing(cur_list)		---(��ػ��)
	if cur_list[1]==1 then 				--���������
		return 1,0,24903,1,0,0

	elseif cur_list[1]==5 then		--������ƪ
		return 2,0,18797,1,0,0
	elseif cur_list[1]==9 then		--������ƪ
		return 2,0,18797,1,0,0
	elseif cur_list[1]==13 then		--������ƪ
		return 2,0,18797,1,0,0

	elseif cur_list[1]==3 then		--��Ѫ����
		return 3,0,23860,1,0,0
	elseif cur_list[1]==7 then		--ħɷ����
		return 3,0,23861,1,0,0
	elseif cur_list[1]==11 then		--��������
		return 3,0,23862,1,0,0
	elseif cur_list[1]==15 then		--��Ѫ����
		return 3,0,23860,1,0,0

	elseif cur_list[1]==2 then		--������ӡ
		return 4,0,18910,1,0,0
	elseif cur_list[1]==4 then		--̫һ�����
		return 4,0,1807,5,0,0
	elseif cur_list[1]==6 then		--̫һ�����
		return 4,0,1807,5,0,0
	elseif cur_list[1]==8 then		--������ӡ
		return 4,0,18910,1,0,0
	elseif cur_list[1]==10 then		--������ӡ
		return 4,0,18910,1,0,0
	elseif cur_list[1]==12 then		--̫һ�����
		return 4,0,1807,5,0,0
	elseif cur_list[1]==14 then		--̫һ�����
		return 4,0,1807,5,0,0
	else													--������ӡ
		return 4,0,18910,1,0,0
	end
end 
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType50984Cashing(cur_list)		---(��ɫʥ��)
	if cur_list[1]==1 then 				--ʥ������
		return 1,0,50983,1,0,0
	elseif cur_list[1]==5 then		--��Ԫ�쾧9��
		return 1,0,40668,1,0,0
	elseif cur_list[1]==9 then		--ʮ���������
		return 1,0,32103,1,0,0
	elseif cur_list[1]==13 then		--ǬԪ��̥
		return 1,0,40673,1,0,0

	elseif cur_list[1]==3 then		--2�Ƚ���ʯ��
		return 2,0,49293,1,0,0
	elseif cur_list[1]==7 then		--2�Ƚ���ʯ��
		return 2,0,49293,1,0,0
	elseif cur_list[1]==11 then		--2�Ƚ���ʯ��
		return 2,0,49293,1,0,0
	elseif cur_list[1]==15 then		--2�Ƚ���ʯ��
		return 2,0,49293,1,0,0

	elseif cur_list[1]==4 then		--�ɶ�
		return 3,0,18794,3,0,0
	elseif cur_list[1]==6 then		--�ɶ�
		return 3,0,18794,3,0,0
	elseif cur_list[1]==12 then		--�ɶ�
		return 3,0,18794,3,0,0
	elseif cur_list[1]==14 then		--�ɶ�
		return 3,0,18794,3,0,0

	elseif cur_list[1]==2 then		--��ʯ��
		return 4,0,42401,1,0,0
	elseif cur_list[1]==8 then		--��ʯ��
		return 4,0,42401,1,0,0
	elseif cur_list[1]==10 then		--��ʯ��
		return 4,0,42401,1,0,0
	elseif cur_list[1]==16 then		--��ʯ��
		return 4,0,42401,1,0,0
	else													--��ʯ��
		return 4,0,42401,1,0,0
	end
end 
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType54031Cashing(cur_list)		---(�������쾧��Ʊ)
	if cur_list[1]==1 then 				--�˽��쾧
		return 1,0,53961,1,0,0
	elseif cur_list[1]==5 then		--ǿ��buff
		return 1,0,54030,1,0,0
	elseif cur_list[1]==9 then		--�˽��쾧
		return 1,0,53961,1,0,0
	elseif cur_list[1]==13 then		--ǿ��buff
		return 1,0,54030,1,0,0

	elseif cur_list[1]==3 then		--��ˮ��
		return 2,0,51442,10,0,0
	elseif cur_list[1]==7 then		--4���쾧
		return 2,0,53801,1,0,0
	elseif cur_list[1]==11 then		--��ˮ��
		return 2,0,51442,10,0,0
	elseif cur_list[1]==15 then		--4���쾧
		return 2,0,53801,1,0,0

	elseif cur_list[1]==4 then		--3���쾧
		return 3,0,53802,1,0,0
	elseif cur_list[1]==6 then		--��������
		return 3,0,54013,1,0,0
	elseif cur_list[1]==12 then		--��������
		return 3,0,54014,1,0,0
	elseif cur_list[1]==14 then		--��������
		return 3,0,54015,1,0,0

	elseif cur_list[1]==2 then		--2���쾧
		return 4,0,53803,1,0,0
	elseif cur_list[1]==8 then		--�ͼ�Ԫ����
		return 4,0,22459,30,0,0
	elseif cur_list[1]==10 then		--��ˮ��
		return 4,0,51442,3,0,0
	elseif cur_list[1]==16 then		--Ԫ����
		return 4,0,41668,80,0,0
	else													--Ԫ����
		return 4,0,41668,1,0,0
	end
end 
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType52680Cashing(cur_list)		---(�����ɽ�)
	if cur_list[1]==1 then 				--�����ɽ�
		return 1,0,52679,1,0,0
	elseif cur_list[1]==5 then		--�ټƷ���һ�ȯ
		return 1,0,52343,1,0,0
	elseif cur_list[1]==9 then		--ʮ���������
		return 1,0,32103,1,0,0
	elseif cur_list[1]==13 then		--�ټƽ���һ�ȯ
		return 1,0,52342,1,0,0

	elseif cur_list[1]==3 then		--2�Ƚ���ʯ��
		return 2,0,49293,1,0,0
	elseif cur_list[1]==7 then		--2�Ƚ���ʯ��
		return 2,0,49293,1,0,0
	elseif cur_list[1]==11 then		--2�Ƚ���ʯ��
		return 2,0,49293,1,0,0
	elseif cur_list[1]==15 then		--2�Ƚ���ʯ��
		return 2,0,49293,1,0,0

	elseif cur_list[1]==4 then		--�ɶ�
		return 3,0,18794,3,0,0
	elseif cur_list[1]==6 then		--�ɶ�
		return 3,0,18794,3,0,0
	elseif cur_list[1]==12 then		--�ɶ�
		return 3,0,18794,3,0,0
	elseif cur_list[1]==14 then		--�ɶ�
		return 3,0,18794,3,0,0

	elseif cur_list[1]==2 then		--��ʯ��
		return 4,0,42401,1,0,0
	elseif cur_list[1]==8 then		--��ʯ��
		return 4,0,42401,1,0,0
	elseif cur_list[1]==10 then		--��ʯ��
		return 4,0,42401,1,0,0
	elseif cur_list[1]==16 then		--��ʯ��
		return 4,0,42401,1,0,0
	else													--��ʯ��
		return 4,0,42401,1,0,0
	end
end 
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType54886Cashing(cur_list)		---(�������)
	if cur_list[1]==1 then 				--ǬԪ��̥
		return 1,0,40673,1,0,0
	elseif cur_list[1]==5 then		--����ʱװ�һ�ȯ
		return 1,0,42399,1,0,0
	elseif cur_list[1]==9 then		--ʮ���������
		return 1,0,32103,1,0,0
	elseif cur_list[1]==13 then		--�������
		return 1,0,40510,1,0,0

	elseif cur_list[1]==3 then		--2�Ƚ���ʯ��
		return 2,0,49293,1,0,0
	elseif cur_list[1]==7 then		--2�Ƚ���ʯ��
		return 2,0,49293,1,0,0
	elseif cur_list[1]==11 then		--2�Ƚ���ʯ��
		return 2,0,49293,1,0,0
	elseif cur_list[1]==15 then		--2�Ƚ���ʯ��
		return 2,0,49293,1,0,0

	elseif cur_list[1]==4 then		--�ɶ�
		return 3,0,18794,3,0,0
	elseif cur_list[1]==6 then		--�ɶ�
		return 3,0,18794,3,0,0
	elseif cur_list[1]==12 then		--�ɶ�
		return 3,0,18794,3,0,0
	elseif cur_list[1]==14 then		--�ɶ�
		return 3,0,18794,3,0,0

	elseif cur_list[1]==2 then		--��ʯ��
		return 4,0,42401,1,0,0
	elseif cur_list[1]==8 then		--��ʯ��
		return 4,0,42401,1,0,0
	elseif cur_list[1]==10 then		--��ʯ��
		return 4,0,42401,1,0,0
	elseif cur_list[1]==16 then		--��ʯ��
		return 4,0,42401,1,0,0
	else													--��ʯ��
		return 4,0,42401,1,0,0
	end
end 
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType54929Cashing(cur_list)		---(��ɫ����)
	if cur_list[1]==1 then 				--����
		return 1,0,54919,1,0,0
	elseif cur_list[1]==5 then		--�������
		return 1,0,42862,1,0,0
	elseif cur_list[1]==9 then		--ʮ���������
		return 1,0,32103,1,0,0
	elseif cur_list[1]==13 then		--�������
		return 1,0,40668,1,0,0

	elseif cur_list[1]==3 then		--2�Ƚ���ʯ��
		return 2,0,49293,1,0,0
	elseif cur_list[1]==7 then		--2�Ƚ���ʯ��
		return 2,0,49293,1,0,0
	elseif cur_list[1]==11 then		--2�Ƚ���ʯ��
		return 2,0,49293,1,0,0
	elseif cur_list[1]==15 then		--2�Ƚ���ʯ��
		return 2,0,49293,1,0,0

	elseif cur_list[1]==4 then		--�ɶ�
		return 3,0,18794,3,0,0
	elseif cur_list[1]==6 then		--�ɶ�
		return 3,0,18794,3,0,0
	elseif cur_list[1]==12 then		--�ɶ�
		return 3,0,18794,3,0,0
	elseif cur_list[1]==14 then		--�ɶ�
		return 3,0,18794,3,0,0

	elseif cur_list[1]==2 then		--��ʯ��
		return 4,0,42401,1,0,0
	elseif cur_list[1]==8 then		--��ʯ��
		return 4,0,42401,1,0,0
	elseif cur_list[1]==10 then		--��ʯ��
		return 4,0,42401,1,0,0
	elseif cur_list[1]==16 then		--��ʯ��
		return 4,0,42401,1,0,0
	else													--��ʯ��
		return 4,0,42401,1,0,0
	end
end 
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType55541Cashing(cur_list)		---(���߿���)
	if cur_list[1]==1 then 				--9�׻�Ԫ�쾧
		return 1,0,40668,1,0,0
	elseif cur_list[1]==5 then		--�ټƷ���һ�ȯ
		return 1,0,52343,1,0,0
	elseif cur_list[1]==9 then		--ʮ���������
		return 1,0,32103,1,0,0
	elseif cur_list[1]==13 then		--�ټƽ���һ�ȯ
		return 1,0,52342,1,0,0

	elseif cur_list[1]==3 then		--2�Ƚ���ʯ��
		return 2,0,49293,1,0,0
	elseif cur_list[1]==7 then		--2�Ƚ���ʯ��
		return 2,0,49293,1,0,0
	elseif cur_list[1]==11 then		--2�Ƚ���ʯ��
		return 2,0,49293,1,0,0
	elseif cur_list[1]==15 then		--2�Ƚ���ʯ��
		return 2,0,49293,1,0,0

	elseif cur_list[1]==4 then		--�ɶ�
		return 3,0,18794,3,0,0
	elseif cur_list[1]==6 then		--�ɶ�
		return 3,0,18794,3,0,0
	elseif cur_list[1]==12 then		--�ɶ�
		return 3,0,18794,3,0,0
	elseif cur_list[1]==14 then		--�ɶ�
		return 3,0,18794,3,0,0

	elseif cur_list[1]==2 then		--��ʯ��
		return 4,0,42401,1,0,0
	elseif cur_list[1]==8 then		--��ʯ��
		return 4,0,42401,1,0,0
	elseif cur_list[1]==10 then		--��ʯ��
		return 4,0,42401,1,0,0
	elseif cur_list[1]==16 then		--��ʯ��
		return 4,0,42401,1,0,0
	else													--��ʯ��
		return 4,0,42401,1,0,0
	end
end 
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType55792Cashing(cur_list)		---(��¥��)
	if cur_list[1]==1 then 				--ĩ�ճ��һ�ȯ
		return 1,0,55758,1,0,0
	elseif cur_list[1]==5 then		--�������
		return 1,0,42862,1,0,0
	elseif cur_list[1]==9 then		--ʮ���������
		return 1,0,32103,1,0,0
	elseif cur_list[1]==13 then		--����ʱװ�һ�ȯ
		return 1,0,42399,1,0,0

	elseif cur_list[1]==3 then		--2�Ƚ���ʯ��
		return 2,0,49293,1,0,0
	elseif cur_list[1]==7 then		--2�Ƚ���ʯ��
		return 2,0,49293,1,0,0
	elseif cur_list[1]==11 then		--2�Ƚ���ʯ��
		return 2,0,49293,1,0,0
	elseif cur_list[1]==15 then		--2�Ƚ���ʯ��
		return 2,0,49293,1,0,0

	elseif cur_list[1]==4 then		--�ɶ�
		return 3,0,18794,3,0,0
	elseif cur_list[1]==6 then		--�ɶ�
		return 3,0,18794,3,0,0
	elseif cur_list[1]==12 then		--�ɶ�
		return 3,0,18794,3,0,0
	elseif cur_list[1]==14 then		--�ɶ�
		return 3,0,18794,3,0,0

	elseif cur_list[1]==2 then		--��ʯ��
		return 4,0,42401,1,0,0
	elseif cur_list[1]==8 then		--��ʯ��
		return 4,0,42401,1,0,0
	elseif cur_list[1]==10 then		--��ʯ��
		return 4,0,42401,1,0,0
	elseif cur_list[1]==16 then		--��ʯ��
		return 4,0,42401,1,0,0
	else													--��ʯ��
		return 4,0,42401,1,0,0
	end
end 
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType55966Cashing(cur_list)		---(��ɽϪ)
	if cur_list[1]==1 then 				--���ϻ�����
		return 1,0,55969,1,0,0
	elseif cur_list[1]==5 then		--��Ԫ�쾧9��
		return 1,0,40668,1,0,0
	elseif cur_list[1]==9 then		--ʮ���������
		return 1,0,32103,1,0,0
	elseif cur_list[1]==13 then		--ǬԪ��̥
		return 1,0,40673,1,0,0

	elseif cur_list[1]==3 then		--2�Ƚ���ʯ��
		return 2,0,49293,1,0,0
	elseif cur_list[1]==7 then		--2�Ƚ���ʯ��
		return 2,0,49293,1,0,0
	elseif cur_list[1]==11 then		--2�Ƚ���ʯ��
		return 2,0,49293,1,0,0
	elseif cur_list[1]==15 then		--2�Ƚ���ʯ��
		return 2,0,49293,1,0,0

	elseif cur_list[1]==4 then		--�컯��
		return 3,0,21345,500,0,0
	elseif cur_list[1]==6 then		--����ħѪ
		return 3,0,6350,1,0,0
	elseif cur_list[1]==12 then		--�컯��
		return 3,0,21345,500,0,0
	elseif cur_list[1]==14 then		--����ħѪ
		return 3,0,6350,1,0,0

	elseif cur_list[1]==2 then		--��ʯ��
		return 4,0,42401,1,0,0
	elseif cur_list[1]==8 then		--��ʯ��
		return 4,0,42401,1,0,0
	elseif cur_list[1]==10 then		--��ʯ��
		return 4,0,42401,1,0,0
	elseif cur_list[1]==16 then		--��ʯ��
		return 4,0,42401,1,0,0
	else													--��ʯ��
		return 4,0,42401,1,0,0
	end
end
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType55590Cashing(cur_list)		---(�����)
	if cur_list[1]==1 then 				--����
		return 1,0,44495,1,0,0
	elseif cur_list[1]==5 then		--ʮ���������
		return 1,0,32103,1,0,0
	elseif cur_list[1]==9 then		--�ɻ�
		return 1,0,50620,1,0,0
	elseif cur_list[1]==13 then		--������
		return 1,0,55596,1,0,0

	elseif cur_list[1]==3 then		--2�Ƚ���ʯ��
		return 2,0,49293,1,0,0
	elseif cur_list[1]==7 then		--2�Ƚ���ʯ��
		return 2,0,49293,1,0,0
	elseif cur_list[1]==11 then		--2�Ƚ���ʯ��
		return 2,0,49293,1,0,0
	elseif cur_list[1]==15 then		--2�Ƚ���ʯ��
		return 2,0,49293,1,0,0

	elseif cur_list[1]==4 then		--�ɶ�
		return 3,0,18794,3,0,0
	elseif cur_list[1]==6 then		--�ɶ�
		return 3,0,18794,3,0,0
	elseif cur_list[1]==12 then		--�ɶ�
		return 3,0,18794,3,0,0
	elseif cur_list[1]==14 then		--�ɶ�
		return 3,0,18794,3,0,0

	elseif cur_list[1]==2 then		--��ʯ��
		return 4,0,42401,1,0,0
	elseif cur_list[1]==8 then		--��ʯ��
		return 4,0,42401,1,0,0
	elseif cur_list[1]==10 then		--��ʯ��
		return 4,0,42401,1,0,0
	elseif cur_list[1]==16 then		--��ʯ��
		return 4,0,42401,1,0,0
	else													--��ʯ��
		return 4,0,42401,1,0,0
	end
end 
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType58780Cashing(cur_list)		---(Ⱦɫ��)
	if cur_list[1]>0 and cur_list[1]<=12 then
		return 1,0,58719+cur_list[1],1,0,0
	elseif cur_list[1]>12 and cur_list[1]<=24 then
		return 2,0,58719+cur_list[1],1,0,0
	elseif cur_list[1]>24 and cur_list[1]<=36 then
		return 3,0,58719+cur_list[1],1,0,0
	elseif cur_list[1]>36 and cur_list[1]<=48 then
		return 4,0,58719+cur_list[1],1,0,0
	elseif cur_list[1]>48 and cur_list[1]<=60 then
		return 5,0,58719+cur_list[1],1,0,0
	else 
		return 5,0,58779,1,0,0
	end		
end 
function LotteryType55442Cashing(cur_list)		---(Ⱦɫ��)
	if cur_list[1]>0 and cur_list[1]<=12 then
		return 1,0,58719+cur_list[1],1,0,0
	elseif cur_list[1]>12 and cur_list[1]<=24 then
		return 2,0,58719+cur_list[1],1,0,0
	elseif cur_list[1]>24 and cur_list[1]<=36 then
		return 3,0,58719+cur_list[1],1,0,0
	elseif cur_list[1]>36 and cur_list[1]<=48 then
		return 4,0,58719+cur_list[1],1,0,0
	elseif cur_list[1]>48 and cur_list[1]<=60 then
		return 5,0,58719+cur_list[1],1,0,0
	else 
		return 5,0,58779,1,0,0
	end		
end 
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType60300Cashing(cur_list)		---(ȵ����)
	if cur_list[1]==1 then 				--�����¶
		return 1,0,60261,1,0,0
	elseif cur_list[1]==5 then		--��Ԫ�쾧9��
		return 1,0,40668,1,0,0
	elseif cur_list[1]==9 then		--ʮ���������
		return 1,0,32103,1,0,0
	elseif cur_list[1]==13 then		--�������
		return 1,0,42862,1,0,0

	elseif cur_list[1]==3 then		--2�Ƚ���ʯ��
		return 2,0,49293,1,0,0
	elseif cur_list[1]==7 then		--2�Ƚ���ʯ��
		return 2,0,49293,1,0,0
	elseif cur_list[1]==11 then		--2�Ƚ���ʯ��
		return 2,0,49293,1,0,0
	elseif cur_list[1]==15 then		--2�Ƚ���ʯ��
		return 2,0,49293,1,0,0

	elseif cur_list[1]==4 then		--�컯��
		return 3,0,21345,500,0,0
	elseif cur_list[1]==6 then		--����ħѪ
		return 3,0,6350,1,0,0
	elseif cur_list[1]==12 then		--�컯��
		return 3,0,21345,500,0,0
	elseif cur_list[1]==14 then		--����ħѪ
		return 3,0,6350,1,0,0

	elseif cur_list[1]==2 then		--��ʯ��
		return 4,0,42401,1,0,0
	elseif cur_list[1]==8 then		--��ʯ��
		return 4,0,42401,1,0,0
	elseif cur_list[1]==10 then		--��ʯ��
		return 4,0,42401,1,0,0
	elseif cur_list[1]==16 then		--��ʯ��
		return 4,0,42401,1,0,0
	else													--��ʯ��
		return 4,0,42401,1,0,0
	end
end 
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType58313Cashing(cur_list)		---(�����)
	if cur_list[1]==1 then 				--�зʶһ�ȯ
		return 1,0,58314,1,0,0
	elseif cur_list[1]==5 then		--��Ԫ�쾧9��
		return 1,0,40668,1,0,0
	elseif cur_list[1]==9 then		--ʮ���������
		return 1,0,32103,1,0,0
	elseif cur_list[1]==13 then		--����ʱװ�һ�ȯ
		return 1,0,42399,1,0,0

	elseif cur_list[1]==3 then		--2�Ƚ���ʯ��
		return 2,0,49293,1,0,0
	elseif cur_list[1]==7 then		--2�Ƚ���ʯ��
		return 2,0,49293,1,0,0
	elseif cur_list[1]==11 then		--2�Ƚ���ʯ��
		return 2,0,49293,1,0,0
	elseif cur_list[1]==15 then		--2�Ƚ���ʯ��
		return 2,0,49293,1,0,0

	elseif cur_list[1]==4 then		--�컯��
		return 3,0,21345,500,0,0
	elseif cur_list[1]==6 then		--����ħѪ
		return 3,0,6350,1,0,0
	elseif cur_list[1]==12 then		--�컯��
		return 3,0,21345,500,0,0
	elseif cur_list[1]==14 then		--����ħѪ
		return 3,0,6350,1,0,0

	elseif cur_list[1]==2 then		--��ʯ��
		return 4,0,42401,1,0,0
	elseif cur_list[1]==8 then		--��ʯ��
		return 4,0,42401,1,0,0
	elseif cur_list[1]==10 then		--��ʯ��
		return 4,0,42401,1,0,0
	elseif cur_list[1]==16 then		--��ʯ��
		return 4,0,42401,1,0,0
	else													--��ʯ��
		return 4,0,42401,1,0,0
	end
end 
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType61160Cashing(cur_list)		---(�����ð��ɲ�Ʊ)
	if cur_list[1]==1 then 				--ʮ����
		return 1,0,61211,1,0,0
	elseif cur_list[1]==5 then		--ʮ����
		return 1,0,61211,1,0,0
	elseif cur_list[1]==9 then		--ʮ����
		return 1,0,61211,1,0,0
	elseif cur_list[1]==13 then		--ʮ����
		return 1,0,61211,1,0,0

	elseif cur_list[1]==3 then		--ʮ����Ƭ
		return 2,0,49370,1,0,0
	elseif cur_list[1]==7 then		--ʮ����Ƭ
		return 2,0,49370,1,0,0
	elseif cur_list[1]==11 then		--ʮ����Ƭ
		return 2,0,49370,1,0,0
	elseif cur_list[1]==15 then		--ʮ����Ƭ
		return 2,0,49370,1,0,0

	elseif cur_list[1]==4 then		--Ԫ����
		return 3,0,41668,200,0,0
	elseif cur_list[1]==6 then		--Ԫ����
		return 3,0,41668,200,0,0
	elseif cur_list[1]==12 then		--Ԫ����
		return 3,0,41668,200,0,0
	elseif cur_list[1]==14 then		--Ԫ����
		return 3,0,41668,200,0,0

	elseif cur_list[1]==2 then		--�컯��
		return 4,0,22343,200,0,0
	elseif cur_list[1]==8 then		--�컯��
		return 4,0,22343,200,0,0
	elseif cur_list[1]==10 then		--�컯��
		return 4,0,22343,200,0,0
	elseif cur_list[1]==16 then		--�컯��
		return 4,0,22343,200,0,0
	else													--�컯��
		return 4,0,22343,200,0,0
	end
end 
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType58365Cashing(cur_list)		---(����Ũ)
	if cur_list[1]==1 then 				--�ɽ����һ�ȯ
		return 1,0,58363,1,0,0
	elseif cur_list[1]==5 then		--��Ԫ�쾧9��
		return 1,0,40668,1,0,0
	elseif cur_list[1]==9 then		--ʮ���������
		return 1,0,32103,1,0,0
	elseif cur_list[1]==13 then		--�������
		return 1,0,40510,1,0,0

	elseif cur_list[1]==3 then		--2�Ƚ���ʯ��
		return 2,0,49293,1,0,0
	elseif cur_list[1]==7 then		--2�Ƚ���ʯ��
		return 2,0,49293,1,0,0
	elseif cur_list[1]==11 then		--2�Ƚ���ʯ��
		return 2,0,49293,1,0,0
	elseif cur_list[1]==15 then		--2�Ƚ���ʯ��
		return 2,0,49293,1,0,0

	elseif cur_list[1]==4 then		--�컯��
		return 3,0,21345,500,0,0
	elseif cur_list[1]==6 then		--����ħѪ
		return 3,0,6350,1,0,0
	elseif cur_list[1]==12 then		--�컯��
		return 3,0,21345,500,0,0
	elseif cur_list[1]==14 then		--����ħѪ
		return 3,0,6350,1,0,0

	elseif cur_list[1]==2 then		--��ʯ��
		return 4,0,42401,1,0,0
	elseif cur_list[1]==8 then		--��ʯ��
		return 4,0,42401,1,0,0
	elseif cur_list[1]==10 then		--��ʯ��
		return 4,0,42401,1,0,0
	elseif cur_list[1]==16 then		--��ʯ��
		return 4,0,42401,1,0,0
	else													--��ʯ��
		return 4,0,42401,1,0,0
	end
end 
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType58555Cashing(cur_list)		---(�˽���)
	if cur_list[1]==1 then 				--��ҹ����(���
		return 1,0,58554,1,0,0
	elseif cur_list[1]==5 then		--�ټƷ���һ�ȯ
		return 1,0,52343,1,0,0
	elseif cur_list[1]==9 then		--ʮ���������
		return 1,0,32103,1,0,0
	elseif cur_list[1]==13 then		--�ټƽ���һ�ȯ
		return 1,0,52342,1,0,0

	elseif cur_list[1]==3 then		--2�Ƚ���ʯ��
		return 2,0,49293,1,0,0
	elseif cur_list[1]==7 then		--2�Ƚ���ʯ��
		return 2,0,49293,1,0,0
	elseif cur_list[1]==11 then		--2�Ƚ���ʯ��
		return 2,0,49293,1,0,0
	elseif cur_list[1]==15 then		--2�Ƚ���ʯ��
		return 2,0,49293,1,0,0

	elseif cur_list[1]==4 then		--�컯��
		return 3,0,21345,500,0,0
	elseif cur_list[1]==6 then		--����ħѪ
		return 3,0,6350,1,0,0
	elseif cur_list[1]==12 then		--�컯��
		return 3,0,21345,500,0,0
	elseif cur_list[1]==14 then		--����ħѪ
		return 3,0,6350,1,0,0

	elseif cur_list[1]==2 then		--��ʯ��
		return 4,0,42401,1,0,0
	elseif cur_list[1]==8 then		--��ʯ��
		return 4,0,42401,1,0,0
	elseif cur_list[1]==10 then		--��ʯ��
		return 4,0,42401,1,0,0
	elseif cur_list[1]==16 then		--��ʯ��
		return 4,0,42401,1,0,0
	else													--��ʯ��
		return 4,0,42401,1,0,0
	end
end
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType55493Cashing(cur_list)		---(������Ԫ�����Ʊ)
	if cur_list[1]==1 then 				--Ԫ��
		return 1,0,55489,1,0,0
	elseif cur_list[1]==5 then		--Ԫ��
		return 1,0,55489,1,0,0
	elseif cur_list[1]==9 then		--Ԫ��
		return 1,0,55489,1,0,0
	elseif cur_list[1]==13 then		--Ԫ��
		return 1,0,55489,1,0,0

	elseif cur_list[1]==3 then		--Ԫ��
		return 2,0,55490,1,0,0
	elseif cur_list[1]==7 then		--Ԫ��
		return 2,0,55491,1,0,0
	elseif cur_list[1]==11 then		--Ԫ��
		return 2,0,55490,1,0,0
	elseif cur_list[1]==15 then		--Ԫ��
		return 2,0,55491,1,0,0

	elseif cur_list[1]==4 then		--Ԫ��
		return 3,0,55491,1,0,0
	elseif cur_list[1]==6 then		--Ԫ��
		return 3,0,55490,1,0,0
	elseif cur_list[1]==12 then		--Ԫ��
		return 3,0,55491,1,0,0
	elseif cur_list[1]==14 then		--Ԫ��
		return 3,0,55490,1,0,0

	elseif cur_list[1]==2 then		--Ԫ��
		return 4,0,55490,1,0,0
	elseif cur_list[1]==8 then		--Ԫ��
		return 4,0,55491,1,0,0
	elseif cur_list[1]==10 then		--Ԫ��
		return 4,0,55490,1,0,0
	elseif cur_list[1]==16 then		--Ԫ��
		return 4,0,55491,1,0,0
	else													--Ԫ��
		return 4,0,55491,1,0,0
	end
end 
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType57426Cashing(cur_list)		---(������)
	if cur_list[1]==1 then 				--�����һ�ȯ
		return 1,0,57425,1,0,0
	elseif cur_list[1]==5 then		--�ټƷ���һ�ȯ
		return 1,0,52343,1,0,0
	elseif cur_list[1]==9 then		--ʮ���������
		return 1,0,32103,1,0,0
	elseif cur_list[1]==13 then		--�ټƽ���һ�ȯ
		return 1,0,52342,1,0,0

	elseif cur_list[1]==3 then		--2�Ƚ���ʯ��
		return 2,0,49293,1,0,0
	elseif cur_list[1]==7 then		--2�Ƚ���ʯ��
		return 2,0,49293,1,0,0
	elseif cur_list[1]==11 then		--2�Ƚ���ʯ��
		return 2,0,49293,1,0,0
	elseif cur_list[1]==15 then		--2�Ƚ���ʯ��
		return 2,0,49293,1,0,0

	elseif cur_list[1]==4 then		--�컯��
		return 3,0,21345,500,0,0
	elseif cur_list[1]==6 then		--����ħѪ
		return 3,0,6350,1,0,0
	elseif cur_list[1]==12 then		--�컯��
		return 3,0,21345,500,0,0
	elseif cur_list[1]==14 then		--����ħѪ
		return 3,0,6350,1,0,0

	elseif cur_list[1]==2 then		--��ʯ��
		return 4,0,42401,1,0,0
	elseif cur_list[1]==8 then		--��ʯ��
		return 4,0,42401,1,0,0
	elseif cur_list[1]==10 then		--��ʯ��
		return 4,0,42401,1,0,0
	elseif cur_list[1]==16 then		--��ʯ��
		return 4,0,42401,1,0,0
	else													--��ʯ��
		return 4,0,42401,1,0,0
	end
end 
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType54909Cashing(cur_list)		---(��ս�ò�Ʊ)
	if cur_list[1]==1 then 				--��Ԫ�쾧9��
		return 1,0,53962,1,0,0
	elseif cur_list[1]==5 then		--�������
		return 1,0,54912,1,0,0
	elseif cur_list[1]==9 then		--ʮ���������
		return 1,0,32286,1,0,0
	elseif cur_list[1]==13 then		--�������
		return 1,0,54912,1,0,0

	elseif cur_list[1]==3 then		--���
		return 2,0,55218,1,0,0
	elseif cur_list[1]==7 then		--����
		return 2,0,55219,1,0,0
	elseif cur_list[1]==11 then		--���
		return 2,0,55218,1,0,0
	elseif cur_list[1]==15 then		--����
		return 2,0,55219,1,0,0

	elseif cur_list[1]==4 then		--Ԫ�����
		return 3,0,41668,250,0,0
	elseif cur_list[1]==6 then		--Ԫ�����
		return 3,0,41668,250,0,0
	elseif cur_list[1]==12 then		--Ԫ�����
		return 3,0,41668,250,0,0
	elseif cur_list[1]==14 then		--Ԫ�����
		return 3,0,41668,250,0,0

	elseif cur_list[1]==2 then		--�컯���
		return 4,0,22343,250,0,0
	elseif cur_list[1]==8 then		--�컯���
		return 4,0,22343,250,0,0
	elseif cur_list[1]==10 then		--�컯���
		return 4,0,22343,250,0,0
	elseif cur_list[1]==16 then		--�컯���
		return 4,0,22343,250,0,0
	else													--�컯���
		return 4,0,22343,250,0,0
	end
end 
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType33823Cashing(cur_list)		---(ӭ�´���)
	if cur_list[1]==1 then 				--���������
		return 1,0,24903,1,0,0
	elseif cur_list[1]==5 then		--������
		return 1,0,33820,1,0,0
	elseif cur_list[1]==9 then		--��ħѪ�����
		return 1,0,33821,1,0,0
	elseif cur_list[1]==13 then		--���������
		return 1,0,24903,1,0,0

	elseif cur_list[1]==3 then		--������ƪ
		return 2,0,18797,1,0,0
	elseif cur_list[1]==7 then		--Ů����
		return 2,0,7937,1,0,0
	elseif cur_list[1]==11 then		--�а���
		return 2,0,7931,1,0,0
	elseif cur_list[1]==15 then		--������ƪ
		return 2,0,18797,1,0,0

	elseif cur_list[1]==4 then		--������
		return 3,0,16551,3,0,0
	elseif cur_list[1]==6 then		--�۱���
		return 3,0,13343,10,0,0
	elseif cur_list[1]==12 then		--�۱���
		return 3,0,13343,10,0,0
	elseif cur_list[1]==14 then		--������
		return 3,0,16551,3,0,0

	elseif cur_list[1]==2 then		--�������
		return 4,0,25306,1,0,0
	elseif cur_list[1]==8 then		--���Ǳ���
		return 4,0,25307,1,0,0
	elseif cur_list[1]==10 then		--���Ǳ���
		return 4,0,25307,1,0,0
	elseif cur_list[1]==16 then		--�������
		return 4,0,25306,1,0,0
	else													--���Ǳ���
		return 4,0,25307,1,0,0
	end
end 
-------------------------------------------------------------------------------------------------------------
---------------------------------�ָ���-----------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
--[[
--   
--      �ӿں���LotterySelectNumber 
--	˵������ʾ����һ����Ʊ�е�ĳλ����
--      ������
--           id : ��Ʊ����Ʒ id�� ��ͬ�Ĳ�Ʊ�����в�ͬ�ı���
--           max_count: ���Ų�Ʊ�ܹ����м����������
--           cur_list: ��ǰ�Ѿ����ɵĲ�Ʊ���� #cur_list�Ϳ��Եõ���ǰ���ɵĺ������� 
--                     cur_list[1] �� cur_list[#cur_list] ���ǵ�ǰ�Ѿ����ɵ����к���
--                     ��׼�ĸ������ɿ���������Щ����
--      ���أ��������Ӧ������һ��1~255����ֵ��ʾ�������ɵĵ�����Ʊ���룬0����Ϊ
--            ����Ĳ�Ʊ���룬�������Ϊ����������з��أ�
--
--      ************************************************************************
--
--      �ӿں���LotteryCashing
--      ˵������һ���Ѿ�������ϵĲ�Ʊ���жҽ�����
--      ������
--           id : ��Ʊ����Ʒ id�� ��ͬ�Ĳ�Ʊ�����в�ͬ�ı���
--           cur_list: ��ǰ�Ѿ����ɵĲ�Ʊ���� #cur_list�Ϳ��Եõ���ǰ���еĺ���
--                     cur_list[1] �� cur_list[#cur_list] ��ʾ����������˳��ĺ���
--      ���أ��ҽ���Ľ���ɴ˽ӿڷ��أ��ҽ��ܹ������������Ͳ������з��ء�
--          ���صĸ�ʽΪ return b_level b_money b_item b_count b_bind b_period;
--          ��������ֵ�������£�
--           b_level: ���β�Ʊ���н��ȼ����ȼ���һ�����ڵ���0������
--           b_money: ���β�Ʊ���н����𣬽�����һ�����ڵ���0������
--           b_item:�����β�Ʊ�Ľ�����Ʒid�����Ϊ0��-1���ʾ�޽�Ʒ
--           b_count: ���β�Ʊ�Ľ�����Ʒ��Ŀ�����ֵӦ�����ڵ���0�������ڶѵ�����
--           b_bind: �����н����ŵ���Ʒ�����Ƿ�󶨣���ЧֵΪ0����1��ֻ�жѵ�����Ϊ1���������������
--           b_period:�����н�������Ʒ�����Ƿ�����Чʱ�䣬����һ�����ڵ���0������������0��ʾ������Чֵ��
--                    ֻ�жѵ�����Ϊ1��������������塣
--         �����ز�������������Ҫ�󣬻��߲����ķ�Χ������Ҫ��ʱ����������ķ��ر���Ϊ�Ǵ���ġ�
-------------------------------------------------------------------------------------------------------------
--]]
---
---  �йؽӿ�ʵ�֡�����������ӿ���һ���ο�ʵ��?
---��ʹ��if�������жϲ�ͬ�Ĳ�Ʊ��Ȼ����ò�ͬ��Ʊ�����ɺ��жϺ���
---
function LotterySelectNumber(id, max_count,cur_list)
	if(id==6576) then
		return LotteryType6576SelectNumber(cur_list,max_count);
	elseif(id==7916) then
		return LotteryType7916SelectNumber(cur_list,max_count);
	elseif(id==10484) then
		return LotteryType10484SelectNumber(cur_list,max_count);
	elseif(id==10722) then
		return LotteryType10722SelectNumber(cur_list,max_count);	
	elseif(id==11537) then
		return LotteryType11537SelectNumber(cur_list,max_count);
	elseif(id==11742) then 
		return LotteryType11742SelectNumber(cur_list,max_count);
	elseif(id==11743) then 
		return LotteryType11743SelectNumber(cur_list,max_count);	
	elseif(id==12006) then 
		return LotteryType12006SelectNumber(cur_list,max_count);		
	elseif(id==13318) then 
		return LotteryType13318SelectNumber(cur_list,max_count);	
	elseif(id==13319) then 
		return LotteryType13319SelectNumber(cur_list,max_count);	
	elseif(id==13377) then 
		return LotteryType13377SelectNumber(cur_list,max_count);	
	elseif (id>=13320 and id<=13339)
		  or (id>=18752 and id<=18756)
	 		or (id>=31493 and id<=31502) 
	 		or (id>=40357 and id<=40366)	-- ���⡢�컪������Ʊ
	 		or (id>=50610 and id<=50619)	-- ���㡢̫껻�����Ʊ
	 		or (id>=54766	and id<=54770)  -- ���ʻ�����Ʊ
			or (id>=62174	and id<=62178)  -- ǣ��������Ʊ
			or (id>=62179	and id<=62183)  -- Ӣ�л�����Ʊ
			or (id == 62061	or id == 62062 or id == 62063)
	then 
		return LotteryTypeCharmSeason1SelectNumber(cur_list,max_count,id);	
	elseif(id==10555 or id==6560) then 					---���û��������ԵĲ�Ʊ����Ч
		return 0;
	elseif(id==13593) then 
		return LotteryType13593SelectNumber(cur_list,max_count);	
	elseif(id==13905) then 
		return LotteryType13905SelectNumber(cur_list,max_count);
	elseif(id==15677) then 
		return LotteryType15677SelectNumber(cur_list,max_count);
	elseif(id==15866) then 
		return LotteryType15866SelectNumber(cur_list,max_count);
	elseif(id==16550) then 
		return LotteryType16550SelectNumber(cur_list,max_count);
	elseif(id==18283) then 
		return LotteryType18283SelectNumber(cur_list,max_count);
	elseif(id==18799) then 
		return LotteryType18799SelectNumber(cur_list,max_count);
	elseif(id==18890) then 
		return LotteryType18890SelectNumber(cur_list,max_count);
	elseif(id==19079 or id==19081 or id==19082 or id==19087) then 
		return LotteryTypeGoldSeason1SelectNumber(cur_list,max_count);
	elseif(id==19112 or id==19113 or id==19114) then 
		return LotteryTypeItemSeason1SelectNumber(cur_list,max_count);
	elseif(id==19115) then 
		return LotteryTypeItemSeason2SelectNumber(cur_list,max_count);
	elseif(id==19125) then 
		return LotteryType19125SelectNumber(cur_list,max_count);
	elseif(id==19297) then 
		return LotteryType19297SelectNumber(cur_list,max_count);
	elseif(id==19434) then 
		return LotteryType19434SelectNumber(cur_list,max_count);
	elseif(id>=19425 and id<=19433) then 
		return LotteryTypeGoldSeason2SelectNumber(cur_list,max_count);
	elseif(id==19558) then 
		return LotteryType19558SelectNumber(cur_list,max_count);
	elseif(id==19713) then 
		return LotteryType19713SelectNumber(cur_list,max_count);
	elseif(id==20097) then 
		return LotteryType20097SelectNumber(cur_list,max_count);
	elseif(id==20109) then 
		return LotteryType20109SelectNumber(cur_list,max_count);
	elseif(id==20284) then 
		return LotteryType20284SelectNumber(cur_list,max_count);
	elseif(id==20480) then 
		return LotteryType20480SelectNumber(cur_list,max_count);
	elseif(id==20482) then 
		return LotteryType20482SelectNumber(cur_list,max_count);
	elseif(id==20460) then 
		return LotteryType20460SelectNumber(cur_list,max_count);
	elseif(id==21194) then 
		return LotteryType21194SelectNumber(cur_list,max_count);
	elseif(id==21697) then 
		return LotteryType21697SelectNumber(cur_list,max_count);
	elseif(id==21752) then 
		return LotteryType21752SelectNumber(cur_list,max_count);
	elseif(id==22126) then 
		return LotteryType22126SelectNumber(cur_list,max_count);
	elseif(id==22127) then 
		return LotteryType22127SelectNumber(cur_list,max_count);
	elseif(id==23144) then 
		return LotteryType23144SelectNumber(cur_list,max_count);
	elseif(id==23162) then 
		return LotteryType23162SelectNumber(cur_list,max_count);
	elseif(id==23018) then 
		return LotteryType23018SelectNumber(cur_list,max_count);
	elseif(id==23295) then 
		return LotteryType23295SelectNumber(cur_list,max_count);
	elseif(id==23212) then 
		return LotteryType23212SelectNumber(cur_list,max_count);
	elseif(id==23336) then 
		return LotteryType23336SelectNumber(cur_list,max_count);
	elseif(id==23363) then 
		return LotteryType23363SelectNumber(cur_list,max_count);
	elseif(id==23422) then 
		return LotteryType23422SelectNumber(cur_list,max_count);
	elseif(id==23423) then 
		return LotteryType23423SelectNumber(cur_list,max_count);
	elseif(id==24343) then 
		return LotteryType24343SelectNumber(cur_list,max_count);
	elseif(id==24344) then 
		return LotteryType24344SelectNumber(cur_list,max_count);
	elseif(id==24993) then 
		return LotteryType24993SelectNumber(cur_list,max_count);
	elseif(id==24998) then 
		return LotteryType24998SelectNumber(cur_list,max_count);
	elseif(id==24999) then 
		return LotteryType24999SelectNumber(cur_list,max_count);
	elseif(id==34125) then 
		return LotteryType34125SelectNumber(cur_list,max_count);
	elseif(id==33055) then 
		return LotteryType33055SelectNumber(cur_list,max_count);
	elseif(id==28703) then 
		return LotteryType28703SelectNumber(cur_list,max_count);
	elseif(id==25418) then 
		return LotteryType25418SelectNumber(cur_list,max_count);
	elseif(id==25305) then 
		return LotteryType25305SelectNumber(cur_list,max_count);
	elseif(id==34124) then 
		return LotteryType34124SelectNumber(cur_list,max_count);
	elseif(id==25000) then 
		return LotteryType25000SelectNumber(cur_list,max_count);
	elseif(id==34937) then 
		return LotteryType34937SelectNumber(cur_list,max_count);
	elseif(id==25750) then 
		return LotteryType25750SelectNumber(cur_list,max_count);
	elseif(id==28573) then 
		return LotteryType28573SelectNumber(cur_list,max_count);
	elseif(id==34295) then 
		return LotteryType34295SelectNumber(cur_list,max_count);
	elseif(id==41080) then 
		return LotteryType41080SelectNumber(cur_list,max_count);
	elseif(id==40928) then 
		return LotteryType40928SelectNumber(cur_list,max_count);
	elseif(id==32605) then 
		return LotteryType32605SelectNumber(cur_list,max_count);
	elseif(id==42732) then 
		return LotteryType42732SelectNumber(cur_list,max_count);
	elseif(id==42784) then 
		return LotteryType42784SelectNumber(cur_list,max_count);
	elseif(id==42868) then 
		return LotteryType42868SelectNumber(cur_list,max_count);
	elseif(id==25417) then 
		return LotteryType25417SelectNumber(cur_list,max_count);
	elseif(id==42665) then 
		return LotteryType42665SelectNumber(cur_list,max_count);
	elseif(id==44403) then 
		return LotteryType44403SelectNumber(cur_list,max_count);
	elseif(id==42353) then 
		return LotteryType42353SelectNumber(cur_list,max_count);
	elseif(id==40529) then 
		return LotteryType40529SelectNumber(cur_list,max_count);
	elseif(id==44638) then 
		return LotteryType44638SelectNumber(cur_list,max_count);
	elseif(id==43403) then 
		return LotteryType43403SelectNumber(cur_list,max_count);
	elseif(id==50621) then 
		return LotteryType50621SelectNumber(cur_list,max_count);
	elseif(id==44764) then 
		return LotteryType44764SelectNumber(cur_list,max_count);
	elseif(id==50824) then 
		return LotteryType50824SelectNumber(cur_list,max_count);
	elseif(id==44766) then 
		return LotteryType44766SelectNumber(cur_list,max_count);
	elseif(id==33530) then 
		return LotteryType33530SelectNumber(cur_list,max_count);
	elseif(id==51097) then 
		return LotteryType51097SelectNumber(cur_list,max_count);
	elseif(id==51203) then 
		return LotteryType51203SelectNumber(cur_list,max_count);
	elseif(id==51267) then 
		return LotteryType51267SelectNumber(cur_list,max_count);
	elseif(id==40670) then 
		return LotteryType40670SelectNumber(cur_list,max_count);
	elseif(id==40344) then 
		return LotteryType40344SelectNumber(cur_list,max_count);
	elseif(id==35361) then 
		return LotteryType35361SelectNumber(cur_list,max_count);
	elseif(id==32692) then 
		return LotteryType32692SelectNumber(cur_list,max_count);
	elseif(id==41391) then 
		return LotteryType41391SelectNumber(cur_list,max_count);
	elseif(id==52346) then 
		return LotteryType52346SelectNumber(cur_list,max_count);
	elseif(id==51452) then 
		return LotteryType51452SelectNumber(cur_list,max_count);
	elseif(id==40346) then 
		return LotteryType40346SelectNumber(cur_list,max_count);
	elseif(id==25749) then 
		return LotteryType25749SelectNumber(cur_list,max_count);
	elseif(id==52751) then 
		return LotteryType52751SelectNumber(cur_list,max_count);
	elseif(id==44823) then 
		return LotteryType44823SelectNumber(cur_list,max_count);
	elseif(id==52457) then 
		return LotteryType52457SelectNumber(cur_list,max_count);
	elseif(id==54054) then 
		return LotteryType54054SelectNumber(cur_list,max_count);
	elseif(id==54858) then 
		return LotteryType54858SelectNumber(cur_list,max_count);
	elseif(id==41307) then 
		return LotteryType41307SelectNumber(cur_list,max_count);
	elseif(id==52471) then 
		return LotteryType52471SelectNumber(cur_list,max_count);
	elseif(id==42338) then 
		return LotteryType42338SelectNumber(cur_list,max_count);
	elseif(id==40345) then 
		return LotteryType40345SelectNumber(cur_list,max_count);
	elseif(id==50984) then 
		return LotteryType50984SelectNumber(cur_list,max_count);
	elseif(id==54031) then 
		return LotteryType54031SelectNumber(cur_list,max_count);
	elseif(id==52680) then 
		return LotteryType52680SelectNumber(cur_list,max_count);
	elseif(id==54886) then 
		return LotteryType54886SelectNumber(cur_list,max_count);
	elseif(id==55541) then 
		return LotteryType55541SelectNumber(cur_list,max_count);
	elseif(id==55792) then 
		return LotteryType55792SelectNumber(cur_list,max_count);
	elseif(id==55590) then 
		return LotteryType55590SelectNumber(cur_list,max_count);
	elseif(id==55966) then 
		return LotteryType55966SelectNumber(cur_list,max_count);
	elseif(id==58313) then 
		return LotteryType58313SelectNumber(cur_list,max_count);
	elseif(id==60300) then 
		return LotteryType60300SelectNumber(cur_list,max_count);
	elseif(id==58365) then 
		return LotteryType58365SelectNumber(cur_list,max_count);
	elseif(id==61160) then 
		return LotteryType61160SelectNumber(cur_list,max_count);
	elseif(id==58555) then 
		return LotteryType58555SelectNumber(cur_list,max_count);
	elseif(id==55493) then 
		return LotteryType55493SelectNumber(cur_list,max_count);
	elseif(id==54909) then 
		return LotteryType54909SelectNumber(cur_list,max_count);
	elseif(id==57426) then 
		return LotteryType57426SelectNumber(cur_list,max_count);
	elseif(id==54929) then 
		return LotteryType54929SelectNumber(cur_list,max_count);
	elseif(id==33823) then 
		return LotteryType33823SelectNumber(cur_list,max_count);
	elseif(id==58780) then 
		return LotteryType58780SelectNumber(cur_list,max_count);
	elseif(id==55442) then 
		return LotteryType55442SelectNumber(cur_list,max_count);
	else
		return 0;
	end 	
end

function LotteryCashing(id,cur_list)
	if(id == 6576) then
		return LotteryType6576Cashing(cur_list);
	elseif(id == 7916) then
		return LotteryType7916Cashing(cur_list);
	elseif(id == 10484) then
		return LotteryType10484Cashing(cur_list);
	elseif(id==10722) then
		return LotteryType10722Cashing(cur_list);
	elseif(id==11537) then
		return LotteryType11537Cashing(cur_list);	
	elseif(id==11742) then
		return LotteryType11742Cashing(cur_list);	
	elseif(id==11743) then
		return LotteryType11743Cashing(cur_list);	
	elseif(id==12006) then
		return LotteryType12006Cashing(cur_list);
	elseif(id==13318) then
		return LotteryType13318Cashing(cur_list);	
	elseif(id==13319) then
		return LotteryType13319Cashing(cur_list);		
	elseif(id==13377) then
		return LotteryType13377Cashing(cur_list);		
	elseif (id>=13320 and id<=13339) 
			or (id>=18752 and id<=18756) 
			or (id>=31493 and id<=31502)
			or (id>=40357 and id<=40366)	-- ���⡢�컪������Ʊ
			or (id>=50610 and id<=50619)	-- ���㡢̫껻�����Ʊ
			or (id>=54766	and id<=54770)  -- ���ʻ�����Ʊ
			or (id>=62174	and id<=62178)  -- ǣ��������Ʊ
			or (id>=62179	and id<=62183)  -- Ӣ�л�����Ʊ
			or (id == 62061	or id == 62062 or id == 62063)
	then
		return LotteryTypeCharmSeason1Cashing(cur_list,id);	
	elseif(id==10555 or id==6560) then 					---���û��������ԵĲ�Ʊ����Ч
		return 0;
	elseif(id==13593) then 
		return LotteryType13593Cashing(cur_list);	
	elseif(id==13905) then 
		return LotteryType13905Cashing(cur_list);	
	elseif(id==15677) then 
		return LotteryType15677Cashing(cur_list);	
	elseif(id==15866) then 
		return LotteryType15866Cashing(cur_list);
	elseif(id==16550) then 
		return LotteryType16550Cashing(cur_list);
	elseif(id==18283) then 
		return LotteryType18283Cashing(cur_list);
	elseif(id==18799) then 
		return LotteryType18799Cashing(cur_list);
	elseif(id==18890) then 
		return LotteryType18890Cashing(cur_list);
	elseif(id==19079 or id==19081 or id==19082 or id==19087) then
		return LotteryTypeGoldSeason1Cashing(cur_list,id);
	elseif(id==19112 or id==19113 or id==19114) then
		return LotteryTypeItemSeason1Cashing(cur_list,id);
	elseif(id==19115) then
		return LotteryTypeItemSeason2Cashing(cur_list,id);
	elseif(id==19125) then
		return LotteryType19125Cashing(cur_list);
	elseif(id==19297) then
		return LotteryType19297Cashing(cur_list);
	elseif(id==19434) then
		return LotteryType19434Cashing(cur_list);
	elseif(id>=19425 and id<=19433) then
		return LotteryTypeGoldSeason2Cashing(cur_list,id);
	elseif(id==19558) then
		return LotteryType19558Cashing(cur_list);
	elseif(id==19713) then
		return LotteryType19713Cashing(cur_list);
	elseif(id==20097) then
		return LotteryType20097Cashing(cur_list);
	elseif(id==20109) then
		return LotteryType20109Cashing(cur_list);
	elseif(id==20284) then
		return LotteryType20284Cashing(cur_list);
	elseif(id==20480) then
		return LotteryType20480Cashing(cur_list);
	elseif(id==20482) then
		return LotteryType20482Cashing(cur_list);
	elseif(id==20460) then
		return LotteryType20460Cashing(cur_list);
	elseif(id==21194) then
		return LotteryType21194Cashing(cur_list);
	elseif(id==21697) then
		return LotteryType21697Cashing(cur_list);
	elseif(id==21752) then
		return LotteryType21752Cashing(cur_list);
	elseif(id==22126) then
		return LotteryType22126Cashing(cur_list);
	elseif(id==22127) then
		return LotteryType22127Cashing(cur_list);
	elseif(id==23144) then
		return LotteryType23144Cashing(cur_list);
	elseif(id==23162) then
		return LotteryType23162Cashing(cur_list);
	elseif(id==23018) then
		return LotteryType23018Cashing(cur_list);
	elseif(id==23295) then
		return LotteryType23295Cashing(cur_list);
	elseif(id==23212) then
		return LotteryType23212Cashing(cur_list);
	elseif(id==23336) then
		return LotteryType23336Cashing(cur_list);
	elseif(id==23363) then
		return LotteryType23363Cashing(cur_list);
	elseif(id==23422) then
		return LotteryType23422Cashing(cur_list);
	elseif(id==23423) then
		return LotteryType23423Cashing(cur_list);
	elseif(id==24343) then
		return LotteryType24343Cashing(cur_list);
	elseif(id==24344) then
		return LotteryType24344Cashing(cur_list);
	elseif(id==24993) then
		return LotteryType24993Cashing(cur_list);    
	elseif(id==24998) then
		return LotteryType24998Cashing(cur_list);
	elseif(id==24999) then
		return LotteryType24999Cashing(cur_list);
	elseif(id==34125) then
		return LotteryType34125Cashing(cur_list);
	elseif(id==33055) then
		return LotteryType33055Cashing(cur_list);
	elseif(id==28703) then
		return LotteryType28703Cashing(cur_list);
	elseif(id==25418) then
		return LotteryType25418Cashing(cur_list);
	elseif(id==25305) then
		return LotteryType25305Cashing(cur_list);
	elseif(id==34124) then
		return LotteryType34124Cashing(cur_list);
	elseif(id==25000) then
		return LotteryType25000Cashing(cur_list);
	elseif(id==34937) then
		return LotteryType34937Cashing(cur_list);
	elseif(id==25750) then
		return LotteryType25750Cashing(cur_list);
	elseif(id==28573) then
		return LotteryType28573Cashing(cur_list);
	elseif(id==34295) then
		return LotteryType34295Cashing(cur_list);
	elseif(id==41080) then
		return LotteryType41080Cashing(cur_list);
	elseif(id==40928) then
		return LotteryType40928Cashing(cur_list);
	elseif(id==32605) then
		return LotteryType32605Cashing(cur_list);
	elseif(id==42732) then
		return LotteryType42732Cashing(cur_list);
	elseif(id==42784) then
		return LotteryType42784Cashing(cur_list);
	elseif(id==42868) then
		return LotteryType42868Cashing(cur_list);
	elseif(id==25417) then
		return LotteryType25417Cashing(cur_list);
	elseif(id==42665) then
		return LotteryType42665Cashing(cur_list);
	elseif(id==44403) then
		return LotteryType44403Cashing(cur_list);
	elseif(id==42353) then
		return LotteryType42353Cashing(cur_list);
	elseif(id==40529) then
		return LotteryType40529Cashing(cur_list);
	elseif(id==44638) then
		return LotteryType44638Cashing(cur_list);
	elseif(id==43403) then
		return LotteryType43403Cashing(cur_list);
	elseif(id==50621) then
		return LotteryType50621Cashing(cur_list);
	elseif(id==44764) then
		return LotteryType44764Cashing(cur_list);
	elseif(id==50824) then
		return LotteryType50824Cashing(cur_list);
	elseif(id==44766) then
		return LotteryType44766Cashing(cur_list);
	elseif(id==33530) then
		return LotteryType33530Cashing(cur_list);
	elseif(id==51097) then
		return LotteryType51097Cashing(cur_list);
	elseif(id==51203) then
		return LotteryType51203Cashing(cur_list);
	elseif(id==51267) then
		return LotteryType51267Cashing(cur_list);
	elseif(id==40670) then
		return LotteryType40670Cashing(cur_list);
	elseif(id==40344) then
		return LotteryType40344Cashing(cur_list);
	elseif(id==35361) then
		return LotteryType35361Cashing(cur_list);
	elseif(id==32692) then
		return LotteryType32692Cashing(cur_list);
	elseif(id==41391) then
		return LotteryType41391Cashing(cur_list);
	elseif(id==52346) then
		return LotteryType52346Cashing(cur_list);
	elseif(id==51452) then
		return LotteryType51452Cashing(cur_list);
	elseif(id==40346) then
		return LotteryType40346Cashing(cur_list);
	elseif(id==25749) then
		return LotteryType25749Cashing(cur_list);
	elseif(id==52751) then
		return LotteryType52751Cashing(cur_list);
	elseif(id==44823) then
		return LotteryType44823Cashing(cur_list);
	elseif(id==52457) then
		return LotteryType52457Cashing(cur_list);
	elseif(id==54054) then
		return LotteryType54054Cashing(cur_list);
	elseif(id==54858) then
		return LotteryType54858Cashing(cur_list);
	elseif(id==41307) then
		return LotteryType41307Cashing(cur_list);
	elseif(id==52471) then
		return LotteryType52471Cashing(cur_list);
	elseif(id==42338) then
		return LotteryType42338Cashing(cur_list);
	elseif(id==40345) then
		return LotteryType40345Cashing(cur_list);
	elseif(id==50984) then
		return LotteryType50984Cashing(cur_list);
	elseif(id==54031) then
		return LotteryType54031Cashing(cur_list);
	elseif(id==52680) then
		return LotteryType52680Cashing(cur_list);
	elseif(id==54929) then
		return LotteryType54929Cashing(cur_list);
	elseif(id==55541) then
		return LotteryType55541Cashing(cur_list);
	elseif(id==55792) then
		return LotteryType55792Cashing(cur_list);
	elseif(id==55590) then
		return LotteryType55590Cashing(cur_list);
	elseif(id==55966) then
		return LotteryType55966Cashing(cur_list);
	elseif(id==55493) then
		return LotteryType55493Cashing(cur_list);
	elseif(id==58313) then
		return LotteryType58313Cashing(cur_list);
	elseif(id==60300) then
		return LotteryType60300Cashing(cur_list);
	elseif(id==58365) then
		return LotteryType58365Cashing(cur_list);
	elseif(id==58555) then
		return LotteryType58555Cashing(cur_list);
	elseif(id==61160) then
		return LotteryType61160Cashing(cur_list);
	elseif(id==54909) then
		return LotteryType54909Cashing(cur_list);
	elseif(id==57426) then
		return LotteryType57426Cashing(cur_list);
	elseif(id==54886) then
		return LotteryType54886Cashing(cur_list);
	elseif(id==33823) then
		return LotteryType33823Cashing(cur_list);
	elseif(id==58780) then
		return LotteryType58780Cashing(cur_list);
	elseif(id==55442) then
		return LotteryType55442Cashing(cur_list);
	else
		return 0;	-- ���ش���
	end 	
end

-------------------------------------------------------------------------------------------------------------
--[[
--  ����һ����ѡʵ�֡�ʹ��table�������еĲ�Ʊ�ӿڡ�����ʱֱ�Ӳ�ѯ������֮
--	�ź���Ҫ��AddLotteryTemplate����ÿ�ֲ�Ʊ��ӳ����뵽����.
--	��ֻ��һ����ʾ�Դ��룬�ӿڵ����ֱ��޸�ΪXXXX_aux�������򲢲������������ƵĽӿں���
--

function LotterySelectNumber_aux(id, max_count, cur_list)
	local m = lottery_template[id];
	if(m) then
	return m.Select(cur_list, max_count);
	end
	return 0; 	-- ���ش���
end

function LotteryCashing_aux(id , cur_list)
	local m = lottery_template[id];
	if(m) then
	return m.Cashing(cur_list);
	end
	return 0;	-- ���ش���
end

AddLotteryTemplate(3613, LotteryType3613SelectNumber,LotteryType3613Cashing);
--]]