﻿using Core.Maybe;

namespace ControllerImplementations.Controllers.CommandHandlerBasedApi
{
    public class AddPostCommand
    {
        public PostDto Post { get; set; }
        public PostCreatedDto ResponseCreatedPost { get; set; }
        public Maybe<ErrorInfo> Error { get; set; }
    }
}