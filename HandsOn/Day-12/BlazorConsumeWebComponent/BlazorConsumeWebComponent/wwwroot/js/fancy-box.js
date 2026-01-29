class FancyBox extends HTMLElement {
    connectedCallback() {
        this.innerHTML=`
        <div style="border: 2px solid blue; padding: 10px; margin: 10px;">
            <h2>Fancy Box Component</h2>
            <p>This is a fancy box created using a Web Component!</p>
        </div>
        `; 
    }
}
customElements.define('fancy-box', FancyBox);