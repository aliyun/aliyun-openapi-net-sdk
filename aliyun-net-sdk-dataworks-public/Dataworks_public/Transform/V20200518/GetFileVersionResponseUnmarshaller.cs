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
using Aliyun.Acs.dataworks_public.Model.V20200518;

namespace Aliyun.Acs.dataworks_public.Transform.V20200518
{
    public class GetFileVersionResponseUnmarshaller
    {
        public static GetFileVersionResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetFileVersionResponse getFileVersionResponse = new GetFileVersionResponse();

			getFileVersionResponse.HttpResponse = _ctx.HttpResponse;
			getFileVersionResponse.RequestId = _ctx.StringValue("GetFileVersion.RequestId");
			getFileVersionResponse.Success = _ctx.BooleanValue("GetFileVersion.Success");
			getFileVersionResponse.ErrorCode = _ctx.StringValue("GetFileVersion.ErrorCode");
			getFileVersionResponse.ErrorMessage = _ctx.StringValue("GetFileVersion.ErrorMessage");
			getFileVersionResponse.HttpStatusCode = _ctx.IntegerValue("GetFileVersion.HttpStatusCode");

			GetFileVersionResponse.GetFileVersion_Data data = new GetFileVersionResponse.GetFileVersion_Data();
			data.FileVersion = _ctx.IntegerValue("GetFileVersion.Data.FileVersion");
			data.FileContent = _ctx.StringValue("GetFileVersion.Data.FileContent");
			data.FilePropertyContent = _ctx.StringValue("GetFileVersion.Data.FilePropertyContent");
			data.NodeContent = _ctx.StringValue("GetFileVersion.Data.NodeContent");
			data.Comment = _ctx.StringValue("GetFileVersion.Data.Comment");
			data.NodeId = _ctx.LongValue("GetFileVersion.Data.NodeId");
			data.IsCurrentProd = _ctx.BooleanValue("GetFileVersion.Data.IsCurrentProd");
			data.ChangeType = _ctx.StringValue("GetFileVersion.Data.ChangeType");
			data.Status = _ctx.StringValue("GetFileVersion.Data.Status");
			data.FileName = _ctx.StringValue("GetFileVersion.Data.FileName");
			data.CommitUser = _ctx.StringValue("GetFileVersion.Data.CommitUser");
			data.CommitTime = _ctx.LongValue("GetFileVersion.Data.CommitTime");
			data.UseType = _ctx.StringValue("GetFileVersion.Data.UseType");
			getFileVersionResponse.Data = data;
        
			return getFileVersionResponse;
        }
    }
}
