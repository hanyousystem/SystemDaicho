import { Component, OnInit, Input } from '@angular/core';
import { ApiserviceService } from 'src/app/apiservice.service';
import { Output, EventEmitter } from '@angular/core';
import { Naisei } from '../Models/Naise'

@Component({
  selector: 'app-add-edit-system',
  templateUrl: './add-edit-system.component.html',
  styleUrls: ['./add-edit-system.component.css']
})
export class AddEditSystemComponent implements OnInit {

  constructor(private service: ApiserviceService) { }

  @Input() depart: Naisei;
  @Output() newItemEvent = new EventEmitter<string>();
  Id = "";
  Name = "";
  Detail = "";
  ProcessControl: number = 0;
  SystemCategory: number = 0;
  CategoryList: any = [];
  ProcessControlList: any = [];
  Demographics = "";

  ngOnInit(): void {
    this.Id = this.depart.id;
    this.Name = this.depart.name;
    this.Detail = this.depart.detail;
    this.ProcessControl = this.depart.processName;
    this.SystemCategory = this.depart.categoryName;
    this.service.getCategories().subscribe(data => {
      this.CategoryList = data;
    });
    this.service.getProcessControls().subscribe(data => {
      this.ProcessControlList = data;
    });
    this.Demographics = this.depart.Demographics;
  }

  addSystem() {
    var dept = {
      Id: this.Id,
      Name: this.Name,
      Detail: this.Detail,
      SystemCategory: this.SystemCategory,
      ProcessControl: this.ProcessControl,
      Demographics: this.Demographics,
    };
    this.service.addSystem(dept).subscribe(res => {
      this.newItemEvent.emit("");
    }, error => {
      console.log(error.toString());
    }
    );
  }

  updateSystem() {
    var dept = {
      Id: this.Id,
      Name: this.Name,
      Detail: this.Detail,
      SystemCategory: this.SystemCategory,
      ProcessControl: this.ProcessControl,
      Demographics: this.Demographics,
    };
    this.service.updateSystem(dept).subscribe(res => {

      console.log("updateSystem")
      if (res === null) {
        console.log("updateSystem callback1")
        this.newItemEvent.emit("");
        console.log("updateSystem callback2")
      } else {
        console.log("updateSystem" + res.toString())
      }
    });
  }
  ChangeSystemCategory(e: any) {
    console.log("from " + this.SystemCategory + "ChangeSystemCategory =" + e.target.value);
    this.SystemCategory = e.target.value;
  }
  ChangeProcessControl(e: any) {
    console.log("from " + this.ProcessControl + "ChangeProcessControl =" + e.target.value);
    this.ProcessControl = e.target.value;
  }
}

