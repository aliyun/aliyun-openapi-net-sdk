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
using Aliyun.Acs.Cdn.Model.V20141111;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Cdn.Transform.V20141111
{
    public class DescribeDomainQoSRtResponseUnmarshaller
    {
        public static DescribeDomainQoSRtResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDomainQoSRtResponse describeDomainQoSRtResponse = new DescribeDomainQoSRtResponse();

			describeDomainQoSRtResponse.HttpResponse = context.HttpResponse;
			describeDomainQoSRtResponse.DomainName = context.StringValue("DescribeDomainQoSRt.DomainName");
			describeDomainQoSRtResponse.StartTime = context.StringValue("DescribeDomainQoSRt.StartTime");
			describeDomainQoSRtResponse.EndTime = context.StringValue("DescribeDomainQoSRt.EndTime");
			describeDomainQoSRtResponse.Ip = context.StringValue("DescribeDomainQoSRt.Ip");

			List<DescribeDomainQoSRtResponse.DescribeDomainQoSRt_Data> describeDomainQoSRtResponse_content = new List<DescribeDomainQoSRtResponse.DescribeDomainQoSRt_Data>();
			for (int i = 0; i < context.Length("DescribeDomainQoSRt.Content.Length"); i++) {
				DescribeDomainQoSRtResponse.DescribeDomainQoSRt_Data data = new DescribeDomainQoSRtResponse.DescribeDomainQoSRt_Data();
				data.More5s = context.StringValue("DescribeDomainQoSRt.Content["+ i +"].More5s");
				data.Time = context.StringValue("DescribeDomainQoSRt.Content["+ i +"].Time");
				data.More3s = context.StringValue("DescribeDomainQoSRt.Content["+ i +"].More3s");

				describeDomainQoSRtResponse_content.Add(data);
			}
			describeDomainQoSRtResponse.Content = describeDomainQoSRtResponse_content;
        
			return describeDomainQoSRtResponse;
        }
    }
}