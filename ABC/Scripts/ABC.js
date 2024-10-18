function GetDropdownList(SearchId, divId, SearchText, IsNepali) {
    var items;
    $.getJSON('/DropdownLoad/LoadDropdown/', { SearchText: SearchText, SearchId: SearchId, IsNepali: IsNepali, }, function (data) {
        
      
        $.each(data, function (i, rslt) {
            debugger;
            items += "<option Value='" + rslt.Value + "'>" + rslt.Text + "</option>";
        });
        $(divId).empty();
        $(divId).html(items);
    });
}