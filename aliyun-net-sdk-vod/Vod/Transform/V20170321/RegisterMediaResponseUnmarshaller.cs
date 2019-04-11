/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using System;
using System.Collections.Generic;

using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.vod.Model.V20170321;

namespace Aliyun.Acs.vod.Transform.V20170321
{
    public class RegisterMediaResponseUnmarshaller
    {
        public static RegisterMediaResponse Unmarshall(UnmarshallerContext context)
        {
			RegisterMediaResponse registerMediaResponse = new RegisterMediaResponse();

			registerMediaResponse.HttpResponse = context.HttpResponse;
			registerMediaResponse.RequestId = context.StringValue("RegisterMedia.RequestId");

			List<string> registerMediaResponse_failedFileURLs = new List<string>();
			for (int i = 0; i < context.Length("RegisterMedia.FailedFileURLs.Length"); i++) {
				registerMediaResponse_failedFileURLs.Add(context.StringValue("RegisterMedia.FailedFileURLs["+ i +"]"));
			}
			registerMediaResponse.FailedFileURLs = registerMediaResponse_failedFileURLs;

			List<RegisterMediaResponse.RegisterMedia_RegisteredMedia> registerMediaResponse_registeredMediaList = new List<RegisterMediaResponse.RegisterMedia_RegisteredMedia>();
			for (int i = 0; i < context.Length("RegisterMedia.RegisteredMediaList.Length"); i++) {
				RegisterMediaResponse.RegisterMedia_RegisteredMedia registeredMedia = new RegisterMediaResponse.RegisterMedia_RegisteredMedia();
				registeredMedia.MediaId = context.StringValue("RegisterMedia.RegisteredMediaList["+ i +"].MediaId");
				registeredMedia.FileURL = context.StringValue("RegisterMedia.RegisteredMediaList["+ i +"].FileURL");
				registeredMedia.NewRegister = context.BooleanValue("RegisterMedia.RegisteredMediaList["+ i +"].NewRegister");

				registerMediaResponse_registeredMediaList.Add(registeredMedia);
			}
			registerMediaResponse.RegisteredMediaList = registerMediaResponse_registeredMediaList;
        
			return registerMediaResponse;
        }
    }
}
