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
using Aliyun.Acs.Sas.Model.V20181203;

namespace Aliyun.Acs.Sas.Transform.V20181203
{
    public class CreateFileDetectUploadUrlResponseUnmarshaller
    {
        public static CreateFileDetectUploadUrlResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CreateFileDetectUploadUrlResponse createFileDetectUploadUrlResponse = new CreateFileDetectUploadUrlResponse();

			createFileDetectUploadUrlResponse.HttpResponse = _ctx.HttpResponse;
			createFileDetectUploadUrlResponse.RequestId = _ctx.StringValue("CreateFileDetectUploadUrl.RequestId");

			List<CreateFileDetectUploadUrlResponse.CreateFileDetectUploadUrl_UploadUrList> createFileDetectUploadUrlResponse_uploadUrlList = new List<CreateFileDetectUploadUrlResponse.CreateFileDetectUploadUrl_UploadUrList>();
			for (int i = 0; i < _ctx.Length("CreateFileDetectUploadUrl.UploadUrlList.Length"); i++) {
				CreateFileDetectUploadUrlResponse.CreateFileDetectUploadUrl_UploadUrList uploadUrList = new CreateFileDetectUploadUrlResponse.CreateFileDetectUploadUrl_UploadUrList();
				uploadUrList.PublicUrl = _ctx.StringValue("CreateFileDetectUploadUrl.UploadUrlList["+ i +"].PublicUrl");
				uploadUrList.InternalUrl = _ctx.StringValue("CreateFileDetectUploadUrl.UploadUrlList["+ i +"].InternalUrl");
				uploadUrList.Expire = _ctx.StringValue("CreateFileDetectUploadUrl.UploadUrlList["+ i +"].Expire");
				uploadUrList.FileExist = _ctx.BooleanValue("CreateFileDetectUploadUrl.UploadUrlList["+ i +"].FileExist");
				uploadUrList.HashKey = _ctx.StringValue("CreateFileDetectUploadUrl.UploadUrlList["+ i +"].HashKey");

				CreateFileDetectUploadUrlResponse.CreateFileDetectUploadUrl_UploadUrList.CreateFileDetectUploadUrl_Context context = new CreateFileDetectUploadUrlResponse.CreateFileDetectUploadUrl_UploadUrList.CreateFileDetectUploadUrl_Context();
				context.AccessId = _ctx.StringValue("CreateFileDetectUploadUrl.UploadUrlList["+ i +"].Context.AccessId");
				context.Policy = _ctx.StringValue("CreateFileDetectUploadUrl.UploadUrlList["+ i +"].Context.Policy");
				context.Signature = _ctx.StringValue("CreateFileDetectUploadUrl.UploadUrlList["+ i +"].Context.Signature");
				context.OssKey = _ctx.StringValue("CreateFileDetectUploadUrl.UploadUrlList["+ i +"].Context.OssKey");
				uploadUrList.Context = context;

				createFileDetectUploadUrlResponse_uploadUrlList.Add(uploadUrList);
			}
			createFileDetectUploadUrlResponse.UploadUrlList = createFileDetectUploadUrlResponse_uploadUrlList;
        
			return createFileDetectUploadUrlResponse;
        }
    }
}
