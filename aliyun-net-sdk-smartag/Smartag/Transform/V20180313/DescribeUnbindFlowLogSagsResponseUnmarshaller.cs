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
using Aliyun.Acs.Smartag.Model.V20180313;

namespace Aliyun.Acs.Smartag.Transform.V20180313
{
    public class DescribeUnbindFlowLogSagsResponseUnmarshaller
    {
        public static DescribeUnbindFlowLogSagsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeUnbindFlowLogSagsResponse describeUnbindFlowLogSagsResponse = new DescribeUnbindFlowLogSagsResponse();

			describeUnbindFlowLogSagsResponse.HttpResponse = context.HttpResponse;
			describeUnbindFlowLogSagsResponse.RequestId = context.StringValue("DescribeUnbindFlowLogSags.RequestId");
			describeUnbindFlowLogSagsResponse.Count = context.IntegerValue("DescribeUnbindFlowLogSags.Count");

			List<DescribeUnbindFlowLogSagsResponse.DescribeUnbindFlowLogSags_Sag> describeUnbindFlowLogSagsResponse_sags = new List<DescribeUnbindFlowLogSagsResponse.DescribeUnbindFlowLogSags_Sag>();
			for (int i = 0; i < context.Length("DescribeUnbindFlowLogSags.Sags.Length"); i++) {
				DescribeUnbindFlowLogSagsResponse.DescribeUnbindFlowLogSags_Sag sag = new DescribeUnbindFlowLogSagsResponse.DescribeUnbindFlowLogSags_Sag();
				sag.SmartAGId = context.StringValue("DescribeUnbindFlowLogSags.Sags["+ i +"].SmartAGId");
				sag.Description = context.StringValue("DescribeUnbindFlowLogSags.Sags["+ i +"].Description");
				sag.Name = context.StringValue("DescribeUnbindFlowLogSags.Sags["+ i +"].Name");

				describeUnbindFlowLogSagsResponse_sags.Add(sag);
			}
			describeUnbindFlowLogSagsResponse.Sags = describeUnbindFlowLogSagsResponse_sags;
        
			return describeUnbindFlowLogSagsResponse;
        }
    }
}
