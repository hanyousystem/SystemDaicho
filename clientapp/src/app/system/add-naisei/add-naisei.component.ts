import { Component } from '@angular/core';
import { UserdataService } from 'src/app/userdata.service';
import { ApiserviceService } from 'src/app/apiservice.service';
import { Naisei } from '../Models/Naise';
import { Location } from '@angular/common';
@Component({
  selector: 'app-add-naisei',
  templateUrl: './add-naisei.component.html',
  styleUrls: ['./add-naisei.component.css']
})
export class AddNaiseiComponent {

  SystemList!: Naisei;
  messege: any;
  constructor(
    private userdataservice: UserdataService,
    private apiservice: ApiserviceService,
    private location: Location,
  ) { }
  systemid!: string;
  ngOnInit() {
    this.systemid = this.userdataservice.getUserdata();
    this.SystemList = this.dummyObject;
  }

  addSystem() {
    this.SystemList.id = this.systemid
    console.log(this.SystemList.id);
    this.apiservice.addSystem(this.SystemList).subscribe(
      (Response) => {
        alert("追加しました。");
      },
      (error) => {
        alert("追加に失敗しましたもう一度確認してください。");
      }
    );
  }
  goBack(): void {
    this.location.back();
  }

  dummyObject: Naisei = {
    id: '',
    kubun: '',
    systemName: '',
    gaiyo: '',
    shukanKashitsu: '',
    sekinin_Shozoku: '',
    sekinin_Name: '',
    renraku_Shozoku: '',
    renraku_Name: '',
    renraku_Naisen: '',
    sysType_ProgressSys: '',
    sysType_ChkSys: '',
    sysType_ChkSupportSys: '',
    sysType_CrtSys: '',
    sysType_Kobetsu: '',
    sysType_Summary: '',
    sysType_HanyoSummary: '',
    sysType_DBSummary: '',
    sysType_Shinsa: '',
    sysType_Adam: '',
    sysType_Other: '',
    devKaihatsu_PGMCnt_VBNet: '',
    devKaihatsu_PGMCnt_CSharp: '',
    devKaihatsu_PGMCnt_VBA: '',
    devKaihatsu_PGMCnt_Access: '',
    devKaihatsu_PGMCnt_R: '',
    devKaihatsu_PGMCnt_Other: '',
    devKaihatsu_LOC_VBNET: '',
    devKaihatsu_LOC_CSharp: '',
    devKaihatsu_LOC_VBA: '',
    devShisa_PGMCnt_VBNET: '',
    devShisa_PGMCnt_CSharp: '',
    devShisa_PGMCnt_VBA: '',
    devShisa_PGMCnt_Access: '',
    devShisa_PGMCnt_R: '',
    devShisa_PGMCnt_Other: '',
    devShisa_LOC_VBNET: '',
    devShisa_LOC_Csharp: '',
    devShisa_LOC_VBA: '',
    devOther_PGMCnt_VBNET: '',
    devOther_PGMCnt_CSharp: '',
    devOther_PGMCnt_VBA: '',
    devOther_PGMCnt_Access: '',
    devOther_PGMCnt_R: '',
    devOther_PGMCnt_Other: '',
    devOther_LOC_VBNET: '',
    devOther_LOC_CSharp: '',
    devOther_LOC_VBA: '',
    user_Center: '',
    user_Kyoku: '',
    user_OtherSeifu: '',
    user_Localgovernment: '',
    user_Ippan: '',
    sysConfig: '',
    lineType_IE: '',
    lineType_SeifuNW: '',
    lineType_SINET: '',
    lineType_LGWIN: '',
    lineType_Other: '',
    infoType_Kimitsu3: '',
    infoType_Kimitsu2: '',
    infoType_Kanzen2: '',
    infoType_Kayo2: '',
    handlingInfoLimit: '',
    chosaKibo_ChosaCnt: '',
    chosaKibo_ChkCnt: '',
    chosaKibo_ListCnt: '',
    chosaKibo_KekkahyoCnt: '',

  }
}
