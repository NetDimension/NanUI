// THIS FILE IS PART OF NanUI PROJECT
// THE NanUI PROJECT IS AN OPENSOURCE LIBRARY LICENSED UNDER THE MIT License.
// COPYRIGHTS (C) Xuanchen Lin. ALL RIGHTS RESERVED.
// GITHUB: https://github.com/XuanchenLin/NanUI

namespace NetDimension.NanUI.Browser;
public interface IFrameHandler
{
    void OnFrameCreated(CefBrowser browser, CefFrame frame);
    void OnFrameAttached(CefBrowser browser, CefFrame frame, bool reattached);
    void OnFrameDetached(CefBrowser browser, CefFrame frame);
    void OnMainFrameChanged(CefBrowser browser, CefFrame? oldFrame, CefFrame? newFrame);
}
