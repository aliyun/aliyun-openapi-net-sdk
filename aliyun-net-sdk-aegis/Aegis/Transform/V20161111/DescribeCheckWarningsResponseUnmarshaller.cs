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
using Aliyun.Acs.aegis.Model.V20161111;

namespace Aliyun.Acs.aegis.Transform.V20161111
{
    public class DescribeCheckWarningsResponseUnmarshaller
    {
        public static DescribeCheckWarningsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeCheckWarningsResponse describeCheckWarningsResponse = new DescribeCheckWarningsResponse();

			describeCheckWarningsResponse.HttpResponse = context.HttpResponse;
			describeCheckWarningsResponse.RequestId = context.StringValue("DescribeCheckWarnings.RequestId");
			describeCheckWarningsResponse.Count = context.IntegerValue("DescribeCheckWarnings.Count");
			describeCheckWarningsResponse.PageSize = context.IntegerValue("DescribeCheckWarnings.PageSize");
			describeCheckWarningsResponse.TotalCount = context.IntegerValue("DescribeCheckWarnings.TotalCount");
			describeCheckWarningsResponse.CurrentPage = context.IntegerValue("DescribeCheckWarnings.CurrentPage");

			List<DescribeCheckWarningsResponse.DescribeCheckWarnings_CheckWarning> describeCheckWarningsResponse_checkWarnings = new List<DescribeCheckWarningsResponse.DescribeCheckWarnings_CheckWarning>();
			for (int i = 0; i < context.Length("DescribeCheckWarnings.CheckWarnings.Length"); i++) {
				DescribeCheckWarningsResponse.DescribeCheckWarnings_CheckWarning checkWarning = new DescribeCheckWarningsResponse.DescribeCheckWarnings_CheckWarning();
				checkWarning.Uuid = context.StringValue("DescribeCheckWarnings.CheckWarnings["+ i +"].Uuid");
				checkWarning.CheckId = context.LongValue("DescribeCheckWarnings.CheckWarnings["+ i +"].CheckId");
				checkWarning.CheckWarningId = context.LongValue("DescribeCheckWarnings.CheckWarnings["+ i +"].CheckWarningId");
				checkWarning.Level = context.StringValue("DescribeCheckWarnings.CheckWarnings["+ i +"].Level");
				checkWarning.Item = context.StringValue("DescribeCheckWarnings.CheckWarnings["+ i +"].Item");
				checkWarning.Type = context.StringValue("DescribeCheckWarnings.CheckWarnings["+ i +"].Type");
				checkWarning.Status = context.IntegerValue("DescribeCheckWarnings.CheckWarnings["+ i +"].Status");

				describeCheckWarningsResponse_checkWarnings.Add(checkWarning);
			}
			describeCheckWarningsResponse.CheckWarnings = describeCheckWarningsResponse_checkWarnings;
        
			return describeCheckWarningsResponse;
        }
    }
}
