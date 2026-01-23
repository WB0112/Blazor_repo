window.CallNotityFromJsOnly = function () {
    //call void static method
    DotNet.invokeMethodAsync(
        "HandsOnBlazorJavascriptInterop",
        "Notify",
        "Hello From Javascirpt"
    );
}
window.CallAddNumbersFromJsOnly = function () {
    //call void static method
    const result=DotNet.invokeMethodAsync(
        "HandsOnBlazorJavascriptInterop",
        "AddNumbers",
        10, 23
    );
    return result;
}
window.CallSqaureFromJsOnly = function (a) {
    //call void static method
    const result=DotNet.invokeMethodAsync(
        "HandsOnBlazorJavascriptInterop",
        "Square",
        a
    );
    return result;
}