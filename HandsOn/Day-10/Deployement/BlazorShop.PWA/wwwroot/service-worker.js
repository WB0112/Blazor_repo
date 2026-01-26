// In development, always fetch from the network and do not enable offline support.
// This is because caching would make development more difficult (changes would not
// be reflected on the first load after each change).
self.importScripts('./service-worker-assets.js');


self.addEventListener('install', event => {
    event.waitUntil(
        caches.open('blazor-shop-cache')
            .then(cache => cache.addAll(self.assetsManifest.assets.map(a => a.url)))
    );
});


self.addEventListener('fetch', event => {
    event.respondWith(
        caches.match(event.request)
            .then(response => response || fetch(event.request))
    );
});
//Result

//App loads when offline

//Cached static assets

//Fast startup