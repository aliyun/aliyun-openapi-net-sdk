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
    public class GetMetaTableBasicInfoResponseUnmarshaller
    {
        public static GetMetaTableBasicInfoResponse Unmarshall(UnmarshallerContext context)
        {
			GetMetaTableBasicInfoResponse getMetaTableBasicInfoResponse = new GetMetaTableBasicInfoResponse();

			getMetaTableBasicInfoResponse.HttpResponse = context.HttpResponse;
			getMetaTableBasicInfoResponse.RequestId = context.StringValue("GetMetaTableBasicInfo.RequestId");
			getMetaTableBasicInfoResponse.ErrorCode = context.StringValue("GetMetaTableBasicInfo.ErrorCode");
			getMetaTableBasicInfoResponse.ErrorMessage = context.StringValue("GetMetaTableBasicInfo.ErrorMessage");
			getMetaTableBasicInfoResponse.HttpStatusCode = context.IntegerValue("GetMetaTableBasicInfo.HttpStatusCode");
			getMetaTableBasicInfoResponse.Success = context.BooleanValue("GetMetaTableBasicInfo.Success");

			GetMetaTableBasicInfoResponse.GetMetaTableBasicInfo_Data data = new GetMetaTableBasicInfoResponse.GetMetaTableBasicInfo_Data();
			data.TableName = context.StringValue("GetMetaTableBasicInfo.Data.TableName");
			data.TableGuid = context.StringValue("GetMetaTableBasicInfo.Data.TableGuid");
			data.OwnerId = context.StringValue("GetMetaTableBasicInfo.Data.OwnerId");
			data.TenantId = context.LongValue("GetMetaTableBasicInfo.Data.TenantId");
			data.ProjectId = context.LongValue("GetMetaTableBasicInfo.Data.ProjectId");
			data.CreateTime = context.LongValue("GetMetaTableBasicInfo.Data.CreateTime");
			data.LastModifyTime = context.LongValue("GetMetaTableBasicInfo.Data.LastModifyTime");
			data.LifeCycle = context.IntegerValue("GetMetaTableBasicInfo.Data.LifeCycle");
			data.IsVisible = context.IntegerValue("GetMetaTableBasicInfo.Data.IsVisible");
			data.LastDdlTime = context.LongValue("GetMetaTableBasicInfo.Data.LastDdlTime");
			data.LastAccessTime = context.LongValue("GetMetaTableBasicInfo.Data.LastAccessTime");
			data.EnvType = context.IntegerValue("GetMetaTableBasicInfo.Data.EnvType");
			data.DataSize = context.LongValue("GetMetaTableBasicInfo.Data.DataSize");
			data.Comment = context.StringValue("GetMetaTableBasicInfo.Data.Comment");
			data.ProjectName = context.StringValue("GetMetaTableBasicInfo.Data.ProjectName");
			getMetaTableBasicInfoResponse.Data = data;
        
			return getMetaTableBasicInfoResponse;
        }
    }
}
