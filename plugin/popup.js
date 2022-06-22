window.onload = cp_url;

function cp_url()
{
    chrome.tabs.query({
        active: true,
        currentWindow: false,
    }, function(tabs) {
        var tab = tabs[0];
        var input_post = document.getElementById("address");
        input_post.value = tab.url;
        document.getElementById("f_url").innerHTML = input_post.value;
    });   
}
