﻿namespace API.Configuration
{
    public class ApiResponse<T>
    {
        public bool Sucess { get; set; }
        public T Data { get; set; }
        public string Message { get; set; }

    }
}
