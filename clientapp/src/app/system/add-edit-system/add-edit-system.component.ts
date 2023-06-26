import { Component, OnInit, Input } from '@angular/core';
import { ApiserviceService } from 'src/app/apiservice.service';
import { Output, EventEmitter } from '@angular/core';
import { Naisei } from '../Models/Naise'
import { UserdataService } from 'src/app/userdata.service';

@Component({
  selector: 'app-add-edit-system',
  templateUrl: './add-edit-system.component.html',
  styleUrls: ['./add-edit-system.component.css']
})
export class AddEditSystemComponent implements OnInit {



  @Input() depart!: Naisei;
  @Output() newItemEvent = new EventEmitter<string>();
  constructor(private service: ApiserviceService, private userdataservice: UserdataService) { }
  id: string = '';

  ngOnInit(): void {
  }

  addSystem() {
    this.depart.id = this.id;
    this.service.addSystem(this.depart).subscribe();
  }

  updateSystem() {
    this.depart.id = this.id;
    this.service.updateSystem(this.depart).subscribe(res => {
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
}

