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
    public class UpdateDatasetResponseUnmarshaller
    {
        public static UpdateDatasetResponse Unmarshall(UnmarshallerContext _ctx)
        {
			UpdateDatasetResponse updateDatasetResponse = new UpdateDatasetResponse();

			updateDatasetResponse.HttpResponse = _ctx.HttpResponse;
			updateDatasetResponse.Message = _ctx.StringValue("UpdateDataset.Message");
			updateDatasetResponse.RequestId = _ctx.StringValue("UpdateDataset.RequestId");
			updateDatasetResponse.Code = _ctx.StringValue("UpdateDataset.Code");

			UpdateDatasetResponse.UpdateDataset_Data data = new UpdateDatasetResponse.UpdateDataset_Data();
			data.Id = _ctx.LongValue("UpdateDataset.Data.Id");
			data.GmtCreate = _ctx.LongValue("UpdateDataset.Data.GmtCreate");
			data.Name = _ctx.StringValue("UpdateDataset.Data.Name");
			data.Description = _ctx.StringValue("UpdateDataset.Data.Description");
			updateDatasetResponse.Data = data;
        
			return updateDatasetResponse;
        }
    }
}
