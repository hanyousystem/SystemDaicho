import { Component } from '@angular/core';
import { Gaisei } from '../Models/Gaisei';
import { UserdataService } from 'src/app/userdata.service';
import { ApiserviceService } from 'src/app/apiservice.service';
import { Location } from '@angular/common';

@Component({
  selector: 'app-add-gaisei',
  templateUrl: './add-gaisei.component.html',
  styleUrls: ['./add-gaisei.component.css']
})
export class AddGaiseiComponent {
  SystemList!: Gaisei;
  messege!: string;
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
    this.apiservice.addSystem_Gaisei(this.SystemList).subscribe(
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
  dummyObject: Gaisei = {
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
    sysType: '',
    dev_Scratch: '',
    dev_Package: '',
    dev_ScratchPackage: '',
    dev_Software: '',
    dev_Other: '',
    user_Center: '',
    user_Kyoku: '',
    user_Seifu: '',
    user_Localgovernment: '',
    user_Ippan: '',
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
    packageName: '',
    packageDevName: '',
    recentIntro_Jigyosha: '',
    recentIntro_Jiki: '',
    recentMainte_Jigyosha: '',
    recentMainte_Start: '',
    recentMainte_End: '',
    recentMainte_Kikan: '',
    recentMainte_SameIntro: '',
    recentOpe_Jigyosha: '',
    recentOpe_Start: '',
    recentOpe_End: '',
    recentOpe_Kikan: '',
    recentOpe_SameIntro: '',
    recentOpe_SameMainte: '',
    cloudService_UserUmu: '',
    cloudService_SeviceName: '',
    cloudService_Jigyosha: '',
    cloudService_ServiceKigyo: '',
    cloudService_Gaiyo: '',
    cloudService_Start: '',
    cloudService_End: '',
    cloudService_Kikan: '',
    cloudService_DomainName: '',
    cloudService_Kimitsu3: '',
    cloudService_Kimitsu2: '',
    cloudService_Kanzen2: '',
    cloudService_Kayo2: '',
    cloudService_Limit: '',
    scheduleRenew: '',

  }
}
