------------------------------------------------------------------------------------------------------
-- �����ű�
-- �������нű�������ϵͳ��صĹ���ʱ���Ե���

-----------------------------------------------------------------------------------------------------------
----���ּ�����̬��-------------------------------------------------------------------------------------------
math.randomseed(os.time())
math.random()
math.random()
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
   				if Total_Chance==0 then                
		 				n2[m]=0
						n2[1]=1
					else
						n2[m]=nx[m]/ Total_Chance
					end
			end
			return n2
end
-------------------------------------------------------------------------------------------------------------
----���ճ��ָ������Ӧ��ѡȡ��λ��---------------------------------------------------------------------------

function ZLottery_Get_RanPoint(s1)
			local js,ron1
			ron1= math.random()                
 		 local p1=ZLottery_Chance_Norm(s1)
			for js=1,table.getn(p1) do
  		        if ron1<=p1[js] then 
   		 	  		return js
				  		end
			end
			return 1
end

-----------------------------------------------��������������-------------------------------------------------
----------------------------------------------------------------------------------------------------------------
---Լ������ز�����id�ţ���Ԫ����ͬ��
---1����Ѫ
---2������
---3������
---4������
---5������
---6������
---7����������
---8�����ܶ���
---9��Ԫ��ֵ
---10������һ����
---11������һ���˺�
---12����������һ����
---13����������һ���˺�
---14������
---15����ħ
---16������
---17������
---18����ħ
---19���˷�
---20������̶��˺�
---21�������˺��ٷֱ�
---22��ѣ�ο���
---23��������
---24���Ȼ���
---25����������
---26����˯����
---27�����ٿ���
---28�������˺�����
---29����Ѫ���Ӱٷֱ�
---30���������Ӱٷֱ�
---31���������Ӱٷֱ�
---32���������Ӱٷֱ�
---33��Ԫ������
-------------------------------------------------------------------
function AstrologyIdentify(id, astrology, reborn_cnt, equip_mask)

    ---A-1)δ�����������Գ�1���ʷֲ�(ÿ��10��)
    local AttributeLib1 = 
    			{
   				1200,1200,1500,1000,2000,1800,100,0,0,100,
   				0,100,0,0,0,0,0,0,0,150,
    			}
    ---A-2)δ����ñ�����Գ�2���ʷֲ�(ÿ��10��)
    local AttributeLib2 =
    			{
    			1000,1500,1000,1000,1750,1750,0,100,0,0,
   				100,0,100,0,0,0,0,0,0,150,
   				0,600,600,
    			}
    ---A-3)δ�����·����Գ�3���ʷֲ�(ÿ��10��)
    local AttributeLib3 = 
    			{
   				1000,1000,1000,1400,1900,1800,0,100,0,0,
   				100,0,0,0,0,0,0,0,0,150,
   				0,0,0,600,600,
    			}
    ---A-4)δ����Ь�����Գ�4���ʷֲ�(ÿ��10��)
    local AttributeLib4 =
    			{
    			1400,1000,900,1000,2000,1800,100,0,0,0,
   				100,0,100,0,0,0,0,0,0,0,
   				100,0,0,0,0,600,600,
    			}
    ---B-1)�����������Գ�5���ʷֲ�(ÿ��10��)
    local AttributeLib5 = 
    			{
   				600,600,900,700,950,950,100,0,100,100,
   				0,100,0,650,650,650,650,650,650,150,
   				0,0,0,0,0,0,0,50,150,150,
   				200,200,100,
    			}
    ---B-2)����ñ�����Գ�6���ʷֲ�(ÿ��10��)
    local AttributeLib6 =
    			{
    			600,900,450,1000,900,900,0,100,100,0,
   				100,0,100,650,650,650,650,650,650,150,
   				0,450,450,0,0,0,0,50,0,100,
   				150,200,100,
    			}
    ---B-3)�����·����Գ�7���ʷֲ�(ÿ��10��)
    local AttributeLib7 = 
    			{
   				500,500,500,900,800,800,0,100,100,0,
   				100,0,100,650,650,650,650,650,650,150,
   				0,0,0,450,450,0,0,50,150,0,
   				150,200,100,
    			}
    ---B-4)����Ь�����Գ�8���ʷֲ�(ÿ��10��)
    local AttributeLib8 =
    			{
    			900,600,400,650,750,850,100,0,100,0,
   				100,0,100,650,650,650,650,650,650,0,
   				100,0,0,0,0,450,450,50,150,150,
   				0,100,100,
    			}
    ---������Ŀ�ĸ��ʷֲ���1����5����δ�����ͣ�
    local AttributeNumberList =
    			{
    			4000,5000,800,195,5,
    			}
    ---������Ŀ�ĸ��ʷֲ���1����5���������ͣ�
    local AttributeNumberList2 =
    			{
    			9996,1,1,1,1,
    			}
    ---��ֵ�ȼ��ĸ��ʷֲ�����9����
    local Proplevel =
    			{
    			9992,1,1,1,1,1,1,1,1,
    			}
     ---���Գ���ÿ�����Ե�ÿ��ֵ�ȼ�ֵ(��Ӧ�����id�ţ����Գ���33������)
    local LevelsValue1 =
    			{
    			15000,15000,1800,750,135,105,135,135,3000,120,
    			320,180,360,120,120,120,120,120,120,600,
    			120,270,270,270,270,270,90,36,80,80,
    			80,60,48,
    			}
     local LevelsValue2 =
    			{
    			11250,11250,900,540,90,75,60,60,0,90,
    			200,90,200,0,0,0,0,0,0,210,
    			120,180,180,180,180,180,45,0,60,60,
    			60,45,0,
    			}
    ---���Գظ�����Ȩ�أ�ÿ��10����
    local Propweight =
    			{
    			3,3,3,2,2,2,4,4,4,4,
    			4,4,4,2,2,2,2,2,2,3,
    			3,3,3,3,3,3,3,4,3,3,
    			3,2,4,
    			}
-------------------------------------------------------------------------------------------------------------
---���������Ŀ����

		function GetNumerList(s2)
				local k = 1
				k = ZLottery_Get_RanPoint(s2)
				return k
		end
		
---������Ե�id

		function GetId(s1)
				local	k1 = 1
				k1 = ZLottery_Get_RanPoint(s1)
				return k1
		end
---������Ե���ֵλ

		function GetGrade(s1)
				local	k1 = 1
				k1 = ZLottery_Get_RanPoint(s1)
				return k1
		end

---��ø�������ֵ
		local AttCnt
		local i
		local j = 0
		local j1 = 0
		local	a={}
		local b={}
		local c={}
		local d={}
		local Tempatt={}
		local Tempattt_size = 0
		

---δ������		
    if reborn_cnt>=0 and reborn_cnt<1 then
				AttCnt = GetNumerList(AttributeNumberList)
				if AttCnt>=5 then 
				   AttCnt = 5 
				end
				
				if AttCnt<1 then 
				   AttCnt = 1 
				end

---���δ�����;������Ե�id			
				if equip_mask>0 and equip_mask<2 then
				
				Tempattt_size = table.getn(AttributeLib1)
				for i=1,Tempattt_size do
   					Tempatt[i] = AttributeLib1[i]        
				end
   			   for i=1,AttCnt do
						   a[i]=GetId(Tempatt)
						   Tempatt[a[i]]=0
				   end
				
				elseif equip_mask>=2 and equip_mask<4 then
				   Tempattt_size = table.getn(AttributeLib2)
				for i=1,Tempattt_size do
   					Tempatt[i] = AttributeLib2[i]        
				end
   			   for i=1,AttCnt do
						   a[i]=GetId(Tempatt)
						   Tempatt[a[i]]=0
				   end
				
				elseif equip_mask>=4 and equip_mask<8 then
					Tempattt_size = table.getn(AttributeLib3)
				for i=1,Tempattt_size do
   					Tempatt[i] = AttributeLib3[i]        
				end
   			   for i=1,AttCnt do
						   a[i]=GetId(Tempatt)
						   Tempatt[a[i]]=0
				   end
				
				elseif equip_mask>=8 and equip_mask<9 then
					 Tempattt_size = table.getn(AttributeLib4)
				for i=1,Tempattt_size do
   					Tempatt[i] = AttributeLib4[i]        
				end
   			   for i=1,AttCnt do
						   a[i]=GetId(Tempatt)
						   Tempatt[a[i]]=0
				   end
				
				end
---��þ������Ե�ֵ
      for i=1,AttCnt do
					b[i] = GetGrade(Proplevel)
			end
---ÿ�����Ե�С������ֵ
			for i=1,AttCnt do
					d[i] = math.random(1,10)*0.1
			end
---��ø����Եľ���ֵ
    	for i=1,AttCnt do
     			c[i] = LevelsValue2[a[i]]*(b[i]+d[i])
    	end				
				
				
				
---������				
		elseif reborn_cnt>=1 then
				AttCnt = GetNumerList(AttributeNumberList2)
				if AttCnt>=5 then 
				   AttCnt = 5 
				end
				
				if AttCnt<1 then 
				   AttCnt = 1 
				end
---���δ�����;������Ե�id			
				if equip_mask>0 and equip_mask<2 then
		Tempattt_size = table.getn(AttributeLib5)
				for i=1,Tempattt_size do
   					Tempatt[i] = AttributeLib5[i]        
				end
   			   for i=1,AttCnt do
						   a[i]=GetId(Tempatt)
						   Tempatt[a[i]]=0
				   end
				
				elseif equip_mask>=2 and equip_mask<4 then
				   Tempattt_size = table.getn(AttributeLib6)
				for i=1,Tempattt_size do
   					Tempatt[i] = AttributeLib6[i]        
				end
   			   for i=1,AttCnt do
						   a[i]=GetId(Tempatt)
						   Tempatt[a[i]]=0
				   end
				
				elseif equip_mask>=4 and equip_mask<8 then
					 Tempattt_size = table.getn(AttributeLib7)
				for i=1,Tempattt_size do
   					Tempatt[i] = AttributeLib7[i]        
				end
   			   for i=1,AttCnt do
						   a[i]=GetId(Tempatt)
						   Tempatt[a[i]]=0
				   end
				
				elseif equip_mask>=8 and equip_mask<9 then
					 Tempattt_size = table.getn(AttributeLib8)
				for i=1,Tempattt_size do
   					Tempatt[i] = AttributeLib8[i]        
				end
   			   for i=1,AttCnt do
						   a[i]=GetId(Tempatt)
						   Tempatt[a[i]]=0
				   end
				
				end
---��þ������Ե�ֵ
      for i=1,AttCnt do
					b[i] = GetGrade(Proplevel)
			end
---ÿ�����Ե�С������ֵ
			for i=1,AttCnt do
					d[i] = math.random(1,10)*0.1
			end
---��ø����Եľ���ֵ
    	for i=1,AttCnt do
     			c[i] = LevelsValue1[a[i]]*(b[i]+d[i])
    	end		
    end
    
 ---�����������
    for i=1,AttCnt do
						j = j + Propweight[a[i]]*(b[i]+d[i])
				end
		astrology:SetScore(math.floor(j*5) + AttCnt*8)

---�����������ֵ
    astrology:SetEnergyConsume(math.floor(j*0.1)+1)		

---����Ԫ�������id��ֵ����λ������С��				
     			for i=1,AttCnt do
     					astrology:SetProp(i-1,a[i],c[i])
     			end       
    end 
    
		
		
		