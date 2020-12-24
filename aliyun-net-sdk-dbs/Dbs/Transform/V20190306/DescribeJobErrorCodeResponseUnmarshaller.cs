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
using Aliyun.Acs.Dbs.Model.V20190306;

namespace Aliyun.Acs.Dbs.Transform.V20190306
{
    public class DescribeJobErrorCodeResponseUnmarshaller
    {
        public static DescribeJobErrorCodeResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeJobErrorCodeResponse describeJobErrorCodeResponse = new DescribeJobErrorCodeResponse();

			describeJobErrorCodeResponse.HttpResponse = _ctx.HttpResponse;
			describeJobErrorCodeResponse.Success = _ctx.BooleanValue("DescribeJobErrorCode.Success");
			describeJobErrorCodeResponse.ErrCode = _ctx.StringValue("DescribeJobErrorCode.ErrCode");
			describeJobErrorCodeResponse.ErrMessage = _ctx.StringValue("DescribeJobErrorCode.ErrMessage");
			describeJobErrorCodeResponse.HttpStatusCode = _ctx.IntegerValue("DescribeJobErrorCode.HttpStatusCode");
			describeJobErrorCodeResponse.RequestId = _ctx.StringValue("DescribeJobErrorCode.RequestId");

			DescribeJobErrorCodeResponse.DescribeJobErrorCode_Item item = new DescribeJobErrorCodeResponse.DescribeJobErrorCode_Item();
			item.JobId = _ctx.StringValue("DescribeJobErrorCode.Item.JobId");
			item.Language = _ctx.StringValue("DescribeJobErrorCode.Item.Language");
			item.ErrorCode = _ctx.StringValue("DescribeJobErrorCode.Item.ErrorCode");
			item.ErrorMessage = _ctx.StringValue("DescribeJobErrorCode.Item.ErrorMessage");
			item.JobType = _ctx.StringValue("DescribeJobErrorCode.Item.JobType");
			item.JobState = _ctx.StringValue("DescribeJobErrorCode.Item.JobState");
			describeJobErrorCodeResponse.Item = item;
        
			return describeJobErrorCodeResponse;
        }
    }
}
