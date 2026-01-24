window.callStaticDotNet = function () {
    DotNet.invokeMethodAsync(
        "BlazorInteropCaseStudy",
        "Notify",
        "Hello from JavaScript!"
    );
};
