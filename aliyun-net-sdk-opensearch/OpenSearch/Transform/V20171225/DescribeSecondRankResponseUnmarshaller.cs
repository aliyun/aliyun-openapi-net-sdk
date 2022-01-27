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
    public class DescribeSecondRankResponseUnmarshaller
    {
        public static DescribeSecondRankResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeSecondRankResponse describeSecondRankResponse = new DescribeSecondRankResponse();

			describeSecondRankResponse.HttpResponse = _ctx.HttpResponse;
			describeSecondRankResponse.RequestId = _ctx.StringValue("DescribeSecondRank.requestId");

			DescribeSecondRankResponse.DescribeSecondRank_Result result = new DescribeSecondRankResponse.DescribeSecondRank_Result();
			result.Id = _ctx.StringValue("DescribeSecondRank.Result.id");
			result.Name = _ctx.StringValue("DescribeSecondRank.Result.name");
			result.Meta = _ctx.StringValue("DescribeSecondRank.Result.meta");
			result.Active = _ctx.BooleanValue("DescribeSecondRank.Result.active");
			result.Description = _ctx.StringValue("DescribeSecondRank.Result.description");
			result.Created = _ctx.IntegerValue("DescribeSecondRank.Result.created");
			result.Updated = _ctx.IntegerValue("DescribeSecondRank.Result.updated");
			result.IsDefault = _ctx.StringValue("DescribeSecondRank.Result.isDefault");
			result.IsSys = _ctx.StringValue("DescribeSecondRank.Result.isSys");
			describeSecondRankResponse.Result = result;
        
			return describeSecondRankResponse;
        }
    }
}
