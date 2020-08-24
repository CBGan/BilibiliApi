namespace BilibiliApi.Dynamic.CardEnum
{
    public enum CardType
    {
        /// <summary>
        /// 未知类型
        /// </summary>
        Unknown = 0,
        /// <summary>
        /// 转发
        /// </summary>
        Forward = 1,
        /// <summary>
        /// 纯文本动态
        /// </summary>
        TextAndPic = 2,
        /// <summary>
        /// 图片动态
        /// </summary>
        PlainText = 4,
        /// <summary>
        /// 视频动态
        /// </summary>
        Video = 8,
        /// <summary>
        /// 直播间动态
        /// </summary>
        //Live = 4200
    }
}
