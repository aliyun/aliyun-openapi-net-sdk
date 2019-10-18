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
using Aliyun.Acs.DnsKnocker.Model.V20190910;

namespace Aliyun.Acs.DnsKnocker.Transform.V20190910
{
    public class GetResourceRecordsResponseUnmarshaller
    {
        public static GetResourceRecordsResponse Unmarshall(UnmarshallerContext context)
        {
			GetResourceRecordsResponse getResourceRecordsResponse = new GetResourceRecordsResponse();

			getResourceRecordsResponse.HttpResponse = context.HttpResponse;
			getResourceRecordsResponse.ResultCode = context.StringValue("GetResourceRecords.ResultCode");
			getResourceRecordsResponse.ResultMessage = context.StringValue("GetResourceRecords.ResultMessage");
			getResourceRecordsResponse.Success = context.BooleanValue("GetResourceRecords.Success");
			getResourceRecordsResponse.RequestId = context.StringValue("GetResourceRecords.RequestId");

			List<string> getResourceRecordsResponse_resourceRecordSet = new List<string>();
			for (int i = 0; i < context.Length("GetResourceRecords.ResourceRecordSet.Length"); i++) {
				getResourceRecordsResponse_resourceRecordSet.Add(context.StringValue("GetResourceRecords.ResourceRecordSet["+ i +"]"));
			}
			getResourceRecordsResponse.ResourceRecordSet = getResourceRecordsResponse_resourceRecordSet;
        
			return getResourceRecordsResponse;
        }
    }
}
