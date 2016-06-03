// ***********************************************************************
// Assembly         : Acnur.App.Aplication
// Author           : Mauricio Ospina - Cel: 3204958448 - ambrosio.mauro@gmail.com
// Created          : 14-10-2015
//
// Last Modified By : Mauricio Ospina
// Last Modified On : 03-07-2016
// ***********************************************************************
// <copyright file="Utilidades.cs" company="Alto Comisionado de las Naciones Unidas para los Refugiados - ACNUR">
//     Este producto fue desarrollado para Alto Comisionado de las Naciones Unidas para los Refugiados - ACNUR. Todos los derechos reservados.
// </copyright>
// <summary>Clase para utilidades varias.</summary>
// ***********************************************************************

/// <summary>
/// The Aplication namespace.
/// </summary>
namespace Acnur.App.Aplication
{
    using Acnur.App.Aplication.Enumerators;
    using Acnur.App.Entities;
    using DevExpress.XtraEditors;
    using DevExpress.XtraEditors.DXErrorProvider;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Globalization;
    using System.IO;
    using System.IO.Compression;
    using System.Linq;
    using System.Reflection;
    using System.Runtime.Serialization;
    using System.Runtime.Serialization.Formatters.Binary;
    using System.Text;
    using System.Web.UI.WebControls;
    using System.Windows.Forms;
    using System.Xml;

    /// <summary>
    /// Clase utilitaria
    /// </summary>
    public static class Utilities
    {
        #region "CONSTANTES"

        /// <summary>
        /// The valor defecto
        /// </summary>
        public const string ValorDefecto = "Seleccione por favor...";

        /// <summary>
        /// Constante para el valor cero
        /// </summary>
        public const string ValorCero = "0";

        /// <summary>
        /// Formato para 2 decimales
        /// </summary>
        public const string FormatoDecimalDos = "#.00";

        /// <summary>
        /// Constante publica apara el formato de pesos con decimales
        /// </summary>
        public const string FormatoDecimalPesos = "$ #,##0.00";

        /// <summary>
        /// Cadena de formato de fechas
        /// </summary>
        public const string FormatoFecha = "dd/MM/yyyy";

        /// <summary>
        /// Constante para la fecha minima
        /// </summary>
        public const string FechaMinima = "01/01/1900";

        /// <summary>
        /// Constante para la fecha máxima
        /// </summary>
        public const string FechaMaxima = "01/01/2100";

        /// <summary>
        /// Expresión Formato Fecha
        /// </summary>
        public const string ExpresionValidacionFormatoFecha = @"^(0[1-9]|[12][0-9]|3[01])[/](0[1-9]|1[012])[/](19|20)\d\d$";

        #endregion

        /// <summary>
        /// Cadena de ceros utilizada en la funcion recursiva Agregar Ceros
        /// </summary>
        /// <value>The ceros.</value>
        public static string Ceros { get; set; }

        #region Lista de tipos mime

        /// <summary>
        /// Cadenas de tipos usando la extensión de los archivos
        /// </summary>
        public static IDictionary<string, string> _mappings = new Dictionary<string, string>(StringComparer.InvariantCultureIgnoreCase) 
        {
        {".323", "text/h323"},
        {".3g2", "video/3gpp2"},
        {".3gp", "video/3gpp"},
        {".3gp2", "video/3gpp2"},
        {".3gpp", "video/3gpp"},
        {".7z", "application/x-7z-compressed"},
        {".aa", "audio/audible"},
        {".AAC", "audio/aac"},
        {".aaf", "application/octet-stream"},
        {".aax", "audio/vnd.audible.aax"},
        {".ac3", "audio/ac3"},
        {".aca", "application/octet-stream"},
        {".accda", "application/msaccess.addin"},
        {".accdb", "application/msaccess"},
        {".accdc", "application/msaccess.cab"},
        {".accde", "application/msaccess"},
        {".accdr", "application/msaccess.runtime"},
        {".accdt", "application/msaccess"},
        {".accdw", "application/msaccess.webapplication"},
        {".accft", "application/msaccess.ftemplate"},
        {".acx", "application/internet-property-stream"},
        {".AddIn", "text/xml"},
        {".ade", "application/msaccess"},
        {".adobebridge", "application/x-bridge-url"},
        {".adp", "application/msaccess"},
        {".ADT", "audio/vnd.dlna.adts"},
        {".ADTS", "audio/aac"},
        {".afm", "application/octet-stream"},
        {".ai", "application/postscript"},
        {".aif", "audio/x-aiff"},
        {".aifc", "audio/aiff"},
        {".aiff", "audio/aiff"},
        {".air", "application/vnd.adobe.air-application-installer-package+zip"},
        {".amc", "application/x-mpeg"},
        {".application", "application/x-ms-application"},
        {".art", "image/x-jg"},
        {".asa", "application/xml"},
        {".asax", "application/xml"},
        {".ascx", "application/xml"},
        {".asd", "application/octet-stream"},
        {".asf", "video/x-ms-asf"},
        {".ashx", "application/xml"},
        {".asi", "application/octet-stream"},
        {".asm", "text/plain"},
        {".asmx", "application/xml"},
        {".aspx", "application/xml"},
        {".asr", "video/x-ms-asf"},
        {".asx", "video/x-ms-asf"},
        {".atom", "application/atom+xml"},
        {".au", "audio/basic"},
        {".avi", "video/x-msvideo"},
        {".axs", "application/olescript"},
        {".bas", "text/plain"},
        {".bcpio", "application/x-bcpio"},
        {".bin", "application/octet-stream"},
        {".bmp", "image/bmp"},
        {".c", "text/plain"},
        {".cab", "application/octet-stream"},
        {".caf", "audio/x-caf"},
        {".calx", "application/vnd.ms-office.calx"},
        {".cat", "application/vnd.ms-pki.seccat"},
        {".cc", "text/plain"},
        {".cd", "text/plain"},
        {".cdda", "audio/aiff"},
        {".cdf", "application/x-cdf"},
        {".cer", "application/x-x509-ca-cert"},
        {".chm", "application/octet-stream"},
        {".class", "application/x-java-applet"},
        {".clp", "application/x-msclip"},
        {".cmx", "image/x-cmx"},
        {".cnf", "text/plain"},
        {".cod", "image/cis-cod"},
        {".config", "application/xml"},
        {".contact", "text/x-ms-contact"},
        {".coverage", "application/xml"},
        {".cpio", "application/x-cpio"},
        {".cpp", "text/plain"},
        {".crd", "application/x-mscardfile"},
        {".crl", "application/pkix-crl"},
        {".crt", "application/x-x509-ca-cert"},
        {".cs", "text/plain"},
        {".csdproj", "text/plain"},
        {".csh", "application/x-csh"},
        {".csproj", "text/plain"},
        {".css", "text/css"},
        {".csv", "text/csv"},
        {".cur", "application/octet-stream"},
        {".cxx", "text/plain"},
        {".dat", "application/octet-stream"},
        {".datasource", "application/xml"},
        {".dbproj", "text/plain"},
        {".dcr", "application/x-director"},
        {".def", "text/plain"},
        {".deploy", "application/octet-stream"},
        {".der", "application/x-x509-ca-cert"},
        {".dgml", "application/xml"},
        {".dib", "image/bmp"},
        {".dif", "video/x-dv"},
        {".dir", "application/x-director"},
        {".disco", "text/xml"},
        {".dll", "application/x-msdownload"},
        {".dll.config", "text/xml"},
        {".dlm", "text/dlm"},
        {".doc", "application/msword"},
        {".docm", "application/vnd.ms-word.document.macroEnabled.12"},
        {".docx", "application/vnd.openxmlformats-officedocument.wordprocessingml.document"},
        {".dot", "application/msword"},
        {".dotm", "application/vnd.ms-word.template.macroEnabled.12"},
        {".dotx", "application/vnd.openxmlformats-officedocument.wordprocessingml.template"},
        {".dsp", "application/octet-stream"},
        {".dsw", "text/plain"},
        {".dtd", "text/xml"},
        {".dtsConfig", "text/xml"},
        {".dv", "video/x-dv"},
        {".dvi", "application/x-dvi"},
        {".dwf", "drawing/x-dwf"},
        {".dwp", "application/octet-stream"},
        {".dxr", "application/x-director"},
        {".eml", "message/rfc822"},
        {".emz", "application/octet-stream"},
        {".eot", "application/octet-stream"},
        {".eps", "application/postscript"},
        {".etl", "application/etl"},
        {".etx", "text/x-setext"},
        {".evy", "application/envoy"},
        {".exe", "application/octet-stream"},
        {".exe.config", "text/xml"},
        {".fdf", "application/vnd.fdf"},
        {".fif", "application/fractals"},
        {".filters", "Application/xml"},
        {".fla", "application/octet-stream"},
        {".flr", "x-world/x-vrml"},
        {".flv", "video/x-flv"},
        {".fsscript", "application/fsharp-script"},
        {".fsx", "application/fsharp-script"},
        {".generictest", "application/xml"},
        {".gif", "image/gif"},
        {".group", "text/x-ms-group"},
        {".gsm", "audio/x-gsm"},
        {".gtar", "application/x-gtar"},
        {".gz", "application/x-gzip"},
        {".h", "text/plain"},
        {".hdf", "application/x-hdf"},
        {".hdml", "text/x-hdml"},
        {".hhc", "application/x-oleobject"},
        {".hhk", "application/octet-stream"},
        {".hhp", "application/octet-stream"},
        {".hlp", "application/winhlp"},
        {".hpp", "text/plain"},
        {".hqx", "application/mac-binhex40"},
        {".hta", "application/hta"},
        {".htc", "text/x-component"},
        {".htm", "text/html"},
        {".html", "text/html"},
        {".htt", "text/webviewhtml"},
        {".hxa", "application/xml"},
        {".hxc", "application/xml"},
        {".hxd", "application/octet-stream"},
        {".hxe", "application/xml"},
        {".hxf", "application/xml"},
        {".hxh", "application/octet-stream"},
        {".hxi", "application/octet-stream"},
        {".hxk", "application/xml"},
        {".hxq", "application/octet-stream"},
        {".hxr", "application/octet-stream"},
        {".hxs", "application/octet-stream"},
        {".hxt", "text/html"},
        {".hxv", "application/xml"},
        {".hxw", "application/octet-stream"},
        {".hxx", "text/plain"},
        {".i", "text/plain"},
        {".ico", "image/x-icon"},
        {".ics", "application/octet-stream"},
        {".idl", "text/plain"},
        {".ief", "image/ief"},
        {".iii", "application/x-iphone"},
        {".inc", "text/plain"},
        {".inf", "application/octet-stream"},
        {".inl", "text/plain"},
        {".ins", "application/x-internet-signup"},
        {".ipa", "application/x-itunes-ipa"},
        {".ipg", "application/x-itunes-ipg"},
        {".ipproj", "text/plain"},
        {".ipsw", "application/x-itunes-ipsw"},
        {".iqy", "text/x-ms-iqy"},
        {".isp", "application/x-internet-signup"},
        {".ite", "application/x-itunes-ite"},
        {".itlp", "application/x-itunes-itlp"},
        {".itms", "application/x-itunes-itms"},
        {".itpc", "application/x-itunes-itpc"},
        {".IVF", "video/x-ivf"},
        {".jar", "application/java-archive"},
        {".java", "application/octet-stream"},
        {".jck", "application/liquidmotion"},
        {".jcz", "application/liquidmotion"},
        {".jfif", "image/pjpeg"},
        {".jnlp", "application/x-java-jnlp-file"},
        {".jpb", "application/octet-stream"},
        {".jpe", "image/jpeg"},
        {".jpeg", "image/jpeg"},
        {".jpg", "image/jpeg"},
        {".js", "application/x-javascript"},
        {".jsx", "text/jscript"},
        {".jsxbin", "text/plain"},
        {".latex", "application/x-latex"},
        {".library-ms", "application/windows-library+xml"},
        {".lit", "application/x-ms-reader"},
        {".loadtest", "application/xml"},
        {".lpk", "application/octet-stream"},
        {".lsf", "video/x-la-asf"},
        {".lst", "text/plain"},
        {".lsx", "video/x-la-asf"},
        {".lzh", "application/octet-stream"},
        {".m13", "application/x-msmediaview"},
        {".m14", "application/x-msmediaview"},
        {".m1v", "video/mpeg"},
        {".m2t", "video/vnd.dlna.mpeg-tts"},
        {".m2ts", "video/vnd.dlna.mpeg-tts"},
        {".m2v", "video/mpeg"},
        {".m3u", "audio/x-mpegurl"},
        {".m3u8", "audio/x-mpegurl"},
        {".m4a", "audio/m4a"},
        {".m4b", "audio/m4b"},
        {".m4p", "audio/m4p"},
        {".m4r", "audio/x-m4r"},
        {".m4v", "video/x-m4v"},
        {".mac", "image/x-macpaint"},
        {".mak", "text/plain"},
        {".man", "application/x-troff-man"},
        {".manifest", "application/x-ms-manifest"},
        {".map", "text/plain"},
        {".master", "application/xml"},
        {".mda", "application/msaccess"},
        {".mdb", "application/x-msaccess"},
        {".mde", "application/msaccess"},
        {".mdp", "application/octet-stream"},
        {".me", "application/x-troff-me"},
        {".mfp", "application/x-shockwave-flash"},
        {".mht", "message/rfc822"},
        {".mhtml", "message/rfc822"},
        {".mid", "audio/mid"},
        {".midi", "audio/mid"},
        {".mix", "application/octet-stream"},
        {".mk", "text/plain"},
        {".mmf", "application/x-smaf"},
        {".mno", "text/xml"},
        {".mny", "application/x-msmoney"},
        {".mod", "video/mpeg"},
        {".mov", "video/quicktime"},
        {".movie", "video/x-sgi-movie"},
        {".mp2", "video/mpeg"},
        {".mp2v", "video/mpeg"},
        {".mp3", "audio/mpeg"},
        {".mp4", "video/mp4"},
        {".mp4v", "video/mp4"},
        {".mpa", "video/mpeg"},
        {".mpe", "video/mpeg"},
        {".mpeg", "video/mpeg"},
        {".mpf", "application/vnd.ms-mediapackage"},
        {".mpg", "video/mpeg"},
        {".mpp", "application/vnd.ms-project"},
        {".mpv2", "video/mpeg"},
        {".mqv", "video/quicktime"},
        {".ms", "application/x-troff-ms"},
        {".msi", "application/octet-stream"},
        {".mso", "application/octet-stream"},
        {".mts", "video/vnd.dlna.mpeg-tts"},
        {".mtx", "application/xml"},
        {".mvb", "application/x-msmediaview"},
        {".mvc", "application/x-miva-compiled"},
        {".mxp", "application/x-mmxp"},
        {".nc", "application/x-netcdf"},
        {".nsc", "video/x-ms-asf"},
        {".nws", "message/rfc822"},
        {".ocx", "application/octet-stream"},
        {".oda", "application/oda"},
        {".odc", "text/x-ms-odc"},
        {".odh", "text/plain"},
        {".odl", "text/plain"},
        {".odp", "application/vnd.oasis.opendocument.presentation"},
        {".ods", "application/oleobject"},
        {".odt", "application/vnd.oasis.opendocument.text"},
        {".one", "application/onenote"},
        {".onea", "application/onenote"},
        {".onepkg", "application/onenote"},
        {".onetmp", "application/onenote"},
        {".onetoc", "application/onenote"},
        {".onetoc2", "application/onenote"},
        {".orderedtest", "application/xml"},
        {".osdx", "application/opensearchdescription+xml"},
        {".p10", "application/pkcs10"},
        {".p12", "application/x-pkcs12"},
        {".p7b", "application/x-pkcs7-certificates"},
        {".p7c", "application/pkcs7-mime"},
        {".p7m", "application/pkcs7-mime"},
        {".p7r", "application/x-pkcs7-certreqresp"},
        {".p7s", "application/pkcs7-signature"},
        {".pbm", "image/x-portable-bitmap"},
        {".pcast", "application/x-podcast"},
        {".pct", "image/pict"},
        {".pcx", "application/octet-stream"},
        {".pcz", "application/octet-stream"},
        {".pdf", "application/pdf"},
        {".pfb", "application/octet-stream"},
        {".pfm", "application/octet-stream"},
        {".pfx", "application/x-pkcs12"},
        {".pgm", "image/x-portable-graymap"},
        {".pic", "image/pict"},
        {".pict", "image/pict"},
        {".pkgdef", "text/plain"},
        {".pkgundef", "text/plain"},
        {".pko", "application/vnd.ms-pki.pko"},
        {".pls", "audio/scpls"},
        {".pma", "application/x-perfmon"},
        {".pmc", "application/x-perfmon"},
        {".pml", "application/x-perfmon"},
        {".pmr", "application/x-perfmon"},
        {".pmw", "application/x-perfmon"},
        {".png", "image/png"},
        {".pnm", "image/x-portable-anymap"},
        {".pnt", "image/x-macpaint"},
        {".pntg", "image/x-macpaint"},
        {".pnz", "image/png"},
        {".pot", "application/vnd.ms-powerpoint"},
        {".potm", "application/vnd.ms-powerpoint.template.macroEnabled.12"},
        {".potx", "application/vnd.openxmlformats-officedocument.presentationml.template"},
        {".ppa", "application/vnd.ms-powerpoint"},
        {".ppam", "application/vnd.ms-powerpoint.addin.macroEnabled.12"},
        {".ppm", "image/x-portable-pixmap"},
        {".pps", "application/vnd.ms-powerpoint"},
        {".ppsm", "application/vnd.ms-powerpoint.slideshow.macroEnabled.12"},
        {".ppsx", "application/vnd.openxmlformats-officedocument.presentationml.slideshow"},
        {".ppt", "application/vnd.ms-powerpoint"},
        {".pptm", "application/vnd.ms-powerpoint.presentation.macroEnabled.12"},
        {".pptx", "application/vnd.openxmlformats-officedocument.presentationml.presentation"},
        {".prf", "application/pics-rules"},
        {".prm", "application/octet-stream"},
        {".prx", "application/octet-stream"},
        {".ps", "application/postscript"},
        {".psc1", "application/PowerShell"},
        {".psd", "application/octet-stream"},
        {".psess", "application/xml"},
        {".psm", "application/octet-stream"},
        {".psp", "application/octet-stream"},
        {".pub", "application/x-mspublisher"},
        {".pwz", "application/vnd.ms-powerpoint"},
        {".qht", "text/x-html-insertion"},
        {".qhtm", "text/x-html-insertion"},
        {".qt", "video/quicktime"},
        {".qti", "image/x-quicktime"},
        {".qtif", "image/x-quicktime"},
        {".qtl", "application/x-quicktimeplayer"},
        {".qxd", "application/octet-stream"},
        {".ra", "audio/x-pn-realaudio"},
        {".ram", "audio/x-pn-realaudio"},
        {".rar", "application/octet-stream"},
        {".ras", "image/x-cmu-raster"},
        {".rat", "application/rat-file"},
        {".rc", "text/plain"},
        {".rc2", "text/plain"},
        {".rct", "text/plain"},
        {".rdlc", "application/xml"},
        {".resx", "application/xml"},
        {".rf", "image/vnd.rn-realflash"},
        {".rgb", "image/x-rgb"},
        {".rgs", "text/plain"},
        {".rm", "application/vnd.rn-realmedia"},
        {".rmi", "audio/mid"},
        {".rmp", "application/vnd.rn-rn_music_package"},
        {".roff", "application/x-troff"},
        {".rpm", "audio/x-pn-realaudio-plugin"},
        {".rqy", "text/x-ms-rqy"},
        {".rtf", "application/rtf"},
        {".rtx", "text/richtext"},
        {".ruleset", "application/xml"},
        {".s", "text/plain"},
        {".safariextz", "application/x-safari-safariextz"},
        {".scd", "application/x-msschedule"},
        {".sct", "text/scriptlet"},
        {".sd2", "audio/x-sd2"},
        {".sdp", "application/sdp"},
        {".sea", "application/octet-stream"},
        {".searchConnector-ms", "application/windows-search-connector+xml"},
        {".setpay", "application/set-payment-initiation"},
        {".setreg", "application/set-registration-initiation"},
        {".settings", "application/xml"},
        {".sgimb", "application/x-sgimb"},
        {".sgml", "text/sgml"},
        {".sh", "application/x-sh"},
        {".shar", "application/x-shar"},
        {".shtml", "text/html"},
        {".sit", "application/x-stuffit"},
        {".sitemap", "application/xml"},
        {".skin", "application/xml"},
        {".sldm", "application/vnd.ms-powerpoint.slide.macroEnabled.12"},
        {".sldx", "application/vnd.openxmlformats-officedocument.presentationml.slide"},
        {".slk", "application/vnd.ms-excel"},
        {".sln", "text/plain"},
        {".slupkg-ms", "application/x-ms-license"},
        {".smd", "audio/x-smd"},
        {".smi", "application/octet-stream"},
        {".smx", "audio/x-smd"},
        {".smz", "audio/x-smd"},
        {".snd", "audio/basic"},
        {".snippet", "application/xml"},
        {".snp", "application/octet-stream"},
        {".sol", "text/plain"},
        {".sor", "text/plain"},
        {".spc", "application/x-pkcs7-certificates"},
        {".spl", "application/futuresplash"},
        {".src", "application/x-wais-source"},
        {".srf", "text/plain"},
        {".SSISDeploymentManifest", "text/xml"},
        {".ssm", "application/streamingmedia"},
        {".sst", "application/vnd.ms-pki.certstore"},
        {".stl", "application/vnd.ms-pki.stl"},
        {".sv4cpio", "application/x-sv4cpio"},
        {".sv4crc", "application/x-sv4crc"},
        {".svc", "application/xml"},
        {".swf", "application/x-shockwave-flash"},
        {".t", "application/x-troff"},
        {".tar", "application/x-tar"},
        {".tcl", "application/x-tcl"},
        {".testrunconfig", "application/xml"},
        {".testsettings", "application/xml"},
        {".tex", "application/x-tex"},
        {".texi", "application/x-texinfo"},
        {".texinfo", "application/x-texinfo"},
        {".tgz", "application/x-compressed"},
        {".thmx", "application/vnd.ms-officetheme"},
        {".thn", "application/octet-stream"},
        {".tif", "image/tiff"},
        {".tiff", "image/tiff"},
        {".tlh", "text/plain"},
        {".tli", "text/plain"},
        {".toc", "application/octet-stream"},
        {".tr", "application/x-troff"},
        {".trm", "application/x-msterminal"},
        {".trx", "application/xml"},
        {".ts", "video/vnd.dlna.mpeg-tts"},
        {".tsv", "text/tab-separated-values"},
        {".ttf", "application/octet-stream"},
        {".tts", "video/vnd.dlna.mpeg-tts"},
        {".txt", "text/plain"},
        {".u32", "application/octet-stream"},
        {".uls", "text/iuls"},
        {".user", "text/plain"},
        {".ustar", "application/x-ustar"},
        {".vb", "text/plain"},
        {".vbdproj", "text/plain"},
        {".vbk", "video/mpeg"},
        {".vbproj", "text/plain"},
        {".vbs", "text/vbscript"},
        {".vcf", "text/x-vcard"},
        {".vcproj", "Application/xml"},
        {".vcs", "text/plain"},
        {".vcxproj", "Application/xml"},
        {".vddproj", "text/plain"},
        {".vdp", "text/plain"},
        {".vdproj", "text/plain"},
        {".vdx", "application/vnd.ms-visio.viewer"},
        {".vml", "text/xml"},
        {".vscontent", "application/xml"},
        {".vsct", "text/xml"},
        {".vsd", "application/vnd.visio"},
        {".vsi", "application/ms-vsi"},
        {".vsix", "application/vsix"},
        {".vsixlangpack", "text/xml"},
        {".vsixmanifest", "text/xml"},
        {".vsmdi", "application/xml"},
        {".vspscc", "text/plain"},
        {".vss", "application/vnd.visio"},
        {".vsscc", "text/plain"},
        {".vssettings", "text/xml"},
        {".vssscc", "text/plain"},
        {".vst", "application/vnd.visio"},
        {".vstemplate", "text/xml"},
        {".vsto", "application/x-ms-vsto"},
        {".vsw", "application/vnd.visio"},
        {".vsx", "application/vnd.visio"},
        {".vtx", "application/vnd.visio"},
        {".wav", "audio/wav"},
        {".wave", "audio/wav"},
        {".wax", "audio/x-ms-wax"},
        {".wbk", "application/msword"},
        {".wbmp", "image/vnd.wap.wbmp"},
        {".wcm", "application/vnd.ms-works"},
        {".wdb", "application/vnd.ms-works"},
        {".wdp", "image/vnd.ms-photo"},
        {".webarchive", "application/x-safari-webarchive"},
        {".webtest", "application/xml"},
        {".wiq", "application/xml"},
        {".wiz", "application/msword"},
        {".wks", "application/vnd.ms-works"},
        {".WLMP", "application/wlmoviemaker"},
        {".wlpginstall", "application/x-wlpg-detect"},
        {".wlpginstall3", "application/x-wlpg3-detect"},
        {".wm", "video/x-ms-wm"},
        {".wma", "audio/x-ms-wma"},
        {".wmd", "application/x-ms-wmd"},
        {".wmf", "application/x-msmetafile"},
        {".wml", "text/vnd.wap.wml"},
        {".wmlc", "application/vnd.wap.wmlc"},
        {".wmls", "text/vnd.wap.wmlscript"},
        {".wmlsc", "application/vnd.wap.wmlscriptc"},
        {".wmp", "video/x-ms-wmp"},
        {".wmv", "video/x-ms-wmv"},
        {".wmx", "video/x-ms-wmx"},
        {".wmz", "application/x-ms-wmz"},
        {".wpl", "application/vnd.ms-wpl"},
        {".wps", "application/vnd.ms-works"},
        {".wri", "application/x-mswrite"},
        {".wrl", "x-world/x-vrml"},
        {".wrz", "x-world/x-vrml"},
        {".wsc", "text/scriptlet"},
        {".wsdl", "text/xml"},
        {".wvx", "video/x-ms-wvx"},
        {".x", "application/directx"},
        {".xaf", "x-world/x-vrml"},
        {".xaml", "application/xaml+xml"},
        {".xap", "application/x-silverlight-app"},
        {".xbap", "application/x-ms-xbap"},
        {".xbm", "image/x-xbitmap"},
        {".xdr", "text/plain"},
        {".xht", "application/xhtml+xml"},
        {".xhtml", "application/xhtml+xml"},
        {".xla", "application/vnd.ms-excel"},
        {".xlam", "application/vnd.ms-excel.addin.macroEnabled.12"},
        {".xlc", "application/vnd.ms-excel"},
        {".xld", "application/vnd.ms-excel"},
        {".xlk", "application/vnd.ms-excel"},
        {".xll", "application/vnd.ms-excel"},
        {".xlm", "application/vnd.ms-excel"},
        {".xls", "application/vnd.ms-excel"},
        {".xlsb", "application/vnd.ms-excel.sheet.binary.macroEnabled.12"},
        {".xlsm", "application/vnd.ms-excel.sheet.macroEnabled.12"},
        {".xlsx", "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet"},
        {".xlt", "application/vnd.ms-excel"},
        {".xltm", "application/vnd.ms-excel.template.macroEnabled.12"},
        {".xltx", "application/vnd.openxmlformats-officedocument.spreadsheetml.template"},
        {".xlw", "application/vnd.ms-excel"},
        {".xml", "text/xml"},
        {".xmta", "application/xml"},
        {".xof", "x-world/x-vrml"},
        {".XOML", "text/plain"},
        {".xpm", "image/x-xpixmap"},
        {".xps", "application/vnd.ms-xpsdocument"},
        {".xrm-ms", "text/xml"},
        {".xsc", "application/xml"},
        {".xsd", "text/xml"},
        {".xsf", "text/xml"},
        {".xsl", "text/xml"},
        {".xslt", "text/xml"},
        {".xsn", "application/octet-stream"},
        {".xss", "application/xml"},
        {".xtp", "application/octet-stream"},
        {".xwd", "image/x-xwindowdump"},
        {".z", "application/x-compress"},
        {".zip", "application/x-zip-compressed"},
        
        };

        #endregion

        /// <summary>
        /// Trae el tipo mime de una extensión
        /// </summary>
        /// <param name="extension">Cadena de la extensión .bmp .pdf etc</param>
        /// <returns>Retorna el tipo mime o binario si no encuentra el tipo asociado a la extensión</returns>
        public static string TraerTipoMime(string extension)
        {
            if (!extension.StartsWith("."))
            {
                extension = "." + extension;
            }

            string mime;

            return _mappings.TryGetValue(extension, out mime) ? mime : "application/octet-stream";
        }

        /// <summary>
        /// Método que devuelve un objeto de tipo DateTime a partir de una fecha en formato texto.
        /// </summary>
        /// <param name="fecha">Fecha que se va a convertir.</param>
        /// <returns>Objeto que representa la fecha en formato texto.</returns>
        public static DateTime CalculaFecha(string fecha)
        {
            DateTime resultado;
            return string.IsNullOrWhiteSpace(fecha) == true || DateTime.TryParse(fecha, out resultado) == false ? DateTime.MinValue : DateTime.Parse(fecha, CultureInfo.CurrentCulture);
        }

        /// <summary>
        /// Retorna la diferencia de dos fechas en meses
        /// </summary>
        /// <param name="fecha1">Fecha inicio del rango</param>
        /// <param name="fecha2">Fecha fin del rango</param>
        /// <returns>Valor absoluto de la diferencia en meses</returns>
        public static int DiferenciaFechasMeses(this DateTime fecha1, DateTime fecha2)
        {
            return Math.Abs(((fecha1.Year * 12) + fecha1.Month) - ((fecha2.Year * 12) + fecha2.Month));
        }

        /// <summary>
        /// Convierte un DetalleBasica en un enum
        /// </summary>
        /// <typeparam name="TEnumerado">Tipo de enum</typeparam>
        /// <param name="parametro">Registro de la tabla detalle basica</param>
        /// <returns>Retorna una enumeracion</returns>
        public static TEnumerado Convertir<TEnumerado>(ParameterDetail parametro)
        {
            Type tipoEnum = typeof(TEnumerado);
            TEnumerado value = (TEnumerado)Enum.ToObject(tipoEnum, parametro.Ordinal);
            return value;
        }

        /// <summary>
        /// Retorna el id de un detalle parametro de una lista de TabParameterDetail
        /// que corresponde a la enumeracion
        /// </summary>
        /// <typeparam name="TEnumerado">Enumeracion deseada</typeparam>
        /// <param name="parametros">Lista de parametros</param>
        /// <param name="enumerado">Enumeracion con el valor por defecto</param>
        /// <returns>Retorna el IdParameterDetail de la lista que corresponde</returns>
        public static int ValorIdParameterDetail<TEnumerado>(List<ParameterDetail> parametros, TEnumerado enumerado)
        {
            int identificadorEnumerado = (int)(object)enumerado;
            foreach (ParameterDetail parametro in parametros)
            {
                if (parametro.Ordinal == identificadorEnumerado)
                {
                    return parametro.IdParameterDetail;
                }
            }

            return -1;
        }

        /// <summary>
        /// Convierte de un ParameterDetail cual es el tipo de parametro
        /// al que pertenece
        /// </summary>
        /// <param name="parametro">Objeto de detalle Parameter</param>
        /// <returns>Retorna el tipo de parametro</returns>
        public static TypeParameter ObtenerTipoParametro(ParameterDetail parametro)
        {
            return (TypeParameter)parametro.IdParameter;
        }

        /// <summary>
        /// Convierte de un parametro cual es el tipo de parametro
        /// al que pertenece
        /// </summary>
        /// <param name="parametro">Objeto de Parameter</param>
        /// <returns>Retorna el tipo de parametro</returns>
        public static TypeParameter ObtenerTipoParametro(Acnur.App.Entities.Parameter parametro)
        {
            return (TypeParameter)parametro.IdParameter;
        }

        /// <summary>
        /// Selecciona un valor por defecto de un enumerado en la lista
        /// </summary>
        /// <typeparam name="TEnumerado">Tipo anonimo de enumerados</typeparam>
        /// <param name="lista">Dropdownlist o ComboBox</param>
        /// <param name="parametros">Lista de ParameterDetail</param>
        /// <param name="enumerado">Enumerado del valor por defecto</param>
        /// <param name="llenar">Si desea incluir el llenado del combobox</param>
        /// <param name="itemSeleccioneOpcion">Opcion para incluir el item seleccione dentro del combo</param>
        public static void SeleccionarValorXDefectoDDL<TEnumerado>(ComboBoxEdit lista, List<ParameterDetail> parametros, TEnumerado enumerado, bool llenar = true, bool itemSeleccioneOpcion = false)
        {
            SeleccionarValorXDefectoDDLId(lista, parametros, ValorIdParameterDetail(parametros, enumerado).ToString(), llenar);
        }

        /// <summary>
        /// Selecciona un vvalor por defecto de un enumerado en la lista
        /// </summary>
        /// <param name="lista">Dropdownlist o ComboBox</param>
        /// <param name="parametros">Lista de ParameterDetail</param>
        /// <param name="identificadorLlave">Llave de valor por defecto</param>
        /// <param name="llenar">Si desea incluir el llenado del combobox</param>
        /// <param name="itemSeleccioneOpcion">Opcion para incluir el item seleccione dentro del combo</param>
        public static void SeleccionarValorXDefectoDDLId(ComboBoxEdit lista, List<ParameterDetail> parametros, int identificadorLlave, bool llenar = true, bool itemSeleccioneOpcion = false)
        {
            SeleccionarValorXDefectoDDLId(lista, parametros, identificadorLlave.ToString(), llenar, itemSeleccioneOpcion);
        }

        /// <summary>
        /// Selecciona un vvalor por defecto de un enumerado en la lista
        /// </summary>
        /// <param name="lista">Dropdownlist o ComboBox</param>
        /// <param name="parametros">Lista de ParameterDetail</param>
        /// <param name="identificadorLlave">Llave de valor por defecto</param>
        /// <param name="llenar">Si desea incluir el llenado del combobox</param>
        /// <param name="itemSeleccioneOpcion">Opcion para incluir el item seleccione dentro del combo</param>
        public static void SeleccionarValorXDefectoDDLId(ComboBoxEdit lista, List<ParameterDetail> parametros, string identificadorLlave, bool llenar = true, bool itemSeleccioneOpcion = false)
        {
            if (itemSeleccioneOpcion)
            {
                lista.Properties.Items.Insert(0, (new ListItem(ValorDefecto, ValorCero)));
            }

            if (llenar)
            {
                LlenarLista(lista, parametros);
            }

            lista.SelectedIndex = 0;
        }

        /// <summary>
        /// Llena un dropdownlist (combobox) con una lista de parametros
        /// </summary>
        /// <param name="lista">Dropdownlist o ComboBox</param>
        /// <param name="parametros">Lista de ParameterDetail</param>
        public static void LlenarLista(ComboBoxEdit lista, List<ParameterDetail> parametros)
        {
            foreach (ParameterDetail parametro in parametros)
            {
                lista.Properties.Items.Add(new ListItem(parametro.Name, parametro.IdParameterDetail.ToString()));
            }
        }

        /// <summary>
        /// Llena un ComboBox con la lista de parámetros editables
        /// </summary>
        /// <param name="lista">Dropdownlist o ComboBox</param>
        /// <param name="parametros">Lista de Parameter</param>
        public static void LlenarLista(ComboBoxEdit lista, List<Acnur.App.Entities.Parameter> parametros)
        {
            lista.Properties.Items.Insert(0, (new ListItem(ValorDefecto, ValorCero)));

            foreach (Acnur.App.Entities.Parameter parametro in parametros)
            {
                lista.Properties.Items.Add(new ListItem(parametro.Name, parametro.IdParameter.ToString()));
            }

            lista.SelectedIndex = 0;
        }

        /// <summary>
        /// Llena un dropdownlist (combobox) con una lista de parametros y el codigo es el ordinal
        /// </summary>
        /// <param name="lista">Dropdownlist o ComboBox</param>
        /// <param name="parametros">Lista de ParameterDetail</param>
        public static void LlenarListaOrdinal(ComboBoxEdit lista, List<ParameterDetail> parametros)
        {
            foreach (ParameterDetail parametro in parametros)
            {
                lista.Properties.Items.Add(new ListItem(parametro.Name, parametro.Ordinal.ToString()));
            }
        }

        /// <summary>
        /// Método que devuelve la cadena que representa la fecha especificada.
        /// </summary>
        /// <param name="fecha">Objeto fecha que se va a convertir.</param>
        /// <returns>Cadena que representa la fecha especificada.</returns>
        public static string ObtenerCadenaDeFecha(DateTime? fecha)
        {
            return fecha.HasValue ? fecha.Value.ToString(FormatoFecha).Trim() : string.Empty;
        }

        /// <summary>
        /// Calcula la edad en años
        /// </summary>
        /// <param name="fechaNacimiento">Fecha de nacimiento</param>
        /// <param name="fechaCalculo">Fecha de calculo</param>
        /// <returns>Un entero con la edad en años</returns>
        public static int CalcularEdadAnios(DateTime fechaNacimiento, DateTime fechaCalculo)
        {
            int anios = fechaCalculo.Year - fechaNacimiento.Year;

            if (fechaCalculo.Month < fechaNacimiento.Month || (fechaCalculo.Month == fechaNacimiento.Month && fechaCalculo.Day < fechaNacimiento.Day))
            {
                anios--;
            }

            return anios;
        }

        /// <summary>
        /// Método que devuelve el nombre del mes asociado a un número de mes (1 a 13).
        /// </summary>
        /// <param name="numeroMes">Número del mes en el rango de 1 a 13.</param>
        /// <returns>Nombre del mes asociado a un número de mes (1 a 13).</returns>
        public static string ObtenerNombreMes(int numeroMes)
        {
            string nombreMes = string.Empty;

            if (numeroMes > 0 && numeroMes <= 13)
            {
                string mes = System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(numeroMes);
                nombreMes = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(mes);
            }

            return nombreMes;
        }

        /// <summary>
        /// Método para serializar un objeto
        /// </summary>
        /// <param name="objeto">Objeto a serializar</param>
        /// <returns>Cadena XMl de objeto</returns>
        public static byte[] Serializar(object objeto)
        {
            MemoryStream ms = new MemoryStream();
            XmlDictionaryWriter writer = XmlDictionaryWriter.CreateTextWriter(ms, Encoding.UTF8);
            DataContractSerializer dcs = new DataContractSerializer(objeto.GetType());
            dcs.WriteObject(writer, objeto);
            writer.Flush();

            return ms.GetBuffer();
        }

        /// <summary>
        /// Método para deserializar arreglo de bytes dado
        /// </summary>
        /// <param name="objetoSerializado">Objeto serializado</param>
        /// <param name="nuevoTipo">Tipo de objeto a devolver</param>
        /// <returns>Obejo deserializado</returns>
        public static object Deserialize(byte[] objetoSerializado, Type nuevoTipo)
        {
            MemoryStream memoryStream = new MemoryStream(objetoSerializado);
            XmlDictionaryReader reader = XmlDictionaryReader.CreateTextReader(memoryStream, Encoding.UTF8, new XmlDictionaryReaderQuotas(), null);
            DataContractSerializer dataContractSerializer = new DataContractSerializer(nuevoTipo);
            return dataContractSerializer.ReadObject(reader);
        }

        /// <summary>
        /// Método que serializa objeto enviado
        /// </summary>
        /// <param name="objObjeto">Objeto a serializar</param>
        /// <returns>Arreglo de Bytes</returns>
        public static byte[] SerializarXML(object objObjeto)
        {
            object nvo = Copiar(objObjeto);
            LimpiarPropBytePropAgregacion(nvo);

            var formatter = new BinaryFormatter();
            byte[] content;
            using (var ms = new MemoryStream())
            {
                using (var ds = new DeflateStream(ms, CompressionMode.Compress, true))
                {
                    formatter.Serialize(ds, nvo);
                }

                ms.Position = 0;
                content = ms.GetBuffer();
            }

            return content;
        }

        /// <summary>
        /// Método para deserializar arreglo de bytes dado
        /// </summary>
        /// <param name="objetoSerializado">Objeto serializado</param>
        /// <returns>Cadena string DesSerializada</returns>
        public static string DesSerializarXML(byte[] objetoSerializado)
        {
            if (objetoSerializado.Length <= 0)
            {
                return string.Empty;
            }

            object result = null;
            var formatter = new BinaryFormatter();
            using (var ms = new MemoryStream(objetoSerializado))
            {
                using (var ds = new DeflateStream(ms, CompressionMode.Decompress, true))
                {
                    result = formatter.Deserialize(ds);
                }
            }

            string strDatos = string.Empty;

            foreach (PropertyInfo item in result.GetType().GetProperties())
            {
                if (item.Name.IndexOf("Tab") < 0)
                {
                    strDatos += item.Name + ":";
                    strDatos += GetValueProperty(item.Name, result) + ";";
                }
            }

            return strDatos;
        }

        /// <summary>
        /// Método que elimina arreglo de bytes de un objeto y agregaciones
        /// </summary>
        /// <param name="objeto">Objeto a eliminar propiedades con arreglo de bytes</param>
        public static void LimpiarPropBytePropAgregacion(object objeto)
        {
            foreach (PropertyInfo item in objeto.GetType().GetProperties())
            {
                if (item.PropertyType.FullName.Equals("System.Byte[]") || item.PropertyType.FullName.Contains("DOMAIN.ENTITIES"))
                {
                    item.SetValue(objeto, null, null);
                }
            }
        }

        /// <summary>
        /// Método para agregar ceros a un string
        /// </summary>
        /// <param name="cantidad">Cantidad de ceros a agregar</param>
        public static void AgregarCeros(int cantidad)
        {
            if (cantidad > 0)
            {
                Ceros = Ceros + "0";
                cantidad = cantidad - 1;
                AgregarCeros(cantidad);
            }
        }

        /// <summary>
        /// Permite obtener la IP del cliente que realiza la solicitud.
        /// </summary>
        /// <returns>Dirección IP.</returns>
        public static string ObtenerDireccionIP()
        {
            string direccionIP = "127.0.0.1";

            if (System.Web.HttpContext.Current != null)
            {
                string cadenaDireccionesIPs = System.Web.HttpContext.Current.Request.ServerVariables["HTTP_X_FORWARDED_FOR"];

                if (!string.IsNullOrEmpty(cadenaDireccionesIPs))
                {
                    direccionIP = cadenaDireccionesIPs.Split(',')[0];
                }

                direccionIP = System.Web.HttpContext.Current.Request.ServerVariables["REMOTE_ADDR"];
            }

            return direccionIP;
        }

        /// <summary>
        /// Permite obtener el Usurio de Windows
        /// </summary>
        /// <returns>Dirección IP.</returns>
        public static string ObtenerUsuarioWindows()
        {
            string usuarioWindows = string.Empty;

            if (!string.IsNullOrEmpty(System.Web.HttpContext.Current.Request.ServerVariables["LOGON_USER"]))
            {
                usuarioWindows = System.Web.HttpContext.Current.Request.ServerVariables["LOGON_USER"];

                if (usuarioWindows.IndexOf('\\') > 0)
                {
                    usuarioWindows = usuarioWindows.Split('\\')[1];
                }
            }

            //// Para ambiente de desarrollo
            if (System.Configuration.ConfigurationManager.AppSettings.Get("LoginDesarrollo").ToLower().Equals("si") && string.IsNullOrEmpty(usuarioWindows))
            {
                usuarioWindows = System.Environment.UserName;
            }

            return usuarioWindows;
        }

        /// <summary>
        /// Retorna las propiedadesinfo de un tipo para un tipo
        /// </summary>
        /// <param name="origen">Tipo que tiene propriedades de un tipo repetidas</param>
        /// <param name="propiedadBusqueda">Tipo a buscar en la propiedad</param>
        /// <returns>Lista de propiedades info encontradas con el tipo propiedadBusqueda</returns>
        public static System.Reflection.PropertyInfo[] PropiedadesPorTipo(Type origen, Type propiedadBusqueda)
        {
            List<System.Reflection.PropertyInfo> retorno = new List<System.Reflection.PropertyInfo>();
            System.Reflection.PropertyInfo[] listaPropiedades = origen.GetProperties();

            foreach (System.Reflection.PropertyInfo propiedad in listaPropiedades)
            {
                if (propiedad.PropertyType.Name.Equals(propiedadBusqueda.Name))
                {
                    retorno.Add(propiedad);
                }
            }

            return retorno.ToArray();
        }

        /// <summary>
        /// Método que compara dos objetos
        /// </summary>
        /// <param name="objetoUno">Objeto uno</param>
        /// <param name="objetoDos">Objeto dos</param>
        /// <param name="propiedadesOmitir">The propiedades omitir.</param>
        /// <returns>Valor bool que indica si son o no iguales los objetos pasados</returns>
        public static bool SonIguales(object objetoUno, object objetoDos, string[] propiedadesOmitir)
        {
            bool sonIguales = true;

            if (objetoUno != null && objetoDos != null)
            {
                string valorUno = string.Empty;
                string valorDos = string.Empty;

                foreach (PropertyInfo itemUno in objetoUno.GetType().GetProperties())
                {
                    if (!Array.Exists(propiedadesOmitir, prop => prop == itemUno.Name) && itemUno.Name.IndexOf("Tab") < 0)
                    {
                        foreach (PropertyInfo itemDos in objetoDos.GetType().GetProperties())
                        {
                            if (itemUno.Name.Equals(itemDos.Name))
                            {
                                valorUno = itemUno.GetValue(objetoUno, null) != null ? itemUno.GetValue(objetoUno, null).ToString() : string.Empty;
                                valorDos = itemDos.GetValue(objetoDos, null) != null ? itemDos.GetValue(objetoDos, null).ToString() : string.Empty;

                                if (!valorUno.Equals(valorDos))
                                {
                                    sonIguales = false;
                                    break;
                                }
                                break;
                            }
                        }
                    }
                    if (!sonIguales)
                    {
                        break;
                    }
                }
            }

            return sonIguales;
        }

        /// <summary>
        /// Escribe en archivo de log el texto deseado
        /// </summary>
        /// <param name="texto">Texto a escribir</param>
        public static void Logear(string texto)
        {
            string path = @"c:\temp\log.txt";
            using (System.IO.StreamWriter sw = System.IO.File.AppendText(path))
            {
                sw.WriteLine(texto);
            }
        }

        /// <summary>
        /// Retorna el item de seleecion por defecto
        /// </summary>
        /// <param name="descripcion">Descripción opcional si debe mostrar inicialmente algo diferente a (-Seleccionar-)</param>
        /// <returns>Un listitem inicial</returns>
        public static ListItem ItemSeleccioneOpcion(string descripcion)
        {
            if (string.IsNullOrEmpty(descripcion))
            {
                descripcion = ValorDefecto;
            }

            return new ListItem(descripcion, "-1");
        }

        /// <summary>
        /// Método para Clonar un objeto
        /// </summary>
        /// <param name="from">Objeto con origen de datos</param>
        /// <returns>Objeto clonado</returns>
        public static object Copiar(object from)
        {
            object result = Activator.CreateInstance(from.GetType());
            Copiar(from, result);
            return result;
        }

        /// <summary>
        /// Método para clonar por referencia
        /// </summary>
        /// <param name="from">Objeto Origen</param>
        /// <param name="result">Objeto Destino</param>
        public static void Copiar(object from, object result)
        {
            Type type = from.GetType();
            Type typeResult = result.GetType();

            foreach (PropertyInfo propertyInfo in type.GetProperties())
            {
                try
                {
                    object valor = type.InvokeMember(propertyInfo.Name, BindingFlags.GetProperty, null, from, new object[] { });

                    PropertyInfo mi = typeResult.GetProperty(propertyInfo.Name);

                    if (mi != null)
                    {
                        type.InvokeMember(propertyInfo.Name, BindingFlags.SetProperty, null, result, new object[] { valor });
                    }
                }
                catch (Exception)
                {
                }
            }
        }

        /// <summary>
        /// Método que obtiene el valor de una propiedad dada para un objeto tipo object
        /// </summary>
        /// <param name="propiedad">Nombre de la propiedad a obtener valor</param>
        /// <param name="objSearch">Obejto del cual se quiere obtener el valor</param>
        /// <returns>Valor de la propiedad indicada</returns>
        public static string GetValueProperty(string propiedad, object objSearch)
        {
            string valor = string.Empty;

            foreach (PropertyInfo item in objSearch.GetType().GetProperties())
            {
                if (item.Name.Equals(propiedad))
                {
                    valor = item.GetValue(objSearch, null) != null ? item.GetValue(objSearch, null).ToString() : string.Empty;
                    break;
                }
            }

            return valor;
        }

        /// <summary>
        /// Retorna los valores de las propiedades de una  entidad
        /// </summary>
        /// <typeparam name="T">Tipo entidad generica</typeparam>
        /// <param name="clase">Entidad o clase</param>
        /// <returns>Una cadena con los valores del objeto</returns>
        public static string RetornarPropiedades<T>(T clase)
        {
            string cadena = string.Empty;

            foreach (PropertyInfo propertyInfo in clase.GetType().GetProperties())
            {
                cadena = cadena + propertyInfo.GetValue(clase, null).ToString();
            }

            return cadena;
        }

        /// <summary>
        /// Método que realiza la serialización de un objeto en una cadena de caracteres en formato JSON
        /// </summary>
        /// <typeparam name="T">Tipo del objeto a serializar</typeparam>
        /// <param name="objetoASerializar">Objeto a serializar</param>
        /// <returns>Cadena que representa el objeto serializado en formato JSON</returns>
        public static string SerializarJson<T>(T objetoASerializar)
        {
            var serializador = new System.Web.Script.Serialization.JavaScriptSerializer();
            return serializador.Serialize(objetoASerializar);
        }

        /// <summary>
        /// Método que deserializa una cadena en fomrato JSON a un objeto del tipo especificado
        /// </summary>
        /// <typeparam name="T">Tipo del objeto a deserializar</typeparam>
        /// <param name="objetoSerializado">Cadena en formato JSON que contiene los datos de un objeto serializado</param>
        /// <returns>Objeto deserializado.</returns>
        public static T DeserializarJson<T>(string objetoSerializado)
        {
            var serializador = new System.Web.Script.Serialization.JavaScriptSerializer();
            return serializador.Deserialize<T>(objetoSerializado);
        }

        /// <summary>
        /// Método que deja en mayuscula la primera letra de una palabra dentro de una frase.
        /// </summary>
        /// <param name="entrada">Cadena de entrada.</param>
        /// <returns>Cadena de salida.</returns>
        public static string AsignarMayusculaPrimeraLetraPalabra(string entrada)
        {
            string[] palabras = entrada.Split(' ');
            string salida = string.Empty;

            List<string> listadoPalabrasSalida = new List<string>();

            if (palabras.Length > 1)
            {
                foreach (var palabra in palabras)
                {
                    string palabraSalida = palabra.ToLower();

                    if (palabra.Length > 3)
                    {
                        palabraSalida = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(palabraSalida);
                    }

                    listadoPalabrasSalida.Add(palabraSalida);
                }

                salida = string.Join(" ", listadoPalabrasSalida);
            }
            else
            {
                salida = palabras[0].Length > 4 ? System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(palabras[0].ToLower()) : palabras[0];
            }

            return salida;
        }

        /// <summary>
        /// Retorna el máximo de caracteres permitido. Para este caso van a ser 4000 caracteres
        /// </summary>
        /// <param name="entrada">cadena de texto</param>
        /// <returns>cadena de texto con el límite de 4000 caracteres</returns>
        public static string RetornarMaximoString(string entrada)
        {
            string retorno = entrada;

            if (entrada.Length > 4000)
            {
                retorno = entrada.Substring(0, 3999);
            }

            return retorno;
        }

        /// <summary>
        /// Listas de meses del año.
        /// </summary>
        /// <param name="ddlMonth">DropDownList que se quiere llenar</param>
        public static void ListaMesesAnio(ref DropDownList ddlMonth)
        {
            int MesValue = 1;
            var americanCulture = new CultureInfo("es-CO");

            foreach (var item in americanCulture.DateTimeFormat.MonthNames)
            {
                ddlMonth.Items.Add(new ListItem(item, MesValue.ToString()));
                MesValue++;
            }

            ddlMonth.Items.Insert(0, ItemSeleccioneOpcion(string.Empty));
        }

        /// <summary>
        /// Listas de los años con el año actual desde el anio de inicio.
        /// </summary>
        /// <param name="ddlAnio">The DDL año.</param>
        /// <param name="anoInicio">The ano inicio.</param>
        public static void ListaAnios(ref DropDownList ddlAnio, int anoInicio)
        {
            for (int i = anoInicio; i <= DateTime.Now.Year; i++)
            {
                ddlAnio.Items.Add(new ListItem(i.ToString(), i.ToString()));
            }

            ddlAnio.Items.Insert(0, ItemSeleccioneOpcion(string.Empty));
        }

        /// <summary>
        /// Convierte una lista de cualquiertipo a tabla
        /// </summary>
        /// <typeparam name="T">Tipo de dato de la lista</typeparam>
        /// <param name="data">Datos de la lista</param>
        /// <returns>Retorna un datatable con la información de la tabla</returns>
        public static DataTable ConvertirListaTabla<T>(List<T> data)
        {
            PropertyDescriptorCollection properties =
            TypeDescriptor.GetProperties(typeof(T));
            DataTable table = new DataTable();

            foreach (PropertyDescriptor prop in properties)
            {
                table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            }

            foreach (T item in data)
            {
                DataRow row = table.NewRow();

                foreach (PropertyDescriptor prop in properties)
                {
                    row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                }

                table.Rows.Add(row);
            }

            return table;
        }

        /// <summary>
        /// Crears the CSV de lista.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list">The list.</param>
        /// <param name="include">The include.</param>
        /// <param name="exclude">The exclude.</param>
        /// <returns>System.String.</returns>
        public static string CrearCsvDeLista<T>(IList<T> list, string include, string exclude)
        {
            ////Variables for build CSV string
            StringBuilder sb = new StringBuilder();
            List<string> propNames;
            List<string> propValues;
            bool isNameDone = false;

            ////Get property collection and set selected property list
            PropertyInfo[] props = typeof(T).GetProperties();
            List<PropertyInfo> propList = GetSelectedProperties(props, include, exclude);

            ////Add list name and total count
            string typeName = GetSimpleTypeName(list);

            ////Iterate through data list collection
            foreach (var item in list)
            {
                propNames = new List<string>();
                propValues = new List<string>();

                ////Iterate through property collection
                foreach (var prop in propList)
                {
                    ////Construct property name string if not done in sb
                    if (!isNameDone) propNames.Add(prop.Name);

                    ////Construct property value string with double quotes for issue of any comma in string type data
                    var val = prop.PropertyType == typeof(string) ? "\"{0}\"" : "{0}";
                    propValues.Add(string.Format(val, prop.GetValue(item, null)));
                }

                ////Add line for Names
                string line = string.Empty;

                if (!isNameDone)
                {
                    line = string.Join(",", propNames);
                    sb.AppendLine(line);
                    isNameDone = true;
                }

                ////Add line for the values
                line = string.Join(",", propValues);
                sb.Append(line);
                sb.AppendLine("");
            }

            if (!string.IsNullOrEmpty(sb.ToString()))
            {
                return sb.ToString();
            }

            return null;
        }

        /// <summary>
        /// Gets the selected properties.
        /// </summary>
        /// <param name="props">The props.</param>
        /// <param name="include">The include.</param>
        /// <param name="exclude">The exclude.</param>
        /// <returns>List&lt;PropertyInfo&gt;.</returns>
        private static List<PropertyInfo> GetSelectedProperties(PropertyInfo[] props, string include, string exclude)
        {
            List<PropertyInfo> propList = new List<PropertyInfo>();

            if (include != "") //Do include first
            {
                var includeProps = include.ToLower().Split(',').ToList();

                foreach (var item in props)
                {
                    var propName = includeProps.Where(a => a == item.Name.ToLower()).FirstOrDefault();

                    if (!string.IsNullOrEmpty(propName))
                    {
                        propList.Add(item);
                    }
                }
            }
            else if (exclude != "") //Then do exclude
            {
                var excludeProps = exclude.ToLower().Split(',');
                foreach (var item in props)
                {
                    var propName = excludeProps.Where(a => a == item.Name.ToLower()).FirstOrDefault();

                    if (string.IsNullOrEmpty(propName))
                    {
                        propList.Add(item);
                    }
                }
            }
            else //Default
            {
                propList.AddRange(props.ToList());
            }

            return propList;
        }

        /// <summary>
        /// Gets the name of the simple type.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list">The list.</param>
        /// <returns>System.String.</returns>
        private static string GetSimpleTypeName<T>(IList<T> list)
        {
            string typeName = list.GetType().ToString();
            int pos = typeName.IndexOf("[") + 1;
            typeName = typeName.Substring(pos, typeName.LastIndexOf("]") - pos);
            typeName = typeName.Substring(typeName.LastIndexOf(".") + 1);
            return typeName;
        }

        /// <summary>
        /// Determina si es un número
        /// </summary>
        /// <param name="valor">The valor.</param>
        /// <returns><c>true</c> if the specified valor is numeric; otherwise, <c>false</c>.</returns>
        public static bool EsNumerico(object valor)
        {
            bool isNumber;
            double isItNumeric;
            isNumber = Double.TryParse(Convert.ToString(valor), System.Globalization.NumberStyles.Any, System.Globalization.NumberFormatInfo.InvariantInfo, out isItNumeric);
            return isNumber;
        }

        /// <summary>
        /// Gets the item ComboBox.
        /// </summary>
        /// <param name="cmb">The CMB.</param>
        /// <param name="value">The value.</param>
        /// <returns>ListItem.</returns>
        public static ListItem GetItemComboBox(ComboBoxEdit cmb, int value)
        {
            ListItem result = new ListItem();

            foreach (ListItem item in cmb.Properties.Items)
                if (item.Value == value.ToString())
                    result = item;

            return result;
        }

        /// <summary>
        /// Nots the empty rule.
        /// </summary>
        /// <returns>Validation Rule Base.</returns>
        public static ValidationRuleBase ValidationRuleNotEmpty()
        {
            ConditionValidationRule notEmpty = new ConditionValidationRule();
            notEmpty.ConditionOperator = ConditionOperator.IsNotBlank;
            notEmpty.ErrorText = "This value is requered";
            notEmpty.ErrorType = ErrorType.Warning;
            return notEmpty;
        }

        /// <summary>
        /// Values the between.
        /// </summary>
        /// <param name="ValueStart">The value start.</param>
        /// <param name="ValueEnd">The value end.</param>
        /// <returns>Validation Rule Base.</returns>
        public static ValidationRuleBase ValidationRuleBetween(int ValueStart, int ValueEnd)
        {
            ConditionValidationRule range = new ConditionValidationRule();
            range.ConditionOperator = ConditionOperator.Between;
            range.Value1 = ValueStart;
            range.Value2 = ValueEnd;
            range.ErrorText = "This value must be between " + ValueStart.ToString() + " and " + ValueEnd.ToString();
            range.ErrorType = ErrorType.Warning;
            return range;
        }

        /// <summary>
        /// Rules the select combo.
        /// </summary>
        /// <returns>ValidationRuleBase.</returns>
        public static ValidationRuleBase ValidationRuleSelectCombo()
        {
            ConditionValidationRule range = new ConditionValidationRule();
            range.ConditionOperator = ConditionOperator.NotContains;
            range.Value1 = "Seleccione por favor...";
            range.ErrorText = "Please choose a value";
            range.ErrorType = ErrorType.Warning;
            return range;
        }

        /// <summary>
        /// Validations the remove rule.
        /// </summary>
        /// <param name="validator">The validator.</param>
        /// <param name="control">The control.</param>
        public static void ValidationRemoveRule(DXValidationProvider validator, Control control)
        {
            ArrayList al = new ArrayList((ICollection)validator.GetInvalidControls());

            foreach (Control c in al)
                validator.RemoveControlError(control);

            validator.SetValidationRule(control, null);
        }
    }
}
