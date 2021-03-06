﻿using System.Drawing;

namespace TagsCloudContainer.UserInterface
{
    public interface IResultDisplay
    {
        void ShowResult(Bitmap bitmap);

        void ShowError(string errorMessage);
    }
}