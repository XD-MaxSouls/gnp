--- Mcncc.com
---//AddSkillProficiency 
---//���ﲶ׽��Ϣ��̬����
function ZStaticAvailableMonsterList()
	local staticmonster={}
		staticmonster[1]={monster_id=30280,pet_id=29996}	---//С¹
		staticmonster[2]={monster_id=31555,pet_id=30991}	---//��ħ
		staticmonster[3]={monster_id=31556,pet_id=30988}	---//��ͷ����
		staticmonster[4]={monster_id=31557,pet_id=30989}	---//�й�
		staticmonster[5]={monster_id=31558,pet_id=30990}	---//èͷӥ
	return staticmonster
end 
---//�䷽��Ϣ��̬����---------------------------------------------------------------------
function ZStaticRecipeList()
	local staticrecipe={}
		staticrecipe[1]={recipe_id=2417,recipe_group=1,recipe_level=1,recipe_type=11}---����̫֮�����
		staticrecipe[2]={recipe_id=2423,recipe_group=1,recipe_level=1,recipe_type=11}---ˮ��̫֮�����
		staticrecipe[3]={recipe_id=2411,recipe_group=1,recipe_level=1,recipe_type=11}---̫�����
		staticrecipe[4]={recipe_id=2418,recipe_group=1,recipe_level=1,recipe_type=11}---����֮�������
		staticrecipe[5]={recipe_id=2424,recipe_group=1,recipe_level=1,recipe_type=11}---ˮ��֮�������
		staticrecipe[6]={recipe_id=2412,recipe_group=1,recipe_level=1,recipe_type=11}---�������
		staticrecipe[7]={recipe_id=2519,recipe_group=1,recipe_level=2,recipe_type=11}---������̫֮�����
		staticrecipe[8]={recipe_id=2525,recipe_group=1,recipe_level=2,recipe_type=11}---���ˮ��̫֮�����
		staticrecipe[9]={recipe_id=2520,recipe_group=1,recipe_level=2,recipe_type=11}---������֮�������
		staticrecipe[10]={recipe_id=2526,recipe_group=1,recipe_level=2,recipe_type=11}---���ˮ��֮�������
		staticrecipe[11]={recipe_id=2507,recipe_group=1,recipe_level=2,recipe_type=11}---�����̫֮�����
		staticrecipe[12]={recipe_id=2513,recipe_group=1,recipe_level=2,recipe_type=11}---��ˮ��̫֮�����
		staticrecipe[13]={recipe_id=2508,recipe_group=1,recipe_level=2,recipe_type=11}---�����֮�������
		staticrecipe[14]={recipe_id=2514,recipe_group=1,recipe_level=2,recipe_type=11}---��ˮ��֮�������
		staticrecipe[15]={recipe_id=2369,recipe_group=1,recipe_level=1,recipe_type=11}---����֮�޽�ͷ��
		staticrecipe[16]={recipe_id=2363,recipe_group=1,recipe_level=1,recipe_type=11}---�޽�ͷ��
		staticrecipe[17]={recipe_id=2370,recipe_group=1,recipe_level=1,recipe_type=11}---����֮����ͷ��
		staticrecipe[18]={recipe_id=2364,recipe_group=1,recipe_level=1,recipe_type=11}---����ͷ��
		staticrecipe[19]={recipe_id=2465,recipe_group=1,recipe_level=2,recipe_type=11}---�������֮�޽�ͷ��
		staticrecipe[20]={recipe_id=2466,recipe_group=1,recipe_level=2,recipe_type=11}---�������֮����ͷ��
		staticrecipe[21]={recipe_id=2459,recipe_group=1,recipe_level=2,recipe_type=11}---������֮�޽�ͷ��
		staticrecipe[22]={recipe_id=2460,recipe_group=1,recipe_level=2,recipe_type=11}---������֮����ͷ��
		staticrecipe[23]={recipe_id=2405,recipe_group=1,recipe_level=1,recipe_type=11}---ľ��֮�������
		staticrecipe[24]={recipe_id=2399,recipe_group=1,recipe_level=1,recipe_type=11}---�������
		staticrecipe[25]={recipe_id=2406,recipe_group=1,recipe_level=1,recipe_type=11}---ľ��֮�������
		staticrecipe[26]={recipe_id=2400,recipe_group=1,recipe_level=1,recipe_type=11}---�������
		staticrecipe[27]={recipe_id=2501,recipe_group=1,recipe_level=2,recipe_type=11}---���ľ��֮�������
		staticrecipe[28]={recipe_id=2502,recipe_group=1,recipe_level=2,recipe_type=11}---���ľ��֮�������
		staticrecipe[29]={recipe_id=2495,recipe_group=1,recipe_level=2,recipe_type=11}---��ľ��֮�������
		staticrecipe[30]={recipe_id=2496,recipe_group=1,recipe_level=2,recipe_type=11}---��ľ��֮�������
		staticrecipe[31]={recipe_id=2747,recipe_group=1,recipe_level=1,recipe_type=11}---����̫֮���ľ�
		staticrecipe[32]={recipe_id=2447,recipe_group=1,recipe_level=1,recipe_type=11}---�޺�̫֮���ľ�
		staticrecipe[33]={recipe_id=2441,recipe_group=1,recipe_level=1,recipe_type=11}---̫���ľ�
		staticrecipe[34]={recipe_id=2748,recipe_group=1,recipe_level=1,recipe_type=11}---����֮�Ƶ��ľ�
		staticrecipe[35]={recipe_id=2448,recipe_group=1,recipe_level=1,recipe_type=11}---�޺�֮�Ƶ��ľ�
		staticrecipe[36]={recipe_id=2442,recipe_group=1,recipe_level=1,recipe_type=11}---�Ƶ��ľ�
		staticrecipe[37]={recipe_id=2759,recipe_group=1,recipe_level=2,recipe_type=11}---������̫֮���ľ�
		staticrecipe[38]={recipe_id=2537,recipe_group=1,recipe_level=2,recipe_type=11}---����޺�̫֮���ľ�
		staticrecipe[39]={recipe_id=2760,recipe_group=1,recipe_level=2,recipe_type=11}---������֮�Ƶ��ľ�
		staticrecipe[40]={recipe_id=2538,recipe_group=1,recipe_level=2,recipe_type=11}---����޺�֮�Ƶ��ľ�
		staticrecipe[41]={recipe_id=2753,recipe_group=1,recipe_level=2,recipe_type=11}---�����̫֮���ľ�
		staticrecipe[42]={recipe_id=2531,recipe_group=1,recipe_level=2,recipe_type=11}---���޺�̫֮���ľ�
		staticrecipe[43]={recipe_id=2754,recipe_group=1,recipe_level=2,recipe_type=11}---�����֮�Ƶ��ľ�
		staticrecipe[44]={recipe_id=2532,recipe_group=1,recipe_level=2,recipe_type=11}---���޺�֮�Ƶ��ľ�
		staticrecipe[45]={recipe_id=2681,recipe_group=1,recipe_level=1,recipe_type=11}---�򶾻���
		staticrecipe[46]={recipe_id=2657,recipe_group=1,recipe_level=1,recipe_type=11}---�ٹ�Ƥ
		staticrecipe[47]={recipe_id=2693,recipe_group=1,recipe_level=1,recipe_type=11}---����ʯ��
		staticrecipe[48]={recipe_id=2663,recipe_group=1,recipe_level=1,recipe_type=11}---�ɽ�����
		staticrecipe[49]={recipe_id=2651,recipe_group=1,recipe_level=1,recipe_type=11}---��������
		staticrecipe[50]={recipe_id=2669,recipe_group=1,recipe_level=1,recipe_type=11}---�����۴�
		staticrecipe[51]={recipe_id=2675,recipe_group=1,recipe_level=1,recipe_type=11}---��ţ�Ǵ�
		staticrecipe[52]={recipe_id=2687,recipe_group=1,recipe_level=1,recipe_type=11}---����˪��
		staticrecipe[53]={recipe_id=2682,recipe_group=1,recipe_level=1,recipe_type=11}---����Ѫ��
		staticrecipe[54]={recipe_id=2658,recipe_group=1,recipe_level=1,recipe_type=11}---����ħ��
		staticrecipe[55]={recipe_id=2694,recipe_group=1,recipe_level=1,recipe_type=11}---����ӡ��
		staticrecipe[56]={recipe_id=2664,recipe_group=1,recipe_level=1,recipe_type=11}---Ԫ˧ʥ��
		staticrecipe[57]={recipe_id=2652,recipe_group=1,recipe_level=1,recipe_type=11}---��β����
		staticrecipe[58]={recipe_id=2670,recipe_group=1,recipe_level=1,recipe_type=11}---��������
		staticrecipe[59]={recipe_id=2676,recipe_group=1,recipe_level=1,recipe_type=11}---��������
		staticrecipe[60]={recipe_id=2688,recipe_group=1,recipe_level=1,recipe_type=11}---���ʥ��
		staticrecipe[61]={recipe_id=2729,recipe_group=1,recipe_level=1,recipe_type=11}---�򶾽�
		staticrecipe[62]={recipe_id=2711,recipe_group=1,recipe_level=1,recipe_type=11}---��������
		staticrecipe[63]={recipe_id=2705,recipe_group=1,recipe_level=1,recipe_type=11}---���ѩ��
		staticrecipe[64]={recipe_id=2723,recipe_group=1,recipe_level=1,recipe_type=11}---������
		staticrecipe[65]={recipe_id=2741,recipe_group=1,recipe_level=1,recipe_type=11}---����ͼ��
		staticrecipe[66]={recipe_id=2699,recipe_group=1,recipe_level=1,recipe_type=11}---����ŭĿ
		staticrecipe[67]={recipe_id=2717,recipe_group=1,recipe_level=1,recipe_type=11}---��������
		staticrecipe[68]={recipe_id=2735,recipe_group=1,recipe_level=1,recipe_type=11}---��������
		staticrecipe[69]={recipe_id=2730,recipe_group=1,recipe_level=1,recipe_type=11}---��������
		staticrecipe[70]={recipe_id=2712,recipe_group=1,recipe_level=1,recipe_type=11}---��ľ�챦
		staticrecipe[71]={recipe_id=2706,recipe_group=1,recipe_level=1,recipe_type=11}---��˫��ɫ
		staticrecipe[72]={recipe_id=2724,recipe_group=1,recipe_level=1,recipe_type=11}---���ӻ���
		staticrecipe[73]={recipe_id=2742,recipe_group=1,recipe_level=1,recipe_type=11}---����ʥ��
		staticrecipe[74]={recipe_id=2700,recipe_group=1,recipe_level=1,recipe_type=11}---��β��Ѫ
		staticrecipe[75]={recipe_id=2718,recipe_group=1,recipe_level=1,recipe_type=11}---����ӡ��
		staticrecipe[76]={recipe_id=2736,recipe_group=1,recipe_level=1,recipe_type=11}---��ط���
		staticrecipe[77]={recipe_id=2375,recipe_group=1,recipe_level=1,recipe_type=11}---��������
		staticrecipe[78]={recipe_id=2381,recipe_group=1,recipe_level=1,recipe_type=11}---����֮��������
		staticrecipe[79]={recipe_id=2376,recipe_group=1,recipe_level=1,recipe_type=11}---��������
		staticrecipe[80]={recipe_id=2382,recipe_group=1,recipe_level=1,recipe_type=11}---����֮��������
		staticrecipe[81]={recipe_id=2477,recipe_group=1,recipe_level=2,recipe_type=11}---�������֮��������
		staticrecipe[82]={recipe_id=2478,recipe_group=1,recipe_level=2,recipe_type=11}---�������֮��������
		staticrecipe[83]={recipe_id=2471,recipe_group=1,recipe_level=2,recipe_type=11}---������֮��������
		staticrecipe[84]={recipe_id=2472,recipe_group=1,recipe_level=2,recipe_type=11}---������֮��������
		staticrecipe[85]={recipe_id=2387,recipe_group=1,recipe_level=1,recipe_type=11}---����ս��
		staticrecipe[86]={recipe_id=2393,recipe_group=1,recipe_level=1,recipe_type=11}---����֮����ս��
		staticrecipe[87]={recipe_id=2388,recipe_group=1,recipe_level=1,recipe_type=11}---����ս��
		staticrecipe[88]={recipe_id=2394,recipe_group=1,recipe_level=1,recipe_type=11}---����֮����ս��
		staticrecipe[89]={recipe_id=2489,recipe_group=1,recipe_level=2,recipe_type=11}---�������֮����ս��
		staticrecipe[90]={recipe_id=2490,recipe_group=1,recipe_level=2,recipe_type=11}---�������֮����ս��
		staticrecipe[91]={recipe_id=2483,recipe_group=1,recipe_level=2,recipe_type=11}---������֮����ս��
		staticrecipe[92]={recipe_id=2484,recipe_group=1,recipe_level=2,recipe_type=11}---������֮����ս��
		staticrecipe[93]={recipe_id=2435,recipe_group=1,recipe_level=1,recipe_type=11}---�ƶ�֮ͨ������
		staticrecipe[94]={recipe_id=2429,recipe_group=1,recipe_level=1,recipe_type=11}---ͨ������
		staticrecipe[95]={recipe_id=2436,recipe_group=1,recipe_level=1,recipe_type=11}---�ƶ�֮��������
		staticrecipe[96]={recipe_id=2430,recipe_group=1,recipe_level=1,recipe_type=11}---��������
		staticrecipe[97]={recipe_id=2549,recipe_group=1,recipe_level=2,recipe_type=11}---���ƶ�֮ͨ������
		staticrecipe[98]={recipe_id=2550,recipe_group=1,recipe_level=2,recipe_type=11}---���ƶ�֮��������
		staticrecipe[99]={recipe_id=2543,recipe_group=1,recipe_level=2,recipe_type=11}---��ƶ�֮ͨ������
		staticrecipe[100]={recipe_id=2544,recipe_group=1,recipe_level=2,recipe_type=11}---��ƶ�֮��������
		staticrecipe[101]={recipe_id=2579,recipe_group=1,recipe_level=1,recipe_type=11}---����֮ˡ
		staticrecipe[102]={recipe_id=2591,recipe_group=1,recipe_level=1,recipe_type=11}---����֮��
		staticrecipe[103]={recipe_id=2567,recipe_group=1,recipe_level=1,recipe_type=11}---���֮��
		staticrecipe[104]={recipe_id=2555,recipe_group=1,recipe_level=1,recipe_type=11}---���屦��
		staticrecipe[105]={recipe_id=2585,recipe_group=1,recipe_level=1,recipe_type=11}---���֮��
		staticrecipe[106]={recipe_id=2597,recipe_group=1,recipe_level=1,recipe_type=11}---�޳�֮��
		staticrecipe[107]={recipe_id=2573,recipe_group=1,recipe_level=1,recipe_type=11}---����֮��
		staticrecipe[108]={recipe_id=2561,recipe_group=1,recipe_level=1,recipe_type=11}---����֮־
		staticrecipe[109]={recipe_id=2580,recipe_group=1,recipe_level=1,recipe_type=11}---��ľ֮¶
		staticrecipe[110]={recipe_id=2592,recipe_group=1,recipe_level=1,recipe_type=11}---��Ȼ֮��
		staticrecipe[111]={recipe_id=2568,recipe_group=1,recipe_level=1,recipe_type=11}---��˫֮̾
		staticrecipe[112]={recipe_id=2556,recipe_group=1,recipe_level=1,recipe_type=11}---��ʥ����
		staticrecipe[113]={recipe_id=2586,recipe_group=1,recipe_level=1,recipe_type=11}---����֮��
		staticrecipe[114]={recipe_id=2598,recipe_group=1,recipe_level=1,recipe_type=11}---ڤ��֮��
		staticrecipe[115]={recipe_id=2574,recipe_group=1,recipe_level=1,recipe_type=11}---�칬֮��
		staticrecipe[116]={recipe_id=2562,recipe_group=1,recipe_level=1,recipe_type=11}---��������
		staticrecipe[117]={recipe_id=2609,recipe_group=1,recipe_level=1,recipe_type=11}---�ٹ����
		staticrecipe[118]={recipe_id=2639,recipe_group=1,recipe_level=1,recipe_type=11}---�������
		staticrecipe[119]={recipe_id=2603,recipe_group=1,recipe_level=1,recipe_type=11}---�������
		staticrecipe[120]={recipe_id=2645,recipe_group=1,recipe_level=1,recipe_type=11}---�޳�����
		staticrecipe[121]={recipe_id=2621,recipe_group=1,recipe_level=1,recipe_type=11}---�ɽ����
		staticrecipe[122]={recipe_id=2627,recipe_group=1,recipe_level=1,recipe_type=11}---��������
		staticrecipe[123]={recipe_id=2633,recipe_group=1,recipe_level=1,recipe_type=11}---��ţ����
		staticrecipe[124]={recipe_id=2615,recipe_group=1,recipe_level=1,recipe_type=11}---��������
		staticrecipe[125]={recipe_id=2610,recipe_group=1,recipe_level=1,recipe_type=11}---����ħѪ
		staticrecipe[126]={recipe_id=2640,recipe_group=1,recipe_level=1,recipe_type=11}---��Ȼ����
		staticrecipe[127]={recipe_id=2604,recipe_group=1,recipe_level=1,recipe_type=11}---����������
		staticrecipe[128]={recipe_id=2646,recipe_group=1,recipe_level=1,recipe_type=11}---ڤ������
		staticrecipe[129]={recipe_id=2622,recipe_group=1,recipe_level=1,recipe_type=11}---Ԫ˧��ӡ
		staticrecipe[130]={recipe_id=2628,recipe_group=1,recipe_level=1,recipe_type=11}---�칬���
		staticrecipe[131]={recipe_id=2634,recipe_group=1,recipe_level=1,recipe_type=11}---����Ѫӡ
		staticrecipe[132]={recipe_id=2616,recipe_group=1,recipe_level=1,recipe_type=11}---��������
		staticrecipe[133]={recipe_id=2453,recipe_group=1,recipe_level=1,recipe_type=11}---�ܷ���׹
		staticrecipe[134]={recipe_id=2454,recipe_group=1,recipe_level=1,recipe_type=11}---������׹
		staticrecipe[135]={recipe_id=2919,recipe_group=0,recipe_level=2,recipe_type=5}---���⻤��<��������><���᳤��>�䷽
		staticrecipe[136]={recipe_id=2920,recipe_group=0,recipe_level=2,recipe_type=5}---���⻤��<�������><���ӹ���>�䷽
		staticrecipe[137]={recipe_id=2923,recipe_group=0,recipe_level=2,recipe_type=5}---���⻤��<������ŭ><���׽���>�䷽
		staticrecipe[138]={recipe_id=2922,recipe_group=0,recipe_level=2,recipe_type=5}---���⻤��<������><ʢ��֮��>�䷽
		staticrecipe[139]={recipe_id=2921,recipe_group=0,recipe_level=2,recipe_type=5}---���⻤��<��ħ�ط�><��ħŭ��>�䷽
		staticrecipe[140]={recipe_id=2925,recipe_group=0,recipe_level=2,recipe_type=5}---���⻤��<����е�><������â>�䷽
		staticrecipe[141]={recipe_id=2926,recipe_group=0,recipe_level=2,recipe_type=5}---���⻤��<���׿�Х><Ⱥ���ѿ�>�䷽
		staticrecipe[142]={recipe_id=2927,recipe_group=0,recipe_level=2,recipe_type=5}---���⻤��<�������><ն������>�䷽
		staticrecipe[143]={recipe_id=2924,recipe_group=0,recipe_level=2,recipe_type=5}---���⻤��<����ʥ��><�������>�䷽
		staticrecipe[144]={recipe_id=1743,recipe_group=0,recipe_level=1,recipe_type=5}---�����⣩���������䷽
		staticrecipe[145]={recipe_id=1761,recipe_group=0,recipe_level=1,recipe_type=5}---�����⣩��������䷽
		staticrecipe[146]={recipe_id=1759,recipe_group=0,recipe_level=1,recipe_type=5}---�����⣩���ӹ����䷽
		staticrecipe[147]={recipe_id=1776,recipe_group=0,recipe_level=1,recipe_type=5}---�����⣩���������䷽
		staticrecipe[148]={recipe_id=1747,recipe_group=0,recipe_level=1,recipe_type=5}---�����⣩�罣֮â�䷽
		staticrecipe[149]={recipe_id=1771,recipe_group=0,recipe_level=1,recipe_type=5}---�����⣩����֮Թ�䷽
		staticrecipe[150]={recipe_id=1748,recipe_group=0,recipe_level=1,recipe_type=5}---�����⣩��Ԫ����䷽
		staticrecipe[151]={recipe_id=1736,recipe_group=0,recipe_level=1,recipe_type=5}---�����⣩���������䷽
		staticrecipe[152]={recipe_id=1741,recipe_group=0,recipe_level=1,recipe_type=5}---�����⣩��������䷽
		staticrecipe[153]={recipe_id=1770,recipe_group=0,recipe_level=1,recipe_type=5}---�����⣩����֮���䷽
		staticrecipe[154]={recipe_id=1772,recipe_group=0,recipe_level=1,recipe_type=5}---�����⣩��ħ�����䷽
		staticrecipe[155]={recipe_id=1775,recipe_group=0,recipe_level=1,recipe_type=5}---�����⣩���ĳ����䷽
		staticrecipe[156]={recipe_id=1755,recipe_group=0,recipe_level=1,recipe_type=5}---�����⣩��Ԫ֮���䷽
		staticrecipe[157]={recipe_id=1773,recipe_group=0,recipe_level=1,recipe_type=5}---�����⣩��ʥ�����䷽
		staticrecipe[158]={recipe_id=1760,recipe_group=0,recipe_level=1,recipe_type=5}---�����⣩������ŭ�䷽
		staticrecipe[159]={recipe_id=1746,recipe_group=0,recipe_level=1,recipe_type=5}---�����⣩�������䷽
		staticrecipe[160]={recipe_id=1764,recipe_group=0,recipe_level=1,recipe_type=5}---�����⣩��������䷽
		staticrecipe[161]={recipe_id=1742,recipe_group=0,recipe_level=1,recipe_type=5}---�����⣩�������䷽
		staticrecipe[162]={recipe_id=1750,recipe_group=0,recipe_level=1,recipe_type=5}---�����⣩ŭ���Ľ��䷽
		staticrecipe[163]={recipe_id=1738,recipe_group=0,recipe_level=1,recipe_type=5}---�����⣩��ħ�ط��䷽
		staticrecipe[164]={recipe_id=1749,recipe_group=0,recipe_level=1,recipe_type=5}---�����⣩��ħŭ���䷽
		staticrecipe[165]={recipe_id=1756,recipe_group=0,recipe_level=1,recipe_type=5}---�����⣩���᳤���䷽
		staticrecipe[166]={recipe_id=1740,recipe_group=0,recipe_level=1,recipe_type=5}---�����⣩���﷨���䷽
		staticrecipe[167]={recipe_id=1767,recipe_group=0,recipe_level=1,recipe_type=5}---�����⣩Ⱥ���ѿ��䷽
		staticrecipe[168]={recipe_id=1737,recipe_group=0,recipe_level=1,recipe_type=5}---�����⣩���������䷽
		staticrecipe[169]={recipe_id=1762,recipe_group=0,recipe_level=1,recipe_type=5}---�����⣩ʢ��֮���䷽
		staticrecipe[170]={recipe_id=1763,recipe_group=0,recipe_level=1,recipe_type=5}---�����⣩˪�������䷽
		staticrecipe[171]={recipe_id=1768,recipe_group=0,recipe_level=1,recipe_type=5}---�����⣩��������䷽
		staticrecipe[172]={recipe_id=1769,recipe_group=0,recipe_level=1,recipe_type=5}---�����⣩�콣�����䷽
		staticrecipe[173]={recipe_id=1739,recipe_group=0,recipe_level=1,recipe_type=5}---�����⣩����е��䷽
		staticrecipe[174]={recipe_id=1766,recipe_group=0,recipe_level=1,recipe_type=5}---�����⣩���׿�Х�䷽
		staticrecipe[175]={recipe_id=1752,recipe_group=0,recipe_level=1,recipe_type=5}---�����⣩��������䷽
		staticrecipe[176]={recipe_id=1765,recipe_group=0,recipe_level=1,recipe_type=5}---�����⣩���׽����䷽
		staticrecipe[177]={recipe_id=1744,recipe_group=0,recipe_level=1,recipe_type=5}---�����⣩��Ԫ�����䷽
		staticrecipe[178]={recipe_id=1745,recipe_group=0,recipe_level=1,recipe_type=5}---�����⣩��������䷽
		staticrecipe[179]={recipe_id=1751,recipe_group=0,recipe_level=1,recipe_type=5}---�����⣩а�������䷽
		staticrecipe[180]={recipe_id=1758,recipe_group=0,recipe_level=1,recipe_type=5}---�����⣩���������䷽
		staticrecipe[181]={recipe_id=1757,recipe_group=0,recipe_level=1,recipe_type=5}---�����⣩����ʥ���䷽
		staticrecipe[182]={recipe_id=1774,recipe_group=0,recipe_level=1,recipe_type=5}---�����⣩��ɲ�����䷽
		staticrecipe[183]={recipe_id=1754,recipe_group=0,recipe_level=1,recipe_type=5}---�����⣩������â�䷽
		staticrecipe[184]={recipe_id=1753,recipe_group=0,recipe_level=1,recipe_type=5}---�����⣩ն�������䷽
		staticrecipe[185]={recipe_id=2940,recipe_group=0,recipe_level=2,recipe_type=5}---���ʻ���<�ȱ�Ϊ��><����㱻>�䷽
		staticrecipe[186]={recipe_id=2938,recipe_group=0,recipe_level=2,recipe_type=5}---���ʻ���<�Ⱦ��ٲ�><�޾��ຣ>�䷽
		staticrecipe[187]={recipe_id=2944,recipe_group=0,recipe_level=2,recipe_type=5}---���ʻ���<���ݳ���><Ԧ����ͨ>�䷽
		staticrecipe[188]={recipe_id=2943,recipe_group=0,recipe_level=2,recipe_type=5}---���ʻ���<����֮��><��������>�䷽
		staticrecipe[189]={recipe_id=2942,recipe_group=0,recipe_level=2,recipe_type=5}---���ʻ���<���ı���><��ħ���>�䷽
		staticrecipe[190]={recipe_id=2945,recipe_group=0,recipe_level=2,recipe_type=5}---���ʻ���<��������><����ͨ��>�䷽
		staticrecipe[191]={recipe_id=2941,recipe_group=0,recipe_level=2,recipe_type=5}---���ʻ���<��ת֮��><��ղ���>�䷽
		staticrecipe[192]={recipe_id=2939,recipe_group=0,recipe_level=2,recipe_type=5}---���ʻ���<�ռ���ɫ><ɫ���ǿ�>�䷽
		staticrecipe[193]={recipe_id=2937,recipe_group=0,recipe_level=2,recipe_type=5}---���ʻ���<�컨��׹><���ķ���>�䷽
		staticrecipe[194]={recipe_id=1808,recipe_group=0,recipe_level=1,recipe_type=5}---�����ʣ��ȱ�Ϊ���䷽
		staticrecipe[195]={recipe_id=1789,recipe_group=0,recipe_level=1,recipe_type=5}---�����ʣ��Ⱦ��ٲ��䷽
		staticrecipe[196]={recipe_id=1792,recipe_group=0,recipe_level=1,recipe_type=5}---�����ʣ�����֮���䷽
		staticrecipe[197]={recipe_id=1786,recipe_group=0,recipe_level=1,recipe_type=5}---�����ʣ����ݳ����䷽
		staticrecipe[198]={recipe_id=1782,recipe_group=0,recipe_level=1,recipe_type=5}---�����ʣ��������䷽
		staticrecipe[199]={recipe_id=1817,recipe_group=0,recipe_level=1,recipe_type=5}---�����ʣ�����㱻�䷽
		staticrecipe[200]={recipe_id=1816,recipe_group=0,recipe_level=1,recipe_type=5}---�����ʣ�����ӡ�䷽
		staticrecipe[201]={recipe_id=1804,recipe_group=0,recipe_level=1,recipe_type=5}---�����ʣ���ħ����䷽
		staticrecipe[202]={recipe_id=1783,recipe_group=0,recipe_level=1,recipe_type=5}---�����ʣ��̱���Ԫ�䷽
		staticrecipe[203]={recipe_id=1787,recipe_group=0,recipe_level=1,recipe_type=5}---�����ʣ�����֮���䷽
		staticrecipe[204]={recipe_id=1805,recipe_group=0,recipe_level=1,recipe_type=5}---�����ʣ����������䷽
		staticrecipe[205]={recipe_id=1797,recipe_group=0,recipe_level=1,recipe_type=5}---�����ʣ����������䷽
		staticrecipe[206]={recipe_id=1779,recipe_group=0,recipe_level=1,recipe_type=5}---�����ʣ����ı����䷽
		staticrecipe[207]={recipe_id=1780,recipe_group=0,recipe_level=1,recipe_type=5}---�����ʣ���ħ�����䷽
		staticrecipe[208]={recipe_id=1814,recipe_group=0,recipe_level=1,recipe_type=5}---�����ʣ���ղ����䷽
		staticrecipe[209]={recipe_id=1803,recipe_group=0,recipe_level=1,recipe_type=5}---�����ʣ������ħ�䷽
		staticrecipe[210]={recipe_id=1802,recipe_group=0,recipe_level=1,recipe_type=5}---�����ʣ����������䷽
		staticrecipe[211]={recipe_id=1807,recipe_group=0,recipe_level=1,recipe_type=5}---�����ʣ���ת֮���䷽
		staticrecipe[212]={recipe_id=1778,recipe_group=0,recipe_level=1,recipe_type=5}---�����ʣ��ռ���ɫ�䷽
		staticrecipe[213]={recipe_id=1791,recipe_group=0,recipe_level=1,recipe_type=5}---�����ʣ���ڤ�����䷽
		staticrecipe[214]={recipe_id=1796,recipe_group=0,recipe_level=1,recipe_type=5}---�����ʣ�������Ե�䷽
		staticrecipe[215]={recipe_id=1798,recipe_group=0,recipe_level=1,recipe_type=5}---�����ʣ���������䷽
		staticrecipe[216]={recipe_id=1801,recipe_group=0,recipe_level=1,recipe_type=5}---�����ʣ�Ǭ�������䷽
		staticrecipe[217]={recipe_id=1790,recipe_group=0,recipe_level=1,recipe_type=5}---�����ʣ�ɫ���ǿ��䷽
		staticrecipe[218]={recipe_id=1809,recipe_group=0,recipe_level=1,recipe_type=5}---�����ʣ���ħ�����䷽
		staticrecipe[219]={recipe_id=1781,recipe_group=0,recipe_level=1,recipe_type=5}---�����ʣ����ķ����䷽
		staticrecipe[220]={recipe_id=1811,recipe_group=0,recipe_level=1,recipe_type=5}---�����ʣ������ඥ�䷽
		staticrecipe[221]={recipe_id=1793,recipe_group=0,recipe_level=1,recipe_type=5}---�����ʣ����ѭ���䷽
		staticrecipe[222]={recipe_id=1815,recipe_group=0,recipe_level=1,recipe_type=5}---�����ʣ���������䷽
		staticrecipe[223]={recipe_id=1777,recipe_group=0,recipe_level=1,recipe_type=5}---�����ʣ��컨��׹�䷽
		staticrecipe[224]={recipe_id=1810,recipe_group=0,recipe_level=1,recipe_type=5}---�����ʣ����豦���䷽
		staticrecipe[225]={recipe_id=1813,recipe_group=0,recipe_level=1,recipe_type=5}---�����ʣ�����ͨ���䷽
		staticrecipe[226]={recipe_id=1795,recipe_group=0,recipe_level=1,recipe_type=5}---�����ʣ�������Ը�䷽
		staticrecipe[227]={recipe_id=1806,recipe_group=0,recipe_level=1,recipe_type=5}---�����ʣ��޳��ֶ��䷽
		staticrecipe[228]={recipe_id=1799,recipe_group=0,recipe_level=1,recipe_type=5}---�����ʣ��޾��ຣ�䷽
		staticrecipe[229]={recipe_id=1800,recipe_group=0,recipe_level=1,recipe_type=5}---�����ʣ����������䷽
		staticrecipe[230]={recipe_id=1812,recipe_group=0,recipe_level=1,recipe_type=5}---�����ʣ�аħ��ɢ�䷽
		staticrecipe[231]={recipe_id=1785,recipe_group=0,recipe_level=1,recipe_type=5}---�����ʣ����������䷽
		staticrecipe[232]={recipe_id=1788,recipe_group=0,recipe_level=1,recipe_type=5}---�����ʣ�һ������䷽
		staticrecipe[233]={recipe_id=1794,recipe_group=0,recipe_level=1,recipe_type=5}---�����ʣ�Ԧ����ͨ�䷽
		staticrecipe[234]={recipe_id=1784,recipe_group=0,recipe_level=1,recipe_type=5}---�����ʣ����쵻���䷽
		staticrecipe[235]={recipe_id=2768,recipe_group=0,recipe_level=1,recipe_type=5}---�����ƣ���Ȼ���䷽
		staticrecipe[236]={recipe_id=2777,recipe_group=0,recipe_level=1,recipe_type=5}---�����ƣ��ٶ����䷽
		staticrecipe[237]={recipe_id=2787,recipe_group=0,recipe_level=1,recipe_type=5}---�����ƣ��ٹ��䷽
		staticrecipe[238]={recipe_id=2788,recipe_group=0,recipe_level=1,recipe_type=5}---�����ƣ����ŭ�䷽
		staticrecipe[239]={recipe_id=2781,recipe_group=0,recipe_level=1,recipe_type=5}---�����ƣ����ӡ�䷽
		staticrecipe[240]={recipe_id=2775,recipe_group=0,recipe_level=1,recipe_type=5}---�����ƣ��ز����䷽
		staticrecipe[241]={recipe_id=2770,recipe_group=0,recipe_level=1,recipe_type=5}---�����ƣ��������䷽
		staticrecipe[242]={recipe_id=2776,recipe_group=0,recipe_level=1,recipe_type=5}---�����ƣ�������䷽
		staticrecipe[243]={recipe_id=2774,recipe_group=0,recipe_level=1,recipe_type=5}---�����ƣ�������䷽
		staticrecipe[244]={recipe_id=2797,recipe_group=0,recipe_level=1,recipe_type=5}---�����ƣ����۴��䷽
		staticrecipe[245]={recipe_id=2762,recipe_group=0,recipe_level=1,recipe_type=5}---�����ƣ�������䷽
		staticrecipe[246]={recipe_id=2798,recipe_group=0,recipe_level=1,recipe_type=5}---�����ƣ��������䷽
		staticrecipe[247]={recipe_id=2765,recipe_group=0,recipe_level=1,recipe_type=5}---�����ƣ��������䷽
		staticrecipe[248]={recipe_id=2801,recipe_group=0,recipe_level=1,recipe_type=5}---�����ƣ���Ǭ���䷽
		staticrecipe[249]={recipe_id=2792,recipe_group=0,recipe_level=1,recipe_type=5}---�����ƣ�����ͨ�䷽
		staticrecipe[250]={recipe_id=2780,recipe_group=0,recipe_level=1,recipe_type=5}---�����ƣ��������䷽
		staticrecipe[251]={recipe_id=2764,recipe_group=0,recipe_level=1,recipe_type=5}---�����ƣ����Ƕ��䷽
		staticrecipe[252]={recipe_id=2783,recipe_group=0,recipe_level=1,recipe_type=5}---�����ƣ��ػ���䷽
		staticrecipe[253]={recipe_id=2789,recipe_group=0,recipe_level=1,recipe_type=5}---�����ƣ��������䷽
		staticrecipe[254]={recipe_id=2763,recipe_group=0,recipe_level=1,recipe_type=5}---�����ƣ���Ѫ���䷽
		staticrecipe[255]={recipe_id=2796,recipe_group=0,recipe_level=1,recipe_type=5}---�����ƣ�������䷽
		staticrecipe[256]={recipe_id=2766,recipe_group=0,recipe_level=1,recipe_type=5}---�����ƣ����ľ��䷽
		staticrecipe[257]={recipe_id=2785,recipe_group=0,recipe_level=1,recipe_type=5}---�����ƣ��������䷽
		staticrecipe[258]={recipe_id=2773,recipe_group=0,recipe_level=1,recipe_type=5}---�����ƣ�������䷽
		staticrecipe[259]={recipe_id=2784,recipe_group=0,recipe_level=1,recipe_type=5}---�����ƣ��͹�Х�䷽
		staticrecipe[260]={recipe_id=2769,recipe_group=0,recipe_level=1,recipe_type=5}---�����ƣ�Ļ�춾�䷽
		staticrecipe[261]={recipe_id=2772,recipe_group=0,recipe_level=1,recipe_type=5}---�����ƣ��������䷽
		staticrecipe[262]={recipe_id=2794,recipe_group=0,recipe_level=1,recipe_type=5}---�����ƣ���Ѫ���䷽
		staticrecipe[263]={recipe_id=2778,recipe_group=0,recipe_level=1,recipe_type=5}---�����ƣ�ŭ�����䷽
		staticrecipe[264]={recipe_id=2771,recipe_group=0,recipe_level=1,recipe_type=5}---�����ƣ��������䷽
		staticrecipe[265]={recipe_id=2795,recipe_group=0,recipe_level=1,recipe_type=5}---�����ƣ��ɻ���䷽
		staticrecipe[266]={recipe_id=2793,recipe_group=0,recipe_level=1,recipe_type=5}---�����ƣ����嶾�䷽
		staticrecipe[267]={recipe_id=2800,recipe_group=0,recipe_level=1,recipe_type=5}---�����ƣ������䷽
		staticrecipe[268]={recipe_id=2802,recipe_group=0,recipe_level=1,recipe_type=5}---�����ƣ���ٹ��䷽
		staticrecipe[269]={recipe_id=2779,recipe_group=0,recipe_level=1,recipe_type=5}---�����ƣ���ٻ��䷽
		staticrecipe[270]={recipe_id=2767,recipe_group=0,recipe_level=1,recipe_type=5}---�����ƣ���Ӱ���䷽
		staticrecipe[271]={recipe_id=2790,recipe_group=0,recipe_level=1,recipe_type=5}---�����ƣ�а����䷽
		staticrecipe[272]={recipe_id=2786,recipe_group=0,recipe_level=1,recipe_type=5}---�����ƣ�аѪ���䷽
		staticrecipe[273]={recipe_id=2799,recipe_group=0,recipe_level=1,recipe_type=5}---�����ƣ�Ѫ�����䷽
		staticrecipe[274]={recipe_id=2791,recipe_group=0,recipe_level=1,recipe_type=5}---�����ƣ�Ӧ�����䷽
		staticrecipe[275]={recipe_id=2782,recipe_group=0,recipe_level=1,recipe_type=5}---�����ƣ�������䷽
		staticrecipe[276]={recipe_id=2933,recipe_group=0,recipe_level=2,recipe_type=5}---���ƻ���<���ӡ><�͹�Х>�䷽
		staticrecipe[277]={recipe_id=2934,recipe_group=0,recipe_level=2,recipe_type=5}---���ƻ���<���۴�><����>�䷽
		staticrecipe[278]={recipe_id=2929,recipe_group=0,recipe_level=2,recipe_type=5}---���ƻ���<��Ѫ��><�����>�䷽
		staticrecipe[279]={recipe_id=2930,recipe_group=0,recipe_level=2,recipe_type=5}---���ƻ���<��Ѫ��><�����>�䷽
		staticrecipe[280]={recipe_id=2936,recipe_group=0,recipe_level=2,recipe_type=5}---���ƻ���<Ļ�춾><������>�䷽
		staticrecipe[281]={recipe_id=2935,recipe_group=0,recipe_level=2,recipe_type=5}---���ƻ���<�ɻ��><������>�䷽
		staticrecipe[282]={recipe_id=2931,recipe_group=0,recipe_level=2,recipe_type=5}---���ƻ���<���嶾><��Ѫ��>�䷽
		staticrecipe[283]={recipe_id=2932,recipe_group=0,recipe_level=2,recipe_type=5}---���ƻ���<��ٻ�><�����>�䷽
		staticrecipe[284]={recipe_id=2928,recipe_group=0,recipe_level=2,recipe_type=5}---���ƻ���<а���><Ӧ����>�䷽
		staticrecipe[285]={recipe_id=1847,recipe_group=0,recipe_level=1,recipe_type=5}---�����ϣ���Ȼ�䷽
		staticrecipe[286]={recipe_id=1853,recipe_group=0,recipe_level=1,recipe_type=5}---�����ϣ������䷽
		staticrecipe[287]={recipe_id=1827,recipe_group=0,recipe_level=1,recipe_type=5}---�����ϣ������䷽
		staticrecipe[288]={recipe_id=1829,recipe_group=0,recipe_level=1,recipe_type=5}---�����ϣ������䷽
		staticrecipe[289]={recipe_id=1821,recipe_group=0,recipe_level=1,recipe_type=5}---�����ϣ������䷽
		staticrecipe[290]={recipe_id=1844,recipe_group=0,recipe_level=1,recipe_type=5}---�����ϣ�����䷽
		staticrecipe[291]={recipe_id=1843,recipe_group=0,recipe_level=1,recipe_type=5}---�����ϣ������䷽
		staticrecipe[292]={recipe_id=1826,recipe_group=0,recipe_level=1,recipe_type=5}---�����ϣ������䷽
		staticrecipe[293]={recipe_id=1841,recipe_group=0,recipe_level=1,recipe_type=5}---�����ϣ������䷽
		staticrecipe[294]={recipe_id=1845,recipe_group=0,recipe_level=1,recipe_type=5}---�����ϣ������䷽
		staticrecipe[295]={recipe_id=1824,recipe_group=0,recipe_level=1,recipe_type=5}---�����ϣ��þ��䷽
		staticrecipe[296]={recipe_id=1854,recipe_group=0,recipe_level=1,recipe_type=5}---�����ϣ������䷽
		staticrecipe[297]={recipe_id=1822,recipe_group=0,recipe_level=1,recipe_type=5}---�����ϣ������䷽
		staticrecipe[298]={recipe_id=1842,recipe_group=0,recipe_level=1,recipe_type=5}---�����ϣ������䷽
		staticrecipe[299]={recipe_id=1828,recipe_group=0,recipe_level=1,recipe_type=5}---�����ϣ������䷽
		staticrecipe[300]={recipe_id=1849,recipe_group=0,recipe_level=1,recipe_type=5}---�����ϣ������䷽
		staticrecipe[301]={recipe_id=1852,recipe_group=0,recipe_level=1,recipe_type=5}---�����ϣ���Ѫ�䷽
		staticrecipe[302]={recipe_id=1820,recipe_group=0,recipe_level=1,recipe_type=5}---�����ϣ������䷽
		staticrecipe[303]={recipe_id=1825,recipe_group=0,recipe_level=1,recipe_type=5}---�����ϣ������䷽
		staticrecipe[304]={recipe_id=1834,recipe_group=0,recipe_level=1,recipe_type=5}---�����ϣ������䷽
		staticrecipe[305]={recipe_id=1840,recipe_group=0,recipe_level=1,recipe_type=5}---�����ϣ���ʧ�䷽
		staticrecipe[306]={recipe_id=1830,recipe_group=0,recipe_level=1,recipe_type=5}---�����ϣ�����䷽
		staticrecipe[307]={recipe_id=1851,recipe_group=0,recipe_level=1,recipe_type=5}---�����ϣ�����䷽
		staticrecipe[308]={recipe_id=1823,recipe_group=0,recipe_level=1,recipe_type=5}---�����ϣ��鶯�䷽
		staticrecipe[309]={recipe_id=1836,recipe_group=0,recipe_level=1,recipe_type=5}---�����ϣ�����䷽
		staticrecipe[310]={recipe_id=1856,recipe_group=0,recipe_level=1,recipe_type=5}---�����ϣ������䷽
		staticrecipe[311]={recipe_id=1857,recipe_group=0,recipe_level=1,recipe_type=5}---�����ϣ������䷽
		staticrecipe[312]={recipe_id=1858,recipe_group=0,recipe_level=1,recipe_type=5}---�����ϣ������䷽
		staticrecipe[313]={recipe_id=1819,recipe_group=0,recipe_level=1,recipe_type=5}---�����ϣ�ʶ���䷽
		staticrecipe[314]={recipe_id=1839,recipe_group=0,recipe_level=1,recipe_type=5}---�����ϣ�˼���䷽
		staticrecipe[315]={recipe_id=1850,recipe_group=0,recipe_level=1,recipe_type=5}---�����ϣ������䷽
		staticrecipe[316]={recipe_id=1846,recipe_group=0,recipe_level=1,recipe_type=5}---�����ϣ������䷽
		staticrecipe[317]={recipe_id=1818,recipe_group=0,recipe_level=1,recipe_type=5}---�����ϣ�����䷽
		staticrecipe[318]={recipe_id=1837,recipe_group=0,recipe_level=1,recipe_type=5}---�����ϣ������䷽
		staticrecipe[319]={recipe_id=1835,recipe_group=0,recipe_level=1,recipe_type=5}---�����ϣ���Ը�䷽
		staticrecipe[320]={recipe_id=1832,recipe_group=0,recipe_level=1,recipe_type=5}---�����ϣ������䷽
		staticrecipe[321]={recipe_id=1838,recipe_group=0,recipe_level=1,recipe_type=5}---�����ϣ��೾�䷽
		staticrecipe[322]={recipe_id=1833,recipe_group=0,recipe_level=1,recipe_type=5}---�����ϣ������䷽
		staticrecipe[323]={recipe_id=1848,recipe_group=0,recipe_level=1,recipe_type=5}---�����ϣ�Ԧ���䷽
		staticrecipe[324]={recipe_id=1831,recipe_group=0,recipe_level=1,recipe_type=5}---�����ϣ�Լ���䷽
		staticrecipe[325]={recipe_id=1855,recipe_group=0,recipe_level=1,recipe_type=5}---�����ϣ������䷽
		staticrecipe[326]={recipe_id=2949,recipe_group=0,recipe_level=2,recipe_type=5}---���ϻ���<����><����>�䷽
		staticrecipe[327]={recipe_id=2952,recipe_group=0,recipe_level=2,recipe_type=5}---���ϻ���<�þ�><����>�䷽
		staticrecipe[328]={recipe_id=2951,recipe_group=0,recipe_level=2,recipe_type=5}---���ϻ���<����><��Ѫ>�䷽
		staticrecipe[329]={recipe_id=2953,recipe_group=0,recipe_level=2,recipe_type=5}---���ϻ���<����><����>�䷽
		staticrecipe[330]={recipe_id=2948,recipe_group=0,recipe_level=2,recipe_type=5}---���ϻ���<����><����>�䷽
		staticrecipe[331]={recipe_id=2954,recipe_group=0,recipe_level=2,recipe_type=5}---���ϻ���<���><��ʧ>�䷽
		staticrecipe[332]={recipe_id=2950,recipe_group=0,recipe_level=2,recipe_type=5}---���ϻ���<�鶯><��Ȼ>�䷽
		staticrecipe[333]={recipe_id=2946,recipe_group=0,recipe_level=2,recipe_type=5}---���ϻ���<����><�೾>�䷽
		staticrecipe[334]={recipe_id=2947,recipe_group=0,recipe_level=2,recipe_type=5}---���ϻ���<��Ը><����>�䷽
		staticrecipe[335]={recipe_id=1886,recipe_group=0,recipe_level=1,recipe_type=5}---��Ѫ�䣩�����䷽
		staticrecipe[336]={recipe_id=1881,recipe_group=0,recipe_level=1,recipe_type=5}---��Ѫ�䣩�����䷽
		staticrecipe[337]={recipe_id=1887,recipe_group=0,recipe_level=1,recipe_type=5}---��Ѫ�䣩�����䷽
		staticrecipe[338]={recipe_id=1870,recipe_group=0,recipe_level=1,recipe_type=5}---��Ѫ�䣩�����䷽
		staticrecipe[339]={recipe_id=1884,recipe_group=0,recipe_level=1,recipe_type=5}---��Ѫ�䣩��ע�䷽
		staticrecipe[340]={recipe_id=1860,recipe_group=0,recipe_level=1,recipe_type=5}---��Ѫ�䣩�����䷽
		staticrecipe[341]={recipe_id=1869,recipe_group=0,recipe_level=1,recipe_type=5}---��Ѫ�䣩�����䷽
		staticrecipe[342]={recipe_id=1859,recipe_group=0,recipe_level=1,recipe_type=5}---��Ѫ�䣩��ħ�䷽
		staticrecipe[343]={recipe_id=1866,recipe_group=0,recipe_level=1,recipe_type=5}---��Ѫ�䣩��ŭ�䷽
		staticrecipe[344]={recipe_id=1895,recipe_group=0,recipe_level=1,recipe_type=5}---��Ѫ�䣩�����䷽
		staticrecipe[345]={recipe_id=1865,recipe_group=0,recipe_level=1,recipe_type=5}---��Ѫ�䣩�����䷽
		staticrecipe[346]={recipe_id=1896,recipe_group=0,recipe_level=1,recipe_type=5}---��Ѫ�䣩�����䷽
		staticrecipe[347]={recipe_id=1861,recipe_group=0,recipe_level=1,recipe_type=5}---��Ѫ�䣩�����䷽
		staticrecipe[348]={recipe_id=1899,recipe_group=0,recipe_level=1,recipe_type=5}---��Ѫ�䣩�����䷽
		staticrecipe[349]={recipe_id=1892,recipe_group=0,recipe_level=1,recipe_type=5}---��Ѫ�䣩�����䷽
		staticrecipe[350]={recipe_id=1883,recipe_group=0,recipe_level=1,recipe_type=5}---��Ѫ�䣩�����䷽
		staticrecipe[351]={recipe_id=1867,recipe_group=0,recipe_level=1,recipe_type=5}---��Ѫ�䣩�����䷽
		staticrecipe[352]={recipe_id=1893,recipe_group=0,recipe_level=1,recipe_type=5}---��Ѫ�䣩ħ���䷽
		staticrecipe[353]={recipe_id=1898,recipe_group=0,recipe_level=1,recipe_type=5}---��Ѫ�䣩ħ���䷽
		staticrecipe[354]={recipe_id=1897,recipe_group=0,recipe_level=1,recipe_type=5}---��Ѫ�䣩ħ���䷽
		staticrecipe[355]={recipe_id=1888,recipe_group=0,recipe_level=1,recipe_type=5}---��Ѫ�䣩ħɷ�䷽
		staticrecipe[356]={recipe_id=1875,recipe_group=0,recipe_level=1,recipe_type=5}---��Ѫ�䣩ħ���䷽
		staticrecipe[357]={recipe_id=1885,recipe_group=0,recipe_level=1,recipe_type=5}---��Ѫ�䣩ĩ���䷽
		staticrecipe[358]={recipe_id=1891,recipe_group=0,recipe_level=1,recipe_type=5}---��Ѫ�䣩ŭ���䷽
		staticrecipe[359]={recipe_id=1863,recipe_group=0,recipe_level=1,recipe_type=5}---��Ѫ�䣩�ƻ��䷽
		staticrecipe[360]={recipe_id=1889,recipe_group=0,recipe_level=1,recipe_type=5}---��Ѫ�䣩�ƿ��䷽
		staticrecipe[361]={recipe_id=1879,recipe_group=0,recipe_level=1,recipe_type=5}---��Ѫ�䣩�����䷽
		staticrecipe[362]={recipe_id=1882,recipe_group=0,recipe_level=1,recipe_type=5}---��Ѫ�䣩��Ѫ�䷽
		staticrecipe[363]={recipe_id=1868,recipe_group=0,recipe_level=1,recipe_type=5}---��Ѫ�䣩��Ǵ�䷽
		staticrecipe[364]={recipe_id=1874,recipe_group=0,recipe_level=1,recipe_type=5}---��Ѫ�䣩��ɷ�䷽
		staticrecipe[365]={recipe_id=1877,recipe_group=0,recipe_level=1,recipe_type=5}---��Ѫ�䣩�����䷽
		staticrecipe[366]={recipe_id=1880,recipe_group=0,recipe_level=1,recipe_type=5}---��Ѫ�䣩�����䷽
		staticrecipe[367]={recipe_id=1894,recipe_group=0,recipe_level=1,recipe_type=5}---��Ѫ�䣩Ω���䷽
		staticrecipe[368]={recipe_id=1864,recipe_group=0,recipe_level=1,recipe_type=5}---��Ѫ�䣩�޼��䷽
		staticrecipe[369]={recipe_id=1872,recipe_group=0,recipe_level=1,recipe_type=5}---��Ѫ�䣩�����䷽
		staticrecipe[370]={recipe_id=1890,recipe_group=0,recipe_level=1,recipe_type=5}---��Ѫ�䣩�����䷽
		staticrecipe[371]={recipe_id=1878,recipe_group=0,recipe_level=1,recipe_type=5}---��Ѫ�䣩Ѫ��䷽
		staticrecipe[372]={recipe_id=1871,recipe_group=0,recipe_level=1,recipe_type=5}---��Ѫ�䣩ҵ���䷽
		staticrecipe[373]={recipe_id=1873,recipe_group=0,recipe_level=1,recipe_type=5}---��Ѫ�䣩ս���䷽
		staticrecipe[374]={recipe_id=1862,recipe_group=0,recipe_level=1,recipe_type=5}---��Ѫ�䣩�����䷽
		staticrecipe[375]={recipe_id=1876,recipe_group=0,recipe_level=1,recipe_type=5}---��Ѫ�䣩��Թ�䷽
		staticrecipe[376]={recipe_id=2957,recipe_group=0,recipe_level=2,recipe_type=5}---Ѫ�令��<����><����>�䷽
		staticrecipe[377]={recipe_id=2955,recipe_group=0,recipe_level=2,recipe_type=5}---Ѫ�令��<����><����>�䷽
		staticrecipe[378]={recipe_id=2960,recipe_group=0,recipe_level=2,recipe_type=5}---Ѫ�令��<����><ŭ��>�䷽
		staticrecipe[379]={recipe_id=2956,recipe_group=0,recipe_level=2,recipe_type=5}---Ѫ�令��<����><����>�䷽
		staticrecipe[380]={recipe_id=2961,recipe_group=0,recipe_level=2,recipe_type=5}---Ѫ�令��<ħ��><����>�䷽
		staticrecipe[381]={recipe_id=2959,recipe_group=0,recipe_level=2,recipe_type=5}---Ѫ�令��<��Ѫ><����>�䷽
		staticrecipe[382]={recipe_id=2958,recipe_group=0,recipe_level=2,recipe_type=5}---Ѫ�令��<��Ǵ><��ɷ>�䷽
		staticrecipe[383]={recipe_id=2962,recipe_group=0,recipe_level=2,recipe_type=5}---Ѫ�令��<�޼�><ĩ��>�䷽
		staticrecipe[384]={recipe_id=2963,recipe_group=0,recipe_level=2,recipe_type=5}---Ѫ�令��<����><����>�䷽
		staticrecipe[385]={recipe_id=3040,recipe_group=0,recipe_level=1,recipe_type=5}---���н��ҡ������䷽
		staticrecipe[386]={recipe_id=3041,recipe_group=0,recipe_level=1,recipe_type=5}---���н��ҡ������䷽
		staticrecipe[387]={recipe_id=3042,recipe_group=0,recipe_level=1,recipe_type=5}---���н��ҡ��ļ��䷽
		staticrecipe[388]={recipe_id=3043,recipe_group=0,recipe_level=1,recipe_type=5}---���н��ҡ�����䷽
		staticrecipe[389]={recipe_id=3044,recipe_group=0,recipe_level=1,recipe_type=5}---���н��ҡ������䷽
		staticrecipe[390]={recipe_id=3045,recipe_group=0,recipe_level=1,recipe_type=5}---���н��ҡ��߼��䷽
		staticrecipe[391]={recipe_id=3046,recipe_group=0,recipe_level=1,recipe_type=5}---���н��ҡ��˼��䷽
		staticrecipe[392]={recipe_id=3047,recipe_group=0,recipe_level=1,recipe_type=5}---���н��ҡ��ż��䷽
		staticrecipe[393]={recipe_id=3048,recipe_group=0,recipe_level=1,recipe_type=5}---���н��ҡ�ʮ���䷽
		staticrecipe[394]={recipe_id=3049,recipe_group=0,recipe_level=1,recipe_type=5}---���н��ҡ�ʮһ���䷽
		staticrecipe[395]={recipe_id=3050,recipe_group=0,recipe_level=1,recipe_type=5}---���н��ҡ�ʮ�����䷽
		staticrecipe[396]={recipe_id=3051,recipe_group=0,recipe_level=1,recipe_type=5}---���н��ҡ�ʮ�����䷽
		staticrecipe[397]={recipe_id=3052,recipe_group=0,recipe_level=1,recipe_type=5}---���н��ҡ�ʮ�ļ��䷽
		staticrecipe[398]={recipe_id=3053,recipe_group=0,recipe_level=1,recipe_type=5}---���н��ҡ�ʮ����䷽
		staticrecipe[399]={recipe_id=3054,recipe_group=0,recipe_level=1,recipe_type=5}---���н��ҡ�ʮ�����䷽
		staticrecipe[400]={recipe_id=3055,recipe_group=0,recipe_level=1,recipe_type=5}---���н��ҡ�ʮ�߼��䷽
		staticrecipe[401]={recipe_id=3056,recipe_group=0,recipe_level=1,recipe_type=5}---���н��ҡ�ʮ�˼��䷽
		staticrecipe[402]={recipe_id=3057,recipe_group=0,recipe_level=1,recipe_type=5}---���н��ҡ�ʮ�ż��䷽
		staticrecipe[403]={recipe_id=3058,recipe_group=0,recipe_level=1,recipe_type=5}---���н��ҡ���ʮ���䷽
		staticrecipe[404]={recipe_id=3059,recipe_group=0,recipe_level=1,recipe_type=5}---���н��ҡ���ʮһ���䷽
		staticrecipe[405]={recipe_id=3060,recipe_group=0,recipe_level=1,recipe_type=5}---���н��ҡ���ʮ�����䷽
		staticrecipe[406]={recipe_id=3061,recipe_group=0,recipe_level=1,recipe_type=5}---���н��ҡ���ʮ�����䷽
		staticrecipe[407]={recipe_id=3062,recipe_group=0,recipe_level=1,recipe_type=5}---���н��ҡ���ʮ�ļ��䷽
		staticrecipe[408]={recipe_id=3063,recipe_group=0,recipe_level=1,recipe_type=5}---���н��ҡ���ʮ����䷽
		staticrecipe[409]={recipe_id=3064,recipe_group=0,recipe_level=1,recipe_type=5}---���н��ҡ���ʮ�����䷽
		staticrecipe[410]={recipe_id=3065,recipe_group=0,recipe_level=1,recipe_type=5}---���н��ҡ���ʮ�߼��䷽
		staticrecipe[411]={recipe_id=3066,recipe_group=0,recipe_level=1,recipe_type=5}---���н��ҡ���ʮ�˼��䷽
		staticrecipe[412]={recipe_id=3067,recipe_group=0,recipe_level=1,recipe_type=5}---���н��ҡ���ʮ�ż��䷽
		staticrecipe[413]={recipe_id=3068,recipe_group=0,recipe_level=1,recipe_type=5}---���н��ҡ���ʮ���䷽
		staticrecipe[414]={recipe_id=3069,recipe_group=0,recipe_level=1,recipe_type=5}---���н��ҡ���ʮһ���䷽
		staticrecipe[415]={recipe_id=3070,recipe_group=0,recipe_level=1,recipe_type=5}---���н��ҡ���ʮ�����䷽
		staticrecipe[416]={recipe_id=3071,recipe_group=0,recipe_level=1,recipe_type=5}---���н��ҡ���ʮ�����䷽
		staticrecipe[417]={recipe_id=3072,recipe_group=0,recipe_level=1,recipe_type=5}---���н��ҡ���ʮ�ļ��䷽
		staticrecipe[418]={recipe_id=3073,recipe_group=0,recipe_level=1,recipe_type=5}---���н��ҡ���ʮ����䷽
		staticrecipe[419]={recipe_id=3074,recipe_group=0,recipe_level=1,recipe_type=5}---���н��ҡ���ʮ�����䷽
		staticrecipe[420]={recipe_id=3075,recipe_group=0,recipe_level=1,recipe_type=5}---̫����ҡ������䷽
		staticrecipe[421]={recipe_id=3076,recipe_group=0,recipe_level=1,recipe_type=5}---̫����ҡ������䷽
		staticrecipe[422]={recipe_id=3077,recipe_group=0,recipe_level=1,recipe_type=5}---̫����ҡ��ļ��䷽
		staticrecipe[423]={recipe_id=3078,recipe_group=0,recipe_level=1,recipe_type=5}---̫����ҡ�����䷽
		staticrecipe[424]={recipe_id=3079,recipe_group=0,recipe_level=1,recipe_type=5}---̫����ҡ������䷽
		staticrecipe[425]={recipe_id=3080,recipe_group=0,recipe_level=1,recipe_type=5}---̫����ҡ��߼��䷽
		staticrecipe[426]={recipe_id=3081,recipe_group=0,recipe_level=1,recipe_type=5}---̫����ҡ��˼��䷽
		staticrecipe[427]={recipe_id=3082,recipe_group=0,recipe_level=1,recipe_type=5}---̫����ҡ��ż��䷽
		staticrecipe[428]={recipe_id=3083,recipe_group=0,recipe_level=1,recipe_type=5}---̫����ҡ�ʮ���䷽
		staticrecipe[429]={recipe_id=3084,recipe_group=0,recipe_level=1,recipe_type=5}---̫����ҡ�ʮһ���䷽
		staticrecipe[430]={recipe_id=3085,recipe_group=0,recipe_level=1,recipe_type=5}---̫����ҡ�ʮ�����䷽
		staticrecipe[431]={recipe_id=3086,recipe_group=0,recipe_level=1,recipe_type=5}---̫����ҡ�ʮ�����䷽
		staticrecipe[432]={recipe_id=3087,recipe_group=0,recipe_level=1,recipe_type=5}---̫����ҡ�ʮ�ļ��䷽
		staticrecipe[433]={recipe_id=3088,recipe_group=0,recipe_level=1,recipe_type=5}---̫����ҡ�ʮ����䷽
		staticrecipe[434]={recipe_id=3089,recipe_group=0,recipe_level=1,recipe_type=5}---̫����ҡ�ʮ�����䷽
		staticrecipe[435]={recipe_id=3090,recipe_group=0,recipe_level=1,recipe_type=5}---̫����ҡ�ʮ�߼��䷽
		staticrecipe[436]={recipe_id=3091,recipe_group=0,recipe_level=1,recipe_type=5}---̫����ҡ�ʮ�˼��䷽
		staticrecipe[437]={recipe_id=3092,recipe_group=0,recipe_level=1,recipe_type=5}---̫����ҡ�ʮ�ż��䷽
		staticrecipe[438]={recipe_id=3093,recipe_group=0,recipe_level=1,recipe_type=5}---̫����ҡ���ʮ���䷽
		staticrecipe[439]={recipe_id=3094,recipe_group=0,recipe_level=1,recipe_type=5}---̫����ҡ���ʮһ���䷽
		staticrecipe[440]={recipe_id=3095,recipe_group=0,recipe_level=1,recipe_type=5}---̫����ҡ���ʮ�����䷽
		staticrecipe[441]={recipe_id=3096,recipe_group=0,recipe_level=1,recipe_type=5}---̫����ҡ���ʮ�����䷽
		staticrecipe[442]={recipe_id=3097,recipe_group=0,recipe_level=1,recipe_type=5}---̫����ҡ���ʮ�ļ��䷽
		staticrecipe[443]={recipe_id=3098,recipe_group=0,recipe_level=1,recipe_type=5}---̫����ҡ���ʮ����䷽
		staticrecipe[444]={recipe_id=3099,recipe_group=0,recipe_level=1,recipe_type=5}---̫����ҡ���ʮ�����䷽
		staticrecipe[445]={recipe_id=3100,recipe_group=0,recipe_level=1,recipe_type=5}---̫����ҡ���ʮ�߼��䷽
		staticrecipe[446]={recipe_id=3101,recipe_group=0,recipe_level=1,recipe_type=5}---̫����ҡ���ʮ�˼��䷽
		staticrecipe[447]={recipe_id=3102,recipe_group=0,recipe_level=1,recipe_type=5}---̫����ҡ���ʮ�ż��䷽
		staticrecipe[448]={recipe_id=3103,recipe_group=0,recipe_level=1,recipe_type=5}---̫����ҡ���ʮ���䷽
		staticrecipe[449]={recipe_id=3104,recipe_group=0,recipe_level=1,recipe_type=5}---̫����ҡ���ʮһ���䷽
		staticrecipe[450]={recipe_id=3105,recipe_group=0,recipe_level=1,recipe_type=5}---̫����ҡ���ʮ�����䷽
		staticrecipe[451]={recipe_id=3106,recipe_group=0,recipe_level=1,recipe_type=5}---̫����ҡ���ʮ�����䷽
		staticrecipe[452]={recipe_id=3107,recipe_group=0,recipe_level=1,recipe_type=5}---̫����ҡ���ʮ�ļ��䷽
		staticrecipe[453]={recipe_id=3108,recipe_group=0,recipe_level=1,recipe_type=5}---̫����ҡ���ʮ����䷽
		staticrecipe[454]={recipe_id=3109,recipe_group=0,recipe_level=1,recipe_type=5}---̫����ҡ���ʮ�����䷽
		staticrecipe[455]={recipe_id=3005,recipe_group=0,recipe_level=1,recipe_type=5}---��ң���ҡ������䷽
		staticrecipe[456]={recipe_id=3006,recipe_group=0,recipe_level=1,recipe_type=5}---��ң���ҡ������䷽
		staticrecipe[457]={recipe_id=3007,recipe_group=0,recipe_level=1,recipe_type=5}---��ң���ҡ��ļ��䷽
		staticrecipe[458]={recipe_id=3008,recipe_group=0,recipe_level=1,recipe_type=5}---��ң���ҡ�����䷽
		staticrecipe[459]={recipe_id=3009,recipe_group=0,recipe_level=1,recipe_type=5}---��ң���ҡ������䷽
		staticrecipe[460]={recipe_id=3010,recipe_group=0,recipe_level=1,recipe_type=5}---��ң���ҡ��߼��䷽
		staticrecipe[461]={recipe_id=3011,recipe_group=0,recipe_level=1,recipe_type=5}---��ң���ҡ��˼��䷽
		staticrecipe[462]={recipe_id=3012,recipe_group=0,recipe_level=1,recipe_type=5}---��ң���ҡ��ż��䷽
		staticrecipe[463]={recipe_id=3013,recipe_group=0,recipe_level=1,recipe_type=5}---��ң���ҡ�ʮ���䷽
		staticrecipe[464]={recipe_id=3014,recipe_group=0,recipe_level=1,recipe_type=5}---��ң���ҡ�ʮһ���䷽
		staticrecipe[465]={recipe_id=3015,recipe_group=0,recipe_level=1,recipe_type=5}---��ң���ҡ�ʮ�����䷽
		staticrecipe[466]={recipe_id=3016,recipe_group=0,recipe_level=1,recipe_type=5}---��ң���ҡ�ʮ�����䷽
		staticrecipe[467]={recipe_id=3017,recipe_group=0,recipe_level=1,recipe_type=5}---��ң���ҡ�ʮ�ļ��䷽
		staticrecipe[468]={recipe_id=3018,recipe_group=0,recipe_level=1,recipe_type=5}---��ң���ҡ�ʮ����䷽
		staticrecipe[469]={recipe_id=3019,recipe_group=0,recipe_level=1,recipe_type=5}---��ң���ҡ�ʮ�����䷽
		staticrecipe[470]={recipe_id=3020,recipe_group=0,recipe_level=1,recipe_type=5}---��ң���ҡ�ʮ�߼��䷽
		staticrecipe[471]={recipe_id=3021,recipe_group=0,recipe_level=1,recipe_type=5}---��ң���ҡ�ʮ�˼��䷽
		staticrecipe[472]={recipe_id=3022,recipe_group=0,recipe_level=1,recipe_type=5}---��ң���ҡ�ʮ�ż��䷽
		staticrecipe[473]={recipe_id=3023,recipe_group=0,recipe_level=1,recipe_type=5}---��ң���ҡ���ʮ���䷽
		staticrecipe[474]={recipe_id=3024,recipe_group=0,recipe_level=1,recipe_type=5}---��ң���ҡ���ʮһ���䷽
		staticrecipe[475]={recipe_id=3025,recipe_group=0,recipe_level=1,recipe_type=5}---��ң���ҡ���ʮ�����䷽
		staticrecipe[476]={recipe_id=3026,recipe_group=0,recipe_level=1,recipe_type=5}---��ң���ҡ���ʮ�����䷽
		staticrecipe[477]={recipe_id=3027,recipe_group=0,recipe_level=1,recipe_type=5}---��ң���ҡ���ʮ�ļ��䷽
		staticrecipe[478]={recipe_id=3028,recipe_group=0,recipe_level=1,recipe_type=5}---��ң���ҡ���ʮ����䷽
		staticrecipe[479]={recipe_id=3029,recipe_group=0,recipe_level=1,recipe_type=5}---��ң���ҡ���ʮ�����䷽
		staticrecipe[480]={recipe_id=3030,recipe_group=0,recipe_level=1,recipe_type=5}---��ң���ҡ���ʮ�߼��䷽
		staticrecipe[481]={recipe_id=3031,recipe_group=0,recipe_level=1,recipe_type=5}---��ң���ҡ���ʮ�˼��䷽
		staticrecipe[482]={recipe_id=3032,recipe_group=0,recipe_level=1,recipe_type=5}---��ң���ҡ���ʮ�ż��䷽
		staticrecipe[483]={recipe_id=3033,recipe_group=0,recipe_level=1,recipe_type=5}---��ң���ҡ���ʮ���䷽
		staticrecipe[484]={recipe_id=3034,recipe_group=0,recipe_level=1,recipe_type=5}---��ң���ҡ���ʮһ���䷽
		staticrecipe[485]={recipe_id=3035,recipe_group=0,recipe_level=1,recipe_type=5}---��ң���ҡ���ʮ�����䷽
		staticrecipe[486]={recipe_id=3036,recipe_group=0,recipe_level=1,recipe_type=5}---��ң���ҡ���ʮ�����䷽
		staticrecipe[487]={recipe_id=3037,recipe_group=0,recipe_level=1,recipe_type=5}---��ң���ҡ���ʮ�ļ��䷽
		staticrecipe[488]={recipe_id=3038,recipe_group=0,recipe_level=1,recipe_type=5}---��ң���ҡ���ʮ����䷽
		staticrecipe[489]={recipe_id=3039,recipe_group=0,recipe_level=1,recipe_type=5}---��ң���ҡ���ʮ�����䷽
		staticrecipe[490]={recipe_id=1939,recipe_group=0,recipe_level=10,recipe_type=3}---[142]�زؿ�[��]
		staticrecipe[491]={recipe_id=2005,recipe_group=0,recipe_level=10,recipe_type=3}---[142]�زؿ�[Ů]
		staticrecipe[492]={recipe_id=1937,recipe_group=0,recipe_level=8,recipe_type=3}---[120]ڤ����[��]
		staticrecipe[493]={recipe_id=2003,recipe_group=0,recipe_level=8,recipe_type=3}---[120]ڤ����[Ů]
		staticrecipe[494]={recipe_id=1938,recipe_group=0,recipe_level=9,recipe_type=3}---[135]���ǿ�[��]
		staticrecipe[495]={recipe_id=2004,recipe_group=0,recipe_level=9,recipe_type=3}---[135]���ǿ�[Ů]
		staticrecipe[496]={recipe_id=1946,recipe_group=0,recipe_level=10,recipe_type=3}---[142]�ŵ�ڤ�������[��]
		staticrecipe[497]={recipe_id=2012,recipe_group=0,recipe_level=10,recipe_type=3}---[142]�ŵ�ڤ�������[Ů]
		staticrecipe[498]={recipe_id=1944,recipe_group=0,recipe_level=8,recipe_type=3}---[120]���׶��Ŀ�[��]
		staticrecipe[499]={recipe_id=2010,recipe_group=0,recipe_level=8,recipe_type=3}---[120]���׶��Ŀ�[Ů]
		staticrecipe[500]={recipe_id=1945,recipe_group=0,recipe_level=9,recipe_type=3}---[135]ս�����ħ���[��]
		staticrecipe[501]={recipe_id=2011,recipe_group=0,recipe_level=9,recipe_type=3}---[135]ս�����ħ���[Ů]
		staticrecipe[502]={recipe_id=1960,recipe_group=0,recipe_level=10,recipe_type=3}---[142]�������𾫿�[��]
		staticrecipe[503]={recipe_id=2026,recipe_group=0,recipe_level=10,recipe_type=3}---[142]�������𾫿�[Ů]
		staticrecipe[504]={recipe_id=1958,recipe_group=0,recipe_level=8,recipe_type=3}---[120]���Ź��ǿ�[��]
		staticrecipe[505]={recipe_id=2024,recipe_group=0,recipe_level=8,recipe_type=3}---[120]���Ź��ǿ�[Ů]
		staticrecipe[506]={recipe_id=1959,recipe_group=0,recipe_level=9,recipe_type=3}---[135]�ķع�ڣ�����[��]
		staticrecipe[507]={recipe_id=2025,recipe_group=0,recipe_level=9,recipe_type=3}---[135]�ķع�ڣ�����[Ů]
		staticrecipe[508]={recipe_id=1981,recipe_group=0,recipe_level=10,recipe_type=3}---[142]�����ֻ�ħ�Ŀ�[��]
		staticrecipe[509]={recipe_id=2047,recipe_group=0,recipe_level=10,recipe_type=3}---[142]�����ֻ�ħ�Ŀ�[Ů]
		staticrecipe[510]={recipe_id=1979,recipe_group=0,recipe_level=8,recipe_type=3}---[120]��Ԧ���ҿ�[��]
		staticrecipe[511]={recipe_id=2045,recipe_group=0,recipe_level=8,recipe_type=3}---[120]��Ԧ���ҿ�[Ů]
		staticrecipe[512]={recipe_id=1980,recipe_group=0,recipe_level=9,recipe_type=3}---[135]ڤ�Ӷ���ϴ���[��]
		staticrecipe[513]={recipe_id=2046,recipe_group=0,recipe_level=9,recipe_type=3}---[135]ڤ�Ӷ���ϴ���[Ů]
		staticrecipe[514]={recipe_id=1988,recipe_group=0,recipe_level=10,recipe_type=3}---[142]�߽����������[��]
		staticrecipe[515]={recipe_id=2054,recipe_group=0,recipe_level=10,recipe_type=3}---[142]�߽����������[Ů]
		staticrecipe[516]={recipe_id=1986,recipe_group=0,recipe_level=8,recipe_type=3}---[120]�߿׾ۻ��[��]
		staticrecipe[517]={recipe_id=2052,recipe_group=0,recipe_level=8,recipe_type=3}---[120]�߿׾ۻ��[Ů]
		staticrecipe[518]={recipe_id=1987,recipe_group=0,recipe_level=9,recipe_type=3}---[135]Ѫ���𲨵���[��]
		staticrecipe[519]={recipe_id=2053,recipe_group=0,recipe_level=9,recipe_type=3}---[135]Ѫ���𲨵���[Ů]
		staticrecipe[520]={recipe_id=1967,recipe_group=0,recipe_level=10,recipe_type=3}---[142]����Ԫ��ڤ��[��]
		staticrecipe[521]={recipe_id=2033,recipe_group=0,recipe_level=10,recipe_type=3}---[142]����Ԫ��ڤ��[Ů]
		staticrecipe[522]={recipe_id=1965,recipe_group=0,recipe_level=8,recipe_type=3}---[120]��Χ��ڤ��[��]
		staticrecipe[523]={recipe_id=2031,recipe_group=0,recipe_level=8,recipe_type=3}---[120]��Χ��ڤ��[Ů]
		staticrecipe[524]={recipe_id=1966,recipe_group=0,recipe_level=9,recipe_type=3}---[135]������ڤ��[��]
		staticrecipe[525]={recipe_id=2032,recipe_group=0,recipe_level=9,recipe_type=3}---[135]������ڤ��[Ů]
		staticrecipe[526]={recipe_id=1995,recipe_group=0,recipe_level=10,recipe_type=3}---[142]����������ħ��[��]
		staticrecipe[527]={recipe_id=2061,recipe_group=0,recipe_level=10,recipe_type=3}---[142]����������ħ��[Ů]
		staticrecipe[528]={recipe_id=1993,recipe_group=0,recipe_level=8,recipe_type=3}---[120]���Ž�����[��]
		staticrecipe[529]={recipe_id=2059,recipe_group=0,recipe_level=8,recipe_type=3}---[120]���Ž�����[Ů]
		staticrecipe[530]={recipe_id=1994,recipe_group=0,recipe_level=9,recipe_type=3}---[135]��Ӱ�ƶ����ȿ�[��]
		staticrecipe[531]={recipe_id=2060,recipe_group=0,recipe_level=9,recipe_type=3}---[135]��Ӱ�ƶ����ȿ�[Ů]
		staticrecipe[532]={recipe_id=1974,recipe_group=0,recipe_level=10,recipe_type=3}---[142]�������ڳ��տ�[��]
		staticrecipe[533]={recipe_id=2040,recipe_group=0,recipe_level=10,recipe_type=3}---[142]�������ڳ��տ�[Ů]
		staticrecipe[534]={recipe_id=1972,recipe_group=0,recipe_level=8,recipe_type=3}---[120]���о�����[��]
		staticrecipe[535]={recipe_id=2038,recipe_group=0,recipe_level=8,recipe_type=3}---[120]���о�����[Ů]
		staticrecipe[536]={recipe_id=1973,recipe_group=0,recipe_level=9,recipe_type=3}---[135]����ܳ������[��]
		staticrecipe[537]={recipe_id=2039,recipe_group=0,recipe_level=9,recipe_type=3}---[135]����ܳ������[Ů]
		staticrecipe[538]={recipe_id=1953,recipe_group=0,recipe_level=10,recipe_type=3}---[142]�������������[��]
		staticrecipe[539]={recipe_id=2019,recipe_group=0,recipe_level=10,recipe_type=3}---[142]�������������[Ů]
		staticrecipe[540]={recipe_id=1951,recipe_group=0,recipe_level=8,recipe_type=3}---[120]�Ź����п�[��]
		staticrecipe[541]={recipe_id=2017,recipe_group=0,recipe_level=8,recipe_type=3}---[120]�Ź����п�[Ů]
		staticrecipe[542]={recipe_id=1952,recipe_group=0,recipe_level=9,recipe_type=3}---[135]��ڤת�������[��]
		staticrecipe[543]={recipe_id=2018,recipe_group=0,recipe_level=9,recipe_type=3}---[135]��ڤת�������[Ů]
		staticrecipe[544]={recipe_id=251,recipe_group=0,recipe_level=10,recipe_type=3}---[142]�ʼ���[��]
		staticrecipe[545]={recipe_id=299,recipe_group=0,recipe_level=10,recipe_type=3}---[142]�ʼ���[Ů]
		staticrecipe[546]={recipe_id=249,recipe_group=0,recipe_level=8,recipe_type=3}---[120]�����[��]
		staticrecipe[547]={recipe_id=297,recipe_group=0,recipe_level=8,recipe_type=3}---[120]�����[Ů]
		staticrecipe[548]={recipe_id=250,recipe_group=0,recipe_level=9,recipe_type=3}---[135]�����[��]
		staticrecipe[549]={recipe_id=298,recipe_group=0,recipe_level=9,recipe_type=3}---[135]�����[Ů]
		staticrecipe[550]={recipe_id=958,recipe_group=0,recipe_level=10,recipe_type=3}---[142]�������а���[��]
		staticrecipe[551]={recipe_id=959,recipe_group=0,recipe_level=10,recipe_type=3}---[142]�������а���[Ů]
		staticrecipe[552]={recipe_id=962,recipe_group=0,recipe_level=8,recipe_type=3}---[120]������Ѫ��[��]
		staticrecipe[553]={recipe_id=963,recipe_group=0,recipe_level=8,recipe_type=3}---[120]������Ѫ��[Ů]
		staticrecipe[554]={recipe_id=964,recipe_group=0,recipe_level=9,recipe_type=3}---[135]���������ڽ��[��]
		staticrecipe[555]={recipe_id=965,recipe_group=0,recipe_level=9,recipe_type=3}---[135]���������ڽ��[Ů]
		staticrecipe[556]={recipe_id=966,recipe_group=0,recipe_level=10,recipe_type=3}---[142]�����ݺ������[��]
		staticrecipe[557]={recipe_id=967,recipe_group=0,recipe_level=10,recipe_type=3}---[142]�����ݺ������[Ů]
		staticrecipe[558]={recipe_id=970,recipe_group=0,recipe_level=8,recipe_type=3}---[120]�����ƾ���[��]
		staticrecipe[559]={recipe_id=971,recipe_group=0,recipe_level=8,recipe_type=3}---[120]�����ƾ���[Ů]
		staticrecipe[560]={recipe_id=972,recipe_group=0,recipe_level=9,recipe_type=3}---[135]����������Ѫ��[��]
		staticrecipe[561]={recipe_id=973,recipe_group=0,recipe_level=9,recipe_type=3}---[135]����������Ѫ��[Ů]
		staticrecipe[562]={recipe_id=974,recipe_group=0,recipe_level=10,recipe_type=3}---[142]�߽ݵ��������[��]
		staticrecipe[563]={recipe_id=975,recipe_group=0,recipe_level=10,recipe_type=3}---[142]�߽ݵ��������[Ů]
		staticrecipe[564]={recipe_id=978,recipe_group=0,recipe_level=8,recipe_type=3}---[120]�����һ��[��]
		staticrecipe[565]={recipe_id=979,recipe_group=0,recipe_level=8,recipe_type=3}---[120]�����һ��[Ů]
		staticrecipe[566]={recipe_id=980,recipe_group=0,recipe_level=9,recipe_type=3}---[135]���Х���⥿�[��]
		staticrecipe[567]={recipe_id=981,recipe_group=0,recipe_level=9,recipe_type=3}---[135]���Х���⥿�[Ů]
		staticrecipe[568]={recipe_id=982,recipe_group=0,recipe_level=10,recipe_type=3}---[142]�ĺ�Х�������[��]
		staticrecipe[569]={recipe_id=983,recipe_group=0,recipe_level=10,recipe_type=3}---[142]�ĺ�Х�������[Ů]
		staticrecipe[570]={recipe_id=986,recipe_group=0,recipe_level=8,recipe_type=3}---[120]���ķ�����[��]
		staticrecipe[571]={recipe_id=987,recipe_group=0,recipe_level=8,recipe_type=3}---[120]���ķ�����[Ů]
		staticrecipe[572]={recipe_id=988,recipe_group=0,recipe_level=9,recipe_type=3}---[135]������ͷ������[��]
		staticrecipe[573]={recipe_id=989,recipe_group=0,recipe_level=9,recipe_type=3}---[135]������ͷ������[Ů]
		staticrecipe[574]={recipe_id=990,recipe_group=0,recipe_level=10,recipe_type=3}---[142]�����Ӣ���Ŀ�[��]
		staticrecipe[575]={recipe_id=991,recipe_group=0,recipe_level=10,recipe_type=3}---[142]�����Ӣ���Ŀ�[Ů]
		staticrecipe[576]={recipe_id=994,recipe_group=0,recipe_level=8,recipe_type=3}---[120]����ŭ���[��]
		staticrecipe[577]={recipe_id=995,recipe_group=0,recipe_level=8,recipe_type=3}---[120]����ŭ���[Ů]
		staticrecipe[578]={recipe_id=996,recipe_group=0,recipe_level=9,recipe_type=3}---[135]����̫�������[��]
		staticrecipe[579]={recipe_id=997,recipe_group=0,recipe_level=9,recipe_type=3}---[135]����̫�������[Ů]
		staticrecipe[580]={recipe_id=998,recipe_group=0,recipe_level=10,recipe_type=3}---[142]��ɷ���ӷ����[��]
		staticrecipe[581]={recipe_id=999,recipe_group=0,recipe_level=10,recipe_type=3}---[142]��ɷ���ӷ����[Ů]
		staticrecipe[582]={recipe_id=1002,recipe_group=0,recipe_level=8,recipe_type=3}---[120]���������[��]
		staticrecipe[583]={recipe_id=1003,recipe_group=0,recipe_level=8,recipe_type=3}---[120]���������[Ů]
		staticrecipe[584]={recipe_id=1004,recipe_group=0,recipe_level=9,recipe_type=3}---[135]���ǽ����ƽ��[��]
		staticrecipe[585]={recipe_id=1005,recipe_group=0,recipe_level=9,recipe_type=3}---[135]���ǽ����ƽ��[Ů]
		staticrecipe[586]={recipe_id=1006,recipe_group=0,recipe_level=10,recipe_type=3}---[142]����ۺ�������[��]
		staticrecipe[587]={recipe_id=1007,recipe_group=0,recipe_level=10,recipe_type=3}---[142]����ۺ�������[Ů]
		staticrecipe[588]={recipe_id=1010,recipe_group=0,recipe_level=8,recipe_type=3}---[120]���޳��ۿ�[��]
		staticrecipe[589]={recipe_id=1011,recipe_group=0,recipe_level=8,recipe_type=3}---[120]���޳��ۿ�[Ů]
		staticrecipe[590]={recipe_id=1012,recipe_group=0,recipe_level=9,recipe_type=3}---[135]��������а���[��]
		staticrecipe[591]={recipe_id=1013,recipe_group=0,recipe_level=9,recipe_type=3}---[135]��������а���[Ů]
		staticrecipe[592]={recipe_id=950,recipe_group=0,recipe_level=10,recipe_type=3}---[142]��ħ����ڤ���[��]
		staticrecipe[593]={recipe_id=951,recipe_group=0,recipe_level=10,recipe_type=3}---[142]��ħ����ڤ���[Ů]
		staticrecipe[594]={recipe_id=954,recipe_group=0,recipe_level=8,recipe_type=3}---[120]��ת���Ŀ�[��]
		staticrecipe[595]={recipe_id=955,recipe_group=0,recipe_level=8,recipe_type=3}---[120]��ת���Ŀ�[Ů]
		staticrecipe[596]={recipe_id=956,recipe_group=0,recipe_level=9,recipe_type=3}---[135]�������˽ٿ�[��]
		staticrecipe[597]={recipe_id=957,recipe_group=0,recipe_level=9,recipe_type=3}---[135]�������˽ٿ�[Ů]
		staticrecipe[598]={recipe_id=255,recipe_group=0,recipe_level=10,recipe_type=3}---[142]���޿�[��]
		staticrecipe[599]={recipe_id=303,recipe_group=0,recipe_level=10,recipe_type=3}---[142]���޿�[Ů]
		staticrecipe[600]={recipe_id=253,recipe_group=0,recipe_level=8,recipe_type=3}---[120]�����[��]
		staticrecipe[601]={recipe_id=301,recipe_group=0,recipe_level=8,recipe_type=3}---[120]�����[Ů]
		staticrecipe[602]={recipe_id=254,recipe_group=0,recipe_level=9,recipe_type=3}---[135]���ſ�[��]
		staticrecipe[603]={recipe_id=302,recipe_group=0,recipe_level=9,recipe_type=3}---[135]���ſ�[Ů]
		staticrecipe[604]={recipe_id=1022,recipe_group=0,recipe_level=10,recipe_type=3}---[142]��Ū÷����̾��[��]
		staticrecipe[605]={recipe_id=1023,recipe_group=0,recipe_level=10,recipe_type=3}---[142]��Ū÷����̾��[Ů]
		staticrecipe[606]={recipe_id=1026,recipe_group=0,recipe_level=8,recipe_type=3}---[120]��β������[��]
		staticrecipe[607]={recipe_id=1027,recipe_group=0,recipe_level=8,recipe_type=3}---[120]��β������[Ů]
		staticrecipe[608]={recipe_id=1028,recipe_group=0,recipe_level=9,recipe_type=3}---[135]��������ٻ���[��]
		staticrecipe[609]={recipe_id=1029,recipe_group=0,recipe_level=9,recipe_type=3}---[135]��������ٻ���[Ů]
		staticrecipe[610]={recipe_id=1030,recipe_group=0,recipe_level=10,recipe_type=3}---[142]��Ҷ��欽�����[��]
		staticrecipe[611]={recipe_id=1031,recipe_group=0,recipe_level=10,recipe_type=3}---[142]��Ҷ��欽�����[Ů]
		staticrecipe[612]={recipe_id=1034,recipe_group=0,recipe_level=8,recipe_type=3}---[120]���������[��]
		staticrecipe[613]={recipe_id=1035,recipe_group=0,recipe_level=8,recipe_type=3}---[120]���������[Ů]
		staticrecipe[614]={recipe_id=1036,recipe_group=0,recipe_level=9,recipe_type=3}---[135]�òʻ�����ƿ�[��]
		staticrecipe[615]={recipe_id=1037,recipe_group=0,recipe_level=9,recipe_type=3}---[135]�òʻ�����ƿ�[Ů]
		staticrecipe[616]={recipe_id=1038,recipe_group=0,recipe_level=10,recipe_type=3}---[142]�߲�Ө�����Ŀ�[��]
		staticrecipe[617]={recipe_id=1039,recipe_group=0,recipe_level=10,recipe_type=3}---[142]�߲�Ө�����Ŀ�[Ů]
		staticrecipe[618]={recipe_id=1042,recipe_group=0,recipe_level=8,recipe_type=3}---[120]�߱������[��]
		staticrecipe[619]={recipe_id=1043,recipe_group=0,recipe_level=8,recipe_type=3}---[120]�߱������[Ů]
		staticrecipe[620]={recipe_id=1044,recipe_group=0,recipe_level=9,recipe_type=3}---[135]�仨��ˮ�����[��]
		staticrecipe[621]={recipe_id=1045,recipe_group=0,recipe_level=9,recipe_type=3}---[135]�仨��ˮ�����[Ů]
		staticrecipe[622]={recipe_id=1046,recipe_group=0,recipe_level=10,recipe_type=3}---[142]��Ұ���������[��]
		staticrecipe[623]={recipe_id=1047,recipe_group=0,recipe_level=10,recipe_type=3}---[142]��Ұ���������[Ů]
		staticrecipe[624]={recipe_id=1050,recipe_group=0,recipe_level=8,recipe_type=3}---[120]��ʥ���տ�[��]
		staticrecipe[625]={recipe_id=1051,recipe_group=0,recipe_level=8,recipe_type=3}---[120]��ʥ���տ�[Ů]
		staticrecipe[626]={recipe_id=1052,recipe_group=0,recipe_level=9,recipe_type=3}---[135]��ϼ�ֿ��޲ʿ�[��]
		staticrecipe[627]={recipe_id=1053,recipe_group=0,recipe_level=9,recipe_type=3}---[135]��ϼ�ֿ��޲ʿ�[Ů]
		staticrecipe[628]={recipe_id=1054,recipe_group=0,recipe_level=10,recipe_type=3}---[142]�˱�ҹ�������[��]
		staticrecipe[629]={recipe_id=1055,recipe_group=0,recipe_level=10,recipe_type=3}---[142]�˱�ҹ�������[Ů]
		staticrecipe[630]={recipe_id=1058,recipe_group=0,recipe_level=8,recipe_type=3}---[120]�˻ļ��ƿ�[��]
		staticrecipe[631]={recipe_id=1059,recipe_group=0,recipe_level=8,recipe_type=3}---[120]�˻ļ��ƿ�[Ů]
		staticrecipe[632]={recipe_id=1060,recipe_group=0,recipe_level=9,recipe_type=3}---[135]�ٷ�������ң��[��]
		staticrecipe[633]={recipe_id=1061,recipe_group=0,recipe_level=9,recipe_type=3}---[135]�ٷ�������ң��[Ů]
		staticrecipe[634]={recipe_id=1062,recipe_group=0,recipe_level=10,recipe_type=3}---[142]������ᰰ����[��]
		staticrecipe[635]={recipe_id=1063,recipe_group=0,recipe_level=10,recipe_type=3}---[142]������ᰰ����[Ů]
		staticrecipe[636]={recipe_id=1066,recipe_group=0,recipe_level=8,recipe_type=3}---[120]��ɫ�����[��]
		staticrecipe[637]={recipe_id=1067,recipe_group=0,recipe_level=8,recipe_type=3}---[120]��ɫ�����[Ů]
		staticrecipe[638]={recipe_id=1068,recipe_group=0,recipe_level=9,recipe_type=3}---[135]̫���������Ŀ�[��]
		staticrecipe[639]={recipe_id=1069,recipe_group=0,recipe_level=9,recipe_type=3}---[135]̫���������Ŀ�[Ů]
		staticrecipe[640]={recipe_id=1070,recipe_group=0,recipe_level=10,recipe_type=3}---[142]�Ż������篿�[��]
		staticrecipe[641]={recipe_id=1071,recipe_group=0,recipe_level=10,recipe_type=3}---[142]�Ż������篿�[Ů]
		staticrecipe[642]={recipe_id=1074,recipe_group=0,recipe_level=8,recipe_type=3}---[120]�Ż���ɴ��[��]
		staticrecipe[643]={recipe_id=1075,recipe_group=0,recipe_level=8,recipe_type=3}---[120]�Ż���ɴ��[Ů]
		staticrecipe[644]={recipe_id=1076,recipe_group=0,recipe_level=9,recipe_type=3}---[135]��̨�����л���[��]
		staticrecipe[645]={recipe_id=1077,recipe_group=0,recipe_level=9,recipe_type=3}---[135]��̨�����л���[Ů]
		staticrecipe[646]={recipe_id=1014,recipe_group=0,recipe_level=10,recipe_type=3}---[142]������̨�����[��]
		staticrecipe[647]={recipe_id=1015,recipe_group=0,recipe_level=10,recipe_type=3}---[142]������̨�����[Ů]
		staticrecipe[648]={recipe_id=1018,recipe_group=0,recipe_level=8,recipe_type=3}---[120]�Ż����Ŀ�[��]
		staticrecipe[649]={recipe_id=1019,recipe_group=0,recipe_level=8,recipe_type=3}---[120]�Ż����Ŀ�[Ů]
		staticrecipe[650]={recipe_id=1020,recipe_group=0,recipe_level=9,recipe_type=3}---[135]Զ�ͽ�������[��]
		staticrecipe[651]={recipe_id=1021,recipe_group=0,recipe_level=9,recipe_type=3}---[135]Զ�ͽ�������[Ů]
		staticrecipe[652]={recipe_id=3610,recipe_group=0,recipe_level=10,recipe_type=3}---100������ñ���䷽
		staticrecipe[653]={recipe_id=3676,recipe_group=0,recipe_level=10,recipe_type=3}---100������ñŮ�䷽
		staticrecipe[654]={recipe_id=3608,recipe_group=0,recipe_level=8,recipe_type=3}---80������ñ���䷽
		staticrecipe[655]={recipe_id=3674,recipe_group=0,recipe_level=8,recipe_type=3}---80������ñŮ�䷽
		staticrecipe[656]={recipe_id=3609,recipe_group=0,recipe_level=9,recipe_type=3}---90������ñ���䷽
		staticrecipe[657]={recipe_id=3675,recipe_group=0,recipe_level=9,recipe_type=3}---90������ñŮ�䷽
		staticrecipe[658]={recipe_id=3617,recipe_group=0,recipe_level=10,recipe_type=3}---����100������ñ���䷽
		staticrecipe[659]={recipe_id=3683,recipe_group=0,recipe_level=10,recipe_type=3}---����100������ñŮ�䷽
		staticrecipe[660]={recipe_id=3615,recipe_group=0,recipe_level=8,recipe_type=3}---����80������ñ���䷽
		staticrecipe[661]={recipe_id=3681,recipe_group=0,recipe_level=8,recipe_type=3}---����80������ñŮ�䷽
		staticrecipe[662]={recipe_id=3616,recipe_group=0,recipe_level=9,recipe_type=3}---����90������ñ���䷽
		staticrecipe[663]={recipe_id=3682,recipe_group=0,recipe_level=9,recipe_type=3}---����90������ñŮ�䷽
		staticrecipe[664]={recipe_id=3631,recipe_group=0,recipe_level=10,recipe_type=3}---�������װ100������ñ���䷽
		staticrecipe[665]={recipe_id=3697,recipe_group=0,recipe_level=10,recipe_type=3}---�������װ100������ñŮ�䷽
		staticrecipe[666]={recipe_id=3629,recipe_group=0,recipe_level=8,recipe_type=3}---�������װ80������ñ���䷽
		staticrecipe[667]={recipe_id=3695,recipe_group=0,recipe_level=8,recipe_type=3}---�������װ80������ñŮ�䷽
		staticrecipe[668]={recipe_id=3630,recipe_group=0,recipe_level=9,recipe_type=3}---�������װ90������ñ���䷽
		staticrecipe[669]={recipe_id=3696,recipe_group=0,recipe_level=9,recipe_type=3}---�������װ90������ñŮ�䷽
		staticrecipe[670]={recipe_id=3652,recipe_group=0,recipe_level=10,recipe_type=3}---���쿹��װ��100������ñ���䷽
		staticrecipe[671]={recipe_id=3718,recipe_group=0,recipe_level=10,recipe_type=3}---���쿹��װ��100������ñŮ�䷽
		staticrecipe[672]={recipe_id=3650,recipe_group=0,recipe_level=8,recipe_type=3}---���쿹��װ��80������ñ���䷽
		staticrecipe[673]={recipe_id=3716,recipe_group=0,recipe_level=8,recipe_type=3}---���쿹��װ��80������ñŮ�䷽
		staticrecipe[674]={recipe_id=3651,recipe_group=0,recipe_level=9,recipe_type=3}---���쿹��װ��90������ñ���䷽
		staticrecipe[675]={recipe_id=3717,recipe_group=0,recipe_level=9,recipe_type=3}---���쿹��װ��90������ñŮ�䷽
		staticrecipe[676]={recipe_id=3659,recipe_group=0,recipe_level=10,recipe_type=3}---���쿹��װ��100������ñ���䷽
		staticrecipe[677]={recipe_id=3725,recipe_group=0,recipe_level=10,recipe_type=3}---���쿹��װ��100������ñŮ�䷽
		staticrecipe[678]={recipe_id=3657,recipe_group=0,recipe_level=8,recipe_type=3}---���쿹��װ��80������ñ���䷽
		staticrecipe[679]={recipe_id=3723,recipe_group=0,recipe_level=8,recipe_type=3}---���쿹��װ��80������ñŮ�䷽
		staticrecipe[680]={recipe_id=3658,recipe_group=0,recipe_level=9,recipe_type=3}---���쿹��װ��90������ñ���䷽
		staticrecipe[681]={recipe_id=3724,recipe_group=0,recipe_level=9,recipe_type=3}---���쿹��װ��90������ñŮ�䷽
		staticrecipe[682]={recipe_id=3638,recipe_group=0,recipe_level=10,recipe_type=3}---���쿹��װ��100������ñ���䷽
		staticrecipe[683]={recipe_id=3704,recipe_group=0,recipe_level=10,recipe_type=3}---���쿹��װ��100������ñŮ�䷽
		staticrecipe[684]={recipe_id=3636,recipe_group=0,recipe_level=8,recipe_type=3}---���쿹��װ��80������ñ���䷽
		staticrecipe[685]={recipe_id=3702,recipe_group=0,recipe_level=8,recipe_type=3}---���쿹��װ��80������ñŮ�䷽
		staticrecipe[686]={recipe_id=3637,recipe_group=0,recipe_level=9,recipe_type=3}---���쿹��װ��90������ñ���䷽
		staticrecipe[687]={recipe_id=3703,recipe_group=0,recipe_level=9,recipe_type=3}---���쿹��װ��90������ñŮ�䷽
		staticrecipe[688]={recipe_id=3666,recipe_group=0,recipe_level=10,recipe_type=3}---���쿹��װ��100������ñ���䷽
		staticrecipe[689]={recipe_id=3732,recipe_group=0,recipe_level=10,recipe_type=3}---���쿹��װ��100������ñŮ�䷽
		staticrecipe[690]={recipe_id=3664,recipe_group=0,recipe_level=8,recipe_type=3}---���쿹��װ��80������ñ���䷽
		staticrecipe[691]={recipe_id=3730,recipe_group=0,recipe_level=8,recipe_type=3}---���쿹��װ��80������ñŮ�䷽
		staticrecipe[692]={recipe_id=3665,recipe_group=0,recipe_level=9,recipe_type=3}---���쿹��װ��90������ñ���䷽
		staticrecipe[693]={recipe_id=3731,recipe_group=0,recipe_level=9,recipe_type=3}---���쿹��װ��90������ñŮ�䷽
		staticrecipe[694]={recipe_id=3645,recipe_group=0,recipe_level=10,recipe_type=3}---���쿹��װ��100������ñ���䷽
		staticrecipe[695]={recipe_id=3711,recipe_group=0,recipe_level=10,recipe_type=3}---���쿹��װ��100������ñŮ�䷽
		staticrecipe[696]={recipe_id=3643,recipe_group=0,recipe_level=8,recipe_type=3}---���쿹��װ��80������ñ���䷽
		staticrecipe[697]={recipe_id=3709,recipe_group=0,recipe_level=8,recipe_type=3}---���쿹��װ��80������ñŮ�䷽
		staticrecipe[698]={recipe_id=3644,recipe_group=0,recipe_level=9,recipe_type=3}---���쿹��װ��90������ñ���䷽
		staticrecipe[699]={recipe_id=3710,recipe_group=0,recipe_level=9,recipe_type=3}---���쿹��װ��90������ñŮ�䷽
		staticrecipe[700]={recipe_id=3624,recipe_group=0,recipe_level=10,recipe_type=3}---����ħ��װ100������ñ���䷽
		staticrecipe[701]={recipe_id=3690,recipe_group=0,recipe_level=10,recipe_type=3}---����ħ��װ100������ñŮ�䷽
		staticrecipe[702]={recipe_id=3622,recipe_group=0,recipe_level=8,recipe_type=3}---����ħ��װ80������ñ���䷽
		staticrecipe[703]={recipe_id=3688,recipe_group=0,recipe_level=8,recipe_type=3}---����ħ��װ80������ñŮ�䷽
		staticrecipe[704]={recipe_id=3623,recipe_group=0,recipe_level=9,recipe_type=3}---����ħ��װ90������ñ���䷽
		staticrecipe[705]={recipe_id=3689,recipe_group=0,recipe_level=9,recipe_type=3}---����ħ��װ90������ñŮ�䷽
		staticrecipe[706]={recipe_id=4020,recipe_group=0,recipe_level=10,recipe_type=3}---100����ɽñ���䷽
		staticrecipe[707]={recipe_id=4086,recipe_group=0,recipe_level=10,recipe_type=3}---100����ɽñŮ�䷽
		staticrecipe[708]={recipe_id=4018,recipe_group=0,recipe_level=8,recipe_type=3}---80����ɽñ���䷽
		staticrecipe[709]={recipe_id=4084,recipe_group=0,recipe_level=8,recipe_type=3}---80����ɽñŮ�䷽
		staticrecipe[710]={recipe_id=4019,recipe_group=0,recipe_level=9,recipe_type=3}---90����ɽñ���䷽
		staticrecipe[711]={recipe_id=4085,recipe_group=0,recipe_level=9,recipe_type=3}---90����ɽñŮ�䷽
		staticrecipe[712]={recipe_id=4027,recipe_group=0,recipe_level=10,recipe_type=3}---����100����ɽñ���䷽
		staticrecipe[713]={recipe_id=4093,recipe_group=0,recipe_level=10,recipe_type=3}---����100����ɽñŮ�䷽
		staticrecipe[714]={recipe_id=4025,recipe_group=0,recipe_level=8,recipe_type=3}---����80����ɽñ���䷽
		staticrecipe[715]={recipe_id=4091,recipe_group=0,recipe_level=8,recipe_type=3}---����80����ɽñŮ�䷽
		staticrecipe[716]={recipe_id=4026,recipe_group=0,recipe_level=9,recipe_type=3}---����90����ɽñ���䷽
		staticrecipe[717]={recipe_id=4092,recipe_group=0,recipe_level=9,recipe_type=3}---����90����ɽñŮ�䷽
		staticrecipe[718]={recipe_id=4041,recipe_group=0,recipe_level=10,recipe_type=3}---�������װ100����ɽñ���䷽
		staticrecipe[719]={recipe_id=4107,recipe_group=0,recipe_level=10,recipe_type=3}---�������װ100����ɽñŮ�䷽
		staticrecipe[720]={recipe_id=4039,recipe_group=0,recipe_level=8,recipe_type=3}---�������װ80����ɽñ���䷽
		staticrecipe[721]={recipe_id=4105,recipe_group=0,recipe_level=8,recipe_type=3}---�������װ80����ɽñŮ�䷽
		staticrecipe[722]={recipe_id=4040,recipe_group=0,recipe_level=9,recipe_type=3}---�������װ90����ɽñ���䷽
		staticrecipe[723]={recipe_id=4106,recipe_group=0,recipe_level=9,recipe_type=3}---�������װ90����ɽñŮ�䷽
		staticrecipe[724]={recipe_id=4062,recipe_group=0,recipe_level=10,recipe_type=3}---���쿹��װ��100����ɽñ���䷽
		staticrecipe[725]={recipe_id=4128,recipe_group=0,recipe_level=10,recipe_type=3}---���쿹��װ��100����ɽñŮ�䷽
		staticrecipe[726]={recipe_id=4060,recipe_group=0,recipe_level=8,recipe_type=3}---���쿹��װ��80����ɽñ���䷽
		staticrecipe[727]={recipe_id=4126,recipe_group=0,recipe_level=8,recipe_type=3}---���쿹��װ��80����ɽñŮ�䷽
		staticrecipe[728]={recipe_id=4061,recipe_group=0,recipe_level=9,recipe_type=3}---���쿹��װ��90����ɽñ���䷽
		staticrecipe[729]={recipe_id=4127,recipe_group=0,recipe_level=9,recipe_type=3}---���쿹��װ��90����ɽñŮ�䷽
		staticrecipe[730]={recipe_id=4069,recipe_group=0,recipe_level=10,recipe_type=3}---���쿹��װ��100����ɽñ���䷽
		staticrecipe[731]={recipe_id=4135,recipe_group=0,recipe_level=10,recipe_type=3}---���쿹��װ��100����ɽñŮ�䷽
		staticrecipe[732]={recipe_id=4067,recipe_group=0,recipe_level=8,recipe_type=3}---���쿹��װ��80����ɽñ���䷽
		staticrecipe[733]={recipe_id=4133,recipe_group=0,recipe_level=8,recipe_type=3}---���쿹��װ��80����ɽñŮ�䷽
		staticrecipe[734]={recipe_id=4068,recipe_group=0,recipe_level=9,recipe_type=3}---���쿹��װ��90����ɽñ���䷽
		staticrecipe[735]={recipe_id=4134,recipe_group=0,recipe_level=9,recipe_type=3}---���쿹��װ��90����ɽñŮ�䷽
		staticrecipe[736]={recipe_id=4048,recipe_group=0,recipe_level=10,recipe_type=3}---���쿹��װ��100����ɽñ���䷽
		staticrecipe[737]={recipe_id=4114,recipe_group=0,recipe_level=10,recipe_type=3}---���쿹��װ��100����ɽñŮ�䷽
		staticrecipe[738]={recipe_id=4046,recipe_group=0,recipe_level=8,recipe_type=3}---���쿹��װ��80����ɽñ���䷽
		staticrecipe[739]={recipe_id=4112,recipe_group=0,recipe_level=8,recipe_type=3}---���쿹��װ��80����ɽñŮ�䷽
		staticrecipe[740]={recipe_id=4047,recipe_group=0,recipe_level=9,recipe_type=3}---���쿹��װ��90����ɽñ���䷽
		staticrecipe[741]={recipe_id=4113,recipe_group=0,recipe_level=9,recipe_type=3}---���쿹��װ��90����ɽñŮ�䷽
		staticrecipe[742]={recipe_id=4076,recipe_group=0,recipe_level=10,recipe_type=3}---���쿹��װ��100����ɽñ���䷽
		staticrecipe[743]={recipe_id=4142,recipe_group=0,recipe_level=10,recipe_type=3}---���쿹��װ��100����ɽñŮ�䷽
		staticrecipe[744]={recipe_id=4074,recipe_group=0,recipe_level=8,recipe_type=3}---���쿹��װ��80����ɽñ���䷽
		staticrecipe[745]={recipe_id=4140,recipe_group=0,recipe_level=8,recipe_type=3}---���쿹��װ��80����ɽñŮ�䷽
		staticrecipe[746]={recipe_id=4075,recipe_group=0,recipe_level=9,recipe_type=3}---���쿹��װ��90����ɽñ���䷽
		staticrecipe[747]={recipe_id=4141,recipe_group=0,recipe_level=9,recipe_type=3}---���쿹��װ��90����ɽñŮ�䷽
		staticrecipe[748]={recipe_id=4055,recipe_group=0,recipe_level=10,recipe_type=3}---���쿹��װ��100����ɽñ���䷽
		staticrecipe[749]={recipe_id=4121,recipe_group=0,recipe_level=10,recipe_type=3}---���쿹��װ��100����ɽñŮ�䷽
		staticrecipe[750]={recipe_id=4053,recipe_group=0,recipe_level=8,recipe_type=3}---���쿹��װ��80����ɽñ���䷽
		staticrecipe[751]={recipe_id=4119,recipe_group=0,recipe_level=8,recipe_type=3}---���쿹��װ��80����ɽñŮ�䷽
		staticrecipe[752]={recipe_id=4054,recipe_group=0,recipe_level=9,recipe_type=3}---���쿹��װ��90����ɽñ���䷽
		staticrecipe[753]={recipe_id=4120,recipe_group=0,recipe_level=9,recipe_type=3}---���쿹��װ��90����ɽñŮ�䷽
		staticrecipe[754]={recipe_id=4034,recipe_group=0,recipe_level=10,recipe_type=3}---����ħ��װ100����ɽñ���䷽
		staticrecipe[755]={recipe_id=4100,recipe_group=0,recipe_level=10,recipe_type=3}---����ħ��װ100����ɽñŮ�䷽
		staticrecipe[756]={recipe_id=4032,recipe_group=0,recipe_level=8,recipe_type=3}---����ħ��װ80����ɽñ���䷽
		staticrecipe[757]={recipe_id=4098,recipe_group=0,recipe_level=8,recipe_type=3}---����ħ��װ80����ɽñŮ�䷽
		staticrecipe[758]={recipe_id=4033,recipe_group=0,recipe_level=9,recipe_type=3}---����ħ��װ90����ɽñ���䷽
		staticrecipe[759]={recipe_id=4099,recipe_group=0,recipe_level=9,recipe_type=3}---����ħ��װ90����ɽñŮ�䷽
		staticrecipe[760]={recipe_id=259,recipe_group=0,recipe_level=10,recipe_type=3}---[142]�����[��]
		staticrecipe[761]={recipe_id=307,recipe_group=0,recipe_level=10,recipe_type=3}---[142]�����[Ů]
		staticrecipe[762]={recipe_id=257,recipe_group=0,recipe_level=8,recipe_type=3}---[120]̫���[��]
		staticrecipe[763]={recipe_id=305,recipe_group=0,recipe_level=8,recipe_type=3}---[120]̫���[Ů]
		staticrecipe[764]={recipe_id=258,recipe_group=0,recipe_level=9,recipe_type=3}---[135]�����[��]
		staticrecipe[765]={recipe_id=306,recipe_group=0,recipe_level=9,recipe_type=3}---[135]�����[Ů]
		staticrecipe[766]={recipe_id=1086,recipe_group=0,recipe_level=10,recipe_type=3}---[142]��������Ԫ��[��]
		staticrecipe[767]={recipe_id=1087,recipe_group=0,recipe_level=10,recipe_type=3}---[142]��������Ԫ��[Ů]
		staticrecipe[768]={recipe_id=1090,recipe_group=0,recipe_level=8,recipe_type=3}---[120]����֤����[��]
		staticrecipe[769]={recipe_id=1091,recipe_group=0,recipe_level=8,recipe_type=3}---[120]����֤����[Ů]
		staticrecipe[770]={recipe_id=1092,recipe_group=0,recipe_level=9,recipe_type=3}---[135]������������[��]
		staticrecipe[771]={recipe_id=1093,recipe_group=0,recipe_level=9,recipe_type=3}---[135]������������[Ů]
		staticrecipe[772]={recipe_id=1094,recipe_group=0,recipe_level=10,recipe_type=3}---[142]�����ݷ������[��]
		staticrecipe[773]={recipe_id=1095,recipe_group=0,recipe_level=10,recipe_type=3}---[142]�����ݷ������[Ů]
		staticrecipe[774]={recipe_id=1098,recipe_group=0,recipe_level=8,recipe_type=3}---[120]��سռ����[��]
		staticrecipe[775]={recipe_id=1099,recipe_group=0,recipe_level=8,recipe_type=3}---[120]��سռ����[Ů]
		staticrecipe[776]={recipe_id=1100,recipe_group=0,recipe_level=9,recipe_type=3}---[135]�����ɲ�����[��]
		staticrecipe[777]={recipe_id=1101,recipe_group=0,recipe_level=9,recipe_type=3}---[135]�����ɲ�����[Ů]
		staticrecipe[778]={recipe_id=1102,recipe_group=0,recipe_level=10,recipe_type=3}---[142]�߷�������ع�[��]
		staticrecipe[779]={recipe_id=1103,recipe_group=0,recipe_level=10,recipe_type=3}---[142]�߷�������ع�[Ů]
		staticrecipe[780]={recipe_id=1106,recipe_group=0,recipe_level=8,recipe_type=3}---[120]����פ���[��]
		staticrecipe[781]={recipe_id=1107,recipe_group=0,recipe_level=8,recipe_type=3}---[120]����פ���[Ů]
		staticrecipe[782]={recipe_id=1108,recipe_group=0,recipe_level=9,recipe_type=3}---[135]�����Ǿ���Ԫ��[��]
		staticrecipe[783]={recipe_id=1109,recipe_group=0,recipe_level=9,recipe_type=3}---[135]�����Ǿ���Ԫ��[Ů]
		staticrecipe[784]={recipe_id=1110,recipe_group=0,recipe_level=10,recipe_type=3}---[142]��ʥ���������[��]
		staticrecipe[785]={recipe_id=1111,recipe_group=0,recipe_level=10,recipe_type=3}---[142]��ʥ���������[Ů]
		staticrecipe[786]={recipe_id=1114,recipe_group=0,recipe_level=8,recipe_type=3}---[120]�ĺ�������[��]
		staticrecipe[787]={recipe_id=1115,recipe_group=0,recipe_level=8,recipe_type=3}---[120]�ĺ�������[Ů]
		staticrecipe[788]={recipe_id=1116,recipe_group=0,recipe_level=9,recipe_type=3}---[135]�񶦽ᵤ��ʥ��[��]
		staticrecipe[789]={recipe_id=1117,recipe_group=0,recipe_level=9,recipe_type=3}---[135]�񶦽ᵤ��ʥ��[Ů]
		staticrecipe[790]={recipe_id=1118,recipe_group=0,recipe_level=10,recipe_type=3}---[142]���Ž������Ĺ�[��]
		staticrecipe[791]={recipe_id=1119,recipe_group=0,recipe_level=10,recipe_type=3}---[142]���Ž������Ĺ�[Ů]
		staticrecipe[792]={recipe_id=1122,recipe_group=0,recipe_level=8,recipe_type=3}---[120]�˼�������[��]
		staticrecipe[793]={recipe_id=1123,recipe_group=0,recipe_level=8,recipe_type=3}---[120]�˼�������[Ů]
		staticrecipe[794]={recipe_id=1124,recipe_group=0,recipe_level=9,recipe_type=3}---[135]�ط�ͨ����ڤ��[��]
		staticrecipe[795]={recipe_id=1125,recipe_group=0,recipe_level=9,recipe_type=3}---[135]�ط�ͨ����ڤ��[Ů]
		staticrecipe[796]={recipe_id=1126,recipe_group=0,recipe_level=10,recipe_type=3}---[142]���گ��������[��]
		staticrecipe[797]={recipe_id=1127,recipe_group=0,recipe_level=10,recipe_type=3}---[142]���گ��������[Ů]
		staticrecipe[798]={recipe_id=1130,recipe_group=0,recipe_level=8,recipe_type=3}---[120]��Ԫ�����[��]
		staticrecipe[799]={recipe_id=1131,recipe_group=0,recipe_level=8,recipe_type=3}---[120]��Ԫ�����[Ů]
		staticrecipe[800]={recipe_id=1132,recipe_group=0,recipe_level=9,recipe_type=3}---[135]�������յ��Ĺ�[��]
		staticrecipe[801]={recipe_id=1133,recipe_group=0,recipe_level=9,recipe_type=3}---[135]�������յ��Ĺ�[Ů]
		staticrecipe[802]={recipe_id=1134,recipe_group=0,recipe_level=10,recipe_type=3}---[142]��ɲ���׺ƹ��[��]
		staticrecipe[803]={recipe_id=1135,recipe_group=0,recipe_level=10,recipe_type=3}---[142]��ɲ���׺ƹ��[Ů]
		staticrecipe[804]={recipe_id=1138,recipe_group=0,recipe_level=8,recipe_type=3}---[120]��Ӣ��Ԫ��[��]
		staticrecipe[805]={recipe_id=1139,recipe_group=0,recipe_level=8,recipe_type=3}---[120]��Ӣ��Ԫ��[Ů]
		staticrecipe[806]={recipe_id=1140,recipe_group=0,recipe_level=9,recipe_type=3}---[135]��Ԫ�����ֽ��[��]
		staticrecipe[807]={recipe_id=1141,recipe_group=0,recipe_level=9,recipe_type=3}---[135]��Ԫ�����ֽ��[Ů]
		staticrecipe[808]={recipe_id=1078,recipe_group=0,recipe_level=10,recipe_type=3}---[142]�ž�������ŭ��[��]
		staticrecipe[809]={recipe_id=1079,recipe_group=0,recipe_level=10,recipe_type=3}---[142]�ž�������ŭ��[Ů]
		staticrecipe[810]={recipe_id=1082,recipe_group=0,recipe_level=8,recipe_type=3}---[120]�������ɹ�[��]
		staticrecipe[811]={recipe_id=1083,recipe_group=0,recipe_level=8,recipe_type=3}---[120]�������ɹ�[Ů]
		staticrecipe[812]={recipe_id=1084,recipe_group=0,recipe_level=9,recipe_type=3}---[135]������ٽ��޹�[��]
		staticrecipe[813]={recipe_id=1085,recipe_group=0,recipe_level=9,recipe_type=3}---[135]������ٽ��޹�[Ů]
		staticrecipe[814]={recipe_id=263,recipe_group=0,recipe_level=10,recipe_type=3}---[142]�����[��]
		staticrecipe[815]={recipe_id=311,recipe_group=0,recipe_level=10,recipe_type=3}---[142]�����[Ů]
		staticrecipe[816]={recipe_id=261,recipe_group=0,recipe_level=8,recipe_type=3}---[120]�����[��]
		staticrecipe[817]={recipe_id=309,recipe_group=0,recipe_level=8,recipe_type=3}---[120]�����[Ů]
		staticrecipe[818]={recipe_id=262,recipe_group=0,recipe_level=9,recipe_type=3}---[135]�����[��]
		staticrecipe[819]={recipe_id=310,recipe_group=0,recipe_level=9,recipe_type=3}---[135]�����[Ů]
		staticrecipe[820]={recipe_id=1150,recipe_group=0,recipe_level=10,recipe_type=3}---[142]�������������[��]
		staticrecipe[821]={recipe_id=1151,recipe_group=0,recipe_level=10,recipe_type=3}---[142]�������������[Ů]
		staticrecipe[822]={recipe_id=1154,recipe_group=0,recipe_level=8,recipe_type=3}---[120]��������[��]
		staticrecipe[823]={recipe_id=1155,recipe_group=0,recipe_level=8,recipe_type=3}---[120]��������[Ů]
		staticrecipe[824]={recipe_id=1156,recipe_group=0,recipe_level=9,recipe_type=3}---[135]��¬ɳ�����߹�[��]
		staticrecipe[825]={recipe_id=1157,recipe_group=0,recipe_level=9,recipe_type=3}---[135]��¬ɳ�����߹�[Ů]
		staticrecipe[826]={recipe_id=1158,recipe_group=0,recipe_level=10,recipe_type=3}---[142]�����������¹�[��]
		staticrecipe[827]={recipe_id=1159,recipe_group=0,recipe_level=10,recipe_type=3}---[142]�����������¹�[Ů]
		staticrecipe[828]={recipe_id=1162,recipe_group=0,recipe_level=8,recipe_type=3}---[120]���������[��]
		staticrecipe[829]={recipe_id=1163,recipe_group=0,recipe_level=8,recipe_type=3}---[120]���������[Ů]
		staticrecipe[830]={recipe_id=1164,recipe_group=0,recipe_level=9,recipe_type=3}---[135]��ҵ�޾�٤����[��]
		staticrecipe[831]={recipe_id=1165,recipe_group=0,recipe_level=9,recipe_type=3}---[135]��ҵ�޾�٤����[Ů]
		staticrecipe[832]={recipe_id=1166,recipe_group=0,recipe_level=10,recipe_type=3}---[142]�߽��ֻؼ����[��]
		staticrecipe[833]={recipe_id=1167,recipe_group=0,recipe_level=10,recipe_type=3}---[142]�߽��ֻؼ����[Ů]
		staticrecipe[834]={recipe_id=1170,recipe_group=0,recipe_level=8,recipe_type=3}---[120]�߷�������[��]
		staticrecipe[835]={recipe_id=1171,recipe_group=0,recipe_level=8,recipe_type=3}---[120]�߷�������[Ů]
		staticrecipe[836]={recipe_id=1172,recipe_group=0,recipe_level=9,recipe_type=3}---[135]�������д�ʿ��[��]
		staticrecipe[837]={recipe_id=1173,recipe_group=0,recipe_level=9,recipe_type=3}---[135]�������д�ʿ��[Ů]
		staticrecipe[838]={recipe_id=1174,recipe_group=0,recipe_level=10,recipe_type=3}---[142]������η������[��]
		staticrecipe[839]={recipe_id=1175,recipe_group=0,recipe_level=10,recipe_type=3}---[142]������η������[Ů]
		staticrecipe[840]={recipe_id=1178,recipe_group=0,recipe_level=8,recipe_type=3}---[120]�ĳ�ͨ���[��]
		staticrecipe[841]={recipe_id=1179,recipe_group=0,recipe_level=8,recipe_type=3}---[120]�ĳ�ͨ���[Ů]
		staticrecipe[842]={recipe_id=1180,recipe_group=0,recipe_level=9,recipe_type=3}---[135]���������޺���[��]
		staticrecipe[843]={recipe_id=1181,recipe_group=0,recipe_level=9,recipe_type=3}---[135]���������޺���[Ů]
		staticrecipe[844]={recipe_id=1182,recipe_group=0,recipe_level=10,recipe_type=3}---[142]����Ԫ�徻���[��]
		staticrecipe[845]={recipe_id=1183,recipe_group=0,recipe_level=10,recipe_type=3}---[142]����Ԫ�徻���[Ů]
		staticrecipe[846]={recipe_id=1186,recipe_group=0,recipe_level=8,recipe_type=3}---[120]�˵����Ĺ�[��]
		staticrecipe[847]={recipe_id=1187,recipe_group=0,recipe_level=8,recipe_type=3}---[120]�˵����Ĺ�[Ů]
		staticrecipe[848]={recipe_id=1188,recipe_group=0,recipe_level=9,recipe_type=3}---[135]�����޳���ʦ��[��]
		staticrecipe[849]={recipe_id=1189,recipe_group=0,recipe_level=9,recipe_type=3}---[135]�����޳���ʦ��[Ů]
		staticrecipe[850]={recipe_id=1190,recipe_group=0,recipe_level=10,recipe_type=3}---[142]���Ƕ���������[��]
		staticrecipe[851]={recipe_id=1191,recipe_group=0,recipe_level=10,recipe_type=3}---[142]���Ƕ���������[Ů]
		staticrecipe[852]={recipe_id=1194,recipe_group=0,recipe_level=8,recipe_type=3}---[120]������ҵ��[��]
		staticrecipe[853]={recipe_id=1195,recipe_group=0,recipe_level=8,recipe_type=3}---[120]������ҵ��[Ů]
		staticrecipe[854]={recipe_id=1196,recipe_group=0,recipe_level=9,recipe_type=3}---[135]��ͨ��פ��չ�[��]
		staticrecipe[855]={recipe_id=1197,recipe_group=0,recipe_level=9,recipe_type=3}---[135]��ͨ��פ��չ�[Ů]
		staticrecipe[856]={recipe_id=1198,recipe_group=0,recipe_level=10,recipe_type=3}---[142]ʮ�����������[��]
		staticrecipe[857]={recipe_id=1199,recipe_group=0,recipe_level=10,recipe_type=3}---[142]ʮ�����������[Ů]
		staticrecipe[858]={recipe_id=1202,recipe_group=0,recipe_level=8,recipe_type=3}---[120]����Ⱥ���[��]
		staticrecipe[859]={recipe_id=1203,recipe_group=0,recipe_level=8,recipe_type=3}---[120]����Ⱥ���[Ů]
		staticrecipe[860]={recipe_id=1204,recipe_group=0,recipe_level=9,recipe_type=3}---[135]Ħڭɲ�������[��]
		staticrecipe[861]={recipe_id=1205,recipe_group=0,recipe_level=9,recipe_type=3}---[135]Ħڭɲ�������[Ů]
		staticrecipe[862]={recipe_id=1142,recipe_group=0,recipe_level=10,recipe_type=3}---[142]�ŵ����޵زع�[��]
		staticrecipe[863]={recipe_id=1143,recipe_group=0,recipe_level=10,recipe_type=3}---[142]�ŵ����޵زع�[Ů]
		staticrecipe[864]={recipe_id=1146,recipe_group=0,recipe_level=8,recipe_type=3}---[120]�����Ϲ�[��]
		staticrecipe[865]={recipe_id=1147,recipe_group=0,recipe_level=8,recipe_type=3}---[120]�����Ϲ�[Ů]
		staticrecipe[866]={recipe_id=1148,recipe_group=0,recipe_level=9,recipe_type=3}---[135]��ɽ��������[��]
		staticrecipe[867]={recipe_id=1149,recipe_group=0,recipe_level=9,recipe_type=3}---[135]��ɽ��������[Ů]
		staticrecipe[868]={recipe_id=3113,recipe_group=0,recipe_level=5,recipe_type=5}---�컯֮��ѭ
		staticrecipe[869]={recipe_id=3114,recipe_group=0,recipe_level=5,recipe_type=5}---�컯֮����
		staticrecipe[870]={recipe_id=3116,recipe_group=0,recipe_level=5,recipe_type=5}---�컯֮���
		staticrecipe[871]={recipe_id=3115,recipe_group=0,recipe_level=5,recipe_type=5}---�컯֮����
		staticrecipe[872]={recipe_id=3117,recipe_group=0,recipe_level=5,recipe_type=5}---�컯֮����
		staticrecipe[873]={recipe_id=3118,recipe_group=0,recipe_level=5,recipe_type=5}---�컯֮���
		staticrecipe[874]={recipe_id=1929,recipe_group=0,recipe_level=10,recipe_type=1}---[148]ħ��ָ
		staticrecipe[875]={recipe_id=1927,recipe_group=0,recipe_level=8,recipe_type=1}---[120]ħ����
		staticrecipe[876]={recipe_id=1928,recipe_group=0,recipe_level=9,recipe_type=1}---[135]������
		staticrecipe[877]={recipe_id=235,recipe_group=0,recipe_level=10,recipe_type=1}---[148]������
		staticrecipe[878]={recipe_id=233,recipe_group=0,recipe_level=8,recipe_type=1}---[120]������
		staticrecipe[879]={recipe_id=234,recipe_group=0,recipe_level=9,recipe_type=1}---[135]¾����
		staticrecipe[880]={recipe_id=239,recipe_group=0,recipe_level=10,recipe_type=1}---[148]���컷
		staticrecipe[881]={recipe_id=237,recipe_group=0,recipe_level=8,recipe_type=1}---[120]��껷
		staticrecipe[882]={recipe_id=238,recipe_group=0,recipe_level=9,recipe_type=1}---[135]������
		staticrecipe[883]={recipe_id=3599,recipe_group=0,recipe_level=10,recipe_type=1}---100�����������䷽
		staticrecipe[884]={recipe_id=3597,recipe_group=0,recipe_level=8,recipe_type=1}---80�����������䷽
		staticrecipe[885]={recipe_id=3598,recipe_group=0,recipe_level=9,recipe_type=1}---90�����������䷽
		staticrecipe[886]={recipe_id=4010,recipe_group=0,recipe_level=10,recipe_type=1}---100����ɽ�����䷽
		staticrecipe[887]={recipe_id=4008,recipe_group=0,recipe_level=8,recipe_type=1}---80����ɽ�����䷽
		staticrecipe[888]={recipe_id=4009,recipe_group=0,recipe_level=9,recipe_type=1}---90����ɽ�����䷽
		staticrecipe[889]={recipe_id=243,recipe_group=0,recipe_level=10,recipe_type=1}---[148]����
		staticrecipe[890]={recipe_id=241,recipe_group=0,recipe_level=8,recipe_type=1}---[120]Ǭ����
		staticrecipe[891]={recipe_id=242,recipe_group=0,recipe_level=9,recipe_type=1}---[135]��Ԫ��
		staticrecipe[892]={recipe_id=247,recipe_group=0,recipe_level=10,recipe_type=1}---[148]������
		staticrecipe[893]={recipe_id=245,recipe_group=0,recipe_level=8,recipe_type=1}---[120]������
		staticrecipe[894]={recipe_id=246,recipe_group=0,recipe_level=9,recipe_type=1}---[135]��Ħ��
		staticrecipe[895]={recipe_id=2071,recipe_group=0,recipe_level=10,recipe_type=4}---[144]�ز�ѥ[��]
		staticrecipe[896]={recipe_id=2137,recipe_group=0,recipe_level=10,recipe_type=4}---[144]�ز�ѥ[Ů]
		staticrecipe[897]={recipe_id=2069,recipe_group=0,recipe_level=8,recipe_type=4}---[120]ڤ��ѥ[��]
		staticrecipe[898]={recipe_id=2135,recipe_group=0,recipe_level=8,recipe_type=4}---[120]ڤ��ѥ[Ů]
		staticrecipe[899]={recipe_id=2070,recipe_group=0,recipe_level=9,recipe_type=4}---[135]����ѥ[��]
		staticrecipe[900]={recipe_id=2136,recipe_group=0,recipe_level=9,recipe_type=4}---[135]����ѥ[Ů]
		staticrecipe[901]={recipe_id=2078,recipe_group=0,recipe_level=10,recipe_type=4}---[144]�ŵ�ڤ������ѥ[��]
		staticrecipe[902]={recipe_id=2144,recipe_group=0,recipe_level=10,recipe_type=4}---[144]�ŵ�ڤ������ѥ[Ů]
		staticrecipe[903]={recipe_id=2076,recipe_group=0,recipe_level=8,recipe_type=4}---[120]���׶���ѥ[��]
		staticrecipe[904]={recipe_id=2142,recipe_group=0,recipe_level=8,recipe_type=4}---[120]���׶���ѥ[Ů]
		staticrecipe[905]={recipe_id=2077,recipe_group=0,recipe_level=9,recipe_type=4}---[135]ս�����ħ��ѥ[��]
		staticrecipe[906]={recipe_id=2143,recipe_group=0,recipe_level=9,recipe_type=4}---[135]ս�����ħ��ѥ[Ů]
		staticrecipe[907]={recipe_id=2092,recipe_group=0,recipe_level=10,recipe_type=4}---[144]��������ѥ[��]
		staticrecipe[908]={recipe_id=2158,recipe_group=0,recipe_level=10,recipe_type=4}---[144]��������ѥ[Ů]
		staticrecipe[909]={recipe_id=2090,recipe_group=0,recipe_level=8,recipe_type=4}---[120]���Ź���ѥ[��]
		staticrecipe[910]={recipe_id=2156,recipe_group=0,recipe_level=8,recipe_type=4}---[120]���Ź���ѥ[Ů]
		staticrecipe[911]={recipe_id=2091,recipe_group=0,recipe_level=9,recipe_type=4}---[135]�ķع�ڣ����ѥ[��]
		staticrecipe[912]={recipe_id=2157,recipe_group=0,recipe_level=9,recipe_type=4}---[135]�ķع�ڣ����ѥ[Ů]
		staticrecipe[913]={recipe_id=2113,recipe_group=0,recipe_level=10,recipe_type=4}---[144]�����ֻ�ħ��ѥ[��]
		staticrecipe[914]={recipe_id=2179,recipe_group=0,recipe_level=10,recipe_type=4}---[144]�����ֻ�ħ��ѥ[Ů]
		staticrecipe[915]={recipe_id=2111,recipe_group=0,recipe_level=8,recipe_type=4}---[120]��Ԧ����ѥ[��]
		staticrecipe[916]={recipe_id=2177,recipe_group=0,recipe_level=8,recipe_type=4}---[120]��Ԧ����ѥ[Ů]
		staticrecipe[917]={recipe_id=2112,recipe_group=0,recipe_level=9,recipe_type=4}---[135]ڤ�Ӷ���ϴ��ѥ[��]
		staticrecipe[918]={recipe_id=2178,recipe_group=0,recipe_level=9,recipe_type=4}---[135]ڤ�Ӷ���ϴ��ѥ[Ů]
		staticrecipe[919]={recipe_id=2120,recipe_group=0,recipe_level=10,recipe_type=4}---[144]�߽���������ѥ[��]
		staticrecipe[920]={recipe_id=2186,recipe_group=0,recipe_level=10,recipe_type=4}---[144]�߽���������ѥ[Ů]
		staticrecipe[921]={recipe_id=2118,recipe_group=0,recipe_level=8,recipe_type=4}---[120]�߿׾ۻ�ѥ[��]
		staticrecipe[922]={recipe_id=2184,recipe_group=0,recipe_level=8,recipe_type=4}---[120]�߿׾ۻ�ѥ[Ů]
		staticrecipe[923]={recipe_id=2119,recipe_group=0,recipe_level=9,recipe_type=4}---[135]Ѫ���𲨵��ѥ[��]
		staticrecipe[924]={recipe_id=2185,recipe_group=0,recipe_level=9,recipe_type=4}---[135]Ѫ���𲨵��ѥ[Ů]
		staticrecipe[925]={recipe_id=2099,recipe_group=0,recipe_level=10,recipe_type=4}---[144]����Ԫ��ڤѥ[��]
		staticrecipe[926]={recipe_id=2165,recipe_group=0,recipe_level=10,recipe_type=4}---[144]����Ԫ��ڤѥ[Ů]
		staticrecipe[927]={recipe_id=2097,recipe_group=0,recipe_level=8,recipe_type=4}---[120]��Χ��ڤѥ[��]
		staticrecipe[928]={recipe_id=2163,recipe_group=0,recipe_level=8,recipe_type=4}---[120]��Χ��ڤѥ[Ů]
		staticrecipe[929]={recipe_id=2098,recipe_group=0,recipe_level=9,recipe_type=4}---[135]������ڤѥ[��]
		staticrecipe[930]={recipe_id=2164,recipe_group=0,recipe_level=9,recipe_type=4}---[135]������ڤѥ[Ů]
		staticrecipe[931]={recipe_id=2127,recipe_group=0,recipe_level=10,recipe_type=4}---[144]����������ħѥ[��]
		staticrecipe[932]={recipe_id=2193,recipe_group=0,recipe_level=10,recipe_type=4}---[144]����������ħѥ[Ů]
		staticrecipe[933]={recipe_id=2125,recipe_group=0,recipe_level=8,recipe_type=4}---[120]���Ž���ѥ[��]
		staticrecipe[934]={recipe_id=2191,recipe_group=0,recipe_level=8,recipe_type=4}---[120]���Ž���ѥ[Ů]
		staticrecipe[935]={recipe_id=2126,recipe_group=0,recipe_level=9,recipe_type=4}---[135]��Ӱ�ƶ�����ѥ[��]
		staticrecipe[936]={recipe_id=2192,recipe_group=0,recipe_level=9,recipe_type=4}---[135]��Ӱ�ƶ�����ѥ[Ů]
		staticrecipe[937]={recipe_id=2106,recipe_group=0,recipe_level=10,recipe_type=4}---[144]�������ڳ���ѥ[��]
		staticrecipe[938]={recipe_id=2172,recipe_group=0,recipe_level=10,recipe_type=4}---[144]�������ڳ���ѥ[Ů]
		staticrecipe[939]={recipe_id=2104,recipe_group=0,recipe_level=8,recipe_type=4}---[120]���о���ѥ[��]
		staticrecipe[940]={recipe_id=2170,recipe_group=0,recipe_level=8,recipe_type=4}---[120]���о���ѥ[Ů]
		staticrecipe[941]={recipe_id=2105,recipe_group=0,recipe_level=9,recipe_type=4}---[135]����ܳ�����ѥ[��]
		staticrecipe[942]={recipe_id=2171,recipe_group=0,recipe_level=9,recipe_type=4}---[135]����ܳ�����ѥ[Ů]
		staticrecipe[943]={recipe_id=2085,recipe_group=0,recipe_level=10,recipe_type=4}---[144]������������ѥ[��]
		staticrecipe[944]={recipe_id=2151,recipe_group=0,recipe_level=10,recipe_type=4}---[144]������������ѥ[Ů]
		staticrecipe[945]={recipe_id=2083,recipe_group=0,recipe_level=8,recipe_type=4}---[120]�Ź�����ѥ[��]
		staticrecipe[946]={recipe_id=2149,recipe_group=0,recipe_level=8,recipe_type=4}---[120]�Ź�����ѥ[Ů]
		staticrecipe[947]={recipe_id=2084,recipe_group=0,recipe_level=9,recipe_type=4}---[135]��ڤת�����ѥ[��]
		staticrecipe[948]={recipe_id=2150,recipe_group=0,recipe_level=9,recipe_type=4}---[135]��ڤת�����ѥ[Ů]
		staticrecipe[949]={recipe_id=283,recipe_group=0,recipe_level=10,recipe_type=4}---[144]�ʼ�ѥ[��]
		staticrecipe[950]={recipe_id=331,recipe_group=0,recipe_level=10,recipe_type=4}---[144]�ʼ�ѥ[Ů]
		staticrecipe[951]={recipe_id=281,recipe_group=0,recipe_level=8,recipe_type=4}---[120]����ѥ[��]
		staticrecipe[952]={recipe_id=329,recipe_group=0,recipe_level=8,recipe_type=4}---[120]����ѥ[Ů]
		staticrecipe[953]={recipe_id=282,recipe_group=0,recipe_level=9,recipe_type=4}---[135]����ѥ[��]
		staticrecipe[954]={recipe_id=330,recipe_group=0,recipe_level=9,recipe_type=4}---[135]����ѥ[Ů]
		staticrecipe[955]={recipe_id=1214,recipe_group=0,recipe_level=10,recipe_type=4}---[144]�������а��ѥ[��]
		staticrecipe[956]={recipe_id=1215,recipe_group=0,recipe_level=10,recipe_type=4}---[144]�������а��ѥ[Ů]
		staticrecipe[957]={recipe_id=1218,recipe_group=0,recipe_level=8,recipe_type=4}---[120]������Ѫѥ[��]
		staticrecipe[958]={recipe_id=1219,recipe_group=0,recipe_level=8,recipe_type=4}---[120]������Ѫѥ[Ů]
		staticrecipe[959]={recipe_id=1220,recipe_group=0,recipe_level=9,recipe_type=4}---[135]���������ڽ�ѥ[��]
		staticrecipe[960]={recipe_id=1221,recipe_group=0,recipe_level=9,recipe_type=4}---[135]���������ڽ�ѥ[Ů]
		staticrecipe[961]={recipe_id=1222,recipe_group=0,recipe_level=10,recipe_type=4}---[144]�����ݺ�����ѥ[��]
		staticrecipe[962]={recipe_id=1223,recipe_group=0,recipe_level=10,recipe_type=4}---[144]�����ݺ�����ѥ[Ů]
		staticrecipe[963]={recipe_id=1226,recipe_group=0,recipe_level=8,recipe_type=4}---[120]�����ƾ�ѥ[��]
		staticrecipe[964]={recipe_id=1227,recipe_group=0,recipe_level=8,recipe_type=4}---[120]�����ƾ�ѥ[Ů]
		staticrecipe[965]={recipe_id=1228,recipe_group=0,recipe_level=9,recipe_type=4}---[135]����������Ѫѥ[��]
		staticrecipe[966]={recipe_id=1229,recipe_group=0,recipe_level=9,recipe_type=4}---[135]����������Ѫѥ[Ů]
		staticrecipe[967]={recipe_id=1230,recipe_group=0,recipe_level=10,recipe_type=4}---[144]�߽ݵ�������ѥ[��]
		staticrecipe[968]={recipe_id=1231,recipe_group=0,recipe_level=10,recipe_type=4}---[144]�߽ݵ�������ѥ[Ů]
		staticrecipe[969]={recipe_id=1234,recipe_group=0,recipe_level=8,recipe_type=4}---[120]�����һ�ѥ[��]
		staticrecipe[970]={recipe_id=1235,recipe_group=0,recipe_level=8,recipe_type=4}---[120]�����һ�ѥ[Ů]
		staticrecipe[971]={recipe_id=1236,recipe_group=0,recipe_level=9,recipe_type=4}---[135]���Х����ѥ[��]
		staticrecipe[972]={recipe_id=1237,recipe_group=0,recipe_level=9,recipe_type=4}---[135]���Х����ѥ[Ů]
		staticrecipe[973]={recipe_id=1238,recipe_group=0,recipe_level=10,recipe_type=4}---[144]�ĺ�Х������ѥ[��]
		staticrecipe[974]={recipe_id=1239,recipe_group=0,recipe_level=10,recipe_type=4}---[144]�ĺ�Х������ѥ[Ů]
		staticrecipe[975]={recipe_id=1242,recipe_group=0,recipe_level=8,recipe_type=4}---[120]���ķ���ѥ[��]
		staticrecipe[976]={recipe_id=1243,recipe_group=0,recipe_level=8,recipe_type=4}---[120]���ķ���ѥ[Ů]
		staticrecipe[977]={recipe_id=1244,recipe_group=0,recipe_level=9,recipe_type=4}---[135]������ͷ����ѥ[��]
		staticrecipe[978]={recipe_id=1245,recipe_group=0,recipe_level=9,recipe_type=4}---[135]������ͷ����ѥ[Ů]
		staticrecipe[979]={recipe_id=1246,recipe_group=0,recipe_level=10,recipe_type=4}---[144]�����Ӣ����ѥ[��]
		staticrecipe[980]={recipe_id=1247,recipe_group=0,recipe_level=10,recipe_type=4}---[144]�����Ӣ����ѥ[Ů]
		staticrecipe[981]={recipe_id=1250,recipe_group=0,recipe_level=8,recipe_type=4}---[120]����ŭ��ѥ[��]
		staticrecipe[982]={recipe_id=1251,recipe_group=0,recipe_level=8,recipe_type=4}---[120]����ŭ��ѥ[Ů]
		staticrecipe[983]={recipe_id=1252,recipe_group=0,recipe_level=9,recipe_type=4}---[135]����̫������ѥ[��]
		staticrecipe[984]={recipe_id=1253,recipe_group=0,recipe_level=9,recipe_type=4}---[135]����̫������ѥ[Ů]
		staticrecipe[985]={recipe_id=1254,recipe_group=0,recipe_level=10,recipe_type=4}---[144]��ɷ���ӷ���ѥ[��]
		staticrecipe[986]={recipe_id=1255,recipe_group=0,recipe_level=10,recipe_type=4}---[144]��ɷ���ӷ���ѥ[Ů]
		staticrecipe[987]={recipe_id=1258,recipe_group=0,recipe_level=8,recipe_type=4}---[120]��������ѥ[��]
		staticrecipe[988]={recipe_id=1259,recipe_group=0,recipe_level=8,recipe_type=4}---[120]��������ѥ[Ů]
		staticrecipe[989]={recipe_id=1260,recipe_group=0,recipe_level=9,recipe_type=4}---[135]���ǽ����ƽ�ѥ[��]
		staticrecipe[990]={recipe_id=1261,recipe_group=0,recipe_level=9,recipe_type=4}---[135]���ǽ����ƽ�ѥ[Ů]
		staticrecipe[991]={recipe_id=1262,recipe_group=0,recipe_level=10,recipe_type=4}---[144]����ۺ������ѥ[��]
		staticrecipe[992]={recipe_id=1263,recipe_group=0,recipe_level=10,recipe_type=4}---[144]����ۺ������ѥ[Ů]
		staticrecipe[993]={recipe_id=1266,recipe_group=0,recipe_level=8,recipe_type=4}---[120]���޳���ѥ[��]
		staticrecipe[994]={recipe_id=1267,recipe_group=0,recipe_level=8,recipe_type=4}---[120]���޳���ѥ[Ů]
		staticrecipe[995]={recipe_id=1268,recipe_group=0,recipe_level=9,recipe_type=4}---[135]��������а��ѥ[��]
		staticrecipe[996]={recipe_id=1269,recipe_group=0,recipe_level=9,recipe_type=4}---[135]��������а��ѥ[Ů]
		staticrecipe[997]={recipe_id=1206,recipe_group=0,recipe_level=10,recipe_type=4}---[144]��ħ����ڤ��ѥ[��]
		staticrecipe[998]={recipe_id=1207,recipe_group=0,recipe_level=10,recipe_type=4}---[144]��ħ����ڤ��ѥ[Ů]
		staticrecipe[999]={recipe_id=1210,recipe_group=0,recipe_level=8,recipe_type=4}---[120]��ת����ѥ[��]
		staticrecipe[1000]={recipe_id=1211,recipe_group=0,recipe_level=8,recipe_type=4}---[120]��ת����ѥ[Ů]
		staticrecipe[1001]={recipe_id=1212,recipe_group=0,recipe_level=9,recipe_type=4}---[135]�������˽�ѥ[��]
		staticrecipe[1002]={recipe_id=1213,recipe_group=0,recipe_level=9,recipe_type=4}---[135]�������˽�ѥ[Ů]
		staticrecipe[1003]={recipe_id=287,recipe_group=0,recipe_level=10,recipe_type=4}---[144]����ѥ[��]
		staticrecipe[1004]={recipe_id=335,recipe_group=0,recipe_level=10,recipe_type=4}---[144]����ѥ[Ů]
		staticrecipe[1005]={recipe_id=285,recipe_group=0,recipe_level=8,recipe_type=4}---[120]����ѥ[��]
		staticrecipe[1006]={recipe_id=333,recipe_group=0,recipe_level=8,recipe_type=4}---[120]����ѥ[Ů]
		staticrecipe[1007]={recipe_id=286,recipe_group=0,recipe_level=9,recipe_type=4}---[135]����ѥ[��]
		staticrecipe[1008]={recipe_id=334,recipe_group=0,recipe_level=9,recipe_type=4}---[135]����ѥ[Ů]
		staticrecipe[1009]={recipe_id=1278,recipe_group=0,recipe_level=10,recipe_type=4}---[144]��Ū÷����̾ѥ[��]
		staticrecipe[1010]={recipe_id=1279,recipe_group=0,recipe_level=10,recipe_type=4}---[144]��Ū÷����̾ѥ[Ů]
		staticrecipe[1011]={recipe_id=1282,recipe_group=0,recipe_level=8,recipe_type=4}---[120]��β����ѥ[��]
		staticrecipe[1012]={recipe_id=1283,recipe_group=0,recipe_level=8,recipe_type=4}---[120]��β����ѥ[Ů]
		staticrecipe[1013]={recipe_id=1284,recipe_group=0,recipe_level=9,recipe_type=4}---[135]��������ٻ�ѥ[��]
		staticrecipe[1014]={recipe_id=1285,recipe_group=0,recipe_level=9,recipe_type=4}---[135]��������ٻ�ѥ[Ů]
		staticrecipe[1015]={recipe_id=1286,recipe_group=0,recipe_level=10,recipe_type=4}---[144]��Ҷ��欽���ѥ[��]
		staticrecipe[1016]={recipe_id=1287,recipe_group=0,recipe_level=10,recipe_type=4}---[144]��Ҷ��欽���ѥ[Ů]
		staticrecipe[1017]={recipe_id=1290,recipe_group=0,recipe_level=8,recipe_type=4}---[120]��������ѥ[��]
		staticrecipe[1018]={recipe_id=1291,recipe_group=0,recipe_level=8,recipe_type=4}---[120]��������ѥ[Ů]
		staticrecipe[1019]={recipe_id=1292,recipe_group=0,recipe_level=9,recipe_type=4}---[135]�òʻ������ѥ[��]
		staticrecipe[1020]={recipe_id=1293,recipe_group=0,recipe_level=9,recipe_type=4}---[135]�òʻ������ѥ[Ů]
		staticrecipe[1021]={recipe_id=1294,recipe_group=0,recipe_level=10,recipe_type=4}---[144]�߲�Ө������ѥ[��]
		staticrecipe[1022]={recipe_id=1295,recipe_group=0,recipe_level=10,recipe_type=4}---[144]�߲�Ө������ѥ[Ů]
		staticrecipe[1023]={recipe_id=1298,recipe_group=0,recipe_level=8,recipe_type=4}---[120]�߱�����ѥ[��]
		staticrecipe[1024]={recipe_id=1299,recipe_group=0,recipe_level=8,recipe_type=4}---[120]�߱�����ѥ[Ů]
		staticrecipe[1025]={recipe_id=1300,recipe_group=0,recipe_level=9,recipe_type=4}---[135]�仨��ˮ����ѥ[��]
		staticrecipe[1026]={recipe_id=1301,recipe_group=0,recipe_level=9,recipe_type=4}---[135]�仨��ˮ����ѥ[Ů]
		staticrecipe[1027]={recipe_id=1302,recipe_group=0,recipe_level=10,recipe_type=4}---[144]��Ұ��������ѥ[��]
		staticrecipe[1028]={recipe_id=1303,recipe_group=0,recipe_level=10,recipe_type=4}---[144]��Ұ��������ѥ[Ů]
		staticrecipe[1029]={recipe_id=1306,recipe_group=0,recipe_level=8,recipe_type=4}---[120]��ʥ����ѥ[��]
		staticrecipe[1030]={recipe_id=1307,recipe_group=0,recipe_level=8,recipe_type=4}---[120]��ʥ����ѥ[Ů]
		staticrecipe[1031]={recipe_id=1308,recipe_group=0,recipe_level=9,recipe_type=4}---[135]��ϼ�ֿ��޲�ѥ[��]
		staticrecipe[1032]={recipe_id=1309,recipe_group=0,recipe_level=9,recipe_type=4}---[135]��ϼ�ֿ��޲�ѥ[Ů]
		staticrecipe[1033]={recipe_id=1310,recipe_group=0,recipe_level=10,recipe_type=4}---[144]�˱�ҹ������ѥ[��]
		staticrecipe[1034]={recipe_id=1311,recipe_group=0,recipe_level=10,recipe_type=4}---[144]�˱�ҹ������ѥ[Ů]
		staticrecipe[1035]={recipe_id=1314,recipe_group=0,recipe_level=8,recipe_type=4}---[120]�˻ļ���ѥ[��]
		staticrecipe[1036]={recipe_id=1315,recipe_group=0,recipe_level=8,recipe_type=4}---[120]�˻ļ���ѥ[Ů]
		staticrecipe[1037]={recipe_id=1316,recipe_group=0,recipe_level=9,recipe_type=4}---[135]�ٷ�������ңѥ[��]
		staticrecipe[1038]={recipe_id=1317,recipe_group=0,recipe_level=9,recipe_type=4}---[135]�ٷ�������ңѥ[Ů]
		staticrecipe[1039]={recipe_id=1318,recipe_group=0,recipe_level=10,recipe_type=4}---[144]������ᰰ���ѥ[��]
		staticrecipe[1040]={recipe_id=1319,recipe_group=0,recipe_level=10,recipe_type=4}---[144]������ᰰ���ѥ[Ů]
		staticrecipe[1041]={recipe_id=1322,recipe_group=0,recipe_level=8,recipe_type=4}---[120]��ɫ����ѥ[��]
		staticrecipe[1042]={recipe_id=1323,recipe_group=0,recipe_level=8,recipe_type=4}---[120]��ɫ����ѥ[Ů]
		staticrecipe[1043]={recipe_id=1324,recipe_group=0,recipe_level=9,recipe_type=4}---[135]̫����������ѥ[��]
		staticrecipe[1044]={recipe_id=1325,recipe_group=0,recipe_level=9,recipe_type=4}---[135]̫����������ѥ[Ů]
		staticrecipe[1045]={recipe_id=1326,recipe_group=0,recipe_level=10,recipe_type=4}---[144]�Ż�������ѥ[��]
		staticrecipe[1046]={recipe_id=1327,recipe_group=0,recipe_level=10,recipe_type=4}---[144]�Ż�������ѥ[Ů]
		staticrecipe[1047]={recipe_id=1330,recipe_group=0,recipe_level=8,recipe_type=4}---[120]�Ż���ɴѥ[��]
		staticrecipe[1048]={recipe_id=1331,recipe_group=0,recipe_level=8,recipe_type=4}---[120]�Ż���ɴѥ[Ů]
		staticrecipe[1049]={recipe_id=1332,recipe_group=0,recipe_level=9,recipe_type=4}---[135]��̨�����л�ѥ[��]
		staticrecipe[1050]={recipe_id=1333,recipe_group=0,recipe_level=9,recipe_type=4}---[135]��̨�����л�ѥ[Ů]
		staticrecipe[1051]={recipe_id=1270,recipe_group=0,recipe_level=10,recipe_type=4}---[144]������̨����ѥ[��]
		staticrecipe[1052]={recipe_id=1271,recipe_group=0,recipe_level=10,recipe_type=4}---[144]������̨����ѥ[Ů]
		staticrecipe[1053]={recipe_id=1274,recipe_group=0,recipe_level=8,recipe_type=4}---[120]�Ż�����ѥ[��]
		staticrecipe[1054]={recipe_id=1275,recipe_group=0,recipe_level=8,recipe_type=4}---[120]�Ż�����ѥ[Ů]
		staticrecipe[1055]={recipe_id=1276,recipe_group=0,recipe_level=9,recipe_type=4}---[135]Զ�ͽ������ѥ[��]
		staticrecipe[1056]={recipe_id=1277,recipe_group=0,recipe_level=9,recipe_type=4}---[135]Զ�ͽ������ѥ[Ů]
		staticrecipe[1057]={recipe_id=3744,recipe_group=0,recipe_level=10,recipe_type=4}---100������Ь���䷽
		staticrecipe[1058]={recipe_id=3810,recipe_group=0,recipe_level=10,recipe_type=4}---100������ЬŮ�䷽
		staticrecipe[1059]={recipe_id=3742,recipe_group=0,recipe_level=8,recipe_type=4}---80������Ь���䷽
		staticrecipe[1060]={recipe_id=3808,recipe_group=0,recipe_level=8,recipe_type=4}---80������ЬŮ�䷽
		staticrecipe[1061]={recipe_id=3743,recipe_group=0,recipe_level=9,recipe_type=4}---90������Ь���䷽
		staticrecipe[1062]={recipe_id=3809,recipe_group=0,recipe_level=9,recipe_type=4}---90������ЬŮ�䷽
		staticrecipe[1063]={recipe_id=3751,recipe_group=0,recipe_level=10,recipe_type=4}---����100������Ь���䷽
		staticrecipe[1064]={recipe_id=3817,recipe_group=0,recipe_level=10,recipe_type=4}---����100������ЬŮ�䷽
		staticrecipe[1065]={recipe_id=3749,recipe_group=0,recipe_level=8,recipe_type=4}---����80������Ь���䷽
		staticrecipe[1066]={recipe_id=3815,recipe_group=0,recipe_level=8,recipe_type=4}---����80������ЬŮ�䷽
		staticrecipe[1067]={recipe_id=3750,recipe_group=0,recipe_level=9,recipe_type=4}---����90������Ь���䷽
		staticrecipe[1068]={recipe_id=3816,recipe_group=0,recipe_level=9,recipe_type=4}---����90������ЬŮ�䷽
		staticrecipe[1069]={recipe_id=3765,recipe_group=0,recipe_level=10,recipe_type=4}---�������װ100������Ь���䷽
		staticrecipe[1070]={recipe_id=3831,recipe_group=0,recipe_level=10,recipe_type=4}---�������װ100������ЬŮ�䷽
		staticrecipe[1071]={recipe_id=3763,recipe_group=0,recipe_level=8,recipe_type=4}---�������װ80������Ь���䷽
		staticrecipe[1072]={recipe_id=3829,recipe_group=0,recipe_level=8,recipe_type=4}---�������װ80������ЬŮ�䷽
		staticrecipe[1073]={recipe_id=3764,recipe_group=0,recipe_level=9,recipe_type=4}---�������װ90������Ь���䷽
		staticrecipe[1074]={recipe_id=3830,recipe_group=0,recipe_level=9,recipe_type=4}---�������װ90������ЬŮ�䷽
		staticrecipe[1075]={recipe_id=3786,recipe_group=0,recipe_level=10,recipe_type=4}---���쿹��װ��100������Ь���䷽
		staticrecipe[1076]={recipe_id=3852,recipe_group=0,recipe_level=10,recipe_type=4}---���쿹��װ��100������ЬŮ�䷽
		staticrecipe[1077]={recipe_id=3784,recipe_group=0,recipe_level=8,recipe_type=4}---���쿹��װ��80������Ь���䷽
		staticrecipe[1078]={recipe_id=3850,recipe_group=0,recipe_level=8,recipe_type=4}---���쿹��װ��80������ЬŮ�䷽
		staticrecipe[1079]={recipe_id=3785,recipe_group=0,recipe_level=9,recipe_type=4}---���쿹��װ��90������Ь���䷽
		staticrecipe[1080]={recipe_id=3851,recipe_group=0,recipe_level=9,recipe_type=4}---���쿹��װ��90������ЬŮ�䷽
		staticrecipe[1081]={recipe_id=3793,recipe_group=0,recipe_level=10,recipe_type=4}---���쿹��װ��100������Ь���䷽
		staticrecipe[1082]={recipe_id=3859,recipe_group=0,recipe_level=10,recipe_type=4}---���쿹��װ��100������ЬŮ�䷽
		staticrecipe[1083]={recipe_id=3791,recipe_group=0,recipe_level=8,recipe_type=4}---���쿹��װ��80������Ь���䷽
		staticrecipe[1084]={recipe_id=3857,recipe_group=0,recipe_level=8,recipe_type=4}---���쿹��װ��80������ЬŮ�䷽
		staticrecipe[1085]={recipe_id=3792,recipe_group=0,recipe_level=9,recipe_type=4}---���쿹��װ��90������Ь���䷽
		staticrecipe[1086]={recipe_id=3858,recipe_group=0,recipe_level=9,recipe_type=4}---���쿹��װ��90������ЬŮ�䷽
		staticrecipe[1087]={recipe_id=3772,recipe_group=0,recipe_level=10,recipe_type=4}---���쿹��װ��100������Ь���䷽
		staticrecipe[1088]={recipe_id=3838,recipe_group=0,recipe_level=10,recipe_type=4}---���쿹��װ��100������ЬŮ�䷽
		staticrecipe[1089]={recipe_id=3770,recipe_group=0,recipe_level=8,recipe_type=4}---���쿹��װ��80������Ь���䷽
		staticrecipe[1090]={recipe_id=3836,recipe_group=0,recipe_level=8,recipe_type=4}---���쿹��װ��80������ЬŮ�䷽
		staticrecipe[1091]={recipe_id=3771,recipe_group=0,recipe_level=9,recipe_type=4}---���쿹��װ��90������Ь���䷽
		staticrecipe[1092]={recipe_id=3837,recipe_group=0,recipe_level=9,recipe_type=4}---���쿹��װ��90������ЬŮ�䷽
		staticrecipe[1093]={recipe_id=3800,recipe_group=0,recipe_level=10,recipe_type=4}---���쿹��װ��100������Ь���䷽
		staticrecipe[1094]={recipe_id=3866,recipe_group=0,recipe_level=10,recipe_type=4}---���쿹��װ��100������ЬŮ�䷽
		staticrecipe[1095]={recipe_id=3798,recipe_group=0,recipe_level=8,recipe_type=4}---���쿹��װ��80������Ь���䷽
		staticrecipe[1096]={recipe_id=3864,recipe_group=0,recipe_level=8,recipe_type=4}---���쿹��װ��80������ЬŮ�䷽
		staticrecipe[1097]={recipe_id=3799,recipe_group=0,recipe_level=9,recipe_type=4}---���쿹��װ��90������Ь���䷽
		staticrecipe[1098]={recipe_id=3865,recipe_group=0,recipe_level=9,recipe_type=4}---���쿹��װ��90������ЬŮ�䷽
		staticrecipe[1099]={recipe_id=3779,recipe_group=0,recipe_level=10,recipe_type=4}---���쿹��װ��100������Ь���䷽
		staticrecipe[1100]={recipe_id=3845,recipe_group=0,recipe_level=10,recipe_type=4}---���쿹��װ��100������ЬŮ�䷽
		staticrecipe[1101]={recipe_id=3777,recipe_group=0,recipe_level=8,recipe_type=4}---���쿹��װ��80������Ь���䷽
		staticrecipe[1102]={recipe_id=3843,recipe_group=0,recipe_level=8,recipe_type=4}---���쿹��װ��80������ЬŮ�䷽
		staticrecipe[1103]={recipe_id=3778,recipe_group=0,recipe_level=9,recipe_type=4}---���쿹��װ��90������Ь���䷽
		staticrecipe[1104]={recipe_id=3844,recipe_group=0,recipe_level=9,recipe_type=4}---���쿹��װ��90������ЬŮ�䷽
		staticrecipe[1105]={recipe_id=3758,recipe_group=0,recipe_level=10,recipe_type=4}---����ħ��װ100������Ь���䷽
		staticrecipe[1106]={recipe_id=3824,recipe_group=0,recipe_level=10,recipe_type=4}---����ħ��װ100������ЬŮ�䷽
		staticrecipe[1107]={recipe_id=3756,recipe_group=0,recipe_level=8,recipe_type=4}---����ħ��װ80������Ь���䷽
		staticrecipe[1108]={recipe_id=3822,recipe_group=0,recipe_level=8,recipe_type=4}---����ħ��װ80������ЬŮ�䷽
		staticrecipe[1109]={recipe_id=3757,recipe_group=0,recipe_level=9,recipe_type=4}---����ħ��װ90������Ь���䷽
		staticrecipe[1110]={recipe_id=3823,recipe_group=0,recipe_level=9,recipe_type=4}---����ħ��װ90������ЬŮ�䷽
		staticrecipe[1111]={recipe_id=4152,recipe_group=0,recipe_level=10,recipe_type=4}---100����ɽЬ���䷽
		staticrecipe[1112]={recipe_id=4218,recipe_group=0,recipe_level=10,recipe_type=4}---100����ɽЬŮ�䷽
		staticrecipe[1113]={recipe_id=4150,recipe_group=0,recipe_level=8,recipe_type=4}---80����ɽЬ���䷽
		staticrecipe[1114]={recipe_id=4216,recipe_group=0,recipe_level=8,recipe_type=4}---80����ɽЬŮ�䷽
		staticrecipe[1115]={recipe_id=4151,recipe_group=0,recipe_level=9,recipe_type=4}---90����ɽЬ���䷽
		staticrecipe[1116]={recipe_id=4217,recipe_group=0,recipe_level=9,recipe_type=4}---90����ɽЬŮ�䷽
		staticrecipe[1117]={recipe_id=4159,recipe_group=0,recipe_level=10,recipe_type=4}---����100����ɽЬ���䷽
		staticrecipe[1118]={recipe_id=4225,recipe_group=0,recipe_level=10,recipe_type=4}---����100����ɽЬŮ�䷽
		staticrecipe[1119]={recipe_id=4157,recipe_group=0,recipe_level=8,recipe_type=4}---����80����ɽЬ���䷽
		staticrecipe[1120]={recipe_id=4223,recipe_group=0,recipe_level=8,recipe_type=4}---����80����ɽЬŮ�䷽
		staticrecipe[1121]={recipe_id=4158,recipe_group=0,recipe_level=9,recipe_type=4}---����90����ɽЬ���䷽
		staticrecipe[1122]={recipe_id=4224,recipe_group=0,recipe_level=9,recipe_type=4}---����90����ɽЬŮ�䷽
		staticrecipe[1123]={recipe_id=4173,recipe_group=0,recipe_level=10,recipe_type=4}---�������װ100����ɽЬ���䷽
		staticrecipe[1124]={recipe_id=4239,recipe_group=0,recipe_level=10,recipe_type=4}---�������װ100����ɽЬŮ�䷽
		staticrecipe[1125]={recipe_id=4171,recipe_group=0,recipe_level=8,recipe_type=4}---�������װ80����ɽЬ���䷽
		staticrecipe[1126]={recipe_id=4237,recipe_group=0,recipe_level=8,recipe_type=4}---�������װ80����ɽЬŮ�䷽
		staticrecipe[1127]={recipe_id=4172,recipe_group=0,recipe_level=9,recipe_type=4}---�������װ90����ɽЬ���䷽
		staticrecipe[1128]={recipe_id=4238,recipe_group=0,recipe_level=9,recipe_type=4}---�������װ90����ɽЬŮ�䷽
		staticrecipe[1129]={recipe_id=4194,recipe_group=0,recipe_level=10,recipe_type=4}---���쿹��װ��100����ɽЬ���䷽
		staticrecipe[1130]={recipe_id=4260,recipe_group=0,recipe_level=10,recipe_type=4}---���쿹��װ��100����ɽЬŮ�䷽
		staticrecipe[1131]={recipe_id=4192,recipe_group=0,recipe_level=8,recipe_type=4}---���쿹��װ��80����ɽЬ���䷽
		staticrecipe[1132]={recipe_id=4258,recipe_group=0,recipe_level=8,recipe_type=4}---���쿹��װ��80����ɽЬŮ�䷽
		staticrecipe[1133]={recipe_id=4193,recipe_group=0,recipe_level=9,recipe_type=4}---���쿹��װ��90����ɽЬ���䷽
		staticrecipe[1134]={recipe_id=4259,recipe_group=0,recipe_level=9,recipe_type=4}---���쿹��װ��90����ɽЬŮ�䷽
		staticrecipe[1135]={recipe_id=4201,recipe_group=0,recipe_level=10,recipe_type=4}---���쿹��װ��100����ɽЬ���䷽
		staticrecipe[1136]={recipe_id=4267,recipe_group=0,recipe_level=10,recipe_type=4}---���쿹��װ��100����ɽЬŮ�䷽
		staticrecipe[1137]={recipe_id=4199,recipe_group=0,recipe_level=8,recipe_type=4}---���쿹��װ��80����ɽЬ���䷽
		staticrecipe[1138]={recipe_id=4265,recipe_group=0,recipe_level=8,recipe_type=4}---���쿹��װ��80����ɽЬŮ�䷽
		staticrecipe[1139]={recipe_id=4200,recipe_group=0,recipe_level=9,recipe_type=4}---���쿹��װ��90����ɽЬ���䷽
		staticrecipe[1140]={recipe_id=4266,recipe_group=0,recipe_level=9,recipe_type=4}---���쿹��װ��90����ɽЬŮ�䷽
		staticrecipe[1141]={recipe_id=4180,recipe_group=0,recipe_level=10,recipe_type=4}---���쿹��װ��100����ɽЬ���䷽
		staticrecipe[1142]={recipe_id=4246,recipe_group=0,recipe_level=10,recipe_type=4}---���쿹��װ��100����ɽЬŮ�䷽
		staticrecipe[1143]={recipe_id=4178,recipe_group=0,recipe_level=8,recipe_type=4}---���쿹��װ��80����ɽЬ���䷽
		staticrecipe[1144]={recipe_id=4244,recipe_group=0,recipe_level=8,recipe_type=4}---���쿹��װ��80����ɽЬŮ�䷽
		staticrecipe[1145]={recipe_id=4179,recipe_group=0,recipe_level=9,recipe_type=4}---���쿹��װ��90����ɽЬ���䷽
		staticrecipe[1146]={recipe_id=4245,recipe_group=0,recipe_level=9,recipe_type=4}---���쿹��װ��90����ɽЬŮ�䷽
		staticrecipe[1147]={recipe_id=4208,recipe_group=0,recipe_level=10,recipe_type=4}---���쿹��װ��100����ɽЬ���䷽
		staticrecipe[1148]={recipe_id=4274,recipe_group=0,recipe_level=10,recipe_type=4}---���쿹��װ��100����ɽЬŮ�䷽
		staticrecipe[1149]={recipe_id=4206,recipe_group=0,recipe_level=8,recipe_type=4}---���쿹��װ��80����ɽЬ���䷽
		staticrecipe[1150]={recipe_id=4272,recipe_group=0,recipe_level=8,recipe_type=4}---���쿹��װ��80����ɽЬŮ�䷽
		staticrecipe[1151]={recipe_id=4207,recipe_group=0,recipe_level=9,recipe_type=4}---���쿹��װ��90����ɽЬ���䷽
		staticrecipe[1152]={recipe_id=4273,recipe_group=0,recipe_level=9,recipe_type=4}---���쿹��װ��90����ɽЬŮ�䷽
		staticrecipe[1153]={recipe_id=4187,recipe_group=0,recipe_level=10,recipe_type=4}---���쿹��װ��100����ɽЬ���䷽
		staticrecipe[1154]={recipe_id=4253,recipe_group=0,recipe_level=10,recipe_type=4}---���쿹��װ��100����ɽЬŮ�䷽
		staticrecipe[1155]={recipe_id=4185,recipe_group=0,recipe_level=8,recipe_type=4}---���쿹��װ��80����ɽЬ���䷽
		staticrecipe[1156]={recipe_id=4251,recipe_group=0,recipe_level=8,recipe_type=4}---���쿹��װ��80����ɽЬŮ�䷽
		staticrecipe[1157]={recipe_id=4186,recipe_group=0,recipe_level=9,recipe_type=4}---���쿹��װ��90����ɽЬ���䷽
		staticrecipe[1158]={recipe_id=4252,recipe_group=0,recipe_level=9,recipe_type=4}---���쿹��װ��90����ɽЬŮ�䷽
		staticrecipe[1159]={recipe_id=4166,recipe_group=0,recipe_level=10,recipe_type=4}---����ħ��װ100����ɽЬ���䷽
		staticrecipe[1160]={recipe_id=4232,recipe_group=0,recipe_level=10,recipe_type=4}---����ħ��װ100����ɽЬŮ�䷽
		staticrecipe[1161]={recipe_id=4164,recipe_group=0,recipe_level=8,recipe_type=4}---����ħ��װ80����ɽЬ���䷽
		staticrecipe[1162]={recipe_id=4230,recipe_group=0,recipe_level=8,recipe_type=4}---����ħ��װ80����ɽЬŮ�䷽
		staticrecipe[1163]={recipe_id=4165,recipe_group=0,recipe_level=9,recipe_type=4}---����ħ��װ90����ɽЬ���䷽
		staticrecipe[1164]={recipe_id=4231,recipe_group=0,recipe_level=9,recipe_type=4}---����ħ��װ90����ɽЬŮ�䷽
		staticrecipe[1165]={recipe_id=291,recipe_group=0,recipe_level=10,recipe_type=4}---[144]������[��]
		staticrecipe[1166]={recipe_id=339,recipe_group=0,recipe_level=10,recipe_type=4}---[144]������[Ů]
		staticrecipe[1167]={recipe_id=289,recipe_group=0,recipe_level=8,recipe_type=4}---[120]̫����[��]
		staticrecipe[1168]={recipe_id=337,recipe_group=0,recipe_level=8,recipe_type=4}---[120]̫����[Ů]
		staticrecipe[1169]={recipe_id=290,recipe_group=0,recipe_level=9,recipe_type=4}---[135]������[��]
		staticrecipe[1170]={recipe_id=338,recipe_group=0,recipe_level=9,recipe_type=4}---[135]������[Ů]
		staticrecipe[1171]={recipe_id=1342,recipe_group=0,recipe_level=10,recipe_type=4}---[144]��������Ԫ��[��]
		staticrecipe[1172]={recipe_id=1343,recipe_group=0,recipe_level=10,recipe_type=4}---[144]��������Ԫ��[Ů]
		staticrecipe[1173]={recipe_id=1346,recipe_group=0,recipe_level=8,recipe_type=4}---[120]����֤����[��]
		staticrecipe[1174]={recipe_id=1347,recipe_group=0,recipe_level=8,recipe_type=4}---[120]����֤����[Ů]
		staticrecipe[1175]={recipe_id=1348,recipe_group=0,recipe_level=9,recipe_type=4}---[135]�������������[��]
		staticrecipe[1176]={recipe_id=1349,recipe_group=0,recipe_level=9,recipe_type=4}---[135]�������������[Ů]
		staticrecipe[1177]={recipe_id=1350,recipe_group=0,recipe_level=10,recipe_type=4}---[144]�����ݷ������[��]
		staticrecipe[1178]={recipe_id=1351,recipe_group=0,recipe_level=10,recipe_type=4}---[144]�����ݷ������[Ů]
		staticrecipe[1179]={recipe_id=1354,recipe_group=0,recipe_level=8,recipe_type=4}---[120]��سռ����[��]
		staticrecipe[1180]={recipe_id=1355,recipe_group=0,recipe_level=8,recipe_type=4}---[120]��سռ����[Ů]
		staticrecipe[1181]={recipe_id=1356,recipe_group=0,recipe_level=9,recipe_type=4}---[135]�����ɲ������[��]
		staticrecipe[1182]={recipe_id=1357,recipe_group=0,recipe_level=9,recipe_type=4}---[135]�����ɲ������[Ů]
		staticrecipe[1183]={recipe_id=1358,recipe_group=0,recipe_level=10,recipe_type=4}---[144]�߷����������[��]
		staticrecipe[1184]={recipe_id=1359,recipe_group=0,recipe_level=10,recipe_type=4}---[144]�߷����������[Ů]
		staticrecipe[1185]={recipe_id=1362,recipe_group=0,recipe_level=8,recipe_type=4}---[120]����פ����[��]
		staticrecipe[1186]={recipe_id=1363,recipe_group=0,recipe_level=8,recipe_type=4}---[120]����פ����[Ů]
		staticrecipe[1187]={recipe_id=1364,recipe_group=0,recipe_level=9,recipe_type=4}---[135]�����Ǿ���Ԫ��[��]
		staticrecipe[1188]={recipe_id=1365,recipe_group=0,recipe_level=9,recipe_type=4}---[135]�����Ǿ���Ԫ��[Ů]
		staticrecipe[1189]={recipe_id=1366,recipe_group=0,recipe_level=10,recipe_type=4}---[144]��ʥ����������[��]
		staticrecipe[1190]={recipe_id=1367,recipe_group=0,recipe_level=10,recipe_type=4}---[144]��ʥ����������[Ů]
		staticrecipe[1191]={recipe_id=1370,recipe_group=0,recipe_level=8,recipe_type=4}---[120]�ĺ�������[��]
		staticrecipe[1192]={recipe_id=1371,recipe_group=0,recipe_level=8,recipe_type=4}---[120]�ĺ�������[Ů]
		staticrecipe[1193]={recipe_id=1372,recipe_group=0,recipe_level=9,recipe_type=4}---[135]�񶦽ᵤ��ʥ��[��]
		staticrecipe[1194]={recipe_id=1373,recipe_group=0,recipe_level=9,recipe_type=4}---[135]�񶦽ᵤ��ʥ��[Ů]
		staticrecipe[1195]={recipe_id=1374,recipe_group=0,recipe_level=10,recipe_type=4}---[144]���Ž���������[��]
		staticrecipe[1196]={recipe_id=1375,recipe_group=0,recipe_level=10,recipe_type=4}---[144]���Ž���������[Ů]
		staticrecipe[1197]={recipe_id=1378,recipe_group=0,recipe_level=8,recipe_type=4}---[120]�˼�������[��]
		staticrecipe[1198]={recipe_id=1379,recipe_group=0,recipe_level=8,recipe_type=4}---[120]�˼�������[Ů]
		staticrecipe[1199]={recipe_id=1380,recipe_group=0,recipe_level=9,recipe_type=4}---[135]�ط�ͨ����ڤ��[��]
		staticrecipe[1200]={recipe_id=1381,recipe_group=0,recipe_level=9,recipe_type=4}---[135]�ط�ͨ����ڤ��[Ů]
		staticrecipe[1201]={recipe_id=1382,recipe_group=0,recipe_level=10,recipe_type=4}---[144]���گ��������[��]
		staticrecipe[1202]={recipe_id=1383,recipe_group=0,recipe_level=10,recipe_type=4}---[144]���گ��������[Ů]
		staticrecipe[1203]={recipe_id=1386,recipe_group=0,recipe_level=8,recipe_type=4}---[120]��Ԫ������[��]
		staticrecipe[1204]={recipe_id=1387,recipe_group=0,recipe_level=8,recipe_type=4}---[120]��Ԫ������[Ů]
		staticrecipe[1205]={recipe_id=1388,recipe_group=0,recipe_level=9,recipe_type=4}---[135]�������յ�����[��]
		staticrecipe[1206]={recipe_id=1389,recipe_group=0,recipe_level=9,recipe_type=4}---[135]�������յ�����[Ů]
		staticrecipe[1207]={recipe_id=1390,recipe_group=0,recipe_level=10,recipe_type=4}---[144]��ɲ���׺ƹ���[��]
		staticrecipe[1208]={recipe_id=1391,recipe_group=0,recipe_level=10,recipe_type=4}---[144]��ɲ���׺ƹ���[Ů]
		staticrecipe[1209]={recipe_id=1394,recipe_group=0,recipe_level=8,recipe_type=4}---[120]��Ӣ��Ԫ��[��]
		staticrecipe[1210]={recipe_id=1395,recipe_group=0,recipe_level=8,recipe_type=4}---[120]��Ӣ��Ԫ��[Ů]
		staticrecipe[1211]={recipe_id=1396,recipe_group=0,recipe_level=9,recipe_type=4}---[135]��Ԫ�����ֽ���[��]
		staticrecipe[1212]={recipe_id=1397,recipe_group=0,recipe_level=9,recipe_type=4}---[135]��Ԫ�����ֽ���[Ů]
		staticrecipe[1213]={recipe_id=1334,recipe_group=0,recipe_level=10,recipe_type=4}---[144]�ž�������ŭ��[��]
		staticrecipe[1214]={recipe_id=1335,recipe_group=0,recipe_level=10,recipe_type=4}---[144]�ž�������ŭ��[Ů]
		staticrecipe[1215]={recipe_id=1338,recipe_group=0,recipe_level=8,recipe_type=4}---[120]����������[��]
		staticrecipe[1216]={recipe_id=1339,recipe_group=0,recipe_level=8,recipe_type=4}---[120]����������[Ů]
		staticrecipe[1217]={recipe_id=1340,recipe_group=0,recipe_level=9,recipe_type=4}---[135]������ٽ�����[��]
		staticrecipe[1218]={recipe_id=1341,recipe_group=0,recipe_level=9,recipe_type=4}---[135]������ٽ�����[Ů]
		staticrecipe[1219]={recipe_id=295,recipe_group=0,recipe_level=10,recipe_type=4}---[144]������[��]
		staticrecipe[1220]={recipe_id=343,recipe_group=0,recipe_level=10,recipe_type=4}---[144]������[Ů]
		staticrecipe[1221]={recipe_id=293,recipe_group=0,recipe_level=8,recipe_type=4}---[120]������[��]
		staticrecipe[1222]={recipe_id=341,recipe_group=0,recipe_level=8,recipe_type=4}---[120]������[Ů]
		staticrecipe[1223]={recipe_id=294,recipe_group=0,recipe_level=9,recipe_type=4}---[135]������[��]
		staticrecipe[1224]={recipe_id=342,recipe_group=0,recipe_level=9,recipe_type=4}---[135]������[Ů]
		staticrecipe[1225]={recipe_id=1406,recipe_group=0,recipe_level=10,recipe_type=4}---[144]�������������[��]
		staticrecipe[1226]={recipe_id=1407,recipe_group=0,recipe_level=10,recipe_type=4}---[144]�������������[Ů]
		staticrecipe[1227]={recipe_id=1410,recipe_group=0,recipe_level=8,recipe_type=4}---[120]���������[��]
		staticrecipe[1228]={recipe_id=1411,recipe_group=0,recipe_level=8,recipe_type=4}---[120]���������[Ů]
		staticrecipe[1229]={recipe_id=1412,recipe_group=0,recipe_level=9,recipe_type=4}---[135]��¬ɳ��������[��]
		staticrecipe[1230]={recipe_id=1413,recipe_group=0,recipe_level=9,recipe_type=4}---[135]��¬ɳ��������[Ů]
		staticrecipe[1231]={recipe_id=1414,recipe_group=0,recipe_level=10,recipe_type=4}---[144]��������������[��]
		staticrecipe[1232]={recipe_id=1415,recipe_group=0,recipe_level=10,recipe_type=4}---[144]��������������[Ů]
		staticrecipe[1233]={recipe_id=1418,recipe_group=0,recipe_level=8,recipe_type=4}---[120]���������[��]
		staticrecipe[1234]={recipe_id=1419,recipe_group=0,recipe_level=8,recipe_type=4}---[120]���������[Ů]
		staticrecipe[1235]={recipe_id=1420,recipe_group=0,recipe_level=9,recipe_type=4}---[135]��ҵ�޾�٤����[��]
		staticrecipe[1236]={recipe_id=1421,recipe_group=0,recipe_level=9,recipe_type=4}---[135]��ҵ�޾�٤����[Ů]
		staticrecipe[1237]={recipe_id=1422,recipe_group=0,recipe_level=10,recipe_type=4}---[144]�߽��ֻؼ�����[��]
		staticrecipe[1238]={recipe_id=1423,recipe_group=0,recipe_level=10,recipe_type=4}---[144]�߽��ֻؼ�����[Ů]
		staticrecipe[1239]={recipe_id=1426,recipe_group=0,recipe_level=8,recipe_type=4}---[120]�߷�������[��]
		staticrecipe[1240]={recipe_id=1427,recipe_group=0,recipe_level=8,recipe_type=4}---[120]�߷�������[Ů]
		staticrecipe[1241]={recipe_id=1428,recipe_group=0,recipe_level=9,recipe_type=4}---[135]�������д�ʿ��[��]
		staticrecipe[1242]={recipe_id=1429,recipe_group=0,recipe_level=9,recipe_type=4}---[135]�������д�ʿ��[Ů]
		staticrecipe[1243]={recipe_id=1430,recipe_group=0,recipe_level=10,recipe_type=4}---[144]������η������[��]
		staticrecipe[1244]={recipe_id=1431,recipe_group=0,recipe_level=10,recipe_type=4}---[144]������η������[Ů]
		staticrecipe[1245]={recipe_id=1434,recipe_group=0,recipe_level=8,recipe_type=4}---[120]�ĳ�ͨ����[��]
		staticrecipe[1246]={recipe_id=1435,recipe_group=0,recipe_level=8,recipe_type=4}---[120]�ĳ�ͨ����[Ů]
		staticrecipe[1247]={recipe_id=1436,recipe_group=0,recipe_level=9,recipe_type=4}---[135]���������޺���[��]
		staticrecipe[1248]={recipe_id=1437,recipe_group=0,recipe_level=9,recipe_type=4}---[135]���������޺���[Ů]
		staticrecipe[1249]={recipe_id=1438,recipe_group=0,recipe_level=10,recipe_type=4}---[144]����Ԫ�徻����[��]
		staticrecipe[1250]={recipe_id=1439,recipe_group=0,recipe_level=10,recipe_type=4}---[144]����Ԫ�徻����[Ů]
		staticrecipe[1251]={recipe_id=1442,recipe_group=0,recipe_level=8,recipe_type=4}---[120]�˵�������[��]
		staticrecipe[1252]={recipe_id=1443,recipe_group=0,recipe_level=8,recipe_type=4}---[120]�˵�������[Ů]
		staticrecipe[1253]={recipe_id=1444,recipe_group=0,recipe_level=9,recipe_type=4}---[135]�����޳���ʦ��[��]
		staticrecipe[1254]={recipe_id=1445,recipe_group=0,recipe_level=9,recipe_type=4}---[135]�����޳���ʦ��[Ů]
		staticrecipe[1255]={recipe_id=1446,recipe_group=0,recipe_level=10,recipe_type=4}---[144]���Ƕ���������[��]
		staticrecipe[1256]={recipe_id=1447,recipe_group=0,recipe_level=10,recipe_type=4}---[144]���Ƕ���������[Ů]
		staticrecipe[1257]={recipe_id=1450,recipe_group=0,recipe_level=8,recipe_type=4}---[120]������ҵ��[��]
		staticrecipe[1258]={recipe_id=1451,recipe_group=0,recipe_level=8,recipe_type=4}---[120]������ҵ��[Ů]
		staticrecipe[1259]={recipe_id=1452,recipe_group=0,recipe_level=9,recipe_type=4}---[135]��ͨ��פ�����[��]
		staticrecipe[1260]={recipe_id=1453,recipe_group=0,recipe_level=9,recipe_type=4}---[135]��ͨ��פ�����[Ů]
		staticrecipe[1261]={recipe_id=1454,recipe_group=0,recipe_level=10,recipe_type=4}---[144]ʮ������������[��]
		staticrecipe[1262]={recipe_id=1455,recipe_group=0,recipe_level=10,recipe_type=4}---[144]ʮ������������[Ů]
		staticrecipe[1263]={recipe_id=1458,recipe_group=0,recipe_level=8,recipe_type=4}---[120]����Ⱥ���[��]
		staticrecipe[1264]={recipe_id=1459,recipe_group=0,recipe_level=8,recipe_type=4}---[120]����Ⱥ���[Ů]
		staticrecipe[1265]={recipe_id=1460,recipe_group=0,recipe_level=9,recipe_type=4}---[135]Ħڭɲ��������[��]
		staticrecipe[1266]={recipe_id=1461,recipe_group=0,recipe_level=9,recipe_type=4}---[135]Ħڭɲ��������[Ů]
		staticrecipe[1267]={recipe_id=1398,recipe_group=0,recipe_level=10,recipe_type=4}---[144]�ŵ����޵ز���[��]
		staticrecipe[1268]={recipe_id=1399,recipe_group=0,recipe_level=10,recipe_type=4}---[144]�ŵ����޵ز���[Ů]
		staticrecipe[1269]={recipe_id=1402,recipe_group=0,recipe_level=8,recipe_type=4}---[120]��������[��]
		staticrecipe[1270]={recipe_id=1403,recipe_group=0,recipe_level=8,recipe_type=4}---[120]��������[Ů]
		staticrecipe[1271]={recipe_id=1404,recipe_group=0,recipe_level=9,recipe_type=4}---[135]��ɽ���������[��]
		staticrecipe[1272]={recipe_id=1405,recipe_group=0,recipe_level=9,recipe_type=4}---[135]��ɽ���������[Ů]
		staticrecipe[1273]={recipe_id=2203,recipe_group=0,recipe_level=10,recipe_type=2}---[146]�زؼ�[��]
		staticrecipe[1274]={recipe_id=2269,recipe_group=0,recipe_level=10,recipe_type=2}---[146]�زؼ�[Ů]
		staticrecipe[1275]={recipe_id=2201,recipe_group=0,recipe_level=8,recipe_type=2}---[120]ڤ����[��]
		staticrecipe[1276]={recipe_id=2267,recipe_group=0,recipe_level=8,recipe_type=2}---[120]ڤ����[Ů]
		staticrecipe[1277]={recipe_id=2202,recipe_group=0,recipe_level=9,recipe_type=2}---[135]���Ǽ�[��]
		staticrecipe[1278]={recipe_id=2268,recipe_group=0,recipe_level=9,recipe_type=2}---[135]���Ǽ�[Ů]
		staticrecipe[1279]={recipe_id=2210,recipe_group=0,recipe_level=10,recipe_type=2}---[146]�ŵ�ڤ�������[��]
		staticrecipe[1280]={recipe_id=2276,recipe_group=0,recipe_level=10,recipe_type=2}---[146]�ŵ�ڤ�������[Ů]
		staticrecipe[1281]={recipe_id=2208,recipe_group=0,recipe_level=8,recipe_type=2}---[120]���׶��ļ�[��]
		staticrecipe[1282]={recipe_id=2274,recipe_group=0,recipe_level=8,recipe_type=2}---[120]���׶��ļ�[Ů]
		staticrecipe[1283]={recipe_id=2209,recipe_group=0,recipe_level=9,recipe_type=2}---[135]ս�����ħ���[��]
		staticrecipe[1284]={recipe_id=2275,recipe_group=0,recipe_level=9,recipe_type=2}---[135]ս�����ħ���[Ů]
		staticrecipe[1285]={recipe_id=2224,recipe_group=0,recipe_level=10,recipe_type=2}---[146]�������𾫼�[��]
		staticrecipe[1286]={recipe_id=2290,recipe_group=0,recipe_level=10,recipe_type=2}---[146]�������𾫼�[Ů]
		staticrecipe[1287]={recipe_id=2222,recipe_group=0,recipe_level=8,recipe_type=2}---[120]���Ź��Ǽ�[��]
		staticrecipe[1288]={recipe_id=2288,recipe_group=0,recipe_level=8,recipe_type=2}---[120]���Ź��Ǽ�[Ů]
		staticrecipe[1289]={recipe_id=2223,recipe_group=0,recipe_level=9,recipe_type=2}---[135]�ķع�ڣ�����[��]
		staticrecipe[1290]={recipe_id=2289,recipe_group=0,recipe_level=9,recipe_type=2}---[135]�ķع�ڣ�����[Ů]
		staticrecipe[1291]={recipe_id=2245,recipe_group=0,recipe_level=10,recipe_type=2}---[146]�����ֻ�ħ�ļ�[��]
		staticrecipe[1292]={recipe_id=2311,recipe_group=0,recipe_level=10,recipe_type=2}---[146]�����ֻ�ħ�ļ�[Ů]
		staticrecipe[1293]={recipe_id=2243,recipe_group=0,recipe_level=8,recipe_type=2}---[120]��Ԧ���Ҽ�[��]
		staticrecipe[1294]={recipe_id=2309,recipe_group=0,recipe_level=8,recipe_type=2}---[120]��Ԧ���Ҽ�[Ů]
		staticrecipe[1295]={recipe_id=2244,recipe_group=0,recipe_level=9,recipe_type=2}---[135]ڤ�Ӷ���ϴ���[��]
		staticrecipe[1296]={recipe_id=2310,recipe_group=0,recipe_level=9,recipe_type=2}---[135]ڤ�Ӷ���ϴ���[Ů]
		staticrecipe[1297]={recipe_id=2252,recipe_group=0,recipe_level=10,recipe_type=2}---[146]�߽����������[��]
		staticrecipe[1298]={recipe_id=2318,recipe_group=0,recipe_level=10,recipe_type=2}---[146]�߽����������[Ů]
		staticrecipe[1299]={recipe_id=2250,recipe_group=0,recipe_level=8,recipe_type=2}---[120]�߿׾ۻ��[��]
		staticrecipe[1300]={recipe_id=2316,recipe_group=0,recipe_level=8,recipe_type=2}---[120]�߿׾ۻ��[Ů]
		staticrecipe[1301]={recipe_id=2251,recipe_group=0,recipe_level=9,recipe_type=2}---[135]Ѫ���𲨵���[��]
		staticrecipe[1302]={recipe_id=2317,recipe_group=0,recipe_level=9,recipe_type=2}---[135]Ѫ���𲨵���[Ů]
		staticrecipe[1303]={recipe_id=2231,recipe_group=0,recipe_level=10,recipe_type=2}---[146]����Ԫ��ڤ��[��]
		staticrecipe[1304]={recipe_id=2297,recipe_group=0,recipe_level=10,recipe_type=2}---[146]����Ԫ��ڤ��[Ů]
		staticrecipe[1305]={recipe_id=2229,recipe_group=0,recipe_level=8,recipe_type=2}---[120]��Χ��ڤ��[��]
		staticrecipe[1306]={recipe_id=2295,recipe_group=0,recipe_level=8,recipe_type=2}---[120]��Χ��ڤ��[Ů]
		staticrecipe[1307]={recipe_id=2230,recipe_group=0,recipe_level=9,recipe_type=2}---[135]������ڤ��[��]
		staticrecipe[1308]={recipe_id=2296,recipe_group=0,recipe_level=9,recipe_type=2}---[135]������ڤ��[Ů]
		staticrecipe[1309]={recipe_id=2259,recipe_group=0,recipe_level=10,recipe_type=2}---[146]����������ħ��[��]
		staticrecipe[1310]={recipe_id=2325,recipe_group=0,recipe_level=10,recipe_type=2}---[146]����������ħ��[Ů]
		staticrecipe[1311]={recipe_id=2257,recipe_group=0,recipe_level=8,recipe_type=2}---[120]���Ž�����[��]
		staticrecipe[1312]={recipe_id=2323,recipe_group=0,recipe_level=8,recipe_type=2}---[120]���Ž�����[Ů]
		staticrecipe[1313]={recipe_id=2258,recipe_group=0,recipe_level=9,recipe_type=2}---[135]��Ӱ�ƶ����ȼ�[��]
		staticrecipe[1314]={recipe_id=2324,recipe_group=0,recipe_level=9,recipe_type=2}---[135]��Ӱ�ƶ����ȼ�[Ů]
		staticrecipe[1315]={recipe_id=2238,recipe_group=0,recipe_level=10,recipe_type=2}---[146]�������ڳ��ռ�[��]
		staticrecipe[1316]={recipe_id=2304,recipe_group=0,recipe_level=10,recipe_type=2}---[146]�������ڳ��ռ�[Ů]
		staticrecipe[1317]={recipe_id=2236,recipe_group=0,recipe_level=8,recipe_type=2}---[120]���о�����[��]
		staticrecipe[1318]={recipe_id=2302,recipe_group=0,recipe_level=8,recipe_type=2}---[120]���о�����[Ů]
		staticrecipe[1319]={recipe_id=2237,recipe_group=0,recipe_level=9,recipe_type=2}---[135]����ܳ������[��]
		staticrecipe[1320]={recipe_id=2303,recipe_group=0,recipe_level=9,recipe_type=2}---[135]����ܳ������[Ů]
		staticrecipe[1321]={recipe_id=2217,recipe_group=0,recipe_level=10,recipe_type=2}---[146]�������������[��]
		staticrecipe[1322]={recipe_id=2283,recipe_group=0,recipe_level=10,recipe_type=2}---[146]�������������[Ů]
		staticrecipe[1323]={recipe_id=2215,recipe_group=0,recipe_level=8,recipe_type=2}---[120]�Ź����м�[��]
		staticrecipe[1324]={recipe_id=2281,recipe_group=0,recipe_level=8,recipe_type=2}---[120]�Ź����м�[Ů]
		staticrecipe[1325]={recipe_id=2216,recipe_group=0,recipe_level=9,recipe_type=2}---[135]��ڤת�������[��]
		staticrecipe[1326]={recipe_id=2282,recipe_group=0,recipe_level=9,recipe_type=2}---[135]��ڤת�������[Ů]
		staticrecipe[1327]={recipe_id=267,recipe_group=0,recipe_level=10,recipe_type=2}---[146]�ʼ���[��]
		staticrecipe[1328]={recipe_id=315,recipe_group=0,recipe_level=10,recipe_type=2}---[146]�ʼ���[Ů]
		staticrecipe[1329]={recipe_id=265,recipe_group=0,recipe_level=8,recipe_type=2}---[120]�����[��]
		staticrecipe[1330]={recipe_id=313,recipe_group=0,recipe_level=8,recipe_type=2}---[120]�����[Ů]
		staticrecipe[1331]={recipe_id=266,recipe_group=0,recipe_level=9,recipe_type=2}---[135]�����[��]
		staticrecipe[1332]={recipe_id=314,recipe_group=0,recipe_level=9,recipe_type=2}---[135]�����[Ů]
		staticrecipe[1333]={recipe_id=1470,recipe_group=0,recipe_level=10,recipe_type=2}---[146]�������а����[��]
		staticrecipe[1334]={recipe_id=1471,recipe_group=0,recipe_level=10,recipe_type=2}---[146]�������а����[Ů]
		staticrecipe[1335]={recipe_id=1474,recipe_group=0,recipe_level=8,recipe_type=2}---[120]������Ѫ��[��]
		staticrecipe[1336]={recipe_id=1475,recipe_group=0,recipe_level=8,recipe_type=2}---[120]������Ѫ��[Ů]
		staticrecipe[1337]={recipe_id=1476,recipe_group=0,recipe_level=9,recipe_type=2}---[135]���������ڽ��[��]
		staticrecipe[1338]={recipe_id=1477,recipe_group=0,recipe_level=9,recipe_type=2}---[135]���������ڽ��[Ů]
		staticrecipe[1339]={recipe_id=1478,recipe_group=0,recipe_level=10,recipe_type=2}---[146]�����ݺ�������[��]
		staticrecipe[1340]={recipe_id=1479,recipe_group=0,recipe_level=10,recipe_type=2}---[146]�����ݺ�������[Ů]
		staticrecipe[1341]={recipe_id=1482,recipe_group=0,recipe_level=8,recipe_type=2}---[120]�����ƾ���[��]
		staticrecipe[1342]={recipe_id=1483,recipe_group=0,recipe_level=8,recipe_type=2}---[120]�����ƾ���[Ů]
		staticrecipe[1343]={recipe_id=1484,recipe_group=0,recipe_level=9,recipe_type=2}---[135]����������Ѫ��[��]
		staticrecipe[1344]={recipe_id=1485,recipe_group=0,recipe_level=9,recipe_type=2}---[135]����������Ѫ��[Ů]
		staticrecipe[1345]={recipe_id=1486,recipe_group=0,recipe_level=10,recipe_type=2}---[146]�߽ݵ���������[��]
		staticrecipe[1346]={recipe_id=1487,recipe_group=0,recipe_level=10,recipe_type=2}---[146]�߽ݵ���������[Ů]
		staticrecipe[1347]={recipe_id=1490,recipe_group=0,recipe_level=8,recipe_type=2}---[120]�����һ���[��]
		staticrecipe[1348]={recipe_id=1491,recipe_group=0,recipe_level=8,recipe_type=2}---[120]�����һ���[Ů]
		staticrecipe[1349]={recipe_id=1492,recipe_group=0,recipe_level=9,recipe_type=2}---[135]���Х������[��]
		staticrecipe[1350]={recipe_id=1493,recipe_group=0,recipe_level=9,recipe_type=2}---[135]���Х������[Ů]
		staticrecipe[1351]={recipe_id=1494,recipe_group=0,recipe_level=10,recipe_type=2}---[146]�ĺ�Х��������[��]
		staticrecipe[1352]={recipe_id=1495,recipe_group=0,recipe_level=10,recipe_type=2}---[146]�ĺ�Х��������[Ů]
		staticrecipe[1353]={recipe_id=1498,recipe_group=0,recipe_level=8,recipe_type=2}---[120]���ķ�����[��]
		staticrecipe[1354]={recipe_id=1499,recipe_group=0,recipe_level=8,recipe_type=2}---[120]���ķ�����[Ů]
		staticrecipe[1355]={recipe_id=1500,recipe_group=0,recipe_level=9,recipe_type=2}---[135]������ͷ������[��]
		staticrecipe[1356]={recipe_id=1501,recipe_group=0,recipe_level=9,recipe_type=2}---[135]������ͷ������[Ů]
		staticrecipe[1357]={recipe_id=1502,recipe_group=0,recipe_level=10,recipe_type=2}---[146]�����Ӣ������[��]
		staticrecipe[1358]={recipe_id=1503,recipe_group=0,recipe_level=10,recipe_type=2}---[146]�����Ӣ������[Ů]
		staticrecipe[1359]={recipe_id=1506,recipe_group=0,recipe_level=8,recipe_type=2}---[120]����ŭ����[��]
		staticrecipe[1360]={recipe_id=1507,recipe_group=0,recipe_level=8,recipe_type=2}---[120]����ŭ����[Ů]
		staticrecipe[1361]={recipe_id=1508,recipe_group=0,recipe_level=9,recipe_type=2}---[135]����̫��������[��]
		staticrecipe[1362]={recipe_id=1509,recipe_group=0,recipe_level=9,recipe_type=2}---[135]����̫��������[Ů]
		staticrecipe[1363]={recipe_id=1510,recipe_group=0,recipe_level=10,recipe_type=2}---[146]��ɷ���ӷ�����[��]
		staticrecipe[1364]={recipe_id=1511,recipe_group=0,recipe_level=10,recipe_type=2}---[146]��ɷ���ӷ�����[Ů]
		staticrecipe[1365]={recipe_id=1514,recipe_group=0,recipe_level=8,recipe_type=2}---[120]����������[��]
		staticrecipe[1366]={recipe_id=1515,recipe_group=0,recipe_level=8,recipe_type=2}---[120]����������[Ů]
		staticrecipe[1367]={recipe_id=1516,recipe_group=0,recipe_level=9,recipe_type=2}---[135]���ǽ����ƽ��[��]
		staticrecipe[1368]={recipe_id=1517,recipe_group=0,recipe_level=9,recipe_type=2}---[135]���ǽ����ƽ��[Ů]
		staticrecipe[1369]={recipe_id=1518,recipe_group=0,recipe_level=10,recipe_type=2}---[146]����ۺ��������[��]
		staticrecipe[1370]={recipe_id=1519,recipe_group=0,recipe_level=10,recipe_type=2}---[146]����ۺ��������[Ů]
		staticrecipe[1371]={recipe_id=1522,recipe_group=0,recipe_level=8,recipe_type=2}---[120]���޳�����[��]
		staticrecipe[1372]={recipe_id=1523,recipe_group=0,recipe_level=8,recipe_type=2}---[120]���޳�����[Ů]
		staticrecipe[1373]={recipe_id=1524,recipe_group=0,recipe_level=9,recipe_type=2}---[135]��������а����[��]
		staticrecipe[1374]={recipe_id=1525,recipe_group=0,recipe_level=9,recipe_type=2}---[135]��������а����[Ů]
		staticrecipe[1375]={recipe_id=1462,recipe_group=0,recipe_level=10,recipe_type=2}---[146]��ħ����ڤ����[��]
		staticrecipe[1376]={recipe_id=1463,recipe_group=0,recipe_level=10,recipe_type=2}---[146]��ħ����ڤ����[Ů]
		staticrecipe[1377]={recipe_id=1466,recipe_group=0,recipe_level=8,recipe_type=2}---[120]��ת������[��]
		staticrecipe[1378]={recipe_id=1467,recipe_group=0,recipe_level=8,recipe_type=2}---[120]��ת������[Ů]
		staticrecipe[1379]={recipe_id=1468,recipe_group=0,recipe_level=9,recipe_type=2}---[135]�������˽���[��]
		staticrecipe[1380]={recipe_id=1469,recipe_group=0,recipe_level=9,recipe_type=2}---[135]�������˽���[Ů]
		staticrecipe[1381]={recipe_id=271,recipe_group=0,recipe_level=10,recipe_type=2}---[146]������[��]
		staticrecipe[1382]={recipe_id=319,recipe_group=0,recipe_level=10,recipe_type=2}---[146]������[Ů]
		staticrecipe[1383]={recipe_id=269,recipe_group=0,recipe_level=8,recipe_type=2}---[120]������[��]
		staticrecipe[1384]={recipe_id=317,recipe_group=0,recipe_level=8,recipe_type=2}---[120]������[Ů]
		staticrecipe[1385]={recipe_id=270,recipe_group=0,recipe_level=9,recipe_type=2}---[135]������[��]
		staticrecipe[1386]={recipe_id=318,recipe_group=0,recipe_level=9,recipe_type=2}---[135]������[Ů]
		staticrecipe[1387]={recipe_id=1534,recipe_group=0,recipe_level=10,recipe_type=2}---[146]��Ū÷����̾��[��]
		staticrecipe[1388]={recipe_id=1535,recipe_group=0,recipe_level=10,recipe_type=2}---[146]��Ū÷����̾��[Ů]
		staticrecipe[1389]={recipe_id=1538,recipe_group=0,recipe_level=8,recipe_type=2}---[120]��β������[��]
		staticrecipe[1390]={recipe_id=1539,recipe_group=0,recipe_level=8,recipe_type=2}---[120]��β������[Ů]
		staticrecipe[1391]={recipe_id=1540,recipe_group=0,recipe_level=9,recipe_type=2}---[135]��������ٻ���[��]
		staticrecipe[1392]={recipe_id=1541,recipe_group=0,recipe_level=9,recipe_type=2}---[135]��������ٻ���[Ů]
		staticrecipe[1393]={recipe_id=1542,recipe_group=0,recipe_level=10,recipe_type=2}---[146]��Ҷ��欽�����[��]
		staticrecipe[1394]={recipe_id=1543,recipe_group=0,recipe_level=10,recipe_type=2}---[146]��Ҷ��欽�����[Ů]
		staticrecipe[1395]={recipe_id=1546,recipe_group=0,recipe_level=8,recipe_type=2}---[120]����������[��]
		staticrecipe[1396]={recipe_id=1547,recipe_group=0,recipe_level=8,recipe_type=2}---[120]����������[Ů]
		staticrecipe[1397]={recipe_id=1548,recipe_group=0,recipe_level=9,recipe_type=2}---[135]�òʻ��������[��]
		staticrecipe[1398]={recipe_id=1549,recipe_group=0,recipe_level=9,recipe_type=2}---[135]�òʻ��������[Ů]
		staticrecipe[1399]={recipe_id=1550,recipe_group=0,recipe_level=10,recipe_type=2}---[146]�߲�Ө��������[��]
		staticrecipe[1400]={recipe_id=1551,recipe_group=0,recipe_level=10,recipe_type=2}---[146]�߲�Ө��������[Ů]
		staticrecipe[1401]={recipe_id=1554,recipe_group=0,recipe_level=8,recipe_type=2}---[120]�߱�������[��]
		staticrecipe[1402]={recipe_id=1555,recipe_group=0,recipe_level=8,recipe_type=2}---[120]�߱�������[Ů]
		staticrecipe[1403]={recipe_id=1556,recipe_group=0,recipe_level=9,recipe_type=2}---[135]�仨��ˮ������[��]
		staticrecipe[1404]={recipe_id=1557,recipe_group=0,recipe_level=9,recipe_type=2}---[135]�仨��ˮ������[Ů]
		staticrecipe[1405]={recipe_id=1558,recipe_group=0,recipe_level=10,recipe_type=2}---[146]��Ұ����������[��]
		staticrecipe[1406]={recipe_id=1559,recipe_group=0,recipe_level=10,recipe_type=2}---[146]��Ұ����������[Ů]
		staticrecipe[1407]={recipe_id=1562,recipe_group=0,recipe_level=8,recipe_type=2}---[120]��ʥ������[��]
		staticrecipe[1408]={recipe_id=1563,recipe_group=0,recipe_level=8,recipe_type=2}---[120]��ʥ������[Ů]
		staticrecipe[1409]={recipe_id=1564,recipe_group=0,recipe_level=9,recipe_type=2}---[135]��ϼ�ֿ��޲���[��]
		staticrecipe[1410]={recipe_id=1565,recipe_group=0,recipe_level=9,recipe_type=2}---[135]��ϼ�ֿ��޲���[Ů]
		staticrecipe[1411]={recipe_id=1566,recipe_group=0,recipe_level=10,recipe_type=2}---[146]�˱�ҹ��������[��]
		staticrecipe[1412]={recipe_id=1567,recipe_group=0,recipe_level=10,recipe_type=2}---[146]�˱�ҹ��������[Ů]
		staticrecipe[1413]={recipe_id=1570,recipe_group=0,recipe_level=8,recipe_type=2}---[120]�˻ļ�����[��]
		staticrecipe[1414]={recipe_id=1571,recipe_group=0,recipe_level=8,recipe_type=2}---[120]�˻ļ�����[Ů]
		staticrecipe[1415]={recipe_id=1572,recipe_group=0,recipe_level=9,recipe_type=2}---[135]�ٷ�������ң��[��]
		staticrecipe[1416]={recipe_id=1573,recipe_group=0,recipe_level=9,recipe_type=2}---[135]�ٷ�������ң��[Ů]
		staticrecipe[1417]={recipe_id=1574,recipe_group=0,recipe_level=10,recipe_type=2}---[146]������ᰰ�����[��]
		staticrecipe[1418]={recipe_id=1575,recipe_group=0,recipe_level=10,recipe_type=2}---[146]������ᰰ�����[Ů]
		staticrecipe[1419]={recipe_id=1578,recipe_group=0,recipe_level=8,recipe_type=2}---[120]��ɫ������[��]
		staticrecipe[1420]={recipe_id=1579,recipe_group=0,recipe_level=8,recipe_type=2}---[120]��ɫ������[Ů]
		staticrecipe[1421]={recipe_id=1580,recipe_group=0,recipe_level=9,recipe_type=2}---[135]̫������������[��]
		staticrecipe[1422]={recipe_id=1581,recipe_group=0,recipe_level=9,recipe_type=2}---[135]̫������������[Ů]
		staticrecipe[1423]={recipe_id=1582,recipe_group=0,recipe_level=10,recipe_type=2}---[146]�Ż���������[��]
		staticrecipe[1424]={recipe_id=1583,recipe_group=0,recipe_level=10,recipe_type=2}---[146]�Ż���������[Ů]
		staticrecipe[1425]={recipe_id=1586,recipe_group=0,recipe_level=8,recipe_type=2}---[120]�Ż���ɴ��[��]
		staticrecipe[1426]={recipe_id=1587,recipe_group=0,recipe_level=8,recipe_type=2}---[120]�Ż���ɴ��[Ů]
		staticrecipe[1427]={recipe_id=1588,recipe_group=0,recipe_level=9,recipe_type=2}---[135]��̨�����л���[��]
		staticrecipe[1428]={recipe_id=1589,recipe_group=0,recipe_level=9,recipe_type=2}---[135]��̨�����л���[Ů]
		staticrecipe[1429]={recipe_id=1526,recipe_group=0,recipe_level=10,recipe_type=2}---[146]������̨������[��]
		staticrecipe[1430]={recipe_id=1527,recipe_group=0,recipe_level=10,recipe_type=2}---[146]������̨������[Ů]
		staticrecipe[1431]={recipe_id=1530,recipe_group=0,recipe_level=8,recipe_type=2}---[120]�Ż�������[��]
		staticrecipe[1432]={recipe_id=1531,recipe_group=0,recipe_level=8,recipe_type=2}---[120]�Ż�������[Ů]
		staticrecipe[1433]={recipe_id=1532,recipe_group=0,recipe_level=9,recipe_type=2}---[135]Զ�ͽ��������[��]
		staticrecipe[1434]={recipe_id=1533,recipe_group=0,recipe_level=9,recipe_type=2}---[135]Զ�ͽ��������[Ů]
		staticrecipe[1435]={recipe_id=3878,recipe_group=0,recipe_level=10,recipe_type=2}---100����������䷽
		staticrecipe[1436]={recipe_id=3944,recipe_group=0,recipe_level=10,recipe_type=2}---100�������Ů�䷽
		staticrecipe[1437]={recipe_id=3876,recipe_group=0,recipe_level=8,recipe_type=2}---80����������䷽
		staticrecipe[1438]={recipe_id=3942,recipe_group=0,recipe_level=8,recipe_type=2}---80�������Ů�䷽
		staticrecipe[1439]={recipe_id=3877,recipe_group=0,recipe_level=9,recipe_type=2}---90����������䷽
		staticrecipe[1440]={recipe_id=3943,recipe_group=0,recipe_level=9,recipe_type=2}---90�������Ů�䷽
		staticrecipe[1441]={recipe_id=3885,recipe_group=0,recipe_level=10,recipe_type=2}---����100����������䷽
		staticrecipe[1442]={recipe_id=3951,recipe_group=0,recipe_level=10,recipe_type=2}---����100�������Ů�䷽
		staticrecipe[1443]={recipe_id=3883,recipe_group=0,recipe_level=8,recipe_type=2}---����80����������䷽
		staticrecipe[1444]={recipe_id=3949,recipe_group=0,recipe_level=8,recipe_type=2}---����80�������Ů�䷽
		staticrecipe[1445]={recipe_id=3884,recipe_group=0,recipe_level=9,recipe_type=2}---����90����������䷽
		staticrecipe[1446]={recipe_id=3950,recipe_group=0,recipe_level=9,recipe_type=2}---����90�������Ů�䷽
		staticrecipe[1447]={recipe_id=3899,recipe_group=0,recipe_level=10,recipe_type=2}---�������װ100����������䷽
		staticrecipe[1448]={recipe_id=3965,recipe_group=0,recipe_level=10,recipe_type=2}---�������װ100�������Ů�䷽
		staticrecipe[1449]={recipe_id=3897,recipe_group=0,recipe_level=8,recipe_type=2}---�������װ80����������䷽
		staticrecipe[1450]={recipe_id=3963,recipe_group=0,recipe_level=8,recipe_type=2}---�������װ80�������Ů�䷽
		staticrecipe[1451]={recipe_id=3898,recipe_group=0,recipe_level=9,recipe_type=2}---�������װ90����������䷽
		staticrecipe[1452]={recipe_id=3964,recipe_group=0,recipe_level=9,recipe_type=2}---�������װ90�������Ů�䷽
		staticrecipe[1453]={recipe_id=3920,recipe_group=0,recipe_level=10,recipe_type=2}---���쿹��װ��100����������䷽
		staticrecipe[1454]={recipe_id=3986,recipe_group=0,recipe_level=10,recipe_type=2}---���쿹��װ��100�������Ů�䷽
		staticrecipe[1455]={recipe_id=3918,recipe_group=0,recipe_level=8,recipe_type=2}---���쿹��װ��80����������䷽
		staticrecipe[1456]={recipe_id=3984,recipe_group=0,recipe_level=8,recipe_type=2}---���쿹��װ��80�������Ů�䷽
		staticrecipe[1457]={recipe_id=3919,recipe_group=0,recipe_level=9,recipe_type=2}---���쿹��װ��90����������䷽
		staticrecipe[1458]={recipe_id=3985,recipe_group=0,recipe_level=9,recipe_type=2}---���쿹��װ��90�������Ů�䷽
		staticrecipe[1459]={recipe_id=3927,recipe_group=0,recipe_level=10,recipe_type=2}---���쿹��װ��100����������䷽
		staticrecipe[1460]={recipe_id=3993,recipe_group=0,recipe_level=10,recipe_type=2}---���쿹��װ��100�������Ů�䷽
		staticrecipe[1461]={recipe_id=3925,recipe_group=0,recipe_level=8,recipe_type=2}---���쿹��װ��80����������䷽
		staticrecipe[1462]={recipe_id=3991,recipe_group=0,recipe_level=8,recipe_type=2}---���쿹��װ��80�������Ů�䷽
		staticrecipe[1463]={recipe_id=3926,recipe_group=0,recipe_level=9,recipe_type=2}---���쿹��װ��90����������䷽
		staticrecipe[1464]={recipe_id=3992,recipe_group=0,recipe_level=9,recipe_type=2}---���쿹��װ��90�������Ů�䷽
		staticrecipe[1465]={recipe_id=3906,recipe_group=0,recipe_level=10,recipe_type=2}---���쿹��װ��100����������䷽
		staticrecipe[1466]={recipe_id=3972,recipe_group=0,recipe_level=10,recipe_type=2}---���쿹��װ��100�������Ů�䷽
		staticrecipe[1467]={recipe_id=3904,recipe_group=0,recipe_level=8,recipe_type=2}---���쿹��װ��80����������䷽
		staticrecipe[1468]={recipe_id=3970,recipe_group=0,recipe_level=8,recipe_type=2}---���쿹��װ��80�������Ů�䷽
		staticrecipe[1469]={recipe_id=3905,recipe_group=0,recipe_level=9,recipe_type=2}---���쿹��װ��90����������䷽
		staticrecipe[1470]={recipe_id=3971,recipe_group=0,recipe_level=9,recipe_type=2}---���쿹��װ��90�������Ů�䷽
		staticrecipe[1471]={recipe_id=3934,recipe_group=0,recipe_level=10,recipe_type=2}---���쿹��װ��100����������䷽
		staticrecipe[1472]={recipe_id=4000,recipe_group=0,recipe_level=10,recipe_type=2}---���쿹��װ��100�������Ů�䷽
		staticrecipe[1473]={recipe_id=3932,recipe_group=0,recipe_level=8,recipe_type=2}---���쿹��װ��80����������䷽
		staticrecipe[1474]={recipe_id=3998,recipe_group=0,recipe_level=8,recipe_type=2}---���쿹��װ��80�������Ů�䷽
		staticrecipe[1475]={recipe_id=3933,recipe_group=0,recipe_level=9,recipe_type=2}---���쿹��װ��90����������䷽
		staticrecipe[1476]={recipe_id=3999,recipe_group=0,recipe_level=9,recipe_type=2}---���쿹��װ��90�������Ů�䷽
		staticrecipe[1477]={recipe_id=3913,recipe_group=0,recipe_level=10,recipe_type=2}---���쿹��װ��100����������䷽
		staticrecipe[1478]={recipe_id=3979,recipe_group=0,recipe_level=10,recipe_type=2}---���쿹��װ��100�������Ů�䷽
		staticrecipe[1479]={recipe_id=3911,recipe_group=0,recipe_level=8,recipe_type=2}---���쿹��װ��80����������䷽
		staticrecipe[1480]={recipe_id=3977,recipe_group=0,recipe_level=8,recipe_type=2}---���쿹��װ��80�������Ů�䷽
		staticrecipe[1481]={recipe_id=3912,recipe_group=0,recipe_level=9,recipe_type=2}---���쿹��װ��90����������䷽
		staticrecipe[1482]={recipe_id=3978,recipe_group=0,recipe_level=9,recipe_type=2}---���쿹��װ��90�������Ů�䷽
		staticrecipe[1483]={recipe_id=3892,recipe_group=0,recipe_level=10,recipe_type=2}---����ħ��װ100����������䷽
		staticrecipe[1484]={recipe_id=3958,recipe_group=0,recipe_level=10,recipe_type=2}---����ħ��װ100�������Ů�䷽
		staticrecipe[1485]={recipe_id=3890,recipe_group=0,recipe_level=8,recipe_type=2}---����ħ��װ80����������䷽
		staticrecipe[1486]={recipe_id=3956,recipe_group=0,recipe_level=8,recipe_type=2}---����ħ��װ80�������Ů�䷽
		staticrecipe[1487]={recipe_id=3891,recipe_group=0,recipe_level=9,recipe_type=2}---����ħ��װ90����������䷽
		staticrecipe[1488]={recipe_id=3957,recipe_group=0,recipe_level=9,recipe_type=2}---����ħ��װ90�������Ů�䷽
		staticrecipe[1489]={recipe_id=4284,recipe_group=0,recipe_level=10,recipe_type=2}---100����ɽ�����䷽
		staticrecipe[1490]={recipe_id=4350,recipe_group=0,recipe_level=10,recipe_type=2}---100����ɽ��Ů�䷽
		staticrecipe[1491]={recipe_id=4282,recipe_group=0,recipe_level=8,recipe_type=2}---80����ɽ�����䷽
		staticrecipe[1492]={recipe_id=4348,recipe_group=0,recipe_level=8,recipe_type=2}---80����ɽ��Ů�䷽
		staticrecipe[1493]={recipe_id=4283,recipe_group=0,recipe_level=9,recipe_type=2}---90����ɽ�����䷽
		staticrecipe[1494]={recipe_id=4349,recipe_group=0,recipe_level=9,recipe_type=2}---90����ɽ��Ů�䷽
		staticrecipe[1495]={recipe_id=4291,recipe_group=0,recipe_level=10,recipe_type=2}---����100����ɽ�����䷽
		staticrecipe[1496]={recipe_id=4357,recipe_group=0,recipe_level=10,recipe_type=2}---����100����ɽ��Ů�䷽
		staticrecipe[1497]={recipe_id=4289,recipe_group=0,recipe_level=8,recipe_type=2}---����80����ɽ�����䷽
		staticrecipe[1498]={recipe_id=4355,recipe_group=0,recipe_level=8,recipe_type=2}---����80����ɽ��Ů�䷽
		staticrecipe[1499]={recipe_id=4290,recipe_group=0,recipe_level=9,recipe_type=2}---����90����ɽ�����䷽
		staticrecipe[1500]={recipe_id=4356,recipe_group=0,recipe_level=9,recipe_type=2}---����90����ɽ��Ů�䷽
		staticrecipe[1501]={recipe_id=4305,recipe_group=0,recipe_level=10,recipe_type=2}---�������װ100����ɽ�����䷽
		staticrecipe[1502]={recipe_id=4371,recipe_group=0,recipe_level=10,recipe_type=2}---�������װ100����ɽ��Ů�䷽
		staticrecipe[1503]={recipe_id=4303,recipe_group=0,recipe_level=8,recipe_type=2}---�������װ80����ɽ�����䷽
		staticrecipe[1504]={recipe_id=4369,recipe_group=0,recipe_level=8,recipe_type=2}---�������װ80����ɽ��Ů�䷽
		staticrecipe[1505]={recipe_id=4304,recipe_group=0,recipe_level=9,recipe_type=2}---�������װ90����ɽ�����䷽
		staticrecipe[1506]={recipe_id=4370,recipe_group=0,recipe_level=9,recipe_type=2}---�������װ90����ɽ��Ů�䷽
		staticrecipe[1507]={recipe_id=4326,recipe_group=0,recipe_level=10,recipe_type=2}---���쿹��װ��100����ɽ�����䷽
		staticrecipe[1508]={recipe_id=4392,recipe_group=0,recipe_level=10,recipe_type=2}---���쿹��װ��100����ɽ��Ů�䷽
		staticrecipe[1509]={recipe_id=4324,recipe_group=0,recipe_level=8,recipe_type=2}---���쿹��װ��80����ɽ�����䷽
		staticrecipe[1510]={recipe_id=4390,recipe_group=0,recipe_level=8,recipe_type=2}---���쿹��װ��80����ɽ��Ů�䷽
		staticrecipe[1511]={recipe_id=4325,recipe_group=0,recipe_level=9,recipe_type=2}---���쿹��װ��90����ɽ�����䷽
		staticrecipe[1512]={recipe_id=4391,recipe_group=0,recipe_level=9,recipe_type=2}---���쿹��װ��90����ɽ��Ů�䷽
		staticrecipe[1513]={recipe_id=4333,recipe_group=0,recipe_level=10,recipe_type=2}---���쿹��װ��100����ɽ�����䷽
		staticrecipe[1514]={recipe_id=4399,recipe_group=0,recipe_level=10,recipe_type=2}---���쿹��װ��100����ɽ��Ů�䷽
		staticrecipe[1515]={recipe_id=4331,recipe_group=0,recipe_level=8,recipe_type=2}---���쿹��װ��80����ɽ�����䷽
		staticrecipe[1516]={recipe_id=4397,recipe_group=0,recipe_level=8,recipe_type=2}---���쿹��װ��80����ɽ��Ů�䷽
		staticrecipe[1517]={recipe_id=4332,recipe_group=0,recipe_level=9,recipe_type=2}---���쿹��װ��90����ɽ�����䷽
		staticrecipe[1518]={recipe_id=4398,recipe_group=0,recipe_level=9,recipe_type=2}---���쿹��װ��90����ɽ��Ů�䷽
		staticrecipe[1519]={recipe_id=4312,recipe_group=0,recipe_level=10,recipe_type=2}---���쿹��װ��100����ɽ�����䷽
		staticrecipe[1520]={recipe_id=4378,recipe_group=0,recipe_level=10,recipe_type=2}---���쿹��װ��100����ɽ��Ů�䷽
		staticrecipe[1521]={recipe_id=4310,recipe_group=0,recipe_level=8,recipe_type=2}---���쿹��װ��80����ɽ�����䷽
		staticrecipe[1522]={recipe_id=4376,recipe_group=0,recipe_level=8,recipe_type=2}---���쿹��װ��80����ɽ��Ů�䷽
		staticrecipe[1523]={recipe_id=4311,recipe_group=0,recipe_level=9,recipe_type=2}---���쿹��װ��90����ɽ�����䷽
		staticrecipe[1524]={recipe_id=4377,recipe_group=0,recipe_level=9,recipe_type=2}---���쿹��װ��90����ɽ��Ů�䷽
		staticrecipe[1525]={recipe_id=4340,recipe_group=0,recipe_level=10,recipe_type=2}---���쿹��װ��100����ɽ�����䷽
		staticrecipe[1526]={recipe_id=4405,recipe_group=0,recipe_level=10,recipe_type=2}---���쿹��װ��100����ɽ��Ů�䷽
		staticrecipe[1527]={recipe_id=4338,recipe_group=0,recipe_level=8,recipe_type=2}---���쿹��װ��80����ɽ�����䷽
		staticrecipe[1528]={recipe_id=4406,recipe_group=0,recipe_level=8,recipe_type=2}---���쿹��װ��80����ɽ��Ů�䷽
		staticrecipe[1529]={recipe_id=4339,recipe_group=0,recipe_level=9,recipe_type=2}---���쿹��װ��90����ɽ�����䷽
		staticrecipe[1530]={recipe_id=4404,recipe_group=0,recipe_level=9,recipe_type=2}---���쿹��װ��90����ɽ��Ů�䷽
		staticrecipe[1531]={recipe_id=4319,recipe_group=0,recipe_level=10,recipe_type=2}---���쿹��װ��100����ɽ�����䷽
		staticrecipe[1532]={recipe_id=4385,recipe_group=0,recipe_level=10,recipe_type=2}---���쿹��װ��100����ɽ��Ů�䷽
		staticrecipe[1533]={recipe_id=4317,recipe_group=0,recipe_level=8,recipe_type=2}---���쿹��װ��80����ɽ�����䷽
		staticrecipe[1534]={recipe_id=4383,recipe_group=0,recipe_level=8,recipe_type=2}---���쿹��װ��80����ɽ��Ů�䷽
		staticrecipe[1535]={recipe_id=4318,recipe_group=0,recipe_level=9,recipe_type=2}---���쿹��װ��90����ɽ�����䷽
		staticrecipe[1536]={recipe_id=4384,recipe_group=0,recipe_level=9,recipe_type=2}---���쿹��װ��90����ɽ��Ů�䷽
		staticrecipe[1537]={recipe_id=4298,recipe_group=0,recipe_level=10,recipe_type=2}---����ħ��װ100����ɽ�����䷽
		staticrecipe[1538]={recipe_id=4364,recipe_group=0,recipe_level=10,recipe_type=2}---����ħ��װ100����ɽ��Ů�䷽
		staticrecipe[1539]={recipe_id=4296,recipe_group=0,recipe_level=8,recipe_type=2}---����ħ��װ80����ɽ�����䷽
		staticrecipe[1540]={recipe_id=4362,recipe_group=0,recipe_level=8,recipe_type=2}---����ħ��װ80����ɽ��Ů�䷽
		staticrecipe[1541]={recipe_id=4297,recipe_group=0,recipe_level=9,recipe_type=2}---����ħ��װ90����ɽ�����䷽
		staticrecipe[1542]={recipe_id=4363,recipe_group=0,recipe_level=9,recipe_type=2}---����ħ��װ90����ɽ��Ů�䷽
		staticrecipe[1543]={recipe_id=275,recipe_group=0,recipe_level=10,recipe_type=2}---[146]������[��]
		staticrecipe[1544]={recipe_id=323,recipe_group=0,recipe_level=10,recipe_type=2}---[146]������[Ů]
		staticrecipe[1545]={recipe_id=273,recipe_group=0,recipe_level=8,recipe_type=2}---[120]̫����[��]
		staticrecipe[1546]={recipe_id=321,recipe_group=0,recipe_level=8,recipe_type=2}---[120]̫����[Ů]
		staticrecipe[1547]={recipe_id=274,recipe_group=0,recipe_level=9,recipe_type=2}---[135]������[��]
		staticrecipe[1548]={recipe_id=322,recipe_group=0,recipe_level=9,recipe_type=2}---[135]������[Ů]
		staticrecipe[1549]={recipe_id=1598,recipe_group=0,recipe_level=10,recipe_type=2}---[146]��������Ԫ��[��]
		staticrecipe[1550]={recipe_id=1599,recipe_group=0,recipe_level=10,recipe_type=2}---[146]��������Ԫ��[Ů]
		staticrecipe[1551]={recipe_id=1602,recipe_group=0,recipe_level=8,recipe_type=2}---[120]����֤����[��]
		staticrecipe[1552]={recipe_id=1603,recipe_group=0,recipe_level=8,recipe_type=2}---[120]����֤����[Ů]
		staticrecipe[1553]={recipe_id=1604,recipe_group=0,recipe_level=9,recipe_type=2}---[135]�������������[��]
		staticrecipe[1554]={recipe_id=1605,recipe_group=0,recipe_level=9,recipe_type=2}---[135]�������������[Ů]
		staticrecipe[1555]={recipe_id=1606,recipe_group=0,recipe_level=10,recipe_type=2}---[146]�����ݷ������[��]
		staticrecipe[1556]={recipe_id=1607,recipe_group=0,recipe_level=10,recipe_type=2}---[146]�����ݷ������[Ů]
		staticrecipe[1557]={recipe_id=1610,recipe_group=0,recipe_level=8,recipe_type=2}---[120]��سռ����[��]
		staticrecipe[1558]={recipe_id=1611,recipe_group=0,recipe_level=8,recipe_type=2}---[120]��سռ����[Ů]
		staticrecipe[1559]={recipe_id=1612,recipe_group=0,recipe_level=9,recipe_type=2}---[135]�����ɲ������[��]
		staticrecipe[1560]={recipe_id=1613,recipe_group=0,recipe_level=9,recipe_type=2}---[135]�����ɲ������[Ů]
		staticrecipe[1561]={recipe_id=1614,recipe_group=0,recipe_level=10,recipe_type=2}---[146]�߷����������[��]
		staticrecipe[1562]={recipe_id=1615,recipe_group=0,recipe_level=10,recipe_type=2}---[146]�߷����������[Ů]
		staticrecipe[1563]={recipe_id=1618,recipe_group=0,recipe_level=8,recipe_type=2}---[120]����פ����[��]
		staticrecipe[1564]={recipe_id=1619,recipe_group=0,recipe_level=8,recipe_type=2}---[120]����פ����[Ů]
		staticrecipe[1565]={recipe_id=1620,recipe_group=0,recipe_level=9,recipe_type=2}---[135]�����Ǿ���Ԫ��[��]
		staticrecipe[1566]={recipe_id=1621,recipe_group=0,recipe_level=9,recipe_type=2}---[135]�����Ǿ���Ԫ��[Ů]
		staticrecipe[1567]={recipe_id=1622,recipe_group=0,recipe_level=10,recipe_type=2}---[146]��ʥ����������[��]
		staticrecipe[1568]={recipe_id=1623,recipe_group=0,recipe_level=10,recipe_type=2}---[146]��ʥ����������[Ů]
		staticrecipe[1569]={recipe_id=1626,recipe_group=0,recipe_level=8,recipe_type=2}---[120]�ĺ�������[��]
		staticrecipe[1570]={recipe_id=1627,recipe_group=0,recipe_level=8,recipe_type=2}---[120]�ĺ�������[Ů]
		staticrecipe[1571]={recipe_id=1628,recipe_group=0,recipe_level=9,recipe_type=2}---[135]�񶦽ᵤ��ʥ��[��]
		staticrecipe[1572]={recipe_id=1629,recipe_group=0,recipe_level=9,recipe_type=2}---[135]�񶦽ᵤ��ʥ��[Ů]
		staticrecipe[1573]={recipe_id=1630,recipe_group=0,recipe_level=10,recipe_type=2}---[146]���Ž���������[��]
		staticrecipe[1574]={recipe_id=1631,recipe_group=0,recipe_level=10,recipe_type=2}---[146]���Ž���������[Ů]
		staticrecipe[1575]={recipe_id=1634,recipe_group=0,recipe_level=8,recipe_type=2}---[120]�˼�������[��]
		staticrecipe[1576]={recipe_id=1635,recipe_group=0,recipe_level=8,recipe_type=2}---[120]�˼�������[Ů]
		staticrecipe[1577]={recipe_id=1636,recipe_group=0,recipe_level=9,recipe_type=2}---[135]�ط�ͨ����ڤ��[��]
		staticrecipe[1578]={recipe_id=1637,recipe_group=0,recipe_level=9,recipe_type=2}---[135]�ط�ͨ����ڤ��[Ů]
		staticrecipe[1579]={recipe_id=1638,recipe_group=0,recipe_level=10,recipe_type=2}---[146]���گ��������[��]
		staticrecipe[1580]={recipe_id=1639,recipe_group=0,recipe_level=10,recipe_type=2}---[146]���گ��������[Ů]
		staticrecipe[1581]={recipe_id=1642,recipe_group=0,recipe_level=8,recipe_type=2}---[120]��Ԫ������[��]
		staticrecipe[1582]={recipe_id=1643,recipe_group=0,recipe_level=8,recipe_type=2}---[120]��Ԫ������[Ů]
		staticrecipe[1583]={recipe_id=1644,recipe_group=0,recipe_level=9,recipe_type=2}---[135]�������յ�����[��]
		staticrecipe[1584]={recipe_id=1645,recipe_group=0,recipe_level=9,recipe_type=2}---[135]�������յ�����[Ů]
		staticrecipe[1585]={recipe_id=1646,recipe_group=0,recipe_level=10,recipe_type=2}---[146]��ɲ���׺ƹ���[��]
		staticrecipe[1586]={recipe_id=1647,recipe_group=0,recipe_level=10,recipe_type=2}---[146]��ɲ���׺ƹ���[Ů]
		staticrecipe[1587]={recipe_id=1650,recipe_group=0,recipe_level=8,recipe_type=2}---[120]��Ӣ��Ԫ��[��]
		staticrecipe[1588]={recipe_id=1651,recipe_group=0,recipe_level=8,recipe_type=2}---[120]��Ӣ��Ԫ��[Ů]
		staticrecipe[1589]={recipe_id=1652,recipe_group=0,recipe_level=9,recipe_type=2}---[135]��Ԫ�����ֽ���[��]
		staticrecipe[1590]={recipe_id=1653,recipe_group=0,recipe_level=9,recipe_type=2}---[135]��Ԫ�����ֽ���[Ů]
		staticrecipe[1591]={recipe_id=1590,recipe_group=0,recipe_level=10,recipe_type=2}---[146]�ž�������ŭ��[��]
		staticrecipe[1592]={recipe_id=1591,recipe_group=0,recipe_level=10,recipe_type=2}---[146]�ž�������ŭ��[Ů]
		staticrecipe[1593]={recipe_id=1594,recipe_group=0,recipe_level=8,recipe_type=2}---[120]����������[��]
		staticrecipe[1594]={recipe_id=1595,recipe_group=0,recipe_level=8,recipe_type=2}---[120]����������[Ů]
		staticrecipe[1595]={recipe_id=1596,recipe_group=0,recipe_level=9,recipe_type=2}---[135]������ٽ�����[��]
		staticrecipe[1596]={recipe_id=1597,recipe_group=0,recipe_level=9,recipe_type=2}---[135]������ٽ�����[Ů]
		staticrecipe[1597]={recipe_id=279,recipe_group=0,recipe_level=10,recipe_type=2}---[146]������[��]
		staticrecipe[1598]={recipe_id=327,recipe_group=0,recipe_level=10,recipe_type=2}---[146]������[Ů]
		staticrecipe[1599]={recipe_id=277,recipe_group=0,recipe_level=8,recipe_type=2}---[120]������[��]
		staticrecipe[1600]={recipe_id=325,recipe_group=0,recipe_level=8,recipe_type=2}---[120]������[Ů]
		staticrecipe[1601]={recipe_id=278,recipe_group=0,recipe_level=9,recipe_type=2}---[135]������[��]
		staticrecipe[1602]={recipe_id=326,recipe_group=0,recipe_level=9,recipe_type=2}---[135]������[Ů]
		staticrecipe[1603]={recipe_id=1662,recipe_group=0,recipe_level=10,recipe_type=2}---[146]�������������[��]
		staticrecipe[1604]={recipe_id=1663,recipe_group=0,recipe_level=10,recipe_type=2}---[146]�������������[Ů]
		staticrecipe[1605]={recipe_id=1666,recipe_group=0,recipe_level=8,recipe_type=2}---[120]���������[��]
		staticrecipe[1606]={recipe_id=1667,recipe_group=0,recipe_level=8,recipe_type=2}---[120]���������[Ů]
		staticrecipe[1607]={recipe_id=1668,recipe_group=0,recipe_level=9,recipe_type=2}---[135]��¬ɳ��������[��]
		staticrecipe[1608]={recipe_id=1669,recipe_group=0,recipe_level=9,recipe_type=2}---[135]��¬ɳ��������[Ů]
		staticrecipe[1609]={recipe_id=1670,recipe_group=0,recipe_level=10,recipe_type=2}---[146]��������������[��]
		staticrecipe[1610]={recipe_id=1671,recipe_group=0,recipe_level=10,recipe_type=2}---[146]��������������[Ů]
		staticrecipe[1611]={recipe_id=1674,recipe_group=0,recipe_level=8,recipe_type=2}---[120]���������[��]
		staticrecipe[1612]={recipe_id=1675,recipe_group=0,recipe_level=8,recipe_type=2}---[120]���������[Ů]
		staticrecipe[1613]={recipe_id=1676,recipe_group=0,recipe_level=9,recipe_type=2}---[135]��ҵ�޾�٤����[��]
		staticrecipe[1614]={recipe_id=1677,recipe_group=0,recipe_level=9,recipe_type=2}---[135]��ҵ�޾�٤����[Ů]
		staticrecipe[1615]={recipe_id=1678,recipe_group=0,recipe_level=10,recipe_type=2}---[146]�߽��ֻؼ�����[��]
		staticrecipe[1616]={recipe_id=1679,recipe_group=0,recipe_level=10,recipe_type=2}---[146]�߽��ֻؼ�����[Ů]
		staticrecipe[1617]={recipe_id=1682,recipe_group=0,recipe_level=8,recipe_type=2}---[120]�߷�������[��]
		staticrecipe[1618]={recipe_id=1683,recipe_group=0,recipe_level=8,recipe_type=2}---[120]�߷�������[Ů]
		staticrecipe[1619]={recipe_id=1684,recipe_group=0,recipe_level=9,recipe_type=2}---[135]�������д�ʿ��[��]
		staticrecipe[1620]={recipe_id=1685,recipe_group=0,recipe_level=9,recipe_type=2}---[135]�������д�ʿ��[Ů]
		staticrecipe[1621]={recipe_id=1686,recipe_group=0,recipe_level=10,recipe_type=2}---[146]������η������[��]
		staticrecipe[1622]={recipe_id=1687,recipe_group=0,recipe_level=10,recipe_type=2}---[146]������η������[Ů]
		staticrecipe[1623]={recipe_id=1690,recipe_group=0,recipe_level=8,recipe_type=2}---[120]�ĳ�ͨ����[��]
		staticrecipe[1624]={recipe_id=1691,recipe_group=0,recipe_level=8,recipe_type=2}---[120]�ĳ�ͨ����[Ů]
		staticrecipe[1625]={recipe_id=1692,recipe_group=0,recipe_level=9,recipe_type=2}---[135]���������޺���[��]
		staticrecipe[1626]={recipe_id=1693,recipe_group=0,recipe_level=9,recipe_type=2}---[135]���������޺���[Ů]
		staticrecipe[1627]={recipe_id=1694,recipe_group=0,recipe_level=10,recipe_type=2}---[146]����Ԫ�徻����[��]
		staticrecipe[1628]={recipe_id=1695,recipe_group=0,recipe_level=10,recipe_type=2}---[146]����Ԫ�徻����[Ů]
		staticrecipe[1629]={recipe_id=1698,recipe_group=0,recipe_level=8,recipe_type=2}---[120]�˵�������[��]
		staticrecipe[1630]={recipe_id=1699,recipe_group=0,recipe_level=8,recipe_type=2}---[120]�˵�������[Ů]
		staticrecipe[1631]={recipe_id=1700,recipe_group=0,recipe_level=9,recipe_type=2}---[135]�����޳���ʦ��[��]
		staticrecipe[1632]={recipe_id=1701,recipe_group=0,recipe_level=9,recipe_type=2}---[135]�����޳���ʦ��[Ů]
		staticrecipe[1633]={recipe_id=1702,recipe_group=0,recipe_level=10,recipe_type=2}---[146]���Ƕ���������[��]
		staticrecipe[1634]={recipe_id=1703,recipe_group=0,recipe_level=10,recipe_type=2}---[146]���Ƕ���������[Ů]
		staticrecipe[1635]={recipe_id=1706,recipe_group=0,recipe_level=8,recipe_type=2}---[120]������ҵ��[��]
		staticrecipe[1636]={recipe_id=1707,recipe_group=0,recipe_level=8,recipe_type=2}---[120]������ҵ��[Ů]
		staticrecipe[1637]={recipe_id=1708,recipe_group=0,recipe_level=9,recipe_type=2}---[135]��ͨ��פ�����[��]
		staticrecipe[1638]={recipe_id=1709,recipe_group=0,recipe_level=9,recipe_type=2}---[135]��ͨ��פ�����[Ů]
		staticrecipe[1639]={recipe_id=1710,recipe_group=0,recipe_level=10,recipe_type=2}---[146]ʮ������������[��]
		staticrecipe[1640]={recipe_id=1711,recipe_group=0,recipe_level=10,recipe_type=2}---[146]ʮ������������[Ů]
		staticrecipe[1641]={recipe_id=1714,recipe_group=0,recipe_level=8,recipe_type=2}---[120]����Ⱥ���[��]
		staticrecipe[1642]={recipe_id=1715,recipe_group=0,recipe_level=8,recipe_type=2}---[120]����Ⱥ���[Ů]
		staticrecipe[1643]={recipe_id=1716,recipe_group=0,recipe_level=9,recipe_type=2}---[135]Ħڭɲ��������[��]
		staticrecipe[1644]={recipe_id=1717,recipe_group=0,recipe_level=9,recipe_type=2}---[135]Ħڭɲ��������[Ů]
		staticrecipe[1645]={recipe_id=1654,recipe_group=0,recipe_level=10,recipe_type=2}---[146]�ŵ����޵ز���[��]
		staticrecipe[1646]={recipe_id=1655,recipe_group=0,recipe_level=10,recipe_type=2}---[146]�ŵ����޵ز���[Ů]
		staticrecipe[1647]={recipe_id=1658,recipe_group=0,recipe_level=8,recipe_type=2}---[120]��������[��]
		staticrecipe[1648]={recipe_id=1659,recipe_group=0,recipe_level=8,recipe_type=2}---[120]��������[Ů]
		staticrecipe[1649]={recipe_id=1660,recipe_group=0,recipe_level=9,recipe_type=2}---[135]��ɽ���������[��]
		staticrecipe[1650]={recipe_id=1661,recipe_group=0,recipe_level=9,recipe_type=2}---[135]��ɽ���������[Ů]
		staticrecipe[1651]={recipe_id=2967,recipe_group=0,recipe_level=1,recipe_type=5}---�������ǻ����䷽
		staticrecipe[1652]={recipe_id=2968,recipe_group=0,recipe_level=1,recipe_type=5}---���������۶��䷽
		staticrecipe[1653]={recipe_id=2969,recipe_group=0,recipe_level=1,recipe_type=5}---���������ݺ��䷽
		staticrecipe[1654]={recipe_id=2970,recipe_group=0,recipe_level=1,recipe_type=5}---����������Ԫ�䷽
		staticrecipe[1655]={recipe_id=2971,recipe_group=0,recipe_level=1,recipe_type=5}---������س����䷽
		staticrecipe[1656]={recipe_id=2972,recipe_group=0,recipe_level=1,recipe_type=5}---��������ת���䷽
		staticrecipe[1657]={recipe_id=2973,recipe_group=0,recipe_level=1,recipe_type=5}---�����˷���ͨ�䷽
		staticrecipe[1658]={recipe_id=2974,recipe_group=0,recipe_level=1,recipe_type=5}---������ת�����䷽
		staticrecipe[1659]={recipe_id=2975,recipe_group=0,recipe_level=1,recipe_type=5}---����ʮ��Ǭ���䷽
		staticrecipe[1660]={recipe_id=2976,recipe_group=0,recipe_level=1,recipe_type=5}---�����ٽٶ�ڤ�䷽
		staticrecipe[1661]={recipe_id=2977,recipe_group=0,recipe_level=1,recipe_type=5}---����ǧ������䷽
		staticrecipe[1662]={recipe_id=2978,recipe_group=0,recipe_level=1,recipe_type=5}---�������������䷽
		staticrecipe[1663]={recipe_id=2979,recipe_group=0,recipe_level=1,recipe_type=5}---�������ǻ����䷽
		staticrecipe[1664]={recipe_id=2980,recipe_group=0,recipe_level=1,recipe_type=5}---���������۶��䷽
		staticrecipe[1665]={recipe_id=2981,recipe_group=0,recipe_level=1,recipe_type=5}---���������ݺ��䷽
		staticrecipe[1666]={recipe_id=2982,recipe_group=0,recipe_level=1,recipe_type=5}---����������Ԫ�䷽
		staticrecipe[1667]={recipe_id=2983,recipe_group=0,recipe_level=1,recipe_type=5}---������س����䷽
		staticrecipe[1668]={recipe_id=2984,recipe_group=0,recipe_level=1,recipe_type=5}---��������ת���䷽
		staticrecipe[1669]={recipe_id=2985,recipe_group=0,recipe_level=1,recipe_type=5}---�����˷���ͨ�䷽
		staticrecipe[1670]={recipe_id=2986,recipe_group=0,recipe_level=1,recipe_type=5}---������ת�����䷽
		staticrecipe[1671]={recipe_id=2987,recipe_group=0,recipe_level=1,recipe_type=5}---����ʮ��Ǭ���䷽
		staticrecipe[1672]={recipe_id=2988,recipe_group=0,recipe_level=1,recipe_type=5}---�����ٽٶ�ڤ�䷽
		staticrecipe[1673]={recipe_id=2989,recipe_group=0,recipe_level=1,recipe_type=5}---����ǧ������䷽
		staticrecipe[1674]={recipe_id=2990,recipe_group=0,recipe_level=1,recipe_type=5}---�������������䷽
		staticrecipe[1675]={recipe_id=2362,recipe_group=1,recipe_level=3,recipe_type=11}
		staticrecipe[1676]={recipe_id=2368,recipe_group=1,recipe_level=3,recipe_type=11}
		staticrecipe[1677]={recipe_id=2374,recipe_group=1,recipe_level=3,recipe_type=11}
		staticrecipe[1678]={recipe_id=2380,recipe_group=1,recipe_level=3,recipe_type=11}
		staticrecipe[1679]={recipe_id=2386,recipe_group=1,recipe_level=3,recipe_type=11}
		staticrecipe[1680]={recipe_id=2392,recipe_group=1,recipe_level=3,recipe_type=11}
		staticrecipe[1681]={recipe_id=2398,recipe_group=1,recipe_level=3,recipe_type=11}
		staticrecipe[1682]={recipe_id=2404,recipe_group=1,recipe_level=3,recipe_type=11}
		staticrecipe[1683]={recipe_id=2410,recipe_group=1,recipe_level=3,recipe_type=11}
		staticrecipe[1684]={recipe_id=2416,recipe_group=1,recipe_level=3,recipe_type=11}
		staticrecipe[1685]={recipe_id=2422,recipe_group=1,recipe_level=3,recipe_type=11}
		staticrecipe[1686]={recipe_id=2428,recipe_group=1,recipe_level=3,recipe_type=11}
		staticrecipe[1687]={recipe_id=2434,recipe_group=1,recipe_level=3,recipe_type=11}
		staticrecipe[1688]={recipe_id=2440,recipe_group=1,recipe_level=3,recipe_type=11}
		staticrecipe[1689]={recipe_id=2446,recipe_group=1,recipe_level=3,recipe_type=11}
		staticrecipe[1690]={recipe_id=2452,recipe_group=1,recipe_level=3,recipe_type=11}
		staticrecipe[1691]={recipe_id=2458,recipe_group=1,recipe_level=3,recipe_type=11}
		staticrecipe[1692]={recipe_id=2464,recipe_group=1,recipe_level=3,recipe_type=11}
		staticrecipe[1693]={recipe_id=2470,recipe_group=1,recipe_level=3,recipe_type=11}
		staticrecipe[1694]={recipe_id=2476,recipe_group=1,recipe_level=3,recipe_type=11}
		staticrecipe[1695]={recipe_id=2482,recipe_group=1,recipe_level=3,recipe_type=11}
		staticrecipe[1696]={recipe_id=2488,recipe_group=1,recipe_level=3,recipe_type=11}
		staticrecipe[1697]={recipe_id=2494,recipe_group=1,recipe_level=3,recipe_type=11}
		staticrecipe[1698]={recipe_id=2500,recipe_group=1,recipe_level=3,recipe_type=11}
		staticrecipe[1699]={recipe_id=2506,recipe_group=1,recipe_level=3,recipe_type=11}
		staticrecipe[1700]={recipe_id=2512,recipe_group=1,recipe_level=3,recipe_type=11}
		staticrecipe[1701]={recipe_id=2518,recipe_group=1,recipe_level=3,recipe_type=11}
		staticrecipe[1702]={recipe_id=2524,recipe_group=1,recipe_level=3,recipe_type=11}
		staticrecipe[1703]={recipe_id=2530,recipe_group=1,recipe_level=3,recipe_type=11}
		staticrecipe[1704]={recipe_id=2536,recipe_group=1,recipe_level=3,recipe_type=11}
		staticrecipe[1705]={recipe_id=2542,recipe_group=1,recipe_level=3,recipe_type=11}
		staticrecipe[1706]={recipe_id=2548,recipe_group=1,recipe_level=3,recipe_type=11}
		staticrecipe[1707]={recipe_id=2554,recipe_group=1,recipe_level=3,recipe_type=11}
		staticrecipe[1708]={recipe_id=2560,recipe_group=1,recipe_level=3,recipe_type=11}
		staticrecipe[1709]={recipe_id=2566,recipe_group=1,recipe_level=3,recipe_type=11}
		staticrecipe[1710]={recipe_id=2572,recipe_group=1,recipe_level=3,recipe_type=11}
		staticrecipe[1711]={recipe_id=2578,recipe_group=1,recipe_level=3,recipe_type=11}
		staticrecipe[1712]={recipe_id=2584,recipe_group=1,recipe_level=3,recipe_type=11}
		staticrecipe[1713]={recipe_id=2590,recipe_group=1,recipe_level=3,recipe_type=11}
		staticrecipe[1714]={recipe_id=2596,recipe_group=1,recipe_level=3,recipe_type=11}
		staticrecipe[1715]={recipe_id=2602,recipe_group=1,recipe_level=3,recipe_type=11}
		staticrecipe[1716]={recipe_id=2608,recipe_group=1,recipe_level=3,recipe_type=11}
		staticrecipe[1717]={recipe_id=2614,recipe_group=1,recipe_level=3,recipe_type=11}
		staticrecipe[1718]={recipe_id=2620,recipe_group=1,recipe_level=3,recipe_type=11}
		staticrecipe[1719]={recipe_id=2626,recipe_group=1,recipe_level=3,recipe_type=11}
		staticrecipe[1720]={recipe_id=2632,recipe_group=1,recipe_level=3,recipe_type=11}
		staticrecipe[1721]={recipe_id=2638,recipe_group=1,recipe_level=3,recipe_type=11}
		staticrecipe[1722]={recipe_id=2644,recipe_group=1,recipe_level=3,recipe_type=11}
		staticrecipe[1723]={recipe_id=2650,recipe_group=1,recipe_level=3,recipe_type=11}
		staticrecipe[1724]={recipe_id=2656,recipe_group=1,recipe_level=3,recipe_type=11}
		staticrecipe[1725]={recipe_id=2662,recipe_group=1,recipe_level=3,recipe_type=11}
		staticrecipe[1726]={recipe_id=2668,recipe_group=1,recipe_level=3,recipe_type=11}
		staticrecipe[1727]={recipe_id=2674,recipe_group=1,recipe_level=3,recipe_type=11}
		staticrecipe[1728]={recipe_id=2680,recipe_group=1,recipe_level=3,recipe_type=11}
		staticrecipe[1729]={recipe_id=2686,recipe_group=1,recipe_level=3,recipe_type=11}
		staticrecipe[1730]={recipe_id=2692,recipe_group=1,recipe_level=3,recipe_type=11}
		staticrecipe[1731]={recipe_id=2698,recipe_group=1,recipe_level=3,recipe_type=11}
		staticrecipe[1732]={recipe_id=2704,recipe_group=1,recipe_level=3,recipe_type=11}
		staticrecipe[1733]={recipe_id=2710,recipe_group=1,recipe_level=3,recipe_type=11}
		staticrecipe[1734]={recipe_id=2716,recipe_group=1,recipe_level=3,recipe_type=11}
		staticrecipe[1735]={recipe_id=2722,recipe_group=1,recipe_level=3,recipe_type=11}
		staticrecipe[1736]={recipe_id=2728,recipe_group=1,recipe_level=3,recipe_type=11}
		staticrecipe[1737]={recipe_id=2734,recipe_group=1,recipe_level=3,recipe_type=11}
		staticrecipe[1738]={recipe_id=2740,recipe_group=1,recipe_level=3,recipe_type=11}
		staticrecipe[1739]={recipe_id=2746,recipe_group=1,recipe_level=3,recipe_type=11}
		staticrecipe[1740]={recipe_id=2752,recipe_group=1,recipe_level=3,recipe_type=11}
		staticrecipe[1741]={recipe_id=2758,recipe_group=1,recipe_level=3,recipe_type=11}
		staticrecipe[1742]={recipe_id=4410,recipe_group=0,recipe_level=1,recipe_type=5}	---����
		staticrecipe[1743]={recipe_id=4411,recipe_group=0,recipe_level=1,recipe_type=5}	---����
		staticrecipe[1744]={recipe_id=4412,recipe_group=0,recipe_level=1,recipe_type=5}	---����
		staticrecipe[1745]={recipe_id=4413,recipe_group=0,recipe_level=1,recipe_type=5}	---����
		staticrecipe[1746]={recipe_id=4414,recipe_group=0,recipe_level=1,recipe_type=5}	---����
		staticrecipe[1747]={recipe_id=4415,recipe_group=0,recipe_level=1,recipe_type=5}	---���
		staticrecipe[1748]={recipe_id=4416,recipe_group=0,recipe_level=1,recipe_type=5}	---ŭ��
		staticrecipe[1749]={recipe_id=4417,recipe_group=0,recipe_level=1,recipe_type=5}	---����
		staticrecipe[1750]={recipe_id=4418,recipe_group=0,recipe_level=1,recipe_type=5}	---��Ӱ
		staticrecipe[1751]={recipe_id=4419,recipe_group=0,recipe_level=1,recipe_type=5}	---���
		staticrecipe[1752]={recipe_id=4420,recipe_group=0,recipe_level=1,recipe_type=5}	---����
		staticrecipe[1753]={recipe_id=4421,recipe_group=0,recipe_level=1,recipe_type=5}	---Ѫ��
		staticrecipe[1754]={recipe_id=4422,recipe_group=0,recipe_level=1,recipe_type=5}	---��ɱ
		staticrecipe[1755]={recipe_id=4423,recipe_group=0,recipe_level=1,recipe_type=5}	---Ѫ��
		staticrecipe[1756]={recipe_id=4424,recipe_group=0,recipe_level=1,recipe_type=5}	---����
		staticrecipe[1757]={recipe_id=4425,recipe_group=0,recipe_level=1,recipe_type=5}	---����
		staticrecipe[1758]={recipe_id=4426,recipe_group=0,recipe_level=1,recipe_type=5}	---����
		staticrecipe[1759]={recipe_id=4427,recipe_group=0,recipe_level=1,recipe_type=5}	---����
		staticrecipe[1760]={recipe_id=4428,recipe_group=0,recipe_level=1,recipe_type=5}	---�
		staticrecipe[1761]={recipe_id=4429,recipe_group=0,recipe_level=1,recipe_type=5}	---����
		staticrecipe[1762]={recipe_id=4430,recipe_group=0,recipe_level=1,recipe_type=5}	---��ԭ
		staticrecipe[1763]={recipe_id=4431,recipe_group=0,recipe_level=1,recipe_type=5}	---����
		staticrecipe[1764]={recipe_id=4432,recipe_group=0,recipe_level=1,recipe_type=5}	---˫��
		staticrecipe[1765]={recipe_id=4433,recipe_group=0,recipe_level=1,recipe_type=5}	---����
		staticrecipe[1766]={recipe_id=4434,recipe_group=0,recipe_level=1,recipe_type=5}	---����
		staticrecipe[1767]={recipe_id=4435,recipe_group=0,recipe_level=1,recipe_type=5}	---����
		staticrecipe[1768]={recipe_id=4436,recipe_group=0,recipe_level=1,recipe_type=5}	---����
		staticrecipe[1769]={recipe_id=4437,recipe_group=0,recipe_level=1,recipe_type=5}	---����
		staticrecipe[1770]={recipe_id=4438,recipe_group=0,recipe_level=1,recipe_type=5}	---��Ȼ
		staticrecipe[1771]={recipe_id=4439,recipe_group=0,recipe_level=1,recipe_type=5}	---ɱ��
		staticrecipe[1772]={recipe_id=4440,recipe_group=0,recipe_level=1,recipe_type=5}	---Ц̸
		staticrecipe[1773]={recipe_id=4441,recipe_group=0,recipe_level=1,recipe_type=5}	---�۴�
		staticrecipe[1774]={recipe_id=4442,recipe_group=0,recipe_level=1,recipe_type=5}	---����
		staticrecipe[1775]={recipe_id=4443,recipe_group=0,recipe_level=1,recipe_type=5}	---����
		staticrecipe[1776]={recipe_id=4444,recipe_group=0,recipe_level=1,recipe_type=5}	---�ٱ�
		staticrecipe[1777]={recipe_id=4445,recipe_group=0,recipe_level=1,recipe_type=5}	---����
		staticrecipe[1778]={recipe_id=4446,recipe_group=0,recipe_level=1,recipe_type=5}	---����
		staticrecipe[1779]={recipe_id=4447,recipe_group=0,recipe_level=1,recipe_type=5}	---����
		staticrecipe[1780]={recipe_id=4448,recipe_group=0,recipe_level=1,recipe_type=5}	---����
		staticrecipe[1781]={recipe_id=4449,recipe_group=0,recipe_level=1,recipe_type=5}	---ͨ��
		staticrecipe[1782]={recipe_id=4450,recipe_group=0,recipe_level=1,recipe_type=5}	---���
		staticrecipe[1783]={recipe_id=4451,recipe_group=0,recipe_level=1,recipe_type=5}	---�ѻ�
		staticrecipe[1784]={recipe_id=4452,recipe_group=0,recipe_level=1,recipe_type=5}	---ǧ��
		staticrecipe[1785]={recipe_id=4453,recipe_group=0,recipe_level=1,recipe_type=5}	---����
		staticrecipe[1786]={recipe_id=4454,recipe_group=0,recipe_level=1,recipe_type=5}	---����
		staticrecipe[1787]={recipe_id=4455,recipe_group=0,recipe_level=1,recipe_type=5}	---����
		staticrecipe[1788]={recipe_id=4456,recipe_group=0,recipe_level=1,recipe_type=5}	---����
		staticrecipe[1789]={recipe_id=4457,recipe_group=0,recipe_level=1,recipe_type=5}	---���
		staticrecipe[1790]={recipe_id=4458,recipe_group=0,recipe_level=1,recipe_type=5}	---����
		staticrecipe[1791]={recipe_id=4459,recipe_group=0,recipe_level=1,recipe_type=5}	---�o��
		staticrecipe[1792]={recipe_id=4460,recipe_group=0,recipe_level=1,recipe_type=5}	---����
		staticrecipe[1793]={recipe_id=4461,recipe_group=0,recipe_level=1,recipe_type=5}	---����
		staticrecipe[1794]={recipe_id=4462,recipe_group=0,recipe_level=1,recipe_type=5}	---����
		staticrecipe[1795]={recipe_id=4463,recipe_group=0,recipe_level=1,recipe_type=5}	---����
		staticrecipe[1796]={recipe_id=4464,recipe_group=0,recipe_level=1,recipe_type=5}	---��ܰ
		staticrecipe[1797]={recipe_id=4465,recipe_group=0,recipe_level=1,recipe_type=5}	---��
		staticrecipe[1798]={recipe_id=4466,recipe_group=0,recipe_level=1,recipe_type=5}	---��ľ
		staticrecipe[1799]={recipe_id=4467,recipe_group=0,recipe_level=1,recipe_type=5}	---����
		staticrecipe[1800]={recipe_id=4468,recipe_group=0,recipe_level=1,recipe_type=5}	---����
		staticrecipe[1801]={recipe_id=4469,recipe_group=0,recipe_level=1,recipe_type=5}	---����
		staticrecipe[1802]={recipe_id=4470,recipe_group=0,recipe_level=1,recipe_type=5}	---����
		staticrecipe[1803]={recipe_id=4471,recipe_group=0,recipe_level=1,recipe_type=5}	---�ٹ�
		staticrecipe[1804]={recipe_id=4472,recipe_group=0,recipe_level=1,recipe_type=5}	---����
		staticrecipe[1805]={recipe_id=4473,recipe_group=0,recipe_level=1,recipe_type=5}	---��ѿ
		staticrecipe[1806]={recipe_id=4474,recipe_group=0,recipe_level=1,recipe_type=5}	---�֦
		staticrecipe[1807]={recipe_id=4475,recipe_group=0,recipe_level=1,recipe_type=5}	---ǧ��
		staticrecipe[1808]={recipe_id=4476,recipe_group=0,recipe_level=1,recipe_type=5}	---����
		staticrecipe[1809]={recipe_id=4477,recipe_group=0,recipe_level=1,recipe_type=5}	---���
		staticrecipe[1810]={recipe_id=4478,recipe_group=0,recipe_level=1,recipe_type=5}	---����
		staticrecipe[1811]={recipe_id=4479,recipe_group=0,recipe_level=1,recipe_type=5}	---���
		staticrecipe[1812]={recipe_id=4480,recipe_group=0,recipe_level=1,recipe_type=5}	---����
		staticrecipe[1813]={recipe_id=4481,recipe_group=0,recipe_level=1,recipe_type=5}	---ĺɫ
		staticrecipe[1814]={recipe_id=4482,recipe_group=0,recipe_level=1,recipe_type=5}	---����
		staticrecipe[1815]={recipe_id=4483,recipe_group=0,recipe_level=1,recipe_type=5}	---����
		staticrecipe[1816]={recipe_id=4484,recipe_group=0,recipe_level=1,recipe_type=5}	---����
		staticrecipe[1817]={recipe_id=4485,recipe_group=0,recipe_level=1,recipe_type=5}	---�ǿ�
		staticrecipe[1818]={recipe_id=4486,recipe_group=0,recipe_level=1,recipe_type=5}	---���
		staticrecipe[1819]={recipe_id=4487,recipe_group=0,recipe_level=1,recipe_type=5}	---����
		staticrecipe[1820]={recipe_id=4488,recipe_group=0,recipe_level=1,recipe_type=5}	---���
		staticrecipe[1821]={recipe_id=4489,recipe_group=0,recipe_level=1,recipe_type=5}	---�Ҹ�
		staticrecipe[1822]={recipe_id=4490,recipe_group=0,recipe_level=1,recipe_type=5}	---Ѫ��
		staticrecipe[1823]={recipe_id=4491,recipe_group=0,recipe_level=1,recipe_type=5}	---��Ŀ
		staticrecipe[1824]={recipe_id=4492,recipe_group=0,recipe_level=1,recipe_type=5}	---��ħ
		staticrecipe[1825]={recipe_id=4493,recipe_group=0,recipe_level=1,recipe_type=5}	---����
		staticrecipe[1826]={recipe_id=4494,recipe_group=0,recipe_level=1,recipe_type=5}	---����
		staticrecipe[1827]={recipe_id=4495,recipe_group=0,recipe_level=1,recipe_type=5}	---���
		staticrecipe[1828]={recipe_id=4496,recipe_group=0,recipe_level=1,recipe_type=5}	---����
		staticrecipe[1829]={recipe_id=4497,recipe_group=0,recipe_level=1,recipe_type=5}	---��Ŀ
		staticrecipe[1830]={recipe_id=4498,recipe_group=0,recipe_level=1,recipe_type=5}	---����
		staticrecipe[1831]={recipe_id=4499,recipe_group=0,recipe_level=1,recipe_type=5}	---����
		staticrecipe[1832]={recipe_id=4500,recipe_group=0,recipe_level=1,recipe_type=5}	---����
		staticrecipe[1833]={recipe_id=4501,recipe_group=0,recipe_level=1,recipe_type=5}	---����
		staticrecipe[1834]={recipe_id=4502,recipe_group=0,recipe_level=1,recipe_type=5}	---����
		staticrecipe[1835]={recipe_id=4503,recipe_group=0,recipe_level=1,recipe_type=5}	---����
		staticrecipe[1836]={recipe_id=4504,recipe_group=0,recipe_level=1,recipe_type=5}	---����
		staticrecipe[1837]={recipe_id=4505,recipe_group=0,recipe_level=1,recipe_type=5}	---ŭ��
		staticrecipe[1838]={recipe_id=4506,recipe_group=0,recipe_level=1,recipe_type=5}	---����
		staticrecipe[1839]={recipe_id=4507,recipe_group=0,recipe_level=1,recipe_type=5}	---����
		staticrecipe[1840]={recipe_id=4508,recipe_group=0,recipe_level=1,recipe_type=5}	---����
		staticrecipe[1841]={recipe_id=4509,recipe_group=0,recipe_level=1,recipe_type=5}	---����
		staticrecipe[1842]={recipe_id=4510,recipe_group=0,recipe_level=1,recipe_type=5}	---ɽ¡
		staticrecipe[1843]={recipe_id=4511,recipe_group=0,recipe_level=1,recipe_type=5}	---�ٱ�
		staticrecipe[1844]={recipe_id=4512,recipe_group=0,recipe_level=1,recipe_type=5}	---����_�����䷽
		staticrecipe[1845]={recipe_id=4513,recipe_group=0,recipe_level=1,recipe_type=5}	---Ѫ��_��ɱ�䷽
		staticrecipe[1846]={recipe_id=4514,recipe_group=0,recipe_level=1,recipe_type=5}	---��Ӱ_����䷽
		staticrecipe[1847]={recipe_id=4515,recipe_group=0,recipe_level=1,recipe_type=5}	---�_�����䷽
		staticrecipe[1848]={recipe_id=4516,recipe_group=0,recipe_level=1,recipe_type=5}	---��ԭ_�����䷽
		staticrecipe[1849]={recipe_id=4517,recipe_group=0,recipe_level=1,recipe_type=5}	---����_�����䷽
		staticrecipe[1850]={recipe_id=4518,recipe_group=0,recipe_level=1,recipe_type=5}	---��Ȼ_ɱ���䷽
		staticrecipe[1851]={recipe_id=4519,recipe_group=0,recipe_level=1,recipe_type=5}	---����_�����䷽
		staticrecipe[1852]={recipe_id=4520,recipe_group=0,recipe_level=1,recipe_type=5}	---���_�ѻ��䷽
		staticrecipe[1853]={recipe_id=4521,recipe_group=0,recipe_level=1,recipe_type=5}	---��ܰ_���䷽
		staticrecipe[1854]={recipe_id=4522,recipe_group=0,recipe_level=1,recipe_type=5}	---����_�����䷽
		staticrecipe[1855]={recipe_id=4523,recipe_group=0,recipe_level=1,recipe_type=5}	---����_�����䷽
		staticrecipe[1856]={recipe_id=4524,recipe_group=0,recipe_level=1,recipe_type=5}	---����_ɽ¡�䷽
		staticrecipe[1857]={recipe_id=4525,recipe_group=0,recipe_level=1,recipe_type=5}	---ĺɫ_�����䷽
		staticrecipe[1858]={recipe_id=4526,recipe_group=0,recipe_level=1,recipe_type=5}	---���_�����䷽
		staticrecipe[1859]={recipe_id=4527,recipe_group=0,recipe_level=1,recipe_type=5}	---��ħ_�����䷽
		staticrecipe[1860]={recipe_id=4528,recipe_group=0,recipe_level=1,recipe_type=5}	---����_�����䷽
		staticrecipe[1861]={recipe_id=4529,recipe_group=0,recipe_level=1,recipe_type=5}	---����_�����䷽
		staticrecipe[1862]={recipe_id=5355,recipe_group=0,recipe_level=1,recipe_type=5}	---����_�ⴸ�䷽
		staticrecipe[1863]={recipe_id=5356,recipe_group=0,recipe_level=1,recipe_type=5}	---����_�����䷽
		staticrecipe[1864]={recipe_id=5357,recipe_group=0,recipe_level=1,recipe_type=5}	---����_��ɨ�䷽
		staticrecipe[1865]={recipe_id=5358,recipe_group=0,recipe_level=1,recipe_type=5}	---����_�ֵ��䷽
		staticrecipe[1866]={recipe_id=5359,recipe_group=0,recipe_level=1,recipe_type=5}	---����_��ȭ�䷽
		staticrecipe[1867]={recipe_id=5360,recipe_group=0,recipe_level=1,recipe_type=5}	---����_˲���䷽
		staticrecipe[1868]={recipe_id=5361,recipe_group=0,recipe_level=1,recipe_type=5}	---����_�����䷽
		staticrecipe[1869]={recipe_id=5362,recipe_group=0,recipe_level=1,recipe_type=5}	---����_�����䷽
		staticrecipe[1870]={recipe_id=5363,recipe_group=0,recipe_level=1,recipe_type=5}	---����_�����䷽
		staticrecipe[1871]={recipe_id=5364,recipe_group=0,recipe_level=1,recipe_type=5}	---����_�����䷽
		staticrecipe[1872]={recipe_id=5365,recipe_group=0,recipe_level=1,recipe_type=5}	---����_ն���䷽
		staticrecipe[1873]={recipe_id=5366,recipe_group=0,recipe_level=1,recipe_type=5}	---����_����䷽
		staticrecipe[1874]={recipe_id=5367,recipe_group=0,recipe_level=1,recipe_type=5}	---����_�����䷽
		staticrecipe[1875]={recipe_id=5368,recipe_group=0,recipe_level=1,recipe_type=5}	---����_�����䷽
		staticrecipe[1876]={recipe_id=5369,recipe_group=0,recipe_level=1,recipe_type=5}	---����_�����䷽
		staticrecipe[1877]={recipe_id=5370,recipe_group=0,recipe_level=1,recipe_type=5}	---����_Ѫ���䷽
		staticrecipe[1878]={recipe_id=5371,recipe_group=0,recipe_level=1,recipe_type=5}	---����_ɱ���䷽
		staticrecipe[1879]={recipe_id=5372,recipe_group=0,recipe_level=1,recipe_type=5}	---����_�����䷽
		staticrecipe[1880]={recipe_id=5373,recipe_group=0,recipe_level=1,recipe_type=5}	---����_�����䷽
		staticrecipe[1881]={recipe_id=5374,recipe_group=0,recipe_level=1,recipe_type=5}	---����_�����䷽
		staticrecipe[1882]={recipe_id=5375,recipe_group=0,recipe_level=1,recipe_type=5}	---����_ɱ���䷽
		staticrecipe[1883]={recipe_id=5376,recipe_group=0,recipe_level=1,recipe_type=5}	---����_ͨ���䷽
		staticrecipe[1884]={recipe_id=5377,recipe_group=0,recipe_level=1,recipe_type=5}	---����_�Ͼ��䷽
		staticrecipe[1885]={recipe_id=5378,recipe_group=0,recipe_level=1,recipe_type=5}	---����_ӥ���䷽
		staticrecipe[1886]={recipe_id=5379,recipe_group=0,recipe_level=1,recipe_type=5}	---����_�����䷽
		staticrecipe[1887]={recipe_id=5380,recipe_group=0,recipe_level=1,recipe_type=5}	---����_�����䷽
		staticrecipe[1888]={recipe_id=5381,recipe_group=0,recipe_level=1,recipe_type=5}	---����_�����䷽
		staticrecipe[1889]={recipe_id=5382,recipe_group=0,recipe_level=1,recipe_type=5}	---����_�����䷽
		staticrecipe[1890]={recipe_id=5383,recipe_group=0,recipe_level=1,recipe_type=5}	---����_��Ϣ�䷽
		staticrecipe[1891]={recipe_id=5384,recipe_group=0,recipe_level=1,recipe_type=5}	---����_����䷽
		staticrecipe[1892]={recipe_id=5385,recipe_group=0,recipe_level=1,recipe_type=5}	---����_�����䷽
		staticrecipe[1893]={recipe_id=5386,recipe_group=0,recipe_level=1,recipe_type=5}	---����_�����䷽
		staticrecipe[1894]={recipe_id=5387,recipe_group=0,recipe_level=1,recipe_type=5}	---����_Ы���䷽
		staticrecipe[1895]={recipe_id=5388,recipe_group=0,recipe_level=1,recipe_type=5}	---����_ڤ���䷽
		staticrecipe[1896]={recipe_id=5389,recipe_group=0,recipe_level=1,recipe_type=5}	---����_�����䷽
		staticrecipe[1897]={recipe_id=5390,recipe_group=0,recipe_level=1,recipe_type=5}	---����_�����䷽
		staticrecipe[1898]={recipe_id=5391,recipe_group=0,recipe_level=1,recipe_type=5}	---����_�����䷽
		staticrecipe[1899]={recipe_id=5392,recipe_group=0,recipe_level=1,recipe_type=5}	---����_��ָ�䷽
		staticrecipe[1900]={recipe_id=5393,recipe_group=0,recipe_level=1,recipe_type=5}	---����_ɱ���䷽
		staticrecipe[1901]={recipe_id=5394,recipe_group=0,recipe_level=1,recipe_type=5}	---����_��Ӱ�䷽
		staticrecipe[1902]={recipe_id=5395,recipe_group=0,recipe_level=1,recipe_type=5}	---����_�����䷽
		staticrecipe[1903]={recipe_id=5396,recipe_group=0,recipe_level=1,recipe_type=5}	---����_��Ӱ�䷽
		staticrecipe[1904]={recipe_id=5397,recipe_group=0,recipe_level=1,recipe_type=5}	---����_Ӱ���䷽
		staticrecipe[1905]={recipe_id=5398,recipe_group=0,recipe_level=1,recipe_type=5}	---����_Ӱ���䷽
		staticrecipe[1906]={recipe_id=5399,recipe_group=0,recipe_level=1,recipe_type=5}	---����_��Ӱ�䷽
		staticrecipe[1907]={recipe_id=5400,recipe_group=0,recipe_level=1,recipe_type=5}	---����_��Ӱ�䷽
		staticrecipe[1908]={recipe_id=5401,recipe_group=0,recipe_level=1,recipe_type=5}	---����_߮���䷽
		staticrecipe[1909]={recipe_id=5402,recipe_group=0,recipe_level=1,recipe_type=5}	---����_�����䷽
		staticrecipe[1910]={recipe_id=5403,recipe_group=0,recipe_level=1,recipe_type=5}	---����_Σ���䷽
		staticrecipe[1911]={recipe_id=5404,recipe_group=0,recipe_level=1,recipe_type=5}	---����_ȱ���䷽
		staticrecipe[1912]={recipe_id=5405,recipe_group=0,recipe_level=1,recipe_type=5}	---����_�����䷽
		staticrecipe[1913]={recipe_id=5406,recipe_group=0,recipe_level=1,recipe_type=5}	---�컪_�����䷽
		staticrecipe[1914]={recipe_id=5407,recipe_group=0,recipe_level=1,recipe_type=5}	---�컪_�����䷽
		staticrecipe[1915]={recipe_id=5408,recipe_group=0,recipe_level=1,recipe_type=5}	---�컪_�����䷽
		staticrecipe[1916]={recipe_id=5409,recipe_group=0,recipe_level=1,recipe_type=5}	---�컪_֪���䷽
		staticrecipe[1917]={recipe_id=5410,recipe_group=0,recipe_level=1,recipe_type=5}	---�컪_�뺣�䷽
		staticrecipe[1918]={recipe_id=5411,recipe_group=0,recipe_level=1,recipe_type=5}	---�컪_����䷽
		staticrecipe[1919]={recipe_id=5412,recipe_group=0,recipe_level=1,recipe_type=5}	---�컪_ӳ���䷽
		staticrecipe[1920]={recipe_id=5413,recipe_group=0,recipe_level=1,recipe_type=5}	---�컪_ΡΡ�䷽
		staticrecipe[1921]={recipe_id=5414,recipe_group=0,recipe_level=1,recipe_type=5}	---�컪_��Ȼ�䷽
		staticrecipe[1922]={recipe_id=5415,recipe_group=0,recipe_level=1,recipe_type=5}	---�컪_�����䷽
		staticrecipe[1923]={recipe_id=5416,recipe_group=0,recipe_level=1,recipe_type=5}	---�컪_�����䷽
		staticrecipe[1924]={recipe_id=5417,recipe_group=0,recipe_level=1,recipe_type=5}	---�컪_�罫�䷽
		staticrecipe[1925]={recipe_id=5418,recipe_group=0,recipe_level=1,recipe_type=5}	---�컪_�����䷽
		staticrecipe[1926]={recipe_id=5419,recipe_group=0,recipe_level=1,recipe_type=5}	---�컪_�����䷽
		staticrecipe[1927]={recipe_id=5420,recipe_group=0,recipe_level=1,recipe_type=5}	---�컪_�ﻪ�䷽
		staticrecipe[1928]={recipe_id=5421,recipe_group=0,recipe_level=1,recipe_type=5}	---�컪_�챦�䷽
		staticrecipe[1929]={recipe_id=5422,recipe_group=0,recipe_level=1,recipe_type=5}	---�컪_�˽��䷽
		staticrecipe[1930]={recipe_id=5423,recipe_group=0,recipe_level=1,recipe_type=5}	---�컪_����䷽
		staticrecipe[1931]={recipe_id=5424,recipe_group=0,recipe_level=1,recipe_type=5}	---�컪_�����䷽
		staticrecipe[1932]={recipe_id=5425,recipe_group=0,recipe_level=1,recipe_type=5}	---�컪_�����䷽
		staticrecipe[1933]={recipe_id=5426,recipe_group=0,recipe_level=1,recipe_type=5}	---�컪_�����䷽
		staticrecipe[1934]={recipe_id=5427,recipe_group=0,recipe_level=1,recipe_type=5}	---�컪_�����䷽
		staticrecipe[1935]={recipe_id=5428,recipe_group=0,recipe_level=1,recipe_type=5}	---�컪_����䷽
		staticrecipe[1936]={recipe_id=5429,recipe_group=0,recipe_level=1,recipe_type=5}	---�컪_�����䷽
		staticrecipe[1937]={recipe_id=5430,recipe_group=0,recipe_level=1,recipe_type=5}	---�컪_����䷽
		staticrecipe[1938]={recipe_id=5431,recipe_group=0,recipe_level=1,recipe_type=5}	---�컪_�����䷽
		staticrecipe[1939]={recipe_id=5432,recipe_group=0,recipe_level=1,recipe_type=5}	---�컪_�г��䷽
		staticrecipe[1940]={recipe_id=5433,recipe_group=0,recipe_level=1,recipe_type=5}	---�컪_�����䷽
		staticrecipe[1941]={recipe_id=5434,recipe_group=0,recipe_level=1,recipe_type=5}	---�컪_˷ӯ�䷽
		staticrecipe[1942]={recipe_id=5435,recipe_group=0,recipe_level=1,recipe_type=5}	---�컪_�����䷽
		staticrecipe[1943]={recipe_id=5436,recipe_group=0,recipe_level=1,recipe_type=5}	---�컪_��÷�䷽
		staticrecipe[1944]={recipe_id=5437,recipe_group=0,recipe_level=1,recipe_type=5}	---�컪_�켪�䷽
		staticrecipe[1945]={recipe_id=5438,recipe_group=0,recipe_level=1,recipe_type=5}	---�컪_����䷽
		staticrecipe[1946]={recipe_id=5439,recipe_group=0,recipe_level=1,recipe_type=5}	---�컪_�����䷽
		staticrecipe[1947]={recipe_id=5440,recipe_group=0,recipe_level=1,recipe_type=5}	---�컪_Զ���䷽
		staticrecipe[1948]={recipe_id=5441,recipe_group=0,recipe_level=1,recipe_type=5}	---�컪_�����䷽
		staticrecipe[1949]={recipe_id=5442,recipe_group=0,recipe_level=1,recipe_type=5}	---�컪_�����䷽
		staticrecipe[1950]={recipe_id=5443,recipe_group=0,recipe_level=1,recipe_type=5}	---�컪_�����䷽
		staticrecipe[1951]={recipe_id=5444,recipe_group=0,recipe_level=1,recipe_type=5}	---�컪_�����䷽
		staticrecipe[1952]={recipe_id=5445,recipe_group=0,recipe_level=1,recipe_type=5}	---�컪_�˳��䷽
		staticrecipe[1953]={recipe_id=5446,recipe_group=0,recipe_level=1,recipe_type=5}	---�컪_�����䷽
		staticrecipe[1954]={recipe_id=5447,recipe_group=0,recipe_level=1,recipe_type=5}	---�컪_�����䷽
		staticrecipe[1955]={recipe_id=5448,recipe_group=0,recipe_level=1,recipe_type=5}	---�컪_����䷽
		staticrecipe[1956]={recipe_id=5449,recipe_group=0,recipe_level=1,recipe_type=5}	---�컪_�����䷽
		staticrecipe[1957]={recipe_id=5450,recipe_group=0,recipe_level=1,recipe_type=5}	---�컪_�Ի��䷽
		staticrecipe[1958]={recipe_id=5451,recipe_group=0,recipe_level=1,recipe_type=5}	---�컪_�����䷽
		staticrecipe[1959]={recipe_id=5452,recipe_group=0,recipe_level=1,recipe_type=5}	---�컪_�����䷽
		staticrecipe[1960]={recipe_id=5453,recipe_group=0,recipe_level=1,recipe_type=5}	---�컪_�����䷽
		staticrecipe[1961]={recipe_id=5454,recipe_group=0,recipe_level=1,recipe_type=5}	---�컪_�����䷽
		staticrecipe[1962]={recipe_id=5455,recipe_group=0,recipe_level=1,recipe_type=5}	---�컪_�����䷽
		staticrecipe[1963]={recipe_id=5456,recipe_group=0,recipe_level=1,recipe_type=5}	---�컪_�����䷽
		staticrecipe[1964]={recipe_id=5457,recipe_group=0,recipe_level=1,recipe_type=5}	---��ɨ_�ֵ��䷽
		staticrecipe[1965]={recipe_id=5458,recipe_group=0,recipe_level=1,recipe_type=5}	---����_�����䷽
		staticrecipe[1966]={recipe_id=5459,recipe_group=0,recipe_level=1,recipe_type=5}	---����_�����䷽
		staticrecipe[1967]={recipe_id=5460,recipe_group=0,recipe_level=1,recipe_type=5}	---����_�����䷽
		staticrecipe[1968]={recipe_id=5461,recipe_group=0,recipe_level=1,recipe_type=5}	---����_�����䷽
		staticrecipe[1969]={recipe_id=5462,recipe_group=0,recipe_level=1,recipe_type=5}	---���_�����䷽
		staticrecipe[1970]={recipe_id=5463,recipe_group=0,recipe_level=1,recipe_type=5}	---����_Ы���䷽
		staticrecipe[1971]={recipe_id=5464,recipe_group=0,recipe_level=1,recipe_type=5}	---����_Ӱ���䷽
		staticrecipe[1972]={recipe_id=5465,recipe_group=0,recipe_level=1,recipe_type=5}	---����_ȱ���䷽
		staticrecipe[1973]={recipe_id=5466,recipe_group=0,recipe_level=1,recipe_type=5}	---����_�罫�䷽
		staticrecipe[1974]={recipe_id=5467,recipe_group=0,recipe_level=1,recipe_type=5}	---ΡΡ_��Ȼ�䷽
		staticrecipe[1975]={recipe_id=5468,recipe_group=0,recipe_level=1,recipe_type=5}	---֪��_����䷽
		staticrecipe[1976]={recipe_id=5469,recipe_group=0,recipe_level=1,recipe_type=5}	---����_����䷽
		staticrecipe[1977]={recipe_id=5470,recipe_group=0,recipe_level=1,recipe_type=5}	---����_˷ӯ�䷽
		staticrecipe[1978]={recipe_id=5471,recipe_group=0,recipe_level=1,recipe_type=5}	---�г�_�켪�䷽
		staticrecipe[1979]={recipe_id=5472,recipe_group=0,recipe_level=1,recipe_type=5}	---����_�����䷽
		staticrecipe[1980]={recipe_id=5473,recipe_group=0,recipe_level=1,recipe_type=5}	---�Ի�_�����䷽
		staticrecipe[1981]={recipe_id=5474,recipe_group=0,recipe_level=1,recipe_type=5}	---����_�˳��䷽
		staticrecipe[1982]={recipe_id=5507,recipe_group=0,recipe_level=1,recipe_type=5}	---̫�_��ħ�䷽
		staticrecipe[1983]={recipe_id=5508,recipe_group=0,recipe_level=1,recipe_type=5}	---̫�_��Ԩ�䷽
		staticrecipe[1984]={recipe_id=5509,recipe_group=0,recipe_level=1,recipe_type=5}	---̫�_�����䷽
		staticrecipe[1985]={recipe_id=5510,recipe_group=0,recipe_level=1,recipe_type=5}	---̫�_����䷽
		staticrecipe[1986]={recipe_id=5511,recipe_group=0,recipe_level=1,recipe_type=5}	---̫�_�����䷽
		staticrecipe[1987]={recipe_id=5512,recipe_group=0,recipe_level=1,recipe_type=5}	---̫�_�����䷽
		staticrecipe[1988]={recipe_id=5513,recipe_group=0,recipe_level=1,recipe_type=5}	---̫�_�����䷽
		staticrecipe[1989]={recipe_id=5514,recipe_group=0,recipe_level=1,recipe_type=5}	---̫�_�����䷽
		staticrecipe[1990]={recipe_id=5515,recipe_group=0,recipe_level=1,recipe_type=5}	---̫�_����䷽
		staticrecipe[1991]={recipe_id=5516,recipe_group=0,recipe_level=1,recipe_type=5}	---̫�_�����䷽
		staticrecipe[1992]={recipe_id=5517,recipe_group=0,recipe_level=1,recipe_type=5}	---̫�_�����䷽
		staticrecipe[1993]={recipe_id=5518,recipe_group=0,recipe_level=1,recipe_type=5}	---̫�_�����䷽
		staticrecipe[1994]={recipe_id=5519,recipe_group=0,recipe_level=1,recipe_type=5}	---̫�_ӯ���䷽
		staticrecipe[1995]={recipe_id=5520,recipe_group=0,recipe_level=1,recipe_type=5}	---̫�_�����䷽
		staticrecipe[1996]={recipe_id=5521,recipe_group=0,recipe_level=1,recipe_type=5}	---̫�_�����䷽
		staticrecipe[1997]={recipe_id=5522,recipe_group=0,recipe_level=1,recipe_type=5}	---̫�_ս���䷽
		staticrecipe[1998]={recipe_id=5523,recipe_group=0,recipe_level=1,recipe_type=5}	---̫�_����䷽
		staticrecipe[1999]={recipe_id=5524,recipe_group=0,recipe_level=1,recipe_type=5}	---̫�_ս���䷽
		staticrecipe[2000]={recipe_id=5525,recipe_group=0,recipe_level=1,recipe_type=5}	---̫�_�����䷽
		staticrecipe[2001]={recipe_id=5526,recipe_group=0,recipe_level=1,recipe_type=5}	---̫�_�ƻ��䷽
		staticrecipe[2002]={recipe_id=5527,recipe_group=0,recipe_level=1,recipe_type=5}	---̫�_�����䷽
		staticrecipe[2003]={recipe_id=5528,recipe_group=0,recipe_level=1,recipe_type=5}	---̫�_��ħ�䷽
		staticrecipe[2004]={recipe_id=5529,recipe_group=0,recipe_level=1,recipe_type=5}	---̫�_�����䷽
		staticrecipe[2005]={recipe_id=5530,recipe_group=0,recipe_level=1,recipe_type=5}	---̫�_�����䷽
		staticrecipe[2006]={recipe_id=5531,recipe_group=0,recipe_level=1,recipe_type=5}	---̫�_��ڣ�䷽
		staticrecipe[2007]={recipe_id=5532,recipe_group=0,recipe_level=1,recipe_type=5}	---̫�_�ֻ��䷽
		staticrecipe[2008]={recipe_id=5533,recipe_group=0,recipe_level=1,recipe_type=5}	---̫�_��˷�䷽
		staticrecipe[2009]={recipe_id=5534,recipe_group=0,recipe_level=1,recipe_type=5}	---̫�_İ·�䷽
		staticrecipe[2010]={recipe_id=5535,recipe_group=0,recipe_level=1,recipe_type=5}	---̫�_ͽ���䷽
		staticrecipe[2011]={recipe_id=5536,recipe_group=0,recipe_level=1,recipe_type=5}	---̫�_�׻��䷽
		staticrecipe[2012]={recipe_id=5537,recipe_group=0,recipe_level=1,recipe_type=5}	---̫�_�����䷽
		staticrecipe[2013]={recipe_id=5538,recipe_group=0,recipe_level=1,recipe_type=5}	---̫�_����䷽
		staticrecipe[2014]={recipe_id=5539,recipe_group=0,recipe_level=1,recipe_type=5}	---̫�_�����䷽
		staticrecipe[2015]={recipe_id=5540,recipe_group=0,recipe_level=1,recipe_type=5}	---̫�_�콾�䷽
		staticrecipe[2016]={recipe_id=5541,recipe_group=0,recipe_level=1,recipe_type=5}	---̫�_����䷽
		staticrecipe[2017]={recipe_id=5542,recipe_group=0,recipe_level=1,recipe_type=5}	---̫�_�����䷽
		staticrecipe[2018]={recipe_id=5543,recipe_group=0,recipe_level=1,recipe_type=5}	---̫�_�ɸ��䷽
		staticrecipe[2019]={recipe_id=5544,recipe_group=0,recipe_level=1,recipe_type=5}	---̫�_�����䷽
		staticrecipe[2020]={recipe_id=5545,recipe_group=0,recipe_level=1,recipe_type=5}	---̫�_�����䷽
		staticrecipe[2021]={recipe_id=5546,recipe_group=0,recipe_level=1,recipe_type=5}	---̫�_�����䷽
		staticrecipe[2022]={recipe_id=5547,recipe_group=0,recipe_level=1,recipe_type=5}	---̫�_�����䷽
		staticrecipe[2023]={recipe_id=5548,recipe_group=0,recipe_level=1,recipe_type=5}	---̫�_�̼��䷽
		staticrecipe[2024]={recipe_id=5549,recipe_group=0,recipe_level=1,recipe_type=5}	---̫�_�����䷽
		staticrecipe[2025]={recipe_id=5550,recipe_group=0,recipe_level=1,recipe_type=5}	---̫�_����䷽
		staticrecipe[2026]={recipe_id=5551,recipe_group=0,recipe_level=1,recipe_type=5}	---̫�_����䷽
		staticrecipe[2027]={recipe_id=5552,recipe_group=0,recipe_level=1,recipe_type=5}	---̫�_�����䷽
		staticrecipe[2028]={recipe_id=5553,recipe_group=0,recipe_level=1,recipe_type=5}	---̫�_�����䷽
		staticrecipe[2029]={recipe_id=5554,recipe_group=0,recipe_level=1,recipe_type=5}	---̫�_�����䷽
		staticrecipe[2030]={recipe_id=5555,recipe_group=0,recipe_level=1,recipe_type=5}	---̫�_����䷽
		staticrecipe[2031]={recipe_id=5556,recipe_group=0,recipe_level=1,recipe_type=5}	---̫�_�����䷽
		staticrecipe[2032]={recipe_id=5557,recipe_group=0,recipe_level=1,recipe_type=5}	---̫�_��ħ�䷽
		staticrecipe[2033]={recipe_id=5558,recipe_group=0,recipe_level=1,recipe_type=5}	---���_�����䷽
		staticrecipe[2034]={recipe_id=5559,recipe_group=0,recipe_level=1,recipe_type=5}	---���_�����䷽
		staticrecipe[2035]={recipe_id=5560,recipe_group=0,recipe_level=1,recipe_type=5}	---���_�ƻ��䷽
		staticrecipe[2036]={recipe_id=5561,recipe_group=0,recipe_level=1,recipe_type=5}	---����_�콾�䷽
		staticrecipe[2037]={recipe_id=5562,recipe_group=0,recipe_level=1,recipe_type=5}	---��ڣ_����䷽
		staticrecipe[2038]={recipe_id=5563,recipe_group=0,recipe_level=1,recipe_type=5}	---�ֻ�_�����䷽
		staticrecipe[2039]={recipe_id=5564,recipe_group=0,recipe_level=1,recipe_type=5}	---�ɸ�_�����䷽
		staticrecipe[2040]={recipe_id=5565,recipe_group=0,recipe_level=1,recipe_type=5}	---����_�����䷽
		staticrecipe[2041]={recipe_id=5566,recipe_group=0,recipe_level=1,recipe_type=5}	---����_�̼��䷽
		staticrecipe[2042]={recipe_id=5567,recipe_group=0,recipe_level=1,recipe_type=5}	---����_�����䷽
		staticrecipe[2043]={recipe_id=5568,recipe_group=0,recipe_level=1,recipe_type=5}	---����_����䷽
		staticrecipe[2044]={recipe_id=5569,recipe_group=0,recipe_level=1,recipe_type=5}	---����_ӫ���䷽
		staticrecipe[2045]={recipe_id=5570,recipe_group=0,recipe_level=1,recipe_type=5}	---����_�����䷽
		staticrecipe[2046]={recipe_id=5571,recipe_group=0,recipe_level=1,recipe_type=5}	---����_�����䷽
		staticrecipe[2047]={recipe_id=5572,recipe_group=0,recipe_level=1,recipe_type=5}	---����_�����䷽
		staticrecipe[2048]={recipe_id=5573,recipe_group=0,recipe_level=1,recipe_type=5}	---����_˸���䷽
		staticrecipe[2049]={recipe_id=5574,recipe_group=0,recipe_level=1,recipe_type=5}	---����_ݱ���䷽
		staticrecipe[2050]={recipe_id=5575,recipe_group=0,recipe_level=1,recipe_type=5}	---����_ȼ���䷽
		staticrecipe[2051]={recipe_id=5576,recipe_group=0,recipe_level=1,recipe_type=5}	---����_�����䷽
		staticrecipe[2052]={recipe_id=5577,recipe_group=0,recipe_level=1,recipe_type=5}	---����_�����䷽
		staticrecipe[2053]={recipe_id=5578,recipe_group=0,recipe_level=1,recipe_type=5}	---����_�����䷽
		staticrecipe[2054]={recipe_id=5579,recipe_group=0,recipe_level=1,recipe_type=5}	---����_����䷽
		staticrecipe[2055]={recipe_id=5580,recipe_group=0,recipe_level=1,recipe_type=5}	---����_����䷽
		staticrecipe[2056]={recipe_id=5581,recipe_group=0,recipe_level=1,recipe_type=5}	---����_����䷽
		staticrecipe[2057]={recipe_id=5582,recipe_group=0,recipe_level=1,recipe_type=5}	---����_����䷽
		staticrecipe[2058]={recipe_id=5583,recipe_group=0,recipe_level=1,recipe_type=5}	---����_��ɽ�䷽
		staticrecipe[2059]={recipe_id=5584,recipe_group=0,recipe_level=1,recipe_type=5}	---����_׿���䷽
		staticrecipe[2060]={recipe_id=5585,recipe_group=0,recipe_level=1,recipe_type=5}	---����_�����䷽
		staticrecipe[2061]={recipe_id=5586,recipe_group=0,recipe_level=1,recipe_type=5}	---����_��ִ�䷽
		staticrecipe[2062]={recipe_id=5587,recipe_group=0,recipe_level=1,recipe_type=5}	---����_�����䷽
		staticrecipe[2063]={recipe_id=5588,recipe_group=0,recipe_level=1,recipe_type=5}	---����_�����䷽
		staticrecipe[2064]={recipe_id=5589,recipe_group=0,recipe_level=1,recipe_type=5}	---����_����䷽
		staticrecipe[2065]={recipe_id=5590,recipe_group=0,recipe_level=1,recipe_type=5}	---����_��б�䷽
		staticrecipe[2066]={recipe_id=5591,recipe_group=0,recipe_level=1,recipe_type=5}	---����_�����䷽
		staticrecipe[2067]={recipe_id=5592,recipe_group=0,recipe_level=1,recipe_type=5}	---����_����䷽
		staticrecipe[2068]={recipe_id=5593,recipe_group=0,recipe_level=1,recipe_type=5}	---����_Ԫ���䷽
		staticrecipe[2069]={recipe_id=5594,recipe_group=0,recipe_level=1,recipe_type=5}	---����_ƥ���䷽
		staticrecipe[2070]={recipe_id=5595,recipe_group=0,recipe_level=1,recipe_type=5}	---����_��а�䷽
		staticrecipe[2071]={recipe_id=5596,recipe_group=0,recipe_level=1,recipe_type=5}	---����_˪���䷽
		staticrecipe[2072]={recipe_id=5597,recipe_group=0,recipe_level=1,recipe_type=5}	---����_Ƽ���䷽
		staticrecipe[2073]={recipe_id=5598,recipe_group=0,recipe_level=1,recipe_type=5}	---����_�����䷽
		staticrecipe[2074]={recipe_id=5599,recipe_group=0,recipe_level=1,recipe_type=5}	---����_����䷽
		staticrecipe[2075]={recipe_id=5600,recipe_group=0,recipe_level=1,recipe_type=5}	---����_�����䷽
		staticrecipe[2076]={recipe_id=5601,recipe_group=0,recipe_level=1,recipe_type=5}	---����_�����䷽
		staticrecipe[2077]={recipe_id=5602,recipe_group=0,recipe_level=1,recipe_type=5}	---����_�޺��䷽
		staticrecipe[2078]={recipe_id=5603,recipe_group=0,recipe_level=1,recipe_type=5}	---����_�����䷽
		staticrecipe[2079]={recipe_id=5604,recipe_group=0,recipe_level=1,recipe_type=5}	---����_��ɽ�䷽
		staticrecipe[2080]={recipe_id=5605,recipe_group=0,recipe_level=1,recipe_type=5}	---����_�����䷽
		staticrecipe[2081]={recipe_id=5606,recipe_group=0,recipe_level=1,recipe_type=5}	---����_�����䷽
		staticrecipe[2082]={recipe_id=5607,recipe_group=0,recipe_level=1,recipe_type=5}	---����_�����䷽
		staticrecipe[2083]={recipe_id=5608,recipe_group=0,recipe_level=1,recipe_type=5}	---����_�����䷽
		staticrecipe[2084]={recipe_id=5609,recipe_group=0,recipe_level=1,recipe_type=5}	---����_�ٺ��䷽
		staticrecipe[2085]={recipe_id=5610,recipe_group=0,recipe_level=1,recipe_type=5}	---����_�۳��䷽
		staticrecipe[2086]={recipe_id=5611,recipe_group=0,recipe_level=1,recipe_type=5}	---����_�����䷽
		staticrecipe[2087]={recipe_id=5612,recipe_group=0,recipe_level=1,recipe_type=5}	---����_�����䷽
		staticrecipe[2088]={recipe_id=5613,recipe_group=0,recipe_level=1,recipe_type=5}	---����_�����䷽
		staticrecipe[2089]={recipe_id=5614,recipe_group=0,recipe_level=1,recipe_type=5}	---����_����䷽
		staticrecipe[2090]={recipe_id=5615,recipe_group=0,recipe_level=1,recipe_type=5}	---����_�����䷽
		staticrecipe[2091]={recipe_id=5616,recipe_group=0,recipe_level=1,recipe_type=5}	---����_¾���䷽
		staticrecipe[2092]={recipe_id=5617,recipe_group=0,recipe_level=1,recipe_type=5}	---����_�޵��䷽
		staticrecipe[2093]={recipe_id=5618,recipe_group=0,recipe_level=1,recipe_type=5}	---ȼ��_�����䷽
		staticrecipe[2094]={recipe_id=5619,recipe_group=0,recipe_level=1,recipe_type=5}	---����_�����䷽
		staticrecipe[2095]={recipe_id=5620,recipe_group=0,recipe_level=1,recipe_type=5}	---���_����䷽
		staticrecipe[2096]={recipe_id=5621,recipe_group=0,recipe_level=1,recipe_type=5}	---���_Ԫ���䷽
		staticrecipe[2097]={recipe_id=5622,recipe_group=0,recipe_level=1,recipe_type=5}	---׿��_�����䷽
		staticrecipe[2098]={recipe_id=5623,recipe_group=0,recipe_level=1,recipe_type=5}	---ƥ��_˪���䷽
		staticrecipe[2099]={recipe_id=5624,recipe_group=0,recipe_level=1,recipe_type=5}	---����_�����䷽
		staticrecipe[2100]={recipe_id=5625,recipe_group=0,recipe_level=1,recipe_type=5}	---�ٺ�_�����䷽
		staticrecipe[2101]={recipe_id=5626,recipe_group=0,recipe_level=1,recipe_type=5}	---����_����䷽
		staticrecipe[2102]={recipe_id=4550,recipe_group=0,recipe_level=8,recipe_type=1}
		staticrecipe[2103]={recipe_id=4551,recipe_group=0,recipe_level=9,recipe_type=1}
		staticrecipe[2104]={recipe_id=4552,recipe_group=0,recipe_level=10,recipe_type=1}
		staticrecipe[2105]={recipe_id=4560,recipe_group=0,recipe_level=8,recipe_type=3}
		staticrecipe[2106]={recipe_id=4561,recipe_group=0,recipe_level=9,recipe_type=3}
		staticrecipe[2107]={recipe_id=4562,recipe_group=0,recipe_level=10,recipe_type=3}
		staticrecipe[2108]={recipe_id=4626,recipe_group=0,recipe_level=8,recipe_type=3}
		staticrecipe[2109]={recipe_id=4627,recipe_group=0,recipe_level=9,recipe_type=3}
		staticrecipe[2110]={recipe_id=4628,recipe_group=0,recipe_level=10,recipe_type=3}
		staticrecipe[2111]={recipe_id=4692,recipe_group=0,recipe_level=8,recipe_type=4}
		staticrecipe[2112]={recipe_id=4693,recipe_group=0,recipe_level=9,recipe_type=4}
		staticrecipe[2113]={recipe_id=4694,recipe_group=0,recipe_level=10,recipe_type=4}
		staticrecipe[2114]={recipe_id=4758,recipe_group=0,recipe_level=8,recipe_type=4}
		staticrecipe[2115]={recipe_id=4759,recipe_group=0,recipe_level=9,recipe_type=4}
		staticrecipe[2116]={recipe_id=4760,recipe_group=0,recipe_level=10,recipe_type=4}
		staticrecipe[2117]={recipe_id=4824,recipe_group=0,recipe_level=8,recipe_type=2}
		staticrecipe[2118]={recipe_id=4825,recipe_group=0,recipe_level=9,recipe_type=2}
		staticrecipe[2119]={recipe_id=4826,recipe_group=0,recipe_level=10,recipe_type=2}
		staticrecipe[2120]={recipe_id=4890,recipe_group=0,recipe_level=8,recipe_type=2}
		staticrecipe[2121]={recipe_id=4891,recipe_group=0,recipe_level=9,recipe_type=2}
		staticrecipe[2122]={recipe_id=4892,recipe_group=0,recipe_level=10,recipe_type=2}
		staticrecipe[2123]={recipe_id=4956,recipe_group=0,recipe_level=8,recipe_type=1}
		staticrecipe[2124]={recipe_id=4957,recipe_group=0,recipe_level=9,recipe_type=1}
		staticrecipe[2125]={recipe_id=4958,recipe_group=0,recipe_level=10,recipe_type=1}
		staticrecipe[2126]={recipe_id=4966,recipe_group=0,recipe_level=8,recipe_type=3}
		staticrecipe[2127]={recipe_id=4967,recipe_group=0,recipe_level=9,recipe_type=3}
		staticrecipe[2128]={recipe_id=4968,recipe_group=0,recipe_level=10,recipe_type=3}
		staticrecipe[2129]={recipe_id=5032,recipe_group=0,recipe_level=8,recipe_type=3}
		staticrecipe[2130]={recipe_id=5033,recipe_group=0,recipe_level=9,recipe_type=3}
		staticrecipe[2131]={recipe_id=5034,recipe_group=0,recipe_level=10,recipe_type=3}
		staticrecipe[2132]={recipe_id=5098,recipe_group=0,recipe_level=8,recipe_type=4}
		staticrecipe[2133]={recipe_id=5099,recipe_group=0,recipe_level=9,recipe_type=4}
		staticrecipe[2134]={recipe_id=5100,recipe_group=0,recipe_level=10,recipe_type=4}
		staticrecipe[2135]={recipe_id=5164,recipe_group=0,recipe_level=8,recipe_type=4}
		staticrecipe[2136]={recipe_id=5165,recipe_group=0,recipe_level=9,recipe_type=4}
		staticrecipe[2137]={recipe_id=5166,recipe_group=0,recipe_level=10,recipe_type=4}
		staticrecipe[2138]={recipe_id=5230,recipe_group=0,recipe_level=8,recipe_type=2}
		staticrecipe[2139]={recipe_id=5231,recipe_group=0,recipe_level=9,recipe_type=2}
		staticrecipe[2140]={recipe_id=5232,recipe_group=0,recipe_level=10,recipe_type=2}
		staticrecipe[2141]={recipe_id=5296,recipe_group=0,recipe_level=8,recipe_type=2}
		staticrecipe[2142]={recipe_id=5297,recipe_group=0,recipe_level=9,recipe_type=2}
		staticrecipe[2143]={recipe_id=5298,recipe_group=0,recipe_level=10,recipe_type=2}
		staticrecipe[2144]={recipe_id=5642,recipe_group=0,recipe_level=8,recipe_type=1}
		staticrecipe[2145]={recipe_id=5643,recipe_group=0,recipe_level=9,recipe_type=1}
		staticrecipe[2146]={recipe_id=5644,recipe_group=0,recipe_level=10,recipe_type=1}
		staticrecipe[2147]={recipe_id=5659,recipe_group=0,recipe_level=8,recipe_type=3}
		staticrecipe[2148]={recipe_id=5660,recipe_group=0,recipe_level=8,recipe_type=3}
		staticrecipe[2149]={recipe_id=5661,recipe_group=0,recipe_level=9,recipe_type=3}
		staticrecipe[2150]={recipe_id=5662,recipe_group=0,recipe_level=9,recipe_type=3}
		staticrecipe[2151]={recipe_id=5663,recipe_group=0,recipe_level=10,recipe_type=3}
		staticrecipe[2152]={recipe_id=5664,recipe_group=0,recipe_level=10,recipe_type=3}
		staticrecipe[2153]={recipe_id=5679,recipe_group=0,recipe_level=8,recipe_type=2}
		staticrecipe[2154]={recipe_id=5680,recipe_group=0,recipe_level=8,recipe_type=2}
		staticrecipe[2155]={recipe_id=5681,recipe_group=0,recipe_level=9,recipe_type=2}
		staticrecipe[2156]={recipe_id=5682,recipe_group=0,recipe_level=9,recipe_type=2}
		staticrecipe[2157]={recipe_id=5683,recipe_group=0,recipe_level=10,recipe_type=2}
		staticrecipe[2158]={recipe_id=5684,recipe_group=0,recipe_level=10,recipe_type=2}
		staticrecipe[2159]={recipe_id=5699,recipe_group=0,recipe_level=8,recipe_type=4}
		staticrecipe[2160]={recipe_id=5700,recipe_group=0,recipe_level=8,recipe_type=4}
		staticrecipe[2161]={recipe_id=5701,recipe_group=0,recipe_level=9,recipe_type=4}
		staticrecipe[2162]={recipe_id=5702,recipe_group=0,recipe_level=9,recipe_type=4}
		staticrecipe[2163]={recipe_id=5703,recipe_group=0,recipe_level=10,recipe_type=4}
		staticrecipe[2164]={recipe_id=5704,recipe_group=0,recipe_level=10,recipe_type=4}
		staticrecipe[2165]={recipe_id=5712,recipe_group=0,recipe_level=8,recipe_type=1}
		staticrecipe[2166]={recipe_id=5713,recipe_group=0,recipe_level=9,recipe_type=1}
		staticrecipe[2167]={recipe_id=5714,recipe_group=0,recipe_level=10,recipe_type=1}
		staticrecipe[2168]={recipe_id=5729,recipe_group=0,recipe_level=8,recipe_type=3}
		staticrecipe[2169]={recipe_id=5730,recipe_group=0,recipe_level=8,recipe_type=3}
		staticrecipe[2170]={recipe_id=5731,recipe_group=0,recipe_level=9,recipe_type=3}
		staticrecipe[2171]={recipe_id=5732,recipe_group=0,recipe_level=9,recipe_type=3}
		staticrecipe[2172]={recipe_id=5733,recipe_group=0,recipe_level=10,recipe_type=3}
		staticrecipe[2173]={recipe_id=5734,recipe_group=0,recipe_level=10,recipe_type=3}
		staticrecipe[2174]={recipe_id=5749,recipe_group=0,recipe_level=8,recipe_type=2}
		staticrecipe[2175]={recipe_id=5750,recipe_group=0,recipe_level=8,recipe_type=2}
		staticrecipe[2176]={recipe_id=5751,recipe_group=0,recipe_level=9,recipe_type=2}
		staticrecipe[2177]={recipe_id=5752,recipe_group=0,recipe_level=9,recipe_type=2}
		staticrecipe[2178]={recipe_id=5753,recipe_group=0,recipe_level=10,recipe_type=2}
		staticrecipe[2179]={recipe_id=5754,recipe_group=0,recipe_level=10,recipe_type=2}
		staticrecipe[2180]={recipe_id=5769,recipe_group=0,recipe_level=8,recipe_type=4}
		staticrecipe[2181]={recipe_id=5770,recipe_group=0,recipe_level=8,recipe_type=4}
		staticrecipe[2182]={recipe_id=5771,recipe_group=0,recipe_level=9,recipe_type=4}
		staticrecipe[2183]={recipe_id=5772,recipe_group=0,recipe_level=9,recipe_type=4}
		staticrecipe[2184]={recipe_id=5773,recipe_group=0,recipe_level=10,recipe_type=4}
		staticrecipe[2185]={recipe_id=5774,recipe_group=0,recipe_level=10,recipe_type=4}


	return staticrecipe
end 
---//************************************************************************************************- 
---//************************************************************************************************-  
---//************************************************************************************************- 
---//************************************************************************************************- 
---//���ﲶ׽���ֿ�ʼ--------------------------------------------------------------------------------
---//��������������ж�------------------------------------------------------------------------------
function ZCatchIsAvailableMonsRace(monster_raceinfo)
	if monster_raceinfo>=1 and monster_raceinfo<65536 then 
		return 1
	else
		return 0
	end 	
end 
---//���������Ӧ�Ĳ�׽����id
function ZSkillsOfPetCatch(monster_raceinfo)
	local returnedskillid=0
	local msg_id_whencatch=0		---//��ʱ����
	local catchskilllist={}
		catchskilllist[1]={raceinfo=1,skillid=1971,msg_id=311}				---//����
		catchskilllist[2]={raceinfo=2,skillid=1973,msg_id=312}				---//����
		catchskilllist[3]={raceinfo=4,skillid=1973,msg_id=313}				---//����
		catchskilllist[4]={raceinfo=8,skillid=1971,msg_id=314}				---//����
		catchskilllist[5]={raceinfo=16,skillid=1973,msg_id=315}				---//����
		catchskilllist[6]={raceinfo=32,skillid=1971,msg_id=316}				---//�콫
		catchskilllist[7]={raceinfo=64,skillid=1972,msg_id=317}				---//����
		catchskilllist[8]={raceinfo=128,skillid=1972,msg_id=318}			---//ɽ��
		catchskilllist[9]={raceinfo=256,skillid=1974,msg_id=319}			---//Ұ��
		catchskilllist[10]={raceinfo=512,skillid=1972,msg_id=320}			---//����
		catchskilllist[11]={raceinfo=1024,skillid=1974,msg_id=321}		---//ˮ��
		catchskilllist[12]={raceinfo=2048,skillid=1974,msg_id=322}		---//���
		catchskilllist[13]={raceinfo=4096,skillid=1973,msg_id=323}		---//����
		catchskilllist[14]={raceinfo=8192,skillid=1971,msg_id=324}		---//����
		catchskilllist[15]={raceinfo=16384,skillid=1974,msg_id=325}		---//Ԫ��
		catchskilllist[16]={raceinfo=32768,skillid=1972,msg_id=326}		---//����

	for i,v in pairs(catchskilllist) do
		if monster_raceinfo == v.raceinfo then 
			returnedskillid=v.skillid
			msg_id_whencatch=v.msg_id
		end
	end
	return returnedskillid,msg_id_whencatch
end

---//���ﲶ׽�Ѷȶ��ڲ�׽�ɹ��ʵ�Ӱ��----------------------------------------------------------------
function ZCatchChanceFromDifficulty(monster_catchdifficulty)
	if type(monster_catchdifficulty)~="number" or monster_catchdifficulty<=0 or monster_catchdifficulty>8 then 
		monster_catchdifficulty=9
	end 
	local difficultyratio	={0.95,0.85,0.80,0.75,0.65,0.55,0.45,0.25,0.01}			---//��׽�Ѷȵ��µ��Ѷ�ϵ��
	local difficultyaddexp={1,2,4,8,12,16,24,32,0}														---//��׽�Ѷȵ��µļ�������������
	
	return difficultyratio[monster_catchdifficulty],difficultyaddexp[monster_catchdifficulty]
end 

---//������Ѫ���ڲ�׽�ɹ��ʵ�Ӱ��--------------------------------------------------------------------
function ZCatchChanceFromHP(monster_hp)
	if type(monster_hp)~="number" or monster_hp<=0 or monster_hp>1 then 
		monster_hp=1
	end 
	local hpratio=math.min(math.max(1-0.5*monster_hp*monster_hp,0),1)
	return hpratio
end 

---//������Ｖ�����ڲ�׽�ɹ��ʵ�Ӱ��-----------------------------------------------------------
function ZCatchChanceFromLevels(monster_level,player_level)
	if type(monster_level)~="number" or monster_level<1 or monster_level>150 then 
		monster_level=150
	end 
	if type(player_level)~="number" or player_level<1 or player_level>150 then 
		player_level=1
	end 
	local levelplus=1
	if player_level>monster_level*2 then 
		levelplus=10
	elseif player_level<monster_level*0.5 then 
		levelplus=-10
	else
		levelplus=0
	end 	
	return levelplus
end 

---//���ﲶ׽������---------------------------------------------------------------
function PetBedgeCatch(monster_id, monster_level, monster_raceinfo, monster_catchdifficulty,monster_hp,player_level, player)
	local pet_id,msg_channel,msg_id=0,0,301
	local maincatchskillid=1970				---//��׽����id
	local passive_catch_skillid=0			---//race��Ӧ�ı�����׽��ͨ����id
	local finnalcatchchance=0					---//��׽���ܳɹ���
	local iscatch=0										---//�Ƿ�׽�ɹ�
	local skill_alvl,skill_blvl=0,0		---//������׽��ͨ���ܵļӵ�ȼ����ܵȼ�
	local maxraceinfo=65536						---//�����������ı��(2^16)
	local addskillexp=0								---//��׽���ӵļ���������
	local availablepetlist=ZStaticAvailableMonsterList()
	
	---//2010�����Ⲷ׽������ɺ
	if monster_id==33370 then
		return 33528,0,327
	end
	
	---//����id����ȷ
	if type(monster_id)~="number" or type(monster_raceinfo)~="number" then
	 return pet_id,msg_channel,302
	end 
	---//���Ｖ����ȷ
	if type(monster_level)~="number" or monster_level<1 or monster_level>150 then
	 return pet_id,msg_channel,303
	end 
	---//�������岻��ȷ
	if type(monster_raceinfo)~="number" or monster_raceinfo<=0 or monster_raceinfo>maxraceinfo or ZCatchIsAvailableMonsRace(monster_raceinfo)==0 then
	 return pet_id,msg_channel,304
	end 	
	---//ģ���в�׽ϵ������ȷ���߲����Բ�׽
	if type(monster_catchdifficulty)~="number" or monster_catchdifficulty<=0 or monster_catchdifficulty>8 then
	 return pet_id,msg_channel,305
	end 	
	---//��Ѫ����������,����50%
	if type(monster_hp)~="number" or monster_hp<=0 or monster_hp>0.5 then
	 return pet_id,msg_channel,306
	end 	
	---//��Ҽ��𴫵ݴ���
	if type(player_level)~="number" or player_level<=0 or player_level>150 then
	 return pet_id,msg_channel,307
	end 	

	passive_catch_skillid,msg_id=ZSkillsOfPetCatch(monster_raceinfo)
	skill_alvl,skill_blvl=player:PlayerQuerySkilllvl(passive_catch_skillid)
	
	---//�Ѷȵ��µĲ�׽���ӣ��Ѷȵ��µ����Ӽ�������
	local difficultyratio,addexpifcatch=ZCatchChanceFromDifficulty(monster_catchdifficulty)
	---//����HP�������µĲ�׽����
	local HPratio=ZCatchChanceFromHP(monster_hp)
	---//�˺͹��Ｖ���µĲ�׽�ӳ�/˥��
	local leveldiffplus=ZCatchChanceFromLevels(monster_level,player_level)
	finnalcatchchance=(0.6*skill_alvl*skill_alvl+5*skill_alvl+10)*difficultyratio*HPratio+leveldiffplus
	iscatch=ZMiscThrowDice(finnalcatchchance)
	if iscatch==1 then 
		for i,v in pairs(availablepetlist) do
			if v.monster_id==monster_id then 
				pet_id=v.pet_id
			end 
		end 
		player:AddSkillProficiency(passive_catch_skillid,addexpifcatch) 
		player:AddSkillProficiency(maincatchskillid,10) 
	else
		pet_id=0
		msg_id=309
		addskillexp=0
		player:AddSkillProficiency(maincatchskillid,1) 
	end 
		return pet_id,msg_channel,msg_id
end
---//���ﲶ׽���ֽ���-------------------------------------------------------------------------------- 
---//************************************************************************************************- 
---//************************************************************************************************- 
---//************************************************************************************************- 
---//************************************************************************************************- 
---//����ר�����ֿ�ʼ-------------------------------------------------------------------------------- 
---//����䷽�Ļ���������Ϣ--------------------------------------------------------------------------
function ZRecipeGetProps(recipe_id)
	if type(recipe_id)~="number" then
	 return 0,0,401
	end 	
	local recipe_group=99				---//0,����������1,�������� ,99-error
	local recipe_level=99				---//�䷽�ȼ�1-10,99-error
	local recipe_type=99				---//1,����������2�����·���3����ñ�ӣ�4����Ь�ӣ�5����������
															---//11 �������,99-error
	local recipelist=ZStaticRecipeList()
	for i,v in pairs(recipelist) do
		if v.recipe_id == recipe_id then 
			recipe_group=v.recipe_group 
			recipe_level=v.recipe_level
			recipe_type=v.recipe_type
		end
	end
	if recipe_group~=1 and recipe_group~=0 then recipe_group=99 end   	
	if recipe_level<1 or recipe_level>10 then recipe_level=99 end  
	if recipe_type~=1 and recipe_type~=2 and recipe_type~=3 and recipe_type~=4 and recipe_type~=5 and recipe_type~=11 then recipe_type=99 end 												
	return recipe_group,recipe_level,recipe_type
end 
---//����䷽��Ӧ�ļ��ܵȼ���Ϣ--------------------------------------------------------------------------
function ZSkillsOfRecipes(recipe_type,recipe_id,player_level,iscreteinuniqueplace)
	if recipe_type==99 or type(recipe_type)~="number" then return 0 end 
	local re_skill_1,re_skill_2,re_skill_3,re_skill_4=0,0,0,0
	local recipeskilllist={}
		if iscreteinuniqueplace==1 then 
			recipeskilllist[1]={recipe_type=1,skillid_1=1979,skillid_2=389,skillid_3=389,skillid_4=389}
			recipeskilllist[2]={recipe_type=2,skillid_1=1980,skillid_2=389,skillid_3=389,skillid_4=389}
			recipeskilllist[3]={recipe_type=3,skillid_1=1981,skillid_2=389,skillid_3=389,skillid_4=389}
			recipeskilllist[4]={recipe_type=4,skillid_1=1982,skillid_2=389,skillid_3=389,skillid_4=389}
			recipeskilllist[5]={recipe_type=5,skillid_1=1984,skillid_2=389,skillid_3=389,skillid_4=389}
			recipeskilllist[6]={recipe_type=11,skillid_1=1983,skillid_2=389,skillid_3=389,skillid_4=389}
		else
			recipeskilllist[1]={recipe_type=1,skillid_1=1979,skillid_2=389,skillid_3=389,skillid_4=389}
			recipeskilllist[2]={recipe_type=2,skillid_1=1980,skillid_2=389,skillid_3=389,skillid_4=389}
			recipeskilllist[3]={recipe_type=3,skillid_1=1981,skillid_2=389,skillid_3=389,skillid_4=389}
			recipeskilllist[4]={recipe_type=4,skillid_1=1982,skillid_2=389,skillid_3=389,skillid_4=389}
			recipeskilllist[5]={recipe_type=5,skillid_1=1984,skillid_2=389,skillid_3=389,skillid_4=389}
			recipeskilllist[6]={recipe_type=11,skillid_1=1983,skillid_2=389,skillid_3=389,skillid_4=389}
		end 	
	for i,v in pairs(recipeskilllist) do
		if recipe_type == v.recipe_type then 
			re_skill_1=v.skillid_1
			re_skill_2=v.skillid_2
			re_skill_3=v.skillid_3
			re_skill_4=v.skillid_4
		end
	end
	return re_skill_1,re_skill_2,re_skill_3,re_skill_4	

end 
---//����䷽��������Ĳ�����Ϣ-------------------------------------------------------------------------
function ZStaticRecipeExtItems(recipe_group,recipe_level,recipe_type)
	local recipeextlist={}
	local recipeextchance={}
	if recipe_group==0 and recipe_level<8 and recipe_type~=5 then 
		return 0,0
	end
	
	if recipe_group==0 then					---//��������
			recipeextlist={30185,30186,30187,30188,30189}
			if recipe_level==8 then 
				recipeextchance={27000,18000,9000,1000,100}		
			elseif recipe_level==9 then
				recipeextchance={27000,18000,9000,2000,200}			
			elseif recipe_level==10 then
				recipeextchance={27000,18000,9000,3000,300}					
			else 
				recipeextchance={27000,18000,9000,100,100}				
			end 
	elseif recipe_group==1 then 		---//��������
			recipeextlist={30190,30191,30192,30193,30194}
			if recipe_level==1 then
				recipeextchance={27000,18000,9000,1000,100}
			elseif recipe_level==2 then
				recipeextchance={27000,18000,9000,2000,200}
			elseif recipe_level==3 then
				recipeextchance={27000,18000,9000,200,50}
			else
				recipeextchance={27000,18000,9000,100,100}
			end 							
	else
			recipeextlist={0,0,0,0,0}
			recipeextchance={100,100,100,100,100}
	end 	

		return recipeextlist[ZMiscGetRanPoint(recipeextchance)],1
end

---//������ö������������--------------------------------------------------------------------------
function ExtGainOfCreate(recipe_id, player_level, player_gender, player_prof, player)
	local item_id=0											---//������Ʒid
	local item_count=0									---//������Ʒ����
	local msg_id=401										---//��ʾ��Ϣ	
	local discover_type,create_type=0,1	---//������ʱ��discover_typeĬ��Ϊ0������create_type��Ĭ��Ϊ1

	if type(recipe_id)~="number" or type(player_level)~="number" or player_level<0 or player_level>150 then
	 return item_id,item_count,msg_id
	end 	
	
	local withskill_1,withskill_2,withskill_3,withskill_4=0,0,0,0			---//��Ӧ����,����ĸ�
	local finnalrecipechance=0																				---//������Ʒ����
	local iscreteinuniqueplace=0																			---//�Ƿ�����ض�����			
	local uniqueitem=0						
	local uniquecount=0				
	local skill_alvl1,skill_blvl1=0,0
	local skill_alvl2,skill_blvl2=0,0
	local skill_alvl3,skill_blvl3=0,0
	local skill_alvl4,skill_blvl4=0,0
	
	local recipe_group,recipe_level,recipe_type=0,1,1
	---//0,����������1,�������� ,99-error
	---//�䷽�ȼ�1-10,99-error
	---//1,����������2�����·���3����ñ�ӣ�4����Ь�ӣ�5������
	---//11 �������,99-error
	local maps_id,maps_x,maps_y,maps_z=0,0,0,0
	---//��ͼ��Ϣ
	
	maps_id,maps_x,maps_y,maps_z=player:PlayerQueryPosition()
	uniqueitem,uniquecount=ZMiscFindInAreas(discover_type,create_type,maps_id,maps_x,maps_y,maps_z,recipe_id)

	if uniqueitem>0 and uniquecount>0 then 	iscreteinuniqueplace=1 end 
	
	recipe_group,recipe_level,recipe_type=ZRecipeGetProps(recipe_id)
	withskill_1,withskill_2,withskill_3,withskill_4=ZSkillsOfRecipes(recipe_type,recipe_id,player_level,iscreteinuniqueplace)
	skill_alvl1,skill_blvl1=player:PlayerQuerySkilllvl(withskill_1)
	skill_alvl2,skill_blvl2=player:PlayerQuerySkilllvl(withskill_2)
	skill_alvl3,skill_blvl3=player:PlayerQuerySkilllvl(withskill_3)
	skill_alvl4,skill_blvl4=player:PlayerQuerySkilllvl(withskill_4)
	
	local finnalrecipechance=0				---//�Ƿ��ж������
	local passive_create_skillid=0		---//���������ȵļ���
	local addskillexp=0								---//���ӵ�������
	---//��������ֻ��һ��������ʹ��
	finnalrecipechance=6*skill_alvl1+15
	if recipe_group==99 or recipe_level==99 or recipe_type==99 then finnalrecipechance=0 end
	
	if ZMiscThrowDice(finnalrecipechance)==1 then 
			if iscreteinuniqueplace==1 then 
					item_id,item_count=ZMiscFindInAreas(discover_type,create_type,maps_id,maps_x,maps_y,maps_z,recipe_id)
			else
					item_id,item_count=ZStaticRecipeExtItems(recipe_group,recipe_level,recipe_type)
					player:AddSkillProficiency(withskill_1,1) 
			end 	
			msg_id=402
	else

			msg_id=403
	end 
		return item_id,item_count,msg_id

end 
---//����ר�����ֽ���-------------------------------------------------------------------------------- 
---//************************************************************************************************- 
---//************************************************************************************************- 
---//************************************************************************************************- 
---//************************************************************************************************- 
---//̽Ѱϵͳ���ֿ�ʼ-------------------------------------------------------------------------------- 
---//��ͼ�����������
function ZStaticAreaDrops(discover_type,create_type)
	local areamiscitems={}
	---//discover and create ���õ�������(if create need sometimes)
	---//��ͼid,maps_id,-1�������Ƶ�ͼ
	---//�Ƿ��ռ����(���˵��Ƕ�ռ�㣬��ռ������������Ƕ�ռ��)
	---//������ʼ�㣬������ֹ��(����--->����)
	---//������Ʒ��id��������Ʒ���������ޣ�������Ʒ����������
	---//����(����������������һ����������32(maxitemslist)��
	---//�䷽id,create������������
	if discover_type==1 and create_type==0 then 
		areamiscitems[1]={maps_id=1,is_unique=0,maps_x1=-400,maps_y1=-400,maps_z1=-400,maps_x2=400,maps_y2=400,maps_z2=400,item_id=16812,item_count1=1,item_count2=3,dicovery_chance=100,recipe_id=-1}
		areamiscitems[2]={maps_id=1,is_unique=0,maps_x1=-400,maps_y1=-400,maps_z1=-400,maps_x2=400,maps_y2=400,maps_z2=400,item_id=16813,item_count1=1,item_count2=3,dicovery_chance=100,recipe_id=-1}
		areamiscitems[3]={maps_id=1,is_unique=0,maps_x1=-400,maps_y1=-400,maps_z1=-400,maps_x2=400,maps_y2=400,maps_z2=400,item_id=16814,item_count1=1,item_count2=3,dicovery_chance=100,recipe_id=-1}
		areamiscitems[4]={maps_id=1,is_unique=0,maps_x1=0,maps_y1=-400,maps_z1=-400,maps_x2=400,maps_y2=400,maps_z2=400,item_id=16815,item_count1=1,item_count2=3,dicovery_chance=100,recipe_id=-1}
		areamiscitems[5]={maps_id=1,is_unique=0,maps_x1=0,maps_y1=-400,maps_z1=-400,maps_x2=400,maps_y2=400,maps_z2=400,item_id=16816,item_count1=1,item_count2=3,dicovery_chance=100,recipe_id=-1}
		areamiscitems[6]={maps_id=1,is_unique=0,maps_x1=0,maps_y1=-400,maps_z1=-400,maps_x2=400,maps_y2=400,maps_z2=400,item_id=16817,item_count1=1,item_count2=3,dicovery_chance=100,recipe_id=-1}
		areamiscitems[7]={maps_id=-1,is_unique=0,maps_x1=-400,maps_y1=-400,maps_z1=-400,maps_x2=400,maps_y2=400,maps_z2=400,item_id=16830,item_count1=1,item_count2=3,dicovery_chance=100,recipe_id=-1}
	elseif discover_type==2 and create_type==0 then
		areamiscitems[1]={maps_id=2,is_unique=0,maps_x1=-400,maps_y1=-400,maps_z1=-400,maps_x2=400,maps_y2=400,maps_z2=400,item_id=16823,item_count1=1,item_count2=3,dicovery_chance=100,recipe_id=-1}
		areamiscitems[2]={maps_id=3,is_unique=0,maps_x1=-400,maps_y1=-400,maps_z1=-400,maps_x2=400,maps_y2=400,maps_z2=400,item_id=16824,item_count1=1,item_count2=3,dicovery_chance=100,recipe_id=-1}
		areamiscitems[3]={maps_id=4,is_unique=0,maps_x1=-400,maps_y1=-400,maps_z1=-400,maps_x2=400,maps_y2=400,maps_z2=400,item_id=16825,item_count1=1,item_count2=3,dicovery_chance=100,recipe_id=-1}
	elseif create_type==0 and discover_type>2 then 
		areamiscitems[1]={maps_id=2,is_unique=0,maps_x1=-400,maps_y1=-400,maps_z1=-400,maps_x2=400,maps_y2=400,maps_z2=400,item_id=0,item_count1=0,item_count2=0,dicovery_chance=100,recipe_id=-1}
		areamiscitems[2]={maps_id=3,is_unique=0,maps_x1=-400,maps_y1=-400,maps_z1=-400,maps_x2=400,maps_y2=400,maps_z2=400,item_id=0,item_count1=0,item_count2=0,dicovery_chance=100,recipe_id=-1}
		areamiscitems[3]={maps_id=4,is_unique=0,maps_x1=-400,maps_y1=-400,maps_z1=-400,maps_x2=400,maps_y2=400,maps_z2=400,item_id=0,item_count1=0,item_count2=0,dicovery_chance=100,recipe_id=-1}
		areamiscitems[4]={maps_id=4,is_unique=1,maps_x1=200,maps_y1=-400,maps_z1=200,maps_x2=400,maps_y2=400,maps_z2=400,item_id=0,item_count1=0,item_count2=0,dicovery_chance=100,recipe_id=-1}
	end 
	
	if discover_type==0 and create_type==1 then
		areamiscitems[1]={maps_id=1,is_unique=0,maps_x1=-400,maps_y1=-400,maps_z1=-400,maps_x2=400,maps_y2=400,maps_z2=400,item_id=685,item_count1=1,item_count2=3,dicovery_chance=100,recipe_id=-1}
		areamiscitems[2]={maps_id=1,is_unique=0,maps_x1=-400,maps_y1=-400,maps_z1=-400,maps_x2=400,maps_y2=400,maps_z2=400,item_id=685,item_count1=1,item_count2=3,dicovery_chance=100,recipe_id=-1}
		areamiscitems[3]={maps_id=1,is_unique=0,maps_x1=-400,maps_y1=-400,maps_z1=-400,maps_x2=400,maps_y2=400,maps_z2=400,item_id=685,item_count1=1,item_count2=3,dicovery_chance=100,recipe_id=-1}
		areamiscitems[4]={maps_id=1,is_unique=0,maps_x1=-400,maps_y1=-400,maps_z1=-400,maps_x2=400,maps_y2=400,maps_z2=400,item_id=685,item_count1=1,item_count2=3,dicovery_chance=100,recipe_id=-1}
	end 	
	
	return areamiscitems
end 
---//��ͬ̽�����Ͷ�Ӧ�ı�������id
function ZSkillsOfDiscovery(discover_type)
	local re_skill_1,re_skill_2,re_skill_3,re_skill_4=0,0,0,0
	---//һ��̽�������������ĸ��������
	local discoveryskilllist={}
		discoveryskilllist[1]={discover_type=1,skill_id1=218,skill_id2=219,skill_id3=220,skill_id4=221}
		discoveryskilllist[2]={discover_type=2,skill_id1=218,skill_id2=219,skill_id3=220,skill_id4=221}
	for i,v in pairs(discoveryskilllist) do
		if discover_type == v.discover_type then 
			re_skill_1=v.skill_id1
			re_skill_2=v.skill_id2
			re_skill_3=v.skill_id3
			re_skill_4=v.skill_id4
		end
	end
	return re_skill_1,re_skill_2,re_skill_3,re_skill_4
end
---//̽Ѱ��ö������������--------------------------------------------------------------------------
function DiscoveryGain(player_level, player_gender, player_prof,discover_type, player)
	local create_type=0					---discover��ʱ��create_typeĬ��Ϊ0
	local gain_id,item_count,msg_id=0,0,501
	local maps_id,maps_x,maps_y,maps_z=1,100,0,100
	local skill_alvl1,skill_blvl1=0,0
	local skill_alvl2,skill_blvl2=0,0
	local skill_alvl3,skill_blvl3=0,0
	local skill_alvl4,skill_blvl4=0,0
	local isgain=0							---//�Ƿ�ɹ��Ļ������Ʒ
	maps_id,maps_x,maps_y,maps_z=player:PlayerQueryPosition()
	
	
	local withskill_1,withskill_2,withskill_3,withskill_4=0,0,0,0
	withskill_1,withskill_2,withskill_3,withskill_4= ZSkillsOfDiscovery(discover_type)
	skill_alvl1,skill_blvl1=player:PlayerQuerySkilllvl(withskill_1)
	skill_alvl2,skill_blvl2=player:PlayerQuerySkilllvl(withskill_2)
	skill_alvl3,skill_blvl3=player:PlayerQuerySkilllvl(withskill_3)
	skill_alvl4,skill_blvl4=player:PlayerQuerySkilllvl(withskill_4)
	
	local finnaldiscoverychance=10*(skill_alvl1+skill_alvl2+skill_alvl3+skill_alvl4)
	
	if ZMiscThrowDice(finnaldiscoverychance)==1 then 
		---//discover_type,create_type,maps_id,maps_x,maps_y,maps_z,recipe_id
		gain_id,item_count=ZMiscFindInAreas(discover_type,create_type,maps_id,maps_x,maps_y,maps_z,0)
		
		msg_id=502
	
	else
		msg_id=503
	end 	
	return gain_id, item_count, msg_id
end 


---//̽Ѱϵͳ���ֽ���-------------------------------------------------------------------------------- 

-----//�����ԽӵĽӿ�
-----
---PetBedgeCatch(monster_id, monster_level, monster_raceinfo, monster_catchdifficulty, monster_hp, player_level);
---ExtGainOfCreate(recipe_id, player_level,player_gender, player_prof);
---DiscoveryGain(player_level, player_gender, player_prof,discover_type);
---player_gender: 0 - Ů  1-��
---PlayerQuerySkilllvl(skill_id) 
---PlayerQueryPosition()

---//���ú������ֿ�ʼ------------------------------------------------------------------------------
---//�ɹ���roll---------------------------------------------------------
function ZMiscThrowDice(chance)
	if type(chance)~="number" or chance<=0 then 
		chance=0
	end 
	if chance>100 then chance=100 end 
	local zrollresult=0
	local zrolldice= math.random()*100   
	if zrolldice<chance and zrolldice~=0 then 
		zrollresult=1
	else 
		zrollresult=0
	end 
	return zrollresult
end 
---//���һ��num1-num2֮�������----------------------------------
function ZMiscRandomNumber(num1,num2)
	if num2<0 or num1<0 then return 0 end 
	if num1==num2 then return num1 end 
	return math.min(num1,num2)+math.floor(math.random()*math.abs(num1-num2)) 
end 	

---//�ж��Ƿ��ڹ涨������----------------------------------
function ZMiscIsInAreas(x0,y0,z0,x1,y1,z1,x2,y2,z2)
	if x0>=x1 and x0<=x2 and y0>=y1 and y0<=y2 and z0>=z1 and z0<=z2 then 
		return 1
	elseif x0<=x1 and x0>=x2 and y0<=y1 and y0>=y2 and z0<=z1 and z0>=z2 then 
		return 1
	else 
		return 0
	end 
end 

---//�ڻ���������GetMisc----------------------------------
function ZMiscFindInAreas(discover_type,create_type,maps_id,maps_x,maps_y,maps_z,recipe_id)
	local maxitemslist=32		---//���һ������32�ֵ���
	local existuniquearea=0	---//����unique��������
	local itemdroplist={}

	for i=1,maxitemslist do
		itemdroplist[i]={is_unique=0,item_id=0,item_count=0,dicovery_chance=0}
	end 
	local extdropitems=ZStaticAreaDrops(discover_type,create_type)
	local nowitemlist=0		---//���еĵ�������
		
	
	---//�ռ����������ĵ�ͼ������Ϣ
	---//discover type 
	if discover_type~=0 and create_type==0 then 
		for i,v in pairs(extdropitems) do
			if (maps_id == v.maps_id or v.maps_id==-1) and ZMiscIsInAreas(maps_x,maps_y,maps_z,v.maps_x1,v.maps_y1,v.maps_z1,v.maps_x2,v.maps_y2,v.maps_z2)==1 
				and nowitemlist<=32 then 
				
				nowitemlist=nowitemlist+1
				itemdroplist[nowitemlist].is_unique=v.is_unique
				if itemdroplist[nowitemlist].is_unique>0 then existuniquearea=1 end 
				itemdroplist[nowitemlist].item_id=v.item_id
				itemdroplist[nowitemlist].item_count=ZMiscRandomNumber(v.item_count1,v.item_count2)
				itemdroplist[nowitemlist].dicovery_chance=math.max(v.dicovery_chance,0)
			else
			end
		end
	---//create type
	elseif discover_type==0 and create_type~=0 then
		
			for i,v in pairs(extdropitems) do
			if (maps_id == v.maps_id or v.maps_id==-1) and ZMiscIsInAreas(maps_x,maps_y,maps_z,v.maps_x1,v.maps_y1,v.maps_z1,v.maps_x2,v.maps_y2,v.maps_z2)==1 
				and nowitemlist<=32  and recipe_id==v.recipe_id then 
				nowitemlist=nowitemlist+1
				itemdroplist[nowitemlist].is_unique=v.is_unique
				if itemdroplist[nowitemlist].is_unique>0 then existuniquearea=1 end 
				itemdroplist[nowitemlist].item_id=v.item_id
				itemdroplist[nowitemlist].item_count=ZMiscRandomNumber(v.item_count1,v.item_count2)
				itemdroplist[nowitemlist].dicovery_chance=math.max(v.dicovery_chance,0)
			else
			end
		end	
	else 
		return 0,0
	end 	 	

	---//�������unique_area�����
	if existuniquearea>0 then 
		for i,v in pairs(itemdroplist) do
			if v.is_unique==0 then 
				v.dicovery_chance=0
			end 
		end
	end 
	
	---//���ʵ��Ӳ�ѡȡһ��������
	local finnalposition=-1				---//����ѡȡ�ĵ���id��listid
	local sumchances={}				
	for m=0,maxitemslist-1 do
		sumchances[0]=0
		sumchances[m+1]=sumchances[m]+itemdroplist[m+1].dicovery_chance
	end 
	local randomchance=math.max(math.min(math.random()*sumchances[maxitemslist],sumchances[maxitemslist]),1)
	for k=0,maxitemslist-1 do 
			if randomchance>sumchances[k] and randomchance<=sumchances[k+1] then 
				finnalposition=k+1
			end 
	end 
	
	---//���ؽ��
	if finnalposition<=0 or finnalposition>maxitemslist then
		return 0,0
	else
		return itemdroplist[finnalposition].item_id,itemdroplist[finnalposition].item_count
	end
	
end 
----���ּ�����̬��--------------------------------------------------------------
function ZMiscNormChance(n1)
	local n1_size=table.getn(n1)
	local Total_Chance=0
	local i,m,k
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
-------------------------------------------------------------------------------- 

----���ճ��ָ������Ӧ��ѡȡ��λ��----------------------------------------------
function ZMiscGetRanPoint(s1)
	local js,ron1
	ron1= math.random()                
  local p1=ZMiscNormChance(s1)
	for js=1,table.getn(p1) do
          if ron1<=p1[js] then 
    	  		return js
		  		end
	end
	return 1
end