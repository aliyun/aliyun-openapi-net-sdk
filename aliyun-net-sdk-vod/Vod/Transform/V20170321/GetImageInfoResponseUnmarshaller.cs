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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.vod.Model.V20170321;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.vod.Transform.V20170321
{
    public class GetImageInfoResponseUnmarshaller
    {
        public static GetImageInfoResponse Unmarshall(UnmarshallerContext context)
        {
			GetImageInfoResponse getImageInfoResponse = new GetImageInfoResponse();

			getImageInfoResponse.HttpResponse = context.HttpResponse;
			getImageInfoResponse.RequestId = context.StringValue("GetImageInfo.RequestId");

			GetImageInfoResponse.GetImageInfo_ImageInfo imageInfo = new GetImageInfoResponse.GetImageInfo_ImageInfo();
			imageInfo.ImageId = context.StringValue("GetImageInfo.ImageInfo.ImageId");
			imageInfo.Title = context.StringValue("GetImageInfo.ImageInfo.Title");
			imageInfo.CreationTime = context.StringValue("GetImageInfo.ImageInfo.CreationTime");
			imageInfo.ImageType = context.StringValue("GetImageInfo.ImageInfo.ImageType");
			imageInfo.Tags = context.StringValue("GetImageInfo.ImageInfo.Tags");
			imageInfo.URL = context.StringValue("GetImageInfo.ImageInfo.URL");

			GetImageInfoResponse.GetImageInfo_ImageInfo.GetImageInfo_Mezzanine mezzanine = new GetImageInfoResponse.GetImageInfo_ImageInfo.GetImageInfo_Mezzanine();
			mezzanine.OriginalFileName = context.StringValue("GetImageInfo.ImageInfo.Mezzanine.OriginalFileName");
			imageInfo.Mezzanine = mezzanine;
			getImageInfoResponse.ImageInfo = imageInfo;
        
			return getImageInfoResponse;
        }
    }
}