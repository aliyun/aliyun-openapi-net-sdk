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
using Aliyun.Acs.Sas.Model.V20181203;

namespace Aliyun.Acs.Sas.Transform.V20181203
{
    public class DescribeAccesskeyLeakListResponseUnmarshaller
    {
        public static DescribeAccesskeyLeakListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeAccesskeyLeakListResponse describeAccesskeyLeakListResponse = new DescribeAccesskeyLeakListResponse();

			describeAccesskeyLeakListResponse.HttpResponse = _ctx.HttpResponse;
			describeAccesskeyLeakListResponse.RequestId = _ctx.StringValue("DescribeAccesskeyLeakList.RequestId");
			describeAccesskeyLeakListResponse.GmtLast = _ctx.LongValue("DescribeAccesskeyLeakList.GmtLast");
			describeAccesskeyLeakListResponse.AkLeakCount = _ctx.IntegerValue("DescribeAccesskeyLeakList.AkLeakCount");
			describeAccesskeyLeakListResponse.PageSize = _ctx.IntegerValue("DescribeAccesskeyLeakList.PageSize");
			describeAccesskeyLeakListResponse.CurrentPage = _ctx.IntegerValue("DescribeAccesskeyLeakList.CurrentPage");
			describeAccesskeyLeakListResponse.TotalCount = _ctx.IntegerValue("DescribeAccesskeyLeakList.TotalCount");

			List<DescribeAccesskeyLeakListResponse.DescribeAccesskeyLeakList_AccessKeyLeak> describeAccesskeyLeakListResponse_accessKeyLeakList = new List<DescribeAccesskeyLeakListResponse.DescribeAccesskeyLeakList_AccessKeyLeak>();
			for (int i = 0; i < _ctx.Length("DescribeAccesskeyLeakList.AccessKeyLeakList.Length"); i++) {
				DescribeAccesskeyLeakListResponse.DescribeAccesskeyLeakList_AccessKeyLeak accessKeyLeak = new DescribeAccesskeyLeakListResponse.DescribeAccesskeyLeakList_AccessKeyLeak();
				accessKeyLeak.Id = _ctx.LongValue("DescribeAccesskeyLeakList.AccessKeyLeakList["+ i +"].Id");
				accessKeyLeak.GmtModified = _ctx.LongValue("DescribeAccesskeyLeakList.AccessKeyLeakList["+ i +"].GmtModified");
				accessKeyLeak.Asset = _ctx.StringValue("DescribeAccesskeyLeakList.AccessKeyLeakList["+ i +"].Asset");
				accessKeyLeak.Type = _ctx.StringValue("DescribeAccesskeyLeakList.AccessKeyLeakList["+ i +"].Type");
				accessKeyLeak.AccesskeyId = _ctx.StringValue("DescribeAccesskeyLeakList.AccessKeyLeakList["+ i +"].AccesskeyId");
				accessKeyLeak.Status = _ctx.StringValue("DescribeAccesskeyLeakList.AccessKeyLeakList["+ i +"].Status");
				accessKeyLeak.AliUserName = _ctx.StringValue("DescribeAccesskeyLeakList.AccessKeyLeakList["+ i +"].AliUserName");
				accessKeyLeak.DealType = _ctx.StringValue("DescribeAccesskeyLeakList.AccessKeyLeakList["+ i +"].DealType");
				accessKeyLeak.DealTime = _ctx.StringValue("DescribeAccesskeyLeakList.AccessKeyLeakList["+ i +"].DealTime");
				accessKeyLeak.UserType = _ctx.StringValue("DescribeAccesskeyLeakList.AccessKeyLeakList["+ i +"].UserType");
				accessKeyLeak.Url = _ctx.StringValue("DescribeAccesskeyLeakList.AccessKeyLeakList["+ i +"].Url");

				describeAccesskeyLeakListResponse_accessKeyLeakList.Add(accessKeyLeak);
			}
			describeAccesskeyLeakListResponse.AccessKeyLeakList = describeAccesskeyLeakListResponse_accessKeyLeakList;
        
			return describeAccesskeyLeakListResponse;
        }
    }
}
