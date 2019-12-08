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
function LotteryType6576SelectNumber(list, max_count) --- Lottery Used@20070618(��ľ����)
	local NumList={1,2,3,4}
	local NumChance={360,360,360,180}
	return NumList[ZLottery_Get_RanPoint(NumChance)]
end
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType7916SelectNumber(list, max_count) --- Lottery Used@20070706(�����)
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
function LotteryType10722SelectNumber(list, max_count) --- Lottery Used@200708XX(���Ԫ��)
	local NumList={1,2,3,4}
	local NumChance={280,10,200,510}
	return NumList[ZLottery_Get_RanPoint(NumChance)]
end
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType11537SelectNumber(list, max_count) --- Lottery Used@20070924(����֮��)
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
function LotteryType12006SelectNumber(list, max_count) --- Lottery Used@20071106(���Ա���)
	local NumList={1,2,3,4}
	local NumChance={100,40,100,760}
	return NumList[ZLottery_Get_RanPoint(NumChance)]
end
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType13318SelectNumber(list, max_count) --- Lottery Used@20071123(��������)
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
	local NumChance={136,216,400,248}
	return NumList[ZLottery_Get_RanPoint(NumChance)]
end
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType13905SelectNumber(list, max_count) --- Lottery Used@20080115(��ͼ��)
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
function LotteryType15866SelectNumber(list, max_count) --- Lottery Used@20080315(�׹�ī��)
	local NumList={1,2,3,4}
	local NumChance={1260,2155,2934,3651}
	return NumList[ZLottery_Get_RanPoint(NumChance)]
end
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType16550SelectNumber(list, max_count) --- Lottery Used@20080416(��¹����)
	local NumList={1,2,3,4}
	local NumChance={1260,3420,3300,2020}
	return NumList[ZLottery_Get_RanPoint(NumChance)]
end
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType18283SelectNumber(list, max_count) --- Lottery Used@20080509(�������)
	local NumList={1,2,3,4}
	local NumChance={1260,3550,3300,1890}
	return NumList[ZLottery_Get_RanPoint(NumChance)]
end
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType18799SelectNumber(list, max_count) --- Lottery Used@20080601(�����쾧)
	local NumList={1,2,3,4}
	local NumChance={2000,2160,3000,2840}
	return NumList[ZLottery_Get_RanPoint(NumChance)]
end
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType18890SelectNumber(list, max_count) --- Lottery Used@20080619(����ʥ��)
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
function LotteryType19125SelectNumber(list, max_count) 			--- Lottery Used@20080710(��������)
	local NumList={1,2,3,4}
	local NumChance={1450,3110,3000,2440}
	return NumList[ZLottery_Get_RanPoint(NumChance)]
end
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType19297SelectNumber(list, max_count) 			--- Lottery Used@20080730(�ƹ����)
	local NumList={1,2,3,4}
	local NumChance={1450,2470,3000,3080}
	return NumList[ZLottery_Get_RanPoint(NumChance)]
end
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType19434SelectNumber(list, max_count) 			--- Lottery Used@20080812(������ͼ)
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
function LotteryType19713SelectNumber(list, max_count) 			--- Lottery Used@20080916(����֮��)
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
function LotteryType20109SelectNumber(list, max_count) 			--- Lottery Used@20080930(�������)
	local NumList={1,2,3,4}
	local NumChance={1450,1000,3000,4550}
	return NumList[ZLottery_Get_RanPoint(NumChance)]
end
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType20284SelectNumber(list, max_count) 			--- Lottery Used@20081009(����ӡ)
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
function LotteryType88813SelectNumber(list, max_count)			--- Lottery Used@20081203(������)
	local NumList={1,2,3,4}
	local NumChance={126,311,300,263}
	return NumList[ZLottery_Get_RanPoint(NumChance)]
end
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------

function LotteryType6576Cashing(cur_list)		---(��ľ����)
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
	
	Out_Prize[1][4713]=100
	
	Out_Prize[2][6473]=100

	Out_Prize[3][3988]=100
	Out_Prize[3][3991]=100
	Out_Prize[3][6430]=100
	Out_Prize[3][3989]=100
	Out_Prize[3][3990]=100
	Out_Prize[3][3992]=100
	
	Out_Prize[4][1807]=100
		
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
	
	Out_Prize[1][7925]=100
	
	Out_Prize[2][7540]=100
	Out_Prize[2][7541]=100
	
	Out_Prize[3][6473]=100
	Out_Prize[4][1807]=100
		
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

	Out_Prize[3][7928]=100
	Out_Prize[3][7932]=100
	Out_Prize[3][7935]=100
	Out_Prize[3][7939]=100
	
	Out_Prize[4][4703]=100
		
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
function LotteryType10722Cashing(cur_list)	---(���Ԫ��)
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
	
	Out_Prize[1][10715]=100
	
	Out_Prize[2][7824]=100
	
	
	Out_Prize[3][6473]=100
	Out_Prize[4][8079]=100
		
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
	
	Out_Prize[1][11538]=100
	
	Out_Prize[2][11539]=100
	
	
	Out_Prize[3][6473]=100
	Out_Prize[4][8079]=100
		
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
function LotteryType12006Cashing(cur_list)	---(���Ա���)
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
	
	Out_Prize[1][12005]=100
	
	Out_Prize[2][10869]=100
	
	
	Out_Prize[3][2579]=100
	Out_Prize[4][8079]=100
		
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
function LotteryType13318Cashing(cur_list)	---(��������)
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

	Out_Prize[3][13344]=100		---//���Ӷһ�ȯ(��ҿɼ�Ϊ3�Ƚ�)		

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
	Out_Prize[2][13350]=100		---�߼����Ƿ�
	Out_Prize[3][13343]=100		---//��ý�һ�ȯ
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
	
	Out_Prize[1][13592]=100
	
	Out_Prize[2][10867]=100

	Out_Prize[3][13343]=100

	Out_Prize[4][8079]=100
		
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
		return 3,0,prizeout,1,0,0
	else 
		return 4,0,8079,2,0,0
	end
	return 4,0,8079,2,0,0 
end 
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType13905Cashing(cur_list)		---(��ͼ��)
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
	
	Out_Prize[1][13486]=100
	
	Out_Prize[2][13904]=333 ---//�߼�����
	Out_Prize[2][13903]=667	---//�߼���ľ
	
	Out_Prize[3][13901]=333	---//��Defҩ
	Out_Prize[3][13900]=667	---//��Atkҩ
	
	Out_Prize[4][8079]=100
		
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
		return 3,0,prizeout,2,0,0
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
	
	Out_Prize[1][15672]=100
	
	Out_Prize[2][7931]=40
	Out_Prize[2][7937]=60	

	Out_Prize[3][15693]=140	---���¶һ�ȯ
	Out_Prize[3][15694]=20	---���նһ�ȯ	
	
	Out_Prize[4][8079]=100
		
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
function LotteryType15866Cashing(cur_list)		---(�׹�ī��)
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
	
	Out_Prize[1][15865]=100		---���ٺڱ�
	
	Out_Prize[2][15868]=100		---����	

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
function LotteryType16550Cashing(cur_list)		---(��¹����)
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

	Out_Prize[3][7939]=100		---�챦������
		
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
function LotteryType18283Cashing(cur_list)		---(�������)
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

	Out_Prize[3][15693]=50	---���¶һ�ȯ
	Out_Prize[3][15694]=30	---���նһ�ȯ	
	
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
function LotteryType18799Cashing(cur_list)		---(�����쾧)
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
	
	Out_Prize[2][18797]=100		---�����һ�ȯ

	Out_Prize[3][15693]=140		---���¶һ�ȯ
	Out_Prize[3][15694]=20		---���նһ�ȯ	
	
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
		if prizeout==15694 then 
			return 3,0,prizeout,1,0,0
		else
			return 3,0,prizeout,2,0,0
		end 
	else 
		prizeout=lot_prize[4][ZLottery_Get_RanPoint(lot_prizechance[4])]
		return 4,0,prizeout,1,0,0
	end
	return 4,0,13900,2,0,0 
end 
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType18890Cashing(cur_list)		---(����ʥ��)
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
	
	Out_Prize[1][18891]=100		---�ɽ��һ�ȯ
	
	Out_Prize[2][10872]=100		---������

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
	if nowcurlist[fmax_count]=="111" then 
		prizeout=lot_prize[1][ZLottery_Get_RanPoint(lot_prizechance[1])]
		return 1,0,prizeout,Out_Prize[1][prizeout].num,0,0
	end
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
function LotteryType19125Cashing(cur_list)		---(��������)
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
function LotteryType19434Cashing(cur_list)		---(Ʊ�����/������ͼ)
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
function LotteryType19713Cashing(cur_list)		---(����֮��)
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
function LotteryType20109Cashing(cur_list)		---(�������)
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
	
	Out_Prize[1][20110]=100		---�ɽ�������һ�ȯ
	
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
function LotteryType20284Cashing(cur_list)		---(����ӡ)
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
function LotteryType20460Cashing(cur_list)		---(����ת��)
	---fmax_countΪ�ò�Ʊ����Чλ��
	local cp
	local nowcurlist={}
	local fmax_count=table.getn(cur_list)
	nowcurlist[0]=""
	for cp=1,fmax_count do
		nowcurlist[cp]=nowcurlist[cp-1]..cur_list[cp]
	end 

	if nowcurlist[fmax_count]=="11" then 
		return 1,0,13350,1,0,0
	elseif nowcurlist[fmax_count]=="13" then
		return 4,0,5520,1,0,0
	elseif nowcurlist[fmax_count]=="13" then
		return 3,0,3993,1,0,0
	elseif nowcurlist[fmax_count]=="14" then
		return 4,0,3994,1,0,0
	elseif nowcurlist[fmax_count]=="21" then
		return 2,0,21284,1,0,0
	elseif nowcurlist[fmax_count]=="22" then
		return 4,0,1807,1,0,0
	elseif nowcurlist[fmax_count]=="23" then
		return 3,0,13990,1,0,0
	elseif nowcurlist[fmax_count]=="24" then
		return 4,0,685,1,0,0
	elseif nowcurlist[fmax_count]=="31" then
		return 2,0,21200,1,0,0
	elseif nowcurlist[fmax_count]=="32" then
		return 4,0,16553,1,0,0
	elseif nowcurlist[fmax_count]=="33" then
		return 3,0,21153,1,0,0
	elseif nowcurlist[fmax_count]=="34" then
		return 4,0,21154,1,0,0
	elseif nowcurlist[fmax_count]=="41" then
		return 2,0,4008,1,0,0
	elseif nowcurlist[fmax_count]=="42" then
		return 4,0,4007,1,0,0
	elseif nowcurlist[fmax_count]=="43" then
		return 3,0,6359,1,0,0
	else
		return 4,0,55,1,0,0
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
function LotteryType88813Cashing(cur_list)		---(�����ƪ/ѩ��������Ҳ�Ʊ)
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

	Out_Prize[1][20645]=80			---�ɡ�����
	Out_Prize[2][20657]=80			---�ɡ�����
	Out_Prize[2][20633]=80			---�ɡ�����
	Out_Prize[2][20621]=80			---�ɡ���ң
	Out_Prize[3][3995]=80			---���·�45%
	Out_Prize[3][21345]=50			---�컯���200
	Out_Prize[4][19257]=50			---�����ڵ�
	Out_Prize[4][21820]=50			---���н��ҡ�ʮ��
	
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
			return 3,0,prizeout,200,0,0
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
	elseif(id>=13320 and id<=13339) or (id>=18752 and id<=18756) then 
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
	elseif(id==19112 or id==19113 or id==19114 or id==19115) then 
		return LotteryTypeItemSeason1SelectNumber(cur_list,max_count);
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
			elseif(id==88813) then 
		return LotteryType88813SelectNumber(cur_list,max_count);
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
	elseif(id>=13320 and id<=13339) or (id>=18752 and id<=18756) then
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
	elseif(id==19112 or id==19113 or id==19114 or id==19115) then
		return LotteryTypeItemSeason1Cashing(cur_list,id);
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
			elseif(id==88813) then
		return LotteryType88813Cashing(cur_list);
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