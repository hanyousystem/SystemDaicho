namespace systeminventory_sample.Models.DbFirst;

public partial class inHouseSystem_Gaisei
{

    public string? ID { get; set; }
    public string? Kubun { get; set; }
    public string? SystemName { get; set; }
    public string? Gaiyo { get; set; }
    public string? ShukanKashitsu { get; set; }
    public string? Sekinin_Shozoku { get; set; }
    public string? Sekinin_Name { get; set; }
    public string? Renraku_Shozoku { get; set; }
    public string? Renraku_Name { get; set; }
    public string? Renraku_Naisen { get; set; }
    public string? UnyoKaishi { get; set; }
    public string? JikiKoukai { get; set; }
    public string? User_Center { get; set; }
    public string? User_Kyoku { get; set; }
    public string? User_Seifu { get; set; }
    public string? User_Localgovernment { get; set; }
    public string? User_Ippan { get; set; }
    public string? System_Coope { get; set; }
    public string? Kibo_Cnt { get; set; }
    public string? Kibo_PV { get; set; }
    public string? InfoType_Kimitsu3 { get; set; }
    public string? InfoType_Kimitsu2 { get; set; }
    public string? InfoType_Kanzen2 { get; set; }
    public string? InfoType_Kayo2 { get; set; }
    public string? Toriatsukaiseigen { get; set; }
    public string? Kojin_Toriatsukai { get; set; }
    public string? Kojin_Tokutei { get; set; }
    public string? SystemType { get; set; }
    public string? Dev_Way { get; set; }
    public string? Dev_Other { get; set; }
    public string? App_LOC { get; set; }
    public string? App_GamenCnt { get; set; }
    public string? App_ChohyoCnt { get; set; }
    public string? Server_BaseCnt { get; set; }
    public string? Server_BackupCnt { get; set; }
    public string? Server_Cnt { get; set; }
    public string? LineType_IE { get; set; }
    public string? LineType_SeifuNW { get; set; }
    public string? LineType_SINET { get; set; }
    public string? LineType_LGWIN { get; set; }
    public string? LineType_Other { get; set; }
    public string? PackageName { get; set; }
    public string? PackageDev { get; set; }
    public string? CloudService_UserUmu { get; set; }
    public string? CloudService_SeviceName { get; set; }
    public string? CloudService_Jigyosha { get; set; }
    public string? CloudService_ServiceKigyo { get; set; }
    public string? CloudService_Gaiyo { get; set; }
    public string? CloudService_Start { get; set; }
    public string? CloudService_End { get; set; }
    public string? CloudService_DomainName { get; set; }
    public string? CloudService_Kimitsu3 { get; set; }
    public string? CloudService_Kimitsu2 { get; set; }
    public string? CloudService_Kanzen2 { get; set; }
    public string? CloudService_Kayo2 { get; set; }
    public string? CloudService_Toriatsukai { get; set; }
    public string? CloudService_Schedule { get; set; }
    public string? MokuhyoRate { get; set; }
    public string? Donyu_Jigyosha { get; set; }
    public string? Donyu_Jiki { get; set; }
    public string? Donyu_Price { get; set; }
    public string? Hoshu_Jigyosha { get; set; }
    public string? Hoshu_Start { get; set; }
    public string? Hoshu_End { get; set; }
    public string? Hoshu_Price { get; set; }
    public string? Hoshu_SameDonyu { get; set; }
    public string? Unyo_Jigyosha { get; set; }
    public string? Unyo_Start { get; set; }
    public string? Unyo_End { get; set; }
    public string? Unyo_Price { get; set; }
    public string? Unyo_SameDonyu { get; set; }
    public string? Unyo_SameHoshu { get; set; }

    public Boolean isDelete { get; set; }

}
