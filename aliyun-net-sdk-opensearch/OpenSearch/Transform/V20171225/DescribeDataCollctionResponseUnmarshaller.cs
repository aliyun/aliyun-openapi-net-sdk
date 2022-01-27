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
    public class DescribeDataCollctionResponseUnmarshaller
    {
        public static DescribeDataCollctionResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDataCollctionResponse describeDataCollctionResponse = new DescribeDataCollctionResponse();

			describeDataCollctionResponse.HttpResponse = _ctx.HttpResponse;
			describeDataCollctionResponse.RequestId = _ctx.StringValue("DescribeDataCollction.requestId");

			DescribeDataCollctionResponse.DescribeDataCollction_Result result = new DescribeDataCollctionResponse.DescribeDataCollction_Result();
			result.Id = _ctx.StringValue("DescribeDataCollction.Result.id");
			result.Name = _ctx.StringValue("DescribeDataCollction.Result.name");
			result.Type = _ctx.StringValue("DescribeDataCollction.Result.type");
			result.Status = _ctx.IntegerValue("DescribeDataCollction.Result.status");
			result.DataCollectionType = _ctx.StringValue("DescribeDataCollction.Result.dataCollectionType");
			result.IndustryName = _ctx.StringValue("DescribeDataCollction.Result.industryName");
			result.Created = _ctx.IntegerValue("DescribeDataCollction.Result.created");
			result.Updated = _ctx.IntegerValue("DescribeDataCollction.Result.updated");
			result.SundialId = _ctx.StringValue("DescribeDataCollction.Result.sundialId");
			describeDataCollctionResponse.Result = result;
        
			return describeDataCollctionResponse;
        }
    }
}
