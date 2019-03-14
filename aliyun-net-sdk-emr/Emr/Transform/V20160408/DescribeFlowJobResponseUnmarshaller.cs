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
        public static DescribeFlowJobResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeFlowJobResponse describeFlowJobResponse = new DescribeFlowJobResponse();

			describeFlowJobResponse.HttpResponse = context.HttpResponse;
			describeFlowJobResponse.RequestId = context.StringValue("DescribeFlowJob.RequestId");
			describeFlowJobResponse.Id = context.StringValue("DescribeFlowJob.Id");
			describeFlowJobResponse.GmtCreate = context.LongValue("DescribeFlowJob.GmtCreate");
			describeFlowJobResponse.GmtModified = context.LongValue("DescribeFlowJob.GmtModified");
			describeFlowJobResponse.Name = context.StringValue("DescribeFlowJob.Name");
			describeFlowJobResponse.Type = context.StringValue("DescribeFlowJob.Type");
			describeFlowJobResponse.Description = context.StringValue("DescribeFlowJob.Description");
			describeFlowJobResponse.FailAct = context.StringValue("DescribeFlowJob.FailAct");
			describeFlowJobResponse.MaxRetry = context.IntegerValue("DescribeFlowJob.MaxRetry");
			describeFlowJobResponse.RetryInterval = context.LongValue("DescribeFlowJob.RetryInterval");
			describeFlowJobResponse._Params = context.StringValue("DescribeFlowJob.Params");
			describeFlowJobResponse.ParamConf = context.StringValue("DescribeFlowJob.ParamConf");
			describeFlowJobResponse.CustomVariables = context.StringValue("DescribeFlowJob.CustomVariables");
			describeFlowJobResponse.EnvConf = context.StringValue("DescribeFlowJob.EnvConf");
			describeFlowJobResponse.RunConf = context.StringValue("DescribeFlowJob.RunConf");
			describeFlowJobResponse.MonitorConf = context.StringValue("DescribeFlowJob.MonitorConf");
			describeFlowJobResponse.CategoryId = context.StringValue("DescribeFlowJob.CategoryId");
			describeFlowJobResponse.Mode = context.StringValue("DescribeFlowJob.Mode");
			describeFlowJobResponse.LastInstanceId = context.StringValue("DescribeFlowJob.LastInstanceId");
			describeFlowJobResponse.Adhoc = context.StringValue("DescribeFlowJob.Adhoc");
			describeFlowJobResponse.AlertConf = context.StringValue("DescribeFlowJob.AlertConf");

			List<DescribeFlowJobResponse.DescribeFlowJob_Resource> describeFlowJobResponse_resourceList = new List<DescribeFlowJobResponse.DescribeFlowJob_Resource>();
			for (int i = 0; i < context.Length("DescribeFlowJob.ResourceList.Length"); i++) {
				DescribeFlowJobResponse.DescribeFlowJob_Resource resource = new DescribeFlowJobResponse.DescribeFlowJob_Resource();
				resource.Path = context.StringValue("DescribeFlowJob.ResourceList["+ i +"].Path");
				resource.Alias = context.StringValue("DescribeFlowJob.ResourceList["+ i +"].Alias");

				describeFlowJobResponse_resourceList.Add(resource);
			}
			describeFlowJobResponse.ResourceList = describeFlowJobResponse_resourceList;
        
			return describeFlowJobResponse;
        }
    }
}
