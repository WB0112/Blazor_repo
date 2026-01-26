// In development, always fetch from the network and do not enable offline support.
// This is because caching would make development more difficult (changes would not
// be reflected on the first load after each change).
// In production, the service worker will be generated and will take care of
// caching for offline support.
self.addEventListener("push", event => {
    if (!event.data) return;

    const data = event.data.json();

    event.waitUntil(
        self.registration.showNotification(data.title, {
            body: data.message,
            icon: "/icon-192.png",
            badge: "/icon-192.png"
        })
    );
});
// Handle notification click event
self.addEventListener("notificationclick", event => {
    event.notification.close();
    event.waitUntil(
        clients.openWindow("/")
    );
});