
$(function () {


    //    $(".Question1").bind("click", function (e) {
    //        CalculateRisk();
    //    });
    //    $(".Question8").bind("click", function (e) {
    //        CalculateRisk();
    //    });


    //Calculate the risk
    $("input:radio, .AnswerCheckBoxes").bind("click", function (e) {
        CalculateRisk();
    });

    $(document).ready(function () {
        CalculateRisk();
    });


    function CalculateRisk() {
        var Green = 0;
        var Yellow = 0;
        var Blue = 0;

        //switch ($(".Question1:checked").val()) {
        switch ($("#Question1").val()) {
            case "61 - 65":
            case "66 - 70":
            case "71 - 75":
            case "76 - 80":
            case "81 - 85":
            case "86 - 90":
            case "> 90":
                Green++;
                break;
        }

        //        switch ($(".Question8:checked").val()) {
        //            case "Uncomplicated peptic ulcer":
        //            case "Dyspepsia":
        //                Green++;
        //                break;
        //            case "Bleeding peptic ulcer":
        //                Blue++;
        //                break;
        //        }

        if ($("#Question8").val().indexOf("Uncomplicated peptic ulcer") != -1) {
            Green++;
        }
        if ($("#Question8").val().indexOf("Dyspepsia") != -1) {
            Green++;
        }
        if ($("#Question8").val().indexOf("Bleeding peptic ulcer") != -1) {
            Blue++;
        }



//        if ($("#Question9_Acetaminophen:checked").val() == "Acetaminophen < 3000mg") { Yellow++; }
//        if ($("#Question9_Acetaminophen:checked").val() == "Acetaminophen >= 3000mg") { Green++; }

//        if ($("#Question9_Aspirin:checked").val() == "Aspirin < 3000mg") { Yellow++; }
//        if ($("#Question9_Aspirin:checked").val() == "Aspirin >= 3000mg") { Green++; }

//        if ($("#Question9_Diclofenac:checked").val() == "Diclofenac 100mg/day") { Yellow++; }
//        if ($("#Question9_Diclofenac:checked").val() == "Diclofenac 150mg/day") { Green++; }

//        if ($("#Question9_DiclofenacMisoprostol:checked").val() == "Diclofenac/Misoprostol 100 mg diclofenac/day") { Yellow++; }
//        if ($("#Question9_DiclofenacMisoprostol:checked").val() == "Diclofenac/Misoprostol 150 mg diclofenac/day") { Green++; }

//        if ($("#Question9_Ibuprofen:checked").val() == "Ibuprofen < 1200mg") { Yellow++; }
//        if ($("#Question9_Ibuprofen:checked").val() == "Ibuprofen >= 1200mg") { Green++; }

//        if ($("#Question9_Indomethacin:checked").val() == "Indomethacin < 200 mg/day") { Yellow++; }
//        if ($("#Question9_Indomethacin:checked").val() == "Indomethacin >= 200 mg/day") { Green++; }

//        if ($("#Question9_Meloxicam:checked").val() == "Meloxicam < 15 mg/day") { Yellow++; }
//        if ($("#Question9_Meloxicam:checked").val() == "Meloxicam >= 15 mg/day") { Green++; }

//        if ($("#Question9_Naproxen:checked").val() == "Naproxen < 1000 mg/day") { Yellow++; }
//        if ($("#Question9_Naproxen:checked").val() == "Naproxen >= 1000 mg/day") { Green++; }

//        if ($("#Question9_Naproxen_esomeprazole:checked").val() == "Naproxen—esomeprazole < 1000 mg/day") { Yellow++; }
//        if ($("#Question9_Naproxen_esomeprazole:checked").val() == "Naproxen—esomeprazole >= 1000 mg/day") { Green++; }

//        if ($("#Question9_Celecoxib:checked").val() == "Celecoxib < 200 mg/day") { Yellow++; }
//        if ($("#Question9_Celecoxib:checked").val() == "Celecoxib >= 200 mg/day") { Green++; }


//        if ($("#Question9_Acetaminophen_tramadol:checked").val() == "Acetaminophen/tramadol < 3000/300 mg/day") { Yellow++; }
//        if ($("#Question9_Acetaminophen_tramadol:checked").val() == "Acetaminophen/tramadol >= 3000/300 mg/day") { Green++; }

//        if ($("#Question9_Codeine:checked").val() == "Codeine < 3000/300 mg/day") { Yellow++; }
//        if ($("#Question9_Codeine:checked").val() == "Codeine >= 3000/300 mg/day") { Green++; }

//        if ($("#Question9_Tramadol:checked").val() == "Tramadol < 300 mg/day") { Yellow++; }
//        if ($("#Question9_Tramadol:checked").val() == "Tramadol >= 300 mg/day") { Green++; }



        if ($("#Question9").val().indexOf("Acetaminophen < 3000mg") != -1) { Yellow++; }
        if ($("#Question9").val().indexOf("Acetaminophen >= 3000mg") != -1) { Green++; }

        if ($("#Question9").val().indexOf("Aspirin < 3000mg") != -1) { Yellow++; }
        if ($("#Question9").val().indexOf("Aspirin >= 3000mg") != -1) { Green++; }

        if ($("#Question9").val().indexOf("Diclofenac 100mg/day") != -1) { Yellow++; }
        if ($("#Question9").val().indexOf("Diclofenac 150mg/day") != -1) { Green++; }

        if ($("#Question9").val().indexOf("Diclofenac/Misoprostol 100 mg diclofenac/day") != -1) { Yellow++; }
        if ($("#Question9").val().indexOf("Diclofenac/Misoprostol 150 mg diclofenac/day") != -1) { Green++; }

        if ($("#Question9").val().indexOf("Ibuprofen < 1200mg") != -1) { Yellow++; }
        if ($("#Question9").val().indexOf("Ibuprofen >= 1200mg") != -1) { Green++; }

        if ($("#Question9").val().indexOf("Indomethacin < 200 mg/day") != -1) { Yellow++; }
        if ($("#Question9").val().indexOf("Indomethacin >= 200 mg/day") != -1) { Green++; }

        if ($("#Question9").val().indexOf("Meloxicam < 15 mg/day") != -1) { Yellow++; }
        if ($("#Question9").val().indexOf("Meloxicam >= 15 mg/day") != -1) { Green++; }

        if ($("#Question9").val().indexOf("Naproxen < 1000 mg/day") != -1) { Yellow++; }
        if ($("#Question9").val().indexOf("Naproxen >= 1000 mg/day") != -1) { Green++; }

        if ($("#Question9").val().indexOf("Naproxen—esomeprazole < 1000 mg/day") != -1) { Yellow++; }
        if ($("#Question9").val().indexOf("Naproxen—esomeprazole >= 1000 mg/day") != -1) { Green++; }

        if ($("#Question9").val().indexOf("Celecoxib < 200 mg/day") != -1) { Yellow++; }
        if ($("#Question9").val().indexOf("Celecoxib >= 200 mg/day") != -1) { Green++; }


        if ($("#Question9").val().indexOf("Acetaminophen/tramadol < 3000/300 mg/day") != -1) { Yellow++; }
        if ($("#Question9").val().indexOf("Acetaminophen/tramadol >= 3000/300 mg/day") != -1) { Green++; }

        if ($("#Question9").val().indexOf("Codeine < 3000/300 mg/day") != -1) { Yellow++; }
        if ($("#Question9").val().indexOf("Codeine >= 3000/300 mg/day") != -1) { Green++; }

        if ($("#Question9").val().indexOf("Tramadol < 300 mg/day") != -1) { Yellow++; }
        if ($("#Question9").val().indexOf("Tramadol >= 300 mg/day") != -1) { Green++; }



        if ($("#Question10").val().indexOf("Low-dose ASA (<300 mg/day)") != -1) {
            Green++;
        }
        if ($("#Question10").val().indexOf("Corticosteroid (eg, prednisone)") != -1) {
            Green++;
        }
        if ($("#Question10").val().indexOf("Anticoagulant (eg, warfarin)") != -1) {
            Blue++;
        }


//        $(".AnswerCheckBoxes:checked").each(function (i) {
//            switch (this.value) {
//                case "Low-dose ASA (<300 mg/day)":
//                case "Corticosteroid (eg, prednisone)":
//                    Green++;
//                    break;
//                case "Anticoagulant (eg, warfarin)":
//                    Blue++;
//                    break;
//            }
//        });

        //        if (Green == 0 && Yellow <= 1 && Blue == 0) { $("#Question12").val("Low risk"); }
        //        if ((Green == 1 || Green == 2) || (Yellow >= 2 && Blue == 0)) { $("#Question12").val("Moderate risk"); }
        //        if (Green >= 3 || (Green >= 2 && Yellow >= 2) || Blue >= 1) { $("#Question12").val("High risk"); }

        if (Green == 0 && Yellow <= 1 && Blue == 0) { $(".GIRisk").val("Low risk"); $(".GIRisk").html("Low risk").addClass("green"); }
        if ((Green == 1 || Green == 2) || (Yellow >= 2 && Blue == 0)) { $(".GIRisk").val("Moderate risk"); $(".GIRisk").html("Moderate risk").addClass("yellow"); }
        if (Green >= 3 || (Green >= 2 && Yellow >= 2) || Blue >= 1) { $(".GIRisk").val("High risk"); $(".GIRisk").html("High risk").addClass("red"); }

     //   alert("Green=" + Green + " Yellow=" + Yellow + " Blue=" + Blue);

    }

});