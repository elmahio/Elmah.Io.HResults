namespace Elmah.Io.HResults.Facilities
{
    internal class FacilityMediaserverResolver : FacilityResolverBase
    {
        public FacilityMediaserverResolver() : base(13, "FACILITY_MEDIASERVER")
        {
        }

        internal override Code Resolve(bool failure, int code)
        {
            if (failure)
            {
                switch (code)
                {
                    case 3: return new Code(code, "NS_W_SERVER_BANDWIDTH_LIMIT", "The maximum filebitrate value specified is greater than the server's configured maximum bandwidth.");
                    case 4: return new Code(code, "NS_W_FILE_BANDWIDTH_LIMIT", "The maximum bandwidth value specified is less than the maximum filebitrate.");
                    case 96: return new Code(code, "NS_W_UNKNOWN_EVENT", "Unknown %1 event encountered.");
                    case 409: return new Code(code, "NS_I_CATATONIC_FAILURE", "Disk %1 ( %2 ) on Content Server %3, will be failed because it is catatonic.");
                    case 410: return new Code(code, "NS_I_CATATONIC_AUTO_UNFAIL", "Disk %1 ( %2 ) on Content Server %3, auto online from catatonic state.");
                }
            }
            else
            {
                switch (code)
                {
                    case 0: return new Code(code, "NS_S_CALLPENDING", "The requested operation is pending completion.");
                    case 1: return new Code(code, "NS_S_CALLABORTED", "The requested operation was aborted by the client.");
                    case 2: return new Code(code, "NS_S_STREAM_TRUNCATED", "The stream was purposefully stopped before completion.");
                    case 3016: return new Code(code, "NS_S_REBUFFERING", "The requested operation has caused the source to rebuffer.");
                    case 3017: return new Code(code, "NS_S_DEGRADING_QUALITY", "The requested operation has caused the source to degrade codec quality.");
                    case 3035: return new Code(code, "NS_S_TRANSCRYPTOR_EOF", "The transcryptor object has reached end of file.");
                    case 4072: return new Code(code, "NS_S_WMP_UI_VERSIONMISMATCH", "An upgrade is needed for the theme manager to correctly show this skin. Skin reports version: %.1f.");
                    case 4073: return new Code(code, "NS_S_WMP_EXCEPTION", "An error occurred in one of the UI components.");
                    case 4160: return new Code(code, "NS_S_WMP_LOADED_GIF_IMAGE", "Successfully loaded a GIF file.");
                    case 4161: return new Code(code, "NS_S_WMP_LOADED_PNG_IMAGE", "Successfully loaded a PNG file.");
                    case 4162: return new Code(code, "NS_S_WMP_LOADED_BMP_IMAGE", "Successfully loaded a BMP file.");
                    case 4163: return new Code(code, "NS_S_WMP_LOADED_JPG_IMAGE", "Successfully loaded a JPG file.");
                    case 4175: return new Code(code, "NS_S_WMG_FORCE_DROP_FRAME", "Drop this frame.");
                    case 4191: return new Code(code, "NS_S_WMR_ALREADYRENDERED", "The specified stream has already been rendered.");
                    case 4192: return new Code(code, "NS_S_WMR_PINTYPEPARTIALMATCH", "The specified type partially matches this pin type.");
                    case 4193: return new Code(code, "NS_S_WMR_PINTYPEFULLMATCH", "The specified type fully matches this pin type.");
                    case 4198: return new Code(code, "NS_S_WMG_ADVISE_DROP_FRAME", "The timestamp is late compared to the current render position. Advise dropping this frame.");
                    case 4199: return new Code(code, "NS_S_WMG_ADVISE_DROP_TO_KEYFRAME", "The timestamp is severely late compared to the current render position. Advise dropping everything up to the next key frame.");
                    case 4315: return new Code(code, "NS_S_NEED_TO_BUY_BURN_RIGHTS", "No burn rights. You will be prompted to buy burn rights when you try to burn this file to an audio CD.");
                    case 4350: return new Code(code, "NS_S_WMPCORE_PLAYLISTCLEARABORT", "Failed to clear playlist because it was aborted by user.");
                    case 4351: return new Code(code, "NS_S_WMPCORE_PLAYLISTREMOVEITEMABORT", "Failed to remove item in the playlist since it was aborted by user.");
                    case 4354: return new Code(code, "NS_S_WMPCORE_PLAYLIST_CREATION_PENDING", "Playlist is being generated asynchronously.");
                    case 4355: return new Code(code, "NS_S_WMPCORE_MEDIA_VALIDATION_PENDING", "Validation of the media is pending.");
                    case 4356: return new Code(code, "NS_S_WMPCORE_PLAYLIST_REPEAT_SECONDARY_SEGMENTS_IGNORED", "Encountered more than one Repeat block during ASX processing.");
                    case 4357: return new Code(code, "NS_S_WMPCORE_COMMAND_NOT_AVAILABLE", "Current state of WMP disallows calling this method or property.");
                    case 4358: return new Code(code, "NS_S_WMPCORE_PLAYLIST_NAME_AUTO_GENERATED", "Name for the playlist has been auto generated.");
                    case 4359: return new Code(code, "NS_S_WMPCORE_PLAYLIST_IMPORT_MISSING_ITEMS", "The imported playlist does not contain all items from the original.");
                    case 4360: return new Code(code, "NS_S_WMPCORE_PLAYLIST_COLLAPSED_TO_SINGLE_MEDIA", "The M3U playlist has been ignored because it only contains one item.");
                    case 4361: return new Code(code, "NS_S_WMPCORE_MEDIA_CHILD_PLAYLIST_OPEN_PENDING", "The open for the child playlist associated with this media is pending.");
                    case 4362: return new Code(code, "NS_S_WMPCORE_MORE_NODES_AVAIABLE", "More nodes support the interface requested, but the array for returning them is full.");
                    case 4405: return new Code(code, "NS_S_WMPBR_SUCCESS", "Backup or Restore successful!.");
                    case 4406: return new Code(code, "NS_S_WMPBR_PARTIALSUCCESS", "Transfer complete with limitations.");
                    case 4420: return new Code(code, "NS_S_WMPEFFECT_TRANSPARENT", "Request to the effects control to change transparency status to transparent.");
                    case 4421: return new Code(code, "NS_S_WMPEFFECT_OPAQUE", "Request to the effects control to change transparency status to opaque.");
                    case 4430: return new Code(code, "NS_S_OPERATION_PENDING", "The requested application pane is performing an operation and will not be released.");
                    case 4953: return new Code(code, "NS_S_TRACK_BUY_REQUIRES_ALBUM_PURCHASE", "The file is only available for purchase when you buy the entire album.");
                    case 4958: return new Code(code, "NS_S_NAVIGATION_COMPLETE_WITH_ERRORS", "There were problems completing the requested navigation. There are identifiers missing in the catalog.");
                    case 4961: return new Code(code, "NS_S_TRACK_ALREADY_DOWNLOADED", "Track already downloaded.");
                    case 5401: return new Code(code, "NS_S_PUBLISHING_POINT_STARTED_WITH_FAILED_SINKS", "The publishing point successfully started, but one or more of the requested data writer plug-ins failed.");
                    case 10022: return new Code(code, "NS_S_DRM_LICENSE_ACQUIRED", "Status message: The license was acquired.");
                    case 10023: return new Code(code, "NS_S_DRM_INDIVIDUALIZED", "Status message: The security upgrade has been completed.");
                    case 10054: return new Code(code, "NS_S_DRM_MONITOR_CANCELLED", "Status message: License monitoring has been canceled.");
                    case 10055: return new Code(code, "NS_S_DRM_ACQUIRE_CANCELLED", "Status message: License acquisition has been canceled.");
                    case 10094: return new Code(code, "NS_S_DRM_BURNABLE_TRACK", "The track is burnable and had no playlist burn limit.");
                    case 10095: return new Code(code, "NS_S_DRM_BURNABLE_TRACK_WITH_PLAYLIST_RESTRICTION", "The track is burnable but has a playlist burn limit.");
                    case 10206: return new Code(code, "NS_S_DRM_NEEDS_INDIVIDUALIZATION", "A security upgrade is required to perform the operation on this media file.");
                    case 11000: return new Code(code, "NS_S_REBOOT_RECOMMENDED", "Installation was successful; however, some file cleanup is not complete. For best results, restart your computer.");
                    case 11001: return new Code(code, "NS_S_REBOOT_REQUIRED", "Installation was successful; however, some file cleanup is not complete. To continue, you must restart your computer.");
                    case 12041: return new Code(code, "NS_S_EOSRECEDING", "EOS hit during rewinding.");
                    case 12045: return new Code(code, "NS_S_CHANGENOTICE", "Internal.");
                }
            }

            return Unknown(code);
        }
    }
}
