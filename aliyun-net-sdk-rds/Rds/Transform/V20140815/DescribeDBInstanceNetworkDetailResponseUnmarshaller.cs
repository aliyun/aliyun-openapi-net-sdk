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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Rds.Model.V20140815;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Rds.Transform.V20140815
{
    public class DescribeDBInstanceNetworkDetailResponseUnmarshaller
    {
        public static DescribeDBInstanceNetworkDetailResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDBInstanceNetworkDetailResponse describeDBInstanceNetworkDetailResponse = new DescribeDBInstanceNetworkDetailResponse();

			describeDBInstanceNetworkDetailResponse.HttpResponse = context.HttpResponse;
			describeDBInstanceNetworkDetailResponse.RequestId = context.StringValue("DescribeDBInstanceNetworkDetail.RequestId");
			describeDBInstanceNetworkDetailResponse.DBInstanceId = context.StringValue("DescribeDBInstanceNetworkDetail.DBInstanceId");
			describeDBInstanceNetworkDetailResponse.StartTime = context.StringValue("DescribeDBInstanceNetworkDetail.StartTime");
			describeDBInstanceNetworkDetailResponse.EndTime = context.StringValue("DescribeDBInstanceNetworkDetail.EndTime");
			describeDBInstanceNetworkDetailResponse.NewConnection = context.StringValue("DescribeDBInstanceNetworkDetail.NewConnection");
			describeDBInstanceNetworkDetailResponse.ActiveConnection = context.StringValue("DescribeDBInstanceNetworkDetail.ActiveConnection");
			describeDBInstanceNetworkDetailResponse.AbortedConnection = context.StringValue("DescribeDBInstanceNetworkDetail.AbortedConnection");
			describeDBInstanceNetworkDetailResponse.NetworkRequest = context.StringValue("DescribeDBInstanceNetworkDetail.NetworkRequest");
			describeDBInstanceNetworkDetailResponse.NetworkTrafficIn = context.StringValue("DescribeDBInstanceNetworkDetail.NetworkTrafficIn");
			describeDBInstanceNetworkDetailResponse.NetworkTrafficOut = context.StringValue("DescribeDBInstanceNetworkDetail.NetworkTrafficOut");
			describeDBInstanceNetworkDetailResponse.NetworkLatency = context.StringValue("DescribeDBInstanceNetworkDetail.NetworkLatency");
			describeDBInstanceNetworkDetailResponse.BackendLatency = context.StringValue("DescribeDBInstanceNetworkDetail.BackendLatency");
			describeDBInstanceNetworkDetailResponse.NetworkErrors = context.StringValue("DescribeDBInstanceNetworkDetail.NetworkErrors");

			List<DescribeDBInstanceNetworkDetailResponse.DescribeDBInstanceNetworkDetail_NetworkKey> describeDBInstanceNetworkDetailResponse_networkDetail = new List<DescribeDBInstanceNetworkDetailResponse.DescribeDBInstanceNetworkDetail_NetworkKey>();
			for (int i = 0; i < context.Length("DescribeDBInstanceNetworkDetail.NetworkDetail.Length"); i++) {
				DescribeDBInstanceNetworkDetailResponse.DescribeDBInstanceNetworkDetail_NetworkKey networkKey = new DescribeDBInstanceNetworkDetailResponse.DescribeDBInstanceNetworkDetail_NetworkKey();
				networkKey.Key = context.StringValue("DescribeDBInstanceNetworkDetail.NetworkDetail["+ i +"].Key");
				networkKey.Unit = context.StringValue("DescribeDBInstanceNetworkDetail.NetworkDetail["+ i +"].Unit");

				List<DescribeDBInstanceNetworkDetailResponse.DescribeDBInstanceNetworkDetail_NetworkKey.DescribeDBInstanceNetworkDetail_NetworkValue> networkKey_values = new List<DescribeDBInstanceNetworkDetailResponse.DescribeDBInstanceNetworkDetail_NetworkKey.DescribeDBInstanceNetworkDetail_NetworkValue>();
				for (int j = 0; j < context.Length("DescribeDBInstanceNetworkDetail.NetworkDetail["+ i +"].Values.Length"); j++) {
					DescribeDBInstanceNetworkDetailResponse.DescribeDBInstanceNetworkDetail_NetworkKey.DescribeDBInstanceNetworkDetail_NetworkValue networkValue = new DescribeDBInstanceNetworkDetailResponse.DescribeDBInstanceNetworkDetail_NetworkKey.DescribeDBInstanceNetworkDetail_NetworkValue();
					networkValue._Value = context.StringValue("DescribeDBInstanceNetworkDetail.NetworkDetail["+ i +"].Values["+ j +"].Value");
					networkValue.DateTime = context.StringValue("DescribeDBInstanceNetworkDetail.NetworkDetail["+ i +"].Values["+ j +"].DateTime");

					networkKey_values.Add(networkValue);
				}
				networkKey.Values = networkKey_values;

				describeDBInstanceNetworkDetailResponse_networkDetail.Add(networkKey);
			}
			describeDBInstanceNetworkDetailResponse.NetworkDetail = describeDBInstanceNetworkDetailResponse_networkDetail;
        
			return describeDBInstanceNetworkDetailResponse;
        }
    }
}