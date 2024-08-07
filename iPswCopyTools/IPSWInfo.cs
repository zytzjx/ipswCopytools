﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace iPswCopyTools
{
    enum DEVICETYPE
    {
        iPhone,
        iPad,
        iPod
    }

    class IPSWInfo
    {
        private List<String> _Dmgs = new List<string>();
        private string _srcDmgFolder;
        private string _srcIPSWFolder;
        private string _srcAPSTDMGFolder;
        private Boolean _isoverwrite;
        private string _cpinfo;
        private int error;

        public String DeviceName;
        public List<String> Dmgs
        {
            get { return _Dmgs; }
        }
        public String IPSWFileName;
        public DEVICETYPE DevType = DEVICETYPE.iPhone;

        public String DMGFolder
        {
            set { _srcDmgFolder = value; }
        }
        public String IPSWFolder
        {
            set { _srcIPSWFolder = value; }
        }
        public String LOTDMGFolder
        {
            set { _srcAPSTDMGFolder = value; }
        }

        public Boolean IsOverwrite{
            set { _isoverwrite = value; }
        }

        public String CopyInfo
        {
            get { return _cpinfo; }
        }

        public int Error
        {
            get { return error; }
        }
        public void SetDMGS(String s)
        {
            _Dmgs.Clear();
            var items = s.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
            foreach(var it in items)
            {
                _Dmgs.Add(it);
            }     
        }

        public void CopyFiles(String srcDmgfolder, string srcIpswFolder, String dstFolder)
        {
            if (string.IsNullOrEmpty(srcDmgfolder) || string.IsNullOrEmpty(srcIpswFolder) || string.IsNullOrEmpty(dstFolder))
            {
                error = 3;
                System.Diagnostics.Trace.WriteLine($"DMG={srcDmgfolder} or IPSW={srcIpswFolder} or target={dstFolder}");
                return;
            }
            System.Diagnostics.Trace.WriteLine($"Copy File From {Path.Combine(srcIpswFolder, IPSWFileName)} to {Path.Combine(dstFolder, IPSWFileName)}");
            try
            {
                _cpinfo = $"copying {IPSWFileName}";
                if (_isoverwrite || !File.Exists(Path.Combine(dstFolder, IPSWFileName)))
                {
                    File.Copy(Path.Combine(srcIpswFolder, IPSWFileName), Path.Combine(dstFolder, IPSWFileName), true);
                }
                System.Diagnostics.Trace.WriteLine($"Copy ipsw Success { IPSWFileName}");

            }
            catch
            {
                error = 2;
                _cpinfo = $"failed: {IPSWFileName}";
                System.Diagnostics.Trace.WriteLine($"Copy ipsw Failed { IPSWFileName}");
                if (File.Exists(Path.Combine(dstFolder, IPSWFileName)))
                {
                    try
                    {
                        File.Delete(Path.Combine(dstFolder, IPSWFileName));
                    }
                    catch
                    {

                    }
                }
            }
            foreach(var it in _Dmgs)
            {
                System.Diagnostics.Trace.WriteLine($"Copy File From {Path.Combine(srcDmgfolder, it)} to {Path.Combine(dstFolder, it)}");
                try
                {
                    _cpinfo = $"copying {it}";
                    if (_isoverwrite || !File.Exists(Path.Combine(dstFolder, it)))
                    {
                        File.Copy(Path.Combine(srcDmgfolder, it), Path.Combine(dstFolder, it), true);
                    }
                    System.Diagnostics.Trace.WriteLine($"Copy DMG Success {it}");
                }
                catch
                {
                    error = 1;
                    _cpinfo = $"failed: {it}";
                    System.Diagnostics.Trace.WriteLine($"Copy DMG failed {it}");
                    if (File.Exists(Path.Combine(dstFolder, it)))
                    {
                        try
                        {
                            File.Delete(Path.Combine(dstFolder, it));
                        }
                        catch
                        {

                        }
                    }
                }
            }
        }


        public void COPY()
        {
            error = 0;
            CopyFiles(_srcDmgFolder, _srcIPSWFolder, _srcAPSTDMGFolder);
        }


        public Boolean CheckDMGFolder()
        {
            Boolean bRet = false;
            if (!File.Exists(Path.Combine(_srcAPSTDMGFolder, IPSWFileName)))
            {
                return bRet;
            }
            foreach (var it in _Dmgs)
            {
                if (!File.Exists(Path.Combine(_srcAPSTDMGFolder, it)))
                {
                    return bRet;
                }
            }

            return true;
        }

        public Boolean DeleteDMGFolder()
        {
            Boolean bRet = true;
            if (File.Exists(Path.Combine(_srcAPSTDMGFolder, IPSWFileName)))
            {
                try
                {
                    File.Delete(Path.Combine(_srcAPSTDMGFolder, IPSWFileName));
                }
                catch
                {
                    bRet = false;
                }
            }
            foreach (var it in _Dmgs)
            {
                if (File.Exists(Path.Combine(_srcAPSTDMGFolder, it)))
                {
                    try
                    {
                        File.Delete(Path.Combine(_srcAPSTDMGFolder, it));
                    }
                    catch
                    {
                        bRet = false;
                    }
                }
            }

            return bRet;
        }
    }

}
