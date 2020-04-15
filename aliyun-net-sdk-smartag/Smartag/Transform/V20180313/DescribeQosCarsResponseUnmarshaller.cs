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
    public class DescribeQosCarsResponseUnmarshaller
    {
        public static DescribeQosCarsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeQosCarsResponse describeQosCarsResponse = new DescribeQosCarsResponse();

			describeQosCarsResponse.HttpResponse = context.HttpResponse;
			describeQosCarsResponse.RequestId = context.StringValue("DescribeQosCars.RequestId");
			describeQosCarsResponse.TotalCount = context.IntegerValue("DescribeQosCars.TotalCount");
			describeQosCarsResponse.PageNumber = context.IntegerValue("DescribeQosCars.PageNumber");
			describeQosCarsResponse.PageSize = context.IntegerValue("DescribeQosCars.PageSize");

			List<DescribeQosCarsResponse.DescribeQosCars_QosCar> describeQosCarsResponse_qosCars = new List<DescribeQosCarsResponse.DescribeQosCars_QosCar>();
			for (int i = 0; i < context.Length("DescribeQosCars.QosCars.Length"); i++) {
				DescribeQosCarsResponse.DescribeQosCars_QosCar qosCar = new DescribeQosCarsResponse.DescribeQosCars_QosCar();
				qosCar.QosCarId = context.StringValue("DescribeQosCars.QosCars["+ i +"].QosCarId");
				qosCar.QosId = context.StringValue("DescribeQosCars.QosCars["+ i +"].QosId");
				qosCar.Description = context.StringValue("DescribeQosCars.QosCars["+ i +"].Description");
				qosCar.Priority = context.IntegerValue("DescribeQosCars.QosCars["+ i +"].Priority");
				qosCar.LimitType = context.StringValue("DescribeQosCars.QosCars["+ i +"].LimitType");
				qosCar.MinBandwidthAbs = context.IntegerValue("DescribeQosCars.QosCars["+ i +"].MinBandwidthAbs");
				qosCar.MaxBandwidthAbs = context.IntegerValue("DescribeQosCars.QosCars["+ i +"].MaxBandwidthAbs");
				qosCar.MinBandwidthPercent = context.IntegerValue("DescribeQosCars.QosCars["+ i +"].MinBandwidthPercent");
				qosCar.MaxBandwidthPercent = context.IntegerValue("DescribeQosCars.QosCars["+ i +"].MaxBandwidthPercent");
				qosCar.PercentSourceType = context.StringValue("DescribeQosCars.QosCars["+ i +"].PercentSourceType");
				qosCar.Name = context.StringValue("DescribeQosCars.QosCars["+ i +"].Name");

				describeQosCarsResponse_qosCars.Add(qosCar);
			}
			describeQosCarsResponse.QosCars = describeQosCarsResponse_qosCars;
        
			return describeQosCarsResponse;
        }
    }
}
