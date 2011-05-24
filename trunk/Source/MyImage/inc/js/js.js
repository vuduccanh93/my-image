function hideGetTop(div){
	var node = document.getElementById(div);
	var br = navigator.appName;
	var os = null;
	var brWidth = document.all?document.body.clientWidth:window.innerWidth;
	if(br=='Netscape')
		os = window.pageYOffset;
	else if(br=='Microsoft Internet Explorer')
		os = document.documentElement.scrollTop;
	if(os > 300 && brWidth >1140)
		node.style.visibility = "visible";
	else node.style.visibility = "hidden";
}
