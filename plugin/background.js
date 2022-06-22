const filter = { 
    url: [
        { urlMatches: 'http' }
      ] 
  }

chrome.webNavigation.onCompleted.addListener(newPageListener, filter);

function newPageListener()
{
  chrome.tabs.query({
      active: true,
      lastFocusedWindow: true
  }, function(tabs) {

      const tab = tabs[0];
      var timestamp = new Date();
      var report = "INFO: " + timestamp.toISOString() + " : Checking: " + tab.url;
      console.info(report);

      chrome.tabs.sendMessage(tab.id, {text: 'report_back'}, doStuffWithDom);
  });
}

function doStuffWithDom(domContent) 
{
  var isLoginPage = false;
  var pattern_passwd = 'type="password"';

  var timestamp = new Date();
  var report = "RESULT: " + timestamp.toISOString() + ": ";

  if(domContent.includes(pattern_passwd)) {
      isLoginPage = true;
      report += "LOGIN PAGE IDENTIFIED";
  }
  else {
      isLoginPage = false;
      report += "PAGE IGNORED";
  }
  console.info(report);

  if(isLoginPage == true)
  {
      chrome.tabs.query({
          active: true,
          lastFocusedWindow: true
      }, function(tabs) {
          const tab = tabs[0];

          const key = tab.url;
          const value = { name: "URL" };

          chrome.storage.local.get([key], (result) => {
              console.log('Retrieved: ' + result.key);

              if(typeof result.key === typeof undefined){
                  showPopup(key);
                  chrome.storage.local.set({key: value}, () => {
                      console.log('Stored: ' + key);
                    });
              } else {
                  console.log('Already in storage: ' + result.key);
              }
          });
      });
  } 
}

function showPopup(url)
{
  var timestamp = new Date();
  var report = "WARN: " + timestamp.toISOString() + " : Alert send: " + url;
  console.warn(report);

  const height = 1000;
  const width = 1000;

  chrome.windows.create(
      {
          'url': 'popup.html', 
          'type': 'popup', 
          'height': height, 
          'width': width
      }, 
      function(window) {
  });
}