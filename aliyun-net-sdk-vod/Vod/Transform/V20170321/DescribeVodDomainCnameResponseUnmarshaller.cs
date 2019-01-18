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
using Aliyun.Acs.vod.Model.V20170321;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.vod.Transform.V20170321
{
    public class DescribeVodDomainCnameResponseUnmarshaller
    {
        public static DescribeVodDomainCnameResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeVodDomainCnameResponse describeVodDomainCnameResponse = new DescribeVodDomainCnameResponse();

			describeVodDomainCnameResponse.HttpResponse = context.HttpResponse;
			describeVodDomainCnameResponse.RequestId = context.StringValue("DescribeVodDomainCname.RequestId");

			List<DescribeVodDomainCnameResponse.DescribeVodDomainCname_Data> describeVodDomainCnameResponse_cnameDatas = new List<DescribeVodDomainCnameResponse.DescribeVodDomainCname_Data>();
			for (int i = 0; i < context.Length("DescribeVodDomainCname.CnameDatas.Length"); i++) {
				DescribeVodDomainCnameResponse.DescribeVodDomainCname_Data data = new DescribeVodDomainCnameResponse.DescribeVodDomainCname_Data();
				data.Domain = context.StringValue("DescribeVodDomainCname.CnameDatas["+ i +"].Domain");
				data.Cname = context.StringValue("DescribeVodDomainCname.CnameDatas["+ i +"].Cname");
				data.Status = context.IntegerValue("DescribeVodDomainCname.CnameDatas["+ i +"].Status");

				describeVodDomainCnameResponse_cnameDatas.Add(data);
			}
			describeVodDomainCnameResponse.CnameDatas = describeVodDomainCnameResponse_cnameDatas;
        
			return describeVodDomainCnameResponse;
        }
    }
}