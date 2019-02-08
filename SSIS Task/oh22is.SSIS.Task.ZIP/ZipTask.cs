using System;
using Microsoft.SqlServer.Dts.Runtime;

namespace oh22is.DTS.Task.ZIP
{
    [DtsTask(DisplayName = "SharpZipLib Task",
        Description = "ZIP Task for SSIS using SharpZipLib. SharpZipLib (#ziplib, formerly NZipLib) is a compression library that supports Zip files using both stored and deflate compression methods, PKZIP 2.0 style and AES encryption, tar with GNU long filename extensions, GZip, zlib and raw deflate, as well as BZip2.",
        IconResource = "oh22is.DTS.Task.ZIP.zip.ico",
        UITypeName = "oh22is.DTS.Task.ZIP.ZipUI, oh22is.DTS.Task.ZIP2017, Version=1.0.0.0, Culture=Neutral, PublicKeyToken=28fb6a90a3947f07",
        TaskContact = "Tillmann Eitelberg, oh22information services GmbH",
        RequiredProductLevel = DTSProductLevel.None)]
    public class ZipTask : Microsoft.SqlServer.Dts.Runtime.Task
    {

        /// <summary>
        /// Variables / SSIS Properties for the configuration of the component
        /// </summary>
        #region Properties

        public string Action { get; set; }
        public string FileFolder { get; set; }
        public string Input { get; set; }
        public string Output { get; set; }
        public decimal ZipLevel { get; set; }
        public string Password { get; set; }
        public int AesKeySize { get; set; }
        public bool Zip64 { get; set; }

        #endregion Properties
       
        /// <summary>
        /// 
        /// </summary>
        /// <param name="connections"></param>
        /// <param name="variableDispenser"></param>
        /// <param name="componentEvents"></param>
        /// <param name="log"></param>
        /// <param name="transaction"></param>
        /// <returns></returns>
        public override DTSExecResult Execute(Connections connections, VariableDispenser variableDispenser, IDTSComponentEvents componentEvents, IDTSLogging log, object transaction)
        {
            bool fireAgain = false;
            try
            {
                if (Action == "ZIP")
                {
                    var compress = new Compress(Input, Output, FileFolder, ZipLevel, Password, AesKeySize, Zip64);
                    componentEvents.FireInformation(0, "SSIS ZIP Task", Input + " has been compressed", null, 0, ref fireAgain);
                    return DTSExecResult.Success;
                }
                else
                {
                    return DTSExecResult.Failure;
                }
            }
            catch (Exception ex)
            {
                componentEvents.FireError(0, "SSIS ZIP Task", ex.ToString(), null, 0);
                return DTSExecResult.Failure;
            }
        }
    }
}
