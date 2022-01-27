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
    public class DescribeABTestExperimentResponseUnmarshaller
    {
        public static DescribeABTestExperimentResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeABTestExperimentResponse describeABTestExperimentResponse = new DescribeABTestExperimentResponse();

			describeABTestExperimentResponse.HttpResponse = _ctx.HttpResponse;
			describeABTestExperimentResponse.RequestId = _ctx.StringValue("DescribeABTestExperiment.requestId");

			DescribeABTestExperimentResponse.DescribeABTestExperiment_Result result = new DescribeABTestExperimentResponse.DescribeABTestExperiment_Result();
			result.Id = _ctx.StringValue("DescribeABTestExperiment.Result.id");
			result.Name = _ctx.StringValue("DescribeABTestExperiment.Result.name");
			result.Created = _ctx.IntegerValue("DescribeABTestExperiment.Result.created");
			result.Updated = _ctx.IntegerValue("DescribeABTestExperiment.Result.updated");
			result.Online = _ctx.BooleanValue("DescribeABTestExperiment.Result.online");
			result.Traffic = _ctx.IntegerValue("DescribeABTestExperiment.Result.traffic");

			DescribeABTestExperimentResponse.DescribeABTestExperiment_Result.DescribeABTestExperiment__Params _params = new DescribeABTestExperimentResponse.DescribeABTestExperiment_Result.DescribeABTestExperiment__Params();
			_params.First_formula_name = _ctx.StringValue("DescribeABTestExperiment.Result.Params.first_formula_name");
			result._Params = _params;
			describeABTestExperimentResponse.Result = result;
        
			return describeABTestExperimentResponse;
        }
    }
}
