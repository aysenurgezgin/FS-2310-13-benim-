"use strict";
const txtTaskDescription = document.getElementById("txt-task-description");
const btnAddTask = document.getElementById("btn-add-task");
const taskList = document.getElementById("task-list");

let isEditMode=false;//eger bu değişken false ise yaeni kayıt modunda re ise düzenleme modundayız.
let editedTaskId;//o an da hangi göred düzenleniyorsa uyguama boyunca geçerli olacka sekilde o görevi id'sini

let taskListArray = [
    { id: 1, taskDescription: "Netflix izle", status: "completed" },
    { id: 2, taskDescription: "Pilavı unutma", status: "pending" },
    { id: 3, taskDescription: "Eceye kendini affettir", status: "pending" },
    { id: 4, taskDescription: "Pazar günü için toplantı planla", status: "completed" },
    { id: 15, taskDescription: "Çok kilo verdin, yemek yemeyi unutma!", status: "pending" }
];

//btnAddTask elemnetine click yapıldığında çalışacak fonksiyonun ası addTask'tir.
btnAddTask.addEventListener("click",addTask);

//Yeni görev ekleyen fonksiyon
 function addTask(event){
    event.preventDefault();//ilgili olayın default davranışlarını iptal ediyor.
    let value = txtTaskDescription.value.trim();
    if (value != "") {
        let id = taskListArray.length == 0 ? 1 : taskListArray[taskListArray.length - 1].id + 1;
        taskListArray.push(
            {
                "id": id,
                "taskDescription": value,
                "status": "pending"
            }
        );
            displayTasks();
        console.log(taskListArray);
    } else {
        alert("Lütfen görev açıklamasını boş bırakmayınız.")
    }
    txtTaskDescription.value = "";
    txtTaskDescription.focus();
 }

 // Bu function, her ihtiyaç duyulduğunda tüm görevleri yeniden okuyup ekranda göstermek için kullanılacak.
function displayTasks() {
    // Bu function, her ihtiyaç duyulduğunda tüm görevleri yeniden okuyup ekranda göstermek için kullanılacak.
    taskList.innerHTML = "";
    if (taskListArray.length == 0) {
        taskList.innerHTML = `<div class="alert alert-warning mb-0">Tanımlı görev bulunmamaktadır.</div>`;
    } else {
       for(const task of taskListArray){
        let completed=task.status=="completed"?"checked":"";
        let taskLi=`
        <li class="task list-group-item" id=""${task.id}">
        <div class="form-check d-flex justify-content-between align-items-center">
            <input onclick="updateStatus(this);" type="checkbox" id="${task.id}" class="form-check-input"${completed}>
            <div class="input-group">
                <input id=""${task.id}" class="form-control ${completed}" type="text" value="${task.taskDescription}"
                    disabled/>
                <button onclick="editTask(this);" id=""${task.id}" class="btn btn-warning"><i class="fa-solid fa-pen-to-square"></i></button>
                <button onclick="deleteTask(this);" id=""${task.id}" class="btn btn-danger"><i class="fa-solid fa-trash"></i></button>
            </div>
        </div>
    </li>
        `;
        taskList.insertAdjacentHTML("beforeend",taskLi);
       }
    }
}

//Task update (tamamlandı/devam ediyor)işlemini yapan fonksiyon
function updateStatus(activeTask) {
   let newStatus=activeTask.checked ? "completed" :"pending";
   for(const task of taskListArray){
        if (activeTask.id==task.id) {
            task.status=newStatus;
            break;
        }
   }
   console.log(taskListArray);
   displayTasks();
   
}
function editTask(clickedButton){
    //Araştırma ödevi:bir text'e odaklandığımızda içiçndeki metnin 
    // sonuna ya da seçili bir halde odaklanmanın bir yolu var mı nasıl
   
    editedTaskId=clickedButton.id;
    let editedTask=clickedButton.previousElementSibling;
    let
    let isChecked=editedTask.classList.contains("checked") ? "checked":"";
    console.log(isChecked);
    if (!isEditMode) {
        

    editedTask.removeAttribute("disabled");
    if(checked!="")editedTask.classList.remove(checked);
    clickedButton.classList.remove("btn-warning");
    clickedButton.classList.add("btn-info");
    // clickedButton.firstElementChild.classList.remove("fa-pen-to-square");
    // clickedButton.firstElementChild.classList.remove("fa-solid");
    // clickedButton.firstElementChild.classList.add("fa-circle-check");
    // clickedButton.firstElementChild.classList.add("fa-regular");
    clickedButton.innerHTML='<i class="fa-solid fa-circle-check"></i>';
    editedTask.focus();
    isEditMode=true;
    }else{
        editedTask.setAttribute("disabled","disabled");
        if(checked!="")editedTask.classList.add(checked);
        clickedButton.classList.remove("btn-info");
        clickedButton.classList.add("btn-warning");
        clickedButton.innerHTML='<i class="fa-solid fa-pen-to-square></i>';
        isEditMode=false;
        }
}

displayTasks();

