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
    public async Task<ActionResult<IEnumerable<inHouseSystem_Gaisei>>> GetSystems()
    {
        var data = await _context.Systems_Gaisei.ToListAsync();
        return data;

    }

    // GETリクエストに対するアクションメソッドの指定
    [HttpGet("{id}")]

    public async Task<ActionResult<inHouseSystem_Gaisei>> GetSystem(string id)
    {
        var data = await _context.Systems_Gaisei.FindAsync(id);
        return data;

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
