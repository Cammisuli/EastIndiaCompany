﻿<%@ Control Language="C#" AutoEventWireup="true" Inherits="Merchello.Bazaar.Install.Installer" %>
<h1>We Hope You Love Merchello!</h1>
<p>Merchello, is a collaborative eCommerce package for the Umbraco CMS and has been an intensive effort by many in the Umbraco community.
    It is our goal to continue to improve and refine Merchello based on your feed back, so please let us know what you think! 
</p>

<h2>Install</h2>
<p>We have installed a store with some development settings.  Before you "Go Live" you will need to enable SSL. We have added a new appSetting to your web.config file
    that enables SSL on certain views that we think should be enabled in most situations. 
</p>
<code>
    &lt;appSettings&gt;
        &lt;add key="Bazaar:RequireSsl" value="false" /&gt;
    &lt;/appSetting&gt;
</code>
