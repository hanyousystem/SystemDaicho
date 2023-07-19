using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace systeminventory_sample.Models.DbFirst
{
    // DbContextを継承したinHouseDbContextクラスの定義
    public partial class inHouseDbContext : DbContext
    {
        // コンストラクター
        public inHouseDbContext()
        {
        }

        // コンストラクター
        public inHouseDbContext(DbContextOptions<inHouseDbContext> options)
            : base(options)
        {
        }
        //appsetting.jsonを設定
        public static string ConfigPath { get; set; } = null!;
        // inHouseSystemテーブルに対応するDbSet
        // テーブルを取得⇒列名が同じ名前のプロパティに対してセットを行うため、テーブルの列名がずれていないか確認
        public virtual DbSet<inHouseSystems> Systems { get; set; } = null!;
        // inHouseSystemテーブルに対応するDbSet
        public virtual DbSet<inHouseSystem_Gaisei> Systems_Gaisei { get; set; } = null!;
        public DbSet<ChangeLog> ChangeLogs { get; set; } = null!;
        // SystemCategoryテーブルに対応するDbSet

        // DbContextOptionsBuilderに対しての設定

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ChangeLog>(entity =>
            {
                entity
                    .ToTable("UserOpeLog");
            });

            // inHouseSystemテーブルの定義
            modelBuilder.Entity<inHouseSystems>(entity =>
            {
                entity
                    .ToTable("Naisei"); // inHouseSystemテーブルに対応するテーブル名
            });

            // inHouseSystem_Gaiseiテーブルの定義
            modelBuilder.Entity<inHouseSystem_Gaisei>(entity =>
            {
                entity
                    .ToTable("Gaisei_test"); // inHouseSystemテーブルに対応するテーブル名
            });

            // モデル生成完了時の処理（部分メソッド）
            OnModelCreatingPartial(modelBuilder);
        }

        // OnModelCreatingPartialメソッドの宣言（部分メソッド）
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
