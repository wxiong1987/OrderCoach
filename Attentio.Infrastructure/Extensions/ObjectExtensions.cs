using System;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Web;

namespace Attentio.Infrastructure.Extensions
{
    public static class ObjectExtensions
    {
        public static string Save(this HttpPostedFileBase file, string folder)
        {
            var guidFileName = string.Format("{0}{1}", Guid.NewGuid(), Path.GetExtension(file.FileName));
            var filepath = Path.Combine(folder, guidFileName);
            file.SaveAs(filepath);
            return guidFileName;
        }

        public static byte[] ToBinary(this HttpPostedFileBase file)
        {
            using (var reader = new BinaryReader(file.InputStream))
            {
                return reader.ReadBytes(file.ContentLength);
            }
        }

        public static int AttributeMaxLength(this object obj)
        {
            var attribute = obj.GetType()
                .GetCustomAttributes(typeof (MaxLengthAttribute), false).FirstOrDefault()
                as MaxLengthAttribute;
            return attribute != null ? attribute.Length : 0;
        }
    }
}