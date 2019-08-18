"use strict"

let area = document.querySelector(".area");
let input = document.querySelector(".photo");
let button = document.querySelector(".button");
let dropareaImage = document.querySelector(".droparea-Image")


let areaSingle = document.querySelector(".single-area");
let inputSingle = document.querySelector(".single-photo");
let dropareaImageSingle = document.querySelector(".single-droparea-Image")

let SingleImagesize = 0;

area.onclick = function () {
    input.click()
};

areaSingle.onclick = function () {
    inputSingle.click()
};

inputSingle.onchange = function (e) {
    [...e.target.files].forEach(file => {

        if (file.type.match("image/*")) {
            let reader = new FileReader();

            reader.onloadend = function (event) {
                let image = document.createElement("img");
                image.classList.add("img");
                image.src = event.target.result;
                dropareaImageSingle.appendChild(image);
                SingleImagesize += parseInt((file.size / 1024))
            }
            reader.readAsDataURL(file);
        }
    })
}

input.onchange = function (e) {
    [...e.target.files].forEach(file => {

        if (file.type.match("image/*")) {
            let reader = new FileReader();

            reader.onloadend = function (event) {
                let image = document.createElement("img");
                image.classList.add("img");
                image.src = event.target.result;
                dropareaImage.appendChild(image);
                Imagesize += parseInt((file.size / 1024))
            }
            reader.readAsDataURL(file);
        }
    })
}

    
$(function () {
    $("#Model_MarcaId").click(function () {
        var marcaId = $(this).val();

        if (marcaId) {
            $.ajax({
                url: "/Ajax/index?id=" + marcaId,
                type: "GET",
                success: function (res) {
                    $("#ModelId").html(res);
                }
            });
        }

    })
});