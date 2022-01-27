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
using Aliyun.Acs.sae.Model.V20190506;

namespace Aliyun.Acs.sae.Transform.V20190506
{
    public class DescribeApplicationSlbsResponseUnmarshaller
    {
        public static DescribeApplicationSlbsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeApplicationSlbsResponse describeApplicationSlbsResponse = new DescribeApplicationSlbsResponse();

			describeApplicationSlbsResponse.HttpResponse = _ctx.HttpResponse;
			describeApplicationSlbsResponse.Code = _ctx.StringValue("DescribeApplicationSlbs.Code");
			describeApplicationSlbsResponse.ErrorCode = _ctx.StringValue("DescribeApplicationSlbs.ErrorCode");
			describeApplicationSlbsResponse.Message = _ctx.StringValue("DescribeApplicationSlbs.Message");
			describeApplicationSlbsResponse.Success = _ctx.BooleanValue("DescribeApplicationSlbs.Success");
			describeApplicationSlbsResponse.TraceId = _ctx.StringValue("DescribeApplicationSlbs.TraceId");
			describeApplicationSlbsResponse.RequestId = _ctx.StringValue("DescribeApplicationSlbs.RequestId");

			DescribeApplicationSlbsResponse.DescribeApplicationSlbs_Data data = new DescribeApplicationSlbsResponse.DescribeApplicationSlbs_Data();
			data.InternetIp = _ctx.StringValue("DescribeApplicationSlbs.Data.InternetIp");
			data.IntranetIp = _ctx.StringValue("DescribeApplicationSlbs.Data.IntranetIp");
			data.InternetSlbId = _ctx.StringValue("DescribeApplicationSlbs.Data.InternetSlbId");
			data.IntranetSlbId = _ctx.StringValue("DescribeApplicationSlbs.Data.IntranetSlbId");

			List<DescribeApplicationSlbsResponse.DescribeApplicationSlbs_Data.DescribeApplicationSlbs_InternetItem> data_internet = new List<DescribeApplicationSlbsResponse.DescribeApplicationSlbs_Data.DescribeApplicationSlbs_InternetItem>();
			for (int i = 0; i < _ctx.Length("DescribeApplicationSlbs.Data.Internet.Length"); i++) {
				DescribeApplicationSlbsResponse.DescribeApplicationSlbs_Data.DescribeApplicationSlbs_InternetItem internetItem = new DescribeApplicationSlbsResponse.DescribeApplicationSlbs_Data.DescribeApplicationSlbs_InternetItem();
				internetItem.Port = _ctx.IntegerValue("DescribeApplicationSlbs.Data.Internet["+ i +"].Port");
				internetItem.Protocol = _ctx.StringValue("DescribeApplicationSlbs.Data.Internet["+ i +"].Protocol");
				internetItem.TargetPort = _ctx.IntegerValue("DescribeApplicationSlbs.Data.Internet["+ i +"].TargetPort");
				internetItem.HttpsCertId = _ctx.StringValue("DescribeApplicationSlbs.Data.Internet["+ i +"].HttpsCertId");

				data_internet.Add(internetItem);
			}
			data.Internet = data_internet;

			List<DescribeApplicationSlbsResponse.DescribeApplicationSlbs_Data.DescribeApplicationSlbs_IntranetItem> data_intranet = new List<DescribeApplicationSlbsResponse.DescribeApplicationSlbs_Data.DescribeApplicationSlbs_IntranetItem>();
			for (int i = 0; i < _ctx.Length("DescribeApplicationSlbs.Data.Intranet.Length"); i++) {
				DescribeApplicationSlbsResponse.DescribeApplicationSlbs_Data.DescribeApplicationSlbs_IntranetItem intranetItem = new DescribeApplicationSlbsResponse.DescribeApplicationSlbs_Data.DescribeApplicationSlbs_IntranetItem();
				intranetItem.Port = _ctx.IntegerValue("DescribeApplicationSlbs.Data.Intranet["+ i +"].Port");
				intranetItem.Protocol = _ctx.StringValue("DescribeApplicationSlbs.Data.Intranet["+ i +"].Protocol");
				intranetItem.TargetPort = _ctx.IntegerValue("DescribeApplicationSlbs.Data.Intranet["+ i +"].TargetPort");
				intranetItem.HttpsCertId = _ctx.StringValue("DescribeApplicationSlbs.Data.Intranet["+ i +"].HttpsCertId");

				data_intranet.Add(intranetItem);
			}
			data.Intranet = data_intranet;
			describeApplicationSlbsResponse.Data = data;
        
			return describeApplicationSlbsResponse;
        }
    }
}
