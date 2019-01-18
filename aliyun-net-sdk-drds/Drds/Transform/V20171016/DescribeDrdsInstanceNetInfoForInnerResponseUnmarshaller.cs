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
using Aliyun.Acs.Drds.Model.V20171016;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Drds.Transform.V20171016
{
    public class DescribeDrdsInstanceNetInfoForInnerResponseUnmarshaller
    {
        public static DescribeDrdsInstanceNetInfoForInnerResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDrdsInstanceNetInfoForInnerResponse describeDrdsInstanceNetInfoForInnerResponse = new DescribeDrdsInstanceNetInfoForInnerResponse();

			describeDrdsInstanceNetInfoForInnerResponse.HttpResponse = context.HttpResponse;
			describeDrdsInstanceNetInfoForInnerResponse.RequestId = context.StringValue("DescribeDrdsInstanceNetInfoForInner.RequestId");
			describeDrdsInstanceNetInfoForInnerResponse.Success = context.BooleanValue("DescribeDrdsInstanceNetInfoForInner.Success");
			describeDrdsInstanceNetInfoForInnerResponse.DrdsInstanceId = context.StringValue("DescribeDrdsInstanceNetInfoForInner.DrdsInstanceId");
			describeDrdsInstanceNetInfoForInnerResponse.NetworkType = context.StringValue("DescribeDrdsInstanceNetInfoForInner.NetworkType");

			List<DescribeDrdsInstanceNetInfoForInnerResponse.DescribeDrdsInstanceNetInfoForInner_NetInfo> describeDrdsInstanceNetInfoForInnerResponse_netInfos = new List<DescribeDrdsInstanceNetInfoForInnerResponse.DescribeDrdsInstanceNetInfoForInner_NetInfo>();
			for (int i = 0; i < context.Length("DescribeDrdsInstanceNetInfoForInner.NetInfos.Length"); i++) {
				DescribeDrdsInstanceNetInfoForInnerResponse.DescribeDrdsInstanceNetInfoForInner_NetInfo netInfo = new DescribeDrdsInstanceNetInfoForInnerResponse.DescribeDrdsInstanceNetInfoForInner_NetInfo();
				netInfo.IP = context.StringValue("DescribeDrdsInstanceNetInfoForInner.NetInfos["+ i +"].IP");
				netInfo.Port = context.StringValue("DescribeDrdsInstanceNetInfoForInner.NetInfos["+ i +"].Port");
				netInfo.Type = context.StringValue("DescribeDrdsInstanceNetInfoForInner.NetInfos["+ i +"].Type");
				netInfo.IsForVpc = context.BooleanValue("DescribeDrdsInstanceNetInfoForInner.NetInfos["+ i +"].IsForVpc");

				describeDrdsInstanceNetInfoForInnerResponse_netInfos.Add(netInfo);
			}
			describeDrdsInstanceNetInfoForInnerResponse.NetInfos = describeDrdsInstanceNetInfoForInnerResponse_netInfos;
        
			return describeDrdsInstanceNetInfoForInnerResponse;
        }
    }
}