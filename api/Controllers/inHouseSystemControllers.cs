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
    [HttpGet("maxid")]
    public async Task<ActionResult<string>> GetMaxID()
    {
        var maxID = await _context.Systems.MaxAsync(s => s.ID);
        return maxID;

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
    public async Task<IActionResult> PostSystem(inHouseSystems system)
    {
        // システムをデータベースに追加
        _context.Systems.Add(system);
        // 変更をデータベースに保存
        await _context.SaveChangesAsync();
        // 追加したシステムを返す

        return NoContent();
    }

}

