using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using systeminventory_sample.Models.DbFirst;

namespace inHouseSystem.Controllers;

// APIコントローラーを示す属性
// APIコントローラーとは：httpからのリクエストを受け取り、httpのレスポンスで返すオブジェクト
[ApiController]
// ルートURLの指定
[Route("[Controller]")]

public class inHouseSystemController_Gaisei : ControllerBase
{
    // データベースコンテキストの設定
    private readonly inHouseDbContext _context;

    public inHouseSystemController_Gaisei(inHouseDbContext context)
    {
        _context = context;
    }

    // GETリクエストに対するアクションメソッドの指定

    [HttpGet]
    public IEnumerable<alldata_Gaisei> GetSystems()
    {
        var query = from system in _context.Systems_Gaisei
                    select new alldata_Gaisei
                    {
                         ID = system.ID,
                         Kubun = system.Kubun,
                         SystemName = system.SystemName,
                         Gaiyo = system.Gaiyo,
                         ShukanKashitsu = system.ShukanKashitsu,
                         Sekinin_Shozoku = system.Sekinin_Shozoku,
                         Sekinin_Name = system.Sekinin_Name,
                         Renraku_Shozoku = system.Renraku_Shozoku,
                         Renraku_Name = system.Renraku_Name,
                         Renraku_Naisen = system.Renraku_Naisen,
                         SysType = system.SysType,
                         Dev_Scratch = system.Dev_Scratch,
                         Dev_Package = system.Dev_Package,
                         Dev_ScratchPackage = system.Dev_ScratchPackage,
                         Dev_Software = system.Dev_Software,
                         Dev_Other = system.Dev_Other,
                         User_Center = system.User_Center,
                         User_Kyoku = system.User_Kyoku,
                         User_Seifu = system.User_Seifu,
                         User_Localgovernment = system.User_Localgovernment,
                         User_Ippan = system.User_Ippan,
                         LineType_IE = system.LineType_IE,
                         LineType_SeifuNW = system.LineType_SeifuNW,
                         LineType_SINET = system.LineType_SINET,
                         LineType_LGWIN = system.LineType_LGWIN,
                         LineType_Other = system.LineType_Other,
                         InfoType_Kimitsu3 = system.InfoType_Kimitsu3,
                         InfoType_Kimitsu2 = system.InfoType_Kimitsu2,
                         InfoType_Kanzen2 = system.InfoType_Kanzen2,
                         InfoType_Kayo2 = system.InfoType_Kayo2,
                         HandlingInfoLimit = system.HandlingInfoLimit,
                         PackageName = system.PackageName,
                         PackageDevName = system.PackageDevName,
                         RecentIntro_Jigyosha = system.RecentIntro_Jigyosha,
                         RecentIntro_Jiki = system.RecentIntro_Jiki,
                         RecentMainte_Jigyosha = system.RecentMainte_Jigyosha,
                         RecentMainte_Start = system.RecentMainte_Start,
                         RecentMainte_End = system.RecentMainte_End,
                         RecentMainte_Kikan = system.RecentMainte_Kikan,
                         RecentMainte_SameIntro = system.RecentMainte_SameIntro,
                         RecentOpe_Jigyosha = system.RecentOpe_Jigyosha,
                         RecentOpe_Start = system.RecentOpe_Start,
                         RecentOpe_End = system.RecentOpe_End,
                         RecentOpe_Kikan = system.RecentOpe_Kikan,
                         RecentOpe_SameIntro = system.RecentOpe_SameIntro,
                         RecentOpe_SameMainte = system.RecentOpe_SameMainte,
                         CloudService_UserUmu = system.CloudService_UserUmu,
                         CloudService_SeviceName = system.CloudService_SeviceName,
                         CloudService_Jigyosha = system.CloudService_Jigyosha,
                         CloudService_ServiceKigyo = system.CloudService_ServiceKigyo,
                         CloudService_Gaiyo = system.CloudService_Gaiyo,
                         CloudService_Start = system.CloudService_Start,
                         CloudService_End = system.CloudService_End,
                         CloudService_Kikan = system.CloudService_Kikan,
                         CloudService_DomainName = system.CloudService_DomainName,
                         CloudService_Kimitsu3 = system.CloudService_Kimitsu3,
                         CloudService_Kimitsu2 = system.CloudService_Kimitsu2,
                         CloudService_Kanzen2 = system.CloudService_Kanzen2,
                         CloudService_Kayo2 = system.CloudService_Kayo2,
                         CloudService_Limit = system.CloudService_Limit,
                         ScheduleRenew = system.ScheduleRenew
                    };

        return query.ToList();

    }

    // GETリクエストに対するアクションメソッドの指定
    [HttpGet("{id}")]
    public IEnumerable<alldata_Gaisei> GetSystem(string id)
    {
        // 指定されたIDのシステムを取得
        var result = from system in _context.Systems_Gaisei
                     select new alldata_Gaisei
                     {
                         ID = system.ID,
                         Kubun = system.Kubun,
                         SystemName = system.SystemName,
                         Gaiyo = system.Gaiyo,
                         ShukanKashitsu = system.ShukanKashitsu,
                         Sekinin_Shozoku = system.Sekinin_Shozoku,
                         Sekinin_Name = system.Sekinin_Name,
                         Renraku_Shozoku = system.Renraku_Shozoku,
                         Renraku_Name = system.Renraku_Name,
                         Renraku_Naisen = system.Renraku_Naisen,
                         SysType = system.SysType,
                         Dev_Scratch = system.Dev_Scratch,
                         Dev_Package = system.Dev_Package,
                         Dev_ScratchPackage = system.Dev_ScratchPackage,
                         Dev_Software = system.Dev_Software,
                         Dev_Other = system.Dev_Other,
                         User_Center = system.User_Center,
                         User_Kyoku = system.User_Kyoku,
                         User_Seifu = system.User_Seifu,
                         User_Localgovernment = system.User_Localgovernment,
                         User_Ippan = system.User_Ippan,
                         LineType_IE = system.LineType_IE,
                         LineType_SeifuNW = system.LineType_SeifuNW,
                         LineType_SINET = system.LineType_SINET,
                         LineType_LGWIN = system.LineType_LGWIN,
                         LineType_Other = system.LineType_Other,
                         InfoType_Kimitsu3 = system.InfoType_Kimitsu3,
                         InfoType_Kimitsu2 = system.InfoType_Kimitsu2,
                         InfoType_Kanzen2 = system.InfoType_Kanzen2,
                         InfoType_Kayo2 = system.InfoType_Kayo2,
                         HandlingInfoLimit = system.HandlingInfoLimit,
                         PackageName = system.PackageName,
                         PackageDevName = system.PackageDevName,
                         RecentIntro_Jigyosha = system.RecentIntro_Jigyosha,
                         RecentIntro_Jiki = system.RecentIntro_Jiki,
                         RecentMainte_Jigyosha = system.RecentMainte_Jigyosha,
                         RecentMainte_Start = system.RecentMainte_Start,
                         RecentMainte_End = system.RecentMainte_End,
                         RecentMainte_Kikan = system.RecentMainte_Kikan,
                         RecentMainte_SameIntro = system.RecentMainte_SameIntro,
                         RecentOpe_Jigyosha = system.RecentOpe_Jigyosha,
                         RecentOpe_Start = system.RecentOpe_Start,
                         RecentOpe_End = system.RecentOpe_End,
                         RecentOpe_Kikan = system.RecentOpe_Kikan,
                         RecentOpe_SameIntro = system.RecentOpe_SameIntro,
                         RecentOpe_SameMainte = system.RecentOpe_SameMainte,
                         CloudService_UserUmu = system.CloudService_UserUmu,
                         CloudService_SeviceName = system.CloudService_SeviceName,
                         CloudService_Jigyosha = system.CloudService_Jigyosha,
                         CloudService_ServiceKigyo = system.CloudService_ServiceKigyo,
                         CloudService_Gaiyo = system.CloudService_Gaiyo,
                         CloudService_Start = system.CloudService_Start,
                         CloudService_End = system.CloudService_End,
                         CloudService_Kikan = system.CloudService_Kikan,
                         CloudService_DomainName = system.CloudService_DomainName,
                         CloudService_Kimitsu3 = system.CloudService_Kimitsu3,
                         CloudService_Kimitsu2 = system.CloudService_Kimitsu2,
                         CloudService_Kanzen2 = system.CloudService_Kanzen2,
                         CloudService_Kayo2 = system.CloudService_Kayo2,
                         CloudService_Limit = system.CloudService_Limit,
                         ScheduleRenew = system.ScheduleRenew
                     };
        return result;
    }

    // PUTリクエストに対するアクションメソッドの指定
    [HttpPut("{id}")]
    public async Task<IActionResult> PutSystem(string id, inHouseSystem_Gaisei system)
    {
        // IDの不一致をチェック
        if (id != system.ID)
        {
            return BadRequest();
        }
        // データの状態を変更
        _context.Entry(system).State = EntityState.Modified;

        try
        {
            // 変更をデータベースに保存
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            // データの更新に失敗した場合は、IDが一致しない場合はBadRequestを返す
            if (id != system.ID)
            {
                return BadRequest();
            }
            else
            {
                // それ以外の場合は例外をスロー
                throw;
            }
        }
        // 更新が成功した場合は204を返す
        return NoContent();
    }

    // POSTリクエストに対するアクションメソッドの指定
    [HttpPost]
    public async Task<ActionResult<inHouseSystem_Gaisei>> PostSystem(inHouseSystem_Gaisei system)
    {
        // システムをデータベースに追加
        _context.Systems_Gaisei.Add(system);
        // 変更をデータベースに保存
        await _context.SaveChangesAsync();
        // 追加したシステムを返す
        return CreatedAtAction(nameof(GetSystems), new { id = system.ID }, system);
    }

}

public class alldata_Gaisei
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
