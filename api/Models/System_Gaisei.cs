using System;
using System.Collections.Generic;

namespace systeminventory_sample.Models.DbFirst;

public partial class inHouseSystem_Gaisei
{
    
    public string? ID { get; set; }

    public string? CategoryName { get; set; }

    public string? Name { get; set; }

    public string? Detail { get; set; }

    public string? ProcessName { get; set; }

    public string? Kubun { get; set; }
    public string? SystemName { get; set; }   
    public string? Gaiyo { get; set; }
    public string? ShukanKashitsu { get; set; }
    public string? Sekinin_Shozoku { get; set; }   
    public string? Sekinin_Name { get; set; }
    public string? Renraku_Shozoku { get; set; }
    public string? Renraku_Name { get; set; }   
    public string? Renraku_Naisen { get; set; }
    public string? SysType { get; set; }
    public string? Dev_Scratch { get; set; }   
    public string? Dev_Package { get; set; }
    public string? Dev_ScratchPackage { get; set; }
    public string? Dev_Software { get; set; }   
    public string? Dev_Other { get; set; }
    public string? User_Center { get; set; }
    public string? User_Kyoku { get; set; }
    public string? User_Seifu { get; set; }   
    public string? User_Localgovernment { get; set; }
    public string? User_Ippan { get; set; }
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
    public string? PackageName { get; set; }
    public string? PackageDevName { get; set; }

    public string? RecentIntro_Jigyosha { get; set; }
    public string? RecentIntro_Jiki { get; set; }

    public string? RecentMainte_Jigyosha { get; set; }
    public string? RecentMainte_Start { get; set; }
    public string? RecentMainte_End { get; set; }
    public string? RecentMainte_Kikan { get; set; }
    public string? RecentMainte_SameIntro { get; set; }

    public string? RecentOpe_Jigyosha { get; set; }
    public string? RecentOpe_Start { get; set; }
    public string? RecentOpe_End { get; set; }
    public string? RecentOpe_Kikan { get; set; }
    public string? RecentOpe_SameIntro { get; set; }
    public string? RecentOpe_SameMainte { get; set; }

    public string? CloudService_UserUmu { get; set; }
    public string? CloudService_SeviceName { get; set; }
    public string? CloudService_Jigyosha { get; set; }
    public string? CloudService_ServiceKigyo { get; set; }
    public string? CloudService_Gaiyo { get; set; }
    public string? CloudService_Start { get; set; }
    public string? CloudService_End { get; set; }
    public string? CloudService_Kikan { get; set; }
    public string? CloudService_DomainName { get; set; }
    public string? CloudService_Kimitsu3 { get; set; }   
    public string? CloudService_Kimitsu2 { get; set; }
    public string? CloudService_Kanzen2 { get; set; }
    public string? CloudService_Kayo2 { get; set; }  
    public string? CloudService_Limit { get; set; }  
    public string? ScheduleRenew { get; set; }

}
