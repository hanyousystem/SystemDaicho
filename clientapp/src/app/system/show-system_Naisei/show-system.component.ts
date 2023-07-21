import { Component, OnInit, ViewChild, ElementRef } from '@angular/core';
import { ApiserviceService } from 'src/app/apiservice.service';
import { Naisei } from '../Models/Naisei';
import { UserdataService } from 'src/app/userdata.service';
import { UserAD } from '../Models/UserAD';
import { Router } from '@angular/router';
import { Location } from '@angular/common';
import { Log } from '../Models/Logs';
import dayjs from "dayjs";

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
  userAD!: UserAD
  @ViewChild('closebutton') closebutton?: ElementRef;

  ngOnInit(): void {
    this.userdataservice.getUserAD().then(
      data => {
        this.userAD = data;
      }
    )
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
    if (isIDExit && kamei == this.userAD.sectionName.slice(2)) {
      this.userdataservice.setUserdata(SystemID);
      this.router.navigate([`sytem_Naisei/edit/` + SystemID])
    }
    else {
      if (!isIDExit) {
        alert("IDが見つかりません");
        return
      }
      else {
        alert("所属課室のIDを指定してください");
      }
    }
  }
  deleteClick(item: Naisei) {
    if (item.shukanKashitsu != this.userAD.sectionName.slice(2)) {
      alert("所属課室のIDを指定してください。");
      return;
    }
    if (confirm('削除しますか?')) {
      item.isDelete = true;
      //Datetime型だとUTC時刻になってしまうので＋9時間して、日本時刻とする
      const log: Log = {
        userID: this.userAD.userID,
        section: this.userAD.sectionName,
        dateTime: dayjs().format('YYYY-MM-DD HH:mm:ss'),
        operation: '削除',
      };
      this.service.postlog(log);
      this.service.updateSystem(item).subscribe(data => {
        this.refreshDepList();
      })
    }
  }


  closeClick() {
    this.ActivateAddEditSystemComp = false;
    this.refreshDepList();
  }
  goBack(): void {
    this.location.back();
  }

  constructor(
    private service: ApiserviceService,
    private userdataservice: UserdataService,
    private location: Location,
    private router: Router,
  ) { }
}
