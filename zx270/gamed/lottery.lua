local lottery_template = {};

function AddLotteryTemplate(id, s1, c1)
	lottery_template[tonumber(id)] = {};
	lottery_template[tonumber(id)].Select = s1;
	lottery_template[tonumber(id)].Cashing = c1;
end

----出现几率正态化-------------------------------------------------------------------------------------------
function ZLottery_Chance_Norm(n1)
  local n1_size=table.getn(n1)
	local Total_Chance=0
	local i,k,m
	---先求和
	for i=1,n1_size do
   		Total_Chance=n1[i]+Total_Chance          
	end
 	---生成概率组序列
	local nx={}
	for k=1,n1_size do
			if k==1 then 
				nx[1]=n1[k]
			else
		    nx[k]=n1[k]+nx[k-1]              
		  end
	end
	---再生产标准化的概率组序列
	local n2={}
  for m=1,n1_size do
   		if Total_Chance==0 then                 ---对于全0序列的处理，返回{1,0,0...}
		 		n2[m]=0
				n2[1]=1
			else
				n2[m]=nx[m]/ Total_Chance
			end
	end
	---返回一个概率序列 
  ---ZLuaTal_Special_Print(n2)   				---$$$$测试用$$$$-----
	return n2
end
-------------------------------------------------------------------------------------------------------------
----按照出现概率随机应该选取的位置---------------------------------------------------------------------------
function ZLottery_Get_RanPoint(s1)
	local js,ron1
	ron1= math.random()                
	---print("---------------------------")     ---$$$$测试用$$$$-----
	---print("Now the random Num is:",ron1) 	---$$$$测试用$$$$-----
  local p1=ZLottery_Chance_Norm(s1)
	for js=1,table.getn(p1) do
          if ron1<=p1[js] then 
		    	---print("So We Choose:",js) 		---$$$$测试用$$$$-----
    	  		return js
		  		end
	end
	return 1
end
-------------------------------------------------------------------------------------------------------------
---找到S1中a数字的个数---------------------------------------------------------------------------------------
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
function LotteryType6576SelectNumber(list, max_count) --- Lottery Used@20070618(神木宝盒)
	local NumList={1,2,3,4}
	local NumChance={360,360,360,180}
	return NumList[ZLottery_Get_RanPoint(NumChance)]
end
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType7916SelectNumber(list, max_count) --- Lottery Used@20070706(玄龟金鼎)
	local NumList={1,2,3}
	local NumChance={120,50,830}
	return NumList[ZLottery_Get_RanPoint(NumChance)]
end
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType10484SelectNumber(list, max_count) --- Lottery Used@20070723(仙工宝箱)
	local NumList={1,2}
	local NumChance={140,860}
	return NumList[ZLottery_Get_RanPoint(NumChance)]
end
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType10722SelectNumber(list, max_count) --- Lottery Used@200708XX(灵狐元丹)
	local NumList={1,2,3,4}
	local NumChance={280,10,200,510}
	return NumList[ZLottery_Get_RanPoint(NumChance)]
end
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType11537SelectNumber(list, max_count) --- Lottery Used@20070924(玄蛇之魂)
	local NumList={1,2,3,4}
	local NumChance={180,10,150,660}
	return NumList[ZLottery_Get_RanPoint(NumChance)]
end
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType11742SelectNumber(list, max_count) --- Lottery Used@20071010(国庆山河扇大礼包)
	local NumList={1,2,3,4}
	local NumChance={100,0,0,0}
	return NumList[ZLottery_Get_RanPoint(NumChance)]
end
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType11743SelectNumber(list, max_count) --- Lottery Used@20071010(国庆万毒鼎大礼包)
	local NumList={1,2,3,4}
	local NumChance={100,0,0,0}
	return NumList[ZLottery_Get_RanPoint(NumChance)]
end
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType12006SelectNumber(list, max_count) --- Lottery Used@20071106(龙驹宝鉴)
	local NumList={1,2,3,4}
	local NumChance={100,40,100,760}
	return NumList[ZLottery_Get_RanPoint(NumChance)]
end
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType13318SelectNumber(list, max_count) --- Lottery Used@20071123(绽魂仙羽)
	local NumList={1,2,3,4}
	local NumChance={40,240,83,637}
	return NumList[ZLottery_Get_RanPoint(NumChance)]
end
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType13319SelectNumber(list, max_count) --- Lottery Used@20071123(乾坤遁宝)
	local NumList={1,2,3,4}
	local NumChance={159,50,105,686}
	return NumList[ZLottery_Get_RanPoint(NumChance)]
end
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryTypeCharmSeason1SelectNumber(list, max_count,id) --- Lottery Used@20071123(第一批护符材料箱)
	local NumList={1,2,3,4}
	local NumChance={100,0,0,0}
	return NumList[ZLottery_Get_RanPoint(NumChance)]
end
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType13377SelectNumber(list, max_count) --- Lottery Used@20071123(虚拟币箱子出产的绽魂仙羽)
	local NumList={1,2,3,4}
	local NumChance={40,240,83,637}
	return NumList[ZLottery_Get_RanPoint(NumChance)]
end
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType13593SelectNumber(list, max_count) --- Lottery Used@20071218(月光宝盒)
	local NumList={1,2,3,4}
	local NumChance={136,216,400,248}
	return NumList[ZLottery_Get_RanPoint(NumChance)]
end
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType13905SelectNumber(list, max_count) --- Lottery Used@20080115(狼图腾)
	local NumList={1,2,3,4}
	local NumChance={1443,4643,2000,1914}
	return NumList[ZLottery_Get_RanPoint(NumChance)]
end
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType15677SelectNumber(list, max_count) --- Lottery Used@20080222(狮王之心)
	local NumList={1,2,3,4}
	local NumChance={1494,1710,1000,5796}
	return NumList[ZLottery_Get_RanPoint(NumChance)]
end
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType15866SelectNumber(list, max_count) --- Lottery Used@20080315(雷光墨玉)
	local NumList={1,2,3,4}
	local NumChance={1260,2155,2934,3651}
	return NumList[ZLottery_Get_RanPoint(NumChance)]
end
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType16550SelectNumber(list, max_count) --- Lottery Used@20080416(逐鹿御令)
	local NumList={1,2,3,4}
	local NumChance={1260,3420,3300,2020}
	return NumList[ZLottery_Get_RanPoint(NumChance)]
end
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType18283SelectNumber(list, max_count) --- Lottery Used@20080509(麒麟金尊)
	local NumList={1,2,3,4}
	local NumChance={1260,3550,3300,1890}
	return NumList[ZLottery_Get_RanPoint(NumChance)]
end
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType18799SelectNumber(list, max_count) --- Lottery Used@20080601(昆仑天晶)
	local NumList={1,2,3,4}
	local NumChance={2000,2160,3000,2840}
	return NumList[ZLottery_Get_RanPoint(NumChance)]
end
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType18890SelectNumber(list, max_count) --- Lottery Used@20080619(行天圣宝)
	local NumList={1,2,3,4}
	local NumChance={1494,2160,3000,3346}
	return NumList[ZLottery_Get_RanPoint(NumChance)]
end
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryTypeGoldSeason1SelectNumber(list, max_count) --- Lottery Used@20080704(金币回收宝箱)
	local NumList={1,2,3,4}
	local NumChance={100,0,0,0}
	return NumList[ZLottery_Get_RanPoint(NumChance)]
end
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryTypeItemSeason1SelectNumber(list, max_count) --- Lottery Used@20080708(装备奖励宝箱)
	local NumList={1,2,3,4}
	local NumChance={100,0,0,0}
	return NumList[ZLottery_Get_RanPoint(NumChance)]
end
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType19125SelectNumber(list, max_count) 			--- Lottery Used@20080710(神龙秘笈)
	local NumList={1,2,3,4}
	local NumChance={1450,3110,3000,2440}
	return NumList[ZLottery_Get_RanPoint(NumChance)]
end
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType19297SelectNumber(list, max_count) 			--- Lottery Used@20080730(云光天鉴)
	local NumList={1,2,3,4}
	local NumChance={1450,2470,3000,3080}
	return NumList[ZLottery_Get_RanPoint(NumChance)]
end
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType19434SelectNumber(list, max_count) 			--- Lottery Used@20080812(龙宫锦图)
	local NumList={1,2,3,4}
	local NumChance={1260,2470,3000,3270}
	return NumList[ZLottery_Get_RanPoint(NumChance)]
end
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType19558SelectNumber(list, max_count) 			--- Lottery Used@20080902(如意之鼓)
	local NumList={1,2,3,4}
	local NumChance={1260,2470,3000,3270}
	return NumList[ZLottery_Get_RanPoint(NumChance)]
end
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryTypeGoldSeason2SelectNumber(list, max_count) --- Lottery Used@20080812(金币回收宝箱/宠物技能书)
	local NumList={1,2,3,4}
	local NumChance={100,0,0,0}
	return NumList[ZLottery_Get_RanPoint(NumChance)]
end
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType19713SelectNumber(list, max_count) 			--- Lottery Used@20080916(炎蹄之心)
	local NumList={1,2,3,4}
	local NumChance={1260,1920,3000,3820}
	return NumList[ZLottery_Get_RanPoint(NumChance)]
end
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType20097SelectNumber(list, max_count) 			--- Lottery Used@20080930(08国庆虚拟币礼包)
	local NumList={1,2,3,4}
	local NumChance={1150,3280,3000,2570}
	return NumList[ZLottery_Get_RanPoint(NumChance)]
end
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType20109SelectNumber(list, max_count) 			--- Lottery Used@20080930(鸣珏瑰玉)
	local NumList={1,2,3,4}
	local NumChance={1450,1000,3000,4550}
	return NumList[ZLottery_Get_RanPoint(NumChance)]
end
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType20284SelectNumber(list, max_count) 			--- Lottery Used@20081009(苍穹光印)
	local NumList={1,2,3,4}
	local NumChance={1590,3420,3000,1990}
	return NumList[ZLottery_Get_RanPoint(NumChance)]
end
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType20480SelectNumber(list, max_count)			--- Lottery Used@20081022A(孔雀令)
	local NumList={1,2,3,4}
	local NumChance={1260,1920,3000,3820}
	return NumList[ZLottery_Get_RanPoint(NumChance)]
end
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType20482SelectNumber(list, max_count)			--- Lottery Used@20081022B(龙皇古卷)
	local NumList={1,2,3,4}
	local NumChance={1700,2500,3300,2500}
	return NumList[ZLottery_Get_RanPoint(NumChance)]
end
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType20460SelectNumber(list, max_count)			--- Lottery Used@20081106(命运轮盘)
	local NumList={1,2,3,4}
	local NumChance={20,20,30,30}
	return NumList[ZLottery_Get_RanPoint(NumChance)]
end
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType21194SelectNumber(list, max_count)			--- Lottery Used@20081113(兽骨玉匣)
	local NumList={1,2,3,4}
	local NumChance={126,247,300,327}
	return NumList[ZLottery_Get_RanPoint(NumChance)]
end
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType21697SelectNumber(list, max_count)			--- Lottery Used@20081201(极东绽石)
	local NumList={1,2,3,4}
	local NumChance={171,311,300,218}
	return NumList[ZLottery_Get_RanPoint(NumChance)]
end
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType21752SelectNumber(list, max_count)			--- Lottery Used@20081202(天眷神篇/雪琪月虚拟币彩票)
	local NumList={1,2,3,4}
	local NumChance={126,311,300,263}
	return NumList[ZLottery_Get_RanPoint(NumChance)]
end
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------
function LotteryType88813SelectNumber(list, max_count)			--- Lottery Used@20081203(聚仙盘)
	local NumList={1,2,3,4}
	local NumChance={126,311,300,263}
	return NumList[ZLottery_Get_RanPoint(NumChance)]
end
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------

function LotteryType6576Cashing(cur_list)		---(神木宝盒)
	---fmax_count为该彩票的有效位数
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
function LotteryType7916Cashing(cur_list)	---(玄龟金鼎)
	---fmax_count为该彩票的有效位数
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
function LotteryType10484Cashing(cur_list)	---(仙工宝箱)
	---fmax_count为该彩票的有效位数
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
	
	Out_Prize[1][4708]=100	---七星剑
	Out_Prize[1][4709]=100	---四灵幡
	Out_Prize[1][4710]=100	---金刚杵
	Out_Prize[1][4711]=100	---多情环
	
	Out_Prize[2][6047]=50	---八卦石秘笈
	
	Out_Prize[2][6050]=100	---六合镜秘笈
	Out_Prize[2][6048]=100	---朱雀印秘笈
	Out_Prize[2][6051]=100	---轮回珠秘笈
	Out_Prize[2][6049]=100	---慑心铃秘笈
	
	Out_Prize[2][6054]=50	---七星剑秘笈
	Out_Prize[2][6052]=50	---四灵幡秘笈
	Out_Prize[2][6055]=50	---金刚杵秘笈
	Out_Prize[2][6053]=50	---多情环秘笈
	
	Out_Prize[2][6056]=10	---山河扇秘笈
	Out_Prize[2][6057]=10	---神木骰秘笈
	Out_Prize[2][6059]=10	---玉净瓶秘笈

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
function LotteryType10722Cashing(cur_list)	---(灵狐元丹)
	---fmax_count为该彩票的有效位数
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
function LotteryType11537Cashing(cur_list)	---(玄蛇之魂)
	---fmax_count为该彩票的有效位数
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
function LotteryType11742Cashing(cur_list)	---(国庆山河扇大礼包)
	---fmax_count为该彩票的有效位数
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
function LotteryType11743Cashing(cur_list)	---(国庆万毒鼎大礼包)
	---fmax_count为该彩票的有效位数
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
function LotteryType12006Cashing(cur_list)	---(龙驹宝鉴)
	---fmax_count为该彩票的有效位数
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
function LotteryType13318Cashing(cur_list)	---(绽魂仙羽)
	---fmax_count为该彩票的有效位数
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
	
	Out_Prize[1][13342]=100		---鹤（兑换券）	
	
	Out_Prize[2][13312]=20		---衣服
	Out_Prize[2][13313]=40		---头饰	
	Out_Prize[2][13314]=40		---鞋子

	Out_Prize[3][13344]=100		---//箱子兑换券(玩家可见为3等奖)		

	Out_Prize[4][11678]=25		---玄真秘文石(玩家可见为4等奖)
	Out_Prize[4][11676]=25		---魔魂秘文石
	Out_Prize[4][11679]=25		---佛尊秘文石			
	Out_Prize[4][11677]=25		---奇艳秘文石

	Out_Prize[5][8079]=100		---飞天神符	
		
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
function LotteryType13377Cashing(cur_list)	---(虚拟币出产箱子的绽魂仙羽)
	---fmax_count为该彩票的有效位数
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
	
	Out_Prize[1][13342]=100		---鹤（兑换券）	
	
	Out_Prize[2][13312]=20		---衣服
	Out_Prize[2][13313]=40		---头饰	
	Out_Prize[2][13314]=40		---鞋子
		
	Out_Prize[3][13344]=100		---//箱子兑换券
	
	Out_Prize[4][11678]=25		---玄真秘文石
	Out_Prize[4][11676]=25		---魔魂秘文石
	Out_Prize[4][11679]=25		---佛尊秘文石			
	Out_Prize[4][11677]=25		---奇艳秘文石
	

	Out_Prize[5][8079]=100		---飞天神符	
		
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
function LotteryType13319Cashing(cur_list)	---(乾坤遁宝)
	---fmax_count为该彩票的有效位数
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
	
	Out_Prize[1][10867]=100		---阴阳镜
	Out_Prize[2][13350]=100		---高级吉星符
	Out_Prize[3][13343]=100		---//灵媒兑换券
	Out_Prize[4][1807]=100		---太一轮
		
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
function LotteryTypeCharmSeason1Cashing(cur_list,id)	---(第一批护符材料)
	---fmax_count为该彩票的有效位数
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
	
	if id==13320 then  ---道逾
		Out_Prize[1][12686]=200  ---寒冰烈炎_金
		Out_Prize[1][12691]=47  ---少阳初现_金
		Out_Prize[1][12696]=63  ---破魔秘法_金
		Out_Prize[1][12701]=27  ---天眷有道_金
		Out_Prize[1][12706]=26  ---驱物法诀_金
		Out_Prize[1][12711]=31  ---护体罡气_金
		Out_Prize[1][12716]=53  ---炼神还虚_金
		Out_Prize[1][12722]=42  ---冰心玉阙_金
		Out_Prize[1][12727]=28  ---仙元护体_金
		Out_Prize[1][12732]=31  ---先天罡气_金
		Out_Prize[1][12737]=47  ---雷神降世_金
		Out_Prize[1][12742]=200  ---风剑之芒_金
		Out_Prize[1][12747]=170  ---归元真解_金
		Out_Prize[1][12752]=63  ---破魔怒意_金
		Out_Prize[1][12757]=63  ---怒剑心劫_金
		Out_Prize[1][12762]=37  ---邪剑星羽_金
		Out_Prize[1][12767]=47  ---天诛真诀_金
		Out_Prize[1][12772]=32  ---斩龙奥义_金
		Out_Prize[1][12777]=27  ---玄天星芒_金
		Out_Prize[1][12782]=170  ---剑元之聚_金
		Out_Prize[1][12788]=29  ---气贯长虹_金
		Out_Prize[1][12793]=30  ---玄冰圣护_金
		Out_Prize[1][12798]=29  ---玄冰劲气_金
		Out_Prize[1][12803]=23  ---返朴归真_金
		Out_Prize[1][12808]=23  ---狂雷天怒_金
		Out_Prize[1][12813]=38  ---冰域天机_金
		Out_Prize[1][12818]=36  ---盛冰之寒_金
		Out_Prize[1][12823]=72  ---霜寒化境_金
		Out_Prize[1][12828]=63  ---雷云奇变_金
		Out_Prize[1][12833]=63  ---五雷交轰_金
		Out_Prize[1][12838]=25  ---天雷狂啸_金
		Out_Prize[1][12843]=29  ---群雷裂空_金
		Out_Prize[1][12848]=34  ---天地无用_金

	elseif id==13321 then 
		Out_Prize[1][12687]=200  ---寒冰烈炎_木
		Out_Prize[1][12692]=47  ---少阳初现_木
		Out_Prize[1][12697]=63  ---破魔秘法_木
		Out_Prize[1][12702]=27  ---天眷有道_木
		Out_Prize[1][12707]=26  ---驱物法诀_木
		Out_Prize[1][12712]=31  ---护体罡气_木
		Out_Prize[1][12718]=53  ---炼神还虚_木
		Out_Prize[1][12723]=42  ---冰心玉阙_木
		Out_Prize[1][12728]=28  ---仙元护体_木
		Out_Prize[1][12733]=31  ---先天罡气_木
		Out_Prize[1][12738]=47  ---雷神降世_木
		Out_Prize[1][12743]=200  ---风剑之芒_木
		Out_Prize[1][12748]=170  ---归元真解_木
		Out_Prize[1][12753]=63  ---破魔怒意_木
		Out_Prize[1][12758]=63  ---怒剑心劫_木
		Out_Prize[1][12763]=37  ---邪剑星羽_木
		Out_Prize[1][12768]=47  ---天诛真诀_木
		Out_Prize[1][12773]=32  ---斩龙奥义_木
		Out_Prize[1][12778]=27  ---玄天星芒_木
		Out_Prize[1][12783]=170  ---剑元之聚_木
		Out_Prize[1][12789]=29  ---气贯长虹_木
		Out_Prize[1][12794]=30  ---玄冰圣护_木
		Out_Prize[1][12799]=29  ---玄冰劲气_木
		Out_Prize[1][12804]=23  ---返朴归真_木
		Out_Prize[1][12809]=23  ---狂雷天怒_木
		Out_Prize[1][12814]=38  ---冰域天机_木
		Out_Prize[1][12819]=36  ---盛冰之寒_木
		Out_Prize[1][12824]=72  ---霜寒化境_木
		Out_Prize[1][12829]=63  ---雷云奇变_木
		Out_Prize[1][12834]=63  ---五雷交轰_木
		Out_Prize[1][12839]=25  ---天雷狂啸_木
		Out_Prize[1][12844]=29  ---群雷裂空_木
		Out_Prize[1][12849]=34  ---天地无用_木

	elseif id==13322 then 
		Out_Prize[1][12688]=200  ---寒冰烈炎_水
		Out_Prize[1][12693]=47  ---少阳初现_水
		Out_Prize[1][12698]=63  ---破魔秘法_水
		Out_Prize[1][12703]=27  ---天眷有道_水
		Out_Prize[1][12708]=26  ---驱物法诀_水
		Out_Prize[1][12713]=31  ---护体罡气_水
		Out_Prize[1][12719]=53  ---炼神还虚_水
		Out_Prize[1][12724]=42  ---冰心玉阙_水
		Out_Prize[1][12729]=28  ---仙元护体_水
		Out_Prize[1][12734]=31  ---先天罡气_水
		Out_Prize[1][12739]=47  ---雷神降世_水
		Out_Prize[1][12744]=200  ---风剑之芒_水
		Out_Prize[1][12749]=170  ---归元真解_水
		Out_Prize[1][12754]=63  ---破魔怒意_水
		Out_Prize[1][12759]=63  ---怒剑心劫_水
		Out_Prize[1][12764]=37  ---邪剑星羽_水
		Out_Prize[1][12769]=47  ---天诛真诀_水
		Out_Prize[1][12774]=32  ---斩龙奥义_水
		Out_Prize[1][12779]=27  ---玄天星芒_水
		Out_Prize[1][12784]=170  ---剑元之聚_水
		Out_Prize[1][12790]=29  ---气贯长虹_水
		Out_Prize[1][12795]=30  ---玄冰圣护_水
		Out_Prize[1][12800]=29  ---玄冰劲气_水
		Out_Prize[1][12805]=23  ---返朴归真_水
		Out_Prize[1][12810]=23  ---狂雷天怒_水
		Out_Prize[1][12815]=38  ---冰域天机_水
		Out_Prize[1][12820]=36  ---盛冰之寒_水
		Out_Prize[1][12825]=72  ---霜寒化境_水
		Out_Prize[1][12830]=63  ---雷云奇变_水
		Out_Prize[1][12835]=63  ---五雷交轰_水
		Out_Prize[1][12840]=25  ---天雷狂啸_水
		Out_Prize[1][12845]=29  ---群雷裂空_水
		Out_Prize[1][12850]=34  ---天地无用_水

	elseif id==13323 then 
		Out_Prize[1][12689]=200  ---寒冰烈炎_火
		Out_Prize[1][12694]=47  ---少阳初现_火
		Out_Prize[1][12699]=63  ---破魔秘法_火
		Out_Prize[1][12704]=27  ---天眷有道_火
		Out_Prize[1][12709]=26  ---驱物法诀_火
		Out_Prize[1][12714]=31  ---护体罡气_火
		Out_Prize[1][12720]=53  ---炼神还虚_火
		Out_Prize[1][12725]=42  ---冰心玉阙_火
		Out_Prize[1][12730]=28  ---仙元护体_火
		Out_Prize[1][12735]=31  ---先天罡气_火
		Out_Prize[1][12740]=47  ---雷神降世_火
		Out_Prize[1][12745]=200  ---风剑之芒_火
		Out_Prize[1][12750]=170  ---归元真解_火
		Out_Prize[1][12755]=63  ---破魔怒意_火
		Out_Prize[1][12760]=63  ---怒剑心劫_火
		Out_Prize[1][12765]=37  ---邪剑星羽_火
		Out_Prize[1][12770]=47  ---天诛真诀_火
		Out_Prize[1][12775]=32  ---斩龙奥义_火
		Out_Prize[1][12780]=27  ---玄天星芒_火
		Out_Prize[1][12785]=170  ---剑元之聚_火
		Out_Prize[1][12791]=29  ---气贯长虹_火
		Out_Prize[1][12796]=30  ---玄冰圣护_火
		Out_Prize[1][12801]=29  ---玄冰劲气_火
		Out_Prize[1][12806]=23  ---返朴归真_火
		Out_Prize[1][12811]=23  ---狂雷天怒_火
		Out_Prize[1][12816]=38  ---冰域天机_火
		Out_Prize[1][12821]=36  ---盛冰之寒_火
		Out_Prize[1][12826]=72  ---霜寒化境_火
		Out_Prize[1][12831]=63  ---雷云奇变_火
		Out_Prize[1][12836]=63  ---五雷交轰_火
		Out_Prize[1][12841]=25  ---天雷狂啸_火
		Out_Prize[1][12846]=29  ---群雷裂空_火
		Out_Prize[1][12851]=34  ---天地无用_火

	elseif id==13324 then 
		Out_Prize[1][12690]=200  ---寒冰烈炎_土
		Out_Prize[1][12695]=47  ---少阳初现_土
		Out_Prize[1][12700]=63  ---破魔秘法_土
		Out_Prize[1][12705]=27  ---天眷有道_土
		Out_Prize[1][12710]=26  ---驱物法诀_土
		Out_Prize[1][12715]=31  ---护体罡气_土
		Out_Prize[1][12721]=53  ---炼神还虚_土
		Out_Prize[1][12726]=42  ---冰心玉阙_土
		Out_Prize[1][12731]=28  ---仙元护体_土
		Out_Prize[1][12736]=31  ---先天罡气_土
		Out_Prize[1][12741]=47  ---雷神降世_土
		Out_Prize[1][12746]=200  ---风剑之芒_土
		Out_Prize[1][12751]=170  ---归元真解_土
		Out_Prize[1][12756]=63  ---破魔怒意_土
		Out_Prize[1][12761]=63  ---怒剑心劫_土
		Out_Prize[1][12766]=37  ---邪剑星羽_土
		Out_Prize[1][12771]=47  ---天诛真诀_土
		Out_Prize[1][12776]=32  ---斩龙奥义_土
		Out_Prize[1][12781]=27  ---玄天星芒_土
		Out_Prize[1][12786]=170  ---剑元之聚_土
		Out_Prize[1][12792]=29  ---气贯长虹_土
		Out_Prize[1][12797]=30  ---玄冰圣护_土
		Out_Prize[1][12802]=29  ---玄冰劲气_土
		Out_Prize[1][12807]=23  ---返朴归真_土
		Out_Prize[1][12812]=23  ---狂雷天怒_土
		Out_Prize[1][12817]=38  ---冰域天机_土
		Out_Prize[1][12822]=36  ---盛冰之寒_土
		Out_Prize[1][12827]=72  ---霜寒化境_土
		Out_Prize[1][12832]=63  ---雷云奇变_土
		Out_Prize[1][12837]=63  ---五雷交轰_土
		Out_Prize[1][12842]=25  ---天雷狂啸_土
		Out_Prize[1][12847]=29  ---群雷裂空_土
		Out_Prize[1][12852]=34  ---天地无用_土

	elseif id==13325 then 
		Out_Prize[1][12072]=200  ---狂魔_金
		Out_Prize[1][12073]=30  ---火舞_金
		Out_Prize[1][12074]=30  ---戾气_金
		Out_Prize[1][12075]=47  ---震慑_金
		Out_Prize[1][12076]=46  ---破魂_金
		Out_Prize[1][12077]=31  ---无间_金
		Out_Prize[1][12078]=38  ---雷鸣_金
		Out_Prize[1][12079]=40  ---狂怒_金
		Out_Prize[1][12080]=26  ---灭神_金
		Out_Prize[1][12081]=30  ---天谴_金
		Out_Prize[1][12082]=47  ---亢龙_金
		Out_Prize[1][12083]=33  ---炽热_金
		Out_Prize[1][12084]=42  ---业火_金
		Out_Prize[1][12085]=30  ---信念_金
		Out_Prize[1][12086]=33  ---战意_金
		Out_Prize[1][12087]=30  ---天煞_金
		Out_Prize[1][12088]=40  ---魔心_金
		Out_Prize[1][12089]=27  ---咒怨_金
		Out_Prize[1][12090]=30  ---天佑_金
		Out_Prize[1][12091]=26  ---血咒_金
		Out_Prize[1][12092]=26  ---驱物_金
		Out_Prize[1][12093]=26  ---妄念_金
		Out_Prize[1][12094]=53  ---冰寒_金
		Out_Prize[1][12095]=38  ---噬血_金
		Out_Prize[1][12096]=29  ---梦魇_金
		Out_Prize[1][12097]=31  ---孤注_金
		Out_Prize[1][12098]=27  ---末日_金
		Out_Prize[1][12099]=53  ---冰锋_金
		Out_Prize[1][12100]=92  ---沉舟_金
		Out_Prize[1][12101]=47  ---魔煞_金
		Out_Prize[1][12102]=30  ---破空_金
		Out_Prize[1][12103]=35  ---虚无_金
		Out_Prize[1][12104]=26  ---怒龙_金

	elseif id==13326 then 
		Out_Prize[1][12128]=200  ---狂魔_木
		Out_Prize[1][12130]=30  ---火舞_木
		Out_Prize[1][12131]=30  ---戾气_木
		Out_Prize[1][12133]=47  ---震慑_木
		Out_Prize[1][12135]=46  ---破魂_木
		Out_Prize[1][12136]=31  ---无间_木
		Out_Prize[1][12139]=38  ---雷鸣_木
		Out_Prize[1][12141]=40  ---狂怒_木
		Out_Prize[1][12144]=26  ---灭神_木
		Out_Prize[1][12147]=30  ---天谴_木
		Out_Prize[1][12148]=47  ---亢龙_木
		Out_Prize[1][12149]=33  ---炽热_木
		Out_Prize[1][12151]=42  ---业火_木
		Out_Prize[1][12153]=30  ---信念_木
		Out_Prize[1][12155]=33  ---战意_木
		Out_Prize[1][12157]=30  ---天煞_木
		Out_Prize[1][12159]=40  ---魔心_木
		Out_Prize[1][12161]=27  ---咒怨_木
		Out_Prize[1][12164]=30  ---天佑_木
		Out_Prize[1][12166]=26  ---血咒_木
		Out_Prize[1][12167]=26  ---驱物_木
		Out_Prize[1][12169]=26  ---妄念_木
		Out_Prize[1][12171]=53  ---冰寒_木
		Out_Prize[1][12173]=38  ---噬血_木
		Out_Prize[1][12175]=29  ---梦魇_木
		Out_Prize[1][12177]=31  ---孤注_木
		Out_Prize[1][12179]=27  ---末日_木
		Out_Prize[1][12181]=53  ---冰锋_木
		Out_Prize[1][12182]=92  ---沉舟_木
		Out_Prize[1][12184]=47  ---魔煞_木
		Out_Prize[1][12185]=30  ---破空_木
		Out_Prize[1][12187]=35  ---虚无_木
		Out_Prize[1][12188]=26  ---怒龙_木

	elseif id==13327 then 
		Out_Prize[1][12228]=200  ---狂魔_水
		Out_Prize[1][12230]=30  ---火舞_水
		Out_Prize[1][12232]=30  ---戾气_水
		Out_Prize[1][12234]=47  ---震慑_水
		Out_Prize[1][12236]=46  ---破魂_水
		Out_Prize[1][12238]=31  ---无间_水
		Out_Prize[1][12242]=38  ---雷鸣_水
		Out_Prize[1][12243]=40  ---狂怒_水
		Out_Prize[1][12244]=26  ---灭神_水
		Out_Prize[1][12245]=30  ---天谴_水
		Out_Prize[1][12247]=47  ---亢龙_水
		Out_Prize[1][12248]=33  ---炽热_水
		Out_Prize[1][12250]=42  ---业火_水
		Out_Prize[1][12252]=30  ---信念_水
		Out_Prize[1][12254]=33  ---战意_水
		Out_Prize[1][12257]=30  ---天煞_水
		Out_Prize[1][12259]=40  ---魔心_水
		Out_Prize[1][12260]=27  ---咒怨_水
		Out_Prize[1][12261]=30  ---天佑_水
		Out_Prize[1][12262]=26  ---血咒_水
		Out_Prize[1][12263]=26  ---驱物_水
		Out_Prize[1][12264]=26  ---妄念_水
		Out_Prize[1][12265]=53  ---冰寒_水
		Out_Prize[1][12266]=38  ---噬血_水
		Out_Prize[1][12267]=29  ---梦魇_水
		Out_Prize[1][12268]=31  ---孤注_水
		Out_Prize[1][12269]=27  ---末日_水
		Out_Prize[1][12270]=53  ---冰锋_水
		Out_Prize[1][12271]=92  ---沉舟_水
		Out_Prize[1][12272]=47  ---魔煞_水
		Out_Prize[1][12273]=30  ---破空_水
		Out_Prize[1][12274]=35  ---虚无_水
		Out_Prize[1][12275]=26  ---怒龙_水


	elseif id==13328 then 
		Out_Prize[1][12284]=200  ---狂魔_火
		Out_Prize[1][12285]=30  ---火舞_火
		Out_Prize[1][12286]=30  ---戾气_火
		Out_Prize[1][12287]=47  ---震慑_火
		Out_Prize[1][12288]=46  ---破魂_火
		Out_Prize[1][12289]=31  ---无间_火
		Out_Prize[1][12290]=38  ---雷鸣_火
		Out_Prize[1][12291]=40  ---狂怒_火
		Out_Prize[1][12292]=26  ---灭神_火
		Out_Prize[1][12293]=30  ---天谴_火
		Out_Prize[1][12294]=47  ---亢龙_火
		Out_Prize[1][12295]=33  ---炽热_火
		Out_Prize[1][12296]=42  ---业火_火
		Out_Prize[1][12298]=30  ---信念_火
		Out_Prize[1][12300]=33  ---战意_火
		Out_Prize[1][12302]=30  ---天煞_火
		Out_Prize[1][12304]=40  ---魔心_火
		Out_Prize[1][12306]=27  ---咒怨_火
		Out_Prize[1][12308]=30  ---天佑_火
		Out_Prize[1][12310]=26  ---血咒_火
		Out_Prize[1][12312]=26  ---驱物_火
		Out_Prize[1][12314]=26  ---妄念_火
		Out_Prize[1][12316]=53  ---冰寒_火
		Out_Prize[1][12318]=38  ---噬血_火
		Out_Prize[1][12322]=29  ---梦魇_火
		Out_Prize[1][12323]=31  ---孤注_火
		Out_Prize[1][12325]=27  ---末日_火
		Out_Prize[1][12327]=53  ---冰锋_火
		Out_Prize[1][12329]=92  ---沉舟_火
		Out_Prize[1][12330]=47  ---魔煞_火
		Out_Prize[1][12333]=30  ---破空_火
		Out_Prize[1][12335]=35  ---虚无_火
		Out_Prize[1][12337]=26  ---怒龙_火


	elseif id==13329 then 
		Out_Prize[1][12346]=200  ---狂魔_土
		Out_Prize[1][12347]=30  ---火舞_土
		Out_Prize[1][12348]=30  ---戾气_土
		Out_Prize[1][12349]=47  ---震慑_土
		Out_Prize[1][12350]=46  ---破魂_土
		Out_Prize[1][12351]=31  ---无间_土
		Out_Prize[1][12352]=38  ---雷鸣_土
		Out_Prize[1][12353]=40  ---狂怒_土
		Out_Prize[1][12354]=26  ---灭神_土
		Out_Prize[1][12355]=30  ---天谴_土
		Out_Prize[1][12356]=47  ---亢龙_土
		Out_Prize[1][12357]=33  ---炽热_土
		Out_Prize[1][12358]=42  ---业火_土
		Out_Prize[1][12359]=30  ---信念_土
		Out_Prize[1][12360]=33  ---战意_土
		Out_Prize[1][12361]=30  ---天煞_土
		Out_Prize[1][12362]=40  ---魔心_土
		Out_Prize[1][12363]=27  ---咒怨_土
		Out_Prize[1][12364]=30  ---天佑_土
		Out_Prize[1][12365]=26  ---血咒_土
		Out_Prize[1][12366]=26  ---驱物_土
		Out_Prize[1][12367]=26  ---妄念_土
		Out_Prize[1][12368]=53  ---冰寒_土
		Out_Prize[1][12369]=38  ---噬血_土
		Out_Prize[1][12370]=29  ---梦魇_土
		Out_Prize[1][12371]=31  ---孤注_土
		Out_Prize[1][12372]=27  ---末日_土
		Out_Prize[1][12373]=53  ---冰锋_土
		Out_Prize[1][12374]=92  ---沉舟_土
		Out_Prize[1][12375]=47  ---魔煞_土
		Out_Prize[1][12376]=30  ---破空_土
		Out_Prize[1][12377]=35  ---虚无_土
		Out_Prize[1][12378]=26  ---怒龙_土


	elseif id==13330 then 
		Out_Prize[1][12107]=92  ---天花乱坠_金
		Out_Prize[1][12109]=29  ---空即是色_金
		Out_Prize[1][12111]=31  ---袈裟蔽天_金
		Out_Prize[1][12115]=200  ---降魔真言_金
		Out_Prize[1][12117]=92  ---束心法咒_金
		Out_Prize[1][12118]=170  ---梵经心语_金
		Out_Prize[1][12119]=28  ---固本培元_金
		Out_Prize[1][12120]=47  ---再造祷言_金
		Out_Prize[1][12121]=43  ---悬壶济世_金
		Out_Prize[1][12122]=35  ---法螺常念_金
		Out_Prize[1][12123]=27  ---光明之颂_金
		Out_Prize[1][12124]=35  ---一语道破_金
		Out_Prize[1][12125]=34  ---度尽劫波_金
		Out_Prize[1][12126]=29  ---色即是空_金
		Out_Prize[1][12127]=29  ---空冥禅念_金
		Out_Prize[1][12129]=28  ---顿悟之偈_金
		Out_Prize[1][12132]=26  ---天道循环_金
		Out_Prize[1][12134]=26  ---驭物神通_金
		Out_Prize[1][12137]=92  ---往生夙愿_金
		Out_Prize[1][12138]=28  ---了世尘缘_金
		Out_Prize[1][12140]=53  ---极乐颂泽_金
		Out_Prize[1][12142]=34  ---灵魂绽放_金
		Out_Prize[1][12143]=27  ---无尽苦海_金
		Out_Prize[1][12145]=35  ---相续不空_金
		Out_Prize[1][12146]=35  ---乾坤正气_金
		Out_Prize[1][12150]=29  ---净世佛心_金
		Out_Prize[1][12152]=29  ---金刚破魔_金
		Out_Prize[1][12154]=31  ---伏魔真诀_金
		Out_Prize[1][12156]=32  ---极乐禅言_金
		Out_Prize[1][12158]=30  ---无常轮渡_金
		Out_Prize[1][12160]=55  ---九转之易_金
		Out_Prize[1][12162]=34  ---慈悲为怀_金
		Out_Prize[1][12163]=30  ---神魔妄念_金

	elseif id==13331 then 
		Out_Prize[1][12183]=92  ---天花乱坠_木
		Out_Prize[1][12186]=29  ---空即是色_木
		Out_Prize[1][12189]=31  ---袈裟蔽天_木
		Out_Prize[1][12192]=200  ---降魔真言_木
		Out_Prize[1][12194]=92  ---束心法咒_木
		Out_Prize[1][12197]=170  ---梵经心语_木
		Out_Prize[1][12199]=28  ---固本培元_木
		Out_Prize[1][12202]=47  ---再造祷言_木
		Out_Prize[1][12203]=43  ---悬壶济世_木
		Out_Prize[1][12204]=35  ---法螺常念_木
		Out_Prize[1][12205]=27  ---光明之颂_木
		Out_Prize[1][12206]=35  ---一语道破_木
		Out_Prize[1][12207]=34  ---度尽劫波_木
		Out_Prize[1][12208]=29  ---色即是空_木
		Out_Prize[1][12209]=29  ---空冥禅念_木
		Out_Prize[1][12210]=28  ---顿悟之偈_木
		Out_Prize[1][12211]=26  ---天道循环_木
		Out_Prize[1][12212]=26  ---驭物神通_木
		Out_Prize[1][12213]=92  ---往生夙愿_木
		Out_Prize[1][12214]=28  ---了世尘缘_木
		Out_Prize[1][12215]=53  ---极乐颂泽_木
		Out_Prize[1][12216]=34  ---灵魂绽放_木
		Out_Prize[1][12217]=27  ---无尽苦海_木
		Out_Prize[1][12218]=35  ---相续不空_木
		Out_Prize[1][12219]=35  ---乾坤正气_木
		Out_Prize[1][12220]=29  ---净世佛心_木
		Out_Prize[1][12221]=29  ---金刚破魔_木
		Out_Prize[1][12222]=31  ---伏魔真诀_木
		Out_Prize[1][12223]=32  ---极乐禅言_木
		Out_Prize[1][12224]=30  ---无常轮渡_木
		Out_Prize[1][12225]=55  ---九转之易_木
		Out_Prize[1][12226]=34  ---慈悲为怀_木
		Out_Prize[1][12227]=30  ---神魔妄念_木

	elseif id==13332 then
		Out_Prize[1][12246]=92  ---天花乱坠_水
		Out_Prize[1][12249]=29  ---空即是色_水
		Out_Prize[1][12251]=31  ---袈裟蔽天_水
		Out_Prize[1][12253]=200  ---降魔真言_水
		Out_Prize[1][12255]=92  ---束心法咒_水
		Out_Prize[1][12256]=170  ---梵经心语_水
		Out_Prize[1][12258]=28  ---固本培元_水
		Out_Prize[1][12297]=47  ---再造祷言_水
		Out_Prize[1][12299]=43  ---悬壶济世_水
		Out_Prize[1][12301]=35  ---法螺常念_水
		Out_Prize[1][12303]=27  ---光明之颂_水
		Out_Prize[1][12305]=35  ---一语道破_水
		Out_Prize[1][12307]=34  ---度尽劫波_水
		Out_Prize[1][12309]=29  ---色即是空_水
		Out_Prize[1][12311]=29  ---空冥禅念_水
		Out_Prize[1][12313]=28  ---顿悟之偈_水
		Out_Prize[1][12315]=26  ---天道循环_水
		Out_Prize[1][12317]=26  ---驭物神通_水
		Out_Prize[1][12319]=92  ---往生夙愿_水
		Out_Prize[1][12320]=28  ---了世尘缘_水
		Out_Prize[1][12321]=53  ---极乐颂泽_水
		Out_Prize[1][12324]=34  ---灵魂绽放_水
		Out_Prize[1][12326]=27  ---无尽苦海_水
		Out_Prize[1][12328]=35  ---相续不空_水
		Out_Prize[1][12331]=35  ---乾坤正气_水
		Out_Prize[1][12332]=29  ---净世佛心_水
		Out_Prize[1][12334]=29  ---金刚破魔_水
		Out_Prize[1][12336]=31  ---伏魔真诀_水
		Out_Prize[1][12387]=32  ---极乐禅言_水
		Out_Prize[1][12388]=30  ---无常轮渡_水
		Out_Prize[1][12389]=55  ---九转之易_水
		Out_Prize[1][12390]=34  ---慈悲为怀_水
		Out_Prize[1][12391]=30  ---神魔妄念_水

 
	elseif id==13333 then 
		Out_Prize[1][12400]=92  ---天花乱坠_火
		Out_Prize[1][12401]=29  ---空即是色_火
		Out_Prize[1][12402]=31  ---袈裟蔽天_火
		Out_Prize[1][12403]=200  ---降魔真言_火
		Out_Prize[1][12404]=92  ---束心法咒_火
		Out_Prize[1][12405]=170  ---梵经心语_火
		Out_Prize[1][12406]=28  ---固本培元_火
		Out_Prize[1][12407]=47  ---再造祷言_火
		Out_Prize[1][12408]=43  ---悬壶济世_火
		Out_Prize[1][12409]=35  ---法螺常念_火
		Out_Prize[1][12410]=27  ---光明之颂_火
		Out_Prize[1][12411]=35  ---一语道破_火
		Out_Prize[1][12412]=34  ---度尽劫波_火
		Out_Prize[1][12413]=29  ---色即是空_火
		Out_Prize[1][12414]=29  ---空冥禅念_火
		Out_Prize[1][12415]=28  ---顿悟之偈_火
		Out_Prize[1][12416]=26  ---天道循环_火
		Out_Prize[1][12417]=26  ---驭物神通_火
		Out_Prize[1][12418]=92  ---往生夙愿_火
		Out_Prize[1][12419]=28  ---了世尘缘_火
		Out_Prize[1][12420]=53  ---极乐颂泽_火
		Out_Prize[1][12422]=34  ---灵魂绽放_火
		Out_Prize[1][12450]=27  ---无尽苦海_火
		Out_Prize[1][12453]=35  ---相续不空_火
		Out_Prize[1][12455]=35  ---乾坤正气_火
		Out_Prize[1][12457]=29  ---净世佛心_火
		Out_Prize[1][12460]=29  ---金刚破魔_火
		Out_Prize[1][12463]=31  ---伏魔真诀_火
		Out_Prize[1][12465]=32  ---极乐禅言_火
		Out_Prize[1][12466]=30  ---无常轮渡_火
		Out_Prize[1][12468]=55  ---九转之易_火
		Out_Prize[1][12470]=34  ---慈悲为怀_火
		Out_Prize[1][12473]=30  ---神魔妄念_火


	elseif id==13334 then 
		Out_Prize[1][12503]=92  ---天花乱坠_土
		Out_Prize[1][13235]=29  ---空即是色_土
		Out_Prize[1][12505]=31  ---袈裟蔽天_土
		Out_Prize[1][12507]=200  ---降魔真言_土
		Out_Prize[1][12509]=92  ---束心法咒_土
		Out_Prize[1][12512]=170  ---梵经心语_土
		Out_Prize[1][12514]=28  ---固本培元_土
		Out_Prize[1][12516]=47  ---再造祷言_土
		Out_Prize[1][12518]=43  ---悬壶济世_土
		Out_Prize[1][12519]=35  ---法螺常念_土
		Out_Prize[1][12520]=27  ---光明之颂_土
		Out_Prize[1][12521]=35  ---一语道破_土
		Out_Prize[1][12522]=34  ---度尽劫波_土
		Out_Prize[1][12523]=29  ---色即是空_土
		Out_Prize[1][12524]=29  ---空冥禅念_土
		Out_Prize[1][12525]=28  ---顿悟之偈_土
		Out_Prize[1][12526]=26  ---天道循环_土
		Out_Prize[1][12527]=26  ---驭物神通_土
		Out_Prize[1][12528]=92  ---往生夙愿_土
		Out_Prize[1][12529]=28  ---了世尘缘_土
		Out_Prize[1][12530]=53  ---极乐颂泽_土
		Out_Prize[1][12531]=34  ---灵魂绽放_土
		Out_Prize[1][12532]=27  ---无尽苦海_土
		Out_Prize[1][12533]=35  ---相续不空_土
		Out_Prize[1][12534]=35  ---乾坤正气_土
		Out_Prize[1][12535]=29  ---净世佛心_土
		Out_Prize[1][12536]=29  ---金刚破魔_土
		Out_Prize[1][12537]=31  ---伏魔真诀_土
		Out_Prize[1][12538]=32  ---极乐禅言_土
		Out_Prize[1][12539]=30  ---无常轮渡_土
		Out_Prize[1][12540]=55  ---九转之易_土
		Out_Prize[1][12541]=34  ---慈悲为怀_土
		Out_Prize[1][12542]=30  ---神魔妄念_土


	elseif id==13335 then
		Out_Prize[1][12421]=200  ---相济_金
		Out_Prize[1][12423]=63  ---识破_金
		Out_Prize[1][12424]=35  ---魅心_金
		Out_Prize[1][12437]=27  ---荡漾_金
		Out_Prize[1][12442]=92  ---击天_金
		Out_Prize[1][12447]=26  ---情动_金
		Out_Prize[1][12454]=34  ---幻境_金
		Out_Prize[1][12462]=29  ---梦乡_金
		Out_Prize[1][12472]=29  ---风月_金
		Out_Prize[1][12478]=37  ---不逾_金
		Out_Prize[1][12485]=28  ---绝尘_金
		Out_Prize[1][12493]=34  ---残香_金
		Out_Prize[1][12500]=42  ---翩飞_金
		Out_Prize[1][12510]=38  ---约定_金
		Out_Prize[1][12551]=38  ---星月_金
		Out_Prize[1][12556]=92  ---幽兰_金
		Out_Prize[1][12561]=34  ---迷梦_金
		Out_Prize[1][12566]=34  ---心愿_金
		Out_Prize[1][12571]=22  ---情惑_金
		Out_Prize[1][12576]=72  ---心门_金
		Out_Prize[1][12581]=42  ---亦尘_金
		Out_Prize[1][12586]=34  ---思恋_金
		Out_Prize[1][12591]=31  ---迷失_金
		Out_Prize[1][12596]=47  ---花间_金
		Out_Prize[1][12601]=28  ---惊鸿_金
		Out_Prize[1][12606]=28  ---风物_金
		Out_Prize[1][12611]=47  ---悱恻_金
		Out_Prize[1][12616]=42  ---化羽_金
		Out_Prize[1][12621]=34  ---天伤_金
		Out_Prize[1][12626]=26  ---黯然_金
		Out_Prize[1][12631]=200  ---驭宝_金
		Out_Prize[1][12632]=27  ---绝情_金
		Out_Prize[1][12641]=37  ---天籁_金

 	elseif id==13336 then 
 		Out_Prize[1][12425]=200  ---相济_木
		Out_Prize[1][12429]=63  ---识破_木
		Out_Prize[1][12433]=35  ---魅心_木
		Out_Prize[1][12438]=27  ---荡漾_木
		Out_Prize[1][12443]=92  ---击天_木
		Out_Prize[1][12448]=26  ---情动_木
		Out_Prize[1][12456]=34  ---幻境_木
		Out_Prize[1][12464]=29  ---梦乡_木
		Out_Prize[1][12474]=29  ---风月_木
		Out_Prize[1][12479]=37  ---不逾_木
		Out_Prize[1][12488]=28  ---绝尘_木
		Out_Prize[1][12494]=34  ---残香_木
		Out_Prize[1][12502]=42  ---翩飞_木
		Out_Prize[1][12511]=38  ---约定_木
		Out_Prize[1][12552]=38  ---星月_木
		Out_Prize[1][12557]=92  ---幽兰_木
		Out_Prize[1][12562]=34  ---迷梦_木
		Out_Prize[1][12567]=34  ---心愿_木
		Out_Prize[1][12572]=22  ---情惑_木
		Out_Prize[1][12577]=72  ---心门_木
		Out_Prize[1][12582]=42  ---亦尘_木
		Out_Prize[1][12587]=34  ---思恋_木
		Out_Prize[1][12592]=31  ---迷失_木
		Out_Prize[1][12597]=47  ---花间_木
		Out_Prize[1][12602]=28  ---惊鸿_木
		Out_Prize[1][12607]=28  ---风物_木
		Out_Prize[1][12612]=47  ---悱恻_木
		Out_Prize[1][12617]=42  ---化羽_木
		Out_Prize[1][12622]=34  ---天伤_木
		Out_Prize[1][12627]=26  ---黯然_木
		Out_Prize[1][12633]=200  ---驭宝_木
		Out_Prize[1][12637]=27  ---绝情_木
		Out_Prize[1][12642]=37  ---天籁_木

	elseif id==13337 then
		Out_Prize[1][12426]=200  ---相济_水
		Out_Prize[1][12430]=63  ---识破_水
		Out_Prize[1][12434]=35  ---魅心_水
		Out_Prize[1][12439]=27  ---荡漾_水
		Out_Prize[1][12444]=92  ---击天_水
		Out_Prize[1][12449]=26  ---情动_水
		Out_Prize[1][12458]=34  ---幻境_水
		Out_Prize[1][12471]=29  ---梦乡_水
		Out_Prize[1][12475]=29  ---风月_水
		Out_Prize[1][12480]=37  ---不逾_水
		Out_Prize[1][12490]=28  ---绝尘_水
		Out_Prize[1][12495]=34  ---残香_水
		Out_Prize[1][12504]=42  ---翩飞_水
		Out_Prize[1][12513]=38  ---约定_水
		Out_Prize[1][12553]=38  ---星月_水
		Out_Prize[1][12558]=92  ---幽兰_水
		Out_Prize[1][12563]=34  ---迷梦_水
		Out_Prize[1][12568]=34  ---心愿_水
		Out_Prize[1][12573]=22  ---情惑_水
		Out_Prize[1][12578]=72  ---心门_水
		Out_Prize[1][12583]=42  ---亦尘_水
		Out_Prize[1][12588]=34  ---思恋_水
		Out_Prize[1][12593]=31  ---迷失_水
		Out_Prize[1][12598]=47  ---花间_水
		Out_Prize[1][12603]=28  ---惊鸿_水
		Out_Prize[1][12608]=28  ---风物_水
		Out_Prize[1][12613]=47  ---悱恻_水
		Out_Prize[1][12618]=42  ---化羽_水
		Out_Prize[1][12623]=34  ---天伤_水
		Out_Prize[1][12628]=26  ---黯然_水
		Out_Prize[1][12634]=200  ---驭宝_水
		Out_Prize[1][12638]=27  ---绝情_水
		Out_Prize[1][12643]=37  ---天籁_水

 	elseif id==13338 then 
 		Out_Prize[1][12427]=200  ---相济_火
		Out_Prize[1][12431]=63  ---识破_火
		Out_Prize[1][12435]=35  ---魅心_火
		Out_Prize[1][12440]=27  ---荡漾_火
		Out_Prize[1][12445]=92  ---击天_火
		Out_Prize[1][12451]=26  ---情动_火
		Out_Prize[1][12459]=34  ---幻境_火
		Out_Prize[1][12467]=29  ---梦乡_火
		Out_Prize[1][12476]=29  ---风月_火
		Out_Prize[1][12481]=37  ---不逾_火
		Out_Prize[1][12491]=28  ---绝尘_火
		Out_Prize[1][12496]=34  ---残香_火
		Out_Prize[1][12506]=42  ---翩飞_火
		Out_Prize[1][12515]=38  ---约定_火
		Out_Prize[1][12554]=38  ---星月_火
		Out_Prize[1][12559]=92  ---幽兰_火
		Out_Prize[1][12564]=34  ---迷梦_火
		Out_Prize[1][12569]=34  ---心愿_火
		Out_Prize[1][12574]=22  ---情惑_火
		Out_Prize[1][12579]=72  ---心门_火
		Out_Prize[1][12584]=42  ---亦尘_火
		Out_Prize[1][12589]=34  ---思恋_火
		Out_Prize[1][12594]=31  ---迷失_火
		Out_Prize[1][12599]=47  ---花间_火
		Out_Prize[1][12604]=28  ---惊鸿_火
		Out_Prize[1][12609]=28  ---风物_火
		Out_Prize[1][12614]=47  ---悱恻_火
		Out_Prize[1][12619]=42  ---化羽_火
		Out_Prize[1][12624]=34  ---天伤_火
		Out_Prize[1][12629]=26  ---黯然_火
		Out_Prize[1][12635]=200  ---驭宝_火
		Out_Prize[1][12639]=27  ---绝情_火
		Out_Prize[1][12644]=37  ---天籁_火
	
	elseif id==13339 then 
		Out_Prize[1][12428]=200  ---相济_土
		Out_Prize[1][12432]=63  ---识破_土
		Out_Prize[1][12436]=35  ---魅心_土
		Out_Prize[1][12441]=27  ---荡漾_土
		Out_Prize[1][12446]=92  ---击天_土
		Out_Prize[1][12452]=26  ---情动_土
		Out_Prize[1][12461]=34  ---幻境_土
		Out_Prize[1][12469]=29  ---梦乡_土
		Out_Prize[1][12477]=29  ---风月_土
		Out_Prize[1][12484]=37  ---不逾_土
		Out_Prize[1][12492]=28  ---绝尘_土
		Out_Prize[1][12497]=34  ---残香_土
		Out_Prize[1][12508]=42  ---翩飞_土
		Out_Prize[1][12517]=38  ---约定_土
		Out_Prize[1][12555]=38  ---星月_土
		Out_Prize[1][12560]=92  ---幽兰_土
		Out_Prize[1][12565]=34  ---迷梦_土
		Out_Prize[1][12570]=34  ---心愿_土
		Out_Prize[1][12575]=22  ---情惑_土
		Out_Prize[1][12580]=72  ---心门_土
		Out_Prize[1][12585]=42  ---亦尘_土
		Out_Prize[1][12590]=34  ---思恋_土
		Out_Prize[1][12595]=31  ---迷失_土
		Out_Prize[1][12600]=47  ---花间_土
		Out_Prize[1][12605]=28  ---惊鸿_土
		Out_Prize[1][12610]=28  ---风物_土
		Out_Prize[1][12615]=47  ---悱恻_土
		Out_Prize[1][12620]=42  ---化羽_土
		Out_Prize[1][12625]=34  ---天伤_土
		Out_Prize[1][12630]=26  ---黯然_土
		Out_Prize[1][12636]=200  ---驭宝_土
		Out_Prize[1][12640]=27  ---绝情_土
		Out_Prize[1][12645]=37  ---天籁_土
	
	elseif id==18752 then
		Out_Prize[1][18460]=120---恶鬼牙_金
		Out_Prize[1][18465]=60---沥血心_金
		Out_Prize[1][18470]=120---化骨毒_金
		Out_Prize[1][18475]=120---攻心咒_金
		Out_Prize[1][18480]=120---乱心诀_金
		Out_Prize[1][18485]=120---无影毒_金
		Out_Prize[1][18490]=120---黯然咒_金
		Out_Prize[1][18495]=120---幕天毒_金
		Out_Prize[1][18500]=120---地灵咒_金
		Out_Prize[1][18510]=60---孽龙毒_金
		Out_Prize[1][18520]=60---定魂诀_金
		Out_Prize[1][18535]=120---百毒炼_金
		Out_Prize[1][18540]=120---怒灵噬_金
		Out_Prize[1][18545]=120---天劫火_金
		Out_Prize[1][18550]=120---鬼阴风_金
		Out_Prize[1][18555]=60---挫骨印_金
		Out_Prize[1][18560]=60---真火咒_金
		Out_Prize[1][18565]=120---回魂祭_金
		Out_Prize[1][18570]=120---猛鬼啸_金
		Out_Prize[1][18575]=60---罗生门_金
		Out_Prize[1][18580]=15---邪血神_金
		Out_Prize[1][18585]=120---百鬼抄_金
		Out_Prize[1][18595]=120---截宗秘_金
		Out_Prize[1][18600]=120---邪灵蛊_金
		Out_Prize[1][18605]=120---应声蛊_金
		Out_Prize[1][18610]=120---鬼翼通_金
		Out_Prize[1][18615]=60---饲五毒_金
		Out_Prize[1][18620]=120---凝血咒_金
		Out_Prize[1][18625]=120---噬魂蛊_金
		Out_Prize[1][18635]=60---毒鳞刺_金
		Out_Prize[1][18640]=120---附蛊蛭_金
		Out_Prize[1][18650]=15---碎魂蛊_金
		Out_Prize[1][18655]=60---蛊乾坤_金
	elseif id==18753 then
		Out_Prize[1][18461]=120---恶鬼牙_木
		Out_Prize[1][18466]=60---沥血心_木
		Out_Prize[1][18471]=120---化骨毒_木
		Out_Prize[1][18476]=120---攻心咒_木
		Out_Prize[1][18481]=120---乱心诀_木
		Out_Prize[1][18486]=120---无影毒_木
		Out_Prize[1][18491]=120---黯然咒_木
		Out_Prize[1][18496]=120---幕天毒_木
		Out_Prize[1][18501]=120---地灵咒_木
		Out_Prize[1][18511]=60---孽龙毒_木
		Out_Prize[1][18521]=60---定魂诀_木
		Out_Prize[1][18536]=120---百毒炼_木
		Out_Prize[1][18541]=120---怒灵噬_木
		Out_Prize[1][18546]=120---天劫火_木
		Out_Prize[1][18551]=120---鬼阴风_木
		Out_Prize[1][18556]=60---挫骨印_木
		Out_Prize[1][18561]=60---真火咒_木
		Out_Prize[1][18566]=120---回魂祭_木
		Out_Prize[1][18571]=120---猛鬼啸_木
		Out_Prize[1][18576]=60---罗生门_木
		Out_Prize[1][18581]=15---邪血神_木
		Out_Prize[1][18586]=120---百鬼抄_木
		Out_Prize[1][18596]=120---截宗秘_木
		Out_Prize[1][18601]=120---邪灵蛊_木
		Out_Prize[1][18606]=120---应声蛊_木
		Out_Prize[1][18611]=120---鬼翼通_木
		Out_Prize[1][18616]=60---饲五毒_木
		Out_Prize[1][18621]=120---凝血咒_木
		Out_Prize[1][18626]=120---噬魂蛊_木
		Out_Prize[1][18636]=60---毒鳞刺_木
		Out_Prize[1][18641]=120---附蛊蛭_木
		Out_Prize[1][18651]=15---碎魂蛊_木
		Out_Prize[1][18656]=60---蛊乾坤_木
	elseif id==18754 then
		Out_Prize[1][18462]=120---恶鬼牙_水
		Out_Prize[1][18467]=60---沥血心_水
		Out_Prize[1][18472]=120---化骨毒_水
		Out_Prize[1][18477]=120---攻心咒_水
		Out_Prize[1][18482]=120---乱心诀_水
		Out_Prize[1][18487]=120---无影毒_水
		Out_Prize[1][18492]=120---黯然咒_水
		Out_Prize[1][18497]=120---幕天毒_水
		Out_Prize[1][18502]=120---地灵咒_水
		Out_Prize[1][18512]=60---孽龙毒_水
		Out_Prize[1][18522]=60---定魂诀_水
		Out_Prize[1][18537]=120---百毒炼_水
		Out_Prize[1][18542]=120---怒灵噬_水
		Out_Prize[1][18547]=120---天劫火_水
		Out_Prize[1][18552]=120---鬼阴风_水
		Out_Prize[1][18557]=60---挫骨印_水
		Out_Prize[1][18562]=60---真火咒_水
		Out_Prize[1][18567]=120---回魂祭_水
		Out_Prize[1][18572]=120---猛鬼啸_水
		Out_Prize[1][18577]=60---罗生门_水
		Out_Prize[1][18582]=15---邪血神_水
		Out_Prize[1][18587]=120---百鬼抄_水
		Out_Prize[1][18597]=120---截宗秘_水
		Out_Prize[1][18602]=120---邪灵蛊_水
		Out_Prize[1][18607]=120---应声蛊_水
		Out_Prize[1][18612]=120---鬼翼通_水
		Out_Prize[1][18617]=60---饲五毒_水
		Out_Prize[1][18622]=120---凝血咒_水
		Out_Prize[1][18627]=120---噬魂蛊_水
		Out_Prize[1][18637]=60---毒鳞刺_水
		Out_Prize[1][18642]=120---附蛊蛭_水
		Out_Prize[1][18652]=15---碎魂蛊_水
		Out_Prize[1][18657]=60---蛊乾坤_水
	elseif id==18755 then
		Out_Prize[1][18463]=120---恶鬼牙_火
		Out_Prize[1][18468]=60---沥血心_火
		Out_Prize[1][18473]=120---化骨毒_火
		Out_Prize[1][18478]=120---攻心咒_火
		Out_Prize[1][18483]=120---乱心诀_火
		Out_Prize[1][18488]=120---无影毒_火
		Out_Prize[1][18493]=120---黯然咒_火
		Out_Prize[1][18498]=120---幕天毒_火
		Out_Prize[1][18503]=120---地灵咒_火
		Out_Prize[1][18513]=60---孽龙毒_火
		Out_Prize[1][18523]=60---定魂诀_火
		Out_Prize[1][18538]=120---百毒炼_火
		Out_Prize[1][18543]=120---怒灵噬_火
		Out_Prize[1][18548]=120---天劫火_火
		Out_Prize[1][18553]=120---鬼阴风_火
		Out_Prize[1][18558]=60---挫骨印_火
		Out_Prize[1][18563]=60---真火咒_火
		Out_Prize[1][18568]=120---回魂祭_火
		Out_Prize[1][18573]=120---猛鬼啸_火
		Out_Prize[1][18578]=60---罗生门_火
		Out_Prize[1][18583]=15---邪血神_火
		Out_Prize[1][18588]=120---百鬼抄_火
		Out_Prize[1][18598]=120---截宗秘_火
		Out_Prize[1][18603]=120---邪灵蛊_火
		Out_Prize[1][18608]=120---应声蛊_火
		Out_Prize[1][18613]=120---鬼翼通_火
		Out_Prize[1][18618]=60---饲五毒_火
		Out_Prize[1][18623]=120---凝血咒_火
		Out_Prize[1][18628]=120---噬魂蛊_火
		Out_Prize[1][18638]=60---毒鳞刺_火
		Out_Prize[1][18643]=120---附蛊蛭_火
		Out_Prize[1][18653]=15---碎魂蛊_火
		Out_Prize[1][18658]=60---蛊乾坤_火

	elseif id==18756 then 
		Out_Prize[1][18464]=120---恶鬼牙_土
		Out_Prize[1][18469]=60---沥血心_土
		Out_Prize[1][18474]=120---化骨毒_土
		Out_Prize[1][18479]=120---攻心咒_土
		Out_Prize[1][18484]=120---乱心诀_土
		Out_Prize[1][18489]=120---无影毒_土
		Out_Prize[1][18494]=120---黯然咒_土
		Out_Prize[1][18499]=120---幕天毒_土
		Out_Prize[1][18504]=120---地灵咒_土
		Out_Prize[1][18514]=60---孽龙毒_土
		Out_Prize[1][18524]=60---定魂诀_土
		Out_Prize[1][18539]=120---百毒炼_土
		Out_Prize[1][18544]=120---怒灵噬_土
		Out_Prize[1][18549]=120---天劫火_土
		Out_Prize[1][18554]=120---鬼阴风_土
		Out_Prize[1][18559]=60---挫骨印_土
		Out_Prize[1][18564]=60---真火咒_土
		Out_Prize[1][18569]=120---回魂祭_土
		Out_Prize[1][18574]=120---猛鬼啸_土
		Out_Prize[1][18579]=60---罗生门_土
		Out_Prize[1][18584]=15---邪血神_土
		Out_Prize[1][18589]=120---百鬼抄_土
		Out_Prize[1][18599]=120---截宗秘_土
		Out_Prize[1][18604]=120---邪灵蛊_土
		Out_Prize[1][18609]=120---应声蛊_土
		Out_Prize[1][18614]=120---鬼翼通_土
		Out_Prize[1][18619]=60---饲五毒_土
		Out_Prize[1][18624]=120---凝血咒_土
		Out_Prize[1][18629]=120---噬魂蛊_土
		Out_Prize[1][18639]=60---毒鳞刺_土
		Out_Prize[1][18644]=120---附蛊蛭_土
		Out_Prize[1][18654]=15---碎魂蛊_土
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
function LotteryType13593Cashing(cur_list)		---(月光宝盒)
	---fmax_count为该彩票的有效位数
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
function LotteryType13905Cashing(cur_list)		---(狼图腾)
	---fmax_count为该彩票的有效位数
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
	
	Out_Prize[2][13904]=333 ---//高级天罗
	Out_Prize[2][13903]=667	---//高级建木
	
	Out_Prize[3][13901]=333	---//加Def药
	Out_Prize[3][13900]=667	---//加Atk药
	
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
function LotteryType15677Cashing(cur_list)		---(狮王之心)
	---fmax_count为该彩票的有效位数
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

	Out_Prize[3][15693]=140	---暗月兑换券
	Out_Prize[3][15694]=20	---赤日兑换券	
	
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
function LotteryType15866Cashing(cur_list)		---(雷光墨玉)
	---fmax_count为该彩票的有效位数
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
	
	Out_Prize[1][15865]=100		---快速黑豹
	
	Out_Prize[2][15868]=100		---落魂灯	

	Out_Prize[3][13343]=100		---聚宝盆
		
	Out_Prize[4][13901]=25		---加Def药
	Out_Prize[4][13900]=100		---加Atk药
		
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
function LotteryType16550Cashing(cur_list)		---(逐鹿御令)
	---fmax_count为该彩票的有效位数
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
	
	Out_Prize[1][16549]=100		---五色鹿
	
	Out_Prize[2][7931]=40			---结婚礼包男
	Out_Prize[2][7937]=60			---结婚礼包女

	Out_Prize[3][7939]=100		---天宝逆龙鳞
		
	Out_Prize[4][13901]=25		---加Def药
	Out_Prize[4][13900]=100		---加Atk药
		
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
function LotteryType18283Cashing(cur_list)		---(麒麟金尊)
	---fmax_count为该彩票的有效位数
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
	
	Out_Prize[1][18284]=100	---麒麟兑换券
	
	Out_Prize[2][13307]=80	---鬼面面具
	Out_Prize[2][13306]=20	---蝴蝶面饰	

	Out_Prize[3][15693]=50	---暗月兑换券
	Out_Prize[3][15694]=30	---赤日兑换券	
	
	Out_Prize[4][8079]=100	---飞天神符
		
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
function LotteryType18799Cashing(cur_list)		---(昆仑天晶)
	---fmax_count为该彩票的有效位数
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
	
	Out_Prize[1][18801]=100		---冰原雪熊
	
	Out_Prize[2][18797]=100		---法宝兑换券

	Out_Prize[3][15693]=140		---暗月兑换券
	Out_Prize[3][15694]=20		---赤日兑换券	
	
	Out_Prize[4][13901]=25		---加Def药
	Out_Prize[4][13900]=100		---加Atk药
		
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
function LotteryType18890Cashing(cur_list)		---(行天圣宝)
	---fmax_count为该彩票的有效位数
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
	
	Out_Prize[1][18891]=100		---飞剑兑换券
	
	Out_Prize[2][10872]=100		---五龙轮

	Out_Prize[3][18794]=100		---仙豆
	
	Out_Prize[4][8079]=100		---飞天神符
		
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
function LotteryTypeItemSeason1Cashing(cur_list,id)		---(金币回收彩票)
	---fmax_count为该彩票的有效位数
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
		Out_Prize[1][3449]={chance=100,num=1}---//魔噬
		Out_Prize[1][3459]={chance=100,num=1}---//圣护
		Out_Prize[1][3530]={chance=100,num=1}---//魔御
		Out_Prize[1][3540]={chance=100,num=1}---//魔吟
		Out_Prize[1][6151]={chance=100,num=1}---//裂云戒
		Out_Prize[1][6152]={chance=100,num=1}---//裂空戒
		Out_Prize[1][6153]={chance=100,num=1}---//裂魂戒
		Out_Prize[1][6154]={chance=100,num=1}---//荒雷戒
		Out_Prize[1][6155]={chance=100,num=1}---//凌云戒
		Out_Prize[1][6156]={chance=100,num=1}---//飞云戒
		Out_Prize[1][6157]={chance=100,num=1}---//雷云戒
		Out_Prize[1][6158]={chance=100,num=1}---//集英戒
		Out_Prize[1][6159]={chance=100,num=1}---//雷英戒
		Out_Prize[1][6160]={chance=100,num=1}---//空雷戒
		Out_Prize[1][6161]={chance=100,num=1}---//华光戒
		Out_Prize[1][6162]={chance=100,num=1}---//雷光戒
		Out_Prize[1][6163]={chance=100,num=1}---//极光戒
		Out_Prize[1][6164]={chance=100,num=1}---//断云戒
		Out_Prize[1][6165]={chance=100,num=1}---//涅云戒
		Out_Prize[1][6311]={chance=100,num=1}---//魔循
		Out_Prize[1][6331]={chance=100,num=1}---//魔锐
		Out_Prize[1][14377]={chance=100,num=1}---//陵延神盔（男）
		Out_Prize[1][14384]={chance=100,num=1}---//济灵冥盔（男）
		Out_Prize[1][14518]={chance=100,num=1}---//陵延神盔（女）
		Out_Prize[1][14525]={chance=100,num=1}---//济灵冥盔（女）
		Out_Prize[1][14750]={chance=100,num=1}---//陵延神甲（男）
		Out_Prize[1][14757]={chance=100,num=1}---//济灵冥甲（男）
		Out_Prize[1][14891]={chance=100,num=1}---//陵延神甲（女）
		Out_Prize[1][14898]={chance=100,num=1}---//济灵冥甲（女）
		Out_Prize[1][15032]={chance=100,num=1}---//陵延神靴（男）
		Out_Prize[1][15039]={chance=100,num=1}---//济灵冥靴（男）
		Out_Prize[1][15173]={chance=100,num=1}---//陵延神靴（女）
		Out_Prize[1][15180]={chance=100,num=1}---//济灵冥靴（女）
		Out_Prize[1][3008]={chance=100,num=1}---//荒冢战甲（男）
		Out_Prize[1][3015]={chance=100,num=1}---//闲歌灵衫（男）
		Out_Prize[1][3022]={chance=100,num=1}---//筑基道袍（男）
		Out_Prize[1][3029]={chance=100,num=1}---//宝树禅衣（男）
		Out_Prize[1][3036]={chance=100,num=1}---//荒冢战靴（男）
		Out_Prize[1][3043]={chance=100,num=1}---//闲歌灵靴（男）
		Out_Prize[1][3050]={chance=100,num=1}---//筑基道履（男）
		Out_Prize[1][3057]={chance=100,num=1}---//宝树禅履（男）
		Out_Prize[1][3064]={chance=100,num=1}---//荒冢战盔（男）
		Out_Prize[1][3071]={chance=100,num=1}---//闲歌灵盔（男）
		Out_Prize[1][3078]={chance=100,num=1}---//筑基道冠（男）
		Out_Prize[1][3085]={chance=100,num=1}---//宝树禅冠（男）
		Out_Prize[1][3092]={chance=100,num=1}---//荒冢战甲（女）
		Out_Prize[1][3099]={chance=100,num=1}---//闲歌灵衫（女）
		Out_Prize[1][3106]={chance=100,num=1}---//筑基道袍（女）
		Out_Prize[1][3113]={chance=100,num=1}---//宝树禅衣（女）
		Out_Prize[1][3120]={chance=100,num=1}---//荒冢战靴（女）
		Out_Prize[1][3127]={chance=100,num=1}---//闲歌灵靴（女）
		Out_Prize[1][3134]={chance=100,num=1}---//筑基道履（女）
		Out_Prize[1][3141]={chance=100,num=1}---//宝树禅履（女）
		Out_Prize[1][3148]={chance=100,num=1}---//荒冢战盔（女）
		Out_Prize[1][3155]={chance=100,num=1}---//闲歌灵盔（女）
		Out_Prize[1][3162]={chance=100,num=1}---//筑基道冠（女）
		Out_Prize[1][3169]={chance=100,num=1}---//宝树禅冠（女）
		Out_Prize[1][5180]={chance=100,num=1}---//杀欲魔盔（男）
		Out_Prize[1][5181]={chance=100,num=1}---//杀欲魔盔（女）
		Out_Prize[1][5208]={chance=100,num=1}---//雅意灵盔（男）
		Out_Prize[1][5209]={chance=100,num=1}---//雅意灵盔（女）
		Out_Prize[1][5236]={chance=100,num=1}---//修本道冠（男）
		Out_Prize[1][5237]={chance=100,num=1}---//修本道冠（女）
		Out_Prize[1][5264]={chance=100,num=1}---//明台禅冠（男）
		Out_Prize[1][5265]={chance=100,num=1}---//明台禅冠（女）
		Out_Prize[1][5316]={chance=100,num=1}---//杀欲魔靴（男）
		Out_Prize[1][5317]={chance=100,num=1}---//杀欲魔靴（女）
		Out_Prize[1][5344]={chance=100,num=1}---//雅意灵靴（男）
		Out_Prize[1][5345]={chance=100,num=1}---//雅意灵靴（女）
		Out_Prize[1][5372]={chance=100,num=1}---//修本道履（男）
		Out_Prize[1][5373]={chance=100,num=1}---//修本道履（女）
		Out_Prize[1][5400]={chance=100,num=1}---//明台禅履（男）
		Out_Prize[1][5401]={chance=100,num=1}---//明台禅履（女）
		Out_Prize[1][5428]={chance=100,num=1}---//杀欲魔甲（男）
		Out_Prize[1][5429]={chance=100,num=1}---//杀欲魔甲（女）
		Out_Prize[1][5456]={chance=100,num=1}---//雅意灵衫（男）
		Out_Prize[1][5457]={chance=100,num=1}---//雅意灵衫（女）
		Out_Prize[1][5484]={chance=100,num=1}---//修本道袍（男）
		Out_Prize[1][5485]={chance=100,num=1}---//修本道袍（女）
		Out_Prize[1][5512]={chance=100,num=1}---//明台禅衣（男）
		Out_Prize[1][5513]={chance=100,num=1}---//明台禅衣（女）
	elseif id==19113 then 
		Out_Prize[1][3450]={chance=100,num=1}---//龙威
		Out_Prize[1][3460]={chance=100,num=1}---//天佑
		Out_Prize[1][3531]={chance=100,num=1}---//龙胆
		Out_Prize[1][3541]={chance=100,num=1}---//龙心
		Out_Prize[1][6312]={chance=100,num=1}---//龙循
		Out_Prize[1][6332]={chance=100,num=1}---//龙锐
		Out_Prize[1][14378]={chance=100,num=1}---//碎魂天残盔（男）
		Out_Prize[1][14385]={chance=100,num=1}---//黑煞解尸盔（男）
		Out_Prize[1][14519]={chance=100,num=1}---//碎魂天残盔（女）
		Out_Prize[1][14526]={chance=100,num=1}---//黑煞解尸盔（女）
		Out_Prize[1][14751]={chance=100,num=1}---//碎魂天残甲（男）
		Out_Prize[1][14758]={chance=100,num=1}---//黑煞解尸甲（男）
		Out_Prize[1][14892]={chance=100,num=1}---//碎魂天残甲（女）
		Out_Prize[1][14899]={chance=100,num=1}---//黑煞解尸甲（女）
		Out_Prize[1][15033]={chance=100,num=1}---//碎魂天残靴（男）
		Out_Prize[1][15040]={chance=100,num=1}---//黑煞解尸靴（男）
		Out_Prize[1][15174]={chance=100,num=1}---//碎魂天残靴（女）
		Out_Prize[1][15181]={chance=100,num=1}---//黑煞解尸靴（女）
		Out_Prize[1][3009]={chance=100,num=1}---//魔尊戍魂铠（男）
		Out_Prize[1][3016]={chance=100,num=1}---//幻雾山岚衫（男）
		Out_Prize[1][3023]={chance=100,num=1}---//龙华矫天袍（男）
		Out_Prize[1][3030]={chance=100,num=1}---//寂灭功德袍（男）
		Out_Prize[1][3037]={chance=100,num=1}---//魔尊戍魂靴（男）
		Out_Prize[1][3044]={chance=100,num=1}---//幻雾山岚靴（男）
		Out_Prize[1][3051]={chance=100,num=1}---//龙华矫天履（男）
		Out_Prize[1][3058]={chance=100,num=1}---//寂灭功德履（男）
		Out_Prize[1][3065]={chance=100,num=1}---//魔尊戍魂盔（男）
		Out_Prize[1][3072]={chance=100,num=1}---//幻雾山岚盔（男）
		Out_Prize[1][3079]={chance=100,num=1}---//龙华矫天冠（男）
		Out_Prize[1][3086]={chance=100,num=1}---//寂灭功德冠（男）
		Out_Prize[1][3093]={chance=100,num=1}---//魔尊戍魂铠（女）
		Out_Prize[1][3100]={chance=100,num=1}---//幻雾山岚衫（女）
		Out_Prize[1][3107]={chance=100,num=1}---//龙华矫天袍（女）
		Out_Prize[1][3114]={chance=100,num=1}---//寂灭功德袍（女）
		Out_Prize[1][3121]={chance=100,num=1}---//魔尊戍魂靴（女）
		Out_Prize[1][3128]={chance=100,num=1}---//幻雾山岚靴（女）
		Out_Prize[1][3135]={chance=100,num=1}---//龙华矫天履（女）
		Out_Prize[1][3142]={chance=100,num=1}---//寂灭功德履（女）
		Out_Prize[1][3149]={chance=100,num=1}---//魔尊戍魂盔（女）
		Out_Prize[1][3156]={chance=100,num=1}---//幻雾山岚盔（女）
		Out_Prize[1][3163]={chance=100,num=1}---//龙华矫天冠（女）
		Out_Prize[1][3170]={chance=100,num=1}---//寂灭功德冠（女）
		Out_Prize[1][8278]={chance=100,num=1}---//浴血龙威盔（男）
		Out_Prize[1][8279]={chance=100,num=1}---//浴血龙威盔（女）
		Out_Prize[1][8390]={chance=100,num=1}---//离人挽歌盔（男）
		Out_Prize[1][8391]={chance=100,num=1}---//离人挽歌盔（女）
		Out_Prize[1][8510]={chance=100,num=1}---//定心云锦冠（男）
		Out_Prize[1][8512]={chance=100,num=1}---//定心云锦冠（女）
		Out_Prize[1][8648]={chance=100,num=1}---//宝树聚元冠（男）
		Out_Prize[1][8649]={chance=100,num=1}---//宝树聚元冠（女）
		Out_Prize[1][8856]={chance=100,num=1}---//浴血龙威靴（男）
		Out_Prize[1][8857]={chance=100,num=1}---//浴血龙威靴（女）
		Out_Prize[1][8968]={chance=100,num=1}---//离人挽歌靴（男）
		Out_Prize[1][8969]={chance=100,num=1}---//离人挽歌靴（女）
		Out_Prize[1][9080]={chance=100,num=1}---//定心云锦履（男）
		Out_Prize[1][9081]={chance=100,num=1}---//定心云锦履（女）
		Out_Prize[1][9192]={chance=100,num=1}---//宝树聚元履（男）
		Out_Prize[1][9193]={chance=100,num=1}---//宝树聚元履（女）
		Out_Prize[1][9304]={chance=100,num=1}---//浴血龙威甲（男）
		Out_Prize[1][9305]={chance=100,num=1}---//浴血龙威甲（女）
		Out_Prize[1][9416]={chance=100,num=1}---//离人挽歌衫（男）
		Out_Prize[1][9417]={chance=100,num=1}---//离人挽歌衫（女）
		Out_Prize[1][9528]={chance=100,num=1}---//定心云锦袍（男）
		Out_Prize[1][9529]={chance=100,num=1}---//定心云锦袍（女）
		Out_Prize[1][9640]={chance=100,num=1}---//宝树聚元袍（男）
		Out_Prize[1][9641]={chance=100,num=1}---//宝树聚元袍（女）
	elseif id==19114 then
		Out_Prize[1][3451]={chance=100,num=1}---//仙恕
		Out_Prize[1][3461]={chance=100,num=1}---//清虚
		Out_Prize[1][3532]={chance=100,num=1}---//仙助
		Out_Prize[1][3542]={chance=100,num=1}---//仙灵
		Out_Prize[1][6313]={chance=100,num=1}---//仙循
		Out_Prize[1][6333]={chance=100,num=1}---//仙锐
		Out_Prize[1][10926]={chance=100,num=1}---//破云戒
		Out_Prize[1][10927]={chance=100,num=1}---//破空戒
		Out_Prize[1][10928]={chance=100,num=1}---//破魂戒
		Out_Prize[1][10929]={chance=100,num=1}---//狂雷戒
		Out_Prize[1][10930]={chance=100,num=1}---//荡云戒
		Out_Prize[1][10931]={chance=100,num=1}---//流云戒
		Out_Prize[1][10932]={chance=100,num=1}---//定云戒
		Out_Prize[1][10933]={chance=100,num=1}---//聚英戒
		Out_Prize[1][10934]={chance=100,num=1}---//飞英戒
		Out_Prize[1][10935]={chance=100,num=1}---//幻雷戒
		Out_Prize[1][10936]={chance=100,num=1}---//烁光戒
		Out_Prize[1][10937]={chance=100,num=1}---//盈光戒
		Out_Prize[1][10938]={chance=100,num=1}---//绚光戒
		Out_Prize[1][10939]={chance=100,num=1}---//朔云戒
		Out_Prize[1][10940]={chance=100,num=1}---//奠云戒
		Out_Prize[1][14379]={chance=100,num=1}---//九曜定心盔（男）
		Out_Prize[1][14386]={chance=100,num=1}---//九蛊逆刃盔（男）
		Out_Prize[1][14520]={chance=100,num=1}---//九曜定心盔（女）
		Out_Prize[1][14527]={chance=100,num=1}---//九蛊逆刃盔（女）
		Out_Prize[1][14752]={chance=100,num=1}---//九曜定心甲（男）
		Out_Prize[1][14759]={chance=100,num=1}---//九蛊逆刃甲（男）
		Out_Prize[1][14893]={chance=100,num=1}---//九曜定心甲（女）
		Out_Prize[1][14900]={chance=100,num=1}---//九蛊逆刃甲（女）
		Out_Prize[1][15034]={chance=100,num=1}---//九曜定心靴（男）
		Out_Prize[1][15041]={chance=100,num=1}---//九蛊逆刃靴（男）
		Out_Prize[1][15175]={chance=100,num=1}---//九曜定心靴（女）
		Out_Prize[1][15182]={chance=100,num=1}---//九蛊逆刃靴（女）
		Out_Prize[1][3010]={chance=100,num=1}---//九转焚心铠（男）
		Out_Prize[1][3017]={chance=100,num=1}---//九华惑心铠（男）
		Out_Prize[1][3024]={chance=100,num=1}---//九阳洞仙袍（男）
		Out_Prize[1][3031]={chance=100,num=1}---//九尊华严袍（男）
		Out_Prize[1][3038]={chance=100,num=1}---//九转焚心靴（男）
		Out_Prize[1][3045]={chance=100,num=1}---//九华惑心靴（男）
		Out_Prize[1][3052]={chance=100,num=1}---//九阳洞仙履（男）
		Out_Prize[1][3059]={chance=100,num=1}---//九尊华严履（男）
		Out_Prize[1][3066]={chance=100,num=1}---//九转焚心盔（男）
		Out_Prize[1][3073]={chance=100,num=1}---//九华惑心盔（男）
		Out_Prize[1][3080]={chance=100,num=1}---//九阳洞仙冠（男）
		Out_Prize[1][3087]={chance=100,num=1}---//九尊华严冠（男）
		Out_Prize[1][3094]={chance=100,num=1}---//九转焚心铠（女）
		Out_Prize[1][3101]={chance=100,num=1}---//九华惑心铠（女）
		Out_Prize[1][3108]={chance=100,num=1}---//九阳洞仙袍（女）
		Out_Prize[1][3115]={chance=100,num=1}---//九尊华严袍（女）
		Out_Prize[1][3122]={chance=100,num=1}---//九转焚心靴（女）
		Out_Prize[1][3129]={chance=100,num=1}---//九华惑心靴（女）
		Out_Prize[1][3136]={chance=100,num=1}---//九阳洞仙履（女）
		Out_Prize[1][3143]={chance=100,num=1}---//九尊华严履（女）
		Out_Prize[1][3150]={chance=100,num=1}---//九转焚心盔（女）
		Out_Prize[1][3157]={chance=100,num=1}---//九华惑心盔（女）
		Out_Prize[1][3164]={chance=100,num=1}---//九阳洞仙冠（女）
		Out_Prize[1][3171]={chance=100,num=1}---//九尊华严冠（女）
		Out_Prize[1][8306]={chance=100,num=1}---//九兽赤鳞盔（男）
		Out_Prize[1][8307]={chance=100,num=1}---//九兽赤鳞盔（女）
		Out_Prize[1][8418]={chance=100,num=1}---//九焕金纱盔（男）
		Out_Prize[1][8419]={chance=100,num=1}---//九焕金纱盔（女）
		Out_Prize[1][8561]={chance=100,num=1}---//九英聚元冠（男）
		Out_Prize[1][8562]={chance=100,num=1}---//九英聚元冠（女）
		Out_Prize[1][8676]={chance=100,num=1}---//九妙慈航冠（男）
		Out_Prize[1][8677]={chance=100,num=1}---//九妙慈航冠（女）
		Out_Prize[1][8884]={chance=100,num=1}---//九兽赤鳞靴（男）
		Out_Prize[1][8885]={chance=100,num=1}---//九兽赤鳞靴（女）
		Out_Prize[1][8996]={chance=100,num=1}---//九焕金纱靴（男）
		Out_Prize[1][8997]={chance=100,num=1}---//九焕金纱靴（女）
		Out_Prize[1][9108]={chance=100,num=1}---//九英聚元履（男）
		Out_Prize[1][9109]={chance=100,num=1}---//九英聚元履（女）
		Out_Prize[1][9220]={chance=100,num=1}---//九妙慈航履（男）
		Out_Prize[1][9221]={chance=100,num=1}---//九妙慈航履（女）
		Out_Prize[1][9332]={chance=100,num=1}---//九兽赤鳞铠（男）
		Out_Prize[1][9333]={chance=100,num=1}---//九兽赤鳞铠（女）
		Out_Prize[1][9444]={chance=100,num=1}---//九焕金纱铠（男）
		Out_Prize[1][9445]={chance=100,num=1}---//九焕金纱铠（女）
		Out_Prize[1][9556]={chance=100,num=1}---//九英聚元袍（男）
		Out_Prize[1][9557]={chance=100,num=1}---//九英聚元袍（女）
		Out_Prize[1][9668]={chance=100,num=1}---//九妙慈航袍（男）
		Out_Prize[1][9669]={chance=100,num=1}---//九妙慈航袍（女）
	elseif id==19115 then 
		Out_Prize[1][3452]={chance=100,num=1}---//神威
		Out_Prize[1][3462]={chance=100,num=1}---//太虚
		Out_Prize[1][3533]={chance=100,num=1}---//神迹
		Out_Prize[1][3543]={chance=100,num=1}---//神喻
		Out_Prize[1][6314]={chance=100,num=1}---//神循
		Out_Prize[1][6334]={chance=100,num=1}---//神锐
		Out_Prize[1][14380]={chance=100,num=1}---//战天狂灵魔神盔（男）
		Out_Prize[1][14387]={chance=100,num=1}---//幽冥转魂天祭盔（男）
		Out_Prize[1][14521]={chance=100,num=1}---//战天狂灵魔神盔（女）
		Out_Prize[1][14528]={chance=100,num=1}---//幽冥转魂天祭盔（女）
		Out_Prize[1][14753]={chance=100,num=1}---//战天狂灵魔神甲（男）
		Out_Prize[1][14760]={chance=100,num=1}---//幽冥转魂天祭甲（男）
		Out_Prize[1][14894]={chance=100,num=1}---//战天狂灵魔神甲（女）
		Out_Prize[1][14901]={chance=100,num=1}---//幽冥转魂天祭甲（女）
		Out_Prize[1][15035]={chance=100,num=1}---//战天狂灵魔神靴（男）
		Out_Prize[1][15042]={chance=100,num=1}---//幽冥转魂天祭靴（男）
		Out_Prize[1][15176]={chance=100,num=1}---//战天狂灵魔神靴（女）
		Out_Prize[1][15183]={chance=100,num=1}---//幽冥转魂天祭靴（女）
		Out_Prize[1][3011]={chance=100,num=1}---//离魂鬼契克劫铠（男）
		Out_Prize[1][3018]={chance=100,num=1}---//远峦接天离愁衫（男）
		Out_Prize[1][3025]={chance=100,num=1}---//云门天官锦罗袍（男）
		Out_Prize[1][3032]={chance=100,num=1}---//金山觉意佛尊袍（男）
		Out_Prize[1][3039]={chance=100,num=1}---//离魂鬼契克劫靴（男）
		Out_Prize[1][3046]={chance=100,num=1}---//远峦接天离愁靴（男）
		Out_Prize[1][3053]={chance=100,num=1}---//云门天官锦罗履（男）
		Out_Prize[1][3060]={chance=100,num=1}---//金山觉意佛尊履（男）
		Out_Prize[1][3067]={chance=100,num=1}---//离魂鬼契克劫盔（男）
		Out_Prize[1][3074]={chance=100,num=1}---//远峦接天离愁盔（男）
		Out_Prize[1][3081]={chance=100,num=1}---//云门天官锦罗冠（男）
		Out_Prize[1][3088]={chance=100,num=1}---//金山觉意佛尊冠（男）
		Out_Prize[1][3095]={chance=100,num=1}---//离魂鬼契克劫铠（女）
		Out_Prize[1][3102]={chance=100,num=1}---//远峦接天离愁衫（女）
		Out_Prize[1][3109]={chance=100,num=1}---//云门天官锦罗袍（女）
		Out_Prize[1][3116]={chance=100,num=1}---//金山觉意佛尊袍（女）
		Out_Prize[1][3123]={chance=100,num=1}---//离魂鬼契克劫靴（女）
		Out_Prize[1][3130]={chance=100,num=1}---//远峦接天离愁靴（女）
		Out_Prize[1][3137]={chance=100,num=1}---//云门天官锦罗履（女）
		Out_Prize[1][3144]={chance=100,num=1}---//金山觉意佛尊履（女）
		Out_Prize[1][3151]={chance=100,num=1}---//离魂鬼契克劫盔（女）
		Out_Prize[1][3158]={chance=100,num=1}---//远峦接天离愁盔（女）
		Out_Prize[1][3165]={chance=100,num=1}---//云门天官锦罗冠（女）
		Out_Prize[1][3172]={chance=100,num=1}---//金山觉意佛尊冠（女）
		Out_Prize[1][8334]={chance=100,num=1}---//明尊天佑邪灵盔（男）
		Out_Prize[1][8335]={chance=100,num=1}---//明尊天佑邪灵盔（女）
		Out_Prize[1][8446]={chance=100,num=1}---//琼台天籁承欢盔（男）
		Out_Prize[1][8447]={chance=100,num=1}---//琼台天籁承欢盔（女）
		Out_Prize[1][8592]={chance=100,num=1}---//积元贮本弥金冠（男）
		Out_Prize[1][8593]={chance=100,num=1}---//积元贮本弥金冠（女）
		Out_Prize[1][8704]={chance=100,num=1}---//摩诃刹利诸天冠（男）
		Out_Prize[1][8705]={chance=100,num=1}---//摩诃刹利诸天冠（女）
		Out_Prize[1][8912]={chance=100,num=1}---//明尊天佑邪灵靴（男）
		Out_Prize[1][8913]={chance=100,num=1}---//明尊天佑邪灵靴（女）
		Out_Prize[1][9024]={chance=100,num=1}---//琼台天籁承欢靴（男）
		Out_Prize[1][9025]={chance=100,num=1}---//琼台天籁承欢靴（女）
		Out_Prize[1][9136]={chance=100,num=1}---//积元贮本弥金履（男）
		Out_Prize[1][9137]={chance=100,num=1}---//积元贮本弥金履（女）
		Out_Prize[1][9248]={chance=100,num=1}---//摩诃刹利诸天履（男）
		Out_Prize[1][9249]={chance=100,num=1}---//摩诃刹利诸天履（女）
		Out_Prize[1][9360]={chance=100,num=1}---//明尊天佑邪灵铠（男）
		Out_Prize[1][9361]={chance=100,num=1}---//明尊天佑邪灵铠（女）
		Out_Prize[1][9472]={chance=100,num=1}---//琼台天籁承欢衫（男）
		Out_Prize[1][9473]={chance=100,num=1}---//琼台天籁承欢衫（女）
		Out_Prize[1][9584]={chance=100,num=1}---//积元贮本弥金袍（男）
		Out_Prize[1][9585]={chance=100,num=1}---//积元贮本弥金袍（女）
		Out_Prize[1][9696]={chance=100,num=1}---//摩诃刹利诸天袍（男）
		Out_Prize[1][9697]={chance=100,num=1}---//摩诃刹利诸天袍（女）
		Out_Prize[1][6315]={chance=100,num=1}---//天循(可强化戒指1)
		Out_Prize[1][6305]={chance=100,num=1}---//天戍(可强化戒指2)
		Out_Prize[1][3463]={chance=100,num=1}---//玉虚(可强化戒指3)
		Out_Prize[1][10957]={chance=100,num=1}---//天道戒(可强化戒指4)
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
function LotteryTypeGoldSeason1Cashing(cur_list,id)	---(虚拟币兑换物品)
	---fmax_count为该彩票的有效位数
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
function LotteryType19125Cashing(cur_list)		---(神龙秘笈)
	---fmax_count为该彩票的有效位数
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
	
	Out_Prize[1][19132]=100		---熊猫panda
	
	Out_Prize[2][19127]=100		---龙火面具(男)
	Out_Prize[2][19128]=200		---鸟羽面具(女)
	
	Out_Prize[3][13343]=140		---聚宝盆
	
	Out_Prize[4][8079]=25		---飞天神符
		
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
function LotteryType19297Cashing(cur_list)		---(云光天鉴)
	---fmax_count为该彩票的有效位数
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
	
	Out_Prize[1][19298]=100		---云壤之华(云梭兑换券)
	
	Out_Prize[2][16506]=100		---宠物：魅心蝶精

	Out_Prize[3][18794]=100		---仙豆
	
	Out_Prize[4][8079]=100			---飞天神符
		
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
function LotteryType19434Cashing(cur_list)		---(票彩鱼金/龙宫锦图)
	---fmax_count为该彩票的有效位数
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
	
	Out_Prize[1][19435]=100		---锦鳞(金鱼兑换券)
	
	Out_Prize[2][19129]=100		---毒蝎面具(男)
	Out_Prize[2][19130]=200		---花瓣面具(女)

	Out_Prize[3][18794]=100		---仙豆
	
	Out_Prize[4][13901]=25		---加Def药
	Out_Prize[4][13900]=100		---加Atk药
		
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
function LotteryType19558Cashing(cur_list)		---(如意金鼓/朔望彤云)
	---fmax_count为该彩票的有效位数
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
	
	Out_Prize[1][19559]=100		---玉如意(飞剑兑换券)
	
	Out_Prize[2][18306]=100		---缥缈之影(宠物)

	Out_Prize[3][16551]=100		---集宝盆
	Out_Prize[3][19418]=900		---灵宝秘尘
	
	Out_Prize[4][8079]=100		---飞天神符

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
function LotteryTypeGoldSeason2Cashing(cur_list,id)		---(虚拟币回收彩票/宠物技能书)
	---fmax_count为该彩票的有效位数
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
		Out_Prize[1][19356]={chance=100,num=1}---//守护<日曜>
		Out_Prize[1][19357]={chance=100,num=1}---//热忱<日曜>
		Out_Prize[1][19358]={chance=100,num=1}---//闪耀<日曜>
		Out_Prize[1][19359]={chance=100,num=1}---//光辉<日曜>
		Out_Prize[1][19360]={chance=100,num=1}---//神聚<日曜>
		Out_Prize[1][19361]={chance=100,num=1}---//中天<日曜>
	elseif id==19426 then 
		Out_Prize[1][19362]={chance=100,num=1}---//新月<月曜>
		Out_Prize[1][19363]={chance=100,num=1}---//会神<月曜>
		Out_Prize[1][19364]={chance=100,num=1}---//贯注<月曜>
		Out_Prize[1][19365]={chance=100,num=1}---//流星<月曜>
		Out_Prize[1][19366]={chance=100,num=1}---//月影<月曜>
		Out_Prize[1][19367]={chance=100,num=1}---//水月<月曜>
	elseif id==19427 then 
		Out_Prize[1][19368]={chance=100,num=1}---//芒刺<金曜>
		Out_Prize[1][19369]={chance=100,num=1}---//怒嚎<金曜>
		Out_Prize[1][19370]={chance=100,num=1}---//全力<金曜>
		Out_Prize[1][19371]={chance=100,num=1}---//撕裂<金曜>
		Out_Prize[1][19372]={chance=100,num=1}---//刺耳<金曜>
		Out_Prize[1][19373]={chance=100,num=1}---//挑衅<金曜>
	elseif id==19428 then 
		Out_Prize[1][19374]={chance=100,num=1}---//曜灵<木曜>
		Out_Prize[1][19375]={chance=100,num=1}---//林荫<木曜>
		Out_Prize[1][19376]={chance=100,num=1}---//猛击<木曜>
		Out_Prize[1][19377]={chance=100,num=1}---//明灭<木曜>
		Out_Prize[1][19378]={chance=100,num=1}---//羁绊<木曜>
		Out_Prize[1][19379]={chance=100,num=1}---//疲惫<木曜>
	elseif id==19429 then 
		Out_Prize[1][19380]={chance=100,num=1}---//甘泉<水曜>
		Out_Prize[1][19381]={chance=100,num=1}---//祷告<水曜>
		Out_Prize[1][19382]={chance=100,num=1}---//预言<水曜>
		Out_Prize[1][19383]={chance=100,num=1}---//波纹<水曜>
		Out_Prize[1][19384]={chance=100,num=1}---//涟漪<水曜>
		Out_Prize[1][19385]={chance=100,num=1}---//思虑<水曜>
	elseif id==19430 then 
		Out_Prize[1][19386]={chance=100,num=1}---//火甲<火曜>
		Out_Prize[1][19387]={chance=100,num=1}---//贯通<火曜>
		Out_Prize[1][19388]={chance=100,num=1}---//酝酿<火曜>
		Out_Prize[1][19389]={chance=100,num=1}---//灼热<火曜>
		Out_Prize[1][19390]={chance=100,num=1}---//真火<火曜>
		Out_Prize[1][19391]={chance=100,num=1}---//燃尽<火曜>
	elseif id==19431 then 
		Out_Prize[1][19392]={chance=100,num=1}---//地祝<土曜>
		Out_Prize[1][19393]={chance=100,num=1}---//洞察<土曜>
		Out_Prize[1][19394]={chance=100,num=1}---//伤痕<土曜>
		Out_Prize[1][19395]={chance=100,num=1}---//追迹<土曜>
		Out_Prize[1][19396]={chance=100,num=1}---//沉沦<土曜>
		Out_Prize[1][19397]={chance=100,num=1}---//陷地<土曜>
	elseif id==19432 then 
		Out_Prize[1][19398]={chance=100,num=1}---//妄言<罗候>
		Out_Prize[1][19399]={chance=100,num=1}---//黯淡<罗候>
		Out_Prize[1][19400]={chance=100,num=1}---//宿命<罗候>
		Out_Prize[1][19401]={chance=100,num=1}---//禁锢<罗候>
		Out_Prize[1][19402]={chance=100,num=1}---//喝言<罗候>
		Out_Prize[1][19403]={chance=100,num=1}---//苦痛<罗候>
	elseif id==19433 then 
		Out_Prize[1][19404]={chance=100,num=1}---//闪避<计都>
		Out_Prize[1][19405]={chance=100,num=1}---//藐视<计都>
		Out_Prize[1][19406]={chance=100,num=1}---//锋利<计都>
		Out_Prize[1][19407]={chance=100,num=1}---//厄运<计都>
		Out_Prize[1][19408]={chance=100,num=1}---//忏悔<计都>
		Out_Prize[1][19409]={chance=100,num=1}---//迷茫<计都>
	end
		Out_Prize[1][19410]={chance=100,num=1}---//沸腾<通用>
		Out_Prize[1][19411]={chance=100,num=1}---//凝华<通用>
		Out_Prize[1][19412]={chance=100,num=1}---//挥洒<通用>
		Out_Prize[1][19413]={chance=100,num=1}---//蛮力<通用>
		Out_Prize[1][19414]={chance=100,num=1}---//修整<通用>
		Out_Prize[1][19415]={chance=100,num=1}---//汲取<通用>
	
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
function LotteryType19713Cashing(cur_list)		---(炎蹄之心)
	---fmax_count为该彩票的有效位数
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
	
	Out_Prize[1][19714]=100		---妖马兑换券
	
	Out_Prize[2][7931]=40			---结婚礼包男
	Out_Prize[2][7937]=60			---结婚礼包女

	Out_Prize[3][18794]=100		---仙豆
	
	Out_Prize[4][8079]=100		---飞天神符
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
function LotteryType20097Cashing(cur_list)		---(08国情虚拟币礼包)
	---fmax_count为该彩票的有效位数
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
	
	Out_Prize[1][20096]=100		---新暴击项链
	
	Out_Prize[2][6315]=200			---100级躲闪戒指
	Out_Prize[2][6305]=200			---100级防御戒指
	Out_Prize[2][3463]=200			---100级减伤戒指
	Out_Prize[2][10957]=100			---100级全抗戒指

	Out_Prize[3][16551]=100			---集宝盆
	Out_Prize[3][13301]=60			---五行珠1
	Out_Prize[3][13302]=60			---五行珠2
	Out_Prize[3][13303]=60			---五行珠3
	Out_Prize[3][13304]=60			---五行珠4
	Out_Prize[3][13305]=60			---五行珠5
	
	Out_Prize[4][20098]=100			---功德香兑换券
	Out_Prize[4][20099]=100			---乾坤通宝兑换券
	
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
function LotteryType20109Cashing(cur_list)		---(鸣珏瑰玉)
	---fmax_count为该彩票的有效位数
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
	
	Out_Prize[1][20110]=100		---飞剑：碧落兑换券
	
	Out_Prize[2][20090]=40		---法宝：混元金斗

	Out_Prize[3][18794]=100		---仙豆
	
	Out_Prize[4][8079]=100		---飞天神符
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
function LotteryType20284Cashing(cur_list)		---(苍穹光印)
	---fmax_count为该彩票的有效位数
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
	
	Out_Prize[1][20283]=100		---飞剑：鸿飞兑换券
	
	Out_Prize[2][20108]=100		---法宝：彩翼黄鸟
	Out_Prize[2][19510]=100		---宠物：妙翅黄鸟
	
	Out_Prize[3][18794]=500		---仙豆
	Out_Prize[3][7939]=100		---天宝逆龙鳞
	Out_Prize[3][19257]=200		---麒麟内丹
	
	Out_Prize[4][8079]=100		---飞天神符
	
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
function LotteryType20480Cashing(cur_list)		---(孔雀令)
	---fmax_count为该彩票的有效位数
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
	
	Out_Prize[1][20486]=100		---孔雀兑换券

	Out_Prize[2][7931]=40			---结婚礼包男
	Out_Prize[2][7937]=60			---结婚礼包女

	Out_Prize[3][18794]=100		---仙豆

	Out_Prize[4][13901]=25		---加Def药
	Out_Prize[4][13900]=100		---加Atk药

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
function LotteryType20482Cashing(cur_list)		---(龙皇古卷)
	---fmax_count为该彩票的有效位数
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
	
	Out_Prize[1][20487]=100 ---//飞剑紫芒兑换券
	
	Out_Prize[2][18797]=100 ---//绝版法宝兑换券
	
	Out_Prize[3][13343]=100	---//聚宝盆
	
	Out_Prize[4][8079]=100	---//飞天神符
		
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
function LotteryType20460Cashing(cur_list)		---(极光转盘)
	---fmax_count为该彩票的有效位数
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
function LotteryType21194Cashing(cur_list)		---(兽骨玉匣)
	---fmax_count为该彩票的有效位数
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
	
	Out_Prize[1][21189]=100		---绝版坐骑兑换券

	Out_Prize[2][20491]=100		---法宝：长明灯

	Out_Prize[3][18794]=100		---仙豆三个

	Out_Prize[4][13901]=20		---龟灵冰晶
	Out_Prize[4][13900]=80		---虎魄冰晶

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
function LotteryType21697Cashing(cur_list)		---(极东绽石)
	---fmax_count为该彩票的有效位数
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
	
	Out_Prize[1][21890]=100 ---//飞剑罡拓兑换券
	Out_Prize[2][19257]=100 ---//麒麟内丹
	Out_Prize[3][13343]=100	---//聚宝盆
	Out_Prize[4][8079]=100	---//飞天神符
		
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
function LotteryType21752Cashing(cur_list)		---(天眷神篇/雪琪月虚拟币彩票)
	---fmax_count为该彩票的有效位数
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

	Out_Prize[1][20096]=100			---新暴击项链:神藏
	Out_Prize[2][21742]=33			---神行锦囊·初计
	Out_Prize[2][21743]=33			---太虚锦囊·初计
	Out_Prize[2][21744]=33			---逍遥锦囊·初计
	Out_Prize[3][21200]=50			---龙魂符(仙魔精练符)
	Out_Prize[3][21345]=50			---造化珠×10
	Out_Prize[4][20098]=50			---成捆的功德香
	Out_Prize[4][19557]=50			---月宫祝福
	
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
function LotteryType88813Cashing(cur_list)		---(天眷神篇/雪琪月虚拟币彩票)
	---fmax_count为该彩票的有效位数
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

	Out_Prize[1][20645]=80			---仙·降龙
	Out_Prize[2][20657]=80			---仙·伏虎
	Out_Prize[2][20633]=80			---仙·诛妖
	Out_Prize[2][20621]=80			---仙·逍遥
	Out_Prize[3][3995]=80			---天下符45%
	Out_Prize[3][21345]=50			---造化珠×200
	Out_Prize[4][19257]=50			---麒麟内丹
	Out_Prize[4][21820]=50			---神行锦囊·十计
	
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
--      接口函数LotterySelectNumber 
--	说明：表示生成一个彩票中的某位数字
--      参数：
--           id : 彩票的物品 id， 不同的彩票可能有不同的表现
--           max_count: 这张彩票总共会有几个数字组成
--           cur_list: 当前已经生成的彩票号码 #cur_list就可以得到当前生成的号码数量 
--                     cur_list[1] 到 cur_list[#cur_list] 就是当前已经生成的所有号码
--                     标准的概率生成可能无需这些参数
--      返回：这个函数应当返回一个1~255的数值表示本次生成的单个彩票号码，0被认为
--            错误的彩票号码，因而被作为错误情况进行返回．
--
--      ************************************************************************
--
--      接口函数LotteryCashing
--      说明：对一张已经生成完毕的彩票进行兑奖操作
--      参数：
--           id : 彩票的物品 id， 不同的彩票可能有不同的表现
--           cur_list: 当前已经生成的彩票号码 #cur_list就可以得到当前所有的号码
--                     cur_list[1] 到 cur_list[#cur_list] 表示了依照生成顺序的号码
--      返回：兑奖后的结果由此接口返回，兑奖总共有六个整数型参数进行返回。
--          返回的格式为 return b_level b_money b_item b_count b_bind b_period;
--          各个返回值解释如下：
--           b_level: 本次彩票的中奖等级，等级是一个大于等于0的整数
--           b_money: 本次彩票的中奖奖金，奖金是一个大于等于0的整数
--           b_item:　本次彩票的奖励物品id，如果为0或-1则表示无奖品
--           b_count: 本次彩票的奖励物品数目，这个值应当大于等于0并不大于堆叠上限
--           b_bind: 本次中奖发放的物品奖励是否绑定，有效值为0或者1。只有堆叠上限为1这个参数才有意义
--           b_period:本次中奖发放物品奖励是否有有效时间，这是一个大于等于0的整数，大于0表示存在有效值。
--                    只有堆叠上限为1这个参数才有意义。
--         当返回参数个数不满足要求，或者参数的范围不满足要求时，这个函数的返回被认为是错误的。
-------------------------------------------------------------------------------------------------------------
--]]
---
---  有关接口实现　后面的两个接口是一个参考实现?
---　使用if语句进行判断不同的彩票　然后调用不同彩票的生成和判断函数
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
	elseif(id==10555 or id==6560) then 					---空置或用来测试的彩票，无效
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
	elseif(id==10555 or id==6560) then 					---空置或用来测试的彩票，无效
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
		return 0;	-- 返回错误
	end 	
end

-------------------------------------------------------------------------------------------------------------
--[[
--  另外一个备选实现　使用table保存所有的彩票接口　调用时直接查询并调用之
--	才后面要用AddLotteryTemplate　将每种彩票的映射加入到其中.
--	这只是一个提示性代码，接口的名字被修改为XXXX_aux，主程序并不会调用这个名称的接口函数
--

function LotterySelectNumber_aux(id, max_count, cur_list)
	local m = lottery_template[id];
	if(m) then
	return m.Select(cur_list, max_count);
	end
	return 0; 	-- 返回错误
end

function LotteryCashing_aux(id , cur_list)
	local m = lottery_template[id];
	if(m) then
	return m.Cashing(cur_list);
	end
	return 0;	-- 返回错误
end

AddLotteryTemplate(3613, LotteryType3613SelectNumber,LotteryType3613Cashing);
--]]