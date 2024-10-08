﻿using MDRService.Application.Common.Models;

namespace MDRService.Application.Common.Messaging
{
    public interface IResponse<T>
    {
        public T? Data { get; set; }
        public int Count { get; set; }
        public bool IsSuccess { get; set; }
        public int StatusCode { get; set; }
        public string? Message { get; set; }
        public Error? Error { get; set; }
        public string? Source { get; set; }
    }
}