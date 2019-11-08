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
        public static DescribeJobErrorCodeResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeJobErrorCodeResponse describeJobErrorCodeResponse = new DescribeJobErrorCodeResponse();

			describeJobErrorCodeResponse.HttpResponse = context.HttpResponse;
			describeJobErrorCodeResponse.Success = context.BooleanValue("DescribeJobErrorCode.Success");
			describeJobErrorCodeResponse.ErrCode = context.StringValue("DescribeJobErrorCode.ErrCode");
			describeJobErrorCodeResponse.ErrMessage = context.StringValue("DescribeJobErrorCode.ErrMessage");
			describeJobErrorCodeResponse.HttpStatusCode = context.IntegerValue("DescribeJobErrorCode.HttpStatusCode");
			describeJobErrorCodeResponse.RequestId = context.StringValue("DescribeJobErrorCode.RequestId");

			DescribeJobErrorCodeResponse.DescribeJobErrorCode_Item item = new DescribeJobErrorCodeResponse.DescribeJobErrorCode_Item();
			item.JobId = context.StringValue("DescribeJobErrorCode.Item.JobId");
			item.Language = context.StringValue("DescribeJobErrorCode.Item.Language");
			item.ErrorCode = context.StringValue("DescribeJobErrorCode.Item.ErrorCode");
			item.ErrorMessage = context.StringValue("DescribeJobErrorCode.Item.ErrorMessage");
			item.JobType = context.StringValue("DescribeJobErrorCode.Item.JobType");
			item.JobState = context.StringValue("DescribeJobErrorCode.Item.JobState");
			describeJobErrorCodeResponse.Item = item;
        
			return describeJobErrorCodeResponse;
        }
    }
}
