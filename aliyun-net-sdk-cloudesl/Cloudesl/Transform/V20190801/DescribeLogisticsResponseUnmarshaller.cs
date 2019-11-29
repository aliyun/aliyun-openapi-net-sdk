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
using Aliyun.Acs.cloudesl.Model.V20190801;

namespace Aliyun.Acs.cloudesl.Transform.V20190801
{
    public class DescribeLogisticsResponseUnmarshaller
    {
        public static DescribeLogisticsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeLogisticsResponse describeLogisticsResponse = new DescribeLogisticsResponse();

			describeLogisticsResponse.HttpResponse = context.HttpResponse;
			describeLogisticsResponse.ErrorMessage = context.StringValue("DescribeLogistics.ErrorMessage");
			describeLogisticsResponse.ErrorCode = context.StringValue("DescribeLogistics.ErrorCode");
			describeLogisticsResponse.Message = context.StringValue("DescribeLogistics.Message");
			describeLogisticsResponse.DynamicCode = context.StringValue("DescribeLogistics.DynamicCode");
			describeLogisticsResponse.Code = context.StringValue("DescribeLogistics.Code");
			describeLogisticsResponse.DynamicMessage = context.StringValue("DescribeLogistics.DynamicMessage");
			describeLogisticsResponse.RequestId = context.StringValue("DescribeLogistics.RequestId");
			describeLogisticsResponse.Success = context.BooleanValue("DescribeLogistics.Success");

			List<DescribeLogisticsResponse.DescribeLogistics_LogisticsInfo> describeLogisticsResponse_logistics = new List<DescribeLogisticsResponse.DescribeLogistics_LogisticsInfo>();
			for (int i = 0; i < context.Length("DescribeLogistics.Logistics.Length"); i++) {
				DescribeLogisticsResponse.DescribeLogistics_LogisticsInfo logisticsInfo = new DescribeLogisticsResponse.DescribeLogistics_LogisticsInfo();
				logisticsInfo.OrderId = context.StringValue("DescribeLogistics.Logistics["+ i +"].OrderId");
				logisticsInfo.ApMacList = context.StringValue("DescribeLogistics.Logistics["+ i +"].ApMacList");
				logisticsInfo.PrNumber = context.StringValue("DescribeLogistics.Logistics["+ i +"].PrNumber");
				logisticsInfo.EslMacList = context.StringValue("DescribeLogistics.Logistics["+ i +"].EslMacList");
				logisticsInfo.PoNumber = context.StringValue("DescribeLogistics.Logistics["+ i +"].PoNumber");
				logisticsInfo.AcceptStatus = context.BooleanValue("DescribeLogistics.Logistics["+ i +"].AcceptStatus");
				logisticsInfo.HasSend = context.StringValue("DescribeLogistics.Logistics["+ i +"].HasSend");
				logisticsInfo.LogisticsDocuments = context.StringValue("DescribeLogistics.Logistics["+ i +"].LogisticsDocuments");
				logisticsInfo.Description = context.StringValue("DescribeLogistics.Logistics["+ i +"].Description");

				describeLogisticsResponse_logistics.Add(logisticsInfo);
			}
			describeLogisticsResponse.Logistics = describeLogisticsResponse_logistics;
        
			return describeLogisticsResponse;
        }
    }
}
