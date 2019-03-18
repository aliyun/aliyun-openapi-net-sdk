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
using Aliyun.Acs.cas.Model.V20180813;

namespace Aliyun.Acs.cas.Transform.V20180813
{
    public class DescribeExpectationResultResponseUnmarshaller
    {
        public static DescribeExpectationResultResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeExpectationResultResponse describeExpectationResultResponse = new DescribeExpectationResultResponse();

			describeExpectationResultResponse.HttpResponse = context.HttpResponse;
			describeExpectationResultResponse.RequestId = context.StringValue("DescribeExpectationResult.RequestId");
			describeExpectationResultResponse.ExpectationType = context.StringValue("DescribeExpectationResult.ExpectationType");
			describeExpectationResultResponse.ErrorMessage = context.StringValue("DescribeExpectationResult.ErrorMessage");
			describeExpectationResultResponse.ProcessStatus = context.StringValue("DescribeExpectationResult.ProcessStatus");
			describeExpectationResultResponse.CheckName = context.StringValue("DescribeExpectationResult.CheckName");
			describeExpectationResultResponse.CheckValue = context.StringValue("DescribeExpectationResult.CheckValue");
			describeExpectationResultResponse.ModifiedTime = context.StringValue("DescribeExpectationResult.ModifiedTime");
			describeExpectationResultResponse.CheckType = context.StringValue("DescribeExpectationResult.CheckType");
			describeExpectationResultResponse.CheckName1 = context.StringValue("DescribeExpectationResult.CheckName1");
			describeExpectationResultResponse.CheckName2 = context.StringValue("DescribeExpectationResult.CheckName2");
        
			return describeExpectationResultResponse;
        }
    }
}
