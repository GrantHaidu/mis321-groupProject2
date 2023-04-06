let cars =[
    {
    carImg : "./resources/img/tesla.png",
    vinID : 1,
    carName : "Tesla Model S", 
    carPrice : "89,990", 
    shortDesc: "The Tesla Model S is an electric luxury sedan with impressive performance, advanced technology, and a sleek design.",
    range: "405 Miles",
    horsePower: "400 horses",
    drive: "4wd",
    transmission: "Automatic",
    color: "Pearl White Multi-Coat",
    seat: "5"
    },
    {
      carImg : "./resources/img/R1T.png",
      vinID : 2,
      carName : "Rivian R1T", 
      carPrice : "74,075", 
      shortDesc: "The R1T is an electric pickup truck produced by Rivian Automotive, featuring all-wheel drive, up to 400+ miles of range, and various advanced technologies and off-road capabilities.",
      range: "400 Miles",
      horsePower: "600 horses",
      drive: "4wd",
      transmission: "Automatic",
      color: "LA Silver",
      seat: "5"
    },
  
]



//THIS READS IN LOCAL STORAGE
function readInFile(){
    if(JSON.parse(localStorage.getItem('AllMyCars')) != null){
        try{
            songs = JSON.parse(localStorage.getItem('AllMyCars'))
        }catch{
    
        } 
    }
}

//THIS WILL BE THE HOME SCTRUCTURE FOR THE CARS
 let renderCars = function() {
    
    let html = `<div class="row">`
    cars.forEach(function(car, index)
    {
        {  
        html += `
            
        <table> 
            <tbody>
            <tr>
                <td class="img"><img src="${car.carImg}" alt="${car.carName}"></td>
                <td class="shortDesc">
                    <h1 class="name"><strong>${car.carName}</strong></h1>
                    <p>${car.shortDesc}</p>
                </td>
                <td class="price">
                    <strong>$${car.carPrice}</strong>
                </td>
                <td style="text-align: center;">
                    <button type="button" class="btn btn-outline-primary" data-bs-toggle="modal" data-bs-target="#carModal">View Details</button>
                    <br>
                    <button type="button" class="btn btn-outline-primary" data-bs-toggle="modal" data-bs-target="#availModal">Check Availability</button>
                </td>
            </tr>
            
          
            <div class="modal fade" id="carModal" 
            tabindex="-1" aria-labelledby="carModalLabel" aria-hidden="true">
            <div class="modal-dialog">
              <div class="modal-content">
                <div class="modal-header">
                  <center><h5 class="modal-title" id="carModalLabel">Car Details</h5></center>
                  <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
                </div>
                <div class="modal-body p-5 pt-0">
                  <div class="row">
                    <div id="features">
                      <h1 class="name"><strong>${car.carName}</strong></h1>
                      <p><strong>$${car.carPrice}</strong></p>
                      <p>Travel Range: ${car.range}</p>
                      <p>Horsepower: ${car.horsePower}</p>
                      <p>Drive: ${car.drive}</p>
                      <p>Transmission: ${car.transmission}</p>
                      <p>Color: ${car.color}</p>
                      <p>Seats up to: ${car.seat}</p>
                      <hr>

                    <div class="compare">
                    <center>
                        <h4>Compare to Generic Gas Car</h4>
                        <form id="compareForm">
                        <div class="form-group">
                          <label for="avgMiles">Average Miles Driven Per Year:</label>
                          <p style="color: gray;"> 13,500 Miles <p/>
                        </div>
                        <div class="form-group">
                          <label for="gasPrice">Average Gas Price in Your Area:</label>
                          <p style="color: gray;"> $3.150<p/>
                        </div>
                        <div class="form-group">
                          <label for="yearsDriven">Years Intended to Drive:</label>
                          <p style="color: gray;"> 12 Years <p/>
                        </div>
                        <div class="form-group">
                          <label for="electricCost">Average Cost of Electric:</label>
                          <p style="color: gray;"> 1,214 kWh = $154.30 <p/>
                        </div>
                        <button type="submit" class="btn btn-primary">Compare</button>
                      </form>
                    </center>
                  </div>
                      
                    </div>
                  </div>
                </div> 
                </div>         
              </div>
            </div>
          <div class="modal-backdrop fade show"></div>
          </div>

          <div class="modal fade" id="availModals" tabindex="-1" aria-labelledby="availModalLabel" aria-hidden="true">
        <div class="modal-dialog">
          <div class="modal-content">
            <div class="modal-header">
              <center><h5 class="modal-title" id="availModalLabel">Car Availability</h5></center>
              <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
            </div>

          <div class="modal-body p-5 pt-0">
            <br
            <form class="">
              <div class="form-floating mb-3">
                <input type="email" class="form-control rounded-3" id="floatingInput" placeholder="First Last">
                <label for="floatingInput">Full Name</label>
              </div>
              <div class="form-floating mb-3">
                <input type="password" class="form-control rounded-3" id="floatingPassword" placeholder="name@email.com">
                <label for="floatingPassword">Email</label>
              </div>
              <button class="w-100 mb-2 btn btn-lg rounded-3 btn-primary" type="submit">Submit</button>
              <center><small class="text-muted">Check inbox to view availability on this vehicle</small></center>
            </form>
          </div>
        </div>
        </tbody>
            </table>
 `
        }
    })
    
  

    html += `</div>`
    document.getElementById("car").innerHTML = html;

    localStorage.setItem('AllMyCars', JSON.stringify(cars))

    const addCarForm = document.getElementById('#new-car');
    addCarForm.addEventListener('submit', (event) => {
        event.preventDefault();
        // add the new car to the cars array
        const newCar = {
            carImg: document.getElementById('car-img').value,
            carName: document.getElementById('car-name').value,
            shortDescript: document.getElementById('short-desc').value,
            carPrice: document.getElementById('car-price').value,
            range: document.getElementById('travel-range').value,
            horsePower: document.getElementById('horse-power').value,
            drive: document.getElementById('drive').value,
            transmission: document.getElementById('transmission').value,
            carColor: document.getElementById('car-color').value,
            seat: document.getElementById('car-seat').value
        };
        cars.push(newCar);
        // render the updated cars array
        renderCars();
    });
}


// function viewDetails(cars, myID) {
//   let html = `<div class="row">`  
//   for(var i = 0; i < cars.length; i++){
//       if(cars[i].vinID == myID){
//         {
//         html += `
//           <div class="modal fade" id="carModal" 
//           tabindex="-1" aria-labelledby="carModalLabel" aria-hidden="true">
//           <div class="modal-dialog">
//             <div class="modal-content">
//               <div class="modal-header">
//                 <center><h5 class="modal-title" id="carModalLabel">Car Details</h5></center>
//                 <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
//               </div>
//               <div class="modal-body p-5 pt-0">
//                 <div class="row">
//                   <div id="features">
//                     <h1 class="name"><strong>${cars[i].carName}</strong></h1>
//                     <p><strong>$${cars[i].carPrice}</strong></p>
//                     <p>Travel Range: ${cars[si].range}</p>
//                     <p>Horsepower: ${cars[i].horsePower}</p>
//                     <p>Drive: ${cars[i].drive}</p>
//                     <p>Transmission: ${cars[i].transmission}</p>
//                     <p>Color: ${cars[i].color}</p>
//                     <p>Seats up to: ${cars[i].seat}</p>
//                     <hr>

//                   <div class="compare">
//                   <center>
//                       <h4>Compare to Generic Gas Car</h4>
//                       <form id="compareForm">
//                       <div class="form-group">
//                         <label for="avgMiles">Average Miles Driven Per Year:</label>
//                         <p style="color: gray;"> 13,500 Miles <p/>
//                       </div>
//                       <div class="form-group">
//                         <label for="gasPrice">Average Gas Price in Your Area:</label>
//                         <p style="color: gray;"> $3.150<p/>
//                       </div>
//                       <div class="form-group">
//                         <label for="yearsDriven">Years Intended to Drive:</label>
//                         <p style="color: gray;"> 12 Years <p/>
//                       </div>
//                       <div class="form-group">
//                         <label for="electricCost">Average Cost of Electric:</label>
//                         <p style="color: gray;"> 1,214 kWh = $154.30 <p/>
//                       </div>
//                       <button type="submit" class="btn btn-primary">Compare</button>
//                     </form>
//                   </center>
//                 </div>
                    
//                   </div>
//                 </div>
//               </div> 
//               </div>         
//             </div>
//           </div>
//         <div class="modal-backdrop fade show"></div>
//         </div>`
//         }
          
//       }

//   }

//   renderCars(cars)
// }


//THIS WILL ADD THE CAR AND STORE IT IN LOCAL STORAGE
const addCarForm = document.getElementById('new-car'); addCarForm.addEventListener('submit', (event) => {
  event.preventDefault();
  const carImg = document.getElementById('car-img').files[0]; // get the selected image file
  var reader = new FileReader(); // create a FileReader object
  reader.onload = function() {
    // when the file is loaded, store the base64 encoded image data in the cars array

    const newCar = {
      carImg: reader.result,
      vinID: 2,
      carName: e.target.elements.carName.value,
      carPrice: e.target.elements.carPrice.value,
      shortDescript: e.target.elements.shortDescript.value,
      range: e.target.elements.travelRange.value,
      horsePower: e.target.elements.horsePower.value,
      drive: e.target.elements.drive.value,
      transmission: e.target.elements.transmission.value,
      color: e.target.elements.carColor.value
    }
    cars.unshift(newCar);

    renderCars(cars);
    blankFields();
  };
  reader.readAsDataURL(carImg); // read the image file as a data URL
});

function handleOnLoad(){
  //readInFile()
  renderCars()
}

















// function addNewCar(event) {
//   const form = 
//   event.preventDefault();

//   var carImg = document.querySelector('#car-img').files[0]; // get the selected image file
//   var reader = new FileReader();
//   const carImg = document.getElementById(reader.result);
//   const vinID = 2
//   const carName = document.getElementById("carName");
//   const carPrice = document.getElementById("carPrice");
//   const shortDesc = document.getElementById("shortDescript");
//   const range = document.getElementById("travelRange");
//   const horsePower = document.getElementById("horsePower");
//   const drive = document.getElementById("drive");
//   const transmission = document.getElementById("transmission");
//   const color = document.getElementById("carColor");
  

//   const newCar = {
//     carImg: carImg.value,
//       vinID: vinID.value,
//       carName: carName.value,
//       carPrice: carPrice.value,
//       shortDesc: shortDesc.value,
//       range: travelRange.value,
//       horsePower: horsePower.value,
//       drive: drive.value,
//       transmission: transmission.value,
//       color: color.value

//   };
//   cars.unshift(newCar);
//   console.log(newCar);
//   renderCars(cars)
// }






// document.querySelector('#new-car').addEventListener('submit',function(e){

    




    
//     e.preventDefault()// prevents refresh
//     var date = new Date()
//     songs.unshift({
//         carImg: "./resources/img/F150.png",
//         vinID: 2,
//         carName: e.target.elements.carName.value, 
//         carPrice: e.target.elements.carPrice.value, 
//         shortDesc: e.target.elements.shortDescript.value, 
//         range: e.target.elements.travelRange.value,
//         horsePower: e.target.elements.horsePower.value,
//         drive: "4wd",
//         transmission: "Automatic",
//         color: e.target.elements.carColor.value 
//     })

//     renderCars(cars)
//     blankFields()
// })







//THIS GETS CALLED IN HTML

//  const closeModalButtons = carModal.querySelectorAll("[data-close]");
//  const modalBackdrop = document.querySelector(".modal-backdrop");

//  closeModalButtons.forEach(function(button) {
//    button.addEventListener("click", function() {
//      myModal.style.display = "none";
//      myModal.classList.remove("show");
//      document.body.classList.remove("modal-open");
//    });
//});

//  myModal.addEventListener("click", function(event) {
//    if (event.target === myModal) {
//      myModal.style.display = "none";
//      myModal.classList.remove("show");
//      document.body.classList.remove("modal-open");