﻿using Microsoft.Extensions.Diagnostics.HealthChecks;
using System.Runtime.InteropServices;

namespace NetLock_Server
{
    public class Application_Paths
    {
        public static string logs_dir = Path.Combine(GetBasePath(), "0x101 Cyber Security", "NetLock RMM", "Server", "Logs");
        public static string debug_txt_path = Path.Combine(GetBasePath(), "0x101 Cyber Security", "NetLock RMM", "Server", "debug.txt");

        public static string _public_uploads_user = Path.Combine(GetCurrentDirectory(), "www", "public", "uploads", "user");
        public static string _public_downloads_user = Path.Combine(GetCurrentDirectory(), "www", "public", "downloads", "user");

        public static string _private_downloads_netlock = Path.Combine(GetCurrentDirectory(), "www", "private", "downloads", "netlock");
        
        public static string _private_uploads_remote_temp = Path.Combine(GetCurrentDirectory(), "www", "private", "uploads", "remote", "temp");
        public static string _private_downloads_remote_temp = Path.Combine(GetCurrentDirectory(), "www", "private", "downloads", "remote", "temp");

        public static string _private_files_admin = Path.Combine(GetCurrentDirectory(), "www", "private", "files", "admin");

        // URLs
        public static string redirect_path = "/";

        private static string GetBasePath()
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                return Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
            {
                return "/var";
            }
            else
            {
                throw new NotSupportedException("Unsupported OS");
            }
        }

        private static string GetCurrentDirectory()
        {
            return AppContext.BaseDirectory;
        }
    }
}