var HTTPObj = null;
createXMLHttp();
function createXMLHttp(){
    var httpReq = HTTPObj;
    if(!httpReq){
        if(typeof window.XMLHttpRequest !='undefined'){
            try{
                httpReq = new XMLHttpRequest();
            }catch(e){
                httpReq = null;
            }
        }else if(typeof window.createRequest){
            try{
                httpReq = window.createRequest();
            }catch(e){
                httpReq = null;
            }
        }else if(typeof window.ActiveXObject !='undefined'){
            try{
                httpReq = new ActiveXObject("Msxml2.XMLHTTP");
            }catch(e){
                try{
                    httpReq = new ActiveXObject("Microsoft.XMLHTTP");
                }catch(e){
                    httpReq = null;
                }
            }
        }
    }
    HTTPObj = httpReq;
}
function senReq(url,target_elem,handler){
    var doDefault = true;
    if(HTTPObj){
        try{
            HTTPObj.targetId = target_elem;
        }catch(e){
            HTTPtarget = target_elem;
        }
        HTTPObj.open("GET",url,true);
        HTTPObj.onreadystatechange = handler;
        HTTPObj.send(null);
        doDefault = false;
    }else{
        doDefault = true;
    }
    return doDefault;
}
function handleResponse() {
    if (HTTPObj.readyState == 4 || HTTPObj.readyState == "complete" ) {
        try {
            if (HTTPObj.status == 200) {
                var targ = document.getElementById(HTTPObj.targetId);
                targ.innerHTML = HTTPObj.responseText;
        } //else if (HTTPObj.readyState != "complete") {
            //alert(HTTPObj.status + ": " + HTTPObj.status.Text);
        //}
        } catch (e) {
            alert("Network error!\nPlease try later.");
        }
    }
}
function sendRequest(url,targetid){
    senReq(url,targetid,handleResponse);
}
/*-----------------------------------------------------------------------------------*/

function trim (str) {
	str = str.replace(/^\s+/, '');
	for (var i = str.length - 1; i >= 0; i--) {
		if (/\S/.test(str.charAt(i))) {
			str = str.substring(0, i + 1);
			break;
		}
	}
	return str;
}

