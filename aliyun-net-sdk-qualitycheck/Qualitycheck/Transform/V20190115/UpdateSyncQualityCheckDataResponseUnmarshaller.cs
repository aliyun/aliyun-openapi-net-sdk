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
using Aliyun.Acs.Qualitycheck.Model.V20190115;

namespace Aliyun.Acs.Qualitycheck.Transform.V20190115
{
    public class UpdateSyncQualityCheckDataResponseUnmarshaller
    {
        public static UpdateSyncQualityCheckDataResponse Unmarshall(UnmarshallerContext _ctx)
        {
			UpdateSyncQualityCheckDataResponse updateSyncQualityCheckDataResponse = new UpdateSyncQualityCheckDataResponse();

			updateSyncQualityCheckDataResponse.HttpResponse = _ctx.HttpResponse;
			updateSyncQualityCheckDataResponse.RequestId = _ctx.StringValue("UpdateSyncQualityCheckData.RequestId");
			updateSyncQualityCheckDataResponse.Success = _ctx.BooleanValue("UpdateSyncQualityCheckData.Success");
			updateSyncQualityCheckDataResponse.Code = _ctx.StringValue("UpdateSyncQualityCheckData.Code");
			updateSyncQualityCheckDataResponse.Message = _ctx.StringValue("UpdateSyncQualityCheckData.Message");

			UpdateSyncQualityCheckDataResponse.UpdateSyncQualityCheckData_Data data = new UpdateSyncQualityCheckDataResponse.UpdateSyncQualityCheckData_Data();
			data.TaskId = _ctx.StringValue("UpdateSyncQualityCheckData.Data.TaskId");
			data.Tid = _ctx.StringValue("UpdateSyncQualityCheckData.Data.Tid");
			updateSyncQualityCheckDataResponse.Data = data;
        
			return updateSyncQualityCheckDataResponse;
        }
    }
}
