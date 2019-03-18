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
using Aliyun.Acs.afs.Model.V20180112;

namespace Aliyun.Acs.afs.Transform.V20180112
{
    public class DescribeEarlyWarningResponseUnmarshaller
    {
        public static DescribeEarlyWarningResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeEarlyWarningResponse describeEarlyWarningResponse = new DescribeEarlyWarningResponse();

			describeEarlyWarningResponse.HttpResponse = context.HttpResponse;
			describeEarlyWarningResponse.RequestId = context.StringValue("DescribeEarlyWarning.RequestId");
			describeEarlyWarningResponse.HasWarning = context.BooleanValue("DescribeEarlyWarning.HasWarning");
			describeEarlyWarningResponse.BizCode = context.StringValue("DescribeEarlyWarning.BizCode");

			List<DescribeEarlyWarningResponse.DescribeEarlyWarning_EarlyWarning> describeEarlyWarningResponse_earlyWarnings = new List<DescribeEarlyWarningResponse.DescribeEarlyWarning_EarlyWarning>();
			for (int i = 0; i < context.Length("DescribeEarlyWarning.EarlyWarnings.Length"); i++) {
				DescribeEarlyWarningResponse.DescribeEarlyWarning_EarlyWarning earlyWarning = new DescribeEarlyWarningResponse.DescribeEarlyWarning_EarlyWarning();
				earlyWarning.WarnOpen = context.BooleanValue("DescribeEarlyWarning.EarlyWarnings["+ i +"].WarnOpen");
				earlyWarning.Title = context.StringValue("DescribeEarlyWarning.EarlyWarnings["+ i +"].Title");
				earlyWarning.Content = context.StringValue("DescribeEarlyWarning.EarlyWarnings["+ i +"].Content");
				earlyWarning.Frequency = context.StringValue("DescribeEarlyWarning.EarlyWarnings["+ i +"].Frequency");
				earlyWarning.TimeOpen = context.BooleanValue("DescribeEarlyWarning.EarlyWarnings["+ i +"].TimeOpen");
				earlyWarning.TimeBegin = context.StringValue("DescribeEarlyWarning.EarlyWarnings["+ i +"].TimeBegin");
				earlyWarning.TimeEnd = context.StringValue("DescribeEarlyWarning.EarlyWarnings["+ i +"].TimeEnd");
				earlyWarning.Channel = context.StringValue("DescribeEarlyWarning.EarlyWarnings["+ i +"].Channel");

				describeEarlyWarningResponse_earlyWarnings.Add(earlyWarning);
			}
			describeEarlyWarningResponse.EarlyWarnings = describeEarlyWarningResponse_earlyWarnings;
        
			return describeEarlyWarningResponse;
        }
    }
}
