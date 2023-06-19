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
        //private static IConfiguration Config { get; set; }= null!;
        // public static void configurationInitialize(IConfiguration configuration)
        // {
        //    Config =configuration;
        //}
        // ProcessControlテーブルに対応するDbSet
        public virtual DbSet<ProcessControl> ProcessControls { get; set; } = null!;

        // inHouseSystemテーブルに対応するDbSet
        // テーブルを取得⇒列名が同じ名前のプロパティに対してセットを行うため、テーブルの列名がずれていないか確認
        public virtual DbSet<inHouseSystem> Systems { get; set; } = null!;
        // inHouseSystemテーブルに対応するDbSet
        public virtual DbSet<inHouseSystem_Gaisei> Systems_Gaisei { get; set; } = null!;
        // SystemCategoryテーブルに対応するDbSet
        public virtual DbSet<SystemCategory> SystemCategories { get; set; } = null!;

        // DbContextOptionsBuilderに対しての設定
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // データベース接続文字列の設定
            optionsBuilder.UseSqlite(ConfigPath);
            // optionsBuilder.UseSqlServer(ConfigPath);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // ProcessControlテーブルの定義
            modelBuilder.Entity<ProcessControl>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToTable("ProcessControl"); // ProcessControlテーブルに対応するテーブル名
            });

            // inHouseSystemテーブルの定義
            modelBuilder.Entity<inHouseSystem>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToTable("Naisei"); // inHouseSystemテーブルに対応するテーブル名
            });

            // inHouseSystem_Gaiseiテーブルの定義
            modelBuilder.Entity<inHouseSystem_Gaisei>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToTable("Gaisei"); // inHouseSystemテーブルに対応するテーブル名
            });

            // SystemCategoryテーブルの定義
            modelBuilder.Entity<SystemCategory>(entity =>
            {
                entity.HasNoKey(); // 主キーの定義がないことを設定
            });

            // モデル生成完了時の処理（部分メソッド）
            OnModelCreatingPartial(modelBuilder);
        }

        // OnModelCreatingPartialメソッドの宣言（部分メソッド）
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
