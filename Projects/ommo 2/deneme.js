
const modalBtn = document.getElementById("modal-ac");
const modal = document.querySelector(".modal");
const modalKapat = document.getElementById("modal-kapat");

modalBtn.addEventListener("click", () => {
  modal.style.display = "flex";
});

modalKapat.addEventListener("click", () => {
  modal.style.display = "none";
});

const modalBtn1 = document.getElementById("modal-edit");

modalBtn1.addEventListener("click", () => {
  modal.style.display = "flex";
});
    

var cars = [     
    {marka:"Volkswagen", model:"Polo", renk:"Beyaz", motor:1.6, yas:5},  
    {marka:"Porsche", model:"Panamera", renk:"Kırmızı", motor:3.6, yas:4},  
    {marka:"Volvo", model:"S40", renk:"Siyah", motor:1.6, yas:3},   
    {marka:"Seat", model:"Leon", renk:"Turuncu", motor:1.6, yas:6},  
  ];

let formDOM = document.querySelector("#editForm")
formDOM.addEventListener('submit',formSubmit)

function formSubmit(event){
    event.preventDefault()
    console.log("işlem gerçekleşti")
    const name = document.querySelector("#txtAd")
    const url = document.querySelector("#url");

    if(name.value && url.value){
        addItem(name.value, url.value)
        name.value = ""
        url.value = ""
    }
}





// let listDOM = document.querySelector('#list')
const addItem = (name, url) => {

    // let liDOM = document.createElement('li')

    // liDOM.innerHTML = `${name} ${url}`
    // sinifim[4]= new Array(111,`${name}`,`${url}`)
    
    //listDOM.append(liDOM),

    cars.push({
        marka:`${name}`,
        model:`${url}`,
        renk:"color1", 
        motor:111,
        yas:222
      })

    //console.log("2->",sinifim)
    listAppend()

}
    
listAppend = () => {
    var i,j; var str;

  
        cars.forEach(item =>{
        str += '<ul>'
                str += '<li>'+ item.marka + '</li>';
                str += '<li>'+ item.model + '</li>';
                // str += '<li>'+ item.renk + '</li>';
                str += '<li>'+ 
                '<button class="btns" id="modal-edit">'+ '<i class="fa fa-edit"></i></button>'+
                '<button class="btns">'+'<i class="fa fa-trash"></i></button>'+
                '</li>';
                // str += '<li>'+ item.yas + '</li>';

                console.log("Marka: "+item.marka+", Model: "+item.model+", Renk: "+item.renk+", Motor: "+item.motor+", Yaş: "+item.yas);
             
        str += '</ul>';
    })
        document.getElementById("slideContainer").innerHTML = str;

}









 // var slides = ["slide 1", "slide 2", "slide 3"]
    // var str = '<ul>'

    // slides.forEach(function(slide) {
    //     str += '<li>'+ slide + '</li>';
    // }); 

    // str += '</ul>';
    // document.getElementById("slideContainer").innerHTML = str;

    // var weight = ["weight 1", "weight 2", "weight 3"]
    // var strWe = '<ul>'

    // weight.forEach(function(slide) {
    //     strWe += '<li>'+ weight + '</li>';
    // }); 

    // strWe += '</ul>';
    // document.getElementById("container").innerHTML = strWe;

//buton ile div içinde yazdıralım.
var bilgiler = [];
bilgiler.push("1");
var btn=document.getElementById("form-buton");
btn.onclick=function(){
    
    var ad=document.getElementById("txtAd");
    bilgiler.push("s"+ad.value);
    window.alert("Hoşgeldin: "+ad.value+"-"+bilgiler);
    
}		 
bilgiler.push("2");


   
    
    function waitForLoad(id, callback){
        var timer = setInterval(function(){
            if(document.getElementById(id)){
                clearInterval(timer);
                callback();
            }
        }, 100);
    }

    waitForLoad("subm", function(){
        console.log("load successful, you can proceed!!");

        const controller = document.querySelector('input[type=range]');
        const radialProgress = document.querySelector('.RadialProgress');
    
        const setProgress = (progress) => {
            const value = `${progress}%`;
            console.log("->",value);
            radialProgress.style.setProperty('--progress', value)
            radialProgress.innerHTML = value
            radialProgress.setAttribute('aria-valuenow', value)
        }   
    
        setProgress(controller.value)
            controller.oninput = () => {
            setProgress(controller.value)
        }
    });


  


