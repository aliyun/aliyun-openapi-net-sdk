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
using Aliyun.Acs.Airec.Model.V20201126;

namespace Aliyun.Acs.Airec.Transform.V20201126
{
    public class StopDataSetResponseUnmarshaller
    {
        public static StopDataSetResponse Unmarshall(UnmarshallerContext _ctx)
        {
			StopDataSetResponse stopDataSetResponse = new StopDataSetResponse();

			stopDataSetResponse.HttpResponse = _ctx.HttpResponse;
			stopDataSetResponse.Code = _ctx.StringValue("StopDataSet.code");
			stopDataSetResponse.Message = _ctx.StringValue("StopDataSet.message");
			stopDataSetResponse.RequestId = _ctx.StringValue("StopDataSet.requestId");

			StopDataSetResponse.StopDataSet_Result result = new StopDataSetResponse.StopDataSet_Result();
			result.GmtCreate = _ctx.LongValue("StopDataSet.Result.gmtCreate");
			result.GmtModified = _ctx.LongValue("StopDataSet.Result.gmtModified");
			result.InstanceId = _ctx.StringValue("StopDataSet.Result.instanceId");
			result.State = _ctx.StringValue("StopDataSet.Result.state");
			result.VersionId = _ctx.StringValue("StopDataSet.Result.versionId");
			stopDataSetResponse.Result = result;
        
			return stopDataSetResponse;
        }
    }
}
