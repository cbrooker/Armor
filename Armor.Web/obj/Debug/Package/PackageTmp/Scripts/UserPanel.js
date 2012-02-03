

<script language="javascript" type="text/javascript">

    $(function () {
        $("#slidingPanel").slideUp();

        $("#RegistrationButton").bind("click", function (e) {
            e.preventDefault();
            $("#slidingPanel").slideToggle();
        });
    });

</script>