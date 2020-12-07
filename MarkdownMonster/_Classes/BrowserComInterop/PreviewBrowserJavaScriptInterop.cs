﻿using System;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using MarkdownMonster;
using Westwind.Utilities;

namespace MarkdownMonster.BrowserComInterop
{

    /// <summary>
    /// JavaScript 
    /// </summary>
    public class PreviewBrowserJavaScriptInterop : BaseBrowserInterop
    {
        private PreviewBrowserDotnetInterop _webViewPreviewDotnetInterop;
        private object WebBrowser;


        public PreviewBrowserJavaScriptInterop(PreviewBrowserDotnetInterop interop)
        {
            _webViewPreviewDotnetInterop = interop;
            WebBrowser = interop.WebBrowser;

            if (WebBrowser is WebBrowser)
                Instance = PreviewBrowserDotnetInterop.GetWebBrowserWindow(WebBrowser as WebBrowser);
            
        }

        public void InitializeInterop()
        {
            Invoke("initializeinterop");
        }


        public void UpdateDocumentContent(string html, int lineNo)
        {
            if (_webViewPreviewDotnetInterop.WebBrowser == null)
                return;

            //_webViewPreviewDotnetInterop.htmlToUpdate = html;

            Invoke("updateDocumentContent", html, lineNo);
        }


        public void ScrollToPragmaLine(int editorLineNumber = -1,
            string headerId = null,
            bool updateCodeBlocks = true,
            bool noScrollTimeout = false, bool noScrollTopAdjustment = false)
        {
            Invoke("scrollToPragmaLine", editorLineNumber, headerId, noScrollTimeout, noScrollTopAdjustment);
        }
        
        public void ScrollToHtmlBlock(string htmlText)
        {
            Invoke("scrollToHtmlBlock", htmlText);
        }
        

        public void SetHighlightTimeout(int timeout)
        {
            SetEx("previewer.highlightTimeout", timeout);
        }


    }
}
