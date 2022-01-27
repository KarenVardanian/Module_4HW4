let pCollection = document.getElementsByTagName('p');
console.log(pCollection);
for(let i=0; i<pCollection.length; i++){
//   pCollection[i].onclick = function(){
//     this.classList.toggle( 'bigger');

//  }
pCollection[i].addEventListener('click', bigText);
}