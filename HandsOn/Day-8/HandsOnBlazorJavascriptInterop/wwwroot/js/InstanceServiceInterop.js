window.callNofityInstance = function (dotNetRef) {
    dotNetRef.invokeMethodAsync(
        "Nofity",
        "Hello from Javascript!!"
    );
}
window.callAddInstance = function (dotNetRef) {
    const result = await dotNetRef.invokeMethodAsync(
        "Add",
        10,
        20
    );
    console.log("Result from .Net Instance", result);
    return result;
}