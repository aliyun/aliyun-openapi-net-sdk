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
using Aliyun.Acs.OpenSearch.Model.V20171225;

namespace Aliyun.Acs.OpenSearch.Transform.V20171225
{
    public class DescribeAppResponseUnmarshaller
    {
        public static DescribeAppResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeAppResponse describeAppResponse = new DescribeAppResponse();

			describeAppResponse.HttpResponse = _ctx.HttpResponse;
			describeAppResponse.RequestId = _ctx.StringValue("DescribeApp.requestId");

			DescribeAppResponse.DescribeApp_Result result = new DescribeAppResponse.DescribeApp_Result();
			result.Created = _ctx.IntegerValue("DescribeApp.Result.created");
			result.ClusterName = _ctx.StringValue("DescribeApp.Result.clusterName");
			result.AutoSwitch = _ctx.BooleanValue("DescribeApp.Result.autoSwitch");
			result.AlgoDeploymentId = _ctx.IntegerValue("DescribeApp.Result.algoDeploymentId");
			result.Type = _ctx.StringValue("DescribeApp.Result.type");
			result.Description = _ctx.StringValue("DescribeApp.Result.description");
			result.Status = _ctx.StringValue("DescribeApp.Result.status");
			result.Schema = _ctx.StringValue("DescribeApp.Result.schema");
			result.ProgressPercent = _ctx.IntegerValue("DescribeApp.Result.progressPercent");
			result.Id = _ctx.StringValue("DescribeApp.Result.id");

			List<string> result_fetchFields = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeApp.Result.FetchFields.Length"); i++) {
				result_fetchFields.Add(_ctx.StringValue("DescribeApp.Result.FetchFields["+ i +"]"));
			}
			result.FetchFields = result_fetchFields;

			DescribeAppResponse.DescribeApp_Result.DescribeApp_Quota quota = new DescribeAppResponse.DescribeApp_Result.DescribeApp_Quota();
			quota.Spec = _ctx.StringValue("DescribeApp.Result.Quota.spec");
			quota.Qps = _ctx.IntegerValue("DescribeApp.Result.Quota.qps");
			quota.DocSize = _ctx.IntegerValue("DescribeApp.Result.Quota.docSize");
			quota.ComputeResource = _ctx.IntegerValue("DescribeApp.Result.Quota.computeResource");
			result.Quota = quota;

			DescribeAppResponse.DescribeApp_Result.DescribeApp_Domain domain = new DescribeAppResponse.DescribeApp_Result.DescribeApp_Domain();
			domain.Category = _ctx.StringValue("DescribeApp.Result.Domain.category");
			domain.Name = _ctx.StringValue("DescribeApp.Result.Domain.name");

			DescribeAppResponse.DescribeApp_Result.DescribeApp_Domain.DescribeApp_Functions functions = new DescribeAppResponse.DescribeApp_Result.DescribeApp_Domain.DescribeApp_Functions();

			List<string> functions_service = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeApp.Result.Domain.Functions.Service.Length"); i++) {
				functions_service.Add(_ctx.StringValue("DescribeApp.Result.Domain.Functions.Service["+ i +"]"));
			}
			functions.Service = functions_service;

			List<string> functions_qp = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeApp.Result.Domain.Functions.Qp.Length"); i++) {
				functions_qp.Add(_ctx.StringValue("DescribeApp.Result.Domain.Functions.Qp["+ i +"]"));
			}
			functions.Qp = functions_qp;

			List<string> functions_algo = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeApp.Result.Domain.Functions.Algo.Length"); i++) {
				functions_algo.Add(_ctx.StringValue("DescribeApp.Result.Domain.Functions.Algo["+ i +"]"));
			}
			functions.Algo = functions_algo;
			domain.Functions = functions;
			result.Domain = domain;
			describeAppResponse.Result = result;
        
			return describeAppResponse;
        }
    }
}
