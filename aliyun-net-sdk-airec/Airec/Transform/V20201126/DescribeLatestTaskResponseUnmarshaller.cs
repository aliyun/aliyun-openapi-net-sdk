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
    public class DescribeLatestTaskResponseUnmarshaller
    {
        public static DescribeLatestTaskResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeLatestTaskResponse describeLatestTaskResponse = new DescribeLatestTaskResponse();

			describeLatestTaskResponse.HttpResponse = _ctx.HttpResponse;
			describeLatestTaskResponse.RequestId = _ctx.StringValue("DescribeLatestTask.requestId");

			List<DescribeLatestTaskResponse.DescribeLatestTask_IndexVersion> describeLatestTaskResponse_result = new List<DescribeLatestTaskResponse.DescribeLatestTask_IndexVersion>();
			for (int i = 0; i < _ctx.Length("DescribeLatestTask.Result.Length"); i++) {
				DescribeLatestTaskResponse.DescribeLatestTask_IndexVersion indexVersion = new DescribeLatestTaskResponse.DescribeLatestTask_IndexVersion();
				indexVersion.VersionId = _ctx.StringValue("DescribeLatestTask.Result["+ i +"].versionId");
				indexVersion.Status = _ctx.StringValue("DescribeLatestTask.Result["+ i +"].status");
				indexVersion.BuiltTime = _ctx.StringValue("DescribeLatestTask.Result["+ i +"].builtTime");
				indexVersion.SwitchedTime = _ctx.StringValue("DescribeLatestTask.Result["+ i +"].switchedTime");
				indexVersion.RollbackEnabled = _ctx.BooleanValue("DescribeLatestTask.Result["+ i +"].rollbackEnabled");
				indexVersion.CostSeconds = _ctx.IntegerValue("DescribeLatestTask.Result["+ i +"].costSeconds");
				indexVersion.Size = _ctx.LongValue("DescribeLatestTask.Result["+ i +"].size");
				indexVersion.Progress = _ctx.IntegerValue("DescribeLatestTask.Result["+ i +"].progress");
				indexVersion.FlowType = _ctx.StringValue("DescribeLatestTask.Result["+ i +"].flowType");
				indexVersion.Code = _ctx.StringValue("DescribeLatestTask.Result["+ i +"].code");
				indexVersion.Message = _ctx.StringValue("DescribeLatestTask.Result["+ i +"].message");

				describeLatestTaskResponse_result.Add(indexVersion);
			}
			describeLatestTaskResponse.Result = describeLatestTaskResponse_result;
        
			return describeLatestTaskResponse;
        }
    }
}
