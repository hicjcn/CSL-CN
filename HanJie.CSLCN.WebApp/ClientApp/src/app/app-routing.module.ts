import { NgModule, OnInit } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { HomepageComponent } from './components/homepage/homepage.component';
import { WikiPassageComponent } from './components/wiki-passage/wiki-passage.component';
import { RegisterComponent } from './components/register/register.component';
import { LoginComponent } from './components/login/login.component';
import { DonatorRank } from './components/donator-rank/donator-rank.component';

const routes: Routes = [
  { path: "", redirectTo: "/homepage", pathMatch: "full" },
  { path: "homepage", component: HomepageComponent },
  { path: "wiki-passage/:id", component: WikiPassageComponent },
  { path: "login", component: LoginComponent },
  { path: "register", component: RegisterComponent },
  { path: "donator-rank", component: DonatorRank }
];

@NgModule({
  imports: [RouterModule.forRoot(routes, { onSameUrlNavigation: "reload" })],
  exports: [RouterModule]
})
export class AppRoutingModule implements OnInit {

  ngOnInit() {

  }

}