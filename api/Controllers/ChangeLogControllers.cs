using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using systeminventory_sample.Models.DbFirst;

namespace inHouseSystem.Controllers;
[ApiController]
// ルートURLの指定
[Route("[Controller]")]

public class ChangeLogController : ControllerBase
{
    private readonly inHouseDbContext? _context;

    public ChangeLogController(inHouseDbContext context)
    {
        _context = context;
    }

    [HttpPost]
    public async Task<IActionResult> PostLog(ChangeLog log)
    {
        // システムをデータベースに追加
        _context.ChangeLogs.Add(log);
        // 変更をデータベースに保存
        await _context.SaveChangesAsync();
        // 追加したシステムを返す

        return NoContent();
    }
    [HttpGet]
    public async Task<ActionResult<IEnumerable<ChangeLog>>> GetLog()
    {
        return _context.ChangeLogs.ToList();

    }

    [HttpGet("userid")]
    public UserID GetUserID()
    {
        return new UserID { userID = "aaaa" };
    }

    [HttpGet("userad/{id}")]

    public UserAD GetUserAD(string id)
    {
        return new UserAD
        {
            seubsectionID = "N33333",
            sectionName = "情報システム課",
            userID = id,
            mailAddress = "mail"
        };
    }


}


