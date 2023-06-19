using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using systeminventory_sample.Models.DbFirst;

namespace inHouseSystem.Controllers;

// APIコントローラーを示す属性
// APIコントローラーとは：httpからのリクエストを受け取り、httpのレスポンスで返すオブジェクト
[ApiController]
// ルートURLの指定
[Route("[Controller]")]

public class inHouseSystemController : ControllerBase
{
    // データベースコンテキストの設定
    private readonly inHouseDbContext _context;

    public inHouseSystemController(inHouseDbContext context)
    {
        _context = context;
    }

    // GETリクエストに対するアクションメソッドの指定

    [HttpGet]
    public async Task<ActionResult<IEnumerable<inHouseSystems>>> GetSystems()
    {
        var data = await _context.Systems.ToListAsync();
        return data;

    }

    // GETリクエストに対するアクションメソッドの指定
    [HttpGet("{id}")]

    public async Task<ActionResult<inHouseSystems>> GetSystem(string id)
    {
        var data = await _context.Systems.FindAsync(id);
        return data;

    }


    // PUTリクエストに対するアクションメソッドの指定
    [HttpPut("{id}")]
    public async Task<IActionResult> PutSystem(string id, systeminventory_sample.Models.DbFirst.inHouseSystems system)
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
    public async Task<ActionResult<systeminventory_sample.Models.DbFirst.inHouseSystems>> PostSystem(systeminventory_sample.Models.DbFirst.inHouseSystems system)
    {
        // システムをデータベースに追加
        _context.Systems.Add(system);
        // 変更をデータベースに保存
        await _context.SaveChangesAsync();
        // 追加したシステムを返す
        return CreatedAtAction(nameof(GetSystems), new { id = system.ID }, system);
    }

}

public class alldata
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
