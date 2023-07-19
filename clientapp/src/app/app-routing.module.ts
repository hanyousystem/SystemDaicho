import { Component, NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ShowSystemComponent } from './system/show-system_Naisei/show-system.component';
import { ShowSystemComponent_Gaisei } from './system/show-system_Gaisei/show-system.component_Gaisei';
import { AddNaiseiComponent } from './system/add-naisei/add-naisei.component';
import { EditNaiseiComponent } from './system/edit-naisei/edit-naisei.component';
import { AddGaiseiComponent } from './system/add-gaisei/add-gaisei.component';
import { EditGaiseiComponent } from './system/edit-gaisei/edit-gaisei.component';
// Routing を行う対象のコンポーネントを管理する
// path にセットした文字列にマッチしたURLが指定されると、対になっているコンポーネントが表示される
// 下記のように明示する以外にも
//    '' で [/] のルートパスを指定できる
//    '**' でワイルドカードを指定できる
const routes: Routes = [
  { path: 'system_Naisei', component: ShowSystemComponent },
  { path: 'system_Gaisei', component: ShowSystemComponent_Gaisei },
  { path: `sytem_Naisei/edit/:id`, component: EditNaiseiComponent },
  { path: `sytem_Naisei/add`, component: AddNaiseiComponent },
  { path: `sytem_Gaisei/edit/:id`, component: EditGaiseiComponent },
  { path: `sytem_Gaisei/add`, component: AddGaiseiComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes, { useHash: true })],
  exports: [RouterModule]
})
export class AppRoutingModule { }
