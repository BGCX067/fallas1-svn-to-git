var TTWnd=null;

function tooltip_init(){
	 var a = document.getElementsByTagName("a"); 
 for(i=0; i<a.length; i++){ 
 	if(a[i].className == "htt" && a[i].id != ""){
 		sp_addEvt(a[i], 'mouseover', sp_showTT);
 		sp_addEvt(a[i], 'mouseout', sp_closeTT);
 	}
 } 
}

function sp_showTT(){
	 if(TTWnd!=null){
	 	sp_closeTT();
	 }
	 TTWnd = sp_getObj("t"+this.id);
	 sp_show(TTWnd);
	 x = sp_getPageX(this);
	 y = sp_getPageY(this);
	 w = sp_getW(TTWnd);
	 h = sp_getH(TTWnd);
	 y = y - h;
	 pw = sp_getDocW()+sp_getScrollX();
	 ph = sp_getDocH()+sp_getScrollY();
	 if((w+x)>pw)
	 	x = pw-w;
	 if((h+y)>ph)
	 	y = ph-h;
	 sp_moveTo(TTWnd,x, y);
	 return false;
}

function sp_closeTT(){
	if(TTWnd!=null){
		sp_hide(TTWnd);
		TTWnd=null;
		}
}