﻿using System;
using System.Collections.ObjectModel;
using System.IO;

namespace PhotoViewer
{
    public class ImageInfo
    {
        public string Name { get; }
        public string FullName { get; }
        public ImageInfo(string name, string fullName)
        {
            Name = name;
            FullName = fullName;
        }
    }
    public class ImagesRepository
    {
        public ObservableCollection<ImageInfo> Images { get; } = new();

        public void GetImages(string folder)
        {
            Images.Clear();
            var di = new DirectoryInfo(folder);
            var files = di.GetFiles("*.jpg");

            foreach (FileInfo file in files)
            {
                Images.Add(new ImageInfo(file.Name, file.FullName));
            }
        }
    }
}
