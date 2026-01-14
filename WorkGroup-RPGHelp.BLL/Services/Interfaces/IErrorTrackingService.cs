using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WorkGroup_RPGHelp.BLL.Services.Interfaces
{
    public interface IErrorTrackingService
    {
        void CaptureException(Exception exception, Dictionary<string, object>? extra = null);

        void CaptureMessage(string message, Dictionary<string, object>? extra = null);

        void AddBreadcrumb(string message, string category = "default", string type = " default", Dictionary<string, string>? data = null);
    }
}
