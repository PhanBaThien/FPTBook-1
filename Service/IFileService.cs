﻿namespace FPTBook_v3.Service
{
    public interface IFileService
    {
        public Tuple<int, string> SaveImage(IFormFile imgFile);
        public bool Delete(string imgFile);
        Tuple<int, string> SaveImage(string user_Img);
    }
}
