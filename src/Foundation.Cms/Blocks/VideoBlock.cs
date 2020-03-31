using EPiServer.Core;
using EPiServer.DataAnnotations;
using EPiServer.Web;
using System.ComponentModel.DataAnnotations;

namespace Foundation.Cms.Blocks
{
    [ContentType(DisplayName = "Video Block",
        GUID = "03D454F9-3BE8-4421-9A5D-CBBE8E38443D",
        Description = "Video Block",
        GroupName = CmsGroupNames.Content)]
    [ImageUrl("~/assets/icons/cms/blocks/CMS-icon-block-05.png")]
    public class VideoBlock : FoundationBlockData
    {
        [CultureSpecific]
        [UIHint(UIHint.Video)]
        public virtual ContentReference Video { get; set; }
    }
}