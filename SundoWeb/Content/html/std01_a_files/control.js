
function k_d() {

  if (event.keyCode == 67){
      return true;
   }

  if (event.keyCode == 70){
      return true;
   }

  if ((event.ctrlKey) || (event.keyCode == 122)){
    event.keyCode=0;event.cancelBubble=true;event.returnValue=false;
   }

  if (event.keyCode == 93) {
    window.external.AddFavorite('http://','¡¡');
    }
}

document.onkeydown=k_d;

