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
using Aliyun.Acs.Emr.Model.V20160408;

namespace Aliyun.Acs.Emr.Transform.V20160408
{
    public class DescribeFlowJobResponseUnmarshaller
    {
        public static DescribeFlowJobResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeFlowJobResponse describeFlowJobResponse = new DescribeFlowJobResponse();

			describeFlowJobResponse.HttpResponse = _ctx.HttpResponse;
			describeFlowJobResponse.RequestId = _ctx.StringValue("DescribeFlowJob.RequestId");
			describeFlowJobResponse.Id = _ctx.StringValue("DescribeFlowJob.Id");
			describeFlowJobResponse.GmtCreate = _ctx.LongValue("DescribeFlowJob.GmtCreate");
			describeFlowJobResponse.GmtModified = _ctx.LongValue("DescribeFlowJob.GmtModified");
			describeFlowJobResponse.Name = _ctx.StringValue("DescribeFlowJob.Name");
			describeFlowJobResponse.Type = _ctx.StringValue("DescribeFlowJob.Type");
			describeFlowJobResponse.Description = _ctx.StringValue("DescribeFlowJob.Description");
			describeFlowJobResponse.FailAct = _ctx.StringValue("DescribeFlowJob.FailAct");
			describeFlowJobResponse.MaxRetry = _ctx.IntegerValue("DescribeFlowJob.MaxRetry");
			describeFlowJobResponse.RetryInterval = _ctx.LongValue("DescribeFlowJob.RetryInterval");
			describeFlowJobResponse.RetryPolicy = _ctx.StringValue("DescribeFlowJob.RetryPolicy");
			describeFlowJobResponse._Params = _ctx.StringValue("DescribeFlowJob.Params");
			describeFlowJobResponse.ParamConf = _ctx.StringValue("DescribeFlowJob.ParamConf");
			describeFlowJobResponse.CustomVariables = _ctx.StringValue("DescribeFlowJob.CustomVariables");
			describeFlowJobResponse.EnvConf = _ctx.StringValue("DescribeFlowJob.EnvConf");
			describeFlowJobResponse.RunConf = _ctx.StringValue("DescribeFlowJob.RunConf");
			describeFlowJobResponse.MonitorConf = _ctx.StringValue("DescribeFlowJob.MonitorConf");
			describeFlowJobResponse.CategoryId = _ctx.StringValue("DescribeFlowJob.CategoryId");
			describeFlowJobResponse.Mode = _ctx.StringValue("DescribeFlowJob.mode");
			describeFlowJobResponse.LastInstanceId = _ctx.StringValue("DescribeFlowJob.LastInstanceId");
			describeFlowJobResponse.Adhoc = _ctx.StringValue("DescribeFlowJob.Adhoc");
			describeFlowJobResponse.AlertConf = _ctx.StringValue("DescribeFlowJob.AlertConf");
			describeFlowJobResponse.EditLockDetail = _ctx.StringValue("DescribeFlowJob.EditLockDetail");
			describeFlowJobResponse.MaxRunningTimeSec = _ctx.LongValue("DescribeFlowJob.MaxRunningTimeSec");

			List<DescribeFlowJobResponse.DescribeFlowJob_Resource> describeFlowJobResponse_resourceList = new List<DescribeFlowJobResponse.DescribeFlowJob_Resource>();
			for (int i = 0; i < _ctx.Length("DescribeFlowJob.ResourceList.Length"); i++) {
				DescribeFlowJobResponse.DescribeFlowJob_Resource resource = new DescribeFlowJobResponse.DescribeFlowJob_Resource();
				resource.Path = _ctx.StringValue("DescribeFlowJob.ResourceList["+ i +"].Path");
				resource.Alias = _ctx.StringValue("DescribeFlowJob.ResourceList["+ i +"].Alias");

				describeFlowJobResponse_resourceList.Add(resource);
			}
			describeFlowJobResponse.ResourceList = describeFlowJobResponse_resourceList;
        
			return describeFlowJobResponse;
        }
    }
}
