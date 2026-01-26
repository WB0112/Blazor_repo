// In development, always fetch from the network and do not enable offline support.
// This is because caching would make development more difficult (changes would not
// be reflected on the first load after each change).
// In production, enable offline support by caching resources during the installation
self.addEventListener('fetch', (event) => {
    event.respondWith(caches.match(event.request))
        .then(response => response || fetch(event.request));
});
