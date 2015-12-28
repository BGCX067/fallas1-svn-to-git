// by Raul @ 07.02.07

var g_posx = 0;
var g_posy = 0;
function toggleContent(ObjID, disp)
{
	ObjStyle = document.getElementById(ObjID).style;
	if(disp)
	{
		ObjStyle.display = disp;
		return;
	}
	if(ObjStyle.display != "none")
		ObjStyle.display = "none";
	else
		ObjStyle.display = "";
}
function getChildrenByTagName(parent, tag)
{
	tag = tag.toUpperCase();
	result = new Array();
	child = parent.firstChild;
	while(child != null)
	{
		if(child.tagName == tag)
			result[result.length] = child;
		child = (child.nextSibling != null) ? child.nextSibling : null;
	}
	return result;
}
function findPos(obj) {
	var curleft = curtop = 0;
	if (obj.offsetParent) {
		curleft = obj.offsetLeft
		curtop = obj.offsetTop
		while (obj = obj.offsetParent) {
			curleft += obj.offsetLeft
			curtop += obj.offsetTop
		}
	}
	return [curleft,curtop];
}
function getMousePosition(e) {
	
	if (!e) var e = window.event;
	if (e.pageX || e.pageY) 	{
		g_posx = e.pageX;
		g_posy = e.pageY;
	}
	else if (e.clientX || e.clientY) 	{
		g_posx = e.clientX + document.body.scrollLeft
			+ document.documentElement.scrollLeft;
		g_posy = e.clientY + document.body.scrollTop
			+ document.documentElement.scrollTop;
	}
}

/*
	concatenate array values
	returns a string
	arr = subject
	sep = separator, default is ""
*/
function array2string(arr, sep)
{
	str = "";
	if(!sep) sep = "";
	for(cnt=0;cnt<arr.length;cnt++)
	{
		str += sep + arr[cnt];
	}
	
	return str;
}
document.onmouseover = getMousePosition;
