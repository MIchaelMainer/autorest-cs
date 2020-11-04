namespace Microsoft.Graph
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Models;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.IO;
    using System;

    public partial class Mail
    {

        partial void CustomInitialize()
        {
            this.SetUserAgent("CustomUserAgent");
        }
    }
}