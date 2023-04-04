using System;
using System.Collections.Generic;

namespace systeminventory_sample.Models.DbFirst;

public partial class inHouseSystem
{
    
    public string? ID { get; set; }
    public string? Kubun  { get; set; }
    public string? SystemName { get; set; }   
    public string? Gaiyo { get; set; }
    public string? ShukanKashitsu { get; set; }
    public string? Sekinin_Shozoku { get; set; }   
    public string? Sekinin_Name { get; set; }
    public string? Renraku_Shozoku { get; set; }
    public string? Renraku_Name { get; set; }   
    public string? Renraku_Naisen { get; set; }
    public string? SysType_ProgressSys { get; set; }
    public string? SysType_ChkSys { get; set; }   
    public string? SysType_ChkSupportSys { get; set; }
    public string? SysType_CrtSys { get; set; }
    public string? SysType_Kobetsu { get; set; }   
    public string? SysType_Summary { get; set; }
    public string? SysType_HanyoSummary { get; set; }
    public string? SysType_DBSummary { get; set; }
    public string? SysType_Shinsa { get; set; }   
    public string? SysType_Adam { get; set; }
    public string? SysType_Other { get; set; }
    public string? DevKaihatsu_PGMCnt_VBNet { get; set; }   
    public string? DevKaihatsu_PGMCnt_CSharp { get; set; }
    public string? DevKaihatsu_PGMCnt_VBA { get; set; }
    public string? DevKaihatsu_PGMCnt_Access { get; set; }   
    public string? DevKaihatsu_PGMCnt_R { get; set; }
    public string? DevKaihatsu_PGMCnt_Other { get; set; }
    public string? DevKaihatsu_LOC_VBNET { get; set; }   
    public string? DevKaihatsu_LOC_CSharp { get; set; }
    public string? DevKaihatsu_LOC_VBA { get; set; }
    public string? DevShisa_PGMCnt_VBNET { get; set; }   
    public string? DevShisa_PGMCnt_CSharp { get; set; }
    public string? DevShisa_PGMCnt_VBA { get; set; }
    public string? DevShisa_PGMCnt_Access { get; set; }   
    public string? DevShisa_PGMCnt_R { get; set; }
    public string? DevShisa_PGMCnt_Other { get; set; }
    public string? DevShisa_LOC_VBNET { get; set; }   
    public string? DevShisa_LOC_Csharp { get; set; }
    public string? DevShisa_LOC_VBA { get; set; }   
    public string? DevOther_PGMCnt_VBNET { get; set; }
    public string? DevOther_PGMCnt_CSharp { get; set; }
    public string? DevOther_PGMCnt_VBA { get; set; }   
    public string? DevOther_PGMCnt_Access { get; set; }
    public string? DevOther_PGMCnt_R { get; set; }
    public string? DevOther_PGMCnt_Other { get; set; }   
    public string? DevOther_LOC_VBNET { get; set; }
    public string? DevOther_LOC_CSharp { get; set; }
    public string? DevOther_LOC_VBA { get; set; }   
    public string? User_Center { get; set; }
    public string? User_Kyoku { get; set; }
    public string? User_OtherSeifu { get; set; }   
    public string? User_Localgovernment { get; set; }
    public string? User_Ippan { get; set; }
    public string? SysConfig { get; set; }   
    public string? LineType_IE { get; set; }
    public string? LineType_SeifuNW { get; set; }
    public string? LineType_SINET { get; set; }   
    public string? LineType_LGWIN { get; set; }
    public string? LineType_Other { get; set; }
    public string? InfoType_Kimitsu3 { get; set; }   
    public string? InfoType_Kimitsu2 { get; set; }
    public string? InfoType_Kanzen2 { get; set; }
    public string? InfoType_Kayo2 { get; set; }   
    public string? HandlingInfoLimit { get; set; }
    public string? ChosaKibo_ChosaCnt { get; set; }
    public string? ChosaKibo_ChkCnt { get; set; }   
    public string? ChosaKibo_ListCnt { get; set; }
    public string? ChosaKibo_KekkahyoCnt { get; set; }
}
