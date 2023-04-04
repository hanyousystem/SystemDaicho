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
    public IEnumerable<alldata> GetSystems()
    {
        var query = from system in _context.Systems
                    select new alldata
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
                         SysType_ProgressSys = system.SysType_ProgressSys,
                         SysType_ChkSys = system.SysType_ChkSys,
                         SysType_ChkSupportSys = system.SysType_ChkSupportSys,
                         SysType_CrtSys = system.SysType_CrtSys,
                         SysType_Kobetsu = system.SysType_Kobetsu,
                         SysType_Summary = system.SysType_Summary,
                         SysType_HanyoSummary = system.SysType_HanyoSummary,
                         SysType_DBSummary = system.SysType_DBSummary,
                         SysType_Shinsa = system.SysType_Shinsa,
                         SysType_Adam = system.SysType_Adam,
                         SysType_Other = system.SysType_Other,
                         DevKaihatsu_PGMCnt_VBNet = system.DevKaihatsu_PGMCnt_VBNet,
                         DevKaihatsu_PGMCnt_CSharp = system.DevKaihatsu_PGMCnt_CSharp,
                         DevKaihatsu_PGMCnt_VBA = system.DevKaihatsu_PGMCnt_VBA,
                         DevKaihatsu_PGMCnt_Access = system.DevKaihatsu_PGMCnt_Access,
                         DevKaihatsu_PGMCnt_R = system.DevKaihatsu_PGMCnt_R,
                         DevKaihatsu_PGMCnt_Other = system.DevKaihatsu_PGMCnt_Other,
                         DevKaihatsu_LOC_VBNET = system.DevKaihatsu_LOC_VBNET,
                         DevKaihatsu_LOC_CSharp = system.DevKaihatsu_LOC_CSharp,
                         DevKaihatsu_LOC_VBA = system.DevKaihatsu_LOC_VBA,
                         DevShisa_PGMCnt_VBNET = system.DevShisa_PGMCnt_VBNET,
                         DevShisa_PGMCnt_CSharp = system.DevShisa_PGMCnt_CSharp,
                         DevShisa_PGMCnt_VBA = system.DevShisa_PGMCnt_VBA,
                         DevShisa_PGMCnt_Access = system.DevShisa_PGMCnt_Access,
                         DevShisa_PGMCnt_R = system.DevShisa_PGMCnt_R,
                         DevShisa_PGMCnt_Other = system.DevShisa_PGMCnt_Other,
                         DevShisa_LOC_VBNET = system.DevShisa_LOC_VBNET,
                         DevShisa_LOC_Csharp = system.DevShisa_LOC_Csharp,
                         DevShisa_LOC_VBA = system.DevShisa_LOC_VBA,
                         DevOther_PGMCnt_VBNET = system.DevOther_PGMCnt_VBNET,
                         DevOther_PGMCnt_CSharp = system.DevOther_PGMCnt_CSharp,
                         DevOther_PGMCnt_VBA = system.DevOther_PGMCnt_VBA,
                         DevOther_PGMCnt_Access = system.DevOther_PGMCnt_Access,
                         DevOther_PGMCnt_R = system.DevOther_PGMCnt_R,
                         DevOther_PGMCnt_Other = system.DevOther_PGMCnt_Other,
                         DevOther_LOC_VBNET = system.DevOther_LOC_VBNET,
                         DevOther_LOC_CSharp = system.DevOther_LOC_CSharp,
                         DevOther_LOC_VBA = system.DevOther_LOC_VBA,
                         User_Center = system.User_Center,
                         User_Kyoku = system.User_Kyoku,
                         User_OtherSeifu = system.User_OtherSeifu,
                         User_Localgovernment = system.User_Localgovernment,
                         User_Ippan = system.User_Ippan,
                         SysConfig = system.SysConfig,
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
                         ChosaKibo_ChosaCnt = system.ChosaKibo_ChosaCnt,
                         ChosaKibo_ChkCnt = system.ChosaKibo_ChkCnt,
                         ChosaKibo_ListCnt = system.ChosaKibo_ListCnt,
                         ChosaKibo_KekkahyoCnt = system.ChosaKibo_KekkahyoCnt
                    };

        return query.ToList();

    }

    // GETリクエストに対するアクションメソッドの指定
    [HttpGet("{id}")]
    public IEnumerable<alldata> GetSystem(string id)
    {
        // 指定されたIDのシステムを取得
        var result = from system in _context.Systems
                     select new alldata
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
                         SysType_ProgressSys = system.SysType_ProgressSys,
                         SysType_ChkSys = system.SysType_ChkSys,
                         SysType_ChkSupportSys = system.SysType_ChkSupportSys,
                         SysType_CrtSys = system.SysType_CrtSys,
                         SysType_Kobetsu = system.SysType_Kobetsu,
                         SysType_Summary = system.SysType_Summary,
                         SysType_HanyoSummary = system.SysType_HanyoSummary,
                         SysType_DBSummary = system.SysType_DBSummary,
                         SysType_Shinsa = system.SysType_Shinsa,
                         SysType_Adam = system.SysType_Adam,
                         SysType_Other = system.SysType_Other,
                         DevKaihatsu_PGMCnt_VBNet = system.DevKaihatsu_PGMCnt_VBNet,
                         DevKaihatsu_PGMCnt_CSharp = system.DevKaihatsu_PGMCnt_CSharp,
                         DevKaihatsu_PGMCnt_VBA = system.DevKaihatsu_PGMCnt_VBA,
                         DevKaihatsu_PGMCnt_Access = system.DevKaihatsu_PGMCnt_Access,
                         DevKaihatsu_PGMCnt_R = system.DevKaihatsu_PGMCnt_R,
                         DevKaihatsu_PGMCnt_Other = system.DevKaihatsu_PGMCnt_Other,
                         DevKaihatsu_LOC_VBNET = system.DevKaihatsu_LOC_VBNET,
                         DevKaihatsu_LOC_CSharp = system.DevKaihatsu_LOC_CSharp,
                         DevKaihatsu_LOC_VBA = system.DevKaihatsu_LOC_VBA,
                         DevShisa_PGMCnt_VBNET = system.DevShisa_PGMCnt_VBNET,
                         DevShisa_PGMCnt_CSharp = system.DevShisa_PGMCnt_CSharp,
                         DevShisa_PGMCnt_VBA = system.DevShisa_PGMCnt_VBA,
                         DevShisa_PGMCnt_Access = system.DevShisa_PGMCnt_Access,
                         DevShisa_PGMCnt_R = system.DevShisa_PGMCnt_R,
                         DevShisa_PGMCnt_Other = system.DevShisa_PGMCnt_Other,
                         DevShisa_LOC_VBNET = system.DevShisa_LOC_VBNET,
                         DevShisa_LOC_Csharp = system.DevShisa_LOC_Csharp,
                         DevShisa_LOC_VBA = system.DevShisa_LOC_VBA,
                         DevOther_PGMCnt_VBNET = system.DevOther_PGMCnt_VBNET,
                         DevOther_PGMCnt_CSharp = system.DevOther_PGMCnt_CSharp,
                         DevOther_PGMCnt_VBA = system.DevOther_PGMCnt_VBA,
                         DevOther_PGMCnt_Access = system.DevOther_PGMCnt_Access,
                         DevOther_PGMCnt_R = system.DevOther_PGMCnt_R,
                         DevOther_PGMCnt_Other = system.DevOther_PGMCnt_Other,
                         DevOther_LOC_VBNET = system.DevOther_LOC_VBNET,
                         DevOther_LOC_CSharp = system.DevOther_LOC_CSharp,
                         DevOther_LOC_VBA = system.DevOther_LOC_VBA,
                         User_Center = system.User_Center,
                         User_Kyoku = system.User_Kyoku,
                         User_OtherSeifu = system.User_OtherSeifu,
                         User_Localgovernment = system.User_Localgovernment,
                         User_Ippan = system.User_Ippan,
                         SysConfig = system.SysConfig,
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
                         ChosaKibo_ChosaCnt = system.ChosaKibo_ChosaCnt,
                         ChosaKibo_ChkCnt = system.ChosaKibo_ChkCnt,
                         ChosaKibo_ListCnt = system.ChosaKibo_ListCnt,
                     };
        return result;
    }

    // PUTリクエストに対するアクションメソッドの指定
    [HttpPut("{id}")]
    public async Task<IActionResult> PutSystem(string id, systeminventory_sample.Models.DbFirst.inHouseSystem system)
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
    public async Task<ActionResult<systeminventory_sample.Models.DbFirst.inHouseSystem>> PostSystem(systeminventory_sample.Models.DbFirst.inHouseSystem system)
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
