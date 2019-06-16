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
using Aliyun.Acs.Airec.Model.V20181012;

namespace Aliyun.Acs.Airec.Transform.V20181012
{
    public class StopDataSetResponseUnmarshaller
    {
        public static StopDataSetResponse Unmarshall(UnmarshallerContext context)
        {
			StopDataSetResponse stopDataSetResponse = new StopDataSetResponse();

			stopDataSetResponse.HttpResponse = context.HttpResponse;
			stopDataSetResponse.RequestId = context.StringValue("StopDataSet.RequestId");
			stopDataSetResponse.Code = context.StringValue("StopDataSet.Code");
			stopDataSetResponse.Message = context.StringValue("StopDataSet.Message");

			StopDataSetResponse.StopDataSet_Result result = new StopDataSetResponse.StopDataSet_Result();
			result.InstanceId = context.StringValue("StopDataSet.Result.InstanceId");
			result.VersionId = context.StringValue("StopDataSet.Result.VersionId");
			result.State = context.StringValue("StopDataSet.Result.State");
			result.GmtCreate = context.LongValue("StopDataSet.Result.GmtCreate");
			result.GmtModified = context.LongValue("StopDataSet.Result.GmtModified");
			stopDataSetResponse.Result = result;
        
			return stopDataSetResponse;
        }
    }
}
