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
using Aliyun.Acs.adb.Model.V20211201;

namespace Aliyun.Acs.adb.Transform.V20211201
{
    public class CreateOssSubDirectoryResponseUnmarshaller
    {
        public static CreateOssSubDirectoryResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CreateOssSubDirectoryResponse createOssSubDirectoryResponse = new CreateOssSubDirectoryResponse();

			createOssSubDirectoryResponse.HttpResponse = _ctx.HttpResponse;
			createOssSubDirectoryResponse.RequestId = _ctx.StringValue("CreateOssSubDirectory.RequestId");
			createOssSubDirectoryResponse.Message = _ctx.StringValue("CreateOssSubDirectory.Message");
			createOssSubDirectoryResponse.HttpStatusCode = _ctx.LongValue("CreateOssSubDirectory.HttpStatusCode");
			createOssSubDirectoryResponse.Success = _ctx.BooleanValue("CreateOssSubDirectory.Success");

			CreateOssSubDirectoryResponse.CreateOssSubDirectory_Data data = new CreateOssSubDirectoryResponse.CreateOssSubDirectory_Data();
			data.ClientCRC = _ctx.LongValue("CreateOssSubDirectory.Data.ClientCRC");
			data.ETag = _ctx.StringValue("CreateOssSubDirectory.Data.ETag");
			data.RequestId = _ctx.StringValue("CreateOssSubDirectory.Data.RequestId");
			data.ServerCRC = _ctx.LongValue("CreateOssSubDirectory.Data.ServerCRC");
			createOssSubDirectoryResponse.Data = data;
        
			return createOssSubDirectoryResponse;
        }
    }
}
