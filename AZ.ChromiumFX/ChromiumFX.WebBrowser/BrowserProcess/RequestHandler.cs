// Copyright (c) 2014-2017 Wolfgang Borgsmüller
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license. See the License.txt file for details.

using Chromium;
using Chromium.Event;

namespace ChromiumFX.WebBrowser.BrowserProcess {
    internal class RequestHandler : CfxRequestHandler {

        internal BrowserClient client;

        internal RequestHandler(BrowserClient client) {
            this.client = client;

            this.GetResourceHandler += new CfxGetResourceHandlerEventHandler(RequestHandler_GetResourceHandler);
            
        }

        void RequestHandler_GetResourceHandler(object sender, CfxGetResourceHandlerEventArgs e) {
            WebResource resource;
            if(client.browser.webResources.TryGetValue(e.Request.Url, out resource)) {
                e.SetReturnValue(resource.GetResourceHandler());
            }
        }
    }
}
