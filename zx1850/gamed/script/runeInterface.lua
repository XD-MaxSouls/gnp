


------------------------------------------------------------------------------------------------------
-- Ԫ��ű�
-- �������нű���Ԫ��ϵͳ��صĹ���ʱ���Ե���



-------------------------------------Ԫ��������ݽṹ------------------------------------------------------
----1��ID
----2���ȼ�
----3��ʣ�ྭ��
----4��Ʒ������
----5������1��ID
----6������1�ľ���ֵ
----7������2��ID
----8������2�ľ���ֵ
----9������3��ID
---10������3�ľ���ֵ
---11������4��ID
---12������4�ľ���ֵ
---13������5��ID
---14������5�ľ���ֵ
---15������6��ID
---16������6�ľ���ֵ
---17������7��ID
---18������7�ľ���ֵ
---19������8��ID
---20������8�ľ���ֵ
---21������1�ĵ�λ����洢��
---22������1��С��λ����洢��
---23������2�ĵ�λ����洢��
---24������2��С��λ����洢��
---25������3�ĵ�λ����洢��
---26������3��С��λ����洢��
---27������4�ĵ�λ����洢��
---28������4��С��λ����洢��
---29������5�ĵ�λ����洢��
---30������5��С��λ����洢��
---31������6�ĵ�λ����洢��
---32������6��С��λ����洢��
---33������7�ĵ�λ����洢��
---34������7��С��λ����洢��
---35������8�ĵ�λ����洢��
---36������8��С��λ����洢��
---37��ϴ����������洢��
---38����Ԫ��������洢��
---39��ƽ����λ����洢��
---40�����ã���洢��
---41�����ã���洢��
---42�����ã���洢��
---43�����ã���洢��
---44�����ã���洢��
---45�����ã���洢��
---46�����ã���洢��
---47�����ã���洢��
---48�����ã���洢��

-----------------------------------------------------------------------------------------------------------



--Ԫ�����Գ�ʼ��
---------------------------------------------------------------------------------------------------- 

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

-----------------------------------------------Ԫ�����������-------------------------------------------------
----------------------------------------------------------------------------------------------------------------
---Լ������ز�����id��
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
---id��ԪӤid��score����ֵ̥��c_type�����������
function RuneInit(id, rune,score,c_type)

    ---���Գ�1���ʷֲ�(ÿ��10��)
    local AttributeLib = 
    			{
   				1400,1600,1000,1000,3000,2800,500,400,300,200,
   				200,300,200,400,400,400,400,400,400,800,
   				100,900,900,900,900,900,0,
    			}
    ---���Գ�2���ʷֲ�(ÿ��10��)
    local AttributeLib2 =
    			{
    			1500,1700,1000,1200,3200,3000,500,400,300,200,
   				200,300,200,400,400,400,400,400,400,800,
   				100,900,900,900,900,900,0,100,200,300,
   				300,400,100,

    			}
        ---��ʼ��λ���ʷֲ�(ÿ��10��)
    local AttributeGrades =
    			{
    			5000,2500,1200,500,300,200,150,120,90,80,
    			70,40,30,15,10,8,6,4,2,1,
    			}  
    ---������Ŀ�ĸ��ʷֲ���2����8����
    local AttributeNumberList =
    			{
    			500,700,600,150,45,4,1,
    			--1,1,1,1,1,1,10000,
    			}
    ---���Գ���ÿ�����Եĵ�λֵ(��Ӧ�����id�ţ����Գ���33������)
    local GradesValue =
    			{
    			2800,3200,330,190,40,30,
    			40,30,800,14,90,16,
    			110,30,30,30,30,30,
    			30,130,16,30,30,30,
    			30,30,10,20,30,30,
    			40,30,40,
    			}
    ---��������3���ĸ��ʷֲ�
    local AttExtraCnt1 =
    			{
    			1200,600,150,45,4,1,
    			}
    ---��������4���ĸ��ʷֲ�
    local AttExtraCnt2 =
    			{
    			1800,150,45,4,1,
    			}
    ---��������5���ĸ��ʷֲ�
    local AttExtraCnt3 =
    			{
    			1950,45,4,1,
    			}
    ---��������6���ĸ��ʷֲ�
    local AttExtraCnt4 =
    			{
    			1995,4,1,
    			}
		
-------------------------------------------------------------------------------------------------------------
---���������Ŀ����

		function GetNumerList(s2)
				local k = 2
				k = ZLottery_Get_RanPoint(s2) + 1
				return k
		end
		
---������Ե�id

		function GetId(s1)
				local	k1 = 1
				k1 = ZLottery_Get_RanPoint(s1)
				return k1
		end
		
---������Եĵ�λ

		function GetGrade(s1)
				local	k1 = 1
				k1 = ZLottery_Get_RanPoint(s1)
				return k1
		end
				
	
				
		
---��ø�������ֵ
		local AttCnt
		local i
		local j = 0
		local	a={}
		local b={}
		local c={}
		local d={}
		local Att = {}
		local Att1 = {}
		
		local num = 0
		if c_type == 0 then
				if score<2001 then
						AttCnt = GetNumerList(AttributeNumberList)
				elseif score>2000 and score<10001 then
						AttCnt = GetNumerList(AttExtraCnt1) + 1
				elseif score>10000 and score<60001 then
						AttCnt = GetNumerList(AttExtraCnt2) + 2
				elseif score>60000 and score<200001 then
						AttCnt = GetNumerList(AttExtraCnt3) + 3
				elseif score>200000  then
						AttCnt = GetNumerList(AttExtraCnt4) + 4
				end
		elseif c_type == 1 then
				AttCnt = 5	
		elseif c_type == 2 then
				AttCnt = 6
		elseif c_type == 3 then
				AttCnt = 8
		elseif c_type == 4 then
				AttCnt = 8
		end
---���Ԫ������id����Ϊ2�����
---һ��Ϊ����4�����ԣ�ǰ4��������1�����Կ⣬����4����������2�ſ�
---��һ��ΪС��4�����ԣ�ֻ��1�ſ�		
		if AttCnt > 1 then  
		if 	AttCnt>4 then
		local Att_size1 = table.getn(AttributeLib2)
		local Att_size = table.getn(AttributeLib)
				for i=1,Att_size1 do
   					Att1[i] = AttributeLib2[i]        
				end
				for i=1,Att_size do
   					Att[i] = AttributeLib[i]        
				end		
				for i=1,4 do
						a[i]=GetId(Att1)
						Att1[a[i]] = 0
				end		
				for i=5,AttCnt do
						a[i]=GetId(Att)
						Att[a[i]] = 0
				end
		elseif AttCnt<=4 then		
		local Att_size = table.getn(AttributeLib)
				for i=1,Att_size do
   					Att[i] = AttributeLib[i]        
				end
				for i=1,AttCnt do
						a[i]=GetId(Att)
						Att[a[i]] = 0
				end
		end
---������е����Ե�λ		
			for i=1,AttCnt do
					b[i] = GetGrade(AttributeGrades)
			end
---ÿ�����Ե�С������ֵ
			for i=1,AttCnt do
					d[i] = math.random(1,10)*0.1
			end
---��ø����Եľ���ֵ
    	for i=1,AttCnt do
     			c[i] = GradesValue[a[i]]*(b[i]+d[i])
    	end


---���ƽ���ȼ�
				for i=1,AttCnt do
						j = j + b[i]
				end
				rune:SetAvgGrade(math.floor(j/AttCnt))
---����Ԫ�������
				rune:SetQuality(AttCnt*5+math.floor(j/AttCnt)*3)  
---����Ԫ�������id��ֵ����λ������С��				
     			for i=1,AttCnt do
     					rune:SetAtt(i-1,a[i],c[i],b[i],d[i])
     			end
     			return 1
     	else return 0   
     	end  
		

	    
end
---------------------------------------------------------------------------------------------------------------------
---------------------------------------------------Ԫ���Ԫ����---------------------------------------------------
function RuneReset(id, rune,score)
    ---���Գ�1���ʷֲ�(ÿ��10��)
    local AttributeLib = 
    			{
   				1400,1600,1000,1000,3000,2800,500,400,300,300,
   				200,300,300,400,400,400,400,400,400,800,
   				100,900,900,900,900,900,0,
    			}
    ---���Գ�2���ʷֲ�(ÿ��10��)
    local AttributeLib2 =
    			{
    			1500,1700,1000,1200,3200,3000,500,400,300,200,
   				200,300,200,400,400,400,400,400,400,800,
   				100,900,900,900,900,900,0,100,200,300,
   				300,400,100,

    			}

    ---���Գ�3�ĸ��ʷֲ�(���ڵ�̥����5����ǰ4������)
    local AttributeLib3 = 
    			{
   				1400,1600,1000,1000,3000,0,500,400,300,300,
   				200,300,300,400,400,400,400,400,400,800,
   				100,900,900,900,900,900,0,
    			}  
    ---���Գ�4�ĸ��ʷֲ������ڵ�̥����5���ĺ�4�����ԣ�
    local AttributeLib4 =
    			{
    			1400,1600,1000,1000,3000,0,500,400,300,300,
   				200,300,300,400,400,400,400,400,400,800,
   				100,900,900,900,900,900,0,100,300,300,
   				400,300,100,

    			}    			
    ---���Գ�5�ĸ��ʷֲ�(���ڵ�̥����6����ǰ4������)
    local AttributeLib5 = 
    			{
   				1400,1600,1000,1000,0,0,500,400,300,300,
   				200,300,300,400,400,400,400,400,400,800,
   				100,900,900,900,900,900,0,
    			}  
    ---���Գ�6�ĸ��ʷֲ������ڵ�̥����6���ĺ�4�����ԣ�
    local AttributeLib6 =
    			{
    			1400,1600,1000,1000,0,0,500,400,300,300,
   				200,300,300,400,400,400,400,400,400,800,
   				100,900,900,900,900,900,0,100,300,300,
   				400,300,100,

    			} 
    ---��ʼ��λ���ʷֲ�(ÿ��10��)
    local AttributeGrades =
    			{
    			5000,2500,1200,500,300,200,150,120,90,80,
    			70,40,30,15,10,8,6,4,2,1,
    			}  
    ---������Ŀ�ĸ��ʷֲ���2����8����
    local AttributeNumberList =
    			{
    			500,700,600,150,45,4,1,
    			--1,1,1,1,1,1,10000,
    			}
    ---��������3���ĸ��ʷֲ�
    local AttExtraCnt1 =
    			{
    			1200,600,150,45,4,1,
    			}
    ---��������4���ĸ��ʷֲ�
    local AttExtraCnt2 =
    			{
    			1800,150,45,4,1,
    			}
    ---��������5���ĸ��ʷֲ�
    local AttExtraCnt3 =
    			{
    			1950,45,4,1,
    			}
    ---��������6���ĸ��ʷֲ�
    local AttExtraCnt4 =
    			{
    			1995,4,1,
    			}
    ---���Գ���ÿ�����Եĵ�λֵ(��Ӧ�����id�ţ����Գ���33������)
    local GradesValue =
    			{
    			2800,3200,330,190,40,30,
    			40,30,800,14,90,16,
    			110,30,30,30,30,30,
    			30,130,16,30,30,30,
    			30,30,10,20,30,30,
    			40,30,40,
    			}

---���������Ŀ����

		function GetNumerList(s2)
				local k = 2
				k = ZLottery_Get_RanPoint(s2) + 1
				return k
		end
		
---������Ե�id

		function GetId(s1)
				local	k1 = 1
				k1 = ZLottery_Get_RanPoint(s1)
				return k1
		end
		
---������Եĵ�λ

		function GetGrade(s1)
				local	k1 = 1
				k1 = ZLottery_Get_RanPoint(s1)
				return k1
		end
---��������Ԫ��ԭ���ĸ���������ֵΪ0		
     			for i=1,8 do
     					rune:SetAtt(i-1,0,0,0,0)
     			end
		
---��ø�������ֵ
		local AttCnt
		local i
		local j = 0
		local	a={}
		local b={}
		local c={}
		local d={}
		local Att = {}
		local Att1 = {}
		
		local num = 0
		if score<2001 then
				AttCnt = GetNumerList(AttributeNumberList)
		elseif score>2000 and score<10001 then
				AttCnt = GetNumerList(AttExtraCnt1) + 1
		elseif score>10000 and score<60001 then
				AttCnt = GetNumerList(AttExtraCnt2) + 2
		elseif score>60000 and score<200001 then
				AttCnt = GetNumerList(AttExtraCnt3) + 3
		elseif score>200000  then
				AttCnt = GetNumerList(AttExtraCnt4) + 4
		end
		
---���Ԫ������id����Ϊ2�����
---һ��Ϊ����4�����ԣ�ǰ4��������1�����Կ⣬����4����������2�ſ�
---��һ��ΪС��4�����ԣ�ֻ��1�ſ�		
		if AttCnt > 1 then  
		if 	AttCnt>4 then
		local Att_size1
		local Att_size
---�жϵ�ֵ̥ѡ�����Կ�
			if score>60000 and score<200001 then
					 Att_size1 = table.getn(AttributeLib4)
		 	     Att_size = table.getn(AttributeLib3)
				   for i=1,Att_size1 do
   					   Att1[i] = AttributeLib4[i]        
				   end
				   for i=1,Att_size do
   			    		Att[i] = AttributeLib3[i]        
				   end		
				   for i=1,4 do
						    a[i]=GetId(Att1)
						    Att1[a[i]] = 0
				   end		
				   for i=5,AttCnt do
				    		a[i]=GetId(Att)
					    	Att[a[i]] = 0
				   end					 	     
		 	     
 	     			     
			elseif score>200000  then
					 Att_size1 = table.getn(AttributeLib6)
		 	     Att_size = table.getn(AttributeLib5)		
				   for i=1,Att_size1 do
   					   Att1[i] = AttributeLib6[i]        
				   end
				   for i=1,Att_size do
   			    		Att[i] = AttributeLib5[i]        
				   end		
				   for i=1,4 do
						    a[i]=GetId(Att1)
						    Att1[a[i]] = 0
				   end		
				   for i=5,AttCnt do
				    		a[i]=GetId(Att)
					    	Att[a[i]] = 0
				   end				 	     
		 	     
	 	     	     
			else 
					 Att_size1 = table.getn(AttributeLib2)
		 	     Att_size = table.getn(AttributeLib)
				   for i=1,Att_size1 do
   					   Att1[i] = AttributeLib2[i]        
				   end
				   for i=1,Att_size do
   			    		Att[i] = AttributeLib[i]        
				   end		
				   for i=1,4 do
						    a[i]=GetId(Att1)
						    Att1[a[i]] = 0
				   end		
				   for i=5,AttCnt do
				    		a[i]=GetId(Att)
					    	Att[a[i]] = 0
				   end		 	     
		 	     	 	     
			end


		elseif AttCnt<=4 then		
		local Att_size = table.getn(AttributeLib)
				for i=1,Att_size do
   					Att[i] = AttributeLib[i]        
				end
				for i=1,AttCnt do
						a[i]=GetId(Att)
						Att[a[i]] = 0
				end
		end
---������е����Ե�λ		
			for i=1,AttCnt do
					b[i] = GetGrade(AttributeGrades)
			end
---ÿ�����Ե�С������ֵ
			for i=1,AttCnt do
					d[i] = math.random(1,10)*0.1
			end
---��ø����Եľ���ֵ
    	for i=1,AttCnt do
     			c[i] = GradesValue[a[i]]*(b[i]+d[i])
    	end


---���ƽ���ȼ�
				for i=1,AttCnt do
						j = j + b[i]
				end
				rune:SetAvgGrade(math.floor(j/AttCnt))
---����Ԫ�������
				rune:SetQuality(AttCnt*5+math.floor(j/AttCnt)*3)  
---����Ԫ�������id��ֵ����λ������С��				
     			for i=1,AttCnt do
     					rune:SetAtt(i-1,a[i],c[i],b[i],d[i])
     			end
     			return 1
     	else return 0   
     	end  
    
    			   			
end
---------------------------------------------------------------------------------------------------------------------
----------------------------------------------------Ԫ������ϴ��-----------------------------------------------------
function RuneRefine(id, rune,score)
	local GradesValue =
    			{
    			2800,3200,330,190,40,30,
    			40,30,800,14,90,16,
    			110,30,30,30,30,30,
    			30,130,16,30,30,30,
    			30,30,10,20,30,30,
    			40,30,40,
    			}
	local UpperList={}
		UpperList[0]={30,35,35}	
		UpperList[1]={31,35,34}	
		UpperList[2]={32,35,33}		
		UpperList[3]={33,35,32}	
		UpperList[4]={34,35,31}	
		UpperList[5]={35,30,30}		
		UpperList[6]={36,30,28}	
		UpperList[7]={37,30,27}	
		UpperList[8]={38,30,25}	
		UpperList[9]={40,30,23}	
		UpperList[10]={42,30,22}	
		UpperList[11]={43,30,21}
		UpperList[12]={44,30,20}	
		UpperList[13]={45,27,18}	
		UpperList[14]={46,27,16}	
		UpperList[15]={47,27,15}	
		UpperList[16]={48,27,14}	
		UpperList[17]={49,25,13}	
		UpperList[18]={50,25,12}	
		UpperList[19]={55,25,11}
			
	local quality,avg,AttCnt
	local i,j,k
	local CurrentGrades = {}
	local GradeRandom
	local a={}
	local b={}
	local c={}
	local d={}

	quality = rune:QueryQuality()
	avg = rune:GetAvgGrade()
	AttCnt = rune:GetAttCnt()

	
	
	if avg ==0 then avg = 1 end
	if avg>0 and AttCnt>0 then 
			for i=1,3 do
					CurrentGrades[i] = UpperList[avg][i]
			end
	

			for i=1,AttCnt do
			--id��ֵ����λ��С��ֵ
					a[i],b[i],c[i],d[i]=rune:GetAtt(i-1)
			----����λ��15������ʱ�����⴦����ֹ��һ������������
					if c[i] > 14 and (c[i]-avg) > 4 then
							for i=1,3 do
									CurrentGrades[i] = UpperList[avg+4][i]
							end	
					end
			----------------------------------------------------------
					GradeRandom = ZLottery_Get_RanPoint(CurrentGrades)
					
					if GradeRandom == 1 then
							if c[i] == 1 or c[i]== 0 then
									c[i] = 1
									d[i] = math.random(1,10)*0.1
									b[i] = GradesValue[a[i]]*(c[i]+d[i])
									rune:SetRefineAtt(i-1,a[i],b[i],c[i],d[i])	
							elseif c[i] >1 then
									c[i] = c[i] - 1
									d[i] = math.random(1,10)*0.1
									b[i] = GradesValue[a[i]]*(c[i]+d[i])
									rune:SetRefineAtt(i-1,a[i],b[i],c[i],d[i])
							end
					elseif GradeRandom == 2 then
							if  c[i]== 0 then
									c[i] = 1
									d[i] = math.random(1,10)*0.1
									b[i] = GradesValue[a[i]]*(c[i]+d[i])
									rune:SetRefineAtt(i-1,a[i],b[i],c[i],d[i])
							elseif c[i] >0 then
									rune:SetRefineAtt(i-1,a[i],b[i],c[i],d[i])						
							end
							
					elseif GradeRandom == 3 then
							if c[i] < 20 and c[i] >= 0 then 
									c[i] = c[i] + 1
									d[i] = math.random(1,10)*0.1
									b[i] = GradesValue[a[i]]*(c[i]+d[i])
									rune:SetRefineAtt(i-1,a[i],b[i],c[i],d[i])
							elseif c[i] == 20 then
									d[i] = math.random(1,10)*0.1
									b[i] = GradesValue[a[i]]*(c[i]+d[i])
									rune:SetRefineAtt(i-1,a[i],b[i],c[i],d[i])
							end						
					end
			end
	end
	j=0
	for i=1,AttCnt do
		j=j+c[i]
	end
	avg=math.floor(j/AttCnt)
	rune:SetAvgGrade(avg)
	quality = avg*3+AttCnt*5 
	rune:SetRefineQuality(quality)
	return 1
	
	
end

---------------------------------------------------------------------------------------------------------------------
-----------------------------------------------------Ԫ��ֽ�--------------------------------------------------------
function RuneDecompose(id, rune,score)
	local level,quality,value
	level = rune:QueryLevel()
	quality =rune:QueryQuality()
	value = quality + math.random(0,20)
	if level >9 then
		if value < 86 and value > 0 then return 52248
		elseif value < 106 and value > 85 then return 52249
		elseif value < 118 and value > 105 then return 52251
		elseif value > 117  then return 52252
		end
	else return 0
	end
end

