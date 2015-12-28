function flagInapComment(chkbx){
	if(chkbx.tagName != "INPUT") return;
	cid = chkbx.id.substring(chkbx.id.indexOf("_")+1, chkbx.id.length);
	new Ajax.Request('/comment/flagBadComment/cid/'+cid+'.html', {asynchronous:true, evalScripts:false});
	divId = 'divThx_'.concat(cid);
	document.getElementById(divId).style.visibility = (chkbx.checked)?'visible':'hidden';
	chkbx.disabled = true;
}

function editEmailPreferences(chkbx,username){
	if(chkbx.tagName != "INPUT") return;
	cid = chkbx.id.substring(chkbx.id.indexOf("_")+1, chkbx.id.length);
	
	var notice = 'emailPrefUpdate_'.concat(cid);
	if (chkbx.checked == false) {
		alert('You will no longer receive emails when others comment on this page');
		var value = 0;
	} else {
		alert('You will receive an email when others comment on this page');
		var value = 1;
	}
	//alert('/profile/updateEmailPreferencesC/hash/' + cid + '/value/' + value + '/user/' + username + '.html'); die();
	new Ajax.Request('/profile/updateEmailPreferencesC/hash/' + cid + '/value/' + value + '/user/' + username + '.html', {asynchronous:true, evalScripts:false});

}

function editComment(btnEdit){// not used
	if(btnEdit.tagName != "INPUT") return;
	
	divs = getChildrenByTagName(btnEdit.parentNode.parentNode, 'DIV');
	if(btnEdit.value == "Edit"){
		for(i=0;i<divs.length;i++){
			if(divs[i].id == 'cmtContent'){
				cmtText = divs[i].firstChild.nodeValue;
				edtText = document.createElement('TEXTAREA');
				divs[i].replaceChild(
					edtText,
					divs[i].firstChild);
				edtText.value = cmtText;
				edtText.style.width = "100%";
			}
		}
		btnEdit.value = "Cancel";
	}
	else if(btnEdit.value == "Cancel"){
		for(i=0;i<divs.length;i++){
			if(divs[i].id == 'cmtContent'){
				edtText = getChildrenByTagName(divs[i], 'TEXTAREA')[0];
				cmtText = edtText.value;
				divs[i].replaceChild(
					document.createTextNode(cmtText),
					edtText);
			}
		}
		btnEdit.value = "Edit";
	}
}