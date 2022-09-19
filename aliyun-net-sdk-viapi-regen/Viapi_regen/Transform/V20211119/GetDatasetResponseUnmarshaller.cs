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
using Aliyun.Acs.viapi_regen.Model.V20211119;

namespace Aliyun.Acs.viapi_regen.Transform.V20211119
{
    public class GetDatasetResponseUnmarshaller
    {
        public static GetDatasetResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetDatasetResponse getDatasetResponse = new GetDatasetResponse();

			getDatasetResponse.HttpResponse = _ctx.HttpResponse;
			getDatasetResponse.Message = _ctx.StringValue("GetDataset.Message");
			getDatasetResponse.RequestId = _ctx.StringValue("GetDataset.RequestId");
			getDatasetResponse.Code = _ctx.StringValue("GetDataset.Code");

			GetDatasetResponse.GetDataset_Data data = new GetDatasetResponse.GetDataset_Data();
			data.Id = _ctx.LongValue("GetDataset.Data.Id");
			data.OwnerType = _ctx.StringValue("GetDataset.Data.OwnerType");
			data.OssUrl = _ctx.StringValue("GetDataset.Data.OssUrl");
			data.GmtCreate = _ctx.LongValue("GetDataset.Data.GmtCreate");
			data.Name = _ctx.StringValue("GetDataset.Data.Name");
			data.Description = _ctx.StringValue("GetDataset.Data.Description");
			data.Total = _ctx.LongValue("GetDataset.Data.Total");
			getDatasetResponse.Data = data;
        
			return getDatasetResponse;
        }
    }
}
