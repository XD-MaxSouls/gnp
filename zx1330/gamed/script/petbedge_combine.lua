---�������е������������߹���----------------------------------------------------------------------
function ZLuaPetBedgeAidMatrix()
	local AidMatrix={}
		---//type=0:��Ҫ�����������ʺ�Ч������
		---//effect1:�ɹ���������,effect2:ʹ��Ч������,�Ƿ�������
		AidMatrix[16322]={effect1=25,effect2=0,type=0}
		AidMatrix[16323]={effect1=0,effect2=0.30,type=0}
		
		---//type=1:������������
		---//effect1:�������ɵļ�������
		AidMatrix[22393]={effect1=7,effect2=0.30,type=1}
		
		AidMatrix[0]={effect1=0,effect2=0,effect3=99}
	return AidMatrix
end 
-----�������е������õ��߹���----------------------------------------------------------------------
function ZLuaPetBedgeCidMatrix()
	local Horoscope=ZLuaPetBedgeHoroscopeDesc()
	local Race=ZLuaPetBedgeRaceDesc()
	local CidMatrix={}
		---//type=1	 	��������
		---//type=2	 	��������,effect1
		---//type=3		�ı�����,effect1(����������)
		---//type=4		�ı�����,effect1(����������)
		---//type=5	 	�����������(�Ը�),effect1(1-6�ֱ���������Ը�,7�������)
		---//type=6	 	����ı��츳,effect1(1-15�ֱ�������㡢����ͱ���)
		---//type=7	 	����ѧϰ����,effect1(λ��(1-10�̶�λ��,13���λ��),effect2����,effect3,���ܼ���,
		---//	effect4 ��������,effect5,����ְҵ,effect6,������̬,effect7,����id)
		---//type=7	 	����ѧϰ����,effect1(�ʺ�ְҵ0-8,99ͨ��),effect2(����ָ��id),effect3(׷�Ӽ��ܼ���)
		---//					effect4(�����ɹ�����>100,ʵ�ʳɹ���Ϊeffect4-���弶��),effect5,�������ǵ�)
		---//	effect4 ��������,effect5,����ְҵ,effect6,������̬,effect7,����id)	
		---//type=8	 	������������,effect1(λ��)
		---//type=9	 	�����������ܶȵ�ǰֵ,effect1(������ֵ)��effect2(���ӵ����޵ı���<=1)
		---//type=10	�����������ܶ�����,effect1(��ֵ)
		---//type=11	�������Գɳ�(��Ѫ),effect1(����1-100),effect2(����ֵ),effect3(MaxstarCanUse)
		---//type=12	�������Գɳ�(����),effect1(����1-100),effect2(����ֵ),effect3(MaxstarCanUse)
		---//type=13	�������Գɳ�(��С����),effect1(����1-100),effect2(����ֵ),effect3(MaxstarCanUse)
		---//type=14	�������Գɳ�(��󹥻�),effect1(����1-100),effect2(����ֵ),effect3(MaxstarCanUse)
		---//type=15	�������Գɳ�(ͨ�ù���),effect1(����1-100),effect2(����ֵ),effect3(MaxstarCanUse)
		---//type=16	�������Գɳ�(����),effect1(����1-100),effect2(����ֵ),effect3(MaxstarCanUse)
		---//type=17	�������Գɳ�(����),effect1(����1-100),effect2(����ֵ),effect3(MaxstarCanUse)
		---//type=18	�������Գɳ�(����),effect1(����1-100),effect2(����ֵ),effect3(MaxstarCanUse)
		---//type=19	�������Գɳ�(ѣ��),effect1(����1-100),effect2(����ֵ),effect3(MaxstarCanUse)
		---//type=20	�������Գɳ�(����),effect1(����1-100),effect2(����ֵ),effect3(MaxstarCanUse)
		---//type=21	�������Գɳ�(����),effect1(����1-100),effect2(����ֵ),effect3(MaxstarCanUse)
		---//type=22	�������Գɳ�(�Ȼ�),effect1(����1-100),effect2(����ֵ),effect3(MaxstarCanUse)
		---//type=23	�������Գɳ�(��˯),effect1(����1-100),effect2(����ֵ),effect3(MaxstarCanUse)
		---//type=24	�������Գɳ�(����),effect1(����1-100),effect2(����ֵ),effect3(MaxstarCanUse)
		---//type=25	���ս�����Գɳ�(ÿ������)
		---//type11-25 effect4/effect5/effect6Ϊ�ڶ�����ֵ(ʹ��aid�ı����ɳ�),effect7Ϊʧ�ܱ����ɳ�
		---//type=26	�������Գɳ�����1,effect1(����1-100),effect2(����ֵ),effect3(MaxstarCanUse)
		---//type=27	�������Գɳ�����2,effect1(����1-100),effect2(����ֵ),effect3(MaxstarCanUse)
		---//type=28	�������Գɳ�����3,effect1(����1-100),effect2(����ֵ),effect3(MaxstarCanUse)
		---//type=29	�������Գɳ�����4,effect1(����1-100),effect2(����ֵ),effect3(MaxstarCanUse)
		---//type=30	�������Գɳ�����5,effect1(����1-100),effect2(����ֵ),effect3(MaxstarCanUse)
		---//type=31	�������Գɳ�����6,effect1(����1-100),effect2(����ֵ),effect3(MaxstarCanUse)
		---//type=32	�ı�������(�޽�)
		---//type=33	����ı�ҩ��
		---//type=34	�������ҩ��
		---//type=35  ����۲�ҩ��(������)
		---//type=36 	�ı��ֻ�
		---//type=37	���ﶷ������
		---//type=38	��������ǿ��(��Եר��effect1(����1-����2-����3-���)effect2(�ȼ�))
			
		---//Ԥ������
		CidMatrix[16302]={type=1,effect1=0,effect2=0,effect3=0,effect4=0,effect5=0,effect6=0,effect7=0}		
		CidMatrix[31246]={type=1,effect1=0,effect2=0,effect3=0,effect4=0,effect5=0,effect6=0,effect7=0}
		---//��������
		CidMatrix[16303]={type=2,effect1=0,effect2=0,effect3=0,effect4=0,effect5=0,effect6=0,effect7=0}	
		---//�ı�����
		CidMatrix[16304]={type=3,effect1=100,effect2=0,effect3=0,effect4=0,effect5=0,effect6=0,effect7=0}			
		CidMatrix[16305]={type=3,effect1=500,effect2=0,effect3=0,effect4=0,effect5=0,effect6=0,effect7=0}	
		CidMatrix[16306]={type=3,effect1=2000,effect2=0,effect3=0,effect4=0,effect5=0,effect6=0,effect7=0}	
		---//�ı�����
		CidMatrix[16315]={type=4,effect1=100,effect2=0,effect3=0,effect4=0,effect5=0,effect6=0,effect7=0}			
		CidMatrix[16316]={type=4,effect1=500,effect2=0,effect3=0,effect4=0,effect5=0,effect6=0,effect7=0}	
		CidMatrix[16317]={type=4,effect1=2000,effect2=0,effect3=0,effect4=0,effect5=0,effect6=0,effect7=0}	
		---//�Ը�ı�
		CidMatrix[18371]={type=5,effect1=99,effect2=0,effect3=0,effect4=0,effect5=0,effect6=0,effect7=0}
		CidMatrix[18370]={type=5,effect1=0,effect2=0,effect3=0,effect4=0,effect5=0,effect6=0,effect7=0}
		CidMatrix[16320]={type=5,effect1=1,effect2=0,effect3=0,effect4=0,effect5=0,effect6=0,effect7=0}	
		CidMatrix[16326]={type=5,effect1=2,effect2=0,effect3=0,effect4=0,effect5=0,effect6=0,effect7=0}	
		CidMatrix[16327]={type=5,effect1=3,effect2=0,effect3=0,effect4=0,effect5=0,effect6=0,effect7=0}	
		CidMatrix[16328]={type=5,effect1=4,effect2=0,effect3=0,effect4=0,effect5=0,effect6=0,effect7=0}	
		CidMatrix[16329]={type=5,effect1=5,effect2=0,effect3=0,effect4=0,effect5=0,effect6=0,effect7=0}	
		CidMatrix[16330]={type=5,effect1=6,effect2=0,effect3=0,effect4=0,effect5=0,effect6=0,effect7=0}	
		CidMatrix[16331]={type=5,effect1=7,effect2=0,effect3=0,effect4=0,effect5=0,effect6=0,effect7=0}	
		---//�츳�ı�
		CidMatrix[16311]={type=6,effect1=1,effect2=0,effect3=0,effect4=0,effect5=0,effect6=0,effect7=0}			
		CidMatrix[16312]={type=6,effect1=2,effect2=0,effect3=0,effect4=0,effect5=0,effect6=0,effect7=0}
		CidMatrix[16332]={type=6,effect1=3,effect2=0,effect3=0,effect4=0,effect5=0,effect6=0,effect7=0}	
		CidMatrix[16333]={type=6,effect1=4,effect2=0,effect3=0,effect4=0,effect5=0,effect6=0,effect7=0}
		CidMatrix[16334]={type=6,effect1=5,effect2=0,effect3=0,effect4=0,effect5=0,effect6=0,effect7=0}
		CidMatrix[16335]={type=6,effect1=6,effect2=0,effect3=0,effect4=0,effect5=0,effect6=0,effect7=0}
		CidMatrix[16336]={type=6,effect1=7,effect2=0,effect3=0,effect4=0,effect5=0,effect6=0,effect7=0}
		CidMatrix[16337]={type=6,effect1=8,effect2=0,effect3=0,effect4=0,effect5=0,effect6=0,effect7=0}
		CidMatrix[16338]={type=6,effect1=9,effect2=0,effect3=0,effect4=0,effect5=0,effect6=0,effect7=0}
		CidMatrix[16339]={type=6,effect1=10,effect2=0,effect3=0,effect4=0,effect5=0,effect6=0,effect7=0}
		CidMatrix[16340]={type=6,effect1=11,effect2=0,effect3=0,effect4=0,effect5=0,effect6=0,effect7=0}
		CidMatrix[16341]={type=6,effect1=12,effect2=0,effect3=0,effect4=0,effect5=0,effect6=0,effect7=0}
		CidMatrix[16342]={type=6,effect1=13,effect2=0,effect3=0,effect4=0,effect5=0,effect6=0,effect7=0}
		CidMatrix[16343]={type=6,effect1=14,effect2=0,effect3=0,effect4=0,effect5=0,effect6=0,effect7=0}
		CidMatrix[16344]={type=6,effect1=15,effect2=0,effect3=0,effect4=0,effect5=0,effect6=0,effect7=0}
		
		---//��������
		CidMatrix[19356]={type=7,effect1=0,effect2=1399,effect3=1,effect4=300,effect5=0,effect6=0,effect7=0}---//�ػ�<����>
		CidMatrix[19357]={type=7,effect1=0,effect2=1400,effect3=1,effect4=300,effect5=0,effect6=0,effect7=0}---//�ȳ�<����>
		CidMatrix[19358]={type=7,effect1=0,effect2=1401,effect3=1,effect4=300,effect5=0,effect6=0,effect7=0}---//��ҫ<����>
		CidMatrix[19359]={type=7,effect1=0,effect2=1402,effect3=1,effect4=300,effect5=0,effect6=0,effect7=0}---//���<����>
		CidMatrix[19360]={type=7,effect1=0,effect2=1403,effect3=1,effect4=300,effect5=0,effect6=0,effect7=0}---//���<����>
		CidMatrix[19361]={type=7,effect1=0,effect2=1404,effect3=1,effect4=300,effect5=0,effect6=0,effect7=0}---//����<����>
		CidMatrix[19362]={type=7,effect1=1,effect2=1405,effect3=1,effect4=300,effect5=0,effect6=0,effect7=0}---//����<����>
		CidMatrix[19363]={type=7,effect1=1,effect2=1406,effect3=1,effect4=300,effect5=0,effect6=0,effect7=0}---//����<����>
		CidMatrix[19364]={type=7,effect1=1,effect2=1407,effect3=1,effect4=300,effect5=0,effect6=0,effect7=0}---//��ע<����>
		CidMatrix[19365]={type=7,effect1=1,effect2=1408,effect3=1,effect4=300,effect5=0,effect6=0,effect7=0}---//����<����>
		CidMatrix[19366]={type=7,effect1=1,effect2=1409,effect3=1,effect4=300,effect5=0,effect6=0,effect7=0}---//��Ӱ<����>
		CidMatrix[19367]={type=7,effect1=1,effect2=1410,effect3=1,effect4=300,effect5=0,effect6=0,effect7=0}---//ˮ��<����>
		CidMatrix[19368]={type=7,effect1=2,effect2=1411,effect3=1,effect4=300,effect5=0,effect6=0,effect7=0}---//â��<����>
		CidMatrix[19369]={type=7,effect1=2,effect2=1412,effect3=1,effect4=300,effect5=0,effect6=0,effect7=0}---//ŭ��<����>
		CidMatrix[19370]={type=7,effect1=2,effect2=1413,effect3=1,effect4=300,effect5=0,effect6=0,effect7=0}---//ȫ��<����>
		CidMatrix[19371]={type=7,effect1=2,effect2=1414,effect3=1,effect4=300,effect5=0,effect6=0,effect7=0}---//˺��<����>
		CidMatrix[19372]={type=7,effect1=2,effect2=1415,effect3=1,effect4=300,effect5=0,effect6=0,effect7=0}---//�̶�<����>
		CidMatrix[19373]={type=7,effect1=2,effect2=1416,effect3=1,effect4=300,effect5=0,effect6=0,effect7=0}---//����<����>
		CidMatrix[19374]={type=7,effect1=3,effect2=1417,effect3=1,effect4=300,effect5=0,effect6=0,effect7=0}---//����<ľ��>
		CidMatrix[19375]={type=7,effect1=3,effect2=1418,effect3=1,effect4=300,effect5=0,effect6=0,effect7=0}---//����<ľ��>
		CidMatrix[19376]={type=7,effect1=3,effect2=1419,effect3=1,effect4=300,effect5=0,effect6=0,effect7=0}---//�ͻ�<ľ��>
		CidMatrix[19377]={type=7,effect1=3,effect2=1420,effect3=1,effect4=300,effect5=0,effect6=0,effect7=0}---//����<ľ��>
		CidMatrix[19378]={type=7,effect1=3,effect2=1421,effect3=1,effect4=300,effect5=0,effect6=0,effect7=0}---//�<ľ��>
		CidMatrix[19379]={type=7,effect1=3,effect2=1422,effect3=1,effect4=300,effect5=0,effect6=0,effect7=0}---//ƣ��<ľ��>
		CidMatrix[19380]={type=7,effect1=4,effect2=1423,effect3=1,effect4=300,effect5=0,effect6=0,effect7=0}---//��Ȫ<ˮ��>
		CidMatrix[19381]={type=7,effect1=4,effect2=1424,effect3=1,effect4=300,effect5=0,effect6=0,effect7=0}---//����<ˮ��>
		CidMatrix[19382]={type=7,effect1=4,effect2=1425,effect3=1,effect4=300,effect5=0,effect6=0,effect7=0}---//Ԥ��<ˮ��>
		CidMatrix[19383]={type=7,effect1=4,effect2=1426,effect3=1,effect4=300,effect5=0,effect6=0,effect7=0}---//����<ˮ��>
		CidMatrix[19384]={type=7,effect1=4,effect2=1427,effect3=1,effect4=300,effect5=0,effect6=0,effect7=0}---//����<ˮ��>
		CidMatrix[19385]={type=7,effect1=4,effect2=1428,effect3=1,effect4=300,effect5=0,effect6=0,effect7=0}---//˼��<ˮ��>
		CidMatrix[19386]={type=7,effect1=5,effect2=1429,effect3=1,effect4=300,effect5=0,effect6=0,effect7=0}---//���<����>
		CidMatrix[19387]={type=7,effect1=5,effect2=1430,effect3=1,effect4=300,effect5=0,effect6=0,effect7=0}---//��ͨ<����>
		CidMatrix[19388]={type=7,effect1=5,effect2=1431,effect3=1,effect4=300,effect5=0,effect6=0,effect7=0}---//����<����>
		CidMatrix[19389]={type=7,effect1=5,effect2=1432,effect3=1,effect4=300,effect5=0,effect6=0,effect7=0}---//����<����>
		CidMatrix[19390]={type=7,effect1=5,effect2=1433,effect3=1,effect4=300,effect5=0,effect6=0,effect7=0}---//���<����>
		CidMatrix[19391]={type=7,effect1=5,effect2=1434,effect3=1,effect4=300,effect5=0,effect6=0,effect7=0}---//ȼ��<����>
		CidMatrix[19392]={type=7,effect1=6,effect2=1435,effect3=1,effect4=300,effect5=0,effect6=0,effect7=0}---//��ף<����>
		CidMatrix[19393]={type=7,effect1=6,effect2=1436,effect3=1,effect4=300,effect5=0,effect6=0,effect7=0}---//����<����>
		CidMatrix[19394]={type=7,effect1=6,effect2=1437,effect3=1,effect4=300,effect5=0,effect6=0,effect7=0}---//�˺�<����>
		CidMatrix[19395]={type=7,effect1=6,effect2=1438,effect3=1,effect4=300,effect5=0,effect6=0,effect7=0}---//׷��<����>
		CidMatrix[19396]={type=7,effect1=6,effect2=1439,effect3=1,effect4=300,effect5=0,effect6=0,effect7=0}---//����<����>
		CidMatrix[19397]={type=7,effect1=6,effect2=1440,effect3=1,effect4=300,effect5=0,effect6=0,effect7=0}---//�ݵ�<����>
		CidMatrix[19398]={type=7,effect1=7,effect2=1441,effect3=1,effect4=300,effect5=0,effect6=0,effect7=0}---//����<�޺�>
		CidMatrix[19399]={type=7,effect1=7,effect2=1442,effect3=1,effect4=300,effect5=0,effect6=0,effect7=0}---//����<�޺�>
		CidMatrix[19400]={type=7,effect1=7,effect2=1443,effect3=1,effect4=300,effect5=0,effect6=0,effect7=0}---//����<�޺�>
		CidMatrix[19401]={type=7,effect1=7,effect2=1444,effect3=1,effect4=300,effect5=0,effect6=0,effect7=0}---//����<�޺�>
		CidMatrix[19402]={type=7,effect1=7,effect2=1445,effect3=1,effect4=300,effect5=0,effect6=0,effect7=0}---//����<�޺�>
		CidMatrix[19403]={type=7,effect1=7,effect2=1446,effect3=1,effect4=300,effect5=0,effect6=0,effect7=0}---//��ʹ<�޺�>
		CidMatrix[19404]={type=7,effect1=8,effect2=1447,effect3=1,effect4=300,effect5=0,effect6=0,effect7=0}---//����<�ƶ�>
		CidMatrix[19405]={type=7,effect1=8,effect2=1448,effect3=1,effect4=300,effect5=0,effect6=0,effect7=0}---//����<�ƶ�>
		CidMatrix[19406]={type=7,effect1=8,effect2=1449,effect3=1,effect4=300,effect5=0,effect6=0,effect7=0}---//����<�ƶ�>
		CidMatrix[19407]={type=7,effect1=8,effect2=1450,effect3=1,effect4=300,effect5=0,effect6=0,effect7=0}---//����<�ƶ�>
		CidMatrix[19408]={type=7,effect1=8,effect2=1451,effect3=1,effect4=300,effect5=0,effect6=0,effect7=0}---//���<�ƶ�>
		CidMatrix[19409]={type=7,effect1=8,effect2=1452,effect3=1,effect4=300,effect5=0,effect6=0,effect7=0}---//��ã<�ƶ�>
		CidMatrix[19410]={type=7,effect1=99,effect2=1453,effect3=1,effect4=300,effect5=0,effect6=0,effect7=0}---//����<ͨ��>
		CidMatrix[19411]={type=7,effect1=99,effect2=1454,effect3=1,effect4=300,effect5=0,effect6=0,effect7=0}---//����<ͨ��>
		CidMatrix[19412]={type=7,effect1=99,effect2=1455,effect3=1,effect4=300,effect5=0,effect6=0,effect7=0}---//����<ͨ��>
		CidMatrix[19413]={type=7,effect1=99,effect2=1456,effect3=1,effect4=300,effect5=0,effect6=0,effect7=0}---//����<ͨ��>
		CidMatrix[19414]={type=7,effect1=99,effect2=1457,effect3=1,effect4=300,effect5=0,effect6=0,effect7=0}---//����<ͨ��>
		CidMatrix[19415]={type=7,effect1=99,effect2=1458,effect3=1,effect4=300,effect5=0,effect6=0,effect7=0}---//��ȡ<ͨ��>
		
		CidMatrix[23229]={type=7,effect1=0,effect2=1399,effect3=1,effect4=300,effect5=1,effect6=0,effect7=0}---//�������������ػ�<����>��
		CidMatrix[23230]={type=7,effect1=0,effect2=1400,effect3=1,effect4=300,effect5=1,effect6=0,effect7=0}---//�������������ȳ�<����>��
		CidMatrix[23231]={type=7,effect1=0,effect2=1401,effect3=1,effect4=300,effect5=1,effect6=0,effect7=0}---//��������������ҫ<����>��
		CidMatrix[23232]={type=7,effect1=0,effect2=1402,effect3=1,effect4=300,effect5=1,effect6=0,effect7=0}---//�����������񡤹��<����>��
		CidMatrix[23233]={type=7,effect1=0,effect2=1403,effect3=1,effect4=300,effect5=1,effect6=0,effect7=0}---//���������������<����>��
		CidMatrix[23234]={type=7,effect1=0,effect2=1404,effect3=1,effect4=300,effect5=1,effect6=0,effect7=0}---//����������������<����>��
		CidMatrix[23235]={type=7,effect1=1,effect2=1405,effect3=1,effect4=300,effect5=1,effect6=0,effect7=0}---//����������������<����>��
		CidMatrix[23236]={type=7,effect1=1,effect2=1406,effect3=1,effect4=300,effect5=1,effect6=0,effect7=0}---//�����������񡤻���<����>��
		CidMatrix[23237]={type=7,effect1=1,effect2=1407,effect3=1,effect4=300,effect5=1,effect6=0,effect7=0}---//�����������񡤹�ע<����>��
		CidMatrix[23238]={type=7,effect1=1,effect2=1408,effect3=1,effect4=300,effect5=1,effect6=0,effect7=0}---//����������������<����>��
		CidMatrix[23239]={type=7,effect1=1,effect2=1409,effect3=1,effect4=300,effect5=1,effect6=0,effect7=0}---//��������������Ӱ<����>��
		CidMatrix[23240]={type=7,effect1=1,effect2=1410,effect3=1,effect4=300,effect5=1,effect6=0,effect7=0}---//������������ˮ��<����>��
		CidMatrix[23241]={type=7,effect1=2,effect2=1411,effect3=1,effect4=300,effect5=1,effect6=0,effect7=0}---//������������â��<����>��
		CidMatrix[23242]={type=7,effect1=2,effect2=1412,effect3=1,effect4=300,effect5=1,effect6=0,effect7=0}---//������������ŭ��<����>��
		CidMatrix[23243]={type=7,effect1=2,effect2=1413,effect3=1,effect4=300,effect5=1,effect6=0,effect7=0}---//������������ȫ��<����>��
		CidMatrix[23244]={type=7,effect1=2,effect2=1414,effect3=1,effect4=300,effect5=1,effect6=0,effect7=0}---//������������˺��<����>��
		CidMatrix[23245]={type=7,effect1=2,effect2=1415,effect3=1,effect4=300,effect5=1,effect6=0,effect7=0}---//�����������񡤴̶�<����>��
		CidMatrix[23246]={type=7,effect1=2,effect2=1416,effect3=1,effect4=300,effect5=1,effect6=0,effect7=0}---//����������������<����>��
		CidMatrix[23247]={type=7,effect1=3,effect2=1417,effect3=1,effect4=300,effect5=1,effect6=0,effect7=0}---//����������������<ľ��>��
		CidMatrix[23248]={type=7,effect1=3,effect2=1418,effect3=1,effect4=300,effect5=1,effect6=0,effect7=0}---//����������������<ľ��>��
		CidMatrix[23249]={type=7,effect1=3,effect2=1419,effect3=1,effect4=300,effect5=1,effect6=0,effect7=0}---//�������������ͻ�<ľ��>��
		CidMatrix[23250]={type=7,effect1=3,effect2=1420,effect3=1,effect4=300,effect5=1,effect6=0,effect7=0}---//����������������<ľ��>��
		CidMatrix[23251]={type=7,effect1=3,effect2=1421,effect3=1,effect4=300,effect5=1,effect6=0,effect7=0}---//�������������<ľ��>��
		CidMatrix[23252]={type=7,effect1=3,effect2=1422,effect3=1,effect4=300,effect5=1,effect6=0,effect7=0}---//������������ƣ��<ľ��>��
		CidMatrix[23253]={type=7,effect1=4,effect2=1423,effect3=1,effect4=300,effect5=1,effect6=0,effect7=0}---//�����������񡤸�Ȫ<ˮ��>��
		CidMatrix[23254]={type=7,effect1=4,effect2=1424,effect3=1,effect4=300,effect5=1,effect6=0,effect7=0}---//�����������񡤵���<ˮ��>��
		CidMatrix[23255]={type=7,effect1=4,effect2=1425,effect3=1,effect4=300,effect5=1,effect6=0,effect7=0}---//������������Ԥ��<ˮ��>��
		CidMatrix[23256]={type=7,effect1=4,effect2=1426,effect3=1,effect4=300,effect5=1,effect6=0,effect7=0}---//�����������񡤲���<ˮ��>��
		CidMatrix[23257]={type=7,effect1=4,effect2=1427,effect3=1,effect4=300,effect5=1,effect6=0,effect7=0}---//����������������<ˮ��>��
		CidMatrix[23258]={type=7,effect1=4,effect2=1428,effect3=1,effect4=300,effect5=1,effect6=0,effect7=0}---//������������˼��<ˮ��>��
		CidMatrix[23259]={type=7,effect1=5,effect2=1429,effect3=1,effect4=300,effect5=1,effect6=0,effect7=0}---//�����������񡤻��<����>��
		CidMatrix[23260]={type=7,effect1=5,effect2=1430,effect3=1,effect4=300,effect5=1,effect6=0,effect7=0}---//�����������񡤹�ͨ<����>��
		CidMatrix[23261]={type=7,effect1=5,effect2=1431,effect3=1,effect4=300,effect5=1,effect6=0,effect7=0}---//����������������<����>��
		CidMatrix[23263]={type=7,effect1=5,effect2=1432,effect3=1,effect4=300,effect5=1,effect6=0,effect7=0}---//����������������<����>��
		CidMatrix[23264]={type=7,effect1=5,effect2=1433,effect3=1,effect4=300,effect5=1,effect6=0,effect7=0}---//���������������<����>��
		CidMatrix[23266]={type=7,effect1=5,effect2=1434,effect3=1,effect4=300,effect5=1,effect6=0,effect7=0}---//������������ȼ��<����>��
		CidMatrix[23268]={type=7,effect1=6,effect2=1435,effect3=1,effect4=300,effect5=1,effect6=0,effect7=0}---//�����������񡤵�ף<����>��
		CidMatrix[23269]={type=7,effect1=6,effect2=1436,effect3=1,effect4=300,effect5=1,effect6=0,effect7=0}---//�����������񡤶���<����>��
		CidMatrix[23270]={type=7,effect1=6,effect2=1437,effect3=1,effect4=300,effect5=1,effect6=0,effect7=0}---//�������������˺�<����>��
		CidMatrix[23271]={type=7,effect1=6,effect2=1438,effect3=1,effect4=300,effect5=1,effect6=0,effect7=0}---//������������׷��<����>��
		CidMatrix[23272]={type=7,effect1=6,effect2=1439,effect3=1,effect4=300,effect5=1,effect6=0,effect7=0}---//�����������񡤳���<����>��
		CidMatrix[23273]={type=7,effect1=6,effect2=1440,effect3=1,effect4=300,effect5=1,effect6=0,effect7=0}---//�������������ݵ�<����>��
		CidMatrix[23274]={type=7,effect1=7,effect2=1441,effect3=1,effect4=300,effect5=1,effect6=0,effect7=0}---//����������������<�޺�>��
		CidMatrix[23275]={type=7,effect1=7,effect2=1442,effect3=1,effect4=300,effect5=1,effect6=0,effect7=0}---//����������������<�޺�>��
		CidMatrix[23276]={type=7,effect1=7,effect2=1443,effect3=1,effect4=300,effect5=1,effect6=0,effect7=0}---//����������������<�޺�>��
		CidMatrix[23277]={type=7,effect1=7,effect2=1444,effect3=1,effect4=300,effect5=1,effect6=0,effect7=0}---//�����������񡤽���<�޺�>��
		CidMatrix[23278]={type=7,effect1=7,effect2=1445,effect3=1,effect4=300,effect5=1,effect6=0,effect7=0}---//�����������񡤺���<�޺�>��
		CidMatrix[23279]={type=7,effect1=7,effect2=1446,effect3=1,effect4=300,effect5=1,effect6=0,effect7=0}---//�����������񡤿�ʹ<�޺�>��
		CidMatrix[23280]={type=7,effect1=8,effect2=1447,effect3=1,effect4=300,effect5=1,effect6=0,effect7=0}---//����������������<�ƶ�>��
		CidMatrix[23281]={type=7,effect1=8,effect2=1448,effect3=1,effect4=300,effect5=1,effect6=0,effect7=0}---//����������������<�ƶ�>��
		CidMatrix[23282]={type=7,effect1=8,effect2=1449,effect3=1,effect4=300,effect5=1,effect6=0,effect7=0}---//�����������񡤷���<�ƶ�>��
		CidMatrix[23283]={type=7,effect1=8,effect2=1450,effect3=1,effect4=300,effect5=1,effect6=0,effect7=0}---//�����������񡤶���<�ƶ�>��
		CidMatrix[23284]={type=7,effect1=8,effect2=1451,effect3=1,effect4=300,effect5=1,effect6=0,effect7=0}---//���������������<�ƶ�>��
		CidMatrix[23285]={type=7,effect1=8,effect2=1452,effect3=1,effect4=300,effect5=1,effect6=0,effect7=0}---//��������������ã<�ƶ�>��
		CidMatrix[23286]={type=7,effect1=99,effect2=1453,effect3=1,effect4=300,effect5=1,effect6=0,effect7=0}---//�����������񡤷���<ͨ��>��
		CidMatrix[23287]={type=7,effect1=99,effect2=1454,effect3=1,effect4=300,effect5=1,effect6=0,effect7=0}---//����������������<ͨ��>��
		CidMatrix[23288]={type=7,effect1=99,effect2=1455,effect3=1,effect4=300,effect5=1,effect6=0,effect7=0}---//�����������񡤻���<ͨ��>��
		CidMatrix[23289]={type=7,effect1=99,effect2=1456,effect3=1,effect4=300,effect5=1,effect6=0,effect7=0}---//����������������<ͨ��>��
		CidMatrix[23290]={type=7,effect1=99,effect2=1457,effect3=1,effect4=300,effect5=1,effect6=0,effect7=0}---//����������������<ͨ��>��
		CidMatrix[23291]={type=7,effect1=99,effect2=1458,effect3=1,effect4=300,effect5=1,effect6=0,effect7=0}---//�����������񡤼�ȡ<ͨ��>��

		---//�ı����ܶȵ�ǰֵ
		CidMatrix[16307]={type=9,effect1=50,effect2=1,effect3=0,effect4=0,effect5=0,effect6=0,effect7=0}			
		CidMatrix[16308]={type=9,effect1=300,effect2=1,effect3=0,effect4=0,effect5=0,effect6=0,effect7=0}	
		CidMatrix[16309]={type=9,effect1=1600,effect2=1,effect3=0,effect4=0,effect5=0,effect6=0,effect7=0}			
		CidMatrix[16310]={type=9,effect1=3600,effect2=1,effect3=0,effect4=0,effect5=0,effect6=0,effect7=0}			
		---//�ı����ܶ����ֵ
		CidMatrix[16311]={type=10,effect1=50,effect2=0,effect3=0,effect4=0,effect5=0,effect6=0,effect7=0}			
		CidMatrix[16312]={type=10,effect1=300,effect2=0,effect3=0,effect4=0,effect5=0,effect6=0,effect7=0}	
		CidMatrix[16313]={type=10,effect1=1600,effect2=0,effect3=0,effect4=0,effect5=0,effect6=0,effect7=0}			
		CidMatrix[16314]={type=10,effect1=3600,effect2=0,effect3=0,effect4=0,effect5=0,effect6=0,effect7=0}
	
		---//��Ѫ�ı�
		---//���Ƽ۸� ��0.5/��1.0/��2.0/��5.0/��15.0/��30.0/��60.0
		CidMatrix[16029]={type=11,effect1=0,effect2=10,effect3=8,effect4=100,effect5=1,effect6=6,effect7=1}
		CidMatrix[16030]={type=11,effect1=0,effect2=20,effect3=12,effect4=100,effect5=2,effect6=15,effect7=2}
		CidMatrix[16031]={type=11,effect1=0,effect2=40,effect3=18,effect4=100,effect5=4,effect6=20,effect7=4}
		CidMatrix[16032]={type=11,effect1=0,effect2=100,effect3=20,effect4=100,effect5=10,effect6=20,effect7=8}
		CidMatrix[16033]={type=11,effect1=0,effect2=300,effect3=20,effect4=100,effect5=30,effect6=20,effect7=16}
		CidMatrix[16034]={type=11,effect1=0,effect2=600,effect3=20,effect4=100,effect5=60,effect6=20,effect7=32}
		CidMatrix[16035]={type=11,effect1=0,effect2=1200,effect3=20,effect4=100,effect5=120,effect6=20,effect7=64}
		CidMatrix[16036]={type=11,effect1=0,effect2=1,effect3=20,effect4=0,effect5=0,effect6=0,effect7=0}
		CidMatrix[16037]={type=11,effect1=0,effect2=1,effect3=20,effect4=0,effect5=0,effect6=0,effect7=0}
		CidMatrix[16038]={type=11,effect1=0,effect2=1,effect3=20,effect4=0,effect5=0,effect6=0,effect7=0}
		CidMatrix[16039]={type=11,effect1=0,effect2=1,effect3=20,effect4=0,effect5=0,effect6=0,effect7=0}
		CidMatrix[16040]={type=11,effect1=0,effect2=1,effect3=20,effect4=0,effect5=0,effect6=0,effect7=0}
		CidMatrix[16041]={type=11,effect1=0,effect2=1,effect3=20,effect4=0,effect5=0,effect6=0,effect7=0}
		CidMatrix[16042]={type=11,effect1=0,effect2=1,effect3=20,effect4=0,effect5=0,effect6=0,effect7=0}
		CidMatrix[16043]={type=11,effect1=0,effect2=1,effect3=20,effect4=0,effect5=0,effect6=0,effect7=0}
		CidMatrix[16044]={type=11,effect1=0,effect2=1,effect3=20,effect4=0,effect5=0,effect6=0,effect7=0}
		CidMatrix[16045]={type=11,effect1=0,effect2=1,effect3=20,effect4=0,effect5=0,effect6=0,effect7=0}
		CidMatrix[16046]={type=11,effect1=0,effect2=1,effect3=20,effect4=0,effect5=0,effect6=0,effect7=0}
		CidMatrix[16047]={type=11,effect1=0,effect2=1,effect3=20,effect4=0,effect5=0,effect6=0,effect7=0}
		CidMatrix[16048]={type=11,effect1=0,effect2=9999,effect3=20,effect4=0,effect5=0,effect6=0,effect7=0}
		CidMatrix[23881]={type=11,effect1=0,effect2=40,effect3=12,effect4=100,effect5=4,effect6=20,effect7=4}

		---//�����ı�
		CidMatrix[16049]={type=12,effect1=0,effect2=10,effect3=8,effect4=100,effect5=1,effect6=6,effect7=1}
		CidMatrix[16050]={type=12,effect1=0,effect2=20,effect3=12,effect4=100,effect5=2,effect6=15,effect7=2}
		CidMatrix[16051]={type=12,effect1=0,effect2=40,effect3=18,effect4=100,effect5=4,effect6=20,effect7=4}
		CidMatrix[16052]={type=12,effect1=0,effect2=100,effect3=20,effect4=100,effect5=10,effect6=20,effect7=8}
		CidMatrix[16053]={type=12,effect1=0,effect2=300,effect3=20,effect4=100,effect5=30,effect6=20,effect7=16}
		CidMatrix[16054]={type=12,effect1=0,effect2=600,effect3=20,effect4=100,effect5=60,effect6=20,effect7=32}
		CidMatrix[16055]={type=12,effect1=0,effect2=1200,effect3=20,effect4=100,effect5=120,effect6=20,effect7=64}
		CidMatrix[16056]={type=12,effect1=0,effect2=1,effect3=20,effect4=0,effect5=0,effect6=0,effect7=0}
		CidMatrix[16057]={type=12,effect1=0,effect2=1,effect3=20,effect4=0,effect5=0,effect6=0,effect7=0}
		CidMatrix[16058]={type=12,effect1=0,effect2=1,effect3=20,effect4=0,effect5=0,effect6=0,effect7=0}
		CidMatrix[16059]={type=12,effect1=0,effect2=1,effect3=20,effect4=0,effect5=0,effect6=0,effect7=0}
		CidMatrix[16060]={type=12,effect1=0,effect2=1,effect3=20,effect4=0,effect5=0,effect6=0,effect7=0}
		CidMatrix[16061]={type=12,effect1=0,effect2=1,effect3=20,effect4=0,effect5=0,effect6=0,effect7=0}
		CidMatrix[16062]={type=12,effect1=0,effect2=1,effect3=20,effect4=0,effect5=0,effect6=0,effect7=0}
		CidMatrix[16063]={type=12,effect1=0,effect2=1,effect3=20,effect4=0,effect5=0,effect6=0,effect7=0}
		CidMatrix[16064]={type=12,effect1=0,effect2=1,effect3=20,effect4=0,effect5=0,effect6=0,effect7=0}
		CidMatrix[16065]={type=12,effect1=0,effect2=1,effect3=20,effect4=0,effect5=0,effect6=0,effect7=0}
		CidMatrix[16066]={type=12,effect1=0,effect2=1,effect3=20,effect4=0,effect5=0,effect6=0,effect7=0}
		CidMatrix[16067]={type=12,effect1=0,effect2=1,effect3=20,effect4=0,effect5=0,effect6=0,effect7=0}
		CidMatrix[16068]={type=12,effect1=0,effect2=9999,effect3=20,effect4=0,effect5=0,effect6=0,effect7=0}

			---//��С�����ı�
		CidMatrix[16069]={type=13,effect1=0,effect2=10,effect3=8,effect4=100,effect5=1,effect6=6,effect7=1}
		CidMatrix[16070]={type=13,effect1=0,effect2=20,effect3=12,effect4=100,effect5=2,effect6=15,effect7=2}
		CidMatrix[16071]={type=13,effect1=0,effect2=40,effect3=18,effect4=100,effect5=4,effect6=20,effect7=4}
		CidMatrix[16072]={type=13,effect1=0,effect2=100,effect3=20,effect4=100,effect5=10,effect6=20,effect7=8}
		CidMatrix[16073]={type=13,effect1=0,effect2=300,effect3=20,effect4=100,effect5=30,effect6=20,effect7=16}
		CidMatrix[16074]={type=13,effect1=0,effect2=600,effect3=20,effect4=100,effect5=60,effect6=20,effect7=32}
		CidMatrix[16075]={type=13,effect1=0,effect2=1200,effect3=20,effect4=100,effect5=120,effect6=20,effect7=64}
		CidMatrix[16076]={type=13,effect1=0,effect2=1,effect3=20,effect4=0,effect5=0,effect6=0,effect7=0}
		CidMatrix[16077]={type=13,effect1=0,effect2=1,effect3=20,effect4=0,effect5=0,effect6=0,effect7=0}
		CidMatrix[16078]={type=13,effect1=0,effect2=1,effect3=20,effect4=0,effect5=0,effect6=0,effect7=0}
		CidMatrix[16079]={type=13,effect1=0,effect2=1,effect3=20,effect4=0,effect5=0,effect6=0,effect7=0}
		CidMatrix[16080]={type=13,effect1=0,effect2=1,effect3=20,effect4=0,effect5=0,effect6=0,effect7=0}
		CidMatrix[16081]={type=13,effect1=0,effect2=1,effect3=20,effect4=0,effect5=0,effect6=0,effect7=0}
		CidMatrix[16082]={type=13,effect1=0,effect2=1,effect3=20,effect4=0,effect5=0,effect6=0,effect7=0}
		CidMatrix[16083]={type=13,effect1=0,effect2=1,effect3=20,effect4=0,effect5=0,effect6=0,effect7=0}
		CidMatrix[16084]={type=13,effect1=0,effect2=1,effect3=20,effect4=0,effect5=0,effect6=0,effect7=0}
		CidMatrix[16085]={type=13,effect1=0,effect2=1,effect3=20,effect4=0,effect5=0,effect6=0,effect7=0}
		CidMatrix[16086]={type=13,effect1=0,effect2=1,effect3=20,effect4=0,effect5=0,effect6=0,effect7=0}
		CidMatrix[16087]={type=13,effect1=0,effect2=1,effect3=20,effect4=0,effect5=0,effect6=0,effect7=0}
		CidMatrix[16088]={type=13,effect1=0,effect2=9999,effect3=20,effect4=0,effect5=0,effect6=0,effect7=0}

		---//��󹥻��ı�
		CidMatrix[16089]={type=14,effect1=0,effect2=10,effect3=8,effect4=100,effect5=1,effect6=6,effect7=1}
		CidMatrix[16090]={type=14,effect1=0,effect2=20,effect3=12,effect4=100,effect5=2,effect6=15,effect7=2}
		CidMatrix[16091]={type=14,effect1=0,effect2=40,effect3=18,effect4=100,effect5=4,effect6=20,effect7=4}
		CidMatrix[16092]={type=14,effect1=0,effect2=100,effect3=20,effect4=100,effect5=10,effect6=20,effect7=8}
		CidMatrix[16093]={type=14,effect1=0,effect2=300,effect3=20,effect4=100,effect5=30,effect6=20,effect7=16}
		CidMatrix[16094]={type=14,effect1=0,effect2=600,effect3=20,effect4=100,effect5=60,effect6=20,effect7=32}
		CidMatrix[16095]={type=14,effect1=0,effect2=1200,effect3=20,effect4=100,effect5=120,effect6=20,effect7=64}
		CidMatrix[16096]={type=14,effect1=0,effect2=1,effect3=20,effect4=0,effect5=0,effect6=0,effect7=0}
		CidMatrix[16097]={type=14,effect1=0,effect2=1,effect3=20,effect4=0,effect5=0,effect6=0,effect7=0}
		CidMatrix[16098]={type=14,effect1=0,effect2=1,effect3=20,effect4=0,effect5=0,effect6=0,effect7=0}
		CidMatrix[16099]={type=14,effect1=0,effect2=1,effect3=20,effect4=0,effect5=0,effect6=0,effect7=0}
		CidMatrix[16100]={type=14,effect1=0,effect2=1,effect3=20,effect4=0,effect5=0,effect6=0,effect7=0}
		CidMatrix[16101]={type=14,effect1=0,effect2=1,effect3=20,effect4=0,effect5=0,effect6=0,effect7=0}
		CidMatrix[16102]={type=14,effect1=0,effect2=1,effect3=20,effect4=0,effect5=0,effect6=0,effect7=0}
		CidMatrix[16103]={type=14,effect1=0,effect2=1,effect3=20,effect4=0,effect5=0,effect6=0,effect7=0}
		CidMatrix[16104]={type=14,effect1=0,effect2=1,effect3=20,effect4=0,effect5=0,effect6=0,effect7=0}
		CidMatrix[16105]={type=14,effect1=0,effect2=1,effect3=20,effect4=0,effect5=0,effect6=0,effect7=0}
		CidMatrix[16106]={type=14,effect1=0,effect2=1,effect3=20,effect4=0,effect5=0,effect6=0,effect7=0}
		CidMatrix[16107]={type=14,effect1=0,effect2=1,effect3=20,effect4=0,effect5=0,effect6=0,effect7=0}
		CidMatrix[16108]={type=14,effect1=0,effect2=9999,effect3=20,effect4=0,effect5=0,effect6=0,effect7=0}

		---//�����ı�
		CidMatrix[16109]={type=15,effect1=0,effect2=10,effect3=8,effect4=100,effect5=1,effect6=6,effect7=1}
		CidMatrix[16110]={type=15,effect1=0,effect2=20,effect3=12,effect4=100,effect5=2,effect6=15,effect7=2}
		CidMatrix[16111]={type=15,effect1=0,effect2=40,effect3=18,effect4=100,effect5=4,effect6=20,effect7=4}
		CidMatrix[16112]={type=15,effect1=0,effect2=100,effect3=20,effect4=100,effect5=10,effect6=20,effect7=8}
		CidMatrix[16113]={type=15,effect1=0,effect2=300,effect3=20,effect4=100,effect5=30,effect6=20,effect7=16}
		CidMatrix[16114]={type=15,effect1=0,effect2=600,effect3=20,effect4=100,effect5=60,effect6=20,effect7=32}
		CidMatrix[16115]={type=15,effect1=0,effect2=1200,effect3=20,effect4=100,effect5=120,effect6=20,effect7=64}
		CidMatrix[16116]={type=15,effect1=0,effect2=1,effect3=20,effect4=0,effect5=0,effect6=0,effect7=0}
		CidMatrix[16117]={type=15,effect1=0,effect2=1,effect3=20,effect4=0,effect5=0,effect6=0,effect7=0}
		CidMatrix[16118]={type=15,effect1=0,effect2=1,effect3=20,effect4=0,effect5=0,effect6=0,effect7=0}
		CidMatrix[16119]={type=15,effect1=0,effect2=1,effect3=20,effect4=0,effect5=0,effect6=0,effect7=0}
		CidMatrix[16120]={type=15,effect1=0,effect2=1,effect3=20,effect4=0,effect5=0,effect6=0,effect7=0}
		CidMatrix[16121]={type=15,effect1=0,effect2=1,effect3=20,effect4=0,effect5=0,effect6=0,effect7=0}
		CidMatrix[16122]={type=15,effect1=0,effect2=1,effect3=20,effect4=0,effect5=0,effect6=0,effect7=0}
		CidMatrix[16123]={type=15,effect1=0,effect2=1,effect3=20,effect4=0,effect5=0,effect6=0,effect7=0}
		CidMatrix[16124]={type=15,effect1=0,effect2=1,effect3=20,effect4=0,effect5=0,effect6=0,effect7=0}
		CidMatrix[16125]={type=15,effect1=0,effect2=1,effect3=20,effect4=0,effect5=0,effect6=0,effect7=0}
		CidMatrix[16126]={type=15,effect1=0,effect2=1,effect3=20,effect4=0,effect5=0,effect6=0,effect7=0}
		CidMatrix[16127]={type=15,effect1=0,effect2=1,effect3=20,effect4=0,effect5=0,effect6=0,effect7=0}
		CidMatrix[16128]={type=15,effect1=0,effect2=9999,effect3=20,effect4=0,effect5=0,effect6=0,effect7=0}

		---//���иı�
		CidMatrix[16129]={type=16,effect1=0,effect2=10,effect3=8,effect4=100,effect5=1,effect6=6,effect7=1}
		CidMatrix[16130]={type=16,effect1=0,effect2=20,effect3=12,effect4=100,effect5=2,effect6=15,effect7=2}
		CidMatrix[16131]={type=16,effect1=0,effect2=40,effect3=18,effect4=100,effect5=4,effect6=20,effect7=4}
		CidMatrix[16132]={type=16,effect1=0,effect2=100,effect3=20,effect4=100,effect5=10,effect6=20,effect7=8}
		CidMatrix[16133]={type=16,effect1=0,effect2=300,effect3=20,effect4=100,effect5=30,effect6=20,effect7=16}
		CidMatrix[16134]={type=16,effect1=0,effect2=600,effect3=20,effect4=100,effect5=60,effect6=20,effect7=32}
		CidMatrix[16135]={type=16,effect1=0,effect2=1200,effect3=20,effect4=100,effect5=120,effect6=20,effect7=64}
		CidMatrix[16136]={type=16,effect1=0,effect2=1,effect3=20,effect4=0,effect5=0,effect6=0,effect7=0}
		CidMatrix[16137]={type=16,effect1=0,effect2=1,effect3=20,effect4=0,effect5=0,effect6=0,effect7=0}
		CidMatrix[16138]={type=16,effect1=0,effect2=1,effect3=20,effect4=0,effect5=0,effect6=0,effect7=0}
		CidMatrix[16139]={type=16,effect1=0,effect2=1,effect3=20,effect4=0,effect5=0,effect6=0,effect7=0}
		CidMatrix[16140]={type=16,effect1=0,effect2=1,effect3=20,effect4=0,effect5=0,effect6=0,effect7=0}
		CidMatrix[16141]={type=16,effect1=0,effect2=1,effect3=20,effect4=0,effect5=0,effect6=0,effect7=0}
		CidMatrix[16142]={type=16,effect1=0,effect2=1,effect3=20,effect4=0,effect5=0,effect6=0,effect7=0}
		CidMatrix[16143]={type=16,effect1=0,effect2=1,effect3=20,effect4=0,effect5=0,effect6=0,effect7=0}
		CidMatrix[16144]={type=16,effect1=0,effect2=1,effect3=20,effect4=0,effect5=0,effect6=0,effect7=0}
		CidMatrix[16145]={type=16,effect1=0,effect2=1,effect3=20,effect4=0,effect5=0,effect6=0,effect7=0}
		CidMatrix[16146]={type=16,effect1=0,effect2=1,effect3=20,effect4=0,effect5=0,effect6=0,effect7=0}
		CidMatrix[16147]={type=16,effect1=0,effect2=1,effect3=20,effect4=0,effect5=0,effect6=0,effect7=0}
		CidMatrix[16148]={type=16,effect1=0,effect2=9999,effect3=20,effect4=0,effect5=0,effect6=0,effect7=0}
	
		---//�����ı�
		CidMatrix[16149]={type=17,effect1=0,effect2=10,effect3=8,effect4=100,effect5=1,effect6=6,effect7=1}
		CidMatrix[16150]={type=17,effect1=0,effect2=20,effect3=12,effect4=100,effect5=2,effect6=15,effect7=2}
		CidMatrix[16151]={type=17,effect1=0,effect2=40,effect3=18,effect4=100,effect5=4,effect6=20,effect7=4}
		CidMatrix[16152]={type=17,effect1=0,effect2=100,effect3=20,effect4=100,effect5=10,effect6=20,effect7=8}
		CidMatrix[16153]={type=17,effect1=0,effect2=300,effect3=20,effect4=100,effect5=30,effect6=20,effect7=16}
		CidMatrix[16154]={type=17,effect1=0,effect2=600,effect3=20,effect4=100,effect5=60,effect6=20,effect7=32}
		CidMatrix[16155]={type=17,effect1=0,effect2=1200,effect3=20,effect4=100,effect5=120,effect6=20,effect7=64}
		CidMatrix[16156]={type=17,effect1=0,effect2=1,effect3=20,effect4=0,effect5=0,effect6=0,effect7=0}
		CidMatrix[16157]={type=17,effect1=0,effect2=1,effect3=20,effect4=0,effect5=0,effect6=0,effect7=0}
		CidMatrix[16158]={type=17,effect1=0,effect2=1,effect3=20,effect4=0,effect5=0,effect6=0,effect7=0}
		CidMatrix[16159]={type=17,effect1=0,effect2=1,effect3=20,effect4=0,effect5=0,effect6=0,effect7=0}
		CidMatrix[16160]={type=17,effect1=0,effect2=1,effect3=20,effect4=0,effect5=0,effect6=0,effect7=0}
		CidMatrix[16161]={type=17,effect1=0,effect2=1,effect3=20,effect4=0,effect5=0,effect6=0,effect7=0}
		CidMatrix[16162]={type=17,effect1=0,effect2=1,effect3=20,effect4=0,effect5=0,effect6=0,effect7=0}
		CidMatrix[16164]={type=17,effect1=0,effect2=1,effect3=20,effect4=0,effect5=0,effect6=0,effect7=0}
		CidMatrix[16163]={type=17,effect1=0,effect2=1,effect3=20,effect4=0,effect5=0,effect6=0,effect7=0}
		CidMatrix[16165]={type=17,effect1=0,effect2=1,effect3=20,effect4=0,effect5=0,effect6=0,effect7=0}
		CidMatrix[16166]={type=17,effect1=0,effect2=1,effect3=20,effect4=0,effect5=0,effect6=0,effect7=0}
		CidMatrix[16167]={type=17,effect1=0,effect2=1,effect3=20,effect4=0,effect5=0,effect6=0,effect7=0}
		CidMatrix[16168]={type=17,effect1=0,effect2=9999,effect3=20,effect4=0,effect5=0,effect6=0,effect7=0}

		---//ѣ�θı�
		CidMatrix[16169]={type=18,effect1=0,effect2=10,effect3=8,effect4=100,effect5=1,effect6=6,effect7=1}
		CidMatrix[16170]={type=18,effect1=0,effect2=20,effect3=12,effect4=100,effect5=2,effect6=15,effect7=2}
		CidMatrix[16171]={type=18,effect1=0,effect2=40,effect3=18,effect4=100,effect5=4,effect6=20,effect7=4}
		CidMatrix[16172]={type=18,effect1=0,effect2=100,effect3=20,effect4=100,effect5=10,effect6=20,effect7=8}
		CidMatrix[16173]={type=18,effect1=0,effect2=300,effect3=20,effect4=100,effect5=30,effect6=20,effect7=16}
		CidMatrix[16174]={type=18,effect1=0,effect2=600,effect3=20,effect4=100,effect5=60,effect6=20,effect7=32}
		CidMatrix[16175]={type=18,effect1=0,effect2=1200,effect3=20,effect4=100,effect5=120,effect6=20,effect7=64}
		CidMatrix[16176]={type=18,effect1=0,effect2=1,effect3=20,effect4=0,effect5=0,effect6=0,effect7=0}
		CidMatrix[16177]={type=18,effect1=0,effect2=1,effect3=20,effect4=0,effect5=0,effect6=0,effect7=0}
		CidMatrix[16178]={type=18,effect1=0,effect2=1,effect3=20,effect4=0,effect5=0,effect6=0,effect7=0}
		CidMatrix[16179]={type=18,effect1=0,effect2=1,effect3=20,effect4=0,effect5=0,effect6=0,effect7=0}
		CidMatrix[16180]={type=18,effect1=0,effect2=1,effect3=20,effect4=0,effect5=0,effect6=0,effect7=0}
		CidMatrix[16181]={type=18,effect1=0,effect2=1,effect3=20,effect4=0,effect5=0,effect6=0,effect7=0}
		CidMatrix[16182]={type=18,effect1=0,effect2=1,effect3=20,effect4=0,effect5=0,effect6=0,effect7=0}
		CidMatrix[16183]={type=18,effect1=0,effect2=1,effect3=20,effect4=0,effect5=0,effect6=0,effect7=0}
		CidMatrix[16184]={type=18,effect1=0,effect2=1,effect3=20,effect4=0,effect5=0,effect6=0,effect7=0}
		CidMatrix[16185]={type=18,effect1=0,effect2=1,effect3=20,effect4=0,effect5=0,effect6=0,effect7=0}
		CidMatrix[16186]={type=18,effect1=0,effect2=1,effect3=20,effect4=0,effect5=0,effect6=0,effect7=0}
		CidMatrix[16187]={type=18,effect1=0,effect2=1,effect3=20,effect4=0,effect5=0,effect6=0,effect7=0}
		CidMatrix[16188]={type=18,effect1=0,effect2=9999,effect3=20,effect4=0,effect5=0,effect6=0,effect7=0}

		---//�����ı�
		CidMatrix[16189]={type=19,effect1=0,effect2=10,effect3=8,effect4=100,effect5=1,effect6=6,effect7=1}
		CidMatrix[16190]={type=19,effect1=0,effect2=20,effect3=12,effect4=100,effect5=2,effect6=15,effect7=2}
		CidMatrix[16191]={type=19,effect1=0,effect2=40,effect3=18,effect4=100,effect5=4,effect6=20,effect7=4}
		CidMatrix[16192]={type=19,effect1=0,effect2=100,effect3=20,effect4=100,effect5=10,effect6=20,effect7=8}
		CidMatrix[16193]={type=19,effect1=0,effect2=300,effect3=20,effect4=100,effect5=30,effect6=20,effect7=16}
		CidMatrix[16194]={type=19,effect1=0,effect2=600,effect3=20,effect4=100,effect5=60,effect6=20,effect7=32}
		CidMatrix[16195]={type=19,effect1=0,effect2=1200,effect3=20,effect4=100,effect5=120,effect6=20,effect7=64}
		CidMatrix[16196]={type=19,effect1=0,effect2=1,effect3=20,effect4=0,effect5=0,effect6=0,effect7=0}
		CidMatrix[16197]={type=19,effect1=0,effect2=1,effect3=20,effect4=0,effect5=0,effect6=0,effect7=0}
		CidMatrix[16198]={type=19,effect1=0,effect2=1,effect3=20,effect4=0,effect5=0,effect6=0,effect7=0}
		CidMatrix[16199]={type=19,effect1=0,effect2=1,effect3=20,effect4=0,effect5=0,effect6=0,effect7=0}
		CidMatrix[16200]={type=19,effect1=0,effect2=1,effect3=20,effect4=0,effect5=0,effect6=0,effect7=0}
		CidMatrix[16201]={type=19,effect1=0,effect2=1,effect3=20,effect4=0,effect5=0,effect6=0,effect7=0}
		CidMatrix[16202]={type=19,effect1=0,effect2=1,effect3=20,effect4=0,effect5=0,effect6=0,effect7=0}
		CidMatrix[16203]={type=19,effect1=0,effect2=1,effect3=20,effect4=0,effect5=0,effect6=0,effect7=0}
		CidMatrix[16204]={type=19,effect1=0,effect2=1,effect3=20,effect4=0,effect5=0,effect6=0,effect7=0}
		CidMatrix[16205]={type=19,effect1=0,effect2=1,effect3=20,effect4=0,effect5=0,effect6=0,effect7=0}
		CidMatrix[16206]={type=19,effect1=0,effect2=1,effect3=20,effect4=0,effect5=0,effect6=0,effect7=0}
		CidMatrix[16207]={type=19,effect1=0,effect2=1,effect3=20,effect4=0,effect5=0,effect6=0,effect7=0}
		CidMatrix[16208]={type=19,effect1=0,effect2=9999,effect3=20,effect4=0,effect5=0,effect6=0,effect7=0}

		---//����ı�
		CidMatrix[16249]={type=20,effect1=0,effect2=10,effect3=8,effect4=100,effect5=1,effect6=6,effect7=1}
		CidMatrix[16250]={type=20,effect1=0,effect2=20,effect3=12,effect4=100,effect5=2,effect6=15,effect7=2}
		CidMatrix[16251]={type=20,effect1=0,effect2=40,effect3=18,effect4=100,effect5=4,effect6=20,effect7=4}
		CidMatrix[16252]={type=20,effect1=0,effect2=100,effect3=20,effect4=100,effect5=10,effect6=20,effect7=8}
		CidMatrix[16253]={type=20,effect1=0,effect2=300,effect3=20,effect4=100,effect5=30,effect6=20,effect7=16}
		CidMatrix[16254]={type=20,effect1=0,effect2=600,effect3=20,effect4=100,effect5=60,effect6=20,effect7=32}
		CidMatrix[16255]={type=20,effect1=0,effect2=1200,effect3=20,effect4=100,effect5=120,effect6=20,effect7=64}
		CidMatrix[16256]={type=20,effect1=0,effect2=1,effect3=20,effect4=0,effect5=0,effect6=0,effect7=0}
		CidMatrix[16257]={type=20,effect1=0,effect2=1,effect3=20,effect4=0,effect5=0,effect6=0,effect7=0}
		CidMatrix[16258]={type=20,effect1=0,effect2=1,effect3=20,effect4=0,effect5=0,effect6=0,effect7=0}
		CidMatrix[16259]={type=20,effect1=0,effect2=1,effect3=20,effect4=0,effect5=0,effect6=0,effect7=0}
		CidMatrix[16260]={type=20,effect1=0,effect2=1,effect3=20,effect4=0,effect5=0,effect6=0,effect7=0}
		CidMatrix[16261]={type=20,effect1=0,effect2=1,effect3=20,effect4=0,effect5=0,effect6=0,effect7=0}
		CidMatrix[16262]={type=20,effect1=0,effect2=1,effect3=20,effect4=0,effect5=0,effect6=0,effect7=0}
		CidMatrix[16263]={type=20,effect1=0,effect2=1,effect3=20,effect4=0,effect5=0,effect6=0,effect7=0}
		CidMatrix[16264]={type=20,effect1=0,effect2=1,effect3=20,effect4=0,effect5=0,effect6=0,effect7=0}
		CidMatrix[16265]={type=20,effect1=0,effect2=1,effect3=20,effect4=0,effect5=0,effect6=0,effect7=0}
		CidMatrix[16266]={type=20,effect1=0,effect2=1,effect3=20,effect4=0,effect5=0,effect6=0,effect7=0}
		CidMatrix[16267]={type=20,effect1=0,effect2=1,effect3=20,effect4=0,effect5=0,effect6=0,effect7=0}
		CidMatrix[16268]={type=20,effect1=0,effect2=9999,effect3=20,effect4=0,effect5=0,effect6=0,effect7=0}

		---//�Ȼ�ı�
		CidMatrix[16209]={type=21,effect1=0,effect2=10,effect3=8,effect4=100,effect5=1,effect6=6,effect7=1}
		CidMatrix[16210]={type=21,effect1=0,effect2=20,effect3=12,effect4=100,effect5=2,effect6=15,effect7=2}
		CidMatrix[16211]={type=21,effect1=0,effect2=40,effect3=18,effect4=100,effect5=4,effect6=20,effect7=4}
		CidMatrix[16212]={type=21,effect1=0,effect2=100,effect3=20,effect4=100,effect5=10,effect6=20,effect7=8}
		CidMatrix[16213]={type=21,effect1=0,effect2=300,effect3=20,effect4=100,effect5=30,effect6=20,effect7=16}
		CidMatrix[16214]={type=21,effect1=0,effect2=600,effect3=20,effect4=100,effect5=60,effect6=20,effect7=32}
		CidMatrix[16215]={type=21,effect1=0,effect2=1200,effect3=20,effect4=100,effect5=120,effect6=20,effect7=64}
		CidMatrix[16216]={type=21,effect1=0,effect2=1,effect3=20,effect4=0,effect5=0,effect6=0,effect7=0}
		CidMatrix[16217]={type=21,effect1=0,effect2=1,effect3=20,effect4=0,effect5=0,effect6=0,effect7=0}
		CidMatrix[16218]={type=21,effect1=0,effect2=1,effect3=20,effect4=0,effect5=0,effect6=0,effect7=0}
		CidMatrix[16219]={type=21,effect1=0,effect2=1,effect3=20,effect4=0,effect5=0,effect6=0,effect7=0}
		CidMatrix[16220]={type=21,effect1=0,effect2=1,effect3=20,effect4=0,effect5=0,effect6=0,effect7=0}
		CidMatrix[16221]={type=21,effect1=0,effect2=1,effect3=20,effect4=0,effect5=0,effect6=0,effect7=0}
		CidMatrix[16222]={type=21,effect1=0,effect2=1,effect3=20,effect4=0,effect5=0,effect6=0,effect7=0}
		CidMatrix[16223]={type=21,effect1=0,effect2=1,effect3=20,effect4=0,effect5=0,effect6=0,effect7=0}
		CidMatrix[16224]={type=21,effect1=0,effect2=1,effect3=20,effect4=0,effect5=0,effect6=0,effect7=0}
		CidMatrix[16225]={type=21,effect1=0,effect2=1,effect3=20,effect4=0,effect5=0,effect6=0,effect7=0}
		CidMatrix[16226]={type=21,effect1=0,effect2=1,effect3=20,effect4=0,effect5=0,effect6=0,effect7=0}
		CidMatrix[16227]={type=21,effect1=0,effect2=1,effect3=20,effect4=0,effect5=0,effect6=0,effect7=0}
		CidMatrix[16228]={type=21,effect1=0,effect2=9999,effect3=20,effect4=0,effect5=0,effect6=0,effect7=0}

		---//��˯�ı�
		CidMatrix[16229]={type=22,effect1=0,effect2=10,effect3=8,effect4=100,effect5=1,effect6=6,effect7=1}
		CidMatrix[16230]={type=22,effect1=0,effect2=20,effect3=12,effect4=100,effect5=2,effect6=15,effect7=2}
		CidMatrix[16231]={type=22,effect1=0,effect2=40,effect3=18,effect4=100,effect5=4,effect6=20,effect7=4}
		CidMatrix[16232]={type=22,effect1=0,effect2=100,effect3=20,effect4=100,effect5=10,effect6=20,effect7=8}
		CidMatrix[16233]={type=22,effect1=0,effect2=300,effect3=20,effect4=100,effect5=30,effect6=20,effect7=16}
		CidMatrix[16234]={type=22,effect1=0,effect2=600,effect3=20,effect4=100,effect5=60,effect6=20,effect7=32}
		CidMatrix[16235]={type=22,effect1=0,effect2=1200,effect3=20,effect4=100,effect5=120,effect6=20,effect7=64}
		CidMatrix[16236]={type=22,effect1=0,effect2=1,effect3=20,effect4=0,effect5=0,effect6=0,effect7=0}
		CidMatrix[16237]={type=22,effect1=0,effect2=1,effect3=20,effect4=0,effect5=0,effect6=0,effect7=0}
		CidMatrix[16238]={type=22,effect1=0,effect2=1,effect3=20,effect4=0,effect5=0,effect6=0,effect7=0}
		CidMatrix[16239]={type=22,effect1=0,effect2=1,effect3=20,effect4=0,effect5=0,effect6=0,effect7=0}
		CidMatrix[16240]={type=22,effect1=0,effect2=1,effect3=20,effect4=0,effect5=0,effect6=0,effect7=0}
		CidMatrix[16241]={type=22,effect1=0,effect2=1,effect3=20,effect4=0,effect5=0,effect6=0,effect7=0}
		CidMatrix[16242]={type=22,effect1=0,effect2=1,effect3=20,effect4=0,effect5=0,effect6=0,effect7=0}
		CidMatrix[16243]={type=22,effect1=0,effect2=1,effect3=20,effect4=0,effect5=0,effect6=0,effect7=0}
		CidMatrix[16244]={type=22,effect1=0,effect2=1,effect3=20,effect4=0,effect5=0,effect6=0,effect7=0}
		CidMatrix[16245]={type=22,effect1=0,effect2=1,effect3=20,effect4=0,effect5=0,effect6=0,effect7=0}
		CidMatrix[16246]={type=22,effect1=0,effect2=1,effect3=20,effect4=0,effect5=0,effect6=0,effect7=0}
		CidMatrix[16247]={type=22,effect1=0,effect2=1,effect3=20,effect4=0,effect5=0,effect6=0,effect7=0}
		CidMatrix[16248]={type=22,effect1=0,effect2=9999,effect3=20,effect4=0,effect5=0,effect6=0,effect7=0}


		---//�����ı�
		CidMatrix[16269]={type=23,effect1=0,effect2=10,effect3=8,effect4=100,effect5=1,effect6=6,effect7=1}
		CidMatrix[16270]={type=23,effect1=0,effect2=20,effect3=12,effect4=100,effect5=2,effect6=15,effect7=2}
		CidMatrix[16271]={type=23,effect1=0,effect2=40,effect3=18,effect4=100,effect5=4,effect6=20,effect7=4}
		CidMatrix[16272]={type=23,effect1=0,effect2=100,effect3=20,effect4=100,effect5=10,effect6=20,effect7=8}
		CidMatrix[16273]={type=23,effect1=0,effect2=300,effect3=20,effect4=100,effect5=30,effect6=20,effect7=16}
		CidMatrix[16274]={type=23,effect1=0,effect2=600,effect3=20,effect4=100,effect5=60,effect6=20,effect7=32}
		CidMatrix[16275]={type=23,effect1=0,effect2=1200,effect3=20,effect4=100,effect5=120,effect6=20,effect7=64}
		CidMatrix[16276]={type=23,effect1=0,effect2=1,effect3=20,effect4=0,effect5=0,effect6=0,effect7=0}
		CidMatrix[16277]={type=23,effect1=0,effect2=1,effect3=20,effect4=0,effect5=0,effect6=0,effect7=0}
		CidMatrix[16278]={type=23,effect1=0,effect2=1,effect3=20,effect4=0,effect5=0,effect6=0,effect7=0}
		CidMatrix[16279]={type=23,effect1=0,effect2=1,effect3=20,effect4=0,effect5=0,effect6=0,effect7=0}
		CidMatrix[16280]={type=23,effect1=0,effect2=1,effect3=20,effect4=0,effect5=0,effect6=0,effect7=0}
		CidMatrix[16281]={type=23,effect1=0,effect2=1,effect3=20,effect4=0,effect5=0,effect6=0,effect7=0}
		CidMatrix[16282]={type=23,effect1=0,effect2=1,effect3=20,effect4=0,effect5=0,effect6=0,effect7=0}
		CidMatrix[16283]={type=23,effect1=0,effect2=1,effect3=20,effect4=0,effect5=0,effect6=0,effect7=0}
		CidMatrix[16284]={type=23,effect1=0,effect2=1,effect3=20,effect4=0,effect5=0,effect6=0,effect7=0}
		CidMatrix[16285]={type=23,effect1=0,effect2=1,effect3=20,effect4=0,effect5=0,effect6=0,effect7=0}
		CidMatrix[16286]={type=23,effect1=0,effect2=1,effect3=20,effect4=0,effect5=0,effect6=0,effect7=0}
		CidMatrix[16287]={type=23,effect1=0,effect2=1,effect3=20,effect4=0,effect5=0,effect6=0,effect7=0}
		CidMatrix[16288]={type=23,effect1=0,effect2=9999,effect3=20,effect4=0,effect5=0,effect6=0,effect7=0}

		---//���ս�����Ըı�
		---//�ֱ�Ϊ15-60��61-120��121-150������(3��ת��ǰ,3��ת����)
		CidMatrix[17588]={type=25,effect1=0,effect2=10,effect3=10,effect4=100,effect5=1,effect6=10,effect7=0}
		CidMatrix[17589]={type=25,effect1=0,effect2=20,effect3=10,effect4=100,effect5=2,effect6=10,effect7=0}
		CidMatrix[17590]={type=25,effect1=0,effect2=40,effect3=15,effect4=100,effect5=4,effect6=15,effect7=0}
		CidMatrix[17591]={type=25,effect1=0,effect2=15,effect3=15,effect4=100,effect5=2,effect6=15,effect7=0}
		CidMatrix[17592]={type=25,effect1=0,effect2=25,effect3=15,effect4=100,effect5=4,effect6=15,effect7=0}
		CidMatrix[17593]={type=25,effect1=0,effect2=50,effect3=20,effect4=100,effect5=8,effect6=20,effect7=0}
		
		---//�����͸ı�(�޽�)�ı�
		CidMatrix[16320]={type=32,effect1=0,effect2=0,effect3=0,effect4=0,effect5=0,effect6=0,effect7=0}		

		---//����ı�ҩ��(���ǵȸı��ҩ��)
		---//effect1(���ʹ���ǵ�)/effect2(ָ���shape)/effect3(ָ���shape(���������)
		CidMatrix[17782]={type=33,effect1=1,effect2=1,effect3=2,effect4=0,effect5=0,effect6=0,effect7=0}		
		CidMatrix[17819]={type=33,effect1=12,effect2=3,effect3=4,effect4=0,effect5=0,effect6=0,effect7=0}	
		CidMatrix[17820]={type=33,effect1=18,effect2=5,effect3=6,effect4=0,effect5=0,effect6=0,effect7=0}
	
		---//����ҩ��(���﷢�������ҩ��)
		CidMatrix[18726]={type=34,effect1=0,effect2=0,effect3=0,effect4=0,effect5=0,effect6=0,effect7=0}
		
		---//�ɳ��۲�ҩ��(����ר��)
		CidMatrix[18725]={type=35,effect1=0,effect2=0,effect3=0,effect4=0,effect5=0,effect6=0,effect7=0}

		---//�ֻظı�
		CidMatrix[19183]={type=36,effect1=0,effect2=0,effect3=0,effect4=0,effect5=0,effect6=0,effect7=0}		

		---//���ض�֭(�̶�ֵ�����ͷ����ɳ�)
		CidMatrix[20481]={type=37,effect1=1,effect2=0,effect3=0,effect4=0,effect5=0,effect6=0,effect7=0}		
		CidMatrix[20483]={type=37,effect1=10,effect2=0,effect3=0,effect4=0,effect5=0,effect6=0,effect7=0}	
		CidMatrix[20484]={type=37,effect1=50,effect2=0,effect3=0,effect4=0,effect5=0,effect6=0,effect7=0}
		CidMatrix[23880]={type=37,effect1=1,effect2=0,effect3=0,effect4=0,effect5=0,effect6=0,effect7=0}	
				
		---//����ǿ��(�������������������Ʒ)
		CidMatrix[20048]={type=38,effect1=1,effect2=1,effect3=0,effect4=0,effect5=0,effect6=0,effect7=0}		
		CidMatrix[20049]={type=38,effect1=1,effect2=2,effect3=0,effect4=0,effect5=0,effect6=0,effect7=0}	
		CidMatrix[20050]={type=38,effect1=1,effect2=3,effect3=0,effect4=0,effect5=0,effect6=0,effect7=0}			
		CidMatrix[20051]={type=38,effect1=1,effect2=4,effect3=0,effect4=0,effect5=0,effect6=0,effect7=0}	
		CidMatrix[20052]={type=38,effect1=1,effect2=5,effect3=0,effect4=0,effect5=0,effect6=0,effect7=0}	
		CidMatrix[20053]={type=38,effect1=1,effect2=6,effect3=0,effect4=0,effect5=0,effect6=0,effect7=0}	
		CidMatrix[20054]={type=38,effect1=1,effect2=7,effect3=0,effect4=0,effect5=0,effect6=0,effect7=0}	
		CidMatrix[20055]={type=38,effect1=1,effect2=8,effect3=0,effect4=0,effect5=0,effect6=0,effect7=0}	
		CidMatrix[20056]={type=38,effect1=1,effect2=9,effect3=0,effect4=0,effect5=0,effect6=0,effect7=0}	
		CidMatrix[20057]={type=38,effect1=1,effect2=10,effect3=0,effect4=0,effect5=0,effect6=0,effect7=0}	
		CidMatrix[20058]={type=38,effect1=1,effect2=11,effect3=0,effect4=0,effect5=0,effect6=0,effect7=0}	
		CidMatrix[20059]={type=38,effect1=1,effect2=12,effect3=0,effect4=0,effect5=0,effect6=0,effect7=0}	
		CidMatrix[20060]={type=38,effect1=1,effect2=13,effect3=0,effect4=0,effect5=0,effect6=0,effect7=0}	
		CidMatrix[20061]={type=38,effect1=1,effect2=14,effect3=0,effect4=0,effect5=0,effect6=0,effect7=0}	
		CidMatrix[20062]={type=38,effect1=1,effect2=15,effect3=0,effect4=0,effect5=0,effect6=0,effect7=0}	
		CidMatrix[20063]={type=38,effect1=1,effect2=16,effect3=0,effect4=0,effect5=0,effect6=0,effect7=0}	
		CidMatrix[20064]={type=38,effect1=1,effect2=17,effect3=0,effect4=0,effect5=0,effect6=0,effect7=0}	
		CidMatrix[20065]={type=38,effect1=1,effect2=18,effect3=0,effect4=0,effect5=0,effect6=0,effect7=0}	
		CidMatrix[20066]={type=38,effect1=1,effect2=19,effect3=0,effect4=0,effect5=0,effect6=0,effect7=0}	
		CidMatrix[20067]={type=38,effect1=1,effect2=20,effect3=0,effect4=0,effect5=0,effect6=0,effect7=0}	
		
		CidMatrix[20068]={type=38,effect1=2,effect2=1,effect3=0,effect4=0,effect5=0,effect6=0,effect7=0}	
		CidMatrix[20069]={type=38,effect1=2,effect2=2,effect3=0,effect4=0,effect5=0,effect6=0,effect7=0}	
		CidMatrix[20070]={type=38,effect1=2,effect2=3,effect3=0,effect4=0,effect5=0,effect6=0,effect7=0}	
		CidMatrix[20071]={type=38,effect1=2,effect2=4,effect3=0,effect4=0,effect5=0,effect6=0,effect7=0}	
		CidMatrix[20072]={type=38,effect1=2,effect2=5,effect3=0,effect4=0,effect5=0,effect6=0,effect7=0}	
		CidMatrix[20073]={type=38,effect1=2,effect2=6,effect3=0,effect4=0,effect5=0,effect6=0,effect7=0}	
		CidMatrix[20074]={type=38,effect1=2,effect2=7,effect3=0,effect4=0,effect5=0,effect6=0,effect7=0}	
		CidMatrix[20075]={type=38,effect1=2,effect2=8,effect3=0,effect4=0,effect5=0,effect6=0,effect7=0}	
		CidMatrix[20076]={type=38,effect1=2,effect2=9,effect3=0,effect4=0,effect5=0,effect6=0,effect7=0}	
		CidMatrix[20077]={type=38,effect1=2,effect2=10,effect3=0,effect4=0,effect5=0,effect6=0,effect7=0}	
		CidMatrix[20078]={type=38,effect1=2,effect2=11,effect3=0,effect4=0,effect5=0,effect6=0,effect7=0}
		CidMatrix[20079]={type=38,effect1=2,effect2=12,effect3=0,effect4=0,effect5=0,effect6=0,effect7=0}	
		CidMatrix[20080]={type=38,effect1=2,effect2=13,effect3=0,effect4=0,effect5=0,effect6=0,effect7=0}	
		CidMatrix[20081]={type=38,effect1=2,effect2=14,effect3=0,effect4=0,effect5=0,effect6=0,effect7=0}	
		CidMatrix[20082]={type=38,effect1=2,effect2=15,effect3=0,effect4=0,effect5=0,effect6=0,effect7=0}
		CidMatrix[20083]={type=38,effect1=2,effect2=16,effect3=0,effect4=0,effect5=0,effect6=0,effect7=0}
		CidMatrix[20084]={type=38,effect1=2,effect2=17,effect3=0,effect4=0,effect5=0,effect6=0,effect7=0}	
		CidMatrix[20085]={type=38,effect1=2,effect2=18,effect3=0,effect4=0,effect5=0,effect6=0,effect7=0}	
		CidMatrix[20086]={type=38,effect1=2,effect2=19,effect3=0,effect4=0,effect5=0,effect6=0,effect7=0}	
		CidMatrix[20087]={type=38,effect1=2,effect2=20,effect3=0,effect4=0,effect5=0,effect6=0,effect7=0}											
		
		---//����껯Getҩ��(��ʱid��ռ���˳ɳ��۲�ҩ��)
		CidMatrix[22990]={type=39,effect1=0,effect2=0,effect3=0,effect4=0,effect5=0,effect6=0,effect7=0}

		---//����껯Setҩ��(��ʱid��ռ���˳ɳ��۲�ҩ��)
		CidMatrix[22992]={type=40,effect1=16503,effect2=0,effect3=0,effect4=0,effect5=0,effect6=0,effect7=0}
		CidMatrix[22993]={type=40,effect1=16504,effect2=0,effect3=0,effect4=0,effect5=0,effect6=0,effect7=0}
		CidMatrix[22994]={type=40,effect1=16505,effect2=0,effect3=0,effect4=0,effect5=0,effect6=0,effect7=0}
		CidMatrix[22995]={type=40,effect1=16506,effect2=0,effect3=0,effect4=0,effect5=0,effect6=0,effect7=0}
		CidMatrix[22996]={type=40,effect1=16507,effect2=0,effect3=0,effect4=0,effect5=0,effect6=0,effect7=0}
		CidMatrix[22997]={type=40,effect1=16508,effect2=0,effect3=0,effect4=0,effect5=0,effect6=0,effect7=0}
		CidMatrix[22998]={type=40,effect1=18306,effect2=0,effect3=0,effect4=0,effect5=0,effect6=0,effect7=0}
		CidMatrix[22999]={type=40,effect1=18929,effect2=0,effect3=0,effect4=0,effect5=0,effect6=0,effect7=0}
		CidMatrix[23000]={type=40,effect1=19510,effect2=0,effect3=0,effect4=0,effect5=0,effect6=0,effect7=0}
		CidMatrix[23001]={type=40,effect1=20108,effect2=0,effect3=0,effect4=0,effect5=0,effect6=0,effect7=0}
		CidMatrix[23002]={type=40,effect1=19110,effect2=0,effect3=0,effect4=0,effect5=0,effect6=0,effect7=0}
		CidMatrix[23003]={type=40,effect1=20488,effect2=0,effect3=0,effect4=0,effect5=0,effect6=0,effect7=0}
		CidMatrix[23004]={type=40,effect1=20489,effect2=0,effect3=0,effect4=0,effect5=0,effect6=0,effect7=0}
		CidMatrix[23005]={type=40,effect1=20561,effect2=0,effect3=0,effect4=0,effect5=0,effect6=0,effect7=0}
		CidMatrix[23006]={type=40,effect1=22105,effect2=0,effect3=0,effect4=0,effect5=0,effect6=0,effect7=0}
		CidMatrix[23007]={type=40,effect1=22484,effect2=0,effect3=0,effect4=0,effect5=0,effect6=0,effect7=0}
		CidMatrix[23008]={type=40,effect1=21247,effect2=0,effect3=0,effect4=0,effect5=0,effect6=0,effect7=0}
		CidMatrix[23338]={type=40,effect1=23337,effect2=0,effect3=0,effect4=0,effect5=0,effect6=0,effect7=0}		
		
		return CidMatrix
end 

---������������-----------------------------------------------------------------------------------
function ZLuaPetBedgeHolyReborn(pet_tid,pet_in,pet_out,cid,aid,origin)
	if ZLuaPetBedgeExistInTmplIDs(pet_tid) == 0 then return end
	if pet_in == nil then return end
	local petstar=pet_in:QueryStar()
	local petlevel=pet_in:QueryLevel()
	if petstar>5 then 
		return 0,0,88
	end 
	local DataIndex=ZLuaPetBedgeDataIndex()
	PetBedgeInit(pet_tid,pet_out,origin)
	pet_out:UpdateData(DataIndex["identify"], 1)
	pet_out:SetLevel(petlevel)
	return pet_tid,0,1
end 
---�������----------------------------------------------------------------------------------------
function ZLuaPetBedgeIdentify(pet_tid,pet_in,pet_out,cid,aid,origin)
	if ZLuaPetBedgeExistInTmplIDs(pet_tid) == 0 then return end
	if pet_in == nil then return end
	local DataIndex=ZLuaPetBedgeDataIndex()
	local ServerOrigins=ZLuaPetBedgeOrigins()
	local isidentify=pet_in:QueryIdentify()
	if isidentify==0 then 
		pet_out:UpdateData(DataIndex["identify"], 1)
		return pet_tid,0,1
	else 
		---//�����Ѿ�����
		return 0,0,2	
	end 		
end 
---����ı�����------------------------------------------------------------------------------------
function ZLuaPetBedgeChangeAge(pet_tid,pet_in,pet_out,cid,aid,origin)
	if ZLuaPetBedgeExistInTmplIDs(pet_tid) == 0 then return end
	if pet_in == nil then return end
	local DataIndex=ZLuaPetBedgeDataIndex()
	local ServerOrigins=ZLuaPetBedgeOrigins()
	local CidMatrix=ZLuaPetBedgeCidMatrix()
	
	local howmanyage=pet_in:QueryAge()
	howmanyage=math.min(math.max(howmanyage-CidMatrix[cid].effect1,1),pet_in:QueryLife())
	pet_out:SetAge(howmanyage)

	return pet_tid,0,3
end 
---����ı�����------------------------------------------------------------------------------------
function ZLuaPetBedgeChangeLife(pet_tid,pet_in,pet_out,cid,aid,origin)
	if ZLuaPetBedgeExistInTmplIDs(pet_tid) == 0 then return end
	if pet_in == nil then return end
	local DataIndex=ZLuaPetBedgeDataIndex()
	local ServerOrigins=ZLuaPetBedgeOrigins()
	local CidMatrix=ZLuaPetBedgeCidMatrix()
	
	local howmanylife=pet_in:QueryLife()
	if howmanylife<25000 then 
		howmanylife=math.min(howmanylife+CidMatrix[cid].effect1,25000)
		pet_out:SetLife(howmanylife)
		return pet_tid,0,4
	else 
		return 0,0,5	 
	end 
	
end 
---����ı�����(�Ը�)------------------------------------------------------------------------------
function ZLuaPetBedgeChangeEmement(pet_tid,pet_in,pet_out,cid,aid,origin)
	if ZLuaPetBedgeExistInTmplIDs(pet_tid) == 0 then return end
	if pet_in == nil then return end
	local CidMatrix=ZLuaPetBedgeCidMatrix()
	local DataIndex=ZLuaPetBedgeDataIndex()
	local ServerOrigins=ZLuaPetBedgeOrigins()
	local Emement=ZLuaPetBedgeElementDesc()
	local cidelement=CidMatrix[cid].effect1
	local newelement=pet_in:QueryElement()
	
	---�뵱ǰ�Ը���ͬ��ʧ��
	if pet_in:QueryElement()==cidelement and cidelement~=99 then 
		return 0,0,6
	end 
	if cidelement==99 then 
		newelement=ZLuaPetBedgeElementInfo(pet_tid) 
	else
		newelement=cidelement
	end 
 	
 	pet_out:UpdateData(DataIndex["element"], newelement)
	return pet_tid,0,7
end 

---����ı��츳------------------------------------------------------------------------------------
function ZLuaPetBedgeChangeTalent(pet_tid,pet_in,pet_out,cid,aid,origin)
	if ZLuaPetBedgeExistInTmplIDs(pet_tid) == 0 then return end
	if pet_in == nil then return end
	local CidMatrix=ZLuaPetBedgeCidMatrix()
	local DataIndex=ZLuaPetBedgeDataIndex()
	local ServerOrigins=ZLuaPetBedgeOrigins()
	local TalentsChoosed
	local TalentsList={}	
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

		---//13����Ϊ�����������
		TalentsList[14]={10,0,5,0,0,0,0,0,0,0,5,0,0}
		TalentsList[15]={0,10,0,5,0,0,0,0,0,0,0,5,0}
		TalentsList[16]={5,0,10,0,5,0,0,0,0,0,0,0,0}
		TalentsList[17]={0,5,0,10,0,5,0,0,0,0,0,0,0}
		TalentsList[18]={0,0,5,0,10,0,5,0,0,0,0,0,0}
		TalentsList[19]={0,0,0,5,0,10,0,5,0,0,0,0,0}
		TalentsList[20]={0,0,0,0,5,0,10,0,5,0,0,0,0}
		TalentsList[21]={0,0,0,0,0,5,0,10,0,5,0,0,0}
		TalentsList[22]={0,0,0,0,0,0,5,0,10,0,5,0,0}
		TalentsList[23]={0,0,0,0,0,0,0,5,0,10,0,5,0}
		TalentsList[24]={0,0,0,0,0,0,0,0,5,0,10,0,5}
		TalentsList[25]={0,5,0,0,0,0,0,0,0,5,0,10,0}
		TalentsList[26]={0,0,0,5,0,0,0,5,0,0,0,5,10}
		
	local c=CidMatrix[cid].effect1
	if c>1 and c<=13 then TalentsChoosed=c end 
	if c==14 then TalentsChoosed=math.floor(math.random()*13+1) end 
	if c~=15 and (TalentsChoosed>13 or TalentsChoosed<1) then TalentsChoosed=1 end 
	if c==15 then TalentsChoosed=math.floor(math.random()*table.getn(TalentsList)+1) end 
	if c==15 and 	TalentsChoosed>table.getn(TalentsList) then TalentsChoosed=1 end 
	
	pet_out:UpdateData(DataIndex["talent_1"], TalentsList[TalentsChoosed][1] or 0)	
	pet_out:UpdateData(DataIndex["talent_2"], TalentsList[TalentsChoosed][2] or 0)	
	pet_out:UpdateData(DataIndex["talent_3"], TalentsList[TalentsChoosed][3] or 0)	
	pet_out:UpdateData(DataIndex["talent_4"], TalentsList[TalentsChoosed][4] or 0)	
	pet_out:UpdateData(DataIndex["talent_5"], TalentsList[TalentsChoosed][5] or 0)	
	pet_out:UpdateData(DataIndex["talent_6"], TalentsList[TalentsChoosed][6] or 0)	
	pet_out:UpdateData(DataIndex["talent_7"], TalentsList[TalentsChoosed][7] or 0)	
	pet_out:UpdateData(DataIndex["talent_8"], TalentsList[TalentsChoosed][8] or 0)	
	pet_out:UpdateData(DataIndex["talent_9"], TalentsList[TalentsChoosed][9] or 0)	
	pet_out:UpdateData(DataIndex["talent_10"], TalentsList[TalentsChoosed][10] or 0)	
	pet_out:UpdateData(DataIndex["talent_11"], TalentsList[TalentsChoosed][11] or 0)	
	pet_out:UpdateData(DataIndex["talent_12"], TalentsList[TalentsChoosed][12] or 0)	
	pet_out:UpdateData(DataIndex["talent_13"], TalentsList[TalentsChoosed][13] or 0)
	pet_out:UpdateData(DataIndex["isspecial"], 0)

	return pet_tid,0,8
	
end 
---����ѧϰ����-------------------------------------------------------------------------------------
function ZLuaPetBedgeLearnSkill(pet_tid,pet_in,pet_out,cid,aid,origin)
	if ZLuaPetBedgeExistInTmplIDs(pet_tid) == 0 then return end
	if pet_in == nil then return end
	local CidMatrix=ZLuaPetBedgeCidMatrix()
	local AidMatrix=ZLuaPetBedgeAidMatrix()
	local DataIndex=ZLuaPetBedgeDataIndex()
	local ServerOrigins=ZLuaPetBedgeOrigins()
	local Horoscope=ZLuaPetBedgeHoroscopeDesc()
	local Race=ZLuaPetBedgeRaceDesc()
	---//type=7	 	����ѧϰ����,effect1(�ʺ�ְҵ0-8,99ͨ��),effect2(����ָ��id),effect3(׷�Ӽ��ܼ���)
	---//					effect4(�����ɹ�����>100,ʵ�ʳɹ���Ϊ100-���弶��)
	
	---���ܵļ���ѧϰ��������
	local pet_level,pet_horoscope,pet_race,pet_shape
		pet_level=pet_in:QueryLevel()
		pet_race=pet_in:QueryData(DataIndex["race"])	
		pet_horoscope=pet_in:QueryData(DataIndex["horoscope"])	
		pet_shape=pet_in:QueryData(DataIndex["shape"])	
		
	---//���಻����ѧϰ����
	if pet_horoscope~=CidMatrix[cid].effect1 and CidMatrix[cid].effect1~=99 then 
		return 0,0,9
	end 
	
	local petskill_id,petskill_lvl={},{}
	---//ֻ�Ե�2-8�����ܲſ���ʹ�ü��ܾ���
	petskill_id[1]=pet_in:QueryData(DataIndex["skillid_1"]) or 0	
	petskill_id[2]=pet_in:QueryData(DataIndex["skillid_2"])	or 0
	petskill_id[3]=pet_in:QueryData(DataIndex["skillid_3"])	or 0
	petskill_id[4]=pet_in:QueryData(DataIndex["skillid_4"])	or 0
	petskill_id[5]=pet_in:QueryData(DataIndex["skillid_5"])	or 0
	petskill_id[6]=pet_in:QueryData(DataIndex["skillid_6"])	or 0
	petskill_id[7]=pet_in:QueryData(DataIndex["skillid_7"])	or 0
	
	petskill_lvl[1]=pet_in:QueryData(DataIndex["skilllvl_1"])	or 0
	petskill_lvl[2]=pet_in:QueryData(DataIndex["skilllvl_2"])	or 0
	petskill_lvl[3]=pet_in:QueryData(DataIndex["skilllvl_3"])	or 0
	petskill_lvl[4]=pet_in:QueryData(DataIndex["skilllvl_4"])	or 0
	petskill_lvl[5]=pet_in:QueryData(DataIndex["skilllvl_5"])	or 0
	petskill_lvl[6]=pet_in:QueryData(DataIndex["skilllvl_6"])	or 0
	petskill_lvl[7]=pet_in:QueryData(DataIndex["skilllvl_7"])	or 0
	
	local TotalSkills=0					---//���м�������
	local IsExistSameSkill=0		---//�Ƿ������ͬ����
	local IsExistPosition=0			---//�Ƿ��пհ�λ��
	local BlankPostion=0				---//�հ�λ������
	local UsingAidType=99				---//ʹ�õ�aid������
	
	UsingAidType=AidMatrix[aid].type or 99
	local CidItemLevel=0					---//������ĵ���
	CidItemLevel=CidMatrix[cid].effect5
		
	for i=1,7 do
		if petskill_id[i]==CidMatrix[cid].effect2 then 
				IsExistSameSkill=1
		---//������ͬ����
		---//ʹ���˼��������������ߣ�����ʹ�ó��ﲻ��ļ��ܾ��һ����Ӽ�������
				if UsingAidType==1 and aid~=0 then
					return 0,0,94
				end  
				if ZPetBedge_ChanceCalc(CidMatrix[cid].effect4-petskill_lvl[i])==1 and petskill_lvl[i]<=30+30*CidItemLevel then 
					petskill_lvl[i]=petskill_lvl[i]+1
					pet_out:UpdateData(DataIndex["skilllvl_1"],petskill_lvl[1])
					pet_out:UpdateData(DataIndex["skilllvl_2"],petskill_lvl[2])
					pet_out:UpdateData(DataIndex["skilllvl_3"],petskill_lvl[3])
					pet_out:UpdateData(DataIndex["skilllvl_4"],petskill_lvl[4])
					pet_out:UpdateData(DataIndex["skilllvl_5"],petskill_lvl[5])
					pet_out:UpdateData(DataIndex["skilllvl_6"],petskill_lvl[6])
					pet_out:UpdateData(DataIndex["skilllvl_7"],petskill_lvl[7])
					return pet_tid,0,10	
				else
					if petskill_lvl[i]>30 and CidItemLevel==0 then 
						return 0,0,11
					elseif petskill_lvl[i]>60 and CidItemLevel==1 then 
						return 0,0,97
					else
						return 0,0,12
					end 
				end 
		end
		if petskill_id[i]~=0 and petskill_id[i]~=nil then
			TotalSkills=TotalSkills+1
		end 
	end 	
	---//��������ͬ����
	local msg_no_exsit_case=13
	---//������߼�
	if IsExistSameSkill==0 and UsingAidType~=1 then 
			local RandomPostion=math.max(math.min(math.floor(math.random()*TotalSkills+1),TotalSkills),1)
			petskill_id[RandomPostion]=CidMatrix[cid].effect2
			petskill_lvl[RandomPostion]=CidMatrix[cid].effect3			
			msg_no_exsit_case=14
		pet_out:UpdateData(DataIndex["skillid_1"],petskill_id[1])
		pet_out:UpdateData(DataIndex["skillid_2"],petskill_id[2])
		pet_out:UpdateData(DataIndex["skillid_3"],petskill_id[3])
		pet_out:UpdateData(DataIndex["skillid_4"],petskill_id[4])
		pet_out:UpdateData(DataIndex["skillid_5"],petskill_id[5])
		pet_out:UpdateData(DataIndex["skillid_6"],petskill_id[6])
		pet_out:UpdateData(DataIndex["skillid_7"],petskill_id[7])	
				
		pet_out:UpdateData(DataIndex["skilllvl_1"],petskill_lvl[1])
		pet_out:UpdateData(DataIndex["skilllvl_2"],petskill_lvl[2])
		pet_out:UpdateData(DataIndex["skilllvl_3"],petskill_lvl[3])
		pet_out:UpdateData(DataIndex["skilllvl_4"],petskill_lvl[4])
		pet_out:UpdateData(DataIndex["skilllvl_5"],petskill_lvl[5])
		pet_out:UpdateData(DataIndex["skilllvl_6"],petskill_lvl[6])
		pet_out:UpdateData(DataIndex["skilllvl_7"],petskill_lvl[7])
		
		return pet_tid,0,msg_no_exsit_case
	---//�������߼�
	elseif IsExistSameSkill==0 and UsingAidType==1 and aid~=0 then 
		if TotalSkills>=7 then 
			return 0,0,96	
		elseif pet_in:QueryData(DataIndex["reserve1"])==1 then 
			return 0,0,207		
		else 
			if 	TotalSkills==1 then 
				pet_out:UpdateData(DataIndex["skillid_2"],CidMatrix[cid].effect2)	
				pet_out:UpdateData(DataIndex["skilllvl_2"],CidMatrix[cid].effect3)
			 	pet_out:UpdateData(DataIndex["reserve1"], 1)
			elseif TotalSkills==2 then
				pet_out:UpdateData(DataIndex["skillid_3"],CidMatrix[cid].effect2)	
				pet_out:UpdateData(DataIndex["skilllvl_3"],CidMatrix[cid].effect3)
				pet_out:UpdateData(DataIndex["reserve1"], 1)
			elseif TotalSkills==3 then
				pet_out:UpdateData(DataIndex["skillid_4"],CidMatrix[cid].effect2)	
				pet_out:UpdateData(DataIndex["skilllvl_4"],CidMatrix[cid].effect3)
				pet_out:UpdateData(DataIndex["reserve1"], 1)
			elseif TotalSkills==4 then
				pet_out:UpdateData(DataIndex["skillid_5"],CidMatrix[cid].effect2)	
				pet_out:UpdateData(DataIndex["skilllvl_5"],CidMatrix[cid].effect3)
				pet_out:UpdateData(DataIndex["reserve1"], 1)
			elseif TotalSkills==5 then
				pet_out:UpdateData(DataIndex["skillid_6"],CidMatrix[cid].effect2)	
				pet_out:UpdateData(DataIndex["skilllvl_6"],CidMatrix[cid].effect3)
				pet_out:UpdateData(DataIndex["reserve1"], 1)
			elseif TotalSkills==6 then
				pet_out:UpdateData(DataIndex["skillid_7"],CidMatrix[cid].effect2)	
				pet_out:UpdateData(DataIndex["skilllvl_7"],CidMatrix[cid].effect3)
				pet_out:UpdateData(DataIndex["reserve1"], 1)
			else
				return 0,0,96	
			end 
			return pet_tid,0,95
		end 
	else 
		return 0,0,96	
	end 
	
end 
---������������------------------------------------------------------------------------------------
---//�˹�����δ����
function ZLuaPetBedgeForgetSkill(pet_tid,pet_in,pet_out,cid,aid,origin)
	if ZLuaPetBedgeExistInTmplIDs(pet_tid) == 0 then return end
	if pet_in == nil then return end
	local CidMatrix=ZLuaPetBedgeCidMatrix()
	local DataIndex=ZLuaPetBedgeDataIndex()
	local ServerOrigins=ZLuaPetBedgeOrigins()	
	local positonchoosed
	return pet_tid,0,99
end 
---����������ܶȵ�ǰֵ----------------------------------------------------------------------------
function ZLuaPetBedgeChangeCurHonor(pet_tid,pet_in,pet_out,cid,aid,origin)
	if ZLuaPetBedgeExistInTmplIDs(pet_tid) == 0 then return end
	if pet_in == nil then return end
	local CidMatrix=ZLuaPetBedgeCidMatrix()
	local DataIndex=ZLuaPetBedgeDataIndex()
	local ServerOrigins=ZLuaPetBedgeOrigins()
	if pet_in:QueryCurHonorPoint()>=pet_in:QueryMaxHonorPoint()*CidMatrix[cid].effect2 then 
		return 0,0,15
	else 
		pet_out:SetCurHonorPoint(math.min(pet_in:QueryCurHonorPoint()+CidMatrix[cid].effect1,pet_in:QueryMaxHonorPoint()))
		return pet_tid,0,16
	end 
end 
---����������ܶ�����------------------------------------------------------------------------------
function ZLuaPetBedgeChangeMaxHonor(pet_tid,pet_in,pet_out,cid,aid,origin)
	if ZLuaPetBedgeExistInTmplIDs(pet_tid) == 0 then return end
	if pet_in == nil then return end
	local CidMatrix=ZLuaPetBedgeCidMatrix()
	local DataIndex=ZLuaPetBedgeDataIndex()
	local ServerOrigins=ZLuaPetBedgeOrigins()
	local preMaxHornorPoint
	if pet_in:QueryMaxHonorPoint()>=57600 then 
		return 0,0,17
	else 
		preMaxHonorPoint=pet_in:QueryMaxHonorPoint()+CidMatrix[cid].effect1
		pet_out:SetMaxHonorPoint(math.min(preMaxHonorPoint,57600))	
		return pet_tid,0,18
	end 	

end 
---�������ս�����Եĳɹ����ʻ���ֵ����------------------------------------------------------------
function ZLuaPetBedgeCombatGrowChance(pet,poisongrowtype,level)
	if level<0 or level>150 then return end 
	local BaseCombineChance={}
	local pseudogrades=ZLuaPetBedgeSuperPseudoGrades()
	local nowgrades,nowposition=pseudogrades[1],1
	---��ǰ�ɳ���,�ɳ������ڵĵ�λ
	local DataIndex=ZLuaPetBedgeDataIndex() 
	---//�˴����ͺ�Ϊ��д,ע���޸�
	if poisongrowtype==11 then 
		nowgrades=pet:QueryData(DataIndex["potential_hp"])
	elseif poisongrowtype==12 then 
		nowgrades=pet:QueryData(DataIndex["potential_mp"])
	elseif poisongrowtype==13 then 
		nowgrades=pet:QueryData(DataIndex["potential_minatk"])
	elseif poisongrowtype==14 then 
		nowgrades=pet:QueryData(DataIndex["potential_maxatk"])
	elseif poisongrowtype==15 then 
		nowgrades=pet:QueryData(DataIndex["potential_def"])
	elseif poisongrowtype==16 then 	
		nowgrades=pet:QueryData(DataIndex["potential_attackrate"])
	elseif poisongrowtype==17 then 
		nowgrades=pet:QueryData(DataIndex["potential_dodge"])
	elseif poisongrowtype==18 then 
		nowgrades=pet:QueryData(DataIndex["potential_resist1"])
	elseif poisongrowtype==19 then 
		nowgrades=pet:QueryData(DataIndex["potential_resist2"])
	elseif poisongrowtype==20 then
		nowgrades=pet:QueryData(DataIndex["potential_resist3"])
	elseif poisongrowtype==21 then 
		nowgrades=pet:QueryData(DataIndex["potential_resist4"])
	elseif poisongrowtype==22 then	
		nowgrades=pet:QueryData(DataIndex["potential_resist5"])
	elseif poisongrowtype==23 then
		nowgrades=pet:QueryData(DataIndex["potential_resist6"])
	else
		nowgrades=pseudogrades[1]
	end 
	for i=1,table.getn(pseudogrades)-1 do
		if nowgrades>=pseudogrades[i] and nowgrades<pseudogrades[i+1] then 
			nowposition=i	
		elseif nowgrades>=pseudogrades[table.getn(pseudogrades)] then 
			nowposition=table.getn(pseudogrades)
		end 
	end 

	if nowposition<1 or nowposition>table.getn(pseudogrades) then
		nowposition=table.getn(pseudogrades)
	end 
	BaseCombineChance={99,95,90,85,80,75,75,70,70,65,
										 60,55,50,45,40,35,30,25,25,25,
										 20,20,20,20,15,15,15,10,10,10,
										 5,5,5,5,5,5,5,5,5,5,
										 5,5,5,5,5,5,5,5,5,5,
										 5,5,5,5,5,5,5,5,5,5}	
	return BaseCombineChance[nowposition]
end 

---�������ս���������ֵ--------------------------------------------------------------------------
function ZLuaPetBedgeCombatPropDeal(pet_tid,pet_in,pet_out,cid,aid,origin,usetype)
	if ZLuaPetBedgeExistInTmplIDs(pet_tid) == 0 then return end
	if type(cid)~="number" or type(aid)~="number" then return end 
	if pet_in == nil then return end

	local CidMatrix=ZLuaPetBedgeCidMatrix()
	local AidMatrix=ZLuaPetBedgeAidMatrix()
	local DataIndex=ZLuaPetBedgeDataIndex()
	local GradeDirection=ZLuaPetBedgeGradeDirection()
	local ServerOrigins=ZLuaPetBedgeOrigins()
	
	local NativeStar,NativeLevel,NativeGrowChance
	local PoisonGrowType,PoisonBaseGrowChance,PoisonBaseGrowEffect
	local PoisonUseMaxStar
		---//�����ǵ�/���Ｖ��/�������Ӧgrades�ͼ���Ļ����ϳɳɹ���
		---//ҩ�ṩ�ĳɳ���/ҩ�ṩ�Ķ���ɹ���/ҩ�ṩ�Ļ���Ч��
		---//������߿�ʹ�õ�����ǵ�
	NativeStar=pet_in:QueryData(DataIndex["star"])
	NativeLevel=pet_in:QueryLevel()
	
	if usetype==1 then
		---���γɳ�ʹ������
		PoisonGrowType=CidMatrix[cid].type
		PoisonBaseGrowChance=CidMatrix[cid].effect1
		PoisonBaseGrowEffect=CidMatrix[cid].effect2
		PoisonUseMaxStar=CidMatrix[cid].effect3
	elseif usetype>1 and type(usetype)=="number" then 
		---���γɳ�ʹ������
		PoisonGrowType=usetype
		PoisonBaseGrowChance=CidMatrix[cid].effect4
		PoisonBaseGrowEffect=CidMatrix[cid].effect5
		PoisonUseMaxStar=CidMatrix[cid].effect6
	else
		---���γɳ�ʹ������
		PoisonGrowType=CidMatrix[cid].type
		PoisonBaseGrowChance=0
		PoisonBaseGrowEffect=0
		PoisonUseMaxStar=20
	end 

	---//����ʧ�ܻ�õ�΢������������
	local PosionFailedSmallGrow=1
	PosionFailedSmallGrow=CidMatrix[cid].effect7
	---//��ǰ�ۼƵ�΢������������ϵ��
	local NowSmallGrow=math.floor(pet_in:QueryData(DataIndex["smallgrow"])/10)
	
	
	local ItemAddGrowChance,ItemGrowEffectInc
	---//�����ṩ�Ķ���ɹ���,�����ṩ��Ч���ӳ�
	ItemAddGrowChance=AidMatrix[aid].effect1
	ItemGrowEffectInc=AidMatrix[aid].effect2
	
	
	local RaceAddGrowChance=0
	---//�����ṩ�Ķ���ɹ���
	local Race=ZLuaPetBedgeRaceDesc()
	local race=pet_in:QueryData(DataIndex["race"])
	if race==Race["renzu"] then 
		RaceAddGrowChance=3 
	end 
		
	local MainType,Element,Origin,Horoscope
	---�����������/����/��Դ
	MainType=pet_in:QueryMainType()
	Element=pet_in:QueryElement()
	Horoscope=pet_in:QueryHoroscope()
	Origin=pet_in:QueryData(DataIndex["nativeorigin"])
	
	local MainTypeGrowEffectInc=0
	---//���������͵��µĳɳ�����	
	MainTypeGrowEffectInc=ZLuaPetBedgeMaintypeGrowEffect(MainType,PoisonGrowType)
	
	---�������Ҫ���Գɳ�����
	local MaxGrowGrades={}
	MaxGrowGrades=ZLuaPetBedgeMaxGrowGrades(pet_tid,MainType,Horoscope,Origin)
	
	---ʹ�ø������߲���ȷ
	if aid~=0 and AidMatrix[aid].type~=0 then 
		return 0,0,208
	end 	
	
	---�����ǵȳ�����Ʒ������ʹ���ǵ�
	if PoisonUseMaxStar<=NativeStar and PoisonUseMaxStar~=20 then 
		return 0,0,19		
	end 	
	
	---����ɳ������ѡȡ�ɳ�����
	if PoisonGrowType==25 then 
		PoisonGrowType=ZLuaChooseNormalNums(11,24,1) 
	end 
	
	local TotalGrowChance,TotalGrowEffect,TotalGrowCalc
	---//�ܳɹ���(ת����),�����ṩ����Ч��,�ܳɹ��ʼ�������ж�����
	NativeGrowChance=ZLuaPetBedgeCombatGrowChance(pet_in,PoisonGrowType,NativeLevel)	
	TotalGrowChance=NativeGrowChance+PoisonBaseGrowChance+ItemAddGrowChance+RaceAddGrowChance
	TotalGrowCalc=ZPetBedge_ChanceCalc(TotalGrowChance)
	TotalGrowEffect=PoisonBaseGrowEffect*(1+ItemGrowEffectInc+MainTypeGrowEffectInc)
	
	if PoisonGrowType==11 then 
	---//type=11	�������Գɳ�(��Ѫ),effect1(����1-100),effect2(����ֵ)
		if pet_in:QueryData(DataIndex["potential_hp"])<MaxGrowGrades[GradeDirection["potential_hp"]] then 
			if TotalGrowCalc==1 then 
				pet_out:UpdateData(DataIndex["potential_hp"],math.min(pet_in:QueryData(DataIndex["potential_hp"])+TotalGrowEffect,
				MaxGrowGrades[GradeDirection["potential_hp"]]))
				pet_out:UpdateData(DataIndex["feedtimes"], pet_in:QueryData(DataIndex["feedtimes"])+1)	
				return pet_tid,0,20
			else
				if pet_in:QueryData(DataIndex["smallgrow"])>=10 then 
					pet_out:UpdateData(DataIndex["potential_hp"],math.min(pet_in:QueryData(DataIndex["potential_hp"])+NowSmallGrow,
					MaxGrowGrades[GradeDirection["potential_hp"]]))
					pet_out:UpdateData(DataIndex["smallgrow"],pet_in:QueryData(DataIndex["smallgrow"])-10*NowSmallGrow)
				else
					pet_out:UpdateData(DataIndex["smallgrow"],pet_in:QueryData(DataIndex["smallgrow"])+PosionFailedSmallGrow)
				end 
				return pet_tid,0,21
			end 		
		else
				return 0,0,22			
		end 
	elseif PoisonGrowType==12 then 
		---//type=12	�������Գɳ�(����),effect1(����1-100),effect2(����ֵ)
		if pet_in:QueryData(DataIndex["potential_mp"])<MaxGrowGrades[GradeDirection["potential_mp"]] then 
			if TotalGrowCalc==1 then 
				pet_out:UpdateData(DataIndex["potential_mp"],math.min(pet_in:QueryData(DataIndex["potential_mp"])+TotalGrowEffect,
				MaxGrowGrades[GradeDirection["potential_mp"]]))
				pet_out:UpdateData(DataIndex["feedtimes"], pet_in:QueryData(DataIndex["feedtimes"])+1)	
				return pet_tid,0,23
			else
				if pet_in:QueryData(DataIndex["smallgrow"])>=10 then 
					pet_out:UpdateData(DataIndex["potential_mp"],math.min(pet_in:QueryData(DataIndex["potential_mp"])+NowSmallGrow,
					MaxGrowGrades[GradeDirection["potential_mp"]]))
					pet_out:UpdateData(DataIndex["smallgrow"],pet_in:QueryData(DataIndex["smallgrow"])-10*NowSmallGrow)
				else
					pet_out:UpdateData(DataIndex["smallgrow"],pet_in:QueryData(DataIndex["smallgrow"])+PosionFailedSmallGrow)
				end
				return pet_tid,0,24
			end 		
		else
				return 0,0,25			
		end 
	elseif PoisonGrowType==13 then
	---//type=13	�������Գɳ�(��С����),effect1(����1-100),effect2(����ֵ)
		if pet_in:QueryData(DataIndex["potential_minatk"])<MaxGrowGrades[GradeDirection["potential_minatk"]] and
		 pet_in:QueryData(DataIndex["potential_minatk"])<pet_in:QueryData(DataIndex["potential_maxatk"]) then 
			if TotalGrowCalc==1 then 
				if pet_in:QueryData(DataIndex["potential_minatk"])>=pet_in:QueryData(DataIndex["potential_maxatk"]) then
					return 0,0,26
				else
				pet_out:UpdateData(DataIndex["potential_minatk"],math.min(pet_in:QueryData(DataIndex["potential_minatk"])+TotalGrowEffect,
				MaxGrowGrades[GradeDirection["potential_minatk"]],pet_in:QueryData(DataIndex["potential_maxatk"])))
				pet_out:UpdateData(DataIndex["feedtimes"], pet_in:QueryData(DataIndex["feedtimes"])+1)	
					return pet_tid,0,27
				end 
			else
				if pet_in:QueryData(DataIndex["smallgrow"])>=10 then 
					pet_out:UpdateData(DataIndex["potential_minatk"],math.min(pet_in:QueryData(DataIndex["potential_minatk"])+NowSmallGrow,
					MaxGrowGrades[GradeDirection["potential_minatk"]],pet_in:QueryData(DataIndex["potential_maxatk"])))
					pet_out:UpdateData(DataIndex["smallgrow"],pet_in:QueryData(DataIndex["smallgrow"])-10*NowSmallGrow)
				else
					pet_out:UpdateData(DataIndex["smallgrow"],pet_in:QueryData(DataIndex["smallgrow"])+PosionFailedSmallGrow)
				end
				return pet_tid,0,28
			end 		
		else
				return 0,0,29			
		end 
	elseif PoisonGrowType==14 then
	---//type=14	�������Գɳ�(��󹥻�),effect1(����1-100),effect2(����ֵ)
		if pet_in:QueryData(DataIndex["potential_maxatk"])<MaxGrowGrades[GradeDirection["potential_maxatk"]] then 
			if TotalGrowCalc==1 then 
				pet_out:UpdateData(DataIndex["potential_maxatk"],math.min(pet_in:QueryData(DataIndex["potential_maxatk"])+TotalGrowEffect,
				MaxGrowGrades[GradeDirection["potential_maxatk"]]))
				pet_out:UpdateData(DataIndex["feedtimes"], pet_in:QueryData(DataIndex["feedtimes"])+1)	
				return pet_tid,0,30
			else
				if pet_in:QueryData(DataIndex["smallgrow"])>=10 then 
					pet_out:UpdateData(DataIndex["potential_maxatk"],math.min(pet_in:QueryData(DataIndex["potential_maxatk"])+NowSmallGrow,
					MaxGrowGrades[GradeDirection["potential_maxatk"]]))
					pet_out:UpdateData(DataIndex["smallgrow"],pet_in:QueryData(DataIndex["smallgrow"])-10*NowSmallGrow)
				else
					pet_out:UpdateData(DataIndex["smallgrow"],pet_in:QueryData(DataIndex["smallgrow"])+PosionFailedSmallGrow)
				end 
				return pet_tid,0,31
			end 		
		else
				return 0,0,32			
		end 
	elseif PoisonGrowType==24  then
	---//type=15	�������Գɳ�(ͨ�ù���),effect1(����1-100),effect2(����ֵ)
		if pet_in:QueryData(DataIndex["potential_minatk"])<MaxGrowGrades[GradeDirection["potential_minatk"]] and
				 pet_in:QueryData(DataIndex["potential_minatk"])<=pet_in:QueryData(DataIndex["potential_maxatk"]) and
				 pet_in:QueryData(DataIndex["potential_maxatk"])<=MaxGrowGrades[GradeDirection["potential_maxatk"]] then 
			if TotalGrowCalc==1 then 
				pet_out:UpdateData(DataIndex["potential_minatk"],math.min(pet_in:QueryData(DataIndex["potential_minatk"])+TotalGrowEffect,
				MaxGrowGrades[GradeDirection["potential_minatk"]],pet_in:QueryData(DataIndex["potential_maxatk"])))
				pet_out:UpdateData(DataIndex["potential_maxatk"],math.min(pet_in:QueryData(DataIndex["potential_maxatk"])+TotalGrowEffect,
				MaxGrowGrades[GradeDirection["potential_maxatk"]]))
				pet_out:UpdateData(DataIndex["feedtimes"], pet_in:QueryData(DataIndex["feedtimes"])+2)	
				return pet_tid,0,33
			else
				return pet_tid,0,34
			end 		
		else
				return 0,0,35			
		end 
	elseif PoisonGrowType==15 then
	---//type=16	�������Գɳ�(����),effect1(����1-100),effect2(����ֵ)
		if pet_in:QueryData(DataIndex["potential_def"])<MaxGrowGrades[GradeDirection["potential_def"]] then 
			if TotalGrowCalc==1 then 
				pet_out:UpdateData(DataIndex["potential_def"],math.min(pet_in:QueryData(DataIndex["potential_def"])+TotalGrowEffect,
				MaxGrowGrades[GradeDirection["potential_def"]]))
				pet_out:UpdateData(DataIndex["feedtimes"], pet_in:QueryData(DataIndex["feedtimes"])+1)	
				return pet_tid,0,36
			else
				if pet_in:QueryData(DataIndex["smallgrow"])>=10 then
					pet_out:UpdateData(DataIndex["potential_def"],math.min(pet_in:QueryData(DataIndex["potential_def"])+NowSmallGrow,
					MaxGrowGrades[GradeDirection["potential_def"]]))
					pet_out:UpdateData(DataIndex["smallgrow"],pet_in:QueryData(DataIndex["smallgrow"])-10*NowSmallGrow)
				else
					pet_out:UpdateData(DataIndex["smallgrow"],pet_in:QueryData(DataIndex["smallgrow"])+PosionFailedSmallGrow)
				end 
				return pet_tid,0,37
			end 		
		else
				return 0,0,38			
		end
	elseif PoisonGrowType==16 then
	---//type=17	�������Գɳ�(����),effect1(����1-100),effect2(����ֵ)
		if pet_in:QueryData(DataIndex["potential_attackrate"])<MaxGrowGrades[GradeDirection["potential_attackrate"]] then 
			if TotalGrowCalc==1 then 
				pet_out:UpdateData(DataIndex["potential_attackrate"],math.min(pet_in:QueryData(DataIndex["potential_attackrate"])+TotalGrowEffect,
				MaxGrowGrades[GradeDirection["potential_attackrate"]]))
				pet_out:UpdateData(DataIndex["feedtimes"], pet_in:QueryData(DataIndex["feedtimes"])+1)	
				return pet_tid,0,39
			else
				if pet_in:QueryData(DataIndex["smallgrow"])>=10 then
					pet_out:UpdateData(DataIndex["potential_attackrate"],math.min(pet_in:QueryData(DataIndex["potential_attackrate"])+NowSmallGrow,
					MaxGrowGrades[GradeDirection["potential_attackrate"]]))
					pet_out:UpdateData(DataIndex["smallgrow"],pet_in:QueryData(DataIndex["smallgrow"])-10*NowSmallGrow)
				else
					pet_out:UpdateData(DataIndex["smallgrow"],pet_in:QueryData(DataIndex["smallgrow"])+PosionFailedSmallGrow)
				end 			
				return pet_tid,0,40
			end 		
		else
				return 0,0,41			
		end
	elseif PoisonGrowType==17 then
	---//type=18	�������Գɳ�(����),effect1(����1-100),effect2(����ֵ)
		if pet_in:QueryData(DataIndex["potential_dodge"])<MaxGrowGrades[GradeDirection["potential_dodge"]] then 
			if TotalGrowCalc==1 then 
				pet_out:UpdateData(DataIndex["potential_dodge"],math.min(pet_in:QueryData(DataIndex["potential_dodge"])+TotalGrowEffect,
				MaxGrowGrades[GradeDirection["potential_dodge"]]))
				pet_out:UpdateData(DataIndex["feedtimes"], pet_in:QueryData(DataIndex["feedtimes"])+1)	
				return pet_tid,0,42
			else
				if pet_in:QueryData(DataIndex["smallgrow"])>=10 then
					pet_out:UpdateData(DataIndex["potential_dodge"],math.min(pet_in:QueryData(DataIndex["potential_dodge"])+NowSmallGrow,
					MaxGrowGrades[GradeDirection["potential_dodge"]]))
					pet_out:UpdateData(DataIndex["smallgrow"],pet_in:QueryData(DataIndex["smallgrow"])-10*NowSmallGrow)
				else
					pet_out:UpdateData(DataIndex["smallgrow"],pet_in:QueryData(DataIndex["smallgrow"])+PosionFailedSmallGrow)
				end  
				return pet_tid,0,43
			end 		
		else
				return 0,0,44			
		end
	elseif PoisonGrowType==18 then
	---//type=19	�������Գɳ�(����1),effect1(����1-100),effect2(����ֵ)
		if pet_in:QueryData(DataIndex["potential_resist1"])<MaxGrowGrades[GradeDirection["potential_resist1"]] then 
			if TotalGrowCalc==1 then 
				pet_out:UpdateData(DataIndex["potential_resist1"],math.min(pet_in:QueryData(DataIndex["potential_resist1"])+TotalGrowEffect,
				MaxGrowGrades[GradeDirection["potential_resist1"]]))
				pet_out:UpdateData(DataIndex["feedtimes"], pet_in:QueryData(DataIndex["feedtimes"])+1)	
				return pet_tid,0,45
			else
				if pet_in:QueryData(DataIndex["smallgrow"])>=10 then
					pet_out:UpdateData(DataIndex["potential_resist1"],math.min(pet_in:QueryData(DataIndex["potential_resist1"])+NowSmallGrow,
					MaxGrowGrades[GradeDirection["potential_resist1"]]))
					pet_out:UpdateData(DataIndex["smallgrow"],pet_in:QueryData(DataIndex["smallgrow"])-10*NowSmallGrow)
				else
					pet_out:UpdateData(DataIndex["smallgrow"],pet_in:QueryData(DataIndex["smallgrow"])+PosionFailedSmallGrow)
				end 
				return pet_tid,0,46
			end 		
		else
				return 0,0,47
		end
	elseif PoisonGrowType==19 then
	---//type=20	�������Գɳ�(����2),effect1(����1-100),effect2(����ֵ)
		if pet_in:QueryData(DataIndex["potential_resist2"])<MaxGrowGrades[GradeDirection["potential_resist2"]] then 
			if TotalGrowCalc==1 then 
				pet_out:UpdateData(DataIndex["potential_resist2"],math.min(pet_in:QueryData(DataIndex["potential_resist2"])+TotalGrowEffect,
				MaxGrowGrades[GradeDirection["potential_resist2"]]))
				pet_out:UpdateData(DataIndex["feedtimes"], pet_in:QueryData(DataIndex["feedtimes"])+1)	
				return pet_tid,0,48
			else
				if pet_in:QueryData(DataIndex["smallgrow"])>=10 then
					pet_out:UpdateData(DataIndex["potential_resist2"],math.min(pet_in:QueryData(DataIndex["potential_resist2"])+NowSmallGrow,
					MaxGrowGrades[GradeDirection["potential_resist2"]]))
					pet_out:UpdateData(DataIndex["smallgrow"],pet_in:QueryData(DataIndex["smallgrow"])-10*NowSmallGrow)
				else
					pet_out:UpdateData(DataIndex["smallgrow"],pet_in:QueryData(DataIndex["smallgrow"])+PosionFailedSmallGrow)
				end 
				return pet_tid,0,49
			end 		
		else
				return 0,0,50
		end
	elseif PoisonGrowType==20 then
	---//type=21	�������Գɳ�(����3),effect1(����1-100),effect2(����ֵ)
		if pet_in:QueryData(DataIndex["potential_resist3"])<MaxGrowGrades[GradeDirection["potential_resist3"]] then 
			if TotalGrowCalc==1 then 
				pet_out:UpdateData(DataIndex["potential_resist3"],math.min(pet_in:QueryData(DataIndex["potential_resist3"])+TotalGrowEffect,
				MaxGrowGrades[GradeDirection["potential_resist3"]]))
				pet_out:UpdateData(DataIndex["feedtimes"], pet_in:QueryData(DataIndex["feedtimes"])+1)	
				return pet_tid,0,51
			else
				if pet_in:QueryData(DataIndex["smallgrow"])>=10 then
					pet_out:UpdateData(DataIndex["potential_resist3"],math.min(pet_in:QueryData(DataIndex["potential_resist3"])+NowSmallGrow,
					MaxGrowGrades[GradeDirection["potential_resist3"]]))
					pet_out:UpdateData(DataIndex["smallgrow"],pet_in:QueryData(DataIndex["smallgrow"])-10*NowSmallGrow)
				else
					pet_out:UpdateData(DataIndex["smallgrow"],pet_in:QueryData(DataIndex["smallgrow"])+PosionFailedSmallGrow)
				end 
				return pet_tid,0,52
			end 		
		else
				return 0,0,53
		end
	elseif PoisonGrowType==21 then
	---//type=22	�������Գɳ�(����4),effect1(����1-100),effect2(����ֵ)
		if pet_in:QueryData(DataIndex["potential_resist4"])<MaxGrowGrades[GradeDirection["potential_resist4"]] then 
			if TotalGrowCalc==1 then 
				pet_out:UpdateData(DataIndex["potential_resist4"],math.min(pet_in:QueryData(DataIndex["potential_resist4"])+TotalGrowEffect,
				MaxGrowGrades[GradeDirection["potential_resist4"]]))
				pet_out:UpdateData(DataIndex["feedtimes"], pet_in:QueryData(DataIndex["feedtimes"])+1)	
				return pet_tid,0,54
			else
				if pet_in:QueryData(DataIndex["smallgrow"])>=10 then
					pet_out:UpdateData(DataIndex["potential_resist4"],math.min(pet_in:QueryData(DataIndex["potential_resist4"])+NowSmallGrow,
					MaxGrowGrades[GradeDirection["potential_resist4"]]))
					pet_out:UpdateData(DataIndex["smallgrow"],pet_in:QueryData(DataIndex["smallgrow"])-10*NowSmallGrow)
				else
					pet_out:UpdateData(DataIndex["smallgrow"],pet_in:QueryData(DataIndex["smallgrow"])+PosionFailedSmallGrow)
				end 
				return pet_tid,0,55
			end 		
		else
				return 0,0,56
		end
	elseif PoisonGrowType==22 then
	---//type=23	�������Գɳ�(����5),effect1(����1-100),effect2(����ֵ)
		if pet_in:QueryData(DataIndex["potential_resist5"])<MaxGrowGrades[GradeDirection["potential_resist5"]] then 
			if TotalGrowCalc==1 then 
				pet_out:UpdateData(DataIndex["potential_resist5"],math.min(pet_in:QueryData(DataIndex["potential_resist5"])+TotalGrowEffect,
				MaxGrowGrades[GradeDirection["potential_resist5"]]))
				pet_out:UpdateData(DataIndex["feedtimes"], pet_in:QueryData(DataIndex["feedtimes"])+1)	
				return pet_tid,0,57
			else
				if pet_in:QueryData(DataIndex["smallgrow"])>=10 then
					pet_out:UpdateData(DataIndex["potential_resist5"],math.min(pet_in:QueryData(DataIndex["potential_resist5"])+NowSmallGrow,
					MaxGrowGrades[GradeDirection["potential_resist5"]]))
					pet_out:UpdateData(DataIndex["smallgrow"],pet_in:QueryData(DataIndex["smallgrow"])-10*NowSmallGrow)
				else
					pet_out:UpdateData(DataIndex["smallgrow"],pet_in:QueryData(DataIndex["smallgrow"])+PosionFailedSmallGrow)
				end 	
				return pet_tid,0,58
			end 		
		else
				return 0,0,59
		end
	elseif PoisonGrowType==23 then
	---//type=24	�������Գɳ�(����6),effect1(����1-100),effect2(����ֵ)
		if pet_in:QueryData(DataIndex["potential_resist6"])<MaxGrowGrades[GradeDirection["potential_resist6"]] then 
			if TotalGrowCalc==1 then 
				pet_out:UpdateData(DataIndex["potential_resist6"],math.min(pet_in:QueryData(DataIndex["potential_resist6"])+TotalGrowEffect,
				MaxGrowGrades[GradeDirection["potential_resist6"]]))
				pet_out:UpdateData(DataIndex["feedtimes"], pet_in:QueryData(DataIndex["feedtimes"])+1)	
				return pet_tid,0,60
			else
				return pet_tid,0,61
			end 		
		else
				return 0,0,62
		end
	else
				return 0,0,63
	end 

end 
---������������������ֵ--------------------------------------------------------------------------
function ZLuaPetBedgeLifePropDeal(pet_tid,pet_in,pet_out,cid,aid,origin)
	if ZLuaPetBedgeExistInTmplIDs(pet_tid) == 0 then return end
	if type(cid)~="number" or type(aid)~="number" then return end 
	if pet_in == nil then return end
	local CidMatrix=ZLuaPetBedgeCidMatrix()
	local AidMatrix=ZLuaPetBedgeAidMatrix()
	local DataIndex=ZLuaPetBedgeDataIndex()
	local ServerOrigins=ZLuaPetBedgeOrigins()	
	
	local PoisonGrowType,PoisonBaseGrowChance,PoisonBaseGrowEffect
	local PoisonUseMaxStar
		---//�����ǵ�/���Ｖ��
		---//���ﱾ��ɳ�����/ҩ�ṩ�ĳɳ���/ҩ�ṩ�Ķ���ɹ���/ҩ�ṩ�Ļ���Ч��
		---//������߿�ʹ�õ�����ǵ�
	PoisonGrowType=CidMatrix[cid].type
	PoisonBaseGrowChance=CidMatrix[cid].effect1
	PoisonBaseGrowEffect=CidMatrix[cid].effect2
	PoisonUseMaxStar=CidMatrix[cid].effect3
	
	local ItemAddGrowChance,ItemGrowEffectInc
	---//�����ṩ�Ķ���ɹ���,�����ṩ��Ч���ӳ�
	ItemAddGrowChance=AidMatrix[aid].effect1
	ItemGrowEffectInc=AidMatrix[aid].effect2

	
	local NativeStar=pet_in:QueryStar()
		---�����ǵȳ�����Ʒ������ʹ���ǵ�
	if PoisonUseMaxStar<NativeStar then 
		return 0,0,64		
	end 	
		
	if ZPetBedge_ChanceCalc(PoisonBaseGrowChance+ItemAddGrowChance)~=1 then 
		return 0,0,65
	else
		if PoisonGrowType==26 then 
			pet_out:UpdateData(DataIndex["acuity"],pet_in:QueryData(DataIndex["acuity"])+
			PoisonBaseGrowEffect*(1+ItemGrowEffectInc))
			return pet_tid,0,66
		elseif PoisonGrowType==27 then
			pet_out:UpdateData(DataIndex["stamina"],pet_in:QueryData(DataIndex["stamina"])+
			PoisonBaseGrowEffect*(1+ItemGrowEffectInc))
			return pet_tid,0,67
		elseif PoisonGrowType==28 then
			pet_out:UpdateData(DataIndex["sawy"],pet_in:QueryData(DataIndex["sawy"])+
			PoisonBaseGrowEffect*(1+ItemGrowEffectInc))
			return pet_tid,0,68
		elseif PoisonGrowType==29 then
			pet_out:UpdateData(DataIndex["dowry"],pet_in:QueryData(DataIndex["dowry"])+
			PoisonBaseGrowEffect*(1+ItemGrowEffectInc))
			return pet_tid,0,69
		elseif PoisonGrowType==30 then
			pet_out:UpdateData(DataIndex["wisdom"],pet_in:QueryData(DataIndex["wisdom"])+
			PoisonBaseGrowEffect*(1+ItemGrowEffectInc))			
			return pet_tid,0,70
		elseif PoisonGrowType==31 then
			pet_out:UpdateData(DataIndex["cnr"],pet_in:QueryData(DataIndex["cnr"])+
			PoisonBaseGrowEffect*(1+ItemGrowEffectInc))
			return pet_tid,0,71
		else
			return pet_tid,0,72
		end 
	end 	
end 

---�ı����������(�޽�)----------------------------------------------------------------------------
function ZLuaPetBedgeChangeMainType(pet_tid,pet_in,pet_out,cid,aid,origin)
	if ZLuaPetBedgeExistInTmplIDs(pet_tid) == 0 then return end
	if pet_in == nil then return end
	local DataIndex=ZLuaPetBedgeDataIndex()
	local ServerOrigins=ZLuaPetBedgeOrigins()
	local nativemaintype=pet_in:QueryMainType()
	---//�����޽����ͳ��ֵĸ���
	local MaintypeList={0,1,2,3,4,5,6,7,8,9,10,11,12}
	local MaintypeChance={100,600,100,100,100,700,300,600,600,600,600,600,0}
	MaintypeChance[nativemaintype+1]=0
	local newmaintype=MaintypeList[ZPetGrade_Get_RanPoint(MaintypeChance)]
	if newmaintype<0 then newmaintype=0 end 
	if newmaintype>=12 then newmaintype=11 end
	---//�����޽�����anywhere
	pet_out:UpdateData(DataIndex["maintype"], newmaintype)
	return pet_tid,0,73
end 

---�ı�����ֻ�----------------------------------------------------------------------------
function ZLuaPetBedgeChangeFatality(pet_tid,pet_in,pet_out,cid,aid,origin)
	if ZLuaPetBedgeExistInTmplIDs(pet_tid) == 0 then return end
	if pet_in == nil then return end
	local DataIndex=ZLuaPetBedgeDataIndex()
	local ServerOrigins=ZLuaPetBedgeOrigins()
	local NewFatality=ZLuaPetBedgeFatalitySkills(pet_tid,origin)
	pet_out:UpdateData(DataIndex["skillid_8"], NewFatality or 0)	
	return pet_tid,0,89
end
---���ﶹ������-------------------------------------------------------------------------------
function ZLuaPetBedgeStaticGrowUp(pet_tid,pet_in,pet_out,cid,aid,origin)  
	if ZLuaPetBedgeExistInTmplIDs(pet_tid) == 0 then return end
	if pet_in == nil then return end
	local DataIndex=ZLuaPetBedgeDataIndex()
	local ServerOrigins=ZLuaPetBedgeOrigins()
	local NewPeaSkillID=pet_in:QueryData(DataIndex["skillid_11"]) or 0
	local NewPeaSkillLevel=pet_in:QueryData(DataIndex["skilllvl_11"]) or 0
	local CidMatrix=ZLuaPetBedgeCidMatrix()
	local cideffect=CidMatrix[cid].effect1
	
	local para1=math.max(NewPeaSkillID-1262,0)
	local para2=NewPeaSkillLevel+cideffect
	local sumpara=para1*99+para2
	
	local newpara1=math.ceil(sumpara/99)+1261
	local newpara2=sumpara-math.floor(sumpara/99)*99
	if newpara2==0 and newpara1~=0 then 
		newpara2=99
	end 

	if sumpara>=0 and sumpara<=9*99 then 
		pet_out:UpdateData(DataIndex["skillid_11"], newpara1 or 0)
		pet_out:UpdateData(DataIndex["skilllvl_11"], newpara2 or 0)
		return pet_tid,0,90
	else
		return 0,0,91
	end 

end 
----------------------------------------------------------------------------------------------
-----�����Ե��������-------------------------------------------------------------------------
function ZLuaPetBedgeBuddhaGrow(pet_tid,pet_in,pet_out,cid,aid,origin,cult)  
	if ZLuaPetBedgeExistInTmplIDs(pet_tid) == 0 then return end
	if pet_in == nil then return end
	local DataIndex=ZLuaPetBedgeDataIndex()
	local ServerOrigins=ZLuaPetBedgeOrigins()
	local NewPeaSkillID=pet_in:QueryData(DataIndex["skillid_10"]) or 0
	local NewPeaSkillLevel=pet_in:QueryData(DataIndex["skilllvl_10"]) or 0
	local CidMatrix=ZLuaPetBedgeCidMatrix()
	local cideffect1=CidMatrix[cid].effect1	---type
	local cideffect2=CidMatrix[cid].effect2	---effect lvl
	
	---//�Ƿ𲻿���������
	if cult~=4 and type(cult)=="number" then
		return 0,0,92
	end
	
	if cideffect1==1 then 
		pet_out:UpdateData(DataIndex["skillid_10"], 1356 or 0)
		pet_out:UpdateData(DataIndex["skilllvl_10"], cideffect2 or 0)
	elseif cideffect1==2 then 
		pet_out:UpdateData(DataIndex["skillid_10"], 1357 or 0)
		pet_out:UpdateData(DataIndex["skilllvl_10"], cideffect2 or 0)
	elseif cideffect1==3 then 
		pet_out:UpdateData(DataIndex["skillid_10"], 1358 or 0)
		pet_out:UpdateData(DataIndex["skilllvl_10"], cideffect2 or 0)
	else
		return 0,0,92
	end 
	return pet_tid,0,93
end 
-----����껯����-------------------------------------------------------------------------
function ZLuaPetBedgeGetSpirit(pet_tid,pet_in,pet_out,cid,aid,origin)  
	if ZLuaPetBedgeExistInTmplIDs(pet_tid) == 0 then return end
	if pet_in == nil then return end
	local CidMatrix=ZLuaPetBedgeCidMatrix()
	local availablePets=ZLuaAvailablePets()
	
	local pet
	local newspirit_id=0
	for _,pet in pairs(availablePets) do
		if pet.pet_tid == pet_tid then 
			newspirit_id=pet.spirit_id 
		end
	end
	if newspirit_id~=0 and pet_in:QueryLevel()>75 then 
		return newspirit_id,0,201
	elseif newspirit_id~=0 and pet_in:QueryLevel()<75 then 
		return 0,0,202
	else
		return 0,0,203
	end 
end 
-----����껯����-------------------------------------------------------------------------
function ZLuaPetBedgeSetSpirit(pet_tid,pet_in,pet_out,cid,aid,origin)  
	if ZLuaPetBedgeExistInTmplIDs(pet_tid) == 0 then return end
	if pet_in == nil then return end
	local DataIndex=ZLuaPetBedgeDataIndex()
	local ServerOrigins=ZLuaPetBedgeOrigins()
	local CidMatrix=ZLuaPetBedgeCidMatrix()
	local newpet_tid=CidMatrix[cid].effect1
	
  local availableChangeModelPets={16503,16504,16505,16506,16507,16508,18306,18929,19510,20108,19110,20488,
  																20489,20561,22105,22484,21247,23337,24650,24781,25117,25118,25124,25234,25311,25422,34054,
  																25421,25385,33146,29993,29994,29995,29996,29997,30988,30989,30990,30991,34126,34214,34215,
  																34289,40541,40631,40665,40863,40864,40865,40866,40867,40868,40869,40870,41261,41262,41928,42683}
	
	for _,petid in pairs(availableChangeModelPets) do
		if petid==pet_tid then 
			local nativerace,_,_=ZLuaPetBedgeStaticInfo(newpet_tid)
			pet_out:UpdateData(DataIndex["race"], nativerace)
			pet_out:UpdateData(DataIndex["skillid_9"],1355)	
			pet_out:UpdateData(DataIndex["skilllvl_9"],pet_in:QueryData(DataIndex["skilllvl_9"]))
			return newpet_tid,0,206	
			
		end
	end
	return 0,0,203
	
end 
---�ı��������-------------------------------------------------------------------------------
function ZLuaPetBedgeChangeState(pet_tid,pet_in,pet_out,cid,aid,origin) 
	if ZLuaPetBedgeExistInTmplIDs(pet_tid) == 0 then return end
	if pet_in == nil then return end
	local DataIndex=ZLuaPetBedgeDataIndex()
	local ServerOrigins=ZLuaPetBedgeOrigins()
	local CidMatrix=ZLuaPetBedgeCidMatrix()
	local AvailablePets=ZLuaAvailablePets()
		
	---//�ض������޷��ı�����
	for i,v in pairs(AvailablePets) do
		if v.pet_tid == pet_tid and v.changefigure_able==0 then   
			return 0,1,87	
		end 
	end
	
	local Star=pet_in:QueryData(DataIndex["star"]) or 1
	---//effect1(���ʹ���ǵ�)/effect2(ָ���shape)/effect3(ָ���shape(���������)
	if Star<CidMatrix[cid].effect1 then 
		return 0,0,80
	else
		if pet_in:QueryData(DataIndex["isaberrant"])==1 then 
			pet_out:UpdateData(DataIndex["shape"],CidMatrix[cid].effect3)
		else
			pet_out:UpdateData(DataIndex["shape"],CidMatrix[cid].effect2)
		end 	
		return pet_tid,0,81
	end 	
end 
---�������---------------------------------------------------------------------------
function ZLuaPetBedgeAberrantState(pet_tid,pet_in,pet_out,cid,aid,origin) 
	if ZLuaPetBedgeExistInTmplIDs(pet_tid) == 0 then return end
	if pet_in == nil then return end
	local DataIndex=ZLuaPetBedgeDataIndex()
	local ServerOrigins=ZLuaPetBedgeOrigins()
	local AvailablePets=ZLuaAvailablePets()
	local IsAberrant=pet_in:QueryData(DataIndex["isaberrant"])
	local msg_id=82
	
	---//�ض������޷��ı�����
	for i,v in pairs(AvailablePets) do
		if v.pet_tid == pet_tid and v.changefigure_able==0 then   
			return 0,1,87	
		end 
	end
		
	if IsAberrant==0 then 
		IsAberrant=1
			pet_out:UpdateData(DataIndex["shape"],pet_in:QueryData(DataIndex["shape"])+1)
		msg_id=82
	else 
		IsAberrant=0
			pet_out:UpdateData(DataIndex["shape"],pet_in:QueryData(DataIndex["shape"])-1)
		msg_id=83
	end 
	pet_out:UpdateData(DataIndex["isaberrant"],IsAberrant)
	return pet_tid,0,msg_id
end 
---��������ʼ�漶��ɳ����ɳ�(������)------------------------------------------------------
function ZLuaPetBedgeArtGrowState(pet_tid,pet_in,pet_out,cid,aid,origin) 
	if ZLuaPetBedgeExistInTmplIDs(pet_tid) == 0 then return end
	if pet_in == nil then return end
	local DataIndex=ZLuaPetBedgeDataIndex()
	local ServerOrigins=ZLuaPetBedgeOrigins()
	local IsGrow=pet_in:QueryData(DataIndex["isgrowup"])
	local msg_id=84
	if IsGrow==0 then 
		IsGrow=1
		msg_id=84
	else 
		IsGrow=0
		msg_id=85
	end 
	pet_out:UpdateData(DataIndex["isgrowup"],IsGrow)
	return pet_tid,0,msg_id
end 
---��������������----------------------------------------------------------------------------------
function PetBedgeCombine(pet_tid,pet_in,pet_out,cid,aid,cult)
  if ZLuaPetBedgeExistInTmplIDs(pet_tid) == 0 then return 0,1,99 end
  if pet_in == nil then return 0,1,99 end
  local AvailablePets=ZLuaAvailablePets()
  local CidMatrix=ZLuaPetBedgeCidMatrix()
  local AidMatrix=ZLuaPetBedgeAidMatrix()
  local DataIndex=ZLuaPetBedgeDataIndex()
	local ServerOrigins=ZLuaPetBedgeOrigins()
	
	for i,v in pairs(AvailablePets) do
		if v.pet_tid == pet_tid and v.combine_able==0 and v.fixage_able==0 then   
			return 0,1,98
		end 
	end
	
	for i,v in pairs(AvailablePets) do
		if v.pet_tid == pet_tid and v.combine_able==0 and v.fixage_able==1 and (CidMatrix[cid].type<3 or CidMatrix[cid].type>4) then   
			return 0,1,98
		end 
	end
	
  ---//�������ݵ��³���
  for i,v in pairs(DataIndex) do
		pet_out:UpdateData(v, pet_in:QueryData(v) )
	end
 	pet_out:SetLevel(pet_in:QueryLevel())
 	pet_out:SetExp(pet_in:QueryExp())
 	pet_out:SetCurHP(pet_in:QueryCurHP())
 	pet_out:SetCurVigor(pet_in:QueryCurVigor())
 	pet_out:SetAge(pet_in:QueryAge())
 	pet_out:SetLife(pet_in:QueryLife())
  pet_out:SetCurHonorPoint(pet_in:QueryCurHonorPoint())
 	pet_out:SetMaxHonorPoint(pet_in:QueryMaxHonorPoint())
  pet_out:SetCurHungerPoint(pet_in:QueryCurHungerPoint())
 	pet_out:SetMaxHungerPoint(pet_in:QueryMaxHungerPoint())
 	
 	local origin=pet_in:QueryData(DataIndex["nativeorigin"])
 	local isidentify=pet_in:QueryData(DataIndex["identify"])
 	local newpet_id,msg_channel,msg_id
	local DoSpecialSpirit=0			---//ר���ڳ��ｻ��spirit
	
  ---//���β���Ҫ�������ߵ�����
	if aid~=0 and CidMatrix[cid].type<=6 then 
		return 0,0,208
	end 
	if aid~=0 and CidMatrix[cid].type>7 and CidMatrix[cid].type<11 then 
		return 0,0,208
	end 	
	if aid~=0 and CidMatrix[cid].type>25 then 
		return 0,0,208
	end 	
  
  if CidMatrix[cid].type==nil or type(CidMatrix[cid].type)~="number" then CidMatrix[cid].type=0 end 
  
  ---//������������	
  if CidMatrix[cid].type==1 and isidentify==1 then 
  	newpet_id,msg_channel,msg_id=ZLuaPetBedgeHolyReborn(pet_tid,pet_in,pet_out,cid,aid,origin)  
  elseif CidMatrix[cid].type==2 and isidentify==1 then 
  	newpet_id,msg_channel,msg_id=ZLuaPetBedgeIdentify(pet_tid,pet_in,pet_out,cid,aid,origin)
  ---//����ı�����
  elseif CidMatrix[cid].type==3 and isidentify==1 then
  	newpet_id,msg_channel,msg_id=ZLuaPetBedgeChangeAge(pet_tid,pet_in,pet_out,cid,aid,origin)
  ---//����ı�����
  elseif CidMatrix[cid].type==4 and isidentify==1 then
  	newpet_id,msg_channel,msg_id=ZLuaPetBedgeChangeLife(pet_tid,pet_in,pet_out,cid,aid,origin)
  ---//����ı��Ը�
  elseif CidMatrix[cid].type==5 and isidentify==1 then 
  	newpet_id,msg_channel,msg_id=ZLuaPetBedgeChangeEmement(pet_tid,pet_in,pet_out,cid,aid,origin)
  ---//����ı��츳
  elseif CidMatrix[cid].type==6 and isidentify==1 then
  	newpet_id,msg_channel,msg_id=ZLuaPetBedgeChangeTalent(pet_tid,pet_in,pet_out,cid,aid,origin)
  ---//����ѧϰ����
  elseif CidMatrix[cid].type==7 and isidentify==1 then 
  	newpet_id,msg_channel,msg_id=ZLuaPetBedgeLearnSkill(pet_tid,pet_in,pet_out,cid,aid,origin)
  ---//������������
  elseif CidMatrix[cid].type==8 and isidentify==1 then
  	newpet_id,msg_channel,msg_id=ZLuaPetBedgeForgetSkill(pet_tid,pet_in,pet_out,cid,aid,origin)
  ---//����ı䵱ǰ���ܶ�
  elseif CidMatrix[cid].type==9 and isidentify==1 then 
  	newpet_id,msg_channel,msg_id=ZLuaPetBedgeChangeCurHonor(pet_tid,pet_in,pet_out,cid,aid,origin)
  ---//����ı�������ܶ�
  elseif CidMatrix[cid].type==10 and isidentify==1 then  
  	newpet_id,msg_channel,msg_id=ZLuaPetBedgeChangeMaxHonor(pet_tid,pet_in,pet_out,cid,aid,origin)
 	---//����ı�ս���������
  elseif CidMatrix[cid].type>=11 and CidMatrix[cid].type<=25 and isidentify==1 then  
  	newpet_id,msg_channel,msg_id=ZLuaPetBedgeCombatPropDeal(pet_tid,pet_in,pet_out,cid,aid,origin,1)
  	---//usetype=1���������ɳ�(��cid���µ�һ�γɳ�)
  	---//usetype>1�������ɳ�(��aid���µĶ��γɳ�,��usetype����ɳ�����)

   	if newpet_id~=0 and ZLuaPetBedgeExistInTmplIDs(newpet_id)~=0 then 
  		---//���¼����ǵ�
  		local NewStar=ZLuaPetBedgeReCalcStar(newpet_id,pet_out,origin)
  		pet_out:UpdateData(DataIndex["star"],NewStar)
    	---����ս�����Ա����ɳ�(�Ƿ���ɳ�)
    	if AidMatrix[aid].effect3==1 and aid~=0 then 
    		ZLuaPetBedgePassiveAddCombatProp(pet_tid,pet_in,pet_out,cid,aid,origin)
    	end 
    	---�������ܶ�����
  		ZLuaPetBedgePassiveAddMaxHonor(pet_tid,pet_in,pet_out,cid,aid,origin)
  		---ͳ��ʹ�õ�aid
  		if aid~=0 and aid~=nil then 
  			pet_out:UpdateData(DataIndex["feedaids"],pet_in:QueryData(DataIndex["feedaids"])+1)
  		end 
  	end 		

  ---//����ı������������
  elseif CidMatrix[cid].type>=26 and CidMatrix[cid].type<=31 and isidentify==1 then
  	newpet_id,msg_channel,msg_id=ZLuaPetBedgeLifePropDeal(pet_tid,pet_in,pet_out,cid,aid,origin)
  ---//����ı�������
  elseif CidMatrix[cid].type==32 and isidentify==1 then  
  	newpet_id,msg_channel,msg_id=ZLuaPetBedgeChangeMainType(pet_tid,pet_in,pet_out,cid,aid,origin) 
   ---//����ı�����
  elseif CidMatrix[cid].type==33 and isidentify==1 then  
  	newpet_id,msg_channel,msg_id=ZLuaPetBedgeChangeState(pet_tid,pet_in,pet_out,cid,aid,origin) 
   ---//�������(����)
  elseif CidMatrix[cid].type==34 and isidentify==1 then  
  	newpet_id,msg_channel,msg_id=ZLuaPetBedgeAberrantState(pet_tid,pet_in,pet_out,cid,aid,origin)   
   ---//���￪ʼ�ɳ�(������)
  elseif CidMatrix[cid].type==35 and isidentify==1 then  
  	newpet_id,msg_channel,msg_id=ZLuaPetBedgeArtGrowState(pet_tid,pet_in,pet_out,cid,aid,origin)   
  ---//����ı��ֻ�
  elseif CidMatrix[cid].type==36 and isidentify==1 then  
  	newpet_id,msg_channel,msg_id=ZLuaPetBedgeChangeFatality(pet_tid,pet_in,pet_out,cid,aid,origin)   
 	---//����ͨ�������������������ͷ���
  elseif CidMatrix[cid].type==37 and isidentify==1 then  
  	newpet_id,msg_channel,msg_id=ZLuaPetBedgeStaticGrowUp(pet_tid,pet_in,pet_out,cid,aid,origin)  
 	---//����ͨ������ǿ����������
  elseif CidMatrix[cid].type==38 and isidentify==1 then  
  	newpet_id,msg_channel,msg_id=ZLuaPetBedgeBuddhaGrow(pet_tid,pet_in,pet_out,cid,aid,origin,cult)  
  ---//����껯����(�л��������֮��һ��)
  elseif CidMatrix[cid].type==39 and isidentify==1 then  
  	newpet_id,msg_channel,msg_id=ZLuaPetBedgeGetSpirit(pet_tid,pet_in,pet_out,cid,aid,origin)
  	DoSpecialSpirit=1  
  ---//����껯�趨(�л��������֮�ڶ���)
  elseif CidMatrix[cid].type==40 and isidentify==1 then  
  	newpet_id,msg_channel,msg_id=ZLuaPetBedgeSetSpirit(pet_tid,pet_in,pet_out,cid,aid,origin) 
  else 
  	newpet_id=0
  	msg_channel=0
  	msg_id=74				---����δ��������Ƿ�����
  end 
   
  if (ZLuaPetBedgeExistInTmplIDs(newpet_id)==0 or newpet_id==0) and DoSpecialSpirit==0 then 
  	newpet_id=0
  elseif DoSpecialSpirit==1 then 
  	---//����껯Get���жϲ���id
  else
  	---//pet_out:UpdateData(DataIndex["origin"],ServerOrigins["combine"])
   	pet_out:UpdateData(DataIndex["id"],newpet_id)
   	ZLuaPetBedgeRebuild(newpet_id,pet_out,ServerOrigins["combine"],_,cult)
  end 
  return newpet_id,0,msg_id
end
---���¼�������ǵ�-------------------------------------------------------------------------------
function ZLuaPetBedgeReCalcStar(pet_id,pet,origin)
		if ZLuaPetBedgeExistInTmplIDs(pet_id)==0 then return 1 end 
		local GradeDirection=ZLuaPetBedgeGradeDirection()
  	local DataIndex=ZLuaPetBedgeDataIndex()
  	local Grades={}
  		Grades[GradeDirection["potential_hp"]]				=pet:QueryData(DataIndex["potential_hp"])
			Grades[GradeDirection["potential_mp"]]				=pet:QueryData(DataIndex["potential_mp"])
			Grades[GradeDirection["potential_minatk"]]		=pet:QueryData(DataIndex["potential_minatk"])
			Grades[GradeDirection["potential_maxatk"]]		=pet:QueryData(DataIndex["potential_maxatk"])
			Grades[GradeDirection["potential_def"]]				=pet:QueryData(DataIndex["potential_def"])
			Grades[GradeDirection["potential_attackrate"]]=pet:QueryData(DataIndex["potential_attackrate"])
			Grades[GradeDirection["potential_dodge"]]			=pet:QueryData(DataIndex["potential_dodge"])
			Grades[GradeDirection["potential_resist1"]]		=pet:QueryData(DataIndex["potential_resist1"])
			Grades[GradeDirection["potential_resist2"]]		=pet:QueryData(DataIndex["potential_resist2"])
			Grades[GradeDirection["potential_resist3"]]		=pet:QueryData(DataIndex["potential_resist3"])
			Grades[GradeDirection["potential_resist4"]]		=pet:QueryData(DataIndex["potential_resist4"])
			Grades[GradeDirection["potential_resist5"]]		=pet:QueryData(DataIndex["potential_resist5"])
			Grades[GradeDirection["potential_resist6"]]		=pet:QueryData(DataIndex["potential_resist6"])
  	local Horoscope=pet:QueryHoroscope()
  	local NewStar=ZLuaPetStarFromGrades(pet_id,origin,Horoscope,Grades,2)	---//����2����ϳɺ����¼����ǵ�
   	if NewStar>20 or NewStar<0 then NewStar=1 end
  	return NewStar
end 
---�����������������������ܶ�����-------------------------------------------------------------------
function ZLuaPetBedgePassiveAddMaxHonor(pet_tid,pet_in,pet_out,cid,aid,origin)
	if ZLuaPetBedgeExistInTmplIDs(pet_tid) == 0 then return end
	if pet_in == nil then return end
	local MaxHonor=57600
	local CidMatrix=ZLuaPetBedgeCidMatrix()
	local DataIndex=ZLuaPetBedgeDataIndex()
	local ServerOrigins=ZLuaPetBedgeOrigins()
	
	local AddChance=15
	local AddHonor=100
	if aid~=0 and aid~=nil then 
		AddChance=85 
		AddHonor=150
	end
	if CidMatrix[cid].effect3>=12 then 
		AddChance=85  
		AddHonor=200
	end 
	
	if ZPetBedge_ChanceCalc(AddChance)==1 then  
		pet_out:SetMaxHonorPoint(math.min(pet_in:QueryMaxHonorPoint()+AddHonor,MaxHonor))
	end

end 
---������������������������ս������-----------------------------------------------------------------
function ZLuaPetBedgePassiveAddCombatProp(pet_tid,pet_in,pet_out,cid,aid,origin)
	if ZLuaPetBedgeExistInTmplIDs(pet_tid) == 0 then return end
	if type(cid)~="number" or type(aid)~="number" then return end 
	if pet_in == nil then return end

	local CidMatrix=ZLuaPetBedgeCidMatrix()
	local AidMatrix=ZLuaPetBedgeAidMatrix()
	local DataIndex=ZLuaPetBedgeDataIndex()
	local GradeDirection=ZLuaPetBedgeGradeDirection()
	local ServerOrigins=ZLuaPetBedgeOrigins()
	local usetype
	
	if aid~=0 and aid~=nil then 
  	for usetype=11,24 do
  	ZLuaPetBedgeCombatPropDeal(pet_tid,pet_in,pet_out,cid,aid,origin,usetype)
  	end 
  end 
	
end 

---//������Ҫ���͵��µĳɳ�����(�������ɹ�ʱ)
function ZLuaPetBedgeMaintypeGrowEffect(maintype,poisongrowtype)
	---//maintype from 0-12	
	---//poisongrowtype=11-23
	---//�˲��ֽ�Ϊ�ƻ��߼�(��д)	
	local maintypegrowchanceadd=0
	
	if type(maintype)~="number" or type(poisongrowtype)~="number" then 
		maintypegrowchanceadd=0
	end 	
	if maintype==poisongrowtype-11 then 
		maintypegrowchanceadd=0.05
	end 
	
	return maintypegrowchanceadd
end 

----���ʴ�����-----------------------------------------------------------------------------------
---�ɹ�����Ϊchance--------------------------------------------------------------------------------
function ZPetBedge_ChanceCalc(chance)
	if type(chance)~="number" or chance<0 then return 0 end 
	local c
	local cx={}
	if chance>=100 then 
		c=1
	elseif chance<=0 then 
		c=0
	else 
		cx={100-chance,chance}
		c=ZPetGrade_Get_RanPoint(cx)-1
	end 
	return c	
end 
---------------------------------------------------------------------------------------------------