namespace StardewModdingAPI.Web.Framework.LogParser
{
    /// <summary>The response for a save-log request.</summary>
    internal class SavePasteResponse
    {
        /// <summary>Whether the log was successfully saved.</summary>
        public bool Success { get; set; }

        /// <summary>The saved paste ID (if <see cref="Success"/> is <c>true</c>).</summary>
        public string ID { get; set; }

        /// <summary>The error message (if saving failed).</summary>
        public string Error { get; set; }
    }
}
