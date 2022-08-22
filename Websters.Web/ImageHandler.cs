using ImageMagick;
using System;
using System.IO;
using System.Web;

namespace Websters.Web
{
    public class ImageHandler : IHttpHandler
    {
        // TODO: Support for a placeholder image
        //public static string noImageUrl = @"images\no_photo.jpg";

        public void ProcessRequest(HttpContext context)
        {
            string imagePath = context.Server.MapPath(context.Request.FilePath);
            try
            {
                using (Stream file = new FileStream(imagePath, FileMode.Open, FileAccess.Read))
                {
                    // TODO: Check file format header and don't rely on file extension only, which might be worng.
                    using (MagickImageCollection images = new MagickImageCollection(file))
                    {
                        foreach (IMagickImage<ushort> image in images)
                        {
                            SetQuality(context, image);
                            SetDefines(context, image);
                            SetCompression(context, image);
                            SetFormat(context, image);
                            SetSize(context, image);
                            // TODO: Support for rotation
                        }
                        images.Write(context.Response.OutputStream, MagickFormat.WebP);
                        context.Response.ContentType = @"image\webp";
                        //context.Response.End();
                    }
                }
            }
            catch (Exception ex)
            {
                // TODO: Error logging
            }
        }

        private void SetSize(HttpContext context, IMagickImage<ushort> image)
        {
            // TODO: Support for different resize methods overloads like percentage
            if (!String.IsNullOrEmpty(context.Request["w"]) && !String.IsNullOrEmpty(context.Request["h"]))
            {
                int width = Convert.ToInt32(context.Request["w"]);
                int height = Convert.ToInt32(context.Request["h"]);
                image.Resize(width, height);
            }
            else if (!String.IsNullOrEmpty(context.Request["w"]))
            {
                int width = Convert.ToInt32(context.Request["w"]);
                image.Resize(width, 0);
            }
            else if (!String.IsNullOrEmpty(context.Request["h"]))
            {
                int height = Convert.ToInt32(context.Request["h"]);
                image.Resize(0, height);
            }
        }

        private void SetFormat(HttpContext context, IMagickImage<ushort> image)
        {
            // TODO: Support for different file formats
            image.Format = MagickFormat.WebP;
        }

        private void SetCompression(HttpContext context, IMagickImage<ushort> image)
        {
            // TODO: Support for different compression methods
            image.Settings.Compression = CompressionMethod.WebP;
        }

        private void SetDefines(HttpContext context, IMagickImage<ushort> image)
        {
            // TODO
            //image.Settings.SetDefines(new WebPWriteDefines() { Lossless = true, Method = 6 });
        }

        private void SetQuality(HttpContext context, IMagickImage<ushort> image)
        {
            if (!String.IsNullOrEmpty(context.Request["q"]))
            {
                int quality = Convert.ToInt32(context.Request["q"]);
                image.Quality = quality;
            }
            else
            {
                image.Quality = 50;
            }
        }

        public bool IsReusable { get { return true; } }

    }
}
