import { Component, OnInit, ViewChild, ElementRef } from '@angular/core';
import { ApiserviceService } from 'src/app/apiservice.service';
import { Naisei } from '../Models/Naise';
import { Injectable } from '@angular/core';
import { UserdataService } from 'src/app/userdata.service';
import { max } from 'rxjs';

@Component({
  selector: 'app-show-system',
  templateUrl: './show-system.component.html',
  styleUrls: ['./show-system.component.css']
})
export class ShowSystemComponent implements OnInit {
  SystemList: any = []; // システムリスト
  ModalTitle = ""; // モーダルタイトル
  ActivateAddEditSystemComp: boolean = false; // システム追加・編集のアクティブ状態
  SystemID: string = "";
  SystemIdFilter = ""; // システムIDフィルター
  shukanKashitsuFilter = ""; // システム名フィルター
  SystemListWithoutFilter: any = []; // フィルター前のシステムリスト
  @ViewChild('closebutton') closebutton?: ElementRef;

  ngOnInit(): void {
    this.refreshDepList(); // 初期表示時にシステムリストを更新する
  }

  // システム追加・編集画面のコールバック
  callback(value: string) {
    console.log("callback called");
    if (this.closebutton !== undefined) {
      this.closebutton.nativeElement.click(); // モーダルを閉じる
      this.refreshDepList(); // システムリストを更新する
    } else {
      console.log("closebutton undefined");
    }
  }

  // システムリストを更新する
  refreshDepList() {
    this.service.getSystemList().subscribe(data => {
      this.SystemList = data;
      this.SystemListWithoutFilter = data; // フィルター前のシステムリストを更新する
    });
  }

  // システムリストをソートする
  sortResult(prop: any, asc: any) {
    this.SystemList = this.SystemListWithoutFilter.sort(function (a: any, b: any) {
      if (asc) {
        return (a[prop] > b[prop]) ? 1 : ((a[prop] < b[prop]) ? -1 : 0);
      }
      else {
        return (b[prop] > a[prop]) ? 1 : ((b[prop] < a[prop]) ? -1 : 0);
      }
    });
  }

  // システムリストをフィルターする
  FilterFn() {
    var SystemIdFilter = this.SystemIdFilter;
    var shukanKashitsuFilter = this.shukanKashitsuFilter;

    this.SystemList = this.SystemListWithoutFilter.filter(
      function (el: any) {
        return el.id.toString().toLowerCase().includes(
          SystemIdFilter.toString().trim().toLowerCase()
        ) &&
          el.shukanKashitsu.toString().toLowerCase().includes(
            shukanKashitsuFilter.toString().trim().toLowerCase())
      }
    );
  }

  // システム追加ボタンがクリックされた場合
  addClick() {
    let maxtID = 0;
    for (const item of this.SystemList) {
      const idNumber = parseInt(item.id.slice(1));
      if (maxtID < idNumber) {
        maxtID = idNumber;
      }
    }
    const nextID = `N${(maxtID + 1).toString().padStart(5, '0')}`;
    console.log(nextID);
    this.userdataservice.setUserdata(nextID);

  }
  editClick(SystemID: string) {
    let isIDExit = false;
    let kamei!: string;
    for (const item of this.SystemList) {
      if (item.id == SystemID) {
        isIDExit = true;
        kamei = item.shukanKashitsu;
        break;
      }
    }
    if (!isIDExit) {
      alert("IDが見つかりません");
      return;
    }
    console.log(kamei);
    this.userdataservice.setUserdata(SystemID);
  }
  deleteClick(item: Naisei) {
    if (confirm('削除しますか?')) {
      item.isDelete = true;
      this.service.updateSystem(item).subscribe(data => {
        this.refreshDepList();
      })
    }
  }


  closeClick() {
    this.ActivateAddEditSystemComp = false;
    this.refreshDepList();
  }


  constructor(private service: ApiserviceService, private userdataservice: UserdataService) { }
}
