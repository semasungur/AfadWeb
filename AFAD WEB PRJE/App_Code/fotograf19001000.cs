﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.IO;

/// <summary>
/// Summary description for fotograf
/// </summary>
		public class fotograf19001000
{
    public static void yukle(FileUpload fu, int Ksize)
    {
        System.Drawing.Image orjinalFoto = null;
        HttpPostedFile jpeg_image_upload = fu.PostedFile;
        orjinalFoto = System.Drawing.Image.FromStream(jpeg_image_upload.InputStream);
        KucukBoyut(orjinalFoto, Ksize, fu.FileName);      
    }
    protected static void KucukBoyut(System.Drawing.Image orjinalFoto, int boyut, string dosyaAdi)
    {
        System.Drawing.Bitmap islenmisFotograf = null;
        System.Drawing.Graphics grafik = null;
 
        int hedefGenislik = boyut;
        int hedefYukseklik = boyut;
        int new_width, new_height;
 
        new_height = (int)Math.Round(((float)orjinalFoto.Height * (float)boyut) / (float)orjinalFoto.Width);
        new_width = hedefGenislik;
        hedefYukseklik = new_height;
        new_width = new_width > hedefGenislik ? hedefGenislik : new_width;
        new_height = new_height > hedefYukseklik ? hedefYukseklik : new_height;
 
        islenmisFotograf = new System.Drawing.Bitmap(hedefGenislik, 1000);
        grafik = System.Drawing.Graphics.FromImage(islenmisFotograf);
        grafik.FillRectangle(new System.Drawing.SolidBrush(System.Drawing.Color.White), new System.Drawing.Rectangle(0, 0, hedefGenislik, hedefYukseklik));
        int paste_x = (hedefGenislik - new_width) / 2;
        int paste_y = (hedefYukseklik - new_height) / 2;
 
        grafik.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
        grafik.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
        grafik.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.Default;
 
        System.Drawing.Imaging.ImageCodecInfo codec = System.Drawing.Imaging.ImageCodecInfo.GetImageEncoders()[1];
        System.Drawing.Imaging.EncoderParameters eParams = new System.Drawing.Imaging.EncoderParameters(1);
        eParams.Param[0] = new System.Drawing.Imaging.EncoderParameter(System.Drawing.Imaging.Encoder.Quality, 95L);
 
        grafik.DrawImage(orjinalFoto, paste_x, paste_y, new_width, 1000);
        islenmisFotograf.Save(HttpContext.Current.Server.MapPath("../picture_library/" + Guid.NewGuid().ToString().Substring(0, 20)+dosyaAdi ), codec, eParams);
    }
}
	