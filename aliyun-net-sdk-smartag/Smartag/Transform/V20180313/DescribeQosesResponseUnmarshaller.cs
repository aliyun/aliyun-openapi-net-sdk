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
    public class DescribeQosesResponseUnmarshaller
    {
        public static DescribeQosesResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeQosesResponse describeQosesResponse = new DescribeQosesResponse();

			describeQosesResponse.HttpResponse = context.HttpResponse;
			describeQosesResponse.RequestId = context.StringValue("DescribeQoses.RequestId");
			describeQosesResponse.TotalCount = context.IntegerValue("DescribeQoses.TotalCount");
			describeQosesResponse.PageNumber = context.IntegerValue("DescribeQoses.PageNumber");
			describeQosesResponse.PageSize = context.IntegerValue("DescribeQoses.PageSize");

			List<DescribeQosesResponse.DescribeQoses_Qos> describeQosesResponse_qoses = new List<DescribeQosesResponse.DescribeQoses_Qos>();
			for (int i = 0; i < context.Length("DescribeQoses.Qoses.Length"); i++) {
				DescribeQosesResponse.DescribeQoses_Qos qos = new DescribeQosesResponse.DescribeQoses_Qos();
				qos.QosId = context.StringValue("DescribeQoses.Qoses["+ i +"].QosId");
				qos.QosName = context.StringValue("DescribeQoses.Qoses["+ i +"].QosName");
				qos.SagCount = context.StringValue("DescribeQoses.Qoses["+ i +"].SagCount");
				qos.SmartAGIds = context.StringValue("DescribeQoses.Qoses["+ i +"].SmartAGIds");
				qos.QosDescription = context.StringValue("DescribeQoses.Qoses["+ i +"].QosDescription");

				describeQosesResponse_qoses.Add(qos);
			}
			describeQosesResponse.Qoses = describeQosesResponse_qoses;
        
			return describeQosesResponse;
        }
    }
}
