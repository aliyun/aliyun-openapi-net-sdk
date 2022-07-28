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
    public class GetImageInfosResponseUnmarshaller
    {
        public static GetImageInfosResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetImageInfosResponse getImageInfosResponse = new GetImageInfosResponse();

			getImageInfosResponse.HttpResponse = _ctx.HttpResponse;
			getImageInfosResponse.RequestId = _ctx.StringValue("GetImageInfos.RequestId");

			List<string> getImageInfosResponse_nonExistImageIds = new List<string>();
			for (int i = 0; i < _ctx.Length("GetImageInfos.NonExistImageIds.Length"); i++) {
				getImageInfosResponse_nonExistImageIds.Add(_ctx.StringValue("GetImageInfos.NonExistImageIds["+ i +"]"));
			}
			getImageInfosResponse.NonExistImageIds = getImageInfosResponse_nonExistImageIds;

			List<GetImageInfosResponse.GetImageInfos_Image> getImageInfosResponse_imageInfo = new List<GetImageInfosResponse.GetImageInfos_Image>();
			for (int i = 0; i < _ctx.Length("GetImageInfos.ImageInfo.Length"); i++) {
				GetImageInfosResponse.GetImageInfos_Image image = new GetImageInfosResponse.GetImageInfos_Image();
				image.CreationTime = _ctx.StringValue("GetImageInfos.ImageInfo["+ i +"].CreationTime");
				image.StorageLocation = _ctx.StringValue("GetImageInfos.ImageInfo["+ i +"].StorageLocation");
				image.Status = _ctx.StringValue("GetImageInfos.ImageInfo["+ i +"].Status");
				image.CateId = _ctx.LongValue("GetImageInfos.ImageInfo["+ i +"].CateId");
				image.Tags = _ctx.StringValue("GetImageInfos.ImageInfo["+ i +"].Tags");
				image.RegionId = _ctx.StringValue("GetImageInfos.ImageInfo["+ i +"].RegionId");
				image.ImageType = _ctx.StringValue("GetImageInfos.ImageInfo["+ i +"].ImageType");
				image.CateName = _ctx.StringValue("GetImageInfos.ImageInfo["+ i +"].CateName");
				image.Description = _ctx.StringValue("GetImageInfos.ImageInfo["+ i +"].Description");
				image.AppId = _ctx.StringValue("GetImageInfos.ImageInfo["+ i +"].AppId");
				image.URL = _ctx.StringValue("GetImageInfos.ImageInfo["+ i +"].URL");
				image.Title = _ctx.StringValue("GetImageInfos.ImageInfo["+ i +"].Title");
				image.ImageId = _ctx.StringValue("GetImageInfos.ImageInfo["+ i +"].ImageId");
				image.AuditStatus = _ctx.StringValue("GetImageInfos.ImageInfo["+ i +"].AuditStatus");

				GetImageInfosResponse.GetImageInfos_Image.GetImageInfos_Mezzanine mezzanine = new GetImageInfosResponse.GetImageInfos_Image.GetImageInfos_Mezzanine();
				mezzanine.FileURL = _ctx.StringValue("GetImageInfos.ImageInfo["+ i +"].Mezzanine.FileURL");
				mezzanine.OriginalFileName = _ctx.StringValue("GetImageInfos.ImageInfo["+ i +"].Mezzanine.OriginalFileName");
				mezzanine.Width = _ctx.IntegerValue("GetImageInfos.ImageInfo["+ i +"].Mezzanine.Width");
				mezzanine.Height = _ctx.IntegerValue("GetImageInfos.ImageInfo["+ i +"].Mezzanine.Height");
				mezzanine.FileSize = _ctx.StringValue("GetImageInfos.ImageInfo["+ i +"].Mezzanine.FileSize");
				image.Mezzanine = mezzanine;

				getImageInfosResponse_imageInfo.Add(image);
			}
			getImageInfosResponse.ImageInfo = getImageInfosResponse_imageInfo;
        
			return getImageInfosResponse;
        }
    }
}
