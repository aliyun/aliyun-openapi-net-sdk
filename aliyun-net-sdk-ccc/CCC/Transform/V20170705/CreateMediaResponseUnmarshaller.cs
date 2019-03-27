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
using Aliyun.Acs.CCC.Model.V20170705;

namespace Aliyun.Acs.CCC.Transform.V20170705
{
    public class CreateMediaResponseUnmarshaller
    {
        public static CreateMediaResponse Unmarshall(UnmarshallerContext context)
        {
			CreateMediaResponse createMediaResponse = new CreateMediaResponse();

			createMediaResponse.HttpResponse = context.HttpResponse;
			createMediaResponse.RequestId = context.StringValue("CreateMedia.RequestId");
			createMediaResponse.Success = context.BooleanValue("CreateMedia.Success");
			createMediaResponse.Code = context.StringValue("CreateMedia.Code");
			createMediaResponse.Message = context.StringValue("CreateMedia.Message");
			createMediaResponse.HttpStatusCode = context.IntegerValue("CreateMedia.HttpStatusCode");

			CreateMediaResponse.CreateMedia_MediaUploadParam mediaUploadParam = new CreateMediaResponse.CreateMedia_MediaUploadParam();
			mediaUploadParam.Id = context.StringValue("CreateMedia.MediaUploadParam.Id");
			mediaUploadParam.Instance = context.StringValue("CreateMedia.MediaUploadParam.Instance");
			mediaUploadParam.Name = context.StringValue("CreateMedia.MediaUploadParam.Name");
			mediaUploadParam.FileName = context.StringValue("CreateMedia.MediaUploadParam.FileName");
			mediaUploadParam.OssFileName = context.StringValue("CreateMedia.MediaUploadParam.OssFileName");
			mediaUploadParam.OssFilePath = context.StringValue("CreateMedia.MediaUploadParam.OssFilePath");
			createMediaResponse.MediaUploadParam = mediaUploadParam;
        
			return createMediaResponse;
        }
    }
}
